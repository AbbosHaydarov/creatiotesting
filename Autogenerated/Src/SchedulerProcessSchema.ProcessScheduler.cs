namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Quartz;
	using Quartz.Collection;
	using Quartz.Impl;
	using Quartz.Impl.Triggers;
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
	using Terrasoft.Core.Scheduler;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SchedulerProcessSchema

	/// <exclude/>
	public class SchedulerProcessSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SchedulerProcessSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SchedulerProcessSchema(SchedulerProcessSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SchedulerProcessSchema(SchedulerProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a");
			RealUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a");
			Name = "SchedulerProcess";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3e194c97-e54f-44fb-905a-ee29891f4f0a");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d6b59852-b6f9-4e91-aae6-09b690e17bdc")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("a65ac81e-f852-4d57-a829-f252b48e0300")) == null) {
				Columns.Add(CreateSysEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("ff52d5df-a23e-4d03-8d9c-d72c9e5a91fd")) == null) {
				Columns.Add(CreateSchedulerExpressionColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a");
			return column;
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d6b59852-b6f9-4e91-aae6-09b690e17bdc"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a"),
				ModifiedInSchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a"),
				CreatedInPackageId = new Guid("3e194c97-e54f-44fb-905a-ee29891f4f0a"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("a65ac81e-f852-4d57-a829-f252b48e0300"),
				Name = @"SysEntitySchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a"),
				ModifiedInSchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a"),
				CreatedInPackageId = new Guid("3e194c97-e54f-44fb-905a-ee29891f4f0a")
			};
		}

		protected virtual EntitySchemaColumn CreateSchedulerExpressionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ff52d5df-a23e-4d03-8d9c-d72c9e5a91fd"),
				Name = @"SchedulerExpression",
				ReferenceSchemaUId = new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a"),
				ModifiedInSchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a"),
				CreatedInPackageId = new Guid("3e194c97-e54f-44fb-905a-ee29891f4f0a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SchedulerProcess(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SchedulerProcess_ProcessSchedulerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SchedulerProcessSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SchedulerProcessSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("279694af-2175-488c-9d11-765baa2f0c4a"));
		}

		#endregion

	}

	#endregion

	#region Class: SchedulerProcess

	/// <summary>
	/// Calendar.
	/// </summary>
	public class SchedulerProcess : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SchedulerProcess(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SchedulerProcess";
		}

		public SchedulerProcess(SchedulerProcess source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Active.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		/// <summary>
		/// Process schema identifier.
		/// </summary>
		public Guid SysEntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaUId");
			}
			set {
				SetColumnValue("SysEntitySchemaUId", value);
			}
		}

		/// <exclude/>
		public Guid SchedulerExpressionId {
			get {
				return GetTypedColumnValue<Guid>("SchedulerExpressionId");
			}
			set {
				SetColumnValue("SchedulerExpressionId", value);
				_schedulerExpression = null;
			}
		}

		/// <exclude/>
		public string SchedulerExpressionName {
			get {
				return GetTypedColumnValue<string>("SchedulerExpressionName");
			}
			set {
				SetColumnValue("SchedulerExpressionName", value);
				if (_schedulerExpression != null) {
					_schedulerExpression.Name = value;
				}
			}
		}

		private SchedulerExpression _schedulerExpression;
		/// <summary>
		/// Expression.
		/// </summary>
		public SchedulerExpression SchedulerExpression {
			get {
				return _schedulerExpression ??
					(_schedulerExpression = LookupColumnEntities.GetEntity("SchedulerExpression") as SchedulerExpression);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SchedulerProcess_ProcessSchedulerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SchedulerProcessDeleted", e);
			Deleting += (s, e) => ThrowEvent("SchedulerProcessDeleting", e);
			Saved += (s, e) => ThrowEvent("SchedulerProcessSaved", e);
			Validating += (s, e) => ThrowEvent("SchedulerProcessValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SchedulerProcess(this);
		}

		#endregion

	}

	#endregion

	#region Class: SchedulerProcess_ProcessSchedulerEventsProcess

	/// <exclude/>
	public partial class SchedulerProcess_ProcessSchedulerEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : SchedulerProcess
	{

		public SchedulerProcess_ProcessSchedulerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SchedulerProcess_ProcessSchedulerEventsProcess";
			SchemaUId = new Guid("279694af-2175-488c-9d11-765baa2f0c4a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("279694af-2175-488c-9d11-765baa2f0c4a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("50edeee1-426d-4636-b174-e362b98e2a28"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _schedulerProcessSavedStartMessage;
		public ProcessFlowElement SchedulerProcessSavedStartMessage {
			get {
				return _schedulerProcessSavedStartMessage ?? (_schedulerProcessSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SchedulerProcessSavedStartMessage",
					SchemaElementUId = new Guid("3fc08aa7-f874-4487-b3c0-3ccb9c080be1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _schedulerProcessSavedScriptTask;
		public ProcessScriptTask SchedulerProcessSavedScriptTask {
			get {
				return _schedulerProcessSavedScriptTask ?? (_schedulerProcessSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SchedulerProcessSavedScriptTask",
					SchemaElementUId = new Guid("a89c6fe2-3791-47db-ac81-ad2bac6a6c9d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SchedulerProcessSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("68c8c01f-cf85-4d41-8d62-97b6330eba11"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _schedulerProcessDeletingStartMessage;
		public ProcessFlowElement SchedulerProcessDeletingStartMessage {
			get {
				return _schedulerProcessDeletingStartMessage ?? (_schedulerProcessDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SchedulerProcessDeletingStartMessage",
					SchemaElementUId = new Guid("63ec93c5-5626-44b1-9468-a19825e2664f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _schedulerProcessDeletingScriptTask;
		public ProcessScriptTask SchedulerProcessDeletingScriptTask {
			get {
				return _schedulerProcessDeletingScriptTask ?? (_schedulerProcessDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SchedulerProcessDeletingScriptTask",
					SchemaElementUId = new Guid("3cd143d3-f948-42ba-bc1c-46d236c407fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SchedulerProcessDeletingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SchedulerProcessSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SchedulerProcessSavedStartMessage };
			FlowElements[SchedulerProcessSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SchedulerProcessSavedScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SchedulerProcessDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SchedulerProcessDeletingStartMessage };
			FlowElements[SchedulerProcessDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SchedulerProcessDeletingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SchedulerProcessSavedStartMessage":
						e.Context.QueueTasks.Enqueue("SchedulerProcessSavedScriptTask");
						break;
					case "SchedulerProcessSavedScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "SchedulerProcessDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("SchedulerProcessDeletingScriptTask");
						break;
					case "SchedulerProcessDeletingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SchedulerProcessSavedStartMessage");
			ActivatedEventElements.Add("SchedulerProcessDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SchedulerProcessSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SchedulerProcessSavedStartMessage";
					result = SchedulerProcessSavedStartMessage.Execute(context);
					break;
				case "SchedulerProcessSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SchedulerProcessSavedScriptTask";
					result = SchedulerProcessSavedScriptTask.Execute(context, SchedulerProcessSavedScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SchedulerProcessDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SchedulerProcessDeletingStartMessage";
					result = SchedulerProcessDeletingStartMessage.Execute(context);
					break;
				case "SchedulerProcessDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SchedulerProcessDeletingScriptTask";
					result = SchedulerProcessDeletingScriptTask.Execute(context, SchedulerProcessDeletingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool SchedulerProcessSavedScriptTaskExecute(ProcessExecutingContext context) {
			SchedulerProcess schedule = (SchedulerProcess)Entity;
			VwSysSchemaInfo vwSysSchemaInfo = GetVwSysSchemaInfo(schedule);
			string jobName = vwSysSchemaInfo.Name + "_" + schedule.Id;
			if (!schedule.Active) {
				AppScheduler.RemoveJob(jobName + "Job", jobName + "Group");
				return true;
			}
			IJobDetail job = AppScheduler.CreateProcessJob(jobName + "Job", jobName + "Group", vwSysSchemaInfo.Name,
				UserConnection.Workspace.Name, UserConnection.CurrentUser.Name);
			if (!schedule.SchedulerExpression.FetchFromDB("Id", schedule.SchedulerExpressionId, new List<string> {"Expression"})) {
				return true;
			}
			CronTriggerImpl trigger = new CronTriggerImpl(jobName + "Trigger",
				jobName + "Group", schedule.SchedulerExpression.Expression);
			var triggers = new Quartz.Collection.HashSet<ITrigger> {trigger};
			AppScheduler.Instance.ScheduleJob(job, triggers, true);
			return true;
		}

		public virtual bool SchedulerProcessDeletingScriptTaskExecute(ProcessExecutingContext context) {
			SchedulerProcess schedule = (SchedulerProcess)Entity;
			VwSysSchemaInfo vwSysSchemaInfo = GetVwSysSchemaInfo(schedule);
			string jobName = vwSysSchemaInfo.Name + "_" + schedule.Id;
			AppScheduler.RemoveJob(jobName + "Job", jobName + "Group");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SchedulerProcessSaved":
							if (ActivatedEventElements.Contains("SchedulerProcessSavedStartMessage")) {
							context.QueueTasks.Enqueue("SchedulerProcessSavedStartMessage");
						}
						break;
					case "SchedulerProcessDeleting":
							if (ActivatedEventElements.Contains("SchedulerProcessDeletingStartMessage")) {
							context.QueueTasks.Enqueue("SchedulerProcessDeletingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: SchedulerProcess_ProcessSchedulerEventsProcess

	/// <exclude/>
	public class SchedulerProcess_ProcessSchedulerEventsProcess : SchedulerProcess_ProcessSchedulerEventsProcess<SchedulerProcess>
	{

		public SchedulerProcess_ProcessSchedulerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SchedulerProcess_ProcessSchedulerEventsProcess

	public partial class SchedulerProcess_ProcessSchedulerEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual VwSysSchemaInfo GetVwSysSchemaInfo(SchedulerProcess entity) {
			SchedulerProcess schedule = (SchedulerProcess)entity;
			var conditions = new Dictionary<string, object>() {
				{ "UId", entity.SysEntitySchemaUId },
				{ "SysWorkspace", UserConnection.Workspace.Id }
			};
			var vwSysSchemaInfo = new VwSysSchemaInfo(UserConnection);
			if (!vwSysSchemaInfo.FetchFromDB(conditions)) {
				return null;
			}
			return vwSysSchemaInfo;
		}

		#endregion

	}

	#endregion


	#region Class: SchedulerProcessEventsProcess

	/// <exclude/>
	public class SchedulerProcessEventsProcess : SchedulerProcess_ProcessSchedulerEventsProcess
	{

		public SchedulerProcessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

