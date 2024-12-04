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

	#region Class: SpecificationListItemSchema

	/// <exclude/>
	public class SpecificationListItemSchema : Terrasoft.Configuration.SpecificationListItem_CrtFinservSpecification_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationListItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationListItemSchema(SpecificationListItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationListItemSchema(SpecificationListItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("311a2664-d39a-45c9-9ae1-c31f8d143a64");
			Name = "SpecificationListItem";
			ParentSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("130e523a-8197-4c4f-ba2e-2a0c2de1e372")) == null) {
				Columns.Add(CreateLookupValueIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLookupValueIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("130e523a-8197-4c4f-ba2e-2a0c2de1e372"),
				Name = @"LookupValueId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("311a2664-d39a-45c9-9ae1-c31f8d143a64"),
				ModifiedInSchemaUId = new Guid("311a2664-d39a-45c9-9ae1-c31f8d143a64"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationListItem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationListItem_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationListItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationListItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("311a2664-d39a-45c9-9ae1-c31f8d143a64"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationListItem

	/// <summary>
	/// Feature value.
	/// </summary>
	public class SpecificationListItem : Terrasoft.Configuration.SpecificationListItem_CrtFinservSpecification_Terrasoft
	{

		#region Constructors: Public

		public SpecificationListItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationListItem";
		}

		public SpecificationListItem(SpecificationListItem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Lookup value Id.
		/// </summary>
		public Guid LookupValueId {
			get {
				return GetTypedColumnValue<Guid>("LookupValueId");
			}
			set {
				SetColumnValue("LookupValueId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationListItem_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationListItemDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecificationListItemDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecificationListItemInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationListItemInserting", e);
			Saved += (s, e) => ThrowEvent("SpecificationListItemSaved", e);
			Saving += (s, e) => ThrowEvent("SpecificationListItemSaving", e);
			Validating += (s, e) => ThrowEvent("SpecificationListItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationListItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationListItem_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class SpecificationListItem_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationListItem_CrtFinservSpecificationEventsProcess<TEntity> where TEntity : SpecificationListItem
	{

		public SpecificationListItem_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationListItem_CrtFinservProductEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("311a2664-d39a-45c9-9ae1-c31f8d143a64");
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

	#region Class: SpecificationListItem_CrtFinservProductEventsProcess

	/// <exclude/>
	public class SpecificationListItem_CrtFinservProductEventsProcess : SpecificationListItem_CrtFinservProductEventsProcess<SpecificationListItem>
	{

		public SpecificationListItem_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationListItem_CrtFinservProductEventsProcess

	public partial class SpecificationListItem_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationListItemEventsProcess

	/// <exclude/>
	public class SpecificationListItemEventsProcess : SpecificationListItem_CrtFinservProductEventsProcess
	{

		public SpecificationListItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

