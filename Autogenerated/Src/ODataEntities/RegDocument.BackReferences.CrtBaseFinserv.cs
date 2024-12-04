namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RegDocument

	/// <exclude/>
	public class RegDocument : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public RegDocument(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RegDocument";
		}

		public RegDocument(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "RegDocument";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<RegDocumentFile> RegDocumentFileCollectionByRegDocument {
			get;
			set;
		}

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

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = new Contact(LookupColumnEntities.GetEntity("Contact")));
			}
		}

		/// <exclude/>
		public Guid CitizenshipId {
			get {
				return GetTypedColumnValue<Guid>("CitizenshipId");
			}
			set {
				SetColumnValue("CitizenshipId", value);
				_citizenship = null;
			}
		}

		/// <exclude/>
		public string CitizenshipName {
			get {
				return GetTypedColumnValue<string>("CitizenshipName");
			}
			set {
				SetColumnValue("CitizenshipName", value);
				if (_citizenship != null) {
					_citizenship.Name = value;
				}
			}
		}

		private Country _citizenship;
		/// <summary>
		/// Citizenship.
		/// </summary>
		public Country Citizenship {
			get {
				return _citizenship ??
					(_citizenship = new Country(LookupColumnEntities.GetEntity("Citizenship")));
			}
		}

		/// <exclude/>
		public Guid RegDocumentTypeId {
			get {
				return GetTypedColumnValue<Guid>("RegDocumentTypeId");
			}
			set {
				SetColumnValue("RegDocumentTypeId", value);
				_regDocumentType = null;
			}
		}

		/// <exclude/>
		public string RegDocumentTypeName {
			get {
				return GetTypedColumnValue<string>("RegDocumentTypeName");
			}
			set {
				SetColumnValue("RegDocumentTypeName", value);
				if (_regDocumentType != null) {
					_regDocumentType.Name = value;
				}
			}
		}

		private RegDocumentType _regDocumentType;
		/// <summary>
		/// Document type.
		/// </summary>
		public RegDocumentType RegDocumentType {
			get {
				return _regDocumentType ??
					(_regDocumentType = new RegDocumentType(LookupColumnEntities.GetEntity("RegDocumentType")));
			}
		}

		/// <summary>
		/// Series.
		/// </summary>
		public string Series {
			get {
				return GetTypedColumnValue<string>("Series");
			}
			set {
				SetColumnValue("Series", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Issued by.
		/// </summary>
		public string IssuedBy {
			get {
				return GetTypedColumnValue<string>("IssuedBy");
			}
			set {
				SetColumnValue("IssuedBy", value);
			}
		}

		/// <summary>
		/// Issued on.
		/// </summary>
		public DateTime IssueDate {
			get {
				return GetTypedColumnValue<DateTime>("IssueDate");
			}
			set {
				SetColumnValue("IssueDate", value);
			}
		}

		/// <summary>
		/// Valid until.
		/// </summary>
		public DateTime ValidUntil {
			get {
				return GetTypedColumnValue<DateTime>("ValidUntil");
			}
			set {
				SetColumnValue("ValidUntil", value);
			}
		}

		/// <summary>
		/// Department code.
		/// </summary>
		public string CodeDivision {
			get {
				return GetTypedColumnValue<string>("CodeDivision");
			}
			set {
				SetColumnValue("CodeDivision", value);
			}
		}

		/// <summary>
		/// Primary.
		/// </summary>
		public bool IsPrimary {
			get {
				return GetTypedColumnValue<bool>("IsPrimary");
			}
			set {
				SetColumnValue("IsPrimary", value);
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
		public string DocumentNumber {
			get {
				return GetTypedColumnValue<string>("DocumentNumber");
			}
			set {
				SetColumnValue("DocumentNumber", value);
				if (_document != null) {
					_document.Number = value;
				}
			}
		}

		private Document _document;
		/// <summary>
		/// Document link.
		/// </summary>
		public Document Document {
			get {
				return _document ??
					(_document = new Document(LookupColumnEntities.GetEntity("Document")));
			}
		}

		#endregion

	}

	#endregion

}

