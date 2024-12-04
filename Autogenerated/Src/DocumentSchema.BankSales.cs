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

	#region Class: Document_BankSales_TerrasoftSchema

	/// <exclude/>
	public class Document_BankSales_TerrasoftSchema : Terrasoft.Configuration.Document_CrtFinservApplication_TerrasoftSchema
	{

		#region Constructors: Public

		public Document_BankSales_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_BankSales_TerrasoftSchema(Document_BankSales_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_BankSales_TerrasoftSchema(Document_BankSales_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6e3df338-01fa-4cfd-b7d6-744bd4c1104c");
			Name = "Document_BankSales_Terrasoft";
			ParentSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9cd1d1a0-c2da-49e6-9ba7-a016fcece7d2");
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
			return new Document_BankSales_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_BankSalesEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_BankSales_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_BankSales_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e3df338-01fa-4cfd-b7d6-744bd4c1104c"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_BankSales_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_BankSales_Terrasoft : Terrasoft.Configuration.Document_CrtFinservApplication_Terrasoft
	{

		#region Constructors: Public

		public Document_BankSales_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_BankSales_Terrasoft";
		}

		public Document_BankSales_Terrasoft(Document_BankSales_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_BankSalesEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Document_BankSales_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("Document_BankSales_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Document_BankSales_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_BankSalesEventsProcess

	/// <exclude/>
	public partial class Document_BankSalesEventsProcess<TEntity> : Terrasoft.Configuration.Document_CrtFinservApplicationEventsProcess<TEntity> where TEntity : Document_BankSales_Terrasoft
	{

		public Document_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_BankSalesEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6e3df338-01fa-4cfd-b7d6-744bd4c1104c");
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

	#region Class: Document_BankSalesEventsProcess

	/// <exclude/>
	public class Document_BankSalesEventsProcess : Document_BankSalesEventsProcess<Document_BankSales_Terrasoft>
	{

		public Document_BankSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Document_BankSalesEventsProcess

	public partial class Document_BankSalesEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

