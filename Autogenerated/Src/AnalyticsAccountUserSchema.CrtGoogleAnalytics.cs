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

	#region Class: AnalyticsAccountUserSchema

	/// <exclude/>
	public class AnalyticsAccountUserSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AnalyticsAccountUserSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AnalyticsAccountUserSchema(AnalyticsAccountUserSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AnalyticsAccountUserSchema(AnalyticsAccountUserSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db18b49b-5228-4648-87af-fe1d4a930b50");
			RealUId = new Guid("db18b49b-5228-4648-87af-fe1d4a930b50");
			Name = "AnalyticsAccountUser";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fb1e3601-9835-4464-96f8-122c8aa27de8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreatePlatformUserIdColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c2a6d04e-2b36-b494-fab1-a1dd343759f5")) == null) {
				Columns.Add(CreateWebAnalyticsAccountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateWebAnalyticsAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c2a6d04e-2b36-b494-fab1-a1dd343759f5"),
				Name = @"WebAnalyticsAccount",
				ReferenceSchemaUId = new Guid("1b13bc48-6e80-430c-9a32-7ad5cab0355b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("db18b49b-5228-4648-87af-fe1d4a930b50"),
				ModifiedInSchemaUId = new Guid("db18b49b-5228-4648-87af-fe1d4a930b50"),
				CreatedInPackageId = new Guid("fb1e3601-9835-4464-96f8-122c8aa27de8"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreatePlatformUserIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("2f6aefd7-f23d-9006-d515-8dc5d817bdd8"),
				Name = @"PlatformUserId",
				CreatedInSchemaUId = new Guid("db18b49b-5228-4648-87af-fe1d4a930b50"),
				ModifiedInSchemaUId = new Guid("db18b49b-5228-4648-87af-fe1d4a930b50"),
				CreatedInPackageId = new Guid("fb1e3601-9835-4464-96f8-122c8aa27de8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AnalyticsAccountUser(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AnalyticsAccountUserSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AnalyticsAccountUserSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db18b49b-5228-4648-87af-fe1d4a930b50"));
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsAccountUser

	/// <summary>
	/// Web analytics account user.
	/// </summary>
	public class AnalyticsAccountUser : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AnalyticsAccountUser(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AnalyticsAccountUser";
		}

		public AnalyticsAccountUser(AnalyticsAccountUser source)
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
		/// Platform user Id.
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
			var process = new AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess(UserConnection);
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
			return new AnalyticsAccountUser(this);
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public partial class AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AnalyticsAccountUser
	{

		public AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess";
			SchemaUId = new Guid("db18b49b-5228-4648-87af-fe1d4a930b50");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("db18b49b-5228-4648-87af-fe1d4a930b50");
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

	#region Class: AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public class AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess : AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess<AnalyticsAccountUser>
	{

		public AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess

	public partial class AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AnalyticsAccountUserEventsProcess

	/// <exclude/>
	public class AnalyticsAccountUserEventsProcess : AnalyticsAccountUser_CrtGoogleAnalyticsEventsProcess
	{

		public AnalyticsAccountUserEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

