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

	#region Class: AppFormMainContactSchema

	/// <exclude/>
	public class AppFormMainContactSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AppFormMainContactSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormMainContactSchema(AppFormMainContactSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormMainContactSchema(AppFormMainContactSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f");
			RealUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f");
			Name = "AppFormMainContact";
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
			if (Columns.FindByUId(new Guid("d848f46e-37b5-44b8-9227-9e0954e83e8f")) == null) {
				Columns.Add(CreateRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("9a652fdc-5e53-4992-8bef-479b02c73d59")) == null) {
				Columns.Add(CreateCommunicationValue1Column());
			}
			if (Columns.FindByUId(new Guid("398fde8f-b3cb-43b1-a856-805d4d1adb4a")) == null) {
				Columns.Add(CreateCommunicationValue2Column());
			}
			if (Columns.FindByUId(new Guid("07305cce-1b15-4508-81b0-5947ba3eb39e")) == null) {
				Columns.Add(CreateCommunicationValue3Column());
			}
			if (Columns.FindByUId(new Guid("3b384940-4039-47b6-a58c-a14035c81b1a")) == null) {
				Columns.Add(CreateCommunicationType1Column());
			}
			if (Columns.FindByUId(new Guid("f1318a4e-4772-4b9b-913a-e1e6e0e4d473")) == null) {
				Columns.Add(CreateCommunicationType2Column());
			}
			if (Columns.FindByUId(new Guid("ff28d66c-4df1-4061-80c2-2cff8631f22e")) == null) {
				Columns.Add(CreateCommunicationType3Column());
			}
			if (Columns.FindByUId(new Guid("8c7e6713-0ca7-439d-ae9d-2318cff8868a")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d848f46e-37b5-44b8-9227-9e0954e83e8f"),
				Name = @"RelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("abb38b6e-2482-4024-be73-5d5ab39aab0c"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationValue1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("9a652fdc-5e53-4992-8bef-479b02c73d59"),
				Name = @"CommunicationValue1",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationValue2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("398fde8f-b3cb-43b1-a856-805d4d1adb4a"),
				Name = @"CommunicationValue2",
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationValue3Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("07305cce-1b15-4508-81b0-5947ba3eb39e"),
				Name = @"CommunicationValue3",
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationType1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3b384940-4039-47b6-a58c-a14035c81b1a"),
				Name = @"CommunicationType1",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"d4a2dc80-30ca-df11-9b2a-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationType2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f1318a4e-4772-4b9b-913a-e1e6e0e4d473"),
				Name = @"CommunicationType2",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0da6a26b-d7bc-df11-b00f-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationType3Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ff28d66c-4df1-4061-80c2-2cff8631f22e"),
				Name = @"CommunicationType3",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"3dddb3cc-53ee-49c4-a71f-e9e257f59e49"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8c7e6713-0ca7-439d-ae9d-2318cff8868a"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
				ModifiedInSchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"),
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
			return new AppFormMainContact(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormMainContact_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormMainContactSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormMainContactSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormMainContact

	/// <summary>
	/// Contact person in application form.
	/// </summary>
	public class AppFormMainContact : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AppFormMainContact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormMainContact";
		}

		public AppFormMainContact(AppFormMainContact source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid RelationTypeId {
			get {
				return GetTypedColumnValue<Guid>("RelationTypeId");
			}
			set {
				SetColumnValue("RelationTypeId", value);
				_relationType = null;
			}
		}

		/// <exclude/>
		public string RelationTypeName {
			get {
				return GetTypedColumnValue<string>("RelationTypeName");
			}
			set {
				SetColumnValue("RelationTypeName", value);
				if (_relationType != null) {
					_relationType.Name = value;
				}
			}
		}

		private RelationType _relationType;
		/// <summary>
		/// Column 1.
		/// </summary>
		public RelationType RelationType {
			get {
				return _relationType ??
					(_relationType = LookupColumnEntities.GetEntity("RelationType") as RelationType);
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

		/// <summary>
		/// Communication value 1.
		/// </summary>
		public string CommunicationValue1 {
			get {
				return GetTypedColumnValue<string>("CommunicationValue1");
			}
			set {
				SetColumnValue("CommunicationValue1", value);
			}
		}

		/// <summary>
		/// Communication value 2.
		/// </summary>
		public string CommunicationValue2 {
			get {
				return GetTypedColumnValue<string>("CommunicationValue2");
			}
			set {
				SetColumnValue("CommunicationValue2", value);
			}
		}

		/// <summary>
		/// Communication value 3.
		/// </summary>
		public string CommunicationValue3 {
			get {
				return GetTypedColumnValue<string>("CommunicationValue3");
			}
			set {
				SetColumnValue("CommunicationValue3", value);
			}
		}

		/// <exclude/>
		public Guid CommunicationType1Id {
			get {
				return GetTypedColumnValue<Guid>("CommunicationType1Id");
			}
			set {
				SetColumnValue("CommunicationType1Id", value);
				_communicationType1 = null;
			}
		}

		/// <exclude/>
		public string CommunicationType1Name {
			get {
				return GetTypedColumnValue<string>("CommunicationType1Name");
			}
			set {
				SetColumnValue("CommunicationType1Name", value);
				if (_communicationType1 != null) {
					_communicationType1.Name = value;
				}
			}
		}

		private CommunicationType _communicationType1;
		/// <summary>
		/// Communication type 1.
		/// </summary>
		public CommunicationType CommunicationType1 {
			get {
				return _communicationType1 ??
					(_communicationType1 = LookupColumnEntities.GetEntity("CommunicationType1") as CommunicationType);
			}
		}

		/// <exclude/>
		public Guid CommunicationType2Id {
			get {
				return GetTypedColumnValue<Guid>("CommunicationType2Id");
			}
			set {
				SetColumnValue("CommunicationType2Id", value);
				_communicationType2 = null;
			}
		}

		/// <exclude/>
		public string CommunicationType2Name {
			get {
				return GetTypedColumnValue<string>("CommunicationType2Name");
			}
			set {
				SetColumnValue("CommunicationType2Name", value);
				if (_communicationType2 != null) {
					_communicationType2.Name = value;
				}
			}
		}

		private CommunicationType _communicationType2;
		/// <summary>
		/// Communication type 2.
		/// </summary>
		public CommunicationType CommunicationType2 {
			get {
				return _communicationType2 ??
					(_communicationType2 = LookupColumnEntities.GetEntity("CommunicationType2") as CommunicationType);
			}
		}

		/// <exclude/>
		public Guid CommunicationType3Id {
			get {
				return GetTypedColumnValue<Guid>("CommunicationType3Id");
			}
			set {
				SetColumnValue("CommunicationType3Id", value);
				_communicationType3 = null;
			}
		}

		/// <exclude/>
		public string CommunicationType3Name {
			get {
				return GetTypedColumnValue<string>("CommunicationType3Name");
			}
			set {
				SetColumnValue("CommunicationType3Name", value);
				if (_communicationType3 != null) {
					_communicationType3.Name = value;
				}
			}
		}

		private CommunicationType _communicationType3;
		/// <summary>
		/// Communication type 3.
		/// </summary>
		public CommunicationType CommunicationType3 {
			get {
				return _communicationType3 ??
					(_communicationType3 = LookupColumnEntities.GetEntity("CommunicationType3") as CommunicationType);
			}
		}

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
			var process = new AppFormMainContact_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormMainContactDeleted", e);
			Validating += (s, e) => ThrowEvent("AppFormMainContactValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormMainContact(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormMainContact_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormMainContact_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AppFormMainContact
	{

		public AppFormMainContact_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormMainContact_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3b05091e-54e7-43bf-9e8b-9d3116b88b4f");
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

	#region Class: AppFormMainContact_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormMainContact_CrtFinservApplicationEventsProcess : AppFormMainContact_CrtFinservApplicationEventsProcess<AppFormMainContact>
	{

		public AppFormMainContact_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormMainContact_CrtFinservApplicationEventsProcess

	public partial class AppFormMainContact_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormMainContactEventsProcess

	/// <exclude/>
	public class AppFormMainContactEventsProcess : AppFormMainContact_CrtFinservApplicationEventsProcess
	{

		public AppFormMainContactEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

