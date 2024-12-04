namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema

	/// <exclude/>
	public class ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema(ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema(ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a");
			RealUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a");
			Name = "ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1e8e4aca-7c5b-4c85-9c75-d8d2a2bcdde9")) == null) {
				Columns.Add(CreateProductConditionColumn());
			}
			if (Columns.FindByUId(new Guid("e5183a1f-255f-4bf4-a037-44852ba49bc5")) == null) {
				Columns.Add(CreateStringValueColumn());
			}
			if (Columns.FindByUId(new Guid("47164b9a-f861-4904-9019-39f1a8910671")) == null) {
				Columns.Add(CreateIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("8348f878-43c2-45b3-b9c3-394c8b9117e3")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("37722d92-f6ed-4f9a-a1da-f1a8893561eb")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("343d5641-17a5-4640-b1b6-9d47bd4f42f5")) == null) {
				Columns.Add(CreateSpecificationListItemColumn());
			}
			if (Columns.FindByUId(new Guid("92d9480b-92c0-442d-ac43-11d41c91d663")) == null) {
				Columns.Add(CreateDisplayValueColumn());
			}
			if (Columns.FindByUId(new Guid("85cfb185-e791-4065-a577-af503f444e7f")) == null) {
				Columns.Add(CreateCorrectionValueColumn());
			}
			if (Columns.FindByUId(new Guid("40565f2f-bf0a-4e37-8da9-b806a8728498")) == null) {
				Columns.Add(CreateChangeCriteriaColumn());
			}
			if (Columns.FindByUId(new Guid("808aca23-3e10-4303-84ae-75d8ac3866a9")) == null) {
				Columns.Add(CreateVariableSpecificationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductConditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1e8e4aca-7c5b-4c85-9c75-d8d2a2bcdde9"),
				Name = @"ProductCondition",
				ReferenceSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateStringValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("e5183a1f-255f-4bf4-a037-44852ba49bc5"),
				Name = @"StringValue",
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("47164b9a-f861-4904-9019-39f1a8910671"),
				Name = @"IntegerValue",
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8348f878-43c2-45b3-b9c3-394c8b9117e3"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("37722d92-f6ed-4f9a-a1da-f1a8893561eb"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationListItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("343d5641-17a5-4640-b1b6-9d47bd4f42f5"),
				Name = @"SpecificationListItem",
				ReferenceSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateDisplayValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("92d9480b-92c0-442d-ac43-11d41c91d663"),
				Name = @"DisplayValue",
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateCorrectionValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("85cfb185-e791-4065-a577-af503f444e7f"),
				Name = @"CorrectionValue",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateChangeCriteriaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("40565f2f-bf0a-4e37-8da9-b806a8728498"),
				Name = @"ChangeCriteria",
				ReferenceSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateVariableSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("808aca23-3e10-4303-84ae-75d8ac3866a9"),
				Name = @"VariableSpecification",
				ReferenceSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				ModifiedInSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ChangeCriteriaInCondition_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a"));
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft

	/// <summary>
	/// Condition change criteria in the product conditions.
	/// </summary>
	public class ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft";
		}

		public ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft(ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
					(_productCondition = LookupColumnEntities.GetEntity("ProductCondition") as ProductCondition);
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
					(_specificationListItem = LookupColumnEntities.GetEntity("SpecificationListItem") as SpecificationListItem);
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
					(_changeCriteria = LookupColumnEntities.GetEntity("ChangeCriteria") as ChangeCriteria);
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
					(_variableSpecification = LookupColumnEntities.GetEntity("VariableSpecification") as DefSpecification);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ChangeCriteriaInCondition_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteriaInCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ChangeCriteriaInCondition_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft
	{

		public ChangeCriteriaInCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeCriteriaInCondition_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private LocalizableString _trueString;
		public LocalizableString TrueString {
			get {
				return _trueString ?? (_trueString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TrueString.Value"));
			}
		}

		private LocalizableString _falseString;
		public LocalizableString FalseString {
			get {
				return _falseString ?? (_falseString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FalseString.Value"));
			}
		}

		private LocalizableString _unsupportedSpecificationType;
		public LocalizableString UnsupportedSpecificationType {
			get {
				return _unsupportedSpecificationType ?? (_unsupportedSpecificationType = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UnsupportedSpecificationType.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteriaInCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ChangeCriteriaInCondition_CrtFinservProductEventsProcess : ChangeCriteriaInCondition_CrtFinservProductEventsProcess<ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft>
	{

		public ChangeCriteriaInCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

