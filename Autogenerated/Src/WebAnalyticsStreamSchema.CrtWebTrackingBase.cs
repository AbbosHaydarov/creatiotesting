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

	#region Class: WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema

	/// <exclude/>
	public class WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema(WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema(WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd8246a6-61be-4413-8656-5040eead5197");
			RealUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197");
			Name = "WebAnalyticsStream_CrtWebTrackingBase_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
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
			if (Columns.FindByUId(new Guid("3100d551-bf2d-6ceb-7173-e0bdc27adb80")) == null) {
				Columns.Add(CreateWebAnalyticsAccountColumn());
			}
			if (Columns.FindByUId(new Guid("3684d0fd-4414-f90f-8758-cf182730a6e7")) == null) {
				Columns.Add(CreateStreamIdColumn());
			}
			if (Columns.FindByUId(new Guid("f598c257-4922-c3d8-cd29-407d5f3efef9")) == null) {
				Columns.Add(CreateSiteUrlColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateWebAnalyticsAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3100d551-bf2d-6ceb-7173-e0bdc27adb80"),
				Name = @"WebAnalyticsAccount",
				ReferenceSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				ModifiedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateStreamIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3684d0fd-4414-f90f-8758-cf182730a6e7"),
				Name = @"StreamId",
				CreatedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				ModifiedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d1dcb785-4a0d-6b10-9287-05d906dc8466"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				ModifiedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd")
			};
		}

		protected virtual EntitySchemaColumn CreateSiteUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f598c257-4922-c3d8-cd29-407d5f3efef9"),
				Name = @"SiteUrl",
				CreatedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
				ModifiedInSchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197"),
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
			return new WebAnalyticsStream_CrtWebTrackingBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebAnalyticsStream_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebAnalyticsStream_CrtWebTrackingBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd8246a6-61be-4413-8656-5040eead5197"));
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsStream_CrtWebTrackingBase_Terrasoft

	/// <summary>
	/// Web analytics stream.
	/// </summary>
	public class WebAnalyticsStream_CrtWebTrackingBase_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WebAnalyticsStream_CrtWebTrackingBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsStream_CrtWebTrackingBase_Terrasoft";
		}

		public WebAnalyticsStream_CrtWebTrackingBase_Terrasoft(WebAnalyticsStream_CrtWebTrackingBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid WebAnalyticsAccountId {
			get {
				return GetTypedColumnValue<Guid>("WebAnalyticsAccountId");
			}
			set {
				SetColumnValue("WebAnalyticsAccountId", value);
				_webAnalyticsAccount = null;
			}
		}

		/// <exclude/>
		public string WebAnalyticsAccountName {
			get {
				return GetTypedColumnValue<string>("WebAnalyticsAccountName");
			}
			set {
				SetColumnValue("WebAnalyticsAccountName", value);
				if (_webAnalyticsAccount != null) {
					_webAnalyticsAccount.Name = value;
				}
			}
		}

		private WebAnalyticsAccount _webAnalyticsAccount;
		/// <summary>
		/// Web analytics account.
		/// </summary>
		public WebAnalyticsAccount WebAnalyticsAccount {
			get {
				return _webAnalyticsAccount ??
					(_webAnalyticsAccount = LookupColumnEntities.GetEntity("WebAnalyticsAccount") as WebAnalyticsAccount);
			}
		}

		/// <summary>
		/// Stream Id.
		/// </summary>
		public string StreamId {
			get {
				return GetTypedColumnValue<string>("StreamId");
			}
			set {
				SetColumnValue("StreamId", value);
			}
		}

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

		/// <summary>
		/// URL.
		/// </summary>
		public string SiteUrl {
			get {
				return GetTypedColumnValue<string>("SiteUrl");
			}
			set {
				SetColumnValue("SiteUrl", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebAnalyticsStream_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new WebAnalyticsStream_CrtWebTrackingBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsStream_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class WebAnalyticsStream_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : WebAnalyticsStream_CrtWebTrackingBase_Terrasoft
	{

		public WebAnalyticsStream_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebAnalyticsStream_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("bd8246a6-61be-4413-8656-5040eead5197");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bd8246a6-61be-4413-8656-5040eead5197");
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

	#region Class: WebAnalyticsStream_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class WebAnalyticsStream_CrtWebTrackingBaseEventsProcess : WebAnalyticsStream_CrtWebTrackingBaseEventsProcess<WebAnalyticsStream_CrtWebTrackingBase_Terrasoft>
	{

		public WebAnalyticsStream_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebAnalyticsStream_CrtWebTrackingBaseEventsProcess

	public partial class WebAnalyticsStream_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

