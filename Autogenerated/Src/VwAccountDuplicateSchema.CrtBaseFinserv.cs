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

	#region Class: VwAccountDuplicateSchema

	/// <exclude/>
	public class VwAccountDuplicateSchema : Terrasoft.Configuration.VwAccountDuplicate_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public VwAccountDuplicateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAccountDuplicateSchema(VwAccountDuplicateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAccountDuplicateSchema(VwAccountDuplicateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e26bc942-2048-44af-a53a-d24f3971551f");
			Name = "VwAccountDuplicate";
			ParentSchemaUId = new Guid("80cf3d69-0e4b-47fc-a0d6-e62acc462de6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("42c464a9-9677-4bbd-86c1-308caea3de84");
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
			return new VwAccountDuplicate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAccountDuplicate_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAccountDuplicateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAccountDuplicateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e26bc942-2048-44af-a53a-d24f3971551f"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountDuplicate

	/// <summary>
	/// Legal entity duplicate (view).
	/// </summary>
	public class VwAccountDuplicate : Terrasoft.Configuration.VwAccountDuplicate_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public VwAccountDuplicate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAccountDuplicate";
		}

		public VwAccountDuplicate(VwAccountDuplicate source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAccountDuplicate_CrtBaseFinservEventsProcess(UserConnection);
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
			return new VwAccountDuplicate(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountDuplicate_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class VwAccountDuplicate_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.VwAccountDuplicate_CrtBaseEventsProcess<TEntity> where TEntity : VwAccountDuplicate
	{

		public VwAccountDuplicate_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAccountDuplicate_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e26bc942-2048-44af-a53a-d24f3971551f");
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

	#region Class: VwAccountDuplicate_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class VwAccountDuplicate_CrtBaseFinservEventsProcess : VwAccountDuplicate_CrtBaseFinservEventsProcess<VwAccountDuplicate>
	{

		public VwAccountDuplicate_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAccountDuplicate_CrtBaseFinservEventsProcess

	public partial class VwAccountDuplicate_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwAccountDuplicateEventsProcess

	/// <exclude/>
	public class VwAccountDuplicateEventsProcess : VwAccountDuplicate_CrtBaseFinservEventsProcess
	{

		public VwAccountDuplicateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

