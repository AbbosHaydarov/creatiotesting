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

	#region Class: OpportunityTypeSchema

	/// <exclude/>
	public class OpportunityTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OpportunityTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityTypeSchema(OpportunityTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityTypeSchema(OpportunityTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85fe0df7-a970-4717-8f7b-8caba783906b");
			RealUId = new Guid("85fe0df7-a970-4717-8f7b-8caba783906b");
			Name = "OpportunityType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
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
			return new OpportunityType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityType_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85fe0df7-a970-4717-8f7b-8caba783906b"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityType

	/// <summary>
	/// Opportunity Type.
	/// </summary>
	public class OpportunityType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OpportunityType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityType";
		}

		public OpportunityType(OpportunityType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityType_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityTypeInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityTypeSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityTypeSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityType(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityType_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityType_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : OpportunityType
	{

		public OpportunityType_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityType_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("85fe0df7-a970-4717-8f7b-8caba783906b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("85fe0df7-a970-4717-8f7b-8caba783906b");
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

	#region Class: OpportunityType_CrtOpportunityEventsProcess

	/// <exclude/>
	public class OpportunityType_CrtOpportunityEventsProcess : OpportunityType_CrtOpportunityEventsProcess<OpportunityType>
	{

		public OpportunityType_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityType_CrtOpportunityEventsProcess

	public partial class OpportunityType_CrtOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityTypeEventsProcess

	/// <exclude/>
	public class OpportunityTypeEventsProcess : OpportunityType_CrtOpportunityEventsProcess
	{

		public OpportunityTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

