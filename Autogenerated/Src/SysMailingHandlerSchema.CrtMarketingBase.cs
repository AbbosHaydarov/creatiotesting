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

	#region Class: SysMailingHandler_CrtMarketingBase_TerrasoftSchema

	/// <exclude/>
	public class SysMailingHandler_CrtMarketingBase_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysMailingHandler_CrtMarketingBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysMailingHandler_CrtMarketingBase_TerrasoftSchema(SysMailingHandler_CrtMarketingBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysMailingHandler_CrtMarketingBase_TerrasoftSchema(SysMailingHandler_CrtMarketingBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810");
			RealUId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810");
			Name = "SysMailingHandler_CrtMarketingBase_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
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
			if (Columns.FindByUId(new Guid("22f6954c-894d-4cd2-90ec-c6daf8741dc1")) == null) {
				Columns.Add(CreateClassNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("24d948e8-b33f-4289-9854-3d48f47a3db1"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810"),
				ModifiedInSchemaUId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810"),
				CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0")
			};
		}

		protected virtual EntitySchemaColumn CreateClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("22f6954c-894d-4cd2-90ec-c6daf8741dc1"),
				Name = @"ClassName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810"),
				ModifiedInSchemaUId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810"),
				CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysMailingHandler_CrtMarketingBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysMailingHandler_CrtMarketingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysMailingHandler_CrtMarketingBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysMailingHandler_CrtMarketingBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810"));
		}

		#endregion

	}

	#endregion

	#region Class: SysMailingHandler_CrtMarketingBase_Terrasoft

	/// <summary>
	/// Mailing handler.
	/// </summary>
	public class SysMailingHandler_CrtMarketingBase_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysMailingHandler_CrtMarketingBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysMailingHandler_CrtMarketingBase_Terrasoft";
		}

		public SysMailingHandler_CrtMarketingBase_Terrasoft(SysMailingHandler_CrtMarketingBase_Terrasoft source)
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

		/// <summary>
		/// Class name.
		/// </summary>
		public string ClassName {
			get {
				return GetTypedColumnValue<string>("ClassName");
			}
			set {
				SetColumnValue("ClassName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysMailingHandler_CrtMarketingBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysMailingHandler_CrtMarketingBase_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("SysMailingHandler_CrtMarketingBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMailingHandler_CrtMarketingBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysMailingHandler_CrtMarketingBaseEventsProcess

	/// <exclude/>
	public partial class SysMailingHandler_CrtMarketingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysMailingHandler_CrtMarketingBase_Terrasoft
	{

		public SysMailingHandler_CrtMarketingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMailingHandler_CrtMarketingBaseEventsProcess";
			SchemaUId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810");
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

	#region Class: SysMailingHandler_CrtMarketingBaseEventsProcess

	/// <exclude/>
	public class SysMailingHandler_CrtMarketingBaseEventsProcess : SysMailingHandler_CrtMarketingBaseEventsProcess<SysMailingHandler_CrtMarketingBase_Terrasoft>
	{

		public SysMailingHandler_CrtMarketingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMailingHandler_CrtMarketingBaseEventsProcess

	public partial class SysMailingHandler_CrtMarketingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

