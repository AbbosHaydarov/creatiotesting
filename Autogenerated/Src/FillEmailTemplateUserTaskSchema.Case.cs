namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: FillEmailTemplateUserTaskSchema

	/// <exclude/>
	public class FillEmailTemplateUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public FillEmailTemplateUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public FillEmailTemplateUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1");
			RealUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1");
			Name = "FillEmailTemplateUserTask";
			CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,77,111,19,49,16,61,239,254,10,215,189,56,210,42,234,189,128,160,33,160,8,10,105,211,210,3,226,96,118,167,141,209,174,55,181,189,192,10,245,191,51,99,59,89,111,250,65,145,114,136,198,111,222,60,191,121,222,215,252,167,52,172,145,90,222,128,97,47,217,165,5,51,107,181,134,210,169,86,79,231,218,41,215,175,202,53,52,242,52,128,142,115,234,184,128,102,83,75,7,243,213,25,118,105,248,197,82,232,89,7,166,23,145,181,96,156,207,27,169,234,109,15,231,147,227,60,33,152,190,169,170,89,91,119,141,22,156,175,186,239,63,112,248,147,152,147,182,234,239,1,222,169,218,129,177,4,20,121,150,158,204,12,224,191,112,126,165,220,122,41,141,108,128,192,8,204,66,125,214,54,27,105,148,109,245,69,191,129,233,252,182,147,117,193,240,152,243,69,197,185,255,187,229,92,84,121,54,201,39,193,136,91,186,234,57,216,174,118,104,68,58,246,61,184,224,9,234,174,131,159,98,108,47,82,168,107,38,18,138,233,172,237,180,99,175,216,209,132,253,201,179,104,6,18,39,152,175,71,223,136,155,116,70,75,190,200,186,131,23,214,25,165,111,94,237,121,152,145,89,255,75,176,51,248,142,65,109,129,164,24,112,157,209,204,153,14,176,156,7,44,179,126,221,159,208,78,28,17,106,211,121,179,113,125,48,199,246,54,4,226,89,201,194,21,234,106,161,173,147,186,132,147,254,114,81,137,85,111,83,224,162,138,150,13,196,7,152,190,174,174,189,93,99,53,91,200,148,10,79,92,37,60,0,165,159,21,229,97,68,220,127,40,96,99,132,144,179,195,29,8,40,70,61,113,210,40,207,148,48,60,122,171,188,53,210,244,113,21,56,46,172,132,149,30,74,20,54,106,124,28,44,162,178,70,150,166,181,31,149,165,252,144,181,167,84,16,49,28,94,202,22,64,106,206,165,190,1,49,224,40,3,19,68,93,183,248,124,202,181,32,202,65,198,82,90,203,148,78,134,248,13,168,107,113,144,104,197,56,107,135,23,182,31,160,23,227,230,137,199,103,3,43,173,44,236,139,52,4,243,131,67,39,253,82,186,245,126,63,70,155,198,197,230,52,6,89,22,211,9,246,54,48,196,72,220,247,126,143,51,70,5,25,210,75,208,23,101,12,44,198,212,94,203,93,142,191,144,38,240,249,73,6,238,62,5,123,31,128,130,137,54,108,227,28,202,214,84,62,223,195,163,167,71,10,191,221,213,103,191,17,11,86,12,118,23,44,226,80,139,167,46,210,144,32,77,124,247,79,115,16,232,49,2,127,19,235,84,131,223,179,208,140,116,156,31,206,99,237,144,115,122,140,98,187,227,89,139,177,15,64,49,238,11,187,190,220,84,88,121,28,85,144,214,45,249,202,111,80,80,0,163,167,241,96,169,202,135,196,96,249,57,122,118,221,255,146,180,3,62,160,10,207,162,176,244,75,194,255,2,175,88,149,169,75,7,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateBodyParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateSysEntitySchemaIdParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoDataLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoDataLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("61db10e5-c317-40c1-8a73-5e70756abb21"),
				Name = "NoDataLocalizableString",
				CreatedInPackageId = new Guid("88636621-dfdb-4601-a5d0-d48d9d187d38"),
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("82b57fbb-8e7b-48de-85e8-e9063cd8275a"),
				Name = "Subject",
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateBodyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("851df5cc-c52b-4978-94a4-a3afeccfa553"),
				Name = "Body",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("04f6bb80-2f4d-4120-9fd3-6831f5236a7b"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("315ec20d-75de-4da7-9e8d-d75d5ed99ed0"),
				Name = "TemplateId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("01e6c3d6-9264-4ed4-8bf0-72f8067b77eb"),
				Name = "SysEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
			Methods.Add(CreateFindMacroMethod());
			Methods.Add(CreateGetEstimateStringMethod());
			Methods.Add(CreateGetEstimateStringPicMethod());
			Methods.Add(CreateGetTextWOMacrosesMethod());
			Methods.Add(CreateUpdateConstMacrosMethod());
			Methods.Add(CreateContainsConstMacrosMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("93cfd6b9-c336-4181-b7c0-04b1e4c2c236"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("210bfd1a-83b3-4f95-b5e6-69b9c56e506a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dcaac0c4-8da9-4934-a5ab-aaa139c2da2f"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("1c03a3fe-87f3-466f-a6b7-a88ed4e512f8")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("decdb517-2d4b-45cb-a4be-a2c01521313b"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f92127a8-c740-4049-9d20-0766b5ea7294"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2417cdb2-d558-4a2d-b526-76a2b199cf80"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("23ca1ff3-6865-4a1a-a502-84247be7e11f"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6817b341-f94c-4c95-a71f-9ffe62629c7a"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3618695e-9ec3-4573-bee0-844799f0bad1"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bc26359d-e2b6-4c3a-ba40-db5d51784a67"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9bdc5516-0629-4934-ad37-5559ea38a903"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindMacroMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("068bf8bb-c681-43d6-b6b3-0bae1afeade1"),
				Name = "FindMacro",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a4441277-8414-490d-8067-2ffe56fa4b12"),
				Name = "source",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,75,44,82,40,74,173,82,176,85,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,211,208,180,230,74,203,47,74,77,76,206,80,208,240,77,44,1,82,185,96,50,51,79,33,40,53,61,181,66,15,44,152,90,172,81,156,95,90,148,156,170,163,224,160,20,19,173,172,161,167,109,175,169,28,19,171,164,169,169,80,205,197,9,52,91,207,49,37,69,3,172,85,207,189,40,191,180,160,56,218,48,86,47,44,49,167,52,21,104,67,45,87,81,106,73,105,81,30,200,17,214,0,158,62,51,39,141,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEstimateStringMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a6645307-34ff-46d1-b3fd-f6b347c00721"),
				Name = "GetEstimateString",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,201,110,194,48,16,61,55,95,97,229,0,137,64,110,123,134,80,85,64,171,74,221,3,189,91,201,4,44,18,27,141,109,218,8,241,239,157,44,164,45,28,122,177,100,235,205,91,230,217,88,148,106,197,28,230,44,98,129,169,111,225,2,16,133,209,153,229,83,141,64,135,202,228,202,161,176,82,43,30,151,38,6,107,9,103,248,61,216,15,145,59,8,150,6,144,96,10,146,10,51,100,126,44,45,44,49,247,195,145,215,144,178,92,170,13,105,248,99,193,214,8,89,212,247,217,160,214,29,48,127,234,140,213,69,12,184,147,9,24,46,190,210,27,81,51,69,96,172,44,132,133,158,76,163,106,224,29,18,141,233,67,202,23,58,174,121,131,176,34,232,85,230,212,42,218,95,29,250,147,253,245,97,124,41,38,140,249,157,56,130,113,185,37,249,230,206,231,197,214,150,35,111,39,144,129,178,210,150,113,178,134,66,188,57,192,146,80,10,62,217,252,244,253,36,36,255,13,120,18,74,172,0,171,224,100,196,100,141,251,71,216,65,189,130,51,13,126,155,166,83,157,187,66,5,254,179,40,224,95,208,171,150,202,250,33,127,193,20,112,38,177,241,64,86,255,62,240,25,152,4,84,74,25,71,94,29,143,232,146,77,162,243,188,155,56,215,161,26,155,48,164,214,226,78,194,146,189,140,190,130,72,214,44,168,88,167,175,76,170,83,238,144,237,189,139,118,211,131,110,213,119,26,169,192,160,170,127,72,115,149,88,19,170,249,57,93,178,159,66,143,176,69,185,133,118,1,53,118,220,48,78,142,43,35,83,7,15,193,58,84,109,193,163,111,167,244,106,41,207,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEstimateStringPicMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8e6159dd-fc1b-43f1-985d-ed73381690d2"),
				Name = "GetEstimateStringPic",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,84,75,83,219,48,16,62,147,95,161,250,146,100,8,14,48,28,58,118,146,41,13,244,49,83,166,45,9,244,172,88,107,91,131,44,25,105,29,72,25,254,123,87,114,30,144,182,92,100,61,86,223,99,181,107,135,86,234,130,53,86,165,29,153,247,190,32,214,83,163,17,30,49,158,54,214,130,70,246,110,204,116,163,84,159,61,117,40,140,141,89,207,133,75,253,57,88,203,157,201,49,254,5,139,120,106,170,202,104,63,189,65,169,36,74,112,241,103,192,143,220,193,121,93,43,153,113,148,70,223,88,245,47,146,248,26,238,27,112,216,79,59,207,12,148,131,55,200,166,198,2,13,58,151,69,99,3,104,60,91,185,25,32,82,92,224,188,229,170,129,222,141,3,75,97,26,50,31,51,96,209,76,34,16,127,228,73,58,153,209,14,89,11,206,132,92,206,112,165,128,248,62,68,15,82,96,153,176,179,227,250,49,101,37,200,162,196,205,42,39,213,71,78,254,134,132,157,190,247,27,222,195,17,87,178,208,9,203,200,7,216,148,45,193,34,185,85,155,253,74,10,161,128,46,43,195,49,81,144,99,202,22,60,187,43,172,105,180,72,158,142,159,211,40,125,173,167,180,144,111,4,69,129,67,64,102,90,179,9,211,70,19,92,102,148,177,9,123,40,201,213,27,164,94,113,206,43,169,86,9,187,5,43,184,230,3,118,110,37,87,131,57,47,77,197,61,121,103,205,171,164,190,243,148,35,20,44,164,97,220,61,59,238,174,147,208,206,157,151,53,238,86,220,22,82,31,161,169,19,230,51,209,157,68,236,176,115,112,16,141,120,80,63,238,210,218,151,21,141,209,112,6,118,41,51,184,50,2,212,112,74,21,113,77,86,116,113,69,98,10,168,40,111,235,128,216,45,179,33,157,129,143,25,122,132,107,239,91,124,21,1,134,82,181,21,240,116,250,28,56,25,145,18,43,189,224,246,228,132,78,40,116,52,164,205,173,172,33,111,167,52,67,49,241,158,151,220,50,11,174,81,72,150,219,4,196,151,85,141,171,52,28,129,187,167,125,13,15,236,82,163,196,213,44,43,161,226,63,27,176,171,189,210,138,95,6,180,158,172,47,55,242,232,114,30,66,190,193,18,66,225,17,106,124,46,196,212,168,166,210,189,232,135,145,26,163,126,252,221,10,176,23,210,182,128,196,251,122,35,190,0,71,229,37,72,226,95,16,244,53,141,245,216,57,53,6,207,74,214,243,242,221,62,59,147,218,123,242,253,209,234,165,139,170,133,223,243,211,247,173,126,224,65,106,47,207,103,103,31,204,163,204,87,53,172,85,132,134,27,81,236,100,107,41,109,17,66,149,254,15,97,186,187,188,243,17,207,205,44,60,70,111,139,65,255,136,139,93,135,174,159,234,147,177,21,199,222,166,117,7,45,149,191,179,126,212,195,253,80,95,221,131,214,19,69,191,0,29,236,26,46,252,27,44,96,99,181,111,3,190,32,202,5,85,32,216,113,151,170,63,3,165,106,46,252,67,108,215,174,230,89,88,159,116,39,35,180,161,40,55,18,8,99,72,91,52,120,36,42,187,63,7,164,6,66,112,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetTextWOMacrosesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2b084abd-573c-4f2d-b4b8-582d3b9973ca"),
				Name = "GetTextWOMacroses",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("baf37087-414c-4e51-88fb-c78b858ae000"),
				Name = "Macroses",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("357fa74c-acc2-419f-ac6a-f48804305624"),
				Name = "Text",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b563cf96-e5c4-4a7a-9802-1a5adcb30fec"),
				Name = "entity",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d59e6a4e-8147-425c-ab19-5875b408efb4"),
				Name = "columnNames",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,193,110,194,48,12,134,207,237,83,88,229,146,10,148,23,168,38,14,99,226,2,8,109,136,11,226,224,5,51,42,165,9,74,92,180,14,241,238,75,82,65,197,118,138,108,255,255,103,255,241,236,106,243,5,7,100,124,107,206,220,193,11,172,236,44,84,11,171,80,215,63,248,169,233,35,105,228,22,117,75,85,126,180,142,80,157,64,92,208,129,178,186,109,204,10,27,90,163,247,80,27,88,162,114,214,147,47,225,154,103,190,167,15,170,128,239,123,50,109,171,30,146,75,132,255,159,178,235,34,39,123,34,12,133,223,61,31,176,15,150,236,142,18,100,184,230,78,206,137,95,147,42,5,16,131,163,132,233,116,72,94,202,141,237,147,138,50,96,110,160,144,67,204,184,253,78,124,104,227,60,207,54,244,205,161,27,31,249,78,103,141,138,68,177,27,21,48,254,251,47,99,40,70,251,98,210,167,12,244,91,238,136,91,103,146,183,250,5,74,65,218,129,132,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateConstMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("419457fa-ec7e-428b-94ad-e5e1b0223e3e"),
				Name = "UpdateConstMacros",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("67584c4f-1726-4855-9869-d26066896a12"),
				Name = "macros",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a522e1b-73d3-4b89-ae28-11ba6ab5b402"),
				Name = "value",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,11,46,77,202,74,77,46,81,176,85,8,134,176,244,130,82,11,114,18,147,83,53,114,19,147,139,242,139,117,20,202,18,115,74,83,53,173,185,156,242,83,42,129,202,64,20,46,53,0,100,81,225,33,77,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateContainsConstMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("720e7993-8d68-4306-9038-0b3e0457adb5"),
				Name = "ContainsConstMacros",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("91a82ca0-30c0-47ca-b870-a5b95f568416"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dd6ef407-3efe-4c9b-a0bc-18674cb7dc35"),
				Name = "macros",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("91a82ca0-30c0-47ca-b870-a5b95f568416")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,8,46,77,202,74,77,46,209,115,206,207,43,73,204,204,43,214,200,77,76,46,202,47,214,84,168,169,81,112,202,79,169,196,144,176,6,0,235,38,29,239,57,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FillEmailTemplateUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new FillEmailTemplateUserTask(userConnection) {
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1")
			};
		}

		#endregion

	}

	#endregion

	#region Class: FillEmailTemplateUserTask

	[DesignModeProperty(Name = "Subject", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.Subject.Caption", DescriptionResourceItem = "Parameters.Subject.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Body", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.Body.Caption", DescriptionResourceItem = "Parameters.Body.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TemplateId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.TemplateId.Caption", DescriptionResourceItem = "Parameters.TemplateId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SysEntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.SysEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.SysEntitySchemaId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class FillEmailTemplateUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public FillEmailTemplateUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1");
		}

		#endregion

		#region Properties: Public

		public virtual string Subject {
			get;
			set;
		}

		public virtual string Body {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual Guid TemplateId {
			get;
			set;
		}

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		private LocalizableString _noDataLocalizableString;
		public LocalizableString NoDataLocalizableString {
			get {
				return _noDataLocalizableString ?? (_noDataLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.NoDataLocalizableString.Value"));
			}
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("Subject")) {
				writer.WriteValue("Subject", Subject, null);
			}
			if (!HasMapping("Body")) {
				writer.WriteValue("Body", Body, null);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("SysEntitySchemaId")) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Subject":
					Subject = reader.GetStringValue();
				break;
				case "Body":
					Body = reader.GetStringValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "TemplateId":
					TemplateId = reader.GetGuidValue();
				break;
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

