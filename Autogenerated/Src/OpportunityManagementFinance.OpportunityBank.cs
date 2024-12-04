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

	#region Class: OpportunityManagementFinanceSchema

	/// <exclude/>
	public class OpportunityManagementFinanceSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public OpportunityManagementFinanceSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public OpportunityManagementFinanceSchema(OpportunityManagementFinanceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityManagementFinance";
			UId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc");
			CreatedInPackageId = new Guid("60a1c5d5-b601-479f-92f1-be91ff7f23f7");
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
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc");
			Version = 0;
			PackageUId = new Guid("60bd7cb9-5552-477e-bfa8-05d8b60538bb");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCurrentOpportunityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("af8eea9e-0e11-426e-a870-2cff33d00f84"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePresentationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0eae6fcc-65b6-433e-b4dc-e42323c488c1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"Presentation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b8d6c762-b63e-49b7-b651-c8d29f9c8d74"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("342aec56-8359-4c5b-826b-9e8489fd6a4b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsStageChangedByUserParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9786c0e4-cc5f-4c9f-b46d-090a297e2b74"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"IsStageChangedByUser",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateClientOpportunityCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02b1469d-72ad-4909-a7cf-6b41b79d41a7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ClientOpportunityCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpportunityTitleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("738ceb61-832b-4b27-a973-9347e26e827e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OpportunityTitle",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b6534525-3848-4420-8930-e7bcc98a1756"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateClientNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b2b54e53-5309-4650-ac67-b8a4705d22b4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ClientName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOpportunityParameter());
			Parameters.Add(CreatePresentationParameter());
			Parameters.Add(CreateMainContactParameter());
			Parameters.Add(CreateAccountParameter());
			Parameters.Add(CreateIsStageChangedByUserParameter());
			Parameters.Add(CreateClientOpportunityCountParameter());
			Parameters.Add(CreateOpportunityTitleParameter());
			Parameters.Add(CreateContactParameter());
			Parameters.Add(CreateClientNameParameter());
		}

		protected virtual void InitializeProspectingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("81432db0-f5f5-40d1-8f22-4d8c3bb4cf48"),
				ContainerUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb29a402-5da5-4f9b-844c-e79f4e1f115a"),
				ContainerUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fdc628cc-1da4-4b5d-b397-d6c93e1e9517"),
				ContainerUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeNeedsAnalysisParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("5b443132-caa7-4f82-80dd-cc84a5380caa"),
				ContainerUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6a80392b-c787-4788-a532-fca2370b3840"),
				ContainerUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5e47a6d3-f9bb-404f-87e2-aed31c62acc3"),
				ContainerUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementValuePpropositionParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("4274528b-203f-43bc-87d3-abf86b9a792e"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b20705a6-a8bc-460d-8389-aaaa9b58be16"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var presentationParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("f7d5c580-2ff1-4209-a013-2bef80d7f3a9"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"Presentation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			presentationParameter.SourceValue = new ProcessSchemaParameterValue(presentationParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{0eae6fcc-65b6-433e-b4dc-e42323c488c1}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(presentationParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("2a0e89a7-92f6-4cf6-a9f2-a0140105ba95"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeIdDecisionMakersParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("76602486-f8b8-47cb-8b9f-d00841250f90"),
				ContainerUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e6028b5e-002d-4bc7-bc34-8affd537f00c"),
				ContainerUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5dc6ce94-0fc5-4ffa-8e00-83c67ce5da35"),
				ContainerUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementPerceptionAnalysisParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("c647b290-fae9-4f2f-b291-b94262f923dc"),
				ContainerUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d34fbe8-274b-4c6e-88d8-7307f538cfee"),
				ContainerUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("36230419-640f-4176-ad85-8beca7d791ca"),
				ContainerUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementProposalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("0a768934-39e6-4d8e-9fd4-4859b59f0779"),
				ContainerUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2902276d-abfd-4fd2-b6f9-b5bda02f0222"),
				ContainerUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("dc02a11c-a24c-4451-897b-9dce3a6a7178"),
				ContainerUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementNegotiationsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("f58812eb-a5a3-43ef-84a7-454b69c3aaed"),
				ContainerUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("33eb9e90-615e-412b-86bf-8d9f6c8831a8"),
				ContainerUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("47d1669f-a6cc-48ac-85b8-94795d69938e"),
				ContainerUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementContractationParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("a2600d6c-144b-4c75-acb3-f04cb1577884"),
				ContainerUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("16815d2d-6357-4be4-9265-46e9a99e093b"),
				ContainerUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("b812d4a7-16f1-4a13-b2e9-f0b2c48a8532"),
				ContainerUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementEndStageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("1494d351-8b28-4d15-a088-912b8872f732"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var nextOpportunityStageNumberParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0fa7431c-1004-411e-ae2e-b485fc040737"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextOpportunityStageNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			nextOpportunityStageNumberParameter.SourceValue = new ProcessSchemaParameterValue(nextOpportunityStageNumberParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(nextOpportunityStageNumberParameter);
			var currentStageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dcb46392-5cd0-43ba-9004-211ef9690ca5"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"CurrentStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentStageParameter.SourceValue = new ProcessSchemaParameterValue(currentStageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(currentStageParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9c2d0712-831e-499c-a94b-562db3eaed86"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
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
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var isStageChangedByUserParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f2941be-b24c-4797-8b31-addbd6057927"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"IsStageChangedByUser",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isStageChangedByUserParameter.SourceValue = new ProcessSchemaParameterValue(isStageChangedByUserParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9786c0e4-cc5f-4c9f-b46d-090a297e2b74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(isStageChangedByUserParameter);
			var dontShowPageEndOfStageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ef2201a2-720c-453d-8a5b-62d5077c6041"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"DontShowPageEndOfStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			dontShowPageEndOfStageParameter.SourceValue = new ProcessSchemaParameterValue(dontShowPageEndOfStageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(dontShowPageEndOfStageParameter);
			var nextStageParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("a8f664f6-40f1-4b7e-9602-25265d8962b3"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			nextStageParameter.SourceValue = new ProcessSchemaParameterValue(nextStageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(nextStageParameter);
		}

		protected virtual void InitializeReadOppDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("378a7c4d-c2ae-4dc0-8450-7d00de21889a"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,20,252,43,69,135,158,164,98,75,254,146,115,92,182,101,47,105,160,105,41,36,75,120,146,158,178,2,127,197,150,104,22,179,255,189,242,58,155,66,14,165,208,83,64,7,233,61,205,188,153,65,154,31,220,244,217,53,30,199,218,66,51,33,13,59,83,147,156,131,72,4,71,150,164,34,99,153,130,130,201,210,38,172,72,173,52,40,19,45,42,36,180,131,22,107,178,162,183,198,121,66,157,199,118,170,239,230,63,164,126,12,72,31,236,249,240,77,31,176,133,239,203,0,192,172,176,170,42,153,78,184,102,25,96,197,192,136,148,129,228,66,27,35,101,166,45,89,181,84,152,139,66,101,130,161,82,57,203,100,197,153,42,160,100,138,151,42,23,74,129,176,57,161,13,90,191,125,30,70,156,38,215,119,245,140,175,251,219,227,16,85,174,179,55,125,19,218,142,208,22,61,220,128,63,44,66,18,204,114,13,76,103,50,178,91,44,25,8,105,152,0,85,242,178,194,180,72,75,66,53,12,126,161,37,59,67,168,1,15,63,160,9,120,102,158,93,212,200,69,146,86,121,17,177,169,136,118,4,79,88,85,68,119,214,20,86,162,40,164,84,230,146,215,151,224,226,222,77,215,161,197,209,233,151,216,49,230,215,143,245,172,251,206,143,125,179,80,95,159,175,223,226,179,95,195,125,105,253,92,13,249,88,95,64,228,68,195,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,8,29,221,227,225,175,105,109,194,228,251,246,29,89,165,209,102,228,136,143,236,44,119,121,131,198,77,67,3,199,243,185,38,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,109,144,55,4,53,185,39,96,43,68,144,241,19,96,154,178,140,23,200,160,42,19,198,181,181,66,152,36,177,85,118,79,162,168,255,31,117,183,155,190,254,234,46,63,100,245,180,255,20,171,111,10,55,23,100,61,255,139,186,211,126,209,183,63,197,245,27,208,129,205,245,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09ca5d94-4475-494b-bb1d-1711734825d0"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("809504a0-92ba-4c37-9223-2bd86178ceeb"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("47e4b981-ae34-43d6-80d1-541eb76f8886"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("093cfd0d-3919-4594-bdbd-243b89c2421c"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99a55b65-320e-4a00-a443-906ccbd17195"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ea0a8aa9-15cc-4e7b-b857-0fde66046c9d"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("61d6f451-48d9-4c96-917b-f6c5ce85df83"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("10ddcd85-ccf7-42e5-8390-78074cc70ded"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c1248569-3f8c-43f3-9cb3-48975e8f84ef"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3feedf55-86a5-4ac5-bb7d-a85d1a84eb9d"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("734b2f72-a22c-41d7-900f-06d5bb7faf75"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d60364bd-0961-431f-8a33-c5f616c3de09"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5fc444a5-9b7a-422c-8693-86213fa317e7"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e4513fe5-860a-4300-889d-38b3328e8894"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("adee94c3-29c5-4b7a-960c-20c6b71d3afb"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("454dc5b0-a0d3-4a3d-b852-62380501a11c"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d3cf0def-09ec-4121-be55-a5dbeabb5df1"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("68831c61-87cd-4367-9e6c-9a1e1ff5c10a"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeFindPresentationParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("590098f3-05ec-4bc7-ac56-18d861124c44"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,91,139,220,54,20,199,191,74,240,67,159,172,162,203,209,109,250,184,108,97,161,221,4,146,150,64,88,194,145,116,180,107,50,99,79,108,153,118,25,230,187,87,158,217,77,134,176,217,166,105,105,73,154,55,91,246,209,185,253,127,58,218,189,238,166,31,187,117,161,113,149,113,61,81,59,95,164,85,67,90,123,155,2,48,138,206,49,136,100,153,11,153,179,132,92,56,145,188,78,33,52,109,143,27,90,53,71,235,243,212,149,166,237,10,109,166,213,171,221,251,77,203,56,83,251,58,31,94,158,199,27,218,224,47,139,131,8,224,147,83,146,33,196,200,32,112,193,130,79,154,57,20,50,130,68,159,157,111,142,177,72,97,162,228,200,153,204,222,51,72,193,50,31,92,100,58,129,163,168,29,96,112,77,187,166,92,206,127,223,142,52,77,221,208,175,118,244,238,249,197,237,182,70,121,244,125,54,172,231,77,223,180,27,42,248,12,203,77,13,196,37,7,217,71,22,192,5,6,214,7,230,49,26,6,32,100,86,160,76,68,217,180,17,183,101,217,182,121,94,176,204,83,211,142,148,105,164,62,210,73,78,142,107,196,72,192,156,225,192,128,215,162,161,167,192,120,214,32,44,104,175,34,111,218,132,5,127,197,245,76,135,184,118,93,53,12,210,107,110,69,102,150,176,102,72,70,50,151,4,50,47,124,200,202,42,153,179,188,175,246,79,195,240,102,222,214,74,79,151,243,134,198,46,222,181,141,106,253,135,113,181,139,67,95,198,97,189,108,126,121,98,112,108,207,221,199,151,199,146,172,15,95,22,195,102,223,206,19,157,173,59,234,203,121,31,135,212,245,215,135,206,237,247,213,102,179,197,177,155,238,11,121,254,118,198,117,45,64,119,125,243,104,193,159,225,88,253,215,174,127,105,41,183,219,251,200,15,49,47,114,78,221,180,93,227,237,225,125,213,124,247,118,30,202,15,23,253,147,237,56,92,47,57,31,23,154,15,12,239,127,84,30,18,4,7,76,59,50,44,101,33,152,183,162,202,130,139,100,56,121,229,162,185,219,97,223,62,232,234,114,40,79,170,240,198,66,233,79,92,185,79,119,117,85,123,251,143,114,170,130,202,194,56,207,146,179,245,204,224,193,48,207,45,175,176,10,4,153,147,114,220,127,62,167,26,188,136,74,101,70,94,218,122,34,161,99,168,109,117,6,78,112,66,13,81,155,19,78,151,205,30,166,212,234,0,73,85,204,181,78,75,70,201,44,202,227,76,101,240,168,93,242,38,218,47,77,178,223,40,253,24,165,47,112,122,243,56,51,57,16,199,88,165,16,115,228,71,102,2,231,249,223,97,6,81,201,136,185,170,154,180,96,32,193,84,35,206,235,255,17,200,25,74,206,136,191,51,219,4,100,180,130,17,175,135,0,40,169,25,214,121,87,101,11,40,189,162,36,148,59,97,230,12,11,93,15,227,237,195,220,120,35,72,114,87,3,20,178,110,150,42,133,129,123,189,128,46,200,64,50,241,219,116,251,122,166,219,207,68,165,218,60,142,14,200,104,33,130,255,79,198,77,136,90,59,203,13,203,38,214,113,99,173,97,193,250,196,164,128,68,150,132,225,82,126,62,58,96,14,163,20,107,12,102,81,251,210,60,149,3,179,156,162,196,76,73,219,124,130,206,211,237,118,24,203,220,119,229,35,244,32,129,201,193,89,22,185,172,137,33,213,241,149,148,168,23,68,169,98,74,222,67,204,255,159,169,115,54,79,101,216,124,165,232,156,205,99,237,126,121,50,188,215,196,227,24,97,118,84,147,37,198,169,18,4,210,16,195,170,108,38,99,206,74,165,58,140,28,60,126,65,252,203,46,95,93,76,79,127,235,239,209,59,150,237,234,251,186,250,193,194,187,75,252,106,247,41,81,238,175,78,112,191,218,255,1,24,125,65,165,92,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d7349ecf-3808-499e-94e5-a6af0b6c8059"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3ddba6f3-67f9-46a5-bda4-c9be1d38263b"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7711d045-dde7-4665-b251-2b6cda4ba16c"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("14ac52bb-d8de-4e93-ba14-2092314ad9ec"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44ef2079-3350-48f5-8417-a062c43f2a0e"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f79b49c3-44b7-458a-af53-ffc25ba8de44"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("bcd38317-a882-4317-8881-b21b8f0ca57b"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9371b699-8ba0-411a-be54-7912877edf8f"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ca81fffe-20a5-46bf-ab20-5fa6f0638a5f"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6c987b70-a95f-48b9-bcfb-8ddc2192e44a"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e64f2c49-b461-45e7-bb8f-1f660acca3cc"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b598adf2-e516-42e9-9f34-f99fb251a690"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5b343947-0aa5-4776-9b18-096d905e7603"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6f8cde56-f764-4ad1-b528-0d9031cd1e8e"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6351aab6-3117-48e1-afe4-c9ad827a53d7"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fbf3104-1357-48ca-926e-2f85305a4602"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a1185c72-1f88-4782-91cd-14d14087185c"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("cd2817ae-fc09-4cca-95f2-d6362651a8e4"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeLinkOppToProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("41befda8-dd24-45a3-8e91-5fa9d9e03fa0"),
				ContainerUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("773490bc-4ab0-4078-9f03-a0ead61c8e69"),
				ContainerUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
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
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
		}

		protected virtual void InitializeReadOppMainContactParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ec44add-c3cb-4c83-aa2a-21116fe737ce"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,93,107,219,48,20,253,43,197,15,123,178,134,44,201,150,228,189,53,100,80,24,109,96,31,12,74,40,215,210,85,99,234,143,212,150,89,67,200,127,159,236,212,107,9,101,108,180,47,125,211,135,239,209,185,231,158,227,253,77,217,127,46,43,143,93,238,160,234,49,30,46,108,30,169,68,107,170,20,37,90,74,65,4,38,150,232,140,165,4,10,33,153,78,81,48,173,163,184,129,26,243,232,88,189,180,165,143,226,210,99,221,231,215,251,39,80,223,13,24,223,184,105,243,213,108,176,134,239,227,3,14,152,20,142,91,146,74,224,68,8,68,82,100,66,16,171,185,16,9,240,196,34,139,142,92,138,172,48,142,26,71,36,179,142,8,150,106,2,41,229,161,50,161,162,192,148,73,21,62,173,208,249,229,195,182,195,190,47,219,38,223,227,159,245,183,221,54,176,60,190,189,104,171,161,110,162,184,70,15,43,240,155,60,74,69,90,36,194,2,49,160,50,34,64,178,128,174,28,73,45,56,14,180,40,156,165,81,108,96,235,71,216,232,106,187,109,59,63,52,165,223,69,113,135,14,59,108,12,62,107,12,80,100,174,80,146,24,202,76,192,67,69,192,242,132,128,102,220,88,171,181,48,46,138,45,120,248,1,213,128,19,185,125,57,182,25,116,165,50,9,109,34,232,32,121,198,136,178,9,16,157,232,194,113,201,153,115,108,150,252,75,219,222,13,219,32,119,127,57,212,216,149,230,113,118,24,134,208,118,249,222,180,141,239,218,106,4,191,124,86,112,156,209,227,229,207,163,46,213,116,51,22,70,135,120,232,113,81,149,216,248,101,99,90,91,54,183,211,248,14,135,80,83,111,161,43,251,89,205,229,253,0,85,16,160,188,221,252,85,245,197,208,251,182,126,111,253,198,161,215,0,19,28,59,113,30,13,109,203,126,91,193,110,218,231,209,135,251,161,245,159,22,67,23,166,239,207,218,39,79,28,47,162,19,128,185,0,156,194,208,44,18,138,73,18,156,156,33,1,37,41,97,198,57,206,45,165,78,137,71,132,67,252,54,79,94,95,244,87,191,154,57,122,71,217,214,31,195,233,201,193,106,174,206,247,255,194,242,176,158,121,174,131,59,222,52,238,1,223,105,149,114,98,165,83,68,216,34,33,138,106,77,140,6,206,81,211,52,75,221,43,226,110,104,86,48,64,34,205,248,99,115,33,248,74,167,140,20,146,107,165,57,75,89,166,158,197,125,213,149,53,116,187,179,209,67,96,252,139,70,214,180,200,210,34,112,13,196,67,226,19,17,8,75,169,9,19,140,134,5,56,77,229,108,228,243,182,173,16,154,255,112,242,98,131,230,238,188,125,56,245,113,232,207,220,21,225,252,37,23,79,152,175,136,237,106,118,195,251,106,248,133,220,158,166,98,244,231,100,218,245,225,55,167,91,127,183,250,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d00d1284-6858-4e40-8c5e-a0f9533fcf07"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0d4d59f-c216-40cc-ae96-8a3781c09399"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0d7bbe7-f11e-455f-b2e5-ea58c2f931f5"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c886b18d-6796-4aed-9bbf-b5cf5d06a8fb"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("57ed4753-40aa-4155-9040-01d05641a1f9"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5f7ffe6c-b419-41a7-92a7-41c7106f2edd"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,205,79,201,76,203,76,77,241,207,179,50,178,50,212,241,76,177,50,176,50,0,0,136,48,240,252,21,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				UId = new Guid("7e1be2d8-91ed-49a9-b295-80136f24d052"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("57df5b20-4163-4583-a743-b3bd41e7476c"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("36a1459d-8951-4d2d-83c0-ce1785ad17d6"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5227d4a1-7e1a-488c-b08f-249e8af25b4f"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("26f8e2e7-d0a5-4cce-a1c4-005d27eac4ef"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a91ced74-aa15-4fc9-ad90-beb2c4848a91"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0597c0d4-7fe9-438b-996d-a1cec2485907"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				UId = new Guid("24109401-bfc2-4470-b36d-6264dd15b451"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("213f4da0-dbd4-4801-9f20-61ad02c52c1a"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,5,193,65,1,0,32,8,3,192,68,123,224,112,64,28,132,254,25,188,107,157,92,118,35,74,6,47,39,50,245,96,212,149,237,206,148,62,148,174,20,226,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("14eb509a-8789-4d60-a6db-802311455631"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ce39439e-0507-44c2-ad51-a76f693a3d3c"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("81a3e144-a50d-43c1-b259-3b436b1bd4d0"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeStartSignalLeadStageChangeParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("db9eb8c4-a431-4aa1-9ee4-580f6ffe1896"),
				ContainerUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
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
				UId = new Guid("e33c0cfe-adc7-4b51-8f8f-370d3a2a3f3d"),
				ContainerUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("89651dda-ab13-4a9a-8a6c-4c658eb62d6b"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("26dd7e96-d79a-4c1d-a31a-e8388a3d205d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"df249c13-df7a-48d2-b128-85183c4a0e10",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("816e7c8a-2c10-4a6f-9be0-35eb9c4ddff5"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97a322a9-f1ca-49d6-ab97-756349dc65dc"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,171,86,82,41,169,44,72,85,178,82,10,73,45,42,74,44,206,79,43,209,115,206,47,74,213,11,40,202,79,78,45,46,214,243,201,79,78,204,201,172,74,76,202,73,13,72,44,74,204,77,45,73,45,10,75,204,41,77,45,246,201,44,46,209,81,64,213,166,164,163,164,82,6,150,85,178,138,142,173,5,0,199,127,71,237,94,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("c5f0d6a4-d18b-446e-8335-18fb080f660a"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc433afb-dfc9-4098-97f6-caf21a16f74e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("1c82493a-8e96-4e42-8e59-0050ff57ccc6"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("933618d4-76fc-43ac-ac72-94ef456a3325"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e24948f-5ffc-48eb-8cd6-6290a4458b50"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41355bca-971c-4003-990e-8da96ce29d27"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8971ff1-f4b5-4bd1-ad83-92a56940fda8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("6399efc5-9d36-4c8d-84c5-3e5851db8ea2"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isReexecutionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c482b777-a1a7-41d8-86f3-3deb50dd0ff8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"Enter the opportunity details",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("8a4540f5-5964-49f6-9dd1-077938701455"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("4960bd57-b2f9-45a4-9184-feb6f57d727b"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dbe4def5-6971-4b97-a463-8f91e0d395d8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("865a5fc7-ff9d-42c1-b37f-e7d02f2ef7aa"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f513407c-014f-4acb-a526-b212d7445f91"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8dabbbff-449b-468b-a494-80ad1cb1636d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("502e4584-f30e-4b9b-bc80-da8f5149d287"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("514f3679-fd23-41d3-ac6e-b13355c6b716"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea067875-15ce-466a-b805-9fd42938fa32"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab3aea55-ee61-4a61-8d37-c77f890582a6"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("e98d7ab1-5b31-4dfd-bd8a-01a99df1c13e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("4fbdcb67-4e39-4e84-b5d0-e4916df0cc20"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("92150aaf-bd20-4b0b-aae5-802a6ddacaaf"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("b9c197e7-4fda-443b-af5d-04703f2512af"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("500c6c82-6637-4f8b-bb30-9fb30e6c5c7a"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("4450ed80-79a2-4253-bf53-f4c99757acd0"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("ad403374-d787-48cb-8401-24d5938fecff"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("29b687ca-aff7-43a8-8cf5-918beb75a406"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("12c7bcea-bbb6-467e-8b86-c73d6c2327ac"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("0b1c3a54-c7df-40ad-9016-020646d1af0f"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("f71b0056-5161-4704-b6e6-57433d6cec8d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a103d16-ba6b-4bd1-8ddc-3e9254763dc8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("ef2d226f-d2f6-44b9-8885-f2dc3c38e962"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41c2a0db-39ad-4b1a-9e9b-392fb44871ef"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("b75c6907-0060-42e9-a1b2-3ef95bc2be78"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("66c1e2c8-d668-462c-8641-cc41b2cb6ee7"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("aef3f8a1-0813-481c-8557-882ce62c0029"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("002eea98-0f7a-4a3f-843b-636f63d8cf6e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("bc19d651-dabb-46b9-9f3b-b8da6581c36d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("f650edfc-44d9-4d70-bb68-14bd3c9ad3d1"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("ca76ab70-8cff-4f21-81c9-b9e679c8ddff"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("b40747ec-b53b-4474-ba15-384d04322c33"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("35d9c012-2263-46ec-952f-e92631c411de"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
				UId = new Guid("cd406c52-f5b6-4f47-9117-6e510888a57e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
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
		}

		protected virtual void InitializeReadDataLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9d21b7c3-5ea8-4f73-a5bf-f266ecb2b022"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,43,139,14,61,89,193,31,178,44,185,167,18,182,101,161,164,161,77,75,33,187,132,145,52,202,10,252,177,177,100,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,239,205,123,143,241,116,231,252,71,215,4,28,106,11,141,199,100,220,152,154,100,210,90,142,105,74,139,74,48,202,84,165,169,50,105,78,83,166,75,101,109,145,231,138,145,164,131,22,107,178,160,215,198,5,146,184,128,173,175,111,167,63,164,97,24,49,185,179,167,226,155,222,99,11,223,231,1,44,3,43,36,74,90,149,169,162,12,149,162,66,131,166,145,91,42,206,4,203,80,147,69,11,151,69,202,115,163,169,182,149,165,76,8,67,21,207,128,102,25,67,109,173,180,188,200,73,210,160,13,235,167,195,128,222,187,190,171,39,252,125,190,121,62,68,149,203,236,203,190,25,219,142,36,45,6,184,134,176,175,9,96,138,172,212,64,53,147,37,101,22,43,10,133,52,180,0,85,229,149,192,140,103,21,73,52,28,194,76,75,54,134,36,6,2,252,128,102,196,19,243,228,162,198,188,72,51,81,242,136,205,10,77,89,145,167,84,112,81,81,107,184,149,88,112,41,149,57,231,245,105,116,241,236,252,213,216,226,224,244,75,236,24,243,235,135,122,210,125,23,134,190,153,169,175,78,207,111,240,41,44,225,190,92,253,92,12,133,216,159,65,228,152,140,30,47,27,135,93,88,119,186,55,174,187,95,56,143,199,8,105,15,48,56,127,78,97,253,48,66,67,146,193,221,239,255,154,214,229,232,67,223,254,71,86,147,104,51,114,196,37,59,201,157,119,208,56,127,104,224,249,84,215,228,221,195,216,135,247,159,17,204,202,7,184,199,122,181,221,46,189,15,143,224,66,100,90,121,104,240,220,188,248,138,186,31,204,106,99,150,154,188,26,80,147,45,129,162,168,152,101,156,150,60,134,192,170,148,83,89,2,206,139,201,180,80,74,89,38,46,140,146,168,132,102,20,88,145,81,6,144,81,137,200,104,41,82,203,173,197,76,72,190,37,209,217,191,215,123,187,241,95,30,187,243,111,184,4,183,187,136,221,87,141,117,131,109,76,184,158,222,98,240,24,1,215,231,81,245,244,22,187,199,221,108,120,119,140,223,47,96,108,124,62,126,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ddb8f352-0211-44fc-8b93-f3abbd023649"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65843b8b-f9d2-41cc-8170-734e51b1a5ca"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b341955e-cf2a-400b-907c-a8557f3c93c1"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1409c0d5-2885-44c0-8161-47a69431903e"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bf8e626b-4175-4de4-99ed-f96ac7a26c1d"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5b1ea493-ed30-4d02-bdbb-0efcafe849f9"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("d4413fda-e205-481c-828d-b4e67061712f"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95dce4e4-ff66-4664-b6f7-dacd9bf91bca"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9a35a728-e367-4047-bda3-0b7be164f5ae"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7090f5b0-1f18-467e-9a40-60d3d177b9c4"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("11af421d-b60c-4cf9-a2f6-5d599eaa340c"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2c5d37d8-5236-42a7-b93f-6d4732c94385"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("83955bee-426f-4831-9715-4eda69412fb7"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2d0ef092-481e-4e72-920c-caa204e62d66"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e72ba4ac-d6aa-4c7c-8d86-2be667ba6622"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cc0389f7-a908-4db4-b2f9-dc8c55c3a68c"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8ca2796a-0852-480e-8a35-8f82f9d2dc8f"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("58ed1820-e362-49f5-968c-162a220fb729"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeChangeDataLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("f161763e-878f-4674-8e4e-3fc88a6a58b3"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("092165e2-051d-4f89-92cf-c710ba91ab13"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6c0d30ee-7c93-4ea8-9ca4-918c3d232658"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,93,107,219,48,20,253,43,65,15,123,178,130,63,100,125,120,143,193,29,121,233,202,214,141,65,27,138,62,174,26,129,108,167,182,204,90,76,254,251,228,56,217,160,15,35,79,131,129,49,146,236,115,238,61,71,231,78,79,110,184,113,62,64,95,89,233,7,72,198,173,169,16,0,147,52,215,6,231,196,8,76,88,193,176,96,165,198,5,213,25,37,37,48,81,50,148,180,178,129,10,45,232,218,184,128,18,23,160,25,170,135,233,15,105,232,71,72,158,236,105,243,85,239,161,145,223,230,2,36,147,150,11,16,152,149,169,194,4,148,194,92,75,141,173,45,132,162,132,147,12,52,58,247,66,129,105,158,26,204,152,178,152,112,41,176,52,156,97,150,131,42,121,206,210,82,151,40,241,96,67,253,122,232,97,24,92,215,86,19,252,94,223,191,29,98,151,75,237,77,231,199,166,69,73,3,65,222,201,176,175,144,132,20,72,169,37,214,68,148,152,88,96,88,22,194,224,66,42,150,51,14,25,205,162,82,45,15,97,166,69,91,131,18,35,131,252,46,253,8,39,230,201,197,30,243,34,205,120,73,35,54,43,52,38,69,158,98,78,99,143,214,80,43,160,160,66,40,115,241,235,211,232,226,218,13,183,99,3,189,211,103,219,33,250,215,245,213,164,187,54,244,157,159,169,111,79,191,223,195,107,88,204,61,127,250,177,8,10,241,124,6,161,99,50,14,176,241,14,218,80,183,186,51,174,125,94,56,143,199,8,105,14,178,119,195,197,133,250,101,148,30,37,189,123,222,255,213,173,205,56,132,174,249,143,164,38,81,102,228,136,33,59,181,59,103,208,184,225,224,229,219,105,95,161,15,47,99,23,62,126,1,105,86,126,126,205,202,214,55,174,31,194,106,14,237,170,179,171,232,192,232,67,228,92,233,206,123,208,243,141,175,183,102,65,162,119,21,42,244,136,44,16,195,57,164,152,208,56,27,132,43,137,69,166,52,6,97,192,144,82,21,186,76,215,134,144,172,176,70,98,200,211,24,48,158,105,204,115,110,176,34,64,89,26,211,149,229,118,125,77,10,31,81,212,255,15,84,61,108,135,207,63,219,203,180,46,254,238,214,241,244,221,65,237,161,137,23,81,77,215,216,112,140,128,187,75,169,106,186,198,148,25,82,183,193,133,183,101,106,171,233,26,151,142,187,217,167,221,49,62,191,0,138,129,16,15,219,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55a55d6a-8498-40c0-bdfe-95136f257586"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,207,111,218,48,20,254,87,144,219,35,70,137,109,226,56,183,169,221,1,169,221,208,218,245,82,56,60,251,61,175,72,33,65,78,216,196,80,254,247,25,3,107,233,182,203,124,72,148,247,242,253,176,223,231,61,187,238,119,27,98,21,123,164,16,160,107,125,63,185,105,3,77,230,161,117,212,117,147,187,214,65,189,250,9,182,166,57,4,88,83,79,225,9,234,45,117,119,171,174,31,143,46,97,108,204,174,191,167,46,171,158,247,108,214,211,250,235,12,35,59,9,69,22,209,114,169,75,199,213,84,228,188,4,178,188,240,30,193,72,52,152,97,4,187,182,222,174,155,123,234,97,14,253,11,171,246,44,177,69,2,237,188,247,74,150,220,16,149,92,9,45,120,153,23,200,167,72,86,99,230,12,202,130,13,99,214,185,23,90,67,18,125,5,171,28,124,105,200,112,61,205,44,143,78,44,47,29,56,238,189,52,182,80,165,202,201,29,192,167,255,95,129,207,87,207,179,238,243,143,134,194,67,226,173,60,212,29,45,39,177,250,174,240,177,166,53,53,125,181,87,106,234,139,146,4,183,152,73,174,180,42,56,20,90,115,41,180,181,164,181,240,133,27,34,224,247,105,86,123,44,156,4,44,163,61,105,52,87,136,17,34,132,225,126,42,200,131,149,168,164,29,150,87,203,131,69,92,117,155,26,118,79,127,58,253,128,56,106,55,155,54,244,219,102,213,239,38,55,129,160,39,28,5,114,109,192,209,12,143,4,155,139,41,190,165,216,47,142,97,88,176,106,241,175,56,156,222,199,205,95,6,226,125,22,22,108,188,96,15,237,54,184,3,163,60,124,156,103,147,20,178,211,226,127,121,156,215,145,35,193,238,161,129,111,20,62,69,197,4,79,173,91,232,33,137,63,70,223,103,98,43,204,52,211,185,231,154,192,196,105,23,49,42,152,3,55,185,177,94,106,41,188,23,9,253,133,60,5,106,28,93,26,3,82,133,183,165,230,46,19,49,171,16,243,6,40,115,14,70,72,135,104,140,114,62,225,147,242,171,153,115,108,99,165,217,214,117,18,232,210,254,15,247,224,100,252,212,185,125,51,198,55,12,45,174,252,138,112,214,252,207,81,13,108,24,150,195,47,165,56,77,219,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddDataContactToOpportunityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("77b402b4-36ef-4afe-85ca-fbbfe0540b9f"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
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
				Value = @"fa274f3d-57a3-44ee-b644-d93441a31de2",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("611d2131-f988-40c6-a266-7ac3720e4624"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f87e7355-4618-4675-ac15-23509e6ffedd"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
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
				UId = new Guid("20e936ce-6092-493c-b50c-aaf70285c26b"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ccc51ea5-dba9-4d02-9514-ddb4ac2fa55c"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,201,110,220,70,16,253,149,1,237,227,244,160,247,101,110,129,236,0,2,236,68,177,29,95,36,29,170,187,170,237,1,40,82,32,57,9,148,193,252,123,106,40,77,180,36,81,140,32,7,39,8,15,92,186,249,94,85,119,189,87,189,107,94,78,55,215,212,172,155,15,52,12,48,246,117,90,157,244,3,173,206,134,190,208,56,174,222,244,5,218,205,47,144,91,58,131,1,174,104,162,225,35,180,91,26,223,108,198,105,185,120,12,107,150,205,203,159,230,217,102,125,190,107,78,39,186,250,241,20,153,61,37,116,165,70,16,9,180,17,54,147,23,89,133,34,164,71,95,93,177,197,57,203,224,210,183,219,171,238,45,77,112,6,211,231,102,189,107,102,54,38,112,214,101,101,17,68,129,232,133,133,160,5,184,88,133,67,168,6,100,206,21,101,179,95,54,99,249,76,87,48,7,189,7,87,208,193,86,131,194,5,224,232,150,72,100,111,173,192,100,172,85,96,20,146,62,128,239,254,191,7,158,191,56,63,29,191,255,185,163,225,253,204,187,174,208,142,116,185,226,209,39,3,175,91,186,162,110,90,239,172,117,213,71,210,34,163,228,88,193,122,1,62,4,97,116,200,153,66,208,213,151,61,3,126,219,205,245,14,125,49,128,49,137,96,82,16,22,145,33,90,39,81,157,166,10,217,160,53,121,127,249,226,242,144,34,110,198,235,22,110,62,254,62,211,111,16,23,253,245,117,63,76,219,110,51,221,172,78,6,130,137,112,49,80,233,7,92,156,226,45,193,245,163,42,62,164,216,93,220,138,225,162,89,95,252,153,28,238,158,183,139,127,44,136,167,90,184,104,150,23,205,251,126,59,148,3,163,57,124,28,107,51,71,144,119,151,248,131,219,241,186,229,152,97,111,161,131,79,52,124,199,17,103,248,60,245,10,38,152,131,127,224,188,143,196,89,39,39,131,170,34,16,36,97,201,107,17,81,177,244,84,202,213,4,163,107,213,51,250,29,85,26,168,43,244,56,49,32,235,107,142,65,20,169,11,75,141,162,0,52,74,64,210,166,32,166,100,75,157,241,115,228,251,100,142,178,229,145,110,219,182,115,128,113,94,255,193,7,119,137,223,205,188,122,80,198,7,12,61,110,234,134,240,180,251,59,91,181,111,246,251,229,67,211,185,74,177,168,232,68,214,200,186,10,54,240,26,140,19,209,131,211,198,231,28,12,60,107,58,240,58,162,1,16,33,121,37,108,178,70,196,232,179,80,198,59,175,16,75,73,254,171,48,93,37,139,49,146,20,214,59,46,89,204,135,106,231,34,40,33,33,119,14,83,156,124,106,58,78,194,84,110,40,164,165,99,136,42,34,242,106,69,102,193,4,233,85,80,186,30,32,175,187,137,221,116,50,239,209,122,7,104,147,68,23,133,116,22,216,170,188,185,73,179,197,17,163,245,158,178,73,209,252,181,85,223,17,224,162,61,220,144,5,188,250,118,51,140,211,98,195,117,91,244,149,253,58,110,219,105,211,125,90,112,97,90,42,211,166,239,86,63,108,185,11,31,164,177,128,145,199,187,9,202,244,191,159,191,204,207,202,103,98,193,42,17,43,183,101,171,92,226,126,128,82,64,148,220,90,125,52,136,230,95,225,103,67,209,73,105,188,136,217,176,248,136,15,11,176,42,136,16,17,164,211,197,161,194,231,15,209,34,125,214,64,34,148,96,133,61,168,63,38,199,71,21,31,60,49,25,237,180,143,255,188,159,167,129,31,207,248,225,56,255,223,63,153,146,204,222,229,202,221,163,86,110,83,202,178,38,67,72,66,91,45,249,5,106,146,225,57,37,127,113,98,95,161,146,47,247,191,2,149,74,120,39,108,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77fca69f-0da0-430c-a3da-c7ed23ab5394"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
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

		protected virtual void InitializeAddDataOpportunityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("36768833-e793-4cd5-8c7c-6fa9657737df"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
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
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1aa11035-b136-470f-8cb3-1f4060a6f342"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05d8eeec-d375-46f9-ae98-2ee983ccb91d"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
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
				UId = new Guid("8513b4b5-7a5d-4bac-b336-7ffa764d5510"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("488491cb-2475-44b0-9985-39cc11395c42"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,153,75,111,27,71,18,199,191,10,193,228,144,32,106,109,191,31,2,114,216,181,179,128,129,60,140,216,155,139,229,67,117,87,149,67,128,34,5,146,202,194,43,232,187,239,127,40,57,182,156,13,19,56,48,98,135,203,195,80,154,97,119,245,116,213,175,94,125,61,255,116,247,242,82,230,103,243,167,178,217,208,118,173,187,211,7,235,141,156,62,222,172,135,108,183,167,95,175,7,45,23,255,161,190,148,199,180,161,11,217,201,230,7,90,94,201,246,235,197,118,119,50,187,63,108,126,50,255,244,167,253,211,249,217,179,235,249,163,157,92,252,235,17,99,246,214,83,200,201,6,19,40,14,19,11,59,211,184,116,51,186,102,73,73,109,234,5,131,199,122,121,117,177,250,70,118,244,152,118,63,206,207,174,231,251,217,48,65,236,45,73,80,53,202,201,155,72,226,76,183,148,140,31,201,89,220,119,137,202,252,230,100,190,29,63,202,5,237,133,190,30,76,18,179,246,90,204,176,30,210,73,170,33,14,206,80,243,97,48,183,22,135,78,131,239,126,255,122,224,179,79,158,61,218,126,247,239,149,108,158,236,231,61,83,90,110,229,249,41,238,190,117,227,231,205,57,187,14,209,147,140,148,77,13,169,153,56,82,55,213,231,110,154,212,88,155,114,166,216,111,158,127,242,124,146,200,139,237,229,146,94,254,240,75,193,127,31,99,125,181,218,221,254,236,242,222,214,191,249,195,235,243,91,13,158,207,207,206,127,77,135,119,223,183,43,190,175,197,183,21,120,62,63,57,159,63,89,95,109,198,52,99,152,254,121,181,161,123,9,246,238,99,254,199,229,213,231,118,142,253,176,111,104,69,47,100,243,45,36,238,135,239,31,61,164,29,237,133,63,197,186,95,77,220,125,75,182,56,53,69,8,155,38,217,155,202,142,76,115,173,107,40,193,171,250,253,232,239,69,101,35,171,33,247,23,230,19,151,225,168,27,199,98,77,76,22,246,17,173,55,214,139,21,216,134,231,124,251,114,123,201,175,23,243,202,214,112,103,117,181,92,238,5,108,247,239,63,25,239,221,194,239,158,60,124,67,89,111,204,176,230,133,46,132,31,173,222,101,171,110,230,55,55,39,111,146,210,93,175,213,86,216,120,215,201,86,49,130,74,247,38,48,87,219,216,106,200,249,32,41,165,217,148,195,152,72,113,209,68,78,108,40,41,155,158,133,185,59,203,153,195,7,66,74,247,61,69,73,193,164,96,161,116,56,8,67,35,23,211,43,197,98,19,123,223,227,68,202,108,246,197,236,124,254,183,243,57,190,63,123,39,73,214,119,23,115,99,83,60,177,137,13,226,168,96,143,114,143,174,151,198,209,81,153,36,125,225,62,63,125,186,126,178,219,44,86,47,62,251,252,48,161,147,113,204,214,58,27,203,133,76,160,190,181,202,7,251,219,223,93,94,174,55,187,171,213,98,247,242,193,45,207,191,20,241,215,167,59,13,10,73,29,212,235,0,102,156,116,76,45,147,9,53,48,101,82,26,58,14,209,253,187,23,246,161,211,173,85,123,240,109,152,28,90,54,81,1,89,117,61,153,208,124,212,164,131,97,138,135,227,96,136,112,15,77,76,70,204,52,209,103,76,80,225,231,90,170,170,210,108,119,37,255,153,116,127,181,148,11,152,253,217,181,74,228,90,39,95,156,19,100,213,62,249,242,62,140,52,22,142,169,135,145,236,205,125,72,57,70,23,148,201,136,159,222,173,58,188,155,175,240,92,8,7,197,102,87,156,215,105,200,87,171,221,30,167,105,143,206,174,107,245,93,29,23,120,72,132,143,232,109,53,213,14,50,93,155,11,163,50,54,89,127,59,220,126,47,196,179,229,116,97,24,240,233,63,23,155,237,110,182,128,222,38,194,55,178,189,90,238,192,235,12,138,89,202,216,45,214,171,211,127,92,241,11,57,154,248,156,198,168,54,91,54,153,129,113,44,37,24,228,50,80,208,112,8,173,154,83,163,124,28,4,35,130,138,228,134,236,78,43,24,26,72,52,74,138,166,217,192,41,33,156,164,234,15,18,28,136,122,32,239,13,56,128,11,112,148,77,171,189,35,222,143,50,200,219,222,237,159,74,240,59,68,205,217,151,95,206,236,97,190,126,45,26,254,60,244,175,143,16,156,115,78,29,70,99,117,202,236,92,116,166,150,210,140,159,124,86,41,164,205,150,163,64,136,74,25,165,68,100,3,41,195,172,184,195,136,27,57,227,131,182,96,125,118,105,28,78,113,115,141,41,5,66,18,145,96,156,32,130,12,105,236,70,71,201,210,84,66,110,241,184,130,96,26,86,169,32,165,232,182,6,216,150,207,200,164,165,153,161,204,195,99,179,26,217,247,17,4,159,208,82,182,179,245,180,41,199,18,9,255,104,165,234,114,135,129,38,192,175,130,42,207,161,71,80,153,1,67,69,4,137,25,25,49,135,143,2,99,91,53,137,6,54,106,17,14,163,199,219,52,74,5,197,92,213,236,145,34,248,49,14,99,220,45,143,138,250,52,20,184,128,232,198,148,185,53,50,89,130,101,38,117,26,252,177,97,156,27,30,71,147,61,222,7,93,12,100,89,185,171,65,166,144,7,12,35,35,199,120,31,24,127,43,194,179,9,206,255,67,252,251,32,22,203,93,58,146,184,216,2,46,34,2,126,213,27,130,221,163,219,50,164,214,250,81,64,28,74,10,5,29,88,195,21,69,101,236,25,33,36,0,168,224,98,13,72,248,136,188,28,132,120,192,11,160,165,132,88,76,109,242,2,45,129,195,9,21,69,103,183,70,155,209,221,61,46,136,227,8,148,213,161,225,219,24,177,184,147,162,84,66,133,96,75,246,37,178,205,37,141,247,1,241,67,25,139,45,254,152,237,22,23,178,92,172,142,6,102,246,78,154,104,132,21,101,116,60,173,243,166,251,154,141,146,163,10,37,49,197,120,20,137,181,160,48,75,14,169,73,86,28,58,160,133,10,175,132,88,106,68,139,160,72,101,75,238,112,98,237,112,18,163,182,57,35,57,79,189,20,198,209,133,197,49,141,198,129,10,48,7,4,234,35,235,46,81,180,148,227,84,96,88,33,216,150,160,90,143,5,217,117,106,195,177,246,222,130,190,191,196,154,23,63,237,145,62,22,146,255,104,110,157,24,149,33,32,48,46,77,182,193,146,80,16,225,66,138,131,15,205,165,161,78,250,40,72,182,22,110,12,113,212,168,19,84,184,83,150,77,21,36,19,15,237,54,72,138,153,14,231,214,56,57,66,179,1,45,246,100,247,53,182,162,33,202,213,104,79,165,81,193,140,77,62,144,46,19,186,34,33,38,143,38,56,206,71,77,68,55,4,241,114,242,90,165,143,209,42,185,146,242,111,35,246,96,189,218,209,56,154,126,108,63,226,42,244,249,205,127,1,179,150,13,217,183,32,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6c3ad89-7397-4dd6-a229-f52efab3d43b"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
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

		protected virtual void InitializeReadDataCountOpportunityByAccountParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95d638cd-1142-40c7-b944-f9e7fdc8b952"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,203,106,221,48,16,253,23,45,186,178,138,172,135,109,185,171,114,185,133,64,73,3,125,80,8,151,48,150,70,137,168,95,177,101,218,96,252,239,149,175,175,219,144,69,41,221,21,188,176,70,62,103,206,57,51,158,239,252,248,206,215,1,135,210,65,61,98,50,93,217,146,228,40,152,171,148,162,185,213,5,149,70,56,90,9,204,104,206,192,72,147,170,194,106,32,73,11,13,150,100,67,31,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,206,157,15,31,205,3,54,240,121,109,0,40,51,87,21,57,53,140,27,42,1,11,10,86,164,20,52,23,198,90,173,165,113,100,211,82,137,194,10,6,21,205,114,107,169,204,101,69,11,192,156,102,90,88,6,232,42,233,10,146,212,232,194,241,71,63,224,56,250,174,45,103,252,245,254,233,169,143,42,183,222,135,174,158,154,150,36,13,6,184,129,240,80,18,89,105,133,194,57,234,172,226,171,144,148,86,12,20,229,70,165,44,214,83,5,57,73,12,244,97,165,37,111,141,233,166,54,58,29,208,225,128,173,193,103,166,184,178,185,73,163,210,212,34,163,82,177,200,37,25,167,140,35,195,200,195,109,134,36,177,16,224,11,212,19,158,133,205,126,181,200,181,98,121,234,104,142,160,169,196,140,211,194,166,64,117,170,43,39,114,193,157,227,123,220,239,187,238,219,212,199,168,199,235,169,193,193,155,203,220,48,14,160,27,202,217,116,109,24,186,122,37,191,126,6,216,230,115,185,252,186,101,82,159,111,86,32,89,146,105,196,67,237,177,13,199,214,116,214,183,247,231,209,45,75,196,52,61,12,126,220,147,60,62,78,80,199,0,252,253,195,31,19,63,76,99,232,154,255,205,111,18,189,70,154,184,173,103,205,235,50,91,63,246,53,60,157,207,37,121,245,56,117,225,205,101,15,182,3,121,1,218,63,18,146,3,26,149,209,66,168,104,211,168,184,185,60,171,168,198,66,22,218,217,12,100,117,97,88,146,127,111,115,123,53,126,248,222,238,191,215,22,207,233,117,172,190,40,220,236,232,114,254,27,101,203,105,215,118,90,226,243,19,99,190,182,24,41,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("baccf23b-370e-4e0b-b657-7bfa21cdd970"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("daf54a7f-8a62-4589-9c9c-c261921a13fd"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cf300c28-9b38-48ff-a8d5-ecb1fba12e64"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc3b5658-a8e6-4cab-b27b-819a3025ed71"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("693953ab-8637-4183-87d1-ee4988a862f8"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e608114-da8f-4197-a7c1-9abde0e48dca"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("a81f55d7-8bc9-4327-b691-9ede33487823"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a83ce913-3e58-4db8-b563-712f4f1f1d4f"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f23fe366-df2c-4531-b2ed-ebdf444d985e"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("236f9f63-489b-4485-b92a-f5a499fe453e"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5a384c94-4c0e-46d6-ab9c-2f2f6cf1de5a"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("199f3817-15db-4ed6-b57f-350fc7b100b3"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d3ab4b8a-b637-47a5-bc47-da539d6683f1"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("156fda51-7aad-4289-bdf5-909adb3f882f"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("84c58779-0b9a-4c9a-92d9-5ba3900861f5"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d2b28272-8058-40a5-b869-30703026b4b7"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d801edde-baf3-46d2-a9c0-3a75ffe91790"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bc100e0a-c81b-4273-8655-6fbd2d302636"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadDataAccountParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("760c8144-4547-4f2e-9058-d28c8497d3e6"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,75,150,100,203,61,149,101,91,246,146,6,154,150,66,178,132,177,52,202,10,252,177,177,37,154,96,246,191,87,94,103,91,8,164,244,90,240,65,51,242,123,243,222,243,120,190,247,211,39,223,6,28,107,7,237,132,89,220,217,154,104,41,100,213,8,164,220,161,163,162,44,12,5,110,52,101,210,22,76,114,38,157,2,146,245,208,97,77,86,244,214,250,64,50,31,176,155,234,219,249,15,105,24,35,102,247,238,92,124,53,7,236,224,219,50,128,75,91,26,6,13,101,22,115,42,100,206,104,35,114,78,115,142,57,74,40,185,85,72,86,45,133,170,10,149,231,72,133,168,52,21,73,2,213,142,91,170,114,165,26,141,186,114,150,145,172,69,23,182,79,199,17,167,201,15,125,61,227,239,243,205,243,49,169,92,103,111,134,54,118,61,201,58,12,112,13,225,80,19,72,243,132,52,64,141,208,146,10,135,37,133,66,91,90,64,83,242,178,66,166,88,73,50,3,199,176,208,146,157,37,153,133,0,223,161,141,120,102,158,253,98,167,200,89,37,85,194,178,20,149,40,120,78,43,85,149,212,89,229,52,22,74,235,198,94,242,250,28,125,58,251,233,42,118,56,122,243,18,59,166,252,134,177,158,205,208,135,113,104,23,234,171,243,235,55,248,20,214,112,95,174,126,172,134,66,234,47,32,114,202,226,132,155,214,99,31,182,189,25,172,239,31,86,206,211,41,65,186,35,140,126,186,164,176,125,140,208,146,108,244,15,135,191,166,181,137,83,24,186,255,200,106,150,108,66,250,170,56,158,229,46,59,104,253,116,108,225,249,92,215,228,221,99,28,194,135,143,198,12,49,244,107,65,94,129,106,114,71,10,193,1,141,84,180,42,100,90,54,35,27,90,113,213,80,141,85,218,190,228,17,68,115,71,146,144,183,233,251,240,54,253,237,110,250,242,179,191,252,9,171,246,253,251,212,125,213,184,190,32,235,249,95,20,157,246,139,166,253,41,61,191,0,77,248,193,226,208,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("29d241ea-e7c1-468b-93dd-4fabc9692e05"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99fe1d4f-11a3-4a99-a403-3f8329c46387"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("23c9ab4d-c03e-4823-a89d-b8157e04f637"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0481537e-1347-4a84-bc95-3f25b63bd2aa"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("98fe3323-90ae-4f77-9698-90cb6049bb21"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ab5fefa4-6698-4258-940b-0a2c6dd14a31"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("d3b28169-5be2-4f9c-97c0-eef28ed4f516"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3bc1a643-8bc8-4d8c-96c9-19e0df86a151"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("801aa1e5-b4cb-4d94-abad-0dfa07dffec6"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f75452e6-8240-4d69-825e-90cd8847e099"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("36ec811c-adc6-4e15-a536-d4bbcf966b71"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("affd0b02-dbe8-4101-aeb3-b62e33160dd3"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("591a5668-a8e2-41dc-a509-888da5a63e1a"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9cc3666e-b170-44af-a775-f6810f7e7250"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87a74108-882e-4315-a51f-706bae061c72"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5436907-184b-4bae-b060-99c5407f2a22"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("89901727-f199-48c2-bcdc-e40b65c75a7c"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("147cccd2-825b-42c6-8465-5624d50c9a10"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadDataContactParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f3d16d53-5568-4d10-85f2-ecee93297c69"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,178,44,185,199,176,41,185,164,233,39,133,36,132,177,52,74,4,254,216,216,50,77,48,251,223,43,175,179,45,228,80,114,43,5,99,164,177,231,157,153,103,102,230,187,48,158,135,38,226,80,121,104,70,204,166,11,87,17,174,153,182,166,246,20,77,201,168,100,165,162,26,184,163,194,131,46,13,228,142,215,156,100,29,180,88,145,213,123,231,66,36,89,136,216,142,213,245,252,71,52,14,19,102,119,254,120,249,98,31,176,133,111,199,0,170,70,161,10,78,181,199,156,74,94,24,170,157,99,20,52,19,78,42,45,156,19,100,205,197,139,154,21,181,49,20,148,209,84,170,218,81,173,114,65,89,201,188,231,70,50,101,24,201,26,244,113,247,180,31,112,28,67,223,85,51,254,62,127,125,222,167,44,215,216,103,125,51,181,29,201,90,140,112,5,241,161,34,128,12,101,97,129,90,105,10,42,61,150,20,132,73,149,66,93,230,165,70,174,120,73,50,11,251,184,200,146,11,71,50,7,17,190,67,51,225,81,121,14,41,199,92,48,174,11,149,124,185,176,84,138,156,165,28,117,73,189,83,222,164,66,141,169,221,137,215,135,41,164,115,24,47,167,22,135,96,95,176,99,226,215,15,213,108,251,46,14,125,179,72,95,30,127,255,138,79,113,133,251,242,233,199,90,80,76,246,197,137,28,178,105,196,179,38,96,23,119,157,237,93,232,238,87,205,195,33,185,180,123,24,194,120,162,176,123,156,160,33,217,16,238,31,254,74,235,108,26,99,223,254,71,165,102,169,204,164,145,134,236,152,238,50,131,46,140,251,6,158,143,247,138,188,123,156,250,248,254,51,130,219,52,203,107,169,108,123,30,134,49,110,150,161,221,244,126,147,8,76,77,76,154,27,219,55,13,218,165,227,219,79,9,88,240,1,221,6,198,100,239,34,216,184,106,145,87,49,43,114,67,60,74,167,53,166,149,81,69,130,163,107,160,134,215,54,173,145,67,39,139,90,216,130,109,157,148,92,120,7,20,115,150,70,78,115,75,117,174,29,173,37,170,146,165,121,227,185,223,130,147,134,185,66,83,86,72,160,73,181,160,38,151,138,58,167,165,82,88,11,163,197,13,73,68,254,73,157,215,23,227,199,159,221,105,163,215,30,220,110,147,245,149,97,215,96,155,154,85,205,111,1,115,72,14,87,167,80,213,252,22,76,139,203,174,139,33,62,175,155,93,205,111,225,118,184,93,200,221,30,210,243,11,19,114,238,11,255,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d0e3dc9-842e-46e7-8ec6-d71896474631"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("01b2e31d-1d81-4b50-bc28-b8d8b4b60976"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2fc79c56-2808-4e39-a3da-7b92d8218134"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4d312b88-dd01-43fa-a2cf-92d118789fc2"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("705dbcc7-95ff-47ba-a0de-e637092435f6"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0dfc2b7f-d9f0-4923-87e3-ce36e9fb5442"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("daa09ed7-2a7d-4450-a30a-dd8ac16c0a06"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c0aed0e-7343-442c-970e-e1e5c5a4ede4"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("957d85e9-6cea-4ba9-b671-6ff1d0faecee"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("96aba7e1-c060-491b-a648-67b8fed13557"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0afa84c8-ac3e-4b20-8ff2-a08e0f96f627"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("13f4af03-0d2b-4788-9a8d-f585fb5cfd13"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2c12c50b-6308-45df-becd-68952bb8177e"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("adb4ba05-85d5-4736-a24e-94b25bcf8904"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("04d717aa-6962-480f-b56d-1be4aba03d1c"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("67a25d02-1e6e-46fc-bb0a-c9e2f19819ab"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("90d54b35-e43d-4beb-b30a-9984c50c24f4"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f1fbddca-7799-4bcf-a075-426df81db125"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializePresentationTaskCreationParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("a81724cd-f82e-401e-bdc4-1f4968318e58"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dafab651-4b04-4a39-9ffa-a14a50789205"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ff84282e-f6d0-4910-a414-28117fa48082"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
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
				UId = new Guid("5ad22c54-905a-451d-b9fd-76ff73069b58"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5cd8ef8c-6a8f-48a6-8cbb-13e448e5e606"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,90,93,111,27,199,21,253,43,4,157,135,22,208,16,243,253,161,183,192,73,81,1,118,235,58,110,94,44,63,220,153,185,215,33,66,145,2,185,76,225,10,250,239,61,75,73,181,172,180,180,154,68,133,21,138,15,75,104,119,239,204,112,238,57,115,238,135,46,166,95,13,31,206,121,122,60,125,195,235,53,109,86,50,204,158,175,214,60,123,181,94,53,222,108,102,47,86,141,22,243,127,82,93,240,43,90,211,25,15,188,254,158,22,91,222,188,152,111,134,163,201,167,102,211,163,233,87,63,237,158,78,143,223,94,76,79,6,62,251,251,73,199,232,150,66,107,218,137,210,186,120,229,157,68,85,57,107,165,99,75,193,137,97,93,53,140,219,106,177,61,91,190,228,129,94,209,240,195,244,248,98,186,27,13,3,248,222,68,147,51,42,73,79,202,247,74,138,180,246,138,189,113,213,96,12,239,204,244,242,104,186,105,63,240,25,237,38,253,104,220,188,47,61,59,171,200,183,166,124,213,70,213,210,131,202,100,108,243,150,138,228,50,26,95,191,255,209,240,116,250,124,181,236,219,54,76,206,215,188,225,229,64,195,124,181,60,157,142,47,247,249,230,124,65,31,190,255,95,108,206,63,217,194,219,86,23,167,87,158,56,157,30,159,254,55,95,92,127,127,183,251,137,159,122,227,174,35,78,167,71,167,211,239,86,219,117,27,71,116,227,31,55,27,179,155,65,95,127,224,143,159,93,110,62,87,99,236,204,94,210,146,222,243,250,47,152,113,103,190,123,244,13,13,180,155,252,13,214,125,51,112,104,228,130,24,173,200,96,151,125,139,73,81,137,164,92,118,157,34,9,53,105,59,235,215,44,188,230,101,227,95,184,176,221,204,31,23,115,131,25,220,89,110,23,139,221,4,155,221,239,31,65,120,189,240,235,39,223,220,242,220,173,17,86,125,46,115,238,39,203,95,178,162,203,233,229,229,209,109,196,155,228,200,250,66,202,107,131,75,47,77,21,109,162,10,148,83,44,177,83,202,159,65,124,204,190,123,224,220,215,88,49,0,70,41,78,170,74,154,155,37,225,30,146,252,246,136,127,251,236,237,201,230,175,255,88,242,250,106,23,142,133,22,27,126,55,195,221,59,55,190,93,240,25,208,125,124,225,125,144,152,217,170,218,181,83,62,249,168,40,166,164,156,77,181,114,74,86,98,187,132,193,191,17,123,124,209,99,115,212,115,81,201,149,145,205,29,38,214,22,37,193,178,80,117,221,187,122,249,238,217,187,125,60,123,251,236,235,222,39,171,243,243,213,122,216,46,231,195,135,217,107,110,171,117,159,156,244,43,195,223,63,217,170,45,65,39,35,42,49,21,229,57,90,149,119,56,49,165,138,75,206,138,216,125,100,35,246,81,106,78,170,105,11,148,16,103,69,29,103,44,21,235,90,239,165,248,38,143,130,108,210,172,214,166,177,226,146,2,240,148,28,224,78,89,105,103,50,24,192,133,107,218,75,182,224,139,105,14,250,196,197,2,144,13,182,20,82,81,221,103,163,153,130,111,33,62,4,217,94,172,86,63,110,207,103,41,84,223,93,169,42,132,62,142,0,62,192,145,90,57,193,9,18,114,47,144,201,153,84,214,212,240,28,71,168,86,93,12,166,209,122,148,84,211,163,230,226,114,139,159,163,204,245,124,95,183,97,254,19,40,51,25,89,48,123,67,155,31,159,40,115,63,202,220,199,83,143,130,50,88,104,52,58,119,21,157,133,198,100,238,170,84,47,8,203,92,240,169,24,151,186,217,75,153,150,141,23,74,70,177,54,208,39,103,131,162,134,241,114,247,100,139,227,110,92,126,64,202,148,104,216,234,12,225,48,118,148,71,208,182,234,2,242,235,106,56,122,40,76,211,51,111,91,242,205,23,21,50,199,43,202,148,132,213,254,26,202,60,167,129,223,175,214,31,102,47,153,135,249,242,253,19,115,238,199,156,251,56,236,81,48,71,91,31,178,111,117,4,43,84,183,65,53,139,144,198,79,202,213,100,143,3,194,239,103,14,54,170,115,11,70,229,28,0,126,155,73,1,158,184,232,166,155,241,213,120,231,127,123,230,12,107,124,237,65,250,205,243,223,127,216,84,116,141,161,10,194,3,17,108,161,241,240,68,130,216,91,15,124,166,68,82,116,58,136,28,37,216,14,204,178,81,145,58,43,156,230,208,128,6,64,185,108,217,102,219,144,165,200,94,36,143,152,163,224,178,138,166,34,219,195,190,129,10,29,33,137,41,177,152,136,56,190,247,47,34,71,17,6,59,51,131,164,113,164,92,70,90,85,76,109,8,247,58,119,80,214,181,160,239,230,40,160,177,147,78,10,167,22,78,169,108,154,202,22,250,86,17,103,39,29,77,50,86,70,147,111,151,3,100,225,249,110,143,142,47,88,26,148,112,151,250,58,200,106,128,19,178,144,87,166,39,221,98,21,27,165,124,62,179,121,205,212,39,139,241,210,1,224,217,159,230,235,205,48,153,195,111,147,149,76,80,85,216,46,70,229,153,192,49,11,134,46,173,150,55,98,52,190,207,19,90,246,201,48,63,227,67,145,166,110,13,66,124,241,200,99,34,170,75,218,32,23,181,80,26,33,67,25,142,234,228,253,65,16,90,23,224,152,81,32,51,0,60,148,5,5,50,36,13,14,133,131,84,109,234,204,72,175,247,23,29,52,66,34,70,70,105,66,181,32,139,67,33,167,214,168,116,75,14,39,99,245,173,212,39,66,255,39,66,207,80,141,248,51,124,191,249,131,249,227,255,137,220,119,167,124,34,250,193,16,61,235,220,16,69,22,148,205,80,110,27,83,79,149,171,182,202,117,147,10,217,158,240,108,127,12,170,147,139,66,78,165,210,33,86,41,130,232,28,139,42,17,145,105,44,197,161,32,242,69,16,61,161,42,83,185,25,213,131,236,210,204,162,170,32,153,171,209,17,59,93,52,135,122,87,185,5,59,48,190,40,168,148,40,200,56,228,64,66,71,49,135,74,237,84,80,137,230,159,43,55,202,173,33,56,66,189,58,148,142,163,79,208,97,16,95,49,72,138,92,132,93,44,254,158,202,125,171,40,121,111,142,239,118,229,80,4,251,215,22,46,77,68,153,34,142,25,148,160,238,236,77,40,176,239,128,112,214,136,57,35,122,13,221,61,10,30,91,231,154,109,26,253,17,34,160,59,85,143,34,74,35,232,109,69,32,89,141,110,121,191,96,87,33,42,45,137,106,46,102,96,29,103,64,118,187,246,75,138,81,11,137,241,249,176,34,112,234,200,67,122,64,118,23,252,216,120,201,65,149,241,144,68,170,227,99,228,234,74,118,15,17,129,255,109,139,70,233,8,141,9,109,112,31,125,191,54,60,241,249,208,248,92,91,141,30,34,130,74,130,128,81,156,84,30,179,98,237,28,8,25,172,109,173,238,229,115,135,214,120,131,243,208,163,12,139,157,64,18,89,91,70,159,219,152,220,37,112,70,135,236,192,248,204,154,61,218,202,10,117,92,88,9,182,148,28,20,218,81,77,54,101,54,48,124,8,62,63,181,17,239,171,198,222,16,128,197,232,230,6,13,17,227,138,210,104,163,166,68,208,40,137,62,123,195,237,81,176,23,237,180,18,136,81,137,117,104,0,122,107,198,158,8,58,60,165,35,255,69,223,94,184,132,253,81,117,213,61,10,2,106,147,8,81,53,33,255,38,19,208,24,65,15,223,59,212,211,244,161,169,49,194,112,100,39,40,70,136,24,252,115,64,22,168,241,24,139,251,64,9,241,118,70,111,53,60,184,26,35,164,90,109,151,79,106,108,238,199,103,27,122,106,6,241,168,233,35,66,198,106,102,29,3,75,109,113,20,195,111,22,34,245,165,242,249,221,229,191,0,79,24,246,2,211,38,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3b349266-cabe-4ac9-9bab-90e5a99b9312"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
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

		protected virtual void InitializeReadOppoortunityData2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e113eec9-67b0-4d53-8bd1-162890643787"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,172,44,52,19,38,97,103,42,130,185,54,117,102,129,178,186,6,42,148,204,105,201,184,160,220,0,178,90,151,92,88,65,146,14,90,172,200,138,222,26,231,73,226,60,182,83,117,55,255,33,245,99,192,228,193,158,15,223,244,1,91,248,190,52,0,20,210,214,101,65,117,154,105,42,0,75,10,134,51,10,42,227,218,24,165,132,182,100,213,34,139,210,160,205,82,106,133,42,168,176,82,82,197,153,162,170,72,115,89,34,22,41,211,36,105,208,250,237,243,48,226,52,185,190,171,102,124,221,223,30,135,168,114,237,189,233,155,208,118,36,105,209,195,13,248,195,34,36,69,145,107,160,90,168,60,178,99,65,129,43,67,57,212,69,86,148,200,36,43,72,162,97,240,11,45,217,25,146,24,240,240,3,154,128,103,230,217,69,141,25,79,89,153,203,136,101,60,218,225,81,109,41,163,59,107,164,85,200,165,82,181,185,228,245,37,184,184,119,211,117,104,113,116,250,37,118,140,249,245,99,53,235,190,243,99,223,44,212,215,231,231,183,248,236,215,112,95,174,126,174,134,124,172,47,32,114,74,194,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,72,50,186,199,195,95,211,218,132,201,247,237,59,178,154,68,155,145,35,14,217,89,238,50,131,198,77,67,3,199,243,185,34,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,189,32,111,8,42,114,79,192,198,233,2,133,52,69,198,168,200,36,82,40,139,148,102,218,90,206,77,154,218,82,220,147,40,234,255,91,221,237,166,175,191,186,203,15,89,61,237,63,197,234,155,194,205,5,89,205,255,162,238,180,95,244,237,79,113,253,6,219,198,33,213,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("da79942f-8a30-4c0f-855d-60c2d9a24472"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("314efddf-5361-477a-9ff8-a9cb5fab8b62"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("06b753c1-0d8b-436b-8acc-ddf113106da6"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad17e1dd-e357-4be2-be8e-37597e384cc1"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cb37f59-15e3-4146-8d7f-c8726fcb37d4"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6f41753d-91d4-4093-8fba-b44d89023e4c"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("dfa2d329-fcfc-4412-bf5d-d4a9bda93dae"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("820e9918-37b0-4611-aaf2-8d870ec7da7d"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("cb9c1fe1-8c58-4f12-89f1-7aae2156df27"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("813a52d4-0e07-46b4-a63f-229d35aa56c6"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a3dabfcb-04f6-4cea-92b9-d9ea7aee59b1"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fcd7d381-1523-402c-b1b8-ed682284f793"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e2a2ccd2-d26f-4f42-ae98-edf3516e1ea8"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b5926df2-7c95-4492-a867-2d430924a35b"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("701045a2-ff5b-4e90-ae4f-035211803404"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5402bebd-14b9-42b0-8196-579eb5bbe71e"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("96db62c1-ce73-496e-a661-3117af6166c1"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("510b4f7b-0b11-445f-839e-ab79347decea"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6fbea50a-fcc9-45a8-9318-18aaea6960f4"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,75,107,220,48,16,254,43,139,14,61,89,139,100,203,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,177,177,101,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,51,223,99,198,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,164,186,200,211,20,168,202,4,163,34,70,84,131,146,84,105,147,217,84,48,131,182,32,73,11,13,150,100,169,222,90,31,72,226,3,54,67,121,61,253,105,26,250,17,147,91,119,10,190,153,123,108,224,251,12,192,157,148,60,79,145,10,206,20,21,218,42,170,117,158,81,169,153,200,29,147,214,41,69,22,46,182,226,178,208,204,82,83,104,65,5,200,130,66,6,154,170,74,74,229,128,177,212,197,167,53,186,176,125,58,244,56,12,190,107,203,9,127,159,175,158,15,145,229,130,189,233,234,177,105,73,210,96,128,75,8,247,37,73,141,168,176,18,57,181,58,215,84,100,140,209,170,170,144,58,20,70,59,168,164,227,106,13,200,80,228,6,168,17,58,167,194,225,76,65,91,154,65,85,164,133,66,46,121,180,195,192,33,204,216,228,51,130,93,239,44,73,44,4,248,1,245,136,39,14,147,143,106,210,140,113,149,207,26,120,102,34,94,202,168,146,170,160,206,74,167,49,147,90,87,246,236,236,167,209,199,179,31,46,198,6,123,111,94,6,132,209,233,174,47,39,211,181,161,239,234,185,245,197,233,249,21,62,133,101,12,47,87,63,23,233,33,230,231,34,114,76,198,1,55,181,199,54,108,91,211,89,223,222,45,61,143,199,88,210,28,160,247,195,217,175,237,195,8,53,73,122,127,119,255,87,95,55,227,16,186,230,63,146,154,68,153,177,71,92,199,19,221,121,91,173,31,14,53,60,159,226,146,188,123,24,187,240,126,158,225,106,8,112,135,229,106,191,95,114,31,30,193,135,216,105,53,64,141,231,228,250,43,154,174,183,171,157,93,98,242,10,160,36,123,2,89,86,8,39,36,205,101,52,65,20,76,82,157,3,82,206,133,48,42,238,155,19,106,109,43,141,149,50,130,130,200,120,220,115,224,84,35,10,154,43,230,164,115,200,149,150,123,18,149,253,123,190,215,187,225,203,99,123,254,97,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,25,170,156,222,34,247,120,51,11,190,57,198,239,23,104,109,241,196,168,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("054c4df5-87b5-404f-85c8-f5bb3e7c2694"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85e3b80e-36f9-4932-88fd-521181901c0a"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("335d8956-0dcb-469d-90e9-ceef1f2c5ecf"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9f755be-cee7-464d-9e1b-b41958012cd7"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea0c6605-f519-48fc-a673-083c99411a6a"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("04c4106d-1c1b-4e36-adfa-2bde0c00cacb"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,177,50,180,50,212,241,76,177,50,176,50,0,0,230,77,107,227,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("ee89e1ce-8692-4233-94c8-45e2768973be"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a73fd6bc-7349-44c8-9897-4cbf76d42e92"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("83effc4d-ad92-4d9f-8f5d-a8a8a9476b51"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5877a9b3-2232-413f-bca4-841e0c74fcaf"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e49f79ee-5843-4cf5-8054-c5513d2f9295"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2bb22b1b-8777-4e67-bd6f-76818c3e0d4b"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("10b071ad-0944-459a-90cb-7bd9819ae222"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("35106250-8b54-4cad-8a40-45adb5f3cd75"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1ba2a29-f542-4078-94a5-6af41945ce12"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9077d7fd-aab0-4d45-9d7d-e410dd871d90"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e01f3c07-11ea-4ff6-869f-1fd82c661820"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2a64a7e9-eae5-4633-b37c-798ea1a52b36"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("07e87dc6-266d-4544-87cb-bfd58618dbfc"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
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
				Value = @"a5657e6b-342d-4104-8ab8-aab37ef29860",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e34ab8a-aae1-49fa-a036-0f0b0ae39983"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,43,139,14,61,89,139,101,75,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,99,99,203,36,193,236,127,175,188,206,182,144,67,201,165,135,130,15,154,145,231,189,121,111,70,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,10,231,164,202,37,213,5,230,148,179,52,163,26,10,75,193,113,33,152,200,140,192,130,36,45,52,88,146,165,122,107,125,32,137,15,216,12,229,245,244,7,52,244,35,38,183,238,20,124,51,247,216,192,247,153,128,57,41,35,14,206,216,138,114,109,21,213,90,228,84,234,148,11,151,74,235,148,34,75,47,66,229,105,94,160,162,153,208,150,114,99,20,173,138,74,82,22,99,100,21,51,92,75,146,212,232,194,246,233,208,227,48,248,174,45,39,252,125,190,122,62,196,46,23,238,77,87,143,77,75,146,6,3,92,66,184,47,73,102,120,133,21,23,212,106,161,41,207,211,148,86,85,133,212,33,55,218,65,37,29,83,107,192,20,185,48,64,35,151,160,220,97,65,33,143,205,228,80,21,89,161,144,73,22,237,48,112,8,51,55,249,140,96,215,59,75,18,11,1,126,64,61,226,169,135,201,71,53,89,158,50,37,100,4,96,185,137,124,89,74,149,84,5,117,86,58,141,185,212,186,178,103,103,63,141,62,158,253,112,49,54,216,123,243,50,32,140,78,119,125,57,153,174,13,125,87,207,208,23,167,223,175,240,41,44,99,120,185,250,185,72,15,49,63,23,145,99,50,14,184,169,61,182,97,219,154,206,250,246,110,193,60,30,99,73,115,128,222,15,103,191,182,15,35,212,36,233,253,221,253,95,125,221,140,67,232,154,255,72,106,18,101,70,140,184,142,167,118,231,109,181,126,56,212,240,124,138,75,242,238,97,236,194,251,121,134,171,33,192,29,150,171,253,126,201,125,120,4,31,34,210,106,128,26,207,201,245,87,52,93,111,87,59,187,196,228,21,65,73,246,4,242,188,224,142,75,42,100,52,129,23,105,124,88,2,144,50,198,185,81,113,223,28,87,107,91,105,172,148,225,20,120,206,40,7,96,84,35,114,42,84,234,164,115,200,148,150,123,18,149,253,251,126,175,119,195,151,199,246,252,96,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,153,170,156,222,34,247,120,51,11,190,57,198,239,23,225,253,223,116,168,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4c062c1-d149-4854-b95d-7d3101c49ba8"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
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
				UId = new Guid("9b1e2c37-1ca0-4018-820c-534743d29771"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1f66152e-4108-49d8-9953-69045f06df88",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f57e619-c84a-40cd-a0f1-b5c0fad5c3c5"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,197,84,77,111,219,48,12,253,43,133,218,99,24,200,146,44,89,185,110,59,4,104,187,98,237,122,73,114,160,36,106,13,224,216,129,237,172,232,130,252,247,201,78,186,126,96,235,176,162,232,124,176,97,137,239,145,122,228,211,150,157,116,119,107,98,19,118,69,77,131,109,29,187,241,135,186,161,241,69,83,123,106,219,241,105,237,177,92,254,64,87,210,5,54,184,162,142,154,107,44,55,212,158,46,219,110,116,244,20,198,70,236,228,251,176,203,38,179,45,155,118,180,250,58,13,137,93,88,153,11,151,21,64,81,90,80,138,75,64,97,17,114,87,80,230,77,97,50,199,19,216,215,229,102,85,157,81,135,23,216,221,176,201,150,13,108,137,64,102,209,21,82,121,224,65,107,80,194,8,64,206,5,88,17,13,145,181,193,123,197,118,35,214,250,27,90,225,144,244,1,140,185,206,13,105,7,82,137,0,42,227,10,10,116,5,32,58,105,40,10,91,104,222,131,15,241,15,64,35,45,143,210,91,224,20,83,217,49,152,148,149,36,112,71,54,88,18,58,242,108,140,196,73,229,30,193,43,155,167,32,74,65,210,6,144,232,140,48,233,124,58,51,61,123,88,182,235,18,239,174,159,39,73,82,135,141,239,198,169,230,20,181,126,162,242,227,184,237,124,223,172,57,155,204,255,212,174,195,247,114,80,225,105,195,158,247,106,206,70,115,118,89,111,26,223,51,234,254,231,94,187,33,3,63,60,240,155,215,253,179,231,24,96,103,88,225,55,106,206,83,198,1,62,108,125,196,14,135,228,87,169,238,127,38,254,66,145,26,170,60,189,178,176,33,243,67,49,247,99,53,172,188,89,103,15,149,182,131,144,253,192,31,20,168,54,101,217,43,240,168,233,143,74,169,195,50,46,41,76,171,215,28,109,199,118,187,209,19,119,113,46,109,102,51,80,133,79,175,32,17,208,197,28,156,243,185,21,185,113,17,241,69,119,161,205,81,145,42,192,20,61,139,180,10,28,57,15,86,97,46,130,240,133,12,238,237,221,53,59,158,77,219,207,183,21,53,123,21,38,17,203,150,22,227,180,250,108,225,83,73,43,170,186,201,86,169,60,234,130,4,184,144,174,16,101,148,6,212,198,128,20,198,57,50,70,68,237,119,9,240,107,244,39,219,160,189,196,80,88,72,45,55,73,156,144,32,66,88,136,185,160,152,74,12,74,186,221,226,120,241,146,69,103,199,231,116,123,84,175,215,117,211,109,170,101,119,55,238,255,27,242,117,19,142,166,97,15,254,79,206,149,239,231,92,39,108,206,77,22,193,16,38,211,144,22,80,132,12,33,205,158,139,210,72,17,163,120,201,185,72,74,167,107,220,128,231,194,131,66,74,67,18,100,6,104,133,244,33,88,171,124,252,139,115,15,182,122,127,195,45,118,63,1,255,251,130,98,44,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("916d8dad-7673-427b-a065-b9d623107663"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
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

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("06208806-e8cf-4d1b-b140-1bb619b9ed9d"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,219,146,44,201,61,46,91,8,148,52,208,15,10,97,9,35,105,148,152,250,43,182,76,27,140,255,123,181,246,58,13,57,148,210,91,65,7,141,164,247,230,205,155,209,124,87,141,239,171,58,224,80,122,168,71,76,166,43,87,18,7,90,235,2,29,53,153,204,41,183,80,80,37,192,82,180,142,155,34,119,232,50,70,146,22,26,44,201,134,62,186,42,144,164,10,216,140,229,237,252,155,52,12,19,38,119,126,13,62,217,7,108,224,203,57,1,32,47,188,81,146,218,52,183,148,3,42,10,142,101,20,116,206,172,115,90,115,235,201,166,69,184,130,9,46,83,42,209,196,167,185,241,20,148,20,20,60,58,157,162,50,210,228,36,169,209,135,227,207,126,192,113,172,186,182,156,241,121,255,249,169,143,42,183,220,135,174,158,154,150,36,13,6,184,129,240,80,146,130,67,42,140,7,202,68,234,40,119,145,221,120,167,168,55,66,106,144,220,51,141,36,177,208,135,51,45,57,116,109,0,27,43,29,208,227,128,173,197,23,69,101,133,65,86,136,140,42,143,209,181,76,104,170,156,75,163,220,148,57,94,40,230,92,116,205,65,128,175,80,79,184,10,155,171,8,52,185,22,169,204,124,44,17,52,229,88,228,17,152,1,213,153,54,158,73,150,123,159,239,118,127,232,186,239,83,31,173,30,175,167,6,135,202,94,250,134,177,1,221,80,206,54,42,28,186,250,76,126,253,2,176,245,231,114,249,109,243,164,94,111,206,64,178,36,211,136,135,186,194,54,28,91,219,185,170,189,95,91,183,44,17,211,244,48,84,227,238,228,241,113,130,58,26,80,221,63,252,209,241,195,52,134,174,249,223,234,77,98,173,145,38,78,235,170,249,60,204,174,26,251,26,158,214,184,36,111,30,167,46,188,187,204,193,22,144,87,160,253,145,41,4,227,34,23,148,41,174,40,231,121,74,149,102,41,69,105,172,213,10,50,41,138,11,195,146,252,123,154,219,171,241,227,143,118,255,94,155,61,167,183,241,244,213,193,205,142,46,231,191,81,182,156,118,109,167,37,174,95,30,241,119,1,41,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c7f8a702-1219-42b2-bf9d-1f55c8264391"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3792585d-cd7c-494c-b316-b160fa45ae28"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("faa46a7f-a96c-46cf-9a47-add578864b68"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("68383c19-2658-416e-958d-1489861993aa"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("80cefc71-5fc6-4296-b100-29c98156e0b1"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("35445f62-ccc0-4a74-94f0-9ec9ea65b343"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("6cba6276-dc6c-4940-803b-a32b756d2ebd"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d7147db-0aaa-41c5-8897-3ad2d88fd821"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("00aae8e4-4e62-4538-9bf7-d0b6178f7c93"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e696780e-c260-4f1d-ac47-1890fdb6b840"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("da459109-1578-45d4-9510-627e44859262"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("05f93e88-b9f0-488c-b37f-c86bd5b8d920"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1ddf79d1-87fa-413b-b322-71e34392312d"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2f6fab91-5a02-44f1-9ea1-7012b00b2849"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d5f43f08-08d2-4c1d-aae8-d8cddf1e99e0"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b65917ae-2434-428b-b40e-92d5141b5034"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8a7896a5-a21a-40f3-93d9-7b5832d40f00"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("54b74755-6963-49d4-825e-8f08240a8812"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeAddDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("f5c84e26-162f-4de1-8294-6e4af7634cec"),
				ContainerUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
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
				Value = @"7abdac5b-742d-4453-a07c-11e73658156e",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("652608f8-95d7-4a3b-b783-014cd09293a0"),
				ContainerUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,43,139,14,61,89,139,108,201,250,112,79,101,217,150,133,146,134,54,45,133,108,8,99,105,156,8,252,177,177,101,146,96,246,191,87,94,103,91,200,161,228,84,40,248,160,25,105,222,188,247,102,60,221,250,225,163,175,3,246,69,5,245,128,201,184,115,5,17,41,114,11,198,80,229,148,161,66,101,146,150,178,50,84,151,170,204,181,52,82,229,156,36,45,52,88,144,165,122,235,124,32,137,15,216,12,197,245,244,7,52,244,35,38,183,213,41,248,102,239,177,129,239,115,3,229,56,175,152,205,40,51,86,83,145,107,71,181,67,65,89,105,117,198,171,76,103,146,145,133,139,181,25,166,44,222,105,38,211,248,84,228,212,24,40,105,134,192,28,230,57,84,202,145,164,198,42,108,159,14,61,14,131,239,218,98,194,223,231,171,231,67,100,185,244,222,116,245,216,180,36,105,48,192,37,132,251,130,112,149,89,131,22,41,19,46,162,67,110,41,8,203,163,230,200,142,41,107,24,99,107,192,216,63,183,64,173,48,57,21,21,42,10,220,56,202,161,84,153,210,152,202,84,145,196,194,33,204,189,201,103,4,183,222,69,82,14,2,252,128,122,196,19,135,201,71,53,25,103,169,206,101,4,72,185,165,130,103,140,106,169,21,173,92,244,23,185,52,166,116,103,103,63,141,62,158,253,112,49,54,216,123,251,50,32,140,78,119,125,49,217,174,13,125,87,207,208,23,167,231,87,248,20,150,49,188,92,253,92,164,135,152,159,139,200,49,25,7,220,212,30,219,176,109,109,231,124,123,183,96,30,143,177,164,57,64,239,135,179,95,219,135,17,106,146,244,254,238,254,175,190,110,198,33,116,205,127,36,53,137,50,35,70,92,199,19,221,121,91,157,31,14,53,60,159,226,130,188,123,24,187,240,126,158,225,202,183,171,253,126,137,63,60,130,15,17,101,53,64,141,231,228,106,8,112,135,235,175,104,187,222,173,118,110,201,146,87,45,10,178,39,192,185,18,149,144,52,151,209,134,184,92,146,154,28,144,166,169,16,86,151,101,89,9,189,118,165,193,82,91,17,55,144,207,187,8,41,53,24,23,63,215,172,146,85,133,169,54,114,79,162,182,127,193,248,122,55,124,121,108,207,63,237,98,222,205,58,102,95,37,182,53,54,209,229,98,122,139,196,99,44,184,60,183,42,166,183,8,62,222,204,146,111,142,241,251,5,90,191,223,1,172,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3468e686-0a3c-4fda-bec3-184be133f6d3"),
				ContainerUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
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
				UId = new Guid("ae322fe7-b3af-4bfb-827b-b2d801f86f9f"),
				ContainerUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"7d33f0c2-09c8-458d-8de4-0bc823f28260",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d50b648a-e5ed-4bd4-93f1-b84931e30d54"),
				ContainerUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,152,75,111,27,55,16,128,255,138,176,206,161,5,60,6,151,111,234,216,180,7,3,73,106,52,143,139,237,195,144,28,54,2,86,90,97,181,174,225,10,250,239,29,173,228,196,54,26,89,9,92,213,7,239,65,194,114,57,15,114,248,113,200,89,86,175,250,155,57,85,227,234,3,117,29,46,218,210,159,188,110,59,58,57,235,218,68,139,197,201,155,54,97,51,249,27,99,67,103,216,225,148,122,234,62,97,115,69,139,55,147,69,127,60,186,47,86,29,87,175,254,26,190,86,227,243,101,117,218,211,244,227,105,102,237,73,149,40,36,106,16,89,9,208,130,16,208,21,2,41,138,213,210,57,175,76,98,225,212,54,87,211,217,91,234,241,12,251,207,213,120,89,13,218,88,129,207,202,170,32,106,32,163,44,104,18,18,188,164,2,46,200,26,179,194,44,107,83,173,142,171,69,250,76,83,28,140,126,21,118,24,51,38,19,193,105,153,65,107,163,0,133,75,80,215,228,148,53,190,54,150,214,194,219,254,223,111,53,79,22,243,6,111,62,61,148,223,52,112,135,249,189,185,187,219,101,121,177,9,193,69,53,190,248,86,16,182,255,239,135,177,221,15,195,195,8,92,84,199,23,213,251,246,170,75,107,141,118,253,114,59,35,131,5,177,125,224,95,126,110,159,141,142,65,236,45,206,240,79,234,222,177,197,65,124,248,244,43,246,56,24,255,192,126,127,183,226,63,168,80,71,179,68,63,232,216,96,249,171,51,183,139,101,104,217,39,94,91,39,22,195,28,173,87,232,118,112,179,171,166,89,15,238,78,40,239,88,105,243,164,76,40,159,206,126,196,235,85,181,90,29,223,197,65,72,161,140,17,9,74,109,60,104,103,44,120,107,16,162,75,74,43,109,115,109,197,78,28,200,215,68,20,16,234,104,89,129,170,61,4,12,133,121,202,152,179,118,201,75,245,244,56,236,107,117,39,14,163,159,114,215,206,33,183,215,179,81,195,123,200,207,47,124,28,140,143,125,2,248,28,248,208,137,178,17,210,64,89,195,172,41,105,8,222,177,216,154,26,12,10,85,189,155,143,90,7,137,84,2,24,99,29,176,58,9,81,9,15,38,186,204,11,28,41,70,247,244,124,236,107,245,49,62,40,77,166,216,188,128,113,56,48,246,137,220,115,0,195,160,69,180,162,0,121,175,24,12,173,193,39,25,33,197,82,146,40,74,101,103,118,130,161,121,1,115,122,81,96,2,243,164,69,225,131,152,77,9,98,200,74,199,122,157,63,237,211,131,177,175,213,71,192,248,165,109,27,194,217,11,24,135,3,99,159,200,61,7,48,82,8,197,37,237,33,233,108,64,23,74,128,94,41,136,198,89,129,198,27,146,126,39,24,193,155,196,119,20,5,57,41,78,141,198,7,8,142,60,212,214,42,78,59,84,203,20,159,30,140,125,173,62,2,198,100,214,19,31,211,95,192,56,28,24,251,68,238,57,128,225,214,238,212,201,50,14,155,204,198,75,211,234,12,86,201,36,189,208,42,57,220,9,134,197,140,197,72,15,81,164,245,89,204,105,64,190,182,131,19,65,41,78,58,54,231,252,244,96,236,107,245,91,96,124,185,37,191,220,46,14,134,196,62,49,123,14,72,68,25,53,251,163,193,228,192,126,242,157,2,98,172,37,148,152,77,140,217,163,181,187,15,81,201,212,46,132,84,248,230,206,21,6,45,100,1,207,195,101,5,54,11,105,89,75,250,15,144,56,63,58,63,93,252,126,61,163,110,51,11,227,130,205,130,46,79,184,245,65,195,111,13,77,105,214,143,151,172,189,88,191,62,204,102,222,169,180,211,188,13,88,231,64,73,23,35,57,39,139,77,43,22,248,66,203,120,153,109,226,58,9,239,102,78,5,222,47,114,102,17,41,3,112,96,169,96,84,89,171,184,186,60,186,220,5,223,249,209,59,186,30,181,243,121,219,245,87,179,73,127,115,242,186,35,236,41,143,58,74,109,151,71,167,121,163,224,127,42,139,169,195,149,197,162,12,70,184,154,33,32,12,204,132,229,138,84,174,17,66,29,98,81,78,201,82,228,46,48,145,180,45,209,59,72,66,38,208,200,25,134,11,89,53,96,144,42,229,28,130,78,229,17,48,183,104,29,30,186,203,213,63,69,80,222,105,95,22,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b7e9251-c513-4107-842c-db639bf6112b"),
				ContainerUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
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
			ProcessSchemaLaneSet schemaOpportunityMangement = CreateOpportunityMangementLaneSet();
			LaneSets.Add(schemaOpportunityMangement);
			ProcessSchemaLane schemaOpportunityMangementProcess = CreateOpportunityMangementProcessLane();
			schemaOpportunityMangement.Lanes.Add(schemaOpportunityMangementProcess);
			ProcessSchemaSubProcess prospecting = CreateProspectingSubProcess();
			FlowElements.Add(prospecting);
			ProcessSchemaSubProcess needsanalysis = CreateNeedsAnalysisSubProcess();
			FlowElements.Add(needsanalysis);
			ProcessSchemaSubProcess oppmanagementvaluepproposition = CreateOppManagementValuePpropositionSubProcess();
			FlowElements.Add(oppmanagementvaluepproposition);
			ProcessSchemaSubProcess iddecisionmakers = CreateIdDecisionMakersSubProcess();
			FlowElements.Add(iddecisionmakers);
			ProcessSchemaSubProcess oppmanagementperceptionanalysis = CreateOppManagementPerceptionAnalysisSubProcess();
			FlowElements.Add(oppmanagementperceptionanalysis);
			ProcessSchemaSubProcess oppmanagementproposal = CreateOppManagementProposalSubProcess();
			FlowElements.Add(oppmanagementproposal);
			ProcessSchemaSubProcess oppmanagementnegotiations = CreateOppManagementNegotiationsSubProcess();
			FlowElements.Add(oppmanagementnegotiations);
			ProcessSchemaSubProcess oppmanagementcontractation = CreateOppManagementContractationSubProcess();
			FlowElements.Add(oppmanagementcontractation);
			ProcessSchemaSubProcess oppmanagementendstage = CreateOppManagementEndStageSubProcess();
			FlowElements.Add(oppmanagementendstage);
			ProcessSchemaUserTask readoppdata = CreateReadOppDataUserTask();
			FlowElements.Add(readoppdata);
			ProcessSchemaExclusiveGateway opportunitystage = CreateOpportunityStageExclusiveGateway();
			FlowElements.Add(opportunitystage);
			ProcessSchemaTerminateEvent terminate3 = CreateTerminate3TerminateEvent();
			FlowElements.Add(terminate3);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask findpresentation = CreateFindPresentationUserTask();
			FlowElements.Add(findpresentation);
			ProcessSchemaFormulaTask savepresentationparameter2 = CreateSavePresentationParameter2FormulaTask();
			FlowElements.Add(savepresentationparameter2);
			ProcessSchemaUserTask linkopptoprocess = CreateLinkOppToProcessUserTask();
			FlowElements.Add(linkopptoprocess);
			ProcessSchemaUserTask readoppmaincontact = CreateReadOppMainContactUserTask();
			FlowElements.Add(readoppmaincontact);
			ProcessSchemaFormulaTask savemaincontactparameter = CreateSaveMainContactParameterFormulaTask();
			FlowElements.Add(savemaincontactparameter);
			ProcessSchemaStartSignalEvent startsignalleadstagechange = CreateStartSignalLeadStageChangeStartSignalEvent();
			FlowElements.Add(startsignalleadstagechange);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			ProcessSchemaStartEvent startoppbusinessprocess = CreateStartOppBusinessProcessStartEvent();
			FlowElements.Add(startoppbusinessprocess);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaExclusiveGateway exclusivegateway4 = CreateExclusiveGateway4ExclusiveGateway();
			FlowElements.Add(exclusivegateway4);
			ProcessSchemaTerminateEvent terminate4 = CreateTerminate4TerminateEvent();
			FlowElements.Add(terminate4);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaFormulaTask storeisstagechangedbyuser = CreateStoreIsStageChangedByUserFormulaTask();
			FlowElements.Add(storeisstagechangedbyuser);
			ProcessSchemaFormulaTask resetisstagechangedbyuser = CreateResetIsStageChangedByUserFormulaTask();
			FlowElements.Add(resetisstagechangedbyuser);
			ProcessSchemaUserTask readdatalead = CreateReadDataLeadUserTask();
			FlowElements.Add(readdatalead);
			ProcessSchemaUserTask changedatalead = CreateChangeDataLeadUserTask();
			FlowElements.Add(changedatalead);
			ProcessSchemaExclusiveGateway exclusivegatewaysetdatetimepresentation = CreateExclusiveGatewaySetDateTimePresentationExclusiveGateway();
			FlowElements.Add(exclusivegatewaysetdatetimepresentation);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask adddatacontacttoopportunity = CreateAddDataContactToOpportunityUserTask();
			FlowElements.Add(adddatacontacttoopportunity);
			ProcessSchemaExclusiveGateway exclusivegatewayleadqualifiedascontact = CreateExclusiveGatewayLeadQualifiedAsContactExclusiveGateway();
			FlowElements.Add(exclusivegatewayleadqualifiedascontact);
			ProcessSchemaUserTask adddataopportunity = CreateAddDataOpportunityUserTask();
			FlowElements.Add(adddataopportunity);
			ProcessSchemaUserTask readdatacountopportunitybyaccount = CreateReadDataCountOpportunityByAccountUserTask();
			FlowElements.Add(readdatacountopportunitybyaccount);
			ProcessSchemaUserTask readdataaccount = CreateReadDataAccountUserTask();
			FlowElements.Add(readdataaccount);
			ProcessSchemaFormulaTask formulataskaccountbylead = CreateFormulaTaskAccountByLeadFormulaTask();
			FlowElements.Add(formulataskaccountbylead);
			ProcessSchemaUserTask readdatacontact = CreateReadDataContactUserTask();
			FlowElements.Add(readdatacontact);
			ProcessSchemaExclusiveGateway exclusivegatewayqualifiedbyaccount = CreateExclusiveGatewayQualifiedByAccountExclusiveGateway();
			FlowElements.Add(exclusivegatewayqualifiedbyaccount);
			ProcessSchemaFormulaTask savecurroppparameter = CreateSaveCurrOppParameterFormulaTask();
			FlowElements.Add(savecurroppparameter);
			ProcessSchemaUserTask presentationtaskcreation = CreatePresentationTaskCreationUserTask();
			FlowElements.Add(presentationtaskcreation);
			ProcessSchemaFormulaTask savepresentationparameter = CreateSavePresentationParameterFormulaTask();
			FlowElements.Add(savepresentationparameter);
			ProcessSchemaUserTask readoppoortunitydata2 = CreateReadOppoortunityData2UserTask();
			FlowElements.Add(readoppoortunitydata2);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			ProcessSchemaFormulaTask formulatask5 = CreateFormulaTask5FormulaTask();
			FlowElements.Add(formulatask5);
			ProcessSchemaFormulaTask formulatask6 = CreateFormulaTask6FormulaTask();
			FlowElements.Add(formulatask6);
			ProcessSchemaFormulaTask formulatask7 = CreateFormulaTask7FormulaTask();
			FlowElements.Add(formulatask7);
			ProcessSchemaFormulaTask formulatask8 = CreateFormulaTask8FormulaTask();
			FlowElements.Add(formulatask8);
			ProcessSchemaFormulaTask formulatask9 = CreateFormulaTask9FormulaTask();
			FlowElements.Add(formulatask9);
			ProcessSchemaUserTask adddatausertask2 = CreateAddDataUserTask2UserTask();
			FlowElements.Add(adddatausertask2);
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateProspectingStageConditionalFlow());
			FlowElements.Add(CreateNeedAnalysisStageConditionalFlow());
			FlowElements.Add(CreateValuePropositionConditionalFlow());
			FlowElements.Add(CreateDecisionMakersConditionalFlow());
			FlowElements.Add(CreatePerceptionAnalysisStageConditionalFlow());
			FlowElements.Add(CreateNegotiationsStageConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateContractationStageConditionalFlow());
			FlowElements.Add(CreateProposalStageConditionalFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateConditionalFlow8ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow31SequenceFlow());
			FlowElements.Add(CreateSequenceFlow32SequenceFlow());
			FlowElements.Add(CreateSequenceFlow33SequenceFlow());
			FlowElements.Add(CreateConditionalFlow10ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow34SequenceFlow());
			FlowElements.Add(CreateSequenceFlow35SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow36SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow7ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow37SequenceFlow());
			FlowElements.Add(CreateConditionalFlow11ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow38SequenceFlow());
			FlowElements.Add(CreateSequenceFlow39SequenceFlow());
			FlowElements.Add(CreateConditionalFlow12ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow40SequenceFlow());
			FlowElements.Add(CreateSequenceFlow41SequenceFlow());
			FlowElements.Add(CreateSequenceFlow42SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow43SequenceFlow());
			FlowElements.Add(CreateSequenceFlow44SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateConditionalFlow5ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow46SequenceFlow());
			FlowElements.Add(CreateSequenceFlow47SequenceFlow());
			FlowElements.Add(CreateSequenceFlow50SequenceFlow());
			FlowElements.Add(CreateSequenceFlow49SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
			FlowElements.Add(CreateSequenceFlow45SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow48SequenceFlow());
			FlowElements.Add(CreateSequenceFlow51SequenceFlow());
			FlowElements.Add(CreateSequenceFlow52SequenceFlow());
			FlowElements.Add(CreateSequenceFlow53SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b7a4e901-cd6d-48d8-8ea3-b631737057d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateProspectingStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ProspectingStage",
				UId = new Guid("6da9cfcb-81e5-48a4-a1c1-42a6279225e6"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.c2067b11-0ee0-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(736, 133),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 47));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateNeedAnalysisStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "NeedAnalysisStage",
				UId = new Guid("9301d50a-6c5b-4489-badd-4a28230234ae"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.2a6de0f7-44d9-4b8a-bce6-acddb7ed8915#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(750, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 152));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateValuePropositionConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ValueProposition",
				UId = new Guid("bb42fb47-5fbd-4f77-af1e-ce351db4f8f9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.325f0619-0ee0-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(712, 283),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 243));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateDecisionMakersConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "DecisionMakers",
				UId = new Guid("f094c232-c29e-46d1-86fc-2e61dcac8e07"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.f4e4a00b-ec48-46d0-9ea0-c2b502165ee9#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(723, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 334));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreatePerceptionAnalysisStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "PerceptionAnalysisStage",
				UId = new Guid("90dc5cd4-a514-48c4-9705-1babb54dc9a9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.241ade6b-4256-4947-ba8a-7d96988a97b6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(690, 398),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 666));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateNegotiationsStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "NegotiationsStage",
				UId = new Guid("3b93fd4b-c4ce-43ef-81de-d70f18e28cd9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.f808c955-c5aa-4aba-95c0-ba7d584d2f32#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(693, 494),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 834));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a0baa7ff-239e-42e9-8768-1ee3435f5a90"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(346, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc1b7702-073c-45cc-926b-05e107a8fd30"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateContractationStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContractationStage",
				UId = new Guid("97b5d2a4-5ab3-4fb5-9544-7ee6933c7e5a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.fb563df2-5ae6-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(944, 656),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 639));
			schemaFlow.PolylinePointPositions.Add(new Point(1890, 639));
			schemaFlow.PolylinePointPositions.Add(new Point(1890, 918));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateProposalStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ProposalStage",
				UId = new Guid("94b519f4-4f88-4966-9c23-8a451496a11b"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.423774cb-5ae6-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1006, 566),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1969, 750));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow16",
				UId = new Guid("de2431a0-d30e-4cfc-b8cf-278b073a39f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1261, 438),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2012, 596));
			schemaFlow.PolylinePointPositions.Add(new Point(2012, 527));
			schemaFlow.PolylinePointPositions.Add(new Point(2515, 527));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("a681a1ef-7292-4df0-8fc4-8af2fec6edb9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1088, 494),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2248, 716));
			schemaFlow.PolylinePointPositions.Add(new Point(1345, 716));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("8d4357f8-f4f9-48b5-a570-41ea6d475b92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(919, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2284, 47));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("f96d1ad1-4a55-4afb-9ba8-e36591778f46"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(920, 333),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2284, 152));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("3d3dd689-8fb9-4955-b1ca-b7d2ce229b92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(936, 377),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("0eb60d05-9aec-4c62-be1d-1178bca849d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(936, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2107, 377));
			schemaFlow.PolylinePointPositions.Add(new Point(2284, 377));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("2b63dc8f-d13f-49c5-835d-3483f4523a44"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(936, 520),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2284, 666));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("0e1f6ffa-18a8-4413-a8ec-e72659aa72f9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(936, 572),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2284, 750));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("462272ae-0429-49e5-8618-a2a7fd3481fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(918, 611),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2284, 834));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("b535ac24-faf0-4bd6-ba78-19cfe825e870"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(917, 669),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2515, 918));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("b131dc29-103b-498c-8cad-b0267ae02df9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(330, 444),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow14",
				UId = new Guid("be43f005-b89c-4be1-b699-0acc87df40c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(320, 441),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("656a4a04-8b53-40cb-9fe2-d14c1a49db28"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{da7cbb80-cd50-40b3-883c-6f5384f2478a}].[Parameter:{6f8cde56-f764-4ad1-b528-0d9031cd1e8e}]#].Count == 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(386, 495),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("945c5224-09ec-408a-b369-ae94b490e7b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(218, 604),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("af05fdeb-fca0-41d3-9791-46dc1679ea6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(218, 716),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d530128e-0ad3-40af-b76a-b9da0f99dec8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(427, 311),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1304, 338));
			schemaFlow.PolylinePointPositions.Add(new Point(1304, 390));
			schemaFlow.PolylinePointPositions.Add(new Point(1141, 390));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("f2e28c79-53c0-420e-bc3b-2fe8df5cb57d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(380, 318),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1421, 268));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("3a915671-271f-4aca-8ecb-49e7c53c9b5f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(380, 318),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("44ae693f-6aa2-4a99-bdf0-2cde17ec3507"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(750, 303),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("a580eaa3-fc67-44f4-97b8-d4612d7fe5bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1134, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("de750837-99b2-4b33-b71b-deba1897a823"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("55a5a7b6-1fe9-43e6-8550-f6da9d2fcf2b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow27",
				UId = new Guid("788216e9-2036-4a1f-831c-141dbdcba7b5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(386, 151),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow8ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow8",
				UId = new Guid("12da4680-7947-44ac-bce4-174e2ea3d434"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(456, 66),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("e15bb4f0-0213-4d52-8387-1a542b5d4eb4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(759, 158),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow31SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow31",
				UId = new Guid("060a734c-031d-4892-97f8-7d1c8e825e30"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(896, 128),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow32SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow32",
				UId = new Guid("af864a06-1ac3-4766-bdb4-9064d35c26ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1041, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow33SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow33",
				UId = new Guid("3df63af1-a134-40e5-b6bf-b5a735392364"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1133, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow10ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow10",
				UId = new Guid("fe99e954-54c6-4dbc-ae4e-724f11084d1e"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1224, 186),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow34SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow34",
				UId = new Guid("9aa77dec-7ab7-4403-a78e-711f966d98a3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(915, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1760, 86));
			schemaFlow.PolylinePointPositions.Add(new Point(1679, 86));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow35SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow35",
				UId = new Guid("598e3e34-6da9-4dea-8c0d-5f7bcfca6637"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(946, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1937, 43));
			schemaFlow.PolylinePointPositions.Add(new Point(1937, 177));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow1",
				UId = new Guid("8add388c-07d2-4f83-bfa0-ac871ab00d61"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(218, 110),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow36SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow36",
				UId = new Guid("5ec251e3-686c-42c6-8f99-34b869d3217c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(946, 283),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("6f012dc4-0679-4da3-84ce-757680848a3c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#] != null && !DateTime.MinValue.Equals([#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#])",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(862, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow7ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow7",
				UId = new Guid("e1fae17b-971d-469e-82c9-0d8f1161f09b"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{7cfff438-9ee8-4272-816d-5deb7d0c9d36}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(342, 197),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow37SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow37",
				UId = new Guid("866016a6-730c-4f6d-8688-5ca07b0bba21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(750, 303),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow11ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow11",
				UId = new Guid("aff117cc-494a-447b-824c-ea45bf0c048a"),
				ConditionExpression = @"[#SysSettings.StartOppBusinessProcessFinance#] == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(304, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow38SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow38",
				UId = new Guid("d775251b-c99c-4962-8c31-63e5179999be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(298, 119),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(107, 176));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow39SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow39",
				UId = new Guid("2b69f135-398e-443a-a1a4-3237cbf24d5d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(768, 644),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow12ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow12",
				UId = new Guid("b3fa892c-1d0a-4e76-a01e-553b47b9714a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{b10332bd-27a4-46bc-a990-f59da9cdbb25}].[Parameter:{c5f0d6a4-d18b-446e-8335-18fb080f660a}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(834, 698),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("129d65ec-f59b-44af-b1d6-cda0a6b4ff21"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow40SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow40",
				UId = new Guid("7eab7b7b-6047-42c1-a1fb-6279a4cd3a64"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1149, 544),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow41SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow41",
				UId = new Guid("1c43080a-684a-4791-9f3b-a6ab1a023caa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(990, 644),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow42SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow42",
				UId = new Guid("a0e10bcc-d9cf-4167-8c98-8f859c88ba6a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(936, 377),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2284, 243));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("de731752-04c3-40a1-9853-07e0a87ba911"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(2100, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("2f225a00-7172-4df7-b6bb-f13891d00109"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("483624cb-e100-4417-b0d7-2d89990301bc"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{9d00770f-dda3-42a7-937d-59d67284f4c1}].[Parameter:{a73fd6bc-7349-44c8-9897-4cbf76d42e92}]#] == 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1183, 361),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow43SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow43",
				UId = new Guid("87a64e65-a497-4ebc-a9cf-14260e618e18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1286, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow44SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow44",
				UId = new Guid("a5997d52-51b6-48a5-a656-bd7d3854ca36"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1234, 350),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1305, 500));
			schemaFlow.PolylinePointPositions.Add(new Point(1176, 500));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow28",
				UId = new Guid("72ab06d6-4130-493c-b2af-5c38d597d2ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(447, 123),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow5ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow5",
				UId = new Guid("e9f42fb2-6bda-464a-8a5a-cfb4b9ca50b1"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]  != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(576, 108),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow46SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow46",
				UId = new Guid("59c61212-02fe-41a0-ad79-c40ccc35532c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(1041, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow47SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow47",
				UId = new Guid("17b0bf13-f217-45b1-afcc-b2adc6141887"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(991, 186),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow50SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow50",
				UId = new Guid("a302bf3e-58ff-4854-bc1b-7eaa9052bfe8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(896, 128),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow49SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow49",
				UId = new Guid("17087fe4-cdf9-44bf-87ae-069f098e6b9f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(906, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("7f2af97b-9700-4293-ab0f-ab54f86bdd6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(751, 186),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow45SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow45",
				UId = new Guid("153b7c7c-46d1-44e7-b271-f8fcdeacae3b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(644, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("c6c60e5b-a2e1-4af3-81b1-7c228375d5c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(66, 337));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow48SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow48",
				UId = new Guid("14dc3926-be2e-4381-aa61-5cf5889f09b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow51SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow51",
				UId = new Guid("d9b40787-f4db-4de9-a07f-63291d659ebb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1221, 176));
			schemaFlow.PolylinePointPositions.Add(new Point(1221, 47));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow52SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow52",
				UId = new Guid("29aaa936-4362-4814-a131-6dd7a498a947"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1221, 337));
			schemaFlow.PolylinePointPositions.Add(new Point(1221, 47));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow53SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow53",
				UId = new Guid("ad809ac2-6d6a-4bfe-9c65-b9044f2ec5d0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("60a1c5d5-b601-479f-92f1-be91ff7f23f7"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateOpportunityMangementLaneSet() {
			ProcessSchemaLaneSet schemaOpportunityMangement = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8ea1b510-d580-4bce-a7d9-506d9c032358"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OpportunityMangement",
				Position = new Point(5, 5),
				Size = new Size(2403, 961),
				UseBackgroundMode = false
			};
			return schemaOpportunityMangement;
		}

		protected virtual ProcessSchemaLane CreateOpportunityMangementProcessLane() {
			ProcessSchemaLane schemaOpportunityMangementProcess = new ProcessSchemaLane(this) {
				UId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8ea1b510-d580-4bce-a7d9-506d9c032358"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OpportunityMangementProcess",
				Position = new Point(29, 0),
				Size = new Size(2374, 961),
				UseBackgroundMode = false
			};
			return schemaOpportunityMangementProcess;
		}

		protected virtual ProcessSchemaUserTask CreateReadOppDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadOppData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1310, 569),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadOppDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateOpportunityStageExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OpportunityStage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1942, 569),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaSubProcess CreateProspectingSubProcess() {
			ProcessSchemaSubProcess schemaProspecting = new ProcessSchemaSubProcess(this) {
				UId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"Prospecting",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2072, 20),
				SchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeProspectingParameters(schemaProspecting);
			return schemaProspecting;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate3TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"Terminate3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2502, 583),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaSubProcess CreateNeedsAnalysisSubProcess() {
			ProcessSchemaSubProcess schemaNeedsAnalysis = new ProcessSchemaSubProcess(this) {
				UId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"NeedsAnalysis",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2072, 125),
				SchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeNeedsAnalysisParameters(schemaNeedsAnalysis);
			return schemaNeedsAnalysis;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementValuePpropositionSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementValuePproposition = new ProcessSchemaSubProcess(this) {
				UId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OppManagementValuePproposition",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2072, 216),
				SchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementValuePpropositionParameters(schemaOppManagementValuePproposition);
			return schemaOppManagementValuePproposition;
		}

		protected virtual ProcessSchemaSubProcess CreateIdDecisionMakersSubProcess() {
			ProcessSchemaSubProcess schemaIdDecisionMakers = new ProcessSchemaSubProcess(this) {
				UId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"IdDecisionMakers",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2072, 307),
				SchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeIdDecisionMakersParameters(schemaIdDecisionMakers);
			return schemaIdDecisionMakers;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementPerceptionAnalysisSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementPerceptionAnalysis = new ProcessSchemaSubProcess(this) {
				UId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OppManagementPerceptionAnalysis",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2075, 639),
				SchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementPerceptionAnalysisParameters(schemaOppManagementPerceptionAnalysis);
			return schemaOppManagementPerceptionAnalysis;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementProposalSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementProposal = new ProcessSchemaSubProcess(this) {
				UId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OppManagementProposal",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2075, 723),
				SchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementProposalParameters(schemaOppManagementProposal);
			return schemaOppManagementProposal;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementNegotiationsSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementNegotiations = new ProcessSchemaSubProcess(this) {
				UId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OppManagementNegotiations",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2075, 807),
				SchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementNegotiationsParameters(schemaOppManagementNegotiations);
			return schemaOppManagementNegotiations;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementContractationSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementContractation = new ProcessSchemaSubProcess(this) {
				UId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OppManagementContractation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2075, 891),
				SchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementContractationParameters(schemaOppManagementContractation);
			return schemaOppManagementContractation;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementEndStageSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementEndStage = new ProcessSchemaSubProcess(this) {
				UId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OppManagementEndStage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2383, 569),
				SchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementEndStageParameters(schemaOppManagementEndStage);
			return schemaOppManagementEndStage;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(638, 569),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateFindPresentationUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FindPresentation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(778, 569),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFindPresentationParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSavePresentationParameter2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"SavePresentationParameter2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(939, 653),
				ResultParameterMetaPath = @"0eae6fcc-65b6-433e-b4dc-e42323c488c1",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,177,10,131,48,16,128,225,135,113,190,146,152,196,156,174,197,161,83,11,29,197,225,46,185,208,130,166,160,150,82,196,119,175,174,221,126,126,248,186,162,187,204,215,79,150,233,30,30,50,82,147,104,152,165,63,237,247,111,180,131,140,146,151,102,141,228,3,51,42,8,209,41,176,138,13,32,154,0,85,114,6,109,42,173,71,218,118,112,163,137,70,89,100,106,86,14,209,160,209,30,8,177,4,123,20,34,106,224,82,51,38,21,200,121,62,72,155,151,231,242,61,191,134,247,152,155,149,68,137,117,129,32,216,218,129,77,178,123,83,71,48,196,190,244,40,186,210,126,235,139,254,7,38,198,222,228,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateLinkOppToProcessUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"LinkOppToProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1107, 569),
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeLinkOppToProcessParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadOppMainContactUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadOppMainContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1422, 569),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadOppMainContactParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSaveMainContactParameterFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"SaveMainContactParameter",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1534, 569),
				ResultParameterMetaPath = @"b8d6c762-b63e-49b7-b651-c8d29f9c8d74",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,145,61,75,3,81,16,69,255,202,66,26,45,70,246,125,191,89,8,22,18,196,74,193,50,164,152,55,111,6,3,217,85,146,13,18,66,254,187,47,109,236,44,109,47,28,230,158,59,119,207,199,109,125,88,141,95,243,169,91,46,187,245,98,253,114,120,253,158,100,255,206,31,50,210,160,180,59,200,230,161,165,55,193,106,39,163,76,243,112,238,57,153,204,182,135,108,163,7,79,53,3,113,80,176,194,46,146,69,242,152,47,13,120,163,61,141,50,203,126,56,71,83,163,250,96,192,231,138,224,25,35,160,73,5,52,114,96,201,161,106,118,87,100,53,205,219,249,244,244,185,59,142,83,163,60,245,161,40,129,11,125,5,95,139,66,209,118,77,75,72,72,201,171,67,185,108,22,155,251,238,241,47,30,28,69,201,9,1,171,231,230,33,9,114,239,20,56,132,204,198,99,37,235,111,60,146,152,34,182,85,64,35,173,17,18,66,177,24,26,103,92,84,235,107,31,236,111,15,138,54,87,71,4,9,99,155,0,189,131,156,99,129,198,132,182,76,229,182,199,213,163,27,254,197,59,126,0,19,38,209,124,98,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignalLeadStageChangeStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"StartSignalLeadStageChange",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(53, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("bc0c2d60-5a3d-4840-aa4e-c60ea776e206");
			InitializeStartSignalLeadStageChangeParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(80, 310),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartEvent CreateStartOppBusinessProcessStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("cc1b7702-073c-45cc-926b-05e107a8fd30"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"StartOppBusinessProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(313, 583),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"OpenEditPageUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(631, 772),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ExclusiveGateway4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(778, 772),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate4TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("129d65ec-f59b-44af-b1d6-cda0a6b4ff21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"Terminate4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(792, 877),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1107, 772),
				ResultParameterMetaPath = @"af8eea9e-0e11-426e-a870-2cff33d00f84",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,173,14,195,32,20,64,225,135,169,190,11,255,3,252,68,213,150,76,54,136,123,225,146,137,82,65,155,76,52,125,247,161,103,191,156,179,76,203,188,63,191,27,247,119,254,112,195,88,113,221,57,221,134,254,193,99,229,198,219,17,79,146,66,107,69,5,212,29,13,24,71,25,48,4,1,213,134,130,33,23,34,101,175,49,188,176,99,227,131,123,60,179,173,162,184,81,23,233,9,140,113,12,94,107,11,210,87,18,94,84,231,4,94,105,74,63,188,126,6,30,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2177, 216),
				ResultParameterMetaPath = @"0eae6fcc-65b6-433e-b4dc-e42323c488c1",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,115,47,205,76,209,115,205,45,40,169,4,0,200,160,7,199,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateStoreIsStageChangedByUserFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"StoreIsStageChangedByUser",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2250, 569),
				ResultParameterMetaPath = @"9786c0e4-cc5f-4c9f-b46d-090a297e2b74",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,148,49,111,27,49,12,133,255,74,128,204,44,40,145,162,40,239,29,58,181,64,71,195,3,41,81,232,144,100,112,2,116,72,242,223,75,143,118,167,214,26,169,187,227,199,247,30,239,248,120,252,246,250,253,247,75,156,127,206,95,241,108,135,109,79,175,113,250,146,213,155,194,215,167,120,142,151,183,195,59,46,15,107,195,160,35,21,96,219,12,54,92,97,13,89,97,101,82,147,249,153,47,252,176,179,61,199,91,156,15,239,225,117,24,99,133,182,172,1,239,225,160,204,19,162,143,205,81,118,41,205,62,79,143,167,135,143,143,135,227,191,19,77,33,109,181,20,32,47,8,204,221,64,23,49,4,109,18,108,147,251,160,27,34,49,69,26,213,97,118,237,192,93,21,172,81,133,61,173,82,71,39,101,188,16,253,31,144,88,235,68,134,16,194,41,81,235,3,92,214,4,108,123,173,130,182,36,214,13,144,87,236,216,76,192,212,39,176,224,2,37,29,96,121,134,55,245,40,114,135,68,171,169,121,49,3,177,233,73,68,3,134,87,133,185,172,34,121,231,249,23,81,8,86,245,22,128,88,23,176,207,14,62,83,85,181,189,87,163,190,17,231,61,68,166,181,246,217,160,101,159,140,81,77,141,148,21,202,246,18,226,173,243,197,129,43,162,154,166,110,15,133,218,57,135,152,18,160,186,20,58,97,223,141,116,238,136,59,136,130,92,6,103,176,177,55,6,198,221,193,72,70,18,201,88,22,233,75,189,213,168,14,204,33,100,129,249,78,141,246,170,105,244,206,73,154,47,195,186,243,182,222,65,84,125,21,138,204,195,66,15,96,213,128,177,246,206,110,185,129,158,13,198,202,207,95,17,81,62,63,98,32,72,73,235,184,100,196,85,124,231,66,140,45,83,149,138,233,29,68,58,215,37,22,2,49,51,76,188,219,204,132,214,6,82,131,55,123,143,168,25,211,43,162,34,90,218,202,8,9,181,92,53,15,134,81,37,127,3,18,195,198,8,28,228,23,162,63,190,203,223,63,139,4,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateResetIsStageChangedByUserFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ResetIsStageChangedByUser",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1660, 569),
				ResultParameterMetaPath = @"9786c0e4-cc5f-4c9f-b46d-090a297e2b74",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,75,75,204,41,78,5,0,48,104,205,43,5,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadDataLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(204, 310),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ChangeDataLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1505, 150),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewaySetDateTimePresentationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ExclusiveGatewaySetDateTimePresentation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1393, 150),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"Terminate2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(225, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataContactToOpportunityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"AddDataContactToOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1853, 20),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataContactToOpportunityParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayLeadQualifiedAsContactExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ExclusiveGatewayLeadQualifiedAsContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1733, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataOpportunityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"AddDataOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1260, 20),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataOpportunityParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataCountOpportunityByAccountUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadDataCountOpportunityByAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(862, 310),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataCountOpportunityByAccountParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataAccountUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadDataAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(617, 310),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataAccountParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTaskAccountByLeadFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTaskAccountByLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(498, 310),
				ResultParameterMetaPath = @"342aec56-8359-4c5b-826b-9e8489fd6a4b",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,177,10,194,48,16,0,208,143,113,62,73,210,187,54,201,42,29,156,20,28,75,135,107,114,65,161,169,208,86,68,74,255,221,184,186,62,120,221,161,59,47,151,247,36,243,45,220,37,179,79,60,46,210,31,139,254,65,59,74,150,105,245,91,18,140,214,138,2,172,41,0,218,129,193,233,33,128,184,40,17,105,168,2,169,189,132,43,207,156,101,149,217,111,17,81,87,41,50,136,81,84,138,14,96,141,141,48,160,212,141,170,117,163,77,250,149,118,90,31,235,231,244,28,95,121,242,91,101,28,58,22,132,148,116,85,86,34,112,137,34,32,113,131,68,86,152,104,239,15,253,23,82,182,133,99,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataContactUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadDataContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(617, 149),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataContactParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayQualifiedByAccountExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ExclusiveGatewayQualifiedByAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(372, 310),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateSaveCurrOppParameterFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"SaveCurrOppParameter",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1386, 311),
				ResultParameterMetaPath = @"af8eea9e-0e11-426e-a870-2cff33d00f84",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,177,10,195,32,16,0,208,143,201,124,165,156,198,139,238,29,58,165,208,49,56,156,222,73,135,152,193,4,58,132,252,123,157,187,62,120,203,176,60,247,249,187,105,123,231,143,86,14,133,215,93,227,173,235,31,60,86,173,186,29,225,180,118,44,110,82,132,36,119,3,150,172,3,118,68,96,144,82,82,34,44,46,95,61,188,184,113,213,67,91,56,197,101,195,50,121,32,227,9,172,72,47,136,30,202,136,90,56,25,177,38,93,113,136,63,181,94,204,26,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreatePresentationTaskCreationUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"PresentationTaskCreation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1260, 150),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializePresentationTaskCreationParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSavePresentationParameterFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"SavePresentationParameter",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1260, 241),
				ResultParameterMetaPath = @"0eae6fcc-65b6-433e-b4dc-e42323c488c1",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,173,14,194,48,20,6,208,135,153,190,164,244,111,185,245,8,20,36,200,165,226,222,242,53,136,117,162,91,130,88,246,238,76,99,79,114,166,97,186,175,143,239,130,254,42,31,52,73,85,230,21,249,114,234,31,220,102,52,44,91,218,125,168,170,163,97,82,120,38,207,65,72,48,26,170,5,142,237,187,132,104,202,113,134,167,116,105,216,208,211,238,212,121,182,49,82,17,5,121,41,76,172,162,196,6,65,152,149,221,213,30,121,200,63,255,140,172,32,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadOppoortunityData2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadOppoortunityData2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1645, 150),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadOppoortunityData2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1107, 430),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"AddDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1271, 430),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(372, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"ReadDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(862, 149),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(988, 149),
				ResultParameterMetaPath = @"02b1469d-72ad-4909-a7cf-6b41b79d41a7",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,177,14,130,48,16,0,208,143,97,62,67,185,150,187,118,119,112,210,196,145,48,156,189,35,14,148,161,144,56,16,255,221,206,174,47,121,83,55,221,246,251,103,179,250,204,111,43,146,22,89,119,155,47,77,255,224,186,90,177,237,72,39,179,68,99,18,136,153,50,120,66,6,238,205,131,71,68,195,16,108,84,247,109,225,33,85,138,29,86,211,57,42,57,79,250,130,94,68,192,187,28,128,57,18,160,232,160,204,139,242,208,74,55,255,0,207,157,35,16,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(988, 310),
				ResultParameterMetaPath = @"02b1469d-72ad-4909-a7cf-6b41b79d41a7",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,177,14,194,32,16,0,208,143,233,124,70,188,131,30,236,14,78,154,56,54,12,7,28,113,40,29,104,19,135,166,255,110,103,215,151,188,105,152,30,235,243,187,104,127,231,143,54,9,85,230,85,227,229,212,63,184,207,218,116,217,194,158,172,225,76,226,128,144,5,40,97,2,246,236,193,120,66,29,179,43,104,175,199,25,94,210,165,233,166,61,236,194,152,213,27,4,84,203,64,37,49,36,235,16,70,115,171,84,77,53,133,234,17,135,248,3,216,229,173,9,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask5FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask5",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(736, 310),
				ResultParameterMetaPath = @"738ceb61-832b-4b27-a973-9347e26e827e",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,141,61,11,194,48,20,0,127,140,243,147,36,205,103,87,233,224,164,224,88,58,188,36,239,161,208,84,104,43,34,165,255,221,184,58,29,28,28,215,31,250,243,114,121,79,52,223,210,157,10,182,140,227,66,195,177,218,63,209,141,84,104,90,219,13,173,246,108,173,128,38,32,130,118,140,16,146,113,160,56,39,45,98,200,13,167,189,6,87,156,177,208,74,115,187,229,38,42,47,109,0,19,73,129,230,144,32,184,36,128,136,149,167,172,217,72,251,75,186,105,125,172,159,211,115,124,149,169,221,92,242,18,133,36,96,19,98,29,101,6,223,136,4,158,42,88,70,246,62,236,195,97,248,2,55,56,7,126,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask6FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask6",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(736, 149),
				ResultParameterMetaPath = @"738ceb61-832b-4b27-a973-9347e26e827e",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,187,10,194,48,20,0,208,143,113,190,146,230,157,172,210,193,73,193,177,116,184,73,110,80,104,34,180,17,145,210,127,183,174,174,7,206,112,24,206,203,229,93,105,190,197,59,21,244,25,167,133,198,227,174,127,208,79,84,168,54,191,146,205,150,132,203,64,74,56,144,204,26,64,169,29,32,23,193,201,46,68,45,205,182,135,43,206,88,168,209,236,215,132,200,28,37,3,28,77,2,41,21,3,20,12,33,37,139,177,211,145,33,211,191,210,215,246,104,159,211,115,122,149,234,87,84,49,162,113,28,164,73,251,226,22,193,138,28,64,69,199,67,74,206,228,108,183,241,48,126,1,146,45,47,48,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask7FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask7",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(498, 149),
				ResultParameterMetaPath = @"b6534525-3848-4420-8930-e7bcc98a1756",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,205,177,10,194,48,16,128,225,135,113,62,73,154,75,122,201,42,29,156,20,28,75,135,36,119,69,161,141,208,86,68,74,223,221,186,186,254,240,241,183,135,246,60,95,222,69,166,91,190,203,24,67,31,135,89,186,227,94,255,66,51,200,40,101,9,107,47,200,68,162,0,157,205,128,148,34,120,157,50,136,103,97,180,201,100,171,182,29,92,227,20,71,89,100,10,43,35,106,211,115,4,169,148,221,137,206,64,21,49,36,20,87,43,167,107,93,245,63,210,148,229,177,124,78,207,225,53,150,176,70,70,175,216,18,40,139,17,246,169,5,95,161,3,102,66,231,36,25,79,102,235,14,221,23,218,197,238,43,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask8FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask8",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1113, 149),
				ResultParameterMetaPath = @"b2b54e53-5309-4650-ac67-b8a4705d22b4",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,187,10,194,48,20,0,208,143,113,190,146,230,157,172,210,193,73,193,177,116,184,73,110,80,104,34,180,17,145,210,127,183,174,174,7,206,112,24,206,203,229,93,105,190,197,59,21,244,25,167,133,198,227,174,127,208,79,84,168,54,191,146,205,150,132,203,64,74,56,144,204,26,64,169,29,32,23,193,201,46,68,45,205,182,135,43,206,88,168,209,236,215,132,200,28,37,3,28,77,2,41,21,3,20,12,33,37,139,177,211,145,33,211,191,210,215,246,104,159,211,115,122,149,234,87,84,49,162,113,28,164,73,251,226,22,193,138,28,64,69,199,67,74,206,228,108,183,241,48,126,1,146,45,47,48,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask9FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"FormulaTask9",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1113, 310),
				ResultParameterMetaPath = @"b2b54e53-5309-4650-ac67-b8a4705d22b4",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,141,61,11,194,48,20,0,127,140,243,147,36,205,103,87,233,224,164,224,88,58,188,36,239,161,208,84,104,43,34,165,255,221,184,58,29,28,28,215,31,250,243,114,121,79,52,223,210,157,10,182,140,227,66,195,177,218,63,209,141,84,104,90,219,13,173,246,108,173,128,38,32,130,118,140,16,146,113,160,56,39,45,98,200,13,167,189,6,87,156,177,208,74,115,187,229,38,42,47,109,0,19,73,129,230,144,32,184,36,128,136,149,167,172,217,72,251,75,186,105,125,172,159,211,115,124,149,169,221,92,242,18,133,36,96,19,98,29,101,6,223,136,4,158,42,88,70,246,62,236,195,97,248,2,55,56,7,126,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("60a1c5d5-b601-479f-92f1-be91ff7f23f7"),
				CreatedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"),
				Name = @"AddDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1400, 20),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new OpportunityManagementFinance(userConnection);
		}

		public override object Clone() {
			return new OpportunityManagementFinanceSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityManagementFinance

	/// <exclude/>
	public class OpportunityManagementFinance : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessOpportunityMangementProcess

		/// <exclude/>
		public class ProcessOpportunityMangementProcess : ProcessLane
		{

			public ProcessOpportunityMangementProcess(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadOppDataFlowElement

		/// <exclude/>
		public class ReadOppDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOppDataFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOppData";
				IsLogging = true;
				SchemaElementUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,20,252,43,69,135,158,164,98,75,254,146,115,92,182,101,47,105,160,105,41,36,75,120,146,158,178,2,127,197,150,104,22,179,255,189,242,58,155,66,14,165,208,83,64,7,233,61,205,188,153,65,154,31,220,244,217,53,30,199,218,66,51,33,13,59,83,147,156,131,72,4,71,150,164,34,99,153,130,130,201,210,38,172,72,173,52,40,19,45,42,36,180,131,22,107,178,162,183,198,121,66,157,199,118,170,239,230,63,164,126,12,72,31,236,249,240,77,31,176,133,239,203,0,192,172,176,170,42,153,78,184,102,25,96,197,192,136,148,129,228,66,27,35,101,166,45,89,181,84,152,139,66,101,130,161,82,57,203,100,197,153,42,160,100,138,151,42,23,74,129,176,57,161,13,90,191,125,30,70,156,38,215,119,245,140,175,251,219,227,16,85,174,179,55,125,19,218,142,208,22,61,220,128,63,44,66,18,204,114,13,76,103,50,178,91,44,25,8,105,152,0,85,242,178,194,180,72,75,66,53,12,126,161,37,59,67,168,1,15,63,160,9,120,102,158,93,212,200,69,146,86,121,17,177,169,136,118,4,79,88,85,68,119,214,20,86,162,40,164,84,230,146,215,151,224,226,222,77,215,161,197,209,233,151,216,49,230,215,143,245,172,251,206,143,125,179,80,95,159,175,223,226,179,95,195,125,105,253,92,13,249,88,95,64,228,68,195,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,8,29,221,227,225,175,105,109,194,228,251,246,29,89,165,209,102,228,136,143,236,44,119,121,131,198,77,67,3,199,243,185,38,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,109,144,55,4,53,185,39,96,43,68,144,241,19,96,154,178,140,23,200,160,42,19,198,181,181,66,152,36,177,85,118,79,162,168,255,31,117,183,155,190,254,234,46,63,100,245,180,255,20,171,111,10,55,23,100,61,255,139,186,211,126,209,183,63,197,245,27,208,129,205,245,232,3,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ProspectingFlowElement

		/// <exclude/>
		public class ProspectingFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public ProspectingFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "Prospecting";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
			}

			#endregion

		}

		#endregion

		#region Class: NeedsAnalysisFlowElement

		/// <exclude/>
		public class NeedsAnalysisFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public NeedsAnalysisFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "NeedsAnalysis";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementValuePpropositionFlowElement

		/// <exclude/>
		public class OppManagementValuePpropositionFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementValuePpropositionFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid Presentation {
				get {
					return GetParameterValue<Guid>("Presentation");
				}
				set {
					SetParameterValue("Presentation", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "OppManagementValuePproposition";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("Presentation", (Guid)((process.Presentation)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: IdDecisionMakersFlowElement

		/// <exclude/>
		public class IdDecisionMakersFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public IdDecisionMakersFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "IdDecisionMakers";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementPerceptionAnalysisFlowElement

		/// <exclude/>
		public class OppManagementPerceptionAnalysisFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementPerceptionAnalysisFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "OppManagementPerceptionAnalysis";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementProposalFlowElement

		/// <exclude/>
		public class OppManagementProposalFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementProposalFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "OppManagementProposal";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementNegotiationsFlowElement

		/// <exclude/>
		public class OppManagementNegotiationsFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementNegotiationsFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "OppManagementNegotiations";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementContractationFlowElement

		/// <exclude/>
		public class OppManagementContractationFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementContractationFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "OppManagementContractation";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementEndStageFlowElement

		/// <exclude/>
		public class OppManagementEndStageFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementEndStageFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public int NextOpportunityStageNumber {
				get {
					return GetParameterValue<int>("NextOpportunityStageNumber");
				}
				set {
					SetParameterValue("NextOpportunityStageNumber", value);
				}
			}

			public Guid CurrentStage {
				get {
					return GetParameterValue<Guid>("CurrentStage");
				}
				set {
					SetParameterValue("CurrentStage", value);
				}
			}

			public LocalizableString Recommendation {
				get {
					return GetParameterValue<LocalizableString>("Recommendation");
				}
				set {
					SetParameterValue("Recommendation", value);
				}
			}

			public bool IsStageChangedByUser {
				get {
					return GetParameterValue<bool>("IsStageChangedByUser");
				}
				set {
					SetParameterValue("IsStageChangedByUser", value);
				}
			}

			public bool DontShowPageEndOfStage {
				get {
					return GetParameterValue<bool>("DontShowPageEndOfStage");
				}
				set {
					SetParameterValue("DontShowPageEndOfStage", value);
				}
			}

			public Guid NextStage {
				get {
					return GetParameterValue<Guid>("NextStage");
				}
				set {
					SetParameterValue("NextStage", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagementFinance)owner;
				Name = "OppManagementEndStage";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagementFinance)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("IsStageChangedByUser", (bool)((process.IsStageChangedByUser)));
			}

			#endregion

		}

		#endregion

		#region Class: FindPresentationFlowElement

		/// <exclude/>
		public class FindPresentationFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public FindPresentationFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FindPresentation";
				IsLogging = true;
				SchemaElementUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,91,139,220,54,20,199,191,74,240,67,159,172,162,203,209,109,250,184,108,97,161,221,4,146,150,64,88,194,145,116,180,107,50,99,79,108,153,118,25,230,187,87,158,217,77,134,176,217,166,105,105,73,154,55,91,246,209,185,253,127,58,218,189,238,166,31,187,117,161,113,149,113,61,81,59,95,164,85,67,90,123,155,2,48,138,206,49,136,100,153,11,153,179,132,92,56,145,188,78,33,52,109,143,27,90,53,71,235,243,212,149,166,237,10,109,166,213,171,221,251,77,203,56,83,251,58,31,94,158,199,27,218,224,47,139,131,8,224,147,83,146,33,196,200,32,112,193,130,79,154,57,20,50,130,68,159,157,111,142,177,72,97,162,228,200,153,204,222,51,72,193,50,31,92,100,58,129,163,168,29,96,112,77,187,166,92,206,127,223,142,52,77,221,208,175,118,244,238,249,197,237,182,70,121,244,125,54,172,231,77,223,180,27,42,248,12,203,77,13,196,37,7,217,71,22,192,5,6,214,7,230,49,26,6,32,100,86,160,76,68,217,180,17,183,101,217,182,121,94,176,204,83,211,142,148,105,164,62,210,73,78,142,107,196,72,192,156,225,192,128,215,162,161,167,192,120,214,32,44,104,175,34,111,218,132,5,127,197,245,76,135,184,118,93,53,12,210,107,110,69,102,150,176,102,72,70,50,151,4,50,47,124,200,202,42,153,179,188,175,246,79,195,240,102,222,214,74,79,151,243,134,198,46,222,181,141,106,253,135,113,181,139,67,95,198,97,189,108,126,121,98,112,108,207,221,199,151,199,146,172,15,95,22,195,102,223,206,19,157,173,59,234,203,121,31,135,212,245,215,135,206,237,247,213,102,179,197,177,155,238,11,121,254,118,198,117,45,64,119,125,243,104,193,159,225,88,253,215,174,127,105,41,183,219,251,200,15,49,47,114,78,221,180,93,227,237,225,125,213,124,247,118,30,202,15,23,253,147,237,56,92,47,57,31,23,154,15,12,239,127,84,30,18,4,7,76,59,50,44,101,33,152,183,162,202,130,139,100,56,121,229,162,185,219,97,223,62,232,234,114,40,79,170,240,198,66,233,79,92,185,79,119,117,85,123,251,143,114,170,130,202,194,56,207,146,179,245,204,224,193,48,207,45,175,176,10,4,153,147,114,220,127,62,167,26,188,136,74,101,70,94,218,122,34,161,99,168,109,117,6,78,112,66,13,81,155,19,78,151,205,30,166,212,234,0,73,85,204,181,78,75,70,201,44,202,227,76,101,240,168,93,242,38,218,47,77,178,223,40,253,24,165,47,112,122,243,56,51,57,16,199,88,165,16,115,228,71,102,2,231,249,223,97,6,81,201,136,185,170,154,180,96,32,193,84,35,206,235,255,17,200,25,74,206,136,191,51,219,4,100,180,130,17,175,135,0,40,169,25,214,121,87,101,11,40,189,162,36,148,59,97,230,12,11,93,15,227,237,195,220,120,35,72,114,87,3,20,178,110,150,42,133,129,123,189,128,46,200,64,50,241,219,116,251,122,166,219,207,68,165,218,60,142,14,200,104,33,130,255,79,198,77,136,90,59,203,13,203,38,214,113,99,173,97,193,250,196,164,128,68,150,132,225,82,126,62,58,96,14,163,20,107,12,102,81,251,210,60,149,3,179,156,162,196,76,73,219,124,130,206,211,237,118,24,203,220,119,229,35,244,32,129,201,193,89,22,185,172,137,33,213,241,149,148,168,23,68,169,98,74,222,67,204,255,159,169,115,54,79,101,216,124,165,232,156,205,99,237,126,121,50,188,215,196,227,24,97,118,84,147,37,198,169,18,4,210,16,195,170,108,38,99,206,74,165,58,140,28,60,126,65,252,203,46,95,93,76,79,127,235,239,209,59,150,237,234,251,186,250,193,194,187,75,252,106,247,41,81,238,175,78,112,191,218,255,1,24,125,65,165,92,14,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
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

		#region Class: LinkOppToProcessFlowElement

		/// <exclude/>
		public class LinkOppToProcessFlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkOppToProcessFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkOppToProcess";
				IsLogging = true;
				SchemaElementUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.CurrentOpportunity));
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

			private Guid _entitySchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
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

		#region Class: ReadOppMainContactFlowElement

		/// <exclude/>
		public class ReadOppMainContactFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOppMainContactFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOppMainContact";
				IsLogging = true;
				SchemaElementUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,93,107,219,48,20,253,43,197,15,123,178,134,44,201,150,228,189,53,100,80,24,109,96,31,12,74,40,215,210,85,99,234,143,212,150,89,67,200,127,159,236,212,107,9,101,108,180,47,125,211,135,239,209,185,231,158,227,253,77,217,127,46,43,143,93,238,160,234,49,30,46,108,30,169,68,107,170,20,37,90,74,65,4,38,150,232,140,165,4,10,33,153,78,81,48,173,163,184,129,26,243,232,88,189,180,165,143,226,210,99,221,231,215,251,39,80,223,13,24,223,184,105,243,213,108,176,134,239,227,3,14,152,20,142,91,146,74,224,68,8,68,82,100,66,16,171,185,16,9,240,196,34,139,142,92,138,172,48,142,26,71,36,179,142,8,150,106,2,41,229,161,50,161,162,192,148,73,21,62,173,208,249,229,195,182,195,190,47,219,38,223,227,159,245,183,221,54,176,60,190,189,104,171,161,110,162,184,70,15,43,240,155,60,74,69,90,36,194,2,49,160,50,34,64,178,128,174,28,73,45,56,14,180,40,156,165,81,108,96,235,71,216,232,106,187,109,59,63,52,165,223,69,113,135,14,59,108,12,62,107,12,80,100,174,80,146,24,202,76,192,67,69,192,242,132,128,102,220,88,171,181,48,46,138,45,120,248,1,213,128,19,185,125,57,182,25,116,165,50,9,109,34,232,32,121,198,136,178,9,16,157,232,194,113,201,153,115,108,150,252,75,219,222,13,219,32,119,127,57,212,216,149,230,113,118,24,134,208,118,249,222,180,141,239,218,106,4,191,124,86,112,156,209,227,229,207,163,46,213,116,51,22,70,135,120,232,113,81,149,216,248,101,99,90,91,54,183,211,248,14,135,80,83,111,161,43,251,89,205,229,253,0,85,16,160,188,221,252,85,245,197,208,251,182,126,111,253,198,161,215,0,19,28,59,113,30,13,109,203,126,91,193,110,218,231,209,135,251,161,245,159,22,67,23,166,239,207,218,39,79,28,47,162,19,128,185,0,156,194,208,44,18,138,73,18,156,156,33,1,37,41,97,198,57,206,45,165,78,137,71,132,67,252,54,79,94,95,244,87,191,154,57,122,71,217,214,31,195,233,201,193,106,174,206,247,255,194,242,176,158,121,174,131,59,222,52,238,1,223,105,149,114,98,165,83,68,216,34,33,138,106,77,140,6,206,81,211,52,75,221,43,226,110,104,86,48,64,34,205,248,99,115,33,248,74,167,140,20,146,107,165,57,75,89,166,158,197,125,213,149,53,116,187,179,209,67,96,252,139,70,214,180,200,210,34,112,13,196,67,226,19,17,8,75,169,9,19,140,134,5,56,77,229,108,228,243,182,173,16,154,255,112,242,98,131,230,238,188,125,56,245,113,232,207,220,21,225,252,37,23,79,152,175,136,237,106,118,195,251,106,248,133,220,158,166,98,244,231,100,218,245,225,55,167,91,127,183,250,6,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,205,79,201,76,203,76,77,241,207,179,50,178,50,212,241,76,177,50,176,50,0,0,136,48,240,252,21,0,0,0 })));
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
								new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"));
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
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,5,193,65,1,0,32,8,3,192,68,123,224,112,64,28,132,254,25,188,107,157,92,118,35,74,6,47,39,50,245,96,212,149,237,206,148,62,148,174,20,226,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
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

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("df249c13-df7a-48d2-b128-85183c4a0e10");
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
					return _recommendation ?? (_recommendation = GetLocalizableString("7fd90c57d4e44518bdf167e8684604dc",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataLeadFlowElement

		/// <exclude/>
		public class ReadDataLeadFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataLeadFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataLead";
				IsLogging = true;
				SchemaElementUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,43,139,14,61,89,193,31,178,44,185,167,18,182,101,161,164,161,77,75,33,187,132,145,52,202,10,252,177,177,100,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,239,205,123,143,241,116,231,252,71,215,4,28,106,11,141,199,100,220,152,154,100,210,90,142,105,74,139,74,48,202,84,165,169,50,105,78,83,166,75,101,109,145,231,138,145,164,131,22,107,178,160,215,198,5,146,184,128,173,175,111,167,63,164,97,24,49,185,179,167,226,155,222,99,11,223,231,1,44,3,43,36,74,90,149,169,162,12,149,162,66,131,166,145,91,42,206,4,203,80,147,69,11,151,69,202,115,163,169,182,149,165,76,8,67,21,207,128,102,25,67,109,173,180,188,200,73,210,160,13,235,167,195,128,222,187,190,171,39,252,125,190,121,62,68,149,203,236,203,190,25,219,142,36,45,6,184,134,176,175,9,96,138,172,212,64,53,147,37,101,22,43,10,133,52,180,0,85,229,149,192,140,103,21,73,52,28,194,76,75,54,134,36,6,2,252,128,102,196,19,243,228,162,198,188,72,51,81,242,136,205,10,77,89,145,167,84,112,81,81,107,184,149,88,112,41,149,57,231,245,105,116,241,236,252,213,216,226,224,244,75,236,24,243,235,135,122,210,125,23,134,190,153,169,175,78,207,111,240,41,44,225,190,92,253,92,12,133,216,159,65,228,152,140,30,47,27,135,93,88,119,186,55,174,187,95,56,143,199,8,105,15,48,56,127,78,97,253,48,66,67,146,193,221,239,255,154,214,229,232,67,223,254,71,86,147,104,51,114,196,37,59,201,157,119,208,56,127,104,224,249,84,215,228,221,195,216,135,247,159,17,204,202,7,184,199,122,181,221,46,189,15,143,224,66,100,90,121,104,240,220,188,248,138,186,31,204,106,99,150,154,188,26,80,147,45,129,162,168,152,101,156,150,60,134,192,170,148,83,89,2,206,139,201,180,80,74,89,38,46,140,146,168,132,102,20,88,145,81,6,144,81,137,200,104,41,82,203,173,197,76,72,190,37,209,217,191,215,123,187,241,95,30,187,243,111,184,4,183,187,136,221,87,141,117,131,109,76,184,158,222,98,240,24,1,215,231,81,245,244,22,187,199,221,108,120,119,140,223,47,96,108,124,62,126,4,0,0 })));
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

		#region Class: ChangeDataLeadFlowElement

		/// <exclude/>
		public class ChangeDataLeadFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataLeadFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataLead";
				IsLogging = true;
				SchemaElementUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Opportunity", () => _recordColumnValues_Opportunity.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Opportunity;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,93,107,219,48,20,253,43,65,15,123,178,130,63,100,125,120,143,193,29,121,233,202,214,141,65,27,138,62,174,26,129,108,167,182,204,90,76,254,251,228,56,217,160,15,35,79,131,129,49,146,236,115,238,61,71,231,78,79,110,184,113,62,64,95,89,233,7,72,198,173,169,16,0,147,52,215,6,231,196,8,76,88,193,176,96,165,198,5,213,25,37,37,48,81,50,148,180,178,129,10,45,232,218,184,128,18,23,160,25,170,135,233,15,105,232,71,72,158,236,105,243,85,239,161,145,223,230,2,36,147,150,11,16,152,149,169,194,4,148,194,92,75,141,173,45,132,162,132,147,12,52,58,247,66,129,105,158,26,204,152,178,152,112,41,176,52,156,97,150,131,42,121,206,210,82,151,40,241,96,67,253,122,232,97,24,92,215,86,19,252,94,223,191,29,98,151,75,237,77,231,199,166,69,73,3,65,222,201,176,175,144,132,20,72,169,37,214,68,148,152,88,96,88,22,194,224,66,42,150,51,14,25,205,162,82,45,15,97,166,69,91,131,18,35,131,252,46,253,8,39,230,201,197,30,243,34,205,120,73,35,54,43,52,38,69,158,98,78,99,143,214,80,43,160,160,66,40,115,241,235,211,232,226,218,13,183,99,3,189,211,103,219,33,250,215,245,213,164,187,54,244,157,159,169,111,79,191,223,195,107,88,204,61,127,250,177,8,10,241,124,6,161,99,50,14,176,241,14,218,80,183,186,51,174,125,94,56,143,199,8,105,14,178,119,195,197,133,250,101,148,30,37,189,123,222,255,213,173,205,56,132,174,249,143,164,38,81,102,228,136,33,59,181,59,103,208,184,225,224,229,219,105,95,161,15,47,99,23,62,126,1,105,86,126,126,205,202,214,55,174,31,194,106,14,237,170,179,171,232,192,232,67,228,92,233,206,123,208,243,141,175,183,102,65,162,119,21,42,244,136,44,16,195,57,164,152,208,56,27,132,43,137,69,166,52,6,97,192,144,82,21,186,76,215,134,144,172,176,70,98,200,211,24,48,158,105,204,115,110,176,34,64,89,26,211,149,229,118,125,77,10,31,81,212,255,15,84,61,108,135,207,63,219,203,180,46,254,238,214,241,244,221,65,237,161,137,23,81,77,215,216,112,140,128,187,75,169,106,186,198,148,25,82,183,193,133,183,101,106,171,233,26,151,142,187,217,167,221,49,62,191,0,138,129,16,15,219,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,207,111,218,48,20,254,87,144,219,35,70,137,109,226,56,183,169,221,1,169,221,208,218,245,82,56,60,251,61,175,72,33,65,78,216,196,80,254,247,25,3,107,233,182,203,124,72,148,247,242,253,176,223,231,61,187,238,119,27,98,21,123,164,16,160,107,125,63,185,105,3,77,230,161,117,212,117,147,187,214,65,189,250,9,182,166,57,4,88,83,79,225,9,234,45,117,119,171,174,31,143,46,97,108,204,174,191,167,46,171,158,247,108,214,211,250,235,12,35,59,9,69,22,209,114,169,75,199,213,84,228,188,4,178,188,240,30,193,72,52,152,97,4,187,182,222,174,155,123,234,97,14,253,11,171,246,44,177,69,2,237,188,247,74,150,220,16,149,92,9,45,120,153,23,200,167,72,86,99,230,12,202,130,13,99,214,185,23,90,67,18,125,5,171,28,124,105,200,112,61,205,44,143,78,44,47,29,56,238,189,52,182,80,165,202,201,29,192,167,255,95,129,207,87,207,179,238,243,143,134,194,67,226,173,60,212,29,45,39,177,250,174,240,177,166,53,53,125,181,87,106,234,139,146,4,183,152,73,174,180,42,56,20,90,115,41,180,181,164,181,240,133,27,34,224,247,105,86,123,44,156,4,44,163,61,105,52,87,136,17,34,132,225,126,42,200,131,149,168,164,29,150,87,203,131,69,92,117,155,26,118,79,127,58,253,128,56,106,55,155,54,244,219,102,213,239,38,55,129,160,39,28,5,114,109,192,209,12,143,4,155,139,41,190,165,216,47,142,97,88,176,106,241,175,56,156,222,199,205,95,6,226,125,22,22,108,188,96,15,237,54,184,3,163,60,124,156,103,147,20,178,211,226,127,121,156,215,145,35,193,238,161,129,111,20,62,69,197,4,79,173,91,232,33,137,63,70,223,103,98,43,204,52,211,185,231,154,192,196,105,23,49,42,152,3,55,185,177,94,106,41,188,23,9,253,133,60,5,106,28,93,26,3,82,133,183,165,230,46,19,49,171,16,243,6,40,115,14,70,72,135,104,140,114,62,225,147,242,171,153,115,108,99,165,217,214,117,18,232,210,254,15,247,224,100,252,212,185,125,51,198,55,12,45,174,252,138,112,214,252,207,81,13,108,24,150,195,47,165,56,77,219,210,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7fd90c57d4e44518bdf167e8684604dc",
							"BaseElements.ChangeDataLead.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("60bd7cb9-5552-477e-bfa8-05d8b60538bb");
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

		#region Class: AddDataContactToOpportunityFlowElement

		/// <exclude/>
		public class AddDataContactToOpportunityFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataContactToOpportunityFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataContactToOpportunity";
				IsLogging = true;
				SchemaElementUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_recordDefValues_IsMainContact = () => (bool)(true);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsMainContact", () => _recordDefValues_IsMainContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Opportunity;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<bool> _recordDefValues_IsMainContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,201,110,220,70,16,253,149,1,237,227,244,160,247,101,110,129,236,0,2,236,68,177,29,95,36,29,170,187,170,237,1,40,82,32,57,9,148,193,252,123,106,40,77,180,36,81,140,32,7,39,8,15,92,186,249,94,85,119,189,87,189,107,94,78,55,215,212,172,155,15,52,12,48,246,117,90,157,244,3,173,206,134,190,208,56,174,222,244,5,218,205,47,144,91,58,131,1,174,104,162,225,35,180,91,26,223,108,198,105,185,120,12,107,150,205,203,159,230,217,102,125,190,107,78,39,186,250,241,20,153,61,37,116,165,70,16,9,180,17,54,147,23,89,133,34,164,71,95,93,177,197,57,203,224,210,183,219,171,238,45,77,112,6,211,231,102,189,107,102,54,38,112,214,101,101,17,68,129,232,133,133,160,5,184,88,133,67,168,6,100,206,21,101,179,95,54,99,249,76,87,48,7,189,7,87,208,193,86,131,194,5,224,232,150,72,100,111,173,192,100,172,85,96,20,146,62,128,239,254,191,7,158,191,56,63,29,191,255,185,163,225,253,204,187,174,208,142,116,185,226,209,39,3,175,91,186,162,110,90,239,172,117,213,71,210,34,163,228,88,193,122,1,62,4,97,116,200,153,66,208,213,151,61,3,126,219,205,245,14,125,49,128,49,137,96,82,16,22,145,33,90,39,81,157,166,10,217,160,53,121,127,249,226,242,144,34,110,198,235,22,110,62,254,62,211,111,16,23,253,245,117,63,76,219,110,51,221,172,78,6,130,137,112,49,80,233,7,92,156,226,45,193,245,163,42,62,164,216,93,220,138,225,162,89,95,252,153,28,238,158,183,139,127,44,136,167,90,184,104,150,23,205,251,126,59,148,3,163,57,124,28,107,51,71,144,119,151,248,131,219,241,186,229,152,97,111,161,131,79,52,124,199,17,103,248,60,245,10,38,152,131,127,224,188,143,196,89,39,39,131,170,34,16,36,97,201,107,17,81,177,244,84,202,213,4,163,107,213,51,250,29,85,26,168,43,244,56,49,32,235,107,142,65,20,169,11,75,141,162,0,52,74,64,210,166,32,166,100,75,157,241,115,228,251,100,142,178,229,145,110,219,182,115,128,113,94,255,193,7,119,137,223,205,188,122,80,198,7,12,61,110,234,134,240,180,251,59,91,181,111,246,251,229,67,211,185,74,177,168,232,68,214,200,186,10,54,240,26,140,19,209,131,211,198,231,28,12,60,107,58,240,58,162,1,16,33,121,37,108,178,70,196,232,179,80,198,59,175,16,75,73,254,171,48,93,37,139,49,146,20,214,59,46,89,204,135,106,231,34,40,33,33,119,14,83,156,124,106,58,78,194,84,110,40,164,165,99,136,42,34,242,106,69,102,193,4,233,85,80,186,30,32,175,187,137,221,116,50,239,209,122,7,104,147,68,23,133,116,22,216,170,188,185,73,179,197,17,163,245,158,178,73,209,252,181,85,223,17,224,162,61,220,144,5,188,250,118,51,140,211,98,195,117,91,244,149,253,58,110,219,105,211,125,90,112,97,90,42,211,166,239,86,63,108,185,11,31,164,177,128,145,199,187,9,202,244,191,159,191,204,207,202,103,98,193,42,17,43,183,101,171,92,226,126,128,82,64,148,220,90,125,52,136,230,95,225,103,67,209,73,105,188,136,217,176,248,136,15,11,176,42,136,16,17,164,211,197,161,194,231,15,209,34,125,214,64,34,148,96,133,61,168,63,38,199,71,21,31,60,49,25,237,180,143,255,188,159,167,129,31,207,248,225,56,255,223,63,153,146,204,222,229,202,221,163,86,110,83,202,178,38,67,72,66,91,45,249,5,106,146,225,57,37,127,113,98,95,161,146,47,247,191,2,149,74,120,39,108,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7fd90c57d4e44518bdf167e8684604dc",
							"BaseElements.AddDataContactToOpportunity.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("60bd7cb9-5552-477e-bfa8-05d8b60538bb");
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

		#region Class: AddDataOpportunityFlowElement

		/// <exclude/>
		public class AddDataOpportunityFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataOpportunityFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataOpportunity";
				IsLogging = true;
				SchemaElementUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Account = () => (Guid)((process.Account));
				_recordDefValues_Title = () => new LocalizableString((process.ClientName)  + "/" + ((process.ClientOpportunityCount)+1).ToString());
				_recordDefValues_Budget = () => (Decimal)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("Budget").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Decimal>("Budget") : 0m)));
				_recordDefValues_IsPrimary = () => (bool)((process.ClientOpportunityCount) == 0);
				_recordDefValues_Owner = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("SalesOwner").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("SalesOwnerId") : Guid.Empty)));
				_recordDefValues_LeadType = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_recordDefValues_DueDate = () => (DateTime)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("DecisionDate").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("DecisionDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_recordDefValues_ResponsibleDepartment = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("OpportunityDepartment").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("OpportunityDepartmentId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)((process.Contact));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Budget", () => _recordDefValues_Budget.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsPrimary", () => _recordDefValues_IsPrimary.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_LeadType", () => _recordDefValues_LeadType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DueDate", () => _recordDefValues_DueDate.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ResponsibleDepartment", () => _recordDefValues_ResponsibleDepartment.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Account;
			internal Func<string> _recordDefValues_Title;
			internal Func<Decimal> _recordDefValues_Budget;
			internal Func<bool> _recordDefValues_IsPrimary;
			internal Func<Guid> _recordDefValues_Owner;
			internal Func<Guid> _recordDefValues_LeadType;
			internal Func<DateTime> _recordDefValues_DueDate;
			internal Func<Guid> _recordDefValues_ResponsibleDepartment;
			internal Func<Guid> _recordDefValues_Contact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,153,75,111,27,71,18,199,191,10,193,228,144,32,106,109,191,31,2,114,216,181,179,128,129,60,140,216,155,139,229,67,117,87,149,67,128,34,5,146,202,194,43,232,187,239,127,40,57,182,156,13,19,56,48,98,135,203,195,80,154,97,119,245,116,213,175,94,125,61,255,116,247,242,82,230,103,243,167,178,217,208,118,173,187,211,7,235,141,156,62,222,172,135,108,183,167,95,175,7,45,23,255,161,190,148,199,180,161,11,217,201,230,7,90,94,201,246,235,197,118,119,50,187,63,108,126,50,255,244,167,253,211,249,217,179,235,249,163,157,92,252,235,17,99,246,214,83,200,201,6,19,40,14,19,11,59,211,184,116,51,186,102,73,73,109,234,5,131,199,122,121,117,177,250,70,118,244,152,118,63,206,207,174,231,251,217,48,65,236,45,73,80,53,202,201,155,72,226,76,183,148,140,31,201,89,220,119,137,202,252,230,100,190,29,63,202,5,237,133,190,30,76,18,179,246,90,204,176,30,210,73,170,33,14,206,80,243,97,48,183,22,135,78,131,239,126,255,122,224,179,79,158,61,218,126,247,239,149,108,158,236,231,61,83,90,110,229,249,41,238,190,117,227,231,205,57,187,14,209,147,140,148,77,13,169,153,56,82,55,213,231,110,154,212,88,155,114,166,216,111,158,127,242,124,146,200,139,237,229,146,94,254,240,75,193,127,31,99,125,181,218,221,254,236,242,222,214,191,249,195,235,243,91,13,158,207,207,206,127,77,135,119,223,183,43,190,175,197,183,21,120,62,63,57,159,63,89,95,109,198,52,99,152,254,121,181,161,123,9,246,238,99,254,199,229,213,231,118,142,253,176,111,104,69,47,100,243,45,36,238,135,239,31,61,164,29,237,133,63,197,186,95,77,220,125,75,182,56,53,69,8,155,38,217,155,202,142,76,115,173,107,40,193,171,250,253,232,239,69,101,35,171,33,247,23,230,19,151,225,168,27,199,98,77,76,22,246,17,173,55,214,139,21,216,134,231,124,251,114,123,201,175,23,243,202,214,112,103,117,181,92,238,5,108,247,239,63,25,239,221,194,239,158,60,124,67,89,111,204,176,230,133,46,132,31,173,222,101,171,110,230,55,55,39,111,146,210,93,175,213,86,216,120,215,201,86,49,130,74,247,38,48,87,219,216,106,200,249,32,41,165,217,148,195,152,72,113,209,68,78,108,40,41,155,158,133,185,59,203,153,195,7,66,74,247,61,69,73,193,164,96,161,116,56,8,67,35,23,211,43,197,98,19,123,223,227,68,202,108,246,197,236,124,254,183,243,57,190,63,123,39,73,214,119,23,115,99,83,60,177,137,13,226,168,96,143,114,143,174,151,198,209,81,153,36,125,225,62,63,125,186,126,178,219,44,86,47,62,251,252,48,161,147,113,204,214,58,27,203,133,76,160,190,181,202,7,251,219,223,93,94,174,55,187,171,213,98,247,242,193,45,207,191,20,241,215,167,59,13,10,73,29,212,235,0,102,156,116,76,45,147,9,53,48,101,82,26,58,14,209,253,187,23,246,161,211,173,85,123,240,109,152,28,90,54,81,1,89,117,61,153,208,124,212,164,131,97,138,135,227,96,136,112,15,77,76,70,204,52,209,103,76,80,225,231,90,170,170,210,108,119,37,255,153,116,127,181,148,11,152,253,217,181,74,228,90,39,95,156,19,100,213,62,249,242,62,140,52,22,142,169,135,145,236,205,125,72,57,70,23,148,201,136,159,222,173,58,188,155,175,240,92,8,7,197,102,87,156,215,105,200,87,171,221,30,167,105,143,206,174,107,245,93,29,23,120,72,132,143,232,109,53,213,14,50,93,155,11,163,50,54,89,127,59,220,126,47,196,179,229,116,97,24,240,233,63,23,155,237,110,182,128,222,38,194,55,178,189,90,238,192,235,12,138,89,202,216,45,214,171,211,127,92,241,11,57,154,248,156,198,168,54,91,54,153,129,113,44,37,24,228,50,80,208,112,8,173,154,83,163,124,28,4,35,130,138,228,134,236,78,43,24,26,72,52,74,138,166,217,192,41,33,156,164,234,15,18,28,136,122,32,239,13,56,128,11,112,148,77,171,189,35,222,143,50,200,219,222,237,159,74,240,59,68,205,217,151,95,206,236,97,190,126,45,26,254,60,244,175,143,16,156,115,78,29,70,99,117,202,236,92,116,166,150,210,140,159,124,86,41,164,205,150,163,64,136,74,25,165,68,100,3,41,195,172,184,195,136,27,57,227,131,182,96,125,118,105,28,78,113,115,141,41,5,66,18,145,96,156,32,130,12,105,236,70,71,201,210,84,66,110,241,184,130,96,26,86,169,32,165,232,182,6,216,150,207,200,164,165,153,161,204,195,99,179,26,217,247,17,4,159,208,82,182,179,245,180,41,199,18,9,255,104,165,234,114,135,129,38,192,175,130,42,207,161,71,80,153,1,67,69,4,137,25,25,49,135,143,2,99,91,53,137,6,54,106,17,14,163,199,219,52,74,5,197,92,213,236,145,34,248,49,14,99,220,45,143,138,250,52,20,184,128,232,198,148,185,53,50,89,130,101,38,117,26,252,177,97,156,27,30,71,147,61,222,7,93,12,100,89,185,171,65,166,144,7,12,35,35,199,120,31,24,127,43,194,179,9,206,255,67,252,251,32,22,203,93,58,146,184,216,2,46,34,2,126,213,27,130,221,163,219,50,164,214,250,81,64,28,74,10,5,29,88,195,21,69,101,236,25,33,36,0,168,224,98,13,72,248,136,188,28,132,120,192,11,160,165,132,88,76,109,242,2,45,129,195,9,21,69,103,183,70,155,209,221,61,46,136,227,8,148,213,161,225,219,24,177,184,147,162,84,66,133,96,75,246,37,178,205,37,141,247,1,241,67,25,139,45,254,152,237,22,23,178,92,172,142,6,102,246,78,154,104,132,21,101,116,60,173,243,166,251,154,141,146,163,10,37,49,197,120,20,137,181,160,48,75,14,169,73,86,28,58,160,133,10,175,132,88,106,68,139,160,72,101,75,238,112,98,237,112,18,163,182,57,35,57,79,189,20,198,209,133,197,49,141,198,129,10,48,7,4,234,35,235,46,81,180,148,227,84,96,88,33,216,150,160,90,143,5,217,117,106,195,177,246,222,130,190,191,196,154,23,63,237,145,62,22,146,255,104,110,157,24,149,33,32,48,46,77,182,193,146,80,16,225,66,138,131,15,205,165,161,78,250,40,72,182,22,110,12,113,212,168,19,84,184,83,150,77,21,36,19,15,237,54,72,138,153,14,231,214,56,57,66,179,1,45,246,100,247,53,182,162,33,202,213,104,79,165,81,193,140,77,62,144,46,19,186,34,33,38,143,38,56,206,71,77,68,55,4,241,114,242,90,165,143,209,42,185,146,242,111,35,246,96,189,218,209,56,154,126,108,63,226,42,244,249,205,127,1,179,150,13,217,183,32,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7fd90c57d4e44518bdf167e8684604dc",
							"BaseElements.AddDataOpportunity.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("60bd7cb9-5552-477e-bfa8-05d8b60538bb");
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

		#region Class: ReadDataCountOpportunityByAccountFlowElement

		/// <exclude/>
		public class ReadDataCountOpportunityByAccountFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataCountOpportunityByAccountFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataCountOpportunityByAccount";
				IsLogging = true;
				SchemaElementUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,203,106,221,48,16,253,23,45,186,178,138,172,135,109,185,171,114,185,133,64,73,3,125,80,8,151,48,150,70,137,168,95,177,101,218,96,252,239,149,175,175,219,144,69,41,221,21,188,176,70,62,103,206,57,51,158,239,252,248,206,215,1,135,210,65,61,98,50,93,217,146,228,40,152,171,148,162,185,213,5,149,70,56,90,9,204,104,206,192,72,147,170,194,106,32,73,11,13,150,100,67,31,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,206,157,15,31,205,3,54,240,121,109,0,40,51,87,21,57,53,140,27,42,1,11,10,86,164,20,52,23,198,90,173,165,113,100,211,82,137,194,10,6,21,205,114,107,169,204,101,69,11,192,156,102,90,88,6,232,42,233,10,146,212,232,194,241,71,63,224,56,250,174,45,103,252,245,254,233,169,143,42,183,222,135,174,158,154,150,36,13,6,184,129,240,80,18,89,105,133,194,57,234,172,226,171,144,148,86,12,20,229,70,165,44,214,83,5,57,73,12,244,97,165,37,111,141,233,166,54,58,29,208,225,128,173,193,103,166,184,178,185,73,163,210,212,34,163,82,177,200,37,25,167,140,35,195,200,195,109,134,36,177,16,224,11,212,19,158,133,205,126,181,200,181,98,121,234,104,142,160,169,196,140,211,194,166,64,117,170,43,39,114,193,157,227,123,220,239,187,238,219,212,199,168,199,235,169,193,193,155,203,220,48,14,160,27,202,217,116,109,24,186,122,37,191,126,6,216,230,115,185,252,186,101,82,159,111,86,32,89,146,105,196,67,237,177,13,199,214,116,214,183,247,231,209,45,75,196,52,61,12,126,220,147,60,62,78,80,199,0,252,253,195,31,19,63,76,99,232,154,255,205,111,18,189,70,154,184,173,103,205,235,50,91,63,246,53,60,157,207,37,121,245,56,117,225,205,101,15,182,3,121,1,218,63,18,146,3,26,149,209,66,168,104,211,168,184,185,60,171,168,198,66,22,218,217,12,100,117,97,88,146,127,111,115,123,53,126,248,222,238,191,215,22,207,233,117,172,190,40,220,236,232,114,254,27,101,203,105,215,118,90,226,243,19,99,190,182,24,41,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
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

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ReadDataAccountFlowElement

		/// <exclude/>
		public class ReadDataAccountFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataAccountFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataAccount";
				IsLogging = true;
				SchemaElementUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,75,150,100,203,61,149,101,91,246,146,6,154,150,66,178,132,177,52,202,10,252,177,177,37,154,96,246,191,87,94,103,91,8,164,244,90,240,65,51,242,123,243,222,243,120,190,247,211,39,223,6,28,107,7,237,132,89,220,217,154,104,41,100,213,8,164,220,161,163,162,44,12,5,110,52,101,210,22,76,114,38,157,2,146,245,208,97,77,86,244,214,250,64,50,31,176,155,234,219,249,15,105,24,35,102,247,238,92,124,53,7,236,224,219,50,128,75,91,26,6,13,101,22,115,42,100,206,104,35,114,78,115,142,57,74,40,185,85,72,86,45,133,170,10,149,231,72,133,168,52,21,73,2,213,142,91,170,114,165,26,141,186,114,150,145,172,69,23,182,79,199,17,167,201,15,125,61,227,239,243,205,243,49,169,92,103,111,134,54,118,61,201,58,12,112,13,225,80,19,72,243,132,52,64,141,208,146,10,135,37,133,66,91,90,64,83,242,178,66,166,88,73,50,3,199,176,208,146,157,37,153,133,0,223,161,141,120,102,158,253,98,167,200,89,37,85,194,178,20,149,40,120,78,43,85,149,212,89,229,52,22,74,235,198,94,242,250,28,125,58,251,233,42,118,56,122,243,18,59,166,252,134,177,158,205,208,135,113,104,23,234,171,243,235,55,248,20,214,112,95,174,126,172,134,66,234,47,32,114,202,226,132,155,214,99,31,182,189,25,172,239,31,86,206,211,41,65,186,35,140,126,186,164,176,125,140,208,146,108,244,15,135,191,166,181,137,83,24,186,255,200,106,150,108,66,250,170,56,158,229,46,59,104,253,116,108,225,249,92,215,228,221,99,28,194,135,143,198,12,49,244,107,65,94,129,106,114,71,10,193,1,141,84,180,42,100,90,54,35,27,90,113,213,80,141,85,218,190,228,17,68,115,71,146,144,183,233,251,240,54,253,237,110,250,242,179,191,252,9,171,246,253,251,212,125,213,184,190,32,235,249,95,20,157,246,139,166,253,41,61,191,0,77,248,193,226,208,3,0,0 })));
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

		#region Class: ReadDataContactFlowElement

		/// <exclude/>
		public class ReadDataContactFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataContactFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataContact";
				IsLogging = true;
				SchemaElementUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,178,44,185,199,176,41,185,164,233,39,133,36,132,177,52,74,4,254,216,216,50,77,48,251,223,43,175,179,45,228,80,114,43,5,99,164,177,231,157,153,103,102,230,187,48,158,135,38,226,80,121,104,70,204,166,11,87,17,174,153,182,166,246,20,77,201,168,100,165,162,26,184,163,194,131,46,13,228,142,215,156,100,29,180,88,145,213,123,231,66,36,89,136,216,142,213,245,252,71,52,14,19,102,119,254,120,249,98,31,176,133,111,199,0,170,70,161,10,78,181,199,156,74,94,24,170,157,99,20,52,19,78,42,45,156,19,100,205,197,139,154,21,181,49,20,148,209,84,170,218,81,173,114,65,89,201,188,231,70,50,101,24,201,26,244,113,247,180,31,112,28,67,223,85,51,254,62,127,125,222,167,44,215,216,103,125,51,181,29,201,90,140,112,5,241,161,34,128,12,101,97,129,90,105,10,42,61,150,20,132,73,149,66,93,230,165,70,174,120,73,50,11,251,184,200,146,11,71,50,7,17,190,67,51,225,81,121,14,41,199,92,48,174,11,149,124,185,176,84,138,156,165,28,117,73,189,83,222,164,66,141,169,221,137,215,135,41,164,115,24,47,167,22,135,96,95,176,99,226,215,15,213,108,251,46,14,125,179,72,95,30,127,255,138,79,113,133,251,242,233,199,90,80,76,246,197,137,28,178,105,196,179,38,96,23,119,157,237,93,232,238,87,205,195,33,185,180,123,24,194,120,162,176,123,156,160,33,217,16,238,31,254,74,235,108,26,99,223,254,71,165,102,169,204,164,145,134,236,152,238,50,131,46,140,251,6,158,143,247,138,188,123,156,250,248,254,51,130,219,52,203,107,169,108,123,30,134,49,110,150,161,221,244,126,147,8,76,77,76,154,27,219,55,13,218,165,227,219,79,9,88,240,1,221,6,198,100,239,34,216,184,106,145,87,49,43,114,67,60,74,167,53,166,149,81,69,130,163,107,160,134,215,54,173,145,67,39,139,90,216,130,109,157,148,92,120,7,20,115,150,70,78,115,75,117,174,29,173,37,170,146,165,121,227,185,223,130,147,134,185,66,83,86,72,160,73,181,160,38,151,138,58,167,165,82,88,11,163,197,13,73,68,254,73,157,215,23,227,199,159,221,105,163,215,30,220,110,147,245,149,97,215,96,155,154,85,205,111,1,115,72,14,87,167,80,213,252,22,76,139,203,174,139,33,62,175,155,93,205,111,225,118,184,93,200,221,30,210,243,11,19,114,238,11,255,4,0,0 })));
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

		#region Class: PresentationTaskCreationFlowElement

		/// <exclude/>
		public class PresentationTaskCreationFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public PresentationTaskCreationFlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PresentationTaskCreation";
				IsLogging = true;
				SchemaElementUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString("Conduct presentation");
				_recordDefValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
				_recordDefValues_Type = () => (Guid)(new Guid("fbe0acdc-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("42c74c49-58e6-df11-971b-001d60e938c6"));
				_recordDefValues_ShowInScheduler = () => (bool)(true);
				_recordDefValues_StartDate = () => (DateTime)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_recordDefValues_DueDate = () => (DateTime)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).AddHours(1));
				_recordDefValues_Owner = () => (Guid)(((process.ReadOppoortunityData2.ResultEntity.IsColumnValueLoaded(process.ReadOppoortunityData2.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadOppoortunityData2.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_recordDefValues_Lead = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_Account = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ShowInScheduler", () => _recordDefValues_ShowInScheduler.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_StartDate", () => _recordDefValues_StartDate.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DueDate", () => _recordDefValues_DueDate.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Lead", () => _recordDefValues_Lead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Title;
			internal Func<Guid> _recordDefValues_Opportunity;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<bool> _recordDefValues_ShowInScheduler;
			internal Func<DateTime> _recordDefValues_StartDate;
			internal Func<DateTime> _recordDefValues_DueDate;
			internal Func<Guid> _recordDefValues_Owner;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Lead;
			internal Func<Guid> _recordDefValues_Account;

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

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,90,93,111,27,199,21,253,43,4,157,135,22,208,16,243,253,161,183,192,73,81,1,118,235,58,110,94,44,63,220,153,185,215,33,66,145,2,185,76,225,10,250,239,61,75,73,181,172,180,180,154,68,133,21,138,15,75,104,119,239,204,112,238,57,115,238,135,46,166,95,13,31,206,121,122,60,125,195,235,53,109,86,50,204,158,175,214,60,123,181,94,53,222,108,102,47,86,141,22,243,127,82,93,240,43,90,211,25,15,188,254,158,22,91,222,188,152,111,134,163,201,167,102,211,163,233,87,63,237,158,78,143,223,94,76,79,6,62,251,251,73,199,232,150,66,107,218,137,210,186,120,229,157,68,85,57,107,165,99,75,193,137,97,93,53,140,219,106,177,61,91,190,228,129,94,209,240,195,244,248,98,186,27,13,3,248,222,68,147,51,42,73,79,202,247,74,138,180,246,138,189,113,213,96,12,239,204,244,242,104,186,105,63,240,25,237,38,253,104,220,188,47,61,59,171,200,183,166,124,213,70,213,210,131,202,100,108,243,150,138,228,50,26,95,191,255,209,240,116,250,124,181,236,219,54,76,206,215,188,225,229,64,195,124,181,60,157,142,47,247,249,230,124,65,31,190,255,95,108,206,63,217,194,219,86,23,167,87,158,56,157,30,159,254,55,95,92,127,127,183,251,137,159,122,227,174,35,78,167,71,167,211,239,86,219,117,27,71,116,227,31,55,27,179,155,65,95,127,224,143,159,93,110,62,87,99,236,204,94,210,146,222,243,250,47,152,113,103,190,123,244,13,13,180,155,252,13,214,125,51,112,104,228,130,24,173,200,96,151,125,139,73,81,137,164,92,118,157,34,9,53,105,59,235,215,44,188,230,101,227,95,184,176,221,204,31,23,115,131,25,220,89,110,23,139,221,4,155,221,239,31,65,120,189,240,235,39,223,220,242,220,173,17,86,125,46,115,238,39,203,95,178,162,203,233,229,229,209,109,196,155,228,200,250,66,202,107,131,75,47,77,21,109,162,10,148,83,44,177,83,202,159,65,124,204,190,123,224,220,215,88,49,0,70,41,78,170,74,154,155,37,225,30,146,252,246,136,127,251,236,237,201,230,175,255,88,242,250,106,23,142,133,22,27,126,55,195,221,59,55,190,93,240,25,208,125,124,225,125,144,152,217,170,218,181,83,62,249,168,40,166,164,156,77,181,114,74,86,98,187,132,193,191,17,123,124,209,99,115,212,115,81,201,149,145,205,29,38,214,22,37,193,178,80,117,221,187,122,249,238,217,187,125,60,123,251,236,235,222,39,171,243,243,213,122,216,46,231,195,135,217,107,110,171,117,159,156,244,43,195,223,63,217,170,45,65,39,35,42,49,21,229,57,90,149,119,56,49,165,138,75,206,138,216,125,100,35,246,81,106,78,170,105,11,148,16,103,69,29,103,44,21,235,90,239,165,248,38,143,130,108,210,172,214,166,177,226,146,2,240,148,28,224,78,89,105,103,50,24,192,133,107,218,75,182,224,139,105,14,250,196,197,2,144,13,182,20,82,81,221,103,163,153,130,111,33,62,4,217,94,172,86,63,110,207,103,41,84,223,93,169,42,132,62,142,0,62,192,145,90,57,193,9,18,114,47,144,201,153,84,214,212,240,28,71,168,86,93,12,166,209,122,148,84,211,163,230,226,114,139,159,163,204,245,124,95,183,97,254,19,40,51,25,89,48,123,67,155,31,159,40,115,63,202,220,199,83,143,130,50,88,104,52,58,119,21,157,133,198,100,238,170,84,47,8,203,92,240,169,24,151,186,217,75,153,150,141,23,74,70,177,54,208,39,103,131,162,134,241,114,247,100,139,227,110,92,126,64,202,148,104,216,234,12,225,48,118,148,71,208,182,234,2,242,235,106,56,122,40,76,211,51,111,91,242,205,23,21,50,199,43,202,148,132,213,254,26,202,60,167,129,223,175,214,31,102,47,153,135,249,242,253,19,115,238,199,156,251,56,236,81,48,71,91,31,178,111,117,4,43,84,183,65,53,139,144,198,79,202,213,100,143,3,194,239,103,14,54,170,115,11,70,229,28,0,126,155,73,1,158,184,232,166,155,241,213,120,231,127,123,230,12,107,124,237,65,250,205,243,223,127,216,84,116,141,161,10,194,3,17,108,161,241,240,68,130,216,91,15,124,166,68,82,116,58,136,28,37,216,14,204,178,81,145,58,43,156,230,208,128,6,64,185,108,217,102,219,144,165,200,94,36,143,152,163,224,178,138,166,34,219,195,190,129,10,29,33,137,41,177,152,136,56,190,247,47,34,71,17,6,59,51,131,164,113,164,92,70,90,85,76,109,8,247,58,119,80,214,181,160,239,230,40,160,177,147,78,10,167,22,78,169,108,154,202,22,250,86,17,103,39,29,77,50,86,70,147,111,151,3,100,225,249,110,143,142,47,88,26,148,112,151,250,58,200,106,128,19,178,144,87,166,39,221,98,21,27,165,124,62,179,121,205,212,39,139,241,210,1,224,217,159,230,235,205,48,153,195,111,147,149,76,80,85,216,46,70,229,153,192,49,11,134,46,173,150,55,98,52,190,207,19,90,246,201,48,63,227,67,145,166,110,13,66,124,241,200,99,34,170,75,218,32,23,181,80,26,33,67,25,142,234,228,253,65,16,90,23,224,152,81,32,51,0,60,148,5,5,50,36,13,14,133,131,84,109,234,204,72,175,247,23,29,52,66,34,70,70,105,66,181,32,139,67,33,167,214,168,116,75,14,39,99,245,173,212,39,66,255,39,66,207,80,141,248,51,124,191,249,131,249,227,255,137,220,119,167,124,34,250,193,16,61,235,220,16,69,22,148,205,80,110,27,83,79,149,171,182,202,117,147,10,217,158,240,108,127,12,170,147,139,66,78,165,210,33,86,41,130,232,28,139,42,17,145,105,44,197,161,32,242,69,16,61,161,42,83,185,25,213,131,236,210,204,162,170,32,153,171,209,17,59,93,52,135,122,87,185,5,59,48,190,40,168,148,40,200,56,228,64,66,71,49,135,74,237,84,80,137,230,159,43,55,202,173,33,56,66,189,58,148,142,163,79,208,97,16,95,49,72,138,92,132,93,44,254,158,202,125,171,40,121,111,142,239,118,229,80,4,251,215,22,46,77,68,153,34,142,25,148,160,238,236,77,40,176,239,128,112,214,136,57,35,122,13,221,61,10,30,91,231,154,109,26,253,17,34,160,59,85,143,34,74,35,232,109,69,32,89,141,110,121,191,96,87,33,42,45,137,106,46,102,96,29,103,64,118,187,246,75,138,81,11,137,241,249,176,34,112,234,200,67,122,64,118,23,252,216,120,201,65,149,241,144,68,170,227,99,228,234,74,118,15,17,129,255,109,139,70,233,8,141,9,109,112,31,125,191,54,60,241,249,208,248,92,91,141,30,34,130,74,130,128,81,156,84,30,179,98,237,28,8,25,172,109,173,238,229,115,135,214,120,131,243,208,163,12,139,157,64,18,89,91,70,159,219,152,220,37,112,70,135,236,192,248,204,154,61,218,202,10,117,92,88,9,182,148,28,20,218,81,77,54,101,54,48,124,8,62,63,181,17,239,171,198,222,16,128,197,232,230,6,13,17,227,138,210,104,163,166,68,208,40,137,62,123,195,237,81,176,23,237,180,18,136,81,137,117,104,0,122,107,198,158,8,58,60,165,35,255,69,223,94,184,132,253,81,117,213,61,10,2,106,147,8,81,53,33,255,38,19,208,24,65,15,223,59,212,211,244,161,169,49,194,112,100,39,40,70,136,24,252,115,64,22,168,241,24,139,251,64,9,241,118,70,111,53,60,184,26,35,164,90,109,151,79,106,108,238,199,103,27,122,106,6,241,168,233,35,66,198,106,102,29,3,75,109,113,20,195,111,22,34,245,165,242,249,221,229,191,0,79,24,246,2,211,38,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7fd90c57d4e44518bdf167e8684604dc",
							"BaseElements.PresentationTaskCreation.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("60bd7cb9-5552-477e-bfa8-05d8b60538bb");
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

		#region Class: ReadOppoortunityData2FlowElement

		/// <exclude/>
		public class ReadOppoortunityData2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOppoortunityData2FlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOppoortunityData2";
				IsLogging = true;
				SchemaElementUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,172,44,52,19,38,97,103,42,130,185,54,117,102,129,178,186,6,42,148,204,105,201,184,160,220,0,178,90,151,92,88,65,146,14,90,172,200,138,222,26,231,73,226,60,182,83,117,55,255,33,245,99,192,228,193,158,15,223,244,1,91,248,190,52,0,20,210,214,101,65,117,154,105,42,0,75,10,134,51,10,42,227,218,24,165,132,182,100,213,34,139,210,160,205,82,106,133,42,168,176,82,82,197,153,162,170,72,115,89,34,22,41,211,36,105,208,250,237,243,48,226,52,185,190,171,102,124,221,223,30,135,168,114,237,189,233,155,208,118,36,105,209,195,13,248,195,34,36,69,145,107,160,90,168,60,178,99,65,129,43,67,57,212,69,86,148,200,36,43,72,162,97,240,11,45,217,25,146,24,240,240,3,154,128,103,230,217,69,141,25,79,89,153,203,136,101,60,218,225,81,109,41,163,59,107,164,85,200,165,82,181,185,228,245,37,184,184,119,211,117,104,113,116,250,37,118,140,249,245,99,53,235,190,243,99,223,44,212,215,231,231,183,248,236,215,112,95,174,126,174,134,124,172,47,32,114,74,194,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,72,50,186,199,195,95,211,218,132,201,247,237,59,178,154,68,155,145,35,14,217,89,238,50,131,198,77,67,3,199,243,185,34,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,189,32,111,8,42,114,79,192,198,233,2,133,52,69,198,168,200,36,82,40,139,148,102,218,90,206,77,154,218,82,220,147,40,234,255,91,221,237,166,175,191,186,203,15,89,61,237,63,197,234,155,194,205,5,89,205,255,162,238,180,95,244,237,79,113,253,6,219,198,33,213,232,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,75,107,220,48,16,254,43,139,14,61,89,139,100,203,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,177,177,101,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,51,223,99,198,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,164,186,200,211,20,168,202,4,163,34,70,84,131,146,84,105,147,217,84,48,131,182,32,73,11,13,150,100,169,222,90,31,72,226,3,54,67,121,61,253,105,26,250,17,147,91,119,10,190,153,123,108,224,251,12,192,157,148,60,79,145,10,206,20,21,218,42,170,117,158,81,169,153,200,29,147,214,41,69,22,46,182,226,178,208,204,82,83,104,65,5,200,130,66,6,154,170,74,74,229,128,177,212,197,167,53,186,176,125,58,244,56,12,190,107,203,9,127,159,175,158,15,145,229,130,189,233,234,177,105,73,210,96,128,75,8,247,37,73,141,168,176,18,57,181,58,215,84,100,140,209,170,170,144,58,20,70,59,168,164,227,106,13,200,80,228,6,168,17,58,167,194,225,76,65,91,154,65,85,164,133,66,46,121,180,195,192,33,204,216,228,51,130,93,239,44,73,44,4,248,1,245,136,39,14,147,143,106,210,140,113,149,207,26,120,102,34,94,202,168,146,170,160,206,74,167,49,147,90,87,246,236,236,167,209,199,179,31,46,198,6,123,111,94,6,132,209,233,174,47,39,211,181,161,239,234,185,245,197,233,249,21,62,133,101,12,47,87,63,23,233,33,230,231,34,114,76,198,1,55,181,199,54,108,91,211,89,223,222,45,61,143,199,88,210,28,160,247,195,217,175,237,195,8,53,73,122,127,119,255,87,95,55,227,16,186,230,63,146,154,68,153,177,71,92,199,19,221,121,91,173,31,14,53,60,159,226,146,188,123,24,187,240,126,158,225,106,8,112,135,229,106,191,95,114,31,30,193,135,216,105,53,64,141,231,228,250,43,154,174,183,171,157,93,98,242,10,160,36,123,2,89,86,8,39,36,205,101,52,65,20,76,82,157,3,82,206,133,48,42,238,155,19,106,109,43,141,149,50,130,130,200,120,220,115,224,84,35,10,154,43,230,164,115,200,149,150,123,18,149,253,123,190,215,187,225,203,99,123,254,97,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,25,170,156,222,34,247,120,51,11,190,57,198,239,23,104,109,241,196,168,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
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

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,73,77,76,177,50,180,50,212,241,76,177,50,176,50,0,0,230,77,107,227,15,0,0,0 })));
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
								new Guid("1f66152e-4108-49d8-9953-69045f06df88")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("1f66152e-4108-49d8-9953-69045f06df88"));
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

			public AddDataUserTask1FlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Product", () => _recordDefValues_Product.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Product;
			internal Func<Guid> _recordDefValues_Opportunity;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,43,139,14,61,89,139,101,75,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,99,99,203,36,193,236,127,175,188,206,182,144,67,201,165,135,130,15,154,145,231,189,121,111,70,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,10,231,164,202,37,213,5,230,148,179,52,163,26,10,75,193,113,33,152,200,140,192,130,36,45,52,88,146,165,122,107,125,32,137,15,216,12,229,245,244,7,52,244,35,38,183,238,20,124,51,247,216,192,247,153,128,57,41,35,14,206,216,138,114,109,21,213,90,228,84,234,148,11,151,74,235,148,34,75,47,66,229,105,94,160,162,153,208,150,114,99,20,173,138,74,82,22,99,100,21,51,92,75,146,212,232,194,246,233,208,227,48,248,174,45,39,252,125,190,122,62,196,46,23,238,77,87,143,77,75,146,6,3,92,66,184,47,73,102,120,133,21,23,212,106,161,41,207,211,148,86,85,133,212,33,55,218,65,37,29,83,107,192,20,185,48,64,35,151,160,220,97,65,33,143,205,228,80,21,89,161,144,73,22,237,48,112,8,51,55,249,140,96,215,59,75,18,11,1,126,64,61,226,169,135,201,71,53,89,158,50,37,100,4,96,185,137,124,89,74,149,84,5,117,86,58,141,185,212,186,178,103,103,63,141,62,158,253,112,49,54,216,123,243,50,32,140,78,119,125,57,153,174,13,125,87,207,208,23,167,223,175,240,41,44,99,120,185,250,185,72,15,49,63,23,145,99,50,14,184,169,61,182,97,219,154,206,250,246,110,193,60,30,99,73,115,128,222,15,103,191,182,15,35,212,36,233,253,221,253,95,125,221,140,67,232,154,255,72,106,18,101,70,140,184,142,167,118,231,109,181,126,56,212,240,124,138,75,242,238,97,236,194,251,121,134,171,33,192,29,150,171,253,126,201,125,120,4,31,34,210,106,128,26,207,201,245,87,52,93,111,87,59,187,196,228,21,65,73,246,4,242,188,224,142,75,42,100,52,129,23,105,124,88,2,144,50,198,185,81,113,223,28,87,107,91,105,172,148,225,20,120,206,40,7,96,84,35,114,42,84,234,164,115,200,148,150,123,18,149,253,251,126,175,119,195,151,199,246,252,96,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,153,170,156,222,34,247,120,51,11,190,57,198,239,23,225,253,223,116,168,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("1f66152e-4108-49d8-9953-69045f06df88");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,84,77,111,219,48,12,253,43,133,218,99,24,200,146,44,89,185,110,59,4,104,187,98,237,122,73,114,160,36,106,13,224,216,129,237,172,232,130,252,247,201,78,186,126,96,235,176,162,232,124,176,97,137,239,145,122,228,211,150,157,116,119,107,98,19,118,69,77,131,109,29,187,241,135,186,161,241,69,83,123,106,219,241,105,237,177,92,254,64,87,210,5,54,184,162,142,154,107,44,55,212,158,46,219,110,116,244,20,198,70,236,228,251,176,203,38,179,45,155,118,180,250,58,13,137,93,88,153,11,151,21,64,81,90,80,138,75,64,97,17,114,87,80,230,77,97,50,199,19,216,215,229,102,85,157,81,135,23,216,221,176,201,150,13,108,137,64,102,209,21,82,121,224,65,107,80,194,8,64,206,5,88,17,13,145,181,193,123,197,118,35,214,250,27,90,225,144,244,1,140,185,206,13,105,7,82,137,0,42,227,10,10,116,5,32,58,105,40,10,91,104,222,131,15,241,15,64,35,45,143,210,91,224,20,83,217,49,152,148,149,36,112,71,54,88,18,58,242,108,140,196,73,229,30,193,43,155,167,32,74,65,210,6,144,232,140,48,233,124,58,51,61,123,88,182,235,18,239,174,159,39,73,82,135,141,239,198,169,230,20,181,126,162,242,227,184,237,124,223,172,57,155,204,255,212,174,195,247,114,80,225,105,195,158,247,106,206,70,115,118,89,111,26,223,51,234,254,231,94,187,33,3,63,60,240,155,215,253,179,231,24,96,103,88,225,55,106,206,83,198,1,62,108,125,196,14,135,228,87,169,238,127,38,254,66,145,26,170,60,189,178,176,33,243,67,49,247,99,53,172,188,89,103,15,149,182,131,144,253,192,31,20,168,54,101,217,43,240,168,233,143,74,169,195,50,46,41,76,171,215,28,109,199,118,187,209,19,119,113,46,109,102,51,80,133,79,175,32,17,208,197,28,156,243,185,21,185,113,17,241,69,119,161,205,81,145,42,192,20,61,139,180,10,28,57,15,86,97,46,130,240,133,12,238,237,221,53,59,158,77,219,207,183,21,53,123,21,38,17,203,150,22,227,180,250,108,225,83,73,43,170,186,201,86,169,60,234,130,4,184,144,174,16,101,148,6,212,198,128,20,198,57,50,70,68,237,119,9,240,107,244,39,219,160,189,196,80,88,72,45,55,73,156,144,32,66,88,136,185,160,152,74,12,74,186,221,226,120,241,146,69,103,199,231,116,123,84,175,215,117,211,109,170,101,119,55,238,255,27,242,117,19,142,166,97,15,254,79,206,149,239,231,92,39,108,206,77,22,193,16,38,211,144,22,80,132,12,33,205,158,139,210,72,17,163,120,201,185,72,74,167,107,220,128,231,194,131,66,74,67,18,100,6,104,133,244,33,88,171,124,252,139,115,15,182,122,127,195,45,118,63,1,255,251,130,98,44,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7fd90c57d4e44518bdf167e8684604dc",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("60bd7cb9-5552-477e-bfa8-05d8b60538bb");
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

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,47,58,244,100,21,219,146,44,201,61,46,91,8,148,52,208,15,10,97,9,35,105,148,152,250,43,182,76,27,140,255,123,181,246,58,13,57,148,210,91,65,7,141,164,247,230,205,155,209,124,87,141,239,171,58,224,80,122,168,71,76,166,43,87,18,7,90,235,2,29,53,153,204,41,183,80,80,37,192,82,180,142,155,34,119,232,50,70,146,22,26,44,201,134,62,186,42,144,164,10,216,140,229,237,252,155,52,12,19,38,119,126,13,62,217,7,108,224,203,57,1,32,47,188,81,146,218,52,183,148,3,42,10,142,101,20,116,206,172,115,90,115,235,201,166,69,184,130,9,46,83,42,209,196,167,185,241,20,148,20,20,60,58,157,162,50,210,228,36,169,209,135,227,207,126,192,113,172,186,182,156,241,121,255,249,169,143,42,183,220,135,174,158,154,150,36,13,6,184,129,240,80,146,130,67,42,140,7,202,68,234,40,119,145,221,120,167,168,55,66,106,144,220,51,141,36,177,208,135,51,45,57,116,109,0,27,43,29,208,227,128,173,197,23,69,101,133,65,86,136,140,42,143,209,181,76,104,170,156,75,163,220,148,57,94,40,230,92,116,205,65,128,175,80,79,184,10,155,171,8,52,185,22,169,204,124,44,17,52,229,88,228,17,152,1,213,153,54,158,73,150,123,159,239,118,127,232,186,239,83,31,173,30,175,167,6,135,202,94,250,134,177,1,221,80,206,54,42,28,186,250,76,126,253,2,176,245,231,114,249,109,243,164,94,111,206,64,178,36,211,136,135,186,194,54,28,91,219,185,170,189,95,91,183,44,17,211,244,48,84,227,238,228,241,113,130,58,26,80,221,63,252,209,241,195,52,134,174,249,223,234,77,98,173,145,38,78,235,170,249,60,204,174,26,251,26,158,214,184,36,111,30,167,46,188,187,204,193,22,144,87,160,253,145,41,4,227,34,23,148,41,174,40,231,121,74,149,102,41,69,105,172,213,10,50,41,138,11,195,146,252,123,154,219,171,241,227,143,118,255,94,155,61,167,183,241,244,213,193,205,142,46,231,191,81,182,156,118,109,167,37,174,95,30,241,119,1,41,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
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

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
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

			#endregion

		}

		#endregion

		#region Class: AddDataUserTask2FlowElement

		/// <exclude/>
		public class AddDataUserTask2FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask2FlowElement(UserConnection userConnection, OpportunityManagementFinance process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("37b73641-5ef8-42a7-b1b9-add606693fc1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_StringValue", () => _recordDefValues_StringValue.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ListItemValue", () => _recordDefValues_ListItemValue.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_FloatValue", () => _recordDefValues_FloatValue.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_BooleanValue", () => _recordDefValues_BooleanValue.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IntValue", () => _recordDefValues_IntValue.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Specification", () => _recordDefValues_Specification.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_StringValue;
			internal Func<Guid> _recordDefValues_ListItemValue;
			internal Func<Decimal> _recordDefValues_FloatValue;
			internal Func<bool> _recordDefValues_BooleanValue;
			internal Func<int> _recordDefValues_IntValue;
			internal Func<Guid> _recordDefValues_Specification;
			internal Func<Guid> _recordDefValues_Opportunity;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("7abdac5b-742d-4453-a07c-11e73658156e");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,77,107,220,48,16,253,43,139,14,61,89,139,108,201,250,112,79,101,217,150,133,146,134,54,45,133,108,8,99,105,156,8,252,177,177,101,146,96,246,191,87,94,103,91,200,161,228,84,40,248,160,25,105,222,188,247,102,60,221,250,225,163,175,3,246,69,5,245,128,201,184,115,5,17,41,114,11,198,80,229,148,161,66,101,146,150,178,50,84,151,170,204,181,52,82,229,156,36,45,52,88,144,165,122,235,124,32,137,15,216,12,197,245,244,7,52,244,35,38,183,213,41,248,102,239,177,129,239,115,3,229,56,175,152,205,40,51,86,83,145,107,71,181,67,65,89,105,117,198,171,76,103,146,145,133,139,181,25,166,44,222,105,38,211,248,84,228,212,24,40,105,134,192,28,230,57,84,202,145,164,198,42,108,159,14,61,14,131,239,218,98,194,223,231,171,231,67,100,185,244,222,116,245,216,180,36,105,48,192,37,132,251,130,112,149,89,131,22,41,19,46,162,67,110,41,8,203,163,230,200,142,41,107,24,99,107,192,216,63,183,64,173,48,57,21,21,42,10,220,56,202,161,84,153,210,152,202,84,145,196,194,33,204,189,201,103,4,183,222,69,82,14,2,252,128,122,196,19,135,201,71,53,25,103,169,206,101,4,72,185,165,130,103,140,106,169,21,173,92,244,23,185,52,166,116,103,103,63,141,62,158,253,112,49,54,216,123,251,50,32,140,78,119,125,49,217,174,13,125,87,207,208,23,167,231,87,248,20,150,49,188,92,253,92,164,135,152,159,139,200,49,25,7,220,212,30,219,176,109,109,231,124,123,183,96,30,143,177,164,57,64,239,135,179,95,219,135,17,106,146,244,254,238,254,175,190,110,198,33,116,205,127,36,53,137,50,35,70,92,199,19,221,121,91,157,31,14,53,60,159,226,130,188,123,24,187,240,126,158,225,202,183,171,253,126,137,63,60,130,15,17,101,53,64,141,231,228,106,8,112,135,235,175,104,187,222,173,118,110,201,146,87,45,10,178,39,192,185,18,149,144,52,151,209,134,184,92,146,154,28,144,166,169,16,86,151,101,89,9,189,118,165,193,82,91,17,55,144,207,187,8,41,53,24,23,63,215,172,146,85,133,169,54,114,79,162,182,127,193,248,122,55,124,121,108,207,63,237,98,222,205,58,102,95,37,182,53,54,209,229,98,122,139,196,99,44,184,60,183,42,166,183,8,62,222,204,146,111,142,241,251,5,90,191,223,1,172,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("7d33f0c2-09c8-458d-8de4-0bc823f28260");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,152,75,111,27,55,16,128,255,138,176,206,161,5,60,6,151,111,234,216,180,7,3,73,106,52,143,139,237,195,144,28,54,2,86,90,97,181,174,225,10,250,239,29,173,228,196,54,26,89,9,92,213,7,239,65,194,114,57,15,114,248,113,200,89,86,175,250,155,57,85,227,234,3,117,29,46,218,210,159,188,110,59,58,57,235,218,68,139,197,201,155,54,97,51,249,27,99,67,103,216,225,148,122,234,62,97,115,69,139,55,147,69,127,60,186,47,86,29,87,175,254,26,190,86,227,243,101,117,218,211,244,227,105,102,237,73,149,40,36,106,16,89,9,208,130,16,208,21,2,41,138,213,210,57,175,76,98,225,212,54,87,211,217,91,234,241,12,251,207,213,120,89,13,218,88,129,207,202,170,32,106,32,163,44,104,18,18,188,164,2,46,200,26,179,194,44,107,83,173,142,171,69,250,76,83,28,140,126,21,118,24,51,38,19,193,105,153,65,107,163,0,133,75,80,215,228,148,53,190,54,150,214,194,219,254,223,111,53,79,22,243,6,111,62,61,148,223,52,112,135,249,189,185,187,219,101,121,177,9,193,69,53,190,248,86,16,182,255,239,135,177,221,15,195,195,8,92,84,199,23,213,251,246,170,75,107,141,118,253,114,59,35,131,5,177,125,224,95,126,110,159,141,142,65,236,45,206,240,79,234,222,177,197,65,124,248,244,43,246,56,24,255,192,126,127,183,226,63,168,80,71,179,68,63,232,216,96,249,171,51,183,139,101,104,217,39,94,91,39,22,195,28,173,87,232,118,112,179,171,166,89,15,238,78,40,239,88,105,243,164,76,40,159,206,126,196,235,85,181,90,29,223,197,65,72,161,140,17,9,74,109,60,104,103,44,120,107,16,162,75,74,43,109,115,109,197,78,28,200,215,68,20,16,234,104,89,129,170,61,4,12,133,121,202,152,179,118,201,75,245,244,56,236,107,117,39,14,163,159,114,215,206,33,183,215,179,81,195,123,200,207,47,124,28,140,143,125,2,248,28,248,208,137,178,17,210,64,89,195,172,41,105,8,222,177,216,154,26,12,10,85,189,155,143,90,7,137,84,2,24,99,29,176,58,9,81,9,15,38,186,204,11,28,41,70,247,244,124,236,107,245,49,62,40,77,166,216,188,128,113,56,48,246,137,220,115,0,195,160,69,180,162,0,121,175,24,12,173,193,39,25,33,197,82,146,40,74,101,103,118,130,161,121,1,115,122,81,96,2,243,164,69,225,131,152,77,9,98,200,74,199,122,157,63,237,211,131,177,175,213,71,192,248,165,109,27,194,217,11,24,135,3,99,159,200,61,7,48,82,8,197,37,237,33,233,108,64,23,74,128,94,41,136,198,89,129,198,27,146,126,39,24,193,155,196,119,20,5,57,41,78,141,198,7,8,142,60,212,214,42,78,59,84,203,20,159,30,140,125,173,62,2,198,100,214,19,31,211,95,192,56,28,24,251,68,238,57,128,225,214,238,212,201,50,14,155,204,198,75,211,234,12,86,201,36,189,208,42,57,220,9,134,197,140,197,72,15,81,164,245,89,204,105,64,190,182,131,19,65,41,78,58,54,231,252,244,96,236,107,245,91,96,124,185,37,191,220,46,14,134,196,62,49,123,14,72,68,25,53,251,163,193,228,192,126,242,157,2,98,172,37,148,152,77,140,217,163,181,187,15,81,201,212,46,132,84,248,230,206,21,6,45,100,1,207,195,101,5,54,11,105,89,75,250,15,144,56,63,58,63,93,252,126,61,163,110,51,11,227,130,205,130,46,79,184,245,65,195,111,13,77,105,214,143,151,172,189,88,191,62,204,102,222,169,180,211,188,13,88,231,64,73,23,35,57,39,139,77,43,22,248,66,203,120,153,109,226,58,9,239,102,78,5,222,47,114,102,17,41,3,112,96,169,96,84,89,171,184,186,60,186,220,5,223,249,209,59,186,30,181,243,121,219,245,87,179,73,127,115,242,186,35,236,41,143,58,74,109,151,71,167,121,163,224,127,42,139,169,195,149,197,162,12,70,184,154,33,32,12,204,132,229,138,84,174,17,66,29,98,81,78,201,82,228,46,48,145,180,45,209,59,72,66,38,208,200,25,134,11,89,53,96,144,42,229,28,130,78,229,17,48,183,104,29,30,186,203,213,63,69,80,222,105,95,22,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7fd90c57d4e44518bdf167e8684604dc",
							"BaseElements.AddDataUserTask2.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("60bd7cb9-5552-477e-bfa8-05d8b60538bb");
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

		public OpportunityManagementFinance(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityManagementFinance";
			SchemaUId = new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc");
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
				return new Guid("7fd90c57-d4e4-4518-bdf1-67e8684604dc");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: OpportunityManagementFinance, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: OpportunityManagementFinance, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public virtual Guid Presentation {
			get;
			set;
		}

		public virtual Guid MainContact {
			get;
			set;
		}

		public virtual Guid Account {
			get;
			set;
		}

		public virtual bool IsStageChangedByUser {
			get;
			set;
		}

		public virtual int ClientOpportunityCount {
			get;
			set;
		}

		public virtual string OpportunityTitle {
			get;
			set;
		}

		public virtual Guid Contact {
			get;
			set;
		}

		public virtual string ClientName {
			get;
			set;
		}

		private ProcessOpportunityMangementProcess _opportunityMangementProcess;
		public ProcessOpportunityMangementProcess OpportunityMangementProcess {
			get {
				return _opportunityMangementProcess ?? ((_opportunityMangementProcess) = new ProcessOpportunityMangementProcess(UserConnection, this));
			}
		}

		private ReadOppDataFlowElement _readOppData;
		public ReadOppDataFlowElement ReadOppData {
			get {
				return _readOppData ?? (_readOppData = new ReadOppDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _opportunityStage;
		public ProcessExclusiveGateway OpportunityStage {
			get {
				return _opportunityStage ?? (_opportunityStage = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "OpportunityStage",
					SchemaElementUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.OpportunityStage.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProspectingFlowElement _prospecting;
		public ProspectingFlowElement Prospecting {
			get {
				return _prospecting ?? ((_prospecting) = new ProspectingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminate3;
		public ProcessTerminateEvent Terminate3 {
			get {
				return _terminate3 ?? (_terminate3 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate3",
					SchemaElementUId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private NeedsAnalysisFlowElement _needsAnalysis;
		public NeedsAnalysisFlowElement NeedsAnalysis {
			get {
				return _needsAnalysis ?? ((_needsAnalysis) = new NeedsAnalysisFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementValuePpropositionFlowElement _oppManagementValuePproposition;
		public OppManagementValuePpropositionFlowElement OppManagementValuePproposition {
			get {
				return _oppManagementValuePproposition ?? ((_oppManagementValuePproposition) = new OppManagementValuePpropositionFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IdDecisionMakersFlowElement _idDecisionMakers;
		public IdDecisionMakersFlowElement IdDecisionMakers {
			get {
				return _idDecisionMakers ?? ((_idDecisionMakers) = new IdDecisionMakersFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementPerceptionAnalysisFlowElement _oppManagementPerceptionAnalysis;
		public OppManagementPerceptionAnalysisFlowElement OppManagementPerceptionAnalysis {
			get {
				return _oppManagementPerceptionAnalysis ?? ((_oppManagementPerceptionAnalysis) = new OppManagementPerceptionAnalysisFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementProposalFlowElement _oppManagementProposal;
		public OppManagementProposalFlowElement OppManagementProposal {
			get {
				return _oppManagementProposal ?? ((_oppManagementProposal) = new OppManagementProposalFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementNegotiationsFlowElement _oppManagementNegotiations;
		public OppManagementNegotiationsFlowElement OppManagementNegotiations {
			get {
				return _oppManagementNegotiations ?? ((_oppManagementNegotiations) = new OppManagementNegotiationsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementContractationFlowElement _oppManagementContractation;
		public OppManagementContractationFlowElement OppManagementContractation {
			get {
				return _oppManagementContractation ?? ((_oppManagementContractation) = new OppManagementContractationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementEndStageFlowElement _oppManagementEndStage;
		public OppManagementEndStageFlowElement OppManagementEndStage {
			get {
				return _oppManagementEndStage ?? ((_oppManagementEndStage) = new OppManagementEndStageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
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

		private FindPresentationFlowElement _findPresentation;
		public FindPresentationFlowElement FindPresentation {
			get {
				return _findPresentation ?? (_findPresentation = new FindPresentationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _savePresentationParameter2;
		public ProcessScriptTask SavePresentationParameter2 {
			get {
				return _savePresentationParameter2 ?? (_savePresentationParameter2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SavePresentationParameter2",
					SchemaElementUId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SavePresentationParameter2Execute,
				});
			}
		}

		private LinkOppToProcessFlowElement _linkOppToProcess;
		public LinkOppToProcessFlowElement LinkOppToProcess {
			get {
				return _linkOppToProcess ?? (_linkOppToProcess = new LinkOppToProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadOppMainContactFlowElement _readOppMainContact;
		public ReadOppMainContactFlowElement ReadOppMainContact {
			get {
				return _readOppMainContact ?? (_readOppMainContact = new ReadOppMainContactFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _saveMainContactParameter;
		public ProcessScriptTask SaveMainContactParameter {
			get {
				return _saveMainContactParameter ?? (_saveMainContactParameter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SaveMainContactParameter",
					SchemaElementUId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SaveMainContactParameterExecute,
				});
			}
		}

		private ProcessStartSignalEvent _startSignalLeadStageChange;
		public ProcessStartSignalEvent StartSignalLeadStageChange {
			get {
				return _startSignalLeadStageChange ?? (_startSignalLeadStageChange = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignalLeadStageChange",
					SerializeToDB = false,
					IsLogging = false,
					SchemaElementUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessFlowElement _startOppBusinessProcess;
		public ProcessFlowElement StartOppBusinessProcess {
			get {
				return _startOppBusinessProcess ?? (_startOppBusinessProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartOppBusinessProcess",
					SchemaElementUId = new Guid("cc1b7702-073c-45cc-926b-05e107a8fd30"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4;
		public ProcessExclusiveGateway ExclusiveGateway4 {
			get {
				return _exclusiveGateway4 ?? (_exclusiveGateway4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4",
					SchemaElementUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminate4;
		public ProcessTerminateEvent Terminate4 {
			get {
				return _terminate4 ?? (_terminate4 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate4",
					SchemaElementUId = new Guid("129d65ec-f59b-44af-b1d6-cda0a6b4ff21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ProcessScriptTask _storeIsStageChangedByUser;
		public ProcessScriptTask StoreIsStageChangedByUser {
			get {
				return _storeIsStageChangedByUser ?? (_storeIsStageChangedByUser = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "StoreIsStageChangedByUser",
					SchemaElementUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = StoreIsStageChangedByUserExecute,
				});
			}
		}

		private ProcessScriptTask _resetIsStageChangedByUser;
		public ProcessScriptTask ResetIsStageChangedByUser {
			get {
				return _resetIsStageChangedByUser ?? (_resetIsStageChangedByUser = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "ResetIsStageChangedByUser",
					SchemaElementUId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ResetIsStageChangedByUserExecute,
				});
			}
		}

		private ReadDataLeadFlowElement _readDataLead;
		public ReadDataLeadFlowElement ReadDataLead {
			get {
				return _readDataLead ?? (_readDataLead = new ReadDataLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataLeadFlowElement _changeDataLead;
		public ChangeDataLeadFlowElement ChangeDataLead {
			get {
				return _changeDataLead ?? (_changeDataLead = new ChangeDataLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewaySetDateTimePresentation;
		public ProcessExclusiveGateway ExclusiveGatewaySetDateTimePresentation {
			get {
				return _exclusiveGatewaySetDateTimePresentation ?? (_exclusiveGatewaySetDateTimePresentation = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewaySetDateTimePresentation",
					SchemaElementUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewaySetDateTimePresentation.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminate2;
		public ProcessTerminateEvent Terminate2 {
			get {
				return _terminate2 ?? (_terminate2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate2",
					SchemaElementUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AddDataContactToOpportunityFlowElement _addDataContactToOpportunity;
		public AddDataContactToOpportunityFlowElement AddDataContactToOpportunity {
			get {
				return _addDataContactToOpportunity ?? (_addDataContactToOpportunity = new AddDataContactToOpportunityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayLeadQualifiedAsContact;
		public ProcessExclusiveGateway ExclusiveGatewayLeadQualifiedAsContact {
			get {
				return _exclusiveGatewayLeadQualifiedAsContact ?? (_exclusiveGatewayLeadQualifiedAsContact = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayLeadQualifiedAsContact",
					SchemaElementUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayLeadQualifiedAsContact.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private AddDataOpportunityFlowElement _addDataOpportunity;
		public AddDataOpportunityFlowElement AddDataOpportunity {
			get {
				return _addDataOpportunity ?? (_addDataOpportunity = new AddDataOpportunityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataCountOpportunityByAccountFlowElement _readDataCountOpportunityByAccount;
		public ReadDataCountOpportunityByAccountFlowElement ReadDataCountOpportunityByAccount {
			get {
				return _readDataCountOpportunityByAccount ?? (_readDataCountOpportunityByAccount = new ReadDataCountOpportunityByAccountFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataAccountFlowElement _readDataAccount;
		public ReadDataAccountFlowElement ReadDataAccount {
			get {
				return _readDataAccount ?? (_readDataAccount = new ReadDataAccountFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTaskAccountByLead;
		public ProcessScriptTask FormulaTaskAccountByLead {
			get {
				return _formulaTaskAccountByLead ?? (_formulaTaskAccountByLead = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTaskAccountByLead",
					SchemaElementUId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTaskAccountByLeadExecute,
				});
			}
		}

		private ReadDataContactFlowElement _readDataContact;
		public ReadDataContactFlowElement ReadDataContact {
			get {
				return _readDataContact ?? (_readDataContact = new ReadDataContactFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayQualifiedByAccount;
		public ProcessExclusiveGateway ExclusiveGatewayQualifiedByAccount {
			get {
				return _exclusiveGatewayQualifiedByAccount ?? (_exclusiveGatewayQualifiedByAccount = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayQualifiedByAccount",
					SchemaElementUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayQualifiedByAccount.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _saveCurrOppParameter;
		public ProcessScriptTask SaveCurrOppParameter {
			get {
				return _saveCurrOppParameter ?? (_saveCurrOppParameter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SaveCurrOppParameter",
					SchemaElementUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SaveCurrOppParameterExecute,
				});
			}
		}

		private PresentationTaskCreationFlowElement _presentationTaskCreation;
		public PresentationTaskCreationFlowElement PresentationTaskCreation {
			get {
				return _presentationTaskCreation ?? (_presentationTaskCreation = new PresentationTaskCreationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _savePresentationParameter;
		public ProcessScriptTask SavePresentationParameter {
			get {
				return _savePresentationParameter ?? (_savePresentationParameter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SavePresentationParameter",
					SchemaElementUId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SavePresentationParameterExecute,
				});
			}
		}

		private ReadOppoortunityData2FlowElement _readOppoortunityData2;
		public ReadOppoortunityData2FlowElement ReadOppoortunityData2 {
			get {
				return _readOppoortunityData2 ?? (_readOppoortunityData2 = new ReadOppoortunityData2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
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

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask3;
		public ProcessScriptTask FormulaTask3 {
			get {
				return _formulaTask3 ?? (_formulaTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask3",
					SchemaElementUId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask4;
		public ProcessScriptTask FormulaTask4 {
			get {
				return _formulaTask4 ?? (_formulaTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask4",
					SchemaElementUId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask4Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask5;
		public ProcessScriptTask FormulaTask5 {
			get {
				return _formulaTask5 ?? (_formulaTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask5",
					SchemaElementUId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask5Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask6;
		public ProcessScriptTask FormulaTask6 {
			get {
				return _formulaTask6 ?? (_formulaTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask6",
					SchemaElementUId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask6Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask7;
		public ProcessScriptTask FormulaTask7 {
			get {
				return _formulaTask7 ?? (_formulaTask7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask7",
					SchemaElementUId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask7Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask8;
		public ProcessScriptTask FormulaTask8 {
			get {
				return _formulaTask8 ?? (_formulaTask8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask8",
					SchemaElementUId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask8Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask9;
		public ProcessScriptTask FormulaTask9 {
			get {
				return _formulaTask9 ?? (_formulaTask9 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask9",
					SchemaElementUId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask9Execute,
				});
			}
		}

		private AddDataUserTask2FlowElement _addDataUserTask2;
		public AddDataUserTask2FlowElement AddDataUserTask2 {
			get {
				return _addDataUserTask2 ?? (_addDataUserTask2 = new AddDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _prospectingStage;
		public ProcessConditionalFlow ProspectingStage {
			get {
				return _prospectingStage ?? (_prospectingStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ProspectingStage",
					SchemaElementUId = new Guid("6da9cfcb-81e5-48a4-a1c1-42a6279225e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _needAnalysisStage;
		public ProcessConditionalFlow NeedAnalysisStage {
			get {
				return _needAnalysisStage ?? (_needAnalysisStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "NeedAnalysisStage",
					SchemaElementUId = new Guid("9301d50a-6c5b-4489-badd-4a28230234ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _valueProposition;
		public ProcessConditionalFlow ValueProposition {
			get {
				return _valueProposition ?? (_valueProposition = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ValueProposition",
					SchemaElementUId = new Guid("bb42fb47-5fbd-4f77-af1e-ce351db4f8f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _decisionMakers;
		public ProcessConditionalFlow DecisionMakers {
			get {
				return _decisionMakers ?? (_decisionMakers = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "DecisionMakers",
					SchemaElementUId = new Guid("f094c232-c29e-46d1-86fc-2e61dcac8e07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _perceptionAnalysisStage;
		public ProcessConditionalFlow PerceptionAnalysisStage {
			get {
				return _perceptionAnalysisStage ?? (_perceptionAnalysisStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "PerceptionAnalysisStage",
					SchemaElementUId = new Guid("90dc5cd4-a514-48c4-9705-1babb54dc9a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _negotiationsStage;
		public ProcessConditionalFlow NegotiationsStage {
			get {
				return _negotiationsStage ?? (_negotiationsStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "NegotiationsStage",
					SchemaElementUId = new Guid("3b93fd4b-c4ce-43ef-81de-d70f18e28cd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _contractationStage;
		public ProcessConditionalFlow ContractationStage {
			get {
				return _contractationStage ?? (_contractationStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContractationStage",
					SchemaElementUId = new Guid("97b5d2a4-5ab3-4fb5-9544-7ee6933c7e5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _proposalStage;
		public ProcessConditionalFlow ProposalStage {
			get {
				return _proposalStage ?? (_proposalStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ProposalStage",
					SchemaElementUId = new Guid("94b519f4-4f88-4966-9c23-8a451496a11b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("b131dc29-103b-498c-8cad-b0267ae02df9"),
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
					SchemaElementUId = new Guid("656a4a04-8b53-40cb-9fe2-d14c1a49db28"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow8;
		public ProcessConditionalFlow ConditionalFlow8 {
			get {
				return _conditionalFlow8 ?? (_conditionalFlow8 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow8",
					SchemaElementUId = new Guid("12da4680-7947-44ac-bce4-174e2ea3d434"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow10;
		public ProcessConditionalFlow ConditionalFlow10 {
			get {
				return _conditionalFlow10 ?? (_conditionalFlow10 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow10",
					SchemaElementUId = new Guid("fe99e954-54c6-4dbc-ae4e-724f11084d1e"),
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
					SchemaElementUId = new Guid("6f012dc4-0679-4da3-84ce-757680848a3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("e1fae17b-971d-469e-82c9-0d8f1161f09b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow11;
		public ProcessConditionalFlow ConditionalFlow11 {
			get {
				return _conditionalFlow11 ?? (_conditionalFlow11 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow11",
					SchemaElementUId = new Guid("aff117cc-494a-447b-824c-ea45bf0c048a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow12;
		public ProcessConditionalFlow ConditionalFlow12 {
			get {
				return _conditionalFlow12 ?? (_conditionalFlow12 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow12",
					SchemaElementUId = new Guid("b3fa892c-1d0a-4e76-a01e-553b47b9714a"),
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
					SchemaElementUId = new Guid("483624cb-e100-4417-b0d7-2d89990301bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow5;
		public ProcessConditionalFlow ConditionalFlow5 {
			get {
				return _conditionalFlow5 ?? (_conditionalFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow5",
					SchemaElementUId = new Guid("e9f42fb2-6bda-464a-8a5a-cfb4b9ca50b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _opportunityStageProspectingToken;
		public ProcessToken OpportunityStageProspectingToken {
			get {
				return _opportunityStageProspectingToken ?? (_opportunityStageProspectingToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageProspectingToken",
					SchemaElementUId = new Guid("96d1e9e6-c039-4489-9969-fb941fb8556d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageNeedsAnalysisToken;
		public ProcessToken OpportunityStageNeedsAnalysisToken {
			get {
				return _opportunityStageNeedsAnalysisToken ?? (_opportunityStageNeedsAnalysisToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageNeedsAnalysisToken",
					SchemaElementUId = new Guid("c4bec1a2-7112-4936-a6eb-40b4304feac6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementValuePpropositionToken;
		public ProcessToken OpportunityStageOppManagementValuePpropositionToken {
			get {
				return _opportunityStageOppManagementValuePpropositionToken ?? (_opportunityStageOppManagementValuePpropositionToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementValuePpropositionToken",
					SchemaElementUId = new Guid("e40ccd98-4d34-4985-b330-55bcc78b8bea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageIdDecisionMakersToken;
		public ProcessToken OpportunityStageIdDecisionMakersToken {
			get {
				return _opportunityStageIdDecisionMakersToken ?? (_opportunityStageIdDecisionMakersToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageIdDecisionMakersToken",
					SchemaElementUId = new Guid("91539453-3f81-4a55-8662-7af9b571926b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementPerceptionAnalysisToken;
		public ProcessToken OpportunityStageOppManagementPerceptionAnalysisToken {
			get {
				return _opportunityStageOppManagementPerceptionAnalysisToken ?? (_opportunityStageOppManagementPerceptionAnalysisToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementPerceptionAnalysisToken",
					SchemaElementUId = new Guid("bfdca54c-eba4-4b71-87b7-0f768125c981"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementProposalToken;
		public ProcessToken OpportunityStageOppManagementProposalToken {
			get {
				return _opportunityStageOppManagementProposalToken ?? (_opportunityStageOppManagementProposalToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementProposalToken",
					SchemaElementUId = new Guid("dc26a94f-949f-41c0-acff-6d2ad59d192d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementNegotiationsToken;
		public ProcessToken OpportunityStageOppManagementNegotiationsToken {
			get {
				return _opportunityStageOppManagementNegotiationsToken ?? (_opportunityStageOppManagementNegotiationsToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementNegotiationsToken",
					SchemaElementUId = new Guid("4e8ec52c-84e0-483d-ab77-7f8a469dd4ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementContractationToken;
		public ProcessToken OpportunityStageOppManagementContractationToken {
			get {
				return _opportunityStageOppManagementContractationToken ?? (_opportunityStageOppManagementContractationToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementContractationToken",
					SchemaElementUId = new Guid("ae6ea71e-a2e0-4b5f-8233-4d4097dd639a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _storeIsStageChangedByUserOppManagementEndStageToken;
		public ProcessToken StoreIsStageChangedByUserOppManagementEndStageToken {
			get {
				return _storeIsStageChangedByUserOppManagementEndStageToken ?? (_storeIsStageChangedByUserOppManagementEndStageToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "StoreIsStageChangedByUserOppManagementEndStageToken",
					SchemaElementUId = new Guid("204fe312-eb8a-4549-b983-d13d45653200"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ReadOppData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOppData };
			FlowElements[OpportunityStage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStage };
			FlowElements[Prospecting.SchemaElementUId] = new Collection<ProcessFlowElement> { Prospecting };
			FlowElements[Terminate3.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate3 };
			FlowElements[NeedsAnalysis.SchemaElementUId] = new Collection<ProcessFlowElement> { NeedsAnalysis };
			FlowElements[OppManagementValuePproposition.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementValuePproposition };
			FlowElements[IdDecisionMakers.SchemaElementUId] = new Collection<ProcessFlowElement> { IdDecisionMakers };
			FlowElements[OppManagementPerceptionAnalysis.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementPerceptionAnalysis };
			FlowElements[OppManagementProposal.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementProposal };
			FlowElements[OppManagementNegotiations.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementNegotiations };
			FlowElements[OppManagementContractation.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementContractation };
			FlowElements[OppManagementEndStage.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementEndStage };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[FindPresentation.SchemaElementUId] = new Collection<ProcessFlowElement> { FindPresentation };
			FlowElements[SavePresentationParameter2.SchemaElementUId] = new Collection<ProcessFlowElement> { SavePresentationParameter2 };
			FlowElements[LinkOppToProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkOppToProcess };
			FlowElements[ReadOppMainContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOppMainContact };
			FlowElements[SaveMainContactParameter.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveMainContactParameter };
			FlowElements[StartSignalLeadStageChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignalLeadStageChange };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[StartOppBusinessProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartOppBusinessProcess };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[ExclusiveGateway4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4 };
			FlowElements[Terminate4.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate4 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[StoreIsStageChangedByUser.SchemaElementUId] = new Collection<ProcessFlowElement> { StoreIsStageChangedByUser };
			FlowElements[ResetIsStageChangedByUser.SchemaElementUId] = new Collection<ProcessFlowElement> { ResetIsStageChangedByUser };
			FlowElements[ReadDataLead.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataLead };
			FlowElements[ChangeDataLead.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataLead };
			FlowElements[ExclusiveGatewaySetDateTimePresentation.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewaySetDateTimePresentation };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[AddDataContactToOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataContactToOpportunity };
			FlowElements[ExclusiveGatewayLeadQualifiedAsContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayLeadQualifiedAsContact };
			FlowElements[AddDataOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataOpportunity };
			FlowElements[ReadDataCountOpportunityByAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataCountOpportunityByAccount };
			FlowElements[ReadDataAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataAccount };
			FlowElements[FormulaTaskAccountByLead.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTaskAccountByLead };
			FlowElements[ReadDataContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataContact };
			FlowElements[ExclusiveGatewayQualifiedByAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayQualifiedByAccount };
			FlowElements[SaveCurrOppParameter.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveCurrOppParameter };
			FlowElements[PresentationTaskCreation.SchemaElementUId] = new Collection<ProcessFlowElement> { PresentationTaskCreation };
			FlowElements[SavePresentationParameter.SchemaElementUId] = new Collection<ProcessFlowElement> { SavePresentationParameter };
			FlowElements[ReadOppoortunityData2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOppoortunityData2 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
			FlowElements[FormulaTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask5 };
			FlowElements[FormulaTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask6 };
			FlowElements[FormulaTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask7 };
			FlowElements[FormulaTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask8 };
			FlowElements[FormulaTask9.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask9 };
			FlowElements[AddDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask2 };
			FlowElements[OpportunityStageProspectingToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageProspectingToken };
			FlowElements[OpportunityStageNeedsAnalysisToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageNeedsAnalysisToken };
			FlowElements[OpportunityStageOppManagementValuePpropositionToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementValuePpropositionToken };
			FlowElements[OpportunityStageIdDecisionMakersToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageIdDecisionMakersToken };
			FlowElements[OpportunityStageOppManagementPerceptionAnalysisToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementPerceptionAnalysisToken };
			FlowElements[OpportunityStageOppManagementProposalToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementProposalToken };
			FlowElements[OpportunityStageOppManagementNegotiationsToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementNegotiationsToken };
			FlowElements[OpportunityStageOppManagementContractationToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementContractationToken };
			FlowElements[StoreIsStageChangedByUserOppManagementEndStageToken.SchemaElementUId] = new Collection<ProcessFlowElement> { StoreIsStageChangedByUserOppManagementEndStageToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ReadOppData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppMainContact", e.Context.SenderName));
						break;
					case "OpportunityStage":
						if (ProspectingStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageProspectingToken", e.Context.SenderName));
							break;
						}
						if (NeedAnalysisStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageNeedsAnalysisToken", e.Context.SenderName));
							break;
						}
						if (ValuePropositionExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementValuePpropositionToken", e.Context.SenderName));
							break;
						}
						if (DecisionMakersExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageIdDecisionMakersToken", e.Context.SenderName));
							break;
						}
						if (PerceptionAnalysisStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementPerceptionAnalysisToken", e.Context.SenderName));
							break;
						}
						if (NegotiationsStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementNegotiationsToken", e.Context.SenderName));
							break;
						}
						if (ContractationStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementContractationToken", e.Context.SenderName));
							break;
						}
						if (ProposalStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementProposalToken", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate3", e.Context.SenderName));
						break;
					case "Prospecting":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "Terminate3":
						CompleteProcess();
						break;
					case "NeedsAnalysis":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementValuePproposition":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "IdDecisionMakers":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementPerceptionAnalysis":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementProposal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementNegotiations":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementContractation":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate3", e.Context.SenderName));
						break;
					case "OppManagementEndStage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppData", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FindPresentation", e.Context.SenderName));
						break;
					case "FindPresentation":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SavePresentationParameter2", e.Context.SenderName));
						break;
					case "SavePresentationParameter2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
						break;
					case "LinkOppToProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppData", e.Context.SenderName));
						break;
					case "ReadOppMainContact":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveMainContactParameter", e.Context.SenderName));
						break;
					case "SaveMainContactParameter":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ResetIsStageChangedByUser", e.Context.SenderName));
						break;
					case "StartSignalLeadStageChange":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow11ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "StartOppBusinessProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway4", e.Context.SenderName));
						break;
					case "ExclusiveGateway4":
						if (ConditionalFlow12ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate4", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "Terminate4":
						CompleteProcess();
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "StoreIsStageChangedByUser":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUserOppManagementEndStageToken", e.Context.SenderName));
						break;
					case "ResetIsStageChangedByUser":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStage", e.Context.SenderName));
						break;
					case "ReadDataLead":
						if (ConditionalFlow7ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayQualifiedByAccount", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "ChangeDataLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewaySetDateTimePresentation", e.Context.SenderName));
						break;
					case "ExclusiveGatewaySetDateTimePresentation":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PresentationTaskCreation", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveCurrOppParameter", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "AddDataContactToOpportunity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppoortunityData2", e.Context.SenderName));
						break;
					case "ExclusiveGatewayLeadQualifiedAsContact":
						if (ConditionalFlow10ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataContactToOpportunity", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppoortunityData2", e.Context.SenderName));
						break;
					case "AddDataOpportunity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataCountOpportunityByAccount":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "ReadDataAccount":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask5", e.Context.SenderName));
						break;
					case "FormulaTaskAccountByLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataAccount", e.Context.SenderName));
						break;
					case "ReadDataContact":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask6", e.Context.SenderName));
						break;
					case "ExclusiveGatewayQualifiedByAccount":
						if (ConditionalFlow8ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTaskAccountByLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "SaveCurrOppParameter":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "PresentationTaskCreation":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SavePresentationParameter", e.Context.SenderName));
						break;
					case "SavePresentationParameter":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveCurrOppParameter", e.Context.SenderName));
						break;
					case "ReadOppoortunityData2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataLead", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow5ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask7", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask8", e.Context.SenderName));
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask9", e.Context.SenderName));
						break;
					case "FormulaTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataCountOpportunityByAccount", e.Context.SenderName));
						break;
					case "FormulaTask6":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "FormulaTask7":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataContact", e.Context.SenderName));
						break;
					case "FormulaTask8":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataOpportunity", e.Context.SenderName));
						break;
					case "FormulaTask9":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataOpportunity", e.Context.SenderName));
						break;
					case "AddDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayLeadQualifiedAsContact", e.Context.SenderName));
						break;
					case "OpportunityStageProspectingToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Prospecting", e.Context.SenderName));
						break;
					case "OpportunityStageNeedsAnalysisToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("NeedsAnalysis", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementValuePpropositionToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementValuePproposition", e.Context.SenderName));
						break;
					case "OpportunityStageIdDecisionMakersToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IdDecisionMakers", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementPerceptionAnalysisToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementPerceptionAnalysis", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementProposalToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementProposal", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementNegotiationsToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementNegotiations", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementContractationToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementContractation", e.Context.SenderName));
						break;
					case "StoreIsStageChangedByUserOppManagementEndStageToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementEndStage", e.Context.SenderName));
						break;
			}
		}

		private bool ProspectingStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("c2067b11-0ee0-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ProspectingStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"c2067b11-0ee0-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool NeedAnalysisStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("2a6de0f7-44d9-4b8a-bce6-acddb7ed8915"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "NeedAnalysisStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"2a6de0f7-44d9-4b8a-bce6-acddb7ed8915\")", result);
			return result;
		}

		private bool ValuePropositionExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("325f0619-0ee0-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ValueProposition", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"325f0619-0ee0-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool DecisionMakersExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("f4e4a00b-ec48-46d0-9ea0-c2b502165ee9"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "DecisionMakers", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"f4e4a00b-ec48-46d0-9ea0-c2b502165ee9\")", result);
			return result;
		}

		private bool PerceptionAnalysisStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("241ade6b-4256-4947-ba8a-7d96988a97b6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "PerceptionAnalysisStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"241ade6b-4256-4947-ba8a-7d96988a97b6\")", result);
			return result;
		}

		private bool NegotiationsStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("f808c955-c5aa-4aba-95c0-ba7d584d2f32"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "NegotiationsStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"f808c955-c5aa-4aba-95c0-ba7d584d2f32\")", result);
			return result;
		}

		private bool ContractationStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("fb563df2-5ae6-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ContractationStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"fb563df2-5ae6-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool ProposalStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("423774cb-5ae6-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ProposalStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"423774cb-5ae6-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((CurrentOpportunity) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalFlow1", "(CurrentOpportunity) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((FindPresentation.ResultEntityCollection).Count == 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "FindPresentation", "ConditionalFlow2", "(FindPresentation.ResultEntityCollection).Count == 0", result);
			return result;
		}

		private bool ConditionalFlow8ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayQualifiedByAccount", "ConditionalFlow8", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"QualifiedAccount\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"QualifiedAccountId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow10ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayLeadQualifiedAsContact", "ConditionalFlow10", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"QualifiedContact\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"QualifiedContactId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))) != null && !DateTime.MinValue.Equals(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture)))));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewaySetDateTimePresentation", "ConditionalFlow4", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"MeetingDate\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>(\"MeetingDate\") : DateTime.ParseExact(\"01.01.0001 0:00\", \"dd.MM.yyyy H:mm\", CultureInfo.InvariantCulture))) != null && !DateTime.MinValue.Equals(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"MeetingDate\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>(\"MeetingDate\") : DateTime.ParseExact(\"01.01.0001 0:00\", \"dd.MM.yyyy H:mm\", CultureInfo.InvariantCulture))))", result);
			return result;
		}

		private bool ConditionalFlow7ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("Opportunity").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("OpportunityId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataLead", "ConditionalFlow7", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"Opportunity\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"OpportunityId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow11ExpressionExecute() {
			bool result = Convert.ToBoolean(((Boolean)SysSettings.GetValue(UserConnection, "StartOppBusinessProcessFinance")) == true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway3", "ConditionalFlow11", "((Boolean)SysSettings.GetValue(UserConnection, \"StartOppBusinessProcessFinance\")) == true", result);
			return result;
		}

		private bool ConditionalFlow12ExpressionExecute() {
			bool result = Convert.ToBoolean((OpenEditPageUserTask1.RecordId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway4", "ConditionalFlow12", "(OpenEditPageUserTask1.RecordId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadDataUserTask1.ResultCount) == 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow3", "(ReadDataUserTask1.ResultCount) == 0", result);
			return result;
		}

		private bool ConditionalFlow5ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty))  != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow5", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"QualifiedContact\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"QualifiedContactId\") : Guid.Empty))  != Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("Presentation")) {
				writer.WriteValue("Presentation", Presentation, Guid.Empty);
			}
			if (!HasMapping("MainContact")) {
				writer.WriteValue("MainContact", MainContact, Guid.Empty);
			}
			if (!HasMapping("Account")) {
				writer.WriteValue("Account", Account, Guid.Empty);
			}
			if (!HasMapping("IsStageChangedByUser")) {
				writer.WriteValue("IsStageChangedByUser", IsStageChangedByUser, false);
			}
			if (!HasMapping("ClientOpportunityCount")) {
				writer.WriteValue("ClientOpportunityCount", ClientOpportunityCount, 0);
			}
			if (!HasMapping("OpportunityTitle")) {
				writer.WriteValue("OpportunityTitle", OpportunityTitle, null);
			}
			if (!HasMapping("Contact")) {
				writer.WriteValue("Contact", Contact, Guid.Empty);
			}
			if (!HasMapping("ClientName")) {
				writer.WriteValue("ClientName", ClientName, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartOppBusinessProcess", string.Empty));
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
			MetaPathParameterValues.Add("af8eea9e-0e11-426e-a870-2cff33d00f84", () => CurrentOpportunity);
			MetaPathParameterValues.Add("0eae6fcc-65b6-433e-b4dc-e42323c488c1", () => Presentation);
			MetaPathParameterValues.Add("b8d6c762-b63e-49b7-b651-c8d29f9c8d74", () => MainContact);
			MetaPathParameterValues.Add("342aec56-8359-4c5b-826b-9e8489fd6a4b", () => Account);
			MetaPathParameterValues.Add("9786c0e4-cc5f-4c9f-b46d-090a297e2b74", () => IsStageChangedByUser);
			MetaPathParameterValues.Add("02b1469d-72ad-4909-a7cf-6b41b79d41a7", () => ClientOpportunityCount);
			MetaPathParameterValues.Add("738ceb61-832b-4b27-a973-9347e26e827e", () => OpportunityTitle);
			MetaPathParameterValues.Add("b6534525-3848-4420-8930-e7bcc98a1756", () => Contact);
			MetaPathParameterValues.Add("b2b54e53-5309-4650-ac67-b8a4705d22b4", () => ClientName);
			MetaPathParameterValues.Add("378a7c4d-c2ae-4dc0-8450-7d00de21889a", () => ReadOppData.DataSourceFilters);
			MetaPathParameterValues.Add("09ca5d94-4475-494b-bb1d-1711734825d0", () => ReadOppData.ResultType);
			MetaPathParameterValues.Add("809504a0-92ba-4c37-9223-2bd86178ceeb", () => ReadOppData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("47e4b981-ae34-43d6-80d1-541eb76f8886", () => ReadOppData.NumberOfRecords);
			MetaPathParameterValues.Add("093cfd0d-3919-4594-bdbd-243b89c2421c", () => ReadOppData.FunctionType);
			MetaPathParameterValues.Add("99a55b65-320e-4a00-a443-906ccbd17195", () => ReadOppData.AggregationColumnName);
			MetaPathParameterValues.Add("ea0a8aa9-15cc-4e7b-b857-0fde66046c9d", () => ReadOppData.OrderInfo);
			MetaPathParameterValues.Add("61d6f451-48d9-4c96-917b-f6c5ce85df83", () => ReadOppData.ResultEntity);
			MetaPathParameterValues.Add("10ddcd85-ccf7-42e5-8390-78074cc70ded", () => ReadOppData.ResultCount);
			MetaPathParameterValues.Add("c1248569-3f8c-43f3-9cb3-48975e8f84ef", () => ReadOppData.ResultIntegerFunction);
			MetaPathParameterValues.Add("3feedf55-86a5-4ac5-bb7d-a85d1a84eb9d", () => ReadOppData.ResultFloatFunction);
			MetaPathParameterValues.Add("734b2f72-a22c-41d7-900f-06d5bb7faf75", () => ReadOppData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("d60364bd-0961-431f-8a33-c5f616c3de09", () => ReadOppData.ResultRowsCount);
			MetaPathParameterValues.Add("5fc444a5-9b7a-422c-8693-86213fa317e7", () => ReadOppData.CanReadUncommitedData);
			MetaPathParameterValues.Add("e4513fe5-860a-4300-889d-38b3328e8894", () => ReadOppData.ResultEntityCollection);
			MetaPathParameterValues.Add("adee94c3-29c5-4b7a-960c-20c6b71d3afb", () => ReadOppData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("454dc5b0-a0d3-4a3d-b852-62380501a11c", () => ReadOppData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d3cf0def-09ec-4121-be55-a5dbeabb5df1", () => ReadOppData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("68831c61-87cd-4367-9e6c-9a1e1ff5c10a", () => ReadOppData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("81432db0-f5f5-40d1-8f22-4d8c3bb4cf48", () => Prospecting.CurrentOpportunity);
			MetaPathParameterValues.Add("eb29a402-5da5-4f9b-844c-e79f4e1f115a", () => Prospecting.OpportunityStageChanged);
			MetaPathParameterValues.Add("fdc628cc-1da4-4b5d-b397-d6c93e1e9517", () => Prospecting.MainContact);
			MetaPathParameterValues.Add("5b443132-caa7-4f82-80dd-cc84a5380caa", () => NeedsAnalysis.CurrentOpportunity);
			MetaPathParameterValues.Add("6a80392b-c787-4788-a532-fca2370b3840", () => NeedsAnalysis.OpportunityStageChanged);
			MetaPathParameterValues.Add("5e47a6d3-f9bb-404f-87e2-aed31c62acc3", () => NeedsAnalysis.MainContact);
			MetaPathParameterValues.Add("4274528b-203f-43bc-87d3-abf86b9a792e", () => OppManagementValuePproposition.CurrentOpportunity);
			MetaPathParameterValues.Add("b20705a6-a8bc-460d-8389-aaaa9b58be16", () => OppManagementValuePproposition.OpportunityStageChanged);
			MetaPathParameterValues.Add("f7d5c580-2ff1-4209-a013-2bef80d7f3a9", () => OppManagementValuePproposition.Presentation);
			MetaPathParameterValues.Add("2a0e89a7-92f6-4cf6-a9f2-a0140105ba95", () => OppManagementValuePproposition.MainContact);
			MetaPathParameterValues.Add("76602486-f8b8-47cb-8b9f-d00841250f90", () => IdDecisionMakers.CurrentOpportunity);
			MetaPathParameterValues.Add("e6028b5e-002d-4bc7-bc34-8affd537f00c", () => IdDecisionMakers.OpportunityStageChanged);
			MetaPathParameterValues.Add("5dc6ce94-0fc5-4ffa-8e00-83c67ce5da35", () => IdDecisionMakers.MainContact);
			MetaPathParameterValues.Add("c647b290-fae9-4f2f-b291-b94262f923dc", () => OppManagementPerceptionAnalysis.CurrentOpportunity);
			MetaPathParameterValues.Add("2d34fbe8-274b-4c6e-88d8-7307f538cfee", () => OppManagementPerceptionAnalysis.OpportunityStageChanged);
			MetaPathParameterValues.Add("36230419-640f-4176-ad85-8beca7d791ca", () => OppManagementPerceptionAnalysis.MainContact);
			MetaPathParameterValues.Add("0a768934-39e6-4d8e-9fd4-4859b59f0779", () => OppManagementProposal.CurrentOpportunity);
			MetaPathParameterValues.Add("2902276d-abfd-4fd2-b6f9-b5bda02f0222", () => OppManagementProposal.OpportunityStageChanged);
			MetaPathParameterValues.Add("dc02a11c-a24c-4451-897b-9dce3a6a7178", () => OppManagementProposal.MainContact);
			MetaPathParameterValues.Add("f58812eb-a5a3-43ef-84a7-454b69c3aaed", () => OppManagementNegotiations.CurrentOpportunity);
			MetaPathParameterValues.Add("33eb9e90-615e-412b-86bf-8d9f6c8831a8", () => OppManagementNegotiations.OpportunityStageChanged);
			MetaPathParameterValues.Add("47d1669f-a6cc-48ac-85b8-94795d69938e", () => OppManagementNegotiations.MainContact);
			MetaPathParameterValues.Add("a2600d6c-144b-4c75-acb3-f04cb1577884", () => OppManagementContractation.CurrentOpportunity);
			MetaPathParameterValues.Add("16815d2d-6357-4be4-9265-46e9a99e093b", () => OppManagementContractation.OpportunityStageChanged);
			MetaPathParameterValues.Add("b812d4a7-16f1-4a13-b2e9-f0b2c48a8532", () => OppManagementContractation.MainContact);
			MetaPathParameterValues.Add("1494d351-8b28-4d15-a088-912b8872f732", () => OppManagementEndStage.CurrentOpportunity);
			MetaPathParameterValues.Add("0fa7431c-1004-411e-ae2e-b485fc040737", () => OppManagementEndStage.NextOpportunityStageNumber);
			MetaPathParameterValues.Add("dcb46392-5cd0-43ba-9004-211ef9690ca5", () => OppManagementEndStage.CurrentStage);
			MetaPathParameterValues.Add("9c2d0712-831e-499c-a94b-562db3eaed86", () => OppManagementEndStage.Recommendation);
			MetaPathParameterValues.Add("2f2941be-b24c-4797-8b31-addbd6057927", () => OppManagementEndStage.IsStageChangedByUser);
			MetaPathParameterValues.Add("ef2201a2-720c-453d-8a5b-62d5077c6041", () => OppManagementEndStage.DontShowPageEndOfStage);
			MetaPathParameterValues.Add("a8f664f6-40f1-4b7e-9602-25265d8962b3", () => OppManagementEndStage.NextStage);
			MetaPathParameterValues.Add("590098f3-05ec-4bc7-ac56-18d861124c44", () => FindPresentation.DataSourceFilters);
			MetaPathParameterValues.Add("d7349ecf-3808-499e-94e5-a6af0b6c8059", () => FindPresentation.ResultType);
			MetaPathParameterValues.Add("3ddba6f3-67f9-46a5-bda4-c9be1d38263b", () => FindPresentation.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7711d045-dde7-4665-b251-2b6cda4ba16c", () => FindPresentation.NumberOfRecords);
			MetaPathParameterValues.Add("14ac52bb-d8de-4e93-ba14-2092314ad9ec", () => FindPresentation.FunctionType);
			MetaPathParameterValues.Add("44ef2079-3350-48f5-8417-a062c43f2a0e", () => FindPresentation.AggregationColumnName);
			MetaPathParameterValues.Add("f79b49c3-44b7-458a-af53-ffc25ba8de44", () => FindPresentation.OrderInfo);
			MetaPathParameterValues.Add("bcd38317-a882-4317-8881-b21b8f0ca57b", () => FindPresentation.ResultEntity);
			MetaPathParameterValues.Add("9371b699-8ba0-411a-be54-7912877edf8f", () => FindPresentation.ResultCount);
			MetaPathParameterValues.Add("ca81fffe-20a5-46bf-ab20-5fa6f0638a5f", () => FindPresentation.ResultIntegerFunction);
			MetaPathParameterValues.Add("6c987b70-a95f-48b9-bcfb-8ddc2192e44a", () => FindPresentation.ResultFloatFunction);
			MetaPathParameterValues.Add("e64f2c49-b461-45e7-bb8f-1f660acca3cc", () => FindPresentation.ResultDateTimeFunction);
			MetaPathParameterValues.Add("b598adf2-e516-42e9-9f34-f99fb251a690", () => FindPresentation.ResultRowsCount);
			MetaPathParameterValues.Add("5b343947-0aa5-4776-9b18-096d905e7603", () => FindPresentation.CanReadUncommitedData);
			MetaPathParameterValues.Add("6f8cde56-f764-4ad1-b528-0d9031cd1e8e", () => FindPresentation.ResultEntityCollection);
			MetaPathParameterValues.Add("6351aab6-3117-48e1-afe4-c9ad827a53d7", () => FindPresentation.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("1fbf3104-1357-48ca-926e-2f85305a4602", () => FindPresentation.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a1185c72-1f88-4782-91cd-14d14087185c", () => FindPresentation.ResultCompositeObjectList);
			MetaPathParameterValues.Add("cd2817ae-fc09-4cca-95f2-d6362651a8e4", () => FindPresentation.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("41befda8-dd24-45a3-8e91-5fa9d9e03fa0", () => LinkOppToProcess.EntityId);
			MetaPathParameterValues.Add("773490bc-4ab0-4078-9f03-a0ead61c8e69", () => LinkOppToProcess.EntitySchemaId);
			MetaPathParameterValues.Add("6ec44add-c3cb-4c83-aa2a-21116fe737ce", () => ReadOppMainContact.DataSourceFilters);
			MetaPathParameterValues.Add("d00d1284-6858-4e40-8c5e-a0f9533fcf07", () => ReadOppMainContact.ResultType);
			MetaPathParameterValues.Add("b0d4d59f-c216-40cc-ae96-8a3781c09399", () => ReadOppMainContact.ReadSomeTopRecords);
			MetaPathParameterValues.Add("e0d7bbe7-f11e-455f-b2e5-ea58c2f931f5", () => ReadOppMainContact.NumberOfRecords);
			MetaPathParameterValues.Add("c886b18d-6796-4aed-9bbf-b5cf5d06a8fb", () => ReadOppMainContact.FunctionType);
			MetaPathParameterValues.Add("57ed4753-40aa-4155-9040-01d05641a1f9", () => ReadOppMainContact.AggregationColumnName);
			MetaPathParameterValues.Add("5f7ffe6c-b419-41a7-92a7-41c7106f2edd", () => ReadOppMainContact.OrderInfo);
			MetaPathParameterValues.Add("7e1be2d8-91ed-49a9-b295-80136f24d052", () => ReadOppMainContact.ResultEntity);
			MetaPathParameterValues.Add("57df5b20-4163-4583-a743-b3bd41e7476c", () => ReadOppMainContact.ResultCount);
			MetaPathParameterValues.Add("36a1459d-8951-4d2d-83c0-ce1785ad17d6", () => ReadOppMainContact.ResultIntegerFunction);
			MetaPathParameterValues.Add("5227d4a1-7e1a-488c-b08f-249e8af25b4f", () => ReadOppMainContact.ResultFloatFunction);
			MetaPathParameterValues.Add("26f8e2e7-d0a5-4cce-a1c4-005d27eac4ef", () => ReadOppMainContact.ResultDateTimeFunction);
			MetaPathParameterValues.Add("a91ced74-aa15-4fc9-ad90-beb2c4848a91", () => ReadOppMainContact.ResultRowsCount);
			MetaPathParameterValues.Add("0597c0d4-7fe9-438b-996d-a1cec2485907", () => ReadOppMainContact.CanReadUncommitedData);
			MetaPathParameterValues.Add("24109401-bfc2-4470-b36d-6264dd15b451", () => ReadOppMainContact.ResultEntityCollection);
			MetaPathParameterValues.Add("213f4da0-dbd4-4801-9f20-61ad02c52c1a", () => ReadOppMainContact.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("14eb509a-8789-4d60-a6db-802311455631", () => ReadOppMainContact.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ce39439e-0507-44c2-ad51-a76f693a3d3c", () => ReadOppMainContact.ResultCompositeObjectList);
			MetaPathParameterValues.Add("81a3e144-a50d-43c1-b259-3b436b1bd4d0", () => ReadOppMainContact.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("db9eb8c4-a431-4aa1-9ee4-580f6ffe1896", () => StartSignalLeadStageChange.RecordId);
			MetaPathParameterValues.Add("e33c0cfe-adc7-4b51-8f8f-370d3a2a3f3d", () => StartSignalLeadStageChange.EntitySchemaUId);
			MetaPathParameterValues.Add("89651dda-ab13-4a9a-8a6c-4c658eb62d6b", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("26dd7e96-d79a-4c1d-a31a-e8388a3d205d", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("816e7c8a-2c10-4a6f-9be0-35eb9c4ddff5", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("97a322a9-f1ca-49d6-ab97-756349dc65dc", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("c5f0d6a4-d18b-446e-8335-18fb080f660a", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("dc433afb-dfc9-4098-97f6-caf21a16f74e", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("1c82493a-8e96-4e42-8e59-0050ff57ccc6", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("933618d4-76fc-43ac-ac72-94ef456a3325", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("0e24948f-5ffc-48eb-8cd6-6290a4458b50", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("41355bca-971c-4003-990e-8da96ce29d27", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("b8971ff1-f4b5-4bd1-ad83-92a56940fda8", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("6399efc5-9d36-4c8d-84c5-3e5851db8ea2", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("c482b777-a1a7-41d8-86f3-3deb50dd0ff8", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("8a4540f5-5964-49f6-9dd1-077938701455", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("4960bd57-b2f9-45a4-9184-feb6f57d727b", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("dbe4def5-6971-4b97-a463-8f91e0d395d8", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("865a5fc7-ff9d-42c1-b37f-e7d02f2ef7aa", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("f513407c-014f-4acb-a526-b212d7445f91", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("8dabbbff-449b-468b-a494-80ad1cb1636d", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("502e4584-f30e-4b9b-bc80-da8f5149d287", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("514f3679-fd23-41d3-ac6e-b13355c6b716", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("ea067875-15ce-466a-b805-9fd42938fa32", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("ab3aea55-ee61-4a61-8d37-c77f890582a6", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("e98d7ab1-5b31-4dfd-bd8a-01a99df1c13e", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("4fbdcb67-4e39-4e84-b5d0-e4916df0cc20", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("92150aaf-bd20-4b0b-aae5-802a6ddacaaf", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("b9c197e7-4fda-443b-af5d-04703f2512af", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("500c6c82-6637-4f8b-bb30-9fb30e6c5c7a", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("4450ed80-79a2-4253-bf53-f4c99757acd0", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("ad403374-d787-48cb-8401-24d5938fecff", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("29b687ca-aff7-43a8-8cf5-918beb75a406", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("12c7bcea-bbb6-467e-8b86-c73d6c2327ac", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("0b1c3a54-c7df-40ad-9016-020646d1af0f", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("f71b0056-5161-4704-b6e6-57433d6cec8d", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("8a103d16-ba6b-4bd1-8ddc-3e9254763dc8", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("ef2d226f-d2f6-44b9-8885-f2dc3c38e962", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("41c2a0db-39ad-4b1a-9e9b-392fb44871ef", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("b75c6907-0060-42e9-a1b2-3ef95bc2be78", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("66c1e2c8-d668-462c-8641-cc41b2cb6ee7", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("aef3f8a1-0813-481c-8557-882ce62c0029", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("002eea98-0f7a-4a3f-843b-636f63d8cf6e", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("bc19d651-dabb-46b9-9f3b-b8da6581c36d", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("f650edfc-44d9-4d70-bb68-14bd3c9ad3d1", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("ca76ab70-8cff-4f21-81c9-b9e679c8ddff", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("b40747ec-b53b-4474-ba15-384d04322c33", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("35d9c012-2263-46ec-952f-e92631c411de", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("cd406c52-f5b6-4f47-9117-6e510888a57e", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("9d21b7c3-5ea8-4f73-a5bf-f266ecb2b022", () => ReadDataLead.DataSourceFilters);
			MetaPathParameterValues.Add("ddb8f352-0211-44fc-8b93-f3abbd023649", () => ReadDataLead.ResultType);
			MetaPathParameterValues.Add("65843b8b-f9d2-41cc-8170-734e51b1a5ca", () => ReadDataLead.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b341955e-cf2a-400b-907c-a8557f3c93c1", () => ReadDataLead.NumberOfRecords);
			MetaPathParameterValues.Add("1409c0d5-2885-44c0-8161-47a69431903e", () => ReadDataLead.FunctionType);
			MetaPathParameterValues.Add("bf8e626b-4175-4de4-99ed-f96ac7a26c1d", () => ReadDataLead.AggregationColumnName);
			MetaPathParameterValues.Add("5b1ea493-ed30-4d02-bdbb-0efcafe849f9", () => ReadDataLead.OrderInfo);
			MetaPathParameterValues.Add("d4413fda-e205-481c-828d-b4e67061712f", () => ReadDataLead.ResultEntity);
			MetaPathParameterValues.Add("95dce4e4-ff66-4664-b6f7-dacd9bf91bca", () => ReadDataLead.ResultCount);
			MetaPathParameterValues.Add("9a35a728-e367-4047-bda3-0b7be164f5ae", () => ReadDataLead.ResultIntegerFunction);
			MetaPathParameterValues.Add("7090f5b0-1f18-467e-9a40-60d3d177b9c4", () => ReadDataLead.ResultFloatFunction);
			MetaPathParameterValues.Add("11af421d-b60c-4cf9-a2f6-5d599eaa340c", () => ReadDataLead.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2c5d37d8-5236-42a7-b93f-6d4732c94385", () => ReadDataLead.ResultRowsCount);
			MetaPathParameterValues.Add("83955bee-426f-4831-9715-4eda69412fb7", () => ReadDataLead.CanReadUncommitedData);
			MetaPathParameterValues.Add("2d0ef092-481e-4e72-920c-caa204e62d66", () => ReadDataLead.ResultEntityCollection);
			MetaPathParameterValues.Add("e72ba4ac-d6aa-4c7c-8d86-2be667ba6622", () => ReadDataLead.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("cc0389f7-a908-4db4-b2f9-dc8c55c3a68c", () => ReadDataLead.IgnoreDisplayValues);
			MetaPathParameterValues.Add("8ca2796a-0852-480e-8a35-8f82f9d2dc8f", () => ReadDataLead.ResultCompositeObjectList);
			MetaPathParameterValues.Add("58ed1820-e362-49f5-968c-162a220fb729", () => ReadDataLead.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f161763e-878f-4674-8e4e-3fc88a6a58b3", () => ChangeDataLead.EntitySchemaUId);
			MetaPathParameterValues.Add("092165e2-051d-4f89-92cf-c710ba91ab13", () => ChangeDataLead.IsMatchConditions);
			MetaPathParameterValues.Add("6c0d30ee-7c93-4ea8-9ca4-918c3d232658", () => ChangeDataLead.DataSourceFilters);
			MetaPathParameterValues.Add("55a55d6a-8498-40c0-bdfe-95136f257586", () => ChangeDataLead.RecordColumnValues);
			MetaPathParameterValues.Add("77b402b4-36ef-4afe-85ca-fbbfe0540b9f", () => AddDataContactToOpportunity.EntitySchemaId);
			MetaPathParameterValues.Add("611d2131-f988-40c6-a266-7ac3720e4624", () => AddDataContactToOpportunity.DataSourceFilters);
			MetaPathParameterValues.Add("f87e7355-4618-4675-ac15-23509e6ffedd", () => AddDataContactToOpportunity.RecordAddMode);
			MetaPathParameterValues.Add("20e936ce-6092-493c-b50c-aaf70285c26b", () => AddDataContactToOpportunity.FilterEntitySchemaId);
			MetaPathParameterValues.Add("ccc51ea5-dba9-4d02-9514-ddb4ac2fa55c", () => AddDataContactToOpportunity.RecordDefValues);
			MetaPathParameterValues.Add("77fca69f-0da0-430c-a3da-c7ed23ab5394", () => AddDataContactToOpportunity.RecordId);
			MetaPathParameterValues.Add("36768833-e793-4cd5-8c7c-6fa9657737df", () => AddDataOpportunity.EntitySchemaId);
			MetaPathParameterValues.Add("1aa11035-b136-470f-8cb3-1f4060a6f342", () => AddDataOpportunity.DataSourceFilters);
			MetaPathParameterValues.Add("05d8eeec-d375-46f9-ae98-2ee983ccb91d", () => AddDataOpportunity.RecordAddMode);
			MetaPathParameterValues.Add("8513b4b5-7a5d-4bac-b336-7ffa764d5510", () => AddDataOpportunity.FilterEntitySchemaId);
			MetaPathParameterValues.Add("488491cb-2475-44b0-9985-39cc11395c42", () => AddDataOpportunity.RecordDefValues);
			MetaPathParameterValues.Add("d6c3ad89-7397-4dd6-a229-f52efab3d43b", () => AddDataOpportunity.RecordId);
			MetaPathParameterValues.Add("95d638cd-1142-40c7-b944-f9e7fdc8b952", () => ReadDataCountOpportunityByAccount.DataSourceFilters);
			MetaPathParameterValues.Add("baccf23b-370e-4e0b-b657-7bfa21cdd970", () => ReadDataCountOpportunityByAccount.ResultType);
			MetaPathParameterValues.Add("daf54a7f-8a62-4589-9c9c-c261921a13fd", () => ReadDataCountOpportunityByAccount.ReadSomeTopRecords);
			MetaPathParameterValues.Add("cf300c28-9b38-48ff-a8d5-ecb1fba12e64", () => ReadDataCountOpportunityByAccount.NumberOfRecords);
			MetaPathParameterValues.Add("fc3b5658-a8e6-4cab-b27b-819a3025ed71", () => ReadDataCountOpportunityByAccount.FunctionType);
			MetaPathParameterValues.Add("693953ab-8637-4183-87d1-ee4988a862f8", () => ReadDataCountOpportunityByAccount.AggregationColumnName);
			MetaPathParameterValues.Add("5e608114-da8f-4197-a7c1-9abde0e48dca", () => ReadDataCountOpportunityByAccount.OrderInfo);
			MetaPathParameterValues.Add("a81f55d7-8bc9-4327-b691-9ede33487823", () => ReadDataCountOpportunityByAccount.ResultEntity);
			MetaPathParameterValues.Add("a83ce913-3e58-4db8-b563-712f4f1f1d4f", () => ReadDataCountOpportunityByAccount.ResultCount);
			MetaPathParameterValues.Add("f23fe366-df2c-4531-b2ed-ebdf444d985e", () => ReadDataCountOpportunityByAccount.ResultIntegerFunction);
			MetaPathParameterValues.Add("236f9f63-489b-4485-b92a-f5a499fe453e", () => ReadDataCountOpportunityByAccount.ResultFloatFunction);
			MetaPathParameterValues.Add("5a384c94-4c0e-46d6-ab9c-2f2f6cf1de5a", () => ReadDataCountOpportunityByAccount.ResultDateTimeFunction);
			MetaPathParameterValues.Add("199f3817-15db-4ed6-b57f-350fc7b100b3", () => ReadDataCountOpportunityByAccount.ResultRowsCount);
			MetaPathParameterValues.Add("d3ab4b8a-b637-47a5-bc47-da539d6683f1", () => ReadDataCountOpportunityByAccount.CanReadUncommitedData);
			MetaPathParameterValues.Add("156fda51-7aad-4289-bdf5-909adb3f882f", () => ReadDataCountOpportunityByAccount.ResultEntityCollection);
			MetaPathParameterValues.Add("84c58779-0b9a-4c9a-92d9-5ba3900861f5", () => ReadDataCountOpportunityByAccount.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("d2b28272-8058-40a5-b869-30703026b4b7", () => ReadDataCountOpportunityByAccount.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d801edde-baf3-46d2-a9c0-3a75ffe91790", () => ReadDataCountOpportunityByAccount.ResultCompositeObjectList);
			MetaPathParameterValues.Add("bc100e0a-c81b-4273-8655-6fbd2d302636", () => ReadDataCountOpportunityByAccount.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("760c8144-4547-4f2e-9058-d28c8497d3e6", () => ReadDataAccount.DataSourceFilters);
			MetaPathParameterValues.Add("29d241ea-e7c1-468b-93dd-4fabc9692e05", () => ReadDataAccount.ResultType);
			MetaPathParameterValues.Add("99fe1d4f-11a3-4a99-a403-3f8329c46387", () => ReadDataAccount.ReadSomeTopRecords);
			MetaPathParameterValues.Add("23c9ab4d-c03e-4823-a89d-b8157e04f637", () => ReadDataAccount.NumberOfRecords);
			MetaPathParameterValues.Add("0481537e-1347-4a84-bc95-3f25b63bd2aa", () => ReadDataAccount.FunctionType);
			MetaPathParameterValues.Add("98fe3323-90ae-4f77-9698-90cb6049bb21", () => ReadDataAccount.AggregationColumnName);
			MetaPathParameterValues.Add("ab5fefa4-6698-4258-940b-0a2c6dd14a31", () => ReadDataAccount.OrderInfo);
			MetaPathParameterValues.Add("d3b28169-5be2-4f9c-97c0-eef28ed4f516", () => ReadDataAccount.ResultEntity);
			MetaPathParameterValues.Add("3bc1a643-8bc8-4d8c-96c9-19e0df86a151", () => ReadDataAccount.ResultCount);
			MetaPathParameterValues.Add("801aa1e5-b4cb-4d94-abad-0dfa07dffec6", () => ReadDataAccount.ResultIntegerFunction);
			MetaPathParameterValues.Add("f75452e6-8240-4d69-825e-90cd8847e099", () => ReadDataAccount.ResultFloatFunction);
			MetaPathParameterValues.Add("36ec811c-adc6-4e15-a536-d4bbcf966b71", () => ReadDataAccount.ResultDateTimeFunction);
			MetaPathParameterValues.Add("affd0b02-dbe8-4101-aeb3-b62e33160dd3", () => ReadDataAccount.ResultRowsCount);
			MetaPathParameterValues.Add("591a5668-a8e2-41dc-a509-888da5a63e1a", () => ReadDataAccount.CanReadUncommitedData);
			MetaPathParameterValues.Add("9cc3666e-b170-44af-a775-f6810f7e7250", () => ReadDataAccount.ResultEntityCollection);
			MetaPathParameterValues.Add("87a74108-882e-4315-a51f-706bae061c72", () => ReadDataAccount.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("e5436907-184b-4bae-b060-99c5407f2a22", () => ReadDataAccount.IgnoreDisplayValues);
			MetaPathParameterValues.Add("89901727-f199-48c2-bcdc-e40b65c75a7c", () => ReadDataAccount.ResultCompositeObjectList);
			MetaPathParameterValues.Add("147cccd2-825b-42c6-8465-5624d50c9a10", () => ReadDataAccount.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f3d16d53-5568-4d10-85f2-ecee93297c69", () => ReadDataContact.DataSourceFilters);
			MetaPathParameterValues.Add("6d0e3dc9-842e-46e7-8ec6-d71896474631", () => ReadDataContact.ResultType);
			MetaPathParameterValues.Add("01b2e31d-1d81-4b50-bc28-b8d8b4b60976", () => ReadDataContact.ReadSomeTopRecords);
			MetaPathParameterValues.Add("2fc79c56-2808-4e39-a3da-7b92d8218134", () => ReadDataContact.NumberOfRecords);
			MetaPathParameterValues.Add("4d312b88-dd01-43fa-a2cf-92d118789fc2", () => ReadDataContact.FunctionType);
			MetaPathParameterValues.Add("705dbcc7-95ff-47ba-a0de-e637092435f6", () => ReadDataContact.AggregationColumnName);
			MetaPathParameterValues.Add("0dfc2b7f-d9f0-4923-87e3-ce36e9fb5442", () => ReadDataContact.OrderInfo);
			MetaPathParameterValues.Add("daa09ed7-2a7d-4450-a30a-dd8ac16c0a06", () => ReadDataContact.ResultEntity);
			MetaPathParameterValues.Add("1c0aed0e-7343-442c-970e-e1e5c5a4ede4", () => ReadDataContact.ResultCount);
			MetaPathParameterValues.Add("957d85e9-6cea-4ba9-b671-6ff1d0faecee", () => ReadDataContact.ResultIntegerFunction);
			MetaPathParameterValues.Add("96aba7e1-c060-491b-a648-67b8fed13557", () => ReadDataContact.ResultFloatFunction);
			MetaPathParameterValues.Add("0afa84c8-ac3e-4b20-8ff2-a08e0f96f627", () => ReadDataContact.ResultDateTimeFunction);
			MetaPathParameterValues.Add("13f4af03-0d2b-4788-9a8d-f585fb5cfd13", () => ReadDataContact.ResultRowsCount);
			MetaPathParameterValues.Add("2c12c50b-6308-45df-becd-68952bb8177e", () => ReadDataContact.CanReadUncommitedData);
			MetaPathParameterValues.Add("adb4ba05-85d5-4736-a24e-94b25bcf8904", () => ReadDataContact.ResultEntityCollection);
			MetaPathParameterValues.Add("04d717aa-6962-480f-b56d-1be4aba03d1c", () => ReadDataContact.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("67a25d02-1e6e-46fc-bb0a-c9e2f19819ab", () => ReadDataContact.IgnoreDisplayValues);
			MetaPathParameterValues.Add("90d54b35-e43d-4beb-b30a-9984c50c24f4", () => ReadDataContact.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f1fbddca-7799-4bcf-a075-426df81db125", () => ReadDataContact.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a81724cd-f82e-401e-bdc4-1f4968318e58", () => PresentationTaskCreation.EntitySchemaId);
			MetaPathParameterValues.Add("dafab651-4b04-4a39-9ffa-a14a50789205", () => PresentationTaskCreation.DataSourceFilters);
			MetaPathParameterValues.Add("ff84282e-f6d0-4910-a414-28117fa48082", () => PresentationTaskCreation.RecordAddMode);
			MetaPathParameterValues.Add("5ad22c54-905a-451d-b9fd-76ff73069b58", () => PresentationTaskCreation.FilterEntitySchemaId);
			MetaPathParameterValues.Add("5cd8ef8c-6a8f-48a6-8cbb-13e448e5e606", () => PresentationTaskCreation.RecordDefValues);
			MetaPathParameterValues.Add("3b349266-cabe-4ac9-9bab-90e5a99b9312", () => PresentationTaskCreation.RecordId);
			MetaPathParameterValues.Add("e113eec9-67b0-4d53-8bd1-162890643787", () => ReadOppoortunityData2.DataSourceFilters);
			MetaPathParameterValues.Add("da79942f-8a30-4c0f-855d-60c2d9a24472", () => ReadOppoortunityData2.ResultType);
			MetaPathParameterValues.Add("314efddf-5361-477a-9ff8-a9cb5fab8b62", () => ReadOppoortunityData2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("06b753c1-0d8b-436b-8acc-ddf113106da6", () => ReadOppoortunityData2.NumberOfRecords);
			MetaPathParameterValues.Add("ad17e1dd-e357-4be2-be8e-37597e384cc1", () => ReadOppoortunityData2.FunctionType);
			MetaPathParameterValues.Add("9cb37f59-15e3-4146-8d7f-c8726fcb37d4", () => ReadOppoortunityData2.AggregationColumnName);
			MetaPathParameterValues.Add("6f41753d-91d4-4093-8fba-b44d89023e4c", () => ReadOppoortunityData2.OrderInfo);
			MetaPathParameterValues.Add("dfa2d329-fcfc-4412-bf5d-d4a9bda93dae", () => ReadOppoortunityData2.ResultEntity);
			MetaPathParameterValues.Add("820e9918-37b0-4611-aaf2-8d870ec7da7d", () => ReadOppoortunityData2.ResultCount);
			MetaPathParameterValues.Add("cb9c1fe1-8c58-4f12-89f1-7aae2156df27", () => ReadOppoortunityData2.ResultIntegerFunction);
			MetaPathParameterValues.Add("813a52d4-0e07-46b4-a63f-229d35aa56c6", () => ReadOppoortunityData2.ResultFloatFunction);
			MetaPathParameterValues.Add("a3dabfcb-04f6-4cea-92b9-d9ea7aee59b1", () => ReadOppoortunityData2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("fcd7d381-1523-402c-b1b8-ed682284f793", () => ReadOppoortunityData2.ResultRowsCount);
			MetaPathParameterValues.Add("e2a2ccd2-d26f-4f42-ae98-edf3516e1ea8", () => ReadOppoortunityData2.CanReadUncommitedData);
			MetaPathParameterValues.Add("b5926df2-7c95-4492-a867-2d430924a35b", () => ReadOppoortunityData2.ResultEntityCollection);
			MetaPathParameterValues.Add("701045a2-ff5b-4e90-ae4f-035211803404", () => ReadOppoortunityData2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5402bebd-14b9-42b0-8196-579eb5bbe71e", () => ReadOppoortunityData2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("96db62c1-ce73-496e-a661-3117af6166c1", () => ReadOppoortunityData2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("510b4f7b-0b11-445f-839e-ab79347decea", () => ReadOppoortunityData2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("6fbea50a-fcc9-45a8-9318-18aaea6960f4", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("054c4df5-87b5-404f-85c8-f5bb3e7c2694", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("85e3b80e-36f9-4932-88fd-521181901c0a", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("335d8956-0dcb-469d-90e9-ceef1f2c5ecf", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("d9f755be-cee7-464d-9e1b-b41958012cd7", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("ea0c6605-f519-48fc-a673-083c99411a6a", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("04c4106d-1c1b-4e36-adfa-2bde0c00cacb", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("ee89e1ce-8692-4233-94c8-45e2768973be", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("a73fd6bc-7349-44c8-9897-4cbf76d42e92", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("83effc4d-ad92-4d9f-8f5d-a8a8a9476b51", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("5877a9b3-2232-413f-bca4-841e0c74fcaf", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("e49f79ee-5843-4cf5-8054-c5513d2f9295", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2bb22b1b-8777-4e67-bd6f-76818c3e0d4b", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("10b071ad-0944-459a-90cb-7bd9819ae222", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("35106250-8b54-4cad-8a40-45adb5f3cd75", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("c1ba2a29-f542-4078-94a5-6af41945ce12", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9077d7fd-aab0-4d45-9d7d-e410dd871d90", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("e01f3c07-11ea-4ff6-869f-1fd82c661820", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("2a64a7e9-eae5-4633-b37c-798ea1a52b36", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("07e87dc6-266d-4544-87cb-bfd58618dbfc", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("8e34ab8a-aae1-49fa-a036-0f0b0ae39983", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("b4c062c1-d149-4854-b95d-7d3101c49ba8", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("9b1e2c37-1ca0-4018-820c-534743d29771", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("3f57e619-c84a-40cd-a0f1-b5c0fad5c3c5", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("916d8dad-7673-427b-a065-b9d623107663", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("06208806-e8cf-4d1b-b140-1bb619b9ed9d", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("c7f8a702-1219-42b2-bf9d-1f55c8264391", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("3792585d-cd7c-494c-b316-b160fa45ae28", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("faa46a7f-a96c-46cf-9a47-add578864b68", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("68383c19-2658-416e-958d-1489861993aa", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("80cefc71-5fc6-4296-b100-29c98156e0b1", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("35445f62-ccc0-4a74-94f0-9ec9ea65b343", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("6cba6276-dc6c-4940-803b-a32b756d2ebd", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("6d7147db-0aaa-41c5-8897-3ad2d88fd821", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("00aae8e4-4e62-4538-9bf7-d0b6178f7c93", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("e696780e-c260-4f1d-ac47-1890fdb6b840", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("da459109-1578-45d4-9510-627e44859262", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("05f93e88-b9f0-488c-b37f-c86bd5b8d920", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("1ddf79d1-87fa-413b-b322-71e34392312d", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("2f6fab91-5a02-44f1-9ea1-7012b00b2849", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("d5f43f08-08d2-4c1d-aae8-d8cddf1e99e0", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b65917ae-2434-428b-b40e-92d5141b5034", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("8a7896a5-a21a-40f3-93d9-7b5832d40f00", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("54b74755-6963-49d4-825e-8f08240a8812", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f5c84e26-162f-4de1-8294-6e4af7634cec", () => AddDataUserTask2.EntitySchemaId);
			MetaPathParameterValues.Add("652608f8-95d7-4a3b-b783-014cd09293a0", () => AddDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("3468e686-0a3c-4fda-bec3-184be133f6d3", () => AddDataUserTask2.RecordAddMode);
			MetaPathParameterValues.Add("ae322fe7-b3af-4bfb-827b-b2d801f86f9f", () => AddDataUserTask2.FilterEntitySchemaId);
			MetaPathParameterValues.Add("d50b648a-e5ed-4bd4-93f1-b84931e30d54", () => AddDataUserTask2.RecordDefValues);
			MetaPathParameterValues.Add("9b7e9251-c513-4107-842c-db639bf6112b", () => AddDataUserTask2.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "Presentation":
					if (!hasValueToRead) break;
					Presentation = reader.GetValue<System.Guid>();
				break;
				case "MainContact":
					if (!hasValueToRead) break;
					MainContact = reader.GetValue<System.Guid>();
				break;
				case "Account":
					if (!hasValueToRead) break;
					Account = reader.GetValue<System.Guid>();
				break;
				case "IsStageChangedByUser":
					if (!hasValueToRead) break;
					IsStageChangedByUser = reader.GetValue<System.Boolean>();
				break;
				case "ClientOpportunityCount":
					if (!hasValueToRead) break;
					ClientOpportunityCount = reader.GetValue<System.Int32>();
				break;
				case "OpportunityTitle":
					if (!hasValueToRead) break;
					OpportunityTitle = reader.GetValue<System.String>();
				break;
				case "Contact":
					if (!hasValueToRead) break;
					Contact = reader.GetValue<System.Guid>();
				break;
				case "ClientName":
					if (!hasValueToRead) break;
					ClientName = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SavePresentationParameter2Execute(ProcessExecutingContext context) {
			var localPresentation = ((FindPresentation.ResultEntity.IsColumnValueLoaded(FindPresentation.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? FindPresentation.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty));
			Presentation = (System.Guid)localPresentation;
			return true;
		}

		public virtual bool SaveMainContactParameterExecute(ProcessExecutingContext context) {
			var localMainContact = (Guid.Empty == ((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty))) ? ((ReadOppMainContact.ResultEntity.IsColumnValueLoaded(ReadOppMainContact.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadOppMainContact.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)) : ((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty));
			MainContact = (System.Guid)localMainContact;
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localCurrentOpportunity = (OpenEditPageUserTask1.RecordId);
			CurrentOpportunity = (System.Guid)localCurrentOpportunity;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localPresentation = Guid.Empty;
			Presentation = (System.Guid)localPresentation;
			return true;
		}

		public virtual bool StoreIsStageChangedByUserExecute(ProcessExecutingContext context) {
			var localIsStageChangedByUser = (Prospecting.OpportunityStageChanged) || (NeedsAnalysis.OpportunityStageChanged)|| (OppManagementValuePproposition.OpportunityStageChanged) || (IdDecisionMakers.OpportunityStageChanged) || (OppManagementPerceptionAnalysis.OpportunityStageChanged) || (OppManagementProposal.OpportunityStageChanged) || (OppManagementNegotiations.OpportunityStageChanged) || (OppManagementContractation.OpportunityStageChanged);
			IsStageChangedByUser = (System.Boolean)localIsStageChangedByUser;
			return true;
		}

		public virtual bool ResetIsStageChangedByUserExecute(ProcessExecutingContext context) {
			var localIsStageChangedByUser = false;
			IsStageChangedByUser = (System.Boolean)localIsStageChangedByUser;
			return true;
		}

		public virtual bool FormulaTaskAccountByLeadExecute(ProcessExecutingContext context) {
			var localAccount = ((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty));
			Account = (System.Guid)localAccount;
			return true;
		}

		public virtual bool SaveCurrOppParameterExecute(ProcessExecutingContext context) {
			var localCurrentOpportunity = (AddDataOpportunity.RecordId);
			CurrentOpportunity = (System.Guid)localCurrentOpportunity;
			return true;
		}

		public virtual bool SavePresentationParameterExecute(ProcessExecutingContext context) {
			var localPresentation = (PresentationTaskCreation.RecordId);
			Presentation = (System.Guid)localPresentation;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localClientOpportunityCount = (ReadDataUserTask2.ResultCount);
			ClientOpportunityCount = (System.Int32)localClientOpportunityCount;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localClientOpportunityCount = (ReadDataCountOpportunityByAccount.ResultCount);
			ClientOpportunityCount = (System.Int32)localClientOpportunityCount;
			return true;
		}

		public virtual bool FormulaTask5Execute(ProcessExecutingContext context) {
			var localOpportunityTitle = ((ReadDataAccount.ResultEntity.IsColumnValueLoaded(ReadDataAccount.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataAccount.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			OpportunityTitle = (System.String)localOpportunityTitle;
			return true;
		}

		public virtual bool FormulaTask6Execute(ProcessExecutingContext context) {
			var localOpportunityTitle = ((ReadDataContact.ResultEntity.IsColumnValueLoaded(ReadDataContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataContact.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			OpportunityTitle = (System.String)localOpportunityTitle;
			return true;
		}

		public virtual bool FormulaTask7Execute(ProcessExecutingContext context) {
			var localContact = ((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty));
			Contact = (System.Guid)localContact;
			return true;
		}

		public virtual bool FormulaTask8Execute(ProcessExecutingContext context) {
			var localClientName = ((ReadDataContact.ResultEntity.IsColumnValueLoaded(ReadDataContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataContact.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			ClientName = (System.String)localClientName;
			return true;
		}

		public virtual bool FormulaTask9Execute(ProcessExecutingContext context) {
			var localClientName = ((ReadDataAccount.ResultEntity.IsColumnValueLoaded(ReadDataAccount.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataAccount.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			ClientName = (System.String)localClientName;
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
			var cloneItem = (OpportunityManagementFinance)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

