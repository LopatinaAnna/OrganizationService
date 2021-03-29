using System;
using System.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using static System.Configuration.ConfigurationManager;

namespace OrganizationService
{
    class Program
    {
        static readonly string connection = ConnectionStrings["DefaultConnection"].ConnectionString;

        static void Main(string[] args)
        {
            CreateEntity();
            GetUserId();
            GetEntityDataByFetch();
            GetEntityDataByQuery();
            Console.ReadLine();
        }

        static void GetEntityDataByFetch()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                var fetchXml = $@"
                <fetch top='50'>
                  <entity name='new_orderplan'>
                    <attribute name='new_name' />
                    <attribute name='new_orderplanid' />
                    <order attribute='new_name' descending='true' />
                  </entity>
                </fetch>";

                var orderPlans = svc.GetEntityDataByFetchSearch(fetchXml);

                foreach (var item in orderPlans)
                {
                    Console.WriteLine(item.Value["new_name"]);
                }
            }
        }

        static void GetEntityDataByQuery()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                var query = new QueryExpression("new_orderplan")
                {
                    ColumnSet = new ColumnSet("new_orderplanid", "new_name"),
                    NoLock = true, 
                    Distinct = true
                };
                
                query.AddOrder("new_name", OrderType.Ascending);

                var entityCollection = svc.RetrieveMultiple(query);

                var list = entityCollection.Entities.ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(item.GetAttributeValue<string>("new_name"));
                }
            }
        }

        static void GetUserId()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                WhoAmIRequest request = new WhoAmIRequest();

                WhoAmIResponse response = (WhoAmIResponse)svc.Execute(request);

                Console.WriteLine($"Your UserId is '{response.UserId}'");

                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
        }

        static void CreateEntity()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                var courier = new Entity("new_courier");

                courier["new_name"] = "Create entity test 7";
                courier["new_vehicle"] = new OptionSetValue(100000001);

                // Associate an entity to a new contact

                //var primaryContact = new Entity("contact");
                //primaryContact["firstname"] = "John";
                //primaryContact["lastname"] = "Smith";
                //EntityCollection primaryContactCollection = new EntityCollection();
                //primaryContactCollection.Entities.Add(primaryContact);
                //courier.RelatedEntities[new Relationship("new_contact_new_courier_contact")] = primaryContactCollection;

                // Associate an entity to an existing contact

                courier["new_contact"] = new EntityReference("contact", new Guid("1218da0b-0d87-eb11-a812-000d3a4c1ce8"));

                Guid id = svc.Create(courier);

                Console.WriteLine("Entity created.");

                // Retrieve an entity

                Entity entity = svc.Retrieve("new_courier", id, new ColumnSet("new_name"));
                Console.WriteLine($"Entity name: {entity["new_name"]}");

                Console.ReadLine();
            }
        }
    }
}
