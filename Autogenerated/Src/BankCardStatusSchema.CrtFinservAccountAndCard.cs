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

	#region Class: BankCardStatusSchema

	/// <exclude/>
	public class BankCardStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BankCardStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardStatusSchema(BankCardStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardStatusSchema(BankCardStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			RealUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			Name = "BankCardStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
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
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankCardStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardStatus_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardStatus

	/// <summary>
	/// Card status.
	/// </summary>
	public class BankCardStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BankCardStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardStatus";
		}

		public BankCardStatus(BankCardStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardStatus_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardStatusDeleted", e);
			Validating += (s, e) => ThrowEvent("BankCardStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardStatus_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardStatus_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankCardStatus
	{

		public BankCardStatus_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardStatus_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9");
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

	#region Class: BankCardStatus_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardStatus_CrtFinservAccountAndCardEventsProcess : BankCardStatus_CrtFinservAccountAndCardEventsProcess<BankCardStatus>
	{

		public BankCardStatus_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardStatus_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardStatus_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardStatusEventsProcess

	/// <exclude/>
	public class BankCardStatusEventsProcess : BankCardStatus_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

