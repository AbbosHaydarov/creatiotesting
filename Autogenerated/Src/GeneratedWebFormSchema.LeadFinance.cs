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

	#region Class: GeneratedWebFormSchema

	/// <exclude/>
	public class GeneratedWebFormSchema : Terrasoft.Configuration.GeneratedWebForm_CrtEngagementToolsApp_TerrasoftSchema
	{

		#region Constructors: Public

		public GeneratedWebFormSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public GeneratedWebFormSchema(GeneratedWebFormSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public GeneratedWebFormSchema(GeneratedWebFormSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("40df8df0-6755-4d09-8945-e36c690dd359");
			Name = "GeneratedWebForm";
			ParentSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1969e22c-6ec5-4e43-96b6-d405d5090755");
			IsDBView = false;
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
			return new GeneratedWebForm(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new GeneratedWebForm_LeadFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new GeneratedWebFormSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new GeneratedWebFormSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40df8df0-6755-4d09-8945-e36c690dd359"));
		}

		#endregion

	}

	#endregion

	#region Class: GeneratedWebForm

	/// <summary>
	/// Landing page (web form).
	/// </summary>
	public class GeneratedWebForm : Terrasoft.Configuration.GeneratedWebForm_CrtEngagementToolsApp_Terrasoft
	{

		#region Constructors: Public

		public GeneratedWebForm(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "GeneratedWebForm";
		}

		public GeneratedWebForm(GeneratedWebForm source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new GeneratedWebForm_LeadFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("GeneratedWebFormDeleted", e);
			Validating += (s, e) => ThrowEvent("GeneratedWebFormValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GeneratedWebForm(this);
		}

		#endregion

	}

	#endregion

	#region Class: GeneratedWebForm_LeadFinanceEventsProcess

	/// <exclude/>
	public partial class GeneratedWebForm_LeadFinanceEventsProcess<TEntity> : Terrasoft.Configuration.GeneratedWebForm_CrtEngagementToolsAppEventsProcess<TEntity> where TEntity : GeneratedWebForm
	{

		public GeneratedWebForm_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "GeneratedWebForm_LeadFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("40df8df0-6755-4d09-8945-e36c690dd359");
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

	#region Class: GeneratedWebForm_LeadFinanceEventsProcess

	/// <exclude/>
	public class GeneratedWebForm_LeadFinanceEventsProcess : GeneratedWebForm_LeadFinanceEventsProcess<GeneratedWebForm>
	{

		public GeneratedWebForm_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: GeneratedWebForm_LeadFinanceEventsProcess

	public partial class GeneratedWebForm_LeadFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: GeneratedWebFormEventsProcess

	/// <exclude/>
	public class GeneratedWebFormEventsProcess : GeneratedWebForm_LeadFinanceEventsProcess
	{

		public GeneratedWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

