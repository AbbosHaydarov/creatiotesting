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

	#region Class: InterestPeriodSchema

	/// <exclude/>
	public class InterestPeriodSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public InterestPeriodSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InterestPeriodSchema(InterestPeriodSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InterestPeriodSchema(InterestPeriodSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d1f81bcb-ec08-4452-bf94-188116146d26");
			RealUId = new Guid("d1f81bcb-ec08-4452-bf94-188116146d26");
			Name = "InterestPeriod";
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
			return new InterestPeriod(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InterestPeriod_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InterestPeriodSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InterestPeriodSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d1f81bcb-ec08-4452-bf94-188116146d26"));
		}

		#endregion

	}

	#endregion

	#region Class: InterestPeriod

	/// <summary>
	/// Interest period.
	/// </summary>
	public class InterestPeriod : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public InterestPeriod(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InterestPeriod";
		}

		public InterestPeriod(InterestPeriod source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InterestPeriod_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InterestPeriodDeleted", e);
			Validating += (s, e) => ThrowEvent("InterestPeriodValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InterestPeriod(this);
		}

		#endregion

	}

	#endregion

	#region Class: InterestPeriod_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class InterestPeriod_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : InterestPeriod
	{

		public InterestPeriod_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InterestPeriod_BankOnboardingEventsProcess";
			SchemaUId = new Guid("d1f81bcb-ec08-4452-bf94-188116146d26");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d1f81bcb-ec08-4452-bf94-188116146d26");
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

	#region Class: InterestPeriod_BankOnboardingEventsProcess

	/// <exclude/>
	public class InterestPeriod_BankOnboardingEventsProcess : InterestPeriod_BankOnboardingEventsProcess<InterestPeriod>
	{

		public InterestPeriod_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InterestPeriod_BankOnboardingEventsProcess

	public partial class InterestPeriod_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: InterestPeriodEventsProcess

	/// <exclude/>
	public class InterestPeriodEventsProcess : InterestPeriod_BankOnboardingEventsProcess
	{

		public InterestPeriodEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

