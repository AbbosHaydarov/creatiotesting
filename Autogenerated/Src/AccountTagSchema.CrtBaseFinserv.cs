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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: AccountTagSchema

	/// <exclude/>
	public class AccountTagSchema : Terrasoft.Configuration.AccountTag_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountTagSchema(AccountTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountTagSchema(AccountTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a4252d42-acc4-40bc-bead-d64ae61a0479");
			Name = "AccountTag";
			ParentSchemaUId = new Guid("42b60e75-f30e-4895-a80c-3835a5e5b97a");
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
			return new AccountTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountTag_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4252d42-acc4-40bc-bead-d64ae61a0479"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountTag

	/// <summary>
	/// Legal entities section tag.
	/// </summary>
	public class AccountTag : Terrasoft.Configuration.AccountTag_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountTag";
		}

		public AccountTag(AccountTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountTag_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountTagDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountTagInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountTagInserting", e);
			Saved += (s, e) => ThrowEvent("AccountTagSaved", e);
			Saving += (s, e) => ThrowEvent("AccountTagSaving", e);
			Validating += (s, e) => ThrowEvent("AccountTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountTag_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountTag_CrtBaseEventsProcess<TEntity> where TEntity : AccountTag
	{

		public AccountTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountTag_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a4252d42-acc4-40bc-bead-d64ae61a0479");
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

	#region Class: AccountTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountTag_CrtBaseFinservEventsProcess : AccountTag_CrtBaseFinservEventsProcess<AccountTag>
	{

		public AccountTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountTag_CrtBaseFinservEventsProcess

	public partial class AccountTag_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountTagEventsProcess

	/// <exclude/>
	public class AccountTagEventsProcess : AccountTag_CrtBaseFinservEventsProcess
	{

		public AccountTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

