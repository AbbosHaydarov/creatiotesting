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

	#region Class: RegDocument_CrtFinservDocument_TerrasoftSchema

	/// <exclude/>
	public class RegDocument_CrtFinservDocument_TerrasoftSchema : Terrasoft.Configuration.RegDocument_CrtBaseFinserv_TerrasoftSchema
	{

		#region Constructors: Public

		public RegDocument_CrtFinservDocument_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RegDocument_CrtFinservDocument_TerrasoftSchema(RegDocument_CrtFinservDocument_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RegDocument_CrtFinservDocument_TerrasoftSchema(RegDocument_CrtFinservDocument_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("88b4b951-84af-4b66-9b88-5f31dc53f02b");
			Name = "RegDocument_CrtFinservDocument_Terrasoft";
			ParentSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ed5d5276-d8c1-4b95-8662-491540f16566");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8d14ac4e-b297-447c-9bae-3c9051a228f2")) == null) {
				Columns.Add(CreateDocumentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDocumentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8d14ac4e-b297-447c-9bae-3c9051a228f2"),
				Name = @"Document",
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("88b4b951-84af-4b66-9b88-5f31dc53f02b"),
				ModifiedInSchemaUId = new Guid("88b4b951-84af-4b66-9b88-5f31dc53f02b"),
				CreatedInPackageId = new Guid("ed5d5276-d8c1-4b95-8662-491540f16566")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RegDocument_CrtFinservDocument_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RegDocument_CrtFinservDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RegDocument_CrtFinservDocument_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RegDocument_CrtFinservDocument_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88b4b951-84af-4b66-9b88-5f31dc53f02b"));
		}

		#endregion

	}

	#endregion

	#region Class: RegDocument_CrtFinservDocument_Terrasoft

	/// <summary>
	/// Registration document.
	/// </summary>
	public class RegDocument_CrtFinservDocument_Terrasoft : Terrasoft.Configuration.RegDocument_CrtBaseFinserv_Terrasoft
	{

		#region Constructors: Public

		public RegDocument_CrtFinservDocument_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RegDocument_CrtFinservDocument_Terrasoft";
		}

		public RegDocument_CrtFinservDocument_Terrasoft(RegDocument_CrtFinservDocument_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DocumentId {
			get {
				return GetTypedColumnValue<Guid>("DocumentId");
			}
			set {
				SetColumnValue("DocumentId", value);
				_document = null;
			}
		}

		/// <exclude/>
		public string DocumentNumber {
			get {
				return GetTypedColumnValue<string>("DocumentNumber");
			}
			set {
				SetColumnValue("DocumentNumber", value);
				if (_document != null) {
					_document.Number = value;
				}
			}
		}

		private Document _document;
		/// <summary>
		/// Document link.
		/// </summary>
		public Document Document {
			get {
				return _document ??
					(_document = LookupColumnEntities.GetEntity("Document") as Document);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RegDocument_CrtFinservDocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("RegDocument_CrtFinservDocument_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("RegDocument_CrtFinservDocument_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("RegDocument_CrtFinservDocument_TerrasoftInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RegDocument_CrtFinservDocument_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: RegDocument_CrtFinservDocumentEventsProcess

	/// <exclude/>
	public partial class RegDocument_CrtFinservDocumentEventsProcess<TEntity> : Terrasoft.Configuration.RegDocument_CrtBaseFinservEventsProcess<TEntity> where TEntity : RegDocument_CrtFinservDocument_Terrasoft
	{

		public RegDocument_CrtFinservDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RegDocument_CrtFinservDocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("88b4b951-84af-4b66-9b88-5f31dc53f02b");
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

	#region Class: RegDocument_CrtFinservDocumentEventsProcess

	/// <exclude/>
	public class RegDocument_CrtFinservDocumentEventsProcess : RegDocument_CrtFinservDocumentEventsProcess<RegDocument_CrtFinservDocument_Terrasoft>
	{

		public RegDocument_CrtFinservDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RegDocument_CrtFinservDocumentEventsProcess

	public partial class RegDocument_CrtFinservDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

