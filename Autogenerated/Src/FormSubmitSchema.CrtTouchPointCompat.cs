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

	#region Class: FormSubmit_CrtTouchPointCompat_TerrasoftSchema

	/// <exclude/>
	public class FormSubmit_CrtTouchPointCompat_TerrasoftSchema : Terrasoft.Configuration.FormSubmit_CrtTouchInWebForm_TerrasoftSchema
	{

		#region Constructors: Public

		public FormSubmit_CrtTouchPointCompat_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmit_CrtTouchPointCompat_TerrasoftSchema(FormSubmit_CrtTouchPointCompat_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmit_CrtTouchPointCompat_TerrasoftSchema(FormSubmit_CrtTouchPointCompat_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0ff5130c-aa9f-466c-9a3c-cc9bbd8aa3bc");
			Name = "FormSubmit_CrtTouchPointCompat_Terrasoft";
			ParentSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			ExtendParent = true;
			CreatedInPackageId = new Guid("87510823-55b1-4e34-9258-45f3340e2dda");
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
			return new FormSubmit_CrtTouchPointCompat_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtTouchPointCompatEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmit_CrtTouchPointCompat_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmit_CrtTouchPointCompat_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ff5130c-aa9f-466c-9a3c-cc9bbd8aa3bc"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtTouchPointCompat_Terrasoft

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit_CrtTouchPointCompat_Terrasoft : Terrasoft.Configuration.FormSubmit_CrtTouchInWebForm_Terrasoft
	{

		#region Constructors: Public

		public FormSubmit_CrtTouchPointCompat_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit_CrtTouchPointCompat_Terrasoft";
		}

		public FormSubmit_CrtTouchPointCompat_Terrasoft(FormSubmit_CrtTouchPointCompat_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtTouchPointCompatEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("FormSubmit_CrtTouchPointCompat_TerrasoftInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FormSubmit_CrtTouchPointCompat_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtTouchPointCompatEventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtTouchPointCompatEventsProcess<TEntity> : Terrasoft.Configuration.FormSubmit_CrtTouchInWebFormEventsProcess<TEntity> where TEntity : FormSubmit_CrtTouchPointCompat_Terrasoft
	{

		public FormSubmit_CrtTouchPointCompatEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtTouchPointCompatEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0ff5130c-aa9f-466c-9a3c-cc9bbd8aa3bc");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4_3abedf87a4c749739d8761f88d906db9;
		public ProcessFlowElement EventSubProcess4_3abedf87a4c749739d8761f88d906db9 {
			get {
				return _eventSubProcess4_3abedf87a4c749739d8761f88d906db9 ?? (_eventSubProcess4_3abedf87a4c749739d8761f88d906db9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_3abedf87a4c749739d8761f88d906db9",
					SchemaElementUId = new Guid("3abedf87-a4c7-4973-9d87-61f88d906db9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_683edc097d594031b5f56a7130a9619f;
		public ProcessFlowElement StartMessage4_683edc097d594031b5f56a7130a9619f {
			get {
				return _startMessage4_683edc097d594031b5f56a7130a9619f ?? (_startMessage4_683edc097d594031b5f56a7130a9619f = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_683edc097d594031b5f56a7130a9619f",
					SchemaElementUId = new Guid("683edc09-7d59-4031-b5f5-6a7130a9619f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_3e825201a4a14b99b801c055043e3a23;
		public ProcessScriptTask ScriptTask4_3e825201a4a14b99b801c055043e3a23 {
			get {
				return _scriptTask4_3e825201a4a14b99b801c055043e3a23 ?? (_scriptTask4_3e825201a4a14b99b801c055043e3a23 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_3e825201a4a14b99b801c055043e3a23",
					SchemaElementUId = new Guid("3e825201-a4a1-4b99-b801-c055043e3a23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_3e825201a4a14b99b801c055043e3a23Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4_3abedf87a4c749739d8761f88d906db9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_3abedf87a4c749739d8761f88d906db9 };
			FlowElements[StartMessage4_683edc097d594031b5f56a7130a9619f.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_683edc097d594031b5f56a7130a9619f };
			FlowElements[ScriptTask4_3e825201a4a14b99b801c055043e3a23.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_3e825201a4a14b99b801c055043e3a23 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4_3abedf87a4c749739d8761f88d906db9":
						break;
					case "StartMessage4_683edc097d594031b5f56a7130a9619f":
						e.Context.QueueTasks.Enqueue("ScriptTask4_3e825201a4a14b99b801c055043e3a23");
						break;
					case "ScriptTask4_3e825201a4a14b99b801c055043e3a23":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage4_683edc097d594031b5f56a7130a9619f");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4_3abedf87a4c749739d8761f88d906db9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_683edc097d594031b5f56a7130a9619f":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_683edc097d594031b5f56a7130a9619f";
					result = StartMessage4_683edc097d594031b5f56a7130a9619f.Execute(context);
					break;
				case "ScriptTask4_3e825201a4a14b99b801c055043e3a23":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_3e825201a4a14b99b801c055043e3a23";
					result = ScriptTask4_3e825201a4a14b99b801c055043e3a23.Execute(context, ScriptTask4_3e825201a4a14b99b801c055043e3a23Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask4_3e825201a4a14b99b801c055043e3a23Execute(ProcessExecutingContext context) {
			FormSubmitInserting();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "FormSubmit_CrtTouchPointCompat_TerrasoftInserting":
							if (ActivatedEventElements.Contains("StartMessage4_683edc097d594031b5f56a7130a9619f")) {
							context.QueueTasks.Enqueue("StartMessage4_683edc097d594031b5f56a7130a9619f");
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

	#region Class: FormSubmit_CrtTouchPointCompatEventsProcess

	/// <exclude/>
	public class FormSubmit_CrtTouchPointCompatEventsProcess : FormSubmit_CrtTouchPointCompatEventsProcess<FormSubmit_CrtTouchPointCompat_Terrasoft>
	{

		public FormSubmit_CrtTouchPointCompatEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

