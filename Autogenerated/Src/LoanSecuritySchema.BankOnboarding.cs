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

	#region Class: LoanSecuritySchema

	/// <exclude/>
	public class LoanSecuritySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LoanSecuritySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LoanSecuritySchema(LoanSecuritySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LoanSecuritySchema(LoanSecuritySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2748058-37f1-442b-b84b-5b04d65e021f");
			RealUId = new Guid("a2748058-37f1-442b-b84b-5b04d65e021f");
			Name = "LoanSecurity";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("18490550-2ef7-4eba-bc96-898c1b71e400");
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
			return new LoanSecurity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LoanSecurity_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LoanSecuritySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LoanSecuritySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2748058-37f1-442b-b84b-5b04d65e021f"));
		}

		#endregion

	}

	#endregion

	#region Class: LoanSecurity

	/// <summary>
	/// Provision for loan.
	/// </summary>
	public class LoanSecurity : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LoanSecurity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LoanSecurity";
		}

		public LoanSecurity(LoanSecurity source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LoanSecurity_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LoanSecurityDeleted", e);
			Validating += (s, e) => ThrowEvent("LoanSecurityValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LoanSecurity(this);
		}

		#endregion

	}

	#endregion

	#region Class: LoanSecurity_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class LoanSecurity_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : LoanSecurity
	{

		public LoanSecurity_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoanSecurity_BankOnboardingEventsProcess";
			SchemaUId = new Guid("a2748058-37f1-442b-b84b-5b04d65e021f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a2748058-37f1-442b-b84b-5b04d65e021f");
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

	#region Class: LoanSecurity_BankOnboardingEventsProcess

	/// <exclude/>
	public class LoanSecurity_BankOnboardingEventsProcess : LoanSecurity_BankOnboardingEventsProcess<LoanSecurity>
	{

		public LoanSecurity_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LoanSecurity_BankOnboardingEventsProcess

	public partial class LoanSecurity_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: LoanSecurityEventsProcess

	/// <exclude/>
	public class LoanSecurityEventsProcess : LoanSecurity_BankOnboardingEventsProcess
	{

		public LoanSecurityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

