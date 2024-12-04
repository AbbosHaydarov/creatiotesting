namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ChangeCriteriaInCondition

	/// <exclude/>
	public class ChangeCriteriaInCondition : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public ChangeCriteriaInCondition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ChangeCriteriaInCondition";
		}

		public ChangeCriteriaInCondition(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "ChangeCriteriaInCondition";
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

		/// <summary>
		/// Value.
		/// </summary>
		public string StringValue {
			get {
				return GetTypedColumnValue<string>("StringValue");
			}
			set {
				SetColumnValue("StringValue", value);
			}
		}

		/// <summary>
		/// Numeric value.
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
		/// Value.
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
		/// Value.
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
		/// Value.
		/// </summary>
		public SpecificationListItem SpecificationListItem {
			get {
				return _specificationListItem ??
					(_specificationListItem = new SpecificationListItem(LookupColumnEntities.GetEntity("SpecificationListItem")));
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
		/// Correcting value.
		/// </summary>
		public Decimal CorrectionValue {
			get {
				return GetTypedColumnValue<Decimal>("CorrectionValue");
			}
			set {
				SetColumnValue("CorrectionValue", value);
			}
		}

		/// <exclude/>
		public Guid ChangeCriteriaId {
			get {
				return GetTypedColumnValue<Guid>("ChangeCriteriaId");
			}
			set {
				SetColumnValue("ChangeCriteriaId", value);
				_changeCriteria = null;
			}
		}

		/// <exclude/>
		public string ChangeCriteriaDisplayValue {
			get {
				return GetTypedColumnValue<string>("ChangeCriteriaDisplayValue");
			}
			set {
				SetColumnValue("ChangeCriteriaDisplayValue", value);
				if (_changeCriteria != null) {
					_changeCriteria.DisplayValue = value;
				}
			}
		}

		private ChangeCriteria _changeCriteria;
		/// <summary>
		/// Change criteria.
		/// </summary>
		public ChangeCriteria ChangeCriteria {
			get {
				return _changeCriteria ??
					(_changeCriteria = new ChangeCriteria(LookupColumnEntities.GetEntity("ChangeCriteria")));
			}
		}

		/// <exclude/>
		public Guid VariableSpecificationId {
			get {
				return GetTypedColumnValue<Guid>("VariableSpecificationId");
			}
			set {
				SetColumnValue("VariableSpecificationId", value);
				_variableSpecification = null;
			}
		}

		/// <exclude/>
		public string VariableSpecificationName {
			get {
				return GetTypedColumnValue<string>("VariableSpecificationName");
			}
			set {
				SetColumnValue("VariableSpecificationName", value);
				if (_variableSpecification != null) {
					_variableSpecification.Name = value;
				}
			}
		}

		private DefSpecification _variableSpecification;
		/// <summary>
		/// Variable parameter.
		/// </summary>
		public DefSpecification VariableSpecification {
			get {
				return _variableSpecification ??
					(_variableSpecification = new DefSpecification(LookupColumnEntities.GetEntity("VariableSpecification")));
			}
		}

		#endregion

	}

	#endregion

}

