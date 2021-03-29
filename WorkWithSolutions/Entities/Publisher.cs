namespace CrmEarlyBound
{
	
	/// <summary>
	/// A publisher of a CRM solution.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("publisher")]
	public partial class Publisher : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Publisher() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "publisher";
		
		public const string EntitySchemaName = "Publisher";
		
		public const string PrimaryIdAttribute = "publisherid";
		
		public const string PrimaryNameAttribute = "friendlyname";
		
		public const string EntityLogicalCollectionName = "publishers";
		
		public const string EntitySetName = "publishers";
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Type of address for address 1, such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public virtual Publisher_Address1_AddressTypeCode? Address1_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Publisher_Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// City name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Country/region name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// County name for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Fax number for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Latitude for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// First line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Second line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Third line for entering address 1 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Longitude for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Name to enter for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// ZIP Code or postal code for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Post office box number for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Method of shipment for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public virtual Publisher_Address1_ShippingMethodCode? Address1_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Publisher_Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// State or province for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// First telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Second telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Third telephone number associated with address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// United Parcel Service (UPS) zone for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Type of address for address 2. such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public virtual Publisher_Address2_AddressTypeCode? Address2_AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Publisher_Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// City name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Country/region name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// County name for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Fax number for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Latitude for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// First line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Second line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Third line for entering address 2 information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Longitude for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Name to enter for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// ZIP Code or postal code for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Post office box number for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Method of shipment for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public virtual Publisher_Address2_ShippingMethodCode? Address2_ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Publisher_Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// State or province for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// First telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Second telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Third telephone number associated with address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// United Parcel Service (UPS) zone for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the publisher was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Default option value prefix used for newly created options for solutions associated with this publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationoptionvalueprefix")]
		public System.Nullable<int> CustomizationOptionValuePrefix
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationoptionvalueprefix");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomizationOptionValuePrefix");
				this.SetAttributeValue("customizationoptionvalueprefix", value);
				this.OnPropertyChanged("CustomizationOptionValuePrefix");
			}
		}
		
		/// <summary>
		/// Prefix used for new entities, attributes, and entity relationships for solutions associated with this publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationprefix")]
		public string CustomizationPrefix
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("customizationprefix");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomizationPrefix");
				this.SetAttributeValue("customizationprefix", value);
				this.OnPropertyChanged("CustomizationPrefix");
			}
		}
		
		/// <summary>
		/// Description of the solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Email address for the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EMailAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EMailAddress");
				this.SetAttributeValue("emailaddress", value);
				this.OnPropertyChanged("EMailAddress");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// User display name for this publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlyname")]
		public string FriendlyName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("friendlyname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FriendlyName");
				this.SetAttributeValue("friendlyname", value);
				this.OnPropertyChanged("FriendlyName");
			}
		}
		
		/// <summary>
		/// Indicates whether the publisher was created as part of a managed solution installation.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreadonly")]
		public System.Nullable<bool> IsReadonly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isreadonly");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the publisher was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Default locale of the publisher in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointpublisherdefaultlocale")]
		public string PinpointPublisherDefaultLocale
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pinpointpublisherdefaultlocale");
			}
		}
		
		/// <summary>
		/// Identifier of the publisher in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointpublisherid")]
		public System.Nullable<long> PinpointPublisherId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("pinpointpublisherid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		public System.Nullable<System.Guid> PublisherId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("publisherid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PublisherId");
				this.SetAttributeValue("publisherid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PublisherId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.PublisherId = value;
			}
		}
		
		/// <summary>
		/// URL for the supporting website of this publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportingwebsiteurl")]
		public string SupportingWebsiteUrl
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("supportingwebsiteurl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SupportingWebsiteUrl");
				this.SetAttributeValue("supportingwebsiteurl", value);
				this.OnPropertyChanged("SupportingWebsiteUrl");
			}
		}
		
		/// <summary>
		/// The unique name of this publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N publisher_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("publisher_solution")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Solution> publisher_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Solution>("publisher_solution", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("publisher_solution");
				this.SetRelatedEntities<CrmEarlyBound.Solution>("publisher_solution", null, value);
				this.OnPropertyChanged("publisher_solution");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Publisher(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["publisherid"] = base.Id;
                        break;
                    case "publisherid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}