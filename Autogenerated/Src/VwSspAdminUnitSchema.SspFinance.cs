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

	#region Class: VwSspAdminUnitSchema

	/// <exclude/>
	public class VwSspAdminUnitSchema : Terrasoft.Configuration.VwSspAdminUnit_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSspAdminUnitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSspAdminUnitSchema(VwSspAdminUnitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSspAdminUnitSchema(VwSspAdminUnitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3769cb11-da16-4d48-903c-bc14ddcaea4e");
			Name = "VwSspAdminUnit";
			ParentSchemaUId = new Guid("83d6c406-8e3c-4ef3-ac23-522d7026aa4e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fc1b287f-93d6-4bb2-ad79-b31901dd2c29");
			IsDBView = true;
			UseDenyRecordRights = false;
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
			return new VwSspAdminUnit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSspAdminUnit_SspFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSspAdminUnitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSspAdminUnitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3769cb11-da16-4d48-903c-bc14ddcaea4e"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSspAdminUnit

	/// <summary>
	/// VwSspAdminUnit.
	/// </summary>
	public class VwSspAdminUnit : Terrasoft.Configuration.VwSspAdminUnit_SSP_Terrasoft
	{

		#region Constructors: Public

		public VwSspAdminUnit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSspAdminUnit";
		}

		public VwSspAdminUnit(VwSspAdminUnit source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSspAdminUnit_SspFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSspAdminUnit(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSspAdminUnit_SspFinanceEventsProcess

	/// <exclude/>
	public partial class VwSspAdminUnit_SspFinanceEventsProcess<TEntity> : Terrasoft.Configuration.VwSspAdminUnit_SSPEventsProcess<TEntity> where TEntity : VwSspAdminUnit
	{

		public VwSspAdminUnit_SspFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSspAdminUnit_SspFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3769cb11-da16-4d48-903c-bc14ddcaea4e");
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

	#region Class: VwSspAdminUnit_SspFinanceEventsProcess

	/// <exclude/>
	public class VwSspAdminUnit_SspFinanceEventsProcess : VwSspAdminUnit_SspFinanceEventsProcess<VwSspAdminUnit>
	{

		public VwSspAdminUnit_SspFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSspAdminUnit_SspFinanceEventsProcess

	public partial class VwSspAdminUnit_SspFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSspAdminUnitEventsProcess

	/// <exclude/>
	public class VwSspAdminUnitEventsProcess : VwSspAdminUnit_SspFinanceEventsProcess
	{

		public VwSspAdminUnitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

