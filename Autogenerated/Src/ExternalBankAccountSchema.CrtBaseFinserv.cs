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

	#region Class: ExternalBankAccountSchema

	/// <exclude/>
	public class ExternalBankAccountSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ExternalBankAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ExternalBankAccountSchema(ExternalBankAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ExternalBankAccountSchema(ExternalBankAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			RealUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			Name = "ExternalBankAccount";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1f01ecb9-1069-485a-8fc4-558409f5ff70")) == null) {
				Columns.Add(CreateBankAccountColumn());
			}
			if (Columns.FindByUId(new Guid("2ebb6bd0-ec2d-438e-a842-bad7d88996e3")) == null) {
				Columns.Add(CreateBankAccountTypeColumn());
			}
			if (Columns.FindByUId(new Guid("59f17621-274a-4b94-b1a9-e5a68f64af30")) == null) {
				Columns.Add(CreateIsPrimaryColumn());
			}
			if (Columns.FindByUId(new Guid("d232c5cf-bd40-486c-a4b7-bd328c971457")) == null) {
				Columns.Add(CreateBankAccountTurnoverColumn());
			}
			if (Columns.FindByUId(new Guid("bf83b053-af3d-4026-9336-edacc209ce88")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("62659353-a2ee-4258-b746-38f3643395e4")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("edc6a877-1528-449a-bd96-d7c5cad319ac")) == null) {
				Columns.Add(CreateActualizedOnColumn());
			}
			if (Columns.FindByUId(new Guid("4ee27554-b539-4b85-842a-d75ade94f681")) == null) {
				Columns.Add(CreateAccountColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBankAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1f01ecb9-1069-485a-8fc4-558409f5ff70"),
				Name = @"BankAccount",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d45565f4-ae16-4da7-b5e0-4fb8052edc72"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateBankAccountTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2ebb6bd0-ec2d-438e-a842-bad7d88996e3"),
				Name = @"BankAccountType",
				ReferenceSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateIsPrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("59f17621-274a-4b94-b1a9-e5a68f64af30"),
				Name = @"IsPrimary",
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateBankAccountTurnoverColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d232c5cf-bd40-486c-a4b7-bd328c971457"),
				Name = @"BankAccountTurnover",
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bf83b053-af3d-4026-9336-edacc209ce88"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("62659353-a2ee-4258-b746-38f3643395e4"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateActualizedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("edc6a877-1528-449a-bd96-d7c5cad319ac"),
				Name = @"ActualizedOn",
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4ee27554-b539-4b85-842a-d75ade94f681"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				ModifiedInSchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"),
				CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ExternalBankAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ExternalBankAccount_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ExternalBankAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ExternalBankAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e"));
		}

		#endregion

	}

	#endregion

	#region Class: ExternalBankAccount

	/// <summary>
	/// Account in external bank.
	/// </summary>
	public class ExternalBankAccount : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ExternalBankAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ExternalBankAccount";
		}

		public ExternalBankAccount(ExternalBankAccount source)
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
		public string BankAccountName {
			get {
				return GetTypedColumnValue<string>("BankAccountName");
			}
			set {
				SetColumnValue("BankAccountName", value);
				if (_bankAccount != null) {
					_bankAccount.Name = value;
				}
			}
		}

		private Account _bankAccount;
		/// <summary>
		/// Bank.
		/// </summary>
		public Account BankAccount {
			get {
				return _bankAccount ??
					(_bankAccount = LookupColumnEntities.GetEntity("BankAccount") as Account);
			}
		}

		/// <summary>
		/// Account number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <exclude/>
		public Guid BankAccountTypeId {
			get {
				return GetTypedColumnValue<Guid>("BankAccountTypeId");
			}
			set {
				SetColumnValue("BankAccountTypeId", value);
				_bankAccountType = null;
			}
		}

		/// <exclude/>
		public string BankAccountTypeName {
			get {
				return GetTypedColumnValue<string>("BankAccountTypeName");
			}
			set {
				SetColumnValue("BankAccountTypeName", value);
				if (_bankAccountType != null) {
					_bankAccountType.Name = value;
				}
			}
		}

		private BankAccountType _bankAccountType;
		/// <summary>
		/// Type.
		/// </summary>
		public BankAccountType BankAccountType {
			get {
				return _bankAccountType ??
					(_bankAccountType = LookupColumnEntities.GetEntity("BankAccountType") as BankAccountType);
			}
		}

		/// <summary>
		/// Primary.
		/// </summary>
		public bool IsPrimary {
			get {
				return GetTypedColumnValue<bool>("IsPrimary");
			}
			set {
				SetColumnValue("IsPrimary", value);
			}
		}

		/// <summary>
		/// Account turnover.
		/// </summary>
		public Decimal BankAccountTurnover {
			get {
				return GetTypedColumnValue<Decimal>("BankAccountTurnover");
			}
			set {
				SetColumnValue("BankAccountTurnover", value);
			}
		}

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Update on.
		/// </summary>
		public DateTime ActualizedOn {
			get {
				return GetTypedColumnValue<DateTime>("ActualizedOn");
			}
			set {
				SetColumnValue("ActualizedOn", value);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Legal entity.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ExternalBankAccount_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ExternalBankAccountDeleted", e);
			Validating += (s, e) => ThrowEvent("ExternalBankAccountValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ExternalBankAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: ExternalBankAccount_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ExternalBankAccount_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ExternalBankAccount
	{

		public ExternalBankAccount_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExternalBankAccount_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("33c00e57-1d85-4884-b851-0330f3e5f26e");
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

	#region Class: ExternalBankAccount_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ExternalBankAccount_CrtBaseFinservEventsProcess : ExternalBankAccount_CrtBaseFinservEventsProcess<ExternalBankAccount>
	{

		public ExternalBankAccount_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExternalBankAccount_CrtBaseFinservEventsProcess

	public partial class ExternalBankAccount_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ExternalBankAccountEventsProcess

	/// <exclude/>
	public class ExternalBankAccountEventsProcess : ExternalBankAccount_CrtBaseFinservEventsProcess
	{

		public ExternalBankAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

