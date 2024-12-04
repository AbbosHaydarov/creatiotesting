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

	#region Class: ChangeCriteriaInConditionSchema

	/// <exclude/>
	public class ChangeCriteriaInConditionSchema : Terrasoft.Configuration.ChangeCriteriaInCondition_CrtFinservProduct_TerrasoftSchema
	{

		#region Constructors: Public

		public ChangeCriteriaInConditionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ChangeCriteriaInConditionSchema(ChangeCriteriaInConditionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ChangeCriteriaInConditionSchema(ChangeCriteriaInConditionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("43184ea5-f12e-4167-b646-7856f6cbdaed");
			Name = "ChangeCriteriaInCondition";
			ParentSchemaUId = new Guid("15dc809e-723d-42d8-bbdc-92bbb1656b0a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1477990a-d82d-4b14-a671-0257bc56c816");
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
			return new ChangeCriteriaInCondition(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ChangeCriteriaInConditionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ChangeCriteriaInConditionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43184ea5-f12e-4167-b646-7856f6cbdaed"));
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteriaInCondition

	/// <summary>
	/// Condition change criteria in the product conditions.
	/// </summary>
	public class ChangeCriteriaInCondition : Terrasoft.Configuration.ChangeCriteriaInCondition_CrtFinservProduct_Terrasoft
	{

		#region Constructors: Public

		public ChangeCriteriaInCondition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ChangeCriteriaInCondition";
		}

		public ChangeCriteriaInCondition(ChangeCriteriaInCondition source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ChangeCriteriaInConditionDeleted", e);
			Deleting += (s, e) => ThrowEvent("ChangeCriteriaInConditionDeleting", e);
			Inserted += (s, e) => ThrowEvent("ChangeCriteriaInConditionInserted", e);
			Inserting += (s, e) => ThrowEvent("ChangeCriteriaInConditionInserting", e);
			Saved += (s, e) => ThrowEvent("ChangeCriteriaInConditionSaved", e);
			Saving += (s, e) => ThrowEvent("ChangeCriteriaInConditionSaving", e);
			Validating += (s, e) => ThrowEvent("ChangeCriteriaInConditionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeCriteriaInCondition(this);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess

	/// <exclude/>
	public partial class ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess<TEntity> : Terrasoft.Configuration.ChangeCriteriaInCondition_CrtFinservProductEventsProcess<TEntity> where TEntity : ChangeCriteriaInCondition
	{

		public ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("43184ea5-f12e-4167-b646-7856f6cbdaed");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_e24881d9dc574236b47836592e879c55;
		public ProcessFlowElement EventSubProcess3_e24881d9dc574236b47836592e879c55 {
			get {
				return _eventSubProcess3_e24881d9dc574236b47836592e879c55 ?? (_eventSubProcess3_e24881d9dc574236b47836592e879c55 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_e24881d9dc574236b47836592e879c55",
					SchemaElementUId = new Guid("e24881d9-dc57-4236-b478-36592e879c55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_9c7f6695236c4ccf99ce5085f18db5eb;
		public ProcessFlowElement StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb {
			get {
				return _startMessage3_9c7f6695236c4ccf99ce5085f18db5eb ?? (_startMessage3_9c7f6695236c4ccf99ce5085f18db5eb = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb",
					SchemaElementUId = new Guid("9c7f6695-236c-4ccf-99ce-5085f18db5eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_21c8aa108f984f529820c649c7da7b79;
		public ProcessScriptTask ScriptTask3_21c8aa108f984f529820c649c7da7b79 {
			get {
				return _scriptTask3_21c8aa108f984f529820c649c7da7b79 ?? (_scriptTask3_21c8aa108f984f529820c649c7da7b79 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_21c8aa108f984f529820c649c7da7b79",
					SchemaElementUId = new Guid("21c8aa10-8f98-4f52-9820-c649c7da7b79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_21c8aa108f984f529820c649c7da7b79Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_e24881d9dc574236b47836592e879c55.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_e24881d9dc574236b47836592e879c55 };
			FlowElements[StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb };
			FlowElements[ScriptTask3_21c8aa108f984f529820c649c7da7b79.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_21c8aa108f984f529820c649c7da7b79 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_e24881d9dc574236b47836592e879c55":
						break;
					case "StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb":
						e.Context.QueueTasks.Enqueue("ScriptTask3_21c8aa108f984f529820c649c7da7b79");
						break;
					case "ScriptTask3_21c8aa108f984f529820c649c7da7b79":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_e24881d9dc574236b47836592e879c55":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb";
					result = StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb.Execute(context);
					break;
				case "ScriptTask3_21c8aa108f984f529820c649c7da7b79":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_21c8aa108f984f529820c649c7da7b79";
					result = ScriptTask3_21c8aa108f984f529820c649c7da7b79.Execute(context, ScriptTask3_21c8aa108f984f529820c649c7da7b79Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_21c8aa108f984f529820c649c7da7b79Execute(ProcessExecutingContext context) {
			FillDisplayValue();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ChangeCriteriaInConditionSaving":
							if (ActivatedEventElements.Contains("StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb")) {
							context.QueueTasks.Enqueue("StartMessage3_9c7f6695236c4ccf99ce5085f18db5eb");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess

	/// <exclude/>
	public class ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess : ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess<ChangeCriteriaInCondition>
	{

		public ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: ChangeCriteriaInConditionEventsProcess

	/// <exclude/>
	public class ChangeCriteriaInConditionEventsProcess : ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess
	{

		public ChangeCriteriaInConditionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

