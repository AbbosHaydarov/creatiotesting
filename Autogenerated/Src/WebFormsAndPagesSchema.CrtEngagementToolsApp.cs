namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: WebFormsAndPagesSchema

	/// <exclude/>
	public class WebFormsAndPagesSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WebFormsAndPagesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebFormsAndPagesSchema(WebFormsAndPagesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebFormsAndPagesSchema(WebFormsAndPagesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e414f84-4a40-4114-8957-9a68e35f3186");
			RealUId = new Guid("9e414f84-4a40-4114-8957-9a68e35f3186");
			Name = "WebFormsAndPages";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6f71e54c-1960-40c9-94f6-073fd67699ab");
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
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3b627134-34d4-49a8-8c3c-3d8fcbf9121b"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("9e414f84-4a40-4114-8957-9a68e35f3186"),
				ModifiedInSchemaUId = new Guid("9e414f84-4a40-4114-8957-9a68e35f3186"),
				CreatedInPackageId = new Guid("6f71e54c-1960-40c9-94f6-073fd67699ab")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebFormsAndPages(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebFormsAndPages_CrtEngagementToolsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebFormsAndPagesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebFormsAndPagesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e414f84-4a40-4114-8957-9a68e35f3186"));
		}

		#endregion

	}

	#endregion

	#region Class: WebFormsAndPages

	/// <summary>
	/// Web forms and pages.
	/// </summary>
	public class WebFormsAndPages : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WebFormsAndPages(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebFormsAndPages";
		}

		public WebFormsAndPages(WebFormsAndPages source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebFormsAndPages_CrtEngagementToolsAppEventsProcess(UserConnection);
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
			return new WebFormsAndPages(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebFormsAndPages_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public partial class WebFormsAndPages_CrtEngagementToolsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : WebFormsAndPages
	{

		public WebFormsAndPages_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebFormsAndPages_CrtEngagementToolsAppEventsProcess";
			SchemaUId = new Guid("9e414f84-4a40-4114-8957-9a68e35f3186");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9e414f84-4a40-4114-8957-9a68e35f3186");
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

	#region Class: WebFormsAndPages_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public class WebFormsAndPages_CrtEngagementToolsAppEventsProcess : WebFormsAndPages_CrtEngagementToolsAppEventsProcess<WebFormsAndPages>
	{

		public WebFormsAndPages_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebFormsAndPages_CrtEngagementToolsAppEventsProcess

	public partial class WebFormsAndPages_CrtEngagementToolsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebFormsAndPagesEventsProcess

	/// <exclude/>
	public class WebFormsAndPagesEventsProcess : WebFormsAndPages_CrtEngagementToolsAppEventsProcess
	{

		public WebFormsAndPagesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

