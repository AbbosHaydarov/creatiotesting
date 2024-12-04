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

	#region Class: Event_CrtEventMarketingApp_TerrasoftSchema

	/// <exclude/>
	public class Event_CrtEventMarketingApp_TerrasoftSchema : Terrasoft.Configuration.Event_CrtEvent_TerrasoftSchema
	{

		#region Constructors: Public

		public Event_CrtEventMarketingApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Event_CrtEventMarketingApp_TerrasoftSchema(Event_CrtEventMarketingApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Event_CrtEventMarketingApp_TerrasoftSchema(Event_CrtEventMarketingApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("cd5d360c-d90f-4e19-aaf8-c29b23a40bd8");
			Name = "Event_CrtEventMarketingApp_Terrasoft";
			ParentSchemaUId = new Guid("5b4fdfc7-12b6-4b4f-a9bd-b6f1b6e4447f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b132060c-2bb9-46b7-94a0-5a96d67de713");
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
			return new Event_CrtEventMarketingApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Event_CrtEventMarketingAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Event_CrtEventMarketingApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Event_CrtEventMarketingApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd5d360c-d90f-4e19-aaf8-c29b23a40bd8"));
		}

		#endregion

	}

	#endregion

	#region Class: Event_CrtEventMarketingApp_Terrasoft

	/// <summary>
	/// Event.
	/// </summary>
	public class Event_CrtEventMarketingApp_Terrasoft : Terrasoft.Configuration.Event_CrtEvent_Terrasoft
	{

		#region Constructors: Public

		public Event_CrtEventMarketingApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Event_CrtEventMarketingApp_Terrasoft";
		}

		public Event_CrtEventMarketingApp_Terrasoft(Event_CrtEventMarketingApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Event_CrtEventMarketingAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Event_CrtEventMarketingApp_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Event_CrtEventMarketingApp_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Event_CrtEventMarketingApp_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Event_CrtEventMarketingApp_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Event_CrtEventMarketingApp_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Event_CrtEventMarketingApp_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Event_CrtEventMarketingApp_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Event_CrtEventMarketingApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Event_CrtEventMarketingAppEventsProcess

	/// <exclude/>
	public partial class Event_CrtEventMarketingAppEventsProcess<TEntity> : Terrasoft.Configuration.Event_CrtEventEventsProcess<TEntity> where TEntity : Event_CrtEventMarketingApp_Terrasoft
	{

		public Event_CrtEventMarketingAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Event_CrtEventMarketingAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cd5d360c-d90f-4e19-aaf8-c29b23a40bd8");
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

	#region Class: Event_CrtEventMarketingAppEventsProcess

	/// <exclude/>
	public class Event_CrtEventMarketingAppEventsProcess : Event_CrtEventMarketingAppEventsProcess<Event_CrtEventMarketingApp_Terrasoft>
	{

		public Event_CrtEventMarketingAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Event_CrtEventMarketingAppEventsProcess

	public partial class Event_CrtEventMarketingAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

