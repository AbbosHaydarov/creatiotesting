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

	#region Class: AccountAddressSchema

	/// <exclude/>
	public class AccountAddressSchema : Terrasoft.Configuration.AccountAddress_CrtBaseFinserv_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountAddressSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAddressSchema(AccountAddressSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAddressSchema(AccountAddressSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("321aa740-eca7-431c-a45e-e80aa67060cf");
			Name = "AccountAddress";
			ParentSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9a909c9d-955a-4e10-b52b-fe1cb989996b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new AccountAddress(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAddress_AddressFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAddressSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAddressSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("321aa740-eca7-431c-a45e-e80aa67060cf"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress

	/// <summary>
	/// Legal entity address.
	/// </summary>
	public class AccountAddress : Terrasoft.Configuration.AccountAddress_CrtBaseFinserv_Terrasoft
	{

		#region Constructors: Public

		public AccountAddress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAddress";
		}

		public AccountAddress(AccountAddress source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAddress_AddressFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAddressDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountAddressDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountAddressInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAddressInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAddressSaved", e);
			Saving += (s, e) => ThrowEvent("AccountAddressSaving", e);
			Validating += (s, e) => ThrowEvent("AccountAddressValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAddress(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress_AddressFinanceEventsProcess

	/// <exclude/>
	public partial class AccountAddress_AddressFinanceEventsProcess<TEntity> : Terrasoft.Configuration.AccountAddress_CrtBaseFinservEventsProcess<TEntity> where TEntity : AccountAddress
	{

		public AccountAddress_AddressFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAddress_AddressFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("321aa740-eca7-431c-a45e-e80aa67060cf");
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

	#region Class: AccountAddress_AddressFinanceEventsProcess

	/// <exclude/>
	public class AccountAddress_AddressFinanceEventsProcess : AccountAddress_AddressFinanceEventsProcess<AccountAddress>
	{

		public AccountAddress_AddressFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: AccountAddressEventsProcess

	/// <exclude/>
	public class AccountAddressEventsProcess : AccountAddress_AddressFinanceEventsProcess
	{

		public AccountAddressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

