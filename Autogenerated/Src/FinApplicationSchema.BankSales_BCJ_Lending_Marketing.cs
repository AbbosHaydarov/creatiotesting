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

	#region Class: FinApplicationSchema

	/// <exclude/>
	public class FinApplicationSchema : Terrasoft.Configuration.FinApplication_OBSW_TerrasoftSchema
	{

		#region Constructors: Public

		public FinApplicationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationSchema(FinApplicationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationSchema(FinApplicationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("40077c71-1bed-4170-8dc1-e9fd0b888619");
			Name = "FinApplication";
			ParentSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("cab00ffd-892f-4778-8abc-c75c08de4570");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateProductCategoryColumn() {
			EntitySchemaColumn column = base.CreateProductCategoryColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("40077c71-1bed-4170-8dc1-e9fd0b888619");
			return column;
		}

		protected override EntitySchemaColumn CreateProductTypeColumn() {
			EntitySchemaColumn column = base.CreateProductTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("40077c71-1bed-4170-8dc1-e9fd0b888619");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplication(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40077c71-1bed-4170-8dc1-e9fd0b888619"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication

	/// <summary>
	/// Application.
	/// </summary>
	public class FinApplication : Terrasoft.Configuration.FinApplication_OBSW_Terrasoft
	{

		#region Constructors: Public

		public FinApplication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplication";
		}

		public FinApplication(FinApplication source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection);
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
			return new FinApplication(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess

	/// <exclude/>
	public partial class FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess<TEntity> : Terrasoft.Configuration.FinApplication_OBSWEventsProcess<TEntity> where TEntity : FinApplication
	{

		public FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("40077c71-1bed-4170-8dc1-e9fd0b888619");
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

	#region Class: FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess

	/// <exclude/>
	public class FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess : FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess<FinApplication>
	{

		public FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess

	public partial class FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationEventsProcess : FinApplication_BankSales_BCJ_Lending_MarketingEventsProcess
	{

		public FinApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

