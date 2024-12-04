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

	#region Class: FinIndicatorInFolderSchema

	/// <exclude/>
	public class FinIndicatorInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public FinIndicatorInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinIndicatorInFolderSchema(FinIndicatorInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinIndicatorInFolderSchema(FinIndicatorInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			RealUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			Name = "FinIndicatorInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e8ebf16b-b9c4-471c-90d6-0d764c0fcb93")) == null) {
				Columns.Add(CreateFinIndicatorColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("af52b29b-ffa3-4366-90b0-252d6c90bbff");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinIndicatorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e8ebf16b-b9c4-471c-90d6-0d764c0fcb93"),
				Name = @"FinIndicator",
				ReferenceSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56"),
				ModifiedInSchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56"),
				CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinIndicatorInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinIndicatorInFolder_FinancialIndicatorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinIndicatorInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinIndicatorInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56"));
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorInFolder

	/// <summary>
	/// Object in folder - Financial indicators.
	/// </summary>
	public class FinIndicatorInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public FinIndicatorInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinIndicatorInFolder";
		}

		public FinIndicatorInFolder(FinIndicatorInFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid FinIndicatorId {
			get {
				return GetTypedColumnValue<Guid>("FinIndicatorId");
			}
			set {
				SetColumnValue("FinIndicatorId", value);
				_finIndicator = null;
			}
		}

		/// <exclude/>
		public string FinIndicatorName {
			get {
				return GetTypedColumnValue<string>("FinIndicatorName");
			}
			set {
				SetColumnValue("FinIndicatorName", value);
				if (_finIndicator != null) {
					_finIndicator.Name = value;
				}
			}
		}

		private FinIndicator _finIndicator;
		/// <summary>
		/// Financial indicators.
		/// </summary>
		public FinIndicator FinIndicator {
			get {
				return _finIndicator ??
					(_finIndicator = LookupColumnEntities.GetEntity("FinIndicator") as FinIndicator);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinIndicatorInFolder_FinancialIndicatorEventsProcess(UserConnection);
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
			return new FinIndicatorInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorInFolder_FinancialIndicatorEventsProcess

	/// <exclude/>
	public partial class FinIndicatorInFolder_FinancialIndicatorEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinIndicatorInFolder
	{

		public FinIndicatorInFolder_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinIndicatorInFolder_FinancialIndicatorEventsProcess";
			SchemaUId = new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b82b210c-4c4a-4cf7-b2f0-5dd55425fe56");
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

	#region Class: FinIndicatorInFolder_FinancialIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicatorInFolder_FinancialIndicatorEventsProcess : FinIndicatorInFolder_FinancialIndicatorEventsProcess<FinIndicatorInFolder>
	{

		public FinIndicatorInFolder_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinIndicatorInFolder_FinancialIndicatorEventsProcess

	public partial class FinIndicatorInFolder_FinancialIndicatorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinIndicatorInFolderEventsProcess

	/// <exclude/>
	public class FinIndicatorInFolderEventsProcess : FinIndicatorInFolder_FinancialIndicatorEventsProcess
	{

		public FinIndicatorInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

