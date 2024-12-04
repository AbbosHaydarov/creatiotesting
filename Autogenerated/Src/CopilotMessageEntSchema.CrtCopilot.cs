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

	#region Class: CopilotMessageEntSchema

	/// <exclude/>
	public class CopilotMessageEntSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CopilotMessageEntSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CopilotMessageEntSchema(CopilotMessageEntSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CopilotMessageEntSchema(CopilotMessageEntSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a");
			RealUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a");
			Name = "CopilotMessageEnt";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("189620e3-cecb-64b1-963e-061f764bdfa8")) == null) {
				Columns.Add(CreateToolCallIdColumn());
			}
			if (Columns.FindByUId(new Guid("f100144e-3028-59e1-57e0-69347d471c3e")) == null) {
				Columns.Add(CreateRoleColumn());
			}
			if (Columns.FindByUId(new Guid("d3eab9a1-1032-12d6-f591-1f63fb8a267f")) == null) {
				Columns.Add(CreateContentColumn());
			}
			if (Columns.FindByUId(new Guid("680c2c8c-f74f-8c26-91d9-5de4670a5aef")) == null) {
				Columns.Add(CreateCopilotSessionColumn());
			}
			if (Columns.FindByUId(new Guid("e66fba18-ba06-1679-8b64-93bea7a6b639")) == null) {
				Columns.Add(CreateIntentColumn());
			}
			if (Columns.FindByUId(new Guid("093c5917-f943-7c1c-7b75-e7b59a180023")) == null) {
				Columns.Add(CreateCopilotRequestColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateToolCallIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("189620e3-cecb-64b1-963e-061f764bdfa8"),
				Name = @"ToolCallId",
				CreatedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				ModifiedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f100144e-3028-59e1-57e0-69347d471c3e"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("0b692a14-a874-4feb-848d-5efa3b022184"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				ModifiedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateContentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d3eab9a1-1032-12d6-f591-1f63fb8a267f"),
				Name = @"Content",
				CreatedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				ModifiedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateCopilotSessionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("680c2c8c-f74f-8c26-91d9-5de4670a5aef"),
				Name = @"CopilotSession",
				ReferenceSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				ModifiedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e")
			};
		}

		protected virtual EntitySchemaColumn CreateIntentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e66fba18-ba06-1679-8b64-93bea7a6b639"),
				Name = @"Intent",
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				ModifiedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e")
			};
		}

		protected virtual EntitySchemaColumn CreateCopilotRequestColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("093c5917-f943-7c1c-7b75-e7b59a180023"),
				Name = @"CopilotRequest",
				ReferenceSchemaUId = new Guid("b846aaa6-f2d5-4146-9fc0-606dfd041b5e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				ModifiedInSchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"),
				CreatedInPackageId = new Guid("bad99159-33f2-43af-aab2-3508b9685277"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CopilotMessageEnt(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CopilotMessageEnt_CrtCopilotEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CopilotMessageEntSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CopilotMessageEntSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a"));
		}

		#endregion

	}

	#endregion

	#region Class: CopilotMessageEnt

	/// <summary>
	/// Copilot message.
	/// </summary>
	public class CopilotMessageEnt : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CopilotMessageEnt(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CopilotMessageEnt";
		}

		public CopilotMessageEnt(CopilotMessageEnt source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// ToolCall identifier.
		/// </summary>
		public string ToolCallId {
			get {
				return GetTypedColumnValue<string>("ToolCallId");
			}
			set {
				SetColumnValue("ToolCallId", value);
			}
		}

		/// <exclude/>
		public Guid RoleId {
			get {
				return GetTypedColumnValue<Guid>("RoleId");
			}
			set {
				SetColumnValue("RoleId", value);
				_role = null;
			}
		}

		/// <exclude/>
		public string RoleName {
			get {
				return GetTypedColumnValue<string>("RoleName");
			}
			set {
				SetColumnValue("RoleName", value);
				if (_role != null) {
					_role.Name = value;
				}
			}
		}

		private CopilotMessageRoleEnt _role;
		/// <summary>
		/// Role.
		/// </summary>
		public CopilotMessageRoleEnt Role {
			get {
				return _role ??
					(_role = LookupColumnEntities.GetEntity("Role") as CopilotMessageRoleEnt);
			}
		}

		/// <summary>
		/// Content.
		/// </summary>
		public string Content {
			get {
				return GetTypedColumnValue<string>("Content");
			}
			set {
				SetColumnValue("Content", value);
			}
		}

		/// <exclude/>
		public Guid CopilotSessionId {
			get {
				return GetTypedColumnValue<Guid>("CopilotSessionId");
			}
			set {
				SetColumnValue("CopilotSessionId", value);
				_copilotSession = null;
			}
		}

		/// <exclude/>
		public string CopilotSessionTitle {
			get {
				return GetTypedColumnValue<string>("CopilotSessionTitle");
			}
			set {
				SetColumnValue("CopilotSessionTitle", value);
				if (_copilotSession != null) {
					_copilotSession.Title = value;
				}
			}
		}

		private CopilotSessionEnt _copilotSession;
		/// <summary>
		/// Copilot Session.
		/// </summary>
		public CopilotSessionEnt CopilotSession {
			get {
				return _copilotSession ??
					(_copilotSession = LookupColumnEntities.GetEntity("CopilotSession") as CopilotSessionEnt);
			}
		}

		/// <exclude/>
		public Guid IntentId {
			get {
				return GetTypedColumnValue<Guid>("IntentId");
			}
			set {
				SetColumnValue("IntentId", value);
				_intent = null;
			}
		}

		/// <exclude/>
		public string IntentCaption {
			get {
				return GetTypedColumnValue<string>("IntentCaption");
			}
			set {
				SetColumnValue("IntentCaption", value);
				if (_intent != null) {
					_intent.Caption = value;
				}
			}
		}

		private VwSysSchemaInfo _intent;
		/// <summary>
		/// Intent.
		/// </summary>
		public VwSysSchemaInfo Intent {
			get {
				return _intent ??
					(_intent = LookupColumnEntities.GetEntity("Intent") as VwSysSchemaInfo);
			}
		}

		/// <exclude/>
		public Guid CopilotRequestId {
			get {
				return GetTypedColumnValue<Guid>("CopilotRequestId");
			}
			set {
				SetColumnValue("CopilotRequestId", value);
				_copilotRequest = null;
			}
		}

		private CopilotRequestEnt _copilotRequest;
		/// <summary>
		/// Copilot Request.
		/// </summary>
		/// <remarks>
		/// Copilot Request.
		/// </remarks>
		public CopilotRequestEnt CopilotRequest {
			get {
				return _copilotRequest ??
					(_copilotRequest = LookupColumnEntities.GetEntity("CopilotRequest") as CopilotRequestEnt);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CopilotMessageEnt_CrtCopilotEventsProcess(UserConnection);
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
			return new CopilotMessageEnt(this);
		}

		#endregion

	}

	#endregion

	#region Class: CopilotMessageEnt_CrtCopilotEventsProcess

	/// <exclude/>
	public partial class CopilotMessageEnt_CrtCopilotEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CopilotMessageEnt
	{

		public CopilotMessageEnt_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CopilotMessageEnt_CrtCopilotEventsProcess";
			SchemaUId = new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("427e6cd6-9696-4887-a905-5cfc48217c0a");
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

	#region Class: CopilotMessageEnt_CrtCopilotEventsProcess

	/// <exclude/>
	public class CopilotMessageEnt_CrtCopilotEventsProcess : CopilotMessageEnt_CrtCopilotEventsProcess<CopilotMessageEnt>
	{

		public CopilotMessageEnt_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CopilotMessageEnt_CrtCopilotEventsProcess

	public partial class CopilotMessageEnt_CrtCopilotEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CopilotMessageEntEventsProcess

	/// <exclude/>
	public class CopilotMessageEntEventsProcess : CopilotMessageEnt_CrtCopilotEventsProcess
	{

		public CopilotMessageEntEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

