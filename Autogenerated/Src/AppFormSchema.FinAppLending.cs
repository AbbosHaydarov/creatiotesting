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

	#region Class: AppFormSchema

	/// <exclude/>
	public class AppFormSchema : Terrasoft.Configuration.AppForm_CrtFinservApplication_TerrasoftSchema
	{

		#region Constructors: Public

		public AppFormSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormSchema(AppFormSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormSchema(AppFormSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("21153444-08b6-45c1-ac18-2bbb1af84f98");
			Name = "AppForm";
			ParentSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			ExtendParent = true;
			CreatedInPackageId = new Guid("979b8d33-1efb-406e-b9eb-bb1fd00a3c53");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppForm(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppForm_FinAppLendingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21153444-08b6-45c1-ac18-2bbb1af84f98"));
		}

		#endregion

	}

	#endregion

	#region Class: AppForm

	/// <summary>
	/// Application Form.
	/// </summary>
	public class AppForm : Terrasoft.Configuration.AppForm_CrtFinservApplication_Terrasoft
	{

		#region Constructors: Public

		public AppForm(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppForm";
		}

		public AppForm(AppForm source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppForm_FinAppLendingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormDeleted", e);
			Deleting += (s, e) => ThrowEvent("AppFormDeleting", e);
			Inserted += (s, e) => ThrowEvent("AppFormInserted", e);
			Inserting += (s, e) => ThrowEvent("AppFormInserting", e);
			Saved += (s, e) => ThrowEvent("AppFormSaved", e);
			Saving += (s, e) => ThrowEvent("AppFormSaving", e);
			Validating += (s, e) => ThrowEvent("AppFormValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppForm(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppForm_FinAppLendingEventsProcess

	/// <exclude/>
	public partial class AppForm_FinAppLendingEventsProcess<TEntity> : Terrasoft.Configuration.AppForm_CrtFinservApplicationEventsProcess<TEntity> where TEntity : AppForm
	{

		public AppForm_FinAppLendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppForm_FinAppLendingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("21153444-08b6-45c1-ac18-2bbb1af84f98");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_4da99b1642344545a1d34588522c0040;
		public ProcessFlowElement EventSubProcess3_4da99b1642344545a1d34588522c0040 {
			get {
				return _eventSubProcess3_4da99b1642344545a1d34588522c0040 ?? (_eventSubProcess3_4da99b1642344545a1d34588522c0040 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_4da99b1642344545a1d34588522c0040",
					SchemaElementUId = new Guid("4da99b16-4234-4545-a1d3-4588522c0040"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_e9300d42dbcb4e85bbcb854823b540e5;
		public ProcessFlowElement StartMessage3_e9300d42dbcb4e85bbcb854823b540e5 {
			get {
				return _startMessage3_e9300d42dbcb4e85bbcb854823b540e5 ?? (_startMessage3_e9300d42dbcb4e85bbcb854823b540e5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_e9300d42dbcb4e85bbcb854823b540e5",
					SchemaElementUId = new Guid("e9300d42-dbcb-4e85-bbcb-854823b540e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_84ec968ac8994c2ba08f7069acb3c86b;
		public ProcessScriptTask ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b {
			get {
				return _scriptTask3_84ec968ac8994c2ba08f7069acb3c86b ?? (_scriptTask3_84ec968ac8994c2ba08f7069acb3c86b = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b",
					SchemaElementUId = new Guid("84ec968a-c899-4c2b-a08f-7069acb3c86b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_84ec968ac8994c2ba08f7069acb3c86bExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_4da99b1642344545a1d34588522c0040.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_4da99b1642344545a1d34588522c0040 };
			FlowElements[StartMessage3_e9300d42dbcb4e85bbcb854823b540e5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_e9300d42dbcb4e85bbcb854823b540e5 };
			FlowElements[ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_4da99b1642344545a1d34588522c0040":
						break;
					case "StartMessage3_e9300d42dbcb4e85bbcb854823b540e5":
						e.Context.QueueTasks.Enqueue("ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b");
						break;
					case "ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_e9300d42dbcb4e85bbcb854823b540e5");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_4da99b1642344545a1d34588522c0040":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_e9300d42dbcb4e85bbcb854823b540e5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_e9300d42dbcb4e85bbcb854823b540e5";
					result = StartMessage3_e9300d42dbcb4e85bbcb854823b540e5.Execute(context);
					break;
				case "ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b";
					result = ScriptTask3_84ec968ac8994c2ba08f7069acb3c86b.Execute(context, ScriptTask3_84ec968ac8994c2ba08f7069acb3c86bExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_84ec968ac8994c2ba08f7069acb3c86bExecute(ProcessExecutingContext context) {
			OnAppFormSaving();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AppFormSaving":
							if (ActivatedEventElements.Contains("StartMessage3_e9300d42dbcb4e85bbcb854823b540e5")) {
							context.QueueTasks.Enqueue("StartMessage3_e9300d42dbcb4e85bbcb854823b540e5");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: AppForm_FinAppLendingEventsProcess

	/// <exclude/>
	public class AppForm_FinAppLendingEventsProcess : AppForm_FinAppLendingEventsProcess<AppForm>
	{

		public AppForm_FinAppLendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: AppFormEventsProcess

	/// <exclude/>
	public class AppFormEventsProcess : AppForm_FinAppLendingEventsProcess
	{

		public AppFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

