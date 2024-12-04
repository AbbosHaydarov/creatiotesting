namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BankCard

	/// <exclude/>
	public class BankCard : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BankCard(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCard";
		}

		public BankCard(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "BankCard";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByBankCard {
			get;
			set;
		}

		public IEnumerable<BankCardBankAccount> BankCardBankAccountCollectionByBankCard {
			get;
			set;
		}

		public IEnumerable<BankCardFile> BankCardFileCollectionByBankCard {
			get;
			set;
		}

		public IEnumerable<BankCardInFolder> BankCardInFolderCollectionByBankCard {
			get;
			set;
		}

		public IEnumerable<BankCardInTag> BankCardInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<BankCardRelated> BankCardRelatedCollectionByBankCard {
			get;
			set;
		}

		public IEnumerable<BankCardRelated> BankCardRelatedCollectionByRelatedBankCard {
			get;
			set;
		}

		public IEnumerable<Transaction> TransactionCollectionByBankCard {
			get;
			set;
		}

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
		/// Owner.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = new Contact(LookupColumnEntities.GetEntity("Contact")));
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
		public Guid BankCardTypeId {
			get {
				return GetTypedColumnValue<Guid>("BankCardTypeId");
			}
			set {
				SetColumnValue("BankCardTypeId", value);
				_bankCardType = null;
			}
		}

		/// <exclude/>
		public string BankCardTypeName {
			get {
				return GetTypedColumnValue<string>("BankCardTypeName");
			}
			set {
				SetColumnValue("BankCardTypeName", value);
				if (_bankCardType != null) {
					_bankCardType.Name = value;
				}
			}
		}

		private BankCardType _bankCardType;
		/// <summary>
		/// Type.
		/// </summary>
		public BankCardType BankCardType {
			get {
				return _bankCardType ??
					(_bankCardType = new BankCardType(LookupColumnEntities.GetEntity("BankCardType")));
			}
		}

		/// <exclude/>
		public Guid BankCardPaymentSystemId {
			get {
				return GetTypedColumnValue<Guid>("BankCardPaymentSystemId");
			}
			set {
				SetColumnValue("BankCardPaymentSystemId", value);
				_bankCardPaymentSystem = null;
			}
		}

		/// <exclude/>
		public string BankCardPaymentSystemName {
			get {
				return GetTypedColumnValue<string>("BankCardPaymentSystemName");
			}
			set {
				SetColumnValue("BankCardPaymentSystemName", value);
				if (_bankCardPaymentSystem != null) {
					_bankCardPaymentSystem.Name = value;
				}
			}
		}

		private BankCardPaymentSystem _bankCardPaymentSystem;
		/// <summary>
		/// Payment system.
		/// </summary>
		public BankCardPaymentSystem BankCardPaymentSystem {
			get {
				return _bankCardPaymentSystem ??
					(_bankCardPaymentSystem = new BankCardPaymentSystem(LookupColumnEntities.GetEntity("BankCardPaymentSystem")));
			}
		}

		/// <exclude/>
		public Guid BankCardCategoryId {
			get {
				return GetTypedColumnValue<Guid>("BankCardCategoryId");
			}
			set {
				SetColumnValue("BankCardCategoryId", value);
				_bankCardCategory = null;
			}
		}

		/// <exclude/>
		public string BankCardCategoryName {
			get {
				return GetTypedColumnValue<string>("BankCardCategoryName");
			}
			set {
				SetColumnValue("BankCardCategoryName", value);
				if (_bankCardCategory != null) {
					_bankCardCategory.Name = value;
				}
			}
		}

		private BankCardCategory _bankCardCategory;
		/// <summary>
		/// Category.
		/// </summary>
		public BankCardCategory BankCardCategory {
			get {
				return _bankCardCategory ??
					(_bankCardCategory = new BankCardCategory(LookupColumnEntities.GetEntity("BankCardCategory")));
			}
		}

		/// <exclude/>
		public Guid HolderId {
			get {
				return GetTypedColumnValue<Guid>("HolderId");
			}
			set {
				SetColumnValue("HolderId", value);
				_holder = null;
			}
		}

		/// <exclude/>
		public string HolderName {
			get {
				return GetTypedColumnValue<string>("HolderName");
			}
			set {
				SetColumnValue("HolderName", value);
				if (_holder != null) {
					_holder.Name = value;
				}
			}
		}

		private Contact _holder;
		/// <summary>
		/// Cardholder.
		/// </summary>
		public Contact Holder {
			get {
				return _holder ??
					(_holder = new Contact(LookupColumnEntities.GetEntity("Holder")));
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
		/// Multicurrency.
		/// </summary>
		public bool IsMulticurrency {
			get {
				return GetTypedColumnValue<bool>("IsMulticurrency");
			}
			set {
				SetColumnValue("IsMulticurrency", value);
			}
		}

		/// <exclude/>
		public Guid BranchId {
			get {
				return GetTypedColumnValue<Guid>("BranchId");
			}
			set {
				SetColumnValue("BranchId", value);
				_branch = null;
			}
		}

		/// <exclude/>
		public string BranchName {
			get {
				return GetTypedColumnValue<string>("BranchName");
			}
			set {
				SetColumnValue("BranchName", value);
				if (_branch != null) {
					_branch.Name = value;
				}
			}
		}

		private Account _branch;
		/// <summary>
		/// Branch.
		/// </summary>
		public Account Branch {
			get {
				return _branch ??
					(_branch = new Account(LookupColumnEntities.GetEntity("Branch")));
			}
		}

		/// <exclude/>
		public Guid DivisionId {
			get {
				return GetTypedColumnValue<Guid>("DivisionId");
			}
			set {
				SetColumnValue("DivisionId", value);
				_division = null;
			}
		}

		/// <exclude/>
		public string DivisionName {
			get {
				return GetTypedColumnValue<string>("DivisionName");
			}
			set {
				SetColumnValue("DivisionName", value);
				if (_division != null) {
					_division.Name = value;
				}
			}
		}

		private Account _division;
		/// <summary>
		/// Office.
		/// </summary>
		public Account Division {
			get {
				return _division ??
					(_division = new Account(LookupColumnEntities.GetEntity("Division")));
			}
		}

		/// <summary>
		/// Opened on.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <exclude/>
		public Guid BankCardStatusId {
			get {
				return GetTypedColumnValue<Guid>("BankCardStatusId");
			}
			set {
				SetColumnValue("BankCardStatusId", value);
				_bankCardStatus = null;
			}
		}

		/// <exclude/>
		public string BankCardStatusName {
			get {
				return GetTypedColumnValue<string>("BankCardStatusName");
			}
			set {
				SetColumnValue("BankCardStatusName", value);
				if (_bankCardStatus != null) {
					_bankCardStatus.Name = value;
				}
			}
		}

		private BankCardStatus _bankCardStatus;
		/// <summary>
		/// Status.
		/// </summary>
		public BankCardStatus BankCardStatus {
			get {
				return _bankCardStatus ??
					(_bankCardStatus = new BankCardStatus(LookupColumnEntities.GetEntity("BankCardStatus")));
			}
		}

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = new Product(LookupColumnEntities.GetEntity("Product")));
			}
		}

		/// <exclude/>
		public Guid BankCardOwnerId {
			get {
				return GetTypedColumnValue<Guid>("BankCardOwnerId");
			}
			set {
				SetColumnValue("BankCardOwnerId", value);
				_bankCardOwner = null;
			}
		}

		/// <exclude/>
		public string BankCardOwnerName {
			get {
				return GetTypedColumnValue<string>("BankCardOwnerName");
			}
			set {
				SetColumnValue("BankCardOwnerName", value);
				if (_bankCardOwner != null) {
					_bankCardOwner.Name = value;
				}
			}
		}

		private Account _bankCardOwner;
		/// <summary>
		/// Legal entity.
		/// </summary>
		public Account BankCardOwner {
			get {
				return _bankCardOwner ??
					(_bankCardOwner = new Account(LookupColumnEntities.GetEntity("BankCardOwner")));
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = new Contract(LookupColumnEntities.GetEntity("Contract")));
			}
		}

		/// <exclude/>
		public Guid PackageId {
			get {
				return GetTypedColumnValue<Guid>("PackageId");
			}
			set {
				SetColumnValue("PackageId", value);
				_package = null;
			}
		}

		/// <exclude/>
		public string PackageName {
			get {
				return GetTypedColumnValue<string>("PackageName");
			}
			set {
				SetColumnValue("PackageName", value);
				if (_package != null) {
					_package.Name = value;
				}
			}
		}

		private Product _package;
		/// <summary>
		/// Banking package.
		/// </summary>
		public Product Package {
			get {
				return _package ??
					(_package = new Product(LookupColumnEntities.GetEntity("Package")));
			}
		}

		/// <summary>
		/// First and last name.
		/// </summary>
		public string ContactNameEng {
			get {
				return GetTypedColumnValue<string>("ContactNameEng");
			}
			set {
				SetColumnValue("ContactNameEng", value);
			}
		}

		/// <summary>
		/// PayPass / PayWave.
		/// </summary>
		public bool IsPayPassPayWave {
			get {
				return GetTypedColumnValue<bool>("IsPayPassPayWave");
			}
			set {
				SetColumnValue("IsPayPassPayWave", value);
			}
		}

		/// <summary>
		/// Expiration Date.
		/// </summary>
		public string ValidDate {
			get {
				return GetTypedColumnValue<string>("ValidDate");
			}
			set {
				SetColumnValue("ValidDate", value);
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

		/// <summary>
		/// ATM withdrawal limit.
		/// </summary>
		public Decimal CashLimit {
			get {
				return GetTypedColumnValue<Decimal>("CashLimit");
			}
			set {
				SetColumnValue("CashLimit", value);
			}
		}

		/// <summary>
		/// Debt.
		/// </summary>
		public Decimal Debt {
			get {
				return GetTypedColumnValue<Decimal>("Debt");
			}
			set {
				SetColumnValue("Debt", value);
			}
		}

		/// <summary>
		/// Pay before.
		/// </summary>
		public DateTime RepayDate {
			get {
				return GetTypedColumnValue<DateTime>("RepayDate");
			}
			set {
				SetColumnValue("RepayDate", value);
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

		#endregion

	}

	#endregion

}

