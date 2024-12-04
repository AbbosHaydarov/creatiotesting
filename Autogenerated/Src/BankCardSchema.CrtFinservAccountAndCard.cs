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

	#region Class: BankCardSchema

	/// <exclude/>
	public class BankCardSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BankCardSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardSchema(BankCardSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardSchema(BankCardSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			RealUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			Name = "BankCard";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e26f0fd8-93a3-44c0-bffd-86076309d502")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("18d5e12f-04fb-4b61-ae7c-a06d44e28a2f")) == null) {
				Columns.Add(CreateBankCardTypeColumn());
			}
			if (Columns.FindByUId(new Guid("a7d77b03-14f6-400b-abf0-87eef444e5c5")) == null) {
				Columns.Add(CreateBankCardPaymentSystemColumn());
			}
			if (Columns.FindByUId(new Guid("05018344-931a-4848-8372-929698b4b450")) == null) {
				Columns.Add(CreateBankCardCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("96447d3d-7b78-4a6d-b476-e4a2d47fc3fe")) == null) {
				Columns.Add(CreateHolderColumn());
			}
			if (Columns.FindByUId(new Guid("6af1d020-4ee1-4351-a268-b474bf61ef73")) == null) {
				Columns.Add(CreateIsPrimaryColumn());
			}
			if (Columns.FindByUId(new Guid("95c924ce-da5b-4e6e-bb03-df38cf0f5371")) == null) {
				Columns.Add(CreateIsMulticurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("6d9c13a1-07e9-4ed3-b980-0afb1eb419a6")) == null) {
				Columns.Add(CreateBranchColumn());
			}
			if (Columns.FindByUId(new Guid("f5309b60-67d9-4c40-b55d-aa9e304c89dd")) == null) {
				Columns.Add(CreateDivisionColumn());
			}
			if (Columns.FindByUId(new Guid("28065f70-ee59-4673-ac04-b902a19c5c8c")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("a8d6bf81-c8b2-4328-83da-914174ee5d25")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("b1b16413-d565-469b-83f7-483e84b59ac4")) == null) {
				Columns.Add(CreateBankCardStatusColumn());
			}
			if (Columns.FindByUId(new Guid("428d3bc4-81a7-4b67-842e-e1354327bd27")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("bba3c08e-432c-469d-b8a3-9115baa072cc")) == null) {
				Columns.Add(CreateBankCardOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("3d0c0a82-561e-470a-95e9-33a4f2f8d8b3")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("f6870855-0867-4f61-98f9-e801d1563beb")) == null) {
				Columns.Add(CreateContractColumn());
			}
			if (Columns.FindByUId(new Guid("9444b73d-8650-4d23-a7d5-a49004c17d5e")) == null) {
				Columns.Add(CreatePackageColumn());
			}
			if (Columns.FindByUId(new Guid("62f36bd7-b255-4f37-91c8-c573ba71827b")) == null) {
				Columns.Add(CreateContactNameEngColumn());
			}
			if (Columns.FindByUId(new Guid("0f1df890-09ae-4318-8b51-03ea92d2b3d7")) == null) {
				Columns.Add(CreateIsPayPassPayWaveColumn());
			}
			if (Columns.FindByUId(new Guid("da986698-c7cc-4495-80c1-1513e36d284a")) == null) {
				Columns.Add(CreateValidDateColumn());
			}
			if (Columns.FindByUId(new Guid("1b4fa62f-2836-4f1b-8bd7-c2e726ff474c")) == null) {
				Columns.Add(CreateBalanceColumn());
			}
			if (Columns.FindByUId(new Guid("d26c5532-3b48-40fc-b07a-d530a540a374")) == null) {
				Columns.Add(CreateCashLimitColumn());
			}
			if (Columns.FindByUId(new Guid("d2d6ce69-f6b4-41e6-8b0b-b07759a0e120")) == null) {
				Columns.Add(CreateDebtColumn());
			}
			if (Columns.FindByUId(new Guid("f1261a6f-4288-45d8-a301-a63e5f637cfc")) == null) {
				Columns.Add(CreateRepayDateColumn());
			}
			if (Columns.FindByUId(new Guid("60b65809-c6d0-b9c9-c31e-c84080ad634f")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			column.CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e26f0fd8-93a3-44c0-bffd-86076309d502"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5475de06-4bd5-4b29-bb8b-f3a0596a0817")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("61fe12d3-1e2b-4cf6-84a1-d7af71a5884f"),
				Name = @"Number",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateBankCardTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("18d5e12f-04fb-4b61-ae7c-a06d44e28a2f"),
				Name = @"BankCardType",
				ReferenceSchemaUId = new Guid("29a6d264-a74b-4c8a-9975-055cdf78b507"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateBankCardPaymentSystemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a7d77b03-14f6-400b-abf0-87eef444e5c5"),
				Name = @"BankCardPaymentSystem",
				ReferenceSchemaUId = new Guid("fca59039-a1ac-4f36-a2be-009b7182c824"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateBankCardCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("05018344-931a-4848-8372-929698b4b450"),
				Name = @"BankCardCategory",
				ReferenceSchemaUId = new Guid("0765b4c7-db02-4ceb-92aa-6e1938df7e2e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateHolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("96447d3d-7b78-4a6d-b476-e4a2d47fc3fe"),
				Name = @"Holder",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateIsPrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6af1d020-4ee1-4351-a268-b474bf61ef73"),
				Name = @"IsPrimary",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateIsMulticurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("95c924ce-da5b-4e6e-bb03-df38cf0f5371"),
				Name = @"IsMulticurrency",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateBranchColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6d9c13a1-07e9-4ed3-b980-0afb1eb419a6"),
				Name = @"Branch",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateDivisionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f5309b60-67d9-4c40-b55d-aa9e304c89dd"),
				Name = @"Division",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("28065f70-ee59-4673-ac04-b902a19c5c8c"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("a8d6bf81-c8b2-4328-83da-914174ee5d25"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateBankCardStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b1b16413-d565-469b-83f7-483e84b59ac4"),
				Name = @"BankCardStatus",
				ReferenceSchemaUId = new Guid("b98f2a7a-9b32-412f-ab81-2caedf117ca9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"BankCardStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("428d3bc4-81a7-4b67-842e-e1354327bd27"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateBankCardOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bba3c08e-432c-469d-b8a3-9115baa072cc"),
				Name = @"BankCardOwner",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3d0c0a82-561e-470a-95e9-33a4f2f8d8b3"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("04ba647c-7304-4766-b5bf-2558c4aa2694")
			};
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f6870855-0867-4f61-98f9-e801d1563beb"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("a8eafc64-1d25-480f-ac4c-49fe9d09980f")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9444b73d-8650-4d23-a7d5-a49004c17d5e"),
				Name = @"Package",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateContactNameEngColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("62f36bd7-b255-4f37-91c8-c573ba71827b"),
				Name = @"ContactNameEng",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateIsPayPassPayWaveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0f1df890-09ae-4318-8b51-03ea92d2b3d7"),
				Name = @"IsPayPassPayWave",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateValidDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("da986698-c7cc-4495-80c1-1513e36d284a"),
				Name = @"ValidDate",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateBalanceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("1b4fa62f-2836-4f1b-8bd7-c2e726ff474c"),
				Name = @"Balance",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateCashLimitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d26c5532-3b48-40fc-b07a-d530a540a374"),
				Name = @"CashLimit",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateDebtColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d2d6ce69-f6b4-41e6-8b0b-b07759a0e120"),
				Name = @"Debt",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateRepayDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("f1261a6f-4288-45d8-a301-a63e5f637cfc"),
				Name = @"RepayDate",
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("60b65809-c6d0-b9c9-c31e-c84080ad634f"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				ModifiedInSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				CreatedInPackageId = new Guid("ddfd5d39-f04b-461e-bb22-4a9a1cde5b2f"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankCard(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCard_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCard

	/// <summary>
	/// Card.
	/// </summary>
	public class BankCard : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BankCard(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCard";
		}

		public BankCard(BankCard source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Owner.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
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

		/// <exclude/>
		public Guid BankCardTypeId {
			get {
				return GetTypedColumnValue<Guid>("BankCardTypeId");
			}
			set {
				SetColumnValue("BankCardTypeId", value);
				_bankCardType = null;
			}
		}

		/// <exclude/>
		public string BankCardTypeName {
			get {
				return GetTypedColumnValue<string>("BankCardTypeName");
			}
			set {
				SetColumnValue("BankCardTypeName", value);
				if (_bankCardType != null) {
					_bankCardType.Name = value;
				}
			}
		}

		private BankCardType _bankCardType;
		/// <summary>
		/// Type.
		/// </summary>
		public BankCardType BankCardType {
			get {
				return _bankCardType ??
					(_bankCardType = LookupColumnEntities.GetEntity("BankCardType") as BankCardType);
			}
		}

		/// <exclude/>
		public Guid BankCardPaymentSystemId {
			get {
				return GetTypedColumnValue<Guid>("BankCardPaymentSystemId");
			}
			set {
				SetColumnValue("BankCardPaymentSystemId", value);
				_bankCardPaymentSystem = null;
			}
		}

		/// <exclude/>
		public string BankCardPaymentSystemName {
			get {
				return GetTypedColumnValue<string>("BankCardPaymentSystemName");
			}
			set {
				SetColumnValue("BankCardPaymentSystemName", value);
				if (_bankCardPaymentSystem != null) {
					_bankCardPaymentSystem.Name = value;
				}
			}
		}

		private BankCardPaymentSystem _bankCardPaymentSystem;
		/// <summary>
		/// Payment system.
		/// </summary>
		public BankCardPaymentSystem BankCardPaymentSystem {
			get {
				return _bankCardPaymentSystem ??
					(_bankCardPaymentSystem = LookupColumnEntities.GetEntity("BankCardPaymentSystem") as BankCardPaymentSystem);
			}
		}

		/// <exclude/>
		public Guid BankCardCategoryId {
			get {
				return GetTypedColumnValue<Guid>("BankCardCategoryId");
			}
			set {
				SetColumnValue("BankCardCategoryId", value);
				_bankCardCategory = null;
			}
		}

		/// <exclude/>
		public string BankCardCategoryName {
			get {
				return GetTypedColumnValue<string>("BankCardCategoryName");
			}
			set {
				SetColumnValue("BankCardCategoryName", value);
				if (_bankCardCategory != null) {
					_bankCardCategory.Name = value;
				}
			}
		}

		private BankCardCategory _bankCardCategory;
		/// <summary>
		/// Category.
		/// </summary>
		public BankCardCategory BankCardCategory {
			get {
				return _bankCardCategory ??
					(_bankCardCategory = LookupColumnEntities.GetEntity("BankCardCategory") as BankCardCategory);
			}
		}

		/// <exclude/>
		public Guid HolderId {
			get {
				return GetTypedColumnValue<Guid>("HolderId");
			}
			set {
				SetColumnValue("HolderId", value);
				_holder = null;
			}
		}

		/// <exclude/>
		public string HolderName {
			get {
				return GetTypedColumnValue<string>("HolderName");
			}
			set {
				SetColumnValue("HolderName", value);
				if (_holder != null) {
					_holder.Name = value;
				}
			}
		}

		private Contact _holder;
		/// <summary>
		/// Cardholder.
		/// </summary>
		public Contact Holder {
			get {
				return _holder ??
					(_holder = LookupColumnEntities.GetEntity("Holder") as Contact);
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

		/// <summary>
		/// Multicurrency.
		/// </summary>
		public bool IsMulticurrency {
			get {
				return GetTypedColumnValue<bool>("IsMulticurrency");
			}
			set {
				SetColumnValue("IsMulticurrency", value);
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
		public Guid DivisionId {
			get {
				return GetTypedColumnValue<Guid>("DivisionId");
			}
			set {
				SetColumnValue("DivisionId", value);
				_division = null;
			}
		}

		/// <exclude/>
		public string DivisionName {
			get {
				return GetTypedColumnValue<string>("DivisionName");
			}
			set {
				SetColumnValue("DivisionName", value);
				if (_division != null) {
					_division.Name = value;
				}
			}
		}

		private Account _division;
		/// <summary>
		/// Office.
		/// </summary>
		public Account Division {
			get {
				return _division ??
					(_division = LookupColumnEntities.GetEntity("Division") as Account);
			}
		}

		/// <summary>
		/// Opened on.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <exclude/>
		public Guid BankCardStatusId {
			get {
				return GetTypedColumnValue<Guid>("BankCardStatusId");
			}
			set {
				SetColumnValue("BankCardStatusId", value);
				_bankCardStatus = null;
			}
		}

		/// <exclude/>
		public string BankCardStatusName {
			get {
				return GetTypedColumnValue<string>("BankCardStatusName");
			}
			set {
				SetColumnValue("BankCardStatusName", value);
				if (_bankCardStatus != null) {
					_bankCardStatus.Name = value;
				}
			}
		}

		private BankCardStatus _bankCardStatus;
		/// <summary>
		/// Status.
		/// </summary>
		public BankCardStatus BankCardStatus {
			get {
				return _bankCardStatus ??
					(_bankCardStatus = LookupColumnEntities.GetEntity("BankCardStatus") as BankCardStatus);
			}
		}

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		/// <exclude/>
		public Guid BankCardOwnerId {
			get {
				return GetTypedColumnValue<Guid>("BankCardOwnerId");
			}
			set {
				SetColumnValue("BankCardOwnerId", value);
				_bankCardOwner = null;
			}
		}

		/// <exclude/>
		public string BankCardOwnerName {
			get {
				return GetTypedColumnValue<string>("BankCardOwnerName");
			}
			set {
				SetColumnValue("BankCardOwnerName", value);
				if (_bankCardOwner != null) {
					_bankCardOwner.Name = value;
				}
			}
		}

		private Account _bankCardOwner;
		/// <summary>
		/// Legal entity.
		/// </summary>
		public Account BankCardOwner {
			get {
				return _bankCardOwner ??
					(_bankCardOwner = LookupColumnEntities.GetEntity("BankCardOwner") as Account);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		/// <exclude/>
		public Guid PackageId {
			get {
				return GetTypedColumnValue<Guid>("PackageId");
			}
			set {
				SetColumnValue("PackageId", value);
				_package = null;
			}
		}

		/// <exclude/>
		public string PackageName {
			get {
				return GetTypedColumnValue<string>("PackageName");
			}
			set {
				SetColumnValue("PackageName", value);
				if (_package != null) {
					_package.Name = value;
				}
			}
		}

		private Product _package;
		/// <summary>
		/// Banking package.
		/// </summary>
		public Product Package {
			get {
				return _package ??
					(_package = LookupColumnEntities.GetEntity("Package") as Product);
			}
		}

		/// <summary>
		/// First and last name.
		/// </summary>
		public string ContactNameEng {
			get {
				return GetTypedColumnValue<string>("ContactNameEng");
			}
			set {
				SetColumnValue("ContactNameEng", value);
			}
		}

		/// <summary>
		/// PayPass / PayWave.
		/// </summary>
		public bool IsPayPassPayWave {
			get {
				return GetTypedColumnValue<bool>("IsPayPassPayWave");
			}
			set {
				SetColumnValue("IsPayPassPayWave", value);
			}
		}

		/// <summary>
		/// Expiration Date.
		/// </summary>
		public string ValidDate {
			get {
				return GetTypedColumnValue<string>("ValidDate");
			}
			set {
				SetColumnValue("ValidDate", value);
			}
		}

		/// <summary>
		/// Balance.
		/// </summary>
		public Decimal Balance {
			get {
				return GetTypedColumnValue<Decimal>("Balance");
			}
			set {
				SetColumnValue("Balance", value);
			}
		}

		/// <summary>
		/// ATM withdrawal limit.
		/// </summary>
		public Decimal CashLimit {
			get {
				return GetTypedColumnValue<Decimal>("CashLimit");
			}
			set {
				SetColumnValue("CashLimit", value);
			}
		}

		/// <summary>
		/// Debt.
		/// </summary>
		public Decimal Debt {
			get {
				return GetTypedColumnValue<Decimal>("Debt");
			}
			set {
				SetColumnValue("Debt", value);
			}
		}

		/// <summary>
		/// Pay before.
		/// </summary>
		public DateTime RepayDate {
			get {
				return GetTypedColumnValue<DateTime>("RepayDate");
			}
			set {
				SetColumnValue("RepayDate", value);
			}
		}

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCard_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardDeleted", e);
			Validating += (s, e) => ThrowEvent("BankCardValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCard(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCard_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCard_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BankCard
	{

		public BankCard_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCard_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
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

	#region Class: BankCard_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCard_CrtFinservAccountAndCardEventsProcess : BankCard_CrtFinservAccountAndCardEventsProcess<BankCard>
	{

		public BankCard_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCard_CrtFinservAccountAndCardEventsProcess

	public partial class BankCard_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardEventsProcess

	/// <exclude/>
	public class BankCardEventsProcess : BankCard_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

