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

	#region Class: AccountBillingInfoSchema

	/// <exclude/>
	public class AccountBillingInfoSchema : Terrasoft.Configuration.AccountBillingInfo_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountBillingInfoSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountBillingInfoSchema(AccountBillingInfoSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountBillingInfoSchema(AccountBillingInfoSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7906c549-4c03-4946-83c8-0965d86c06f3");
			Name = "AccountBillingInfo";
			ParentSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			ExtendParent = true;
			CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
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
			return new AccountBillingInfo(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountBillingInfo_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountBillingInfoSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountBillingInfoSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7906c549-4c03-4946-83c8-0965d86c06f3"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountBillingInfo

	/// <summary>
	/// Legal entity banking details.
	/// </summary>
	public class AccountBillingInfo : Terrasoft.Configuration.AccountBillingInfo_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public AccountBillingInfo(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountBillingInfo";
		}

		public AccountBillingInfo(AccountBillingInfo source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountBillingInfo_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountBillingInfoDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountBillingInfoDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountBillingInfoInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountBillingInfoInserting", e);
			Saved += (s, e) => ThrowEvent("AccountBillingInfoSaved", e);
			Saving += (s, e) => ThrowEvent("AccountBillingInfoSaving", e);
			Validating += (s, e) => ThrowEvent("AccountBillingInfoValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountBillingInfo(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountBillingInfo_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountBillingInfo_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountBillingInfo_CrtCustomer360AppEventsProcess<TEntity> where TEntity : AccountBillingInfo
	{

		public AccountBillingInfo_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountBillingInfo_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7906c549-4c03-4946-83c8-0965d86c06f3");
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

	#region Class: AccountBillingInfo_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountBillingInfo_CrtBaseFinservEventsProcess : AccountBillingInfo_CrtBaseFinservEventsProcess<AccountBillingInfo>
	{

		public AccountBillingInfo_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountBillingInfo_CrtBaseFinservEventsProcess

	public partial class AccountBillingInfo_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountBillingInfoEventsProcess

	/// <exclude/>
	public class AccountBillingInfoEventsProcess : AccountBillingInfo_CrtBaseFinservEventsProcess
	{

		public AccountBillingInfoEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

