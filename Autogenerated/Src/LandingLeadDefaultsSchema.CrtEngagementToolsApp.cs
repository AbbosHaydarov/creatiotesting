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

	#region Class: LandingLeadDefaultsSchema

	/// <exclude/>
	public class LandingLeadDefaultsSchema : Terrasoft.Configuration.LandingLeadDefaults_CrtLeadWebForm_TerrasoftSchema
	{

		#region Constructors: Public

		public LandingLeadDefaultsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LandingLeadDefaultsSchema(LandingLeadDefaultsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LandingLeadDefaultsSchema(LandingLeadDefaultsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("fc280ba0-00b4-4a10-88f8-65bf6e72f89f");
			Name = "LandingLeadDefaults";
			ParentSchemaUId = new Guid("ffb1d52b-8389-47ce-b239-0e3cb713c56a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b5a21ae5-6b53-4a07-8184-9dca88e51cce");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
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
			return new LandingLeadDefaults(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LandingLeadDefaults_CrtEngagementToolsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LandingLeadDefaultsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LandingLeadDefaultsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc280ba0-00b4-4a10-88f8-65bf6e72f89f"));
		}

		#endregion

	}

	#endregion

	#region Class: LandingLeadDefaults

	/// <summary>
	/// Default values for the lead fields.
	/// </summary>
	public class LandingLeadDefaults : Terrasoft.Configuration.LandingLeadDefaults_CrtLeadWebForm_Terrasoft
	{

		#region Constructors: Public

		public LandingLeadDefaults(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LandingLeadDefaults";
		}

		public LandingLeadDefaults(LandingLeadDefaults source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LandingLeadDefaults_CrtEngagementToolsAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("LandingLeadDefaultsDeleting", e);
			Inserted += (s, e) => ThrowEvent("LandingLeadDefaultsInserted", e);
			Inserting += (s, e) => ThrowEvent("LandingLeadDefaultsInserting", e);
			Saved += (s, e) => ThrowEvent("LandingLeadDefaultsSaved", e);
			Saving += (s, e) => ThrowEvent("LandingLeadDefaultsSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LandingLeadDefaults(this);
		}

		#endregion

	}

	#endregion

	#region Class: LandingLeadDefaults_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public partial class LandingLeadDefaults_CrtEngagementToolsAppEventsProcess<TEntity> : Terrasoft.Configuration.LandingLeadDefaults_CrtLeadWebFormEventsProcess<TEntity> where TEntity : LandingLeadDefaults
	{

		public LandingLeadDefaults_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LandingLeadDefaults_CrtEngagementToolsAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fc280ba0-00b4-4a10-88f8-65bf6e72f89f");
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

	#region Class: LandingLeadDefaults_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public class LandingLeadDefaults_CrtEngagementToolsAppEventsProcess : LandingLeadDefaults_CrtEngagementToolsAppEventsProcess<LandingLeadDefaults>
	{

		public LandingLeadDefaults_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LandingLeadDefaults_CrtEngagementToolsAppEventsProcess

	public partial class LandingLeadDefaults_CrtEngagementToolsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LandingLeadDefaultsEventsProcess

	/// <exclude/>
	public class LandingLeadDefaultsEventsProcess : LandingLeadDefaults_CrtEngagementToolsAppEventsProcess
	{

		public LandingLeadDefaultsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

