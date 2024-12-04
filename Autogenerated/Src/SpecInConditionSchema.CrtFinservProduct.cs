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

	#region Class: SpecInCondition_CrtFinservProduct_TerrasoftSchema

	/// <exclude/>
	public class SpecInCondition_CrtFinservProduct_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecInCondition_CrtFinservProduct_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecInCondition_CrtFinservProduct_TerrasoftSchema(SpecInCondition_CrtFinservProduct_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecInCondition_CrtFinservProduct_TerrasoftSchema(SpecInCondition_CrtFinservProduct_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69");
			RealUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69");
			Name = "SpecInCondition_CrtFinservProduct_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7e5eaf08-a84a-4990-97c1-d25c809c0ca6")) == null) {
				Columns.Add(CreateProductConditionColumn());
			}
			if (Columns.FindByUId(new Guid("412f3b3d-36e9-4d3b-bf85-e356d2ea898d")) == null) {
				Columns.Add(CreateSpecInConditionTypeColumn());
			}
			if (Columns.FindByUId(new Guid("03e30b34-1843-49e5-a62a-2f75fa43b918")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("9934f295-220e-4c64-8075-f43f1b8186ab")) == null) {
				Columns.Add(CreateSpecificationListItemColumn());
			}
			if (Columns.FindByUId(new Guid("22c14183-795b-4e77-83c3-2536362a2675")) == null) {
				Columns.Add(CreateCurrentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("47ba1176-b417-4351-9f79-79a3fa4ae1b1")) == null) {
				Columns.Add(CreateTextValueColumn());
			}
			if (Columns.FindByUId(new Guid("37514877-aab3-4bd7-a19a-9e41c7ac414c")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("9ae773be-ad20-4738-9919-bd127c19fa34")) == null) {
				Columns.Add(CreateMinFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("ee2c1ffd-9cc5-4f50-85b1-0eddd0c3d2e9")) == null) {
				Columns.Add(CreateMaxFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("ed247239-e15b-42e7-ac51-ffe6603b6957")) == null) {
				Columns.Add(CreateIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("d5b6673b-700f-4e90-801b-3fd94047e582")) == null) {
				Columns.Add(CreateMinIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("c739d69b-c0f7-4a6e-b93e-f1341fc7790c")) == null) {
				Columns.Add(CreateMaxIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("4c795baf-8cc0-4f84-91a9-6ff6e6737cba")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("bc062055-3359-44c3-9a55-2161657495a2")) == null) {
				Columns.Add(CreateRowPositionColumn());
			}
			if (Columns.FindByUId(new Guid("17b4d494-e182-471b-8e99-6c6926b2ec35")) == null) {
				Columns.Add(CreateValuePositionColumn());
			}
			if (Columns.FindByUId(new Guid("fd1af754-2608-4989-8549-e8e52a6fbd45")) == null) {
				Columns.Add(CreateOpportunityConditionColumn());
			}
			if (Columns.FindByUId(new Guid("ed07692f-24a3-40b9-b7a3-904b9d5caa40")) == null) {
				Columns.Add(CreateSpecTableValueXColumn());
			}
			if (Columns.FindByUId(new Guid("ec9fd1fc-7076-4f52-b28e-b504a5189823")) == null) {
				Columns.Add(CreateSpecTableValueYColumn());
			}
			if (Columns.FindByUId(new Guid("8476cafb-ead6-4b39-bee3-d2cdadba9bf8")) == null) {
				Columns.Add(CreateIsEmptyValueColumn());
			}
			if (Columns.FindByUId(new Guid("5d070f43-b32e-47c8-8c02-757f1bbf659a")) == null) {
				Columns.Add(CreateIsEmptyMinValueColumn());
			}
			if (Columns.FindByUId(new Guid("aaa507c7-b482-4181-a538-939edc4a40f0")) == null) {
				Columns.Add(CreateIsEmptyMaxValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductConditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7e5eaf08-a84a-4990-97c1-d25c809c0ca6"),
				Name = @"ProductCondition",
				ReferenceSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecInConditionTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("412f3b3d-36e9-4d3b-bf85-e356d2ea898d"),
				Name = @"SpecInConditionType",
				ReferenceSchemaUId = new Guid("f36204bb-8e9a-4fac-a8f2-520b9e8d4819"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("03e30b34-1843-49e5-a62a-2f75fa43b918"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationListItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9934f295-220e-4c64-8075-f43f1b8186ab"),
				Name = @"SpecificationListItem",
				ReferenceSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("22c14183-795b-4e77-83c3-2536362a2675"),
				Name = @"CurrentType",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateTextValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("47ba1176-b417-4351-9f79-79a3fa4ae1b1"),
				Name = @"TextValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("37514877-aab3-4bd7-a19a-9e41c7ac414c"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateMinFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("9ae773be-ad20-4738-9919-bd127c19fa34"),
				Name = @"MinFloatValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ee2c1ffd-9cc5-4f50-85b1-0eddd0c3d2e9"),
				Name = @"MaxFloatValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ed247239-e15b-42e7-ac51-ffe6603b6957"),
				Name = @"IntegerValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateMinIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d5b6673b-700f-4e90-801b-3fd94047e582"),
				Name = @"MinIntegerValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c739d69b-c0f7-4a6e-b93e-f1341fc7790c"),
				Name = @"MaxIntegerValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("4c795baf-8cc0-4f84-91a9-6ff6e6737cba"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateRowPositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bc062055-3359-44c3-9a55-2161657495a2"),
				Name = @"RowPosition",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateValuePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("17b4d494-e182-471b-8e99-6c6926b2ec35"),
				Name = @"ValuePosition",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateOpportunityConditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fd1af754-2608-4989-8549-e8e52a6fbd45"),
				Name = @"OpportunityCondition",
				ReferenceSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecTableValueXColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ed07692f-24a3-40b9-b7a3-904b9d5caa40"),
				Name = @"SpecTableValueX",
				ReferenceSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecTableValueYColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ec9fd1fc-7076-4f52-b28e-b504a5189823"),
				Name = @"SpecTableValueY",
				ReferenceSchemaUId = new Guid("a60aa111-df0f-4f54-a0b7-904ec7603068"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("13c8b578-aa8a-47f2-a7b8-c84c268f235b")
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8476cafb-ead6-4b39-bee3-d2cdadba9bf8"),
				Name = @"IsEmptyValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8348d424-5381-454b-b3a5-294bd3fbfdd9")
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyMinValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5d070f43-b32e-47c8-8c02-757f1bbf659a"),
				Name = @"IsEmptyMinValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsEmptyMaxValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("aaa507c7-b482-4181-a538-939edc4a40f0"),
				Name = @"IsEmptyMaxValue",
				CreatedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				ModifiedInSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"),
				CreatedInPackageId = new Guid("8e6b2aa9-b51e-46d6-9720-281ae73926be"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecInCondition_CrtFinservProduct_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecInCondition_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecInCondition_CrtFinservProduct_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecInCondition_CrtFinservProduct_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecInCondition_CrtFinservProduct_Terrasoft

	/// <summary>
	/// Parameter in product condition.
	/// </summary>
	public class SpecInCondition_CrtFinservProduct_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecInCondition_CrtFinservProduct_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecInCondition_CrtFinservProduct_Terrasoft";
		}

		public SpecInCondition_CrtFinservProduct_Terrasoft(SpecInCondition_CrtFinservProduct_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProductConditionId {
			get {
				return GetTypedColumnValue<Guid>("ProductConditionId");
			}
			set {
				SetColumnValue("ProductConditionId", value);
				_productCondition = null;
			}
		}

		/// <exclude/>
		public string ProductConditionName {
			get {
				return GetTypedColumnValue<string>("ProductConditionName");
			}
			set {
				SetColumnValue("ProductConditionName", value);
				if (_productCondition != null) {
					_productCondition.Name = value;
				}
			}
		}

		private ProductCondition _productCondition;
		/// <summary>
		/// Product conditions.
		/// </summary>
		public ProductCondition ProductCondition {
			get {
				return _productCondition ??
					(_productCondition = LookupColumnEntities.GetEntity("ProductCondition") as ProductCondition);
			}
		}

		/// <exclude/>
		public Guid SpecInConditionTypeId {
			get {
				return GetTypedColumnValue<Guid>("SpecInConditionTypeId");
			}
			set {
				SetColumnValue("SpecInConditionTypeId", value);
				_specInConditionType = null;
			}
		}

		/// <exclude/>
		public string SpecInConditionTypeName {
			get {
				return GetTypedColumnValue<string>("SpecInConditionTypeName");
			}
			set {
				SetColumnValue("SpecInConditionTypeName", value);
				if (_specInConditionType != null) {
					_specInConditionType.Name = value;
				}
			}
		}

		private SpecInConditionType _specInConditionType;
		/// <summary>
		/// Parameter classification in product condition.
		/// </summary>
		public SpecInConditionType SpecInConditionType {
			get {
				return _specInConditionType ??
					(_specInConditionType = LookupColumnEntities.GetEntity("SpecInConditionType") as SpecInConditionType);
			}
		}

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Parameter.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
			}
		}

		/// <exclude/>
		public Guid SpecificationListItemId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationListItemId");
			}
			set {
				SetColumnValue("SpecificationListItemId", value);
				_specificationListItem = null;
			}
		}

		/// <exclude/>
		public string SpecificationListItemName {
			get {
				return GetTypedColumnValue<string>("SpecificationListItemName");
			}
			set {
				SetColumnValue("SpecificationListItemName", value);
				if (_specificationListItem != null) {
					_specificationListItem.Name = value;
				}
			}
		}

		private SpecificationListItem _specificationListItem;
		/// <summary>
		/// Parameter value.
		/// </summary>
		public SpecificationListItem SpecificationListItem {
			get {
				return _specificationListItem ??
					(_specificationListItem = LookupColumnEntities.GetEntity("SpecificationListItem") as SpecificationListItem);
			}
		}

		/// <summary>
		/// View type.
		/// </summary>
		public string CurrentType {
			get {
				return GetTypedColumnValue<string>("CurrentType");
			}
			set {
				SetColumnValue("CurrentType", value);
			}
		}

		/// <summary>
		/// Text value.
		/// </summary>
		public string TextValue {
			get {
				return GetTypedColumnValue<string>("TextValue");
			}
			set {
				SetColumnValue("TextValue", value);
			}
		}

		/// <summary>
		/// Decimal value.
		/// </summary>
		public Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// Minimum decimal value.
		/// </summary>
		public Decimal MinFloatValue {
			get {
				return GetTypedColumnValue<Decimal>("MinFloatValue");
			}
			set {
				SetColumnValue("MinFloatValue", value);
			}
		}

		/// <summary>
		/// Maximal decimal value.
		/// </summary>
		public Decimal MaxFloatValue {
			get {
				return GetTypedColumnValue<Decimal>("MaxFloatValue");
			}
			set {
				SetColumnValue("MaxFloatValue", value);
			}
		}

		/// <summary>
		/// Integer.
		/// </summary>
		public int IntegerValue {
			get {
				return GetTypedColumnValue<int>("IntegerValue");
			}
			set {
				SetColumnValue("IntegerValue", value);
			}
		}

		/// <summary>
		/// Minimum integer value.
		/// </summary>
		public int MinIntegerValue {
			get {
				return GetTypedColumnValue<int>("MinIntegerValue");
			}
			set {
				SetColumnValue("MinIntegerValue", value);
			}
		}

		/// <summary>
		/// Maximum integer value.
		/// </summary>
		public int MaxIntegerValue {
			get {
				return GetTypedColumnValue<int>("MaxIntegerValue");
			}
			set {
				SetColumnValue("MaxIntegerValue", value);
			}
		}

		/// <summary>
		/// Logic value.
		/// </summary>
		public bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <summary>
		/// Position of item in a list.
		/// </summary>
		public int RowPosition {
			get {
				return GetTypedColumnValue<int>("RowPosition");
			}
			set {
				SetColumnValue("RowPosition", value);
			}
		}

		/// <summary>
		/// Position of item in string.
		/// </summary>
		public int ValuePosition {
			get {
				return GetTypedColumnValue<int>("ValuePosition");
			}
			set {
				SetColumnValue("ValuePosition", value);
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
		public Guid SpecTableValueXId {
			get {
				return GetTypedColumnValue<Guid>("SpecTableValueXId");
			}
			set {
				SetColumnValue("SpecTableValueXId", value);
				_specTableValueX = null;
			}
		}

		private SpecTableValue _specTableValueX;
		/// <summary>
		/// SpecTableValueX.
		/// </summary>
		public SpecTableValue SpecTableValueX {
			get {
				return _specTableValueX ??
					(_specTableValueX = LookupColumnEntities.GetEntity("SpecTableValueX") as SpecTableValue);
			}
		}

		/// <exclude/>
		public Guid SpecTableValueYId {
			get {
				return GetTypedColumnValue<Guid>("SpecTableValueYId");
			}
			set {
				SetColumnValue("SpecTableValueYId", value);
				_specTableValueY = null;
			}
		}

		private SpecTableValue _specTableValueY;
		/// <summary>
		/// SpecTableValueY.
		/// </summary>
		public SpecTableValue SpecTableValueY {
			get {
				return _specTableValueY ??
					(_specTableValueY = LookupColumnEntities.GetEntity("SpecTableValueY") as SpecTableValue);
			}
		}

		/// <summary>
		/// The value is not filled in.
		/// </summary>
		public bool IsEmptyValue {
			get {
				return GetTypedColumnValue<bool>("IsEmptyValue");
			}
			set {
				SetColumnValue("IsEmptyValue", value);
			}
		}

		/// <summary>
		/// Minimum valus is not filled in.
		/// </summary>
		public bool IsEmptyMinValue {
			get {
				return GetTypedColumnValue<bool>("IsEmptyMinValue");
			}
			set {
				SetColumnValue("IsEmptyMinValue", value);
			}
		}

		/// <summary>
		/// Maximum value is not filled in.
		/// </summary>
		public bool IsEmptyMaxValue {
			get {
				return GetTypedColumnValue<bool>("IsEmptyMaxValue");
			}
			set {
				SetColumnValue("IsEmptyMaxValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecInCondition_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecInCondition_CrtFinservProduct_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class SpecInCondition_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SpecInCondition_CrtFinservProduct_Terrasoft
	{

		public SpecInCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecInCondition_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69");
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

	#region Class: SpecInCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public class SpecInCondition_CrtFinservProductEventsProcess : SpecInCondition_CrtFinservProductEventsProcess<SpecInCondition_CrtFinservProduct_Terrasoft>
	{

		public SpecInCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

