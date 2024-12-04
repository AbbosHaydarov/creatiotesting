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

	#region Class: FinAppDecisionSchema

	/// <exclude/>
	public class FinAppDecisionSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public FinAppDecisionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinAppDecisionSchema(FinAppDecisionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinAppDecisionSchema(FinAppDecisionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e");
			RealUId = new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e");
			Name = "FinAppDecision";
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
			if (Columns.FindByUId(new Guid("e44b16fb-93aa-4b69-8286-62497a2cd927")) == null) {
				Columns.Add(CreateFinalStateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFinalStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e44b16fb-93aa-4b69-8286-62497a2cd927"),
				Name = @"FinalState",
				CreatedInSchemaUId = new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e"),
				ModifiedInSchemaUId = new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinAppDecision(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinAppDecision_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinAppDecisionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinAppDecisionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e"));
		}

		#endregion

	}

	#endregion

	#region Class: FinAppDecision

	/// <summary>
	/// Application decision.
	/// </summary>
	public class FinAppDecision : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public FinAppDecision(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinAppDecision";
		}

		public FinAppDecision(FinAppDecision source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Status is final.
		/// </summary>
		public bool FinalState {
			get {
				return GetTypedColumnValue<bool>("FinalState");
			}
			set {
				SetColumnValue("FinalState", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinAppDecision_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinAppDecisionDeleted", e);
			Validating += (s, e) => ThrowEvent("FinAppDecisionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinAppDecision(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinAppDecision_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinAppDecision_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinAppDecision
	{

		public FinAppDecision_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinAppDecision_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e");
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

	#region Class: FinAppDecision_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinAppDecision_CrtFinservApplicationEventsProcess : FinAppDecision_CrtFinservApplicationEventsProcess<FinAppDecision>
	{

		public FinAppDecision_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinAppDecision_CrtFinservApplicationEventsProcess

	public partial class FinAppDecision_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinAppDecisionEventsProcess

	/// <exclude/>
	public class FinAppDecisionEventsProcess : FinAppDecision_CrtFinservApplicationEventsProcess
	{

		public FinAppDecisionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

