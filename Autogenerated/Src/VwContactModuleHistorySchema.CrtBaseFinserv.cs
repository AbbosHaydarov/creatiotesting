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

	#region Class: VwContactModuleHistorySchema

	/// <exclude/>
	public class VwContactModuleHistorySchema : Terrasoft.Configuration.VwContactModuleHistory_CrtUIv2_TerrasoftSchema
	{

		#region Constructors: Public

		public VwContactModuleHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwContactModuleHistorySchema(VwContactModuleHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwContactModuleHistorySchema(VwContactModuleHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("99304755-3c2d-45e0-8a9d-c8664e8b3d88");
			Name = "VwContactModuleHistory";
			ParentSchemaUId = new Guid("b2df669b-ebc2-4e72-913c-bf68895c27a1");
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
			return new VwContactModuleHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwContactModuleHistory_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwContactModuleHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwContactModuleHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99304755-3c2d-45e0-8a9d-c8664e8b3d88"));
		}

		#endregion

	}

	#endregion

	#region Class: VwContactModuleHistory

	/// <summary>
	/// Contacts section history (view).
	/// </summary>
	public class VwContactModuleHistory : Terrasoft.Configuration.VwContactModuleHistory_CrtUIv2_Terrasoft
	{

		#region Constructors: Public

		public VwContactModuleHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwContactModuleHistory";
		}

		public VwContactModuleHistory(VwContactModuleHistory source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwContactModuleHistory_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwContactModuleHistoryDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwContactModuleHistoryDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwContactModuleHistoryInserted", e);
			Saved += (s, e) => ThrowEvent("VwContactModuleHistorySaved", e);
			Saving += (s, e) => ThrowEvent("VwContactModuleHistorySaving", e);
			Validating += (s, e) => ThrowEvent("VwContactModuleHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwContactModuleHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwContactModuleHistory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwContactModuleHistory_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwContactModuleHistory_CrtUIv2EventsProcess<TEntity> where TEntity : VwContactModuleHistory
	{

		public VwContactModuleHistory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwContactModuleHistory_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("99304755-3c2d-45e0-8a9d-c8664e8b3d88");
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

	#region Class: VwContactModuleHistory_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwContactModuleHistory_CrtBaseFinservEventsProcess : VwContactModuleHistory_CrtBaseFinservEventsProcess<VwContactModuleHistory>
	{

		public VwContactModuleHistory_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwContactModuleHistory_CrtBaseFinservEventsProcess

	public partial class VwContactModuleHistory_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwContactModuleHistoryEventsProcess

	/// <exclude/>
	public class VwContactModuleHistoryEventsProcess : VwContactModuleHistory_CrtBaseFinservEventsProcess
	{

		public VwContactModuleHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

