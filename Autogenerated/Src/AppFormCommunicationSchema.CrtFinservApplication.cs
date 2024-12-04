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

	#region Class: AppFormCommunicationSchema

	/// <exclude/>
	public class AppFormCommunicationSchema : Terrasoft.Configuration.BaseCommunicationSchema
	{

		#region Constructors: Public

		public AppFormCommunicationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormCommunicationSchema(AppFormCommunicationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormCommunicationSchema(AppFormCommunicationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f1c7f11-798b-46c5-8852-eb08078d99b8");
			RealUId = new Guid("8f1c7f11-798b-46c5-8852-eb08078d99b8");
			Name = "AppFormCommunication";
			ParentSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("aebbc583-e044-45ab-8ea3-6a849f6569df")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("aebbc583-e044-45ab-8ea3-6a849f6569df"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("8f1c7f11-798b-46c5-8852-eb08078d99b8"),
				ModifiedInSchemaUId = new Guid("8f1c7f11-798b-46c5-8852-eb08078d99b8"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppFormCommunication(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormCommunication_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormCommunicationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormCommunicationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f1c7f11-798b-46c5-8852-eb08078d99b8"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormCommunication

	/// <summary>
	/// Communication option in application form.
	/// </summary>
	public class AppFormCommunication : Terrasoft.Configuration.BaseCommunication
	{

		#region Constructors: Public

		public AppFormCommunication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormCommunication";
		}

		public AppFormCommunication(AppFormCommunication source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AppFormId {
			get {
				return GetTypedColumnValue<Guid>("AppFormId");
			}
			set {
				SetColumnValue("AppFormId", value);
				_appForm = null;
			}
		}

		/// <exclude/>
		public string AppFormParticipant {
			get {
				return GetTypedColumnValue<string>("AppFormParticipant");
			}
			set {
				SetColumnValue("AppFormParticipant", value);
				if (_appForm != null) {
					_appForm.Participant = value;
				}
			}
		}

		private AppForm _appForm;
		/// <summary>
		/// Application form.
		/// </summary>
		public AppForm AppForm {
			get {
				return _appForm ??
					(_appForm = LookupColumnEntities.GetEntity("AppForm") as AppForm);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormCommunication_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormCommunicationDeleted", e);
			Validating += (s, e) => ThrowEvent("AppFormCommunicationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormCommunication(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormCommunication_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormCommunication_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseCommunication_CrtBaseEventsProcess<TEntity> where TEntity : AppFormCommunication
	{

		public AppFormCommunication_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormCommunication_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("8f1c7f11-798b-46c5-8852-eb08078d99b8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8f1c7f11-798b-46c5-8852-eb08078d99b8");
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

	#region Class: AppFormCommunication_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormCommunication_CrtFinservApplicationEventsProcess : AppFormCommunication_CrtFinservApplicationEventsProcess<AppFormCommunication>
	{

		public AppFormCommunication_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormCommunication_CrtFinservApplicationEventsProcess

	public partial class AppFormCommunication_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormCommunicationEventsProcess

	/// <exclude/>
	public class AppFormCommunicationEventsProcess : AppFormCommunication_CrtFinservApplicationEventsProcess
	{

		public AppFormCommunicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

