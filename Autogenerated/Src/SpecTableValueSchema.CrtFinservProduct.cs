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

	#region Class: SpecTableValueSchema

	/// <exclude/>
	public class SpecTableValueSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecTableValueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecTableValueSchema(SpecTableValueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecTableValueSchema(SpecTableValueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068");
			RealUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068");
			Name = "SpecTableValue";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("eb064533-f4eb-4ac7-8af6-959a206f1575")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("00772fdb-aeeb-4227-a607-07c690d9388f")) == null) {
				Columns.Add(CreateSpecificationListItemColumn());
			}
			if (Columns.FindByUId(new Guid("f99746d3-f783-4d61-8c31-5dbe73f02ccd")) == null) {
				Columns.Add(CreateCurrentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("66e07fdf-2604-4058-82cc-9c4efe6282bb")) == null) {
				Columns.Add(CreateTextValueColumn());
			}
			if (Columns.FindByUId(new Guid("7392d678-afb1-4a1d-af64-27246ee1e4f3")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("df8a1640-dfa0-47ed-b085-6a8107088641")) == null) {
				Columns.Add(CreateMinFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("e5904a8e-36d8-4bc4-a576-1fae2e057308")) == null) {
				Columns.Add(CreateMaxFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("2497c2cd-ea28-4a11-8528-d9838a2238d0")) == null) {
				Columns.Add(CreateIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("54b4a51c-8dff-4b42-9b12-dec2da297a7a")) == null) {
				Columns.Add(CreateMinIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("3a037f5d-4ab2-4346-b6f2-606d16349af3")) == null) {
				Columns.Add(CreateMaxIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("3841b0c0-f47d-4aeb-afe9-088807f105d8")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("2376336c-a313-4e07-ad22-ad66c41f05f2")) == null) {
				Columns.Add(CreateIsEmptyMinValueColumn());
			}
			if (Columns.FindByUId(new Guid("dbe17279-da63-4b2a-ae9e-50169b1aad2f")) == null) {
				Columns.Add(CreateIsEmptyMaxValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("eb064533-f4eb-4ac7-8af6-959a206f1575"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationListItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("00772fdb-aeeb-4227-a607-07c690d9388f"),
				Name = @"SpecificationListItem",
				ReferenceSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f99746d3-f783-4d61-8c31-5dbe73f02ccd"),
				Name = @"CurrentType",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateTextValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("66e07fdf-2604-4058-82cc-9c4efe6282bb"),
				Name = @"TextValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("7392d678-afb1-4a1d-af64-27246ee1e4f3"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateMinFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("df8a1640-dfa0-47ed-b085-6a8107088641"),
				Name = @"MinFloatValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("e5904a8e-36d8-4bc4-a576-1fae2e057308"),
				Name = @"MaxFloatValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2497c2cd-ea28-4a11-8528-d9838a2238d0"),
				Name = @"IntegerValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateMinIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("54b4a51c-8dff-4b42-9b12-dec2da297a7a"),
				Name = @"MinIntegerValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3a037f5d-4ab2-4346-b6f2-606d16349af3"),
				Name = @"MaxIntegerValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3841b0c0-f47d-4aeb-afe9-088807f105d8"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyMinValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2376336c-a313-4e07-ad22-ad66c41f05f2"),
				Name = @"IsEmptyMinValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyMaxValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("dbe17279-da63-4b2a-ae9e-50169b1aad2f"),
				Name = @"IsEmptyMaxValue",
				CreatedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				ModifiedInSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecTableValue(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecTableValue_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecTableValueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecTableValueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecTableValue

	/// <summary>
	/// Table part parameter value.
	/// </summary>
	public class SpecTableValue : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecTableValue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecTableValue";
		}

		public SpecTableValue(SpecTableValue source)
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
		/// Parameter value.
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

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecTableValue_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecTableValueDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecTableValueValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecTableValue(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecTableValue_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class SpecTableValue_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SpecTableValue
	{

		public SpecTableValue_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecTableValue_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068");
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

	#region Class: SpecTableValue_CrtFinservProductEventsProcess

	/// <exclude/>
	public class SpecTableValue_CrtFinservProductEventsProcess : SpecTableValue_CrtFinservProductEventsProcess<SpecTableValue>
	{

		public SpecTableValue_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecTableValue_CrtFinservProductEventsProcess

	public partial class SpecTableValue_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecTableValueEventsProcess

	/// <exclude/>
	public class SpecTableValueEventsProcess : SpecTableValue_CrtFinservProductEventsProcess
	{

		public SpecTableValueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

