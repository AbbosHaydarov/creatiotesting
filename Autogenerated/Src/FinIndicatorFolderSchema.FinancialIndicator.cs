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

	#region Class: FinIndicatorFolderSchema

	/// <exclude/>
	public class FinIndicatorFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public FinIndicatorFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinIndicatorFolderSchema(FinIndicatorFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinIndicatorFolderSchema(FinIndicatorFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			RealUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			Name = "FinIndicatorFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateSearchDataColumn() {
			EntitySchemaColumn column = base.CreateSearchDataColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinIndicatorFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinIndicatorFolder_FinancialIndicatorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinIndicatorFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinIndicatorFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff"));
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorFolder

	/// <summary>
	/// Section folder - Financial indicators.
	/// </summary>
	public class FinIndicatorFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public FinIndicatorFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinIndicatorFolder";
		}

		public FinIndicatorFolder(FinIndicatorFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private FinIndicatorFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public FinIndicatorFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as FinIndicatorFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinIndicatorFolder_FinancialIndicatorEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinIndicatorFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorFolder_FinancialIndicatorEventsProcess

	/// <exclude/>
	public partial class FinIndicatorFolder_FinancialIndicatorEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinIndicatorFolder
	{

		public FinIndicatorFolder_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinIndicatorFolder_FinancialIndicatorEventsProcess";
			SchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
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

	#region Class: FinIndicatorFolder_FinancialIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicatorFolder_FinancialIndicatorEventsProcess : FinIndicatorFolder_FinancialIndicatorEventsProcess<FinIndicatorFolder>
	{

		public FinIndicatorFolder_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinIndicatorFolder_FinancialIndicatorEventsProcess

	public partial class FinIndicatorFolder_FinancialIndicatorEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion


	#region Class: FinIndicatorFolderEventsProcess

	/// <exclude/>
	public class FinIndicatorFolderEventsProcess : FinIndicatorFolder_FinancialIndicatorEventsProcess
	{

		public FinIndicatorFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

