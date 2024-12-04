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

	#region Class: AppValQuestionResultSchema

	/// <exclude/>
	public class AppValQuestionResultSchema : Terrasoft.Configuration.AppValidationQuestionSchema
	{

		#region Constructors: Public

		public AppValQuestionResultSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValQuestionResultSchema(AppValQuestionResultSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValQuestionResultSchema(AppValQuestionResultSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a");
			RealUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a");
			Name = "AppValQuestionResult";
			ParentSchemaUId = new Guid("32a37bf0-2daf-4772-a41f-bc625be5fd68");
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
			if (Columns.FindByUId(new Guid("084de351-d385-45b0-86d4-9e717a6514ed")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("b08eb58b-9235-4df6-9f6d-b230b138f4b0")) == null) {
				Columns.Add(CreateAppValidationAnswerColumn());
			}
			if (Columns.FindByUId(new Guid("0adb17fd-1e41-402a-bade-ddecd5a59185")) == null) {
				Columns.Add(CreateAppValidationColumn());
			}
		}

		protected override EntitySchemaColumn CreateAppValidationItemColumn() {
			EntitySchemaColumn column = base.CreateAppValidationItemColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a");
			return column;
		}

		protected override EntitySchemaColumn CreateQuestionColumn() {
			EntitySchemaColumn column = base.CreateQuestionColumn();
			column.IsMultiLineText = true;
			column.ModifiedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("084de351-d385-45b0-86d4-9e717a6514ed"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a"),
				ModifiedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAppValidationAnswerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b08eb58b-9235-4df6-9f6d-b230b138f4b0"),
				Name = @"AppValidationAnswer",
				ReferenceSchemaUId = new Guid("14569457-970c-45f7-a78f-2c7d9b57bf0b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a"),
				ModifiedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateAppValidationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0adb17fd-1e41-402a-bade-ddecd5a59185"),
				Name = @"AppValidation",
				ReferenceSchemaUId = new Guid("5b073788-2338-4689-9971-5aadcd4c4794"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a"),
				ModifiedInSchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a"),
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
			return new AppValQuestionResult(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValQuestionResult_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValQuestionResultSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValQuestionResultSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValQuestionResult

	/// <summary>
	/// Check list.
	/// </summary>
	public class AppValQuestionResult : Terrasoft.Configuration.AppValidationQuestion
	{

		#region Constructors: Public

		public AppValQuestionResult(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValQuestionResult";
		}

		public AppValQuestionResult(AppValQuestionResult source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <exclude/>
		public Guid AppValidationAnswerId {
			get {
				return GetTypedColumnValue<Guid>("AppValidationAnswerId");
			}
			set {
				SetColumnValue("AppValidationAnswerId", value);
				_appValidationAnswer = null;
			}
		}

		/// <exclude/>
		public string AppValidationAnswerName {
			get {
				return GetTypedColumnValue<string>("AppValidationAnswerName");
			}
			set {
				SetColumnValue("AppValidationAnswerName", value);
				if (_appValidationAnswer != null) {
					_appValidationAnswer.Name = value;
				}
			}
		}

		private AppValidationAnswer _appValidationAnswer;
		/// <summary>
		/// Answer.
		/// </summary>
		public AppValidationAnswer AppValidationAnswer {
			get {
				return _appValidationAnswer ??
					(_appValidationAnswer = LookupColumnEntities.GetEntity("AppValidationAnswer") as AppValidationAnswer);
			}
		}

		/// <exclude/>
		public Guid AppValidationId {
			get {
				return GetTypedColumnValue<Guid>("AppValidationId");
			}
			set {
				SetColumnValue("AppValidationId", value);
				_appValidation = null;
			}
		}

		/// <exclude/>
		public string AppValidationName {
			get {
				return GetTypedColumnValue<string>("AppValidationName");
			}
			set {
				SetColumnValue("AppValidationName", value);
				if (_appValidation != null) {
					_appValidation.Name = value;
				}
			}
		}

		private AppValidation _appValidation;
		/// <summary>
		/// Verification.
		/// </summary>
		public AppValidation AppValidation {
			get {
				return _appValidation ??
					(_appValidation = LookupColumnEntities.GetEntity("AppValidation") as AppValidation);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValQuestionResult_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValQuestionResultDeleted", e);
			Deleting += (s, e) => ThrowEvent("AppValQuestionResultDeleting", e);
			Inserted += (s, e) => ThrowEvent("AppValQuestionResultInserted", e);
			Inserting += (s, e) => ThrowEvent("AppValQuestionResultInserting", e);
			Saved += (s, e) => ThrowEvent("AppValQuestionResultSaved", e);
			Saving += (s, e) => ThrowEvent("AppValQuestionResultSaving", e);
			Validating += (s, e) => ThrowEvent("AppValQuestionResultValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValQuestionResult(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValQuestionResult_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppValQuestionResult_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.AppValidationQuestion_CrtFinservApplicationEventsProcess<TEntity> where TEntity : AppValQuestionResult
	{

		public AppValQuestionResult_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValQuestionResult_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5af8bd15-188e-4f53-b8cb-7e61cfdbb80a");
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

	#region Class: AppValQuestionResult_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppValQuestionResult_CrtFinservApplicationEventsProcess : AppValQuestionResult_CrtFinservApplicationEventsProcess<AppValQuestionResult>
	{

		public AppValQuestionResult_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppValQuestionResult_CrtFinservApplicationEventsProcess

	public partial class AppValQuestionResult_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppValQuestionResultEventsProcess

	/// <exclude/>
	public class AppValQuestionResultEventsProcess : AppValQuestionResult_CrtFinservApplicationEventsProcess
	{

		public AppValQuestionResultEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

