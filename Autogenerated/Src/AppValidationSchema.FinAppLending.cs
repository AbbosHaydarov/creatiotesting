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

	#region Class: AppValidationSchema

	/// <exclude/>
	public class AppValidationSchema : Terrasoft.Configuration.AppValidation_CrtFinservApplication_TerrasoftSchema
	{

		#region Constructors: Public

		public AppValidationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValidationSchema(AppValidationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValidationSchema(AppValidationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c281619a-8fb7-4f6a-9da0-b27a8c85c6c8");
			Name = "AppValidation";
			ParentSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794");
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
			return new AppValidation(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValidation_FinAppLendingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValidationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValidationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c281619a-8fb7-4f6a-9da0-b27a8c85c6c8"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValidation

	/// <summary>
	/// Validation.
	/// </summary>
	public class AppValidation : Terrasoft.Configuration.AppValidation_CrtFinservApplication_Terrasoft
	{

		#region Constructors: Public

		public AppValidation(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidation";
		}

		public AppValidation(AppValidation source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValidation_FinAppLendingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValidationDeleted", e);
			Deleting += (s, e) => ThrowEvent("AppValidationDeleting", e);
			Inserted += (s, e) => ThrowEvent("AppValidationInserted", e);
			Inserting += (s, e) => ThrowEvent("AppValidationInserting", e);
			Saved += (s, e) => ThrowEvent("AppValidationSaved", e);
			Saving += (s, e) => ThrowEvent("AppValidationSaving", e);
			Validating += (s, e) => ThrowEvent("AppValidationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidation(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidation_FinAppLendingEventsProcess

	/// <exclude/>
	public partial class AppValidation_FinAppLendingEventsProcess<TEntity> : Terrasoft.Configuration.AppValidation_CrtFinservApplicationEventsProcess<TEntity> where TEntity : AppValidation
	{

		public AppValidation_FinAppLendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValidation_FinAppLendingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c281619a-8fb7-4f6a-9da0-b27a8c85c6c8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_380cad8cf31f47f98998e5567b7417f0;
		public ProcessFlowElement EventSubProcess3_380cad8cf31f47f98998e5567b7417f0 {
			get {
				return _eventSubProcess3_380cad8cf31f47f98998e5567b7417f0 ?? (_eventSubProcess3_380cad8cf31f47f98998e5567b7417f0 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_380cad8cf31f47f98998e5567b7417f0",
					SchemaElementUId = new Guid("380cad8c-f31f-47f9-8998-e5567b7417f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_263749e92b904bcdac43fde3879092c1;
		public ProcessFlowElement StartMessage3_263749e92b904bcdac43fde3879092c1 {
			get {
				return _startMessage3_263749e92b904bcdac43fde3879092c1 ?? (_startMessage3_263749e92b904bcdac43fde3879092c1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_263749e92b904bcdac43fde3879092c1",
					SchemaElementUId = new Guid("263749e9-2b90-4bcd-ac43-fde3879092c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_4244b5da85b64032a2ead16b6f6edc13;
		public ProcessScriptTask ScriptTask3_4244b5da85b64032a2ead16b6f6edc13 {
			get {
				return _scriptTask3_4244b5da85b64032a2ead16b6f6edc13 ?? (_scriptTask3_4244b5da85b64032a2ead16b6f6edc13 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_4244b5da85b64032a2ead16b6f6edc13",
					SchemaElementUId = new Guid("4244b5da-85b6-4032-a2ea-d16b6f6edc13"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_4244b5da85b64032a2ead16b6f6edc13Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6;
		public ProcessFlowElement EventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6 {
			get {
				return _eventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6 ?? (_eventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6",
					SchemaElementUId = new Guid("a53271cb-4e3e-42c6-9a77-b83aa0e40cf6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_cd0a01d232ed4766a51e6fe670b18152;
		public ProcessFlowElement StartMessage4_cd0a01d232ed4766a51e6fe670b18152 {
			get {
				return _startMessage4_cd0a01d232ed4766a51e6fe670b18152 ?? (_startMessage4_cd0a01d232ed4766a51e6fe670b18152 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_cd0a01d232ed4766a51e6fe670b18152",
					SchemaElementUId = new Guid("cd0a01d2-32ed-4766-a51e-6fe670b18152"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_dcfe8b5c5d724a11974334b0d241f799;
		public ProcessScriptTask ScriptTask4_dcfe8b5c5d724a11974334b0d241f799 {
			get {
				return _scriptTask4_dcfe8b5c5d724a11974334b0d241f799 ?? (_scriptTask4_dcfe8b5c5d724a11974334b0d241f799 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_dcfe8b5c5d724a11974334b0d241f799",
					SchemaElementUId = new Guid("dcfe8b5c-5d72-4a11-9743-34b0d241f799"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_dcfe8b5c5d724a11974334b0d241f799Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_380cad8cf31f47f98998e5567b7417f0.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_380cad8cf31f47f98998e5567b7417f0 };
			FlowElements[StartMessage3_263749e92b904bcdac43fde3879092c1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_263749e92b904bcdac43fde3879092c1 };
			FlowElements[ScriptTask3_4244b5da85b64032a2ead16b6f6edc13.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_4244b5da85b64032a2ead16b6f6edc13 };
			FlowElements[EventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6 };
			FlowElements[StartMessage4_cd0a01d232ed4766a51e6fe670b18152.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_cd0a01d232ed4766a51e6fe670b18152 };
			FlowElements[ScriptTask4_dcfe8b5c5d724a11974334b0d241f799.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_dcfe8b5c5d724a11974334b0d241f799 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_380cad8cf31f47f98998e5567b7417f0":
						break;
					case "StartMessage3_263749e92b904bcdac43fde3879092c1":
						e.Context.QueueTasks.Enqueue("ScriptTask3_4244b5da85b64032a2ead16b6f6edc13");
						break;
					case "ScriptTask3_4244b5da85b64032a2ead16b6f6edc13":
						break;
					case "EventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6":
						break;
					case "StartMessage4_cd0a01d232ed4766a51e6fe670b18152":
						e.Context.QueueTasks.Enqueue("ScriptTask4_dcfe8b5c5d724a11974334b0d241f799");
						break;
					case "ScriptTask4_dcfe8b5c5d724a11974334b0d241f799":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_263749e92b904bcdac43fde3879092c1");
			ActivatedEventElements.Add("StartMessage4_cd0a01d232ed4766a51e6fe670b18152");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_380cad8cf31f47f98998e5567b7417f0":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_263749e92b904bcdac43fde3879092c1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_263749e92b904bcdac43fde3879092c1";
					result = StartMessage3_263749e92b904bcdac43fde3879092c1.Execute(context);
					break;
				case "ScriptTask3_4244b5da85b64032a2ead16b6f6edc13":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_4244b5da85b64032a2ead16b6f6edc13";
					result = ScriptTask3_4244b5da85b64032a2ead16b6f6edc13.Execute(context, ScriptTask3_4244b5da85b64032a2ead16b6f6edc13Execute);
					break;
				case "EventSubProcess4_a53271cb4e3e42c69a77b83aa0e40cf6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_cd0a01d232ed4766a51e6fe670b18152":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_cd0a01d232ed4766a51e6fe670b18152";
					result = StartMessage4_cd0a01d232ed4766a51e6fe670b18152.Execute(context);
					break;
				case "ScriptTask4_dcfe8b5c5d724a11974334b0d241f799":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_dcfe8b5c5d724a11974334b0d241f799";
					result = ScriptTask4_dcfe8b5c5d724a11974334b0d241f799.Execute(context, ScriptTask4_dcfe8b5c5d724a11974334b0d241f799Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_4244b5da85b64032a2ead16b6f6edc13Execute(ProcessExecutingContext context) {
			OldValidationItemId = Entity.GetTypedOldColumnValue<Guid>("ValidationItemId");
			this.GenerateNameByValidationItem();
			return true;
		}

		public virtual bool ScriptTask4_dcfe8b5c5d724a11974334b0d241f799Execute(ProcessExecutingContext context) {
			FillAppValQuestionResult();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AppValidationSaving":
							if (ActivatedEventElements.Contains("StartMessage3_263749e92b904bcdac43fde3879092c1")) {
							context.QueueTasks.Enqueue("StartMessage3_263749e92b904bcdac43fde3879092c1");
						}
						break;
					case "AppValidationSaved":
							if (ActivatedEventElements.Contains("StartMessage4_cd0a01d232ed4766a51e6fe670b18152")) {
							context.QueueTasks.Enqueue("StartMessage4_cd0a01d232ed4766a51e6fe670b18152");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidation_FinAppLendingEventsProcess

	/// <exclude/>
	public class AppValidation_FinAppLendingEventsProcess : AppValidation_FinAppLendingEventsProcess<AppValidation>
	{

		public AppValidation_FinAppLendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: AppValidationEventsProcess

	/// <exclude/>
	public class AppValidationEventsProcess : AppValidation_FinAppLendingEventsProcess
	{

		public AppValidationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

