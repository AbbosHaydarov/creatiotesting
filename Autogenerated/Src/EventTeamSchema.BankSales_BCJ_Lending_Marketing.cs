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

	#region Class: EventTeamSchema

	/// <exclude/>
	public class EventTeamSchema : Terrasoft.Configuration.EventTeam_CrtEvent_TerrasoftSchema
	{

		#region Constructors: Public

		public EventTeamSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EventTeamSchema(EventTeamSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EventTeamSchema(EventTeamSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("4fe85a6d-2516-490f-a232-04afb9268c2b");
			Name = "EventTeam";
			ParentSchemaUId = new Guid("a5a0dbe7-3622-4dba-bc06-154ebbfd330f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("76a3b911-520d-4e5a-aeef-480d6ce2314d");
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
			return new EventTeam(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EventTeamSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EventTeamSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4fe85a6d-2516-490f-a232-04afb9268c2b"));
		}

		#endregion

	}

	#endregion

	#region Class: EventTeam

	/// <summary>
	/// Event team member.
	/// </summary>
	public class EventTeam : Terrasoft.Configuration.EventTeam_CrtEvent_Terrasoft
	{

		#region Constructors: Public

		public EventTeam(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EventTeam";
		}

		public EventTeam(EventTeam source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection);
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
			return new EventTeam(this);
		}

		#endregion

	}

	#endregion

	#region Class: EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess

	/// <exclude/>
	public partial class EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess<TEntity> : Terrasoft.Configuration.EventTeam_CrtEventEventsProcess<TEntity> where TEntity : EventTeam
	{

		public EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4fe85a6d-2516-490f-a232-04afb9268c2b");
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

	#region Class: EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess

	/// <exclude/>
	public class EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess : EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess<EventTeam>
	{

		public EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess

	public partial class EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EventTeamEventsProcess

	/// <exclude/>
	public class EventTeamEventsProcess : EventTeam_BankSales_BCJ_Lending_MarketingEventsProcess
	{

		public EventTeamEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

