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

	#region Class: RegDocument_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class RegDocument_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public RegDocument_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RegDocument_CrtBaseFinserv_TerrasoftSchema(RegDocument_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RegDocument_CrtBaseFinserv_TerrasoftSchema(RegDocument_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42");
			RealUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42");
			Name = "RegDocument_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d");
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
			if (Columns.FindByUId(new Guid("e639ba30-7068-48c5-8671-bf726dff2671")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("70112220-778a-4078-b682-a1c78a0179fd")) == null) {
				Columns.Add(CreateCitizenshipColumn());
			}
			if (Columns.FindByUId(new Guid("f2b59e3e-cfd2-4f1e-a205-d06e18f0242d")) == null) {
				Columns.Add(CreateRegDocumentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("88fab035-3e12-4305-8ef6-e75b2cf996db")) == null) {
				Columns.Add(CreateSeriesColumn());
			}
			if (Columns.FindByUId(new Guid("41833dab-d075-4ffe-a8bc-5f3ef017929e")) == null) {
				Columns.Add(CreateIssuedByColumn());
			}
			if (Columns.FindByUId(new Guid("cd878aa4-15f7-4573-96f4-6d7ef052cc12")) == null) {
				Columns.Add(CreateIssueDateColumn());
			}
			if (Columns.FindByUId(new Guid("a0058cbc-3728-4c53-bca4-9801e2881e4e")) == null) {
				Columns.Add(CreateValidUntilColumn());
			}
			if (Columns.FindByUId(new Guid("e9aea89e-fd13-43b0-a96f-c7ca20571b3c")) == null) {
				Columns.Add(CreateCodeDivisionColumn());
			}
			if (Columns.FindByUId(new Guid("920d7848-9fd1-46a3-b0b1-cef07099cf21")) == null) {
				Columns.Add(CreateIsPrimaryColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e639ba30-7068-48c5-8671-bf726dff2671"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateCitizenshipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("70112220-778a-4078-b682-a1c78a0179fd"),
				Name = @"Citizenship",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateRegDocumentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f2b59e3e-cfd2-4f1e-a205-d06e18f0242d"),
				Name = @"RegDocumentType",
				ReferenceSchemaUId = new Guid("ec520e44-c1ab-4545-8489-6e9adaf5c73b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateSeriesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("88fab035-3e12-4305-8ef6-e75b2cf996db"),
				Name = @"Series",
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b5a3460c-51ee-402e-864e-de13c14a5565"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateIssuedByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("41833dab-d075-4ffe-a8bc-5f3ef017929e"),
				Name = @"IssuedBy",
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateIssueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("cd878aa4-15f7-4573-96f4-6d7ef052cc12"),
				Name = @"IssueDate",
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateValidUntilColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("a0058cbc-3728-4c53-bca4-9801e2881e4e"),
				Name = @"ValidUntil",
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeDivisionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("e9aea89e-fd13-43b0-a96f-c7ca20571b3c"),
				Name = @"CodeDivision",
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected virtual EntitySchemaColumn CreateIsPrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("920d7848-9fd1-46a3-b0b1-cef07099cf21"),
				Name = @"IsPrimary",
				CreatedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				ModifiedInSchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"),
				CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RegDocument_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RegDocument_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RegDocument_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RegDocument_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42"));
		}

		#endregion

	}

	#endregion

	#region Class: RegDocument_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Registration document.
	/// </summary>
	public class RegDocument_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public RegDocument_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RegDocument_CrtBaseFinserv_Terrasoft";
		}

		public RegDocument_CrtBaseFinserv_Terrasoft(RegDocument_CrtBaseFinserv_Terrasoft source)
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
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
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
		public Guid RegDocumentTypeId {
			get {
				return GetTypedColumnValue<Guid>("RegDocumentTypeId");
			}
			set {
				SetColumnValue("RegDocumentTypeId", value);
				_regDocumentType = null;
			}
		}

		/// <exclude/>
		public string RegDocumentTypeName {
			get {
				return GetTypedColumnValue<string>("RegDocumentTypeName");
			}
			set {
				SetColumnValue("RegDocumentTypeName", value);
				if (_regDocumentType != null) {
					_regDocumentType.Name = value;
				}
			}
		}

		private RegDocumentType _regDocumentType;
		/// <summary>
		/// Document type.
		/// </summary>
		public RegDocumentType RegDocumentType {
			get {
				return _regDocumentType ??
					(_regDocumentType = LookupColumnEntities.GetEntity("RegDocumentType") as RegDocumentType);
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
		/// Issued on.
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
		/// Valid until.
		/// </summary>
		public DateTime ValidUntil {
			get {
				return GetTypedColumnValue<DateTime>("ValidUntil");
			}
			set {
				SetColumnValue("ValidUntil", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RegDocument_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RegDocument_CrtBaseFinserv_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("RegDocument_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("RegDocument_CrtBaseFinserv_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("RegDocument_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RegDocument_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: RegDocument_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class RegDocument_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : RegDocument_CrtBaseFinserv_Terrasoft
	{

		public RegDocument_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RegDocument_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("70fa20d7-9317-4480-ae3b-5f33df17dd42");
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

	#region Class: RegDocument_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class RegDocument_CrtBaseFinservEventsProcess : RegDocument_CrtBaseFinservEventsProcess<RegDocument_CrtBaseFinserv_Terrasoft>
	{

		public RegDocument_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

