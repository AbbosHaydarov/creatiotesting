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

	#region Class: AccountOwnershipFormSchema

	/// <exclude/>
	public class AccountOwnershipFormSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AccountOwnershipFormSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountOwnershipFormSchema(AccountOwnershipFormSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountOwnershipFormSchema(AccountOwnershipFormSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			RealUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			Name = "AccountOwnershipForm";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
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

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			column.CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountOwnershipForm(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountOwnershipForm_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountOwnershipFormSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountOwnershipFormSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnershipForm

	/// <summary>
	/// Legal entity ownership form.
	/// </summary>
	public class AccountOwnershipForm : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AccountOwnershipForm(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountOwnershipForm";
		}

		public AccountOwnershipForm(AccountOwnershipForm source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountOwnershipForm_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountOwnershipFormDeleted", e);
			Validating += (s, e) => ThrowEvent("AccountOwnershipFormValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountOwnershipForm(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnershipForm_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountOwnershipForm_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountOwnershipForm
	{

		public AccountOwnershipForm_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountOwnershipForm_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2");
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

	#region Class: AccountOwnershipForm_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountOwnershipForm_CrtBaseFinservEventsProcess : AccountOwnershipForm_CrtBaseFinservEventsProcess<AccountOwnershipForm>
	{

		public AccountOwnershipForm_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountOwnershipForm_CrtBaseFinservEventsProcess

	public partial class AccountOwnershipForm_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountOwnershipFormEventsProcess

	/// <exclude/>
	public class AccountOwnershipFormEventsProcess : AccountOwnershipForm_CrtBaseFinservEventsProcess
	{

		public AccountOwnershipFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

