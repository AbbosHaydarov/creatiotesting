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
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ViewRecordAllChangesProcessSchema

	/// <exclude/>
	public class ViewRecordAllChangesProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ViewRecordAllChangesProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ViewRecordAllChangesProcessSchema(ViewRecordAllChangesProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ViewRecordAllChangesProcess";
			UId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438");
			BackgroundModePriority = BackgroundModePriority.Medium;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438");
			Version = 0;
			PackageUId = new Guid("06d9ef10-51d8-122c-8933-9212e84236c9");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02ebc602-b614-42e3-92f4-72a724b1e92f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6c5bae4c-c34a-4bf9-80d0-61fbb7c91dd8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"Page",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateShowGridParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3d7b9c01-8151-469d-8d94-64baf9bc6eb0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"ShowGrid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("71d8fb77-af88-4aaf-8f7d-769f4bbfe83f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"CurrentSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0bd6afe1-e067-4ce7-ab1c-ad0f7b4a84a0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterByChangeTrackedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("23e517dd-2f43-4894-9151-37cd960f1d93"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"FilterByChangeTracked",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordNotSelectedMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("17e3b620-2918-4660-8368-143d59c6da5c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"RecordNotSelectedMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreatePageParameter());
			Parameters.Add(CreateShowGridParameter());
			Parameters.Add(CreateCurrentSchemaUIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateFilterByChangeTrackedParameter());
			Parameters.Add(CreateRecordNotSelectedMessageParameter());
		}

		protected virtual void InitializeOpenGridPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fed1b265-7a88-40d5-9aab-2f730d5b56e1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("b07ed27e-cda3-4074-bb4d-e220e23cc856"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("51420213-2e9e-4baf-9a53-f59359845b57"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("a01fbaa2-0025-46f5-8002-01973fdef582"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("946606ed-b8b0-4368-b3f2-829db7d972e1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("a0bc2be7-315b-4f09-bd1b-f49aa523daae"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("63b7efcf-04a2-4483-b578-8e3e4669da36"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("b593d800-eeab-40e3-89c0-19c5bc4a90f8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("3d9b4a78-0619-4888-91b8-c65860cb9772"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("e5937907-a215-4f63-903b-c6c0365e17b4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("6c4ab842-4d6b-4775-8966-3f5c82086535"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("53b3ee84-6c68-48ae-92e2-d4fc720b1716"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreProfileParameter);
		}

		protected virtual void InitializeShowMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a382ed28-d3b2-4968-ae8b-07582b718e61"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			pageParameter.SourceValue = new ProcessSchemaParameterValue(pageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageParameter);
			var iconParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df40cb7e-cde7-4f58-9cc2-fb0379775b4d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			iconParameter.SourceValue = new ProcessSchemaParameterValue(iconParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(iconParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24d293f2-eef6-414a-ad10-6d56399173d5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			buttonsParameter.SourceValue = new ProcessSchemaParameterValue(buttonsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var windowCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("236e33b0-2730-472b-9064-e3674474f378"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			windowCaptionParameter.SourceValue = new ProcessSchemaParameterValue(windowCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(windowCaptionParameter);
			var messageTextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("428ecd53-04d3-4bc2-adc4-140ea47da2f9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			messageTextParameter.SourceValue = new ProcessSchemaParameterValue(messageTextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(messageTextParameter);
			var responseMessagesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abcd1e76-3775-47bd-88ea-5ae7b18cf86e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			responseMessagesParameter.SourceValue = new ProcessSchemaParameterValue(responseMessagesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(responseMessagesParameter);
			var processInstanceIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c675b7d1-5f91-47de-8a84-44dd3ba1ae8d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			processInstanceIdParameter.SourceValue = new ProcessSchemaParameterValue(processInstanceIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(processInstanceIdParameter);
			var pageParametersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c518195-debc-47ba-a7ea-09ae20f853ee"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			pageParametersParameter.SourceValue = new ProcessSchemaParameterValue(pageParametersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageParametersParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet16 = CreateLaneSet16LaneSet();
			LaneSets.Add(schemaLaneSet16);
			ProcessSchemaLane schemaLane52 = CreateLane52Lane();
			schemaLaneSet16.Lanes.Add(schemaLane52);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask checkparametersscripttask = CreateCheckParametersScriptTaskScriptTask();
			FlowElements.Add(checkparametersscripttask);
			ProcessSchemaUserTask opengridpageusertask = CreateOpenGridPageUserTaskUserTask();
			FlowElements.Add(opengridpageusertask);
			ProcessSchemaUserTask showmessageusertask = CreateShowMessageUserTaskUserTask();
			FlowElements.Add(showmessageusertask);
			FlowElements.Add(CreateSequenceFlow178SequenceFlow());
			FlowElements.Add(CreateConditionalFlow21ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow180SequenceFlow());
			FlowElements.Add(CreateSequenceFlow181SequenceFlow());
			FlowElements.Add(CreateSequenceFlow182SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow178SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow178",
				UId = new Guid("e2541e01-fc8f-4dac-8baf-b0c37073cd33"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d33f4bb1-0400-4d7d-8105-add7f1ad4217"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6f87a3e8-c275-4e15-92c5-6bcc7b918ad5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow21ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow21",
				UId = new Guid("c8a1f7ce-0534-44a2-8765-e9385fa15f3c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"ShowGrid",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				CurveCenterPosition = new Point(330, 134),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f87a3e8-c275-4e15-92c5-6bcc7b918ad5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow180SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow180",
				UId = new Guid("ada79fbc-3ebb-49c3-a463-7f26c4f0e0ce"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				CurveCenterPosition = new Point(330, 231),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f87a3e8-c275-4e15-92c5-6bcc7b918ad5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow181SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow181",
				UId = new Guid("908bf2e3-cd3d-4023-b110-edd8b0592be0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				CurveCenterPosition = new Point(546, 138),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b20b653-c814-4972-ac2b-6dc1cd08e8c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow182SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow182",
				UId = new Guid("d4587d72-dbb2-4098-92b8-9d0a73664ba8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				CurveCenterPosition = new Point(546, 248),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b20b653-c814-4972-ac2b-6dc1cd08e8c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet16LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet16 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b534fc13-4898-4125-a190-7cf1c0eedc51"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"LaneSet16",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet16;
		}

		protected virtual ProcessSchemaLane CreateLane52Lane() {
			ProcessSchemaLane schemaLane52 = new ProcessSchemaLane(this) {
				UId = new Guid("c138a33a-67d1-4ac0-8b98-e9193e8cfacc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b534fc13-4898-4125-a190-7cf1c0eedc51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"Lane52",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane52;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("d33f4bb1-0400-4d7d-8105-add7f1ad4217"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c138a33a-67d1-4ac0-8b98-e9193e8cfacc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"Start1",
				Position = new Point(50, 163),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("9b20b653-c814-4972-ac2b-6dc1cd08e8c3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c138a33a-67d1-4ac0-8b98-e9193e8cfacc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"End1",
				Position = new Point(596, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6f87a3e8-c275-4e15-92c5-6bcc7b918ad5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c138a33a-67d1-4ac0-8b98-e9193e8cfacc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"CheckParametersScriptTask",
				Position = new Point(176, 149),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,85,93,79,219,48,20,125,102,210,254,131,151,167,84,162,81,39,64,133,65,59,181,105,41,209,68,97,180,140,7,196,131,73,110,219,140,212,238,108,135,46,2,254,251,174,237,148,52,165,129,167,61,84,174,157,123,238,57,190,95,142,39,196,245,83,33,128,169,81,56,131,57,189,14,34,210,106,145,65,26,71,94,127,190,80,25,121,126,38,157,80,197,143,48,22,0,3,17,71,185,253,21,95,110,218,214,200,211,231,79,59,163,25,95,106,59,210,34,19,154,72,56,206,207,206,65,74,58,133,107,9,98,76,229,131,119,41,120,136,71,1,147,138,178,16,130,168,181,250,139,34,42,65,184,65,199,163,76,42,152,123,55,112,239,157,41,181,240,57,83,240,87,121,185,180,213,122,70,89,148,128,32,84,146,49,8,65,37,159,40,239,58,208,48,141,16,60,145,198,97,21,89,190,31,163,107,228,188,130,144,139,104,200,213,8,18,8,21,68,249,231,42,116,16,114,134,48,231,166,115,53,12,134,3,167,202,174,155,42,197,153,212,166,23,63,180,213,11,1,12,155,137,229,35,21,68,154,196,224,103,141,64,221,12,201,99,206,188,62,83,177,202,108,218,206,41,67,151,194,27,128,90,5,177,155,97,24,223,36,183,118,156,123,133,53,180,206,99,78,227,173,197,62,79,162,18,41,172,80,11,42,232,28,20,8,45,151,193,146,244,98,35,134,138,236,68,42,17,179,233,46,191,255,141,2,219,174,97,42,236,111,29,75,16,68,206,29,98,203,244,43,247,17,76,126,209,36,5,25,68,35,37,72,94,91,67,88,234,213,173,121,99,62,50,36,214,185,70,40,42,166,144,95,175,184,4,134,97,44,104,248,224,207,40,155,162,55,214,235,90,147,2,152,240,233,122,0,127,166,32,178,194,65,32,55,241,228,187,185,239,27,140,251,49,101,141,124,123,23,91,59,222,41,68,217,207,151,84,103,45,136,124,158,164,115,93,69,219,228,122,157,40,55,112,29,75,107,20,64,228,152,91,6,111,0,167,113,130,169,8,176,115,180,63,91,207,246,76,219,199,56,11,190,216,109,55,43,249,179,125,189,179,129,169,82,229,11,160,10,172,205,77,172,102,151,175,53,224,218,67,159,207,177,46,98,201,217,56,91,128,215,255,147,210,100,151,56,88,25,187,239,140,26,115,167,181,214,248,223,114,202,17,253,88,25,254,182,242,91,18,169,147,229,110,72,94,47,70,123,174,219,106,171,23,44,47,123,136,9,215,211,7,123,206,45,207,131,218,42,135,133,51,207,231,41,83,164,77,26,121,6,53,87,104,149,91,111,166,243,11,192,109,227,206,20,50,198,33,175,44,211,142,39,186,253,218,110,69,117,122,198,198,200,236,36,49,149,70,72,169,243,109,179,231,157,191,193,191,138,221,198,112,27,225,144,196,181,71,21,189,45,79,5,237,163,112,110,90,231,98,1,76,39,69,207,242,210,75,81,228,186,114,92,17,187,182,109,128,158,156,53,50,76,122,153,90,235,124,209,130,183,18,234,67,236,174,215,231,12,41,55,30,180,74,157,230,213,53,2,205,160,115,26,123,135,167,7,7,157,94,189,231,239,29,213,247,123,253,78,189,123,212,219,175,119,155,205,230,105,179,113,120,218,223,255,106,154,28,21,9,80,169,96,118,74,255,3,201,252,167,121,207,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenGridPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c138a33a-67d1-4ac0-8b98-e9193e8cfacc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"OpenGridPageUserTask",
				Position = new Point(344, 51),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeOpenGridPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c138a33a-67d1-4ac0-8b98-e9193e8cfacc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"ShowMessageUserTask",
				Position = new Point(344, 247),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeShowMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a369e679-44d1-4bd8-91bb-a9cd19d8850a"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("decb8af7-e9e5-4c08-9d0f-e4636f42f1b6"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ViewRecordAllChangesProcess(userConnection);
		}

		public override object Clone() {
			return new ViewRecordAllChangesProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"));
		}

		#endregion

	}

	#endregion

	#region Class: ViewRecordAllChangesProcess

	/// <exclude/>
	public class ViewRecordAllChangesProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane52

		/// <exclude/>
		public class ProcessLane52 : ProcessLane
		{

			public ProcessLane52(UserConnection userConnection, ViewRecordAllChangesProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: OpenGridPageUserTaskFlowElement

		/// <exclude/>
		public class OpenGridPageUserTaskFlowElement : OpenPageUserTask
		{

			#region Constructors: Public

			public OpenGridPageUserTaskFlowElement(UserConnection userConnection, ViewRecordAllChangesProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenGridPageUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("dfb5dc20-5d4d-4a72-9cca-5bc19567a0a6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

		}

		#endregion

		#region Class: ShowMessageUserTaskFlowElement

		/// <exclude/>
		public class ShowMessageUserTaskFlowElement : QuestionUserTask
		{

			#region Constructors: Public

			public ShowMessageUserTaskFlowElement(UserConnection userConnection, ViewRecordAllChangesProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowMessageUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("f0a7f14d-5b44-4058-b8de-5b4f23742f32");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

		}

		#endregion

		public ViewRecordAllChangesProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ViewRecordAllChangesProcess";
			SchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438");
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
				return new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ViewRecordAllChangesProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ViewRecordAllChangesProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Object Page {
			get;
			set;
		}

		public virtual bool ShowGrid {
			get;
			set;
		}

		public virtual Guid CurrentSchemaUId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual bool FilterByChangeTracked {
			get;
			set;
		}

		private LocalizableString _recordNotSelectedMessage;
		public virtual LocalizableString RecordNotSelectedMessage {
			get {
				return _recordNotSelectedMessage ?? (_recordNotSelectedMessage = GetLocalizableString("d71118073e7b4e7a8a982d77f3250438",
						 "Parameters.RecordNotSelectedMessage.Value"));
			}
			set {
				_recordNotSelectedMessage = value;
			}
		}

		private ProcessLane52 _lane52;
		public ProcessLane52 Lane52 {
			get {
				return _lane52 ?? ((_lane52) = new ProcessLane52(UserConnection, this));
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
					SchemaElementUId = new Guid("d33f4bb1-0400-4d7d-8105-add7f1ad4217"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("9b20b653-c814-4972-ac2b-6dc1cd08e8c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _checkParametersScriptTask;
		public ProcessScriptTask CheckParametersScriptTask {
			get {
				return _checkParametersScriptTask ?? (_checkParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckParametersScriptTask",
					SchemaElementUId = new Guid("6f87a3e8-c275-4e15-92c5-6bcc7b918ad5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CheckParametersScriptTaskExecute,
				});
			}
		}

		private OpenGridPageUserTaskFlowElement _openGridPageUserTask;
		public OpenGridPageUserTaskFlowElement OpenGridPageUserTask {
			get {
				return _openGridPageUserTask ?? (_openGridPageUserTask = new OpenGridPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ShowMessageUserTaskFlowElement _showMessageUserTask;
		public ShowMessageUserTaskFlowElement ShowMessageUserTask {
			get {
				return _showMessageUserTask ?? (_showMessageUserTask = new ShowMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlow21;
		public ProcessConditionalFlow ConditionalFlow21 {
			get {
				return _conditionalFlow21 ?? (_conditionalFlow21 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow21",
					SchemaElementUId = new Guid("c8a1f7ce-0534-44a2-8765-e9385fa15f3c"),
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
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[CheckParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckParametersScriptTask };
			FlowElements[OpenGridPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenGridPageUserTask };
			FlowElements[ShowMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CheckParametersScriptTask", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "CheckParametersScriptTask":
						if (ConditionalFlow21ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenGridPageUserTask", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ShowMessageUserTask", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "CheckParametersScriptTask");
						break;
					case "OpenGridPageUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "ShowMessageUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow21ExpressionExecute() {
			bool result = Convert.ToBoolean(ShowGrid);
			Log.InfoFormat(ConditionalExpressionLogMessage, "CheckParametersScriptTask", "ConditionalFlow21", "ShowGrid", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (Page != null) {
				if (Page.GetType().IsSerializable ||
					Page.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Page", Page, null);
				}
			}
			if (!HasMapping("ShowGrid")) {
				writer.WriteValue("ShowGrid", ShowGrid, false);
			}
			if (!HasMapping("CurrentSchemaUId")) {
				writer.WriteValue("CurrentSchemaUId", CurrentSchemaUId, Guid.Empty);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("FilterByChangeTracked")) {
				writer.WriteValue("FilterByChangeTracked", FilterByChangeTracked, false);
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
			MetaPathParameterValues.Add("02ebc602-b614-42e3-92f4-72a724b1e92f", () => PageInstanceId);
			MetaPathParameterValues.Add("6c5bae4c-c34a-4bf9-80d0-61fbb7c91dd8", () => Page);
			MetaPathParameterValues.Add("3d7b9c01-8151-469d-8d94-64baf9bc6eb0", () => ShowGrid);
			MetaPathParameterValues.Add("71d8fb77-af88-4aaf-8f7d-769f4bbfe83f", () => CurrentSchemaUId);
			MetaPathParameterValues.Add("0bd6afe1-e067-4ce7-ab1c-ad0f7b4a84a0", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("23e517dd-2f43-4894-9151-37cd960f1d93", () => FilterByChangeTracked);
			MetaPathParameterValues.Add("17e3b620-2918-4660-8368-143d59c6da5c", () => RecordNotSelectedMessage);
			MetaPathParameterValues.Add("fed1b265-7a88-40d5-9aab-2f730d5b56e1", () => OpenGridPageUserTask.PageUId);
			MetaPathParameterValues.Add("b07ed27e-cda3-4074-bb4d-e220e23cc856", () => OpenGridPageUserTask.PageUrl);
			MetaPathParameterValues.Add("51420213-2e9e-4baf-9a53-f59359845b57", () => OpenGridPageUserTask.OpenerInstanceId);
			MetaPathParameterValues.Add("a01fbaa2-0025-46f5-8002-01973fdef582", () => OpenGridPageUserTask.CloseOpenerOnLoad);
			MetaPathParameterValues.Add("946606ed-b8b0-4368-b3f2-829db7d972e1", () => OpenGridPageUserTask.PageParameters);
			MetaPathParameterValues.Add("a0bc2be7-315b-4f09-bd1b-f49aa523daae", () => OpenGridPageUserTask.Width);
			MetaPathParameterValues.Add("63b7efcf-04a2-4483-b578-8e3e4669da36", () => OpenGridPageUserTask.CloseMessage);
			MetaPathParameterValues.Add("b593d800-eeab-40e3-89c0-19c5bc4a90f8", () => OpenGridPageUserTask.Height);
			MetaPathParameterValues.Add("3d9b4a78-0619-4888-91b8-c65860cb9772", () => OpenGridPageUserTask.Centered);
			MetaPathParameterValues.Add("e5937907-a215-4f63-903b-c6c0365e17b4", () => OpenGridPageUserTask.UseOpenerRegisterScript);
			MetaPathParameterValues.Add("6c4ab842-4d6b-4775-8966-3f5c82086535", () => OpenGridPageUserTask.UseCurrentActivePage);
			MetaPathParameterValues.Add("53b3ee84-6c68-48ae-92e2-d4fc720b1716", () => OpenGridPageUserTask.IgnoreProfile);
			MetaPathParameterValues.Add("a382ed28-d3b2-4968-ae8b-07582b718e61", () => ShowMessageUserTask.Page);
			MetaPathParameterValues.Add("df40cb7e-cde7-4f58-9cc2-fb0379775b4d", () => ShowMessageUserTask.Icon);
			MetaPathParameterValues.Add("24d293f2-eef6-414a-ad10-6d56399173d5", () => ShowMessageUserTask.Buttons);
			MetaPathParameterValues.Add("236e33b0-2730-472b-9064-e3674474f378", () => ShowMessageUserTask.WindowCaption);
			MetaPathParameterValues.Add("428ecd53-04d3-4bc2-adc4-140ea47da2f9", () => ShowMessageUserTask.MessageText);
			MetaPathParameterValues.Add("abcd1e76-3775-47bd-88ea-5ae7b18cf86e", () => ShowMessageUserTask.ResponseMessages);
			MetaPathParameterValues.Add("c675b7d1-5f91-47de-8a84-44dd3ba1ae8d", () => ShowMessageUserTask.ProcessInstanceId);
			MetaPathParameterValues.Add("0c518195-debc-47ba-a7ea-09ae20f853ee", () => ShowMessageUserTask.PageParameters);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "Page":
					if (!hasValueToRead) break;
					Page = reader.GetSerializableObjectValue();
				break;
				case "ShowGrid":
					if (!hasValueToRead) break;
					ShowGrid = reader.GetValue<System.Boolean>();
				break;
				case "CurrentSchemaUId":
					if (!hasValueToRead) break;
					CurrentSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "FilterByChangeTracked":
					if (!hasValueToRead) break;
					FilterByChangeTracked = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool CheckParametersScriptTaskExecute(ProcessExecutingContext context) {
			if (CurrentSchemaUId == Guid.Empty || ActiveTreeGridCurrentRowId == Guid.Empty) {
				ShowGrid = false;
				ShowMessageUserTask.ProcessInstanceId=InstanceUId;
				ShowMessageUserTask.Page = System.Web.HttpContext.Current.CurrentHandler as Terrasoft.UI.WebControls.Page;
				ShowMessageUserTask.MessageText = RecordNotSelectedMessage;
				ShowMessageUserTask.Icon = "WARNING";
				ShowMessageUserTask.Buttons = "OK";
			} else {
				var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(CurrentSchemaUId);
				var entitySchemaId = schema.UId;
				ShowGrid = true;
				var parameters = new Dictionary<string,object>();
				parameters["schemaId"] = entitySchemaId;
				var defValuesIdStr = Guid.NewGuid().ToString();
				var targetSchema = schema.GetTrackChangesInDBSchema();
				var logEntitySchemaQuery = schema.IsTrackChangesInDB ? new EntitySchemaQuery(schema.GetTrackChangesInDBSchema()) : new EntitySchemaQuery(schema);	
				var logSchemaParentIdColumn = logEntitySchemaQuery.AddColumn("ChangeTracked");
				IEntitySchemaQueryFilterItem logRecordFilter;
				if (!FilterByChangeTracked) {
					logRecordFilter = logEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", ActiveTreeGridCurrentRowId);
				} else {
					logRecordFilter = logEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "ChangeTracked", ActiveTreeGridCurrentRowId);
				}
				logEntitySchemaQuery.Filters.Add(logRecordFilter);
				var logRecords = logEntitySchemaQuery.GetEntityCollection(UserConnection);
				if (logRecords.Count > 0) {
					var currentEntityId = logRecords[0].GetTypedColumnValue<Guid>(logSchemaParentIdColumn.ValueQueryAlias);
					parameters["entityId"] = currentEntityId;
				}
				UserConnection.SessionData[defValuesIdStr] = parameters;	
				OpenGridPageUserTask.PageParameters = new Dictionary<string, string> {
					{"defValuesId", defValuesIdStr}
				};
				OpenGridPageUserTask.OpenerInstanceId = InstanceUId;
				OpenGridPageUserTask.PageUId = new Guid("038F55AD-DC39-4DEA-B9D4-B777F708FE41");
			}
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
			var cloneItem = (ViewRecordAllChangesProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Page = Page;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

