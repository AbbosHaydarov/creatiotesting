namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: RunSendEmailToCaseGroupSchema

	/// <exclude/>
	public class RunSendEmailToCaseGroupSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public RunSendEmailToCaseGroupSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public RunSendEmailToCaseGroupSchema(RunSendEmailToCaseGroupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RunSendEmailToCaseGroup";
			UId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49");
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
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02541d56-c300-4b56-b7b9-a795a2af3a8e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3c1a583e-579d-4272-8c0c-cb74582f81f0}].[Parameter:{bcf4067c-cafc-4056-b29f-1afecb12a005}]#]  == Guid.Empty ? [#[IsOwnerSchema:false].[IsSchema:false].[Element:{5f24a920-e8d6-4e2b-ab95-9606f938e9ce}].[Parameter:{387361b5-5452-454b-89f5-1cd99a230829}]#] : [#[IsOwnerSchema:false].[IsSchema:false].[Element:{3c1a583e-579d-4272-8c0c-cb74582f81f0}].[Parameter:{bcf4067c-cafc-4056-b29f-1afecb12a005}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf4067c-cafc-4056-b29f-1afecb12a005"),
				ContainerUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7cc92fc9-fece-47af-9bf1-99d8b3ec74eb"),
				ContainerUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeStartSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("387361b5-5452-454b-89f5-1cd99a230829"),
				ContainerUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbbbcb2e-769d-4c62-aa1b-04440ddcd118"),
				ContainerUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask runprocess = CreateRunProcessScriptTask();
			FlowElements.Add(runprocess);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("14ab0ad1-8660-4bb3-8424-564ccb990427"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(185, 127));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("bc83b551-12cb-4fba-accd-964617644676"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(185, 267));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("930315a5-ede8-41f0-822f-7abd90adfb85"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f937c722-64ff-4561-ab8b-c5f114957735"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8c91975d-2cb4-4229-8b2b-8c71b0e9324c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c91975d-2cb4-4229-8b2b-8c71b0e9324c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"Terminate1",
				Position = new Point(438, 180),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(77, 113),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(77, 253),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("70620d00-e4ea-48d1-9fdc-4572fcd8d41b");
			schemaStartSignalEvent.EntityChangedColumns.Add("9147230c-ab53-4eb4-b0b4-ac78be6f8326");
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"ExclusiveGateway1",
				Position = new Point(157, 166),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateRunProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RunProcess",
				Position = new Point(280, 166),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,86,93,79,219,72,20,125,14,18,255,97,234,39,71,10,22,165,105,21,149,133,85,106,18,54,213,66,41,14,237,67,213,135,89,251,18,70,178,199,102,102,220,109,84,248,239,123,231,195,201,216,49,168,43,144,130,236,185,115,207,61,115,238,199,248,70,130,136,75,206,33,85,172,228,164,110,191,158,144,155,214,194,241,254,30,187,37,97,123,87,20,215,66,0,87,122,107,180,93,94,174,43,32,39,22,65,63,71,73,114,53,36,191,246,247,6,59,65,58,120,211,170,242,222,146,181,84,80,236,240,120,220,223,251,65,5,145,192,51,16,179,130,178,28,129,150,32,4,149,229,173,66,30,2,52,153,91,182,170,5,109,128,18,80,138,241,149,140,206,65,125,161,121,13,127,72,37,112,225,180,115,164,17,65,154,65,82,87,85,41,84,2,226,7,75,193,196,8,70,196,122,68,179,162,82,235,97,191,32,136,190,144,115,160,170,22,48,227,244,159,28,178,48,48,254,23,32,37,93,193,69,157,43,246,55,229,171,26,95,130,33,121,120,32,47,130,248,114,20,12,173,182,90,147,148,74,184,134,180,20,217,34,67,81,194,68,81,60,5,91,113,154,191,142,54,134,87,39,228,188,102,153,59,8,186,14,254,36,253,59,181,237,189,111,59,218,216,142,93,72,144,247,24,137,195,191,100,198,21,83,235,36,189,131,130,126,174,65,172,187,226,248,27,46,40,71,246,98,68,130,24,57,7,90,206,1,66,69,211,44,139,203,188,46,120,24,156,139,178,174,172,165,57,155,69,192,120,122,43,10,101,223,119,82,232,203,96,252,117,166,60,127,20,128,215,121,110,117,51,224,52,43,24,191,225,76,205,94,122,28,172,181,105,3,102,201,15,124,240,8,203,217,216,175,217,234,78,73,140,117,75,115,9,102,159,145,83,39,218,42,112,73,11,108,163,22,53,95,30,100,162,104,170,34,91,157,195,72,111,223,192,172,180,118,166,6,182,199,214,130,233,118,116,8,182,11,116,33,156,58,173,23,89,31,225,57,203,21,8,169,67,135,45,67,44,176,72,193,154,191,50,117,119,69,5,82,208,123,67,187,24,151,69,69,5,147,118,34,68,179,251,154,230,168,208,55,148,72,55,245,130,95,151,57,188,119,111,223,117,151,234,5,108,52,199,126,104,217,152,228,151,121,190,25,26,45,22,155,42,136,55,91,58,137,218,162,8,144,216,59,136,224,58,249,99,201,80,200,99,140,184,197,143,18,208,79,33,74,127,74,160,87,179,102,114,116,114,53,116,124,117,177,189,114,17,22,242,18,11,237,147,248,122,199,20,36,21,77,33,180,36,92,211,122,73,95,66,81,229,40,104,98,230,154,43,66,127,172,249,19,205,36,93,139,126,65,83,81,74,87,126,189,7,223,141,96,234,226,41,100,221,142,184,34,21,142,74,157,134,173,147,69,123,241,208,219,78,44,252,235,57,57,38,128,103,198,123,46,202,98,89,134,126,55,143,186,39,25,249,247,192,200,101,216,29,124,32,0,41,113,162,68,109,59,99,240,72,0,155,173,9,190,43,189,194,187,227,119,148,111,57,244,171,190,139,222,8,240,23,228,213,239,37,184,223,179,35,200,211,209,115,231,102,242,253,12,21,157,192,102,101,145,133,29,133,125,68,229,86,183,115,120,71,13,211,49,110,161,11,53,242,40,53,176,255,191,2,218,36,162,43,193,10,42,214,94,131,62,87,19,248,241,96,255,225,207,171,6,61,6,141,151,213,189,212,93,96,202,223,165,73,219,113,228,190,155,204,223,78,199,179,131,233,217,225,187,131,113,60,121,115,48,153,196,227,131,195,241,225,217,209,120,114,56,159,198,31,182,23,86,97,155,114,247,43,231,74,148,41,54,70,235,230,104,156,42,223,134,174,14,196,244,24,54,37,229,41,124,88,223,96,150,250,200,110,238,186,22,74,228,122,210,187,238,156,125,198,87,140,195,147,4,173,249,184,235,244,19,210,26,51,141,110,45,152,141,151,179,27,191,51,102,16,49,63,110,106,54,95,81,167,4,175,6,123,93,152,156,233,155,80,11,253,140,131,237,218,111,230,131,161,169,134,224,59,250,249,11,209,178,76,204,254,208,124,216,60,26,22,29,230,145,125,128,142,76,168,234,168,203,202,40,170,75,101,127,207,31,38,255,1,132,62,205,169,60,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("09015002-8c72-44a0-87aa-300725e2353a"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4bc22559-3627-4ea2-9aee-a2721c12aafa"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("60d0ddb8-902b-457f-9428-6aa42c5240aa"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7abde226-b990-4e5b-9337-0c55786d6c6f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new RunSendEmailToCaseGroup(userConnection);
		}

		public override object Clone() {
			return new RunSendEmailToCaseGroupSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"));
		}

		#endregion

	}

	#endregion

	#region Class: RunSendEmailToCaseGroup

	/// <exclude/>
	public class RunSendEmailToCaseGroup : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, RunSendEmailToCaseGroup process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public RunSendEmailToCaseGroup(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RunSendEmailToCaseGroup";
			SchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_caseRecordId = () => { return (Guid)((StartSignal1.RecordId)  == Guid.Empty ? (StartSignal2.RecordId) : (StartSignal1.RecordId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: RunSendEmailToCaseGroup, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: RunSendEmailToCaseGroup, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		private Func<Guid> _caseRecordId;
		public virtual Guid CaseRecordId {
			get {
				return (_caseRecordId ?? (_caseRecordId = () => Guid.Empty)).Invoke();
			}
			set {
				_caseRecordId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal2;
		public ProcessStartSignalEvent StartSignal2 {
			get {
				return _startSignal2 ?? (_startSignal2 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal2",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _runProcess;
		public ProcessScriptTask RunProcess {
			get {
				return _runProcess ?? (_runProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunProcess",
					SchemaElementUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = RunProcessExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[RunProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcess };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("RunProcess", e.Context.SenderName));
						break;
					case "RunProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
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
			MetaPathParameterValues.Add("02541d56-c300-4b56-b7b9-a795a2af3a8e", () => CaseRecordId);
			MetaPathParameterValues.Add("bcf4067c-cafc-4056-b29f-1afecb12a005", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("7cc92fc9-fece-47af-9bf1-99d8b3ec74eb", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("387361b5-5452-454b-89f5-1cd99a230829", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("fbbbcb2e-769d-4c62-aa1b-04440ddcd118", () => StartSignal2.EntitySchemaUId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool RunProcessExecute(ProcessExecutingContext context) {
			UserConnection userConnection = UserConnection;
			if (userConnection.CurrentUser.ConnectionType == UserType.SSP) {
				userConnection = userConnection.AppConnection.SystemUserConnection;
			}
			var senderEmail = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(userConnection, 
				"SupportServiceEmail", string.Empty);
			if (userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage") || userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
				var caseRecordId = (StartSignal1.RecordId != Guid.Empty)
					? StartSignal1.RecordId 
					: StartSignal2.RecordId;
				var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "Case");
				esq.AddColumn("Group");
				var caseEntity = esq.GetEntity(userConnection, caseRecordId);
				if (caseEntity != null) {
					var adminUnitEsq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysAdminUnit");
					adminUnitEsq.UseAdminRights = false;
					var emailColumnName = adminUnitEsq.AddColumn("Contact.Email").Name;
					var groupId = caseEntity.GetTypedColumnValue<Guid>("GroupId");
					adminUnitEsq.Filters.Add(adminUnitEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "[SysUserInRole:SysUser].SysRole", groupId));
					var collection = adminUnitEsq.GetEntityCollection(userConnection);
					var result = string.Join(";", collection.Select(e => e.GetTypedColumnValue<string>(emailColumnName)));
					if (!string.IsNullOrWhiteSpace(result)) {
						var emailTemplateSender = new Terrasoft.Configuration.EmailWithMacrosManager(userConnection);
						var emailTemplateId = Terrasoft.Configuration.CaseConsts.GroupTemplateId;
						if (userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
							emailTemplateSender.SendEmailFromTo(caseRecordId, emailTemplateId, senderEmail, result);
							return true;
						} else {
							var emailTemplateStore = new Terrasoft.Configuration.EmailTemplateStore(userConnection);
							var emailTemplateLanguageHelper = new Terrasoft.Configuration.EmailTemplateLanguageHelper(caseRecordId, userConnection);
							var languageId = emailTemplateLanguageHelper.GetLanguageId(emailTemplateId);
							var templateEntity = emailTemplateStore.GetTemplate(emailTemplateId, languageId);
							emailTemplateSender.SendEmailFromTo(caseRecordId, templateEntity.PrimaryColumnValue, senderEmail, result);
						}
					}
				}
			} else {
				Guid sendEmailToCaseGroup = new Guid("C68F5A4E-AD06-4C83-88C4-040D2480FACB");
				var manager = userConnection.ProcessSchemaManager;
				var processSchema = manager.GetInstanceByUId(sendEmailToCaseGroup);
				if (processSchema.Enabled) {
					var processEngine = userConnection.ProcessEngine;
					var processExecutor = processEngine.ProcessExecutor;
					Dictionary<string, string> parameterValues = new Dictionary<string, string> {
						["CaseRecordId"] = CaseRecordId.ToString()
					};
					processExecutor.Execute(processSchema.UId, parameterValues);
				}
			}
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
			var cloneItem = (RunSendEmailToCaseGroup)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

