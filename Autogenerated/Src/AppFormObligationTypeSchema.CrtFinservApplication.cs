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

	#region Class: AppFormObligationTypeSchema

	/// <exclude/>
	public class AppFormObligationTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AppFormObligationTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormObligationTypeSchema(AppFormObligationTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormObligationTypeSchema(AppFormObligationTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0eb1556a-1346-4c2e-bc29-c95f158493c9");
			RealUId = new Guid("0eb1556a-1346-4c2e-bc29-c95f158493c9");
			Name = "AppFormObligationType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b");
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
			return new AppFormObligationType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormObligationType_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormObligationTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormObligationTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0eb1556a-1346-4c2e-bc29-c95f158493c9"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormObligationType

	/// <summary>
	/// Application form obligation type.
	/// </summary>
	public class AppFormObligationType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AppFormObligationType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormObligationType";
		}

		public AppFormObligationType(AppFormObligationType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormObligationType_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormObligationTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("AppFormObligationTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormObligationType(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormObligationType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormObligationType_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AppFormObligationType
	{

		public AppFormObligationType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormObligationType_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("0eb1556a-1346-4c2e-bc29-c95f158493c9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0eb1556a-1346-4c2e-bc29-c95f158493c9");
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

	#region Class: AppFormObligationType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormObligationType_CrtFinservApplicationEventsProcess : AppFormObligationType_CrtFinservApplicationEventsProcess<AppFormObligationType>
	{

		public AppFormObligationType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormObligationType_CrtFinservApplicationEventsProcess

	public partial class AppFormObligationType_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormObligationTypeEventsProcess

	/// <exclude/>
	public class AppFormObligationTypeEventsProcess : AppFormObligationType_CrtFinservApplicationEventsProcess
	{

		public AppFormObligationTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

