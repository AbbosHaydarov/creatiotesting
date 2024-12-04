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

	#region Class: AppValidation_CrtFinservApplication_TerrasoftSchema

	/// <exclude/>
	public class AppValidation_CrtFinservApplication_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AppValidation_CrtFinservApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValidation_CrtFinservApplication_TerrasoftSchema(AppValidation_CrtFinservApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValidation_CrtFinservApplication_TerrasoftSchema(AppValidation_CrtFinservApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794");
			RealUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794");
			Name = "AppValidation_CrtFinservApplication_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1eff5643-db22-4405-b765-280d3cdb832b")) == null) {
				Columns.Add(CreateValidationItemColumn());
			}
			if (Columns.FindByUId(new Guid("6ce13bf7-f6c8-45a2-9f82-09779092d15f")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
			if (Columns.FindByUId(new Guid("e97705f1-fcf7-4685-9d9c-50ddd3b2e786")) == null) {
				Columns.Add(CreateValidationResultColumn());
			}
			if (Columns.FindByUId(new Guid("fb07d542-5be2-4891-a43f-5209f5a0925f")) == null) {
				Columns.Add(CreateParticipantColumn());
			}
			if (Columns.FindByUId(new Guid("10b1c85e-2bda-4e8b-bc71-763c2dc9e129")) == null) {
				Columns.Add(CreateParticipantRoleColumn());
			}
			if (Columns.FindByUId(new Guid("f8323c2b-9888-472d-956b-68f28a043521")) == null) {
				Columns.Add(CreateRoleColumn());
			}
			if (Columns.FindByUId(new Guid("98993d20-cf7b-4fee-9231-86b68e6c47b7")) == null) {
				Columns.Add(CreateValidationDateColumn());
			}
			if (Columns.FindByUId(new Guid("de3038fc-cfa4-4336-99e6-3ea9a1d9d438")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("ff0d4ab4-af4b-472f-babd-91e8d8e99422")) == null) {
				Columns.Add(CreateCommentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateValidationItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1eff5643-db22-4405-b765-280d3cdb832b"),
				Name = @"ValidationItem",
				ReferenceSchemaUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6ce13bf7-f6c8-45a2-9f82-09779092d15f"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateValidationResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e97705f1-fcf7-4685-9d9c-50ddd3b2e786"),
				Name = @"ValidationResult",
				ReferenceSchemaUId = new Guid("2edae1ed-a765-4453-8a7d-f7652fe3efa6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateParticipantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fb07d542-5be2-4891-a43f-5209f5a0925f"),
				Name = @"Participant",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateParticipantRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("10b1c85e-2bda-4e8b-bc71-763c2dc9e129"),
				Name = @"ParticipantRole",
				ReferenceSchemaUId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f8323c2b-9888-472d-956b-68f28a043521"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateValidationDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("98993d20-cf7b-4fee-9231-86b68e6c47b7"),
				Name = @"ValidationDate",
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("de3038fc-cfa4-4336-99e6-3ea9a1d9d438"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("ff0d4ab4-af4b-472f-babd-91e8d8e99422"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ca6b9a3b-d8c7-4f93-a531-ada177169e55"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				ModifiedInSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppValidation_CrtFinservApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValidation_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValidation_CrtFinservApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValidation_CrtFinservApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b073788-2338-4689-9971-5aadcd4c4794"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValidation_CrtFinservApplication_Terrasoft

	/// <summary>
	/// Validation.
	/// </summary>
	public class AppValidation_CrtFinservApplication_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AppValidation_CrtFinservApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidation_CrtFinservApplication_Terrasoft";
		}

		public AppValidation_CrtFinservApplication_Terrasoft(AppValidation_CrtFinservApplication_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ValidationItemId {
			get {
				return GetTypedColumnValue<Guid>("ValidationItemId");
			}
			set {
				SetColumnValue("ValidationItemId", value);
				_validationItem = null;
			}
		}

		/// <exclude/>
		public string ValidationItemName {
			get {
				return GetTypedColumnValue<string>("ValidationItemName");
			}
			set {
				SetColumnValue("ValidationItemName", value);
				if (_validationItem != null) {
					_validationItem.Name = value;
				}
			}
		}

		private AppValidationItem _validationItem;
		/// <summary>
		/// Validation item.
		/// </summary>
		public AppValidationItem ValidationItem {
			get {
				return _validationItem ??
					(_validationItem = LookupColumnEntities.GetEntity("ValidationItem") as AppValidationItem);
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
		public Guid ValidationResultId {
			get {
				return GetTypedColumnValue<Guid>("ValidationResultId");
			}
			set {
				SetColumnValue("ValidationResultId", value);
				_validationResult = null;
			}
		}

		/// <exclude/>
		public string ValidationResultName {
			get {
				return GetTypedColumnValue<string>("ValidationResultName");
			}
			set {
				SetColumnValue("ValidationResultName", value);
				if (_validationResult != null) {
					_validationResult.Name = value;
				}
			}
		}

		private AppValidationResult _validationResult;
		/// <summary>
		/// Result.
		/// </summary>
		public AppValidationResult ValidationResult {
			get {
				return _validationResult ??
					(_validationResult = LookupColumnEntities.GetEntity("ValidationResult") as AppValidationResult);
			}
		}

		/// <exclude/>
		public Guid ParticipantId {
			get {
				return GetTypedColumnValue<Guid>("ParticipantId");
			}
			set {
				SetColumnValue("ParticipantId", value);
				_participant = null;
			}
		}

		/// <exclude/>
		public string ParticipantParticipant {
			get {
				return GetTypedColumnValue<string>("ParticipantParticipant");
			}
			set {
				SetColumnValue("ParticipantParticipant", value);
				if (_participant != null) {
					_participant.Participant = value;
				}
			}
		}

		private AppForm _participant;
		/// <summary>
		/// Application form.
		/// </summary>
		public AppForm Participant {
			get {
				return _participant ??
					(_participant = LookupColumnEntities.GetEntity("Participant") as AppForm);
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

		private SysAdminUnit _role;
		/// <summary>
		/// Role.
		/// </summary>
		public SysAdminUnit Role {
			get {
				return _role ??
					(_role = LookupColumnEntities.GetEntity("Role") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Validation date.
		/// </summary>
		public DateTime ValidationDate {
			get {
				return GetTypedColumnValue<DateTime>("ValidationDate");
			}
			set {
				SetColumnValue("ValidationDate", value);
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

		/// <summary>
		/// Comment.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValidation_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValidation_CrtFinservApplication_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("AppValidation_CrtFinservApplication_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AppValidation_CrtFinservApplication_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AppValidation_CrtFinservApplication_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidation_CrtFinservApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidation_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppValidation_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AppValidation_CrtFinservApplication_Terrasoft
	{

		public AppValidation_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValidation_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5b073788-2338-4689-9971-5aadcd4c4794");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid OldValidationItemId {
			get;
			set;
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

	#region Class: AppValidation_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppValidation_CrtFinservApplicationEventsProcess : AppValidation_CrtFinservApplicationEventsProcess<AppValidation_CrtFinservApplication_Terrasoft>
	{

		public AppValidation_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

