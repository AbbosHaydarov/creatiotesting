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

	#region Class: PeriodTypeSchema

	/// <exclude/>
	public class PeriodTypeSchema : Terrasoft.Configuration.PeriodType_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public PeriodTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PeriodTypeSchema(PeriodTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PeriodTypeSchema(PeriodTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1d374cd1-7ed3-42ac-bf9a-aa640837c81b");
			Name = "PeriodType";
			ParentSchemaUId = new Guid("3608a0e4-0235-4936-9c0e-99620e73940c");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d66ef255-bffe-4b01-a996-26b991249158")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d66ef255-bffe-4b01-a996-26b991249158"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("1d374cd1-7ed3-42ac-bf9a-aa640837c81b"),
				ModifiedInSchemaUId = new Guid("1d374cd1-7ed3-42ac-bf9a-aa640837c81b"),
				CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PeriodType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PeriodType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PeriodTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PeriodTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d374cd1-7ed3-42ac-bf9a-aa640837c81b"));
		}

		#endregion

	}

	#endregion

	#region Class: PeriodType

	/// <summary>
	/// Period type.
	/// </summary>
	public class PeriodType : Terrasoft.Configuration.PeriodType_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public PeriodType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PeriodType";
		}

		public PeriodType(PeriodType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PeriodType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PeriodTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("PeriodTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("PeriodTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("PeriodTypeInserting", e);
			Saved += (s, e) => ThrowEvent("PeriodTypeSaved", e);
			Saving += (s, e) => ThrowEvent("PeriodTypeSaving", e);
			Validating += (s, e) => ThrowEvent("PeriodTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PeriodType(this);
		}

		#endregion

	}

	#endregion

	#region Class: PeriodType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class PeriodType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.PeriodType_CrtBaseEventsProcess<TEntity> where TEntity : PeriodType
	{

		public PeriodType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PeriodType_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1d374cd1-7ed3-42ac-bf9a-aa640837c81b");
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

	#region Class: PeriodType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class PeriodType_CrtBaseFinservEventsProcess : PeriodType_CrtBaseFinservEventsProcess<PeriodType>
	{

		public PeriodType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PeriodType_CrtBaseFinservEventsProcess

	public partial class PeriodType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PeriodTypeEventsProcess

	/// <exclude/>
	public class PeriodTypeEventsProcess : PeriodType_CrtBaseFinservEventsProcess
	{

		public PeriodTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

