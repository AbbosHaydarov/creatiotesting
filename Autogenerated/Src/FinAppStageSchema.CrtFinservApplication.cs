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

	#region Class: FinAppStageSchema

	/// <exclude/>
	public class FinAppStageSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public FinAppStageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinAppStageSchema(FinAppStageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinAppStageSchema(FinAppStageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c7397bc8-1eb6-4a40-98c8-a78c05c7e48d");
			RealUId = new Guid("c7397bc8-1eb6-4a40-98c8-a78c05c7e48d");
			Name = "FinAppStage";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b");
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
			return new FinAppStage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinAppStage_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinAppStageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinAppStageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c7397bc8-1eb6-4a40-98c8-a78c05c7e48d"));
		}

		#endregion

	}

	#endregion

	#region Class: FinAppStage

	/// <summary>
	/// Application stage.
	/// </summary>
	public class FinAppStage : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public FinAppStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinAppStage";
		}

		public FinAppStage(FinAppStage source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinAppStage_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinAppStageDeleted", e);
			Validating += (s, e) => ThrowEvent("FinAppStageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinAppStage(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinAppStage_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinAppStage_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinAppStage
	{

		public FinAppStage_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinAppStage_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("c7397bc8-1eb6-4a40-98c8-a78c05c7e48d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c7397bc8-1eb6-4a40-98c8-a78c05c7e48d");
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

	#region Class: FinAppStage_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinAppStage_CrtFinservApplicationEventsProcess : FinAppStage_CrtFinservApplicationEventsProcess<FinAppStage>
	{

		public FinAppStage_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinAppStage_CrtFinservApplicationEventsProcess

	public partial class FinAppStage_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinAppStageEventsProcess

	/// <exclude/>
	public class FinAppStageEventsProcess : FinAppStage_CrtFinservApplicationEventsProcess
	{

		public FinAppStageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

