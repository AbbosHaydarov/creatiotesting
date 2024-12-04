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

	#region Class: MortgageKindSchema

	/// <exclude/>
	public class MortgageKindSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public MortgageKindSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MortgageKindSchema(MortgageKindSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MortgageKindSchema(MortgageKindSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90379e93-4431-4219-a330-46ec6ffb6f18");
			RealUId = new Guid("90379e93-4431-4219-a330-46ec6ffb6f18");
			Name = "MortgageKind";
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
			return new MortgageKind(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MortgageKind_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MortgageKindSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MortgageKindSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90379e93-4431-4219-a330-46ec6ffb6f18"));
		}

		#endregion

	}

	#endregion

	#region Class: MortgageKind

	/// <summary>
	/// Rank of a mortgage.
	/// </summary>
	public class MortgageKind : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public MortgageKind(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MortgageKind";
		}

		public MortgageKind(MortgageKind source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MortgageKind_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MortgageKindDeleted", e);
			Validating += (s, e) => ThrowEvent("MortgageKindValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MortgageKind(this);
		}

		#endregion

	}

	#endregion

	#region Class: MortgageKind_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class MortgageKind_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : MortgageKind
	{

		public MortgageKind_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MortgageKind_BankOnboardingEventsProcess";
			SchemaUId = new Guid("90379e93-4431-4219-a330-46ec6ffb6f18");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("90379e93-4431-4219-a330-46ec6ffb6f18");
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

	#region Class: MortgageKind_BankOnboardingEventsProcess

	/// <exclude/>
	public class MortgageKind_BankOnboardingEventsProcess : MortgageKind_BankOnboardingEventsProcess<MortgageKind>
	{

		public MortgageKind_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MortgageKind_BankOnboardingEventsProcess

	public partial class MortgageKind_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: MortgageKindEventsProcess

	/// <exclude/>
	public class MortgageKindEventsProcess : MortgageKind_BankOnboardingEventsProcess
	{

		public MortgageKindEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

