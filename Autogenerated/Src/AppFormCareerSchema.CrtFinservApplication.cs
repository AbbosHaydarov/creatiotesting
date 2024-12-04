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

	#region Class: AppFormCareerSchema

	/// <exclude/>
	public class AppFormCareerSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AppFormCareerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormCareerSchema(AppFormCareerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormCareerSchema(AppFormCareerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63");
			RealUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63");
			Name = "AppFormCareer";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6ffc5e9e-4f38-4bcf-8cb5-f406962a4a53")) == null) {
				Columns.Add(CreateEmployerColumn());
			}
			if (Columns.FindByUId(new Guid("52f11d3f-b19f-4d80-95d9-fc1a424c0d7d")) == null) {
				Columns.Add(CreateLegalFormColumn());
			}
			if (Columns.FindByUId(new Guid("68da8047-62bd-41bb-a516-f621fec784da")) == null) {
				Columns.Add(CreateIndustryColumn());
			}
			if (Columns.FindByUId(new Guid("3711fdd5-153f-4e93-a9d5-d026240ab755")) == null) {
				Columns.Add(CreateBusinessPhoneColumn());
			}
			if (Columns.FindByUId(new Guid("ef5fc651-70a1-4635-ba9f-7141d018ddeb")) == null) {
				Columns.Add(CreateRoleColumn());
			}
			if (Columns.FindByUId(new Guid("72a1ac86-5f45-47ea-81dd-14cabac6e246")) == null) {
				Columns.Add(CreateJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("d33582dc-5d82-454f-abe1-30fb7eed08ca")) == null) {
				Columns.Add(CreateYearsOfEmploymentColumn());
			}
			if (Columns.FindByUId(new Guid("df780198-a6d4-4eec-8460-09847c144d88")) == null) {
				Columns.Add(CreateMonthOfEmploymentColumn());
			}
			if (Columns.FindByUId(new Guid("01054450-258d-4f79-87d4-4704939faeba")) == null) {
				Columns.Add(CreatePrimaryColumn());
			}
			if (Columns.FindByUId(new Guid("f1ec0e19-5ac9-48ce-8270-9ac4281eb076")) == null) {
				Columns.Add(CreateCurrentColumn());
			}
			if (Columns.FindByUId(new Guid("c51fb2c8-8aea-4389-b4f5-92fa2cf2b906")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEmployerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6ffc5e9e-4f38-4bcf-8cb5-f406962a4a53"),
				Name = @"Employer",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateLegalFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("52f11d3f-b19f-4d80-95d9-fc1a424c0d7d"),
				Name = @"LegalForm",
				ReferenceSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateIndustryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("68da8047-62bd-41bb-a516-f621fec784da"),
				Name = @"Industry",
				ReferenceSchemaUId = new Guid("95de3d3b-b909-40d9-a3fa-e80d38ec208e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateBusinessPhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3711fdd5-153f-4e93-a9d5-d026240ab755"),
				Name = @"BusinessPhone",
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ef5fc651-70a1-4635-ba9f-7141d018ddeb"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("54aa771f-fba6-4d76-9239-bff3f00ee3e5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("72a1ac86-5f45-47ea-81dd-14cabac6e246"),
				Name = @"JobTitle",
				ReferenceSchemaUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateYearsOfEmploymentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d33582dc-5d82-454f-abe1-30fb7eed08ca"),
				Name = @"YearsOfEmployment",
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateMonthOfEmploymentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("df780198-a6d4-4eec-8460-09847c144d88"),
				Name = @"MonthOfEmployment",
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("01054450-258d-4f79-87d4-4704939faeba"),
				Name = @"Primary",
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f1ec0e19-5ac9-48ce-8270-9ac4281eb076"),
				Name = @"Current",
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c51fb2c8-8aea-4389-b4f5-92fa2cf2b906"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
				ModifiedInSchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"),
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
			return new AppFormCareer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormCareer_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormCareerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormCareerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormCareer

	/// <summary>
	/// Career in application form.
	/// </summary>
	public class AppFormCareer : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AppFormCareer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormCareer";
		}

		public AppFormCareer(AppFormCareer source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
					(_employer = LookupColumnEntities.GetEntity("Employer") as Account);
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
					(_legalForm = LookupColumnEntities.GetEntity("LegalForm") as AccountOwnership);
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
					(_industry = LookupColumnEntities.GetEntity("Industry") as AccountIndustry);
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
					(_role = LookupColumnEntities.GetEntity("Role") as ContactDecisionRole);
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
					(_jobTitle = LookupColumnEntities.GetEntity("JobTitle") as Job);
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
					(_appForm = LookupColumnEntities.GetEntity("AppForm") as AppForm);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormCareer_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormCareerDeleted", e);
			Validating += (s, e) => ThrowEvent("AppFormCareerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormCareer(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormCareer_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormCareer_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AppFormCareer
	{

		public AppFormCareer_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormCareer_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9dd445a9-8e5e-4931-9489-083be73e6a63");
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

	#region Class: AppFormCareer_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormCareer_CrtFinservApplicationEventsProcess : AppFormCareer_CrtFinservApplicationEventsProcess<AppFormCareer>
	{

		public AppFormCareer_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormCareer_CrtFinservApplicationEventsProcess

	public partial class AppFormCareer_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormCareerEventsProcess

	/// <exclude/>
	public class AppFormCareerEventsProcess : AppFormCareer_CrtFinservApplicationEventsProcess
	{

		public AppFormCareerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

