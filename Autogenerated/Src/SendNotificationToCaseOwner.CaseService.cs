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
	using TConfiguration = Terrasoft.Configuration;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendNotificationToCaseOwnerSchema

	/// <exclude/>
	public class SendNotificationToCaseOwnerSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendNotificationToCaseOwnerSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendNotificationToCaseOwnerSchema(SendNotificationToCaseOwnerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendNotificationToCaseOwner";
			UId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
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
			RealUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateActivityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("917716bf-4d97-4095-a230-624af4a6b429"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dbd4dbea-e2f6-43a8-9366-14aac293091e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"CaseOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("63e2fd8f-d2d4-4c91-a9a3-3eea91ebb907"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"CaseId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("709f0792-1296-4595-93ee-af64360d8192"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"SubjectCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateAssigneeIsClearedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9857231e-99d6-4e24-98f0-e976db21dd58"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"AssigneeIsCleared",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#BooleanValue.False#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateActivityIdParameter());
			Parameters.Add(CreateCaseOwnerIdParameter());
			Parameters.Add(CreateCaseIdParameter());
			Parameters.Add(CreateSubjectCaptionParameter());
			Parameters.Add(CreateAssigneeIsClearedParameter());
		}

		protected virtual void InitializeReadCaseDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4506bd0f-7d6f-4191-9565-845a21c0d11d"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,149,66,231,48,160,222,162,111,133,235,22,190,52,1,98,228,82,229,64,145,75,153,168,100,9,36,149,214,53,252,239,93,74,182,235,20,46,226,246,210,232,32,81,131,225,236,236,107,23,136,134,91,251,153,183,16,204,130,21,24,195,109,167,220,237,71,221,56,48,159,76,55,244,193,77,96,193,104,222,232,31,32,39,124,33,181,251,192,29,199,43,187,242,151,66,25,204,202,203,26,101,112,83,6,218,65,107,145,131,87,10,145,200,60,75,41,73,210,92,224,43,98,164,2,33,72,150,168,48,74,101,92,100,130,78,204,63,137,207,187,182,231,6,166,24,163,188,26,143,171,109,239,169,33,2,98,164,104,219,109,14,96,236,77,216,197,134,87,13,72,252,119,102,0,132,156,209,45,102,3,43,221,194,61,55,24,203,235,116,30,66,146,226,141,245,172,6,148,91,124,239,13,88,171,187,205,107,230,154,161,221,156,179,81,0,78,191,7,59,116,244,232,153,247,220,173,71,137,37,218,218,143,46,223,215,181,129,154,59,253,124,110,226,43,108,71,222,117,245,195,11,18,187,244,200,155,1,206,98,190,204,100,206,123,55,37,52,133,71,130,209,245,250,234,92,79,21,123,45,221,8,193,254,72,190,82,243,98,14,81,134,224,179,7,38,149,227,177,12,190,44,237,221,183,13,152,7,177,134,150,79,85,123,186,69,244,55,224,164,63,219,101,49,68,74,22,138,200,72,38,36,17,44,36,156,241,152,196,0,156,133,80,85,140,230,251,167,201,135,182,125,195,183,143,167,112,115,110,225,221,161,102,254,131,16,147,57,203,41,103,132,138,48,35,9,164,57,169,152,170,136,2,69,105,42,194,84,37,5,182,216,63,190,19,93,173,5,111,238,122,48,216,233,177,210,244,242,140,190,24,110,159,191,233,58,55,101,117,170,159,183,51,122,57,78,9,205,19,38,163,12,72,42,171,220,143,74,65,42,17,73,2,33,85,180,16,140,197,149,66,51,184,224,190,196,15,221,96,196,97,161,236,180,217,255,180,177,255,97,15,255,102,181,46,14,247,53,195,250,86,198,112,249,86,38,109,31,236,127,2,187,245,87,161,63,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("125091b9-9929-4b16-b593-00f43685f38f"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5abb2c3a-53c2-45f9-a792-dc0d56899ec5"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69ff34a2-2575-4283-8a79-1849034587f1"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6bda2483-0b9a-4e13-83aa-ef65d8e5fc29"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0a9c951-282e-4b35-b2b9-586d16c25933"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("cd4e92d5-8ac6-4681-9893-10531933e9f7"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("c0f47d08-77d4-4f35-b9b8-79efd4ecc233"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3648d82-88fe-4d08-83f0-38a192059287"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("51a965b5-b922-460b-8ded-70db0b0b9559"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1a36246f-ef97-4371-8e3c-6e2fdff4875d"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e6df8d5b-cab3-4471-b93f-f16dbda2f9a4"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("23e88460-2b78-42f3-bb7d-bc523ec78b23"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("efcb90d5-185b-45d2-b46e-ebdd4f4422c5"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("78164945-a544-4c0f-a423-9e6fcc580552"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c50e486-1699-49e5-a51a-1bc6cd510ae5"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("876cd4a1-2b3c-48b1-85e5-ea04e0312504"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1dc6153c-6972-4ba3-a98b-45cc9415adf8"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ec7c15e4-15a4-4c18-96e8-9a5f1efe0ea9"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("78d57c59-616c-456c-ac2c-9cd77bdbd677"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,19,49,20,253,149,104,214,117,52,15,207,43,59,84,2,202,134,86,180,234,134,116,113,199,190,78,45,230,37,219,83,8,81,254,157,235,153,54,164,40,168,129,13,72,204,106,124,116,238,241,185,47,239,2,81,131,181,31,160,193,96,17,220,162,49,96,59,229,230,239,116,237,208,188,55,221,208,7,23,129,69,163,161,214,223,80,78,248,82,106,247,22,28,80,200,110,253,67,97,29,44,214,167,53,214,193,197,58,208,14,27,75,28,10,201,65,162,72,75,100,101,86,72,198,115,201,89,145,1,48,85,170,82,134,28,99,158,70,19,243,87,226,151,93,211,131,193,233,142,81,94,141,191,183,219,222,83,35,2,196,72,209,182,107,159,192,196,155,176,203,22,170,26,37,157,157,25,144,32,103,116,67,217,224,173,110,240,26,12,221,229,117,58,15,17,73,65,109,61,171,70,229,150,95,123,131,214,234,174,125,205,92,61,52,237,49,155,4,240,112,124,178,19,142,30,61,243,26,220,195,40,177,34,91,251,209,229,155,205,198,224,6,156,126,60,54,241,25,183,35,239,188,250,81,128,164,46,221,65,61,224,209,157,47,51,185,132,222,77,9,77,215,19,193,232,205,195,217,185,30,42,246,90,186,49,129,253,51,249,76,205,147,57,196,25,129,143,30,152,84,158,127,215,193,167,149,189,250,210,162,185,17,15,216,192,84,181,251,57,161,63,1,203,26,27,108,221,98,39,194,56,3,149,167,44,140,169,132,92,85,200,160,40,75,22,85,121,148,20,128,149,226,229,158,2,14,134,124,136,162,122,135,5,203,125,213,185,74,82,86,149,21,29,75,84,146,163,16,113,146,248,144,101,235,180,219,78,147,176,216,65,30,129,4,4,150,240,140,162,36,34,171,42,174,152,200,33,77,82,158,134,32,243,253,253,148,174,182,125,13,219,187,67,86,31,17,228,76,128,197,153,175,4,173,149,177,110,230,151,105,214,169,25,213,120,168,157,110,55,51,26,165,26,133,239,229,252,198,129,27,236,168,230,91,74,26,81,156,165,85,20,73,150,149,149,31,152,52,97,69,36,42,86,84,34,65,128,72,70,34,166,209,243,159,159,144,110,163,5,212,87,61,26,154,192,113,2,194,211,187,243,98,233,124,95,76,215,185,169,218,135,190,94,146,245,35,71,207,51,172,242,44,143,56,167,138,171,92,48,46,82,32,75,121,204,100,146,2,196,89,18,230,64,51,188,167,231,199,167,125,211,13,70,60,173,187,157,222,157,63,122,79,254,194,43,241,59,139,127,114,245,206,89,165,255,108,73,86,255,214,88,239,131,253,119,210,30,43,144,74,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86e26d5e-484f-41f0-bbab-fc34eeb9aa75"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e78616d2-d5e4-45ff-b596-cd4077bd95f6"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15712166-8aff-40a6-aa13-01c7f3e35c6d"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f55e2a6-ba23-43c6-830c-0c37149c2dfa"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("22a51850-96e2-4f1b-921c-2e8ae641277c"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bbcdf8e1-e64e-4131-8c66-a7875bc9aa86"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("7f3b2864-d5d3-405d-b781-90d93ae8c182"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3fdbb8ea-a109-436f-9526-5f4981e720df"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9b717c7a-0916-4442-a7e2-1eb5d8444932"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f94eb8f0-f6d7-4e39-bcac-5f524d486d10"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0a8a652e-132a-4a06-ba66-aaf55eb0d4ee"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("02e560cd-10d7-4e56-bd33-2638021393b9"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b6a76e86-7bda-4867-9d85-33825ffc996a"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9e70bb31-84bd-4894-9154-dc72555d80ee"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ae4b4580-882a-42d6-858b-fc7f1a5ad5ae"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41083d4f-db04-4676-8683-a5a2eb046ccf"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1a93ba6d-d6e3-4dbb-9c4a-f2503b744290"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e18ad9e1-7b63-4861-a0ab-c80d4b7ac8cf"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4de1092c-2886-4a3a-b044-6a900b08bad6"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0ba9435d-0627-444d-8a1f-ad7297863488"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("179d913f-3405-40bc-89fb-a1def3ab9a09"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,21,67,231,48,144,68,234,65,223,138,212,45,114,105,130,38,200,165,206,97,69,174,28,162,122,129,164,211,186,134,255,189,75,201,113,147,194,69,220,94,90,160,190,88,28,204,44,103,95,220,70,170,1,231,62,64,139,209,60,186,69,107,193,245,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,245,132,47,180,241,111,193,3,73,182,203,31,17,150,209,124,121,60,198,50,58,91,70,198,99,235,136,19,36,105,38,53,207,4,211,50,85,76,84,21,103,37,170,156,197,144,40,157,197,192,115,13,123,230,47,130,95,244,237,0,22,167,59,198,240,245,248,121,187,25,2,53,33,64,141,20,227,250,110,15,242,96,194,45,58,168,26,212,116,246,118,141,4,121,107,90,202,6,111,77,139,215,96,233,174,16,167,15,16,145,106,104,92,96,53,88,251,197,215,193,162,115,166,239,94,51,215,172,219,238,57,155,2,224,225,184,183,19,143,30,3,243,26,252,195,24,226,146,108,237,70,151,111,86,43,139,43,240,230,241,185,137,207,184,25,121,167,213,143,4,154,186,116,7,205,26,159,221,249,50,147,11,24,252,148,208,116,61,17,172,89,61,156,156,235,161,98,175,165,155,18,56,60,145,79,140,121,52,135,52,39,240,49,0,83,148,167,207,101,244,233,210,93,125,233,208,222,168,7,108,97,170,218,253,57,161,63,1,139,6,91,236,252,124,171,226,52,135,186,200,88,156,106,193,68,93,33,131,82,74,150,84,69,194,75,192,170,22,114,71,130,131,161,32,169,69,161,227,146,21,197,40,225,25,171,100,69,71,137,181,22,168,84,202,121,144,44,58,111,252,102,154,132,249,22,48,70,145,41,96,74,200,140,84,88,48,224,82,51,14,85,145,22,37,38,121,82,236,238,167,116,141,27,26,216,220,29,178,250,136,160,103,10,28,206,66,37,104,173,172,243,179,176,76,179,190,158,81,141,215,141,55,221,106,70,163,212,160,10,189,60,223,247,49,252,145,62,75,177,200,185,72,152,174,184,164,97,81,9,131,84,150,76,39,165,2,1,18,138,92,209,216,133,95,152,142,126,101,20,52,87,3,90,154,190,177,251,241,241,189,121,177,112,161,39,182,239,253,84,233,67,79,47,200,246,232,229,48,185,53,228,185,206,82,70,174,52,19,101,157,176,74,21,130,73,129,149,230,92,201,44,230,100,134,30,157,144,236,77,191,182,106,191,228,110,122,109,254,232,21,249,11,111,195,239,172,251,209,133,59,101,129,254,179,213,184,252,87,6,122,23,237,190,3,24,243,34,169,58,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a90561e6-7bbd-4a0f-96af-b770af8d44eb"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,83,77,79,27,49,16,253,43,200,112,140,87,246,250,59,87,168,42,164,80,69,64,185,16,14,99,123,92,162,110,178,209,126,84,162,81,254,123,157,37,1,130,10,173,212,94,42,213,7,175,236,157,247,102,60,239,205,154,156,116,15,43,36,99,114,141,77,3,109,157,186,226,180,110,176,152,54,117,192,182,45,38,117,128,106,254,29,124,133,83,104,96,129,29,54,55,80,245,216,78,230,109,55,58,58,132,145,17,57,249,54,252,37,227,219,53,57,239,112,241,249,60,102,246,210,186,82,66,82,212,178,82,83,25,189,160,32,101,162,82,249,160,140,244,81,160,207,224,80,87,253,98,121,129,29,76,161,187,39,227,53,25,216,50,1,24,14,17,16,168,144,90,102,2,68,234,125,38,8,6,148,80,82,49,136,134,108,70,164,13,247,184,128,33,233,51,152,115,19,69,153,28,181,165,81,57,167,144,212,74,206,41,15,90,115,174,2,186,16,183,224,93,252,51,240,246,120,82,215,95,251,85,225,92,18,138,113,65,181,55,64,165,137,154,122,41,25,69,145,56,48,15,206,241,80,36,166,243,51,60,210,20,67,126,164,179,101,78,35,56,141,54,36,80,101,194,24,210,241,221,54,81,156,183,171,10,30,110,222,204,119,10,45,30,181,29,116,125,91,92,98,189,194,37,198,71,232,234,64,133,151,224,245,236,81,204,25,25,207,222,146,115,247,189,26,186,116,40,232,107,45,103,100,52,35,87,117,223,132,45,163,200,135,179,23,85,15,73,134,144,87,199,189,120,249,102,217,87,213,238,230,12,58,216,7,238,175,235,56,79,115,140,231,203,171,189,102,3,11,219,45,250,147,109,191,30,107,251,19,216,5,44,225,11,54,159,114,3,158,107,127,170,242,58,183,113,79,236,75,167,152,225,137,26,4,71,37,234,172,106,228,64,29,119,62,9,147,125,149,202,1,125,137,9,27,92,6,60,44,236,119,172,179,195,183,67,183,183,83,179,171,107,219,170,13,217,108,70,47,103,137,25,103,19,147,150,26,145,68,118,115,8,20,44,104,170,149,21,40,140,54,202,198,119,103,201,48,93,178,152,123,131,50,15,148,204,175,161,46,91,54,83,153,50,133,104,163,228,254,239,207,210,199,126,30,139,15,139,85,247,240,222,4,28,70,253,55,251,63,102,118,174,61,10,173,56,181,9,75,42,185,202,62,137,145,101,131,50,17,165,182,34,70,241,43,179,223,109,126,0,81,130,55,189,150,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("dc0d8500-2c5d-44ee-8b80-5d1ee9e419af"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("582913d8-566d-458d-b331-4604de9e8c23"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				UId = new Guid("db752332-2f10-401f-9ce4-5238cd69c2e9"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,75,143,211,48,16,254,43,85,206,235,42,207,166,233,13,149,130,246,194,174,216,106,47,100,15,19,103,220,90,56,15,217,206,66,169,242,223,25,39,109,233,162,162,45,72,136,3,62,217,159,190,153,249,230,229,189,199,21,24,243,1,42,244,22,222,26,181,6,211,8,59,125,39,149,69,253,94,55,93,235,221,120,6,181,4,37,191,97,57,226,171,82,218,183,96,129,76,246,249,15,15,185,183,200,47,251,200,189,155,220,147,22,43,67,28,50,73,4,148,126,144,205,89,128,60,100,49,159,9,150,137,40,100,115,94,134,137,72,130,48,74,253,145,249,43,231,203,166,106,65,227,24,99,112,47,134,235,122,215,58,106,64,0,31,40,210,52,245,1,140,156,8,179,170,161,80,88,210,219,234,14,9,178,90,86,148,13,174,101,133,247,160,41,150,243,211,56,136,72,2,148,113,44,133,194,174,190,182,26,141,145,77,253,154,56,213,85,245,57,155,28,224,233,121,144,227,15,26,29,243,30,236,118,112,113,75,178,250,65,229,155,205,70,227,6,172,124,62,23,241,25,119,3,239,186,250,145,65,73,93,122,4,213,225,89,204,151,153,44,161,181,99,66,99,120,34,104,185,217,94,157,235,169,98,175,165,27,18,216,30,201,87,250,188,152,67,56,35,240,217,1,163,151,227,53,247,62,221,154,187,47,53,234,7,190,197,10,198,170,61,77,9,253,9,88,41,172,176,182,139,61,247,195,25,136,52,97,126,88,198,44,22,5,50,152,103,25,11,138,52,136,230,128,133,136,179,158,12,78,130,156,137,136,211,210,159,179,52,29,76,162,132,21,89,65,207,12,69,25,35,231,97,20,57,147,85,109,165,221,141,147,176,216,3,250,24,39,28,24,143,179,132,172,48,101,16,101,37,139,160,72,195,116,142,193,44,72,251,167,49,93,105,90,5,187,199,83,86,31,17,202,9,7,131,19,87,9,90,43,109,236,196,45,211,164,17,19,170,113,167,172,172,55,19,26,37,133,220,245,114,58,140,145,59,174,219,205,70,114,80,119,45,106,154,166,161,155,254,229,61,120,177,64,174,198,186,105,236,88,185,83,143,150,36,99,80,121,156,68,10,68,31,132,19,246,208,116,154,31,22,210,140,63,195,31,109,252,63,216,227,223,89,205,139,203,113,205,176,255,79,99,220,187,243,151,134,175,247,250,239,180,254,100,80,182,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc1fbcca-fa65-4c95-9a77-ce97f378b282"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,110,219,48,12,253,149,66,237,49,52,44,75,182,162,92,219,75,128,116,8,154,174,151,166,7,74,162,214,96,142,29,88,246,128,46,200,191,79,113,236,166,41,86,96,192,116,144,33,154,239,241,137,143,218,179,155,246,109,71,108,198,30,169,105,48,212,190,77,110,235,134,146,101,83,91,10,33,89,212,22,203,205,111,52,37,45,177,193,45,181,212,60,97,217,81,88,108,66,59,185,186,132,177,9,187,249,213,255,101,179,231,61,155,183,180,253,62,119,145,221,25,229,165,76,29,100,62,227,32,133,77,97,42,184,7,173,20,183,153,201,76,225,242,8,182,117,217,109,171,123,106,113,137,237,43,155,237,89,207,22,9,80,113,116,72,8,66,22,18,164,35,2,99,164,7,171,48,23,185,204,83,116,138,29,38,44,216,87,218,98,95,244,12,230,92,57,145,121,13,211,76,229,32,115,33,97,42,57,7,110,139,130,243,220,146,182,238,8,30,242,207,192,231,235,69,93,255,236,118,137,214,94,228,41,23,80,24,133,32,149,43,192,196,251,0,9,207,49,53,168,53,183,137,79,11,65,198,16,120,103,11,144,122,154,197,50,130,131,155,90,143,121,230,201,89,127,253,114,44,228,54,97,87,226,219,211,151,245,110,49,208,85,104,177,237,66,242,64,245,142,42,114,39,232,238,194,133,143,224,253,250,100,230,154,205,214,95,217,57,124,87,125,151,46,13,253,236,229,154,77,214,108,85,119,141,61,50,138,120,184,251,160,186,47,210,167,124,58,142,230,197,72,213,149,229,16,185,195,22,199,196,49,92,187,141,223,144,155,87,171,209,179,158,37,29,22,252,101,27,215,73,219,255,192,238,177,194,31,212,124,139,13,56,107,127,87,249,24,219,56,18,155,76,231,169,138,179,170,8,53,72,42,162,171,142,35,104,174,141,23,42,206,149,207,122,244,3,121,106,168,178,116,41,236,95,70,103,192,135,190,219,199,87,51,232,58,182,234,192,14,135,151,195,31,36,81,154,26,169,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
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
			ProcessSchemaUserTask readcasedata = CreateReadCaseDataUserTask();
			FlowElements.Add(readcasedata);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaScriptTask createnotificationscripttask = CreateCreateNotificationScriptTaskScriptTask();
			FlowElements.Add(createnotificationscripttask);
			ProcessSchemaScriptTask setactivityserviceprocessed = CreateSetActivityServiceProcessedScriptTask();
			FlowElements.Add(setactivityserviceprocessed);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow3ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("707dc0f7-731e-4b42-b6bc-33a3ac14d1d6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f86f691-728b-4367-98e9-372c14b8eb83"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e480bdab-02d9-43fb-9d11-3cab3de13d05"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("dea78ebe-598e-4789-8933-7e97ada40c4e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("164028a5-0e9f-43b5-b440-9f409420a265"),
				ConditionExpression = @"([#[IsOwnerSchema:false].[IsSchema:false].[Element:{9755f7a3-15ff-4623-b0f7-6bd8b05d9682}].[Parameter:{7f3b2864-d5d3-405d-b781-90d93ae8c182}].[EntityColumn:{0a97a9ee-3cf1-4e17-ae9c-b06583f4b46e}]#] || [#[IsOwnerSchema:false].[IsSchema:false].[Element:{9755f7a3-15ff-4623-b0f7-6bd8b05d9682}].[Parameter:{7f3b2864-d5d3-405d-b781-90d93ae8c182}].[EntityColumn:{98771b3f-7dbe-4b12-a017-0ab8d406a02a}]#]) &&  ([#[IsOwnerSchema:false].[IsSchema:false].[Element:{c026af75-02d4-4fbe-a899-1b7138aebf49}].[Parameter:{c0f47d08-77d4-4f35-b9b8-79efd4ecc233}].[EntityColumn:{a71adaea-3464-4dee-bb4f-c7a535450ad7}]#] != [#Lookup.99f35013-6b7a-47d6-b440-e3f1a0ba991c.f063ebbe-fdc6-4982-8431-d8cfa52fedcf#])",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("e5b968fe-a1e2-4553-9f9e-2365429b0f48"),
				ConditionExpression = @"([#[IsOwnerSchema:false].[IsSchema:false].[Element:{c026af75-02d4-4fbe-a899-1b7138aebf49}].[Parameter:{c0f47d08-77d4-4f35-b9b8-79efd4ecc233}].[EntityColumn:{70620d00-e4ea-48d1-9fdc-4572fcd8d41b}]#] == Guid.Empty) || ([#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9857231e-99d6-4e24-98f0-e976db21dd58}]#]==true)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(687, 84));
			schemaFlow.PolylinePointPositions.Add(new Point(862, 84));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("293d8afc-a4e7-4800-987c-5de2164824aa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("a35125c1-02b5-47c1-926b-95f966f6b9ce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("efc90b80-b772-4205-bf51-315a08b3047a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow3",
				UId = new Guid("1e21d9c0-b54f-47a0-8af2-5c4ae0fa2720"),
				ConditionExpression = @"[#SysSettings.ClearAssigneeOnCaseReopening<Boolean>#]==true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(274, 452));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("8824362b-6385-4a61-a315-c46db2761d09"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("df870c75-8a1b-4baa-8304-cfb719f11ef8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(576, 332));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("a301fe1f-8a8c-4bb6-9d8c-06bf6dc5581d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(576, 452));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("6a9d764d-7daf-46c9-88d3-78c3efb8d84f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("4149de33-d5f1-4f2f-8636-d849aa44aaaf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("db31b497-0277-4fd6-9e5b-27bc8d92092d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db31b497-0277-4fd6-9e5b-27bc8d92092d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("0f86f691-728b-4367-98e9-372c14b8eb83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"Terminate1",
				Position = new Point(849, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadCaseDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ReadCaseData",
				Position = new Point(140, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadCaseDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ReadDataUserTask2",
				Position = new Point(240, 170),
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
				UId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ExclusiveGateway1",
				Position = new Point(660, 170),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(460, 425),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateNotificationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"CreateNotificationScriptTask",
				Position = new Point(751, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,85,75,143,218,48,16,62,131,196,127,112,115,74,36,100,245,210,75,183,187,21,4,118,203,97,217,138,71,239,222,100,32,174,18,27,249,193,42,90,241,223,59,182,3,132,85,183,164,123,64,138,61,243,125,158,249,230,193,84,24,110,106,162,160,226,34,231,98,59,13,231,91,178,214,160,82,41,4,100,134,75,65,195,253,50,43,160,98,143,76,176,45,40,250,0,102,38,180,97,34,131,113,61,103,21,196,209,226,200,19,37,131,126,143,166,10,152,129,128,141,47,25,147,155,65,127,207,20,201,152,134,89,142,15,46,128,229,41,30,38,204,48,186,0,109,75,19,128,244,167,226,21,83,117,42,75,91,137,95,172,180,112,67,2,88,190,8,80,87,208,24,229,170,222,65,222,130,127,123,176,60,191,139,163,167,0,143,142,177,8,91,61,131,250,111,54,109,20,102,140,124,115,143,63,209,101,18,165,112,185,34,163,128,23,50,225,62,115,76,165,129,12,137,124,254,141,114,220,145,87,84,203,253,122,209,200,154,66,170,104,248,182,0,169,85,10,132,113,183,20,175,13,203,204,44,71,196,97,232,193,189,168,185,68,100,163,74,219,184,148,86,101,128,182,21,186,109,248,214,42,230,89,79,245,194,107,109,244,249,28,0,33,152,75,170,38,201,97,163,86,219,52,194,80,247,168,18,74,58,36,231,131,115,25,244,15,141,42,152,122,163,199,210,139,48,182,188,204,65,197,78,181,141,196,134,201,10,18,7,93,200,222,233,75,184,56,75,73,189,228,58,241,47,34,21,29,237,118,32,242,216,123,58,138,67,120,165,96,186,192,103,238,121,9,107,195,75,196,130,118,197,123,156,124,249,129,166,120,42,50,233,242,164,107,193,241,11,156,109,92,27,208,177,35,93,201,16,91,156,36,142,243,205,116,208,37,152,9,108,90,45,160,227,119,220,90,62,113,83,90,47,78,151,226,118,161,60,57,159,203,222,5,22,170,235,81,31,107,136,46,143,4,232,138,87,240,239,132,81,249,230,136,227,6,206,31,101,63,54,139,245,141,144,178,93,51,71,97,112,232,189,84,21,51,241,167,230,56,211,115,91,150,79,106,90,237,112,209,44,47,64,237,98,186,46,253,78,222,181,227,86,233,245,190,146,104,142,205,137,123,142,151,184,23,51,224,123,200,241,99,203,148,75,150,152,2,252,210,34,115,73,95,63,31,48,55,135,58,13,67,226,118,211,85,253,47,34,64,138,203,60,219,187,49,172,220,15,47,228,20,41,252,66,186,26,82,173,219,148,190,55,206,239,211,117,199,198,10,121,156,208,221,80,110,34,17,224,102,246,175,238,108,143,45,225,13,198,42,65,140,194,127,128,63,42,221,156,166,185,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetActivityServiceProcessedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"SetActivityServiceProcessed",
				Position = new Point(653, 365),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,142,177,10,194,48,20,69,103,251,21,143,76,9,148,252,64,113,144,210,161,155,80,138,243,35,185,98,161,77,245,37,169,250,247,86,172,131,56,94,56,151,115,22,22,98,151,134,101,72,207,254,234,57,129,246,20,112,167,207,208,125,132,212,115,8,88,153,57,148,164,14,27,172,76,177,179,29,146,86,29,100,25,28,142,50,59,196,8,175,74,170,231,49,79,193,30,89,120,66,130,232,51,143,17,230,125,57,93,32,208,170,245,202,216,54,54,183,204,163,254,195,191,146,214,27,67,28,183,152,170,248,45,181,205,3,46,175,145,166,42,4,41,75,160,36,25,213,11,109,242,86,202,212,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ExclusiveGateway2",
				Position = new Point(247, 305),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ChangeDataUserTask2",
				Position = new Point(391, 305),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"FormulaTask1",
				Position = new Point(340, 425),
				ResultParameterMetaPath = @"9857231e-99d6-4e24-98f0-e976db21dd58",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ExclusiveGateway3",
				Position = new Point(549, 365),
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
				UId = new Guid("a62d71a9-1414-4f68-86ab-baff31296a19"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f119a82c-706c-4b56-bf2d-bb763a00c4e7"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c0c3676-9acd-4b48-a524-ac71ec25ed67"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2ec255eb-3b3c-4d0a-a3e1-616e3f38ecdf"),
				Name = "Terrasoft.Configuration",
				Alias = "TConfiguration",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendNotificationToCaseOwner(userConnection);
		}

		public override object Clone() {
			return new SendNotificationToCaseOwnerSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"));
		}

		#endregion

	}

	#endregion

	#region Class: SendNotificationToCaseOwner

	/// <exclude/>
	public class SendNotificationToCaseOwner : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadCaseDataFlowElement

		/// <exclude/>
		public class ReadCaseDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCaseDataFlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCaseData";
				IsLogging = true;
				SchemaElementUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,149,66,231,48,160,222,162,111,133,235,22,190,52,1,98,228,82,229,64,145,75,153,168,100,9,36,149,214,53,252,239,93,74,182,235,20,46,226,246,210,232,32,81,131,225,236,236,107,23,136,134,91,251,153,183,16,204,130,21,24,195,109,167,220,237,71,221,56,48,159,76,55,244,193,77,96,193,104,222,232,31,32,39,124,33,181,251,192,29,199,43,187,242,151,66,25,204,202,203,26,101,112,83,6,218,65,107,145,131,87,10,145,200,60,75,41,73,210,92,224,43,98,164,2,33,72,150,168,48,74,101,92,100,130,78,204,63,137,207,187,182,231,6,166,24,163,188,26,143,171,109,239,169,33,2,98,164,104,219,109,14,96,236,77,216,197,134,87,13,72,252,119,102,0,132,156,209,45,102,3,43,221,194,61,55,24,203,235,116,30,66,146,226,141,245,172,6,148,91,124,239,13,88,171,187,205,107,230,154,161,221,156,179,81,0,78,191,7,59,116,244,232,153,247,220,173,71,137,37,218,218,143,46,223,215,181,129,154,59,253,124,110,226,43,108,71,222,117,245,195,11,18,187,244,200,155,1,206,98,190,204,100,206,123,55,37,52,133,71,130,209,245,250,234,92,79,21,123,45,221,8,193,254,72,190,82,243,98,14,81,134,224,179,7,38,149,227,177,12,190,44,237,221,183,13,152,7,177,134,150,79,85,123,186,69,244,55,224,164,63,219,101,49,68,74,22,138,200,72,38,36,17,44,36,156,241,152,196,0,156,133,80,85,140,230,251,167,201,135,182,125,195,183,143,167,112,115,110,225,221,161,102,254,131,16,147,57,203,41,103,132,138,48,35,9,164,57,169,152,170,136,2,69,105,42,194,84,37,5,182,216,63,190,19,93,173,5,111,238,122,48,216,233,177,210,244,242,140,190,24,110,159,191,233,58,55,101,117,170,159,183,51,122,57,78,9,205,19,38,163,12,72,42,171,220,143,74,65,42,17,73,2,33,85,180,16,140,197,149,66,51,184,224,190,196,15,221,96,196,97,161,236,180,217,255,180,177,255,97,15,255,102,181,46,14,247,53,195,250,86,198,112,249,86,38,109,31,236,127,2,187,245,87,161,63,6,0,0 })));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,19,49,20,253,149,104,214,117,52,15,207,43,59,84,2,202,134,86,180,234,134,116,113,199,190,78,45,230,37,219,83,8,81,254,157,235,153,54,164,40,168,129,13,72,204,106,124,116,238,241,185,47,239,2,81,131,181,31,160,193,96,17,220,162,49,96,59,229,230,239,116,237,208,188,55,221,208,7,23,129,69,163,161,214,223,80,78,248,82,106,247,22,28,80,200,110,253,67,97,29,44,214,167,53,214,193,197,58,208,14,27,75,28,10,201,65,162,72,75,100,101,86,72,198,115,201,89,145,1,48,85,170,82,134,28,99,158,70,19,243,87,226,151,93,211,131,193,233,142,81,94,141,191,183,219,222,83,35,2,196,72,209,182,107,159,192,196,155,176,203,22,170,26,37,157,157,25,144,32,103,116,67,217,224,173,110,240,26,12,221,229,117,58,15,17,73,65,109,61,171,70,229,150,95,123,131,214,234,174,125,205,92,61,52,237,49,155,4,240,112,124,178,19,142,30,61,243,26,220,195,40,177,34,91,251,209,229,155,205,198,224,6,156,126,60,54,241,25,183,35,239,188,250,81,128,164,46,221,65,61,224,209,157,47,51,185,132,222,77,9,77,215,19,193,232,205,195,217,185,30,42,246,90,186,49,129,253,51,249,76,205,147,57,196,25,129,143,30,152,84,158,127,215,193,167,149,189,250,210,162,185,17,15,216,192,84,181,251,57,161,63,1,203,26,27,108,221,98,39,194,56,3,149,167,44,140,169,132,92,85,200,160,40,75,22,85,121,148,20,128,149,226,229,158,2,14,134,124,136,162,122,135,5,203,125,213,185,74,82,86,149,21,29,75,84,146,163,16,113,146,248,144,101,235,180,219,78,147,176,216,65,30,129,4,4,150,240,140,162,36,34,171,42,174,152,200,33,77,82,158,134,32,243,253,253,148,174,182,125,13,219,187,67,86,31,17,228,76,128,197,153,175,4,173,149,177,110,230,151,105,214,169,25,213,120,168,157,110,55,51,26,165,26,133,239,229,252,198,129,27,236,168,230,91,74,26,81,156,165,85,20,73,150,149,149,31,152,52,97,69,36,42,86,84,34,65,128,72,70,34,166,209,243,159,159,144,110,163,5,212,87,61,26,154,192,113,2,194,211,187,243,98,233,124,95,76,215,185,169,218,135,190,94,146,245,35,71,207,51,172,242,44,143,56,167,138,171,92,48,46,82,32,75,121,204,100,146,2,196,89,18,230,64,51,188,167,231,199,167,125,211,13,70,60,173,187,157,222,157,63,122,79,254,194,43,241,59,139,127,114,245,206,89,165,255,108,73,86,255,214,88,239,131,253,119,210,30,43,144,74,7,0,0 })));
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("f063ebbe-fdc6-4982-8431-d8cfa52fedcf"));
				_recordColumnValues_Owner = () => (Guid)(Guid.Empty);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;
			internal Func<Guid> _recordColumnValues_Owner;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,21,67,231,48,144,68,234,65,223,138,212,45,114,105,130,38,200,165,206,97,69,174,28,162,122,129,164,211,186,134,255,189,75,201,113,147,194,69,220,94,90,160,190,88,28,204,44,103,95,220,70,170,1,231,62,64,139,209,60,186,69,107,193,245,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,245,132,47,180,241,111,193,3,73,182,203,31,17,150,209,124,121,60,198,50,58,91,70,198,99,235,136,19,36,105,38,53,207,4,211,50,85,76,84,21,103,37,170,156,197,144,40,157,197,192,115,13,123,230,47,130,95,244,237,0,22,167,59,198,240,245,248,121,187,25,2,53,33,64,141,20,227,250,110,15,242,96,194,45,58,168,26,212,116,246,118,141,4,121,107,90,202,6,111,77,139,215,96,233,174,16,167,15,16,145,106,104,92,96,53,88,251,197,215,193,162,115,166,239,94,51,215,172,219,238,57,155,2,224,225,184,183,19,143,30,3,243,26,252,195,24,226,146,108,237,70,151,111,86,43,139,43,240,230,241,185,137,207,184,25,121,167,213,143,4,154,186,116,7,205,26,159,221,249,50,147,11,24,252,148,208,116,61,17,172,89,61,156,156,235,161,98,175,165,155,18,56,60,145,79,140,121,52,135,52,39,240,49,0,83,148,167,207,101,244,233,210,93,125,233,208,222,168,7,108,97,170,218,253,57,161,63,1,139,6,91,236,252,124,171,226,52,135,186,200,88,156,106,193,68,93,33,131,82,74,150,84,69,194,75,192,170,22,114,71,130,131,161,32,169,69,161,227,146,21,197,40,225,25,171,100,69,71,137,181,22,168,84,202,121,144,44,58,111,252,102,154,132,249,22,48,70,145,41,96,74,200,140,84,88,48,224,82,51,14,85,145,22,37,38,121,82,236,238,167,116,141,27,26,216,220,29,178,250,136,160,103,10,28,206,66,37,104,173,172,243,179,176,76,179,190,158,81,141,215,141,55,221,106,70,163,212,160,10,189,60,223,247,49,252,145,62,75,177,200,185,72,152,174,184,164,97,81,9,131,84,150,76,39,165,2,1,18,138,92,209,216,133,95,152,142,126,101,20,52,87,3,90,154,190,177,251,241,241,189,121,177,112,161,39,182,239,253,84,233,67,79,47,200,246,232,229,48,185,53,228,185,206,82,70,174,52,19,101,157,176,74,21,130,73,129,149,230,92,201,44,230,100,134,30,157,144,236,77,191,182,106,191,228,110,122,109,254,232,21,249,11,111,195,239,172,251,209,133,59,101,129,254,179,213,184,252,87,6,122,23,237,190,3,24,243,34,169,58,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,83,77,79,27,49,16,253,43,200,112,140,87,246,250,59,87,168,42,164,80,69,64,185,16,14,99,123,92,162,110,178,209,126,84,162,81,254,123,157,37,1,130,10,173,212,94,42,213,7,175,236,157,247,102,60,239,205,154,156,116,15,43,36,99,114,141,77,3,109,157,186,226,180,110,176,152,54,117,192,182,45,38,117,128,106,254,29,124,133,83,104,96,129,29,54,55,80,245,216,78,230,109,55,58,58,132,145,17,57,249,54,252,37,227,219,53,57,239,112,241,249,60,102,246,210,186,82,66,82,212,178,82,83,25,189,160,32,101,162,82,249,160,140,244,81,160,207,224,80,87,253,98,121,129,29,76,161,187,39,227,53,25,216,50,1,24,14,17,16,168,144,90,102,2,68,234,125,38,8,6,148,80,82,49,136,134,108,70,164,13,247,184,128,33,233,51,152,115,19,69,153,28,181,165,81,57,167,144,212,74,206,41,15,90,115,174,2,186,16,183,224,93,252,51,240,246,120,82,215,95,251,85,225,92,18,138,113,65,181,55,64,165,137,154,122,41,25,69,145,56,48,15,206,241,80,36,166,243,51,60,210,20,67,126,164,179,101,78,35,56,141,54,36,80,101,194,24,210,241,221,54,81,156,183,171,10,30,110,222,204,119,10,45,30,181,29,116,125,91,92,98,189,194,37,198,71,232,234,64,133,151,224,245,236,81,204,25,25,207,222,146,115,247,189,26,186,116,40,232,107,45,103,100,52,35,87,117,223,132,45,163,200,135,179,23,85,15,73,134,144,87,199,189,120,249,102,217,87,213,238,230,12,58,216,7,238,175,235,56,79,115,140,231,203,171,189,102,3,11,219,45,250,147,109,191,30,107,251,19,216,5,44,225,11,54,159,114,3,158,107,127,170,242,58,183,113,79,236,75,167,152,225,137,26,4,71,37,234,172,106,228,64,29,119,62,9,147,125,149,202,1,125,137,9,27,92,6,60,44,236,119,172,179,195,183,67,183,183,83,179,171,107,219,170,13,217,108,70,47,103,137,25,103,19,147,150,26,145,68,118,115,8,20,44,104,170,149,21,40,140,54,202,198,119,103,201,48,93,178,152,123,131,50,15,148,204,175,161,46,91,54,83,153,50,133,104,163,228,254,239,207,210,199,126,30,139,15,139,85,247,240,222,4,28,70,253,55,251,63,102,118,174,61,10,173,56,181,9,75,42,185,202,62,137,145,101,131,50,17,165,182,34,70,241,43,179,223,109,126,0,81,130,55,189,150,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "53d09a3b5a4248cdbd0cf36c9a389625",
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

		#region Class: ChangeDataUserTask2FlowElement

		/// <exclude/>
		public class ChangeDataUserTask2FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("f063ebbe-fdc6-4982-8431-d8cfa52fedcf"));
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

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,75,143,211,48,16,254,43,85,206,235,42,207,166,233,13,149,130,246,194,174,216,106,47,100,15,19,103,220,90,56,15,217,206,66,169,242,223,25,39,109,233,162,162,45,72,136,3,62,217,159,190,153,249,230,229,189,199,21,24,243,1,42,244,22,222,26,181,6,211,8,59,125,39,149,69,253,94,55,93,235,221,120,6,181,4,37,191,97,57,226,171,82,218,183,96,129,76,246,249,15,15,185,183,200,47,251,200,189,155,220,147,22,43,67,28,50,73,4,148,126,144,205,89,128,60,100,49,159,9,150,137,40,100,115,94,134,137,72,130,48,74,253,145,249,43,231,203,166,106,65,227,24,99,112,47,134,235,122,215,58,106,64,0,31,40,210,52,245,1,140,156,8,179,170,161,80,88,210,219,234,14,9,178,90,86,148,13,174,101,133,247,160,41,150,243,211,56,136,72,2,148,113,44,133,194,174,190,182,26,141,145,77,253,154,56,213,85,245,57,155,28,224,233,121,144,227,15,26,29,243,30,236,118,112,113,75,178,250,65,229,155,205,70,227,6,172,124,62,23,241,25,119,3,239,186,250,145,65,73,93,122,4,213,225,89,204,151,153,44,161,181,99,66,99,120,34,104,185,217,94,157,235,169,98,175,165,27,18,216,30,201,87,250,188,152,67,56,35,240,217,1,163,151,227,53,247,62,221,154,187,47,53,234,7,190,197,10,198,170,61,77,9,253,9,88,41,172,176,182,139,61,247,195,25,136,52,97,126,88,198,44,22,5,50,152,103,25,11,138,52,136,230,128,133,136,179,158,12,78,130,156,137,136,211,210,159,179,52,29,76,162,132,21,89,65,207,12,69,25,35,231,97,20,57,147,85,109,165,221,141,147,176,216,3,250,24,39,28,24,143,179,132,172,48,101,16,101,37,139,160,72,195,116,142,193,44,72,251,167,49,93,105,90,5,187,199,83,86,31,17,202,9,7,131,19,87,9,90,43,109,236,196,45,211,164,17,19,170,113,167,172,172,55,19,26,37,133,220,245,114,58,140,145,59,174,219,205,70,114,80,119,45,106,154,166,161,155,254,229,61,120,177,64,174,198,186,105,236,88,185,83,143,150,36,99,80,121,156,68,10,68,31,132,19,246,208,116,154,31,22,210,140,63,195,31,109,252,63,216,227,223,89,205,139,203,113,205,176,255,79,99,220,187,243,151,134,175,247,250,239,180,254,100,80,182,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,110,219,48,12,253,149,66,237,49,52,44,75,182,162,92,219,75,128,116,8,154,174,151,166,7,74,162,214,96,142,29,88,246,128,46,200,191,79,113,236,166,41,86,96,192,116,144,33,154,239,241,137,143,218,179,155,246,109,71,108,198,30,169,105,48,212,190,77,110,235,134,146,101,83,91,10,33,89,212,22,203,205,111,52,37,45,177,193,45,181,212,60,97,217,81,88,108,66,59,185,186,132,177,9,187,249,213,255,101,179,231,61,155,183,180,253,62,119,145,221,25,229,165,76,29,100,62,227,32,133,77,97,42,184,7,173,20,183,153,201,76,225,242,8,182,117,217,109,171,123,106,113,137,237,43,155,237,89,207,22,9,80,113,116,72,8,66,22,18,164,35,2,99,164,7,171,48,23,185,204,83,116,138,29,38,44,216,87,218,98,95,244,12,230,92,57,145,121,13,211,76,229,32,115,33,97,42,57,7,110,139,130,243,220,146,182,238,8,30,242,207,192,231,235,69,93,255,236,118,137,214,94,228,41,23,80,24,133,32,149,43,192,196,251,0,9,207,49,53,168,53,183,137,79,11,65,198,16,120,103,11,144,122,154,197,50,130,131,155,90,143,121,230,201,89,127,253,114,44,228,54,97,87,226,219,211,151,245,110,49,208,85,104,177,237,66,242,64,245,142,42,114,39,232,238,194,133,143,224,253,250,100,230,154,205,214,95,217,57,124,87,125,151,46,13,253,236,229,154,77,214,108,85,119,141,61,50,138,120,184,251,160,186,47,210,167,124,58,142,230,197,72,213,149,229,16,185,195,22,199,196,49,92,187,141,223,144,155,87,171,209,179,158,37,29,22,252,101,27,215,73,219,255,192,238,177,194,31,212,124,139,13,56,107,127,87,249,24,219,56,18,155,76,231,169,138,179,170,8,53,72,42,162,171,142,35,104,174,141,23,42,206,149,207,122,244,3,121,106,168,178,116,41,236,95,70,103,192,135,190,219,199,87,51,232,58,182,234,192,14,135,151,195,31,36,81,154,26,169,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "53d09a3b5a4248cdbd0cf36c9a389625",
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

		public SendNotificationToCaseOwner(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendNotificationToCaseOwner";
			SchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_assigneeIsCleared = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendNotificationToCaseOwner, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendNotificationToCaseOwner, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid ActivityId {
			get;
			set;
		}

		public virtual Guid CaseOwnerId {
			get;
			set;
		}

		public virtual Guid CaseId {
			get;
			set;
		}

		private LocalizableString _subjectCaption;
		public virtual LocalizableString SubjectCaption {
			get {
				return _subjectCaption ?? (_subjectCaption = GetLocalizableString("53d09a3b5a4248cdbd0cf36c9a389625",
						 "Parameters.SubjectCaption.Value"));
			}
			set {
				_subjectCaption = value;
			}
		}

		private Func<bool> _assigneeIsCleared;
		public virtual bool AssigneeIsCleared {
			get {
				return (_assigneeIsCleared ?? (_assigneeIsCleared = () => false)).Invoke();
			}
			set {
				_assigneeIsCleared = () => { return value; };
			}
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
					SchemaElementUId = new Guid("0f86f691-728b-4367-98e9-372c14b8eb83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ReadCaseDataFlowElement _readCaseData;
		public ReadCaseDataFlowElement ReadCaseData {
			get {
				return _readCaseData ?? (_readCaseData = new ReadCaseDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
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

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _createNotificationScriptTask;
		public ProcessScriptTask CreateNotificationScriptTask {
			get {
				return _createNotificationScriptTask ?? (_createNotificationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateNotificationScriptTask",
					SchemaElementUId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CreateNotificationScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _setActivityServiceProcessed;
		public ProcessScriptTask SetActivityServiceProcessed {
			get {
				return _setActivityServiceProcessed ?? (_setActivityServiceProcessed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetActivityServiceProcessed",
					SchemaElementUId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SetActivityServiceProcessedExecute,
				});
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
					SchemaElementUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
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

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
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
					SchemaElementUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
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

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("164028a5-0e9f-43b5-b440-9f409420a265"),
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
					SchemaElementUId = new Guid("e5b968fe-a1e2-4553-9f9e-2365429b0f48"),
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
					SchemaElementUId = new Guid("1e21d9c0-b54f-47a0-8af2-5c4ae0fa2720"),
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
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ReadCaseData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCaseData };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[CreateNotificationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateNotificationScriptTask };
			FlowElements[SetActivityServiceProcessed.SchemaElementUId] = new Collection<ProcessFlowElement> { SetActivityServiceProcessed };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseData", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadCaseData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateNotificationScriptTask", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "CreateNotificationScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "SetActivityServiceProcessed":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
						break;
					case "ChangeDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetActivityServiceProcessed", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("IsPaused").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>("IsPaused") : false)) || ((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("IsResolved").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>("IsResolved") : false))) &&  (((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName("Status").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("StatusId") : Guid.Empty)) != new Guid("f063ebbe-fdc6-4982-8431-d8cfa52fedcf")));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask2", "ConditionalSequenceFlow1", "(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"IsPaused\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>(\"IsPaused\") : false)) || ((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"IsResolved\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>(\"IsResolved\") : false))) &&  (((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName(\"Status\").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>(\"StatusId\") : Guid.Empty)) != new Guid(\"f063ebbe-fdc6-4982-8431-d8cfa52fedcf\"))", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)) == Guid.Empty) || ((AssigneeIsCleared)==true));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow2", "(((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName(\"Owner\").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>(\"OwnerId\") : Guid.Empty)) == Guid.Empty) || ((AssigneeIsCleared)==true)", result);
			return result;
		}

		private bool ConditionalSequenceFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean(((Boolean)SysSettings.GetValue(UserConnection, "ClearAssigneeOnCaseReopening"))==true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow3", "((Boolean)SysSettings.GetValue(UserConnection, \"ClearAssigneeOnCaseReopening\"))==true", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ActivityId")) {
				writer.WriteValue("ActivityId", ActivityId, Guid.Empty);
			}
			if (!HasMapping("CaseOwnerId")) {
				writer.WriteValue("CaseOwnerId", CaseOwnerId, Guid.Empty);
			}
			if (!HasMapping("CaseId")) {
				writer.WriteValue("CaseId", CaseId, Guid.Empty);
			}
			if (!HasMapping("AssigneeIsCleared")) {
				writer.WriteValue("AssigneeIsCleared", AssigneeIsCleared, false);
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
			MetaPathParameterValues.Add("917716bf-4d97-4095-a230-624af4a6b429", () => ActivityId);
			MetaPathParameterValues.Add("dbd4dbea-e2f6-43a8-9366-14aac293091e", () => CaseOwnerId);
			MetaPathParameterValues.Add("63e2fd8f-d2d4-4c91-a9a3-3eea91ebb907", () => CaseId);
			MetaPathParameterValues.Add("709f0792-1296-4595-93ee-af64360d8192", () => SubjectCaption);
			MetaPathParameterValues.Add("9857231e-99d6-4e24-98f0-e976db21dd58", () => AssigneeIsCleared);
			MetaPathParameterValues.Add("4506bd0f-7d6f-4191-9565-845a21c0d11d", () => ReadCaseData.DataSourceFilters);
			MetaPathParameterValues.Add("125091b9-9929-4b16-b593-00f43685f38f", () => ReadCaseData.ResultType);
			MetaPathParameterValues.Add("5abb2c3a-53c2-45f9-a792-dc0d56899ec5", () => ReadCaseData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("69ff34a2-2575-4283-8a79-1849034587f1", () => ReadCaseData.NumberOfRecords);
			MetaPathParameterValues.Add("6bda2483-0b9a-4e13-83aa-ef65d8e5fc29", () => ReadCaseData.FunctionType);
			MetaPathParameterValues.Add("d0a9c951-282e-4b35-b2b9-586d16c25933", () => ReadCaseData.AggregationColumnName);
			MetaPathParameterValues.Add("cd4e92d5-8ac6-4681-9893-10531933e9f7", () => ReadCaseData.OrderInfo);
			MetaPathParameterValues.Add("c0f47d08-77d4-4f35-b9b8-79efd4ecc233", () => ReadCaseData.ResultEntity);
			MetaPathParameterValues.Add("e3648d82-88fe-4d08-83f0-38a192059287", () => ReadCaseData.ResultCount);
			MetaPathParameterValues.Add("51a965b5-b922-460b-8ded-70db0b0b9559", () => ReadCaseData.ResultIntegerFunction);
			MetaPathParameterValues.Add("1a36246f-ef97-4371-8e3c-6e2fdff4875d", () => ReadCaseData.ResultFloatFunction);
			MetaPathParameterValues.Add("e6df8d5b-cab3-4471-b93f-f16dbda2f9a4", () => ReadCaseData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("23e88460-2b78-42f3-bb7d-bc523ec78b23", () => ReadCaseData.ResultRowsCount);
			MetaPathParameterValues.Add("efcb90d5-185b-45d2-b46e-ebdd4f4422c5", () => ReadCaseData.CanReadUncommitedData);
			MetaPathParameterValues.Add("78164945-a544-4c0f-a423-9e6fcc580552", () => ReadCaseData.ResultEntityCollection);
			MetaPathParameterValues.Add("3c50e486-1699-49e5-a51a-1bc6cd510ae5", () => ReadCaseData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("876cd4a1-2b3c-48b1-85e5-ea04e0312504", () => ReadCaseData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("1dc6153c-6972-4ba3-a98b-45cc9415adf8", () => ReadCaseData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("ec7c15e4-15a4-4c18-96e8-9a5f1efe0ea9", () => ReadCaseData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("78d57c59-616c-456c-ac2c-9cd77bdbd677", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("86e26d5e-484f-41f0-bbab-fc34eeb9aa75", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("e78616d2-d5e4-45ff-b596-cd4077bd95f6", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("15712166-8aff-40a6-aa13-01c7f3e35c6d", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("4f55e2a6-ba23-43c6-830c-0c37149c2dfa", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("22a51850-96e2-4f1b-921c-2e8ae641277c", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("bbcdf8e1-e64e-4131-8c66-a7875bc9aa86", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("7f3b2864-d5d3-405d-b781-90d93ae8c182", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("3fdbb8ea-a109-436f-9526-5f4981e720df", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("9b717c7a-0916-4442-a7e2-1eb5d8444932", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("f94eb8f0-f6d7-4e39-bcac-5f524d486d10", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("0a8a652e-132a-4a06-ba66-aaf55eb0d4ee", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("02e560cd-10d7-4e56-bd33-2638021393b9", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("b6a76e86-7bda-4867-9d85-33825ffc996a", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("9e70bb31-84bd-4894-9154-dc72555d80ee", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("ae4b4580-882a-42d6-858b-fc7f1a5ad5ae", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("41083d4f-db04-4676-8683-a5a2eb046ccf", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("1a93ba6d-d6e3-4dbb-9c4a-f2503b744290", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("e18ad9e1-7b63-4861-a0ab-c80d4b7ac8cf", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("4de1092c-2886-4a3a-b044-6a900b08bad6", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("0ba9435d-0627-444d-8a1f-ad7297863488", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("179d913f-3405-40bc-89fb-a1def3ab9a09", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("a90561e6-7bbd-4a0f-96af-b770af8d44eb", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("dc0d8500-2c5d-44ee-8b80-5d1ee9e419af", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("582913d8-566d-458d-b331-4604de9e8c23", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("db752332-2f10-401f-9ce4-5238cd69c2e9", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("bc1fbcca-fa65-4c95-9a77-ce97f378b282", () => ChangeDataUserTask2.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ActivityId":
					if (!hasValueToRead) break;
					ActivityId = reader.GetValue<System.Guid>();
				break;
				case "CaseOwnerId":
					if (!hasValueToRead) break;
					CaseOwnerId = reader.GetValue<System.Guid>();
				break;
				case "CaseId":
					if (!hasValueToRead) break;
					CaseId = reader.GetValue<System.Guid>();
				break;
				case "AssigneeIsCleared":
					if (!hasValueToRead) break;
					AssigneeIsCleared = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool CreateNotificationScriptTaskExecute(ProcessExecutingContext context) {
			Entity remindingEntity = UserConnection.EntitySchemaManager.GetInstanceByName("Reminding")
				.CreateEntity(UserConnection);
			var caseId = ReadCaseData.ResultEntity.PrimaryColumnValue; 
			var ownerId = ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId");
			var number = ReadCaseData.ResultEntity.GetTypedColumnValue<string>("Number");
			var condition = new Dictionary<string, object> {
				{
					"Author", UserConnection.CurrentUser.ContactId
				}, {
					"Contact", ownerId
				}, {
					"Source", TConfiguration.RemindingConsts.RemindingSourceAuthorId
				}, {
					"Number", number
				}, {
					"ActivityId", ActivityId
				}
			};
			var str = new StringBuilder();
			foreach (object value in condition.Values) {
				str.Append(value);
			}
			var hash = FileUtilities.GetMD5Hash(Encoding.Unicode.GetBytes(str.ToString()));
			remindingEntity.SetDefColumnValues();
			remindingEntity.SetColumnValue("AuthorId", UserConnection.CurrentUser.ContactId);
			remindingEntity.SetColumnValue("ContactId", ownerId);
			remindingEntity.SetColumnValue("SourceId", TConfiguration.RemindingConsts.RemindingSourceAuthorId);
			remindingEntity.SetColumnValue("RemindTime", UserConnection.CurrentUser.GetCurrentDateTime());
			var subjectCaption = string.Format(!string.IsNullOrEmpty(SubjectCaption.ToString())
					? SubjectCaption.ToString() 
					: "New email received regarding the case No.{0}", 
					number
				); 
			remindingEntity.SetColumnValue("SubjectCaption", subjectCaption);
			var caseSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Case");
			remindingEntity.SetColumnValue("SysEntitySchemaId", caseSchema.UId);
			remindingEntity.SetColumnValue("SubjectId", caseId);
			remindingEntity.SetColumnValue("Hash", hash);
			remindingEntity.Save();
			return true;
		}

		public virtual bool SetActivityServiceProcessedExecute(ProcessExecutingContext context) {
			var activityUpdate = new Update(UserConnection, "Activity")
				.Set("ServiceProcessed", Column.Parameter(false))
				.Where("Id").IsEqual(Column.Parameter(ActivityId)) as Update;
			activityUpdate.Execute();
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localAssigneeIsCleared = true;
			AssigneeIsCleared = (System.Boolean)localAssigneeIsCleared;
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
			var cloneItem = (SendNotificationToCaseOwner)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

