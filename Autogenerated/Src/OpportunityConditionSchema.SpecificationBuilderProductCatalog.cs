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

	#region Class: OpportunityConditionSchema

	/// <exclude/>
	public class OpportunityConditionSchema : Terrasoft.Configuration.OpportunityCondition_CrtFinservProduct_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityConditionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityConditionSchema(OpportunityConditionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityConditionSchema(OpportunityConditionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8e7c6bac-aed6-4362-9b36-ad3c2ac4e437");
			Name = "OpportunityCondition";
			ParentSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2");
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
			return new OpportunityCondition(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityConditionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityConditionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e7c6bac-aed6-4362-9b36-ad3c2ac4e437"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCondition

	/// <summary>
	/// Opportunity condition.
	/// </summary>
	public class OpportunityCondition : Terrasoft.Configuration.OpportunityCondition_CrtFinservProduct_Terrasoft
	{

		#region Constructors: Public

		public OpportunityCondition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityCondition";
		}

		public OpportunityCondition(OpportunityCondition source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityConditionDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityConditionDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityConditionInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityConditionInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityConditionSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityConditionSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityConditionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityCondition(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess

	/// <exclude/>
	public partial class OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityCondition_CrtFinservProductEventsProcess<TEntity> where TEntity : OpportunityCondition
	{

		public OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8e7c6bac-aed6-4362-9b36-ad3c2ac4e437");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2;
		public ProcessFlowElement EventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2 {
			get {
				return _eventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2 ?? (_eventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2",
					SchemaElementUId = new Guid("9e8b4f12-ea21-46c4-9970-bf0fb5dd14c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_c2c4481ffb0a4fac870362795ef6ca38;
		public ProcessFlowElement StartMessage3_c2c4481ffb0a4fac870362795ef6ca38 {
			get {
				return _startMessage3_c2c4481ffb0a4fac870362795ef6ca38 ?? (_startMessage3_c2c4481ffb0a4fac870362795ef6ca38 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_c2c4481ffb0a4fac870362795ef6ca38",
					SchemaElementUId = new Guid("c2c4481f-fb0a-4fac-8703-62795ef6ca38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_e2c896eb7ec9427eaa37a201e999dfb8;
		public ProcessScriptTask ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8 {
			get {
				return _scriptTask3_e2c896eb7ec9427eaa37a201e999dfb8 ?? (_scriptTask3_e2c896eb7ec9427eaa37a201e999dfb8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8",
					SchemaElementUId = new Guid("e2c896eb-7ec9-427e-aa37-a201e999dfb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2 };
			FlowElements[StartMessage3_c2c4481ffb0a4fac870362795ef6ca38.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_c2c4481ffb0a4fac870362795ef6ca38 };
			FlowElements[ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2":
						break;
					case "StartMessage3_c2c4481ffb0a4fac870362795ef6ca38":
						e.Context.QueueTasks.Enqueue("ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8");
						break;
					case "ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_c2c4481ffb0a4fac870362795ef6ca38");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_9e8b4f12ea2146c49970bf0fb5dd14c2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_c2c4481ffb0a4fac870362795ef6ca38":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_c2c4481ffb0a4fac870362795ef6ca38";
					result = StartMessage3_c2c4481ffb0a4fac870362795ef6ca38.Execute(context);
					break;
				case "ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8";
					result = ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8.Execute(context, ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_e2c896eb7ec9427eaa37a201e999dfb8Execute(ProcessExecutingContext context) {
			DeleteRelatedEntities();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityConditionDeleting":
							if (ActivatedEventElements.Contains("StartMessage3_c2c4481ffb0a4fac870362795ef6ca38")) {
							context.QueueTasks.Enqueue("StartMessage3_c2c4481ffb0a4fac870362795ef6ca38");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess

	/// <exclude/>
	public class OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess : OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess<OpportunityCondition>
	{

		public OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: OpportunityConditionEventsProcess

	/// <exclude/>
	public class OpportunityConditionEventsProcess : OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess
	{

		public OpportunityConditionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

