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

	#region Class: BankCardBankAccountSchema

	/// <exclude/>
	public class BankCardBankAccountSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BankCardBankAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardBankAccountSchema(BankCardBankAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardBankAccountSchema(BankCardBankAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5");
			RealUId = new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5");
			Name = "BankCardBankAccount";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2dd58f96-66a6-48c0-9951-9ed842c16271");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6097d7e8-78c2-4d52-84fa-8fff87004d8e")) == null) {
				Columns.Add(CreateBankCardColumn());
			}
			if (Columns.FindByUId(new Guid("18aa5acf-0304-4cef-aa55-d0485801d037")) == null) {
				Columns.Add(CreateBankAccountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateBankCardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6097d7e8-78c2-4d52-84fa-8fff87004d8e"),
				Name = @"BankCard",
				ReferenceSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5"),
				ModifiedInSchemaUId = new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5"),
				CreatedInPackageId = new Guid("2dd58f96-66a6-48c0-9951-9ed842c16271")
			};
		}

		protected virtual EntitySchemaColumn CreateBankAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("18aa5acf-0304-4cef-aa55-d0485801d037"),
				Name = @"BankAccount",
				ReferenceSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5"),
				ModifiedInSchemaUId = new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5"),
				CreatedInPackageId = new Guid("2dd58f96-66a6-48c0-9951-9ed842c16271")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankCardBankAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardBankAccount_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardBankAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardBankAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardBankAccount

	/// <summary>
	/// Cards and financial accounts connection.
	/// </summary>
	public class BankCardBankAccount : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BankCardBankAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardBankAccount";
		}

		public BankCardBankAccount(BankCardBankAccount source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BankCardId {
			get {
				return GetTypedColumnValue<Guid>("BankCardId");
			}
			set {
				SetColumnValue("BankCardId", value);
				_bankCard = null;
			}
		}

		/// <exclude/>
		public string BankCardNumber {
			get {
				return GetTypedColumnValue<string>("BankCardNumber");
			}
			set {
				SetColumnValue("BankCardNumber", value);
				if (_bankCard != null) {
					_bankCard.Number = value;
				}
			}
		}

		private BankCard _bankCard;
		/// <summary>
		/// Card.
		/// </summary>
		public BankCard BankCard {
			get {
				return _bankCard ??
					(_bankCard = LookupColumnEntities.GetEntity("BankCard") as BankCard);
			}
		}

		/// <exclude/>
		public Guid BankAccountId {
			get {
				return GetTypedColumnValue<Guid>("BankAccountId");
			}
			set {
				SetColumnValue("BankAccountId", value);
				_bankAccount = null;
			}
		}

		/// <exclude/>
		public string BankAccountBankAccountNumber {
			get {
				return GetTypedColumnValue<string>("BankAccountBankAccountNumber");
			}
			set {
				SetColumnValue("BankAccountBankAccountNumber", value);
				if (_bankAccount != null) {
					_bankAccount.BankAccountNumber = value;
				}
			}
		}

		private BankAccount _bankAccount;
		/// <summary>
		/// Financial account.
		/// </summary>
		public BankAccount BankAccount {
			get {
				return _bankAccount ??
					(_bankAccount = LookupColumnEntities.GetEntity("BankAccount") as BankAccount);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardBankAccount_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardBankAccountDeleted", e);
			Validating += (s, e) => ThrowEvent("BankCardBankAccountValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardBankAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardBankAccount_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardBankAccount_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BankCardBankAccount
	{

		public BankCardBankAccount_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardBankAccount_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c891d9ee-8ae4-4d45-92f6-f0886d9da8b5");
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

	#region Class: BankCardBankAccount_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardBankAccount_CrtFinservAccountAndCardEventsProcess : BankCardBankAccount_CrtFinservAccountAndCardEventsProcess<BankCardBankAccount>
	{

		public BankCardBankAccount_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardBankAccount_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardBankAccount_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardBankAccountEventsProcess

	/// <exclude/>
	public class BankCardBankAccountEventsProcess : BankCardBankAccount_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardBankAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

