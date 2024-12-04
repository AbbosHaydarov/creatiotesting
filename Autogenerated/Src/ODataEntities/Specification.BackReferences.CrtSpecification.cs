namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Specification

	/// <exclude/>
	public class Specification : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Specification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Specification";
		}

		public Specification(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Specification";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ChangeCriteria> ChangeCriteriaCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<DefSpecification> DefSpecificationCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<FinApplicationSpec> FinApplicationSpecCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<ProductFilter> ProductFilterCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInContract> SpecificationInContractCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInLead> SpecificationInLeadCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInLeadType> SpecificationInLeadTypeCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInObject> SpecificationInObjectCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInOpportunity> SpecificationInOpportunityCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInProduct> SpecificationInProductCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationListItem> SpecificationListItemCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecInAppFormProperty> SpecInAppFormPropertyCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecInCondition> SpecInConditionCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecInherited> SpecInheritedCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecInPropertyType> SpecInPropertyTypeCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecTableInherited> SpecTableInheritedCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecTableValue> SpecTableValueCollectionBySpecification {
			get;
			set;
		}

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SpecificationType _type;
		/// <summary>
		/// Value type.
		/// </summary>
		public SpecificationType Type {
			get {
				return _type ??
					(_type = new SpecificationType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <exclude/>
		public Guid UnitId {
			get {
				return GetTypedColumnValue<Guid>("UnitId");
			}
			set {
				SetColumnValue("UnitId", value);
				_unit = null;
			}
		}

		/// <exclude/>
		public string UnitName {
			get {
				return GetTypedColumnValue<string>("UnitName");
			}
			set {
				SetColumnValue("UnitName", value);
				if (_unit != null) {
					_unit.Name = value;
				}
			}
		}

		private Unit _unit;
		/// <summary>
		/// Unit of measure.
		/// </summary>
		public Unit Unit {
			get {
				return _unit ??
					(_unit = new Unit(LookupColumnEntities.GetEntity("Unit")));
			}
		}

		/// <exclude/>
		public Guid LookupId {
			get {
				return GetTypedColumnValue<Guid>("LookupId");
			}
			set {
				SetColumnValue("LookupId", value);
				_lookup = null;
			}
		}

		/// <exclude/>
		public string LookupName {
			get {
				return GetTypedColumnValue<string>("LookupName");
			}
			set {
				SetColumnValue("LookupName", value);
				if (_lookup != null) {
					_lookup.Name = value;
				}
			}
		}

		private Lookup _lookup;
		/// <summary>
		/// Connect with lookup.
		/// </summary>
		public Lookup Lookup {
			get {
				return _lookup ??
					(_lookup = new Lookup(LookupColumnEntities.GetEntity("Lookup")));
			}
		}

		/// <exclude/>
		public Guid SpecInConditionTypeId {
			get {
				return GetTypedColumnValue<Guid>("SpecInConditionTypeId");
			}
			set {
				SetColumnValue("SpecInConditionTypeId", value);
				_specInConditionType = null;
			}
		}

		/// <exclude/>
		public string SpecInConditionTypeName {
			get {
				return GetTypedColumnValue<string>("SpecInConditionTypeName");
			}
			set {
				SetColumnValue("SpecInConditionTypeName", value);
				if (_specInConditionType != null) {
					_specInConditionType.Name = value;
				}
			}
		}

		private SpecInConditionType _specInConditionType;
		/// <summary>
		/// Parameter classification.
		/// </summary>
		public SpecInConditionType SpecInConditionType {
			get {
				return _specInConditionType ??
					(_specInConditionType = new SpecInConditionType(LookupColumnEntities.GetEntity("SpecInConditionType")));
			}
		}

		#endregion

	}

	#endregion

}

