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

	#region Class: AccountAddress_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class AccountAddress_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.AccountAddress_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountAddress_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAddress_CrtBaseFinserv_TerrasoftSchema(AccountAddress_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAddress_CrtBaseFinserv_TerrasoftSchema(AccountAddress_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9922bca4-a21b-4e2c-9fff-7e345b1ef43a");
			Name = "AccountAddress_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9a909c9d-955a-4e10-b52b-fe1cb989996b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText");
			column.ModifiedInSchemaUId = new Guid("9922bca4-a21b-4e2c-9fff-7e345b1ef43a");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountAddress_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAddress_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAddress_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAddress_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9922bca4-a21b-4e2c-9fff-7e345b1ef43a"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Legal entity address.
	/// </summary>
	public class AccountAddress_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.AccountAddress_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public AccountAddress_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAddress_CrtBaseFinserv_Terrasoft";
		}

		public AccountAddress_CrtBaseFinserv_Terrasoft(AccountAddress_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAddress_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("AccountAddress_CrtBaseFinserv_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountAddress_CrtBaseFinserv_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAddress_CrtBaseFinserv_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAddress_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AccountAddress_CrtBaseFinserv_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AccountAddress_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAddress_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountAddress_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountAddress_CrtCustomer360AppEventsProcess<TEntity> where TEntity : AccountAddress_CrtBaseFinserv_Terrasoft
	{

		public AccountAddress_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAddress_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9922bca4-a21b-4e2c-9fff-7e345b1ef43a");
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

	#region Class: AccountAddress_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountAddress_CrtBaseFinservEventsProcess : AccountAddress_CrtBaseFinservEventsProcess<AccountAddress_CrtBaseFinserv_Terrasoft>
	{

		public AccountAddress_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

