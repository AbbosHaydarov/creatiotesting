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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: OpportunityTagSchema

	/// <exclude/>
	public class OpportunityTagSchema : Terrasoft.Configuration.OpportunityTag_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityTagSchema(OpportunityTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityTagSchema(OpportunityTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("df36dc15-9430-458d-8d85-bdc9e47c1b4c");
			Name = "OpportunityTag";
			ParentSchemaUId = new Guid("7e18476b-185f-406b-b415-b942b35b4c0b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new OpportunityTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityTag_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df36dc15-9430-458d-8d85-bdc9e47c1b4c"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityTag

	/// <summary>
	/// Opportunities section tag.
	/// </summary>
	public class OpportunityTag : Terrasoft.Configuration.OpportunityTag_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityTag";
		}

		public OpportunityTag(OpportunityTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityTag_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityTagDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityTagInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityTagInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityTagSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityTagSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityTag_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityTag_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityTag_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityTag
	{

		public OpportunityTag_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityTag_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("df36dc15-9430-458d-8d85-bdc9e47c1b4c");
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

	#region Class: OpportunityTag_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityTag_OpportunityEventsProcess : OpportunityTag_OpportunityEventsProcess<OpportunityTag>
	{

		public OpportunityTag_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: OpportunityTagEventsProcess

	/// <exclude/>
	public class OpportunityTagEventsProcess : OpportunityTag_OpportunityEventsProcess
	{

		public OpportunityTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

