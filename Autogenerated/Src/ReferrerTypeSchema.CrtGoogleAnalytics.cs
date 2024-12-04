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

	#region Class: ReferrerType_CrtGoogleAnalytics_TerrasoftSchema

	/// <exclude/>
	public class ReferrerType_CrtGoogleAnalytics_TerrasoftSchema : Terrasoft.Configuration.ReferrerType_CrtWebTrackingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ReferrerType_CrtGoogleAnalytics_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ReferrerType_CrtGoogleAnalytics_TerrasoftSchema(ReferrerType_CrtGoogleAnalytics_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ReferrerType_CrtGoogleAnalytics_TerrasoftSchema(ReferrerType_CrtGoogleAnalytics_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3269c8eb-cddf-4154-bad9-4ef5a87e83a3");
			Name = "ReferrerType_CrtGoogleAnalytics_Terrasoft";
			ParentSchemaUId = new Guid("0aa9fb42-d3d0-4981-841f-eed551db7db5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9d5f25a3-92b3-36ec-5b65-90691f738891")) == null) {
				Columns.Add(CreateGACodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateGACodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("9d5f25a3-92b3-36ec-5b65-90691f738891"),
				Name = @"GACode",
				CreatedInSchemaUId = new Guid("3269c8eb-cddf-4154-bad9-4ef5a87e83a3"),
				ModifiedInSchemaUId = new Guid("3269c8eb-cddf-4154-bad9-4ef5a87e83a3"),
				CreatedInPackageId = new Guid("09b9c59a-1bca-4fd8-85b6-b08874b4ad91")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ReferrerType_CrtGoogleAnalytics_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ReferrerType_CrtGoogleAnalyticsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ReferrerType_CrtGoogleAnalytics_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ReferrerType_CrtGoogleAnalytics_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3269c8eb-cddf-4154-bad9-4ef5a87e83a3"));
		}

		#endregion

	}

	#endregion

	#region Class: ReferrerType_CrtGoogleAnalytics_Terrasoft

	/// <summary>
	/// Referrer type.
	/// </summary>
	public class ReferrerType_CrtGoogleAnalytics_Terrasoft : Terrasoft.Configuration.ReferrerType_CrtWebTrackingBase_Terrasoft
	{

		#region Constructors: Public

		public ReferrerType_CrtGoogleAnalytics_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ReferrerType_CrtGoogleAnalytics_Terrasoft";
		}

		public ReferrerType_CrtGoogleAnalytics_Terrasoft(ReferrerType_CrtGoogleAnalytics_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Google Analytics code.
		/// </summary>
		public string GACode {
			get {
				return GetTypedColumnValue<string>("GACode");
			}
			set {
				SetColumnValue("GACode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ReferrerType_CrtGoogleAnalyticsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ReferrerType_CrtGoogleAnalytics_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ReferrerType_CrtGoogleAnalytics_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ReferrerType_CrtGoogleAnalytics_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ReferrerType_CrtGoogleAnalytics_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ReferrerType_CrtGoogleAnalytics_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ReferrerType_CrtGoogleAnalytics_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ReferrerType_CrtGoogleAnalytics_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReferrerType_CrtGoogleAnalytics_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ReferrerType_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public partial class ReferrerType_CrtGoogleAnalyticsEventsProcess<TEntity> : Terrasoft.Configuration.ReferrerType_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : ReferrerType_CrtGoogleAnalytics_Terrasoft
	{

		public ReferrerType_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReferrerType_CrtGoogleAnalyticsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3269c8eb-cddf-4154-bad9-4ef5a87e83a3");
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

	#region Class: ReferrerType_CrtGoogleAnalyticsEventsProcess

	/// <exclude/>
	public class ReferrerType_CrtGoogleAnalyticsEventsProcess : ReferrerType_CrtGoogleAnalyticsEventsProcess<ReferrerType_CrtGoogleAnalytics_Terrasoft>
	{

		public ReferrerType_CrtGoogleAnalyticsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReferrerType_CrtGoogleAnalyticsEventsProcess

	public partial class ReferrerType_CrtGoogleAnalyticsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

