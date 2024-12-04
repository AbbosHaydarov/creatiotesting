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

	#region Class: FinApplication_CrtFinservApplication_TerrasoftSchema

	/// <exclude/>
	public class FinApplication_CrtFinservApplication_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FinApplication_CrtFinservApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplication_CrtFinservApplication_TerrasoftSchema(FinApplication_CrtFinservApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplication_CrtFinservApplication_TerrasoftSchema(FinApplication_CrtFinservApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			RealUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			Name = "FinApplication_CrtFinservApplication_Terrasoft";
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
			PrimaryDisplayColumn = CreateNumberColumn();
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
			if (Columns.FindByUId(new Guid("d6346d44-9575-46c1-8179-97c7bf8c18d5")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("c6baab9f-ce97-4526-b93f-434161676c21")) == null) {
				Columns.Add(CreateContractColumn());
			}
			if (Columns.FindByUId(new Guid("065f0c1e-e178-4d6f-b392-74f08ea80ef0")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("af85a69f-2ae3-475f-a337-60352fcd9cb8")) == null) {
				Columns.Add(CreatePackageColumn());
			}
			if (Columns.FindByUId(new Guid("e105bd83-c7a9-4215-b363-45d74b03b9f5")) == null) {
				Columns.Add(CreateFillingDateColumn());
			}
			if (Columns.FindByUId(new Guid("28bc96f8-49b2-414d-9189-a01aee51e0e7")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("537a5ece-3d51-4660-a27d-9e724339124a")) == null) {
				Columns.Add(CreateDecisionColumn());
			}
			if (Columns.FindByUId(new Guid("28ed12e9-c08d-465d-826d-075b6c686028")) == null) {
				Columns.Add(CreateDecisionDateColumn());
			}
			if (Columns.FindByUId(new Guid("c96ab24e-41c1-4879-95bb-001ff03d8401")) == null) {
				Columns.Add(CreateDivisionColumn());
			}
			if (Columns.FindByUId(new Guid("44bbd12a-2c92-4ea8-9f76-e9337006b4a1")) == null) {
				Columns.Add(CreateBranchColumn());
			}
			if (Columns.FindByUId(new Guid("74adbb22-cc9f-488a-8028-f0ad0d3c8725")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("ff452c3a-757c-4ecc-b986-dded9a5cd2ef")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("7eefcbec-d970-4e2f-8422-8a42fdfa9492")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("f002ecdc-a66e-45f8-82b4-8ef6d22d0df1")) == null) {
				Columns.Add(CreateProductCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("86f943fe-5da9-47bc-806e-dd092f5101d2")) == null) {
				Columns.Add(CreateProductTypeColumn());
			}
			if (Columns.FindByUId(new Guid("0d703fbd-9b77-4f94-9c88-f19d10334ad8")) == null) {
				Columns.Add(CreateOpportunityConditionColumn());
			}
			if (Columns.FindByUId(new Guid("799913e1-0cff-4345-8029-aea74ba611a5")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("d43ee636-bead-4ac1-945d-315fb030e205")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("28d809ff-4555-4ced-9ade-97b06463ca44")) == null) {
				Columns.Add(CreateStageColumn());
			}
			if (Columns.FindByUId(new Guid("4d5d481f-304a-4ef0-bc0c-7f7d9d7e1c34")) == null) {
				Columns.Add(CreateApproverColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2ad39f67-18c1-45a3-9d30-ee2ee53813ae"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d6346d44-9575-46c1-8179-97c7bf8c18d5"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c6baab9f-ce97-4526-b93f-434161676c21"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("065f0c1e-e178-4d6f-b392-74f08ea80ef0"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("af85a69f-2ae3-475f-a337-60352fcd9cb8"),
				Name = @"Package",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateFillingDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("e105bd83-c7a9-4215-b363-45d74b03b9f5"),
				Name = @"FillingDate",
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("28bc96f8-49b2-414d-9189-a01aee51e0e7"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("a46a8c54-9001-4d43-8d81-b834feb42b4f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateDecisionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("537a5ece-3d51-4660-a27d-9e724339124a"),
				Name = @"Decision",
				ReferenceSchemaUId = new Guid("3eb4067e-c91a-432b-bb0c-2223060c693e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateDecisionDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("28ed12e9-c08d-465d-826d-075b6c686028"),
				Name = @"DecisionDate",
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateDivisionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c96ab24e-41c1-4879-95bb-001ff03d8401"),
				Name = @"Division",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateBranchColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("44bbd12a-2c92-4ea8-9f76-e9337006b4a1"),
				Name = @"Branch",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("74adbb22-cc9f-488a-8028-f0ad0d3c8725"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ff452c3a-757c-4ecc-b986-dded9a5cd2ef"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("c8da7e08-6492-4148-9858-7626794d6819"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7eefcbec-d970-4e2f-8422-8a42fdfa9492"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("07c6bf76-835d-4235-bf25-d6c5624e0383"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("c8da7e08-6492-4148-9858-7626794d6819"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"3b97f67a-d540-405c-a7e9-345237dc4a4a"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateProductCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f002ecdc-a66e-45f8-82b4-8ef6d22d0df1"),
				Name = @"ProductCategory",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("c8da7e08-6492-4148-9858-7626794d6819"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1fc784ab-49d7-4147-bae8-0ab51d176b73"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateProductTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("86f943fe-5da9-47bc-806e-dd092f5101d2"),
				Name = @"ProductType",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("c8da7e08-6492-4148-9858-7626794d6819"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"2a28c611-8e18-41ec-82d5-3ff3e06da698"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOpportunityConditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0d703fbd-9b77-4f94-9c88-f19d10334ad8"),
				Name = @"OpportunityCondition",
				ReferenceSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("799913e1-0cff-4345-8029-aea74ba611a5"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("d43ee636-bead-4ac1-945d-315fb030e205"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("28d809ff-4555-4ced-9ade-97b06463ca44"),
				Name = @"Stage",
				ReferenceSchemaUId = new Guid("c7397bc8-1eb6-4a40-98c8-a78c05c7e48d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected virtual EntitySchemaColumn CreatePhotoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("20481525-6675-4b47-b799-beda3407a5ae"),
				Name = @"Photo",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected virtual EntitySchemaColumn CreateApproverColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4d5d481f-304a-4ef0-bc0c-7f7d9d7e1c34"),
				Name = @"Approver",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				ModifiedInSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplication_CrtFinservApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplication_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplication_CrtFinservApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplication_CrtFinservApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_CrtFinservApplication_Terrasoft

	/// <summary>
	/// Application.
	/// </summary>
	public class FinApplication_CrtFinservApplication_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public FinApplication_CrtFinservApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplication_CrtFinservApplication_Terrasoft";
		}

		public FinApplication_CrtFinservApplication_Terrasoft(FinApplication_CrtFinservApplication_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Registration date.
		/// </summary>
		public DateTime FillingDate {
			get {
				return GetTypedColumnValue<DateTime>("FillingDate");
			}
			set {
				SetColumnValue("FillingDate", value);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private FinAppStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public FinAppStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as FinAppStatus);
			}
		}

		/// <exclude/>
		public Guid DecisionId {
			get {
				return GetTypedColumnValue<Guid>("DecisionId");
			}
			set {
				SetColumnValue("DecisionId", value);
				_decision = null;
			}
		}

		/// <exclude/>
		public string DecisionName {
			get {
				return GetTypedColumnValue<string>("DecisionName");
			}
			set {
				SetColumnValue("DecisionName", value);
				if (_decision != null) {
					_decision.Name = value;
				}
			}
		}

		private FinAppDecision _decision;
		/// <summary>
		/// Decision.
		/// </summary>
		public FinAppDecision Decision {
			get {
				return _decision ??
					(_decision = LookupColumnEntities.GetEntity("Decision") as FinAppDecision);
			}
		}

		/// <summary>
		/// Decision date.
		/// </summary>
		public DateTime DecisionDate {
			get {
				return GetTypedColumnValue<DateTime>("DecisionDate");
			}
			set {
				SetColumnValue("DecisionDate", value);
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
		/// Branch.
		/// </summary>
		public Account Division {
			get {
				return _division ??
					(_division = LookupColumnEntities.GetEntity("Division") as Account);
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
		/// Office.
		/// </summary>
		public Account Branch {
			get {
				return _branch ??
					(_branch = LookupColumnEntities.GetEntity("Branch") as Account);
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
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private ApplicationOrigin _source;
		/// <summary>
		/// Source.
		/// </summary>
		public ApplicationOrigin Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as ApplicationOrigin);
			}
		}

		/// <exclude/>
		public Guid ProductCategoryId {
			get {
				return GetTypedColumnValue<Guid>("ProductCategoryId");
			}
			set {
				SetColumnValue("ProductCategoryId", value);
				_productCategory = null;
			}
		}

		/// <exclude/>
		public string ProductCategoryName {
			get {
				return GetTypedColumnValue<string>("ProductCategoryName");
			}
			set {
				SetColumnValue("ProductCategoryName", value);
				if (_productCategory != null) {
					_productCategory.Name = value;
				}
			}
		}

		private ProductCategory _productCategory;
		/// <summary>
		/// Product category.
		/// </summary>
		public ProductCategory ProductCategory {
			get {
				return _productCategory ??
					(_productCategory = LookupColumnEntities.GetEntity("ProductCategory") as ProductCategory);
			}
		}

		/// <exclude/>
		public Guid ProductTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeId");
			}
			set {
				SetColumnValue("ProductTypeId", value);
				_productType = null;
			}
		}

		/// <exclude/>
		public string ProductTypeName {
			get {
				return GetTypedColumnValue<string>("ProductTypeName");
			}
			set {
				SetColumnValue("ProductTypeName", value);
				if (_productType != null) {
					_productType.Name = value;
				}
			}
		}

		private ProductType _productType;
		/// <summary>
		/// Product type.
		/// </summary>
		public ProductType ProductType {
			get {
				return _productType ??
					(_productType = LookupColumnEntities.GetEntity("ProductType") as ProductType);
			}
		}

		/// <exclude/>
		public Guid OpportunityConditionId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityConditionId");
			}
			set {
				SetColumnValue("OpportunityConditionId", value);
				_opportunityCondition = null;
			}
		}

		/// <exclude/>
		public string OpportunityConditionName {
			get {
				return GetTypedColumnValue<string>("OpportunityConditionName");
			}
			set {
				SetColumnValue("OpportunityConditionName", value);
				if (_opportunityCondition != null) {
					_opportunityCondition.Name = value;
				}
			}
		}

		private OpportunityCondition _opportunityCondition;
		/// <summary>
		/// Opportunity condition.
		/// </summary>
		public OpportunityCondition OpportunityCondition {
			get {
				return _opportunityCondition ??
					(_opportunityCondition = LookupColumnEntities.GetEntity("OpportunityCondition") as OpportunityCondition);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Legal entity.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
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
		public Guid StageId {
			get {
				return GetTypedColumnValue<Guid>("StageId");
			}
			set {
				SetColumnValue("StageId", value);
				_stage = null;
			}
		}

		/// <exclude/>
		public string StageName {
			get {
				return GetTypedColumnValue<string>("StageName");
			}
			set {
				SetColumnValue("StageName", value);
				if (_stage != null) {
					_stage.Name = value;
				}
			}
		}

		private FinAppStage _stage;
		/// <summary>
		/// Stage.
		/// </summary>
		public FinAppStage Stage {
			get {
				return _stage ??
					(_stage = LookupColumnEntities.GetEntity("Stage") as FinAppStage);
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
		public Guid ApproverId {
			get {
				return GetTypedColumnValue<Guid>("ApproverId");
			}
			set {
				SetColumnValue("ApproverId", value);
				_approver = null;
			}
		}

		/// <exclude/>
		public string ApproverName {
			get {
				return GetTypedColumnValue<string>("ApproverName");
			}
			set {
				SetColumnValue("ApproverName", value);
				if (_approver != null) {
					_approver.Name = value;
				}
			}
		}

		private Contact _approver;
		/// <summary>
		/// Decision maker.
		/// </summary>
		public Contact Approver {
			get {
				return _approver ??
					(_approver = LookupColumnEntities.GetEntity("Approver") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplication_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinApplication_CrtFinservApplication_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("FinApplication_CrtFinservApplication_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("FinApplication_CrtFinservApplication_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinApplication_CrtFinservApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplication_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : FinApplication_CrtFinservApplication_Terrasoft
	{

		public FinApplication_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplication_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
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

	#region Class: FinApplication_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinApplication_CrtFinservApplicationEventsProcess : FinApplication_CrtFinservApplicationEventsProcess<FinApplication_CrtFinservApplication_Terrasoft>
	{

		public FinApplication_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplication_CrtFinservApplicationEventsProcess

	public partial class FinApplication_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

