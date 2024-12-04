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

	#region Class: LeadManagementHandoffFinanceSchema

	/// <exclude/>
	public class LeadManagementHandoffFinanceSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementHandoffFinanceSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementHandoffFinanceSchema(LeadManagementHandoffFinanceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementHandoffFinance";
			UId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4");
			CreatedInPackageId = new Guid("dde4f4da-9d1e-43c2-84fa-4954487c1f6e");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"LeadManagementHandoffFinance";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4");
			Version = 0;
			PackageUId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("54a0a9d9-5cdd-45ca-8269-7e1318e707b2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa68c1b9-9e12-4b99-bdde-6eb1806d8874"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,201,150,45,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,203,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,63,126,244,117,192,161,116,80,143,152,76,7,91,18,89,57,167,242,84,81,169,11,160,130,113,73,65,113,69,153,144,76,240,76,2,58,36,73,11,13,150,100,67,239,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,222,173,151,175,230,132,13,124,91,26,8,14,78,105,212,84,230,172,162,2,171,138,42,3,134,58,151,233,170,16,74,112,52,100,211,194,164,176,58,214,83,89,229,41,21,144,58,170,92,90,209,130,129,112,150,27,237,88,74,146,26,93,216,63,245,3,142,163,239,218,114,198,215,248,230,185,143,42,183,222,187,174,158,154,150,36,13,6,184,134,112,42,9,32,67,145,27,160,70,232,156,10,135,113,210,76,91,154,65,37,83,169,144,23,92,146,196,64,31,22,90,114,176,36,177,16,224,59,212,19,174,204,179,143,26,211,140,113,149,23,17,203,51,67,69,150,50,170,10,37,169,179,133,211,152,21,90,87,246,226,215,167,201,199,216,143,87,83,131,131,55,47,182,99,244,175,27,202,217,116,109,24,186,122,161,190,90,203,111,240,41,108,230,190,60,253,216,6,10,49,191,128,200,57,153,70,220,213,30,219,176,111,77,103,125,251,176,113,158,207,17,210,244,48,248,241,226,194,254,113,130,154,36,131,127,56,253,209,173,221,52,134,174,249,143,70,77,226,152,145,35,46,217,42,119,217,65,235,199,190,134,231,245,94,146,119,143,83,23,62,124,70,176,91,68,222,32,74,114,71,114,1,12,180,213,52,55,214,210,117,43,84,90,196,29,69,158,113,133,146,201,42,189,35,81,197,63,112,223,30,198,47,63,219,203,31,216,84,31,223,199,236,155,196,245,5,89,206,127,35,231,124,92,4,29,207,241,252,2,68,247,49,72,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99786611-0f56-4e3c-8f29-a4185ad1f427"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c21a605f-a60b-42ed-9061-294cc87b69a0"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8bb1e66c-1b41-4f67-ab42-57cdc5d866a6"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("745423dc-b077-4526-8e74-98d8ad204cb8"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e1878c2-6cac-4d8b-baa8-a59f16943d8b"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("1053c0e9-6404-4b90-bd4a-07157c475327"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("8bc11220-5b0b-4d4e-a16c-25109fbcecd2"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("952c2d22-d6b6-4a51-82ac-ec6cfa9a867e"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("ff499ce0-d575-4f90-b31d-15c099b5f8ee"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("ddfda365-0d3d-45c9-84c5-ef97a50abd3e"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("7ced0725-a5ff-48ab-8329-db8cd92d45fc"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("1bdef657-82b6-4e4c-9cba-7cc3f773ead3"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("0e7bc406-b400-4ee2-8857-94f4a2ed4291"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("a4c0fd5e-3b7e-4c6a-bf78-0b172e842a9f"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed0eae90-a660-43ec-85fa-c1bc0b2c7a5c"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fb15793-1f5f-4afb-a9c5-7ee6d16f6cd6"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("d1788627-60e4-44cd-ad66-8387366ff0ee"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("460ec60f-88a1-4a7c-be25-e09b9f9029d7"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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

		protected virtual void InitializeActivityUserTaskBANTParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5141e1f7-4af9-4bf4-b6d1-8874c0d2dc5f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Contact customer, specify need (if any) and decision-making role.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("5b4637a8-7fc7-40e0-bfac-9cb675816ccf"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0902eded-b1a4-4f75-aa93-09fdf0aac605"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba47d7d3-1ca5-41d1-9d6b-42ce60295158"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"60",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fdd5f4d6-8792-40d3-a46d-47a3545e3715"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5f4c4e07-469e-451a-88f4-305e2f6792b2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abdfdb50-a1ba-4d57-9207-b1dd297f6e84"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6ff80f1-90c6-416a-90bb-260e00d506f7"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e14fc2e-ed85-4967-92f6-4ffd68e2401a"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0685b12b-443e-4c64-ab26-d4859f0c8c4b"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("53d8ba23-d026-4fd0-9523-ad2d59cb13a1"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("54f32772-50b2-49b4-a2a7-eee12cea8efc"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("531d1563-ba9a-4e91-98ce-d35b182bca5f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fdb90180-2f4b-4831-b679-403593dd3b6f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("41dcb696-2cb1-4512-b3cf-dd1a7583a4ff"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d329e26e-4b48-4034-a14b-d1f9fe83945f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("a61fc569-1cd9-4ee0-913c-ffb7359a1776"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f7625075-971c-47b4-b67f-f12b29f07881"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("71e2fad8-087d-4d30-853f-4284671382e2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("b9471d7d-f83c-40ed-8479-ac97045d505d"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("42791514-cf69-4e4b-a09a-b627acdcf9e8"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85441486-29f4-4732-bedf-744579a8ec72"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("1ec1c9c1-eadf-4d15-a0fa-5e9731a46b43"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4c515728-a780-4846-a088-022faab38f6a"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Contact customer, get in touch with contact persons, define interest and BANT. As a result, either proceed to handoff or continue lead nurturing.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5cf10363-3ca3-4fcf-a2e0-2c6f612c9aef"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("38749114-70e5-4e48-85a8-d4f5a5ff24c3"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("725e7498-44eb-49c5-8104-b615cd2a44b3"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("24e0015e-591a-49d6-b47e-f60c309ab061"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("ed86a088-1c5e-4485-b084-878f1a8d39df"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("b14902c4-2013-48e9-b69e-d810c180118b"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("1138fd23-4b02-4812-9de6-6ecb917db660"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("948d7cec-52ca-4a20-9991-67a3f04cc7c2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("4b5d863d-2006-4c46-8f37-592fbfa512c0"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
			var queueItemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("aadf2fcd-684b-4414-8317-bf9879e97569"),
				UId = new Guid("af9569bc-af68-4326-b7bd-5c4ef9e17ea0"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"QueueItem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			queueItemParameter.SourceValue = new ProcessSchemaParameterValue(queueItemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(queueItemParameter);
			var applicationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("93699f4a-3722-4757-85a7-ebcb8cbd5d41"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Application",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			applicationParameter.SourceValue = new ProcessSchemaParameterValue(applicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(applicationParameter);
			var finApplicationParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				UId = new Guid("4f326ae3-c270-4edb-b8c8-661e21a86817"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"FinApplication",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			finApplicationParameter.SourceValue = new ProcessSchemaParameterValue(finApplicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(finApplicationParameter);
		}

		protected virtual void InitializeChangeLeadStateToNoInterestParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("2c070493-7483-4c5e-a83b-3eb1c5d78ab7"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c600955c-8b94-4c98-aee1-79c3c61d4140"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24bf952c-9579-4dcf-981f-f2cce1dbc830"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,182,228,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,95,177,101,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,163,121,111,222,60,70,243,189,31,63,250,58,224,80,57,168,71,164,211,193,86,36,211,165,40,108,94,178,44,213,156,113,11,130,169,210,10,166,1,10,238,20,215,153,72,8,109,161,193,138,108,232,189,245,129,80,31,176,25,171,219,249,55,105,24,38,164,247,110,189,124,53,39,108,224,219,210,128,167,224,164,66,197,74,145,104,198,81,107,38,13,24,230,92,174,116,193,37,79,209,144,77,11,231,82,160,80,154,153,88,203,184,118,57,147,90,228,12,184,116,73,6,34,229,186,32,180,70,23,246,79,253,128,227,232,187,182,154,241,53,190,121,238,163,202,173,247,174,171,167,166,37,180,193,0,215,16,78,21,1,76,144,11,3,204,112,37,24,119,88,50,200,149,101,57,232,50,43,37,166,69,90,18,106,160,15,11,45,57,88,66,45,4,248,14,245,132,43,243,236,23,191,242,36,149,162,136,216,52,55,140,231,89,194,100,33,75,230,108,225,20,230,133,82,218,94,252,250,52,249,24,251,241,106,106,112,240,230,197,118,140,254,117,67,53,155,174,13,67,87,47,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,211,105,196,93,237,177,13,251,214,116,214,183,15,27,231,249,28,33,77,15,131,31,47,46,236,31,39,168,9,29,252,195,233,143,110,237,166,49,116,205,127,52,42,141,99,70,142,184,100,171,220,101,7,173,31,251,26,158,215,123,69,222,61,78,93,248,240,25,193,110,17,121,131,168,200,29,17,28,18,80,86,49,97,172,101,235,86,200,172,136,59,138,105,158,74,44,147,82,103,119,36,170,248,7,238,219,195,248,229,103,123,249,3,155,234,227,251,152,125,147,184,190,32,171,249,111,228,156,143,139,160,227,57,158,95,209,224,137,218,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,83,209,78,219,48,20,253,21,100,120,236,141,236,216,177,227,190,142,23,36,64,104,48,94,40,15,215,246,245,136,150,54,85,146,78,98,85,255,125,174,105,69,59,141,9,33,77,218,195,242,224,40,177,207,57,247,222,227,179,102,103,227,243,146,216,148,221,81,223,227,208,197,177,248,212,245,84,220,244,157,167,97,40,46,59,143,109,243,3,93,75,55,216,227,156,70,234,239,177,93,209,112,217,12,227,228,228,24,198,38,236,236,123,222,101,211,135,53,187,24,105,254,229,34,36,118,47,148,228,174,50,80,85,49,130,242,193,0,58,69,128,117,224,88,233,42,212,198,39,176,239,218,213,124,113,69,35,222,224,248,196,166,107,150,217,18,129,117,165,177,222,104,224,165,144,160,98,37,0,125,208,32,173,212,36,184,182,46,40,182,153,176,193,63,209,28,179,232,43,88,9,140,181,37,11,166,226,14,20,57,7,181,71,15,49,74,235,180,170,149,32,191,5,239,206,191,2,31,78,47,187,238,219,106,89,148,33,10,239,107,13,186,52,30,84,72,11,6,17,129,7,170,137,92,234,133,251,34,154,154,107,29,36,160,145,148,100,210,113,231,172,5,82,198,68,239,172,114,101,125,250,184,21,10,205,176,108,241,249,254,77,189,107,162,112,50,199,113,213,55,227,115,113,221,141,39,205,34,77,158,134,145,194,11,197,242,200,141,67,146,245,236,197,212,25,155,206,222,178,117,247,190,205,211,58,54,246,87,79,103,108,50,99,183,221,170,247,91,70,185,253,216,207,56,43,240,221,3,191,89,246,207,11,71,134,93,225,2,191,82,127,157,20,51,60,111,157,227,136,89,252,46,213,189,39,118,165,173,184,73,67,54,132,54,141,83,151,80,7,129,96,133,117,81,26,89,198,88,102,244,103,138,105,52,11,79,199,133,189,199,179,140,207,202,175,197,236,175,95,250,179,88,181,109,22,24,114,255,219,251,188,43,124,183,115,126,96,228,1,67,23,154,216,80,184,88,124,100,84,27,182,217,76,14,195,35,48,72,45,164,0,151,154,72,141,112,1,86,133,18,66,52,92,152,218,150,36,241,143,225,113,158,251,50,104,14,21,202,0,233,190,115,64,76,233,243,154,19,26,163,169,228,250,111,134,167,148,74,248,32,160,114,50,101,215,39,121,203,133,0,29,141,182,146,162,38,165,138,42,117,233,37,121,144,21,79,135,156,72,53,242,36,88,59,146,142,147,16,145,191,55,60,183,99,186,97,255,67,131,31,10,205,59,188,250,87,67,243,184,249,9,207,214,238,57,207,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeLeadNurturingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("091ab17a-49f8-4d9e-be81-1ca9c9dcb055"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6f0df01f-2acd-4bc7-adec-34cfc25c9246"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,75,107,220,48,16,254,47,58,244,100,21,217,150,109,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,95,177,100,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,99,127,143,249,24,205,247,206,127,116,77,192,177,182,208,120,76,166,131,169,9,67,171,37,23,5,197,146,43,202,81,11,10,10,56,69,76,141,201,76,197,180,209,36,233,160,197,154,108,232,189,113,129,36,46,96,235,235,219,249,55,105,24,39,76,238,237,122,249,170,79,216,194,183,69,128,167,96,133,68,73,171,130,45,2,74,81,161,65,83,107,115,169,74,46,120,138,81,96,245,82,9,166,51,80,150,166,86,49,202,45,147,20,140,150,148,41,169,37,242,50,203,181,33,73,131,54,236,159,134,17,189,119,125,87,207,248,90,223,60,15,209,229,166,189,235,155,169,237,72,210,98,128,107,8,167,154,0,50,228,133,6,170,185,44,34,59,86,20,114,105,104,14,170,202,42,129,105,153,86,36,209,48,132,133,150,28,162,148,129,0,223,161,153,112,101,158,93,244,152,229,44,21,69,25,177,105,174,41,207,51,70,69,41,42,106,77,105,37,230,165,148,202,92,242,250,52,185,88,59,127,53,181,56,58,253,18,59,198,252,250,177,158,117,223,133,177,111,22,234,171,245,247,27,124,10,91,184,47,159,126,108,3,133,216,95,64,228,156,76,30,119,141,195,46,236,59,221,27,215,61,108,156,231,115,132,180,3,140,206,95,82,216,63,78,208,144,100,116,15,167,63,166,181,155,124,232,219,255,104,212,36,142,25,57,226,146,173,118,151,29,52,206,15,13,60,175,247,154,188,123,156,250,240,225,51,130,217,42,242,6,81,147,59,82,112,96,32,141,164,133,54,134,174,91,33,178,50,238,40,166,121,42,176,98,149,202,238,72,116,241,15,220,183,7,255,229,103,119,121,3,155,235,227,251,216,125,211,184,190,32,235,249,111,236,156,143,139,161,227,57,158,95,203,128,158,28,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38717ef0-c344-40ce-a5f4-e39c87df0d1d"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,77,79,219,64,16,253,43,200,112,204,68,251,229,93,111,174,229,130,4,8,21,202,133,112,152,157,157,45,86,147,56,178,29,36,138,242,223,187,49,137,72,170,82,69,149,42,245,208,61,172,101,175,223,123,227,121,243,252,90,156,245,47,75,46,38,197,29,183,45,118,77,234,199,159,154,150,199,55,109,67,220,117,227,203,134,112,86,127,199,48,227,27,108,113,206,61,183,247,56,91,113,119,89,119,253,232,228,16,86,140,138,179,231,225,180,152,60,188,22,23,61,207,191,92,196,204,30,74,150,214,106,3,145,243,102,144,36,132,210,24,208,201,122,174,164,34,50,50,131,169,153,173,230,139,43,238,241,6,251,167,98,242,90,12,108,153,192,7,229,60,57,11,66,73,13,38,149,18,144,162,5,237,181,101,41,172,15,209,20,235,81,209,209,19,207,113,16,125,7,27,137,169,242,236,193,149,34,128,225,16,160,34,36,72,73,251,96,77,101,36,211,6,188,125,255,29,248,112,122,217,52,223,86,203,177,138,73,18,85,22,172,114,4,38,230,13,163,76,32,34,87,204,1,131,17,52,46,131,142,82,24,11,137,164,5,83,82,5,88,162,4,229,171,152,168,42,93,105,236,233,227,70,40,214,221,114,134,47,247,31,234,93,51,199,147,57,246,171,182,238,95,198,231,117,71,205,51,183,28,223,224,203,3,39,246,9,94,167,111,134,78,139,201,244,35,75,183,215,219,161,83,135,166,254,236,231,180,24,77,139,219,102,213,210,134,81,111,110,118,253,29,20,196,118,193,47,182,221,122,227,24,96,87,184,192,175,220,94,103,197,1,62,28,157,99,143,131,248,93,174,123,71,28,148,47,133,203,13,118,140,62,59,102,21,84,81,34,120,233,67,210,78,171,148,212,128,254,204,41,247,101,65,124,88,216,49,126,13,248,65,249,189,152,221,232,229,39,139,213,108,54,8,116,195,247,111,102,121,91,248,246,228,124,207,196,61,134,38,214,169,230,120,177,248,147,86,173,139,245,122,180,31,28,175,4,42,42,67,142,75,153,192,120,46,1,181,10,128,142,164,115,50,138,224,171,223,6,39,144,32,21,173,128,18,117,132,60,235,2,16,13,3,89,193,232,156,101,37,236,223,12,142,210,70,82,148,144,195,145,115,75,89,222,11,41,193,38,103,189,230,100,217,152,177,52,148,200,230,223,1,107,206,53,122,199,80,229,184,3,71,163,179,225,161,18,94,31,25,156,219,62,79,216,38,48,125,91,135,85,95,55,139,255,145,241,199,69,230,8,167,254,213,200,60,174,127,0,175,75,31,53,201,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAutoGeneratedPageHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37ca1e6d-f9a7-4c7f-ba6c-9ca142ff1579"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Proceed to handoff: Information",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("92313c1a-6c83-4de1-b493-4b387b234357"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5854a389-d5a2-4dce-814f-9c06510637e6"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Specify information that is required for proceeding to handoff",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41d66075-70c0-453a-8022-cff5949370b2"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3111f593-81b1-42b5-99a0-cd853a60b279"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			buttonsParameter.SourceValue = new ProcessSchemaParameterValue(buttonsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""853857d6-cc8a-4f66-a1ca-f7261718597c"",""name"":""SaveButton"",""caption"":""Save"",""style"":""green"",""performValidation"":true,""isEnabled"":true,""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d88c0edd-7a1d-4087-b13e-ce975c3e925f"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Elements",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			elementsParameter.SourceValue = new ProcessSchemaParameterValue(elementsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""3a8ae276-d1a6-4833-8edd-18a3802457a6"",""name"":""LeadType"",""caption"":""Need type"",""controlEditType"":""SelectionField"",""isRequired"":true,""dataFilter"":"""",""controlDataValueType"":""11"",""dataSource"":""e0dbeb22-4932-4eee-a8f2-a247a5fce888""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""3c1a49b0-c3d5-4625-857c-486a8728ce72"",""name"":""OpportunityResponsible"",""caption"":""Opportunity owner"",""controlEditType"":""SelectionField"",""isRequired"":false,""dataFilter"":"""",""controlDataValueType"":""10"",""dataSource"":""16be3651-8fe2-4159-8dd0-a803d4683dd3""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""2f793155-6bc5-4cb4-a9d1-f07a2a5f9214"",""name"":""DecisionDate"",""caption"":""Decision date"",""controlEditType"":""DateTimeField"",""isRequired"":false,""dateTimeFormat"":""8""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""77adfed6-803a-43ee-a405-f8d108f86eca"",""name"":""Comment"",""caption"":""Comment"",""controlEditType"":""1"",""isMultiline"":true,""isRequired"":false}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d35cac3-bad2-40c8-842e-1b639ac400c8"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ExtendedClientModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			extendedClientModuleParameter.SourceValue = new ProcessSchemaParameterValue(extendedClientModuleParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f2e508ca-4b2f-4b48-976b-52653e3dbe10"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntryPointId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entryPointIdParameter.SourceValue = new ProcessSchemaParameterValue(entryPointIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entryPointIdParameter);
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("478f0294-5119-41e8-ab5b-bc27d9882a36"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"PressedButtonCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pressedButtonCodeParameter.SourceValue = new ProcessSchemaParameterValue(pressedButtonCodeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pressedButtonCodeParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("9d600d04-bc01-4cd3-86a4-a9bb56f488b7"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a698c3a6-4b9a-4404-9178-0cd67c688925"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03fc2e34-8cdc-4158-9dd1-dafee46392f4"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Use the page to specify BANT (information about decision-making role of a contact person, need details and decision timeline) received while communicating with customer.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97a4e728-73b0-4b7e-8a0e-313bec8ab330"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"IsRunning",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isRunningParameter.SourceValue = new ProcessSchemaParameterValue(isRunningParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var leadTypeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("3a8ae276-d1a6-4833-8edd-18a3802457a6"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"LeadType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadTypeParameter.SourceValue = new ProcessSchemaParameterValue(leadTypeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{5c696704-62e8-4503-86bf-ed66c3dd63d5}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(leadTypeParameter);
			var opportunityResponsibleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("3c1a49b0-c3d5-4625-857c-486a8728ce72"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"OpportunityResponsible",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityResponsibleParameter.SourceValue = new ProcessSchemaParameterValue(opportunityResponsibleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{5c0fa796-b083-4126-ace9-cfddc25539a0}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(opportunityResponsibleParameter);
			var decisionDateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f793155-6bc5-4cb4-a9d1-f07a2a5f9214"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"DecisionDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Date")
			};
			decisionDateParameter.SourceValue = new ProcessSchemaParameterValue(decisionDateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{4c3a6f1b-99d3-4baf-8954-076274d0675c}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(decisionDateParameter);
			var commentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77adfed6-803a-43ee-a405-f8d108f86eca"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"Comment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			commentParameter.SourceValue = new ProcessSchemaParameterValue(commentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0}].[Parameter:{946dd2c0-da26-457d-ad8c-4ba3167aa54d}].[EntityColumn:{070b689f-c9d8-46e3-bb52-bcb1f430f5cf}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(commentParameter);
		}

		protected virtual void InitializeReadLeadForHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e73bc51-9c3d-46b9-99dc-388c60d1dae1"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,91,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,201,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,231,63,186,38,224,88,89,104,60,38,211,193,84,36,67,38,24,160,162,66,151,37,21,32,107,170,108,94,83,97,10,100,41,207,121,46,107,146,116,208,98,69,54,244,222,184,64,18,23,176,245,213,237,252,155,52,140,19,38,247,118,189,124,213,39,108,225,219,210,64,100,96,165,138,13,202,60,141,180,88,215,84,106,208,212,90,174,234,66,72,145,161,38,155,22,45,176,96,32,74,90,167,44,143,165,220,208,90,3,82,174,114,205,153,176,38,183,146,36,13,218,176,127,26,70,244,222,245,93,53,227,107,124,243,60,68,149,91,239,93,223,76,109,71,146,22,3,92,67,56,85,4,48,69,145,107,160,90,168,200,110,177,164,192,149,161,28,234,146,149,18,179,34,43,73,162,97,8,11,45,57,24,146,24,8,240,29,154,9,87,230,217,69,141,140,167,153,204,139,136,205,184,166,130,179,148,202,66,150,212,154,194,42,228,133,82,181,185,248,245,105,114,49,118,254,106,106,113,116,250,197,118,140,254,245,99,53,235,190,11,99,223,44,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,39,147,199,93,227,176,11,251,78,247,198,117,15,27,231,249,28,33,237,0,163,243,23,23,246,143,19,52,36,25,221,195,233,143,110,237,38,31,250,246,63,26,53,137,99,70,142,184,100,171,220,101,7,141,243,67,3,207,235,189,34,239,30,167,62,124,248,140,96,182,136,188,65,84,228,142,228,2,82,80,70,209,92,27,67,215,173,144,172,136,59,138,25,207,36,150,105,89,179,59,18,85,252,3,247,237,193,127,249,217,93,254,192,166,250,248,62,102,223,36,174,47,200,106,254,27,57,231,227,34,232,120,142,231,23,149,211,217,112,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c3ef0854-9dec-41d4-8d16-407475422cc6"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("976150fd-e561-4fa6-9f3f-911949e5c42c"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51bcbfaa-b77d-4c21-947e-02e0676d3545"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("663137f9-795a-4269-b94a-83f9c02d10da"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b1c37761-25d6-438c-bdbc-43b2a149b1ca"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("73074895-abf7-4e2d-ad95-2629a87fc3d5"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("69f1e87b-3dd8-44cf-8c4f-97bd0653ad06"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("225fc2e7-3024-4f80-b9c4-c881e8aadeed"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("38d606ea-c1d2-4017-915e-893f7f96a610"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("d8b37a80-9357-459a-9ca1-945f0af37bb5"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("3207b919-eb4b-44b7-9c43-5080d06b54a1"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("f24a8102-fb92-4bc4-b65f-c475f479a843"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("8f0a63b7-c987-4e12-93c8-76a709a96645"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("4af22b59-f62b-47c3-ad50-2c78bf148bf7"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a1770417-d693-4416-9df8-379715d76f1e"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e6e3bcd-5e15-4652-84f8-98664792001d"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("d9cc6ce2-f4c2-48b7-99ec-f97bea66b913"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("4dbe8b2c-9cba-4708-8f84-a8d5cc9e7b1b"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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

		protected virtual void InitializeReadActivityDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7a60eae-1035-42aa-a3a1-1572936331df"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,111,212,48,20,252,43,149,15,156,226,85,28,59,137,29,78,176,44,104,47,75,37,22,132,212,174,170,23,251,185,107,145,143,109,226,136,86,81,254,59,206,166,11,82,15,168,7,46,72,62,216,207,158,121,51,163,231,241,206,245,31,93,229,177,43,44,84,61,70,195,214,20,36,231,9,66,198,24,77,227,76,81,33,153,161,32,211,132,90,149,150,9,40,46,83,131,36,106,160,198,130,44,232,141,113,158,68,206,99,221,23,55,227,31,82,223,13,24,221,217,243,225,139,62,98,13,95,231,6,90,8,101,36,79,40,8,173,169,40,99,70,75,101,82,42,129,37,90,132,22,86,42,178,104,65,137,220,166,165,166,152,161,160,2,115,77,161,180,57,213,60,99,162,204,76,170,84,78,162,10,173,223,60,158,58,236,123,215,54,197,136,191,247,251,167,83,80,185,244,94,183,213,80,55,36,170,209,195,53,248,99,65,0,99,20,169,6,170,133,74,169,176,152,83,224,202,80,14,101,158,228,18,89,198,2,187,134,147,159,105,201,214,144,200,128,135,111,80,13,120,102,30,93,208,152,240,152,201,52,11,88,198,131,29,158,196,84,102,50,167,214,100,86,33,207,148,42,205,37,175,79,131,11,123,215,239,134,26,59,167,159,99,199,144,95,219,21,163,110,27,223,181,213,76,189,59,63,223,227,163,95,194,125,190,250,190,24,242,161,62,131,200,20,13,61,174,43,135,141,223,52,186,53,174,185,95,56,167,41,64,234,19,116,174,191,164,176,121,24,160,34,81,231,238,143,127,77,107,61,244,190,173,255,35,171,81,176,25,56,194,144,157,229,206,51,104,92,127,170,224,233,124,46,200,155,135,161,245,111,247,208,255,40,174,62,160,117,13,94,189,127,183,219,175,230,202,213,214,44,215,228,5,77,65,110,137,148,178,228,74,100,148,151,202,134,1,49,72,165,65,164,92,165,0,146,113,198,180,94,137,36,87,44,101,130,106,59,255,23,20,37,133,88,1,45,179,36,7,109,116,72,70,222,146,160,255,95,169,186,217,246,159,127,54,151,47,181,132,112,88,133,234,139,194,166,194,58,164,85,140,175,177,49,5,192,245,165,85,49,190,198,212,116,152,109,29,166,176,126,1,177,30,142,224,74,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51205379-8b3b-4d44-91b1-2cf7e081b07f"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9078003-1806-4096-a752-6ce6fcaf6be3"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76950e9e-10e8-40f4-86ff-2e96d8188d1b"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("93775e4e-88f1-48e9-ad74-74ac5f28d089"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("60cd6a65-a50a-4617-80ad-ed2c447da612"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("72a0125d-b3d1-40d6-87c7-019a59320276"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("946dd2c0-da26-457d-ad8c-4ba3167aa54d"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd269b97-48c0-45a2-b046-e6a8730dbc7b"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("af08f6d6-b7c6-43d1-9f43-0d58376f1628"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("1374d32a-f908-40e6-bf89-db89d892800d"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("5b57f2b2-ecee-4016-9433-31ce467f75e4"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("c8013d26-15c8-4309-8bd8-b47ac03d9b59"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("16f2c6ff-c1c8-4618-a4e9-e3c0db708ee5"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("0d16c05d-2fc2-4a8a-8988-a0236870a419"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6aa112f-0172-4d91-a4d7-4aca0c91d611"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa42b756-be31-4168-9f40-03d0cd697284"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("87858d3a-ae6e-4ec8-9258-e827e98d90d9"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("4afc82d3-cf77-4ec0-9e1c-95ac9e097615"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("de2b38a3-9f52-4d0b-8df6-067cb01d12fa"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Value = @"b0e78c23-7095-4d59-b8eb-c10243bcd67b",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2486b970-ba2a-4d75-ad7e-6a6ca3693558"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0582550-2e0c-4765-8c6b-c7cbbd545084"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				UId = new Guid("0b9fe44f-dae0-43df-bf4f-456291e2c0f3"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85beb4a5-021f-4174-8075-c753178d9f8c"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,219,110,219,70,16,253,21,129,201,67,11,104,132,189,113,47,122,109,130,194,128,147,26,117,154,23,203,15,179,187,179,177,0,137,52,40,42,70,42,232,223,59,164,229,70,78,83,21,48,210,22,77,202,7,9,228,238,92,247,156,57,187,171,158,247,31,110,169,154,87,111,168,235,112,211,150,126,246,67,219,209,236,162,107,19,109,54,179,243,54,225,106,249,43,198,21,93,96,135,107,234,169,123,139,171,45,109,206,151,155,126,58,121,108,86,77,171,231,239,199,213,106,126,181,171,206,122,90,255,114,150,217,59,162,116,82,69,4,172,165,3,131,161,64,76,168,65,80,86,218,229,140,38,74,54,78,237,106,187,110,94,81,143,23,216,223,84,243,93,53,122,99,7,81,56,139,46,40,48,42,100,48,46,71,240,65,102,176,86,73,109,36,138,152,169,218,79,171,77,186,161,53,142,65,143,141,201,249,164,52,56,17,106,48,185,14,16,61,69,72,82,40,163,99,202,214,197,193,248,176,255,163,225,213,179,171,179,205,79,119,13,117,151,163,223,121,193,213,134,174,103,252,245,147,15,191,55,103,190,171,13,10,12,57,64,157,50,167,90,39,4,175,108,0,71,82,75,79,78,184,168,246,215,207,174,135,136,121,185,185,93,225,135,183,127,12,124,78,152,239,247,220,62,234,251,241,174,221,226,254,248,22,213,124,241,103,7,120,248,191,79,247,241,17,126,122,122,139,106,186,168,46,219,109,151,6,143,122,120,121,232,230,24,65,28,30,248,204,207,195,115,239,99,52,123,133,13,190,163,238,53,71,28,205,199,165,23,216,227,24,252,13,231,253,224,88,105,33,125,109,29,160,212,9,140,86,2,188,245,14,74,182,37,144,182,33,196,60,90,255,76,133,58,106,18,61,49,177,49,242,199,100,30,128,198,95,154,237,106,53,6,216,140,245,15,200,61,36,126,88,121,113,116,82,71,30,218,188,44,75,202,103,205,83,50,218,87,251,253,244,17,77,180,241,94,57,15,37,114,249,198,214,2,34,170,12,129,36,55,8,131,168,139,62,73,19,116,24,164,64,70,156,200,2,12,73,132,80,167,4,142,241,88,84,86,65,150,240,229,105,210,208,221,228,199,237,50,127,183,168,152,138,197,7,98,180,215,34,114,2,145,121,154,48,65,41,58,68,107,188,145,148,22,213,247,167,176,255,52,111,255,179,228,155,97,137,171,235,98,92,178,64,222,176,32,36,43,1,99,100,144,71,138,172,5,137,124,20,39,89,66,177,216,24,131,6,143,104,89,141,132,132,32,68,134,100,9,173,195,82,72,201,127,83,76,94,174,104,77,77,63,223,185,34,180,242,69,131,141,53,39,90,179,158,68,76,172,122,217,164,232,80,69,227,244,254,177,250,132,108,185,20,97,88,95,185,44,147,50,87,105,209,0,134,200,62,10,207,151,232,254,90,125,14,170,177,108,222,77,250,27,154,116,180,217,174,250,73,91,38,183,195,2,229,113,161,157,220,96,147,219,82,102,99,85,223,138,90,69,21,106,225,100,97,65,199,192,67,201,42,240,121,24,180,50,196,162,157,86,165,168,83,60,148,54,178,166,213,18,60,227,12,140,100,0,249,204,211,26,189,208,217,88,175,115,214,255,9,30,154,200,90,101,85,130,224,52,163,83,13,160,243,252,154,131,203,142,178,174,131,86,39,121,88,24,191,201,115,39,81,42,166,18,67,19,162,42,17,68,205,93,137,62,163,55,233,203,243,240,178,239,24,190,140,161,38,97,207,34,115,214,148,182,91,99,191,108,155,9,198,118,219,127,30,228,220,167,233,228,101,243,126,217,181,205,192,206,217,107,186,59,95,54,140,203,127,134,216,206,97,46,148,45,75,187,70,190,36,17,1,26,81,67,97,240,9,95,188,165,132,3,177,79,106,235,223,80,251,72,89,202,199,187,39,71,227,227,126,116,112,196,245,96,120,72,239,235,31,18,73,20,97,172,26,46,113,124,155,53,60,140,193,27,170,33,24,25,114,242,53,15,1,249,181,138,245,245,254,55,70,89,192,100,87,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca953947-82c9-4fca-ad12-345201627164"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("f7d955b1-b130-45d2-b90b-36a4a2ff1c1b"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86baa44f-1be5-4c2b-afba-f50c69444878"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad1909b2-86a5-4387-ac62-e67d8d19b991"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,107,109,235,195,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,118,54,133,28,74,233,173,160,195,104,70,239,205,155,199,104,186,247,225,163,111,34,14,149,131,38,32,29,247,182,34,194,42,37,53,34,67,225,36,43,156,176,12,50,233,152,44,107,196,50,23,170,228,53,161,29,180,88,145,21,189,179,62,18,234,35,182,161,186,157,126,147,198,97,68,122,239,150,203,87,115,196,22,190,205,13,10,14,78,105,212,137,49,171,89,129,117,205,148,1,195,156,203,117,45,10,85,112,52,100,213,226,120,205,83,98,174,25,195,10,105,57,211,9,202,80,130,17,160,149,149,14,9,109,208,197,221,211,105,192,16,124,223,85,19,190,198,55,207,167,164,114,237,189,237,155,177,237,8,109,49,194,53,196,99,69,0,51,44,74,3,204,20,186,76,147,162,100,144,107,203,114,168,229,70,42,228,130,75,66,13,156,226,76,75,246,150,80,11,17,190,67,51,226,194,60,249,164,113,147,103,92,149,34,97,121,158,52,230,155,140,41,161,36,115,86,56,141,185,208,186,182,23,191,62,141,62,197,62,92,141,45,14,222,188,216,142,201,191,126,168,38,211,119,113,232,155,153,250,106,121,126,131,79,113,53,247,165,244,99,29,40,166,252,12,34,103,58,6,220,54,30,187,184,235,76,111,125,247,176,114,158,207,9,210,158,96,240,225,226,194,238,113,132,134,208,193,63,28,255,232,214,118,12,177,111,255,163,81,105,26,51,113,164,37,91,228,206,59,104,125,56,53,240,188,220,43,242,238,113,236,227,135,207,8,118,141,200,27,68,69,238,72,89,64,6,218,106,86,26,107,217,178,21,106,35,210,142,34,207,185,66,153,201,122,115,71,146,138,127,224,190,221,135,47,63,187,203,31,88,85,31,222,167,236,155,196,245,5,89,77,127,35,231,124,152,5,29,206,233,252,2,227,206,64,245,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea16bf89-752e-4e21-a5fa-2779bbe6a5de"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,151,223,111,219,54,16,199,255,21,67,237,99,104,240,231,145,244,219,176,236,33,64,218,6,75,215,151,36,15,71,242,216,24,115,44,67,146,87,100,129,255,247,157,148,164,73,138,53,53,134,21,88,176,10,144,100,139,250,222,145,60,126,238,196,155,230,245,112,189,161,102,209,188,167,174,195,190,173,195,252,231,182,163,249,73,215,102,234,251,249,113,155,113,181,252,19,211,138,78,176,195,43,26,168,251,128,171,45,245,199,203,126,56,152,61,149,53,7,205,235,63,166,214,102,113,118,211,28,13,116,245,219,81,97,235,78,147,143,201,121,65,197,43,97,177,100,17,117,85,34,59,48,49,41,233,1,144,197,185,93,109,175,214,111,104,192,19,28,46,155,197,77,51,89,99,3,41,203,172,11,72,225,208,20,97,131,149,2,209,146,200,32,9,189,7,210,18,154,221,65,211,231,75,186,194,201,233,131,216,42,172,33,82,20,222,201,36,44,165,36,66,198,44,106,101,231,192,198,20,229,81,124,247,254,131,240,236,213,113,219,254,190,221,204,181,54,86,229,162,132,75,198,8,155,217,125,148,74,9,168,30,162,161,10,100,237,220,99,148,81,178,7,103,146,19,214,197,192,131,76,70,72,36,138,18,52,240,104,95,93,140,142,202,178,223,172,240,250,195,87,253,157,14,248,145,230,63,125,194,229,176,92,127,156,245,184,162,91,229,230,73,16,30,107,111,206,111,99,121,222,44,206,191,22,205,187,251,233,52,73,79,227,249,101,40,207,155,131,243,230,180,221,118,121,180,104,198,63,247,83,59,121,144,119,135,248,155,203,253,113,107,99,146,189,193,53,143,168,123,203,30,39,249,212,116,136,3,78,206,223,115,191,239,13,39,29,157,244,170,10,79,24,57,88,160,69,40,10,69,84,49,85,227,141,174,85,79,234,95,169,82,71,235,76,79,59,182,79,168,38,253,228,249,161,51,247,171,142,159,172,183,171,213,228,160,159,198,63,46,227,187,142,223,181,28,62,138,223,35,11,109,89,214,37,149,163,245,63,153,170,93,179,219,29,60,102,198,107,42,50,214,200,144,72,94,78,132,70,132,138,94,240,137,54,242,130,142,193,60,203,76,76,218,199,236,65,72,173,120,38,170,83,2,115,1,97,162,1,82,18,98,42,246,123,50,83,170,202,57,128,0,237,179,176,133,47,88,56,174,178,80,32,74,152,172,204,115,128,106,12,149,192,204,80,101,174,115,21,200,97,22,0,206,219,72,185,2,230,61,153,121,75,84,102,87,56,108,187,229,112,61,63,101,100,122,209,17,150,235,31,228,236,73,206,30,1,123,17,228,196,92,117,176,214,241,123,9,132,213,181,136,224,13,136,98,141,145,26,131,134,160,159,37,199,101,136,224,165,229,153,160,192,153,92,50,122,144,42,87,47,128,108,74,1,83,220,247,32,231,236,168,127,247,105,77,221,237,44,44,42,174,122,186,152,243,211,47,30,252,178,162,43,90,15,139,27,95,165,209,97,228,37,57,30,169,43,69,36,102,92,64,177,57,121,212,201,122,179,99,193,231,92,191,184,49,24,144,52,103,5,78,170,44,9,156,36,3,177,78,5,52,65,106,235,60,194,238,226,91,204,221,85,146,177,56,13,151,52,235,168,223,174,134,89,91,103,155,177,129,202,212,208,206,46,113,93,218,90,111,217,28,171,211,15,22,247,99,145,100,73,148,180,22,54,26,190,16,145,192,80,181,64,109,61,186,154,41,132,240,34,88,68,116,65,69,151,68,146,192,95,126,148,188,136,100,71,22,81,26,50,25,76,206,223,96,81,114,197,139,192,6,2,87,49,165,129,171,24,211,149,107,41,89,59,103,34,202,23,203,98,86,92,202,147,20,156,84,184,196,131,118,34,184,49,247,6,192,224,117,200,228,245,158,44,142,124,125,230,109,49,123,196,231,45,155,243,119,155,77,219,13,219,53,23,199,89,59,14,236,7,138,251,161,168,32,145,1,254,120,10,149,24,69,229,34,127,144,22,222,127,4,105,138,133,192,245,192,188,8,20,139,117,144,108,208,130,106,194,177,170,105,193,37,157,248,23,72,84,0,129,207,103,81,180,217,32,84,149,68,140,133,81,76,88,69,136,206,10,222,190,105,111,139,4,239,242,75,69,81,87,31,141,114,142,37,153,81,204,201,10,140,188,139,168,146,223,231,140,27,181,178,255,22,138,135,148,151,253,178,93,207,10,14,255,155,138,8,35,45,145,119,240,168,144,49,114,188,18,146,230,218,198,27,119,116,214,106,149,164,122,14,195,189,59,246,31,196,240,98,247,23,250,234,201,215,105,17,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("96352b96-718c-4854-ab6d-31d33673a18b"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702f5fbb-ed10-4780-81d7-ed81fe787102"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24e70e39-6f35-420e-8745-11cb3e30fc29"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,127,200,150,228,30,183,219,178,80,210,64,183,37,144,44,97,36,141,178,2,127,108,44,153,38,152,253,239,149,237,108,10,57,148,210,91,65,135,209,88,239,205,155,231,153,233,222,249,79,174,9,56,212,22,26,143,201,184,51,53,169,56,88,86,113,69,75,173,83,202,120,140,132,173,36,45,0,149,49,156,89,166,74,146,116,208,98,77,86,244,214,184,64,18,23,176,245,245,237,244,155,52,12,35,38,247,118,185,124,211,71,108,225,251,92,128,101,96,133,68,73,121,153,42,202,80,197,2,26,52,181,182,144,170,98,130,101,168,201,170,133,33,160,205,153,160,32,74,65,153,205,99,164,68,78,173,212,42,47,11,102,21,42,146,132,193,181,31,33,224,222,181,120,13,67,84,22,11,238,251,57,181,106,104,208,134,237,211,105,64,239,93,223,213,19,190,198,251,231,83,108,99,21,183,233,155,177,237,72,18,225,112,13,225,88,19,192,20,89,169,129,106,38,203,88,30,57,133,66,154,104,133,226,57,23,152,85,25,39,137,134,83,152,105,201,206,144,196,64,128,31,208,140,184,48,79,46,54,145,23,105,38,202,42,98,179,66,83,86,228,41,21,149,224,212,154,202,74,44,42,41,149,185,24,250,121,116,49,118,254,106,108,113,112,250,229,191,96,52,184,31,234,73,247,93,24,250,102,166,190,90,158,239,241,41,172,238,191,124,186,89,27,10,49,63,131,200,57,25,61,110,26,135,93,216,118,186,55,174,123,88,57,207,231,8,105,79,48,56,127,113,97,251,56,66,67,146,193,61,28,255,232,214,102,244,161,111,255,163,86,147,216,230,58,20,139,220,121,72,141,243,167,6,158,151,123,77,222,61,142,125,248,240,5,193,172,17,121,131,168,201,29,41,25,164,32,141,140,107,97,12,93,166,66,228,113,45,56,102,69,38,144,167,92,229,119,36,170,248,7,238,219,157,255,250,179,187,44,201,170,250,240,62,102,223,36,94,135,187,158,254,70,206,249,48,11,58,156,227,249,5,86,230,180,189,235,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa996c30-4714-41b7-ba32-536d65ced754"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,77,111,27,55,16,253,43,6,147,163,70,24,126,147,190,21,205,197,128,147,24,113,154,75,148,195,144,28,38,66,36,173,177,187,106,225,24,250,239,165,214,50,108,21,141,43,20,45,16,20,221,3,23,187,228,155,55,228,123,195,185,19,47,199,219,27,22,231,226,61,247,61,13,93,29,231,63,119,61,207,175,250,46,243,48,204,47,187,76,171,229,55,74,43,190,162,158,214,60,114,255,129,86,91,30,46,151,195,56,59,59,134,137,153,120,249,235,52,43,206,63,222,137,139,145,215,191,92,148,22,221,69,169,66,76,5,146,163,0,6,145,32,112,82,160,152,28,42,93,200,146,108,224,220,173,182,235,205,107,30,233,138,198,47,226,252,78,76,209,90,128,148,49,171,226,16,44,233,2,38,24,4,34,195,144,29,50,121,239,88,161,19,187,153,24,242,23,94,211,68,250,8,54,146,106,136,28,193,91,76,96,56,37,8,153,50,212,170,99,114,45,152,228,188,7,31,214,63,2,63,190,184,236,186,175,219,155,185,82,218,200,92,36,216,164,53,152,220,232,35,74,9,174,122,23,53,87,199,198,204,61,69,140,216,24,172,78,22,140,141,1,162,74,26,144,152,35,58,229,178,117,47,62,237,137,202,114,184,89,209,237,135,239,242,93,143,244,153,231,63,253,70,203,113,185,249,124,54,208,138,239,145,55,71,34,60,197,222,45,238,181,92,136,243,197,247,212,60,188,175,167,67,58,214,243,143,82,46,196,108,33,174,187,109,159,247,17,245,254,227,225,104,39,6,60,60,240,39,195,195,115,31,99,130,189,166,77,219,81,255,166,49,78,240,105,234,21,141,52,145,191,111,121,63,4,78,42,90,244,178,130,103,138,77,44,167,32,20,73,16,101,76,85,123,173,106,85,19,250,29,87,238,121,147,249,56,177,83,164,154,240,19,243,99,50,15,174,107,127,54,219,213,106,34,24,166,253,239,109,124,72,252,48,243,234,137,126,79,34,116,101,89,151,92,46,54,127,231,168,118,98,183,155,61,173,25,150,86,185,210,156,84,144,61,152,102,84,32,99,51,20,239,9,109,49,104,93,253,139,154,161,32,61,235,102,123,215,106,6,155,31,67,64,3,193,198,104,80,75,44,46,252,243,53,179,16,111,251,194,253,66,60,103,244,163,69,255,125,79,107,101,201,235,20,0,171,105,82,26,66,104,7,168,192,59,108,182,12,136,154,242,115,158,62,57,177,31,221,211,197,88,25,115,114,80,61,53,75,106,153,32,198,92,161,221,238,201,36,137,38,165,240,172,167,99,82,62,102,239,0,149,108,213,93,173,4,202,197,129,142,218,177,68,215,122,140,249,55,251,64,169,50,231,224,192,41,159,193,148,54,80,105,119,21,22,14,204,137,146,193,60,119,174,106,205,37,180,62,192,181,245,170,182,63,106,87,23,56,103,189,137,156,171,163,124,98,31,120,195,92,206,214,52,110,251,229,120,59,191,110,109,96,128,158,169,220,254,223,13,226,105,221,224,4,193,126,212,202,249,180,251,29,150,237,164,112,159,9,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadHandoffProcess = CreateLeadHandoffProcessLaneSet();
			LaneSets.Add(schemaLeadHandoffProcess);
			ProcessSchemaLane schemaLeadHandoff = CreateLeadHandoffLane();
			schemaLeadHandoffProcess.Lanes.Add(schemaLeadHandoff);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminatenurturing = CreateTerminateNurturingTerminateEvent();
			FlowElements.Add(terminatenurturing);
			ProcessSchemaExclusiveGateway exclusivegatewayleaddefined = CreateExclusiveGatewayLeadDefinedExclusiveGateway();
			FlowElements.Add(exclusivegatewayleaddefined);
			ProcessSchemaTerminateEvent terminateleadundefined = CreateTerminateLeadUndefinedTerminateEvent();
			FlowElements.Add(terminateleadundefined);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask activityusertaskbant = CreateActivityUserTaskBANTUserTask();
			FlowElements.Add(activityusertaskbant);
			ProcessSchemaUserTask changeleadstatetonointerest = CreateChangeLeadStateToNoInterestUserTask();
			FlowElements.Add(changeleadstatetonointerest);
			ProcessSchemaUserTask changeleadnurturing = CreateChangeLeadNurturingUserTask();
			FlowElements.Add(changeleadnurturing);
			ProcessSchemaTerminateEvent terminateopportunity = CreateTerminateOpportunityTerminateEvent();
			FlowElements.Add(terminateopportunity);
			ProcessSchemaTerminateEvent terminatenointerest = CreateTerminateNoInterestTerminateEvent();
			FlowElements.Add(terminatenointerest);
			ProcessSchemaUserTask autogeneratedpagehandoff = CreateAutoGeneratedPageHandoffUserTask();
			FlowElements.Add(autogeneratedpagehandoff);
			ProcessSchemaUserTask readleadforhandoff = CreateReadLeadForHandoffUserTask();
			FlowElements.Add(readleadforhandoff);
			ProcessSchemaUserTask readactivitydata = CreateReadActivityDataUserTask();
			FlowElements.Add(readactivitydata);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow9ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow7ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5b260b1a-a023-4cd9-a40d-481707a20898"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("c46387cf-300b-4cd8-be2d-4740b8665e12"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(182, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowLeadDefined",
				UId = new Guid("ec60176a-01ca-46d0-bf66-047ed4a197d9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(242, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("f4359b3c-140b-4cfa-a64a-624975aad45f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(566, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow9ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow9",
				UId = new Guid("1c27d27e-3f1d-4f64-a277-78d7380f5bb1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(560, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("e07f0e4a-f36b-1410-6698-00155d043204"),
					}},
				}
			};
			schemaFlow.PolylinePointPositions.Add(new Point(371, 414));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow7ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow7",
				UId = new Guid("37f09d58-5453-451a-97f7-c4f7dcacee68"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(582, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("d76ddb1d-3dc5-4e4a-a026-c27588143f72"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(956, 295),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("4c30ec94-2c81-4c4f-889c-bea3f5a1139b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(923, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("31b52b04-44cf-4b5c-9b9b-5d4441942c8f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(956, 180),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("da8b2a97-17f6-4b09-944c-d3169e2a7cf5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(712, 163),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("98857f24-89e8-4af8-bd7b-bd7edc0c46e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(353, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("23ff5267-6922-4cdf-bc26-a9d0f2ececcd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(326, 164),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("d87d32bc-f36b-1410-6598-00155d043204"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("528b01b5-68f3-4731-884e-9434c98dfe97"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(1148, 189),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1251ae43-7225-4df5-993b-23aae9b2351a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(952, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b189122e-cd60-4368-8d1c-eed898c517dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2dc83e6e-1ed4-44d5-8886-72aa55f8985d"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(1162, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("8cdb95ca-c8ea-4880-b7cc-741fa584081f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadHandoffProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadHandoffProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c46f8bb0-50e4-4535-913d-d89bd088077f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"LeadHandoffProcess",
				Position = new Point(5, 5),
				Size = new Size(1232, 599),
				UseBackgroundMode = false
			};
			return schemaLeadHandoffProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadHandoffLane() {
			ProcessSchemaLane schemaLeadHandoff = new ProcessSchemaLane(this) {
				UId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("c46f8bb0-50e4-4535-913d-d89bd088077f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"LeadHandoff",
				Position = new Point(29, 0),
				Size = new Size(1203, 599),
				UseBackgroundMode = false
			};
			return schemaLeadHandoff;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"Start",
				Position = new Point(50, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNurturingTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"TerminateNurturing",
				Position = new Point(673, 282),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayLeadDefinedExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ExclusiveGatewayLeadDefined",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(120, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateLeadUndefinedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"TerminateLeadUndefined",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(134, 289),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(218, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateActivityUserTaskBANTUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ActivityUserTaskBANT",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(337, 156),
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeActivityUserTaskBANTParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadStateToNoInterestUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ChangeLeadStateToNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 387),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadStateToNoInterestParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadNurturingUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ChangeLeadNurturing",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 268),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadNurturingParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateOpportunityTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"TerminateOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1149, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNoInterestTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"TerminateNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(673, 401),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"AutoGeneratedPageHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(785, 156),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAutoGeneratedPageHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadForHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ReadLeadForHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(652, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadForHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadActivityDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ReadActivityData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadActivityDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"AddDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(912, 156),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2dc83e6e-1ed4-44d5-8886-72aa55f8985d"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ChangeDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1039, 156),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4"),
				Name = @"ChangeDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1039, 34),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementHandoffFinance(userConnection);
		}

		public override object Clone() {
			return new LeadManagementHandoffFinanceSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("604808a6-567a-468c-889a-a25a7223d7e4"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementHandoffFinance

	/// <exclude/>
	public class LeadManagementHandoffFinance : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadHandoff

		/// <exclude/>
		public class ProcessLeadHandoff : ProcessLane
		{

			public ProcessLeadHandoff(UserConnection userConnection, LeadManagementHandoffFinance process)
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

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,201,150,45,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,203,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,63,126,244,117,192,161,116,80,143,152,76,7,91,18,89,57,167,242,84,81,169,11,160,130,113,73,65,113,69,153,144,76,240,76,2,58,36,73,11,13,150,100,67,239,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,222,173,151,175,230,132,13,124,91,26,8,14,78,105,212,84,230,172,162,2,171,138,42,3,134,58,151,233,170,16,74,112,52,100,211,194,164,176,58,214,83,89,229,41,21,144,58,170,92,90,209,130,129,112,150,27,237,88,74,146,26,93,216,63,245,3,142,163,239,218,114,198,215,248,230,185,143,42,183,222,187,174,158,154,150,36,13,6,184,134,112,42,9,32,67,145,27,160,70,232,156,10,135,113,210,76,91,154,65,37,83,169,144,23,92,146,196,64,31,22,90,114,176,36,177,16,224,59,212,19,174,204,179,143,26,211,140,113,149,23,17,203,51,67,69,150,50,170,10,37,169,179,133,211,152,21,90,87,246,226,215,167,201,199,216,143,87,83,131,131,55,47,182,99,244,175,27,202,217,116,109,24,186,122,161,190,90,203,111,240,41,108,230,190,60,253,216,6,10,49,191,128,200,57,153,70,220,213,30,219,176,111,77,103,125,251,176,113,158,207,17,210,244,48,248,241,226,194,254,113,130,154,36,131,127,56,253,209,173,221,52,134,174,249,143,70,77,226,152,145,35,46,217,42,119,217,65,235,199,190,134,231,245,94,146,119,143,83,23,62,124,70,176,91,68,222,32,74,114,71,114,1,12,180,213,52,55,214,210,117,43,84,90,196,29,69,158,113,133,146,201,42,189,35,81,197,63,112,223,30,198,47,63,219,203,31,216,84,31,223,199,236,155,196,245,5,89,206,127,35,231,124,92,4,29,207,241,252,2,68,247,49,72,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ActivityUserTaskBANTFlowElement

		/// <exclude/>
		public class ActivityUserTaskBANTFlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTaskBANTFlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTaskBANT";
				IsLogging = true;
				SchemaElementUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_lead = () => (Guid)((process.LeadId));
				_account = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("604808a6567a468c889aa25a7223d7e4",
						 "BaseElements.ActivityUserTaskBANT.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _activityCategory = new Guid("f51c4643-58e6-df11-971b-001d60e938c6");
			public override Guid ActivityCategory {
				get {
					return _activityCategory;
				}
				set {
					_activityCategory = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			private int _duration = 60;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _remindBefore = 0;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
				}
			}

			private bool _showInScheduler = true;
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

			internal Func<Guid> _lead;
			public override Guid Lead {
				get {
					return (_lead ?? (_lead = () => Guid.Empty)).Invoke();
				}
				set {
					_lead = () => { return value; };
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("604808a6567a468c889aa25a7223d7e4",
						 "BaseElements.ActivityUserTaskBANT.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"89a7d2c0-103f-4f41-87f7-265a34bf1d89\",\"e07f0e4a-f36b-1410-6698-00155d043204\",\"a08e24ec-c5d1-4951-b49f-5e70dde6a7d9\",\"d87d32bc-f36b-1410-6598-00155d043204\",\"fdc13e7b-c600-487f-a398-7240d059ee6a\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: ChangeLeadStateToNoInterestFlowElement

		/// <exclude/>
		public class ChangeLeadStateToNoInterestFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadStateToNoInterestFlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadStateToNoInterest";
				IsLogging = true;
				SchemaElementUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("f78066d3-a73e-4e86-bb99-e477fcb94b28"));
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("51adc3ec-3503-4b10-a00b-8be3b0e11f08"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,182,228,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,95,177,101,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,163,121,111,222,60,70,243,189,31,63,250,58,224,80,57,168,71,164,211,193,86,36,211,165,40,108,94,178,44,213,156,113,11,130,169,210,10,166,1,10,238,20,215,153,72,8,109,161,193,138,108,232,189,245,129,80,31,176,25,171,219,249,55,105,24,38,164,247,110,189,124,53,39,108,224,219,210,128,167,224,164,66,197,74,145,104,198,81,107,38,13,24,230,92,174,116,193,37,79,209,144,77,11,231,82,160,80,154,153,88,203,184,118,57,147,90,228,12,184,116,73,6,34,229,186,32,180,70,23,246,79,253,128,227,232,187,182,154,241,53,190,121,238,163,202,173,247,174,171,167,166,37,180,193,0,215,16,78,21,1,76,144,11,3,204,112,37,24,119,88,50,200,149,101,57,232,50,43,37,166,69,90,18,106,160,15,11,45,57,88,66,45,4,248,14,245,132,43,243,236,23,191,242,36,149,162,136,216,52,55,140,231,89,194,100,33,75,230,108,225,20,230,133,82,218,94,252,250,52,249,24,251,241,106,106,112,240,230,197,118,140,254,117,67,53,155,174,13,67,87,47,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,211,105,196,93,237,177,13,251,214,116,214,183,15,27,231,249,28,33,77,15,131,31,47,46,236,31,39,168,9,29,252,195,233,143,110,237,166,49,116,205,127,52,42,141,99,70,142,184,100,171,220,101,7,173,31,251,26,158,215,123,69,222,61,78,93,248,240,25,193,110,17,121,131,168,200,29,17,28,18,80,86,49,97,172,101,235,86,200,172,136,59,138,105,158,74,44,147,82,103,119,36,170,248,7,238,219,195,248,229,103,123,249,3,155,234,227,251,152,125,147,184,190,32,171,249,111,228,156,143,139,160,227,57,158,95,209,224,137,218,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,83,209,78,219,48,20,253,21,100,120,236,141,236,216,177,227,190,142,23,36,64,104,48,94,40,15,215,246,245,136,150,54,85,146,78,98,85,255,125,174,105,69,59,141,9,33,77,218,195,242,224,40,177,207,57,247,222,227,179,102,103,227,243,146,216,148,221,81,223,227,208,197,177,248,212,245,84,220,244,157,167,97,40,46,59,143,109,243,3,93,75,55,216,227,156,70,234,239,177,93,209,112,217,12,227,228,228,24,198,38,236,236,123,222,101,211,135,53,187,24,105,254,229,34,36,118,47,148,228,174,50,80,85,49,130,242,193,0,58,69,128,117,224,88,233,42,212,198,39,176,239,218,213,124,113,69,35,222,224,248,196,166,107,150,217,18,129,117,165,177,222,104,224,165,144,160,98,37,0,125,208,32,173,212,36,184,182,46,40,182,153,176,193,63,209,28,179,232,43,88,9,140,181,37,11,166,226,14,20,57,7,181,71,15,49,74,235,180,170,149,32,191,5,239,206,191,2,31,78,47,187,238,219,106,89,148,33,10,239,107,13,186,52,30,84,72,11,6,17,129,7,170,137,92,234,133,251,34,154,154,107,29,36,160,145,148,100,210,113,231,172,5,82,198,68,239,172,114,101,125,250,184,21,10,205,176,108,241,249,254,77,189,107,162,112,50,199,113,213,55,227,115,113,221,141,39,205,34,77,158,134,145,194,11,197,242,200,141,67,146,245,236,197,212,25,155,206,222,178,117,247,190,205,211,58,54,246,87,79,103,108,50,99,183,221,170,247,91,70,185,253,216,207,56,43,240,221,3,191,89,246,207,11,71,134,93,225,2,191,82,127,157,20,51,60,111,157,227,136,89,252,46,213,189,39,118,165,173,184,73,67,54,132,54,141,83,151,80,7,129,96,133,117,81,26,89,198,88,102,244,103,138,105,52,11,79,199,133,189,199,179,140,207,202,175,197,236,175,95,250,179,88,181,109,22,24,114,255,219,251,188,43,124,183,115,126,96,228,1,67,23,154,216,80,184,88,124,100,84,27,182,217,76,14,195,35,48,72,45,164,0,151,154,72,141,112,1,86,133,18,66,52,92,152,218,150,36,241,143,225,113,158,251,50,104,14,21,202,0,233,190,115,64,76,233,243,154,19,26,163,169,228,250,111,134,167,148,74,248,32,160,114,50,101,215,39,121,203,133,0,29,141,182,146,162,38,165,138,42,117,233,37,121,144,21,79,135,156,72,53,242,36,88,59,146,142,147,16,145,191,55,60,183,99,186,97,255,67,131,31,10,205,59,188,250,87,67,243,184,249,9,207,214,238,57,207,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "604808a6567a468c889aa25a7223d7e4",
							"BaseElements.ChangeLeadStateToNoInterest.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b");
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

		#region Class: ChangeLeadNurturingFlowElement

		/// <exclude/>
		public class ChangeLeadNurturingFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadNurturingFlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadNurturing";
				IsLogging = true;
				SchemaElementUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("5b3d1046-fc16-45c8-a5a1-298dfc857546"));
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("14cfc644-e3ed-497e-8279-ed4319bb8093"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,75,107,220,48,16,254,47,58,244,100,21,217,150,109,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,95,177,100,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,99,127,143,249,24,205,247,206,127,116,77,192,177,182,208,120,76,166,131,169,9,67,171,37,23,5,197,146,43,202,81,11,10,10,56,69,76,141,201,76,197,180,209,36,233,160,197,154,108,232,189,113,129,36,46,96,235,235,219,249,55,105,24,39,76,238,237,122,249,170,79,216,194,183,69,128,167,96,133,68,73,171,130,45,2,74,81,161,65,83,107,115,169,74,46,120,138,81,96,245,82,9,166,51,80,150,166,86,49,202,45,147,20,140,150,148,41,169,37,242,50,203,181,33,73,131,54,236,159,134,17,189,119,125,87,207,248,90,223,60,15,209,229,166,189,235,155,169,237,72,210,98,128,107,8,167,154,0,50,228,133,6,170,185,44,34,59,86,20,114,105,104,14,170,202,42,129,105,153,86,36,209,48,132,133,150,28,162,148,129,0,223,161,153,112,101,158,93,244,152,229,44,21,69,25,177,105,174,41,207,51,70,69,41,42,106,77,105,37,230,165,148,202,92,242,250,52,185,88,59,127,53,181,56,58,253,18,59,198,252,250,177,158,117,223,133,177,111,22,234,171,245,247,27,124,10,91,184,47,159,126,108,3,133,216,95,64,228,156,76,30,119,141,195,46,236,59,221,27,215,61,108,156,231,115,132,180,3,140,206,95,82,216,63,78,208,144,100,116,15,167,63,166,181,155,124,232,219,255,104,212,36,142,25,57,226,146,173,118,151,29,52,206,15,13,60,175,247,154,188,123,156,250,240,225,51,130,217,42,242,6,81,147,59,82,112,96,32,141,164,133,54,134,174,91,33,178,50,238,40,166,121,42,176,98,149,202,238,72,116,241,15,220,183,7,255,229,103,119,121,3,155,235,227,251,216,125,211,184,190,32,235,249,111,236,156,143,139,161,227,57,158,95,203,128,158,28,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,77,79,219,64,16,253,43,200,112,204,68,251,229,93,111,174,229,130,4,8,21,202,133,112,152,157,157,45,86,147,56,178,29,36,138,242,223,187,49,137,72,170,82,69,149,42,245,208,61,172,101,175,223,123,227,121,243,252,90,156,245,47,75,46,38,197,29,183,45,118,77,234,199,159,154,150,199,55,109,67,220,117,227,203,134,112,86,127,199,48,227,27,108,113,206,61,183,247,56,91,113,119,89,119,253,232,228,16,86,140,138,179,231,225,180,152,60,188,22,23,61,207,191,92,196,204,30,74,150,214,106,3,145,243,102,144,36,132,210,24,208,201,122,174,164,34,50,50,131,169,153,173,230,139,43,238,241,6,251,167,98,242,90,12,108,153,192,7,229,60,57,11,66,73,13,38,149,18,144,162,5,237,181,101,41,172,15,209,20,235,81,209,209,19,207,113,16,125,7,27,137,169,242,236,193,149,34,128,225,16,160,34,36,72,73,251,96,77,101,36,211,6,188,125,255,29,248,112,122,217,52,223,86,203,177,138,73,18,85,22,172,114,4,38,230,13,163,76,32,34,87,204,1,131,17,52,46,131,142,82,24,11,137,164,5,83,82,5,88,162,4,229,171,152,168,42,93,105,236,233,227,70,40,214,221,114,134,47,247,31,234,93,51,199,147,57,246,171,182,238,95,198,231,117,71,205,51,183,28,223,224,203,3,39,246,9,94,167,111,134,78,139,201,244,35,75,183,215,219,161,83,135,166,254,236,231,180,24,77,139,219,102,213,210,134,81,111,110,118,253,29,20,196,118,193,47,182,221,122,227,24,96,87,184,192,175,220,94,103,197,1,62,28,157,99,143,131,248,93,174,123,71,28,148,47,133,203,13,118,140,62,59,102,21,84,81,34,120,233,67,210,78,171,148,212,128,254,204,41,247,101,65,124,88,216,49,126,13,248,65,249,189,152,221,232,229,39,139,213,108,54,8,116,195,247,111,102,121,91,248,246,228,124,207,196,61,134,38,214,169,230,120,177,248,147,86,173,139,245,122,180,31,28,175,4,42,42,67,142,75,153,192,120,46,1,181,10,128,142,164,115,50,138,224,171,223,6,39,144,32,21,173,128,18,117,132,60,235,2,16,13,3,89,193,232,156,101,37,236,223,12,142,210,70,82,148,144,195,145,115,75,89,222,11,41,193,38,103,189,230,100,217,152,177,52,148,200,230,223,1,107,206,53,122,199,80,229,184,3,71,163,179,225,161,18,94,31,25,156,219,62,79,216,38,48,125,91,135,85,95,55,139,255,145,241,199,69,230,8,167,254,213,200,60,174,127,0,175,75,31,53,201,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "604808a6567a468c889aa25a7223d7e4",
							"BaseElements.ChangeLeadNurturing.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b");
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

		#region Class: AutoGeneratedPageHandoffFlowElement

		/// <exclude/>
		public class AutoGeneratedPageHandoffFlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public AutoGeneratedPageHandoffFlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AutoGeneratedPageHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_showExecutionPage = () => (bool)(true);
				_leadType = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_opportunityResponsible = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("SalesOwner").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("SalesOwnerId") : Guid.Empty)));
				_decisionDate = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("DecisionDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("DecisionDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_comment = () => new LocalizableString(((process.ReadActivityData.ResultEntity.IsColumnValueLoaded(process.ReadActivityData.ResultEntity.Schema.Columns.GetByName("DetailedResult").ColumnValueName) ? process.ReadActivityData.ResultEntity.GetTypedColumnValue<string>("DetailedResult") : null)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("604808a6567a468c889aa25a7223d7e4",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("604808a6567a468c889aa25a7223d7e4",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("604808a6567a468c889aa25a7223d7e4",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("604808a6567a468c889aa25a7223d7e4",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Elements.Value"));
				}
				set {
					_elements = value;
				}
			}

			internal Func<bool> _showExecutionPage;
			public override bool ShowExecutionPage {
				get {
					return (_showExecutionPage ?? (_showExecutionPage = () => false)).Invoke();
				}
				set {
					_showExecutionPage = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("604808a6567a468c889aa25a7223d7e4",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			internal Func<Guid> _leadType;
			public virtual Guid LeadType {
				get {
					return (_leadType ?? (_leadType = () => Guid.Empty)).Invoke();
				}
				set {
					_leadType = () => { return value; };
				}
			}

			internal Func<Guid> _opportunityResponsible;
			public virtual Guid OpportunityResponsible {
				get {
					return (_opportunityResponsible ?? (_opportunityResponsible = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityResponsible = () => { return value; };
				}
			}

			internal Func<DateTime> _decisionDate;
			public virtual DateTime DecisionDate {
				get {
					return (_decisionDate ?? (_decisionDate = () => DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).Invoke();
				}
				set {
					_decisionDate = () => { return value; };
				}
			}

			internal Func<string> _comment;
			public virtual string Comment {
				get {
					return (_comment ?? (_comment = () => null)).Invoke();
				}
				set {
					_comment = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadLeadForHandoffFlowElement

		/// <exclude/>
		public class ReadLeadForHandoffFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadForHandoffFlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadForHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,91,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,201,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,231,63,186,38,224,88,89,104,60,38,211,193,84,36,67,38,24,160,162,66,151,37,21,32,107,170,108,94,83,97,10,100,41,207,121,46,107,146,116,208,98,69,54,244,222,184,64,18,23,176,245,213,237,252,155,52,140,19,38,247,118,189,124,213,39,108,225,219,210,64,100,96,165,138,13,202,60,141,180,88,215,84,106,208,212,90,174,234,66,72,145,161,38,155,22,45,176,96,32,74,90,167,44,143,165,220,208,90,3,82,174,114,205,153,176,38,183,146,36,13,218,176,127,26,70,244,222,245,93,53,227,107,124,243,60,68,149,91,239,93,223,76,109,71,146,22,3,92,67,56,85,4,48,69,145,107,160,90,168,200,110,177,164,192,149,161,28,234,146,149,18,179,34,43,73,162,97,8,11,45,57,24,146,24,8,240,29,154,9,87,230,217,69,141,140,167,153,204,139,136,205,184,166,130,179,148,202,66,150,212,154,194,42,228,133,82,181,185,248,245,105,114,49,118,254,106,106,113,116,250,197,118,140,254,245,99,53,235,190,11,99,223,44,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,39,147,199,93,227,176,11,251,78,247,198,117,15,27,231,249,28,33,237,0,163,243,23,23,246,143,19,52,36,25,221,195,233,143,110,237,38,31,250,246,63,26,53,137,99,70,142,184,100,171,220,101,7,141,243,67,3,207,235,189,34,239,30,167,62,124,248,140,96,182,136,188,65,84,228,142,228,2,82,80,70,209,92,27,67,215,173,144,172,136,59,138,25,207,36,150,105,89,179,59,18,85,252,3,247,237,193,127,249,217,93,254,192,166,250,248,62,102,223,36,174,47,200,106,254,27,57,231,227,34,232,120,142,231,23,149,211,217,112,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ReadActivityDataFlowElement

		/// <exclude/>
		public class ReadActivityDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadActivityDataFlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadActivityData";
				IsLogging = true;
				SchemaElementUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,111,212,48,20,252,43,149,15,156,226,85,28,59,137,29,78,176,44,104,47,75,37,22,132,212,174,170,23,251,185,107,145,143,109,226,136,86,81,254,59,206,166,11,82,15,168,7,46,72,62,216,207,158,121,51,163,231,241,206,245,31,93,229,177,43,44,84,61,70,195,214,20,36,231,9,66,198,24,77,227,76,81,33,153,161,32,211,132,90,149,150,9,40,46,83,131,36,106,160,198,130,44,232,141,113,158,68,206,99,221,23,55,227,31,82,223,13,24,221,217,243,225,139,62,98,13,95,231,6,90,8,101,36,79,40,8,173,169,40,99,70,75,101,82,42,129,37,90,132,22,86,42,178,104,65,137,220,166,165,166,152,161,160,2,115,77,161,180,57,213,60,99,162,204,76,170,84,78,162,10,173,223,60,158,58,236,123,215,54,197,136,191,247,251,167,83,80,185,244,94,183,213,80,55,36,170,209,195,53,248,99,65,0,99,20,169,6,170,133,74,169,176,152,83,224,202,80,14,101,158,228,18,89,198,2,187,134,147,159,105,201,214,144,200,128,135,111,80,13,120,102,30,93,208,152,240,152,201,52,11,88,198,131,29,158,196,84,102,50,167,214,100,86,33,207,148,42,205,37,175,79,131,11,123,215,239,134,26,59,167,159,99,199,144,95,219,21,163,110,27,223,181,213,76,189,59,63,223,227,163,95,194,125,190,250,190,24,242,161,62,131,200,20,13,61,174,43,135,141,223,52,186,53,174,185,95,56,167,41,64,234,19,116,174,191,164,176,121,24,160,34,81,231,238,143,127,77,107,61,244,190,173,255,35,171,81,176,25,56,194,144,157,229,206,51,104,92,127,170,224,233,124,46,200,155,135,161,245,111,247,208,255,40,174,62,160,117,13,94,189,127,183,219,175,230,202,213,214,44,215,228,5,77,65,110,137,148,178,228,74,100,148,151,202,134,1,49,72,165,65,164,92,165,0,146,113,198,180,94,137,36,87,44,101,130,106,59,255,23,20,37,133,88,1,45,179,36,7,109,116,72,70,222,146,160,255,95,169,186,217,246,159,127,54,151,47,181,132,112,88,133,234,139,194,166,194,58,164,85,140,175,177,49,5,192,245,165,85,49,190,198,212,116,152,109,29,166,176,126,1,177,30,142,224,74,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })));
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
								new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"));
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

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_EntityId = () => (Guid)((process.LeadId));
				_recordDefValues_EntitySchemaUId = () => (Guid)(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
				_recordDefValues_CreatedBy = () => (Guid)((process.AutoGeneratedPageHandoff.OwnerId));
				_recordDefValues_Message = () => new LocalizableString(String.Concat("Information about proceeding to handoff:", Environment.NewLine, (process.AutoGeneratedPageHandoff.Comment)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_EntityId", () => _recordDefValues_EntityId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_EntitySchemaUId", () => _recordDefValues_EntitySchemaUId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CreatedBy", () => _recordDefValues_CreatedBy.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Message", () => _recordDefValues_Message.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_EntityId;
			internal Func<Guid> _recordDefValues_EntitySchemaUId;
			internal Func<Guid> _recordDefValues_CreatedBy;
			internal Func<string> _recordDefValues_Message;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,219,110,219,70,16,253,21,129,201,67,11,104,132,189,113,47,122,109,130,194,128,147,26,117,154,23,203,15,179,187,179,177,0,137,52,40,42,70,42,232,223,59,164,229,70,78,83,21,48,210,22,77,202,7,9,228,238,92,247,156,57,187,171,158,247,31,110,169,154,87,111,168,235,112,211,150,126,246,67,219,209,236,162,107,19,109,54,179,243,54,225,106,249,43,198,21,93,96,135,107,234,169,123,139,171,45,109,206,151,155,126,58,121,108,86,77,171,231,239,199,213,106,126,181,171,206,122,90,255,114,150,217,59,162,116,82,69,4,172,165,3,131,161,64,76,168,65,80,86,218,229,140,38,74,54,78,237,106,187,110,94,81,143,23,216,223,84,243,93,53,122,99,7,81,56,139,46,40,48,42,100,48,46,71,240,65,102,176,86,73,109,36,138,152,169,218,79,171,77,186,161,53,142,65,143,141,201,249,164,52,56,17,106,48,185,14,16,61,69,72,82,40,163,99,202,214,197,193,248,176,255,163,225,213,179,171,179,205,79,119,13,117,151,163,223,121,193,213,134,174,103,252,245,147,15,191,55,103,190,171,13,10,12,57,64,157,50,167,90,39,4,175,108,0,71,82,75,79,78,184,168,246,215,207,174,135,136,121,185,185,93,225,135,183,127,12,124,78,152,239,247,220,62,234,251,241,174,221,226,254,248,22,213,124,241,103,7,120,248,191,79,247,241,17,126,122,122,139,106,186,168,46,219,109,151,6,143,122,120,121,232,230,24,65,28,30,248,204,207,195,115,239,99,52,123,133,13,190,163,238,53,71,28,205,199,165,23,216,227,24,252,13,231,253,224,88,105,33,125,109,29,160,212,9,140,86,2,188,245,14,74,182,37,144,182,33,196,60,90,255,76,133,58,106,18,61,49,177,49,242,199,100,30,128,198,95,154,237,106,53,6,216,140,245,15,200,61,36,126,88,121,113,116,82,71,30,218,188,44,75,202,103,205,83,50,218,87,251,253,244,17,77,180,241,94,57,15,37,114,249,198,214,2,34,170,12,129,36,55,8,131,168,139,62,73,19,116,24,164,64,70,156,200,2,12,73,132,80,167,4,142,241,88,84,86,65,150,240,229,105,210,208,221,228,199,237,50,127,183,168,152,138,197,7,98,180,215,34,114,2,145,121,154,48,65,41,58,68,107,188,145,148,22,213,247,167,176,255,52,111,255,179,228,155,97,137,171,235,98,92,178,64,222,176,32,36,43,1,99,100,144,71,138,172,5,137,124,20,39,89,66,177,216,24,131,6,143,104,89,141,132,132,32,68,134,100,9,173,195,82,72,201,127,83,76,94,174,104,77,77,63,223,185,34,180,242,69,131,141,53,39,90,179,158,68,76,172,122,217,164,232,80,69,227,244,254,177,250,132,108,185,20,97,88,95,185,44,147,50,87,105,209,0,134,200,62,10,207,151,232,254,90,125,14,170,177,108,222,77,250,27,154,116,180,217,174,250,73,91,38,183,195,2,229,113,161,157,220,96,147,219,82,102,99,85,223,138,90,69,21,106,225,100,97,65,199,192,67,201,42,240,121,24,180,50,196,162,157,86,165,168,83,60,148,54,178,166,213,18,60,227,12,140,100,0,249,204,211,26,189,208,217,88,175,115,214,255,9,30,154,200,90,101,85,130,224,52,163,83,13,160,243,252,154,131,203,142,178,174,131,86,39,121,88,24,191,201,115,39,81,42,166,18,67,19,162,42,17,68,205,93,137,62,163,55,233,203,243,240,178,239,24,190,140,161,38,97,207,34,115,214,148,182,91,99,191,108,155,9,198,118,219,127,30,228,220,167,233,228,101,243,126,217,181,205,192,206,217,107,186,59,95,54,140,203,127,134,216,206,97,46,148,45,75,187,70,190,36,17,1,26,81,67,97,240,9,95,188,165,132,3,177,79,106,235,223,80,251,72,89,202,199,187,39,71,227,227,126,116,112,196,245,96,120,72,239,235,31,18,73,20,97,172,26,46,113,124,155,53,60,140,193,27,170,33,24,25,114,242,53,15,1,249,181,138,245,245,254,55,70,89,192,100,87,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "604808a6567a468c889aa25a7223d7e4",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b");
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("7a90900b-53b5-4598-92b3-0aee90626c56"));
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("66f33ed8-53ef-48cf-abf3-665749ecf6ac"));
				_recordColumnValues_LeadType = () => (Guid)((process.AutoGeneratedPageHandoff.LeadType));
				_recordColumnValues_SalesOwner = () => (Guid)((process.AutoGeneratedPageHandoff.OpportunityResponsible));
				_recordColumnValues_DecisionDate = () => (DateTime)((process.AutoGeneratedPageHandoff.DecisionDate));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadType", () => _recordColumnValues_LeadType.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SalesOwner", () => _recordColumnValues_SalesOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_DecisionDate", () => _recordColumnValues_DecisionDate.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_LeadType;
			internal Func<Guid> _recordColumnValues_SalesOwner;
			internal Func<DateTime> _recordColumnValues_DecisionDate;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,107,109,235,195,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,118,54,133,28,74,233,173,160,195,104,70,239,205,155,199,104,186,247,225,163,111,34,14,149,131,38,32,29,247,182,34,194,42,37,53,34,67,225,36,43,156,176,12,50,233,152,44,107,196,50,23,170,228,53,161,29,180,88,145,21,189,179,62,18,234,35,182,161,186,157,126,147,198,97,68,122,239,150,203,87,115,196,22,190,205,13,10,14,78,105,212,137,49,171,89,129,117,205,148,1,195,156,203,117,45,10,85,112,52,100,213,226,120,205,83,98,174,25,195,10,105,57,211,9,202,80,130,17,160,149,149,14,9,109,208,197,221,211,105,192,16,124,223,85,19,190,198,55,207,167,164,114,237,189,237,155,177,237,8,109,49,194,53,196,99,69,0,51,44,74,3,204,20,186,76,147,162,100,144,107,203,114,168,229,70,42,228,130,75,66,13,156,226,76,75,246,150,80,11,17,190,67,51,226,194,60,249,164,113,147,103,92,149,34,97,121,158,52,230,155,140,41,161,36,115,86,56,141,185,208,186,182,23,191,62,141,62,197,62,92,141,45,14,222,188,216,142,201,191,126,168,38,211,119,113,232,155,153,250,106,121,126,131,79,113,53,247,165,244,99,29,40,166,252,12,34,103,58,6,220,54,30,187,184,235,76,111,125,247,176,114,158,207,9,210,158,96,240,225,226,194,238,113,132,134,208,193,63,28,255,232,214,118,12,177,111,255,163,81,105,26,51,113,164,37,91,228,206,59,104,125,56,53,240,188,220,43,242,238,113,236,227,135,207,8,118,141,200,27,68,69,238,72,89,64,6,218,106,86,26,107,217,178,21,106,35,210,142,34,207,185,66,153,201,122,115,71,146,138,127,224,190,221,135,47,63,187,203,31,88,85,31,222,167,236,155,196,245,5,89,77,127,35,231,124,152,5,29,206,233,252,2,227,206,64,245,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,151,223,111,219,54,16,199,255,21,67,237,99,104,240,231,145,244,219,176,236,33,64,218,6,75,215,151,36,15,71,242,216,24,115,44,67,146,87,100,129,255,247,157,148,164,73,138,53,53,134,21,88,176,10,144,100,139,250,222,145,60,126,238,196,155,230,245,112,189,161,102,209,188,167,174,195,190,173,195,252,231,182,163,249,73,215,102,234,251,249,113,155,113,181,252,19,211,138,78,176,195,43,26,168,251,128,171,45,245,199,203,126,56,152,61,149,53,7,205,235,63,166,214,102,113,118,211,28,13,116,245,219,81,97,235,78,147,143,201,121,65,197,43,97,177,100,17,117,85,34,59,48,49,41,233,1,144,197,185,93,109,175,214,111,104,192,19,28,46,155,197,77,51,89,99,3,41,203,172,11,72,225,208,20,97,131,149,2,209,146,200,32,9,189,7,210,18,154,221,65,211,231,75,186,194,201,233,131,216,42,172,33,82,20,222,201,36,44,165,36,66,198,44,106,101,231,192,198,20,229,81,124,247,254,131,240,236,213,113,219,254,190,221,204,181,54,86,229,162,132,75,198,8,155,217,125,148,74,9,168,30,162,161,10,100,237,220,99,148,81,178,7,103,146,19,214,197,192,131,76,70,72,36,138,18,52,240,104,95,93,140,142,202,178,223,172,240,250,195,87,253,157,14,248,145,230,63,125,194,229,176,92,127,156,245,184,162,91,229,230,73,16,30,107,111,206,111,99,121,222,44,206,191,22,205,187,251,233,52,73,79,227,249,101,40,207,155,131,243,230,180,221,118,121,180,104,198,63,247,83,59,121,144,119,135,248,155,203,253,113,107,99,146,189,193,53,143,168,123,203,30,39,249,212,116,136,3,78,206,223,115,191,239,13,39,29,157,244,170,10,79,24,57,88,160,69,40,10,69,84,49,85,227,141,174,85,79,234,95,169,82,71,235,76,79,59,182,79,168,38,253,228,249,161,51,247,171,142,159,172,183,171,213,228,160,159,198,63,46,227,187,142,223,181,28,62,138,223,35,11,109,89,214,37,149,163,245,63,153,170,93,179,219,29,60,102,198,107,42,50,214,200,144,72,94,78,132,70,132,138,94,240,137,54,242,130,142,193,60,203,76,76,218,199,236,65,72,173,120,38,170,83,2,115,1,97,162,1,82,18,98,42,246,123,50,83,170,202,57,128,0,237,179,176,133,47,88,56,174,178,80,32,74,152,172,204,115,128,106,12,149,192,204,80,101,174,115,21,200,97,22,0,206,219,72,185,2,230,61,153,121,75,84,102,87,56,108,187,229,112,61,63,101,100,122,209,17,150,235,31,228,236,73,206,30,1,123,17,228,196,92,117,176,214,241,123,9,132,213,181,136,224,13,136,98,141,145,26,131,134,160,159,37,199,101,136,224,165,229,153,160,192,153,92,50,122,144,42,87,47,128,108,74,1,83,220,247,32,231,236,168,127,247,105,77,221,237,44,44,42,174,122,186,152,243,211,47,30,252,178,162,43,90,15,139,27,95,165,209,97,228,37,57,30,169,43,69,36,102,92,64,177,57,121,212,201,122,179,99,193,231,92,191,184,49,24,144,52,103,5,78,170,44,9,156,36,3,177,78,5,52,65,106,235,60,194,238,226,91,204,221,85,146,177,56,13,151,52,235,168,223,174,134,89,91,103,155,177,129,202,212,208,206,46,113,93,218,90,111,217,28,171,211,15,22,247,99,145,100,73,148,180,22,54,26,190,16,145,192,80,181,64,109,61,186,154,41,132,240,34,88,68,116,65,69,151,68,146,192,95,126,148,188,136,100,71,22,81,26,50,25,76,206,223,96,81,114,197,139,192,6,2,87,49,165,129,171,24,211,149,107,41,89,59,103,34,202,23,203,98,86,92,202,147,20,156,84,184,196,131,118,34,184,49,247,6,192,224,117,200,228,245,158,44,142,124,125,230,109,49,123,196,231,45,155,243,119,155,77,219,13,219,53,23,199,89,59,14,236,7,138,251,161,168,32,145,1,254,120,10,149,24,69,229,34,127,144,22,222,127,4,105,138,133,192,245,192,188,8,20,139,117,144,108,208,130,106,194,177,170,105,193,37,157,248,23,72,84,0,129,207,103,81,180,217,32,84,149,68,140,133,81,76,88,69,136,206,10,222,190,105,111,139,4,239,242,75,69,81,87,31,141,114,142,37,153,81,204,201,10,140,188,139,168,146,223,231,140,27,181,178,255,22,138,135,148,151,253,178,93,207,10,14,255,155,138,8,35,45,145,119,240,168,144,49,114,188,18,146,230,218,198,27,119,116,214,106,149,164,122,14,195,189,59,246,31,196,240,98,247,23,250,234,201,215,105,17,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "604808a6567a468c889aa25a7223d7e4",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b");
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

		#region Class: ChangeDataUserTask2FlowElement

		/// <exclude/>
		public class ChangeDataUserTask2FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, LeadManagementHandoffFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("7a90900b-53b5-4598-92b3-0aee90626c56"));
				_recordColumnValues_SaleType = () => new LocalizableString("Order");
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("66f33ed8-53ef-48cf-abf3-665749ecf6ac"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SaleType", () => _recordColumnValues_SaleType.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<string> _recordColumnValues_SaleType;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,127,200,150,228,30,183,219,178,80,210,64,183,37,144,44,97,36,141,178,2,127,108,44,153,38,152,253,239,149,237,108,10,57,148,210,91,65,135,209,88,239,205,155,231,153,233,222,249,79,174,9,56,212,22,26,143,201,184,51,53,169,56,88,86,113,69,75,173,83,202,120,140,132,173,36,45,0,149,49,156,89,166,74,146,116,208,98,77,86,244,214,184,64,18,23,176,245,245,237,244,155,52,12,35,38,247,118,185,124,211,71,108,225,251,92,128,101,96,133,68,73,121,153,42,202,80,197,2,26,52,181,182,144,170,98,130,101,168,201,170,133,33,160,205,153,160,32,74,65,153,205,99,164,68,78,173,212,42,47,11,102,21,42,146,132,193,181,31,33,224,222,181,120,13,67,84,22,11,238,251,57,181,106,104,208,134,237,211,105,64,239,93,223,213,19,190,198,251,231,83,108,99,21,183,233,155,177,237,72,18,225,112,13,225,88,19,192,20,89,169,129,106,38,203,88,30,57,133,66,154,104,133,226,57,23,152,85,25,39,137,134,83,152,105,201,206,144,196,64,128,31,208,140,184,48,79,46,54,145,23,105,38,202,42,98,179,66,83,86,228,41,21,149,224,212,154,202,74,44,42,41,149,185,24,250,121,116,49,118,254,106,108,113,112,250,229,191,96,52,184,31,234,73,247,93,24,250,102,166,190,90,158,239,241,41,172,238,191,124,186,89,27,10,49,63,131,200,57,25,61,110,26,135,93,216,118,186,55,174,123,88,57,207,231,8,105,79,48,56,127,113,97,251,56,66,67,146,193,61,28,255,232,214,102,244,161,111,255,163,86,147,216,230,58,20,139,220,121,72,141,243,167,6,158,151,123,77,222,61,142,125,248,240,5,193,172,17,121,131,168,201,29,41,25,164,32,141,140,107,97,12,93,166,66,228,113,45,56,102,69,38,144,167,92,229,119,36,170,248,7,238,219,157,255,250,179,187,44,201,170,250,240,62,102,223,36,94,135,187,158,254,70,206,249,48,11,58,156,227,249,5,86,230,180,189,235,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,77,111,27,55,16,253,43,6,147,163,70,24,126,147,190,21,205,197,128,147,24,113,154,75,148,195,144,28,38,66,36,173,177,187,106,225,24,250,239,165,214,50,108,21,141,43,20,45,16,20,221,3,23,187,228,155,55,228,123,195,185,19,47,199,219,27,22,231,226,61,247,61,13,93,29,231,63,119,61,207,175,250,46,243,48,204,47,187,76,171,229,55,74,43,190,162,158,214,60,114,255,129,86,91,30,46,151,195,56,59,59,134,137,153,120,249,235,52,43,206,63,222,137,139,145,215,191,92,148,22,221,69,169,66,76,5,146,163,0,6,145,32,112,82,160,152,28,42,93,200,146,108,224,220,173,182,235,205,107,30,233,138,198,47,226,252,78,76,209,90,128,148,49,171,226,16,44,233,2,38,24,4,34,195,144,29,50,121,239,88,161,19,187,153,24,242,23,94,211,68,250,8,54,146,106,136,28,193,91,76,96,56,37,8,153,50,212,170,99,114,45,152,228,188,7,31,214,63,2,63,190,184,236,186,175,219,155,185,82,218,200,92,36,216,164,53,152,220,232,35,74,9,174,122,23,53,87,199,198,204,61,69,140,216,24,172,78,22,140,141,1,162,74,26,144,152,35,58,229,178,117,47,62,237,137,202,114,184,89,209,237,135,239,242,93,143,244,153,231,63,253,70,203,113,185,249,124,54,208,138,239,145,55,71,34,60,197,222,45,238,181,92,136,243,197,247,212,60,188,175,167,67,58,214,243,143,82,46,196,108,33,174,187,109,159,247,17,245,254,227,225,104,39,6,60,60,240,39,195,195,115,31,99,130,189,166,77,219,81,255,166,49,78,240,105,234,21,141,52,145,191,111,121,63,4,78,42,90,244,178,130,103,138,77,44,167,32,20,73,16,101,76,85,123,173,106,85,19,250,29,87,238,121,147,249,56,177,83,164,154,240,19,243,99,50,15,174,107,127,54,219,213,106,34,24,166,253,239,109,124,72,252,48,243,234,137,126,79,34,116,101,89,151,92,46,54,127,231,168,118,98,183,155,61,173,25,150,86,185,210,156,84,144,61,152,102,84,32,99,51,20,239,9,109,49,104,93,253,139,154,161,32,61,235,102,123,215,106,6,155,31,67,64,3,193,198,104,80,75,44,46,252,243,53,179,16,111,251,194,253,66,60,103,244,163,69,255,125,79,107,101,201,235,20,0,171,105,82,26,66,104,7,168,192,59,108,182,12,136,154,242,115,158,62,57,177,31,221,211,197,88,25,115,114,80,61,53,75,106,153,32,198,92,161,221,238,201,36,137,38,165,240,172,167,99,82,62,102,239,0,149,108,213,93,173,4,202,197,129,142,218,177,68,215,122,140,249,55,251,64,169,50,231,224,192,41,159,193,148,54,80,105,119,21,22,14,204,137,146,193,60,119,174,106,205,37,180,62,192,181,245,170,182,63,106,87,23,56,103,189,137,156,171,163,124,98,31,120,195,92,206,214,52,110,251,229,120,59,191,110,109,96,128,158,169,220,254,223,13,226,105,221,224,4,193,126,212,202,249,180,251,29,150,237,164,112,159,9,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "604808a6567a468c889aa25a7223d7e4",
							"BaseElements.ChangeDataUserTask2.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b");
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

		public LeadManagementHandoffFinance(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementHandoffFinance";
			SchemaUId = new Guid("604808a6-567a-468c-889a-a25a7223d7e4");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("604808a6-567a-468c-889a-a25a7223d7e4");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementHandoffFinance, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementHandoffFinance, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		private ProcessLeadHandoff _leadHandoff;
		public ProcessLeadHandoff LeadHandoff {
			get {
				return _leadHandoff ?? ((_leadHandoff) = new ProcessLeadHandoff(UserConnection, this));
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
					SchemaElementUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateNurturing;
		public ProcessTerminateEvent TerminateNurturing {
			get {
				return _terminateNurturing ?? (_terminateNurturing = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNurturing",
					SchemaElementUId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayLeadDefined;
		public ProcessExclusiveGateway ExclusiveGatewayLeadDefined {
			get {
				return _exclusiveGatewayLeadDefined ?? (_exclusiveGatewayLeadDefined = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayLeadDefined",
					SchemaElementUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayLeadDefined.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateLeadUndefined;
		public ProcessTerminateEvent TerminateLeadUndefined {
			get {
				return _terminateLeadUndefined ?? (_terminateLeadUndefined = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateLeadUndefined",
					SchemaElementUId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ActivityUserTaskBANTFlowElement _activityUserTaskBANT;
		public ActivityUserTaskBANTFlowElement ActivityUserTaskBANT {
			get {
				return _activityUserTaskBANT ?? (_activityUserTaskBANT = new ActivityUserTaskBANTFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadStateToNoInterestFlowElement _changeLeadStateToNoInterest;
		public ChangeLeadStateToNoInterestFlowElement ChangeLeadStateToNoInterest {
			get {
				return _changeLeadStateToNoInterest ?? (_changeLeadStateToNoInterest = new ChangeLeadStateToNoInterestFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadNurturingFlowElement _changeLeadNurturing;
		public ChangeLeadNurturingFlowElement ChangeLeadNurturing {
			get {
				return _changeLeadNurturing ?? (_changeLeadNurturing = new ChangeLeadNurturingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateOpportunity;
		public ProcessTerminateEvent TerminateOpportunity {
			get {
				return _terminateOpportunity ?? (_terminateOpportunity = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateOpportunity",
					SchemaElementUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateNoInterest;
		public ProcessTerminateEvent TerminateNoInterest {
			get {
				return _terminateNoInterest ?? (_terminateNoInterest = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNoInterest",
					SchemaElementUId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AutoGeneratedPageHandoffFlowElement _autoGeneratedPageHandoff;
		public AutoGeneratedPageHandoffFlowElement AutoGeneratedPageHandoff {
			get {
				return _autoGeneratedPageHandoff ?? (_autoGeneratedPageHandoff = new AutoGeneratedPageHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadForHandoffFlowElement _readLeadForHandoff;
		public ReadLeadForHandoffFlowElement ReadLeadForHandoff {
			get {
				return _readLeadForHandoff ?? (_readLeadForHandoff = new ReadLeadForHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadActivityDataFlowElement _readActivityData;
		public ReadActivityDataFlowElement ReadActivityData {
			get {
				return _readActivityData ?? (_readActivityData = new ReadActivityDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("c46387cf-300b-4cd8-be2d-4740b8665e12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("f4359b3c-140b-4cfa-a64a-624975aad45f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow9;
		public ProcessConditionalFlow ConditionalFlow9 {
			get {
				return _conditionalFlow9 ?? (_conditionalFlow9 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow9",
					SchemaElementUId = new Guid("1c27d27e-3f1d-4f64-a277-78d7380f5bb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("e07f0e4a-f36b-1410-6698-00155d043204"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow7;
		public ProcessConditionalFlow ConditionalFlow7 {
			get {
				return _conditionalFlow7 ?? (_conditionalFlow7 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow7",
					SchemaElementUId = new Guid("37f09d58-5453-451a-97f7-c4f7dcacee68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9"),
						}},
					},
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
					SchemaElementUId = new Guid("23ff5267-6922-4cdf-bc26-a9d0f2ececcd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("d87d32bc-f36b-1410-6598-00155d043204"),
						}},
					},
				});
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
					SchemaElementUId = new Guid("8cdb95ca-c8ea-4880-b7cc-741fa584081f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[TerminateNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNurturing };
			FlowElements[ExclusiveGatewayLeadDefined.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayLeadDefined };
			FlowElements[TerminateLeadUndefined.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateLeadUndefined };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ActivityUserTaskBANT.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTaskBANT };
			FlowElements[ChangeLeadStateToNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadStateToNoInterest };
			FlowElements[ChangeLeadNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadNurturing };
			FlowElements[TerminateOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateOpportunity };
			FlowElements[TerminateNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNoInterest };
			FlowElements[AutoGeneratedPageHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageHandoff };
			FlowElements[ReadLeadForHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadForHandoff };
			FlowElements[ReadActivityData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadActivityData };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayLeadDefined", e.Context.SenderName));
						break;
					case "TerminateNurturing":
						CompleteProcess();
						break;
					case "ExclusiveGatewayLeadDefined":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateLeadUndefined", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "TerminateLeadUndefined":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTaskBANT", e.Context.SenderName));
						break;
					case "ActivityUserTaskBANT":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadActivityData", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow9ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadStateToNoInterest", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow7ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadNurturing", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
							break;
						}
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ActivityUserTaskBANT");
						break;
					case "ChangeLeadStateToNoInterest":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNoInterest", e.Context.SenderName));
						break;
					case "ChangeLeadNurturing":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNurturing", e.Context.SenderName));
						break;
					case "TerminateOpportunity":
						CompleteProcess();
						break;
					case "TerminateNoInterest":
						CompleteProcess();
						break;
					case "AutoGeneratedPageHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ReadLeadForHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageHandoff", e.Context.SenderName));
						break;
					case "ReadActivityData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadForHandoff", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateOpportunity", e.Context.SenderName));
						break;
					case "ChangeDataUserTask2":
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayLeadDefined", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow4", "ActivityUserTaskBANT.ActivityResult == new Guid(\"89a7d2c0-103f-4f41-87f7-265a34bf1d89\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow9ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("e07f0e4a-f36b-1410-6698-00155d043204");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow9", "ActivityUserTaskBANT.ActivityResult == new Guid(\"e07f0e4a-f36b-1410-6698-00155d043204\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow7ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow7", "ActivityUserTaskBANT.ActivityResult == new Guid(\"a08e24ec-c5d1-4951-b49f-5e70dde6a7d9\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("d87d32bc-f36b-1410-6598-00155d043204");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow1", "ActivityUserTaskBANT.ActivityResult == new Guid(\"d87d32bc-f36b-1410-6598-00155d043204\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalSequenceFlow1", "ActivityUserTaskBANT.ActivityResult == new Guid(\"fdc13e7b-c600-487f-a398-7240d059ee6a\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("AutoGeneratedPageHandoff.LeadType")) {
				writer.WriteValue("AutoGeneratedPageHandoff.LeadType", AutoGeneratedPageHandoff.LeadType, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.OpportunityResponsible")) {
				writer.WriteValue("AutoGeneratedPageHandoff.OpportunityResponsible", AutoGeneratedPageHandoff.OpportunityResponsible, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.DecisionDate")) {
				writer.WriteValue("AutoGeneratedPageHandoff.DecisionDate", AutoGeneratedPageHandoff.DecisionDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("AutoGeneratedPageHandoff.Comment")) {
				writer.WriteValue("AutoGeneratedPageHandoff.Comment", AutoGeneratedPageHandoff.Comment, null);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
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
			MetaPathParameterValues.Add("54a0a9d9-5cdd-45ca-8269-7e1318e707b2", () => LeadId);
			MetaPathParameterValues.Add("fa68c1b9-9e12-4b99-bdde-6eb1806d8874", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("99786611-0f56-4e3c-8f29-a4185ad1f427", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("c21a605f-a60b-42ed-9061-294cc87b69a0", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8bb1e66c-1b41-4f67-ab42-57cdc5d866a6", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("745423dc-b077-4526-8e74-98d8ad204cb8", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("5e1878c2-6cac-4d8b-baa8-a59f16943d8b", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("1053c0e9-6404-4b90-bd4a-07157c475327", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("8bc11220-5b0b-4d4e-a16c-25109fbcecd2", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("952c2d22-d6b6-4a51-82ac-ec6cfa9a867e", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("ff499ce0-d575-4f90-b31d-15c099b5f8ee", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("ddfda365-0d3d-45c9-84c5-ef97a50abd3e", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("7ced0725-a5ff-48ab-8329-db8cd92d45fc", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("1bdef657-82b6-4e4c-9cba-7cc3f773ead3", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("0e7bc406-b400-4ee2-8857-94f4a2ed4291", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("a4c0fd5e-3b7e-4c6a-bf78-0b172e842a9f", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("ed0eae90-a660-43ec-85fa-c1bc0b2c7a5c", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4fb15793-1f5f-4afb-a9c5-7ee6d16f6cd6", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d1788627-60e4-44cd-ad66-8387366ff0ee", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("460ec60f-88a1-4a7c-be25-e09b9f9029d7", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("5141e1f7-4af9-4bf4-b6d1-8874c0d2dc5f", () => ActivityUserTaskBANT.Recommendation);
			MetaPathParameterValues.Add("5b4637a8-7fc7-40e0-bfac-9cb675816ccf", () => ActivityUserTaskBANT.ActivityCategory);
			MetaPathParameterValues.Add("0902eded-b1a4-4f75-aa93-09fdf0aac605", () => ActivityUserTaskBANT.OwnerId);
			MetaPathParameterValues.Add("ba47d7d3-1ca5-41d1-9d6b-42ce60295158", () => ActivityUserTaskBANT.Duration);
			MetaPathParameterValues.Add("fdd5f4d6-8792-40d3-a46d-47a3545e3715", () => ActivityUserTaskBANT.DurationPeriod);
			MetaPathParameterValues.Add("5f4c4e07-469e-451a-88f4-305e2f6792b2", () => ActivityUserTaskBANT.StartIn);
			MetaPathParameterValues.Add("abdfdb50-a1ba-4d57-9207-b1dd297f6e84", () => ActivityUserTaskBANT.StartInPeriod);
			MetaPathParameterValues.Add("d6ff80f1-90c6-416a-90bb-260e00d506f7", () => ActivityUserTaskBANT.RemindBefore);
			MetaPathParameterValues.Add("4e14fc2e-ed85-4967-92f6-4ffd68e2401a", () => ActivityUserTaskBANT.RemindBeforePeriod);
			MetaPathParameterValues.Add("0685b12b-443e-4c64-ab26-d4859f0c8c4b", () => ActivityUserTaskBANT.ShowInScheduler);
			MetaPathParameterValues.Add("53d8ba23-d026-4fd0-9523-ad2d59cb13a1", () => ActivityUserTaskBANT.ShowExecutionPage);
			MetaPathParameterValues.Add("54f32772-50b2-49b4-a2a7-eee12cea8efc", () => ActivityUserTaskBANT.Lead);
			MetaPathParameterValues.Add("531d1563-ba9a-4e91-98ce-d35b182bca5f", () => ActivityUserTaskBANT.Account);
			MetaPathParameterValues.Add("fdb90180-2f4b-4831-b679-403593dd3b6f", () => ActivityUserTaskBANT.Contact);
			MetaPathParameterValues.Add("41dcb696-2cb1-4512-b3cf-dd1a7583a4ff", () => ActivityUserTaskBANT.Opportunity);
			MetaPathParameterValues.Add("d329e26e-4b48-4034-a14b-d1f9fe83945f", () => ActivityUserTaskBANT.Invoice);
			MetaPathParameterValues.Add("a61fc569-1cd9-4ee0-913c-ffb7359a1776", () => ActivityUserTaskBANT.Document);
			MetaPathParameterValues.Add("f7625075-971c-47b4-b67f-f12b29f07881", () => ActivityUserTaskBANT.Incident);
			MetaPathParameterValues.Add("71e2fad8-087d-4d30-853f-4284671382e2", () => ActivityUserTaskBANT.Case);
			MetaPathParameterValues.Add("b9471d7d-f83c-40ed-8479-ac97045d505d", () => ActivityUserTaskBANT.ActivityResult);
			MetaPathParameterValues.Add("42791514-cf69-4e4b-a09a-b627acdcf9e8", () => ActivityUserTaskBANT.CurrentActivityId);
			MetaPathParameterValues.Add("85441486-29f4-4732-bedf-744579a8ec72", () => ActivityUserTaskBANT.IsActivityCompleted);
			MetaPathParameterValues.Add("1ec1c9c1-eadf-4d15-a0fa-5e9731a46b43", () => ActivityUserTaskBANT.ExecutionContext);
			MetaPathParameterValues.Add("4c515728-a780-4846-a088-022faab38f6a", () => ActivityUserTaskBANT.InformationOnStep);
			MetaPathParameterValues.Add("5cf10363-3ca3-4fcf-a2e0-2c6f612c9aef", () => ActivityUserTaskBANT.Order);
			MetaPathParameterValues.Add("38749114-70e5-4e48-85a8-d4f5a5ff24c3", () => ActivityUserTaskBANT.Requests);
			MetaPathParameterValues.Add("725e7498-44eb-49c5-8104-b615cd2a44b3", () => ActivityUserTaskBANT.Listing);
			MetaPathParameterValues.Add("24e0015e-591a-49d6-b47e-f60c309ab061", () => ActivityUserTaskBANT.Property);
			MetaPathParameterValues.Add("ed86a088-1c5e-4485-b084-878f1a8d39df", () => ActivityUserTaskBANT.Contract);
			MetaPathParameterValues.Add("b14902c4-2013-48e9-b69e-d810c180118b", () => ActivityUserTaskBANT.Project);
			MetaPathParameterValues.Add("1138fd23-4b02-4812-9de6-6ecb917db660", () => ActivityUserTaskBANT.Problem);
			MetaPathParameterValues.Add("948d7cec-52ca-4a20-9991-67a3f04cc7c2", () => ActivityUserTaskBANT.Change);
			MetaPathParameterValues.Add("4b5d863d-2006-4c46-8f37-592fbfa512c0", () => ActivityUserTaskBANT.Release);
			MetaPathParameterValues.Add("af9569bc-af68-4326-b7bd-5c4ef9e17ea0", () => ActivityUserTaskBANT.QueueItem);
			MetaPathParameterValues.Add("93699f4a-3722-4757-85a7-ebcb8cbd5d41", () => ActivityUserTaskBANT.Application);
			MetaPathParameterValues.Add("4f326ae3-c270-4edb-b8c8-661e21a86817", () => ActivityUserTaskBANT.FinApplication);
			MetaPathParameterValues.Add("2c070493-7483-4c5e-a83b-3eb1c5d78ab7", () => ChangeLeadStateToNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("c600955c-8b94-4c98-aee1-79c3c61d4140", () => ChangeLeadStateToNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("24bf952c-9579-4dcf-981f-f2cce1dbc830", () => ChangeLeadStateToNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a", () => ChangeLeadStateToNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("091ab17a-49f8-4d9e-be81-1ca9c9dcb055", () => ChangeLeadNurturing.EntitySchemaUId);
			MetaPathParameterValues.Add("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13", () => ChangeLeadNurturing.IsMatchConditions);
			MetaPathParameterValues.Add("6f0df01f-2acd-4bc7-adec-34cfc25c9246", () => ChangeLeadNurturing.DataSourceFilters);
			MetaPathParameterValues.Add("38717ef0-c344-40ce-a5f4-e39c87df0d1d", () => ChangeLeadNurturing.RecordColumnValues);
			MetaPathParameterValues.Add("37ca1e6d-f9a7-4c7f-ba6c-9ca142ff1579", () => AutoGeneratedPageHandoff.Title);
			MetaPathParameterValues.Add("92313c1a-6c83-4de1-b493-4b387b234357", () => AutoGeneratedPageHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("5854a389-d5a2-4dce-814f-9c06510637e6", () => AutoGeneratedPageHandoff.Recommendation);
			MetaPathParameterValues.Add("41d66075-70c0-453a-8022-cff5949370b2", () => AutoGeneratedPageHandoff.EntityId);
			MetaPathParameterValues.Add("3111f593-81b1-42b5-99a0-cd853a60b279", () => AutoGeneratedPageHandoff.Buttons);
			MetaPathParameterValues.Add("d88c0edd-7a1d-4087-b13e-ce975c3e925f", () => AutoGeneratedPageHandoff.Elements);
			MetaPathParameterValues.Add("7d35cac3-bad2-40c8-842e-1b639ac400c8", () => AutoGeneratedPageHandoff.ExtendedClientModule);
			MetaPathParameterValues.Add("f2e508ca-4b2f-4b48-976b-52653e3dbe10", () => AutoGeneratedPageHandoff.EntryPointId);
			MetaPathParameterValues.Add("478f0294-5119-41e8-ab5b-bc27d9882a36", () => AutoGeneratedPageHandoff.PressedButtonCode);
			MetaPathParameterValues.Add("9d600d04-bc01-4cd3-86a4-a9bb56f488b7", () => AutoGeneratedPageHandoff.OwnerId);
			MetaPathParameterValues.Add("a698c3a6-4b9a-4404-9178-0cd67c688925", () => AutoGeneratedPageHandoff.ShowExecutionPage);
			MetaPathParameterValues.Add("03fc2e34-8cdc-4158-9dd1-dafee46392f4", () => AutoGeneratedPageHandoff.InformationOnStep);
			MetaPathParameterValues.Add("97a4e728-73b0-4b7e-8a0e-313bec8ab330", () => AutoGeneratedPageHandoff.IsRunning);
			MetaPathParameterValues.Add("3a8ae276-d1a6-4833-8edd-18a3802457a6", () => AutoGeneratedPageHandoff.LeadType);
			MetaPathParameterValues.Add("3c1a49b0-c3d5-4625-857c-486a8728ce72", () => AutoGeneratedPageHandoff.OpportunityResponsible);
			MetaPathParameterValues.Add("2f793155-6bc5-4cb4-a9d1-f07a2a5f9214", () => AutoGeneratedPageHandoff.DecisionDate);
			MetaPathParameterValues.Add("77adfed6-803a-43ee-a405-f8d108f86eca", () => AutoGeneratedPageHandoff.Comment);
			MetaPathParameterValues.Add("6e73bc51-9c3d-46b9-99dc-388c60d1dae1", () => ReadLeadForHandoff.DataSourceFilters);
			MetaPathParameterValues.Add("c3ef0854-9dec-41d4-8d16-407475422cc6", () => ReadLeadForHandoff.ResultType);
			MetaPathParameterValues.Add("976150fd-e561-4fa6-9f3f-911949e5c42c", () => ReadLeadForHandoff.ReadSomeTopRecords);
			MetaPathParameterValues.Add("51bcbfaa-b77d-4c21-947e-02e0676d3545", () => ReadLeadForHandoff.NumberOfRecords);
			MetaPathParameterValues.Add("663137f9-795a-4269-b94a-83f9c02d10da", () => ReadLeadForHandoff.FunctionType);
			MetaPathParameterValues.Add("b1c37761-25d6-438c-bdbc-43b2a149b1ca", () => ReadLeadForHandoff.AggregationColumnName);
			MetaPathParameterValues.Add("73074895-abf7-4e2d-ad95-2629a87fc3d5", () => ReadLeadForHandoff.OrderInfo);
			MetaPathParameterValues.Add("69f1e87b-3dd8-44cf-8c4f-97bd0653ad06", () => ReadLeadForHandoff.ResultEntity);
			MetaPathParameterValues.Add("225fc2e7-3024-4f80-b9c4-c881e8aadeed", () => ReadLeadForHandoff.ResultCount);
			MetaPathParameterValues.Add("38d606ea-c1d2-4017-915e-893f7f96a610", () => ReadLeadForHandoff.ResultIntegerFunction);
			MetaPathParameterValues.Add("d8b37a80-9357-459a-9ca1-945f0af37bb5", () => ReadLeadForHandoff.ResultFloatFunction);
			MetaPathParameterValues.Add("3207b919-eb4b-44b7-9c43-5080d06b54a1", () => ReadLeadForHandoff.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f24a8102-fb92-4bc4-b65f-c475f479a843", () => ReadLeadForHandoff.ResultRowsCount);
			MetaPathParameterValues.Add("8f0a63b7-c987-4e12-93c8-76a709a96645", () => ReadLeadForHandoff.CanReadUncommitedData);
			MetaPathParameterValues.Add("4af22b59-f62b-47c3-ad50-2c78bf148bf7", () => ReadLeadForHandoff.ResultEntityCollection);
			MetaPathParameterValues.Add("a1770417-d693-4416-9df8-379715d76f1e", () => ReadLeadForHandoff.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5e6e3bcd-5e15-4652-84f8-98664792001d", () => ReadLeadForHandoff.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d9cc6ce2-f4c2-48b7-99ec-f97bea66b913", () => ReadLeadForHandoff.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4dbe8b2c-9cba-4708-8f84-a8d5cc9e7b1b", () => ReadLeadForHandoff.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("b7a60eae-1035-42aa-a3a1-1572936331df", () => ReadActivityData.DataSourceFilters);
			MetaPathParameterValues.Add("51205379-8b3b-4d44-91b1-2cf7e081b07f", () => ReadActivityData.ResultType);
			MetaPathParameterValues.Add("f9078003-1806-4096-a752-6ce6fcaf6be3", () => ReadActivityData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("76950e9e-10e8-40f4-86ff-2e96d8188d1b", () => ReadActivityData.NumberOfRecords);
			MetaPathParameterValues.Add("93775e4e-88f1-48e9-ad74-74ac5f28d089", () => ReadActivityData.FunctionType);
			MetaPathParameterValues.Add("60cd6a65-a50a-4617-80ad-ed2c447da612", () => ReadActivityData.AggregationColumnName);
			MetaPathParameterValues.Add("72a0125d-b3d1-40d6-87c7-019a59320276", () => ReadActivityData.OrderInfo);
			MetaPathParameterValues.Add("946dd2c0-da26-457d-ad8c-4ba3167aa54d", () => ReadActivityData.ResultEntity);
			MetaPathParameterValues.Add("cd269b97-48c0-45a2-b046-e6a8730dbc7b", () => ReadActivityData.ResultCount);
			MetaPathParameterValues.Add("af08f6d6-b7c6-43d1-9f43-0d58376f1628", () => ReadActivityData.ResultIntegerFunction);
			MetaPathParameterValues.Add("1374d32a-f908-40e6-bf89-db89d892800d", () => ReadActivityData.ResultFloatFunction);
			MetaPathParameterValues.Add("5b57f2b2-ecee-4016-9433-31ce467f75e4", () => ReadActivityData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("c8013d26-15c8-4309-8bd8-b47ac03d9b59", () => ReadActivityData.ResultRowsCount);
			MetaPathParameterValues.Add("16f2c6ff-c1c8-4618-a4e9-e3c0db708ee5", () => ReadActivityData.CanReadUncommitedData);
			MetaPathParameterValues.Add("0d16c05d-2fc2-4a8a-8988-a0236870a419", () => ReadActivityData.ResultEntityCollection);
			MetaPathParameterValues.Add("d6aa112f-0172-4d91-a4d7-4aca0c91d611", () => ReadActivityData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("aa42b756-be31-4168-9f40-03d0cd697284", () => ReadActivityData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("87858d3a-ae6e-4ec8-9258-e827e98d90d9", () => ReadActivityData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4afc82d3-cf77-4ec0-9e1c-95ac9e097615", () => ReadActivityData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("de2b38a3-9f52-4d0b-8df6-067cb01d12fa", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("2486b970-ba2a-4d75-ad7e-6a6ca3693558", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("d0582550-2e0c-4765-8c6b-c7cbbd545084", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("0b9fe44f-dae0-43df-bf4f-456291e2c0f3", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("85beb4a5-021f-4174-8075-c753178d9f8c", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("ca953947-82c9-4fca-ad12-345201627164", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("f7d955b1-b130-45d2-b90b-36a4a2ff1c1b", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("86baa44f-1be5-4c2b-afba-f50c69444878", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("ad1909b2-86a5-4387-ac62-e67d8d19b991", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("ea16bf89-752e-4e21-a5fa-2779bbe6a5de", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("96352b96-718c-4854-ab6d-31d33673a18b", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("702f5fbb-ed10-4780-81d7-ed81fe787102", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("24e70e39-6f35-420e-8745-11cb3e30fc29", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("aa996c30-4714-41b7-ba32-536d65ced754", () => ChangeDataUserTask2.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "AutoGeneratedPageHandoff.LeadType":
					AutoGeneratedPageHandoff.LeadType = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageHandoff.OpportunityResponsible":
					AutoGeneratedPageHandoff.OpportunityResponsible = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageHandoff.DecisionDate":
					AutoGeneratedPageHandoff.DecisionDate = reader.GetValue<System.DateTime>();
				break;
				case "AutoGeneratedPageHandoff.Comment":
					AutoGeneratedPageHandoff.Comment = reader.GetValue<System.String>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
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
			var cloneItem = (LeadManagementHandoffFinance)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

