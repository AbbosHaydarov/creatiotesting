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

	#region Class: BankAccountCloseReasonSchema

	/// <exclude/>
	public class BankAccountCloseReasonSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BankAccountCloseReasonSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankAccountCloseReasonSchema(BankAccountCloseReasonSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankAccountCloseReasonSchema(BankAccountCloseReasonSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			RealUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			Name = "BankAccountCloseReason";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			column.CreatedInPackageId = new Guid("e40960d2-171c-4660-bc1d-72804d3e5ecd");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankAccountCloseReason(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankAccountCloseReasonSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankAccountCloseReasonSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39"));
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountCloseReason

	/// <summary>
	/// Reason for financial account closing.
	/// </summary>
	public class BankAccountCloseReason : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BankAccountCloseReason(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankAccountCloseReason";
		}

		public BankAccountCloseReason(BankAccountCloseReason source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankAccountCloseReasonDeleted", e);
			Validating += (s, e) => ThrowEvent("BankAccountCloseReasonValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankAccountCloseReason(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankAccountCloseReason
	{

		public BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("344ea0af-d623-4876-9f1c-9135e90a5e39");
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

	#region Class: BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess : BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess<BankAccountCloseReason>
	{

		public BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess

	public partial class BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankAccountCloseReasonEventsProcess

	/// <exclude/>
	public class BankAccountCloseReasonEventsProcess : BankAccountCloseReason_CrtFinservAccountAndCardEventsProcess
	{

		public BankAccountCloseReasonEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

