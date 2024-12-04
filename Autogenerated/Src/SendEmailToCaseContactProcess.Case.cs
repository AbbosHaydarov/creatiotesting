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

	#region Class: SendEmailToCaseContactProcessSchema

	/// <exclude/>
	public class SendEmailToCaseContactProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToCaseContactProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToCaseContactProcessSchema(SendEmailToCaseContactProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToCaseContactProcess";
			UId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
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
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			Version = 0;
			PackageUId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2182c543-89b6-4709-8a44-0ccc49d8c85a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3da60100-fb70-4440-a82a-0ee88ccc4b13"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateParentActivityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be5104c4-7adc-4c31-a4a7-99463c431b36"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ParentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{b59a15ea-751e-4fd8-8281-f1a3dc7190ff}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseIdParameter());
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateSenderEmailParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateParentActivityIdParameter());
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,111,219,48,12,253,43,131,207,85,97,59,254,144,115,27,178,108,200,101,45,208,160,151,185,7,90,162,19,97,254,130,164,116,203,2,255,247,81,118,226,165,67,134,102,187,172,190,88,122,120,124,124,164,200,131,39,42,48,230,51,212,232,205,189,53,106,13,166,45,237,237,71,85,89,212,159,116,187,235,188,27,207,160,86,80,169,31,40,71,124,41,149,253,0,22,40,228,144,255,82,200,189,121,126,89,35,247,110,114,79,89,172,13,113,40,68,6,41,47,35,201,89,26,38,5,139,210,24,24,164,65,204,210,0,18,95,22,25,150,60,26,153,127,18,95,180,117,7,26,199,28,131,124,57,28,215,251,206,81,3,2,196,64,81,166,109,142,224,204,153,48,203,6,138,10,37,221,173,222,33,65,86,171,154,170,193,181,170,241,30,52,229,114,58,173,131,136,84,66,101,28,171,194,210,46,191,119,26,141,81,109,243,154,185,106,87,55,231,108,18,192,233,122,180,227,15,30,29,243,30,236,118,144,88,145,173,126,112,249,126,179,209,184,1,171,158,207,77,124,197,253,192,187,174,127,20,32,233,149,30,161,218,225,89,206,151,149,44,160,179,99,65,99,122,34,104,181,217,94,93,235,212,177,215,202,13,9,236,78,228,43,53,47,214,16,38,4,62,59,96,84,57,29,115,239,203,202,220,125,107,80,63,136,45,214,48,118,237,233,150,208,223,128,73,127,126,8,3,30,138,56,154,49,158,21,9,117,210,207,24,135,40,98,190,16,34,202,36,23,60,134,254,105,244,161,76,87,193,254,113,74,183,0,131,239,142,61,115,63,130,120,198,57,248,65,200,130,56,76,89,20,66,194,120,26,35,203,74,12,125,25,202,89,28,83,108,239,62,247,18,237,70,9,168,238,58,212,244,210,67,167,253,203,51,250,98,184,93,253,186,109,237,88,213,212,63,103,103,240,114,154,146,146,23,178,148,179,148,9,193,157,25,178,149,249,101,202,146,2,33,201,178,0,68,80,144,25,90,112,215,226,135,118,167,197,113,161,204,184,217,255,180,177,255,97,15,255,102,181,46,14,247,53,195,250,86,198,112,245,86,38,173,247,250,159,251,130,65,241,63,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				UId = new Guid("7295cdb3-7ab5-4bee-89d9-c56484594ef4"),
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
				UId = new Guid("54930385-8650-4d03-90c1-c4d8d893f9c0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,19,49,20,253,149,104,214,117,53,15,207,195,217,161,18,80,55,180,162,85,55,164,139,107,207,117,106,49,47,217,78,33,68,249,119,174,103,218,144,162,160,6,54,32,49,43,207,209,185,199,231,190,188,141,84,3,206,125,128,22,163,121,116,139,214,130,235,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,235,9,95,212,198,191,5,15,20,178,93,254,80,88,70,243,229,113,141,101,116,182,140,140,199,214,17,135,66,210,92,228,74,10,193,114,0,100,60,78,129,85,53,22,76,171,68,168,36,209,160,117,53,49,127,37,126,209,183,3,88,156,238,24,229,245,120,188,221,12,129,154,16,160,70,138,113,125,247,4,102,193,132,91,116,32,27,172,233,223,219,53,18,228,173,105,41,27,188,53,45,94,131,165,187,130,78,31,32,34,105,104,92,96,53,168,253,226,235,96,209,57,211,119,175,153,107,214,109,119,200,38,1,220,255,62,217,137,71,143,129,121,13,254,97,148,184,36,91,187,209,229,155,213,202,226,10,188,121,60,52,241,25,55,35,239,180,250,81,64,77,93,186,131,102,141,7,119,190,204,228,2,6,63,37,52,93,79,4,107,86,15,39,231,186,175,216,107,233,166,4,14,207,228,19,53,143,230,144,22,4,62,6,96,82,121,62,46,163,79,151,238,234,75,135,246,70,61,96,11,83,213,238,207,9,253,9,88,52,216,98,231,231,219,50,150,144,149,85,205,84,25,231,140,139,56,101,80,86,5,75,85,90,115,93,164,153,18,201,142,2,246,134,230,219,26,243,68,85,85,202,202,172,208,140,215,178,100,2,18,201,164,44,226,28,85,153,167,113,21,66,22,157,55,126,51,77,194,124,91,100,162,208,188,64,166,184,160,40,45,19,86,229,113,205,170,148,87,133,208,58,230,50,219,221,79,233,26,55,52,176,185,219,103,245,17,161,158,41,112,56,11,149,160,181,178,206,207,194,50,205,122,61,163,26,175,27,111,186,213,140,70,169,65,21,122,73,243,215,121,80,126,148,11,61,37,145,90,100,154,151,152,48,212,85,197,120,82,8,38,69,89,178,82,137,74,102,188,206,74,41,104,246,194,23,70,164,95,25,5,205,213,128,150,70,112,28,129,248,248,242,188,216,186,208,24,219,247,126,42,247,190,177,135,118,158,39,88,101,28,74,169,18,38,80,165,140,3,71,38,11,228,84,70,81,11,41,36,38,152,147,31,122,124,66,210,55,253,218,170,167,101,119,211,171,243,71,175,201,95,120,35,126,103,237,143,46,222,41,139,244,159,173,200,229,63,52,211,187,104,247,29,172,145,81,107,69,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				UId = new Guid("d807090c-ac42-41d3-96e3-707643e37743"),
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
				UId = new Guid("11ca4e50-4405-4b31-a193-e8434aa0f27e"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,27,71,18,253,21,130,9,176,47,106,162,239,23,189,37,142,23,43,192,222,24,118,54,47,150,31,170,171,171,109,238,82,164,49,28,37,208,10,250,247,61,67,73,241,101,19,90,74,32,203,6,196,7,18,51,236,75,77,117,157,58,85,103,206,231,223,142,103,111,101,126,56,255,73,134,129,182,155,62,46,30,109,6,89,60,27,54,44,219,237,226,201,134,105,181,252,47,213,149,60,163,129,78,100,148,225,103,90,157,202,246,201,114,59,30,204,62,156,54,63,152,127,251,203,238,223,249,225,203,243,249,209,40,39,255,58,106,88,189,229,210,51,7,173,116,45,65,121,145,162,136,169,169,210,106,208,222,248,90,178,198,100,222,172,78,79,214,79,101,164,103,52,190,153,31,158,207,119,171,97,1,223,184,107,114,70,165,222,146,242,173,146,34,173,189,18,111,92,53,41,56,239,204,252,226,96,190,229,55,114,66,187,77,223,77,102,239,75,203,206,42,242,204,202,87,109,84,45,45,168,76,198,178,183,4,219,202,52,249,106,252,187,137,47,191,121,121,180,253,241,215,181,12,47,118,235,30,118,90,109,229,213,2,119,63,186,241,155,115,14,207,83,215,92,45,76,117,173,17,118,179,216,55,10,41,73,197,22,211,146,72,230,139,87,223,188,154,118,108,203,237,219,21,157,253,252,255,27,191,56,173,255,22,30,47,135,189,253,192,245,239,15,60,63,190,60,193,227,249,225,241,31,157,225,213,239,165,197,31,158,226,199,7,120,60,63,56,158,191,216,156,14,60,173,232,112,241,195,123,22,238,54,217,13,249,232,242,250,196,112,103,125,186,90,93,221,249,129,70,186,30,120,125,123,211,150,125,41,237,104,253,226,250,160,118,171,232,171,143,250,157,175,235,207,165,109,127,101,218,83,90,211,107,25,254,9,7,188,179,253,55,43,127,130,27,175,23,14,76,46,116,163,21,25,4,139,231,152,20,149,72,202,101,215,40,82,39,238,188,155,253,92,186,12,178,102,249,147,134,61,151,237,206,219,19,84,174,236,154,92,117,49,191,184,56,120,31,64,158,40,235,40,86,57,207,86,121,135,208,47,8,107,37,136,169,226,173,99,31,211,94,0,5,95,12,59,215,167,25,0,16,83,86,20,82,81,205,103,163,133,130,231,16,239,2,64,79,54,155,255,156,190,93,164,80,125,115,165,170,16,218,180,66,139,42,55,248,215,117,95,40,228,86,34,167,133,216,236,76,19,86,240,174,86,173,27,108,163,117,135,215,76,139,90,138,203,28,63,133,155,171,253,190,227,113,249,203,114,60,155,77,224,88,60,62,161,229,234,1,74,247,2,165,106,75,208,201,116,149,132,10,82,127,180,211,201,147,42,166,212,238,146,179,189,219,125,80,186,73,228,220,10,74,22,132,99,147,104,128,192,192,32,176,138,42,209,103,165,169,245,154,184,198,222,218,94,40,69,147,37,5,237,84,6,245,40,31,108,83,68,14,151,61,69,228,248,28,92,13,247,201,69,143,87,114,34,235,241,240,60,39,199,110,162,217,96,188,224,73,189,85,37,37,120,82,87,29,138,215,186,26,123,241,33,121,89,35,189,151,208,85,77,56,35,31,144,248,114,196,225,197,224,115,228,78,181,231,254,105,242,250,7,173,219,74,102,112,57,6,140,50,235,155,97,6,11,151,171,217,175,203,241,205,236,132,120,216,108,23,223,111,218,217,3,40,239,5,148,172,187,246,113,34,130,104,1,132,138,116,155,189,4,85,188,41,141,115,48,177,154,207,202,111,181,129,111,181,7,31,185,90,167,44,1,76,153,102,149,24,238,192,90,110,161,247,253,252,102,171,137,210,178,138,32,106,64,91,163,184,204,25,15,88,41,115,69,213,233,164,124,33,5,226,84,66,104,3,111,33,221,192,249,222,163,204,200,150,148,70,101,152,153,217,87,227,110,80,32,202,186,201,240,183,237,37,176,30,112,116,47,56,106,173,58,50,34,74,39,201,104,75,64,110,53,129,230,154,22,176,196,84,188,212,246,89,113,100,170,53,49,163,184,67,239,1,114,11,201,128,155,144,242,75,172,86,11,136,203,245,178,23,71,232,93,194,68,202,42,107,36,5,111,168,162,78,4,21,100,10,186,24,239,168,228,250,69,144,91,213,22,13,160,73,170,104,96,199,75,198,147,6,70,69,220,24,137,13,29,101,203,245,35,114,3,188,122,54,61,170,90,125,71,234,155,200,45,25,212,35,214,123,20,250,217,59,75,211,148,199,235,17,165,227,163,157,143,14,207,91,237,86,219,169,42,5,84,149,79,40,69,42,119,175,90,150,80,77,142,206,106,243,105,184,62,23,106,51,222,172,71,226,113,214,16,75,139,191,47,135,237,56,91,226,232,102,155,62,27,100,123,186,26,151,235,215,24,180,90,161,243,91,110,214,15,117,235,61,182,128,95,28,69,58,212,102,32,56,8,31,185,35,122,147,65,221,26,44,43,169,196,129,42,89,180,135,251,53,148,196,144,81,60,130,62,88,228,6,228,40,8,19,157,84,183,192,52,210,3,55,227,190,16,138,180,38,91,14,30,53,117,169,96,243,164,11,54,2,250,244,68,143,176,3,254,167,79,99,238,17,109,101,118,212,30,184,241,171,108,252,140,73,13,131,112,242,54,65,51,132,196,7,0,66,18,48,28,163,49,129,165,112,187,21,128,136,152,5,69,150,170,174,78,220,232,130,170,189,144,138,182,182,226,170,245,189,231,189,0,162,30,40,185,230,20,168,20,24,64,34,80,25,15,163,76,72,48,199,128,99,155,189,67,13,5,82,98,138,132,254,55,25,70,223,89,97,122,149,210,148,75,101,34,61,168,36,182,47,82,143,13,28,239,85,119,17,150,121,116,202,58,102,134,201,220,157,174,174,192,243,55,212,80,158,66,52,196,89,95,74,40,63,158,142,175,55,160,167,7,48,125,149,96,186,73,236,220,10,76,58,50,52,68,244,47,53,117,167,60,85,129,28,2,169,193,146,47,12,137,69,88,246,11,146,156,141,239,132,250,84,180,65,199,231,108,192,43,129,220,240,88,158,108,113,2,50,202,119,8,166,18,141,88,157,35,218,76,139,237,27,136,190,234,233,221,4,68,17,137,168,228,153,245,34,107,151,201,161,159,76,25,230,193,80,3,192,199,48,9,146,80,163,52,140,214,254,182,130,36,67,16,121,189,25,206,30,138,187,175,24,78,55,137,158,219,233,31,149,41,65,144,83,226,12,2,218,129,236,160,103,0,18,53,102,100,115,137,148,246,115,83,214,29,136,129,9,9,42,186,242,57,160,184,11,17,90,169,237,16,68,38,21,68,223,65,223,54,14,248,217,19,254,215,255,63,188,192,250,204,1,94,116,141,1,98,173,210,189,227,68,81,7,160,213,197,235,30,235,17,182,41,81,47,250,90,53,191,179,238,229,213,197,255,0,187,250,69,63,95,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,193,142,155,48,20,252,23,206,235,21,193,6,146,189,85,217,180,183,54,82,162,158,114,121,152,103,98,45,196,200,54,171,166,171,252,123,109,147,164,137,196,106,217,74,81,91,237,13,70,227,97,222,120,120,47,17,175,193,152,175,208,96,244,16,173,81,107,48,74,216,251,207,178,182,168,191,104,213,181,209,93,100,80,75,168,229,79,44,123,124,81,74,251,8,22,220,145,151,205,111,133,77,244,176,25,214,216,68,119,155,72,90,108,140,227,184,35,83,42,146,2,242,9,65,145,48,194,98,90,16,40,184,32,200,4,229,105,202,75,72,211,158,249,154,248,92,53,45,104,236,191,17,228,69,120,92,239,91,79,157,56,128,7,138,52,106,119,4,169,55,97,22,59,40,106,44,221,187,213,29,58,200,106,217,184,105,112,45,27,92,130,118,223,242,58,202,67,142,36,160,54,158,85,163,176,139,31,173,70,99,164,218,189,101,174,238,154,221,37,219,9,224,249,245,104,39,14,30,61,115,9,118,27,36,122,173,67,240,249,169,170,52,86,96,229,243,165,141,39,220,7,230,184,4,221,129,210,221,211,119,168,59,188,72,230,122,150,57,180,182,31,233,100,192,81,180,172,182,163,231,61,167,246,214,200,137,3,219,19,121,164,230,224,20,201,212,129,207,30,8,199,230,96,124,110,7,159,28,229,37,159,98,156,19,198,121,74,24,99,156,20,60,79,9,82,90,210,25,38,49,205,39,31,177,91,171,189,89,2,127,130,10,239,199,215,108,92,152,239,174,217,181,145,255,183,110,62,194,90,85,146,67,253,173,69,237,82,12,222,227,225,50,92,181,40,243,83,43,101,87,124,139,13,156,29,185,91,234,145,224,227,116,13,57,100,113,158,208,140,20,57,10,194,82,206,8,208,60,35,98,146,20,25,178,153,152,101,137,51,228,86,181,119,190,82,157,230,199,250,154,126,71,255,209,238,253,11,173,127,223,146,28,108,205,152,22,220,100,157,252,163,113,173,134,254,251,155,39,119,211,63,227,16,29,126,1,249,234,133,188,185,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				UId = new Guid("18948b43-85ae-4330-be87-8f1c167989ca"),
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
				UId = new Guid("1457d571-f048-4ae5-8570-1050eea8797d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,79,227,48,16,253,43,43,159,9,106,62,250,121,67,80,16,151,5,137,138,203,134,195,212,153,164,22,78,28,217,14,208,173,242,223,119,28,183,161,172,186,162,172,132,32,39,231,233,249,205,155,231,153,13,227,18,140,249,9,37,178,25,91,160,214,96,84,110,79,47,133,180,168,175,180,106,106,118,194,12,106,1,82,252,198,204,227,243,76,216,11,176,64,87,54,233,171,66,202,102,233,97,141,148,157,164,76,88,44,13,113,232,202,100,148,12,199,203,120,20,96,22,69,65,18,230,195,96,58,142,38,65,204,195,65,24,193,50,30,78,34,207,252,151,248,185,42,107,208,232,107,116,242,121,119,92,172,107,71,13,9,224,29,69,24,85,109,193,216,153,48,243,10,150,18,51,250,183,186,65,130,172,22,37,117,131,11,81,226,45,104,170,229,116,148,131,136,148,131,52,142,37,49,183,243,151,90,163,49,66,85,239,153,147,77,89,237,179,73,0,251,223,173,157,65,231,209,49,111,193,174,58,137,107,178,213,118,46,207,138,66,99,1,86,60,237,155,120,196,117,199,59,46,63,186,144,209,43,221,131,108,112,175,230,219,78,206,161,182,190,33,95,158,8,90,20,171,163,123,237,19,123,175,221,136,192,122,71,62,82,243,96,15,209,136,192,39,7,120,149,221,49,101,191,174,205,205,115,133,250,142,175,176,4,159,218,195,41,161,127,1,189,254,108,179,196,97,56,72,120,18,140,33,227,65,194,227,48,128,4,198,193,116,154,140,98,158,196,33,165,220,62,120,31,194,212,18,214,247,125,57,146,193,202,254,0,78,175,36,44,189,76,235,62,151,176,42,4,7,121,83,163,166,23,236,18,28,28,158,189,55,67,235,250,210,74,89,239,182,207,229,172,215,223,155,0,42,70,139,233,162,185,83,141,230,219,69,48,126,35,255,107,211,190,96,127,62,178,18,7,135,242,152,33,203,190,195,248,124,246,100,180,172,253,3,18,83,210,84,203,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
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
				UId = new Guid("abc3fae2-412a-4e2b-828e-49c9b0b3ce97"),
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
				UId = new Guid("e654965c-2862-4862-8043-2912627b828b"),
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
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9ddc1a0b-a466-47d2-82b5-83aa49438994"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(83, 101));
			schemaFlow.PolylinePointPositions.Add(new Point(83, 87));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("a2e8ef78-e0cb-4b03-80ee-1ef683b0ed83"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{6396f46e-c49f-4fb1-850d-824869ff04b3}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(430, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(240, 87));
			schemaFlow.PolylinePointPositions.Add(new Point(240, 107));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("35dcb8df-533d-48b8-aa1d-33128db9836d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(438, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(154, 30));
			schemaFlow.PolylinePointPositions.Add(new Point(1186, 30));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f07aee8e-1621-486d-92b1-1591317f60c2"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{b0200417-902a-4e81-a5c4-edc6274b9d8b}].[Parameter:{e88f81f6-bb4f-4667-8712-8244a108432a}].[EntityColumn:{dbf202ec-c444-479b-bcf4-d8e5b1863201}]#] != string.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(522, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(325, 332));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("598e616a-5180-40f1-a0ab-9f92b088b9bb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(528, 197),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(325, 50));
			schemaFlow.PolylinePointPositions.Add(new Point(1186, 50));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("44c5fa4c-0096-49bc-ad9a-40266638707f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(722, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(628, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(494, 332));
			schemaFlow.PolylinePointPositions.Add(new Point(494, 152));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e72d381c-dce6-4ad4-8896-113ee36b7e48"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(722, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(1136, 307));
			schemaFlow.PolylinePointPositions.Add(new Point(1136, 193));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("261cef82-4b0a-4d18-8b5b-aa42470fb2fd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(945, 152));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("5880c05f-f6d8-4064-bb1f-0c7b60536fb5"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{a93cb111-ce30-4da4-89ec-d2a2f3dd71c4}]#]==[#Lookup.b17869fe-43f9-487a-af82-b7626f1fc810.7f9e1f1e-f46b-1410-3492-0050ba5d6c38#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(945, 438));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dae6eec2-f54b-41ae-aabb-69a51383693f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 1,
				ContainerUId = new Guid("dae6eec2-f54b-41ae-aabb-69a51383693f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"Start1",
				Position = new Point(20, 88),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"Terminate1",
				Position = new Point(1173, 180),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ReadDataUserTask2",
				Position = new Point(291, 80),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"FillEmailUserTask",
				Position = new Point(520, 125),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ReadDataUserTask3",
				Position = new Point(400, 305),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ExclusiveGateway1",
				Position = new Point(665, 125),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ReadDataUserTask4",
				Position = new Point(658, 411),
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
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"FormulaTask1",
				Position = new Point(808, 411),
				ResultParameterMetaPath = @"7f0cb231-3dda-4b22-a6ea-e79291d7ee8c",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,144,177,106,195,48,20,69,127,69,36,75,66,43,35,89,178,165,24,66,7,227,193,147,75,50,6,15,79,210,83,98,176,229,34,187,180,197,228,223,235,102,236,39,100,61,112,184,156,187,187,108,47,245,212,124,5,140,103,123,195,1,10,15,253,132,109,178,210,127,160,234,113,192,48,23,139,202,140,245,10,129,130,55,140,202,84,167,212,164,10,168,211,42,207,52,183,144,235,244,190,10,239,16,97,192,25,99,177,28,50,107,4,104,75,29,74,69,37,26,79,193,104,65,165,196,20,115,60,24,150,227,159,82,133,185,155,127,202,177,255,28,66,177,72,103,61,3,193,169,242,110,181,156,89,39,25,147,20,37,23,134,171,76,72,193,239,237,182,221,39,117,112,248,221,248,221,230,84,21,100,243,74,206,115,236,194,181,28,135,15,136,221,52,134,164,137,174,11,208,215,215,48,70,44,97,194,61,57,30,9,35,111,228,25,14,32,107,244,163,156,188,60,69,207,47,137,154,8,140,150,2,0,0 }
			};
			
			return FormulaTask;
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
			return new SendEmailToCaseContactProcess(userConnection);
		}

		public override object Clone() {
			return new SendEmailToCaseContactProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("010a69df-55e1-475c-937c-0184594f2e41"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToCaseContactProcess

	/// <exclude/>
	public class SendEmailToCaseContactProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToCaseContactProcess process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = false;
				SchemaElementUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,111,219,48,12,253,43,131,207,85,97,59,254,144,115,27,178,108,200,101,45,208,160,151,185,7,90,162,19,97,254,130,164,116,203,2,255,247,81,118,226,165,67,134,102,187,172,190,88,122,120,124,124,164,200,131,39,42,48,230,51,212,232,205,189,53,106,13,166,45,237,237,71,85,89,212,159,116,187,235,188,27,207,160,86,80,169,31,40,71,124,41,149,253,0,22,40,228,144,255,82,200,189,121,126,89,35,247,110,114,79,89,172,13,113,40,68,6,41,47,35,201,89,26,38,5,139,210,24,24,164,65,204,210,0,18,95,22,25,150,60,26,153,127,18,95,180,117,7,26,199,28,131,124,57,28,215,251,206,81,3,2,196,64,81,166,109,142,224,204,153,48,203,6,138,10,37,221,173,222,33,65,86,171,154,170,193,181,170,241,30,52,229,114,58,173,131,136,84,66,101,28,171,194,210,46,191,119,26,141,81,109,243,154,185,106,87,55,231,108,18,192,233,122,180,227,15,30,29,243,30,236,118,144,88,145,173,126,112,249,126,179,209,184,1,171,158,207,77,124,197,253,192,187,174,127,20,32,233,149,30,161,218,225,89,206,151,149,44,160,179,99,65,99,122,34,104,181,217,94,93,235,212,177,215,202,13,9,236,78,228,43,53,47,214,16,38,4,62,59,96,84,57,29,115,239,203,202,220,125,107,80,63,136,45,214,48,118,237,233,150,208,223,128,73,127,126,8,3,30,138,56,154,49,158,21,9,117,210,207,24,135,40,98,190,16,34,202,36,23,60,134,254,105,244,161,76,87,193,254,113,74,183,0,131,239,142,61,115,63,130,120,198,57,248,65,200,130,56,76,89,20,66,194,120,26,35,203,74,12,125,25,202,89,28,83,108,239,62,247,18,237,70,9,168,238,58,212,244,210,67,167,253,203,51,250,98,184,93,253,186,109,237,88,213,212,63,103,103,240,114,154,146,146,23,178,148,179,148,9,193,157,25,178,149,249,101,202,146,2,33,201,178,0,68,80,144,25,90,112,215,226,135,118,167,197,113,161,204,184,217,255,180,177,255,97,15,255,102,181,46,14,247,53,195,250,86,198,112,245,86,38,173,247,250,159,251,130,65,241,63,6,0,0 })));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = false;
				SchemaElementUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,19,49,20,253,149,104,214,117,53,15,207,195,217,161,18,80,55,180,162,85,55,164,139,107,207,117,106,49,47,217,78,33,68,249,119,174,103,218,144,162,160,6,54,32,49,43,207,209,185,199,231,190,188,141,84,3,206,125,128,22,163,121,116,139,214,130,235,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,235,9,95,212,198,191,5,15,20,178,93,254,80,88,70,243,229,113,141,101,116,182,140,140,199,214,17,135,66,210,92,228,74,10,193,114,0,100,60,78,129,85,53,22,76,171,68,168,36,209,160,117,53,49,127,37,126,209,183,3,88,156,238,24,229,245,120,188,221,12,129,154,16,160,70,138,113,125,247,4,102,193,132,91,116,32,27,172,233,223,219,53,18,228,173,105,41,27,188,53,45,94,131,165,187,130,78,31,32,34,105,104,92,96,53,168,253,226,235,96,209,57,211,119,175,153,107,214,109,119,200,38,1,220,255,62,217,137,71,143,129,121,13,254,97,148,184,36,91,187,209,229,155,213,202,226,10,188,121,60,52,241,25,55,35,239,180,250,81,64,77,93,186,131,102,141,7,119,190,204,228,2,6,63,37,52,93,79,4,107,86,15,39,231,186,175,216,107,233,166,4,14,207,228,19,53,143,230,144,22,4,62,6,96,82,121,62,46,163,79,151,238,234,75,135,246,70,61,96,11,83,213,238,207,9,253,9,88,52,216,98,231,231,219,50,150,144,149,85,205,84,25,231,140,139,56,101,80,86,5,75,85,90,115,93,164,153,18,201,142,2,246,134,230,219,26,243,68,85,85,202,202,172,208,140,215,178,100,2,18,201,164,44,226,28,85,153,167,113,21,66,22,157,55,126,51,77,194,124,91,100,162,208,188,64,166,184,160,40,45,19,86,229,113,205,170,148,87,133,208,58,230,50,219,221,79,233,26,55,52,176,185,219,103,245,17,161,158,41,112,56,11,149,160,181,178,206,207,194,50,205,122,61,163,26,175,27,111,186,213,140,70,169,65,21,122,73,243,215,121,80,126,148,11,61,37,145,90,100,154,151,152,48,212,85,197,120,82,8,38,69,89,178,82,137,74,102,188,206,74,41,104,246,194,23,70,164,95,25,5,205,213,128,150,70,112,28,129,248,248,242,188,216,186,208,24,219,247,126,42,247,190,177,135,118,158,39,88,101,28,74,169,18,38,80,165,140,3,71,38,11,228,84,70,81,11,41,36,38,152,147,31,122,124,66,210,55,253,218,170,167,101,119,211,171,243,71,175,201,95,120,35,126,103,237,143,46,222,41,139,244,159,173,200,229,63,52,211,187,104,247,29,172,145,81,107,69,7,0,0 })));
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

			public FillEmailUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FillEmailUserTask";
				IsLogging = false;
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

			public AddActivityDataUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddActivityDataUserTask";
				IsLogging = false;
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,27,71,18,253,21,130,9,176,47,106,162,239,23,189,37,142,23,43,192,222,24,118,54,47,150,31,170,171,171,109,238,82,164,49,28,37,208,10,250,247,61,67,73,241,101,19,90,74,32,203,6,196,7,18,51,236,75,77,117,157,58,85,103,206,231,223,142,103,111,101,126,56,255,73,134,129,182,155,62,46,30,109,6,89,60,27,54,44,219,237,226,201,134,105,181,252,47,213,149,60,163,129,78,100,148,225,103,90,157,202,246,201,114,59,30,204,62,156,54,63,152,127,251,203,238,223,249,225,203,243,249,209,40,39,255,58,106,88,189,229,210,51,7,173,116,45,65,121,145,162,136,169,169,210,106,208,222,248,90,178,198,100,222,172,78,79,214,79,101,164,103,52,190,153,31,158,207,119,171,97,1,223,184,107,114,70,165,222,146,242,173,146,34,173,189,18,111,92,53,41,56,239,204,252,226,96,190,229,55,114,66,187,77,223,77,102,239,75,203,206,42,242,204,202,87,109,84,45,45,168,76,198,178,183,4,219,202,52,249,106,252,187,137,47,191,121,121,180,253,241,215,181,12,47,118,235,30,118,90,109,229,213,2,119,63,186,241,155,115,14,207,83,215,92,45,76,117,173,17,118,179,216,55,10,41,73,197,22,211,146,72,230,139,87,223,188,154,118,108,203,237,219,21,157,253,252,255,27,191,56,173,255,22,30,47,135,189,253,192,245,239,15,60,63,190,60,193,227,249,225,241,31,157,225,213,239,165,197,31,158,226,199,7,120,60,63,56,158,191,216,156,14,60,173,232,112,241,195,123,22,238,54,217,13,249,232,242,250,196,112,103,125,186,90,93,221,249,129,70,186,30,120,125,123,211,150,125,41,237,104,253,226,250,160,118,171,232,171,143,250,157,175,235,207,165,109,127,101,218,83,90,211,107,25,254,9,7,188,179,253,55,43,127,130,27,175,23,14,76,46,116,163,21,25,4,139,231,152,20,149,72,202,101,215,40,82,39,238,188,155,253,92,186,12,178,102,249,147,134,61,151,237,206,219,19,84,174,236,154,92,117,49,191,184,56,120,31,64,158,40,235,40,86,57,207,86,121,135,208,47,8,107,37,136,169,226,173,99,31,211,94,0,5,95,12,59,215,167,25,0,16,83,86,20,82,81,205,103,163,133,130,231,16,239,2,64,79,54,155,255,156,190,93,164,80,125,115,165,170,16,218,180,66,139,42,55,248,215,117,95,40,228,86,34,167,133,216,236,76,19,86,240,174,86,173,27,108,163,117,135,215,76,139,90,138,203,28,63,133,155,171,253,190,227,113,249,203,114,60,155,77,224,88,60,62,161,229,234,1,74,247,2,165,106,75,208,201,116,149,132,10,82,127,180,211,201,147,42,166,212,238,146,179,189,219,125,80,186,73,228,220,10,74,22,132,99,147,104,128,192,192,32,176,138,42,209,103,165,169,245,154,184,198,222,218,94,40,69,147,37,5,237,84,6,245,40,31,108,83,68,14,151,61,69,228,248,28,92,13,247,201,69,143,87,114,34,235,241,240,60,39,199,110,162,217,96,188,224,73,189,85,37,37,120,82,87,29,138,215,186,26,123,241,33,121,89,35,189,151,208,85,77,56,35,31,144,248,114,196,225,197,224,115,228,78,181,231,254,105,242,250,7,173,219,74,102,112,57,6,140,50,235,155,97,6,11,151,171,217,175,203,241,205,236,132,120,216,108,23,223,111,218,217,3,40,239,5,148,172,187,246,113,34,130,104,1,132,138,116,155,189,4,85,188,41,141,115,48,177,154,207,202,111,181,129,111,181,7,31,185,90,167,44,1,76,153,102,149,24,238,192,90,110,161,247,253,252,102,171,137,210,178,138,32,106,64,91,163,184,204,25,15,88,41,115,69,213,233,164,124,33,5,226,84,66,104,3,111,33,221,192,249,222,163,204,200,150,148,70,101,152,153,217,87,227,110,80,32,202,186,201,240,183,237,37,176,30,112,116,47,56,106,173,58,50,34,74,39,201,104,75,64,110,53,129,230,154,22,176,196,84,188,212,246,89,113,100,170,53,49,163,184,67,239,1,114,11,201,128,155,144,242,75,172,86,11,136,203,245,178,23,71,232,93,194,68,202,42,107,36,5,111,168,162,78,4,21,100,10,186,24,239,168,228,250,69,144,91,213,22,13,160,73,170,104,96,199,75,198,147,6,70,69,220,24,137,13,29,101,203,245,35,114,3,188,122,54,61,170,90,125,71,234,155,200,45,25,212,35,214,123,20,250,217,59,75,211,148,199,235,17,165,227,163,157,143,14,207,91,237,86,219,169,42,5,84,149,79,40,69,42,119,175,90,150,80,77,142,206,106,243,105,184,62,23,106,51,222,172,71,226,113,214,16,75,139,191,47,135,237,56,91,226,232,102,155,62,27,100,123,186,26,151,235,215,24,180,90,161,243,91,110,214,15,117,235,61,182,128,95,28,69,58,212,102,32,56,8,31,185,35,122,147,65,221,26,44,43,169,196,129,42,89,180,135,251,53,148,196,144,81,60,130,62,88,228,6,228,40,8,19,157,84,183,192,52,210,3,55,227,190,16,138,180,38,91,14,30,53,117,169,96,243,164,11,54,2,250,244,68,143,176,3,254,167,79,99,238,17,109,101,118,212,30,184,241,171,108,252,140,73,13,131,112,242,54,65,51,132,196,7,0,66,18,48,28,163,49,129,165,112,187,21,128,136,152,5,69,150,170,174,78,220,232,130,170,189,144,138,182,182,226,170,245,189,231,189,0,162,30,40,185,230,20,168,20,24,64,34,80,25,15,163,76,72,48,199,128,99,155,189,67,13,5,82,98,138,132,254,55,25,70,223,89,97,122,149,210,148,75,101,34,61,168,36,182,47,82,143,13,28,239,85,119,17,150,121,116,202,58,102,134,201,220,157,174,174,192,243,55,212,80,158,66,52,196,89,95,74,40,63,158,142,175,55,160,167,7,48,125,149,96,186,73,236,220,10,76,58,50,52,68,244,47,53,117,167,60,85,129,28,2,169,193,146,47,12,137,69,88,246,11,146,156,141,239,132,250,84,180,65,199,231,108,192,43,129,220,240,88,158,108,113,2,50,202,119,8,166,18,141,88,157,35,218,76,139,237,27,136,190,234,233,221,4,68,17,137,168,228,153,245,34,107,151,201,161,159,76,25,230,193,80,3,192,199,48,9,146,80,163,52,140,214,254,182,130,36,67,16,121,189,25,206,30,138,187,175,24,78,55,137,158,219,233,31,149,41,65,144,83,226,12,2,218,129,236,160,103,0,18,53,102,100,115,137,148,246,115,83,214,29,136,129,9,9,42,186,242,57,160,184,11,17,90,169,237,16,68,38,21,68,223,65,223,54,14,248,217,19,254,215,255,63,188,192,250,204,1,94,116,141,1,98,173,210,189,227,68,81,7,160,213,197,235,30,235,17,182,41,81,47,250,90,53,191,179,238,229,213,197,255,0,187,250,69,63,95,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "010a69df55e1475c937c0184594f2e41",
							"BaseElements.AddActivityDataUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57");
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

			public ReadDataUserTask3FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = false;
				SchemaElementUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,193,142,155,48,20,252,23,206,235,21,193,6,146,189,85,217,180,183,54,82,162,158,114,121,152,103,98,45,196,200,54,171,166,171,252,123,109,147,164,137,196,106,217,74,81,91,237,13,70,227,97,222,120,120,47,17,175,193,152,175,208,96,244,16,173,81,107,48,74,216,251,207,178,182,168,191,104,213,181,209,93,100,80,75,168,229,79,44,123,124,81,74,251,8,22,220,145,151,205,111,133,77,244,176,25,214,216,68,119,155,72,90,108,140,227,184,35,83,42,146,2,242,9,65,145,48,194,98,90,16,40,184,32,200,4,229,105,202,75,72,211,158,249,154,248,92,53,45,104,236,191,17,228,69,120,92,239,91,79,157,56,128,7,138,52,106,119,4,169,55,97,22,59,40,106,44,221,187,213,29,58,200,106,217,184,105,112,45,27,92,130,118,223,242,58,202,67,142,36,160,54,158,85,163,176,139,31,173,70,99,164,218,189,101,174,238,154,221,37,219,9,224,249,245,104,39,14,30,61,115,9,118,27,36,122,173,67,240,249,169,170,52,86,96,229,243,165,141,39,220,7,230,184,4,221,129,210,221,211,119,168,59,188,72,230,122,150,57,180,182,31,233,100,192,81,180,172,182,163,231,61,167,246,214,200,137,3,219,19,121,164,230,224,20,201,212,129,207,30,8,199,230,96,124,110,7,159,28,229,37,159,98,156,19,198,121,74,24,99,156,20,60,79,9,82,90,210,25,38,49,205,39,31,177,91,171,189,89,2,127,130,10,239,199,215,108,92,152,239,174,217,181,145,255,183,110,62,194,90,85,146,67,253,173,69,237,82,12,222,227,225,50,92,181,40,243,83,43,101,87,124,139,13,156,29,185,91,234,145,224,227,116,13,57,100,113,158,208,140,20,57,10,194,82,206,8,208,60,35,98,146,20,25,178,153,152,101,137,51,228,86,181,119,190,82,157,230,199,250,154,126,71,255,209,238,253,11,173,127,223,146,28,108,205,152,22,220,100,157,252,163,113,173,134,254,251,155,39,119,211,63,227,16,29,126,1,249,234,133,188,185,8,0,0 })));
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

			public ReadDataUserTask4FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = false;
				SchemaElementUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,79,227,48,16,253,43,43,159,9,106,62,250,121,67,80,16,151,5,137,138,203,134,195,212,153,164,22,78,28,217,14,208,173,242,223,119,28,183,161,172,186,162,172,132,32,39,231,233,249,205,155,231,153,13,227,18,140,249,9,37,178,25,91,160,214,96,84,110,79,47,133,180,168,175,180,106,106,118,194,12,106,1,82,252,198,204,227,243,76,216,11,176,64,87,54,233,171,66,202,102,233,97,141,148,157,164,76,88,44,13,113,232,202,100,148,12,199,203,120,20,96,22,69,65,18,230,195,96,58,142,38,65,204,195,65,24,193,50,30,78,34,207,252,151,248,185,42,107,208,232,107,116,242,121,119,92,172,107,71,13,9,224,29,69,24,85,109,193,216,153,48,243,10,150,18,51,250,183,186,65,130,172,22,37,117,131,11,81,226,45,104,170,229,116,148,131,136,148,131,52,142,37,49,183,243,151,90,163,49,66,85,239,153,147,77,89,237,179,73,0,251,223,173,157,65,231,209,49,111,193,174,58,137,107,178,213,118,46,207,138,66,99,1,86,60,237,155,120,196,117,199,59,46,63,186,144,209,43,221,131,108,112,175,230,219,78,206,161,182,190,33,95,158,8,90,20,171,163,123,237,19,123,175,221,136,192,122,71,62,82,243,96,15,209,136,192,39,7,120,149,221,49,101,191,174,205,205,115,133,250,142,175,176,4,159,218,195,41,161,127,1,189,254,108,179,196,97,56,72,120,18,140,33,227,65,194,227,48,128,4,198,193,116,154,140,98,158,196,33,165,220,62,120,31,194,212,18,214,247,125,57,146,193,202,254,0,78,175,36,44,189,76,235,62,151,176,42,4,7,121,83,163,166,23,236,18,28,28,158,189,55,67,235,250,210,74,89,239,182,207,229,172,215,223,155,0,42,70,139,233,162,185,83,141,230,219,69,48,126,35,255,107,211,190,96,127,62,178,18,7,135,242,152,33,203,190,195,248,124,246,100,180,172,253,3,18,83,210,84,203,5,0,0 })));
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

		public SendEmailToCaseContactProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToCaseContactProcess";
			SchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_subject = () => { return new LocalizableString((FillEmailUserTask.Subject)); };
			_parentActivityId = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ParentActivity").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ParentActivityId") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToCaseContactProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToCaseContactProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid TemplateId {
			get;
			set;
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
					Script = FormulaTask1Execute,
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
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
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

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseId")) {
				writer.WriteValue("CaseId", CaseId, Guid.Empty);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("SenderEmail")) {
				writer.WriteValue("SenderEmail", SenderEmail, null);
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
			MetaPathParameterValues.Add("7295cdb3-7ab5-4bee-89d9-c56484594ef4", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("54930385-8650-4d03-90c1-c4d8d893f9c0", () => ReadDataUserTask1.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("d807090c-ac42-41d3-96e3-707643e37743", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("11ca4e50-4405-4b31-a193-e8434aa0f27e", () => ReadDataUserTask2.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("18948b43-85ae-4330-be87-8f1c167989ca", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1457d571-f048-4ae5-8570-1050eea8797d", () => ReadDataUserTask3.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("abc3fae2-412a-4e2b-828e-49c9b0b3ce97", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("e654965c-2862-4862-8043-2912627b828b", () => ReadDataUserTask4.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseId":
					if (!hasValueToRead) break;
					CaseId = reader.GetValue<System.Guid>();
				break;
				case "TemplateId":
					if (!hasValueToRead) break;
					TemplateId = reader.GetValue<System.Guid>();
				break;
				case "SenderEmail":
					if (!hasValueToRead) break;
					SenderEmail = reader.GetValue<System.String>();
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
			var localSubject = (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null))).IndexOf("RE: ", StringComparison.OrdinalIgnoreCase) == 0 ? ((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null)) : "RE: " + ((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null));
			Subject = (System.String)localSubject;
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
			var cloneItem = (SendEmailToCaseContactProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

