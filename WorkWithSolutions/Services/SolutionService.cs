using System;
using CrmEarlyBound;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using static System.Configuration.ConfigurationManager;

namespace WorkWithSolutions.Services
{
    class SolutionService
    {
        readonly string connection = ConnectionStrings["DefaultConnection"].ConnectionString;

        public Solution RetrieveSolution(string solutionUniqueName)
        {
            using (var svc = new CrmServiceClient(connection))
            {
                QueryExpression querySampleSolution = new QueryExpression
                {
                    EntityName = Solution.EntityLogicalName,
                    ColumnSet = new ColumnSet(new string[] { "publisherid", "installedon", "version", "versionnumber", "friendlyname" }),
                    Criteria = new FilterExpression()
                };

                querySampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solutionUniqueName);
                Solution sampleSolution = (Solution)svc.RetrieveMultiple(querySampleSolution).Entities[0];

                return sampleSolution;
            }
        }

        public void CreateSolution(string solutionUniqueName, string solutionFriendlyName)
        {
            Guid DefaultPublisherId = new Guid("{d21aab71-79e7-11dd-8874-00188b01e34f}");

            using (var svc = new CrmServiceClient(connection))
            {
                //Define a solution
                Solution solution = new Solution
                {
                    UniqueName = solutionUniqueName,
                    FriendlyName = solutionFriendlyName,
                    PublisherId = new EntityReference(Publisher.EntityLogicalName, DefaultPublisherId),
                    Description = $"This is {solutionFriendlyName} solution.",
                    Version = "1.0"
                };

                //Check whether it already exists
                QueryExpression queryCheckForSampleSolution = new QueryExpression
                {
                    EntityName = Solution.EntityLogicalName,
                    ColumnSet = new ColumnSet(),
                    Criteria = new FilterExpression()
                };
                queryCheckForSampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solution.UniqueName);

                //Create the solution if it does not already exist.
                EntityCollection querySampleSolutionResults = svc.RetrieveMultiple(queryCheckForSampleSolution);
                Solution SampleSolutionResults = null;
                Guid _solutionsSampleSolutionId = Guid.Empty;

                if (querySampleSolutionResults.Entities.Count > 0)
                {
                    SampleSolutionResults = (Solution)querySampleSolutionResults.Entities[0];
                    _solutionsSampleSolutionId = (Guid)SampleSolutionResults.SolutionId;
                    Console.WriteLine(string.Format("Solution already exist: {0}.", solution.FriendlyName));
                }
                if (SampleSolutionResults == null)
                {
                    _solutionsSampleSolutionId = svc.Create(solution);
                    Console.WriteLine(string.Format("Created solution: {0}.", solution.FriendlyName));
                }
            }
        }

        public void DeleteSolution(string solutionUniqueName)
        {
            using (var svc = new CrmServiceClient(connection))
            {
                QueryExpression queryImportedSolution = new QueryExpression
                {
                    EntityName = Solution.EntityLogicalName,
                    ColumnSet = new ColumnSet(new string[] { "solutionid", "friendlyname" }),
                    Criteria = new FilterExpression()
                };

                queryImportedSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solutionUniqueName);

                Solution ImportedSolution = (Solution)svc.RetrieveMultiple(queryImportedSolution).Entities[0];

                svc.Delete(Solution.EntityLogicalName, (Guid)ImportedSolution.SolutionId);

                Console.WriteLine("Deleted solution: {0}.", ImportedSolution.FriendlyName);
            }
        }
    }
}
