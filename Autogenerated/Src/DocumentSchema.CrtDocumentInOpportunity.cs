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

	#region Class: Document_CrtDocumentInOpportunity_TerrasoftSchema

	/// <exclude/>
	public class Document_CrtDocumentInOpportunity_TerrasoftSchema : Terrasoft.Configuration.Document_Document_TerrasoftSchema
	{

		#region Constructors: Public

		public Document_CrtDocumentInOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_CrtDocumentInOpportunity_TerrasoftSchema(Document_CrtDocumentInOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_CrtDocumentInOpportunity_TerrasoftSchema(Document_CrtDocumentInOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2ab1b8dd-d9b4-4393-9994-00f5a9233a91");
			Name = "Document_CrtDocumentInOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6609fecb-0611-4043-b793-9364d39c2783");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d9e3320f-e365-4069-b345-3b3ec6adf04c")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("2ab1b8dd-d9b4-4393-9994-00f5a9233a91");
			column.CreatedInPackageId = new Guid("6609fecb-0611-4043-b793-9364d39c2783");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d9e3320f-e365-4069-b345-3b3ec6adf04c"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2ab1b8dd-d9b4-4393-9994-00f5a9233a91"),
				ModifiedInSchemaUId = new Guid("2ab1b8dd-d9b4-4393-9994-00f5a9233a91"),
				CreatedInPackageId = new Guid("6609fecb-0611-4043-b793-9364d39c2783")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Document_CrtDocumentInOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_CrtDocumentInOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_CrtDocumentInOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_CrtDocumentInOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ab1b8dd-d9b4-4393-9994-00f5a9233a91"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtDocumentInOpportunity_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_CrtDocumentInOpportunity_Terrasoft : Terrasoft.Configuration.Document_Document_Terrasoft
	{

		#region Constructors: Public

		public Document_CrtDocumentInOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_CrtDocumentInOpportunity_Terrasoft";
		}

		public Document_CrtDocumentInOpportunity_Terrasoft(Document_CrtDocumentInOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_CrtDocumentInOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Document_CrtDocumentInOpportunity_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Document_CrtDocumentInOpportunity_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("Document_CrtDocumentInOpportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Document_CrtDocumentInOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtDocumentInOpportunityEventsProcess

	/// <exclude/>
	public partial class Document_CrtDocumentInOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.Document_DocumentEventsProcess<TEntity> where TEntity : Document_CrtDocumentInOpportunity_Terrasoft
	{

		public Document_CrtDocumentInOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_CrtDocumentInOpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2ab1b8dd-d9b4-4393-9994-00f5a9233a91");
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

	#region Class: Document_CrtDocumentInOpportunityEventsProcess

	/// <exclude/>
	public class Document_CrtDocumentInOpportunityEventsProcess : Document_CrtDocumentInOpportunityEventsProcess<Document_CrtDocumentInOpportunity_Terrasoft>
	{

		public Document_CrtDocumentInOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Document_CrtDocumentInOpportunityEventsProcess

	public partial class Document_CrtDocumentInOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

