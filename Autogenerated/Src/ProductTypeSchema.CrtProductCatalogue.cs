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

	#region Class: ProductType_CrtProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class ProductType_CrtProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.ProductType_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductType_CrtProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductType_CrtProductCatalogue_TerrasoftSchema(ProductType_CrtProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductType_CrtProductCatalogue_TerrasoftSchema(ProductType_CrtProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("eeb575f1-edb7-4278-a702-680b7b8fd545");
			Name = "ProductType_CrtProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("694a7a4e-a952-4163-a0ce-df045e72aedb")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("694a7a4e-a952-4163-a0ce-df045e72aedb"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("eeb575f1-edb7-4278-a702-680b7b8fd545"),
				ModifiedInSchemaUId = new Guid("eeb575f1-edb7-4278-a702-680b7b8fd545"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductType_CrtProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductType_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductType_CrtProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductType_CrtProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eeb575f1-edb7-4278-a702-680b7b8fd545"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductType_CrtProductCatalogue_Terrasoft

	/// <summary>
	/// Product type.
	/// </summary>
	public class ProductType_CrtProductCatalogue_Terrasoft : Terrasoft.Configuration.ProductType_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ProductType_CrtProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductType_CrtProductCatalogue_Terrasoft";
		}

		public ProductType_CrtProductCatalogue_Terrasoft(ProductType_CrtProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private ProductCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public ProductCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as ProductCategory);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductType_CrtProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductType_CrtProductCatalogue_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ProductType_CrtProductCatalogue_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ProductType_CrtProductCatalogue_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ProductType_CrtProductCatalogue_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ProductType_CrtProductCatalogue_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ProductType_CrtProductCatalogue_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ProductType_CrtProductCatalogue_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductType_CrtProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductType_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductType_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.ProductType_CrtBaseEventsProcess<TEntity> where TEntity : ProductType_CrtProductCatalogue_Terrasoft
	{

		public ProductType_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductType_CrtProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eeb575f1-edb7-4278-a702-680b7b8fd545");
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

	#region Class: ProductType_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductType_CrtProductCatalogueEventsProcess : ProductType_CrtProductCatalogueEventsProcess<ProductType_CrtProductCatalogue_Terrasoft>
	{

		public ProductType_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductType_CrtProductCatalogueEventsProcess

	public partial class ProductType_CrtProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

