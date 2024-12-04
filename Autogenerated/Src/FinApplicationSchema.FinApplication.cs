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

	#region Class: FinApplication_FinApplication_TerrasoftSchema

	/// <exclude/>
	public class FinApplication_FinApplication_TerrasoftSchema : Terrasoft.Configuration.FinApplication_CrtFinservApplication_TerrasoftSchema
	{

		#region Constructors: Public

		public FinApplication_FinApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplication_FinApplication_TerrasoftSchema(FinApplication_FinApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplication_FinApplication_TerrasoftSchema(FinApplication_FinApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			Name = "FinApplication_FinApplication_Terrasoft";
			ParentSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("cc84f781-7756-4619-af55-0254dae4d203");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.IsValueCloneable = false;
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override EntitySchemaColumn CreateContactColumn() {
			EntitySchemaColumn column = base.CreateContactColumn();
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override EntitySchemaColumn CreateProductColumn() {
			EntitySchemaColumn column = base.CreateProductColumn();
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override EntitySchemaColumn CreateFillingDateColumn() {
			EntitySchemaColumn column = base.CreateFillingDateColumn();
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"ddbc52bc-e014-4d73-92cb-9314b9e58da7"
			};
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override EntitySchemaColumn CreateProductCategoryColumn() {
			EntitySchemaColumn column = base.CreateProductCategoryColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override EntitySchemaColumn CreateProductTypeColumn() {
			EntitySchemaColumn column = base.CreateProductTypeColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override EntitySchemaColumn CreateStageColumn() {
			EntitySchemaColumn column = base.CreateStageColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"59aa17ff-ee74-4eca-8387-4f25f1e302d3"
			};
			column.ModifiedInSchemaUId = new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplication_FinApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplication_FinApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplication_FinApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplication_FinApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_FinApplication_Terrasoft

	/// <summary>
	/// Application.
	/// </summary>
	public class FinApplication_FinApplication_Terrasoft : Terrasoft.Configuration.FinApplication_CrtFinservApplication_Terrasoft
	{

		#region Constructors: Public

		public FinApplication_FinApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplication_FinApplication_Terrasoft";
		}

		public FinApplication_FinApplication_Terrasoft(FinApplication_FinApplication_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplication_FinApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinApplication_FinApplication_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("FinApplication_FinApplication_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("FinApplication_FinApplication_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("FinApplication_FinApplication_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("FinApplication_FinApplication_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("FinApplication_FinApplication_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("FinApplication_FinApplication_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinApplication_FinApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_FinApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplication_FinApplicationEventsProcess<TEntity> : Terrasoft.Configuration.FinApplication_CrtFinservApplicationEventsProcess<TEntity> where TEntity : FinApplication_FinApplication_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, FinApplication_FinApplicationEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("754a62c2-d26a-4cb6-ba1e-874c4f1af14b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public FinApplication_FinApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplication_FinApplicationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("85af5bcc-a53e-44db-a358-74fde8134a0e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6;
		public ProcessFlowElement EventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6 {
			get {
				return _eventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6 ?? (_eventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6",
					SchemaElementUId = new Guid("57c912af-d6d3-4b05-9d5b-9f822fcfeaf6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_6b2779fb430b4d83930e15fe3c28159e;
		public ProcessFlowElement StartMessage3_6b2779fb430b4d83930e15fe3c28159e {
			get {
				return _startMessage3_6b2779fb430b4d83930e15fe3c28159e ?? (_startMessage3_6b2779fb430b4d83930e15fe3c28159e = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_6b2779fb430b4d83930e15fe3c28159e",
					SchemaElementUId = new Guid("6b2779fb-430b-4d83-930e-15fe3c28159e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0;
		public ProcessExclusiveGateway ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0 {
			get {
				return _exclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0 ?? (_exclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0",
					SchemaElementUId = new Guid("ebd2fbc8-0811-45cd-b5cc-10440ce126c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _scriptTask3_c3a75b786cc749d5a7949a7225edd56b;
		public ProcessScriptTask ScriptTask3_c3a75b786cc749d5a7949a7225edd56b {
			get {
				return _scriptTask3_c3a75b786cc749d5a7949a7225edd56b ?? (_scriptTask3_c3a75b786cc749d5a7949a7225edd56b = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_c3a75b786cc749d5a7949a7225edd56b",
					SchemaElementUId = new Guid("c3a75b78-6cc7-49d5-a794-9a7225edd56b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_c3a75b786cc749d5a7949a7225edd56bExecute,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1_b77d26de71524e69a960c6fbbb064d2a;
		public ProcessTerminateEvent TerminateEvent1_b77d26de71524e69a960c6fbbb064d2a {
			get {
				return _terminateEvent1_b77d26de71524e69a960c6fbbb064d2a ?? (_terminateEvent1_b77d26de71524e69a960c6fbbb064d2a = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1_b77d26de71524e69a960c6fbbb064d2a",
					SchemaElementUId = new Guid("b77d26de-7152-4e69-a960-c6fbbb064d2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_c67236e4c4214d65bccd2b9856692335;
		public ProcessScriptTask ScriptTask5_c67236e4c4214d65bccd2b9856692335 {
			get {
				return _scriptTask5_c67236e4c4214d65bccd2b9856692335 ?? (_scriptTask5_c67236e4c4214d65bccd2b9856692335 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_c67236e4c4214d65bccd2b9856692335",
					SchemaElementUId = new Guid("c67236e4-c421-4d65-bccd-2b9856692335"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_c67236e4c4214d65bccd2b9856692335Execute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1_f8dfe7c6008e4f35a82a410661346b8c;
		public ProcessConditionalFlow ConditionalSequenceFlow1_f8dfe7c6008e4f35a82a410661346b8c {
			get {
				return _conditionalSequenceFlow1_f8dfe7c6008e4f35a82a410661346b8c ?? (_conditionalSequenceFlow1_f8dfe7c6008e4f35a82a410661346b8c = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1_f8dfe7c6008e4f35a82a410661346b8c",
					SchemaElementUId = new Guid("f8dfe7c6-008e-4f35-a82a-410661346b8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6 };
			FlowElements[StartMessage3_6b2779fb430b4d83930e15fe3c28159e.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_6b2779fb430b4d83930e15fe3c28159e };
			FlowElements[ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0 };
			FlowElements[ScriptTask3_c3a75b786cc749d5a7949a7225edd56b.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_c3a75b786cc749d5a7949a7225edd56b };
			FlowElements[TerminateEvent1_b77d26de71524e69a960c6fbbb064d2a.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1_b77d26de71524e69a960c6fbbb064d2a };
			FlowElements[ScriptTask5_c67236e4c4214d65bccd2b9856692335.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_c67236e4c4214d65bccd2b9856692335 };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6":
						break;
					case "StartMessage3_6b2779fb430b4d83930e15fe3c28159e":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0");
						break;
					case "ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0":
						if (ConditionalSequenceFlow1_f8dfe7c6008e4f35a82a410661346b8cExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask3_c3a75b786cc749d5a7949a7225edd56b");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent1_b77d26de71524e69a960c6fbbb064d2a");
						break;
					case "ScriptTask3_c3a75b786cc749d5a7949a7225edd56b":
						e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
						break;
					case "TerminateEvent1_b77d26de71524e69a960c6fbbb064d2a":
						break;
					case "ScriptTask5_c67236e4c4214d65bccd2b9856692335":
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTask5_c67236e4c4214d65bccd2b9856692335");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalSequenceFlow1_f8dfe7c6008e4f35a82a410661346b8cExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_6b2779fb430b4d83930e15fe3c28159e");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_57c912afd6d34b059d5b9f822fcfeaf6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_6b2779fb430b4d83930e15fe3c28159e":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_6b2779fb430b4d83930e15fe3c28159e";
					result = StartMessage3_6b2779fb430b4d83930e15fe3c28159e.Execute(context);
					break;
				case "ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0";
					result = ExclusiveGateway1_ebd2fbc8081145cdb5cc10440ce126c0.Execute(context);
					break;
				case "ScriptTask3_c3a75b786cc749d5a7949a7225edd56b":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_c3a75b786cc749d5a7949a7225edd56b";
					result = ScriptTask3_c3a75b786cc749d5a7949a7225edd56b.Execute(context, ScriptTask3_c3a75b786cc749d5a7949a7225edd56bExecute);
					break;
				case "TerminateEvent1_b77d26de71524e69a960c6fbbb064d2a":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask5_c67236e4c4214d65bccd2b9856692335":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_c67236e4c4214d65bccd2b9856692335";
					result = ScriptTask5_c67236e4c4214d65bccd2b9856692335.Execute(context, ScriptTask5_c67236e4c4214d65bccd2b9856692335Execute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_c3a75b786cc749d5a7949a7225edd56bExecute(ProcessExecutingContext context) {
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool ScriptTask5_c67236e4c4214d65bccd2b9856692335Execute(ProcessExecutingContext context) {
			string code = GenerateNumberUserTask.ResultCode;
			Entity.SetColumnValue("Number", code);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "FinApplication_FinApplication_TerrasoftInserting":
							if (ActivatedEventElements.Contains("StartMessage3_6b2779fb430b4d83930e15fe3c28159e")) {
							context.QueueTasks.Enqueue("StartMessage3_6b2779fb430b4d83930e15fe3c28159e");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_FinApplicationEventsProcess

	/// <exclude/>
	public class FinApplication_FinApplicationEventsProcess : FinApplication_FinApplicationEventsProcess<FinApplication_FinApplication_Terrasoft>
	{

		public FinApplication_FinApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplication_FinApplicationEventsProcess

	public partial class FinApplication_FinApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

