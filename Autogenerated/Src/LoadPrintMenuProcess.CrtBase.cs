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
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: LoadPrintMenuProcessSchema

	/// <exclude/>
	public class LoadPrintMenuProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LoadPrintMenuProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LoadPrintMenuProcessSchema(LoadPrintMenuProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoadPrintMenuProcess";
			UId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
			BackgroundModePriority = BackgroundModePriority.Medium;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
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
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,86,239,111,218,60,16,254,220,73,251,31,60,127,120,21,212,16,181,148,150,178,174,239,251,66,128,10,169,237,170,5,214,15,213,52,25,98,104,214,36,142,28,135,149,109,253,223,119,182,19,146,144,192,186,254,8,196,190,123,238,238,185,59,251,222,190,137,146,153,239,205,209,202,227,34,33,62,90,49,207,69,215,140,184,55,52,76,140,6,250,249,246,205,193,138,112,20,192,43,186,68,114,21,145,24,77,40,231,36,102,11,97,77,199,214,61,157,217,44,20,156,249,177,181,249,34,37,251,36,166,54,243,125,58,23,30,11,47,0,202,91,32,67,65,189,187,68,97,226,251,218,128,178,64,162,200,38,243,71,10,86,166,49,229,0,20,106,61,203,161,113,12,159,106,215,186,247,196,227,53,155,19,95,190,122,225,210,152,56,32,186,240,150,9,39,74,90,137,77,133,231,123,194,163,177,117,207,248,83,28,145,57,85,235,87,156,37,81,227,34,179,201,105,196,184,136,115,31,193,120,30,218,22,46,11,2,22,230,192,87,84,56,84,170,13,136,32,70,217,101,243,111,80,110,152,155,248,244,147,118,69,67,154,27,54,0,105,127,124,169,158,90,213,129,197,130,3,47,104,78,34,41,15,177,37,65,120,75,2,73,236,95,120,117,61,255,145,171,86,194,195,206,58,46,250,141,97,201,214,6,113,78,111,68,150,212,1,191,2,114,67,66,248,206,171,185,149,44,22,37,12,124,183,173,132,27,123,43,174,34,175,204,87,50,107,57,240,110,184,64,239,146,8,106,12,60,181,74,248,250,131,230,203,68,108,246,13,68,255,69,209,177,137,246,109,183,160,104,145,180,1,70,68,194,67,80,120,168,144,253,197,154,48,71,105,26,13,73,111,68,56,157,48,35,106,237,23,109,92,188,104,250,22,140,83,72,41,50,242,50,69,94,88,45,216,180,129,14,174,18,232,219,56,75,202,216,5,166,67,250,29,201,101,67,43,61,224,194,54,46,27,85,16,178,55,157,34,194,101,17,48,51,164,45,105,200,63,152,209,165,81,111,76,195,136,117,180,195,87,189,83,171,89,174,111,80,78,117,246,18,91,214,125,164,126,36,11,136,62,235,24,50,171,165,117,92,163,47,57,202,156,46,120,141,79,90,163,78,203,238,218,77,120,118,154,237,246,240,168,121,110,159,183,155,39,109,187,59,28,28,119,236,222,233,17,110,108,56,44,146,168,107,119,186,147,203,79,101,169,90,74,54,233,255,168,40,136,243,158,208,184,5,184,58,9,252,69,70,51,232,223,194,137,108,125,38,126,66,209,127,202,15,107,24,68,98,141,222,215,58,86,143,84,231,157,100,109,167,115,151,69,75,191,126,85,15,13,107,228,133,238,88,208,160,191,6,133,93,64,141,173,43,69,254,200,155,198,234,185,174,97,67,51,9,42,175,36,137,99,164,149,98,110,103,160,224,123,6,113,112,136,254,199,255,96,116,184,139,221,130,14,218,200,150,234,200,220,96,225,59,16,20,58,161,153,51,95,241,97,214,76,57,20,134,83,212,68,130,39,52,39,241,69,127,190,32,234,199,20,237,42,196,243,190,221,58,237,14,71,205,118,171,115,214,108,119,143,206,154,253,78,239,172,217,58,25,216,167,221,254,176,51,26,182,138,133,248,74,138,42,206,253,33,38,224,96,87,84,11,2,254,111,194,210,81,169,167,124,192,63,252,201,223,173,185,228,117,3,135,52,142,182,34,73,91,62,123,79,111,41,19,109,173,79,200,114,179,38,73,25,15,76,52,99,204,71,94,60,160,171,225,115,196,97,10,209,97,150,167,34,101,83,167,224,245,78,234,3,37,83,183,198,3,64,208,86,47,14,138,27,186,125,85,131,220,210,239,42,197,101,205,52,156,116,52,43,4,88,39,5,71,35,147,119,176,250,180,70,156,5,61,190,156,25,71,102,203,236,116,204,227,211,179,50,54,80,82,192,133,183,210,110,239,27,121,30,174,104,40,32,60,200,212,147,229,120,203,144,248,233,164,81,101,13,142,20,252,49,162,161,170,151,237,205,27,248,6,93,133,225,168,193,105,254,28,152,220,220,242,110,54,65,190,219,149,147,61,222,141,227,105,228,195,92,11,190,201,190,146,80,178,224,210,43,60,211,131,229,250,250,83,115,177,116,95,155,147,71,64,86,89,112,181,67,204,130,242,56,47,140,39,186,78,137,40,246,199,221,70,82,133,82,63,230,202,113,242,33,213,135,115,185,0,159,57,247,27,50,129,72,192,181,11,0,0 };
			RealUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
			Version = 0;
			PackageUId = new Guid("06d9ef10-51d8-122c-8933-9212e84236c9");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateMenuParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8d814a0f-f49c-47b8-811a-9d7fcedd7c1f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"Menu",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("720ead89-8627-4304-a359-d709a91ead74"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateMenuParameter());
			Parameters.Add(CreateSysModuleIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet4 = CreateLaneSet4LaneSet();
			LaneSets.Add(schemaLaneSet4);
			ProcessSchemaLane schemaLane8 = CreateLane8Lane();
			schemaLaneSet4.Lanes.Add(schemaLane8);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("f1217494-1fb3-445d-9f17-0fcfc701b6f6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				CurveCenterPosition = new Point(174, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97ae99d0-c2e3-47dd-a4dd-8a6878366ee1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("99284bf7-21f1-4235-9ee8-97831b800760"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				CurveCenterPosition = new Point(324, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0634007-ed0b-46c9-860c-e2819299abfb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet4LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet4 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("22a03e1e-7d55-4798-a4f9-8501cbfc71d1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"LaneSet4",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet4;
		}

		protected virtual ProcessSchemaLane CreateLane8Lane() {
			ProcessSchemaLane schemaLane8 = new ProcessSchemaLane(this) {
				UId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("22a03e1e-7d55-4798-a4f9-8501cbfc71d1"),
				CreatedInOwnerSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"Lane8",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane8;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("97ae99d0-c2e3-47dd-a4dd-8a6878366ee1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"Start1",
				Position = new Point(57, 72),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("b0634007-ed0b-46c9-860c-e2819299abfb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"End1",
				Position = new Point(316, 72),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b499f499-2977-45ce-aa15-281af0a76bba"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"ScriptTask1",
				Position = new Point(169, 58),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,243,201,79,76,241,77,205,43,213,208,180,230,229,2,49,20,108,21,242,74,115,114,128,188,162,212,146,210,162,60,133,146,162,210,84,107,0,71,19,235,36,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7a147170-d041-4a67-b3b1-c7ff2b70fef8"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1ea5759e-7be8-45c7-a793-b66f77ab8b4f"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b00609b8-3139-4513-8337-2a8cafd4a7fb"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("15406e8e-7657-422a-9d4c-760556f1a647"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LoadPrintMenuProcess(userConnection);
		}

		public override object Clone() {
			return new LoadPrintMenuProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"));
		}

		#endregion

	}

	#endregion

	#region Class: LoadPrintMenuProcess

	/// <exclude/>
	public class LoadPrintMenuProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane8

		/// <exclude/>
		public class ProcessLane8 : ProcessLane
		{

			public ProcessLane8(UserConnection userConnection, LoadPrintMenuProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public LoadPrintMenuProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoadPrintMenuProcess";
			SchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LoadPrintMenuProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LoadPrintMenuProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Object Menu {
			get;
			set;
		}

		public virtual Guid SysModuleId {
			get;
			set;
		}

		private ProcessLane8 _lane8;
		public ProcessLane8 Lane8 {
			get {
				return _lane8 ?? ((_lane8) = new ProcessLane8(UserConnection, this));
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
					SchemaElementUId = new Guid("97ae99d0-c2e3-47dd-a4dd-8a6878366ee1"),
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
					SchemaElementUId = new Guid("b0634007-ed0b-46c9-860c-e2819299abfb"),
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
					SchemaElementUId = new Guid("776ac1f3-00bb-472b-a5ee-8a9a1b2a43be"),
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
			if (!HasMapping("SysModuleId")) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
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
			MetaPathParameterValues.Add("8d814a0f-f49c-47b8-811a-9d7fcedd7c1f", () => Menu);
			MetaPathParameterValues.Add("720ead89-8627-4304-a359-d709a91ead74", () => SysModuleId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SysModuleId":
					if (!hasValueToRead) break;
					SysModuleId = reader.GetValue<System.Guid>();
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
			LoadMenu();
			Menu = null;
			return true;
		}

			
			public virtual void LoadMenu() {
				var menu = Menu as Terrasoft.UI.WebControls.Controls.MenuBaseCollection;
				if (menu != null) {
					var appCache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
					var reportsCollection = Terrasoft.Configuration.CommonUtilities.GetSelectData(UserConnection, Terrasoft.Configuration.CommonUtilities.GetModuleReportsSelect, appCache, TSConfiguration.CacheUtilities.ReportsCache);
					string captionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleReport", "Caption");
					var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as Terrasoft.UI.WebControls.PageSchemaManager;
					reportsCollection.Sort(delegate(Dictionary<string, object> p1, Dictionary<string, object> p2) { 
						return p1[captionColumnName].ToString().CompareTo(p2[captionColumnName].ToString());});
					foreach (var report in reportsCollection) {
						Guid sysModuleId = new Guid(report["sysModuleId"].ToString());
						if (SysModuleId == sysModuleId) {
							Guid reportId = new Guid(report["sysModuleReportId"].ToString());
							Guid typeId = new Guid(report["typeId"].ToString());
							string caption = report[captionColumnName].ToString();
							string helpContextId = report["helpContextId"].ToString();
							if (typeId == new Guid("32F72C9C-72C7-44E0-8C84-34C9ED17CA50")) {
								Guid reportSchemaUId = new Guid(report["sysReportSchemaUId"].ToString());
								Guid sysOptionsPageSchemaUId = report["sysOptionsPageSchemaUId"] == DBNull.Value ? Guid.Empty : new Guid(report["sysOptionsPageSchemaUId"].ToString());
								if (sysOptionsPageSchemaUId == Guid.Empty || pageSchemaManager.FindItemByUId(sysOptionsPageSchemaUId) != null) {
									menu.Add(CreateMenuItem(caption, reportSchemaUId.ToString()
										+ @"&" + sysOptionsPageSchemaUId.ToString() + @"&" + helpContextId,
										"PrintReportMenuItem_"+reportId.ToString("n"), true));
								}
							} else if (typeId == new Guid("8BC259EF-4276-4906-B7A6-23DC59BE7FE2")) {
								menu.Add(CreateMenuItem(caption, reportId.ToString("n"),
										"PrintReportMenuItem_" + reportId.ToString("n"), false));
							}
						}
					}
				}
			}
			
			
			public virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMenuItem(string MenuItemCaption, string MenuItemTag, string menuID, bool isDevExpressReport) {
				var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
				menuItem.ID = menuID;	
				menuItem.UId = Guid.NewGuid();
				menuItem.Caption = MenuItemCaption;
				menuItem.CaptionColor = Color.FromArgb(0,2,77,156);
				menuItem.Tag = MenuItemTag;
				menuItem.AjaxEvents.Click.SignalName = isDevExpressReport ? "OpenPrintDevExpressReportMessage" : "CreateMSWordReportMessage";
				if (!isDevExpressReport) {
					menuItem.AjaxEvents.Click.IsUpload = true;
				}
				return menuItem;
			}
			
			
			public virtual void OpenReportPage(string parameters) {
				var keyName = "PrintReportParameters";
				UserConnection.SessionData[keyName] = parameters;
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
			var cloneItem = (LoadPrintMenuProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Menu = Menu;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

