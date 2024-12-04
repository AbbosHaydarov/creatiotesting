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

	#region Class: Opportunity_OpportunityBank_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_OpportunityBank_TerrasoftSchema : Terrasoft.Configuration.Opportunity_OpportunityManagement_TerrasoftSchema
	{

		#region Constructors: Public

		public Opportunity_OpportunityBank_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_OpportunityBank_TerrasoftSchema(Opportunity_OpportunityBank_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_OpportunityBank_TerrasoftSchema(Opportunity_OpportunityBank_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_OpportunityTitleIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("538d5288-c406-4b69-8f00-7b42c02cbdf3");
			index.Name = "IDX_OpportunityTitle";
			index.CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			EntitySchemaIndexColumn titleIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("7a45b5d6-7ce5-4417-8995-a0f6d21a272b"),
				ColumnUId = new Guid("790563cf-fd14-4d5d-a5fd-b6eddb10d6d3"),
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(titleIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("59294388-127a-4489-a94d-e570ffdb47eb");
			Name = "Opportunity_OpportunityBank_Terrasoft";
			ParentSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("41f44fab-313e-43c2-b3bd-fa52484a67ad")) == null) {
				Columns.Add(CreateRevenueColumn());
			}
		}

		protected override EntitySchemaColumn CreateBudgetColumn() {
			EntitySchemaColumn column = base.CreateBudgetColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("59294388-127a-4489-a94d-e570ffdb47eb");
			column.CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2");
			return column;
		}

		protected override EntitySchemaColumn CreateAmountColumn() {
			EntitySchemaColumn column = base.CreateAmountColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("59294388-127a-4489-a94d-e570ffdb47eb");
			column.CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2");
			return column;
		}

		protected override EntitySchemaColumn CreateCompletenessColumn() {
			EntitySchemaColumn column = base.CreateCompletenessColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"0"
			};
			column.ModifiedInSchemaUId = new Guid("59294388-127a-4489-a94d-e570ffdb47eb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateRevenueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("41f44fab-313e-43c2-b3bd-fa52484a67ad"),
				Name = @"Revenue",
				CreatedInSchemaUId = new Guid("59294388-127a-4489-a94d-e570ffdb47eb"),
				ModifiedInSchemaUId = new Guid("59294388-127a-4489-a94d-e570ffdb47eb"),
				CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_OpportunityTitleIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Opportunity_OpportunityBank_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_OpportunityBankEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_OpportunityBank_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_OpportunityBank_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59294388-127a-4489-a94d-e570ffdb47eb"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityBank_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_OpportunityBank_Terrasoft : Terrasoft.Configuration.Opportunity_OpportunityManagement_Terrasoft
	{

		#region Constructors: Public

		public Opportunity_OpportunityBank_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_OpportunityBank_Terrasoft";
		}

		public Opportunity_OpportunityBank_Terrasoft(Opportunity_OpportunityBank_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Revenue.
		/// </summary>
		public Decimal Revenue {
			get {
				return GetTypedColumnValue<Decimal>("Revenue");
			}
			set {
				SetColumnValue("Revenue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_OpportunityBankEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("Opportunity_OpportunityBank_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_OpportunityBank_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityBankEventsProcess

	/// <exclude/>
	public partial class Opportunity_OpportunityBankEventsProcess<TEntity> : Terrasoft.Configuration.Opportunity_OpportunityManagementEventsProcess<TEntity> where TEntity : Opportunity_OpportunityBank_Terrasoft
	{

		public Opportunity_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_OpportunityBankEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("59294388-127a-4489-a94d-e570ffdb47eb");
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

	#region Class: Opportunity_OpportunityBankEventsProcess

	/// <exclude/>
	public class Opportunity_OpportunityBankEventsProcess : Opportunity_OpportunityBankEventsProcess<Opportunity_OpportunityBank_Terrasoft>
	{

		public Opportunity_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Opportunity_OpportunityBankEventsProcess

	public partial class Opportunity_OpportunityBankEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

