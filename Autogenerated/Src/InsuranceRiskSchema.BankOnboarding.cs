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

	#region Class: InsuranceRiskSchema

	/// <exclude/>
	public class InsuranceRiskSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public InsuranceRiskSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InsuranceRiskSchema(InsuranceRiskSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InsuranceRiskSchema(InsuranceRiskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("370df5f9-9ccd-482a-97d2-551fb83d3c68");
			RealUId = new Guid("370df5f9-9ccd-482a-97d2-551fb83d3c68");
			Name = "InsuranceRisk";
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
			return new InsuranceRisk(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InsuranceRisk_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InsuranceRiskSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InsuranceRiskSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("370df5f9-9ccd-482a-97d2-551fb83d3c68"));
		}

		#endregion

	}

	#endregion

	#region Class: InsuranceRisk

	/// <summary>
	/// Insurance risk.
	/// </summary>
	public class InsuranceRisk : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public InsuranceRisk(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InsuranceRisk";
		}

		public InsuranceRisk(InsuranceRisk source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InsuranceRisk_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InsuranceRiskDeleted", e);
			Validating += (s, e) => ThrowEvent("InsuranceRiskValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InsuranceRisk(this);
		}

		#endregion

	}

	#endregion

	#region Class: InsuranceRisk_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class InsuranceRisk_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : InsuranceRisk
	{

		public InsuranceRisk_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InsuranceRisk_BankOnboardingEventsProcess";
			SchemaUId = new Guid("370df5f9-9ccd-482a-97d2-551fb83d3c68");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("370df5f9-9ccd-482a-97d2-551fb83d3c68");
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

	#region Class: InsuranceRisk_BankOnboardingEventsProcess

	/// <exclude/>
	public class InsuranceRisk_BankOnboardingEventsProcess : InsuranceRisk_BankOnboardingEventsProcess<InsuranceRisk>
	{

		public InsuranceRisk_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InsuranceRisk_BankOnboardingEventsProcess

	public partial class InsuranceRisk_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: InsuranceRiskEventsProcess

	/// <exclude/>
	public class InsuranceRiskEventsProcess : InsuranceRisk_BankOnboardingEventsProcess
	{

		public InsuranceRiskEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

