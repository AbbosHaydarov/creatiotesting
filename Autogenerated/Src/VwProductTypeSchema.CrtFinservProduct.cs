namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: VwProductTypeSchema

	/// <exclude/>
	public class VwProductTypeSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public VwProductTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwProductTypeSchema(VwProductTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwProductTypeSchema(VwProductTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471");
			RealUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471");
			Name = "VwProductType";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9c49bd49-3908-42ed-8bfa-3e4386486753");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b886628e-d576-496c-bc72-d228037b8858")) == null) {
				Columns.Add(CreateParentIdColumn());
			}
			if (Columns.FindByUId(new Guid("b5bab4fb-ff95-450b-88ad-ea02ad87cc4b")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("acce5c59-8257-425b-9db2-8f91785a11ce")) == null) {
				Columns.Add(CreateEntitySchemaNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("c5b63799-d7da-46d7-9153-260b892c0275"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				ModifiedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				CreatedInPackageId = new Guid("9c49bd49-3908-42ed-8bfa-3e4386486753")
			};
		}

		protected virtual EntitySchemaColumn CreateParentIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b886628e-d576-496c-bc72-d228037b8858"),
				Name = @"ParentId",
				CreatedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				ModifiedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				CreatedInPackageId = new Guid("9c49bd49-3908-42ed-8bfa-3e4386486753")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9755dbc5-be5d-4349-9dd7-50505b5b52f8"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				ModifiedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				CreatedInPackageId = new Guid("9c49bd49-3908-42ed-8bfa-3e4386486753"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b5bab4fb-ff95-450b-88ad-ea02ad87cc4b"),
				Name = @"Type",
				CreatedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				ModifiedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				CreatedInPackageId = new Guid("9c49bd49-3908-42ed-8bfa-3e4386486753")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("acce5c59-8257-425b-9db2-8f91785a11ce"),
				Name = @"EntitySchemaName",
				CreatedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				ModifiedInSchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471"),
				CreatedInPackageId = new Guid("9c49bd49-3908-42ed-8bfa-3e4386486753")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwProductType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwProductType_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwProductTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwProductTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d517232d-05a8-4216-b7a6-144e16c43471"));
		}

		#endregion

	}

	#endregion

	#region Class: VwProductType

	/// <summary>
	/// Product types view.
	/// </summary>
	public class VwProductType : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwProductType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwProductType";
		}

		public VwProductType(VwProductType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Record Id.
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
		/// Parent Id.
		/// </summary>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
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

		/// <summary>
		/// Type.
		/// </summary>
		public int Type {
			get {
				return GetTypedColumnValue<int>("Type");
			}
			set {
				SetColumnValue("Type", value);
			}
		}

		/// <summary>
		/// Object name.
		/// </summary>
		public string EntitySchemaName {
			get {
				return GetTypedColumnValue<string>("EntitySchemaName");
			}
			set {
				SetColumnValue("EntitySchemaName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwProductType_CrtFinservProductEventsProcess(UserConnection);
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
			return new VwProductType(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwProductType_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class VwProductType_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : VwProductType
	{

		private TEntity _entity;
		public TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public VwProductType_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwProductType_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("d517232d-05a8-4216-b7a6-144e16c43471");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d517232d-05a8-4216-b7a6-144e16c43471");
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

	#region Class: VwProductType_CrtFinservProductEventsProcess

	/// <exclude/>
	public class VwProductType_CrtFinservProductEventsProcess : VwProductType_CrtFinservProductEventsProcess<VwProductType>
	{

		public VwProductType_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwProductType_CrtFinservProductEventsProcess

	public partial class VwProductType_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwProductTypeEventsProcess

	/// <exclude/>
	public class VwProductTypeEventsProcess : VwProductType_CrtFinservProductEventsProcess
	{

		public VwProductTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

