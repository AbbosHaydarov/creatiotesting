namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CrtPlaybook

	/// <exclude/>
	public class CrtPlaybook : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CrtPlaybook(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CrtPlaybook";
		}

		public CrtPlaybook(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "CrtPlaybook";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PlaybookStage> PlaybookStageCollectionByPlaybook {
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
		public Guid ObjectId {
			get {
				return GetTypedColumnValue<Guid>("ObjectId");
			}
			set {
				SetColumnValue("ObjectId", value);
				_object = null;
			}
		}

		/// <exclude/>
		public string ObjectCaption {
			get {
				return GetTypedColumnValue<string>("ObjectCaption");
			}
			set {
				SetColumnValue("ObjectCaption", value);
				if (_object != null) {
					_object.Caption = value;
				}
			}
		}

		private VwDcmStagedObject _object;
		/// <summary>
		/// Object.
		/// </summary>
		public VwDcmStagedObject Object {
			get {
				return _object ??
					(_object = new VwDcmStagedObject(LookupColumnEntities.GetEntity("Object")));
			}
		}

		/// <exclude/>
		public Guid DcmCaseId {
			get {
				return GetTypedColumnValue<Guid>("DcmCaseId");
			}
			set {
				SetColumnValue("DcmCaseId", value);
				_dcmCase = null;
			}
		}

		/// <exclude/>
		public string DcmCaseCaption {
			get {
				return GetTypedColumnValue<string>("DcmCaseCaption");
			}
			set {
				SetColumnValue("DcmCaseCaption", value);
				if (_dcmCase != null) {
					_dcmCase.Caption = value;
				}
			}
		}

		private VwSysDcmLib _dcmCase;
		/// <summary>
		/// DCM case.
		/// </summary>
		public VwSysDcmLib DcmCase {
			get {
				return _dcmCase ??
					(_dcmCase = new VwSysDcmLib(LookupColumnEntities.GetEntity("DcmCase")));
			}
		}

		#endregion

	}

	#endregion

}

