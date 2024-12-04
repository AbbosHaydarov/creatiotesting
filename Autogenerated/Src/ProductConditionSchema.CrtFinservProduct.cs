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

	#region Class: ProductConditionSchema

	/// <exclude/>
	public class ProductConditionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProductConditionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductConditionSchema(ProductConditionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductConditionSchema(ProductConditionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9");
			RealUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9");
			Name = "ProductCondition";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("98adf260-e95d-43dc-8982-bd8751d1a3a5")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("063076ce-ad20-4a31-8b8c-6534d08424b8")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("55c6be8b-7e56-4b2a-855a-91672fe3330b")) == null) {
				Columns.Add(CreateProductColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("30d54b01-c95b-4d9c-95b1-ad4df46bef67"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				ModifiedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("98adf260-e95d-43dc-8982-bd8751d1a3a5"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				ModifiedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("063076ce-ad20-4a31-8b8c-6534d08424b8"),
				Name = @"DueDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				ModifiedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("55c6be8b-7e56-4b2a-855a-91672fe3330b"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				ModifiedInSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductCondition(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductCondition_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductConditionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductConditionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductCondition

	/// <summary>
	/// Product detail.
	/// </summary>
	public class ProductCondition : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProductCondition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCondition";
		}

		public ProductCondition(ProductCondition source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductCondition_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductConditionDeleted", e);
			Validating += (s, e) => ThrowEvent("ProductConditionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCondition(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ProductCondition_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ProductCondition
	{

		public ProductCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCondition_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eecaf746-82f5-428e-947e-169fce01cbd9");
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

	#region Class: ProductCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ProductCondition_CrtFinservProductEventsProcess : ProductCondition_CrtFinservProductEventsProcess<ProductCondition>
	{

		public ProductCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: ProductConditionEventsProcess

	/// <exclude/>
	public class ProductConditionEventsProcess : ProductCondition_CrtFinservProductEventsProcess
	{

		public ProductConditionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

