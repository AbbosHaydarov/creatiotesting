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

	#region Class: TouchActionSchema

	/// <exclude/>
	public class TouchActionSchema : Terrasoft.Configuration.TouchAction_CrtWebTrackingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public TouchActionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchActionSchema(TouchActionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchActionSchema(TouchActionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_WebPageId_ActionIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("6b146bf6-4d96-4264-a00d-97e94f47a3a4");
			index.Name = "IX_WebPageId_ActionId";
			index.CreatedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d");
			index.ModifiedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d");
			index.CreatedInPackageId = new Guid("85622c2d-5e89-40f7-ac77-4469fee4cbcc");
			EntitySchemaIndexColumn actionIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a3ebb747-aeab-f3fc-1a3f-c0a7cf49138d"),
				ColumnUId = new Guid("2e0922e7-c9f0-b2e4-6710-8b1aac320c3a"),
				CreatedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d"),
				ModifiedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d"),
				CreatedInPackageId = new Guid("85622c2d-5e89-40f7-ac77-4469fee4cbcc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(actionIdIndexColumn);
			EntitySchemaIndexColumn webPageIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8239a42c-d82b-6bae-6167-bfbbed99defb"),
				ColumnUId = new Guid("6b6c27d1-4a18-f273-5fcb-f1dedbb365bb"),
				CreatedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d"),
				ModifiedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d"),
				CreatedInPackageId = new Guid("85622c2d-5e89-40f7-ac77-4469fee4cbcc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(webPageIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d");
			Name = "TouchAction";
			ParentSchemaUId = new Guid("c6ab21fb-e1e1-442c-879b-33eafc715001");
			ExtendParent = true;
			CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dfb73908-e124-e033-d500-10e3c69b9643")) == null) {
				Columns.Add(CreateEventsCountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEventsCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("dfb73908-e124-e033-d500-10e3c69b9643"),
				Name = @"EventsCount",
				CreatedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d"),
				ModifiedInSchemaUId = new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d"),
				CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_WebPageId_ActionIdIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new TouchAction(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchAction_CrtGoogleAnalyticsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchActionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchActionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchAction

	/// <summary>
	/// Web actions.
	/// </summary>
	public class TouchAction : Terrasoft.Configuration.TouchAction_CrtWebTrackingBase_Terrasoft
	{

		#region Constructors: Public

		public TouchAction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchAction";
		}

		public TouchAction(TouchAction source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number of events.
		/// </summary>
		public int EventsCount {
			get {
				return GetTypedColumnValue<int>("EventsCount");
			}
			set {
				SetColumnValue("EventsCount", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchAction_CrtGoogleAnalyticsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("TouchActionDeleted", e);
			Deleting += (s, e) => ThrowEvent("TouchActionDeleting", e);
			Inserted += (s, e) => ThrowEvent("TouchActionInserted", e);
			Inserting += (s, e) => ThrowEvent("TouchActionInserting", e);
			Saved += (s, e) => ThrowEvent("TouchActionSaved", e);
			Saving += (s, e) => ThrowEvent("TouchActionSaving", e);
			Validating += (s, e) => ThrowEvent("TouchActionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new TouchAction(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchAction_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public partial class TouchAction_CrtGoogleAnalyticsEventsProcess<TEntity> : Terrasoft.Configuration.TouchAction_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : TouchAction
	{

		public TouchAction_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchAction_CrtGoogleAnalyticsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8f5231c6-1476-4f80-bb7d-c96f3d60940d");
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

	#region Class: TouchAction_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public class TouchAction_CrtGoogleAnalyticsEventsProcess : TouchAction_CrtGoogleAnalyticsEventsProcess<TouchAction>
	{

		public TouchAction_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchAction_CrtGoogleAnalyticsEventsProcess

	public partial class TouchAction_CrtGoogleAnalyticsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchActionEventsProcess

	/// <exclude/>
	public class TouchActionEventsProcess : TouchAction_CrtGoogleAnalyticsEventsProcess
	{

		public TouchActionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

