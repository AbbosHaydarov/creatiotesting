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
	using Terrasoft.Configuration;
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

	#region Class: FinApplicationSpec_CrtFinservApplication_TerrasoftSchema

	/// <exclude/>
	public class FinApplicationSpec_CrtFinservApplication_TerrasoftSchema : Terrasoft.Configuration.SpecInConditionSchema
	{

		#region Constructors: Public

		public FinApplicationSpec_CrtFinservApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationSpec_CrtFinservApplication_TerrasoftSchema(FinApplicationSpec_CrtFinservApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationSpec_CrtFinservApplication_TerrasoftSchema(FinApplicationSpec_CrtFinservApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61");
			RealUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61");
			Name = "FinApplicationSpec_CrtFinservApplication_Terrasoft";
			ParentSchemaUId = new Guid("cf300ecc-fa6f-4159-9413-ba10aab7fa69");
			ExtendParent = false;
			CreatedInPackageId = new Guid("31bef9c7-e872-41cf-bc01-91fceff746e0");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateDisplayValueColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("55d4b34d-a8c9-4963-a4f6-34b4092a767d")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
			if (Columns.FindByUId(new Guid("27c2556a-cbf1-49f3-982f-0a40e153a2e5")) == null) {
				Columns.Add(CreateIsCustomColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("55d4b34d-a8c9-4963-a4f6-34b4092a767d"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61"),
				ModifiedInSchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61"),
				CreatedInPackageId = new Guid("31bef9c7-e872-41cf-bc01-91fceff746e0")
			};
		}

		protected virtual EntitySchemaColumn CreateDisplayValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("dabcf5c2-80b8-408b-a4d9-595eb6435666"),
				Name = @"DisplayValue",
				CreatedInSchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61"),
				ModifiedInSchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61"),
				CreatedInPackageId = new Guid("31bef9c7-e872-41cf-bc01-91fceff746e0")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCustomColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("27c2556a-cbf1-49f3-982f-0a40e153a2e5"),
				Name = @"IsCustom",
				CreatedInSchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61"),
				ModifiedInSchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61"),
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
			return new FinApplicationSpec_CrtFinservApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplicationSpec_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationSpec_CrtFinservApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationSpec_CrtFinservApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationSpec_CrtFinservApplication_Terrasoft

	/// <summary>
	/// Application parameters.
	/// </summary>
	public class FinApplicationSpec_CrtFinservApplication_Terrasoft : Terrasoft.Configuration.SpecInCondition
	{

		#region Constructors: Public

		public FinApplicationSpec_CrtFinservApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationSpec_CrtFinservApplication_Terrasoft";
		}

		public FinApplicationSpec_CrtFinservApplication_Terrasoft(FinApplicationSpec_CrtFinservApplication_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <summary>
		/// Value.
		/// </summary>
		public string DisplayValue {
			get {
				return GetTypedColumnValue<string>("DisplayValue");
			}
			set {
				SetColumnValue("DisplayValue", value);
			}
		}

		/// <summary>
		/// Added by the user.
		/// </summary>
		public bool IsCustom {
			get {
				return GetTypedColumnValue<bool>("IsCustom");
			}
			set {
				SetColumnValue("IsCustom", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplicationSpec_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinApplicationSpec_CrtFinservApplication_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("FinApplicationSpec_CrtFinservApplication_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("FinApplicationSpec_CrtFinservApplication_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("FinApplicationSpec_CrtFinservApplication_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("FinApplicationSpec_CrtFinservApplication_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("FinApplicationSpec_CrtFinservApplication_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("FinApplicationSpec_CrtFinservApplication_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinApplicationSpec_CrtFinservApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationSpec_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplicationSpec_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.SpecInCondition_SpecificationBuilderProductCatalogEventsProcess<TEntity> where TEntity : FinApplicationSpec_CrtFinservApplication_Terrasoft
	{

		public FinApplicationSpec_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplicationSpec_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a1333edb-144a-476b-91f8-7aac85cd6d61");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private LocalizableString _trueString;
		public LocalizableString TrueString {
			get {
				return _trueString ?? (_trueString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TrueString.Value"));
			}
		}

		private LocalizableString _falseString;
		public LocalizableString FalseString {
			get {
				return _falseString ?? (_falseString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FalseString.Value"));
			}
		}

		private LocalizableString _unsupportedSpecificationType;
		public LocalizableString UnsupportedSpecificationType {
			get {
				return _unsupportedSpecificationType ?? (_unsupportedSpecificationType = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UnsupportedSpecificationType.Value"));
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

	#region Class: FinApplicationSpec_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationSpec_CrtFinservApplicationEventsProcess : FinApplicationSpec_CrtFinservApplicationEventsProcess<FinApplicationSpec_CrtFinservApplication_Terrasoft>
	{

		public FinApplicationSpec_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

