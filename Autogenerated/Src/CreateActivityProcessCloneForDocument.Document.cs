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

	#region Class: CreateActivityProcessCloneForDocumentSchema

	/// <exclude/>
	public class CreateActivityProcessCloneForDocumentSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CreateActivityProcessCloneForDocumentSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CreateActivityProcessCloneForDocumentSchema(CreateActivityProcessCloneForDocumentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CreateActivityProcessCloneForDocument";
			UId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.16.2.1599";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			Version = 0;
			PackageUId = new Guid("f0a4df72-c82f-425f-8080-82c120139634");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("48afa22b-7602-4990-9f3e-061a442a8e6a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("68768651-b929-4d24-ad67-4b7f1dd06f1b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedActivityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5fca99d5-4536-4f81-8778-87f2b17c44ed"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"SelectedActivity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateSelectedActivityParameter());
		}

		protected virtual void InitializeOpenActivityTypeLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageParametersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c42a570-d16c-4740-85e9-587a7c231a16"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			pageParametersParameter.SourceValue = new ProcessSchemaParameterValue(pageParametersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageParametersParameter);
			var processKeyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7222b831-d4eb-4d55-b69b-0bf8578b9e9e"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			processKeyParameter.SourceValue = new ProcessSchemaParameterValue(processKeyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(processKeyParameter);
			var userContextKeyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b90e09c-c471-46d6-9f5d-87cdc7efe4e4"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			userContextKeyParameter.SourceValue = new ProcessSchemaParameterValue(userContextKeyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(userContextKeyParameter);
			var useCurrentActivePageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc012c0e-2e6c-421b-ad7f-440b0f036325"),
				ContainerUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCurrentActivePageParameter.SourceValue = new ProcessSchemaParameterValue(useCurrentActivePageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(useCurrentActivePageParameter);
		}

		protected virtual void InitializeOpenActivityEditPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cc3e5db-0506-47e6-8b27-efadda2cb88b"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageUIdParameter);
			var pageUrlParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b79dad0a-6cf5-450f-a4e6-b8917e7e9301"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pageUrlParameter.SourceValue = new ProcessSchemaParameterValue(pageUrlParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageUrlParameter);
			var openerInstanceIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("26db47b8-17d4-4ffb-82e9-4453d8f508b2"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			openerInstanceIdParameter.SourceValue = new ProcessSchemaParameterValue(openerInstanceIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(openerInstanceIdParameter);
			var closeOpenerOnLoadParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c9a42adb-6104-4870-b756-4bf340757950"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			closeOpenerOnLoadParameter.SourceValue = new ProcessSchemaParameterValue(closeOpenerOnLoadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(closeOpenerOnLoadParameter);
			var pageParametersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7cfd311-080e-4bea-a766-8e8dcab60aa0"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			pageParametersParameter.SourceValue = new ProcessSchemaParameterValue(pageParametersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageParametersParameter);
			var widthParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0be2a70-6167-4750-b6fc-cfd85f6f52f7"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			widthParameter.SourceValue = new ProcessSchemaParameterValue(widthParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(widthParameter);
			var closeMessageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("824337a6-ab71-4560-9425-1820381aef1c"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			closeMessageParameter.SourceValue = new ProcessSchemaParameterValue(closeMessageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(closeMessageParameter);
			var heightParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0362a1ad-23f4-400f-9c87-58b6ae2cfae0"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			heightParameter.SourceValue = new ProcessSchemaParameterValue(heightParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(heightParameter);
			var centeredParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3bdd4182-000f-4d5c-8cf4-d1234ab6bba7"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			centeredParameter.SourceValue = new ProcessSchemaParameterValue(centeredParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(centeredParameter);
			var useOpenerRegisterScriptParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e111e58-83bf-4da4-823f-cb70ffcf49f5"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useOpenerRegisterScriptParameter.SourceValue = new ProcessSchemaParameterValue(useOpenerRegisterScriptParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(useOpenerRegisterScriptParameter);
			var useCurrentActivePageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d1d2784c-8bea-4fd7-a223-bb3659de78c7"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCurrentActivePageParameter.SourceValue = new ProcessSchemaParameterValue(useCurrentActivePageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(useCurrentActivePageParameter);
			var ignoreProfileParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb40ba52-ad85-4880-90df-f4882e51e669"),
				ContainerUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreProfileParameter.SourceValue = new ProcessSchemaParameterValue(ignoreProfileParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreProfileParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet44 = CreateLaneSet44LaneSet();
			LaneSets.Add(schemaLaneSet44);
			ProcessSchemaLane schemaLane132 = CreateLane132Lane();
			schemaLaneSet44.Lanes.Add(schemaLane132);
			ProcessSchemaStartEvent createactivitystart = CreateCreateActivityStartStartEvent();
			FlowElements.Add(createactivitystart);
			ProcessSchemaEndEvent createactivityend = CreateCreateActivityEndEndEvent();
			FlowElements.Add(createactivityend);
			ProcessSchemaScriptTask beforeopenactivitytypelookupusertaskscripttask = CreateBeforeOpenActivityTypeLookupUserTaskScriptTaskScriptTask();
			FlowElements.Add(beforeopenactivitytypelookupusertaskscripttask);
			ProcessSchemaUserTask openactivitytypelookupusertask = CreateOpenActivityTypeLookupUserTaskUserTask();
			FlowElements.Add(openactivitytypelookupusertask);
			ProcessSchemaScriptTask beforeopenactivityeditpageusertaskscripttask = CreateBeforeOpenActivityEditPageUserTaskScriptTaskScriptTask();
			FlowElements.Add(beforeopenactivityeditpageusertaskscripttask);
			ProcessSchemaUserTask openactivityeditpageusertask = CreateOpenActivityEditPageUserTaskUserTask();
			FlowElements.Add(openactivityeditpageusertask);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosedintermediatecatchmessageevent = CreateLookupGridPageClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			FlowElements.Add(lookupgridpageclosedintermediatecatchmessageevent);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			Artifacts.Add(CreateChooseActivityTypeGroupGroup());
			Artifacts.Add(CreateOpenActivityEditPageGroupGroup());
			FlowElements.Add(CreateSequenceFlow445SequenceFlow());
			FlowElements.Add(CreateSequenceFlow446SequenceFlow());
			FlowElements.Add(CreateSequenceFlow447SequenceFlow());
			FlowElements.Add(CreateSequenceFlow448SequenceFlow());
			FlowElements.Add(CreateSequenceFlow449SequenceFlow());
			FlowElements.Add(CreateSequenceFlow450SequenceFlow());
			FlowElements.Add(CreateConditionalFlow33ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow452SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow445SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow445",
				UId = new Guid("0c4f094c-4d91-4bf6-b6b6-66251497ad4d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(169, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6fc4602c-fc70-44c3-970e-fd8f8c346555"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow446SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow446",
				UId = new Guid("25133738-d010-4dcc-97e8-0478ab9fa550"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(528, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow447SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow447",
				UId = new Guid("aa53f9fd-740d-434e-b186-4e3146651918"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(346, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow448SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow448",
				UId = new Guid("951e2629-0b2d-485f-8466-c7e6827b297e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(366, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow449SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow449",
				UId = new Guid("ee5128a2-2875-4375-bea1-e7fc9b896bc4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(497, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow450SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow450",
				UId = new Guid("0c4dbc32-3c79-4aef-a4cf-58e3c95e0e21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(354, 293),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow33ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow33",
				UId = new Guid("98339cc3-bd6c-44cd-9c17-ca3764eb5c79"),
				ConditionExpression = @"!SelectedActivity",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(546, 298),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow452SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow452",
				UId = new Guid("539742c1-7fc7-401d-8333-ec4d282aefee"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				CurveCenterPosition = new Point(390, 374),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet44LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet44 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2ab231ce-25c1-4294-b43e-8e0e7f116999"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"LaneSet44",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(702, 515),
				UseBackgroundMode = false
			};
			return schemaLaneSet44;
		}

		protected virtual ProcessSchemaLane CreateLane132Lane() {
			ProcessSchemaLane schemaLane132 = new ProcessSchemaLane(this) {
				UId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2ab231ce-25c1-4294-b43e-8e0e7f116999"),
				CreatedInOwnerSchemaUId = new Guid("9bbcfc0d-93c2-4a92-8a30-9ccf72b4610e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"Lane132",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(673, 515),
				UseBackgroundMode = false
			};
			return schemaLane132;
		}

		protected virtual ProcessSchemaGroup CreateChooseActivityTypeGroupGroup() {
			ProcessSchemaGroup schemaChooseActivityTypeGroup = new ProcessSchemaGroup(this) {
				UId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Group",
				IsExpanded = true,
				ManagerItemUId = new Guid("eb7053a9-51e7-456f-9498-73ccc42bfeb6"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"ChooseActivityTypeGroup",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(134, 23),
				Size = new Size(427, 154),
				UseBackgroundMode = false
			};
			schemaChooseActivityTypeGroup.CategorizedFlowElementsUIds = new Collection<Guid>() {
			};
			return schemaChooseActivityTypeGroup;
		}

		protected virtual ProcessSchemaGroup CreateOpenActivityEditPageGroupGroup() {
			ProcessSchemaGroup schemaOpenActivityEditPageGroup = new ProcessSchemaGroup(this) {
				UId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Group",
				IsExpanded = true,
				ManagerItemUId = new Guid("eb7053a9-51e7-456f-9498-73ccc42bfeb6"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"OpenActivityEditPageGroup",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(133, 210),
				Size = new Size(427, 291),
				UseBackgroundMode = false
			};
			schemaOpenActivityEditPageGroup.CategorizedFlowElementsUIds = new Collection<Guid>() {
			};
			return schemaOpenActivityEditPageGroup;
		}

		protected virtual ProcessSchemaStartEvent CreateCreateActivityStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("6fc4602c-fc70-44c3-970e-fd8f8c346555"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"CreateActivityStart",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(36, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateCreateActivityEndEndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49398f23-e44b-4ebd-86a8-a3994832afcc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"CreateActivityEnd",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(631, 275),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBeforeOpenActivityTypeLookupUserTaskScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"BeforeOpenActivityTypeLookupUserTaskScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(70, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,144,209,106,194,64,16,69,223,243,21,67,158,34,152,208,98,162,134,181,130,180,20,164,45,250,160,31,176,217,157,216,173,113,55,236,78,108,243,247,93,9,173,173,72,171,111,195,112,239,157,51,119,81,163,158,9,82,123,69,237,170,173,241,217,152,109,83,175,29,218,21,119,219,100,105,141,64,231,158,176,133,59,16,70,19,126,208,215,50,153,107,71,92,11,92,207,37,11,28,89,165,55,224,196,43,238,184,223,120,125,56,202,138,84,14,242,34,206,50,41,226,180,144,195,120,44,111,111,226,65,153,230,60,27,203,124,40,70,33,3,8,22,255,80,240,13,46,185,229,59,36,180,206,39,107,124,135,7,229,13,70,115,219,194,164,59,222,7,83,188,161,160,105,212,99,193,158,91,168,79,125,65,244,135,171,7,87,97,176,224,119,124,50,147,50,10,191,255,15,251,199,46,60,206,57,45,74,69,47,70,162,151,150,188,114,232,101,247,166,170,60,139,39,156,28,73,79,65,167,80,170,234,71,19,151,153,14,165,156,163,232,158,124,236,18,15,40,221,228,213,22,169,177,26,200,54,200,62,1,46,160,243,209,40,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenActivityTypeLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"OpenActivityTypeLookupUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(217, 49),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeOpenActivityTypeLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateBeforeOpenActivityEditPageUserTaskScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"BeforeOpenActivityEditPageUserTaskScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(71, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,86,93,111,163,56,20,125,46,191,194,195,19,72,5,65,62,8,85,166,149,210,143,169,170,217,105,171,105,102,95,86,251,96,108,211,178,77,32,50,166,221,104,148,255,62,215,6,243,145,144,164,125,10,49,215,231,92,223,115,238,53,111,152,35,76,68,242,150,136,245,124,189,98,179,148,222,208,68,60,226,103,118,157,192,122,150,98,190,70,231,40,101,239,168,89,248,154,11,158,164,207,167,229,207,133,101,163,223,198,201,111,51,142,152,135,9,37,14,137,137,231,208,216,247,157,200,243,98,199,243,124,26,120,236,108,24,146,192,60,69,102,60,136,226,225,217,36,114,194,24,15,157,81,24,97,39,10,206,124,103,60,25,6,94,56,241,207,130,9,54,55,167,18,146,249,225,208,167,236,40,36,30,120,195,128,132,161,67,176,55,114,70,147,209,200,1,148,200,25,71,33,30,5,129,63,160,225,80,67,14,62,6,73,9,165,216,11,198,206,112,224,71,206,104,28,120,14,198,36,114,188,113,28,16,50,25,16,26,122,230,198,216,76,13,227,13,170,152,179,5,35,130,209,89,89,205,132,229,178,158,57,212,206,218,45,28,202,162,255,32,250,194,182,30,86,44,157,181,4,248,43,203,94,139,213,175,156,241,57,206,95,221,91,38,158,42,224,191,241,162,96,185,37,95,93,101,105,202,20,166,109,79,251,216,21,212,29,5,242,146,208,189,89,174,196,186,12,213,114,107,157,123,194,226,140,51,76,94,144,245,157,173,21,237,35,78,248,118,238,40,17,108,137,146,116,223,201,149,41,246,230,37,55,187,0,63,53,54,13,157,76,79,163,30,117,165,194,79,98,100,105,40,116,14,231,232,229,83,161,39,189,7,87,155,213,25,167,16,18,65,34,175,240,0,178,26,18,250,169,44,203,93,126,95,44,22,15,92,149,199,218,197,177,109,196,153,40,120,138,4,151,64,70,91,85,29,86,107,170,254,40,114,217,85,183,69,66,251,32,167,198,17,107,60,242,140,176,60,87,7,71,36,75,5,251,95,232,69,247,46,205,5,78,137,228,169,252,169,41,30,86,171,140,139,34,133,71,149,131,228,239,179,199,140,144,172,72,197,193,24,240,161,128,231,131,49,215,25,41,150,172,7,72,214,87,29,143,205,57,99,183,60,161,87,5,231,16,249,51,123,135,224,47,80,30,40,186,146,78,226,209,10,167,42,219,156,113,142,243,44,22,46,36,17,39,207,5,199,210,23,174,166,219,238,19,16,85,18,106,20,247,27,19,228,229,27,207,150,215,151,7,178,176,187,206,233,156,101,255,46,233,164,125,229,174,19,128,206,150,162,210,171,108,81,44,83,229,192,175,178,60,23,150,217,217,99,218,109,184,182,42,31,129,170,227,187,48,109,225,62,2,83,199,43,152,205,201,9,244,135,161,7,147,246,40,96,85,246,151,122,1,34,172,61,145,23,182,196,63,112,10,166,230,16,208,85,69,141,183,118,132,101,222,236,110,51,109,132,115,212,243,162,26,125,106,9,176,123,24,37,129,110,133,203,245,61,94,50,89,146,50,93,121,148,182,177,244,122,121,124,25,43,231,162,66,115,203,181,92,194,105,24,237,5,211,118,229,66,137,149,53,202,125,18,174,165,121,7,17,151,2,126,18,173,146,189,131,68,74,13,63,137,84,41,95,35,149,37,99,113,121,27,53,77,125,207,222,213,36,211,69,213,17,59,223,14,104,251,30,145,91,100,107,246,52,217,151,246,196,80,173,88,227,186,51,74,235,110,222,61,211,105,207,252,113,231,89,57,207,45,121,107,130,129,219,172,77,99,29,35,221,171,72,195,89,131,109,83,182,25,155,30,60,198,184,87,185,134,177,6,59,196,216,157,69,199,88,15,122,185,97,238,128,186,109,118,57,36,182,250,253,9,238,38,248,189,198,2,255,211,50,81,107,219,191,114,34,233,55,149,221,86,152,3,165,96,124,215,77,181,153,234,79,209,169,209,132,171,115,152,45,34,248,174,235,167,221,186,110,123,239,236,199,118,26,13,9,36,217,190,252,255,0,134,93,101,152,82,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenActivityEditPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"OpenActivityEditPageUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(190, 191),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeOpenActivityEditPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4cf2404-62c0-4872-b5fb-84edd60b84a0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"LookupGridPageClosedIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(336, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("279cfd30-17db-450e-9985-cc649b790580"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(197, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
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
				UId = new Guid("664357bb-934c-4fde-b2f2-e8fc0a67309b"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new CreateActivityProcessCloneForDocument(userConnection);
		}

		public override object Clone() {
			return new CreateActivityProcessCloneForDocumentSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75b8cfc6-80da-47f3-a167-779b61341982"));
		}

		#endregion

	}

	#endregion

	#region Class: CreateActivityProcessCloneForDocument

	/// <exclude/>
	public class CreateActivityProcessCloneForDocument : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane132

		/// <exclude/>
		public class ProcessLane132 : ProcessLane
		{

			public ProcessLane132(UserConnection userConnection, CreateActivityProcessCloneForDocument process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: OpenActivityTypeLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenActivityTypeLookupUserTaskFlowElement : OpenLookupUserTask
		{

			#region Constructors: Public

			public OpenActivityTypeLookupUserTaskFlowElement(UserConnection userConnection, CreateActivityProcessCloneForDocument process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenActivityTypeLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("3d73d129-a59e-4b61-bb05-e48e4209788e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

		}

		#endregion

		#region Class: OpenActivityEditPageUserTaskFlowElement

		/// <exclude/>
		public class OpenActivityEditPageUserTaskFlowElement : OpenPageUserTask
		{

			#region Constructors: Public

			public OpenActivityEditPageUserTaskFlowElement(UserConnection userConnection, CreateActivityProcessCloneForDocument process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenActivityEditPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("f3dc3b97-cc97-4c25-a03c-a758f86145f9");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

		}

		#endregion

		public CreateActivityProcessCloneForDocument(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CreateActivityProcessCloneForDocument";
			SchemaUId = new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("75b8cfc6-80da-47f3-a167-779b61341982");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CreateActivityProcessCloneForDocument, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CreateActivityProcessCloneForDocument, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual bool SelectedActivity {
			get;
			set;
		}

		private ProcessLane132 _lane132;
		public ProcessLane132 Lane132 {
			get {
				return _lane132 ?? ((_lane132) = new ProcessLane132(UserConnection, this));
			}
		}

		private ProcessFlowElement _createActivityStart;
		public ProcessFlowElement CreateActivityStart {
			get {
				return _createActivityStart ?? (_createActivityStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "CreateActivityStart",
					SchemaElementUId = new Guid("6fc4602c-fc70-44c3-970e-fd8f8c346555"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessEndEvent _createActivityEnd;
		public ProcessEndEvent CreateActivityEnd {
			get {
				return _createActivityEnd ?? (_createActivityEnd = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "CreateActivityEnd",
					SchemaElementUId = new Guid("507d0b8e-760c-4043-aa61-4603a3736178"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _beforeOpenActivityTypeLookupUserTaskScriptTask;
		public ProcessScriptTask BeforeOpenActivityTypeLookupUserTaskScriptTask {
			get {
				return _beforeOpenActivityTypeLookupUserTaskScriptTask ?? (_beforeOpenActivityTypeLookupUserTaskScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeOpenActivityTypeLookupUserTaskScriptTask",
					SchemaElementUId = new Guid("c27651a6-c904-4c67-b6cd-02bcf3eef885"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = BeforeOpenActivityTypeLookupUserTaskScriptTaskExecute,
				});
			}
		}

		private OpenActivityTypeLookupUserTaskFlowElement _openActivityTypeLookupUserTask;
		public OpenActivityTypeLookupUserTaskFlowElement OpenActivityTypeLookupUserTask {
			get {
				return _openActivityTypeLookupUserTask ?? (_openActivityTypeLookupUserTask = new OpenActivityTypeLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _beforeOpenActivityEditPageUserTaskScriptTask;
		public ProcessScriptTask BeforeOpenActivityEditPageUserTaskScriptTask {
			get {
				return _beforeOpenActivityEditPageUserTaskScriptTask ?? (_beforeOpenActivityEditPageUserTaskScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeOpenActivityEditPageUserTaskScriptTask",
					SchemaElementUId = new Guid("920b034f-e9f0-4a34-9ffe-6dd95c6d8119"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = BeforeOpenActivityEditPageUserTaskScriptTaskExecute,
				});
			}
		}

		private OpenActivityEditPageUserTaskFlowElement _openActivityEditPageUserTask;
		public OpenActivityEditPageUserTaskFlowElement OpenActivityEditPageUserTask {
			get {
				return _openActivityEditPageUserTask ?? (_openActivityEditPageUserTask = new OpenActivityEditPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _lookupGridPageClosedIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent LookupGridPageClosedIntermediateCatchMessageEvent {
			get {
				return _lookupGridPageClosedIntermediateCatchMessageEvent ?? (_lookupGridPageClosedIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "LookupGridPageClosedIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("467490ca-d037-45ec-a492-7d5378b331f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
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
					SchemaElementUId = new Guid("d2b5ab64-78f2-462b-b415-c626cb09c07d"),
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

		private ProcessConditionalFlow _conditionalFlow33;
		public ProcessConditionalFlow ConditionalFlow33 {
			get {
				return _conditionalFlow33 ?? (_conditionalFlow33 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow33",
					SchemaElementUId = new Guid("98339cc3-bd6c-44cd-9c17-ca3764eb5c79"),
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
			FlowElements[CreateActivityStart.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateActivityStart };
			FlowElements[CreateActivityEnd.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateActivityEnd };
			FlowElements[BeforeOpenActivityTypeLookupUserTaskScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeOpenActivityTypeLookupUserTaskScriptTask };
			FlowElements[OpenActivityTypeLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenActivityTypeLookupUserTask };
			FlowElements[BeforeOpenActivityEditPageUserTaskScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeOpenActivityEditPageUserTaskScriptTask };
			FlowElements[OpenActivityEditPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenActivityEditPageUserTask };
			FlowElements[LookupGridPageClosedIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosedIntermediateCatchMessageEvent };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CreateActivityStart":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("BeforeOpenActivityTypeLookupUserTaskScriptTask", e.Context.SenderName));
						break;
					case "CreateActivityEnd":
						CompleteProcess();
						break;
					case "BeforeOpenActivityTypeLookupUserTaskScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenActivityTypeLookupUserTask", e.Context.SenderName));
						break;
					case "OpenActivityTypeLookupUserTask":
						ActivatedEventElements.Add("LookupGridPageClosedIntermediateCatchMessageEvent");
						break;
					case "BeforeOpenActivityEditPageUserTaskScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "OpenActivityEditPageUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateActivityEnd", e.Context.SenderName));
						break;
					case "LookupGridPageClosedIntermediateCatchMessageEvent":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("BeforeOpenActivityEditPageUserTaskScriptTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow33ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateActivityEnd", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenActivityEditPageUserTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow33ExpressionExecute() {
			bool result = Convert.ToBoolean(!SelectedActivity);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow33", "!SelectedActivity", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("SelectedActivity")) {
				writer.WriteValue("SelectedActivity", SelectedActivity, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateActivityStart", string.Empty));
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
			MetaPathParameterValues.Add("48afa22b-7602-4990-9f3e-061a442a8e6a", () => PageInstanceId);
			MetaPathParameterValues.Add("68768651-b929-4d24-ad67-4b7f1dd06f1b", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("5fca99d5-4536-4f81-8778-87f2b17c44ed", () => SelectedActivity);
			MetaPathParameterValues.Add("7c42a570-d16c-4740-85e9-587a7c231a16", () => OpenActivityTypeLookupUserTask.PageParameters);
			MetaPathParameterValues.Add("7222b831-d4eb-4d55-b69b-0bf8578b9e9e", () => OpenActivityTypeLookupUserTask.ProcessKey);
			MetaPathParameterValues.Add("5b90e09c-c471-46d6-9f5d-87cdc7efe4e4", () => OpenActivityTypeLookupUserTask.UserContextKey);
			MetaPathParameterValues.Add("fc012c0e-2e6c-421b-ad7f-440b0f036325", () => OpenActivityTypeLookupUserTask.UseCurrentActivePage);
			MetaPathParameterValues.Add("9cc3e5db-0506-47e6-8b27-efadda2cb88b", () => OpenActivityEditPageUserTask.PageUId);
			MetaPathParameterValues.Add("b79dad0a-6cf5-450f-a4e6-b8917e7e9301", () => OpenActivityEditPageUserTask.PageUrl);
			MetaPathParameterValues.Add("26db47b8-17d4-4ffb-82e9-4453d8f508b2", () => OpenActivityEditPageUserTask.OpenerInstanceId);
			MetaPathParameterValues.Add("c9a42adb-6104-4870-b756-4bf340757950", () => OpenActivityEditPageUserTask.CloseOpenerOnLoad);
			MetaPathParameterValues.Add("a7cfd311-080e-4bea-a766-8e8dcab60aa0", () => OpenActivityEditPageUserTask.PageParameters);
			MetaPathParameterValues.Add("a0be2a70-6167-4750-b6fc-cfd85f6f52f7", () => OpenActivityEditPageUserTask.Width);
			MetaPathParameterValues.Add("824337a6-ab71-4560-9425-1820381aef1c", () => OpenActivityEditPageUserTask.CloseMessage);
			MetaPathParameterValues.Add("0362a1ad-23f4-400f-9c87-58b6ae2cfae0", () => OpenActivityEditPageUserTask.Height);
			MetaPathParameterValues.Add("3bdd4182-000f-4d5c-8cf4-d1234ab6bba7", () => OpenActivityEditPageUserTask.Centered);
			MetaPathParameterValues.Add("3e111e58-83bf-4da4-823f-cb70ffcf49f5", () => OpenActivityEditPageUserTask.UseOpenerRegisterScript);
			MetaPathParameterValues.Add("d1d2784c-8bea-4fd7-a223-bb3659de78c7", () => OpenActivityEditPageUserTask.UseCurrentActivePage);
			MetaPathParameterValues.Add("bb40ba52-ad85-4880-90df-f4882e51e669", () => OpenActivityEditPageUserTask.IgnoreProfile);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "SelectedActivity":
					if (!hasValueToRead) break;
					SelectedActivity = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool BeforeOpenActivityTypeLookupUserTaskScriptTaskExecute(ProcessExecutingContext context) {
			OpenActivityTypeLookupUserTask.ProcessKey = context.Process.InstanceUId;
			string schemaUId = "75b4d39b-55dc-4bd6-8d10-3f49a58d96c7";  
			OpenActivityTypeLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = 
			(Dictionary <string, object>) OpenActivityTypeLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("editMode", false);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			pageParameters.Add("LookupFilters", filters);
			return true;
		}

		public virtual bool BeforeOpenActivityEditPageUserTaskScriptTaskExecute(ProcessExecutingContext context) {
			var activityTypeAndEditPageDictionary = new Dictionary<string,string>() {
				{"fbe0acdc-cfc0-df11-b00f-001d60e938c6", "f2bf397b-8fa3-48ba-b691-57360871967a"},
				{"e1831dec-cfc0-df11-b00f-001d60e938c6", "a2036c88-ca04-4744-967b-5b8a46612d83"},
				{"e2831dec-cfc0-df11-b00f-001d60e938c6", "dcdda065-321b-4560-aacb-05f6cc72cd80"}
			};
			
			var selectedActivitiesTypes = (Dictionary<string, object>)(OpenActivityTypeLookupUserTask.GetSelectedValues(UserConnection));
			var selectedActivityTypeId = string.Empty;
			var activityEditPageId = string.Empty;
			foreach (KeyValuePair<string, object> item in selectedActivitiesTypes) {
				selectedActivityTypeId = item.Key;
			}
			foreach (var item in activityTypeAndEditPageDictionary) {
				if (item.Key == selectedActivityTypeId) {
					activityEditPageId = item.Value;
					break;
				}
			}
			if (String.IsNullOrEmpty(activityEditPageId)) return true;
			
			OpenActivityEditPageUserTask.PageUId = new Guid(activityEditPageId);
			OpenActivityTypeLookupUserTask.ProcessKey = context.Process.InstanceUId;
			
			var activityOpportunityId = Guid.Empty;
			var activityAccountId = Guid.Empty;
			var activityContactId = Guid.Empty;
			var activityDocumentId = Guid.Empty;
			if (ActiveTreeGridCurrentRowId != null) {
				var document = new Terrasoft.Configuration.Document(UserConnection);
				if (document.FetchFromDB(ActiveTreeGridCurrentRowId)) {
					activityDocumentId = ActiveTreeGridCurrentRowId;
					activityOpportunityId = document.GetTypedColumnValue<Guid>("OpportunityId");
					activityAccountId = document.GetTypedColumnValue<Guid>("AccountId");
					activityContactId = document.GetTypedColumnValue<Guid>("ContactId");
				}		
			}
			
			SelectedActivity = true;
			
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByName("Activity");
			var documentActivityColumnName = schema.Columns.GetByName("Document").Name;
			var opportunityActivityColumnName = schema.Columns.GetByName("Opportunity").Name;
			var accountActivityColumnName = schema.Columns.GetByName("Account").Name;
			var contactActivityColumnName = schema.Columns.GetByName("Contact").Name;
			
			var defValuesId = Guid.NewGuid();
			var defValues = new Dictionary <string, object>();
			if (activityDocumentId != Guid.Empty) {
				defValues.Add(documentActivityColumnName, activityDocumentId.ToString());
			}
			
			if (activityAccountId != Guid.Empty) {
				defValues.Add(accountActivityColumnName, activityAccountId.ToString());
			}
			if (activityContactId != Guid.Empty) {
				defValues.Add(contactActivityColumnName, activityContactId.ToString());
			}
			if (activityOpportunityId != Guid.Empty) {
				defValues.Add(opportunityActivityColumnName, activityOpportunityId.ToString());	
			}
			UserConnection.SessionData[defValuesId.ToString()] = defValues;
			
			var parameters = new Dictionary<string, string>();
			parameters.Add("defValuesId", defValuesId.ToString());
			OpenActivityEditPageUserTask.PageParameters = parameters;
			
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosedIntermediateCatchMessageEvent")) {
						context.QueueTasksV2.Enqueue(new ProcessQueueElement("LookupGridPageClosedIntermediateCatchMessageEvent", "LookupGridPageClosedIntermediateCatchMessageEvent"));
					}
					break;
			}
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
			var cloneItem = (CreateActivityProcessCloneForDocument)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

