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

	#region Class: AccountOwnershipSchema

	/// <exclude/>
	public class AccountOwnershipSchema : Terrasoft.Configuration.AccountOwnership_CrtCoreBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountOwnershipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountOwnershipSchema(AccountOwnershipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountOwnershipSchema(AccountOwnershipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3bec359d-4ddc-43a7-af14-820b71090a71");
			Name = "AccountOwnership";
			ParentSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
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
			return new AccountOwnership(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountOwnership_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountOwnershipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountOwnershipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3bec359d-4ddc-43a7-af14-820b71090a71"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnership

	/// <summary>
	/// Legal entity form.
	/// </summary>
	public class AccountOwnership : Terrasoft.Configuration.AccountOwnership_CrtCoreBase_Terrasoft
	{

		#region Constructors: Public

		public AccountOwnership(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountOwnership";
		}

		public AccountOwnership(AccountOwnership source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountOwnership_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountOwnershipDeleted", e);
			Validating += (s, e) => ThrowEvent("AccountOwnershipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountOwnership(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnership_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountOwnership_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountOwnership_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountOwnership
	{

		public AccountOwnership_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountOwnership_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3bec359d-4ddc-43a7-af14-820b71090a71");
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

	#region Class: AccountOwnership_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountOwnership_CrtBaseFinservEventsProcess : AccountOwnership_CrtBaseFinservEventsProcess<AccountOwnership>
	{

		public AccountOwnership_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountOwnership_CrtBaseFinservEventsProcess

	public partial class AccountOwnership_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountOwnershipEventsProcess

	/// <exclude/>
	public class AccountOwnershipEventsProcess : AccountOwnership_CrtBaseFinservEventsProcess
	{

		public AccountOwnershipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

