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

	#region Class: LandingObjectDefaultsSchema

	/// <exclude/>
	public class LandingObjectDefaultsSchema : Terrasoft.Configuration.LandingObjectDefaults_CrtWebForm_TerrasoftSchema
	{

		#region Constructors: Public

		public LandingObjectDefaultsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LandingObjectDefaultsSchema(LandingObjectDefaultsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LandingObjectDefaultsSchema(LandingObjectDefaultsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6");
			Name = "LandingObjectDefaults";
			ParentSchemaUId = new Guid("53c5ad19-3faf-4a01-97bc-17c9c817fcbc");
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

		protected override EntitySchemaColumn CreateTextValueColumn() {
			EntitySchemaColumn column = base.CreateTextValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6");
			return column;
		}

		protected override EntitySchemaColumn CreateIntegerValueColumn() {
			EntitySchemaColumn column = base.CreateIntegerValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6");
			return column;
		}

		protected override EntitySchemaColumn CreateFloatValueColumn() {
			EntitySchemaColumn column = base.CreateFloatValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6");
			return column;
		}

		protected override EntitySchemaColumn CreateBooleanValueColumn() {
			EntitySchemaColumn column = base.CreateBooleanValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6");
			return column;
		}

		protected override EntitySchemaColumn CreateDateTimeValueColumn() {
			EntitySchemaColumn column = base.CreateDateTimeValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LandingObjectDefaults(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LandingObjectDefaults_CrtEngagementToolsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LandingObjectDefaultsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LandingObjectDefaultsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6"));
		}

		#endregion

	}

	#endregion

	#region Class: LandingObjectDefaults

	/// <summary>
	/// Default values for the object fields.
	/// </summary>
	public class LandingObjectDefaults : Terrasoft.Configuration.LandingObjectDefaults_CrtWebForm_Terrasoft
	{

		#region Constructors: Public

		public LandingObjectDefaults(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LandingObjectDefaults";
		}

		public LandingObjectDefaults(LandingObjectDefaults source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LandingObjectDefaults_CrtEngagementToolsAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("LandingObjectDefaultsDeleting", e);
			Inserted += (s, e) => ThrowEvent("LandingObjectDefaultsInserted", e);
			Inserting += (s, e) => ThrowEvent("LandingObjectDefaultsInserting", e);
			Saved += (s, e) => ThrowEvent("LandingObjectDefaultsSaved", e);
			Saving += (s, e) => ThrowEvent("LandingObjectDefaultsSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LandingObjectDefaults(this);
		}

		#endregion

	}

	#endregion

	#region Class: LandingObjectDefaults_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public partial class LandingObjectDefaults_CrtEngagementToolsAppEventsProcess<TEntity> : Terrasoft.Configuration.LandingObjectDefaults_CrtWebFormEventsProcess<TEntity> where TEntity : LandingObjectDefaults
	{

		public LandingObjectDefaults_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LandingObjectDefaults_CrtEngagementToolsAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c2d4ec5a-2923-41f2-a5a8-44d696be9cc6");
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

	#region Class: LandingObjectDefaults_CrtEngagementToolsAppEventsProcess

	/// <exclude/>
	public class LandingObjectDefaults_CrtEngagementToolsAppEventsProcess : LandingObjectDefaults_CrtEngagementToolsAppEventsProcess<LandingObjectDefaults>
	{

		public LandingObjectDefaults_CrtEngagementToolsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LandingObjectDefaults_CrtEngagementToolsAppEventsProcess

	public partial class LandingObjectDefaults_CrtEngagementToolsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LandingObjectDefaultsEventsProcess

	/// <exclude/>
	public class LandingObjectDefaultsEventsProcess : LandingObjectDefaults_CrtEngagementToolsAppEventsProcess
	{

		public LandingObjectDefaultsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

