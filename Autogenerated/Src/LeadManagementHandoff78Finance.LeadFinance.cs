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

	#region Class: LeadManagementHandoff78FinanceSchema

	/// <exclude/>
	public class LeadManagementHandoff78FinanceSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementHandoff78FinanceSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementHandoff78FinanceSchema(LeadManagementHandoff78FinanceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementHandoff78Finance";
			UId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
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
			Tag = @"LeadManagementHandoff78Finance";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7");
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpenTaskPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("33fe706c-8bb5-40f7-890a-9d67b92dbea5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"OpenTaskPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFeedMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e99feae2-362b-4143-b7aa-31d837292ee6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"FeedMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreatePostponedDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2011a547-369b-43fc-b445-c742752ae214"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"PostponedDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateOpenTaskPageParameter());
			Parameters.Add(CreateFeedMessageParameter());
			Parameters.Add(CreatePostponedDateParameter());
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,193,142,211,48,16,253,151,156,215,43,39,117,227,164,55,180,20,84,9,177,43,109,181,23,178,135,73,60,110,45,146,38,178,221,133,82,85,226,19,246,99,56,32,142,236,159,240,37,216,113,91,186,168,104,11,23,54,82,164,248,229,249,205,204,155,153,117,84,213,96,204,91,104,48,26,69,83,212,26,76,43,237,249,43,85,91,212,175,117,187,236,162,179,200,160,86,80,171,79,40,2,62,22,202,190,4,11,238,202,186,248,165,80,68,163,226,184,70,17,157,21,145,178,216,24,199,113,87,40,103,34,103,49,16,94,14,19,194,32,145,36,147,73,73,82,10,76,138,184,202,37,77,2,243,79,226,23,109,211,129,198,16,163,151,151,253,231,116,213,121,106,236,128,170,167,40,211,46,182,224,192,39,97,198,11,40,107,20,238,108,245,18,29,100,181,106,92,53,56,85,13,94,129,118,177,188,78,235,33,71,146,80,27,207,170,81,218,241,199,78,163,49,170,93,60,149,92,189,108,22,135,108,39,128,251,227,54,29,218,231,232,153,87,96,231,189,196,196,165,181,233,179,124,49,155,105,156,129,85,119,135,73,188,199,85,207,59,205,63,119,65,184,46,221,64,189,196,131,152,143,43,185,128,206,134,130,66,120,71,208,106,54,63,185,214,189,99,79,149,155,56,176,219,145,79,212,60,90,67,146,58,240,206,3,65,101,247,89,68,239,38,230,242,195,2,245,117,53,199,6,130,107,183,231,14,253,13,216,235,143,214,67,6,20,114,145,147,97,37,4,97,195,10,72,150,164,57,225,24,15,226,12,57,229,101,178,185,13,121,40,211,213,176,186,217,135,123,184,255,241,249,219,195,253,247,175,238,253,210,83,188,129,238,7,148,20,105,9,146,32,79,24,97,169,72,72,158,229,41,225,105,58,200,177,20,34,206,124,163,253,227,251,209,206,84,5,245,101,135,218,245,187,247,155,30,159,212,71,35,238,93,208,109,107,67,109,123,23,223,32,132,46,238,102,133,151,82,102,195,36,35,60,79,129,48,26,115,2,89,156,17,202,56,101,241,128,3,74,119,115,227,214,220,27,125,221,46,117,181,93,43,19,246,251,159,246,246,63,108,227,223,44,216,209,17,63,101,100,159,203,48,78,158,203,164,109,162,205,79,25,41,228,120,69,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				UId = new Guid("8ad9f6fb-958b-43df-b80d-51bf6cda4238"),
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
				UId = new Guid("5624c57e-4bd7-43dc-831b-47b31fdac380"),
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
				Value = @"Contact customer, specify need, decision-making role.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2011a547-369b-43fc-b445-c742752ae214}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = @"Contact customer, get in touch with contact persons, define interest and BANT. As a result, either proceed to handoff, order or continue lead nurturing.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				UId = new Guid("99e9cc26-01cd-4e03-9c89-1d86e4dbc2c2"),
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
				UId = new Guid("f125cd4c-65d2-4885-9b77-e4bcc5b9f876"),
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,219,48,16,252,149,128,201,209,107,240,37,82,244,181,185,4,72,130,160,73,115,137,115,88,146,203,70,168,108,25,146,92,32,53,252,239,165,21,187,182,139,166,13,2,244,80,160,58,72,176,201,153,89,205,112,180,98,103,253,243,130,216,132,221,81,219,98,215,164,126,252,161,105,105,124,211,54,129,186,110,124,217,4,172,171,111,232,107,186,193,22,103,212,83,123,143,245,146,186,203,170,235,71,39,199,48,54,98,103,95,135,85,54,121,88,177,139,158,102,159,46,98,102,71,146,92,39,83,0,38,89,130,230,60,128,47,188,130,80,232,194,163,77,86,20,50,131,67,83,47,103,243,43,234,241,6,251,39,54,89,177,129,45,19,56,47,173,11,214,0,151,66,129,78,133,0,12,209,128,114,202,144,224,198,249,168,217,122,196,186,240,68,51,28,68,247,96,45,48,149,142,28,216,130,123,208,228,61,148,1,3,164,164,156,55,186,212,130,194,6,188,221,191,7,62,156,94,54,205,151,229,98,44,99,18,33,148,6,140,180,1,116,204,55,140,34,1,143,84,18,121,244,154,135,113,178,37,55,38,42,64,171,40,203,228,237,222,59,7,164,173,77,193,59,237,101,121,250,184,17,138,85,183,168,241,249,254,85,189,107,162,120,50,195,126,217,86,253,243,248,186,233,79,170,121,118,158,186,158,226,11,197,226,40,141,67,146,213,244,37,212,41,155,76,95,139,117,251,188,29,220,58,14,246,231,76,167,108,52,101,183,205,178,13,27,70,181,249,177,243,120,80,224,219,11,126,113,219,93,47,28,3,236,10,231,248,153,218,235,172,56,192,135,165,115,236,113,16,191,203,115,239,136,189,116,5,183,217,100,75,232,178,157,70,66,25,5,130,19,206,39,101,149,76,73,14,232,143,148,178,53,243,64,199,131,189,37,179,1,63,40,239,135,217,29,191,252,207,124,89,215,131,64,55,188,255,230,60,111,7,223,174,156,31,4,121,192,208,196,42,85,20,47,230,239,180,106,51,194,15,79,182,106,107,182,94,143,14,59,85,234,96,76,169,36,168,84,228,78,217,50,183,75,37,3,78,150,69,178,62,40,12,238,183,157,242,129,7,25,13,135,2,85,132,92,3,14,136,154,32,24,78,104,173,201,157,53,127,179,83,82,105,17,162,128,252,33,200,149,14,89,222,113,33,192,36,107,156,162,100,72,235,113,33,48,6,69,1,84,193,243,38,47,242,140,60,11,150,158,148,231,36,68,226,111,237,212,109,159,15,222,255,46,189,175,75,242,207,89,253,99,93,122,92,127,7,248,139,99,205,253,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,219,48,16,252,149,130,201,209,107,240,37,62,124,109,46,1,146,32,104,210,92,226,28,150,228,178,17,106,91,134,36,7,72,3,255,123,105,197,110,236,162,41,140,2,61,20,168,14,20,68,106,102,86,59,59,122,97,167,253,243,146,216,132,221,82,219,98,215,228,126,252,177,105,105,124,221,54,145,186,110,124,209,68,156,213,223,48,204,232,26,91,156,83,79,237,29,206,86,212,93,212,93,63,250,112,8,99,35,118,250,52,156,178,201,253,11,59,239,105,254,249,60,21,118,33,93,86,33,90,240,82,85,160,53,26,64,205,37,24,227,124,217,214,206,114,81,192,177,153,173,230,139,75,234,241,26,251,71,54,121,97,3,91,33,240,65,90,31,173,1,46,133,2,157,43,1,24,147,1,229,149,33,193,141,15,73,179,245,136,117,241,145,230,56,136,190,129,181,192,236,60,121,176,21,15,160,41,4,112,17,35,228,172,124,48,218,105,65,113,3,222,190,255,6,188,63,185,104,154,175,171,229,88,166,44,98,116,6,140,180,17,116,42,11,38,145,129,39,114,68,1,131,230,113,92,5,149,4,215,6,114,20,6,116,21,29,96,133,2,164,119,41,71,87,217,74,155,147,135,141,80,170,187,229,12,159,239,222,213,187,34,74,31,230,216,175,218,186,127,30,159,213,93,108,158,168,165,244,10,95,30,56,177,79,240,50,125,53,116,202,38,211,247,44,221,222,111,134,78,29,154,250,179,159,83,54,154,178,155,102,213,198,13,163,218,60,236,250,59,40,240,237,5,191,88,118,215,43,199,0,187,196,5,126,161,246,170,40,14,240,225,232,12,123,28,196,111,75,221,59,226,32,125,197,109,105,176,37,244,197,49,35,193,37,129,224,133,15,89,89,37,115,150,3,250,19,229,210,151,69,164,195,194,142,241,107,192,15,202,111,197,236,70,175,236,44,86,179,217,32,208,13,223,191,153,229,109,225,219,147,179,61,19,247,24,154,84,231,154,210,249,226,15,91,181,41,225,71,79,182,106,107,182,94,143,246,243,164,130,148,210,219,10,148,38,1,218,144,2,167,200,65,170,140,112,209,32,25,235,127,155,167,16,121,148,201,112,168,80,37,40,17,224,128,168,9,162,225,132,214,26,146,220,252,205,60,73,165,69,76,2,74,102,74,156,99,145,247,92,8,48,217,26,175,40,27,210,122,44,116,204,209,104,13,164,168,212,232,45,129,43,127,1,160,164,85,153,131,224,184,87,71,230,233,166,47,131,183,201,81,223,214,97,213,215,205,226,127,146,252,113,73,58,194,169,127,44,73,15,235,239,101,67,93,26,247,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,211,64,20,253,23,175,59,149,51,51,126,101,135,74,64,145,16,173,212,168,27,220,197,181,125,237,140,176,99,107,102,82,8,81,36,62,161,31,195,2,177,164,127,194,151,112,199,78,66,138,130,26,216,80,75,150,60,199,103,206,61,247,181,246,242,26,140,121,11,13,122,99,111,134,90,131,105,75,123,254,74,213,22,245,107,221,46,59,239,204,51,168,21,212,234,19,22,3,62,41,148,125,9,22,232,202,58,253,165,144,122,227,244,184,70,234,157,165,158,178,216,24,226,184,43,18,67,14,50,98,153,207,3,38,81,20,44,203,1,153,72,130,92,112,89,22,65,25,111,153,127,16,191,104,155,14,52,14,49,122,249,178,255,156,173,58,71,29,17,144,247,20,101,218,197,22,20,206,132,153,44,32,171,177,160,179,213,75,36,200,106,213,80,54,56,83,13,94,129,166,88,78,167,117,16,145,74,168,141,99,213,88,218,201,199,78,163,49,170,93,60,101,174,94,54,139,67,54,9,224,254,184,181,227,247,30,29,243,10,236,188,151,152,146,173,77,239,242,69,85,105,172,192,170,187,67,19,239,113,213,243,78,171,31,93,40,168,75,55,80,47,241,32,230,227,76,46,160,179,67,66,67,120,34,104,85,205,79,206,117,95,177,167,210,229,4,118,59,242,137,154,71,115,224,33,129,119,14,24,84,118,159,169,247,110,106,46,63,44,80,95,231,115,108,96,168,218,237,57,161,191,1,123,253,241,58,144,224,67,82,36,44,200,139,130,201,32,7,22,243,48,97,17,142,196,40,198,200,143,50,190,185,29,124,40,211,213,176,186,217,135,123,184,255,241,249,219,195,253,247,175,244,126,233,41,174,128,244,35,129,2,98,20,130,154,146,72,38,69,136,44,139,69,194,32,150,200,185,28,73,16,33,53,218,61,174,31,109,165,114,168,47,59,212,212,239,190,222,254,241,73,125,52,226,174,10,186,109,237,144,219,190,138,111,16,134,46,238,102,101,132,92,114,192,132,201,60,138,152,132,56,99,73,25,100,76,22,33,114,95,4,34,136,51,50,67,107,238,10,125,221,46,117,190,93,43,51,236,247,63,237,237,127,216,198,191,89,176,163,35,126,202,200,62,151,97,156,62,151,73,219,120,155,159,135,70,83,60,69,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				UId = new Guid("4589897f-ff86-44ec-9638-7b562d3ab2a8"),
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
				UId = new Guid("c56e2064-b9b2-4c5d-8e17-e101e465756e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,211,64,20,253,149,200,235,78,149,241,123,178,43,37,160,108,218,74,141,186,33,93,92,143,175,211,17,118,108,141,39,133,16,69,234,39,180,85,87,236,248,3,22,72,116,3,11,42,248,144,126,9,119,236,54,164,40,168,129,13,16,201,202,204,209,185,231,190,103,238,200,28,234,122,15,10,116,122,206,16,181,134,186,204,204,246,51,149,27,212,207,117,57,173,156,45,167,70,173,32,87,111,48,109,241,126,170,204,83,48,64,38,243,209,15,133,145,211,27,173,215,24,57,91,35,71,25,44,106,226,144,9,198,232,101,65,34,25,134,232,51,31,35,201,32,201,34,38,189,144,251,73,152,6,66,68,45,243,87,226,187,101,81,129,198,214,71,35,159,53,199,225,172,178,84,78,128,108,40,170,46,39,119,160,103,131,168,251,19,72,114,76,233,110,244,20,9,50,90,21,148,13,14,85,129,7,160,201,151,213,41,45,68,164,12,242,218,178,114,204,76,255,117,165,177,174,85,57,121,44,184,124,90,76,86,217,36,128,203,235,93,56,221,38,70,203,60,0,115,210,72,12,40,172,69,19,229,206,120,172,113,12,70,157,174,6,241,18,103,13,111,179,250,145,65,74,93,58,130,124,138,43,62,31,102,178,11,149,105,19,106,221,19,65,171,241,201,198,185,46,43,246,88,186,46,129,213,61,121,67,205,181,57,184,33,129,167,22,104,85,238,143,35,231,197,160,222,127,53,65,125,40,79,176,128,182,106,199,219,132,254,4,244,115,44,112,98,122,243,56,142,19,79,248,33,243,18,145,49,63,75,145,197,41,34,243,68,0,16,115,143,115,41,23,100,176,12,168,55,247,221,72,240,128,251,76,102,161,160,210,251,9,131,174,0,150,132,110,4,50,149,153,192,120,113,220,6,174,234,42,135,217,209,50,190,155,243,219,179,171,155,243,47,239,233,251,208,252,95,220,158,189,179,135,206,205,197,183,75,123,123,75,183,207,247,240,39,250,174,91,244,226,235,101,231,201,206,222,112,123,144,118,8,253,184,78,229,186,241,106,155,72,190,120,8,194,197,36,100,93,47,179,35,226,122,76,4,169,207,34,33,48,75,121,224,199,30,167,97,179,63,59,19,229,88,73,200,247,43,212,52,115,77,207,187,235,183,229,193,154,217,78,232,178,52,109,125,151,157,220,145,52,183,202,208,172,174,204,108,228,185,8,33,231,44,232,218,194,197,60,101,16,7,46,203,68,144,184,32,188,56,72,201,122,65,207,141,109,248,97,57,213,242,110,189,235,246,157,249,163,247,227,47,188,10,191,179,232,107,87,109,147,213,249,111,151,98,240,47,141,231,194,89,124,7,217,93,169,69,2,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				UId = new Guid("cf2fd364-ebc2-4e4b-9d70-b023c6ddc868"),
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
				UId = new Guid("affe8596-58fc-40b3-a1ec-d76a746cdf6f"),
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,221,110,91,69,16,126,149,232,164,23,69,242,70,251,119,246,199,183,180,160,72,73,169,154,210,155,56,23,179,187,179,173,37,251,56,178,157,70,197,178,84,120,130,164,151,60,3,23,33,226,175,32,138,20,171,60,72,159,132,57,39,118,154,132,98,170,180,20,36,114,228,243,55,103,102,118,118,103,191,111,198,147,226,198,248,201,46,22,237,226,62,14,135,48,26,228,241,218,199,131,33,174,221,29,14,34,142,70,107,27,131,8,189,238,23,16,122,120,23,134,208,199,49,14,31,64,111,15,71,27,221,209,184,181,114,209,172,104,21,55,30,55,95,139,246,246,164,88,31,99,255,243,245,68,222,3,38,12,214,35,147,160,75,166,101,66,6,218,0,243,94,168,16,93,8,38,58,50,142,131,222,94,191,218,196,49,220,133,241,163,162,61,41,26,111,181,3,110,13,88,47,201,214,39,166,109,10,204,121,145,152,49,82,40,45,128,135,132,197,180,85,140,226,35,236,67,51,232,121,99,180,46,74,197,44,247,52,122,42,61,11,14,3,139,130,75,77,227,39,99,67,109,60,215,127,109,184,189,186,189,62,250,108,191,194,225,86,227,183,157,161,55,194,157,53,146,94,18,156,45,78,123,82,106,224,224,147,103,101,76,20,106,25,129,57,105,60,179,40,148,112,104,185,13,114,186,179,186,83,143,152,186,163,221,30,60,121,240,231,129,103,7,175,158,254,60,59,56,249,137,206,239,78,149,119,47,36,224,188,250,164,115,154,199,78,209,238,252,85,38,231,247,211,184,47,230,242,114,26,59,69,171,83,108,13,246,134,177,246,168,232,229,214,185,56,155,65,26,149,75,175,139,188,145,164,218,235,245,230,146,91,48,134,133,226,66,60,72,221,220,197,180,94,109,45,210,213,120,225,243,131,189,225,178,56,78,99,123,23,179,77,168,224,33,14,239,208,2,188,142,253,44,202,251,180,140,11,199,82,113,225,74,99,25,8,21,153,86,146,51,103,156,101,57,153,236,81,25,239,67,106,172,239,97,198,33,86,17,175,24,216,61,28,53,171,93,3,102,30,87,189,84,211,98,58,109,157,135,17,55,38,131,55,200,132,2,218,200,220,11,230,147,8,12,92,208,166,76,65,210,111,41,140,192,130,23,28,104,71,242,196,153,70,65,16,44,99,100,150,246,107,150,73,122,145,253,251,135,81,133,251,43,159,238,117,211,205,78,65,80,205,206,35,161,161,228,129,2,8,132,227,8,145,229,172,124,48,218,105,129,177,83,124,180,12,27,87,243,118,13,158,255,59,120,100,118,9,149,67,134,194,81,29,1,105,153,215,96,152,178,180,137,80,113,110,99,92,10,158,28,180,141,78,100,154,145,164,253,239,92,96,65,230,192,120,169,69,25,92,2,167,227,251,7,207,214,120,216,173,30,18,47,87,17,198,55,175,84,145,208,251,140,128,146,41,35,9,38,66,43,22,44,145,128,18,201,41,43,189,68,52,117,69,106,173,220,174,30,119,135,131,170,143,213,120,237,14,238,111,116,43,42,14,111,63,230,237,30,214,166,237,73,150,129,155,136,192,178,44,21,37,159,27,230,121,136,44,82,218,117,52,180,25,66,57,189,24,164,117,101,45,38,66,202,129,210,227,101,102,14,80,49,229,2,47,9,227,96,45,153,172,238,44,229,134,203,139,245,9,98,218,164,170,71,123,118,201,244,102,7,47,95,80,153,253,118,118,248,234,171,111,232,225,168,121,57,56,121,65,130,167,95,211,67,93,136,143,86,22,159,191,167,243,199,217,225,239,207,232,254,203,236,240,229,179,133,218,209,217,195,10,93,126,107,84,207,217,28,55,46,169,156,47,52,142,79,213,230,42,103,159,232,252,161,118,79,211,232,215,161,206,231,124,205,96,31,152,193,34,207,92,27,162,9,186,80,177,12,145,24,76,99,73,172,33,124,138,174,20,38,136,15,202,96,209,250,168,146,210,76,58,42,250,90,249,200,188,228,68,41,25,74,15,78,70,157,97,41,131,97,200,38,4,175,8,89,68,124,212,167,82,255,192,121,34,88,34,24,162,193,140,82,252,155,93,244,187,240,7,128,37,130,206,156,37,94,210,220,28,145,8,8,34,57,83,74,169,164,9,42,57,254,54,109,247,127,147,10,154,184,230,46,143,231,222,232,229,240,228,203,139,210,131,147,95,155,147,132,207,233,225,249,245,63,135,55,113,192,63,78,29,65,250,146,91,106,21,44,130,167,198,212,72,230,82,221,108,11,31,178,178,74,230,44,151,81,7,81,11,181,72,165,96,142,32,73,21,155,176,230,18,117,236,224,184,74,218,56,149,146,250,59,234,216,153,254,1,128,153,87,136,222,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,211,64,20,253,23,175,59,149,157,216,30,59,59,84,2,138,132,104,165,70,221,224,46,174,103,238,36,35,236,216,154,153,20,66,20,137,79,232,199,176,64,44,233,159,240,37,220,177,147,144,162,136,6,54,212,146,37,207,241,153,115,207,125,173,3,81,129,181,111,161,198,96,20,76,209,24,176,141,114,231,175,116,229,208,188,54,205,178,13,206,2,139,70,67,165,63,161,236,241,177,212,238,37,56,160,43,235,226,151,66,17,140,138,227,26,69,112,86,4,218,97,109,137,67,87,84,84,70,113,22,11,166,148,16,44,230,50,98,121,150,35,67,14,34,133,60,147,92,121,181,63,136,95,52,117,11,6,251,24,157,188,234,62,167,171,214,83,35,2,68,71,209,182,89,108,193,161,55,97,199,11,40,43,148,116,118,102,137,4,57,163,107,202,6,167,186,198,43,48,20,203,235,52,30,34,146,130,202,122,86,133,202,141,63,182,6,173,213,205,226,41,115,213,178,94,28,178,73,0,247,199,173,157,176,243,232,153,87,224,230,157,196,132,108,109,58,151,47,102,51,131,51,112,250,238,208,196,123,92,117,188,211,234,71,23,36,117,233,6,170,37,30,196,124,156,201,5,180,174,79,168,15,79,4,163,103,243,147,115,221,87,236,169,116,7,4,182,59,242,137,154,71,115,24,164,4,222,121,160,87,217,125,22,193,187,137,189,252,176,64,115,45,230,88,67,95,181,219,115,66,127,3,246,250,163,117,18,67,8,185,204,89,34,164,100,113,34,128,101,131,52,103,28,163,97,148,33,15,121,57,216,220,246,62,180,109,43,88,221,236,195,61,220,255,248,252,237,225,254,251,87,122,191,116,20,95,64,250,145,135,81,201,7,130,51,20,144,176,56,15,21,203,56,31,48,21,70,152,36,160,164,130,148,26,237,31,223,143,102,166,5,84,151,45,26,234,119,87,239,240,248,164,62,26,113,95,5,211,52,174,207,109,95,197,55,8,125,23,119,179,146,202,44,227,57,210,112,164,138,179,88,165,146,65,200,21,227,73,137,152,12,211,44,137,74,50,67,107,238,11,125,221,44,141,216,174,149,237,247,251,159,246,246,63,108,227,223,44,216,209,17,63,101,100,159,203,48,78,158,203,164,109,130,205,79,140,163,78,37,69,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,205,110,91,85,16,126,149,200,116,153,99,157,255,31,111,9,139,72,41,173,104,233,166,201,98,206,156,57,173,133,99,71,182,3,42,81,164,194,11,64,42,86,21,27,246,44,218,138,0,42,162,72,173,202,131,244,73,152,123,109,55,78,105,211,84,80,33,163,88,186,215,215,199,51,115,38,227,249,190,153,51,57,232,92,154,222,217,163,78,175,115,157,198,99,152,140,234,180,251,225,104,76,221,171,227,17,210,100,210,221,26,33,12,250,95,66,30,208,85,24,195,46,77,105,124,3,6,251,52,217,234,79,166,235,107,167,213,58,235,157,75,159,183,223,118,122,55,15,58,155,83,218,253,116,179,176,245,232,64,34,86,41,130,146,81,88,212,90,64,42,81,164,4,177,152,168,74,148,192,202,56,26,236,239,14,47,211,20,174,194,244,118,167,119,208,105,173,177,129,140,18,117,241,82,56,48,69,216,104,165,0,176,36,208,75,130,16,60,105,233,59,135,235,157,9,222,166,93,104,55,61,81,182,10,106,76,148,68,112,50,11,75,57,139,136,128,162,86,147,178,103,99,138,176,81,158,203,159,40,222,252,96,107,52,250,108,127,175,171,181,177,10,139,18,46,27,195,254,243,246,73,42,37,124,13,62,25,170,158,172,237,6,72,50,73,222,193,153,236,132,117,137,255,62,157,141,144,64,148,164,215,30,157,255,96,167,217,168,244,39,123,3,184,115,227,239,251,61,251,246,233,15,124,253,241,236,232,197,215,63,242,195,3,190,30,241,245,132,23,238,54,223,252,206,215,175,124,61,238,182,162,188,122,127,46,246,83,251,205,209,211,111,214,248,225,183,185,88,179,248,128,69,159,63,225,135,159,151,23,151,108,29,175,45,111,249,100,73,162,213,152,249,188,119,234,231,95,246,250,96,123,150,69,219,157,222,246,155,242,104,254,126,173,253,121,78,103,210,171,73,180,221,89,223,238,92,27,237,143,177,177,104,248,195,198,82,184,218,77,90,145,87,62,46,178,134,87,134,251,131,193,124,101,3,166,176,16,92,44,143,74,191,246,169,108,14,175,45,146,165,181,34,231,47,241,154,219,226,53,243,237,159,168,93,134,33,220,162,241,199,28,128,19,223,95,122,121,157,195,184,48,156,117,114,50,168,42,2,65,226,172,245,90,196,162,64,36,149,114,53,193,232,90,117,171,253,9,85,26,211,16,233,180,99,231,201,217,185,254,164,141,118,3,215,185,95,77,168,14,59,135,135,235,203,32,86,74,87,31,8,133,67,203,32,174,90,137,140,20,132,14,37,147,69,133,164,212,153,32,78,89,135,132,193,11,169,21,123,84,157,18,128,197,11,147,140,39,37,125,202,197,190,79,16,151,170,16,163,23,94,7,20,182,240,13,10,199,87,22,138,68,25,178,149,216,245,190,26,67,76,77,142,67,196,68,131,85,0,135,91,120,239,130,77,132,213,3,254,171,32,126,113,247,187,133,220,241,28,184,44,247,244,171,25,180,143,158,223,155,129,115,174,125,127,89,246,225,220,212,146,60,219,109,109,126,127,162,48,67,244,163,198,204,227,51,129,126,124,1,244,213,4,250,57,242,250,157,128,14,210,97,172,142,68,72,73,10,155,148,23,81,37,37,146,41,50,121,182,138,96,206,4,186,67,89,33,36,47,178,140,12,116,165,61,3,157,161,139,181,20,212,206,153,4,242,125,0,253,230,230,228,202,23,67,26,207,226,211,171,48,152,208,78,151,87,95,89,248,104,64,187,52,156,246,14,170,206,210,35,129,168,218,177,163,70,122,230,200,140,220,86,164,100,209,27,45,179,59,100,133,151,21,171,119,160,216,7,39,193,9,175,74,227,30,19,32,104,230,214,136,5,92,242,49,122,147,14,119,222,78,17,109,69,126,184,76,17,15,151,49,251,184,89,92,91,70,251,47,207,142,254,188,215,50,4,147,194,73,225,95,60,44,104,226,120,89,231,209,50,204,215,22,52,240,6,6,96,243,221,43,123,123,163,241,116,127,216,159,222,225,108,217,27,13,39,125,110,253,46,136,97,37,137,65,249,76,198,115,149,141,149,52,195,208,37,214,47,220,57,71,105,138,245,209,148,98,222,137,24,200,68,73,165,113,3,35,112,135,91,140,0,149,140,112,197,101,77,178,20,175,234,153,196,64,21,141,118,82,113,59,98,26,3,28,165,88,193,10,85,130,68,159,171,246,53,173,42,49,112,7,36,81,102,62,157,120,207,238,149,232,154,64,91,81,72,155,26,172,175,154,244,234,18,195,101,162,105,127,120,235,122,127,247,130,13,254,27,54,40,90,81,162,106,5,74,111,133,149,74,139,172,185,234,87,80,16,85,80,5,94,246,243,175,101,131,115,59,118,110,54,8,58,248,160,25,128,42,114,214,163,69,118,136,207,248,154,139,34,31,20,184,76,22,247,150,54,193,39,31,24,34,94,19,31,40,156,52,34,50,9,8,166,24,143,76,78,222,176,129,21,101,3,85,179,207,200,231,8,163,44,255,90,33,6,238,161,176,8,67,214,101,25,42,153,98,86,151,13,182,8,74,147,155,23,141,193,74,54,6,92,170,51,101,30,194,217,100,248,70,68,92,170,42,207,228,180,13,224,42,82,140,241,221,78,12,160,66,82,0,34,242,93,88,224,19,67,2,235,68,53,5,75,48,133,161,122,246,104,160,233,7,124,85,153,39,130,220,84,216,12,149,77,57,43,100,224,67,141,45,210,7,135,43,75,5,18,107,198,204,211,146,236,248,56,133,134,27,131,202,125,2,47,201,76,129,217,0,221,234,82,193,6,97,127,210,31,13,57,81,47,232,224,162,51,152,77,10,17,98,194,234,132,142,153,139,95,181,156,251,42,152,102,208,71,42,71,6,12,3,242,44,58,0,43,193,219,10,2,120,188,207,189,14,49,202,44,15,14,249,132,141,170,212,156,147,169,171,74,7,60,233,76,5,17,5,185,102,140,170,101,18,201,49,131,87,87,249,8,1,74,131,150,255,139,1,194,6,241,255,12,166,77,156,46,218,132,149,108,19,92,137,214,121,70,176,114,196,133,171,144,227,129,30,223,184,122,41,201,29,126,226,57,223,219,218,132,157,195,191,0,21,21,193,125,100,28,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeIntermediateCatchSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0666ed69-b39c-40e3-8809-2b5e4de75265"),
				ContainerUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeLinkLeadToProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("7c89538d-7e55-4c93-9f0f-a2c2f80b1e80"),
				ContainerUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("ba921970-53ef-41a3-b7a6-07acd54a2917"),
				ContainerUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
		}

		protected virtual void InitializeAutoGeneratedPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d4e21dc6-ae7f-4060-91b3-ce65f3742261"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				Value = @"Set rescheduled date",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("fce5f296-feaa-4e40-8cbb-305fd22cb2db"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9f81254-85b1-456e-a58a-ebe2fd2b8a31"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				Value = @"Set rescheduled date.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c23ba28e-759a-4f56-9c0a-fe9df5188f52"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dfc93d28-365e-4669-a10a-43f2f09d1c88"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""33b526d3-b712-42af-939f-d47b020e9b7e"",""isEnabled"":true,""performValidation"":true,""caption"":""Save"",""name"":""Save"",""style"":""green"",""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("60b03c43-255a-4016-aa32-22859aaf1ce3"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""2c37e023-1170-4373-802d-9f3fa87fb04e"",""controlEditType"":""DateTimeField"",""caption"":""Rescheduled date"",""name"":""PostponedDate"",""text"":"""",""isMultiline"":false,""isRequired"":true,""canBeMinimized"":false,""minimized"":false,""dataSource"":null,""dataFilter"":"""",""controlDataValueType"":""10"",""dateTimeFormat"":""7""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dde310c5-648a-4f1f-967c-996a1beea049"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1480eb1d-1abf-41e9-bd39-f683731420dc"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				UId = new Guid("5894c4e4-ebd2-4f30-ada2-f8230d48fb62"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				UId = new Guid("cf460504-8871-4e8e-a6e4-c3c0731e19a7"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("13dca079-66e4-4df1-866b-5b3606d1a7bc"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7ca018e0-a0cc-4fd8-8bd9-e6a3fa04c96a"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b1fb948-eb5c-47f4-b75b-8300bc40bb35"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
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
			var postponedDateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eabadc9c-efc4-4198-b542-b281f25f7287"),
				ContainerUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"PostponedDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			postponedDateParameter.SourceValue = new ProcessSchemaParameterValue(postponedDateParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(postponedDateParameter);
		}

		protected virtual void InitializePreconfiguredPageHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a4af36b-6aa9-4659-98c1-cf050d9950f1"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Information about proceeding to handoff",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4df2b222-660d-4648-8f5a-bffb5a3269f2"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var clientUnitSchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4497dc66-0695-4ab9-b635-67be61818e31"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ClientUnitSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			clientUnitSchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(clientUnitSchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"6e63ff78-f0ea-4fe2-9769-9ac6352d43cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e3df99b-ffc6-455e-997c-c60bfdf7f2eb"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e143ccc9-9b11-4f17-a1a5-7ee92fce09f2"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("23bd5077-702b-4511-bef3-6506f8b0f77c"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a6f285cf-7c47-44dc-ae05-9583fc425406"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"UseCardProcessModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCardProcessModuleParameter.SourceValue = new ProcessSchemaParameterValue(useCardProcessModuleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("aa7fb4f0-d056-48b2-a1aa-6522326b3d80"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2b2d50da-858e-4c72-a4c5-f150375be4f8"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("255a61e2-a759-4a62-bd5e-8ae24a559429"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Use the page to specify information about decision date, need type (the BANT criteria) and the information required to create an opportunity (owner and sales division).",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d2cad175-5994-4244-8d81-52e247ed7e40"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var templateParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("d726baad-ac31-4b39-8193-f0fad988fd35"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Template",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			templateParameter.SourceValue = new ProcessSchemaParameterValue(templateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.21620f25-166f-42f1-8b4d-224a959040a3#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(templateParameter);
			var moduleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("28908944-bfb2-42d0-8082-a158159c5bb2"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Module",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			moduleParameter.SourceValue = new ProcessSchemaParameterValue(moduleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.eb89c336-08b9-4951-bffd-3f5abc433174#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(moduleParameter);
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("199c0e81-ce30-4afd-8e09-b39587499e01"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var urlParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d329955-122e-4815-b929-20479271d11c"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Url",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			urlParameter.SourceValue = new ProcessSchemaParameterValue(urlParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"""[Module]/[Page]/add""",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(urlParameter);
			var leadIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("cb59892e-1739-4d1c-b0d3-c9c2dc18668c"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var leadTypeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("1fb6bcd8-3144-4787-81cd-3e45b07fe3d3"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf"),
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(leadTypeParameter);
			var opportunityResponsibleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("1b6450a5-61db-4ee7-a240-8cda59688639"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf"),
				Name = @"OpportunityResponsible",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityResponsibleParameter.SourceValue = new ProcessSchemaParameterValue(opportunityResponsibleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(opportunityResponsibleParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("e109dccc-e548-4209-9562-f5f4c1a12a20"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf"),
				Name = @"OpportunityDepartment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(opportunityDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{a40a64fa-a0ea-40e6-9476-a59c1dfbb93f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
			var meetingTimeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4c10c0bd-466b-4d85-a804-de23f746f2e2"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf"),
				Name = @"MeetingTime",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			meetingTimeParameter.SourceValue = new ProcessSchemaParameterValue(meetingTimeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(meetingTimeParameter);
			var decisionDateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("10cfbcb1-bb50-4c35-afbd-cb10be7b07c5"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf"),
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(decisionDateParameter);
			var commentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("785320ba-9fb2-492f-8ae3-38b059e9a775"),
				ContainerUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf"),
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
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7")
			};
			parametrizedElement.Parameters.Add(commentParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadHandoffProcess = CreateLeadHandoffProcessLaneSet();
			LaneSets.Add(schemaLeadHandoffProcess);
			ProcessSchemaLane schemaLeadHandoff = CreateLeadHandoffLane();
			schemaLeadHandoffProcess.Lanes.Add(schemaLeadHandoff);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
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
			ProcessSchemaUserTask readleadforhandoff = CreateReadLeadForHandoffUserTask();
			FlowElements.Add(readleadforhandoff);
			ProcessSchemaUserTask readactivitydata = CreateReadActivityDataUserTask();
			FlowElements.Add(readactivitydata);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaParallelGateway parallelgateway1 = CreateParallelGateway1ParallelGateway();
			FlowElements.Add(parallelgateway1);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignal1 = CreateIntermediateCatchSignal1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignal1);
			ProcessSchemaUserTask linkleadtoprocess = CreateLinkLeadToProcessUserTask();
			FlowElements.Add(linkleadtoprocess);
			ProcessSchemaUserTask autogeneratedpageusertask1 = CreateAutoGeneratedPageUserTask1UserTask();
			FlowElements.Add(autogeneratedpageusertask1);
			ProcessSchemaExclusiveGateway exclusivegatewayleaddefined = CreateExclusiveGatewayLeadDefinedExclusiveGateway();
			FlowElements.Add(exclusivegatewayleaddefined);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaUserTask preconfiguredpagehandoff = CreatePreconfiguredPageHandoffUserTask();
			FlowElements.Add(preconfiguredpagehandoff);
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow9ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow7ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("f4359b3c-140b-4cfa-a64a-624975aad45f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(566, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(560, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(546, 413));
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(582, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(581, 294));
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(712, 163),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(353, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(326, 164),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, -1),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(1148, 189),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
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

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("a03340ad-f234-41cf-98dc-8ca1a3a48685"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1353, 522));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("450418d7-0200-4475-b7ff-5b9a030033d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("be291346-793f-4516-aa5b-d5092e1c6503"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("80779727-76f0-4a9b-bb4f-4ecf980a3615"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("08cf5beb-1b4f-40e4-8f9a-806083777f94"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f953c208-f894-44f6-8442-545758257172"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88c82def-7546-4f53-8c58-6ad4fc09f3d3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("d993453d-40dc-41e4-b308-9e536418010d"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88c82def-7546-4f53-8c58-6ad4fc09f3d3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb5358f6-93bf-45d4-bdc6-5e4e225ecaed"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowLeadDefined",
				UId = new Guid("5de1e928-e562-4a4c-bf12-a27ad4c8925e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88c82def-7546-4f53-8c58-6ad4fc09f3d3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("9ce26f73-4a5c-415d-92ed-e8dd01f06013"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(311, 521));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("67251549-a972-4c73-9036-2f0f644edc46"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("08cf5beb-1b4f-40e4-8f9a-806083777f94"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(494, 105));
			schemaFlow.PolylinePointPositions.Add(new Point(512, 105));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("bbced094-c4ba-4126-a19a-611d99d22ac1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("3066815c-90c7-4dd2-a9a2-3f5361f6bc27"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"LeadHandoffProcess",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"LeadHandoff",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"Start",
				Position = new Point(79, 80),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ReadLeadData",
				Position = new Point(391, 155),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ActivityUserTaskBANT",
				Position = new Point(512, 155),
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ChangeLeadStateToNoInterest",
				Position = new Point(699, 386),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ChangeLeadNurturing",
				Position = new Point(699, 267),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"TerminateOpportunity",
				Position = new Point(1340, 169),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadForHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ReadLeadForHandoff",
				Position = new Point(825, 155),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ReadActivityData",
				Position = new Point(699, 155),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"AddDataUserTask1",
				Position = new Point(1084, 155),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(1215, 155),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ParallelGateway1",
				Position = new Point(284, 155),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignal1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"IntermediateCatchSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(782, 508),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("bc0c2d60-5a3d-4840-aa4e-c60ea776e206");
			InitializeIntermediateCatchSignal1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateLinkLeadToProcessUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"LinkLeadToProcess",
				Position = new Point(171, 155),
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeLinkLeadToProcessParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"AutoGeneratedPageUserTask1",
				Position = new Point(581, 20),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAutoGeneratedPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayLeadDefinedExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("88c82def-7546-4f53-8c58-6ad4fc09f3d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"ExclusiveGatewayLeadDefined",
				Position = new Point(65, 155),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("bb5358f6-93bf-45d4-bdc6-5e4e225ecaed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"TerminateEvent1",
				Position = new Point(79, 281),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("08cf5beb-1b4f-40e4-8f9a-806083777f94"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"FormulaTask1",
				Position = new Point(460, 20),
				ResultParameterMetaPath = @"2011a547-369b-43fc-b445-c742752ae214",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,189,10,131,48,20,64,225,87,17,92,90,74,66,18,163,38,206,237,208,161,63,160,155,56,220,196,27,42,24,133,152,226,32,190,123,157,187,126,156,211,166,237,125,121,173,19,134,218,126,208,67,229,96,92,176,163,135,254,193,109,68,143,83,172,54,230,24,179,25,10,194,181,22,68,178,146,17,80,133,37,202,228,18,120,86,136,178,23,251,49,188,33,128,199,136,161,218,16,12,244,86,91,130,206,74,34,185,86,228,136,5,49,66,113,39,114,87,10,85,238,93,218,209,250,107,98,0,27,79,87,136,216,12,30,233,115,94,207,180,153,35,140,143,97,250,70,92,146,75,194,127,143,151,36,79,182,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreatePreconfiguredPageHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b"),
				CreatedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"),
				Name = @"PreconfiguredPageHandoff",
				Position = new Point(953, 155),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializePreconfiguredPageHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementHandoff78Finance(userConnection);
		}

		public override object Clone() {
			return new LeadManagementHandoff78FinanceSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementHandoff78Finance

	/// <exclude/>
	public class LeadManagementHandoff78Finance : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadHandoff

		/// <exclude/>
		public class ProcessLeadHandoff : ProcessLane
		{

			public ProcessLeadHandoff(UserConnection userConnection, LeadManagementHandoff78Finance process)
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

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,193,142,211,48,16,253,151,156,215,43,39,117,227,164,55,180,20,84,9,177,43,109,181,23,178,135,73,60,110,45,146,38,178,221,133,82,85,226,19,246,99,56,32,142,236,159,240,37,216,113,91,186,168,104,11,23,54,82,164,248,229,249,205,204,155,153,117,84,213,96,204,91,104,48,26,69,83,212,26,76,43,237,249,43,85,91,212,175,117,187,236,162,179,200,160,86,80,171,79,40,2,62,22,202,190,4,11,238,202,186,248,165,80,68,163,226,184,70,17,157,21,145,178,216,24,199,113,87,40,103,34,103,49,16,94,14,19,194,32,145,36,147,73,73,82,10,76,138,184,202,37,77,2,243,79,226,23,109,211,129,198,16,163,151,151,253,231,116,213,121,106,236,128,170,167,40,211,46,182,224,192,39,97,198,11,40,107,20,238,108,245,18,29,100,181,106,92,53,56,85,13,94,129,118,177,188,78,235,33,71,146,80,27,207,170,81,218,241,199,78,163,49,170,93,60,149,92,189,108,22,135,108,39,128,251,227,54,29,218,231,232,153,87,96,231,189,196,196,165,181,233,179,124,49,155,105,156,129,85,119,135,73,188,199,85,207,59,205,63,119,65,184,46,221,64,189,196,131,152,143,43,185,128,206,134,130,66,120,71,208,106,54,63,185,214,189,99,79,149,155,56,176,219,145,79,212,60,90,67,146,58,240,206,3,65,101,247,89,68,239,38,230,242,195,2,245,117,53,199,6,130,107,183,231,14,253,13,216,235,143,214,67,6,20,114,145,147,97,37,4,97,195,10,72,150,164,57,225,24,15,226,12,57,229,101,178,185,13,121,40,211,213,176,186,217,135,123,184,255,241,249,219,195,253,247,175,238,253,210,83,188,129,238,7,148,20,105,9,146,32,79,24,97,169,72,72,158,229,41,225,105,58,200,177,20,34,206,124,163,253,227,251,209,206,84,5,245,101,135,218,245,187,247,155,30,159,212,71,35,238,93,208,109,107,67,109,123,23,223,32,132,46,238,102,133,151,82,102,195,36,35,60,79,129,48,26,115,2,89,156,17,202,56,101,241,128,3,74,119,115,227,214,220,27,125,221,46,117,181,93,43,19,246,251,159,246,246,63,108,227,223,44,216,209,17,63,101,100,159,203,48,78,158,203,164,109,162,205,79,25,41,228,120,69,6,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ActivityUserTaskBANTFlowElement

		/// <exclude/>
		public class ActivityUserTaskBANTFlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTaskBANTFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
				_startIn = () => (int)((process.PostponedDate));
				_lead = () => (Guid)((process.LeadId));
				_account = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
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

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			internal Func<int> _startIn;
			public override int StartIn {
				get {
					return (_startIn ?? (_startIn = () => 0)).Invoke();
				}
				set {
					_startIn = () => { return value; };
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
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

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
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

			private bool _showExecutionPage = false;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.ActivityUserTaskBANT.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"89a7d2c0-103f-4f41-87f7-265a34bf1d89\",\"e07f0e4a-f36b-1410-6698-00155d043204\",\"a08e24ec-c5d1-4951-b49f-5e70dde6a7d9\",\"d87d32bc-f36b-1410-6598-00155d043204\"]";
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

			public ChangeLeadStateToNoInterestFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,219,48,16,252,149,128,201,209,107,240,37,82,244,181,185,4,72,130,160,73,115,137,115,88,146,203,70,168,108,25,146,92,32,53,252,239,165,21,187,182,139,166,13,2,244,80,160,58,72,176,201,153,89,205,112,180,98,103,253,243,130,216,132,221,81,219,98,215,164,126,252,161,105,105,124,211,54,129,186,110,124,217,4,172,171,111,232,107,186,193,22,103,212,83,123,143,245,146,186,203,170,235,71,39,199,48,54,98,103,95,135,85,54,121,88,177,139,158,102,159,46,98,102,71,146,92,39,83,0,38,89,130,230,60,128,47,188,130,80,232,194,163,77,86,20,50,131,67,83,47,103,243,43,234,241,6,251,39,54,89,177,129,45,19,56,47,173,11,214,0,151,66,129,78,133,0,12,209,128,114,202,144,224,198,249,168,217,122,196,186,240,68,51,28,68,247,96,45,48,149,142,28,216,130,123,208,228,61,148,1,3,164,164,156,55,186,212,130,194,6,188,221,191,7,62,156,94,54,205,151,229,98,44,99,18,33,148,6,140,180,1,116,204,55,140,34,1,143,84,18,121,244,154,135,113,178,37,55,38,42,64,171,40,203,228,237,222,59,7,164,173,77,193,59,237,101,121,250,184,17,138,85,183,168,241,249,254,85,189,107,162,120,50,195,126,217,86,253,243,248,186,233,79,170,121,118,158,186,158,226,11,197,226,40,141,67,146,213,244,37,212,41,155,76,95,139,117,251,188,29,220,58,14,246,231,76,167,108,52,101,183,205,178,13,27,70,181,249,177,243,120,80,224,219,11,126,113,219,93,47,28,3,236,10,231,248,153,218,235,172,56,192,135,165,115,236,113,16,191,203,115,239,136,189,116,5,183,217,100,75,232,178,157,70,66,25,5,130,19,206,39,101,149,76,73,14,232,143,148,178,53,243,64,199,131,189,37,179,1,63,40,239,135,217,29,191,252,207,124,89,215,131,64,55,188,255,230,60,111,7,223,174,156,31,4,121,192,208,196,42,85,20,47,230,239,180,106,51,194,15,79,182,106,107,182,94,143,14,59,85,234,96,76,169,36,168,84,228,78,217,50,183,75,37,3,78,150,69,178,62,40,12,238,183,157,242,129,7,25,13,135,2,85,132,92,3,14,136,154,32,24,78,104,173,201,157,53,127,179,83,82,105,17,162,128,252,33,200,149,14,89,222,113,33,192,36,107,156,162,100,72,235,113,33,48,6,69,1,84,193,243,38,47,242,140,60,11,150,158,148,231,36,68,226,111,237,212,109,159,15,222,255,46,189,175,75,242,207,89,253,99,93,122,92,127,7,248,139,99,205,253,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "8bef0d31f58d4d54b1a2e096bfcbb0b7",
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

			public ChangeLeadNurturingFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,203,110,219,48,16,252,149,130,201,209,107,240,37,62,124,109,46,1,146,32,104,210,92,226,28,150,228,178,17,106,91,134,36,7,72,3,255,123,105,197,110,236,162,41,140,2,61,20,168,14,20,68,106,102,86,59,59,122,97,167,253,243,146,216,132,221,82,219,98,215,228,126,252,177,105,105,124,221,54,145,186,110,124,209,68,156,213,223,48,204,232,26,91,156,83,79,237,29,206,86,212,93,212,93,63,250,112,8,99,35,118,250,52,156,178,201,253,11,59,239,105,254,249,60,21,118,33,93,86,33,90,240,82,85,160,53,26,64,205,37,24,227,124,217,214,206,114,81,192,177,153,173,230,139,75,234,241,26,251,71,54,121,97,3,91,33,240,65,90,31,173,1,46,133,2,157,43,1,24,147,1,229,149,33,193,141,15,73,179,245,136,117,241,145,230,56,136,190,129,181,192,236,60,121,176,21,15,160,41,4,112,17,35,228,172,124,48,218,105,65,113,3,222,190,255,6,188,63,185,104,154,175,171,229,88,166,44,98,116,6,140,180,17,116,42,11,38,145,129,39,114,68,1,131,230,113,92,5,149,4,215,6,114,20,6,116,21,29,96,133,2,164,119,41,71,87,217,74,155,147,135,141,80,170,187,229,12,159,239,222,213,187,34,74,31,230,216,175,218,186,127,30,159,213,93,108,158,168,165,244,10,95,30,56,177,79,240,50,125,53,116,202,38,211,247,44,221,222,111,134,78,29,154,250,179,159,83,54,154,178,155,102,213,198,13,163,218,60,236,250,59,40,240,237,5,191,88,118,215,43,199,0,187,196,5,126,161,246,170,40,14,240,225,232,12,123,28,196,111,75,221,59,226,32,125,197,109,105,176,37,244,197,49,35,193,37,129,224,133,15,89,89,37,115,150,3,250,19,229,210,151,69,164,195,194,142,241,107,192,15,202,111,197,236,70,175,236,44,86,179,217,32,208,13,223,191,153,229,109,225,219,147,179,61,19,247,24,154,84,231,154,210,249,226,15,91,181,41,225,71,79,182,106,107,182,94,143,246,243,164,130,148,210,219,10,148,38,1,218,144,2,167,200,65,170,140,112,209,32,25,235,127,155,167,16,121,148,201,112,168,80,37,40,17,224,128,168,9,162,225,132,214,26,146,220,252,205,60,73,165,69,76,2,74,102,74,156,99,145,247,92,8,48,217,26,175,40,27,210,122,44,116,204,209,104,13,164,168,212,232,45,129,43,127,1,160,164,85,153,131,224,184,87,71,230,233,166,47,131,183,201,81,223,214,97,213,215,205,226,127,146,252,113,73,58,194,169,127,44,73,15,235,239,101,67,93,26,247,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "8bef0d31f58d4d54b1a2e096bfcbb0b7",
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

		#region Class: ReadLeadForHandoffFlowElement

		/// <exclude/>
		public class ReadLeadForHandoffFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadForHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,211,64,20,253,23,175,59,149,51,51,126,101,135,74,64,145,16,173,212,168,27,220,197,181,125,237,140,176,99,107,102,82,8,81,36,62,161,31,195,2,177,164,127,194,151,112,199,78,66,138,130,26,216,80,75,150,60,199,103,206,61,247,181,246,242,26,140,121,11,13,122,99,111,134,90,131,105,75,123,254,74,213,22,245,107,221,46,59,239,204,51,168,21,212,234,19,22,3,62,41,148,125,9,22,232,202,58,253,165,144,122,227,244,184,70,234,157,165,158,178,216,24,226,184,43,18,67,14,50,98,153,207,3,38,81,20,44,203,1,153,72,130,92,112,89,22,65,25,111,153,127,16,191,104,155,14,52,14,49,122,249,178,255,156,173,58,71,29,17,144,247,20,101,218,197,22,20,206,132,153,44,32,171,177,160,179,213,75,36,200,106,213,80,54,56,83,13,94,129,166,88,78,167,117,16,145,74,168,141,99,213,88,218,201,199,78,163,49,170,93,60,101,174,94,54,139,67,54,9,224,254,184,181,227,247,30,29,243,10,236,188,151,152,146,173,77,239,242,69,85,105,172,192,170,187,67,19,239,113,213,243,78,171,31,93,40,168,75,55,80,47,241,32,230,227,76,46,160,179,67,66,67,120,34,104,85,205,79,206,117,95,177,167,210,229,4,118,59,242,137,154,71,115,224,33,129,119,14,24,84,118,159,169,247,110,106,46,63,44,80,95,231,115,108,96,168,218,237,57,161,191,1,123,253,241,58,144,224,67,82,36,44,200,139,130,201,32,7,22,243,48,97,17,142,196,40,198,200,143,50,190,185,29,124,40,211,213,176,186,217,135,123,184,255,241,249,219,195,253,247,175,244,126,233,41,174,128,244,35,129,2,98,20,130,154,146,72,38,69,136,44,139,69,194,32,150,200,185,28,73,16,33,53,218,61,174,31,109,165,114,168,47,59,212,212,239,190,222,254,241,73,125,52,226,174,10,186,109,237,144,219,190,138,111,16,134,46,238,102,101,132,92,114,192,132,201,60,138,152,132,56,99,73,25,100,76,22,33,114,95,4,34,136,51,50,67,107,238,10,125,221,46,117,190,93,43,51,236,247,63,237,237,127,216,198,191,89,176,163,35,126,202,200,62,151,97,156,62,151,73,219,120,155,159,135,70,83,60,69,6,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ReadActivityDataFlowElement

		/// <exclude/>
		public class ReadActivityDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadActivityDataFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,211,64,20,253,149,200,235,78,149,241,123,178,43,37,160,108,218,74,141,186,33,93,92,143,175,211,17,118,108,141,39,133,16,69,234,39,180,85,87,236,248,3,22,72,116,3,11,42,248,144,126,9,119,236,54,164,40,168,129,13,16,201,202,204,209,185,231,190,103,238,200,28,234,122,15,10,116,122,206,16,181,134,186,204,204,246,51,149,27,212,207,117,57,173,156,45,167,70,173,32,87,111,48,109,241,126,170,204,83,48,64,38,243,209,15,133,145,211,27,173,215,24,57,91,35,71,25,44,106,226,144,9,198,232,101,65,34,25,134,232,51,31,35,201,32,201,34,38,189,144,251,73,152,6,66,68,45,243,87,226,187,101,81,129,198,214,71,35,159,53,199,225,172,178,84,78,128,108,40,170,46,39,119,160,103,131,168,251,19,72,114,76,233,110,244,20,9,50,90,21,148,13,14,85,129,7,160,201,151,213,41,45,68,164,12,242,218,178,114,204,76,255,117,165,177,174,85,57,121,44,184,124,90,76,86,217,36,128,203,235,93,56,221,38,70,203,60,0,115,210,72,12,40,172,69,19,229,206,120,172,113,12,70,157,174,6,241,18,103,13,111,179,250,145,65,74,93,58,130,124,138,43,62,31,102,178,11,149,105,19,106,221,19,65,171,241,201,198,185,46,43,246,88,186,46,129,213,61,121,67,205,181,57,184,33,129,167,22,104,85,238,143,35,231,197,160,222,127,53,65,125,40,79,176,128,182,106,199,219,132,254,4,244,115,44,112,98,122,243,56,142,19,79,248,33,243,18,145,49,63,75,145,197,41,34,243,68,0,16,115,143,115,41,23,100,176,12,168,55,247,221,72,240,128,251,76,102,161,160,210,251,9,131,174,0,150,132,110,4,50,149,153,192,120,113,220,6,174,234,42,135,217,209,50,190,155,243,219,179,171,155,243,47,239,233,251,208,252,95,220,158,189,179,135,206,205,197,183,75,123,123,75,183,207,247,240,39,250,174,91,244,226,235,101,231,201,206,222,112,123,144,118,8,253,184,78,229,186,241,106,155,72,190,120,8,194,197,36,100,93,47,179,35,226,122,76,4,169,207,34,33,48,75,121,224,199,30,167,97,179,63,59,19,229,88,73,200,247,43,212,52,115,77,207,187,235,183,229,193,154,217,78,232,178,52,109,125,151,157,220,145,52,183,202,208,172,174,204,108,228,185,8,33,231,44,232,218,194,197,60,101,16,7,46,203,68,144,184,32,188,56,72,201,122,65,207,141,109,248,97,57,213,242,110,189,235,246,157,249,163,247,227,47,188,10,191,179,232,107,87,109,147,213,249,111,151,98,240,47,141,231,194,89,124,7,217,93,169,69,2,7,0,0 })));
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

			public AddDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
				_recordDefValues_Message = () => new LocalizableString(String.Concat((process.FeedMessage), Environment.NewLine, (process.PreconfiguredPageHandoff.Comment)));
				_recordDefValues_CreatedBy = () => (Guid)((process.PreconfiguredPageHandoff.OwnerId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_EntityId", () => _recordDefValues_EntityId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_EntitySchemaUId", () => _recordDefValues_EntitySchemaUId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Message", () => _recordDefValues_Message.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CreatedBy", () => _recordDefValues_CreatedBy.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_EntityId;
			internal Func<Guid> _recordDefValues_EntitySchemaUId;
			internal Func<string> _recordDefValues_Message;
			internal Func<Guid> _recordDefValues_CreatedBy;

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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,221,110,91,69,16,126,149,232,164,23,69,242,70,251,119,246,199,183,180,160,72,73,169,154,210,155,56,23,179,187,179,173,37,251,56,178,157,70,197,178,84,120,130,164,151,60,3,23,33,226,175,32,138,20,171,60,72,159,132,57,39,118,154,132,98,170,180,20,36,114,228,243,55,103,102,118,118,103,191,111,198,147,226,198,248,201,46,22,237,226,62,14,135,48,26,228,241,218,199,131,33,174,221,29,14,34,142,70,107,27,131,8,189,238,23,16,122,120,23,134,208,199,49,14,31,64,111,15,71,27,221,209,184,181,114,209,172,104,21,55,30,55,95,139,246,246,164,88,31,99,255,243,245,68,222,3,38,12,214,35,147,160,75,166,101,66,6,218,0,243,94,168,16,93,8,38,58,50,142,131,222,94,191,218,196,49,220,133,241,163,162,61,41,26,111,181,3,110,13,88,47,201,214,39,166,109,10,204,121,145,152,49,82,40,45,128,135,132,197,180,85,140,226,35,236,67,51,232,121,99,180,46,74,197,44,247,52,122,42,61,11,14,3,139,130,75,77,227,39,99,67,109,60,215,127,109,184,189,186,189,62,250,108,191,194,225,86,227,183,157,161,55,194,157,53,146,94,18,156,45,78,123,82,106,224,224,147,103,101,76,20,106,25,129,57,105,60,179,40,148,112,104,185,13,114,186,179,186,83,143,152,186,163,221,30,60,121,240,231,129,103,7,175,158,254,60,59,56,249,137,206,239,78,149,119,47,36,224,188,250,164,115,154,199,78,209,238,252,85,38,231,247,211,184,47,230,242,114,26,59,69,171,83,108,13,246,134,177,246,168,232,229,214,185,56,155,65,26,149,75,175,139,188,145,164,218,235,245,230,146,91,48,134,133,226,66,60,72,221,220,197,180,94,109,45,210,213,120,225,243,131,189,225,178,56,78,99,123,23,179,77,168,224,33,14,239,208,2,188,142,253,44,202,251,180,140,11,199,82,113,225,74,99,25,8,21,153,86,146,51,103,156,101,57,153,236,81,25,239,67,106,172,239,97,198,33,86,17,175,24,216,61,28,53,171,93,3,102,30,87,189,84,211,98,58,109,157,135,17,55,38,131,55,200,132,2,218,200,220,11,230,147,8,12,92,208,166,76,65,210,111,41,140,192,130,23,28,104,71,242,196,153,70,65,16,44,99,100,150,246,107,150,73,122,145,253,251,135,81,133,251,43,159,238,117,211,205,78,65,80,205,206,35,161,161,228,129,2,8,132,227,8,145,229,172,124,48,218,105,129,177,83,124,180,12,27,87,243,118,13,158,255,59,120,100,118,9,149,67,134,194,81,29,1,105,153,215,96,152,178,180,137,80,113,110,99,92,10,158,28,180,141,78,100,154,145,164,253,239,92,96,65,230,192,120,169,69,25,92,2,167,227,251,7,207,214,120,216,173,30,18,47,87,17,198,55,175,84,145,208,251,140,128,146,41,35,9,38,66,43,22,44,145,128,18,201,41,43,189,68,52,117,69,106,173,220,174,30,119,135,131,170,143,213,120,237,14,238,111,116,43,42,14,111,63,230,237,30,214,166,237,73,150,129,155,136,192,178,44,21,37,159,27,230,121,136,44,82,218,117,52,180,25,66,57,189,24,164,117,101,45,38,66,202,129,210,227,101,102,14,80,49,229,2,47,9,227,96,45,153,172,238,44,229,134,203,139,245,9,98,218,164,170,71,123,118,201,244,102,7,47,95,80,153,253,118,118,248,234,171,111,232,225,168,121,57,56,121,65,130,167,95,211,67,93,136,143,86,22,159,191,167,243,199,217,225,239,207,232,254,203,236,240,229,179,133,218,209,217,195,10,93,126,107,84,207,217,28,55,46,169,156,47,52,142,79,213,230,42,103,159,232,252,161,118,79,211,232,215,161,206,231,124,205,96,31,152,193,34,207,92,27,162,9,186,80,177,12,145,24,76,99,73,172,33,124,138,174,20,38,136,15,202,96,209,250,168,146,210,76,58,42,250,90,249,200,188,228,68,41,25,74,15,78,70,157,97,41,131,97,200,38,4,175,8,89,68,124,212,167,82,255,192,121,34,88,34,24,162,193,140,82,252,155,93,244,187,240,7,128,37,130,206,156,37,94,210,220,28,145,8,8,34,57,83,74,169,164,9,42,57,254,54,109,247,127,147,10,154,184,230,46,143,231,222,232,229,240,228,203,139,210,131,147,95,155,147,132,207,233,225,249,245,63,135,55,113,192,63,78,29,65,250,146,91,106,21,44,130,167,198,212,72,230,82,221,108,11,31,178,178,74,230,44,151,81,7,81,11,181,72,165,96,142,32,73,21,155,176,230,18,117,236,224,184,74,218,56,149,146,250,59,234,216,153,254,1,128,153,87,136,222,15,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "8bef0d31f58d4d54b1a2e096bfcbb0b7",
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
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
				_recordColumnValues_SalesOwner = () => (Guid)((process.PreconfiguredPageHandoff.OpportunityResponsible));
				_recordColumnValues_MeetingDate = () => (DateTime)((process.PreconfiguredPageHandoff.MeetingTime));
				_recordColumnValues_LeadType = () => (Guid)((process.PreconfiguredPageHandoff.LeadType));
				_recordColumnValues_DecisionDate = () => (DateTime)((process.PreconfiguredPageHandoff.DecisionDate));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.PreconfiguredPageHandoff.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SalesOwner", () => _recordColumnValues_SalesOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_MeetingDate", () => _recordColumnValues_MeetingDate.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadType", () => _recordColumnValues_LeadType.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_DecisionDate", () => _recordColumnValues_DecisionDate.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_SalesOwner;
			internal Func<DateTime> _recordColumnValues_MeetingDate;
			internal Func<Guid> _recordColumnValues_LeadType;
			internal Func<DateTime> _recordColumnValues_DecisionDate;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,211,64,20,253,23,175,59,149,157,216,30,59,59,84,2,138,132,104,165,70,221,224,46,174,103,238,36,35,236,216,154,153,20,66,20,137,79,232,199,176,64,44,233,159,240,37,220,177,147,144,162,136,6,54,212,146,37,207,241,153,115,207,125,173,3,81,129,181,111,161,198,96,20,76,209,24,176,141,114,231,175,116,229,208,188,54,205,178,13,206,2,139,70,67,165,63,161,236,241,177,212,238,37,56,160,43,235,226,151,66,17,140,138,227,26,69,112,86,4,218,97,109,137,67,87,84,84,70,113,22,11,166,148,16,44,230,50,98,121,150,35,67,14,34,133,60,147,92,121,181,63,136,95,52,117,11,6,251,24,157,188,234,62,167,171,214,83,35,2,68,71,209,182,89,108,193,161,55,97,199,11,40,43,148,116,118,102,137,4,57,163,107,202,6,167,186,198,43,48,20,203,235,52,30,34,146,130,202,122,86,133,202,141,63,182,6,173,213,205,226,41,115,213,178,94,28,178,73,0,247,199,173,157,176,243,232,153,87,224,230,157,196,132,108,109,58,151,47,102,51,131,51,112,250,238,208,196,123,92,117,188,211,234,71,23,36,117,233,6,170,37,30,196,124,156,201,5,180,174,79,168,15,79,4,163,103,243,147,115,221,87,236,169,116,7,4,182,59,242,137,154,71,115,24,164,4,222,121,160,87,217,125,22,193,187,137,189,252,176,64,115,45,230,88,67,95,181,219,115,66,127,3,246,250,163,117,18,67,8,185,204,89,34,164,100,113,34,128,101,131,52,103,28,163,97,148,33,15,121,57,216,220,246,62,180,109,43,88,221,236,195,61,220,255,248,252,237,225,254,251,87,122,191,116,20,95,64,250,145,135,81,201,7,130,51,20,144,176,56,15,21,203,56,31,48,21,70,152,36,160,164,130,148,26,237,31,223,143,102,166,5,84,151,45,26,234,119,87,239,240,248,164,62,26,113,95,5,211,52,174,207,109,95,197,55,8,125,23,119,179,146,202,44,227,57,210,112,164,138,179,88,165,146,65,200,21,227,73,137,152,12,211,44,137,74,50,67,107,238,11,125,221,44,141,216,174,149,237,247,251,159,246,246,63,108,227,223,44,216,209,17,63,101,100,159,203,48,78,158,203,164,109,130,205,79,140,163,78,37,69,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,205,110,91,85,16,126,149,200,116,153,99,157,255,31,111,9,139,72,41,173,104,233,166,201,98,206,156,57,173,133,99,71,182,3,42,81,164,194,11,64,42,86,21,27,246,44,218,138,0,42,162,72,173,202,131,244,73,152,123,109,55,78,105,211,84,80,33,163,88,186,215,215,199,51,115,38,227,249,190,153,51,57,232,92,154,222,217,163,78,175,115,157,198,99,152,140,234,180,251,225,104,76,221,171,227,17,210,100,210,221,26,33,12,250,95,66,30,208,85,24,195,46,77,105,124,3,6,251,52,217,234,79,166,235,107,167,213,58,235,157,75,159,183,223,118,122,55,15,58,155,83,218,253,116,179,176,245,232,64,34,86,41,130,146,81,88,212,90,64,42,81,164,4,177,152,168,74,148,192,202,56,26,236,239,14,47,211,20,174,194,244,118,167,119,208,105,173,177,129,140,18,117,241,82,56,48,69,216,104,165,0,176,36,208,75,130,16,60,105,233,59,135,235,157,9,222,166,93,104,55,61,81,182,10,106,76,148,68,112,50,11,75,57,139,136,128,162,86,147,178,103,99,138,176,81,158,203,159,40,222,252,96,107,52,250,108,127,175,171,181,177,10,139,18,46,27,195,254,243,246,73,42,37,124,13,62,25,170,158,172,237,6,72,50,73,222,193,153,236,132,117,137,255,62,157,141,144,64,148,164,215,30,157,255,96,167,217,168,244,39,123,3,184,115,227,239,251,61,251,246,233,15,124,253,241,236,232,197,215,63,242,195,3,190,30,241,245,132,23,238,54,223,252,206,215,175,124,61,238,182,162,188,122,127,46,246,83,251,205,209,211,111,214,248,225,183,185,88,179,248,128,69,159,63,225,135,159,151,23,151,108,29,175,45,111,249,100,73,162,213,152,249,188,119,234,231,95,246,250,96,123,150,69,219,157,222,246,155,242,104,254,126,173,253,121,78,103,210,171,73,180,221,89,223,238,92,27,237,143,177,177,104,248,195,198,82,184,218,77,90,145,87,62,46,178,134,87,134,251,131,193,124,101,3,166,176,16,92,44,143,74,191,246,169,108,14,175,45,146,165,181,34,231,47,241,154,219,226,53,243,237,159,168,93,134,33,220,162,241,199,28,128,19,223,95,122,121,157,195,184,48,156,117,114,50,168,42,2,65,226,172,245,90,196,162,64,36,149,114,53,193,232,90,117,171,253,9,85,26,211,16,233,180,99,231,201,217,185,254,164,141,118,3,215,185,95,77,168,14,59,135,135,235,203,32,86,74,87,31,8,133,67,203,32,174,90,137,140,20,132,14,37,147,69,133,164,212,153,32,78,89,135,132,193,11,169,21,123,84,157,18,128,197,11,147,140,39,37,125,202,197,190,79,16,151,170,16,163,23,94,7,20,182,240,13,10,199,87,22,138,68,25,178,149,216,245,190,26,67,76,77,142,67,196,68,131,85,0,135,91,120,239,130,77,132,213,3,254,171,32,126,113,247,187,133,220,241,28,184,44,247,244,171,25,180,143,158,223,155,129,115,174,125,127,89,246,225,220,212,146,60,219,109,109,126,127,162,48,67,244,163,198,204,227,51,129,126,124,1,244,213,4,250,57,242,250,157,128,14,210,97,172,142,68,72,73,10,155,148,23,81,37,37,146,41,50,121,182,138,96,206,4,186,67,89,33,36,47,178,140,12,116,165,61,3,157,161,139,181,20,212,206,153,4,242,125,0,253,230,230,228,202,23,67,26,207,226,211,171,48,152,208,78,151,87,95,89,248,104,64,187,52,156,246,14,170,206,210,35,129,168,218,177,163,70,122,230,200,140,220,86,164,100,209,27,45,179,59,100,133,151,21,171,119,160,216,7,39,193,9,175,74,227,30,19,32,104,230,214,136,5,92,242,49,122,147,14,119,222,78,17,109,69,126,184,76,17,15,151,49,251,184,89,92,91,70,251,47,207,142,254,188,215,50,4,147,194,73,225,95,60,44,104,226,120,89,231,209,50,204,215,22,52,240,6,6,96,243,221,43,123,123,163,241,116,127,216,159,222,225,108,217,27,13,39,125,110,253,46,136,97,37,137,65,249,76,198,115,149,141,149,52,195,208,37,214,47,220,57,71,105,138,245,209,148,98,222,137,24,200,68,73,165,113,3,35,112,135,91,140,0,149,140,112,197,101,77,178,20,175,234,153,196,64,21,141,118,82,113,59,98,26,3,28,165,88,193,10,85,130,68,159,171,246,53,173,42,49,112,7,36,81,102,62,157,120,207,238,149,232,154,64,91,81,72,155,26,172,175,154,244,234,18,195,101,162,105,127,120,235,122,127,247,130,13,254,27,54,40,90,81,162,106,5,74,111,133,149,74,139,172,185,234,87,80,16,85,80,5,94,246,243,175,101,131,115,59,118,110,54,8,58,248,160,25,128,42,114,214,163,69,118,136,207,248,154,139,34,31,20,184,76,22,247,150,54,193,39,31,24,34,94,19,31,40,156,52,34,50,9,8,166,24,143,76,78,222,176,129,21,101,3,85,179,207,200,231,8,163,44,255,90,33,6,238,161,176,8,67,214,101,25,42,153,98,86,151,13,182,8,74,147,155,23,141,193,74,54,6,92,170,51,101,30,194,217,100,248,70,68,92,170,42,207,228,180,13,224,42,82,140,241,221,78,12,160,66,82,0,34,242,93,88,224,19,67,2,235,68,53,5,75,48,133,161,122,246,104,160,233,7,124,85,153,39,130,220,84,216,12,149,77,57,43,100,224,67,141,45,210,7,135,43,75,5,18,107,198,204,211,146,236,248,56,133,134,27,131,202,125,2,47,201,76,129,217,0,221,234,82,193,6,97,127,210,31,13,57,81,47,232,224,162,51,152,77,10,17,98,194,234,132,142,153,139,95,181,156,251,42,152,102,208,71,42,71,6,12,3,242,44,58,0,43,193,219,10,2,120,188,207,189,14,49,202,44,15,14,249,132,141,170,212,156,147,169,171,74,7,60,233,76,5,17,5,185,102,140,170,101,18,201,49,131,87,87,249,8,1,74,131,150,255,139,1,194,6,241,255,12,166,77,156,46,218,132,149,108,19,92,137,214,121,70,176,114,196,133,171,144,227,129,30,223,184,122,41,201,29,126,226,57,223,219,218,132,157,195,191,0,21,21,193,125,100,28,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "8bef0d31f58d4d54b1a2e096bfcbb0b7",
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

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = true;
				SchemaElementUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "LinkLeadToProcess", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: IntermediateCatchSignal1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal1";
				IsLogging = true;
				SchemaElementUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""bc0c2d60-5a3d-4840-aa4e-c60ea776e206""]}";
				EntityFilters = @"{_isFilter:false,uId:""ff91b700-bf5f-4cda-aef7-97d68bbfe418"",name:""FilterEdit"",items:[]}";
				_recordId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: LinkLeadToProcessFlowElement

		/// <exclude/>
		public class LinkLeadToProcessFlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkLeadToProcessFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkLeadToProcess";
				IsLogging = true;
				SchemaElementUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _entityId;
			public override Guid EntityId {
				get {
					return (_entityId ?? (_entityId = () => Guid.Empty)).Invoke();
				}
				set {
					_entityId = () => { return value; };
				}
			}

			private Guid _entitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AutoGeneratedPageUserTask1FlowElement

		/// <exclude/>
		public class AutoGeneratedPageUserTask1FlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public AutoGeneratedPageUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AutoGeneratedPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("0f00c3e2-1992-4070-a86c-8b54a13627d2");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Elements.Value"));
				}
				set {
					_elements = value;
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

			public virtual DateTime PostponedDate {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Class: PreconfiguredPageHandoffFlowElement

		/// <exclude/>
		public class PreconfiguredPageHandoffFlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public PreconfiguredPageHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff78Finance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PreconfiguredPageHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("f2b06cea-f253-4306-90bc-c6994c6320b5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_showExecutionPage = () => (bool)(false);
				_leadId = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_leadType = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_opportunityResponsible = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_opportunityDepartment = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("OpportunityDepartment").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OpportunityDepartmentId") : Guid.Empty)));
				_meetingTime = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_decisionDate = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("DecisionDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("DecisionDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_comment = () => new LocalizableString(((process.ReadActivityData.ResultEntity.IsColumnValueLoaded(process.ReadActivityData.ResultEntity.Schema.Columns.GetByName("DetailedResult").ColumnValueName) ? process.ReadActivityData.ResultEntity.GetTypedColumnValue<string>("DetailedResult") : null)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.PreconfiguredPageHandoff.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.PreconfiguredPageHandoff.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("6e63ff78-f0ea-4fe2-9769-9ac6352d43cf");
			public override Guid ClientUnitSchemaUId {
				get {
					return _clientUnitSchemaUId;
				}
				set {
					_clientUnitSchemaUId = value;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "BaseElements.PreconfiguredPageHandoff.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			internal Func<Guid> _leadId;
			public virtual Guid LeadId {
				get {
					return (_leadId ?? (_leadId = () => Guid.Empty)).Invoke();
				}
				set {
					_leadId = () => { return value; };
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

			internal Func<Guid> _opportunityDepartment;
			public virtual Guid OpportunityDepartment {
				get {
					return (_opportunityDepartment ?? (_opportunityDepartment = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityDepartment = () => { return value; };
				}
			}

			internal Func<DateTime> _meetingTime;
			public virtual DateTime MeetingTime {
				get {
					return (_meetingTime ?? (_meetingTime = () => DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).Invoke();
				}
				set {
					_meetingTime = () => { return value; };
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

		public LeadManagementHandoff78Finance(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementHandoff78Finance";
			SchemaUId = new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7");
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
				return new Guid("8bef0d31-f58d-4d54-b1a2-e096bfcbb0b7");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementHandoff78Finance, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementHandoff78Finance, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		public virtual bool OpenTaskPage {
			get;
			set;
		}

		private string _feedMessage;
		public virtual string FeedMessage {
			get {
				return _feedMessage ?? (_feedMessage = GetLocalizableString("8bef0d31f58d4d54b1a2e096bfcbb0b7",
						 "Parameters.FeedMessage.Value"));
			}
			set {
				_feedMessage = value;
			}
		}

		private int _postponedDate = 0;
		public int PostponedDate {
			get {
				return _postponedDate;
			}
			set {
				_postponedDate = value;
			}
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
					IsLogging = true,
				});
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

		private ParallelGateway1FlowElement _parallelGateway1;
		public ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LinkLeadToProcessFlowElement _linkLeadToProcess;
		public LinkLeadToProcessFlowElement LinkLeadToProcess {
			get {
				return _linkLeadToProcess ?? (_linkLeadToProcess = new LinkLeadToProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AutoGeneratedPageUserTask1FlowElement _autoGeneratedPageUserTask1;
		public AutoGeneratedPageUserTask1FlowElement AutoGeneratedPageUserTask1 {
			get {
				return _autoGeneratedPageUserTask1 ?? (_autoGeneratedPageUserTask1 = new AutoGeneratedPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("88c82def-7546-4f53-8c58-6ad4fc09f3d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayLeadDefined.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("bb5358f6-93bf-45d4-bdc6-5e4e225ecaed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("08cf5beb-1b4f-40e4-8f9a-806083777f94"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private PreconfiguredPageHandoffFlowElement _preconfiguredPageHandoff;
		public PreconfiguredPageHandoffFlowElement PreconfiguredPageHandoff {
			get {
				return _preconfiguredPageHandoff ?? (_preconfiguredPageHandoff = new PreconfiguredPageHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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

		private ProcessConditionalFlow _conditionalFlowLeadUndefined;
		public ProcessConditionalFlow ConditionalFlowLeadUndefined {
			get {
				return _conditionalFlowLeadUndefined ?? (_conditionalFlowLeadUndefined = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowLeadUndefined",
					SchemaElementUId = new Guid("d993453d-40dc-41e4-b308-9e536418010d"),
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
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ActivityUserTaskBANT.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTaskBANT };
			FlowElements[ChangeLeadStateToNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadStateToNoInterest };
			FlowElements[ChangeLeadNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadNurturing };
			FlowElements[TerminateOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateOpportunity };
			FlowElements[ReadLeadForHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadForHandoff };
			FlowElements[ReadActivityData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadActivityData };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[LinkLeadToProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkLeadToProcess };
			FlowElements[AutoGeneratedPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageUserTask1 };
			FlowElements[ExclusiveGatewayLeadDefined.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayLeadDefined };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[PreconfiguredPageHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { PreconfiguredPageHandoff };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayLeadDefined", e.Context.SenderName));
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
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageUserTask1", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ActivityUserTaskBANT");
						break;
					case "ChangeLeadStateToNoInterest":
						break;
					case "ChangeLeadNurturing":
						break;
					case "TerminateOpportunity":
						CompleteProcess();
						break;
					case "ReadLeadForHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PreconfiguredPageHandoff", e.Context.SenderName));
						break;
					case "ReadActivityData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadForHandoff", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
						}
						break;
					case "IntermediateCatchSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateOpportunity", e.Context.SenderName));
						break;
					case "LinkLeadToProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "AutoGeneratedPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "ExclusiveGatewayLeadDefined":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkLeadToProcess", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTaskBANT", e.Context.SenderName));
						break;
					case "PreconfiguredPageHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
			}
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

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayLeadDefined", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("AutoGeneratedPageUserTask1.PostponedDate")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.PostponedDate", AutoGeneratedPageUserTask1.PostponedDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("PreconfiguredPageHandoff.LeadId")) {
				writer.WriteValue("PreconfiguredPageHandoff.LeadId", PreconfiguredPageHandoff.LeadId, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.LeadType")) {
				writer.WriteValue("PreconfiguredPageHandoff.LeadType", PreconfiguredPageHandoff.LeadType, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.OpportunityResponsible")) {
				writer.WriteValue("PreconfiguredPageHandoff.OpportunityResponsible", PreconfiguredPageHandoff.OpportunityResponsible, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.OpportunityDepartment")) {
				writer.WriteValue("PreconfiguredPageHandoff.OpportunityDepartment", PreconfiguredPageHandoff.OpportunityDepartment, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.MeetingTime")) {
				writer.WriteValue("PreconfiguredPageHandoff.MeetingTime", PreconfiguredPageHandoff.MeetingTime, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("PreconfiguredPageHandoff.DecisionDate")) {
				writer.WriteValue("PreconfiguredPageHandoff.DecisionDate", PreconfiguredPageHandoff.DecisionDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("PreconfiguredPageHandoff.Comment")) {
				writer.WriteValue("PreconfiguredPageHandoff.Comment", PreconfiguredPageHandoff.Comment, null);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("OpenTaskPage")) {
				writer.WriteValue("OpenTaskPage", OpenTaskPage, false);
			}
			if (!HasMapping("FeedMessage")) {
				writer.WriteValue("FeedMessage", FeedMessage, null);
			}
			if (!HasMapping("PostponedDate")) {
				writer.WriteValue("PostponedDate", PostponedDate, 0);
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
			MetaPathParameterValues.Add("33fe706c-8bb5-40f7-890a-9d67b92dbea5", () => OpenTaskPage);
			MetaPathParameterValues.Add("e99feae2-362b-4143-b7aa-31d837292ee6", () => FeedMessage);
			MetaPathParameterValues.Add("2011a547-369b-43fc-b445-c742752ae214", () => PostponedDate);
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
			MetaPathParameterValues.Add("8ad9f6fb-958b-43df-b80d-51bf6cda4238", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("5624c57e-4bd7-43dc-831b-47b31fdac380", () => ReadLeadData.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("99e9cc26-01cd-4e03-9c89-1d86e4dbc2c2", () => ActivityUserTaskBANT.Application);
			MetaPathParameterValues.Add("f125cd4c-65d2-4885-9b77-e4bcc5b9f876", () => ActivityUserTaskBANT.FinApplication);
			MetaPathParameterValues.Add("2c070493-7483-4c5e-a83b-3eb1c5d78ab7", () => ChangeLeadStateToNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("c600955c-8b94-4c98-aee1-79c3c61d4140", () => ChangeLeadStateToNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("24bf952c-9579-4dcf-981f-f2cce1dbc830", () => ChangeLeadStateToNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a", () => ChangeLeadStateToNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("091ab17a-49f8-4d9e-be81-1ca9c9dcb055", () => ChangeLeadNurturing.EntitySchemaUId);
			MetaPathParameterValues.Add("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13", () => ChangeLeadNurturing.IsMatchConditions);
			MetaPathParameterValues.Add("6f0df01f-2acd-4bc7-adec-34cfc25c9246", () => ChangeLeadNurturing.DataSourceFilters);
			MetaPathParameterValues.Add("38717ef0-c344-40ce-a5f4-e39c87df0d1d", () => ChangeLeadNurturing.RecordColumnValues);
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
			MetaPathParameterValues.Add("4589897f-ff86-44ec-9638-7b562d3ab2a8", () => ReadLeadForHandoff.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c56e2064-b9b2-4c5d-8e17-e101e465756e", () => ReadLeadForHandoff.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("cf2fd364-ebc2-4e4b-9d70-b023c6ddc868", () => ReadActivityData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("affe8596-58fc-40b3-a1ec-d76a746cdf6f", () => ReadActivityData.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("0666ed69-b39c-40e3-8809-2b5e4de75265", () => IntermediateCatchSignal1.RecordId);
			MetaPathParameterValues.Add("7c89538d-7e55-4c93-9f0f-a2c2f80b1e80", () => LinkLeadToProcess.EntityId);
			MetaPathParameterValues.Add("ba921970-53ef-41a3-b7a6-07acd54a2917", () => LinkLeadToProcess.EntitySchemaId);
			MetaPathParameterValues.Add("d4e21dc6-ae7f-4060-91b3-ce65f3742261", () => AutoGeneratedPageUserTask1.Title);
			MetaPathParameterValues.Add("fce5f296-feaa-4e40-8cbb-305fd22cb2db", () => AutoGeneratedPageUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("d9f81254-85b1-456e-a58a-ebe2fd2b8a31", () => AutoGeneratedPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("c23ba28e-759a-4f56-9c0a-fe9df5188f52", () => AutoGeneratedPageUserTask1.EntityId);
			MetaPathParameterValues.Add("dfc93d28-365e-4669-a10a-43f2f09d1c88", () => AutoGeneratedPageUserTask1.Buttons);
			MetaPathParameterValues.Add("60b03c43-255a-4016-aa32-22859aaf1ce3", () => AutoGeneratedPageUserTask1.Elements);
			MetaPathParameterValues.Add("dde310c5-648a-4f1f-967c-996a1beea049", () => AutoGeneratedPageUserTask1.ExtendedClientModule);
			MetaPathParameterValues.Add("1480eb1d-1abf-41e9-bd39-f683731420dc", () => AutoGeneratedPageUserTask1.EntryPointId);
			MetaPathParameterValues.Add("5894c4e4-ebd2-4f30-ada2-f8230d48fb62", () => AutoGeneratedPageUserTask1.PressedButtonCode);
			MetaPathParameterValues.Add("cf460504-8871-4e8e-a6e4-c3c0731e19a7", () => AutoGeneratedPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("13dca079-66e4-4df1-866b-5b3606d1a7bc", () => AutoGeneratedPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("7ca018e0-a0cc-4fd8-8bd9-e6a3fa04c96a", () => AutoGeneratedPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("1b1fb948-eb5c-47f4-b75b-8300bc40bb35", () => AutoGeneratedPageUserTask1.IsRunning);
			MetaPathParameterValues.Add("eabadc9c-efc4-4198-b542-b281f25f7287", () => AutoGeneratedPageUserTask1.PostponedDate);
			MetaPathParameterValues.Add("8a4af36b-6aa9-4659-98c1-cf050d9950f1", () => PreconfiguredPageHandoff.Title);
			MetaPathParameterValues.Add("4df2b222-660d-4648-8f5a-bffb5a3269f2", () => PreconfiguredPageHandoff.Recommendation);
			MetaPathParameterValues.Add("4497dc66-0695-4ab9-b635-67be61818e31", () => PreconfiguredPageHandoff.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("6e3df99b-ffc6-455e-997c-c60bfdf7f2eb", () => PreconfiguredPageHandoff.EntityId);
			MetaPathParameterValues.Add("e143ccc9-9b11-4f17-a1a5-7ee92fce09f2", () => PreconfiguredPageHandoff.EntryPointId);
			MetaPathParameterValues.Add("23bd5077-702b-4511-bef3-6506f8b0f77c", () => PreconfiguredPageHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("a6f285cf-7c47-44dc-ae05-9583fc425406", () => PreconfiguredPageHandoff.UseCardProcessModule);
			MetaPathParameterValues.Add("aa7fb4f0-d056-48b2-a1aa-6522326b3d80", () => PreconfiguredPageHandoff.OwnerId);
			MetaPathParameterValues.Add("2b2d50da-858e-4c72-a4c5-f150375be4f8", () => PreconfiguredPageHandoff.ShowExecutionPage);
			MetaPathParameterValues.Add("255a61e2-a759-4a62-bd5e-8ae24a559429", () => PreconfiguredPageHandoff.InformationOnStep);
			MetaPathParameterValues.Add("d2cad175-5994-4244-8d81-52e247ed7e40", () => PreconfiguredPageHandoff.IsRunning);
			MetaPathParameterValues.Add("d726baad-ac31-4b39-8193-f0fad988fd35", () => PreconfiguredPageHandoff.Template);
			MetaPathParameterValues.Add("28908944-bfb2-42d0-8082-a158159c5bb2", () => PreconfiguredPageHandoff.Module);
			MetaPathParameterValues.Add("199c0e81-ce30-4afd-8e09-b39587499e01", () => PreconfiguredPageHandoff.PressedButtonCode);
			MetaPathParameterValues.Add("2d329955-122e-4815-b929-20479271d11c", () => PreconfiguredPageHandoff.Url);
			MetaPathParameterValues.Add("cb59892e-1739-4d1c-b0d3-c9c2dc18668c", () => PreconfiguredPageHandoff.LeadId);
			MetaPathParameterValues.Add("1fb6bcd8-3144-4787-81cd-3e45b07fe3d3", () => PreconfiguredPageHandoff.LeadType);
			MetaPathParameterValues.Add("1b6450a5-61db-4ee7-a240-8cda59688639", () => PreconfiguredPageHandoff.OpportunityResponsible);
			MetaPathParameterValues.Add("e109dccc-e548-4209-9562-f5f4c1a12a20", () => PreconfiguredPageHandoff.OpportunityDepartment);
			MetaPathParameterValues.Add("4c10c0bd-466b-4d85-a804-de23f746f2e2", () => PreconfiguredPageHandoff.MeetingTime);
			MetaPathParameterValues.Add("10cfbcb1-bb50-4c35-afbd-cb10be7b07c5", () => PreconfiguredPageHandoff.DecisionDate);
			MetaPathParameterValues.Add("785320ba-9fb2-492f-8ae3-38b059e9a775", () => PreconfiguredPageHandoff.Comment);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "AutoGeneratedPageUserTask1.PostponedDate":
					AutoGeneratedPageUserTask1.PostponedDate = reader.GetValue<System.DateTime>();
				break;
				case "PreconfiguredPageHandoff.LeadId":
					PreconfiguredPageHandoff.LeadId = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.LeadType":
					PreconfiguredPageHandoff.LeadType = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.OpportunityResponsible":
					PreconfiguredPageHandoff.OpportunityResponsible = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.OpportunityDepartment":
					PreconfiguredPageHandoff.OpportunityDepartment = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.MeetingTime":
					PreconfiguredPageHandoff.MeetingTime = reader.GetValue<System.DateTime>();
				break;
				case "PreconfiguredPageHandoff.DecisionDate":
					PreconfiguredPageHandoff.DecisionDate = reader.GetValue<System.DateTime>();
				break;
				case "PreconfiguredPageHandoff.Comment":
					PreconfiguredPageHandoff.Comment = reader.GetValue<System.String>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "OpenTaskPage":
					if (!hasValueToRead) break;
					OpenTaskPage = reader.GetValue<System.Boolean>();
				break;
				case "FeedMessage":
					if (!hasValueToRead) break;
					FeedMessage = reader.GetValue<System.String>();
				break;
				case "PostponedDate":
					if (!hasValueToRead) break;
					PostponedDate = reader.GetValue<System.Int32>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localPostponedDate = (AutoGeneratedPageUserTask1.PostponedDate).Subtract(DateTime.Now).TotalMinutes + 1;
			PostponedDate = (System.Int32)localPostponedDate;
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
			var cloneItem = (LeadManagementHandoff78Finance)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

