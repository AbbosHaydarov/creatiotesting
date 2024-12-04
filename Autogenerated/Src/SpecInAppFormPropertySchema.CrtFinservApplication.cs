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

	#region Class: SpecInAppFormPropertySchema

	/// <exclude/>
	public class SpecInAppFormPropertySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecInAppFormPropertySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecInAppFormPropertySchema(SpecInAppFormPropertySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecInAppFormPropertySchema(SpecInAppFormPropertySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef");
			RealUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef");
			Name = "SpecInAppFormProperty";
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
			if (Columns.FindByUId(new Guid("f122b0a5-c224-4403-8b1a-ffd0a259bb32")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("e6aa0af5-29f9-44bd-a049-ca69b9c251fa")) == null) {
				Columns.Add(CreateAppFormPropertyColumn());
			}
			if (Columns.FindByUId(new Guid("39384a5f-9a38-4a8e-9dc9-d1e24d4892a3")) == null) {
				Columns.Add(CreateTextValueColumn());
			}
			if (Columns.FindByUId(new Guid("ca1c513e-74f0-4980-afca-9f23c7f7279b")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("57e5cb81-9890-4fea-84f9-60e54151e276")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("7656e426-b39b-498f-a84c-3977c7e73c12")) == null) {
				Columns.Add(CreateSpecificationListItemColumn());
			}
			if (Columns.FindByUId(new Guid("a5f03ee5-3320-4cc7-9110-686d0eaf4d04")) == null) {
				Columns.Add(CreateIntValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f122b0a5-c224-4403-8b1a-ffd0a259bb32"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				ModifiedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAppFormPropertyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e6aa0af5-29f9-44bd-a049-ca69b9c251fa"),
				Name = @"AppFormProperty",
				ReferenceSchemaUId = new Guid("e4ae25fb-ef8b-4443-99f0-560813992f62"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				ModifiedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateTextValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("39384a5f-9a38-4a8e-9dc9-d1e24d4892a3"),
				Name = @"TextValue",
				CreatedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				ModifiedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ca1c513e-74f0-4980-afca-9f23c7f7279b"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				ModifiedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("57e5cb81-9890-4fea-84f9-60e54151e276"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				ModifiedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationListItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7656e426-b39b-498f-a84c-3977c7e73c12"),
				Name = @"SpecificationListItem",
				ReferenceSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				ModifiedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateIntValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("a5f03ee5-3320-4cc7-9110-686d0eaf4d04"),
				Name = @"IntValue",
				CreatedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
				ModifiedInSchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"),
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
			return new SpecInAppFormProperty(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecInAppFormProperty_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecInAppFormPropertySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecInAppFormPropertySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecInAppFormProperty

	/// <summary>
	/// Property specification in application form.
	/// </summary>
	public class SpecInAppFormProperty : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecInAppFormProperty(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecInAppFormProperty";
		}

		public SpecInAppFormProperty(SpecInAppFormProperty source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		public Guid AppFormPropertyId {
			get {
				return GetTypedColumnValue<Guid>("AppFormPropertyId");
			}
			set {
				SetColumnValue("AppFormPropertyId", value);
				_appFormProperty = null;
			}
		}

		/// <exclude/>
		public string AppFormPropertyName {
			get {
				return GetTypedColumnValue<string>("AppFormPropertyName");
			}
			set {
				SetColumnValue("AppFormPropertyName", value);
				if (_appFormProperty != null) {
					_appFormProperty.Name = value;
				}
			}
		}

		private AppFormProperty _appFormProperty;
		/// <summary>
		/// Property in application form.
		/// </summary>
		public AppFormProperty AppFormProperty {
			get {
				return _appFormProperty ??
					(_appFormProperty = LookupColumnEntities.GetEntity("AppFormProperty") as AppFormProperty);
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
		/// Float value.
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
		/// Boolean value.
		/// </summary>
		public bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
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
		/// Integer.
		/// </summary>
		public int IntValue {
			get {
				return GetTypedColumnValue<int>("IntValue");
			}
			set {
				SetColumnValue("IntValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecInAppFormProperty_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecInAppFormPropertyDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecInAppFormPropertyValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecInAppFormProperty(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInAppFormProperty_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class SpecInAppFormProperty_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SpecInAppFormProperty
	{

		public SpecInAppFormProperty_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecInAppFormProperty_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fd8fc90a-397c-4cf9-a7ed-806c63fb84ef");
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

	#region Class: SpecInAppFormProperty_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class SpecInAppFormProperty_CrtFinservApplicationEventsProcess : SpecInAppFormProperty_CrtFinservApplicationEventsProcess<SpecInAppFormProperty>
	{

		public SpecInAppFormProperty_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecInAppFormProperty_CrtFinservApplicationEventsProcess

	public partial class SpecInAppFormProperty_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecInAppFormPropertyEventsProcess

	/// <exclude/>
	public class SpecInAppFormPropertyEventsProcess : SpecInAppFormProperty_CrtFinservApplicationEventsProcess
	{

		public SpecInAppFormPropertyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

