namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AppValidation

	/// <exclude/>
	public class AppValidation : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AppValidation(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidation";
		}

		public AppValidation(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AppValidation";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AppValQuestionResult> AppValQuestionResultCollectionByAppValidation {
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
		public Guid ValidationItemId {
			get {
				return GetTypedColumnValue<Guid>("ValidationItemId");
			}
			set {
				SetColumnValue("ValidationItemId", value);
				_validationItem = null;
			}
		}

		/// <exclude/>
		public string ValidationItemName {
			get {
				return GetTypedColumnValue<string>("ValidationItemName");
			}
			set {
				SetColumnValue("ValidationItemName", value);
				if (_validationItem != null) {
					_validationItem.Name = value;
				}
			}
		}

		private AppValidationItem _validationItem;
		/// <summary>
		/// Validation item.
		/// </summary>
		public AppValidationItem ValidationItem {
			get {
				return _validationItem ??
					(_validationItem = new AppValidationItem(LookupColumnEntities.GetEntity("ValidationItem")));
			}
		}

		/// <exclude/>
		public Guid FinApplicationId {
			get {
				return GetTypedColumnValue<Guid>("FinApplicationId");
			}
			set {
				SetColumnValue("FinApplicationId", value);
				_finApplication = null;
			}
		}

		/// <exclude/>
		public string FinApplicationNumber {
			get {
				return GetTypedColumnValue<string>("FinApplicationNumber");
			}
			set {
				SetColumnValue("FinApplicationNumber", value);
				if (_finApplication != null) {
					_finApplication.Number = value;
				}
			}
		}

		private FinApplication _finApplication;
		/// <summary>
		/// Application.
		/// </summary>
		public FinApplication FinApplication {
			get {
				return _finApplication ??
					(_finApplication = new FinApplication(LookupColumnEntities.GetEntity("FinApplication")));
			}
		}

		/// <exclude/>
		public Guid ValidationResultId {
			get {
				return GetTypedColumnValue<Guid>("ValidationResultId");
			}
			set {
				SetColumnValue("ValidationResultId", value);
				_validationResult = null;
			}
		}

		/// <exclude/>
		public string ValidationResultName {
			get {
				return GetTypedColumnValue<string>("ValidationResultName");
			}
			set {
				SetColumnValue("ValidationResultName", value);
				if (_validationResult != null) {
					_validationResult.Name = value;
				}
			}
		}

		private AppValidationResult _validationResult;
		/// <summary>
		/// Result.
		/// </summary>
		public AppValidationResult ValidationResult {
			get {
				return _validationResult ??
					(_validationResult = new AppValidationResult(LookupColumnEntities.GetEntity("ValidationResult")));
			}
		}

		/// <exclude/>
		public Guid ParticipantId {
			get {
				return GetTypedColumnValue<Guid>("ParticipantId");
			}
			set {
				SetColumnValue("ParticipantId", value);
				_participant = null;
			}
		}

		/// <exclude/>
		public string ParticipantParticipant {
			get {
				return GetTypedColumnValue<string>("ParticipantParticipant");
			}
			set {
				SetColumnValue("ParticipantParticipant", value);
				if (_participant != null) {
					_participant.Participant = value;
				}
			}
		}

		private AppForm _participant;
		/// <summary>
		/// Application form.
		/// </summary>
		public AppForm Participant {
			get {
				return _participant ??
					(_participant = new AppForm(LookupColumnEntities.GetEntity("Participant")));
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
		/// Participant role.
		/// </summary>
		public ParticipantRole ParticipantRole {
			get {
				return _participantRole ??
					(_participantRole = new ParticipantRole(LookupColumnEntities.GetEntity("ParticipantRole")));
			}
		}

		/// <exclude/>
		public Guid RoleId {
			get {
				return GetTypedColumnValue<Guid>("RoleId");
			}
			set {
				SetColumnValue("RoleId", value);
				_role = null;
			}
		}

		/// <exclude/>
		public string RoleName {
			get {
				return GetTypedColumnValue<string>("RoleName");
			}
			set {
				SetColumnValue("RoleName", value);
				if (_role != null) {
					_role.Name = value;
				}
			}
		}

		private SysAdminUnit _role;
		/// <summary>
		/// Role.
		/// </summary>
		public SysAdminUnit Role {
			get {
				return _role ??
					(_role = new SysAdminUnit(LookupColumnEntities.GetEntity("Role")));
			}
		}

		/// <summary>
		/// Validation date.
		/// </summary>
		public DateTime ValidationDate {
			get {
				return GetTypedColumnValue<DateTime>("ValidationDate");
			}
			set {
				SetColumnValue("ValidationDate", value);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = new Contact(LookupColumnEntities.GetEntity("Owner")));
			}
		}

		/// <summary>
		/// Comment.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
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

	}

	#endregion

}

