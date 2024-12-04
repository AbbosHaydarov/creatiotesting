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

	#region Class: LeadFolderSchema

	/// <exclude/>
	public class LeadFolderSchema : Terrasoft.Configuration.LeadFolder_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadFolderSchema(LeadFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadFolderSchema(LeadFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("81bab5f3-54e4-4282-86f2-cb4c718abdc7");
			Name = "LeadFolder";
			ParentSchemaUId = new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
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

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("81bab5f3-54e4-4282-86f2-cb4c718abdc7");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadFolder_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81bab5f3-54e4-4282-86f2-cb4c718abdc7"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadFolder

	/// <summary>
	/// Lead folder.
	/// </summary>
	public class LeadFolder : Terrasoft.Configuration.LeadFolder_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public LeadFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadFolder";
		}

		public LeadFolder(LeadFolder source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadFolder_LeadEventsProcess(UserConnection);
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
			return new LeadFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadFolder_LeadEventsProcess

	/// <exclude/>
	public partial class LeadFolder_LeadEventsProcess<TEntity> : Terrasoft.Configuration.LeadFolder_CrtLeadEventsProcess<TEntity> where TEntity : LeadFolder
	{

		public LeadFolder_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadFolder_LeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("81bab5f3-54e4-4282-86f2-cb4c718abdc7");
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

	#region Class: LeadFolder_LeadEventsProcess

	/// <exclude/>
	public class LeadFolder_LeadEventsProcess : LeadFolder_LeadEventsProcess<LeadFolder>
	{

		public LeadFolder_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: LeadFolderEventsProcess

	/// <exclude/>
	public class LeadFolderEventsProcess : LeadFolder_LeadEventsProcess
	{

		public LeadFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

