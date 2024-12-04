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

	#region Class: BankCardInFolderSchema

	/// <exclude/>
	public class BankCardInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public BankCardInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardInFolderSchema(BankCardInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardInFolderSchema(BankCardInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			RealUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			Name = "BankCardInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
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
			if (Columns.FindByUId(new Guid("7e5ff85e-8167-4456-966b-2557c6b7a81a")) == null) {
				Columns.Add(CreateBankCardColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("9898ec70-540f-40e2-b84c-49b6ae6c85f4");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBankCardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7e5ff85e-8167-4456-966b-2557c6b7a81a"),
				Name = @"BankCard",
				ReferenceSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3"),
				ModifiedInSchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3"),
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
			return new BankCardInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardInFolder_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardInFolder

	/// <summary>
	/// "Cards" object in folder.
	/// </summary>
	public class BankCardInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public BankCardInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardInFolder";
		}

		public BankCardInFolder(BankCardInFolder source)
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
		/// Map.
		/// </summary>
		public BankCard BankCard {
			get {
				return _bankCard ??
					(_bankCard = LookupColumnEntities.GetEntity("BankCard") as BankCard);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardInFolder_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardInFolderDeleted", e);
			Validating += (s, e) => ThrowEvent("BankCardInFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardInFolder_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardInFolder_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankCardInFolder
	{

		public BankCardInFolder_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardInFolder_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("00d58087-abfd-49c4-9f58-caee5f99aba3");
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

	#region Class: BankCardInFolder_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardInFolder_CrtFinservAccountAndCardEventsProcess : BankCardInFolder_CrtFinservAccountAndCardEventsProcess<BankCardInFolder>
	{

		public BankCardInFolder_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardInFolder_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardInFolder_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardInFolderEventsProcess

	/// <exclude/>
	public class BankCardInFolderEventsProcess : BankCardInFolder_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

