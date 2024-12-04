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
	using Terrasoft.Configuration;
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

	#region Class: AccountFileSchema

	/// <exclude/>
	public class AccountFileSchema : Terrasoft.Configuration.AccountFile_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountFileSchema(AccountFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountFileSchema(AccountFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b4c28fca-2156-499a-9765-6c96f7d103d9");
			Name = "AccountFile";
			ParentSchemaUId = new Guid("149d2eaf-cbd2-49fa-b565-637748ff823c");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
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
			return new AccountFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountFile_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4c28fca-2156-499a-9765-6c96f7d103d9"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountFile

	/// <summary>
	/// File and link of account.
	/// </summary>
	public class AccountFile : Terrasoft.Configuration.AccountFile_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountFile";
		}

		public AccountFile(AccountFile source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountFile_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountFileDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountFileDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountFileInserted", e);
			Saved += (s, e) => ThrowEvent("AccountFileSaved", e);
			Saving += (s, e) => ThrowEvent("AccountFileSaving", e);
			Updated += (s, e) => ThrowEvent("AccountFileUpdated", e);
			Validating += (s, e) => ThrowEvent("AccountFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountFile_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountFile_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountFile_CrtBaseEventsProcess<TEntity> where TEntity : AccountFile
	{

		public AccountFile_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountFile_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b4c28fca-2156-499a-9765-6c96f7d103d9");
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

	#region Class: AccountFile_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountFile_CrtBaseFinservEventsProcess : AccountFile_CrtBaseFinservEventsProcess<AccountFile>
	{

		public AccountFile_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountFile_CrtBaseFinservEventsProcess

	public partial class AccountFile_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountFileEventsProcess

	/// <exclude/>
	public class AccountFileEventsProcess : AccountFile_CrtBaseFinservEventsProcess
	{

		public AccountFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

