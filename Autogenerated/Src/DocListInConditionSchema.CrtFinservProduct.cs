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

	#region Class: DocListInConditionSchema

	/// <exclude/>
	public class DocListInConditionSchema : Terrasoft.Configuration.DocumentListSchema
	{

		#region Constructors: Public

		public DocListInConditionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocListInConditionSchema(DocListInConditionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocListInConditionSchema(DocListInConditionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a");
			RealUId = new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a");
			Name = "DocListInCondition";
			ParentSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c");
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
			if (Columns.FindByUId(new Guid("40a648ce-9d15-4289-9dbc-83a3b062ae18")) == null) {
				Columns.Add(CreateProductConditionColumn());
			}
			if (Columns.FindByUId(new Guid("a8e79d67-df18-4813-ad2b-1a4db30fbb18")) == null) {
				Columns.Add(CreateFilterEntityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductConditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("40a648ce-9d15-4289-9dbc-83a3b062ae18"),
				Name = @"ProductCondition",
				ReferenceSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a"),
				ModifiedInSchemaUId = new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateFilterEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a8e79d67-df18-4813-ad2b-1a4db30fbb18"),
				Name = @"FilterEntity",
				ReferenceSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a"),
				ModifiedInSchemaUId = new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocListInCondition(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocListInCondition_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocListInConditionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocListInConditionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a"));
		}

		#endregion

	}

	#endregion

	#region Class: DocListInCondition

	/// <summary>
	/// Document in package.
	/// </summary>
	public class DocListInCondition : Terrasoft.Configuration.DocumentList
	{

		#region Constructors: Public

		public DocListInCondition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocListInCondition";
		}

		public DocListInCondition(DocListInCondition source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProductConditionId {
			get {
				return GetTypedColumnValue<Guid>("ProductConditionId");
			}
			set {
				SetColumnValue("ProductConditionId", value);
				_productCondition = null;
			}
		}

		/// <exclude/>
		public string ProductConditionName {
			get {
				return GetTypedColumnValue<string>("ProductConditionName");
			}
			set {
				SetColumnValue("ProductConditionName", value);
				if (_productCondition != null) {
					_productCondition.Name = value;
				}
			}
		}

		private ProductCondition _productCondition;
		/// <summary>
		/// Product conditions.
		/// </summary>
		public ProductCondition ProductCondition {
			get {
				return _productCondition ??
					(_productCondition = LookupColumnEntities.GetEntity("ProductCondition") as ProductCondition);
			}
		}

		/// <exclude/>
		public Guid FilterEntityId {
			get {
				return GetTypedColumnValue<Guid>("FilterEntityId");
			}
			set {
				SetColumnValue("FilterEntityId", value);
				_filterEntity = null;
			}
		}

		/// <exclude/>
		public string FilterEntityCaption {
			get {
				return GetTypedColumnValue<string>("FilterEntityCaption");
			}
			set {
				SetColumnValue("FilterEntityCaption", value);
				if (_filterEntity != null) {
					_filterEntity.Caption = value;
				}
			}
		}

		private FilterEntityCatalog _filterEntity;
		/// <summary>
		/// Filtering object.
		/// </summary>
		public FilterEntityCatalog FilterEntity {
			get {
				return _filterEntity ??
					(_filterEntity = LookupColumnEntities.GetEntity("FilterEntity") as FilterEntityCatalog);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocListInCondition_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocListInConditionDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocListInConditionDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocListInConditionInserted", e);
			Inserting += (s, e) => ThrowEvent("DocListInConditionInserting", e);
			Saved += (s, e) => ThrowEvent("DocListInConditionSaved", e);
			Saving += (s, e) => ThrowEvent("DocListInConditionSaving", e);
			Validating += (s, e) => ThrowEvent("DocListInConditionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocListInCondition(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocListInCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class DocListInCondition_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.DocumentList_CrtFinservProductEventsProcess<TEntity> where TEntity : DocListInCondition
	{

		public DocListInCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocListInCondition_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("838a6d97-9c4a-460f-9f9d-08bdd417525a");
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

	#region Class: DocListInCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public class DocListInCondition_CrtFinservProductEventsProcess : DocListInCondition_CrtFinservProductEventsProcess<DocListInCondition>
	{

		public DocListInCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocListInCondition_CrtFinservProductEventsProcess

	public partial class DocListInCondition_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocListInConditionEventsProcess

	/// <exclude/>
	public class DocListInConditionEventsProcess : DocListInCondition_CrtFinservProductEventsProcess
	{

		public DocListInConditionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

