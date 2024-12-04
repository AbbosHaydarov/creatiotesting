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

	#region Class: Call_CrtLead_TerrasoftSchema

	/// <exclude/>
	public class Call_CrtLead_TerrasoftSchema : Terrasoft.Configuration.Call_CrtBaseFinserv_TerrasoftSchema
	{

		#region Constructors: Public

		public Call_CrtLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Call_CrtLead_TerrasoftSchema(Call_CrtLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Call_CrtLead_TerrasoftSchema(Call_CrtLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("fdb30b0c-2da8-49ce-80dc-2ca0628668c8");
			Name = "Call_CrtLead_Terrasoft";
			ParentSchemaUId = new Guid("2f81fa05-11ae-400d-8e07-5ef6a620d1ad");
			ExtendParent = true;
			CreatedInPackageId = new Guid("96386906-0220-46aa-a190-2514d5228612");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("02a029f7-23d2-4c19-86b8-0aa9b96fe246")) == null) {
				Columns.Add(CreateLeadColumn());
			}
		}

		protected override EntitySchemaColumn CreateCallerIdColumn() {
			EntitySchemaColumn column = base.CreateCallerIdColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("fdb30b0c-2da8-49ce-80dc-2ca0628668c8");
			column.CreatedInPackageId = new Guid("96386906-0220-46aa-a190-2514d5228612");
			return column;
		}

		protected override EntitySchemaColumn CreateCalledIdColumn() {
			EntitySchemaColumn column = base.CreateCalledIdColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("fdb30b0c-2da8-49ce-80dc-2ca0628668c8");
			column.CreatedInPackageId = new Guid("96386906-0220-46aa-a190-2514d5228612");
			return column;
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("02a029f7-23d2-4c19-86b8-0aa9b96fe246"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fdb30b0c-2da8-49ce-80dc-2ca0628668c8"),
				ModifiedInSchemaUId = new Guid("fdb30b0c-2da8-49ce-80dc-2ca0628668c8"),
				CreatedInPackageId = new Guid("96386906-0220-46aa-a190-2514d5228612")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Call_CrtLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Call_CrtLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Call_CrtLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Call_CrtLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fdb30b0c-2da8-49ce-80dc-2ca0628668c8"));
		}

		#endregion

	}

	#endregion

	#region Class: Call_CrtLead_Terrasoft

	/// <summary>
	/// Call.
	/// </summary>
	public class Call_CrtLead_Terrasoft : Terrasoft.Configuration.Call_CrtBaseFinserv_Terrasoft
	{

		#region Constructors: Public

		public Call_CrtLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Call_CrtLead_Terrasoft";
		}

		public Call_CrtLead_Terrasoft(Call_CrtLead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadId {
			get {
				return GetTypedColumnValue<Guid>("LeadId");
			}
			set {
				SetColumnValue("LeadId", value);
				_lead = null;
			}
		}

		/// <exclude/>
		public string LeadLeadName {
			get {
				return GetTypedColumnValue<string>("LeadLeadName");
			}
			set {
				SetColumnValue("LeadLeadName", value);
				if (_lead != null) {
					_lead.LeadName = value;
				}
			}
		}

		private Lead _lead;
		/// <summary>
		/// Lead.
		/// </summary>
		public Lead Lead {
			get {
				return _lead ??
					(_lead = LookupColumnEntities.GetEntity("Lead") as Lead);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Call_CrtLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Call_CrtLead_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Call_CrtLead_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Call_CrtLead_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Call_CrtLead_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Call_CrtLead_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Call_CrtLead_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Call_CrtLead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Call_CrtLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Call_CrtLeadEventsProcess

	/// <exclude/>
	public partial class Call_CrtLeadEventsProcess<TEntity> : Terrasoft.Configuration.Call_CrtBaseFinservEventsProcess<TEntity> where TEntity : Call_CrtLead_Terrasoft
	{

		public Call_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Call_CrtLeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fdb30b0c-2da8-49ce-80dc-2ca0628668c8");
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

	#region Class: Call_CrtLeadEventsProcess

	/// <exclude/>
	public class Call_CrtLeadEventsProcess : Call_CrtLeadEventsProcess<Call_CrtLead_Terrasoft>
	{

		public Call_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Call_CrtLeadEventsProcess

	public partial class Call_CrtLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

