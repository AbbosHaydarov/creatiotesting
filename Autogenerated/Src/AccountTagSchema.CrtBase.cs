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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: AccountTag_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class AccountTag_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public AccountTag_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountTag_CrtBase_TerrasoftSchema(AccountTag_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountTag_CrtBase_TerrasoftSchema(AccountTag_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42b60e75-f30e-4895-a80c-3835a5e5b97a");
			RealUId = new Guid("42b60e75-f30e-4895-a80c-3835a5e5b97a");
			Name = "AccountTag_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dfe2c6b5-61e8-4e57-95ae-a3c34fa0908f");
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
			return new AccountTag_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountTag_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountTag_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountTag_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42b60e75-f30e-4895-a80c-3835a5e5b97a"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountTag_CrtBase_Terrasoft

	/// <summary>
	/// Accounts section tag.
	/// </summary>
	public class AccountTag_CrtBase_Terrasoft : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public AccountTag_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountTag_CrtBase_Terrasoft";
		}

		public AccountTag_CrtBase_Terrasoft(AccountTag_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountTag_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("AccountTag_CrtBase_TerrasoftInserted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountTag_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountTag_CrtBaseEventsProcess

	/// <exclude/>
	public partial class AccountTag_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : AccountTag_CrtBase_Terrasoft
	{

		public AccountTag_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountTag_CrtBaseEventsProcess";
			SchemaUId = new Guid("42b60e75-f30e-4895-a80c-3835a5e5b97a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("42b60e75-f30e-4895-a80c-3835a5e5b97a");
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

	#region Class: AccountTag_CrtBaseEventsProcess

	/// <exclude/>
	public class AccountTag_CrtBaseEventsProcess : AccountTag_CrtBaseEventsProcess<AccountTag_CrtBase_Terrasoft>
	{

		public AccountTag_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountTag_CrtBaseEventsProcess

	public partial class AccountTag_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

