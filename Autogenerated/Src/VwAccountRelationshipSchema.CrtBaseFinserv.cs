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

	#region Class: VwAccountRelationshipSchema

	/// <exclude/>
	public class VwAccountRelationshipSchema : Terrasoft.Configuration.VwAccountRelationship_CrtNUI_TerrasoftSchema
	{

		#region Constructors: Public

		public VwAccountRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAccountRelationshipSchema(VwAccountRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAccountRelationshipSchema(VwAccountRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("03c0679c-d528-4348-833e-0811849405ff");
			Name = "VwAccountRelationship";
			ParentSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
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
			return new VwAccountRelationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAccountRelationship_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAccountRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAccountRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03c0679c-d528-4348-833e-0811849405ff"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountRelationship

	/// <summary>
	/// Relationship of legal entity (view).
	/// </summary>
	public class VwAccountRelationship : Terrasoft.Configuration.VwAccountRelationship_CrtNUI_Terrasoft
	{

		#region Constructors: Public

		public VwAccountRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAccountRelationship";
		}

		public VwAccountRelationship(VwAccountRelationship source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAccountRelationship_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwAccountRelationshipDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwAccountRelationshipDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwAccountRelationshipInserted", e);
			Saved += (s, e) => ThrowEvent("VwAccountRelationshipSaved", e);
			Saving += (s, e) => ThrowEvent("VwAccountRelationshipSaving", e);
			Validating += (s, e) => ThrowEvent("VwAccountRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAccountRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountRelationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwAccountRelationship_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwAccountRelationship_CrtNUIEventsProcess<TEntity> where TEntity : VwAccountRelationship
	{

		public VwAccountRelationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAccountRelationship_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("03c0679c-d528-4348-833e-0811849405ff");
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

	#region Class: VwAccountRelationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwAccountRelationship_CrtBaseFinservEventsProcess : VwAccountRelationship_CrtBaseFinservEventsProcess<VwAccountRelationship>
	{

		public VwAccountRelationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAccountRelationship_CrtBaseFinservEventsProcess

	public partial class VwAccountRelationship_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwAccountRelationshipEventsProcess

	/// <exclude/>
	public class VwAccountRelationshipEventsProcess : VwAccountRelationship_CrtBaseFinservEventsProcess
	{

		public VwAccountRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

