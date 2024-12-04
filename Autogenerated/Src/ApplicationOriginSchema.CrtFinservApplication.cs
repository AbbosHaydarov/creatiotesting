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

	#region Class: ApplicationOriginSchema

	/// <exclude/>
	public class ApplicationOriginSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ApplicationOriginSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ApplicationOriginSchema(ApplicationOriginSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ApplicationOriginSchema(ApplicationOriginSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("07c6bf76-835d-4235-bf25-d6c5624e0383");
			RealUId = new Guid("07c6bf76-835d-4235-bf25-d6c5624e0383");
			Name = "ApplicationOrigin";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c8da7e08-6492-4148-9858-7626794d6819");
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
			return new ApplicationOrigin(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ApplicationOrigin_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ApplicationOriginSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ApplicationOriginSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07c6bf76-835d-4235-bf25-d6c5624e0383"));
		}

		#endregion

	}

	#endregion

	#region Class: ApplicationOrigin

	/// <summary>
	/// Application origin.
	/// </summary>
	public class ApplicationOrigin : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ApplicationOrigin(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ApplicationOrigin";
		}

		public ApplicationOrigin(ApplicationOrigin source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ApplicationOrigin_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ApplicationOriginDeleted", e);
			Validating += (s, e) => ThrowEvent("ApplicationOriginValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ApplicationOrigin(this);
		}

		#endregion

	}

	#endregion

	#region Class: ApplicationOrigin_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class ApplicationOrigin_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ApplicationOrigin
	{

		public ApplicationOrigin_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ApplicationOrigin_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("07c6bf76-835d-4235-bf25-d6c5624e0383");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("07c6bf76-835d-4235-bf25-d6c5624e0383");
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

	#region Class: ApplicationOrigin_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class ApplicationOrigin_CrtFinservApplicationEventsProcess : ApplicationOrigin_CrtFinservApplicationEventsProcess<ApplicationOrigin>
	{

		public ApplicationOrigin_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ApplicationOrigin_CrtFinservApplicationEventsProcess

	public partial class ApplicationOrigin_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ApplicationOriginEventsProcess

	/// <exclude/>
	public class ApplicationOriginEventsProcess : ApplicationOrigin_CrtFinservApplicationEventsProcess
	{

		public ApplicationOriginEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

