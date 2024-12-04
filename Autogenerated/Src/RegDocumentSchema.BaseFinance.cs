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

	#region Class: RegDocumentSchema

	/// <exclude/>
	public class RegDocumentSchema : Terrasoft.Configuration.RegDocument_CrtFinservDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public RegDocumentSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RegDocumentSchema(RegDocumentSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RegDocumentSchema(RegDocumentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6c3d5b83-ef9d-4242-bd6c-ef3459bed7fe");
			Name = "RegDocument";
			ParentSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42");
			ExtendParent = true;
			CreatedInPackageId = new Guid("42c464a9-9677-4bbd-86c1-308caea3de84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
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
			return new RegDocument(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RegDocument_BaseFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RegDocumentSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RegDocumentSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c3d5b83-ef9d-4242-bd6c-ef3459bed7fe"));
		}

		#endregion

	}

	#endregion

	#region Class: RegDocument

	/// <summary>
	/// Registration document.
	/// </summary>
	public class RegDocument : Terrasoft.Configuration.RegDocument_CrtFinservDocument_Terrasoft
	{

		#region Constructors: Public

		public RegDocument(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RegDocument";
		}

		public RegDocument(RegDocument source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RegDocument_BaseFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RegDocumentDeleted", e);
			Deleting += (s, e) => ThrowEvent("RegDocumentDeleting", e);
			Inserted += (s, e) => ThrowEvent("RegDocumentInserted", e);
			Inserting += (s, e) => ThrowEvent("RegDocumentInserting", e);
			Saved += (s, e) => ThrowEvent("RegDocumentSaved", e);
			Saving += (s, e) => ThrowEvent("RegDocumentSaving", e);
			Validating += (s, e) => ThrowEvent("RegDocumentValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RegDocument(this);
		}

		#endregion

	}

	#endregion

	#region Class: RegDocument_BaseFinanceEventsProcess

	/// <exclude/>
	public partial class RegDocument_BaseFinanceEventsProcess<TEntity> : Terrasoft.Configuration.RegDocument_CrtFinservDocumentEventsProcess<TEntity> where TEntity : RegDocument
	{

		public RegDocument_BaseFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RegDocument_BaseFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6c3d5b83-ef9d-4242-bd6c-ef3459bed7fe");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4_dad33e4137864e48a82ca4f52d7933cf;
		public ProcessFlowElement EventSubProcess4_dad33e4137864e48a82ca4f52d7933cf {
			get {
				return _eventSubProcess4_dad33e4137864e48a82ca4f52d7933cf ?? (_eventSubProcess4_dad33e4137864e48a82ca4f52d7933cf = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_dad33e4137864e48a82ca4f52d7933cf",
					SchemaElementUId = new Guid("dad33e41-3786-4e48-a82c-a4f52d7933cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_c545237d3c94407790d8ad1c2aba8275;
		public ProcessFlowElement StartMessage4_c545237d3c94407790d8ad1c2aba8275 {
			get {
				return _startMessage4_c545237d3c94407790d8ad1c2aba8275 ?? (_startMessage4_c545237d3c94407790d8ad1c2aba8275 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_c545237d3c94407790d8ad1c2aba8275",
					SchemaElementUId = new Guid("c545237d-3c94-4077-90d8-ad1c2aba8275"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_47b075309d884126b942c7325011efff;
		public ProcessScriptTask ScriptTask3_47b075309d884126b942c7325011efff {
			get {
				return _scriptTask3_47b075309d884126b942c7325011efff ?? (_scriptTask3_47b075309d884126b942c7325011efff = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_47b075309d884126b942c7325011efff",
					SchemaElementUId = new Guid("47b07530-9d88-4126-b942-c7325011efff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_47b075309d884126b942c7325011efffExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_47ce6bb4903248188abcaa2ee027afe8;
		public ProcessFlowElement EventSubProcess5_47ce6bb4903248188abcaa2ee027afe8 {
			get {
				return _eventSubProcess5_47ce6bb4903248188abcaa2ee027afe8 ?? (_eventSubProcess5_47ce6bb4903248188abcaa2ee027afe8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_47ce6bb4903248188abcaa2ee027afe8",
					SchemaElementUId = new Guid("47ce6bb4-9032-4818-8abc-aa2ee027afe8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_dc3c15011ba943b8980cfe56763d6167;
		public ProcessFlowElement StartMessage5_dc3c15011ba943b8980cfe56763d6167 {
			get {
				return _startMessage5_dc3c15011ba943b8980cfe56763d6167 ?? (_startMessage5_dc3c15011ba943b8980cfe56763d6167 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_dc3c15011ba943b8980cfe56763d6167",
					SchemaElementUId = new Guid("dc3c1501-1ba9-43b8-980c-fe56763d6167"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_1b038afd58c0469483b5c96f02431e6f;
		public ProcessScriptTask ScriptTask4_1b038afd58c0469483b5c96f02431e6f {
			get {
				return _scriptTask4_1b038afd58c0469483b5c96f02431e6f ?? (_scriptTask4_1b038afd58c0469483b5c96f02431e6f = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_1b038afd58c0469483b5c96f02431e6f",
					SchemaElementUId = new Guid("1b038afd-58c0-4694-83b5-c96f02431e6f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_1b038afd58c0469483b5c96f02431e6fExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6_88d55dad319542468043ac071a877b8c;
		public ProcessFlowElement EventSubProcess6_88d55dad319542468043ac071a877b8c {
			get {
				return _eventSubProcess6_88d55dad319542468043ac071a877b8c ?? (_eventSubProcess6_88d55dad319542468043ac071a877b8c = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6_88d55dad319542468043ac071a877b8c",
					SchemaElementUId = new Guid("88d55dad-3195-4246-8043-ac071a877b8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6_724b38c627124fd7a0c83f02013d52b7;
		public ProcessFlowElement StartMessage6_724b38c627124fd7a0c83f02013d52b7 {
			get {
				return _startMessage6_724b38c627124fd7a0c83f02013d52b7 ?? (_startMessage6_724b38c627124fd7a0c83f02013d52b7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6_724b38c627124fd7a0c83f02013d52b7",
					SchemaElementUId = new Guid("724b38c6-2712-4fd7-a0c8-3f02013d52b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_9b0d83bfe37a4200a1110c3d5e727221;
		public ProcessScriptTask ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221 {
			get {
				return _scriptTask5_9b0d83bfe37a4200a1110c3d5e727221 ?? (_scriptTask5_9b0d83bfe37a4200a1110c3d5e727221 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221",
					SchemaElementUId = new Guid("9b0d83bf-e37a-4200-a111-0c3d5e727221"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4_dad33e4137864e48a82ca4f52d7933cf.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_dad33e4137864e48a82ca4f52d7933cf };
			FlowElements[StartMessage4_c545237d3c94407790d8ad1c2aba8275.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_c545237d3c94407790d8ad1c2aba8275 };
			FlowElements[ScriptTask3_47b075309d884126b942c7325011efff.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_47b075309d884126b942c7325011efff };
			FlowElements[EventSubProcess5_47ce6bb4903248188abcaa2ee027afe8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_47ce6bb4903248188abcaa2ee027afe8 };
			FlowElements[StartMessage5_dc3c15011ba943b8980cfe56763d6167.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_dc3c15011ba943b8980cfe56763d6167 };
			FlowElements[ScriptTask4_1b038afd58c0469483b5c96f02431e6f.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_1b038afd58c0469483b5c96f02431e6f };
			FlowElements[EventSubProcess6_88d55dad319542468043ac071a877b8c.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6_88d55dad319542468043ac071a877b8c };
			FlowElements[StartMessage6_724b38c627124fd7a0c83f02013d52b7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6_724b38c627124fd7a0c83f02013d52b7 };
			FlowElements[ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4_dad33e4137864e48a82ca4f52d7933cf":
						break;
					case "StartMessage4_c545237d3c94407790d8ad1c2aba8275":
						e.Context.QueueTasks.Enqueue("ScriptTask3_47b075309d884126b942c7325011efff");
						break;
					case "ScriptTask3_47b075309d884126b942c7325011efff":
						break;
					case "EventSubProcess5_47ce6bb4903248188abcaa2ee027afe8":
						break;
					case "StartMessage5_dc3c15011ba943b8980cfe56763d6167":
						e.Context.QueueTasks.Enqueue("ScriptTask4_1b038afd58c0469483b5c96f02431e6f");
						break;
					case "ScriptTask4_1b038afd58c0469483b5c96f02431e6f":
						break;
					case "EventSubProcess6_88d55dad319542468043ac071a877b8c":
						break;
					case "StartMessage6_724b38c627124fd7a0c83f02013d52b7":
						e.Context.QueueTasks.Enqueue("ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221");
						break;
					case "ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage4_c545237d3c94407790d8ad1c2aba8275");
			ActivatedEventElements.Add("StartMessage5_dc3c15011ba943b8980cfe56763d6167");
			ActivatedEventElements.Add("StartMessage6_724b38c627124fd7a0c83f02013d52b7");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4_dad33e4137864e48a82ca4f52d7933cf":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_c545237d3c94407790d8ad1c2aba8275":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_c545237d3c94407790d8ad1c2aba8275";
					result = StartMessage4_c545237d3c94407790d8ad1c2aba8275.Execute(context);
					break;
				case "ScriptTask3_47b075309d884126b942c7325011efff":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_47b075309d884126b942c7325011efff";
					result = ScriptTask3_47b075309d884126b942c7325011efff.Execute(context, ScriptTask3_47b075309d884126b942c7325011efffExecute);
					break;
				case "EventSubProcess5_47ce6bb4903248188abcaa2ee027afe8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_dc3c15011ba943b8980cfe56763d6167":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_dc3c15011ba943b8980cfe56763d6167";
					result = StartMessage5_dc3c15011ba943b8980cfe56763d6167.Execute(context);
					break;
				case "ScriptTask4_1b038afd58c0469483b5c96f02431e6f":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_1b038afd58c0469483b5c96f02431e6f";
					result = ScriptTask4_1b038afd58c0469483b5c96f02431e6f.Execute(context, ScriptTask4_1b038afd58c0469483b5c96f02431e6fExecute);
					break;
				case "EventSubProcess6_88d55dad319542468043ac071a877b8c":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6_724b38c627124fd7a0c83f02013d52b7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6_724b38c627124fd7a0c83f02013d52b7";
					result = StartMessage6_724b38c627124fd7a0c83f02013d52b7.Execute(context);
					break;
				case "ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221";
					result = ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221.Execute(context, ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_47b075309d884126b942c7325011efffExecute(ProcessExecutingContext context) {
			OnSaved();
			return true;
		}

		public virtual bool ScriptTask4_1b038afd58c0469483b5c96f02431e6fExecute(ProcessExecutingContext context) {
			OnDeleted();
			return true;
		}

		public virtual bool ScriptTask5_9b0d83bfe37a4200a1110c3d5e727221Execute(ProcessExecutingContext context) {
			OnSaving();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "RegDocumentSaved":
							if (ActivatedEventElements.Contains("StartMessage4_c545237d3c94407790d8ad1c2aba8275")) {
							context.QueueTasks.Enqueue("StartMessage4_c545237d3c94407790d8ad1c2aba8275");
							ProcessQueue(context);
							return;
						}
						break;
					case "RegDocumentDeleted":
							if (ActivatedEventElements.Contains("StartMessage5_dc3c15011ba943b8980cfe56763d6167")) {
							context.QueueTasks.Enqueue("StartMessage5_dc3c15011ba943b8980cfe56763d6167");
							ProcessQueue(context);
							return;
						}
						break;
					case "RegDocumentSaving":
							if (ActivatedEventElements.Contains("StartMessage6_724b38c627124fd7a0c83f02013d52b7")) {
							context.QueueTasks.Enqueue("StartMessage6_724b38c627124fd7a0c83f02013d52b7");
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

	#region Class: RegDocument_BaseFinanceEventsProcess

	/// <exclude/>
	public class RegDocument_BaseFinanceEventsProcess : RegDocument_BaseFinanceEventsProcess<RegDocument>
	{

		public RegDocument_BaseFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: RegDocumentEventsProcess

	/// <exclude/>
	public class RegDocumentEventsProcess : RegDocument_BaseFinanceEventsProcess
	{

		public RegDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

