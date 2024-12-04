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

	#region Class: InterestPayOutPeriodSchema

	/// <exclude/>
	public class InterestPayOutPeriodSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public InterestPayOutPeriodSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InterestPayOutPeriodSchema(InterestPayOutPeriodSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InterestPayOutPeriodSchema(InterestPayOutPeriodSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bbcbc883-fbac-40ab-b6d7-71929dab7e19");
			RealUId = new Guid("bbcbc883-fbac-40ab-b6d7-71929dab7e19");
			Name = "InterestPayOutPeriod";
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
			return new InterestPayOutPeriod(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InterestPayOutPeriod_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InterestPayOutPeriodSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InterestPayOutPeriodSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bbcbc883-fbac-40ab-b6d7-71929dab7e19"));
		}

		#endregion

	}

	#endregion

	#region Class: InterestPayOutPeriod

	/// <summary>
	/// Interest payment period.
	/// </summary>
	public class InterestPayOutPeriod : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public InterestPayOutPeriod(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InterestPayOutPeriod";
		}

		public InterestPayOutPeriod(InterestPayOutPeriod source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InterestPayOutPeriod_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InterestPayOutPeriodDeleted", e);
			Validating += (s, e) => ThrowEvent("InterestPayOutPeriodValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InterestPayOutPeriod(this);
		}

		#endregion

	}

	#endregion

	#region Class: InterestPayOutPeriod_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class InterestPayOutPeriod_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : InterestPayOutPeriod
	{

		public InterestPayOutPeriod_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InterestPayOutPeriod_BankOnboardingEventsProcess";
			SchemaUId = new Guid("bbcbc883-fbac-40ab-b6d7-71929dab7e19");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bbcbc883-fbac-40ab-b6d7-71929dab7e19");
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

	#region Class: InterestPayOutPeriod_BankOnboardingEventsProcess

	/// <exclude/>
	public class InterestPayOutPeriod_BankOnboardingEventsProcess : InterestPayOutPeriod_BankOnboardingEventsProcess<InterestPayOutPeriod>
	{

		public InterestPayOutPeriod_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InterestPayOutPeriod_BankOnboardingEventsProcess

	public partial class InterestPayOutPeriod_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: InterestPayOutPeriodEventsProcess

	/// <exclude/>
	public class InterestPayOutPeriodEventsProcess : InterestPayOutPeriod_BankOnboardingEventsProcess
	{

		public InterestPayOutPeriodEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

