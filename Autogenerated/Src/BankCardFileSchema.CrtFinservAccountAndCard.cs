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
	using Terrasoft.Configuration;
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

	#region Class: BankCardFileSchema

	/// <exclude/>
	public class BankCardFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public BankCardFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardFileSchema(BankCardFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardFileSchema(BankCardFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			RealUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			Name = "BankCardFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
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
			if (Columns.FindByUId(new Guid("e46a3e44-148b-42ae-a7cb-cb6b80a9ecf8")) == null) {
				Columns.Add(CreateBankCardColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateLockedByColumn() {
			EntitySchemaColumn column = base.CreateLockedByColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateLockedOnColumn() {
			EntitySchemaColumn column = base.CreateLockedOnColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateDataColumn() {
			EntitySchemaColumn column = base.CreateDataColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateVersionColumn() {
			EntitySchemaColumn column = base.CreateVersionColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateSizeColumn() {
			EntitySchemaColumn column = base.CreateSizeColumn();
			column.ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBankCardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e46a3e44-148b-42ae-a7cb-cb6b80a9ecf8"),
				Name = @"BankCard",
				ReferenceSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27"),
				ModifiedInSchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27"),
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
			return new BankCardFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardFile_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardFile

	/// <summary>
	/// Card attachment.
	/// </summary>
	public class BankCardFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public BankCardFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardFile";
		}

		public BankCardFile(BankCardFile source)
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
			var process = new BankCardFile_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardFileDeleted", e);
			Updated += (s, e) => ThrowEvent("BankCardFileUpdated", e);
			Validating += (s, e) => ThrowEvent("BankCardFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardFile_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardFile_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.File_LinkPreviewEventsProcess<TEntity> where TEntity : BankCardFile
	{

		public BankCardFile_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardFile_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2666f664-25b8-4012-bdb6-985f3e6baa27");
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

	#region Class: BankCardFile_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardFile_CrtFinservAccountAndCardEventsProcess : BankCardFile_CrtFinservAccountAndCardEventsProcess<BankCardFile>
	{

		public BankCardFile_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardFile_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardFile_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardFileEventsProcess

	/// <exclude/>
	public class BankCardFileEventsProcess : BankCardFile_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

