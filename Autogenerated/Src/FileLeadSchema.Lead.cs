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
	using Terrasoft.Configuration;
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

	#region Class: FileLeadSchema

	/// <exclude/>
	public class FileLeadSchema : Terrasoft.Configuration.FileLead_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public FileLeadSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FileLeadSchema(FileLeadSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FileLeadSchema(FileLeadSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("99a7e52b-de3c-453a-9bad-7c026d1079c0");
			Name = "FileLead";
			ParentSchemaUId = new Guid("d95c76f6-64bc-444c-9bfc-1b9cfd4f06e0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new FileLead(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FileLead_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FileLeadSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FileLeadSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99a7e52b-de3c-453a-9bad-7c026d1079c0"));
		}

		#endregion

	}

	#endregion

	#region Class: FileLead

	/// <summary>
	/// Lead attachment.
	/// </summary>
	public class FileLead : Terrasoft.Configuration.FileLead_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public FileLead(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FileLead";
		}

		public FileLead(FileLead source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FileLead_LeadEventsProcess(UserConnection);
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
			return new FileLead(this);
		}

		#endregion

	}

	#endregion

	#region Class: FileLead_LeadEventsProcess

	/// <exclude/>
	public partial class FileLead_LeadEventsProcess<TEntity> : Terrasoft.Configuration.FileLead_CrtLeadEventsProcess<TEntity> where TEntity : FileLead
	{

		public FileLead_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FileLead_LeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("99a7e52b-de3c-453a-9bad-7c026d1079c0");
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

	#region Class: FileLead_LeadEventsProcess

	/// <exclude/>
	public class FileLead_LeadEventsProcess : FileLead_LeadEventsProcess<FileLead>
	{

		public FileLead_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: FileLeadEventsProcess

	/// <exclude/>
	public class FileLeadEventsProcess : FileLead_LeadEventsProcess
	{

		public FileLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

