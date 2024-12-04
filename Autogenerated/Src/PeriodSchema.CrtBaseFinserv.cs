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

	#region Class: PeriodSchema

	/// <exclude/>
	public class PeriodSchema : Terrasoft.Configuration.Period_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public PeriodSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PeriodSchema(PeriodSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PeriodSchema(PeriodSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b31b7e94-eee5-4b8e-ae9d-a5c48c1ba131");
			Name = "Period";
			ParentSchemaUId = new Guid("5b473ba3-604c-41d6-b25d-032754dad4d2");
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Period(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Period_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PeriodSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PeriodSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b31b7e94-eee5-4b8e-ae9d-a5c48c1ba131"));
		}

		#endregion

	}

	#endregion

	#region Class: Period

	/// <summary>
	/// Period.
	/// </summary>
	public class Period : Terrasoft.Configuration.Period_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public Period(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Period";
		}

		public Period(Period source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Period_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PeriodDeleted", e);
			Deleting += (s, e) => ThrowEvent("PeriodDeleting", e);
			Inserted += (s, e) => ThrowEvent("PeriodInserted", e);
			Inserting += (s, e) => ThrowEvent("PeriodInserting", e);
			Saved += (s, e) => ThrowEvent("PeriodSaved", e);
			Saving += (s, e) => ThrowEvent("PeriodSaving", e);
			Validating += (s, e) => ThrowEvent("PeriodValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Period(this);
		}

		#endregion

	}

	#endregion

	#region Class: Period_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class Period_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.Period_CrtBaseEventsProcess<TEntity> where TEntity : Period
	{

		public Period_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Period_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b31b7e94-eee5-4b8e-ae9d-a5c48c1ba131");
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

	#region Class: Period_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class Period_CrtBaseFinservEventsProcess : Period_CrtBaseFinservEventsProcess<Period>
	{

		public Period_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Period_CrtBaseFinservEventsProcess

	public partial class Period_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PeriodEventsProcess

	/// <exclude/>
	public class PeriodEventsProcess : Period_CrtBaseFinservEventsProcess
	{

		public PeriodEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

