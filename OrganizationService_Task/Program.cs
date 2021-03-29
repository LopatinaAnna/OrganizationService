using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using static System.Configuration.ConfigurationManager;

namespace OrganizationService_Task
{
    /// <summary>
    /// Deactivate old Orders and Order Plans:
    /// Get all Order Plans where Estimated Finish Date is less than today
    /// Go through all the retrieved Order Plans
    /// Get all Orders which are related to the current Order Plan
    /// Go through all the retrieved Orders
    /// Deactivate them(set “statecode” field to “Inactive”)
    /// Deactivate current Order Plan(set “statecode” field to “Inactive”)
    /// </summary>
    class Program
    {
        static readonly string connection = ConnectionStrings["DefaultConnection"].ConnectionString;

        static void Main(string[] args)
        {
            var orderPlans = GetOrderPlansWhereDateIsLessThanToday();

            var orders = GetAllOrders();

            foreach (var orderPlan in orderPlans)
            {
                foreach (var order in orders)
                {
                    var orderPlanInOrder = order.GetAttributeValue<EntityReference>("new_orderplan");

                    if (orderPlanInOrder.Id == orderPlan.Id)
                    {
                        DeactivateEntity("new_order", order.Id);
                    }
                }
                DeactivateEntity("new_orderplan", orderPlan.Id);
            }

            Console.ReadKey();
        }

        static void DeactivateEntity(string entityName, Guid id)
        {
            using (var svc = new CrmServiceClient(connection))
            {
                var retrievedAccount = new Entity(entityName, id);

                var entity = new Entity(entityName) { Id = retrievedAccount.Id };

                entity["statecode"] = new OptionSetValue(1);

                svc.Update(entity);
            }
        }

        static List<Entity> GetOrderPlansWhereDateIsLessThanToday()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                var query = new QueryExpression("new_orderplan")
                {
                    ColumnSet = new ColumnSet("new_orderplanid", "new_name", "new_estimatedfinishdate"),
                    NoLock = true,
                    Distinct = true
                };

                query.Criteria.AddCondition("new_estimatedfinishdate", ConditionOperator.LessThan, DateTime.Now);
                query.AddOrder("new_estimatedfinishdate", OrderType.Ascending);

                var entityCollection = svc.RetrieveMultiple(query);

                return entityCollection.Entities.ToList();
            }
        }

        static List<Entity> GetAllOrders()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                var query = new QueryExpression("new_order")
                {
                    ColumnSet = new ColumnSet("new_orderid", "new_orderplan"),
                    NoLock = true,
                    Distinct = true
                };

                var entityCollection = svc.RetrieveMultiple(query);

                return entityCollection.Entities.ToList();
            }
        }
    }
}
