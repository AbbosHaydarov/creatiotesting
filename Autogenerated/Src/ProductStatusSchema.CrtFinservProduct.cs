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

	#region Class: ProductStatusSchema

	/// <exclude/>
	public class ProductStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ProductStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductStatusSchema(ProductStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductStatusSchema(ProductStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			RealUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			Name = "ProductStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			column.CreatedInPackageId = new Guid("eda1c160-6805-407f-9b7a-34cca4539aae");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductStatus_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductStatus

	/// <summary>
	/// Product status.
	/// </summary>
	public class ProductStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ProductStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductStatus";
		}

		public ProductStatus(ProductStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductStatus_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductStatusDeleted", e);
			Validating += (s, e) => ThrowEvent("ProductStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductStatus_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ProductStatus_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ProductStatus
	{

		public ProductStatus_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductStatus_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7e739651-eb7d-4d13-874e-aa403a2039d8");
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

	#region Class: ProductStatus_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ProductStatus_CrtFinservProductEventsProcess : ProductStatus_CrtFinservProductEventsProcess<ProductStatus>
	{

		public ProductStatus_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductStatus_CrtFinservProductEventsProcess

	public partial class ProductStatus_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductStatusEventsProcess

	/// <exclude/>
	public class ProductStatusEventsProcess : ProductStatus_CrtFinservProductEventsProcess
	{

		public ProductStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

