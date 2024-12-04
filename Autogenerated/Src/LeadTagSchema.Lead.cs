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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: LeadTagSchema

	/// <exclude/>
	public class LeadTagSchema : Terrasoft.Configuration.LeadTag_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadTagSchema(LeadTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadTagSchema(LeadTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("bb558624-b8cd-4264-9541-7f772c92ab34");
			Name = "LeadTag";
			ParentSchemaUId = new Guid("be1059c6-63ff-4c7a-805a-697b2358b245");
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
			return new LeadTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadTag_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb558624-b8cd-4264-9541-7f772c92ab34"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadTag

	/// <summary>
	/// Leads section tag.
	/// </summary>
	public class LeadTag : Terrasoft.Configuration.LeadTag_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public LeadTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadTag";
		}

		public LeadTag(LeadTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadTag_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadTagDeleted", e);
			Deleting += (s, e) => ThrowEvent("LeadTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("LeadTagInserted", e);
			Inserting += (s, e) => ThrowEvent("LeadTagInserting", e);
			Saved += (s, e) => ThrowEvent("LeadTagSaved", e);
			Saving += (s, e) => ThrowEvent("LeadTagSaving", e);
			Validating += (s, e) => ThrowEvent("LeadTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadTag_LeadEventsProcess

	/// <exclude/>
	public partial class LeadTag_LeadEventsProcess<TEntity> : Terrasoft.Configuration.LeadTag_CrtLeadEventsProcess<TEntity> where TEntity : LeadTag
	{

		public LeadTag_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadTag_LeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bb558624-b8cd-4264-9541-7f772c92ab34");
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

	#region Class: LeadTag_LeadEventsProcess

	/// <exclude/>
	public class LeadTag_LeadEventsProcess : LeadTag_LeadEventsProcess<LeadTag>
	{

		public LeadTag_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: LeadTagEventsProcess

	/// <exclude/>
	public class LeadTagEventsProcess : LeadTag_LeadEventsProcess
	{

		public LeadTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

