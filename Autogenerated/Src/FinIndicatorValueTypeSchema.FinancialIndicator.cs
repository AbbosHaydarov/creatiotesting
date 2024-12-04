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

	#region Class: FinIndicatorValueTypeSchema

	/// <exclude/>
	public class FinIndicatorValueTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public FinIndicatorValueTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinIndicatorValueTypeSchema(FinIndicatorValueTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinIndicatorValueTypeSchema(FinIndicatorValueTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			RealUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			Name = "FinIndicatorValueType";
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
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			column.CreatedInPackageId = new Guid("564ee07f-4758-4604-a5fc-57985d7c39cd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
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
			return new FinIndicatorValueType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinIndicatorValueType_FinancialIndicatorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinIndicatorValueTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinIndicatorValueTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b"));
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorValueType

	/// <summary>
	/// Value type.
	/// </summary>
	public class FinIndicatorValueType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public FinIndicatorValueType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinIndicatorValueType";
		}

		public FinIndicatorValueType(FinIndicatorValueType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinIndicatorValueType_FinancialIndicatorEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinIndicatorValueTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("FinIndicatorValueTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinIndicatorValueType(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorValueType_FinancialIndicatorEventsProcess

	/// <exclude/>
	public partial class FinIndicatorValueType_FinancialIndicatorEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinIndicatorValueType
	{

		public FinIndicatorValueType_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinIndicatorValueType_FinancialIndicatorEventsProcess";
			SchemaUId = new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("863610fb-c455-4ada-8af2-d8b2269cf58b");
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

	#region Class: FinIndicatorValueType_FinancialIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicatorValueType_FinancialIndicatorEventsProcess : FinIndicatorValueType_FinancialIndicatorEventsProcess<FinIndicatorValueType>
	{

		public FinIndicatorValueType_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinIndicatorValueType_FinancialIndicatorEventsProcess

	public partial class FinIndicatorValueType_FinancialIndicatorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinIndicatorValueTypeEventsProcess

	/// <exclude/>
	public class FinIndicatorValueTypeEventsProcess : FinIndicatorValueType_FinancialIndicatorEventsProcess
	{

		public FinIndicatorValueTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

