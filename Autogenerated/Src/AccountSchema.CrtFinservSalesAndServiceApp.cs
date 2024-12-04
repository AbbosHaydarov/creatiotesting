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

	#region Class: Account_CrtFinservSalesAndServiceApp_TerrasoftSchema

	/// <exclude/>
	public class Account_CrtFinservSalesAndServiceApp_TerrasoftSchema : Terrasoft.Configuration.Account_CrtMLLeadConversion_TerrasoftSchema
	{

		#region Constructors: Public

		public Account_CrtFinservSalesAndServiceApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Account_CrtFinservSalesAndServiceApp_TerrasoftSchema(Account_CrtFinservSalesAndServiceApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Account_CrtFinservSalesAndServiceApp_TerrasoftSchema(Account_CrtFinservSalesAndServiceApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("86fc7f4d-3ab9-4f34-bb7b-506ccc7f2418");
			Name = "Account_CrtFinservSalesAndServiceApp_Terrasoft";
			ParentSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("929db29c-5471-46f0-93aa-7200cd6864dc");
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
			return new Account_CrtFinservSalesAndServiceApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Account_CrtFinservSalesAndServiceAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Account_CrtFinservSalesAndServiceApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Account_CrtFinservSalesAndServiceApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86fc7f4d-3ab9-4f34-bb7b-506ccc7f2418"));
		}

		#endregion

	}

	#endregion

	#region Class: Account_CrtFinservSalesAndServiceApp_Terrasoft

	/// <summary>
	/// Legal entity.
	/// </summary>
	public class Account_CrtFinservSalesAndServiceApp_Terrasoft : Terrasoft.Configuration.Account_CrtMLLeadConversion_Terrasoft
	{

		#region Constructors: Public

		public Account_CrtFinservSalesAndServiceApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Account_CrtFinservSalesAndServiceApp_Terrasoft";
		}

		public Account_CrtFinservSalesAndServiceApp_Terrasoft(Account_CrtFinservSalesAndServiceApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Account_CrtFinservSalesAndServiceAppEventsProcess(UserConnection);
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
			return new Account_CrtFinservSalesAndServiceApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Account_CrtFinservSalesAndServiceAppEventsProcess

	/// <exclude/>
	public partial class Account_CrtFinservSalesAndServiceAppEventsProcess<TEntity> : Terrasoft.Configuration.Account_CrtMLLeadConversionEventsProcess<TEntity> where TEntity : Account_CrtFinservSalesAndServiceApp_Terrasoft
	{

		public Account_CrtFinservSalesAndServiceAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Account_CrtFinservSalesAndServiceAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("86fc7f4d-3ab9-4f34-bb7b-506ccc7f2418");
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

	#region Class: Account_CrtFinservSalesAndServiceAppEventsProcess

	/// <exclude/>
	public class Account_CrtFinservSalesAndServiceAppEventsProcess : Account_CrtFinservSalesAndServiceAppEventsProcess<Account_CrtFinservSalesAndServiceApp_Terrasoft>
	{

		public Account_CrtFinservSalesAndServiceAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Account_CrtFinservSalesAndServiceAppEventsProcess

	public partial class Account_CrtFinservSalesAndServiceAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

