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

	#region Class: DocumentListSchema

	/// <exclude/>
	public class DocumentListSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DocumentListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentListSchema(DocumentListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentListSchema(DocumentListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c");
			RealUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c");
			Name = "DocumentList";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6");
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
			if (Columns.FindByUId(new Guid("c1b561ec-858a-45cb-a5f2-d8baeaeac62a")) == null) {
				Columns.Add(CreateDocumentColumn());
			}
			if (Columns.FindByUId(new Guid("782d236a-aeba-4162-aae2-3fb560f59801")) == null) {
				Columns.Add(CreateSysModuleReportColumn());
			}
			if (Columns.FindByUId(new Guid("f6681bef-54ed-4a24-816d-2ede90c3f77d")) == null) {
				Columns.Add(CreateIsRequiredColumn());
			}
			if (Columns.FindByUId(new Guid("3d693589-efd2-4f59-961a-9148ba8afdcf")) == null) {
				Columns.Add(CreateHasFiltersColumn());
			}
			if (Columns.FindByUId(new Guid("fd8f8825-05bf-4bc3-a5f1-b09b373712e6")) == null) {
				Columns.Add(CreateDocumentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("240201eb-7792-4e8e-9f59-c2c51c6aa959")) == null) {
				Columns.Add(CreateDocumentListStageColumn());
			}
			if (Columns.FindByUId(new Guid("99455a15-1c61-4c4c-9e10-a0d4749d1aed")) == null) {
				Columns.Add(CreateParticipantRoleColumn());
			}
			if (Columns.FindByUId(new Guid("c0a588c1-09f1-46a0-80ec-770f016bf773")) == null) {
				Columns.Add(CreateProductCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("5230709c-fcc3-4bd6-973d-ddc37118178c")) == null) {
				Columns.Add(CreateProductTypeColumn());
			}
			if (Columns.FindByUId(new Guid("fcc6984d-ab6e-4acd-a0fa-83450f7a84dc")) == null) {
				Columns.Add(CreateFilterConfigColumn());
			}
			if (Columns.FindByUId(new Guid("c114a947-5f53-4b6b-954c-264203f2387a")) == null) {
				Columns.Add(CreateDocListGroupColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("91f95cdb-6ac8-4b7c-b685-b4e179797097"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDocumentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c1b561ec-858a-45cb-a5f2-d8baeaeac62a"),
				Name = @"Document",
				ReferenceSchemaUId = new Guid("ec520e44-c1ab-4545-8489-6e9adaf5c73b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysModuleReportColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("782d236a-aeba-4162-aae2-3fb560f59801"),
				Name = @"SysModuleReport",
				ReferenceSchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsRequiredColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f6681bef-54ed-4a24-816d-2ede90c3f77d"),
				Name = @"IsRequired",
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6")
			};
		}

		protected virtual EntitySchemaColumn CreateHasFiltersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3d693589-efd2-4f59-961a-9148ba8afdcf"),
				Name = @"HasFilters",
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6")
			};
		}

		protected virtual EntitySchemaColumn CreateDocumentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fd8f8825-05bf-4bc3-a5f1-b09b373712e6"),
				Name = @"DocumentType",
				ReferenceSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6")
			};
		}

		protected virtual EntitySchemaColumn CreateDocumentListStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("240201eb-7792-4e8e-9f59-c2c51c6aa959"),
				Name = @"DocumentListStage",
				ReferenceSchemaUId = new Guid("055d88f1-7c3f-4850-933a-cd594d7ca6cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6")
			};
		}

		protected virtual EntitySchemaColumn CreateParticipantRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("99455a15-1c61-4c4c-9e10-a0d4749d1aed"),
				Name = @"ParticipantRole",
				ReferenceSchemaUId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6")
			};
		}

		protected virtual EntitySchemaColumn CreateProductCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c0a588c1-09f1-46a0-80ec-770f016bf773"),
				Name = @"ProductCategory",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("265863ca-9e34-491c-ae3f-df0ca7f51136")
			};
		}

		protected virtual EntitySchemaColumn CreateProductTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5230709c-fcc3-4bd6-973d-ddc37118178c"),
				Name = @"ProductType",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("265863ca-9e34-491c-ae3f-df0ca7f51136")
			};
		}

		protected virtual EntitySchemaColumn CreateFilterConfigColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("fcc6984d-ab6e-4acd-a0fa-83450f7a84dc"),
				Name = @"FilterConfig",
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateDocListGroupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c114a947-5f53-4b6b-954c-264203f2387a"),
				Name = @"DocListGroup",
				ReferenceSchemaUId = new Guid("6192328d-4522-4d9a-bc7c-46b57770c3f1"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				ModifiedInSchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentList_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentList

	/// <summary>
	/// Documents package.
	/// </summary>
	public class DocumentList : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DocumentList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentList";
		}

		public DocumentList(DocumentList source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <exclude/>
		public Guid DocumentId {
			get {
				return GetTypedColumnValue<Guid>("DocumentId");
			}
			set {
				SetColumnValue("DocumentId", value);
				_document = null;
			}
		}

		/// <exclude/>
		public string DocumentName {
			get {
				return GetTypedColumnValue<string>("DocumentName");
			}
			set {
				SetColumnValue("DocumentName", value);
				if (_document != null) {
					_document.Name = value;
				}
			}
		}

		private RegDocumentType _document;
		/// <summary>
		/// Document.
		/// </summary>
		public RegDocumentType Document {
			get {
				return _document ??
					(_document = LookupColumnEntities.GetEntity("Document") as RegDocumentType);
			}
		}

		/// <exclude/>
		public Guid SysModuleReportId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleReportId");
			}
			set {
				SetColumnValue("SysModuleReportId", value);
				_sysModuleReport = null;
			}
		}

		/// <exclude/>
		public string SysModuleReportCaption {
			get {
				return GetTypedColumnValue<string>("SysModuleReportCaption");
			}
			set {
				SetColumnValue("SysModuleReportCaption", value);
				if (_sysModuleReport != null) {
					_sysModuleReport.Caption = value;
				}
			}
		}

		private SysModuleReport _sysModuleReport;
		/// <summary>
		/// Template.
		/// </summary>
		public SysModuleReport SysModuleReport {
			get {
				return _sysModuleReport ??
					(_sysModuleReport = LookupColumnEntities.GetEntity("SysModuleReport") as SysModuleReport);
			}
		}

		/// <summary>
		/// Required.
		/// </summary>
		public bool IsRequired {
			get {
				return GetTypedColumnValue<bool>("IsRequired");
			}
			set {
				SetColumnValue("IsRequired", value);
			}
		}

		/// <summary>
		/// Filter.
		/// </summary>
		public bool HasFilters {
			get {
				return GetTypedColumnValue<bool>("HasFilters");
			}
			set {
				SetColumnValue("HasFilters", value);
			}
		}

		/// <exclude/>
		public Guid DocumentTypeId {
			get {
				return GetTypedColumnValue<Guid>("DocumentTypeId");
			}
			set {
				SetColumnValue("DocumentTypeId", value);
				_documentType = null;
			}
		}

		/// <exclude/>
		public string DocumentTypeName {
			get {
				return GetTypedColumnValue<string>("DocumentTypeName");
			}
			set {
				SetColumnValue("DocumentTypeName", value);
				if (_documentType != null) {
					_documentType.Name = value;
				}
			}
		}

		private DocumentType _documentType;
		/// <summary>
		/// Document type.
		/// </summary>
		public DocumentType DocumentType {
			get {
				return _documentType ??
					(_documentType = LookupColumnEntities.GetEntity("DocumentType") as DocumentType);
			}
		}

		/// <exclude/>
		public Guid DocumentListStageId {
			get {
				return GetTypedColumnValue<Guid>("DocumentListStageId");
			}
			set {
				SetColumnValue("DocumentListStageId", value);
				_documentListStage = null;
			}
		}

		/// <exclude/>
		public string DocumentListStageName {
			get {
				return GetTypedColumnValue<string>("DocumentListStageName");
			}
			set {
				SetColumnValue("DocumentListStageName", value);
				if (_documentListStage != null) {
					_documentListStage.Name = value;
				}
			}
		}

		private DocumentListStage _documentListStage;
		/// <summary>
		/// Stage.
		/// </summary>
		public DocumentListStage DocumentListStage {
			get {
				return _documentListStage ??
					(_documentListStage = LookupColumnEntities.GetEntity("DocumentListStage") as DocumentListStage);
			}
		}

		/// <exclude/>
		public Guid ParticipantRoleId {
			get {
				return GetTypedColumnValue<Guid>("ParticipantRoleId");
			}
			set {
				SetColumnValue("ParticipantRoleId", value);
				_participantRole = null;
			}
		}

		/// <exclude/>
		public string ParticipantRoleName {
			get {
				return GetTypedColumnValue<string>("ParticipantRoleName");
			}
			set {
				SetColumnValue("ParticipantRoleName", value);
				if (_participantRole != null) {
					_participantRole.Name = value;
				}
			}
		}

		private ParticipantRole _participantRole;
		/// <summary>
		/// Role.
		/// </summary>
		public ParticipantRole ParticipantRole {
			get {
				return _participantRole ??
					(_participantRole = LookupColumnEntities.GetEntity("ParticipantRole") as ParticipantRole);
			}
		}

		/// <exclude/>
		public Guid ProductCategoryId {
			get {
				return GetTypedColumnValue<Guid>("ProductCategoryId");
			}
			set {
				SetColumnValue("ProductCategoryId", value);
				_productCategory = null;
			}
		}

		/// <exclude/>
		public string ProductCategoryName {
			get {
				return GetTypedColumnValue<string>("ProductCategoryName");
			}
			set {
				SetColumnValue("ProductCategoryName", value);
				if (_productCategory != null) {
					_productCategory.Name = value;
				}
			}
		}

		private ProductCategory _productCategory;
		/// <summary>
		/// Product category.
		/// </summary>
		public ProductCategory ProductCategory {
			get {
				return _productCategory ??
					(_productCategory = LookupColumnEntities.GetEntity("ProductCategory") as ProductCategory);
			}
		}

		/// <exclude/>
		public Guid ProductTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeId");
			}
			set {
				SetColumnValue("ProductTypeId", value);
				_productType = null;
			}
		}

		/// <exclude/>
		public string ProductTypeName {
			get {
				return GetTypedColumnValue<string>("ProductTypeName");
			}
			set {
				SetColumnValue("ProductTypeName", value);
				if (_productType != null) {
					_productType.Name = value;
				}
			}
		}

		private ProductType _productType;
		/// <summary>
		/// Product type.
		/// </summary>
		public ProductType ProductType {
			get {
				return _productType ??
					(_productType = LookupColumnEntities.GetEntity("ProductType") as ProductType);
			}
		}

		/// <summary>
		/// Filter setup.
		/// </summary>
		public string FilterConfig {
			get {
				return GetTypedColumnValue<string>("FilterConfig");
			}
			set {
				SetColumnValue("FilterConfig", value);
			}
		}

		/// <exclude/>
		public Guid DocListGroupId {
			get {
				return GetTypedColumnValue<Guid>("DocListGroupId");
			}
			set {
				SetColumnValue("DocListGroupId", value);
				_docListGroup = null;
			}
		}

		/// <exclude/>
		public string DocListGroupName {
			get {
				return GetTypedColumnValue<string>("DocListGroupName");
			}
			set {
				SetColumnValue("DocListGroupName", value);
				if (_docListGroup != null) {
					_docListGroup.Name = value;
				}
			}
		}

		private DocListGroup _docListGroup;
		/// <summary>
		/// Document group.
		/// </summary>
		public DocListGroup DocListGroup {
			get {
				return _docListGroup ??
					(_docListGroup = LookupColumnEntities.GetEntity("DocListGroup") as DocListGroup);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentList_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentListDeleted", e);
			Saving += (s, e) => ThrowEvent("DocumentListSaving", e);
			Validating += (s, e) => ThrowEvent("DocumentListValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentList(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentList_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class DocumentList_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DocumentList
	{

		public DocumentList_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentList_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ba8d51e9-1ef4-4d85-926b-0487f070378c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _beforeDocumentListSavedSubprocess;
		public ProcessFlowElement BeforeDocumentListSavedSubprocess {
			get {
				return _beforeDocumentListSavedSubprocess ?? (_beforeDocumentListSavedSubprocess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeDocumentListSavedSubprocess",
					SchemaElementUId = new Guid("90e751e1-5702-4719-adb5-2cb690035eae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _beforeDocumentListSavedScriptTask;
		public ProcessScriptTask BeforeDocumentListSavedScriptTask {
			get {
				return _beforeDocumentListSavedScriptTask ?? (_beforeDocumentListSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeDocumentListSavedScriptTask",
					SchemaElementUId = new Guid("c50d0c17-5105-48bd-954c-86dcaec79a40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BeforeDocumentListSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _documentListSaving;
		public ProcessFlowElement DocumentListSaving {
			get {
				return _documentListSaving ?? (_documentListSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DocumentListSaving",
					SchemaElementUId = new Guid("f350a5b0-0743-4b90-9e9b-1b3110445361"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BeforeDocumentListSavedSubprocess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeDocumentListSavedSubprocess };
			FlowElements[BeforeDocumentListSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeDocumentListSavedScriptTask };
			FlowElements[DocumentListSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentListSaving };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BeforeDocumentListSavedSubprocess":
						break;
					case "BeforeDocumentListSavedScriptTask":
						break;
					case "DocumentListSaving":
						e.Context.QueueTasks.Enqueue("BeforeDocumentListSavedScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DocumentListSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BeforeDocumentListSavedSubprocess":
					context.QueueTasks.Dequeue();
					break;
				case "BeforeDocumentListSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeDocumentListSavedScriptTask";
					result = BeforeDocumentListSavedScriptTask.Execute(context, BeforeDocumentListSavedScriptTaskExecute);
					break;
				case "DocumentListSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentListSaving";
					result = DocumentListSaving.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool BeforeDocumentListSavedScriptTaskExecute(ProcessExecutingContext context) {
			this.GenerateNameByDocument();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DocumentListSaving":
							if (ActivatedEventElements.Contains("DocumentListSaving")) {
							context.QueueTasks.Enqueue("DocumentListSaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentList_CrtFinservProductEventsProcess

	/// <exclude/>
	public class DocumentList_CrtFinservProductEventsProcess : DocumentList_CrtFinservProductEventsProcess<DocumentList>
	{

		public DocumentList_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentList_CrtFinservProductEventsProcess

	public partial class DocumentList_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void GenerateNameByDocument() {
			Guid documentId = Entity.GetTypedColumnValue<Guid>("DocumentId");
			if (documentId != Guid.Empty) {
				var regDocumentTypeEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "RegDocumentType");
				var regDocumentTypeNameColumn = regDocumentTypeEsq.AddColumn("Name");
				var regDocumentTypeEntity = regDocumentTypeEsq.GetEntity(UserConnection, documentId);
				if (regDocumentTypeEntity != null) {
					string regDocumentTypeName =
						regDocumentTypeEntity.GetTypedColumnValue<string>(regDocumentTypeNameColumn.Name);
					Entity.SetColumnValue("Name", regDocumentTypeName);
				}
			}
		}

		#endregion

	}

	#endregion


	#region Class: DocumentListEventsProcess

	/// <exclude/>
	public class DocumentListEventsProcess : DocumentList_CrtFinservProductEventsProcess
	{

		public DocumentListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

