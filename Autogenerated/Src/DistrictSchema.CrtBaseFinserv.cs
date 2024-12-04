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

	#region Class: DistrictSchema

	/// <exclude/>
	public class DistrictSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DistrictSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DistrictSchema(DistrictSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DistrictSchema(DistrictSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			RealUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			Name = "District";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8d422670-056c-415c-93a5-096ecd4a0b5c")) == null) {
				Columns.Add(CreateRegionColumn());
			}
			if (Columns.FindByUId(new Guid("369e0ca4-ebe0-4bc2-af95-8f8a69cfc1ec")) == null) {
				Columns.Add(CreateCountryColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			column.CreatedInPackageId = new Guid("1ca35e06-3f93-4797-bb84-39f955daabc6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateRegionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8d422670-056c-415c-93a5-096ecd4a0b5c"),
				Name = @"Region",
				ReferenceSchemaUId = new Guid("fa4eb497-e6a3-4f8c-8568-5df4bd2a8b91"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
				ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("369e0ca4-ebe0-4bc2-af95-8f8a69cfc1ec"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
				ModifiedInSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
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
			return new District(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new District_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DistrictSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DistrictSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"));
		}

		#endregion

	}

	#endregion

	#region Class: District

	/// <summary>
	/// District.
	/// </summary>
	public class District : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public District(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "District";
		}

		public District(District source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid RegionId {
			get {
				return GetTypedColumnValue<Guid>("RegionId");
			}
			set {
				SetColumnValue("RegionId", value);
				_region = null;
			}
		}

		/// <exclude/>
		public string RegionName {
			get {
				return GetTypedColumnValue<string>("RegionName");
			}
			set {
				SetColumnValue("RegionName", value);
				if (_region != null) {
					_region.Name = value;
				}
			}
		}

		private Region _region;
		/// <summary>
		/// State/province.
		/// </summary>
		public Region Region {
			get {
				return _region ??
					(_region = LookupColumnEntities.GetEntity("Region") as Region);
			}
		}

		/// <exclude/>
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = LookupColumnEntities.GetEntity("Country") as Country);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new District_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DistrictDeleted", e);
			Validating += (s, e) => ThrowEvent("DistrictValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new District(this);
		}

		#endregion

	}

	#endregion

	#region Class: District_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class District_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : District
	{

		public District_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "District_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f");
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

	#region Class: District_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class District_CrtBaseFinservEventsProcess : District_CrtBaseFinservEventsProcess<District>
	{

		public District_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: District_CrtBaseFinservEventsProcess

	public partial class District_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DistrictEventsProcess

	/// <exclude/>
	public class DistrictEventsProcess : District_CrtBaseFinservEventsProcess
	{

		public DistrictEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

