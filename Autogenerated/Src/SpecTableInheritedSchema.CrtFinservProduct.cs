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

	#region Class: SpecTableInheritedSchema

	/// <exclude/>
	public class SpecTableInheritedSchema : Terrasoft.Configuration.BaseSpecValueSchema
	{

		#region Constructors: Public

		public SpecTableInheritedSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecTableInheritedSchema(SpecTableInheritedSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecTableInheritedSchema(SpecTableInheritedSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01e20a43-d408-453c-9730-ae8dab8bae69");
			RealUId = new Guid("01e20a43-d408-453c-9730-ae8dab8bae69");
			Name = "SpecTableInherited";
			ParentSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0fa58806-1f3e-4ede-8a42-899320ded3c0")) == null) {
				Columns.Add(CreateParentIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateParentIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("0fa58806-1f3e-4ede-8a42-899320ded3c0"),
				Name = @"ParentId",
				CreatedInSchemaUId = new Guid("01e20a43-d408-453c-9730-ae8dab8bae69"),
				ModifiedInSchemaUId = new Guid("01e20a43-d408-453c-9730-ae8dab8bae69"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecTableInherited(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecTableInherited_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecTableInheritedSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecTableInheritedSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01e20a43-d408-453c-9730-ae8dab8bae69"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecTableInherited

	/// <summary>
	/// Table part inherited parameter value.
	/// </summary>
	public class SpecTableInherited : Terrasoft.Configuration.BaseSpecValue
	{

		#region Constructors: Public

		public SpecTableInherited(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecTableInherited";
		}

		public SpecTableInherited(SpecTableInherited source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Parent record identifier.
		/// </summary>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecTableInherited_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecTableInheritedDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecTableInheritedDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecTableInheritedInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecTableInheritedInserting", e);
			Saved += (s, e) => ThrowEvent("SpecTableInheritedSaved", e);
			Saving += (s, e) => ThrowEvent("SpecTableInheritedSaving", e);
			Validating += (s, e) => ThrowEvent("SpecTableInheritedValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecTableInherited(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecTableInherited_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class SpecTableInherited_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseSpecValue_CrtFinservProductEventsProcess<TEntity> where TEntity : SpecTableInherited
	{

		public SpecTableInherited_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecTableInherited_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("01e20a43-d408-453c-9730-ae8dab8bae69");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("01e20a43-d408-453c-9730-ae8dab8bae69");
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

	#region Class: SpecTableInherited_CrtFinservProductEventsProcess

	/// <exclude/>
	public class SpecTableInherited_CrtFinservProductEventsProcess : SpecTableInherited_CrtFinservProductEventsProcess<SpecTableInherited>
	{

		public SpecTableInherited_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecTableInherited_CrtFinservProductEventsProcess

	public partial class SpecTableInherited_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecTableInheritedEventsProcess

	/// <exclude/>
	public class SpecTableInheritedEventsProcess : SpecTableInherited_CrtFinservProductEventsProcess
	{

		public SpecTableInheritedEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

