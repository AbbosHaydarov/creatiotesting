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

	#region Class: BaseSpecValueSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseSpecValueSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseSpecValueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseSpecValueSchema(BaseSpecValueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseSpecValueSchema(BaseSpecValueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3");
			RealUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3");
			Name = "BaseSpecValue";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e41d6928-540d-4785-a774-5ffb5ca34933")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("6c69d3d1-aa63-45e2-a1f4-924376228f1f")) == null) {
				Columns.Add(CreateSpecificationListItemColumn());
			}
			if (Columns.FindByUId(new Guid("6bcd6c4b-e8e7-4582-bcb7-4ca06fa877bc")) == null) {
				Columns.Add(CreateCurrentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("aa792335-723b-4b41-8386-88603a18c64c")) == null) {
				Columns.Add(CreateTextValueColumn());
			}
			if (Columns.FindByUId(new Guid("3d9ddf1a-f62c-4b32-97ff-8ed9a04e9749")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("736f7f9d-bf43-4436-87fc-2f4bcdbd24a4")) == null) {
				Columns.Add(CreateMinFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("4d239eea-0344-4311-9a50-f775fbe3282a")) == null) {
				Columns.Add(CreateMaxFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("edf05277-3f0f-4528-ab74-9ca8b6a49178")) == null) {
				Columns.Add(CreateIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("f787438b-78f8-4a28-a806-6a58e99220dd")) == null) {
				Columns.Add(CreateMinIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("9fcb053f-847c-49ba-89af-9242854426ec")) == null) {
				Columns.Add(CreateMaxIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("62b5b7ee-5a39-43f1-a016-70ff4da56b7d")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("d43cb6e7-4fc5-434f-83a3-491d73352d08")) == null) {
				Columns.Add(CreateIsEmptyValueColumn());
			}
			if (Columns.FindByUId(new Guid("9b655610-e622-4ef3-8507-319504e5ae16")) == null) {
				Columns.Add(CreateIsEmptyMinValueColumn());
			}
			if (Columns.FindByUId(new Guid("2410c6ef-d64c-43bd-8fd6-57d33cd17b7f")) == null) {
				Columns.Add(CreateIsEmptyMaxValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e41d6928-540d-4785-a774-5ffb5ca34933"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationListItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6c69d3d1-aa63-45e2-a1f4-924376228f1f"),
				Name = @"SpecificationListItem",
				ReferenceSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6bcd6c4b-e8e7-4582-bcb7-4ca06fa877bc"),
				Name = @"CurrentType",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateTextValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("aa792335-723b-4b41-8386-88603a18c64c"),
				Name = @"TextValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("3d9ddf1a-f62c-4b32-97ff-8ed9a04e9749"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateMinFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("736f7f9d-bf43-4436-87fc-2f4bcdbd24a4"),
				Name = @"MinFloatValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4d239eea-0344-4311-9a50-f775fbe3282a"),
				Name = @"MaxFloatValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("edf05277-3f0f-4528-ab74-9ca8b6a49178"),
				Name = @"IntegerValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateMinIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f787438b-78f8-4a28-a806-6a58e99220dd"),
				Name = @"MinIntegerValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9fcb053f-847c-49ba-89af-9242854426ec"),
				Name = @"MaxIntegerValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("62b5b7ee-5a39-43f1-a016-70ff4da56b7d"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d43cb6e7-4fc5-434f-83a3-491d73352d08"),
				Name = @"IsEmptyValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyMinValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9b655610-e622-4ef3-8507-319504e5ae16"),
				Name = @"IsEmptyMinValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyMaxValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2410c6ef-d64c-43bd-8fd6-57d33cd17b7f"),
				Name = @"IsEmptyMaxValue",
				CreatedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				ModifiedInSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseSpecValue(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseSpecValue_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseSpecValueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseSpecValueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseSpecValue

	/// <summary>
	/// Base specification value.
	/// </summary>
	public class BaseSpecValue : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseSpecValue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseSpecValue";
		}

		public BaseSpecValue(BaseSpecValue source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
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
		/// Lookup parameter value.
		/// </summary>
		public SpecificationListItem SpecificationListItem {
			get {
				return _specificationListItem ??
					(_specificationListItem = LookupColumnEntities.GetEntity("SpecificationListItem") as SpecificationListItem);
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
		/// Integer value.
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
		/// Boolean value.
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
		/// Minimum value is not filled in.
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

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseSpecValue_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseSpecValueDeleted", e);
			Validating += (s, e) => ThrowEvent("BaseSpecValueValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseSpecValue(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseSpecValue_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class BaseSpecValue_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BaseSpecValue
	{

		public BaseSpecValue_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseSpecValue_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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

	#region Class: BaseSpecValue_CrtFinservProductEventsProcess

	/// <exclude/>
	public class BaseSpecValue_CrtFinservProductEventsProcess : BaseSpecValue_CrtFinservProductEventsProcess<BaseSpecValue>
	{

		public BaseSpecValue_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseSpecValue_CrtFinservProductEventsProcess

	public partial class BaseSpecValue_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BaseSpecValueEventsProcess

	/// <exclude/>
	public class BaseSpecValueEventsProcess : BaseSpecValue_CrtFinservProductEventsProcess
	{

		public BaseSpecValueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

