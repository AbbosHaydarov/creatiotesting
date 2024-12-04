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

	#region Class: WebAnalyticsAccStateSchema

	/// <exclude/>
	public class WebAnalyticsAccStateSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public WebAnalyticsAccStateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebAnalyticsAccStateSchema(WebAnalyticsAccStateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebAnalyticsAccStateSchema(WebAnalyticsAccStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283");
			RealUId = new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283");
			Name = "WebAnalyticsAccState";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
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
				UId = new Guid("7a13242f-c309-137d-2ec8-7b1420428d6c"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283"),
				ModifiedInSchemaUId = new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283"),
				CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebAnalyticsAccState(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebAnalyticsAccStateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebAnalyticsAccStateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283"));
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsAccState

	/// <summary>
	/// Web analytics account connection state.
	/// </summary>
	public class WebAnalyticsAccState : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public WebAnalyticsAccState(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsAccState";
		}

		public WebAnalyticsAccState(WebAnalyticsAccState source)
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
			var process = new WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new WebAnalyticsAccState(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : WebAnalyticsAccState
	{

		public WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1636ece3-55ad-4ef3-87e4-3a66253c4283");
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

	#region Class: WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess : WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess<WebAnalyticsAccState>
	{

		public WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess

	public partial class WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebAnalyticsAccStateEventsProcess

	/// <exclude/>
	public class WebAnalyticsAccStateEventsProcess : WebAnalyticsAccState_CrtWebTrackingBaseEventsProcess
	{

		public WebAnalyticsAccStateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

