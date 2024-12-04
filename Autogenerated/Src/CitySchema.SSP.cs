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

	#region Class: City_SSP_TerrasoftSchema

	/// <exclude/>
	public class City_SSP_TerrasoftSchema : Terrasoft.Configuration.City_CrtCoreBase_TerrasoftSchema
	{

		#region Constructors: Public

		public City_SSP_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public City_SSP_TerrasoftSchema(City_SSP_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public City_SSP_TerrasoftSchema(City_SSP_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6fd3d1b7-94d5-4b45-a0a8-80769ffe3541");
			Name = "City_SSP_Terrasoft";
			ParentSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1bc37faf-30bf-4d4a-b067-5fd52b4ccffd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new City_SSP_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new City_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new City_SSP_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new City_SSP_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fd3d1b7-94d5-4b45-a0a8-80769ffe3541"));
		}

		#endregion

	}

	#endregion

	#region Class: City_SSP_Terrasoft

	/// <summary>
	/// City.
	/// </summary>
	public class City_SSP_Terrasoft : Terrasoft.Configuration.City_CrtCoreBase_Terrasoft
	{

		#region Constructors: Public

		public City_SSP_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "City_SSP_Terrasoft";
		}

		public City_SSP_Terrasoft(City_SSP_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new City_SSPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("City_SSP_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("City_SSP_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new City_SSP_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: City_SSPEventsProcess

	/// <exclude/>
	public partial class City_SSPEventsProcess<TEntity> : Terrasoft.Configuration.City_CrtCoreBaseEventsProcess<TEntity> where TEntity : City_SSP_Terrasoft
	{

		public City_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "City_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6fd3d1b7-94d5-4b45-a0a8-80769ffe3541");
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

	#region Class: City_SSPEventsProcess

	/// <exclude/>
	public class City_SSPEventsProcess : City_SSPEventsProcess<City_SSP_Terrasoft>
	{

		public City_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: City_SSPEventsProcess

	public partial class City_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

