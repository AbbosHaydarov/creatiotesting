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

	#region Class: OpportunityFileSchema

	/// <exclude/>
	public class OpportunityFileSchema : Terrasoft.Configuration.OpportunityFile_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityFileSchema(OpportunityFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityFileSchema(OpportunityFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c1ddba99-f81e-46f2-8a20-e76f59b0ee98");
			Name = "OpportunityFile";
			ParentSchemaUId = new Guid("4135a9ba-5936-438f-9795-40fbc090c07b");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityFile_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c1ddba99-f81e-46f2-8a20-e76f59b0ee98"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityFile

	/// <summary>
	/// File and link of opportunity.
	/// </summary>
	public class OpportunityFile : Terrasoft.Configuration.OpportunityFile_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityFile";
		}

		public OpportunityFile(OpportunityFile source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityFile_OpportunityEventsProcess(UserConnection);
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
			return new OpportunityFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityFile_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityFile_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityFile_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityFile
	{

		public OpportunityFile_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityFile_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c1ddba99-f81e-46f2-8a20-e76f59b0ee98");
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

	#region Class: OpportunityFile_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityFile_OpportunityEventsProcess : OpportunityFile_OpportunityEventsProcess<OpportunityFile>
	{

		public OpportunityFile_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: OpportunityFileEventsProcess

	/// <exclude/>
	public class OpportunityFileEventsProcess : OpportunityFile_OpportunityEventsProcess
	{

		public OpportunityFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

