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

	#region Class: IncomeAndExpenseInAppFormSchema

	/// <exclude/>
	public class IncomeAndExpenseInAppFormSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public IncomeAndExpenseInAppFormSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public IncomeAndExpenseInAppFormSchema(IncomeAndExpenseInAppFormSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public IncomeAndExpenseInAppFormSchema(IncomeAndExpenseInAppFormSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a");
			RealUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a");
			Name = "IncomeAndExpenseInAppForm";
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
			if (Columns.FindByUId(new Guid("b9a26741-5023-4035-9ec7-eea996e33e9a")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("d7d21946-e40b-4888-ac1e-3129d1bdb5a3")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("f16712c0-ebb5-4eb4-8219-9b0565afc998")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("b9a26741-5023-4035-9ec7-eea996e33e9a"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a"),
				ModifiedInSchemaUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d7d21946-e40b-4888-ac1e-3129d1bdb5a3"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a"),
				ModifiedInSchemaUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f16712c0-ebb5-4eb4-8219-9b0565afc998"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a"),
				ModifiedInSchemaUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a"),
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
			return new IncomeAndExpenseInAppForm(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new IncomeAndExpenseInAppFormSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new IncomeAndExpenseInAppFormSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06225049-7105-49e0-84e0-eedb51d8b16a"));
		}

		#endregion

	}

	#endregion

	#region Class: IncomeAndExpenseInAppForm

	/// <summary>
	/// Income and expenses in application form.
	/// </summary>
	public class IncomeAndExpenseInAppForm : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public IncomeAndExpenseInAppForm(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "IncomeAndExpenseInAppForm";
		}

		public IncomeAndExpenseInAppForm(IncomeAndExpenseInAppForm source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		private IncomeAndExpenseSource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public IncomeAndExpenseSource Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as IncomeAndExpenseSource);
			}
		}

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
		/// Application Form.
		/// </summary>
		public AppForm AppForm {
			get {
				return _appForm ??
					(_appForm = LookupColumnEntities.GetEntity("AppForm") as AppForm);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("IncomeAndExpenseInAppFormDeleted", e);
			Validating += (s, e) => ThrowEvent("IncomeAndExpenseInAppFormValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IncomeAndExpenseInAppForm(this);
		}

		#endregion

	}

	#endregion

	#region Class: IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : IncomeAndExpenseInAppForm
	{

		public IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("06225049-7105-49e0-84e0-eedb51d8b16a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("06225049-7105-49e0-84e0-eedb51d8b16a");
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

	#region Class: IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess : IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess<IncomeAndExpenseInAppForm>
	{

		public IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess

	public partial class IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: IncomeAndExpenseInAppFormEventsProcess

	/// <exclude/>
	public class IncomeAndExpenseInAppFormEventsProcess : IncomeAndExpenseInAppForm_CrtFinservApplicationEventsProcess
	{

		public IncomeAndExpenseInAppFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

