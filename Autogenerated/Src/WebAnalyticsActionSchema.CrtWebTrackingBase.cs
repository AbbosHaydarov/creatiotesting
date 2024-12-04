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

	#region Class: WebAnalyticsActionSchema

	/// <exclude/>
	[IsVirtual]
	public class WebAnalyticsActionSchema : Terrasoft.Configuration.TouchActionSchema
	{

		#region Constructors: Public

		public WebAnalyticsActionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebAnalyticsActionSchema(WebAnalyticsActionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebAnalyticsActionSchema(WebAnalyticsActionSchema source)
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
			UId = new Guid("88153e17-c793-4993-880c-67a8af0a34c3");
			RealUId = new Guid("88153e17-c793-4993-880c-67a8af0a34c3");
			Name = "WebAnalyticsAction";
			ParentSchemaUId = new Guid("c6ab21fb-e1e1-442c-879b-33eafc715001");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_WebPageId_ActionIdIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebAnalyticsAction(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebAnalyticsAction_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebAnalyticsActionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebAnalyticsActionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88153e17-c793-4993-880c-67a8af0a34c3"));
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsAction

	/// <summary>
	/// Web analytics session action.
	/// </summary>
	public class WebAnalyticsAction : Terrasoft.Configuration.TouchAction
	{

		#region Constructors: Public

		public WebAnalyticsAction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsAction";
		}

		public WebAnalyticsAction(WebAnalyticsAction source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebAnalyticsAction_CrtWebTrackingBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WebAnalyticsActionDeleted", e);
			Deleting += (s, e) => ThrowEvent("WebAnalyticsActionDeleting", e);
			Inserted += (s, e) => ThrowEvent("WebAnalyticsActionInserted", e);
			Inserting += (s, e) => ThrowEvent("WebAnalyticsActionInserting", e);
			Saved += (s, e) => ThrowEvent("WebAnalyticsActionSaved", e);
			Saving += (s, e) => ThrowEvent("WebAnalyticsActionSaving", e);
			Validating += (s, e) => ThrowEvent("WebAnalyticsActionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WebAnalyticsAction(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsAction_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class WebAnalyticsAction_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.TouchAction_CrtGoogleAnalyticsEventsProcess<TEntity> where TEntity : WebAnalyticsAction
	{

		public WebAnalyticsAction_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebAnalyticsAction_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("88153e17-c793-4993-880c-67a8af0a34c3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("88153e17-c793-4993-880c-67a8af0a34c3");
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

	#region Class: WebAnalyticsAction_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class WebAnalyticsAction_CrtWebTrackingBaseEventsProcess : WebAnalyticsAction_CrtWebTrackingBaseEventsProcess<WebAnalyticsAction>
	{

		public WebAnalyticsAction_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebAnalyticsAction_CrtWebTrackingBaseEventsProcess

	public partial class WebAnalyticsAction_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebAnalyticsActionEventsProcess

	/// <exclude/>
	public class WebAnalyticsActionEventsProcess : WebAnalyticsAction_CrtWebTrackingBaseEventsProcess
	{

		public WebAnalyticsActionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

