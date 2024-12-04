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

	#region Class: VwCaseDurationSchema

	/// <exclude/>
	public class VwCaseDurationSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public VwCaseDurationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwCaseDurationSchema(VwCaseDurationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwCaseDurationSchema(VwCaseDurationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d");
			RealUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d");
			Name = "VwCaseDuration";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("582f3ef6-3952-4621-b808-17bb7efafa80")) == null) {
				Columns.Add(CreateTotalSecondsColumn());
			}
			if (Columns.FindByUId(new Guid("9d4b0d22-3978-4579-9a9f-e9c76dee47d5")) == null) {
				Columns.Add(CreateLastActiveDateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("346c51f0-8221-4914-a8e5-97436bb237ef"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d"),
				ModifiedInSchemaUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef")
			};
		}

		protected virtual EntitySchemaColumn CreateTotalSecondsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("582f3ef6-3952-4621-b808-17bb7efafa80"),
				Name = @"TotalSeconds",
				CreatedInSchemaUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d"),
				ModifiedInSchemaUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLastActiveDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("9d4b0d22-3978-4579-9a9f-e9c76dee47d5"),
				Name = @"LastActiveDate",
				CreatedInSchemaUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d"),
				ModifiedInSchemaUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwCaseDuration(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwCaseDuration_OBSWEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwCaseDurationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwCaseDurationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d"));
		}

		#endregion

	}

	#endregion

	#region Class: VwCaseDuration

	/// <summary>
	/// Case duration (view).
	/// </summary>
	public class VwCaseDuration : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwCaseDuration(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwCaseDuration";
		}

		public VwCaseDuration(VwCaseDuration source)
			: base(source) {
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
		/// Total number of seconds.
		/// </summary>
		public int TotalSeconds {
			get {
				return GetTypedColumnValue<int>("TotalSeconds");
			}
			set {
				SetColumnValue("TotalSeconds", value);
			}
		}

		/// <summary>
		/// Last date of active state.
		/// </summary>
		public DateTime LastActiveDate {
			get {
				return GetTypedColumnValue<DateTime>("LastActiveDate");
			}
			set {
				SetColumnValue("LastActiveDate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwCaseDuration_OBSWEventsProcess(UserConnection);
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
			return new VwCaseDuration(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwCaseDuration_OBSWEventsProcess

	/// <exclude/>
	public partial class VwCaseDuration_OBSWEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : VwCaseDuration
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

		public VwCaseDuration_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwCaseDuration_OBSWEventsProcess";
			SchemaUId = new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("668b7ed1-78b6-4b40-a98e-b8c4f716ad7d");
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

	#region Class: VwCaseDuration_OBSWEventsProcess

	/// <exclude/>
	public class VwCaseDuration_OBSWEventsProcess : VwCaseDuration_OBSWEventsProcess<VwCaseDuration>
	{

		public VwCaseDuration_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwCaseDuration_OBSWEventsProcess

	public partial class VwCaseDuration_OBSWEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwCaseDurationEventsProcess

	/// <exclude/>
	public class VwCaseDurationEventsProcess : VwCaseDuration_OBSWEventsProcess
	{

		public VwCaseDurationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

