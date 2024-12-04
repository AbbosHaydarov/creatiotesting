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

	#region Class: CustomerConsultationNewApplicationProcessSchema

	/// <exclude/>
	public class CustomerConsultationNewApplicationProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CustomerConsultationNewApplicationProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CustomerConsultationNewApplicationProcessSchema(CustomerConsultationNewApplicationProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CustomerConsultationNewApplicationProcess";
			UId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca");
			CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420");
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
			Tag = @"Cosultation Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca");
			Version = 0;
			PackageUId = new Guid("22ab9530-e787-4327-b87b-71b73668cf21");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("31d170eb-e43a-4ace-8978-77daa44dec8a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"CaseId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ca39cfe9-1e66-408f-976c-7c2bd35c27ee"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseConsultationThemeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6db963a3-ed68-40f6-be4c-0444a931f6dd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"CaseConsultationThemeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{79dfe29f-4bf1-468b-8b35-3d5f7823ea99}].[Parameter:{63af63f4-ae7e-42b6-afbb-200318881f6d}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateConsultationThemeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("49772e8b-7e12-4f24-9702-d2431849858f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"ConsultationThemeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseIdParameter());
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateCaseConsultationThemeIdParameter());
			Parameters.Add(CreateConsultationThemeIdParameter());
		}

		protected virtual void InitializeStartConsultationSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var caseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("d49b5081-2f43-478c-9fe7-36c88cba2d3b"),
				ContainerUId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{31d170eb-e43a-4ace-8978-77daa44dec8a}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var consultationThemeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				UId = new Guid("da404ac9-3e0e-44b7-a8cf-be255eb2ec38"),
				ContainerUId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			consultationThemeParameter.SourceValue = new ProcessSchemaParameterValue(consultationThemeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{49772e8b-7e12-4f24-9702-d2431849858f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(consultationThemeParameter);
			var caseConsultationThemeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				UId = new Guid("63af63f4-ae7e-42b6-afbb-200318881f6d"),
				ContainerUId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseConsultationThemeParameter.SourceValue = new ProcessSchemaParameterValue(caseConsultationThemeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117")
			};
			parametrizedElement.Parameters.Add(caseConsultationThemeParameter);
			var leadMediumParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"),
				UId = new Guid("2e1f685f-0011-4bc1-b215-c416221432c7"),
				ContainerUId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99"),
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadMediumParameter.SourceValue = new ProcessSchemaParameterValue(leadMediumParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.308ef8cd-4f4f-4898-9b3d-36ab9af01f5c.b1470b51-d708-4a69-8628-3a8cecb5ea60#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(leadMediumParameter);
		}

		protected virtual void InitializeEndConsultationSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var caseConsultationThemeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				UId = new Guid("d7bd10eb-a031-4fab-bcc6-6ec8d2384c5b"),
				ContainerUId = new Guid("042f6ad7-10e7-4cab-a549-84a848b09500"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				Name = @"CaseConsultationTheme",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseConsultationThemeParameter.SourceValue = new ProcessSchemaParameterValue(caseConsultationThemeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{6db963a3-ed68-40f6-be4c-0444a931f6dd}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(caseConsultationThemeParameter);
		}

		protected virtual void InitializeLinkEntityToProcessUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				UId = new Guid("7772715f-d7a3-4210-99dd-2af44979f5f6"),
				ContainerUId = new Guid("f2a2bf4b-5c00-4a53-baed-55c9754883c5"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{6db963a3-ed68-40f6-be4c-0444a931f6dd}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("220dd734-f29a-407d-8c62-5a614d9a4d7a"),
				ContainerUId = new Guid("f2a2bf4b-5c00-4a53-baed-55c9754883c5"),
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
				Value = @"c0b15550-eb1b-4557-9847-d193804edd4b",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("7dd07b13-6101-481d-b920-0825ec24574a"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			objectSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(objectSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"cdda1304-e571-42de-9df7-6dfe528ea7b6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("a91b9bf1-41e0-41a4-ab05-aec4c58dabf3"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			pageSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(pageSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"540a16d7-4865-4e0a-bc81-1e553120c44a",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c16f8b8-e527-4570-b1b6-b7ab7ce85d20"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"EditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			editModeParameter.SourceValue = new ProcessSchemaParameterValue(editModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0079832-b693-42c9-bb9e-d6986d8640fd"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,91,111,211,76,16,253,43,149,225,49,19,121,239,187,121,67,240,82,169,64,69,249,120,105,250,48,187,51,11,17,110,28,217,14,8,162,252,247,111,227,38,189,1,5,132,144,64,98,31,108,121,60,231,204,109,143,215,155,234,241,240,105,197,213,172,122,205,93,135,125,155,135,233,211,182,227,233,105,215,38,238,251,233,73,155,176,89,124,198,216,240,41,118,120,201,3,119,111,176,89,115,127,178,232,135,201,209,93,88,53,169,30,127,24,223,86,179,243,77,117,60,240,229,127,199,84,216,141,100,199,73,102,80,146,44,104,225,9,98,68,2,137,172,101,138,108,13,217,2,78,109,179,190,92,62,231,1,79,113,120,87,205,54,213,200,86,8,200,42,109,73,107,8,198,25,208,54,9,240,194,5,8,46,185,152,125,42,140,166,218,78,170,62,189,227,75,28,131,222,128,19,17,10,85,107,96,227,4,104,73,12,129,178,3,75,153,141,244,140,46,218,29,120,239,127,3,60,127,116,126,220,191,252,184,228,238,108,228,157,101,108,122,190,152,22,235,61,195,117,115,102,155,132,42,164,204,1,4,219,82,107,237,115,201,210,38,112,73,70,82,38,73,199,188,189,120,116,177,139,72,139,126,213,224,167,55,95,6,126,218,46,7,76,195,149,219,234,78,235,111,59,110,230,87,19,156,87,179,249,183,102,184,191,95,101,124,119,138,247,7,56,175,38,243,234,172,93,119,105,199,168,202,195,179,91,25,142,65,70,151,123,143,135,137,21,203,114,221,52,123,203,51,28,240,224,120,48,183,180,200,11,166,227,229,217,97,80,35,75,189,95,240,149,203,97,93,229,246,43,176,231,184,196,183,220,189,40,13,184,201,253,58,203,215,165,141,7,226,40,131,169,157,200,224,24,3,104,182,18,60,9,132,32,66,204,202,41,153,179,28,209,175,56,115,199,203,196,119,19,19,54,178,178,166,108,210,204,178,236,119,19,10,158,106,64,95,43,210,214,43,34,181,199,247,99,183,119,82,217,231,181,107,213,182,218,110,39,183,5,164,234,168,145,140,2,101,99,13,58,168,8,209,99,2,227,81,27,174,131,10,154,31,20,144,244,49,5,155,125,193,198,93,70,154,74,49,62,0,214,2,153,141,224,154,221,239,16,208,73,219,190,95,175,166,168,45,250,100,138,126,235,186,48,144,86,165,33,94,148,34,148,206,28,181,140,58,79,177,208,49,73,9,132,185,136,92,151,250,176,102,13,218,57,31,100,54,202,202,248,61,221,236,227,61,89,173,154,69,194,97,209,46,143,250,1,135,117,63,125,193,31,143,168,116,102,209,252,68,160,127,202,251,203,148,247,35,27,237,167,148,71,9,209,217,242,57,15,57,33,104,19,138,242,140,69,32,109,132,75,202,32,163,120,80,121,201,216,232,50,97,57,236,164,2,237,75,109,72,41,0,75,235,75,85,146,148,215,127,200,209,165,4,9,87,115,4,214,170,212,138,137,193,7,231,193,57,66,212,154,56,121,252,129,163,11,123,254,167,158,235,245,55,169,71,8,71,197,169,156,86,114,247,155,101,148,6,175,133,0,145,172,21,194,36,14,169,56,62,172,158,139,237,255,30,16,228,67,86,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				UId = new Guid("b6c810ee-e13c-44c2-be6b-c2496da5fe47"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9eab9a0c-6f37-4306-98bb-59034a033410"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutedMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			executedModeParameter.SourceValue = new ProcessSchemaParameterValue(executedModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executedModeParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8f652e65-4675-4d80-8bed-6dbfd41a23f0"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d43a2a2-4122-4bd2-8101-edbb9848ab2e"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cc37fcf8-9aec-4e86-b27d-0406d99ad73a"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"GenerateDecisionsFromColumn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			generateDecisionsFromColumnParameter.SourceValue = new ProcessSchemaParameterValue(generateDecisionsFromColumnParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d2bd3e6-358f-4b50-bb24-026e5f527147"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			decisionalColumnMetaPathParameter.SourceValue = new ProcessSchemaParameterValue(decisionalColumnMetaPathParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44e06ee8-2490-4106-8913-2787f7daf0f7"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ResultParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			resultParameterParameter.SourceValue = new ProcessSchemaParameterValue(resultParameterParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultParameterParameter);
			var isReexecutionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("98a370d0-e9dd-4311-99b7-b751a437590a"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsReexecution",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isReexecutionParameter.SourceValue = new ProcessSchemaParameterValue(isReexecutionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(isReexecutionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6418ed7-33f0-442e-ae30-06ffefc99239"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Open edit application page",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("c3196a02-bb15-40c0-9df4-2f1b1bab3a7f"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("54f36676-b503-4c20-932e-e9f1a60b2b42"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7f73ff5-fba2-41b0-83fe-0edebee06943"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4de60faf-2a46-4ded-90be-962be2dc9107"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0107d08-0e2d-4eb9-bf16-68ce058d027e"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d689d279-3957-4d16-a7fa-f9099dca2bcc"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d54b7c40-c2d7-4580-93d1-f1887e7c09a7"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51edf853-fd23-49a7-b334-105b47afba7d"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9f3329c-534c-4d1b-9a55-60c1a0af0f08"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19a8ab0f-52d2-4e55-b71b-e507e8635b4f"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("c8dcb4bb-e8fb-45b2-bf93-a90b2737a5a1"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("44705e6f-f81f-4f28-82bb-b35d71171e9b"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("9c591c26-674f-43fd-b3ca-dbed3a78692c"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("a0ef8682-039f-445f-b481-69d90ba149cc"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("b490668f-62f4-4b94-b3b7-22e116fb0085"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("243b5254-3962-42eb-bc91-adca548aeadf"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("caa19bb6-0f96-420a-865a-8a80dbf9f7ac"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("5236d26f-7b44-4448-847a-f70097219a62"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("046f2929-5ffb-4633-94f5-b34aa10a8b99"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("1a16b9c7-8de9-4a6a-af4f-4f8d245b3c84"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("6f422f91-1c6a-41e9-a3f5-2cd14d5b0bbe"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f157b53-c297-4714-ba55-9fb6ea672e11"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var pageTypeUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7927c008-f83f-475c-9a10-41558fe7a3fd"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageTypeUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageTypeUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2ed4e7df-91fe-4253-b6f5-1f80983a73e8"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(activitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activitySchemaUIdParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0d22a118-8a4f-4034-86e0-ae682c21aa91"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("75b061e1-30e6-48c3-acb9-b7efcb933485"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("ac4c1da4-9046-4cbd-802f-12fe53c2fd4e"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("120c6e09-301b-4b9a-82e0-aac46921431d"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("8a66841c-91c2-4ead-8d7c-1562aa004b66"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("588431d6-7c51-40c3-91df-9737e844073c"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var problemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("47a29905-a7e9-4b42-a8ff-310dbc38d6cc"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("71088b31-25b0-48e2-9945-618f03879978"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("8bb4ff38-b7f8-40ed-8854-b701e2836bf8"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var projectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("921df3e3-66ee-4127-8634-8ad84ca5a2e3"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var activityPriorityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				UId = new Guid("2ae3ad4c-5842-4905-a1a6-e84a4cf12188"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityPriority",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityPriorityParameter.SourceValue = new ProcessSchemaParameterValue(activityPriorityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ab96fa02-7fe6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityPriorityParameter);
			var createActivityParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0d5eb68a-8306-4889-86c5-5ec640b09d27"),
				ContainerUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"CreateActivity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			createActivityParameter.SourceValue = new ProcessSchemaParameterValue(createActivityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(createActivityParameter);
		}

		protected virtual void InitializeLinkEntityToProcessUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				UId = new Guid("d68d98a6-641d-4120-8ab1-9a82c9d7d737"),
				ContainerUId = new Guid("4bf365d6-1818-4b1f-b855-ab55ac640225"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{1404aba0-2d5d-4e35-ada3-b44b5dbfb95f}].[Parameter:{b6c810ee-e13c-44c2-be6b-c2496da5fe47}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("5d980263-c023-4a01-8bda-9a28bf0e3027"),
				ContainerUId = new Guid("4bf365d6-1818-4b1f-b855-ab55ac640225"),
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
				Value = @"cdda1304-e571-42de-9df7-6dfe528ea7b6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess startconsultationsubprocess = CreateStartConsultationSubProcessSubProcess();
			FlowElements.Add(startconsultationsubprocess);
			ProcessSchemaSubProcess endconsultationsubprocess = CreateEndConsultationSubProcessSubProcess();
			FlowElements.Add(endconsultationsubprocess);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask linkentitytoprocessusertask1 = CreateLinkEntityToProcessUserTask1UserTask();
			FlowElements.Add(linkentitytoprocessusertask1);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaUserTask linkentitytoprocessusertask2 = CreateLinkEntityToProcessUserTask2UserTask();
			FlowElements.Add(linkentitytoprocessusertask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6034ec92-2fba-46d5-81f5-0d7b76dcb9bf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7b6da19-cfdc-48a9-8aba-c6a04249cf69"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("472199d4-ec23-4d87-a080-f109e5f581fd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f2a2bf4b-5c00-4a53-baed-55c9754883c5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("c79b4d15-cc19-43de-b3ab-54c6c633f824"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("042f6ad7-10e7-4cab-a549-84a848b09500"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8cee6f39-34dd-43f0-ac1b-75a093325427"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("da7c4301-d411-4015-ad7a-cbdc5e58ef79"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2a2bf4b-5c00-4a53-baed-55c9754883c5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("84a85ea0-c176-40bb-b7f7-6422b5eafefc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4bf365d6-1818-4b1f-b855-ab55ac640225"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("6f11a717-7207-44c3-a86d-433e1185e313"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4fdb287d-e7ac-4400-b918-4cd030ab3b99"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4bf365d6-1818-4b1f-b855-ab55ac640225"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("042f6ad7-10e7-4cab-a549-84a848b09500"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cc33f6e3-2df1-4db8-a1b6-6cf8bcab8b62"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cc33f6e3-2df1-4db8-a1b6-6cf8bcab8b62"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("d7b6da19-cfdc-48a9-8aba-c6a04249cf69"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
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
				UId = new Guid("8cee6f39-34dd-43f0-ac1b-75a093325427"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"Terminate1",
				Position = new Point(838, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaSubProcess CreateStartConsultationSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaStartConsultationSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"StartConsultationSubProcess",
				Position = new Point(140, 170),
				SchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeStartConsultationSubProcessParameters(schemaStartConsultationSubProcess);
			return schemaStartConsultationSubProcess;
		}

		protected virtual ProcessSchemaSubProcess CreateEndConsultationSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaEndConsultationSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("042f6ad7-10e7-4cab-a549-84a848b09500"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"EndConsultationSubProcess",
				Position = new Point(680, 170),
				SchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeEndConsultationSubProcessParameters(schemaEndConsultationSubProcess);
			return schemaEndConsultationSubProcess;
		}

		protected virtual ProcessSchemaUserTask CreateLinkEntityToProcessUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f2a2bf4b-5c00-4a53-baed-55c9754883c5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"LinkEntityToProcessUserTask1",
				Position = new Point(260, 170),
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeLinkEntityToProcessUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3527f69-a44e-46db-8857-8811a9b6a420"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"OpenEditPageUserTask1",
				Position = new Point(391, 170),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateLinkEntityToProcessUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4bf365d6-1818-4b1f-b855-ab55ac640225"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8ab28d-2cbb-4b25-8279-823fed157c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4fdb287d-e7ac-4400-b918-4cd030ab3b99"),
				CreatedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"),
				Name = @"LinkEntityToProcessUserTask2",
				Position = new Point(522, 170),
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeLinkEntityToProcessUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new CustomerConsultationNewApplicationProcess(userConnection);
		}

		public override object Clone() {
			return new CustomerConsultationNewApplicationProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca"));
		}

		#endregion

	}

	#endregion

	#region Class: CustomerConsultationNewApplicationProcess

	/// <exclude/>
	public class CustomerConsultationNewApplicationProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, CustomerConsultationNewApplicationProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: StartConsultationSubProcessFlowElement

		/// <exclude/>
		public class StartConsultationSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public StartConsultationSubProcessFlowElement(UserConnection userConnection, CustomerConsultationNewApplicationProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("25ee8460-69b5-4a82-9154-04381b081117");
			}

			#endregion

			#region Properties: Public

			public Guid Case {
				get {
					return GetParameterValue<Guid>("Case");
				}
				set {
					SetParameterValue("Case", value);
				}
			}

			public Guid ConsultationTheme {
				get {
					return GetParameterValue<Guid>("ConsultationTheme");
				}
				set {
					SetParameterValue("ConsultationTheme", value);
				}
			}

			public Guid CaseConsultationTheme {
				get {
					return GetParameterValue<Guid>("CaseConsultationTheme");
				}
				set {
					SetParameterValue("CaseConsultationTheme", value);
				}
			}

			public Guid LeadMedium {
				get {
					return GetParameterValue<Guid>("LeadMedium");
				}
				set {
					SetParameterValue("LeadMedium", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (CustomerConsultationNewApplicationProcess)owner;
				Name = "StartConsultationSubProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("79dfe29f-4bf1-468b-8b35-3d5f7823ea99");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (CustomerConsultationNewApplicationProcess)Owner;
				SetParameterValue("Case", (Guid)((process.CaseId)));
				SetParameterValue("ConsultationTheme", (Guid)((process.ConsultationThemeId)));
				SetParameterValue("LeadMedium", (Guid)(new Guid("b1470b51-d708-4a69-8628-3a8cecb5ea60")));
			}

			#endregion

		}

		#endregion

		#region Class: EndConsultationSubProcessFlowElement

		/// <exclude/>
		public class EndConsultationSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public EndConsultationSubProcessFlowElement(UserConnection userConnection, CustomerConsultationNewApplicationProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("a5cec4a9-a272-4ac7-b0da-b7823d07059d");
			}

			#endregion

			#region Properties: Public

			public Guid CaseConsultationTheme {
				get {
					return GetParameterValue<Guid>("CaseConsultationTheme");
				}
				set {
					SetParameterValue("CaseConsultationTheme", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (CustomerConsultationNewApplicationProcess)owner;
				Name = "EndConsultationSubProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("042f6ad7-10e7-4cab-a549-84a848b09500");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (CustomerConsultationNewApplicationProcess)Owner;
				SetParameterValue("CaseConsultationTheme", (Guid)((process.CaseConsultationThemeId)));
			}

			#endregion

		}

		#endregion

		#region Class: LinkEntityToProcessUserTask1FlowElement

		/// <exclude/>
		public class LinkEntityToProcessUserTask1FlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkEntityToProcessUserTask1FlowElement(UserConnection userConnection, CustomerConsultationNewApplicationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkEntityToProcessUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f2a2bf4b-5c00-4a53-baed-55c9754883c5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.CaseConsultationThemeId));
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

			private Guid _entitySchemaId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b");
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

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, CustomerConsultationNewApplicationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("1404aba0-2d5d-4e35-ada3-b44b5dbfb95f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordColumnValues_Contact = () => (Guid)((process.ContactId));
				_recordColumnValues_Status = () => (Guid)(new Guid("adfeed22-daf5-44ac-a0e4-477892f5362b"));
				_recordColumnValues_Case = () => (Guid)((process.CaseId));
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Contact", () => _recordColumnValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Case", () => _recordColumnValues_Case.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Contact;
			internal Func<Guid> _recordColumnValues_Status;
			internal Func<Guid> _recordColumnValues_Case;

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("540a16d7-4865-4e0a-bc81-1e553120c44a");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 0;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,91,111,211,76,16,253,43,149,225,49,19,121,239,187,121,67,240,82,169,64,69,249,120,105,250,48,187,51,11,17,110,28,217,14,8,162,252,247,111,227,38,189,1,5,132,144,64,98,31,108,121,60,231,204,109,143,215,155,234,241,240,105,197,213,172,122,205,93,135,125,155,135,233,211,182,227,233,105,215,38,238,251,233,73,155,176,89,124,198,216,240,41,118,120,201,3,119,111,176,89,115,127,178,232,135,201,209,93,88,53,169,30,127,24,223,86,179,243,77,117,60,240,229,127,199,84,216,141,100,199,73,102,80,146,44,104,225,9,98,68,2,137,172,101,138,108,13,217,2,78,109,179,190,92,62,231,1,79,113,120,87,205,54,213,200,86,8,200,42,109,73,107,8,198,25,208,54,9,240,194,5,8,46,185,152,125,42,140,166,218,78,170,62,189,227,75,28,131,222,128,19,17,10,85,107,96,227,4,104,73,12,129,178,3,75,153,141,244,140,46,218,29,120,239,127,3,60,127,116,126,220,191,252,184,228,238,108,228,157,101,108,122,190,152,22,235,61,195,117,115,102,155,132,42,164,204,1,4,219,82,107,237,115,201,210,38,112,73,70,82,38,73,199,188,189,120,116,177,139,72,139,126,213,224,167,55,95,6,126,218,46,7,76,195,149,219,234,78,235,111,59,110,230,87,19,156,87,179,249,183,102,184,191,95,101,124,119,138,247,7,56,175,38,243,234,172,93,119,105,199,168,202,195,179,91,25,142,65,70,151,123,143,135,137,21,203,114,221,52,123,203,51,28,240,224,120,48,183,180,200,11,166,227,229,217,97,80,35,75,189,95,240,149,203,97,93,229,246,43,176,231,184,196,183,220,189,40,13,184,201,253,58,203,215,165,141,7,226,40,131,169,157,200,224,24,3,104,182,18,60,9,132,32,66,204,202,41,153,179,28,209,175,56,115,199,203,196,119,19,19,54,178,178,166,108,210,204,178,236,119,19,10,158,106,64,95,43,210,214,43,34,181,199,247,99,183,119,82,217,231,181,107,213,182,218,110,39,183,5,164,234,168,145,140,2,101,99,13,58,168,8,209,99,2,227,81,27,174,131,10,154,31,20,144,244,49,5,155,125,193,198,93,70,154,74,49,62,0,214,2,153,141,224,154,221,239,16,208,73,219,190,95,175,166,168,45,250,100,138,126,235,186,48,144,86,165,33,94,148,34,148,206,28,181,140,58,79,177,208,49,73,9,132,185,136,92,151,250,176,102,13,218,57,31,100,54,202,202,248,61,221,236,227,61,89,173,154,69,194,97,209,46,143,250,1,135,117,63,125,193,31,143,168,116,102,209,252,68,160,127,202,251,203,148,247,35,27,237,167,148,71,9,209,217,242,57,15,57,33,104,19,138,242,140,69,32,109,132,75,202,32,163,120,80,121,201,216,232,50,97,57,236,164,2,237,75,109,72,41,0,75,235,75,85,146,148,215,127,200,209,165,4,9,87,115,4,214,170,212,138,137,193,7,231,193,57,66,212,154,56,121,252,129,163,11,123,254,167,158,235,245,55,169,71,8,71,197,169,156,86,114,247,155,101,148,6,175,133,0,145,172,21,194,36,14,169,56,62,172,158,139,237,255,30,16,228,67,86,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "90962a6c454d40208411bc35cd6dfeca",
							"BaseElements.OpenEditPageUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("22ab9530-e787-4327-b87b-71b73668cf21");
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

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("90962a6c454d40208411bc35cd6dfeca",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
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

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
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

		}

		#endregion

		#region Class: LinkEntityToProcessUserTask2FlowElement

		/// <exclude/>
		public class LinkEntityToProcessUserTask2FlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkEntityToProcessUserTask2FlowElement(UserConnection userConnection, CustomerConsultationNewApplicationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkEntityToProcessUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("4bf365d6-1818-4b1f-b855-ab55ac640225");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.OpenEditPageUserTask1.RecordId));
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

			private Guid _entitySchemaId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
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

		public CustomerConsultationNewApplicationProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CustomerConsultationNewApplicationProcess";
			SchemaUId = new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_caseConsultationThemeId = () => { return (Guid)((StartConsultationSubProcess.CaseConsultationTheme)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("90962a6c-454d-4020-8411-bc35cd6dfeca");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CustomerConsultationNewApplicationProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CustomerConsultationNewApplicationProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid ContactId {
			get;
			set;
		}

		private Func<Guid> _caseConsultationThemeId;
		public virtual Guid CaseConsultationThemeId {
			get {
				return (_caseConsultationThemeId ?? (_caseConsultationThemeId = () => Guid.Empty)).Invoke();
			}
			set {
				_caseConsultationThemeId = () => { return value; };
			}
		}

		public virtual Guid ConsultationThemeId {
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
					SchemaElementUId = new Guid("d7b6da19-cfdc-48a9-8aba-c6a04249cf69"),
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
					SchemaElementUId = new Guid("8cee6f39-34dd-43f0-ac1b-75a093325427"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private StartConsultationSubProcessFlowElement _startConsultationSubProcess;
		public StartConsultationSubProcessFlowElement StartConsultationSubProcess {
			get {
				return _startConsultationSubProcess ?? ((_startConsultationSubProcess) = new StartConsultationSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private EndConsultationSubProcessFlowElement _endConsultationSubProcess;
		public EndConsultationSubProcessFlowElement EndConsultationSubProcess {
			get {
				return _endConsultationSubProcess ?? ((_endConsultationSubProcess) = new EndConsultationSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LinkEntityToProcessUserTask1FlowElement _linkEntityToProcessUserTask1;
		public LinkEntityToProcessUserTask1FlowElement LinkEntityToProcessUserTask1 {
			get {
				return _linkEntityToProcessUserTask1 ?? (_linkEntityToProcessUserTask1 = new LinkEntityToProcessUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LinkEntityToProcessUserTask2FlowElement _linkEntityToProcessUserTask2;
		public LinkEntityToProcessUserTask2FlowElement LinkEntityToProcessUserTask2 {
			get {
				return _linkEntityToProcessUserTask2 ?? (_linkEntityToProcessUserTask2 = new LinkEntityToProcessUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessToken _start1StartConsultationSubProcessToken;
		public ProcessToken Start1StartConsultationSubProcessToken {
			get {
				return _start1StartConsultationSubProcessToken ?? (_start1StartConsultationSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "Start1StartConsultationSubProcessToken",
					SchemaElementUId = new Guid("e7e9af7e-93f6-44b3-a39e-f5a135fefbea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _linkEntityToProcessUserTask2EndConsultationSubProcessToken;
		public ProcessToken LinkEntityToProcessUserTask2EndConsultationSubProcessToken {
			get {
				return _linkEntityToProcessUserTask2EndConsultationSubProcessToken ?? (_linkEntityToProcessUserTask2EndConsultationSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "LinkEntityToProcessUserTask2EndConsultationSubProcessToken",
					SchemaElementUId = new Guid("45f96d39-bdad-4635-93bb-b8a487a8d5ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartConsultationSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartConsultationSubProcess };
			FlowElements[EndConsultationSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EndConsultationSubProcess };
			FlowElements[LinkEntityToProcessUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkEntityToProcessUserTask1 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[LinkEntityToProcessUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkEntityToProcessUserTask2 };
			FlowElements[Start1StartConsultationSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1StartConsultationSubProcessToken };
			FlowElements[LinkEntityToProcessUserTask2EndConsultationSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkEntityToProcessUserTask2EndConsultationSubProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1StartConsultationSubProcessToken", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartConsultationSubProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkEntityToProcessUserTask1", e.Context.SenderName));
						break;
					case "EndConsultationSubProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "LinkEntityToProcessUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkEntityToProcessUserTask2", e.Context.SenderName));
						break;
					case "LinkEntityToProcessUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkEntityToProcessUserTask2EndConsultationSubProcessToken", e.Context.SenderName));
						break;
					case "Start1StartConsultationSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartConsultationSubProcess", e.Context.SenderName));
						break;
					case "LinkEntityToProcessUserTask2EndConsultationSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EndConsultationSubProcess", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseId")) {
				writer.WriteValue("CaseId", CaseId, Guid.Empty);
			}
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("ConsultationThemeId")) {
				writer.WriteValue("ConsultationThemeId", ConsultationThemeId, Guid.Empty);
			}
			if (!HasMapping("CaseConsultationThemeId")) {
				writer.WriteValue("CaseConsultationThemeId", CaseConsultationThemeId, Guid.Empty);
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
			MetaPathParameterValues.Add("31d170eb-e43a-4ace-8978-77daa44dec8a", () => CaseId);
			MetaPathParameterValues.Add("ca39cfe9-1e66-408f-976c-7c2bd35c27ee", () => ContactId);
			MetaPathParameterValues.Add("6db963a3-ed68-40f6-be4c-0444a931f6dd", () => CaseConsultationThemeId);
			MetaPathParameterValues.Add("49772e8b-7e12-4f24-9702-d2431849858f", () => ConsultationThemeId);
			MetaPathParameterValues.Add("d49b5081-2f43-478c-9fe7-36c88cba2d3b", () => StartConsultationSubProcess.Case);
			MetaPathParameterValues.Add("da404ac9-3e0e-44b7-a8cf-be255eb2ec38", () => StartConsultationSubProcess.ConsultationTheme);
			MetaPathParameterValues.Add("63af63f4-ae7e-42b6-afbb-200318881f6d", () => StartConsultationSubProcess.CaseConsultationTheme);
			MetaPathParameterValues.Add("2e1f685f-0011-4bc1-b215-c416221432c7", () => StartConsultationSubProcess.LeadMedium);
			MetaPathParameterValues.Add("d7bd10eb-a031-4fab-bcc6-6ec8d2384c5b", () => EndConsultationSubProcess.CaseConsultationTheme);
			MetaPathParameterValues.Add("7772715f-d7a3-4210-99dd-2af44979f5f6", () => LinkEntityToProcessUserTask1.EntityId);
			MetaPathParameterValues.Add("220dd734-f29a-407d-8c62-5a614d9a4d7a", () => LinkEntityToProcessUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("7dd07b13-6101-481d-b920-0825ec24574a", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("a91b9bf1-41e0-41a4-ab05-aec4c58dabf3", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("3c16f8b8-e527-4570-b1b6-b7ab7ce85d20", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("a0079832-b693-42c9-bb9e-d6986d8640fd", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("b6c810ee-e13c-44c2-be6b-c2496da5fe47", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("9eab9a0c-6f37-4306-98bb-59034a033410", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("8f652e65-4675-4d80-8bed-6dbfd41a23f0", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("2d43a2a2-4122-4bd2-8101-edbb9848ab2e", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("cc37fcf8-9aec-4e86-b27d-0406d99ad73a", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("7d2bd3e6-358f-4b50-bb24-026e5f527147", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("44e06ee8-2490-4106-8913-2787f7daf0f7", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("98a370d0-e9dd-4311-99b7-b751a437590a", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("d6418ed7-33f0-442e-ae30-06ffefc99239", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("c3196a02-bb15-40c0-9df4-2f1b1bab3a7f", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("54f36676-b503-4c20-932e-e9f1a60b2b42", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("b7f73ff5-fba2-41b0-83fe-0edebee06943", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("4de60faf-2a46-4ded-90be-962be2dc9107", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("d0107d08-0e2d-4eb9-bf16-68ce058d027e", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("d689d279-3957-4d16-a7fa-f9099dca2bcc", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("d54b7c40-c2d7-4580-93d1-f1887e7c09a7", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("51edf853-fd23-49a7-b334-105b47afba7d", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("b9f3329c-534c-4d1b-9a55-60c1a0af0f08", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("19a8ab0f-52d2-4e55-b71b-e507e8635b4f", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("c8dcb4bb-e8fb-45b2-bf93-a90b2737a5a1", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("44705e6f-f81f-4f28-82bb-b35d71171e9b", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("9c591c26-674f-43fd-b3ca-dbed3a78692c", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("a0ef8682-039f-445f-b481-69d90ba149cc", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("b490668f-62f4-4b94-b3b7-22e116fb0085", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("243b5254-3962-42eb-bc91-adca548aeadf", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("caa19bb6-0f96-420a-865a-8a80dbf9f7ac", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("5236d26f-7b44-4448-847a-f70097219a62", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("046f2929-5ffb-4633-94f5-b34aa10a8b99", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("1a16b9c7-8de9-4a6a-af4f-4f8d245b3c84", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("6f422f91-1c6a-41e9-a3f5-2cd14d5b0bbe", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("4f157b53-c297-4714-ba55-9fb6ea672e11", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("7927c008-f83f-475c-9a10-41558fe7a3fd", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("2ed4e7df-91fe-4253-b6f5-1f80983a73e8", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("0d22a118-8a4f-4034-86e0-ae682c21aa91", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("75b061e1-30e6-48c3-acb9-b7efcb933485", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("ac4c1da4-9046-4cbd-802f-12fe53c2fd4e", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("120c6e09-301b-4b9a-82e0-aac46921431d", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("8a66841c-91c2-4ead-8d7c-1562aa004b66", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("588431d6-7c51-40c3-91df-9737e844073c", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("47a29905-a7e9-4b42-a8ff-310dbc38d6cc", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("71088b31-25b0-48e2-9945-618f03879978", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("8bb4ff38-b7f8-40ed-8854-b701e2836bf8", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("921df3e3-66ee-4127-8634-8ad84ca5a2e3", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("2ae3ad4c-5842-4905-a1a6-e84a4cf12188", () => OpenEditPageUserTask1.ActivityPriority);
			MetaPathParameterValues.Add("0d5eb68a-8306-4889-86c5-5ec640b09d27", () => OpenEditPageUserTask1.CreateActivity);
			MetaPathParameterValues.Add("d68d98a6-641d-4120-8ab1-9a82c9d7d737", () => LinkEntityToProcessUserTask2.EntityId);
			MetaPathParameterValues.Add("5d980263-c023-4a01-8bda-9a28bf0e3027", () => LinkEntityToProcessUserTask2.EntitySchemaId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseId":
					if (!hasValueToRead) break;
					CaseId = reader.GetValue<System.Guid>();
				break;
				case "ContactId":
					if (!hasValueToRead) break;
					ContactId = reader.GetValue<System.Guid>();
				break;
				case "ConsultationThemeId":
					if (!hasValueToRead) break;
					ConsultationThemeId = reader.GetValue<System.Guid>();
				break;
				case "CaseConsultationThemeId":
					if (!hasValueToRead) break;
					CaseConsultationThemeId = reader.GetValue<System.Guid>();
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
			var cloneItem = (CustomerConsultationNewApplicationProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

