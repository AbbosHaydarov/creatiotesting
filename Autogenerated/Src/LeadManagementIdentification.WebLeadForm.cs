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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: LeadManagementIdentificationSchema

	/// <exclude/>
	public class LeadManagementIdentificationSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementIdentificationSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementIdentificationSchema(LeadManagementIdentificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementIdentification";
			UId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
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
			SerializeToDB = true;
			SerializeToMemory = false;
			Tag = @"LeadManagementIdentification";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,82,193,74,195,64,16,61,55,208,127,24,123,74,160,236,15,104,133,16,212,22,60,168,88,60,136,135,77,51,41,11,155,221,56,59,91,45,226,191,59,155,138,16,108,61,120,8,44,111,222,155,55,239,145,105,214,199,218,154,13,236,12,113,212,22,118,222,52,80,110,216,120,87,182,140,180,106,208,177,105,205,70,39,40,47,224,99,154,77,2,147,113,91,208,125,111,191,7,107,178,176,128,3,174,174,186,158,247,231,194,51,45,228,143,72,164,131,111,89,61,97,173,150,204,189,42,107,33,234,193,35,12,72,229,29,227,59,171,42,18,137,29,156,45,192,69,107,15,102,147,95,54,227,149,149,239,58,239,210,115,205,198,26,54,24,212,13,242,157,78,171,202,145,246,63,199,168,7,124,141,24,184,72,129,62,229,219,105,2,139,186,185,151,186,126,138,89,162,237,145,228,182,202,234,16,174,101,159,167,125,58,227,226,246,56,245,50,119,248,6,226,37,238,49,177,75,218,198,78,252,158,95,134,208,39,166,249,44,6,36,25,56,28,78,158,205,97,61,2,138,249,159,234,113,151,162,30,3,69,202,56,36,61,145,80,157,254,53,82,208,85,147,196,210,210,52,251,2,31,101,196,242,90,2,0,0 };
			RealUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			Version = 0;
			PackageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1300b53e-296c-4858-8368-493adc25a74c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIdentificationPassedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("27623c14-f1c7-4872-8f1c-45103cd82954"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"IdentificationPassed",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateIdentificationPassedParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f7cf3a22-2a33-428e-9e2b-5f3622d92f72"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,93,111,218,48,20,253,47,121,174,171,196,113,112,194,219,212,178,9,105,90,43,21,245,101,233,195,141,125,1,107,9,137,108,211,141,33,254,251,174,19,96,116,98,42,221,203,154,151,216,71,199,231,158,251,181,141,84,13,206,125,129,6,163,113,52,67,107,193,181,115,127,253,209,212,30,237,39,219,174,187,232,42,114,104,13,212,230,39,234,1,159,104,227,111,193,3,61,217,150,191,21,202,104,92,158,215,40,163,171,50,50,30,27,71,28,122,34,210,10,69,30,3,195,68,197,76,40,41,88,174,37,176,88,38,186,72,56,143,115,149,14,204,191,137,223,180,77,7,22,135,24,189,252,188,63,206,54,93,160,38,4,168,158,98,92,187,218,131,105,48,225,38,43,168,106,212,116,247,118,141,4,121,107,26,202,6,103,166,193,123,176,20,43,232,180,1,34,210,28,106,23,88,53,206,253,228,71,103,209,57,211,174,94,51,87,175,155,213,41,155,4,240,120,221,219,137,123,143,129,121,15,126,217,75,76,201,214,174,119,249,97,177,176,184,0,111,158,79,77,124,195,77,207,187,172,126,244,64,83,151,30,161,94,227,73,204,151,153,220,64,231,135,132,134,240,68,176,102,177,188,56,215,99,197,94,75,151,19,216,29,200,23,106,158,205,129,143,8,124,14,192,160,114,56,150,209,215,169,187,251,190,66,251,160,150,216,192,80,181,167,107,66,255,0,142,250,227,109,146,198,113,149,165,200,120,49,82,76,228,89,206,242,116,148,51,81,164,160,21,207,64,10,181,123,26,124,24,215,213,176,121,60,134,251,140,160,247,37,11,63,66,228,92,243,12,171,130,186,17,75,38,164,24,177,74,101,21,75,19,148,9,7,208,26,128,58,28,190,208,136,118,97,20,212,119,29,90,106,116,95,232,248,252,136,190,152,237,144,190,109,91,63,36,117,44,95,112,211,123,57,12,9,199,164,82,50,43,24,72,73,67,146,243,132,85,192,57,75,85,150,136,74,139,34,134,138,204,208,126,135,10,63,180,107,171,246,251,228,134,197,254,167,133,253,15,107,248,150,205,58,59,219,151,204,234,123,153,194,233,123,153,180,93,180,251,5,66,214,75,222,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a01e5fd1-7cbb-4e06-9188-a9656c381385"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4db6d4f9-57aa-44ef-8934-56b12a060e0e"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc3c82bb-8c59-485f-9376-5880ae2ce035"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf6ac2d-9970-48a9-80e2-c7d41b6c0c2e"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76636537-e5df-47a7-9eb6-124881330bf3"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("232523cc-cb63-410d-8f7c-58cdcf2ef818"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("6c984967-8a07-4d65-aefc-418e5a11cdcd"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3cd6198-af4e-409b-8ba3-0851372ea038"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7e4ceefa-cd15-47a3-8a3b-c8ad4ed1ef7f"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a326237-a485-4b38-9337-3aa27272cdd9"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f7b52dbf-c358-489e-bf2c-3c4ff7924a2c"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd6ab013-fc1e-4bc5-a25b-6855ace31f97"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c6cfc815-55cb-4def-b83c-14b182d467ce"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("72ded882-b97d-4f56-91cb-1e6e212f4218"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a075eb5-bcac-445c-993d-bd329be8d6dc"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,21,83,201,13,4,33,12,171,40,82,46,114,104,170,9,4,250,47,97,179,31,94,198,248,194,109,135,218,49,176,122,11,20,15,67,46,55,88,103,245,62,216,198,136,159,89,44,46,95,176,153,47,168,36,66,69,63,208,12,210,211,27,73,232,75,45,169,88,2,24,103,131,198,122,16,249,20,40,56,60,106,85,221,253,41,175,216,54,247,223,117,2,221,94,16,236,1,15,203,119,118,171,7,126,97,235,110,158,251,146,58,32,150,7,165,7,225,120,136,138,69,121,189,175,61,183,54,38,168,231,128,50,101,132,243,134,139,233,24,177,215,58,246,29,127,155,18,47,44,234,0,61,182,160,198,23,28,113,210,150,141,245,252,211,40,60,106,244,119,167,160,175,70,248,237,11,231,138,245,146,122,42,247,139,44,196,126,4,210,50,160,50,129,45,122,128,211,163,207,243,139,117,63,186,113,177,55,1,46,244,17,118,55,164,31,31,166,237,145,138,82,213,223,82,52,63,79,128,228,159,56,55,65,212,75,72,60,182,187,143,187,203,231,135,135,43,18,106,215,184,179,225,220,18,6,19,64,96,178,119,123,124,239,94,225,14,2,191,127,225,53,194,146,230,57,193,144,171,173,41,241,190,201,232,28,89,9,114,39,81,13,58,176,163,10,136,252,148,109,158,96,237,227,229,69,194,4,79,87,15,200,2,246,83,133,155,143,199,161,25,181,124,117,241,234,58,5,71,115,132,79,131,80,146,13,82,219,167,195,75,70,254,85,197,161,105,102,6,242,102,5,28,10,59,45,33,30,45,19,44,94,247,124,35,44,155,199,157,253,61,105,188,3,185,123,1,159,21,206,34,108,198,95,163,237,202,41,99,10,153,231,124,166,80,230,12,151,150,214,93,70,149,250,41,190,251,168,19,94,206,161,172,6,149,56,203,137,188,188,172,234,180,126,247,58,7,183,1,203,12,68,53,223,184,243,13,180,155,47,61,177,90,241,105,45,247,191,103,155,54,231,35,52,194,166,23,48,129,241,121,182,198,41,125,245,186,78,209,140,26,103,143,234,230,127,208,228,52,98,83,173,101,42,255,122,134,131,87,2,100,203,159,105,207,84,114,44,96,108,79,236,20,101,252,174,15,35,217,129,217,225,127,227,52,160,237,14,41,162,189,174,141,192,247,253,197,173,51,76,230,143,65,187,100,18,127,6,173,60,191,173,186,198,239,15,157,239,2,19,193,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17573208-3be8-4476-9823-f565b0714f28"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("807ae5d1-ceac-47d5-8eb5-4720a6cd38c0"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5770885f-4a81-42ac-b246-d9db3aa13a28"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadContactsByLeadCommunicationsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b62c39d0-3349-4a21-9582-0f3e9fab1b13"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,75,115,219,70,12,254,43,26,157,218,153,172,103,223,220,245,173,117,213,78,14,77,50,77,38,151,216,135,125,96,109,78,41,82,67,82,105,92,143,254,123,65,82,150,237,68,118,24,213,169,149,84,58,104,100,24,11,2,216,239,195,98,193,171,105,40,92,211,188,112,115,152,30,79,223,64,93,187,166,74,237,209,175,121,209,66,253,91,93,45,23,211,103,211,6,234,220,21,249,223,16,7,249,44,230,237,47,174,117,184,228,234,244,198,194,233,244,248,116,187,141,211,233,179,211,105,222,194,188,65,29,92,162,41,117,20,52,16,5,218,18,25,147,34,94,68,69,88,52,153,143,201,8,227,211,160,121,159,241,217,135,188,105,155,225,17,189,245,212,255,124,115,185,232,52,21,10,66,53,95,184,58,111,170,114,45,100,157,52,111,102,165,243,5,68,20,180,245,18,80,212,214,249,28,163,129,55,249,28,94,185,26,159,213,25,170,58,17,42,37,87,52,157,86,1,169,157,125,88,212,208,52,121,85,62,236,220,73,85,44,231,229,109,109,52,0,155,63,215,254,208,222,201,78,243,149,107,47,122,19,239,78,170,178,117,161,61,169,230,243,101,153,7,215,162,250,241,90,120,118,244,28,189,94,245,65,252,116,126,94,195,57,254,251,61,220,4,242,39,92,246,86,198,101,23,23,68,220,195,183,174,88,194,45,143,238,198,121,226,22,157,11,189,217,181,27,147,112,219,185,73,213,43,76,126,240,151,147,33,152,201,90,239,199,254,17,205,210,15,155,180,222,249,29,192,66,101,146,218,133,140,120,201,56,145,186,11,135,107,77,88,224,140,27,0,229,188,248,220,126,116,80,128,251,208,194,182,161,69,236,61,88,94,44,231,190,11,103,27,34,174,29,185,134,196,184,28,110,129,4,55,15,98,226,218,7,84,170,243,243,139,209,65,111,82,247,185,184,57,10,23,215,202,35,109,110,15,68,163,240,125,39,24,172,92,255,68,210,61,111,94,254,85,66,253,58,92,192,220,13,169,59,59,66,233,71,130,89,1,115,40,219,227,43,39,157,78,137,6,194,152,77,152,76,193,136,51,156,19,109,164,164,153,54,96,65,173,112,193,198,161,227,43,29,172,145,86,103,196,56,154,33,37,181,34,14,82,32,146,25,204,61,99,33,134,216,45,153,149,109,222,94,14,144,56,190,74,0,130,71,195,72,6,92,18,233,132,36,150,225,38,10,106,4,200,40,173,48,105,117,54,132,155,55,139,194,93,190,221,68,245,7,184,56,41,240,11,169,85,55,237,164,35,212,164,74,19,76,239,178,104,243,242,188,163,107,1,161,219,202,163,217,220,229,69,111,167,43,49,184,26,76,240,73,41,74,24,164,72,36,197,98,98,64,115,66,5,203,164,128,132,0,66,188,172,240,131,107,152,182,60,179,70,19,240,26,243,225,101,32,206,2,35,148,162,219,158,51,150,32,123,120,235,158,151,247,113,83,126,155,220,188,83,192,7,181,49,52,29,151,201,45,232,102,15,151,238,65,235,83,146,118,21,246,221,94,209,180,15,228,22,77,175,241,8,44,24,21,4,9,41,120,18,19,99,196,122,238,48,49,44,106,10,72,132,160,123,123,155,7,222,64,250,134,233,163,173,124,194,166,181,53,196,251,89,15,249,162,58,199,205,45,94,46,160,238,183,120,141,130,45,160,188,131,230,174,6,213,85,213,14,149,101,227,235,182,83,191,247,99,83,190,163,225,42,80,75,162,163,88,190,165,200,136,149,8,19,102,193,9,197,34,87,178,107,13,58,207,98,16,44,8,17,137,55,74,33,115,45,39,142,10,32,212,243,160,12,115,222,57,121,104,173,118,109,173,198,101,247,155,105,173,82,16,120,46,129,37,218,105,218,181,5,137,120,38,45,17,96,156,74,49,97,187,24,118,55,46,188,200,76,204,72,150,148,239,64,43,8,86,53,67,130,6,43,65,132,104,244,154,228,135,190,237,190,3,97,92,14,15,125,219,126,245,109,146,38,72,44,90,146,44,126,73,46,53,30,227,52,17,97,44,112,165,157,11,81,62,74,223,246,123,229,243,2,38,139,139,170,28,96,176,62,46,117,162,66,115,124,34,68,138,141,35,245,24,41,199,90,37,185,137,188,251,133,244,222,180,111,158,38,166,76,114,68,105,143,222,42,240,196,71,236,55,241,144,116,130,38,141,32,235,172,30,120,250,64,227,54,46,135,7,158,238,23,79,45,94,169,156,81,130,80,188,238,16,105,84,34,198,38,73,152,225,38,67,138,56,7,254,81,120,250,243,178,201,75,60,246,63,101,170,202,172,21,94,51,162,176,204,19,105,141,37,30,180,68,186,10,43,21,126,100,232,59,187,213,125,109,39,251,138,109,231,184,246,160,115,76,90,108,133,188,119,68,72,134,248,135,64,241,190,136,95,1,233,96,162,115,78,91,245,168,87,64,249,189,94,1,199,101,242,112,5,252,191,93,1,147,76,6,135,116,138,100,54,195,66,145,5,28,13,24,73,9,55,120,9,212,145,89,166,112,168,187,250,122,174,221,241,38,80,173,109,198,5,137,153,194,182,194,35,64,157,103,158,96,127,227,0,11,131,228,1,7,21,43,124,119,208,93,132,94,87,203,58,172,199,175,205,240,210,96,167,151,1,79,49,227,127,196,177,253,199,23,182,157,102,220,79,48,185,254,210,97,244,214,73,240,152,145,209,97,102,187,135,51,219,39,24,199,254,139,227,245,158,1,231,46,232,187,51,138,28,123,114,252,151,167,195,23,206,251,190,223,234,57,126,140,181,211,120,234,80,114,247,251,53,217,247,58,110,57,224,110,191,113,119,24,31,108,59,148,190,104,26,240,4,23,253,67,115,241,122,92,115,241,21,111,146,171,233,234,31,149,133,232,176,122,38,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15307ea3-405b-4286-937e-bbd0152634bb"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0de7902-f6c1-44eb-87ff-109bad0eb346"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d29cd82a-8e0d-4086-8795-48b2899e16af"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("daf2cf98-3c7e-4055-b671-143255e4ffb9"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("34ed4a32-1e5a-4623-ae6a-18a622bf6230"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97666c94-b7fa-4cf1-858f-96a7f5e41511"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("10568b26-1c18-4f39-9578-4a72a1c5fb66"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("935c4f95-44b6-44e3-920e-5b06a85a9a77"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("567adf56-c83c-4371-b0d7-e3c15c4a747e"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7ad0d0ed-5315-4834-9632-bc717ea4b547"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("06ba8c97-f038-45da-8d5c-e5fa72c64ac0"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("085f20cb-53af-486b-a15f-5bc389f586df"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7b7d4ca0-20b2-450c-a302-c217ce695e2c"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("316aa43c-1aa6-47f1-aaf7-572b6f838fcf"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2cc24615-28c1-4668-8f49-c93ae2c5896a"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,75,76,53,72,53,49,77,78,212,77,54,177,52,213,53,73,75,53,215,77,52,182,76,209,53,78,76,50,55,50,183,72,53,52,51,52,7,0,106,93,85,138,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4d0581e-c249-4b18-a38c-f40592d4085d"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2729cf7a-36f6-4003-b06a-e8cb957b2269"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f215686f-4d81-4543-93aa-539f611453e4"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeChangeLeadContactAllParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("9a626ad2-321e-427a-9f24-760d9280a022"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("564a7988-620b-401f-9bfc-8041ac06be95"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7b1963b-962d-4921-a62e-3119d14d8a66"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,201,110,219,48,16,253,23,157,195,64,251,226,91,145,184,133,129,162,9,16,35,151,42,135,33,57,178,137,106,3,73,167,117,13,255,123,135,146,173,58,133,139,56,189,52,58,72,212,195,227,155,55,219,206,19,53,24,243,5,26,244,102,222,18,181,6,211,85,246,250,163,170,45,234,79,186,219,244,222,149,103,80,43,168,213,79,148,35,62,151,202,222,130,5,186,178,43,127,43,148,222,172,60,175,81,122,87,165,167,44,54,134,56,116,133,115,12,68,86,73,38,68,84,176,88,248,57,43,178,132,51,4,0,206,101,18,9,136,70,230,223,196,111,186,166,7,141,99,140,65,190,26,142,203,109,239,168,1,1,98,160,40,211,181,7,48,114,38,204,188,5,94,163,164,127,171,55,72,144,213,170,161,108,112,169,26,188,7,77,177,156,78,231,32,34,85,80,27,199,170,177,178,243,31,189,70,99,84,215,190,102,174,222,52,237,41,155,4,112,250,61,216,241,7,143,142,121,15,118,61,72,44,200,214,126,112,249,97,181,210,184,2,171,158,79,77,124,195,237,192,187,172,126,116,65,82,151,30,161,222,224,73,204,151,153,220,64,111,199,132,198,240,68,208,106,181,190,56,215,169,98,175,165,27,18,216,31,201,23,106,158,205,33,76,9,124,118,192,168,114,60,150,222,215,133,185,251,222,162,126,16,107,108,96,172,218,211,53,161,127,0,147,254,108,23,68,190,207,147,8,89,88,164,130,197,121,146,179,60,74,115,22,23,17,72,17,38,144,197,98,255,52,250,80,166,175,97,251,56,133,251,140,32,15,37,115,31,66,170,176,224,60,247,99,22,248,81,200,98,137,212,151,34,72,24,47,146,60,46,42,159,87,85,64,29,118,143,107,68,183,82,2,234,187,30,53,53,122,40,180,127,126,68,95,204,182,75,95,119,157,29,147,154,202,231,220,12,94,142,67,2,60,11,35,78,209,179,2,124,22,39,50,102,144,209,171,72,49,13,57,249,4,233,198,141,246,219,85,248,161,219,104,113,216,39,51,46,246,63,45,236,127,88,195,183,108,214,217,217,190,100,86,223,203,20,46,222,203,164,237,189,253,47,4,255,142,248,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d16c9f4-5c23-4097-8d07-fac1cb716e39"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,77,83,219,48,16,253,43,30,193,49,202,88,214,135,37,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,59,99,43,237,208,76,254,123,21,39,1,66,219,83,117,176,165,213,190,183,187,207,207,27,114,30,95,87,72,42,242,128,125,15,67,23,226,244,162,235,113,122,219,119,14,135,97,122,221,57,104,234,95,96,27,188,133,30,150,24,177,127,132,102,141,195,117,61,196,73,118,10,35,19,114,254,99,188,37,213,211,134,204,34,46,191,207,124,98,47,181,65,225,138,130,218,160,25,21,121,238,169,78,33,42,180,194,80,50,163,188,100,9,236,186,102,189,108,111,48,194,45,196,23,82,109,200,200,150,8,192,11,147,123,169,105,46,5,80,225,181,164,166,16,138,122,175,133,82,104,185,209,156,108,39,100,112,47,184,132,177,232,59,88,48,8,169,154,161,165,204,45,21,104,45,213,14,28,13,129,27,171,132,22,12,221,14,124,200,127,7,62,157,61,205,134,111,63,91,236,239,71,222,42,64,51,224,98,154,162,159,2,87,13,46,177,141,213,70,74,93,148,192,29,149,22,29,21,65,66,154,217,104,90,26,94,42,45,10,102,57,223,38,192,155,154,213,134,229,82,105,91,40,202,28,211,9,194,13,53,178,76,59,40,11,96,78,6,171,212,14,114,213,198,58,190,94,140,26,85,27,192,28,133,116,64,157,48,50,161,176,164,192,141,167,28,108,89,148,26,153,98,229,118,113,182,216,13,230,235,97,213,192,235,227,159,243,221,33,248,204,117,109,168,251,37,142,187,8,46,14,153,125,205,154,221,85,154,177,110,50,104,125,182,122,233,90,28,166,95,234,126,136,89,157,190,108,214,133,172,199,97,221,196,186,125,78,200,166,65,23,235,174,157,206,252,190,234,234,196,48,31,235,110,230,123,223,205,73,53,255,151,243,14,239,189,206,167,222,251,108,187,57,153,204,201,125,183,238,221,142,145,167,195,229,135,129,199,34,99,202,167,227,209,103,41,210,174,155,230,16,185,132,8,199,196,99,184,243,117,168,209,207,218,251,163,189,70,150,252,176,232,95,30,199,181,239,237,127,96,55,208,194,51,246,95,147,0,239,189,191,117,249,144,100,60,18,219,194,200,188,100,129,150,8,38,249,92,21,84,123,6,212,48,99,3,47,121,17,66,49,162,239,48,96,143,173,195,211,198,152,178,200,149,100,84,7,44,168,96,210,36,188,207,41,232,156,123,161,52,247,158,31,240,195,168,246,238,7,63,244,181,147,106,75,182,219,197,246,55,23,17,232,91,84,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c6aba36-8758-475f-ae50-d4a503c1975d"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddContactByLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("c43dec79-6b59-4fc6-94f0-bcc6a7f8c091"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61b7d5bc-8334-4d0a-8ec3-aac02f0f6b0d"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ec4e60e4-4bd2-476d-bfa5-f3879991dce5"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("fc9a7fd7-6ae6-4198-801f-ed65a0714560"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0698fbce-2359-4022-88df-2b5fa4260af7"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,91,109,111,27,185,17,254,43,170,238,128,246,128,208,224,59,135,2,138,2,189,203,21,41,46,109,16,95,239,75,146,15,67,114,120,81,33,75,134,180,110,155,26,254,239,125,86,177,243,118,61,53,238,41,141,93,73,31,214,210,122,201,37,185,243,112,158,153,121,246,114,250,229,240,234,92,166,179,233,247,178,94,243,102,213,135,147,175,87,107,57,121,178,94,85,217,108,78,190,91,85,94,204,255,201,101,33,79,120,205,103,50,200,250,7,94,92,200,230,187,249,102,120,48,121,191,217,244,193,244,203,191,109,255,59,157,61,187,156,62,26,228,236,47,143,26,122,79,49,246,20,172,87,90,68,43,239,76,82,156,187,87,213,217,168,189,169,33,5,70,227,186,90,92,156,45,31,203,192,79,120,120,57,157,93,78,183,189,161,3,14,181,114,202,86,249,212,154,242,150,88,145,235,69,133,154,109,105,45,167,222,105,122,245,96,186,169,47,229,140,183,55,125,219,216,196,34,46,6,163,168,11,122,48,33,43,106,77,43,38,237,154,143,228,90,115,99,227,235,235,223,54,124,246,197,179,71,155,63,255,125,41,235,211,109,191,179,206,139,141,188,56,193,217,15,78,60,92,200,153,44,135,217,37,123,142,189,235,170,140,201,93,249,232,12,110,99,173,138,228,189,78,145,36,75,184,66,131,55,171,57,187,140,53,147,207,49,41,98,157,148,111,49,40,150,94,49,80,146,192,198,212,86,219,216,228,225,114,152,15,175,190,222,174,209,236,146,98,144,98,67,87,46,123,131,21,113,93,177,175,90,213,68,206,187,72,156,184,95,189,248,226,197,228,87,191,157,156,14,235,249,242,199,147,135,103,231,195,171,201,239,38,255,23,211,154,77,126,115,151,231,209,69,156,109,100,84,18,152,189,103,231,85,54,53,41,167,201,137,111,62,59,186,143,143,231,163,167,117,199,31,79,198,208,153,130,83,154,106,81,158,96,112,52,110,72,134,44,37,226,192,44,229,30,62,158,143,158,214,236,78,79,195,235,46,221,180,172,122,198,193,91,31,225,46,52,246,4,202,98,67,100,174,205,143,211,248,234,171,113,219,110,243,205,249,130,95,253,240,211,221,251,169,112,155,44,112,56,249,118,190,222,12,147,57,28,210,100,213,39,107,217,92,44,6,60,212,9,60,206,66,234,48,95,45,225,192,150,3,215,97,178,196,216,127,230,193,255,146,254,182,128,184,85,7,15,207,120,190,216,199,72,110,58,186,253,16,126,127,177,153,47,193,3,38,231,47,87,203,189,172,202,79,122,156,221,182,135,199,171,50,95,200,77,251,215,38,112,254,30,55,121,215,8,46,159,191,166,56,207,167,179,231,63,71,114,174,255,190,54,251,247,105,206,135,12,231,249,244,193,243,233,233,234,98,93,199,30,29,126,124,243,142,245,109,111,178,189,228,131,159,55,148,6,103,150,23,139,197,245,153,111,120,224,155,11,111,78,175,218,188,207,165,61,90,158,222,48,153,109,47,250,250,163,254,205,225,230,243,122,108,191,164,217,99,94,242,143,178,254,19,22,224,237,216,223,140,242,123,44,227,77,199,173,21,199,70,68,233,36,52,226,218,170,146,56,171,166,37,26,42,90,247,210,182,173,159,74,151,181,44,171,252,151,3,123,42,155,237,106,143,92,242,122,92,227,82,93,77,175,174,30,188,203,48,59,217,222,131,116,101,170,103,12,168,144,202,177,4,85,168,103,91,177,121,4,109,119,50,76,42,145,52,195,149,137,143,216,159,34,14,37,58,173,36,212,226,27,27,199,33,28,22,195,244,77,215,234,48,21,39,240,35,158,12,86,132,152,113,223,84,57,22,11,90,22,199,93,120,143,123,240,183,120,180,147,191,174,202,4,227,88,0,221,71,108,31,177,13,108,123,109,53,233,6,150,153,16,19,116,113,42,151,241,103,233,181,181,106,130,209,117,39,182,107,104,169,250,230,84,7,79,85,94,227,27,249,152,85,100,128,158,16,64,38,205,135,133,109,145,100,201,182,168,172,179,32,138,30,119,43,61,21,101,74,179,98,186,139,28,104,207,216,126,42,117,126,62,199,52,127,189,185,230,68,71,116,31,209,61,155,106,97,242,38,118,21,216,142,17,127,43,32,251,28,21,145,119,186,38,239,163,105,59,209,157,125,45,148,2,16,217,208,139,23,210,170,4,196,64,169,101,49,136,136,40,68,57,44,116,215,212,139,201,90,84,48,13,251,93,29,91,5,172,107,117,201,96,27,44,154,123,218,51,186,191,17,112,240,97,156,231,17,215,159,133,145,23,155,3,220,99,71,102,6,60,220,11,24,57,53,195,72,207,228,210,93,114,160,199,118,23,35,79,108,99,182,22,150,31,3,44,173,128,242,149,94,188,146,34,33,71,241,38,55,186,21,35,15,206,137,45,153,97,117,1,200,138,13,24,211,33,170,104,5,193,131,147,162,99,220,137,107,231,61,50,126,130,12,83,139,240,81,12,50,158,29,16,222,73,216,135,110,185,21,127,88,184,102,166,138,199,233,209,61,114,223,200,130,123,85,50,120,12,117,19,16,171,176,13,82,247,140,235,63,30,201,248,189,134,117,37,11,146,219,49,18,192,1,149,151,20,85,230,226,84,13,128,0,188,65,73,37,222,10,214,12,239,193,156,68,97,187,64,160,237,129,109,74,248,41,168,194,48,91,176,113,191,27,214,166,192,41,117,231,96,245,118,28,17,60,53,50,9,109,204,36,24,211,49,94,99,236,97,193,154,50,107,221,186,81,174,33,159,142,187,58,85,156,175,202,230,68,173,246,36,154,101,223,238,122,53,89,174,134,201,197,70,38,242,58,59,120,36,227,159,1,221,89,151,24,74,39,165,251,214,74,80,242,2,152,178,178,30,1,111,66,169,43,235,244,63,77,163,165,146,156,43,146,149,70,96,140,72,185,3,221,174,85,21,58,55,215,13,0,26,118,135,218,168,11,101,236,0,48,227,134,236,32,60,56,161,3,91,85,78,222,249,98,186,205,222,29,22,186,61,174,174,8,98,84,177,99,201,172,51,106,50,210,68,85,76,181,5,199,221,187,79,136,238,211,199,167,71,108,127,22,207,125,231,176,173,89,247,202,61,170,68,25,26,10,105,126,52,68,104,40,160,201,112,85,12,136,130,219,137,109,235,8,33,117,242,170,119,3,120,138,215,99,26,13,197,223,160,75,203,13,49,3,181,195,194,118,240,58,166,218,157,50,174,135,49,119,129,233,225,193,170,172,107,132,44,165,166,148,220,167,195,246,209,113,127,54,90,126,231,192,141,136,144,82,52,136,215,187,217,86,254,45,92,46,226,195,6,58,173,225,210,93,232,187,29,55,42,58,181,199,46,138,117,28,21,86,96,228,200,8,32,101,78,54,75,21,29,122,203,135,5,238,84,173,144,80,86,92,24,137,201,88,224,194,29,33,49,233,60,233,108,33,68,75,244,233,192,125,93,223,62,210,242,35,186,145,226,14,20,83,135,165,219,48,38,231,162,69,5,76,144,171,203,210,216,53,248,109,141,226,244,46,116,195,61,11,75,11,240,248,30,0,213,80,212,229,2,131,6,234,187,196,100,98,229,3,203,165,25,96,91,55,44,129,70,126,5,178,82,41,216,48,81,254,175,82,192,143,188,118,204,237,211,161,187,243,63,142,216,62,122,238,209,115,155,212,179,51,144,54,151,134,156,15,194,230,132,196,187,23,85,188,214,70,147,105,237,63,212,191,170,52,75,144,106,168,4,185,44,172,62,5,149,41,71,37,28,178,229,44,100,56,238,31,219,91,228,238,2,199,155,11,142,226,172,67,39,167,173,64,134,21,52,84,195,46,32,103,108,243,152,20,138,90,153,28,140,152,40,177,134,180,211,196,59,28,84,105,26,153,98,98,164,165,16,90,169,156,19,172,20,5,226,76,216,228,115,142,135,229,190,184,55,174,12,190,15,237,139,134,251,66,123,100,215,64,255,155,142,25,197,54,7,135,182,103,247,117,138,102,3,143,95,143,174,235,94,214,130,196,85,84,120,17,20,26,159,17,208,120,7,141,36,141,146,137,210,161,14,16,95,200,167,91,225,58,54,157,202,88,1,50,182,140,172,18,108,42,23,147,224,136,124,229,130,72,52,90,218,93,226,101,231,160,38,196,218,100,228,165,60,2,78,224,154,138,210,6,19,171,99,57,201,29,24,174,109,72,208,154,66,8,211,125,64,24,78,145,70,54,0,92,231,110,81,15,138,16,195,236,59,163,244,7,89,54,89,31,49,125,47,49,173,11,196,141,4,220,32,83,49,138,116,107,83,5,78,30,82,73,104,44,154,1,188,236,45,125,53,135,4,255,1,59,149,241,208,5,145,98,181,176,93,195,174,18,71,47,118,119,34,169,39,56,229,104,161,19,214,216,96,124,230,164,216,65,36,222,173,239,133,106,71,93,168,31,22,166,61,150,52,141,32,142,40,230,142,242,83,8,212,12,232,25,20,213,22,57,183,224,114,51,251,22,91,174,142,242,233,123,138,232,224,33,175,24,219,247,2,21,164,111,163,98,195,186,12,55,208,93,215,90,196,73,184,157,151,46,100,113,91,144,103,30,77,181,85,164,134,29,196,32,37,248,80,156,141,16,24,236,14,48,91,233,86,91,169,170,162,158,11,174,153,139,66,174,24,185,101,24,125,49,20,157,213,230,176,16,253,177,175,65,238,17,209,215,47,113,29,3,234,207,0,233,59,247,182,19,20,26,166,66,186,165,108,129,252,15,126,21,138,33,212,38,70,80,49,53,221,114,45,102,183,102,26,201,79,10,176,88,110,30,52,147,43,8,68,53,21,60,188,136,206,168,36,53,127,96,249,224,143,125,231,116,143,144,126,255,77,198,35,178,143,200,134,179,214,193,100,143,18,46,148,26,80,20,244,206,215,111,67,64,144,13,101,54,231,88,119,59,107,242,144,118,106,98,168,60,128,75,200,182,17,64,114,100,36,255,16,253,7,196,219,90,151,195,66,246,199,190,20,191,71,100,127,248,150,243,17,219,7,138,237,23,87,255,2,14,145,72,204,99,71,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77a80f56-4b60-48bc-be27-e96ffd4cc59b"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bd8bab91-7c9c-4f46-a8ee-de69c8479c49"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddContactAdressParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("5a0a517a-3cd6-4838-89ed-dd198ad96f83"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Value = @"d54d2218-61c8-413a-a1b7-5748c7e25f56",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dcf0939b-5ae1-4506-a7a2-453c0eb2f2d8"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,75,111,219,70,16,254,43,129,206,217,100,223,143,220,82,39,109,13,20,73,80,7,57,36,246,97,159,14,81,74,20,72,42,173,27,248,191,103,72,201,138,100,75,214,138,72,108,181,182,15,178,180,24,206,206,99,191,225,204,183,95,71,190,180,77,243,198,142,227,232,197,232,125,172,107,219,84,169,125,246,107,81,182,177,254,173,174,102,211,209,211,81,19,235,194,150,197,191,49,204,215,95,135,162,125,101,91,11,143,124,61,253,174,225,116,244,226,116,179,142,211,209,211,211,81,209,198,113,3,50,240,136,145,154,70,31,18,18,202,83,196,141,52,72,51,207,17,139,49,48,42,73,242,66,207,37,183,41,63,170,198,83,91,199,249,30,189,250,212,127,125,127,49,237,68,9,44,248,94,164,104,170,201,98,145,117,70,52,175,39,214,149,49,192,239,182,158,69,88,106,235,98,12,222,196,247,197,56,190,179,53,236,213,233,169,186,37,16,74,182,108,58,169,50,166,246,245,63,211,58,54,77,81,77,118,25,87,206,198,147,85,105,80,16,151,63,23,230,224,222,198,78,242,157,109,63,247,42,142,193,172,203,222,202,151,231,231,117,60,183,109,241,101,213,136,191,226,69,47,151,23,63,120,32,64,150,62,216,114,22,87,246,92,247,228,200,78,219,185,67,243,237,65,160,46,206,63,103,251,186,140,216,46,119,41,44,78,175,132,51,117,110,244,129,74,88,252,210,45,204,181,92,125,61,29,125,58,110,222,254,61,137,245,137,255,28,199,118,30,181,179,103,176,122,109,97,169,255,197,87,194,48,118,130,69,68,141,244,136,107,161,33,146,82,67,76,153,13,158,10,171,184,191,60,155,219,81,52,211,210,94,124,88,110,247,71,180,97,17,178,238,31,172,104,165,180,150,148,34,234,2,232,80,70,35,147,56,70,204,19,98,45,246,78,24,7,25,134,63,120,70,19,131,173,73,30,25,29,28,226,36,41,164,35,8,99,31,73,226,222,144,36,22,30,14,64,88,148,132,226,148,44,10,202,5,196,131,96,200,70,97,144,99,132,123,199,163,163,78,222,174,252,120,178,13,92,252,191,9,174,151,33,116,50,115,129,28,148,229,197,112,195,9,37,183,195,108,97,200,147,182,151,238,0,23,83,172,227,196,199,249,57,93,58,189,102,241,77,96,118,169,254,116,80,208,236,29,95,129,230,2,22,60,105,71,131,84,72,145,128,17,23,201,33,109,84,68,62,112,203,176,182,70,121,220,235,91,110,248,123,213,125,89,81,182,135,146,27,56,157,43,3,208,157,245,176,227,196,171,20,53,74,138,71,64,124,34,29,236,12,194,78,59,22,20,37,30,227,29,200,104,222,204,202,114,27,58,232,38,116,144,255,31,58,242,226,120,135,232,40,250,180,44,130,219,121,192,21,75,80,198,9,226,172,59,49,73,17,100,48,3,11,153,17,142,106,162,156,222,209,101,60,214,192,188,24,62,214,192,157,53,48,57,101,89,146,22,37,38,29,34,156,96,36,147,38,136,120,153,164,136,2,51,206,214,107,224,47,179,166,152,192,1,191,86,7,179,21,221,168,131,223,21,94,213,66,99,28,167,68,49,196,157,5,12,11,165,144,197,60,32,6,149,53,209,224,177,245,252,17,33,59,122,241,172,24,62,34,100,39,66,148,196,46,73,13,93,184,147,17,133,68,8,114,70,107,132,49,9,18,71,195,180,151,235,8,121,21,75,200,73,125,113,13,33,217,138,110,32,228,187,194,30,33,29,68,202,234,188,240,182,124,59,141,181,93,188,163,182,188,204,215,186,128,110,70,169,171,170,189,246,206,234,70,134,126,235,229,91,52,107,8,232,12,97,208,118,18,154,12,138,12,142,24,23,198,34,221,125,144,32,180,141,146,67,61,14,131,199,5,9,101,3,198,29,133,168,119,48,80,90,138,17,40,53,136,193,106,84,218,170,68,220,15,111,138,232,193,55,69,71,213,108,210,246,199,33,163,33,202,139,225,254,133,96,105,196,45,189,208,170,204,178,15,234,13,236,44,79,137,81,165,5,208,5,22,102,24,232,219,96,134,209,150,34,47,40,64,66,71,143,141,127,128,217,253,51,158,247,226,57,201,205,11,225,254,201,61,105,193,241,231,211,186,250,82,64,86,111,205,241,149,185,27,83,108,165,211,209,72,137,128,110,128,58,66,187,62,13,104,32,68,5,229,158,56,238,140,120,136,41,254,88,76,243,242,155,23,191,77,249,189,53,189,31,143,223,61,159,86,77,107,203,39,190,10,113,75,242,184,12,222,82,74,80,208,73,0,209,96,128,104,112,198,35,207,25,39,70,91,2,47,131,7,152,188,163,162,205,44,189,121,1,28,80,122,123,11,110,171,187,87,2,55,147,234,168,144,240,20,65,44,9,14,124,98,164,200,113,24,146,45,177,2,166,42,207,29,139,15,48,169,139,169,61,47,175,121,49,220,27,149,75,27,110,38,238,14,90,190,188,70,110,155,37,248,7,90,66,169,73,134,3,219,141,29,149,208,45,3,93,173,21,77,96,14,181,76,5,37,188,129,81,242,18,110,128,186,248,158,84,179,218,47,110,92,154,249,213,207,160,43,157,123,184,168,217,231,238,101,227,237,71,14,101,122,40,247,20,63,247,46,98,208,29,195,61,92,31,12,226,60,183,16,236,67,178,191,54,228,230,178,215,123,83,212,247,192,60,15,36,147,7,115,179,143,103,39,143,241,219,155,210,123,12,108,30,81,244,51,153,160,253,136,157,65,132,205,61,52,141,3,168,149,225,148,197,129,250,183,78,46,12,31,215,15,212,189,149,193,122,248,52,123,160,190,173,206,157,195,167,186,3,117,238,229,250,252,117,39,195,207,79,155,101,46,71,151,223,0,57,71,56,128,194,38,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55cf3377-2bf5-4a73-8eb5-34e7b911258b"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,4,0,183,239,220,131,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("6d55db5f-8e6c-420b-9a07-be564e8b90da"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6aa29df7-9dcf-4eea-b7dd-70cbb55c6070"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,28,69,16,253,149,101,201,3,72,238,77,223,47,43,33,4,33,32,75,1,162,36,228,129,56,15,213,221,213,176,98,61,99,205,206,130,130,229,127,231,204,218,38,78,128,13,1,43,33,196,243,176,151,158,233,154,234,158,58,117,78,213,156,206,111,141,207,78,120,190,156,63,226,97,160,77,223,198,197,157,126,224,197,253,161,47,188,217,44,238,245,133,214,171,95,41,175,249,62,13,116,204,35,15,143,105,189,229,205,189,213,102,60,152,189,56,109,126,48,191,245,243,238,236,124,249,228,116,126,56,242,241,119,135,21,214,85,36,82,20,165,168,173,72,97,139,101,145,101,33,65,177,153,98,156,245,181,78,147,75,191,222,30,119,95,243,72,247,105,252,113,190,60,157,239,172,193,128,103,21,93,202,81,56,114,70,88,103,130,200,170,177,104,129,56,150,108,149,243,118,126,118,48,223,148,31,249,152,118,55,125,62,185,58,91,181,86,81,120,85,162,176,202,224,198,42,7,225,130,141,37,176,118,205,249,105,242,197,245,207,39,62,249,240,201,225,230,219,95,58,30,30,238,236,46,27,173,55,252,116,129,209,151,6,238,174,249,152,187,113,121,74,150,124,107,178,8,165,82,19,214,27,133,69,106,45,124,180,86,6,31,57,177,59,195,132,223,119,115,121,234,75,138,54,249,32,34,201,32,108,245,78,16,183,2,71,35,59,82,170,212,82,167,41,119,187,113,53,62,187,179,219,163,229,105,240,57,90,95,188,240,212,156,176,178,104,145,92,240,194,21,87,115,145,213,107,41,207,158,126,248,116,90,88,93,109,78,214,244,236,241,31,215,247,128,169,206,214,248,88,124,185,26,54,227,108,133,71,54,235,219,108,224,205,118,61,174,186,31,102,120,38,107,46,227,170,239,22,159,213,138,241,205,185,205,147,23,194,225,170,213,211,163,243,168,58,154,47,143,254,42,174,46,190,207,119,241,197,200,122,57,168,142,230,7,71,243,135,253,118,40,147,69,131,63,95,92,89,206,238,38,187,75,94,250,123,25,69,24,233,182,235,245,197,200,23,52,210,229,133,151,195,125,93,181,21,215,195,238,225,101,240,236,172,200,139,67,252,201,199,229,113,238,219,191,153,246,53,117,244,3,15,223,96,3,158,251,254,187,151,143,176,141,151,134,139,108,210,122,141,8,193,163,21,22,207,88,68,203,78,36,171,82,45,209,41,159,213,110,246,3,110,60,112,87,248,31,58,246,128,55,187,221,158,224,123,225,215,180,85,103,243,179,179,131,171,160,206,46,218,66,202,8,131,8,158,96,229,69,98,38,161,17,233,92,40,105,27,218,94,80,43,107,92,169,45,99,174,210,194,114,182,200,10,62,137,40,147,174,44,85,240,62,188,95,160,182,218,197,236,147,20,141,131,194,51,14,36,162,14,81,52,73,33,167,90,109,136,215,13,234,59,184,253,13,162,223,10,162,179,78,78,6,213,68,96,2,128,216,107,17,171,34,145,84,202,205,4,163,91,211,251,16,237,0,50,153,61,38,24,70,140,89,27,69,198,149,130,50,146,129,231,162,75,227,215,66,52,32,204,92,16,180,42,74,43,108,212,64,180,206,94,52,178,182,21,71,153,226,126,154,14,197,43,25,116,17,153,52,12,80,54,34,42,77,194,155,96,21,25,206,200,96,239,23,162,89,53,36,57,131,69,133,134,28,87,201,8,50,205,139,106,117,178,68,21,251,228,175,25,209,223,31,222,191,125,210,111,70,90,99,180,242,13,184,223,10,184,141,118,20,12,20,171,108,118,2,39,77,116,13,154,11,94,250,134,52,46,13,149,55,74,215,181,214,96,166,28,97,34,188,178,141,173,136,177,22,97,40,41,15,1,17,61,249,253,116,237,101,50,209,69,65,45,131,156,12,248,62,199,92,132,211,202,37,128,41,66,136,254,39,192,173,168,69,169,107,18,169,105,20,11,90,194,209,84,144,23,89,102,41,157,172,148,248,37,112,135,128,234,4,46,128,115,61,196,213,180,172,204,208,90,156,144,38,170,45,5,197,199,171,97,10,129,60,219,118,165,239,218,106,56,230,10,248,117,35,149,113,150,105,131,127,125,183,131,240,108,213,181,126,56,166,115,246,29,152,70,156,27,184,244,67,157,29,214,27,180,190,147,84,12,241,205,198,59,37,98,99,164,121,0,2,243,171,4,169,72,83,173,143,166,86,243,90,104,117,86,101,25,195,196,164,18,96,67,253,11,113,13,78,37,45,57,133,8,167,140,218,139,214,130,108,147,26,92,104,54,98,69,53,2,238,201,123,81,76,11,182,90,89,147,123,207,42,230,90,216,72,6,21,155,140,246,129,149,16,39,57,161,118,150,49,135,132,253,48,200,20,215,76,197,15,71,160,251,246,201,208,255,188,66,200,220,96,251,157,196,54,212,47,74,211,4,50,240,80,111,182,197,34,162,243,104,69,213,102,115,213,20,115,82,175,133,109,214,213,84,84,115,168,118,193,191,150,167,95,14,133,179,146,5,170,193,55,111,188,220,139,237,170,84,165,66,25,6,76,133,204,6,81,161,12,200,34,73,139,200,71,52,151,154,174,31,219,227,128,175,61,216,184,60,127,211,25,122,195,1,62,21,129,46,183,73,106,238,146,160,5,13,133,144,208,136,209,160,144,64,45,201,240,70,165,166,178,84,109,203,44,216,77,221,157,228,42,164,102,156,138,30,28,141,13,26,149,121,111,128,75,143,120,38,180,52,177,170,118,78,167,169,76,196,192,208,105,21,98,172,6,122,207,200,43,164,108,171,68,254,10,9,122,32,37,131,118,175,206,130,101,10,50,198,236,92,185,238,58,242,78,191,237,198,225,166,57,244,110,178,150,76,173,160,249,0,154,82,14,193,165,19,122,57,232,182,138,8,110,128,4,76,228,75,123,45,80,19,94,49,76,47,107,132,118,1,164,83,34,124,169,168,152,208,166,133,148,180,186,185,72,251,89,43,39,233,224,58,136,19,126,216,169,103,69,8,127,81,157,129,64,46,89,203,154,175,31,212,31,253,151,81,237,125,116,154,130,19,89,107,198,150,160,243,139,252,134,91,166,168,44,152,92,42,163,38,84,207,62,248,100,246,213,118,85,23,119,143,79,198,103,31,207,62,157,253,47,86,181,196,50,238,245,253,79,219,147,133,147,209,132,60,153,54,109,114,206,67,205,216,156,5,222,3,68,27,208,149,172,42,47,26,26,226,104,158,145,104,6,231,193,115,82,248,22,149,80,5,162,201,177,147,198,154,253,41,240,163,127,246,202,107,54,189,207,250,243,199,240,111,204,93,89,255,213,51,139,207,183,155,85,55,189,38,251,251,11,190,17,93,239,88,126,254,59,1,255,170,252,252,244,236,55,73,40,141,234,193,31,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9f11eba-9282-49e7-842b-28c1d0f2190f"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03d86494-8865-4f33-baa9-734e477aa2f5"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddContactWebParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("97a7e2ca-58ad-4a27-8a87-3f50772b77be"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Value = @"004a9121-21f8-4a1e-8918-45c0f756ea41",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f713b4e-bdb9-470a-b959-23af1cb99aaa"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,93,111,218,48,20,253,47,121,174,171,196,118,66,194,219,212,177,9,105,106,43,21,117,15,163,15,55,246,13,88,115,72,100,135,110,12,241,223,119,147,0,163,19,163,116,210,214,230,37,201,209,241,185,95,190,103,29,40,11,222,95,67,137,193,48,152,160,115,224,171,162,185,252,96,108,131,238,163,171,150,117,112,17,120,116,6,172,249,129,186,199,71,218,52,239,161,1,58,178,158,254,82,152,6,195,233,113,141,105,112,49,13,76,131,165,39,14,29,41,116,34,84,81,68,76,69,81,193,100,170,129,101,188,144,44,201,115,149,101,89,40,57,111,213,78,136,95,85,101,13,14,251,24,157,124,209,125,78,86,117,75,141,8,80,29,197,248,106,177,5,69,155,132,31,45,32,183,168,233,191,113,75,36,168,113,166,164,106,112,98,74,188,5,71,177,90,157,170,133,136,84,128,245,45,203,98,209,140,190,215,14,189,55,213,226,185,228,236,178,92,28,178,73,0,247,191,219,116,194,46,199,150,121,11,205,188,147,24,83,90,155,46,203,119,179,153,195,25,52,230,241,48,137,175,184,234,120,231,245,143,14,104,154,210,61,216,37,30,196,124,90,201,21,212,77,95,80,31,158,8,206,204,230,103,215,186,239,216,115,229,114,2,235,29,249,76,205,163,53,240,132,192,199,22,232,85,118,159,211,224,203,216,223,124,91,160,187,83,115,44,161,239,218,195,37,161,191,1,123,253,225,58,18,97,152,199,2,25,207,18,69,157,140,83,150,138,36,101,50,19,160,21,143,97,32,213,230,161,207,195,248,218,194,234,126,31,238,19,130,222,182,172,125,17,146,132,60,201,213,64,48,149,74,96,50,207,105,46,49,72,150,230,105,164,57,207,165,140,21,77,152,30,58,35,82,228,58,149,146,113,224,146,73,165,82,150,105,136,152,24,112,46,10,57,80,66,71,167,251,52,246,215,75,107,255,180,3,252,216,14,240,55,191,3,159,49,247,100,21,231,45,194,121,61,60,114,137,162,147,139,64,57,244,150,213,53,120,23,183,155,154,173,102,70,129,189,169,209,193,150,31,30,239,233,147,97,180,119,214,85,85,211,223,196,125,191,218,43,212,69,218,21,148,13,66,1,42,148,12,138,56,99,146,103,192,210,68,208,53,26,164,74,235,56,76,184,18,212,26,50,229,182,162,187,106,233,212,214,4,125,239,198,127,229,178,175,224,157,47,177,195,163,134,116,142,193,188,21,235,248,183,246,240,10,91,143,47,95,228,255,178,73,155,96,243,19,184,24,168,34,211,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9021827f-1e50-40f2-8b7f-ec1b0e056ccb"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,4,0,183,239,220,131,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("aa2e3f7d-4042-4910-b0eb-0f5b57896d58"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7a98d7a0-39d9-4231-b19a-9c603fa6baf0"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,149,75,111,220,54,16,199,191,202,66,201,209,92,240,253,216,91,225,164,128,1,167,53,226,52,61,216,62,12,201,97,34,84,43,25,146,182,133,187,216,239,222,145,188,27,63,218,218,46,138,162,45,16,29,36,145,226,60,56,250,255,56,219,234,245,120,115,141,213,170,250,128,125,15,67,87,198,229,113,215,227,242,172,239,18,14,195,242,180,75,208,212,191,66,108,240,12,122,88,227,136,253,71,104,54,56,156,214,195,120,180,120,104,86,29,85,175,127,158,191,86,171,139,109,117,50,226,250,135,147,76,222,179,202,218,154,16,152,3,237,153,230,46,50,47,193,50,101,4,198,44,101,240,5,200,56,117,205,102,221,190,195,17,206,96,252,92,173,182,213,236,141,28,164,34,165,213,198,179,36,18,103,58,243,196,160,160,97,90,88,171,139,204,198,113,172,118,71,213,144,62,227,26,230,160,119,198,156,107,8,66,10,38,69,161,232,32,144,249,32,232,205,36,94,156,177,8,90,76,198,251,245,119,134,23,175,46,78,134,239,127,105,177,63,159,253,174,10,52,3,94,45,105,246,209,196,219,6,215,216,142,171,173,128,226,185,204,129,133,34,21,211,146,91,22,67,66,6,200,35,231,134,103,8,184,35,131,47,213,92,109,157,3,207,139,177,76,71,75,123,243,49,177,136,210,49,12,182,148,172,83,50,33,238,174,94,93,77,41,230,122,184,110,224,230,227,239,51,253,38,231,197,166,77,93,91,234,126,141,121,65,111,35,164,113,17,97,160,81,215,46,26,132,188,168,219,210,245,107,24,235,174,93,30,247,8,35,125,235,49,117,125,94,156,228,219,16,215,15,254,243,253,32,219,203,91,185,92,86,171,203,63,19,204,254,121,91,158,135,146,121,172,150,203,234,232,178,58,239,54,125,154,60,42,26,188,185,183,187,57,200,188,228,209,240,32,15,154,105,55,77,179,159,121,3,35,28,22,30,166,187,92,151,26,243,73,123,126,80,197,236,133,239,47,246,7,183,195,117,155,219,223,49,123,7,45,124,194,254,59,42,192,93,238,95,178,252,64,101,60,56,142,50,24,238,68,97,14,33,48,141,86,50,159,5,176,32,66,44,202,41,89,138,156,173,223,99,193,30,219,132,15,19,19,54,162,178,70,48,95,80,18,17,38,144,125,230,140,84,53,97,231,85,206,106,111,63,204,213,158,184,220,231,53,149,106,87,237,118,71,247,105,149,81,104,233,4,201,176,56,77,130,180,137,5,29,10,243,66,128,8,147,194,75,126,146,86,46,75,2,52,142,21,40,64,59,210,133,5,101,29,139,198,43,225,192,162,196,244,159,160,21,52,16,99,116,152,8,65,251,211,86,9,170,154,148,204,122,77,135,148,245,24,208,60,162,213,166,224,117,160,205,120,224,142,78,34,107,136,237,146,168,238,30,13,8,145,114,202,147,201,219,118,172,199,155,227,185,70,171,45,58,163,130,160,66,10,157,5,29,11,66,177,24,157,163,178,40,157,13,90,170,116,121,158,241,247,19,194,19,199,203,111,235,126,24,23,53,253,178,69,87,136,224,97,211,140,117,251,137,168,111,26,76,51,222,63,98,252,10,244,191,2,116,206,81,145,108,145,113,135,164,219,76,64,71,71,104,103,142,86,120,106,3,37,230,167,128,126,113,98,47,5,58,43,197,173,75,192,32,207,9,145,214,65,38,203,44,240,132,232,188,79,138,63,9,180,144,69,100,167,136,101,149,168,233,130,145,44,196,76,253,27,57,38,40,89,149,168,255,9,160,79,187,238,167,205,245,50,123,109,83,164,83,164,8,159,9,211,64,30,84,41,83,135,20,133,98,131,119,106,105,193,71,8,212,55,105,167,137,229,34,4,229,40,129,170,38,178,229,24,148,79,246,57,192,246,241,142,187,245,122,211,214,105,238,147,139,238,122,126,76,157,111,130,234,47,4,250,218,74,255,103,173,244,37,66,123,142,188,171,221,111,14,176,79,189,86,11,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("89ff5387-057a-41f9-a2cd-98c33da073a9"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc163fe7-1547-4a7a-9a04-4e4956124bae"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadContactsByLeadEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6514abc-f96a-4d19-b5f8-f55b1ac00b83"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,75,111,27,55,16,254,43,130,78,45,16,26,228,146,203,229,234,22,184,106,225,75,18,52,70,46,145,15,124,12,229,69,247,33,236,82,105,84,65,255,189,195,221,149,44,39,178,163,186,77,237,2,245,193,144,70,195,143,223,112,190,121,108,167,182,212,93,247,70,87,48,157,77,175,161,109,117,215,248,112,241,115,81,6,104,127,105,155,245,106,250,106,218,65,91,232,178,248,3,220,96,159,187,34,252,164,131,198,35,219,197,29,194,98,58,91,156,198,88,76,95,45,166,69,128,170,67,31,60,162,105,238,64,39,142,164,169,118,68,24,46,137,206,165,37,210,105,33,82,46,165,100,106,240,124,8,124,254,185,232,66,55,92,209,163,251,254,227,245,102,21,61,83,52,216,166,90,233,182,232,154,122,52,178,104,45,186,121,173,77,9,14,13,161,93,3,154,66,91,84,24,13,92,23,21,188,211,45,222,21,129,154,104,66,39,175,203,46,122,149,224,195,252,243,170,133,174,43,154,250,113,114,151,77,185,174,234,99,111,4,128,195,215,145,15,237,73,70,207,119,58,220,246,16,31,47,155,58,104,27,46,155,170,90,215,133,213,1,221,103,163,241,230,226,10,89,239,250,32,94,47,151,45,44,241,231,79,112,23,200,111,176,233,81,206,123,93,60,224,48,135,31,116,185,134,35,70,247,227,188,212,171,72,161,135,29,105,76,236,49,185,73,211,59,76,126,48,155,201,16,204,100,244,251,177,191,162,91,155,33,73,99,230,159,32,150,52,247,60,19,206,144,44,81,154,8,202,115,98,120,194,136,246,78,209,92,58,159,88,247,173,124,68,41,192,67,106,97,167,212,194,95,188,88,222,172,43,19,195,57,165,136,61,145,189,36,206,123,195,19,146,72,212,163,154,216,115,64,167,182,88,222,158,29,244,225,233,190,21,119,130,198,213,222,249,76,204,211,129,72,52,126,138,134,1,101,255,17,139,238,170,123,251,123,13,237,123,123,11,149,30,158,238,230,2,173,95,24,230,37,84,80,135,217,86,11,45,189,167,150,48,150,123,34,36,199,119,84,73,66,164,18,130,102,82,65,14,233,14,15,28,8,205,182,210,230,74,228,50,35,74,211,140,8,39,83,162,193,91,34,152,130,84,51,102,157,117,241,200,188,14,69,216,12,146,152,109,61,0,79,156,98,36,131,68,16,161,185,32,57,179,25,225,84,113,16,78,228,92,249,221,205,16,110,209,173,74,189,249,112,136,234,87,208,110,82,226,63,44,173,182,11,147,88,80,147,198,79,240,121,215,101,40,234,101,44,215,18,108,76,229,197,188,210,69,217,227,196,22,131,167,173,76,128,82,106,8,87,40,149,216,53,240,230,20,57,88,46,149,207,149,49,41,67,229,225,31,158,225,44,7,16,60,67,23,228,42,140,7,162,93,146,19,202,83,78,37,254,152,24,253,120,234,174,234,135,106,83,252,55,107,243,94,3,31,220,206,41,211,243,94,242,132,186,217,227,173,123,240,250,186,72,99,135,253,248,162,202,180,15,228,168,76,71,61,2,48,171,82,203,137,245,214,16,231,25,35,185,73,52,161,148,57,73,1,11,193,202,30,239,112,225,157,164,239,42,253,108,148,175,170,105,68,67,189,223,244,146,47,155,37,38,183,124,187,130,182,79,241,168,130,19,162,188,167,230,216,131,218,166,9,67,103,57,112,61,53,245,123,30,123,93,24,233,172,6,225,137,203,5,150,99,226,57,49,76,122,146,169,52,195,190,110,242,132,211,158,221,247,162,118,143,141,230,128,122,100,2,175,103,10,217,48,100,67,169,39,220,164,70,33,75,101,192,35,27,92,28,99,118,223,55,235,214,142,179,183,27,54,198,39,109,130,207,177,224,253,131,59,219,151,139,208,147,22,156,103,88,91,254,234,38,114,114,13,56,167,95,252,63,176,95,224,192,126,134,89,252,55,198,235,3,211,237,41,234,99,199,115,232,220,201,241,111,78,135,239,218,236,119,211,221,159,61,201,224,253,26,16,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("881a211c-0037-4de8-9966-fd5b76082530"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b0558b6-d02e-43db-a632-da912ff74169"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38ac0d8a-57fb-4d3c-a724-83243171725c"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2306c9f4-91b3-4ae6-9d0d-b85b15f043a5"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("91e3ad56-02d2-495e-8f8d-6839c1e13901"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09b2ffa0-b537-4970-bb51-a8da7fb89215"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,176,50,212,241,76,1,82,6,0,110,89,182,126,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f289649e-c0c3-403b-8124-ffe171aafe33"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e7d2a1ae-2033-4d71-9990-c4c12f4faa89"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("681c5445-3ca2-45de-bf7c-0f37318944d1"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95b392b6-a727-407b-a3ec-157c1314469b"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0eadc500-3c91-49a1-8071-9d0668f51d38"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("849f1602-4ec0-45ef-a640-370b4ec656e7"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("847ce0c0-4e8f-4238-a637-16f20d906278"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cfe3a33-faaf-4cb5-b49e-d1eadaa81bec"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,75,76,53,72,53,49,77,78,212,77,54,177,52,213,53,73,75,53,215,77,52,182,76,209,53,78,76,50,55,50,183,72,53,52,51,52,7,0,106,93,85,138,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f61ce3ad-7460-43d4-b04a-9a8735ba629d"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("98cf1789-f51a-4231-b152-7212be2cdca3"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1921c84b-08d6-4bab-b0f8-1e4173f757ea"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeChangeLeadContactEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("788c3395-e8dc-443e-9c81-e57decd44c14"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("40c79c51-5e3e-4a77-881f-bfb3b5148e9c"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3da883c3-07af-4baf-9a48-e1f261dbd978"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,23,157,195,192,122,153,162,111,69,226,22,6,138,38,64,140,92,170,28,86,228,74,38,42,89,2,73,165,117,13,255,123,151,146,237,58,133,139,56,189,52,186,72,26,12,103,103,151,179,219,64,214,96,237,23,104,48,152,5,75,52,6,108,91,186,235,143,186,118,104,62,153,182,239,130,171,192,162,209,80,235,159,168,70,124,174,180,187,5,7,116,100,155,255,86,200,131,89,126,94,35,15,174,242,64,59,108,44,113,232,8,47,195,2,36,47,24,136,24,89,130,92,178,12,100,196,74,133,34,2,5,177,72,202,145,249,55,241,155,182,233,192,224,88,99,144,47,135,207,229,166,243,212,144,0,57,80,180,109,215,123,48,246,38,236,124,13,69,141,138,254,157,233,145,32,103,116,67,221,224,82,55,120,15,134,106,121,157,214,67,68,42,161,182,158,85,99,233,230,63,58,131,214,234,118,253,154,185,186,111,214,167,108,18,192,227,239,222,206,100,240,232,153,247,224,86,131,196,130,108,237,6,151,31,170,202,96,5,78,63,159,154,248,134,155,129,119,217,252,232,128,162,91,122,132,186,199,147,154,47,59,185,129,206,141,13,141,229,137,96,116,181,186,184,215,227,196,94,107,55,34,176,59,144,47,212,60,219,67,52,37,240,217,3,163,202,225,51,15,190,46,236,221,247,53,154,7,185,194,6,198,169,61,93,19,250,7,112,212,159,109,195,120,50,41,82,26,98,36,166,146,37,89,154,177,44,158,102,44,17,49,40,25,165,192,19,185,123,26,125,104,219,213,176,121,60,150,251,140,160,246,35,243,47,66,162,105,42,20,79,56,43,80,9,150,200,136,212,184,23,71,1,80,68,113,150,150,64,55,236,31,127,17,109,165,37,212,119,29,26,186,232,97,208,147,243,17,125,145,109,223,190,105,91,55,54,117,28,159,119,51,120,57,132,68,132,10,120,166,40,36,225,148,179,36,12,5,43,196,36,101,101,194,37,79,226,184,72,5,133,100,71,251,237,39,252,208,246,70,238,247,201,142,139,253,79,11,251,31,214,240,45,155,117,54,219,151,100,245,189,164,112,241,94,146,182,11,118,191,0,88,136,108,183,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bec4aa50-4e70-47b5-99c8-d0f15b4b12f8"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,82,219,48,16,253,21,143,224,24,101,36,91,182,36,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,155,177,149,118,210,140,255,189,178,147,0,161,237,169,58,216,214,106,223,219,221,231,167,29,57,15,219,87,36,37,121,192,174,131,190,245,97,126,209,118,56,191,237,90,139,125,63,191,110,45,212,213,47,48,53,222,66,7,107,12,216,61,66,189,193,254,186,234,195,44,57,133,145,25,57,255,49,157,146,242,105,71,22,1,215,223,23,46,178,91,103,85,206,210,130,58,229,13,21,169,226,20,12,203,105,202,160,40,28,79,65,115,19,193,182,173,55,235,230,6,3,220,66,120,33,229,142,76,108,145,0,156,208,204,229,138,178,92,0,21,78,229,84,167,34,242,57,37,138,2,77,166,85,70,134,25,233,237,11,174,97,42,250,14,22,28,188,210,168,169,204,89,172,142,198,80,101,193,82,239,51,109,10,161,4,71,59,130,15,249,239,192,167,179,167,69,255,237,103,131,221,253,196,91,122,168,123,92,205,99,244,83,224,170,198,53,54,161,220,33,75,81,42,166,168,146,169,166,194,106,73,141,102,146,114,161,164,79,145,203,84,170,33,2,222,212,44,119,2,57,50,169,51,10,57,218,40,14,8,106,164,137,179,89,31,123,229,133,100,136,35,228,170,9,85,216,94,76,26,149,59,64,134,34,183,64,173,208,57,21,30,37,133,76,59,154,129,25,107,32,47,184,28,86,103,171,113,48,87,245,175,53,108,31,255,156,239,14,193,37,182,109,124,213,173,113,250,10,96,67,159,152,109,82,143,71,113,198,170,158,127,169,186,62,36,85,252,157,73,235,147,14,251,77,29,170,230,57,166,215,53,218,80,181,205,124,225,246,165,94,79,92,242,177,216,110,185,55,219,146,148,203,127,217,237,240,222,139,123,106,184,207,94,91,146,217,146,220,183,155,206,142,140,89,220,92,126,152,114,42,50,165,124,218,30,205,21,35,205,166,174,15,145,75,8,112,76,60,134,91,87,249,10,221,162,185,63,122,106,98,97,135,69,255,242,56,174,125,111,255,3,187,129,6,158,177,251,26,5,120,239,253,173,203,135,40,227,145,216,164,58,103,146,123,42,17,162,225,176,72,169,114,28,168,230,218,248,76,102,169,247,233,132,190,67,143,29,54,22,79,27,227,133,193,172,200,57,85,30,83,42,120,174,35,222,49,10,138,101,78,20,42,115,46,59,224,251,73,237,241,86,31,250,26,165,26,200,48,172,134,223,213,184,64,99,73,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5211e1fa-3ffd-44d3-a820-58f034e21f3c"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadContactsByLeadPhoneParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55598db2-619f-4f92-a9b5-d03ddb173ed0"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,77,115,219,56,12,253,43,30,159,118,103,202,12,41,81,20,233,219,54,235,221,201,97,219,206,54,211,75,147,3,68,130,142,102,245,225,145,228,110,179,153,252,247,130,146,237,36,141,147,170,110,179,241,33,62,120,100,24,132,0,16,15,120,184,154,218,2,218,246,13,148,56,157,77,79,177,105,160,173,125,119,244,71,94,116,216,252,217,212,171,229,244,213,180,197,38,135,34,255,15,221,32,159,187,188,251,29,58,160,35,87,103,55,22,206,166,179,179,221,54,206,166,175,206,166,121,135,101,75,58,116,68,75,224,42,85,154,37,54,201,152,20,41,50,64,159,48,107,116,22,123,14,206,113,63,104,62,100,124,254,57,111,187,118,120,69,111,221,247,143,167,151,203,160,153,144,192,214,229,18,154,188,173,171,181,80,4,105,222,206,43,200,10,116,36,232,154,21,146,168,107,242,146,162,193,211,188,196,119,208,208,187,130,161,58,136,72,201,67,209,6,173,2,125,55,255,188,108,176,109,243,186,122,220,185,227,186,88,149,213,109,109,50,128,219,159,107,127,120,239,100,208,124,7,221,69,111,226,227,113,93,117,96,187,227,186,44,87,85,110,161,35,245,217,90,120,126,116,66,94,95,247,65,252,182,88,52,184,160,191,63,225,77,32,255,224,101,111,101,92,118,233,128,163,59,252,0,197,10,111,121,116,55,206,99,88,6,23,122,179,107,55,38,246,182,115,147,186,87,152,252,146,93,78,134,96,38,107,189,95,251,87,180,171,108,184,164,245,205,239,81,44,113,172,0,211,44,97,58,226,158,201,40,226,76,103,220,50,224,34,150,73,156,72,110,213,222,198,163,76,68,104,189,101,34,5,206,164,143,13,211,70,70,244,36,189,246,14,101,10,241,183,46,59,212,25,62,84,138,98,87,41,198,7,95,137,111,86,101,22,194,217,85,110,27,71,54,245,54,46,135,59,234,45,210,143,22,220,198,7,82,106,242,197,197,232,160,183,169,251,86,220,17,9,151,27,229,145,54,119,7,162,72,248,41,8,6,43,155,71,66,244,73,251,246,223,10,155,247,246,2,75,24,82,119,126,68,210,175,4,243,2,75,172,186,217,21,72,80,222,83,121,11,97,168,218,85,44,24,232,40,98,74,75,201,9,212,104,48,185,166,3,91,135,102,87,138,128,45,141,74,153,6,158,50,233,84,18,240,110,9,249,26,19,16,194,58,235,194,145,121,213,229,221,229,80,18,179,43,35,33,6,157,196,140,107,75,93,66,39,158,110,205,75,38,116,164,83,13,9,0,102,215,231,67,184,121,187,44,224,242,195,54,170,191,17,220,164,160,47,130,86,211,118,147,0,168,73,237,39,148,222,85,209,229,213,34,244,130,2,109,184,202,163,215,171,54,175,40,239,147,229,69,93,97,111,48,52,50,50,35,121,132,70,81,185,132,176,200,5,33,89,230,124,68,240,134,216,165,41,71,48,154,74,144,62,116,38,115,214,56,79,14,122,30,135,42,51,192,116,26,43,6,214,82,152,222,8,244,193,234,11,82,31,65,234,184,28,190,32,245,176,144,42,185,71,47,156,97,222,208,151,140,36,93,152,161,81,24,107,131,81,162,0,172,147,63,5,169,127,213,89,94,224,125,156,98,146,113,153,198,228,167,85,192,100,224,18,89,22,1,75,140,160,113,236,40,214,200,15,56,13,64,45,234,5,145,131,226,237,18,155,158,34,172,135,224,142,121,119,103,80,134,22,218,212,117,55,164,123,219,130,119,49,162,222,183,77,77,143,163,7,193,177,52,138,82,163,68,194,82,7,49,147,89,152,83,26,144,81,118,165,5,52,134,242,248,120,7,57,169,30,26,243,114,215,152,151,7,63,230,239,164,117,80,27,51,241,199,101,114,71,31,17,143,83,204,65,235,254,188,15,100,237,227,65,77,252,62,144,91,19,127,131,20,20,86,39,54,102,68,135,50,230,188,16,204,4,164,112,46,156,226,104,98,29,138,145,142,110,95,56,47,33,47,122,209,13,105,24,109,229,30,220,215,214,8,136,231,15,97,145,63,33,22,93,76,171,69,26,56,133,162,70,72,3,61,98,25,215,25,211,50,166,233,130,66,16,35,236,189,123,42,215,238,120,227,173,84,78,25,206,82,35,168,74,41,167,140,8,142,98,218,138,196,113,103,148,49,41,121,67,11,110,184,221,247,245,170,177,107,26,223,14,155,237,94,27,235,115,44,162,63,113,183,252,122,97,219,107,17,219,107,193,122,134,181,233,123,55,161,157,107,200,152,38,243,178,48,28,242,194,240,82,121,135,189,170,190,16,224,123,67,247,251,248,236,51,80,213,31,96,159,15,144,191,125,250,172,184,77,211,198,18,171,255,147,60,61,41,23,186,158,94,127,1,116,41,210,195,225,23,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("519549f0-c248-40b5-be93-602f4ff55bac"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1675f40-4a8b-469f-807f-482b441e6236"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8aacc82f-451e-44f0-a1ea-c48fac82b9aa"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a7cefdb-8943-464e-9818-f056350796f1"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a45be9e6-9a59-46ac-b1b7-9def07669d0c"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6b161822-7e93-4124-b2d6-c1605b5f5657"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("97881864-f21d-4f49-b39f-662c780efdc9"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("83016a9c-a67e-4328-a96e-bfacfc2c77c6"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0d9ba4a-555e-4324-ae31-f59d0233fbc6"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b48e127-d50b-49a3-8459-4a9a52bf6988"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ef7572f-4836-4cfe-ad97-3868281a4281"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ce2e72d3-d7a5-4f50-9ecf-44b4bf27b6ea"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("98faeefc-cf3f-4be3-a9b9-40bd344629d3"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("e75f4ff2-ebaa-43f4-aff7-36f8fa2f00cd"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a5f9685-0340-43a4-85bd-917ac7f8b75a"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,75,76,53,72,53,49,77,78,212,77,54,177,52,213,53,73,75,53,215,77,52,182,76,209,53,78,76,50,55,50,183,72,53,52,51,52,7,0,106,93,85,138,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a757dc8-11a2-46d0-962c-01dc9f7cf05c"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d1a04b45-329c-4e0c-90b8-b7463582c944"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("822209b4-c7f7-4d36-9ddf-32a904b93bda"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeChangeLeadContactPhoneParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("cfc1a8ae-2a77-49bb-a728-a1637ee8c94a"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5feb2bce-5433-4c25-a83d-3f8d28ccc8ab"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9acd36f8-ce89-4f92-bdb8-e4eea778daf4"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,201,110,219,48,16,253,23,157,195,64,251,226,91,145,184,133,129,162,9,16,35,151,42,135,17,57,178,137,106,3,73,165,117,13,255,123,135,146,172,58,133,139,56,189,52,186,136,124,120,124,243,102,219,59,188,2,173,191,64,141,206,194,89,163,82,160,219,210,92,127,148,149,65,245,73,181,125,231,92,57,26,149,132,74,254,68,49,226,75,33,205,45,24,160,39,251,252,183,66,238,44,242,243,26,185,115,149,59,210,96,173,137,99,159,196,145,231,122,62,176,212,19,30,11,11,225,179,12,51,186,38,73,32,66,17,103,5,240,137,249,23,241,155,182,238,64,225,24,99,144,47,135,227,122,215,89,170,71,0,31,40,82,183,205,4,6,214,132,94,54,80,84,40,232,110,84,143,4,25,37,107,202,6,215,178,198,123,80,20,203,234,180,22,34,82,9,149,182,172,10,75,179,252,209,41,212,90,182,205,107,230,170,190,110,78,217,36,128,243,117,178,227,14,30,45,243,30,204,118,144,88,145,173,195,224,242,195,102,163,112,3,70,62,159,154,248,134,187,129,119,89,253,232,129,160,46,61,66,213,227,73,204,151,153,220,64,103,198,132,198,240,68,80,114,179,189,56,215,185,98,175,165,235,19,216,29,201,23,106,158,205,193,143,9,124,182,192,168,114,60,230,206,215,149,190,251,222,160,122,224,91,172,97,172,218,211,53,161,127,0,179,254,98,239,5,174,91,68,1,50,63,139,57,11,211,40,101,105,16,167,44,204,2,16,220,143,32,9,249,225,105,244,33,117,87,193,238,113,14,247,25,65,76,37,179,63,66,162,52,46,56,61,97,158,8,168,47,165,40,24,32,38,204,23,158,23,150,73,192,253,172,164,14,219,207,54,162,221,72,14,213,93,135,138,26,61,20,218,61,63,162,47,102,219,166,175,218,214,140,73,205,229,179,110,6,47,199,33,9,120,81,184,65,20,49,72,252,132,133,130,39,140,50,141,89,20,69,224,122,177,64,20,118,220,104,191,109,133,31,218,94,241,105,159,244,184,216,255,180,176,255,97,13,223,178,89,103,103,251,146,89,125,47,83,184,122,47,147,118,112,14,191,0,8,233,7,64,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15555f52-d536-4815-a506-977a98d2f0f3"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,114,155,48,16,253,21,70,201,209,242,0,18,66,226,154,164,51,158,73,218,76,146,230,18,251,176,146,86,9,51,24,60,32,183,227,50,252,123,5,182,147,216,109,79,213,1,208,106,223,219,221,199,83,79,46,253,110,131,164,32,79,216,182,208,53,206,207,175,154,22,231,247,109,99,176,235,230,183,141,129,170,252,5,186,194,123,104,97,141,30,219,103,168,182,216,221,150,157,159,69,167,48,50,35,151,63,166,83,82,188,244,100,225,113,253,125,97,3,59,119,185,114,194,74,42,56,179,148,107,149,82,41,164,164,104,19,163,132,86,26,156,12,96,211,84,219,117,125,135,30,238,193,191,145,162,39,19,91,32,0,203,85,108,51,73,227,140,3,229,86,102,84,165,92,80,107,37,23,2,53,83,146,145,97,70,58,243,134,107,152,138,126,128,121,18,232,21,42,154,103,177,166,28,181,166,210,128,161,206,49,165,5,151,60,65,51,130,15,249,31,192,151,139,151,69,247,237,103,141,237,227,196,91,56,168,58,92,205,67,244,44,112,83,225,26,107,95,244,9,67,29,231,156,209,212,101,9,229,82,112,170,92,134,161,209,148,199,160,165,69,157,14,1,240,174,102,209,171,92,202,100,76,116,105,18,196,113,92,209,48,143,163,66,164,38,151,49,58,107,212,8,185,169,125,233,119,87,147,70,69,15,24,35,207,12,80,195,85,22,80,152,83,96,202,82,6,58,79,115,137,137,72,242,97,117,177,26,7,179,101,183,169,96,247,252,231,124,15,8,54,50,77,237,202,118,141,211,151,7,227,187,72,239,162,106,60,218,188,53,53,118,243,47,101,219,249,168,12,255,51,106,92,212,98,183,173,124,89,191,134,252,170,66,227,203,166,158,47,236,190,214,230,196,38,159,171,245,203,189,219,150,164,88,254,203,111,135,247,94,221,83,199,157,155,109,73,102,75,242,216,108,91,51,50,178,176,185,254,52,230,84,100,74,57,219,30,221,21,34,245,182,170,14,145,107,240,112,76,60,134,27,91,186,18,237,162,126,60,154,106,98,137,15,139,254,229,113,92,251,222,254,7,118,7,53,188,98,251,53,8,240,209,251,123,151,79,65,198,35,177,78,85,22,231,137,163,57,130,10,238,22,225,110,217,4,168,74,148,118,44,103,169,115,233,132,126,64,135,45,214,6,79,27,75,132,70,38,130,89,165,195,148,242,36,83,1,111,99,10,50,102,150,11,201,172,101,7,124,55,169,61,94,235,67,95,163,84,3,25,134,213,240,27,159,253,156,215,74,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99d9c01e-8ac9-41e6-a4ee-12e2c816886a"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("3719e46d-8e08-48ad-8083-1ccf953996c6"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("08550f59-4992-48fb-b252-df02ec268766"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44584732-acad-4754-bde4-a1b1cfd19199"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,111,218,64,16,253,47,62,103,35,179,31,198,230,86,37,180,66,170,154,72,65,185,212,57,140,189,99,88,213,198,214,238,146,150,34,254,123,103,109,160,164,162,10,233,165,241,197,246,211,219,55,111,102,223,108,163,178,6,231,190,64,131,209,36,154,163,181,224,218,202,95,127,52,181,71,251,201,182,235,46,186,138,28,90,3,181,249,137,122,192,167,218,248,91,240,64,71,182,249,111,133,60,154,228,231,53,242,232,42,143,140,199,198,17,135,142,84,99,40,132,230,138,65,146,112,38,49,25,51,40,17,216,40,137,185,146,124,44,5,20,3,243,111,226,55,109,211,129,197,161,70,47,95,245,159,243,77,23,168,35,2,202,158,98,92,187,218,131,34,152,112,211,21,20,53,106,250,247,118,141,4,121,107,26,234,6,231,166,193,123,176,84,43,232,180,1,34,82,5,181,11,172,26,43,63,253,209,89,116,206,180,171,215,204,213,235,102,117,202,38,1,60,254,238,237,196,189,199,192,188,7,191,236,37,102,100,107,215,187,252,176,88,88,92,128,55,207,167,38,190,225,166,231,93,54,63,58,160,233,150,30,161,94,227,73,205,151,157,220,64,231,135,134,134,242,68,176,102,177,188,184,215,227,196,94,107,151,19,216,29,200,23,106,158,237,129,39,4,62,7,96,80,57,124,230,209,215,153,187,251,190,66,251,80,46,177,129,97,106,79,215,132,254,1,28,245,39,219,145,136,227,66,9,100,60,75,74,38,83,149,178,84,36,41,147,153,0,93,114,5,99,89,238,158,6,31,198,117,53,108,30,143,229,62,35,232,253,200,194,139,144,2,20,168,76,22,76,101,149,98,82,165,25,43,228,136,212,170,52,86,177,4,17,171,112,195,225,9,23,209,46,76,9,245,93,135,150,46,186,31,116,124,62,162,47,178,29,218,183,109,235,135,166,142,227,11,110,122,47,135,144,104,89,232,120,204,5,83,149,210,20,18,160,184,240,76,48,174,5,86,58,205,148,148,193,12,237,119,152,240,67,187,182,229,126,159,220,176,216,255,180,176,255,97,13,223,178,89,103,179,125,73,86,223,75,10,103,239,37,105,187,104,247,11,5,14,193,196,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("33aca163-6ecf-4e71-9484-09432fbc4746"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,203,110,219,48,16,252,21,129,201,209,52,40,241,33,81,183,34,233,193,64,210,6,117,146,75,236,195,146,92,54,2,244,8,40,185,69,106,232,223,75,203,118,28,167,237,169,60,72,218,229,206,236,112,53,220,146,203,225,245,5,73,73,238,49,4,232,59,63,204,175,186,128,243,187,208,89,236,251,249,77,103,161,174,126,129,169,241,14,2,52,56,96,120,132,122,131,253,77,213,15,179,228,28,70,102,228,242,199,180,75,202,167,45,89,12,216,60,44,92,100,87,50,83,78,230,154,114,233,44,21,40,44,5,76,61,101,220,243,204,74,147,59,41,34,216,118,245,166,105,111,113,128,59,24,158,73,185,37,19,91,36,0,39,52,115,178,160,76,10,160,194,21,146,234,76,40,234,92,33,148,66,195,117,193,201,56,35,189,125,198,6,166,166,39,176,72,193,23,26,53,205,37,51,177,187,49,180,176,96,169,247,92,27,37,10,145,162,221,129,15,245,39,224,211,197,211,162,255,250,179,197,176,156,120,75,15,117,143,235,121,204,126,72,124,174,177,193,118,40,183,187,86,44,115,154,106,159,113,42,50,166,168,209,22,227,113,153,97,76,50,7,26,199,8,120,155,102,185,205,115,40,152,151,138,10,163,24,21,133,177,212,96,150,83,212,202,123,39,172,149,218,140,235,139,245,78,162,171,250,151,26,94,31,255,84,250,201,185,100,211,218,174,245,85,104,208,37,241,107,0,59,36,6,250,24,117,109,82,35,184,164,106,125,23,26,24,170,174,157,95,5,132,33,238,5,180,93,112,201,194,237,91,188,156,253,231,247,77,182,171,189,93,86,164,92,253,203,48,135,247,126,60,231,150,249,232,150,21,153,173,200,178,219,4,187,99,228,49,184,126,119,186,169,201,84,242,33,60,218,35,102,218,77,93,31,50,215,48,192,177,240,152,238,92,229,43,116,139,118,121,116,197,196,194,14,139,254,229,113,92,123,109,255,3,187,133,22,190,99,248,18,7,112,210,254,166,242,62,142,241,72,108,50,45,89,30,111,67,142,160,163,61,85,70,11,151,2,213,169,54,158,231,60,243,62,155,208,223,208,99,192,214,226,185,176,84,25,228,74,166,180,240,152,81,145,74,29,241,142,209,232,42,238,132,42,184,115,252,128,239,167,105,239,238,229,65,215,110,84,35,25,199,245,248,27,101,185,213,237,11,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb50f943-4702-4fd8-9aa9-5698a33e9475"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadLandingPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd3fabe0-1945-4d5e-9fb8-9e85ee54cc3b"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,21,67,231,48,208,147,162,124,43,82,39,8,80,52,65,19,164,135,58,135,21,185,84,136,234,5,138,78,235,26,254,247,46,37,199,77,10,163,113,123,105,129,234,32,72,131,217,225,236,139,155,64,214,48,12,239,161,193,96,30,220,162,181,48,116,218,157,158,155,218,161,189,176,221,170,15,78,130,1,173,129,218,124,67,53,225,11,101,220,91,112,64,33,155,229,15,133,101,48,95,30,214,88,6,39,203,192,56,108,6,226,80,8,104,153,149,82,32,139,85,166,88,170,242,152,65,153,23,44,147,37,34,134,161,46,35,175,246,11,241,179,174,233,193,226,116,198,40,175,199,207,219,117,239,169,17,1,114,164,152,161,107,119,96,226,77,12,139,22,202,26,21,253,59,187,66,130,156,53,13,101,131,183,166,193,107,176,116,150,215,233,60,68,36,13,245,224,89,53,106,183,248,218,91,28,6,211,181,175,153,171,87,77,251,156,77,2,184,255,221,217,9,71,143,158,121,13,238,97,148,184,36,91,219,209,229,155,170,178,88,129,51,143,207,77,124,198,245,200,59,174,126,20,160,168,75,119,80,175,240,217,153,47,51,57,131,222,77,9,77,199,19,193,154,234,225,232,92,247,21,123,45,221,152,192,254,137,124,164,230,193,28,98,78,224,163,7,38,149,167,207,101,240,233,114,184,250,210,162,189,145,15,216,192,84,181,251,83,66,127,2,22,53,54,216,186,249,6,82,224,90,135,146,69,81,161,89,202,147,136,129,136,99,198,69,154,134,57,23,88,96,182,165,128,189,161,249,134,203,66,164,5,207,153,128,48,167,210,243,140,1,106,201,210,72,96,6,81,36,149,84,62,100,209,58,227,214,211,36,204,55,69,34,10,21,139,130,241,68,112,150,10,10,40,74,149,177,88,102,34,143,147,36,230,60,222,222,79,233,154,161,175,97,125,183,207,234,3,130,154,213,244,162,141,178,131,155,249,61,154,117,122,70,229,93,213,206,180,213,140,166,168,70,233,219,120,250,14,90,229,161,30,170,105,2,124,79,73,68,71,33,231,146,35,211,97,137,44,205,19,206,132,202,35,150,71,24,150,121,201,49,209,156,102,207,63,126,68,186,202,72,168,175,122,180,52,130,227,8,132,135,151,231,197,214,249,198,216,174,115,83,185,247,141,189,64,234,9,109,147,250,136,229,121,103,155,209,215,211,40,83,85,128,39,58,99,200,195,144,42,35,67,6,146,154,33,194,20,133,206,34,137,60,35,99,116,11,249,57,184,233,86,86,238,182,126,152,174,159,63,186,86,254,194,101,241,59,251,127,112,3,143,217,168,255,108,87,46,255,197,225,222,6,219,239,65,118,3,35,87,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c84ed90e-913c-4d79-be6e-0aeb6dbde695"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("528b68b1-c488-499b-b6a9-98d627973317"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7db9bc2b-3431-4feb-8af1-b2fcbc5cf552"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50c50a69-929a-4ae1-8501-1657483ac91c"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a09f02d-d645-448c-a427-3dc0ad363ad0"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2793b917-606e-429f-8d6b-56caf9a5d36b"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				UId = new Guid("a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0010511-9818-4608-8cc6-966c057c7fb7"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5ce1ad73-33d5-4d54-99dc-103fe2185918"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f1d51e05-81e8-439e-be55-ef17ce69d451"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5400d0e0-9171-4da4-9833-ee4bc440d882"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe6f5c9f-37df-4b0d-b855-65847152e915"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ec12f3b9-746c-4f92-ba49-ce658079412a"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				UId = new Guid("6dc416c9-504c-4429-b04e-93f543f173c4"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b66e4485-d571-44cb-9e32-b832c83541ca"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c52f53d-1e03-445c-bcbe-0982a59c336a"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aadf92c2-302e-499d-a17e-33c74ef006bd"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b3f6ea08-bb3d-48ff-bb96-9f7e3530b585"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadIdentificationProcess = CreateLeadIdentificationProcessLaneSet();
			LaneSets.Add(schemaLeadIdentificationProcess);
			ProcessSchemaLane schemaLeadIdentification = CreateLeadIdentificationLane();
			schemaLeadIdentificationProcess.Lanes.Add(schemaLeadIdentification);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent leadisidentified = CreateLeadIsIdentifiedTerminateEvent();
			FlowElements.Add(leadisidentified);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaExclusiveGateway exclusiveleadhascommunication = CreateExclusiveLeadHasCommunicationExclusiveGateway();
			FlowElements.Add(exclusiveleadhascommunication);
			ProcessSchemaTerminateEvent leaddisqualified = CreateLeadDisqualifiedTerminateEvent();
			FlowElements.Add(leaddisqualified);
			ProcessSchemaUserTask readcontactsbyleadcommunications = CreateReadContactsByLeadCommunicationsUserTask();
			FlowElements.Add(readcontactsbyleadcommunications);
			ProcessSchemaUserTask changeleadcontactall = CreateChangeLeadContactAllUserTask();
			FlowElements.Add(changeleadcontactall);
			ProcessSchemaUserTask addcontactbylead = CreateAddContactByLeadUserTask();
			FlowElements.Add(addcontactbylead);
			ProcessSchemaUserTask addcontactadress = CreateAddContactAdressUserTask();
			FlowElements.Add(addcontactadress);
			ProcessSchemaUserTask addcontactweb = CreateAddContactWebUserTask();
			FlowElements.Add(addcontactweb);
			ProcessSchemaParallelGateway parallelgatewayaddcontactcommunication = CreateParallelGatewayAddContactCommunicationParallelGateway();
			FlowElements.Add(parallelgatewayaddcontactcommunication);
			ProcessSchemaParallelGateway parallelgateway1 = CreateParallelGateway1ParallelGateway();
			FlowElements.Add(parallelgateway1);
			ProcessSchemaUserTask readcontactsbyleademail = CreateReadContactsByLeadEmailUserTask();
			FlowElements.Add(readcontactsbyleademail);
			ProcessSchemaUserTask changeleadcontactemail = CreateChangeLeadContactEmailUserTask();
			FlowElements.Add(changeleadcontactemail);
			ProcessSchemaExclusiveGateway exclusiveinleadcommunication = CreateExclusiveInLeadCommunicationExclusiveGateway();
			FlowElements.Add(exclusiveinleadcommunication);
			ProcessSchemaUserTask readcontactsbyleadphone = CreateReadContactsByLeadPhoneUserTask();
			FlowElements.Add(readcontactsbyleadphone);
			ProcessSchemaUserTask changeleadcontactphone = CreateChangeLeadContactPhoneUserTask();
			FlowElements.Add(changeleadcontactphone);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaScriptTask actionafteridentificationscripttask = CreateActionAfterIdentificationScriptTaskScriptTask();
			FlowElements.Add(actionafteridentificationscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readlandingpage = CreateReadLandingPageUserTask();
			FlowElements.Add(readlandingpage);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			FlowElements.Add(CreateContactFoundAllConditionalFlow());
			FlowElements.Add(CreateContactNotFoundAllSequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateConditionalFlowCommunicationAllConditionalFlow());
			FlowElements.Add(CreateConditionalFlowEmailOnlyConditionalFlow());
			FlowElements.Add(CreateContactFoundEmailConditionalFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateConditionalFlowPhonesOnlyConditionalFlow());
			FlowElements.Add(CreateCntactFoundPhoneConditionalFlow());
			FlowElements.Add(CreateContactNotFoundEmailSequenceFlow());
			FlowElements.Add(CreateContactNotFoundPhoneSequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateSequenceFlowLeadReadSequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateIsNotFromLandingFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateDontContactFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaConditionalFlow CreateContactFoundAllConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContactFoundAll",
				UId = new Guid("e86cf8b0-28a2-4a9b-b145-adf2cced025e"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{55827a3c-5bec-4f5a-bf98-793768421b33}].[Parameter:{10568b26-1c18-4f39-9578-4a72a1c5fb66}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(743, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundAllSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundAll",
				UId = new Guid("de6d680f-d07c-44e0-bad0-0e782cd4ab9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(663, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("685ffe7e-d19d-424d-af66-eab647e50e57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(827, 406),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(890, 317),
				SequenceFlowStartPointPosition = new Point(840, 317),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("ac04a55d-ac74-402d-bd4c-e1838bf4708c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(942, 299),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1009, 317),
				SequenceFlowStartPointPosition = new Point(945, 317),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("520f849c-7cf5-482e-8278-85ac18ec9297"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(952, 407),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1009, 408),
				SequenceFlowStartPointPosition = new Point(918, 344),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(918, 408));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("18317a84-4d39-4605-b176-feb243f51a99"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1086, 544),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1135, 317),
				SequenceFlowStartPointPosition = new Point(1078, 317),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("f6a451c0-89fd-4ccc-ab61-d3c20b1a0644"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1086, 594),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1163, 344),
				SequenceFlowStartPointPosition = new Point(1078, 408),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1163, 408));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("09a82fde-8ba3-4a5d-9cc0-6aecd8a4bd9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1165, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1226, 317),
				SequenceFlowStartPointPosition = new Point(1190, 317),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("7441390e-adc4-42b8-a095-363e9352da36"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1012, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1376, 161),
				SequenceFlowStartPointPosition = new Point(892, 71),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 71));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowCommunicationAllConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowCommunicationAll",
				UId = new Guid("146a48af-ec3c-47df-b53d-49db5dfca733"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] != String.Empty && ([#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] != String.Empty || [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] != String.Empty)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(564, 112),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(560, 71));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowEmailOnlyConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowEmailOnly",
				UId = new Guid("94e08796-33d0-450f-a94d-43d4d8c7e5b4"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] != String.Empty && [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] == String.Empty && [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] == String.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(568, 220),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateContactFoundEmailConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContactFoundEmail",
				UId = new Guid("8ad3bb27-05b3-4197-85fe-9fca6ddb677c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e02e7808-8729-4c97-b907-1487f2e17278}].[Parameter:{4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(672, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("d616bcad-397a-4fb0-9ad7-a6b4eecacb7a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1082, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1348, 189),
				SequenceFlowStartPointPosition = new Point(892, 189),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("04aca506-6521-4495-8b71-07a6e4990984"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1288, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1451, 189),
				SequenceFlowStartPointPosition = new Point(1403, 189),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowPhonesOnlyConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowPhonesOnly",
				UId = new Guid("421b74c1-62c2-430b-965d-8d776c88a27f"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] == String.Empty && ([#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] != String.Empty || [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] != String.Empty)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(465, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(665, 490),
				SequenceFlowStartPointPosition = new Point(587, 189),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(626, 189));
			schemaFlow.PolylinePointPositions.Add(new Point(626, 490));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateCntactFoundPhoneConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "CntactFoundPhone",
				UId = new Guid("9bfd01fc-78f4-4b49-a5a3-0359fc93fab2"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{13eb0743-2f51-4864-9f5e-dd240ab8deb2}].[Parameter:{97881864-f21d-4f49-b39f-662c780efdc9}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(668, 412),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(823, 490),
				SequenceFlowStartPointPosition = new Point(734, 490),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundEmailSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundEmail",
				UId = new Guid("42aea126-6049-4745-ad69-161540c3e406"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(670, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(771, 317),
				SequenceFlowStartPointPosition = new Point(700, 216),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(700, 317));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundPhoneSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundPhone",
				UId = new Guid("df707572-c541-4e4e-862e-378909dd23f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(670, 438),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(771, 317),
				SequenceFlowStartPointPosition = new Point(700, 462),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(700, 317));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("4d08fda8-cd6a-41a3-93c1-ea29843a1dd8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1004, 269),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1376, 216),
				SequenceFlowStartPointPosition = new Point(892, 490),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 490));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("730e6ac4-b34e-4059-a3b7-fdb00cfe6b88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(130, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(72, 189),
				SequenceFlowStartPointPosition = new Point(35, 189),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("d51e9369-1e01-464b-b9e0-a5a76570f27f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1295, 314),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1376, 216),
				SequenceFlowStartPointPosition = new Point(1295, 317),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 317));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowLeadDefined",
				UId = new Guid("809c0113-c2cd-4fc6-81a2-709589e406ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(322, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(160, 189),
				SequenceFlowStartPointPosition = new Point(127, 189),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadReadSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowLeadRead",
				UId = new Guid("39aa9aa5-0e89-45d2-ab91-45a36ea7120a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(393, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(254, 189),
				SequenceFlowStartPointPosition = new Point(229, 189),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("86bf0460-da87-44e8-9e19-16d6bb74396c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{1300b53e-296c-4858-8368-493adc25a74c}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(468, 408),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(722, 592),
				SequenceFlowStartPointPosition = new Point(100, 216),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(100, 592));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("820777f0-a887-4f88-bf50-9a94194c500e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1423, 214),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(1583, 189),
				SequenceFlowStartPointPosition = new Point(1520, 189),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsNotFromLandingFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsNotFromLandingFlow",
				UId = new Guid("b15dccc1-cb8b-4db6-9245-c999d8b93476"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{9389d289-6386-48fc-9bd5-2c5872332662}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(282, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("20f61163-eea7-47a5-b9f2-2e0896ee1530"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateDontContactFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "DontContactFlow",
				UId = new Guid("6e54dca1-2410-4933-8d29-b9c06c6eb9c5"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{17eaa635-03e6-4644-8e7d-7a81a8f837a6}].[Parameter:{a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76}].[EntityColumn:{7e336bc1-838f-48c6-a4d7-6f5bb3930bb2}]#] == false",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(471, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("d4060814-2d0d-4e64-93e2-903d9f427c42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(560, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("ba39820c-a979-4d6a-9f26-dab9940fce00"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("704f89d9-2ad0-404e-8ce3-94ce9f308188"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadIdentificationProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadIdentificationProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bc24ba6a-fa71-49d5-8e0e-37de1a155822"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIdentificationProcess",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLeadIdentificationProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadIdentificationLane() {
			ProcessSchemaLane schemaLeadIdentification = new ProcessSchemaLane(this) {
				UId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bc24ba6a-fa71-49d5-8e0e-37de1a155822"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIdentification",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLeadIdentification;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"Start",
				Position = new Point(4, 173),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateLeadIsIdentifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIsIdentified",
				Position = new Point(1583, 173),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadLeadData",
				Position = new Point(160, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveLeadHasCommunicationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveLeadHasCommunication",
				Position = new Point(532, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateLeadDisqualifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadDisqualified",
				Position = new Point(722, 576),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadCommunicationsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadCommunications",
				Position = new Point(665, 43),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadContactsByLeadCommunicationsParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactAllUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactAll",
				Position = new Point(823, 43),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadContactAllParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactByLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactByLead",
				Position = new Point(771, 289),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddContactByLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactAdressUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactAdress",
				Position = new Point(1009, 380),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddContactAdressParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactWebUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactWeb",
				Position = new Point(1009, 289),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddContactWebParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGatewayAddContactCommunicationParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ParallelGatewayAddContactCommunication",
				Position = new Point(890, 289),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ParallelGateway1",
				Position = new Point(1135, 289),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadEmailUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadEmail",
				Position = new Point(665, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadContactsByLeadEmailParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactEmailUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactEmail",
				Position = new Point(823, 161),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadContactEmailParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveInLeadCommunicationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveInLeadCommunication",
				Position = new Point(1348, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadPhoneUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadPhone",
				Position = new Point(665, 462),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadContactsByLeadPhoneParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactPhoneUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactPhone",
				Position = new Point(823, 462),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadContactPhoneParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(1226, 289),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGatewayIsLeadSet",
				Position = new Point(72, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateActionAfterIdentificationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ActionAfterIdentificationScriptTask",
				Position = new Point(1451, 161),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,115,76,46,201,204,207,115,76,43,73,45,242,76,73,205,43,201,76,203,76,78,4,9,105,104,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,0,140,232,210,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGateway1",
				Position = new Point(254, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadLandingPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadLandingPage",
				Position = new Point(340, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLandingPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGateway2",
				Position = new Point(443, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10509a8f-ce1f-49d4-9a6e-2dbe803346be"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5d1dacad-ecaf-4a19-8976-6e14d8694860"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementIdentification(userConnection);
		}

		public override object Clone() {
			return new LeadManagementIdentificationSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50c67976-474a-4cfb-b066-5ca727be0505"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementIdentification

	/// <exclude/>
	public class LeadManagementIdentification : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadIdentification

		/// <exclude/>
		public class ProcessLeadIdentification : ProcessLane
		{

			public ProcessLeadIdentification(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,93,111,218,48,20,253,47,121,174,171,196,113,112,194,219,212,178,9,105,90,43,21,245,101,233,195,141,125,1,107,9,137,108,211,141,33,254,251,174,19,96,116,98,42,221,203,154,151,216,71,199,231,158,251,181,141,84,13,206,125,129,6,163,113,52,67,107,193,181,115,127,253,209,212,30,237,39,219,174,187,232,42,114,104,13,212,230,39,234,1,159,104,227,111,193,3,61,217,150,191,21,202,104,92,158,215,40,163,171,50,50,30,27,71,28,122,34,210,10,69,30,3,195,68,197,76,40,41,88,174,37,176,88,38,186,72,56,143,115,149,14,204,191,137,223,180,77,7,22,135,24,189,252,188,63,206,54,93,160,38,4,168,158,98,92,187,218,131,105,48,225,38,43,168,106,212,116,247,118,141,4,121,107,26,202,6,103,166,193,123,176,20,43,232,180,1,34,210,28,106,23,88,53,206,253,228,71,103,209,57,211,174,94,51,87,175,155,213,41,155,4,240,120,221,219,137,123,143,129,121,15,126,217,75,76,201,214,174,119,249,97,177,176,184,0,111,158,79,77,124,195,77,207,187,172,126,244,64,83,151,30,161,94,227,73,204,151,153,220,64,231,135,132,134,240,68,176,102,177,188,56,215,99,197,94,75,151,19,216,29,200,23,106,158,205,129,143,8,124,14,192,160,114,56,150,209,215,169,187,251,190,66,251,160,150,216,192,80,181,167,107,66,255,0,142,250,227,109,146,198,113,149,165,200,120,49,82,76,228,89,206,242,116,148,51,81,164,160,21,207,64,10,181,123,26,124,24,215,213,176,121,60,134,251,140,160,247,37,11,63,66,228,92,243,12,171,130,186,17,75,38,164,24,177,74,101,21,75,19,148,9,7,208,26,128,58,28,190,208,136,118,97,20,212,119,29,90,106,116,95,232,248,252,136,190,152,237,144,190,109,91,63,36,117,44,95,112,211,123,57,12,9,199,164,82,50,43,24,72,73,67,146,243,132,85,192,57,75,85,150,136,74,139,34,134,138,204,208,126,135,10,63,180,107,171,246,251,228,134,197,254,167,133,253,15,107,248,150,205,58,59,219,151,204,234,123,153,194,233,123,153,180,93,180,251,5,66,214,75,222,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,21,83,201,13,4,33,12,171,40,82,46,114,104,170,9,4,250,47,97,179,31,94,198,248,194,109,135,218,49,176,122,11,20,15,67,46,55,88,103,245,62,216,198,136,159,89,44,46,95,176,153,47,168,36,66,69,63,208,12,210,211,27,73,232,75,45,169,88,2,24,103,131,198,122,16,249,20,40,56,60,106,85,221,253,41,175,216,54,247,223,117,2,221,94,16,236,1,15,203,119,118,171,7,126,97,235,110,158,251,146,58,32,150,7,165,7,225,120,136,138,69,121,189,175,61,183,54,38,168,231,128,50,101,132,243,134,139,233,24,177,215,58,246,29,127,155,18,47,44,234,0,61,182,160,198,23,28,113,210,150,141,245,252,211,40,60,106,244,119,167,160,175,70,248,237,11,231,138,245,146,122,42,247,139,44,196,126,4,210,50,160,50,129,45,122,128,211,163,207,243,139,117,63,186,113,177,55,1,46,244,17,118,55,164,31,31,166,237,145,138,82,213,223,82,52,63,79,128,228,159,56,55,65,212,75,72,60,182,187,143,187,203,231,135,135,43,18,106,215,184,179,225,220,18,6,19,64,96,178,119,123,124,239,94,225,14,2,191,127,225,53,194,146,230,57,193,144,171,173,41,241,190,201,232,28,89,9,114,39,81,13,58,176,163,10,136,252,148,109,158,96,237,227,229,69,194,4,79,87,15,200,2,246,83,133,155,143,199,161,25,181,124,117,241,234,58,5,71,115,132,79,131,80,146,13,82,219,167,195,75,70,254,85,197,161,105,102,6,242,102,5,28,10,59,45,33,30,45,19,44,94,247,124,35,44,155,199,157,253,61,105,188,3,185,123,1,159,21,206,34,108,198,95,163,237,202,41,99,10,153,231,124,166,80,230,12,151,150,214,93,70,149,250,41,190,251,168,19,94,206,161,172,6,149,56,203,137,188,188,172,234,180,126,247,58,7,183,1,203,12,68,53,223,184,243,13,180,155,47,61,177,90,241,105,45,247,191,103,155,54,231,35,52,194,166,23,48,129,241,121,182,198,41,125,245,186,78,209,140,26,103,143,234,230,127,208,228,52,98,83,173,101,42,255,122,134,131,87,2,100,203,159,105,207,84,114,44,96,108,79,236,20,101,252,174,15,35,217,129,217,225,127,227,52,160,237,14,41,162,189,174,141,192,247,253,197,173,51,76,230,143,65,187,100,18,127,6,173,60,191,173,186,198,239,15,157,239,2,19,193,3,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadContactsByLeadCommunicationsFlowElement

		/// <exclude/>
		public class ReadContactsByLeadCommunicationsFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadCommunicationsFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadCommunications";
				IsLogging = true;
				SchemaElementUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,75,115,219,70,12,254,43,26,157,218,153,172,103,223,220,245,173,117,213,78,14,77,50,77,38,151,216,135,125,96,109,78,41,82,67,82,105,92,143,254,123,65,82,150,237,68,118,24,213,169,149,84,58,104,100,24,11,2,216,239,195,98,193,171,105,40,92,211,188,112,115,152,30,79,223,64,93,187,166,74,237,209,175,121,209,66,253,91,93,45,23,211,103,211,6,234,220,21,249,223,16,7,249,44,230,237,47,174,117,184,228,234,244,198,194,233,244,248,116,187,141,211,233,179,211,105,222,194,188,65,29,92,162,41,117,20,52,16,5,218,18,25,147,34,94,68,69,88,52,153,143,201,8,227,211,160,121,159,241,217,135,188,105,155,225,17,189,245,212,255,124,115,185,232,52,21,10,66,53,95,184,58,111,170,114,45,100,157,52,111,102,165,243,5,68,20,180,245,18,80,212,214,249,28,163,129,55,249,28,94,185,26,159,213,25,170,58,17,42,37,87,52,157,86,1,169,157,125,88,212,208,52,121,85,62,236,220,73,85,44,231,229,109,109,52,0,155,63,215,254,208,222,201,78,243,149,107,47,122,19,239,78,170,178,117,161,61,169,230,243,101,153,7,215,162,250,241,90,120,118,244,28,189,94,245,65,252,116,126,94,195,57,254,251,61,220,4,242,39,92,246,86,198,101,23,23,68,220,195,183,174,88,194,45,143,238,198,121,226,22,157,11,189,217,181,27,147,112,219,185,73,213,43,76,126,240,151,147,33,152,201,90,239,199,254,17,205,210,15,155,180,222,249,29,192,66,101,146,218,133,140,120,201,56,145,186,11,135,107,77,88,224,140,27,0,229,188,248,220,126,116,80,128,251,208,194,182,161,69,236,61,88,94,44,231,190,11,103,27,34,174,29,185,134,196,184,28,110,129,4,55,15,98,226,218,7,84,170,243,243,139,209,65,111,82,247,185,184,57,10,23,215,202,35,109,110,15,68,163,240,125,39,24,172,92,255,68,210,61,111,94,254,85,66,253,58,92,192,220,13,169,59,59,66,233,71,130,89,1,115,40,219,227,43,39,157,78,137,6,194,152,77,152,76,193,136,51,156,19,109,164,164,153,54,96,65,173,112,193,198,161,227,43,29,172,145,86,103,196,56,154,33,37,181,34,14,82,32,146,25,204,61,99,33,134,216,45,153,149,109,222,94,14,144,56,190,74,0,130,71,195,72,6,92,18,233,132,36,150,225,38,10,106,4,200,40,173,48,105,117,54,132,155,55,139,194,93,190,221,68,245,7,184,56,41,240,11,169,85,55,237,164,35,212,164,74,19,76,239,178,104,243,242,188,163,107,1,161,219,202,163,217,220,229,69,111,167,43,49,184,26,76,240,73,41,74,24,164,72,36,197,98,98,64,115,66,5,203,164,128,132,0,66,188,172,240,131,107,152,182,60,179,70,19,240,26,243,225,101,32,206,2,35,148,162,219,158,51,150,32,123,120,235,158,151,247,113,83,126,155,220,188,83,192,7,181,49,52,29,151,201,45,232,102,15,151,238,65,235,83,146,118,21,246,221,94,209,180,15,228,22,77,175,241,8,44,24,21,4,9,41,120,18,19,99,196,122,238,48,49,44,106,10,72,132,160,123,123,155,7,222,64,250,134,233,163,173,124,194,166,181,53,196,251,89,15,249,162,58,199,205,45,94,46,160,238,183,120,141,130,45,160,188,131,230,174,6,213,85,213,14,149,101,227,235,182,83,191,247,99,83,190,163,225,42,80,75,162,163,88,190,165,200,136,149,8,19,102,193,9,197,34,87,178,107,13,58,207,98,16,44,8,17,137,55,74,33,115,45,39,142,10,32,212,243,160,12,115,222,57,121,104,173,118,109,173,198,101,247,155,105,173,82,16,120,46,129,37,218,105,218,181,5,137,120,38,45,17,96,156,74,49,97,187,24,118,55,46,188,200,76,204,72,150,148,239,64,43,8,86,53,67,130,6,43,65,132,104,244,154,228,135,190,237,190,3,97,92,14,15,125,219,126,245,109,146,38,72,44,90,146,44,126,73,46,53,30,227,52,17,97,44,112,165,157,11,81,62,74,223,246,123,229,243,2,38,139,139,170,28,96,176,62,46,117,162,66,115,124,34,68,138,141,35,245,24,41,199,90,37,185,137,188,251,133,244,222,180,111,158,38,166,76,114,68,105,143,222,42,240,196,71,236,55,241,144,116,130,38,141,32,235,172,30,120,250,64,227,54,46,135,7,158,238,23,79,45,94,169,156,81,130,80,188,238,16,105,84,34,198,38,73,152,225,38,67,138,56,7,254,81,120,250,243,178,201,75,60,246,63,101,170,202,172,21,94,51,162,176,204,19,105,141,37,30,180,68,186,10,43,21,126,100,232,59,187,213,125,109,39,251,138,109,231,184,246,160,115,76,90,108,133,188,119,68,72,134,248,135,64,241,190,136,95,1,233,96,162,115,78,91,245,168,87,64,249,189,94,1,199,101,242,112,5,252,191,93,1,147,76,6,135,116,138,100,54,195,66,145,5,28,13,24,73,9,55,120,9,212,145,89,166,112,168,187,250,122,174,221,241,38,80,173,109,198,5,137,153,194,182,194,35,64,157,103,158,96,127,227,0,11,131,228,1,7,21,43,124,119,208,93,132,94,87,203,58,172,199,175,205,240,210,96,167,151,1,79,49,227,127,196,177,253,199,23,182,157,102,220,79,48,185,254,210,97,244,214,73,240,152,145,209,97,102,187,135,51,219,39,24,199,254,139,227,245,158,1,231,46,232,187,51,138,28,123,114,252,151,167,195,23,206,251,190,223,234,57,126,140,181,211,120,234,80,114,247,251,53,217,247,58,110,57,224,110,191,113,119,24,31,108,59,148,190,104,26,240,4,23,253,67,115,241,122,92,115,241,21,111,146,171,233,234,31,149,133,232,176,122,38,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,75,76,53,72,53,49,77,78,212,77,54,177,52,213,53,73,75,53,215,77,52,182,76,209,53,78,76,50,55,50,183,72,53,52,51,52,7,0,106,93,85,138,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeLeadContactAllFlowElement

		/// <exclude/>
		public class ChangeLeadContactAllFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactAllFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactAll";
				IsLogging = true;
				SchemaElementUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,201,110,219,48,16,253,23,157,195,64,251,226,91,145,184,133,129,162,9,16,35,151,42,135,33,57,178,137,106,3,73,167,117,13,255,123,135,146,173,58,133,139,56,189,52,58,72,212,195,227,155,55,219,206,19,53,24,243,5,26,244,102,222,18,181,6,211,85,246,250,163,170,45,234,79,186,219,244,222,149,103,80,43,168,213,79,148,35,62,151,202,222,130,5,186,178,43,127,43,148,222,172,60,175,81,122,87,165,167,44,54,134,56,116,133,115,12,68,86,73,38,68,84,176,88,248,57,43,178,132,51,4,0,206,101,18,9,136,70,230,223,196,111,186,166,7,141,99,140,65,190,26,142,203,109,239,168,1,1,98,160,40,211,181,7,48,114,38,204,188,5,94,163,164,127,171,55,72,144,213,170,161,108,112,169,26,188,7,77,177,156,78,231,32,34,85,80,27,199,170,177,178,243,31,189,70,99,84,215,190,102,174,222,52,237,41,155,4,112,250,61,216,241,7,143,142,121,15,118,61,72,44,200,214,126,112,249,97,181,210,184,2,171,158,79,77,124,195,237,192,187,172,126,116,65,82,151,30,161,222,224,73,204,151,153,220,64,111,199,132,198,240,68,208,106,181,190,56,215,169,98,175,165,27,18,216,31,201,23,106,158,205,33,76,9,124,118,192,168,114,60,150,222,215,133,185,251,222,162,126,16,107,108,96,172,218,211,53,161,127,0,147,254,108,23,68,190,207,147,8,89,88,164,130,197,121,146,179,60,74,115,22,23,17,72,17,38,144,197,98,255,52,250,80,166,175,97,251,56,133,251,140,32,15,37,115,31,66,170,176,224,60,247,99,22,248,81,200,98,137,212,151,34,72,24,47,146,60,46,42,159,87,85,64,29,118,143,107,68,183,82,2,234,187,30,53,53,122,40,180,127,126,68,95,204,182,75,95,119,157,29,147,154,202,231,220,12,94,142,67,2,60,11,35,78,209,179,2,124,22,39,50,102,144,209,171,72,49,13,57,249,4,233,198,141,246,219,85,248,161,219,104,113,216,39,51,46,246,63,45,236,127,88,195,183,108,214,217,217,190,100,86,223,203,20,46,222,203,164,237,189,253,47,4,255,142,248,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,77,83,219,48,16,253,43,30,193,49,202,88,214,135,37,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,59,99,43,237,208,76,254,123,21,39,1,66,219,83,117,176,165,213,190,183,187,207,207,27,114,30,95,87,72,42,242,128,125,15,67,23,226,244,162,235,113,122,219,119,14,135,97,122,221,57,104,234,95,96,27,188,133,30,150,24,177,127,132,102,141,195,117,61,196,73,118,10,35,19,114,254,99,188,37,213,211,134,204,34,46,191,207,124,98,47,181,65,225,138,130,218,160,25,21,121,238,169,78,33,42,180,194,80,50,163,188,100,9,236,186,102,189,108,111,48,194,45,196,23,82,109,200,200,150,8,192,11,147,123,169,105,46,5,80,225,181,164,166,16,138,122,175,133,82,104,185,209,156,108,39,100,112,47,184,132,177,232,59,88,48,8,169,154,161,165,204,45,21,104,45,213,14,28,13,129,27,171,132,22,12,221,14,124,200,127,7,62,157,61,205,134,111,63,91,236,239,71,222,42,64,51,224,98,154,162,159,2,87,13,46,177,141,213,70,74,93,148,192,29,149,22,29,21,65,66,154,217,104,90,26,94,42,45,10,102,57,223,38,192,155,154,213,134,229,82,105,91,40,202,28,211,9,194,13,53,178,76,59,40,11,96,78,6,171,212,14,114,213,198,58,190,94,140,26,85,27,192,28,133,116,64,157,48,50,161,176,164,192,141,167,28,108,89,148,26,153,98,229,118,113,182,216,13,230,235,97,213,192,235,227,159,243,221,33,248,204,117,109,168,251,37,142,187,8,46,14,153,125,205,154,221,85,154,177,110,50,104,125,182,122,233,90,28,166,95,234,126,136,89,157,190,108,214,133,172,199,97,221,196,186,125,78,200,166,65,23,235,174,157,206,252,190,234,234,196,48,31,235,110,230,123,223,205,73,53,255,151,243,14,239,189,206,167,222,251,108,187,57,153,204,201,125,183,238,221,142,145,167,195,229,135,129,199,34,99,202,167,227,209,103,41,210,174,155,230,16,185,132,8,199,196,99,184,243,117,168,209,207,218,251,163,189,70,150,252,176,232,95,30,199,181,239,237,127,96,55,208,194,51,246,95,147,0,239,189,191,117,249,144,100,60,18,219,194,200,188,100,129,150,8,38,249,92,21,84,123,6,212,48,99,3,47,121,17,66,49,162,239,48,96,143,173,195,211,198,152,178,200,149,100,84,7,44,168,96,210,36,188,207,41,232,156,123,161,52,247,158,31,240,195,168,246,238,7,63,244,181,147,106,75,182,219,197,246,55,23,17,232,91,84,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactAll.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: AddContactByLeadFlowElement

		/// <exclude/>
		public class AddContactByLeadFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactByLeadFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactByLead";
				IsLogging = true;
				SchemaElementUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Name = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null)) : (((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) : (((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) : ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)))));
				_recordDefValues_JobTitle = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("FullJobTitle").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("FullJobTitle") : null)));
				_recordDefValues_Dear = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Dear").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Dear") : null)));
				_recordDefValues_Department = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Department").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DepartmentId") : Guid.Empty)));
				_recordDefValues_Job = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Job").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("JobId") : Guid.Empty)));
				_recordDefValues_DoNotUseEmail = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseEmail").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseEmail") : false)));
				_recordDefValues_DoNotUseSms = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseSMS").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseSMS") : false)));
				_recordDefValues_DoNotUseMail = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseMail").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseMail") : false)));
				_recordDefValues_DoNotUseCall = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUsePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUsePhone") : false)));
				_recordDefValues_DoNotUseFax = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseFax").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseFax") : false)));
				_recordDefValues_Confirmed = () => (bool)(false);
				_recordDefValues_SalutationType = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("TitleId") : Guid.Empty)));
				_recordDefValues_Gender = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Gender").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("GenderId") : Guid.Empty)));
				_recordDefValues_DecisionRole = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DecisionRole").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DecisionRoleId") : Guid.Empty)));
				_recordDefValues_Email = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_recordDefValues_MobilePhone = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)));
				_recordDefValues_Phone = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Name", () => _recordDefValues_Name.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_JobTitle", () => _recordDefValues_JobTitle.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Dear", () => _recordDefValues_Dear.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Department", () => _recordDefValues_Department.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Job", () => _recordDefValues_Job.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseEmail", () => _recordDefValues_DoNotUseEmail.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseSms", () => _recordDefValues_DoNotUseSms.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseMail", () => _recordDefValues_DoNotUseMail.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseCall", () => _recordDefValues_DoNotUseCall.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseFax", () => _recordDefValues_DoNotUseFax.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Confirmed", () => _recordDefValues_Confirmed.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SalutationType", () => _recordDefValues_SalutationType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Gender", () => _recordDefValues_Gender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DecisionRole", () => _recordDefValues_DecisionRole.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Email", () => _recordDefValues_Email.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MobilePhone", () => _recordDefValues_MobilePhone.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Phone", () => _recordDefValues_Phone.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Name;
			internal Func<string> _recordDefValues_JobTitle;
			internal Func<string> _recordDefValues_Dear;
			internal Func<Guid> _recordDefValues_Department;
			internal Func<Guid> _recordDefValues_Job;
			internal Func<bool> _recordDefValues_DoNotUseEmail;
			internal Func<bool> _recordDefValues_DoNotUseSms;
			internal Func<bool> _recordDefValues_DoNotUseMail;
			internal Func<bool> _recordDefValues_DoNotUseCall;
			internal Func<bool> _recordDefValues_DoNotUseFax;
			internal Func<bool> _recordDefValues_Confirmed;
			internal Func<Guid> _recordDefValues_SalutationType;
			internal Func<Guid> _recordDefValues_Gender;
			internal Func<Guid> _recordDefValues_DecisionRole;
			internal Func<string> _recordDefValues_Email;
			internal Func<string> _recordDefValues_MobilePhone;
			internal Func<string> _recordDefValues_Phone;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,91,109,111,27,185,17,254,43,170,238,128,246,128,208,224,59,135,2,138,2,189,203,21,41,46,109,16,95,239,75,146,15,67,114,120,81,33,75,134,180,110,155,26,254,239,125,86,177,243,118,61,53,238,41,141,93,73,31,214,210,122,201,37,185,243,112,158,153,121,246,114,250,229,240,234,92,166,179,233,247,178,94,243,102,213,135,147,175,87,107,57,121,178,94,85,217,108,78,190,91,85,94,204,255,201,101,33,79,120,205,103,50,200,250,7,94,92,200,230,187,249,102,120,48,121,191,217,244,193,244,203,191,109,255,59,157,61,187,156,62,26,228,236,47,143,26,122,79,49,246,20,172,87,90,68,43,239,76,82,156,187,87,213,217,168,189,169,33,5,70,227,186,90,92,156,45,31,203,192,79,120,120,57,157,93,78,183,189,161,3,14,181,114,202,86,249,212,154,242,150,88,145,235,69,133,154,109,105,45,167,222,105,122,245,96,186,169,47,229,140,183,55,125,219,216,196,34,46,6,163,168,11,122,48,33,43,106,77,43,38,237,154,143,228,90,115,99,227,235,235,223,54,124,246,197,179,71,155,63,255,125,41,235,211,109,191,179,206,139,141,188,56,193,217,15,78,60,92,200,153,44,135,217,37,123,142,189,235,170,140,201,93,249,232,12,110,99,173,138,228,189,78,145,36,75,184,66,131,55,171,57,187,140,53,147,207,49,41,98,157,148,111,49,40,150,94,49,80,146,192,198,212,86,219,216,228,225,114,152,15,175,190,222,174,209,236,146,98,144,98,67,87,46,123,131,21,113,93,177,175,90,213,68,206,187,72,156,184,95,189,248,226,197,228,87,191,157,156,14,235,249,242,199,147,135,103,231,195,171,201,239,38,255,23,211,154,77,126,115,151,231,209,69,156,109,100,84,18,152,189,103,231,85,54,53,41,167,201,137,111,62,59,186,143,143,231,163,167,117,199,31,79,198,208,153,130,83,154,106,81,158,96,112,52,110,72,134,44,37,226,192,44,229,30,62,158,143,158,214,236,78,79,195,235,46,221,180,172,122,198,193,91,31,225,46,52,246,4,202,98,67,100,174,205,143,211,248,234,171,113,219,110,243,205,249,130,95,253,240,211,221,251,169,112,155,44,112,56,249,118,190,222,12,147,57,28,210,100,213,39,107,217,92,44,6,60,212,9,60,206,66,234,48,95,45,225,192,150,3,215,97,178,196,216,127,230,193,255,146,254,182,128,184,85,7,15,207,120,190,216,199,72,110,58,186,253,16,126,127,177,153,47,193,3,38,231,47,87,203,189,172,202,79,122,156,221,182,135,199,171,50,95,200,77,251,215,38,112,254,30,55,121,215,8,46,159,191,166,56,207,167,179,231,63,71,114,174,255,190,54,251,247,105,206,135,12,231,249,244,193,243,233,233,234,98,93,199,30,29,126,124,243,142,245,109,111,178,189,228,131,159,55,148,6,103,150,23,139,197,245,153,111,120,224,155,11,111,78,175,218,188,207,165,61,90,158,222,48,153,109,47,250,250,163,254,205,225,230,243,122,108,191,164,217,99,94,242,143,178,254,19,22,224,237,216,223,140,242,123,44,227,77,199,173,21,199,70,68,233,36,52,226,218,170,146,56,171,166,37,26,42,90,247,210,182,173,159,74,151,181,44,171,252,151,3,123,42,155,237,106,143,92,242,122,92,227,82,93,77,175,174,30,188,203,48,59,217,222,131,116,101,170,103,12,168,144,202,177,4,85,168,103,91,177,121,4,109,119,50,76,42,145,52,195,149,137,143,216,159,34,14,37,58,173,36,212,226,27,27,199,33,28,22,195,244,77,215,234,48,21,39,240,35,158,12,86,132,152,113,223,84,57,22,11,90,22,199,93,120,143,123,240,183,120,180,147,191,174,202,4,227,88,0,221,71,108,31,177,13,108,123,109,53,233,6,150,153,16,19,116,113,42,151,241,103,233,181,181,106,130,209,117,39,182,107,104,169,250,230,84,7,79,85,94,227,27,249,152,85,100,128,158,16,64,38,205,135,133,109,145,100,201,182,168,172,179,32,138,30,119,43,61,21,101,74,179,98,186,139,28,104,207,216,126,42,117,126,62,199,52,127,189,185,230,68,71,116,31,209,61,155,106,97,242,38,118,21,216,142,17,127,43,32,251,28,21,145,119,186,38,239,163,105,59,209,157,125,45,148,2,16,217,208,139,23,210,170,4,196,64,169,101,49,136,136,40,68,57,44,116,215,212,139,201,90,84,48,13,251,93,29,91,5,172,107,117,201,96,27,44,154,123,218,51,186,191,17,112,240,97,156,231,17,215,159,133,145,23,155,3,220,99,71,102,6,60,220,11,24,57,53,195,72,207,228,210,93,114,160,199,118,23,35,79,108,99,182,22,150,31,3,44,173,128,242,149,94,188,146,34,33,71,241,38,55,186,21,35,15,206,137,45,153,97,117,1,200,138,13,24,211,33,170,104,5,193,131,147,162,99,220,137,107,231,61,50,126,130,12,83,139,240,81,12,50,158,29,16,222,73,216,135,110,185,21,127,88,184,102,166,138,199,233,209,61,114,223,200,130,123,85,50,120,12,117,19,16,171,176,13,82,247,140,235,63,30,201,248,189,134,117,37,11,146,219,49,18,192,1,149,151,20,85,230,226,84,13,128,0,188,65,73,37,222,10,214,12,239,193,156,68,97,187,64,160,237,129,109,74,248,41,168,194,48,91,176,113,191,27,214,166,192,41,117,231,96,245,118,28,17,60,53,50,9,109,204,36,24,211,49,94,99,236,97,193,154,50,107,221,186,81,174,33,159,142,187,58,85,156,175,202,230,68,173,246,36,154,101,223,238,122,53,89,174,134,201,197,70,38,242,58,59,120,36,227,159,1,221,89,151,24,74,39,165,251,214,74,80,242,2,152,178,178,30,1,111,66,169,43,235,244,63,77,163,165,146,156,43,146,149,70,96,140,72,185,3,221,174,85,21,58,55,215,13,0,26,118,135,218,168,11,101,236,0,48,227,134,236,32,60,56,161,3,91,85,78,222,249,98,186,205,222,29,22,186,61,174,174,8,98,84,177,99,201,172,51,106,50,210,68,85,76,181,5,199,221,187,79,136,238,211,199,167,71,108,127,22,207,125,231,176,173,89,247,202,61,170,68,25,26,10,105,126,52,68,104,40,160,201,112,85,12,136,130,219,137,109,235,8,33,117,242,170,119,3,120,138,215,99,26,13,197,223,160,75,203,13,49,3,181,195,194,118,240,58,166,218,157,50,174,135,49,119,129,233,225,193,170,172,107,132,44,165,166,148,220,167,195,246,209,113,127,54,90,126,231,192,141,136,144,82,52,136,215,187,217,86,254,45,92,46,226,195,6,58,173,225,210,93,232,187,29,55,42,58,181,199,46,138,117,28,21,86,96,228,200,8,32,101,78,54,75,21,29,122,203,135,5,238,84,173,144,80,86,92,24,137,201,88,224,194,29,33,49,233,60,233,108,33,68,75,244,233,192,125,93,223,62,210,242,35,186,145,226,14,20,83,135,165,219,48,38,231,162,69,5,76,144,171,203,210,216,53,248,109,141,226,244,46,116,195,61,11,75,11,240,248,30,0,213,80,212,229,2,131,6,234,187,196,100,98,229,3,203,165,25,96,91,55,44,129,70,126,5,178,82,41,216,48,81,254,175,82,192,143,188,118,204,237,211,161,187,243,63,142,216,62,122,238,209,115,155,212,179,51,144,54,151,134,156,15,194,230,132,196,187,23,85,188,214,70,147,105,237,63,212,191,170,52,75,144,106,168,4,185,44,172,62,5,149,41,71,37,28,178,229,44,100,56,238,31,219,91,228,238,2,199,155,11,142,226,172,67,39,167,173,64,134,21,52,84,195,46,32,103,108,243,152,20,138,90,153,28,140,152,40,177,134,180,211,196,59,28,84,105,26,153,98,98,164,165,16,90,169,156,19,172,20,5,226,76,216,228,115,142,135,229,190,184,55,174,12,190,15,237,139,134,251,66,123,100,215,64,255,155,142,25,197,54,7,135,182,103,247,117,138,102,3,143,95,143,174,235,94,214,130,196,85,84,120,17,20,26,159,17,208,120,7,141,36,141,146,137,210,161,14,16,95,200,167,91,225,58,54,157,202,88,1,50,182,140,172,18,108,42,23,147,224,136,124,229,130,72,52,90,218,93,226,101,231,160,38,196,218,100,228,165,60,2,78,224,154,138,210,6,19,171,99,57,201,29,24,174,109,72,208,154,66,8,211,125,64,24,78,145,70,54,0,92,231,110,81,15,138,16,195,236,59,163,244,7,89,54,89,31,49,125,47,49,173,11,196,141,4,220,32,83,49,138,116,107,83,5,78,30,82,73,104,44,154,1,188,236,45,125,53,135,4,255,1,59,149,241,208,5,145,98,181,176,93,195,174,18,71,47,118,119,34,169,39,56,229,104,161,19,214,216,96,124,230,164,216,65,36,222,173,239,133,106,71,93,168,31,22,166,61,150,52,141,32,142,40,230,142,242,83,8,212,12,232,25,20,213,22,57,183,224,114,51,251,22,91,174,142,242,233,123,138,232,224,33,175,24,219,247,2,21,164,111,163,98,195,186,12,55,208,93,215,90,196,73,184,157,151,46,100,113,91,144,103,30,77,181,85,164,134,29,196,32,37,248,80,156,141,16,24,236,14,48,91,233,86,91,169,170,162,158,11,174,153,139,66,174,24,185,101,24,125,49,20,157,213,230,176,16,253,177,175,65,238,17,209,215,47,113,29,3,234,207,0,233,59,247,182,19,20,26,166,66,186,165,108,129,252,15,126,21,138,33,212,38,70,80,49,53,221,114,45,102,183,102,26,201,79,10,176,88,110,30,52,147,43,8,68,53,21,60,188,136,206,168,36,53,127,96,249,224,143,125,231,116,143,144,126,255,77,198,35,178,143,200,134,179,214,193,100,143,18,46,148,26,80,20,244,206,215,111,67,64,144,13,101,54,231,88,119,59,107,242,144,118,106,98,168,60,128,75,200,182,17,64,114,100,36,255,16,253,7,196,219,90,151,195,66,246,199,190,20,191,71,100,127,248,150,243,17,219,7,138,237,23,87,255,2,14,145,72,204,99,71,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactByLead.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: AddContactAdressFlowElement

		/// <exclude/>
		public class AddContactAdressFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactAdressFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactAdress";
				IsLogging = true;
				SchemaElementUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Address = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Address").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Address") : null)));
				_recordDefValues_City = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("City").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CityId") : Guid.Empty)));
				_recordDefValues_Zip = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Zip").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Zip") : null)));
				_recordDefValues_Contact = () => (Guid)((process.AddContactByLead.RecordId));
				_recordDefValues_Region = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Region").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("RegionId") : Guid.Empty)));
				_recordDefValues_Primary = () => (bool)(true);
				_recordDefValues_Country = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Country").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CountryId") : Guid.Empty)));
				_recordDefValues_AddressType = () => (Guid)((((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty)) != Guid.Empty) ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty)) : new Guid("fb7a3f6a-f36b-1410-6f81-1c6f65e50343"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Address", () => _recordDefValues_Address.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_City", () => _recordDefValues_City.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Zip", () => _recordDefValues_Zip.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Region", () => _recordDefValues_Region.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Primary", () => _recordDefValues_Primary.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Country", () => _recordDefValues_Country.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_AddressType", () => _recordDefValues_AddressType.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Address;
			internal Func<Guid> _recordDefValues_City;
			internal Func<string> _recordDefValues_Zip;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Region;
			internal Func<bool> _recordDefValues_Primary;
			internal Func<Guid> _recordDefValues_Country;
			internal Func<Guid> _recordDefValues_AddressType;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,75,111,219,70,16,254,43,129,206,217,100,223,143,220,82,39,109,13,20,73,80,7,57,36,246,97,159,14,81,74,20,72,42,173,27,248,191,103,72,201,138,100,75,214,138,72,108,181,182,15,178,180,24,206,206,99,191,225,204,183,95,71,190,180,77,243,198,142,227,232,197,232,125,172,107,219,84,169,125,246,107,81,182,177,254,173,174,102,211,209,211,81,19,235,194,150,197,191,49,204,215,95,135,162,125,101,91,11,143,124,61,253,174,225,116,244,226,116,179,142,211,209,211,211,81,209,198,113,3,50,240,136,145,154,70,31,18,18,202,83,196,141,52,72,51,207,17,139,49,48,42,73,242,66,207,37,183,41,63,170,198,83,91,199,249,30,189,250,212,127,125,127,49,237,68,9,44,248,94,164,104,170,201,98,145,117,70,52,175,39,214,149,49,192,239,182,158,69,88,106,235,98,12,222,196,247,197,56,190,179,53,236,213,233,169,186,37,16,74,182,108,58,169,50,166,246,245,63,211,58,54,77,81,77,118,25,87,206,198,147,85,105,80,16,151,63,23,230,224,222,198,78,242,157,109,63,247,42,142,193,172,203,222,202,151,231,231,117,60,183,109,241,101,213,136,191,226,69,47,151,23,63,120,32,64,150,62,216,114,22,87,246,92,247,228,200,78,219,185,67,243,237,65,160,46,206,63,103,251,186,140,216,46,119,41,44,78,175,132,51,117,110,244,129,74,88,252,210,45,204,181,92,125,61,29,125,58,110,222,254,61,137,245,137,255,28,199,118,30,181,179,103,176,122,109,97,169,255,197,87,194,48,118,130,69,68,141,244,136,107,161,33,146,82,67,76,153,13,158,10,171,184,191,60,155,219,81,52,211,210,94,124,88,110,247,71,180,97,17,178,238,31,172,104,165,180,150,148,34,234,2,232,80,70,35,147,56,70,204,19,98,45,246,78,24,7,25,134,63,120,70,19,131,173,73,30,25,29,28,226,36,41,164,35,8,99,31,73,226,222,144,36,22,30,14,64,88,148,132,226,148,44,10,202,5,196,131,96,200,70,97,144,99,132,123,199,163,163,78,222,174,252,120,178,13,92,252,191,9,174,151,33,116,50,115,129,28,148,229,197,112,195,9,37,183,195,108,97,200,147,182,151,238,0,23,83,172,227,196,199,249,57,93,58,189,102,241,77,96,118,169,254,116,80,208,236,29,95,129,230,2,22,60,105,71,131,84,72,145,128,17,23,201,33,109,84,68,62,112,203,176,182,70,121,220,235,91,110,248,123,213,125,89,81,182,135,146,27,56,157,43,3,208,157,245,176,227,196,171,20,53,74,138,71,64,124,34,29,236,12,194,78,59,22,20,37,30,227,29,200,104,222,204,202,114,27,58,232,38,116,144,255,31,58,242,226,120,135,232,40,250,180,44,130,219,121,192,21,75,80,198,9,226,172,59,49,73,17,100,48,3,11,153,17,142,106,162,156,222,209,101,60,214,192,188,24,62,214,192,157,53,48,57,101,89,146,22,37,38,29,34,156,96,36,147,38,136,120,153,164,136,2,51,206,214,107,224,47,179,166,152,192,1,191,86,7,179,21,221,168,131,223,21,94,213,66,99,28,167,68,49,196,157,5,12,11,165,144,197,60,32,6,149,53,209,224,177,245,252,17,33,59,122,241,172,24,62,34,100,39,66,148,196,46,73,13,93,184,147,17,133,68,8,114,70,107,132,49,9,18,71,195,180,151,235,8,121,21,75,200,73,125,113,13,33,217,138,110,32,228,187,194,30,33,29,68,202,234,188,240,182,124,59,141,181,93,188,163,182,188,204,215,186,128,110,70,169,171,170,189,246,206,234,70,134,126,235,229,91,52,107,8,232,12,97,208,118,18,154,12,138,12,142,24,23,198,34,221,125,144,32,180,141,146,67,61,14,131,199,5,9,101,3,198,29,133,168,119,48,80,90,138,17,40,53,136,193,106,84,218,170,68,220,15,111,138,232,193,55,69,71,213,108,210,246,199,33,163,33,202,139,225,254,133,96,105,196,45,189,208,170,204,178,15,234,13,236,44,79,137,81,165,5,208,5,22,102,24,232,219,96,134,209,150,34,47,40,64,66,71,143,141,127,128,217,253,51,158,247,226,57,201,205,11,225,254,201,61,105,193,241,231,211,186,250,82,64,86,111,205,241,149,185,27,83,108,165,211,209,72,137,128,110,128,58,66,187,62,13,104,32,68,5,229,158,56,238,140,120,136,41,254,88,76,243,242,155,23,191,77,249,189,53,189,31,143,223,61,159,86,77,107,203,39,190,10,113,75,242,184,12,222,82,74,80,208,73,0,209,96,128,104,112,198,35,207,25,39,70,91,2,47,131,7,152,188,163,162,205,44,189,121,1,28,80,122,123,11,110,171,187,87,2,55,147,234,168,144,240,20,65,44,9,14,124,98,164,200,113,24,146,45,177,2,166,42,207,29,139,15,48,169,139,169,61,47,175,121,49,220,27,149,75,27,110,38,238,14,90,190,188,70,110,155,37,248,7,90,66,169,73,134,3,219,141,29,149,208,45,3,93,173,21,77,96,14,181,76,5,37,188,129,81,242,18,110,128,186,248,158,84,179,218,47,110,92,154,249,213,207,160,43,157,123,184,168,217,231,238,101,227,237,71,14,101,122,40,247,20,63,247,46,98,208,29,195,61,92,31,12,226,60,183,16,236,67,178,191,54,228,230,178,215,123,83,212,247,192,60,15,36,147,7,115,179,143,103,39,143,241,219,155,210,123,12,108,30,81,244,51,153,160,253,136,157,65,132,205,61,52,141,3,168,149,225,148,197,129,250,183,78,46,12,31,215,15,212,189,149,193,122,248,52,123,160,190,173,206,157,195,167,186,3,117,238,229,250,252,117,39,195,207,79,155,101,46,71,151,223,0,57,71,56,128,194,38,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,4,0,183,239,220,131,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,28,69,16,253,149,101,201,3,72,238,77,223,47,43,33,4,33,32,75,1,162,36,228,129,56,15,213,221,213,176,98,61,99,205,206,130,130,229,127,231,204,218,38,78,128,13,1,43,33,196,243,176,151,158,233,154,234,158,58,117,78,213,156,206,111,141,207,78,120,190,156,63,226,97,160,77,223,198,197,157,126,224,197,253,161,47,188,217,44,238,245,133,214,171,95,41,175,249,62,13,116,204,35,15,143,105,189,229,205,189,213,102,60,152,189,56,109,126,48,191,245,243,238,236,124,249,228,116,126,56,242,241,119,135,21,214,85,36,82,20,165,168,173,72,97,139,101,145,101,33,65,177,153,98,156,245,181,78,147,75,191,222,30,119,95,243,72,247,105,252,113,190,60,157,239,172,193,128,103,21,93,202,81,56,114,70,88,103,130,200,170,177,104,129,56,150,108,149,243,118,126,118,48,223,148,31,249,152,118,55,125,62,185,58,91,181,86,81,120,85,162,176,202,224,198,42,7,225,130,141,37,176,118,205,249,105,242,197,245,207,39,62,249,240,201,225,230,219,95,58,30,30,238,236,46,27,173,55,252,116,129,209,151,6,238,174,249,152,187,113,121,74,150,124,107,178,8,165,82,19,214,27,133,69,106,45,124,180,86,6,31,57,177,59,195,132,223,119,115,121,234,75,138,54,249,32,34,201,32,108,245,78,16,183,2,71,35,59,82,170,212,82,167,41,119,187,113,53,62,187,179,219,163,229,105,240,57,90,95,188,240,212,156,176,178,104,145,92,240,194,21,87,115,145,213,107,41,207,158,126,248,116,90,88,93,109,78,214,244,236,241,31,215,247,128,169,206,214,248,88,124,185,26,54,227,108,133,71,54,235,219,108,224,205,118,61,174,186,31,102,120,38,107,46,227,170,239,22,159,213,138,241,205,185,205,147,23,194,225,170,213,211,163,243,168,58,154,47,143,254,42,174,46,190,207,119,241,197,200,122,57,168,142,230,7,71,243,135,253,118,40,147,69,131,63,95,92,89,206,238,38,187,75,94,250,123,25,69,24,233,182,235,245,197,200,23,52,210,229,133,151,195,125,93,181,21,215,195,238,225,101,240,236,172,200,139,67,252,201,199,229,113,238,219,191,153,246,53,117,244,3,15,223,96,3,158,251,254,187,151,143,176,141,151,134,139,108,210,122,141,8,193,163,21,22,207,88,68,203,78,36,171,82,45,209,41,159,213,110,246,3,110,60,112,87,248,31,58,246,128,55,187,221,158,224,123,225,215,180,85,103,243,179,179,131,171,160,206,46,218,66,202,8,131,8,158,96,229,69,98,38,161,17,233,92,40,105,27,218,94,80,43,107,92,169,45,99,174,210,194,114,182,200,10,62,137,40,147,174,44,85,240,62,188,95,160,182,218,197,236,147,20,141,131,194,51,14,36,162,14,81,52,73,33,167,90,109,136,215,13,234,59,184,253,13,162,223,10,162,179,78,78,6,213,68,96,2,128,216,107,17,171,34,145,84,202,205,4,163,91,211,251,16,237,0,50,153,61,38,24,70,140,89,27,69,198,149,130,50,146,129,231,162,75,227,215,66,52,32,204,92,16,180,42,74,43,108,212,64,180,206,94,52,178,182,21,71,153,226,126,154,14,197,43,25,116,17,153,52,12,80,54,34,42,77,194,155,96,21,25,206,200,96,239,23,162,89,53,36,57,131,69,133,134,28,87,201,8,50,205,139,106,117,178,68,21,251,228,175,25,209,223,31,222,191,125,210,111,70,90,99,180,242,13,184,223,10,184,141,118,20,12,20,171,108,118,2,39,77,116,13,154,11,94,250,134,52,46,13,149,55,74,215,181,214,96,166,28,97,34,188,178,141,173,136,177,22,97,40,41,15,1,17,61,249,253,116,237,101,50,209,69,65,45,131,156,12,248,62,199,92,132,211,202,37,128,41,66,136,254,39,192,173,168,69,169,107,18,169,105,20,11,90,194,209,84,144,23,89,102,41,157,172,148,248,37,112,135,128,234,4,46,128,115,61,196,213,180,172,204,208,90,156,144,38,170,45,5,197,199,171,97,10,129,60,219,118,165,239,218,106,56,230,10,248,117,35,149,113,150,105,131,127,125,183,131,240,108,213,181,126,56,166,115,246,29,152,70,156,27,184,244,67,157,29,214,27,180,190,147,84,12,241,205,198,59,37,98,99,164,121,0,2,243,171,4,169,72,83,173,143,166,86,243,90,104,117,86,101,25,195,196,164,18,96,67,253,11,113,13,78,37,45,57,133,8,167,140,218,139,214,130,108,147,26,92,104,54,98,69,53,2,238,201,123,81,76,11,182,90,89,147,123,207,42,230,90,216,72,6,21,155,140,246,129,149,16,39,57,161,118,150,49,135,132,253,48,200,20,215,76,197,15,71,160,251,246,201,208,255,188,66,200,220,96,251,157,196,54,212,47,74,211,4,50,240,80,111,182,197,34,162,243,104,69,213,102,115,213,20,115,82,175,133,109,214,213,84,84,115,168,118,193,191,150,167,95,14,133,179,146,5,170,193,55,111,188,220,139,237,170,84,165,66,25,6,76,133,204,6,81,161,12,200,34,73,139,200,71,52,151,154,174,31,219,227,128,175,61,216,184,60,127,211,25,122,195,1,62,21,129,46,183,73,106,238,146,160,5,13,133,144,208,136,209,160,144,64,45,201,240,70,165,166,178,84,109,203,44,216,77,221,157,228,42,164,102,156,138,30,28,141,13,26,149,121,111,128,75,143,120,38,180,52,177,170,118,78,167,169,76,196,192,208,105,21,98,172,6,122,207,200,43,164,108,171,68,254,10,9,122,32,37,131,118,175,206,130,101,10,50,198,236,92,185,238,58,242,78,191,237,198,225,166,57,244,110,178,150,76,173,160,249,0,154,82,14,193,165,19,122,57,232,182,138,8,110,128,4,76,228,75,123,45,80,19,94,49,76,47,107,132,118,1,164,83,34,124,169,168,152,208,166,133,148,180,186,185,72,251,89,43,39,233,224,58,136,19,126,216,169,103,69,8,127,81,157,129,64,46,89,203,154,175,31,212,31,253,151,81,237,125,116,154,130,19,89,107,198,150,160,243,139,252,134,91,166,168,44,152,92,42,163,38,84,207,62,248,100,246,213,118,85,23,119,143,79,198,103,31,207,62,157,253,47,86,181,196,50,238,245,253,79,219,147,133,147,209,132,60,153,54,109,114,206,67,205,216,156,5,222,3,68,27,208,149,172,42,47,26,26,226,104,158,145,104,6,231,193,115,82,248,22,149,80,5,162,201,177,147,198,154,253,41,240,163,127,246,202,107,54,189,207,250,243,199,240,111,204,93,89,255,213,51,139,207,183,155,85,55,189,38,251,251,11,190,17,93,239,88,126,254,59,1,255,170,252,252,244,236,55,73,40,141,234,193,31,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactAdress.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: AddContactWebFlowElement

		/// <exclude/>
		public class AddContactWebFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactWebFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactWeb";
				IsLogging = true;
				SchemaElementUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Contact = () => (Guid)((process.AddContactByLead.RecordId));
				_recordDefValues_Number = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Website").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Website") : null)));
				_recordDefValues_CommunicationType = () => (Guid)(new Guid("6a8ba927-67cc-df11-9b2a-001d60e938c6"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Number", () => _recordDefValues_Number.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CommunicationType", () => _recordDefValues_CommunicationType.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Contact;
			internal Func<string> _recordDefValues_Number;
			internal Func<Guid> _recordDefValues_CommunicationType;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,93,111,218,48,20,253,47,121,174,171,196,118,66,194,219,212,177,9,105,106,43,21,117,15,163,15,55,246,13,88,115,72,100,135,110,12,241,223,119,147,0,163,19,163,116,210,214,230,37,201,209,241,185,95,190,103,29,40,11,222,95,67,137,193,48,152,160,115,224,171,162,185,252,96,108,131,238,163,171,150,117,112,17,120,116,6,172,249,129,186,199,71,218,52,239,161,1,58,178,158,254,82,152,6,195,233,113,141,105,112,49,13,76,131,165,39,14,29,41,116,34,84,81,68,76,69,81,193,100,170,129,101,188,144,44,201,115,149,101,89,40,57,111,213,78,136,95,85,101,13,14,251,24,157,124,209,125,78,86,117,75,141,8,80,29,197,248,106,177,5,69,155,132,31,45,32,183,168,233,191,113,75,36,168,113,166,164,106,112,98,74,188,5,71,177,90,157,170,133,136,84,128,245,45,203,98,209,140,190,215,14,189,55,213,226,185,228,236,178,92,28,178,73,0,247,191,219,116,194,46,199,150,121,11,205,188,147,24,83,90,155,46,203,119,179,153,195,25,52,230,241,48,137,175,184,234,120,231,245,143,14,104,154,210,61,216,37,30,196,124,90,201,21,212,77,95,80,31,158,8,206,204,230,103,215,186,239,216,115,229,114,2,235,29,249,76,205,163,53,240,132,192,199,22,232,85,118,159,211,224,203,216,223,124,91,160,187,83,115,44,161,239,218,195,37,161,191,1,123,253,225,58,18,97,152,199,2,25,207,18,69,157,140,83,150,138,36,101,50,19,160,21,143,97,32,213,230,161,207,195,248,218,194,234,126,31,238,19,130,222,182,172,125,17,146,132,60,201,213,64,48,149,74,96,50,207,105,46,49,72,150,230,105,164,57,207,165,140,21,77,152,30,58,35,82,228,58,149,146,113,224,146,73,165,82,150,105,136,152,24,112,46,10,57,80,66,71,167,251,52,246,215,75,107,255,180,3,252,216,14,240,55,191,3,159,49,247,100,21,231,45,194,121,61,60,114,137,162,147,139,64,57,244,150,213,53,120,23,183,155,154,173,102,70,129,189,169,209,193,150,31,30,239,233,147,97,180,119,214,85,85,211,223,196,125,191,218,43,212,69,218,21,148,13,66,1,42,148,12,138,56,99,146,103,192,210,68,208,53,26,164,74,235,56,76,184,18,212,26,50,229,182,162,187,106,233,212,214,4,125,239,198,127,229,178,175,224,157,47,177,195,163,134,116,142,193,188,21,235,248,183,246,240,10,91,143,47,95,228,255,178,73,155,96,243,19,184,24,168,34,211,8,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,4,0,183,239,220,131,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,149,75,111,220,54,16,199,191,202,66,201,209,92,240,253,216,91,225,164,128,1,167,53,226,52,61,216,62,12,201,97,34,84,43,25,146,182,133,187,216,239,222,145,188,27,63,218,218,46,138,162,45,16,29,36,145,226,60,56,250,255,56,219,234,245,120,115,141,213,170,250,128,125,15,67,87,198,229,113,215,227,242,172,239,18,14,195,242,180,75,208,212,191,66,108,240,12,122,88,227,136,253,71,104,54,56,156,214,195,120,180,120,104,86,29,85,175,127,158,191,86,171,139,109,117,50,226,250,135,147,76,222,179,202,218,154,16,152,3,237,153,230,46,50,47,193,50,101,4,198,44,101,240,5,200,56,117,205,102,221,190,195,17,206,96,252,92,173,182,213,236,141,28,164,34,165,213,198,179,36,18,103,58,243,196,160,160,97,90,88,171,139,204,198,113,172,118,71,213,144,62,227,26,230,160,119,198,156,107,8,66,10,38,69,161,232,32,144,249,32,232,205,36,94,156,177,8,90,76,198,251,245,119,134,23,175,46,78,134,239,127,105,177,63,159,253,174,10,52,3,94,45,105,246,209,196,219,6,215,216,142,171,173,128,226,185,204,129,133,34,21,211,146,91,22,67,66,6,200,35,231,134,103,8,184,35,131,47,213,92,109,157,3,207,139,177,76,71,75,123,243,49,177,136,210,49,12,182,148,172,83,50,33,238,174,94,93,77,41,230,122,184,110,224,230,227,239,51,253,38,231,197,166,77,93,91,234,126,141,121,65,111,35,164,113,17,97,160,81,215,46,26,132,188,168,219,210,245,107,24,235,174,93,30,247,8,35,125,235,49,117,125,94,156,228,219,16,215,15,254,243,253,32,219,203,91,185,92,86,171,203,63,19,204,254,121,91,158,135,146,121,172,150,203,234,232,178,58,239,54,125,154,60,42,26,188,185,183,187,57,200,188,228,209,240,32,15,154,105,55,77,179,159,121,3,35,28,22,30,166,187,92,151,26,243,73,123,126,80,197,236,133,239,47,246,7,183,195,117,155,219,223,49,123,7,45,124,194,254,59,42,192,93,238,95,178,252,64,101,60,56,142,50,24,238,68,97,14,33,48,141,86,50,159,5,176,32,66,44,202,41,89,138,156,173,223,99,193,30,219,132,15,19,19,54,162,178,70,48,95,80,18,17,38,144,125,230,140,84,53,97,231,85,206,106,111,63,204,213,158,184,220,231,53,149,106,87,237,118,71,247,105,149,81,104,233,4,201,176,56,77,130,180,137,5,29,10,243,66,128,8,147,194,75,126,146,86,46,75,2,52,142,21,40,64,59,210,133,5,101,29,139,198,43,225,192,162,196,244,159,160,21,52,16,99,116,152,8,65,251,211,86,9,170,154,148,204,122,77,135,148,245,24,208,60,162,213,166,224,117,160,205,120,224,142,78,34,107,136,237,146,168,238,30,13,8,145,114,202,147,201,219,118,172,199,155,227,185,70,171,45,58,163,130,160,66,10,157,5,29,11,66,177,24,157,163,178,40,157,13,90,170,116,121,158,241,247,19,194,19,199,203,111,235,126,24,23,53,253,178,69,87,136,224,97,211,140,117,251,137,168,111,26,76,51,222,63,98,252,10,244,191,2,116,206,81,145,108,145,113,135,164,219,76,64,71,71,104,103,142,86,120,106,3,37,230,167,128,126,113,98,47,5,58,43,197,173,75,192,32,207,9,145,214,65,38,203,44,240,132,232,188,79,138,63,9,180,144,69,100,167,136,101,149,168,233,130,145,44,196,76,253,27,57,38,40,89,149,168,255,9,160,79,187,238,167,205,245,50,123,109,83,164,83,164,8,159,9,211,64,30,84,41,83,135,20,133,98,131,119,106,105,193,71,8,212,55,105,167,137,229,34,4,229,40,129,170,38,178,229,24,148,79,246,57,192,246,241,142,187,245,122,211,214,105,238,147,139,238,122,126,76,157,111,130,234,47,4,250,218,74,255,103,173,244,37,66,123,142,188,171,221,111,14,176,79,189,86,11,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactWeb.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ParallelGatewayAddContactCommunicationFlowElement

		/// <exclude/>
		public class ParallelGatewayAddContactCommunicationFlowElement : ProcessParallelGateway
		{

			public ParallelGatewayAddContactCommunicationFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGatewayAddContactCommunication";
				IsLogging = true;
				SchemaElementUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "AddContactByLead", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = true;
				SchemaElementUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "AddContactWeb", false }, { "AddContactAdress", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: ReadContactsByLeadEmailFlowElement

		/// <exclude/>
		public class ReadContactsByLeadEmailFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadEmailFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadEmail";
				IsLogging = true;
				SchemaElementUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,75,111,27,55,16,254,43,130,78,45,16,26,228,146,203,229,234,22,184,106,225,75,18,52,70,46,145,15,124,12,229,69,247,33,236,82,105,84,65,255,189,195,221,149,44,39,178,163,186,77,237,2,245,193,144,70,195,143,223,112,190,121,108,167,182,212,93,247,70,87,48,157,77,175,161,109,117,215,248,112,241,115,81,6,104,127,105,155,245,106,250,106,218,65,91,232,178,248,3,220,96,159,187,34,252,164,131,198,35,219,197,29,194,98,58,91,156,198,88,76,95,45,166,69,128,170,67,31,60,162,105,238,64,39,142,164,169,118,68,24,46,137,206,165,37,210,105,33,82,46,165,100,106,240,124,8,124,254,185,232,66,55,92,209,163,251,254,227,245,102,21,61,83,52,216,166,90,233,182,232,154,122,52,178,104,45,186,121,173,77,9,14,13,161,93,3,154,66,91,84,24,13,92,23,21,188,211,45,222,21,129,154,104,66,39,175,203,46,122,149,224,195,252,243,170,133,174,43,154,250,113,114,151,77,185,174,234,99,111,4,128,195,215,145,15,237,73,70,207,119,58,220,246,16,31,47,155,58,104,27,46,155,170,90,215,133,213,1,221,103,163,241,230,226,10,89,239,250,32,94,47,151,45,44,241,231,79,112,23,200,111,176,233,81,206,123,93,60,224,48,135,31,116,185,134,35,70,247,227,188,212,171,72,161,135,29,105,76,236,49,185,73,211,59,76,126,48,155,201,16,204,100,244,251,177,191,162,91,155,33,73,99,230,159,32,150,52,247,60,19,206,144,44,81,154,8,202,115,98,120,194,136,246,78,209,92,58,159,88,247,173,124,68,41,192,67,106,97,167,212,194,95,188,88,222,172,43,19,195,57,165,136,61,145,189,36,206,123,195,19,146,72,212,163,154,216,115,64,167,182,88,222,158,29,244,225,233,190,21,119,130,198,213,222,249,76,204,211,129,72,52,126,138,134,1,101,255,17,139,238,170,123,251,123,13,237,123,123,11,149,30,158,238,230,2,173,95,24,230,37,84,80,135,217,86,11,45,189,167,150,48,150,123,34,36,199,119,84,73,66,164,18,130,102,82,65,14,233,14,15,28,8,205,182,210,230,74,228,50,35,74,211,140,8,39,83,162,193,91,34,152,130,84,51,102,157,117,241,200,188,14,69,216,12,146,152,109,61,0,79,156,98,36,131,68,16,161,185,32,57,179,25,225,84,113,16,78,228,92,249,221,205,16,110,209,173,74,189,249,112,136,234,87,208,110,82,226,63,44,173,182,11,147,88,80,147,198,79,240,121,215,101,40,234,101,44,215,18,108,76,229,197,188,210,69,217,227,196,22,131,167,173,76,128,82,106,8,87,40,149,216,53,240,230,20,57,88,46,149,207,149,49,41,67,229,225,31,158,225,44,7,16,60,67,23,228,42,140,7,162,93,146,19,202,83,78,37,254,152,24,253,120,234,174,234,135,106,83,252,55,107,243,94,3,31,220,206,41,211,243,94,242,132,186,217,227,173,123,240,250,186,72,99,135,253,248,162,202,180,15,228,168,76,71,61,2,48,171,82,203,137,245,214,16,231,25,35,185,73,52,161,148,57,73,1,11,193,202,30,239,112,225,157,164,239,42,253,108,148,175,170,105,68,67,189,223,244,146,47,155,37,38,183,124,187,130,182,79,241,168,130,19,162,188,167,230,216,131,218,166,9,67,103,57,112,61,53,245,123,30,123,93,24,233,172,6,225,137,203,5,150,99,226,57,49,76,122,146,169,52,195,190,110,242,132,211,158,221,247,162,118,143,141,230,128,122,100,2,175,103,10,217,48,100,67,169,39,220,164,70,33,75,101,192,35,27,92,28,99,118,223,55,235,214,142,179,183,27,54,198,39,109,130,207,177,224,253,131,59,219,151,139,208,147,22,156,103,88,91,254,234,38,114,114,13,56,167,95,252,63,176,95,224,192,126,134,89,252,55,198,235,3,211,237,41,234,99,199,115,232,220,201,241,111,78,135,239,218,236,119,211,221,159,61,201,224,253,26,16,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,176,50,212,241,76,1,82,6,0,110,89,182,126,20,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,75,76,53,72,53,49,77,78,212,77,54,177,52,213,53,73,75,53,215,77,52,182,76,209,53,78,76,50,55,50,183,72,53,52,51,52,7,0,106,93,85,138,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeLeadContactEmailFlowElement

		/// <exclude/>
		public class ChangeLeadContactEmailFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactEmailFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactEmail";
				IsLogging = true;
				SchemaElementUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,23,157,195,192,122,153,162,111,69,226,22,6,138,38,64,140,92,170,28,86,228,74,38,42,89,2,73,165,117,13,255,123,151,146,237,58,133,139,56,189,52,186,72,26,12,103,103,151,179,219,64,214,96,237,23,104,48,152,5,75,52,6,108,91,186,235,143,186,118,104,62,153,182,239,130,171,192,162,209,80,235,159,168,70,124,174,180,187,5,7,116,100,155,255,86,200,131,89,126,94,35,15,174,242,64,59,108,44,113,232,8,47,195,2,36,47,24,136,24,89,130,92,178,12,100,196,74,133,34,2,5,177,72,202,145,249,55,241,155,182,233,192,224,88,99,144,47,135,207,229,166,243,212,144,0,57,80,180,109,215,123,48,246,38,236,124,13,69,141,138,254,157,233,145,32,103,116,67,221,224,82,55,120,15,134,106,121,157,214,67,68,42,161,182,158,85,99,233,230,63,58,131,214,234,118,253,154,185,186,111,214,167,108,18,192,227,239,222,206,100,240,232,153,247,224,86,131,196,130,108,237,6,151,31,170,202,96,5,78,63,159,154,248,134,155,129,119,217,252,232,128,162,91,122,132,186,199,147,154,47,59,185,129,206,141,13,141,229,137,96,116,181,186,184,215,227,196,94,107,55,34,176,59,144,47,212,60,219,67,52,37,240,217,3,163,202,225,51,15,190,46,236,221,247,53,154,7,185,194,6,198,169,61,93,19,250,7,112,212,159,109,195,120,50,41,82,26,98,36,166,146,37,89,154,177,44,158,102,44,17,49,40,25,165,192,19,185,123,26,125,104,219,213,176,121,60,150,251,140,160,246,35,243,47,66,162,105,42,20,79,56,43,80,9,150,200,136,212,184,23,71,1,80,68,113,150,150,64,55,236,31,127,17,109,165,37,212,119,29,26,186,232,97,208,147,243,17,125,145,109,223,190,105,91,55,54,117,28,159,119,51,120,57,132,68,132,10,120,166,40,36,225,148,179,36,12,5,43,196,36,101,101,194,37,79,226,184,72,5,133,100,71,251,237,39,252,208,246,70,238,247,201,142,139,253,79,11,251,31,214,240,45,155,117,54,219,151,100,245,189,164,112,241,94,146,182,11,118,191,0,88,136,108,183,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,82,219,48,16,253,21,143,224,24,101,36,91,182,36,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,155,177,149,118,210,140,255,189,178,147,0,161,237,169,58,216,214,106,223,219,221,231,167,29,57,15,219,87,36,37,121,192,174,131,190,245,97,126,209,118,56,191,237,90,139,125,63,191,110,45,212,213,47,48,53,222,66,7,107,12,216,61,66,189,193,254,186,234,195,44,57,133,145,25,57,255,49,157,146,242,105,71,22,1,215,223,23,46,178,91,103,85,206,210,130,58,229,13,21,169,226,20,12,203,105,202,160,40,28,79,65,115,19,193,182,173,55,235,230,6,3,220,66,120,33,229,142,76,108,145,0,156,208,204,229,138,178,92,0,21,78,229,84,167,34,242,57,37,138,2,77,166,85,70,134,25,233,237,11,174,97,42,250,14,22,28,188,210,168,169,204,89,172,142,198,80,101,193,82,239,51,109,10,161,4,71,59,130,15,249,239,192,167,179,167,69,255,237,103,131,221,253,196,91,122,168,123,92,205,99,244,83,224,170,198,53,54,161,220,33,75,81,42,166,168,146,169,166,194,106,73,141,102,146,114,161,164,79,145,203,84,170,33,2,222,212,44,119,2,57,50,169,51,10,57,218,40,14,8,106,164,137,179,89,31,123,229,133,100,136,35,228,170,9,85,216,94,76,26,149,59,64,134,34,183,64,173,208,57,21,30,37,133,76,59,154,129,25,107,32,47,184,28,86,103,171,113,48,87,245,175,53,108,31,255,156,239,14,193,37,182,109,124,213,173,113,250,10,96,67,159,152,109,82,143,71,113,198,170,158,127,169,186,62,36,85,252,157,73,235,147,14,251,77,29,170,230,57,166,215,53,218,80,181,205,124,225,246,165,94,79,92,242,177,216,110,185,55,219,146,148,203,127,217,237,240,222,139,123,106,184,207,94,91,146,217,146,220,183,155,206,142,140,89,220,92,126,152,114,42,50,165,124,218,30,205,21,35,205,166,174,15,145,75,8,112,76,60,134,91,87,249,10,221,162,185,63,122,106,98,97,135,69,255,242,56,174,125,111,255,3,187,129,6,158,177,251,26,5,120,239,253,173,203,135,40,227,145,216,164,58,103,146,123,42,17,162,225,176,72,169,114,28,168,230,218,248,76,102,169,247,233,132,190,67,143,29,54,22,79,27,227,133,193,172,200,57,85,30,83,42,120,174,35,222,49,10,138,101,78,20,42,115,46,59,224,251,73,237,241,86,31,250,26,165,26,200,48,172,134,223,213,184,64,99,73,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactEmail.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ReadContactsByLeadPhoneFlowElement

		/// <exclude/>
		public class ReadContactsByLeadPhoneFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadPhoneFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadPhone";
				IsLogging = true;
				SchemaElementUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,77,115,219,56,12,253,43,30,159,118,103,202,12,41,81,20,233,219,54,235,221,201,97,219,206,54,211,75,147,3,68,130,142,102,245,225,145,228,110,179,153,252,247,130,146,237,36,141,147,170,110,179,241,33,62,120,100,24,132,0,16,15,120,184,154,218,2,218,246,13,148,56,157,77,79,177,105,160,173,125,119,244,71,94,116,216,252,217,212,171,229,244,213,180,197,38,135,34,255,15,221,32,159,187,188,251,29,58,160,35,87,103,55,22,206,166,179,179,221,54,206,166,175,206,166,121,135,101,75,58,116,68,75,224,42,85,154,37,54,201,152,20,41,50,64,159,48,107,116,22,123,14,206,113,63,104,62,100,124,254,57,111,187,118,120,69,111,221,247,143,167,151,203,160,153,144,192,214,229,18,154,188,173,171,181,80,4,105,222,206,43,200,10,116,36,232,154,21,146,168,107,242,146,162,193,211,188,196,119,208,208,187,130,161,58,136,72,201,67,209,6,173,2,125,55,255,188,108,176,109,243,186,122,220,185,227,186,88,149,213,109,109,50,128,219,159,107,127,120,239,100,208,124,7,221,69,111,226,227,113,93,117,96,187,227,186,44,87,85,110,161,35,245,217,90,120,126,116,66,94,95,247,65,252,182,88,52,184,160,191,63,225,77,32,255,224,101,111,101,92,118,233,128,163,59,252,0,197,10,111,121,116,55,206,99,88,6,23,122,179,107,55,38,246,182,115,147,186,87,152,252,146,93,78,134,96,38,107,189,95,251,87,180,171,108,184,164,245,205,239,81,44,113,172,0,211,44,97,58,226,158,201,40,226,76,103,220,50,224,34,150,73,156,72,110,213,222,198,163,76,68,104,189,101,34,5,206,164,143,13,211,70,70,244,36,189,246,14,101,10,241,183,46,59,212,25,62,84,138,98,87,41,198,7,95,137,111,86,101,22,194,217,85,110,27,71,54,245,54,46,135,59,234,45,210,143,22,220,198,7,82,106,242,197,197,232,160,183,169,251,86,220,17,9,151,27,229,145,54,119,7,162,72,248,41,8,6,43,155,71,66,244,73,251,246,223,10,155,247,246,2,75,24,82,119,126,68,210,175,4,243,2,75,172,186,217,21,72,80,222,83,121,11,97,168,218,85,44,24,232,40,98,74,75,201,9,212,104,48,185,166,3,91,135,102,87,138,128,45,141,74,153,6,158,50,233,84,18,240,110,9,249,26,19,16,194,58,235,194,145,121,213,229,221,229,80,18,179,43,35,33,6,157,196,140,107,75,93,66,39,158,110,205,75,38,116,164,83,13,9,0,102,215,231,67,184,121,187,44,224,242,195,54,170,191,17,220,164,160,47,130,86,211,118,147,0,168,73,237,39,148,222,85,209,229,213,34,244,130,2,109,184,202,163,215,171,54,175,40,239,147,229,69,93,97,111,48,52,50,50,35,121,132,70,81,185,132,176,200,5,33,89,230,124,68,240,134,216,165,41,71,48,154,74,144,62,116,38,115,214,56,79,14,122,30,135,42,51,192,116,26,43,6,214,82,152,222,8,244,193,234,11,82,31,65,234,184,28,190,32,245,176,144,42,185,71,47,156,97,222,208,151,140,36,93,152,161,81,24,107,131,81,162,0,172,147,63,5,169,127,213,89,94,224,125,156,98,146,113,153,198,228,167,85,192,100,224,18,89,22,1,75,140,160,113,236,40,214,200,15,56,13,64,45,234,5,145,131,226,237,18,155,158,34,172,135,224,142,121,119,103,80,134,22,218,212,117,55,164,123,219,130,119,49,162,222,183,77,77,143,163,7,193,177,52,138,82,163,68,194,82,7,49,147,89,152,83,26,144,81,118,165,5,52,134,242,248,120,7,57,169,30,26,243,114,215,152,151,7,63,230,239,164,117,80,27,51,241,199,101,114,71,31,17,143,83,204,65,235,254,188,15,100,237,227,65,77,252,62,144,91,19,127,131,20,20,86,39,54,102,68,135,50,230,188,16,204,4,164,112,46,156,226,104,98,29,138,145,142,110,95,56,47,33,47,122,209,13,105,24,109,229,30,220,215,214,8,136,231,15,97,145,63,33,22,93,76,171,69,26,56,133,162,70,72,3,61,98,25,215,25,211,50,166,233,130,66,16,35,236,189,123,42,215,238,120,227,173,84,78,25,206,82,35,168,74,41,167,140,8,142,98,218,138,196,113,103,148,49,41,121,67,11,110,184,221,247,245,170,177,107,26,223,14,155,237,94,27,235,115,44,162,63,113,183,252,122,97,219,107,17,219,107,193,122,134,181,233,123,55,161,157,107,200,152,38,243,178,48,28,242,194,240,82,121,135,189,170,190,16,224,123,67,247,251,248,236,51,80,213,31,96,159,15,144,191,125,250,172,184,77,211,198,18,171,255,147,60,61,41,23,186,158,94,127,1,116,41,210,195,225,23,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,75,76,53,72,53,49,77,78,212,77,54,177,52,213,53,73,75,53,215,77,52,182,76,209,53,78,76,50,55,50,183,72,53,52,51,52,7,0,106,93,85,138,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeLeadContactPhoneFlowElement

		/// <exclude/>
		public class ChangeLeadContactPhoneFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactPhoneFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactPhone";
				IsLogging = true;
				SchemaElementUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,201,110,219,48,16,253,23,157,195,64,251,226,91,145,184,133,129,162,9,16,35,151,42,135,17,57,178,137,106,3,73,165,117,13,255,123,135,146,172,58,133,139,56,189,52,186,136,124,120,124,243,102,219,59,188,2,173,191,64,141,206,194,89,163,82,160,219,210,92,127,148,149,65,245,73,181,125,231,92,57,26,149,132,74,254,68,49,226,75,33,205,45,24,160,39,251,252,183,66,238,44,242,243,26,185,115,149,59,210,96,173,137,99,159,196,145,231,122,62,176,212,19,30,11,11,225,179,12,51,186,38,73,32,66,17,103,5,240,137,249,23,241,155,182,238,64,225,24,99,144,47,135,227,122,215,89,170,71,0,31,40,82,183,205,4,6,214,132,94,54,80,84,40,232,110,84,143,4,25,37,107,202,6,215,178,198,123,80,20,203,234,180,22,34,82,9,149,182,172,10,75,179,252,209,41,212,90,182,205,107,230,170,190,110,78,217,36,128,243,117,178,227,14,30,45,243,30,204,118,144,88,145,173,195,224,242,195,102,163,112,3,70,62,159,154,248,134,187,129,119,89,253,232,129,160,46,61,66,213,227,73,204,151,153,220,64,103,198,132,198,240,68,80,114,179,189,56,215,185,98,175,165,235,19,216,29,201,23,106,158,205,193,143,9,124,182,192,168,114,60,230,206,215,149,190,251,222,160,122,224,91,172,97,172,218,211,53,161,127,0,179,254,98,239,5,174,91,68,1,50,63,139,57,11,211,40,101,105,16,167,44,204,2,16,220,143,32,9,249,225,105,244,33,117,87,193,238,113,14,247,25,65,76,37,179,63,66,162,52,46,56,61,97,158,8,168,47,165,40,24,32,38,204,23,158,23,150,73,192,253,172,164,14,219,207,54,162,221,72,14,213,93,135,138,26,61,20,218,61,63,162,47,102,219,166,175,218,214,140,73,205,229,179,110,6,47,199,33,9,120,81,184,65,20,49,72,252,132,133,130,39,140,50,141,89,20,69,224,122,177,64,20,118,220,104,191,109,133,31,218,94,241,105,159,244,184,216,255,180,176,255,97,13,223,178,89,103,103,251,146,89,125,47,83,184,122,47,147,118,112,14,191,0,8,233,7,64,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,114,155,48,16,253,21,70,201,209,242,0,18,66,226,154,164,51,158,73,218,76,146,230,18,251,176,146,86,9,51,24,60,32,183,227,50,252,123,5,182,147,216,109,79,213,1,208,106,223,219,221,199,83,79,46,253,110,131,164,32,79,216,182,208,53,206,207,175,154,22,231,247,109,99,176,235,230,183,141,129,170,252,5,186,194,123,104,97,141,30,219,103,168,182,216,221,150,157,159,69,167,48,50,35,151,63,166,83,82,188,244,100,225,113,253,125,97,3,59,119,185,114,194,74,42,56,179,148,107,149,82,41,164,164,104,19,163,132,86,26,156,12,96,211,84,219,117,125,135,30,238,193,191,145,162,39,19,91,32,0,203,85,108,51,73,227,140,3,229,86,102,84,165,92,80,107,37,23,2,53,83,146,145,97,70,58,243,134,107,152,138,126,128,121,18,232,21,42,154,103,177,166,28,181,166,210,128,161,206,49,165,5,151,60,65,51,130,15,249,31,192,151,139,151,69,247,237,103,141,237,227,196,91,56,168,58,92,205,67,244,44,112,83,225,26,107,95,244,9,67,29,231,156,209,212,101,9,229,82,112,170,92,134,161,209,148,199,160,165,69,157,14,1,240,174,102,209,171,92,202,100,76,116,105,18,196,113,92,209,48,143,163,66,164,38,151,49,58,107,212,8,185,169,125,233,119,87,147,70,69,15,24,35,207,12,80,195,85,22,80,152,83,96,202,82,6,58,79,115,137,137,72,242,97,117,177,26,7,179,101,183,169,96,247,252,231,124,15,8,54,50,77,237,202,118,141,211,151,7,227,187,72,239,162,106,60,218,188,53,53,118,243,47,101,219,249,168,12,255,51,106,92,212,98,183,173,124,89,191,134,252,170,66,227,203,166,158,47,236,190,214,230,196,38,159,171,245,203,189,219,150,164,88,254,203,111,135,247,94,221,83,199,157,155,109,73,102,75,242,216,108,91,51,50,178,176,185,254,52,230,84,100,74,57,219,30,221,21,34,245,182,170,14,145,107,240,112,76,60,134,27,91,186,18,237,162,126,60,154,106,98,137,15,139,254,229,113,92,251,222,254,7,118,7,53,188,98,251,53,8,240,209,251,123,151,79,65,198,35,177,78,85,22,231,137,163,57,130,10,238,22,225,110,217,4,168,74,148,118,44,103,169,115,233,132,126,64,135,45,214,6,79,27,75,132,70,38,130,89,165,195,148,242,36,83,1,111,99,10,50,102,150,11,201,172,101,7,124,55,169,61,94,235,67,95,163,84,3,25,134,213,240,27,159,253,156,215,74,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactPhone.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)((process.AddContactByLead.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,111,218,64,16,253,47,62,103,35,179,31,198,230,86,37,180,66,170,154,72,65,185,212,57,140,189,99,88,213,198,214,238,146,150,34,254,123,103,109,160,164,162,10,233,165,241,197,246,211,219,55,111,102,223,108,163,178,6,231,190,64,131,209,36,154,163,181,224,218,202,95,127,52,181,71,251,201,182,235,46,186,138,28,90,3,181,249,137,122,192,167,218,248,91,240,64,71,182,249,111,133,60,154,228,231,53,242,232,42,143,140,199,198,17,135,142,84,99,40,132,230,138,65,146,112,38,49,25,51,40,17,216,40,137,185,146,124,44,5,20,3,243,111,226,55,109,211,129,197,161,70,47,95,245,159,243,77,23,168,35,2,202,158,98,92,187,218,131,34,152,112,211,21,20,53,106,250,247,118,141,4,121,107,26,234,6,231,166,193,123,176,84,43,232,180,1,34,82,5,181,11,172,26,43,63,253,209,89,116,206,180,171,215,204,213,235,102,117,202,38,1,60,254,238,237,196,189,199,192,188,7,191,236,37,102,100,107,215,187,252,176,88,88,92,128,55,207,167,38,190,225,166,231,93,54,63,58,160,233,150,30,161,94,227,73,205,151,157,220,64,231,135,134,134,242,68,176,102,177,188,184,215,227,196,94,107,151,19,216,29,200,23,106,158,237,129,39,4,62,7,96,80,57,124,230,209,215,153,187,251,190,66,251,80,46,177,129,97,106,79,215,132,254,1,28,245,39,219,145,136,227,66,9,100,60,75,74,38,83,149,178,84,36,41,147,153,0,93,114,5,99,89,238,158,6,31,198,117,53,108,30,143,229,62,35,232,253,200,194,139,144,2,20,168,76,22,76,101,149,98,82,165,25,43,228,136,212,170,52,86,177,4,17,171,112,195,225,9,23,209,46,76,9,245,93,135,150,46,186,31,116,124,62,162,47,178,29,218,183,109,235,135,166,142,227,11,110,122,47,135,144,104,89,232,120,204,5,83,149,210,20,18,160,184,240,76,48,174,5,86,58,205,148,148,193,12,237,119,152,240,67,187,182,229,126,159,220,176,216,255,180,176,255,97,13,223,178,89,103,179,125,73,86,223,75,10,103,239,37,105,187,104,247,11,5,14,193,196,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,203,110,219,48,16,252,21,129,201,209,52,40,241,33,81,183,34,233,193,64,210,6,117,146,75,236,195,146,92,54,2,244,8,40,185,69,106,232,223,75,203,118,28,167,237,169,60,72,218,229,206,236,112,53,220,146,203,225,245,5,73,73,238,49,4,232,59,63,204,175,186,128,243,187,208,89,236,251,249,77,103,161,174,126,129,169,241,14,2,52,56,96,120,132,122,131,253,77,213,15,179,228,28,70,102,228,242,199,180,75,202,167,45,89,12,216,60,44,92,100,87,50,83,78,230,154,114,233,44,21,40,44,5,76,61,101,220,243,204,74,147,59,41,34,216,118,245,166,105,111,113,128,59,24,158,73,185,37,19,91,36,0,39,52,115,178,160,76,10,160,194,21,146,234,76,40,234,92,33,148,66,195,117,193,201,56,35,189,125,198,6,166,166,39,176,72,193,23,26,53,205,37,51,177,187,49,180,176,96,169,247,92,27,37,10,145,162,221,129,15,245,39,224,211,197,211,162,255,250,179,197,176,156,120,75,15,117,143,235,121,204,126,72,124,174,177,193,118,40,183,187,86,44,115,154,106,159,113,42,50,166,168,209,22,227,113,153,97,76,50,7,26,199,8,120,155,102,185,205,115,40,152,151,138,10,163,24,21,133,177,212,96,150,83,212,202,123,39,172,149,218,140,235,139,245,78,162,171,250,151,26,94,31,255,84,250,201,185,100,211,218,174,245,85,104,208,37,241,107,0,59,36,6,250,24,117,109,82,35,184,164,106,125,23,26,24,170,174,157,95,5,132,33,238,5,180,93,112,201,194,237,91,188,156,253,231,247,77,182,171,189,93,86,164,92,253,203,48,135,247,126,60,231,150,249,232,150,21,153,173,200,178,219,4,187,99,228,49,184,126,119,186,169,201,84,242,33,60,218,35,102,218,77,93,31,50,215,48,192,177,240,152,238,92,229,43,116,139,118,121,116,197,196,194,14,139,254,229,113,92,123,109,255,3,187,133,22,190,99,248,18,7,112,210,254,166,242,62,142,241,72,108,50,45,89,30,111,67,142,160,163,61,85,70,11,151,2,213,169,54,158,231,60,243,62,155,208,223,208,99,192,214,226,185,176,84,25,228,74,166,180,240,152,81,145,74,29,241,142,209,232,42,238,132,42,184,115,252,128,239,167,105,239,238,229,65,215,110,84,35,25,199,245,248,27,101,185,213,237,11,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ReadLandingPageFlowElement

		/// <exclude/>
		public class ReadLandingPageFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLandingPageFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLandingPage";
				IsLogging = true;
				SchemaElementUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,21,67,231,48,208,147,162,124,43,82,39,8,80,52,65,19,164,135,58,135,21,185,84,136,234,5,138,78,235,26,254,247,46,37,199,77,10,163,113,123,105,129,234,32,72,131,217,225,236,139,155,64,214,48,12,239,161,193,96,30,220,162,181,48,116,218,157,158,155,218,161,189,176,221,170,15,78,130,1,173,129,218,124,67,53,225,11,101,220,91,112,64,33,155,229,15,133,101,48,95,30,214,88,6,39,203,192,56,108,6,226,80,8,104,153,149,82,32,139,85,166,88,170,242,152,65,153,23,44,147,37,34,134,161,46,35,175,246,11,241,179,174,233,193,226,116,198,40,175,199,207,219,117,239,169,17,1,114,164,152,161,107,119,96,226,77,12,139,22,202,26,21,253,59,187,66,130,156,53,13,101,131,183,166,193,107,176,116,150,215,233,60,68,36,13,245,224,89,53,106,183,248,218,91,28,6,211,181,175,153,171,87,77,251,156,77,2,184,255,221,217,9,71,143,158,121,13,238,97,148,184,36,91,219,209,229,155,170,178,88,129,51,143,207,77,124,198,245,200,59,174,126,20,160,168,75,119,80,175,240,217,153,47,51,57,131,222,77,9,77,199,19,193,154,234,225,232,92,247,21,123,45,221,152,192,254,137,124,164,230,193,28,98,78,224,163,7,38,149,167,207,101,240,233,114,184,250,210,162,189,145,15,216,192,84,181,251,83,66,127,2,22,53,54,216,186,249,6,82,224,90,135,146,69,81,161,89,202,147,136,129,136,99,198,69,154,134,57,23,88,96,182,165,128,189,161,249,134,203,66,164,5,207,153,128,48,167,210,243,140,1,106,201,210,72,96,6,81,36,149,84,62,100,209,58,227,214,211,36,204,55,69,34,10,21,139,130,241,68,112,150,10,10,40,74,149,177,88,102,34,143,147,36,230,60,222,222,79,233,154,161,175,97,125,183,207,234,3,130,154,213,244,162,141,178,131,155,249,61,154,117,122,70,229,93,213,206,180,213,140,166,168,70,233,219,120,250,14,90,229,161,30,170,105,2,124,79,73,68,71,33,231,146,35,211,97,137,44,205,19,206,132,202,35,150,71,24,150,121,201,49,209,156,102,207,63,126,68,186,202,72,168,175,122,180,52,130,227,8,132,135,151,231,197,214,249,198,216,174,115,83,185,247,141,189,64,234,9,109,147,250,136,229,121,103,155,209,215,211,40,83,85,128,39,58,99,200,195,144,42,35,67,6,146,154,33,194,20,133,206,34,137,60,35,99,116,11,249,57,184,233,86,86,238,182,126,152,174,159,63,186,86,254,194,101,241,59,251,127,112,3,143,217,168,255,108,87,46,255,197,225,222,6,219,239,65,118,3,35,87,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		public LeadManagementIdentification(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementIdentification";
			SchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_identificationPassed = () => { return (bool)(true); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementIdentification, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementIdentification, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid LeadId {
			get;
			set;
		}

		private Func<bool> _identificationPassed;
		public virtual bool IdentificationPassed {
			get {
				return (_identificationPassed ?? (_identificationPassed = () => false)).Invoke();
			}
			set {
				_identificationPassed = () => { return value; };
			}
		}

		private ProcessLeadIdentification _leadIdentification;
		public ProcessLeadIdentification LeadIdentification {
			get {
				return _leadIdentification ?? ((_leadIdentification) = new ProcessLeadIdentification(UserConnection, this));
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
					SchemaElementUId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _leadIsIdentified;
		public ProcessTerminateEvent LeadIsIdentified {
			get {
				return _leadIsIdentified ?? (_leadIsIdentified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "LeadIsIdentified",
					SchemaElementUId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveLeadHasCommunication;
		public ProcessExclusiveGateway ExclusiveLeadHasCommunication {
			get {
				return _exclusiveLeadHasCommunication ?? (_exclusiveLeadHasCommunication = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveLeadHasCommunication",
					SchemaElementUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveLeadHasCommunication.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _leadDisqualified;
		public ProcessTerminateEvent LeadDisqualified {
			get {
				return _leadDisqualified ?? (_leadDisqualified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "LeadDisqualified",
					SchemaElementUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ReadContactsByLeadCommunicationsFlowElement _readContactsByLeadCommunications;
		public ReadContactsByLeadCommunicationsFlowElement ReadContactsByLeadCommunications {
			get {
				return _readContactsByLeadCommunications ?? (_readContactsByLeadCommunications = new ReadContactsByLeadCommunicationsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactAllFlowElement _changeLeadContactAll;
		public ChangeLeadContactAllFlowElement ChangeLeadContactAll {
			get {
				return _changeLeadContactAll ?? (_changeLeadContactAll = new ChangeLeadContactAllFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactByLeadFlowElement _addContactByLead;
		public AddContactByLeadFlowElement AddContactByLead {
			get {
				return _addContactByLead ?? (_addContactByLead = new AddContactByLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactAdressFlowElement _addContactAdress;
		public AddContactAdressFlowElement AddContactAdress {
			get {
				return _addContactAdress ?? (_addContactAdress = new AddContactAdressFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactWebFlowElement _addContactWeb;
		public AddContactWebFlowElement AddContactWeb {
			get {
				return _addContactWeb ?? (_addContactWeb = new AddContactWebFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ParallelGatewayAddContactCommunicationFlowElement _parallelGatewayAddContactCommunication;
		public ParallelGatewayAddContactCommunicationFlowElement ParallelGatewayAddContactCommunication {
			get {
				return _parallelGatewayAddContactCommunication ?? ((_parallelGatewayAddContactCommunication) = new ParallelGatewayAddContactCommunicationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ParallelGateway1FlowElement _parallelGateway1;
		public ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadContactsByLeadEmailFlowElement _readContactsByLeadEmail;
		public ReadContactsByLeadEmailFlowElement ReadContactsByLeadEmail {
			get {
				return _readContactsByLeadEmail ?? (_readContactsByLeadEmail = new ReadContactsByLeadEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactEmailFlowElement _changeLeadContactEmail;
		public ChangeLeadContactEmailFlowElement ChangeLeadContactEmail {
			get {
				return _changeLeadContactEmail ?? (_changeLeadContactEmail = new ChangeLeadContactEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveInLeadCommunication;
		public ProcessExclusiveGateway ExclusiveInLeadCommunication {
			get {
				return _exclusiveInLeadCommunication ?? (_exclusiveInLeadCommunication = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveInLeadCommunication",
					SchemaElementUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveInLeadCommunication.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadContactsByLeadPhoneFlowElement _readContactsByLeadPhone;
		public ReadContactsByLeadPhoneFlowElement ReadContactsByLeadPhone {
			get {
				return _readContactsByLeadPhone ?? (_readContactsByLeadPhone = new ReadContactsByLeadPhoneFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactPhoneFlowElement _changeLeadContactPhone;
		public ChangeLeadContactPhoneFlowElement ChangeLeadContactPhone {
			get {
				return _changeLeadContactPhone ?? (_changeLeadContactPhone = new ChangeLeadContactPhoneFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayIsLeadSet;
		public ProcessExclusiveGateway ExclusiveGatewayIsLeadSet {
			get {
				return _exclusiveGatewayIsLeadSet ?? (_exclusiveGatewayIsLeadSet = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayIsLeadSet",
					SchemaElementUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayIsLeadSet.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _actionAfterIdentificationScriptTask;
		public ProcessScriptTask ActionAfterIdentificationScriptTask {
			get {
				return _actionAfterIdentificationScriptTask ?? (_actionAfterIdentificationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActionAfterIdentificationScriptTask",
					SchemaElementUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ActionAfterIdentificationScriptTaskExecute,
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
					SchemaElementUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
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

		private ReadLandingPageFlowElement _readLandingPage;
		public ReadLandingPageFlowElement ReadLandingPage {
			get {
				return _readLandingPage ?? (_readLandingPage = new ReadLandingPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessConditionalFlow _contactFoundAll;
		public ProcessConditionalFlow ContactFoundAll {
			get {
				return _contactFoundAll ?? (_contactFoundAll = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContactFoundAll",
					SchemaElementUId = new Guid("e86cf8b0-28a2-4a9b-b145-adf2cced025e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowCommunicationAll;
		public ProcessConditionalFlow ConditionalFlowCommunicationAll {
			get {
				return _conditionalFlowCommunicationAll ?? (_conditionalFlowCommunicationAll = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowCommunicationAll",
					SchemaElementUId = new Guid("146a48af-ec3c-47df-b53d-49db5dfca733"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowEmailOnly;
		public ProcessConditionalFlow ConditionalFlowEmailOnly {
			get {
				return _conditionalFlowEmailOnly ?? (_conditionalFlowEmailOnly = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowEmailOnly",
					SchemaElementUId = new Guid("94e08796-33d0-450f-a94d-43d4d8c7e5b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _contactFoundEmail;
		public ProcessConditionalFlow ContactFoundEmail {
			get {
				return _contactFoundEmail ?? (_contactFoundEmail = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContactFoundEmail",
					SchemaElementUId = new Guid("8ad3bb27-05b3-4197-85fe-9fca6ddb677c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowPhonesOnly;
		public ProcessConditionalFlow ConditionalFlowPhonesOnly {
			get {
				return _conditionalFlowPhonesOnly ?? (_conditionalFlowPhonesOnly = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowPhonesOnly",
					SchemaElementUId = new Guid("421b74c1-62c2-430b-965d-8d776c88a27f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _cntactFoundPhone;
		public ProcessConditionalFlow CntactFoundPhone {
			get {
				return _cntactFoundPhone ?? (_cntactFoundPhone = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "CntactFoundPhone",
					SchemaElementUId = new Guid("9bfd01fc-78f4-4b49-a5a3-0359fc93fab2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowLeadUndefined;
		public ProcessConditionalFlow ConditionalFlowLeadUndefined {
			get {
				return _conditionalFlowLeadUndefined ?? (_conditionalFlowLeadUndefined = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowLeadUndefined",
					SchemaElementUId = new Guid("86bf0460-da87-44e8-9e19-16d6bb74396c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _isNotFromLandingFlow;
		public ProcessConditionalFlow IsNotFromLandingFlow {
			get {
				return _isNotFromLandingFlow ?? (_isNotFromLandingFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsNotFromLandingFlow",
					SchemaElementUId = new Guid("b15dccc1-cb8b-4db6-9245-c999d8b93476"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _dontContactFlow;
		public ProcessConditionalFlow DontContactFlow {
			get {
				return _dontContactFlow ?? (_dontContactFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "DontContactFlow",
					SchemaElementUId = new Guid("6e54dca1-2410-4933-8d29-b9c06c6eb9c5"),
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
			FlowElements[LeadIsIdentified.SchemaElementUId] = new Collection<ProcessFlowElement> { LeadIsIdentified };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ExclusiveLeadHasCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveLeadHasCommunication };
			FlowElements[LeadDisqualified.SchemaElementUId] = new Collection<ProcessFlowElement> { LeadDisqualified };
			FlowElements[ReadContactsByLeadCommunications.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadCommunications };
			FlowElements[ChangeLeadContactAll.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactAll };
			FlowElements[AddContactByLead.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactByLead };
			FlowElements[AddContactAdress.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactAdress };
			FlowElements[AddContactWeb.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactWeb };
			FlowElements[ParallelGatewayAddContactCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGatewayAddContactCommunication };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[ReadContactsByLeadEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadEmail };
			FlowElements[ChangeLeadContactEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactEmail };
			FlowElements[ExclusiveInLeadCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveInLeadCommunication };
			FlowElements[ReadContactsByLeadPhone.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadPhone };
			FlowElements[ChangeLeadContactPhone.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactPhone };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[ActionAfterIdentificationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActionAfterIdentificationScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadLandingPage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLandingPage };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "LeadIsIdentified":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveLeadHasCommunication":
						if (ConditionalFlowCommunicationAllExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadCommunications", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowEmailOnlyExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadEmail", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowPhonesOnlyExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadPhone", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
						break;
					case "LeadDisqualified":
						CompleteProcess();
						break;
					case "ReadContactsByLeadCommunications":
						if (ContactFoundAllExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactAll", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadEmail", e.Context.SenderName));
						break;
					case "ChangeLeadContactAll":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "AddContactByLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGatewayAddContactCommunication", e.Context.SenderName));
						break;
					case "AddContactAdress":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "AddContactWeb":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "ParallelGatewayAddContactCommunication":
						if (ParallelGatewayAddContactCommunication.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactWeb", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactAdress", e.Context.SenderName));
						}
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						}
						break;
					case "ReadContactsByLeadEmail":
						if (ContactFoundEmailExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactEmail", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactByLead", e.Context.SenderName));
						break;
					case "ChangeLeadContactEmail":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ExclusiveInLeadCommunication":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActionAfterIdentificationScriptTask", e.Context.SenderName));
						break;
					case "ReadContactsByLeadPhone":
						if (CntactFoundPhoneExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactPhone", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactByLead", e.Context.SenderName));
						break;
					case "ChangeLeadContactPhone":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "ActionAfterIdentificationScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadIsIdentified", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (IsNotFromLandingFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLandingPage", e.Context.SenderName));
						break;
					case "ReadLandingPage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (DontContactFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveLeadHasCommunication", e.Context.SenderName));
						break;
			}
		}

		private bool ContactFoundAllExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadCommunications", "ContactFoundAll", "((ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowCommunicationAllExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowCommunicationAll", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) != String.Empty)", result);
			return result;
		}

		private bool ConditionalFlowEmailOnlyExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) == String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) == String.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowEmailOnly", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) == String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) == String.Empty", result);
			return result;
		}

		private bool ContactFoundEmailExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadEmail", "ContactFoundEmail", "((ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowPhonesOnlyExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) == String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowPhonesOnly", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) == String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) != String.Empty)", result);
			return result;
		}

		private bool CntactFoundPhoneExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadPhone", "CntactFoundPhone", "((ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsLeadSet", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool IsNotFromLandingFlowExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("WebForm").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("WebFormId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "IsNotFromLandingFlow", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"WebForm\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>(\"WebFormId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private bool DontContactFlowExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLandingPage.ResultEntity.IsColumnValueLoaded(ReadLandingPage.ResultEntity.Schema.Columns.GetByName("CreateContact").ColumnValueName) ? ReadLandingPage.ResultEntity.GetTypedColumnValue<bool>("CreateContact") : false)) == false);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "DontContactFlow", "((ReadLandingPage.ResultEntity.IsColumnValueLoaded(ReadLandingPage.ResultEntity.Schema.Columns.GetByName(\"CreateContact\").ColumnValueName) ? ReadLandingPage.ResultEntity.GetTypedColumnValue<bool>(\"CreateContact\") : false)) == false", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("IdentificationPassed")) {
				writer.WriteValue("IdentificationPassed", IdentificationPassed, false);
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
			MetaPathParameterValues.Add("1300b53e-296c-4858-8368-493adc25a74c", () => LeadId);
			MetaPathParameterValues.Add("27623c14-f1c7-4872-8f1c-45103cd82954", () => IdentificationPassed);
			MetaPathParameterValues.Add("f7cf3a22-2a33-428e-9e2b-5f3622d92f72", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("a01e5fd1-7cbb-4e06-9188-a9656c381385", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("4db6d4f9-57aa-44ef-8934-56b12a060e0e", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("dc3c82bb-8c59-485f-9376-5880ae2ce035", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("bcf6ac2d-9970-48a9-80e2-c7d41b6c0c2e", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("76636537-e5df-47a7-9eb6-124881330bf3", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("232523cc-cb63-410d-8f7c-58cdcf2ef818", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("6c984967-8a07-4d65-aefc-418e5a11cdcd", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("e3cd6198-af4e-409b-8ba3-0851372ea038", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("7e4ceefa-cd15-47a3-8a3b-c8ad4ed1ef7f", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("0a326237-a485-4b38-9337-3aa27272cdd9", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("f7b52dbf-c358-489e-bf2c-3c4ff7924a2c", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("dd6ab013-fc1e-4bc5-a25b-6855ace31f97", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("c6cfc815-55cb-4def-b83c-14b182d467ce", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("72ded882-b97d-4f56-91cb-1e6e212f4218", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("0a075eb5-bcac-445c-993d-bd329be8d6dc", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("17573208-3be8-4476-9823-f565b0714f28", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("807ae5d1-ceac-47d5-8eb5-4720a6cd38c0", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("5770885f-4a81-42ac-b246-d9db3aa13a28", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("b62c39d0-3349-4a21-9582-0f3e9fab1b13", () => ReadContactsByLeadCommunications.DataSourceFilters);
			MetaPathParameterValues.Add("15307ea3-405b-4286-937e-bbd0152634bb", () => ReadContactsByLeadCommunications.ResultType);
			MetaPathParameterValues.Add("b0de7902-f6c1-44eb-87ff-109bad0eb346", () => ReadContactsByLeadCommunications.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d29cd82a-8e0d-4086-8795-48b2899e16af", () => ReadContactsByLeadCommunications.NumberOfRecords);
			MetaPathParameterValues.Add("daf2cf98-3c7e-4055-b671-143255e4ffb9", () => ReadContactsByLeadCommunications.FunctionType);
			MetaPathParameterValues.Add("34ed4a32-1e5a-4623-ae6a-18a622bf6230", () => ReadContactsByLeadCommunications.AggregationColumnName);
			MetaPathParameterValues.Add("97666c94-b7fa-4cf1-858f-96a7f5e41511", () => ReadContactsByLeadCommunications.OrderInfo);
			MetaPathParameterValues.Add("10568b26-1c18-4f39-9578-4a72a1c5fb66", () => ReadContactsByLeadCommunications.ResultEntity);
			MetaPathParameterValues.Add("935c4f95-44b6-44e3-920e-5b06a85a9a77", () => ReadContactsByLeadCommunications.ResultCount);
			MetaPathParameterValues.Add("567adf56-c83c-4371-b0d7-e3c15c4a747e", () => ReadContactsByLeadCommunications.ResultIntegerFunction);
			MetaPathParameterValues.Add("7ad0d0ed-5315-4834-9632-bc717ea4b547", () => ReadContactsByLeadCommunications.ResultFloatFunction);
			MetaPathParameterValues.Add("06ba8c97-f038-45da-8d5c-e5fa72c64ac0", () => ReadContactsByLeadCommunications.ResultDateTimeFunction);
			MetaPathParameterValues.Add("085f20cb-53af-486b-a15f-5bc389f586df", () => ReadContactsByLeadCommunications.ResultRowsCount);
			MetaPathParameterValues.Add("7b7d4ca0-20b2-450c-a302-c217ce695e2c", () => ReadContactsByLeadCommunications.CanReadUncommitedData);
			MetaPathParameterValues.Add("316aa43c-1aa6-47f1-aaf7-572b6f838fcf", () => ReadContactsByLeadCommunications.ResultEntityCollection);
			MetaPathParameterValues.Add("2cc24615-28c1-4668-8f49-c93ae2c5896a", () => ReadContactsByLeadCommunications.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b4d0581e-c249-4b18-a38c-f40592d4085d", () => ReadContactsByLeadCommunications.IgnoreDisplayValues);
			MetaPathParameterValues.Add("2729cf7a-36f6-4003-b06a-e8cb957b2269", () => ReadContactsByLeadCommunications.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f215686f-4d81-4543-93aa-539f611453e4", () => ReadContactsByLeadCommunications.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9a626ad2-321e-427a-9f24-760d9280a022", () => ChangeLeadContactAll.EntitySchemaUId);
			MetaPathParameterValues.Add("564a7988-620b-401f-9bfc-8041ac06be95", () => ChangeLeadContactAll.IsMatchConditions);
			MetaPathParameterValues.Add("b7b1963b-962d-4921-a62e-3119d14d8a66", () => ChangeLeadContactAll.DataSourceFilters);
			MetaPathParameterValues.Add("5d16c9f4-5c23-4097-8d07-fac1cb716e39", () => ChangeLeadContactAll.RecordColumnValues);
			MetaPathParameterValues.Add("2c6aba36-8758-475f-ae50-d4a503c1975d", () => ChangeLeadContactAll.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("c43dec79-6b59-4fc6-94f0-bcc6a7f8c091", () => AddContactByLead.EntitySchemaId);
			MetaPathParameterValues.Add("61b7d5bc-8334-4d0a-8ec3-aac02f0f6b0d", () => AddContactByLead.DataSourceFilters);
			MetaPathParameterValues.Add("ec4e60e4-4bd2-476d-bfa5-f3879991dce5", () => AddContactByLead.RecordAddMode);
			MetaPathParameterValues.Add("fc9a7fd7-6ae6-4198-801f-ed65a0714560", () => AddContactByLead.FilterEntitySchemaId);
			MetaPathParameterValues.Add("0698fbce-2359-4022-88df-2b5fa4260af7", () => AddContactByLead.RecordDefValues);
			MetaPathParameterValues.Add("77a80f56-4b60-48bc-be27-e96ffd4cc59b", () => AddContactByLead.RecordId);
			MetaPathParameterValues.Add("bd8bab91-7c9c-4f46-a8ee-de69c8479c49", () => AddContactByLead.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("5a0a517a-3cd6-4838-89ed-dd198ad96f83", () => AddContactAdress.EntitySchemaId);
			MetaPathParameterValues.Add("dcf0939b-5ae1-4506-a7a2-453c0eb2f2d8", () => AddContactAdress.DataSourceFilters);
			MetaPathParameterValues.Add("55cf3377-2bf5-4a73-8eb5-34e7b911258b", () => AddContactAdress.RecordAddMode);
			MetaPathParameterValues.Add("6d55db5f-8e6c-420b-9a07-be564e8b90da", () => AddContactAdress.FilterEntitySchemaId);
			MetaPathParameterValues.Add("6aa29df7-9dcf-4eea-b7dd-70cbb55c6070", () => AddContactAdress.RecordDefValues);
			MetaPathParameterValues.Add("b9f11eba-9282-49e7-842b-28c1d0f2190f", () => AddContactAdress.RecordId);
			MetaPathParameterValues.Add("03d86494-8865-4f33-baa9-734e477aa2f5", () => AddContactAdress.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("97a7e2ca-58ad-4a27-8a87-3f50772b77be", () => AddContactWeb.EntitySchemaId);
			MetaPathParameterValues.Add("2f713b4e-bdb9-470a-b959-23af1cb99aaa", () => AddContactWeb.DataSourceFilters);
			MetaPathParameterValues.Add("9021827f-1e50-40f2-8b7f-ec1b0e056ccb", () => AddContactWeb.RecordAddMode);
			MetaPathParameterValues.Add("aa2e3f7d-4042-4910-b0eb-0f5b57896d58", () => AddContactWeb.FilterEntitySchemaId);
			MetaPathParameterValues.Add("7a98d7a0-39d9-4231-b19a-9c603fa6baf0", () => AddContactWeb.RecordDefValues);
			MetaPathParameterValues.Add("89ff5387-057a-41f9-a2cd-98c33da073a9", () => AddContactWeb.RecordId);
			MetaPathParameterValues.Add("bc163fe7-1547-4a7a-9a04-4e4956124bae", () => AddContactWeb.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("d6514abc-f96a-4d19-b5f8-f55b1ac00b83", () => ReadContactsByLeadEmail.DataSourceFilters);
			MetaPathParameterValues.Add("881a211c-0037-4de8-9966-fd5b76082530", () => ReadContactsByLeadEmail.ResultType);
			MetaPathParameterValues.Add("1b0558b6-d02e-43db-a632-da912ff74169", () => ReadContactsByLeadEmail.ReadSomeTopRecords);
			MetaPathParameterValues.Add("38ac0d8a-57fb-4d3c-a724-83243171725c", () => ReadContactsByLeadEmail.NumberOfRecords);
			MetaPathParameterValues.Add("2306c9f4-91b3-4ae6-9d0d-b85b15f043a5", () => ReadContactsByLeadEmail.FunctionType);
			MetaPathParameterValues.Add("91e3ad56-02d2-495e-8f8d-6839c1e13901", () => ReadContactsByLeadEmail.AggregationColumnName);
			MetaPathParameterValues.Add("09b2ffa0-b537-4970-bb51-a8da7fb89215", () => ReadContactsByLeadEmail.OrderInfo);
			MetaPathParameterValues.Add("4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee", () => ReadContactsByLeadEmail.ResultEntity);
			MetaPathParameterValues.Add("f289649e-c0c3-403b-8124-ffe171aafe33", () => ReadContactsByLeadEmail.ResultCount);
			MetaPathParameterValues.Add("e7d2a1ae-2033-4d71-9990-c4c12f4faa89", () => ReadContactsByLeadEmail.ResultIntegerFunction);
			MetaPathParameterValues.Add("681c5445-3ca2-45de-bf7c-0f37318944d1", () => ReadContactsByLeadEmail.ResultFloatFunction);
			MetaPathParameterValues.Add("95b392b6-a727-407b-a3ec-157c1314469b", () => ReadContactsByLeadEmail.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0eadc500-3c91-49a1-8071-9d0668f51d38", () => ReadContactsByLeadEmail.ResultRowsCount);
			MetaPathParameterValues.Add("849f1602-4ec0-45ef-a640-370b4ec656e7", () => ReadContactsByLeadEmail.CanReadUncommitedData);
			MetaPathParameterValues.Add("847ce0c0-4e8f-4238-a637-16f20d906278", () => ReadContactsByLeadEmail.ResultEntityCollection);
			MetaPathParameterValues.Add("1cfe3a33-faaf-4cb5-b49e-d1eadaa81bec", () => ReadContactsByLeadEmail.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("f61ce3ad-7460-43d4-b04a-9a8735ba629d", () => ReadContactsByLeadEmail.IgnoreDisplayValues);
			MetaPathParameterValues.Add("98cf1789-f51a-4231-b152-7212be2cdca3", () => ReadContactsByLeadEmail.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1921c84b-08d6-4bab-b0f8-1e4173f757ea", () => ReadContactsByLeadEmail.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("788c3395-e8dc-443e-9c81-e57decd44c14", () => ChangeLeadContactEmail.EntitySchemaUId);
			MetaPathParameterValues.Add("40c79c51-5e3e-4a77-881f-bfb3b5148e9c", () => ChangeLeadContactEmail.IsMatchConditions);
			MetaPathParameterValues.Add("3da883c3-07af-4baf-9a48-e1f261dbd978", () => ChangeLeadContactEmail.DataSourceFilters);
			MetaPathParameterValues.Add("bec4aa50-4e70-47b5-99c8-d0f15b4b12f8", () => ChangeLeadContactEmail.RecordColumnValues);
			MetaPathParameterValues.Add("5211e1fa-3ffd-44d3-a820-58f034e21f3c", () => ChangeLeadContactEmail.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("55598db2-619f-4f92-a9b5-d03ddb173ed0", () => ReadContactsByLeadPhone.DataSourceFilters);
			MetaPathParameterValues.Add("519549f0-c248-40b5-be93-602f4ff55bac", () => ReadContactsByLeadPhone.ResultType);
			MetaPathParameterValues.Add("c1675f40-4a8b-469f-807f-482b441e6236", () => ReadContactsByLeadPhone.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8aacc82f-451e-44f0-a1ea-c48fac82b9aa", () => ReadContactsByLeadPhone.NumberOfRecords);
			MetaPathParameterValues.Add("1a7cefdb-8943-464e-9818-f056350796f1", () => ReadContactsByLeadPhone.FunctionType);
			MetaPathParameterValues.Add("a45be9e6-9a59-46ac-b1b7-9def07669d0c", () => ReadContactsByLeadPhone.AggregationColumnName);
			MetaPathParameterValues.Add("6b161822-7e93-4124-b2d6-c1605b5f5657", () => ReadContactsByLeadPhone.OrderInfo);
			MetaPathParameterValues.Add("97881864-f21d-4f49-b39f-662c780efdc9", () => ReadContactsByLeadPhone.ResultEntity);
			MetaPathParameterValues.Add("83016a9c-a67e-4328-a96e-bfacfc2c77c6", () => ReadContactsByLeadPhone.ResultCount);
			MetaPathParameterValues.Add("a0d9ba4a-555e-4324-ae31-f59d0233fbc6", () => ReadContactsByLeadPhone.ResultIntegerFunction);
			MetaPathParameterValues.Add("5b48e127-d50b-49a3-8459-4a9a52bf6988", () => ReadContactsByLeadPhone.ResultFloatFunction);
			MetaPathParameterValues.Add("6ef7572f-4836-4cfe-ad97-3868281a4281", () => ReadContactsByLeadPhone.ResultDateTimeFunction);
			MetaPathParameterValues.Add("ce2e72d3-d7a5-4f50-9ecf-44b4bf27b6ea", () => ReadContactsByLeadPhone.ResultRowsCount);
			MetaPathParameterValues.Add("98faeefc-cf3f-4be3-a9b9-40bd344629d3", () => ReadContactsByLeadPhone.CanReadUncommitedData);
			MetaPathParameterValues.Add("e75f4ff2-ebaa-43f4-aff7-36f8fa2f00cd", () => ReadContactsByLeadPhone.ResultEntityCollection);
			MetaPathParameterValues.Add("1a5f9685-0340-43a4-85bd-917ac7f8b75a", () => ReadContactsByLeadPhone.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4a757dc8-11a2-46d0-962c-01dc9f7cf05c", () => ReadContactsByLeadPhone.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d1a04b45-329c-4e0c-90b8-b7463582c944", () => ReadContactsByLeadPhone.ResultCompositeObjectList);
			MetaPathParameterValues.Add("822209b4-c7f7-4d36-9ddf-32a904b93bda", () => ReadContactsByLeadPhone.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("cfc1a8ae-2a77-49bb-a728-a1637ee8c94a", () => ChangeLeadContactPhone.EntitySchemaUId);
			MetaPathParameterValues.Add("5feb2bce-5433-4c25-a83d-3f8d28ccc8ab", () => ChangeLeadContactPhone.IsMatchConditions);
			MetaPathParameterValues.Add("9acd36f8-ce89-4f92-bdb8-e4eea778daf4", () => ChangeLeadContactPhone.DataSourceFilters);
			MetaPathParameterValues.Add("15555f52-d536-4815-a506-977a98d2f0f3", () => ChangeLeadContactPhone.RecordColumnValues);
			MetaPathParameterValues.Add("99d9c01e-8ac9-41e6-a4ee-12e2c816886a", () => ChangeLeadContactPhone.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("3719e46d-8e08-48ad-8083-1ccf953996c6", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("08550f59-4992-48fb-b252-df02ec268766", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("44584732-acad-4754-bde4-a1b1cfd19199", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("33aca163-6ecf-4e71-9484-09432fbc4746", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("cb50f943-4702-4fd8-9aa9-5698a33e9475", () => ChangeDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("cd3fabe0-1945-4d5e-9fb8-9e85ee54cc3b", () => ReadLandingPage.DataSourceFilters);
			MetaPathParameterValues.Add("c84ed90e-913c-4d79-be6e-0aeb6dbde695", () => ReadLandingPage.ResultType);
			MetaPathParameterValues.Add("528b68b1-c488-499b-b6a9-98d627973317", () => ReadLandingPage.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7db9bc2b-3431-4feb-8af1-b2fcbc5cf552", () => ReadLandingPage.NumberOfRecords);
			MetaPathParameterValues.Add("50c50a69-929a-4ae1-8501-1657483ac91c", () => ReadLandingPage.FunctionType);
			MetaPathParameterValues.Add("5a09f02d-d645-448c-a427-3dc0ad363ad0", () => ReadLandingPage.AggregationColumnName);
			MetaPathParameterValues.Add("2793b917-606e-429f-8d6b-56caf9a5d36b", () => ReadLandingPage.OrderInfo);
			MetaPathParameterValues.Add("a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76", () => ReadLandingPage.ResultEntity);
			MetaPathParameterValues.Add("e0010511-9818-4608-8cc6-966c057c7fb7", () => ReadLandingPage.ResultCount);
			MetaPathParameterValues.Add("5ce1ad73-33d5-4d54-99dc-103fe2185918", () => ReadLandingPage.ResultIntegerFunction);
			MetaPathParameterValues.Add("f1d51e05-81e8-439e-be55-ef17ce69d451", () => ReadLandingPage.ResultFloatFunction);
			MetaPathParameterValues.Add("5400d0e0-9171-4da4-9833-ee4bc440d882", () => ReadLandingPage.ResultDateTimeFunction);
			MetaPathParameterValues.Add("fe6f5c9f-37df-4b0d-b855-65847152e915", () => ReadLandingPage.ResultRowsCount);
			MetaPathParameterValues.Add("ec12f3b9-746c-4f92-ba49-ce658079412a", () => ReadLandingPage.CanReadUncommitedData);
			MetaPathParameterValues.Add("6dc416c9-504c-4429-b04e-93f543f173c4", () => ReadLandingPage.ResultEntityCollection);
			MetaPathParameterValues.Add("b66e4485-d571-44cb-9e32-b832c83541ca", () => ReadLandingPage.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("1c52f53d-1e03-445c-bcbe-0982a59c336a", () => ReadLandingPage.IgnoreDisplayValues);
			MetaPathParameterValues.Add("aadf92c2-302e-499d-a17e-33c74ef006bd", () => ReadLandingPage.ResultCompositeObjectList);
			MetaPathParameterValues.Add("b3f6ea08-bb3d-48ff-bb96-9f7e3530b585", () => ReadLandingPage.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "IdentificationPassed":
					if (!hasValueToRead) break;
					IdentificationPassed = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ActionAfterIdentificationScriptTaskExecute(ProcessExecutingContext context) {
			ActionAfterIdentification();
			return true;
		}

			
			public virtual void ActionAfterIdentification() {
				string applicationUrl = string.Empty;
				if (Terrasoft.Web.Http.Abstractions.HttpContext.Current != null) {
					applicationUrl = Terrasoft.Web.Common.WebUtilities.GetParentApplicationUrl(Terrasoft.Web.Http.Abstractions.HttpContext.Current.Request);
				}
				var leadQualificationHelper = ClassFactory.Get<LeadQualificationHelper>(new ConstructorArgument[]{
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("applicationUrl", applicationUrl)
				});
				leadQualificationHelper.ActionAfterIdentification(LeadId);
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
			var cloneItem = (LeadManagementIdentification)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

