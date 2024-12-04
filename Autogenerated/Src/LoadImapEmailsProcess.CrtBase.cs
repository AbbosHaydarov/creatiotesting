namespace Terrasoft.Core.Process
{

	using IntegrationApi.Interfaces;
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
	using Terrasoft.Mail;

	#region Class: LoadImapEmailsProcessSchema

	/// <exclude/>
	public class LoadImapEmailsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LoadImapEmailsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LoadImapEmailsProcessSchema(LoadImapEmailsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoadImapEmailsProcess";
			UId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			BackgroundModePriority = BackgroundModePriority.Medium;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,89,91,111,219,54,20,126,118,129,254,7,85,79,114,97,43,78,236,220,144,11,16,59,118,235,173,105,178,58,89,158,105,137,78,132,201,148,75,82,73,188,33,255,125,231,144,148,117,119,212,98,216,128,181,15,150,168,195,239,28,158,203,199,67,230,253,187,85,60,15,3,207,122,10,184,140,73,104,77,199,44,94,82,78,230,33,61,253,20,7,254,185,245,137,202,81,204,57,101,242,78,80,126,69,130,112,30,189,204,214,204,123,228,17,11,254,36,50,136,216,140,74,25,176,7,113,55,245,133,211,182,254,122,255,174,245,68,184,181,220,42,60,102,50,144,235,153,247,72,151,196,58,179,16,125,20,49,70,61,20,114,179,95,175,8,35,15,148,187,96,202,148,9,73,152,71,135,235,175,100,73,29,59,99,79,130,107,183,79,140,126,154,193,248,45,166,124,13,106,24,125,182,198,197,113,231,109,229,29,171,185,174,81,20,198,75,6,202,74,6,184,23,190,175,191,58,205,157,131,235,190,225,193,146,240,181,158,171,150,222,86,170,203,26,38,65,40,41,23,168,201,1,129,10,137,17,167,68,82,45,119,31,200,199,27,194,1,16,39,57,122,112,20,45,87,132,7,34,98,183,235,21,117,199,223,33,51,58,22,130,181,236,217,90,92,248,203,128,221,177,64,218,157,98,212,50,153,226,78,253,255,200,68,140,211,140,242,39,176,1,63,130,149,24,116,204,102,199,62,26,12,38,189,163,254,97,119,124,113,209,235,14,38,131,94,119,120,124,176,223,61,220,157,236,95,14,143,199,23,227,131,177,221,110,111,194,250,29,205,249,70,69,28,74,81,25,80,136,141,142,21,132,38,212,94,40,100,147,194,226,84,198,156,89,11,30,45,45,174,224,172,128,229,209,5,197,249,230,43,226,162,241,38,91,126,39,97,108,10,210,41,103,154,139,9,129,106,94,223,191,195,255,133,154,70,127,128,67,125,156,72,66,129,21,157,186,40,243,193,65,124,85,180,250,19,84,115,90,203,198,104,93,64,5,68,71,45,49,88,88,78,110,178,245,225,76,121,221,29,47,87,114,173,161,74,181,98,202,171,76,0,96,101,78,194,177,43,170,210,110,91,68,88,21,31,208,160,13,7,105,139,10,124,67,155,19,140,158,175,107,125,11,104,169,70,65,75,181,100,77,69,255,8,126,61,182,254,46,80,135,89,68,67,115,83,253,158,46,227,116,237,38,238,183,148,115,34,162,133,4,37,108,17,60,196,92,145,150,155,10,86,229,190,134,220,168,17,183,209,132,74,239,209,96,126,9,132,60,21,146,3,235,157,235,20,105,217,64,12,144,111,194,238,232,215,155,136,203,228,25,240,103,179,47,201,219,84,204,36,225,242,54,20,54,14,188,22,212,85,169,202,186,64,175,253,220,120,126,17,1,235,128,176,147,183,23,11,181,108,189,73,231,86,94,145,162,180,198,113,73,81,53,225,180,160,126,91,170,142,74,1,112,21,252,4,232,227,114,216,36,158,157,124,29,119,10,14,105,39,230,27,182,249,28,9,172,237,178,90,19,137,147,172,48,134,163,82,24,63,228,36,49,88,34,172,148,213,113,204,73,39,161,172,148,79,35,189,241,212,107,202,171,26,161,150,1,127,165,107,197,160,55,36,224,167,21,219,120,167,200,104,170,237,73,181,171,164,174,34,202,173,173,80,145,60,183,247,78,25,106,45,88,87,85,83,121,212,140,109,13,8,122,171,209,149,164,141,51,155,172,161,148,165,219,253,147,79,194,226,54,117,86,191,81,53,178,37,157,10,170,78,234,21,97,42,114,67,215,141,128,19,249,183,48,111,136,16,207,17,247,127,4,55,153,179,13,123,70,153,15,165,143,254,53,229,217,84,67,121,102,174,152,74,251,252,79,212,13,226,53,138,79,167,58,127,179,221,82,177,170,119,62,22,234,250,41,130,58,188,225,20,90,65,186,93,219,13,236,239,215,43,202,224,217,193,95,124,71,127,223,18,241,135,21,21,6,154,158,96,212,28,40,153,179,76,131,185,240,232,209,209,193,128,118,15,231,189,221,238,96,239,152,118,143,247,118,105,183,183,127,208,247,14,247,246,125,248,77,79,13,219,241,63,241,192,175,210,225,29,121,116,183,79,122,221,254,81,255,160,59,152,147,195,238,188,127,116,12,79,199,116,175,183,59,232,237,246,61,173,163,184,50,23,95,210,102,218,160,94,6,138,88,96,243,48,27,113,199,50,27,178,179,177,116,149,76,196,73,111,193,66,79,86,143,153,80,17,6,108,24,189,76,162,16,114,18,87,152,35,30,197,12,149,122,180,55,26,123,78,101,120,106,189,218,161,237,24,0,167,254,91,231,23,247,54,154,41,155,205,97,235,213,162,161,160,42,57,172,159,183,109,155,93,156,122,80,252,202,50,67,126,128,51,245,139,190,106,151,44,171,138,53,230,57,72,155,134,86,89,150,188,24,253,165,41,240,96,92,112,1,14,121,2,219,30,144,22,37,143,145,237,94,63,238,212,20,98,218,24,222,77,221,123,58,7,151,74,30,1,87,109,30,174,128,108,212,98,25,13,205,218,148,234,236,120,254,234,128,25,229,112,226,148,116,137,168,238,103,41,87,136,72,95,160,3,213,118,186,159,9,243,67,232,80,33,231,106,173,64,164,77,201,101,20,26,1,80,178,117,42,28,88,153,111,70,134,235,81,24,128,94,8,74,98,35,92,13,12,137,200,173,4,226,135,62,75,235,60,187,250,179,74,27,182,217,95,233,197,12,81,102,241,178,113,170,162,203,217,99,244,60,246,3,153,164,163,129,52,190,223,217,169,48,183,54,92,39,197,25,32,172,171,220,157,68,124,73,164,243,149,82,31,52,85,147,179,1,211,187,200,155,5,147,230,188,61,132,35,186,214,157,181,20,75,40,89,77,19,189,121,204,175,118,187,3,245,177,80,118,131,208,136,172,240,7,26,105,45,173,20,58,78,134,215,144,173,54,172,214,54,160,162,173,42,185,80,176,29,171,137,65,133,170,126,173,15,226,101,244,204,194,136,248,106,43,23,216,112,25,133,185,214,52,219,130,138,98,19,85,236,175,138,61,110,138,225,170,30,32,161,237,15,229,115,250,84,76,224,186,38,230,116,204,240,226,16,120,236,58,212,166,77,161,86,31,244,33,17,66,150,222,0,8,213,68,8,1,227,96,199,40,132,174,103,66,60,25,233,11,149,211,233,44,253,126,14,7,127,132,50,215,56,160,25,60,30,163,236,5,127,128,187,74,38,129,206,189,18,149,183,245,9,177,118,138,40,181,66,0,81,114,82,69,199,100,142,106,153,21,232,131,139,57,68,234,138,76,56,89,194,157,163,90,116,44,32,172,250,100,9,167,180,213,236,141,245,79,243,50,231,234,154,172,126,249,185,149,215,184,162,118,182,151,46,183,202,5,111,204,14,163,135,128,37,116,183,233,232,11,107,116,241,25,215,132,233,102,28,213,74,10,102,20,197,12,27,206,226,156,111,116,25,73,58,122,36,44,17,74,155,85,203,35,120,172,119,16,115,252,226,81,85,170,22,5,245,45,148,249,113,22,51,83,158,9,199,22,209,212,190,105,143,224,162,79,224,107,178,75,22,207,99,238,125,110,150,129,171,99,166,188,138,142,69,221,148,6,245,131,186,209,52,152,218,184,198,180,179,41,218,12,110,69,175,80,205,44,138,58,114,109,135,26,89,36,77,71,134,75,66,227,154,153,186,179,44,58,4,77,54,215,29,213,55,244,176,99,66,143,163,229,144,188,106,238,241,213,247,47,116,33,175,99,104,43,127,137,2,128,83,125,9,220,121,104,102,181,219,238,117,121,16,224,241,124,166,1,90,112,117,160,174,135,107,77,49,195,233,20,247,254,145,114,90,5,139,86,111,240,204,229,235,166,239,117,54,158,82,183,146,218,55,232,241,76,241,251,243,241,11,245,98,40,161,170,63,121,8,224,208,203,97,58,4,17,211,221,38,252,51,91,61,248,222,213,16,116,230,145,144,112,115,43,156,2,111,15,178,206,155,76,152,203,12,231,252,179,145,46,43,248,255,69,254,170,208,159,255,171,9,144,156,213,106,82,224,111,179,245,56,231,228,27,0,0 };
			RealUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			Version = 0;
			PackageUId = new Guid("06d9ef10-51d8-122c-8933-9212e84236c9");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4fe53caa-18f6-4c4b-b63b-d475fe7b8a0f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b9ae9fb7-09a7-4689-89fe-c1c439f10368"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentUserMailboxSynchronizationSettingsUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ff591096-1b06-47b0-a988-cbd658b46fef"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"CurrentUserMailboxSynchronizationSettingsUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMailboxSynchronizationSettingsPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be94aa4b-5b04-442f-88b6-6841d5c40218"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MailboxSynchronizationSettingsPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"fce8864e-7b01-429e-921e-0563c725d563",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetMailboxSynchronizationMessageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9891be68-d59b-4533-9be3-85e194af599f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"NeedSetMailboxSynchronizationMessageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{E9D59B5B-D6D0-47D6-9F8E-C475806C019C}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMailBoxFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3be2837e-0163-4330-836b-ffca8a2909be"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MailBoxFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("532cb61b-8379-42bc-9a48-99fd98f7801b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("574326c8-1b08-4af9-9e49-7da640ea2c9e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"Messages",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagesCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("562516d4-4d62-4421-b65f-3924fb92a101"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MessagesCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9df9ed0b-1c24-40f3-94dc-f7cfa995d7db"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetMailboxSynchronizationMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("21444bbc-5fee-4669-9cb3-26a7af386911"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"NeedSetMailboxSynchronizationMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateInformationCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c7cc5b5d-0efd-428c-80d5-c6feea55dec6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"InformationCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessLoadEmailsMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e255669d-4628-4d24-b91e-f4e34a99cc0a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"SuccessLoadEmailsMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateCurrentUserMailboxSynchronizationSettingsUIdParameter());
			Parameters.Add(CreateMailboxSynchronizationSettingsPageUIdParameter());
			Parameters.Add(CreateNeedSetMailboxSynchronizationMessageUIdParameter());
			Parameters.Add(CreateMailBoxFolderIdParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateMessagesParameter());
			Parameters.Add(CreateMessagesCountParameter());
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateNeedSetMailboxSynchronizationMessageParameter());
			Parameters.Add(CreateInformationCaptionParameter());
			Parameters.Add(CreateSuccessLoadEmailsMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLoadImapEmailsUserTaskLaneSet = CreateLoadImapEmailsUserTaskLaneSetLaneSet();
			LaneSets.Add(schemaLoadImapEmailsUserTaskLaneSet);
			ProcessSchemaLane schemaLoadImapEmailsUserTaskLane = CreateLoadImapEmailsUserTaskLaneLane();
			schemaLoadImapEmailsUserTaskLaneSet.Lanes.Add(schemaLoadImapEmailsUserTaskLane);
			ProcessSchemaStartEvent loadimapemailsusertaskstart = CreateLoadImapEmailsUserTaskStartStartEvent();
			FlowElements.Add(loadimapemailsusertaskstart);
			ProcessSchemaEndEvent loadimapemailsusertaskend = CreateLoadImapEmailsUserTaskEndEndEvent();
			FlowElements.Add(loadimapemailsusertaskend);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("336acfd9-6be3-4f8e-9ee0-842af3c10118"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				CurveCenterPosition = new Point(374, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4fcbcae3-6713-47fc-ade0-561c841d572b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				CurveCenterPosition = new Point(440, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLoadImapEmailsUserTaskLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaLoadImapEmailsUserTaskLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("21cd00c5-c917-4b96-a25b-d555ef360329"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskLaneSet",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLoadImapEmailsUserTaskLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLoadImapEmailsUserTaskLaneLane() {
			ProcessSchemaLane schemaLoadImapEmailsUserTaskLane = new ProcessSchemaLane(this) {
				UId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("21cd00c5-c917-4b96-a25b-d555ef360329"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskLane",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLoadImapEmailsUserTaskLane;
		}

		protected virtual ProcessSchemaStartEvent CreateLoadImapEmailsUserTaskStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskStart",
				Position = new Point(50, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateLoadImapEmailsUserTaskEndEndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskEnd",
				Position = new Point(547, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"ScriptTask1",
				Position = new Point(267, 177),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,147,81,79,219,48,20,133,159,139,196,127,184,228,1,37,162,137,18,65,17,99,235,164,209,164,168,26,29,18,21,123,161,60,120,205,165,181,148,216,147,237,80,186,42,255,125,118,236,38,93,181,13,41,15,177,125,239,185,223,57,113,166,40,37,89,162,132,33,48,92,67,74,23,138,114,70,196,230,211,109,69,243,62,72,37,40,91,126,246,131,143,199,71,175,68,128,224,92,101,37,161,197,152,23,57,138,73,238,26,77,181,239,37,87,201,248,67,122,126,17,14,210,44,11,179,56,73,194,47,87,151,55,97,28,39,131,65,26,95,140,226,36,245,140,20,125,1,127,170,85,110,248,91,39,52,108,84,162,172,252,169,54,1,108,143,143,122,179,21,95,103,57,85,51,84,74,99,200,169,165,109,104,122,2,85,37,24,40,81,161,94,214,86,244,47,124,67,56,152,100,181,141,27,154,27,227,183,168,70,149,16,200,212,163,68,97,138,127,240,183,217,134,45,86,130,51,250,139,152,68,118,4,143,147,92,218,241,102,154,238,143,70,188,98,202,15,204,156,216,42,255,31,91,131,246,94,184,64,178,88,249,150,1,40,51,36,174,57,229,107,86,112,146,55,46,228,88,240,210,225,235,105,86,0,180,91,192,66,98,235,163,180,204,205,215,208,110,156,133,73,126,152,113,11,222,53,156,236,167,14,167,167,240,199,17,171,138,226,93,174,182,195,225,181,104,239,6,161,159,6,191,187,132,246,190,89,26,93,180,31,148,171,50,105,249,255,186,167,129,155,224,194,108,133,207,90,229,49,23,37,81,190,183,221,206,61,154,207,189,107,152,123,219,184,158,123,125,253,226,234,221,110,162,119,235,186,175,79,220,126,244,21,55,221,226,59,41,42,52,78,220,213,59,113,19,38,242,155,78,237,94,52,30,252,29,66,112,64,52,108,93,71,15,88,242,87,108,43,163,59,100,75,181,130,16,18,167,126,167,99,127,64,89,21,170,75,168,243,161,81,119,174,13,248,147,118,243,12,117,221,97,75,35,179,255,183,252,6,75,100,250,205,245,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("276b5906-88fa-4d43-a6ea-8d6213245d72"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3e068d19-8d8c-4768-b6a9-83bd4995c9bc"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6da2fd2-6cc9-4667-ab57-4f614f3fc9ca"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ef7eb62b-f609-42c2-af07-585c5670410d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a973b80b-c06f-4f64-b532-26268ad871c3"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("997719b8-45ce-4814-939a-6ff72a85e213"),
				Name = "IntegrationApi.Interfaces",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LoadImapEmailsProcess(userConnection);
		}

		public override object Clone() {
			return new LoadImapEmailsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"));
		}

		#endregion

	}

	#endregion

	#region Class: LoadImapEmailsProcess

	/// <exclude/>
	public class LoadImapEmailsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLoadImapEmailsUserTaskLane

		/// <exclude/>
		public class ProcessLoadImapEmailsUserTaskLane : ProcessLane
		{

			public ProcessLoadImapEmailsUserTaskLane(UserConnection userConnection, LoadImapEmailsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public LoadImapEmailsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoadImapEmailsProcess";
			SchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LoadImapEmailsProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LoadImapEmailsProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual Guid CurrentUserMailboxSynchronizationSettingsUId {
			get;
			set;
		}

		private Guid _mailboxSynchronizationSettingsPageUId = new Guid("fce8864e-7b01-429e-921e-0563c725d563");
		public Guid MailboxSynchronizationSettingsPageUId {
			get {
				return _mailboxSynchronizationSettingsPageUId;
			}
			set {
				_mailboxSynchronizationSettingsPageUId = value;
			}
		}

		private Guid _needSetMailboxSynchronizationMessageUId = new Guid("{E9D59B5B-D6D0-47D6-9F8E-C475806C019C}");
		public Guid NeedSetMailboxSynchronizationMessageUId {
			get {
				return _needSetMailboxSynchronizationMessageUId;
			}
			set {
				_needSetMailboxSynchronizationMessageUId = value;
			}
		}

		public virtual Guid MailBoxFolderId {
			get;
			set;
		}

		public virtual string LoadResult {
			get;
			set;
		}

		public virtual Object Messages {
			get;
			set;
		}

		public virtual int MessagesCount {
			get;
			set;
		}

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		private LocalizableString _needSetMailboxSynchronizationMessage;
		public virtual LocalizableString NeedSetMailboxSynchronizationMessage {
			get {
				return _needSetMailboxSynchronizationMessage ?? (_needSetMailboxSynchronizationMessage = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.NeedSetMailboxSynchronizationMessage.Value"));
			}
			set {
				_needSetMailboxSynchronizationMessage = value;
			}
		}

		private LocalizableString _informationCaption;
		public virtual LocalizableString InformationCaption {
			get {
				return _informationCaption ?? (_informationCaption = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.InformationCaption.Value"));
			}
			set {
				_informationCaption = value;
			}
		}

		private LocalizableString _successLoadEmailsMessage;
		public virtual LocalizableString SuccessLoadEmailsMessage {
			get {
				return _successLoadEmailsMessage ?? (_successLoadEmailsMessage = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.SuccessLoadEmailsMessage.Value"));
			}
			set {
				_successLoadEmailsMessage = value;
			}
		}

		private ProcessLoadImapEmailsUserTaskLane _loadImapEmailsUserTaskLane;
		public ProcessLoadImapEmailsUserTaskLane LoadImapEmailsUserTaskLane {
			get {
				return _loadImapEmailsUserTaskLane ?? ((_loadImapEmailsUserTaskLane) = new ProcessLoadImapEmailsUserTaskLane(UserConnection, this));
			}
		}

		private ProcessFlowElement _loadImapEmailsUserTaskStart;
		public ProcessFlowElement LoadImapEmailsUserTaskStart {
			get {
				return _loadImapEmailsUserTaskStart ?? (_loadImapEmailsUserTaskStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "LoadImapEmailsUserTaskStart",
					SchemaElementUId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _loadImapEmailsUserTaskEnd;
		public ProcessEndEvent LoadImapEmailsUserTaskEnd {
			get {
				return _loadImapEmailsUserTaskEnd ?? (_loadImapEmailsUserTaskEnd = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "LoadImapEmailsUserTaskEnd",
					SchemaElementUId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[LoadImapEmailsUserTaskStart.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadImapEmailsUserTaskStart };
			FlowElements[LoadImapEmailsUserTaskEnd.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadImapEmailsUserTaskEnd };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "LoadImapEmailsUserTaskStart":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "LoadImapEmailsUserTaskEnd":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadImapEmailsUserTaskEnd", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("CurrentUserMailboxSynchronizationSettingsUId")) {
				writer.WriteValue("CurrentUserMailboxSynchronizationSettingsUId", CurrentUserMailboxSynchronizationSettingsUId, Guid.Empty);
			}
			if (!HasMapping("MailboxSynchronizationSettingsPageUId")) {
				writer.WriteValue("MailboxSynchronizationSettingsPageUId", MailboxSynchronizationSettingsPageUId, Guid.Empty);
			}
			if (!HasMapping("NeedSetMailboxSynchronizationMessageUId")) {
				writer.WriteValue("NeedSetMailboxSynchronizationMessageUId", NeedSetMailboxSynchronizationMessageUId, Guid.Empty);
			}
			if (!HasMapping("MailBoxFolderId")) {
				writer.WriteValue("MailBoxFolderId", MailBoxFolderId, Guid.Empty);
			}
			if (!HasMapping("LoadResult")) {
				writer.WriteValue("LoadResult", LoadResult, null);
			}
			if (Messages != null) {
				if (Messages.GetType().IsSerializable ||
					Messages.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Messages", Messages, null);
				}
			}
			if (!HasMapping("MessagesCount")) {
				writer.WriteValue("MessagesCount", MessagesCount, 0);
			}
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadImapEmailsUserTaskStart", string.Empty));
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
			MetaPathParameterValues.Add("4fe53caa-18f6-4c4b-b63b-d475fe7b8a0f", () => PageInstanceId);
			MetaPathParameterValues.Add("b9ae9fb7-09a7-4689-89fe-c1c439f10368", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("ff591096-1b06-47b0-a988-cbd658b46fef", () => CurrentUserMailboxSynchronizationSettingsUId);
			MetaPathParameterValues.Add("be94aa4b-5b04-442f-88b6-6841d5c40218", () => MailboxSynchronizationSettingsPageUId);
			MetaPathParameterValues.Add("9891be68-d59b-4533-9be3-85e194af599f", () => NeedSetMailboxSynchronizationMessageUId);
			MetaPathParameterValues.Add("3be2837e-0163-4330-836b-ffca8a2909be", () => MailBoxFolderId);
			MetaPathParameterValues.Add("532cb61b-8379-42bc-9a48-99fd98f7801b", () => LoadResult);
			MetaPathParameterValues.Add("574326c8-1b08-4af9-9e49-7da640ea2c9e", () => Messages);
			MetaPathParameterValues.Add("562516d4-4d62-4421-b65f-3924fb92a101", () => MessagesCount);
			MetaPathParameterValues.Add("9df9ed0b-1c24-40f3-94dc-f7cfa995d7db", () => SenderEmailAddress);
			MetaPathParameterValues.Add("21444bbc-5fee-4669-9cb3-26a7af386911", () => NeedSetMailboxSynchronizationMessage);
			MetaPathParameterValues.Add("c7cc5b5d-0efd-428c-80d5-c6feea55dec6", () => InformationCaption);
			MetaPathParameterValues.Add("e255669d-4628-4d24-b91e-f4e34a99cc0a", () => SuccessLoadEmailsMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "CurrentUserMailboxSynchronizationSettingsUId":
					if (!hasValueToRead) break;
					CurrentUserMailboxSynchronizationSettingsUId = reader.GetValue<System.Guid>();
				break;
				case "MailboxSynchronizationSettingsPageUId":
					if (!hasValueToRead) break;
					MailboxSynchronizationSettingsPageUId = reader.GetValue<System.Guid>();
				break;
				case "NeedSetMailboxSynchronizationMessageUId":
					if (!hasValueToRead) break;
					NeedSetMailboxSynchronizationMessageUId = reader.GetValue<System.Guid>();
				break;
				case "MailBoxFolderId":
					if (!hasValueToRead) break;
					MailBoxFolderId = reader.GetValue<System.Guid>();
				break;
				case "LoadResult":
					if (!hasValueToRead) break;
					LoadResult = reader.GetValue<System.String>();
				break;
				case "Messages":
					if (!hasValueToRead) break;
					Messages = reader.GetSerializableObjectValue();
				break;
				case "MessagesCount":
					if (!hasValueToRead) break;
					MessagesCount = reader.GetValue<System.Int32>();
				break;
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Messages = new Dictionary<Guid, string>();
			var rootEmailFolderId = new Guid("181F9D34-5DEE-E011-A86B-00155D04C01D");
			if (MailBoxFolderId == Guid.Empty) {
				ShowEditSettingsMessage();
				return true;
			}
			if (rootEmailFolderId == MailBoxFolderId) {
				var ids = GetCurrentUserMailboxSynchronizationSettingsUIds();
				if (ids.Count() == 0) {
					ShowEditSettingsMessage();
				}
				foreach(var id in ids) {
					DownloadEmailsFromMailBox(id);
				} 
			} else {
				var mailboxId = GetMailboxId(MailBoxFolderId);
				if (mailboxId != Guid.Empty && mailboxId != null) {
					DownloadEmailsFromMailBox(mailboxId);
				} else {
					ShowEditSettingsMessage();
				}
			}
			var messages = string.Empty;
			foreach(var message in (Dictionary<Guid, string>)Messages) {
				messages += string.Format("{{\"id\": \"{0}\", \"message\": \"{1}\"}},", message.Key, message.Value);
			}
			if (!string.IsNullOrEmpty(messages)) {
				messages = messages.Remove(messages.Length - 1);
			}
			LoadResult = string.Format("{{ \"Messages\": [{0}] }}", messages);
			return true;
		}

			
			public virtual IEnumerable<Guid> GetCurrentUserMailboxSynchronizationSettingsUIds() {
				var mailboxSynchronizationSettingsEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("MailboxSyncSettings");
				var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MailboxSyncSettings");
				var entitySchemaColumn = entitySchemaQuery.AddColumn(mailboxSynchronizationSettingsEntitySchema.GetPrimaryColumnName());
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"SysAdminUnit", UserConnection.CurrentUser.Id));
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"MailServer.Type", new Guid("844F0837-EAA0-4F40-B965-71F5DB9EAE6E")));
				var queryResults = entitySchemaQuery.GetEntityCollection(UserConnection);
				return from result in queryResults select result.GetTypedColumnValue<Guid>(entitySchemaColumn.Name);
			}
			
			
			public virtual MailCredentials GetMailServerCredentials(Guid mailServerUId) {
				var result = new MailCredentials();
				if (mailServerUId != Guid.Empty) {
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var mailServerEntitySchema = entitySchemaManager.GetInstanceByName("MailServer");
					var mailServerEntitySchemaPrimaryColumnName = mailServerEntitySchema.GetPrimaryColumnName();
					var mailServerEntitySchemaPrimaryColumn = mailServerEntitySchema.Columns.GetByName(mailServerEntitySchemaPrimaryColumnName);
					var currentMailServer = new Terrasoft.Configuration.MailServer(UserConnection);
					var columnNamesToFetch = new List<string> {
						"Address",
						"Port",
						"UseSSL",
						"IsStartTls"
					};
					var columnsToFetch = new List<EntitySchemaColumn>();
					foreach (var columnName in columnNamesToFetch) {
						columnsToFetch.Add(mailServerEntitySchema.Columns.GetByName(columnName));
					}
					if (currentMailServer.FetchFromDB(mailServerEntitySchemaPrimaryColumn, mailServerUId, columnsToFetch)) {
						result.Host = currentMailServer.Address;
						result.Port = currentMailServer.Port;
						result.UseSsl = currentMailServer.UseSSL;
						result.StartTls = currentMailServer.IsStartTls;
					}
				}
				return result;
			}
			
			
			public virtual KeyValuePair<MailboxSyncSettings, MailCredentials> GetMailServerUserCredentials(Guid mailboxSynchronizationSettingsUId) {
				var resultMailboxSynchronizationSettings = new MailboxSyncSettings(UserConnection);
				var resultMailCredentials= new MailCredentials();
				if (mailboxSynchronizationSettingsUId != Guid.Empty) {
					if (resultMailboxSynchronizationSettings.FetchFromDB(mailboxSynchronizationSettingsUId)) {
						resultMailCredentials = GetMailServerCredentials(resultMailboxSynchronizationSettings.MailServerId);
						resultMailCredentials.UserName = resultMailboxSynchronizationSettings.UserName;
						resultMailCredentials.UserPassword = resultMailboxSynchronizationSettings.UserPassword;
						resultMailCredentials.SenderEmailAddress = resultMailboxSynchronizationSettings.SenderEmailAddress;
					}
				}
				var result = new KeyValuePair<MailboxSyncSettings, MailCredentials> 
					(resultMailboxSynchronizationSettings, resultMailCredentials);
				return result;
			}
			
			
			/*public virtual void PrepareMailboxSynchronizationSettingsPageOpening(OpenPageUserTask openPageUserTask) {
				var mailboxSynchronizationSettingsPageUId = new Guid("fce8864e-7b01-429e-921e-0563c725d563");
				var mailboxSynchronizationSettingsGridPageUId = new Guid("c8ce13a0-3836-4ba7-b389-4b9e2014013c");
				openPageUserTask.PageParameters = new Dictionary<string, string>();
				var pageParams = openPageUserTask.PageParameters as Dictionary<string, string>;
				if (MailBoxFolderId == Guid.Empty){
					openPageUserTask.PageUId = mailboxSynchronizationSettingsGridPageUId;
					pageParams.Add("userId", UserConnection.CurrentUser.Id.ToString());
				} else {
				 	openPageUserTask.PageUId = mailboxSynchronizationSettingsPageUId;
					pageParams.Add("recordId", GetMailboxId(MailBoxFolderId).ToString());
				}
				openPageUserTask.OpenerInstanceId = InstanceUId;
				openPageUserTask.UseCurrentActivePage = true;
			}*/
			
			
			/*public virtual Terrasoft.UI.WebControls.Controls.MessagePanel GetMainPageMessagePanel() {
				var mainPage = System.Web.HttpContext.Current.Handler as Terrasoft.UI.WebControls.Page;
				var messagePanelControl = Terrasoft.UI.WebControls.Page.FindControlByClientId(mainPage, "BaseMessagePanel", true);
				var messagePanel = messagePanelControl as Terrasoft.UI.WebControls.Controls.MessagePanel;
				return messagePanel;
			}*/
			
			
			public virtual void ShowEditSettingsMessage() {
				//var messagePanel = GetMainPageMessagePanel();
				//var message = string.Format(NeedSetMailboxSynchronizationMessage, MailboxSynchronizationSettingsPageUId.ToString("B"));
				//messagePanel.AddMessage(NeedSetMailboxSynchronizationMessageUId.ToString("N"), InformationCaption, message);
				((Dictionary<Guid, string>)Messages).Add(MailBoxFolderId, NeedSetMailboxSynchronizationMessage.ToString());
			}
			
			
			public virtual void DownloadEmailsFromMailBox(Guid mailboxId) {
				var serverCredentials = GetMailServerUserCredentials(mailboxId).Value;
				if (!UserConnection.GetIsFeatureEnabled("OldEmailIntegration")) {
					var syncSession = ClassFactory.Get<ISyncSession>("Email", new ConstructorArgument("uc", UserConnection),
						new ConstructorArgument("senderEmailAddress", serverCredentials.SenderEmailAddress));
					syncSession.Start();
					return;
				}
				try {
					using (var imapSyncSession = ClassFactory.Get<IImapSyncSession>(
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("credentials", serverCredentials),
					new ConstructorArgument("login", true))) {
						imapSyncSession.SyncImapMail();
						MessagesCount = imapSyncSession.RemoteChangesCount;
					}
				} catch (ImapException e) {	
					//var messagePanel = GetMainPageMessagePanel();
					//var warningCaption = new QuestionUserTask(UserConnection).WarningCaption;
					//messagePanel.AddMessage(warningCaption, e.Message, MessageType.Warning);
					((Dictionary<Guid, string>)Messages).Add(mailboxId, e.Message.ToString());
				}
			}
			
			
			public virtual Guid GetMailboxId(Guid folderId) {
				var sel = new Select(UserConnection)
					.Column("MailboxSyncSettings", "Id")
					.From("MailboxSyncSettings")
					.LeftOuterJoin("ActivityFolder").On("ActivityFolder", "Name")
						.IsEqual("MailboxSyncSettings", "MailboxName")
					.Where("ActivityFolder", "Id").IsEqual(Column.Parameter(folderId)) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				    return sel.ExecuteScalar<Guid>(dbExecutor);
				}
			}
			
			
			public virtual string GetMailboxSenderEmailAddress() {
				var sel = new Select(UserConnection)
					.Column("MailboxSyncSettings", "SenderEmailAddress")
					.From("MailboxSyncSettings")
					.LeftOuterJoin("ActivityFolder").On("ActivityFolder", "Name")
						.IsEqual("MailboxSyncSettings", "MailboxName")
					.Where("ActivityFolder", "Id").IsEqual(Column.Parameter(MailBoxFolderId)) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				    return sel.ExecuteScalar<string>(dbExecutor);
				}
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
			var cloneItem = (LoadImapEmailsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Messages = Messages;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

