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

	#region Class: AppFormObligationSchema

	/// <exclude/>
	public class AppFormObligationSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AppFormObligationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormObligationSchema(AppFormObligationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormObligationSchema(AppFormObligationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230");
			RealUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230");
			Name = "AppFormObligation";
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
			if (Columns.FindByUId(new Guid("c5e5a953-0972-4c28-9f89-241edfef3361")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
			if (Columns.FindByUId(new Guid("152c2c32-6964-4e49-be2a-3f2c6a41647c")) == null) {
				Columns.Add(CreateExpirationDateColumn());
			}
			if (Columns.FindByUId(new Guid("d413aa2f-4628-40b6-90cf-5f5c1cdcb117")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("6dcad683-f1fa-4523-b2ca-7204289146be")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c5e5a953-0972-4c28-9f89-241edfef3361"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				ModifiedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateExpirationDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("152c2c32-6964-4e49-be2a-3f2c6a41647c"),
				Name = @"ExpirationDate",
				CreatedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				ModifiedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d413aa2f-4628-40b6-90cf-5f5c1cdcb117"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				ModifiedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6dcad683-f1fa-4523-b2ca-7204289146be"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("0eb1556a-1346-4c2e-bc29-c95f158493c9"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				ModifiedInSchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
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
			return new AppFormObligation(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormObligation_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormObligationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormObligationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d64cf916-81f9-412a-bdd4-ce6375112230"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormObligation

	/// <summary>
	/// Obligation in application form.
	/// </summary>
	public class AppFormObligation : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AppFormObligation(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormObligation";
		}

		public AppFormObligation(AppFormObligation source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <summary>
		/// Expiration date.
		/// </summary>
		public DateTime ExpirationDate {
			get {
				return GetTypedColumnValue<DateTime>("ExpirationDate");
			}
			set {
				SetColumnValue("ExpirationDate", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private AppFormObligationType _type;
		/// <summary>
		/// Application form obligation type.
		/// </summary>
		public AppFormObligationType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as AppFormObligationType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormObligation_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormObligationDeleted", e);
			Validating += (s, e) => ThrowEvent("AppFormObligationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormObligation(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormObligation_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormObligation_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AppFormObligation
	{

		public AppFormObligation_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormObligation_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("d64cf916-81f9-412a-bdd4-ce6375112230");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d64cf916-81f9-412a-bdd4-ce6375112230");
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

	#region Class: AppFormObligation_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormObligation_CrtFinservApplicationEventsProcess : AppFormObligation_CrtFinservApplicationEventsProcess<AppFormObligation>
	{

		public AppFormObligation_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormObligation_CrtFinservApplicationEventsProcess

	public partial class AppFormObligation_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormObligationEventsProcess

	/// <exclude/>
	public class AppFormObligationEventsProcess : AppFormObligation_CrtFinservApplicationEventsProcess
	{

		public AppFormObligationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

