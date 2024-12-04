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
	using Terrasoft.Mail;
	using Terrasoft.Mail.Sender;

	#region Class: SendEmailToCaseContactProcessMultiLanguageSchema

	/// <exclude/>
	public class SendEmailToCaseContactProcessMultiLanguageSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToCaseContactProcessMultiLanguageSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToCaseContactProcessMultiLanguageSchema(SendEmailToCaseContactProcessMultiLanguageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToCaseContactProcessMultiLanguage";
			UId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce");
			CreatedInPackageId = new Guid("18e91881-16c9-49f4-ab06-bb16b1eb7b07");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
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
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2182c543-89b6-4709-8a44-0ccc49d8c85a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"CaseId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d30737ec-df8a-4aeb-805c-7bc8649175e6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.253cd392-267a-45bb-83b4-17630bcfa37b#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3da60100-fb70-4440-a82a-0ee88ccc4b13"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"SenderEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f0cb231-3dda-4b22-a6ea-e79291d7ee8c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateParentActivityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be5104c4-7adc-4c31-a4a7-99463c431b36"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ParentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{b59a15ea-751e-4fd8-8281-f1a3dc7190ff}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMultiLanguageEnabledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d8ed1115-f389-47a1-bee9-8ed2415c428e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"IsMultiLanguageEnabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEstimateWithIconsEnabledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a1ceebce-05dc-410e-a7d4-682eee2c2a92"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"IsEstimateWithIconsEnabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMultilanguageV2EnabledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b65555c6-7f69-41d1-9675-aa4693ee6b54"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"IsMultilanguageV2Enabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseIdParameter());
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateSenderEmailParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateParentActivityIdParameter());
			Parameters.Add(CreateIsMultiLanguageEnabledParameter());
			Parameters.Add(CreateIsEstimateWithIconsEnabledParameter());
			Parameters.Add(CreateIsMultilanguageV2EnabledParameter());
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2240c0c2-4f40-423c-8b95-f111c72bbfd9"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,205,142,211,48,16,126,21,148,243,122,149,164,249,113,122,67,165,160,94,216,149,182,218,11,217,195,196,113,90,139,164,137,236,116,161,84,149,16,47,64,185,174,16,79,192,97,145,64,66,72,112,104,143,188,5,79,194,216,105,67,23,21,109,225,194,70,178,52,158,124,254,230,155,25,143,231,22,203,65,169,199,80,112,171,107,13,185,148,160,202,172,62,126,40,242,154,203,71,178,156,86,214,145,165,184,20,144,139,23,60,109,252,253,84,212,15,160,6,60,50,143,127,49,196,86,55,222,207,17,91,71,177,37,106,94,40,196,224,145,212,9,105,230,165,148,132,110,144,16,47,244,129,64,232,248,36,116,32,176,211,36,226,25,245,26,228,159,200,123,101,81,129,228,77,12,67,159,25,115,56,171,52,212,65,7,51,16,161,202,201,198,217,209,34,84,127,2,73,206,83,220,215,114,202,209,85,75,81,96,54,124,40,10,126,10,18,99,105,158,82,187,16,148,65,174,52,42,231,89,221,127,94,73,174,148,40,39,183,137,203,167,197,100,23,141,4,188,221,110,228,216,70,163,70,158,66,61,54,20,3,148,181,48,42,239,143,70,146,143,160,22,151,187,34,158,242,153,193,29,86,63,60,144,98,151,206,33,159,242,157,152,55,51,233,65,85,55,9,53,225,17,32,197,104,124,112,174,109,197,110,75,215,69,103,181,5,31,200,185,55,7,55,64,231,165,118,52,44,91,51,182,158,12,212,201,179,9,151,103,108,204,11,104,170,118,113,140,222,223,28,45,127,119,238,58,212,101,190,215,33,52,74,2,172,164,29,17,10,158,71,108,198,152,23,165,148,81,31,22,23,141,14,161,170,28,102,231,109,184,245,242,251,219,245,114,245,17,215,39,92,95,215,111,126,188,188,66,227,179,54,222,25,99,185,250,130,235,122,251,231,27,26,175,222,223,51,214,114,245,193,236,182,255,175,91,26,195,176,122,109,130,234,150,96,40,26,81,10,182,227,18,199,119,67,226,185,16,16,26,250,156,68,25,119,237,212,77,59,190,143,154,22,250,211,29,46,71,130,65,126,82,113,137,55,200,116,208,222,127,247,111,12,141,174,171,44,203,186,169,86,219,151,30,40,52,118,110,95,70,147,52,75,59,33,97,140,106,49,40,43,178,179,144,4,9,135,32,138,28,96,78,130,98,240,225,208,173,59,43,167,146,109,6,85,53,47,198,63,189,4,255,97,190,255,102,100,247,14,205,33,67,112,87,174,247,224,174,220,180,133,181,248,9,87,238,130,148,151,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b46a95f8-c76e-49f0-a82f-3277d460a1f6"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("db33b5a6-46aa-47ff-8e4b-5e13fdb80187"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77acc736-6e4a-4799-8893-f31e6c67dd35"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("576434f3-e5c5-4731-be98-011701f8c85c"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8aa5b82c-3a24-4b4e-b291-b0353a2dc144"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0b953ab2-858c-4dd9-9bce-9d641ba01668"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("de51c882-736f-4db7-9a1b-bb605ec75208"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a5ebf76-4ad7-4eb7-81fd-71180b9cf610"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c4106eb8-5ed0-42c8-b84f-34b0294210ca"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("51459f74-5d40-4e53-8ac7-ffca49ce3463"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("76c7a624-b7e2-4ab7-b03b-403b54d5cf2c"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f5df9dd5-1461-4018-96ef-5e5408602213"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4e739645-cfcf-4acb-b2c4-d98d6c2154ce"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8453c16f-b75c-4362-9c4c-34a7a9599cbc"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd247f81-c60d-43ef-a529-7e9e698f5f8a"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d72a4519-9e07-4c3a-ae50-fb5c05a32b5e"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("63abd854-a87d-4589-8a12-384eb55afc80"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("55e9058b-1352-4783-96b1-8527c49bfe42"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0ec419a6-4bb4-40da-806a-7aff639e25bd"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,77,111,211,64,16,253,43,149,207,221,202,223,246,230,134,74,64,189,208,74,173,122,33,61,172,215,227,212,194,95,178,55,133,16,69,66,220,17,73,143,61,193,137,11,7,64,84,244,131,114,72,84,126,8,191,132,217,181,19,82,20,212,192,5,36,34,173,180,126,251,230,205,155,205,236,12,52,158,176,170,122,192,82,208,90,218,30,148,37,171,242,72,108,220,139,19,1,229,253,50,239,21,218,186,86,65,25,179,36,126,10,97,141,183,195,88,220,101,130,97,200,160,243,67,161,163,181,58,203,53,58,218,122,71,139,5,164,21,114,48,196,116,168,195,3,74,137,195,24,16,91,55,25,241,67,112,73,196,13,202,13,35,98,81,228,215,204,95,137,111,230,105,193,74,168,115,40,249,72,109,247,250,133,164,26,8,112,69,137,171,60,107,64,75,154,168,218,25,11,18,8,241,91,148,61,64,72,148,113,138,213,192,94,156,194,14,43,49,151,212,201,37,132,164,136,37,149,100,37,16,137,246,147,162,132,170,138,243,236,54,115,73,47,205,22,217,40,0,243,207,198,142,174,60,74,230,14,19,135,74,98,11,109,13,149,203,59,221,110,9,93,38,226,163,69,19,143,160,175,120,171,221,31,6,132,248,47,237,179,164,7,11,57,111,86,178,201,10,81,23,84,167,71,66,25,119,15,87,174,117,126,99,183,149,107,34,88,204,200,43,106,46,173,193,116,17,60,146,64,173,50,219,118,180,135,91,213,246,227,12,202,93,126,8,41,171,111,237,96,3,209,159,128,118,2,41,100,162,53,240,244,128,89,158,31,18,238,233,14,177,169,110,18,230,249,46,49,185,25,218,145,107,90,156,26,67,12,152,27,106,13,66,112,12,238,251,38,241,44,55,34,118,24,120,132,50,35,32,65,224,234,14,112,207,49,117,95,134,180,51,17,139,126,221,9,173,129,107,81,55,178,93,32,220,166,24,21,5,6,241,29,61,36,190,105,251,46,141,34,221,14,172,225,65,93,110,92,21,9,235,239,207,171,154,142,38,111,112,157,77,199,223,158,157,224,230,93,189,25,95,31,175,225,215,71,133,140,38,87,106,225,201,57,110,78,229,201,23,92,239,17,121,254,118,22,36,121,167,13,23,229,38,47,55,166,163,235,51,5,54,180,15,51,133,243,53,60,127,129,155,203,38,230,243,60,86,102,95,155,5,72,232,211,116,252,245,88,81,209,211,204,229,89,205,144,39,227,235,171,197,236,40,61,154,92,52,6,47,23,82,92,72,214,43,21,139,75,122,123,221,176,234,164,77,165,138,118,162,238,74,54,44,222,80,72,173,200,246,192,32,16,249,62,177,13,151,146,128,122,30,241,56,245,3,203,14,45,47,160,248,176,228,79,246,127,222,141,57,75,182,11,40,241,125,169,254,214,151,79,134,27,35,69,118,93,153,231,162,238,165,121,215,110,230,153,96,92,40,59,179,231,201,45,155,121,1,55,8,5,110,18,155,217,64,2,23,108,236,17,26,210,128,6,96,128,131,126,112,178,202,222,222,205,123,37,111,38,89,85,143,212,63,26,149,127,97,0,254,206,76,91,58,85,86,153,18,255,217,251,223,250,135,122,122,168,13,191,3,189,74,44,233,34,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0de42aa-d0a6-43c9-84cd-9298f4cb6c71"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("12b7121c-ee28-40f6-89c1-935e8b7d7ca7"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df939b4e-dde0-4d27-824d-3ce613d1a8df"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("70545f3a-7add-45c7-ba78-4585c9bf7ee7"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba3c18dd-7276-4d59-a388-7dd72332309c"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7569fb84-ca21-4722-9617-c42bd11f787f"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("e88f81f6-bb4f-4667-8712-8244a108432a"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("13f6b58c-3dac-47b1-8c2a-67b10c00b042"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f661c175-85bd-46e2-be1b-f8f2696bed90"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c3e9fc0d-0126-49b4-b41c-42ce78706d8d"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("eb5bda7b-e48e-4c43-a503-e9218b4bf960"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1a676d4f-b1c2-4fb2-ad01-f5ebd45a6e19"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b6d720fe-0e34-42a7-8e39-608e8b72fb38"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("89bf6187-da0e-4a92-9f82-dffbe82cc14c"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc3b7c87-0f42-4827-bc59-66107a5f6680"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a9eeba5-9cd2-4b31-b5da-2bb820239f2a"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f82956d1-db47-4d97-8b70-cc7e3dfd605c"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("45fd680b-c0b8-4b2c-9912-97eb3cdc375e"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeFillEmailUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8d2ec88-506d-4044-908d-a191e3892bb2"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText")
			};
			subjectParameter.SourceValue = new ProcessSchemaParameterValue(subjectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var bodyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21eff95f-b71a-4567-861f-65486cfabf8f"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"Body",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			bodyParameter.SourceValue = new ProcessSchemaParameterValue(bodyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(bodyParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("47f64290-f732-4e87-9a44-4cf2485d1240"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2182c543-89b6-4709-8a44-0ccc49d8c85a}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f0a1a14-83f4-4436-9927-3286a76c15e2"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			templateIdParameter.SourceValue = new ProcessSchemaParameterValue(templateIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d30737ec-df8a-4aeb-805c-7bc8649175e6}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var sysEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5f5844ae-4b77-4818-8542-1f6474d6e62c"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"SysEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			sysEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(sysEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{68684123-fbf5-4c0a-a480-775f630307b9}].[Parameter:{8e42a1ac-c457-45b8-8e4d-7e6e530c82aa}].[EntityColumn:{ed98cf3e-1642-4755-acb2-a61181429306}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(sysEntitySchemaIdParameter);
		}

		protected virtual void InitializeAddActivityDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("78fa348b-febc-4c15-9ab7-8db84e2baf7a"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a251d4b1-48d0-4b81-bd57-227f8c042748"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5464c2e0-a7bf-468f-ba2c-a086e8b7cb5b"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("8d80b754-2b5d-4731-ada2-68af17a0c8be"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eef95653-dcf6-49d4-b0e9-a9f6f4c8b03d"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,27,71,18,253,21,130,201,163,154,232,251,69,111,137,227,96,5,216,137,97,123,243,98,249,161,186,186,218,102,150,226,24,228,40,129,34,232,223,247,12,37,197,151,221,80,214,46,20,217,128,248,32,98,90,125,169,169,174,83,167,234,240,124,254,237,120,246,78,230,135,243,151,178,217,208,118,232,227,226,209,176,145,197,179,205,192,178,221,46,158,12,76,171,229,31,84,87,242,140,54,116,34,163,108,126,161,213,169,108,159,44,183,227,193,236,227,101,243,131,249,183,191,237,254,59,63,124,117,62,63,26,229,228,159,71,13,187,183,92,122,230,160,149,174,37,40,47,82,20,49,53,85,90,13,218,27,95,75,214,88,204,195,234,244,100,253,84,70,122,70,227,219,249,225,249,124,183,27,54,240,141,187,38,103,84,234,45,41,223,42,41,210,218,43,241,198,85,147,130,243,206,204,47,14,230,91,126,43,39,180,59,244,253,98,246,190,180,236,172,34,207,172,124,213,70,213,210,130,202,100,44,123,75,176,173,76,139,175,230,191,95,248,234,155,87,71,219,159,127,95,203,230,197,110,223,195,78,171,173,188,94,96,244,147,129,63,157,115,120,158,186,230,106,97,170,107,141,112,154,197,185,81,72,73,42,182,152,150,68,50,95,188,254,230,245,116,98,91,110,223,173,232,236,151,255,60,248,197,105,253,85,120,188,156,246,238,35,215,127,56,241,252,248,242,6,143,231,135,199,127,117,135,87,223,151,22,127,124,139,159,94,224,241,252,224,120,254,98,56,221,240,180,163,195,195,15,31,88,184,59,100,55,229,147,199,235,27,195,200,250,116,181,186,26,249,129,70,186,158,120,61,60,180,101,95,74,59,90,191,184,190,168,221,46,250,234,163,254,203,159,235,207,165,109,255,207,178,167,180,166,55,178,249,9,14,120,111,251,159,86,190,132,27,175,55,14,76,46,116,163,21,25,4,139,231,152,20,149,72,202,101,215,40,82,39,238,188,91,253,92,186,108,100,205,242,63,26,246,92,182,59,111,79,80,185,178,107,114,213,197,252,226,226,224,67,0,121,162,172,163,88,229,60,91,229,29,66,191,32,172,149,32,166,138,183,142,125,76,123,1,20,124,49,236,92,159,86,0,64,76,89,81,72,69,53,159,141,22,10,158,67,188,11,0,61,25,134,127,157,190,91,164,80,125,115,165,170,16,218,180,67,139,42,55,248,215,117,95,40,228,86,34,167,133,216,236,76,19,86,240,174,86,173,27,28,163,117,135,215,76,139,90,138,203,28,111,194,205,213,121,223,241,184,252,109,57,158,205,38,112,44,30,159,208,114,245,0,165,123,129,82,181,37,232,100,186,74,66,5,169,63,218,233,230,73,21,83,106,119,201,217,222,237,62,40,125,78,228,220,10,74,22,132,99,147,104,128,192,192,32,176,138,42,209,103,165,169,245,154,184,198,222,218,94,40,69,147,37,5,237,84,6,245,40,31,108,83,68,14,143,61,69,228,248,28,92,13,247,201,69,143,87,114,34,235,241,240,60,39,199,110,162,217,96,188,224,77,189,85,37,37,120,82,87,29,138,215,186,26,123,241,49,121,89,35,189,151,208,85,77,184,35,31,144,248,114,196,229,197,224,115,228,78,181,231,126,51,121,253,131,214,109,37,51,184,28,19,70,153,245,97,51,131,133,203,213,236,247,229,248,118,118,66,188,25,182,139,239,135,118,246,0,202,123,1,37,235,174,125,156,136,32,90,0,161,34,221,102,47,65,21,111,74,227,28,76,172,230,111,229,183,218,192,183,218,131,143,92,173,83,150,0,166,76,179,74,12,119,96,45,183,208,251,126,126,179,213,68,105,89,69,16,53,160,173,81,92,230,140,23,172,148,185,162,234,116,82,190,144,2,113,42,33,180,129,183,144,110,224,124,239,81,102,100,75,74,163,50,204,204,236,171,113,55,99,108,199,105,179,173,172,155,108,30,80,116,47,40,106,173,58,50,34,74,39,201,104,74,64,109,53,129,228,154,22,112,196,84,186,212,246,183,162,200,84,107,98,70,105,135,206,3,212,22,146,1,51,33,225,151,88,173,22,208,150,235,101,47,138,208,185,132,137,146,85,214,72,9,222,80,69,149,8,34,200,20,116,49,222,81,201,245,139,160,182,170,45,218,63,147,84,209,64,142,151,140,55,13,140,122,184,49,210,26,250,201,150,235,39,212,6,112,245,108,122,84,181,250,142,196,55,81,91,50,168,70,172,247,40,243,179,119,150,166,37,143,215,35,10,199,71,59,31,29,158,183,218,173,182,83,77,10,160,42,159,80,136,84,238,94,181,44,161,154,28,157,213,230,102,176,62,23,106,51,30,214,35,241,56,107,136,165,197,143,203,205,118,156,45,113,117,179,161,207,54,178,61,93,141,203,245,27,76,90,173,208,247,45,135,245,67,213,122,143,13,224,23,71,144,14,149,25,232,13,178,71,238,136,222,100,80,181,6,203,74,42,113,160,74,22,205,225,126,5,37,49,68,20,143,160,15,22,185,1,57,10,178,68,39,213,45,48,141,244,192,205,184,47,132,32,173,201,150,131,71,69,93,42,184,60,233,130,131,128,62,61,145,35,236,128,255,233,102,204,61,162,173,204,142,218,3,55,126,149,109,159,49,169,97,18,110,222,38,40,134,16,248,0,64,8,2,134,99,52,38,176,20,110,183,2,16,17,179,160,196,82,213,213,137,27,93,80,181,23,82,209,214,86,92,181,190,247,188,23,64,212,3,37,215,156,2,149,2,3,72,4,42,227,101,148,9,9,230,24,112,108,179,119,168,160,64,72,76,145,208,253,38,195,232,58,43,76,175,82,154,114,169,76,164,7,141,196,246,69,234,177,129,227,189,234,46,194,50,143,62,89,199,204,48,153,187,211,213,21,120,254,51,21,148,167,144,12,113,215,151,2,202,207,167,227,155,1,244,244,0,166,175,18,76,159,19,59,183,2,147,142,12,5,17,221,75,77,221,41,79,85,32,134,64,104,176,228,11,67,96,17,150,253,114,36,103,227,59,161,62,21,109,208,239,57,27,240,131,64,110,120,45,79,182,56,1,25,229,59,4,83,137,70,172,206,17,77,166,197,241,13,68,95,245,244,203,4,36,17,137,168,228,153,245,34,107,151,201,161,155,76,25,230,193,80,3,192,199,48,201,145,208,162,52,140,214,254,182,114,36,67,14,121,51,108,206,30,138,187,175,24,78,159,19,61,183,83,63,42,83,130,28,167,196,25,4,180,3,217,65,205,0,36,106,204,200,230,18,41,237,231,166,172,59,16,3,19,18,52,116,229,115,64,113,23,34,148,82,219,33,135,76,26,136,190,131,190,109,220,224,107,111,248,127,63,12,43,161,245,108,55,178,120,137,249,15,12,114,47,33,95,116,141,1,226,173,210,189,227,142,81,25,160,249,197,207,63,214,35,144,83,162,94,244,181,138,126,103,253,204,235,139,127,3,223,51,16,210,111,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d07a51ae-6eef-4fae-8974-16c453d75d56"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				UId = new Guid("8ca45dc6-c3c8-40be-8b20-95308cc51e8f"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c44ff41-7d4f-4045-985d-f5591d95f153"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,149,66,231,176,144,245,180,115,11,92,181,183,54,168,141,158,116,89,73,75,153,40,245,0,73,5,113,3,255,123,151,148,237,58,168,218,40,69,31,1,122,147,6,195,209,236,112,180,15,94,41,65,235,247,208,160,119,237,109,81,41,208,29,55,175,223,10,105,80,189,83,221,208,123,87,158,70,37,64,138,47,88,141,120,86,9,243,6,12,208,145,135,252,155,66,238,93,231,211,26,185,119,149,123,194,96,163,137,67,71,150,33,15,10,72,23,12,121,16,177,200,15,11,6,69,201,25,70,60,44,227,184,172,32,142,71,230,143,196,215,93,211,131,194,241,27,78,158,187,199,237,190,183,212,5,1,165,163,8,221,181,71,48,180,38,116,214,66,33,177,162,119,163,6,36,200,40,209,208,52,184,21,13,222,130,162,111,89,157,206,66,68,226,32,181,101,73,228,38,187,239,21,106,45,186,246,41,115,114,104,218,75,54,9,224,249,245,104,199,119,30,45,243,22,204,206,73,140,90,7,231,243,166,174,21,214,96,196,221,165,141,207,184,119,204,121,9,210,129,138,238,233,19,200,1,47,146,121,60,203,26,122,51,142,116,50,64,20,37,234,221,236,121,207,169,61,53,114,64,96,127,34,207,212,156,156,34,88,18,120,103,1,119,108,13,218,230,118,176,201,173,0,146,56,2,100,24,86,192,162,42,241,25,132,97,204,86,75,228,113,28,133,41,101,243,63,118,43,187,55,216,86,100,2,91,51,175,99,243,146,156,234,88,240,211,146,125,196,94,66,137,175,250,163,151,151,95,55,55,208,169,110,46,38,234,154,141,80,118,181,40,65,126,232,81,81,138,206,184,63,221,132,71,21,74,236,200,93,103,54,229,14,27,56,219,217,236,245,136,56,19,167,107,72,33,241,211,32,76,88,145,34,103,81,92,70,116,13,105,194,248,34,40,18,140,86,124,149,4,116,161,180,167,173,237,77,55,168,242,216,93,61,46,232,95,90,188,255,160,242,207,219,144,147,149,153,83,129,63,178,75,94,104,92,217,119,63,253,111,139,237,239,255,19,7,239,240,21,119,29,150,147,176,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8f65b044-884b-49ca-9219-5baf24f17958"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5523d04c-3e1b-4f60-9563-9e520dac2c6c"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a8f08199-d9c0-4005-9c94-7c03f7670d2e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ebd74111-6e32-475d-ab86-716f0976612e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("573cfd72-52b9-4c1e-a621-58e6e1c6ce39"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("524f3776-d1c5-42c1-a379-e9b3d4ea79d5"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,78,44,40,201,204,207,179,50,180,50,212,241,76,177,50,176,50,0,0,176,27,135,17,18,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("8e42a1ac-c457-45b8-8e4d-7e6e530c82aa"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e982666-3fc9-4b3d-bf43-1c31a8e6cb53"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ac82296a-e4a2-4f63-8ecf-fc2befdcc54e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2ce6abdb-47e7-4462-a89a-faa0c73eff6e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5e71482a-fa3d-496e-aab2-d15119381051"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5af71371-6345-46b7-91d8-531f111fc281"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7ee2a87a-3e6d-4e07-bf35-2fba8030ddcd"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("e505355f-473f-4baf-a0c5-a7acfe566ab9"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65c22ff4-89c4-41cc-9507-4121365b392c"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("898740ca-c0ac-43d9-bb83-01db84a4e988"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ef68ece7-b557-4e7c-a75c-1655ae2a8984"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("580236c7-16fb-418f-95fc-61d13bf042e6"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("01c24e99-0525-4c53-bd4b-2b34f9d3766f"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,205,110,211,64,16,126,21,228,115,93,197,63,249,189,85,37,160,94,104,165,70,189,224,30,38,235,177,179,98,237,181,118,55,133,16,69,130,39,128,112,228,196,35,32,4,82,5,130,67,35,94,132,39,97,118,157,154,20,5,53,32,33,176,52,210,236,231,111,191,249,217,153,185,199,4,104,253,0,10,244,6,222,8,149,2,45,51,179,127,143,11,131,234,190,146,211,202,219,243,52,42,14,130,63,197,180,198,135,41,55,119,193,0,93,153,39,63,20,18,111,144,108,215,72,188,189,196,227,6,11,77,28,186,210,235,196,237,238,56,234,248,152,134,161,31,7,89,219,239,119,195,158,31,177,160,21,132,48,142,218,189,176,102,254,74,252,80,22,21,40,172,99,56,249,204,185,163,89,101,169,1,1,204,81,184,150,229,26,140,108,18,122,88,194,88,96,74,103,163,166,72,144,81,188,160,106,112,196,11,60,1,69,177,172,142,180,16,145,50,16,218,178,4,102,102,248,164,82,168,53,151,229,109,201,137,105,81,110,178,73,0,155,227,58,157,150,203,209,50,79,192,76,156,196,17,165,181,112,89,30,228,185,194,28,12,191,216,76,226,17,206,28,111,183,254,209,133,148,94,233,12,196,20,55,98,222,172,228,16,42,83,23,84,135,39,130,226,249,100,231,90,155,142,221,86,110,72,96,117,77,222,81,115,107,13,97,135,192,11,11,212,42,215,110,226,61,60,210,199,143,75,84,167,108,130,5,212,93,59,223,39,244,39,160,209,31,204,199,216,14,90,49,139,253,46,164,204,143,89,20,248,16,67,215,239,247,227,78,196,226,40,160,46,47,206,235,60,184,174,4,204,206,154,112,171,151,87,111,200,190,144,189,39,187,92,45,191,61,123,77,206,7,178,79,171,229,215,87,171,229,213,115,242,63,146,189,37,255,197,29,231,88,96,205,188,36,123,71,246,217,201,88,182,251,65,87,105,14,236,103,159,75,230,156,129,56,174,80,209,56,184,231,104,109,31,228,27,27,96,155,164,164,52,117,233,77,147,15,24,141,20,55,52,70,27,227,68,193,104,203,109,159,79,229,84,177,245,86,233,122,189,255,104,109,255,193,50,254,206,126,109,157,240,93,38,54,253,31,102,241,111,79,198,194,91,124,7,172,30,83,0,24,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c7d73d91-0514-42af-999d-7a34d7ec0e95"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("eeb351c9-365d-423c-800b-a2a013bab823"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("71bd15f4-6282-4eae-a7e9-6faa031d959e"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3f1dbb68-9a58-49b3-a323-5ac45052dfef"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2056ce2f-42d8-4fd2-bf24-61ea6742c3dd"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7f067451-f8bd-4ba8-942d-d6a482207da2"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,4,0,252,157,29,132,13,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("95cb3a8c-de47-4ebf-ab83-44e2e6e9b06e"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0062d8b-80ae-4931-8d0d-9e40b6beed2a"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e646785e-110f-4438-bc03-5a65ff0404d2"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("45fdb25d-4878-4115-a5db-f8c6a0d63fdb"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6c591f23-80f8-405f-bcf7-acb6c98329e5"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5764dd4b-f9ff-4af0-ad7a-a37ba669478c"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("177a98fd-0f17-4427-86c0-92b3fd286f79"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8071ca0f-90db-43d4-8161-5e54d91f00ea"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f92969bc-781b-4b37-b423-62af4cbe765b"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,5,193,129,9,0,48,8,3,176,139,10,150,118,120,143,206,249,255,9,75,60,119,163,68,228,78,194,211,133,138,48,158,169,102,30,89,252,2,221,81,196,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3bcea3e3-3e90-4842-98a1-348ce8d75cc4"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c90d7462-b6c8-4bda-ad55-cfa805f6475d"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("666c551a-f30d-48ef-82b5-53faef7380ca"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask fillemailusertask = CreateFillEmailUserTaskUserTask();
			FlowElements.Add(fillemailusertask);
			ProcessSchemaUserTask addactivitydatausertask = CreateAddActivityDataUserTaskUserTask();
			FlowElements.Add(addactivitydatausertask);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaScriptTask sendmailscripttask = CreateSendMailScriptTaskScriptTask();
			FlowElements.Add(sendmailscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			FlowElements.Add(scripttask2);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			FlowElements.Add(scripttask3);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			FlowElements.Add(scripttask4);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9ddc1a0b-a466-47d2-82b5-83aa49438994"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f074929-411d-41a1-9f14-36b4e42641af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("a2e8ef78-e0cb-4b03-80ee-1ef683b0ed83"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{6396f46e-c49f-4fb1-850d-824869ff04b3}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(430, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("35dcb8df-533d-48b8-aa1d-33128db9836d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(438, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(155, 30));
			schemaFlow.PolylinePointPositions.Add(new Point(1187, 30));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f07aee8e-1621-486d-92b1-1591317f60c2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{b0200417-902a-4e81-a5c4-edc6274b9d8b}].[Parameter:{e88f81f6-bb4f-4667-8712-8244a108432a}].[EntityColumn:{dbf202ec-c444-479b-bcf4-d8e5b1863201}]#] != string.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(522, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20333f00-a29d-40bd-b174-f1b74f89bf82"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("598e616a-5180-40f1-a0ab-9f92b088b9bb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(528, 197),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(326, 30));
			schemaFlow.PolylinePointPositions.Add(new Point(1187, 30));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("44c5fa4c-0096-49bc-ad9a-40266638707f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(722, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("b4bd0bb9-d007-42c8-a087-feac9a3ed139"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(628, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e72d381c-dce6-4ad4-8896-113ee36b7e48"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(722, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1136, 308));
			schemaFlow.PolylinePointPositions.Add(new Point(1136, 307));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("261cef82-4b0a-4d18-8b5b-aa42470fb2fd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("0c2036ff-eec7-4fed-8a49-c46b3cf449a6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("5880c05f-f6d8-4064-bb1f-0c7b60536fb5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{a93cb111-ce30-4da4-89ec-d2a2f3dd71c4}]#]==[#Lookup.b17869fe-43f9-487a-af82-b7626f1fc810.7f9e1f1e-f46b-1410-3492-0050ba5d6c38#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("fb4832f6-f288-41c6-97da-95371a8537c1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("917d22fe-13e7-4464-9603-0f46fd69e64b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(946, 439));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("b1a5cc59-fab4-481f-bb51-e46500862a56"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6a037ba-b91a-4d5c-92e1-a7eec4637e82"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1187, 588));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("a20641fa-66ed-435b-b183-c42d20af156f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20333f00-a29d-40bd-b174-f1b74f89bf82"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba4d73bb-1240-4a05-8f5f-158635ee29ba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("9b12ac39-b4ba-4c0c-82b1-cfb780881afa"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d8ed1115-f389-47a1-bee9-8ed2415c428e}]#] || [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b65555c6-7f69-41d1-9675-aa4693ee6b54}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba4d73bb-1240-4a05-8f5f-158635ee29ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6a037ba-b91a-4d5c-92e1-a7eec4637e82"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("f60f98e4-d97c-4371-acf7-9c4a391ebf4b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba4d73bb-1240-4a05-8f5f-158635ee29ba"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2046ac4f-8c0b-4a3d-b998-d90962403018"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("a74ece8a-b021-4c1b-97e8-0bf72172a17a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f72d3295-d03d-44df-913e-ce128e26f6eb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow3",
				UId = new Guid("2978ae22-dedc-4a05-ad74-8eea4e29b03f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{a1ceebce-05dc-410e-a7d4-682eee2c2a92}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f72d3295-d03d-44df-913e-ce128e26f6eb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7be43985-dcda-49bd-8a77-0caecc01a550"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(532, 129));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("8c158063-a878-4261-bf3a-83c6c3bf8981"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7be43985-dcda-49bd-8a77-0caecc01a550"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1187, 129));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("43051823-ae32-45a6-a439-5b1c2bea4bde"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2046ac4f-8c0b-4a3d-b998-d90962403018"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f72d3295-d03d-44df-913e-ce128e26f6eb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dae6eec2-f54b-41ae-aabb-69a51383693f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("dae6eec2-f54b-41ae-aabb-69a51383693f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("7f074929-411d-41a1-9f14-36b4e42641af"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"Start1",
				Position = new Point(20, 74),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"Terminate1",
				Position = new Point(1173, 293),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ReadDataUserTask1",
				Position = new Point(120, 60),
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
				UId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ReadDataUserTask2",
				Position = new Point(291, 60),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateFillEmailUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"FillEmailUserTask",
				Position = new Point(620, 280),
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFillEmailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddActivityDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"AddActivityDataUserTask",
				Position = new Point(911, 280),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddActivityDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ReadDataUserTask3",
				Position = new Point(620, 420),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendMailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"SendMailScriptTask",
				Position = new Point(1031, 280),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,77,10,194,48,16,133,247,130,119,8,93,165,32,189,64,85,40,245,135,110,253,57,192,96,6,9,182,9,76,38,149,222,222,137,180,84,168,171,48,243,230,189,239,145,30,72,193,131,109,111,121,104,140,218,169,202,152,106,156,15,192,112,15,72,55,8,175,226,130,15,79,166,49,229,122,213,139,7,59,176,109,221,90,116,124,18,191,167,65,188,117,11,33,140,99,113,70,222,30,23,87,123,237,240,173,106,239,2,83,76,155,138,158,177,19,93,103,81,80,34,56,20,188,119,217,70,37,246,188,200,243,17,61,213,253,134,95,209,25,36,97,167,216,169,248,143,162,151,69,23,193,146,251,39,179,72,143,158,255,38,157,17,114,36,167,164,58,150,31,3,155,136,48,58,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ExclusiveGateway1",
				Position = new Point(738, 280),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ReadDataUserTask4",
				Position = new Point(731, 411),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"FormulaTask1",
				Position = new Point(845, 411),
				ResultParameterMetaPath = @"7f0cb231-3dda-4b22-a6ea-e79291d7ee8c",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,207,189,106,195,48,20,134,225,91,17,201,98,83,142,145,44,217,82,4,33,67,240,144,41,165,63,83,240,112,36,29,209,130,173,4,199,165,45,38,247,94,181,99,47,33,235,7,47,31,79,113,90,159,14,215,227,103,162,233,217,191,209,136,54,226,112,165,190,202,235,191,161,27,104,164,52,219,69,55,206,71,77,8,24,29,7,85,155,26,92,173,17,130,209,109,99,132,199,214,212,183,28,60,226,132,35,205,52,217,101,211,120,39,209,120,8,164,52,40,114,17,208,25,9,74,81,77,45,109,28,111,233,55,233,210,252,62,127,239,207,195,199,152,236,162,130,143,28,165,0,29,67,174,130,203,151,156,43,32,37,164,19,186,145,74,138,91,191,238,203,234,229,252,122,185,208,84,148,213,33,5,250,58,198,98,245,212,89,182,42,217,118,203,56,219,177,123,96,178,12,250,83,177,135,187,240,252,0,224,102,164,15,124,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ba4d73bb-1240-4a05-8f5f-158635ee29ba"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ExclusiveGateway2",
				Position = new Point(298, 420),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c6a037ba-b91a-4d5c-92e1-a7eec4637e82"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ScriptTask1",
				Position = new Point(291, 560),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,65,79,132,48,16,133,207,242,43,154,61,177,201,134,195,94,87,189,32,81,18,73,204,46,174,231,145,142,216,88,166,164,29,214,16,227,127,183,32,171,32,171,137,183,50,125,249,222,27,94,15,96,69,97,136,161,224,164,2,165,197,133,216,34,200,43,96,184,119,104,115,112,47,235,104,139,174,209,156,16,43,110,163,107,228,188,173,81,198,70,55,21,237,65,55,120,238,216,42,42,47,195,69,207,88,44,55,193,193,115,177,251,200,177,170,53,48,102,80,88,227,50,32,40,209,122,23,194,87,209,171,31,20,63,79,46,195,206,56,54,68,88,176,50,228,97,234,73,132,169,203,124,6,165,129,202,198,171,246,235,132,224,81,163,92,138,183,224,236,119,167,104,135,36,123,159,220,132,49,56,76,229,74,28,149,221,121,188,188,183,122,23,168,29,118,204,217,6,59,54,22,199,201,39,23,243,212,115,194,237,16,254,6,117,61,253,9,167,21,95,129,79,179,245,32,78,165,71,253,97,212,85,118,156,164,50,252,222,254,8,226,97,242,217,240,79,88,191,94,95,251,48,24,17,86,163,16,29,237,159,69,76,141,163,59,171,42,176,237,232,101,205,251,9,44,114,99,73,176,109,112,243,1,16,134,246,2,190,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("20333f00-a29d-40bd-b174-f1b74f89bf82"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ScriptTask2",
				Position = new Point(291, 280),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,243,44,246,45,205,41,201,244,73,204,75,47,77,76,79,117,205,75,76,202,73,77,81,176,85,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,130,41,210,80,114,205,77,204,204,241,77,45,46,6,234,68,49,70,73,211,154,203,19,98,114,14,84,40,204,136,74,102,135,25,129,76,47,74,5,170,206,83,40,41,42,77,181,6,0,79,140,17,95,196,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f72d3295-d03d-44df-913e-ce128e26f6eb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ExclusiveGateway3",
				Position = new Point(504, 420),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7be43985-dcda-49bd-8a77-0caecc01a550"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ScriptTask3",
				Position = new Point(711, 101),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,141,177,14,194,48,16,67,119,190,226,198,34,161,252,64,197,84,49,48,116,2,196,124,106,221,18,169,189,32,231,2,191,79,202,134,196,100,15,126,207,47,165,96,213,184,220,163,63,122,29,152,242,5,54,130,114,20,195,91,174,32,53,167,201,67,151,108,138,115,161,122,76,22,78,191,76,175,166,51,216,220,50,88,135,134,97,91,237,219,221,95,119,216,226,107,104,58,205,56,143,135,250,179,62,23,245,218,43,68,120,161,137,179,160,253,0,122,170,191,186,161,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2046ac4f-8c0b-4a3d-b998-d90962403018"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ScriptTask4",
				Position = new Point(394, 420),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,142,61,14,130,64,16,133,107,56,197,134,130,64,195,5,8,21,65,179,21,137,193,88,175,248,192,77,96,86,103,102,239,239,70,45,76,44,223,223,151,103,101,16,245,187,83,92,188,222,237,28,72,6,114,215,13,55,211,153,106,194,254,216,82,102,147,234,204,4,102,39,97,209,166,15,180,248,53,178,83,31,168,233,157,32,57,162,242,9,56,225,146,63,46,253,22,196,211,122,194,51,66,244,7,150,103,89,89,154,179,128,211,128,48,191,49,71,168,149,3,156,70,198,247,67,85,252,189,43,234,186,205,25,169,68,70,57,162,125,1,75,116,190,0,194,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6a058acc-ee02-4e77-b820-891e6bc0cb95"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("be966acc-af84-4226-9b13-0286de9ffd75"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("06bb9208-0bbc-4847-80a8-8bc33de240ad"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3b91697b-7fa9-4a1d-b948-99807c7539c5"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8394e686-2333-42c9-8ea4-7feddc53fa46")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToCaseContactProcessMultiLanguage(userConnection);
		}

		public override object Clone() {
			return new SendEmailToCaseContactProcessMultiLanguageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToCaseContactProcessMultiLanguage

	/// <exclude/>
	public class SendEmailToCaseContactProcessMultiLanguage : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToCaseContactProcessMultiLanguage process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendEmailToCaseContactProcessMultiLanguage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,205,142,211,48,16,126,21,148,243,122,149,164,249,113,122,67,165,160,94,216,149,182,218,11,217,195,196,113,90,139,164,137,236,116,161,84,149,16,47,64,185,174,16,79,192,97,145,64,66,72,112,104,143,188,5,79,194,216,105,67,23,21,109,225,194,70,178,52,158,124,254,230,155,25,143,231,22,203,65,169,199,80,112,171,107,13,185,148,160,202,172,62,126,40,242,154,203,71,178,156,86,214,145,165,184,20,144,139,23,60,109,252,253,84,212,15,160,6,60,50,143,127,49,196,86,55,222,207,17,91,71,177,37,106,94,40,196,224,145,212,9,105,230,165,148,132,110,144,16,47,244,129,64,232,248,36,116,32,176,211,36,226,25,245,26,228,159,200,123,101,81,129,228,77,12,67,159,25,115,56,171,52,212,65,7,51,16,161,202,201,198,217,209,34,84,127,2,73,206,83,220,215,114,202,209,85,75,81,96,54,124,40,10,126,10,18,99,105,158,82,187,16,148,65,174,52,42,231,89,221,127,94,73,174,148,40,39,183,137,203,167,197,100,23,141,4,188,221,110,228,216,70,163,70,158,66,61,54,20,3,148,181,48,42,239,143,70,146,143,160,22,151,187,34,158,242,153,193,29,86,63,60,144,98,151,206,33,159,242,157,152,55,51,233,65,85,55,9,53,225,17,32,197,104,124,112,174,109,197,110,75,215,69,103,181,5,31,200,185,55,7,55,64,231,165,118,52,44,91,51,182,158,12,212,201,179,9,151,103,108,204,11,104,170,118,113,140,222,223,28,45,127,119,238,58,212,101,190,215,33,52,74,2,172,164,29,17,10,158,71,108,198,152,23,165,148,81,31,22,23,141,14,161,170,28,102,231,109,184,245,242,251,219,245,114,245,17,215,39,92,95,215,111,126,188,188,66,227,179,54,222,25,99,185,250,130,235,122,251,231,27,26,175,222,223,51,214,114,245,193,236,182,255,175,91,26,195,176,122,109,130,234,150,96,40,26,81,10,182,227,18,199,119,67,226,185,16,16,26,250,156,68,25,119,237,212,77,59,190,143,154,22,250,211,29,46,71,130,65,126,82,113,137,55,200,116,208,222,127,247,111,12,141,174,171,44,203,186,169,86,219,151,30,40,52,118,110,95,70,147,52,75,59,33,97,140,106,49,40,43,178,179,144,4,9,135,32,138,28,96,78,130,98,240,225,208,173,59,43,167,146,109,6,85,53,47,198,63,189,4,255,97,190,255,102,100,247,14,205,33,67,112,87,174,247,224,174,220,180,133,181,248,9,87,238,130,148,151,6,0,0 })));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendEmailToCaseContactProcessMultiLanguage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,77,111,211,64,16,253,43,149,207,221,202,223,246,230,134,74,64,189,208,74,173,122,33,61,172,215,227,212,194,95,178,55,133,16,69,66,220,17,73,143,61,193,137,11,7,64,84,244,131,114,72,84,126,8,191,132,217,181,19,82,20,212,192,5,36,34,173,180,126,251,230,205,155,205,236,12,52,158,176,170,122,192,82,208,90,218,30,148,37,171,242,72,108,220,139,19,1,229,253,50,239,21,218,186,86,65,25,179,36,126,10,97,141,183,195,88,220,101,130,97,200,160,243,67,161,163,181,58,203,53,58,218,122,71,139,5,164,21,114,48,196,116,168,195,3,74,137,195,24,16,91,55,25,241,67,112,73,196,13,202,13,35,98,81,228,215,204,95,137,111,230,105,193,74,168,115,40,249,72,109,247,250,133,164,26,8,112,69,137,171,60,107,64,75,154,168,218,25,11,18,8,241,91,148,61,64,72,148,113,138,213,192,94,156,194,14,43,49,151,212,201,37,132,164,136,37,149,100,37,16,137,246,147,162,132,170,138,243,236,54,115,73,47,205,22,217,40,0,243,207,198,142,174,60,74,230,14,19,135,74,98,11,109,13,149,203,59,221,110,9,93,38,226,163,69,19,143,160,175,120,171,221,31,6,132,248,47,237,179,164,7,11,57,111,86,178,201,10,81,23,84,167,71,66,25,119,15,87,174,117,126,99,183,149,107,34,88,204,200,43,106,46,173,193,116,17,60,146,64,173,50,219,118,180,135,91,213,246,227,12,202,93,126,8,41,171,111,237,96,3,209,159,128,118,2,41,100,162,53,240,244,128,89,158,31,18,238,233,14,177,169,110,18,230,249,46,49,185,25,218,145,107,90,156,26,67,12,152,27,106,13,66,112,12,238,251,38,241,44,55,34,118,24,120,132,50,35,32,65,224,234,14,112,207,49,117,95,134,180,51,17,139,126,221,9,173,129,107,81,55,178,93,32,220,166,24,21,5,6,241,29,61,36,190,105,251,46,141,34,221,14,172,225,65,93,110,92,21,9,235,239,207,171,154,142,38,111,112,157,77,199,223,158,157,224,230,93,189,25,95,31,175,225,215,71,133,140,38,87,106,225,201,57,110,78,229,201,23,92,239,17,121,254,118,22,36,121,167,13,23,229,38,47,55,166,163,235,51,5,54,180,15,51,133,243,53,60,127,129,155,203,38,230,243,60,86,102,95,155,5,72,232,211,116,252,245,88,81,209,211,204,229,89,205,144,39,227,235,171,197,236,40,61,154,92,52,6,47,23,82,92,72,214,43,21,139,75,122,123,221,176,234,164,77,165,138,118,162,238,74,54,44,222,80,72,173,200,246,192,32,16,249,62,177,13,151,146,128,122,30,241,56,245,3,203,14,45,47,160,248,176,228,79,246,127,222,141,57,75,182,11,40,241,125,169,254,214,151,79,134,27,35,69,118,93,153,231,162,238,165,121,215,110,230,153,96,92,40,59,179,231,201,45,155,121,1,55,8,5,110,18,155,217,64,2,23,108,236,17,26,210,128,6,96,128,131,126,112,178,202,222,222,205,123,37,111,38,89,85,143,212,63,26,149,127,97,0,254,206,76,91,58,85,86,153,18,255,217,251,223,250,135,122,122,168,13,191,3,189,74,44,233,34,8,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: FillEmailUserTaskFlowElement

		/// <exclude/>
		public class FillEmailUserTaskFlowElement : FillEmailTemplateUserTask
		{

			#region Constructors: Public

			public FillEmailUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseContactProcessMultiLanguage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FillEmailUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("873c3cad-514e-4042-977b-50b059400b12");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordId = () => (Guid)((process.CaseId));
				_templateId = () => (Guid)((process.TemplateId));
				_sysEntitySchemaId = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("UId").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("UId") : Guid.Empty)));
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

			internal Func<Guid> _templateId;
			public override Guid TemplateId {
				get {
					return (_templateId ?? (_templateId = () => Guid.Empty)).Invoke();
				}
				set {
					_templateId = () => { return value; };
				}
			}

			internal Func<Guid> _sysEntitySchemaId;
			public override Guid SysEntitySchemaId {
				get {
					return (_sysEntitySchemaId ?? (_sysEntitySchemaId = () => Guid.Empty)).Invoke();
				}
				set {
					_sysEntitySchemaId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddActivityDataUserTaskFlowElement

		/// <exclude/>
		public class AddActivityDataUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddActivityDataUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseContactProcessMultiLanguage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddActivityDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString((process.Subject));
				_recordDefValues_Type = () => (Guid)(new Guid("e2831dec-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_Body = () => new LocalizableString((process.FillEmailUserTask.Body));
				_recordDefValues_Sender = () => new LocalizableString((process.SenderEmail));
				_recordDefValues_Recepient = () => new LocalizableString(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_recordDefValues_Case = () => (Guid)((process.CaseId));
				_recordDefValues_MessageType = () => (Guid)(new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("8038a396-7825-e011-8165-00155d043204"));
				_recordDefValues_IsHtmlBody = () => (bool)(true);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Body", () => _recordDefValues_Body.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Sender", () => _recordDefValues_Sender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Recepient", () => _recordDefValues_Recepient.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MessageType", () => _recordDefValues_MessageType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsHtmlBody", () => _recordDefValues_IsHtmlBody.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Title;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<string> _recordDefValues_Body;
			internal Func<string> _recordDefValues_Sender;
			internal Func<string> _recordDefValues_Recepient;
			internal Func<Guid> _recordDefValues_Case;
			internal Func<Guid> _recordDefValues_MessageType;
			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<bool> _recordDefValues_IsHtmlBody;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,27,71,18,253,21,130,201,163,154,232,251,69,111,137,227,96,5,216,137,97,123,243,98,249,161,186,186,218,102,150,226,24,228,40,129,34,232,223,247,12,37,197,151,221,80,214,46,20,217,128,248,32,98,90,125,169,169,174,83,167,234,240,124,254,237,120,246,78,230,135,243,151,178,217,208,118,232,227,226,209,176,145,197,179,205,192,178,221,46,158,12,76,171,229,31,84,87,242,140,54,116,34,163,108,126,161,213,169,108,159,44,183,227,193,236,227,101,243,131,249,183,191,237,254,59,63,124,117,62,63,26,229,228,159,71,13,187,183,92,122,230,160,149,174,37,40,47,82,20,49,53,85,90,13,218,27,95,75,214,88,204,195,234,244,100,253,84,70,122,70,227,219,249,225,249,124,183,27,54,240,141,187,38,103,84,234,45,41,223,42,41,210,218,43,241,198,85,147,130,243,206,204,47,14,230,91,126,43,39,180,59,244,253,98,246,190,180,236,172,34,207,172,124,213,70,213,210,130,202,100,44,123,75,176,173,76,139,175,230,191,95,248,234,155,87,71,219,159,127,95,203,230,197,110,223,195,78,171,173,188,94,96,244,147,129,63,157,115,120,158,186,230,106,97,170,107,141,112,154,197,185,81,72,73,42,182,152,150,68,50,95,188,254,230,245,116,98,91,110,223,173,232,236,151,255,60,248,197,105,253,85,120,188,156,246,238,35,215,127,56,241,252,248,242,6,143,231,135,199,127,117,135,87,223,151,22,127,124,139,159,94,224,241,252,224,120,254,98,56,221,240,180,163,195,195,15,31,88,184,59,100,55,229,147,199,235,27,195,200,250,116,181,186,26,249,129,70,186,158,120,61,60,180,101,95,74,59,90,191,184,190,168,221,46,250,234,163,254,203,159,235,207,165,109,255,207,178,167,180,166,55,178,249,9,14,120,111,251,159,86,190,132,27,175,55,14,76,46,116,163,21,25,4,139,231,152,20,149,72,202,101,215,40,82,39,238,188,91,253,92,186,108,100,205,242,63,26,246,92,182,59,111,79,80,185,178,107,114,213,197,252,226,226,224,67,0,121,162,172,163,88,229,60,91,229,29,66,191,32,172,149,32,166,138,183,142,125,76,123,1,20,124,49,236,92,159,86,0,64,76,89,81,72,69,53,159,141,22,10,158,67,188,11,0,61,25,134,127,157,190,91,164,80,125,115,165,170,16,218,180,67,139,42,55,248,215,117,95,40,228,86,34,167,133,216,236,76,19,86,240,174,86,173,27,28,163,117,135,215,76,139,90,138,203,28,111,194,205,213,121,223,241,184,252,109,57,158,205,38,112,44,30,159,208,114,245,0,165,123,129,82,181,37,232,100,186,74,66,5,169,63,218,233,230,73,21,83,106,119,201,217,222,237,62,40,125,78,228,220,10,74,22,132,99,147,104,128,192,192,32,176,138,42,209,103,165,169,245,154,184,198,222,218,94,40,69,147,37,5,237,84,6,245,40,31,108,83,68,14,143,61,69,228,248,28,92,13,247,201,69,143,87,114,34,235,241,240,60,39,199,110,162,217,96,188,224,77,189,85,37,37,120,82,87,29,138,215,186,26,123,241,49,121,89,35,189,151,208,85,77,184,35,31,144,248,114,196,229,197,224,115,228,78,181,231,126,51,121,253,131,214,109,37,51,184,28,19,70,153,245,97,51,131,133,203,213,236,247,229,248,118,118,66,188,25,182,139,239,135,118,246,0,202,123,1,37,235,174,125,156,136,32,90,0,161,34,221,102,47,65,21,111,74,227,28,76,172,230,111,229,183,218,192,183,218,131,143,92,173,83,150,0,166,76,179,74,12,119,96,45,183,208,251,126,126,179,213,68,105,89,69,16,53,160,173,81,92,230,140,23,172,148,185,162,234,116,82,190,144,2,113,42,33,180,129,183,144,110,224,124,239,81,102,100,75,74,163,50,204,204,236,171,113,55,99,108,199,105,179,173,172,155,108,30,80,116,47,40,106,173,58,50,34,74,39,201,104,74,64,109,53,129,228,154,22,112,196,84,186,212,246,183,162,200,84,107,98,70,105,135,206,3,212,22,146,1,51,33,225,151,88,173,22,208,150,235,101,47,138,208,185,132,137,146,85,214,72,9,222,80,69,149,8,34,200,20,116,49,222,81,201,245,139,160,182,170,45,218,63,147,84,209,64,142,151,140,55,13,140,122,184,49,210,26,250,201,150,235,39,212,6,112,245,108,122,84,181,250,142,196,55,81,91,50,168,70,172,247,40,243,179,119,150,166,37,143,215,35,10,199,71,59,31,29,158,183,218,173,182,83,77,10,160,42,159,80,136,84,238,94,181,44,161,154,28,157,213,230,102,176,62,23,106,51,30,214,35,241,56,107,136,165,197,143,203,205,118,156,45,113,117,179,161,207,54,178,61,93,141,203,245,27,76,90,173,208,247,45,135,245,67,213,122,143,13,224,23,71,144,14,149,25,232,13,178,71,238,136,222,100,80,181,6,203,74,42,113,160,74,22,205,225,126,5,37,49,68,20,143,160,15,22,185,1,57,10,178,68,39,213,45,48,141,244,192,205,184,47,132,32,173,201,150,131,71,69,93,42,184,60,233,130,131,128,62,61,145,35,236,128,255,233,102,204,61,162,173,204,142,218,3,55,126,149,109,159,49,169,97,18,110,222,38,40,134,16,248,0,64,8,2,134,99,52,38,176,20,110,183,2,16,17,179,160,196,82,213,213,137,27,93,80,181,23,82,209,214,86,92,181,190,247,188,23,64,212,3,37,215,156,2,149,2,3,72,4,42,227,101,148,9,9,230,24,112,108,179,119,168,160,64,72,76,145,208,253,38,195,232,58,43,76,175,82,154,114,169,76,164,7,141,196,246,69,234,177,129,227,189,234,46,194,50,143,62,89,199,204,48,153,187,211,213,21,120,254,51,21,148,167,144,12,113,215,151,2,202,207,167,227,155,1,244,244,0,166,175,18,76,159,19,59,183,2,147,142,12,5,17,221,75,77,221,41,79,85,32,134,64,104,176,228,11,67,96,17,150,253,114,36,103,227,59,161,62,21,109,208,239,57,27,240,131,64,110,120,45,79,182,56,1,25,229,59,4,83,137,70,172,206,17,77,166,197,241,13,68,95,245,244,203,4,36,17,137,168,228,153,245,34,107,151,201,161,155,76,25,230,193,80,3,192,199,48,201,145,208,162,52,140,214,254,182,114,36,67,14,121,51,108,206,30,138,187,175,24,78,159,19,61,183,83,63,42,83,130,28,167,196,25,4,180,3,217,65,205,0,36,106,204,200,230,18,41,237,231,166,172,59,16,3,19,18,52,116,229,115,64,113,23,34,148,82,219,33,135,76,26,136,190,131,190,109,220,224,107,111,248,127,63,12,43,161,245,108,55,178,120,137,249,15,12,114,47,33,95,116,141,1,226,173,210,189,227,142,81,25,160,249,197,207,63,214,35,144,83,162,94,244,181,138,126,103,253,204,235,139,127,3,223,51,16,210,111,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7c391a20e766436b8c18fe98a522ddce",
							"BaseElements.AddActivityDataUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
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

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, SendEmailToCaseContactProcessMultiLanguage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,149,66,231,176,144,245,180,115,11,92,181,183,54,168,141,158,116,89,73,75,153,40,245,0,73,5,113,3,255,123,151,148,237,58,168,218,40,69,31,1,122,147,6,195,209,236,112,180,15,94,41,65,235,247,208,160,119,237,109,81,41,208,29,55,175,223,10,105,80,189,83,221,208,123,87,158,70,37,64,138,47,88,141,120,86,9,243,6,12,208,145,135,252,155,66,238,93,231,211,26,185,119,149,123,194,96,163,137,67,71,150,33,15,10,72,23,12,121,16,177,200,15,11,6,69,201,25,70,60,44,227,184,172,32,142,71,230,143,196,215,93,211,131,194,241,27,78,158,187,199,237,190,183,212,5,1,165,163,8,221,181,71,48,180,38,116,214,66,33,177,162,119,163,6,36,200,40,209,208,52,184,21,13,222,130,162,111,89,157,206,66,68,226,32,181,101,73,228,38,187,239,21,106,45,186,246,41,115,114,104,218,75,54,9,224,249,245,104,199,119,30,45,243,22,204,206,73,140,90,7,231,243,166,174,21,214,96,196,221,165,141,207,184,119,204,121,9,210,129,138,238,233,19,200,1,47,146,121,60,203,26,122,51,142,116,50,64,20,37,234,221,236,121,207,169,61,53,114,64,96,127,34,207,212,156,156,34,88,18,120,103,1,119,108,13,218,230,118,176,201,173,0,146,56,2,100,24,86,192,162,42,241,25,132,97,204,86,75,228,113,28,133,41,101,243,63,118,43,187,55,216,86,100,2,91,51,175,99,243,146,156,234,88,240,211,146,125,196,94,66,137,175,250,163,151,151,95,55,55,208,169,110,46,38,234,154,141,80,118,181,40,65,126,232,81,81,138,206,184,63,221,132,71,21,74,236,200,93,103,54,229,14,27,56,219,217,236,245,136,56,19,167,107,72,33,241,211,32,76,88,145,34,103,81,92,70,116,13,105,194,248,34,40,18,140,86,124,149,4,116,161,180,167,173,237,77,55,168,242,216,93,61,46,232,95,90,188,255,160,242,207,219,144,147,149,153,83,129,63,178,75,94,104,92,217,119,63,253,111,139,237,239,255,19,7,239,240,21,119,29,150,147,176,8,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,78,44,40,201,204,207,179,50,180,50,212,241,76,177,50,176,50,0,0,176,27,135,17,18,0,0,0 })));
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
								new Guid("6c7394db-06ff-4050-91ef-8278e21dce15")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"));
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

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, SendEmailToCaseContactProcessMultiLanguage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,205,110,211,64,16,126,21,228,115,93,197,63,249,189,85,37,160,94,104,165,70,189,224,30,38,235,177,179,98,237,181,118,55,133,16,69,130,39,128,112,228,196,35,32,4,82,5,130,67,35,94,132,39,97,118,157,154,20,5,53,32,33,176,52,210,236,231,111,191,249,217,153,185,199,4,104,253,0,10,244,6,222,8,149,2,45,51,179,127,143,11,131,234,190,146,211,202,219,243,52,42,14,130,63,197,180,198,135,41,55,119,193,0,93,153,39,63,20,18,111,144,108,215,72,188,189,196,227,6,11,77,28,186,210,235,196,237,238,56,234,248,152,134,161,31,7,89,219,239,119,195,158,31,177,160,21,132,48,142,218,189,176,102,254,74,252,80,22,21,40,172,99,56,249,204,185,163,89,101,169,1,1,204,81,184,150,229,26,140,108,18,122,88,194,88,96,74,103,163,166,72,144,81,188,160,106,112,196,11,60,1,69,177,172,142,180,16,145,50,16,218,178,4,102,102,248,164,82,168,53,151,229,109,201,137,105,81,110,178,73,0,155,227,58,157,150,203,209,50,79,192,76,156,196,17,165,181,112,89,30,228,185,194,28,12,191,216,76,226,17,206,28,111,183,254,209,133,148,94,233,12,196,20,55,98,222,172,228,16,42,83,23,84,135,39,130,226,249,100,231,90,155,142,221,86,110,72,96,117,77,222,81,115,107,13,97,135,192,11,11,212,42,215,110,226,61,60,210,199,143,75,84,167,108,130,5,212,93,59,223,39,244,39,160,209,31,204,199,216,14,90,49,139,253,46,164,204,143,89,20,248,16,67,215,239,247,227,78,196,226,40,160,46,47,206,235,60,184,174,4,204,206,154,112,171,151,87,111,200,190,144,189,39,187,92,45,191,61,123,77,206,7,178,79,171,229,215,87,171,229,213,115,242,63,146,189,37,255,197,29,231,88,96,205,188,36,123,71,246,217,201,88,182,251,65,87,105,14,236,103,159,75,230,156,129,56,174,80,209,56,184,231,104,109,31,228,27,27,96,155,164,164,52,117,233,77,147,15,24,141,20,55,52,70,27,227,68,193,104,203,109,159,79,229,84,177,245,86,233,122,189,255,104,109,255,193,50,254,206,126,109,157,240,93,38,54,253,31,102,241,111,79,198,194,91,124,7,172,30,83,0,24,6,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,4,0,252,157,29,132,13,0,0,0 })));
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

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,5,193,129,9,0,48,8,3,176,139,10,150,118,120,143,206,249,255,9,75,60,119,163,68,228,78,194,211,133,138,48,158,169,102,30,89,252,2,221,81,196,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		public SendEmailToCaseContactProcessMultiLanguage(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToCaseContactProcessMultiLanguage";
			SchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_templateId = () => { return (Guid)(new Guid("253cd392-267a-45bb-83b4-17630bcfa37b")); };
			_subject = () => { return new LocalizableString((FillEmailUserTask.Subject)); };
			_parentActivityId = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ParentActivity").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ParentActivityId") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7c391a20-e766-436b-8c18-fe98a522ddce");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToCaseContactProcessMultiLanguage, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToCaseContactProcessMultiLanguage, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid CaseId {
			get;
			set;
		}

		private Func<Guid> _templateId;
		public virtual Guid TemplateId {
			get {
				return (_templateId ?? (_templateId = () => Guid.Empty)).Invoke();
			}
			set {
				_templateId = () => { return value; };
			}
		}

		public virtual string SenderEmail {
			get;
			set;
		}

		private Func<string> _subject;
		public virtual string Subject {
			get {
				return (_subject ?? (_subject = () => null)).Invoke();
			}
			set {
				_subject = () => { return value; };
			}
		}

		private Func<Guid> _parentActivityId;
		public virtual Guid ParentActivityId {
			get {
				return (_parentActivityId ?? (_parentActivityId = () => Guid.Empty)).Invoke();
			}
			set {
				_parentActivityId = () => { return value; };
			}
		}

		public virtual bool IsMultiLanguageEnabled {
			get;
			set;
		}

		public virtual bool IsEstimateWithIconsEnabled {
			get;
			set;
		}

		public virtual bool IsMultilanguageV2Enabled {
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
					SchemaElementUId = new Guid("7f074929-411d-41a1-9f14-36b4e42641af"),
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
					SchemaElementUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
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

		private FillEmailUserTaskFlowElement _fillEmailUserTask;
		public FillEmailUserTaskFlowElement FillEmailUserTask {
			get {
				return _fillEmailUserTask ?? (_fillEmailUserTask = new FillEmailUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddActivityDataUserTaskFlowElement _addActivityDataUserTask;
		public AddActivityDataUserTaskFlowElement AddActivityDataUserTask {
			get {
				return _addActivityDataUserTask ?? (_addActivityDataUserTask = new AddActivityDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _sendMailScriptTask;
		public ProcessScriptTask SendMailScriptTask {
			get {
				return _sendMailScriptTask ?? (_sendMailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendMailScriptTask",
					SchemaElementUId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendMailScriptTaskExecute,
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
					SchemaElementUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
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

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
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
					SchemaElementUId = new Guid("ba4d73bb-1240-4a05-8f5f-158635ee29ba"),
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

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("c6a037ba-b91a-4d5c-92e1-a7eec4637e82"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("20333f00-a29d-40bd-b174-f1b74f89bf82"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("f72d3295-d03d-44df-913e-ce128e26f6eb"),
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

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("7be43985-dcda-49bd-8a77-0caecc01a550"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("2046ac4f-8c0b-4a3d-b998-d90962403018"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("a2e8ef78-e0cb-4b03-80ee-1ef683b0ed83"),
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
					SchemaElementUId = new Guid("f07aee8e-1621-486d-92b1-1591317f60c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("5880c05f-f6d8-4064-bb1f-0c7b60536fb5"),
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
					SchemaElementUId = new Guid("9b12ac39-b4ba-4c0c-82b1-cfb780881afa"),
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
					SchemaElementUId = new Guid("2978ae22-dedc-4a05-ad74-8eea4e29b03f"),
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
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FillEmailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillEmailUserTask };
			FlowElements[AddActivityDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddActivityDataUserTask };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[SendMailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendMailScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FillEmailUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "AddActivityDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendMailScriptTask", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillEmailUserTask", e.Context.SenderName));
						break;
					case "SendMailScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddActivityDataUserTask", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddActivityDataUserTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask4", e.Context.SenderName));
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ScriptTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (ConditionalSequenceFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
						break;
					case "ScriptTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ScriptTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow1", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"Contact\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"ContactId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != string.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask2", "ConditionalFlow2", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != string.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Origin").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OriginId") : Guid.Empty))==new Guid("7f9e1f1e-f46b-1410-3492-0050ba5d6c38"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"Origin\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"OriginId\") : Guid.Empty))==new Guid(\"7f9e1f1e-f46b-1410-3492-0050ba5d6c38\")", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((IsMultiLanguageEnabled) || (IsMultilanguageV2Enabled));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow2", "(IsMultiLanguageEnabled) || (IsMultilanguageV2Enabled)", result);
			return result;
		}

		private bool ConditionalSequenceFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((IsEstimateWithIconsEnabled));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway3", "ConditionalSequenceFlow3", "(IsEstimateWithIconsEnabled)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseId")) {
				writer.WriteValue("CaseId", CaseId, Guid.Empty);
			}
			if (!HasMapping("SenderEmail")) {
				writer.WriteValue("SenderEmail", SenderEmail, null);
			}
			if (!HasMapping("IsMultiLanguageEnabled")) {
				writer.WriteValue("IsMultiLanguageEnabled", IsMultiLanguageEnabled, false);
			}
			if (!HasMapping("IsEstimateWithIconsEnabled")) {
				writer.WriteValue("IsEstimateWithIconsEnabled", IsEstimateWithIconsEnabled, false);
			}
			if (!HasMapping("IsMultilanguageV2Enabled")) {
				writer.WriteValue("IsMultilanguageV2Enabled", IsMultilanguageV2Enabled, false);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("Subject")) {
				writer.WriteValue("Subject", Subject, null);
			}
			if (!HasMapping("ParentActivityId")) {
				writer.WriteValue("ParentActivityId", ParentActivityId, Guid.Empty);
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
			MetaPathParameterValues.Add("2182c543-89b6-4709-8a44-0ccc49d8c85a", () => CaseId);
			MetaPathParameterValues.Add("d30737ec-df8a-4aeb-805c-7bc8649175e6", () => TemplateId);
			MetaPathParameterValues.Add("3da60100-fb70-4440-a82a-0ee88ccc4b13", () => SenderEmail);
			MetaPathParameterValues.Add("7f0cb231-3dda-4b22-a6ea-e79291d7ee8c", () => Subject);
			MetaPathParameterValues.Add("be5104c4-7adc-4c31-a4a7-99463c431b36", () => ParentActivityId);
			MetaPathParameterValues.Add("d8ed1115-f389-47a1-bee9-8ed2415c428e", () => IsMultiLanguageEnabled);
			MetaPathParameterValues.Add("a1ceebce-05dc-410e-a7d4-682eee2c2a92", () => IsEstimateWithIconsEnabled);
			MetaPathParameterValues.Add("b65555c6-7f69-41d1-9675-aa4693ee6b54", () => IsMultilanguageV2Enabled);
			MetaPathParameterValues.Add("2240c0c2-4f40-423c-8b95-f111c72bbfd9", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("b46a95f8-c76e-49f0-a82f-3277d460a1f6", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("db33b5a6-46aa-47ff-8e4b-5e13fdb80187", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("77acc736-6e4a-4799-8893-f31e6c67dd35", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("576434f3-e5c5-4731-be98-011701f8c85c", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("8aa5b82c-3a24-4b4e-b291-b0353a2dc144", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("0b953ab2-858c-4dd9-9bce-9d641ba01668", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("de51c882-736f-4db7-9a1b-bb605ec75208", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("1a5ebf76-4ad7-4eb7-81fd-71180b9cf610", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("c4106eb8-5ed0-42c8-b84f-34b0294210ca", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("51459f74-5d40-4e53-8ac7-ffca49ce3463", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("76c7a624-b7e2-4ab7-b03b-403b54d5cf2c", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f5df9dd5-1461-4018-96ef-5e5408602213", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("4e739645-cfcf-4acb-b2c4-d98d6c2154ce", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("8453c16f-b75c-4362-9c4c-34a7a9599cbc", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("dd247f81-c60d-43ef-a529-7e9e698f5f8a", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("d72a4519-9e07-4c3a-ae50-fb5c05a32b5e", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("63abd854-a87d-4589-8a12-384eb55afc80", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("55e9058b-1352-4783-96b1-8527c49bfe42", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("0ec419a6-4bb4-40da-806a-7aff639e25bd", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("b0de42aa-d0a6-43c9-84cd-9298f4cb6c71", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("12b7121c-ee28-40f6-89c1-935e8b7d7ca7", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("df939b4e-dde0-4d27-824d-3ce613d1a8df", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("70545f3a-7add-45c7-ba78-4585c9bf7ee7", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("ba3c18dd-7276-4d59-a388-7dd72332309c", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("7569fb84-ca21-4722-9617-c42bd11f787f", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("e88f81f6-bb4f-4667-8712-8244a108432a", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("13f6b58c-3dac-47b1-8c2a-67b10c00b042", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("f661c175-85bd-46e2-be1b-f8f2696bed90", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("c3e9fc0d-0126-49b4-b41c-42ce78706d8d", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("eb5bda7b-e48e-4c43-a503-e9218b4bf960", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("1a676d4f-b1c2-4fb2-ad01-f5ebd45a6e19", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("b6d720fe-0e34-42a7-8e39-608e8b72fb38", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("89bf6187-da0e-4a92-9f82-dffbe82cc14c", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("fc3b7c87-0f42-4827-bc59-66107a5f6680", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("0a9eeba5-9cd2-4b31-b5da-2bb820239f2a", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("f82956d1-db47-4d97-8b70-cc7e3dfd605c", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("45fd680b-c0b8-4b2c-9912-97eb3cdc375e", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f8d2ec88-506d-4044-908d-a191e3892bb2", () => FillEmailUserTask.Subject);
			MetaPathParameterValues.Add("21eff95f-b71a-4567-861f-65486cfabf8f", () => FillEmailUserTask.Body);
			MetaPathParameterValues.Add("47f64290-f732-4e87-9a44-4cf2485d1240", () => FillEmailUserTask.RecordId);
			MetaPathParameterValues.Add("4f0a1a14-83f4-4436-9927-3286a76c15e2", () => FillEmailUserTask.TemplateId);
			MetaPathParameterValues.Add("5f5844ae-4b77-4818-8542-1f6474d6e62c", () => FillEmailUserTask.SysEntitySchemaId);
			MetaPathParameterValues.Add("78fa348b-febc-4c15-9ab7-8db84e2baf7a", () => AddActivityDataUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("a251d4b1-48d0-4b81-bd57-227f8c042748", () => AddActivityDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("5464c2e0-a7bf-468f-ba2c-a086e8b7cb5b", () => AddActivityDataUserTask.RecordAddMode);
			MetaPathParameterValues.Add("8d80b754-2b5d-4731-ada2-68af17a0c8be", () => AddActivityDataUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("eef95653-dcf6-49d4-b0e9-a9f6f4c8b03d", () => AddActivityDataUserTask.RecordDefValues);
			MetaPathParameterValues.Add("d07a51ae-6eef-4fae-8974-16c453d75d56", () => AddActivityDataUserTask.RecordId);
			MetaPathParameterValues.Add("8ca45dc6-c3c8-40be-8b20-95308cc51e8f", () => AddActivityDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("3c44ff41-7d4f-4045-985d-f5591d95f153", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("8f65b044-884b-49ca-9219-5baf24f17958", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("5523d04c-3e1b-4f60-9563-9e520dac2c6c", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a8f08199-d9c0-4005-9c94-7c03f7670d2e", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("ebd74111-6e32-475d-ab86-716f0976612e", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("573cfd72-52b9-4c1e-a621-58e6e1c6ce39", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("524f3776-d1c5-42c1-a379-e9b3d4ea79d5", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("8e42a1ac-c457-45b8-8e4d-7e6e530c82aa", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("0e982666-3fc9-4b3d-bf43-1c31a8e6cb53", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("ac82296a-e4a2-4f63-8ecf-fc2befdcc54e", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("2ce6abdb-47e7-4462-a89a-faa0c73eff6e", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("5e71482a-fa3d-496e-aab2-d15119381051", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("5af71371-6345-46b7-91d8-531f111fc281", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("7ee2a87a-3e6d-4e07-bf35-2fba8030ddcd", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("e505355f-473f-4baf-a0c5-a7acfe566ab9", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("65c22ff4-89c4-41cc-9507-4121365b392c", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("898740ca-c0ac-43d9-bb83-01db84a4e988", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ef68ece7-b557-4e7c-a75c-1655ae2a8984", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("580236c7-16fb-418f-95fc-61d13bf042e6", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("01c24e99-0525-4c53-bd4b-2b34f9d3766f", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("c7d73d91-0514-42af-999d-7a34d7ec0e95", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("eeb351c9-365d-423c-800b-a2a013bab823", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("71bd15f4-6282-4eae-a7e9-6faa031d959e", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("3f1dbb68-9a58-49b3-a323-5ac45052dfef", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("2056ce2f-42d8-4fd2-bf24-61ea6742c3dd", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("7f067451-f8bd-4ba8-942d-d6a482207da2", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("95cb3a8c-de47-4ebf-ab83-44e2e6e9b06e", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("a0062d8b-80ae-4931-8d0d-9e40b6beed2a", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("e646785e-110f-4438-bc03-5a65ff0404d2", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("45fdb25d-4878-4115-a5db-f8c6a0d63fdb", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("6c591f23-80f8-405f-bcf7-acb6c98329e5", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("5764dd4b-f9ff-4af0-ad7a-a37ba669478c", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("177a98fd-0f17-4427-86c0-92b3fd286f79", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("8071ca0f-90db-43d4-8161-5e54d91f00ea", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("f92969bc-781b-4b37-b423-62af4cbe765b", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3bcea3e3-3e90-4842-98a1-348ce8d75cc4", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("c90d7462-b6c8-4bda-ad55-cfa805f6475d", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("666c551a-f30d-48ef-82b5-53faef7380ca", () => ReadDataUserTask4.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseId":
					if (!hasValueToRead) break;
					CaseId = reader.GetValue<System.Guid>();
				break;
				case "SenderEmail":
					if (!hasValueToRead) break;
					SenderEmail = reader.GetValue<System.String>();
				break;
				case "IsMultiLanguageEnabled":
					if (!hasValueToRead) break;
					IsMultiLanguageEnabled = reader.GetValue<System.Boolean>();
				break;
				case "IsEstimateWithIconsEnabled":
					if (!hasValueToRead) break;
					IsEstimateWithIconsEnabled = reader.GetValue<System.Boolean>();
				break;
				case "IsMultilanguageV2Enabled":
					if (!hasValueToRead) break;
					IsMultilanguageV2Enabled = reader.GetValue<System.Boolean>();
				break;
				case "TemplateId":
					if (!hasValueToRead) break;
					TemplateId = reader.GetValue<System.Guid>();
				break;
				case "Subject":
					if (!hasValueToRead) break;
					Subject = reader.GetValue<System.String>();
				break;
				case "ParentActivityId":
					if (!hasValueToRead) break;
					ParentActivityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SendMailScriptTaskExecute(ProcessExecutingContext context) {
			var activityId = AddActivityDataUserTask.RecordId;
			var emailClientFactory = ClassFactory.Get<EmailClientFactory>(new ConstructorArgument("userConnection", UserConnection));
			var activityEmailSender = new ActivityEmailSender(emailClientFactory, UserConnection);
			activityEmailSender.Send(activityId);
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localSubject = (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null))).ToUpper().IndexOf("RE: ") == 0 ? ((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null)) : "RE: " + ((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null));
			Subject = (System.String)localSubject;
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var contactEmail = ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email");
			var emailTemplateMacrosManager = new EmailWithMacrosManager(UserConnection);
			if (IsMultilanguageV2Enabled) {
				emailTemplateMacrosManager.SendEmailTo(CaseId, TemplateId, contactEmail);
			} else {
				var emailTemplateStore = new EmailTemplateStore(UserConnection);
				var emailTemplateLanguageHelper = new EmailTemplateLanguageHelper(CaseId, UserConnection);
				var languageId = emailTemplateLanguageHelper.GetLanguageId(TemplateId);
				var templateEntity = emailTemplateStore.GetTemplate(TemplateId, languageId);
				emailTemplateMacrosManager.SendEmailTo(CaseId, templateEntity.PrimaryColumnValue, contactEmail);
			}
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			IsMultiLanguageEnabled = UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage");
			IsMultilanguageV2Enabled = UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2");
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			var emailWithMacrosSender = new Terrasoft.Configuration.EmailWithMacrosManager(UserConnection);
			emailWithMacrosSender.SendEmail(CaseId, TemplateId);
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			IsEstimateWithIconsEnabled = (TemplateId == Terrasoft.Configuration.CaseConsts.ConfirmationOfClosingRequestTemplateId 
					&& UserConnection.GetIsFeatureEnabled("EstimateWithIcons"));
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
			var cloneItem = (SendEmailToCaseContactProcessMultiLanguage)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

