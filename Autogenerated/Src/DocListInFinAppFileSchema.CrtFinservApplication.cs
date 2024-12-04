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

	#region Class: DocListInFinAppFileSchema

	/// <exclude/>
	public class DocListInFinAppFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public DocListInFinAppFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocListInFinAppFileSchema(DocListInFinAppFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocListInFinAppFileSchema(DocListInFinAppFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96b4922a-9305-4e91-83c5-91d9c430bda5");
			RealUId = new Guid("96b4922a-9305-4e91-83c5-91d9c430bda5");
			Name = "DocListInFinAppFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
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
			if (Columns.FindByUId(new Guid("059a625d-6f2a-4e91-bd9b-107a56b5cb8a")) == null) {
				Columns.Add(CreateDocListInFinAppColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDocListInFinAppColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("059a625d-6f2a-4e91-bd9b-107a56b5cb8a"),
				Name = @"DocListInFinApp",
				ReferenceSchemaUId = new Guid("96616f6a-fb01-40c8-a8b6-83cd245ae45a"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("96b4922a-9305-4e91-83c5-91d9c430bda5"),
				ModifiedInSchemaUId = new Guid("96b4922a-9305-4e91-83c5-91d9c430bda5"),
				CreatedInPackageId = new Guid("3d232a98-bfd6-47ba-ba23-c8b76435d267")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocListInFinAppFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocListInFinAppFile_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocListInFinAppFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocListInFinAppFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96b4922a-9305-4e91-83c5-91d9c430bda5"));
		}

		#endregion

	}

	#endregion

	#region Class: DocListInFinAppFile

	/// <summary>
	/// Document list in application attachment.
	/// </summary>
	public class DocListInFinAppFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public DocListInFinAppFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocListInFinAppFile";
		}

		public DocListInFinAppFile(DocListInFinAppFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DocListInFinAppId {
			get {
				return GetTypedColumnValue<Guid>("DocListInFinAppId");
			}
			set {
				SetColumnValue("DocListInFinAppId", value);
				_docListInFinApp = null;
			}
		}

		/// <exclude/>
		public string DocListInFinAppName {
			get {
				return GetTypedColumnValue<string>("DocListInFinAppName");
			}
			set {
				SetColumnValue("DocListInFinAppName", value);
				if (_docListInFinApp != null) {
					_docListInFinApp.Name = value;
				}
			}
		}

		private DocListInFinApp _docListInFinApp;
		/// <summary>
		/// DocListInFinAppFile.
		/// </summary>
		public DocListInFinApp DocListInFinApp {
			get {
				return _docListInFinApp ??
					(_docListInFinApp = LookupColumnEntities.GetEntity("DocListInFinApp") as DocListInFinApp);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocListInFinAppFile_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocListInFinAppFileDeleted", e);
			Updated += (s, e) => ThrowEvent("DocListInFinAppFileUpdated", e);
			Validating += (s, e) => ThrowEvent("DocListInFinAppFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocListInFinAppFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocListInFinAppFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class DocListInFinAppFile_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.File_LinkPreviewEventsProcess<TEntity> where TEntity : DocListInFinAppFile
	{

		public DocListInFinAppFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocListInFinAppFile_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("96b4922a-9305-4e91-83c5-91d9c430bda5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("96b4922a-9305-4e91-83c5-91d9c430bda5");
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

	#region Class: DocListInFinAppFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class DocListInFinAppFile_CrtFinservApplicationEventsProcess : DocListInFinAppFile_CrtFinservApplicationEventsProcess<DocListInFinAppFile>
	{

		public DocListInFinAppFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocListInFinAppFile_CrtFinservApplicationEventsProcess

	public partial class DocListInFinAppFile_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocListInFinAppFileEventsProcess

	/// <exclude/>
	public class DocListInFinAppFileEventsProcess : DocListInFinAppFile_CrtFinservApplicationEventsProcess
	{

		public DocListInFinAppFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

