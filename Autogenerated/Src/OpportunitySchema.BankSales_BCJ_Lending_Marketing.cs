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
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
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

	#region Class: OpportunitySchema

	/// <exclude/>
	public class OpportunitySchema : Terrasoft.Configuration.Opportunity_OpportunityBank_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunitySchema(OpportunitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunitySchema(OpportunitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("52ac523f-6193-4e37-b32e-6ad4ce5c4d80");
			Name = "Opportunity";
			ParentSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("76a3b911-520d-4e5a-aeef-480d6ce2314d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateBudgetColumn() {
			EntitySchemaColumn column = base.CreateBudgetColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("52ac523f-6193-4e37-b32e-6ad4ce5c4d80");
			return column;
		}

		protected override EntitySchemaColumn CreateAmountColumn() {
			EntitySchemaColumn column = base.CreateAmountColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("52ac523f-6193-4e37-b32e-6ad4ce5c4d80");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Opportunity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52ac523f-6193-4e37-b32e-6ad4ce5c4d80"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity : Terrasoft.Configuration.Opportunity_OpportunityBank_Terrasoft
	{

		#region Constructors: Public

		public Opportunity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity";
		}

		public Opportunity(Opportunity source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection);
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
			return new Opportunity(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess

	/// <exclude/>
	public partial class Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess<TEntity> : Terrasoft.Configuration.Opportunity_OpportunityBankEventsProcess<TEntity> where TEntity : Opportunity
	{

		public Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("52ac523f-6193-4e37-b32e-6ad4ce5c4d80");
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

	#region Class: Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess

	/// <exclude/>
	public class Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess : Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess<Opportunity>
	{

		public Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess

	public partial class Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityEventsProcess : Opportunity_BankSales_BCJ_Lending_MarketingEventsProcess
	{

		public OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

