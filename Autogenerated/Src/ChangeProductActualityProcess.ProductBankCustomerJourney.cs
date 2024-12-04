namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ChangeProductActualityProcessSchema

	/// <exclude/>
	public class ChangeProductActualityProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ChangeProductActualityProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ChangeProductActualityProcessSchema(ChangeProductActualityProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChangeProductActualityProcess";
			UId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8");
			CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8");
			Version = 0;
			PackageUId = new Guid("79126111-26be-4133-a70e-af339dfaf1fb");
			UseSystemSecurityContext = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask changeproductstatescripttask = CreateChangeProductStateScriptTaskScriptTask();
			FlowElements.Add(changeproductstatescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fa0bf9b7-ef2b-4d6b-89f3-4b9084907cfe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d"),
				CreatedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("41ff6869-6c7f-4296-b7d7-6ec7a6301d97"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8c21c7fd-481a-48aa-90f2-b92754f89c4a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("66e49512-4aa0-4418-81a4-6e7b6862b090"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d"),
				CreatedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8c21c7fd-481a-48aa-90f2-b92754f89c4a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2ee09ce9-49bb-4d8f-a536-a2bbbd02d0e2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9bc7898b-47cf-4b02-8aab-2f05da1f3292"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d"),
				CreatedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(729, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6d0f9abe-fc42-4f50-bf97-f10bdb4632fd"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9bc7898b-47cf-4b02-8aab-2f05da1f3292"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d"),
				CreatedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("41ff6869-6c7f-4296-b7d7-6ec7a6301d97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d0f9abe-fc42-4f50-bf97-f10bdb4632fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d"),
				CreatedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2ee09ce9-49bb-4d8f-a536-a2bbbd02d0e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d0f9abe-fc42-4f50-bf97-f10bdb4632fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d"),
				CreatedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeProductStateScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8c21c7fd-481a-48aa-90f2-b92754f89c4a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d0f9abe-fc42-4f50-bf97-f10bdb4632fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d"),
				CreatedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"),
				Name = @"ChangeProductStateScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(267, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,193,106,131,64,16,134,207,17,124,135,193,147,66,216,23,104,237,197,4,9,244,144,98,210,158,23,29,147,133,184,202,236,44,173,148,190,123,119,208,128,1,115,89,152,217,153,255,159,239,47,189,105,96,160,190,241,53,23,125,55,220,144,177,98,205,222,65,30,71,155,19,18,105,215,183,172,138,158,48,60,182,53,23,79,154,77,111,85,53,186,10,153,141,189,56,85,34,127,234,155,199,215,50,8,190,165,103,135,20,134,45,214,50,185,133,228,184,102,145,108,65,198,213,190,27,120,204,94,226,104,167,25,79,166,67,168,61,17,90,150,26,114,120,84,83,197,244,41,93,241,157,203,251,110,42,66,113,100,90,72,159,112,229,75,87,248,13,152,132,236,201,2,147,199,176,252,39,251,231,161,17,243,89,98,174,36,18,139,223,48,149,79,41,147,44,204,109,84,8,39,189,183,38,239,67,19,144,69,224,195,35,141,71,77,186,11,119,209,250,161,153,168,168,175,43,18,166,201,206,163,0,206,202,7,247,142,206,165,43,74,139,224,178,12,180,155,79,13,84,15,36,106,255,131,181,15,8,83,88,75,254,127,150,178,212,249,18,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ChangeProductActualityProcess(userConnection);
		}

		public override object Clone() {
			return new ChangeProductActualityProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8"));
		}

		#endregion

	}

	#endregion

	#region Class: ChangeProductActualityProcess

	/// <exclude/>
	public class ChangeProductActualityProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ChangeProductActualityProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ChangeProductActualityProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeProductActualityProcess";
			SchemaUId = new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f2e58731-8950-4b46-b117-33d7da55b0f8");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ChangeProductActualityProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ChangeProductActualityProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("41ff6869-6c7f-4296-b7d7-6ec7a6301d97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("2ee09ce9-49bb-4d8f-a536-a2bbbd02d0e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeProductStateScriptTask;
		public ProcessScriptTask ChangeProductStateScriptTask {
			get {
				return _changeProductStateScriptTask ?? (_changeProductStateScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeProductStateScriptTask",
					SchemaElementUId = new Guid("8c21c7fd-481a-48aa-90f2-b92754f89c4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ChangeProductStateScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ChangeProductStateScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeProductStateScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeProductStateScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ChangeProductStateScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ChangeProductStateScriptTaskExecute(ProcessExecutingContext context) {
			Guid productCompleteStatus =
				Terrasoft.Core.Configuration.SysSettings.GetValue<Guid>(UserConnection, "ProductCompleteStatus", Guid.Empty);
			DateTime currentDate = UserConnection.CurrentUser.GetCurrentDateTime();
			
			if (productCompleteStatus == Guid.Empty) {
				return true;
			}
			
			Update productUpdate =
				new Update(UserConnection, "Product")
					.Set("ProductStatusId", new QueryParameter(productCompleteStatus))
				.Where("DueDate")
					.IsLess(new QueryParameter(currentDate)) as Update;
			productUpdate.Execute();
			
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (ChangeProductActualityProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

