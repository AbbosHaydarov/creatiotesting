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

	#region Class: Lead_CrtOpportunityManagement_TerrasoftSchema

	/// <exclude/>
	public class Lead_CrtOpportunityManagement_TerrasoftSchema : Terrasoft.Configuration.Lead_Lead_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CrtOpportunityManagement_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CrtOpportunityManagement_TerrasoftSchema(Lead_CrtOpportunityManagement_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CrtOpportunityManagement_TerrasoftSchema(Lead_CrtOpportunityManagement_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("384755ab-0b4c-44f0-b4b3-3852d51e0285");
			Name = "Lead_CrtOpportunityManagement_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c1ff58fe-5126-408a-b357-7637f7748802");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateQualifyStatusColumn() {
			EntitySchemaColumn column = base.CreateQualifyStatusColumn();
			column.ModifiedInSchemaUId = new Guid("384755ab-0b4c-44f0-b4b3-3852d51e0285");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_CrtOpportunityManagement_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CrtOpportunityManagementEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CrtOpportunityManagement_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CrtOpportunityManagement_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("384755ab-0b4c-44f0-b4b3-3852d51e0285"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtOpportunityManagement_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CrtOpportunityManagement_Terrasoft : Terrasoft.Configuration.Lead_Lead_Terrasoft
	{

		#region Constructors: Public

		public Lead_CrtOpportunityManagement_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CrtOpportunityManagement_Terrasoft";
		}

		public Lead_CrtOpportunityManagement_Terrasoft(Lead_CrtOpportunityManagement_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CrtOpportunityManagementEventsProcess(UserConnection);
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
			return new Lead_CrtOpportunityManagement_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtOpportunityManagementEventsProcess

	/// <exclude/>
	public partial class Lead_CrtOpportunityManagementEventsProcess<TEntity> : Terrasoft.Configuration.Lead_LeadEventsProcess<TEntity> where TEntity : Lead_CrtOpportunityManagement_Terrasoft
	{

		public Lead_CrtOpportunityManagementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CrtOpportunityManagementEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("384755ab-0b4c-44f0-b4b3-3852d51e0285");
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

	#region Class: Lead_CrtOpportunityManagementEventsProcess

	/// <exclude/>
	public class Lead_CrtOpportunityManagementEventsProcess : Lead_CrtOpportunityManagementEventsProcess<Lead_CrtOpportunityManagement_Terrasoft>
	{

		public Lead_CrtOpportunityManagementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_CrtOpportunityManagementEventsProcess

	public partial class Lead_CrtOpportunityManagementEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

