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

	#region Class: City_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class City_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.City_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public City_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public City_CrtBaseFinserv_TerrasoftSchema(City_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public City_CrtBaseFinserv_TerrasoftSchema(City_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("da3b051d-d4d3-4a3b-8672-afd3cfe6aa0a");
			Name = "City_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("13fa97ca-dfed-4f22-9f29-bcee72a25bfb")) == null) {
				Columns.Add(CreateDistrictColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDistrictColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("13fa97ca-dfed-4f22-9f29-bcee72a25bfb"),
				Name = @"District",
				ReferenceSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("da3b051d-d4d3-4a3b-8672-afd3cfe6aa0a"),
				ModifiedInSchemaUId = new Guid("da3b051d-d4d3-4a3b-8672-afd3cfe6aa0a"),
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
			return new City_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new City_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new City_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new City_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da3b051d-d4d3-4a3b-8672-afd3cfe6aa0a"));
		}

		#endregion

	}

	#endregion

	#region Class: City_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// City.
	/// </summary>
	public class City_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.City_SSP_Terrasoft
	{

		#region Constructors: Public

		public City_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "City_CrtBaseFinserv_Terrasoft";
		}

		public City_CrtBaseFinserv_Terrasoft(City_CrtBaseFinserv_Terrasoft source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new City_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("City_CrtBaseFinserv_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("City_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new City_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: City_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class City_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.City_SSPEventsProcess<TEntity> where TEntity : City_CrtBaseFinserv_Terrasoft
	{

		public City_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "City_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("da3b051d-d4d3-4a3b-8672-afd3cfe6aa0a");
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

	#region Class: City_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class City_CrtBaseFinservEventsProcess : City_CrtBaseFinservEventsProcess<City_CrtBaseFinserv_Terrasoft>
	{

		public City_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: City_CrtBaseFinservEventsProcess

	public partial class City_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

