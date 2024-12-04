namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Contract

	/// <exclude/>
	public class Contract : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Contract(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contract";
		}

		public Contract(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Contract";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByContract {
			get;
			set;
		}

		public IEnumerable<BankAccount> BankAccountCollectionByContract {
			get;
			set;
		}

		public IEnumerable<BankCard> BankCardCollectionByContract {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ContractFile> ContractFileCollectionByContract {
			get;
			set;
		}

		public IEnumerable<ContractInFolder> ContractInFolderCollectionByContract {
			get;
			set;
		}

		public IEnumerable<ContractInTag> ContractInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ContractVisa> ContractVisaCollectionByContract {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByContract {
			get;
			set;
		}

		public IEnumerable<FinApplication> FinApplicationCollectionByContract {
			get;
			set;
		}

		public IEnumerable<ProductInContract> ProductInContractCollectionByContract {
			get;
			set;
		}

		public IEnumerable<SpecificationInContract> SpecificationInContractCollectionByContract {
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

		/// <summary>
		/// Start date.
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
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private ContractType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ContractType Type {
			get {
				return _type ??
					(_type = new ContractType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private ContractState _state;
		/// <summary>
		/// Status.
		/// </summary>
		public ContractState State {
			get {
				return _state ??
					(_state = new ContractState(LookupColumnEntities.GetEntity("State")));
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

		/// <exclude/>
		public Guid SupplierBillingInfoId {
			get {
				return GetTypedColumnValue<Guid>("SupplierBillingInfoId");
			}
			set {
				SetColumnValue("SupplierBillingInfoId", value);
				_supplierBillingInfo = null;
			}
		}

		/// <exclude/>
		public string SupplierBillingInfoName {
			get {
				return GetTypedColumnValue<string>("SupplierBillingInfoName");
			}
			set {
				SetColumnValue("SupplierBillingInfoName", value);
				if (_supplierBillingInfo != null) {
					_supplierBillingInfo.Name = value;
				}
			}
		}

		private AccountBillingInfo _supplierBillingInfo;
		/// <summary>
		/// Our banking details.
		/// </summary>
		public AccountBillingInfo SupplierBillingInfo {
			get {
				return _supplierBillingInfo ??
					(_supplierBillingInfo = new AccountBillingInfo(LookupColumnEntities.GetEntity("SupplierBillingInfo")));
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = new Contact(LookupColumnEntities.GetEntity("Owner")));
			}
		}

		/// <exclude/>
		public Guid CustomerBillingInfoId {
			get {
				return GetTypedColumnValue<Guid>("CustomerBillingInfoId");
			}
			set {
				SetColumnValue("CustomerBillingInfoId", value);
				_customerBillingInfo = null;
			}
		}

		/// <exclude/>
		public string CustomerBillingInfoName {
			get {
				return GetTypedColumnValue<string>("CustomerBillingInfoName");
			}
			set {
				SetColumnValue("CustomerBillingInfoName", value);
				if (_customerBillingInfo != null) {
					_customerBillingInfo.Name = value;
				}
			}
		}

		private AccountBillingInfo _customerBillingInfo;
		/// <summary>
		/// Legal entity banking details.
		/// </summary>
		public AccountBillingInfo CustomerBillingInfo {
			get {
				return _customerBillingInfo ??
					(_customerBillingInfo = new AccountBillingInfo(LookupColumnEntities.GetEntity("CustomerBillingInfo")));
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
		/// Contact person.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = new Contact(LookupColumnEntities.GetEntity("Contact")));
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
		public string ParentNumber {
			get {
				return GetTypedColumnValue<string>("ParentNumber");
			}
			set {
				SetColumnValue("ParentNumber", value);
				if (_parent != null) {
					_parent.Number = value;
				}
			}
		}

		private Contract _parent;
		/// <summary>
		/// Parent contract.
		/// </summary>
		public Contract Parent {
			get {
				return _parent ??
					(_parent = new Contract(LookupColumnEntities.GetEntity("Parent")));
			}
		}

		/// <exclude/>
		public Guid OurCompanyId {
			get {
				return GetTypedColumnValue<Guid>("OurCompanyId");
			}
			set {
				SetColumnValue("OurCompanyId", value);
				_ourCompany = null;
			}
		}

		/// <exclude/>
		public string OurCompanyName {
			get {
				return GetTypedColumnValue<string>("OurCompanyName");
			}
			set {
				SetColumnValue("OurCompanyName", value);
				if (_ourCompany != null) {
					_ourCompany.Name = value;
				}
			}
		}

		private Account _ourCompany;
		/// <summary>
		/// Branch.
		/// </summary>
		public Account OurCompany {
			get {
				return _ourCompany ??
					(_ourCompany = new Account(LookupColumnEntities.GetEntity("OurCompany")));
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
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = new Opportunity(LookupColumnEntities.GetEntity("Opportunity")));
			}
		}

		/// <summary>
		/// Signed on.
		/// </summary>
		public DateTime SigningDate {
			get {
				return GetTypedColumnValue<DateTime>("SigningDate");
			}
			set {
				SetColumnValue("SigningDate", value);
			}
		}

		/// <exclude/>
		public Guid FinApplicationId {
			get {
				return GetTypedColumnValue<Guid>("FinApplicationId");
			}
			set {
				SetColumnValue("FinApplicationId", value);
				_finApplication = null;
			}
		}

		/// <exclude/>
		public string FinApplicationNumber {
			get {
				return GetTypedColumnValue<string>("FinApplicationNumber");
			}
			set {
				SetColumnValue("FinApplicationNumber", value);
				if (_finApplication != null) {
					_finApplication.Number = value;
				}
			}
		}

		private FinApplication _finApplication;
		/// <summary>
		/// Application.
		/// </summary>
		public FinApplication FinApplication {
			get {
				return _finApplication ??
					(_finApplication = new FinApplication(LookupColumnEntities.GetEntity("FinApplication")));
			}
		}

		/// <exclude/>
		public Guid ContactContractId {
			get {
				return GetTypedColumnValue<Guid>("ContactContractId");
			}
			set {
				SetColumnValue("ContactContractId", value);
				_contactContract = null;
			}
		}

		/// <exclude/>
		public string ContactContractName {
			get {
				return GetTypedColumnValue<string>("ContactContractName");
			}
			set {
				SetColumnValue("ContactContractName", value);
				if (_contactContract != null) {
					_contactContract.Name = value;
				}
			}
		}

		private Contact _contactContract;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact ContactContract {
			get {
				return _contactContract ??
					(_contactContract = new Contact(LookupColumnEntities.GetEntity("ContactContract")));
			}
		}

		/// <exclude/>
		public Guid DepartmentId {
			get {
				return GetTypedColumnValue<Guid>("DepartmentId");
			}
			set {
				SetColumnValue("DepartmentId", value);
				_department = null;
			}
		}

		/// <exclude/>
		public string DepartmentName {
			get {
				return GetTypedColumnValue<string>("DepartmentName");
			}
			set {
				SetColumnValue("DepartmentName", value);
				if (_department != null) {
					_department.Name = value;
				}
			}
		}

		private Account _department;
		/// <summary>
		/// Office.
		/// </summary>
		public Account Department {
			get {
				return _department ??
					(_department = new Account(LookupColumnEntities.GetEntity("Department")));
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
		/// Created from order.
		/// </summary>
		public bool CreatedFromOrder {
			get {
				return GetTypedColumnValue<bool>("CreatedFromOrder");
			}
			set {
				SetColumnValue("CreatedFromOrder", value);
			}
		}

		#endregion

	}

	#endregion

}

