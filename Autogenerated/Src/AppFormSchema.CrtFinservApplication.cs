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

	#region Class: AppForm_CrtFinservApplication_TerrasoftSchema

	/// <exclude/>
	public class AppForm_CrtFinservApplication_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AppForm_CrtFinservApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppForm_CrtFinservApplication_TerrasoftSchema(AppForm_CrtFinservApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppForm_CrtFinservApplication_TerrasoftSchema(AppForm_CrtFinservApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			RealUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			Name = "AppForm_CrtFinservApplication_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateParticipantColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreatePhotoColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0bebb2ec-66ad-4bba-ae06-5865d3a60a6d")) == null) {
				Columns.Add(CreateSurnameColumn());
			}
			if (Columns.FindByUId(new Guid("40dd3804-4c7d-4cfa-b0ef-7261f87e2ca5")) == null) {
				Columns.Add(CreateGivenNameColumn());
			}
			if (Columns.FindByUId(new Guid("188329d9-b6b7-4bb7-a30b-1c842d4248d3")) == null) {
				Columns.Add(CreateMiddleNameColumn());
			}
			if (Columns.FindByUId(new Guid("7f4e2b16-15c4-40f5-aabb-f834202a60dd")) == null) {
				Columns.Add(CreateINNColumn());
			}
			if (Columns.FindByUId(new Guid("8186df70-775f-40c3-bf33-c21724123744")) == null) {
				Columns.Add(CreateBirthDateColumn());
			}
			if (Columns.FindByUId(new Guid("ccd8364c-e4bd-4730-bf94-d5455fbddec7")) == null) {
				Columns.Add(CreatePlaceOfBirthColumn());
			}
			if (Columns.FindByUId(new Guid("90623e03-2f2e-439b-84bb-02f463f0dc49")) == null) {
				Columns.Add(CreateGenderColumn());
			}
			if (Columns.FindByUId(new Guid("8475d8a3-a872-437b-832c-846448395777")) == null) {
				Columns.Add(CreateCitizenshipColumn());
			}
			if (Columns.FindByUId(new Guid("6857fa0a-e2a3-4716-840e-e7ad0892a5db")) == null) {
				Columns.Add(CreateSocialStatusColumn());
			}
			if (Columns.FindByUId(new Guid("fa25d6f6-ab8d-4ebb-915b-9bcbafa98b80")) == null) {
				Columns.Add(CreateSeriesColumn());
			}
			if (Columns.FindByUId(new Guid("61a8e2a5-7a3d-4e73-9607-b094eca8f629")) == null) {
				Columns.Add(CreateNumberColumn());
			}
			if (Columns.FindByUId(new Guid("79f1162e-06b5-49a4-9ab7-909adb819167")) == null) {
				Columns.Add(CreateIssueDateColumn());
			}
			if (Columns.FindByUId(new Guid("cbba1fdc-20fa-4a79-9cd2-8290a43bea9b")) == null) {
				Columns.Add(CreateIssuedByColumn());
			}
			if (Columns.FindByUId(new Guid("5b24ac88-1d58-417b-8537-38b797babc4f")) == null) {
				Columns.Add(CreateCodeDivisionColumn());
			}
			if (Columns.FindByUId(new Guid("d6abf772-c05e-4635-90cb-435412df5517")) == null) {
				Columns.Add(CreateMaritalStatusColumn());
			}
			if (Columns.FindByUId(new Guid("0cc308e6-955f-4664-b8d0-02c9e6669626")) == null) {
				Columns.Add(CreateNumberOfDependantsColumn());
			}
			if (Columns.FindByUId(new Guid("0dde3f67-acf6-406f-9054-f5e36f81a157")) == null) {
				Columns.Add(CreateEmploymentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("ef871641-4eb9-4c9e-b3ac-dcdb4f6e8287")) == null) {
				Columns.Add(CreateTotalWorkExperienceYearsColumn());
			}
			if (Columns.FindByUId(new Guid("ffe2583a-4fb4-4108-af03-628c88a40820")) == null) {
				Columns.Add(CreateTotalWorkExperienceMonthsColumn());
			}
			if (Columns.FindByUId(new Guid("5d492307-c739-4bcb-8ca4-037f24b83f5d")) == null) {
				Columns.Add(CreateIsAgreePrivateDataProcessingColumn());
			}
			if (Columns.FindByUId(new Guid("4a4b98b7-8c95-4602-8735-c47c560ecd91")) == null) {
				Columns.Add(CreateIsAgreePrivateDataVerificationColumn());
			}
			if (Columns.FindByUId(new Guid("3b070930-96e7-4060-8c41-a50780de36e3")) == null) {
				Columns.Add(CreateNumberOfChildrenColumn());
			}
			if (Columns.FindByUId(new Guid("4700cd60-7223-432e-827e-1d12e3761727")) == null) {
				Columns.Add(CreateChildrenUnder14Column());
			}
			if (Columns.FindByUId(new Guid("3e9cc12f-a269-4e27-a418-07de59700e05")) == null) {
				Columns.Add(CreateSpouseSurnameColumn());
			}
			if (Columns.FindByUId(new Guid("3aaaacb4-2971-41d1-8a0f-e51ac7fb476f")) == null) {
				Columns.Add(CreateSpouseGivenNameColumn());
			}
			if (Columns.FindByUId(new Guid("ccaf4620-1144-4d17-9eaf-4b560f2e2451")) == null) {
				Columns.Add(CreateSpouseMiddleNameColumn());
			}
			if (Columns.FindByUId(new Guid("2e7a8637-d0c8-4c42-a441-1cc1ad46ccd1")) == null) {
				Columns.Add(CreateSpouseBirthDateColumn());
			}
			if (Columns.FindByUId(new Guid("f934b89b-21e7-4ed3-8f57-22b9b5866e90")) == null) {
				Columns.Add(CreateQualificationColumn());
			}
			if (Columns.FindByUId(new Guid("600e80da-e303-4e7a-8794-f65bf72cf999")) == null) {
				Columns.Add(CreatePreviousSurnameColumn());
			}
			if (Columns.FindByUId(new Guid("c6f10651-e216-4753-a6d3-cf8c2b0495b4")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
			if (Columns.FindByUId(new Guid("90f3045d-dbd5-4074-afbd-9746b47131cf")) == null) {
				Columns.Add(CreateParticipantRoleColumn());
			}
			if (Columns.FindByUId(new Guid("6523846e-a1ac-4628-abb5-a85a4dad5d89")) == null) {
				Columns.Add(CreateEducationColumn());
			}
			if (Columns.FindByUId(new Guid("1b00dc57-fee1-4f88-9a60-2f40f4fd4280")) == null) {
				Columns.Add(CreateIsSameAddressColumn());
			}
			if (Columns.FindByUId(new Guid("9914c2bf-cdbb-4c48-9d19-54af3c2ac936")) == null) {
				Columns.Add(CreateSpouseContactNumberColumn());
			}
			if (Columns.FindByUId(new Guid("6fa8588b-367a-4b60-9365-58f20d9a3b0d")) == null) {
				Columns.Add(CreateIsNewContactColumn());
			}
			if (Columns.FindByUId(new Guid("61ea04dc-3419-4291-8a9f-8a621d419db8")) == null) {
				Columns.Add(CreateContactColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			return column;
		}

		protected virtual EntitySchemaColumn CreateParticipantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("2c254678-e186-4239-a0df-50696dfba094"),
				Name = @"Participant",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("bfedb8f0-6459-4f37-b286-469b67ef12f5")
			};
		}

		protected virtual EntitySchemaColumn CreateSurnameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0bebb2ec-66ad-4bba-ae06-5865d3a60a6d"),
				Name = @"Surname",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateGivenNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("40dd3804-4c7d-4cfa-b0ef-7261f87e2ca5"),
				Name = @"GivenName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateMiddleNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("188329d9-b6b7-4bb7-a30b-1c842d4248d3"),
				Name = @"MiddleName",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateINNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("7f4e2b16-15c4-40f5-aabb-f834202a60dd"),
				Name = @"INN",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateBirthDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("8186df70-775f-40c3-bf33-c21724123744"),
				Name = @"BirthDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreatePlaceOfBirthColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("ccd8364c-e4bd-4730-bf94-d5455fbddec7"),
				Name = @"PlaceOfBirth",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateGenderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("90623e03-2f2e-439b-84bb-02f463f0dc49"),
				Name = @"Gender",
				ReferenceSchemaUId = new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateCitizenshipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8475d8a3-a872-437b-832c-846448395777"),
				Name = @"Citizenship",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6857fa0a-e2a3-4716-840e-e7ad0892a5db"),
				Name = @"SocialStatus",
				ReferenceSchemaUId = new Guid("73c26dd5-6e65-4b0a-9614-2e5840cd1c04"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateSeriesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("fa25d6f6-ab8d-4ebb-915b-9bcbafa98b80"),
				Name = @"Series",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("61a8e2a5-7a3d-4e73-9607-b094eca8f629"),
				Name = @"Number",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateIssueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("79f1162e-06b5-49a4-9ab7-909adb819167"),
				Name = @"IssueDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateIssuedByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("cbba1fdc-20fa-4a79-9cd2-8290a43bea9b"),
				Name = @"IssuedBy",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeDivisionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5b24ac88-1d58-417b-8537-38b797babc4f"),
				Name = @"CodeDivision",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateMaritalStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d6abf772-c05e-4635-90cb-435412df5517"),
				Name = @"MaritalStatus",
				ReferenceSchemaUId = new Guid("0274ec85-e8c1-4bc9-aacd-e8d4d999cbf9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberOfDependantsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0cc308e6-955f-4664-b8d0-02c9e6669626"),
				Name = @"NumberOfDependants",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateEmploymentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0dde3f67-acf6-406f-9054-f5e36f81a157"),
				Name = @"EmploymentType",
				ReferenceSchemaUId = new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateTotalWorkExperienceYearsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ef871641-4eb9-4c9e-b3ac-dcdb4f6e8287"),
				Name = @"TotalWorkExperienceYears",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateTotalWorkExperienceMonthsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ffe2583a-4fb4-4108-af03-628c88a40820"),
				Name = @"TotalWorkExperienceMonths",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAgreePrivateDataProcessingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5d492307-c739-4bcb-8ca4-037f24b83f5d"),
				Name = @"IsAgreePrivateDataProcessing",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAgreePrivateDataVerificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("4a4b98b7-8c95-4602-8735-c47c560ecd91"),
				Name = @"IsAgreePrivateDataVerification",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberOfChildrenColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3b070930-96e7-4060-8c41-a50780de36e3"),
				Name = @"NumberOfChildren",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateChildrenUnder14Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4700cd60-7223-432e-827e-1d12e3761727"),
				Name = @"ChildrenUnder14",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateSpouseSurnameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3e9cc12f-a269-4e27-a418-07de59700e05"),
				Name = @"SpouseSurname",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateSpouseGivenNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3aaaacb4-2971-41d1-8a0f-e51ac7fb476f"),
				Name = @"SpouseGivenName",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateSpouseMiddleNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ccaf4620-1144-4d17-9eaf-4b560f2e2451"),
				Name = @"SpouseMiddleName",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateSpouseBirthDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("2e7a8637-d0c8-4c42-a441-1cc1ad46ccd1"),
				Name = @"SpouseBirthDate",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateQualificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f934b89b-21e7-4ed3-8f57-22b9b5866e90"),
				Name = @"Qualification",
				ReferenceSchemaUId = new Guid("74e97118-b269-428f-89a0-d6047ee66673"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreatePreviousSurnameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("600e80da-e303-4e7a-8794-f65bf72cf999"),
				Name = @"PreviousSurname",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c6f10651-e216-4753-a6d3-cf8c2b0495b4"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreatePhotoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("a9e7fdce-992f-400b-947c-25a6f0f9f46b"),
				Name = @"Photo",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6ac6409a-8030-4852-b98d-175a105dfb41")
			};
		}

		protected virtual EntitySchemaColumn CreateParticipantRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("90f3045d-dbd5-4074-afbd-9746b47131cf"),
				Name = @"ParticipantRole",
				ReferenceSchemaUId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6ac6409a-8030-4852-b98d-175a105dfb41")
			};
		}

		protected virtual EntitySchemaColumn CreateEducationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6523846e-a1ac-4628-abb5-a85a4dad5d89"),
				Name = @"Education",
				ReferenceSchemaUId = new Guid("0cd2cddb-839f-48ef-aea1-eb905396f0a1"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c")
			};
		}

		protected virtual EntitySchemaColumn CreateIsSameAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1b00dc57-fee1-4f88-9a60-2f40f4fd4280"),
				Name = @"IsSameAddress",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSpouseContactNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("9914c2bf-cdbb-4c48-9d19-54af3c2ac936"),
				Name = @"SpouseContactNumber",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateIsNewContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6fa8588b-367a-4b60-9365-58f20d9a3b0d"),
				Name = @"IsNewContact",
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("61ea04dc-3419-4291-8a9f-8a621d419db8"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				ModifiedInSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
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
			return new AppForm_CrtFinservApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppForm_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppForm_CrtFinservApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppForm_CrtFinservApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"));
		}

		#endregion

	}

	#endregion

	#region Class: AppForm_CrtFinservApplication_Terrasoft

	/// <summary>
	/// Application Form.
	/// </summary>
	public class AppForm_CrtFinservApplication_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AppForm_CrtFinservApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppForm_CrtFinservApplication_Terrasoft";
		}

		public AppForm_CrtFinservApplication_Terrasoft(AppForm_CrtFinservApplication_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
					(_gender = LookupColumnEntities.GetEntity("Gender") as Gender);
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
					(_citizenship = LookupColumnEntities.GetEntity("Citizenship") as Country);
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
					(_socialStatus = LookupColumnEntities.GetEntity("SocialStatus") as SocialStatus);
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
					(_maritalStatus = LookupColumnEntities.GetEntity("MaritalStatus") as MaritalStatus);
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
					(_employmentType = LookupColumnEntities.GetEntity("EmploymentType") as EmploymentType);
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
					(_qualification = LookupColumnEntities.GetEntity("Qualification") as Qualification);
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
					(_finApplication = LookupColumnEntities.GetEntity("FinApplication") as FinApplication);
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
					(_photo = LookupColumnEntities.GetEntity("Photo") as SysImage);
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
					(_participantRole = LookupColumnEntities.GetEntity("ParticipantRole") as ParticipantRole);
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
					(_education = LookupColumnEntities.GetEntity("Education") as Education);
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
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppForm_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppForm_CrtFinservApplication_TerrasoftDeleted", e);
			Saving += (s, e) => ThrowEvent("AppForm_CrtFinservApplication_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AppForm_CrtFinservApplication_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppForm_CrtFinservApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppForm_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppForm_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AppForm_CrtFinservApplication_Terrasoft
	{

		public AppForm_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppForm_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97");
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

	#region Class: AppForm_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppForm_CrtFinservApplicationEventsProcess : AppForm_CrtFinservApplicationEventsProcess<AppForm_CrtFinservApplication_Terrasoft>
	{

		public AppForm_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

