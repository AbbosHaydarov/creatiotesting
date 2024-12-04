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

	#region Class: StartCaseConsultationThemeSubProcessSchema

	/// <exclude/>
	public class StartCaseConsultationThemeSubProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public StartCaseConsultationThemeSubProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public StartCaseConsultationThemeSubProcessSchema(StartCaseConsultationThemeSubProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "StartCaseConsultationThemeSubProcess";
			UId = new Guid("25ee8460-69b5-4a82-9154-04381b081117");
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
			RealUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117");
			Version = 0;
			PackageUId = new Guid("05591793-3b8e-477e-9dfd-bcd1d14f8fd1");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2f6022a0-883b-48a2-b001-816250994a5a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateConsultationThemeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("486a5918-6016-43e7-9f90-d987e7b5c917"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"ConsultationTheme",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseConsultationThemeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2e779b6c-3b18-42b2-b1a0-a34355b81ce2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"CaseConsultationTheme",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cfb9d771-b844-4a94-a151-dc165f490785}].[Parameter:{cf0af448-1a19-4f7d-9a00-b24e958e19cf}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadMediumParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2538fd92-801e-480b-b688-3f2e431cdd0a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"LeadMedium",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseParameter());
			Parameters.Add(CreateConsultationThemeParameter());
			Parameters.Add(CreateCaseConsultationThemeParameter());
			Parameters.Add(CreateLeadMediumParameter());
		}

		protected virtual void InitializeAddDataCaseConsultationThemeUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("069e38bc-9180-4ab1-90a3-a4ae7e4f4a8a"),
				ContainerUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"c0b15550-eb1b-4557-9847-d193804edd4b",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("71da780b-c1ba-40b0-97c9-b2c28f441333"),
				ContainerUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0efc60b5-0614-43cd-8aad-2045a9692abc"),
				ContainerUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("6781cd68-032b-4915-9207-961fe98a12c4"),
				ContainerUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19c21b99-e97a-45db-9a80-2e167e0fd485"),
				ContainerUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,75,111,35,55,12,254,43,198,236,30,205,64,239,135,175,217,75,128,221,54,104,210,92,146,28,40,137,106,12,76,198,193,204,56,69,26,248,191,151,158,216,155,199,118,131,160,69,129,244,49,7,25,150,244,125,164,68,126,34,239,155,143,227,221,13,53,139,230,148,250,30,135,85,29,15,14,87,61,29,28,247,171,76,195,112,240,121,149,177,93,254,134,169,165,99,236,241,154,70,234,207,176,93,211,240,121,57,140,243,217,115,88,51,111,62,222,78,171,205,226,252,190,57,26,233,250,231,163,194,236,94,97,141,94,73,32,45,45,24,52,21,2,146,131,90,138,182,58,105,107,181,102,112,94,181,235,235,238,11,141,120,140,227,85,179,184,111,38,54,38,168,197,59,155,147,131,36,131,4,19,107,129,64,89,65,181,213,144,240,210,71,69,205,102,222,12,249,138,174,113,50,250,8,206,34,73,107,173,0,74,50,129,177,214,67,12,198,67,145,81,7,97,168,20,147,182,224,221,254,71,224,249,135,243,163,225,199,95,59,234,79,38,222,69,197,118,160,203,3,158,125,49,241,245,114,22,247,170,58,161,20,10,8,65,179,181,128,10,146,16,18,130,116,202,138,24,13,90,220,92,126,184,220,90,44,203,225,166,197,187,179,111,13,31,226,64,15,123,110,158,221,251,211,93,247,23,15,225,187,104,22,23,223,11,224,238,247,193,221,231,33,124,25,189,139,102,126,209,156,172,214,125,222,50,234,237,159,253,109,78,22,196,238,131,63,24,246,223,3,199,4,251,130,29,254,66,253,15,108,113,130,79,75,159,112,196,201,248,41,251,189,39,78,42,90,142,97,5,79,24,193,144,83,16,138,68,136,50,166,170,189,86,181,170,9,253,19,85,234,169,203,244,220,49,41,125,225,77,17,130,242,156,93,86,27,8,70,74,144,217,57,41,109,166,152,203,132,159,44,63,58,179,79,52,158,233,214,109,59,25,24,166,243,111,51,119,231,248,110,229,211,147,72,61,97,88,149,101,93,82,57,234,254,204,85,109,154,205,102,254,84,38,161,152,236,141,85,224,76,12,44,19,77,128,130,7,229,98,145,202,176,128,36,190,42,147,140,40,178,224,163,147,76,10,76,146,122,123,137,22,68,9,201,137,64,21,133,123,39,50,49,193,161,141,50,128,19,210,129,209,196,214,106,20,80,98,240,228,147,205,81,250,55,200,100,213,13,235,118,196,113,185,234,102,35,219,250,95,52,111,20,141,78,202,90,231,3,36,29,56,218,89,70,64,201,26,202,197,169,16,171,229,65,255,35,68,131,54,73,178,44,124,77,92,21,76,160,200,69,162,120,80,9,173,17,213,56,145,237,171,162,17,70,201,24,92,2,235,164,7,227,136,159,159,202,84,62,144,74,37,132,16,165,253,59,68,115,114,55,156,97,191,220,214,214,131,195,117,207,49,26,249,121,164,211,229,62,137,191,159,246,12,229,243,207,110,95,192,103,133,241,51,236,202,108,252,74,242,239,47,31,69,73,138,84,13,100,225,12,24,33,185,224,170,192,205,5,74,12,210,203,130,198,188,166,132,55,59,246,222,149,96,184,142,6,174,32,192,25,207,117,84,186,0,209,98,225,242,161,157,87,85,105,111,242,171,74,48,202,146,137,46,67,220,246,86,38,103,38,224,108,102,97,40,146,134,239,211,187,240,78,202,135,178,58,212,18,89,170,66,18,171,94,36,72,46,4,208,85,145,209,50,151,34,222,208,101,29,117,183,171,246,150,171,6,107,39,95,97,215,81,251,95,81,77,250,139,77,151,222,182,19,33,243,139,91,185,155,55,129,27,150,152,116,1,237,48,69,172,66,86,155,223,171,106,46,55,191,3,138,119,62,88,249,12,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cf0af448-1a19-4f7d-9a00-b24e958e19cf"),
				ContainerUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
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
			ProcessSchemaUserTask adddatacaseconsultationthemeusertask = CreateAddDataCaseConsultationThemeUserTaskUserTask();
			FlowElements.Add(adddatacaseconsultationthemeusertask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("705d3323-59f2-4742-925e-1f7dc40d17c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f40214c-d684-415f-96e2-1850036b1dcd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c962b67f-0c05-4d7d-a641-4470471be942"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ef8c788e-6455-4e5d-8302-edd0277dfcc8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("52cf41e1-4ed3-41fd-a487-0f48c0a5d30c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1216, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3b485728-455b-4022-95ef-a20d16b1a3c5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("52cf41e1-4ed3-41fd-a487-0f48c0a5d30c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1187, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("6f40214c-d684-415f-96e2-1850036b1dcd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b485728-455b-4022-95ef-a20d16b1a3c5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
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
				UId = new Guid("ef8c788e-6455-4e5d-8302-edd0277dfcc8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b485728-455b-4022-95ef-a20d16b1a3c5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataCaseConsultationThemeUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b485728-455b-4022-95ef-a20d16b1a3c5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				CreatedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				Name = @"AddDataCaseConsultationThemeUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(288, 170),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataCaseConsultationThemeUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new StartCaseConsultationThemeSubProcess(userConnection);
		}

		public override object Clone() {
			return new StartCaseConsultationThemeSubProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25ee8460-69b5-4a82-9154-04381b081117"));
		}

		#endregion

	}

	#endregion

	#region Class: StartCaseConsultationThemeSubProcess

	/// <exclude/>
	public class StartCaseConsultationThemeSubProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, StartCaseConsultationThemeSubProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: AddDataCaseConsultationThemeUserTaskFlowElement

		/// <exclude/>
		public class AddDataCaseConsultationThemeUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataCaseConsultationThemeUserTaskFlowElement(UserConnection userConnection, StartCaseConsultationThemeSubProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataCaseConsultationThemeUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("cfb9d771-b844-4a94-a151-dc165f490785");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Case = () => (Guid)((process.Case));
				_recordDefValues_Theme = () => (Guid)((process.ConsultationTheme));
				_recordDefValues_DateTimeStart = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
				_recordDefValues_LeadMedium = () => (Guid)((process.LeadMedium));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Theme", () => _recordDefValues_Theme.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DateTimeStart", () => _recordDefValues_DateTimeStart.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_LeadMedium", () => _recordDefValues_LeadMedium.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Case;
			internal Func<Guid> _recordDefValues_Theme;
			internal Func<DateTime> _recordDefValues_DateTimeStart;
			internal Func<Guid> _recordDefValues_LeadMedium;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,75,111,35,55,12,254,43,198,236,30,205,64,239,135,175,217,75,128,221,54,104,210,92,146,28,40,137,106,12,76,198,193,204,56,69,26,248,191,151,158,216,155,199,118,131,160,69,129,244,49,7,25,150,244,125,164,68,126,34,239,155,143,227,221,13,53,139,230,148,250,30,135,85,29,15,14,87,61,29,28,247,171,76,195,112,240,121,149,177,93,254,134,169,165,99,236,241,154,70,234,207,176,93,211,240,121,57,140,243,217,115,88,51,111,62,222,78,171,205,226,252,190,57,26,233,250,231,163,194,236,94,97,141,94,73,32,45,45,24,52,21,2,146,131,90,138,182,58,105,107,181,102,112,94,181,235,235,238,11,141,120,140,227,85,179,184,111,38,54,38,168,197,59,155,147,131,36,131,4,19,107,129,64,89,65,181,213,144,240,210,71,69,205,102,222,12,249,138,174,113,50,250,8,206,34,73,107,173,0,74,50,129,177,214,67,12,198,67,145,81,7,97,168,20,147,182,224,221,254,71,224,249,135,243,163,225,199,95,59,234,79,38,222,69,197,118,160,203,3,158,125,49,241,245,114,22,247,170,58,161,20,10,8,65,179,181,128,10,146,16,18,130,116,202,138,24,13,90,220,92,126,184,220,90,44,203,225,166,197,187,179,111,13,31,226,64,15,123,110,158,221,251,211,93,247,23,15,225,187,104,22,23,223,11,224,238,247,193,221,231,33,124,25,189,139,102,126,209,156,172,214,125,222,50,234,237,159,253,109,78,22,196,238,131,63,24,246,223,3,199,4,251,130,29,254,66,253,15,108,113,130,79,75,159,112,196,201,248,41,251,189,39,78,42,90,142,97,5,79,24,193,144,83,16,138,68,136,50,166,170,189,86,181,170,9,253,19,85,234,169,203,244,220,49,41,125,225,77,17,130,242,156,93,86,27,8,70,74,144,217,57,41,109,166,152,203,132,159,44,63,58,179,79,52,158,233,214,109,59,25,24,166,243,111,51,119,231,248,110,229,211,147,72,61,97,88,149,101,93,82,57,234,254,204,85,109,154,205,102,254,84,38,161,152,236,141,85,224,76,12,44,19,77,128,130,7,229,98,145,202,176,128,36,190,42,147,140,40,178,224,163,147,76,10,76,146,122,123,137,22,68,9,201,137,64,21,133,123,39,50,49,193,161,141,50,128,19,210,129,209,196,214,106,20,80,98,240,228,147,205,81,250,55,200,100,213,13,235,118,196,113,185,234,102,35,219,250,95,52,111,20,141,78,202,90,231,3,36,29,56,218,89,70,64,201,26,202,197,169,16,171,229,65,255,35,68,131,54,73,178,44,124,77,92,21,76,160,200,69,162,120,80,9,173,17,213,56,145,237,171,162,17,70,201,24,92,2,235,164,7,227,136,159,159,202,84,62,144,74,37,132,16,165,253,59,68,115,114,55,156,97,191,220,214,214,131,195,117,207,49,26,249,121,164,211,229,62,137,191,159,246,12,229,243,207,110,95,192,103,133,241,51,236,202,108,252,74,242,239,47,31,69,73,138,84,13,100,225,12,24,33,185,224,170,192,205,5,74,12,210,203,130,198,188,166,132,55,59,246,222,149,96,184,142,6,174,32,192,25,207,117,84,186,0,209,98,225,242,161,157,87,85,105,111,242,171,74,48,202,146,137,46,67,220,246,86,38,103,38,224,108,102,97,40,146,134,239,211,187,240,78,202,135,178,58,212,18,89,170,66,18,171,94,36,72,46,4,208,85,145,209,50,151,34,222,208,101,29,117,183,171,246,150,171,6,107,39,95,97,215,81,251,95,81,77,250,139,77,151,222,182,19,33,243,139,91,185,155,55,129,27,150,152,116,1,237,48,69,172,66,86,155,223,171,106,46,55,191,3,138,119,62,88,249,12,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "25ee846069b54a82915404381b081117",
							"BaseElements.AddDataCaseConsultationThemeUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("05591793-3b8e-477e-9dfd-bcd1d14f8fd1");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		public StartCaseConsultationThemeSubProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "StartCaseConsultationThemeSubProcess";
			SchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_caseConsultationTheme = () => { return (Guid)((AddDataCaseConsultationThemeUserTask.RecordId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("25ee8460-69b5-4a82-9154-04381b081117");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: StartCaseConsultationThemeSubProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: StartCaseConsultationThemeSubProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid Case {
			get;
			set;
		}

		public virtual Guid ConsultationTheme {
			get;
			set;
		}

		private Func<Guid> _caseConsultationTheme;
		public virtual Guid CaseConsultationTheme {
			get {
				return (_caseConsultationTheme ?? (_caseConsultationTheme = () => Guid.Empty)).Invoke();
			}
			set {
				_caseConsultationTheme = () => { return value; };
			}
		}

		public virtual Guid LeadMedium {
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
					SchemaElementUId = new Guid("6f40214c-d684-415f-96e2-1850036b1dcd"),
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
					SchemaElementUId = new Guid("ef8c788e-6455-4e5d-8302-edd0277dfcc8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AddDataCaseConsultationThemeUserTaskFlowElement _addDataCaseConsultationThemeUserTask;
		public AddDataCaseConsultationThemeUserTaskFlowElement AddDataCaseConsultationThemeUserTask {
			get {
				return _addDataCaseConsultationThemeUserTask ?? (_addDataCaseConsultationThemeUserTask = new AddDataCaseConsultationThemeUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[AddDataCaseConsultationThemeUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataCaseConsultationThemeUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataCaseConsultationThemeUserTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "AddDataCaseConsultationThemeUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("Case")) {
				writer.WriteValue("Case", Case, Guid.Empty);
			}
			if (!HasMapping("ConsultationTheme")) {
				writer.WriteValue("ConsultationTheme", ConsultationTheme, Guid.Empty);
			}
			if (!HasMapping("LeadMedium")) {
				writer.WriteValue("LeadMedium", LeadMedium, Guid.Empty);
			}
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
			MetaPathParameterValues.Add("2f6022a0-883b-48a2-b001-816250994a5a", () => Case);
			MetaPathParameterValues.Add("486a5918-6016-43e7-9f90-d987e7b5c917", () => ConsultationTheme);
			MetaPathParameterValues.Add("2e779b6c-3b18-42b2-b1a0-a34355b81ce2", () => CaseConsultationTheme);
			MetaPathParameterValues.Add("2538fd92-801e-480b-b688-3f2e431cdd0a", () => LeadMedium);
			MetaPathParameterValues.Add("069e38bc-9180-4ab1-90a3-a4ae7e4f4a8a", () => AddDataCaseConsultationThemeUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("71da780b-c1ba-40b0-97c9-b2c28f441333", () => AddDataCaseConsultationThemeUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("0efc60b5-0614-43cd-8aad-2045a9692abc", () => AddDataCaseConsultationThemeUserTask.RecordAddMode);
			MetaPathParameterValues.Add("6781cd68-032b-4915-9207-961fe98a12c4", () => AddDataCaseConsultationThemeUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("19c21b99-e97a-45db-9a80-2e167e0fd485", () => AddDataCaseConsultationThemeUserTask.RecordDefValues);
			MetaPathParameterValues.Add("cf0af448-1a19-4f7d-9a00-b24e958e19cf", () => AddDataCaseConsultationThemeUserTask.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "Case":
					if (!hasValueToRead) break;
					Case = reader.GetValue<System.Guid>();
				break;
				case "ConsultationTheme":
					if (!hasValueToRead) break;
					ConsultationTheme = reader.GetValue<System.Guid>();
				break;
				case "LeadMedium":
					if (!hasValueToRead) break;
					LeadMedium = reader.GetValue<System.Guid>();
				break;
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
			var cloneItem = (StartCaseConsultationThemeSubProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

