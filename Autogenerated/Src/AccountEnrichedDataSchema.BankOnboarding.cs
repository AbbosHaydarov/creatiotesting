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

	#region Class: AccountEnrichedDataSchema

	/// <exclude/>
	public class AccountEnrichedDataSchema : Terrasoft.Configuration.AccountEnrichedData_BankSales_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountEnrichedDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountEnrichedDataSchema(AccountEnrichedDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountEnrichedDataSchema(AccountEnrichedDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f65963fd-8f88-4af9-b2b2-58d08b441dbe");
			Name = "AccountEnrichedData";
			ParentSchemaUId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1");
			ExtendParent = true;
			CreatedInPackageId = new Guid("512e1c5a-41f4-4190-af57-2d99357b5a77");
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
			return new AccountEnrichedData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountEnrichedData_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountEnrichedDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountEnrichedDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f65963fd-8f88-4af9-b2b2-58d08b441dbe"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData

	/// <summary>
	/// Unprocessed enriched Legal entity data.
	/// </summary>
	public class AccountEnrichedData : Terrasoft.Configuration.AccountEnrichedData_BankSales_Terrasoft
	{

		#region Constructors: Public

		public AccountEnrichedData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountEnrichedData";
		}

		public AccountEnrichedData(AccountEnrichedData source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountEnrichedData_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountEnrichedData(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class AccountEnrichedData_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.AccountEnrichedData_BankSalesEventsProcess<TEntity> where TEntity : AccountEnrichedData
	{

		public AccountEnrichedData_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountEnrichedData_BankOnboardingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f65963fd-8f88-4af9-b2b2-58d08b441dbe");
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

	#region Class: AccountEnrichedData_BankOnboardingEventsProcess

	/// <exclude/>
	public class AccountEnrichedData_BankOnboardingEventsProcess : AccountEnrichedData_BankOnboardingEventsProcess<AccountEnrichedData>
	{

		public AccountEnrichedData_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountEnrichedData_BankOnboardingEventsProcess

	public partial class AccountEnrichedData_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountEnrichedDataEventsProcess

	/// <exclude/>
	public class AccountEnrichedDataEventsProcess : AccountEnrichedData_BankOnboardingEventsProcess
	{

		public AccountEnrichedDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

