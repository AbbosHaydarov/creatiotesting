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

	#region Class: CampaignCreateLeadProcessSchema

	/// <exclude/>
	public class CampaignCreateLeadProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CampaignCreateLeadProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CampaignCreateLeadProcessSchema(CampaignCreateLeadProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignCreateLeadProcess";
			UId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
			CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
			CultureName = @"ru-RU";
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,87,75,111,219,56,16,62,187,64,255,3,171,67,33,163,130,144,93,96,47,121,24,104,109,55,112,54,77,83,36,221,30,210,30,104,137,118,24,200,148,151,162,210,120,131,252,247,157,225,80,18,41,43,13,208,60,44,131,228,188,190,153,249,134,122,253,106,91,47,11,153,177,123,169,77,205,11,118,95,202,156,77,181,224,70,156,11,158,199,99,246,248,250,213,232,158,107,86,148,235,181,208,236,132,173,139,114,201,139,195,195,105,185,217,148,42,61,135,117,169,214,248,252,196,21,135,51,233,169,48,184,42,116,108,110,101,149,94,101,183,98,195,211,11,190,17,227,35,167,205,112,189,22,102,161,86,229,180,44,10,145,25,89,42,208,125,61,180,204,43,182,152,171,122,35,52,95,22,226,248,111,177,251,135,23,181,184,228,82,31,159,214,50,79,24,126,78,38,168,91,174,88,60,168,251,205,9,83,117,81,80,60,163,185,50,210,236,200,49,86,64,160,238,235,9,251,90,9,61,45,149,34,177,212,63,232,133,183,80,149,225,42,19,31,118,24,85,28,33,86,145,13,110,52,147,86,146,235,221,113,101,52,32,147,176,114,121,7,234,38,76,193,217,214,245,10,140,129,166,153,88,241,186,48,224,105,189,81,85,140,138,174,140,216,46,114,210,38,149,97,89,89,43,99,161,63,176,107,231,178,50,54,240,73,3,99,30,128,168,196,79,214,157,137,73,209,170,132,164,102,183,44,126,14,62,47,37,76,170,193,4,57,240,28,122,22,55,247,245,196,3,49,165,242,161,157,56,196,147,124,25,117,146,233,149,133,128,194,183,126,85,241,224,33,239,68,28,93,129,119,6,161,162,148,108,132,50,151,186,204,68,85,69,9,91,241,162,18,47,235,248,2,229,46,87,82,0,118,202,240,12,64,4,217,46,234,212,30,115,106,134,193,235,167,119,11,139,8,93,152,230,6,180,160,230,200,19,200,172,125,132,232,81,37,164,31,165,202,93,121,161,226,20,76,59,111,108,145,59,209,176,172,127,25,49,73,36,214,205,32,186,209,147,125,208,167,209,187,70,23,154,241,213,241,123,17,143,59,75,251,181,151,190,207,115,175,251,124,151,173,178,119,239,154,82,158,176,191,14,14,58,85,35,112,245,146,87,149,112,181,239,181,65,155,19,207,78,171,116,200,135,41,184,172,155,26,130,159,126,247,180,145,54,143,160,140,17,76,58,70,187,25,55,152,247,249,67,38,182,182,189,196,67,235,54,49,98,250,141,107,245,177,212,27,110,136,7,24,84,11,100,214,22,21,251,30,61,30,60,125,143,88,198,161,46,74,195,150,130,101,182,61,242,244,241,207,167,185,214,165,62,100,143,127,60,69,9,233,236,23,96,2,6,211,79,80,216,80,230,9,155,43,224,233,82,97,189,167,23,226,231,185,84,77,14,173,183,246,195,99,192,0,22,132,1,112,111,81,255,29,200,209,0,252,195,31,254,246,70,199,47,136,111,159,231,144,114,152,35,186,118,196,236,241,35,50,217,243,106,41,201,126,91,125,169,5,148,175,168,254,117,178,123,123,241,203,244,158,176,104,202,55,208,36,107,133,254,17,171,131,74,44,110,242,62,142,206,174,62,95,12,110,52,146,180,233,170,42,243,212,129,99,40,2,128,12,242,99,210,96,210,204,178,64,54,108,118,11,97,179,191,200,65,179,127,24,77,92,239,182,72,111,45,5,184,129,208,122,9,148,71,121,13,129,183,109,220,133,146,120,70,232,248,217,123,173,249,142,221,209,195,142,49,16,145,54,77,5,214,110,224,182,27,100,16,140,19,112,97,176,183,111,157,138,253,226,92,216,249,53,144,122,122,78,38,44,167,122,162,145,1,62,80,251,56,125,215,229,103,91,34,199,47,234,105,198,227,136,22,28,35,35,235,2,121,129,218,104,218,46,68,3,7,173,249,224,164,93,137,122,99,227,121,7,130,56,112,120,4,113,181,84,131,232,249,59,128,24,240,139,84,21,216,142,3,159,199,0,171,163,185,23,4,26,223,61,74,223,71,1,2,243,213,220,4,182,126,180,36,187,15,202,176,96,99,179,147,236,102,25,137,121,197,241,166,87,150,195,49,251,238,15,21,114,119,50,97,49,49,199,24,185,1,123,193,183,60,238,70,70,48,31,90,102,197,127,45,76,173,251,19,254,232,57,70,116,125,178,223,30,142,24,176,59,232,107,199,129,119,85,217,2,216,237,15,118,179,43,33,159,142,206,168,238,173,22,247,21,46,213,2,220,168,202,149,73,221,149,253,12,118,233,99,38,128,126,36,92,132,254,19,113,107,121,140,55,110,167,169,225,33,79,97,200,66,190,197,25,55,120,133,238,206,222,68,60,207,49,226,232,71,79,103,171,212,202,244,110,49,14,229,102,251,38,234,94,72,102,126,123,56,173,22,229,163,161,52,209,48,31,78,142,125,211,233,15,65,203,169,91,111,37,9,94,61,78,159,185,116,147,227,95,183,57,120,201,106,251,160,81,68,99,136,54,246,168,190,165,88,122,235,137,198,24,2,222,218,226,200,119,10,8,152,178,158,94,114,13,133,7,151,25,184,17,118,251,99,146,251,118,43,52,92,107,145,211,211,133,138,251,34,213,192,165,0,90,7,240,35,239,16,63,207,243,116,254,32,178,26,156,198,178,178,0,254,15,242,36,67,21,43,14,0,0 };
			RealUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
			Version = 0;
			PackageUId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadStepIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eb87380c-a95a-4a44-95da-b83827b301b6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"LeadStepId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTargetInfoCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba95186c-0b66-4608-8e44-30714cb58500"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"TargetInfoCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadStepIdParameter());
			Parameters.Add(CreateTargetInfoCollectionParameter());
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
			ProcessSchemaScriptTask createleadscripttask = CreateCreateLeadScriptTaskScriptTask();
			FlowElements.Add(createleadscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("eebcd74c-6407-4aab-8e22-5a3c69e80227"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c453f4bb-0948-45ee-9f3c-531394a38393"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("4f64caef-8293-4432-a27f-1ea8c4224231"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab63017c-3d97-4dfb-a462-9d975f3c007c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cb83dccf-f722-4089-b444-79c61eeccf4f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("cb83dccf-f722-4089-b444-79c61eeccf4f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c453f4bb-0948-45ee-9f3c-531394a38393"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
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
				UId = new Guid("ab63017c-3d97-4dfb-a462-9d975f3c007c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateLeadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"CreateLeadScriptTask",
				Position = new Point(288, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,245,73,77,76,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,157,165,154,94,27,0,0,0 }
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
			return new CampaignCreateLeadProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignCreateLeadProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignCreateLeadProcess

	/// <exclude/>
	public class CampaignCreateLeadProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, CampaignCreateLeadProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public CampaignCreateLeadProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignCreateLeadProcess";
			SchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
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
				return new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CampaignCreateLeadProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CampaignCreateLeadProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid LeadStepId {
			get;
			set;
		}

		public virtual Object TargetInfoCollection {
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
					SchemaElementUId = new Guid("c453f4bb-0948-45ee-9f3c-531394a38393"),
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
					SchemaElementUId = new Guid("ab63017c-3d97-4dfb-a462-9d975f3c007c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _createLeadScriptTask;
		public ProcessScriptTask CreateLeadScriptTask {
			get {
				return _createLeadScriptTask ?? (_createLeadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateLeadScriptTask",
					SchemaElementUId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CreateLeadScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[CreateLeadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateLeadScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateLeadScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "CreateLeadScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadStepId")) {
				writer.WriteValue("LeadStepId", LeadStepId, Guid.Empty);
			}
			if (TargetInfoCollection != null) {
				if (TargetInfoCollection.GetType().IsSerializable ||
					TargetInfoCollection.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("TargetInfoCollection", TargetInfoCollection, null);
				}
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
			MetaPathParameterValues.Add("eb87380c-a95a-4a44-95da-b83827b301b6", () => LeadStepId);
			MetaPathParameterValues.Add("ba95186c-0b66-4608-8e44-30714cb58500", () => TargetInfoCollection);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadStepId":
					if (!hasValueToRead) break;
					LeadStepId = reader.GetValue<System.Guid>();
				break;
				case "TargetInfoCollection":
					if (!hasValueToRead) break;
					TargetInfoCollection = reader.GetSerializableObjectValue();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool CreateLeadScriptTaskExecute(ProcessExecutingContext context) {
			CreateLead();
			return true;
		}

			
			public virtual void CreateLead() {
				var logger = global::Common.Logging.LogManager.GetLogger(this.Schema.Name);
				var targetInfoCollection = TargetInfoCollection as IEnumerable<KeyValuePair<Guid, Guid>>;
				if (targetInfoCollection != null) {
					EntitySchema leadSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Lead");
					Dictionary<string, object> nameValuePairs = GetDefaultColumns(LeadStepId);
					int counter = 0;
					List<Guid> targetIdCollection = new List<Guid>();
					foreach (KeyValuePair<Guid, Guid> targetInfo in targetInfoCollection) {
						Entity leadEntity = leadSchema.CreateEntity(UserConnection);
						leadEntity.SetDefColumnValues();
						leadEntity.SetColumnValue("StartLeadManagementProcess", false);
						leadEntity.SetColumnValue("QualifiedContactId", targetInfo.Value);
						foreach (KeyValuePair<string, object> pair in nameValuePairs) {
							EntitySchemaColumn column = leadSchema.Columns.FindByName(pair.Key);
							if (column != null) {
								leadEntity.SetColumnValue(column, pair.Value);
							}
						}
						try {
							if (leadEntity.Save()) {
								targetIdCollection.Add(targetInfo.Key);
								if (++counter > 500) {
									SetPassedStepId(LeadStepId, targetIdCollection);
									targetIdCollection.Clear();
									counter = 0;
								}
							}
							leadEntity = null;
						}
						catch (Exception ex) {
							logger.WarnFormat("Lead for contact \"{0}\" can not be created.{2}Error: {1}",
							targetInfo.Value, ex.Message, Environment.NewLine);
						}
					}
					if (targetIdCollection.Count > 0) {
						SetPassedStepId(LeadStepId, targetIdCollection);
					}
				}
			}
			
			
			public virtual Dictionary<string, object> GetDefaultColumns(Guid StepId) {
				var nameValuePairs = new Dictionary<string, object>();
				EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CampaignStep");
				esq.AddColumn("JSON");
				esq.AddColumn("Campaign");
				Entity campaignStep = esq.GetEntity(UserConnection, StepId);
				if (campaignStep != null) {
					Guid campaignId = campaignStep.GetTypedColumnValue<Guid>("CampaignId");
					nameValuePairs.Add("Campaign", campaignId);
					JArray jArray = GetAdditionalInfo(campaignStep);
					if (jArray != null && jArray.Count > 0) {
						IList<Dictionary<string, string>> defaultValues = 
							jArray.ToObject<IList<Dictionary<string, string>>>();
						string columnNameKey = "ColumnName";
						string columnValueKey = "ColumnValue";
						foreach (Dictionary<string, string> defaultValue in defaultValues) {
							if (defaultValue.ContainsKey(columnNameKey) &&
								defaultValue.ContainsKey(columnValueKey)) {
									string columnName = defaultValue[columnNameKey];
									string columnValue = defaultValue[columnValueKey];
									if (columnValue != null && !nameValuePairs.ContainsKey(columnName)) {
										nameValuePairs.Add(columnName, (object)new Guid(columnValue));
									}
							}
						}
					}
				}
				return nameValuePairs;
			}
			
			
			public virtual JArray GetAdditionalInfo(Entity StepEntity) {
				var jsonValue = StepEntity.GetTypedColumnValue<string>("JSON");
				JObject jsonObject = Terrasoft.Common.Json.Json.Deserialize(jsonValue) as JObject;
				if (jsonObject != null) {
					JObject jsonData = jsonObject["addInfo"] as JObject;
					if (jsonData != null) {
						return jsonData["CreateLeadDefaultValues"] as JArray;
					}
				}
				return null;
			}
			
			
			public virtual void SetPassedStepId(Guid passedStepId, IEnumerable<Guid> targetIdCollection) {
				Update updateQuery = new Update(UserConnection, "CampaignTarget")
					.Set("PassedStepId", Column.Parameter(passedStepId))
					.Where("Id").In(Column.Parameters(targetIdCollection)) as Update;
				updateQuery.Execute();
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
			var cloneItem = (CampaignCreateLeadProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.TargetInfoCollection = TargetInfoCollection;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

