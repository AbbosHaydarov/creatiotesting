﻿namespace Terrasoft.Core.Process
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

	#region Class: ContactIdentificationV2Schema

	/// <exclude/>
	public class ContactIdentificationV2Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ContactIdentificationV2Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ContactIdentificationV2Schema(ContactIdentificationV2Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactIdentificationV2";
			UId = new Guid("f58fbc05-8179-4074-9636-19e734769536");
			CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.10.1.444";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
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
			Version = 1;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("f58fbc05-8179-4074-9636-19e734769536");
			Version = 1;
			PackageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("deefb406-4a64-4513-9f48-328ba955695b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("839ed405-68e4-4e40-bd9c-062c634c4a20"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePhoneNumberParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("244eac40-5473-4748-aa26-e77b96a35846"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"PhoneNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fe1f7c0c-c8cf-47c3-bbfe-363c45186118"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"NewContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCaseIncludedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e5e56c22-18ea-449c-b1be-62a59c96abd7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"IsCaseIncluded",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountSelectedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("22ed503f-1097-4afd-9c1c-e7591592243a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountSelected",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateContactButtonCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77a86efd-52da-41d3-b551-b2af78145723"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"CreateContactButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchDetailSelectButtonCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce1af657-ffbd-40aa-8ba8-92e5d0b88a47"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"SearchDetailSelectButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultContactNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("04c9b73f-67bc-483e-9d66-6c2494c5be0f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"DefaultContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateAccountIdParameter());
			Parameters.Add(CreatePhoneNumberParameter());
			Parameters.Add(CreateNewContactParameter());
			Parameters.Add(CreateIsCaseIncludedParameter());
			Parameters.Add(CreateAccountSelectedParameter());
			Parameters.Add(CreateCreateContactButtonCaptionParameter());
			Parameters.Add(CreateSearchDetailSelectButtonCaptionParameter());
			Parameters.Add(CreateDefaultContactNameParameter());
		}

		protected virtual void InitializePreconfiguredPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69b15c71-905e-4fe2-b8c8-13247e6c2e08"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Value = @"Search page - Contacts and Accoutns",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7e141f0a-9d5c-457c-a67f-0a1d278e31bd"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("1b7e2a98-62c5-480f-87de-803a6fd6bd04"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Value = @"4f01d1ce-b5c7-4d19-b354-b5bef74d6e95",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55b46c6d-9866-4800-b1a5-66f885cd2355"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0ae7e716-e7cc-4a75-ae50-55d0030ffc0a"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("d602fd51-f1ec-46f8-a61c-e2a65578dafd"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03340eb8-8dc3-4cfa-803e-9f3b3bc34101"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("8c360d85-bf72-4c87-8c17-d3163c1c7d9d"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("972c2fff-1e7a-4897-88b5-1b6a3de96469"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6943ab1a-dce8-4c57-bd3b-eb4715dcb1d5"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("23145d3b-45a3-4a9a-b019-f296e0cbcfb0"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var templateParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("4a5221ff-1dfa-4371-aa3b-b83fc6ef48f2"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("c003612c-32bf-4743-9ddc-9cd6eddfff56"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("993430b0-b3fc-4871-a50f-48baed943409"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("3f7bb4ba-649e-4dbc-9238-e0630e06179b"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
			var contactIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("12fe9831-090b-4b80-938e-a6c2149a2993"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactIdParameter.SourceValue = new ProcessSchemaParameterValue(contactIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(contactIdParameter);
			var accountIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("6f5535c1-cef2-4fab-aa8c-101f094e1360"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountIdParameter.SourceValue = new ProcessSchemaParameterValue(accountIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(accountIdParameter);
			var contactNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aba17913-301c-4b8a-8b12-d315eba94a55"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			contactNameParameter.SourceValue = new ProcessSchemaParameterValue(contactNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(contactNameParameter);
			var phoneNumberParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f0c052d1-ca27-43fa-bd30-40cbc6d55b3d"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"PhoneNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			phoneNumberParameter.SourceValue = new ProcessSchemaParameterValue(phoneNumberParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(phoneNumberParameter);
			var emailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc1e2817-ed80-4462-81b7-66965f9c76df"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Email",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			emailParameter.SourceValue = new ProcessSchemaParameterValue(emailParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(emailParameter);
			var isContactSelectedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("154e18f3-415a-442d-a42b-a1ab3f228aa9"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"IsContactSelected",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isContactSelectedParameter.SourceValue = new ProcessSchemaParameterValue(isContactSelectedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(isContactSelectedParameter);
			var resultCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17a010c9-438a-4621-b397-adfd1bbf6b2c"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ResultCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			resultCodeParameter.SourceValue = new ProcessSchemaParameterValue(resultCodeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultCodeParameter);
			var isCaseIncludedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9936a9b-7364-4807-886d-c47923aa5526"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"IsCaseIncluded",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isCaseIncludedParameter.SourceValue = new ProcessSchemaParameterValue(isCaseIncludedParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{e5e56c22-18ea-449c-b1be-62a59c96abd7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(isCaseIncludedParameter);
			var accountNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc227909-1872-4ba3-9409-260e522e5bda"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			accountNameParameter.SourceValue = new ProcessSchemaParameterValue(accountNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(accountNameParameter);
			var createContactButtonCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("932357b5-6b5b-4d70-b80b-a52c2cd999a5"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"CreateContactButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			createContactButtonCaptionParameter.SourceValue = new ProcessSchemaParameterValue(createContactButtonCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{77a86efd-52da-41d3-b551-b2af78145723}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(createContactButtonCaptionParameter);
			var searchDetailSelectButtonCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("36bf19ed-4a1b-46d1-8360-7b98a0a05451"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"SearchDetailSelectButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			searchDetailSelectButtonCaptionParameter.SourceValue = new ProcessSchemaParameterValue(searchDetailSelectButtonCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{ce1af657-ffbd-40aa-8ba8-92e5d0b88a47}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(searchDetailSelectButtonCaptionParameter);
		}

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("2cc3931e-cae7-49e3-8cf0-9ce37b4622d1"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("52f0c27a-aa7b-4b1a-81a6-d96439fb602b"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e33fa283-1e3e-45ee-a4c9-cd8f02f2bd1f"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("3b08e0b0-95c8-4039-b074-cc84d0e02189"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03c59888-3e70-4fc6-b8d8-8ca80b0c1a0f"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,75,111,219,70,16,254,43,2,147,67,11,120,133,125,63,116,41,138,216,7,3,121,24,113,154,139,237,195,236,238,108,44,128,162,12,146,106,224,10,250,239,29,210,150,45,27,141,154,186,69,219,32,230,65,34,119,247,155,249,56,59,223,204,114,93,189,236,175,175,176,154,85,31,176,109,161,91,150,126,250,106,217,226,244,164,93,38,236,186,233,235,101,130,122,254,27,196,26,79,160,133,5,246,216,126,132,122,133,221,235,121,215,31,76,30,194,170,131,234,229,175,227,108,53,59,91,87,199,61,46,126,57,206,100,221,155,32,81,8,206,74,194,204,180,143,134,129,139,150,129,22,220,149,96,10,58,65,224,180,172,87,139,230,13,246,112,2,253,101,53,91,87,163,53,50,0,38,37,112,65,50,237,50,25,144,30,152,87,37,50,147,130,140,57,7,87,138,175,54,7,85,151,46,113,1,163,211,123,176,176,17,149,53,130,249,130,100,65,152,192,124,206,156,129,231,42,107,235,85,206,106,0,223,174,191,7,118,125,59,111,62,77,143,187,183,171,186,126,215,30,45,174,250,235,31,206,94,156,29,119,239,62,55,216,158,142,206,102,5,234,14,47,166,52,250,104,224,168,198,5,54,253,108,93,162,16,57,103,199,116,14,150,233,164,200,119,112,116,103,178,14,150,231,164,121,222,16,224,46,196,179,181,85,154,91,145,40,78,193,235,1,23,153,183,133,112,69,43,233,18,104,16,114,115,241,226,98,242,227,228,167,201,215,83,218,241,192,117,10,209,169,194,172,139,137,246,68,33,11,217,90,102,147,212,65,39,19,145,151,193,195,116,220,239,201,108,242,63,123,241,97,199,242,188,187,170,225,250,227,87,110,220,171,22,161,167,137,73,131,159,39,105,217,244,144,250,233,91,242,124,23,199,67,44,176,170,251,237,228,164,25,39,119,66,176,207,196,192,232,234,129,74,118,57,173,207,111,196,118,94,205,206,191,36,183,219,255,155,112,62,20,220,99,173,157,87,7,231,213,233,114,213,166,193,162,162,135,195,157,96,140,78,198,37,143,30,183,226,162,145,134,98,115,59,114,8,61,108,23,110,135,151,121,94,230,152,143,155,211,173,166,70,43,252,246,98,127,240,179,189,110,184,253,29,216,27,104,224,19,182,67,96,239,185,223,177,252,64,97,220,26,206,57,42,16,136,140,59,244,148,47,86,178,232,32,176,204,209,10,31,57,47,49,143,232,247,88,176,197,38,225,19,137,189,199,110,140,246,80,213,110,121,13,161,218,84,155,205,193,110,173,179,38,155,236,137,139,82,198,48,205,29,149,42,240,145,178,63,74,21,41,225,149,130,189,181,46,199,34,185,196,196,146,214,164,0,71,10,136,169,104,70,70,77,20,222,42,201,197,63,95,235,254,29,117,27,176,69,218,236,25,186,52,208,35,142,193,71,199,148,192,12,48,108,92,224,131,186,247,137,251,11,34,60,90,192,188,190,65,62,139,240,123,23,161,180,26,53,102,197,184,49,148,159,142,27,234,34,146,51,69,231,144,98,131,181,209,243,189,34,52,201,38,16,28,153,16,158,83,110,11,36,21,27,206,140,1,39,75,9,116,232,208,223,170,8,165,247,78,71,160,55,42,130,10,140,166,213,81,37,203,148,79,156,103,167,60,47,234,137,34,252,57,165,229,170,233,159,101,248,159,244,194,40,131,225,78,20,230,144,196,167,145,100,232,179,0,22,68,136,69,57,69,137,43,247,201,80,154,236,146,128,200,68,70,74,122,195,5,163,134,37,25,117,35,142,67,226,103,139,127,73,134,84,228,35,71,79,133,192,112,32,66,212,202,64,13,212,132,202,86,37,200,250,79,122,161,167,131,168,231,116,218,119,244,9,65,176,224,89,4,11,76,106,149,130,1,165,56,143,223,170,12,67,212,49,75,106,236,193,41,65,223,52,220,49,224,180,101,33,73,161,10,65,148,118,79,148,225,201,229,178,161,19,233,115,47,252,78,15,164,23,155,223,1,231,63,10,70,218,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c9d9c923-3eb2-47cf-b2d5-b699ef55d643"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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

		protected virtual void InitializeAddDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("50baaec3-b4b2-4696-8e6e-0a52599c84ce"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				Value = @"004a9121-21f8-4a1e-8918-45c0f756ea41",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95bbe5fe-f292-4542-8914-7e0d64c9dd0b"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a7fa4bd-042f-431c-bd8d-a294932edf78"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				UId = new Guid("4314f4b3-ed6a-4fd8-be55-31d309df8a90"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("362a0f68-4c27-4983-b9fe-775a0850402c"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,77,111,219,70,16,253,43,2,147,163,86,216,239,15,93,237,30,4,36,169,81,167,185,88,62,204,238,206,198,2,40,210,32,169,6,174,160,255,222,33,37,199,114,218,124,32,64,208,22,45,15,226,106,151,239,205,236,206,123,28,238,171,151,195,195,61,86,203,234,45,118,29,244,109,25,22,23,109,135,139,171,174,77,216,247,139,87,109,130,122,243,59,196,26,175,160,131,45,14,216,189,131,122,135,253,171,77,63,204,103,207,97,213,188,122,249,219,180,90,45,111,246,213,106,192,237,175,171,76,236,218,24,158,138,205,172,72,112,76,131,70,22,99,116,172,120,133,30,53,148,200,13,129,83,91,239,182,205,107,28,224,10,134,187,106,185,175,38,54,34,72,69,74,171,141,103,73,36,206,116,230,137,65,65,195,180,176,86,23,153,141,227,88,29,230,85,159,238,112,11,83,208,39,48,231,26,130,144,130,73,81,60,69,23,200,124,16,52,50,137,23,103,44,130,22,35,248,244,252,19,240,230,197,205,170,255,249,67,131,221,245,196,187,44,80,247,120,187,160,217,79,38,126,170,113,139,205,176,220,75,37,157,180,138,51,133,38,51,237,180,98,94,121,197,198,36,61,36,17,181,115,7,2,124,60,205,229,62,133,28,82,144,138,32,81,18,36,21,22,105,71,44,218,16,176,24,147,173,86,135,219,23,183,99,138,121,211,223,215,240,240,238,207,153,190,193,15,179,212,54,3,164,97,49,142,59,76,109,151,103,171,124,4,222,63,171,222,57,116,191,62,138,96,93,45,215,159,147,193,233,126,220,244,115,33,124,170,129,117,53,95,87,215,237,174,75,35,163,26,255,60,214,100,138,192,79,23,251,139,159,199,235,200,49,193,94,67,3,239,177,123,67,17,39,248,180,116,9,3,76,193,223,82,222,143,196,81,6,195,157,40,204,33,4,166,209,74,230,179,0,22,68,136,69,57,37,75,145,19,250,23,44,216,97,147,240,121,98,194,70,84,214,8,230,11,82,25,132,9,132,207,156,129,231,42,107,235,85,206,106,194,79,145,159,146,121,148,43,205,52,187,186,158,2,244,211,254,71,253,159,18,63,173,92,158,149,239,140,161,205,155,178,193,188,106,190,231,168,14,213,225,48,63,55,91,84,138,35,26,218,67,178,228,16,23,4,139,121,84,100,226,96,179,161,163,48,95,54,155,144,69,100,167,128,105,149,136,0,136,42,196,108,73,159,28,19,148,172,74,212,63,194,108,215,15,253,53,14,195,166,121,223,47,46,177,192,174,30,46,142,138,190,104,183,219,93,179,73,48,108,218,102,44,250,215,220,64,84,116,30,179,254,72,183,56,209,144,65,206,120,102,237,253,116,27,197,63,139,15,179,124,12,249,191,95,190,205,47,217,107,155,162,46,172,8,79,111,58,27,168,208,170,20,134,193,138,66,18,1,239,254,29,126,49,70,20,106,68,129,69,29,232,69,173,113,28,101,193,132,161,54,227,208,39,238,236,23,253,194,101,73,128,134,218,25,20,50,13,210,153,4,101,29,139,198,43,225,192,162,196,244,119,54,167,179,94,35,105,123,144,52,103,70,59,218,171,211,158,1,72,203,208,185,24,44,40,67,69,253,122,175,185,186,107,27,252,175,244,149,156,163,162,170,32,227,164,5,250,244,160,190,18,29,117,152,204,209,10,31,57,47,145,30,252,188,79,190,57,177,127,160,79,110,15,127,0,77,176,106,194,34,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eec63597-7c61-4178-ab9d-589c0450ab30"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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

		protected virtual void InitializeAddDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("040ed64a-eb19-4f89-925d-c9522c5d6854"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				Value = @"004a9121-21f8-4a1e-8918-45c0f756ea41",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cda6b132-0e59-45bb-988a-dd98d098385b"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("611a2e2a-44ad-46d6-a803-86b905065d78"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				UId = new Guid("a85205de-fa99-4c50-85d5-7011ef3b4d0e"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ac5bb6e7-6eff-457f-b790-d236a0edda50"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,203,142,219,70,16,252,21,129,246,81,45,204,251,161,171,55,135,5,236,100,97,57,190,172,246,208,51,211,227,21,64,145,11,146,178,33,11,250,247,140,40,201,171,117,226,7,12,24,73,144,240,64,74,51,172,234,230,116,85,247,174,122,62,108,31,168,154,87,111,168,235,176,111,243,48,123,209,118,52,187,233,218,72,125,63,123,217,70,172,87,31,49,212,116,131,29,174,105,160,238,45,214,27,234,95,174,250,97,58,121,10,171,166,213,243,247,227,110,53,191,221,85,215,3,173,127,191,78,133,221,75,107,148,76,22,148,97,12,20,106,15,193,171,114,227,76,235,152,48,90,22,11,56,182,245,102,221,188,162,1,111,112,184,175,230,187,106,100,43,4,49,11,97,148,118,16,121,44,4,137,69,192,76,26,20,55,70,101,145,180,101,84,237,167,85,31,239,105,141,99,208,71,48,99,10,61,23,28,4,207,174,68,231,4,206,243,242,75,71,150,173,54,132,138,31,192,167,247,31,129,183,207,110,175,251,223,62,52,212,45,70,222,121,198,186,167,187,89,89,253,108,225,151,154,214,212,12,243,29,49,47,163,44,17,12,231,177,36,170,50,120,50,12,184,18,217,80,210,65,100,220,23,192,167,211,156,239,184,200,228,157,228,192,60,11,160,130,99,224,165,35,64,19,5,87,30,133,247,114,127,247,236,238,144,98,90,245,15,53,110,223,254,57,211,5,97,23,239,39,185,237,38,113,211,15,237,154,186,82,147,102,192,56,28,161,15,79,234,119,9,222,45,143,50,88,86,243,229,151,132,112,122,30,63,251,169,20,62,87,193,178,154,46,171,69,187,233,226,129,81,30,254,156,171,50,70,96,167,11,254,226,118,190,142,28,35,236,21,54,248,142,186,95,75,196,17,62,110,93,225,128,99,240,55,37,239,51,113,16,94,51,203,51,88,66,15,138,140,0,151,56,130,231,62,100,105,165,200,89,140,232,215,148,169,163,38,210,211,196,184,9,36,141,230,224,50,137,34,173,162,82,151,18,3,116,76,38,101,156,76,73,142,248,49,242,99,50,103,193,150,149,102,83,215,99,128,126,252,254,131,3,78,137,159,118,174,46,10,120,193,208,166,85,94,81,186,110,126,228,168,246,213,126,63,189,180,155,242,198,113,111,60,68,97,12,40,137,14,2,83,69,96,65,39,157,172,141,204,233,175,218,173,72,146,39,43,177,96,99,49,25,106,1,62,36,3,146,24,69,204,73,230,160,126,134,221,22,219,126,65,195,176,106,222,245,179,43,202,184,169,135,147,134,95,180,235,245,166,89,69,28,86,109,115,40,250,55,253,176,237,203,121,76,250,35,221,217,10,147,120,201,51,105,31,198,199,65,252,147,176,157,164,99,200,255,253,242,125,126,73,78,153,24,74,135,203,220,165,210,218,125,41,180,204,25,200,27,158,139,68,208,217,127,137,95,172,245,145,138,68,101,196,67,211,102,8,24,141,3,71,74,11,205,120,49,0,125,213,47,76,228,136,164,45,100,204,197,52,116,232,250,210,88,8,186,244,117,139,134,4,197,191,115,60,93,76,27,161,20,97,84,12,180,178,18,148,85,14,16,133,1,178,54,120,131,82,151,162,126,123,218,220,220,183,13,253,87,230,74,74,65,150,170,16,48,75,165,44,169,204,149,96,203,132,73,140,12,119,129,177,28,202,139,95,246,201,119,39,246,15,244,201,221,254,15,25,173,225,11,36,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("415de17c-c12f-4817-8781-82b8431e8c3d"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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

		protected virtual void InitializeAutoGeneratedPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("369adb53-be77-4d6a-9958-3b4c83ca70fe"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"Creating new contact",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("6e13b431-433e-4be7-8eee-468eed2a7d09"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5408038c-ac80-4220-b5cc-f215a44ba230"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"Specify contact data",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("206826a5-918d-4250-8a64-287b1bde9a2b"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9a46d74-6ecd-4ff8-8131-73d06aa4f4bd"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""aa2b00e5-ba27-432d-9421-d457baffb853"",""isEnabled"":true,""performValidation"":true,""caption"":""Next"",""name"":""Next"",""style"":""green"",""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e2f306b-000b-4710-81f9-7b949ea2ad54"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""634061c5-a984-4d9b-86f0-af4327ca4a12"",""controlEditType"":""1"",""caption"":""Name"",""name"":""ContactName"",""isMultiline"":false,""isRequired"":false,""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""9b4bd2f4-9731-4207-a062-9c213f0dc347"",""controlEditType"":""1"",""caption"":""Phone"",""name"":""Phone"",""isMultiline"":false,""isRequired"":false,""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""28874bae-8f14-4476-b3c6-38c00d7380f3"",""controlEditType"":""SelectionField"",""caption"":""Account"",""name"":""Account"",""isRequired"":false,""dataSource"":""25d7c1ab-1de0-4501-b402-02e0e5a72d6e"",""dataFilter"":"""",""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""5a6f26d8-e7c2-41e2-98b7-31edaab7a990"",""controlEditType"":""1"",""caption"":""Email"",""name"":""Email"",""isMultiline"":false,""isRequired"":false,""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("830320f1-bd81-4cea-9f95-a80eadbd7767"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6098bc34-95ad-496c-a3b2-81e95b073100"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("300e12bc-e3f7-49b2-8167-6ffb30b989af"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("0f482d41-ab86-41fc-b865-2e19e647b9aa"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8c0b7c0a-66fd-4a5b-9457-bf3729096fef"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ecbfdeeb-28bb-4777-abb9-4dc8ec14f22e"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"Once the data is filled in, click the ""Next"" button",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76840c62-b319-4288-b212-45c7398a6f01"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
			var contactNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("634061c5-a984-4d9b-86f0-af4327ca4a12"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			contactNameParameter.SourceValue = new ProcessSchemaParameterValue(contactNameParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{aba17913-301c-4b8a-8b12-d315eba94a55}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(contactNameParameter);
			var phoneParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b4bd2f4-9731-4207-a062-9c213f0dc347"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Phone",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			phoneParameter.SourceValue = new ProcessSchemaParameterValue(phoneParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{f0c052d1-ca27-43fa-bd30-40cbc6d55b3d}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(phoneParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("28874bae-8f14-4476-b3c6-38c00d7380f3"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{50fc9fed-3694-412a-846f-9e7f49617296}].[Parameter:{5efb285c-200d-4e01-90d9-5acd97f421c3}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var emailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a6f26d8-e7c2-41e2-98b7-31edaab7a990"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Email",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			emailParameter.SourceValue = new ProcessSchemaParameterValue(emailParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{fc1e2817-ed80-4462-81b7-66965f9c76df}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(emailParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b1517598-2489-44aa-aaa6-5640f2853121"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,219,48,16,252,149,64,231,48,16,41,90,22,125,43,82,183,240,165,9,144,32,151,58,135,21,185,180,137,234,5,146,78,155,26,254,247,174,164,196,113,10,23,113,123,105,171,19,53,152,29,206,190,184,77,116,5,33,124,130,26,147,89,114,139,222,67,104,109,188,248,224,170,136,254,163,111,55,93,114,158,4,244,14,42,247,29,205,136,207,141,139,239,33,2,133,108,151,47,10,203,100,182,60,174,177,76,206,151,137,139,88,7,226,80,136,42,21,64,198,115,102,165,77,153,204,10,205,74,158,90,198,141,225,90,79,141,40,116,49,50,127,37,126,217,214,29,120,28,239,24,228,237,112,188,125,236,122,42,39,64,15,20,23,218,230,9,204,122,19,97,222,64,89,161,161,255,232,55,72,80,244,174,166,108,240,214,213,120,13,158,238,234,117,218,30,34,146,133,42,244,172,10,109,156,127,235,60,134,224,218,230,45,115,213,166,110,14,217,36,128,251,223,39,59,233,224,177,103,94,67,92,15,18,11,178,181,27,92,190,91,173,60,174,32,186,135,67,19,95,240,113,224,157,86,63,10,48,212,165,59,168,54,120,112,231,235,76,46,161,139,99,66,227,245,68,240,110,181,62,57,215,125,197,222,74,87,16,216,61,147,79,212,60,154,131,200,9,124,232,129,81,229,249,184,76,62,47,194,213,215,6,253,141,94,99,13,99,213,238,47,8,253,9,152,87,88,99,19,103,91,76,85,166,51,142,44,231,92,51,105,164,101,10,243,148,113,41,108,142,102,82,10,11,59,10,216,27,154,109,185,176,168,138,140,179,84,165,37,147,101,145,50,149,21,200,32,215,130,75,5,66,169,108,119,63,26,119,161,171,224,241,110,239,239,6,193,235,245,153,109,253,153,222,132,216,214,232,105,86,154,8,58,14,1,125,253,137,54,41,173,201,114,83,50,173,21,50,41,69,193,148,156,72,134,182,80,70,161,229,2,52,205,73,255,245,237,108,87,78,67,117,213,161,167,113,25,218,149,30,31,244,87,27,210,23,209,183,109,28,75,179,111,194,161,157,231,105,147,83,68,171,185,98,92,75,154,54,53,205,89,97,210,148,137,18,83,16,57,78,51,33,201,15,61,20,125,171,110,218,141,215,79,139,25,198,23,226,143,54,255,47,236,243,239,172,232,209,37,57,101,232,255,219,113,94,252,67,211,185,75,118,63,0,158,39,111,237,187,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6afebec2-bcc5-4267-b4d1-642bc77d9b47"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("27a93232-ccc8-48ad-9eff-1ad1ea4b60eb"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("60e46248-0ebb-4ee8-a1bc-4ee2f5b4a0b1"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd28bfbd-e627-4d61-a3fd-91ebd0891488"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b16fad7-4ecc-4715-be57-b6aa7d76d4b9"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4ae849fb-aa93-4b31-98f6-6818622659e0"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("cdf7b7b2-89b5-4196-a299-d432ec544639"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c555a9a-084f-46b0-97da-7805b5965ddc"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("628c1898-b678-4647-b7e5-8624e2a20a4b"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("05f3c3a8-49ec-4ef1-923a-b82935dad796"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bc3bc9a9-a676-4a08-b8d4-3eca60a51ec1"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("712197a2-16fc-411c-a0b8-ad059a020d40"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fb660a18-6ba8-4292-86c1-b614908a8d63"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2519b17d-ed42-4ff6-bb3c-7ebb21fcc7d5"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c735c402-0b9e-406d-a4e0-cbb66e7839f7"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,77,54,75,78,52,52,72,213,53,52,180,48,208,53,73,54,76,213,181,72,52,53,208,53,53,77,52,55,74,75,179,76,74,73,49,1,0,215,224,64,129,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("75c9c0ab-0f22-4b23-9b18-aa90e393a626"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a27c7b13-58a7-4ad4-b15a-448de74c1d65"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9ddc6a96-8c0e-469b-9ff3-8706adc2e1ae"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fbab1060-c0b1-4f93-867c-7266001affb5"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,219,48,16,252,149,64,231,48,144,40,89,150,124,11,82,183,200,165,9,144,32,151,42,135,37,185,178,137,74,162,64,82,105,83,195,255,222,165,100,187,73,225,34,110,47,109,117,34,7,179,163,217,23,55,145,108,192,185,143,208,98,180,136,238,209,90,112,166,246,23,239,117,227,209,126,176,102,232,163,243,200,161,213,208,232,111,168,38,124,169,180,127,7,30,40,100,83,253,80,168,162,69,117,92,163,138,206,171,72,123,108,29,113,40,4,51,174,202,98,94,51,140,179,132,101,69,26,51,136,185,98,169,76,211,88,206,120,206,147,116,98,254,74,252,202,180,61,88,156,254,49,202,215,227,241,254,185,15,212,132,0,57,82,180,51,221,14,76,131,9,183,236,64,52,168,232,238,237,128,4,121,171,91,202,6,239,117,139,183,96,233,95,65,199,4,136,72,53,52,46,176,26,172,253,242,107,111,209,57,109,186,183,204,53,67,219,189,100,147,0,30,174,59,59,241,232,49,48,111,193,175,71,137,73,107,59,250,188,92,173,44,174,192,235,167,151,54,62,227,243,200,60,173,130,20,160,168,79,15,208,12,248,162,50,175,115,185,130,222,79,41,237,13,16,197,234,213,250,228,124,15,85,123,43,101,78,96,191,39,159,168,121,52,11,158,19,248,20,128,73,101,127,172,162,79,215,238,230,75,135,246,78,174,177,133,169,110,143,23,132,254,4,44,27,108,177,243,139,13,198,37,21,45,65,150,39,137,100,153,202,106,86,98,30,179,36,227,117,142,106,38,120,13,91,10,56,24,90,108,106,201,249,188,140,75,150,20,115,206,50,1,41,43,51,186,242,60,198,25,231,56,19,138,66,38,227,218,245,13,60,63,28,252,221,33,88,185,62,171,141,61,147,131,243,166,69,123,113,41,165,25,58,127,214,237,171,127,29,198,179,138,32,155,23,48,23,51,86,206,202,154,101,101,146,176,82,41,193,164,18,185,72,121,81,166,28,104,92,194,23,186,106,86,90,66,115,211,163,165,169,25,123,22,31,159,248,87,171,18,42,105,141,241,83,125,14,157,216,121,26,237,236,135,174,128,66,36,74,40,38,18,32,63,18,194,73,206,153,192,12,234,56,43,164,136,37,249,161,23,35,244,235,206,12,86,238,54,212,77,79,197,31,61,1,127,97,177,127,111,87,143,238,202,41,179,255,223,78,245,245,63,52,159,219,104,251,29,106,42,244,29,198,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("924fc06b-cb19-4f36-a6b8-cf093ff6c691"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c0f02aa-82a3-47c5-8208-d996fae17d12"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("29bb462d-f9de-41f8-a19f-9a0a6f6c1b19"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a4fe780-6a8d-4f63-b87b-5a80ff81bce7"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2195e600-5141-46fb-b239-3e0e4a1d1c65"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("023d4b5d-869b-486b-b744-24dbdc8bba9c"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("5efb285c-200d-4e01-90d9-5acd97f421c3"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("638e86b2-8f33-425f-aaa1-33fb04bf366d"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9eb12b6f-8e40-4fd0-b12e-2a3ef8ae2d3e"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("92940858-d280-4045-be1c-4dfc9c628640"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("392ebbf9-7eb2-467c-8926-251c70dea54e"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d723185e-d81c-4915-b608-d9baa29f3ad5"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("02fb567d-b208-4a18-85e9-4dfe4ee10e81"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a33a0ba3-e017-4a51-892a-31febdf691b4"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e85fcae9-ec25-43af-bcd0-47641523512d"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9526e9cd-5214-40c4-a8ce-b2cd44a5bc1e"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ebd64a2d-e832-4590-8e4e-d17eb77d95d2"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8306da24-e061-4f3c-bcaa-f7f14df26208"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaUserTask preconfiguredpageusertask1 = CreatePreconfiguredPageUserTask1UserTask();
			FlowElements.Add(preconfiguredpageusertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaInclusiveGateway inclusivegateway1 = CreateInclusiveGateway1InclusiveGateway();
			FlowElements.Add(inclusivegateway1);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			ProcessSchemaUserTask adddatausertask2 = CreateAddDataUserTask2UserTask();
			FlowElements.Add(adddatausertask2);
			ProcessSchemaUserTask adddatausertask3 = CreateAddDataUserTask3UserTask();
			FlowElements.Add(adddatausertask3);
			ProcessSchemaUserTask autogeneratedpageusertask1 = CreateAutoGeneratedPageUserTask1UserTask();
			FlowElements.Add(autogeneratedpageusertask1);
			ProcessSchemaFormulaTask formulatask5 = CreateFormulaTask5FormulaTask();
			FlowElements.Add(formulatask5);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaFormulaTask formulatask6 = CreateFormulaTask6FormulaTask();
			FlowElements.Add(formulatask6);
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("0374f97e-d765-44ea-9d30-3be8ae09bd89"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{deefb406-4a64-4513-9f48-328ba955695b}]#] != Guid.Empty || [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{839ed405-68e4-4e40-bd9c-062c634c4a20}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(482, 191),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(1401, 100),
				SequenceFlowStartPointPosition = new Point(162, 198),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(162, 11));
			schemaFlow.PolylinePointPositions.Add(new Point(1401, 11));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("5ad4e173-04b5-4649-837c-d22c26b2674f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(327, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5f92367a-0974-4ebf-a32c-d55c04e48d6a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("d688193f-9dd6-4af8-b948-cde51b4c7904"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("8fa9aea6-0bc2-46bc-9e80-649f429aa652"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(144, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c4b6fd4c-b7fd-4417-a51e-f9c612519b8d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow7",
				UId = new Guid("25b9392e-704d-42ed-9624-4190b568f6ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(277, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("5deb83d5-d535-4f74-8eca-57097cadb848"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("88059cf2-ff4e-44cb-920a-375a1aa1430f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("c7e99f46-3a51-422f-be23-20e5e667edab"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{17a010c9-438a-4621-b397-adfd1bbf6b2c}]#] == ""ContactSelected""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(420, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6736c170-cc87-479a-89bc-5a92e7dab75c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(582, 330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("32c6ad93-f028-469b-bdf3-bc06033eb7ea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(730, 376),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("721dfa93-c964-4ad1-bcc6-54248fddf0c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(903, 333),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("7058391b-7d68-4265-a336-03f8c9347da3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(327, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("9eb9df03-804c-4569-a976-83ca81356295"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(730, 376),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("d393627d-e9ed-4c4a-81df-a49ea5c1fcdd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(730, 376),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("67a31b03-747e-4e89-b588-dcf4ad465052"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(368, 114),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("20233c44-02c5-4422-af20-c4c3cefd67f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(1282, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow15",
				UId = new Guid("6fb5aaeb-187b-4bb5-8135-48362af4d054"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(1246, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("b4a7612b-41dd-4dee-9113-e84a5423a170"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{17a010c9-438a-4621-b397-adfd1bbf6b2c}]#] == ""AccountSelected""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(1190, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a2eacbc5-b538-476c-8c03-51467abed9ec"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a2eacbc5-b538-476c-8c03-51467abed9ec"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c4b6fd4c-b7fd-4417-a51e-f9c612519b8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Start1",
				Position = new Point(43, 212),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Terminate1",
				Position = new Point(1387, 100),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreatePreconfiguredPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"PreconfiguredPageUserTask1",
				Position = new Point(232, 198),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializePreconfiguredPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask1",
				Position = new Point(449, 198),
				ResultParameterMetaPath = @"deefb406-4a64-4513-9f48-328ba955695b",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,161,14,131,48,16,6,224,135,65,223,210,107,187,166,87,63,49,197,146,73,130,56,202,223,76,80,68,33,153,32,188,251,208,179,95,242,13,221,240,220,250,239,138,246,206,31,84,77,69,151,13,227,237,210,63,120,44,168,88,247,116,192,136,203,142,65,129,57,147,159,125,33,65,48,196,222,150,128,249,62,217,162,231,21,94,218,180,98,71,75,7,219,2,137,142,201,136,153,200,79,209,144,184,8,210,144,45,123,81,43,226,206,177,27,127,142,172,191,195,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask2",
				Position = new Point(953, 86),
				ResultParameterMetaPath = @"839ed405-68e4-4e40-bd9c-062c634c4a20",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,139,187,14,194,48,12,0,63,166,179,81,66,76,94,59,3,19,72,140,85,6,39,118,196,208,116,72,43,49,84,253,119,50,179,157,78,119,243,52,63,182,231,119,149,254,46,31,105,20,43,45,155,164,203,176,127,226,190,72,147,117,143,71,205,90,51,179,3,228,96,1,139,81,64,193,13,186,49,6,171,184,160,226,115,12,47,234,212,100,151,30,143,171,247,14,51,9,248,170,17,16,71,157,77,177,96,124,81,138,157,241,170,154,51,77,233,7,66,56,231,37,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AddDataUserTask1",
				Position = new Point(449, 86),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask3",
				Position = new Point(708, 86),
				ResultParameterMetaPath = @"deefb406-4a64-4513-9f48-328ba955695b",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,59,14,194,48,12,0,208,195,116,54,2,219,249,238,12,76,32,49,86,25,242,113,196,208,116,72,43,49,84,189,59,153,89,159,244,230,105,126,108,207,239,42,253,157,63,210,162,175,113,217,36,92,134,254,193,125,145,38,235,238,15,36,52,168,233,10,36,170,0,27,38,176,100,9,184,98,177,49,223,18,27,115,142,240,138,61,54,217,165,251,35,187,226,178,67,26,37,225,40,185,66,194,162,32,105,231,164,42,85,52,211,25,166,240,3,91,238,63,192,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway1InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"InclusiveGateway1",
				Position = new Point(134, 198),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask4",
				Position = new Point(834, 86),
				ResultParameterMetaPath = @"fe1f7c0c-c8cf-47c3-bbfe-363c45186118",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AddDataUserTask2",
				Position = new Point(575, 86),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AddDataUserTask3",
				Position = new Point(575, 198),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AutoGeneratedPageUserTask1",
				Position = new Point(344, 86),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAutoGeneratedPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask5FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask5",
				Position = new Point(834, 198),
				ResultParameterMetaPath = @"839ed405-68e4-4e40-bd9c-062c634c4a20",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,205,187,10,194,48,20,128,225,135,113,62,146,251,165,171,116,112,82,112,44,29,78,146,19,20,154,8,109,68,164,244,221,173,171,235,15,31,255,112,24,206,203,229,93,105,190,197,59,21,236,50,78,11,141,199,189,254,133,126,162,66,181,117,43,70,169,165,205,26,152,13,25,148,37,130,224,131,3,135,129,71,76,86,120,105,182,29,92,113,198,66,141,230,110,141,41,219,96,131,0,231,131,6,197,189,1,20,222,67,82,82,80,212,74,25,233,127,164,175,237,209,62,167,231,244,42,181,91,117,52,17,57,35,224,220,49,80,145,211,254,208,12,180,70,43,114,246,33,37,181,141,135,241,11,190,245,233,142,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ReadDataUserTask1",
				Position = new Point(708, 198),
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
				UId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ReadDataUserTask2",
				Position = new Point(232, 86),
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
				UId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ExclusiveGateway1",
				Position = new Point(1072, 86),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask6FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask6",
				Position = new Point(1177, 23),
				ResultParameterMetaPath = @"22ed503f-1097-4afd-9c1c-e7591592243a",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ContactIdentificationV2(userConnection);
		}

		public override object Clone() {
			return new ContactIdentificationV2Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f58fbc05-8179-4074-9636-19e734769536"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactIdentificationV2

	/// <exclude/>
	public class ContactIdentificationV2 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: PreconfiguredPageUserTask1FlowElement

		/// <exclude/>
		public class PreconfiguredPageUserTask1FlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public PreconfiguredPageUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PreconfiguredPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_isCaseIncluded = () => (bool)((process.IsCaseIncluded));
				_createContactButtonCaption = () => new LocalizableString((process.CreateContactButtonCaption));
				_searchDetailSelectButtonCaption = () => new LocalizableString((process.SearchDetailSelectButtonCaption));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.PreconfiguredPageUserTask1.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("4f01d1ce-b5c7-4d19-b354-b5bef74d6e95");
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

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			public virtual Guid ContactId {
				get;
				set;
			}

			public virtual Guid AccountId {
				get;
				set;
			}

			public virtual string ContactName {
				get;
				set;
			}

			public virtual string PhoneNumber {
				get;
				set;
			}

			public virtual string Email {
				get;
				set;
			}

			public virtual bool IsContactSelected {
				get;
				set;
			}

			public virtual string ResultCode {
				get;
				set;
			}

			internal Func<bool> _isCaseIncluded;
			public virtual bool IsCaseIncluded {
				get {
					return (_isCaseIncluded ?? (_isCaseIncluded = () => false)).Invoke();
				}
				set {
					_isCaseIncluded = () => { return value; };
				}
			}

			public virtual string AccountName {
				get;
				set;
			}

			internal Func<string> _createContactButtonCaption;
			public virtual string CreateContactButtonCaption {
				get {
					return (_createContactButtonCaption ?? (_createContactButtonCaption = () => null)).Invoke();
				}
				set {
					_createContactButtonCaption = () => { return value; };
				}
			}

			internal Func<string> _searchDetailSelectButtonCaption;
			public virtual string SearchDetailSelectButtonCaption {
				get {
					return (_searchDetailSelectButtonCaption ?? (_searchDetailSelectButtonCaption = () => null)).Invoke();
				}
				set {
					_searchDetailSelectButtonCaption = () => { return value; };
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

			public AddDataUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Name = () => new LocalizableString(string.IsNullOrEmpty((process.AutoGeneratedPageUserTask1.ContactName) ) ? (process.DefaultContactName).Value : (process.AutoGeneratedPageUserTask1.ContactName) );
				_recordDefValues_Email = () => new LocalizableString((process.AutoGeneratedPageUserTask1.Email));
				_recordDefValues_Account = () => (Guid)((process.AutoGeneratedPageUserTask1.Account));
				_recordDefValues_Phone = () => new LocalizableString((process.AutoGeneratedPageUserTask1.Phone));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Name", () => _recordDefValues_Name.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Email", () => _recordDefValues_Email.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Phone", () => _recordDefValues_Phone.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Name;
			internal Func<string> _recordDefValues_Email;
			internal Func<Guid> _recordDefValues_Account;
			internal Func<string> _recordDefValues_Phone;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,87,75,111,219,70,16,254,43,2,147,67,11,120,133,125,63,116,41,138,216,7,3,121,24,113,154,139,237,195,236,238,108,44,128,162,12,146,106,224,10,250,239,29,210,150,45,27,141,154,186,69,219,32,230,65,34,119,247,155,249,56,59,223,204,114,93,189,236,175,175,176,154,85,31,176,109,161,91,150,126,250,106,217,226,244,164,93,38,236,186,233,235,101,130,122,254,27,196,26,79,160,133,5,246,216,126,132,122,133,221,235,121,215,31,76,30,194,170,131,234,229,175,227,108,53,59,91,87,199,61,46,126,57,206,100,221,155,32,81,8,206,74,194,204,180,143,134,129,139,150,129,22,220,149,96,10,58,65,224,180,172,87,139,230,13,246,112,2,253,101,53,91,87,163,53,50,0,38,37,112,65,50,237,50,25,144,30,152,87,37,50,147,130,140,57,7,87,138,175,54,7,85,151,46,113,1,163,211,123,176,176,17,149,53,130,249,130,100,65,152,192,124,206,156,129,231,42,107,235,85,206,106,0,223,174,191,7,118,125,59,111,62,77,143,187,183,171,186,126,215,30,45,174,250,235,31,206,94,156,29,119,239,62,55,216,158,142,206,102,5,234,14,47,166,52,250,104,224,168,198,5,54,253,108,93,162,16,57,103,199,116,14,150,233,164,200,119,112,116,103,178,14,150,231,164,121,222,16,224,46,196,179,181,85,154,91,145,40,78,193,235,1,23,153,183,133,112,69,43,233,18,104,16,114,115,241,226,98,242,227,228,167,201,215,83,218,241,192,117,10,209,169,194,172,139,137,246,68,33,11,217,90,102,147,212,65,39,19,145,151,193,195,116,220,239,201,108,242,63,123,241,97,199,242,188,187,170,225,250,227,87,110,220,171,22,161,167,137,73,131,159,39,105,217,244,144,250,233,91,242,124,23,199,67,44,176,170,251,237,228,164,25,39,119,66,176,207,196,192,232,234,129,74,118,57,173,207,111,196,118,94,205,206,191,36,183,219,255,155,112,62,20,220,99,173,157,87,7,231,213,233,114,213,166,193,162,162,135,195,157,96,140,78,198,37,143,30,183,226,162,145,134,98,115,59,114,8,61,108,23,110,135,151,121,94,230,152,143,155,211,173,166,70,43,252,246,98,127,240,179,189,110,184,253,29,216,27,104,224,19,182,67,96,239,185,223,177,252,64,97,220,26,206,57,42,16,136,140,59,244,148,47,86,178,232,32,176,204,209,10,31,57,47,49,143,232,247,88,176,197,38,225,19,137,189,199,110,140,246,80,213,110,121,13,161,218,84,155,205,193,110,173,179,38,155,236,137,139,82,198,48,205,29,149,42,240,145,178,63,74,21,41,225,149,130,189,181,46,199,34,185,196,196,146,214,164,0,71,10,136,169,104,70,70,77,20,222,42,201,197,63,95,235,254,29,117,27,176,69,218,236,25,186,52,208,35,142,193,71,199,148,192,12,48,108,92,224,131,186,247,137,251,11,34,60,90,192,188,190,65,62,139,240,123,23,161,180,26,53,102,197,184,49,148,159,142,27,234,34,146,51,69,231,144,98,131,181,209,243,189,34,52,201,38,16,28,153,16,158,83,110,11,36,21,27,206,140,1,39,75,9,116,232,208,223,170,8,165,247,78,71,160,55,42,130,10,140,166,213,81,37,203,148,79,156,103,167,60,47,234,137,34,252,57,165,229,170,233,159,101,248,159,244,194,40,131,225,78,20,230,144,196,167,145,100,232,179,0,22,68,136,69,57,69,137,43,247,201,80,154,236,146,128,200,68,70,74,122,195,5,163,134,37,25,117,35,142,67,226,103,139,127,73,134,84,228,35,71,79,133,192,112,32,66,212,202,64,13,212,132,202,86,37,200,250,79,122,161,167,131,168,231,116,218,119,244,9,65,176,224,89,4,11,76,106,149,130,1,165,56,143,223,170,12,67,212,49,75,106,236,193,41,65,223,52,220,49,224,180,101,33,73,161,10,65,148,118,79,148,225,201,229,178,161,19,233,115,47,252,78,15,164,23,155,223,1,231,63,10,70,218,15,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f58fbc0581794074963619e734769536",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
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

		#region Class: AddDataUserTask2FlowElement

		/// <exclude/>
		public class AddDataUserTask2FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask2FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Contact = () => (Guid)((process.AddDataUserTask1.RecordId));
				_recordDefValues_CommunicationType = () => (Guid)(((Guid)SysSettings.GetValue(UserConnection, "DefaultContactCommunicationType")));
				_recordDefValues_Number = () => new LocalizableString((process.PhoneNumber));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CommunicationType", () => _recordDefValues_CommunicationType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Number", () => _recordDefValues_Number.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_CommunicationType;
			internal Func<string> _recordDefValues_Number;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,77,111,219,70,16,253,43,2,147,163,86,216,239,15,93,237,30,4,36,169,81,167,185,88,62,204,238,206,198,2,40,210,32,169,6,174,160,255,222,33,37,199,114,218,124,32,64,208,22,45,15,226,106,151,239,205,236,206,123,28,238,171,151,195,195,61,86,203,234,45,118,29,244,109,25,22,23,109,135,139,171,174,77,216,247,139,87,109,130,122,243,59,196,26,175,160,131,45,14,216,189,131,122,135,253,171,77,63,204,103,207,97,213,188,122,249,219,180,90,45,111,246,213,106,192,237,175,171,76,236,218,24,158,138,205,172,72,112,76,131,70,22,99,116,172,120,133,30,53,148,200,13,129,83,91,239,182,205,107,28,224,10,134,187,106,185,175,38,54,34,72,69,74,171,141,103,73,36,206,116,230,137,65,65,195,180,176,86,23,153,141,227,88,29,230,85,159,238,112,11,83,208,39,48,231,26,130,144,130,73,81,60,69,23,200,124,16,52,50,137,23,103,44,130,22,35,248,244,252,19,240,230,197,205,170,255,249,67,131,221,245,196,187,44,80,247,120,187,160,217,79,38,126,170,113,139,205,176,220,75,37,157,180,138,51,133,38,51,237,180,98,94,121,197,198,36,61,36,17,181,115,7,2,124,60,205,229,62,133,28,82,144,138,32,81,18,36,21,22,105,71,44,218,16,176,24,147,173,86,135,219,23,183,99,138,121,211,223,215,240,240,238,207,153,190,193,15,179,212,54,3,164,97,49,142,59,76,109,151,103,171,124,4,222,63,171,222,57,116,191,62,138,96,93,45,215,159,147,193,233,126,220,244,115,33,124,170,129,117,53,95,87,215,237,174,75,35,163,26,255,60,214,100,138,192,79,23,251,139,159,199,235,200,49,193,94,67,3,239,177,123,67,17,39,248,180,116,9,3,76,193,223,82,222,143,196,81,6,195,157,40,204,33,4,166,209,74,230,179,0,22,68,136,69,57,37,75,145,19,250,23,44,216,97,147,240,121,98,194,70,84,214,8,230,11,82,25,132,9,132,207,156,129,231,42,107,235,85,206,106,194,79,145,159,146,121,148,43,205,52,187,186,158,2,244,211,254,71,253,159,18,63,173,92,158,149,239,140,161,205,155,178,193,188,106,190,231,168,14,213,225,48,63,55,91,84,138,35,26,218,67,178,228,16,23,4,139,121,84,100,226,96,179,161,163,48,95,54,155,144,69,100,167,128,105,149,136,0,136,42,196,108,73,159,28,19,148,172,74,212,63,194,108,215,15,253,53,14,195,166,121,223,47,46,177,192,174,30,46,142,138,190,104,183,219,93,179,73,48,108,218,102,44,250,215,220,64,84,116,30,179,254,72,183,56,209,144,65,206,120,102,237,253,116,27,197,63,139,15,179,124,12,249,191,95,190,205,47,217,107,155,162,46,172,8,79,111,58,27,168,208,170,20,134,193,138,66,18,1,239,254,29,126,49,70,20,106,68,129,69,29,232,69,173,113,28,101,193,132,161,54,227,208,39,238,236,23,253,194,101,73,128,134,218,25,20,50,13,210,153,4,101,29,139,198,43,225,192,162,196,244,119,54,167,179,94,35,105,123,144,52,103,70,59,218,171,211,158,1,72,203,208,185,24,44,40,67,69,253,122,175,185,186,107,27,252,175,244,149,156,163,162,170,32,227,164,5,250,244,160,190,18,29,117,152,204,209,10,31,57,47,145,30,252,188,79,190,57,177,127,160,79,110,15,127,0,77,176,106,194,34,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f58fbc0581794074963619e734769536",
							"BaseElements.AddDataUserTask2.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
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

		#region Class: AddDataUserTask3FlowElement

		/// <exclude/>
		public class AddDataUserTask3FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask3FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Contact = () => (Guid)((process.PreconfiguredPageUserTask1.ContactId));
				_recordDefValues_CommunicationType = () => (Guid)(((Guid)SysSettings.GetValue(UserConnection, "DefaultContactCommunicationType")));
				_recordDefValues_Number = () => new LocalizableString((process.PhoneNumber));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CommunicationType", () => _recordDefValues_CommunicationType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Number", () => _recordDefValues_Number.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_CommunicationType;
			internal Func<string> _recordDefValues_Number;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,203,142,219,70,16,252,21,129,246,81,45,204,251,161,171,55,135,5,236,100,97,57,190,172,246,208,51,211,227,21,64,145,11,146,178,33,11,250,247,140,40,201,171,117,226,7,12,24,73,144,240,64,74,51,172,234,230,116,85,247,174,122,62,108,31,168,154,87,111,168,235,176,111,243,48,123,209,118,52,187,233,218,72,125,63,123,217,70,172,87,31,49,212,116,131,29,174,105,160,238,45,214,27,234,95,174,250,97,58,121,10,171,166,213,243,247,227,110,53,191,221,85,215,3,173,127,191,78,133,221,75,107,148,76,22,148,97,12,20,106,15,193,171,114,227,76,235,152,48,90,22,11,56,182,245,102,221,188,162,1,111,112,184,175,230,187,106,100,43,4,49,11,97,148,118,16,121,44,4,137,69,192,76,26,20,55,70,101,145,180,101,84,237,167,85,31,239,105,141,99,208,71,48,99,10,61,23,28,4,207,174,68,231,4,206,243,242,75,71,150,173,54,132,138,31,192,167,247,31,129,183,207,110,175,251,223,62,52,212,45,70,222,121,198,186,167,187,89,89,253,108,225,151,154,214,212,12,243,29,49,47,163,44,17,12,231,177,36,170,50,120,50,12,184,18,217,80,210,65,100,220,23,192,167,211,156,239,184,200,228,157,228,192,60,11,160,130,99,224,165,35,64,19,5,87,30,133,247,114,127,247,236,238,144,98,90,245,15,53,110,223,254,57,211,5,97,23,239,39,185,237,38,113,211,15,237,154,186,82,147,102,192,56,28,161,15,79,234,119,9,222,45,143,50,88,86,243,229,151,132,112,122,30,63,251,169,20,62,87,193,178,154,46,171,69,187,233,226,129,81,30,254,156,171,50,70,96,167,11,254,226,118,190,142,28,35,236,21,54,248,142,186,95,75,196,17,62,110,93,225,128,99,240,55,37,239,51,113,16,94,51,203,51,88,66,15,138,140,0,151,56,130,231,62,100,105,165,200,89,140,232,215,148,169,163,38,210,211,196,184,9,36,141,230,224,50,137,34,173,162,82,151,18,3,116,76,38,101,156,76,73,142,248,49,242,99,50,103,193,150,149,102,83,215,99,128,126,252,254,131,3,78,137,159,118,174,46,10,120,193,208,166,85,94,81,186,110,126,228,168,246,213,126,63,189,180,155,242,198,113,111,60,68,97,12,40,137,14,2,83,69,96,65,39,157,172,141,204,233,175,218,173,72,146,39,43,177,96,99,49,25,106,1,62,36,3,146,24,69,204,73,230,160,126,134,221,22,219,126,65,195,176,106,222,245,179,43,202,184,169,135,147,134,95,180,235,245,166,89,69,28,86,109,115,40,250,55,253,176,237,203,121,76,250,35,221,217,10,147,120,201,51,105,31,198,199,65,252,147,176,157,164,99,200,255,253,242,125,126,73,78,153,24,74,135,203,220,165,210,218,125,41,180,204,25,200,27,158,139,68,208,217,127,137,95,172,245,145,138,68,101,196,67,211,102,8,24,141,3,71,74,11,205,120,49,0,125,213,47,76,228,136,164,45,100,204,197,52,116,232,250,210,88,8,186,244,117,139,134,4,197,191,115,60,93,76,27,161,20,97,84,12,180,178,18,148,85,14,16,133,1,178,54,120,131,82,151,162,126,123,218,220,220,183,13,253,87,230,74,74,65,150,170,16,48,75,165,44,169,204,149,96,203,132,73,140,12,119,129,177,28,202,139,95,246,201,119,39,246,15,244,201,221,254,15,25,173,225,11,36,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f58fbc0581794074963619e734769536",
							"BaseElements.AddDataUserTask3.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
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

		#region Class: AutoGeneratedPageUserTask1FlowElement

		/// <exclude/>
		public class AutoGeneratedPageUserTask1FlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public AutoGeneratedPageUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AutoGeneratedPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_contactName = () => new LocalizableString((process.PreconfiguredPageUserTask1.ContactName));
				_phone = () => new LocalizableString((process.PreconfiguredPageUserTask1.PhoneNumber));
				_account = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_email = () => new LocalizableString((process.PreconfiguredPageUserTask1.Email));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("f58fbc0581794074963619e734769536",
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

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			internal Func<string> _contactName;
			public virtual string ContactName {
				get {
					return (_contactName ?? (_contactName = () => null)).Invoke();
				}
				set {
					_contactName = () => { return value; };
				}
			}

			internal Func<string> _phone;
			public virtual string Phone {
				get {
					return (_phone ?? (_phone = () => null)).Invoke();
				}
				set {
					_phone = () => { return value; };
				}
			}

			internal Func<Guid> _account;
			public virtual Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<string> _email;
			public virtual string Email {
				get {
					return (_email ?? (_email = () => null)).Invoke();
				}
				set {
					_email = () => { return value; };
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,219,48,16,252,149,64,231,48,16,41,90,22,125,43,82,183,240,165,9,144,32,151,58,135,21,185,180,137,234,5,146,78,155,26,254,247,174,164,196,113,10,23,113,123,105,171,19,53,152,29,206,190,184,77,116,5,33,124,130,26,147,89,114,139,222,67,104,109,188,248,224,170,136,254,163,111,55,93,114,158,4,244,14,42,247,29,205,136,207,141,139,239,33,2,133,108,151,47,10,203,100,182,60,174,177,76,206,151,137,139,88,7,226,80,136,42,21,64,198,115,102,165,77,153,204,10,205,74,158,90,198,141,225,90,79,141,40,116,49,50,127,37,126,217,214,29,120,28,239,24,228,237,112,188,125,236,122,42,39,64,15,20,23,218,230,9,204,122,19,97,222,64,89,161,161,255,232,55,72,80,244,174,166,108,240,214,213,120,13,158,238,234,117,218,30,34,146,133,42,244,172,10,109,156,127,235,60,134,224,218,230,45,115,213,166,110,14,217,36,128,251,223,39,59,233,224,177,103,94,67,92,15,18,11,178,181,27,92,190,91,173,60,174,32,186,135,67,19,95,240,113,224,157,86,63,10,48,212,165,59,168,54,120,112,231,235,76,46,161,139,99,66,227,245,68,240,110,181,62,57,215,125,197,222,74,87,16,216,61,147,79,212,60,154,131,200,9,124,232,129,81,229,249,184,76,62,47,194,213,215,6,253,141,94,99,13,99,213,238,47,8,253,9,152,87,88,99,19,103,91,76,85,166,51,142,44,231,92,51,105,164,101,10,243,148,113,41,108,142,102,82,10,11,59,10,216,27,154,109,185,176,168,138,140,179,84,165,37,147,101,145,50,149,21,200,32,215,130,75,5,66,169,108,119,63,26,119,161,171,224,241,110,239,239,6,193,235,245,153,109,253,153,222,132,216,214,232,105,86,154,8,58,14,1,125,253,137,54,41,173,201,114,83,50,173,21,50,41,69,193,148,156,72,134,182,80,70,161,229,2,52,205,73,255,245,237,108,87,78,67,117,213,161,167,113,25,218,149,30,31,244,87,27,210,23,209,183,109,28,75,179,111,194,161,157,231,105,147,83,68,171,185,98,92,75,154,54,53,205,89,97,210,148,137,18,83,16,57,78,51,33,201,15,61,20,125,171,110,218,141,215,79,139,25,198,23,226,143,54,255,47,236,243,239,172,232,209,37,57,101,232,255,219,113,94,252,67,211,185,75,118,63,0,158,39,111,237,187,6,0,0 })));
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

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,77,54,75,78,52,52,72,213,53,52,180,48,208,53,73,54,76,213,181,72,52,53,208,53,53,77,52,55,74,75,179,76,74,73,49,1,0,215,224,64,129,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,219,48,16,252,149,64,231,48,144,40,89,150,124,11,82,183,200,165,9,144,32,151,42,135,37,185,178,137,74,162,64,82,105,83,195,255,222,165,100,187,73,225,34,110,47,109,117,34,7,179,163,217,23,55,145,108,192,185,143,208,98,180,136,238,209,90,112,166,246,23,239,117,227,209,126,176,102,232,163,243,200,161,213,208,232,111,168,38,124,169,180,127,7,30,40,100,83,253,80,168,162,69,117,92,163,138,206,171,72,123,108,29,113,40,4,51,174,202,98,94,51,140,179,132,101,69,26,51,136,185,98,169,76,211,88,206,120,206,147,116,98,254,74,252,202,180,61,88,156,254,49,202,215,227,241,254,185,15,212,132,0,57,82,180,51,221,14,76,131,9,183,236,64,52,168,232,238,237,128,4,121,171,91,202,6,239,117,139,183,96,233,95,65,199,4,136,72,53,52,46,176,26,172,253,242,107,111,209,57,109,186,183,204,53,67,219,189,100,147,0,30,174,59,59,241,232,49,48,111,193,175,71,137,73,107,59,250,188,92,173,44,174,192,235,167,151,54,62,227,243,200,60,173,130,20,160,168,79,15,208,12,248,162,50,175,115,185,130,222,79,41,237,13,16,197,234,213,250,228,124,15,85,123,43,101,78,96,191,39,159,168,121,52,11,158,19,248,20,128,73,101,127,172,162,79,215,238,230,75,135,246,78,174,177,133,169,110,143,23,132,254,4,44,27,108,177,243,139,13,198,37,21,45,65,150,39,137,100,153,202,106,86,98,30,179,36,227,117,142,106,38,120,13,91,10,56,24,90,108,106,201,249,188,140,75,150,20,115,206,50,1,41,43,51,186,242,60,198,25,231,56,19,138,66,38,227,218,245,13,60,63,28,252,221,33,88,185,62,171,141,61,147,131,243,166,69,123,113,41,165,25,58,127,214,237,171,127,29,198,179,138,32,155,23,48,23,51,86,206,202,154,101,101,146,176,82,41,193,164,18,185,72,121,81,166,28,104,92,194,23,186,106,86,90,66,115,211,163,165,169,25,123,22,31,159,248,87,171,18,42,105,141,241,83,125,14,157,216,121,26,237,236,135,174,128,66,36,74,40,38,18,32,63,18,194,73,206,153,192,12,234,56,43,164,136,37,249,161,23,35,244,235,206,12,86,238,54,212,77,79,197,31,61,1,127,97,177,127,111,87,143,238,202,41,179,255,223,78,245,245,63,52,159,219,104,251,29,106,42,244,29,198,6,0,0 })));
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

		public ContactIdentificationV2(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactIdentificationV2";
			SchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f58fbc05-8179-4074-9636-19e734769536");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ContactIdentificationV2, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ContactIdentificationV2, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid ContactId {
			get;
			set;
		}

		public virtual Guid AccountId {
			get;
			set;
		}

		public virtual string PhoneNumber {
			get;
			set;
		}

		public virtual bool NewContact {
			get;
			set;
		}

		public virtual bool IsCaseIncluded {
			get;
			set;
		}

		public virtual bool AccountSelected {
			get;
			set;
		}

		public virtual string CreateContactButtonCaption {
			get;
			set;
		}

		public virtual string SearchDetailSelectButtonCaption {
			get;
			set;
		}

		private LocalizableString _defaultContactName;
		public virtual LocalizableString DefaultContactName {
			get {
				return _defaultContactName ?? (_defaultContactName = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "Parameters.DefaultContactName.Value"));
			}
			set {
				_defaultContactName = value;
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
					SchemaElementUId = new Guid("c4b6fd4c-b7fd-4417-a51e-f9c612519b8d"),
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
					SchemaElementUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private PreconfiguredPageUserTask1FlowElement _preconfiguredPageUserTask1;
		public PreconfiguredPageUserTask1FlowElement PreconfiguredPageUserTask1 {
			get {
				return _preconfiguredPageUserTask1 ?? (_preconfiguredPageUserTask1 = new PreconfiguredPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask2Execute,
				});
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.InclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask4Execute,
				});
			}
		}

		private AddDataUserTask2FlowElement _addDataUserTask2;
		public AddDataUserTask2FlowElement AddDataUserTask2 {
			get {
				return _addDataUserTask2 ?? (_addDataUserTask2 = new AddDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask3FlowElement _addDataUserTask3;
		public AddDataUserTask3FlowElement AddDataUserTask3 {
			get {
				return _addDataUserTask3 ?? (_addDataUserTask3 = new AddDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AutoGeneratedPageUserTask1FlowElement _autoGeneratedPageUserTask1;
		public AutoGeneratedPageUserTask1FlowElement AutoGeneratedPageUserTask1 {
			get {
				return _autoGeneratedPageUserTask1 ?? (_autoGeneratedPageUserTask1 = new AutoGeneratedPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask5Execute,
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
					SchemaElementUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
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

		private ProcessScriptTask _formulaTask6;
		public ProcessScriptTask FormulaTask6 {
			get {
				return _formulaTask6 ?? (_formulaTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask6",
					SchemaElementUId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask6Execute,
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
					SchemaElementUId = new Guid("0374f97e-d765-44ea-9d30-3be8ae09bd89"),
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
					SchemaElementUId = new Guid("c7e99f46-3a51-422f-be23-20e5e667edab"),
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
					SchemaElementUId = new Guid("b4a7612b-41dd-4dee-9113-e84a5423a170"),
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
			FlowElements[PreconfiguredPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { PreconfiguredPageUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
			FlowElements[AddDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask2 };
			FlowElements[AddDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask3 };
			FlowElements[AutoGeneratedPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageUserTask1 };
			FlowElements[FormulaTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask5 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[FormulaTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask6 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "PreconfiguredPageUserTask1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask3", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask2", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "InclusiveGateway1":
						bool isInclusiveGateway1ConditionsEvulated = false;
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							isInclusiveGateway1ConditionsEvulated = true;
						} 
						if (!isInclusiveGateway1ConditionsEvulated) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PreconfiguredPageUserTask1", e.Context.SenderName));
						} 
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "AddDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "AddDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "AutoGeneratedPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask5", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask6", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FormulaTask6":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((ContactId) != Guid.Empty || (AccountId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "InclusiveGateway1", "ConditionalFlow1", "(ContactId) != Guid.Empty || (AccountId) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((PreconfiguredPageUserTask1.ResultCode) == "ContactSelected");
			Log.InfoFormat(ConditionalExpressionLogMessage, "PreconfiguredPageUserTask1", "ConditionalFlow2", "(PreconfiguredPageUserTask1.ResultCode) == \"ContactSelected\"", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((PreconfiguredPageUserTask1.ResultCode) == "AccountSelected");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow3", "(PreconfiguredPageUserTask1.ResultCode) == \"AccountSelected\"", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PreconfiguredPageUserTask1.ContactId")) {
				writer.WriteValue("PreconfiguredPageUserTask1.ContactId", PreconfiguredPageUserTask1.ContactId, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.AccountId")) {
				writer.WriteValue("PreconfiguredPageUserTask1.AccountId", PreconfiguredPageUserTask1.AccountId, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.ContactName")) {
				writer.WriteValue("PreconfiguredPageUserTask1.ContactName", PreconfiguredPageUserTask1.ContactName, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.PhoneNumber")) {
				writer.WriteValue("PreconfiguredPageUserTask1.PhoneNumber", PreconfiguredPageUserTask1.PhoneNumber, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.Email")) {
				writer.WriteValue("PreconfiguredPageUserTask1.Email", PreconfiguredPageUserTask1.Email, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.IsContactSelected")) {
				writer.WriteValue("PreconfiguredPageUserTask1.IsContactSelected", PreconfiguredPageUserTask1.IsContactSelected, false);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.ResultCode")) {
				writer.WriteValue("PreconfiguredPageUserTask1.ResultCode", PreconfiguredPageUserTask1.ResultCode, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.IsCaseIncluded")) {
				writer.WriteValue("PreconfiguredPageUserTask1.IsCaseIncluded", PreconfiguredPageUserTask1.IsCaseIncluded, false);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.AccountName")) {
				writer.WriteValue("PreconfiguredPageUserTask1.AccountName", PreconfiguredPageUserTask1.AccountName, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.CreateContactButtonCaption")) {
				writer.WriteValue("PreconfiguredPageUserTask1.CreateContactButtonCaption", PreconfiguredPageUserTask1.CreateContactButtonCaption, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption")) {
				writer.WriteValue("PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption", PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption, null);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.ContactName")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.ContactName", AutoGeneratedPageUserTask1.ContactName, null);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.Phone")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.Phone", AutoGeneratedPageUserTask1.Phone, null);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.Account")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.Account", AutoGeneratedPageUserTask1.Account, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.Email")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.Email", AutoGeneratedPageUserTask1.Email, null);
			}
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("AccountId")) {
				writer.WriteValue("AccountId", AccountId, Guid.Empty);
			}
			if (!HasMapping("PhoneNumber")) {
				writer.WriteValue("PhoneNumber", PhoneNumber, null);
			}
			if (!HasMapping("NewContact")) {
				writer.WriteValue("NewContact", NewContact, false);
			}
			if (!HasMapping("IsCaseIncluded")) {
				writer.WriteValue("IsCaseIncluded", IsCaseIncluded, false);
			}
			if (!HasMapping("AccountSelected")) {
				writer.WriteValue("AccountSelected", AccountSelected, false);
			}
			if (!HasMapping("CreateContactButtonCaption")) {
				writer.WriteValue("CreateContactButtonCaption", CreateContactButtonCaption, null);
			}
			if (!HasMapping("SearchDetailSelectButtonCaption")) {
				writer.WriteValue("SearchDetailSelectButtonCaption", SearchDetailSelectButtonCaption, null);
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
			MetaPathParameterValues.Add("deefb406-4a64-4513-9f48-328ba955695b", () => ContactId);
			MetaPathParameterValues.Add("839ed405-68e4-4e40-bd9c-062c634c4a20", () => AccountId);
			MetaPathParameterValues.Add("244eac40-5473-4748-aa26-e77b96a35846", () => PhoneNumber);
			MetaPathParameterValues.Add("fe1f7c0c-c8cf-47c3-bbfe-363c45186118", () => NewContact);
			MetaPathParameterValues.Add("e5e56c22-18ea-449c-b1be-62a59c96abd7", () => IsCaseIncluded);
			MetaPathParameterValues.Add("22ed503f-1097-4afd-9c1c-e7591592243a", () => AccountSelected);
			MetaPathParameterValues.Add("77a86efd-52da-41d3-b551-b2af78145723", () => CreateContactButtonCaption);
			MetaPathParameterValues.Add("ce1af657-ffbd-40aa-8ba8-92e5d0b88a47", () => SearchDetailSelectButtonCaption);
			MetaPathParameterValues.Add("04c9b73f-67bc-483e-9d66-6c2494c5be0f", () => DefaultContactName);
			MetaPathParameterValues.Add("69b15c71-905e-4fe2-b8c8-13247e6c2e08", () => PreconfiguredPageUserTask1.Title);
			MetaPathParameterValues.Add("7e141f0a-9d5c-457c-a67f-0a1d278e31bd", () => PreconfiguredPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("1b7e2a98-62c5-480f-87de-803a6fd6bd04", () => PreconfiguredPageUserTask1.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("55b46c6d-9866-4800-b1a5-66f885cd2355", () => PreconfiguredPageUserTask1.EntityId);
			MetaPathParameterValues.Add("0ae7e716-e7cc-4a75-ae50-55d0030ffc0a", () => PreconfiguredPageUserTask1.EntryPointId);
			MetaPathParameterValues.Add("d602fd51-f1ec-46f8-a61c-e2a65578dafd", () => PreconfiguredPageUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("03340eb8-8dc3-4cfa-803e-9f3b3bc34101", () => PreconfiguredPageUserTask1.UseCardProcessModule);
			MetaPathParameterValues.Add("8c360d85-bf72-4c87-8c17-d3163c1c7d9d", () => PreconfiguredPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("972c2fff-1e7a-4897-88b5-1b6a3de96469", () => PreconfiguredPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("6943ab1a-dce8-4c57-bd3b-eb4715dcb1d5", () => PreconfiguredPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("23145d3b-45a3-4a9a-b019-f296e0cbcfb0", () => PreconfiguredPageUserTask1.IsRunning);
			MetaPathParameterValues.Add("4a5221ff-1dfa-4371-aa3b-b83fc6ef48f2", () => PreconfiguredPageUserTask1.Template);
			MetaPathParameterValues.Add("c003612c-32bf-4743-9ddc-9cd6eddfff56", () => PreconfiguredPageUserTask1.Module);
			MetaPathParameterValues.Add("993430b0-b3fc-4871-a50f-48baed943409", () => PreconfiguredPageUserTask1.PressedButtonCode);
			MetaPathParameterValues.Add("3f7bb4ba-649e-4dbc-9238-e0630e06179b", () => PreconfiguredPageUserTask1.Url);
			MetaPathParameterValues.Add("12fe9831-090b-4b80-938e-a6c2149a2993", () => PreconfiguredPageUserTask1.ContactId);
			MetaPathParameterValues.Add("6f5535c1-cef2-4fab-aa8c-101f094e1360", () => PreconfiguredPageUserTask1.AccountId);
			MetaPathParameterValues.Add("aba17913-301c-4b8a-8b12-d315eba94a55", () => PreconfiguredPageUserTask1.ContactName);
			MetaPathParameterValues.Add("f0c052d1-ca27-43fa-bd30-40cbc6d55b3d", () => PreconfiguredPageUserTask1.PhoneNumber);
			MetaPathParameterValues.Add("fc1e2817-ed80-4462-81b7-66965f9c76df", () => PreconfiguredPageUserTask1.Email);
			MetaPathParameterValues.Add("154e18f3-415a-442d-a42b-a1ab3f228aa9", () => PreconfiguredPageUserTask1.IsContactSelected);
			MetaPathParameterValues.Add("17a010c9-438a-4621-b397-adfd1bbf6b2c", () => PreconfiguredPageUserTask1.ResultCode);
			MetaPathParameterValues.Add("f9936a9b-7364-4807-886d-c47923aa5526", () => PreconfiguredPageUserTask1.IsCaseIncluded);
			MetaPathParameterValues.Add("fc227909-1872-4ba3-9409-260e522e5bda", () => PreconfiguredPageUserTask1.AccountName);
			MetaPathParameterValues.Add("932357b5-6b5b-4d70-b80b-a52c2cd999a5", () => PreconfiguredPageUserTask1.CreateContactButtonCaption);
			MetaPathParameterValues.Add("36bf19ed-4a1b-46d1-8360-7b98a0a05451", () => PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption);
			MetaPathParameterValues.Add("2cc3931e-cae7-49e3-8cf0-9ce37b4622d1", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("52f0c27a-aa7b-4b1a-81a6-d96439fb602b", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("e33fa283-1e3e-45ee-a4c9-cd8f02f2bd1f", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("3b08e0b0-95c8-4039-b074-cc84d0e02189", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("03c59888-3e70-4fc6-b8d8-8ca80b0c1a0f", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("c9d9c923-3eb2-47cf-b2d5-b699ef55d643", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("50baaec3-b4b2-4696-8e6e-0a52599c84ce", () => AddDataUserTask2.EntitySchemaId);
			MetaPathParameterValues.Add("95bbe5fe-f292-4542-8914-7e0d64c9dd0b", () => AddDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("0a7fa4bd-042f-431c-bd8d-a294932edf78", () => AddDataUserTask2.RecordAddMode);
			MetaPathParameterValues.Add("4314f4b3-ed6a-4fd8-be55-31d309df8a90", () => AddDataUserTask2.FilterEntitySchemaId);
			MetaPathParameterValues.Add("362a0f68-4c27-4983-b9fe-775a0850402c", () => AddDataUserTask2.RecordDefValues);
			MetaPathParameterValues.Add("eec63597-7c61-4178-ab9d-589c0450ab30", () => AddDataUserTask2.RecordId);
			MetaPathParameterValues.Add("040ed64a-eb19-4f89-925d-c9522c5d6854", () => AddDataUserTask3.EntitySchemaId);
			MetaPathParameterValues.Add("cda6b132-0e59-45bb-988a-dd98d098385b", () => AddDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("611a2e2a-44ad-46d6-a803-86b905065d78", () => AddDataUserTask3.RecordAddMode);
			MetaPathParameterValues.Add("a85205de-fa99-4c50-85d5-7011ef3b4d0e", () => AddDataUserTask3.FilterEntitySchemaId);
			MetaPathParameterValues.Add("ac5bb6e7-6eff-457f-b790-d236a0edda50", () => AddDataUserTask3.RecordDefValues);
			MetaPathParameterValues.Add("415de17c-c12f-4817-8781-82b8431e8c3d", () => AddDataUserTask3.RecordId);
			MetaPathParameterValues.Add("369adb53-be77-4d6a-9958-3b4c83ca70fe", () => AutoGeneratedPageUserTask1.Title);
			MetaPathParameterValues.Add("6e13b431-433e-4be7-8eee-468eed2a7d09", () => AutoGeneratedPageUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("5408038c-ac80-4220-b5cc-f215a44ba230", () => AutoGeneratedPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("206826a5-918d-4250-8a64-287b1bde9a2b", () => AutoGeneratedPageUserTask1.EntityId);
			MetaPathParameterValues.Add("b9a46d74-6ecd-4ff8-8131-73d06aa4f4bd", () => AutoGeneratedPageUserTask1.Buttons);
			MetaPathParameterValues.Add("5e2f306b-000b-4710-81f9-7b949ea2ad54", () => AutoGeneratedPageUserTask1.Elements);
			MetaPathParameterValues.Add("830320f1-bd81-4cea-9f95-a80eadbd7767", () => AutoGeneratedPageUserTask1.ExtendedClientModule);
			MetaPathParameterValues.Add("6098bc34-95ad-496c-a3b2-81e95b073100", () => AutoGeneratedPageUserTask1.EntryPointId);
			MetaPathParameterValues.Add("300e12bc-e3f7-49b2-8167-6ffb30b989af", () => AutoGeneratedPageUserTask1.PressedButtonCode);
			MetaPathParameterValues.Add("0f482d41-ab86-41fc-b865-2e19e647b9aa", () => AutoGeneratedPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("8c0b7c0a-66fd-4a5b-9457-bf3729096fef", () => AutoGeneratedPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("ecbfdeeb-28bb-4777-abb9-4dc8ec14f22e", () => AutoGeneratedPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("76840c62-b319-4288-b212-45c7398a6f01", () => AutoGeneratedPageUserTask1.IsRunning);
			MetaPathParameterValues.Add("634061c5-a984-4d9b-86f0-af4327ca4a12", () => AutoGeneratedPageUserTask1.ContactName);
			MetaPathParameterValues.Add("9b4bd2f4-9731-4207-a062-9c213f0dc347", () => AutoGeneratedPageUserTask1.Phone);
			MetaPathParameterValues.Add("28874bae-8f14-4476-b3c6-38c00d7380f3", () => AutoGeneratedPageUserTask1.Account);
			MetaPathParameterValues.Add("5a6f26d8-e7c2-41e2-98b7-31edaab7a990", () => AutoGeneratedPageUserTask1.Email);
			MetaPathParameterValues.Add("b1517598-2489-44aa-aaa6-5640f2853121", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("6afebec2-bcc5-4267-b4d1-642bc77d9b47", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("27a93232-ccc8-48ad-9eff-1ad1ea4b60eb", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("60e46248-0ebb-4ee8-a1bc-4ee2f5b4a0b1", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("dd28bfbd-e627-4d61-a3fd-91ebd0891488", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("1b16fad7-4ecc-4715-be57-b6aa7d76d4b9", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("4ae849fb-aa93-4b31-98f6-6818622659e0", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("cdf7b7b2-89b5-4196-a299-d432ec544639", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("3c555a9a-084f-46b0-97da-7805b5965ddc", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("628c1898-b678-4647-b7e5-8624e2a20a4b", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("05f3c3a8-49ec-4ef1-923a-b82935dad796", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("bc3bc9a9-a676-4a08-b8d4-3eca60a51ec1", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("712197a2-16fc-411c-a0b8-ad059a020d40", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("fb660a18-6ba8-4292-86c1-b614908a8d63", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("2519b17d-ed42-4ff6-bb3c-7ebb21fcc7d5", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("c735c402-0b9e-406d-a4e0-cbb66e7839f7", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("75c9c0ab-0f22-4b23-9b18-aa90e393a626", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a27c7b13-58a7-4ad4-b15a-448de74c1d65", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("9ddc6a96-8c0e-469b-9ff3-8706adc2e1ae", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("fbab1060-c0b1-4f93-867c-7266001affb5", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("924fc06b-cb19-4f36-a6b8-cf093ff6c691", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("7c0f02aa-82a3-47c5-8208-d996fae17d12", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("29bb462d-f9de-41f8-a19f-9a0a6f6c1b19", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("2a4fe780-6a8d-4f63-b87b-5a80ff81bce7", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("2195e600-5141-46fb-b239-3e0e4a1d1c65", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("023d4b5d-869b-486b-b744-24dbdc8bba9c", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("5efb285c-200d-4e01-90d9-5acd97f421c3", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("638e86b2-8f33-425f-aaa1-33fb04bf366d", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("9eb12b6f-8e40-4fd0-b12e-2a3ef8ae2d3e", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("92940858-d280-4045-be1c-4dfc9c628640", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("392ebbf9-7eb2-467c-8926-251c70dea54e", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("d723185e-d81c-4915-b608-d9baa29f3ad5", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("02fb567d-b208-4a18-85e9-4dfe4ee10e81", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("a33a0ba3-e017-4a51-892a-31febdf691b4", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("e85fcae9-ec25-43af-bcd0-47641523512d", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9526e9cd-5214-40c4-a8ce-b2cd44a5bc1e", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ebd64a2d-e832-4590-8e4e-d17eb77d95d2", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("8306da24-e061-4f3c-bcaa-f7f14df26208", () => ReadDataUserTask2.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PreconfiguredPageUserTask1.ContactId":
					PreconfiguredPageUserTask1.ContactId = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageUserTask1.AccountId":
					PreconfiguredPageUserTask1.AccountId = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageUserTask1.ContactName":
					PreconfiguredPageUserTask1.ContactName = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.PhoneNumber":
					PreconfiguredPageUserTask1.PhoneNumber = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.Email":
					PreconfiguredPageUserTask1.Email = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.IsContactSelected":
					PreconfiguredPageUserTask1.IsContactSelected = reader.GetValue<System.Boolean>();
				break;
				case "PreconfiguredPageUserTask1.ResultCode":
					PreconfiguredPageUserTask1.ResultCode = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.IsCaseIncluded":
					PreconfiguredPageUserTask1.IsCaseIncluded = reader.GetValue<System.Boolean>();
				break;
				case "PreconfiguredPageUserTask1.AccountName":
					PreconfiguredPageUserTask1.AccountName = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.CreateContactButtonCaption":
					PreconfiguredPageUserTask1.CreateContactButtonCaption = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption":
					PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageUserTask1.ContactName":
					AutoGeneratedPageUserTask1.ContactName = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageUserTask1.Phone":
					AutoGeneratedPageUserTask1.Phone = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageUserTask1.Account":
					AutoGeneratedPageUserTask1.Account = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageUserTask1.Email":
					AutoGeneratedPageUserTask1.Email = reader.GetValue<System.String>();
				break;
				case "ContactId":
					if (!hasValueToRead) break;
					ContactId = reader.GetValue<System.Guid>();
				break;
				case "AccountId":
					if (!hasValueToRead) break;
					AccountId = reader.GetValue<System.Guid>();
				break;
				case "PhoneNumber":
					if (!hasValueToRead) break;
					PhoneNumber = reader.GetValue<System.String>();
				break;
				case "NewContact":
					if (!hasValueToRead) break;
					NewContact = reader.GetValue<System.Boolean>();
				break;
				case "IsCaseIncluded":
					if (!hasValueToRead) break;
					IsCaseIncluded = reader.GetValue<System.Boolean>();
				break;
				case "AccountSelected":
					if (!hasValueToRead) break;
					AccountSelected = reader.GetValue<System.Boolean>();
				break;
				case "CreateContactButtonCaption":
					if (!hasValueToRead) break;
					CreateContactButtonCaption = reader.GetValue<System.String>();
				break;
				case "SearchDetailSelectButtonCaption":
					if (!hasValueToRead) break;
					SearchDetailSelectButtonCaption = reader.GetValue<System.String>();
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
			var localContactId = (PreconfiguredPageUserTask1.ContactId);
			ContactId = (System.Guid)localContactId;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localAccountId = (AutoGeneratedPageUserTask1.Account);
			AccountId = (System.Guid)localAccountId;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localContactId = (AddDataUserTask1.RecordId);
			ContactId = (System.Guid)localContactId;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localNewContact = true;
			NewContact = (System.Boolean)localNewContact;
			return true;
		}

		public virtual bool FormulaTask5Execute(ProcessExecutingContext context) {
			var localAccountId = ((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty));
			AccountId = (System.Guid)localAccountId;
			return true;
		}

		public virtual bool FormulaTask6Execute(ProcessExecutingContext context) {
			var localAccountSelected = true;
			AccountSelected = (System.Boolean)localAccountSelected;
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
			var cloneItem = (ContactIdentificationV2)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

