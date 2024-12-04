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
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendImmediatelyTriggeredEmailProcessSchema

	/// <exclude/>
	public class SendImmediatelyTriggeredEmailProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendImmediatelyTriggeredEmailProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendImmediatelyTriggeredEmailProcessSchema(SendImmediatelyTriggeredEmailProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendImmediatelyTriggeredEmailProcess";
			UId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,84,219,110,218,64,16,125,38,82,254,97,197,211,90,178,86,109,31,73,26,137,82,146,162,2,149,66,120,170,250,176,177,39,206,170,123,177,118,215,80,11,241,239,157,93,223,112,155,86,32,13,158,203,153,51,103,6,95,95,149,213,179,20,25,57,8,235,43,46,201,193,136,156,236,64,231,75,197,133,164,9,57,93,95,77,188,173,163,61,112,75,28,198,62,115,15,228,35,9,230,73,40,96,123,159,109,205,241,166,205,176,144,137,82,128,246,14,115,52,28,201,90,56,127,251,169,146,63,35,230,99,23,94,233,23,115,71,147,80,54,148,176,121,158,211,80,244,118,126,164,49,89,229,136,188,48,218,243,204,175,242,52,184,98,42,214,90,112,110,8,70,111,140,183,142,199,203,82,124,192,208,57,233,136,43,172,229,5,196,62,13,243,149,118,158,107,191,25,2,173,34,147,121,89,162,108,220,11,163,247,86,98,250,216,17,123,118,101,161,101,63,78,203,183,141,53,124,134,89,219,104,63,115,152,101,16,39,176,237,201,98,186,208,197,14,236,65,100,97,27,11,201,157,187,199,177,140,173,217,3,248,219,205,40,227,46,170,138,147,59,111,171,144,52,183,69,165,16,149,78,43,7,22,3,26,178,192,126,154,146,253,200,145,68,129,198,253,88,56,145,118,6,122,161,91,76,93,112,85,114,81,232,47,32,75,176,107,40,120,86,179,13,216,2,186,157,105,111,186,36,58,110,150,146,46,128,82,12,194,236,60,148,193,209,47,61,52,58,19,212,59,123,37,116,249,43,131,50,84,19,104,214,179,54,197,210,90,99,233,52,154,120,180,68,40,5,185,192,155,149,117,183,106,134,195,66,132,138,223,240,249,227,255,80,72,243,204,229,108,182,48,74,25,205,16,184,64,21,216,10,127,16,20,57,60,131,109,143,34,172,69,70,7,174,163,137,16,238,254,7,129,157,197,11,161,93,17,30,93,37,101,3,214,3,253,163,28,237,134,107,156,193,178,129,135,127,21,142,109,185,138,51,5,21,26,136,6,171,25,51,244,195,19,136,12,220,22,219,125,179,75,85,250,154,238,80,18,148,240,43,212,73,195,96,112,32,196,67,37,114,182,133,99,176,52,97,79,102,23,49,232,116,59,109,245,179,224,43,171,71,189,222,208,51,190,95,250,245,52,68,186,109,164,228,175,69,142,36,189,208,27,241,27,55,187,4,98,247,198,42,142,23,125,122,119,158,145,239,167,247,231,31,228,244,225,124,131,91,238,149,73,241,237,214,205,149,118,157,227,137,71,194,191,1,99,236,152,6,17,5,0,0 };
			RealUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			Version = 0;
			PackageUId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCampaignIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("85d945df-7ab5-4264-a3c7-f611954a399a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"CampaignId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBulkEmailIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e60bee11-c357-4094-b80e-1e60dc4ffd76"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"BulkEmailId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBulkEmailStepIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3b00293a-64b5-44ae-9a0f-7b6b6d58aa1d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"BulkEmailStepId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2544c42e-6fc8-4a6e-b641-d732f7f86c4a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2f6dcf43-aa4d-43f8-964b-e1058549db84"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ContactEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBulkEmailRIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bd524a10-c122-4d51-b9eb-818c1cfe77be"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"BulkEmailRId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactRIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f780e797-a0f6-48e5-99ec-d7eace686960"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ContactRId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateApplicationUrlParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("387d31a1-145f-4f8d-8f19-f74c35ddce78"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ApplicationUrl",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoggerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2963f4f8-9d7b-492a-961c-75325ea3f492"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Logger",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a62e66d5-5e14-42e0-8b16-1104efe6697a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"SessionKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCampaignIdParameter());
			Parameters.Add(CreateBulkEmailIdParameter());
			Parameters.Add(CreateBulkEmailStepIdParameter());
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateContactEmailParameter());
			Parameters.Add(CreateBulkEmailRIdParameter());
			Parameters.Add(CreateContactRIdParameter());
			Parameters.Add(CreateApplicationUrlParameter());
			Parameters.Add(CreateLoggerParameter());
			Parameters.Add(CreateSessionKeyParameter());
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
			ProcessSchemaScriptTask sendemailscripttask = CreateSendEmailScriptTaskScriptTask();
			FlowElements.Add(sendemailscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f42246f1-51de-4704-bd65-76426cca40a0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb76617b-474b-40d3-8f2e-3580df6254e1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("02fc9bfb-6221-4bd2-b64c-882120920eff"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0fd9a01d-d611-490c-8896-6ce8b5c06573"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("414c22c4-4416-4668-9b85-458fb0254378"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("414c22c4-4416-4668-9b85-458fb0254378"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("eb76617b-474b-40d3-8f2e-3580df6254e1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("0fd9a01d-d611-490c-8896-6ce8b5c06573"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSendEmailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"SendEmailScriptTask",
				Position = new Point(295, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,11,78,205,75,113,205,77,204,204,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,60,56,4,160,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e4d8fa67-fff7-4036-bd67-61e03d6e2b54"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2d11a6f5-135b-474d-9c77-28e78be687aa"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2248d4cd-8afa-4dcd-9f6e-3dc03a4c041f"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("16671048-241e-49b4-b1e7-a6fbc820ffe7")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendImmediatelyTriggeredEmailProcess(userConnection);
		}

		public override object Clone() {
			return new SendImmediatelyTriggeredEmailProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"));
		}

		#endregion

	}

	#endregion

	#region Class: SendImmediatelyTriggeredEmailProcess

	/// <exclude/>
	public class SendImmediatelyTriggeredEmailProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendImmediatelyTriggeredEmailProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SendImmediatelyTriggeredEmailProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendImmediatelyTriggeredEmailProcess";
			SchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendImmediatelyTriggeredEmailProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendImmediatelyTriggeredEmailProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid CampaignId {
			get;
			set;
		}

		public virtual Guid BulkEmailId {
			get;
			set;
		}

		public virtual Guid BulkEmailStepId {
			get;
			set;
		}

		public virtual Guid ContactId {
			get;
			set;
		}

		public virtual string ContactEmail {
			get;
			set;
		}

		public virtual int BulkEmailRId {
			get;
			set;
		}

		public virtual int ContactRId {
			get;
			set;
		}

		public virtual string ApplicationUrl {
			get;
			set;
		}

		public virtual Object Logger {
			get;
			set;
		}

		public virtual string SessionKey {
			get;
			set;
		}

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
					SchemaElementUId = new Guid("eb76617b-474b-40d3-8f2e-3580df6254e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("0fd9a01d-d611-490c-8896-6ce8b5c06573"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _sendEmailScriptTask;
		public ProcessScriptTask SendEmailScriptTask {
			get {
				return _sendEmailScriptTask ?? (_sendEmailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendEmailScriptTask",
					SchemaElementUId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendEmailScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[SendEmailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendEmailScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "SendEmailScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CampaignId")) {
				writer.WriteValue("CampaignId", CampaignId, Guid.Empty);
			}
			if (!HasMapping("BulkEmailId")) {
				writer.WriteValue("BulkEmailId", BulkEmailId, Guid.Empty);
			}
			if (!HasMapping("BulkEmailStepId")) {
				writer.WriteValue("BulkEmailStepId", BulkEmailStepId, Guid.Empty);
			}
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("ContactEmail")) {
				writer.WriteValue("ContactEmail", ContactEmail, null);
			}
			if (!HasMapping("BulkEmailRId")) {
				writer.WriteValue("BulkEmailRId", BulkEmailRId, 0);
			}
			if (!HasMapping("ContactRId")) {
				writer.WriteValue("ContactRId", ContactRId, 0);
			}
			if (!HasMapping("ApplicationUrl")) {
				writer.WriteValue("ApplicationUrl", ApplicationUrl, null);
			}
			if (Logger != null) {
				if (Logger.GetType().IsSerializable ||
					Logger.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Logger", Logger, null);
				}
			}
			if (!HasMapping("SessionKey")) {
				writer.WriteValue("SessionKey", SessionKey, null);
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
			MetaPathParameterValues.Add("85d945df-7ab5-4264-a3c7-f611954a399a", () => CampaignId);
			MetaPathParameterValues.Add("e60bee11-c357-4094-b80e-1e60dc4ffd76", () => BulkEmailId);
			MetaPathParameterValues.Add("3b00293a-64b5-44ae-9a0f-7b6b6d58aa1d", () => BulkEmailStepId);
			MetaPathParameterValues.Add("2544c42e-6fc8-4a6e-b641-d732f7f86c4a", () => ContactId);
			MetaPathParameterValues.Add("2f6dcf43-aa4d-43f8-964b-e1058549db84", () => ContactEmail);
			MetaPathParameterValues.Add("bd524a10-c122-4d51-b9eb-818c1cfe77be", () => BulkEmailRId);
			MetaPathParameterValues.Add("f780e797-a0f6-48e5-99ec-d7eace686960", () => ContactRId);
			MetaPathParameterValues.Add("387d31a1-145f-4f8d-8f19-f74c35ddce78", () => ApplicationUrl);
			MetaPathParameterValues.Add("2963f4f8-9d7b-492a-961c-75325ea3f492", () => Logger);
			MetaPathParameterValues.Add("a62e66d5-5e14-42e0-8b16-1104efe6697a", () => SessionKey);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CampaignId":
					if (!hasValueToRead) break;
					CampaignId = reader.GetValue<System.Guid>();
				break;
				case "BulkEmailId":
					if (!hasValueToRead) break;
					BulkEmailId = reader.GetValue<System.Guid>();
				break;
				case "BulkEmailStepId":
					if (!hasValueToRead) break;
					BulkEmailStepId = reader.GetValue<System.Guid>();
				break;
				case "ContactId":
					if (!hasValueToRead) break;
					ContactId = reader.GetValue<System.Guid>();
				break;
				case "ContactEmail":
					if (!hasValueToRead) break;
					ContactEmail = reader.GetValue<System.String>();
				break;
				case "BulkEmailRId":
					if (!hasValueToRead) break;
					BulkEmailRId = reader.GetValue<System.Int32>();
				break;
				case "ContactRId":
					if (!hasValueToRead) break;
					ContactRId = reader.GetValue<System.Int32>();
				break;
				case "ApplicationUrl":
					if (!hasValueToRead) break;
					ApplicationUrl = reader.GetValue<System.String>();
				break;
				case "Logger":
					if (!hasValueToRead) break;
					Logger = reader.GetSerializableObjectValue();
				break;
				case "SessionKey":
					if (!hasValueToRead) break;
					SessionKey = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SendEmailScriptTaskExecute(ProcessExecutingContext context) {
			SendEmail();
			return true;
		}

			
			public virtual void SendEmail() {
				try {
				var sendDate = DateTime.UtcNow;
				var recipients = new List<BulkEmailRecipientInfo>();
				recipients.Add(new BulkEmailRecipientInfo {
					Id = ContactId,
					EmailAddress = ContactEmail,
					ContactRId = ContactRId
				});
				var messageInfo = new InstantMessageInfo() {
					ApplicationUrl = ApplicationUrl,
					MessageId = BulkEmailId,
					MessageRId = BulkEmailRId,
					Recipients = recipients
				};
				var mailingService = ClassFactory.Get<MailingService>(new ConstructorArgument("userConnection", UserConnection));
				mailingService.SendMessage(messageInfo);
				CampaignHelperLegacy.MergeContactIntoCampaign(UserConnection, CampaignId, BulkEmailStepId, ContactId);
			} catch (Exception e) {
				LogError("Error send immediately message.", e);
			}
			}
			
			
			public virtual global::Common.Logging.ILog GetLogger() {
				var logger = Logger as global::Common.Logging.ILog;
			if (logger == null) {
				logger = global::Common.Logging.LogManager.GetLogger(this.Name);
				Logger = logger;
			}
			if (string.IsNullOrEmpty(SessionKey)) {
				SessionKey = Guid.NewGuid().ToString("N");
			}
			return logger;
			}
			
			
			public virtual void LogError(string message, Exception e) {
				var logger = GetLogger();
			logger.Error(string.Format("{0}: [{1}] {2};", this.Name, SessionKey, message));
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
			var cloneItem = (SendImmediatelyTriggeredEmailProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Logger = Logger;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

