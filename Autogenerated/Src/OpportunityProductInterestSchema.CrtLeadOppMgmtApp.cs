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

	#region Class: OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema

	/// <exclude/>
	public class OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema : Terrasoft.Configuration.OpportunityProductInterest_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema(OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema(OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8aeb767c-d65a-4342-bd9b-9ff34f268cd1");
			Name = "OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft";
			ParentSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4f9bdff1-cc29-494c-8369-48e02459331e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8aeb767c-d65a-4342-bd9b-9ff34f268cd1"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft

	/// <summary>
	/// Opportunity product.
	/// </summary>
	public class OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft : Terrasoft.Configuration.OpportunityProductInterest_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft";
		}

		public OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft(OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityProductInterest_CrtLeadOppMgmtApp_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess

	/// <exclude/>
	public partial class OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityProductInterest_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft
	{

		public OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8aeb767c-d65a-4342-bd9b-9ff34f268cd1");
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

	#region Class: OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess

	/// <exclude/>
	public class OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess : OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess<OpportunityProductInterest_CrtLeadOppMgmtApp_Terrasoft>
	{

		public OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess

	public partial class OpportunityProductInterest_CrtLeadOppMgmtAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

