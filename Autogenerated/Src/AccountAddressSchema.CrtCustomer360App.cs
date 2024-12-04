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

	#region Class: AccountAddress_CrtCustomer360App_TerrasoftSchema

	/// <exclude/>
	public class AccountAddress_CrtCustomer360App_TerrasoftSchema : Terrasoft.Configuration.AccountAddress_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountAddress_CrtCustomer360App_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAddress_CrtCustomer360App_TerrasoftSchema(AccountAddress_CrtCustomer360App_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAddress_CrtCustomer360App_TerrasoftSchema(AccountAddress_CrtCustomer360App_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("95628945-7e2b-4726-8edb-b1232f03e3e1");
			Name = "AccountAddress_CrtCustomer360App_Terrasoft";
			ParentSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9a909c9d-955a-4e10-b52b-fe1cb989996b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateAddressColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("LongText");
			column.ModifiedInSchemaUId = new Guid("95628945-7e2b-4726-8edb-b1232f03e3e1");
			column.CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountAddress_CrtCustomer360App_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAddress_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAddress_CrtCustomer360App_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAddress_CrtCustomer360App_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95628945-7e2b-4726-8edb-b1232f03e3e1"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress_CrtCustomer360App_Terrasoft

	/// <summary>
	/// Legal entity address.
	/// </summary>
	public class AccountAddress_CrtCustomer360App_Terrasoft : Terrasoft.Configuration.AccountAddress_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountAddress_CrtCustomer360App_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAddress_CrtCustomer360App_Terrasoft";
		}

		public AccountAddress_CrtCustomer360App_Terrasoft(AccountAddress_CrtCustomer360App_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAddress_CrtCustomer360AppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAddress_CrtCustomer360App_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountAddress_CrtCustomer360App_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountAddress_CrtCustomer360App_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAddress_CrtCustomer360App_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAddress_CrtCustomer360App_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AccountAddress_CrtCustomer360App_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AccountAddress_CrtCustomer360App_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAddress_CrtCustomer360App_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class AccountAddress_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.AccountAddress_CrtBaseEventsProcess<TEntity> where TEntity : AccountAddress_CrtCustomer360App_Terrasoft
	{

		public AccountAddress_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAddress_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("95628945-7e2b-4726-8edb-b1232f03e3e1");
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

	#region Class: AccountAddress_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class AccountAddress_CrtCustomer360AppEventsProcess : AccountAddress_CrtCustomer360AppEventsProcess<AccountAddress_CrtCustomer360App_Terrasoft>
	{

		public AccountAddress_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAddress_CrtCustomer360AppEventsProcess

	public partial class AccountAddress_CrtCustomer360AppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

