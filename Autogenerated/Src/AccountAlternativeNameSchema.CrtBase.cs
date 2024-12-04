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

	#region Class: AccountAlternativeName_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class AccountAlternativeName_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AccountAlternativeName_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAlternativeName_CrtBase_TerrasoftSchema(AccountAlternativeName_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAlternativeName_CrtBase_TerrasoftSchema(AccountAlternativeName_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56");
			RealUId = new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56");
			Name = "AccountAlternativeName_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5eb0abd5-fa4c-4130-b358-feb9920ab054")) == null) {
				Columns.Add(CreateAccountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5eb0abd5-fa4c-4130-b358-feb9920ab054"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56"),
				ModifiedInSchemaUId = new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountAlternativeName_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAlternativeName_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAlternativeName_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAlternativeName_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAlternativeName_CrtBase_Terrasoft

	/// <summary>
	/// Also Known As.
	/// </summary>
	public class AccountAlternativeName_CrtBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AccountAlternativeName_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAlternativeName_CrtBase_Terrasoft";
		}

		public AccountAlternativeName_CrtBase_Terrasoft(AccountAlternativeName_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAlternativeName_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAlternativeName_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountAlternativeName_CrtBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountAlternativeName_CrtBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAlternativeName_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAlternativeName_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AccountAlternativeName_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AccountAlternativeName_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAlternativeName_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAlternativeName_CrtBaseEventsProcess

	/// <exclude/>
	public partial class AccountAlternativeName_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountAlternativeName_CrtBase_Terrasoft
	{

		public AccountAlternativeName_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAlternativeName_CrtBaseEventsProcess";
			SchemaUId = new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56");
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

	#region Class: AccountAlternativeName_CrtBaseEventsProcess

	/// <exclude/>
	public class AccountAlternativeName_CrtBaseEventsProcess : AccountAlternativeName_CrtBaseEventsProcess<AccountAlternativeName_CrtBase_Terrasoft>
	{

		public AccountAlternativeName_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAlternativeName_CrtBaseEventsProcess

	public partial class AccountAlternativeName_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

