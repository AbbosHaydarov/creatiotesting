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

	#region Class: OpportunityFolderSchema

	/// <exclude/>
	public class OpportunityFolderSchema : Terrasoft.Configuration.OpportunityFolder_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityFolderSchema(OpportunityFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityFolderSchema(OpportunityFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ddf85a12-c473-4296-91ee-512eb3010d34");
			Name = "OpportunityFolder";
			ParentSchemaUId = new Guid("ba431b60-ce67-4198-9281-6571b6920f70");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("ddf85a12-c473-4296-91ee-512eb3010d34");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityFolder_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ddf85a12-c473-4296-91ee-512eb3010d34"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityFolder

	/// <summary>
	/// Opportunity folder.
	/// </summary>
	public class OpportunityFolder : Terrasoft.Configuration.OpportunityFolder_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityFolder";
		}

		public OpportunityFolder(OpportunityFolder source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityFolder_OpportunityEventsProcess(UserConnection);
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
			return new OpportunityFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityFolder_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityFolder_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityFolder_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityFolder
	{

		public OpportunityFolder_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityFolder_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ddf85a12-c473-4296-91ee-512eb3010d34");
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

	#region Class: OpportunityFolder_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityFolder_OpportunityEventsProcess : OpportunityFolder_OpportunityEventsProcess<OpportunityFolder>
	{

		public OpportunityFolder_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: OpportunityFolderEventsProcess

	/// <exclude/>
	public class OpportunityFolderEventsProcess : OpportunityFolder_OpportunityEventsProcess
	{

		public OpportunityFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

