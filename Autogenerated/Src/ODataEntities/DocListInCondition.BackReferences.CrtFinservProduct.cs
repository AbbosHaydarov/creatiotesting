﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocListInCondition

	/// <exclude/>
	public class DocListInCondition : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public DocListInCondition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocListInCondition";
		}

		public DocListInCondition(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "DocListInCondition";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
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
					(_sysModuleReport = new SysModuleReport(LookupColumnEntities.GetEntity("SysModuleReport")));
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
					(_documentType = new DocumentType(LookupColumnEntities.GetEntity("DocumentType")));
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
					(_documentListStage = new DocumentListStage(LookupColumnEntities.GetEntity("DocumentListStage")));
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
					(_participantRole = new ParticipantRole(LookupColumnEntities.GetEntity("ParticipantRole")));
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
					(_productCategory = new ProductCategory(LookupColumnEntities.GetEntity("ProductCategory")));
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
					(_productType = new ProductType(LookupColumnEntities.GetEntity("ProductType")));
			}
		}

		/// <exclude/>
		public Guid ProductConditionId {
			get {
				return GetTypedColumnValue<Guid>("ProductConditionId");
			}
			set {
				SetColumnValue("ProductConditionId", value);
				_productCondition = null;
			}
		}

		/// <exclude/>
		public string ProductConditionName {
			get {
				return GetTypedColumnValue<string>("ProductConditionName");
			}
			set {
				SetColumnValue("ProductConditionName", value);
				if (_productCondition != null) {
					_productCondition.Name = value;
				}
			}
		}

		private ProductCondition _productCondition;
		/// <summary>
		/// Product conditions.
		/// </summary>
		public ProductCondition ProductCondition {
			get {
				return _productCondition ??
					(_productCondition = new ProductCondition(LookupColumnEntities.GetEntity("ProductCondition")));
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
		public Guid FilterEntityId {
			get {
				return GetTypedColumnValue<Guid>("FilterEntityId");
			}
			set {
				SetColumnValue("FilterEntityId", value);
				_filterEntity = null;
			}
		}

		/// <exclude/>
		public string FilterEntityCaption {
			get {
				return GetTypedColumnValue<string>("FilterEntityCaption");
			}
			set {
				SetColumnValue("FilterEntityCaption", value);
				if (_filterEntity != null) {
					_filterEntity.Caption = value;
				}
			}
		}

		private FilterEntityCatalog _filterEntity;
		/// <summary>
		/// Filtering object.
		/// </summary>
		public FilterEntityCatalog FilterEntity {
			get {
				return _filterEntity ??
					(_filterEntity = new FilterEntityCatalog(LookupColumnEntities.GetEntity("FilterEntity")));
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
					(_document = new RegDocumentType(LookupColumnEntities.GetEntity("Document")));
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
					(_docListGroup = new DocListGroup(LookupColumnEntities.GetEntity("DocListGroup")));
			}
		}

		#endregion

	}

	#endregion

}

