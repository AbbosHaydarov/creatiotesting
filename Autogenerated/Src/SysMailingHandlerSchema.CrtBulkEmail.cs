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

	#region Class: SysMailingHandlerSchema

	/// <exclude/>
	public class SysMailingHandlerSchema : Terrasoft.Configuration.SysMailingHandler_CrtMarketingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public SysMailingHandlerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysMailingHandlerSchema(SysMailingHandlerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysMailingHandlerSchema(SysMailingHandlerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9242d9d8-20ac-41c6-965d-d55217944790");
			Name = "SysMailingHandler";
			ParentSchemaUId = new Guid("1d5a3605-19a8-41f1-816f-274d1fc85810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a82b9fe3-3ac8-4d0c-8fee-497c7ba84320");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("34900cd7-9ad9-4d8b-85a2-2cfb0737e9ab")) == null) {
				Columns.Add(CreateProviderColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProviderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("34900cd7-9ad9-4d8b-85a2-2cfb0737e9ab"),
				Name = @"Provider",
				ReferenceSchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9242d9d8-20ac-41c6-965d-d55217944790"),
				ModifiedInSchemaUId = new Guid("9242d9d8-20ac-41c6-965d-d55217944790"),
				CreatedInPackageId = new Guid("a82b9fe3-3ac8-4d0c-8fee-497c7ba84320"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysMailingHandler(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysMailingHandler_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysMailingHandlerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysMailingHandlerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9242d9d8-20ac-41c6-965d-d55217944790"));
		}

		#endregion

	}

	#endregion

	#region Class: SysMailingHandler

	/// <summary>
	/// Mailing handler.
	/// </summary>
	public class SysMailingHandler : Terrasoft.Configuration.SysMailingHandler_CrtMarketingBase_Terrasoft
	{

		#region Constructors: Public

		public SysMailingHandler(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysMailingHandler";
		}

		public SysMailingHandler(SysMailingHandler source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProviderId {
			get {
				return GetTypedColumnValue<Guid>("ProviderId");
			}
			set {
				SetColumnValue("ProviderId", value);
				_provider = null;
			}
		}

		/// <exclude/>
		public string ProviderName {
			get {
				return GetTypedColumnValue<string>("ProviderName");
			}
			set {
				SetColumnValue("ProviderName", value);
				if (_provider != null) {
					_provider.Name = value;
				}
			}
		}

		private SysMailingProvider _provider;
		/// <summary>
		/// Mailing provider.
		/// </summary>
		public SysMailingProvider Provider {
			get {
				return _provider ??
					(_provider = LookupColumnEntities.GetEntity("Provider") as SysMailingProvider);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysMailingHandler_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("SysMailingHandlerDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysMailingHandlerInserted", e);
			Inserting += (s, e) => ThrowEvent("SysMailingHandlerInserting", e);
			Saved += (s, e) => ThrowEvent("SysMailingHandlerSaved", e);
			Saving += (s, e) => ThrowEvent("SysMailingHandlerSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMailingHandler(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysMailingHandler_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class SysMailingHandler_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.SysMailingHandler_CrtMarketingBaseEventsProcess<TEntity> where TEntity : SysMailingHandler
	{

		public SysMailingHandler_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMailingHandler_CrtBulkEmailEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9242d9d8-20ac-41c6-965d-d55217944790");
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

	#region Class: SysMailingHandler_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class SysMailingHandler_CrtBulkEmailEventsProcess : SysMailingHandler_CrtBulkEmailEventsProcess<SysMailingHandler>
	{

		public SysMailingHandler_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMailingHandler_CrtBulkEmailEventsProcess

	public partial class SysMailingHandler_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysMailingHandlerEventsProcess

	/// <exclude/>
	public class SysMailingHandlerEventsProcess : SysMailingHandler_CrtBulkEmailEventsProcess
	{

		public SysMailingHandlerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

