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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;

	#region Class: VwSysAdminUnitSchema

	/// <exclude/>
	public class VwSysAdminUnitSchema : Terrasoft.Configuration.VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysAdminUnitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysAdminUnitSchema(VwSysAdminUnitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysAdminUnitSchema(VwSysAdminUnitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("83270e6d-120f-4905-9bc9-0cbe25afe954");
			Name = "VwSysAdminUnit";
			ParentSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			ExtendParent = true;
			CreatedInPackageId = new Guid("27329051-b308-4a64-83ef-1a0f05a9ca5f");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateLDAPEntryColumn() {
			EntitySchemaColumn column = base.CreateLDAPEntryColumn();
			column.ModifiedInSchemaUId = new Guid("83270e6d-120f-4905-9bc9-0cbe25afe954");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysAdminUnit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysAdminUnit_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysAdminUnitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysAdminUnitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83270e6d-120f-4905-9bc9-0cbe25afe954"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit

	/// <summary>
	/// Users/roles (view).
	/// </summary>
	public class VwSysAdminUnit : Terrasoft.Configuration.VwSysAdminUnit_WebitelCollaborations_Terrasoft
	{

		#region Constructors: Public

		public VwSysAdminUnit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysAdminUnit";
		}

		public VwSysAdminUnit(VwSysAdminUnit source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysAdminUnit_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysAdminUnitDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysAdminUnitDeleting", e);
			Inserting += (s, e) => ThrowEvent("VwSysAdminUnitInserting", e);
			Saved += (s, e) => ThrowEvent("VwSysAdminUnitSaved", e);
			Saving += (s, e) => ThrowEvent("VwSysAdminUnitSaving", e);
			Updated += (s, e) => ThrowEvent("VwSysAdminUnitUpdated", e);
			Validating += (s, e) => ThrowEvent("VwSysAdminUnitValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwSysAdminUnit_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwSysAdminUnit_WebitelCollaborationsEventsProcess<TEntity> where TEntity : VwSysAdminUnit
	{

		public VwSysAdminUnit_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysAdminUnit_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("83270e6d-120f-4905-9bc9-0cbe25afe954");
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

	#region Class: VwSysAdminUnit_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwSysAdminUnit_CrtBaseFinservEventsProcess : VwSysAdminUnit_CrtBaseFinservEventsProcess<VwSysAdminUnit>
	{

		public VwSysAdminUnit_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysAdminUnit_CrtBaseFinservEventsProcess

	public partial class VwSysAdminUnit_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSysAdminUnitEventsProcess

	/// <exclude/>
	public class VwSysAdminUnitEventsProcess : VwSysAdminUnit_CrtBaseFinservEventsProcess
	{

		public VwSysAdminUnitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

