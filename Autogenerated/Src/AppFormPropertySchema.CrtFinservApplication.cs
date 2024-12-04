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

	#region Class: AppFormPropertySchema

	/// <exclude/>
	public class AppFormPropertySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AppFormPropertySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormPropertySchema(AppFormPropertySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormPropertySchema(AppFormPropertySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62");
			RealUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62");
			Name = "AppFormProperty";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ff9bc316-28d3-4973-9842-dd87c44c7904")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
			if (Columns.FindByUId(new Guid("4e1a9f62-d5aa-432f-8e22-b8af4c4d2f71")) == null) {
				Columns.Add(CreatePropertyTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ff9bc316-28d3-4973-9842-dd87c44c7904"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"),
				ModifiedInSchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreatePropertyTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4e1a9f62-d5aa-432f-8e22-b8af4c4d2f71"),
				Name = @"PropertyType",
				ReferenceSchemaUId = new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"),
				ModifiedInSchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("c9052613-167d-4f53-8360-8ad0b7ff5e58"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"),
				ModifiedInSchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"),
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
			return new AppFormProperty(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormProperty_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormPropertySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormPropertySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormProperty

	/// <summary>
	/// Property in application form.
	/// </summary>
	public class AppFormProperty : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AppFormProperty(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormProperty";
		}

		public AppFormProperty(AppFormProperty source)
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

		/// <exclude/>
		public Guid PropertyTypeId {
			get {
				return GetTypedColumnValue<Guid>("PropertyTypeId");
			}
			set {
				SetColumnValue("PropertyTypeId", value);
				_propertyType = null;
			}
		}

		/// <exclude/>
		public string PropertyTypeName {
			get {
				return GetTypedColumnValue<string>("PropertyTypeName");
			}
			set {
				SetColumnValue("PropertyTypeName", value);
				if (_propertyType != null) {
					_propertyType.Name = value;
				}
			}
		}

		private PropertyType _propertyType;
		/// <summary>
		/// Property type.
		/// </summary>
		public PropertyType PropertyType {
			get {
				return _propertyType ??
					(_propertyType = LookupColumnEntities.GetEntity("PropertyType") as PropertyType);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormProperty_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormPropertyDeleted", e);
			Validating += (s, e) => ThrowEvent("AppFormPropertyValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormProperty(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormProperty_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormProperty_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AppFormProperty
	{

		public AppFormProperty_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormProperty_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62");
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

	#region Class: AppFormProperty_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormProperty_CrtFinservApplicationEventsProcess : AppFormProperty_CrtFinservApplicationEventsProcess<AppFormProperty>
	{

		public AppFormProperty_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormProperty_CrtFinservApplicationEventsProcess

	public partial class AppFormProperty_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormPropertyEventsProcess

	/// <exclude/>
	public class AppFormPropertyEventsProcess : AppFormProperty_CrtFinservApplicationEventsProcess
	{

		public AppFormPropertyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

