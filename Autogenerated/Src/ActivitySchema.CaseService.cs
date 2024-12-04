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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.Packages.Case;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_CaseService_TerrasoftSchema

	/// <exclude/>
	public class Activity_CaseService_TerrasoftSchema : Terrasoft.Configuration.Activity_CrtFinservApplication_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_CaseService_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_CaseService_TerrasoftSchema(Activity_CaseService_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_CaseService_TerrasoftSchema(Activity_CaseService_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Activity_SendDateIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("1e60c588-1264-4219-9f83-2a3e68bc54b6");
			index.Name = "IX_Activity_SendDate";
			index.CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed");
			EntitySchemaIndexColumn sendDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b8f4292f-5ae6-43ca-9685-1301b31eba68"),
				ColumnUId = new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc"),
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(sendDateIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateId_StartDate_Type_ShowInSchedIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("5616f33c-a275-4edb-a072-5264b6f7e077");
			index.Name = "Id_StartDate_Type_ShowInSched";
			index.CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			index.ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			index.CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			EntitySchemaIndexColumn showInSchedulerIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("9ba50dac-d3dd-57f3-3c2c-3ec8035c8b31"),
				ColumnUId = new Guid("ff2dec51-885c-428a-8e6a-80c0c14b1434"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(showInSchedulerIndexColumn);
			EntitySchemaIndexColumn startDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("dbd9d02a-031e-a4fa-1033-6b9f10122ca4"),
				ColumnUId = new Guid("a12ca538-61b1-4907-9fdf-01969163d4dd"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(startDateIndexColumn);
			EntitySchemaIndexColumn typeIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("1a9e19cd-0fbc-4a81-0d2b-741666da87e0"),
				ColumnUId = new Guid("5491c33f-e927-4ca8-a579-d4810ea54c56"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(typeIdIndexColumn);
			EntitySchemaIndexColumn idIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("cb359a7a-c5a6-6760-3d2e-d22eb2b0730a"),
				ColumnUId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(idIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60");
			Name = "Activity_CaseService_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a8b8271f-5617-41e0-bbb4-0ac43169bb55");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Activity_SendDateIndex());
			Indexes.Add(CreateId_StartDate_Type_ShowInSchedIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_CaseService_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_CaseServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_CaseService_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_CaseService_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CaseService_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_CaseService_Terrasoft : Terrasoft.Configuration.Activity_CrtFinservApplication_Terrasoft
	{

		#region Constructors: Public

		public Activity_CaseService_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_CaseService_Terrasoft";
		}

		public Activity_CaseService_Terrasoft(Activity_CaseService_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_CaseServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Updated += (s, e) => ThrowEvent("Activity_CaseService_TerrasoftUpdated", e);
			Updating += (s, e) => ThrowEvent("Activity_CaseService_TerrasoftUpdating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_CaseService_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CaseServiceEventsProcess

	/// <exclude/>
	public partial class Activity_CaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CrtFinservApplicationEventsProcess<TEntity> where TEntity : Activity_CaseService_Terrasoft
	{

		public Activity_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_CaseServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _activityUpdatingEventSubProcess1;
		public ProcessFlowElement ActivityUpdatingEventSubProcess1 {
			get {
				return _activityUpdatingEventSubProcess1 ?? (_activityUpdatingEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityUpdatingEventSubProcess1",
					SchemaElementUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityUpdatingStartMessage;
		public ProcessFlowElement ActivityUpdatingStartMessage {
			get {
				return _activityUpdatingStartMessage ?? (_activityUpdatingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityUpdatingStartMessage",
					SchemaElementUId = new Guid("5ec3f798-cf6f-4f34-b4f5-49252580c277"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityUpdatingScriptTask;
		public ProcessScriptTask ActivityUpdatingScriptTask {
			get {
				return _activityUpdatingScriptTask ?? (_activityUpdatingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityUpdatingScriptTask",
					SchemaElementUId = new Guid("8f3c45b6-4b5d-4023-88a1-0dc734deb856"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityUpdatingScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _activityInsertedStartMessageScriptTask;
		public ProcessScriptTask ActivityInsertedStartMessageScriptTask {
			get {
				return _activityInsertedStartMessageScriptTask ?? (_activityInsertedStartMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityInsertedStartMessageScriptTask",
					SchemaElementUId = new Guid("6d01caa4-acfe-44fc-8a73-fffb39bc00b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityInsertedStartMessageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _activityInsertedStartMessage;
		public ProcessFlowElement ActivityInsertedStartMessage {
			get {
				return _activityInsertedStartMessage ?? (_activityInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityInsertedStartMessage",
					SchemaElementUId = new Guid("b80714b7-fff6-48b5-9b95-4e88352fc1be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityUpdatedStartMessage;
		public ProcessFlowElement ActivityUpdatedStartMessage {
			get {
				return _activityUpdatedStartMessage ?? (_activityUpdatedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityUpdatedStartMessage",
					SchemaElementUId = new Guid("1f92bc7d-79dd-463b-abef-9632333ab2fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_27f6989e78934513b0eb72559cae0133;
		public ProcessScriptTask ScriptTask3_27f6989e78934513b0eb72559cae0133 {
			get {
				return _scriptTask3_27f6989e78934513b0eb72559cae0133 ?? (_scriptTask3_27f6989e78934513b0eb72559cae0133 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_27f6989e78934513b0eb72559cae0133",
					SchemaElementUId = new Guid("27f6989e-7893-4513-b0eb-72559cae0133"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_27f6989e78934513b0eb72559cae0133Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ActivityUpdatingEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatingEventSubProcess1 };
			FlowElements[ActivityUpdatingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatingStartMessage };
			FlowElements[ActivityUpdatingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatingScriptTask };
			FlowElements[ActivityInsertedStartMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInsertedStartMessageScriptTask };
			FlowElements[ActivityInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInsertedStartMessage };
			FlowElements[ActivityUpdatedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatedStartMessage };
			FlowElements[ScriptTask3_27f6989e78934513b0eb72559cae0133.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_27f6989e78934513b0eb72559cae0133 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ActivityUpdatingEventSubProcess1":
						break;
					case "ActivityUpdatingStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityUpdatingScriptTask");
						break;
					case "ActivityUpdatingScriptTask":
						break;
					case "ActivityInsertedStartMessageScriptTask":
						break;
					case "ActivityInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityInsertedStartMessageScriptTask");
						break;
					case "ActivityUpdatedStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask3_27f6989e78934513b0eb72559cae0133");
						break;
					case "ScriptTask3_27f6989e78934513b0eb72559cae0133":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityUpdatingStartMessage");
			ActivatedEventElements.Add("ActivityInsertedStartMessage");
			ActivatedEventElements.Add("ActivityUpdatedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ActivityUpdatingEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityUpdatingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityUpdatingStartMessage";
					result = ActivityUpdatingStartMessage.Execute(context);
					break;
				case "ActivityUpdatingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityUpdatingScriptTask";
					result = ActivityUpdatingScriptTask.Execute(context, ActivityUpdatingScriptTaskExecute);
					break;
				case "ActivityInsertedStartMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInsertedStartMessageScriptTask";
					result = ActivityInsertedStartMessageScriptTask.Execute(context, ActivityInsertedStartMessageScriptTaskExecute);
					break;
				case "ActivityInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInsertedStartMessage";
					result = ActivityInsertedStartMessage.Execute(context);
					break;
				case "ActivityUpdatedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityUpdatedStartMessage";
					result = ActivityUpdatedStartMessage.Execute(context);
					break;
				case "ScriptTask3_27f6989e78934513b0eb72559cae0133":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_27f6989e78934513b0eb72559cae0133";
					result = ScriptTask3_27f6989e78934513b0eb72559cae0133.Execute(context, ScriptTask3_27f6989e78934513b0eb72559cae0133Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ActivityUpdatingScriptTaskExecute(ProcessExecutingContext context) {
			var handler = ClassFactory.Get<ICaseServiceActivityEventsHandler>();
			handler.HandleActivityUpdating(Entity, UserConnection,
				UseCategoryFilter, IsRequiredFieldsValid, SetCaseCategory, JoinRecipients, GetRecipients);
			return true;
		}

		public virtual bool ActivityInsertedStartMessageScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("DisableEmbeddedCaseMessageHistoryListener")) { 
				var handler = ClassFactory.Get<ICaseServiceActivityEventsHandler>();
				handler.HandleActivityInserted(Entity, UserConnection, NotifyListeners);
			}
			return true;
		}

		public virtual bool ScriptTask3_27f6989e78934513b0eb72559cae0133Execute(ProcessExecutingContext context) {
			var handler = ClassFactory.Get<ICaseServiceActivityEventsHandler>();
			handler.HandleActivityUpdated(Entity, UserConnection, NotifyListeners);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Activity_CaseService_TerrasoftUpdating":
							if (ActivatedEventElements.Contains("ActivityUpdatingStartMessage")) {
							context.QueueTasks.Enqueue("ActivityUpdatingStartMessage");
						}
						break;
					case "ActivityInserted":
							if (ActivatedEventElements.Contains("ActivityInsertedStartMessage")) {
							context.QueueTasks.Enqueue("ActivityInsertedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Activity_CaseService_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("ActivityUpdatedStartMessage")) {
							context.QueueTasks.Enqueue("ActivityUpdatedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CaseServiceEventsProcess

	/// <exclude/>
	public class Activity_CaseServiceEventsProcess : Activity_CaseServiceEventsProcess<Activity_CaseService_Terrasoft>
	{

		public Activity_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

