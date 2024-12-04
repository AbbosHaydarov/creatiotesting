namespace Terrasoft.Core.Process
{

	using global::Common.Logging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: GenerateAnniversaryRemindingsSchema

	/// <exclude/>
	public class GenerateAnniversaryRemindingsSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public GenerateAnniversaryRemindingsSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public GenerateAnniversaryRemindingsSchema(GenerateAnniversaryRemindingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "GenerateAnniversaryRemindings";
			UId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
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
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			Version = 0;
			PackageUId = new Guid("06d9ef10-51d8-122c-8933-9212e84236c9");
			UseSystemSecurityContext = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
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
			ProcessSchemaScriptTask generatereminding = CreateGenerateRemindingScriptTask();
			FlowElements.Add(generatereminding);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fa41dea9-7551-47ab-9e2c-1763bd583484"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("528e9bac-1ed2-4e52-8225-6cb1c5f70e0e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("3d5af550-2a17-4078-8ba4-35edf569ca6f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("621e8ff4-222d-4239-a838-9104b30d406d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("22f42928-141f-4715-8685-d8996ebbbd4f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("22f42928-141f-4715-8685-d8996ebbbd4f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("528e9bac-1ed2-4e52-8225-6cb1c5f70e0e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("621e8ff4-222d-4239-a838-9104b30d406d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"Terminate1",
				Position = new Point(353, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateGenerateRemindingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"GenerateReminding",
				Position = new Point(171, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,83,203,110,27,49,12,60,107,191,66,241,73,6,140,253,1,63,128,198,112,131,5,154,180,168,157,230,16,244,32,175,185,107,53,107,201,144,184,78,140,192,255,94,82,242,99,109,228,38,137,156,225,112,72,5,244,198,214,178,13,240,0,22,188,70,227,236,28,189,28,103,98,190,15,115,64,164,112,200,31,0,255,232,166,133,81,136,249,19,85,58,139,240,129,249,115,0,63,117,214,66,201,200,129,236,61,159,153,224,155,181,102,7,62,104,191,255,13,27,99,87,76,213,163,28,244,45,244,250,195,108,167,253,117,101,57,150,68,70,24,204,23,238,222,185,6,180,85,183,218,8,104,42,169,238,174,222,251,242,51,19,30,176,245,86,50,253,48,59,68,250,178,209,33,60,233,13,16,117,111,1,222,235,224,42,204,169,74,101,234,54,97,243,123,29,190,20,219,75,18,55,128,107,183,58,145,156,187,43,177,213,77,167,177,148,140,251,45,252,242,110,103,86,64,46,202,41,215,255,174,75,116,126,207,46,142,138,23,231,223,194,86,151,176,232,100,78,20,117,197,15,73,112,60,141,175,184,24,204,207,234,220,17,33,138,153,109,55,164,102,217,192,136,131,19,105,236,26,188,193,112,131,206,196,9,31,84,159,46,47,148,5,138,51,228,120,18,51,243,34,204,219,101,36,255,89,165,34,156,222,63,142,73,251,154,57,45,188,75,183,252,71,211,126,253,43,63,191,94,130,195,48,155,125,148,176,141,3,37,30,188,220,136,160,109,154,97,86,57,15,186,92,75,21,27,141,50,140,61,107,143,179,76,85,232,45,160,182,37,187,65,134,155,157,38,35,243,41,161,17,138,99,40,182,49,136,10,73,172,120,140,211,42,108,229,142,131,139,199,100,7,155,144,226,234,50,212,1,119,197,237,112,134,171,212,146,246,174,127,96,42,94,179,46,71,146,31,229,137,146,122,55,150,23,77,28,50,129,126,31,95,47,217,121,97,119,238,13,212,169,129,88,165,227,93,165,155,0,177,10,193,75,141,236,198,197,40,72,69,216,249,198,213,164,254,135,171,31,181,213,117,90,4,186,209,73,245,158,28,154,202,16,154,48,129,127,148,16,148,158,207,188,119,94,241,130,208,253,102,0,73,240,33,126,161,235,216,93,167,61,92,123,247,126,61,60,250,81,66,136,172,251,199,254,3,25,162,249,59,61,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb29449b-948a-42d8-9ce4-d8a2a70cb237"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ae5cf1a1-fd3c-4e1a-a803-58809bfaee7d"),
				Name = "System.Threading.Tasks",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49c070a0-632a-4ee3-85de-d059e293c3ee"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a4f930e4-62bd-4e84-96b4-2c761af4d3d3"),
				Name = "System.Reflection",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0db02f09-1196-4f60-80e9-5e7f08e20706"),
				Name = "global::Common.Logging",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7bb09134-f66a-45bf-b8a0-743695fdcaf8"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new GenerateAnniversaryRemindings(userConnection);
		}

		public override object Clone() {
			return new GenerateAnniversaryRemindingsSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"));
		}

		#endregion

	}

	#endregion

	#region Class: GenerateAnniversaryRemindingsMethodsWrapper

	/// <exclude/>
	public class GenerateAnniversaryRemindingsMethodsWrapper : ProcessModel
	{

		public GenerateAnniversaryRemindingsMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("GenerateRemindingExecute", GenerateRemindingExecute);
		}

		#region Methods: Private

		private bool GenerateRemindingExecute(ProcessExecutingContext context) {
			string useGenerationStr =
				SysSettings.GetValue<string>(context.UserConnection, "UseGenerateAnniversaryRemindings", "true");
			var useGeneration = Convert.ToBoolean(useGenerationStr);
			if (!useGeneration) {
				return true;
			}
			var className = "Terrasoft.Configuration.BaseAnniversaryReminding";
			var methodName = "GenerateActualRemindings";
			var typeProvider = ClassFactory.Get<IWorkspaceTypeProvider>();
			Type classType = typeProvider.GetType(className);
			IEnumerable<Type> inherits = typeProvider
				.GetTypes()
				.Where(type => type.IsSubclassOf(classType));
			var args = new object[] {context.UserConnection};
			Exception lastException = null;
			foreach (Type type in inherits) {
				object instance = Activator.CreateInstance(type, args);
				MethodInfo methodInfo = type.GetMethod(methodName, new[] {typeof(bool)});
				if (methodInfo == null) {
					continue;
				}
				try {
					methodInfo.Invoke(instance, new object[] {false});
				}
				catch (Exception e) {
					var log = LogManager.GetLogger("Notifications");
					log.Error(e);
					lastException = e;
				}
			}
			if (lastException != null) {
				throw lastException;
			}			
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: GenerateAnniversaryRemindings

	/// <exclude/>
	public class GenerateAnniversaryRemindings : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, GenerateAnniversaryRemindings process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public GenerateAnniversaryRemindings(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "GenerateAnniversaryRemindings";
			SchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new GenerateAnniversaryRemindingsMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: GenerateAnniversaryRemindings, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: GenerateAnniversaryRemindings, Source element: {0}, None of the exclusive gateway conditions are met!";
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
					SchemaElementUId = new Guid("528e9bac-1ed2-4e52-8225-6cb1c5f70e0e"),
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
					SchemaElementUId = new Guid("621e8ff4-222d-4239-a838-9104b30d406d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _generateReminding;
		public ProcessScriptTask GenerateReminding {
			get {
				return _generateReminding ?? (_generateReminding = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GenerateReminding",
					SchemaElementUId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("GenerateRemindingExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[GenerateReminding.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateReminding };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GenerateReminding", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "GenerateReminding":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
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
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (GenerateAnniversaryRemindings)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

