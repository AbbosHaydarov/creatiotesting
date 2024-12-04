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

	#region Class: AccountDuplicateSchema

	/// <exclude/>
	public class AccountDuplicateSchema : Terrasoft.Configuration.AccountDuplicate_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountDuplicateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountDuplicateSchema(AccountDuplicateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountDuplicateSchema(AccountDuplicateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("58292ae5-ced8-4d42-a182-3edfed824649");
			Name = "AccountDuplicate";
			ParentSchemaUId = new Guid("a477264b-2d69-48b7-9268-e9b4d39ebf83");
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
			return new AccountDuplicate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountDuplicate_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountDuplicateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountDuplicateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58292ae5-ced8-4d42-a182-3edfed824649"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountDuplicate

	/// <summary>
	/// Legal entity duplicate.
	/// </summary>
	public class AccountDuplicate : Terrasoft.Configuration.AccountDuplicate_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountDuplicate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountDuplicate";
		}

		public AccountDuplicate(AccountDuplicate source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountDuplicate_CrtBaseFinservEventsProcess(UserConnection);
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
			return new AccountDuplicate(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountDuplicate_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountDuplicate_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountDuplicate_CrtBaseEventsProcess<TEntity> where TEntity : AccountDuplicate
	{

		public AccountDuplicate_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountDuplicate_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("58292ae5-ced8-4d42-a182-3edfed824649");
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

	#region Class: AccountDuplicate_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountDuplicate_CrtBaseFinservEventsProcess : AccountDuplicate_CrtBaseFinservEventsProcess<AccountDuplicate>
	{

		public AccountDuplicate_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountDuplicate_CrtBaseFinservEventsProcess

	public partial class AccountDuplicate_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountDuplicateEventsProcess

	/// <exclude/>
	public class AccountDuplicateEventsProcess : AccountDuplicate_CrtBaseFinservEventsProcess
	{

		public AccountDuplicateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

