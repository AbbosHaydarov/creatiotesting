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
	using Terrasoft.Configuration;
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

	#region Class: FinApplicationSpecSchema

	/// <exclude/>
	public class FinApplicationSpecSchema : Terrasoft.Configuration.FinApplicationSpec_CrtFinservApplication_TerrasoftSchema
	{

		#region Constructors: Public

		public FinApplicationSpecSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationSpecSchema(FinApplicationSpecSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationSpecSchema(FinApplicationSpecSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("aee6b53f-fdbe-4dd8-971b-43fdcce0f431");
			Name = "FinApplicationSpec";
			ParentSchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a93b7107-48fd-44f4-bf18-0f14a4577cc4");
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
			return new FinApplicationSpec(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplicationSpec_FinApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationSpecSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationSpecSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aee6b53f-fdbe-4dd8-971b-43fdcce0f431"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationSpec

	/// <summary>
	/// Application parameters.
	/// </summary>
	public class FinApplicationSpec : Terrasoft.Configuration.FinApplicationSpec_CrtFinservApplication_Terrasoft
	{

		#region Constructors: Public

		public FinApplicationSpec(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationSpec";
		}

		public FinApplicationSpec(FinApplicationSpec source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplicationSpec_FinApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinApplicationSpecDeleted", e);
			Deleting += (s, e) => ThrowEvent("FinApplicationSpecDeleting", e);
			Inserted += (s, e) => ThrowEvent("FinApplicationSpecInserted", e);
			Inserting += (s, e) => ThrowEvent("FinApplicationSpecInserting", e);
			Saved += (s, e) => ThrowEvent("FinApplicationSpecSaved", e);
			Saving += (s, e) => ThrowEvent("FinApplicationSpecSaving", e);
			Validating += (s, e) => ThrowEvent("FinApplicationSpecValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinApplicationSpec(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationSpec_FinApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplicationSpec_FinApplicationEventsProcess<TEntity> : Terrasoft.Configuration.FinApplicationSpec_CrtFinservApplicationEventsProcess<TEntity> where TEntity : FinApplicationSpec
	{

		public FinApplicationSpec_FinApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplicationSpec_FinApplicationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("aee6b53f-fdbe-4dd8-971b-43fdcce0f431");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23;
		public ProcessFlowElement EventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23 {
			get {
				return _eventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23 ?? (_eventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23",
					SchemaElementUId = new Guid("83fa0a0c-2e08-4efe-9f4c-2743c560ed23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_7fb94ec2ee524b81adebecee523bc00b;
		public ProcessFlowElement StartMessage4_7fb94ec2ee524b81adebecee523bc00b {
			get {
				return _startMessage4_7fb94ec2ee524b81adebecee523bc00b ?? (_startMessage4_7fb94ec2ee524b81adebecee523bc00b = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_7fb94ec2ee524b81adebecee523bc00b",
					SchemaElementUId = new Guid("7fb94ec2-ee52-4b81-adeb-ecee523bc00b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7;
		public ProcessScriptTask ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7 {
			get {
				return _scriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7 ?? (_scriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7",
					SchemaElementUId = new Guid("36815a9a-89e3-4877-af1c-c0dbc3d9b1f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23 };
			FlowElements[StartMessage4_7fb94ec2ee524b81adebecee523bc00b.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_7fb94ec2ee524b81adebecee523bc00b };
			FlowElements[ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23":
						break;
					case "StartMessage4_7fb94ec2ee524b81adebecee523bc00b":
						e.Context.QueueTasks.Enqueue("ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7");
						break;
					case "ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage4_7fb94ec2ee524b81adebecee523bc00b");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4_83fa0a0c2e084efe9f4c2743c560ed23":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_7fb94ec2ee524b81adebecee523bc00b":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_7fb94ec2ee524b81adebecee523bc00b";
					result = StartMessage4_7fb94ec2ee524b81adebecee523bc00b.Execute(context);
					break;
				case "ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7";
					result = ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7.Execute(context, ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask4_36815a9a89e34877af1cc0dbc3d9b1f7Execute(ProcessExecutingContext context) {
			FillDisplayValue();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "FinApplicationSpecSaving":
							if (ActivatedEventElements.Contains("StartMessage4_7fb94ec2ee524b81adebecee523bc00b")) {
							context.QueueTasks.Enqueue("StartMessage4_7fb94ec2ee524b81adebecee523bc00b");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationSpec_FinApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationSpec_FinApplicationEventsProcess : FinApplicationSpec_FinApplicationEventsProcess<FinApplicationSpec>
	{

		public FinApplicationSpec_FinApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: FinApplicationSpecEventsProcess

	/// <exclude/>
	public class FinApplicationSpecEventsProcess : FinApplicationSpec_FinApplicationEventsProcess
	{

		public FinApplicationSpecEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

