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

	#region Class: WebAnalyticsVisitorSchema

	/// <exclude/>
	public class WebAnalyticsVisitorSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WebAnalyticsVisitorSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebAnalyticsVisitorSchema(WebAnalyticsVisitorSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebAnalyticsVisitorSchema(WebAnalyticsVisitorSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90");
			RealUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90");
			Name = "WebAnalyticsVisitor";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateVisitorIdColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ab822001-6980-92ab-64c8-82a7ba65e283")) == null) {
				Columns.Add(CreateWebAnalyticsStreamColumn());
			}
			if (Columns.FindByUId(new Guid("55689705-3ede-bb9b-6f68-25b03dfc1679")) == null) {
				Columns.Add(CreateContactColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateWebAnalyticsStreamColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ab822001-6980-92ab-64c8-82a7ba65e283"),
				Name = @"WebAnalyticsStream",
				ReferenceSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"),
				ModifiedInSchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateVisitorIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2a2fa1e7-3ddd-aae6-8175-bcc44912b587"),
				Name = @"VisitorId",
				CreatedInSchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"),
				ModifiedInSchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("55689705-3ede-bb9b-6f68-25b03dfc1679"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"),
				ModifiedInSchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebAnalyticsVisitor(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebAnalyticsVisitorSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebAnalyticsVisitorSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90"));
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsVisitor

	/// <summary>
	/// Web analytics visitor .
	/// </summary>
	public class WebAnalyticsVisitor : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WebAnalyticsVisitor(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsVisitor";
		}

		public WebAnalyticsVisitor(WebAnalyticsVisitor source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid WebAnalyticsStreamId {
			get {
				return GetTypedColumnValue<Guid>("WebAnalyticsStreamId");
			}
			set {
				SetColumnValue("WebAnalyticsStreamId", value);
				_webAnalyticsStream = null;
			}
		}

		/// <exclude/>
		public string WebAnalyticsStreamName {
			get {
				return GetTypedColumnValue<string>("WebAnalyticsStreamName");
			}
			set {
				SetColumnValue("WebAnalyticsStreamName", value);
				if (_webAnalyticsStream != null) {
					_webAnalyticsStream.Name = value;
				}
			}
		}

		private WebAnalyticsStream _webAnalyticsStream;
		/// <summary>
		/// Web analytics stream.
		/// </summary>
		public WebAnalyticsStream WebAnalyticsStream {
			get {
				return _webAnalyticsStream ??
					(_webAnalyticsStream = LookupColumnEntities.GetEntity("WebAnalyticsStream") as WebAnalyticsStream);
			}
		}

		/// <summary>
		/// VisitorId.
		/// </summary>
		public string VisitorId {
			get {
				return GetTypedColumnValue<string>("VisitorId");
			}
			set {
				SetColumnValue("VisitorId", value);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WebAnalyticsVisitor(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : WebAnalyticsVisitor
	{

		public WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1fff3f61-6244-4530-bf8c-e2fcb41a8b90");
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

	#region Class: WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess : WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess<WebAnalyticsVisitor>
	{

		public WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess

	public partial class WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebAnalyticsVisitorEventsProcess

	/// <exclude/>
	public class WebAnalyticsVisitorEventsProcess : WebAnalyticsVisitor_CrtWebTrackingBaseEventsProcess
	{

		public WebAnalyticsVisitorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

