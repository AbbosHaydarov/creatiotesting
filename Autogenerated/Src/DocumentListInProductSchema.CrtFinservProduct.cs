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

	#region Class: DocumentListInProductSchema

	/// <exclude/>
	public class DocumentListInProductSchema : Terrasoft.Configuration.DocumentListSchema
	{

		#region Constructors: Public

		public DocumentListInProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentListInProductSchema(DocumentListInProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentListInProductSchema(DocumentListInProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e73b677d-cd0b-46cf-badb-fc5b09dfd0e9");
			RealUId = new Guid("e73b677d-cd0b-46cf-badb-fc5b09dfd0e9");
			Name = "DocumentListInProduct";
			ParentSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d07b8630-7c4a-45ae-a200-da6c66550d40")) == null) {
				Columns.Add(CreateProductColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d07b8630-7c4a-45ae-a200-da6c66550d40"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e73b677d-cd0b-46cf-badb-fc5b09dfd0e9"),
				ModifiedInSchemaUId = new Guid("e73b677d-cd0b-46cf-badb-fc5b09dfd0e9"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentListInProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentListInProduct_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentListInProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentListInProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e73b677d-cd0b-46cf-badb-fc5b09dfd0e9"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentListInProduct

	/// <summary>
	/// Documents package in product.
	/// </summary>
	public class DocumentListInProduct : Terrasoft.Configuration.DocumentList
	{

		#region Constructors: Public

		public DocumentListInProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentListInProduct";
		}

		public DocumentListInProduct(DocumentListInProduct source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
			var process = new DocumentListInProduct_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentListInProductDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocumentListInProductDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocumentListInProductInserted", e);
			Inserting += (s, e) => ThrowEvent("DocumentListInProductInserting", e);
			Saved += (s, e) => ThrowEvent("DocumentListInProductSaved", e);
			Saving += (s, e) => ThrowEvent("DocumentListInProductSaving", e);
			Validating += (s, e) => ThrowEvent("DocumentListInProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentListInProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentListInProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class DocumentListInProduct_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.DocumentList_CrtFinservProductEventsProcess<TEntity> where TEntity : DocumentListInProduct
	{

		public DocumentListInProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentListInProduct_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("e73b677d-cd0b-46cf-badb-fc5b09dfd0e9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e73b677d-cd0b-46cf-badb-fc5b09dfd0e9");
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

	#region Class: DocumentListInProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public class DocumentListInProduct_CrtFinservProductEventsProcess : DocumentListInProduct_CrtFinservProductEventsProcess<DocumentListInProduct>
	{

		public DocumentListInProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentListInProduct_CrtFinservProductEventsProcess

	public partial class DocumentListInProduct_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocumentListInProductEventsProcess

	/// <exclude/>
	public class DocumentListInProductEventsProcess : DocumentListInProduct_CrtFinservProductEventsProcess
	{

		public DocumentListInProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

