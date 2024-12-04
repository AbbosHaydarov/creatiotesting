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

	#region Class: BaseAddress_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseAddress_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.BaseAddress_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public BaseAddress_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseAddress_CrtBaseFinserv_TerrasoftSchema(BaseAddress_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseAddress_CrtBaseFinserv_TerrasoftSchema(BaseAddress_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb");
			Name = "BaseAddress_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("400e8687-9616-480d-9d81-61de0235cc86");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateAddressColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("07ece532-b9fa-4dc1-a8b2-eb604194fa80")) == null) {
				Columns.Add(CreateDistrictColumn());
			}
			if (Columns.FindByUId(new Guid("50d3b565-2174-4b13-a5dc-573f11bdea7a")) == null) {
				Columns.Add(CreateStreetColumn());
			}
			if (Columns.FindByUId(new Guid("e456ebc7-3f2b-462c-a28f-141395d7791c")) == null) {
				Columns.Add(CreateBuilding1Column());
			}
			if (Columns.FindByUId(new Guid("95080e0a-b3cd-49ed-8020-320b32c58fe7")) == null) {
				Columns.Add(CreateBuilding2Column());
			}
			if (Columns.FindByUId(new Guid("8cd304ae-9836-42d8-9091-f4fe3fc1c2e3")) == null) {
				Columns.Add(CreateAptOfficeColumn());
			}
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("LongText");
			column.ModifiedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb");
			column.CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDistrictColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("07ece532-b9fa-4dc1-a8b2-eb604194fa80"),
				Name = @"District",
				ReferenceSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				ModifiedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateStreetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("50d3b565-2174-4b13-a5dc-573f11bdea7a"),
				Name = @"Street",
				CreatedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				ModifiedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateBuilding1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("e456ebc7-3f2b-462c-a28f-141395d7791c"),
				Name = @"Building1",
				CreatedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				ModifiedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateBuilding2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("95080e0a-b3cd-49ed-8020-320b32c58fe7"),
				Name = @"Building2",
				CreatedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				ModifiedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateAptOfficeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("8cd304ae-9836-42d8-9091-f4fe3fc1c2e3"),
				Name = @"AptOffice",
				CreatedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				ModifiedInSchemaUId = new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseAddress_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseAddress_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseAddress_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseAddress_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseAddress_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Base address.
	/// </summary>
	public class BaseAddress_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.BaseAddress_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public BaseAddress_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseAddress_CrtBaseFinserv_Terrasoft";
		}

		public BaseAddress_CrtBaseFinserv_Terrasoft(BaseAddress_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseAddress_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseAddress_CrtBaseFinserv_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseAddress_CrtBaseFinserv_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseAddress_CrtBaseFinserv_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseAddress_CrtBaseFinserv_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("BaseAddress_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("BaseAddress_CrtBaseFinserv_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("BaseAddress_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseAddress_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseAddress_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class BaseAddress_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseAddress_CrtCustomer360AppEventsProcess<TEntity> where TEntity : BaseAddress_CrtBaseFinserv_Terrasoft
	{

		public BaseAddress_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseAddress_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bade818f-51cf-4d3c-8c4a-33bdf343bbbb");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private LocalizableString _buildingType;
		public LocalizableString BuildingType {
			get {
				return _buildingType ?? (_buildingType = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.BuildingType.Value"));
			}
		}

		private LocalizableString _aptType;
		public LocalizableString AptType {
			get {
				return _aptType ?? (_aptType = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AptType.Value"));
			}
		}

		private LocalizableString _structType;
		public LocalizableString StructType {
			get {
				return _structType ?? (_structType = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.StructType.Value"));
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

	#region Class: BaseAddress_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class BaseAddress_CrtBaseFinservEventsProcess : BaseAddress_CrtBaseFinservEventsProcess<BaseAddress_CrtBaseFinserv_Terrasoft>
	{

		public BaseAddress_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

