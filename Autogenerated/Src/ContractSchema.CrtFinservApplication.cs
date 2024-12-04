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

	#region Class: Contract_CrtFinservApplication_TerrasoftSchema

	/// <exclude/>
	public class Contract_CrtFinservApplication_TerrasoftSchema : Terrasoft.Configuration.Contract_CrtFinservContract_TerrasoftSchema
	{

		#region Constructors: Public

		public Contract_CrtFinservApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contract_CrtFinservApplication_TerrasoftSchema(Contract_CrtFinservApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contract_CrtFinservApplication_TerrasoftSchema(Contract_CrtFinservApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8");
			Name = "Contract_CrtFinservApplication_Terrasoft";
			ParentSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("25db58a7-557e-4287-b7fd-98319ca0272d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0f15b5f2-ead8-468d-b20e-c15418558efc")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
			if (Columns.FindByUId(new Guid("56737a3e-0602-4994-9248-4120242e9c83")) == null) {
				Columns.Add(CreateContactContractColumn());
			}
			if (Columns.FindByUId(new Guid("8690c877-ed80-43ce-a566-ebe5a0317a4a")) == null) {
				Columns.Add(CreateDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("22edc9ff-df17-4a36-8c35-11783df94770")) == null) {
				Columns.Add(CreatePackageColumn());
			}
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Sequence,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountColumn() {
			EntitySchemaColumn column = base.CreateAccountColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8");
			return column;
		}

		protected override EntitySchemaColumn CreateOurCompanyColumn() {
			EntitySchemaColumn column = base.CreateOurCompanyColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f15b5f2-ead8-468d-b20e-c15418558efc"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				ModifiedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				CreatedInPackageId = new Guid("25db58a7-557e-4287-b7fd-98319ca0272d")
			};
		}

		protected virtual EntitySchemaColumn CreateContactContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("56737a3e-0602-4994-9248-4120242e9c83"),
				Name = @"ContactContract",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				ModifiedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				CreatedInPackageId = new Guid("25db58a7-557e-4287-b7fd-98319ca0272d")
			};
		}

		protected virtual EntitySchemaColumn CreateDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8690c877-ed80-43ce-a566-ebe5a0317a4a"),
				Name = @"Department",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				ModifiedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				CreatedInPackageId = new Guid("25db58a7-557e-4287-b7fd-98319ca0272d")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("22edc9ff-df17-4a36-8c35-11783df94770"),
				Name = @"Package",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				ModifiedInSchemaUId = new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"),
				CreatedInPackageId = new Guid("25db58a7-557e-4287-b7fd-98319ca0272d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contract_CrtFinservApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contract_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contract_CrtFinservApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contract_CrtFinservApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8"));
		}

		#endregion

	}

	#endregion

	#region Class: Contract_CrtFinservApplication_Terrasoft

	/// <summary>
	/// Contract.
	/// </summary>
	public class Contract_CrtFinservApplication_Terrasoft : Terrasoft.Configuration.Contract_CrtFinservContract_Terrasoft
	{

		#region Constructors: Public

		public Contract_CrtFinservApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contract_CrtFinservApplication_Terrasoft";
		}

		public Contract_CrtFinservApplication_Terrasoft(Contract_CrtFinservApplication_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid FinApplicationId {
			get {
				return GetTypedColumnValue<Guid>("FinApplicationId");
			}
			set {
				SetColumnValue("FinApplicationId", value);
				_finApplication = null;
			}
		}

		/// <exclude/>
		public string FinApplicationNumber {
			get {
				return GetTypedColumnValue<string>("FinApplicationNumber");
			}
			set {
				SetColumnValue("FinApplicationNumber", value);
				if (_finApplication != null) {
					_finApplication.Number = value;
				}
			}
		}

		private FinApplication _finApplication;
		/// <summary>
		/// Application.
		/// </summary>
		public FinApplication FinApplication {
			get {
				return _finApplication ??
					(_finApplication = LookupColumnEntities.GetEntity("FinApplication") as FinApplication);
			}
		}

		/// <exclude/>
		public Guid ContactContractId {
			get {
				return GetTypedColumnValue<Guid>("ContactContractId");
			}
			set {
				SetColumnValue("ContactContractId", value);
				_contactContract = null;
			}
		}

		/// <exclude/>
		public string ContactContractName {
			get {
				return GetTypedColumnValue<string>("ContactContractName");
			}
			set {
				SetColumnValue("ContactContractName", value);
				if (_contactContract != null) {
					_contactContract.Name = value;
				}
			}
		}

		private Contact _contactContract;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact ContactContract {
			get {
				return _contactContract ??
					(_contactContract = LookupColumnEntities.GetEntity("ContactContract") as Contact);
			}
		}

		/// <exclude/>
		public Guid DepartmentId {
			get {
				return GetTypedColumnValue<Guid>("DepartmentId");
			}
			set {
				SetColumnValue("DepartmentId", value);
				_department = null;
			}
		}

		/// <exclude/>
		public string DepartmentName {
			get {
				return GetTypedColumnValue<string>("DepartmentName");
			}
			set {
				SetColumnValue("DepartmentName", value);
				if (_department != null) {
					_department.Name = value;
				}
			}
		}

		private Account _department;
		/// <summary>
		/// Office.
		/// </summary>
		public Account Department {
			get {
				return _department ??
					(_department = LookupColumnEntities.GetEntity("Department") as Account);
			}
		}

		/// <exclude/>
		public Guid PackageId {
			get {
				return GetTypedColumnValue<Guid>("PackageId");
			}
			set {
				SetColumnValue("PackageId", value);
				_package = null;
			}
		}

		/// <exclude/>
		public string PackageName {
			get {
				return GetTypedColumnValue<string>("PackageName");
			}
			set {
				SetColumnValue("PackageName", value);
				if (_package != null) {
					_package.Name = value;
				}
			}
		}

		private Product _package;
		/// <summary>
		/// Banking package.
		/// </summary>
		public Product Package {
			get {
				return _package ??
					(_package = LookupColumnEntities.GetEntity("Package") as Product);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contract_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contract_CrtFinservApplication_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contract_CrtFinservApplication_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Contract_CrtFinservApplication_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Contract_CrtFinservApplication_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Contract_CrtFinservApplication_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Contract_CrtFinservApplication_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Contract_CrtFinservApplication_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contract_CrtFinservApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contract_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class Contract_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.Contract_CrtFinservContractEventsProcess<TEntity> where TEntity : Contract_CrtFinservApplication_Terrasoft
	{

		public Contract_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contract_CrtFinservApplicationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c0037322-364f-4ca5-a42d-a1b8ff2af5a8");
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

	#region Class: Contract_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class Contract_CrtFinservApplicationEventsProcess : Contract_CrtFinservApplicationEventsProcess<Contract_CrtFinservApplication_Terrasoft>
	{

		public Contract_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contract_CrtFinservApplicationEventsProcess

	public partial class Contract_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

