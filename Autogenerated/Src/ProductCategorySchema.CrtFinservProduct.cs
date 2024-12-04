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

	#region Class: ProductCategorySchema

	/// <exclude/>
	public class ProductCategorySchema : Terrasoft.Configuration.ProductCategory_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductCategorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductCategorySchema(ProductCategorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductCategorySchema(ProductCategorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("abd7854e-5954-4b42-8170-f68cdc864148");
			Name = "ProductCategory";
			ParentSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			ExtendParent = true;
			CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("97c3416f-aac9-44b7-855c-fd30074cfd4f")) == null) {
				Columns.Add(CreateKindColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateKindColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("97c3416f-aac9-44b7-855c-fd30074cfd4f"),
				Name = @"Kind",
				ReferenceSchemaUId = new Guid("3791f0e6-eea3-423f-9bd3-1f139861eb13"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("abd7854e-5954-4b42-8170-f68cdc864148"),
				ModifiedInSchemaUId = new Guid("abd7854e-5954-4b42-8170-f68cdc864148"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"97ec93bc-2a91-4dde-8a8b-34a0d7155de0"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductCategory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductCategory_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductCategorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductCategorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("abd7854e-5954-4b42-8170-f68cdc864148"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductCategory

	/// <summary>
	/// Product category.
	/// </summary>
	public class ProductCategory : Terrasoft.Configuration.ProductCategory_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public ProductCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCategory";
		}

		public ProductCategory(ProductCategory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid KindId {
			get {
				return GetTypedColumnValue<Guid>("KindId");
			}
			set {
				SetColumnValue("KindId", value);
				_kind = null;
			}
		}

		/// <exclude/>
		public string KindName {
			get {
				return GetTypedColumnValue<string>("KindName");
			}
			set {
				SetColumnValue("KindName", value);
				if (_kind != null) {
					_kind.Name = value;
				}
			}
		}

		private ProductCategoryKind _kind;
		/// <summary>
		/// Class.
		/// </summary>
		public ProductCategoryKind Kind {
			get {
				return _kind ??
					(_kind = LookupColumnEntities.GetEntity("Kind") as ProductCategoryKind);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductCategory_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductCategoryDeleted", e);
			Deleting += (s, e) => ThrowEvent("ProductCategoryDeleting", e);
			Inserted += (s, e) => ThrowEvent("ProductCategoryInserted", e);
			Saved += (s, e) => ThrowEvent("ProductCategorySaved", e);
			Saving += (s, e) => ThrowEvent("ProductCategorySaving", e);
			Validating += (s, e) => ThrowEvent("ProductCategoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCategory(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCategory_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ProductCategory_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.ProductCategory_CrtProductCatalogueEventsProcess<TEntity> where TEntity : ProductCategory
	{

		public ProductCategory_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCategory_CrtFinservProductEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("abd7854e-5954-4b42-8170-f68cdc864148");
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

	#region Class: ProductCategory_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ProductCategory_CrtFinservProductEventsProcess : ProductCategory_CrtFinservProductEventsProcess<ProductCategory>
	{

		public ProductCategory_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCategory_CrtFinservProductEventsProcess

	public partial class ProductCategory_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductCategoryEventsProcess

	/// <exclude/>
	public class ProductCategoryEventsProcess : ProductCategory_CrtFinservProductEventsProcess
	{

		public ProductCategoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

