﻿namespace Terrasoft.Core.Process
{

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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ShowAddressOnMapProcessSchema

	/// <exclude/>
	public class ShowAddressOnMapProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ShowAddressOnMapProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ShowAddressOnMapProcessSchema(ShowAddressOnMapProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ShowAddressOnMapProcess";
			UId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d");
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
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,87,203,110,219,70,20,93,203,128,255,97,204,69,64,1,2,211,117,27,7,144,21,217,16,90,75,137,172,52,139,32,139,49,57,178,38,38,57,234,204,208,142,144,8,72,211,109,128,124,66,127,193,125,4,8,250,112,126,129,250,163,220,121,136,15,145,180,229,160,168,33,195,212,204,185,231,158,185,47,142,119,119,230,201,105,72,125,116,65,185,76,112,136,78,25,11,81,111,70,252,243,30,139,3,42,41,139,221,54,122,189,187,211,186,127,127,50,122,52,250,22,165,191,174,222,166,215,233,239,233,71,248,251,105,245,110,245,30,165,127,195,194,31,233,167,244,175,213,47,40,253,7,118,222,193,194,159,233,21,74,63,167,215,171,159,97,255,35,130,239,215,233,111,233,21,88,194,215,244,95,176,253,160,246,175,128,230,202,24,169,39,52,225,132,28,113,26,156,144,144,248,146,4,99,118,41,6,129,0,5,240,209,242,56,17,73,40,209,62,154,226,80,144,239,96,249,2,115,68,98,73,229,226,196,159,145,8,31,227,24,159,17,14,144,167,130,112,56,73,12,84,112,20,175,95,5,213,217,131,97,13,157,119,68,228,32,22,18,199,62,57,88,12,113,68,92,179,175,30,219,107,30,161,151,122,120,174,28,110,16,121,118,89,97,79,102,236,242,152,8,1,204,74,228,4,139,115,111,224,107,19,231,89,119,60,28,12,143,156,38,220,65,34,37,139,133,130,142,190,215,40,248,208,41,114,187,112,204,11,178,14,97,47,225,28,220,67,4,7,1,218,223,71,71,9,13,188,126,52,151,11,147,210,90,110,251,125,66,94,169,16,11,201,105,124,230,29,50,30,97,233,14,153,204,210,66,124,198,3,11,238,148,79,237,253,136,195,132,120,19,246,3,187,36,220,109,235,216,180,56,145,9,143,145,228,137,206,217,210,168,86,33,195,1,164,84,100,161,191,61,103,53,153,40,11,117,94,127,179,236,6,154,214,233,160,66,150,178,52,205,176,176,225,25,157,190,4,79,22,125,83,85,61,73,8,95,0,32,38,151,168,191,185,238,214,20,76,167,116,50,175,84,38,62,75,98,201,23,61,22,38,209,102,153,104,66,15,20,153,93,215,233,25,176,147,89,115,114,6,161,217,206,120,172,177,185,173,15,208,45,221,194,86,110,135,77,132,182,51,93,7,95,91,87,145,135,52,148,132,11,101,225,86,119,123,156,96,73,12,230,25,149,179,199,152,67,232,148,129,107,22,123,44,154,99,78,5,139,39,139,57,241,250,63,193,232,234,32,93,209,89,170,59,168,185,25,218,255,183,44,231,49,167,17,134,12,118,116,253,231,101,104,188,64,212,84,87,85,7,134,113,12,213,222,223,192,185,229,38,209,124,83,6,2,253,25,114,115,98,68,227,138,11,219,251,106,92,152,45,197,175,4,219,228,233,230,125,160,102,197,67,183,84,165,166,173,181,164,110,72,177,104,163,189,226,76,81,164,173,55,111,208,173,164,197,226,253,175,56,243,162,222,146,113,207,14,140,129,24,38,97,56,226,122,243,166,128,24,252,67,183,212,6,166,167,219,54,164,173,86,243,84,89,143,61,248,57,133,52,157,155,231,101,62,8,85,62,198,44,145,228,152,5,196,18,218,65,117,12,71,139,37,174,29,82,69,12,84,95,188,104,194,248,70,151,170,155,234,140,181,162,213,106,102,16,173,189,62,85,111,143,162,189,103,55,6,65,9,172,221,27,112,30,239,220,191,177,177,243,115,66,56,199,130,77,165,226,154,210,179,132,99,35,196,160,234,202,187,200,146,31,114,11,50,11,110,228,196,190,46,243,237,56,187,37,112,45,103,125,198,202,202,189,254,43,42,224,29,246,232,64,77,119,189,3,179,161,24,242,202,153,239,120,53,201,104,27,136,236,68,50,117,172,44,114,141,246,125,5,156,21,144,187,13,91,133,201,44,11,197,104,213,221,44,165,232,68,91,78,216,33,145,48,218,170,47,95,99,244,252,133,237,192,219,252,58,54,127,78,91,193,151,218,143,234,60,107,231,105,55,135,156,69,144,152,102,141,229,76,117,54,84,102,227,96,163,41,214,62,172,4,232,30,213,247,89,189,108,116,111,185,42,139,245,178,62,130,81,177,118,96,98,182,52,55,45,123,65,222,115,221,186,98,132,241,87,227,179,141,238,221,107,186,22,25,242,187,94,23,199,106,156,101,255,71,220,225,174,184,68,4,70,151,137,98,126,152,6,109,95,37,173,171,77,225,62,11,113,149,66,33,183,214,6,191,246,42,107,164,193,34,172,237,238,124,1,126,175,255,194,76,13,0,0 };
			RealUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d");
			Version = 0;
			PackageUId = new Guid("06d9ef10-51d8-122c-8933-9212e84236c9");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("886d5f2f-b6e6-4b62-8959-ecba1b049eb7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d6a48244-98e4-4d58-9e1d-170bf5aa4fb2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateConditionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("127f0a06-9503-424d-817a-049785eed539"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"Condition",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("10dba2e7-c982-4088-8a2b-6efe103a72ab"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"SchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRouteModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4d62a7de-12af-4c26-98e3-1caa711ec265"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"RouteMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTreeGridSelectedRowsIdsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0ccda9d4-c906-4ad0-988f-60939060e266"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"TreeGridSelectedRowsIds",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNotSelectedRecordMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3b1f3831-261b-472e-884d-8975218f6b1d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"NotSelectedRecordMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateAdressNotExitsMesssageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ff2fc526-a15e-45db-a96f-dc7932a8c595"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"AdressNotExitsMesssage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateRouteConditionMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7b132ca7-301b-409d-90dd-cd3fc7030348"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"RouteConditionMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateConditionParameter());
			Parameters.Add(CreateSchemaNameParameter());
			Parameters.Add(CreateRouteModeParameter());
			Parameters.Add(CreateTreeGridSelectedRowsIdsParameter());
			Parameters.Add(CreateNotSelectedRecordMessageParameter());
			Parameters.Add(CreateAdressNotExitsMesssageParameter());
			Parameters.Add(CreateRouteConditionMessageParameter());
		}

		protected virtual void InitializeOpenPageUserTesParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5c251de6-be68-473c-b19b-ccae6fc24c09"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("334f9a34-6e5d-4a56-849e-ef7a599837e9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("42b25373-499b-4af7-99b9-598b25de3e1f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("ab47d2bb-1e60-4205-a6d9-f7e1a70faeae"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("4a1e8bdc-21ed-4085-8eb3-ac0c5721a762"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("15668f08-301c-41db-8866-4d23af3ad617"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("a734b631-679f-42f8-9db1-a38bd8e9a478"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("9b71a831-cf75-4357-9226-64745bee85c1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("e8b718d2-eb72-4fe2-9abf-3e37f88b3d20"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("8c3ec4c5-fb2b-46cb-989f-0a7ac6db689c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("48a6f4f2-bda6-4973-b08b-6468c24ff7dd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("70c0b060-99db-44eb-b8ce-1aea95058498"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
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
				UId = new Guid("578c991f-4298-47a7-b9fd-b5c308c836e3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("de36fde8-db50-4365-9e94-4e560ac5af54"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
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
				UId = new Guid("5dad7039-25e7-418e-9e22-2d965869ad92"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
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
				UId = new Guid("2dbf2331-fe7e-442a-a391-be34890e19da"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
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
				UId = new Guid("b4698cac-18fe-4e30-890a-3b73abf06bc1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("71e17ba6-aa05-474c-bcb3-d82b5527d4b3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
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
				UId = new Guid("d4dfe0dd-c7a2-4d0d-9c99-7e74559a4181"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
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
				UId = new Guid("b9e2dae6-26a0-4ac7-8c87-8c4d7c9f08f4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageParametersParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask prepareopenpageusertask = CreatePrepareOpenPageUserTaskScriptTask();
			FlowElements.Add(prepareopenpageusertask);
			ProcessSchemaUserTask openpageusertes = CreateOpenPageUserTesUserTask();
			FlowElements.Add(openpageusertes);
			ProcessSchemaUserTask showmessageusertask = CreateShowMessageUserTaskUserTask();
			FlowElements.Add(showmessageusertask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7cc87d29-df01-4fc5-a209-8019ed9c84a7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("59161732-b188-4fe8-9ad8-f9e927064d6f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9fb66ce3-a2e5-4be5-8bf5-378a67728a6b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("97d24363-b895-4412-80e6-b6a983aa193e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a645707-9809-4c19-a5c9-e950b032249e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("d8b898e7-af8b-493a-be8e-004a7e5d6c93"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				CurveCenterPosition = new Point(589, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a645707-9809-4c19-a5c9-e950b032249e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("41b21270-fcba-4679-bc8c-5d4055d7104e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"Condition",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				CurveCenterPosition = new Point(398, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9fb66ce3-a2e5-4be5-8bf5-378a67728a6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("7c6135fa-a860-4e98-bf38-30593f6f610c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				CurveCenterPosition = new Point(392, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9fb66ce3-a2e5-4be5-8bf5-378a67728a6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("df169071-7a61-44d4-bb66-73f154b70c1c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a6947031-ffd0-453a-9f78-c8faa1adf29a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("df169071-7a61-44d4-bb66-73f154b70c1c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("59161732-b188-4fe8-9ad8-f9e927064d6f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6947031-ffd0-453a-9f78-c8faa1adf29a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("2a645707-9809-4c19-a5c9-e950b032249e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6947031-ffd0-453a-9f78-c8faa1adf29a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"End1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareOpenPageUserTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9fb66ce3-a2e5-4be5-8bf5-378a67728a6b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6947031-ffd0-453a-9f78-c8faa1adf29a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"PrepareOpenPageUserTask",
				Position = new Point(211, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,81,111,218,48,16,126,6,137,255,224,230,161,10,18,68,140,210,109,140,174,19,162,21,66,26,107,213,192,211,180,7,199,185,80,111,137,141,108,167,21,170,242,223,123,182,161,52,19,153,246,148,216,247,221,125,247,125,119,158,73,145,114,195,165,32,95,201,236,17,216,159,217,225,34,236,78,58,109,109,20,23,27,194,74,165,64,152,152,61,66,65,127,208,2,16,29,32,210,80,102,2,132,61,81,69,152,63,78,25,147,165,48,115,41,55,57,44,233,86,223,211,13,196,59,237,115,215,139,20,83,5,60,147,121,201,211,48,24,36,217,229,197,144,125,238,15,179,139,97,127,148,126,28,245,199,99,74,251,52,203,198,31,210,100,244,105,192,6,129,109,228,110,11,194,86,90,107,80,43,208,145,61,131,90,8,109,168,96,224,170,218,240,241,226,68,142,251,119,208,255,237,21,139,120,113,70,1,204,21,79,99,200,129,25,72,31,228,179,94,164,26,75,173,26,34,84,147,197,173,40,11,80,52,201,225,202,202,189,118,229,190,115,109,252,241,100,213,181,47,27,54,49,158,161,125,101,158,119,59,237,214,183,166,182,162,149,180,44,161,5,125,113,112,100,110,117,218,137,148,57,225,122,89,230,134,251,20,100,106,108,98,207,68,48,245,252,156,76,153,225,79,112,80,59,243,11,129,88,244,19,129,86,79,116,91,108,205,206,163,207,30,100,105,96,41,83,240,204,214,195,45,154,123,79,21,110,143,1,101,53,186,61,184,225,88,88,10,170,118,87,126,217,122,196,127,175,201,11,166,190,4,72,195,205,206,46,93,208,35,199,13,172,122,173,150,139,171,3,19,134,223,88,209,129,216,85,9,187,85,207,193,138,163,232,61,184,102,196,95,9,149,27,21,207,72,88,67,117,93,79,86,140,6,173,177,237,27,106,40,42,177,27,134,207,65,32,4,47,163,248,24,180,242,223,97,127,6,123,231,238,146,223,8,182,62,7,191,254,49,132,9,106,172,8,228,26,28,115,221,194,104,154,226,19,242,254,32,24,37,53,15,233,157,62,251,156,42,43,239,212,251,168,13,168,78,231,44,81,96,74,37,176,223,18,38,175,33,15,239,82,60,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenPageUserTesUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("867769ac-4e18-4564-84e8-e759043f0438"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6947031-ffd0-453a-9f78-c8faa1adf29a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"OpenPageUserTes",
				Position = new Point(428, 170),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeOpenPageUserTesParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6947031-ffd0-453a-9f78-c8faa1adf29a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"),
				Name = @"ShowMessageUserTask",
				Position = new Point(428, 303),
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
				UId = new Guid("cd9c6b3c-63b9-4bda-bd86-91dee885c5a5"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ShowAddressOnMapProcess(userConnection);
		}

		public override object Clone() {
			return new ShowAddressOnMapProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d"));
		}

		#endregion

	}

	#endregion

	#region Class: ShowAddressOnMapProcess

	/// <exclude/>
	public class ShowAddressOnMapProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ShowAddressOnMapProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: OpenPageUserTesFlowElement

		/// <exclude/>
		public class OpenPageUserTesFlowElement : OpenPageUserTask
		{

			#region Constructors: Public

			public OpenPageUserTesFlowElement(UserConnection userConnection, ShowAddressOnMapProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenPageUserTes";
				IsLogging = true;
				SchemaElementUId = new Guid("867769ac-4e18-4564-84e8-e759043f0438");
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

			public ShowMessageUserTaskFlowElement(UserConnection userConnection, ShowAddressOnMapProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowMessageUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("6afc8c44-a39d-4cea-a9d8-d27505b66679");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

		}

		#endregion

		public ShowAddressOnMapProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ShowAddressOnMapProcess";
			SchemaUId = new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("abfbf7ee-e499-45e9-9d22-b9e91a46683d");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ShowAddressOnMapProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ShowAddressOnMapProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual bool Condition {
			get;
			set;
		}

		public virtual string SchemaName {
			get;
			set;
		}

		public virtual bool RouteMode {
			get;
			set;
		}

		public virtual Object TreeGridSelectedRowsIds {
			get;
			set;
		}

		private LocalizableString _notSelectedRecordMessage;
		public virtual LocalizableString NotSelectedRecordMessage {
			get {
				return _notSelectedRecordMessage ?? (_notSelectedRecordMessage = GetLocalizableString("abfbf7eee49945e99d22b9e91a46683d",
						 "Parameters.NotSelectedRecordMessage.Value"));
			}
			set {
				_notSelectedRecordMessage = value;
			}
		}

		private LocalizableString _adressNotExitsMesssage;
		public virtual LocalizableString AdressNotExitsMesssage {
			get {
				return _adressNotExitsMesssage ?? (_adressNotExitsMesssage = GetLocalizableString("abfbf7eee49945e99d22b9e91a46683d",
						 "Parameters.AdressNotExitsMesssage.Value"));
			}
			set {
				_adressNotExitsMesssage = value;
			}
		}

		private LocalizableString _routeConditionMessage;
		public virtual LocalizableString RouteConditionMessage {
			get {
				return _routeConditionMessage ?? (_routeConditionMessage = GetLocalizableString("abfbf7eee49945e99d22b9e91a46683d",
						 "Parameters.RouteConditionMessage.Value"));
			}
			set {
				_routeConditionMessage = value;
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
					SchemaElementUId = new Guid("59161732-b188-4fe8-9ad8-f9e927064d6f"),
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
					SchemaElementUId = new Guid("2a645707-9809-4c19-a5c9-e950b032249e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _prepareOpenPageUserTask;
		public ProcessScriptTask PrepareOpenPageUserTask {
			get {
				return _prepareOpenPageUserTask ?? (_prepareOpenPageUserTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareOpenPageUserTask",
					SchemaElementUId = new Guid("9fb66ce3-a2e5-4be5-8bf5-378a67728a6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = PrepareOpenPageUserTaskExecute,
				});
			}
		}

		private OpenPageUserTesFlowElement _openPageUserTes;
		public OpenPageUserTesFlowElement OpenPageUserTes {
			get {
				return _openPageUserTes ?? (_openPageUserTes = new OpenPageUserTesFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ShowMessageUserTaskFlowElement _showMessageUserTask;
		public ShowMessageUserTaskFlowElement ShowMessageUserTask {
			get {
				return _showMessageUserTask ?? (_showMessageUserTask = new ShowMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("41b21270-fcba-4679-bc8c-5d4055d7104e"),
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
			FlowElements[PrepareOpenPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareOpenPageUserTask };
			FlowElements[OpenPageUserTes.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenPageUserTes };
			FlowElements[ShowMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PrepareOpenPageUserTask", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "PrepareOpenPageUserTask":
						if (ConditionalFlow1ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ShowMessageUserTask", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenPageUserTes", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "PrepareOpenPageUserTask");
						break;
					case "OpenPageUserTes":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "ShowMessageUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(Condition);
			Log.InfoFormat(ConditionalExpressionLogMessage, "PrepareOpenPageUserTask", "ConditionalFlow1", "Condition", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("Condition")) {
				writer.WriteValue("Condition", Condition, false);
			}
			if (!HasMapping("SchemaName")) {
				writer.WriteValue("SchemaName", SchemaName, null);
			}
			if (!HasMapping("RouteMode")) {
				writer.WriteValue("RouteMode", RouteMode, false);
			}
			if (TreeGridSelectedRowsIds != null) {
				if (TreeGridSelectedRowsIds.GetType().IsSerializable ||
					TreeGridSelectedRowsIds.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("TreeGridSelectedRowsIds", TreeGridSelectedRowsIds, null);
				}
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
			MetaPathParameterValues.Add("886d5f2f-b6e6-4b62-8959-ecba1b049eb7", () => PageInstanceId);
			MetaPathParameterValues.Add("d6a48244-98e4-4d58-9e1d-170bf5aa4fb2", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("127f0a06-9503-424d-817a-049785eed539", () => Condition);
			MetaPathParameterValues.Add("10dba2e7-c982-4088-8a2b-6efe103a72ab", () => SchemaName);
			MetaPathParameterValues.Add("4d62a7de-12af-4c26-98e3-1caa711ec265", () => RouteMode);
			MetaPathParameterValues.Add("0ccda9d4-c906-4ad0-988f-60939060e266", () => TreeGridSelectedRowsIds);
			MetaPathParameterValues.Add("3b1f3831-261b-472e-884d-8975218f6b1d", () => NotSelectedRecordMessage);
			MetaPathParameterValues.Add("ff2fc526-a15e-45db-a96f-dc7932a8c595", () => AdressNotExitsMesssage);
			MetaPathParameterValues.Add("7b132ca7-301b-409d-90dd-cd3fc7030348", () => RouteConditionMessage);
			MetaPathParameterValues.Add("5c251de6-be68-473c-b19b-ccae6fc24c09", () => OpenPageUserTes.PageUId);
			MetaPathParameterValues.Add("334f9a34-6e5d-4a56-849e-ef7a599837e9", () => OpenPageUserTes.PageUrl);
			MetaPathParameterValues.Add("42b25373-499b-4af7-99b9-598b25de3e1f", () => OpenPageUserTes.OpenerInstanceId);
			MetaPathParameterValues.Add("ab47d2bb-1e60-4205-a6d9-f7e1a70faeae", () => OpenPageUserTes.CloseOpenerOnLoad);
			MetaPathParameterValues.Add("4a1e8bdc-21ed-4085-8eb3-ac0c5721a762", () => OpenPageUserTes.PageParameters);
			MetaPathParameterValues.Add("15668f08-301c-41db-8866-4d23af3ad617", () => OpenPageUserTes.Width);
			MetaPathParameterValues.Add("a734b631-679f-42f8-9db1-a38bd8e9a478", () => OpenPageUserTes.CloseMessage);
			MetaPathParameterValues.Add("9b71a831-cf75-4357-9226-64745bee85c1", () => OpenPageUserTes.Height);
			MetaPathParameterValues.Add("e8b718d2-eb72-4fe2-9abf-3e37f88b3d20", () => OpenPageUserTes.Centered);
			MetaPathParameterValues.Add("8c3ec4c5-fb2b-46cb-989f-0a7ac6db689c", () => OpenPageUserTes.UseOpenerRegisterScript);
			MetaPathParameterValues.Add("48a6f4f2-bda6-4973-b08b-6468c24ff7dd", () => OpenPageUserTes.UseCurrentActivePage);
			MetaPathParameterValues.Add("70c0b060-99db-44eb-b8ce-1aea95058498", () => OpenPageUserTes.IgnoreProfile);
			MetaPathParameterValues.Add("578c991f-4298-47a7-b9fd-b5c308c836e3", () => ShowMessageUserTask.Page);
			MetaPathParameterValues.Add("de36fde8-db50-4365-9e94-4e560ac5af54", () => ShowMessageUserTask.Icon);
			MetaPathParameterValues.Add("5dad7039-25e7-418e-9e22-2d965869ad92", () => ShowMessageUserTask.Buttons);
			MetaPathParameterValues.Add("2dbf2331-fe7e-442a-a391-be34890e19da", () => ShowMessageUserTask.WindowCaption);
			MetaPathParameterValues.Add("b4698cac-18fe-4e30-890a-3b73abf06bc1", () => ShowMessageUserTask.MessageText);
			MetaPathParameterValues.Add("71e17ba6-aa05-474c-bcb3-d82b5527d4b3", () => ShowMessageUserTask.ResponseMessages);
			MetaPathParameterValues.Add("d4dfe0dd-c7a2-4d0d-9c99-7e74559a4181", () => ShowMessageUserTask.ProcessInstanceId);
			MetaPathParameterValues.Add("b9e2dae6-26a0-4ac7-8c87-8c4d7c9f08f4", () => ShowMessageUserTask.PageParameters);
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
				case "Condition":
					if (!hasValueToRead) break;
					Condition = reader.GetValue<System.Boolean>();
				break;
				case "SchemaName":
					if (!hasValueToRead) break;
					SchemaName = reader.GetValue<System.String>();
				break;
				case "RouteMode":
					if (!hasValueToRead) break;
					RouteMode = reader.GetValue<System.Boolean>();
				break;
				case "TreeGridSelectedRowsIds":
					if (!hasValueToRead) break;
					TreeGridSelectedRowsIds = reader.GetSerializableObjectValue();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool PrepareOpenPageUserTaskExecute(ProcessExecutingContext context) {
			Condition = CheckCondition();
			string currentSchemaName = "Contact";
			var contactAccountGoogleMapsPageSysSchemaUId = new Guid("0bf532c8-2f32-4d64-99aa-aff91db470c0");
			OpenPageUserTes.OpenerInstanceId = PageInstanceId;
			OpenPageUserTes.PageUId = contactAccountGoogleMapsPageSysSchemaUId;
			
			var treeGridSelectedRowsIds = TreeGridSelectedRowsIds as IEnumerable<Guid>;
			
			List<Guid> treeGridSelectedRowsUIds = (treeGridSelectedRowsIds != null)
				? treeGridSelectedRowsIds.ToList()
				: null;
				
			bool isMultiSelect = treeGridSelectedRowsUIds != null 
				&& ActiveTreeGridCurrentRowId != Guid.Empty
				&& !RouteMode;
				
			var pageParameters =  new Dictionary<string, string> {
				{"entityName", SchemaName},		
				{"routeMode", RouteMode.ToString()},
				{"multiSelectMode", isMultiSelect.ToString()},
			};
			
			if (isMultiSelect) {
				var sessionData = UserConnection.SessionData;
				sessionData["CurrentObjectUIds"] = treeGridSelectedRowsUIds;	
			} else {
				pageParameters.Add("entityUId", ActiveTreeGridCurrentRowId.ToString());
			}
			
			OpenPageUserTes.PageParameters = pageParameters;
			
			return true;
		}

			
			public virtual bool CheckCondition() {
				//TODO: Проверить логику метода после добавления параметра TreeGridSelectedRowsIds
				
				bool result = false;
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var entitySchema = entitySchemaManager.GetInstanceByName(SchemaName);
				var schemaCaption = entitySchema.Caption;
				ShowMessageUserTask.Icon = "WARNING";
				ShowMessageUserTask.Buttons = "OK";
				
				if (ActiveTreeGridCurrentRowId == Guid.Empty) {
					ShowMessageUserTask.MessageText = string.Format(NotSelectedRecordMessage, schemaCaption.Value.ToLower());
					return true;
				}
				
				var adressSchema = UserConnection.EntitySchemaManager.GetInstanceByName(string.Format("{0}Address", SchemaName));
				var hasCurrentObjectAddress = false;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, adressSchema.Name);
				var countryColumn = entitySchemaQuery.AddColumn("Country");
				var regionColumn = entitySchemaQuery.AddColumn("Region");
				var cityColumn = entitySchemaQuery.AddColumn("City");
				var addressColumn = entitySchemaQuery.AddColumn("Address");
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					SchemaName, ActiveTreeGridCurrentRowId));
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"Primary", true));
				var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
				foreach (var entity in entityCollection) {
					if (entity.GetTypedColumnValue<Guid>(countryColumn.ValueQueryAlias) != Guid.Empty
						|| entity.GetTypedColumnValue<Guid>(regionColumn.ValueQueryAlias) != Guid.Empty
						|| entity.GetTypedColumnValue<Guid>(cityColumn.ValueQueryAlias) != Guid.Empty
						|| !string.IsNullOrEmpty(entity.GetTypedColumnValue<string>(addressColumn.Name))) {
							hasCurrentObjectAddress = true;
							break;
						}
				}
				
				if (RouteMode) {
					var hasMyContactAddress = false;
					var hasMyCompanyAddress = false;
					var currentUser = UserConnection.CurrentUser;
					var myContactUId = currentUser.ContactId;
					var myCompanyUId = Guid.Empty;
					var contact = new Terrasoft.Configuration.Contact(UserConnection);
					var contactAddress = new Terrasoft.Configuration.ContactAddress(UserConnection);
					var accountAddress = new Terrasoft.Configuration.AccountAddress(UserConnection);
					hasMyContactAddress = contactAddress.ExistInDB("Contact", myContactUId);
					var contactSchema = entitySchemaManager.GetInstanceByName("Contact");
					var contactSchemaPrimaryColumnName = contactSchema.GetPrimaryColumnName();
					var contactSchemaPrimaryColumn = contactSchema.Columns.GetByName(contactSchemaPrimaryColumnName);
					var columnsToFetch = new EntitySchemaColumn[] {
						contactSchema.Columns.GetByName("Account")
					};
					if (contact.FetchFromDB(contactSchemaPrimaryColumn, myContactUId, columnsToFetch)) {
						myCompanyUId = contact.AccountId;	
						hasMyCompanyAddress = accountAddress.ExistInDB("Account", myCompanyUId);
					}
					result = !((hasMyContactAddress || hasMyCompanyAddress) && hasCurrentObjectAddress);
					ShowMessageUserTask.MessageText = string.Format(RouteConditionMessage, schemaCaption.Value.ToLower());
				} else {
					result = !hasCurrentObjectAddress;
					ShowMessageUserTask.MessageText = string.Format(AdressNotExitsMesssage, schemaCaption.Value.ToLower());
				}
				return result;
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
			var cloneItem = (ShowAddressOnMapProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.TreeGridSelectedRowsIds = TreeGridSelectedRowsIds;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

