using System;
using CrmEarlyBound;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using WorkWithSolutions.Entities;
using static System.Configuration.ConfigurationManager;

namespace WorkWithSolutions.Services
{
    class EntityService
    {
        readonly string connection = ConnectionStrings["DefaultConnection"].ConnectionString;

        public void AddNewEntity()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                CreateEntityRequest createrequest = new CreateEntityRequest
                {
                    Entity = new EntityMetadata
                    {
                        SchemaName = "test_entity",
                        DisplayName = new Label("Test entity", 1033),
                        DisplayCollectionName = new Label("Test Entities", 1033),
                        Description = new Label("An entity to store test information", 1033),
                        OwnershipType = OwnershipTypes.UserOwned,
                        IsActivity = false
                    },
                    PrimaryAttribute = new StringAttributeMetadata
                    {
                        SchemaName = "name",
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        MaxLength = 100,
                        FormatName = StringFormatName.Text,
                        DisplayName = new Label("Test", 1033),
                        Description = new Label("The primary attribute for the Test entity.", 1033)
                    },
                    SolutionUniqueName = "samplesolution"
                };

                svc.Execute(createrequest);
                Console.WriteLine("The entity has been created.");
            }
        }

        public void AddExistingEntity(string entityLogicalName, bool addRequiredComponents, bool doNotIncludeSubcomponents)
        {
            using (var svc = new CrmServiceClient(connection))
            {
                RetrieveEntityRequest retrieveEntityRequest = new RetrieveEntityRequest()
                {
                    LogicalName = entityLogicalName
                };
                RetrieveEntityResponse retrieveEntityResponse = (RetrieveEntityResponse)svc.Execute(retrieveEntityRequest);

                AddSolutionComponentRequest addRequest = new AddSolutionComponentRequest()
                {
                    ComponentType = (int)ComponentType.Entity,
                    ComponentId = (Guid)retrieveEntityResponse.EntityMetadata.MetadataId,
                    SolutionUniqueName = "samplesolution",
                    AddRequiredComponents = addRequiredComponents,
                    DoNotIncludeSubcomponents = doNotIncludeSubcomponents
                };
                svc.Execute(addRequest);

                AddExistingComponentToSolution(ComponentType.SystemForm, "EA01497A-3AFD-45AF-8824-05179E65241F", "samplesolution");

                AddExistingComponentToSolution(ComponentType.Attribute, "D2C12E2D-D487-EB11-A812-000D3A4C1CE8", "samplesolution");
            }
        }

        public void AddExistingComponentToSolution(ComponentType type, string id, string solutionUniqueName)
        {
            using (var svc = new CrmServiceClient(connection))
            {
                AddSolutionComponentRequest request = new AddSolutionComponentRequest()
                {
                    ComponentType = (int)type,
                    ComponentId = new Guid(id),
                    SolutionUniqueName = solutionUniqueName
                };
                svc.Execute(request);
            }
        }

        public void CreateEntityRecord()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                var entity = new Entity("test_entity");
                entity["name"] = "Create entity test";
                Guid id = svc.Create(entity);

                Entity retrieveEntity = svc.Retrieve("test_entity", id, new ColumnSet("name"));
                Console.WriteLine($"Record created: {retrieveEntity["name"]}");
            }
        }

        public void AddNewOptionSet()
        {
            using (var svc = new CrmServiceClient(connection))
            {
                CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
                {
                    OptionSet = new OptionSetMetadata()
                    {
                        Name = "test_option_set",
                        DisplayName = new Label("Test Option Set", 1033),
                        IsGlobal = true,
                        OptionSetType = OptionSetType.Picklist,
                        Options =
                        {
                            new OptionMetadata(new Label("Option 1", 1033), 1),
                            new OptionMetadata(new Label("Option 2", 1033), 2)
                        },
                        Description = new Label("This is test option set.", 1033)
                    }, 
                    SolutionUniqueName = "samplesolution"
                };
                svc.Execute(createOptionSetRequest);
            }
        }
    }
}
