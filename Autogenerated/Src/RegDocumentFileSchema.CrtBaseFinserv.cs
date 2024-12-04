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

	#region Class: RegDocumentFileSchema

	/// <exclude/>
	public class RegDocumentFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public RegDocumentFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RegDocumentFileSchema(RegDocumentFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RegDocumentFileSchema(RegDocumentFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("352f354b-1d72-4c21-b566-b3cc918eb5ef");
			RealUId = new Guid("352f354b-1d72-4c21-b566-b3cc918eb5ef");
			Name = "RegDocumentFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1ea03a9b-e70c-4081-ba2b-89f0a49488a5")) == null) {
				Columns.Add(CreateRegDocumentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRegDocumentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1ea03a9b-e70c-4081-ba2b-89f0a49488a5"),
				Name = @"RegDocument",
				ReferenceSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("352f354b-1d72-4c21-b566-b3cc918eb5ef"),
				ModifiedInSchemaUId = new Guid("352f354b-1d72-4c21-b566-b3cc918eb5ef"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RegDocumentFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RegDocumentFile_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RegDocumentFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RegDocumentFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("352f354b-1d72-4c21-b566-b3cc918eb5ef"));
		}

		#endregion

	}

	#endregion

	#region Class: RegDocumentFile

	/// <summary>
	/// Registration document attachments.
	/// </summary>
	public class RegDocumentFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public RegDocumentFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RegDocumentFile";
		}

		public RegDocumentFile(RegDocumentFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid RegDocumentId {
			get {
				return GetTypedColumnValue<Guid>("RegDocumentId");
			}
			set {
				SetColumnValue("RegDocumentId", value);
				_regDocument = null;
			}
		}

		/// <exclude/>
		public string RegDocumentNumber {
			get {
				return GetTypedColumnValue<string>("RegDocumentNumber");
			}
			set {
				SetColumnValue("RegDocumentNumber", value);
				if (_regDocument != null) {
					_regDocument.Number = value;
				}
			}
		}

		private RegDocument _regDocument;
		/// <summary>
		/// Registration document.
		/// </summary>
		public RegDocument RegDocument {
			get {
				return _regDocument ??
					(_regDocument = LookupColumnEntities.GetEntity("RegDocument") as RegDocument);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RegDocumentFile_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RegDocumentFileDeleted", e);
			Deleting += (s, e) => ThrowEvent("RegDocumentFileDeleting", e);
			Inserted += (s, e) => ThrowEvent("RegDocumentFileInserted", e);
			Inserting += (s, e) => ThrowEvent("RegDocumentFileInserting", e);
			Saved += (s, e) => ThrowEvent("RegDocumentFileSaved", e);
			Saving += (s, e) => ThrowEvent("RegDocumentFileSaving", e);
			Updated += (s, e) => ThrowEvent("RegDocumentFileUpdated", e);
			Validating += (s, e) => ThrowEvent("RegDocumentFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RegDocumentFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: RegDocumentFile_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class RegDocumentFile_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.File_LinkPreviewEventsProcess<TEntity> where TEntity : RegDocumentFile
	{

		public RegDocumentFile_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RegDocumentFile_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("352f354b-1d72-4c21-b566-b3cc918eb5ef");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("352f354b-1d72-4c21-b566-b3cc918eb5ef");
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

	#region Class: RegDocumentFile_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class RegDocumentFile_CrtBaseFinservEventsProcess : RegDocumentFile_CrtBaseFinservEventsProcess<RegDocumentFile>
	{

		public RegDocumentFile_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RegDocumentFile_CrtBaseFinservEventsProcess

	public partial class RegDocumentFile_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RegDocumentFileEventsProcess

	/// <exclude/>
	public class RegDocumentFileEventsProcess : RegDocumentFile_CrtBaseFinservEventsProcess
	{

		public RegDocumentFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

