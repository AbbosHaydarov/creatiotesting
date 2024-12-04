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

	#region Class: AccountInTagSchema

	/// <exclude/>
	public class AccountInTagSchema : Terrasoft.Configuration.AccountInTag_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountInTagSchema(AccountInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountInTagSchema(AccountInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ea12316f-3b75-477d-b8fa-5418f650c177");
			Name = "AccountInTag";
			ParentSchemaUId = new Guid("772d4ab2-2e2f-49c1-acfa-964dc80ab5a6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("27329051-b308-4a64-83ef-1a0f05a9ca5f");
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
			return new AccountInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountInTag_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea12316f-3b75-477d-b8fa-5418f650c177"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountInTag

	/// <summary>
	/// Legal entities section record tag.
	/// </summary>
	public class AccountInTag : Terrasoft.Configuration.AccountInTag_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountInTag";
		}

		public AccountInTag(AccountInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountInTag_CrtBaseFinservEventsProcess(UserConnection);
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
			return new AccountInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountInTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountInTag_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountInTag_CrtBaseEventsProcess<TEntity> where TEntity : AccountInTag
	{

		public AccountInTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountInTag_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ea12316f-3b75-477d-b8fa-5418f650c177");
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

	#region Class: AccountInTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountInTag_CrtBaseFinservEventsProcess : AccountInTag_CrtBaseFinservEventsProcess<AccountInTag>
	{

		public AccountInTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountInTag_CrtBaseFinservEventsProcess

	public partial class AccountInTag_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountInTagEventsProcess

	/// <exclude/>
	public class AccountInTagEventsProcess : AccountInTag_CrtBaseFinservEventsProcess
	{

		public AccountInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

