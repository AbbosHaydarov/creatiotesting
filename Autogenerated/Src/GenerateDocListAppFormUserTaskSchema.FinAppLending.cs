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

	#region Class: GenerateDocListAppFormUserTaskSchema

	/// <exclude/>
	public class GenerateDocListAppFormUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public GenerateDocListAppFormUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public GenerateDocListAppFormUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e");
			RealUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e");
			Name = "GenerateDocListAppFormUserTask";
			CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,115,80,42,41,170,84,168,230,226,116,201,79,246,201,44,46,241,73,205,75,201,204,75,247,72,205,41,72,45,82,72,193,38,104,171,224,158,90,130,77,185,134,166,53,23,39,54,45,122,110,153,57,57,80,29,158,121,142,5,5,110,249,69,185,26,80,26,168,169,86,33,57,177,36,57,67,65,195,181,34,57,181,160,36,51,63,79,33,181,66,19,228,170,162,212,146,210,162,60,133,146,162,210,84,160,50,46,100,174,18,0,114,201,242,218,187,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateAppFormParameter());
		}

		protected virtual ProcessSchemaParameter CreateAppFormParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a418c512-2866-4f9e-a710-b83ceaa18c76"),
				Name = "AppForm",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
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
			Methods.Add(CreateGetDocListLendingHelperMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a758b11b-b9e3-4211-9d51-7669e5e04955"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f89a5f78-2d79-4a6a-aa9c-3cb243e48ce2"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("34f05249-e5a0-4dc9-988b-850e80c3c56d"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b02663bc-65b8-4d1d-a419-417e1ff84e58"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bcf8a981-e97f-4d33-8510-f3a4375124fc"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				ModifiedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b1b2bb1c-e4db-45fb-9e85-c5bde7d45e5f"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				ModifiedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("64918ef9-ae6f-4d36-90b5-03b92fed4dbd"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f21f908e-39d7-4b33-aa16-f9c59af37cd8"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				ModifiedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5f61f2d2-f7e6-4e06-9912-638cb70a7008"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("23fd1df7-0b96-44c4-a2a1-151cd1d946ef"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				ModifiedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0b81e581-77b0-4d2a-b9d9-92b45549d01b"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a0b6cf12-78e2-4a5a-9bb9-cd761a591ae3"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("09da5b41-6cf7-4f05-9b05-bb95027aa8f8"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e44dfbb0-62c7-4a06-8bc6-9316d97811dc"),
				Name = "target",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDocListLendingHelperMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ed109512-df09-4f65-bab1-c93cfe67f7a9"),
				Name = "GetDocListLendingHelper",
				CreatedInSchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				ResultValueTypeName = "DocListLendingHelper"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,85,202,193,10,64,64,20,70,225,87,153,172,40,121,1,82,34,44,102,235,1,52,254,166,41,238,232,222,59,201,219,99,105,123,190,195,208,196,100,250,125,21,25,87,167,145,239,106,130,54,67,116,54,136,90,208,22,200,207,216,79,112,155,19,46,211,71,18,229,244,173,29,251,116,128,52,207,146,128,95,32,56,13,145,178,210,44,191,80,20,245,3,73,20,121,35,105,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GenerateDocListAppFormUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new GenerateDocListAppFormUserTask(userConnection) {
				SchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e")
			};
		}

		#endregion

	}

	#endregion

	#region Class: GenerateDocListAppFormUserTask

	[DesignModeProperty(Name = "AppForm", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c363705cca61469db154ae7f48b1bb2e", CaptionResourceItem = "Parameters.AppForm.Caption", DescriptionResourceItem = "Parameters.AppForm.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class GenerateDocListAppFormUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public GenerateDocListAppFormUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("c363705c-ca61-469d-b154-ae7f48b1bb2e");
		}

		#endregion

		#region Properties: Public

		public virtual Guid AppForm {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			try {
				DocListLendingHelper docListLendingHelper = GetDocListLendingHelper();
				docListLendingHelper.FillDocListInAppForm(AppForm);
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

		public virtual DocListLendingHelper GetDocListLendingHelper() {
			return ClassFactory.Get<DocListLendingHelper>(new ConstructorArgument("userConnection", UserConnection));
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("AppForm")) {
				writer.WriteValue("AppForm", AppForm, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "AppForm":
					AppForm = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

