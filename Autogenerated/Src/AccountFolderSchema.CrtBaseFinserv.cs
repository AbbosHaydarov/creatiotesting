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

	#region Class: AccountFolderSchema

	/// <exclude/>
	public class AccountFolderSchema : Terrasoft.Configuration.AccountFolder_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountFolderSchema(AccountFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountFolderSchema(AccountFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7bc366ab-41e8-4d0e-9161-42da09f20917");
			Name = "AccountFolder";
			ParentSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
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
			return new AccountFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountFolder_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7bc366ab-41e8-4d0e-9161-42da09f20917"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountFolder

	/// <summary>
	/// Legal entity folder.
	/// </summary>
	public class AccountFolder : Terrasoft.Configuration.AccountFolder_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountFolder";
		}

		public AccountFolder(AccountFolder source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountFolder_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountFolderDeleted", e);
			Validating += (s, e) => ThrowEvent("AccountFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountFolder_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountFolder_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountFolder_CrtBaseEventsProcess<TEntity> where TEntity : AccountFolder
	{

		public AccountFolder_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountFolder_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7bc366ab-41e8-4d0e-9161-42da09f20917");
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

	#region Class: AccountFolder_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountFolder_CrtBaseFinservEventsProcess : AccountFolder_CrtBaseFinservEventsProcess<AccountFolder>
	{

		public AccountFolder_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountFolder_CrtBaseFinservEventsProcess

	public partial class AccountFolder_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountFolderEventsProcess

	/// <exclude/>
	public class AccountFolderEventsProcess : AccountFolder_CrtBaseFinservEventsProcess
	{

		public AccountFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

