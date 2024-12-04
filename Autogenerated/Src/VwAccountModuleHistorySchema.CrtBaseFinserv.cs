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

	#region Class: VwAccountModuleHistorySchema

	/// <exclude/>
	public class VwAccountModuleHistorySchema : Terrasoft.Configuration.VwAccountModuleHistory_CrtUIv2_TerrasoftSchema
	{

		#region Constructors: Public

		public VwAccountModuleHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAccountModuleHistorySchema(VwAccountModuleHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAccountModuleHistorySchema(VwAccountModuleHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("12144bbd-4086-409e-9e93-438de739ea3f");
			Name = "VwAccountModuleHistory";
			ParentSchemaUId = new Guid("96e6243d-dc48-462a-aa5f-c75d4471c39e");
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
			return new VwAccountModuleHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAccountModuleHistory_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAccountModuleHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAccountModuleHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12144bbd-4086-409e-9e93-438de739ea3f"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountModuleHistory

	/// <summary>
	/// Legal entity section history (view).
	/// </summary>
	public class VwAccountModuleHistory : Terrasoft.Configuration.VwAccountModuleHistory_CrtUIv2_Terrasoft
	{

		#region Constructors: Public

		public VwAccountModuleHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAccountModuleHistory";
		}

		public VwAccountModuleHistory(VwAccountModuleHistory source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAccountModuleHistory_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwAccountModuleHistoryDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwAccountModuleHistoryDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwAccountModuleHistoryInserted", e);
			Saved += (s, e) => ThrowEvent("VwAccountModuleHistorySaved", e);
			Saving += (s, e) => ThrowEvent("VwAccountModuleHistorySaving", e);
			Validating += (s, e) => ThrowEvent("VwAccountModuleHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAccountModuleHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountModuleHistory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwAccountModuleHistory_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwAccountModuleHistory_CrtUIv2EventsProcess<TEntity> where TEntity : VwAccountModuleHistory
	{

		public VwAccountModuleHistory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAccountModuleHistory_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("12144bbd-4086-409e-9e93-438de739ea3f");
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

	#region Class: VwAccountModuleHistory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwAccountModuleHistory_CrtBaseFinservEventsProcess : VwAccountModuleHistory_CrtBaseFinservEventsProcess<VwAccountModuleHistory>
	{

		public VwAccountModuleHistory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAccountModuleHistory_CrtBaseFinservEventsProcess

	public partial class VwAccountModuleHistory_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwAccountModuleHistoryEventsProcess

	/// <exclude/>
	public class VwAccountModuleHistoryEventsProcess : VwAccountModuleHistory_CrtBaseFinservEventsProcess
	{

		public VwAccountModuleHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

