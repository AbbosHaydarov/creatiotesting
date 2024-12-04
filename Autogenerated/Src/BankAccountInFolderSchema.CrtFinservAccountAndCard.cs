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

	#region Class: BankAccountInFolderSchema

	/// <exclude/>
	public class BankAccountInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public BankAccountInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankAccountInFolderSchema(BankAccountInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankAccountInFolderSchema(BankAccountInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			RealUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			Name = "BankAccountInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6fa12234-848c-4fb5-a2e5-1deaba5f4862")) == null) {
				Columns.Add(CreateBankAccountColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("22047aac-d515-4341-88fd-bca49d5e18de");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBankAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6fa12234-848c-4fb5-a2e5-1deaba5f4862"),
				Name = @"BankAccount",
				ReferenceSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1"),
				ModifiedInSchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankAccountInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankAccountInFolder_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankAccountInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankAccountInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1"));
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountInFolder

	/// <summary>
	/// Object in folder - "Financial account".
	/// </summary>
	public class BankAccountInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public BankAccountInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankAccountInFolder";
		}

		public BankAccountInFolder(BankAccountInFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BankAccountId {
			get {
				return GetTypedColumnValue<Guid>("BankAccountId");
			}
			set {
				SetColumnValue("BankAccountId", value);
				_bankAccount = null;
			}
		}

		/// <exclude/>
		public string BankAccountBankAccountNumber {
			get {
				return GetTypedColumnValue<string>("BankAccountBankAccountNumber");
			}
			set {
				SetColumnValue("BankAccountBankAccountNumber", value);
				if (_bankAccount != null) {
					_bankAccount.BankAccountNumber = value;
				}
			}
		}

		private BankAccount _bankAccount;
		/// <summary>
		/// Financial account.
		/// </summary>
		public BankAccount BankAccount {
			get {
				return _bankAccount ??
					(_bankAccount = LookupColumnEntities.GetEntity("BankAccount") as BankAccount);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankAccountInFolder_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankAccountInFolderDeleted", e);
			Validating += (s, e) => ThrowEvent("BankAccountInFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankAccountInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountInFolder_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankAccountInFolder_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankAccountInFolder
	{

		public BankAccountInFolder_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankAccountInFolder_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c0de3192-97b5-4d22-8f1d-9df86b3d86f1");
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

	#region Class: BankAccountInFolder_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankAccountInFolder_CrtFinservAccountAndCardEventsProcess : BankAccountInFolder_CrtFinservAccountAndCardEventsProcess<BankAccountInFolder>
	{

		public BankAccountInFolder_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankAccountInFolder_CrtFinservAccountAndCardEventsProcess

	public partial class BankAccountInFolder_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankAccountInFolderEventsProcess

	/// <exclude/>
	public class BankAccountInFolderEventsProcess : BankAccountInFolder_CrtFinservAccountAndCardEventsProcess
	{

		public BankAccountInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

