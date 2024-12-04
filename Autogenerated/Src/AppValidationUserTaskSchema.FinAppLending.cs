namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: AppValidationUserTaskSchema

	/// <exclude/>
	public class AppValidationUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public AppValidationUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public AppValidationUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a");
			RealUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a");
			Name = "AppValidationUserTask";
			CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = new Guid("4306792a-86cb-47a7-9484-68c5f3fecc99");
			DcmParametersEditPageSchemaV2UId = new Guid("09a40a9b-3442-47dd-90a3-4e93f15bc99b");
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,142,193,10,130,64,20,69,215,205,87,188,92,41,132,63,32,66,86,26,174,133,246,195,204,147,30,232,56,188,222,72,18,253,123,66,155,134,112,123,239,225,220,123,76,102,205,160,189,191,233,129,172,22,154,28,148,112,102,212,130,213,111,154,102,133,162,30,210,115,96,70,39,81,215,90,216,151,112,13,100,243,122,244,178,100,240,82,187,200,153,55,40,230,222,240,52,94,78,27,138,3,244,122,120,224,58,243,86,27,35,101,124,52,111,109,161,90,71,49,151,70,204,170,171,122,65,174,140,208,76,178,116,122,198,206,48,121,169,159,104,130,224,31,206,40,129,221,247,76,145,124,0,229,123,221,45,32,1,0,0 };
			SerializeToDB = true;
			IsUserTask = true;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePageUIdParameter());
			Parameters.Add(CreateFinApplicationParameter());
			Parameters.Add(CreateParticipantRoleParameter());
			Parameters.Add(CreateParticipantParameter());
			Parameters.Add(CreateRoleParameter());
			Parameters.Add(CreateValidationItemParameter());
			Parameters.Add(CreateOwnerIdParameter());
			Parameters.Add(CreateCurrentAppValidationIdParameter());
			Parameters.Add(CreateResultParameterParameter());
			Parameters.Add(CreateValidationDisplayModeParameter());
			Parameters.Add(CreatePerformActionModeParameter());
			Parameters.Add(CreateConductVerificationModeParameter());
		}

		protected virtual ProcessSchemaParameter CreatePageUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e9e4f808-b0af-4974-a89a-c0f798b4e513"),
				Name = "PageUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFinApplicationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6b2927ad-acd9-47f7-9662-bb989e5717ea"),
				Name = "FinApplication",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateParticipantRoleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("88091cfe-bbb6-4469-b7d5-ec91e4ebada3"),
				Name = "ParticipantRole",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateParticipantParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1c833e9f-020b-4f29-8319-0c136a63cae0"),
				Name = "Participant",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRoleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5dc1a62b-6969-48cc-a9c6-b04977587602"),
				Name = "Role",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateValidationItemParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4575b7cb-2bb6-48b5-a71d-5deedcbe4b15"),
				Name = "ValidationItem",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOwnerIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3e5805f6-6441-4fe3-ad16-6ff924363450"),
				Name = "OwnerId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsResult = false,
				IsPerformer = true,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentAppValidationIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("832b54d2-90a6-4c90-830f-90b35fdcd909"),
				Name = "CurrentAppValidationId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultParameterParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9999a5df-9e51-4e43-b3a1-aed04f66de78"),
				Name = "ResultParameter",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("2edae1ed-a765-4453-8a7d-f7652fe3efa6"),
				IsResult = true,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateValidationDisplayModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3f7609b7-df53-46f2-ad79-f9b889eb7ba9"),
				Name = "ValidationDisplayMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePerformActionModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0e787c5d-7895-4d3f-8883-7f1bda4e5e05"),
				Name = "PerformActionMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateConductVerificationModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3c9ca2fc-4aa8-408f-95b4-f14bec7fd89b"),
				Name = "ConductVerificationMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
			Methods.Add(CreateCreateAppValidationMethod());
			Methods.Add(CreateGetConditionDataMethod());
			Methods.Add(CreateSetEntityRecordRightsMethod());
			Methods.Add(CreateSetAppValidationRecordRightsMethod());
			Methods.Add(CreateGetSysAdminUnitIdByContactIdMethod());
			Methods.Add(CreateInitAppValidationMethod());
			Methods.Add(CreateUpdateAppValidationResultMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4aa6423-c6e7-4d39-b342-9e573896bf19"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3e19f0ae-608a-464d-9354-5964b8fc370d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("161aa87b-c482-4362-bc29-5d6d6002c4f4"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d619f46d-a9f0-420a-a141-d7b23b0c412d"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0702c6c9-f8fd-403e-8891-5e89361461fa"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("470cb41d-3604-410d-af9e-2f411eceb5c4"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				ModifiedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b40a04ea-42a1-4a18-9f77-978cfa3fe287"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				ModifiedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,81,203,106,195,48,16,60,75,95,33,124,146,32,136,246,236,166,16,71,105,200,165,135,36,244,82,122,80,173,37,21,216,146,209,195,105,40,249,247,202,182,138,147,130,64,218,97,103,102,119,212,75,71,28,248,216,4,79,150,196,192,153,8,93,7,109,141,116,151,167,109,212,106,65,124,112,218,156,158,41,43,113,159,186,61,52,80,135,220,124,24,11,26,61,184,181,53,6,70,42,195,8,241,181,109,98,107,104,177,83,197,93,253,42,91,24,16,254,226,108,75,139,85,215,189,201,70,43,57,16,247,227,32,5,35,210,103,229,18,71,159,204,9,29,156,213,231,230,27,234,24,172,75,238,247,150,124,99,124,116,32,170,25,162,140,145,31,140,50,127,39,100,144,123,144,10,146,206,252,92,230,117,248,164,12,19,76,103,167,73,4,157,191,116,3,132,206,76,62,92,217,2,161,156,32,95,41,245,47,11,46,170,227,165,131,4,244,224,66,226,137,42,237,27,225,104,135,112,111,4,223,31,62,216,226,102,52,190,133,112,24,147,167,143,44,69,143,208,21,167,115,197,14,66,116,230,239,211,202,95,152,241,92,139,193,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c03292d2-a9af-4084-805c-460efd6c7151"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2b1faec7-4f15-4020-8258-ca4d14aec93c"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				ModifiedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,77,79,131,64,16,134,207,221,95,177,246,4,137,33,222,177,38,218,170,241,162,70,171,23,227,97,132,161,110,178,44,100,63,208,198,244,191,59,124,52,44,148,112,131,217,121,230,125,247,221,169,64,115,40,203,119,144,34,5,43,10,197,87,188,4,13,57,90,212,230,227,226,147,131,225,91,212,26,76,145,217,104,93,168,76,236,156,110,90,163,107,31,140,153,200,120,48,154,181,226,202,73,25,242,63,182,208,104,157,86,60,3,105,48,102,7,246,130,198,73,251,124,212,34,221,1,27,245,159,109,231,67,26,179,138,220,38,133,116,185,234,79,55,96,241,4,126,77,190,49,7,178,91,247,154,232,78,168,244,102,255,72,74,193,114,72,46,195,214,247,228,212,51,207,126,93,216,138,28,121,53,175,124,143,118,187,47,49,109,165,233,192,225,229,145,189,154,148,33,7,139,145,123,180,30,126,98,249,156,191,25,212,244,20,10,147,166,127,237,180,70,101,235,106,173,223,253,110,58,213,32,36,133,131,151,221,211,143,154,200,123,38,178,6,24,38,213,206,240,3,154,189,130,15,205,218,167,178,133,132,30,187,241,204,70,67,161,162,219,196,140,117,187,244,5,6,137,200,75,73,27,116,251,139,137,179,66,237,130,126,127,195,248,31,133,76,244,219,224,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d59273b9-4b98-4a08-b882-d1a3ea60a524"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1a75803f-ebbe-4a21-b922-989dde00f969"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				ModifiedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,206,65,10,194,64,12,5,208,189,167,40,174,42,200,92,160,184,208,82,164,160,34,74,221,199,241,211,14,180,105,73,210,162,183,119,42,110,116,19,66,242,243,200,157,20,46,39,246,104,139,39,252,104,129,235,116,32,161,14,6,209,85,182,152,72,18,245,13,58,74,54,73,165,144,188,103,134,183,208,179,43,216,130,189,174,159,237,145,152,106,136,219,195,74,86,155,201,221,235,20,157,116,185,29,134,27,181,225,65,243,209,50,154,127,204,89,122,15,213,130,235,192,112,23,116,253,132,239,236,16,212,192,144,52,31,69,192,246,67,149,143,245,247,53,87,205,125,44,17,183,38,168,171,134,24,193,79,250,2,29,91,75,87,217,27,67,40,107,115,244,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1a75fd2d-3182-4b60-8ddd-43e3bde82dfc"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,65,139,131,48,16,133,207,250,43,196,147,66,233,31,40,61,116,161,20,47,93,89,235,222,131,62,236,208,52,74,50,98,187,203,254,247,29,99,10,221,195,210,75,50,121,243,205,227,101,44,120,180,38,169,96,73,105,250,194,169,175,216,146,233,178,56,50,152,146,239,56,138,6,219,55,123,93,23,109,178,77,228,92,137,100,212,21,242,58,202,181,10,4,156,243,68,185,212,181,131,61,41,119,169,153,52,49,193,173,15,224,82,89,24,14,68,209,102,239,147,129,205,103,7,114,65,221,223,208,140,140,246,237,94,81,103,148,126,225,88,252,55,247,228,29,210,205,97,197,205,235,235,71,114,137,67,124,175,154,51,174,42,0,233,110,24,62,101,23,173,98,234,77,234,191,139,155,79,253,216,66,250,71,16,120,132,231,6,213,97,33,202,165,154,69,165,117,63,97,161,156,180,36,245,7,220,168,121,247,220,200,242,56,250,137,243,205,47,188,142,138,81,144,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e63f761a-3538-4872-9702-ce5ad7dcefa0"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("03a2784a-b8cf-4cfb-ba60-f2a6dfe45485"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f699ccee-6294-4903-9f9c-eb1e36c1f0db"),
				Name = "target",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAppValidationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f00c9a70-b1fc-475d-ba8d-8df705056298"),
				Name = "CreateAppValidation",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "Terrasoft.Configuration.AppValidation"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,75,44,82,72,44,40,8,75,204,201,76,73,44,201,204,207,83,176,85,200,75,45,87,8,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,2,203,234,57,34,171,213,8,45,78,45,2,202,231,165,38,131,184,154,214,92,40,70,233,5,167,150,184,164,166,57,231,231,148,230,230,1,133,75,83,139,53,48,212,120,166,0,109,116,47,205,76,209,243,75,45,7,209,32,37,69,169,37,165,69,121,168,14,179,6,0,97,27,76,160,171,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConditionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f9442127-bf50-4076-853d-dcfa701dab01"),
				Name = "GetConditionData",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9372c75e-1d69-4ad6-8e8a-aab74288419f"),
				Name = "appValidation",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1c9a38c9-d829-4885-8014-c08cc9e289da"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,193,78,131,64,16,61,195,87,144,158,32,33,251,3,141,135,182,162,193,104,109,74,245,62,194,148,174,89,22,178,59,84,209,244,223,29,10,70,192,246,184,51,111,222,219,247,102,34,77,146,154,36,61,96,1,30,14,31,55,94,109,209,172,74,173,49,37,89,106,17,13,186,79,160,33,71,35,238,145,98,109,9,116,138,203,230,37,206,124,168,170,87,80,50,131,243,72,7,22,220,8,230,238,17,140,183,151,138,90,82,165,58,82,86,209,248,225,221,2,65,82,214,38,197,187,9,192,15,188,111,215,121,44,115,153,130,122,174,208,64,63,54,45,37,100,100,74,98,161,179,208,117,98,27,105,120,83,152,49,144,76,141,92,218,24,60,178,191,45,230,210,178,130,212,249,74,73,46,36,169,145,21,245,56,247,52,119,167,127,137,62,43,131,214,182,170,10,247,52,120,94,254,251,31,192,119,29,231,122,119,215,84,216,7,196,118,235,66,159,157,58,59,48,57,82,87,217,0,29,88,101,246,151,232,22,109,173,104,22,246,204,220,168,177,37,98,212,112,121,162,155,183,237,126,150,205,26,10,244,255,147,4,98,68,209,122,159,174,71,44,178,204,191,100,210,31,170,133,222,239,214,138,10,140,180,189,183,216,174,75,90,215,74,133,147,224,66,79,115,181,179,59,221,148,123,234,47,229,157,105,248,248,142,104,152,249,74,212,246,97,8,242,199,247,26,142,18,97,86,131,84,27,237,181,51,34,225,11,224,60,190,208,159,90,14,199,202,193,252,7,89,238,156,126,34,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntityRecordRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("390141c2-1d78-4106-a8bd-a623945f8f15"),
				Name = "SetEntityRecordRights",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c04a20d8-8613-403e-9f3c-759e25659475"),
				Name = "entity",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ab57d1f7-ed28-4633-8056-ffce77cb9f3b"),
				Name = "sysAdminUnitId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,80,189,110,194,48,24,156,225,41,50,82,41,242,11,32,6,26,50,32,33,64,73,97,183,226,35,124,146,253,25,125,182,131,242,246,77,41,3,130,150,133,137,229,134,211,253,233,58,45,89,10,88,128,251,10,141,23,83,81,123,140,33,155,101,224,72,177,87,117,115,132,211,106,247,168,153,142,7,82,10,207,140,38,146,103,181,248,172,209,36,25,92,37,183,196,80,53,98,121,73,249,13,185,49,175,208,193,78,66,31,230,198,17,239,152,226,210,228,119,149,107,237,144,143,71,163,43,187,21,114,90,250,194,219,228,120,175,109,66,158,125,65,68,7,127,136,170,240,130,1,248,64,109,18,125,153,243,79,245,230,132,171,160,130,54,63,5,207,54,170,185,181,254,156,255,245,209,199,219,31,80,26,138,47,29,240,13,52,168,112,156,62,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetAppValidationRecordRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d6bbdce2-73a4-4e50-99c6-7b969f084b47"),
				Name = "SetAppValidationRecordRights",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("746aa24a-b742-4141-ae8f-74a732542e53"),
				Name = "entity",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,203,76,83,208,8,202,207,73,85,80,180,85,112,47,205,76,209,115,205,45,40,169,212,84,168,230,226,12,78,45,113,205,43,201,44,169,12,74,77,206,47,74,9,202,76,207,40,41,214,72,5,11,233,40,128,52,105,90,115,213,114,101,2,77,240,47,207,75,45,242,76,193,98,8,136,171,80,92,89,236,152,146,155,153,23,154,151,89,2,84,5,84,148,90,18,140,34,230,84,233,156,159,87,146,152,12,100,194,12,3,26,206,9,50,27,77,51,166,21,4,28,138,170,31,100,106,45,87,45,0,138,86,195,91,247,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysAdminUnitIdByContactIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0009e67f-eee4-4a25-bea7-2a7d04dc1c79"),
				Name = "GetSysAdminUnitIdByContactId",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("53d2eb2a-a1b2-400b-8c74-4dd216a4d4fd"),
				Name = "contactId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,146,193,106,132,48,16,134,207,250,20,193,147,130,132,189,219,93,88,196,138,135,150,221,218,109,15,165,135,96,166,221,128,73,108,156,180,72,233,187,55,18,183,172,218,91,152,249,231,155,249,103,82,90,193,73,63,244,123,46,133,58,41,129,21,39,91,82,186,40,45,100,135,67,22,126,50,51,19,20,245,209,41,20,124,145,66,161,192,161,110,206,32,217,209,130,25,226,83,15,38,215,74,65,131,66,43,122,45,184,99,138,189,131,73,73,84,95,193,162,36,11,87,152,92,183,86,42,34,248,244,216,46,251,211,61,159,114,241,50,243,160,53,122,20,45,1,15,70,72,118,1,222,51,9,113,226,26,46,107,110,69,139,96,250,145,186,226,229,6,24,130,87,60,11,60,31,152,113,152,81,30,251,96,174,101,199,140,232,181,122,28,58,160,197,135,101,109,26,6,145,91,3,178,6,163,148,52,254,85,241,228,207,172,27,168,245,59,154,91,83,46,41,160,255,199,177,51,179,44,93,108,219,193,197,27,153,27,152,120,52,215,86,33,217,145,77,66,190,195,192,131,214,157,135,101,223,169,252,101,243,154,133,193,234,147,172,235,199,41,199,45,76,199,121,98,173,133,155,241,47,237,226,203,49,233,120,5,55,234,79,104,0,173,153,251,175,120,246,11,47,170,14,111,144,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitAppValidationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e2e0c938-1d1b-461f-abd5-664a1cee01d1"),
				Name = "InitAppValidation",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eece4eee-6bd9-4f5f-b4aa-33aa85ba91b7"),
				Name = "appValidation",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Configuration.AppValidation",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,150,209,110,130,48,20,134,175,229,41,58,47,12,36,132,23,32,94,184,205,25,19,179,25,167,187,111,104,167,39,150,66,104,113,49,139,239,62,40,232,104,17,13,245,210,211,254,127,255,243,245,208,120,192,25,138,18,150,199,252,13,248,36,77,25,68,88,66,194,209,24,225,52,253,194,12,136,250,29,124,70,59,26,227,224,69,237,21,65,177,155,60,31,223,113,76,221,161,174,28,122,161,3,223,200,189,234,250,52,70,60,103,204,67,191,206,160,220,212,94,158,229,64,130,105,156,202,163,218,52,48,82,80,89,37,40,106,57,189,126,134,143,244,130,23,34,103,112,66,148,9,106,237,168,66,135,133,141,115,114,156,195,133,217,191,207,92,210,184,15,51,93,169,51,51,92,77,102,237,101,11,102,134,137,143,244,130,5,179,150,99,7,179,37,206,36,68,144,98,46,87,9,163,125,160,25,82,157,154,233,107,98,187,178,110,193,205,116,241,145,81,177,32,215,246,188,143,206,18,91,39,178,91,184,30,71,165,99,122,12,81,55,158,190,227,212,158,161,230,224,160,209,8,117,12,74,41,120,96,134,234,75,182,156,150,219,35,242,241,195,105,214,7,130,18,232,20,42,15,115,32,84,117,78,44,123,174,60,125,84,187,88,244,125,118,184,251,20,175,168,200,89,175,15,196,212,118,61,199,181,115,147,76,175,135,177,214,95,122,232,104,224,21,203,94,115,172,43,187,194,43,87,235,232,74,221,12,190,204,146,136,10,177,17,52,91,99,177,223,72,96,32,129,138,210,104,202,37,200,99,195,78,184,114,7,194,215,91,42,124,74,245,75,194,57,141,84,134,218,115,202,183,192,105,48,33,164,46,44,64,72,90,220,190,171,233,125,180,153,19,31,205,202,224,156,20,135,171,148,184,181,73,59,195,187,119,234,2,248,190,174,172,147,170,145,106,244,141,244,231,11,81,25,244,149,114,188,29,167,224,80,252,135,104,94,126,148,100,100,5,219,157,20,122,70,47,252,3,180,251,177,163,134,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateAppValidationResultMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e366566d-8781-4ae0-94e7-09f52e01910f"),
				Name = "UpdateAppValidationResult",
				CreatedInSchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,205,10,194,48,16,132,207,245,41,98,78,9,148,188,128,120,144,162,80,16,17,165,122,14,205,86,3,233,182,230,199,31,196,119,55,109,5,41,186,167,221,29,230,27,70,87,132,77,179,96,45,160,95,180,237,65,26,173,164,215,13,230,74,228,110,89,183,254,193,56,39,207,73,18,231,42,45,9,109,212,129,204,9,194,141,20,253,193,10,7,54,107,16,161,236,156,41,161,35,18,229,189,57,73,196,30,60,163,95,97,7,46,24,159,43,154,146,172,49,161,70,177,149,86,214,224,193,178,149,198,8,89,3,42,141,167,200,118,222,137,77,227,227,86,105,91,131,26,37,12,32,254,201,17,199,51,88,96,52,130,121,215,225,18,164,97,63,1,255,59,115,62,235,33,67,75,177,188,67,25,98,193,225,251,122,3,212,37,201,196,45,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidationUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new AppValidationUserTask(userConnection) {
				SchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a")
			};
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationUserTaskSchemaExtension

	/// <exclude/>
	public class AppValidationUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var results = new Dictionary<Guid, string>();
			var select = new Select(userConnection)
					.Column("Id")
					.Column("Name")
				.From("AppValidationResult") as Select;
			using (var dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						results.Add(userConnection.DBTypeConverter.DBValueToGuid(dataReader[0]), dataReader.GetString(1));
					}
				}
			}
			return results;
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.PageUId.Group", DescriptionResourceItem = "Parameters.PageUId.Group")]
	[DesignModeProperty(Name = "PageUId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.PageUId.Caption", DescriptionResourceItem = "Parameters.PageUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FinApplication", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.FinApplication.Caption", DescriptionResourceItem = "Parameters.FinApplication.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ParticipantRole", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.ParticipantRole.Caption", DescriptionResourceItem = "Parameters.ParticipantRole.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Participant", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.Participant.Caption", DescriptionResourceItem = "Parameters.Participant.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Role", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.Role.Caption", DescriptionResourceItem = "Parameters.Role.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ValidationItem", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.ValidationItem.Caption", DescriptionResourceItem = "Parameters.ValidationItem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentAppValidationId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.CurrentAppValidationId.Caption", DescriptionResourceItem = "Parameters.CurrentAppValidationId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultParameter", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.ResultParameter.Caption", DescriptionResourceItem = "Parameters.ResultParameter.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ValidationDisplayMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.ValidationDisplayMode.Caption", DescriptionResourceItem = "Parameters.ValidationDisplayMode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PerformActionMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.PerformActionMode.Caption", DescriptionResourceItem = "Parameters.PerformActionMode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ConductVerificationMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a1afd8211d84e52a5a0197e91023b8a", CaptionResourceItem = "Parameters.ConductVerificationMode.Caption", DescriptionResourceItem = "Parameters.ConductVerificationMode.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class AppValidationUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public AppValidationUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("4a1afd82-11d8-4e52-a5a0-197e91023b8a");
		}

		#endregion

		#region Properties: Public

		public virtual Guid PageUId {
			get;
			set;
		}

		public virtual Guid FinApplication {
			get;
			set;
		}

		public virtual Guid ParticipantRole {
			get;
			set;
		}

		public virtual Guid Participant {
			get;
			set;
		}

		public virtual Guid Role {
			get;
			set;
		}

		public virtual Guid ValidationItem {
			get;
			set;
		}

		public virtual Guid OwnerId {
			get;
			set;
		}

		public virtual Guid CurrentAppValidationId {
			get;
			set;
		}

		public virtual Guid ResultParameter {
			get;
			set;
		}

		public virtual int ValidationDisplayMode {
			get;
			set;
		}

		public virtual int PerformActionMode {
			get;
			set;
		}

		public virtual int ConductVerificationMode {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var appValidation = CreateAppValidation();
			if (CurrentAppValidationId != Guid.Empty) {
				appValidation.FetchFromDB(CurrentAppValidationId, false);
			}
			CurrentAppValidationId = appValidation.Id;
			InitAppValidation(appValidation);
			AfterActivitySaveScriptExecute(appValidation);
			return false;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			var appValidation = parameters[0] as Terrasoft.Configuration.AppValidation;
			if (appValidation == null) {
				return false;
			}
			ResultParameter = appValidation.ValidationResultId;
			var columnValidationDate = appValidation.Schema.Columns.FindByName("ValidationDate");
			if (columnValidationDate != null) {
				DateTime validationDate = appValidation.GetTypedColumnValue<DateTime>(columnValidationDate);
				appValidation.SetColumnValue("ValidationDate", UserConnection.CurrentUser.GetCurrentDateTime());
			}
			var columnOwner = appValidation.Schema.Columns.FindByName("Owner");
			if (columnOwner != null) {
				appValidation.SetColumnValue(columnOwner , UserConnection.CurrentUser.ContactId);
			}
			
			appValidation.Save();
			
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("AppValidation");
			UserConnection.ProcessEngine.RemoveProcessListener(CurrentAppValidationId, schema.UId, UId);
			this.UpdateAppValidationResult();
		}

		public override string GetExecutionData() {
			return SerializeToString(
				new {
					procElUId = UId,
					name = Name,
					processId = ProcessUserTaskUtilities.GetParentProcessId(Owner),
					isProcessExecutedBySignal = ProcessUserTaskUtilities.GetIsProcessExecutedBySignal(Owner),
					processName = Owner.Name,
					entitySchemaName = "AppValidation",
					nextProcElUId = "nextProcElUIdValue",
					pageUId = PageUId,
					allowedValues = GetResultAllowedValues()
				}
			);
		}

		public virtual Terrasoft.Configuration.AppValidation CreateAppValidation() {
			var appValidation = new Terrasoft.Configuration.AppValidation(UserConnection);
			appValidation.SetDefColumnValues();
			appValidation.Id = Guid.NewGuid();
			return appValidation;
		}

		public virtual string GetConditionData(Entity appValidation, UserConnection userConnection) {
			EntitySchema entitySchema = userConnection.EntitySchemaManager.GetInstanceByUId(appValidation.Schema.UId);
			var filterCollection = new DataSourceFilterCollection() {
				LogicalOperation = LogicalOperationStrict.And,
				IsEnabled = true,
				PreventRegisteringClientScript = true
			};
			DataSourceFilterExpression leftExpression = new DataSourceFilterExpression(
					DataSourceFilterExpressionType.SchemaColumn) {
					TargetColumnPath = "ValidationResult",
					DataValueType = entitySchema.Columns.GetByName("ValidationResult").DataValueType
			};
			filterCollection.Add(new DataSourceFilter(entitySchema, FilterComparisonType.IsNotNull, leftExpression, null) {
					IsEnabled = true
			});
			var jsonConverter = new DataSourceFiltersJsonConverter(userConnection, entitySchema);
			return Json.Serialize(filterCollection, jsonConverter);
		}

		public virtual void SetEntityRecordRights(Entity entity, Guid sysAdminUnitId) {
			var useDenyRecordRights = entity.Schema.UseDenyRecordRights;
			UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(sysAdminUnitId, entity.Schema.Name,
					entity.PrimaryColumnValue, Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation.Read,
					EntitySchemaRecordRightLevel.Allow, useDenyRecordRights);
			UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(sysAdminUnitId, entity.Schema.Name,
					entity.PrimaryColumnValue, Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation.Edit,
					EntitySchemaRecordRightLevel.Allow, useDenyRecordRights);
		}

		public virtual void SetAppValidationRecordRights(Entity entity) {
			if (Role != Guid.Empty) {
				SetEntityRecordRights(entity, Role);
			}
			if (OwnerId != Guid.Empty) {
				Guid sysAdminUnitId = GetSysAdminUnitIdByContactId(OwnerId);
				if (sysAdminUnitId != Guid.Empty) {
					SetEntityRecordRights(entity, sysAdminUnitId);
				}
			}
		}

		public virtual Guid GetSysAdminUnitIdByContactId(Guid contactId) {
			Guid sysAdminUnitId = Guid.Empty;
			var sysAdminUnitESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			EntitySchemaQueryColumn idColumn = sysAdminUnitESQ.AddColumn(sysAdminUnitESQ.RootSchema.GetPrimaryColumnName());
			sysAdminUnitESQ.Filters.Add(sysAdminUnitESQ.CreateFilterWithParameters(FilterComparisonType.Equal,
				"Contact", contactId));
			EntityCollection sysAdminUnitEntities = sysAdminUnitESQ.GetEntityCollection(UserConnection);
			if (sysAdminUnitEntities.Count > 0) {
				Entity sysAdminUnitEntity = sysAdminUnitEntities[0];
				sysAdminUnitId = sysAdminUnitEntity.GetTypedColumnValue<Guid>(idColumn.Name);
			}
			return sysAdminUnitId;
		}

		public virtual void InitAppValidation(Terrasoft.Configuration.AppValidation appValidation) {
			var columnFinApplication = appValidation.Schema.Columns.FindByName("FinApplication");
			if (columnFinApplication != null) {
				if (FinApplication != Guid.Empty) {
					appValidation.SetColumnValue(columnFinApplication , FinApplication); 
				} else {
					appValidation.SetColumnValue(columnFinApplication , null);
				}
			}
			
			var columnValidationItem = appValidation.Schema.Columns.FindByName("ValidationItem");
			if (columnValidationItem != null) {
				if (ValidationItem != Guid.Empty) {
					appValidation.SetColumnValue(columnValidationItem , ValidationItem); 
				} else {
					appValidation.SetColumnValue(columnValidationItem , null);
				}
			}
			
			var columnParticipantRole = appValidation.Schema.Columns.FindByName("ParticipantRole");
			if (columnParticipantRole != null) {
				if (ParticipantRole != Guid.Empty) {
					appValidation.SetColumnValue(columnParticipantRole , ParticipantRole); 
				} else {
					appValidation.SetColumnValue(columnParticipantRole , null);
				}
			}
			
			var columnParticipant = appValidation.Schema.Columns.FindByName("Participant");
			if (columnParticipant != null) {
				if (Participant != Guid.Empty) {
					appValidation.SetColumnValue(columnParticipant , Participant); 
				} else {
					appValidation.SetColumnValue(columnParticipant , null);
				}
			}
			
			var columnRole = appValidation.Schema.Columns.FindByName("Role");
			if (columnRole != null && Role != Guid.Empty) {
				if (Role != Guid.Empty) {
					appValidation.SetColumnValue(columnRole , Role); 
				} else {
					appValidation.SetColumnValue(columnRole , null);
				}
			}
			
			var columnOwner = appValidation.Schema.Columns.FindByName("Owner");
			if (columnOwner != null) {
				if (OwnerId != Guid.Empty) {
					appValidation.SetColumnValue(columnOwner , OwnerId); 
				} else {
					appValidation.SetColumnValue(columnOwner , null);
				}
			}
			
			var columnValidationResult = appValidation.Schema.Columns.FindByName("ValidationResult");
			if (columnValidationResult != null) {
				appValidation.SetColumnValue(columnValidationResult , null);
			}
			
			var columnValidationDate = appValidation.Schema.Columns.FindByName("ValidationDate");
			if (columnValidationDate != null) {
				appValidation.SetColumnValue(columnValidationDate , null);
			}
			
			ProcessUserTaskUtilities.SetEntityColumnValues(this, appValidation);
			UserConnection.ProcessEngine.AddProcessListener(appValidation, UId, GetConditionData(appValidation, UserConnection));
			UserConnection.ProcessEngine.LinkProcessToEntity(Owner, appValidation.Schema.UId, appValidation.Id);
			
			SetAppValidationRecordRights(appValidation);
		}

		public virtual void UpdateAppValidationResult() {
			if (!CurrentAppValidationId.IsEmpty()) {
							var update = new Update(UserConnection, "AppValidation")
									.Set("ValidationResultId", Column.Parameter(FinAppLendingConsts.NotConfirmedAppValidationResult))
								.Where("Id").IsEqual(Column.Parameter(CurrentAppValidationId));
							update.Execute();
						}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("PageUId")) {
				writer.WriteValue("PageUId", PageUId, Guid.Empty);
			}
			if (!HasMapping("FinApplication")) {
				writer.WriteValue("FinApplication", FinApplication, Guid.Empty);
			}
			if (!HasMapping("ParticipantRole")) {
				writer.WriteValue("ParticipantRole", ParticipantRole, Guid.Empty);
			}
			if (!HasMapping("Participant")) {
				writer.WriteValue("Participant", Participant, Guid.Empty);
			}
			if (!HasMapping("Role")) {
				writer.WriteValue("Role", Role, Guid.Empty);
			}
			if (!HasMapping("ValidationItem")) {
				writer.WriteValue("ValidationItem", ValidationItem, Guid.Empty);
			}
			if (!HasMapping("OwnerId")) {
				writer.WriteValue("OwnerId", OwnerId, Guid.Empty);
			}
			if (!HasMapping("CurrentAppValidationId")) {
				writer.WriteValue("CurrentAppValidationId", CurrentAppValidationId, Guid.Empty);
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("ResultParameter")) {
					writer.WriteValue("ResultParameter", ResultParameter, Guid.Empty);
				}
			}
			if (!HasMapping("ValidationDisplayMode")) {
				writer.WriteValue("ValidationDisplayMode", ValidationDisplayMode, 0);
			}
			if (!HasMapping("PerformActionMode")) {
				writer.WriteValue("PerformActionMode", PerformActionMode, 0);
			}
			if (!HasMapping("ConductVerificationMode")) {
				writer.WriteValue("ConductVerificationMode", ConductVerificationMode, 0);
			}
			writer.WriteFinishObject();
		}

		public override bool TryGetPerformer(out Guid performerUId) {
			performerUId = OwnerId;
			return true;
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "PageUId":
					PageUId = reader.GetGuidValue();
				break;
				case "FinApplication":
					FinApplication = reader.GetGuidValue();
				break;
				case "ParticipantRole":
					ParticipantRole = reader.GetGuidValue();
				break;
				case "Participant":
					Participant = reader.GetGuidValue();
				break;
				case "Role":
					Role = reader.GetGuidValue();
				break;
				case "ValidationItem":
					ValidationItem = reader.GetGuidValue();
				break;
				case "OwnerId":
					OwnerId = reader.GetGuidValue();
				break;
				case "CurrentAppValidationId":
					CurrentAppValidationId = reader.GetGuidValue();
				break;
				case "ResultParameter":
					if (!UseFlowEngineMode) {
						break;
					}
					ResultParameter = reader.GetGuidValue();
				break;
				case "ValidationDisplayMode":
					ValidationDisplayMode = reader.GetIntValue();
				break;
				case "PerformActionMode":
					PerformActionMode = reader.GetIntValue();
				break;
				case "ConductVerificationMode":
					ConductVerificationMode = reader.GetIntValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

