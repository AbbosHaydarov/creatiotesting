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

	#region Class: FinIndicatorTypeSchema

	/// <exclude/>
	public class FinIndicatorTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public FinIndicatorTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinIndicatorTypeSchema(FinIndicatorTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinIndicatorTypeSchema(FinIndicatorTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			RealUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			Name = "FinIndicatorType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
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
			return new FinIndicatorType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinIndicatorType_FinancialIndicatorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinIndicatorTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinIndicatorTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787"));
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorType

	/// <summary>
	/// Indicator type.
	/// </summary>
	public class FinIndicatorType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public FinIndicatorType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinIndicatorType";
		}

		public FinIndicatorType(FinIndicatorType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinIndicatorType_FinancialIndicatorEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinIndicatorTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("FinIndicatorTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinIndicatorType(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorType_FinancialIndicatorEventsProcess

	/// <exclude/>
	public partial class FinIndicatorType_FinancialIndicatorEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinIndicatorType
	{

		public FinIndicatorType_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinIndicatorType_FinancialIndicatorEventsProcess";
			SchemaUId = new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5b8b89f3-d321-4456-bf03-5db9349cc787");
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

	#region Class: FinIndicatorType_FinancialIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicatorType_FinancialIndicatorEventsProcess : FinIndicatorType_FinancialIndicatorEventsProcess<FinIndicatorType>
	{

		public FinIndicatorType_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinIndicatorType_FinancialIndicatorEventsProcess

	public partial class FinIndicatorType_FinancialIndicatorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinIndicatorTypeEventsProcess

	/// <exclude/>
	public class FinIndicatorTypeEventsProcess : FinIndicatorType_FinancialIndicatorEventsProcess
	{

		public FinIndicatorTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

