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

	#region Class: Opportunity_CrtFinservOpportunity_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_CrtFinservOpportunity_TerrasoftSchema : Terrasoft.Configuration.Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema
	{

		#region Constructors: Public

		public Opportunity_CrtFinservOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_CrtFinservOpportunity_TerrasoftSchema(Opportunity_CrtFinservOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_CrtFinservOpportunity_TerrasoftSchema(Opportunity_CrtFinservOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("050e193e-4550-4c27-ac13-7487dc193ca2");
			Name = "Opportunity_CrtFinservOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1edcbf29-58d5-4480-82d1-dcc1c989035d");
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
			return new Opportunity_CrtFinservOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_CrtFinservOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_CrtFinservOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_CrtFinservOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("050e193e-4550-4c27-ac13-7487dc193ca2"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtFinservOpportunity_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_CrtFinservOpportunity_Terrasoft : Terrasoft.Configuration.Opportunity_CrtLeadOppMgmtApp_Terrasoft
	{

		#region Constructors: Public

		public Opportunity_CrtFinservOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_CrtFinservOpportunity_Terrasoft";
		}

		public Opportunity_CrtFinservOpportunity_Terrasoft(Opportunity_CrtFinservOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_CrtFinservOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_CrtFinservOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtFinservOpportunityEventsProcess

	/// <exclude/>
	public partial class Opportunity_CrtFinservOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.Opportunity_CrtLeadOppMgmtAppEventsProcess<TEntity> where TEntity : Opportunity_CrtFinservOpportunity_Terrasoft
	{

		public Opportunity_CrtFinservOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_CrtFinservOpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("050e193e-4550-4c27-ac13-7487dc193ca2");
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

	#region Class: Opportunity_CrtFinservOpportunityEventsProcess

	/// <exclude/>
	public class Opportunity_CrtFinservOpportunityEventsProcess : Opportunity_CrtFinservOpportunityEventsProcess<Opportunity_CrtFinservOpportunity_Terrasoft>
	{

		public Opportunity_CrtFinservOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Opportunity_CrtFinservOpportunityEventsProcess

	public partial class Opportunity_CrtFinservOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

