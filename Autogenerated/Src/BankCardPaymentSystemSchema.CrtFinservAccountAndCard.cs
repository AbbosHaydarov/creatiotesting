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

	#region Class: BankCardPaymentSystemSchema

	/// <exclude/>
	public class BankCardPaymentSystemSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BankCardPaymentSystemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardPaymentSystemSchema(BankCardPaymentSystemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardPaymentSystemSchema(BankCardPaymentSystemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			RealUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			Name = "BankCardPaymentSystem";
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
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
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
			return new BankCardPaymentSystem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardPaymentSystemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardPaymentSystemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fca59039-a1ac-4f36-a2be-009b7182c824"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardPaymentSystem

	/// <summary>
	/// Payment system.
	/// </summary>
	public class BankCardPaymentSystem : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BankCardPaymentSystem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardPaymentSystem";
		}

		public BankCardPaymentSystem(BankCardPaymentSystem source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardPaymentSystemDeleted", e);
			Validating += (s, e) => ThrowEvent("BankCardPaymentSystemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardPaymentSystem(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankCardPaymentSystem
	{

		public BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fca59039-a1ac-4f36-a2be-009b7182c824");
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

	#region Class: BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess : BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess<BankCardPaymentSystem>
	{

		public BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardPaymentSystemEventsProcess

	/// <exclude/>
	public class BankCardPaymentSystemEventsProcess : BankCardPaymentSystem_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardPaymentSystemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

