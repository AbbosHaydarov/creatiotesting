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

	#region Class: CopilotSessionEntSchema

	/// <exclude/>
	public class CopilotSessionEntSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CopilotSessionEntSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CopilotSessionEntSchema(CopilotSessionEntSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CopilotSessionEntSchema(CopilotSessionEntSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f");
			RealUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f");
			Name = "CopilotSessionEnt";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("80280dc8-3b2f-e5b5-53dc-e8da2d6d16d7")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("da8c4326-7e29-55fd-6813-0373d5c7685d")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("8021010c-43a5-1fcf-76a6-9f976de2029c")) == null) {
				Columns.Add(CreateUserColumn());
			}
			if (Columns.FindByUId(new Guid("537112a6-40f9-386d-5b75-223c9cca1b05")) == null) {
				Columns.Add(CreateStateColumn());
			}
			if (Columns.FindByUId(new Guid("b03ce89f-55c3-cf69-4256-6531284c0c9a")) == null) {
				Columns.Add(CreateCurrentIntentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("80280dc8-3b2f-e5b5-53dc-e8da2d6d16d7"),
				Name = @"EndDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				ModifiedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("da8c4326-7e29-55fd-6813-0373d5c7685d"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				ModifiedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e")
			};
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3d952249-a898-3800-db7c-05142d36778f"),
				Name = @"Title",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				ModifiedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Sequence,
					SequencePrefix = "",
					SequenceNumberOfChars = 5
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8021010c-43a5-1fcf-76a6-9f976de2029c"),
				Name = @"User",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				ModifiedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("537112a6-40f9-386d-5b75-223c9cca1b05"),
				Name = @"State",
				ReferenceSchemaUId = new Guid("79789d7f-8b37-4493-a2a9-59e18fab8058"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				ModifiedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentIntentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b03ce89f-55c3-cf69-4256-6531284c0c9a"),
				Name = @"CurrentIntent",
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				ModifiedInSchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"),
				CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CopilotSessionEnt(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CopilotSessionEnt_CrtCopilotEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CopilotSessionEntSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CopilotSessionEntSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f"));
		}

		#endregion

	}

	#endregion

	#region Class: CopilotSessionEnt

	/// <summary>
	/// Copilot session.
	/// </summary>
	public class CopilotSessionEnt : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CopilotSessionEnt(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CopilotSessionEnt";
		}

		public CopilotSessionEnt(CopilotSessionEnt source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// End.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Start.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <exclude/>
		public Guid UserId {
			get {
				return GetTypedColumnValue<Guid>("UserId");
			}
			set {
				SetColumnValue("UserId", value);
				_user = null;
			}
		}

		/// <exclude/>
		public string UserName {
			get {
				return GetTypedColumnValue<string>("UserName");
			}
			set {
				SetColumnValue("UserName", value);
				if (_user != null) {
					_user.Name = value;
				}
			}
		}

		private SysAdminUnit _user;
		/// <summary>
		/// User.
		/// </summary>
		public SysAdminUnit User {
			get {
				return _user ??
					(_user = LookupColumnEntities.GetEntity("User") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private CopilotSessionStateEnt _state;
		/// <summary>
		/// State.
		/// </summary>
		public CopilotSessionStateEnt State {
			get {
				return _state ??
					(_state = LookupColumnEntities.GetEntity("State") as CopilotSessionStateEnt);
			}
		}

		/// <exclude/>
		public Guid CurrentIntentId {
			get {
				return GetTypedColumnValue<Guid>("CurrentIntentId");
			}
			set {
				SetColumnValue("CurrentIntentId", value);
				_currentIntent = null;
			}
		}

		/// <exclude/>
		public string CurrentIntentCaption {
			get {
				return GetTypedColumnValue<string>("CurrentIntentCaption");
			}
			set {
				SetColumnValue("CurrentIntentCaption", value);
				if (_currentIntent != null) {
					_currentIntent.Caption = value;
				}
			}
		}

		private VwSysSchemaInfo _currentIntent;
		/// <summary>
		/// Current intent.
		/// </summary>
		public VwSysSchemaInfo CurrentIntent {
			get {
				return _currentIntent ??
					(_currentIntent = LookupColumnEntities.GetEntity("CurrentIntent") as VwSysSchemaInfo);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CopilotSessionEnt_CrtCopilotEventsProcess(UserConnection);
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
			return new CopilotSessionEnt(this);
		}

		#endregion

	}

	#endregion

	#region Class: CopilotSessionEnt_CrtCopilotEventsProcess

	/// <exclude/>
	public partial class CopilotSessionEnt_CrtCopilotEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CopilotSessionEnt
	{

		public CopilotSessionEnt_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CopilotSessionEnt_CrtCopilotEventsProcess";
			SchemaUId = new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b5e91b69-1cf7-456c-a553-76302e52f42f");
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

	#region Class: CopilotSessionEnt_CrtCopilotEventsProcess

	/// <exclude/>
	public class CopilotSessionEnt_CrtCopilotEventsProcess : CopilotSessionEnt_CrtCopilotEventsProcess<CopilotSessionEnt>
	{

		public CopilotSessionEnt_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CopilotSessionEnt_CrtCopilotEventsProcess

	public partial class CopilotSessionEnt_CrtCopilotEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CopilotSessionEntEventsProcess

	/// <exclude/>
	public class CopilotSessionEntEventsProcess : CopilotSessionEnt_CrtCopilotEventsProcess
	{

		public CopilotSessionEntEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

