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
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_BankSales_TerrasoftSchema

	/// <exclude/>
	public class Contact_BankSales_TerrasoftSchema : Terrasoft.Configuration.Contact_Lending_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_BankSales_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_BankSales_TerrasoftSchema(Contact_BankSales_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_BankSales_TerrasoftSchema(Contact_BankSales_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d2435d4e-0a23-4b33-8531-6ec5a2726f1f");
			Name = "Contact_BankSales_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("186e89de-f146-47c3-a2d3-cacfd2c7fbd4");
			IsDBView = false;
			UseDenyRecordRights = false;
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
			return new Contact_BankSales_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_BankSalesEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_BankSales_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_BankSales_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2435d4e-0a23-4b33-8531-6ec5a2726f1f"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_BankSales_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_BankSales_Terrasoft : Terrasoft.Configuration.Contact_Lending_Terrasoft
	{

		#region Constructors: Public

		public Contact_BankSales_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_BankSales_Terrasoft";
		}

		public Contact_BankSales_Terrasoft(Contact_BankSales_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_BankSalesEventsProcess(UserConnection);
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
			return new Contact_BankSales_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_BankSalesEventsProcess

	/// <exclude/>
	public partial class Contact_BankSalesEventsProcess<TEntity> : Terrasoft.Configuration.Contact_LendingEventsProcess<TEntity> where TEntity : Contact_BankSales_Terrasoft
	{

		public Contact_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_BankSalesEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d2435d4e-0a23-4b33-8531-6ec5a2726f1f");
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

	#region Class: Contact_BankSalesEventsProcess

	/// <exclude/>
	public class Contact_BankSalesEventsProcess : Contact_BankSalesEventsProcess<Contact_BankSales_Terrasoft>
	{

		public Contact_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_BankSalesEventsProcess

	public partial class Contact_BankSalesEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

