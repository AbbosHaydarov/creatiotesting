namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AppForm

	/// <exclude/>
	public class AppForm : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AppForm(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppForm";
		}

		public AppForm(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AppForm";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AppFormAddress> AppFormAddressCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppFormCareer> AppFormCareerCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppFormCommunication> AppFormCommunicationCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppFormFile> AppFormFileCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppFormInFolder> AppFormInFolderCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppFormInTag> AppFormInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<AppFormMainContact> AppFormMainContactCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppFormObligation> AppFormObligationCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppFormProperty> AppFormPropertyCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<AppValidation> AppValidationCollectionByParticipant {
			get;
			set;
		}

		public IEnumerable<DocListInFinApp> DocListInFinAppCollectionByAppForm {
			get;
			set;
		}

		public IEnumerable<IncomeAndExpenseInAppForm> IncomeAndExpenseInAppFormCollectionByAppForm {
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
		/// Participant.
		/// </summary>
		public string Participant {
			get {
				return GetTypedColumnValue<string>("Participant");
			}
			set {
				SetColumnValue("Participant", value);
			}
		}

		/// <summary>
		/// Last name.
		/// </summary>
		public string Surname {
			get {
				return GetTypedColumnValue<string>("Surname");
			}
			set {
				SetColumnValue("Surname", value);
			}
		}

		/// <summary>
		/// First name.
		/// </summary>
		public string GivenName {
			get {
				return GetTypedColumnValue<string>("GivenName");
			}
			set {
				SetColumnValue("GivenName", value);
			}
		}

		/// <summary>
		/// Middle name.
		/// </summary>
		public string MiddleName {
			get {
				return GetTypedColumnValue<string>("MiddleName");
			}
			set {
				SetColumnValue("MiddleName", value);
			}
		}

		/// <summary>
		/// SSN.
		/// </summary>
		public string INN {
			get {
				return GetTypedColumnValue<string>("INN");
			}
			set {
				SetColumnValue("INN", value);
			}
		}

		/// <summary>
		/// Birth date.
		/// </summary>
		public DateTime BirthDate {
			get {
				return GetTypedColumnValue<DateTime>("BirthDate");
			}
			set {
				SetColumnValue("BirthDate", value);
			}
		}

		/// <summary>
		/// Birthplace.
		/// </summary>
		public string PlaceOfBirth {
			get {
				return GetTypedColumnValue<string>("PlaceOfBirth");
			}
			set {
				SetColumnValue("PlaceOfBirth", value);
			}
		}

		/// <exclude/>
		public Guid GenderId {
			get {
				return GetTypedColumnValue<Guid>("GenderId");
			}
			set {
				SetColumnValue("GenderId", value);
				_gender = null;
			}
		}

		/// <exclude/>
		public string GenderName {
			get {
				return GetTypedColumnValue<string>("GenderName");
			}
			set {
				SetColumnValue("GenderName", value);
				if (_gender != null) {
					_gender.Name = value;
				}
			}
		}

		private Gender _gender;
		/// <summary>
		/// Gender.
		/// </summary>
		public Gender Gender {
			get {
				return _gender ??
					(_gender = new Gender(LookupColumnEntities.GetEntity("Gender")));
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
		public Guid SocialStatusId {
			get {
				return GetTypedColumnValue<Guid>("SocialStatusId");
			}
			set {
				SetColumnValue("SocialStatusId", value);
				_socialStatus = null;
			}
		}

		/// <exclude/>
		public string SocialStatusName {
			get {
				return GetTypedColumnValue<string>("SocialStatusName");
			}
			set {
				SetColumnValue("SocialStatusName", value);
				if (_socialStatus != null) {
					_socialStatus.Name = value;
				}
			}
		}

		private SocialStatus _socialStatus;
		/// <summary>
		/// Social status.
		/// </summary>
		public SocialStatus SocialStatus {
			get {
				return _socialStatus ??
					(_socialStatus = new SocialStatus(LookupColumnEntities.GetEntity("SocialStatus")));
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
		/// Issue date.
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

		/// <exclude/>
		public Guid MaritalStatusId {
			get {
				return GetTypedColumnValue<Guid>("MaritalStatusId");
			}
			set {
				SetColumnValue("MaritalStatusId", value);
				_maritalStatus = null;
			}
		}

		/// <exclude/>
		public string MaritalStatusName {
			get {
				return GetTypedColumnValue<string>("MaritalStatusName");
			}
			set {
				SetColumnValue("MaritalStatusName", value);
				if (_maritalStatus != null) {
					_maritalStatus.Name = value;
				}
			}
		}

		private MaritalStatus _maritalStatus;
		/// <summary>
		/// Marital status.
		/// </summary>
		public MaritalStatus MaritalStatus {
			get {
				return _maritalStatus ??
					(_maritalStatus = new MaritalStatus(LookupColumnEntities.GetEntity("MaritalStatus")));
			}
		}

		/// <summary>
		/// Number of dependants.
		/// </summary>
		public int NumberOfDependants {
			get {
				return GetTypedColumnValue<int>("NumberOfDependants");
			}
			set {
				SetColumnValue("NumberOfDependants", value);
			}
		}

		/// <exclude/>
		public Guid EmploymentTypeId {
			get {
				return GetTypedColumnValue<Guid>("EmploymentTypeId");
			}
			set {
				SetColumnValue("EmploymentTypeId", value);
				_employmentType = null;
			}
		}

		/// <exclude/>
		public string EmploymentTypeName {
			get {
				return GetTypedColumnValue<string>("EmploymentTypeName");
			}
			set {
				SetColumnValue("EmploymentTypeName", value);
				if (_employmentType != null) {
					_employmentType.Name = value;
				}
			}
		}

		private EmploymentType _employmentType;
		/// <summary>
		/// Type of employment.
		/// </summary>
		public EmploymentType EmploymentType {
			get {
				return _employmentType ??
					(_employmentType = new EmploymentType(LookupColumnEntities.GetEntity("EmploymentType")));
			}
		}

		/// <summary>
		/// Total work experience, years.
		/// </summary>
		public int TotalWorkExperienceYears {
			get {
				return GetTypedColumnValue<int>("TotalWorkExperienceYears");
			}
			set {
				SetColumnValue("TotalWorkExperienceYears", value);
			}
		}

		/// <summary>
		/// Total work experience, months.
		/// </summary>
		public int TotalWorkExperienceMonths {
			get {
				return GetTypedColumnValue<int>("TotalWorkExperienceMonths");
			}
			set {
				SetColumnValue("TotalWorkExperienceMonths", value);
			}
		}

		/// <summary>
		/// Consent to the processing of personal data.
		/// </summary>
		public bool IsAgreePrivateDataProcessing {
			get {
				return GetTypedColumnValue<bool>("IsAgreePrivateDataProcessing");
			}
			set {
				SetColumnValue("IsAgreePrivateDataProcessing", value);
			}
		}

		/// <summary>
		/// Consent to the verification of personal data.
		/// </summary>
		public bool IsAgreePrivateDataVerification {
			get {
				return GetTypedColumnValue<bool>("IsAgreePrivateDataVerification");
			}
			set {
				SetColumnValue("IsAgreePrivateDataVerification", value);
			}
		}

		/// <summary>
		/// Number of children.
		/// </summary>
		public int NumberOfChildren {
			get {
				return GetTypedColumnValue<int>("NumberOfChildren");
			}
			set {
				SetColumnValue("NumberOfChildren", value);
			}
		}

		/// <summary>
		/// Children under 14.
		/// </summary>
		public int ChildrenUnder14 {
			get {
				return GetTypedColumnValue<int>("ChildrenUnder14");
			}
			set {
				SetColumnValue("ChildrenUnder14", value);
			}
		}

		/// <summary>
		/// Spouse last name.
		/// </summary>
		public string SpouseSurname {
			get {
				return GetTypedColumnValue<string>("SpouseSurname");
			}
			set {
				SetColumnValue("SpouseSurname", value);
			}
		}

		/// <summary>
		/// Spouse given name.
		/// </summary>
		public string SpouseGivenName {
			get {
				return GetTypedColumnValue<string>("SpouseGivenName");
			}
			set {
				SetColumnValue("SpouseGivenName", value);
			}
		}

		/// <summary>
		/// Spouse middle name.
		/// </summary>
		public string SpouseMiddleName {
			get {
				return GetTypedColumnValue<string>("SpouseMiddleName");
			}
			set {
				SetColumnValue("SpouseMiddleName", value);
			}
		}

		/// <summary>
		/// Spouse birth date.
		/// </summary>
		public DateTime SpouseBirthDate {
			get {
				return GetTypedColumnValue<DateTime>("SpouseBirthDate");
			}
			set {
				SetColumnValue("SpouseBirthDate", value);
			}
		}

		/// <exclude/>
		public Guid QualificationId {
			get {
				return GetTypedColumnValue<Guid>("QualificationId");
			}
			set {
				SetColumnValue("QualificationId", value);
				_qualification = null;
			}
		}

		/// <exclude/>
		public string QualificationName {
			get {
				return GetTypedColumnValue<string>("QualificationName");
			}
			set {
				SetColumnValue("QualificationName", value);
				if (_qualification != null) {
					_qualification.Name = value;
				}
			}
		}

		private Qualification _qualification;
		/// <summary>
		/// Qualification.
		/// </summary>
		public Qualification Qualification {
			get {
				return _qualification ??
					(_qualification = new Qualification(LookupColumnEntities.GetEntity("Qualification")));
			}
		}

		/// <summary>
		/// Former name.
		/// </summary>
		public string PreviousSurname {
			get {
				return GetTypedColumnValue<string>("PreviousSurname");
			}
			set {
				SetColumnValue("PreviousSurname", value);
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
		public Guid PhotoId {
			get {
				return GetTypedColumnValue<Guid>("PhotoId");
			}
			set {
				SetColumnValue("PhotoId", value);
				_photo = null;
			}
		}

		/// <exclude/>
		public string PhotoName {
			get {
				return GetTypedColumnValue<string>("PhotoName");
			}
			set {
				SetColumnValue("PhotoName", value);
				if (_photo != null) {
					_photo.Name = value;
				}
			}
		}

		private SysImage _photo;
		/// <summary>
		/// Photo.
		/// </summary>
		public SysImage Photo {
			get {
				return _photo ??
					(_photo = new SysImage(LookupColumnEntities.GetEntity("Photo")));
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
		public Guid EducationId {
			get {
				return GetTypedColumnValue<Guid>("EducationId");
			}
			set {
				SetColumnValue("EducationId", value);
				_education = null;
			}
		}

		/// <exclude/>
		public string EducationName {
			get {
				return GetTypedColumnValue<string>("EducationName");
			}
			set {
				SetColumnValue("EducationName", value);
				if (_education != null) {
					_education.Name = value;
				}
			}
		}

		private Education _education;
		/// <summary>
		/// Education.
		/// </summary>
		public Education Education {
			get {
				return _education ??
					(_education = new Education(LookupColumnEntities.GetEntity("Education")));
			}
		}

		/// <summary>
		/// Same as above address.
		/// </summary>
		public bool IsSameAddress {
			get {
				return GetTypedColumnValue<bool>("IsSameAddress");
			}
			set {
				SetColumnValue("IsSameAddress", value);
			}
		}

		/// <summary>
		/// Spouse contact phone.
		/// </summary>
		public string SpouseContactNumber {
			get {
				return GetTypedColumnValue<string>("SpouseContactNumber");
			}
			set {
				SetColumnValue("SpouseContactNumber", value);
			}
		}

		/// <summary>
		/// New contact.
		/// </summary>
		public bool IsNewContact {
			get {
				return GetTypedColumnValue<bool>("IsNewContact");
			}
			set {
				SetColumnValue("IsNewContact", value);
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

		#endregion

	}

	#endregion

}

