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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: AppFormTagSchema

	/// <exclude/>
	public class AppFormTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public AppFormTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormTagSchema(AppFormTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormTagSchema(AppFormTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			RealUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			Name = "AppFormTag";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("bfedb8f0-6459-4f37-b286-469b67ef12f5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppFormTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormTag_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormTag

	/// <summary>
	/// Application from section tag.
	/// </summary>
	public class AppFormTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public AppFormTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormTag";
		}

		public AppFormTag(AppFormTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormTag_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormTagDeleted", e);
			Deleting += (s, e) => ThrowEvent("AppFormTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("AppFormTagInserted", e);
			Inserting += (s, e) => ThrowEvent("AppFormTagInserting", e);
			Saved += (s, e) => ThrowEvent("AppFormTagSaved", e);
			Saving += (s, e) => ThrowEvent("AppFormTagSaving", e);
			Validating += (s, e) => ThrowEvent("AppFormTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormTag_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : AppFormTag
	{

		public AppFormTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormTag_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
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

	#region Class: AppFormTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormTag_CrtFinservApplicationEventsProcess : AppFormTag_CrtFinservApplicationEventsProcess<AppFormTag>
	{

		public AppFormTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormTag_CrtFinservApplicationEventsProcess

	public partial class AppFormTag_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormTagEventsProcess

	/// <exclude/>
	public class AppFormTagEventsProcess : AppFormTag_CrtFinservApplicationEventsProcess
	{

		public AppFormTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

