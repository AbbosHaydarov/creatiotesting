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

	#region Class: ProductKindSchema

	/// <exclude/>
	public class ProductKindSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ProductKindSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductKindSchema(ProductKindSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductKindSchema(ProductKindSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			RealUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			Name = "ProductKind";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cbeda629-452a-490a-b8a9-cee32d6438f0")) == null) {
				Columns.Add(CreateProductTypeColumn());
			}
			if (Columns.FindByUId(new Guid("0288bfe1-c817-4dca-8d66-08897643e534")) == null) {
				Columns.Add(CreateProductCategoryColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProductTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cbeda629-452a-490a-b8a9-cee32d6438f0"),
				Name = @"ProductType",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe"),
				ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe"),
				CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84")
			};
		}

		protected virtual EntitySchemaColumn CreateProductCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0288bfe1-c817-4dca-8d66-08897643e534"),
				Name = @"ProductCategory",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe"),
				ModifiedInSchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe"),
				CreatedInPackageId = new Guid("658cb129-ae5e-47a4-88ad-ee3738e78e43")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductKind(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductKind_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductKindSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductKindSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductKind

	/// <summary>
	/// Product class.
	/// </summary>
	public class ProductKind : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ProductKind(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductKind";
		}

		public ProductKind(ProductKind source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
					(_productType = LookupColumnEntities.GetEntity("ProductType") as ProductType);
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
					(_productCategory = LookupColumnEntities.GetEntity("ProductCategory") as ProductCategory);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductKind_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductKindDeleted", e);
			Saving += (s, e) => ThrowEvent("ProductKindSaving", e);
			Validating += (s, e) => ThrowEvent("ProductKindValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductKind(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductKind_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ProductKind_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ProductKind
	{

		public ProductKind_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductKind_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77b7a77d-429f-4f46-baa3-e24322684ebe");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("1a44c9e4-d358-4b02-9637-78bd8edaad1d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("3e972505-c3bd-4bab-b9e5-9efd5d07f6ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("6f14dff2-033b-4703-a11a-d5700b76ca79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			SetProductCategory();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProductKindSaving":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ProductKind_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ProductKind_CrtFinservProductEventsProcess : ProductKind_CrtFinservProductEventsProcess<ProductKind>
	{

		public ProductKind_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductKind_CrtFinservProductEventsProcess

	public partial class ProductKind_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void SetProductCategory() {
			EntitySchemaQuery productTypeEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ProductType");
			productTypeEsq.AddColumn(productTypeEsq.RootSchema.GetPrimaryColumnName());
			productTypeEsq.AddColumn("Category");
			Guid productTypeId = Entity.GetTypedColumnValue<Guid>("ProductTypeId");
			Entity productTypeEntity = productTypeEsq.GetEntity(UserConnection, productTypeId);
			if (productTypeEntity != null) {
				Guid categoryId = productTypeEntity.GetTypedColumnValue<Guid>("CategoryId");
				Entity.SetColumnValue("ProductCategoryId", categoryId);
			}
		}

		#endregion

	}

	#endregion


	#region Class: ProductKindEventsProcess

	/// <exclude/>
	public class ProductKindEventsProcess : ProductKind_CrtFinservProductEventsProcess
	{

		public ProductKindEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

