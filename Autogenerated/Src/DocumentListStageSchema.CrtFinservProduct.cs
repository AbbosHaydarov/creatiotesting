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

	#region Class: DocumentListStageSchema

	/// <exclude/>
	public class DocumentListStageSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DocumentListStageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentListStageSchema(DocumentListStageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentListStageSchema(DocumentListStageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf");
			RealUId = new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf");
			Name = "DocumentListStage";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e87f4567-4e30-47a9-9de6-06acbb79e79a")) == null) {
				Columns.Add(CreateFilterEntityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFilterEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e87f4567-4e30-47a9-9de6-06acbb79e79a"),
				Name = @"FilterEntity",
				ReferenceSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf"),
				ModifiedInSchemaUId = new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentListStage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentListStage_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentListStageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentListStageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentListStage

	/// <summary>
	/// Document package stage.
	/// </summary>
	public class DocumentListStage : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public DocumentListStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentListStage";
		}

		public DocumentListStage(DocumentListStage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
			var process = new DocumentListStage_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentListStageDeleted", e);
			Validating += (s, e) => ThrowEvent("DocumentListStageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentListStage(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentListStage_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class DocumentListStage_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : DocumentListStage
	{

		public DocumentListStage_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentListStage_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf");
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

	#region Class: DocumentListStage_CrtFinservProductEventsProcess

	/// <exclude/>
	public class DocumentListStage_CrtFinservProductEventsProcess : DocumentListStage_CrtFinservProductEventsProcess<DocumentListStage>
	{

		public DocumentListStage_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentListStage_CrtFinservProductEventsProcess

	public partial class DocumentListStage_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocumentListStageEventsProcess

	/// <exclude/>
	public class DocumentListStageEventsProcess : DocumentListStage_CrtFinservProductEventsProcess
	{

		public DocumentListStageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

