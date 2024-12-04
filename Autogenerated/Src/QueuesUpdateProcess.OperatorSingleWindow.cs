namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
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
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;

	#region Class: QueuesUpdateProcessSchema

	/// <exclude/>
	public class QueuesUpdateProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public QueuesUpdateProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public QueuesUpdateProcessSchema(QueuesUpdateProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueuesUpdateProcess";
			UId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
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
			SerializeToMemory = false;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,87,77,111,227,54,16,61,219,128,255,3,235,147,4,4,66,209,235,54,5,220,196,217,117,177,113,218,245,166,123,102,165,113,76,68,38,29,146,114,226,22,251,223,59,252,144,37,81,148,55,78,129,45,18,36,18,57,51,156,153,247,248,72,77,198,187,234,175,146,229,100,207,164,174,104,73,246,130,21,228,134,149,229,31,21,84,128,15,26,36,20,11,13,91,149,220,43,144,87,130,115,200,53,19,156,84,157,215,11,242,190,66,215,106,87,80,13,43,80,10,199,22,133,31,125,50,193,204,155,210,146,241,7,247,190,164,91,56,142,172,237,74,215,84,211,148,252,51,25,143,86,80,98,92,66,115,147,149,205,101,206,53,211,12,148,159,185,36,104,245,30,244,108,200,34,9,243,235,165,118,204,170,149,78,43,143,119,147,49,91,147,228,68,10,151,132,87,101,233,18,150,160,43,201,209,231,235,100,188,167,146,48,142,203,235,218,18,13,56,60,147,69,107,48,200,47,69,147,108,193,181,72,166,189,214,79,205,228,40,91,129,78,166,54,135,195,39,200,133,44,22,197,244,130,56,115,247,120,223,45,209,250,101,55,82,108,253,146,131,181,152,98,181,60,216,74,218,153,103,243,23,200,43,13,137,49,248,74,114,170,243,13,73,230,47,57,236,44,7,192,21,111,35,170,123,205,74,27,51,251,40,30,230,82,10,153,56,116,179,27,33,183,84,39,11,190,23,143,112,11,122,35,10,59,127,139,153,210,7,184,48,229,77,227,172,195,178,32,243,118,41,62,155,68,70,122,35,197,179,235,53,254,154,159,24,141,175,177,4,13,75,209,230,200,43,152,236,74,50,24,186,118,253,73,75,44,46,64,114,16,195,81,118,37,202,106,203,61,140,102,189,159,12,52,109,52,90,115,211,52,155,169,142,173,181,250,77,48,158,152,63,159,15,59,64,90,112,144,53,210,17,98,220,213,171,117,230,208,33,32,75,154,45,212,252,9,75,10,147,11,237,108,212,25,47,6,194,214,140,27,140,119,52,48,181,124,217,160,239,64,164,30,97,143,17,77,147,209,69,30,126,167,18,119,38,122,37,61,235,11,18,140,164,102,65,170,60,58,72,144,62,130,217,106,7,57,91,31,150,226,163,200,31,63,48,174,149,37,183,193,187,176,132,57,98,236,248,19,219,167,61,16,191,129,89,136,83,77,136,72,255,78,182,175,54,176,190,72,236,4,35,240,164,95,100,11,192,187,29,72,170,133,244,203,45,81,176,146,102,58,197,13,206,20,182,224,52,167,3,82,183,248,60,234,52,163,30,138,229,60,68,154,110,176,134,116,118,92,221,82,142,166,229,193,136,3,42,201,105,130,172,105,169,192,114,160,33,129,103,132,195,178,165,114,110,160,104,68,225,74,84,220,28,43,142,4,223,83,248,6,117,234,63,104,159,59,105,150,240,124,190,234,117,79,46,114,254,209,117,214,145,181,210,84,87,42,114,86,189,82,101,163,210,213,149,224,96,212,253,195,55,174,116,210,238,80,157,138,99,80,155,215,17,205,125,155,170,117,214,142,137,87,189,45,221,230,126,203,230,108,107,68,111,131,54,5,156,212,171,166,27,152,251,93,24,185,129,44,162,95,222,173,147,192,57,114,48,120,214,132,250,240,202,51,238,91,71,98,44,108,171,6,117,195,56,45,157,116,10,29,1,81,203,106,64,114,250,55,171,89,81,196,20,231,255,186,112,69,52,226,109,138,227,181,226,228,109,252,123,126,60,56,204,149,31,87,216,226,21,200,61,203,1,129,205,31,63,195,139,254,0,37,158,139,217,53,96,26,140,150,236,111,248,217,59,253,146,116,63,1,252,18,82,8,189,202,55,176,165,102,101,140,232,99,103,159,58,19,254,155,193,163,224,142,219,59,57,223,238,244,33,233,134,72,7,129,252,66,37,15,112,180,1,92,130,205,122,53,150,77,67,82,11,151,251,18,177,159,38,14,180,133,227,188,243,178,71,166,11,101,16,39,160,158,234,118,53,69,253,90,177,178,152,215,51,65,230,120,235,234,138,144,191,61,61,53,145,113,135,148,30,232,203,246,10,184,43,6,114,105,60,124,52,244,66,95,163,124,61,143,128,75,89,219,0,239,11,216,19,20,178,160,219,24,21,35,102,184,3,107,177,52,155,223,195,21,207,252,135,246,231,221,160,89,230,119,241,37,249,209,89,158,15,169,26,66,50,128,114,132,88,142,76,21,222,205,68,102,57,45,221,21,207,53,59,158,99,104,248,46,8,100,197,109,208,219,206,26,151,181,144,64,141,30,157,100,148,35,17,170,90,60,156,239,82,123,249,89,81,248,93,103,203,54,58,67,0,175,114,214,50,52,108,232,100,37,114,50,246,234,163,234,11,139,113,64,41,114,195,142,48,193,169,105,182,117,109,237,30,204,221,35,118,61,240,218,99,5,62,106,16,72,150,197,205,133,28,250,208,240,152,58,35,87,193,100,252,47,83,161,116,246,136,17,0,0 };
			RealUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			Version = 0;
			PackageUId = new Guid("692a159e-9044-4f75-85a8-855bdb86a76d");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateUpdateSessionIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dbf48210-a598-460b-bfce-b27933ecfff8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"UpdateSessionId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewQueueItemStatusIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("168bc457-1b6d-4962-83a3-24cc0c53583d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"NewQueueItemStatusId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.a4b5e242-0a9b-413d-a7cc-0faca45c3c2c.2b341a1d-6fa1-4960-9c85-fef60d1bbcc4#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxQueueFilteredItemsLifeDaysParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce429aa3-6cd8-4d38-a6b7-019286ef4823"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"MaxQueueFilteredItemsLifeDays",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"1",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateAddedQueueItemsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f1bbdf69-8cdd-4223-b6f6-0ada6c340c29"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"AddedQueueItemsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDeletedQueueItemsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("222b97a0-00c9-411d-897c-c035aff3a4a7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"DeletedQueueItemsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateQueuesUpdatedMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fcfa253f-171b-4c14-9460-e9fde6eb0258"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"QueuesUpdatedMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmptyFilterRootSchemaMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("59c9124e-ef80-402a-a878-2c33e9741c0a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"EmptyFilterRootSchemaMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmptyFiltersMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4212368e-ac01-41d1-8922-c43a0f14a0d7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"EmptyFiltersMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateInvokeMethodErrorMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df7ac21b-eaf4-425a-af1f-8e71d75c59ec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"InvokeMethodErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateUpdateSessionIdParameter());
			Parameters.Add(CreateNewQueueItemStatusIdParameter());
			Parameters.Add(CreateMaxQueueFilteredItemsLifeDaysParameter());
			Parameters.Add(CreateAddedQueueItemsCountParameter());
			Parameters.Add(CreateDeletedQueueItemsCountParameter());
			Parameters.Add(CreateQueuesUpdatedMessageParameter());
			Parameters.Add(CreateEmptyFilterRootSchemaMessageParameter());
			Parameters.Add(CreateEmptyFiltersMessageParameter());
			Parameters.Add(CreateInvokeMethodErrorMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminate = CreateTerminateTerminateEvent();
			FlowElements.Add(terminate);
			ProcessSchemaScriptTask actualizequeuestriggerscripttask = CreateActualizeQueuesTriggerScriptTaskScriptTask();
			FlowElements.Add(actualizequeuestriggerscripttask);
			ProcessSchemaScriptTask fillqueuefiltereditemsscripttask = CreateFillQueueFilteredItemsScriptTaskScriptTask();
			FlowElements.Add(fillqueuefiltereditemsscripttask);
			ProcessSchemaFormulaTask initupdatesessionidformulatask = CreateInitUpdateSessionIdFormulaTaskFormulaTask();
			FlowElements.Add(initupdatesessionidformulatask);
			ProcessSchemaScriptTask updatequeuesscripttask = CreateUpdateQueuesScriptTaskScriptTask();
			FlowElements.Add(updatequeuesscripttask);
			ProcessSchemaScriptTask clearqueuefiltereditemsscripttask = CreateClearQueueFilteredItemsScriptTaskScriptTask();
			FlowElements.Add(clearqueuefiltereditemsscripttask);
			ProcessSchemaScriptTask logprocessscripttask = CreateLogProcessScriptTaskScriptTask();
			FlowElements.Add(logprocessscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask callqueueupdateutilitiesscripttask = CreateCallQueueUpdateUtilitiesScriptTaskScriptTask();
			FlowElements.Add(callqueueupdateutilitiesscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6b36a146-d851-4667-b2d4-526512106c94"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d912ed96-306e-4b1b-b6d7-184caeaeae6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("32bd243b-4cbd-41fd-9810-e31ca13a2e8b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f2f85c52-77cf-4593-b935-cbb9860d4fc8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(647, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("935d3cdd-060a-45b0-8bdb-61c264c77e55"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("f88ea237-acee-4dff-bb1e-df35385b096b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("356e34c8-8191-42e5-84b6-cf41673bce65"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("a4a76fc9-7769-47f1-92f0-e3c484267efc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(677, 205),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("4fbecf5d-d10f-4903-9837-491ef2fc6235"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(789, 205),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("aae426bd-5094-4225-a4c8-d0d840e87564"),
				ConditionExpression = @"false",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(204, 141),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("7816f084-7e3e-457d-9ad0-317d329b9778"),
				ConditionExpression = @"true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(267, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("5af2f059-cf49-4938-a951-7e5680318008"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(626, 127),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a2525006-738b-4752-a483-70687f58d2a7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a2525006-738b-4752-a483-70687f58d2a7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("d912ed96-306e-4b1b-b6d7-184caeaeae6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"Start",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("935d3cdd-060a-45b0-8bdb-61c264c77e55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"Terminate",
				Position = new Point(925, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActualizeQueuesTriggerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"ActualizeQueuesTriggerScriptTask",
				Position = new Point(806, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,85,141,65,10,2,49,16,4,239,130,127,200,81,47,249,192,226,201,23,8,155,7,132,181,55,12,200,68,58,61,224,243,93,241,148,99,87,65,117,25,224,189,187,99,147,117,79,49,207,91,218,186,11,31,229,50,137,229,124,90,65,214,209,119,229,3,239,214,130,245,103,242,35,16,24,69,246,50,25,70,46,239,103,21,254,116,165,181,6,94,230,151,235,81,35,20,244,36,6,150,47,43,2,178,135,147,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateFillQueueFilteredItemsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"FillQueueFilteredItemsScriptTask",
				Position = new Point(260, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,219,110,26,49,16,125,38,82,254,193,226,201,43,33,255,0,202,67,19,32,218,170,164,23,66,251,236,174,39,96,197,216,100,60,14,160,42,255,222,241,122,9,151,210,62,20,33,175,189,51,231,204,25,207,217,121,4,188,11,222,67,67,54,120,145,78,143,55,162,9,158,96,75,106,126,18,24,94,95,189,106,20,17,28,159,57,235,250,170,231,97,35,102,237,89,158,146,84,28,236,169,187,224,210,202,203,254,215,4,9,250,3,209,175,77,255,47,145,7,189,130,179,216,196,58,2,28,105,210,109,64,77,48,172,246,136,146,249,49,88,47,243,242,184,91,131,170,185,56,50,85,155,49,35,77,41,246,43,245,249,184,74,121,155,85,168,58,142,95,146,118,242,36,253,32,81,253,88,2,194,159,209,88,123,75,86,187,150,225,33,80,33,201,247,192,153,184,251,162,145,27,97,217,146,48,65,85,100,126,240,230,2,209,196,250,255,165,41,4,83,237,25,228,118,124,79,206,250,197,81,79,23,120,158,180,139,133,72,199,110,100,60,207,20,25,40,228,232,118,188,133,38,81,64,97,126,190,111,111,196,233,252,213,216,199,132,48,186,61,188,146,85,37,126,49,39,225,174,125,246,58,194,58,79,237,27,104,3,204,152,153,138,105,84,225,134,18,145,135,90,29,77,175,183,89,90,7,66,26,84,57,103,79,207,191,236,188,151,220,123,109,152,78,222,39,107,42,206,186,7,42,118,249,174,93,226,113,229,233,13,207,16,217,90,25,19,9,89,220,37,84,49,223,17,238,233,221,122,255,6,30,91,180,131,231,105,180,67,42,49,48,53,193,42,158,125,30,3,49,95,27,77,48,131,24,249,88,155,193,190,185,110,147,21,13,142,100,116,236,111,121,205,203,155,104,52,53,75,33,199,219,6,214,237,103,11,221,93,181,197,227,156,172,99,163,66,84,159,194,98,140,24,176,107,67,77,2,174,52,201,218,191,134,103,152,2,45,131,105,227,83,214,162,23,48,104,11,229,206,46,180,49,107,208,174,233,81,199,103,182,32,168,14,82,241,190,8,164,37,134,77,222,177,70,254,35,80,66,47,178,135,135,191,1,10,43,177,67,116,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateInitUpdateSessionIdFormulaTaskFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"InitUpdateSessionIdFormulaTask",
				Position = new Point(134, 170),
				ResultParameterMetaPath = @"dbf48210-a598-460b-bfce-b27933ecfff8",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,139,86,14,174,44,14,75,44,202,76,76,202,73,213,115,44,45,201,119,47,205,76,81,142,5,0,88,38,247,74,24,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateQueuesScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"UpdateQueuesScriptTask",
				Position = new Point(393, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,11,45,78,45,114,206,207,203,75,77,46,201,204,207,83,40,69,229,218,42,36,231,231,149,164,86,148,232,133,162,72,88,243,114,185,164,230,164,150,164,250,229,151,56,38,151,148,38,230,4,150,166,150,166,122,150,164,230,22,107,160,154,161,9,84,235,153,7,20,42,241,75,45,199,171,170,40,181,164,180,40,79,161,164,168,52,213,26,0,81,236,215,35,151,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateClearQueueFilteredItemsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"ClearQueueFilteredItemsScriptTask",
				Position = new Point(519, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,80,203,110,194,48,16,60,131,196,63,88,57,217,18,245,15,160,30,170,16,164,72,80,90,65,212,179,21,111,137,69,98,211,245,154,135,170,254,123,215,161,167,114,243,122,30,59,59,103,131,194,66,15,4,226,89,204,166,19,15,23,177,28,103,217,68,192,50,120,15,45,185,224,21,131,122,133,97,144,197,123,130,4,43,215,19,32,216,154,96,40,70,240,163,227,89,22,205,201,26,130,29,196,200,170,218,22,74,215,177,250,74,166,151,217,155,181,120,123,51,104,6,94,129,143,236,185,248,247,163,178,247,68,111,153,91,34,48,98,183,126,244,92,51,99,139,119,231,50,244,105,240,154,211,70,146,75,38,237,221,0,186,161,246,53,92,244,139,181,75,115,139,242,105,99,174,15,209,227,218,125,66,134,149,82,139,217,148,240,38,190,121,225,189,18,93,93,161,77,92,69,134,126,68,107,168,237,132,172,174,45,156,114,37,2,212,72,30,77,99,67,174,119,228,32,234,117,56,84,136,1,101,36,116,254,160,87,1,7,67,178,246,231,112,132,13,80,23,236,136,111,248,2,115,128,121,62,176,40,123,48,248,24,111,215,162,59,209,222,196,35,87,3,250,79,162,248,157,51,77,168,195,112,201,225,102,83,4,74,232,5,97,130,197,47,20,34,252,90,214,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateLogProcessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"LogProcessScriptTask",
				Position = new Point(673, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,141,59,10,194,64,20,69,123,33,123,120,101,132,144,13,4,11,49,8,1,83,88,184,128,129,119,51,12,100,102,228,125,246,175,137,169,108,207,61,156,171,38,169,68,202,80,13,17,116,33,221,65,127,175,146,131,181,79,135,67,95,111,14,6,158,127,82,71,87,102,240,62,77,134,172,183,234,197,58,26,177,226,107,253,241,243,208,156,142,138,165,53,89,130,246,143,26,167,178,212,246,120,221,20,129,185,20,50,113,12,31,37,72,152,105,148,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"ExclusiveGateway1",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateCallQueueUpdateUtilitiesScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"CallQueueUpdateUtilitiesScriptTask",
				Position = new Point(393, 44),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,143,177,10,194,64,16,68,107,3,249,135,37,85,2,146,31,136,10,33,162,164,211,34,149,88,28,113,144,131,228,78,247,246,34,34,254,187,39,87,9,1,187,97,103,31,188,153,20,211,221,195,195,117,183,139,18,116,162,7,45,26,142,214,212,12,202,185,157,234,197,242,179,220,67,86,199,185,199,13,229,6,143,211,153,94,105,178,8,137,26,107,156,176,255,98,53,95,253,8,35,121,230,29,56,20,6,189,104,107,178,37,117,63,135,34,77,222,69,149,38,179,42,229,129,109,15,231,106,47,54,86,81,36,255,75,108,49,64,208,154,176,65,79,145,106,5,99,36,25,226,217,80,80,69,245,1,34,167,252,111,7,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ba49f690-bdb5-4dab-804d-6395616497bf"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2040fa02-b1f4-4c39-85bd-0c29c264a9fa"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c10cdc29-996e-4079-bf44-b3e5e9f0501d"),
				Name = "Terrasoft.Nui.ServiceModel.Extensions",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a22f9d1a-02c1-432e-aa14-06daa10c8e99"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("db7fbfe0-43e5-45c8-ae48-f28c06d2978d"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new QueuesUpdateProcess(userConnection);
		}

		public override object Clone() {
			return new QueuesUpdateProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"));
		}

		#endregion

	}

	#endregion

	#region Class: QueuesUpdateProcess

	/// <exclude/>
	public class QueuesUpdateProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, QueuesUpdateProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public QueuesUpdateProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueuesUpdateProcess";
			SchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_newQueueItemStatusId = () => { return (Guid)(new Guid("2b341a1d-6fa1-4960-9c85-fef60d1bbcc4")); };
			_maxQueueFilteredItemsLifeDays = () => { return (int)(1); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: QueuesUpdateProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: QueuesUpdateProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid UpdateSessionId {
			get;
			set;
		}

		private Func<Guid> _newQueueItemStatusId;
		public virtual Guid NewQueueItemStatusId {
			get {
				return (_newQueueItemStatusId ?? (_newQueueItemStatusId = () => Guid.Empty)).Invoke();
			}
			set {
				_newQueueItemStatusId = () => { return value; };
			}
		}

		private Func<int> _maxQueueFilteredItemsLifeDays;
		public virtual int MaxQueueFilteredItemsLifeDays {
			get {
				return (_maxQueueFilteredItemsLifeDays ?? (_maxQueueFilteredItemsLifeDays = () => 0)).Invoke();
			}
			set {
				_maxQueueFilteredItemsLifeDays = () => { return value; };
			}
		}

		public virtual int AddedQueueItemsCount {
			get;
			set;
		}

		public virtual int DeletedQueueItemsCount {
			get;
			set;
		}

		private LocalizableString _queuesUpdatedMessage;
		public virtual LocalizableString QueuesUpdatedMessage {
			get {
				return _queuesUpdatedMessage ?? (_queuesUpdatedMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.QueuesUpdatedMessage.Value"));
			}
			set {
				_queuesUpdatedMessage = value;
			}
		}

		private LocalizableString _emptyFilterRootSchemaMessage;
		public virtual LocalizableString EmptyFilterRootSchemaMessage {
			get {
				return _emptyFilterRootSchemaMessage ?? (_emptyFilterRootSchemaMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.EmptyFilterRootSchemaMessage.Value"));
			}
			set {
				_emptyFilterRootSchemaMessage = value;
			}
		}

		private LocalizableString _emptyFiltersMessage;
		public virtual LocalizableString EmptyFiltersMessage {
			get {
				return _emptyFiltersMessage ?? (_emptyFiltersMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.EmptyFiltersMessage.Value"));
			}
			set {
				_emptyFiltersMessage = value;
			}
		}

		private LocalizableString _invokeMethodErrorMessage;
		public virtual LocalizableString InvokeMethodErrorMessage {
			get {
				return _invokeMethodErrorMessage ?? (_invokeMethodErrorMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.InvokeMethodErrorMessage.Value"));
			}
			set {
				_invokeMethodErrorMessage = value;
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start;
		public ProcessFlowElement Start {
			get {
				return _start ?? (_start = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start",
					SchemaElementUId = new Guid("d912ed96-306e-4b1b-b6d7-184caeaeae6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate;
		public ProcessTerminateEvent Terminate {
			get {
				return _terminate ?? (_terminate = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate",
					SchemaElementUId = new Guid("935d3cdd-060a-45b0-8bdb-61c264c77e55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _actualizeQueuesTriggerScriptTask;
		public ProcessScriptTask ActualizeQueuesTriggerScriptTask {
			get {
				return _actualizeQueuesTriggerScriptTask ?? (_actualizeQueuesTriggerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizeQueuesTriggerScriptTask",
					SchemaElementUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ActualizeQueuesTriggerScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _fillQueueFilteredItemsScriptTask;
		public ProcessScriptTask FillQueueFilteredItemsScriptTask {
			get {
				return _fillQueueFilteredItemsScriptTask ?? (_fillQueueFilteredItemsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FillQueueFilteredItemsScriptTask",
					SchemaElementUId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FillQueueFilteredItemsScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _initUpdateSessionIdFormulaTask;
		public ProcessScriptTask InitUpdateSessionIdFormulaTask {
			get {
				return _initUpdateSessionIdFormulaTask ?? (_initUpdateSessionIdFormulaTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "InitUpdateSessionIdFormulaTask",
					SchemaElementUId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitUpdateSessionIdFormulaTaskExecute,
				});
			}
		}

		private ProcessScriptTask _updateQueuesScriptTask;
		public ProcessScriptTask UpdateQueuesScriptTask {
			get {
				return _updateQueuesScriptTask ?? (_updateQueuesScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateQueuesScriptTask",
					SchemaElementUId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = UpdateQueuesScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _clearQueueFilteredItemsScriptTask;
		public ProcessScriptTask ClearQueueFilteredItemsScriptTask {
			get {
				return _clearQueueFilteredItemsScriptTask ?? (_clearQueueFilteredItemsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearQueueFilteredItemsScriptTask",
					SchemaElementUId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ClearQueueFilteredItemsScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _logProcessScriptTask;
		public ProcessScriptTask LogProcessScriptTask {
			get {
				return _logProcessScriptTask ?? (_logProcessScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogProcessScriptTask",
					SchemaElementUId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = LogProcessScriptTaskExecute,
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
					SchemaElementUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
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

		private ProcessScriptTask _callQueueUpdateUtilitiesScriptTask;
		public ProcessScriptTask CallQueueUpdateUtilitiesScriptTask {
			get {
				return _callQueueUpdateUtilitiesScriptTask ?? (_callQueueUpdateUtilitiesScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CallQueueUpdateUtilitiesScriptTask",
					SchemaElementUId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CallQueueUpdateUtilitiesScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("aae426bd-5094-4225-a4c8-d0d840e87564"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("7816f084-7e3e-457d-9ad0-317d329b9778"),
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
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[Terminate.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate };
			FlowElements[ActualizeQueuesTriggerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizeQueuesTriggerScriptTask };
			FlowElements[FillQueueFilteredItemsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillQueueFilteredItemsScriptTask };
			FlowElements[InitUpdateSessionIdFormulaTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitUpdateSessionIdFormulaTask };
			FlowElements[UpdateQueuesScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateQueuesScriptTask };
			FlowElements[ClearQueueFilteredItemsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearQueueFilteredItemsScriptTask };
			FlowElements[LogProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogProcessScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[CallQueueUpdateUtilitiesScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CallQueueUpdateUtilitiesScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate":
						CompleteProcess();
						break;
					case "ActualizeQueuesTriggerScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate", e.Context.SenderName));
						break;
					case "FillQueueFilteredItemsScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UpdateQueuesScriptTask", e.Context.SenderName));
						break;
					case "InitUpdateSessionIdFormulaTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillQueueFilteredItemsScriptTask", e.Context.SenderName));
						break;
					case "UpdateQueuesScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ClearQueueFilteredItemsScriptTask", e.Context.SenderName));
						break;
					case "ClearQueueFilteredItemsScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LogProcessScriptTask", e.Context.SenderName));
						break;
					case "LogProcessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActualizeQueuesTriggerScriptTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitUpdateSessionIdFormulaTask", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallQueueUpdateUtilitiesScriptTask", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ExclusiveGateway1");
						break;
					case "CallQueueUpdateUtilitiesScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActualizeQueuesTriggerScriptTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(false);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "false", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow2", "true", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("UpdateSessionId")) {
				writer.WriteValue("UpdateSessionId", UpdateSessionId, Guid.Empty);
			}
			if (!HasMapping("AddedQueueItemsCount")) {
				writer.WriteValue("AddedQueueItemsCount", AddedQueueItemsCount, 0);
			}
			if (!HasMapping("DeletedQueueItemsCount")) {
				writer.WriteValue("DeletedQueueItemsCount", DeletedQueueItemsCount, 0);
			}
			if (!HasMapping("NewQueueItemStatusId")) {
				writer.WriteValue("NewQueueItemStatusId", NewQueueItemStatusId, Guid.Empty);
			}
			if (!HasMapping("MaxQueueFilteredItemsLifeDays")) {
				writer.WriteValue("MaxQueueFilteredItemsLifeDays", MaxQueueFilteredItemsLifeDays, 0);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start", string.Empty));
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
			MetaPathParameterValues.Add("dbf48210-a598-460b-bfce-b27933ecfff8", () => UpdateSessionId);
			MetaPathParameterValues.Add("168bc457-1b6d-4962-83a3-24cc0c53583d", () => NewQueueItemStatusId);
			MetaPathParameterValues.Add("ce429aa3-6cd8-4d38-a6b7-019286ef4823", () => MaxQueueFilteredItemsLifeDays);
			MetaPathParameterValues.Add("f1bbdf69-8cdd-4223-b6f6-0ada6c340c29", () => AddedQueueItemsCount);
			MetaPathParameterValues.Add("222b97a0-00c9-411d-897c-c035aff3a4a7", () => DeletedQueueItemsCount);
			MetaPathParameterValues.Add("fcfa253f-171b-4c14-9460-e9fde6eb0258", () => QueuesUpdatedMessage);
			MetaPathParameterValues.Add("59c9124e-ef80-402a-a878-2c33e9741c0a", () => EmptyFilterRootSchemaMessage);
			MetaPathParameterValues.Add("4212368e-ac01-41d1-8922-c43a0f14a0d7", () => EmptyFiltersMessage);
			MetaPathParameterValues.Add("df7ac21b-eaf4-425a-af1f-8e71d75c59ec", () => InvokeMethodErrorMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "UpdateSessionId":
					if (!hasValueToRead) break;
					UpdateSessionId = reader.GetValue<System.Guid>();
				break;
				case "AddedQueueItemsCount":
					if (!hasValueToRead) break;
					AddedQueueItemsCount = reader.GetValue<System.Int32>();
				break;
				case "DeletedQueueItemsCount":
					if (!hasValueToRead) break;
					DeletedQueueItemsCount = reader.GetValue<System.Int32>();
				break;
				case "NewQueueItemStatusId":
					if (!hasValueToRead) break;
					NewQueueItemStatusId = reader.GetValue<System.Guid>();
				break;
				case "MaxQueueFilteredItemsLifeDays":
					if (!hasValueToRead) break;
					MaxQueueFilteredItemsLifeDays = reader.GetValue<System.Int32>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ActualizeQueuesTriggerScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection userConnection = context.UserConnection;
			Terrasoft.Configuration.QueuesUtilities.UpdateQueuesTrigger(userConnection);
			return true;
		}

		public virtual bool FillQueueFilteredItemsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection userConnection = context.UserConnection;
			var select = 
				new Select(userConnection)
					.Column("Queue", "Id")
					.Column("Queue", "Name")
					.Column("FilterData")
				.From("Queue")
					.Join(JoinType.Inner, "QueueStatus").On("Queue", "StatusId").IsEqual("QueueStatus", "Id")
				.Where("QueueStatus", "IsInitial").IsNotEqual(new QueryParameter(true))
					.And("QueueStatus", "IsFinal").IsNotEqual(new QueryParameter(true))
					.And("Queue", "IsManuallyFilling").IsEqual(new QueryParameter(false))
				as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				try {
					using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
						while (dr.Read()) {
							var queueId = (Guid)dr.GetColumnValue("Id");
							var queueName = (string)dr.GetColumnValue("Name");
							var filterData = (string)dr.GetColumnValue("FilterData");
							FillQueueFilteredItems(userConnection, UpdateSessionId, queueId, queueName, filterData);
						}
					}
				} catch (Exception e) {
					QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
						"FillQueueFilteredItemsScriptTask", e.Message), e);
					throw;
				}
			}
			return true;
		}

		public virtual bool InitUpdateSessionIdFormulaTaskExecute(ProcessExecutingContext context) {
			var localUpdateSessionId = ((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "AutoGuid"));
			UpdateSessionId = (System.Guid)localUpdateSessionId;
			return true;
		}

		public virtual bool UpdateQueuesScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection userConnection = context.UserConnection;
			DeleteNotActualQueueItems(userConnection);
			InsertNewQueueItems(userConnection);
			return true;
		}

		public virtual bool ClearQueueFilteredItemsScriptTaskExecute(ProcessExecutingContext context) {
			var delete = 
				new Delete(UserConnection)
				.From("QueueFilteredItem")
				.Where("UpdateSessionId").IsEqual(new QueryParameter("UpdateSessionId", UpdateSessionId))
					.Or("CreatedOn").IsLessOrEqual(Column.Const(DateTime.UtcNow.AddDays(-MaxQueueFilteredItemsLifeDays)));
			try {
				delete.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"ClearQueueFilteredItemsScriptTask", e.Message), e);
				throw;
			}
			return true;
		}

		public virtual bool LogProcessScriptTaskExecute(ProcessExecutingContext context) {
			string message = string.Format(QueuesUpdatedMessage, AddedQueueItemsCount, DeletedQueueItemsCount);
			QueuesUtilities.LogInfo(message);
			return true;
		}

		public virtual bool CallQueueUpdateUtilitiesScriptTaskExecute(ProcessExecutingContext context) {
			var queuesUpdateUtilities = ClassFactory.Get<QueuesUpdateUtilities> (new[] {
				new ConstructorArgument("userConnection", UserConnection)
			});
			queuesUpdateUtilities.ProcessAutoUpdateQueues();
			queuesUpdateUtilities.ProcessDeleteInactiveQueueItems();
			return true;
		}

			
			public virtual void FillQueueFilteredItems(UserConnection userConnection, Guid updateSessionId, Guid queueId, string queueName, string filterData) {
				Select actualQueueEntitiesSelect = 
				GetActualQueueEntitiesSelect(userConnection, updateSessionId, queueId, queueName, filterData);
			if (actualQueueEntitiesSelect == null) {
				return;
			}
			var insertSelect =
				new InsertSelect(userConnection)
				.Into("QueueFilteredItem")
					.Set("EntityRecordId", "QueueId", "UpdateSessionId")
				.FromSelect(actualQueueEntitiesSelect);
			try {
				insertSelect.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"FillQueueFilteredItems", e.Message), e);
				throw;
			}
			}
			
			
			public virtual void DeleteNotActualQueueItems(UserConnection userConnection) {
				var actualValuesSelect =
				new Select(userConnection)
					.Column("QueueItem2", "Id")
				.From("QueueItem").As("QueueItem2")
				.Join(JoinType.Inner, "QueueFilteredItem")
					.On("QueueFilteredItem", "EntityRecordId").IsEqual("QueueItem2", "EntityRecordId")
					.And("QueueFilteredItem", "QueueId").IsEqual("QueueItem2", "QueueId")
				.Where("QueueFilteredItem", "UpdateSessionId").IsEqual(new QueryParameter("UpdateSessionId", UpdateSessionId))
				as Select;
			actualValuesSelect.SpecifyNoLockHints();
			var delete =
				new Delete(userConnection)
				.From("QueueItem")
				.Join(JoinType.Inner, "Queue")
					.On("Queue", "Id").IsEqual("QueueItem", "QueueId")
				.Where("QueueItem", "Id").Not().In(actualValuesSelect)
					.And("OperatorId").IsNull()
					.And().Exists(new Select(userConnection)
						.Column("Queue", "Id")
						.From("Queue")
						.Where("QueueItem", "QueueId").IsEqual("Queue", "Id")
						.And("Queue", "IsManuallyFilling").IsEqual(new QueryParameter(false))
					as Select)
				as Delete;
			try {
				DeletedQueueItemsCount = delete.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"DeleteNotActualQueueItems", e.Message), e);
				throw;
			}
			}
			
			
			public virtual void InsertNewQueueItems(UserConnection userConnection) {
				var insertSelect = 
				new InsertSelect(userConnection)
				.Into("QueueItem")
					.Set("EntityRecordId", "QueueId", "StatusId")
				.FromSelect(new Select(userConnection)
					.Column("EntityRecordId")
					.Column("QueueId")
					.Column(Column.Const(NewQueueItemStatusId))
					.From("QueueFilteredItem")
					.Where("QueueFilteredItem", "UpdateSessionId").IsEqual(Column.Const(UpdateSessionId))
					.And().Not().Exists(new Select(userConnection)
						.Column("QueueItem", "Id")
						.From("QueueItem")
						.Join(JoinType.Inner, "QueueItemStatus").On("QueueItem", "StatusId").IsEqual("QueueItemStatus", "Id")
						.Where("QueueItem", "QueueId").IsEqual("QueueFilteredItem", "QueueId")
						.And("QueueItem", "EntityRecordId").IsEqual("QueueFilteredItem", "EntityRecordId")
						.And("QueueItemStatus", "IsFinal").IsNotEqual(Column.Const(true))
					as Select)
				as Select);
			try {
				AddedQueueItemsCount = insertSelect.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"InsertNewQueueItems", e.Message), e);
				throw;
			}
			}
			
			
			public virtual Select GetActualQueueEntitiesSelect(UserConnection userConnection, Guid updateSessionId, Guid queueId, string queueName, string filterData) {
				Filters filters = ServiceStackTextHelper.Deserialize<Filters>(filterData);
			string rootSchemaName = filters.RootSchemaName;
			if (string.IsNullOrEmpty(rootSchemaName)) {
				QueuesUtilities.LogWarn(string.Format(EmptyFilterRootSchemaMessage, queueName));
				return null;
			}
			IEntitySchemaQueryFilterItem esqFilters = filters.BuildEsqFilter(rootSchemaName, UserConnection);
			var queryFilterCollection = esqFilters as EntitySchemaQueryFilterCollection;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, rootSchemaName);
			esq.AddColumn("Id");
			if (queryFilterCollection != null) {
				if (queryFilterCollection.Count == 0) {
					QueuesUtilities.LogWarn(string.Format(EmptyFiltersMessage, queueName));
					return null;
				}
				esq.Filters.LogicalOperation = queryFilterCollection.LogicalOperation;
				esq.Filters.IsNot = queryFilterCollection.IsNot;
				foreach (IEntitySchemaQueryFilterItem filter in queryFilterCollection) {
					esq.Filters.Add(filter);
				}
			} else {
				esq.Filters.Add(esqFilters);
			}
			Select select = esq.GetSelectQuery(userConnection);
			select = select
				.Column(Column.Const(queueId))
				.Column(Column.Const(updateSessionId));
			select.SpecifyNoLockHints();
			return select;
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
			var cloneItem = (QueuesUpdateProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

