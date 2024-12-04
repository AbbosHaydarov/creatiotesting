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

	#region Class: AnalyzeCaseSatisfactionLevelSchema

	/// <exclude/>
	public class AnalyzeCaseSatisfactionLevelSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public AnalyzeCaseSatisfactionLevelSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public AnalyzeCaseSatisfactionLevelSchema(AnalyzeCaseSatisfactionLevelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AnalyzeCaseSatisfactionLevel";
			UId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
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
			RealUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7c806e5d-f304-455d-b2e4-9ed5a8c88f0c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("643fc2b1-37e6-4c13-b874-541f74be69c6"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,83,203,110,219,48,16,252,149,64,231,48,208,131,146,37,223,10,215,45,114,105,130,198,200,165,202,97,69,173,100,162,146,40,144,84,90,215,240,191,119,41,217,142,83,184,136,219,75,47,213,137,26,12,103,103,150,187,91,79,52,96,204,39,104,209,155,123,43,212,26,140,170,236,205,7,217,88,212,31,181,26,122,239,218,51,168,37,52,242,7,150,19,190,44,165,125,15,22,232,202,54,127,81,200,189,121,126,94,35,247,174,115,79,90,108,13,113,232,74,26,37,101,86,241,144,249,65,150,48,158,196,21,131,25,15,152,192,178,76,179,168,202,66,62,155,152,191,19,95,168,182,7,141,83,141,81,190,26,143,171,77,239,168,1,1,98,164,72,163,186,61,24,57,19,102,217,65,209,96,73,255,86,15,72,144,213,178,165,52,184,146,45,222,131,166,90,78,71,57,136,72,21,52,198,177,26,172,236,242,123,175,209,24,169,186,183,204,53,67,219,157,178,73,0,143,191,123,59,254,232,209,49,239,193,174,71,137,91,178,181,27,93,190,171,107,141,53,88,249,124,106,226,43,110,70,222,101,253,163,11,37,189,210,35,52,3,158,212,124,157,100,1,189,157,2,77,229,137,160,101,189,190,56,235,177,99,111,197,13,9,236,15,228,11,53,207,102,8,19,2,159,29,48,169,28,142,185,247,229,214,220,125,235,80,63,136,53,182,48,117,237,233,134,208,95,128,163,254,124,59,19,169,159,96,92,178,42,242,57,227,49,157,138,16,57,203,176,140,33,21,105,90,249,98,247,52,249,144,166,111,96,243,120,44,183,0,131,87,159,81,40,93,94,141,47,231,62,215,96,85,75,1,205,93,143,154,30,112,108,160,127,126,244,94,205,172,139,165,149,178,147,217,99,91,92,149,177,254,225,241,5,86,179,40,11,2,6,105,26,50,30,241,152,21,81,28,178,48,42,82,206,41,78,26,20,100,134,246,214,117,238,65,13,90,236,247,196,76,11,251,87,139,248,15,214,235,79,54,230,236,204,94,50,131,255,167,11,221,176,236,126,2,90,144,37,197,10,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fb56437e-ba33-4a23-9d0c-ae27bb35a2a4"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("28d07f6e-0d89-4984-ae74-9e1d6c8a64b5"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c4dec099-47fa-4366-98a4-b699ffa357e6"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("72de3fe9-d5d9-40ab-85f1-88ea175b52be"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e86df7f-bd13-4bc4-9cc7-8b7f60824845"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("247ba482-7f2c-4dc6-94f2-7174de79afd0"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("a7ec7ea4-ce5b-4f68-85b1-5bcb0f131a52"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("608cedf5-b8e9-4b65-b2eb-f05daae2899e"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("d10c7fb3-28cc-4700-a5b8-66c91209a9f8"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("fdea50bf-6a67-4306-9bf6-a560509191ee"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("85ce2111-939c-4c61-a6fc-25f3d846bef3"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("c8ea1ef0-089c-4d1e-ad79-bb1881d2a81b"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("6400198a-fd0f-42e8-aff8-558ad741e1f3"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("b853c17a-5aa9-4f6a-b6f5-dc1d14e76e99"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbfaa20f-5593-406d-b8d0-2a98e6a2c065"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55ff5bcf-9e1c-431e-be5e-7d02bf259e96"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("664166e1-37a2-407f-9c8d-1aa3cb91f96a"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("a9308cdd-6583-4b0d-b236-8b50811ee000"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3dc139f3-bcc4-413e-937a-9d613d137381"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,201,110,219,48,16,253,21,65,231,48,208,66,109,190,21,169,91,228,210,4,77,144,75,157,195,144,28,57,68,181,129,164,210,186,134,255,189,67,41,113,157,194,69,220,94,10,20,213,137,122,120,243,248,102,227,54,148,13,88,251,1,90,12,23,225,45,26,3,182,175,221,249,59,221,56,52,239,77,63,14,225,89,104,209,104,104,244,55,84,51,190,84,218,189,5,7,20,178,93,253,80,88,133,139,213,113,141,85,120,182,10,181,195,214,18,135,66,106,153,2,47,35,100,81,92,32,227,153,82,172,204,146,140,37,74,96,84,69,188,148,74,205,204,95,137,95,244,237,0,6,231,59,38,249,122,58,222,110,6,79,141,9,144,19,69,219,190,123,2,83,111,194,46,59,16,13,122,121,103,70,36,200,25,221,82,54,120,171,91,188,6,67,119,121,157,222,67,68,170,161,177,158,213,96,237,150,95,7,131,214,234,190,123,205,92,51,182,221,33,155,4,112,255,251,100,39,154,60,122,230,53,184,135,73,226,146,108,237,38,151,111,214,107,131,107,112,250,241,208,196,103,220,76,188,211,234,71,1,138,186,116,7,205,136,7,119,190,204,228,2,6,55,39,52,95,79,4,163,215,15,39,231,186,175,216,107,233,38,4,14,207,228,19,53,143,230,144,228,4,62,122,96,86,121,62,174,194,79,151,246,234,75,135,230,70,62,96,11,115,213,238,207,9,253,9,88,54,216,98,231,22,91,37,64,228,34,3,38,227,74,81,29,115,170,163,42,34,38,210,50,129,188,228,85,89,199,59,10,216,27,90,108,161,64,89,32,112,38,49,19,140,215,121,73,165,23,49,203,132,20,81,29,167,49,100,137,15,89,118,78,187,205,60,9,62,42,6,5,8,44,229,57,103,92,33,50,33,120,205,100,1,89,154,241,44,2,85,236,238,231,116,181,29,26,216,220,237,179,250,136,160,2,9,22,3,95,137,128,246,202,88,23,248,109,10,250,58,160,34,143,141,211,221,58,160,89,106,80,250,102,158,223,56,112,163,157,228,124,79,73,36,149,188,204,161,146,44,201,202,132,241,34,79,88,37,233,151,167,41,212,113,93,149,60,246,179,231,63,63,34,253,90,75,104,174,6,52,52,130,211,8,68,199,151,231,197,214,249,198,152,190,119,115,185,247,141,189,32,239,7,142,158,135,88,196,89,90,69,69,205,80,70,64,149,44,75,86,169,12,25,102,149,64,153,166,136,85,77,150,232,253,241,121,223,244,163,145,79,251,110,231,135,231,143,30,148,191,240,76,252,206,230,31,221,189,83,118,233,255,150,192,191,179,37,187,112,247,29,78,13,231,206,154,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c6de25d-2707-4643-a8ad-911d475e594c"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c01b2a0-4d16-41e0-a641-3d9a2f02561b"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c0073aa2-5633-49ad-b4a3-2e43b3e5669f"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("02c2428c-c555-47dc-9e99-df353f553049"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbd3780c-de4a-4e33-8ee8-b9febddbf1a5"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bd37a5c6-0d37-4523-b75c-cf34a74888cb"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("7092f775-9a72-4aaf-b608-e2668011359f"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("352856bf-54d3-414b-a777-6ea0f684dd68"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("38097a14-57ca-4d1c-a9b6-b83821594568"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("891c23be-079e-4dcf-afa7-6c04ead53b72"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("ca27a4b0-7cce-4840-9bca-800f545dca25"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("101a3fe4-83d5-45b2-94de-c891f8aae0b1"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("9b75f53d-4836-4518-9ff9-ac4c9e368e0f"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("b0a000e3-e6fc-4cdd-b51c-12f6e2c080eb"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ae705119-6e00-4b54-afa3-f7214514ce18"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7b964786-d631-40c6-80bc-46e13902504e"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("baeaa6dc-a9dd-4cbb-a360-ffdc711ecee8"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("d28d8cd8-42d1-4f62-bb6c-513cd1af7729"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("42a0be64-dc23-4a7d-9fe3-953b6cefb20b"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,93,111,211,48,20,253,43,81,158,231,41,78,226,38,233,27,26,5,77,66,108,98,19,47,116,15,215,206,117,23,225,124,200,118,7,165,234,127,231,58,217,74,135,138,86,120,1,137,60,197,71,199,199,231,126,110,99,101,192,185,247,208,98,60,143,111,209,90,112,189,246,231,111,26,227,209,190,181,253,122,136,207,98,135,182,1,211,124,195,122,194,23,117,227,95,131,7,186,178,93,254,80,88,198,243,229,113,141,101,124,182,140,27,143,173,35,14,93,17,105,33,11,72,50,166,121,13,44,79,211,154,73,212,57,195,50,7,149,241,66,21,101,58,49,127,37,126,209,183,3,88,156,222,24,229,245,248,123,187,25,2,149,19,160,70,74,227,250,238,17,204,130,9,183,232,64,26,172,233,236,237,26,9,242,182,105,41,26,188,109,90,188,6,75,111,5,157,62,64,68,210,96,92,96,25,212,126,241,117,176,232,92,211,119,47,153,51,235,182,59,100,147,0,238,143,143,118,146,209,99,96,94,131,191,31,37,46,201,214,110,116,249,106,181,178,184,2,223,60,28,154,248,140,155,145,119,90,254,232,66,77,85,250,8,102,141,7,111,62,143,228,2,6,63,5,52,61,79,4,219,172,238,79,142,117,159,177,151,194,77,9,28,158,200,39,106,30,141,33,157,17,248,16,128,73,229,233,119,25,127,186,116,87,95,58,180,55,234,30,91,152,178,118,119,78,232,79,192,194,96,139,157,159,111,107,9,114,38,5,48,197,171,154,229,98,86,179,178,46,18,38,179,50,133,89,153,87,165,230,59,186,176,55,52,223,66,129,170,64,200,153,66,33,89,174,103,37,43,133,228,76,72,37,19,205,51,14,34,13,87,22,157,111,252,102,234,132,249,86,41,173,132,150,154,229,181,170,88,94,96,206,42,174,51,38,114,132,42,21,28,36,47,119,119,83,184,141,27,12,108,62,238,163,250,128,80,71,10,28,70,33,19,17,205,149,117,62,10,211,20,245,58,162,36,175,141,111,186,85,68,189,100,80,133,98,158,223,80,227,56,13,227,33,50,248,128,102,148,14,245,37,193,186,168,80,128,200,88,9,21,117,15,240,138,162,150,148,132,154,167,57,231,149,76,32,167,62,12,95,104,151,126,213,40,48,87,3,90,82,29,219,33,57,62,72,207,38,48,20,201,246,189,159,82,191,47,242,161,179,119,123,99,79,125,205,133,46,146,89,165,24,133,76,201,133,68,176,74,162,24,251,26,19,1,121,82,113,114,70,43,41,164,226,166,95,91,245,184,2,220,180,139,254,104,199,252,133,205,241,59,203,224,232,56,158,50,94,255,217,224,92,254,147,221,189,139,119,223,1,12,208,201,151,101,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6167808-425a-4541-a89f-19118a685830"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df97a40d-caba-46d0-ae3b-3ab77b3aa563"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b70e85c0-915b-4104-b121-b468de8a4637"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("223eb29e-364a-44cc-becc-69e01425be9c"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("656b1ea1-bac6-4518-8006-2d3d95f56bed"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ec808db1-3f0a-4038-a26b-446f2935c069"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da"),
				UId = new Guid("f5fc4e93-92c3-47f2-a1dc-a5ba89846ff7"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("92813432-e952-427c-b775-57f77d398b6d"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("2ef81675-328b-4e33-8a16-6a0df1006683"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("2f91fd7b-c25b-45ae-ac98-c772e1c88493"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("3a06c5c6-afac-4bd1-9115-551805b1f7bb"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("af6a486a-47e5-47a2-85fe-6687125e74bd"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("32bf5acf-9862-459e-a98e-55e6f938cfb2"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ReferenceSchemaUId = new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da"),
				UId = new Guid("fc23f180-56cd-4e39-a2cf-d3dad81c0dd1"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be278a15-6327-41b0-a4a8-6c2d57c5a3cc"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9105f6d4-f8a4-4fc1-b550-632a6cf66f9a"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("dee58147-a6a2-4c39-9f81-0ca6adefb533"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("de1fa507-72c5-48f9-adaa-9e7bd218c5b5"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("9368f221-436d-4df7-8b76-c98cf6d025a9"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65d9b230-45b3-4daa-bb41-9096e6b07169"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a461b0ff-7cf6-4abc-aab6-8c25d8833b2b"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,93,111,211,48,20,253,43,83,158,231,41,77,243,217,55,84,10,218,11,155,88,181,23,178,135,27,251,38,181,72,226,200,118,6,165,234,127,231,58,105,67,135,138,86,144,16,248,201,62,58,62,247,220,175,157,199,107,48,230,3,52,232,45,188,53,106,13,70,149,246,230,157,172,45,234,247,90,245,157,119,237,25,212,18,106,249,13,197,136,175,132,180,111,193,2,125,217,229,63,20,114,111,145,159,215,200,189,235,220,147,22,27,67,28,250,146,4,193,44,200,178,128,241,104,46,88,56,19,130,21,89,148,48,159,67,152,198,113,130,5,47,70,230,175,196,151,170,233,64,227,24,99,144,47,135,235,122,219,57,234,140,0,62,80,164,81,237,1,156,59,19,102,213,66,81,163,160,183,213,61,18,100,181,108,40,27,92,203,6,239,65,83,44,167,163,28,68,164,18,106,227,88,53,150,118,245,181,211,104,140,84,237,107,230,234,190,105,79,217,36,128,211,243,96,199,31,60,58,230,61,216,205,32,113,75,182,246,131,203,55,85,165,177,2,43,159,79,77,124,198,237,192,187,172,126,244,65,80,151,30,161,238,241,36,230,203,76,150,208,217,49,161,49,60,17,180,172,54,23,231,58,85,236,181,116,3,2,187,35,249,66,205,179,57,4,49,129,207,14,24,85,142,215,220,251,116,107,238,190,180,168,31,248,6,27,24,171,246,116,67,232,79,192,164,191,216,37,60,245,99,140,4,43,231,126,200,194,136,110,69,128,33,203,80,68,144,242,52,45,125,190,127,26,125,72,211,213,176,125,156,194,45,193,224,213,71,228,74,139,171,161,115,238,184,2,171,74,114,168,239,58,212,212,192,161,128,254,249,209,123,49,179,46,45,173,148,29,205,78,101,113,81,134,248,199,230,135,133,40,131,216,47,88,81,22,25,11,5,247,25,136,176,100,126,40,202,196,159,69,25,240,136,204,208,222,186,202,61,168,94,243,195,158,152,113,97,255,104,17,255,193,122,253,206,198,156,157,217,75,102,80,252,15,211,245,55,39,103,239,237,191,3,17,107,186,229,230,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3ef5ba64-31d5-408a-91cd-c4b705177d41"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,110,219,48,12,253,21,195,237,49,12,44,75,178,44,95,219,14,8,208,110,69,179,245,210,228,64,75,84,107,192,177,11,75,233,208,5,249,247,41,78,210,54,221,118,154,14,50,68,243,61,146,79,79,155,244,60,188,62,83,90,165,223,105,24,208,247,46,76,47,250,129,166,183,67,111,200,251,233,117,111,176,109,126,97,221,210,45,14,184,162,64,195,61,182,107,242,215,141,15,147,228,20,150,78,210,243,151,241,111,90,61,108,210,89,160,213,143,153,141,236,178,116,69,157,151,53,152,90,18,136,66,230,80,154,130,129,85,121,169,115,172,107,225,202,8,54,125,187,94,117,55,20,240,22,195,83,90,109,210,145,45,18,160,98,104,145,16,184,40,4,8,75,4,59,16,24,133,146,75,33,51,180,42,221,78,82,111,158,104,133,99,209,119,48,99,202,242,220,105,40,115,37,65,72,46,160,20,140,1,51,69,193,152,52,164,141,221,129,15,249,239,192,135,179,135,153,255,246,179,163,97,62,242,86,14,91,79,203,105,140,126,10,92,181,180,162,46,84,27,166,12,149,84,58,208,89,89,130,64,87,0,58,169,65,41,205,184,211,150,202,140,111,35,224,77,205,106,227,164,51,130,52,7,157,27,14,66,185,28,144,89,3,40,107,44,117,41,10,231,212,14,114,213,133,38,188,94,140,26,85,27,201,52,21,130,12,24,158,57,16,117,212,166,206,172,130,130,152,230,153,150,133,200,104,187,60,91,238,6,179,141,127,110,241,245,254,207,249,238,8,109,226,49,52,222,161,9,77,223,37,45,189,80,155,88,12,56,253,210,12,62,36,77,188,197,164,119,201,64,126,221,134,166,123,76,226,53,181,52,102,79,231,1,195,218,239,171,60,159,24,228,99,157,205,98,239,179,69,90,45,254,229,180,195,119,175,235,169,215,62,219,108,145,78,22,233,188,95,15,102,199,200,227,225,242,195,128,99,145,49,229,211,241,232,171,24,233,214,109,123,136,92,198,73,143,137,199,112,111,27,215,144,157,117,243,163,157,70,150,236,176,224,47,219,113,237,123,251,31,216,13,118,248,72,195,215,40,192,123,239,111,93,126,143,50,30,137,235,92,203,76,49,7,138,80,131,160,34,190,42,203,16,52,211,181,227,42,90,222,229,35,250,142,28,13,212,25,58,109,76,107,199,101,198,56,20,181,194,104,60,91,64,45,68,6,196,29,195,172,70,173,153,57,224,253,168,246,238,65,31,250,218,73,181,77,183,219,229,246,55,20,247,87,35,68,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d51b136d-f674-45ae-991e-74dc6a36e5a5"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,201,142,211,64,16,253,21,203,231,113,228,125,201,13,133,128,230,194,140,152,104,46,120,14,229,118,217,105,209,94,212,221,30,8,145,255,157,106,59,9,25,20,52,1,9,113,192,39,251,233,85,213,171,229,121,111,51,1,74,125,128,6,237,165,189,65,41,65,117,149,94,188,227,66,163,124,47,187,161,183,111,108,133,146,131,224,223,176,156,241,117,201,245,91,208,64,33,251,252,71,134,220,94,230,151,115,228,246,77,110,115,141,141,34,14,133,68,89,230,167,94,225,57,232,65,236,132,177,235,57,16,103,232,164,101,84,122,73,16,49,72,146,153,249,171,228,171,174,233,65,226,92,99,74,95,77,175,155,93,111,168,30,1,108,162,112,213,181,7,48,48,34,212,186,133,66,96,73,223,90,14,72,144,150,188,161,110,112,195,27,188,7,73,181,76,158,206,64,68,170,64,40,195,18,88,233,245,215,94,162,82,188,107,95,19,39,134,166,61,103,83,2,60,125,30,228,184,147,70,195,188,7,189,157,82,220,146,172,113,82,249,166,174,37,214,160,249,243,185,136,207,184,155,120,215,205,143,2,74,218,210,35,136,1,207,106,190,236,100,5,189,158,27,154,203,19,65,242,122,123,117,175,167,137,189,214,174,79,96,127,36,95,153,243,98,15,126,76,224,179,1,230,44,199,215,220,254,116,171,238,190,180,40,31,216,22,27,152,167,246,180,32,244,39,96,45,176,193,86,47,247,101,1,69,92,68,224,48,47,43,157,48,138,75,26,97,226,58,69,144,250,16,167,97,150,86,222,72,1,39,65,203,61,36,200,18,132,208,97,24,21,78,88,197,169,147,70,180,137,168,96,133,91,121,129,7,145,111,66,214,173,230,122,55,95,2,69,161,139,33,173,197,97,97,22,81,20,38,14,4,84,50,128,34,241,147,20,189,216,75,198,167,185,93,174,122,1,187,199,83,87,31,17,74,139,129,66,203,76,194,34,95,73,165,45,227,38,171,171,44,26,242,32,52,111,107,139,110,73,32,51,203,92,76,119,100,30,179,238,174,230,12,196,93,143,146,206,105,90,167,123,217,8,47,28,100,134,44,187,78,207,163,59,45,105,69,58,38,153,199,83,164,66,244,135,48,202,30,186,65,178,131,35,213,252,107,248,35,203,255,3,35,255,142,55,47,186,227,154,107,255,159,238,120,52,207,95,58,190,209,30,191,3,249,242,79,43,183,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe0fa648-3fc3-4ce1-a8d3-1681f04a67c9"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ae404d44-60d7-4e4b-8282-762b27d3a152"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("8763f1ba-63c6-4753-87a2-dbaeb9ea40d3"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("9eda2b32-157f-4e17-b87c-cc0782b8e875"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d2adb4a4-eb38-4950-aadd-fdeebf093883"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("6c320b14-8f29-402a-a272-3d4d451107ba"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,43,205,77,74,45,178,50,180,50,4,0,62,85,105,155,10,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("b3c152f3-8f5d-4ccd-a444-d697a2992b1a"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("919f3607-18a5-44b4-b8c5-a553b21c63f7"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("275b1604-78cd-4f80-ad1a-dbb6afbae187"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("58b416b7-18b4-43de-b90e-b775fc705598"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("18226361-e716-427e-8881-44a4fbfcbcbc"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("acdae03e-04e7-470b-acab-80f8b02cde3d"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("98406230-ae2f-4d18-934d-4512830c3860"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4ed4d571-44c8-4a27-a65a-4131b67102cd"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("b38a94a0-f6e4-4feb-8786-12e8b069d09b"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a4fde4e6-b89d-4d7a-9c00-a5b453b8f484"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("2dd75492-fff2-4a42-8113-1363e4c5f0d4"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("b89ce4b1-992d-429f-80d8-91c514f034b4"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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

		protected virtual void InitializeChangeDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("838069b1-290a-4dfe-8a76-789d0b22ee56"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9aae8482-6a87-492c-a2eb-c2cc69f1a33a"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7f1e55bc-3c69-4e8d-ab13-4c60e7f1c2b5"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,149,128,231,40,80,44,201,150,125,43,92,183,200,165,9,26,35,151,42,135,53,181,146,137,82,162,64,82,105,93,195,255,222,37,105,171,78,225,34,110,128,160,21,116,32,7,195,217,217,215,150,113,9,198,124,130,6,217,140,45,81,107,48,170,178,87,31,132,180,168,63,106,213,119,236,146,25,212,2,164,248,129,101,192,23,165,176,239,193,2,61,217,22,191,20,10,54,43,78,107,20,236,178,96,194,98,99,136,67,79,82,200,98,184,230,85,52,141,87,16,165,201,132,71,211,36,47,35,28,39,201,56,201,232,159,76,3,243,79,226,115,213,116,160,49,196,240,242,149,63,46,55,157,163,94,19,192,61,69,24,213,238,193,196,153,48,139,22,86,18,75,186,91,221,35,65,86,139,134,178,193,165,104,240,14,52,197,114,58,202,65,68,170,64,26,199,146,88,217,197,247,78,163,49,66,181,47,153,147,125,211,30,179,73,0,135,235,222,78,236,61,58,230,29,216,181,151,184,33,91,59,239,242,93,93,107,172,193,138,167,99,19,95,113,227,121,231,213,143,30,148,212,165,7,144,61,30,197,124,158,201,28,58,27,18,10,225,137,160,69,189,62,59,215,161,98,47,165,59,34,176,59,144,207,212,60,153,195,104,76,224,147,3,130,202,225,88,176,47,55,230,246,91,139,250,158,175,177,129,80,181,199,43,66,127,3,6,253,217,118,194,243,120,140,89,25,85,73,156,70,105,70,167,213,8,211,104,138,101,6,57,207,243,42,230,187,199,224,67,152,78,194,230,97,8,55,7,131,23,159,145,43,93,94,248,206,185,207,21,88,213,130,131,188,237,80,83,3,125,1,227,211,163,247,108,102,93,90,90,41,27,204,14,101,113,81,124,252,67,243,41,16,237,164,171,202,189,234,53,223,239,128,9,203,248,170,37,251,7,171,243,55,219,112,114,30,207,153,175,242,127,152,156,183,156,138,29,219,253,4,56,110,94,215,194,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("75fd7f6c-28fc-4c7c-bf17-b30ef4fedf91"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,77,111,163,48,20,252,43,200,237,49,142,48,24,48,185,182,151,72,237,42,106,178,185,148,30,30,246,243,22,137,143,200,152,74,217,136,255,190,134,64,211,68,221,203,174,15,32,63,222,140,231,205,224,19,185,183,199,3,146,21,217,161,49,208,54,218,46,31,26,131,203,141,105,36,182,237,242,169,145,80,22,191,33,47,113,3,6,42,180,104,246,80,118,216,62,21,173,93,120,215,48,178,32,247,31,227,87,178,122,61,145,181,197,234,231,90,57,118,161,133,47,67,145,80,197,49,167,156,137,156,10,205,99,202,164,200,85,148,112,157,198,129,3,203,166,236,170,250,25,45,108,192,190,147,213,137,140,108,142,0,89,192,82,166,53,13,4,99,148,135,190,162,128,18,104,2,156,135,17,242,156,229,41,233,23,164,149,239,88,193,120,232,5,204,88,162,194,64,167,84,4,73,68,121,20,114,42,184,163,97,50,142,25,139,36,166,82,13,224,169,255,2,124,189,219,30,219,61,152,98,152,127,249,208,25,131,181,125,4,139,187,162,194,187,183,1,163,138,246,80,194,113,255,45,212,205,239,125,220,192,189,1,235,65,173,188,129,232,76,114,184,178,246,43,205,41,59,39,148,145,85,246,183,140,166,247,118,28,253,58,165,219,128,50,178,200,200,182,233,140,28,24,67,183,121,252,162,127,60,100,108,185,217,206,137,184,74,221,149,229,84,113,250,97,110,156,203,141,42,116,129,106,93,111,231,32,70,22,127,90,244,155,199,188,206,218,254,7,246,12,53,252,66,243,195,25,112,209,254,169,114,231,108,156,137,85,192,48,69,205,169,244,99,78,185,207,2,154,7,34,166,26,24,8,150,48,229,126,171,17,253,130,26,93,106,18,255,81,216,11,182,163,219,195,85,152,116,13,86,245,164,239,223,250,63,244,80,4,92,126,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadDataUserTask5Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a822ce2-db65-4f4c-9559-c00347db1b23"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,75,143,211,48,16,254,43,85,206,235,170,73,243,106,111,168,20,180,23,118,69,87,123,33,123,152,216,147,212,194,121,200,118,22,74,149,255,206,56,105,75,23,21,109,65,66,28,240,201,254,244,205,204,55,47,239,61,174,192,152,15,80,161,183,244,30,80,107,48,77,97,167,239,164,178,168,223,235,166,107,189,27,207,160,150,160,228,55,20,35,190,22,210,190,5,11,100,178,207,126,120,200,188,101,118,217,71,230,221,100,158,180,88,25,226,144,73,33,18,17,228,98,193,114,14,62,11,163,52,96,41,23,130,129,239,47,18,17,5,137,207,231,35,243,87,206,87,77,213,130,198,49,198,224,190,24,174,15,187,214,81,125,2,248,64,145,166,169,15,224,220,137,48,235,26,114,133,130,222,86,119,72,144,213,178,162,108,240,65,86,120,15,154,98,57,63,141,131,136,84,128,50,142,165,176,176,235,175,173,70,99,100,83,191,38,78,117,85,125,206,38,7,120,122,30,228,204,6,141,142,121,15,118,59,184,184,37,89,253,160,242,77,89,106,44,193,202,231,115,17,159,113,55,240,174,171,31,25,8,234,210,35,168,14,207,98,190,204,100,5,173,29,19,26,195,19,65,203,114,123,117,174,167,138,189,150,110,64,96,123,36,95,233,243,98,14,65,76,224,179,3,70,47,199,107,230,125,186,53,119,95,106,212,27,190,197,10,198,170,61,77,9,253,9,88,43,172,176,182,203,61,135,56,159,113,31,89,81,68,41,11,103,116,91,228,2,88,42,146,88,196,105,28,165,126,220,147,193,73,208,114,159,207,185,31,5,197,156,165,69,36,88,200,57,85,61,12,67,38,226,69,2,193,98,17,228,62,56,147,117,109,165,221,141,147,176,220,67,226,131,0,4,54,15,227,144,133,2,145,229,121,88,48,158,64,52,143,194,104,6,34,233,159,198,116,165,105,21,236,30,79,89,125,68,16,19,14,6,39,198,130,237,12,45,150,54,118,226,214,105,210,20,19,170,114,167,172,172,203,9,13,147,66,238,186,57,221,12,76,26,38,119,92,207,155,82,114,80,119,45,106,154,169,161,167,179,203,219,240,98,141,92,165,117,211,216,177,126,167,78,173,72,204,49,194,217,84,82,56,250,44,92,187,54,77,167,249,97,57,205,248,75,252,209,246,255,131,157,254,157,53,189,184,40,215,12,254,255,52,210,189,59,127,117,4,123,175,255,14,53,44,32,79,200,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("94072bca-6162-4e8e-b862-b76f105bc46a"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5c651444-a144-4931-821b-e26e9fb71f60"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("d6933145-11a6-41e0-a083-8e3d0f5cb15f"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("41bdacb0-38ba-4c89-b2bd-9e26c44910c6"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0f225841-4a24-46aa-9ab5-c60099fe3a63"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("e30c8bb4-f01c-440f-8a45-b98eb8058e08"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,75,204,77,181,50,180,50,4,0,127,229,4,95,8,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("82d3dd51-cb6e-431e-b725-0622ebd71499"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1397425e-4ae0-4803-9260-930a308717ad"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("3bbdd8db-b7fb-45ce-a565-73afafc90561"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("1a775799-e9f7-4e06-9c16-7b002d6e9c48"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("a39c131b-b8b8-409b-b619-3e350352fc5e"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("2f2d12aa-73bf-4cc5-9ed8-61b85e547204"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("2d5e1b39-c1bd-463e-aa87-b6982b2c0502"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ecdc24d5-dc69-4e45-9cdc-bbbc660c2d5e"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("93186690-48ea-44b2-a2cf-18064e1d9d6d"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc93e612-6e5f-4209-89e2-bf47d63b7bf2"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("75936d03-8b14-4b5b-ad52-ea3ae6501d35"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("6ab22a53-ba74-4fe1-9b06-5d4dda97b845"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaStartEvent startevent1 = CreateStartEvent1StartEvent();
			FlowElements.Add(startevent1);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			ProcessSchemaUserTask readdatausertask5 = CreateReadDataUserTask5UserTask();
			FlowElements.Add(readdatausertask5);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8c28c284-86be-46b8-b2e6-f127f4feec81"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("83737d09-45d0-40fd-9630-7d18b9e17546"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("738ffaeb-4a93-4ede-99d2-a18ebefe310d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(417, 261));
			schemaFlow.PolylinePointPositions.Add(new Point(1406, 261));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("e7bc3b23-71ca-41a9-a7d7-73a1b7c38399"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{9b9bf88c-1372-47f8-9d44-ebeaec7db7c0}].[Parameter:{7092f775-9a72-4aaf-b608-e2668011359f}].[EntityColumn:{98771b3f-7dbe-4b12-a017-0ab8d406a02a}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(417, 148));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("34efd614-e31d-4208-b42f-1c9207feaceb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("97d8cfff-02dd-47e0-ab08-ab86e99a853e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("6d531419-b788-4cf5-9023-81bd006b0421"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("5a9762ab-9fb2-4607-92d8-972d548892b2"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{17ce8e8f-9088-4af6-af59-77913f9de803}].[Parameter:{f5fc4e93-92c3-47f2-a1dc-a5ba89846ff7}].[EntityColumn:{519e64ec-c30f-4bea-b0d7-6e193095640e}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(601, 91));
			schemaFlow.PolylinePointPositions.Add(new Point(1406, 91));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b5c8bbf2-28c0-4bcd-811a-ea6ebe0336f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f8502a0-3594-4b8f-977d-f540357b0266"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("4c1ae41c-a832-4454-9f59-95e8303e57f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1092, 217));
			schemaFlow.PolylinePointPositions.Add(new Point(1406, 217));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("b12f7964-a59e-4b0d-b921-f24173ada1db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow3",
				UId = new Guid("43d68cc9-41d1-4662-a26b-62bb02a1f91a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{de73a61b-399c-4391-9e63-7eff8e68c02f}].[Parameter:{82d3dd51-cb6e-431e-b725-0622ebd71499}].[EntityColumn:{b78647f6-76db-4d25-b665-00fce475324e}]#] == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("fa228622-278b-4c12-b91f-ed2309e9c835"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1331, 148));
			schemaFlow.PolylinePointPositions.Add(new Point(1331, 173));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("838a62a1-26d2-4951-932f-58f4cb859319"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("033cef62-157b-4804-9ded-0bba90f7da42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("033cef62-157b-4804-9ded-0bba90f7da42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"Terminate1",
				Position = new Point(1393, 160),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask1",
				Position = new Point(137, 176),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask2",
				Position = new Point(260, 176),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ExclusiveGateway1",
				Position = new Point(390, 176),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask3",
				Position = new Point(467, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(680, 121),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ExclusiveGateway2",
				Position = new Point(574, 121),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartEvent CreateStartEvent1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("6f8502a0-3594-4b8f-977d-f540357b0266"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"StartEvent1",
				Position = new Point(56, 190),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ExclusiveGateway3",
				Position = new Point(1065, 121),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask4",
				Position = new Point(810, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ChangeDataUserTask2",
				Position = new Point(1200, 121),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask5UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask5",
				Position = new Point(926, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask5Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new AnalyzeCaseSatisfactionLevel(userConnection);
		}

		public override object Clone() {
			return new AnalyzeCaseSatisfactionLevelSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"));
		}

		#endregion

	}

	#endregion

	#region Class: AnalyzeCaseSatisfactionLevel

	/// <exclude/>
	public class AnalyzeCaseSatisfactionLevel : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,83,203,110,219,48,16,252,149,64,231,48,208,131,146,37,223,10,215,45,114,105,130,198,200,165,202,97,69,173,100,162,146,40,144,84,90,215,240,191,119,41,217,142,83,184,136,219,75,47,213,137,26,12,103,103,150,187,91,79,52,96,204,39,104,209,155,123,43,212,26,140,170,236,205,7,217,88,212,31,181,26,122,239,218,51,168,37,52,242,7,150,19,190,44,165,125,15,22,232,202,54,127,81,200,189,121,126,94,35,247,174,115,79,90,108,13,113,232,74,26,37,101,86,241,144,249,65,150,48,158,196,21,131,25,15,152,192,178,76,179,168,202,66,62,155,152,191,19,95,168,182,7,141,83,141,81,190,26,143,171,77,239,168,1,1,98,164,72,163,186,61,24,57,19,102,217,65,209,96,73,255,86,15,72,144,213,178,165,52,184,146,45,222,131,166,90,78,71,57,136,72,21,52,198,177,26,172,236,242,123,175,209,24,169,186,183,204,53,67,219,157,178,73,0,143,191,123,59,254,232,209,49,239,193,174,71,137,91,178,181,27,93,190,171,107,141,53,88,249,124,106,226,43,110,70,222,101,253,163,11,37,189,210,35,52,3,158,212,124,157,100,1,189,157,2,77,229,137,160,101,189,190,56,235,177,99,111,197,13,9,236,15,228,11,53,207,102,8,19,2,159,29,48,169,28,142,185,247,229,214,220,125,235,80,63,136,53,182,48,117,237,233,134,208,95,128,163,254,124,59,19,169,159,96,92,178,42,242,57,227,49,157,138,16,57,203,176,140,33,21,105,90,249,98,247,52,249,144,166,111,96,243,120,44,183,0,131,87,159,81,40,93,94,141,47,231,62,215,96,85,75,1,205,93,143,154,30,112,108,160,127,126,244,94,205,172,139,165,149,178,147,217,99,91,92,149,177,254,225,241,5,86,179,40,11,2,6,105,26,50,30,241,152,21,81,28,178,48,42,82,206,41,78,26,20,100,134,246,214,117,238,65,13,90,236,247,196,76,11,251,87,139,248,15,214,235,79,54,230,236,204,94,50,131,255,167,11,221,176,236,126,2,90,144,37,197,10,6,0,0 })));
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

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })));
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
								new Guid("117d32f9-8275-4534-8411-1c66115ce9cd")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"));
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

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,201,110,219,48,16,253,21,65,231,48,208,66,109,190,21,169,91,228,210,4,77,144,75,157,195,144,28,57,68,181,129,164,210,186,134,255,189,67,41,113,157,194,69,220,94,10,20,213,137,122,120,243,248,102,227,54,148,13,88,251,1,90,12,23,225,45,26,3,182,175,221,249,59,221,56,52,239,77,63,14,225,89,104,209,104,104,244,55,84,51,190,84,218,189,5,7,20,178,93,253,80,88,133,139,213,113,141,85,120,182,10,181,195,214,18,135,66,106,153,2,47,35,100,81,92,32,227,153,82,172,204,146,140,37,74,96,84,69,188,148,74,205,204,95,137,95,244,237,0,6,231,59,38,249,122,58,222,110,6,79,141,9,144,19,69,219,190,123,2,83,111,194,46,59,16,13,122,121,103,70,36,200,25,221,82,54,120,171,91,188,6,67,119,121,157,222,67,68,170,161,177,158,213,96,237,150,95,7,131,214,234,190,123,205,92,51,182,221,33,155,4,112,255,251,100,39,154,60,122,230,53,184,135,73,226,146,108,237,38,151,111,214,107,131,107,112,250,241,208,196,103,220,76,188,211,234,71,1,138,186,116,7,205,136,7,119,190,204,228,2,6,55,39,52,95,79,4,163,215,15,39,231,186,175,216,107,233,38,4,14,207,228,19,53,143,230,144,228,4,62,122,96,86,121,62,174,194,79,151,246,234,75,135,230,70,62,96,11,115,213,238,207,9,253,9,88,54,216,98,231,22,91,37,64,228,34,3,38,227,74,81,29,115,170,163,42,34,38,210,50,129,188,228,85,89,199,59,10,216,27,90,108,161,64,89,32,112,38,49,19,140,215,121,73,165,23,49,203,132,20,81,29,167,49,100,137,15,89,118,78,187,205,60,9,62,42,6,5,8,44,229,57,103,92,33,50,33,120,205,100,1,89,154,241,44,2,85,236,238,231,116,181,29,26,216,220,237,179,250,136,160,2,9,22,3,95,137,128,246,202,88,23,248,109,10,250,58,160,34,143,141,211,221,58,160,89,106,80,250,102,158,223,56,112,163,157,228,124,79,73,36,149,188,204,161,146,44,201,202,132,241,34,79,88,37,233,151,167,41,212,113,93,149,60,246,179,231,63,63,34,253,90,75,104,174,6,52,52,130,211,8,68,199,151,231,197,214,249,198,152,190,119,115,185,247,141,189,32,239,7,142,158,135,88,196,89,90,69,69,205,80,70,64,149,44,75,86,169,12,25,102,149,64,153,166,136,85,77,150,232,253,241,121,223,244,163,145,79,251,110,231,135,231,143,30,148,191,240,76,252,206,230,31,221,189,83,118,233,255,150,192,191,179,37,187,112,247,29,78,13,231,206,154,7,0,0 })));
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
								new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"));
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

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,93,111,211,48,20,253,43,81,158,231,41,78,226,38,233,27,26,5,77,66,108,98,19,47,116,15,215,206,117,23,225,124,200,118,7,165,234,127,231,58,217,74,135,138,86,120,1,137,60,197,71,199,199,231,126,110,99,101,192,185,247,208,98,60,143,111,209,90,112,189,246,231,111,26,227,209,190,181,253,122,136,207,98,135,182,1,211,124,195,122,194,23,117,227,95,131,7,186,178,93,254,80,88,198,243,229,113,141,101,124,182,140,27,143,173,35,14,93,17,105,33,11,72,50,166,121,13,44,79,211,154,73,212,57,195,50,7,149,241,66,21,101,58,49,127,37,126,209,183,3,88,156,222,24,229,245,248,123,187,25,2,149,19,160,70,74,227,250,238,17,204,130,9,183,232,64,26,172,233,236,237,26,9,242,182,105,41,26,188,109,90,188,6,75,111,5,157,62,64,68,210,96,92,96,25,212,126,241,117,176,232,92,211,119,47,153,51,235,182,59,100,147,0,238,143,143,118,146,209,99,96,94,131,191,31,37,46,201,214,110,116,249,106,181,178,184,2,223,60,28,154,248,140,155,145,119,90,254,232,66,77,85,250,8,102,141,7,111,62,143,228,2,6,63,5,52,61,79,4,219,172,238,79,142,117,159,177,151,194,77,9,28,158,200,39,106,30,141,33,157,17,248,16,128,73,229,233,119,25,127,186,116,87,95,58,180,55,234,30,91,152,178,118,119,78,232,79,192,194,96,139,157,159,111,107,9,114,38,5,48,197,171,154,229,98,86,179,178,46,18,38,179,50,133,89,153,87,165,230,59,186,176,55,52,223,66,129,170,64,200,153,66,33,89,174,103,37,43,133,228,76,72,37,19,205,51,14,34,13,87,22,157,111,252,102,234,132,249,86,41,173,132,150,154,229,181,170,88,94,96,206,42,174,51,38,114,132,42,21,28,36,47,119,119,83,184,141,27,12,108,62,238,163,250,128,80,71,10,28,70,33,19,17,205,149,117,62,10,211,20,245,58,162,36,175,141,111,186,85,68,189,100,80,133,98,158,223,80,227,56,13,227,33,50,248,128,102,148,14,245,37,193,186,168,80,128,200,88,9,21,117,15,240,138,162,150,148,132,154,167,57,231,149,76,32,167,62,12,95,104,151,126,213,40,48,87,3,90,82,29,219,33,57,62,72,207,38,48,20,201,246,189,159,82,191,47,242,161,179,119,123,99,79,125,205,133,46,146,89,165,24,133,76,201,133,68,176,74,162,24,251,26,19,1,121,82,113,114,70,43,41,164,226,166,95,91,245,184,2,220,180,139,254,104,199,252,133,205,241,59,203,224,232,56,158,50,94,255,217,224,92,254,147,221,189,139,119,223,1,12,208,201,151,101,7,0,0 })));
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
								new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da"));
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("Status").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("StatusId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,93,111,211,48,20,253,43,83,158,231,41,77,243,217,55,84,10,218,11,155,88,181,23,178,135,27,251,38,181,72,226,200,118,6,165,234,127,231,58,105,67,135,138,86,144,16,248,201,62,58,62,247,220,175,157,199,107,48,230,3,52,232,45,188,53,106,13,70,149,246,230,157,172,45,234,247,90,245,157,119,237,25,212,18,106,249,13,197,136,175,132,180,111,193,2,125,217,229,63,20,114,111,145,159,215,200,189,235,220,147,22,27,67,28,250,146,4,193,44,200,178,128,241,104,46,88,56,19,130,21,89,148,48,159,67,152,198,113,130,5,47,70,230,175,196,151,170,233,64,227,24,99,144,47,135,235,122,219,57,234,140,0,62,80,164,81,237,1,156,59,19,102,213,66,81,163,160,183,213,61,18,100,181,108,40,27,92,203,6,239,65,83,44,167,163,28,68,164,18,106,227,88,53,150,118,245,181,211,104,140,84,237,107,230,234,190,105,79,217,36,128,211,243,96,199,31,60,58,230,61,216,205,32,113,75,182,246,131,203,55,85,165,177,2,43,159,79,77,124,198,237,192,187,172,126,244,65,80,151,30,161,238,241,36,230,203,76,150,208,217,49,161,49,60,17,180,172,54,23,231,58,85,236,181,116,3,2,187,35,249,66,205,179,57,4,49,129,207,14,24,85,142,215,220,251,116,107,238,190,180,168,31,248,6,27,24,171,246,116,67,232,79,192,164,191,216,37,60,245,99,140,4,43,231,126,200,194,136,110,69,128,33,203,80,68,144,242,52,45,125,190,127,26,125,72,211,213,176,125,156,194,45,193,224,213,71,228,74,139,171,161,115,238,184,2,171,74,114,168,239,58,212,212,192,161,128,254,249,209,123,49,179,46,45,173,148,29,205,78,101,113,81,134,248,199,230,135,133,40,131,216,47,88,81,22,25,11,5,247,25,136,176,100,126,40,202,196,159,69,25,240,136,204,208,222,186,202,61,168,94,243,195,158,152,113,97,255,104,17,255,193,122,253,206,198,156,157,217,75,102,80,252,15,211,245,55,39,103,239,237,191,3,17,107,186,229,230,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,110,219,48,12,253,21,195,237,49,12,44,75,178,44,95,219,14,8,208,110,69,179,245,210,228,64,75,84,107,192,177,11,75,233,208,5,249,247,41,78,210,54,221,118,154,14,50,68,243,61,146,79,79,155,244,60,188,62,83,90,165,223,105,24,208,247,46,76,47,250,129,166,183,67,111,200,251,233,117,111,176,109,126,97,221,210,45,14,184,162,64,195,61,182,107,242,215,141,15,147,228,20,150,78,210,243,151,241,111,90,61,108,210,89,160,213,143,153,141,236,178,116,69,157,151,53,152,90,18,136,66,230,80,154,130,129,85,121,169,115,172,107,225,202,8,54,125,187,94,117,55,20,240,22,195,83,90,109,210,145,45,18,160,98,104,145,16,184,40,4,8,75,4,59,16,24,133,146,75,33,51,180,42,221,78,82,111,158,104,133,99,209,119,48,99,202,242,220,105,40,115,37,65,72,46,160,20,140,1,51,69,193,152,52,164,141,221,129,15,249,239,192,135,179,135,153,255,246,179,163,97,62,242,86,14,91,79,203,105,140,126,10,92,181,180,162,46,84,27,166,12,149,84,58,208,89,89,130,64,87,0,58,169,65,41,205,184,211,150,202,140,111,35,224,77,205,106,227,164,51,130,52,7,157,27,14,66,185,28,144,89,3,40,107,44,117,41,10,231,212,14,114,213,133,38,188,94,140,26,85,27,201,52,21,130,12,24,158,57,16,117,212,166,206,172,130,130,152,230,153,150,133,200,104,187,60,91,238,6,179,141,127,110,241,245,254,207,249,238,8,109,226,49,52,222,161,9,77,223,37,45,189,80,155,88,12,56,253,210,12,62,36,77,188,197,164,119,201,64,126,221,134,166,123,76,226,53,181,52,102,79,231,1,195,218,239,171,60,159,24,228,99,157,205,98,239,179,69,90,45,254,229,180,195,119,175,235,169,215,62,219,108,145,78,22,233,188,95,15,102,199,200,227,225,242,195,128,99,145,49,229,211,241,232,171,24,233,214,109,123,136,92,198,73,143,137,199,112,111,27,215,144,157,117,243,163,157,70,150,236,176,224,47,219,113,237,123,251,31,216,13,118,248,72,195,215,40,192,123,239,111,93,126,143,50,30,137,235,92,203,76,49,7,138,80,131,160,34,190,42,203,16,52,211,181,227,42,90,222,229,35,250,142,28,13,212,25,58,109,76,107,199,101,198,56,20,181,194,104,60,91,64,45,68,6,196,29,195,172,70,173,153,57,224,253,168,246,238,65,31,250,218,73,181,77,183,219,229,246,55,20,247,87,35,68,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "01896e873e4246cf8f019781cacfce12",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
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

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,201,142,211,64,16,253,21,203,231,113,228,125,201,13,133,128,230,194,140,152,104,46,120,14,229,118,217,105,209,94,212,221,30,8,145,255,157,106,59,9,25,20,52,1,9,113,192,39,251,233,85,213,171,229,121,111,51,1,74,125,128,6,237,165,189,65,41,65,117,149,94,188,227,66,163,124,47,187,161,183,111,108,133,146,131,224,223,176,156,241,117,201,245,91,208,64,33,251,252,71,134,220,94,230,151,115,228,246,77,110,115,141,141,34,14,133,68,89,230,167,94,225,57,232,65,236,132,177,235,57,16,103,232,164,101,84,122,73,16,49,72,146,153,249,171,228,171,174,233,65,226,92,99,74,95,77,175,155,93,111,168,30,1,108,162,112,213,181,7,48,48,34,212,186,133,66,96,73,223,90,14,72,144,150,188,161,110,112,195,27,188,7,73,181,76,158,206,64,68,170,64,40,195,18,88,233,245,215,94,162,82,188,107,95,19,39,134,166,61,103,83,2,60,125,30,228,184,147,70,195,188,7,189,157,82,220,146,172,113,82,249,166,174,37,214,160,249,243,185,136,207,184,155,120,215,205,143,2,74,218,210,35,136,1,207,106,190,236,100,5,189,158,27,154,203,19,65,242,122,123,117,175,167,137,189,214,174,79,96,127,36,95,153,243,98,15,126,76,224,179,1,230,44,199,215,220,254,116,171,238,190,180,40,31,216,22,27,152,167,246,180,32,244,39,96,45,176,193,86,47,247,101,1,69,92,68,224,48,47,43,157,48,138,75,26,97,226,58,69,144,250,16,167,97,150,86,222,72,1,39,65,203,61,36,200,18,132,208,97,24,21,78,88,197,169,147,70,180,137,168,96,133,91,121,129,7,145,111,66,214,173,230,122,55,95,2,69,161,139,33,173,197,97,97,22,81,20,38,14,4,84,50,128,34,241,147,20,189,216,75,198,167,185,93,174,122,1,187,199,83,87,31,17,74,139,129,66,203,76,194,34,95,73,165,45,227,38,171,171,44,26,242,32,52,111,107,139,110,73,32,51,203,92,76,119,100,30,179,238,174,230,12,196,93,143,146,206,105,90,167,123,217,8,47,28,100,134,44,187,78,207,163,59,45,105,69,58,38,153,199,83,164,66,244,135,48,202,30,186,65,178,131,35,213,252,107,248,35,203,255,3,35,255,142,55,47,186,227,154,107,255,159,238,120,52,207,95,58,190,209,30,191,3,249,242,79,43,183,6,0,0 })));
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

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,43,205,77,74,45,178,50,180,50,4,0,62,85,105,155,10,0,0,0 })));
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
								new Guid("117d32f9-8275-4534-8411-1c66115ce9cd")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeDataUserTask2FlowElement

		/// <exclude/>
		public class ChangeDataUserTask2FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_ClosureDate = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_ClosureDate", () => _recordColumnValues_ClosureDate.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<DateTime> _recordColumnValues_ClosureDate;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,149,128,231,40,80,44,201,150,125,43,92,183,200,165,9,26,35,151,42,135,53,181,146,137,82,162,64,82,105,93,195,255,222,37,105,171,78,225,34,110,128,160,21,116,32,7,195,217,217,215,150,113,9,198,124,130,6,217,140,45,81,107,48,170,178,87,31,132,180,168,63,106,213,119,236,146,25,212,2,164,248,129,101,192,23,165,176,239,193,2,61,217,22,191,20,10,54,43,78,107,20,236,178,96,194,98,99,136,67,79,82,200,98,184,230,85,52,141,87,16,165,201,132,71,211,36,47,35,28,39,201,56,201,232,159,76,3,243,79,226,115,213,116,160,49,196,240,242,149,63,46,55,157,163,94,19,192,61,69,24,213,238,193,196,153,48,139,22,86,18,75,186,91,221,35,65,86,139,134,178,193,165,104,240,14,52,197,114,58,202,65,68,170,64,26,199,146,88,217,197,247,78,163,49,66,181,47,153,147,125,211,30,179,73,0,135,235,222,78,236,61,58,230,29,216,181,151,184,33,91,59,239,242,93,93,107,172,193,138,167,99,19,95,113,227,121,231,213,143,30,148,212,165,7,144,61,30,197,124,158,201,28,58,27,18,10,225,137,160,69,189,62,59,215,161,98,47,165,59,34,176,59,144,207,212,60,153,195,104,76,224,147,3,130,202,225,88,176,47,55,230,246,91,139,250,158,175,177,129,80,181,199,43,66,127,3,6,253,217,118,194,243,120,140,89,25,85,73,156,70,105,70,167,213,8,211,104,138,101,6,57,207,243,42,230,187,199,224,67,152,78,194,230,97,8,55,7,131,23,159,145,43,93,94,248,206,185,207,21,88,213,130,131,188,237,80,83,3,125,1,227,211,163,247,108,102,93,90,90,41,27,204,14,101,113,81,124,252,67,243,41,16,237,164,171,202,189,234,53,223,239,128,9,203,248,170,37,251,7,171,243,55,219,112,114,30,207,153,175,242,127,152,156,183,156,138,29,219,253,4,56,110,94,215,194,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,77,111,163,48,20,252,43,200,237,49,142,48,24,48,185,182,151,72,237,42,106,178,185,148,30,30,246,243,22,137,143,200,152,74,217,136,255,190,134,64,211,68,221,203,174,15,32,63,222,140,231,205,224,19,185,183,199,3,146,21,217,161,49,208,54,218,46,31,26,131,203,141,105,36,182,237,242,169,145,80,22,191,33,47,113,3,6,42,180,104,246,80,118,216,62,21,173,93,120,215,48,178,32,247,31,227,87,178,122,61,145,181,197,234,231,90,57,118,161,133,47,67,145,80,197,49,167,156,137,156,10,205,99,202,164,200,85,148,112,157,198,129,3,203,166,236,170,250,25,45,108,192,190,147,213,137,140,108,142,0,89,192,82,166,53,13,4,99,148,135,190,162,128,18,104,2,156,135,17,242,156,229,41,233,23,164,149,239,88,193,120,232,5,204,88,162,194,64,167,84,4,73,68,121,20,114,42,184,163,97,50,142,25,139,36,166,82,13,224,169,255,2,124,189,219,30,219,61,152,98,152,127,249,208,25,131,181,125,4,139,187,162,194,187,183,1,163,138,246,80,194,113,255,45,212,205,239,125,220,192,189,1,235,65,173,188,129,232,76,114,184,178,246,43,205,41,59,39,148,145,85,246,183,140,166,247,118,28,253,58,165,219,128,50,178,200,200,182,233,140,28,24,67,183,121,252,162,127,60,100,108,185,217,206,137,184,74,221,149,229,84,113,250,97,110,156,203,141,42,116,129,106,93,111,231,32,70,22,127,90,244,155,199,188,206,218,254,7,246,12,53,252,66,243,195,25,112,209,254,169,114,231,108,156,137,85,192,48,69,205,169,244,99,78,185,207,2,154,7,34,166,26,24,8,150,48,229,126,171,17,253,130,26,93,106,18,255,81,216,11,182,163,219,195,85,152,116,13,86,245,164,239,223,250,63,244,80,4,92,126,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "01896e873e4246cf8f019781cacfce12",
							"BaseElements.ChangeDataUserTask2.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
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

		#region Class: ReadDataUserTask5FlowElement

		/// <exclude/>
		public class ReadDataUserTask5FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask5FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask5";
				IsLogging = true;
				SchemaElementUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,75,143,211,48,16,254,43,85,206,235,170,73,243,106,111,168,20,180,23,118,69,87,123,33,123,152,216,147,212,194,121,200,118,22,74,149,255,206,56,105,75,23,21,109,65,66,28,240,201,254,244,205,204,55,47,239,61,174,192,152,15,80,161,183,244,30,80,107,48,77,97,167,239,164,178,168,223,235,166,107,189,27,207,160,150,160,228,55,20,35,190,22,210,190,5,11,100,178,207,126,120,200,188,101,118,217,71,230,221,100,158,180,88,25,226,144,73,33,18,17,228,98,193,114,14,62,11,163,52,96,41,23,130,129,239,47,18,17,5,137,207,231,35,243,87,206,87,77,213,130,198,49,198,224,190,24,174,15,187,214,81,125,2,248,64,145,166,169,15,224,220,137,48,235,26,114,133,130,222,86,119,72,144,213,178,162,108,240,65,86,120,15,154,98,57,63,141,131,136,84,128,50,142,165,176,176,235,175,173,70,99,100,83,191,38,78,117,85,125,206,38,7,120,122,30,228,204,6,141,142,121,15,118,59,184,184,37,89,253,160,242,77,89,106,44,193,202,231,115,17,159,113,55,240,174,171,31,25,8,234,210,35,168,14,207,98,190,204,100,5,173,29,19,26,195,19,65,203,114,123,117,174,167,138,189,150,110,64,96,123,36,95,233,243,98,14,65,76,224,179,3,70,47,199,107,230,125,186,53,119,95,106,212,27,190,197,10,198,170,61,77,9,253,9,88,43,172,176,182,203,61,135,56,159,113,31,89,81,68,41,11,103,116,91,228,2,88,42,146,88,196,105,28,165,126,220,147,193,73,208,114,159,207,185,31,5,197,156,165,69,36,88,200,57,85,61,12,67,38,226,69,2,193,98,17,228,62,56,147,117,109,165,221,141,147,176,220,67,226,131,0,4,54,15,227,144,133,2,145,229,121,88,48,158,64,52,143,194,104,6,34,233,159,198,116,165,105,21,236,30,79,89,125,68,16,19,14,6,39,198,130,237,12,45,150,54,118,226,214,105,210,20,19,170,114,167,172,172,203,9,13,147,66,238,186,57,221,12,76,26,38,119,92,207,155,82,114,80,119,45,106,154,169,161,167,179,203,219,240,98,141,92,165,117,211,216,177,126,167,78,173,72,204,49,194,217,84,82,56,250,44,92,187,54,77,167,249,97,57,205,248,75,252,209,246,255,131,157,254,157,53,189,184,40,215,12,254,255,52,210,189,59,127,117,4,123,175,255,14,53,44,32,79,200,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,75,204,77,181,50,180,50,4,0,127,229,4,95,8,0,0,0 })));
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
								new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			#endregion

		}

		#endregion

		public AnalyzeCaseSatisfactionLevel(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AnalyzeCaseSatisfactionLevel";
			SchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
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
				return new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: AnalyzeCaseSatisfactionLevel, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: AnalyzeCaseSatisfactionLevel, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CaseRecordId {
			get;
			set;
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
					SchemaElementUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
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

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
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

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("6f8502a0-3594-4b8f-977d-f540357b0266"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask5FlowElement _readDataUserTask5;
		public ReadDataUserTask5FlowElement ReadDataUserTask5 {
			get {
				return _readDataUserTask5 ?? (_readDataUserTask5 = new ReadDataUserTask5FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("e7bc3b23-71ca-41a9-a7d7-73a1b7c38399"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2;
		public ProcessConditionalFlow ConditionalSequenceFlow2 {
			get {
				return _conditionalSequenceFlow2 ?? (_conditionalSequenceFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2",
					SchemaElementUId = new Guid("5a9762ab-9fb2-4607-92d8-972d548892b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow3;
		public ProcessConditionalFlow ConditionalSequenceFlow3 {
			get {
				return _conditionalSequenceFlow3 ?? (_conditionalSequenceFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow3",
					SchemaElementUId = new Guid("43d68cc9-41d1-4662-a26b-62bb02a1f91a"),
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
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
			FlowElements[ReadDataUserTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask5 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (ConditionalSequenceFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask5", e.Context.SenderName));
						break;
					case "ChangeDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("IsResolved").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>("IsResolved") : false)));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"IsResolved\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>(\"IsResolved\") : false))", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("Status").ColumnValueName) ? ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("StatusId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow2", "((ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName(\"Status\").ColumnValueName) ? ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>(\"StatusId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask5.ResultEntity.IsColumnValueLoaded(ReadDataUserTask5.ResultEntity.Schema.Columns.GetByName("IsFinal").ColumnValueName) ? ReadDataUserTask5.ResultEntity.GetTypedColumnValue<bool>("IsFinal") : false)) == true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway3", "ConditionalSequenceFlow3", "((ReadDataUserTask5.ResultEntity.IsColumnValueLoaded(ReadDataUserTask5.ResultEntity.Schema.Columns.GetByName(\"IsFinal\").ColumnValueName) ? ReadDataUserTask5.ResultEntity.GetTypedColumnValue<bool>(\"IsFinal\") : false)) == true", result);
			return result;
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
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
			MetaPathParameterValues.Add("7c806e5d-f304-455d-b2e4-9ed5a8c88f0c", () => CaseRecordId);
			MetaPathParameterValues.Add("643fc2b1-37e6-4c13-b874-541f74be69c6", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("fb56437e-ba33-4a23-9d0c-ae27bb35a2a4", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("28d07f6e-0d89-4984-ae74-9e1d6c8a64b5", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("c4dec099-47fa-4366-98a4-b699ffa357e6", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("72de3fe9-d5d9-40ab-85f1-88ea175b52be", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("5e86df7f-bd13-4bc4-9cc7-8b7f60824845", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("247ba482-7f2c-4dc6-94f2-7174de79afd0", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("a7ec7ea4-ce5b-4f68-85b1-5bcb0f131a52", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("608cedf5-b8e9-4b65-b2eb-f05daae2899e", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("d10c7fb3-28cc-4700-a5b8-66c91209a9f8", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("fdea50bf-6a67-4306-9bf6-a560509191ee", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("85ce2111-939c-4c61-a6fc-25f3d846bef3", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("c8ea1ef0-089c-4d1e-ad79-bb1881d2a81b", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("6400198a-fd0f-42e8-aff8-558ad741e1f3", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("b853c17a-5aa9-4f6a-b6f5-dc1d14e76e99", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("cbfaa20f-5593-406d-b8d0-2a98e6a2c065", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("55ff5bcf-9e1c-431e-be5e-7d02bf259e96", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("664166e1-37a2-407f-9c8d-1aa3cb91f96a", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("a9308cdd-6583-4b0d-b236-8b50811ee000", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("3dc139f3-bcc4-413e-937a-9d613d137381", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("0c6de25d-2707-4643-a8ad-911d475e594c", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("2c01b2a0-4d16-41e0-a641-3d9a2f02561b", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("c0073aa2-5633-49ad-b4a3-2e43b3e5669f", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("02c2428c-c555-47dc-9e99-df353f553049", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("cbd3780c-de4a-4e33-8ee8-b9febddbf1a5", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("bd37a5c6-0d37-4523-b75c-cf34a74888cb", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("7092f775-9a72-4aaf-b608-e2668011359f", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("352856bf-54d3-414b-a777-6ea0f684dd68", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("38097a14-57ca-4d1c-a9b6-b83821594568", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("891c23be-079e-4dcf-afa7-6c04ead53b72", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("ca27a4b0-7cce-4840-9bca-800f545dca25", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("101a3fe4-83d5-45b2-94de-c891f8aae0b1", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("9b75f53d-4836-4518-9ff9-ac4c9e368e0f", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("b0a000e3-e6fc-4cdd-b51c-12f6e2c080eb", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("ae705119-6e00-4b54-afa3-f7214514ce18", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("7b964786-d631-40c6-80bc-46e13902504e", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("baeaa6dc-a9dd-4cbb-a360-ffdc711ecee8", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("d28d8cd8-42d1-4f62-bb6c-513cd1af7729", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("42a0be64-dc23-4a7d-9fe3-953b6cefb20b", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("d6167808-425a-4541-a89f-19118a685830", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("df97a40d-caba-46d0-ae3b-3ab77b3aa563", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b70e85c0-915b-4104-b121-b468de8a4637", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("223eb29e-364a-44cc-becc-69e01425be9c", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("656b1ea1-bac6-4518-8006-2d3d95f56bed", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("ec808db1-3f0a-4038-a26b-446f2935c069", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("f5fc4e93-92c3-47f2-a1dc-a5ba89846ff7", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("92813432-e952-427c-b775-57f77d398b6d", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("2ef81675-328b-4e33-8a16-6a0df1006683", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("2f91fd7b-c25b-45ae-ac98-c772e1c88493", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("3a06c5c6-afac-4bd1-9115-551805b1f7bb", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("af6a486a-47e5-47a2-85fe-6687125e74bd", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("32bf5acf-9862-459e-a98e-55e6f938cfb2", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("fc23f180-56cd-4e39-a2cf-d3dad81c0dd1", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("be278a15-6327-41b0-a4a8-6c2d57c5a3cc", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9105f6d4-f8a4-4fc1-b550-632a6cf66f9a", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("dee58147-a6a2-4c39-9f81-0ca6adefb533", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("de1fa507-72c5-48f9-adaa-9e7bd218c5b5", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9368f221-436d-4df7-8b76-c98cf6d025a9", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("65d9b230-45b3-4daa-bb41-9096e6b07169", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("a461b0ff-7cf6-4abc-aab6-8c25d8833b2b", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("3ef5ba64-31d5-408a-91cd-c4b705177d41", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("d51b136d-f674-45ae-991e-74dc6a36e5a5", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("fe0fa648-3fc3-4ce1-a8d3-1681f04a67c9", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("ae404d44-60d7-4e4b-8282-762b27d3a152", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8763f1ba-63c6-4753-87a2-dbaeb9ea40d3", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("9eda2b32-157f-4e17-b87c-cc0782b8e875", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("d2adb4a4-eb38-4950-aadd-fdeebf093883", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("6c320b14-8f29-402a-a272-3d4d451107ba", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("b3c152f3-8f5d-4ccd-a444-d697a2992b1a", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("919f3607-18a5-44b4-b8c5-a553b21c63f7", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("275b1604-78cd-4f80-ad1a-dbb6afbae187", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("58b416b7-18b4-43de-b90e-b775fc705598", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("18226361-e716-427e-8881-44a4fbfcbcbc", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("acdae03e-04e7-470b-acab-80f8b02cde3d", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("98406230-ae2f-4d18-934d-4512830c3860", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("4ed4d571-44c8-4a27-a65a-4131b67102cd", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("b38a94a0-f6e4-4feb-8786-12e8b069d09b", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("a4fde4e6-b89d-4d7a-9c00-a5b453b8f484", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("2dd75492-fff2-4a42-8113-1363e4c5f0d4", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("b89ce4b1-992d-429f-80d8-91c514f034b4", () => ReadDataUserTask4.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("838069b1-290a-4dfe-8a76-789d0b22ee56", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("9aae8482-6a87-492c-a2eb-c2cc69f1a33a", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("7f1e55bc-3c69-4e8d-ab13-4c60e7f1c2b5", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("75fd7f6c-28fc-4c7c-bf17-b30ef4fedf91", () => ChangeDataUserTask2.RecordColumnValues);
			MetaPathParameterValues.Add("8a822ce2-db65-4f4c-9559-c00347db1b23", () => ReadDataUserTask5.DataSourceFilters);
			MetaPathParameterValues.Add("94072bca-6162-4e8e-b862-b76f105bc46a", () => ReadDataUserTask5.ResultType);
			MetaPathParameterValues.Add("5c651444-a144-4931-821b-e26e9fb71f60", () => ReadDataUserTask5.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d6933145-11a6-41e0-a083-8e3d0f5cb15f", () => ReadDataUserTask5.NumberOfRecords);
			MetaPathParameterValues.Add("41bdacb0-38ba-4c89-b2bd-9e26c44910c6", () => ReadDataUserTask5.FunctionType);
			MetaPathParameterValues.Add("0f225841-4a24-46aa-9ab5-c60099fe3a63", () => ReadDataUserTask5.AggregationColumnName);
			MetaPathParameterValues.Add("e30c8bb4-f01c-440f-8a45-b98eb8058e08", () => ReadDataUserTask5.OrderInfo);
			MetaPathParameterValues.Add("82d3dd51-cb6e-431e-b725-0622ebd71499", () => ReadDataUserTask5.ResultEntity);
			MetaPathParameterValues.Add("1397425e-4ae0-4803-9260-930a308717ad", () => ReadDataUserTask5.ResultCount);
			MetaPathParameterValues.Add("3bbdd8db-b7fb-45ce-a565-73afafc90561", () => ReadDataUserTask5.ResultIntegerFunction);
			MetaPathParameterValues.Add("1a775799-e9f7-4e06-9c16-7b002d6e9c48", () => ReadDataUserTask5.ResultFloatFunction);
			MetaPathParameterValues.Add("a39c131b-b8b8-409b-b619-3e350352fc5e", () => ReadDataUserTask5.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2f2d12aa-73bf-4cc5-9ed8-61b85e547204", () => ReadDataUserTask5.ResultRowsCount);
			MetaPathParameterValues.Add("2d5e1b39-c1bd-463e-aa87-b6982b2c0502", () => ReadDataUserTask5.CanReadUncommitedData);
			MetaPathParameterValues.Add("ecdc24d5-dc69-4e45-9cdc-bbbc660c2d5e", () => ReadDataUserTask5.ResultEntityCollection);
			MetaPathParameterValues.Add("93186690-48ea-44b2-a2cf-18064e1d9d6d", () => ReadDataUserTask5.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("dc93e612-6e5f-4209-89e2-bf47d63b7bf2", () => ReadDataUserTask5.IgnoreDisplayValues);
			MetaPathParameterValues.Add("75936d03-8b14-4b5b-ad52-ea3ae6501d35", () => ReadDataUserTask5.ResultCompositeObjectList);
			MetaPathParameterValues.Add("6ab22a53-ba74-4fe1-9b06-5d4dda97b845", () => ReadDataUserTask5.ConsiderTimeInFilter);
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
			var cloneItem = (AnalyzeCaseSatisfactionLevel)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

