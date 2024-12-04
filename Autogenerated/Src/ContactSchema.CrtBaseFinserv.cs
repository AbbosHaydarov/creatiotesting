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
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.Contact_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtBaseFinserv_TerrasoftSchema(Contact_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtBaseFinserv_TerrasoftSchema(Contact_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8");
			Name = "Contact_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2e1bbae3-941a-44b1-b5e1-25f6381678d4")) == null) {
				Columns.Add(CreateServiceLevelColumn());
			}
			if (Columns.FindByUId(new Guid("2c2d0d33-4210-4825-b995-cfd2f2fcf92a")) == null) {
				Columns.Add(CreateSocialStatusColumn());
			}
			if (Columns.FindByUId(new Guid("fedd9191-771d-4054-94e7-db7327624af0")) == null) {
				Columns.Add(CreateINNColumn());
			}
			if (Columns.FindByUId(new Guid("56ae4485-c589-4bd4-b54a-f1bd913f3ada")) == null) {
				Columns.Add(CreateIsAgreePersonalDataProcessingColumn());
			}
			if (Columns.FindByUId(new Guid("753b03d6-7c35-4c76-8afa-28c6714612a1")) == null) {
				Columns.Add(CreateIsInBlackListColumn());
			}
			if (Columns.FindByUId(new Guid("38b197ca-fc1d-4d55-806d-09cd942f5849")) == null) {
				Columns.Add(CreateBlackListDateColumn());
			}
			if (Columns.FindByUId(new Guid("0ad81545-7439-4d78-936a-82279d372fab")) == null) {
				Columns.Add(CreateBlackListReasonColumn());
			}
			if (Columns.FindByUId(new Guid("9347dfd6-acf0-44dc-a5f7-91358246fdd8")) == null) {
				Columns.Add(CreateBranchColumn());
			}
			if (Columns.FindByUId(new Guid("81ca2575-d1a8-480a-a457-167bc03d1dd9")) == null) {
				Columns.Add(CreateCitizenshipColumn());
			}
			if (Columns.FindByUId(new Guid("c326e129-3dac-458f-905a-8b4931cf2bf3")) == null) {
				Columns.Add(CreateDistrictColumn());
			}
			if (Columns.FindByUId(new Guid("49f90fc7-e3fa-49c7-8200-bf605e9693e8")) == null) {
				Columns.Add(CreateStreetColumn());
			}
			if (Columns.FindByUId(new Guid("4d0d30a5-060f-466f-8a7f-ffd215fc122d")) == null) {
				Columns.Add(CreateBuilding1Column());
			}
			if (Columns.FindByUId(new Guid("891efb80-2a74-4674-b51f-71b11ee3cea4")) == null) {
				Columns.Add(CreateBuilding2Column());
			}
			if (Columns.FindByUId(new Guid("f1226e52-1791-4d3e-88e2-32df69683be3")) == null) {
				Columns.Add(CreateAptOfficeColumn());
			}
			if (Columns.FindByUId(new Guid("aaa3a239-3a51-43b1-a15b-20f9e4a939c2")) == null) {
				Columns.Add(CreatePassportColumn());
			}
			if (Columns.FindByUId(new Guid("76a9f8f2-8f57-4996-b94d-fcadceb550fd")) == null) {
				Columns.Add(CreatePlaceOfBirthColumn());
			}
			if (Columns.FindByUId(new Guid("e2583942-91ba-4052-ac49-f9138bb03771")) == null) {
				Columns.Add(CreateEducationColumn());
			}
			if (Columns.FindByUId(new Guid("2ff774eb-029b-440b-b4a6-b98bf67eec1c")) == null) {
				Columns.Add(CreateMaritalStatusColumn());
			}
			if (Columns.FindByUId(new Guid("86455221-d55e-47e8-966f-714d097f593b")) == null) {
				Columns.Add(CreateSpouseColumn());
			}
			if (Columns.FindByUId(new Guid("f9623f71-dc89-4454-8ee1-77f5adba0080")) == null) {
				Columns.Add(CreateNumberOfFamilyMembersColumn());
			}
			if (Columns.FindByUId(new Guid("4a7c635c-9350-4fc0-a900-3584f53b1c09")) == null) {
				Columns.Add(CreateNumberOfChildrenColumn());
			}
			if (Columns.FindByUId(new Guid("862e28ee-b97f-4cd5-bea9-0d70a9ff32a4")) == null) {
				Columns.Add(CreateIsDeceasedColumn());
			}
			if (Columns.FindByUId(new Guid("c74d5a91-b22a-40cf-a382-49fed258606d")) == null) {
				Columns.Add(CreateDeceasedNotesColumn());
			}
			if (Columns.FindByUId(new Guid("ecfca042-441a-4262-80ff-c0ff233203ac")) == null) {
				Columns.Add(CreateEmploymentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("7c5182e4-a30c-496e-a6eb-3ecba3e478e3")) == null) {
				Columns.Add(CreateClientTypeColumn());
			}
			if (Columns.FindByUId(new Guid("f6e1d2b0-1509-408c-b891-6d2cb7c661cc")) == null) {
				Columns.Add(CreateIsAgreePrivateDataVerificationColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8");
			column.CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
			return column;
		}

		protected override EntitySchemaColumn CreateSurnameColumn() {
			EntitySchemaColumn column = base.CreateSurnameColumn();
			column.ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8");
			column.CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateServiceLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2e1bbae3-941a-44b1-b5e1-25f6381678d4"),
				Name = @"ServiceLevel",
				ReferenceSchemaUId = new Guid("f19a81d2-7b56-49bf-aa20-ca435155ee35"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("ef1c22bc-f60c-4542-a8f9-a8b5b4603c5d")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2c2d0d33-4210-4825-b995-cfd2f2fcf92a"),
				Name = @"SocialStatus",
				ReferenceSchemaUId = new Guid("73c26dd5-6e65-4b0a-9614-2e5840cd1c04"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("ef1c22bc-f60c-4542-a8f9-a8b5b4603c5d")
			};
		}

		protected virtual EntitySchemaColumn CreateINNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("fedd9191-771d-4054-94e7-db7327624af0"),
				Name = @"INN",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("57f657cd-d3d2-4266-ab50-03132e24522a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAgreePersonalDataProcessingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("56ae4485-c589-4bd4-b54a-f1bd913f3ada"),
				Name = @"IsAgreePersonalDataProcessing",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsInBlackListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("753b03d6-7c35-4c76-8afa-28c6714612a1"),
				Name = @"IsInBlackList",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateBlackListDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("38b197ca-fc1d-4d55-806d-09cd942f5849"),
				Name = @"BlackListDate",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateBlackListReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0ad81545-7439-4d78-936a-82279d372fab"),
				Name = @"BlackListReason",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateBranchColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9347dfd6-acf0-44dc-a5f7-91358246fdd8"),
				Name = @"Branch",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateCitizenshipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("81ca2575-d1a8-480a-a457-167bc03d1dd9"),
				Name = @"Citizenship",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateDistrictColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c326e129-3dac-458f-905a-8b4931cf2bf3"),
				Name = @"District",
				ReferenceSchemaUId = new Guid("d31a3b4e-f05e-48c6-b41d-ec79dd5b240f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateStreetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("49f90fc7-e3fa-49c7-8200-bf605e9693e8"),
				Name = @"Street",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateBuilding1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4d0d30a5-060f-466f-8a7f-ffd215fc122d"),
				Name = @"Building1",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateBuilding2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("891efb80-2a74-4674-b51f-71b11ee3cea4"),
				Name = @"Building2",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreateAptOfficeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f1226e52-1791-4d3e-88e2-32df69683be3"),
				Name = @"AptOffice",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("3aeb9fd9-b326-4980-a4cd-4b6ac9d8b422")
			};
		}

		protected virtual EntitySchemaColumn CreatePassportColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("aaa3a239-3a51-43b1-a15b-20f9e4a939c2"),
				Name = @"Passport",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("57f657cd-d3d2-4266-ab50-03132e24522a")
			};
		}

		protected virtual EntitySchemaColumn CreatePlaceOfBirthColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("76a9f8f2-8f57-4996-b94d-fcadceb550fd"),
				Name = @"PlaceOfBirth",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateEducationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e2583942-91ba-4052-ac49-f9138bb03771"),
				Name = @"Education",
				ReferenceSchemaUId = new Guid("0cd2cddb-839f-48ef-aea1-eb905396f0a1"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateMaritalStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2ff774eb-029b-440b-b4a6-b98bf67eec1c"),
				Name = @"MaritalStatus",
				ReferenceSchemaUId = new Guid("0274ec85-e8c1-4bc9-aacd-e8d4d999cbf9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateSpouseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("86455221-d55e-47e8-966f-714d097f593b"),
				Name = @"Spouse",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberOfFamilyMembersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f9623f71-dc89-4454-8ee1-77f5adba0080"),
				Name = @"NumberOfFamilyMembers",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberOfChildrenColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4a7c635c-9350-4fc0-a900-3584f53b1c09"),
				Name = @"NumberOfChildren",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDeceasedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("862e28ee-b97f-4cd5-bea9-0d70a9ff32a4"),
				Name = @"IsDeceased",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateDeceasedNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("c74d5a91-b22a-40cf-a382-49fed258606d"),
				Name = @"DeceasedNotes",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateEmploymentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ecfca042-441a-4262-80ff-c0ff233203ac"),
				Name = @"EmploymentType",
				ReferenceSchemaUId = new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateClientTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7c5182e4-a30c-496e-a6eb-3ecba3e478e3"),
				Name = @"ClientType",
				ReferenceSchemaUId = new Guid("e1cf4d6b-2915-4e19-9e69-66ac3689e115"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAgreePrivateDataVerificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f6e1d2b0-1509-408c-b891-6d2cb7c661cc"),
				Name = @"IsAgreePrivateDataVerification",
				CreatedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				ModifiedInSchemaUId = new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"),
				CreatedInPackageId = new Guid("6f798a6c-821b-4dda-95e1-a275978daa2b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.Contact_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtBaseFinserv_Terrasoft";
		}

		public Contact_CrtBaseFinserv_Terrasoft(Contact_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ServiceLevelId {
			get {
				return GetTypedColumnValue<Guid>("ServiceLevelId");
			}
			set {
				SetColumnValue("ServiceLevelId", value);
				_serviceLevel = null;
			}
		}

		/// <exclude/>
		public string ServiceLevelName {
			get {
				return GetTypedColumnValue<string>("ServiceLevelName");
			}
			set {
				SetColumnValue("ServiceLevelName", value);
				if (_serviceLevel != null) {
					_serviceLevel.Name = value;
				}
			}
		}

		private ServiceLevel _serviceLevel;
		/// <summary>
		/// Segment.
		/// </summary>
		public ServiceLevel ServiceLevel {
			get {
				return _serviceLevel ??
					(_serviceLevel = LookupColumnEntities.GetEntity("ServiceLevel") as ServiceLevel);
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
		/// Consent to the processing of personal data.
		/// </summary>
		public bool IsAgreePersonalDataProcessing {
			get {
				return GetTypedColumnValue<bool>("IsAgreePersonalDataProcessing");
			}
			set {
				SetColumnValue("IsAgreePersonalDataProcessing", value);
			}
		}

		/// <summary>
		/// Blacklisted.
		/// </summary>
		public bool IsInBlackList {
			get {
				return GetTypedColumnValue<bool>("IsInBlackList");
			}
			set {
				SetColumnValue("IsInBlackList", value);
			}
		}

		/// <summary>
		/// Blacklisted on.
		/// </summary>
		public DateTime BlackListDate {
			get {
				return GetTypedColumnValue<DateTime>("BlackListDate");
			}
			set {
				SetColumnValue("BlackListDate", value);
			}
		}

		/// <summary>
		/// Reason for blacklisting.
		/// </summary>
		public string BlackListReason {
			get {
				return GetTypedColumnValue<string>("BlackListReason");
			}
			set {
				SetColumnValue("BlackListReason", value);
			}
		}

		/// <exclude/>
		public Guid BranchId {
			get {
				return GetTypedColumnValue<Guid>("BranchId");
			}
			set {
				SetColumnValue("BranchId", value);
				_branch = null;
			}
		}

		/// <exclude/>
		public string BranchName {
			get {
				return GetTypedColumnValue<string>("BranchName");
			}
			set {
				SetColumnValue("BranchName", value);
				if (_branch != null) {
					_branch.Name = value;
				}
			}
		}

		private Account _branch;
		/// <summary>
		/// Branch.
		/// </summary>
		public Account Branch {
			get {
				return _branch ??
					(_branch = LookupColumnEntities.GetEntity("Branch") as Account);
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
		public Guid DistrictId {
			get {
				return GetTypedColumnValue<Guid>("DistrictId");
			}
			set {
				SetColumnValue("DistrictId", value);
				_district = null;
			}
		}

		/// <exclude/>
		public string DistrictName {
			get {
				return GetTypedColumnValue<string>("DistrictName");
			}
			set {
				SetColumnValue("DistrictName", value);
				if (_district != null) {
					_district.Name = value;
				}
			}
		}

		private District _district;
		/// <summary>
		/// District.
		/// </summary>
		public District District {
			get {
				return _district ??
					(_district = LookupColumnEntities.GetEntity("District") as District);
			}
		}

		/// <summary>
		/// Street.
		/// </summary>
		public string Street {
			get {
				return GetTypedColumnValue<string>("Street");
			}
			set {
				SetColumnValue("Street", value);
			}
		}

		/// <summary>
		/// Building.
		/// </summary>
		public string Building1 {
			get {
				return GetTypedColumnValue<string>("Building1");
			}
			set {
				SetColumnValue("Building1", value);
			}
		}

		/// <summary>
		/// Unit.
		/// </summary>
		public string Building2 {
			get {
				return GetTypedColumnValue<string>("Building2");
			}
			set {
				SetColumnValue("Building2", value);
			}
		}

		/// <summary>
		/// Apartment/office.
		/// </summary>
		public string AptOffice {
			get {
				return GetTypedColumnValue<string>("AptOffice");
			}
			set {
				SetColumnValue("AptOffice", value);
			}
		}

		/// <summary>
		/// Passport.
		/// </summary>
		public string Passport {
			get {
				return GetTypedColumnValue<string>("Passport");
			}
			set {
				SetColumnValue("Passport", value);
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

		/// <exclude/>
		public Guid SpouseId {
			get {
				return GetTypedColumnValue<Guid>("SpouseId");
			}
			set {
				SetColumnValue("SpouseId", value);
				_spouse = null;
			}
		}

		/// <exclude/>
		public string SpouseName {
			get {
				return GetTypedColumnValue<string>("SpouseName");
			}
			set {
				SetColumnValue("SpouseName", value);
				if (_spouse != null) {
					_spouse.Name = value;
				}
			}
		}

		private Contact _spouse;
		/// <summary>
		/// Spouse.
		/// </summary>
		public Contact Spouse {
			get {
				return _spouse ??
					(_spouse = LookupColumnEntities.GetEntity("Spouse") as Contact);
			}
		}

		/// <summary>
		/// Number of family members.
		/// </summary>
		public int NumberOfFamilyMembers {
			get {
				return GetTypedColumnValue<int>("NumberOfFamilyMembers");
			}
			set {
				SetColumnValue("NumberOfFamilyMembers", value);
			}
		}

		/// <summary>
		/// Number of childern.
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
		/// Deceased.
		/// </summary>
		public bool IsDeceased {
			get {
				return GetTypedColumnValue<bool>("IsDeceased");
			}
			set {
				SetColumnValue("IsDeceased", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string DeceasedNotes {
			get {
				return GetTypedColumnValue<string>("DeceasedNotes");
			}
			set {
				SetColumnValue("DeceasedNotes", value);
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

		/// <exclude/>
		public Guid ClientTypeId {
			get {
				return GetTypedColumnValue<Guid>("ClientTypeId");
			}
			set {
				SetColumnValue("ClientTypeId", value);
				_clientType = null;
			}
		}

		/// <exclude/>
		public string ClientTypeName {
			get {
				return GetTypedColumnValue<string>("ClientTypeName");
			}
			set {
				SetColumnValue("ClientTypeName", value);
				if (_clientType != null) {
					_clientType.Name = value;
				}
			}
		}

		private ClientType _clientType;
		/// <summary>
		/// Customer type.
		/// </summary>
		public ClientType ClientType {
			get {
				return _clientType ??
					(_clientType = LookupColumnEntities.GetEntity("ClientType") as ClientType);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftSaving", e);
			Updating += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftUpdating", e);
			Validating += (s, e) => ThrowEvent("Contact_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class Contact_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.Contact_CrtCustomer360AppEventsProcess<TEntity> where TEntity : Contact_CrtBaseFinserv_Terrasoft
	{

		public Contact_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("92b46296-406b-41a0-b75f-81ccf5fddae8");
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

	#region Class: Contact_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class Contact_CrtBaseFinservEventsProcess : Contact_CrtBaseFinservEventsProcess<Contact_CrtBaseFinserv_Terrasoft>
	{

		public Contact_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

