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
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Nui.ServiceModel.WebService;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Campaign_CrtMarketingCampaignsApp_TerrasoftSchema

	/// <exclude/>
	public class Campaign_CrtMarketingCampaignsApp_TerrasoftSchema : Terrasoft.Configuration.Campaign_CrtCampaign_TerrasoftSchema
	{

		#region Constructors: Public

		public Campaign_CrtMarketingCampaignsApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Campaign_CrtMarketingCampaignsApp_TerrasoftSchema(Campaign_CrtMarketingCampaignsApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Campaign_CrtMarketingCampaignsApp_TerrasoftSchema(Campaign_CrtMarketingCampaignsApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6dbb58ec-b602-4ce4-a20a-116dbde7f90f");
			Name = "Campaign_CrtMarketingCampaignsApp_Terrasoft";
			ParentSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			ExtendParent = true;
			CreatedInPackageId = new Guid("468945b7-7281-4366-be7c-f82022576bab");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new Campaign_CrtMarketingCampaignsApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Campaign_CrtMarketingCampaignsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Campaign_CrtMarketingCampaignsApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Campaign_CrtMarketingCampaignsApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6dbb58ec-b602-4ce4-a20a-116dbde7f90f"));
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CrtMarketingCampaignsApp_Terrasoft

	/// <summary>
	/// Campaign.
	/// </summary>
	public class Campaign_CrtMarketingCampaignsApp_Terrasoft : Terrasoft.Configuration.Campaign_CrtCampaign_Terrasoft
	{

		#region Constructors: Public

		public Campaign_CrtMarketingCampaignsApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Campaign_CrtMarketingCampaignsApp_Terrasoft";
		}

		public Campaign_CrtMarketingCampaignsApp_Terrasoft(Campaign_CrtMarketingCampaignsApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Campaign_CrtMarketingCampaignsAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Campaign_CrtMarketingCampaignsApp_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Campaign_CrtMarketingCampaignsApp_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Campaign_CrtMarketingCampaignsApp_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Campaign_CrtMarketingCampaignsApp_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Campaign_CrtMarketingCampaignsApp_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Campaign_CrtMarketingCampaignsApp_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Campaign_CrtMarketingCampaignsApp_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Campaign_CrtMarketingCampaignsApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CrtMarketingCampaignsAppEventsProcess

	/// <exclude/>
	public partial class Campaign_CrtMarketingCampaignsAppEventsProcess<TEntity> : Terrasoft.Configuration.Campaign_CrtCampaignEventsProcess<TEntity> where TEntity : Campaign_CrtMarketingCampaignsApp_Terrasoft
	{

		public Campaign_CrtMarketingCampaignsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Campaign_CrtMarketingCampaignsAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6dbb58ec-b602-4ce4-a20a-116dbde7f90f");
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

	#region Class: Campaign_CrtMarketingCampaignsAppEventsProcess

	/// <exclude/>
	public class Campaign_CrtMarketingCampaignsAppEventsProcess : Campaign_CrtMarketingCampaignsAppEventsProcess<Campaign_CrtMarketingCampaignsApp_Terrasoft>
	{

		public Campaign_CrtMarketingCampaignsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Campaign_CrtMarketingCampaignsAppEventsProcess

	public partial class Campaign_CrtMarketingCampaignsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

