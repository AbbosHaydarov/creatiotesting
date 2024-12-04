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

	#region Class: EndCaseConsultationThemeSubProcessSchema

	/// <exclude/>
	public class EndCaseConsultationThemeSubProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public EndCaseConsultationThemeSubProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public EndCaseConsultationThemeSubProcessSchema(EndCaseConsultationThemeSubProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EndCaseConsultationThemeSubProcess";
			UId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d");
			CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d");
			Version = 0;
			PackageUId = new Guid("05591793-3b8e-477e-9dfd-bcd1d14f8fd1");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseConsultationThemeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a4775e80-90b1-46bb-a278-18e2309c0d98"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Name = @"CaseConsultationTheme",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseConsultationThemeParameter());
		}

		protected virtual void InitializeChangeDataCaseConsultationThemeUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("c6ce2ffe-b9bd-4a08-be86-22dbb183889c"),
				ContainerUId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"c0b15550-eb1b-4557-9847-d193804edd4b",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed1f9da6-53e0-4031-b724-468beabfc6e4"),
				ContainerUId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65f57087-8032-4526-a7c5-e3701a614bae"),
				ContainerUId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,20,252,43,65,135,158,164,34,219,146,45,185,199,101,91,246,146,6,154,150,66,178,132,39,233,57,43,240,199,198,146,105,130,217,255,94,121,157,109,33,135,210,67,47,5,99,164,39,207,188,121,227,209,252,224,195,71,223,70,28,235,6,218,128,116,218,185,154,72,209,104,101,149,96,141,176,138,9,211,40,102,128,167,87,105,44,207,141,204,115,93,16,218,67,135,53,89,209,91,231,35,161,62,98,23,234,187,249,55,105,28,39,164,15,205,121,243,197,30,176,131,175,75,3,203,77,38,165,228,12,77,102,152,144,178,98,90,137,138,185,76,23,138,11,116,78,24,178,106,177,149,130,34,227,13,3,43,36,19,89,99,152,17,90,50,228,60,119,101,86,232,130,91,66,91,108,226,246,249,56,98,8,126,232,235,25,127,173,111,95,142,73,229,218,123,51,180,83,215,19,218,97,132,27,136,135,154,0,114,20,210,2,179,11,167,104,176,98,80,104,199,10,48,85,94,41,204,202,172,34,212,194,49,46,180,100,231,8,117,16,225,27,180,19,158,153,103,159,52,230,5,207,148,44,19,54,43,44,19,69,206,153,42,85,197,26,87,54,26,139,82,107,227,46,126,125,154,124,90,251,112,61,117,56,122,251,106,59,38,255,134,177,158,237,208,199,113,104,23,234,235,243,231,183,248,28,87,115,95,143,190,175,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,29,156,239,31,87,206,211,41,65,186,35,140,62,92,92,216,62,77,208,18,58,250,199,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,20,178,179,220,37,131,206,135,99,11,47,231,125,77,222,61,77,67,252,176,25,250,48,181,17,150,159,121,21,83,34,240,202,247,87,22,2,174,231,228,13,79,77,238,9,136,170,146,168,56,211,41,179,76,148,198,48,72,201,96,153,194,228,133,182,220,105,117,79,146,182,127,214,241,110,23,62,255,232,47,247,101,157,112,255,62,85,223,20,110,46,200,122,254,27,145,167,253,34,115,127,74,207,79,91,54,239,178,246,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21ecce4c-a164-4018-820c-c71016313861"),
				ContainerUId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,203,110,163,48,20,134,95,5,185,93,198,145,1,67,236,108,219,77,164,118,20,77,210,108,74,23,7,251,48,69,226,18,25,83,41,19,241,238,53,46,105,146,118,102,83,47,176,204,241,247,255,231,226,35,185,181,135,61,146,37,217,162,49,208,181,133,157,223,181,6,231,107,211,42,236,186,249,67,171,160,42,255,66,94,225,26,12,212,104,209,236,160,234,177,123,40,59,59,11,174,49,50,35,183,111,62,74,150,207,71,178,178,88,63,173,180,83,231,137,84,152,242,148,66,42,98,202,49,47,40,136,56,166,137,18,177,102,113,148,50,153,56,88,181,85,95,55,143,104,97,13,246,149,44,143,196,171,57,1,33,82,198,165,68,10,138,51,202,21,151,84,46,162,132,50,150,11,140,35,41,69,14,100,152,145,78,189,98,13,222,244,12,43,150,135,73,146,48,138,121,152,83,158,36,11,42,5,95,80,29,202,88,48,142,90,243,124,132,167,251,103,240,249,102,115,232,118,96,202,177,254,249,93,111,12,54,246,30,44,110,203,26,111,94,70,70,151,221,190,130,195,238,159,168,171,63,120,251,130,7,218,241,1,52,58,176,159,34,251,171,214,94,202,28,179,143,9,101,100,153,253,111,70,211,190,241,165,95,79,233,235,128,50,50,203,200,166,237,141,26,21,227,241,112,106,152,119,96,211,114,125,253,246,57,173,15,13,143,61,66,3,127,208,252,114,142,30,247,33,215,31,240,230,91,151,247,73,88,71,33,74,44,56,85,44,229,148,179,48,162,121,36,82,90,64,8,34,92,132,26,56,247,244,111,44,208,181,73,225,15,19,243,206,231,100,78,111,201,253,105,250,170,242,6,157,175,127,124,156,83,226,83,228,254,98,148,23,10,173,46,139,18,245,170,249,73,70,3,25,134,151,225,29,80,95,194,241,103,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
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
			ProcessSchemaUserTask changedatacaseconsultationthemeusertask = CreateChangeDataCaseConsultationThemeUserTaskUserTask();
			FlowElements.Add(changedatacaseconsultationthemeusertask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("309b835b-c0d3-463d-b077-e35d94fd13cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("382b1448-580e-4f89-b07f-3b855afb7089"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0b3843be-ca2b-40b9-9068-644af49714a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f28fcada-5ba7-4765-a0a0-7c8bb8cb9f35"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("18346e56-41ea-4735-898f-0d524cfd56f1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1216, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("1127012d-2f1b-4fa9-94b0-15aaa9e9dce0"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("18346e56-41ea-4735-898f-0d524cfd56f1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1187, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("382b1448-580e-4f89-b07f-3b855afb7089"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1127012d-2f1b-4fa9-94b0-15aaa9e9dce0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
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
				UId = new Guid("f28fcada-5ba7-4765-a0a0-7c8bb8cb9f35"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1127012d-2f1b-4fa9-94b0-15aaa9e9dce0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataCaseConsultationThemeUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1127012d-2f1b-4fa9-94b0-15aaa9e9dce0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Name = @"ChangeDataCaseConsultationThemeUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(288, 170),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataCaseConsultationThemeUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new EndCaseConsultationThemeSubProcess(userConnection);
		}

		public override object Clone() {
			return new EndCaseConsultationThemeSubProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"));
		}

		#endregion

	}

	#endregion

	#region Class: EndCaseConsultationThemeSubProcess

	/// <exclude/>
	public class EndCaseConsultationThemeSubProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, EndCaseConsultationThemeSubProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ChangeDataCaseConsultationThemeUserTaskFlowElement

		/// <exclude/>
		public class ChangeDataCaseConsultationThemeUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataCaseConsultationThemeUserTaskFlowElement(UserConnection userConnection, EndCaseConsultationThemeSubProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataCaseConsultationThemeUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("47230dfa-8fac-426d-93f5-5260032b6d63");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_DateTimeEnd = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_DateTimeEnd", () => _recordColumnValues_DateTimeEnd.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<DateTime> _recordColumnValues_DateTimeEnd;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,20,252,43,65,135,158,164,34,219,146,45,185,199,101,91,246,146,6,154,150,66,178,132,39,233,57,43,240,199,198,146,105,130,217,255,94,121,157,109,33,135,210,67,47,5,99,164,39,207,188,121,227,209,252,224,195,71,223,70,28,235,6,218,128,116,218,185,154,72,209,104,101,149,96,141,176,138,9,211,40,102,128,167,87,105,44,207,141,204,115,93,16,218,67,135,53,89,209,91,231,35,161,62,98,23,234,187,249,55,105,28,39,164,15,205,121,243,197,30,176,131,175,75,3,203,77,38,165,228,12,77,102,152,144,178,98,90,137,138,185,76,23,138,11,116,78,24,178,106,177,149,130,34,227,13,3,43,36,19,89,99,152,17,90,50,228,60,119,101,86,232,130,91,66,91,108,226,246,249,56,98,8,126,232,235,25,127,173,111,95,142,73,229,218,123,51,180,83,215,19,218,97,132,27,136,135,154,0,114,20,210,2,179,11,167,104,176,98,80,104,199,10,48,85,94,41,204,202,172,34,212,194,49,46,180,100,231,8,117,16,225,27,180,19,158,153,103,159,52,230,5,207,148,44,19,54,43,44,19,69,206,153,42,85,197,26,87,54,26,139,82,107,227,46,126,125,154,124,90,251,112,61,117,56,122,251,106,59,38,255,134,177,158,237,208,199,113,104,23,234,235,243,231,183,248,28,87,115,95,143,190,175,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,29,156,239,31,87,206,211,41,65,186,35,140,62,92,92,216,62,77,208,18,58,250,199,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,20,178,179,220,37,131,206,135,99,11,47,231,125,77,222,61,77,67,252,176,25,250,48,181,17,150,159,121,21,83,34,240,202,247,87,22,2,174,231,228,13,79,77,238,9,136,170,146,168,56,211,41,179,76,148,198,48,72,201,96,153,194,228,133,182,220,105,117,79,146,182,127,214,241,110,23,62,255,232,47,247,101,157,112,255,62,85,223,20,110,46,200,122,254,27,145,167,253,34,115,127,74,207,79,91,54,239,178,246,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,203,110,163,48,20,134,95,5,185,93,198,145,1,67,236,108,219,77,164,118,20,77,210,108,74,23,7,251,48,69,226,18,25,83,41,19,241,238,53,46,105,146,118,102,83,47,176,204,241,247,255,231,226,35,185,181,135,61,146,37,217,162,49,208,181,133,157,223,181,6,231,107,211,42,236,186,249,67,171,160,42,255,66,94,225,26,12,212,104,209,236,160,234,177,123,40,59,59,11,174,49,50,35,183,111,62,74,150,207,71,178,178,88,63,173,180,83,231,137,84,152,242,148,66,42,98,202,49,47,40,136,56,166,137,18,177,102,113,148,50,153,56,88,181,85,95,55,143,104,97,13,246,149,44,143,196,171,57,1,33,82,198,165,68,10,138,51,202,21,151,84,46,162,132,50,150,11,140,35,41,69,14,100,152,145,78,189,98,13,222,244,12,43,150,135,73,146,48,138,121,152,83,158,36,11,42,5,95,80,29,202,88,48,142,90,243,124,132,167,251,103,240,249,102,115,232,118,96,202,177,254,249,93,111,12,54,246,30,44,110,203,26,111,94,70,70,151,221,190,130,195,238,159,168,171,63,120,251,130,7,218,241,1,52,58,176,159,34,251,171,214,94,202,28,179,143,9,101,100,153,253,111,70,211,190,241,165,95,79,233,235,128,50,50,203,200,166,237,141,26,21,227,241,112,106,152,119,96,211,114,125,253,246,57,173,15,13,143,61,66,3,127,208,252,114,142,30,247,33,215,31,240,230,91,151,247,73,88,71,33,74,44,56,85,44,229,148,179,48,162,121,36,82,90,64,8,34,92,132,26,56,247,244,111,44,208,181,73,225,15,19,243,206,231,100,78,111,201,253,105,250,170,242,6,157,175,127,124,156,83,226,83,228,254,98,148,23,10,173,46,139,18,245,170,249,73,70,3,25,134,151,225,29,80,95,194,241,103,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "a5cec4a9a2724ac7b0dab7823d07059d",
							"BaseElements.ChangeDataCaseConsultationThemeUserTask.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("05591793-3b8e-477e-9dfd-bcd1d14f8fd1");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		public EndCaseConsultationThemeSubProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EndCaseConsultationThemeSubProcess";
			SchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d");
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
				return new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: EndCaseConsultationThemeSubProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: EndCaseConsultationThemeSubProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CaseConsultationTheme {
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
					SchemaElementUId = new Guid("382b1448-580e-4f89-b07f-3b855afb7089"),
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
					SchemaElementUId = new Guid("f28fcada-5ba7-4765-a0a0-7c8bb8cb9f35"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ChangeDataCaseConsultationThemeUserTaskFlowElement _changeDataCaseConsultationThemeUserTask;
		public ChangeDataCaseConsultationThemeUserTaskFlowElement ChangeDataCaseConsultationThemeUserTask {
			get {
				return _changeDataCaseConsultationThemeUserTask ?? (_changeDataCaseConsultationThemeUserTask = new ChangeDataCaseConsultationThemeUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ChangeDataCaseConsultationThemeUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataCaseConsultationThemeUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataCaseConsultationThemeUserTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ChangeDataCaseConsultationThemeUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseConsultationTheme")) {
				writer.WriteValue("CaseConsultationTheme", CaseConsultationTheme, Guid.Empty);
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
			MetaPathParameterValues.Add("a4775e80-90b1-46bb-a278-18e2309c0d98", () => CaseConsultationTheme);
			MetaPathParameterValues.Add("c6ce2ffe-b9bd-4a08-be86-22dbb183889c", () => ChangeDataCaseConsultationThemeUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("ed1f9da6-53e0-4031-b724-468beabfc6e4", () => ChangeDataCaseConsultationThemeUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("65f57087-8032-4526-a7c5-e3701a614bae", () => ChangeDataCaseConsultationThemeUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("21ecce4c-a164-4018-820c-c71016313861", () => ChangeDataCaseConsultationThemeUserTask.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseConsultationTheme":
					if (!hasValueToRead) break;
					CaseConsultationTheme = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (EndCaseConsultationThemeSubProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

