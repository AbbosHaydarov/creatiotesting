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

	#region Class: CompetitorProductSchema

	/// <exclude/>
	public class CompetitorProductSchema : Terrasoft.Configuration.CompetitorProduct_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public CompetitorProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CompetitorProductSchema(CompetitorProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CompetitorProductSchema(CompetitorProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("bcb10254-808c-4ff8-a708-7cac48454a4d");
			Name = "CompetitorProduct";
			ParentSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("df742097-edc8-4c94-8684-5207adfedf83");
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
			return new CompetitorProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CompetitorProduct_OpportunityBankEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CompetitorProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CompetitorProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bcb10254-808c-4ff8-a708-7cac48454a4d"));
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProduct

	/// <summary>
	/// Competitor product.
	/// </summary>
	public class CompetitorProduct : Terrasoft.Configuration.CompetitorProduct_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public CompetitorProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CompetitorProduct";
		}

		public CompetitorProduct(CompetitorProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CompetitorProduct_OpportunityBankEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CompetitorProductDeleted", e);
			Validating += (s, e) => ThrowEvent("CompetitorProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CompetitorProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProduct_OpportunityBankEventsProcess

	/// <exclude/>
	public partial class CompetitorProduct_OpportunityBankEventsProcess<TEntity> : Terrasoft.Configuration.CompetitorProduct_CrtBaseEventsProcess<TEntity> where TEntity : CompetitorProduct
	{

		public CompetitorProduct_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CompetitorProduct_OpportunityBankEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bcb10254-808c-4ff8-a708-7cac48454a4d");
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

	#region Class: CompetitorProduct_OpportunityBankEventsProcess

	/// <exclude/>
	public class CompetitorProduct_OpportunityBankEventsProcess : CompetitorProduct_OpportunityBankEventsProcess<CompetitorProduct>
	{

		public CompetitorProduct_OpportunityBankEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CompetitorProduct_OpportunityBankEventsProcess

	public partial class CompetitorProduct_OpportunityBankEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CompetitorProductEventsProcess

	/// <exclude/>
	public class CompetitorProductEventsProcess : CompetitorProduct_OpportunityBankEventsProcess
	{

		public CompetitorProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

