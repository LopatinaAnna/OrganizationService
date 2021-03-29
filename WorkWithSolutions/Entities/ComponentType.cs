﻿using CrmEarlyBound;

namespace WorkWithSolutions.Entities
{
	public enum ComponentType
	{
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("AI Configuration", 86)]
		AIConfiguration = 402,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("AI Project", 85)]
		AIProject = 401,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("AI Project Type", 84)]
		AIProjectType = 400,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Attachment", 28)]
		Attachment = 35,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Attribute", 1)]
		Attribute = 2,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Attribute Image Configuration", 88)]
		AttributeImageConfiguration = 431,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Attribute Lookup Value", 4)]
		AttributeLookupValue = 5,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Attribute Map", 36)]
		AttributeMap = 47,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Attribute Picklist Value", 3)]
		AttributePicklistValue = 4,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Canvas App", 79)]
		CanvasApp = 300,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Complex Control", 48)]
		ComplexControl = 64,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Connection Role", 47)]
		ConnectionRole = 63,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Connector", 80)]
		Connector_371 = 371,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Connector", 81)]
		Connector_372 = 372,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Contract Template", 30)]
		ContractTemplate = 37,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Convert Rule", 60)]
		ConvertRule = 154,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Convert Rule Item", 61)]
		ConvertRuleItem = 155,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Custom Control", 66)]
		CustomControl = 66,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Custom Control Default Config", 67)]
		CustomControlDefaultConfig = 68,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Data Source Mapping", 68)]
		DataSourceMapping = 166,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Display String", 18)]
		DisplayString = 22,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Display String Map", 19)]
		DisplayStringMap = 23,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Duplicate Rule", 33)]
		DuplicateRule = 44,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Duplicate Rule Condition", 34)]
		DuplicateRuleCondition = 45,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Email Template", 29)]
		EmailTemplate = 36,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity", 0)]
		Entity = 1,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity Analytics Configuration", 87)]
		EntityAnalyticsConfiguration = 430,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity Image Configuration", 89)]
		EntityImageConfiguration = 432,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity Key", 13)]
		EntityKey = 14,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity Map", 35)]
		EntityMap = 46,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity Relationship", 9)]
		EntityRelationship = 10,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity Relationship Relationships", 11)]
		EntityRelationshipRelationships = 12,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Entity Relationship Role", 10)]
		EntityRelationshipRole = 11,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Environment Variable Definition", 82)]
		EnvironmentVariableDefinition = 380,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Environment Variable Value", 83)]
		EnvironmentVariableValue = 381,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Field Permission", 50)]
		FieldPermission = 71,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Field Security Profile", 49)]
		FieldSecurityProfile = 70,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Form", 20)]
		Form = 24,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Hierarchy Rule", 62)]
		HierarchyRule = 65,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Import Map", 78)]
		ImportMap = 208,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Index", 77)]
		Index = 18,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("KB Article Template", 31)]
		KBArticleTemplate = 38,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Localized Label", 6)]
		LocalizedLabel = 7,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mail Merge Template", 32)]
		MailMergeTemplate = 39,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Managed Property", 12)]
		ManagedProperty = 13,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mobile Offline Profile", 63)]
		MobileOfflineProfile = 161,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mobile Offline Profile Item", 64)]
		MobileOfflineProfileItem = 162,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Option Set", 8)]
		OptionSet = 9,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Organization", 21)]
		Organization = 25,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Plugin Assembly", 52)]
		PluginAssembly = 91,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Plugin Type", 51)]
		PluginType = 90,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Privilege", 14)]
		Privilege = 16,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("PrivilegeObjectTypeCode", 15)]
		PrivilegeObjectTypeCode = 17,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Relationship", 2)]
		Relationship = 3,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Relationship Extra Condition", 7)]
		RelationshipExtraCondition = 8,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Report", 24)]
		Report = 31,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Report Category", 26)]
		ReportCategory = 33,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Report Entity", 25)]
		ReportEntity = 32,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Report Visibility", 27)]
		ReportVisibility = 34,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ribbon Command", 37)]
		RibbonCommand = 48,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ribbon Context Group", 38)]
		RibbonContextGroup = 49,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ribbon Customization", 39)]
		RibbonCustomization = 50,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ribbon Diff", 42)]
		RibbonDiff = 55,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ribbon Rule", 40)]
		RibbonRule = 52,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Ribbon Tab To Command Map", 41)]
		RibbonTabToCommandMap = 53,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Role", 16)]
		Role = 20,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Role Privilege", 17)]
		RolePrivilege = 21,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Routing Rule", 56)]
		RoutingRule = 150,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Routing Rule Item", 57)]
		RoutingRuleItem = 151,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Saved Query", 22)]
		SavedQuery = 26,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Saved Query Visualization", 43)]
		SavedQueryVisualization = 59,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SDKMessage", 69)]
		SDKMessage = 201,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SDKMessageFilter", 70)]
		SDKMessageFilter = 202,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SdkMessagePair", 71)]
		SdkMessagePair = 203,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SDK Message Processing Step", 53)]
		SDKMessageProcessingStep = 92,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SDK Message Processing Step Image", 54)]
		SDKMessageProcessingStepImage = 93,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SdkMessageRequest", 72)]
		SdkMessageRequest = 204,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SdkMessageRequestField", 73)]
		SdkMessageRequestField = 205,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SdkMessageResponse", 74)]
		SdkMessageResponse = 206,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SdkMessageResponseField", 75)]
		SdkMessageResponseField = 207,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Service Endpoint", 55)]
		ServiceEndpoint = 95,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Similarity Rule", 65)]
		SimilarityRule = 165,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Site Map", 46)]
		SiteMap = 62,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SLA", 58)]
		SLA = 152,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SLA Item", 59)]
		SLAItem = 153,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("System Form", 44)]
		SystemForm = 60,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("View Attribute", 5)]
		ViewAttribute = 6,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Web Resource", 45)]
		WebResource = 61,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("WebWizard", 76)]
		WebWizard = 210,

		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Workflow", 23)]
		Workflow = 29,
	}
}
