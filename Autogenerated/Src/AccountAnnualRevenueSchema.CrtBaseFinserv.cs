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

	#region Class: AccountAnnualRevenueSchema

	/// <exclude/>
	public class AccountAnnualRevenueSchema : Terrasoft.Configuration.AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountAnnualRevenueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAnnualRevenueSchema(AccountAnnualRevenueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAnnualRevenueSchema(AccountAnnualRevenueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("111dda6e-d96b-477b-97fa-e14a1c0525da");
			Name = "AccountAnnualRevenue";
			ParentSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			ExtendParent = true;
			CreatedInPackageId = new Guid("42c464a9-9677-4bbd-86c1-308caea3de84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
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
			return new AccountAnnualRevenue(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAnnualRevenue_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAnnualRevenueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAnnualRevenueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("111dda6e-d96b-477b-97fa-e14a1c0525da"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenue

	/// <summary>
	/// Annual revenue of legal entity.
	/// </summary>
	public class AccountAnnualRevenue : Terrasoft.Configuration.AccountAnnualRevenue_CrtCoreBase_Terrasoft
	{

		#region Constructors: Public

		public AccountAnnualRevenue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAnnualRevenue";
		}

		public AccountAnnualRevenue(AccountAnnualRevenue source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAnnualRevenue_CrtBaseFinservEventsProcess(UserConnection);
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
			return new AccountAnnualRevenue(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenue_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountAnnualRevenue_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountAnnualRevenue_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountAnnualRevenue
	{

		public AccountAnnualRevenue_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAnnualRevenue_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("111dda6e-d96b-477b-97fa-e14a1c0525da");
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

	#region Class: AccountAnnualRevenue_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountAnnualRevenue_CrtBaseFinservEventsProcess : AccountAnnualRevenue_CrtBaseFinservEventsProcess<AccountAnnualRevenue>
	{

		public AccountAnnualRevenue_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAnnualRevenue_CrtBaseFinservEventsProcess

	public partial class AccountAnnualRevenue_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountAnnualRevenueEventsProcess

	/// <exclude/>
	public class AccountAnnualRevenueEventsProcess : AccountAnnualRevenue_CrtBaseFinservEventsProcess
	{

		public AccountAnnualRevenueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

