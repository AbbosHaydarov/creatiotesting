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

	#region Class: Lead_LeadFinance_TerrasoftSchema

	/// <exclude/>
	public class Lead_LeadFinance_TerrasoftSchema : Terrasoft.Configuration.Lead_CoreLeadOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_LeadFinance_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_LeadFinance_TerrasoftSchema(Lead_LeadFinance_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_LeadFinance_TerrasoftSchema(Lead_LeadFinance_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			Name = "Lead_LeadFinance_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("18b6ef90-fe59-481c-a633-47a64fb76d2f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("80a487af-920e-456e-8c99-2c7169e81e1e")) == null) {
				Columns.Add(CreateSurnameColumn());
			}
			if (Columns.FindByUId(new Guid("fa32ffce-a15e-4f8e-b094-02665656ded2")) == null) {
				Columns.Add(CreateGivenNameColumn());
			}
			if (Columns.FindByUId(new Guid("19eea159-62cb-40d3-acae-ba71c50426f0")) == null) {
				Columns.Add(CreateMiddleNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateTitleColumn() {
			EntitySchemaColumn column = base.CreateTitleColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressTypeColumn() {
			EntitySchemaColumn column = base.CreateAddressTypeColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateCountryColumn() {
			EntitySchemaColumn column = base.CreateCountryColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateRegionColumn() {
			EntitySchemaColumn column = base.CreateRegionColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateCityColumn() {
			EntitySchemaColumn column = base.CreateCityColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateZipColumn() {
			EntitySchemaColumn column = base.CreateZipColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountOwnershipColumn() {
			EntitySchemaColumn column = base.CreateAccountOwnershipColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateGenderColumn() {
			EntitySchemaColumn column = base.CreateGenderColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateDearColumn() {
			EntitySchemaColumn column = base.CreateDearColumn();
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateBudgetColumn() {
			EntitySchemaColumn column = base.CreateBudgetColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateMeetingDateColumn() {
			EntitySchemaColumn column = base.CreateMeetingDateColumn();
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected override EntitySchemaColumn CreateDecisionDateColumn() {
			EntitySchemaColumn column = base.CreateDecisionDateColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("Date");
			column.ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSurnameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("80a487af-920e-456e-8c99-2c7169e81e1e"),
				Name = @"Surname",
				CreatedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b"),
				ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b"),
				CreatedInPackageId = new Guid("18b6ef90-fe59-481c-a633-47a64fb76d2f")
			};
		}

		protected virtual EntitySchemaColumn CreateGivenNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("fa32ffce-a15e-4f8e-b094-02665656ded2"),
				Name = @"GivenName",
				CreatedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b"),
				ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b"),
				CreatedInPackageId = new Guid("18b6ef90-fe59-481c-a633-47a64fb76d2f")
			};
		}

		protected virtual EntitySchemaColumn CreateMiddleNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("19eea159-62cb-40d3-acae-ba71c50426f0"),
				Name = @"MiddleName",
				CreatedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b"),
				ModifiedInSchemaUId = new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b"),
				CreatedInPackageId = new Guid("18b6ef90-fe59-481c-a633-47a64fb76d2f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_LeadFinance_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_LeadFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_LeadFinance_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_LeadFinance_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_LeadFinance_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_LeadFinance_Terrasoft : Terrasoft.Configuration.Lead_CoreLeadOpportunity_Terrasoft
	{

		#region Constructors: Public

		public Lead_LeadFinance_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_LeadFinance_Terrasoft";
		}

		public Lead_LeadFinance_Terrasoft(Lead_LeadFinance_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Last name.
		/// </summary>
		public string Surname {
			get {
				return GetTypedColumnValue<string>("Surname");
			}
			set {
				SetColumnValue("Surname", value);
			}
		}

		/// <summary>
		/// First name.
		/// </summary>
		public string GivenName {
			get {
				return GetTypedColumnValue<string>("GivenName");
			}
			set {
				SetColumnValue("GivenName", value);
			}
		}

		/// <summary>
		/// Middle name.
		/// </summary>
		public string MiddleName {
			get {
				return GetTypedColumnValue<string>("MiddleName");
			}
			set {
				SetColumnValue("MiddleName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_LeadFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_LeadFinance_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_LeadFinance_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_LeadFinanceEventsProcess

	/// <exclude/>
	public partial class Lead_LeadFinanceEventsProcess<TEntity> : Terrasoft.Configuration.Lead_CoreLeadOpportunityEventsProcess<TEntity> where TEntity : Lead_LeadFinance_Terrasoft
	{

		public Lead_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_LeadFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ecf23df6-4e66-431b-b166-e11a14cb186b");
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

	#region Class: Lead_LeadFinanceEventsProcess

	/// <exclude/>
	public class Lead_LeadFinanceEventsProcess : Lead_LeadFinanceEventsProcess<Lead_LeadFinance_Terrasoft>
	{

		public Lead_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_LeadFinanceEventsProcess

	public partial class Lead_LeadFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateLeadFio() {
			var leadEntity = new Entity(Entity);
			if (leadEntity.FetchFromDB(Entity.PrimaryColumnValue)) {
				var Contact = leadEntity.GetTypedColumnValue<string>("Contact");
				if(!string.IsNullOrEmpty(Contact)) return;
				var Surname = leadEntity.GetTypedColumnValue<string>("Surname");
				var GivenName = leadEntity.GetTypedColumnValue<string>("GivenName");
				var MiddleName = leadEntity.GetTypedColumnValue<string>("MiddleName");
				
				string fullName = string.Empty;
				
				if(!string.IsNullOrEmpty(Surname)){
					fullName+=Surname;
				}
				if(!string.IsNullOrEmpty(GivenName)){
					fullName+=" "+GivenName;
				}
				if(!string.IsNullOrEmpty(MiddleName)){
					fullName+=" "+MiddleName;
				}
				Update updateLeadQuery = new Update(UserConnection, Entity.Schema.Name);
				updateLeadQuery.Set("Contact", Column.Parameter(fullName));
				updateLeadQuery.Where("Id").IsEqual(Column.Parameter(Entity.PrimaryColumnValue));
				updateLeadQuery.Execute();
			}
		}

		public override void LeadInserting() {
			base.LeadInserting();
			string bpmHrefColumnName = "BpmHref";
			string bpmRefColumnName = "BpmRef";
			string bpmHref = Entity.IsColumnValueLoaded(bpmHrefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmHrefColumnName) : String.Empty;
			string bpmRef = Entity.IsColumnValueLoaded(bpmRefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmRefColumnName) : String.Empty;
			Terrasoft.Configuration.LeadSourceHelper lsh = 
				new Terrasoft.Configuration.LeadSourceHelper(UserConnection, bpmHref, bpmRef);
			lsh.ComputeMediumAndSource();
			Guid resultLeadMediumId = lsh.ResultLeadMediumId;
			Guid resultLeadSourceId = lsh.ResultLeadSourceId;
			if (resultLeadMediumId != Guid.Empty) {
				Entity.SetColumnValue("LeadMediumId", resultLeadMediumId);
			}
			if (resultLeadSourceId != Guid.Empty) {
				Entity.SetColumnValue("LeadSourceId", resultLeadSourceId);
			}
		}

		#endregion

	}

	#endregion

}

