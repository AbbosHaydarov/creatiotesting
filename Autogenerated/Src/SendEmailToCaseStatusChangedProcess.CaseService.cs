namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
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

	#region Class: SendEmailToCaseStatusChangedProcessSchema

	/// <exclude/>
	public class SendEmailToCaseStatusChangedProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToCaseStatusChangedProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToCaseStatusChangedProcessSchema(SendEmailToCaseStatusChangedProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToCaseStatusChangedProcess";
			UId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119");
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
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateIsCloseAndExitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("94883989-46c7-4825-b827-2c151618e017"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"IsCloseAndExit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailTemplateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0d056708-d60e-42dd-86c1-f5efcfd86bef"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"EmailTemplate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e9f06e37-ba23-48d4-832c-0745bb5b6289"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCloseStatusIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9fc90727-5ac3-4ea8-a541-e3baca1ade4f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"CloseStatusId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.99f35013-6b7a-47d6-b440-e3f1a0ba991c.3e7f420c-f46b-1410-fc9a-0050ba5d6c38#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailSenderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6adbdb8d-22e9-4e5f-91e9-ac5d02328433"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"EmailSender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsCloseAndExitParameter());
			Parameters.Add(CreateEmailTemplateParameter());
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateCloseStatusIdParameter());
			Parameters.Add(CreateEmailSenderParameter());
		}

		protected virtual void InitializeSubProcessSendEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var caseIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2ea97d45-fb65-4126-9177-dd5587f15336"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			caseIdParameter.SourceValue = new ProcessSchemaParameterValue(caseIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{e9f06e37-ba23-48d4-832c-0745bb5b6289}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(caseIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f984456-427a-4177-9163-9b73842be371"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			templateIdParameter.SourceValue = new ProcessSchemaParameterValue(templateIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{0d056708-d60e-42dd-86c1-f5efcfd86bef}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var senderEmailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4ea09cbc-77f4-49ed-932b-bfc84d1131fb"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText")
			};
			senderEmailParameter.SourceValue = new ProcessSchemaParameterValue(senderEmailParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{6adbdb8d-22e9-4e5f-91e9-ac5d02328433}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(senderEmailParameter);
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e9652116-1fbc-423a-809f-5abee6bc90cb"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText")
			};
			subjectParameter.SourceValue = new ProcessSchemaParameterValue(subjectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var parentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("46ad5752-9bc9-40b5-8f41-4568b7813102"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			parentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(parentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(parentActivityIdParameter);
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b45094d5-b09f-4ac1-94fb-eb15b5624972"),
				ContainerUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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
				UId = new Guid("0ea1b5d8-4e6c-43d5-a7b7-f9bb4610ae41"),
				ContainerUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeStartSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ce8c0266-efa5-44a9-bff8-26d3da1ebeff"),
				ContainerUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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
				UId = new Guid("021c651a-8af8-4170-b888-138386e1329f"),
				ContainerUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("810b9374-7a6a-46db-896a-f030e43430f9"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
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
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e718202-15ca-44b5-b786-1c807f779f66"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
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
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ff8853b-20dd-41d4-8339-8a3541af22e2"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,86,81,79,219,48,16,254,43,40,207,51,114,156,196,137,121,155,24,155,120,1,4,104,47,148,7,199,62,151,104,105,18,217,46,27,67,253,239,59,39,109,87,182,2,41,210,6,244,165,237,233,243,249,187,243,125,119,119,31,169,90,58,119,34,103,16,29,68,151,96,173,116,173,241,251,159,171,218,131,253,98,219,121,23,125,136,28,216,74,214,213,79,208,131,253,72,87,254,147,244,18,143,220,79,126,123,152,68,7,147,237,62,38,209,135,73,84,121,152,57,196,224,17,158,49,83,196,12,136,49,121,78,82,109,40,41,40,213,68,113,99,226,130,209,132,107,53,32,31,115,126,216,206,58,105,97,184,163,119,111,250,159,151,119,93,128,198,104,80,61,164,114,109,179,52,38,129,132,59,106,100,89,131,198,255,222,206,1,77,222,86,51,140,6,46,171,25,156,73,139,119,5,63,109,48,33,200,200,218,5,84,13,198,31,253,232,44,56,87,181,205,115,228,234,249,172,217,68,163,3,88,255,93,210,161,61,199,128,60,147,254,166,119,113,140,180,22,61,203,143,211,169,133,169,244,213,237,38,137,111,112,215,227,198,229,15,15,104,124,165,175,178,158,195,198,157,15,35,57,148,157,31,2,26,174,71,128,173,166,55,163,99,93,103,236,185,112,25,26,187,21,120,164,207,173,49,48,142,198,219,96,24,188,172,126,78,162,171,99,119,250,189,1,123,161,110,96,38,135,172,93,239,163,245,15,195,81,13,51,104,252,193,189,200,203,162,164,25,39,138,114,65,82,145,107,34,117,156,145,140,97,74,57,228,66,241,124,129,7,214,132,14,238,21,20,138,50,206,9,24,153,145,52,149,130,148,198,20,132,113,157,104,25,67,9,198,44,174,7,226,149,235,106,121,247,117,205,239,80,58,216,115,94,250,185,219,83,55,178,153,130,222,63,7,213,90,189,204,124,248,66,92,134,79,88,36,52,33,194,196,72,139,243,156,136,76,0,41,75,78,33,201,179,130,50,131,133,130,159,80,66,200,85,153,68,16,30,103,138,164,180,136,137,128,12,207,170,60,166,73,158,231,130,155,167,211,125,220,60,38,163,244,125,202,232,162,79,241,56,41,141,75,223,150,50,140,159,214,210,138,67,208,19,24,176,208,40,24,202,112,29,105,40,135,77,216,67,217,133,86,121,245,166,132,215,71,188,33,188,101,181,162,82,18,40,75,108,70,90,113,20,81,193,72,145,38,49,209,133,66,137,48,3,90,13,25,92,95,120,14,109,7,77,40,158,13,135,59,56,250,75,88,191,29,162,38,174,195,179,51,150,101,185,54,130,72,37,37,73,179,146,18,33,25,170,22,68,169,147,84,96,143,140,159,81,133,59,153,215,245,99,202,96,219,148,193,222,188,50,250,246,56,78,24,227,50,184,187,48,62,162,101,218,0,60,45,141,182,241,82,249,97,111,232,31,98,197,176,239,121,117,59,173,148,172,79,59,176,114,233,152,110,207,253,131,71,11,131,195,182,173,223,162,195,254,166,85,232,101,28,107,145,166,42,20,34,246,248,68,25,34,10,154,18,86,66,94,50,157,112,144,20,147,136,155,81,136,253,162,157,91,181,220,68,220,176,18,189,104,213,121,133,5,102,151,157,100,235,86,48,166,217,188,219,249,253,111,167,241,43,12,218,93,103,231,35,19,233,37,143,254,96,118,140,109,245,59,247,242,87,104,209,176,107,215,253,47,205,108,17,45,126,1,55,20,2,244,219,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("84e64196-ae90-4d27-ba05-56b7d0cb5cf6"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,165,146,193,110,219,48,12,134,95,101,16,122,140,2,201,150,45,57,215,245,18,160,45,130,165,235,101,222,129,22,169,214,128,99,7,178,51,160,11,252,238,147,85,123,105,138,238,52,29,100,136,228,79,254,248,204,51,187,25,94,143,196,54,236,145,188,135,190,115,195,250,107,231,105,189,243,157,165,190,95,223,117,22,154,250,55,84,13,237,192,195,129,6,242,79,208,156,168,191,171,251,97,245,229,90,198,86,236,230,87,204,178,205,143,51,219,14,116,248,190,197,208,157,20,90,13,185,228,152,38,146,43,204,128,23,153,70,142,70,83,106,133,33,172,138,32,182,93,115,58,180,247,52,192,14,134,23,182,57,179,216,45,52,208,34,79,4,10,193,73,17,112,101,80,242,194,161,229,42,211,137,179,104,80,201,138,141,43,214,219,23,58,64,28,122,17,75,169,195,92,87,112,147,232,44,72,82,197,141,146,146,75,155,231,82,102,150,10,139,147,120,174,191,8,167,32,214,253,177,129,215,167,207,114,199,43,36,239,179,231,242,141,108,201,54,229,191,216,206,223,125,180,124,77,247,35,216,146,173,74,182,239,78,222,78,29,69,120,220,190,179,21,135,196,146,15,207,133,100,136,180,167,166,153,35,183,48,192,82,184,132,59,172,93,77,184,109,247,11,192,216,69,204,135,127,114,45,231,205,219,255,200,238,161,133,103,242,15,1,192,197,251,95,151,143,1,227,210,184,74,138,76,104,233,184,38,40,184,162,60,225,97,21,194,50,201,162,114,169,14,63,217,37,81,253,141,28,121,106,45,93,27,147,121,69,105,158,73,110,28,37,92,201,44,236,4,162,224,96,68,138,42,55,41,98,58,235,251,72,123,90,225,217,215,132,106,100,227,248,115,252,3,236,27,126,200,54,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("033a6a7e-a736-40d7-b07b-7decc010d850"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess subprocesssendemail = CreateSubProcessSendEmailSubProcess();
			FlowElements.Add(subprocesssendemail);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaScriptTask scripttask = CreateScriptTaskScriptTask();
			FlowElements.Add(scripttask);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fcb1629b-22ff-42cb-9266-b81588ed68d3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("f9180d1b-7e24-4b75-811a-70caff864c67"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(487, 72));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("21cdafae-cfe7-4c14-85dd-a45603176746"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(734, 72));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("ebcf97b5-1631-42e6-8413-edda66493717"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{94883989-46c7-4825-b827-2c151618e017}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("5a22b753-52b0-43ce-9a7b-c55286215695"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("815b13ec-93a8-4af3-a0f5-cbff738b1263"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(320, 325));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("936b82a8-012d-4b83-b3d5-481528a4b911"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("87200ec3-22b2-494e-824f-744d1f9062d8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87200ec3-22b2-494e-824f-744d1f9062d8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(82, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(82, 312),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"ScriptTask",
				Position = new Point(286, 177),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,89,221,111,211,58,20,127,46,18,255,67,232,3,74,165,42,112,247,10,155,4,93,199,173,116,55,118,219,238,242,128,120,8,169,187,89,74,147,98,59,131,10,241,191,223,115,142,237,196,78,156,174,101,99,87,186,34,182,207,247,207,231,195,189,79,69,52,73,37,155,179,172,20,171,217,42,58,141,62,84,124,149,76,55,91,181,123,243,252,217,61,236,103,169,98,183,165,216,133,119,165,74,85,37,195,123,92,94,86,185,226,121,90,220,86,233,45,155,22,233,215,156,225,201,27,201,196,164,44,10,150,41,94,22,201,7,166,102,242,130,1,35,97,15,197,195,233,38,229,249,37,147,18,40,137,205,63,134,205,112,4,236,103,114,146,151,146,189,43,86,211,31,92,1,203,117,154,75,6,27,124,29,197,11,149,10,181,224,183,69,154,255,149,212,166,189,112,53,28,69,63,159,63,27,180,76,15,210,1,207,95,29,182,39,191,201,246,164,197,86,251,9,141,73,165,239,1,160,91,50,33,82,89,174,85,2,190,90,243,219,74,164,228,46,115,238,6,60,203,21,103,50,232,63,223,197,227,104,184,96,224,43,244,233,178,68,253,62,22,11,138,220,228,14,220,202,72,62,57,150,175,227,144,58,218,48,130,3,238,77,127,176,172,82,165,0,45,11,246,189,87,211,189,50,59,42,186,110,67,85,6,158,168,100,94,21,49,45,119,98,175,68,133,161,31,8,6,10,23,246,147,220,139,255,45,170,175,215,162,204,0,74,181,62,9,202,162,224,184,66,107,216,94,112,136,149,3,42,92,101,242,155,177,118,90,40,174,118,139,236,142,109,210,127,43,38,118,45,75,18,247,192,101,90,0,102,5,4,0,37,145,139,129,83,242,110,181,154,148,121,181,41,226,161,246,73,104,103,98,110,30,237,105,160,204,153,44,243,123,102,142,128,66,65,102,73,115,208,161,37,171,244,193,171,116,195,246,16,211,201,225,40,193,99,1,181,202,66,165,153,10,105,252,241,123,193,4,109,188,122,133,91,23,60,87,76,72,60,18,227,247,68,0,168,152,94,253,196,213,221,117,42,64,4,30,137,245,226,164,220,108,83,193,101,89,44,119,91,150,76,191,85,105,14,190,155,173,134,45,124,88,179,50,88,212,254,54,246,192,101,208,223,15,226,11,239,180,67,14,23,185,168,242,124,132,64,247,114,94,115,6,153,163,94,198,222,255,210,188,98,111,241,246,159,53,193,2,85,9,165,78,98,60,140,129,246,190,37,247,195,253,48,147,175,101,153,159,197,109,128,80,4,137,95,3,234,3,25,181,208,162,153,128,199,94,52,50,116,82,32,85,171,237,10,236,55,23,228,134,62,186,41,232,156,229,233,142,173,174,74,197,215,28,92,12,171,195,17,114,24,64,166,80,224,1,184,158,231,64,137,177,214,234,3,185,84,49,133,197,28,252,116,199,4,67,111,227,253,5,136,206,36,97,36,54,4,53,160,98,31,45,154,24,82,134,41,44,75,182,217,230,32,74,243,40,98,218,31,116,152,244,37,54,100,190,96,226,158,103,140,84,148,9,249,164,194,77,215,188,229,54,7,233,227,232,209,236,167,82,241,13,109,206,217,183,138,73,165,57,19,95,10,205,96,160,67,144,232,124,201,116,170,252,21,49,200,96,77,152,50,125,117,143,129,181,165,208,176,36,46,37,222,242,35,120,80,86,168,57,208,181,107,244,56,181,236,12,154,250,211,187,22,206,186,201,181,219,81,4,50,112,152,3,38,141,238,89,170,168,224,247,180,200,216,251,29,194,95,35,206,88,48,48,25,67,83,226,70,139,141,201,115,193,60,100,88,160,23,26,122,168,233,42,187,187,16,229,230,252,125,8,185,218,51,3,244,39,20,224,82,66,93,158,148,43,118,206,214,221,206,11,15,234,66,237,158,91,40,193,139,219,86,87,33,88,187,96,239,160,70,42,5,39,169,171,160,40,118,238,177,22,49,32,143,76,60,33,112,151,150,165,150,164,241,7,127,142,145,192,218,65,135,147,241,224,190,99,200,237,247,1,164,70,174,201,22,173,232,79,42,33,128,22,87,209,10,243,137,103,151,28,66,57,178,252,49,6,228,186,165,216,193,165,148,44,14,249,108,28,149,149,234,120,125,100,225,122,136,154,72,69,102,118,184,24,77,160,87,105,115,74,239,205,29,134,63,191,177,177,231,241,127,191,156,54,18,128,199,115,204,161,116,35,98,73,218,143,142,142,247,91,77,120,22,138,251,112,81,109,183,37,116,179,58,57,81,42,5,179,180,163,76,11,252,38,220,113,105,197,232,223,120,91,26,93,155,254,234,228,241,13,150,155,124,231,85,94,55,92,39,110,151,226,85,128,224,9,36,189,193,201,35,184,75,117,172,217,105,53,57,39,71,119,57,160,180,109,116,26,193,227,222,174,154,238,157,46,11,231,92,98,119,142,142,36,42,100,55,122,58,197,172,86,84,143,116,155,58,174,39,190,63,36,167,110,122,225,182,212,45,85,221,238,49,55,116,16,143,92,35,66,247,126,39,77,243,215,108,5,210,47,229,222,48,35,112,117,85,168,179,215,250,118,123,64,177,168,237,18,125,126,253,101,95,249,235,52,28,182,149,10,207,199,78,87,229,201,91,192,16,100,59,172,62,104,76,59,4,193,234,211,225,109,103,235,191,89,190,165,236,113,176,16,159,210,171,93,237,188,172,101,175,65,169,52,187,139,226,142,18,17,47,250,60,108,147,109,135,134,202,159,183,114,116,36,52,87,27,132,46,67,223,66,100,111,87,102,0,119,159,163,195,80,153,197,102,56,233,196,134,84,53,11,109,78,99,71,35,195,213,55,179,93,106,218,182,141,91,26,36,215,2,58,72,177,115,136,52,95,83,70,6,161,164,237,185,217,147,160,49,28,31,242,146,19,108,251,29,148,103,77,125,6,41,182,76,39,55,42,187,42,191,155,150,17,238,10,13,36,46,16,86,154,239,244,177,131,121,80,63,237,242,70,132,55,39,219,57,101,239,41,183,97,12,159,104,234,136,177,136,175,188,241,60,76,69,35,139,153,204,13,221,90,39,96,237,134,207,95,108,103,226,208,63,38,35,183,71,239,241,94,238,97,126,51,121,5,67,156,121,134,210,190,211,141,76,199,63,78,49,153,211,51,145,49,206,113,147,61,141,120,244,106,128,195,230,176,74,64,77,96,28,230,7,211,226,14,122,69,235,204,135,81,90,231,54,74,109,46,83,204,108,97,33,77,23,249,4,83,244,158,65,186,153,57,29,59,208,199,151,188,128,105,81,154,1,216,141,43,37,128,80,50,229,80,32,107,240,194,95,45,219,204,230,222,92,142,150,208,93,108,52,120,80,128,206,214,238,101,0,41,198,197,193,49,183,238,160,235,190,216,197,137,235,169,254,34,110,180,23,208,128,69,167,103,214,38,252,220,87,81,234,126,13,141,198,97,246,144,166,13,213,242,91,54,155,229,2,26,251,48,116,17,86,184,118,53,8,115,137,107,120,61,5,186,30,141,45,87,225,35,144,245,168,55,159,254,71,159,126,128,62,168,103,95,59,225,203,108,82,93,91,99,247,89,203,153,216,5,147,208,15,82,7,10,81,234,1,58,160,196,59,119,26,153,102,213,214,144,2,66,138,244,104,216,140,62,218,137,207,196,3,222,189,84,25,31,146,79,140,231,199,81,192,89,33,159,91,58,29,201,32,217,177,88,240,25,119,155,157,63,17,198,167,72,167,71,99,62,74,165,9,155,205,120,58,162,7,101,60,190,217,176,21,7,93,142,202,121,115,63,231,205,255,64,206,155,89,197,194,121,47,168,183,159,249,186,243,144,125,233,120,112,86,193,134,231,50,205,68,41,77,211,23,238,4,246,229,214,160,130,222,189,83,248,32,139,218,252,46,234,76,88,149,216,53,47,75,93,123,155,223,212,90,179,22,201,175,177,129,179,51,12,89,150,17,190,183,2,50,89,15,116,250,159,92,91,47,79,120,26,194,213,154,139,15,66,192,2,86,228,26,30,125,97,125,81,137,123,182,115,134,11,20,245,242,229,97,191,11,235,151,112,134,65,157,129,93,240,203,217,168,254,113,146,28,214,132,251,137,33,18,228,222,27,16,207,73,251,127,184,196,87,188,230,165,254,240,223,55,221,133,255,1,58,196,173,22,203,31,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateSubProcessSendEmailSubProcess() {
			ProcessSchemaSubProcess schemaSubProcessSendEmail = new ProcessSchemaSubProcess(this) {
				UId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"SubProcessSendEmail",
				Position = new Point(591, 45),
				SchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeSubProcessSendEmailParameters(schemaSubProcessSendEmail);
			return schemaSubProcessSendEmail;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"Terminate1",
				Position = new Point(721, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(191, 298),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"ExclusiveGateway1",
				Position = new Point(460, 177),
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
				UId = new Guid("fb058002-0bf1-4e72-950d-847a882e3c69"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e8b887e-ebaa-40ce-be6c-6b5e1191a3e4"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b964c921-e7ab-4448-9709-966667751d2e"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToCaseStatusChangedProcess(userConnection);
		}

		public override object Clone() {
			return new SendEmailToCaseStatusChangedProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22405112-0a8c-4444-870f-deb07a0f7277"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToCaseStatusChangedProcess

	/// <exclude/>
	public class SendEmailToCaseStatusChangedProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToCaseStatusChangedProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SubProcessSendEmailFlowElement

		/// <exclude/>
		public class SubProcessSendEmailFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public SubProcessSendEmailFlowElement(UserConnection userConnection, SendEmailToCaseStatusChangedProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			}

			#endregion

			#region Properties: Public

			public Guid CaseId {
				get {
					return GetParameterValue<Guid>("CaseId");
				}
				set {
					SetParameterValue("CaseId", value);
				}
			}

			public Guid TemplateId {
				get {
					return GetParameterValue<Guid>("TemplateId");
				}
				set {
					SetParameterValue("TemplateId", value);
				}
			}

			public string SenderEmail {
				get {
					return GetParameterValue<string>("SenderEmail");
				}
				set {
					SetParameterValue("SenderEmail", value);
				}
			}

			public string Subject {
				get {
					return GetParameterValue<string>("Subject");
				}
				set {
					SetParameterValue("Subject", value);
				}
			}

			public Guid ParentActivityId {
				get {
					return GetParameterValue<Guid>("ParentActivityId");
				}
				set {
					SetParameterValue("ParentActivityId", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (SendEmailToCaseStatusChangedProcess)owner;
				Name = "SubProcessSendEmail";
				SerializeToDB = true;
				IsLogging = false;
				SchemaElementUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (SendEmailToCaseStatusChangedProcess)Owner;
				SetParameterValue("CaseId", (Guid)((process.CaseRecordId)));
				SetParameterValue("TemplateId", (Guid)((process.EmailTemplate)));
				SetParameterValue("SenderEmail", new LocalizableString((process.EmailSender)));
			}

			#endregion

		}

		#endregion

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, SendEmailToCaseStatusChangedProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = false;
				SchemaElementUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,86,81,79,219,48,16,254,43,40,207,51,114,156,196,137,121,155,24,155,120,1,4,104,47,148,7,199,62,151,104,105,18,217,46,27,67,253,239,59,39,109,87,182,2,41,210,6,244,165,237,233,243,249,187,243,125,119,119,31,169,90,58,119,34,103,16,29,68,151,96,173,116,173,241,251,159,171,218,131,253,98,219,121,23,125,136,28,216,74,214,213,79,208,131,253,72,87,254,147,244,18,143,220,79,126,123,152,68,7,147,237,62,38,209,135,73,84,121,152,57,196,224,17,158,49,83,196,12,136,49,121,78,82,109,40,41,40,213,68,113,99,226,130,209,132,107,53,32,31,115,126,216,206,58,105,97,184,163,119,111,250,159,151,119,93,128,198,104,80,61,164,114,109,179,52,38,129,132,59,106,100,89,131,198,255,222,206,1,77,222,86,51,140,6,46,171,25,156,73,139,119,5,63,109,48,33,200,200,218,5,84,13,198,31,253,232,44,56,87,181,205,115,228,234,249,172,217,68,163,3,88,255,93,210,161,61,199,128,60,147,254,166,119,113,140,180,22,61,203,143,211,169,133,169,244,213,237,38,137,111,112,215,227,198,229,15,15,104,124,165,175,178,158,195,198,157,15,35,57,148,157,31,2,26,174,71,128,173,166,55,163,99,93,103,236,185,112,25,26,187,21,120,164,207,173,49,48,142,198,219,96,24,188,172,126,78,162,171,99,119,250,189,1,123,161,110,96,38,135,172,93,239,163,245,15,195,81,13,51,104,252,193,189,200,203,162,164,25,39,138,114,65,82,145,107,34,117,156,145,140,97,74,57,228,66,241,124,129,7,214,132,14,238,21,20,138,50,206,9,24,153,145,52,149,130,148,198,20,132,113,157,104,25,67,9,198,44,174,7,226,149,235,106,121,247,117,205,239,80,58,216,115,94,250,185,219,83,55,178,153,130,222,63,7,213,90,189,204,124,248,66,92,134,79,88,36,52,33,194,196,72,139,243,156,136,76,0,41,75,78,33,201,179,130,50,131,133,130,159,80,66,200,85,153,68,16,30,103,138,164,180,136,137,128,12,207,170,60,166,73,158,231,130,155,167,211,125,220,60,38,163,244,125,202,232,162,79,241,56,41,141,75,223,150,50,140,159,214,210,138,67,208,19,24,176,208,40,24,202,112,29,105,40,135,77,216,67,217,133,86,121,245,166,132,215,71,188,33,188,101,181,162,82,18,40,75,108,70,90,113,20,81,193,72,145,38,49,209,133,66,137,48,3,90,13,25,92,95,120,14,109,7,77,40,158,13,135,59,56,250,75,88,191,29,162,38,174,195,179,51,150,101,185,54,130,72,37,37,73,179,146,18,33,25,170,22,68,169,147,84,96,143,140,159,81,133,59,153,215,245,99,202,96,219,148,193,222,188,50,250,246,56,78,24,227,50,184,187,48,62,162,101,218,0,60,45,141,182,241,82,249,97,111,232,31,98,197,176,239,121,117,59,173,148,172,79,59,176,114,233,152,110,207,253,131,71,11,131,195,182,173,223,162,195,254,166,85,232,101,28,107,145,166,42,20,34,246,248,68,25,34,10,154,18,86,66,94,50,157,112,144,20,147,136,155,81,136,253,162,157,91,181,220,68,220,176,18,189,104,213,121,133,5,102,151,157,100,235,86,48,166,217,188,219,249,253,111,167,241,43,12,218,93,103,231,35,19,233,37,143,254,96,118,140,109,245,59,247,242,87,104,209,176,107,215,253,47,205,108,17,45,126,1,55,20,2,244,219,13,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,146,193,110,219,48,12,134,95,101,16,122,140,2,201,150,45,57,215,245,18,160,45,130,165,235,101,222,129,22,169,214,128,99,7,178,51,160,11,252,238,147,85,123,105,138,238,52,29,100,136,228,79,254,248,204,51,187,25,94,143,196,54,236,145,188,135,190,115,195,250,107,231,105,189,243,157,165,190,95,223,117,22,154,250,55,84,13,237,192,195,129,6,242,79,208,156,168,191,171,251,97,245,229,90,198,86,236,230,87,204,178,205,143,51,219,14,116,248,190,197,208,157,20,90,13,185,228,152,38,146,43,204,128,23,153,70,142,70,83,106,133,33,172,138,32,182,93,115,58,180,247,52,192,14,134,23,182,57,179,216,45,52,208,34,79,4,10,193,73,17,112,101,80,242,194,161,229,42,211,137,179,104,80,201,138,141,43,214,219,23,58,64,28,122,17,75,169,195,92,87,112,147,232,44,72,82,197,141,146,146,75,155,231,82,102,150,10,139,147,120,174,191,8,167,32,214,253,177,129,215,167,207,114,199,43,36,239,179,231,242,141,108,201,54,229,191,216,206,223,125,180,124,77,247,35,216,146,173,74,182,239,78,222,78,29,69,120,220,190,179,21,135,196,146,15,207,133,100,136,180,167,166,153,35,183,48,192,82,184,132,59,172,93,77,184,109,247,11,192,216,69,204,135,127,114,45,231,205,219,255,200,238,161,133,103,242,15,1,192,197,251,95,151,143,1,227,210,184,74,138,76,104,233,184,38,40,184,162,60,225,97,21,194,50,201,162,114,169,14,63,217,37,81,253,141,28,121,106,45,93,27,147,121,69,105,158,73,110,28,37,92,201,44,236,4,162,224,96,68,138,42,55,41,98,58,235,251,72,123,90,225,217,215,132,106,100,227,248,115,252,3,236,27,126,200,54,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "224051120a8c4444870fdeb07a0f7277",
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

		public SendEmailToCaseStatusChangedProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToCaseStatusChangedProcess";
			SchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_closeStatusId = () => { return (Guid)(new Guid("3e7f420c-f46b-1410-fc9a-0050ba5d6c38")); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToCaseStatusChangedProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToCaseStatusChangedProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual bool IsCloseAndExit {
			get;
			set;
		}

		public virtual Guid EmailTemplate {
			get;
			set;
		}

		public virtual Guid CaseRecordId {
			get;
			set;
		}

		private Func<Guid> _closeStatusId;
		public virtual Guid CloseStatusId {
			get {
				return (_closeStatusId ?? (_closeStatusId = () => Guid.Empty)).Invoke();
			}
			set {
				_closeStatusId = () => { return value; };
			}
		}

		public virtual string EmailSender {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal2;
		public ProcessStartSignalEvent StartSignal2 {
			get {
				return _startSignal2 ?? (_startSignal2 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal2",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask;
		public ProcessScriptTask ScriptTask {
			get {
				return _scriptTask ?? (_scriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask",
					SchemaElementUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTaskExecute,
				});
			}
		}

		private SubProcessSendEmailFlowElement _subProcessSendEmail;
		public SubProcessSendEmailFlowElement SubProcessSendEmail {
			get {
				return _subProcessSendEmail ?? ((_subProcessSendEmail) = new SubProcessSendEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
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

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("ebcf97b5-1631-42e6-8413-edda66493717"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _exclusiveGateway1SubProcessSendEmailToken;
		public ProcessToken ExclusiveGateway1SubProcessSendEmailToken {
			get {
				return _exclusiveGateway1SubProcessSendEmailToken ?? (_exclusiveGateway1SubProcessSendEmailToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ExclusiveGateway1SubProcessSendEmailToken",
					SchemaElementUId = new Guid("0d0a0985-bba0-49d4-bea5-e5df68dd35d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask };
			FlowElements[SubProcessSendEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSendEmail };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ExclusiveGateway1SubProcessSendEmailToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1SubProcessSendEmailToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "SubProcessSendEmail":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1SubProcessSendEmailToken", e.Context.SenderName));
						break;
					case "ExclusiveGateway1SubProcessSendEmailToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SubProcessSendEmail", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "(IsCloseAndExit)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("IsCloseAndExit")) {
				writer.WriteValue("IsCloseAndExit", IsCloseAndExit, false);
			}
			if (!HasMapping("EmailTemplate")) {
				writer.WriteValue("EmailTemplate", EmailTemplate, Guid.Empty);
			}
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
			}
			if (!HasMapping("EmailSender")) {
				writer.WriteValue("EmailSender", EmailSender, null);
			}
			if (!HasMapping("CloseStatusId")) {
				writer.WriteValue("CloseStatusId", CloseStatusId, Guid.Empty);
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
			MetaPathParameterValues.Add("94883989-46c7-4825-b827-2c151618e017", () => IsCloseAndExit);
			MetaPathParameterValues.Add("0d056708-d60e-42dd-86c1-f5efcfd86bef", () => EmailTemplate);
			MetaPathParameterValues.Add("e9f06e37-ba23-48d4-832c-0745bb5b6289", () => CaseRecordId);
			MetaPathParameterValues.Add("9fc90727-5ac3-4ea8-a541-e3baca1ade4f", () => CloseStatusId);
			MetaPathParameterValues.Add("6adbdb8d-22e9-4e5f-91e9-ac5d02328433", () => EmailSender);
			MetaPathParameterValues.Add("b45094d5-b09f-4ac1-94fb-eb15b5624972", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("0ea1b5d8-4e6c-43d5-a7b7-f9bb4610ae41", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("ce8c0266-efa5-44a9-bff8-26d3da1ebeff", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("021c651a-8af8-4170-b888-138386e1329f", () => StartSignal2.EntitySchemaUId);
			MetaPathParameterValues.Add("2ea97d45-fb65-4126-9177-dd5587f15336", () => SubProcessSendEmail.CaseId);
			MetaPathParameterValues.Add("3f984456-427a-4177-9163-9b73842be371", () => SubProcessSendEmail.TemplateId);
			MetaPathParameterValues.Add("4ea09cbc-77f4-49ed-932b-bfc84d1131fb", () => SubProcessSendEmail.SenderEmail);
			MetaPathParameterValues.Add("e9652116-1fbc-423a-809f-5abee6bc90cb", () => SubProcessSendEmail.Subject);
			MetaPathParameterValues.Add("46ad5752-9bc9-40b5-8f41-4568b7813102", () => SubProcessSendEmail.ParentActivityId);
			MetaPathParameterValues.Add("810b9374-7a6a-46db-896a-f030e43430f9", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("3e718202-15ca-44b5-b786-1c807f779f66", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("6ff8853b-20dd-41d4-8339-8a3541af22e2", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("84e64196-ae90-4d27-ba05-56b7d0cb5cf6", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("033a6a7e-a736-40d7-b07b-7decc010d850", () => ChangeDataUserTask1.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "IsCloseAndExit":
					if (!hasValueToRead) break;
					IsCloseAndExit = reader.GetValue<System.Boolean>();
				break;
				case "EmailTemplate":
					if (!hasValueToRead) break;
					EmailTemplate = reader.GetValue<System.Guid>();
				break;
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
				case "EmailSender":
					if (!hasValueToRead) break;
					EmailSender = reader.GetValue<System.String>();
				break;
				case "CloseStatusId":
					if (!hasValueToRead) break;
					CloseStatusId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskExecute(ProcessExecutingContext context) {
			var CaseRecordId = Guid.Empty;
			var categoryId = Guid.Empty;
			var statusId = Guid.Empty;
			var isMultilanguageEnabled = UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage");
			IsCloseAndExit = false;
			if (StartSignal1.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal1.RecordId;
			}
			if (StartSignal2.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal2.RecordId;
			}
			
			var IsClassFeatureEnable = Terrasoft.Configuration.FeatureUtilities.GetIsFeatureEnabled(UserConnection, "SendEmailToCaseOnStatusChangeClass");
			if(IsClassFeatureEnable) {
				var classExecutor = new Terrasoft.Configuration.SendEmailToCaseOnStatusChange(UserConnection, CaseRecordId);
				classExecutor.Run();
				IsCloseAndExit = true;
				return true;
			}
			
			
			
			SubProcessSendEmail.CaseId = CaseRecordId;
			var isFinal = false;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Case");
			esq.AddColumn("Status");
			esq.AddColumn("Category");
			var IsResolvedColumn = esq.AddColumn("Status.IsResolved");
			var IsFinalColumnName = esq.AddColumn("Status.IsFinal").Name;
			esq.AddColumn("Contact");
			esq.AddColumn("Owner");
			//esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", CaseRecordId));
			var caseEntity = esq.GetEntity(UserConnection, CaseRecordId);
			if (caseEntity != null){
				categoryId = caseEntity.GetTypedColumnValue<Guid>("CategoryId");
				statusId = caseEntity.GetTypedColumnValue<Guid>("StatusId");
				var IsResolved = caseEntity.GetTypedColumnValue<bool>(IsResolvedColumn.Name);
				isFinal = caseEntity.GetTypedColumnValue<bool>(IsFinalColumnName);
				if (!IsResolved) {
					var update = new Update(UserConnection, "DelayedNotification")
						.Set("SendDate", Column.Const(null))
						.Where("CaseId").IsEqual(Column.Parameter(CaseRecordId))
						.And("EmailTemplateId").In(
							Column.Parameter(Terrasoft.Configuration.CaseServiceConsts.ResolutionNotificationTplId), 
							Column.Parameter(Terrasoft.Configuration.CaseServiceConsts.EstimationRequestTplId)
						);
						update.Execute();
				} else {
					var contactId = caseEntity.GetTypedColumnValue<Guid>("ContactId");
					var ownerId = caseEntity.GetTypedColumnValue<Guid>("OwnerId");
					if (contactId == ownerId) {
						IsCloseAndExit = true;
						var entitySchemaManager = UserConnection.EntitySchemaManager;
						var entitySchema = entitySchemaManager.GetInstanceByName("Case");
						Entity entityCase = entitySchema.CreateEntity(UserConnection);
						if (entityCase.FetchFromDB(CaseRecordId))
						{
							Guid closureCodeDefId = Guid.Empty;
							var closureCodeDefString = Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, 
								"CaseClosureCodeDef").ToString();
							entityCase.SetColumnValue("StatusId", CloseStatusId);
							entityCase.SetColumnValue("ClosureDate", UserConnection.CurrentUser.GetCurrentDateTime());
							if (Guid.TryParse(closureCodeDefString, out closureCodeDefId)) {
								entityCase.SetColumnValue("ClosureCodeId", closureCodeDefId);
							}
							entityCase.Save();
							return true;
						}
					}
				}
			}
			
			var emailSender = (string)Terrasoft.Core.Configuration.SysSettings.GetValue<string>(UserConnection, 
				"SupportServiceEmail", String.Empty);
			SubProcessSendEmail.SenderEmail = emailSender;
			var esq2 = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CaseNotificationRule");
			esq2.AddColumn("EmailTemplate");
			esq2.AddColumn("RuleUsage");
			esq2.AddColumn("Delay");
			esq2.Filters.Add(esq2.CreateFilterWithParameters(FilterComparisonType.NotEqual, "RuleUsage", Terrasoft.Configuration.CaseConsts.DisableSendUsageType));
			esq2.Filters.Add(esq2.CreateFilterWithParameters(FilterComparisonType.Equal, "CaseStatus", statusId));
			esq2.Filters.Add(esq2.CreateFilterWithParameters(FilterComparisonType.Equal, "CaseCategory", categoryId));
			var emailTemplateCollection = esq2.GetEntityCollection(UserConnection);
			if (emailTemplateCollection.Count>0) {
				EmailTemplate = emailTemplateCollection[0].GetTypedColumnValue<Guid>("EmailTemplateId");
				if (isMultilanguageEnabled) {
					var emailTemplateStore = new Terrasoft.Configuration.EmailTemplateStore(UserConnection);
					var emailTemplateLanguageHelper = new Terrasoft.Configuration.EmailTemplateLanguageHelper(CaseRecordId, UserConnection);
					foreach (var emailTemplate in emailTemplateCollection) {
						var emailTemplateId = emailTemplate.GetTypedColumnValue<Guid>("EmailTemplateId");
						var languageId = emailTemplateLanguageHelper.GetLanguageId(emailTemplateId);
						var templateEntity = emailTemplateStore.GetTemplate(emailTemplateId, languageId);
						emailTemplate.SetColumnValue("EmailTemplateId", templateEntity.PrimaryColumnValue);
					}
				}
				SubProcessSendEmail.TemplateId = EmailTemplate;
				if(UserConnection.GetIsFeatureEnabled("DelayedNotification")) {
					var currentDate = DateTime.UtcNow;
					if(isFinal) {
						var delayedEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "DelayedNotification");
						delayedEsq.AddColumn("SendDate");
						delayedEsq.AddColumn("Case");
						delayedEsq.AddColumn("Delay");
						var idColumnName = delayedEsq.AddColumn("Id").Name;
						var filters = new[] {
							delayedEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "Case", CaseRecordId),
							delayedEsq.CreateFilter(FilterComparisonType.IsNull, "SendDate")
						};
						delayedEsq.Filters.AddRange(filters);
						var delayedEmailCollection = delayedEsq.GetEntityCollection(UserConnection);
						if(delayedEmailCollection.Any()) {
							currentDate = DateTime.UtcNow;
							foreach(var delayedEmail in delayedEmailCollection) {
								var update = new Update(UserConnection, "DelayedNotification")
									.Set("SendDate", Column.Parameter(currentDate.AddMinutes(
											delayedEmail.GetTypedColumnValue<int>("Delay"))))
									.Where("Id").IsEqual(new QueryParameter(delayedEmail.GetTypedColumnValue<Guid>(idColumnName)));
								update.Execute();
							}
						}
					}
					var delayedNotification = emailTemplateCollection.Where(rule =>
									rule.GetTypedColumnValue<Guid>("RuleUsageId") == Terrasoft.Configuration.CaseConsts.DelaySendUsageType);
					if(delayedNotification.Any()) {
						foreach(var notification in delayedNotification) {
							var update = new Update(UserConnection, "DelayedNotification")
							.Set("SendDate", Column.Parameter(currentDate.AddMinutes(
									notification.GetTypedColumnValue<int>("Delay"))))
							.Where("CaseId").IsEqual(Column.Parameter(CaseRecordId))
							.And("EmailTemplateId").IsEqual(new QueryParameter(notification.GetTypedColumnValue<Guid>("EmailTemplateId")))
							.And("SendDate").IsEqual(Column.Const(null));
							var resultCount = update.Execute();
							if(resultCount == 0) {
							var insert = new Insert(UserConnection)
								.Into("DelayedNotification")
									.Set("CaseId", new QueryParameter(CaseRecordId))
									.Set("Delay", new QueryParameter(notification.GetTypedColumnValue<int>("Delay")))
									.Set("EmailTemplateId", new QueryParameter(notification.GetTypedColumnValue<Guid>("EmailTemplateId")))
									.Set("SendDate", Column.Parameter(currentDate.AddMinutes(
										notification.GetTypedColumnValue<int>("Delay")))) as Insert;
								insert.Execute();
							}
						}
					}
					var immediateNotification = emailTemplateCollection.Where(Rule =>
									Rule.GetTypedColumnValue<Guid>("RuleUsageId") == Terrasoft.Configuration.CaseConsts.ImmediateSendUsageType);
					if(immediateNotification.Any()) {
						var emailTemplateSender = new Terrasoft.Configuration.EmailWithMacrosManager(UserConnection);
						foreach(var notification in immediateNotification) {
							var tplId = notification.GetTypedColumnValue<Guid>("EmailTemplateId");
							try {
								emailTemplateSender.SendEmail(CaseRecordId, tplId);
							} catch {
								continue;
							}
						}
					}
					IsCloseAndExit = true;
					return true;
				}
				if(EmailTemplate == Terrasoft.Configuration.CaseConsts.SatisfactionSurveyTemplateId 
					&& UserConnection.GetIsFeatureEnabled("EstimateWithIcons")) {
				var emailWithMacrosSender = new Terrasoft.Configuration.EmailWithMacrosManager(UserConnection);
				emailWithMacrosSender.SendEmail(CaseRecordId, EmailTemplate);
				IsCloseAndExit = true;
				}
			} else {
				IsCloseAndExit = true;
				return true;
			}
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
			var cloneItem = (SendEmailToCaseStatusChangedProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

