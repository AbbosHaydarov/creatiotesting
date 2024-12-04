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

	#region Class: FinIndicatorSchema

	/// <exclude/>
	public class FinIndicatorSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FinIndicatorSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinIndicatorSchema(FinIndicatorSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinIndicatorSchema(FinIndicatorSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			RealUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			Name = "FinIndicator";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("bfacfb60-0799-4925-8216-dee0a0adae05")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("227ec071-2e0c-4089-9462-115163b5c5cf")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("2842d36c-3d2f-4ce0-a619-e1f71f1989d1")) == null) {
				Columns.Add(CreateValueColumn());
			}
			if (Columns.FindByUId(new Guid("fae90489-a47d-4cea-9637-696188daa6b4")) == null) {
				Columns.Add(CreateValueTypeColumn());
			}
			if (Columns.FindByUId(new Guid("2d196d63-50d4-40cc-926f-1a2c33bd8663")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("a19c45cc-bd2b-4c34-b9a1-f0f65eb084ec")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("e37daa6d-438c-4e20-b387-10b2b37ad132")) == null) {
				Columns.Add(CreatePeriodTypeColumn());
			}
			if (Columns.FindByUId(new Guid("af3ff6b3-6014-4e46-a192-103f338e43b2")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("6cd08c51-ca29-409c-b7b7-6f2197be6095")) == null) {
				Columns.Add(CreatePeriodColumn());
			}
			if (Columns.FindByUId(new Guid("10e59dbe-d0c6-4dee-8963-fc8b5f8cb8bd")) == null) {
				Columns.Add(CreateAccountFolderColumn());
			}
			if (Columns.FindByUId(new Guid("f8f41ef6-7c79-417a-9499-f40952e6357f")) == null) {
				Columns.Add(CreateBankAccountColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("65f590c4-9846-417e-8e5e-266e7156916b"),
				Name = @"Name",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bfacfb60-0799-4925-8216-dee0a0adae05"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("227ec071-2e0c-4089-9462-115163b5c5cf"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("2842d36c-3d2f-4ce0-a619-e1f71f1989d1"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateValueTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fae90489-a47d-4cea-9637-696188daa6b4"),
				Name = @"ValueType",
				ReferenceSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("2d196d63-50d4-40cc-926f-1a2c33bd8663"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("a19c45cc-bd2b-4c34-b9a1-f0f65eb084ec"),
				Name = @"EndDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreatePeriodTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e37daa6d-438c-4e20-b387-10b2b37ad132"),
				Name = @"PeriodType",
				ReferenceSchemaUId = new Guid("3608a0e4-0235-4936-9c0e-99620e73940c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("af3ff6b3-6014-4e46-a192-103f338e43b2"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreatePeriodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6cd08c51-ca29-409c-b7b7-6f2197be6095"),
				Name = @"Period",
				ReferenceSchemaUId = new Guid("5b473ba3-604c-41d6-b25d-032754dad4d2"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountFolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("10e59dbe-d0c6-4dee-8963-fc8b5f8cb8bd"),
				Name = @"AccountFolder",
				ReferenceSchemaUId = new Guid("6bd10faf-89e9-485e-8ee8-f240ba416b38"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected virtual EntitySchemaColumn CreateBankAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f8f41ef6-7c79-417a-9499-f40952e6357f"),
				Name = @"BankAccount",
				ReferenceSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				ModifiedInSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinIndicator(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinIndicator_FinancialIndicatorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinIndicatorSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinIndicatorSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"));
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicator

	/// <summary>
	/// Financial indicators.
	/// </summary>
	public class FinIndicator : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public FinIndicator(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinIndicator";
		}

		public FinIndicator(FinIndicator source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

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

		private FinIndicatorType _type;
		/// <summary>
		/// Indicator type.
		/// </summary>
		public FinIndicatorType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as FinIndicatorType);
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

		/// <summary>
		/// Value.
		/// </summary>
		public Decimal Value {
			get {
				return GetTypedColumnValue<Decimal>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		/// <exclude/>
		public Guid ValueTypeId {
			get {
				return GetTypedColumnValue<Guid>("ValueTypeId");
			}
			set {
				SetColumnValue("ValueTypeId", value);
				_valueType = null;
			}
		}

		/// <exclude/>
		public string ValueTypeName {
			get {
				return GetTypedColumnValue<string>("ValueTypeName");
			}
			set {
				SetColumnValue("ValueTypeName", value);
				if (_valueType != null) {
					_valueType.Name = value;
				}
			}
		}

		private FinIndicatorValueType _valueType;
		/// <summary>
		/// Value type.
		/// </summary>
		public FinIndicatorValueType ValueType {
			get {
				return _valueType ??
					(_valueType = LookupColumnEntities.GetEntity("ValueType") as FinIndicatorValueType);
			}
		}

		/// <summary>
		/// Start date.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <exclude/>
		public Guid PeriodTypeId {
			get {
				return GetTypedColumnValue<Guid>("PeriodTypeId");
			}
			set {
				SetColumnValue("PeriodTypeId", value);
				_periodType = null;
			}
		}

		/// <exclude/>
		public string PeriodTypeName {
			get {
				return GetTypedColumnValue<string>("PeriodTypeName");
			}
			set {
				SetColumnValue("PeriodTypeName", value);
				if (_periodType != null) {
					_periodType.Name = value;
				}
			}
		}

		private PeriodType _periodType;
		/// <summary>
		/// Period type.
		/// </summary>
		public PeriodType PeriodType {
			get {
				return _periodType ??
					(_periodType = LookupColumnEntities.GetEntity("PeriodType") as PeriodType);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Legal entity.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <exclude/>
		public Guid PeriodId {
			get {
				return GetTypedColumnValue<Guid>("PeriodId");
			}
			set {
				SetColumnValue("PeriodId", value);
				_period = null;
			}
		}

		/// <exclude/>
		public string PeriodName {
			get {
				return GetTypedColumnValue<string>("PeriodName");
			}
			set {
				SetColumnValue("PeriodName", value);
				if (_period != null) {
					_period.Name = value;
				}
			}
		}

		private Period _period;
		/// <summary>
		/// Period.
		/// </summary>
		public Period Period {
			get {
				return _period ??
					(_period = LookupColumnEntities.GetEntity("Period") as Period);
			}
		}

		/// <exclude/>
		public Guid AccountFolderId {
			get {
				return GetTypedColumnValue<Guid>("AccountFolderId");
			}
			set {
				SetColumnValue("AccountFolderId", value);
				_accountFolder = null;
			}
		}

		/// <exclude/>
		public string AccountFolderName {
			get {
				return GetTypedColumnValue<string>("AccountFolderName");
			}
			set {
				SetColumnValue("AccountFolderName", value);
				if (_accountFolder != null) {
					_accountFolder.Name = value;
				}
			}
		}

		private AccountFolder _accountFolder;
		/// <summary>
		/// Legal entities segment.
		/// </summary>
		public AccountFolder AccountFolder {
			get {
				return _accountFolder ??
					(_accountFolder = LookupColumnEntities.GetEntity("AccountFolder") as AccountFolder);
			}
		}

		/// <exclude/>
		public Guid BankAccountId {
			get {
				return GetTypedColumnValue<Guid>("BankAccountId");
			}
			set {
				SetColumnValue("BankAccountId", value);
				_bankAccount = null;
			}
		}

		/// <exclude/>
		public string BankAccountBankAccountNumber {
			get {
				return GetTypedColumnValue<string>("BankAccountBankAccountNumber");
			}
			set {
				SetColumnValue("BankAccountBankAccountNumber", value);
				if (_bankAccount != null) {
					_bankAccount.BankAccountNumber = value;
				}
			}
		}

		private BankAccount _bankAccount;
		/// <summary>
		/// Financial account.
		/// </summary>
		public BankAccount BankAccount {
			get {
				return _bankAccount ??
					(_bankAccount = LookupColumnEntities.GetEntity("BankAccount") as BankAccount);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinIndicator_FinancialIndicatorEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinIndicatorDeleted", e);
			Saving += (s, e) => ThrowEvent("FinIndicatorSaving", e);
			Validating += (s, e) => ThrowEvent("FinIndicatorValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinIndicator(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicator_FinancialIndicatorEventsProcess

	/// <exclude/>
	public partial class FinIndicator_FinancialIndicatorEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : FinIndicator
	{

		public FinIndicator_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinIndicator_FinancialIndicatorEventsProcess";
			SchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad;
		public ProcessFlowElement EventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad {
			get {
				return _eventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad ?? (_eventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad",
					SchemaElementUId = new Guid("032c56f6-cf86-42ff-b8fd-1c6f640a97ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_81ff04dcdb824da183ab4d15a2e93976;
		public ProcessScriptTask ScriptTask3_81ff04dcdb824da183ab4d15a2e93976 {
			get {
				return _scriptTask3_81ff04dcdb824da183ab4d15a2e93976 ?? (_scriptTask3_81ff04dcdb824da183ab4d15a2e93976 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_81ff04dcdb824da183ab4d15a2e93976",
					SchemaElementUId = new Guid("81ff04dc-db82-4da1-83ab-4d15a2e93976"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_81ff04dcdb824da183ab4d15a2e93976Execute,
				});
			}
		}

		private ProcessFlowElement _startMessage4_afd37e6497b34d46a647e3f57e2de75f;
		public ProcessFlowElement StartMessage4_afd37e6497b34d46a647e3f57e2de75f {
			get {
				return _startMessage4_afd37e6497b34d46a647e3f57e2de75f ?? (_startMessage4_afd37e6497b34d46a647e3f57e2de75f = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_afd37e6497b34d46a647e3f57e2de75f",
					SchemaElementUId = new Guid("afd37e64-97b3-4d46-a647-e3f57e2de75f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad };
			FlowElements[ScriptTask3_81ff04dcdb824da183ab4d15a2e93976.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_81ff04dcdb824da183ab4d15a2e93976 };
			FlowElements[StartMessage4_afd37e6497b34d46a647e3f57e2de75f.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_afd37e6497b34d46a647e3f57e2de75f };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad":
						break;
					case "ScriptTask3_81ff04dcdb824da183ab4d15a2e93976":
						break;
					case "StartMessage4_afd37e6497b34d46a647e3f57e2de75f":
						e.Context.QueueTasks.Enqueue("ScriptTask3_81ff04dcdb824da183ab4d15a2e93976");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage4_afd37e6497b34d46a647e3f57e2de75f");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_032c56f6cf8642ffb8fd1c6f640a97ad":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask3_81ff04dcdb824da183ab4d15a2e93976":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_81ff04dcdb824da183ab4d15a2e93976";
					result = ScriptTask3_81ff04dcdb824da183ab4d15a2e93976.Execute(context, ScriptTask3_81ff04dcdb824da183ab4d15a2e93976Execute);
					break;
				case "StartMessage4_afd37e6497b34d46a647e3f57e2de75f":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_afd37e6497b34d46a647e3f57e2de75f";
					result = StartMessage4_afd37e6497b34d46a647e3f57e2de75f.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_81ff04dcdb824da183ab4d15a2e93976Execute(ProcessExecutingContext context) {
			UpdatePrimaryDisplayColumnValue();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "FinIndicatorSaving":
							if (ActivatedEventElements.Contains("StartMessage4_afd37e6497b34d46a647e3f57e2de75f")) {
							context.QueueTasks.Enqueue("StartMessage4_afd37e6497b34d46a647e3f57e2de75f");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicator_FinancialIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicator_FinancialIndicatorEventsProcess : FinIndicator_FinancialIndicatorEventsProcess<FinIndicator>
	{

		public FinIndicator_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: FinIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicatorEventsProcess : FinIndicator_FinancialIndicatorEventsProcess
	{

		public FinIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

