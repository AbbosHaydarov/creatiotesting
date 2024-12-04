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

	#region Class: CampaignStatus_CrtCampaign_TerrasoftSchema

	/// <exclude/>
	public class CampaignStatus_CrtCampaign_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CampaignStatus_CrtCampaign_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignStatus_CrtCampaign_TerrasoftSchema(CampaignStatus_CrtCampaign_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignStatus_CrtCampaign_TerrasoftSchema(CampaignStatus_CrtCampaign_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5");
			RealUId = new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5");
			Name = "CampaignStatus_CrtCampaign_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new CampaignStatus_CrtCampaign_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignStatus_CrtCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignStatus_CrtCampaign_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignStatus_CrtCampaign_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStatus_CrtCampaign_Terrasoft

	/// <summary>
	/// Campaign status.
	/// </summary>
	public class CampaignStatus_CrtCampaign_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CampaignStatus_CrtCampaign_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignStatus_CrtCampaign_Terrasoft";
		}

		public CampaignStatus_CrtCampaign_Terrasoft(CampaignStatus_CrtCampaign_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignStatus_CrtCampaignEventsProcess(UserConnection);
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
			return new CampaignStatus_CrtCampaign_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStatus_CrtCampaignEventsProcess

	/// <exclude/>
	public partial class CampaignStatus_CrtCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : CampaignStatus_CrtCampaign_Terrasoft
	{

		public CampaignStatus_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignStatus_CrtCampaignEventsProcess";
			SchemaUId = new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5");
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

	#region Class: CampaignStatus_CrtCampaignEventsProcess

	/// <exclude/>
	public class CampaignStatus_CrtCampaignEventsProcess : CampaignStatus_CrtCampaignEventsProcess<CampaignStatus_CrtCampaign_Terrasoft>
	{

		public CampaignStatus_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignStatus_CrtCampaignEventsProcess

	public partial class CampaignStatus_CrtCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

