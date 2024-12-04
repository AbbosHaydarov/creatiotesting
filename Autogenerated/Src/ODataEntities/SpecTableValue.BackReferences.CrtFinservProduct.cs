namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SpecTableValue

	/// <exclude/>
	public class SpecTableValue : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SpecTableValue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecTableValue";
		}

		public SpecTableValue(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SpecTableValue";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<FinApplicationSpec> FinApplicationSpecCollectionBySpecTableValueX {
			get;
			set;
		}

		public IEnumerable<FinApplicationSpec> FinApplicationSpecCollectionBySpecTableValueY {
			get;
			set;
		}

		public IEnumerable<SpecInCondition> SpecInConditionCollectionBySpecTableValueX {
			get;
			set;
		}

		public IEnumerable<SpecInCondition> SpecInConditionCollectionBySpecTableValueY {
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

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Parameter.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = new Specification(LookupColumnEntities.GetEntity("Specification")));
			}
		}

		/// <exclude/>
		public Guid SpecificationListItemId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationListItemId");
			}
			set {
				SetColumnValue("SpecificationListItemId", value);
				_specificationListItem = null;
			}
		}

		/// <exclude/>
		public string SpecificationListItemName {
			get {
				return GetTypedColumnValue<string>("SpecificationListItemName");
			}
			set {
				SetColumnValue("SpecificationListItemName", value);
				if (_specificationListItem != null) {
					_specificationListItem.Name = value;
				}
			}
		}

		private SpecificationListItem _specificationListItem;
		/// <summary>
		/// Parameter value.
		/// </summary>
		public SpecificationListItem SpecificationListItem {
			get {
				return _specificationListItem ??
					(_specificationListItem = new SpecificationListItem(LookupColumnEntities.GetEntity("SpecificationListItem")));
			}
		}

		/// <summary>
		/// View type.
		/// </summary>
		public string CurrentType {
			get {
				return GetTypedColumnValue<string>("CurrentType");
			}
			set {
				SetColumnValue("CurrentType", value);
			}
		}

		/// <summary>
		/// Text value.
		/// </summary>
		public string TextValue {
			get {
				return GetTypedColumnValue<string>("TextValue");
			}
			set {
				SetColumnValue("TextValue", value);
			}
		}

		/// <summary>
		/// Decimal value.
		/// </summary>
		public Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// Minimum decimal value.
		/// </summary>
		public Decimal MinFloatValue {
			get {
				return GetTypedColumnValue<Decimal>("MinFloatValue");
			}
			set {
				SetColumnValue("MinFloatValue", value);
			}
		}

		/// <summary>
		/// Maximal decimal value.
		/// </summary>
		public Decimal MaxFloatValue {
			get {
				return GetTypedColumnValue<Decimal>("MaxFloatValue");
			}
			set {
				SetColumnValue("MaxFloatValue", value);
			}
		}

		/// <summary>
		/// Integer.
		/// </summary>
		public int IntegerValue {
			get {
				return GetTypedColumnValue<int>("IntegerValue");
			}
			set {
				SetColumnValue("IntegerValue", value);
			}
		}

		/// <summary>
		/// Minimum integer value.
		/// </summary>
		public int MinIntegerValue {
			get {
				return GetTypedColumnValue<int>("MinIntegerValue");
			}
			set {
				SetColumnValue("MinIntegerValue", value);
			}
		}

		/// <summary>
		/// Maximum integer value.
		/// </summary>
		public int MaxIntegerValue {
			get {
				return GetTypedColumnValue<int>("MaxIntegerValue");
			}
			set {
				SetColumnValue("MaxIntegerValue", value);
			}
		}

		/// <summary>
		/// Logic value.
		/// </summary>
		public bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <summary>
		/// Minimum valus is not filled in.
		/// </summary>
		public bool IsEmptyMinValue {
			get {
				return GetTypedColumnValue<bool>("IsEmptyMinValue");
			}
			set {
				SetColumnValue("IsEmptyMinValue", value);
			}
		}

		/// <summary>
		/// Maximum value is not filled in.
		/// </summary>
		public bool IsEmptyMaxValue {
			get {
				return GetTypedColumnValue<bool>("IsEmptyMaxValue");
			}
			set {
				SetColumnValue("IsEmptyMaxValue", value);
			}
		}

		#endregion

	}

	#endregion

}

