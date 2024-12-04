﻿namespace Terrasoft.Configuration
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

	#region Class: ProductCategory_CrtProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class ProductCategory_CrtProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ProductCategory_CrtProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductCategory_CrtProductCatalogue_TerrasoftSchema(ProductCategory_CrtProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductCategory_CrtProductCatalogue_TerrasoftSchema(ProductCategory_CrtProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			RealUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			Name = "ProductCategory_CrtProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("4910df15-c2f1-6fa9-d501-1f0869b447cd"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				ModifiedInSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				CreatedInPackageId = new Guid("421de52c-b1cc-429f-8e0a-6e6eb14d78f5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductCategory_CrtProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductCategory_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductCategory_CrtProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductCategory_CrtProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductCategory_CrtProductCatalogue_Terrasoft

	/// <summary>
	/// Product category.
	/// </summary>
	public class ProductCategory_CrtProductCatalogue_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ProductCategory_CrtProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCategory_CrtProductCatalogue_Terrasoft";
		}

		public ProductCategory_CrtProductCatalogue_Terrasoft(ProductCategory_CrtProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductCategory_CrtProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductCategory_CrtProductCatalogue_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("ProductCategory_CrtProductCatalogue_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("ProductCategory_CrtProductCatalogue_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCategory_CrtProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCategory_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductCategory_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ProductCategory_CrtProductCatalogue_Terrasoft
	{

		public ProductCategory_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCategory_CrtProductCatalogueEventsProcess";
			SchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3e22e8d3-36f6-4c32-adbe-678155527541");
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

	#region Class: ProductCategory_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductCategory_CrtProductCatalogueEventsProcess : ProductCategory_CrtProductCatalogueEventsProcess<ProductCategory_CrtProductCatalogue_Terrasoft>
	{

		public ProductCategory_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCategory_CrtProductCatalogueEventsProcess

	public partial class ProductCategory_CrtProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

