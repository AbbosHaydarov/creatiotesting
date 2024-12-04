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

	#region Class: Document_CrtFinservApplication_TerrasoftSchema

	/// <exclude/>
	public class Document_CrtFinservApplication_TerrasoftSchema : Terrasoft.Configuration.Document_CrtDocumentInOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public Document_CrtFinservApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_CrtFinservApplication_TerrasoftSchema(Document_CrtFinservApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_CrtFinservApplication_TerrasoftSchema(Document_CrtFinservApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("12b47aa0-791d-4d0e-9ddc-4020610b25e7");
			Name = "Document_CrtFinservApplication_Terrasoft";
			ParentSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1024b650-9de3-46b9-8b7f-d9a818df77fc")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("12b47aa0-791d-4d0e-9ddc-4020610b25e7");
			column.CreatedInPackageId = new Guid("6609fecb-0611-4043-b793-9364d39c2783");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1024b650-9de3-46b9-8b7f-d9a818df77fc"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("12b47aa0-791d-4d0e-9ddc-4020610b25e7"),
				ModifiedInSchemaUId = new Guid("12b47aa0-791d-4d0e-9ddc-4020610b25e7"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Document_CrtFinservApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_CrtFinservApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_CrtFinservApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12b47aa0-791d-4d0e-9ddc-4020610b25e7"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtFinservApplication_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_CrtFinservApplication_Terrasoft : Terrasoft.Configuration.Document_CrtDocumentInOpportunity_Terrasoft
	{

		#region Constructors: Public

		public Document_CrtFinservApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_CrtFinservApplication_Terrasoft";
		}

		public Document_CrtFinservApplication_Terrasoft(Document_CrtFinservApplication_Terrasoft source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Document_CrtFinservApplication_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("Document_CrtFinservApplication_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Document_CrtFinservApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class Document_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.Document_CrtDocumentInOpportunityEventsProcess<TEntity> where TEntity : Document_CrtFinservApplication_Terrasoft
	{

		public Document_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_CrtFinservApplicationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("12b47aa0-791d-4d0e-9ddc-4020610b25e7");
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

	#region Class: Document_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class Document_CrtFinservApplicationEventsProcess : Document_CrtFinservApplicationEventsProcess<Document_CrtFinservApplication_Terrasoft>
	{

		public Document_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Document_CrtFinservApplicationEventsProcess

	public partial class Document_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

