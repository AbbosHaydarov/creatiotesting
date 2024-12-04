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

	#region Class: ProductCategoryKindSchema

	/// <exclude/>
	public class ProductCategoryKindSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ProductCategoryKindSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductCategoryKindSchema(ProductCategoryKindSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductCategoryKindSchema(ProductCategoryKindSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3791f0e6-eea3-423f-9bd3-1f139861eb13");
			RealUId = new Guid("3791f0e6-eea3-423f-9bd3-1f139861eb13");
			Name = "ProductCategoryKind";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductCategoryKind(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductCategoryKind_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductCategoryKindSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductCategoryKindSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3791f0e6-eea3-423f-9bd3-1f139861eb13"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductCategoryKind

	/// <summary>
	/// Type of product category.
	/// </summary>
	public class ProductCategoryKind : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ProductCategoryKind(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCategoryKind";
		}

		public ProductCategoryKind(ProductCategoryKind source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductCategoryKind_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductCategoryKindDeleted", e);
			Validating += (s, e) => ThrowEvent("ProductCategoryKindValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCategoryKind(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCategoryKind_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ProductCategoryKind_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ProductCategoryKind
	{

		public ProductCategoryKind_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCategoryKind_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("3791f0e6-eea3-423f-9bd3-1f139861eb13");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3791f0e6-eea3-423f-9bd3-1f139861eb13");
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

	#region Class: ProductCategoryKind_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ProductCategoryKind_CrtFinservProductEventsProcess : ProductCategoryKind_CrtFinservProductEventsProcess<ProductCategoryKind>
	{

		public ProductCategoryKind_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCategoryKind_CrtFinservProductEventsProcess

	public partial class ProductCategoryKind_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductCategoryKindEventsProcess

	/// <exclude/>
	public class ProductCategoryKindEventsProcess : ProductCategoryKind_CrtFinservProductEventsProcess
	{

		public ProductCategoryKindEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

