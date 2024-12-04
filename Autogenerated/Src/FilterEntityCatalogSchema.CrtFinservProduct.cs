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

	#region Class: FilterEntityCatalogSchema

	/// <exclude/>
	public class FilterEntityCatalogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FilterEntityCatalogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FilterEntityCatalogSchema(FilterEntityCatalogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FilterEntityCatalogSchema(FilterEntityCatalogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af");
			RealUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af");
			Name = "FilterEntityCatalog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysFilterEntityCatalogLcz";
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5314483b-cba2-406b-a4b4-498f66e7a531")) == null) {
				Columns.Add(CreateSysEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("6bc3e70e-33ee-4a2a-9940-62c6ed887ba6")) == null) {
				Columns.Add(CreateSysEntitySchemaNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6599c8ef-6293-462f-981d-915ae4fa66f8"),
				Name = @"Caption",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
				ModifiedInSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("5314483b-cba2-406b-a4b4-498f66e7a531"),
				Name = @"SysEntitySchemaUId",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
				ModifiedInSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a")
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6bc3e70e-33ee-4a2a-9940-62c6ed887ba6"),
				Name = @"SysEntitySchemaName",
				CreatedInSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
				ModifiedInSchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"),
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
			return new FilterEntityCatalog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FilterEntityCatalog_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FilterEntityCatalogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FilterEntityCatalogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af"));
		}

		#endregion

	}

	#endregion

	#region Class: FilterEntityCatalog

	/// <summary>
	/// Filtering object in product catalog.
	/// </summary>
	public class FilterEntityCatalog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public FilterEntityCatalog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FilterEntityCatalog";
		}

		public FilterEntityCatalog(FilterEntityCatalog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Object schema Id.
		/// </summary>
		public Guid SysEntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaUId");
			}
			set {
				SetColumnValue("SysEntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Object schema name.
		/// </summary>
		public string SysEntitySchemaName {
			get {
				return GetTypedColumnValue<string>("SysEntitySchemaName");
			}
			set {
				SetColumnValue("SysEntitySchemaName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FilterEntityCatalog_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FilterEntityCatalogDeleted", e);
			Validating += (s, e) => ThrowEvent("FilterEntityCatalogValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FilterEntityCatalog(this);
		}

		#endregion

	}

	#endregion

	#region Class: FilterEntityCatalog_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class FilterEntityCatalog_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : FilterEntityCatalog
	{

		public FilterEntityCatalog_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FilterEntityCatalog_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("99042a50-df8b-40e9-97ec-e4682e32b9af");
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

	#region Class: FilterEntityCatalog_CrtFinservProductEventsProcess

	/// <exclude/>
	public class FilterEntityCatalog_CrtFinservProductEventsProcess : FilterEntityCatalog_CrtFinservProductEventsProcess<FilterEntityCatalog>
	{

		public FilterEntityCatalog_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FilterEntityCatalog_CrtFinservProductEventsProcess

	public partial class FilterEntityCatalog_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FilterEntityCatalogEventsProcess

	/// <exclude/>
	public class FilterEntityCatalogEventsProcess : FilterEntityCatalog_CrtFinservProductEventsProcess
	{

		public FilterEntityCatalogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

