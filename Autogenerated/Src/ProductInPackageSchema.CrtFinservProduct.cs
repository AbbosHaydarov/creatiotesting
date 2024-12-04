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

	#region Class: ProductInPackageSchema

	/// <exclude/>
	public class ProductInPackageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProductInPackageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductInPackageSchema(ProductInPackageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductInPackageSchema(ProductInPackageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d947844-746a-4c48-a90f-84595a6df92d");
			RealUId = new Guid("4d947844-746a-4c48-a90f-84595a6df92d");
			Name = "ProductInPackage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f9386fb2-73ff-4b60-802b-8cb8594e1b7b")) == null) {
				Columns.Add(CreatePackageColumn());
			}
			if (Columns.FindByUId(new Guid("9a980674-170c-463c-8f20-2b615cc798b3")) == null) {
				Columns.Add(CreateProductColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f9386fb2-73ff-4b60-802b-8cb8594e1b7b"),
				Name = @"Package",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("4d947844-746a-4c48-a90f-84595a6df92d"),
				ModifiedInSchemaUId = new Guid("4d947844-746a-4c48-a90f-84595a6df92d"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9a980674-170c-463c-8f20-2b615cc798b3"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4d947844-746a-4c48-a90f-84595a6df92d"),
				ModifiedInSchemaUId = new Guid("4d947844-746a-4c48-a90f-84595a6df92d"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductInPackage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductInPackage_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductInPackageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductInPackageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d947844-746a-4c48-a90f-84595a6df92d"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductInPackage

	/// <summary>
	/// Product in service package.
	/// </summary>
	public class ProductInPackage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProductInPackage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductInPackage";
		}

		public ProductInPackage(ProductInPackage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Service package.
		/// </summary>
		public Product Package {
			get {
				return _package ??
					(_package = LookupColumnEntities.GetEntity("Package") as Product);
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
			var process = new ProductInPackage_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductInPackageDeleted", e);
			Validating += (s, e) => ThrowEvent("ProductInPackageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductInPackage(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductInPackage_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ProductInPackage_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ProductInPackage
	{

		public ProductInPackage_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductInPackage_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("4d947844-746a-4c48-a90f-84595a6df92d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4d947844-746a-4c48-a90f-84595a6df92d");
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

	#region Class: ProductInPackage_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ProductInPackage_CrtFinservProductEventsProcess : ProductInPackage_CrtFinservProductEventsProcess<ProductInPackage>
	{

		public ProductInPackage_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductInPackage_CrtFinservProductEventsProcess

	public partial class ProductInPackage_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductInPackageEventsProcess

	/// <exclude/>
	public class ProductInPackageEventsProcess : ProductInPackage_CrtFinservProductEventsProcess
	{

		public ProductInPackageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

