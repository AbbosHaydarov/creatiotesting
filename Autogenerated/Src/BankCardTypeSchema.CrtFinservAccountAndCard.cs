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

	#region Class: BankCardTypeSchema

	/// <exclude/>
	public class BankCardTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BankCardTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardTypeSchema(BankCardTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardTypeSchema(BankCardTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			RealUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			Name = "BankCardType";
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
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankCardType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardType_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardType

	/// <summary>
	/// Card type.
	/// </summary>
	public class BankCardType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BankCardType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardType";
		}

		public BankCardType(BankCardType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardType_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("BankCardTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardType(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardType_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardType_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankCardType
	{

		public BankCardType_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardType_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507");
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

	#region Class: BankCardType_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardType_CrtFinservAccountAndCardEventsProcess : BankCardType_CrtFinservAccountAndCardEventsProcess<BankCardType>
	{

		public BankCardType_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardType_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardType_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardTypeEventsProcess

	/// <exclude/>
	public class BankCardTypeEventsProcess : BankCardType_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

