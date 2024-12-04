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

	#region Class: AccountCommunicationSchema

	/// <exclude/>
	public class AccountCommunicationSchema : Terrasoft.Configuration.AccountCommunication_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountCommunicationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountCommunicationSchema(AccountCommunicationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountCommunicationSchema(AccountCommunicationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("312ed590-a4c2-4fd2-b3f5-b9a9f428a358");
			Name = "AccountCommunication";
			ParentSchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new AccountCommunication(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountCommunication_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountCommunicationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountCommunicationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("312ed590-a4c2-4fd2-b3f5-b9a9f428a358"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountCommunication

	/// <summary>
	/// Communication option of legal entity.
	/// </summary>
	public class AccountCommunication : Terrasoft.Configuration.AccountCommunication_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountCommunication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountCommunication";
		}

		public AccountCommunication(AccountCommunication source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountCommunication_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("AccountCommunicationDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountCommunicationInserted", e);
			Validating += (s, e) => ThrowEvent("AccountCommunicationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountCommunication(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountCommunication_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountCommunication_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountCommunication_CrtBaseEventsProcess<TEntity> where TEntity : AccountCommunication
	{

		public AccountCommunication_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountCommunication_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("312ed590-a4c2-4fd2-b3f5-b9a9f428a358");
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

	#region Class: AccountCommunication_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountCommunication_CrtBaseFinservEventsProcess : AccountCommunication_CrtBaseFinservEventsProcess<AccountCommunication>
	{

		public AccountCommunication_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountCommunication_CrtBaseFinservEventsProcess

	public partial class AccountCommunication_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountCommunicationEventsProcess

	/// <exclude/>
	public class AccountCommunicationEventsProcess : AccountCommunication_CrtBaseFinservEventsProcess
	{

		public AccountCommunicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

