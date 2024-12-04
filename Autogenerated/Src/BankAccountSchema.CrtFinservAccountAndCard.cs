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

	#region Class: BankAccountSchema

	/// <exclude/>
	public class BankAccountSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BankAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankAccountSchema(BankAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankAccountSchema(BankAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			RealUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			Name = "BankAccount";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateBankAccountNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3d4ce499-7cb6-4c5f-818b-b33ad6b8f991")) == null) {
				Columns.Add(CreateContractColumn());
			}
			if (Columns.FindByUId(new Guid("3a938775-3c7e-41e4-b73f-1cb7655dc93f")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("3d6e7f5f-8aa3-464c-9e9a-982a7db32050")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("8fc06efc-d7c6-4c00-aaa7-f4a78c73b6fa")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("b5e9c7b1-58ef-4c72-9604-87adbc72bd99")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("475c73a8-ff1e-4044-925c-e914ef56f740")) == null) {
				Columns.Add(CreateBalanceColumn());
			}
			if (Columns.FindByUId(new Guid("a0021cef-fca7-466e-932e-fe4b32d43273")) == null) {
				Columns.Add(CreateBranchColumn());
			}
			if (Columns.FindByUId(new Guid("6061a9e6-30a6-48de-b11e-e9e60d5a271d")) == null) {
				Columns.Add(CreateDivisionColumn());
			}
			if (Columns.FindByUId(new Guid("63215dd0-bced-47a3-9005-69535e131210")) == null) {
				Columns.Add(CreateOpenedOnColumn());
			}
			if (Columns.FindByUId(new Guid("d2131d24-2227-4233-804f-f83b917de418")) == null) {
				Columns.Add(CreateActivatedOnColumn());
			}
			if (Columns.FindByUId(new Guid("281282d3-06dd-497c-9b87-3c0f150667d4")) == null) {
				Columns.Add(CreateClosedOnColumn());
			}
			if (Columns.FindByUId(new Guid("727e18f9-ddb7-494a-9ae8-1fc300b6bcba")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("992b2fa3-875b-4181-9d12-6ac6ae27fe79")) == null) {
				Columns.Add(CreateReasonForClosingColumn());
			}
			if (Columns.FindByUId(new Guid("0256129c-bb9b-43d2-b066-f9bffaba993f")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("85484af7-f4a4-4208-90c7-0d5931f61d14")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("97bd1190-5190-405c-b575-f034fef94d96")) == null) {
				Columns.Add(CreatePackageColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBankAccountNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("47005a48-9e25-425c-b9c4-e12eb5619018"),
				Name = @"BankAccountNumber",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3d4ce499-7cb6-4c5f-818b-b33ad6b8f991"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3a938775-3c7e-41e4-b73f-1cb7655dc93f"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3d6e7f5f-8aa3-464c-9e9a-982a7db32050"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8fc06efc-d7c6-4c00-aaa7-f4a78c73b6fa"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b5e9c7b1-58ef-4c72-9604-87adbc72bd99"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateBalanceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("475c73a8-ff1e-4044-925c-e914ef56f740"),
				Name = @"Balance",
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateBranchColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a0021cef-fca7-466e-932e-fe4b32d43273"),
				Name = @"Branch",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateDivisionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6061a9e6-30a6-48de-b11e-e9e60d5a271d"),
				Name = @"Division",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateOpenedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("63215dd0-bced-47a3-9005-69535e131210"),
				Name = @"OpenedOn",
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateActivatedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("d2131d24-2227-4233-804f-f83b917de418"),
				Name = @"ActivatedOn",
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateClosedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("281282d3-06dd-497c-9b87-3c0f150667d4"),
				Name = @"ClosedOn",
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("727e18f9-ddb7-494a-9ae8-1fc300b6bcba"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("7412d125-768b-4241-9017-ad11719b4b4b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"BankAccountStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateReasonForClosingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("992b2fa3-875b-4181-9d12-6ac6ae27fe79"),
				Name = @"ReasonForClosing",
				ReferenceSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0256129c-bb9b-43d2-b066-f9bffaba993f"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("5d26fdfd-3a28-4603-be3a-a8ccec3de2ff"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("85484af7-f4a4-4208-90c7-0d5931f61d14"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("57f657cd-d3d2-4266-ab50-03132e24522a")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("97bd1190-5190-405c-b575-f034fef94d96"),
				Name = @"Package",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				ModifiedInSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankAccount_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e07b87f-6425-4de2-bae2-663576293e82"));
		}

		#endregion

	}

	#endregion

	#region Class: BankAccount

	/// <summary>
	/// Financial account.
	/// </summary>
	public class BankAccount : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BankAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankAccount";
		}

		public BankAccount(BankAccount source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Account number.
		/// </summary>
		public string BankAccountNumber {
			get {
				return GetTypedColumnValue<string>("BankAccountNumber");
			}
			set {
				SetColumnValue("BankAccountNumber", value);
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
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
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
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
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

		private BankAccountType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public BankAccountType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as BankAccountType);
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
					(_branch = LookupColumnEntities.GetEntity("Branch") as Account);
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
					(_division = LookupColumnEntities.GetEntity("Division") as Account);
			}
		}

		/// <summary>
		/// Opened on.
		/// </summary>
		public DateTime OpenedOn {
			get {
				return GetTypedColumnValue<DateTime>("OpenedOn");
			}
			set {
				SetColumnValue("OpenedOn", value);
			}
		}

		/// <summary>
		/// Activated on.
		/// </summary>
		public DateTime ActivatedOn {
			get {
				return GetTypedColumnValue<DateTime>("ActivatedOn");
			}
			set {
				SetColumnValue("ActivatedOn", value);
			}
		}

		/// <summary>
		/// Closed on.
		/// </summary>
		public DateTime ClosedOn {
			get {
				return GetTypedColumnValue<DateTime>("ClosedOn");
			}
			set {
				SetColumnValue("ClosedOn", value);
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

		private BankAccountStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public BankAccountStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as BankAccountStatus);
			}
		}

		/// <exclude/>
		public Guid ReasonForClosingId {
			get {
				return GetTypedColumnValue<Guid>("ReasonForClosingId");
			}
			set {
				SetColumnValue("ReasonForClosingId", value);
				_reasonForClosing = null;
			}
		}

		/// <exclude/>
		public string ReasonForClosingName {
			get {
				return GetTypedColumnValue<string>("ReasonForClosingName");
			}
			set {
				SetColumnValue("ReasonForClosingName", value);
				if (_reasonForClosing != null) {
					_reasonForClosing.Name = value;
				}
			}
		}

		private BankAccountCloseReason _reasonForClosing;
		/// <summary>
		/// Reason for closing.
		/// </summary>
		public BankAccountCloseReason ReasonForClosing {
			get {
				return _reasonForClosing ??
					(_reasonForClosing = LookupColumnEntities.GetEntity("ReasonForClosing") as BankAccountCloseReason);
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
					(_package = LookupColumnEntities.GetEntity("Package") as Product);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankAccount_CrtFinservAccountAndCardEventsProcess(UserConnection);
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
			return new BankAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankAccount_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankAccount_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BankAccount
	{

		public BankAccount_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankAccount_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
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

	#region Class: BankAccount_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankAccount_CrtFinservAccountAndCardEventsProcess : BankAccount_CrtFinservAccountAndCardEventsProcess<BankAccount>
	{

		public BankAccount_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankAccount_CrtFinservAccountAndCardEventsProcess

	public partial class BankAccount_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankAccountEventsProcess

	/// <exclude/>
	public class BankAccountEventsProcess : BankAccount_CrtFinservAccountAndCardEventsProcess
	{

		public BankAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

