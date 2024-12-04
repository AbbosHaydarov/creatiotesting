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

	#region Class: LeadManagementDistributionFinanceSchema

	/// <exclude/>
	public class LeadManagementDistributionFinanceSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementDistributionFinanceSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementDistributionFinanceSchema(LeadManagementDistributionFinanceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementDistributionFinance";
			UId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a");
			CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d");
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
			Tag = @"LeadManagementDistributionFinance";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a");
			Version = 0;
			PackageUId = new Guid("867c36ba-c410-4177-9616-bcc8c1dea83b");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("30cf6943-a881-4c30-a088-ff65572e4241"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateReminderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9cd3f863-0eda-4338-895e-97f82adfe406"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"CreateReminder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{cd5eefc4-6c19-4719-be10-6babbc9acc6e}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateResponsibleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77bfc541-1a1a-4b5e-bd77-3e429c4b637f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ResponsibleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{0d01d7bb-ccf9-4184-a64f-953b68988ea4}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateShowDistributionPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("51139bfa-4db4-45f7-aa2f-590d604f8469"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ShowDistributionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateCreateReminderParameter());
			Parameters.Add(CreateResponsibleIdParameter());
			Parameters.Add(CreateShowDistributionPageParameter());
		}

		protected virtual void InitializeSaveLeadHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("188fdd38-de95-4c10-8ab3-34128e7e82c9"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cad839f-9e67-4603-a369-f4c25fce8216"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51b908e1-277f-4fd9-954b-c200b506502f"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,198,178,236,30,151,109,89,40,105,160,105,41,36,75,24,75,163,172,192,127,54,182,76,19,204,126,247,202,235,108,10,57,148,210,91,193,135,209,216,239,167,55,143,241,124,239,199,143,190,9,52,84,14,155,145,146,105,103,43,38,108,86,103,136,192,51,5,5,7,43,5,199,210,104,14,160,92,46,108,129,194,32,75,58,108,169,98,171,122,107,125,96,137,15,212,142,213,237,252,27,26,134,137,146,123,119,62,124,53,7,106,241,219,114,1,164,232,116,73,37,47,114,81,115,160,186,230,218,160,225,206,201,178,86,160,33,37,195,86,47,168,4,101,26,136,231,18,4,135,28,11,94,103,96,121,90,80,14,153,148,145,3,44,105,200,133,237,211,113,160,113,244,125,87,205,244,90,223,60,31,163,203,245,238,77,223,76,109,199,146,150,2,94,99,56,68,58,9,130,220,32,55,80,230,28,28,21,28,101,105,185,196,186,200,10,77,169,74,11,150,24,60,134,5,203,118,150,37,22,3,126,199,102,162,51,121,246,209,99,38,69,170,115,21,181,169,52,28,100,38,184,86,186,224,206,42,87,146,84,101,89,219,75,94,159,38,31,107,63,94,77,45,13,222,188,196,78,49,191,126,168,102,211,119,97,232,155,5,125,117,254,252,134,158,194,26,238,203,171,31,235,64,33,246,23,17,59,37,211,72,155,198,83,23,182,157,233,173,239,30,86,230,233,20,37,237,17,7,63,94,82,216,62,78,216,176,100,240,15,135,63,166,181,153,198,208,183,255,209,168,73,28,51,50,226,146,157,237,46,59,104,253,120,108,240,249,124,174,216,187,199,169,15,31,62,19,218,181,98,111,20,21,187,99,82,24,167,74,144,28,181,78,57,152,101,235,133,214,113,41,85,158,23,25,65,6,233,29,139,46,254,129,125,187,27,191,252,236,46,255,192,234,122,255,62,118,223,52,174,47,202,106,254,27,59,167,253,98,104,127,138,207,47,177,221,110,55,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e91b04af-7a52-4f54-a02b-32ac50a9f8ad"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,77,111,27,71,12,134,255,138,176,201,209,20,230,251,67,215,164,64,13,36,109,80,39,185,196,62,112,102,200,70,168,164,53,118,215,41,82,67,255,189,212,218,110,236,160,177,141,22,69,83,164,123,88,73,51,122,201,153,33,159,33,47,187,167,211,199,115,234,86,221,107,26,6,28,123,158,150,207,250,129,150,175,134,190,210,56,46,95,244,21,55,235,223,176,108,232,21,14,184,165,137,134,183,184,185,160,241,197,122,156,142,22,119,101,221,81,247,244,195,60,219,173,222,93,118,199,19,109,223,28,55,177,238,189,106,190,22,3,177,198,12,46,132,2,217,39,5,92,115,225,20,93,174,236,68,92,251,205,197,118,247,146,38,124,133,211,251,110,117,217,205,214,196,64,169,170,154,22,20,120,180,13,92,114,10,16,29,65,13,138,48,198,64,70,133,110,127,212,141,245,61,109,113,118,250,73,236,52,114,202,148,33,122,85,192,81,41,144,42,86,96,182,185,4,49,166,169,30,196,215,255,255,36,124,247,228,69,223,255,114,113,190,52,198,58,93,155,6,95,172,5,87,197,125,86,90,67,224,24,178,37,14,228,220,178,82,137,170,216,10,57,121,150,53,134,8,72,177,66,74,156,91,139,90,133,148,158,156,29,28,181,245,120,190,193,143,111,191,232,239,100,194,159,105,249,61,238,90,207,188,152,250,197,136,27,26,175,196,231,119,226,112,91,126,121,122,21,206,211,110,117,250,165,128,94,127,158,204,231,116,55,164,159,71,243,180,59,58,237,78,250,139,161,30,44,218,195,143,155,211,157,61,168,235,7,254,228,117,243,92,217,152,101,47,113,39,155,26,126,16,143,179,124,158,122,142,19,206,206,95,203,186,111,12,23,147,189,138,154,33,18,74,182,80,48,144,154,70,200,90,178,197,70,107,152,205,172,254,137,152,6,218,85,186,187,176,199,68,107,214,207,158,63,45,230,38,241,100,100,119,177,217,204,14,198,121,255,135,76,190,94,248,245,204,243,91,33,188,101,161,111,107,94,83,59,222,253,149,163,218,119,251,253,209,109,108,170,71,195,70,69,40,25,221,33,163,52,148,36,178,26,16,99,65,91,53,231,123,177,241,38,233,104,93,146,67,80,26,156,210,30,48,134,0,181,104,85,99,241,222,213,244,79,96,243,238,120,252,241,215,29,13,87,167,176,98,220,140,116,182,148,209,207,6,254,72,192,213,101,140,133,171,119,26,52,74,168,93,241,4,165,197,8,150,156,201,213,149,96,35,239,207,30,226,103,246,250,63,39,143,227,68,135,66,54,120,13,137,201,128,211,62,11,103,77,110,214,164,108,115,33,217,214,236,127,130,19,149,66,50,1,21,88,169,50,224,140,145,45,57,169,49,5,117,200,45,20,143,84,238,229,196,196,204,100,73,65,204,85,129,99,41,77,5,21,3,251,208,216,56,207,82,161,190,18,78,114,109,150,83,176,160,168,9,39,214,38,72,89,96,201,145,147,193,198,228,84,120,152,147,103,3,225,68,139,129,182,235,93,163,97,193,253,176,232,191,37,118,178,42,193,75,239,1,138,89,82,70,203,197,147,162,244,38,198,25,37,95,144,179,138,247,177,243,232,133,125,237,236,4,118,45,81,36,161,254,208,89,69,41,52,41,248,8,146,73,213,251,92,144,93,186,151,29,116,10,131,99,4,148,86,76,106,12,5,200,46,6,64,159,171,110,92,74,182,252,111,178,243,221,134,182,180,155,86,151,150,124,8,74,138,33,9,206,224,36,250,144,155,105,224,149,10,33,27,163,138,163,253,93,216,146,49,81,10,38,1,133,40,157,132,66,13,104,217,130,209,202,16,123,73,141,136,15,195,38,113,156,134,117,185,152,214,253,110,113,126,232,236,78,14,237,220,162,173,63,172,71,25,251,86,152,43,127,179,175,243,45,57,31,138,3,237,229,170,118,141,60,20,37,47,100,105,103,56,196,236,235,87,203,220,217,254,119,206,104,149,80,108,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeSaveLeadNoInterestParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("a147d2f0-eb4f-4a91-bda3-6b4d5423014b"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d71bf98b-10c9-4b4e-9da3-927f4c707df2"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8b04704d-b57f-4aed-8143-0ba2dc774953"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,245,225,30,151,109,89,40,105,160,105,41,36,75,144,165,81,86,224,143,141,37,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,154,247,230,205,99,52,223,135,248,49,180,9,198,218,155,54,2,158,118,174,70,69,229,20,48,197,8,5,230,9,23,162,36,186,162,21,113,86,73,203,37,99,32,27,132,123,211,65,141,86,244,214,133,132,112,72,208,197,250,118,254,77,154,198,9,240,189,63,95,190,218,3,116,230,219,210,128,83,227,149,6,77,100,85,52,132,67,211,16,101,141,37,222,51,221,8,174,56,5,139,86,45,76,23,66,230,90,82,22,174,36,220,8,75,180,84,146,72,224,180,148,90,59,90,50,132,91,240,105,251,116,28,33,198,48,244,245,12,175,241,205,243,49,171,92,123,111,134,118,234,122,132,59,72,230,218,164,67,141,12,20,192,43,107,136,229,186,34,220,131,36,134,105,71,152,105,100,41,21,80,65,37,194,214,28,211,66,139,118,14,97,103,146,249,110,218,9,206,204,115,200,26,75,86,80,85,137,140,165,204,18,206,202,130,40,145,53,122,39,188,6,38,180,110,220,197,175,79,83,200,113,136,87,83,7,99,176,47,182,67,246,111,24,235,217,14,125,26,135,118,161,190,58,151,223,192,83,90,205,125,121,250,177,14,148,114,126,1,161,19,158,34,108,218,0,125,218,246,118,112,161,127,88,57,79,167,12,233,142,102,12,241,226,194,246,113,50,45,194,99,120,56,252,209,173,205,20,211,208,253,71,163,226,60,102,230,200,75,118,150,187,236,160,11,241,216,154,231,243,189,70,239,30,167,33,125,248,12,198,173,17,122,131,168,209,29,98,133,245,66,115,70,140,82,148,112,203,10,98,10,165,242,82,138,170,146,37,240,146,211,59,148,85,252,3,247,237,46,126,249,217,95,254,192,170,122,255,62,103,223,36,174,47,200,122,254,27,57,167,253,34,104,127,202,231,23,171,70,92,220,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("63cb5219-81b3-4e2c-8f12-bb56e164296d"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,75,111,27,71,12,254,43,194,38,71,83,152,247,67,215,166,7,3,142,27,196,105,46,177,15,156,25,178,17,42,107,13,237,42,69,106,232,191,151,90,219,141,29,52,142,225,34,64,140,100,15,163,213,236,240,205,143,228,92,118,207,199,143,23,212,45,186,55,180,217,224,208,243,56,255,165,223,208,252,213,166,175,52,12,243,163,190,226,106,249,55,150,21,189,194,13,158,211,72,155,183,184,218,210,112,180,28,198,131,217,93,178,238,160,123,254,97,250,218,45,222,93,118,135,35,157,255,126,216,132,187,13,37,25,102,15,17,139,1,167,179,3,44,150,193,170,90,180,165,236,61,103,33,174,253,106,123,190,126,73,35,190,194,241,125,183,184,236,38,110,194,160,84,85,77,11,10,60,218,6,46,57,5,136,142,160,6,69,24,99,32,163,66,183,59,232,134,250,158,206,113,18,250,137,216,105,228,148,41,67,244,170,128,163,82,32,85,172,192,108,115,9,194,76,83,221,19,95,159,255,68,248,238,217,81,223,255,185,189,152,27,99,157,174,77,131,47,214,130,171,34,62,43,173,33,112,12,217,18,7,114,110,238,53,182,106,169,130,245,74,14,21,45,58,42,17,152,10,217,162,72,107,86,233,217,217,94,80,91,14,23,43,252,248,246,139,242,78,70,252,131,230,199,253,56,91,174,197,227,52,140,212,174,72,47,238,68,225,54,241,229,233,85,48,79,187,197,233,151,194,121,253,123,50,121,233,110,64,63,143,229,105,119,112,218,157,244,219,77,221,115,180,251,63,55,190,157,36,168,235,7,254,99,185,121,174,120,76,100,47,113,45,38,109,142,69,226,68,62,125,122,129,35,78,194,223,136,222,55,140,139,201,94,69,205,16,9,179,68,43,24,72,77,35,100,157,11,219,104,37,143,204,68,253,154,88,92,179,174,116,87,177,135,196,106,162,159,36,127,82,230,38,237,100,103,189,93,173,38,1,195,100,255,62,143,175,21,191,254,242,226,86,0,111,113,232,219,146,151,212,14,215,143,113,213,174,219,237,14,110,131,134,41,145,82,146,167,21,155,24,210,170,24,18,108,130,90,75,108,49,70,109,72,223,11,154,92,76,204,53,6,80,70,11,3,246,26,176,182,0,54,219,64,90,133,92,154,251,150,160,105,172,107,77,1,130,137,85,244,151,5,155,196,85,53,49,140,10,22,167,234,156,99,82,33,136,125,24,45,137,24,57,94,74,206,64,46,70,174,37,187,98,30,10,154,99,162,54,19,228,140,219,225,39,116,30,7,157,7,68,236,73,64,135,108,77,149,91,132,20,154,56,34,154,8,69,115,5,157,72,74,116,12,141,26,221,11,29,111,146,142,214,37,169,31,74,131,83,218,75,130,134,0,210,174,84,141,197,123,87,211,183,128,206,187,195,225,183,191,214,180,185,242,194,130,113,53,208,217,92,118,63,219,248,117,69,231,180,30,23,151,150,124,8,74,20,37,118,98,169,47,12,185,153,6,94,9,172,178,49,170,56,218,9,193,191,197,126,113,233,147,173,10,99,131,76,123,231,136,74,83,130,0,151,80,17,153,181,225,182,59,251,26,232,36,142,227,102,89,182,227,178,95,207,46,246,237,106,82,252,103,151,122,24,212,116,144,169,32,72,69,78,76,251,137,200,103,129,106,147,137,33,41,219,92,72,182,53,251,36,160,22,163,115,201,234,4,214,54,129,11,23,169,25,190,25,40,145,77,110,156,49,122,119,47,212,164,71,49,89,82,32,189,74,9,131,164,160,160,98,96,31,26,27,231,37,175,235,83,133,90,109,158,136,171,131,80,245,190,14,201,82,164,243,66,144,90,90,106,198,90,3,61,6,106,175,233,124,185,110,180,153,113,191,153,245,63,18,238,178,42,65,60,159,64,177,212,115,167,157,32,40,198,12,198,25,37,47,200,89,197,251,112,247,96,197,190,119,220,233,170,114,170,94,178,81,55,47,189,90,38,220,162,116,131,146,117,165,160,209,219,175,92,169,208,41,12,142,81,46,41,132,210,226,72,218,128,147,97,17,125,174,186,177,76,97,150,159,42,238,146,49,81,250,53,1,133,40,147,175,66,153,124,45,91,48,90,25,98,47,169,17,241,49,184,59,193,21,13,179,182,252,176,28,100,239,71,193,92,249,159,55,50,223,146,243,161,56,208,94,202,188,107,228,37,85,101,65,150,105,138,67,204,190,126,183,152,59,219,253,3,114,234,137,80,36,17,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddReminderParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("55dd5f60-cee9-44b6-8f68-b543a4174bf2"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				Value = @"ae7a5bc6-115f-4ed2-97c5-13f5c5142c37",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7a3aa063-9af4-482e-adbf-9312dad8b0bf"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e6f433c-09c2-46dc-89d2-80e6a8f6ebda"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				UId = new Guid("ddff7e72-873c-4e34-a274-b1fe98dc4dc5"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95dfe792-7d3e-4db6-8add-2effff3ca7f4"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,203,110,27,71,16,252,149,197,58,135,4,208,16,243,126,232,22,56,15,24,112,28,195,118,124,49,125,232,153,233,137,136,80,164,64,46,99,56,130,254,61,181,75,57,150,156,132,18,2,25,136,45,235,64,73,187,219,61,59,221,93,213,213,195,243,254,171,225,237,25,247,199,253,11,222,108,104,187,110,195,236,225,122,195,179,167,155,117,225,237,118,246,120,93,104,185,248,131,242,146,159,210,134,78,121,224,205,75,90,238,120,251,120,177,29,142,186,235,102,253,81,255,213,239,211,221,254,248,213,121,255,104,224,211,95,30,85,120,215,161,88,153,109,20,185,89,43,108,178,36,146,138,73,20,199,170,70,215,92,37,130,113,89,47,119,167,171,159,120,160,167,52,156,244,199,231,253,228,13,14,216,55,110,193,122,209,200,37,97,165,100,17,131,199,95,214,6,99,179,34,45,77,127,113,212,111,203,9,159,210,180,232,123,99,226,64,46,23,47,148,114,77,88,174,90,164,80,156,80,166,185,226,148,213,197,132,209,248,242,249,247,134,43,126,211,253,184,91,212,175,231,189,85,212,98,226,36,130,147,25,62,114,22,177,80,17,173,153,148,189,141,86,113,153,247,223,140,110,234,98,123,182,164,183,47,239,198,219,217,181,176,95,245,119,62,223,103,111,222,31,207,255,45,127,151,191,159,79,97,185,158,193,15,147,55,239,143,230,253,243,245,110,83,70,143,102,252,231,93,48,167,21,228,229,143,248,135,143,119,63,123,31,147,217,79,180,162,95,121,243,4,43,78,230,211,173,239,104,160,105,241,23,120,239,119,142,179,78,78,6,213,68,96,66,70,217,107,17,171,26,43,36,229,102,130,209,173,233,201,250,25,55,222,240,170,240,245,23,35,93,173,12,164,68,169,132,226,50,168,48,42,65,137,24,201,178,206,45,21,29,39,251,105,229,247,47,243,174,206,112,101,181,91,46,167,5,182,211,254,199,194,189,124,241,203,59,223,93,201,233,21,15,235,186,104,11,174,143,86,255,37,84,23,253,197,197,209,85,148,176,37,74,153,80,157,206,27,97,93,66,85,104,163,68,42,53,200,214,152,124,59,140,18,43,149,53,170,84,161,170,211,192,134,74,130,84,83,34,120,31,200,56,107,171,46,119,143,146,87,15,94,61,218,254,252,102,197,155,125,20,142,27,45,183,252,122,134,171,31,92,248,171,0,143,207,67,200,173,56,171,132,34,164,218,102,199,34,215,16,132,97,171,83,177,217,155,208,46,94,63,120,125,8,80,175,30,76,171,238,31,250,130,147,155,112,162,124,102,227,29,128,209,24,213,161,64,164,177,86,41,40,74,83,173,143,166,86,243,73,224,68,213,164,106,115,96,8,99,43,202,156,155,200,32,17,225,181,243,133,56,235,160,205,65,156,72,167,146,53,173,162,135,164,8,198,64,56,114,177,70,148,150,1,180,108,117,148,246,127,130,19,35,75,243,120,89,100,41,42,97,139,65,190,100,140,232,20,222,185,160,129,22,171,110,198,201,99,166,122,95,96,162,141,84,209,249,0,234,51,5,201,213,82,68,31,131,104,213,183,4,0,164,148,235,33,152,220,250,197,254,239,48,41,49,54,175,107,21,213,27,136,140,156,156,136,6,205,193,104,14,172,172,66,143,212,7,97,82,56,180,20,100,20,174,100,224,204,40,47,50,25,180,232,228,217,24,149,156,209,31,5,38,207,223,110,95,210,102,49,138,206,217,195,221,6,57,26,144,105,126,177,56,229,155,10,29,166,216,127,247,251,7,230,93,133,125,71,171,218,13,112,210,77,207,223,23,60,84,173,56,113,179,162,72,15,121,36,21,200,78,199,81,73,43,138,42,40,136,38,123,63,240,80,57,160,144,179,144,60,246,63,116,61,145,146,110,80,91,174,98,24,25,131,210,14,226,129,26,43,116,135,32,56,41,112,177,54,192,67,168,65,56,155,171,115,49,168,20,63,194,16,2,246,94,175,127,219,157,205,106,41,153,115,116,194,17,230,5,139,249,65,36,168,66,136,61,34,42,25,233,172,110,70,222,87,25,89,9,205,186,10,150,120,81,42,146,16,27,133,109,202,145,14,221,141,221,98,191,222,147,245,128,240,23,26,22,235,85,183,207,220,236,219,221,112,178,254,162,184,110,57,153,220,38,99,159,4,116,92,107,177,176,65,221,122,208,135,85,25,61,53,85,76,92,227,20,175,180,107,62,199,131,208,105,81,66,180,5,40,253,150,240,225,85,16,217,3,58,212,90,163,172,114,170,46,220,61,116,158,15,155,197,234,87,208,239,10,85,140,177,251,9,115,237,16,159,238,246,82,236,251,37,159,162,129,28,159,115,225,104,124,246,162,186,138,22,56,14,88,68,77,66,131,18,212,115,198,4,234,236,197,117,237,86,157,244,232,177,96,9,165,161,68,164,130,224,52,165,8,103,106,148,164,141,214,46,140,38,223,175,134,197,240,246,225,20,60,76,70,198,67,229,81,0,95,51,172,26,102,226,44,141,21,218,57,157,209,117,49,26,153,81,241,29,97,39,221,186,117,195,9,119,101,189,26,168,12,255,117,111,41,59,28,174,212,38,16,159,128,0,131,57,178,102,108,213,107,19,93,74,54,164,246,193,222,144,183,160,117,82,96,64,203,40,109,232,210,104,140,17,206,83,85,86,178,7,215,254,125,111,228,74,161,144,80,66,1,186,4,58,155,96,213,50,4,70,210,185,214,20,80,103,211,222,176,181,55,180,237,206,198,254,202,21,89,27,214,221,9,250,247,186,181,27,78,89,14,228,252,25,84,112,87,118,219,97,125,202,155,110,53,222,248,250,225,62,114,223,204,126,88,108,182,67,183,24,213,3,130,186,225,237,110,57,192,17,66,187,92,114,25,57,112,54,2,239,80,220,39,255,203,105,145,253,245,219,56,253,1,48,238,86,123,207,55,239,250,243,151,43,174,224,164,162,41,140,57,74,142,3,207,40,228,147,39,97,48,159,146,167,70,165,149,123,33,87,146,150,202,120,223,4,142,71,37,176,2,10,73,181,129,60,193,11,42,122,171,188,114,7,57,55,52,139,243,213,52,50,45,78,146,44,196,222,120,46,38,225,47,152,170,193,34,89,125,4,185,242,79,248,251,66,185,159,0,229,118,119,203,185,159,8,229,222,98,215,95,56,247,222,112,46,206,200,131,194,57,168,144,22,223,198,88,194,201,34,116,58,216,23,95,94,249,16,109,45,55,156,44,50,7,19,51,6,67,167,34,32,167,75,216,43,254,100,66,54,248,142,195,202,86,239,158,115,231,253,120,192,55,239,15,97,244,234,51,159,127,69,215,154,13,41,102,33,3,227,132,23,172,10,214,132,146,174,160,73,21,179,196,41,239,103,123,8,248,250,226,79,12,70,62,115,215,29,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2af26cad-fdd2-4138-9712-bb3c00009344"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
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

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("88b815f6-9ed2-474a-a40e-f96b169054b4"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,20,22,141,43,13,103,121,213,20,76,54,220,50,205,65,50,107,108,137,185,203,27,173,36,161,61,116,88,147,21,189,181,62,18,234,35,118,161,190,157,127,147,198,113,66,122,239,206,201,87,115,192,14,190,45,13,36,7,167,52,106,86,21,89,195,36,54,13,83,6,12,115,78,232,166,148,74,114,52,100,213,98,11,157,73,173,145,85,198,85,76,106,80,76,59,37,24,20,38,19,194,102,80,112,78,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,44,12,48,35,117,154,212,97,197,64,104,203,4,52,85,94,41,228,37,175,8,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,185,200,184,42,202,132,229,194,48,41,242,140,169,82,85,204,217,210,105,20,165,214,141,189,248,245,105,242,41,246,225,106,234,112,244,230,197,118,76,254,13,99,61,155,161,143,227,208,46,212,87,231,231,55,248,20,87,115,95,174,126,172,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,25,172,239,31,86,206,211,41,65,186,35,140,62,92,92,216,62,78,208,18,58,250,135,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,180,100,103,185,203,14,90,31,142,45,60,159,243,154,188,123,156,134,248,225,51,130,93,35,242,6,81,147,59,34,50,227,74,45,211,106,41,197,153,52,34,99,144,41,149,150,178,44,138,42,71,153,75,126,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,246,133,21,47,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c774b4b-6e9a-4ef1-bd4d-4af18e1f5a68"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a5fff69-b63a-49e0-a7c9-da42ff12623b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b730802-2250-4ca2-84c5-b50b5d4a07fb"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be3ad5ec-1ac1-4d88-8421-74079d80259b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19076150-3efa-4513-be4e-b624b7233322"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9adb2ee5-70ec-4c6c-b1ab-4cb1ddf4c59b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,241,75,204,77,181,50,180,50,212,241,1,114,66,42,11,82,227,193,34,6,86,6,58,129,165,137,57,153,105,153,169,41,206,249,121,37,137,201,37,8,25,207,20,16,5,0,82,99,140,34,63,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("81e8d9be-76bf-41e2-a013-9bfb7a60bbf7"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a4b4eb8-5619-4c19-a817-49e7435ddac0"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("18ee65b6-9004-44b1-b810-660c4b69eb54"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2ba36ea2-087d-4183-8f2e-029d86d94b6b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("39c22bae-af9c-474a-8c12-e087a1cc5bcc"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("befd9ddf-c017-4e87-bf55-98e25f140075"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2fd8069c-26a9-41c0-9022-20c047525340"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b92dc5ab-c714-451b-b938-04990fc76593"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("904a1de6-b8cd-43d7-a193-0a8234806d6f"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("addb84e6-59ea-4d30-acaf-3f26b8c94365"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1fbff5df-21b7-44cd-9ccc-3c395a630d2b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0083ce82-7259-49e6-bf11-a21e135d34ce"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadLeadTypeParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca3d3049-0f26-41a3-bca2-dd669a7d3396"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,193,106,220,48,16,134,95,101,209,161,39,107,145,45,89,146,221,99,216,148,92,210,208,166,165,144,132,32,75,163,68,32,219,27,91,166,9,102,223,189,227,117,182,133,28,74,78,133,130,17,146,172,255,159,153,79,163,249,62,140,231,33,38,24,106,111,226,8,217,116,225,106,98,185,168,84,99,24,149,185,6,42,44,115,212,232,210,81,85,152,188,210,80,50,239,4,201,58,211,66,77,86,245,206,133,68,178,144,160,29,235,155,249,143,105,26,38,200,238,253,113,241,213,62,66,107,190,45,1,128,185,6,154,162,160,162,226,56,0,0,6,240,5,53,133,80,166,244,22,180,214,100,205,133,131,42,133,102,130,10,15,56,228,92,208,170,241,150,230,130,57,193,29,175,140,50,36,139,224,211,238,121,63,192,56,134,190,171,103,248,61,191,126,217,99,150,107,236,179,62,78,109,71,178,22,146,185,50,233,177,38,6,24,136,210,26,106,69,85,46,33,20,53,188,114,148,155,70,21,74,67,46,115,69,50,107,246,105,177,37,23,142,100,206,36,243,221,196,9,142,206,115,192,28,11,206,114,93,74,212,230,220,82,193,11,70,181,212,138,122,39,125,5,92,86,85,227,78,188,62,77,1,231,97,188,156,90,24,130,125,197,14,200,175,31,234,217,246,93,26,250,184,88,95,30,143,95,195,115,90,225,190,254,250,177,22,148,112,127,17,145,67,54,141,112,22,3,116,105,215,217,222,133,238,97,245,60,28,80,210,238,205,16,198,19,133,221,211,100,34,201,134,240,240,248,87,90,103,211,152,250,246,63,42,53,195,50,209,3,155,236,152,238,210,131,46,140,251,104,94,142,235,154,124,120,154,250,244,241,11,24,183,137,56,108,207,195,48,166,205,210,175,155,222,111,176,248,41,38,180,219,216,62,70,176,203,101,111,47,1,220,38,97,6,171,150,188,137,81,147,91,98,125,46,177,121,75,170,75,235,241,157,32,145,74,48,75,161,129,162,204,189,173,114,197,182,58,7,237,170,6,168,146,13,30,202,1,219,156,229,124,233,226,70,25,201,154,198,171,109,105,101,37,21,118,185,44,64,83,81,50,142,88,241,56,56,41,45,119,78,114,87,222,18,36,240,79,234,186,185,24,63,255,236,78,47,118,101,124,183,197,221,55,27,187,8,45,94,6,222,229,59,64,28,80,112,117,10,85,207,239,193,178,72,118,93,10,233,101,125,185,245,252,30,78,135,187,133,212,221,1,191,95,243,2,190,158,223,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bb7fdf0-23d9-4a53-9bfc-b65d5b2b58ef"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fc1bf95-66f6-437e-ae96-ab0226deef9f"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b6eaed28-95a3-4e02-bc92-584da91d9666"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8af81470-64e6-4c25-bc4e-996386dd37c1"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("876c91d3-f5fd-430b-99a7-6da066af2251"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a511d00e-3b57-438c-ad43-a0b965ac41ff"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("d5067126-b12c-401d-83cc-53d80a232257"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c25ddf34-5ec7-43ef-9f1b-1f022d5afa06"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("39e87f5c-2965-45a4-8ce7-4446e1173001"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3aec9151-bb18-4f05-9f98-6ef24b8eb8fa"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8319a4e6-2ecb-470d-b2fd-9af8514e9ab2"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0e55a545-db7b-429c-8850-c3c910df6b27"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d246ad4e-36de-4230-bc79-a36f43b1befe"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("7ad11547-1b9b-4507-b7ff-0d224aa61262"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5bfef119-7795-4c1c-8d01-0d38138f2a41"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e1d582a-dce9-475f-9eed-bc65b2d11830"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f2209798-7b73-4a75-a59d-28e69da2bc6b"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c0961cde-8588-4fb0-975f-ddf92b6ab59c"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadLeadContactParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe828bdd-0b5b-4b21-8d0d-7fe8bbb6c978"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,98,217,178,44,185,199,176,41,185,164,233,39,133,36,4,125,140,18,129,108,111,108,153,38,152,253,239,29,175,179,45,228,80,114,42,20,27,35,141,53,239,204,60,51,154,239,194,120,30,98,130,161,241,58,142,144,77,23,174,33,90,48,94,106,94,211,220,25,73,57,175,60,53,5,207,105,33,189,17,38,151,94,149,150,100,157,110,161,33,171,247,206,133,68,178,144,160,29,155,235,249,143,104,26,38,200,238,252,113,243,197,62,64,171,191,45,1,152,48,80,138,138,81,233,161,160,156,85,138,74,231,114,170,101,94,58,46,100,233,92,73,214,92,42,175,5,20,178,166,152,147,166,28,76,69,149,148,156,86,86,215,18,159,138,213,5,201,34,248,180,123,218,15,48,142,161,239,154,25,126,175,191,62,239,49,203,53,246,89,31,167,182,35,89,11,73,95,233,244,128,149,66,14,28,165,168,229,170,162,220,67,77,117,169,28,45,181,169,139,90,2,19,172,38,153,213,251,180,200,146,11,71,50,167,147,254,174,227,4,71,229,57,96,142,69,153,51,89,9,244,101,165,165,188,44,114,42,5,166,236,157,240,10,11,85,202,184,19,175,15,83,192,117,24,47,167,22,134,96,95,176,3,242,235,135,102,182,125,151,134,62,46,210,151,199,227,95,225,41,173,112,95,126,253,88,11,74,104,95,156,200,33,155,70,56,139,1,186,180,235,108,239,66,119,191,106,30,14,232,210,238,245,16,198,19,133,221,227,164,35,201,134,112,255,240,87,90,103,211,152,250,246,63,42,53,195,50,81,3,135,236,152,238,50,131,46,140,251,168,159,143,251,134,188,123,156,250,244,254,51,104,183,137,248,217,158,135,97,76,155,101,94,55,189,223,96,241,83,76,40,183,177,125,140,96,151,102,111,63,33,171,224,3,184,141,30,209,222,37,109,211,42,67,94,133,107,200,13,177,158,9,14,80,81,89,89,79,185,69,56,138,231,150,130,129,162,98,222,42,86,231,91,201,64,58,101,128,214,194,224,33,134,179,175,115,86,82,101,188,169,181,200,141,241,245,86,59,174,114,87,73,154,87,203,192,59,137,3,95,112,65,157,147,92,8,48,165,146,229,13,65,24,255,186,196,235,139,241,227,207,238,116,143,87,242,183,91,180,190,50,236,34,180,216,34,236,240,27,152,28,208,225,234,20,170,153,223,66,104,113,217,117,41,164,231,245,62,55,243,91,144,29,110,23,104,183,7,124,127,1,10,149,52,23,245,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4af7ceb-60b9-467c-a8b3-81953d377341"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("311fcede-bca4-4fec-9a42-0f943fe03159"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f32f247-07f2-471b-ba49-b42cae200cf0"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d72c0941-da6e-42f6-b7a5-0b3ffe8b2c2e"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3356dca2-6b01-46e0-9fe2-d0de44ff97b0"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d550d767-aeda-4cf2-9b2a-90c7c38be81b"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fff72291-b74e-4830-8333-56ad140e6e7c"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05f02083-70af-4052-8ee7-2b228747244c"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("123bb774-23e8-4cbe-a707-c0bf2149c012"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a43adf8a-3d3f-4d55-bbb1-030b98ca7464"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2a298fa9-f151-46ad-b486-c3c3bcb89af4"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("51b3ba73-2cd0-43a5-b1bb-d655502ea451"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bd94e2da-67c7-4c33-985e-1f6fdecc4562"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("53665a2a-42d9-47f3-8bf4-e4ebbd2e10f3"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f382eb7c-1c7a-4c11-93b3-5b6271585801"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("377fdd7e-2835-4e98-a892-93bd77cfe77f"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8b494ce5-09e1-4403-8db2-53705a798411"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9d17e551-609b-4f07-bd28-8adbb5bf10f4"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeDistributionLeadPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bbe769c2-34d8-4a8b-a580-a9e4311e6053"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				Value = @"Distribution page",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5160bb63-99ee-4be0-ad4e-f804a2c25915"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var clientUnitSchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2021bd48-f45e-4cd3-b993-7b97a0c3308d"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				Value = @"65a13f26-c1c8-49e6-9744-ce1c028164df",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1905b493-d577-4148-a465-5b25ff5f0ab4"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702a610c-eae3-442a-b9e5-1eae1657abca"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				UId = new Guid("ab6017ca-8f69-4ec1-95d6-57eb04cec232"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1babcc34-fbcc-4e3e-84fe-432c05fdbbe5"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("583c0a7d-9ed9-49b6-919b-fb6caaff12fd"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3aeda084-6af5-44ea-8738-d38edc340131"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{51139bfa-4db4-45f7-aa2f-590d604f8469}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("63033799-a11b-4b1e-9c2b-6e17977e2c43"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("809907b4-6caf-4cda-8cd8-58f9c1196633"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				UId = new Guid("3e3ba938-a24a-464b-813e-886948488e01"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				UId = new Guid("e737696e-ab9a-464f-a9bb-64aab8d4b7b0"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				UId = new Guid("333777f3-163c-4bd8-bb72-c67051a8296f"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				UId = new Guid("1c7fb6cf-9d1e-4f58-96ef-43608663db8a"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
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
				UId = new Guid("345b747f-6492-4686-a503-0062acd716e0"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var resultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9e78508-ae1b-4141-abe0-24ed11eadb13"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"Result",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText")
			};
			resultParameter.SourceValue = new ProcessSchemaParameterValue(resultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultParameter);
			var remindToOwnerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd5eefc4-6c19-4719-be10-6babbc9acc6e"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"RemindToOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			remindToOwnerParameter.SourceValue = new ProcessSchemaParameterValue(remindToOwnerParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(remindToOwnerParameter);
			var leadOwnerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0d01d7bb-ccf9-4184-a64f-953b68988ea4"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"LeadOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			leadOwnerIdParameter.SourceValue = new ProcessSchemaParameterValue(leadOwnerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(leadOwnerIdParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8227a76e-e673-40a1-a3f3-2102ef5efe7a"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"OpportunityDepartment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			opportunityDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(opportunityDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
		}

		protected virtual void InitializeSaveLeadByDefaultParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("560bc47f-ebc5-4687-aa0c-08705e061a9a"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c4e20e54-2a71-4e75-a167-24858aec6fcb"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba1c792f-b05d-43b6-b1d4-1f6f092ae9d7"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,181,118,54,133,28,74,233,173,224,195,104,236,247,230,55,15,121,190,247,225,163,111,35,142,181,131,54,96,54,237,108,77,132,211,166,41,154,134,10,107,56,21,96,129,170,162,212,84,200,28,65,241,178,105,242,130,100,61,116,88,147,85,189,181,62,146,204,71,236,66,125,59,255,54,141,227,132,217,189,91,14,95,205,1,59,248,182,12,96,224,148,70,77,101,153,167,41,152,70,41,3,134,58,199,117,83,9,37,24,26,178,178,96,195,36,56,224,20,25,43,18,139,49,180,1,89,80,205,19,5,151,92,88,157,88,90,116,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,81,174,179,55,67,59,117,61,201,58,140,112,13,241,80,19,192,28,69,105,128,26,161,75,42,28,74,10,92,91,202,161,145,133,84,200,42,38,73,102,224,24,207,182,100,103,73,102,33,194,119,104,39,92,156,103,159,24,11,158,51,85,86,73,203,184,161,130,23,57,85,149,146,212,217,202,105,228,149,214,141,189,228,245,105,242,169,246,225,106,234,112,244,230,37,118,76,249,13,99,61,155,161,143,227,208,158,173,175,150,207,111,240,41,174,225,190,188,250,177,46,20,83,255,44,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,86,205,210,154,201,35,93,178,5,247,124,7,173,15,199,22,158,151,115,77,222,61,78,67,252,240,25,193,174,21,121,163,168,201,29,225,185,113,149,22,156,130,82,140,10,195,115,10,185,82,233,82,86,101,41,11,20,133,96,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,254,12,180,63,165,231,23,66,164,233,35,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f3fd0d58-28e8-457f-8737-49c12cc4cc1d"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,75,111,27,71,12,254,43,194,38,71,141,49,239,135,174,73,15,6,146,214,168,211,92,44,31,56,51,100,35,96,165,53,118,87,41,82,65,255,189,212,90,174,173,180,117,138,244,16,7,238,30,246,49,51,31,201,33,249,145,179,187,230,229,248,233,6,155,69,243,14,251,30,134,142,198,179,87,93,143,103,23,125,87,112,24,206,222,116,5,218,213,239,144,91,188,128,30,214,56,98,255,30,218,45,14,111,86,195,56,159,157,194,154,121,243,242,227,52,219,44,174,118,205,249,136,235,95,206,43,75,215,53,68,171,32,8,175,163,21,22,114,18,201,82,20,144,75,130,168,107,33,2,6,151,174,221,174,55,111,113,132,11,24,63,52,139,93,51,73,99,1,78,71,21,140,141,194,22,169,132,149,202,9,8,222,139,146,149,44,33,59,103,75,108,246,243,102,40,31,112,13,147,210,123,48,107,166,152,48,137,224,100,22,22,115,22,177,64,17,68,38,101,111,217,50,44,7,240,113,253,61,240,234,197,213,249,240,211,111,27,236,47,39,185,11,130,118,192,235,51,30,253,108,224,79,231,44,118,33,100,42,206,42,161,64,129,176,217,161,200,53,4,97,208,234,84,108,246,38,208,254,250,197,245,65,99,93,13,55,45,124,122,255,87,197,147,214,219,69,55,39,142,127,184,108,183,188,141,223,178,89,44,255,41,130,199,231,173,189,167,49,252,60,124,203,102,190,108,46,187,109,95,14,18,205,225,227,206,157,147,6,121,188,196,223,220,238,174,91,25,19,236,45,108,224,87,236,127,100,141,19,124,154,122,13,35,76,202,223,177,221,119,130,179,78,78,6,69,34,32,36,14,144,215,34,86,118,94,82,41,147,9,70,19,233,9,253,51,18,246,184,41,120,106,152,242,25,141,119,74,68,66,45,172,114,137,241,85,10,136,210,84,235,163,169,213,76,248,73,243,189,49,119,153,198,35,155,109,219,78,10,134,105,255,135,212,61,26,126,156,121,253,32,84,15,36,116,117,69,43,172,231,155,175,113,213,190,217,239,231,15,121,18,67,40,214,74,35,160,120,78,115,207,57,155,147,6,129,8,144,73,166,234,20,62,202,19,29,18,161,65,41,66,42,82,48,197,164,200,32,73,144,243,149,180,117,100,83,121,34,60,73,165,26,138,222,8,137,149,121,98,76,20,49,49,89,82,160,168,161,18,90,233,191,204,147,87,61,194,136,179,30,215,171,77,197,126,70,93,63,235,158,19,119,146,204,222,101,174,165,146,168,112,238,115,225,225,44,74,66,91,45,249,5,40,201,240,24,119,254,181,97,79,157,59,138,233,226,14,165,3,164,98,71,56,228,186,43,141,22,185,160,116,168,201,167,168,30,239,49,69,18,132,228,25,22,13,123,82,123,166,33,179,161,80,173,69,59,103,18,200,111,201,157,31,90,92,227,102,92,236,12,58,239,37,55,67,100,58,243,78,51,137,84,117,21,78,74,239,147,214,50,91,220,159,146,205,69,83,36,132,42,18,86,134,176,73,83,113,21,148,125,1,32,82,154,234,151,201,198,113,28,251,85,222,142,171,110,51,187,225,4,61,251,191,77,61,203,54,101,137,139,51,113,155,226,23,62,226,112,191,129,204,251,202,214,70,101,171,55,220,129,30,165,26,88,9,222,18,48,87,145,107,191,68,78,71,27,152,111,46,21,85,41,231,100,232,123,165,90,212,58,240,217,20,5,250,192,101,68,130,18,96,216,87,90,73,141,228,56,53,2,124,13,213,46,161,197,97,86,87,31,87,3,143,61,151,246,150,255,227,209,208,213,104,157,207,86,40,199,89,106,43,58,46,239,124,3,226,63,7,242,33,113,213,127,170,156,187,222,255,1,163,52,214,94,160,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadLeadLegalEntityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d817f08-09b2-4fa8-a782-fe1db9ed6e86"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,98,217,146,101,185,199,176,41,185,164,233,39,133,36,132,177,52,74,4,254,216,216,50,77,48,251,223,59,94,103,91,200,161,228,84,40,24,35,141,52,239,204,60,154,153,239,194,120,30,154,136,67,229,161,25,49,153,46,92,197,192,160,205,148,46,184,50,78,114,105,106,193,141,41,20,175,49,211,214,231,62,211,50,101,73,7,45,86,108,245,222,185,16,89,18,34,182,99,117,61,255,17,141,195,132,201,157,63,110,190,216,7,108,225,219,18,32,83,78,91,1,53,23,14,83,46,85,42,120,45,211,140,167,25,166,168,64,103,174,64,182,230,82,130,50,50,79,13,23,186,240,92,214,190,230,165,164,92,202,66,67,45,140,205,69,225,89,210,160,143,187,167,253,128,227,24,250,174,154,241,247,250,235,243,158,178,92,99,159,245,205,212,118,44,105,49,194,21,196,7,170,148,226,73,101,129,91,105,20,151,30,53,135,220,56,158,67,173,51,93,162,40,132,102,137,133,125,92,100,217,133,99,137,131,8,223,161,153,240,168,60,135,165,156,60,21,165,42,200,87,228,150,203,60,75,41,189,82,115,239,10,111,48,47,140,169,221,137,215,135,41,208,58,140,151,83,139,67,176,47,216,145,248,245,67,53,219,190,139,67,223,44,210,151,199,235,95,241,41,174,112,95,142,126,172,5,69,178,47,78,236,144,76,35,158,53,1,187,184,235,108,239,66,119,191,106,30,14,228,210,238,97,8,227,137,194,238,113,130,134,37,67,184,127,248,43,173,179,105,140,125,251,31,149,154,80,153,164,65,77,118,76,119,233,65,23,198,125,3,207,199,125,197,222,61,78,125,124,255,25,193,109,26,250,109,207,195,48,198,205,210,175,155,222,111,168,248,169,137,36,183,177,125,211,160,93,30,123,251,137,88,5,31,208,109,96,220,128,181,253,212,197,85,134,189,10,87,177,27,102,189,40,36,34,245,165,178,212,166,150,224,24,153,90,142,52,51,74,120,107,132,78,183,165,192,210,153,26,185,46,106,186,36,48,227,144,138,156,27,234,106,13,69,90,215,94,111,243,204,72,3,40,185,247,116,36,75,175,184,241,202,209,148,128,150,74,149,8,74,221,48,130,241,175,75,188,190,24,63,254,236,78,115,188,146,191,221,146,245,149,97,215,96,75,79,68,47,252,6,38,7,114,184,58,133,170,230,183,16,90,92,118,93,12,241,121,157,231,106,126,11,178,195,237,2,237,246,64,223,47,110,74,142,70,245,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d06a36c6-848d-484d-9f4f-0de81448d9c3"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f3625c2a-f59b-4f64-adf6-90e79fe7aeed"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e655a18d-ce53-4e22-a507-a753a23881c5"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd70767a-663a-4bba-9147-4f2e5aa7c244"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f39c6753-02b4-4a5e-a6ba-b99697b2ac57"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e6605cdf-474a-47e1-a009-e4527b6c1cff"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("06c6a63d-3c18-4ea8-b749-38e3092df345"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("71fb3b5e-91ec-4fdb-8587-e8a70e8e15ed"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("68101654-54da-4ebe-be44-76f2736cf13f"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e72ea618-cc5b-414c-b8fe-befedccd80ba"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("48964511-7533-43c6-91dc-e775680cb3d0"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c4510564-d6ba-477d-a3c7-57f062ecc615"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f41ffeec-9d24-433c-9ffc-47368b09b92e"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("758a9e96-25aa-48ce-bdd6-c3efae5de38d"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ddc71462-5e7d-4dd9-8436-cf519e07f134"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d5eba4a-d9f3-4d32-80fb-2650e75a0ddf"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d555ee2e-3bd7-4936-9fe7-2afdc8f4ad93"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9716805a-6341-433b-b8a8-40ebfd6e5ae3"),
				ContainerUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadLeadTypeLegalEntityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9319d39a-ef73-4a83-87bf-b5a8d1347f99"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,91,150,44,187,199,176,41,185,164,161,77,75,33,9,65,31,163,68,32,219,27,91,166,9,102,255,123,199,235,108,11,57,148,156,10,5,35,36,89,243,206,204,163,87,243,125,24,207,67,76,48,52,94,199,17,178,233,194,53,132,51,225,132,1,75,173,97,140,150,182,116,212,72,168,168,0,38,172,45,60,48,35,73,214,233,22,26,178,70,239,92,72,36,11,9,218,177,185,153,255,136,166,97,130,236,222,31,23,95,237,35,180,250,219,146,0,152,51,96,138,130,150,53,199,1,0,168,86,190,160,186,40,43,45,188,5,165,20,89,107,209,74,151,78,23,138,150,149,231,180,116,53,208,58,175,114,106,85,237,189,229,21,183,185,35,89,4,159,118,207,251,1,198,49,244,93,51,195,239,249,245,203,30,171,92,115,159,245,113,106,59,146,181,144,244,149,78,143,168,14,12,74,97,53,181,101,45,104,233,177,73,205,107,71,185,54,85,81,41,200,101,94,145,204,234,125,90,100,201,5,166,114,58,233,239,58,78,112,84,158,3,214,88,112,150,43,33,49,54,231,150,150,188,96,84,73,85,81,239,164,175,129,203,186,54,238,196,235,211,20,112,30,198,203,169,133,33,216,87,236,128,252,250,161,153,109,223,165,161,143,139,244,229,241,248,53,60,167,21,238,235,175,31,107,67,9,247,151,32,114,200,166,17,206,98,128,46,237,58,219,187,208,61,172,154,135,3,134,180,123,61,132,241,68,97,247,52,233,72,178,33,60,60,254,149,214,217,52,166,190,253,143,90,205,176,77,212,64,147,29,203,93,60,232,194,184,143,250,229,184,110,200,135,167,169,79,31,191,128,118,155,136,195,246,60,12,99,218,44,126,221,244,126,131,205,79,49,161,220,198,246,49,130,93,46,123,187,66,128,97,211,1,184,53,158,188,201,211,144,91,98,125,46,209,192,130,42,97,61,190,21,164,82,151,204,82,48,80,136,220,91,52,43,219,170,28,148,171,13,208,74,26,60,148,3,90,157,229,156,214,198,155,74,75,102,140,175,182,194,202,90,86,172,164,178,0,180,187,96,28,209,226,113,112,82,90,238,156,228,78,220,18,164,240,207,122,187,185,24,63,255,236,78,47,119,101,125,183,197,221,55,27,187,8,45,94,10,222,233,59,96,28,48,224,234,148,170,153,223,131,102,9,217,117,41,164,151,245,5,55,243,123,88,29,238,22,90,119,7,252,126,1,26,239,241,186,231,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3b689408-ddf0-4d54-a5a2-1265b86d51d1"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("078cb5da-f078-40c8-b97f-087688f40632"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38001730-4fc7-4b8a-8fed-843d0d603740"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("332a5444-b7b0-4e2e-a40f-ba4d780811e1"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3048d53f-f57f-4784-8cd4-a60b53c26e51"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5983cfa8-0380-48c3-998e-f9add536478c"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("35975265-1ff7-4807-ad9f-43f9f2ab95b2"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9040a2ec-ef7f-4ffd-ba53-7c4bedae2c07"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a0ba2644-fac5-480b-8483-55c9e6559f4d"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("458c0ef7-86bb-428c-ad09-d8644b667072"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7183aa2d-b56a-4ce7-a2ad-67e36307aad7"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("042b8f50-393b-498d-b322-b2d6af5bc6d3"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2b7b6c56-864c-45db-9d37-e83f3fbd2407"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("9d4b3c64-63e8-403e-92f3-005f5cf7fca5"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("790f0486-cb3f-420d-87a9-1d2c3c40a521"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37d7b5ca-dcfb-4db2-9c18-d3da11ba1a96"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fe5cb073-3546-43e0-9e8e-ae8b985b0732"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9bcc5a5d-7972-45ca-b70e-bf911a6ba0de"),
				ContainerUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeAddReminderLegalEntityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("8aa56ae8-b7c3-4724-ac53-c6b7749a1e9b"),
				ContainerUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
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
				Value = @"ae7a5bc6-115f-4ed2-97c5-13f5c5142c37",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3d7d5816-074a-45f2-b76c-7099ac1cb23c"),
				ContainerUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55629ab5-01ee-43ba-a096-138f35bf3a2a"),
				ContainerUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
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
				UId = new Guid("6735bda3-4f6f-4db6-b574-5d4d635b53b1"),
				ContainerUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
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
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("590f52ae-d6f6-43af-91a4-ba3d90a836bf"),
				ContainerUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,93,111,27,55,22,253,43,131,73,31,90,192,20,248,253,225,183,69,218,93,4,72,179,65,147,205,75,148,135,75,242,178,17,86,150,140,209,168,129,215,240,127,239,153,177,179,113,140,86,246,102,221,34,141,163,135,145,61,51,188,228,253,56,231,30,82,231,253,55,227,217,41,247,199,253,75,30,6,218,109,219,184,120,188,29,120,241,124,216,22,222,237,22,79,183,133,214,171,255,80,94,243,115,26,232,132,71,30,94,209,122,207,187,167,171,221,120,212,125,60,172,63,234,191,249,101,126,218,31,191,62,239,159,140,124,242,175,39,21,214,181,207,174,182,152,133,33,169,132,149,190,137,28,27,11,19,165,108,70,103,169,149,193,224,178,93,239,79,54,63,242,72,207,105,124,219,31,159,247,179,53,24,96,223,184,5,235,69,35,151,96,64,178,136,193,227,47,107,131,177,89,145,150,166,191,56,234,119,229,45,159,208,60,233,135,193,196,129,92,46,94,40,229,154,176,92,181,72,161,56,161,76,115,197,41,171,139,9,211,224,171,247,63,12,220,240,187,238,31,251,85,253,118,217,91,69,45,38,78,34,56,153,97,35,103,17,11,21,209,154,73,217,219,104,21,151,101,255,221,100,166,174,118,167,107,58,123,117,63,214,78,63,10,251,117,123,231,203,203,236,45,251,227,229,239,229,239,234,251,197,28,150,143,51,120,51,121,203,254,104,217,191,216,238,135,50,89,52,211,63,239,131,57,207,32,175,62,226,55,46,239,63,151,54,230,97,63,210,134,126,230,225,25,102,156,135,207,143,190,167,145,230,201,95,98,221,239,13,103,157,156,12,170,137,192,132,140,178,215,34,86,69,34,169,148,155,9,70,183,166,231,209,63,113,227,129,55,133,63,94,24,233,106,101,32,37,74,37,43,172,177,86,80,9,74,196,72,150,117,110,169,232,56,143,159,103,254,176,152,247,117,134,59,155,253,122,61,79,176,155,253,159,10,247,106,225,87,79,190,191,150,211,107,22,182,117,213,86,92,159,108,62,37,84,23,253,197,197,209,117,148,176,74,41,57,173,132,73,142,133,213,33,139,164,57,8,19,124,14,210,199,144,141,63,136,18,43,149,53,170,84,161,170,211,192,134,74,130,84,83,34,120,31,200,56,107,171,46,247,143,146,215,143,94,63,217,253,243,221,134,135,203,40,28,55,90,239,248,205,2,119,111,220,248,111,1,30,159,135,144,91,113,86,9,69,72,181,205,112,56,215,0,95,217,234,84,108,246,38,180,139,55,143,222,28,2,212,235,71,79,153,106,183,157,166,190,124,243,43,88,110,3,139,242,153,141,119,64,71,99,148,136,2,155,198,90,165,160,40,77,181,62,154,90,205,95,2,44,222,122,162,232,179,208,185,162,92,125,158,90,10,192,226,91,203,202,215,204,50,241,65,176,72,167,146,53,173,162,145,164,8,218,64,56,114,177,70,148,6,176,181,108,117,148,246,51,1,139,145,165,121,44,22,89,138,104,159,197,32,95,50,70,180,11,239,92,208,128,140,85,119,3,203,67,129,137,54,82,69,231,3,248,207,20,36,87,75,17,65,160,162,85,223,18,0,144,82,174,135,96,114,231,133,125,238,48,169,74,103,155,98,21,82,73,7,225,100,162,200,190,36,225,76,116,20,155,87,108,220,65,152,20,14,45,5,25,133,43,185,34,146,202,139,76,6,125,58,121,54,70,37,103,244,31,2,147,23,103,187,87,52,172,38,229,185,120,188,31,144,163,17,153,230,151,171,19,190,173,208,49,20,254,119,191,220,24,222,77,99,59,218,212,110,50,244,80,144,80,181,226,196,205,138,34,61,212,145,84,160,57,29,39,33,173,40,170,160,160,153,236,131,64,66,9,108,11,160,32,84,42,160,4,182,82,100,86,89,160,152,137,160,53,93,101,117,16,9,212,88,161,47,4,193,73,129,133,181,1,18,66,13,194,217,92,157,139,65,165,248,7,236,65,192,219,219,237,191,247,167,139,90,74,230,28,157,112,132,237,130,197,246,65,164,134,61,20,50,72,84,50,210,89,221,130,188,175,50,178,18,154,117,21,44,177,80,42,146,16,27,229,92,149,19,17,186,91,251,196,229,124,207,182,35,194,95,104,92,109,55,221,101,229,46,30,15,12,232,212,46,159,61,20,248,252,191,155,147,187,100,237,175,1,31,29,139,211,16,142,206,147,17,182,178,17,49,27,84,191,171,94,57,236,103,131,13,7,225,211,162,172,73,5,136,253,150,112,241,42,160,19,1,62,212,90,163,172,114,170,46,220,63,124,94,140,195,106,243,51,106,104,131,74,198,206,251,25,163,124,17,159,187,235,176,31,214,124,130,238,113,124,238,145,199,168,3,4,179,151,40,133,18,17,1,244,70,65,65,73,227,76,75,144,21,23,55,132,155,75,193,105,143,117,182,22,144,125,9,119,107,130,3,120,187,105,202,201,101,61,13,249,97,51,174,198,179,199,115,236,176,55,50,30,18,143,2,40,155,193,84,13,133,151,165,177,66,59,167,51,90,46,54,71,102,146,123,71,112,164,219,182,110,124,139,182,86,202,118,143,30,7,215,186,79,240,45,197,164,200,224,44,34,58,131,228,68,21,69,84,18,253,194,66,97,90,3,191,125,187,225,155,244,197,147,55,85,152,130,183,45,19,148,69,176,9,103,58,108,100,210,181,25,235,126,195,183,18,21,206,128,88,52,151,128,135,0,237,30,33,111,69,100,124,53,149,91,140,105,246,13,174,189,163,93,119,58,113,4,87,36,109,220,118,111,209,188,183,173,221,114,206,242,251,41,255,105,218,46,150,253,110,220,158,240,208,109,166,251,223,254,237,50,112,223,45,254,190,26,118,99,183,154,148,3,98,58,240,110,191,30,97,167,67,69,175,185,76,44,184,152,96,119,40,236,179,253,245,116,185,186,255,63,24,189,221,223,47,159,108,93,193,41,69,83,216,221,168,233,152,176,76,250,61,121,66,73,153,74,158,26,149,86,30,132,86,81,185,32,12,228,133,246,19,28,155,131,212,176,216,165,251,144,179,226,88,180,15,242,32,217,134,102,139,227,52,81,236,4,51,40,189,233,76,76,10,215,130,169,48,106,50,14,92,255,20,178,253,68,66,250,74,182,127,38,217,118,247,203,182,215,216,240,51,101,219,59,56,252,149,110,31,12,221,154,164,88,234,92,68,1,92,160,126,52,14,163,67,133,208,75,224,59,82,85,135,122,203,207,83,28,12,212,176,23,78,69,156,170,234,18,46,85,126,50,56,179,199,238,193,202,86,239,159,110,151,253,116,164,183,236,15,193,243,250,59,95,126,69,215,154,13,41,102,33,3,131,38,43,118,107,57,64,62,87,201,94,197,140,31,27,191,220,99,191,55,23,191,2,114,242,103,88,206,29,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2fbea2ce-a3a1-4680-b731-b7708322ec68"),
				ContainerUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadDistributionProcess = CreateLeadDistributionProcessLaneSet();
			LaneSets.Add(schemaLeadDistributionProcess);
			ProcessSchemaLane schemaLeadDistribution = CreateLeadDistributionLane();
			schemaLeadDistributionProcess.Lanes.Add(schemaLeadDistribution);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminatehandoff = CreateTerminateHandoffTerminateEvent();
			FlowElements.Add(terminatehandoff);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaTerminateEvent terminateleadisnotset = CreateTerminateLeadIsNotSetTerminateEvent();
			FlowElements.Add(terminateleadisnotset);
			ProcessSchemaUserTask saveleadhandoff = CreateSaveLeadHandoffUserTask();
			FlowElements.Add(saveleadhandoff);
			ProcessSchemaUserTask saveleadnointerest = CreateSaveLeadNoInterestUserTask();
			FlowElements.Add(saveleadnointerest);
			ProcessSchemaTerminateEvent terminatenointerest = CreateTerminateNoInterestTerminateEvent();
			FlowElements.Add(terminatenointerest);
			ProcessSchemaTerminateEvent terminatecontinuedistribution = CreateTerminateContinueDistributionTerminateEvent();
			FlowElements.Add(terminatecontinuedistribution);
			ProcessSchemaUserTask addreminder = CreateAddReminderUserTask();
			FlowElements.Add(addreminder);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask readleadtype = CreateReadLeadTypeUserTask();
			FlowElements.Add(readleadtype);
			ProcessSchemaUserTask readleadcontact = CreateReadLeadContactUserTask();
			FlowElements.Add(readleadcontact);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask distributionleadpage = CreateDistributionLeadPageUserTask();
			FlowElements.Add(distributionleadpage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask saveleadbydefault = CreateSaveLeadByDefaultUserTask();
			FlowElements.Add(saveleadbydefault);
			ProcessSchemaUserTask readleadlegalentity = CreateReadLeadLegalEntityUserTask();
			FlowElements.Add(readleadlegalentity);
			ProcessSchemaUserTask readleadtypelegalentity = CreateReadLeadTypeLegalEntityUserTask();
			FlowElements.Add(readleadtypelegalentity);
			ProcessSchemaUserTask addreminderlegalentity = CreateAddReminderLegalEntityUserTask();
			FlowElements.Add(addreminderlegalentity);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlowCreateReminderConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlowNoReminderSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlowContactIsNotEmptyConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5fb58e15-c3e0-48b9-b270-c3878ba5ec8d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("5805d2d7-5516-4f97-9107-0c6b5c4bbc5c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(182, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("290d5fde-c5b4-44ae-9d6b-38bd65766e89"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(598, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowCreateReminderConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowCreateReminder",
				UId = new Guid("97e8e894-d220-43dc-9cfa-0e37f8166e2a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9cd3f863-0eda-4338-895e-97f82adfe406}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(648, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("e7b9f7af-f3f3-45b3-b5ef-e55931027930"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(677, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1153, 148));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowNoReminderSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowNoReminder",
				UId = new Guid("74e4203e-f8b4-42a4-9a72-43c7354d017c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(916, 130),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("8e0f40d1-6611-4d88-a2b3-db13f8f8268e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(220, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f5da7633-709e-40ac-ab2f-51d79b4f1e75"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{a9e78508-ae1b-4141-abe0-24ed11eadb13}]#] == ""TransferToSale""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(480, 152),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("15c1b993-b41b-4b3d-be24-96f8a835c457"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{a9e78508-ae1b-4141-abe0-24ed11eadb13}]#] == ""NotInteresting""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(468, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("7f0e3663-1ccd-4022-9a63-af412567e1dd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(348, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("1d497f73-83f1-49f1-922b-d98d94ddb5e6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(562, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("68e53e5d-ec55-45bb-8ce1-febdee9aa067"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(562, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8693d20e-d10c-4049-b6c4-7b603c0c353d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(1144, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("efeba810-1988-471e-8f37-8fdf1b4013e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(920, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("a2112edf-8702-462c-8323-8546cb7408a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(1026, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("9c88a080-7559-4bf7-9165-a3acc247e49a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlowContactIsNotEmptyConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlowContactIsNotEmpty",
				UId = new Guid("a32d93f4-b840-4d4b-b744-d6780a387368"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf164ee5-85cf-4c3c-940c-ebe251fc9170}].[Parameter:{81e8d9be-76bf-41e2-a013-9bfb7a60bbf7}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("1618f43b-a357-472c-8277-98e7da49c82c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(565, 259));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("6be2f646-285a-42a4-aad8-54143a70c837"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("1d6ef57a-1302-41cc-83f8-954f183aa2cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1072, 259));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadDistributionProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadDistributionProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4d9afef7-9066-439f-b71e-60e2c82e61da"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"LeadDistributionProcess",
				Position = new Point(5, 5),
				Size = new Size(1344, 436),
				UseBackgroundMode = false
			};
			return schemaLeadDistributionProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadDistributionLane() {
			ProcessSchemaLane schemaLeadDistribution = new ProcessSchemaLane(this) {
				UId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4d9afef7-9066-439f-b71e-60e2c82e61da"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"LeadDistribution",
				Position = new Point(29, 0),
				Size = new Size(1315, 436),
				UseBackgroundMode = false
			};
			return schemaLeadDistribution;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"Start",
				Position = new Point(50, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateHandoffTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"TerminateHandoff",
				Position = new Point(1140, 245),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ExclusiveGatewayIsLeadSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(36, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateLeadIsNotSetTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"TerminateLeadIsNotSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(50, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"SaveLeadHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(371, 121),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeSaveLeadHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadNoInterestUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"SaveLeadNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(320, 233),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeSaveLeadNoInterestParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNoInterestTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"TerminateNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(440, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateContinueDistributionTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"TerminateContinueDistribution",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(440, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddReminderUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"AddReminder",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(927, 121),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddReminderParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(531, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadTypeUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ReadLeadType",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(800, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadTypeParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadContactUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ReadLeadContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(672, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadContactParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1045, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateDistributionLeadPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"DistributionLeadPage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(131, 121),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeDistributionLeadPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(240, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadByDefaultUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"SaveLeadByDefault",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(320, 20),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeSaveLeadByDefaultParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadLegalEntityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9891a30b-853a-4818-8104-44655438826f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ReadLeadLegalEntity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(672, 231),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadLegalEntityParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadTypeLegalEntityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"ReadLeadTypeLegalEntity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(800, 231),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadTypeLegalEntityParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddReminderLegalEntityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b910345f-655b-452d-9367-72c0a6654487"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("701b459b-d838-482d-8e35-c88c82decc6d"),
				CreatedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"),
				Name = @"AddReminderLegalEntity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(927, 231),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddReminderLegalEntityParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementDistributionFinance(userConnection);
		}

		public override object Clone() {
			return new LeadManagementDistributionFinanceSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementDistributionFinance

	/// <exclude/>
	public class LeadManagementDistributionFinance : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadDistribution

		/// <exclude/>
		public class ProcessLeadDistribution : ProcessLane
		{

			public ProcessLeadDistribution(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SaveLeadHandoffFlowElement

		/// <exclude/>
		public class SaveLeadHandoffFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadHandoffFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("ceb70b3c-985f-4867-ae7c-88f9dd710688"));
				_recordColumnValues_Owner = () => (Guid)((process.ResponsibleId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.CreateReminder));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,198,178,236,30,151,109,89,40,105,160,105,41,36,75,24,75,163,172,192,127,54,182,76,19,204,126,247,202,235,108,10,57,148,210,91,193,135,209,216,239,167,55,143,241,124,239,199,143,190,9,52,84,14,155,145,146,105,103,43,38,108,86,103,136,192,51,5,5,7,43,5,199,210,104,14,160,92,46,108,129,194,32,75,58,108,169,98,171,122,107,125,96,137,15,212,142,213,237,252,27,26,134,137,146,123,119,62,124,53,7,106,241,219,114,1,164,232,116,73,37,47,114,81,115,160,186,230,218,160,225,206,201,178,86,160,33,37,195,86,47,168,4,101,26,136,231,18,4,135,28,11,94,103,96,121,90,80,14,153,148,145,3,44,105,200,133,237,211,113,160,113,244,125,87,205,244,90,223,60,31,163,203,245,238,77,223,76,109,199,146,150,2,94,99,56,68,58,9,130,220,32,55,80,230,28,28,21,28,101,105,185,196,186,200,10,77,169,74,11,150,24,60,134,5,203,118,150,37,22,3,126,199,102,162,51,121,246,209,99,38,69,170,115,21,181,169,52,28,100,38,184,86,186,224,206,42,87,146,84,101,89,219,75,94,159,38,31,107,63,94,77,45,13,222,188,196,78,49,191,126,168,102,211,119,97,232,155,5,125,117,254,252,134,158,194,26,238,203,171,31,235,64,33,246,23,17,59,37,211,72,155,198,83,23,182,157,233,173,239,30,86,230,233,20,37,237,17,7,63,94,82,216,62,78,216,176,100,240,15,135,63,166,181,153,198,208,183,255,209,168,73,28,51,50,226,146,157,237,46,59,104,253,120,108,240,249,124,174,216,187,199,169,15,31,62,19,218,181,98,111,20,21,187,99,82,24,167,74,144,28,181,78,57,152,101,235,133,214,113,41,85,158,23,25,65,6,233,29,139,46,254,129,125,187,27,191,252,236,46,255,192,234,122,255,62,118,223,52,174,47,202,106,254,27,59,167,253,98,104,127,138,207,47,177,221,110,55,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,77,111,27,71,12,134,255,138,176,201,209,20,230,251,67,215,164,64,13,36,109,80,39,185,196,62,112,102,200,70,168,164,53,118,215,41,82,67,255,189,212,218,110,236,160,177,141,22,69,83,164,123,88,73,51,122,201,153,33,159,33,47,187,167,211,199,115,234,86,221,107,26,6,28,123,158,150,207,250,129,150,175,134,190,210,56,46,95,244,21,55,235,223,176,108,232,21,14,184,165,137,134,183,184,185,160,241,197,122,156,142,22,119,101,221,81,247,244,195,60,219,173,222,93,118,199,19,109,223,28,55,177,238,189,106,190,22,3,177,198,12,46,132,2,217,39,5,92,115,225,20,93,174,236,68,92,251,205,197,118,247,146,38,124,133,211,251,110,117,217,205,214,196,64,169,170,154,22,20,120,180,13,92,114,10,16,29,65,13,138,48,198,64,70,133,110,127,212,141,245,61,109,113,118,250,73,236,52,114,202,148,33,122,85,192,81,41,144,42,86,96,182,185,4,49,166,169,30,196,215,255,255,36,124,247,228,69,223,255,114,113,190,52,198,58,93,155,6,95,172,5,87,197,125,86,90,67,224,24,178,37,14,228,220,178,82,137,170,216,10,57,121,150,53,134,8,72,177,66,74,156,91,139,90,133,148,158,156,29,28,181,245,120,190,193,143,111,191,232,239,100,194,159,105,249,61,238,90,207,188,152,250,197,136,27,26,175,196,231,119,226,112,91,126,121,122,21,206,211,110,117,250,165,128,94,127,158,204,231,116,55,164,159,71,243,180,59,58,237,78,250,139,161,30,44,218,195,143,155,211,157,61,168,235,7,254,228,117,243,92,217,152,101,47,113,39,155,26,126,16,143,179,124,158,122,142,19,206,206,95,203,186,111,12,23,147,189,138,154,33,18,74,182,80,48,144,154,70,200,90,178,197,70,107,152,205,172,254,137,152,6,218,85,186,187,176,199,68,107,214,207,158,63,45,230,38,241,100,100,119,177,217,204,14,198,121,255,135,76,190,94,248,245,204,243,91,33,188,101,161,111,107,94,83,59,222,253,149,163,218,119,251,253,209,109,108,170,71,195,70,69,40,25,221,33,163,52,148,36,178,26,16,99,65,91,53,231,123,177,241,38,233,104,93,146,67,80,26,156,210,30,48,134,0,181,104,85,99,241,222,213,244,79,96,243,238,120,252,241,215,29,13,87,167,176,98,220,140,116,182,148,209,207,6,254,72,192,213,101,140,133,171,119,26,52,74,168,93,241,4,165,197,8,150,156,201,213,149,96,35,239,207,30,226,103,246,250,63,39,143,227,68,135,66,54,120,13,137,201,128,211,62,11,103,77,110,214,164,108,115,33,217,214,236,127,130,19,149,66,50,1,21,88,169,50,224,140,145,45,57,169,49,5,117,200,45,20,143,84,238,229,196,196,204,100,73,65,204,85,129,99,41,77,5,21,3,251,208,216,56,207,82,161,190,18,78,114,109,150,83,176,160,168,9,39,214,38,72,89,96,201,145,147,193,198,228,84,120,152,147,103,3,225,68,139,129,182,235,93,163,97,193,253,176,232,191,37,118,178,42,193,75,239,1,138,89,82,70,203,197,147,162,244,38,198,25,37,95,144,179,138,247,177,243,232,133,125,237,236,4,118,45,81,36,161,254,208,89,69,41,52,41,248,8,146,73,213,251,92,144,93,186,151,29,116,10,131,99,4,148,86,76,106,12,5,200,46,6,64,159,171,110,92,74,182,252,111,178,243,221,134,182,180,155,86,151,150,124,8,74,138,33,9,206,224,36,250,144,155,105,224,149,10,33,27,163,138,163,253,93,216,146,49,81,10,38,1,133,40,157,132,66,13,104,217,130,209,202,16,123,73,141,136,15,195,38,113,156,134,117,185,152,214,253,110,113,126,232,236,78,14,237,220,162,173,63,172,71,25,251,86,152,43,127,179,175,243,45,57,31,138,3,237,229,170,118,141,60,20,37,47,100,105,103,56,196,236,235,87,203,220,217,254,119,206,104,149,80,108,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "753374fefdb24c4d9a027f8fc6ec273a",
							"BaseElements.SaveLeadHandoff.Parameters.RecordColumnValues.Value");
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

		#region Class: SaveLeadNoInterestFlowElement

		/// <exclude/>
		public class SaveLeadNoInterestFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadNoInterestFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadNoInterest";
				IsLogging = true;
				SchemaElementUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("51adc3ec-3503-4b10-a00b-8be3b0e11f08"));
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("f78066d3-a73e-4e86-bb99-e477fcb94b28"));
				_recordColumnValues_Owner = () => (Guid)((process.DistributionLeadPage.OwnerId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.DistributionLeadPage.RemindToOwner));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,245,225,30,151,109,89,40,105,160,105,41,36,75,144,165,81,86,224,143,141,37,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,154,247,230,205,99,52,223,135,248,49,180,9,198,218,155,54,2,158,118,174,70,69,229,20,48,197,8,5,230,9,23,162,36,186,162,21,113,86,73,203,37,99,32,27,132,123,211,65,141,86,244,214,133,132,112,72,208,197,250,118,254,77,154,198,9,240,189,63,95,190,218,3,116,230,219,210,128,83,227,149,6,77,100,85,52,132,67,211,16,101,141,37,222,51,221,8,174,56,5,139,86,45,76,23,66,230,90,82,22,174,36,220,8,75,180,84,146,72,224,180,148,90,59,90,50,132,91,240,105,251,116,28,33,198,48,244,245,12,175,241,205,243,49,171,92,123,111,134,118,234,122,132,59,72,230,218,164,67,141,12,20,192,43,107,136,229,186,34,220,131,36,134,105,71,152,105,100,41,21,80,65,37,194,214,28,211,66,139,118,14,97,103,146,249,110,218,9,206,204,115,200,26,75,86,80,85,137,140,165,204,18,206,202,130,40,145,53,122,39,188,6,38,180,110,220,197,175,79,83,200,113,136,87,83,7,99,176,47,182,67,246,111,24,235,217,14,125,26,135,118,161,190,58,151,223,192,83,90,205,125,121,250,177,14,148,114,126,1,161,19,158,34,108,218,0,125,218,246,118,112,161,127,88,57,79,167,12,233,142,102,12,241,226,194,246,113,50,45,194,99,120,56,252,209,173,205,20,211,208,253,71,163,226,60,102,230,200,75,118,150,187,236,160,11,241,216,154,231,243,189,70,239,30,167,33,125,248,12,198,173,17,122,131,168,209,29,98,133,245,66,115,70,140,82,148,112,203,10,98,10,165,242,82,138,170,146,37,240,146,211,59,148,85,252,3,247,237,46,126,249,217,95,254,192,170,122,255,62,103,223,36,174,47,200,122,254,27,57,167,253,34,104,127,202,231,23,171,70,92,220,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,75,111,27,71,12,254,43,194,38,71,83,152,247,67,215,166,7,3,142,27,196,105,46,177,15,156,25,178,17,42,107,13,237,42,69,106,232,191,151,90,219,141,29,52,142,225,34,64,140,100,15,163,213,236,240,205,143,228,92,118,207,199,143,23,212,45,186,55,180,217,224,208,243,56,255,165,223,208,252,213,166,175,52,12,243,163,190,226,106,249,55,150,21,189,194,13,158,211,72,155,183,184,218,210,112,180,28,198,131,217,93,178,238,160,123,254,97,250,218,45,222,93,118,135,35,157,255,126,216,132,187,13,37,25,102,15,17,139,1,167,179,3,44,150,193,170,90,180,165,236,61,103,33,174,253,106,123,190,126,73,35,190,194,241,125,183,184,236,38,110,194,160,84,85,77,11,10,60,218,6,46,57,5,136,142,160,6,69,24,99,32,163,66,183,59,232,134,250,158,206,113,18,250,137,216,105,228,148,41,67,244,170,128,163,82,32,85,172,192,108,115,9,194,76,83,221,19,95,159,255,68,248,238,217,81,223,255,185,189,152,27,99,157,174,77,131,47,214,130,171,34,62,43,173,33,112,12,217,18,7,114,110,238,53,182,106,169,130,245,74,14,21,45,58,42,17,152,10,217,162,72,107,86,233,217,217,94,80,91,14,23,43,252,248,246,139,242,78,70,252,131,230,199,253,56,91,174,197,227,52,140,212,174,72,47,238,68,225,54,241,229,233,85,48,79,187,197,233,151,194,121,253,123,50,121,233,110,64,63,143,229,105,119,112,218,157,244,219,77,221,115,180,251,63,55,190,157,36,168,235,7,254,99,185,121,174,120,76,100,47,113,45,38,109,142,69,226,68,62,125,122,129,35,78,194,223,136,222,55,140,139,201,94,69,205,16,9,179,68,43,24,72,77,35,100,157,11,219,104,37,143,204,68,253,154,88,92,179,174,116,87,177,135,196,106,162,159,36,127,82,230,38,237,100,103,189,93,173,38,1,195,100,255,62,143,175,21,191,254,242,226,86,0,111,113,232,219,146,151,212,14,215,143,113,213,174,219,237,14,110,131,134,41,145,82,146,167,21,155,24,210,170,24,18,108,130,90,75,108,49,70,109,72,223,11,154,92,76,204,53,6,80,70,11,3,246,26,176,182,0,54,219,64,90,133,92,154,251,150,160,105,172,107,77,1,130,137,85,244,151,5,155,196,85,53,49,140,10,22,167,234,156,99,82,33,136,125,24,45,137,24,57,94,74,206,64,46,70,174,37,187,98,30,10,154,99,162,54,19,228,140,219,225,39,116,30,7,157,7,68,236,73,64,135,108,77,149,91,132,20,154,56,34,154,8,69,115,5,157,72,74,116,12,141,26,221,11,29,111,146,142,214,37,169,31,74,131,83,218,75,130,134,0,210,174,84,141,197,123,87,211,183,128,206,187,195,225,183,191,214,180,185,242,194,130,113,53,208,217,92,118,63,219,248,117,69,231,180,30,23,151,150,124,8,74,20,37,118,98,169,47,12,185,153,6,94,9,172,178,49,170,56,218,9,193,191,197,126,113,233,147,173,10,99,131,76,123,231,136,74,83,130,0,151,80,17,153,181,225,182,59,251,26,232,36,142,227,102,89,182,227,178,95,207,46,246,237,106,82,252,103,151,122,24,212,116,144,169,32,72,69,78,76,251,137,200,103,129,106,147,137,33,41,219,92,72,182,53,251,36,160,22,163,115,201,234,4,214,54,129,11,23,169,25,190,25,40,145,77,110,156,49,122,119,47,212,164,71,49,89,82,32,189,74,9,131,164,160,160,98,96,31,26,27,231,37,175,235,83,133,90,109,158,136,171,131,80,245,190,14,201,82,164,243,66,144,90,90,106,198,90,3,61,6,106,175,233,124,185,110,180,153,113,191,153,245,63,18,238,178,42,65,60,159,64,177,212,115,167,157,32,40,198,12,198,25,37,47,200,89,197,251,112,247,96,197,190,119,220,233,170,114,170,94,178,81,55,47,189,90,38,220,162,116,131,146,117,165,160,209,219,175,92,169,208,41,12,142,81,46,41,132,210,226,72,218,128,147,97,17,125,174,186,177,76,97,150,159,42,238,146,49,81,250,53,1,133,40,147,175,66,153,124,45,91,48,90,25,98,47,169,17,241,49,184,59,193,21,13,179,182,252,176,28,100,239,71,193,92,249,159,55,50,223,146,243,161,56,208,94,202,188,107,228,37,85,101,65,150,105,138,67,204,190,126,183,152,59,219,253,3,114,234,137,80,36,17,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "753374fefdb24c4d9a027f8fc6ec273a",
							"BaseElements.SaveLeadNoInterest.Parameters.RecordColumnValues.Value");
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

		#region Class: AddReminderFlowElement

		/// <exclude/>
		public class AddReminderFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddReminderFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddReminder";
				IsLogging = true;
				SchemaElementUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_SysEntitySchema = () => (Guid)(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
				_recordDefValues_Contact = () => (Guid)((process.ResponsibleId));
				_recordDefValues_SubjectId = () => (Guid)((process.LeadId));
				_recordDefValues_RemindTime = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
				_recordDefValues_Source = () => (Guid)(new Guid("a66d08e1-2e2d-e011-ac0a-00155d043205"));
				_recordDefValues_SubjectCaption = () => new LocalizableString(String.Concat("Need ", ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the contact ", ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null))," was proceeded to handoff"));
				_recordDefValues_Description = () => new LocalizableString(String.Concat("Need", ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the contact ", ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " was proceeded to handoff"));
				_recordDefValues_TypeCaption = () => new LocalizableString("Lead");
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_SysEntitySchema", () => _recordDefValues_SysEntitySchema.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectId", () => _recordDefValues_SubjectId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_RemindTime", () => _recordDefValues_RemindTime.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Source", () => _recordDefValues_Source.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectCaption", () => _recordDefValues_SubjectCaption.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Description", () => _recordDefValues_Description.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_TypeCaption", () => _recordDefValues_TypeCaption.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_SysEntitySchema;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_SubjectId;
			internal Func<DateTime> _recordDefValues_RemindTime;
			internal Func<Guid> _recordDefValues_Source;
			internal Func<string> _recordDefValues_SubjectCaption;
			internal Func<string> _recordDefValues_Description;
			internal Func<string> _recordDefValues_TypeCaption;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,203,110,27,71,16,252,149,197,58,135,4,208,16,243,126,232,22,56,15,24,112,28,195,118,124,49,125,232,153,233,137,136,80,164,64,46,99,56,130,254,61,181,75,57,150,156,132,18,2,25,136,45,235,64,73,187,219,61,59,221,93,213,213,195,243,254,171,225,237,25,247,199,253,11,222,108,104,187,110,195,236,225,122,195,179,167,155,117,225,237,118,246,120,93,104,185,248,131,242,146,159,210,134,78,121,224,205,75,90,238,120,251,120,177,29,142,186,235,102,253,81,255,213,239,211,221,254,248,213,121,255,104,224,211,95,30,85,120,215,161,88,153,109,20,185,89,43,108,178,36,146,138,73,20,199,170,70,215,92,37,130,113,89,47,119,167,171,159,120,160,167,52,156,244,199,231,253,228,13,14,216,55,110,193,122,209,200,37,97,165,100,17,131,199,95,214,6,99,179,34,45,77,127,113,212,111,203,9,159,210,180,232,123,99,226,64,46,23,47,148,114,77,88,174,90,164,80,156,80,166,185,226,148,213,197,132,209,248,242,249,247,134,43,126,211,253,184,91,212,175,231,189,85,212,98,226,36,130,147,25,62,114,22,177,80,17,173,153,148,189,141,86,113,153,247,223,140,110,234,98,123,182,164,183,47,239,198,219,217,181,176,95,245,119,62,223,103,111,222,31,207,255,45,127,151,191,159,79,97,185,158,193,15,147,55,239,143,230,253,243,245,110,83,70,143,102,252,231,93,48,167,21,228,229,143,248,135,143,119,63,123,31,147,217,79,180,162,95,121,243,4,43,78,230,211,173,239,104,160,105,241,23,120,239,119,142,179,78,78,6,213,68,96,66,70,217,107,17,171,26,43,36,229,102,130,209,173,233,201,250,25,55,222,240,170,240,245,23,35,93,173,12,164,68,169,132,226,50,168,48,42,65,137,24,201,178,206,45,21,29,39,251,105,229,247,47,243,174,206,112,101,181,91,46,167,5,182,211,254,199,194,189,124,241,203,59,223,93,201,233,21,15,235,186,104,11,174,143,86,255,37,84,23,253,197,197,209,85,148,176,37,74,153,80,157,206,27,97,93,66,85,104,163,68,42,53,200,214,152,124,59,140,18,43,149,53,170,84,161,170,211,192,134,74,130,84,83,34,120,31,200,56,107,171,46,119,143,146,87,15,94,61,218,254,252,102,197,155,125,20,142,27,45,183,252,122,134,171,31,92,248,171,0,143,207,67,200,173,56,171,132,34,164,218,102,199,34,215,16,132,97,171,83,177,217,155,208,46,94,63,120,125,8,80,175,30,76,171,238,31,250,130,147,155,112,162,124,102,227,29,128,209,24,213,161,64,164,177,86,41,40,74,83,173,143,166,86,243,73,224,68,213,164,106,115,96,8,99,43,202,156,155,200,32,17,225,181,243,133,56,235,160,205,65,156,72,167,146,53,173,162,135,164,8,198,64,56,114,177,70,148,150,1,180,108,117,148,246,127,130,19,35,75,243,120,89,100,41,42,97,139,65,190,100,140,232,20,222,185,160,129,22,171,110,198,201,99,166,122,95,96,162,141,84,209,249,0,234,51,5,201,213,82,68,31,131,104,213,183,4,0,164,148,235,33,152,220,250,197,254,239,48,41,49,54,175,107,21,213,27,136,140,156,156,136,6,205,193,104,14,172,172,66,143,212,7,97,82,56,180,20,100,20,174,100,224,204,40,47,50,25,180,232,228,217,24,149,156,209,31,5,38,207,223,110,95,210,102,49,138,206,217,195,221,6,57,26,144,105,126,177,56,229,155,10,29,166,216,127,247,251,7,230,93,133,125,71,171,218,13,112,210,77,207,223,23,60,84,173,56,113,179,162,72,15,121,36,21,200,78,199,81,73,43,138,42,40,136,38,123,63,240,80,57,160,144,179,144,60,246,63,116,61,145,146,110,80,91,174,98,24,25,131,210,14,226,129,26,43,116,135,32,56,41,112,177,54,192,67,168,65,56,155,171,115,49,168,20,63,194,16,2,246,94,175,127,219,157,205,106,41,153,115,116,194,17,230,5,139,249,65,36,168,66,136,61,34,42,25,233,172,110,70,222,87,25,89,9,205,186,10,150,120,81,42,146,16,27,133,109,202,145,14,221,141,221,98,191,222,147,245,128,240,23,26,22,235,85,183,207,220,236,219,221,112,178,254,162,184,110,57,153,220,38,99,159,4,116,92,107,177,176,65,221,122,208,135,85,25,61,53,85,76,92,227,20,175,180,107,62,199,131,208,105,81,66,180,5,40,253,150,240,225,85,16,217,3,58,212,90,163,172,114,170,46,220,61,116,158,15,155,197,234,87,208,239,10,85,140,177,251,9,115,237,16,159,238,246,82,236,251,37,159,162,129,28,159,115,225,104,124,246,162,186,138,22,56,14,88,68,77,66,131,18,212,115,198,4,234,236,197,117,237,86,157,244,232,177,96,9,165,161,68,164,130,224,52,165,8,103,106,148,164,141,214,46,140,38,223,175,134,197,240,246,225,20,60,76,70,198,67,229,81,0,95,51,172,26,102,226,44,141,21,218,57,157,209,117,49,26,153,81,241,29,97,39,221,186,117,195,9,119,101,189,26,168,12,255,117,111,41,59,28,174,212,38,16,159,128,0,131,57,178,102,108,213,107,19,93,74,54,164,246,193,222,144,183,160,117,82,96,64,203,40,109,232,210,104,140,17,206,83,85,86,178,7,215,254,125,111,228,74,161,144,80,66,1,186,4,58,155,96,213,50,4,70,210,185,214,20,80,103,211,222,176,181,55,180,237,206,198,254,202,21,89,27,214,221,9,250,247,186,181,27,78,89,14,228,252,25,84,112,87,118,219,97,125,202,155,110,53,222,248,250,225,62,114,223,204,126,88,108,182,67,183,24,213,3,130,186,225,237,110,57,192,17,66,187,92,114,25,57,112,54,2,239,80,220,39,255,203,105,145,253,245,219,56,253,1,48,238,86,123,207,55,239,250,243,151,43,174,224,164,162,41,140,57,74,142,3,207,40,228,147,39,97,48,159,146,167,70,165,149,123,33,87,146,150,202,120,223,4,142,71,37,176,2,10,73,181,129,60,193,11,42,122,171,188,114,7,57,55,52,139,243,213,52,50,45,78,146,44,196,222,120,46,38,225,47,152,170,193,34,89,125,4,185,242,79,248,251,66,185,159,0,229,118,119,203,185,159,8,229,222,98,215,95,56,247,222,112,46,206,200,131,194,57,168,144,22,223,198,88,194,201,34,116,58,216,23,95,94,249,16,109,45,55,156,44,50,7,19,51,6,67,167,34,32,167,75,216,43,254,100,66,54,248,142,195,202,86,239,158,115,231,253,120,192,55,239,15,97,244,234,51,159,127,69,215,154,13,41,102,33,3,227,132,23,172,10,214,132,146,174,160,73,21,179,196,41,239,103,123,8,248,250,226,79,12,70,62,115,215,29,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "753374fefdb24c4d9a027f8fc6ec273a",
							"BaseElements.AddReminder.Parameters.RecordDefValues.Value");
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

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,20,22,141,43,13,103,121,213,20,76,54,220,50,205,65,50,107,108,137,185,203,27,173,36,161,61,116,88,147,21,189,181,62,18,234,35,118,161,190,157,127,147,198,113,66,122,239,206,201,87,115,192,14,190,45,13,36,7,167,52,106,86,21,89,195,36,54,13,83,6,12,115,78,232,166,148,74,114,52,100,213,98,11,157,73,173,145,85,198,85,76,106,80,76,59,37,24,20,38,19,194,102,80,112,78,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,44,12,48,35,117,154,212,97,197,64,104,203,4,52,85,94,41,228,37,175,8,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,185,200,184,42,202,132,229,194,48,41,242,140,169,82,85,204,217,210,105,20,165,214,141,189,248,245,105,242,41,246,225,106,234,112,244,230,197,118,76,254,13,99,61,155,161,143,227,208,46,212,87,231,231,55,248,20,87,115,95,174,126,172,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,25,172,239,31,86,206,211,41,65,186,35,140,62,92,92,216,62,78,208,18,58,250,135,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,180,100,103,185,203,14,90,31,142,45,60,159,243,154,188,123,156,134,248,225,51,130,93,35,242,6,81,147,59,34,50,227,74,45,211,106,41,197,153,52,34,99,144,41,149,150,178,44,138,42,71,153,75,126,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,246,133,21,47,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,241,75,204,77,181,50,180,50,212,241,1,114,66,42,11,82,227,193,34,6,86,6,58,129,165,137,57,153,105,153,169,41,206,249,121,37,137,201,37,8,25,207,20,16,5,0,82,99,140,34,63,0,0,0 })));
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

		#region Class: ReadLeadTypeFlowElement

		/// <exclude/>
		public class ReadLeadTypeFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadTypeFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadType";
				IsLogging = true;
				SchemaElementUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,193,106,220,48,16,134,95,101,209,161,39,107,145,45,89,146,221,99,216,148,92,210,208,166,165,144,132,32,75,163,68,32,219,27,91,166,9,102,223,189,227,117,182,133,28,74,78,133,130,17,146,172,255,159,153,79,163,249,62,140,231,33,38,24,106,111,226,8,217,116,225,106,98,185,168,84,99,24,149,185,6,42,44,115,212,232,210,81,85,152,188,210,80,50,239,4,201,58,211,66,77,86,245,206,133,68,178,144,160,29,235,155,249,143,105,26,38,200,238,253,113,241,213,62,66,107,190,45,1,128,185,6,154,162,160,162,226,56,0,0,6,240,5,53,133,80,166,244,22,180,214,100,205,133,131,42,133,102,130,10,15,56,228,92,208,170,241,150,230,130,57,193,29,175,140,50,36,139,224,211,238,121,63,192,56,134,190,171,103,248,61,191,126,217,99,150,107,236,179,62,78,109,71,178,22,146,185,50,233,177,38,6,24,136,210,26,106,69,85,46,33,20,53,188,114,148,155,70,21,74,67,46,115,69,50,107,246,105,177,37,23,142,100,206,36,243,221,196,9,142,206,115,192,28,11,206,114,93,74,212,230,220,82,193,11,70,181,212,138,122,39,125,5,92,86,85,227,78,188,62,77,1,231,97,188,156,90,24,130,125,197,14,200,175,31,234,217,246,93,26,250,184,88,95,30,143,95,195,115,90,225,190,254,250,177,22,148,112,127,17,145,67,54,141,112,22,3,116,105,215,217,222,133,238,97,245,60,28,80,210,238,205,16,198,19,133,221,211,100,34,201,134,240,240,248,87,90,103,211,152,250,246,63,42,53,195,50,209,3,155,236,152,238,210,131,46,140,251,104,94,142,235,154,124,120,154,250,244,241,11,24,183,137,56,108,207,195,48,166,205,210,175,155,222,111,176,248,41,38,180,219,216,62,70,176,203,101,111,47,1,220,38,97,6,171,150,188,137,81,147,91,98,125,46,177,121,75,170,75,235,241,157,32,145,74,48,75,161,129,162,204,189,173,114,197,182,58,7,237,170,6,168,146,13,30,202,1,219,156,229,124,233,226,70,25,201,154,198,171,109,105,101,37,21,118,185,44,64,83,81,50,142,88,241,56,56,41,45,119,78,114,87,222,18,36,240,79,234,186,185,24,63,255,236,78,47,118,101,124,183,197,221,55,27,187,8,45,94,6,222,229,59,64,28,80,112,117,10,85,207,239,193,178,72,118,93,10,233,101,125,185,245,252,30,78,135,187,133,212,221,1,191,95,243,2,190,158,223,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
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
								new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"));
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

		#region Class: ReadLeadContactFlowElement

		/// <exclude/>
		public class ReadLeadContactFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadContactFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadContact";
				IsLogging = true;
				SchemaElementUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,98,217,178,44,185,199,176,41,185,164,233,39,133,36,4,125,140,18,129,108,111,108,153,38,152,253,239,29,175,179,45,228,80,114,42,20,27,35,141,53,239,204,60,51,154,239,194,120,30,98,130,161,241,58,142,144,77,23,174,33,90,48,94,106,94,211,220,25,73,57,175,60,53,5,207,105,33,189,17,38,151,94,149,150,100,157,110,161,33,171,247,206,133,68,178,144,160,29,155,235,249,143,104,26,38,200,238,252,113,243,197,62,64,171,191,45,1,152,48,80,138,138,81,233,161,160,156,85,138,74,231,114,170,101,94,58,46,100,233,92,73,214,92,42,175,5,20,178,166,152,147,166,28,76,69,149,148,156,86,86,215,18,159,138,213,5,201,34,248,180,123,218,15,48,142,161,239,154,25,126,175,191,62,239,49,203,53,246,89,31,167,182,35,89,11,73,95,233,244,128,149,66,14,28,165,168,229,170,162,220,67,77,117,169,28,45,181,169,139,90,2,19,172,38,153,213,251,180,200,146,11,71,50,167,147,254,174,227,4,71,229,57,96,142,69,153,51,89,9,244,101,165,165,188,44,114,42,5,166,236,157,240,10,11,85,202,184,19,175,15,83,192,117,24,47,167,22,134,96,95,176,3,242,235,135,102,182,125,151,134,62,46,210,151,199,227,95,225,41,173,112,95,126,253,88,11,74,104,95,156,200,33,155,70,56,139,1,186,180,235,108,239,66,119,191,106,30,14,232,210,238,245,16,198,19,133,221,227,164,35,201,134,112,255,240,87,90,103,211,152,250,246,63,42,53,195,50,81,3,135,236,152,238,50,131,46,140,251,168,159,143,251,134,188,123,156,250,244,254,51,104,183,137,248,217,158,135,97,76,155,101,94,55,189,223,96,241,83,76,40,183,177,125,140,96,151,102,111,63,33,171,224,3,184,141,30,209,222,37,109,211,42,67,94,133,107,200,13,177,158,9,14,80,81,89,89,79,185,69,56,138,231,150,130,129,162,98,222,42,86,231,91,201,64,58,101,128,214,194,224,33,134,179,175,115,86,82,101,188,169,181,200,141,241,245,86,59,174,114,87,73,154,87,203,192,59,137,3,95,112,65,157,147,92,8,48,165,146,229,13,65,24,255,186,196,235,139,241,227,207,238,116,143,87,242,183,91,180,190,50,236,34,180,216,34,236,240,27,152,28,208,225,234,20,170,153,223,66,104,113,217,117,41,164,231,245,62,55,243,91,144,29,110,23,104,183,7,124,127,1,10,149,52,23,245,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
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

		#region Class: DistributionLeadPageFlowElement

		/// <exclude/>
		public class DistributionLeadPageFlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public DistributionLeadPageFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DistributionLeadPage";
				IsLogging = true;
				SchemaElementUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadDistribution;
				SerializeToDB = true;
				_showExecutionPage = () => (bool)((process.ShowDistributionPage));
				_leadId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("753374fefdb24c4d9a027f8fc6ec273a",
						 "BaseElements.DistributionLeadPage.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("65a13f26-c1c8-49e6-9744-ce1c028164df");
			public override Guid ClientUnitSchemaUId {
				get {
					return _clientUnitSchemaUId;
				}
				set {
					_clientUnitSchemaUId = value;
				}
			}

			private bool _useCardProcessModule = true;
			public override bool UseCardProcessModule {
				get {
					return _useCardProcessModule;
				}
				set {
					_useCardProcessModule = value;
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

			internal Func<Guid> _leadId;
			public virtual Guid LeadId {
				get {
					return (_leadId ?? (_leadId = () => Guid.Empty)).Invoke();
				}
				set {
					_leadId = () => { return value; };
				}
			}

			public virtual string Result {
				get;
				set;
			}

			public virtual bool RemindToOwner {
				get;
				set;
			}

			public virtual Guid LeadOwnerId {
				get;
				set;
			}

			public virtual Guid OpportunityDepartment {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Class: SaveLeadByDefaultFlowElement

		/// <exclude/>
		public class SaveLeadByDefaultFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadByDefaultFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadByDefault";
				IsLogging = true;
				SchemaElementUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Owner = () => (Guid)((process.ResponsibleId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.CreateReminder));
				_recordColumnValues_SalesOwner = () => (Guid)((process.DistributionLeadPage.OwnerId));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SalesOwner", () => _recordColumnValues_SalesOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
			internal Func<Guid> _recordColumnValues_SalesOwner;
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,181,118,54,133,28,74,233,173,224,195,104,236,247,230,55,15,121,190,247,225,163,111,35,142,181,131,54,96,54,237,108,77,132,211,166,41,154,134,10,107,56,21,96,129,170,162,212,84,200,28,65,241,178,105,242,130,100,61,116,88,147,85,189,181,62,146,204,71,236,66,125,59,255,54,141,227,132,217,189,91,14,95,205,1,59,248,182,12,96,224,148,70,77,101,153,167,41,152,70,41,3,134,58,199,117,83,9,37,24,26,178,178,96,195,36,56,224,20,25,43,18,139,49,180,1,89,80,205,19,5,151,92,88,157,88,90,116,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,81,174,179,55,67,59,117,61,201,58,140,112,13,241,80,19,192,28,69,105,128,26,161,75,42,28,74,10,92,91,202,161,145,133,84,200,42,38,73,102,224,24,207,182,100,103,73,102,33,194,119,104,39,92,156,103,159,24,11,158,51,85,86,73,203,184,161,130,23,57,85,149,146,212,217,202,105,228,149,214,141,189,228,245,105,242,169,246,225,106,234,112,244,230,37,118,76,249,13,99,61,155,161,143,227,208,158,173,175,150,207,111,240,41,174,225,190,188,250,177,46,20,83,255,44,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,86,205,210,154,201,35,93,178,5,247,124,7,173,15,199,22,158,151,115,77,222,61,78,67,252,240,25,193,174,21,121,163,168,201,29,225,185,113,149,22,156,130,82,140,10,195,115,10,185,82,233,82,86,101,41,11,20,133,96,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,254,12,180,63,165,231,23,66,164,233,35,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,75,111,27,71,12,254,43,194,38,71,141,49,239,135,174,73,15,6,146,214,168,211,92,44,31,56,51,100,35,96,165,53,118,87,41,82,65,255,189,212,90,174,173,180,117,138,244,16,7,238,30,246,49,51,31,201,33,249,145,179,187,230,229,248,233,6,155,69,243,14,251,30,134,142,198,179,87,93,143,103,23,125,87,112,24,206,222,116,5,218,213,239,144,91,188,128,30,214,56,98,255,30,218,45,14,111,86,195,56,159,157,194,154,121,243,242,227,52,219,44,174,118,205,249,136,235,95,206,43,75,215,53,68,171,32,8,175,163,21,22,114,18,201,82,20,144,75,130,168,107,33,2,6,151,174,221,174,55,111,113,132,11,24,63,52,139,93,51,73,99,1,78,71,21,140,141,194,22,169,132,149,202,9,8,222,139,146,149,44,33,59,103,75,108,246,243,102,40,31,112,13,147,210,123,48,107,166,152,48,137,224,100,22,22,115,22,177,64,17,68,38,101,111,217,50,44,7,240,113,253,61,240,234,197,213,249,240,211,111,27,236,47,39,185,11,130,118,192,235,51,30,253,108,224,79,231,44,118,33,100,42,206,42,161,64,129,176,217,161,200,53,4,97,208,234,84,108,246,38,208,254,250,197,245,65,99,93,13,55,45,124,122,255,87,197,147,214,219,69,55,39,142,127,184,108,183,188,141,223,178,89,44,255,41,130,199,231,173,189,167,49,252,60,124,203,102,190,108,46,187,109,95,14,18,205,225,227,206,157,147,6,121,188,196,223,220,238,174,91,25,19,236,45,108,224,87,236,127,100,141,19,124,154,122,13,35,76,202,223,177,221,119,130,179,78,78,6,69,34,32,36,14,144,215,34,86,118,94,82,41,147,9,70,19,233,9,253,51,18,246,184,41,120,106,152,242,25,141,119,74,68,66,45,172,114,137,241,85,10,136,210,84,235,163,169,213,76,248,73,243,189,49,119,153,198,35,155,109,219,78,10,134,105,255,135,212,61,26,126,156,121,253,32,84,15,36,116,117,69,43,172,231,155,175,113,213,190,217,239,231,15,121,18,67,40,214,74,35,160,120,78,115,207,57,155,147,6,129,8,144,73,166,234,20,62,202,19,29,18,161,65,41,66,42,82,48,197,164,200,32,73,144,243,149,180,117,100,83,121,34,60,73,165,26,138,222,8,137,149,121,98,76,20,49,49,89,82,160,168,161,18,90,233,191,204,147,87,61,194,136,179,30,215,171,77,197,126,70,93,63,235,158,19,119,146,204,222,101,174,165,146,168,112,238,115,225,225,44,74,66,91,45,249,5,40,201,240,24,119,254,181,97,79,157,59,138,233,226,14,165,3,164,98,71,56,228,186,43,141,22,185,160,116,168,201,167,168,30,239,49,69,18,132,228,25,22,13,123,82,123,166,33,179,161,80,173,69,59,103,18,200,111,201,157,31,90,92,227,102,92,236,12,58,239,37,55,67,100,58,243,78,51,137,84,117,21,78,74,239,147,214,50,91,220,159,146,205,69,83,36,132,42,18,86,134,176,73,83,113,21,148,125,1,32,82,154,234,151,201,198,113,28,251,85,222,142,171,110,51,187,225,4,61,251,191,77,61,203,54,101,137,139,51,113,155,226,23,62,226,112,191,129,204,251,202,214,70,101,171,55,220,129,30,165,26,88,9,222,18,48,87,145,107,191,68,78,71,27,152,111,46,21,85,41,231,100,232,123,165,90,212,58,240,217,20,5,250,192,101,68,130,18,96,216,87,90,73,141,228,56,53,2,124,13,213,46,161,197,97,86,87,31,87,3,143,61,151,246,150,255,227,209,208,213,104,157,207,86,40,199,89,106,43,58,46,239,124,3,226,63,7,242,33,113,213,127,170,156,187,222,255,1,163,52,214,94,160,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "753374fefdb24c4d9a027f8fc6ec273a",
							"BaseElements.SaveLeadByDefault.Parameters.RecordColumnValues.Value");
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

		#region Class: ReadLeadLegalEntityFlowElement

		/// <exclude/>
		public class ReadLeadLegalEntityFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadLegalEntityFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadLegalEntity";
				IsLogging = true;
				SchemaElementUId = new Guid("9891a30b-853a-4818-8104-44655438826f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,98,217,146,101,185,199,176,41,185,164,233,39,133,36,132,177,52,74,4,254,216,216,50,77,48,251,223,59,94,103,91,200,161,228,84,40,24,35,141,52,239,204,60,154,153,239,194,120,30,154,136,67,229,161,25,49,153,46,92,197,192,160,205,148,46,184,50,78,114,105,106,193,141,41,20,175,49,211,214,231,62,211,50,101,73,7,45,86,108,245,222,185,16,89,18,34,182,99,117,61,255,17,141,195,132,201,157,63,110,190,216,7,108,225,219,18,32,83,78,91,1,53,23,14,83,46,85,42,120,45,211,140,167,25,166,168,64,103,174,64,182,230,82,130,50,50,79,13,23,186,240,92,214,190,230,165,164,92,202,66,67,45,140,205,69,225,89,210,160,143,187,167,253,128,227,24,250,174,154,241,247,250,235,243,158,178,92,99,159,245,205,212,118,44,105,49,194,21,196,7,170,148,226,73,101,129,91,105,20,151,30,53,135,220,56,158,67,173,51,93,162,40,132,102,137,133,125,92,100,217,133,99,137,131,8,223,161,153,240,168,60,135,165,156,60,21,165,42,200,87,228,150,203,60,75,41,189,82,115,239,10,111,48,47,140,169,221,137,215,135,41,208,58,140,151,83,139,67,176,47,216,145,248,245,67,53,219,190,139,67,223,44,210,151,199,235,95,241,41,174,112,95,142,126,172,5,69,178,47,78,236,144,76,35,158,53,1,187,184,235,108,239,66,119,191,106,30,14,228,210,238,97,8,227,137,194,238,113,130,134,37,67,184,127,248,43,173,179,105,140,125,251,31,149,154,80,153,164,65,77,118,76,119,233,65,23,198,125,3,207,199,125,197,222,61,78,125,124,255,25,193,109,26,250,109,207,195,48,198,205,210,175,155,222,111,168,248,169,137,36,183,177,125,211,160,93,30,123,251,137,88,5,31,208,109,96,220,128,181,253,212,197,85,134,189,10,87,177,27,102,189,40,36,34,245,165,178,212,166,150,224,24,153,90,142,52,51,74,120,107,132,78,183,165,192,210,153,26,185,46,106,186,36,48,227,144,138,156,27,234,106,13,69,90,215,94,111,243,204,72,3,40,185,247,116,36,75,175,184,241,202,209,148,128,150,74,149,8,74,221,48,130,241,175,75,188,190,24,63,254,236,78,115,188,146,191,221,146,245,149,97,215,96,75,79,68,47,252,6,38,7,114,184,58,133,170,230,183,16,90,92,118,93,12,241,121,157,231,106,126,11,178,195,237,2,237,246,64,223,47,110,74,142,70,245,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
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
								new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"));
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

		#region Class: ReadLeadTypeLegalEntityFlowElement

		/// <exclude/>
		public class ReadLeadTypeLegalEntityFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadTypeLegalEntityFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadTypeLegalEntity";
				IsLogging = true;
				SchemaElementUId = new Guid("6eb88279-8609-4c83-87f9-a710353f9369");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,91,150,44,187,199,176,41,185,164,161,77,75,33,9,65,31,163,68,32,219,27,91,166,9,102,255,123,199,235,108,11,57,148,156,10,5,35,36,89,243,206,204,163,87,243,125,24,207,67,76,48,52,94,199,17,178,233,194,53,132,51,225,132,1,75,173,97,140,150,182,116,212,72,168,168,0,38,172,45,60,48,35,73,214,233,22,26,178,70,239,92,72,36,11,9,218,177,185,153,255,136,166,97,130,236,222,31,23,95,237,35,180,250,219,146,0,152,51,96,138,130,150,53,199,1,0,168,86,190,160,186,40,43,45,188,5,165,20,89,107,209,74,151,78,23,138,150,149,231,180,116,53,208,58,175,114,106,85,237,189,229,21,183,185,35,89,4,159,118,207,251,1,198,49,244,93,51,195,239,249,245,203,30,171,92,115,159,245,113,106,59,146,181,144,244,149,78,143,168,14,12,74,97,53,181,101,45,104,233,177,73,205,107,71,185,54,85,81,41,200,101,94,145,204,234,125,90,100,201,5,166,114,58,233,239,58,78,112,84,158,3,214,88,112,150,43,33,49,54,231,150,150,188,96,84,73,85,81,239,164,175,129,203,186,54,238,196,235,211,20,112,30,198,203,169,133,33,216,87,236,128,252,250,161,153,109,223,165,161,143,139,244,229,241,248,53,60,167,21,238,235,175,31,107,67,9,247,151,32,114,200,166,17,206,98,128,46,237,58,219,187,208,61,172,154,135,3,134,180,123,61,132,241,68,97,247,52,233,72,178,33,60,60,254,149,214,217,52,166,190,253,143,90,205,176,77,212,64,147,29,203,93,60,232,194,184,143,250,229,184,110,200,135,167,169,79,31,191,128,118,155,136,195,246,60,12,99,218,44,126,221,244,126,131,205,79,49,161,220,198,246,49,130,93,46,123,187,66,128,97,211,1,184,53,158,188,201,211,144,91,98,125,46,209,192,130,42,97,61,190,21,164,82,151,204,82,48,80,136,220,91,52,43,219,170,28,148,171,13,208,74,26,60,148,3,90,157,229,156,214,198,155,74,75,102,140,175,182,194,202,90,86,172,164,178,0,180,187,96,28,209,226,113,112,82,90,238,156,228,78,220,18,164,240,207,122,187,185,24,63,255,236,78,47,119,101,125,183,197,221,55,27,187,8,45,94,10,222,233,59,96,28,48,224,234,148,170,153,223,131,102,9,217,117,41,164,151,245,5,55,243,123,88,29,238,22,90,119,7,252,126,1,26,239,241,186,231,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
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
								new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"));
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

		#region Class: AddReminderLegalEntityFlowElement

		/// <exclude/>
		public class AddReminderLegalEntityFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddReminderLegalEntityFlowElement(UserConnection userConnection, LeadManagementDistributionFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddReminderLegalEntity";
				IsLogging = true;
				SchemaElementUId = new Guid("b910345f-655b-452d-9367-72c0a6654487");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_SysEntitySchema = () => (Guid)(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
				_recordDefValues_Contact = () => (Guid)((process.ResponsibleId));
				_recordDefValues_SubjectId = () => (Guid)((process.LeadId));
				_recordDefValues_RemindTime = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
				_recordDefValues_Source = () => (Guid)(new Guid("a66d08e1-2e2d-e011-ac0a-00155d043205"));
				_recordDefValues_SubjectCaption = () => new LocalizableString(String.Concat("Need ",((process.ReadLeadTypeLegalEntity.ResultEntity.IsColumnValueLoaded(process.ReadLeadTypeLegalEntity.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadTypeLegalEntity.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the account ", ((process.ReadLeadLegalEntity.ResultEntity.IsColumnValueLoaded(process.ReadLeadLegalEntity.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadLegalEntity.ResultEntity.GetTypedColumnValue<string>("Name") : null))," was proceeded to handoff"));
				_recordDefValues_Description = () => new LocalizableString(String.Concat("Need", ((process.ReadLeadTypeLegalEntity.ResultEntity.IsColumnValueLoaded(process.ReadLeadTypeLegalEntity.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadTypeLegalEntity.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the account ", ((process.ReadLeadLegalEntity.ResultEntity.IsColumnValueLoaded(process.ReadLeadLegalEntity.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadLegalEntity.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " was proceeded to handoff"));
				_recordDefValues_TypeCaption = () => new LocalizableString("Lead");
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_SysEntitySchema", () => _recordDefValues_SysEntitySchema.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectId", () => _recordDefValues_SubjectId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_RemindTime", () => _recordDefValues_RemindTime.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Source", () => _recordDefValues_Source.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectCaption", () => _recordDefValues_SubjectCaption.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Description", () => _recordDefValues_Description.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_TypeCaption", () => _recordDefValues_TypeCaption.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_SysEntitySchema;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_SubjectId;
			internal Func<DateTime> _recordDefValues_RemindTime;
			internal Func<Guid> _recordDefValues_Source;
			internal Func<string> _recordDefValues_SubjectCaption;
			internal Func<string> _recordDefValues_Description;
			internal Func<string> _recordDefValues_TypeCaption;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,93,111,27,55,22,253,43,131,73,31,90,192,20,248,253,225,183,69,218,93,4,72,179,65,147,205,75,148,135,75,242,178,17,86,150,140,209,168,129,215,240,127,239,153,177,179,113,140,86,246,102,221,34,141,163,135,145,61,51,188,228,253,56,231,30,82,231,253,55,227,217,41,247,199,253,75,30,6,218,109,219,184,120,188,29,120,241,124,216,22,222,237,22,79,183,133,214,171,255,80,94,243,115,26,232,132,71,30,94,209,122,207,187,167,171,221,120,212,125,60,172,63,234,191,249,101,126,218,31,191,62,239,159,140,124,242,175,39,21,214,181,207,174,182,152,133,33,169,132,149,190,137,28,27,11,19,165,108,70,103,169,149,193,224,178,93,239,79,54,63,242,72,207,105,124,219,31,159,247,179,53,24,96,223,184,5,235,69,35,151,96,64,178,136,193,227,47,107,131,177,89,145,150,166,191,56,234,119,229,45,159,208,60,233,135,193,196,129,92,46,94,40,229,154,176,92,181,72,161,56,161,76,115,197,41,171,139,9,211,224,171,247,63,12,220,240,187,238,31,251,85,253,118,217,91,69,45,38,78,34,56,153,97,35,103,17,11,21,209,154,73,217,219,104,21,151,101,255,221,100,166,174,118,167,107,58,123,117,63,214,78,63,10,251,117,123,231,203,203,236,45,251,227,229,239,229,239,234,251,197,28,150,143,51,120,51,121,203,254,104,217,191,216,238,135,50,89,52,211,63,239,131,57,207,32,175,62,226,55,46,239,63,151,54,230,97,63,210,134,126,230,225,25,102,156,135,207,143,190,167,145,230,201,95,98,221,239,13,103,157,156,12,170,137,192,132,140,178,215,34,86,69,34,169,148,155,9,70,183,166,231,209,63,113,227,129,55,133,63,94,24,233,106,101,32,37,74,37,43,172,177,86,80,9,74,196,72,150,117,110,169,232,56,143,159,103,254,176,152,247,117,134,59,155,253,122,61,79,176,155,253,159,10,247,106,225,87,79,190,191,150,211,107,22,182,117,213,86,92,159,108,62,37,84,23,253,197,197,209,117,148,176,74,41,57,173,132,73,142,133,213,33,139,164,57,8,19,124,14,210,199,144,141,63,136,18,43,149,53,170,84,161,170,211,192,134,74,130,84,83,34,120,31,200,56,107,171,46,247,143,146,215,143,94,63,217,253,243,221,134,135,203,40,28,55,90,239,248,205,2,119,111,220,248,111,1,30,159,135,144,91,113,86,9,69,72,181,205,112,56,215,0,95,217,234,84,108,246,38,180,139,55,143,222,28,2,212,235,71,79,153,106,183,157,166,190,124,243,43,88,110,3,139,242,153,141,119,64,71,99,148,136,2,155,198,90,165,160,40,77,181,62,154,90,205,95,2,44,222,122,162,232,179,208,185,162,92,125,158,90,10,192,226,91,203,202,215,204,50,241,65,176,72,167,146,53,173,162,145,164,8,218,64,56,114,177,70,148,6,176,181,108,117,148,246,51,1,139,145,165,121,44,22,89,138,104,159,197,32,95,50,70,180,11,239,92,208,128,140,85,119,3,203,67,129,137,54,82,69,231,3,248,207,20,36,87,75,17,65,160,162,85,223,18,0,144,82,174,135,96,114,231,133,125,238,48,169,74,103,155,98,21,82,73,7,225,100,162,200,190,36,225,76,116,20,155,87,108,220,65,152,20,14,45,5,25,133,43,185,34,146,202,139,76,6,125,58,121,54,70,37,103,244,31,2,147,23,103,187,87,52,172,38,229,185,120,188,31,144,163,17,153,230,151,171,19,190,173,208,49,20,254,119,191,220,24,222,77,99,59,218,212,110,50,244,80,144,80,181,226,196,205,138,34,61,212,145,84,160,57,29,39,33,173,40,170,160,160,153,236,131,64,66,9,108,11,160,32,84,42,160,4,182,82,100,86,89,160,152,137,160,53,93,101,117,16,9,212,88,161,47,4,193,73,129,133,181,1,18,66,13,194,217,92,157,139,65,165,248,7,236,65,192,219,219,237,191,247,167,139,90,74,230,28,157,112,132,237,130,197,246,65,164,134,61,20,50,72,84,50,210,89,221,130,188,175,50,178,18,154,117,21,44,177,80,42,146,16,27,229,92,149,19,17,186,91,251,196,229,124,207,182,35,194,95,104,92,109,55,221,101,229,46,30,15,12,232,212,46,159,61,20,248,252,191,155,147,187,100,237,175,1,31,29,139,211,16,142,206,147,17,182,178,17,49,27,84,191,171,94,57,236,103,131,13,7,225,211,162,172,73,5,136,253,150,112,241,42,160,19,1,62,212,90,163,172,114,170,46,220,63,124,94,140,195,106,243,51,106,104,131,74,198,206,251,25,163,124,17,159,187,235,176,31,214,124,130,238,113,124,238,145,199,168,3,4,179,151,40,133,18,17,1,244,70,65,65,73,227,76,75,144,21,23,55,132,155,75,193,105,143,117,182,22,144,125,9,119,107,130,3,120,187,105,202,201,101,61,13,249,97,51,174,198,179,199,115,236,176,55,50,30,18,143,2,40,155,193,84,13,133,151,165,177,66,59,167,51,90,46,54,71,102,146,123,71,112,164,219,182,110,124,139,182,86,202,118,143,30,7,215,186,79,240,45,197,164,200,224,44,34,58,131,228,68,21,69,84,18,253,194,66,97,90,3,191,125,187,225,155,244,197,147,55,85,152,130,183,45,19,148,69,176,9,103,58,108,100,210,181,25,235,126,195,183,18,21,206,128,88,52,151,128,135,0,237,30,33,111,69,100,124,53,149,91,140,105,246,13,174,189,163,93,119,58,113,4,87,36,109,220,118,111,209,188,183,173,221,114,206,242,251,41,255,105,218,46,150,253,110,220,158,240,208,109,166,251,223,254,237,50,112,223,45,254,190,26,118,99,183,154,148,3,98,58,240,110,191,30,97,167,67,69,175,185,76,44,184,152,96,119,40,236,179,253,245,116,185,186,255,63,24,189,221,223,47,159,108,93,193,41,69,83,216,221,168,233,152,176,76,250,61,121,66,73,153,74,158,26,149,86,30,132,86,81,185,32,12,228,133,246,19,28,155,131,212,176,216,165,251,144,179,226,88,180,15,242,32,217,134,102,139,227,52,81,236,4,51,40,189,233,76,76,10,215,130,169,48,106,50,14,92,255,20,178,253,68,66,250,74,182,127,38,217,118,247,203,182,215,216,240,51,101,219,59,56,252,149,110,31,12,221,154,164,88,234,92,68,1,92,160,126,52,14,163,67,133,208,75,224,59,82,85,135,122,203,207,83,28,12,212,176,23,78,69,156,170,234,18,46,85,126,50,56,179,199,238,193,202,86,239,159,110,151,253,116,164,183,236,15,193,243,250,59,95,126,69,215,154,13,41,102,33,3,131,38,43,118,107,57,64,62,87,201,94,197,140,31,27,191,220,99,191,55,23,191,2,114,242,103,88,206,29,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "753374fefdb24c4d9a027f8fc6ec273a",
							"BaseElements.AddReminderLegalEntity.Parameters.RecordDefValues.Value");
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

		public LeadManagementDistributionFinance(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementDistributionFinance";
			SchemaUId = new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_createReminder = () => { return (bool)((DistributionLeadPage.RemindToOwner)); };
			_responsibleId = () => { return (Guid)((DistributionLeadPage.LeadOwnerId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("753374fe-fdb2-4c4d-9a02-7f8fc6ec273a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementDistributionFinance, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementDistributionFinance, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		private Func<bool> _createReminder;
		public virtual bool CreateReminder {
			get {
				return (_createReminder ?? (_createReminder = () => false)).Invoke();
			}
			set {
				_createReminder = () => { return value; };
			}
		}

		private Func<Guid> _responsibleId;
		public virtual Guid ResponsibleId {
			get {
				return (_responsibleId ?? (_responsibleId = () => Guid.Empty)).Invoke();
			}
			set {
				_responsibleId = () => { return value; };
			}
		}

		public virtual bool ShowDistributionPage {
			get;
			set;
		}

		private ProcessLeadDistribution _leadDistribution;
		public ProcessLeadDistribution LeadDistribution {
			get {
				return _leadDistribution ?? ((_leadDistribution) = new ProcessLeadDistribution(UserConnection, this));
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
					SchemaElementUId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateHandoff;
		public ProcessTerminateEvent TerminateHandoff {
			get {
				return _terminateHandoff ?? (_terminateHandoff = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateHandoff",
					SchemaElementUId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayIsLeadSet.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateLeadIsNotSet;
		public ProcessTerminateEvent TerminateLeadIsNotSet {
			get {
				return _terminateLeadIsNotSet ?? (_terminateLeadIsNotSet = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateLeadIsNotSet",
					SchemaElementUId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SaveLeadHandoffFlowElement _saveLeadHandoff;
		public SaveLeadHandoffFlowElement SaveLeadHandoff {
			get {
				return _saveLeadHandoff ?? (_saveLeadHandoff = new SaveLeadHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private SaveLeadNoInterestFlowElement _saveLeadNoInterest;
		public SaveLeadNoInterestFlowElement SaveLeadNoInterest {
			get {
				return _saveLeadNoInterest ?? (_saveLeadNoInterest = new SaveLeadNoInterestFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateContinueDistribution;
		public ProcessTerminateEvent TerminateContinueDistribution {
			get {
				return _terminateContinueDistribution ?? (_terminateContinueDistribution = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateContinueDistribution",
					SchemaElementUId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AddReminderFlowElement _addReminder;
		public AddReminderFlowElement AddReminder {
			get {
				return _addReminder ?? (_addReminder = new AddReminderFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadTypeFlowElement _readLeadType;
		public ReadLeadTypeFlowElement ReadLeadType {
			get {
				return _readLeadType ?? (_readLeadType = new ReadLeadTypeFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadContactFlowElement _readLeadContact;
		public ReadLeadContactFlowElement ReadLeadContact {
			get {
				return _readLeadContact ?? (_readLeadContact = new ReadLeadContactFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private DistributionLeadPageFlowElement _distributionLeadPage;
		public DistributionLeadPageFlowElement DistributionLeadPage {
			get {
				return _distributionLeadPage ?? (_distributionLeadPage = new DistributionLeadPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private SaveLeadByDefaultFlowElement _saveLeadByDefault;
		public SaveLeadByDefaultFlowElement SaveLeadByDefault {
			get {
				return _saveLeadByDefault ?? (_saveLeadByDefault = new SaveLeadByDefaultFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadLegalEntityFlowElement _readLeadLegalEntity;
		public ReadLeadLegalEntityFlowElement ReadLeadLegalEntity {
			get {
				return _readLeadLegalEntity ?? (_readLeadLegalEntity = new ReadLeadLegalEntityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadTypeLegalEntityFlowElement _readLeadTypeLegalEntity;
		public ReadLeadTypeLegalEntityFlowElement ReadLeadTypeLegalEntity {
			get {
				return _readLeadTypeLegalEntity ?? (_readLeadTypeLegalEntity = new ReadLeadTypeLegalEntityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddReminderLegalEntityFlowElement _addReminderLegalEntity;
		public AddReminderLegalEntityFlowElement AddReminderLegalEntity {
			get {
				return _addReminderLegalEntity ?? (_addReminderLegalEntity = new AddReminderLegalEntityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("5805d2d7-5516-4f97-9107-0c6b5c4bbc5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowCreateReminder;
		public ProcessConditionalFlow ConditionalFlowCreateReminder {
			get {
				return _conditionalFlowCreateReminder ?? (_conditionalFlowCreateReminder = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowCreateReminder",
					SchemaElementUId = new Guid("97e8e894-d220-43dc-9cfa-0e37f8166e2a"),
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
					SchemaElementUId = new Guid("f5da7633-709e-40ac-ab2f-51d79b4f1e75"),
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
					SchemaElementUId = new Guid("15c1b993-b41b-4b3d-be24-96f8a835c457"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlowContactIsNotEmpty;
		public ProcessConditionalFlow ConditionalSequenceFlowContactIsNotEmpty {
			get {
				return _conditionalSequenceFlowContactIsNotEmpty ?? (_conditionalSequenceFlowContactIsNotEmpty = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlowContactIsNotEmpty",
					SchemaElementUId = new Guid("a32d93f4-b840-4d4b-b744-d6780a387368"),
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
			FlowElements[TerminateHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateHandoff };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[TerminateLeadIsNotSet.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateLeadIsNotSet };
			FlowElements[SaveLeadHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadHandoff };
			FlowElements[SaveLeadNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadNoInterest };
			FlowElements[TerminateNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNoInterest };
			FlowElements[TerminateContinueDistribution.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateContinueDistribution };
			FlowElements[AddReminder.SchemaElementUId] = new Collection<ProcessFlowElement> { AddReminder };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ReadLeadType.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadType };
			FlowElements[ReadLeadContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadContact };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[DistributionLeadPage.SchemaElementUId] = new Collection<ProcessFlowElement> { DistributionLeadPage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[SaveLeadByDefault.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadByDefault };
			FlowElements[ReadLeadLegalEntity.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadLegalEntity };
			FlowElements[ReadLeadTypeLegalEntity.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadTypeLegalEntity };
			FlowElements[AddReminderLegalEntity.SchemaElementUId] = new Collection<ProcessFlowElement> { AddReminderLegalEntity };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "TerminateHandoff":
						CompleteProcess();
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateLeadIsNotSet", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("DistributionLeadPage", e.Context.SenderName));
						break;
					case "TerminateLeadIsNotSet":
						CompleteProcess();
						break;
					case "SaveLeadHandoff":
						if (ConditionalFlowCreateReminderExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "SaveLeadNoInterest":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNoInterest", e.Context.SenderName));
						break;
					case "TerminateNoInterest":
						CompleteProcess();
						break;
					case "TerminateContinueDistribution":
						CompleteProcess();
						break;
					case "AddReminder":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ReadLeadData":
						if (ConditionalSequenceFlowContactIsNotEmptyExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadContact", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadLegalEntity", e.Context.SenderName));
						break;
					case "ReadLeadType":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddReminder", e.Context.SenderName));
						break;
					case "ReadLeadContact":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadType", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateHandoff", e.Context.SenderName));
						break;
					case "DistributionLeadPage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadHandoff", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadNoInterest", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadByDefault", e.Context.SenderName));
						break;
					case "SaveLeadByDefault":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateContinueDistribution", e.Context.SenderName));
						break;
					case "ReadLeadLegalEntity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadTypeLegalEntity", e.Context.SenderName));
						break;
					case "ReadLeadTypeLegalEntity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddReminderLegalEntity", e.Context.SenderName));
						break;
					case "AddReminderLegalEntity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsLeadSet", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowCreateReminderExpressionExecute() {
			bool result = Convert.ToBoolean((CreateReminder));
			Log.InfoFormat(ConditionalExpressionLogMessage, "SaveLeadHandoff", "ConditionalFlowCreateReminder", "(CreateReminder)", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((DistributionLeadPage.Result) == "TransferToSale");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow2", "(DistributionLeadPage.Result) == \"TransferToSale\"", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((DistributionLeadPage.Result) == "NotInteresting");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow3", "(DistributionLeadPage.Result) == \"NotInteresting\"", result);
			return result;
		}

		private bool ConditionalSequenceFlowContactIsNotEmptyExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadLeadData", "ConditionalSequenceFlowContactIsNotEmpty", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"QualifiedContact\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>(\"QualifiedContactId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("DistributionLeadPage.LeadId")) {
				writer.WriteValue("DistributionLeadPage.LeadId", DistributionLeadPage.LeadId, Guid.Empty);
			}
			if (!HasMapping("DistributionLeadPage.Result")) {
				writer.WriteValue("DistributionLeadPage.Result", DistributionLeadPage.Result, null);
			}
			if (!HasMapping("DistributionLeadPage.RemindToOwner")) {
				writer.WriteValue("DistributionLeadPage.RemindToOwner", DistributionLeadPage.RemindToOwner, false);
			}
			if (!HasMapping("DistributionLeadPage.LeadOwnerId")) {
				writer.WriteValue("DistributionLeadPage.LeadOwnerId", DistributionLeadPage.LeadOwnerId, Guid.Empty);
			}
			if (!HasMapping("DistributionLeadPage.OpportunityDepartment")) {
				writer.WriteValue("DistributionLeadPage.OpportunityDepartment", DistributionLeadPage.OpportunityDepartment, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("ShowDistributionPage")) {
				writer.WriteValue("ShowDistributionPage", ShowDistributionPage, false);
			}
			if (!HasMapping("CreateReminder")) {
				writer.WriteValue("CreateReminder", CreateReminder, false);
			}
			if (!HasMapping("ResponsibleId")) {
				writer.WriteValue("ResponsibleId", ResponsibleId, Guid.Empty);
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
			MetaPathParameterValues.Add("30cf6943-a881-4c30-a088-ff65572e4241", () => LeadId);
			MetaPathParameterValues.Add("9cd3f863-0eda-4338-895e-97f82adfe406", () => CreateReminder);
			MetaPathParameterValues.Add("77bfc541-1a1a-4b5e-bd77-3e429c4b637f", () => ResponsibleId);
			MetaPathParameterValues.Add("51139bfa-4db4-45f7-aa2f-590d604f8469", () => ShowDistributionPage);
			MetaPathParameterValues.Add("188fdd38-de95-4c10-8ab3-34128e7e82c9", () => SaveLeadHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("9cad839f-9e67-4603-a369-f4c25fce8216", () => SaveLeadHandoff.IsMatchConditions);
			MetaPathParameterValues.Add("51b908e1-277f-4fd9-954b-c200b506502f", () => SaveLeadHandoff.DataSourceFilters);
			MetaPathParameterValues.Add("e91b04af-7a52-4f54-a02b-32ac50a9f8ad", () => SaveLeadHandoff.RecordColumnValues);
			MetaPathParameterValues.Add("a147d2f0-eb4f-4a91-bda3-6b4d5423014b", () => SaveLeadNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("d71bf98b-10c9-4b4e-9da3-927f4c707df2", () => SaveLeadNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("8b04704d-b57f-4aed-8143-0ba2dc774953", () => SaveLeadNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("63cb5219-81b3-4e2c-8f12-bb56e164296d", () => SaveLeadNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("55dd5f60-cee9-44b6-8f68-b543a4174bf2", () => AddReminder.EntitySchemaId);
			MetaPathParameterValues.Add("7a3aa063-9af4-482e-adbf-9312dad8b0bf", () => AddReminder.DataSourceFilters);
			MetaPathParameterValues.Add("2e6f433c-09c2-46dc-89d2-80e6a8f6ebda", () => AddReminder.RecordAddMode);
			MetaPathParameterValues.Add("ddff7e72-873c-4e34-a274-b1fe98dc4dc5", () => AddReminder.FilterEntitySchemaId);
			MetaPathParameterValues.Add("95dfe792-7d3e-4db6-8add-2effff3ca7f4", () => AddReminder.RecordDefValues);
			MetaPathParameterValues.Add("2af26cad-fdd2-4138-9712-bb3c00009344", () => AddReminder.RecordId);
			MetaPathParameterValues.Add("88b815f6-9ed2-474a-a40e-f96b169054b4", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("7c774b4b-6e9a-4ef1-bd4d-4af18e1f5a68", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("4a5fff69-b63a-49e0-a7c9-da42ff12623b", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("1b730802-2250-4ca2-84c5-b50b5d4a07fb", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("be3ad5ec-1ac1-4d88-8421-74079d80259b", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("19076150-3efa-4513-be4e-b624b7233322", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("9adb2ee5-70ec-4c6c-b1ab-4cb1ddf4c59b", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("81e8d9be-76bf-41e2-a013-9bfb7a60bbf7", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("0a4b4eb8-5619-4c19-a817-49e7435ddac0", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("18ee65b6-9004-44b1-b810-660c4b69eb54", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("2ba36ea2-087d-4183-8f2e-029d86d94b6b", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("39c22bae-af9c-474a-8c12-e087a1cc5bcc", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("befd9ddf-c017-4e87-bf55-98e25f140075", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("2fd8069c-26a9-41c0-9022-20c047525340", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("b92dc5ab-c714-451b-b938-04990fc76593", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("904a1de6-b8cd-43d7-a193-0a8234806d6f", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("addb84e6-59ea-4d30-acaf-3f26b8c94365", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("1fbff5df-21b7-44cd-9ccc-3c395a630d2b", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("0083ce82-7259-49e6-bf11-a21e135d34ce", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("ca3d3049-0f26-41a3-bca2-dd669a7d3396", () => ReadLeadType.DataSourceFilters);
			MetaPathParameterValues.Add("9bb7fdf0-23d9-4a53-9bfc-b65d5b2b58ef", () => ReadLeadType.ResultType);
			MetaPathParameterValues.Add("1fc1bf95-66f6-437e-ae96-ab0226deef9f", () => ReadLeadType.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b6eaed28-95a3-4e02-bc92-584da91d9666", () => ReadLeadType.NumberOfRecords);
			MetaPathParameterValues.Add("8af81470-64e6-4c25-bc4e-996386dd37c1", () => ReadLeadType.FunctionType);
			MetaPathParameterValues.Add("876c91d3-f5fd-430b-99a7-6da066af2251", () => ReadLeadType.AggregationColumnName);
			MetaPathParameterValues.Add("a511d00e-3b57-438c-ad43-a0b965ac41ff", () => ReadLeadType.OrderInfo);
			MetaPathParameterValues.Add("d5067126-b12c-401d-83cc-53d80a232257", () => ReadLeadType.ResultEntity);
			MetaPathParameterValues.Add("c25ddf34-5ec7-43ef-9f1b-1f022d5afa06", () => ReadLeadType.ResultCount);
			MetaPathParameterValues.Add("39e87f5c-2965-45a4-8ce7-4446e1173001", () => ReadLeadType.ResultIntegerFunction);
			MetaPathParameterValues.Add("3aec9151-bb18-4f05-9f98-6ef24b8eb8fa", () => ReadLeadType.ResultFloatFunction);
			MetaPathParameterValues.Add("8319a4e6-2ecb-470d-b2fd-9af8514e9ab2", () => ReadLeadType.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0e55a545-db7b-429c-8850-c3c910df6b27", () => ReadLeadType.ResultRowsCount);
			MetaPathParameterValues.Add("d246ad4e-36de-4230-bc79-a36f43b1befe", () => ReadLeadType.CanReadUncommitedData);
			MetaPathParameterValues.Add("7ad11547-1b9b-4507-b7ff-0d224aa61262", () => ReadLeadType.ResultEntityCollection);
			MetaPathParameterValues.Add("5bfef119-7795-4c1c-8d01-0d38138f2a41", () => ReadLeadType.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3e1d582a-dce9-475f-9eed-bc65b2d11830", () => ReadLeadType.IgnoreDisplayValues);
			MetaPathParameterValues.Add("f2209798-7b73-4a75-a59d-28e69da2bc6b", () => ReadLeadType.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c0961cde-8588-4fb0-975f-ddf92b6ab59c", () => ReadLeadType.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("fe828bdd-0b5b-4b21-8d0d-7fe8bbb6c978", () => ReadLeadContact.DataSourceFilters);
			MetaPathParameterValues.Add("b4af7ceb-60b9-467c-a8b3-81953d377341", () => ReadLeadContact.ResultType);
			MetaPathParameterValues.Add("311fcede-bca4-4fec-9a42-0f943fe03159", () => ReadLeadContact.ReadSomeTopRecords);
			MetaPathParameterValues.Add("4f32f247-07f2-471b-ba49-b42cae200cf0", () => ReadLeadContact.NumberOfRecords);
			MetaPathParameterValues.Add("d72c0941-da6e-42f6-b7a5-0b3ffe8b2c2e", () => ReadLeadContact.FunctionType);
			MetaPathParameterValues.Add("3356dca2-6b01-46e0-9fe2-d0de44ff97b0", () => ReadLeadContact.AggregationColumnName);
			MetaPathParameterValues.Add("d550d767-aeda-4cf2-9b2a-90c7c38be81b", () => ReadLeadContact.OrderInfo);
			MetaPathParameterValues.Add("fff72291-b74e-4830-8333-56ad140e6e7c", () => ReadLeadContact.ResultEntity);
			MetaPathParameterValues.Add("05f02083-70af-4052-8ee7-2b228747244c", () => ReadLeadContact.ResultCount);
			MetaPathParameterValues.Add("123bb774-23e8-4cbe-a707-c0bf2149c012", () => ReadLeadContact.ResultIntegerFunction);
			MetaPathParameterValues.Add("a43adf8a-3d3f-4d55-bbb1-030b98ca7464", () => ReadLeadContact.ResultFloatFunction);
			MetaPathParameterValues.Add("2a298fa9-f151-46ad-b486-c3c3bcb89af4", () => ReadLeadContact.ResultDateTimeFunction);
			MetaPathParameterValues.Add("51b3ba73-2cd0-43a5-b1bb-d655502ea451", () => ReadLeadContact.ResultRowsCount);
			MetaPathParameterValues.Add("bd94e2da-67c7-4c33-985e-1f6fdecc4562", () => ReadLeadContact.CanReadUncommitedData);
			MetaPathParameterValues.Add("53665a2a-42d9-47f3-8bf4-e4ebbd2e10f3", () => ReadLeadContact.ResultEntityCollection);
			MetaPathParameterValues.Add("f382eb7c-1c7a-4c11-93b3-5b6271585801", () => ReadLeadContact.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("377fdd7e-2835-4e98-a892-93bd77cfe77f", () => ReadLeadContact.IgnoreDisplayValues);
			MetaPathParameterValues.Add("8b494ce5-09e1-4403-8db2-53705a798411", () => ReadLeadContact.ResultCompositeObjectList);
			MetaPathParameterValues.Add("9d17e551-609b-4f07-bd28-8adbb5bf10f4", () => ReadLeadContact.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("bbe769c2-34d8-4a8b-a580-a9e4311e6053", () => DistributionLeadPage.Title);
			MetaPathParameterValues.Add("5160bb63-99ee-4be0-ad4e-f804a2c25915", () => DistributionLeadPage.Recommendation);
			MetaPathParameterValues.Add("2021bd48-f45e-4cd3-b993-7b97a0c3308d", () => DistributionLeadPage.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("1905b493-d577-4148-a465-5b25ff5f0ab4", () => DistributionLeadPage.EntityId);
			MetaPathParameterValues.Add("702a610c-eae3-442a-b9e5-1eae1657abca", () => DistributionLeadPage.EntryPointId);
			MetaPathParameterValues.Add("ab6017ca-8f69-4ec1-95d6-57eb04cec232", () => DistributionLeadPage.EntitySchemaUId);
			MetaPathParameterValues.Add("1babcc34-fbcc-4e3e-84fe-432c05fdbbe5", () => DistributionLeadPage.UseCardProcessModule);
			MetaPathParameterValues.Add("583c0a7d-9ed9-49b6-919b-fb6caaff12fd", () => DistributionLeadPage.OwnerId);
			MetaPathParameterValues.Add("3aeda084-6af5-44ea-8738-d38edc340131", () => DistributionLeadPage.ShowExecutionPage);
			MetaPathParameterValues.Add("63033799-a11b-4b1e-9c2b-6e17977e2c43", () => DistributionLeadPage.InformationOnStep);
			MetaPathParameterValues.Add("809907b4-6caf-4cda-8cd8-58f9c1196633", () => DistributionLeadPage.IsRunning);
			MetaPathParameterValues.Add("3e3ba938-a24a-464b-813e-886948488e01", () => DistributionLeadPage.Template);
			MetaPathParameterValues.Add("e737696e-ab9a-464f-a9bb-64aab8d4b7b0", () => DistributionLeadPage.Module);
			MetaPathParameterValues.Add("333777f3-163c-4bd8-bb72-c67051a8296f", () => DistributionLeadPage.PressedButtonCode);
			MetaPathParameterValues.Add("1c7fb6cf-9d1e-4f58-96ef-43608663db8a", () => DistributionLeadPage.Url);
			MetaPathParameterValues.Add("345b747f-6492-4686-a503-0062acd716e0", () => DistributionLeadPage.LeadId);
			MetaPathParameterValues.Add("a9e78508-ae1b-4141-abe0-24ed11eadb13", () => DistributionLeadPage.Result);
			MetaPathParameterValues.Add("cd5eefc4-6c19-4719-be10-6babbc9acc6e", () => DistributionLeadPage.RemindToOwner);
			MetaPathParameterValues.Add("0d01d7bb-ccf9-4184-a64f-953b68988ea4", () => DistributionLeadPage.LeadOwnerId);
			MetaPathParameterValues.Add("8227a76e-e673-40a1-a3f3-2102ef5efe7a", () => DistributionLeadPage.OpportunityDepartment);
			MetaPathParameterValues.Add("560bc47f-ebc5-4687-aa0c-08705e061a9a", () => SaveLeadByDefault.EntitySchemaUId);
			MetaPathParameterValues.Add("c4e20e54-2a71-4e75-a167-24858aec6fcb", () => SaveLeadByDefault.IsMatchConditions);
			MetaPathParameterValues.Add("ba1c792f-b05d-43b6-b1d4-1f6f092ae9d7", () => SaveLeadByDefault.DataSourceFilters);
			MetaPathParameterValues.Add("f3fd0d58-28e8-457f-8737-49c12cc4cc1d", () => SaveLeadByDefault.RecordColumnValues);
			MetaPathParameterValues.Add("6d817f08-09b2-4fa8-a782-fe1db9ed6e86", () => ReadLeadLegalEntity.DataSourceFilters);
			MetaPathParameterValues.Add("d06a36c6-848d-484d-9f4f-0de81448d9c3", () => ReadLeadLegalEntity.ResultType);
			MetaPathParameterValues.Add("f3625c2a-f59b-4f64-adf6-90e79fe7aeed", () => ReadLeadLegalEntity.ReadSomeTopRecords);
			MetaPathParameterValues.Add("e655a18d-ce53-4e22-a507-a753a23881c5", () => ReadLeadLegalEntity.NumberOfRecords);
			MetaPathParameterValues.Add("dd70767a-663a-4bba-9147-4f2e5aa7c244", () => ReadLeadLegalEntity.FunctionType);
			MetaPathParameterValues.Add("f39c6753-02b4-4a5e-a6ba-b99697b2ac57", () => ReadLeadLegalEntity.AggregationColumnName);
			MetaPathParameterValues.Add("e6605cdf-474a-47e1-a009-e4527b6c1cff", () => ReadLeadLegalEntity.OrderInfo);
			MetaPathParameterValues.Add("06c6a63d-3c18-4ea8-b749-38e3092df345", () => ReadLeadLegalEntity.ResultEntity);
			MetaPathParameterValues.Add("71fb3b5e-91ec-4fdb-8587-e8a70e8e15ed", () => ReadLeadLegalEntity.ResultCount);
			MetaPathParameterValues.Add("68101654-54da-4ebe-be44-76f2736cf13f", () => ReadLeadLegalEntity.ResultIntegerFunction);
			MetaPathParameterValues.Add("e72ea618-cc5b-414c-b8fe-befedccd80ba", () => ReadLeadLegalEntity.ResultFloatFunction);
			MetaPathParameterValues.Add("48964511-7533-43c6-91dc-e775680cb3d0", () => ReadLeadLegalEntity.ResultDateTimeFunction);
			MetaPathParameterValues.Add("c4510564-d6ba-477d-a3c7-57f062ecc615", () => ReadLeadLegalEntity.ResultRowsCount);
			MetaPathParameterValues.Add("f41ffeec-9d24-433c-9ffc-47368b09b92e", () => ReadLeadLegalEntity.CanReadUncommitedData);
			MetaPathParameterValues.Add("758a9e96-25aa-48ce-bdd6-c3efae5de38d", () => ReadLeadLegalEntity.ResultEntityCollection);
			MetaPathParameterValues.Add("ddc71462-5e7d-4dd9-8436-cf519e07f134", () => ReadLeadLegalEntity.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5d5eba4a-d9f3-4d32-80fb-2650e75a0ddf", () => ReadLeadLegalEntity.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d555ee2e-3bd7-4936-9fe7-2afdc8f4ad93", () => ReadLeadLegalEntity.ResultCompositeObjectList);
			MetaPathParameterValues.Add("9716805a-6341-433b-b8a8-40ebfd6e5ae3", () => ReadLeadLegalEntity.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9319d39a-ef73-4a83-87bf-b5a8d1347f99", () => ReadLeadTypeLegalEntity.DataSourceFilters);
			MetaPathParameterValues.Add("3b689408-ddf0-4d54-a5a2-1265b86d51d1", () => ReadLeadTypeLegalEntity.ResultType);
			MetaPathParameterValues.Add("078cb5da-f078-40c8-b97f-087688f40632", () => ReadLeadTypeLegalEntity.ReadSomeTopRecords);
			MetaPathParameterValues.Add("38001730-4fc7-4b8a-8fed-843d0d603740", () => ReadLeadTypeLegalEntity.NumberOfRecords);
			MetaPathParameterValues.Add("332a5444-b7b0-4e2e-a40f-ba4d780811e1", () => ReadLeadTypeLegalEntity.FunctionType);
			MetaPathParameterValues.Add("3048d53f-f57f-4784-8cd4-a60b53c26e51", () => ReadLeadTypeLegalEntity.AggregationColumnName);
			MetaPathParameterValues.Add("5983cfa8-0380-48c3-998e-f9add536478c", () => ReadLeadTypeLegalEntity.OrderInfo);
			MetaPathParameterValues.Add("35975265-1ff7-4807-ad9f-43f9f2ab95b2", () => ReadLeadTypeLegalEntity.ResultEntity);
			MetaPathParameterValues.Add("9040a2ec-ef7f-4ffd-ba53-7c4bedae2c07", () => ReadLeadTypeLegalEntity.ResultCount);
			MetaPathParameterValues.Add("a0ba2644-fac5-480b-8483-55c9e6559f4d", () => ReadLeadTypeLegalEntity.ResultIntegerFunction);
			MetaPathParameterValues.Add("458c0ef7-86bb-428c-ad09-d8644b667072", () => ReadLeadTypeLegalEntity.ResultFloatFunction);
			MetaPathParameterValues.Add("7183aa2d-b56a-4ce7-a2ad-67e36307aad7", () => ReadLeadTypeLegalEntity.ResultDateTimeFunction);
			MetaPathParameterValues.Add("042b8f50-393b-498d-b322-b2d6af5bc6d3", () => ReadLeadTypeLegalEntity.ResultRowsCount);
			MetaPathParameterValues.Add("2b7b6c56-864c-45db-9d37-e83f3fbd2407", () => ReadLeadTypeLegalEntity.CanReadUncommitedData);
			MetaPathParameterValues.Add("9d4b3c64-63e8-403e-92f3-005f5cf7fca5", () => ReadLeadTypeLegalEntity.ResultEntityCollection);
			MetaPathParameterValues.Add("790f0486-cb3f-420d-87a9-1d2c3c40a521", () => ReadLeadTypeLegalEntity.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("37d7b5ca-dcfb-4db2-9c18-d3da11ba1a96", () => ReadLeadTypeLegalEntity.IgnoreDisplayValues);
			MetaPathParameterValues.Add("fe5cb073-3546-43e0-9e8e-ae8b985b0732", () => ReadLeadTypeLegalEntity.ResultCompositeObjectList);
			MetaPathParameterValues.Add("9bcc5a5d-7972-45ca-b70e-bf911a6ba0de", () => ReadLeadTypeLegalEntity.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("8aa56ae8-b7c3-4724-ac53-c6b7749a1e9b", () => AddReminderLegalEntity.EntitySchemaId);
			MetaPathParameterValues.Add("3d7d5816-074a-45f2-b76c-7099ac1cb23c", () => AddReminderLegalEntity.DataSourceFilters);
			MetaPathParameterValues.Add("55629ab5-01ee-43ba-a096-138f35bf3a2a", () => AddReminderLegalEntity.RecordAddMode);
			MetaPathParameterValues.Add("6735bda3-4f6f-4db6-b574-5d4d635b53b1", () => AddReminderLegalEntity.FilterEntitySchemaId);
			MetaPathParameterValues.Add("590f52ae-d6f6-43af-91a4-ba3d90a836bf", () => AddReminderLegalEntity.RecordDefValues);
			MetaPathParameterValues.Add("2fbea2ce-a3a1-4680-b731-b7708322ec68", () => AddReminderLegalEntity.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "DistributionLeadPage.LeadId":
					DistributionLeadPage.LeadId = reader.GetValue<System.Guid>();
				break;
				case "DistributionLeadPage.Result":
					DistributionLeadPage.Result = reader.GetValue<System.String>();
				break;
				case "DistributionLeadPage.RemindToOwner":
					DistributionLeadPage.RemindToOwner = reader.GetValue<System.Boolean>();
				break;
				case "DistributionLeadPage.LeadOwnerId":
					DistributionLeadPage.LeadOwnerId = reader.GetValue<System.Guid>();
				break;
				case "DistributionLeadPage.OpportunityDepartment":
					DistributionLeadPage.OpportunityDepartment = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "ShowDistributionPage":
					if (!hasValueToRead) break;
					ShowDistributionPage = reader.GetValue<System.Boolean>();
				break;
				case "CreateReminder":
					if (!hasValueToRead) break;
					CreateReminder = reader.GetValue<System.Boolean>();
				break;
				case "ResponsibleId":
					if (!hasValueToRead) break;
					ResponsibleId = reader.GetValue<System.Guid>();
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
			var cloneItem = (LeadManagementDistributionFinance)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

