namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: GenerateDocListFinAppUserTaskSchema

	/// <exclude/>
	public class GenerateDocListFinAppUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public GenerateDocListFinAppUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public GenerateDocListFinAppUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da");
			RealUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da");
			Name = "GenerateDocListFinAppUserTask";
			CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,209,10,130,64,16,69,159,245,43,38,159,20,196,31,144,168,32,53,161,167,250,2,89,183,90,216,214,101,157,5,37,252,247,102,69,171,133,230,237,206,156,185,115,103,31,29,59,118,22,61,158,184,212,220,64,235,169,45,84,28,61,32,78,242,176,178,162,221,65,143,205,157,215,45,49,160,172,148,107,219,116,210,235,138,27,196,87,135,194,134,220,8,201,138,167,198,49,129,87,8,84,95,151,25,202,195,105,222,184,144,203,255,133,143,191,67,28,142,102,164,81,224,5,207,74,33,229,146,187,86,165,80,7,173,165,96,13,138,78,197,190,76,215,8,233,98,77,15,78,64,51,246,128,184,24,24,215,142,2,62,184,0,129,225,104,141,2,52,118,190,253,43,163,55,186,78,127,90,75,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateFinApplicationParameter());
			Parameters.Add(CreateRoleParameter());
			Parameters.Add(CreateStageParameter());
		}

		protected virtual ProcessSchemaParameter CreateFinApplicationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b8115f5c-01a6-4aae-8175-98dfa175a434"),
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

		protected virtual ProcessSchemaParameter CreateRoleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1c5c9709-150f-401b-b6d0-e8953b405013"),
				Name = "Role",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0a685b8a-27c9-432b-8e60-eb1f3b0de75f"),
				Name = "Stage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf"),
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
			Methods.Add(CreateGetDocListHelperMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41823e73-e919-46f2-8255-1ec35790d8c1"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f82ca1fc-a251-4967-9f76-880d194cf284"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("eb749094-fabd-4f68-83ef-d17091a91f57"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c2788086-319b-40ed-89aa-b5faa1a320f9"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5e29f1c2-4dcc-4cd9-bacc-73ba23186051"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				ModifiedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("efe9e744-2342-41fa-93a1-42e39d59383b"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				ModifiedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("274428d1-9475-4e09-b978-138dd6c1e13e"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e93f879b-f2d2-48de-a2ee-d17598afcc37"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				ModifiedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("73b4f5ee-1018-456d-95dc-3a6101bbf75d"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("609b30d2-1914-4efc-ae6d-74413affcfee"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				ModifiedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17513d4f-89c0-49cf-835f-eb3574d309a3"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6dfa4d3d-c9e9-4e56-9499-bff6e9f480a9"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e627fc57-9898-4c11-8f7d-b78c48e48458"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("83d0558e-c36b-4959-86c7-eba215cf99ab"),
				Name = "target",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDocListHelperMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("855f9acf-ea04-4713-8956-8626438508c1"),
				Name = "GetDocListHelper",
				CreatedInSchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				ResultValueTypeName = "DocListHelper"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,201,79,246,201,44,46,241,72,205,41,72,45,178,211,200,75,45,87,112,206,207,43,46,41,42,5,169,113,44,74,47,205,77,205,43,209,80,42,45,78,45,2,74,228,165,38,151,100,230,231,41,233,40,132,162,8,104,106,90,3,0,154,104,149,50,98,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GenerateDocListFinAppUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new GenerateDocListFinAppUserTask(userConnection) {
				SchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da")
			};
		}

		#endregion

	}

	#endregion

	#region Class: GenerateDocListFinAppUserTask

	[DesignModeProperty(Name = "FinApplication", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "2955e6c63d7047a2b75dc4b6fabdc6da", CaptionResourceItem = "Parameters.FinApplication.Caption", DescriptionResourceItem = "Parameters.FinApplication.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Role", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "2955e6c63d7047a2b75dc4b6fabdc6da", CaptionResourceItem = "Parameters.Role.Caption", DescriptionResourceItem = "Parameters.Role.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Stage", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "2955e6c63d7047a2b75dc4b6fabdc6da", CaptionResourceItem = "Parameters.Stage.Caption", DescriptionResourceItem = "Parameters.Stage.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class GenerateDocListFinAppUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public GenerateDocListFinAppUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("2955e6c6-3d70-47a2-b75d-c4b6fabdc6da");
		}

		#endregion

		#region Properties: Public

		public virtual Guid FinApplication {
			get;
			set;
		}

		public virtual Guid Role {
			get;
			set;
		}

		public virtual Guid Stage {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			DocListHelper docListHelper = GetDocListHelper();
			Guid? stageId =  null;
			Guid? roleId =  null;
			if (Stage != Guid.Empty) {
			    stageId = Stage;
			}
			if (Role != Guid.Empty) {
			    roleId = Role;
			}
			try {
				docListHelper.FillDocListInFinApplication(FinApplication, stageId, roleId);
			} catch (Exception ex) {
				return true;
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public virtual DocListHelper GetDocListHelper() {
			return ClassFactory.Get<DocListHelper>(new ConstructorArgument("userConnection", UserConnection));
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("FinApplication")) {
				writer.WriteValue("FinApplication", FinApplication, Guid.Empty);
			}
			if (!HasMapping("Role")) {
				writer.WriteValue("Role", Role, Guid.Empty);
			}
			if (!HasMapping("Stage")) {
				writer.WriteValue("Stage", Stage, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "FinApplication":
					FinApplication = reader.GetGuidValue();
				break;
				case "Role":
					Role = reader.GetGuidValue();
				break;
				case "Stage":
					Stage = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

