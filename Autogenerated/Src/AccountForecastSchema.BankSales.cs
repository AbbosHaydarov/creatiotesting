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

	#region Class: AccountForecastSchema

	/// <exclude/>
	public class AccountForecastSchema : Terrasoft.Configuration.AccountForecast_CoreForecast_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountForecastSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountForecastSchema(AccountForecastSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountForecastSchema(AccountForecastSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("20199bf6-c30b-460f-aa83-213923380acd");
			Name = "AccountForecast";
			ParentSchemaUId = new Guid("74900c50-b7e7-452a-83d9-f98707756d6c");
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
			return new AccountForecast(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountForecast_BankSalesEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountForecastSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountForecastSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20199bf6-c30b-460f-aa83-213923380acd"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountForecast

	/// <summary>
	/// Forecast by legal entity.
	/// </summary>
	public class AccountForecast : Terrasoft.Configuration.AccountForecast_CoreForecast_Terrasoft
	{

		#region Constructors: Public

		public AccountForecast(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountForecast";
		}

		public AccountForecast(AccountForecast source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountForecast_BankSalesEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("AccountForecastInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountForecast(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountForecast_BankSalesEventsProcess

	/// <exclude/>
	public partial class AccountForecast_BankSalesEventsProcess<TEntity> : Terrasoft.Configuration.AccountForecast_CoreForecastEventsProcess<TEntity> where TEntity : AccountForecast
	{

		public AccountForecast_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountForecast_BankSalesEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("20199bf6-c30b-460f-aa83-213923380acd");
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

	#region Class: AccountForecast_BankSalesEventsProcess

	/// <exclude/>
	public class AccountForecast_BankSalesEventsProcess : AccountForecast_BankSalesEventsProcess<AccountForecast>
	{

		public AccountForecast_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountForecast_BankSalesEventsProcess

	public partial class AccountForecast_BankSalesEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountForecastEventsProcess

	/// <exclude/>
	public class AccountForecastEventsProcess : AccountForecast_BankSalesEventsProcess
	{

		public AccountForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

