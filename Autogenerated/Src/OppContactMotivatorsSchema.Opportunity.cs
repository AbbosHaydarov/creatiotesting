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

	#region Class: OppContactMotivatorsSchema

	/// <exclude/>
	public class OppContactMotivatorsSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OppContactMotivatorsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OppContactMotivatorsSchema(OppContactMotivatorsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OppContactMotivatorsSchema(OppContactMotivatorsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			RealUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			Name = "OppContactMotivators";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5c9ccd90-06fc-4547-9eb4-c63723b2d23e")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5c9ccd90-06fc-4547-9eb4-c63723b2d23e"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("d0771203-0cb0-4b03-9cea-20ae8f431e08"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6"),
				ModifiedInSchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OppContactMotivators(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OppContactMotivators_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OppContactMotivatorsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OppContactMotivatorsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6"));
		}

		#endregion

	}

	#endregion

	#region Class: OppContactMotivators

	/// <summary>
	/// Decision-making factors.
	/// </summary>
	public class OppContactMotivators : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OppContactMotivators(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OppContactMotivators";
		}

		public OppContactMotivators(OppContactMotivators source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private OppContactMotivatType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public OppContactMotivatType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as OppContactMotivatType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OppContactMotivators_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OppContactMotivatorsDeleted", e);
			Inserting += (s, e) => ThrowEvent("OppContactMotivatorsInserting", e);
			Validating += (s, e) => ThrowEvent("OppContactMotivatorsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OppContactMotivators(this);
		}

		#endregion

	}

	#endregion

	#region Class: OppContactMotivators_OpportunityEventsProcess

	/// <exclude/>
	public partial class OppContactMotivators_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : OppContactMotivators
	{

		public OppContactMotivators_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OppContactMotivators_OpportunityEventsProcess";
			SchemaUId = new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("16ab0b58-3f64-418d-849c-bf9ccd3b3bb6");
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

	#region Class: OppContactMotivators_OpportunityEventsProcess

	/// <exclude/>
	public class OppContactMotivators_OpportunityEventsProcess : OppContactMotivators_OpportunityEventsProcess<OppContactMotivators>
	{

		public OppContactMotivators_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OppContactMotivators_OpportunityEventsProcess

	public partial class OppContactMotivators_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OppContactMotivatorsEventsProcess

	/// <exclude/>
	public class OppContactMotivatorsEventsProcess : OppContactMotivators_OpportunityEventsProcess
	{

		public OppContactMotivatorsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

