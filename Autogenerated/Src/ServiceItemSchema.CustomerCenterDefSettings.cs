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

	#region Class: ServiceItemSchema

	/// <exclude/>
	public class ServiceItemSchema : Terrasoft.Configuration.ServiceItem_SLM_TerrasoftSchema
	{

		#region Constructors: Public

		public ServiceItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceItemSchema(ServiceItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceItemSchema(ServiceItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("004f6aab-6e04-4d14-b787-c16ea4d10e30");
			Name = "ServiceItem";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ccaa00b6-778a-40ae-8764-ace39d5d6d36");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceItem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServiceItem_CustomerCenterDefSettingsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServiceItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("004f6aab-6e04-4d14-b787-c16ea4d10e30"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem

	/// <summary>
	/// Service.
	/// </summary>
	public class ServiceItem : Terrasoft.Configuration.ServiceItem_SLM_Terrasoft
	{

		#region Constructors: Public

		public ServiceItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceItem";
		}

		public ServiceItem(ServiceItem source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceItem_CustomerCenterDefSettingsEventsProcess(UserConnection);
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
			return new ServiceItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem_CustomerCenterDefSettingsEventsProcess

	/// <exclude/>
	public partial class ServiceItem_CustomerCenterDefSettingsEventsProcess<TEntity> : Terrasoft.Configuration.ServiceItem_SLMEventsProcess<TEntity> where TEntity : ServiceItem
	{

		public ServiceItem_CustomerCenterDefSettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceItem_CustomerCenterDefSettingsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("004f6aab-6e04-4d14-b787-c16ea4d10e30");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem_CustomerCenterDefSettingsEventsProcess

	/// <exclude/>
	public class ServiceItem_CustomerCenterDefSettingsEventsProcess : ServiceItem_CustomerCenterDefSettingsEventsProcess<ServiceItem>
	{

		public ServiceItem_CustomerCenterDefSettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceItem_CustomerCenterDefSettingsEventsProcess

	public partial class ServiceItem_CustomerCenterDefSettingsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ServiceItemEventsProcess

	/// <exclude/>
	public class ServiceItemEventsProcess : ServiceItem_CustomerCenterDefSettingsEventsProcess
	{

		public ServiceItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

