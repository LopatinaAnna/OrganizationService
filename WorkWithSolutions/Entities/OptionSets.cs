namespace CrmEarlyBound
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum new_courier_new_vehicle
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Bike", 1, "#0000ff")]
		Bike = 100000001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Car", 0, "#0000ff")]
		Car = 100000000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Scooter", 2, "#0000ff")]
		Scooter = 100000002,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum new_courier_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum new_customer_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum new_order_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum new_orderplan_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Publisher_Address1_AddressTypeCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Publisher_Address1_ShippingMethodCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Publisher_Address2_AddressTypeCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Publisher_Address2_ShippingMethodCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Default Value", 0)]
		DefaultValue = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum Solution_SolutionType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Internal", 2)]
		Internal = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("None", 0)]
		None = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Snapshot", 1)]
		Snapshot = 1,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum msdyn_oc_daysofweek
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Sun", 0, "#0000ff", "Sunday")]
		Sun = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mon", 1, "#0000ff", "Monday")]
		Mon = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Tue", 2, "#0000ff", "Tuesday")]
		Tue = 192350002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Wed", 3, "#0000ff", "Wednesday")]
		Wed = 192350003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Thu", 4, "#0000ff", "Thursday")]
		Thu = 192350004,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Fri", 5, "#0000ff", "Friday")]
		Fri = 192350005,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Sat", 6, "#0000ff", "Saturday")]
		Sat = 192350006,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum msdyn_msdyn_requirementrelationship_msdyn_resourcegroupings
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Organizational Unit", 0, "#0000ff")]
		OrganizationalUnit = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Related Resource Pools", 1, "#0000ff")]
		RelatedResourcePools = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Location", 2, "#0000ff")]
		Location = 192350002,
	}
}
