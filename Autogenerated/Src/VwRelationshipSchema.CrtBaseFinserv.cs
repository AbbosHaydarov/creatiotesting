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

	#region Class: VwRelationshipSchema

	/// <exclude/>
	public class VwRelationshipSchema : Terrasoft.Configuration.VwRelationship_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public VwRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwRelationshipSchema(VwRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwRelationshipSchema(VwRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("dfa07e37-da00-4b70-8985-d734fe174a1a");
			Name = "VwRelationship";
			ParentSchemaUId = new Guid("8409eced-ba37-4a6a-a031-671fcb7be3e2");
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
			return new VwRelationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwRelationship_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfa07e37-da00-4b70-8985-d734fe174a1a"));
		}

		#endregion

	}

	#endregion

	#region Class: VwRelationship

	/// <summary>
	/// Relationship (view).
	/// </summary>
	public class VwRelationship : Terrasoft.Configuration.VwRelationship_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public VwRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwRelationship";
		}

		public VwRelationship(VwRelationship source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwRelationship_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwRelationshipDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwRelationshipDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwRelationshipInserted", e);
			Saved += (s, e) => ThrowEvent("VwRelationshipSaved", e);
			Saving += (s, e) => ThrowEvent("VwRelationshipSaving", e);
			Validating += (s, e) => ThrowEvent("VwRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwRelationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwRelationship_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwRelationship_CrtBaseEventsProcess<TEntity> where TEntity : VwRelationship
	{

		public VwRelationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwRelationship_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dfa07e37-da00-4b70-8985-d734fe174a1a");
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

	#region Class: VwRelationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwRelationship_CrtBaseFinservEventsProcess : VwRelationship_CrtBaseFinservEventsProcess<VwRelationship>
	{

		public VwRelationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwRelationship_CrtBaseFinservEventsProcess

	public partial class VwRelationship_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwRelationshipEventsProcess

	/// <exclude/>
	public class VwRelationshipEventsProcess : VwRelationship_CrtBaseFinservEventsProcess
	{

		public VwRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

