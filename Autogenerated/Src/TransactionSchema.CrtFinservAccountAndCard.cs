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

	#region Class: TransactionSchema

	/// <exclude/>
	public class TransactionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public TransactionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TransactionSchema(TransactionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TransactionSchema(TransactionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9");
			RealUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9");
			Name = "Transaction";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("69f3365e-2ae7-1fdf-2c48-3ea2af51da22")) == null) {
				Columns.Add(CreateCommentColumn());
			}
			if (Columns.FindByUId(new Guid("72c44c77-f244-17a9-9cf1-96f41a344ec4")) == null) {
				Columns.Add(CreateWriteOffDateColumn());
			}
			if (Columns.FindByUId(new Guid("d1d5e49c-2bd3-5ac5-b328-ec6289101d8d")) == null) {
				Columns.Add(CreateTransactionDateColumn());
			}
			if (Columns.FindByUId(new Guid("cb1d3db7-867d-b766-c8cd-bcf0e3d394b6")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("af71f45a-12c9-2be1-d05e-db2d8bcedb2c")) == null) {
				Columns.Add(CreateBalanceColumn());
			}
			if (Columns.FindByUId(new Guid("1ccb6bec-a973-60ce-b07e-a1c941e00c3e")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("8443d5ab-9f2f-b5e6-ace5-ac430e946486")) == null) {
				Columns.Add(CreateLegalEntityColumn());
			}
			if (Columns.FindByUId(new Guid("e57c5b6d-f519-bce4-4c6d-96fd2944bf25")) == null) {
				Columns.Add(CreateNumberColumn());
			}
			if (Columns.FindByUId(new Guid("7d182eed-3732-0662-9a6a-c738ca77e548")) == null) {
				Columns.Add(CreateBankAccountColumn());
			}
			if (Columns.FindByUId(new Guid("08f56c7d-c216-d170-61b2-a47e9b882643")) == null) {
				Columns.Add(CreateBankCardColumn());
			}
			if (Columns.FindByUId(new Guid("d9620171-caf4-949b-1a70-3326ed29ad13")) == null) {
				Columns.Add(CreateTransactionCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("a0beb047-96bc-5ffa-b6fa-2ff343e32db3")) == null) {
				Columns.Add(CreateBalanceCurrencyAmountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("69f3365e-2ae7-1fdf-2c48-3ea2af51da22"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateWriteOffDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("72c44c77-f244-17a9-9cf1-96f41a344ec4"),
				Name = @"WriteOffDate",
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateTransactionDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("d1d5e49c-2bd3-5ac5-b328-ec6289101d8d"),
				Name = @"TransactionDate",
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("cb1d3db7-867d-b766-c8cd-bcf0e3d394b6"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateBalanceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("af71f45a-12c9-2be1-d05e-db2d8bcedb2c"),
				Name = @"Balance",
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1ccb6bec-a973-60ce-b07e-a1c941e00c3e"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateLegalEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8443d5ab-9f2f-b5e6-ace5-ac430e946486"),
				Name = @"LegalEntity",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e57c5b6d-f519-bce4-4c6d-96fd2944bf25"),
				Name = @"Number",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("2c8e7ccd-941d-4c9a-bb23-4b85cc287929")
			};
		}

		protected virtual EntitySchemaColumn CreateBankAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7d182eed-3732-0662-9a6a-c738ca77e548"),
				Name = @"BankAccount",
				ReferenceSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("da98c8ba-3ce8-4fa7-8392-1afd7710ad44"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateBankCardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("08f56c7d-c216-d170-61b2-a47e9b882643"),
				Name = @"BankCard",
				ReferenceSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("da98c8ba-3ce8-4fa7-8392-1afd7710ad44"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateTransactionCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d9620171-caf4-949b-1a70-3326ed29ad13"),
				Name = @"TransactionCurrency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("ddfd5d39-f04b-461e-bb22-4a9a1cde5b2f"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateBalanceCurrencyAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("a0beb047-96bc-5ffa-b6fa-2ff343e32db3"),
				Name = @"BalanceCurrencyAmount",
				CreatedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				ModifiedInSchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"),
				CreatedInPackageId = new Guid("ddfd5d39-f04b-461e-bb22-4a9a1cde5b2f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Transaction(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Transaction_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TransactionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TransactionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9"));
		}

		#endregion

	}

	#endregion

	#region Class: Transaction

	/// <summary>
	/// Transaction.
	/// </summary>
	public class Transaction : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Transaction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Transaction";
		}

		public Transaction(Transaction source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Comment.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		/// <summary>
		/// Write-off date.
		/// </summary>
		public DateTime WriteOffDate {
			get {
				return GetTypedColumnValue<DateTime>("WriteOffDate");
			}
			set {
				SetColumnValue("WriteOffDate", value);
			}
		}

		/// <summary>
		/// Transaction date.
		/// </summary>
		public DateTime TransactionDate {
			get {
				return GetTypedColumnValue<DateTime>("TransactionDate");
			}
			set {
				SetColumnValue("TransactionDate", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Balance.
		/// </summary>
		public Decimal Balance {
			get {
				return GetTypedColumnValue<Decimal>("Balance");
			}
			set {
				SetColumnValue("Balance", value);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public Guid LegalEntityId {
			get {
				return GetTypedColumnValue<Guid>("LegalEntityId");
			}
			set {
				SetColumnValue("LegalEntityId", value);
				_legalEntity = null;
			}
		}

		/// <exclude/>
		public string LegalEntityName {
			get {
				return GetTypedColumnValue<string>("LegalEntityName");
			}
			set {
				SetColumnValue("LegalEntityName", value);
				if (_legalEntity != null) {
					_legalEntity.Name = value;
				}
			}
		}

		private Account _legalEntity;
		/// <summary>
		/// LegalEntity.
		/// </summary>
		public Account LegalEntity {
			get {
				return _legalEntity ??
					(_legalEntity = LookupColumnEntities.GetEntity("LegalEntity") as Account);
			}
		}

		/// <summary>
		/// Number.
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
		/// Account.
		/// </summary>
		public BankAccount BankAccount {
			get {
				return _bankAccount ??
					(_bankAccount = LookupColumnEntities.GetEntity("BankAccount") as BankAccount);
			}
		}

		/// <exclude/>
		public Guid BankCardId {
			get {
				return GetTypedColumnValue<Guid>("BankCardId");
			}
			set {
				SetColumnValue("BankCardId", value);
				_bankCard = null;
			}
		}

		/// <exclude/>
		public string BankCardNumber {
			get {
				return GetTypedColumnValue<string>("BankCardNumber");
			}
			set {
				SetColumnValue("BankCardNumber", value);
				if (_bankCard != null) {
					_bankCard.Number = value;
				}
			}
		}

		private BankCard _bankCard;
		/// <summary>
		/// Card.
		/// </summary>
		public BankCard BankCard {
			get {
				return _bankCard ??
					(_bankCard = LookupColumnEntities.GetEntity("BankCard") as BankCard);
			}
		}

		/// <exclude/>
		public Guid TransactionCurrencyId {
			get {
				return GetTypedColumnValue<Guid>("TransactionCurrencyId");
			}
			set {
				SetColumnValue("TransactionCurrencyId", value);
				_transactionCurrency = null;
			}
		}

		/// <exclude/>
		public string TransactionCurrencyName {
			get {
				return GetTypedColumnValue<string>("TransactionCurrencyName");
			}
			set {
				SetColumnValue("TransactionCurrencyName", value);
				if (_transactionCurrency != null) {
					_transactionCurrency.Name = value;
				}
			}
		}

		private Currency _transactionCurrency;
		/// <summary>
		/// Transaction currency.
		/// </summary>
		public Currency TransactionCurrency {
			get {
				return _transactionCurrency ??
					(_transactionCurrency = LookupColumnEntities.GetEntity("TransactionCurrency") as Currency);
			}
		}

		/// <summary>
		/// Balance currency amount.
		/// </summary>
		public Decimal BalanceCurrencyAmount {
			get {
				return GetTypedColumnValue<Decimal>("BalanceCurrencyAmount");
			}
			set {
				SetColumnValue("BalanceCurrencyAmount", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Transaction_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Transaction(this);
		}

		#endregion

	}

	#endregion

	#region Class: Transaction_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class Transaction_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Transaction
	{

		public Transaction_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Transaction_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d6f7e63e-4bc4-472b-89c6-19304f5164d9");
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

	#region Class: Transaction_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class Transaction_CrtFinservAccountAndCardEventsProcess : Transaction_CrtFinservAccountAndCardEventsProcess<Transaction>
	{

		public Transaction_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Transaction_CrtFinservAccountAndCardEventsProcess

	public partial class Transaction_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TransactionEventsProcess

	/// <exclude/>
	public class TransactionEventsProcess : Transaction_CrtFinservAccountAndCardEventsProcess
	{

		public TransactionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

