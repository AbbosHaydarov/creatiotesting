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

	#region Class: Touch_CrtGoogleAnalytics_TerrasoftSchema

	/// <exclude/>
	public class Touch_CrtGoogleAnalytics_TerrasoftSchema : Terrasoft.Configuration.Touch_CrtWebTrackingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Touch_CrtGoogleAnalytics_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Touch_CrtGoogleAnalytics_TerrasoftSchema(Touch_CrtGoogleAnalytics_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Touch_CrtGoogleAnalytics_TerrasoftSchema(Touch_CrtGoogleAnalytics_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_SessionIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("108c492b-55b4-4746-9723-a9438ccf0371");
			index.Name = "IX_SessionId";
			index.CreatedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2");
			index.ModifiedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2");
			index.CreatedInPackageId = new Guid("85622c2d-5e89-40f7-ac77-4469fee4cbcc");
			EntitySchemaIndexColumn sessionIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("f832a083-a378-bdad-507a-1b90e6efb548"),
				ColumnUId = new Guid("29b8d471-9a85-14d5-a26e-6cda4d071c45"),
				CreatedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2"),
				ModifiedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2"),
				CreatedInPackageId = new Guid("85622c2d-5e89-40f7-ac77-4469fee4cbcc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sessionIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2");
			Name = "Touch_CrtGoogleAnalytics_Terrasoft";
			ParentSchemaUId = new Guid("6895c8a8-7407-460a-90ec-5e5bfbda0fda");
			ExtendParent = true;
			CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e15077b2-bd94-76d5-52bd-96c2f93f7ff8")) == null) {
				Columns.Add(CreateGASessionIdColumn());
			}
			if (Columns.FindByUId(new Guid("59437603-8133-b0bb-8ff5-dbe2a509cdbb")) == null) {
				Columns.Add(CreateWebAnalyticsVisitorColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateGASessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e15077b2-bd94-76d5-52bd-96c2f93f7ff8"),
				Name = @"GASessionId",
				CreatedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2"),
				ModifiedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2"),
				CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateWebAnalyticsVisitorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("59437603-8133-b0bb-8ff5-dbe2a509cdbb"),
				Name = @"WebAnalyticsVisitor",
				ReferenceSchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2"),
				ModifiedInSchemaUId = new Guid("b05000c5-a18c-4250-9e03-074e22d330c2"),
				CreatedInPackageId = new Guid("402fd175-323a-469d-847e-2eee398115b9"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_SessionIdIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Touch_CrtGoogleAnalytics_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Touch_CrtGoogleAnalyticsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Touch_CrtGoogleAnalytics_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Touch_CrtGoogleAnalytics_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b05000c5-a18c-4250-9e03-074e22d330c2"));
		}

		#endregion

	}

	#endregion

	#region Class: Touch_CrtGoogleAnalytics_Terrasoft

	/// <summary>
	/// Web sessions.
	/// </summary>
	public class Touch_CrtGoogleAnalytics_Terrasoft : Terrasoft.Configuration.Touch_CrtWebTrackingBase_Terrasoft
	{

		#region Constructors: Public

		public Touch_CrtGoogleAnalytics_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Touch_CrtGoogleAnalytics_Terrasoft";
		}

		public Touch_CrtGoogleAnalytics_Terrasoft(Touch_CrtGoogleAnalytics_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Google Analytics session identifier.
		/// </summary>
		public string GASessionId {
			get {
				return GetTypedColumnValue<string>("GASessionId");
			}
			set {
				SetColumnValue("GASessionId", value);
			}
		}

		/// <exclude/>
		public Guid WebAnalyticsVisitorId {
			get {
				return GetTypedColumnValue<Guid>("WebAnalyticsVisitorId");
			}
			set {
				SetColumnValue("WebAnalyticsVisitorId", value);
				_webAnalyticsVisitor = null;
			}
		}

		/// <exclude/>
		public string WebAnalyticsVisitorVisitorId {
			get {
				return GetTypedColumnValue<string>("WebAnalyticsVisitorVisitorId");
			}
			set {
				SetColumnValue("WebAnalyticsVisitorVisitorId", value);
				if (_webAnalyticsVisitor != null) {
					_webAnalyticsVisitor.VisitorId = value;
				}
			}
		}

		private WebAnalyticsVisitor _webAnalyticsVisitor;
		/// <summary>
		/// Web analytics visitor.
		/// </summary>
		public WebAnalyticsVisitor WebAnalyticsVisitor {
			get {
				return _webAnalyticsVisitor ??
					(_webAnalyticsVisitor = LookupColumnEntities.GetEntity("WebAnalyticsVisitor") as WebAnalyticsVisitor);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Touch_CrtGoogleAnalyticsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Touch_CrtGoogleAnalytics_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Touch_CrtGoogleAnalytics_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Touch_CrtGoogleAnalytics_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Touch_CrtGoogleAnalytics_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Touch_CrtGoogleAnalytics_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Touch_CrtGoogleAnalytics_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Touch_CrtGoogleAnalytics_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Touch_CrtGoogleAnalytics_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Touch_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public partial class Touch_CrtGoogleAnalyticsEventsProcess<TEntity> : Terrasoft.Configuration.Touch_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : Touch_CrtGoogleAnalytics_Terrasoft
	{

		public Touch_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Touch_CrtGoogleAnalyticsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b05000c5-a18c-4250-9e03-074e22d330c2");
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

	#region Class: Touch_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public class Touch_CrtGoogleAnalyticsEventsProcess : Touch_CrtGoogleAnalyticsEventsProcess<Touch_CrtGoogleAnalytics_Terrasoft>
	{

		public Touch_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Touch_CrtGoogleAnalyticsEventsProcess

	public partial class Touch_CrtGoogleAnalyticsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

