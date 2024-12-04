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

	#region Class: VwQueueItemSchema

	/// <exclude/>
	public class VwQueueItemSchema : Terrasoft.Configuration.VwQueueItem_ServiceDefSettings_TerrasoftSchema
	{

		#region Constructors: Public

		public VwQueueItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwQueueItemSchema(VwQueueItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwQueueItemSchema(VwQueueItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIQueueItemEntityRecordIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("92e31a43-ffdc-40be-809b-d528523bace9");
			index.Name = "IQueueItemEntityRecordId";
			index.CreatedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb");
			index.ModifiedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb");
			index.CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
			EntitySchemaIndexColumn entityRecordIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2bdc98e1-62f3-48a6-9fc0-74cce71d2f69"),
				ColumnUId = new Guid("c4b1d2f2-528c-4e66-9440-67125f0707dd"),
				CreatedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb"),
				ModifiedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(entityRecordIdIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIQueueItemSysProcessDataIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("0341d1a1-1e56-4cc1-a0ff-e6cea07f196d");
			index.Name = "IQueueItemSysProcessDataId";
			index.CreatedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb");
			index.ModifiedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb");
			index.CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
			EntitySchemaIndexColumn sysProcessDataIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("ed385332-3853-404c-aaeb-879761c31bae"),
				ColumnUId = new Guid("96eca8e1-84f2-4c9d-8b05-8c0d852211bf"),
				CreatedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb"),
				ModifiedInSchemaUId = new Guid("5baf4f89-16e6-43f8-a27f-930d372576fb"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysProcessDataIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1a77814d-ead0-4d54-b7f8-c95388dd5bf4");
			Name = "VwQueueItem";
			ParentSchemaUId = new Guid("aadf2fcd-684b-4414-8317-bf9879e97569");
			ExtendParent = true;
			CreatedInPackageId = new Guid("002630c4-bacf-488f-a876-d1a714ec5e51");
			IsDBView = true;
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

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIQueueItemEntityRecordIdIndex());
			Indexes.Add(CreateIQueueItemSysProcessDataIdIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwQueueItem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwQueueItem_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwQueueItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwQueueItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a77814d-ead0-4d54-b7f8-c95388dd5bf4"));
		}

		#endregion

	}

	#endregion

	#region Class: VwQueueItem

	/// <summary>
	/// Queue items (view).
	/// </summary>
	public class VwQueueItem : Terrasoft.Configuration.VwQueueItem_ServiceDefSettings_Terrasoft
	{

		#region Constructors: Public

		public VwQueueItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwQueueItem";
		}

		public VwQueueItem(VwQueueItem source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwQueueItem_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwQueueItemDeleted", e);
			Validating += (s, e) => ThrowEvent("VwQueueItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwQueueItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwQueueItem_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class VwQueueItem_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.VwQueueItem_ServiceDefSettingsEventsProcess<TEntity> where TEntity : VwQueueItem
	{

		public VwQueueItem_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwQueueItem_BankOnboardingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1a77814d-ead0-4d54-b7f8-c95388dd5bf4");
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

	#region Class: VwQueueItem_BankOnboardingEventsProcess

	/// <exclude/>
	public class VwQueueItem_BankOnboardingEventsProcess : VwQueueItem_BankOnboardingEventsProcess<VwQueueItem>
	{

		public VwQueueItem_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwQueueItem_BankOnboardingEventsProcess

	public partial class VwQueueItem_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwQueueItemEventsProcess

	/// <exclude/>
	public class VwQueueItemEventsProcess : VwQueueItem_BankOnboardingEventsProcess
	{

		public VwQueueItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

