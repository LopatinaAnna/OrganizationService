[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
[assembly: System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.71")]

namespace CrmEarlyBound
{
	
	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	public partial class CrmServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CrmServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="CrmEarlyBound.new_courier"/> entities.
		/// </summary>
		public System.Linq.IQueryable<CrmEarlyBound.new_courier> new_courierSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<CrmEarlyBound.new_courier>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="CrmEarlyBound.new_customer"/> entities.
		/// </summary>
		public System.Linq.IQueryable<CrmEarlyBound.new_customer> new_customerSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<CrmEarlyBound.new_customer>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="CrmEarlyBound.new_order"/> entities.
		/// </summary>
		public System.Linq.IQueryable<CrmEarlyBound.new_order> new_orderSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<CrmEarlyBound.new_order>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="CrmEarlyBound.new_orderplan"/> entities.
		/// </summary>
		public System.Linq.IQueryable<CrmEarlyBound.new_orderplan> new_orderplanSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<CrmEarlyBound.new_orderplan>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="CrmEarlyBound.Publisher"/> entities.
		/// </summary>
		public System.Linq.IQueryable<CrmEarlyBound.Publisher> PublisherSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<CrmEarlyBound.Publisher>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="CrmEarlyBound.Solution"/> entities.
		/// </summary>
		public System.Linq.IQueryable<CrmEarlyBound.Solution> SolutionSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<CrmEarlyBound.Solution>();
			}
		}
	}
	
	internal sealed class EntityOptionSetEnum
	{
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
		{
			if (entity.Attributes.ContainsKey(attributeLogicalName))
			{
				Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
				if (value != null)
				{
					return value.Value;
				}
			}
			return null;
		}
	}
	
	/// <summary>
	/// Attribute to handle storing the OptionSet's Metadata.
	/// </summary>
	[System.AttributeUsageAttribute(System.AttributeTargets.Field)]
	public sealed class OptionSetMetadataAttribute : System.Attribute
	{
		
		/// <summary>
		/// Color of the OptionSetValue.
		/// </summary>
		public string Color { get; set; }
		
		/// <summary>
		/// Description of the OptionSetValue.
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// Display order index of the OptionSetValue.
		/// </summary>
		public int DisplayIndex { get; set; }
		
		/// <summary>
		/// External value of the OptionSetValue.
		/// </summary>
		public string ExternalValue { get; set; }
		
		/// <summary>
		/// Name of the OptionSetValue.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Initializes a new instance of the <see cref="OptionSetMetadataAttribute"/> class.
		/// </summary>
		/// <param name="name">Name of the value.</param>
		/// <param name="displayIndex">Display order index of the value.</param>
		/// <param name="color">Color of the value.</param>
		/// <param name="description">Description of the value.</param>
		/// <param name="externalValue">External value of the value.</param>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OptionSetMetadataAttribute(string name, int displayIndex, string color = null, string description = null, string externalValue = null)
		{
			this.Color = color;
			this.Description = description;
			this.ExternalValue = externalValue;
			this.DisplayIndex = displayIndex;
			this.Name = name;
		}
	}
	
	/// <summary>
	/// Extension class to handle retrieving of OptionSetMetadataAttribute.
	/// </summary>
	public static class OptionSetExtension
	{
		
		/// <summary>
		/// Returns the OptionSetMetadataAttribute for the given enum value
		/// </summary>
		/// <typeparam name="T">OptionSet Enum Type</typeparam>
		/// <param name="value">Enum Value with OptionSetMetadataAttribute</param>
		[System.Diagnostics.DebuggerNonUserCode()]
		public static OptionSetMetadataAttribute GetMetadata<T>(this T value)
			where T :  struct, System.IConvertible
		{
			System.Type enumType = typeof(T);
			if (!enumType.IsEnum)
			{
				throw new System.ArgumentException("T must be an enum!");
			}
			System.Reflection.MemberInfo[] members = enumType.GetMember(value.ToString());
			for (int i = 0; (i < members.Length); i++
			)
			{
				System.Attribute attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(members[i], typeof(OptionSetMetadataAttribute));
				if (attribute != null)
				{
					return ((OptionSetMetadataAttribute)(attribute));
				}
			}
			throw new System.ArgumentException("T must be an enum adorned with an OptionSetMetadataAttribute!");
		}
	}
}