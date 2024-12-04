namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Transaction

	/// <exclude/>
	public class Transaction : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Transaction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Transaction";
		}

		public Transaction(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Transaction";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

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
					(_contact = new Contact(LookupColumnEntities.GetEntity("Contact")));
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
					(_legalEntity = new Account(LookupColumnEntities.GetEntity("LegalEntity")));
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
					(_bankAccount = new BankAccount(LookupColumnEntities.GetEntity("BankAccount")));
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
					(_bankCard = new BankCard(LookupColumnEntities.GetEntity("BankCard")));
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
					(_transactionCurrency = new Currency(LookupColumnEntities.GetEntity("TransactionCurrency")));
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

	}

	#endregion

}

