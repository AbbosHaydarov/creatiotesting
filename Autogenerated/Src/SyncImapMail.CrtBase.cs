namespace Terrasoft.Core.Process
{

	using IntegrationApi.Interfaces;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;

	#region Class: SyncImapMailSchema

	/// <exclude/>
	public class SyncImapMailSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncImapMailSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncImapMailSchema(SyncImapMailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncImapMail";
			UId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			BackgroundModePriority = BackgroundModePriority.Medium;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,83,0,0,69,207,108,233,1,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			Version = 0;
			PackageUId = new Guid("06d9ef10-51d8-122c-8933-9212e84236c9");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a54165a0-7744-4599-95de-a742bd292b40"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("57e04ecc-eb57-43da-bb56-54c46c31c8d3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMailUserNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("97325781-b945-49f7-8732-c6cfdd3aebc1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"MailUserName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5cda26a9-50cc-4292-9c8a-84b7533a2e06"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentUserIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("294c50f3-a39f-4a40-a91e-58e6766978b9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"CurrentUserId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadEmailsFromDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ed3fa5d3-4777-4bfb-95e1-e80decf6e0a9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"LoadEmailsFromDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f27c14c-c3e5-4e1c-9b16-b0f669ff0e28"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateMailUserNameParameter());
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateCurrentUserIdParameter());
			Parameters.Add(CreateLoadEmailsFromDateParameter());
			Parameters.Add(CreateCreateRemindingParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("adfc9151-77b2-4fe4-a87b-92ae60725da1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1910142d-434b-41cb-9592-e2c24eee63bd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5d241632-5559-4887-b0c1-a279e8a744cf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5d241632-5559-4887-b0c1-a279e8a744cf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"Start1",
				Position = new Point(57, 44),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"End1",
				Position = new Point(246, 44),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"ScriptTask1",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,86,223,111,211,48,16,126,46,210,254,7,47,188,164,82,9,48,54,30,24,27,42,109,7,69,236,7,75,129,71,228,38,183,205,200,177,59,219,89,23,166,253,239,156,237,180,73,211,150,81,196,164,42,106,236,187,239,238,62,159,191,203,83,118,65,182,79,6,163,120,212,61,233,119,207,251,59,63,94,144,231,207,201,232,180,127,74,122,231,199,207,118,119,246,118,95,147,173,39,55,84,17,13,73,174,96,4,183,134,28,16,242,85,131,234,73,33,32,49,76,138,168,79,13,253,70,121,14,163,98,2,199,84,208,75,80,209,7,48,67,161,13,21,9,188,47,78,104,6,97,16,207,65,130,54,161,154,84,239,11,8,251,62,36,238,41,16,198,198,26,166,24,181,183,240,190,125,64,62,228,44,141,6,217,196,20,228,93,99,247,77,51,197,218,118,52,76,49,194,64,24,102,138,56,185,130,140,126,201,65,21,228,218,61,15,136,128,41,89,218,13,27,120,117,131,178,226,14,82,213,106,5,199,148,241,177,188,141,11,145,196,96,12,19,151,58,104,99,64,7,31,117,211,180,39,121,158,137,48,176,136,150,151,245,187,103,84,235,169,84,233,106,11,27,40,6,117,131,21,225,170,2,173,31,180,59,147,202,60,104,132,145,227,248,243,131,102,67,29,27,170,204,136,175,9,27,131,72,65,13,50,244,88,78,239,136,113,3,74,91,251,208,175,244,20,80,3,126,253,59,51,87,103,84,33,55,214,40,244,139,61,153,77,168,98,90,10,219,35,209,224,58,167,220,81,30,196,133,238,166,25,19,95,5,51,120,184,65,103,177,117,218,143,20,182,206,63,231,114,234,74,237,203,169,224,146,166,120,236,152,135,81,57,60,86,248,129,160,99,14,46,137,66,92,41,41,216,47,106,91,243,145,195,174,56,214,14,89,94,116,225,189,112,112,188,50,120,173,124,100,84,133,216,173,172,186,85,214,7,131,216,154,48,195,20,79,144,81,174,73,82,251,239,175,103,195,34,180,142,185,70,206,73,104,99,166,227,193,45,74,139,145,10,237,151,46,174,70,205,233,191,175,150,194,118,155,220,97,105,53,0,164,7,235,65,103,159,125,228,225,224,220,45,135,21,124,233,217,66,33,13,183,189,83,100,141,102,144,173,150,69,155,204,217,45,211,239,51,23,152,170,226,173,54,10,163,118,136,28,255,196,64,135,165,87,235,142,252,45,209,228,190,51,119,89,208,192,230,53,32,247,206,238,126,127,158,151,70,245,74,115,238,10,237,113,212,154,35,154,96,81,238,144,222,142,64,41,170,229,133,137,44,217,209,112,152,209,137,213,180,79,114,28,207,252,14,29,241,136,54,71,194,234,51,121,3,165,97,227,120,59,53,38,74,71,131,141,59,117,156,116,213,101,158,97,178,131,219,4,38,238,88,130,28,189,73,42,65,19,33,13,185,162,55,64,108,225,132,38,137,204,133,23,50,44,200,62,106,45,18,205,116,21,171,42,143,4,235,241,170,228,70,76,201,249,97,88,237,186,241,244,194,245,44,22,227,182,137,162,211,153,254,110,138,244,178,68,242,109,81,225,160,102,158,228,156,159,42,55,180,170,38,105,102,95,139,91,205,93,139,238,162,30,73,245,25,21,102,137,220,90,160,118,52,146,177,203,45,92,67,210,71,169,205,166,101,237,148,101,213,113,236,68,89,139,195,132,89,2,121,181,2,196,78,28,205,215,194,140,165,228,75,56,187,43,112,102,3,105,51,164,189,85,72,203,247,108,67,178,94,123,84,36,30,127,79,17,142,93,108,61,113,13,209,16,36,251,157,164,143,80,143,241,156,189,166,167,97,112,202,83,23,124,40,12,92,42,175,235,101,187,252,147,162,108,162,39,54,107,155,250,255,148,136,127,20,8,151,130,251,144,210,26,247,87,37,49,140,171,253,195,48,112,165,96,97,150,20,4,70,50,114,107,59,83,23,20,149,4,119,27,99,199,41,232,90,15,189,193,196,107,213,178,245,237,232,235,87,128,199,43,220,96,222,247,29,241,55,223,222,91,245,161,198,74,118,255,196,197,236,4,230,124,96,232,245,76,44,144,176,154,149,181,206,181,203,98,7,77,245,214,46,219,180,145,110,100,255,219,244,108,171,56,78,106,215,162,206,206,111,248,124,82,191,149,12,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("699b2038-adc5-418a-bdd1-d4d0f094a7b3"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2a014b6d-9ec5-48df-a642-6190afc95cc5"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d3124134-245b-4f52-9d71-d7d3dc858b19"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8ebced27-c4ad-4322-bdc4-d34ece6c78e1"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb1fe6c6-00d9-494f-a471-a3a73bc90279"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("411c2ea8-1b30-46ea-8e80-a814bd7b2e00"),
				Name = "IntegrationApi.Interfaces",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncImapMail(userConnection);
		}

		public override object Clone() {
			return new SyncImapMailSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("237dd150-53cf-4801-bd72-d517975107f8"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncImapMailMethodsWrapper

	/// <exclude/>
	public class SyncImapMailMethodsWrapper : ProcessModel
	{

		public SyncImapMailMethodsWrapper(Process process)
			: base(process) {
		}

		#region Methods: Private

			 

		#endregion

	}

	#endregion

	#region Class: SyncImapMail

	/// <exclude/>
	public class SyncImapMail : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SyncImapMail process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SyncImapMail(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncImapMail";
			SchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new SyncImapMailMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncImapMail, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncImapMail, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual string MailUserName {
			get;
			set;
		}

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		public virtual Guid CurrentUserId {
			get;
			set;
		}

		public virtual DateTime LoadEmailsFromDate {
			get;
			set;
		}

		public virtual bool CreateReminding {
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
					SchemaElementUId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("MailUserName")) {
				writer.WriteValue("MailUserName", MailUserName, null);
			}
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
			}
			if (!HasMapping("CurrentUserId")) {
				writer.WriteValue("CurrentUserId", CurrentUserId, Guid.Empty);
			}
			if (!HasMapping("LoadEmailsFromDate")) {
				writer.WriteValue("LoadEmailsFromDate", LoadEmailsFromDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("CreateReminding")) {
				writer.WriteValue("CreateReminding", CreateReminding, false);
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
			MetaPathParameterValues.Add("a54165a0-7744-4599-95de-a742bd292b40", () => PageInstanceId);
			MetaPathParameterValues.Add("57e04ecc-eb57-43da-bb56-54c46c31c8d3", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("97325781-b945-49f7-8732-c6cfdd3aebc1", () => MailUserName);
			MetaPathParameterValues.Add("5cda26a9-50cc-4292-9c8a-84b7533a2e06", () => SenderEmailAddress);
			MetaPathParameterValues.Add("294c50f3-a39f-4a40-a91e-58e6766978b9", () => CurrentUserId);
			MetaPathParameterValues.Add("ed3fa5d3-4777-4bfb-95e1-e80decf6e0a9", () => LoadEmailsFromDate);
			MetaPathParameterValues.Add("7f27c14c-c3e5-4e1c-9b16-b0f669ff0e28", () => CreateReminding);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "MailUserName":
					if (!hasValueToRead) break;
					MailUserName = reader.GetValue<System.String>();
				break;
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
				case "CurrentUserId":
					if (!hasValueToRead) break;
					CurrentUserId = reader.GetValue<System.Guid>();
				break;
				case "LoadEmailsFromDate":
					if (!hasValueToRead) break;
					LoadEmailsFromDate = reader.GetValue<System.DateTime>();
				break;
				case "CreateReminding":
					if (!hasValueToRead) break;
					CreateReminding = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-42546 
			var secureText =  UserConnection.DataValueTypeManager.GetInstanceByName("SecureText") as SecureTextDataValueType;
			var currentUserId = CurrentUserId != Guid.Empty ? CurrentUserId : UserConnection.CurrentUser.Id;
			EntitySchemaQuery query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, 
					"MailboxSyncSettings");
			query.AddColumn("UserName");
			query.AddColumn("UserPassword");
			query.AddColumn("MailServer.Address");
			query.AddColumn("MailServer.Port");
			query.AddColumn("MailServer.UseSSL");
			query.AddColumn("MailServer.IsStartTls");
			query.AddColumn("SenderEmailAddress");
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysAdminUnit.Id", currentUserId));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"MailServer.AllowEmailDownloading", true));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"EnableMailSynhronization", true));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SenderEmailAddress", SenderEmailAddress));
			var select = query.GetSelectQuery(UserConnection);
			 
			MailCredentials credentials = new MailCredentials();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					if (!reader.Read()) {
						var parameters = new Dictionary<string, object> {
							{ "SenderEmailAddress", SenderEmailAddress },
							{ "CurrentUserId", currentUserId }
						};
						var scheduler = ClassFactory.Get<Terrasoft.Mail.IImapSyncJobScheduler>();
						scheduler.RemoveSyncJob(UserConnection, parameters);
						throw new ArgumentException("user does not have mail account");
					}
					credentials.UserName = reader.GetColumnValue<string>(reader.GetName(0));
					string rawPassword = reader.GetColumnValue<string>(reader.GetName(1));
					if (!rawPassword.IsNullOrEmpty()) {
						credentials.UserPassword = secureText.GetValueForLoad(UserConnection, rawPassword).ToString();
					}
					credentials.Host = reader.GetColumnValue<string>(reader.GetName(2));
					credentials.Port = reader.GetColumnValue<int>(reader.GetName(3));
					credentials.UseSsl = reader.GetColumnValue<bool>(reader.GetName(4));
					credentials.StartTls = reader.GetColumnValue<bool>(reader.GetName(5));
					credentials.SenderEmailAddress = reader.GetColumnValue<string>(reader.GetName(6));
				}
			}
			#endif
			if (!UserConnection.GetIsFeatureEnabled("OldEmailIntegration")) {
				var parameters = new Dictionary<string, object> {
					{ "SenderEmailAddress", SenderEmailAddress }
				};
				var scheduler = ClassFactory.Get<Terrasoft.Mail.IImapSyncJobScheduler>();
				scheduler.RemoveSyncJob(UserConnection, parameters);
				var syncSession = ClassFactory.Get<ISyncSession>("Email", new ConstructorArgument("uc", UserConnection),
					new ConstructorArgument("senderEmailAddress", SenderEmailAddress));
				syncSession.Start();
				return true;
			}
			#if !NETSTANDARD2_0 // TODO CRM-42546
			using (var imapSyncSession = ClassFactory.Get<IImapSyncSession>(
				new ConstructorArgument("userConnection", UserConnection),
				new ConstructorArgument("credentials", credentials))) {
				imapSyncSession.SyncImapMail();
			}
			#endif
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
			var cloneItem = (SyncImapMail)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

