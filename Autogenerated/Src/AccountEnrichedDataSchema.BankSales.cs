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

	#region Class: AccountEnrichedData_BankSales_TerrasoftSchema

	/// <exclude/>
	public class AccountEnrichedData_BankSales_TerrasoftSchema : Terrasoft.Configuration.AccountEnrichedData_Lending_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountEnrichedData_BankSales_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountEnrichedData_BankSales_TerrasoftSchema(AccountEnrichedData_BankSales_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountEnrichedData_BankSales_TerrasoftSchema(AccountEnrichedData_BankSales_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("278bfdbf-d0fb-4738-bc98-b2446998bc44");
			Name = "AccountEnrichedData_BankSales_Terrasoft";
			ParentSchemaUId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1");
			ExtendParent = true;
			CreatedInPackageId = new Guid("186e89de-f146-47c3-a2d3-cacfd2c7fbd4");
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
			return new AccountEnrichedData_BankSales_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountEnrichedData_BankSalesEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountEnrichedData_BankSales_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountEnrichedData_BankSales_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("278bfdbf-d0fb-4738-bc98-b2446998bc44"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData_BankSales_Terrasoft

	/// <summary>
	/// Unprocessed enriched Legal entity data.
	/// </summary>
	public class AccountEnrichedData_BankSales_Terrasoft : Terrasoft.Configuration.AccountEnrichedData_Lending_Terrasoft
	{

		#region Constructors: Public

		public AccountEnrichedData_BankSales_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountEnrichedData_BankSales_Terrasoft";
		}

		public AccountEnrichedData_BankSales_Terrasoft(AccountEnrichedData_BankSales_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountEnrichedData_BankSalesEventsProcess(UserConnection);
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
			return new AccountEnrichedData_BankSales_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData_BankSalesEventsProcess

	/// <exclude/>
	public partial class AccountEnrichedData_BankSalesEventsProcess<TEntity> : Terrasoft.Configuration.AccountEnrichedData_LendingEventsProcess<TEntity> where TEntity : AccountEnrichedData_BankSales_Terrasoft
	{

		public AccountEnrichedData_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountEnrichedData_BankSalesEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("278bfdbf-d0fb-4738-bc98-b2446998bc44");
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

	#region Class: AccountEnrichedData_BankSalesEventsProcess

	/// <exclude/>
	public class AccountEnrichedData_BankSalesEventsProcess : AccountEnrichedData_BankSalesEventsProcess<AccountEnrichedData_BankSales_Terrasoft>
	{

		public AccountEnrichedData_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountEnrichedData_BankSalesEventsProcess

	public partial class AccountEnrichedData_BankSalesEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

