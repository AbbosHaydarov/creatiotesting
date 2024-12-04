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

	#region Class: VwFinActiveProductSchema

	/// <exclude/>
	public class VwFinActiveProductSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwFinActiveProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwFinActiveProductSchema(VwFinActiveProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwFinActiveProductSchema(VwFinActiveProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301");
			RealUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301");
			Name = "VwFinActiveProduct";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b");
			IsDBView = true;
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
			if (Columns.FindByUId(new Guid("b6431010-c1ba-4f12-a53d-6d5ed5f11342")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("494db956-dc3e-4498-aa9c-3badea76ed7b")) == null) {
				Columns.Add(CreateOpportunityConditionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1ce63021-3d81-428c-a54b-5e51fa778bcc"),
				Name = @"Name",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301"),
				ModifiedInSchemaUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b6431010-c1ba-4f12-a53d-6d5ed5f11342"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301"),
				ModifiedInSchemaUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected virtual EntitySchemaColumn CreateOpportunityConditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("494db956-dc3e-4498-aa9c-3badea76ed7b"),
				Name = @"OpportunityCondition",
				ReferenceSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301"),
				ModifiedInSchemaUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwFinActiveProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwFinActiveProduct_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwFinActiveProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwFinActiveProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301"));
		}

		#endregion

	}

	#endregion

	#region Class: VwFinActiveProduct

	/// <summary>
	/// Active product.
	/// </summary>
	public class VwFinActiveProduct : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwFinActiveProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwFinActiveProduct";
		}

		public VwFinActiveProduct(VwFinActiveProduct source)
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

		/// <exclude/>
		public Guid OpportunityConditionId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityConditionId");
			}
			set {
				SetColumnValue("OpportunityConditionId", value);
				_opportunityCondition = null;
			}
		}

		/// <exclude/>
		public string OpportunityConditionName {
			get {
				return GetTypedColumnValue<string>("OpportunityConditionName");
			}
			set {
				SetColumnValue("OpportunityConditionName", value);
				if (_opportunityCondition != null) {
					_opportunityCondition.Name = value;
				}
			}
		}

		private OpportunityCondition _opportunityCondition;
		/// <summary>
		/// OpportunityCondition.
		/// </summary>
		public OpportunityCondition OpportunityCondition {
			get {
				return _opportunityCondition ??
					(_opportunityCondition = LookupColumnEntities.GetEntity("OpportunityCondition") as OpportunityCondition);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwFinActiveProduct_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwFinActiveProductDeleted", e);
			Validating += (s, e) => ThrowEvent("VwFinActiveProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwFinActiveProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwFinActiveProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class VwFinActiveProduct_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwFinActiveProduct
	{

		public VwFinActiveProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwFinActiveProduct_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2ab6c982-18d6-429a-a2bc-cf5f4e9a9301");
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

	#region Class: VwFinActiveProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public class VwFinActiveProduct_CrtFinservProductEventsProcess : VwFinActiveProduct_CrtFinservProductEventsProcess<VwFinActiveProduct>
	{

		public VwFinActiveProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwFinActiveProduct_CrtFinservProductEventsProcess

	public partial class VwFinActiveProduct_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwFinActiveProductEventsProcess

	/// <exclude/>
	public class VwFinActiveProductEventsProcess : VwFinActiveProduct_CrtFinservProductEventsProcess
	{

		public VwFinActiveProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

