namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FinApplication

	/// <exclude/>
	public class FinApplication : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public FinApplication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplication";
		}

		public FinApplication(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "FinApplication";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<AppForm> AppFormCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<AppValidation> AppValidationCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<DocListInFinApp> DocListInFinAppCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<FinApplicationFile> FinApplicationFileCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<FinApplicationInFolder> FinApplicationInFolderCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<FinApplicationInTag> FinApplicationInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<FinApplicationSpec> FinApplicationSpecCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<SpecInherited> SpecInheritedCollectionByFinApplication {
			get;
			set;
		}

		public IEnumerable<VwQueueItem> VwQueueItemCollectionByFinApplication {
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
		/// Registration date.
		/// </summary>
		public DateTime FillingDate {
			get {
				return GetTypedColumnValue<DateTime>("FillingDate");
			}
			set {
				SetColumnValue("FillingDate", value);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private FinAppStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public FinAppStatus Status {
			get {
				return _status ??
					(_status = new FinAppStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <exclude/>
		public Guid DecisionId {
			get {
				return GetTypedColumnValue<Guid>("DecisionId");
			}
			set {
				SetColumnValue("DecisionId", value);
				_decision = null;
			}
		}

		/// <exclude/>
		public string DecisionName {
			get {
				return GetTypedColumnValue<string>("DecisionName");
			}
			set {
				SetColumnValue("DecisionName", value);
				if (_decision != null) {
					_decision.Name = value;
				}
			}
		}

		private FinAppDecision _decision;
		/// <summary>
		/// Decision.
		/// </summary>
		public FinAppDecision Decision {
			get {
				return _decision ??
					(_decision = new FinAppDecision(LookupColumnEntities.GetEntity("Decision")));
			}
		}

		/// <summary>
		/// Decision date.
		/// </summary>
		public DateTime DecisionDate {
			get {
				return GetTypedColumnValue<DateTime>("DecisionDate");
			}
			set {
				SetColumnValue("DecisionDate", value);
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
		/// Branch.
		/// </summary>
		public Account Division {
			get {
				return _division ??
					(_division = new Account(LookupColumnEntities.GetEntity("Division")));
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
		/// Office.
		/// </summary>
		public Account Branch {
			get {
				return _branch ??
					(_branch = new Account(LookupColumnEntities.GetEntity("Branch")));
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
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private ApplicationOrigin _source;
		/// <summary>
		/// Source.
		/// </summary>
		public ApplicationOrigin Source {
			get {
				return _source ??
					(_source = new ApplicationOrigin(LookupColumnEntities.GetEntity("Source")));
			}
		}

		/// <exclude/>
		public Guid ProductCategoryId {
			get {
				return GetTypedColumnValue<Guid>("ProductCategoryId");
			}
			set {
				SetColumnValue("ProductCategoryId", value);
				_productCategory = null;
			}
		}

		/// <exclude/>
		public string ProductCategoryName {
			get {
				return GetTypedColumnValue<string>("ProductCategoryName");
			}
			set {
				SetColumnValue("ProductCategoryName", value);
				if (_productCategory != null) {
					_productCategory.Name = value;
				}
			}
		}

		private ProductCategory _productCategory;
		/// <summary>
		/// Product category.
		/// </summary>
		public ProductCategory ProductCategory {
			get {
				return _productCategory ??
					(_productCategory = new ProductCategory(LookupColumnEntities.GetEntity("ProductCategory")));
			}
		}

		/// <exclude/>
		public Guid ProductTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeId");
			}
			set {
				SetColumnValue("ProductTypeId", value);
				_productType = null;
			}
		}

		/// <exclude/>
		public string ProductTypeName {
			get {
				return GetTypedColumnValue<string>("ProductTypeName");
			}
			set {
				SetColumnValue("ProductTypeName", value);
				if (_productType != null) {
					_productType.Name = value;
				}
			}
		}

		private ProductType _productType;
		/// <summary>
		/// Product type.
		/// </summary>
		public ProductType ProductType {
			get {
				return _productType ??
					(_productType = new ProductType(LookupColumnEntities.GetEntity("ProductType")));
			}
		}

		/// <exclude/>
		public Guid OpportunityConditionId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityConditionId");
			}
			set {
				SetColumnValue("OpportunityConditionId", value);
				_opportunityCondition = null;
			}
		}

		/// <exclude/>
		public string OpportunityConditionName {
			get {
				return GetTypedColumnValue<string>("OpportunityConditionName");
			}
			set {
				SetColumnValue("OpportunityConditionName", value);
				if (_opportunityCondition != null) {
					_opportunityCondition.Name = value;
				}
			}
		}

		private OpportunityCondition _opportunityCondition;
		/// <summary>
		/// Opportunity condition.
		/// </summary>
		public OpportunityCondition OpportunityCondition {
			get {
				return _opportunityCondition ??
					(_opportunityCondition = new OpportunityCondition(LookupColumnEntities.GetEntity("OpportunityCondition")));
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
		public Guid StageId {
			get {
				return GetTypedColumnValue<Guid>("StageId");
			}
			set {
				SetColumnValue("StageId", value);
				_stage = null;
			}
		}

		/// <exclude/>
		public string StageName {
			get {
				return GetTypedColumnValue<string>("StageName");
			}
			set {
				SetColumnValue("StageName", value);
				if (_stage != null) {
					_stage.Name = value;
				}
			}
		}

		private FinAppStage _stage;
		/// <summary>
		/// Stage.
		/// </summary>
		public FinAppStage Stage {
			get {
				return _stage ??
					(_stage = new FinAppStage(LookupColumnEntities.GetEntity("Stage")));
			}
		}

		/// <exclude/>
		public Guid CaseId {
			get {
				return GetTypedColumnValue<Guid>("CaseId");
			}
			set {
				SetColumnValue("CaseId", value);
				_case = null;
			}
		}

		/// <exclude/>
		public string CaseNumber {
			get {
				return GetTypedColumnValue<string>("CaseNumber");
			}
			set {
				SetColumnValue("CaseNumber", value);
				if (_case != null) {
					_case.Number = value;
				}
			}
		}

		private Case _case;
		/// <summary>
		/// Case.
		/// </summary>
		public Case Case {
			get {
				return _case ??
					(_case = new Case(LookupColumnEntities.GetEntity("Case")));
			}
		}

		/// <exclude/>
		public Guid PhotoId {
			get {
				return GetTypedColumnValue<Guid>("PhotoId");
			}
			set {
				SetColumnValue("PhotoId", value);
				_photo = null;
			}
		}

		/// <exclude/>
		public string PhotoName {
			get {
				return GetTypedColumnValue<string>("PhotoName");
			}
			set {
				SetColumnValue("PhotoName", value);
				if (_photo != null) {
					_photo.Name = value;
				}
			}
		}

		private SysImage _photo;
		/// <summary>
		/// Photo.
		/// </summary>
		public SysImage Photo {
			get {
				return _photo ??
					(_photo = new SysImage(LookupColumnEntities.GetEntity("Photo")));
			}
		}

		/// <exclude/>
		public Guid ApproverId {
			get {
				return GetTypedColumnValue<Guid>("ApproverId");
			}
			set {
				SetColumnValue("ApproverId", value);
				_approver = null;
			}
		}

		/// <exclude/>
		public string ApproverName {
			get {
				return GetTypedColumnValue<string>("ApproverName");
			}
			set {
				SetColumnValue("ApproverName", value);
				if (_approver != null) {
					_approver.Name = value;
				}
			}
		}

		private Contact _approver;
		/// <summary>
		/// Decision maker.
		/// </summary>
		public Contact Approver {
			get {
				return _approver ??
					(_approver = new Contact(LookupColumnEntities.GetEntity("Approver")));
			}
		}

		#endregion

	}

	#endregion

}

