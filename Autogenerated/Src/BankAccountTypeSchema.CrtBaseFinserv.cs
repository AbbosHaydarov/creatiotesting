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

	#region Class: BankAccountTypeSchema

	/// <exclude/>
	public class BankAccountTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BankAccountTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankAccountTypeSchema(BankAccountTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankAccountTypeSchema(BankAccountTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			RealUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			Name = "BankAccountType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
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
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			column.CreatedInPackageId = new Guid("35c1de78-8143-40fd-9efe-d40278f0f11f");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankAccountType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankAccountType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankAccountTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankAccountTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b"));
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountType

	/// <summary>
	/// Finance account type.
	/// </summary>
	public class BankAccountType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BankAccountType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankAccountType";
		}

		public BankAccountType(BankAccountType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankAccountType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankAccountTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("BankAccountTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankAccountType(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class BankAccountType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankAccountType
	{

		public BankAccountType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankAccountType_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("457ea78d-4754-44bf-92b9-6f6cbf57481b");
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

	#region Class: BankAccountType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class BankAccountType_CrtBaseFinservEventsProcess : BankAccountType_CrtBaseFinservEventsProcess<BankAccountType>
	{

		public BankAccountType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankAccountType_CrtBaseFinservEventsProcess

	public partial class BankAccountType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankAccountTypeEventsProcess

	/// <exclude/>
	public class BankAccountTypeEventsProcess : BankAccountType_CrtBaseFinservEventsProcess
	{

		public BankAccountTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

