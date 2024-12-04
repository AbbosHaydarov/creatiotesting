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
	using Terrasoft.Configuration;
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

	#region Class: Account_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class Account_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.Account_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public Account_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Account_CrtBaseFinserv_TerrasoftSchema(Account_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Account_CrtBaseFinserv_TerrasoftSchema(Account_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIAccountAlternativeNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("ebe37f22-d03b-4ff5-85ab-b19cfd41de7b");
			index.Name = "IAccountAlternativeName";
			index.CreatedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b");
			index.ModifiedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b");
			index.CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1");
			EntitySchemaIndexColumn alternativeNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("58081ad2-6e01-4b09-8a7f-d6e550fd4d71"),
				ColumnUId = new Guid("e36ae687-347d-4bf7-b260-90129862e357"),
				CreatedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b"),
				ModifiedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b"),
				CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(alternativeNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22");
			Name = "Account_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4b8aa047-9de8-42b8-ab32-fbf0f9a39479")) == null) {
				Columns.Add(CreateINNColumn());
			}
			if (Columns.FindByUId(new Guid("92c1d503-f692-433d-be5b-3fa3e918d265")) == null) {
				Columns.Add(CreateIsNotResidentColumn());
			}
			if (Columns.FindByUId(new Guid("b395bb7d-d463-4693-a9e3-26ad3d151f1b")) == null) {
				Columns.Add(CreateIsLiquidatedColumn());
			}
			if (Columns.FindByUId(new Guid("8f22fb85-b155-4c8b-bb8d-6ea48bd905ef")) == null) {
				Columns.Add(CreateIsInBlackListColumn());
			}
			if (Columns.FindByUId(new Guid("172591af-37fa-4192-9994-3d6456fd889d")) == null) {
				Columns.Add(CreateLiquidationDateColumn());
			}
			if (Columns.FindByUId(new Guid("5e482d24-53c3-4f79-8160-fc2372dab6d3")) == null) {
				Columns.Add(CreateBlackListReasonColumn());
			}
			if (Columns.FindByUId(new Guid("2ac2a5bb-b787-4484-9a23-fddf73b8c36b")) == null) {
				Columns.Add(CreateBlackListDateColumn());
			}
			if (Columns.FindByUId(new Guid("b8c6044b-efe3-42e6-9c91-ea96d6faab71")) == null) {
				Columns.Add(CreateOwnershipFormColumn());
			}
			if (Columns.FindByUId(new Guid("85882be0-0254-48d5-b0f3-15deb7639fef")) == null) {
				Columns.Add(CreateBranchColumn());
			}
			if (Columns.FindByUId(new Guid("a01c81b5-f861-4078-99ac-4baa75fdde30")) == null) {
				Columns.Add(CreateStreetColumn());
			}
			if (Columns.FindByUId(new Guid("a9cb2804-7edb-4c2c-9251-14f3fc0add7b")) == null) {
				Columns.Add(CreateBuilding1Column());
			}
			if (Columns.FindByUId(new Guid("8207a1db-e173-4422-967b-9a16f57786e0")) == null) {
				Columns.Add(CreateBuilding2Column());
			}
			if (Columns.FindByUId(new Guid("e1dddd7a-35f4-4b28-8d13-fc3e08ce8758")) == null) {
				Columns.Add(CreateAptOfficeColumn());
			}
			if (Columns.FindByUId(new Guid("e1da7965-43a0-49ae-a8fc-20c14be910f7")) == null) {
				Columns.Add(CreateDistrictColumn());
			}
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.IsValueCloneable = true;
			column.ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected virtual EntitySchemaColumn CreateINNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4b8aa047-9de8-42b8-ab32-fbf0f9a39479"),
				Name = @"INN",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateIsNotResidentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("92c1d503-f692-433d-be5b-3fa3e918d265"),
				Name = @"IsNotResident",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateIsLiquidatedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b395bb7d-d463-4693-a9e3-26ad3d151f1b"),
				Name = @"IsLiquidated",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateIsInBlackListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8f22fb85-b155-4c8b-bb8d-6ea48bd905ef"),
				Name = @"IsInBlackList",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateLiquidationDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("172591af-37fa-4192-9994-3d6456fd889d"),
				Name = @"LiquidationDate",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateBlackListReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("5e482d24-53c3-4f79-8160-fc2372dab6d3"),
				Name = @"BlackListReason",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateBlackListDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("2ac2a5bb-b787-4484-9a23-fddf73b8c36b"),
				Name = @"BlackListDate",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnershipFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b8c6044b-efe3-42e6-9c91-ea96d6faab71"),
				Name = @"OwnershipForm",
				ReferenceSchemaUId = new Guid("ca55b3ff-0ee5-4866-b383-15dbaa191aa2"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8")
			};
		}

		protected virtual EntitySchemaColumn CreateBranchColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("85882be0-0254-48d5-b0f3-15deb7639fef"),
				Name = @"Branch",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("27329051-b308-4a64-83ef-1a0f05a9ca5f")
			};
		}

		protected virtual EntitySchemaColumn CreateStreetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a01c81b5-f861-4078-99ac-4baa75fdde30"),
				Name = @"Street",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateBuilding1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("a9cb2804-7edb-4c2c-9251-14f3fc0add7b"),
				Name = @"Building1",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateBuilding2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("8207a1db-e173-4422-967b-9a16f57786e0"),
				Name = @"Building2",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateAptOfficeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("e1dddd7a-35f4-4b28-8d13-fc3e08ce8758"),
				Name = @"AptOffice",
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateDistrictColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e1da7965-43a0-49ae-a8fc-20c14be910f7"),
				Name = @"District",
				ReferenceSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				ModifiedInSchemaUId = new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIAccountAlternativeNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Account_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Account_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Account_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Account_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70c74984-47c3-487b-ba37-f8c415cfde22"));
		}

		#endregion

	}

	#endregion

	#region Class: Account_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Legal entity.
	/// </summary>
	public class Account_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.Account_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public Account_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Account_CrtBaseFinserv_Terrasoft";
		}

		public Account_CrtBaseFinserv_Terrasoft(Account_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Taxpayer number.
		/// </summary>
		public string INN {
			get {
				return GetTypedColumnValue<string>("INN");
			}
			set {
				SetColumnValue("INN", value);
			}
		}

		/// <summary>
		/// Non-resident.
		/// </summary>
		public bool IsNotResident {
			get {
				return GetTypedColumnValue<bool>("IsNotResident");
			}
			set {
				SetColumnValue("IsNotResident", value);
			}
		}

		/// <summary>
		/// Liquidated.
		/// </summary>
		public bool IsLiquidated {
			get {
				return GetTypedColumnValue<bool>("IsLiquidated");
			}
			set {
				SetColumnValue("IsLiquidated", value);
			}
		}

		/// <summary>
		/// Blacklisted.
		/// </summary>
		public bool IsInBlackList {
			get {
				return GetTypedColumnValue<bool>("IsInBlackList");
			}
			set {
				SetColumnValue("IsInBlackList", value);
			}
		}

		/// <summary>
		/// Liquidated on.
		/// </summary>
		public DateTime LiquidationDate {
			get {
				return GetTypedColumnValue<DateTime>("LiquidationDate");
			}
			set {
				SetColumnValue("LiquidationDate", value);
			}
		}

		/// <summary>
		/// Reason for blacklisting.
		/// </summary>
		public string BlackListReason {
			get {
				return GetTypedColumnValue<string>("BlackListReason");
			}
			set {
				SetColumnValue("BlackListReason", value);
			}
		}

		/// <summary>
		/// Blacklisted on.
		/// </summary>
		public DateTime BlackListDate {
			get {
				return GetTypedColumnValue<DateTime>("BlackListDate");
			}
			set {
				SetColumnValue("BlackListDate", value);
			}
		}

		/// <exclude/>
		public Guid OwnershipFormId {
			get {
				return GetTypedColumnValue<Guid>("OwnershipFormId");
			}
			set {
				SetColumnValue("OwnershipFormId", value);
				_ownershipForm = null;
			}
		}

		/// <exclude/>
		public string OwnershipFormName {
			get {
				return GetTypedColumnValue<string>("OwnershipFormName");
			}
			set {
				SetColumnValue("OwnershipFormName", value);
				if (_ownershipForm != null) {
					_ownershipForm.Name = value;
				}
			}
		}

		private AccountOwnershipForm _ownershipForm;
		/// <summary>
		/// Business entity.
		/// </summary>
		public AccountOwnershipForm OwnershipForm {
			get {
				return _ownershipForm ??
					(_ownershipForm = LookupColumnEntities.GetEntity("OwnershipForm") as AccountOwnershipForm);
			}
		}

		/// <exclude/>
		public Guid BranchId {
			get {
				return GetTypedColumnValue<Guid>("BranchId");
			}
			set {
				SetColumnValue("BranchId", value);
				_branch = null;
			}
		}

		/// <exclude/>
		public string BranchName {
			get {
				return GetTypedColumnValue<string>("BranchName");
			}
			set {
				SetColumnValue("BranchName", value);
				if (_branch != null) {
					_branch.Name = value;
				}
			}
		}

		private Account _branch;
		/// <summary>
		/// Branch.
		/// </summary>
		public Account Branch {
			get {
				return _branch ??
					(_branch = LookupColumnEntities.GetEntity("Branch") as Account);
			}
		}

		/// <summary>
		/// Street.
		/// </summary>
		public string Street {
			get {
				return GetTypedColumnValue<string>("Street");
			}
			set {
				SetColumnValue("Street", value);
			}
		}

		/// <summary>
		/// Building.
		/// </summary>
		public string Building1 {
			get {
				return GetTypedColumnValue<string>("Building1");
			}
			set {
				SetColumnValue("Building1", value);
			}
		}

		/// <summary>
		/// Unit.
		/// </summary>
		public string Building2 {
			get {
				return GetTypedColumnValue<string>("Building2");
			}
			set {
				SetColumnValue("Building2", value);
			}
		}

		/// <summary>
		/// Apartment/office.
		/// </summary>
		public string AptOffice {
			get {
				return GetTypedColumnValue<string>("AptOffice");
			}
			set {
				SetColumnValue("AptOffice", value);
			}
		}

		/// <exclude/>
		public Guid DistrictId {
			get {
				return GetTypedColumnValue<Guid>("DistrictId");
			}
			set {
				SetColumnValue("DistrictId", value);
				_district = null;
			}
		}

		/// <exclude/>
		public string DistrictName {
			get {
				return GetTypedColumnValue<string>("DistrictName");
			}
			set {
				SetColumnValue("DistrictName", value);
				if (_district != null) {
					_district.Name = value;
				}
			}
		}

		private District _district;
		/// <summary>
		/// District.
		/// </summary>
		public District District {
			get {
				return _district ??
					(_district = LookupColumnEntities.GetEntity("District") as District);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Account_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Account_CrtBaseFinserv_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Account_CrtBaseFinserv_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Account_CrtBaseFinserv_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Account_CrtBaseFinserv_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Account_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Account_CrtBaseFinserv_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Account_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Account_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Account_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class Account_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.Account_CrtCustomer360AppEventsProcess<TEntity> where TEntity : Account_CrtBaseFinserv_Terrasoft
	{

		public Account_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Account_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("70c74984-47c3-487b-ba37-f8c415cfde22");
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

	#region Class: Account_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class Account_CrtBaseFinservEventsProcess : Account_CrtBaseFinservEventsProcess<Account_CrtBaseFinserv_Terrasoft>
	{

		public Account_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Account_CrtBaseFinservEventsProcess

	public partial class Account_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

