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

	#region Class: GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema

	/// <exclude/>
	public class GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema : Terrasoft.Configuration.GeneratedWebForm_CrtWebForm_TerrasoftSchema
	{

		#region Constructors: Public

		public GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema(GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema(GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1");
			Name = "GeneratedWebForm_CrtEngagementToolsApp_Terrasoft";
			ParentSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b5a21ae5-6b53-4a07-8184-9dca88e51cce");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c996634a-5883-d899-c0ed-04c029e63450")) == null) {
				Columns.Add(CreateIsFbWebFormColumn());
			}
			if (Columns.FindByUId(new Guid("f38f3fd3-8bed-02a5-7b80-c93d7f27232d")) == null) {
				Columns.Add(CreateWebPageNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateStateColumn() {
			EntitySchemaColumn column = base.CreateStateColumn();
			column.IsValueCloneable = false;
			column.ModifiedInSchemaUId = new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1");
			return column;
		}

		protected virtual EntitySchemaColumn CreateIsFbWebFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c996634a-5883-d899-c0ed-04c029e63450"),
				Name = @"IsFbWebForm",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1"),
				ModifiedInSchemaUId = new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1"),
				CreatedInPackageId = new Guid("b5a21ae5-6b53-4a07-8184-9dca88e51cce"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateWebPageNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f38f3fd3-8bed-02a5-7b80-c93d7f27232d"),
				Name = @"WebPageName",
				CreatedInSchemaUId = new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1"),
				ModifiedInSchemaUId = new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1"),
				CreatedInPackageId = new Guid("7512d77f-7894-4390-8186-ddc6f1685a9e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new GeneratedWebForm_CrtEngagementToolsApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new GeneratedWebForm_CrtEngagementToolsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1"));
		}

		#endregion

	}

	#endregion

	#region Class: GeneratedWebForm_CrtEngagementToolsApp_Terrasoft

	/// <summary>
	/// Landing page (web form).
	/// </summary>
	public class GeneratedWebForm_CrtEngagementToolsApp_Terrasoft : Terrasoft.Configuration.GeneratedWebForm_CrtWebForm_Terrasoft
	{

		#region Constructors: Public

		public GeneratedWebForm_CrtEngagementToolsApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "GeneratedWebForm_CrtEngagementToolsApp_Terrasoft";
		}

		public GeneratedWebForm_CrtEngagementToolsApp_Terrasoft(GeneratedWebForm_CrtEngagementToolsApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Facebook integration enabled.
		/// </summary>
		public bool IsFbWebForm {
			get {
				return GetTypedColumnValue<bool>("IsFbWebForm");
			}
			set {
				SetColumnValue("IsFbWebForm", value);
			}
		}

		/// <summary>
		/// Web page.
		/// </summary>
		public string WebPageName {
			get {
				return GetTypedColumnValue<string>("WebPageName");
			}
			set {
				SetColumnValue("WebPageName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new GeneratedWebForm_CrtEngagementToolsAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("GeneratedWebForm_CrtEngagementToolsApp_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("GeneratedWebForm_CrtEngagementToolsApp_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("GeneratedWebForm_CrtEngagementToolsApp_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GeneratedWebForm_CrtEngagementToolsApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: GeneratedWebForm_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public partial class GeneratedWebForm_CrtEngagementToolsAppEventsProcess<TEntity> : Terrasoft.Configuration.GeneratedWebForm_CrtWebFormEventsProcess<TEntity> where TEntity : GeneratedWebForm_CrtEngagementToolsApp_Terrasoft
	{

		public GeneratedWebForm_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "GeneratedWebForm_CrtEngagementToolsAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("63081bd3-c85a-45dc-944f-3df22b5411e1");
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

	#region Class: GeneratedWebForm_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public class GeneratedWebForm_CrtEngagementToolsAppEventsProcess : GeneratedWebForm_CrtEngagementToolsAppEventsProcess<GeneratedWebForm_CrtEngagementToolsApp_Terrasoft>
	{

		public GeneratedWebForm_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: GeneratedWebForm_CrtEngagementToolsAppEventsProcess

	public partial class GeneratedWebForm_CrtEngagementToolsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

