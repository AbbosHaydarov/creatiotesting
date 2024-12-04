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

	#region Class: OpportunityParticipantSchema

	/// <exclude/>
	public class OpportunityParticipantSchema : Terrasoft.Configuration.OpportunityParticipant_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityParticipantSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityParticipantSchema(OpportunityParticipantSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityParticipantSchema(OpportunityParticipantSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("998341ea-c7f3-4d17-abf1-6cd037ee00b1");
			Name = "OpportunityParticipant";
			ParentSchemaUId = new Guid("0695af13-f66f-4935-a911-4cedc20c5a81");
			ExtendParent = true;
			CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2");
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
			return new OpportunityParticipant(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityParticipant_OpportunityBankEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityParticipantSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityParticipantSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("998341ea-c7f3-4d17-abf1-6cd037ee00b1"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityParticipant

	/// <summary>
	/// Opportunity participant.
	/// </summary>
	public class OpportunityParticipant : Terrasoft.Configuration.OpportunityParticipant_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityParticipant(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityParticipant";
		}

		public OpportunityParticipant(OpportunityParticipant source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityParticipant_OpportunityBankEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityParticipantDeleted", e);
			Validating += (s, e) => ThrowEvent("OpportunityParticipantValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityParticipant(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityParticipant_OpportunityBankEventsProcess

	/// <exclude/>
	public partial class OpportunityParticipant_OpportunityBankEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityParticipant_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityParticipant
	{

		public OpportunityParticipant_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityParticipant_OpportunityBankEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("998341ea-c7f3-4d17-abf1-6cd037ee00b1");
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

	#region Class: OpportunityParticipant_OpportunityBankEventsProcess

	/// <exclude/>
	public class OpportunityParticipant_OpportunityBankEventsProcess : OpportunityParticipant_OpportunityBankEventsProcess<OpportunityParticipant>
	{

		public OpportunityParticipant_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityParticipant_OpportunityBankEventsProcess

	public partial class OpportunityParticipant_OpportunityBankEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityParticipantEventsProcess

	/// <exclude/>
	public class OpportunityParticipantEventsProcess : OpportunityParticipant_OpportunityBankEventsProcess
	{

		public OpportunityParticipantEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

