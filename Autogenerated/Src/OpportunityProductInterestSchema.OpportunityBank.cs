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

	#region Class: OpportunityProductInterestSchema

	/// <exclude/>
	public class OpportunityProductInterestSchema : Terrasoft.Configuration.OpportunityProductInterest_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityProductInterestSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityProductInterestSchema(OpportunityProductInterestSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityProductInterestSchema(OpportunityProductInterestSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e");
			Name = "OpportunityProductInterest";
			ParentSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			ExtendParent = true;
			CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4033ea02-4be3-4440-a4d5-f6b0cd0aefe2")) == null) {
				Columns.Add(CreateRevenueColumn());
			}
			if (Columns.FindByUId(new Guid("c3fa6edb-a733-4b16-ad82-c61381ae6289")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("d3745728-60b9-4431-a549-40be4f654d0e")) == null) {
				Columns.Add(CreateCurrencyRevenueColumn());
			}
		}

		protected override EntitySchemaColumn CreateQuantityColumn() {
			EntitySchemaColumn column = base.CreateQuantityColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e");
			column.CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2");
			return column;
		}

		protected override EntitySchemaColumn CreatePriceColumn() {
			EntitySchemaColumn column = base.CreatePriceColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e");
			column.CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2");
			return column;
		}

		protected virtual EntitySchemaColumn CreateRevenueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4033ea02-4be3-4440-a4d5-f6b0cd0aefe2"),
				Name = @"Revenue",
				CreatedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e"),
				ModifiedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e"),
				CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c3fa6edb-a733-4b16-ad82-c61381ae6289"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e"),
				ModifiedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e"),
				CreatedInPackageId = new Guid("137dc902-687e-48ed-8377-0db7c1578be2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRevenueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d3745728-60b9-4431-a549-40be4f654d0e"),
				Name = @"CurrencyRevenue",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e"),
				ModifiedInSchemaUId = new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e"),
				CreatedInPackageId = new Guid("df742097-edc8-4c94-8684-5207adfedf83"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityProductInterest(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityProductInterest_OpportunityBankEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityProductInterestSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityProductInterestSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest

	/// <summary>
	/// Opportunity product.
	/// </summary>
	public class OpportunityProductInterest : Terrasoft.Configuration.OpportunityProductInterest_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityProductInterest(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityProductInterest";
		}

		public OpportunityProductInterest(OpportunityProductInterest source)
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

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <exclude/>
		public Guid CurrencyRevenueId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyRevenueId");
			}
			set {
				SetColumnValue("CurrencyRevenueId", value);
				_currencyRevenue = null;
			}
		}

		/// <exclude/>
		public string CurrencyRevenueName {
			get {
				return GetTypedColumnValue<string>("CurrencyRevenueName");
			}
			set {
				SetColumnValue("CurrencyRevenueName", value);
				if (_currencyRevenue != null) {
					_currencyRevenue.Name = value;
				}
			}
		}

		private Currency _currencyRevenue;
		/// <summary>
		/// Revenue currency.
		/// </summary>
		public Currency CurrencyRevenue {
			get {
				return _currencyRevenue ??
					(_currencyRevenue = LookupColumnEntities.GetEntity("CurrencyRevenue") as Currency);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityProductInterest_OpportunityBankEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("OpportunityProductInterestValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityProductInterest(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_OpportunityBankEventsProcess

	/// <exclude/>
	public partial class OpportunityProductInterest_OpportunityBankEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityProductInterest_OpportunityEventsProcess<TEntity> where TEntity : OpportunityProductInterest
	{

		public OpportunityProductInterest_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityProductInterest_OpportunityBankEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("161cb125-2f45-4ac0-9335-8ac6be0cbb8e");
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

	#region Class: OpportunityProductInterest_OpportunityBankEventsProcess

	/// <exclude/>
	public class OpportunityProductInterest_OpportunityBankEventsProcess : OpportunityProductInterest_OpportunityBankEventsProcess<OpportunityProductInterest>
	{

		public OpportunityProductInterest_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityProductInterest_OpportunityBankEventsProcess

	public partial class OpportunityProductInterest_OpportunityBankEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CalckOpportunityAmount(Guid opportunityId) {
			var oppotrunityAmountSelect = new Select(UserConnection)
				.Column("Amount")
				.From("OpportunityProductInterest")
				.Where("OpportunityId").IsEqual(Column.Parameter(opportunityId)) as Select;
			double opportunityAmount = 0.0;
			double opportunityRevenue = 0.0;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = oppotrunityAmountSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						if(!dr.IsDBNull(0)){
							opportunityAmount += (double)UserConnection.DBTypeConverter.DBValueToDecimal(dr[0]);
						}
					}
				}
			}
			var update = new Update(UserConnection, "Opportunity")
					.Set("Amount", Column.Parameter(opportunityAmount))
					.Where("Id").IsEqual(Column.Parameter(opportunityId));
				update.Execute();
		}

		#endregion

	}

	#endregion


	#region Class: OpportunityProductInterestEventsProcess

	/// <exclude/>
	public class OpportunityProductInterestEventsProcess : OpportunityProductInterest_OpportunityBankEventsProcess
	{

		public OpportunityProductInterestEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

