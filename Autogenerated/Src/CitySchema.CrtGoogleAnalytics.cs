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

	#region Class: CitySchema

	/// <exclude/>
	public class CitySchema : Terrasoft.Configuration.City_CrtBaseFinserv_TerrasoftSchema
	{

		#region Constructors: Public

		public CitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CitySchema(CitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CitySchema(CitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("bdfc0902-1f7c-4d38-b9d0-944136cf5eaf");
			Name = "City";
			ParentSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe");
			ExtendParent = true;
			CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("93cd8632-5be3-e09c-d2fc-dfa5adf636d8")) == null) {
				Columns.Add(CreateGACityIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateGACityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("93cd8632-5be3-e09c-d2fc-dfa5adf636d8"),
				Name = @"GACityId",
				CreatedInSchemaUId = new Guid("bdfc0902-1f7c-4d38-b9d0-944136cf5eaf"),
				ModifiedInSchemaUId = new Guid("bdfc0902-1f7c-4d38-b9d0-944136cf5eaf"),
				CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new City(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new City_CrtGoogleAnalyticsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bdfc0902-1f7c-4d38-b9d0-944136cf5eaf"));
		}

		#endregion

	}

	#endregion

	#region Class: City

	/// <summary>
	/// City.
	/// </summary>
	public class City : Terrasoft.Configuration.City_CrtBaseFinserv_Terrasoft
	{

		#region Constructors: Public

		public City(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "City";
		}

		public City(City source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Google Analytics City Id.
		/// </summary>
		public string GACityId {
			get {
				return GetTypedColumnValue<string>("GACityId");
			}
			set {
				SetColumnValue("GACityId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new City_CrtGoogleAnalyticsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("CityDeleting", e);
			Inserted += (s, e) => ThrowEvent("CityInserted", e);
			Inserting += (s, e) => ThrowEvent("CityInserting", e);
			Saved += (s, e) => ThrowEvent("CitySaved", e);
			Saving += (s, e) => ThrowEvent("CitySaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new City(this);
		}

		#endregion

	}

	#endregion

	#region Class: City_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public partial class City_CrtGoogleAnalyticsEventsProcess<TEntity> : Terrasoft.Configuration.City_CrtBaseFinservEventsProcess<TEntity> where TEntity : City
	{

		public City_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "City_CrtGoogleAnalyticsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bdfc0902-1f7c-4d38-b9d0-944136cf5eaf");
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

	#region Class: City_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public class City_CrtGoogleAnalyticsEventsProcess : City_CrtGoogleAnalyticsEventsProcess<City>
	{

		public City_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: City_CrtGoogleAnalyticsEventsProcess

	public partial class City_CrtGoogleAnalyticsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CityEventsProcess

	/// <exclude/>
	public class CityEventsProcess : City_CrtGoogleAnalyticsEventsProcess
	{

		public CityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

