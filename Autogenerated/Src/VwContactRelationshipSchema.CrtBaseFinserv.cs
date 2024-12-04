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

	#region Class: VwContactRelationshipSchema

	/// <exclude/>
	public class VwContactRelationshipSchema : Terrasoft.Configuration.VwContactRelationship_CrtNUI_TerrasoftSchema
	{

		#region Constructors: Public

		public VwContactRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwContactRelationshipSchema(VwContactRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwContactRelationshipSchema(VwContactRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("07c3a7a3-ad4f-4207-b649-8bc21e3ec77d");
			Name = "VwContactRelationship";
			ParentSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
			IsDBView = true;
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
			return new VwContactRelationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwContactRelationship_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwContactRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwContactRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07c3a7a3-ad4f-4207-b649-8bc21e3ec77d"));
		}

		#endregion

	}

	#endregion

	#region Class: VwContactRelationship

	/// <summary>
	/// Relationship of contact (view).
	/// </summary>
	public class VwContactRelationship : Terrasoft.Configuration.VwContactRelationship_CrtNUI_Terrasoft
	{

		#region Constructors: Public

		public VwContactRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwContactRelationship";
		}

		public VwContactRelationship(VwContactRelationship source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwContactRelationship_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwContactRelationshipDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwContactRelationshipDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwContactRelationshipInserted", e);
			Saved += (s, e) => ThrowEvent("VwContactRelationshipSaved", e);
			Saving += (s, e) => ThrowEvent("VwContactRelationshipSaving", e);
			Validating += (s, e) => ThrowEvent("VwContactRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwContactRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwContactRelationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwContactRelationship_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwContactRelationship_CrtNUIEventsProcess<TEntity> where TEntity : VwContactRelationship
	{

		public VwContactRelationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwContactRelationship_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("07c3a7a3-ad4f-4207-b649-8bc21e3ec77d");
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

	#region Class: VwContactRelationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwContactRelationship_CrtBaseFinservEventsProcess : VwContactRelationship_CrtBaseFinservEventsProcess<VwContactRelationship>
	{

		public VwContactRelationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwContactRelationship_CrtBaseFinservEventsProcess

	public partial class VwContactRelationship_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwContactRelationshipEventsProcess

	/// <exclude/>
	public class VwContactRelationshipEventsProcess : VwContactRelationship_CrtBaseFinservEventsProcess
	{

		public VwContactRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

