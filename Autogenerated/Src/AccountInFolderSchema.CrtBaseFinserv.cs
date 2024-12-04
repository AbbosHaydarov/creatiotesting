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

	#region Class: AccountInFolderSchema

	/// <exclude/>
	public class AccountInFolderSchema : Terrasoft.Configuration.AccountInFolder_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountInFolderSchema(AccountInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountInFolderSchema(AccountInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("85b876b4-b138-4d8f-8a9f-527255f7613e");
			Name = "AccountInFolder";
			ParentSchemaUId = new Guid("88c4a9e2-e539-4832-90f4-efc1779ebad9");
			ExtendParent = true;
			CreatedInPackageId = new Guid("27329051-b308-4a64-83ef-1a0f05a9ca5f");
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
			return new AccountInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountInFolder_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85b876b4-b138-4d8f-8a9f-527255f7613e"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountInFolder

	/// <summary>
	/// Legal entity in folder.
	/// </summary>
	public class AccountInFolder : Terrasoft.Configuration.AccountInFolder_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountInFolder";
		}

		public AccountInFolder(AccountInFolder source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountInFolder_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountInFolderDeleted", e);
			Validating += (s, e) => ThrowEvent("AccountInFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountInFolder_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountInFolder_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountInFolder_CrtBaseEventsProcess<TEntity> where TEntity : AccountInFolder
	{

		public AccountInFolder_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountInFolder_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("85b876b4-b138-4d8f-8a9f-527255f7613e");
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

	#region Class: AccountInFolder_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountInFolder_CrtBaseFinservEventsProcess : AccountInFolder_CrtBaseFinservEventsProcess<AccountInFolder>
	{

		public AccountInFolder_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountInFolder_CrtBaseFinservEventsProcess

	public partial class AccountInFolder_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountInFolderEventsProcess

	/// <exclude/>
	public class AccountInFolderEventsProcess : AccountInFolder_CrtBaseFinservEventsProcess
	{

		public AccountInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

