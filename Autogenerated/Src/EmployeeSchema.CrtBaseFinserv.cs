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
	using Terrasoft.Configuration.EntitySynchronization;
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

	#region Class: EmployeeSchema

	/// <exclude/>
	public class EmployeeSchema : Terrasoft.Configuration.Employee_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public EmployeeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmployeeSchema(EmployeeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmployeeSchema(EmployeeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7697a8a6-805d-439d-8eda-213c07aad520");
			Name = "Employee";
			ParentSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			ExtendParent = true;
			CreatedInPackageId = new Guid("dfacab72-3dfa-448e-9d11-a09bd3373fb3");
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
			return new Employee(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Employee_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmployeeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmployeeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7697a8a6-805d-439d-8eda-213c07aad520"));
		}

		#endregion

	}

	#endregion

	#region Class: Employee

	/// <summary>
	/// Employee.
	/// </summary>
	public class Employee : Terrasoft.Configuration.Employee_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public Employee(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Employee";
		}

		public Employee(Employee source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Employee_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmployeeDeleted", e);
			Deleting += (s, e) => ThrowEvent("EmployeeDeleting", e);
			Validating += (s, e) => ThrowEvent("EmployeeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Employee(this);
		}

		#endregion

	}

	#endregion

	#region Class: Employee_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class Employee_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.Employee_CrtBaseEventsProcess<TEntity> where TEntity : Employee
	{

		public Employee_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Employee_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7697a8a6-805d-439d-8eda-213c07aad520");
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

	#region Class: Employee_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class Employee_CrtBaseFinservEventsProcess : Employee_CrtBaseFinservEventsProcess<Employee>
	{

		public Employee_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Employee_CrtBaseFinservEventsProcess

	public partial class Employee_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmployeeEventsProcess

	/// <exclude/>
	public class EmployeeEventsProcess : Employee_CrtBaseFinservEventsProcess
	{

		public EmployeeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

