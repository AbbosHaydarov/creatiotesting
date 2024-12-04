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

	#region Class: AccountEnrichedData_Lending_TerrasoftSchema

	/// <exclude/>
	public class AccountEnrichedData_Lending_TerrasoftSchema : Terrasoft.Configuration.AccountEnrichedData_Enrichment_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountEnrichedData_Lending_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountEnrichedData_Lending_TerrasoftSchema(AccountEnrichedData_Lending_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountEnrichedData_Lending_TerrasoftSchema(AccountEnrichedData_Lending_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("51b0ca8a-c4ca-4200-a45e-dc376b9699c1");
			Name = "AccountEnrichedData_Lending_Terrasoft";
			ParentSchemaUId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3eee31f6-6f18-4ff9-81f2-855902148ac8");
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
			return new AccountEnrichedData_Lending_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountEnrichedData_LendingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountEnrichedData_Lending_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountEnrichedData_Lending_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51b0ca8a-c4ca-4200-a45e-dc376b9699c1"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData_Lending_Terrasoft

	/// <summary>
	/// Unprocessed enriched Legal entity data.
	/// </summary>
	public class AccountEnrichedData_Lending_Terrasoft : Terrasoft.Configuration.AccountEnrichedData_Enrichment_Terrasoft
	{

		#region Constructors: Public

		public AccountEnrichedData_Lending_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountEnrichedData_Lending_Terrasoft";
		}

		public AccountEnrichedData_Lending_Terrasoft(AccountEnrichedData_Lending_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountEnrichedData_LendingEventsProcess(UserConnection);
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
			return new AccountEnrichedData_Lending_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData_LendingEventsProcess

	/// <exclude/>
	public partial class AccountEnrichedData_LendingEventsProcess<TEntity> : Terrasoft.Configuration.AccountEnrichedData_EnrichmentEventsProcess<TEntity> where TEntity : AccountEnrichedData_Lending_Terrasoft
	{

		public AccountEnrichedData_LendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountEnrichedData_LendingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("51b0ca8a-c4ca-4200-a45e-dc376b9699c1");
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

	#region Class: AccountEnrichedData_LendingEventsProcess

	/// <exclude/>
	public class AccountEnrichedData_LendingEventsProcess : AccountEnrichedData_LendingEventsProcess<AccountEnrichedData_Lending_Terrasoft>
	{

		public AccountEnrichedData_LendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountEnrichedData_LendingEventsProcess

	public partial class AccountEnrichedData_LendingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

