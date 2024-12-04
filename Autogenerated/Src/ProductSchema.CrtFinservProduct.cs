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

	#region Class: ProductSchema

	/// <exclude/>
	public class ProductSchema : Terrasoft.Configuration.Product_ProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductSchema(ProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductSchema(ProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			Name = "Product";
			ParentSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			ExtendParent = true;
			CreatedInPackageId = new Guid("80d7a7d4-dc00-406c-908d-df0ae7330359");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b4a1be06-79f4-4db8-b78e-95bd8fc1214d")) == null) {
				Columns.Add(CreateProductStatusColumn());
			}
			if (Columns.FindByUId(new Guid("f4adcbe0-6452-4fbc-b7c9-7ea8502d3f91")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("25f165b0-f566-4389-aed9-4720ff8487ad")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("2533bd9e-b073-4e3a-8f06-44779b3cc6fa")) == null) {
				Columns.Add(CreateProductKindColumn());
			}
			if (Columns.FindByUId(new Guid("a940ba17-0c42-4215-bb90-c3f2a86ffe8e")) == null) {
				Columns.Add(CreateInsuranceCompanyColumn());
			}
			if (Columns.FindByUId(new Guid("8d5ba09e-e1ee-4ed1-8715-6dfbc9b5bf50")) == null) {
				Columns.Add(CreateInsuranceContractNumberColumn());
			}
			if (Columns.FindByUId(new Guid("96b5f895-2517-487d-a7a4-0cc6280889e7")) == null) {
				Columns.Add(CreateInsuranceContractDateColumn());
			}
			if (Columns.FindByUId(new Guid("f196ccec-547c-4bce-8279-3fb1d511b364")) == null) {
				Columns.Add(CreateAvailableForColumn());
			}
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateUnitColumn() {
			EntitySchemaColumn column = base.CreateUnitColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateCurrencyColumn() {
			EntitySchemaColumn column = base.CreateCurrencyColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreatePriceColumn() {
			EntitySchemaColumn column = base.CreatePriceColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateURLColumn() {
			EntitySchemaColumn column = base.CreateURLColumn();
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateProductSourceColumn() {
			EntitySchemaColumn column = base.CreateProductSourceColumn();
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateCategoryColumn() {
			EntitySchemaColumn column = base.CreateCategoryColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateTradeMarkColumn() {
			EntitySchemaColumn column = base.CreateTradeMarkColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreatePictureColumn() {
			EntitySchemaColumn column = base.CreatePictureColumn();
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateIsArchiveColumn() {
			EntitySchemaColumn column = base.CreateIsArchiveColumn();
			column.ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProductStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b4a1be06-79f4-4db8-b78e-95bd8fc1214d"),
				Name = @"ProductStatus",
				ReferenceSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"ProductStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("f4adcbe0-6452-4fbc-b7c9-7ea8502d3f91"),
				Name = @"StartDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("25f165b0-f566-4389-aed9-4720ff8487ad"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84")
			};
		}

		protected virtual EntitySchemaColumn CreateProductKindColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2533bd9e-b073-4e3a-8f06-44779b3cc6fa"),
				Name = @"ProductKind",
				ReferenceSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84")
			};
		}

		protected virtual EntitySchemaColumn CreateInsuranceCompanyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a940ba17-0c42-4215-bb90-c3f2a86ffe8e"),
				Name = @"InsuranceCompany",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateInsuranceContractNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("8d5ba09e-e1ee-4ed1-8715-6dfbc9b5bf50"),
				Name = @"InsuranceContractNumber",
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateInsuranceContractDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("96b5f895-2517-487d-a7a4-0cc6280889e7"),
				Name = @"InsuranceContractDate",
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateAvailableForColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f196ccec-547c-4bce-8279-3fb1d511b364"),
				Name = @"AvailableFor",
				ReferenceSchemaUId = new Guid("f42e1f0f-94da-44b7-82e0-ba56300fac21"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				ModifiedInSchemaUId = new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"),
				CreatedInPackageId = new Guid("2a139ddd-8ae7-4248-b1b7-a5365e69a65f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Product(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Product_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9492a780-7041-49c0-8ca5-23e6751614d6"));
		}

		#endregion

	}

	#endregion

	#region Class: Product

	/// <summary>
	/// Product.
	/// </summary>
	public class Product : Terrasoft.Configuration.Product_ProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public Product(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Product";
		}

		public Product(Product source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProductStatusId {
			get {
				return GetTypedColumnValue<Guid>("ProductStatusId");
			}
			set {
				SetColumnValue("ProductStatusId", value);
				_productStatus = null;
			}
		}

		/// <exclude/>
		public string ProductStatusName {
			get {
				return GetTypedColumnValue<string>("ProductStatusName");
			}
			set {
				SetColumnValue("ProductStatusName", value);
				if (_productStatus != null) {
					_productStatus.Name = value;
				}
			}
		}

		private ProductStatus _productStatus;
		/// <summary>
		/// Status.
		/// </summary>
		public ProductStatus ProductStatus {
			get {
				return _productStatus ??
					(_productStatus = LookupColumnEntities.GetEntity("ProductStatus") as ProductStatus);
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
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <exclude/>
		public Guid ProductKindId {
			get {
				return GetTypedColumnValue<Guid>("ProductKindId");
			}
			set {
				SetColumnValue("ProductKindId", value);
				_productKind = null;
			}
		}

		/// <exclude/>
		public string ProductKindName {
			get {
				return GetTypedColumnValue<string>("ProductKindName");
			}
			set {
				SetColumnValue("ProductKindName", value);
				if (_productKind != null) {
					_productKind.Name = value;
				}
			}
		}

		private ProductKind _productKind;
		/// <summary>
		/// Class.
		/// </summary>
		public ProductKind ProductKind {
			get {
				return _productKind ??
					(_productKind = LookupColumnEntities.GetEntity("ProductKind") as ProductKind);
			}
		}

		/// <exclude/>
		public Guid InsuranceCompanyId {
			get {
				return GetTypedColumnValue<Guid>("InsuranceCompanyId");
			}
			set {
				SetColumnValue("InsuranceCompanyId", value);
				_insuranceCompany = null;
			}
		}

		/// <exclude/>
		public string InsuranceCompanyName {
			get {
				return GetTypedColumnValue<string>("InsuranceCompanyName");
			}
			set {
				SetColumnValue("InsuranceCompanyName", value);
				if (_insuranceCompany != null) {
					_insuranceCompany.Name = value;
				}
			}
		}

		private Account _insuranceCompany;
		/// <summary>
		/// Insurance company.
		/// </summary>
		public Account InsuranceCompany {
			get {
				return _insuranceCompany ??
					(_insuranceCompany = LookupColumnEntities.GetEntity("InsuranceCompany") as Account);
			}
		}

		/// <summary>
		/// Contract number.
		/// </summary>
		public string InsuranceContractNumber {
			get {
				return GetTypedColumnValue<string>("InsuranceContractNumber");
			}
			set {
				SetColumnValue("InsuranceContractNumber", value);
			}
		}

		/// <summary>
		/// Contract date.
		/// </summary>
		public DateTime InsuranceContractDate {
			get {
				return GetTypedColumnValue<DateTime>("InsuranceContractDate");
			}
			set {
				SetColumnValue("InsuranceContractDate", value);
			}
		}

		/// <exclude/>
		public Guid AvailableForId {
			get {
				return GetTypedColumnValue<Guid>("AvailableForId");
			}
			set {
				SetColumnValue("AvailableForId", value);
				_availableFor = null;
			}
		}

		/// <exclude/>
		public string AvailableForName {
			get {
				return GetTypedColumnValue<string>("AvailableForName");
			}
			set {
				SetColumnValue("AvailableForName", value);
				if (_availableFor != null) {
					_availableFor.Name = value;
				}
			}
		}

		private ClientTypeForProduct _availableFor;
		/// <summary>
		/// Available for.
		/// </summary>
		public ClientTypeForProduct AvailableFor {
			get {
				return _availableFor ??
					(_availableFor = LookupColumnEntities.GetEntity("AvailableFor") as ClientTypeForProduct);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Product_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductDeleted", e);
			Deleting += (s, e) => ThrowEvent("ProductDeleting", e);
			Inserted += (s, e) => ThrowEvent("ProductInserted", e);
			Inserting += (s, e) => ThrowEvent("ProductInserting", e);
			Saved += (s, e) => ThrowEvent("ProductSaved", e);
			Saving += (s, e) => ThrowEvent("ProductSaving", e);
			Updating += (s, e) => ThrowEvent("ProductUpdating", e);
			Validating += (s, e) => ThrowEvent("ProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Product(this);
		}

		#endregion

	}

	#endregion

	#region Class: Product_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class Product_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.Product_ProductCatalogueEventsProcess<TEntity> where TEntity : Product
	{

		public Product_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Product_CrtFinservProductEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9492a780-7041-49c0-8ca5-23e6751614d6");
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

	#region Class: Product_CrtFinservProductEventsProcess

	/// <exclude/>
	public class Product_CrtFinservProductEventsProcess : Product_CrtFinservProductEventsProcess<Product>
	{

		public Product_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Product_CrtFinservProductEventsProcess

	public partial class Product_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductEventsProcess

	/// <exclude/>
	public class ProductEventsProcess : Product_CrtFinservProductEventsProcess
	{

		public ProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

