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

	#region Class: OpportunityInFolderSchema

	/// <exclude/>
	public class OpportunityInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public OpportunityInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityInFolderSchema(OpportunityInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityInFolderSchema(OpportunityInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970");
			RealUId = new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970");
			Name = "OpportunityInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("89b45049-07c2-41ac-999e-61bdb07f7725")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("ba431b60-ce67-4198-9281-6571b6920f70");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("89b45049-07c2-41ac-999e-61bdb07f7725"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970"),
				ModifiedInSchemaUId = new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityInFolder_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityInFolder

	/// <summary>
	/// Opportunity in folder.
	/// </summary>
	public class OpportunityInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public OpportunityInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityInFolder";
		}

		public OpportunityInFolder(OpportunityInFolder source)
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
			var process = new OpportunityInFolder_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityInFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityInFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityInFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityInFolderInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityInFolderSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityInFolderSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityInFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityInFolder_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityInFolder_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : OpportunityInFolder
	{

		public OpportunityInFolder_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityInFolder_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("57e5c814-e83b-4e79-a18c-adaa69a39970");
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

	#region Class: OpportunityInFolder_CrtOpportunityEventsProcess

	/// <exclude/>
	public class OpportunityInFolder_CrtOpportunityEventsProcess : OpportunityInFolder_CrtOpportunityEventsProcess<OpportunityInFolder>
	{

		public OpportunityInFolder_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityInFolder_CrtOpportunityEventsProcess

	public partial class OpportunityInFolder_CrtOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityInFolderEventsProcess

	/// <exclude/>
	public class OpportunityInFolderEventsProcess : OpportunityInFolder_CrtOpportunityEventsProcess
	{

		public OpportunityInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

