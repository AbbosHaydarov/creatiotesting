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

	#region Class: EmploymentTypeSchema

	/// <exclude/>
	public class EmploymentTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public EmploymentTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmploymentTypeSchema(EmploymentTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmploymentTypeSchema(EmploymentTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08");
			RealUId = new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08");
			Name = "EmploymentType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6");
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
			return new EmploymentType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmploymentType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmploymentTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmploymentTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08"));
		}

		#endregion

	}

	#endregion

	#region Class: EmploymentType

	/// <summary>
	/// Type of employment.
	/// </summary>
	public class EmploymentType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public EmploymentType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmploymentType";
		}

		public EmploymentType(EmploymentType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmploymentType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmploymentTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("EmploymentTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmploymentType(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmploymentType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class EmploymentType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : EmploymentType
	{

		public EmploymentType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmploymentType_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08");
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

	#region Class: EmploymentType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class EmploymentType_CrtBaseFinservEventsProcess : EmploymentType_CrtBaseFinservEventsProcess<EmploymentType>
	{

		public EmploymentType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmploymentType_CrtBaseFinservEventsProcess

	public partial class EmploymentType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmploymentTypeEventsProcess

	/// <exclude/>
	public class EmploymentTypeEventsProcess : EmploymentType_CrtBaseFinservEventsProcess
	{

		public EmploymentTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

