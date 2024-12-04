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

	#region Class: SpecInConditionSchema

	/// <exclude/>
	public class SpecInConditionSchema : Terrasoft.Configuration.SpecInCondition_CrtFinservProduct_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecInConditionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecInConditionSchema(SpecInConditionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecInConditionSchema(SpecInConditionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6b7b2bf1-e5b3-4d8f-bcc1-7c414dbdbe96");
			Name = "SpecInCondition";
			ParentSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69");
			ExtendParent = true;
			CreatedInPackageId = new Guid("86a98e97-c14a-402e-8678-a2ccda7f89c3");
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
			return new SpecInCondition(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecInCondition_SpecificationBuilderProductCatalogEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecInConditionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecInConditionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b7b2bf1-e5b3-4d8f-bcc1-7c414dbdbe96"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecInCondition

	/// <summary>
	/// Parameter in product condition.
	/// </summary>
	public class SpecInCondition : Terrasoft.Configuration.SpecInCondition_CrtFinservProduct_Terrasoft
	{

		#region Constructors: Public

		public SpecInCondition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecInCondition";
		}

		public SpecInCondition(SpecInCondition source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecInCondition_SpecificationBuilderProductCatalogEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecInConditionDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecInConditionDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecInConditionInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecInConditionInserting", e);
			Saved += (s, e) => ThrowEvent("SpecInConditionSaved", e);
			Saving += (s, e) => ThrowEvent("SpecInConditionSaving", e);
			Validating += (s, e) => ThrowEvent("SpecInConditionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecInCondition(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInCondition_SpecificationBuilderProductCatalogEventsProcess

	/// <exclude/>
	public partial class SpecInCondition_SpecificationBuilderProductCatalogEventsProcess<TEntity> : Terrasoft.Configuration.SpecInCondition_CrtFinservProductEventsProcess<TEntity> where TEntity : SpecInCondition
	{

		public SpecInCondition_SpecificationBuilderProductCatalogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecInCondition_SpecificationBuilderProductCatalogEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6b7b2bf1-e5b3-4d8f-bcc1-7c414dbdbe96");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576;
		public ProcessFlowElement EventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576 {
			get {
				return _eventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576 ?? (_eventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576",
					SchemaElementUId = new Guid("d41712ac-4a1e-40d6-984b-3b2d52a59576"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_d8cfa498982c43579d1ccabb6dc274e6;
		public ProcessFlowElement StartMessage4_d8cfa498982c43579d1ccabb6dc274e6 {
			get {
				return _startMessage4_d8cfa498982c43579d1ccabb6dc274e6 ?? (_startMessage4_d8cfa498982c43579d1ccabb6dc274e6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_d8cfa498982c43579d1ccabb6dc274e6",
					SchemaElementUId = new Guid("d8cfa498-982c-4357-9d1c-cabb6dc274e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_751d083520544984b89f4eb4095b2938;
		public ProcessScriptTask ScriptTask4_751d083520544984b89f4eb4095b2938 {
			get {
				return _scriptTask4_751d083520544984b89f4eb4095b2938 ?? (_scriptTask4_751d083520544984b89f4eb4095b2938 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_751d083520544984b89f4eb4095b2938",
					SchemaElementUId = new Guid("751d0835-2054-4984-b89f-4eb4095b2938"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_751d083520544984b89f4eb4095b2938Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576 };
			FlowElements[StartMessage4_d8cfa498982c43579d1ccabb6dc274e6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_d8cfa498982c43579d1ccabb6dc274e6 };
			FlowElements[ScriptTask4_751d083520544984b89f4eb4095b2938.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_751d083520544984b89f4eb4095b2938 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576":
						break;
					case "StartMessage4_d8cfa498982c43579d1ccabb6dc274e6":
						e.Context.QueueTasks.Enqueue("ScriptTask4_751d083520544984b89f4eb4095b2938");
						break;
					case "ScriptTask4_751d083520544984b89f4eb4095b2938":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage4_d8cfa498982c43579d1ccabb6dc274e6");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4_d41712ac4a1e40d6984b3b2d52a59576":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_d8cfa498982c43579d1ccabb6dc274e6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_d8cfa498982c43579d1ccabb6dc274e6";
					result = StartMessage4_d8cfa498982c43579d1ccabb6dc274e6.Execute(context);
					break;
				case "ScriptTask4_751d083520544984b89f4eb4095b2938":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_751d083520544984b89f4eb4095b2938";
					result = ScriptTask4_751d083520544984b89f4eb4095b2938.Execute(context, ScriptTask4_751d083520544984b89f4eb4095b2938Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask4_751d083520544984b89f4eb4095b2938Execute(ProcessExecutingContext context) {
			DeleteRelatedEntityItems();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SpecInConditionDeleted":
							if (ActivatedEventElements.Contains("StartMessage4_d8cfa498982c43579d1ccabb6dc274e6")) {
							context.QueueTasks.Enqueue("StartMessage4_d8cfa498982c43579d1ccabb6dc274e6");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInCondition_SpecificationBuilderProductCatalogEventsProcess

	/// <exclude/>
	public class SpecInCondition_SpecificationBuilderProductCatalogEventsProcess : SpecInCondition_SpecificationBuilderProductCatalogEventsProcess<SpecInCondition>
	{

		public SpecInCondition_SpecificationBuilderProductCatalogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: SpecInConditionEventsProcess

	/// <exclude/>
	public class SpecInConditionEventsProcess : SpecInCondition_SpecificationBuilderProductCatalogEventsProcess
	{

		public SpecInConditionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

