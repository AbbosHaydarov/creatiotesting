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

	#region Class: DocListInFinAppSchema

	/// <exclude/>
	public class DocListInFinAppSchema : Terrasoft.Configuration.DocumentListSchema
	{

		#region Constructors: Public

		public DocListInFinAppSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocListInFinAppSchema(DocListInFinAppSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocListInFinAppSchema(DocListInFinAppSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a");
			RealUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a");
			Name = "DocListInFinApp";
			ParentSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3d232a98-bfd6-47ba-ba23-c8b76435d267");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("da901b78-5f39-4dbe-8386-61908f29d159")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
			if (Columns.FindByUId(new Guid("94a81365-3250-4e72-a09b-3b2f2e96c5f4")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("1d4ee9f7-e0c8-4cfd-9150-d8d3c921aab0")) == null) {
				Columns.Add(CreateDocumentLinkColumn());
			}
			if (Columns.FindByUId(new Guid("61ac5ad7-dcf4-408d-862b-7449529b1d5b")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("da901b78-5f39-4dbe-8386-61908f29d159"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				ModifiedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				CreatedInPackageId = new Guid("3d232a98-bfd6-47ba-ba23-c8b76435d267")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("94a81365-3250-4e72-a09b-3b2f2e96c5f4"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				ModifiedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				CreatedInPackageId = new Guid("c8da7e08-6492-4148-9858-7626794d6819")
			};
		}

		protected virtual EntitySchemaColumn CreateDocumentLinkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1d4ee9f7-e0c8-4cfd-9150-d8d3c921aab0"),
				Name = @"DocumentLink",
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				ModifiedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				CreatedInPackageId = new Guid("a93b7107-48fd-44f4-bf18-0f14a4577cc4")
			};
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("61ac5ad7-dcf4-408d-862b-7449529b1d5b"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				ModifiedInSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				CreatedInPackageId = new Guid("a93b7107-48fd-44f4-bf18-0f14a4577cc4")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocListInFinApp(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocListInFinApp_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocListInFinAppSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocListInFinAppSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"));
		}

		#endregion

	}

	#endregion

	#region Class: DocListInFinApp

	/// <summary>
	/// Required documents in application.
	/// </summary>
	public class DocListInFinApp : Terrasoft.Configuration.DocumentList
	{

		#region Constructors: Public

		public DocListInFinApp(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocListInFinApp";
		}

		public DocListInFinApp(DocListInFinApp source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid FinApplicationId {
			get {
				return GetTypedColumnValue<Guid>("FinApplicationId");
			}
			set {
				SetColumnValue("FinApplicationId", value);
				_finApplication = null;
			}
		}

		/// <exclude/>
		public string FinApplicationNumber {
			get {
				return GetTypedColumnValue<string>("FinApplicationNumber");
			}
			set {
				SetColumnValue("FinApplicationNumber", value);
				if (_finApplication != null) {
					_finApplication.Number = value;
				}
			}
		}

		private FinApplication _finApplication;
		/// <summary>
		/// Application.
		/// </summary>
		public FinApplication FinApplication {
			get {
				return _finApplication ??
					(_finApplication = LookupColumnEntities.GetEntity("FinApplication") as FinApplication);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid DocumentLinkId {
			get {
				return GetTypedColumnValue<Guid>("DocumentLinkId");
			}
			set {
				SetColumnValue("DocumentLinkId", value);
				_documentLink = null;
			}
		}

		/// <exclude/>
		public string DocumentLinkNumber {
			get {
				return GetTypedColumnValue<string>("DocumentLinkNumber");
			}
			set {
				SetColumnValue("DocumentLinkNumber", value);
				if (_documentLink != null) {
					_documentLink.Number = value;
				}
			}
		}

		private Document _documentLink;
		/// <summary>
		/// Document link.
		/// </summary>
		public Document DocumentLink {
			get {
				return _documentLink ??
					(_documentLink = LookupColumnEntities.GetEntity("DocumentLink") as Document);
			}
		}

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
		/// Application form.
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
			var process = new DocListInFinApp_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocListInFinAppDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocListInFinAppDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocListInFinAppInserted", e);
			Inserting += (s, e) => ThrowEvent("DocListInFinAppInserting", e);
			Saved += (s, e) => ThrowEvent("DocListInFinAppSaved", e);
			Saving += (s, e) => ThrowEvent("DocListInFinAppSaving", e);
			Validating += (s, e) => ThrowEvent("DocListInFinAppValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocListInFinApp(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocListInFinApp_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class DocListInFinApp_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.DocumentList_CrtFinservProductEventsProcess<TEntity> where TEntity : DocListInFinApp
	{

		public DocListInFinApp_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocListInFinApp_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a");
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

	#region Class: DocListInFinApp_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class DocListInFinApp_CrtFinservApplicationEventsProcess : DocListInFinApp_CrtFinservApplicationEventsProcess<DocListInFinApp>
	{

		public DocListInFinApp_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocListInFinApp_CrtFinservApplicationEventsProcess

	public partial class DocListInFinApp_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocListInFinAppEventsProcess

	/// <exclude/>
	public class DocListInFinAppEventsProcess : DocListInFinApp_CrtFinservApplicationEventsProcess
	{

		public DocListInFinAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

