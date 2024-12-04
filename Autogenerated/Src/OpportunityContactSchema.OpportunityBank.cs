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

	#region Class: OpportunityContactSchema

	/// <exclude/>
	public class OpportunityContactSchema : Terrasoft.Configuration.OpportunityContact_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityContactSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityContactSchema(OpportunityContactSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityContactSchema(OpportunityContactSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e3eea431-d238-46cd-a773-592da34facbc");
			Name = "OpportunityContact";
			ParentSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c17f7d7f-cc89-4422-b016-b192862791f4");
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
			return new OpportunityContact(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityContact_OpportunityBankEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityContactSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityContactSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3eea431-d238-46cd-a773-592da34facbc"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact

	/// <summary>
	/// Contact in opportunity.
	/// </summary>
	public class OpportunityContact : Terrasoft.Configuration.OpportunityContact_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityContact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityContact";
		}

		public OpportunityContact(OpportunityContact source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityContact_OpportunityBankEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityContactDeleted", e);
			Saved += (s, e) => ThrowEvent("OpportunityContactSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityContactSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityContactValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityContact(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_OpportunityBankEventsProcess

	/// <exclude/>
	public partial class OpportunityContact_OpportunityBankEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityContact_OpportunityEventsProcess<TEntity> where TEntity : OpportunityContact
	{

		public OpportunityContact_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityContact_OpportunityBankEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e3eea431-d238-46cd-a773-592da34facbc");
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

	#region Class: OpportunityContact_OpportunityBankEventsProcess

	/// <exclude/>
	public class OpportunityContact_OpportunityBankEventsProcess : OpportunityContact_OpportunityBankEventsProcess<OpportunityContact>
	{

		public OpportunityContact_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityContact_OpportunityBankEventsProcess

	public partial class OpportunityContact_OpportunityBankEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityContactEventsProcess

	/// <exclude/>
	public class OpportunityContactEventsProcess : OpportunityContact_OpportunityBankEventsProcess
	{

		public OpportunityContactEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

