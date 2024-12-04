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

	#region Class: AppFormInTagSchema

	/// <exclude/>
	public class AppFormInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public AppFormInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormInTagSchema(AppFormInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormInTagSchema(AppFormInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			RealUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			Name = "AppFormInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
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
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("5d42480f-e941-4ce7-8ea6-8665315d79fe");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityParticipant";
			column.ModifiedInSchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppFormInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormInTag_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormInTag

	/// <summary>
	/// Application form section tag.
	/// </summary>
	public class AppFormInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public AppFormInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormInTag";
		}

		public AppFormInTag(AppFormInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormInTag_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormInTagDeleted", e);
			Deleting += (s, e) => ThrowEvent("AppFormInTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("AppFormInTagInserted", e);
			Inserting += (s, e) => ThrowEvent("AppFormInTagInserting", e);
			Saved += (s, e) => ThrowEvent("AppFormInTagSaved", e);
			Saving += (s, e) => ThrowEvent("AppFormInTagSaving", e);
			Validating += (s, e) => ThrowEvent("AppFormInTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormInTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormInTag_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtCoreBaseEventsProcess<TEntity> where TEntity : AppFormInTag
	{

		public AppFormInTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormInTag_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e37ce9b3-bf06-4e1d-b284-fe693b2d810a");
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

	#region Class: AppFormInTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormInTag_CrtFinservApplicationEventsProcess : AppFormInTag_CrtFinservApplicationEventsProcess<AppFormInTag>
	{

		public AppFormInTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormInTag_CrtFinservApplicationEventsProcess

	public partial class AppFormInTag_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormInTagEventsProcess

	/// <exclude/>
	public class AppFormInTagEventsProcess : AppFormInTag_CrtFinservApplicationEventsProcess
	{

		public AppFormInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

