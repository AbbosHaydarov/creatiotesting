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

	#region Class: ProductTypeSchema

	/// <exclude/>
	public class ProductTypeSchema : Terrasoft.Configuration.ProductType_ProductBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductTypeSchema(ProductTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductTypeSchema(ProductTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("768283ce-07f3-4fa2-9701-26676ed013c6");
			Name = "ProductType";
			ParentSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIsServiceColumn() {
			EntitySchemaColumn column = base.CreateIsServiceColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("768283ce-07f3-4fa2-9701-26676ed013c6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override EntitySchemaColumn CreateCategoryColumn() {
			EntitySchemaColumn column = base.CreateCategoryColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("768283ce-07f3-4fa2-9701-26676ed013c6");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductType_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("768283ce-07f3-4fa2-9701-26676ed013c6"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductType

	/// <summary>
	/// Product type.
	/// </summary>
	public class ProductType : Terrasoft.Configuration.ProductType_ProductBase_Terrasoft
	{

		#region Constructors: Public

		public ProductType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductType";
		}

		public ProductType(ProductType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductType_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("ProductTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("ProductTypeInserted", e);
			Saved += (s, e) => ThrowEvent("ProductTypeSaved", e);
			Saving += (s, e) => ThrowEvent("ProductTypeSaving", e);
			Validating += (s, e) => ThrowEvent("ProductTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductType_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ProductType_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.ProductType_ProductBaseEventsProcess<TEntity> where TEntity : ProductType
	{

		public ProductType_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductType_CrtFinservProductEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("768283ce-07f3-4fa2-9701-26676ed013c6");
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

	#region Class: ProductType_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ProductType_CrtFinservProductEventsProcess : ProductType_CrtFinservProductEventsProcess<ProductType>
	{

		public ProductType_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductType_CrtFinservProductEventsProcess

	public partial class ProductType_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductTypeEventsProcess

	/// <exclude/>
	public class ProductTypeEventsProcess : ProductType_CrtFinservProductEventsProcess
	{

		public ProductTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

