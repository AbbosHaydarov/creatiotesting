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

	#region Class: WebAnalyticsAccountSchema

	/// <exclude/>
	public class WebAnalyticsAccountSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WebAnalyticsAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebAnalyticsAccountSchema(WebAnalyticsAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebAnalyticsAccountSchema(WebAnalyticsAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b");
			RealUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b");
			Name = "WebAnalyticsAccount";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2eb3ddc0-89bb-402e-a91c-12d62ceefa4a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			if (Columns.FindByUId(new Guid("4bd45686-e861-e87e-3451-29a9f55933db")) == null) {
				Columns.Add(CreateConnectionStatusColumn());
			}
			if (Columns.FindByUId(new Guid("96d18024-d1c4-b131-7812-f1970f979961")) == null) {
				Columns.Add(CreateWebAnalyticsPlatformColumn());
			}
			if (Columns.FindByUId(new Guid("de29d089-1a49-30b2-8d69-b575c2fe4248")) == null) {
				Columns.Add(CreateAccountIdColumn());
			}
			if (Columns.FindByUId(new Guid("fd19d6fb-74be-082e-b374-fe1e2ab1fd72")) == null) {
				Columns.Add(CreatePlatformUserIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e0ef8283-b3c1-40f9-ca58-ed17ffcec827"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				ModifiedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				CreatedInPackageId = new Guid("2eb3ddc0-89bb-402e-a91c-12d62ceefa4a")
			};
		}

		protected virtual EntitySchemaColumn CreateConnectionStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4bd45686-e861-e87e-3451-29a9f55933db"),
				Name = @"ConnectionStatus",
				ReferenceSchemaUId = new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				ModifiedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				CreatedInPackageId = new Guid("2eb3ddc0-89bb-402e-a91c-12d62ceefa4a")
			};
		}

		protected virtual EntitySchemaColumn CreateWebAnalyticsPlatformColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("96d18024-d1c4-b131-7812-f1970f979961"),
				Name = @"WebAnalyticsPlatform",
				ReferenceSchemaUId = new Guid("b8e1d2fb-7852-4843-815b-a547470f412a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				ModifiedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				CreatedInPackageId = new Guid("2eb3ddc0-89bb-402e-a91c-12d62ceefa4a")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("de29d089-1a49-30b2-8d69-b575c2fe4248"),
				Name = @"AccountId",
				CreatedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				ModifiedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				CreatedInPackageId = new Guid("2eb3ddc0-89bb-402e-a91c-12d62ceefa4a")
			};
		}

		protected virtual EntitySchemaColumn CreatePlatformUserIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("fd19d6fb-74be-082e-b374-fe1e2ab1fd72"),
				Name = @"PlatformUserId",
				CreatedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				ModifiedInSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebAnalyticsAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebAnalyticsAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebAnalyticsAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"));
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsAccount

	/// <summary>
	/// Web analytics account.
	/// </summary>
	public class WebAnalyticsAccount : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WebAnalyticsAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsAccount";
		}

		public WebAnalyticsAccount(WebAnalyticsAccount source)
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
		public Guid ConnectionStatusId {
			get {
				return GetTypedColumnValue<Guid>("ConnectionStatusId");
			}
			set {
				SetColumnValue("ConnectionStatusId", value);
				_connectionStatus = null;
			}
		}

		/// <exclude/>
		public string ConnectionStatusName {
			get {
				return GetTypedColumnValue<string>("ConnectionStatusName");
			}
			set {
				SetColumnValue("ConnectionStatusName", value);
				if (_connectionStatus != null) {
					_connectionStatus.Name = value;
				}
			}
		}

		private WebAnalyticsAccState _connectionStatus;
		/// <summary>
		/// Connection status.
		/// </summary>
		public WebAnalyticsAccState ConnectionStatus {
			get {
				return _connectionStatus ??
					(_connectionStatus = LookupColumnEntities.GetEntity("ConnectionStatus") as WebAnalyticsAccState);
			}
		}

		/// <exclude/>
		public Guid WebAnalyticsPlatformId {
			get {
				return GetTypedColumnValue<Guid>("WebAnalyticsPlatformId");
			}
			set {
				SetColumnValue("WebAnalyticsPlatformId", value);
				_webAnalyticsPlatform = null;
			}
		}

		/// <exclude/>
		public string WebAnalyticsPlatformName {
			get {
				return GetTypedColumnValue<string>("WebAnalyticsPlatformName");
			}
			set {
				SetColumnValue("WebAnalyticsPlatformName", value);
				if (_webAnalyticsPlatform != null) {
					_webAnalyticsPlatform.Name = value;
				}
			}
		}

		private TouchEventTracking _webAnalyticsPlatform;
		/// <summary>
		/// Platform.
		/// </summary>
		public TouchEventTracking WebAnalyticsPlatform {
			get {
				return _webAnalyticsPlatform ??
					(_webAnalyticsPlatform = LookupColumnEntities.GetEntity("WebAnalyticsPlatform") as TouchEventTracking);
			}
		}

		/// <summary>
		/// Account Id.
		/// </summary>
		public string AccountId {
			get {
				return GetTypedColumnValue<string>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
			}
		}

		/// <summary>
		/// Platform user identifier.
		/// </summary>
		public string PlatformUserId {
			get {
				return GetTypedColumnValue<string>("PlatformUserId");
			}
			set {
				SetColumnValue("PlatformUserId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new WebAnalyticsAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : WebAnalyticsAccount
	{

		public WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b");
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

	#region Class: WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess : WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess<WebAnalyticsAccount>
	{

		public WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess

	public partial class WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebAnalyticsAccountEventsProcess

	/// <exclude/>
	public class WebAnalyticsAccountEventsProcess : WebAnalyticsAccount_CrtWebTrackingBaseEventsProcess
	{

		public WebAnalyticsAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

