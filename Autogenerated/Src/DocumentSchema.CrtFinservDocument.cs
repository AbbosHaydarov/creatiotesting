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

	#region Class: Document_CrtFinservDocument_TerrasoftSchema

	/// <exclude/>
	public class Document_CrtFinservDocument_TerrasoftSchema : Terrasoft.Configuration.Document_CrtContractDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public Document_CrtFinservDocument_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_CrtFinservDocument_TerrasoftSchema(Document_CrtFinservDocument_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_CrtFinservDocument_TerrasoftSchema(Document_CrtFinservDocument_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("532a51ae-33e1-4ae5-8a77-4e8c96756694");
			Name = "Document_CrtFinservDocument_Terrasoft";
			ParentSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fd194679-2815-45cf-a16d-e28de800abaf");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Sequence,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("532a51ae-33e1-4ae5-8a77-4e8c96756694");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Document_CrtFinservDocument_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_CrtFinservDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_CrtFinservDocument_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_CrtFinservDocument_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("532a51ae-33e1-4ae5-8a77-4e8c96756694"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtFinservDocument_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_CrtFinservDocument_Terrasoft : Terrasoft.Configuration.Document_CrtContractDocument_Terrasoft
	{

		#region Constructors: Public

		public Document_CrtFinservDocument_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_CrtFinservDocument_Terrasoft";
		}

		public Document_CrtFinservDocument_Terrasoft(Document_CrtFinservDocument_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_CrtFinservDocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("Document_CrtFinservDocument_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Document_CrtFinservDocument_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Document_CrtFinservDocument_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Document_CrtFinservDocument_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Document_CrtFinservDocument_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Document_CrtFinservDocument_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtFinservDocumentEventsProcess

	/// <exclude/>
	public partial class Document_CrtFinservDocumentEventsProcess<TEntity> : Terrasoft.Configuration.Document_CrtContractDocumentEventsProcess<TEntity> where TEntity : Document_CrtFinservDocument_Terrasoft
	{

		public Document_CrtFinservDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_CrtFinservDocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("532a51ae-33e1-4ae5-8a77-4e8c96756694");
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

	#region Class: Document_CrtFinservDocumentEventsProcess

	/// <exclude/>
	public class Document_CrtFinservDocumentEventsProcess : Document_CrtFinservDocumentEventsProcess<Document_CrtFinservDocument_Terrasoft>
	{

		public Document_CrtFinservDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Document_CrtFinservDocumentEventsProcess

	public partial class Document_CrtFinservDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

