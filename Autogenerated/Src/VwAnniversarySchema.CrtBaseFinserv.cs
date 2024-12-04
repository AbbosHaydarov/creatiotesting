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

	#region Class: VwAnniversarySchema

	/// <exclude/>
	public class VwAnniversarySchema : Terrasoft.Configuration.VwAnniversary_CrtNUI_TerrasoftSchema
	{

		#region Constructors: Public

		public VwAnniversarySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAnniversarySchema(VwAnniversarySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAnniversarySchema(VwAnniversarySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5ae907d0-6cad-4219-b18f-1516acd23d87");
			Name = "VwAnniversary";
			ParentSchemaUId = new Guid("303f5779-e867-4e1c-8fdc-e4768f15b4eb");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
			IsDBView = true;
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
			return new VwAnniversary(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAnniversary_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAnniversarySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAnniversarySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ae907d0-6cad-4219-b18f-1516acd23d87"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAnniversary

	/// <summary>
	/// Noteworthy event.
	/// </summary>
	public class VwAnniversary : Terrasoft.Configuration.VwAnniversary_CrtNUI_Terrasoft
	{

		#region Constructors: Public

		public VwAnniversary(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAnniversary";
		}

		public VwAnniversary(VwAnniversary source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAnniversary_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwAnniversaryDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwAnniversaryDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwAnniversaryInserted", e);
			Saved += (s, e) => ThrowEvent("VwAnniversarySaved", e);
			Saving += (s, e) => ThrowEvent("VwAnniversarySaving", e);
			Validating += (s, e) => ThrowEvent("VwAnniversaryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAnniversary(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAnniversary_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwAnniversary_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwAnniversary_CrtNUIEventsProcess<TEntity> where TEntity : VwAnniversary
	{

		public VwAnniversary_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAnniversary_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ae907d0-6cad-4219-b18f-1516acd23d87");
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

	#region Class: VwAnniversary_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwAnniversary_CrtBaseFinservEventsProcess : VwAnniversary_CrtBaseFinservEventsProcess<VwAnniversary>
	{

		public VwAnniversary_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAnniversary_CrtBaseFinservEventsProcess

	public partial class VwAnniversary_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwAnniversaryEventsProcess

	/// <exclude/>
	public class VwAnniversaryEventsProcess : VwAnniversary_CrtBaseFinservEventsProcess
	{

		public VwAnniversaryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

