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

	#region Class: LeadAutoToEndStateSchema

	/// <exclude/>
	public class LeadAutoToEndStateSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadAutoToEndStateSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadAutoToEndStateSchema(LeadAutoToEndStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadAutoToEndState";
			UId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386");
			CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"LeadManagement";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386");
			Version = 0;
			PackageUId = new Guid("72dfd004-1fad-41fa-ad05-3cbc97f2958e");
			UseSystemSecurityContext = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2555d5e5-9d69-46c1-901f-ed528bffbcdc"),
				ContainerUId = new Guid("0633146f-9541-4c90-8494-6facae83a817"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0633146f-9541-4c90-8494-6facae83a817"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
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
				UId = new Guid("fb76d37f-4030-42f0-b828-cbb1a4b381aa"),
				ContainerUId = new Guid("0633146f-9541-4c90-8494-6facae83a817"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0633146f-9541-4c90-8494-6facae83a817"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c674161d-9746-4a42-af2f-efe9123f908d"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,19,49,20,253,21,52,235,186,154,25,207,51,59,84,2,234,134,86,180,234,134,116,225,216,215,169,197,188,100,59,133,18,69,2,190,160,233,119,176,96,129,120,74,44,26,245,71,250,37,92,207,164,33,69,65,13,108,16,18,35,121,102,124,116,124,124,238,245,189,158,120,188,96,198,60,102,37,120,61,239,16,180,102,166,150,118,251,161,42,44,232,71,186,30,55,222,150,103,64,43,86,168,151,32,58,188,47,148,125,192,44,195,37,147,193,15,133,129,215,27,172,215,24,120,91,3,79,89,40,13,114,112,137,20,34,72,242,44,39,81,42,125,18,1,15,8,203,194,152,80,42,169,160,60,204,50,234,119,204,95,137,239,212,101,195,52,116,123,180,242,178,253,61,60,107,28,53,64,128,183,20,101,234,106,1,82,103,194,244,43,54,44,64,224,220,234,49,32,100,181,42,49,26,56,84,37,236,51,141,123,57,157,218,65,72,146,172,48,142,85,128,180,253,23,141,6,99,84,93,221,101,174,24,151,213,42,27,5,96,57,93,216,241,91,143,142,185,207,236,73,43,177,139,182,166,173,203,251,163,145,134,17,179,234,116,213,196,51,56,107,121,155,229,15,23,8,60,165,35,86,140,97,101,207,219,145,236,176,198,118,1,117,219,35,65,171,209,201,198,177,46,51,118,87,184,33,130,205,13,121,67,205,181,49,132,9,130,167,14,232,84,110,126,7,222,211,93,179,247,188,2,125,192,79,160,100,93,214,142,183,17,253,9,232,23,80,66,101,123,19,63,161,52,136,18,73,242,56,10,72,196,115,159,100,81,30,145,68,50,206,32,163,44,11,210,41,46,88,26,234,77,194,56,142,69,12,49,201,69,130,249,79,48,245,185,31,72,2,34,14,179,161,148,67,46,248,244,184,51,174,76,83,176,179,163,165,191,249,249,213,167,249,236,250,205,219,249,249,229,55,28,239,113,188,195,241,193,125,239,225,235,227,2,248,210,177,102,215,175,62,227,236,107,139,206,46,95,207,103,87,23,219,79,128,215,90,44,142,202,125,80,56,78,83,26,197,52,39,44,73,37,137,36,119,113,164,64,88,158,242,48,201,253,72,176,16,43,203,61,174,0,234,145,226,172,216,107,64,99,129,181,7,236,175,111,141,91,61,229,210,174,235,218,118,201,92,30,219,94,211,212,218,142,43,101,177,54,87,106,52,75,56,196,67,17,145,56,201,40,230,54,2,50,20,62,22,106,32,168,47,131,208,79,37,67,79,120,189,184,3,62,168,199,154,47,218,217,116,247,202,31,221,23,127,225,22,248,157,198,94,219,90,155,180,202,255,38,152,255,51,77,48,245,166,223,1,186,144,37,32,88,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e022789-4e9c-4ca9-a63a-bafe8b45d27a"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("891c2114-c8fc-465d-b1f5-f5278d3afcf2"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8c3887c-acc7-4db4-a068-a6c9b5095c6f"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0d2e4df5-ebbe-4435-8f78-c990952374df"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d5c75813-9a69-4394-aa21-757ee0a79c85"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a96c175-f201-4971-a84c-667bf1d98abb"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("d3d56bf1-777a-4bc7-aa00-24988a0b714f"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e30322a-5528-4686-8289-0dd270a0747e"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				UId = new Guid("0515d8e0-89b7-4b5f-86f2-57c17fa5c211"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				UId = new Guid("a43a1cf1-ff6b-4013-8469-b230f95aeed3"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				UId = new Guid("15f88c4d-b432-4552-a155-90b07e7d0e80"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				UId = new Guid("7acadd53-ed9a-430e-92da-737ed1810ea7"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				UId = new Guid("6f8ca22a-b3a4-47eb-9ec6-08f559063864"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("c9b43dca-27ca-4615-a3d9-6b0896d38d91"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a6b199bd-b0af-4235-9fd8-d432bef1342d"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,183,52,79,76,54,54,53,210,53,177,52,183,212,53,73,49,178,208,181,52,48,75,211,181,48,74,75,77,50,75,73,74,182,76,73,6,0,174,79,115,201,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c0fb151-9665-481d-a943-69460316e837"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				UId = new Guid("d67c45a7-4e2e-4914-827d-b010d9f2e469"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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
				UId = new Guid("8b00b79c-2e00-4753-b346-abc376fc2fa3"),
				ContainerUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
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

		protected virtual void InitializeUserQuestionUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var branchingDecisionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("23470eda-fd4a-4dcb-a26f-6eb160c6b305"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"BranchingDecisions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableParameterValuesListDataValueType")
			};
			branchingDecisionsParameter.SourceValue = new ProcessSchemaParameterValue(branchingDecisionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,141,143,65,107,194,64,16,133,255,74,89,60,102,100,99,102,179,187,94,149,130,32,226,161,45,148,210,195,236,238,44,13,141,141,100,99,161,74,254,123,99,14,69,161,180,222,6,222,124,143,247,157,196,164,251,218,179,152,139,7,110,91,74,77,236,166,139,166,229,233,182,109,60,167,52,93,55,158,234,234,72,174,230,45,181,180,227,142,219,39,170,15,156,214,85,234,178,187,107,76,100,98,242,57,166,98,254,114,18,171,142,119,143,171,48,180,75,99,109,148,214,129,215,104,0,35,205,192,177,183,160,77,32,73,132,17,77,62,192,231,223,147,24,27,6,136,52,98,80,136,192,74,6,64,165,61,144,52,4,222,72,89,6,68,157,23,36,250,76,108,134,89,151,220,146,125,149,170,230,67,158,195,5,237,187,225,62,231,85,90,251,227,56,94,204,187,246,192,217,15,241,60,12,30,126,151,28,23,111,236,223,249,106,198,61,213,137,69,223,103,151,66,209,105,233,10,229,32,151,146,1,13,107,48,28,10,80,126,134,222,21,186,40,213,47,66,5,250,178,156,5,144,88,90,64,180,10,92,105,35,20,146,163,212,202,26,133,249,95,66,99,120,147,208,166,249,223,231,181,255,6,94,131,45,57,254,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(branchingDecisionsParameter);
			var resultDecisionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17cd0f5c-25fe-42a4-99da-d593c8a0a37f"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ResultDecisions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			resultDecisionsParameter.SourceValue = new ProcessSchemaParameterValue(resultDecisionsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDecisionsParameter);
			var decisionModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fb9218e3-edba-4d6d-9f82-2f0ad13153dd"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"DecisionMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			decisionModeParameter.SourceValue = new ProcessSchemaParameterValue(decisionModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(decisionModeParameter);
			var isDecisionRequiredParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("711528bb-6676-488b-8c54-79154028c8f1"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"IsDecisionRequired",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isDecisionRequiredParameter.SourceValue = new ProcessSchemaParameterValue(isDecisionRequiredParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(isDecisionRequiredParameter);
			var questionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4ef48da-4ee6-4ee6-ba67-0f5dd93a47cd"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Question",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			questionParameter.SourceValue = new ProcessSchemaParameterValue(questionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"""Is lead need fulfilled by opportunity"" + [#[IsOwnerSchema:false].[IsSchema:false].[Element:{b83c62d8-6c83-4638-8270-2aa30715adc3}].[Parameter:{d3d56bf1-777a-4bc7-aa00-24988a0b714f}].[EntityColumn:{790563cf-fd14-4d5d-a5fd-b6eddb10d6d3}]#] +""?""",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(questionParameter);
			var windowCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0849dedf-33cf-448d-87ad-a9ba022daa4a"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			windowCaptionParameter.SourceValue = new ProcessSchemaParameterValue(windowCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Answer selection page for item &quot;Is lead need fulfilled?&quot;",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(windowCaptionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3db58c3f-22ba-40b8-b71d-4b8bcd16a115"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Is lead need fulfilled?",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("fad75be7-0f8a-4872-967c-7d2c62690303"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("22a1d630-b988-4a27-b8ff-6fd69dca7b08"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("11afda49-35e6-4c12-9ea2-96db901da46b"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9c63a071-4375-4cdc-9829-9904f26e6585"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("588fd741-5860-4c73-8326-9fff706860b8"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("29355950-5494-47a3-b730-2dca6b41b7d3"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0c7abe8-1b56-4322-a1af-34567e8ee6c0"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("10e64984-20e7-4e23-b0a7-b1d11798514c"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a6270bb2-5dac-4ad4-b8bc-207c2b3dce6b"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d251a59-539c-46e1-8fbc-7d54869ffe8f"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("1e3036be-34b9-4a4a-85ec-999e85694aba"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("693953dc-26bc-4cc8-893c-50df8cbfa540"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("2edcfe17-f472-4a05-911e-ff5f6158c136"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("6560a60a-c2f8-4a12-8405-2ed91eed8bf0"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d553a0ac-618b-4bef-bfee-e24778fcd6ad"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("65175ba0-3b99-41ba-8e49-8f54e6f87036"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7b349c4c-8ceb-41b3-9e56-cbee348bc604"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("98189f43-a322-4b76-a3a9-14c369544dee"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc28920d-a411-4c17-85ca-e6461f60c921"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7b906324-fffe-4806-a5bc-9c1e52e06325"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a929915e-60ad-42c2-9a7c-93301d1da38a"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad6124ce-5389-44e0-a050-e08ee0924021"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc996c5b-31fa-4a91-aeb2-7031c3994ca5"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f0d536d-6d1d-4845-9703-1adeb8576fd9"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("59fbf60e-8f41-448a-8616-849f39991f00"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("56c34026-9ed0-4dcb-b716-886b7c4b2b09"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e04571cf-6c74-4140-b50b-a9ea256bd366"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("27c89055-6026-4244-8ff4-093dfc05c28c"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9d05259-826b-43fc-bddb-d0915320cac5"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("670d3618-61ea-44bb-bdc7-c282f5c9882a"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7140ffaf-6034-4859-adb2-33eb5086764b"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("07899f83-a011-4912-99f0-cf24347c6ba4"),
				ContainerUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
		}

		protected virtual void InitializeChangeDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("a904d73f-a09c-44a8-878a-a19fc5c41658"),
				ContainerUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c2bfccf-ed5e-4d79-9cc8-06c7445de2ab"),
				ContainerUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("adbba650-d377-41d5-a69f-514e3c05c2a6"),
				ContainerUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,73,110,212,64,20,189,10,242,58,21,121,42,15,189,67,161,65,145,16,137,72,196,38,206,226,187,252,171,83,194,147,202,213,129,166,101,9,56,65,58,231,96,193,2,49,74,44,210,202,69,114,18,170,236,78,211,9,153,148,13,66,98,81,30,158,222,127,245,231,169,197,114,104,154,103,80,160,53,176,118,81,74,104,42,174,214,31,139,92,161,124,34,171,113,109,173,89,13,74,1,185,120,131,89,143,15,51,161,30,129,2,109,50,77,126,43,36,214,32,185,90,35,177,214,18,75,40,44,26,205,209,38,158,71,3,224,52,34,153,27,82,226,71,94,74,98,238,1,9,168,157,58,16,57,60,142,178,158,121,157,248,102,217,203,119,202,188,251,220,157,212,134,229,107,128,85,69,13,82,52,85,185,0,61,115,127,51,44,33,205,209,40,43,57,70,13,41,41,10,29,8,238,138,2,183,65,234,107,140,78,101,32,77,226,144,55,134,149,35,87,195,215,181,196,166,17,85,121,179,95,27,85,62,46,202,85,182,22,192,229,239,194,29,187,243,209,48,183,65,29,116,18,91,117,93,73,53,46,133,154,36,86,219,185,251,112,52,146,56,2,37,14,87,189,121,137,147,206,224,110,57,212,6,153,174,212,11,200,199,184,184,220,177,255,136,105,3,106,213,135,150,88,243,163,211,175,243,217,217,251,15,243,163,147,159,250,124,210,231,163,62,159,205,187,19,148,200,81,98,201,112,135,29,96,1,203,44,92,8,193,240,196,232,96,229,18,83,251,189,27,82,183,44,192,109,217,115,53,88,159,147,111,46,199,82,243,202,76,184,129,6,15,13,208,171,156,127,38,214,222,102,179,245,170,68,217,71,216,231,126,127,93,163,151,128,97,142,5,150,106,48,181,3,207,115,252,128,147,152,250,14,241,89,108,147,200,143,125,18,112,96,128,145,167,11,18,182,218,96,233,208,96,234,82,74,51,138,148,196,89,16,19,63,96,14,137,109,135,19,204,168,27,165,156,167,44,99,237,126,239,184,104,234,28,38,157,239,183,23,233,129,126,124,89,0,223,123,214,236,236,237,55,253,247,163,67,103,39,239,230,179,211,227,245,231,200,42,153,109,246,93,98,94,90,56,8,60,159,135,105,68,156,136,102,196,143,237,128,128,135,46,73,195,56,181,253,152,135,52,140,117,127,182,237,126,107,154,52,175,70,130,65,190,85,163,132,69,7,217,87,143,218,133,25,53,121,151,85,165,46,53,208,83,132,222,153,243,30,207,60,23,89,168,219,155,2,229,58,171,97,72,34,198,92,2,145,111,115,7,60,207,3,227,141,94,81,166,180,59,213,88,50,236,247,66,211,239,166,123,237,156,191,176,78,238,181,33,174,153,175,187,204,203,255,73,152,255,3,147,208,90,237,47,87,60,214,218,161,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bec87d14-9ecd-40b3-a7ce-6925d9200e60"),
				ContainerUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,203,110,219,48,16,252,149,128,201,209,43,144,226,67,162,175,205,197,128,83,24,117,154,75,156,195,146,92,54,66,101,203,144,228,2,169,225,127,175,164,72,113,28,52,64,129,242,32,129,43,206,236,104,102,121,100,55,237,203,158,216,156,221,83,93,99,83,197,54,249,82,213,148,172,234,202,83,211,36,203,202,99,89,252,70,87,210,10,107,220,82,75,245,3,150,7,106,150,69,211,206,174,46,97,108,198,110,126,13,95,217,252,241,200,22,45,109,191,47,66,199,158,201,84,155,204,32,72,238,34,40,109,34,56,71,28,108,8,90,103,33,117,232,123,176,175,202,195,118,119,71,45,174,176,125,102,243,35,27,216,58,2,231,185,79,131,225,160,81,6,80,185,226,128,168,8,188,225,132,89,102,40,229,134,157,102,172,241,207,180,197,161,233,25,172,4,198,220,146,133,76,115,7,138,156,131,220,163,135,24,165,117,166,35,19,228,123,240,120,254,12,124,188,94,86,213,207,195,62,73,83,169,132,15,2,180,147,18,148,239,218,91,46,4,152,152,25,43,41,26,82,42,225,200,115,158,123,13,90,9,13,74,68,14,142,80,130,16,185,247,146,231,214,106,123,253,212,55,10,69,179,47,241,229,225,211,126,75,194,112,213,180,248,131,146,53,182,69,19,11,10,175,208,253,69,10,239,193,199,205,107,152,27,54,223,124,22,231,248,94,15,46,93,6,250,49,203,13,155,109,216,186,58,212,190,103,148,221,230,246,157,234,161,201,112,228,195,118,10,175,171,236,14,101,57,86,110,177,197,233,224,84,174,66,209,255,214,98,183,158,50,27,88,248,184,224,47,143,105,189,106,251,31,216,29,238,58,115,235,175,157,1,103,237,111,42,239,59,27,39,98,151,90,205,51,17,33,35,180,221,240,152,20,242,32,16,172,176,46,202,110,176,99,76,7,244,55,138,84,211,206,211,165,176,127,25,157,17,223,12,110,247,183,102,212,213,91,117,98,167,211,211,233,15,97,212,210,55,169,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("fa05a2c7-0e11-4e5f-a19b-16fb050762c1"),
				ContainerUId = new Guid("88714082-9190-4092-9c5b-580b606c294f"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc0b26dd-f352-4bdc-85e2-8c07f97c3355"),
				ContainerUId = new Guid("88714082-9190-4092-9c5b-580b606c294f"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ae8ff592-352a-4e64-b2ff-890082dfab9d"),
				ContainerUId = new Guid("88714082-9190-4092-9c5b-580b606c294f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,212,48,20,253,21,148,117,93,57,239,100,118,168,12,168,18,162,21,173,216,52,179,112,156,235,169,69,94,114,60,133,97,20,9,248,130,14,223,193,130,5,226,41,177,232,168,63,210,47,225,58,153,14,109,41,211,170,27,132,196,194,137,125,116,239,185,239,59,179,120,206,154,230,9,43,192,26,88,251,160,20,107,42,161,55,31,202,92,131,122,164,170,73,109,109,88,13,40,201,114,249,10,178,30,31,102,82,63,96,154,161,202,44,249,197,144,88,131,228,122,142,196,218,72,44,169,161,104,80,6,85,108,0,65,131,8,72,154,186,33,241,82,219,37,49,163,41,9,169,200,132,67,193,75,153,97,91,67,190,93,246,244,29,179,232,174,251,211,218,72,121,8,240,170,168,153,146,77,85,46,65,215,216,111,134,37,75,115,200,240,173,213,4,16,210,74,22,24,8,236,203,2,118,153,66,51,134,167,50,16,10,9,150,55,70,42,7,161,135,47,107,5,77,35,171,114,189,95,91,85,62,41,202,139,210,72,0,171,231,210,29,218,249,104,36,119,153,62,236,40,118,234,186,82,122,82,74,61,77,172,182,115,247,254,120,172,96,204,180,60,186,232,205,115,152,118,10,183,203,33,42,100,88,169,103,44,159,192,210,184,77,127,139,105,139,213,186,15,45,177,22,199,167,95,22,243,179,183,239,23,199,39,63,240,124,196,243,1,207,39,243,239,8,21,8,80,80,114,216,227,135,80,176,85,22,46,133,96,228,228,248,240,130,17,83,251,131,53,169,91,21,224,166,236,57,8,214,231,194,235,203,177,226,188,54,19,78,128,224,145,1,122,150,243,107,98,29,108,55,59,47,74,80,125,132,125,238,71,155,136,94,1,134,57,20,80,234,193,140,6,174,107,123,129,32,177,239,217,196,227,49,37,145,23,123,36,16,140,51,136,92,22,217,97,139,10,43,135,6,51,199,247,253,204,7,159,196,89,16,19,47,224,54,137,169,45,8,100,190,19,165,66,164,60,227,237,168,119,92,54,117,206,166,157,239,55,23,233,30,126,62,47,129,111,189,212,252,236,245,87,124,125,239,208,249,201,155,197,252,244,221,230,83,224,149,202,182,179,206,132,249,33,113,100,167,110,68,61,151,4,153,135,93,229,165,41,97,177,143,97,69,33,68,140,70,24,98,136,253,217,182,163,214,52,105,94,141,37,103,249,78,13,138,45,59,136,94,63,106,151,102,212,228,93,85,149,190,210,64,143,129,245,206,156,247,120,204,152,23,114,238,16,74,29,204,170,111,242,27,154,110,23,148,243,192,177,49,217,168,217,226,138,50,165,221,171,38,138,67,191,23,154,126,55,221,105,231,252,133,117,114,167,13,241,135,249,186,205,188,252,159,132,197,63,48,9,173,213,254,4,10,140,227,2,161,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a93327ad-0eff-457f-ac57-26fbc93ce95a"),
				ContainerUId = new Guid("88714082-9190-4092-9c5b-580b606c294f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,93,111,155,48,20,253,43,149,219,199,24,97,108,108,156,215,229,37,82,58,69,75,215,151,210,135,107,251,122,69,35,16,241,49,169,139,242,223,103,8,52,77,181,74,147,230,7,144,47,62,31,58,199,28,201,93,247,122,64,178,36,15,216,52,208,214,190,139,190,212,13,70,219,166,182,216,182,209,166,182,80,22,191,193,148,184,133,6,246,216,97,243,8,101,143,237,166,104,187,197,205,53,140,44,200,221,175,241,43,89,62,29,201,186,195,253,247,181,11,236,74,160,119,41,183,212,97,10,84,160,97,52,211,46,163,74,218,140,11,157,130,74,116,0,219,186,236,247,213,61,118,176,133,238,133,44,143,100,100,11,4,198,198,54,113,50,166,41,112,71,69,38,98,10,32,144,90,25,35,40,37,49,137,37,57,45,72,107,95,112,15,163,232,5,44,24,248,76,163,166,42,141,205,160,110,104,102,193,82,239,185,54,50,144,49,180,3,120,58,127,1,62,221,110,234,250,103,127,136,146,132,11,102,29,163,169,225,156,10,27,228,117,204,24,149,94,73,205,209,75,20,34,98,194,122,43,133,160,200,49,120,212,10,105,150,40,77,209,9,206,180,49,89,172,249,237,243,32,228,138,246,80,194,235,227,167,122,27,4,119,211,118,240,3,163,85,200,185,41,76,223,21,117,117,70,31,174,138,120,143,63,230,231,62,115,178,204,63,107,116,122,239,198,160,174,59,253,88,103,78,22,57,217,213,125,99,7,70,30,54,171,119,198,71,145,241,200,135,237,220,95,152,84,125,89,78,147,21,116,48,31,156,199,181,43,124,129,110,93,237,230,218,70,150,120,90,244,47,143,121,157,189,253,15,236,30,170,144,111,243,53,4,112,241,254,230,242,33,196,56,19,155,68,167,177,98,158,42,4,29,238,143,76,104,230,24,80,29,90,245,92,241,196,251,100,68,127,67,143,13,86,22,175,141,253,203,237,153,240,237,152,246,240,227,76,190,134,168,78,228,116,122,62,253,1,228,209,8,145,172,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fdead1a0-736b-4043-8b38-7b10af3b41ac"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,59,111,19,65,16,254,43,209,213,217,232,94,190,135,59,20,12,74,67,34,37,74,131,83,236,237,237,57,43,238,165,189,117,192,88,150,16,61,194,78,153,10,42,26,138,8,241,112,18,30,210,89,225,135,240,75,152,221,181,29,7,25,197,80,64,19,75,39,207,126,251,205,204,55,119,51,211,55,72,138,171,234,1,206,168,209,52,246,40,231,184,42,18,177,113,143,165,130,242,251,188,232,150,198,186,81,81,206,112,202,158,210,88,227,173,152,137,187,88,96,112,233,183,175,34,180,141,102,123,121,140,182,177,222,54,152,160,89,5,28,112,161,52,105,36,78,144,32,39,78,26,200,37,94,132,66,106,5,136,70,22,9,60,139,120,110,128,53,243,119,193,55,139,172,196,156,234,28,42,124,162,204,189,94,41,169,22,0,68,81,88,85,228,83,208,145,34,170,86,142,163,148,198,112,22,188,75,1,18,156,101,80,13,221,99,25,221,193,28,114,201,56,133,132,128,148,224,180,146,172,148,38,162,245,164,228,180,170,88,145,223,36,46,237,102,249,34,27,2,208,249,113,42,199,84,26,37,115,7,139,67,21,98,11,100,13,148,202,59,157,14,167,29,44,216,209,162,136,71,180,167,120,171,189,63,112,136,225,43,237,227,180,75,23,114,94,175,100,19,151,66,23,164,211,3,129,179,206,225,202,181,206,223,216,77,229,218,0,150,51,242,138,49,151,214,96,123,0,30,73,64,71,153,153,109,227,225,86,181,253,56,167,124,151,28,210,12,235,183,118,176,1,232,47,64,43,165,25,205,69,179,31,5,14,241,236,56,64,30,9,28,228,122,78,128,2,219,55,145,141,177,99,250,86,3,199,196,25,128,195,92,80,179,31,59,113,195,139,18,11,249,190,143,145,27,17,31,97,108,130,139,27,6,1,54,35,223,114,19,233,210,202,5,19,61,221,9,205,190,31,250,152,56,13,27,185,161,31,34,55,182,3,20,154,94,2,217,18,26,121,113,68,194,152,12,14,116,185,172,42,83,220,219,159,87,53,25,214,111,224,25,79,70,63,158,157,128,113,170,141,209,229,241,26,156,222,43,100,88,127,81,15,220,156,129,241,65,222,124,131,211,243,183,96,124,93,160,125,148,145,54,38,195,203,177,164,205,24,239,102,142,103,107,147,81,253,2,140,11,117,61,172,63,79,255,85,232,147,181,153,131,132,62,77,70,223,143,21,21,164,204,196,141,53,67,222,140,46,149,211,233,148,14,161,135,245,249,84,206,197,66,138,115,201,122,165,124,181,182,250,245,85,169,90,57,68,173,95,194,104,200,159,236,224,162,195,8,78,183,75,202,97,66,84,135,154,203,103,251,218,82,144,125,195,139,66,232,110,152,247,221,118,89,22,92,116,115,248,92,187,2,119,0,92,152,52,72,10,11,80,182,224,110,209,229,100,186,112,42,189,249,254,106,163,253,135,61,245,39,171,103,233,240,175,50,204,183,99,122,59,166,147,127,58,166,3,99,240,19,81,191,31,253,192,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9af14c8d-5edd-4be4-82c3-646e2adff0bc"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7f6dda89-a2ac-45ad-b8c0-966007f49fd0"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5ecd48e-a7a6-47ec-82df-5380d83aa6de"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7f02d3d0-3614-4905-abe0-9735007319da"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("59927067-c313-487e-a77d-d761614e8ff2"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ef491bee-22fc-489d-b39e-7ddd0b703901"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("89a40511-3074-42c8-86d3-3a3435c824cf"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8d6e0dc8-5703-47d6-a9fb-bd2247ac15b2"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("37274c45-33e6-4771-b984-e64a60ac3c9e"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("2da695c0-6a45-4669-bb65-ac00a4c44e4b"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("b5a2e001-fa12-4f66-aee8-dedbda666123"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("520dc2ae-127d-4a19-a262-4cb393dd7059"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("80b7ce3d-4682-44d1-9eed-989e91e8cd2a"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("31093895-ecdd-44eb-8dcb-68e59c009683"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7b2e740a-bafe-4153-b031-137e02d7f695"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,179,76,49,54,75,51,179,52,215,53,53,75,73,210,53,49,53,182,212,181,180,48,176,212,77,50,48,79,51,48,76,73,75,181,76,52,0,0,122,108,77,60,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fefe044c-19ec-45d1-b204-216cac3e8aec"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("9c82aecd-d571-4e99-939e-93f3f46b4025"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
				UId = new Guid("233a783f-26d5-4bc7-83f0-156106e985b5"),
				ContainerUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask userquestionusertask1 = CreateUserQuestionUserTask1UserTask();
			FlowElements.Add(userquestionusertask1);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			ProcessSchemaUserTask changedatausertask3 = CreateChangeDataUserTask3UserTask();
			FlowElements.Add(changedatausertask3);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5f32329f-b1e7-4999-96ba-8ca0f115bc9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0633146f-9541-4c90-8494-6facae83a817"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("424a9228-4ce5-4385-b3ca-3e1dafa48978"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("f0787462-3d38-48ab-97ca-b6cff17f42ff"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{67cfff35-621a-4e09-916b-349b66e15f44}].[Parameter:{89a40511-3074-42c8-86d3-3a3435c824cf}].[EntityColumn:{9d36f697-56db-4539-9809-b07f01dfe9a0}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(371, 134),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3d8feeb-df0e-417b-aaee-25280baf9119"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(505, 198));
			schemaFlow.PolylinePointPositions.Add(new Point(505, 197));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("562067d2-5de3-4e83-9d05-3d9b10938727"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(488, 332),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88714082-9190-4092-9c5b-580b606c294f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"), new Collection<Guid>() {
						new Guid("a34c662d-0469-4495-b69f-30ef07598541"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("4c59f6a2-cc7e-42c1-b95d-e084dc60daf6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(486, 279),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"), new Collection<Guid>() {
						new Guid("a744d544-e50d-457c-a08a-c8006d44713a"),
					}},
				}
			};
			schemaFlow.PolylinePointPositions.Add(new Point(508, 351));
			schemaFlow.PolylinePointPositions.Add(new Point(508, 197));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("a6aeda21-aa55-407e-a759-b9c780e3273f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(606, 233),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4e8b447-2802-40bb-989f-573cc8842404"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("4c05c146-e826-447f-9102-5c5bef796db0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(598, 269),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88714082-9190-4092-9c5b-580b606c294f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4e8b447-2802-40bb-989f-573cc8842404"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(736, 351));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("aa9be9f1-0de3-487e-a9c6-4fae18f3f45f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72dfd004-1fad-41fa-ad05-3cbc97f2958e"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3d8feeb-df0e-417b-aaee-25280baf9119"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f235cee2-4622-4f1f-9e61-5ce539fae4a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72dfd004-1fad-41fa-ad05-3cbc97f2958e"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f3d8feeb-df0e-417b-aaee-25280baf9119"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a9a1c213-ba59-43f2-9719-43d1cc48485b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a9a1c213-ba59-43f2-9719-43d1cc48485b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("b4e8b447-2802-40bb-989f-573cc8842404"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"Terminate1",
				Position = new Point(723, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("0633146f-9541-4c90-8494-6facae83a817"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(57, 185),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("797ac352-4979-4d28-906f-82feb6dbc9dc");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f3d8feeb-df0e-417b-aaee-25280baf9119"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"ExclusiveGateway1",
				Position = new Point(366, 171),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"ReadDataUserTask1",
				Position = new Point(125, 171),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserQuestionUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"UserQuestionUserTask1",
				Position = new Point(359, 324),
				SchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeUserQuestionUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"ChangeDataUserTask2",
				Position = new Point(589, 170),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("88714082-9190-4092-9c5b-580b606c294f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c30b0386-9ab7-4104-8ab8-78b14b83ab49"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"ChangeDataUserTask3",
				Position = new Point(589, 324),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39173b28-7cb6-47ae-a429-5024c44d51a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("72dfd004-1fad-41fa-ad05-3cbc97f2958e"),
				CreatedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"),
				Name = @"ReadDataUserTask2",
				Position = new Point(236, 171),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadAutoToEndState(userConnection);
		}

		public override object Clone() {
			return new LeadAutoToEndStateSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadAutoToEndState

	/// <exclude/>
	public class LeadAutoToEndState : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, LeadAutoToEndState process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, LeadAutoToEndState process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("b83c62d8-6c83-4638-8270-2aa30715adc3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,19,49,20,253,21,52,235,186,154,25,207,51,59,84,2,234,134,86,180,234,134,116,225,216,215,169,197,188,100,59,133,18,69,2,190,160,233,119,176,96,129,120,74,44,26,245,71,250,37,92,207,164,33,69,65,13,108,16,18,35,121,102,124,116,124,124,238,245,189,158,120,188,96,198,60,102,37,120,61,239,16,180,102,166,150,118,251,161,42,44,232,71,186,30,55,222,150,103,64,43,86,168,151,32,58,188,47,148,125,192,44,195,37,147,193,15,133,129,215,27,172,215,24,120,91,3,79,89,40,13,114,112,137,20,34,72,242,44,39,81,42,125,18,1,15,8,203,194,152,80,42,169,160,60,204,50,234,119,204,95,137,239,212,101,195,52,116,123,180,242,178,253,61,60,107,28,53,64,128,183,20,101,234,106,1,82,103,194,244,43,54,44,64,224,220,234,49,32,100,181,42,49,26,56,84,37,236,51,141,123,57,157,218,65,72,146,172,48,142,85,128,180,253,23,141,6,99,84,93,221,101,174,24,151,213,42,27,5,96,57,93,216,241,91,143,142,185,207,236,73,43,177,139,182,166,173,203,251,163,145,134,17,179,234,116,213,196,51,56,107,121,155,229,15,23,8,60,165,35,86,140,97,101,207,219,145,236,176,198,118,1,117,219,35,65,171,209,201,198,177,46,51,118,87,184,33,130,205,13,121,67,205,181,49,132,9,130,167,14,232,84,110,126,7,222,211,93,179,247,188,2,125,192,79,160,100,93,214,142,183,17,253,9,232,23,80,66,101,123,19,63,161,52,136,18,73,242,56,10,72,196,115,159,100,81,30,145,68,50,206,32,163,44,11,210,41,46,88,26,234,77,194,56,142,69,12,49,201,69,130,249,79,48,245,185,31,72,2,34,14,179,161,148,67,46,248,244,184,51,174,76,83,176,179,163,165,191,249,249,213,167,249,236,250,205,219,249,249,229,55,28,239,113,188,195,241,193,125,239,225,235,227,2,248,210,177,102,215,175,62,227,236,107,139,206,46,95,207,103,87,23,219,79,128,215,90,44,142,202,125,80,56,78,83,26,197,52,39,44,73,37,137,36,119,113,164,64,88,158,242,48,201,253,72,176,16,43,203,61,174,0,234,145,226,172,216,107,64,99,129,181,7,236,175,111,141,91,61,229,210,174,235,218,118,201,92,30,219,94,211,212,218,142,43,101,177,54,87,106,52,75,56,196,67,17,145,56,201,40,230,54,2,50,20,62,22,106,32,168,47,131,208,79,37,67,79,120,189,184,3,62,168,199,154,47,218,217,116,247,202,31,221,23,127,225,22,248,157,198,94,219,90,155,180,202,255,38,152,255,51,77,48,245,166,223,1,186,144,37,32,88,7,0,0 })));
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

			private bool _readSomeTopRecords = false;
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

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
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
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,183,52,79,76,54,54,53,210,53,177,52,183,212,53,73,49,178,208,181,52,48,75,211,181,48,74,75,77,50,75,73,74,182,76,73,6,0,174,79,115,201,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: UserQuestionUserTask1FlowElement

		/// <exclude/>
		public class UserQuestionUserTask1FlowElement : UserQuestionUserTask
		{

			#region Constructors: Public

			public UserQuestionUserTask1FlowElement(UserConnection userConnection, LeadAutoToEndState process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserQuestionUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ab596052-3889-4d6f-ac74-f7be133771d7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private LocalizableString _branchingDecisions;
			public override LocalizableString BranchingDecisions {
				get {
					if (_branchingDecisions == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,143,193,106,195,48,12,134,95,101,152,30,163,226,52,114,108,247,218,50,40,148,209,195,182,203,216,65,118,100,26,150,46,197,118,7,107,201,187,47,205,169,133,177,203,110,130,79,223,47,253,23,49,203,223,71,22,75,241,204,49,82,234,67,158,175,250,200,243,93,236,61,167,52,223,246,158,186,246,76,174,227,29,69,58,112,230,248,74,221,137,211,182,77,185,120,184,215,68,33,102,95,19,21,203,183,139,216,100,62,188,108,154,49,93,26,107,131,180,14,188,70,3,24,104,1,142,189,5,109,26,146,68,24,208,148,163,124,221,189,136,41,97,148,72,35,54,10,17,88,201,6,80,105,15,36,13,129,55,82,214,13,162,46,43,18,67,33,158,198,183,110,189,53,251,54,181,253,167,188,194,21,29,243,56,95,121,155,182,254,60,61,47,150,57,158,120,164,107,14,171,61,251,15,190,59,252,72,93,98,49,12,197,109,133,224,180,116,149,114,80,74,201,128,134,53,24,110,42,80,126,129,222,85,186,170,213,47,21,42,244,117,189,104,64,98,109,1,209,42,112,181,13,80,73,14,82,43,107,20,150,127,85,152,224,127,42,188,15,63,228,46,79,153,227,1,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "9af301a024e549919da3cf2e0f291386",
							"BaseElements.UserQuestionUserTask1.Parameters.BranchingDecisions.Value");
						dataList.LoadLocalizableValues();
						_branchingDecisions = dataList.GetSerializedItems();
						};
					return _branchingDecisions;
				}
				set {
					_branchingDecisions = value;
				}
			}

			private int _decisionMode = 0;
			public override int DecisionMode {
				get {
					return _decisionMode;
				}
				set {
					_decisionMode = value;
				}
			}

			private bool _isDecisionRequired = true;
			public override bool IsDecisionRequired {
				get {
					return _isDecisionRequired;
				}
				set {
					_isDecisionRequired = value;
				}
			}

			private LocalizableString _question;
			public override LocalizableString Question {
				get {
					return _question ?? (_question = GetLocalizableString("9af301a024e549919da3cf2e0f291386",
						 "BaseElements.UserQuestionUserTask1.Parameters.Question.Value"));
				}
				set {
					_question = value;
				}
			}

			private LocalizableString _windowCaption;
			public override LocalizableString WindowCaption {
				get {
					return _windowCaption ?? (_windowCaption = GetLocalizableString("9af301a024e549919da3cf2e0f291386",
						 "BaseElements.UserQuestionUserTask1.Parameters.WindowCaption.Value"));
				}
				set {
					_windowCaption = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("9af301a024e549919da3cf2e0f291386",
						 "BaseElements.UserQuestionUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private int _duration = 5;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private bool _showInScheduler = false;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			private bool _showExecutionPage = true;
			public override bool ShowExecutionPage {
				get {
					return _showExecutionPage;
				}
				set {
					_showExecutionPage = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"a34c662d-0469-4495-b69f-30ef07598541\",\"a744d544-e50d-457c-a08a-c8006d44713a\"]";
			}

			#endregion

		}

		#endregion

		#region Class: ChangeDataUserTask2FlowElement

		/// <exclude/>
		public class ChangeDataUserTask2FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, LeadAutoToEndState process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("f9de1386-6917-4d63-9831-56fcec025df4");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("0a0808c5-5415-41f0-bea3-118cc3089959"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,73,110,212,64,20,189,10,242,58,21,121,42,15,189,67,161,65,145,16,137,72,196,38,206,226,187,252,171,83,194,147,202,213,129,166,101,9,56,65,58,231,96,193,2,49,74,44,210,202,69,114,18,170,236,78,211,9,153,148,13,66,98,81,30,158,222,127,245,231,169,197,114,104,154,103,80,160,53,176,118,81,74,104,42,174,214,31,139,92,161,124,34,171,113,109,173,89,13,74,1,185,120,131,89,143,15,51,161,30,129,2,109,50,77,126,43,36,214,32,185,90,35,177,214,18,75,40,44,26,205,209,38,158,71,3,224,52,34,153,27,82,226,71,94,74,98,238,1,9,168,157,58,16,57,60,142,178,158,121,157,248,102,217,203,119,202,188,251,220,157,212,134,229,107,128,85,69,13,82,52,85,185,0,61,115,127,51,44,33,205,209,40,43,57,70,13,41,41,10,29,8,238,138,2,183,65,234,107,140,78,101,32,77,226,144,55,134,149,35,87,195,215,181,196,166,17,85,121,179,95,27,85,62,46,202,85,182,22,192,229,239,194,29,187,243,209,48,183,65,29,116,18,91,117,93,73,53,46,133,154,36,86,219,185,251,112,52,146,56,2,37,14,87,189,121,137,147,206,224,110,57,212,6,153,174,212,11,200,199,184,184,220,177,255,136,105,3,106,213,135,150,88,243,163,211,175,243,217,217,251,15,243,163,147,159,250,124,210,231,163,62,159,205,187,19,148,200,81,98,201,112,135,29,96,1,203,44,92,8,193,240,196,232,96,229,18,83,251,189,27,82,183,44,192,109,217,115,53,88,159,147,111,46,199,82,243,202,76,184,129,6,15,13,208,171,156,127,38,214,222,102,179,245,170,68,217,71,216,231,126,127,93,163,151,128,97,142,5,150,106,48,181,3,207,115,252,128,147,152,250,14,241,89,108,147,200,143,125,18,112,96,128,145,167,11,18,182,218,96,233,208,96,234,82,74,51,138,148,196,89,16,19,63,96,14,137,109,135,19,204,168,27,165,156,167,44,99,237,126,239,184,104,234,28,38,157,239,183,23,233,129,126,124,89,0,223,123,214,236,236,237,55,253,247,163,67,103,39,239,230,179,211,227,245,231,200,42,153,109,246,93,98,94,90,56,8,60,159,135,105,68,156,136,102,196,143,237,128,128,135,46,73,195,56,181,253,152,135,52,140,117,127,182,237,126,107,154,52,175,70,130,65,190,85,163,132,69,7,217,87,143,218,133,25,53,121,151,85,165,46,53,208,83,132,222,153,243,30,207,60,23,89,168,219,155,2,229,58,171,97,72,34,198,92,2,145,111,115,7,60,207,3,227,141,94,81,166,180,59,213,88,50,236,247,66,211,239,166,123,237,156,191,176,78,238,181,33,174,153,175,187,204,203,255,73,152,255,3,147,208,90,237,47,87,60,214,218,161,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,203,110,219,48,16,252,149,128,201,209,43,144,226,67,162,175,205,197,128,83,24,117,154,75,156,195,146,92,54,66,101,203,144,228,2,169,225,127,175,164,72,113,28,52,64,129,242,32,129,43,206,236,104,102,121,100,55,237,203,158,216,156,221,83,93,99,83,197,54,249,82,213,148,172,234,202,83,211,36,203,202,99,89,252,70,87,210,10,107,220,82,75,245,3,150,7,106,150,69,211,206,174,46,97,108,198,110,126,13,95,217,252,241,200,22,45,109,191,47,66,199,158,201,84,155,204,32,72,238,34,40,109,34,56,71,28,108,8,90,103,33,117,232,123,176,175,202,195,118,119,71,45,174,176,125,102,243,35,27,216,58,2,231,185,79,131,225,160,81,6,80,185,226,128,168,8,188,225,132,89,102,40,229,134,157,102,172,241,207,180,197,161,233,25,172,4,198,220,146,133,76,115,7,138,156,131,220,163,135,24,165,117,166,35,19,228,123,240,120,254,12,124,188,94,86,213,207,195,62,73,83,169,132,15,2,180,147,18,148,239,218,91,46,4,152,152,25,43,41,26,82,42,225,200,115,158,123,13,90,9,13,74,68,14,142,80,130,16,185,247,146,231,214,106,123,253,212,55,10,69,179,47,241,229,225,211,126,75,194,112,213,180,248,131,146,53,182,69,19,11,10,175,208,253,69,10,239,193,199,205,107,152,27,54,223,124,22,231,248,94,15,46,93,6,250,49,203,13,155,109,216,186,58,212,190,103,148,221,230,246,157,234,161,201,112,228,195,118,10,175,171,236,14,101,57,86,110,177,197,233,224,84,174,66,209,255,214,98,183,158,50,27,88,248,184,224,47,143,105,189,106,251,31,216,29,238,58,115,235,175,157,1,103,237,111,42,239,59,27,39,98,151,90,205,51,17,33,35,180,221,240,152,20,242,32,16,172,176,46,202,110,176,99,76,7,244,55,138,84,211,206,211,165,176,127,25,157,17,223,12,110,247,183,102,212,213,91,117,98,167,211,211,233,15,97,212,210,55,169,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "9af301a024e549919da3cf2e0f291386",
							"BaseElements.ChangeDataUserTask2.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("72dfd004-1fad-41fa-ad05-3cbc97f2958e");
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

		#region Class: ChangeDataUserTask3FlowElement

		/// <exclude/>
		public class ChangeDataUserTask3FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask3FlowElement(UserConnection userConnection, LeadAutoToEndState process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("88714082-9190-4092-9c5b-580b606c294f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("14cfc644-e3ed-497e-8279-ed4319bb8093"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,212,48,20,253,21,148,117,93,57,239,100,118,168,12,168,18,162,21,173,216,52,179,112,156,235,169,69,94,114,60,133,97,20,9,248,130,14,223,193,130,5,226,41,177,232,168,63,210,47,225,58,153,14,109,41,211,170,27,132,196,194,137,125,116,239,185,239,59,179,120,206,154,230,9,43,192,26,88,251,160,20,107,42,161,55,31,202,92,131,122,164,170,73,109,109,88,13,40,201,114,249,10,178,30,31,102,82,63,96,154,161,202,44,249,197,144,88,131,228,122,142,196,218,72,44,169,161,104,80,6,85,108,0,65,131,8,72,154,186,33,241,82,219,37,49,163,41,9,169,200,132,67,193,75,153,97,91,67,190,93,246,244,29,179,232,174,251,211,218,72,121,8,240,170,168,153,146,77,85,46,65,215,216,111,134,37,75,115,200,240,173,213,4,16,210,74,22,24,8,236,203,2,118,153,66,51,134,167,50,16,10,9,150,55,70,42,7,161,135,47,107,5,77,35,171,114,189,95,91,85,62,41,202,139,210,72,0,171,231,210,29,218,249,104,36,119,153,62,236,40,118,234,186,82,122,82,74,61,77,172,182,115,247,254,120,172,96,204,180,60,186,232,205,115,152,118,10,183,203,33,42,100,88,169,103,44,159,192,210,184,77,127,139,105,139,213,186,15,45,177,22,199,167,95,22,243,179,183,239,23,199,39,63,240,124,196,243,1,207,39,243,239,8,21,8,80,80,114,216,227,135,80,176,85,22,46,133,96,228,228,248,240,130,17,83,251,131,53,169,91,21,224,166,236,57,8,214,231,194,235,203,177,226,188,54,19,78,128,224,145,1,122,150,243,107,98,29,108,55,59,47,74,80,125,132,125,238,71,155,136,94,1,134,57,20,80,234,193,140,6,174,107,123,129,32,177,239,217,196,227,49,37,145,23,123,36,16,140,51,136,92,22,217,97,139,10,43,135,6,51,199,247,253,204,7,159,196,89,16,19,47,224,54,137,169,45,8,100,190,19,165,66,164,60,227,237,168,119,92,54,117,206,166,157,239,55,23,233,30,126,62,47,129,111,189,212,252,236,245,87,124,125,239,208,249,201,155,197,252,244,221,230,83,224,149,202,182,179,206,132,249,33,113,100,167,110,68,61,151,4,153,135,93,229,165,41,97,177,143,97,69,33,68,140,70,24,98,136,253,217,182,163,214,52,105,94,141,37,103,249,78,13,138,45,59,136,94,63,106,151,102,212,228,93,85,149,190,210,64,143,129,245,206,156,247,120,204,152,23,114,238,16,74,29,204,170,111,242,27,154,110,23,148,243,192,177,49,217,168,217,226,138,50,165,221,171,38,138,67,191,23,154,126,55,221,105,231,252,133,117,114,167,13,241,135,249,186,205,188,252,159,132,197,63,48,9,173,213,254,4,10,140,227,2,161,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,93,111,155,48,20,253,43,149,219,199,24,97,108,108,156,215,229,37,82,58,69,75,215,151,210,135,107,251,122,69,35,16,241,49,169,139,242,223,103,8,52,77,181,74,147,230,7,144,47,62,31,58,199,28,201,93,247,122,64,178,36,15,216,52,208,214,190,139,190,212,13,70,219,166,182,216,182,209,166,182,80,22,191,193,148,184,133,6,246,216,97,243,8,101,143,237,166,104,187,197,205,53,140,44,200,221,175,241,43,89,62,29,201,186,195,253,247,181,11,236,74,160,119,41,183,212,97,10,84,160,97,52,211,46,163,74,218,140,11,157,130,74,116,0,219,186,236,247,213,61,118,176,133,238,133,44,143,100,100,11,4,198,198,54,113,50,166,41,112,71,69,38,98,10,32,144,90,25,35,40,37,49,137,37,57,45,72,107,95,112,15,163,232,5,44,24,248,76,163,166,42,141,205,160,110,104,102,193,82,239,185,54,50,144,49,180,3,120,58,127,1,62,221,110,234,250,103,127,136,146,132,11,102,29,163,169,225,156,10,27,228,117,204,24,149,94,73,205,209,75,20,34,98,194,122,43,133,160,200,49,120,212,10,105,150,40,77,209,9,206,180,49,89,172,249,237,243,32,228,138,246,80,194,235,227,167,122,27,4,119,211,118,240,3,163,85,200,185,41,76,223,21,117,117,70,31,174,138,120,143,63,230,231,62,115,178,204,63,107,116,122,239,198,160,174,59,253,88,103,78,22,57,217,213,125,99,7,70,30,54,171,119,198,71,145,241,200,135,237,220,95,152,84,125,89,78,147,21,116,48,31,156,199,181,43,124,129,110,93,237,230,218,70,150,120,90,244,47,143,121,157,189,253,15,236,30,170,144,111,243,53,4,112,241,254,230,242,33,196,56,19,155,68,167,177,98,158,42,4,29,238,143,76,104,230,24,80,29,90,245,92,241,196,251,100,68,127,67,143,13,86,22,175,141,253,203,237,153,240,237,152,246,240,227,76,190,134,168,78,228,116,122,62,253,1,228,209,8,145,172,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "9af301a024e549919da3cf2e0f291386",
							"BaseElements.ChangeDataUserTask3.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("72dfd004-1fad-41fa-ad05-3cbc97f2958e");
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

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, LeadAutoToEndState process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("67cfff35-621a-4e09-916b-349b66e15f44");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,59,111,19,65,16,254,43,209,213,217,232,94,190,135,59,20,12,74,67,34,37,74,131,83,236,237,237,57,43,238,165,189,117,192,88,150,16,61,194,78,153,10,42,26,138,8,241,112,18,30,210,89,225,135,240,75,152,221,181,29,7,25,197,80,64,19,75,39,207,126,251,205,204,55,119,51,211,55,72,138,171,234,1,206,168,209,52,246,40,231,184,42,18,177,113,143,165,130,242,251,188,232,150,198,186,81,81,206,112,202,158,210,88,227,173,152,137,187,88,96,112,233,183,175,34,180,141,102,123,121,140,182,177,222,54,152,160,89,5,28,112,161,52,105,36,78,144,32,39,78,26,200,37,94,132,66,106,5,136,70,22,9,60,139,120,110,128,53,243,119,193,55,139,172,196,156,234,28,42,124,162,204,189,94,41,169,22,0,68,81,88,85,228,83,208,145,34,170,86,142,163,148,198,112,22,188,75,1,18,156,101,80,13,221,99,25,221,193,28,114,201,56,133,132,128,148,224,180,146,172,148,38,162,245,164,228,180,170,88,145,223,36,46,237,102,249,34,27,2,208,249,113,42,199,84,26,37,115,7,139,67,21,98,11,100,13,148,202,59,157,14,167,29,44,216,209,162,136,71,180,167,120,171,189,63,112,136,225,43,237,227,180,75,23,114,94,175,100,19,151,66,23,164,211,3,129,179,206,225,202,181,206,223,216,77,229,218,0,150,51,242,138,49,151,214,96,123,0,30,73,64,71,153,153,109,227,225,86,181,253,56,167,124,151,28,210,12,235,183,118,176,1,232,47,64,43,165,25,205,69,179,31,5,14,241,236,56,64,30,9,28,228,122,78,128,2,219,55,145,141,177,99,250,86,3,199,196,25,128,195,92,80,179,31,59,113,195,139,18,11,249,190,143,145,27,17,31,97,108,130,139,27,6,1,54,35,223,114,19,233,210,202,5,19,61,221,9,205,190,31,250,152,56,13,27,185,161,31,34,55,182,3,20,154,94,2,217,18,26,121,113,68,194,152,12,14,116,185,172,42,83,220,219,159,87,53,25,214,111,224,25,79,70,63,158,157,128,113,170,141,209,229,241,26,156,222,43,100,88,127,81,15,220,156,129,241,65,222,124,131,211,243,183,96,124,93,160,125,148,145,54,38,195,203,177,164,205,24,239,102,142,103,107,147,81,253,2,140,11,117,61,172,63,79,255,85,232,147,181,153,131,132,62,77,70,223,143,21,21,164,204,196,141,53,67,222,140,46,149,211,233,148,14,161,135,245,249,84,206,197,66,138,115,201,122,165,124,181,182,250,245,85,169,90,57,68,173,95,194,104,200,159,236,224,162,195,8,78,183,75,202,97,66,84,135,154,203,103,251,218,82,144,125,195,139,66,232,110,152,247,221,118,89,22,92,116,115,248,92,187,2,119,0,92,152,52,72,10,11,80,182,224,110,209,229,100,186,112,42,189,249,254,106,163,253,135,61,245,39,171,103,233,240,175,50,204,183,99,122,59,166,147,127,58,166,3,99,240,19,81,191,31,253,192,8,0,0 })));
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

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,179,76,49,54,75,51,179,52,215,53,53,75,73,210,53,49,53,182,212,181,180,48,176,212,77,50,48,79,51,48,76,73,75,181,76,52,0,0,122,108,77,60,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		public LeadAutoToEndState(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadAutoToEndState";
			SchemaUId = new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386");
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
				return new Guid("9af301a0-24e5-4991-9da3-cf2e0f291386");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadAutoToEndState, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadAutoToEndState, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("b4e8b447-2802-40bb-989f-573cc8842404"),
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
					SchemaElementUId = new Guid("0633146f-9541-4c90-8494-6facae83a817"),
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
					SchemaElementUId = new Guid("f3d8feeb-df0e-417b-aaee-25280baf9119"),
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

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private UserQuestionUserTask1FlowElement _userQuestionUserTask1;
		public UserQuestionUserTask1FlowElement UserQuestionUserTask1 {
			get {
				return _userQuestionUserTask1 ?? (_userQuestionUserTask1 = new UserQuestionUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask3FlowElement _changeDataUserTask3;
		public ChangeDataUserTask3FlowElement ChangeDataUserTask3 {
			get {
				return _changeDataUserTask3 ?? (_changeDataUserTask3 = new ChangeDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("f0787462-3d38-48ab-97ca-b6cff17f42ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("562067d2-5de3-4e83-9d05-3d9b10938727"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"), new Collection<Guid>() {
							new Guid("a34c662d-0469-4495-b69f-30ef07598541"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("4c59f6a2-cc7e-42c1-b95d-e084dc60daf6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("ab596052-3889-4d6f-ac74-f7be133771d7"), new Collection<Guid>() {
							new Guid("a744d544-e50d-457c-a08a-c8006d44713a"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[UserQuestionUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionUserTask1 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
			FlowElements[ChangeDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask3 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserQuestionUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "UserQuestionUserTask1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask3", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "UserQuestionUserTask1");
						break;
					case "ChangeDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Successful").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>("Successful") : false)));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"Successful\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>(\"Successful\") : false))", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalFlow3.ProcessActivitiesSelectedResults[new Guid("ab596052-3889-4d6f-ac74-f7be133771d7")])) != 0;
			Log.InfoFormat(ConditionalExpressionLogMessage, "UserQuestionUserTask1", "ConditionalFlow3", "System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalFlow3.ProcessActivitiesSelectedResults[new Guid(\"ab596052-3889-4d6f-ac74-f7be133771d7\")])) != 0", result);
			Log.Info($"UserQuestionUserTask1.ResultDecisions: {UserQuestionUserTask1.ResultDecisions}");
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalFlow4.ProcessActivitiesSelectedResults[new Guid("ab596052-3889-4d6f-ac74-f7be133771d7")])) != 0;
			Log.InfoFormat(ConditionalExpressionLogMessage, "UserQuestionUserTask1", "ConditionalFlow4", "System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalFlow4.ProcessActivitiesSelectedResults[new Guid(\"ab596052-3889-4d6f-ac74-f7be133771d7\")])) != 0", result);
			Log.Info($"UserQuestionUserTask1.ResultDecisions: {UserQuestionUserTask1.ResultDecisions}");
			return result;
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
			MetaPathParameterValues.Add("2555d5e5-9d69-46c1-901f-ed528bffbcdc", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("fb76d37f-4030-42f0-b828-cbb1a4b381aa", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("c674161d-9746-4a42-af2f-efe9123f908d", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("8e022789-4e9c-4ca9-a63a-bafe8b45d27a", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("891c2114-c8fc-465d-b1f5-f5278d3afcf2", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b8c3887c-acc7-4db4-a068-a6c9b5095c6f", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("0d2e4df5-ebbe-4435-8f78-c990952374df", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("d5c75813-9a69-4394-aa21-757ee0a79c85", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("4a96c175-f201-4971-a84c-667bf1d98abb", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("d3d56bf1-777a-4bc7-aa00-24988a0b714f", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("0e30322a-5528-4686-8289-0dd270a0747e", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("0515d8e0-89b7-4b5f-86f2-57c17fa5c211", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("a43a1cf1-ff6b-4013-8469-b230f95aeed3", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("15f88c4d-b432-4552-a155-90b07e7d0e80", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("7acadd53-ed9a-430e-92da-737ed1810ea7", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("6f8ca22a-b3a4-47eb-9ec6-08f559063864", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("c9b43dca-27ca-4615-a3d9-6b0896d38d91", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("a6b199bd-b0af-4235-9fd8-d432bef1342d", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("0c0fb151-9665-481d-a943-69460316e837", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d67c45a7-4e2e-4914-827d-b010d9f2e469", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("8b00b79c-2e00-4753-b346-abc376fc2fa3", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("23470eda-fd4a-4dcb-a26f-6eb160c6b305", () => UserQuestionUserTask1.BranchingDecisions);
			MetaPathParameterValues.Add("17cd0f5c-25fe-42a4-99da-d593c8a0a37f", () => UserQuestionUserTask1.ResultDecisions);
			MetaPathParameterValues.Add("fb9218e3-edba-4d6d-9f82-2f0ad13153dd", () => UserQuestionUserTask1.DecisionMode);
			MetaPathParameterValues.Add("711528bb-6676-488b-8c54-79154028c8f1", () => UserQuestionUserTask1.IsDecisionRequired);
			MetaPathParameterValues.Add("e4ef48da-4ee6-4ee6-ba67-0f5dd93a47cd", () => UserQuestionUserTask1.Question);
			MetaPathParameterValues.Add("0849dedf-33cf-448d-87ad-a9ba022daa4a", () => UserQuestionUserTask1.WindowCaption);
			MetaPathParameterValues.Add("3db58c3f-22ba-40b8-b71d-4b8bcd16a115", () => UserQuestionUserTask1.Recommendation);
			MetaPathParameterValues.Add("fad75be7-0f8a-4872-967c-7d2c62690303", () => UserQuestionUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("22a1d630-b988-4a27-b8ff-6fd69dca7b08", () => UserQuestionUserTask1.OwnerId);
			MetaPathParameterValues.Add("11afda49-35e6-4c12-9ea2-96db901da46b", () => UserQuestionUserTask1.Duration);
			MetaPathParameterValues.Add("9c63a071-4375-4cdc-9829-9904f26e6585", () => UserQuestionUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("588fd741-5860-4c73-8326-9fff706860b8", () => UserQuestionUserTask1.StartIn);
			MetaPathParameterValues.Add("29355950-5494-47a3-b730-2dca6b41b7d3", () => UserQuestionUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("b0c7abe8-1b56-4322-a1af-34567e8ee6c0", () => UserQuestionUserTask1.RemindBefore);
			MetaPathParameterValues.Add("10e64984-20e7-4e23-b0a7-b1d11798514c", () => UserQuestionUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("a6270bb2-5dac-4ad4-b8bc-207c2b3dce6b", () => UserQuestionUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("5d251a59-539c-46e1-8fbc-7d54869ffe8f", () => UserQuestionUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("1e3036be-34b9-4a4a-85ec-999e85694aba", () => UserQuestionUserTask1.Lead);
			MetaPathParameterValues.Add("693953dc-26bc-4cc8-893c-50df8cbfa540", () => UserQuestionUserTask1.Account);
			MetaPathParameterValues.Add("2edcfe17-f472-4a05-911e-ff5f6158c136", () => UserQuestionUserTask1.Contact);
			MetaPathParameterValues.Add("6560a60a-c2f8-4a12-8405-2ed91eed8bf0", () => UserQuestionUserTask1.Opportunity);
			MetaPathParameterValues.Add("d553a0ac-618b-4bef-bfee-e24778fcd6ad", () => UserQuestionUserTask1.Invoice);
			MetaPathParameterValues.Add("65175ba0-3b99-41ba-8e49-8f54e6f87036", () => UserQuestionUserTask1.Document);
			MetaPathParameterValues.Add("7b349c4c-8ceb-41b3-9e56-cbee348bc604", () => UserQuestionUserTask1.Incident);
			MetaPathParameterValues.Add("98189f43-a322-4b76-a3a9-14c369544dee", () => UserQuestionUserTask1.Case);
			MetaPathParameterValues.Add("bc28920d-a411-4c17-85ca-e6461f60c921", () => UserQuestionUserTask1.ActivityResult);
			MetaPathParameterValues.Add("7b906324-fffe-4806-a5bc-9c1e52e06325", () => UserQuestionUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("a929915e-60ad-42c2-9a7c-93301d1da38a", () => UserQuestionUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("ad6124ce-5389-44e0-a050-e08ee0924021", () => UserQuestionUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("bc996c5b-31fa-4a91-aeb2-7031c3994ca5", () => UserQuestionUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("2f0d536d-6d1d-4845-9703-1adeb8576fd9", () => UserQuestionUserTask1.Order);
			MetaPathParameterValues.Add("59fbf60e-8f41-448a-8616-849f39991f00", () => UserQuestionUserTask1.Requests);
			MetaPathParameterValues.Add("56c34026-9ed0-4dcb-b716-886b7c4b2b09", () => UserQuestionUserTask1.Listing);
			MetaPathParameterValues.Add("e04571cf-6c74-4140-b50b-a9ea256bd366", () => UserQuestionUserTask1.Property);
			MetaPathParameterValues.Add("27c89055-6026-4244-8ff4-093dfc05c28c", () => UserQuestionUserTask1.Contract);
			MetaPathParameterValues.Add("f9d05259-826b-43fc-bddb-d0915320cac5", () => UserQuestionUserTask1.Project);
			MetaPathParameterValues.Add("670d3618-61ea-44bb-bdc7-c282f5c9882a", () => UserQuestionUserTask1.Problem);
			MetaPathParameterValues.Add("7140ffaf-6034-4859-adb2-33eb5086764b", () => UserQuestionUserTask1.Change);
			MetaPathParameterValues.Add("07899f83-a011-4912-99f0-cf24347c6ba4", () => UserQuestionUserTask1.Release);
			MetaPathParameterValues.Add("a904d73f-a09c-44a8-878a-a19fc5c41658", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("0c2bfccf-ed5e-4d79-9cc8-06c7445de2ab", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("adbba650-d377-41d5-a69f-514e3c05c2a6", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("bec87d14-9ecd-40b3-a7ce-6925d9200e60", () => ChangeDataUserTask2.RecordColumnValues);
			MetaPathParameterValues.Add("fa05a2c7-0e11-4e5f-a19b-16fb050762c1", () => ChangeDataUserTask3.EntitySchemaUId);
			MetaPathParameterValues.Add("fc0b26dd-f352-4bdc-85e2-8c07f97c3355", () => ChangeDataUserTask3.IsMatchConditions);
			MetaPathParameterValues.Add("ae8ff592-352a-4e64-b2ff-890082dfab9d", () => ChangeDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("a93327ad-0eff-457f-ac57-26fbc93ce95a", () => ChangeDataUserTask3.RecordColumnValues);
			MetaPathParameterValues.Add("fdead1a0-736b-4043-8b38-7b10af3b41ac", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("9af14c8d-5edd-4be4-82c3-646e2adff0bc", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("7f6dda89-a2ac-45ad-b8c0-966007f49fd0", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("e5ecd48e-a7a6-47ec-82df-5380d83aa6de", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("7f02d3d0-3614-4905-abe0-9735007319da", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("59927067-c313-487e-a77d-d761614e8ff2", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("ef491bee-22fc-489d-b39e-7ddd0b703901", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("89a40511-3074-42c8-86d3-3a3435c824cf", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("8d6e0dc8-5703-47d6-a9fb-bd2247ac15b2", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("37274c45-33e6-4771-b984-e64a60ac3c9e", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("2da695c0-6a45-4669-bb65-ac00a4c44e4b", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("b5a2e001-fa12-4f66-aee8-dedbda666123", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("520dc2ae-127d-4a19-a262-4cb393dd7059", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("80b7ce3d-4682-44d1-9eed-989e91e8cd2a", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("31093895-ecdd-44eb-8dcb-68e59c009683", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("7b2e740a-bafe-4153-b031-137e02d7f695", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("fefe044c-19ec-45d1-b204-216cac3e8aec", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("9c82aecd-d571-4e99-939e-93f3f46b4025", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("233a783f-26d5-4bc7-83f0-156106e985b5", () => ReadDataUserTask2.ConsiderTimeInFilter);
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
			var cloneItem = (LeadAutoToEndState)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

