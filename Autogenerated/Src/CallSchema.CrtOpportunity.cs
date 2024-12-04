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

	#region Class: CallSchema

	/// <exclude/>
	public class CallSchema : Terrasoft.Configuration.Call_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public CallSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CallSchema(CallSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CallSchema(CallSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("74b541e8-7d87-4296-9d62-a65ac5907a92");
			Name = "Call";
			ParentSchemaUId = new Guid("2f81fa05-11ae-400d-8e07-5ef6a620d1ad");
			ExtendParent = true;
			CreatedInPackageId = new Guid("bd93380a-2ac0-4fec-8435-f14f5908016f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0efce1e2-796f-483f-84fc-172aab6ad68a")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected override EntitySchemaColumn CreateCallerIdColumn() {
			EntitySchemaColumn column = base.CreateCallerIdColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("74b541e8-7d87-4296-9d62-a65ac5907a92");
			return column;
		}

		protected override EntitySchemaColumn CreateCalledIdColumn() {
			EntitySchemaColumn column = base.CreateCalledIdColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("74b541e8-7d87-4296-9d62-a65ac5907a92");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0efce1e2-796f-483f-84fc-172aab6ad68a"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("74b541e8-7d87-4296-9d62-a65ac5907a92"),
				ModifiedInSchemaUId = new Guid("74b541e8-7d87-4296-9d62-a65ac5907a92"),
				CreatedInPackageId = new Guid("bd93380a-2ac0-4fec-8435-f14f5908016f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Call(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Call_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CallSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CallSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74b541e8-7d87-4296-9d62-a65ac5907a92"));
		}

		#endregion

	}

	#endregion

	#region Class: Call

	/// <summary>
	/// Call.
	/// </summary>
	public class Call : Terrasoft.Configuration.Call_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public Call(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Call";
		}

		public Call(Call source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Call_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CallDeleted", e);
			Deleting += (s, e) => ThrowEvent("CallDeleting", e);
			Inserted += (s, e) => ThrowEvent("CallInserted", e);
			Inserting += (s, e) => ThrowEvent("CallInserting", e);
			Saved += (s, e) => ThrowEvent("CallSaved", e);
			Saving += (s, e) => ThrowEvent("CallSaving", e);
			Validating += (s, e) => ThrowEvent("CallValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Call(this);
		}

		#endregion

	}

	#endregion

	#region Class: Call_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class Call_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.Call_CrtLeadEventsProcess<TEntity> where TEntity : Call
	{

		public Call_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Call_CrtOpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("74b541e8-7d87-4296-9d62-a65ac5907a92");
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

	#region Class: Call_CrtOpportunityEventsProcess

	/// <exclude/>
	public class Call_CrtOpportunityEventsProcess : Call_CrtOpportunityEventsProcess<Call>
	{

		public Call_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Call_CrtOpportunityEventsProcess

	public partial class Call_CrtOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CallEventsProcess

	/// <exclude/>
	public class CallEventsProcess : Call_CrtOpportunityEventsProcess
	{

		public CallEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

