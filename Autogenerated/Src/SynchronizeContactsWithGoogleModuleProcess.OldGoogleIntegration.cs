namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
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

	#region Class: SynchronizeContactsWithGoogleModuleProcessSchema

	/// <exclude/>
	public class SynchronizeContactsWithGoogleModuleProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SynchronizeContactsWithGoogleModuleProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SynchronizeContactsWithGoogleModuleProcessSchema(SynchronizeContactsWithGoogleModuleProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SynchronizeContactsWithGoogleModuleProcess";
			UId = new Guid("41d591ae-2142-4656-b961-78ce601efb12");
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12");
			Version = 0;
			PackageUId = new Guid("8d48ade0-350e-7694-49aa-2a913c356ce1");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridClientIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9347c356-5a7f-4d63-8cf4-35dce3f40c70"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"ActiveTreeGridClientId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGotoExitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40af7848-4cd2-4e02-9e01-b7e9a916a162"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"GotoExit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9f0492f-ce0f-4c60-a69b-b0001d125269"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"SyncResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFillSettingsLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f4f699d1-8aea-4333-8cb0-404a75b70750"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"FillSettingsLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateActiveTreeGridClientIdParameter());
			Parameters.Add(CreateGotoExitParameter());
			Parameters.Add(CreateSyncResultParameter());
			Parameters.Add(CreateFillSettingsLSParameter());
		}

		protected virtual void InitializeAuthProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageInstanceIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fb1595a2-1c2d-4b13-b782-fd833185cc1a"),
				ContainerUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pageInstanceIdParameter.SourceValue = new ProcessSchemaParameterValue(pageInstanceIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageInstanceIdParameter);
			var activeTreeGridCurrentRowIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1eaa97e3-0a32-49f9-a8e8-9e29ddfa0f5f"),
				ContainerUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activeTreeGridCurrentRowIdParameter.SourceValue = new ProcessSchemaParameterValue(activeTreeGridCurrentRowIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activeTreeGridCurrentRowIdParameter);
			var userTokenParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("45400c79-9351-4161-a4da-a6c003f713d0"),
				ContainerUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"UserToken",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			userTokenParameter.SourceValue = new ProcessSchemaParameterValue(userTokenParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(userTokenParameter);
			var activeTreeGridClientIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5c1f13ea-2d02-4bef-b8dc-ca2361a70b22"),
				ContainerUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"ActiveTreeGridClientId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			activeTreeGridClientIdParameter.SourceValue = new ProcessSchemaParameterValue(activeTreeGridClientIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activeTreeGridClientIdParameter);
			var integrationProcessIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dfe42142-c7ed-4bc2-a4d9-9d2880381168"),
				ContainerUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"IntegrationProcessId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			integrationProcessIdParameter.SourceValue = new ProcessSchemaParameterValue(integrationProcessIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(integrationProcessIdParameter);
			var syncProcessResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5373144e-a462-4d5e-84a9-67acfdce56e2"),
				ContainerUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"SyncProcessResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			syncProcessResultParameter.SourceValue = new ProcessSchemaParameterValue(syncProcessResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58")
			};
			parametrizedElement.Parameters.Add(syncProcessResultParameter);
			var synchronizationAuthenticationErrorMessageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("095fa698-bcc8-4496-92a1-2a81ab277263"),
				ContainerUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("74528743-3768-4ea1-98c1-af5d8111ed6d"),
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"SynchronizationAuthenticationErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			synchronizationAuthenticationErrorMessageParameter.SourceValue = new ProcessSchemaParameterValue(synchronizationAuthenticationErrorMessageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58")
			};
			parametrizedElement.Parameters.Add(synchronizationAuthenticationErrorMessageParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess authprocess = CreateAuthProcessSubProcess();
			FlowElements.Add(authprocess);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask scriptprepare = CreateScriptPrepareScriptTask();
			FlowElements.Add(scriptprepare);
			ProcessSchemaScriptTask getsyncresultscripttask = CreateGetSyncResultScriptTaskScriptTask();
			FlowElements.Add(getsyncresultscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e4b8597f-eb75-4cc1-9ae6-2e2899f4206e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9032e5dc-6a31-4b40-8813-8c24a8f4ffdb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6208cc26-dcfb-4797-abfa-f8b6b227263d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("e8be56f7-d183-490d-8e46-a2a5e1cc00ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df5b9da9-1d40-45f3-8513-899f3d0dad92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("0612dba8-f35e-481d-a52c-90c84d14e834"),
				ConditionExpression = @"!GotoExit",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				CurveCenterPosition = new Point(307, 178),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6208cc26-dcfb-4797-abfa-f8b6b227263d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("daba3bea-ed45-46d5-b3f6-e279d1c92c98"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df5b9da9-1d40-45f3-8513-899f3d0dad92"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2266ac83-9531-45cb-b465-664b7c49e017"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8a41ced4-e4cd-42b4-8c47-76f16143a56d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b981d075-2d4a-4f06-985e-e468946cff24"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8a41ced4-e4cd-42b4-8c47-76f16143a56d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("9032e5dc-6a31-4b40-8813-8c24a8f4ffdb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b981d075-2d4a-4f06-985e-e468946cff24"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
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
				UId = new Guid("2266ac83-9531-45cb-b465-664b7c49e017"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b981d075-2d4a-4f06-985e-e468946cff24"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"End1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6208cc26-dcfb-4797-abfa-f8b6b227263d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b981d075-2d4a-4f06-985e-e468946cff24"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"ScriptPrepare",
				Position = new Point(141, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,91,79,219,48,20,126,6,137,255,224,249,201,65,75,214,150,22,170,85,60,148,82,162,72,27,66,180,140,23,94,140,125,82,34,82,187,243,133,181,2,254,251,142,147,116,41,23,77,202,197,231,242,157,235,231,39,110,200,68,43,199,133,75,141,246,171,76,146,83,146,250,66,38,211,229,202,109,70,7,251,206,108,200,243,193,254,222,7,47,22,220,34,54,7,99,184,213,185,75,38,218,0,126,84,94,44,188,225,174,208,42,153,109,236,12,156,43,212,194,38,41,184,95,188,244,192,110,44,24,116,83,32,130,207,87,66,83,173,23,37,236,38,160,81,132,169,95,137,224,78,60,176,204,193,242,82,187,11,237,149,156,174,5,172,2,142,192,246,20,133,250,94,15,246,159,176,23,225,141,1,229,66,138,170,200,183,185,146,73,107,78,50,57,170,49,22,74,52,163,179,130,63,100,86,9,239,106,140,146,106,0,165,95,42,70,51,73,223,200,99,33,192,218,185,126,4,85,27,46,140,94,50,58,211,162,224,37,26,177,106,87,27,110,31,192,0,163,117,113,168,202,236,244,183,231,37,171,35,37,87,220,240,37,56,48,236,77,23,81,133,29,43,201,232,124,179,130,255,35,67,11,97,47,140,66,14,3,121,194,123,241,32,63,26,198,208,237,118,227,225,160,11,113,167,211,29,12,100,167,47,58,93,140,20,69,132,219,166,105,28,135,183,184,42,194,206,207,166,107,16,222,105,67,228,253,191,227,135,105,78,149,245,6,206,207,90,21,195,120,129,44,77,156,236,156,59,126,13,92,2,6,106,143,167,205,200,147,58,52,212,106,214,166,106,162,236,21,57,97,95,90,96,18,126,44,34,47,47,31,56,187,75,218,6,188,151,106,167,167,235,34,108,214,25,15,163,74,57,219,40,113,13,214,151,65,77,159,239,168,109,248,137,4,67,170,222,209,239,149,243,43,173,221,191,29,254,196,229,242,5,132,214,231,220,62,38,87,70,135,125,103,202,58,174,4,174,3,227,108,133,155,138,83,8,123,15,106,228,57,172,67,218,139,162,44,183,215,226,199,236,115,68,38,144,226,88,225,237,248,250,50,187,76,233,232,240,91,229,103,192,121,163,218,134,144,247,225,197,103,167,221,156,151,54,152,199,222,61,52,245,38,99,92,208,19,204,13,64,106,10,57,41,11,36,88,85,252,231,134,119,232,76,57,88,212,151,122,59,128,128,109,233,214,131,62,135,14,207,227,222,253,144,199,253,254,113,30,223,203,193,48,62,225,199,199,112,52,236,15,37,244,104,184,212,187,13,252,5,186,215,229,185,126,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateAuthProcessSubProcess() {
			ProcessSchemaSubProcess schemaAuthProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b981d075-2d4a-4f06-985e-e468946cff24"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"AuthProcess",
				Position = new Point(337, 170),
				SchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeAuthProcessParameters(schemaAuthProcess);
			return schemaAuthProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateGetSyncResultScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("df5b9da9-1d40-45f3-8513-899f3d0dad92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b981d075-2d4a-4f06-985e-e468946cff24"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12"),
				Name = @"GetSyncResultScriptTask",
				Position = new Point(470, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,11,174,204,75,14,74,45,46,205,41,81,176,85,112,44,45,201,8,40,202,79,78,45,46,214,11,6,74,64,217,16,121,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,203,226,29,171,57,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("638e2f11-dfd9-4ca5-98d5-306a6803e11c"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SynchronizeContactsWithGoogleModuleProcess(userConnection);
		}

		public override object Clone() {
			return new SynchronizeContactsWithGoogleModuleProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("41d591ae-2142-4656-b961-78ce601efb12"));
		}

		#endregion

	}

	#endregion

	#region Class: SynchronizeContactsWithGoogleModuleProcess

	/// <exclude/>
	public class SynchronizeContactsWithGoogleModuleProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SynchronizeContactsWithGoogleModuleProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: AuthProcessFlowElement

		/// <exclude/>
		public class AuthProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public AuthProcessFlowElement(UserConnection userConnection, SynchronizeContactsWithGoogleModuleProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58");
			}

			#endregion

			#region Properties: Public

			public string PageInstanceId {
				get {
					return GetParameterValue<string>("PageInstanceId");
				}
				set {
					SetParameterValue("PageInstanceId", value);
				}
			}

			public Guid ActiveTreeGridCurrentRowId {
				get {
					return GetParameterValue<Guid>("ActiveTreeGridCurrentRowId");
				}
				set {
					SetParameterValue("ActiveTreeGridCurrentRowId", value);
				}
			}

			public Object UserToken {
				get {
					return GetParameterValue<Object>("UserToken");
				}
				set {
					SetParameterValue("UserToken", value);
				}
			}

			public string ActiveTreeGridClientId {
				get {
					return GetParameterValue<string>("ActiveTreeGridClientId");
				}
				set {
					SetParameterValue("ActiveTreeGridClientId", value);
				}
			}

			public Guid IntegrationProcessId {
				get {
					return GetParameterValue<Guid>("IntegrationProcessId");
				}
				set {
					SetParameterValue("IntegrationProcessId", value);
				}
			}

			public string SyncProcessResult {
				get {
					return GetParameterValue<string>("SyncProcessResult");
				}
				set {
					SetParameterValue("SyncProcessResult", value);
				}
			}

			public LocalizableString SynchronizationAuthenticationErrorMessage {
				get {
					return GetParameterValue<LocalizableString>("SynchronizationAuthenticationErrorMessage");
				}
				set {
					SetParameterValue("SynchronizationAuthenticationErrorMessage", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (SynchronizeContactsWithGoogleModuleProcess)owner;
				Name = "AuthProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("d8bd8424-9b94-482f-9040-b83f89fd4a96");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (SynchronizeContactsWithGoogleModuleProcess)Owner;
			}

			#endregion

		}

		#endregion

		public SynchronizeContactsWithGoogleModuleProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SynchronizeContactsWithGoogleModuleProcess";
			SchemaUId = new Guid("41d591ae-2142-4656-b961-78ce601efb12");
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
				return new Guid("41d591ae-2142-4656-b961-78ce601efb12");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SynchronizeContactsWithGoogleModuleProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SynchronizeContactsWithGoogleModuleProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string ActiveTreeGridClientId {
			get;
			set;
		}

		public virtual bool GotoExit {
			get;
			set;
		}

		public virtual string SyncResult {
			get;
			set;
		}

		private LocalizableString _fillSettingsLS;
		public virtual LocalizableString FillSettingsLS {
			get {
				return _fillSettingsLS ?? (_fillSettingsLS = GetLocalizableString("41d591ae21424656b96178ce601efb12",
						 "Parameters.FillSettingsLS.Value"));
			}
			set {
				_fillSettingsLS = value;
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
					SchemaElementUId = new Guid("9032e5dc-6a31-4b40-8813-8c24a8f4ffdb"),
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
					SchemaElementUId = new Guid("2266ac83-9531-45cb-b465-664b7c49e017"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptPrepare;
		public ProcessScriptTask ScriptPrepare {
			get {
				return _scriptPrepare ?? (_scriptPrepare = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepare",
					SchemaElementUId = new Guid("6208cc26-dcfb-4797-abfa-f8b6b227263d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptPrepareExecute,
				});
			}
		}

		private AuthProcessFlowElement _authProcess;
		public AuthProcessFlowElement AuthProcess {
			get {
				return _authProcess ?? ((_authProcess) = new AuthProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _getSyncResultScriptTask;
		public ProcessScriptTask GetSyncResultScriptTask {
			get {
				return _getSyncResultScriptTask ?? (_getSyncResultScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetSyncResultScriptTask",
					SchemaElementUId = new Guid("df5b9da9-1d40-45f3-8513-899f3d0dad92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = GetSyncResultScriptTaskExecute,
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
					SchemaElementUId = new Guid("0612dba8-f35e-481d-a52c-90c84d14e834"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _scriptPrepareAuthProcessToken;
		public ProcessToken ScriptPrepareAuthProcessToken {
			get {
				return _scriptPrepareAuthProcessToken ?? (_scriptPrepareAuthProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ScriptPrepareAuthProcessToken",
					SchemaElementUId = new Guid("5a9ffb01-f21c-48dd-9e72-a013be38c8ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[ScriptPrepare.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepare };
			FlowElements[AuthProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AuthProcess };
			FlowElements[GetSyncResultScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetSyncResultScriptTask };
			FlowElements[ScriptPrepareAuthProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareAuthProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptPrepare", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "ScriptPrepare":
						if (ConditionalFlow2ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptPrepareAuthProcessToken", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ScriptPrepare");
						break;
					case "AuthProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GetSyncResultScriptTask", e.Context.SenderName));
						break;
					case "GetSyncResultScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "ScriptPrepareAuthProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AuthProcess", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(!GotoExit);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ScriptPrepare", "ConditionalFlow2", "!GotoExit", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ActiveTreeGridClientId")) {
				writer.WriteValue("ActiveTreeGridClientId", ActiveTreeGridClientId, null);
			}
			if (!HasMapping("GotoExit")) {
				writer.WriteValue("GotoExit", GotoExit, false);
			}
			if (!HasMapping("SyncResult")) {
				writer.WriteValue("SyncResult", SyncResult, null);
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
			MetaPathParameterValues.Add("9347c356-5a7f-4d63-8cf4-35dce3f40c70", () => ActiveTreeGridClientId);
			MetaPathParameterValues.Add("40af7848-4cd2-4e02-9e01-b7e9a916a162", () => GotoExit);
			MetaPathParameterValues.Add("d9f0492f-ce0f-4c60-a69b-b0001d125269", () => SyncResult);
			MetaPathParameterValues.Add("f4f699d1-8aea-4333-8cb0-404a75b70750", () => FillSettingsLS);
			MetaPathParameterValues.Add("fb1595a2-1c2d-4b13-b782-fd833185cc1a", () => AuthProcess.PageInstanceId);
			MetaPathParameterValues.Add("1eaa97e3-0a32-49f9-a8e8-9e29ddfa0f5f", () => AuthProcess.ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("45400c79-9351-4161-a4da-a6c003f713d0", () => AuthProcess.UserToken);
			MetaPathParameterValues.Add("5c1f13ea-2d02-4bef-b8dc-ca2361a70b22", () => AuthProcess.ActiveTreeGridClientId);
			MetaPathParameterValues.Add("dfe42142-c7ed-4bc2-a4d9-9d2880381168", () => AuthProcess.IntegrationProcessId);
			MetaPathParameterValues.Add("5373144e-a462-4d5e-84a9-67acfdce56e2", () => AuthProcess.SyncProcessResult);
			MetaPathParameterValues.Add("095fa698-bcc8-4496-92a1-2a81ab277263", () => AuthProcess.SynchronizationAuthenticationErrorMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ActiveTreeGridClientId":
					if (!hasValueToRead) break;
					ActiveTreeGridClientId = reader.GetValue<System.String>();
				break;
				case "GotoExit":
					if (!hasValueToRead) break;
					GotoExit = reader.GetValue<System.Boolean>();
				break;
				case "SyncResult":
					if (!hasValueToRead) break;
					SyncResult = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptPrepareExecute(ProcessExecutingContext context) {
			var ContactGroupId = Guid.Empty;
			try {
				ContactGroupId = (Guid)(Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "GoogleContactGroup"));
			} catch(ItemNotFoundException exception) {
			}
			var currentUserId = UserConnection.CurrentUser.Id;
			var select = new Select(UserConnection).
				Column("Id").
				Column("AccessToken").
				From("SocialAccount").
				Where("UserId").IsEqual(Column.Parameter(currentUserId)).
				And("TypeId").IsEqual(Column.Parameter(new Guid("efe5d7a2-5f38-e111-851e-00155d04c01d"))) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					if (!dataReader.Read() || ContactGroupId == Guid.Empty) {
						GotoExit = true;
						SyncResult = "{\"settingsNotSet\": true}";
						/*MessageUserTask.ProcessInstanceId = InstanceUId;
						MessageUserTask.MessageText = FillSettingsLS;
						MessageUserTask.Icon = "WARNING";*/
						return true;
					}
				}
			}
			GotoExit = false;
			AuthProcess.ActiveTreeGridClientId = ActiveTreeGridClientId;
			AuthProcess.IntegrationProcessId = new Guid("2e4ae0af-2b8a-446f-bd58-7a66e3848de2");
			return true;
		}

		public virtual bool GetSyncResultScriptTaskExecute(ProcessExecutingContext context) {
			SyncResult = AuthProcess.SyncProcessResult;
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
			var cloneItem = (SynchronizeContactsWithGoogleModuleProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

