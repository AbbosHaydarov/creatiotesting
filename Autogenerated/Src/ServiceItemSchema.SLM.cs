namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ServiceItem_SLM_TerrasoftSchema

	/// <exclude/>
	public class ServiceItem_SLM_TerrasoftSchema : Terrasoft.Configuration.ServiceItem_CrtSLMITILService_TerrasoftSchema
	{

		#region Constructors: Public

		public ServiceItem_SLM_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceItem_SLM_TerrasoftSchema(ServiceItem_SLM_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceItem_SLM_TerrasoftSchema(ServiceItem_SLM_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("dd5c3c93-0bb0-4ad6-9c54-e571e257ae40");
			Name = "ServiceItem_SLM_Terrasoft";
			ParentSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			ExtendParent = true;
			CreatedInPackageId = new Guid("133895ca-4146-4d9e-8882-c020a2cf3a4a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateCalendarColumn() {
			EntitySchemaColumn column = base.CreateCalendarColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("dd5c3c93-0bb0-4ad6-9c54-e571e257ae40");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceItem_SLM_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServiceItem_SLMEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServiceItem_SLM_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceItem_SLM_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd5c3c93-0bb0-4ad6-9c54-e571e257ae40"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem_SLM_Terrasoft

	/// <summary>
	/// Service.
	/// </summary>
	public class ServiceItem_SLM_Terrasoft : Terrasoft.Configuration.ServiceItem_CrtSLMITILService_Terrasoft
	{

		#region Constructors: Public

		public ServiceItem_SLM_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceItem_SLM_Terrasoft";
		}

		public ServiceItem_SLM_Terrasoft(ServiceItem_SLM_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceItem_SLMEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceItem_SLM_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem_SLMEventsProcess

	/// <exclude/>
	public partial class ServiceItem_SLMEventsProcess<TEntity> : Terrasoft.Configuration.ServiceItem_CrtSLMITILServiceEventsProcess<TEntity> where TEntity : ServiceItem_SLM_Terrasoft
	{

		public ServiceItem_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceItem_SLMEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dd5c3c93-0bb0-4ad6-9c54-e571e257ae40");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a;
		public ProcessFlowElement EventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a {
			get {
				return _eventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a ?? (_eventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a",
					SchemaElementUId = new Guid("7ab2fe9c-72af-4383-b363-303fdf38b98a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_58ef0eedf875411cafff701a19ae60f5;
		public ProcessFlowElement StartMessage3_58ef0eedf875411cafff701a19ae60f5 {
			get {
				return _startMessage3_58ef0eedf875411cafff701a19ae60f5 ?? (_startMessage3_58ef0eedf875411cafff701a19ae60f5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_58ef0eedf875411cafff701a19ae60f5",
					SchemaElementUId = new Guid("58ef0eed-f875-411c-afff-701a19ae60f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _serviceItemSavingScriptTask;
		public ProcessScriptTask ServiceItemSavingScriptTask {
			get {
				return _serviceItemSavingScriptTask ?? (_serviceItemSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ServiceItemSavingScriptTask",
					SchemaElementUId = new Guid("2e163015-3eb0-44c3-a399-ab10fa565abf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ServiceItemSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a };
			FlowElements[StartMessage3_58ef0eedf875411cafff701a19ae60f5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_58ef0eedf875411cafff701a19ae60f5 };
			FlowElements[ServiceItemSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ServiceItemSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a":
						break;
					case "StartMessage3_58ef0eedf875411cafff701a19ae60f5":
						e.Context.QueueTasks.Enqueue("ServiceItemSavingScriptTask");
						break;
					case "ServiceItemSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_58ef0eedf875411cafff701a19ae60f5");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_7ab2fe9c72af4383b363303fdf38b98a":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_58ef0eedf875411cafff701a19ae60f5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_58ef0eedf875411cafff701a19ae60f5";
					result = StartMessage3_58ef0eedf875411cafff701a19ae60f5.Execute(context);
					break;
				case "ServiceItemSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ServiceItemSavingScriptTask";
					result = ServiceItemSavingScriptTask.Execute(context, ServiceItemSavingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ServiceItemSavingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ServiceItemSaving":
							if (ActivatedEventElements.Contains("StartMessage3_58ef0eedf875411cafff701a19ae60f5")) {
							context.QueueTasks.Enqueue("StartMessage3_58ef0eedf875411cafff701a19ae60f5");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem_SLMEventsProcess

	/// <exclude/>
	public class ServiceItem_SLMEventsProcess : ServiceItem_SLMEventsProcess<ServiceItem_SLM_Terrasoft>
	{

		public ServiceItem_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceItem_SLMEventsProcess

	public partial class ServiceItem_SLMEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

