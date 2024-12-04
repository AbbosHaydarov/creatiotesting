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

	#region Class: BankAccountFileSchema

	/// <exclude/>
	public class BankAccountFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public BankAccountFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankAccountFileSchema(BankAccountFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankAccountFileSchema(BankAccountFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			RealUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			Name = "BankAccountFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
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
			if (Columns.FindByUId(new Guid("0bdb64b0-0a28-471f-b9ae-c51a8be5168b")) == null) {
				Columns.Add(CreateBankAccountColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateLockedByColumn() {
			EntitySchemaColumn column = base.CreateLockedByColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateLockedOnColumn() {
			EntitySchemaColumn column = base.CreateLockedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateDataColumn() {
			EntitySchemaColumn column = base.CreateDataColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateVersionColumn() {
			EntitySchemaColumn column = base.CreateVersionColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateSizeColumn() {
			EntitySchemaColumn column = base.CreateSizeColumn();
			column.ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBankAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0bdb64b0-0a28-471f-b9ae-c51a8be5168b"),
				Name = @"BankAccount",
				ReferenceSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b"),
				ModifiedInSchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b"),
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
			return new BankAccountFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankAccountFile_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankAccountFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankAccountFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3be84ec3-5476-432a-96ed-8e863d74118b"));
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountFile

	/// <summary>
	/// Financial account attachment.
	/// </summary>
	public class BankAccountFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public BankAccountFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankAccountFile";
		}

		public BankAccountFile(BankAccountFile source)
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
			var process = new BankAccountFile_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankAccountFileDeleted", e);
			Inserting += (s, e) => ThrowEvent("BankAccountFileInserting", e);
			Updated += (s, e) => ThrowEvent("BankAccountFileUpdated", e);
			Validating += (s, e) => ThrowEvent("BankAccountFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankAccountFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountFile_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankAccountFile_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.File_LinkPreviewEventsProcess<TEntity> where TEntity : BankAccountFile
	{

		public BankAccountFile_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankAccountFile_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3be84ec3-5476-432a-96ed-8e863d74118b");
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

	#region Class: BankAccountFile_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankAccountFile_CrtFinservAccountAndCardEventsProcess : BankAccountFile_CrtFinservAccountAndCardEventsProcess<BankAccountFile>
	{

		public BankAccountFile_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankAccountFile_CrtFinservAccountAndCardEventsProcess

	public partial class BankAccountFile_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankAccountFileEventsProcess

	/// <exclude/>
	public class BankAccountFileEventsProcess : BankAccountFile_CrtFinservAccountAndCardEventsProcess
	{

		public BankAccountFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

