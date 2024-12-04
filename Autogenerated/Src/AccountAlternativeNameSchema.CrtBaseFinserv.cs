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

	#region Class: AccountAlternativeNameSchema

	/// <exclude/>
	public class AccountAlternativeNameSchema : Terrasoft.Configuration.AccountAlternativeName_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountAlternativeNameSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAlternativeNameSchema(AccountAlternativeNameSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAlternativeNameSchema(AccountAlternativeNameSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2acabcbd-c3c2-45e6-b5dc-31cf54224305");
			Name = "AccountAlternativeName";
			ParentSchemaUId = new Guid("9f4fc7b4-8205-4034-995d-23aa97ff1f56");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
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
			return new AccountAlternativeName(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAlternativeName_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAlternativeNameSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAlternativeNameSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2acabcbd-c3c2-45e6-b5dc-31cf54224305"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAlternativeName

	/// <summary>
	/// Also Known As.
	/// </summary>
	public class AccountAlternativeName : Terrasoft.Configuration.AccountAlternativeName_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountAlternativeName(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAlternativeName";
		}

		public AccountAlternativeName(AccountAlternativeName source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAlternativeName_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAlternativeNameDeleted", e);
			Validating += (s, e) => ThrowEvent("AccountAlternativeNameValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAlternativeName(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAlternativeName_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AccountAlternativeName_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AccountAlternativeName_CrtBaseEventsProcess<TEntity> where TEntity : AccountAlternativeName
	{

		public AccountAlternativeName_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAlternativeName_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2acabcbd-c3c2-45e6-b5dc-31cf54224305");
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

	#region Class: AccountAlternativeName_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AccountAlternativeName_CrtBaseFinservEventsProcess : AccountAlternativeName_CrtBaseFinservEventsProcess<AccountAlternativeName>
	{

		public AccountAlternativeName_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAlternativeName_CrtBaseFinservEventsProcess

	public partial class AccountAlternativeName_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountAlternativeNameEventsProcess

	/// <exclude/>
	public class AccountAlternativeNameEventsProcess : AccountAlternativeName_CrtBaseFinservEventsProcess
	{

		public AccountAlternativeNameEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

