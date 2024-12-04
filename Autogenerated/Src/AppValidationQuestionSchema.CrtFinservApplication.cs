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

	#region Class: AppValidationQuestionSchema

	/// <exclude/>
	public class AppValidationQuestionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AppValidationQuestionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValidationQuestionSchema(AppValidationQuestionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValidationQuestionSchema(AppValidationQuestionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68");
			RealUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68");
			Name = "AppValidationQuestion";
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
			if (Columns.FindByUId(new Guid("ed855fd1-52c5-4066-97f6-a7e3baaaa8e0")) == null) {
				Columns.Add(CreateAppValidationItemColumn());
			}
			if (Columns.FindByUId(new Guid("8f68aaab-98e0-47da-8cf0-ffff501e92b2")) == null) {
				Columns.Add(CreateIsRequiredColumn());
			}
			if (Columns.FindByUId(new Guid("dc5a7879-eb03-4eed-b263-7c4e80b49493")) == null) {
				Columns.Add(CreateQuestionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAppValidationItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ed855fd1-52c5-4066-97f6-a7e3baaaa8e0"),
				Name = @"AppValidationItem",
				ReferenceSchemaUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68"),
				ModifiedInSchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateIsRequiredColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8f68aaab-98e0-47da-8cf0-ffff501e92b2"),
				Name = @"IsRequired",
				CreatedInSchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68"),
				ModifiedInSchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateQuestionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("dc5a7879-eb03-4eed-b263-7c4e80b49493"),
				Name = @"Question",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68"),
				ModifiedInSchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68"),
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
			return new AppValidationQuestion(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValidationQuestion_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValidationQuestionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValidationQuestionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationQuestion

	/// <summary>
	/// Check list.
	/// </summary>
	public class AppValidationQuestion : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AppValidationQuestion(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidationQuestion";
		}

		public AppValidationQuestion(AppValidationQuestion source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AppValidationItemId {
			get {
				return GetTypedColumnValue<Guid>("AppValidationItemId");
			}
			set {
				SetColumnValue("AppValidationItemId", value);
				_appValidationItem = null;
			}
		}

		/// <exclude/>
		public string AppValidationItemName {
			get {
				return GetTypedColumnValue<string>("AppValidationItemName");
			}
			set {
				SetColumnValue("AppValidationItemName", value);
				if (_appValidationItem != null) {
					_appValidationItem.Name = value;
				}
			}
		}

		private AppValidationItem _appValidationItem;
		/// <summary>
		/// Validation action.
		/// </summary>
		public AppValidationItem AppValidationItem {
			get {
				return _appValidationItem ??
					(_appValidationItem = LookupColumnEntities.GetEntity("AppValidationItem") as AppValidationItem);
			}
		}

		/// <summary>
		/// Required.
		/// </summary>
		public bool IsRequired {
			get {
				return GetTypedColumnValue<bool>("IsRequired");
			}
			set {
				SetColumnValue("IsRequired", value);
			}
		}

		/// <summary>
		/// Question.
		/// </summary>
		public string Question {
			get {
				return GetTypedColumnValue<string>("Question");
			}
			set {
				SetColumnValue("Question", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValidationQuestion_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValidationQuestionDeleted", e);
			Validating += (s, e) => ThrowEvent("AppValidationQuestionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidationQuestion(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationQuestion_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppValidationQuestion_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AppValidationQuestion
	{

		public AppValidationQuestion_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValidationQuestion_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68");
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

	#region Class: AppValidationQuestion_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppValidationQuestion_CrtFinservApplicationEventsProcess : AppValidationQuestion_CrtFinservApplicationEventsProcess<AppValidationQuestion>
	{

		public AppValidationQuestion_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppValidationQuestion_CrtFinservApplicationEventsProcess

	public partial class AppValidationQuestion_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppValidationQuestionEventsProcess

	/// <exclude/>
	public class AppValidationQuestionEventsProcess : AppValidationQuestion_CrtFinservApplicationEventsProcess
	{

		public AppValidationQuestionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

