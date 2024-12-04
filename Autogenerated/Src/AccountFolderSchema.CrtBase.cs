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

	#region Class: AccountFolder_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class AccountFolder_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public AccountFolder_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountFolder_CrtBase_TerrasoftSchema(AccountFolder_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountFolder_CrtBase_TerrasoftSchema(AccountFolder_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			RealUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			Name = "AccountFolder_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.ModifiedInSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateSearchDataColumn() {
			EntitySchemaColumn column = base.CreateSearchDataColumn();
			column.ModifiedInSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountFolder_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountFolder_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountFolder_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountFolder_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountFolder_CrtBase_Terrasoft

	/// <summary>
	/// Account folder.
	/// </summary>
	public class AccountFolder_CrtBase_Terrasoft : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public AccountFolder_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountFolder_CrtBase_Terrasoft";
		}

		public AccountFolder_CrtBase_Terrasoft(AccountFolder_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private AccountFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public AccountFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as AccountFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountFolder_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountFolder_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountFolder_CrtBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountFolder_CrtBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountFolder_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("AccountFolder_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AccountFolder_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AccountFolder_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountFolder_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountFolder_CrtBaseEventsProcess

	/// <exclude/>
	public partial class AccountFolder_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountFolder_CrtBase_Terrasoft
	{

		public AccountFolder_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountFolder_CrtBaseEventsProcess";
			SchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38");
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

	#region Class: AccountFolder_CrtBaseEventsProcess

	/// <exclude/>
	public class AccountFolder_CrtBaseEventsProcess : AccountFolder_CrtBaseEventsProcess<AccountFolder_CrtBase_Terrasoft>
	{

		public AccountFolder_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountFolder_CrtBaseEventsProcess

	public partial class AccountFolder_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion

}

