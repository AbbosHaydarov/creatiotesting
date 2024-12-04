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

	#region Class: BankCardCategorySchema

	/// <exclude/>
	public class BankCardCategorySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BankCardCategorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardCategorySchema(BankCardCategorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardCategorySchema(BankCardCategorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			RealUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			Name = "BankCardCategory";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("454aa7ab-babf-4788-858f-dedcd94d2787")) == null) {
				Columns.Add(CreateBankCardPaymentSystemColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBankCardPaymentSystemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("454aa7ab-babf-4788-858f-dedcd94d2787"),
				Name = @"BankCardPaymentSystem",
				ReferenceSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e"),
				ModifiedInSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankCardCategory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardCategory_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardCategorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardCategorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardCategory

	/// <summary>
	/// Card category.
	/// </summary>
	public class BankCardCategory : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BankCardCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardCategory";
		}

		public BankCardCategory(BankCardCategory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BankCardPaymentSystemId {
			get {
				return GetTypedColumnValue<Guid>("BankCardPaymentSystemId");
			}
			set {
				SetColumnValue("BankCardPaymentSystemId", value);
				_bankCardPaymentSystem = null;
			}
		}

		/// <exclude/>
		public string BankCardPaymentSystemName {
			get {
				return GetTypedColumnValue<string>("BankCardPaymentSystemName");
			}
			set {
				SetColumnValue("BankCardPaymentSystemName", value);
				if (_bankCardPaymentSystem != null) {
					_bankCardPaymentSystem.Name = value;
				}
			}
		}

		private BankCardPaymentSystem _bankCardPaymentSystem;
		/// <summary>
		/// Payment system.
		/// </summary>
		public BankCardPaymentSystem BankCardPaymentSystem {
			get {
				return _bankCardPaymentSystem ??
					(_bankCardPaymentSystem = LookupColumnEntities.GetEntity("BankCardPaymentSystem") as BankCardPaymentSystem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardCategory_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardCategoryDeleted", e);
			Validating += (s, e) => ThrowEvent("BankCardCategoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardCategory(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardCategory_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardCategory_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankCardCategory
	{

		public BankCardCategory_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardCategory_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e");
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

	#region Class: BankCardCategory_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardCategory_CrtFinservAccountAndCardEventsProcess : BankCardCategory_CrtFinservAccountAndCardEventsProcess<BankCardCategory>
	{

		public BankCardCategory_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardCategory_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardCategory_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardCategoryEventsProcess

	/// <exclude/>
	public class BankCardCategoryEventsProcess : BankCardCategory_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardCategoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

