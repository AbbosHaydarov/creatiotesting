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

	#region Class: AccountOrganizationChartSchema

	/// <exclude/>
	public class AccountOrganizationChartSchema : Terrasoft.Configuration.AccountOrganizationChart_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountOrganizationChartSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountOrganizationChartSchema(AccountOrganizationChartSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountOrganizationChartSchema(AccountOrganizationChartSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("40fc2929-1c57-4303-a631-98bfd1eb6e0b");
			Name = "AccountOrganizationChart";
			ParentSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			RightSchemaName = @"SysAccountOrgChartRight";
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
			return new AccountOrganizationChart(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountOrganizationChart_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountOrganizationChartSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountOrganizationChartSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40fc2929-1c57-4303-a631-98bfd1eb6e0b"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountOrganizationChart

	/// <summary>
	/// Legal entity organizational structure.
	/// </summary>
	public class AccountOrganizationChart : Terrasoft.Configuration.AccountOrganizationChart_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountOrganizationChart(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountOrganizationChart";
		}

		public AccountOrganizationChart(AccountOrganizationChart source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountOrganizationChart_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountOrganizationChartDeleted", e);
			Validating += (s, e) => ThrowEvent("AccountOrganizationChartValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountOrganizationChart(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountOrganizationChart_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountOrganizationChart_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountOrganizationChart_CrtBaseEventsProcess<TEntity> where TEntity : AccountOrganizationChart
	{

		public AccountOrganizationChart_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountOrganizationChart_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("40fc2929-1c57-4303-a631-98bfd1eb6e0b");
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

	#region Class: AccountOrganizationChart_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountOrganizationChart_CrtBaseFinservEventsProcess : AccountOrganizationChart_CrtBaseFinservEventsProcess<AccountOrganizationChart>
	{

		public AccountOrganizationChart_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountOrganizationChart_CrtBaseFinservEventsProcess

	public partial class AccountOrganizationChart_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountOrganizationChartEventsProcess

	/// <exclude/>
	public class AccountOrganizationChartEventsProcess : AccountOrganizationChart_CrtBaseFinservEventsProcess
	{

		public AccountOrganizationChartEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

