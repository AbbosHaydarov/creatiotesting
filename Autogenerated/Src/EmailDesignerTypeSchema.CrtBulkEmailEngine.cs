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

	#region Class: EmailDesignerTypeSchema

	/// <exclude/>
	public class EmailDesignerTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public EmailDesignerTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailDesignerTypeSchema(EmailDesignerTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailDesignerTypeSchema(EmailDesignerTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85292d56-edcf-453d-a626-777f267d81a4");
			RealUId = new Guid("85292d56-edcf-453d-a626-777f267d81a4");
			Name = "EmailDesignerType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new EmailDesignerType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailDesignerType_CrtBulkEmailEngineEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailDesignerTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailDesignerTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85292d56-edcf-453d-a626-777f267d81a4"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailDesignerType

	/// <summary>
	/// Email designer type.
	/// </summary>
	public class EmailDesignerType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public EmailDesignerType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailDesignerType";
		}

		public EmailDesignerType(EmailDesignerType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailDesignerType_CrtBulkEmailEngineEventsProcess(UserConnection);
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
			return new EmailDesignerType(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailDesignerType_CrtBulkEmailEngineEventsProcess

	/// <exclude/>
	public partial class EmailDesignerType_CrtBulkEmailEngineEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : EmailDesignerType
	{

		public EmailDesignerType_CrtBulkEmailEngineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailDesignerType_CrtBulkEmailEngineEventsProcess";
			SchemaUId = new Guid("85292d56-edcf-453d-a626-777f267d81a4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("85292d56-edcf-453d-a626-777f267d81a4");
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

	#region Class: EmailDesignerType_CrtBulkEmailEngineEventsProcess

	/// <exclude/>
	public class EmailDesignerType_CrtBulkEmailEngineEventsProcess : EmailDesignerType_CrtBulkEmailEngineEventsProcess<EmailDesignerType>
	{

		public EmailDesignerType_CrtBulkEmailEngineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailDesignerType_CrtBulkEmailEngineEventsProcess

	public partial class EmailDesignerType_CrtBulkEmailEngineEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmailDesignerTypeEventsProcess

	/// <exclude/>
	public class EmailDesignerTypeEventsProcess : EmailDesignerType_CrtBulkEmailEngineEventsProcess
	{

		public EmailDesignerTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

