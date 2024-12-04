﻿namespace Terrasoft.Configuration
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

	#region Class: CopilotSessionStateEntSchema

	/// <exclude/>
	public class CopilotSessionStateEntSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CopilotSessionStateEntSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CopilotSessionStateEntSchema(CopilotSessionStateEntSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CopilotSessionStateEntSchema(CopilotSessionStateEntSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("79789d7f-8b37-4493-a2a9-59e18fab8058");
			RealUId = new Guid("79789d7f-8b37-4493-a2a9-59e18fab8058");
			Name = "CopilotSessionStateEnt";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7a3a8162-4be1-46b5-bd50-b3efc2df6d2e");
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
			return new CopilotSessionStateEnt(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CopilotSessionStateEnt_CrtCopilotEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CopilotSessionStateEntSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CopilotSessionStateEntSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79789d7f-8b37-4493-a2a9-59e18fab8058"));
		}

		#endregion

	}

	#endregion

	#region Class: CopilotSessionStateEnt

	/// <summary>
	/// Copilot Session state.
	/// </summary>
	public class CopilotSessionStateEnt : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CopilotSessionStateEnt(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CopilotSessionStateEnt";
		}

		public CopilotSessionStateEnt(CopilotSessionStateEnt source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CopilotSessionStateEnt_CrtCopilotEventsProcess(UserConnection);
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
			return new CopilotSessionStateEnt(this);
		}

		#endregion

	}

	#endregion

	#region Class: CopilotSessionStateEnt_CrtCopilotEventsProcess

	/// <exclude/>
	public partial class CopilotSessionStateEnt_CrtCopilotEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : CopilotSessionStateEnt
	{

		public CopilotSessionStateEnt_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CopilotSessionStateEnt_CrtCopilotEventsProcess";
			SchemaUId = new Guid("79789d7f-8b37-4493-a2a9-59e18fab8058");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("79789d7f-8b37-4493-a2a9-59e18fab8058");
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

	#region Class: CopilotSessionStateEnt_CrtCopilotEventsProcess

	/// <exclude/>
	public class CopilotSessionStateEnt_CrtCopilotEventsProcess : CopilotSessionStateEnt_CrtCopilotEventsProcess<CopilotSessionStateEnt>
	{

		public CopilotSessionStateEnt_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CopilotSessionStateEnt_CrtCopilotEventsProcess

	public partial class CopilotSessionStateEnt_CrtCopilotEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CopilotSessionStateEntEventsProcess

	/// <exclude/>
	public class CopilotSessionStateEntEventsProcess : CopilotSessionStateEnt_CrtCopilotEventsProcess
	{

		public CopilotSessionStateEntEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

