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

	#region Class: FormSubmitSchema

	/// <exclude/>
	public class FormSubmitSchema : Terrasoft.Configuration.FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema
	{

		#region Constructors: Public

		public FormSubmitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmitSchema(FormSubmitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmitSchema(FormSubmitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0d5f564a-d724-47f1-84e1-7535a80aca0a");
			Name = "FormSubmit";
			ParentSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			ExtendParent = true;
			CreatedInPackageId = new Guid("029baff5-b5bb-4ad7-9f88-4a919e7f91f3");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateFullNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FormSubmit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtEngagementToolsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d5f564a-d724-47f1-84e1-7535a80aca0a"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit : Terrasoft.Configuration.FormSubmit_CrtEngagementInCampaignBase_Terrasoft
	{

		#region Constructors: Public

		public FormSubmit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit";
		}

		public FormSubmit(FormSubmit source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtEngagementToolsAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FormSubmitDeleted", e);
			Deleting += (s, e) => ThrowEvent("FormSubmitDeleting", e);
			Inserted += (s, e) => ThrowEvent("FormSubmitInserted", e);
			Saved += (s, e) => ThrowEvent("FormSubmitSaved", e);
			Saving += (s, e) => ThrowEvent("FormSubmitSaving", e);
			Validating += (s, e) => ThrowEvent("FormSubmitValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FormSubmit(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtEngagementToolsAppEventsProcess<TEntity> : Terrasoft.Configuration.FormSubmit_CrtEngagementInCampaignBaseEventsProcess<TEntity> where TEntity : FormSubmit
	{

		public FormSubmit_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtEngagementToolsAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0d5f564a-d724-47f1-84e1-7535a80aca0a");
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

	#region Class: FormSubmit_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public class FormSubmit_CrtEngagementToolsAppEventsProcess : FormSubmit_CrtEngagementToolsAppEventsProcess<FormSubmit>
	{

		public FormSubmit_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementToolsAppEventsProcess

	public partial class FormSubmit_CrtEngagementToolsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FormSubmitEventsProcess

	/// <exclude/>
	public class FormSubmitEventsProcess : FormSubmit_CrtEngagementToolsAppEventsProcess
	{

		public FormSubmitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

