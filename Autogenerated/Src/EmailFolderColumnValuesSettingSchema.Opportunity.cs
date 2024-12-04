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

	#region Class: EmailFolderColumnValuesSettingSchema

	/// <exclude/>
	public class EmailFolderColumnValuesSettingSchema : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Document_TerrasoftSchema
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSettingSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailFolderColumnValuesSettingSchema(EmailFolderColumnValuesSettingSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailFolderColumnValuesSettingSchema(EmailFolderColumnValuesSettingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("69532f7a-527b-44ac-833d-61570d0ad673");
			Name = "EmailFolderColumnValuesSetting";
			ParentSchemaUId = new Guid("77ffb765-d7ad-4f91-9027-92cdf97b4c1f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("62283f71-c300-41f6-aa2b-0bd2cb7348ea")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("62283f71-c300-41f6-aa2b-0bd2cb7348ea"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("69532f7a-527b-44ac-833d-61570d0ad673"),
				ModifiedInSchemaUId = new Guid("69532f7a-527b-44ac-833d-61570d0ad673"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailFolderColumnValuesSetting(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailFolderColumnValuesSetting_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailFolderColumnValuesSettingSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailFolderColumnValuesSettingSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69532f7a-527b-44ac-833d-61570d0ad673"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting

	/// <summary>
	/// Setup of email folder field values.
	/// </summary>
	public class EmailFolderColumnValuesSetting : Terrasoft.Configuration.EmailFolderColumnValuesSetting_Document_Terrasoft
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailFolderColumnValuesSetting";
		}

		public EmailFolderColumnValuesSetting(EmailFolderColumnValuesSetting source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailFolderColumnValuesSetting_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailFolderColumnValuesSettingDeleted", e);
			Inserting += (s, e) => ThrowEvent("EmailFolderColumnValuesSettingInserting", e);
			Validating += (s, e) => ThrowEvent("EmailFolderColumnValuesSettingValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailFolderColumnValuesSetting(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_OpportunityEventsProcess

	/// <exclude/>
	public partial class EmailFolderColumnValuesSetting_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.EmailFolderColumnValuesSetting_DocumentEventsProcess<TEntity> where TEntity : EmailFolderColumnValuesSetting
	{

		public EmailFolderColumnValuesSetting_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailFolderColumnValuesSetting_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("69532f7a-527b-44ac-833d-61570d0ad673");
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

	#region Class: EmailFolderColumnValuesSetting_OpportunityEventsProcess

	/// <exclude/>
	public class EmailFolderColumnValuesSetting_OpportunityEventsProcess : EmailFolderColumnValuesSetting_OpportunityEventsProcess<EmailFolderColumnValuesSetting>
	{

		public EmailFolderColumnValuesSetting_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailFolderColumnValuesSetting_OpportunityEventsProcess

	public partial class EmailFolderColumnValuesSetting_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmailFolderColumnValuesSettingEventsProcess

	/// <exclude/>
	public class EmailFolderColumnValuesSettingEventsProcess : EmailFolderColumnValuesSetting_OpportunityEventsProcess
	{

		public EmailFolderColumnValuesSettingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

