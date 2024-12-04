namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AppFormMainContact

	/// <exclude/>
	public class AppFormMainContact : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AppFormMainContact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormMainContact";
		}

		public AppFormMainContact(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AppFormMainContact";
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
					(_relationType = new RelationType(LookupColumnEntities.GetEntity("RelationType")));
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
					(_communicationType1 = new CommunicationType(LookupColumnEntities.GetEntity("CommunicationType1")));
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
					(_communicationType2 = new CommunicationType(LookupColumnEntities.GetEntity("CommunicationType2")));
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
					(_communicationType3 = new CommunicationType(LookupColumnEntities.GetEntity("CommunicationType3")));
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
					(_appForm = new AppForm(LookupColumnEntities.GetEntity("AppForm")));
			}
		}

		#endregion

	}

	#endregion

}

