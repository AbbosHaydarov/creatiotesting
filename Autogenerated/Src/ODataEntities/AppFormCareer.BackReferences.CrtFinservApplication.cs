namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AppFormCareer

	/// <exclude/>
	public class AppFormCareer : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AppFormCareer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormCareer";
		}

		public AppFormCareer(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AppFormCareer";
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
		public Guid EmployerId {
			get {
				return GetTypedColumnValue<Guid>("EmployerId");
			}
			set {
				SetColumnValue("EmployerId", value);
				_employer = null;
			}
		}

		/// <exclude/>
		public string EmployerName {
			get {
				return GetTypedColumnValue<string>("EmployerName");
			}
			set {
				SetColumnValue("EmployerName", value);
				if (_employer != null) {
					_employer.Name = value;
				}
			}
		}

		private Account _employer;
		/// <summary>
		/// Employer.
		/// </summary>
		public Account Employer {
			get {
				return _employer ??
					(_employer = new Account(LookupColumnEntities.GetEntity("Employer")));
			}
		}

		/// <exclude/>
		public Guid LegalFormId {
			get {
				return GetTypedColumnValue<Guid>("LegalFormId");
			}
			set {
				SetColumnValue("LegalFormId", value);
				_legalForm = null;
			}
		}

		/// <exclude/>
		public string LegalFormName {
			get {
				return GetTypedColumnValue<string>("LegalFormName");
			}
			set {
				SetColumnValue("LegalFormName", value);
				if (_legalForm != null) {
					_legalForm.Name = value;
				}
			}
		}

		private AccountOwnership _legalForm;
		/// <summary>
		/// Legal form.
		/// </summary>
		public AccountOwnership LegalForm {
			get {
				return _legalForm ??
					(_legalForm = new AccountOwnership(LookupColumnEntities.GetEntity("LegalForm")));
			}
		}

		/// <exclude/>
		public Guid IndustryId {
			get {
				return GetTypedColumnValue<Guid>("IndustryId");
			}
			set {
				SetColumnValue("IndustryId", value);
				_industry = null;
			}
		}

		/// <exclude/>
		public string IndustryName {
			get {
				return GetTypedColumnValue<string>("IndustryName");
			}
			set {
				SetColumnValue("IndustryName", value);
				if (_industry != null) {
					_industry.Name = value;
				}
			}
		}

		private AccountIndustry _industry;
		/// <summary>
		/// Industry.
		/// </summary>
		public AccountIndustry Industry {
			get {
				return _industry ??
					(_industry = new AccountIndustry(LookupColumnEntities.GetEntity("Industry")));
			}
		}

		/// <summary>
		/// Business phone.
		/// </summary>
		public string BusinessPhone {
			get {
				return GetTypedColumnValue<string>("BusinessPhone");
			}
			set {
				SetColumnValue("BusinessPhone", value);
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

		private ContactDecisionRole _role;
		/// <summary>
		/// Role.
		/// </summary>
		public ContactDecisionRole Role {
			get {
				return _role ??
					(_role = new ContactDecisionRole(LookupColumnEntities.GetEntity("Role")));
			}
		}

		/// <exclude/>
		public Guid JobTitleId {
			get {
				return GetTypedColumnValue<Guid>("JobTitleId");
			}
			set {
				SetColumnValue("JobTitleId", value);
				_jobTitle = null;
			}
		}

		/// <exclude/>
		public string JobTitleName {
			get {
				return GetTypedColumnValue<string>("JobTitleName");
			}
			set {
				SetColumnValue("JobTitleName", value);
				if (_jobTitle != null) {
					_jobTitle.Name = value;
				}
			}
		}

		private Job _jobTitle;
		/// <summary>
		/// Job title.
		/// </summary>
		public Job JobTitle {
			get {
				return _jobTitle ??
					(_jobTitle = new Job(LookupColumnEntities.GetEntity("JobTitle")));
			}
		}

		/// <summary>
		/// Length of employment, years.
		/// </summary>
		public int YearsOfEmployment {
			get {
				return GetTypedColumnValue<int>("YearsOfEmployment");
			}
			set {
				SetColumnValue("YearsOfEmployment", value);
			}
		}

		/// <summary>
		/// Length of employment, month.
		/// </summary>
		public int MonthOfEmployment {
			get {
				return GetTypedColumnValue<int>("MonthOfEmployment");
			}
			set {
				SetColumnValue("MonthOfEmployment", value);
			}
		}

		/// <summary>
		/// Primary.
		/// </summary>
		public bool Primary {
			get {
				return GetTypedColumnValue<bool>("Primary");
			}
			set {
				SetColumnValue("Primary", value);
			}
		}

		/// <summary>
		/// Current.
		/// </summary>
		public bool Current {
			get {
				return GetTypedColumnValue<bool>("Current");
			}
			set {
				SetColumnValue("Current", value);
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

