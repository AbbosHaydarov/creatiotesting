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

	#region Class: SpecificationInOpportunitySchema

	/// <exclude/>
	public class SpecificationInOpportunitySchema : Terrasoft.Configuration.SpecificationInObjectSchema
	{

		#region Constructors: Public

		public SpecificationInOpportunitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInOpportunitySchema(SpecificationInOpportunitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInOpportunitySchema(SpecificationInOpportunitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7abdac5b-742d-4453-a07c-11e73658156e");
			RealUId = new Guid("7abdac5b-742d-4453-a07c-11e73658156e");
			Name = "SpecificationInOpportunity";
			ParentSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e3c944af-7653-41b6-9485-473f7d58c8e2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
			TrackChangesSchemaName = @"SysSpecificationInOppLog";
			RightSchemaName = @"SysSpecificationInOppRight";
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c51799cf-4702-402f-84e7-fb6d026d5bcd")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c51799cf-4702-402f-84e7-fb6d026d5bcd"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("7abdac5b-742d-4453-a07c-11e73658156e"),
				ModifiedInSchemaUId = new Guid("7abdac5b-742d-4453-a07c-11e73658156e"),
				CreatedInPackageId = new Guid("e3c944af-7653-41b6-9485-473f7d58c8e2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationInOpportunity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInOpportunity_OpportunityBankEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInOpportunitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInOpportunitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7abdac5b-742d-4453-a07c-11e73658156e"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInOpportunity

	/// <summary>
	/// Opportunity parameter.
	/// </summary>
	public class SpecificationInOpportunity : Terrasoft.Configuration.SpecificationInObject
	{

		#region Constructors: Public

		public SpecificationInOpportunity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInOpportunity";
		}

		public SpecificationInOpportunity(SpecificationInOpportunity source)
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
			var process = new SpecificationInOpportunity_OpportunityBankEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInOpportunityDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecificationInOpportunityValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInOpportunity(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInOpportunity_OpportunityBankEventsProcess

	/// <exclude/>
	public partial class SpecificationInOpportunity_OpportunityBankEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInObject_SpecificationEventsProcess<TEntity> where TEntity : SpecificationInOpportunity
	{

		public SpecificationInOpportunity_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInOpportunity_OpportunityBankEventsProcess";
			SchemaUId = new Guid("7abdac5b-742d-4453-a07c-11e73658156e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7abdac5b-742d-4453-a07c-11e73658156e");
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

	#region Class: SpecificationInOpportunity_OpportunityBankEventsProcess

	/// <exclude/>
	public class SpecificationInOpportunity_OpportunityBankEventsProcess : SpecificationInOpportunity_OpportunityBankEventsProcess<SpecificationInOpportunity>
	{

		public SpecificationInOpportunity_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInOpportunity_OpportunityBankEventsProcess

	public partial class SpecificationInOpportunity_OpportunityBankEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationInOpportunityEventsProcess

	/// <exclude/>
	public class SpecificationInOpportunityEventsProcess : SpecificationInOpportunity_OpportunityBankEventsProcess
	{

		public SpecificationInOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

