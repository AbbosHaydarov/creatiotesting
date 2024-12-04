namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ActivityStatus_CrtCoreBase_TerrasoftSchema

	/// <exclude/>
	public class ActivityStatus_CrtCoreBase_TerrasoftSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public ActivityStatus_CrtCoreBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityStatus_CrtCoreBase_TerrasoftSchema(ActivityStatus_CrtCoreBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityStatus_CrtCoreBase_TerrasoftSchema(ActivityStatus_CrtCoreBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			RealUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			Name = "ActivityStatus_CrtCoreBase_Terrasoft";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b618e983-400b-4eee-8645-f6a53fd325ec")) == null) {
				Columns.Add(CreateFinishColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.SystemValue,
				ValueSource = SystemValueManager.GetInstanceByName(@"SequentialGuid")
			};
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinishColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b618e983-400b-4eee-8645-f6a53fd325ec"),
				Name = @"Finish",
				CreatedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"),
				ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityStatus_CrtCoreBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityStatus_CrtCoreBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityStatus_CrtCoreBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityStatus_CrtCoreBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityStatus_CrtCoreBase_Terrasoft

	/// <summary>
	/// Activity status.
	/// </summary>
	public class ActivityStatus_CrtCoreBase_Terrasoft : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public ActivityStatus_CrtCoreBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityStatus_CrtCoreBase_Terrasoft";
		}

		public ActivityStatus_CrtCoreBase_Terrasoft(ActivityStatus_CrtCoreBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Status is final.
		/// </summary>
		public bool Finish {
			get {
				return GetTypedColumnValue<bool>("Finish");
			}
			set {
				SetColumnValue("Finish", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityStatus_CrtCoreBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityStatus_CrtCoreBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityStatus_CrtCoreBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ActivityStatus_CrtCoreBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ActivityStatus_CrtCoreBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ActivityStatus_CrtCoreBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ActivityStatus_CrtCoreBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ActivityStatus_CrtCoreBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityStatus_CrtCoreBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityStatus_CrtCoreBaseEventsProcess

	/// <exclude/>
	public partial class ActivityStatus_CrtCoreBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ActivityStatus_CrtCoreBase_Terrasoft
	{

		public ActivityStatus_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityStatus_CrtCoreBaseEventsProcess";
			SchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
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

	#region Class: ActivityStatus_CrtCoreBaseEventsProcess

	/// <exclude/>
	public class ActivityStatus_CrtCoreBaseEventsProcess : ActivityStatus_CrtCoreBaseEventsProcess<ActivityStatus_CrtCoreBase_Terrasoft>
	{

		public ActivityStatus_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityStatus_CrtCoreBaseEventsProcess

	public partial class ActivityStatus_CrtCoreBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

