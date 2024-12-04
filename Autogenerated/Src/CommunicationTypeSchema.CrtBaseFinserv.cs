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

	#region Class: CommunicationTypeSchema

	/// <exclude/>
	public class CommunicationTypeSchema : Terrasoft.Configuration.CommunicationType_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public CommunicationTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CommunicationTypeSchema(CommunicationTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CommunicationTypeSchema(CommunicationTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7609eba0-e13d-4bbc-a3c3-e3a68841bee6");
			Name = "CommunicationType";
			ParentSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873");
			ExtendParent = true;
			CreatedInPackageId = new Guid("27329051-b308-4a64-83ef-1a0f05a9ca5f");
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
			return new CommunicationType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CommunicationType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CommunicationTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CommunicationTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7609eba0-e13d-4bbc-a3c3-e3a68841bee6"));
		}

		#endregion

	}

	#endregion

	#region Class: CommunicationType

	/// <summary>
	/// Communication option type.
	/// </summary>
	public class CommunicationType : Terrasoft.Configuration.CommunicationType_SSP_Terrasoft
	{

		#region Constructors: Public

		public CommunicationType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CommunicationType";
		}

		public CommunicationType(CommunicationType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CommunicationType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CommunicationTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("CommunicationTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("CommunicationTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("CommunicationTypeInserting", e);
			Saved += (s, e) => ThrowEvent("CommunicationTypeSaved", e);
			Saving += (s, e) => ThrowEvent("CommunicationTypeSaving", e);
			Validating += (s, e) => ThrowEvent("CommunicationTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CommunicationType(this);
		}

		#endregion

	}

	#endregion

	#region Class: CommunicationType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class CommunicationType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.CommunicationType_SSPEventsProcess<TEntity> where TEntity : CommunicationType
	{

		public CommunicationType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CommunicationType_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7609eba0-e13d-4bbc-a3c3-e3a68841bee6");
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

	#region Class: CommunicationType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class CommunicationType_CrtBaseFinservEventsProcess : CommunicationType_CrtBaseFinservEventsProcess<CommunicationType>
	{

		public CommunicationType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CommunicationType_CrtBaseFinservEventsProcess

	public partial class CommunicationType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CommunicationTypeEventsProcess

	/// <exclude/>
	public class CommunicationTypeEventsProcess : CommunicationType_CrtBaseFinservEventsProcess
	{

		public CommunicationTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

