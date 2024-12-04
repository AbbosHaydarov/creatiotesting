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

	#region Class: SchedulerExpressionSchema

	/// <exclude/>
	public class SchedulerExpressionSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SchedulerExpressionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SchedulerExpressionSchema(SchedulerExpressionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SchedulerExpressionSchema(SchedulerExpressionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9");
			RealUId = new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9");
			Name = "SchedulerExpression";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0005499f-90c6-4ac9-96af-1b39c32e921e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("efe6fbf6-f062-48d8-9ce3-e8deb8db2047")) == null) {
				Columns.Add(CreateExpressionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateExpressionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("efe6fbf6-f062-48d8-9ce3-e8deb8db2047"),
				Name = @"Expression",
				CreatedInSchemaUId = new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9"),
				ModifiedInSchemaUId = new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9"),
				CreatedInPackageId = new Guid("0005499f-90c6-4ac9-96af-1b39c32e921e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SchedulerExpression(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SchedulerExpression_ProcessSchedulerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SchedulerExpressionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SchedulerExpressionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9"));
		}

		#endregion

	}

	#endregion

	#region Class: SchedulerExpression

	/// <summary>
	/// Scheduler expression.
	/// </summary>
	public class SchedulerExpression : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SchedulerExpression(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SchedulerExpression";
		}

		public SchedulerExpression(SchedulerExpression source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Calendar.
		/// </summary>
		public string Expression {
			get {
				return GetTypedColumnValue<string>("Expression");
			}
			set {
				SetColumnValue("Expression", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SchedulerExpression_ProcessSchedulerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SchedulerExpressionDeleted", e);
			Validating += (s, e) => ThrowEvent("SchedulerExpressionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SchedulerExpression(this);
		}

		#endregion

	}

	#endregion

	#region Class: SchedulerExpression_ProcessSchedulerEventsProcess

	/// <exclude/>
	public partial class SchedulerExpression_ProcessSchedulerEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : SchedulerExpression
	{

		public SchedulerExpression_ProcessSchedulerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SchedulerExpression_ProcessSchedulerEventsProcess";
			SchemaUId = new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4e79775f-f603-4e20-976c-b3c5d26336a9");
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

	#region Class: SchedulerExpression_ProcessSchedulerEventsProcess

	/// <exclude/>
	public class SchedulerExpression_ProcessSchedulerEventsProcess : SchedulerExpression_ProcessSchedulerEventsProcess<SchedulerExpression>
	{

		public SchedulerExpression_ProcessSchedulerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SchedulerExpression_ProcessSchedulerEventsProcess

	public partial class SchedulerExpression_ProcessSchedulerEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SchedulerExpressionEventsProcess

	/// <exclude/>
	public class SchedulerExpressionEventsProcess : SchedulerExpression_ProcessSchedulerEventsProcess
	{

		public SchedulerExpressionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

