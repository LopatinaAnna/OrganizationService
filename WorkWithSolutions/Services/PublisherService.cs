using System;
using CrmEarlyBound;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using static System.Configuration.ConfigurationManager;

namespace WorkWithSolutions.Services
{
    class PublisherService
    {
        readonly string connection = ConnectionStrings["DefaultConnection"].ConnectionString;

        public Publisher RetrieveTheDefaultPublisher()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                Guid defaultPublisherId = new Guid("{d21aab71-79e7-11dd-8874-00188b01e34f}");
                return (Publisher)svc.Retrieve("publisher", defaultPublisherId, new ColumnSet("friendlyname"));
            }
        }

        public Publisher RetrievePublisher(string uniqueName)
        {
            using (var svc = new CrmServiceClient(connection))
            {
                QueryExpression query = new QueryExpression
                {
                    EntityName = Publisher.EntityLogicalName,
                    ColumnSet = new ColumnSet("publisherid"),
                    Criteria = new FilterExpression()
                };

                query.Criteria.AddCondition("uniquename", ConditionOperator.Equal, uniqueName);
                EntityCollection retrievePuslishers = svc.RetrieveMultiple(query);
                Publisher publisher = null;

                if (retrievePuslishers.Entities.Count > 0)
                {
                    publisher = (Publisher)retrievePuslishers.Entities[0];
                }

                return publisher;
            }
        }

        public void CreatePublisher()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                Publisher _crmSdkPublisher = new Publisher
                {
                    UniqueName = "sdksamples",
                    FriendlyName = "Microsoft CRM SDK Samples",
                    SupportingWebsiteUrl = "https://msdn.microsoft.com/dynamics/crm/default.aspx",
                    CustomizationPrefix = "sample",
                    EMailAddress = "someone@microsoft.com",
                    Description = "This publisher was created with samples from the Microsoft Dynamics CRM SDK"
                };

                Publisher publisher = RetrievePublisher("sdksamples");

                if (publisher != null)
                {
                    Console.WriteLine(string.Format("Publisher already exist: {0}.", _crmSdkPublisher.FriendlyName));
                }
                else
                {
                    svc.Create(_crmSdkPublisher);
                    Console.WriteLine(string.Format("Created publisher: {0}.", _crmSdkPublisher.FriendlyName));
                }
            }
        }
    }
}
