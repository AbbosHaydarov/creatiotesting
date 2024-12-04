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
	using System.Security;
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

	#region Class: RelationshipSchema

	/// <exclude/>
	public class RelationshipSchema : Terrasoft.Configuration.Relationship_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public RelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RelationshipSchema(RelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RelationshipSchema(RelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("39bb35d2-c9dd-482e-a44b-8e9739a264ca");
			Name = "Relationship";
			ParentSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
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
			return new Relationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Relationship_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("39bb35d2-c9dd-482e-a44b-8e9739a264ca"));
		}

		#endregion

	}

	#endregion

	#region Class: Relationship

	/// <summary>
	/// Relationship.
	/// </summary>
	public class Relationship : Terrasoft.Configuration.Relationship_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public Relationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Relationship";
		}

		public Relationship(Relationship source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Relationship_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RelationshipDeleted", e);
			Validating += (s, e) => ThrowEvent("RelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Relationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: Relationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class Relationship_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.Relationship_CrtBaseEventsProcess<TEntity> where TEntity : Relationship
	{

		public Relationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Relationship_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("39bb35d2-c9dd-482e-a44b-8e9739a264ca");
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

	#region Class: Relationship_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class Relationship_CrtBaseFinservEventsProcess : Relationship_CrtBaseFinservEventsProcess<Relationship>
	{

		public Relationship_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Relationship_CrtBaseFinservEventsProcess

	public partial class Relationship_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RelationshipEventsProcess

	/// <exclude/>
	public class RelationshipEventsProcess : Relationship_CrtBaseFinservEventsProcess
	{

		public RelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

