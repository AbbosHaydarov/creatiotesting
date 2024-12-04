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

	#region Class: VwModuleHistorySchema

	/// <exclude/>
	public class VwModuleHistorySchema : Terrasoft.Configuration.VwModuleHistory_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public VwModuleHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwModuleHistorySchema(VwModuleHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwModuleHistorySchema(VwModuleHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("81f691b7-0af7-462f-8bff-14482bd6fd68");
			Name = "VwModuleHistory";
			ParentSchemaUId = new Guid("2b1c75be-117a-42fb-aa1d-58ce1ec4cba1");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
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
			return new VwModuleHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwModuleHistory_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwModuleHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwModuleHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81f691b7-0af7-462f-8bff-14482bd6fd68"));
		}

		#endregion

	}

	#endregion

	#region Class: VwModuleHistory

	/// <summary>
	/// Section history (view).
	/// </summary>
	public class VwModuleHistory : Terrasoft.Configuration.VwModuleHistory_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public VwModuleHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwModuleHistory";
		}

		public VwModuleHistory(VwModuleHistory source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwModuleHistory_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwModuleHistoryDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwModuleHistoryDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwModuleHistoryInserted", e);
			Saved += (s, e) => ThrowEvent("VwModuleHistorySaved", e);
			Saving += (s, e) => ThrowEvent("VwModuleHistorySaving", e);
			Validating += (s, e) => ThrowEvent("VwModuleHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwModuleHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwModuleHistory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwModuleHistory_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwModuleHistory_CrtBaseEventsProcess<TEntity> where TEntity : VwModuleHistory
	{

		public VwModuleHistory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwModuleHistory_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("81f691b7-0af7-462f-8bff-14482bd6fd68");
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

	#region Class: VwModuleHistory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwModuleHistory_CrtBaseFinservEventsProcess : VwModuleHistory_CrtBaseFinservEventsProcess<VwModuleHistory>
	{

		public VwModuleHistory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwModuleHistory_CrtBaseFinservEventsProcess

	public partial class VwModuleHistory_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwModuleHistoryEventsProcess

	/// <exclude/>
	public class VwModuleHistoryEventsProcess : VwModuleHistory_CrtBaseFinservEventsProcess
	{

		public VwModuleHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

