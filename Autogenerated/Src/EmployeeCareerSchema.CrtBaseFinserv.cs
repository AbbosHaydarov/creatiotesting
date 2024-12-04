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

	#region Class: EmployeeCareerSchema

	/// <exclude/>
	public class EmployeeCareerSchema : Terrasoft.Configuration.EmployeeCareer_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public EmployeeCareerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmployeeCareerSchema(EmployeeCareerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmployeeCareerSchema(EmployeeCareerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ed6aac53-72e2-4615-a340-1f14d5b6958b");
			Name = "EmployeeCareer";
			ParentSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738");
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
			return new EmployeeCareer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmployeeCareer_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmployeeCareerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmployeeCareerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed6aac53-72e2-4615-a340-1f14d5b6958b"));
		}

		#endregion

	}

	#endregion

	#region Class: EmployeeCareer

	/// <summary>
	/// Employee career in our company.
	/// </summary>
	public class EmployeeCareer : Terrasoft.Configuration.EmployeeCareer_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public EmployeeCareer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmployeeCareer";
		}

		public EmployeeCareer(EmployeeCareer source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmployeeCareer_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("EmployeeCareerDeleting", e);
			Inserted += (s, e) => ThrowEvent("EmployeeCareerInserted", e);
			Inserting += (s, e) => ThrowEvent("EmployeeCareerInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmployeeCareer(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmployeeCareer_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class EmployeeCareer_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.EmployeeCareer_CrtBaseEventsProcess<TEntity> where TEntity : EmployeeCareer
	{

		public EmployeeCareer_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmployeeCareer_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ed6aac53-72e2-4615-a340-1f14d5b6958b");
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

	#region Class: EmployeeCareer_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class EmployeeCareer_CrtBaseFinservEventsProcess : EmployeeCareer_CrtBaseFinservEventsProcess<EmployeeCareer>
	{

		public EmployeeCareer_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmployeeCareer_CrtBaseFinservEventsProcess

	public partial class EmployeeCareer_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmployeeCareerEventsProcess

	/// <exclude/>
	public class EmployeeCareerEventsProcess : EmployeeCareer_CrtBaseFinservEventsProcess
	{

		public EmployeeCareerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

