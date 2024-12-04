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

	#region Class: SenderDomainSchema

	/// <exclude/>
	public class SenderDomainSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SenderDomainSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SenderDomainSchema(SenderDomainSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SenderDomainSchema(SenderDomainSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47");
			RealUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47");
			Name = "SenderDomain";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a141f40d-dd6f-f2a6-b1e7-097697e61579")) == null) {
				Columns.Add(CreateDomainColumn());
			}
			if (Columns.FindByUId(new Guid("f065d4a5-e71f-458e-a3c7-16598d5e8624")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("c40e46bc-d3ad-b45a-f321-89595cc93fdc")) == null) {
				Columns.Add(CreateSpfKeyColumn());
			}
			if (Columns.FindByUId(new Guid("fd4de9c2-9b0f-a176-f7f7-8011b7945fd0")) == null) {
				Columns.Add(CreateMxColumn());
			}
			if (Columns.FindByUId(new Guid("20abf5ab-bf0b-5240-06ab-78184d7c0f5d")) == null) {
				Columns.Add(CreateKeyColumn());
			}
			if (Columns.FindByUId(new Guid("66ba7d56-ed40-b001-edb0-cf49ea5e3cce")) == null) {
				Columns.Add(CreateErrorColumn());
			}
			if (Columns.FindByUId(new Guid("5fd911df-35c6-def2-e3b0-702ff3a69ef6")) == null) {
				Columns.Add(CreateSenderDomainsInfoColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDomainColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a141f40d-dd6f-f2a6-b1e7-097697e61579"),
				Name = @"Domain",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				ModifiedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f065d4a5-e71f-458e-a3c7-16598d5e8624"),
				Name = @"Status",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				ModifiedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf")
			};
		}

		protected virtual EntitySchemaColumn CreateSpfKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c40e46bc-d3ad-b45a-f321-89595cc93fdc"),
				Name = @"SpfKey",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				ModifiedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf")
			};
		}

		protected virtual EntitySchemaColumn CreateMxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("fd4de9c2-9b0f-a176-f7f7-8011b7945fd0"),
				Name = @"Mx",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				ModifiedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf")
			};
		}

		protected virtual EntitySchemaColumn CreateKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("20abf5ab-bf0b-5240-06ab-78184d7c0f5d"),
				Name = @"Key",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				ModifiedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("66ba7d56-ed40-b001-edb0-cf49ea5e3cce"),
				Name = @"Error",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				ModifiedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf")
			};
		}

		protected virtual EntitySchemaColumn CreateSenderDomainsInfoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5fd911df-35c6-def2-e3b0-702ff3a69ef6"),
				Name = @"SenderDomainsInfo",
				ReferenceSchemaUId = new Guid("fe7368cb-c4c8-417b-beb1-d5a848d468e9"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				ModifiedInSchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"),
				CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf"),
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
			return new SenderDomain(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SenderDomain_BpmonlineCloudIntegrationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SenderDomainSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SenderDomainSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47"));
		}

		#endregion

	}

	#endregion

	#region Class: SenderDomain

	/// <summary>
	/// Sender domain.
	/// </summary>
	public class SenderDomain : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SenderDomain(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SenderDomain";
		}

		public SenderDomain(SenderDomain source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Domain.
		/// </summary>
		public string Domain {
			get {
				return GetTypedColumnValue<string>("Domain");
			}
			set {
				SetColumnValue("Domain", value);
			}
		}

		/// <summary>
		/// Status.
		/// </summary>
		public string Status {
			get {
				return GetTypedColumnValue<string>("Status");
			}
			set {
				SetColumnValue("Status", value);
			}
		}

		/// <summary>
		/// SPF key.
		/// </summary>
		public string SpfKey {
			get {
				return GetTypedColumnValue<string>("SpfKey");
			}
			set {
				SetColumnValue("SpfKey", value);
			}
		}

		/// <summary>
		/// Mx key.
		/// </summary>
		public string Mx {
			get {
				return GetTypedColumnValue<string>("Mx");
			}
			set {
				SetColumnValue("Mx", value);
			}
		}

		/// <summary>
		/// Key.
		/// </summary>
		public string Key {
			get {
				return GetTypedColumnValue<string>("Key");
			}
			set {
				SetColumnValue("Key", value);
			}
		}

		/// <summary>
		/// Error.
		/// </summary>
		public string Error {
			get {
				return GetTypedColumnValue<string>("Error");
			}
			set {
				SetColumnValue("Error", value);
			}
		}

		/// <exclude/>
		public Guid SenderDomainsInfoId {
			get {
				return GetTypedColumnValue<Guid>("SenderDomainsInfoId");
			}
			set {
				SetColumnValue("SenderDomainsInfoId", value);
				_senderDomainsInfo = null;
			}
		}

		private SenderDomainsInfo _senderDomainsInfo;
		/// <summary>
		/// Sender domains info.
		/// </summary>
		public SenderDomainsInfo SenderDomainsInfo {
			get {
				return _senderDomainsInfo ??
					(_senderDomainsInfo = LookupColumnEntities.GetEntity("SenderDomainsInfo") as SenderDomainsInfo);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SenderDomain_BpmonlineCloudIntegrationEventsProcess(UserConnection);
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
			return new SenderDomain(this);
		}

		#endregion

	}

	#endregion

	#region Class: SenderDomain_BpmonlineCloudIntegrationEventsProcess

	/// <exclude/>
	public partial class SenderDomain_BpmonlineCloudIntegrationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SenderDomain
	{

		public SenderDomain_BpmonlineCloudIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SenderDomain_BpmonlineCloudIntegrationEventsProcess";
			SchemaUId = new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d9c030ec-7865-4a4d-8878-fa2d6019ab47");
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

	#region Class: SenderDomain_BpmonlineCloudIntegrationEventsProcess

	/// <exclude/>
	public class SenderDomain_BpmonlineCloudIntegrationEventsProcess : SenderDomain_BpmonlineCloudIntegrationEventsProcess<SenderDomain>
	{

		public SenderDomain_BpmonlineCloudIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SenderDomain_BpmonlineCloudIntegrationEventsProcess

	public partial class SenderDomain_BpmonlineCloudIntegrationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SenderDomainEventsProcess

	/// <exclude/>
	public class SenderDomainEventsProcess : SenderDomain_BpmonlineCloudIntegrationEventsProcess
	{

		public SenderDomainEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

