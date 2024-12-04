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

	#region Class: WebAnalyticsTouchSchema

	/// <exclude/>
	[IsVirtual]
	public class WebAnalyticsTouchSchema : Terrasoft.Configuration.TouchSchema
	{

		#region Constructors: Public

		public WebAnalyticsTouchSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebAnalyticsTouchSchema(WebAnalyticsTouchSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebAnalyticsTouchSchema(WebAnalyticsTouchSchema source)
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
			UId = new Guid("a613d73a-2190-4098-984c-da2e7d806915");
			RealUId = new Guid("a613d73a-2190-4098-984c-da2e7d806915");
			Name = "WebAnalyticsTouch";
			ParentSchemaUId = new Guid("6895c8a8-7407-460a-90ec-5e5bfbda0fda");
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
			Indexes.Add(CreateIX_SessionIdIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebAnalyticsTouch(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebAnalyticsTouchSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebAnalyticsTouchSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a613d73a-2190-4098-984c-da2e7d806915"));
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsTouch

	/// <summary>
	/// Web analytics session.
	/// </summary>
	public class WebAnalyticsTouch : Terrasoft.Configuration.Touch
	{

		#region Constructors: Public

		public WebAnalyticsTouch(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsTouch";
		}

		public WebAnalyticsTouch(WebAnalyticsTouch source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WebAnalyticsTouchDeleted", e);
			Deleting += (s, e) => ThrowEvent("WebAnalyticsTouchDeleting", e);
			Inserted += (s, e) => ThrowEvent("WebAnalyticsTouchInserted", e);
			Inserting += (s, e) => ThrowEvent("WebAnalyticsTouchInserting", e);
			Saved += (s, e) => ThrowEvent("WebAnalyticsTouchSaved", e);
			Saving += (s, e) => ThrowEvent("WebAnalyticsTouchSaving", e);
			Validating += (s, e) => ThrowEvent("WebAnalyticsTouchValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WebAnalyticsTouch(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.Touch_CrtMatomoConnectorEventsProcess<TEntity> where TEntity : WebAnalyticsTouch
	{

		public WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("a613d73a-2190-4098-984c-da2e7d806915");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a613d73a-2190-4098-984c-da2e7d806915");
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

	#region Class: WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess : WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess<WebAnalyticsTouch>
	{

		public WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess

	public partial class WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebAnalyticsTouchEventsProcess

	/// <exclude/>
	public class WebAnalyticsTouchEventsProcess : WebAnalyticsTouch_CrtWebTrackingBaseEventsProcess
	{

		public WebAnalyticsTouchEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

