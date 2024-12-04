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
	using Terrasoft.Configuration;
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

	#region Class: AppFormFileSchema

	/// <exclude/>
	public class AppFormFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public AppFormFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormFileSchema(AppFormFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormFileSchema(AppFormFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			RealUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			Name = "AppFormFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
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
			if (Columns.FindByUId(new Guid("78276298-19dd-44a7-b6d3-3ba7ed77da69")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			return column;
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("78276298-19dd-44a7-b6d3-3ba7ed77da69"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa"),
				ModifiedInSchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa"),
				CreatedInPackageId = new Guid("bfedb8f0-6459-4f37-b286-469b67ef12f5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppFormFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormFile_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c642680-158a-4487-a7f2-b8a68e421daa"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormFile

	/// <summary>
	/// Application form file.
	/// </summary>
	public class AppFormFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public AppFormFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormFile";
		}

		public AppFormFile(AppFormFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AppFormId {
			get {
				return GetTypedColumnValue<Guid>("AppFormId");
			}
			set {
				SetColumnValue("AppFormId", value);
				_appForm = null;
			}
		}

		/// <exclude/>
		public string AppFormParticipant {
			get {
				return GetTypedColumnValue<string>("AppFormParticipant");
			}
			set {
				SetColumnValue("AppFormParticipant", value);
				if (_appForm != null) {
					_appForm.Participant = value;
				}
			}
		}

		private AppForm _appForm;
		/// <summary>
		/// AppForm.
		/// </summary>
		public AppForm AppForm {
			get {
				return _appForm ??
					(_appForm = LookupColumnEntities.GetEntity("AppForm") as AppForm);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormFile_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormFileDeleted", e);
			Updated += (s, e) => ThrowEvent("AppFormFileUpdated", e);
			Validating += (s, e) => ThrowEvent("AppFormFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormFile_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.File_LinkPreviewEventsProcess<TEntity> where TEntity : AppFormFile
	{

		public AppFormFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormFile_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6c642680-158a-4487-a7f2-b8a68e421daa");
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

	#region Class: AppFormFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormFile_CrtFinservApplicationEventsProcess : AppFormFile_CrtFinservApplicationEventsProcess<AppFormFile>
	{

		public AppFormFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormFile_CrtFinservApplicationEventsProcess

	public partial class AppFormFile_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormFileEventsProcess

	/// <exclude/>
	public class AppFormFileEventsProcess : AppFormFile_CrtFinservApplicationEventsProcess
	{

		public AppFormFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

