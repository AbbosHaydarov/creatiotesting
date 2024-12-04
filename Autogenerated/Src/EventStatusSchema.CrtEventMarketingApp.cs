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

	#region Class: EventStatusSchema

	/// <exclude/>
	public class EventStatusSchema : Terrasoft.Configuration.EventStatus_CrtEvent_TerrasoftSchema
	{

		#region Constructors: Public

		public EventStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EventStatusSchema(EventStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EventStatusSchema(EventStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("19cd22d1-d3c7-4a91-be24-0c9e4655b9c4");
			Name = "EventStatus";
			ParentSchemaUId = new Guid("b52918af-f05e-4251-985a-7877360e1e02");
			ExtendParent = true;
			CreatedInPackageId = new Guid("7331647a-1c5f-4876-8529-de4570a5b177");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("cd507cda-74ca-db52-18f8-c6a09ec789d7"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("19cd22d1-d3c7-4a91-be24-0c9e4655b9c4"),
				ModifiedInSchemaUId = new Guid("19cd22d1-d3c7-4a91-be24-0c9e4655b9c4"),
				CreatedInPackageId = new Guid("7331647a-1c5f-4876-8529-de4570a5b177")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EventStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EventStatus_CrtEventMarketingAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EventStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EventStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19cd22d1-d3c7-4a91-be24-0c9e4655b9c4"));
		}

		#endregion

	}

	#endregion

	#region Class: EventStatus

	/// <summary>
	/// Event status.
	/// </summary>
	public class EventStatus : Terrasoft.Configuration.EventStatus_CrtEvent_Terrasoft
	{

		#region Constructors: Public

		public EventStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EventStatus";
		}

		public EventStatus(EventStatus source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EventStatus_CrtEventMarketingAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("EventStatusDeleting", e);
			Inserted += (s, e) => ThrowEvent("EventStatusInserted", e);
			Saved += (s, e) => ThrowEvent("EventStatusSaved", e);
			Saving += (s, e) => ThrowEvent("EventStatusSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EventStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: EventStatus_CrtEventMarketingAppEventsProcess

	/// <exclude/>
	public partial class EventStatus_CrtEventMarketingAppEventsProcess<TEntity> : Terrasoft.Configuration.EventStatus_CrtEventEventsProcess<TEntity> where TEntity : EventStatus
	{

		public EventStatus_CrtEventMarketingAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EventStatus_CrtEventMarketingAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("19cd22d1-d3c7-4a91-be24-0c9e4655b9c4");
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

	#region Class: EventStatus_CrtEventMarketingAppEventsProcess

	/// <exclude/>
	public class EventStatus_CrtEventMarketingAppEventsProcess : EventStatus_CrtEventMarketingAppEventsProcess<EventStatus>
	{

		public EventStatus_CrtEventMarketingAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EventStatus_CrtEventMarketingAppEventsProcess

	public partial class EventStatus_CrtEventMarketingAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EventStatusEventsProcess

	/// <exclude/>
	public class EventStatusEventsProcess : EventStatus_CrtEventMarketingAppEventsProcess
	{

		public EventStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

