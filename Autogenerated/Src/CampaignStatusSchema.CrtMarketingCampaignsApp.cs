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

	#region Class: CampaignStatusSchema

	/// <exclude/>
	public class CampaignStatusSchema : Terrasoft.Configuration.CampaignStatus_CrtCampaign_TerrasoftSchema
	{

		#region Constructors: Public

		public CampaignStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignStatusSchema(CampaignStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignStatusSchema(CampaignStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9769babc-e4e7-44f0-bb7e-757a8d2c6ad9");
			Name = "CampaignStatus";
			ParentSchemaUId = new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("de74af10-d5ed-4327-b369-7953ce3cc64e");
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
				UId = new Guid("e263ccf6-37e3-769d-ac19-5e6c49801d55"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("9769babc-e4e7-44f0-bb7e-757a8d2c6ad9"),
				ModifiedInSchemaUId = new Guid("9769babc-e4e7-44f0-bb7e-757a8d2c6ad9"),
				CreatedInPackageId = new Guid("de74af10-d5ed-4327-b369-7953ce3cc64e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignStatus_CrtMarketingCampaignsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9769babc-e4e7-44f0-bb7e-757a8d2c6ad9"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStatus

	/// <summary>
	/// Campaign status.
	/// </summary>
	public class CampaignStatus : Terrasoft.Configuration.CampaignStatus_CrtCampaign_Terrasoft
	{

		#region Constructors: Public

		public CampaignStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignStatus";
		}

		public CampaignStatus(CampaignStatus source)
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
			var process = new CampaignStatus_CrtMarketingCampaignsAppEventsProcess(UserConnection);
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
			return new CampaignStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStatus_CrtMarketingCampaignsAppEventsProcess

	/// <exclude/>
	public partial class CampaignStatus_CrtMarketingCampaignsAppEventsProcess<TEntity> : Terrasoft.Configuration.CampaignStatus_CrtCampaignEventsProcess<TEntity> where TEntity : CampaignStatus
	{

		public CampaignStatus_CrtMarketingCampaignsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignStatus_CrtMarketingCampaignsAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9769babc-e4e7-44f0-bb7e-757a8d2c6ad9");
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

	#region Class: CampaignStatus_CrtMarketingCampaignsAppEventsProcess

	/// <exclude/>
	public class CampaignStatus_CrtMarketingCampaignsAppEventsProcess : CampaignStatus_CrtMarketingCampaignsAppEventsProcess<CampaignStatus>
	{

		public CampaignStatus_CrtMarketingCampaignsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignStatus_CrtMarketingCampaignsAppEventsProcess

	public partial class CampaignStatus_CrtMarketingCampaignsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignStatusEventsProcess

	/// <exclude/>
	public class CampaignStatusEventsProcess : CampaignStatus_CrtMarketingCampaignsAppEventsProcess
	{

		public CampaignStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

