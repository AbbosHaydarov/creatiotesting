namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FinApplicationSpec

	/// <exclude/>
	public class FinApplicationSpec : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public FinApplicationSpec(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationSpec";
		}

		public FinApplicationSpec(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "FinApplicationSpec";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

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
		public Guid ProductConditionId {
			get {
				return GetTypedColumnValue<Guid>("ProductConditionId");
			}
			set {
				SetColumnValue("ProductConditionId", value);
				_productCondition = null;
			}
		}

		/// <exclude/>
		public string ProductConditionName {
			get {
				return GetTypedColumnValue<string>("ProductConditionName");
			}
			set {
				SetColumnValue("ProductConditionName", value);
				if (_productCondition != null) {
					_productCondition.Name = value;
				}
			}
		}

		private ProductCondition _productCondition;
		/// <summary>
		/// Product conditions.
		/// </summary>
		public ProductCondition ProductCondition {
			get {
				return _productCondition ??
					(_productCondition = new ProductCondition(LookupColumnEntities.GetEntity("ProductCondition")));
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
		/// Parameter classification in product condition.
		/// </summary>
		public SpecInConditionType SpecInConditionType {
			get {
				return _specInConditionType ??
					(_specInConditionType = new SpecInConditionType(LookupColumnEntities.GetEntity("SpecInConditionType")));
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

		/// <exclude/>
		public Guid FinApplicationId {
			get {
				return GetTypedColumnValue<Guid>("FinApplicationId");
			}
			set {
				SetColumnValue("FinApplicationId", value);
				_finApplication = null;
			}
		}

		/// <exclude/>
		public string FinApplicationNumber {
			get {
				return GetTypedColumnValue<string>("FinApplicationNumber");
			}
			set {
				SetColumnValue("FinApplicationNumber", value);
				if (_finApplication != null) {
					_finApplication.Number = value;
				}
			}
		}

		private FinApplication _finApplication;
		/// <summary>
		/// Application.
		/// </summary>
		public FinApplication FinApplication {
			get {
				return _finApplication ??
					(_finApplication = new FinApplication(LookupColumnEntities.GetEntity("FinApplication")));
			}
		}

		/// <summary>
		/// Value.
		/// </summary>
		public string DisplayValue {
			get {
				return GetTypedColumnValue<string>("DisplayValue");
			}
			set {
				SetColumnValue("DisplayValue", value);
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
		/// Position of item in a list.
		/// </summary>
		public int RowPosition {
			get {
				return GetTypedColumnValue<int>("RowPosition");
			}
			set {
				SetColumnValue("RowPosition", value);
			}
		}

		/// <summary>
		/// Position of item in string.
		/// </summary>
		public int ValuePosition {
			get {
				return GetTypedColumnValue<int>("ValuePosition");
			}
			set {
				SetColumnValue("ValuePosition", value);
			}
		}

		/// <exclude/>
		public Guid OpportunityConditionId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityConditionId");
			}
			set {
				SetColumnValue("OpportunityConditionId", value);
				_opportunityCondition = null;
			}
		}

		/// <exclude/>
		public string OpportunityConditionName {
			get {
				return GetTypedColumnValue<string>("OpportunityConditionName");
			}
			set {
				SetColumnValue("OpportunityConditionName", value);
				if (_opportunityCondition != null) {
					_opportunityCondition.Name = value;
				}
			}
		}

		private OpportunityCondition _opportunityCondition;
		/// <summary>
		/// Opportunity condition.
		/// </summary>
		public OpportunityCondition OpportunityCondition {
			get {
				return _opportunityCondition ??
					(_opportunityCondition = new OpportunityCondition(LookupColumnEntities.GetEntity("OpportunityCondition")));
			}
		}

		/// <exclude/>
		public Guid SpecTableValueXId {
			get {
				return GetTypedColumnValue<Guid>("SpecTableValueXId");
			}
			set {
				SetColumnValue("SpecTableValueXId", value);
				_specTableValueX = null;
			}
		}

		private SpecTableValue _specTableValueX;
		/// <summary>
		/// SpecTableValueX.
		/// </summary>
		public SpecTableValue SpecTableValueX {
			get {
				return _specTableValueX ??
					(_specTableValueX = new SpecTableValue(LookupColumnEntities.GetEntity("SpecTableValueX")));
			}
		}

		/// <exclude/>
		public Guid SpecTableValueYId {
			get {
				return GetTypedColumnValue<Guid>("SpecTableValueYId");
			}
			set {
				SetColumnValue("SpecTableValueYId", value);
				_specTableValueY = null;
			}
		}

		private SpecTableValue _specTableValueY;
		/// <summary>
		/// SpecTableValueY.
		/// </summary>
		public SpecTableValue SpecTableValueY {
			get {
				return _specTableValueY ??
					(_specTableValueY = new SpecTableValue(LookupColumnEntities.GetEntity("SpecTableValueY")));
			}
		}

		/// <summary>
		/// The value is not filled in.
		/// </summary>
		public bool IsEmptyValue {
			get {
				return GetTypedColumnValue<bool>("IsEmptyValue");
			}
			set {
				SetColumnValue("IsEmptyValue", value);
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

		/// <summary>
		/// Added by the user.
		/// </summary>
		public bool IsCustom {
			get {
				return GetTypedColumnValue<bool>("IsCustom");
			}
			set {
				SetColumnValue("IsCustom", value);
			}
		}

		#endregion

	}

	#endregion

}

