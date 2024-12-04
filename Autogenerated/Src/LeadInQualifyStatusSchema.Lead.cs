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

	#region Class: LeadInQualifyStatusSchema

	/// <exclude/>
	public class LeadInQualifyStatusSchema : Terrasoft.Configuration.LeadInQualifyStatus_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadInQualifyStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadInQualifyStatusSchema(LeadInQualifyStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadInQualifyStatusSchema(LeadInQualifyStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("92ba9c15-92ca-4941-a562-ca38c808a841");
			Name = "LeadInQualifyStatus";
			ParentSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			IsDBView = false;
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
			return new LeadInQualifyStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadInQualifyStatus_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadInQualifyStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadInQualifyStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92ba9c15-92ca-4941-a562-ca38c808a841"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadInQualifyStatus

	/// <summary>
	/// Stage in lead.
	/// </summary>
	public class LeadInQualifyStatus : Terrasoft.Configuration.LeadInQualifyStatus_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public LeadInQualifyStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadInQualifyStatus";
		}

		public LeadInQualifyStatus(LeadInQualifyStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadInQualifyStatus_LeadEventsProcess(UserConnection);
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
			return new LeadInQualifyStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadInQualifyStatus_LeadEventsProcess

	/// <exclude/>
	public partial class LeadInQualifyStatus_LeadEventsProcess<TEntity> : Terrasoft.Configuration.LeadInQualifyStatus_CrtLeadEventsProcess<TEntity> where TEntity : LeadInQualifyStatus
	{

		public LeadInQualifyStatus_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadInQualifyStatus_LeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("92ba9c15-92ca-4941-a562-ca38c808a841");
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

	#region Class: LeadInQualifyStatus_LeadEventsProcess

	/// <exclude/>
	public class LeadInQualifyStatus_LeadEventsProcess : LeadInQualifyStatus_LeadEventsProcess<LeadInQualifyStatus>
	{

		public LeadInQualifyStatus_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadInQualifyStatus_LeadEventsProcess

	public partial class LeadInQualifyStatus_LeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadInQualifyStatusEventsProcess

	/// <exclude/>
	public class LeadInQualifyStatusEventsProcess : LeadInQualifyStatus_LeadEventsProcess
	{

		public LeadInQualifyStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

