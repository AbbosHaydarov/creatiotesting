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

	#region Class: AccountEmployeesNumberSchema

	/// <exclude/>
	public class AccountEmployeesNumberSchema : Terrasoft.Configuration.AccountEmployeesNumber_CrtCoreBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountEmployeesNumberSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountEmployeesNumberSchema(AccountEmployeesNumberSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountEmployeesNumberSchema(AccountEmployeesNumberSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("67d43d2e-06e1-4202-8443-d9cd2885189d");
			Name = "AccountEmployeesNumber";
			ParentSchemaUId = new Guid("ccf7d7bf-b4b7-4eb3-a191-3f47d6c4ee8d");
			ExtendParent = true;
			CreatedInPackageId = new Guid("42c464a9-9677-4bbd-86c1-308caea3de84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
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
			return new AccountEmployeesNumber(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountEmployeesNumber_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountEmployeesNumberSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountEmployeesNumberSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67d43d2e-06e1-4202-8443-d9cd2885189d"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountEmployeesNumber

	/// <summary>
	/// Number of account employees.
	/// </summary>
	public class AccountEmployeesNumber : Terrasoft.Configuration.AccountEmployeesNumber_CrtCoreBase_Terrasoft
	{

		#region Constructors: Public

		public AccountEmployeesNumber(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountEmployeesNumber";
		}

		public AccountEmployeesNumber(AccountEmployeesNumber source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountEmployeesNumber_CrtBaseFinservEventsProcess(UserConnection);
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
			return new AccountEmployeesNumber(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountEmployeesNumber_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountEmployeesNumber_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountEmployeesNumber_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountEmployeesNumber
	{

		public AccountEmployeesNumber_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountEmployeesNumber_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("67d43d2e-06e1-4202-8443-d9cd2885189d");
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

	#region Class: AccountEmployeesNumber_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountEmployeesNumber_CrtBaseFinservEventsProcess : AccountEmployeesNumber_CrtBaseFinservEventsProcess<AccountEmployeesNumber>
	{

		public AccountEmployeesNumber_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountEmployeesNumber_CrtBaseFinservEventsProcess

	public partial class AccountEmployeesNumber_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountEmployeesNumberEventsProcess

	/// <exclude/>
	public class AccountEmployeesNumberEventsProcess : AccountEmployeesNumber_CrtBaseFinservEventsProcess
	{

		public AccountEmployeesNumberEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

