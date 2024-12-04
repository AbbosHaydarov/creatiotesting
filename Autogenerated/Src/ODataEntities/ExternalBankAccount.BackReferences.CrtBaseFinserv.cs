namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalBankAccount

	/// <exclude/>
	public class ExternalBankAccount : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public ExternalBankAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ExternalBankAccount";
		}

		public ExternalBankAccount(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "ExternalBankAccount";
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
					(_bankAccount = new Account(LookupColumnEntities.GetEntity("BankAccount")));
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
					(_bankAccountType = new BankAccountType(LookupColumnEntities.GetEntity("BankAccountType")));
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
					(_currency = new Currency(LookupColumnEntities.GetEntity("Currency")));
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
					(_account = new Account(LookupColumnEntities.GetEntity("Account")));
			}
		}

		#endregion

	}

	#endregion

}

