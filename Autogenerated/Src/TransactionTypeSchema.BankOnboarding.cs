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

	#region Class: TransactionTypeSchema

	/// <exclude/>
	public class TransactionTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public TransactionTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TransactionTypeSchema(TransactionTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TransactionTypeSchema(TransactionTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3aaf703d-4c78-4eed-9c7a-125b5f29aebb");
			RealUId = new Guid("3aaf703d-4c78-4eed-9c7a-125b5f29aebb");
			Name = "TransactionType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f06c7ce5-55b1-4dc3-b481-e1b0a2ceaa62");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new TransactionType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TransactionType_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TransactionTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TransactionTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3aaf703d-4c78-4eed-9c7a-125b5f29aebb"));
		}

		#endregion

	}

	#endregion

	#region Class: TransactionType

	/// <summary>
	/// Transfer method.
	/// </summary>
	public class TransactionType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public TransactionType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TransactionType";
		}

		public TransactionType(TransactionType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TransactionType_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("TransactionTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("TransactionTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new TransactionType(this);
		}

		#endregion

	}

	#endregion

	#region Class: TransactionType_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class TransactionType_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : TransactionType
	{

		public TransactionType_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TransactionType_BankOnboardingEventsProcess";
			SchemaUId = new Guid("3aaf703d-4c78-4eed-9c7a-125b5f29aebb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3aaf703d-4c78-4eed-9c7a-125b5f29aebb");
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

	#region Class: TransactionType_BankOnboardingEventsProcess

	/// <exclude/>
	public class TransactionType_BankOnboardingEventsProcess : TransactionType_BankOnboardingEventsProcess<TransactionType>
	{

		public TransactionType_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TransactionType_BankOnboardingEventsProcess

	public partial class TransactionType_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: TransactionTypeEventsProcess

	/// <exclude/>
	public class TransactionTypeEventsProcess : TransactionType_BankOnboardingEventsProcess
	{

		public TransactionTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

