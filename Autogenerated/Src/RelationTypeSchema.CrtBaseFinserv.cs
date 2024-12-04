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

	#region Class: RelationTypeSchema

	/// <exclude/>
	public class RelationTypeSchema : Terrasoft.Configuration.RelationType_RelationshipDesigner_TerrasoftSchema
	{

		#region Constructors: Public

		public RelationTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RelationTypeSchema(RelationTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RelationTypeSchema(RelationTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e82da241-d0cc-4ae4-beb5-75964647260e");
			Name = "RelationType";
			ParentSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
			ExtendParent = true;
			CreatedInPackageId = new Guid("42c464a9-9677-4bbd-86c1-308caea3de84");
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
			return new RelationType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RelationType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RelationTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RelationTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e82da241-d0cc-4ae4-beb5-75964647260e"));
		}

		#endregion

	}

	#endregion

	#region Class: RelationType

	/// <summary>
	/// Relationship type.
	/// </summary>
	public class RelationType : Terrasoft.Configuration.RelationType_RelationshipDesigner_Terrasoft
	{

		#region Constructors: Public

		public RelationType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RelationType";
		}

		public RelationType(RelationType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RelationType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RelationTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("RelationTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("RelationTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("RelationTypeInserting", e);
			Saved += (s, e) => ThrowEvent("RelationTypeSaved", e);
			Saving += (s, e) => ThrowEvent("RelationTypeSaving", e);
			Validating += (s, e) => ThrowEvent("RelationTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RelationType(this);
		}

		#endregion

	}

	#endregion

	#region Class: RelationType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class RelationType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.RelationType_RelationshipDesignerEventsProcess<TEntity> where TEntity : RelationType
	{

		public RelationType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RelationType_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e82da241-d0cc-4ae4-beb5-75964647260e");
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

	#region Class: RelationType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class RelationType_CrtBaseFinservEventsProcess : RelationType_CrtBaseFinservEventsProcess<RelationType>
	{

		public RelationType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RelationType_CrtBaseFinservEventsProcess

	public partial class RelationType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RelationTypeEventsProcess

	/// <exclude/>
	public class RelationTypeEventsProcess : RelationType_CrtBaseFinservEventsProcess
	{

		public RelationTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

