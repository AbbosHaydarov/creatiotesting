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

	#region Class: VwDcmStagedObjectSchema

	/// <exclude/>
	public class VwDcmStagedObjectSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public VwDcmStagedObjectSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwDcmStagedObjectSchema(VwDcmStagedObjectSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwDcmStagedObjectSchema(VwDcmStagedObjectSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935");
			RealUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935");
			Name = "VwDcmStagedObject";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a86a0a4d-5107-4380-8110-b24f3ed097f6");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ba2177e7-6a5c-ce1b-8945-e5bdae574409")) == null) {
				Columns.Add(CreateUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ba2177e7-6a5c-ce1b-8945-e5bdae574409"),
				Name = @"UId",
				CreatedInSchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"),
				ModifiedInSchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"),
				CreatedInPackageId = new Guid("a86a0a4d-5107-4380-8110-b24f3ed097f6")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("24345f7a-9ba4-4288-f151-a9d44c79a0a9"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"),
				ModifiedInSchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"),
				CreatedInPackageId = new Guid("a86a0a4d-5107-4380-8110-b24f3ed097f6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("fe158e51-a76f-539d-4b8c-0a37cde3a65a"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"),
				ModifiedInSchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"),
				CreatedInPackageId = new Guid("a86a0a4d-5107-4380-8110-b24f3ed097f6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwDcmStagedObject(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwDcmStagedObject_CrtPlaybookEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwDcmStagedObjectSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwDcmStagedObjectSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"));
		}

		#endregion

	}

	#endregion

	#region Class: VwDcmStagedObject

	/// <summary>
	/// VwDcmStagedObject.
	/// </summary>
	public class VwDcmStagedObject : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwDcmStagedObject(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwDcmStagedObject";
		}

		public VwDcmStagedObject(VwDcmStagedObject source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SysSchema UId.
		/// </summary>
		public Guid UId {
			get {
				return GetTypedColumnValue<Guid>("UId");
			}
			set {
				SetColumnValue("UId", value);
			}
		}

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwDcmStagedObject_CrtPlaybookEventsProcess(UserConnection);
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
			return new VwDcmStagedObject(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwDcmStagedObject_CrtPlaybookEventsProcess

	/// <exclude/>
	public partial class VwDcmStagedObject_CrtPlaybookEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : VwDcmStagedObject
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

		public VwDcmStagedObject_CrtPlaybookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwDcmStagedObject_CrtPlaybookEventsProcess";
			SchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935");
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

	#region Class: VwDcmStagedObject_CrtPlaybookEventsProcess

	/// <exclude/>
	public class VwDcmStagedObject_CrtPlaybookEventsProcess : VwDcmStagedObject_CrtPlaybookEventsProcess<VwDcmStagedObject>
	{

		public VwDcmStagedObject_CrtPlaybookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwDcmStagedObject_CrtPlaybookEventsProcess

	public partial class VwDcmStagedObject_CrtPlaybookEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwDcmStagedObjectEventsProcess

	/// <exclude/>
	public class VwDcmStagedObjectEventsProcess : VwDcmStagedObject_CrtPlaybookEventsProcess
	{

		public VwDcmStagedObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

