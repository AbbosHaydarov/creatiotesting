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

	#region Class: AccountCategorySchema

	/// <exclude/>
	public class AccountCategorySchema : Terrasoft.Configuration.AccountCategory_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountCategorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountCategorySchema(AccountCategorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountCategorySchema(AccountCategorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("705e7445-7886-448e-bae9-368a83ffe44f");
			Name = "AccountCategory";
			ParentSchemaUId = new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665");
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
			return new AccountCategory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountCategory_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountCategorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountCategorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("705e7445-7886-448e-bae9-368a83ffe44f"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountCategory

	/// <summary>
	/// Category of legal entity.
	/// </summary>
	public class AccountCategory : Terrasoft.Configuration.AccountCategory_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public AccountCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountCategory";
		}

		public AccountCategory(AccountCategory source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountCategory_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountCategoryDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountCategoryDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountCategoryInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountCategoryInserting", e);
			Saved += (s, e) => ThrowEvent("AccountCategorySaved", e);
			Saving += (s, e) => ThrowEvent("AccountCategorySaving", e);
			Validating += (s, e) => ThrowEvent("AccountCategoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountCategory(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountCategory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountCategory_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountCategory_CrtCustomer360AppEventsProcess<TEntity> where TEntity : AccountCategory
	{

		public AccountCategory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountCategory_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("705e7445-7886-448e-bae9-368a83ffe44f");
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

	#region Class: AccountCategory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountCategory_CrtBaseFinservEventsProcess : AccountCategory_CrtBaseFinservEventsProcess<AccountCategory>
	{

		public AccountCategory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountCategory_CrtBaseFinservEventsProcess

	public partial class AccountCategory_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountCategoryEventsProcess

	/// <exclude/>
	public class AccountCategoryEventsProcess : AccountCategory_CrtBaseFinservEventsProcess
	{

		public AccountCategoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

