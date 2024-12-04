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

	#region Class: OpportunityDepartmentSchema

	/// <exclude/>
	public class OpportunityDepartmentSchema : Terrasoft.Configuration.OpportunityDepartment_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityDepartmentSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityDepartmentSchema(OpportunityDepartmentSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityDepartmentSchema(OpportunityDepartmentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5f8002eb-0344-4434-932a-97e692c4ac67");
			Name = "OpportunityDepartment";
			ParentSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("37e2bfcf-2f62-4b64-b483-fd58dd829849");
			IsDBView = false;
			UseDenyRecordRights = false;
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
			return new OpportunityDepartment(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityDepartment_LeadFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityDepartmentSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityDepartmentSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f8002eb-0344-4434-932a-97e692c4ac67"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityDepartment

	/// <summary>
	/// Sales division.
	/// </summary>
	public class OpportunityDepartment : Terrasoft.Configuration.OpportunityDepartment_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public OpportunityDepartment(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityDepartment";
		}

		public OpportunityDepartment(OpportunityDepartment source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityDepartment_LeadFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityDepartmentDeleted", e);
			Validating += (s, e) => ThrowEvent("OpportunityDepartmentValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityDepartment(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityDepartment_LeadFinanceEventsProcess

	/// <exclude/>
	public partial class OpportunityDepartment_LeadFinanceEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityDepartment_CrtLeadEventsProcess<TEntity> where TEntity : OpportunityDepartment
	{

		public OpportunityDepartment_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityDepartment_LeadFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5f8002eb-0344-4434-932a-97e692c4ac67");
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

	#region Class: OpportunityDepartment_LeadFinanceEventsProcess

	/// <exclude/>
	public class OpportunityDepartment_LeadFinanceEventsProcess : OpportunityDepartment_LeadFinanceEventsProcess<OpportunityDepartment>
	{

		public OpportunityDepartment_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityDepartment_LeadFinanceEventsProcess

	public partial class OpportunityDepartment_LeadFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityDepartmentEventsProcess

	/// <exclude/>
	public class OpportunityDepartmentEventsProcess : OpportunityDepartment_LeadFinanceEventsProcess
	{

		public OpportunityDepartmentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

