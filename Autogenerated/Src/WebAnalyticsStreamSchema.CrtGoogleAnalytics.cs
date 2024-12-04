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

	#region Class: WebAnalyticsStreamSchema

	/// <exclude/>
	public class WebAnalyticsStreamSchema : Terrasoft.Configuration.WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public WebAnalyticsStreamSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebAnalyticsStreamSchema(WebAnalyticsStreamSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebAnalyticsStreamSchema(WebAnalyticsStreamSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f46e9de2-cece-41b2-9709-3cd37a15939f");
			Name = "WebAnalyticsStream";
			ParentSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fb1e3601-9835-4464-96f8-122c8aa27de8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ba77f2db-b41c-67d4-b62c-382a3a53477e")) == null) {
				Columns.Add(CreateGAPropertyIdColumn());
			}
			if (Columns.FindByUId(new Guid("75f7efcc-2dec-5e4d-1446-b09036e0124d")) == null) {
				Columns.Add(CreateMeasurementIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateGAPropertyIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("ba77f2db-b41c-67d4-b62c-382a3a53477e"),
				Name = @"GAPropertyId",
				CreatedInSchemaUId = new Guid("f46e9de2-cece-41b2-9709-3cd37a15939f"),
				ModifiedInSchemaUId = new Guid("f46e9de2-cece-41b2-9709-3cd37a15939f"),
				CreatedInPackageId = new Guid("fb1e3601-9835-4464-96f8-122c8aa27de8")
			};
		}

		protected virtual EntitySchemaColumn CreateMeasurementIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("75f7efcc-2dec-5e4d-1446-b09036e0124d"),
				Name = @"MeasurementId",
				CreatedInSchemaUId = new Guid("f46e9de2-cece-41b2-9709-3cd37a15939f"),
				ModifiedInSchemaUId = new Guid("f46e9de2-cece-41b2-9709-3cd37a15939f"),
				CreatedInPackageId = new Guid("402fd175-323a-469d-847e-2eee398115b9")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebAnalyticsStream(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebAnalyticsStreamSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebAnalyticsStreamSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f46e9de2-cece-41b2-9709-3cd37a15939f"));
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsStream

	/// <summary>
	/// Web analytics stream.
	/// </summary>
	public class WebAnalyticsStream : Terrasoft.Configuration.WebAnalyticsStream_CrtWebTrackingBase_Terrasoft
	{

		#region Constructors: Public

		public WebAnalyticsStream(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsStream";
		}

		public WebAnalyticsStream(WebAnalyticsStream source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Google analytics property Id.
		/// </summary>
		public string GAPropertyId {
			get {
				return GetTypedColumnValue<string>("GAPropertyId");
			}
			set {
				SetColumnValue("GAPropertyId", value);
			}
		}

		/// <summary>
		/// Measurement id.
		/// </summary>
		public string MeasurementId {
			get {
				return GetTypedColumnValue<string>("MeasurementId");
			}
			set {
				SetColumnValue("MeasurementId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WebAnalyticsStreamDeleted", e);
			Deleting += (s, e) => ThrowEvent("WebAnalyticsStreamDeleting", e);
			Inserted += (s, e) => ThrowEvent("WebAnalyticsStreamInserted", e);
			Inserting += (s, e) => ThrowEvent("WebAnalyticsStreamInserting", e);
			Saved += (s, e) => ThrowEvent("WebAnalyticsStreamSaved", e);
			Saving += (s, e) => ThrowEvent("WebAnalyticsStreamSaving", e);
			Validating += (s, e) => ThrowEvent("WebAnalyticsStreamValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WebAnalyticsStream(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public partial class WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess<TEntity> : Terrasoft.Configuration.WebAnalyticsStream_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : WebAnalyticsStream
	{

		public WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f46e9de2-cece-41b2-9709-3cd37a15939f");
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

	#region Class: WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public class WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess : WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess<WebAnalyticsStream>
	{

		public WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess

	public partial class WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebAnalyticsStreamEventsProcess

	/// <exclude/>
	public class WebAnalyticsStreamEventsProcess : WebAnalyticsStream_CrtGoogleAnalyticsEventsProcess
	{

		public WebAnalyticsStreamEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

