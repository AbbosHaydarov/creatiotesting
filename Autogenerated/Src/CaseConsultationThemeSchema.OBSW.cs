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

	#region Class: CaseConsultationThemeSchema

	/// <exclude/>
	public class CaseConsultationThemeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CaseConsultationThemeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseConsultationThemeSchema(CaseConsultationThemeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseConsultationThemeSchema(CaseConsultationThemeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b");
			RealUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b");
			Name = "CaseConsultationTheme";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fd765cb6-b181-49fd-8ec2-f5f4e071792e")) == null) {
				Columns.Add(CreateCaseColumn());
			}
			if (Columns.FindByUId(new Guid("caa0c011-e1b2-4b13-9195-0d8b608efa06")) == null) {
				Columns.Add(CreateThemeColumn());
			}
			if (Columns.FindByUId(new Guid("93f6f913-3ebe-4282-b13a-b27ce85871fc")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("425e496c-9ec2-4cc8-9984-562e14fa1768")) == null) {
				Columns.Add(CreateLeadMediumColumn());
			}
			if (Columns.FindByUId(new Guid("67db3bf1-6c6d-4c7a-a133-5a704c091ed6")) == null) {
				Columns.Add(CreateResultColumn());
			}
			if (Columns.FindByUId(new Guid("0421986b-5617-46e2-8ffd-78e2bd888915")) == null) {
				Columns.Add(CreateDateTimeStartColumn());
			}
			if (Columns.FindByUId(new Guid("8860499e-ac40-4c49-9725-00b8e32998ba")) == null) {
				Columns.Add(CreateDateTimeEndColumn());
			}
			if (Columns.FindByUId(new Guid("d2f07388-fdad-40b9-b2ad-e9649eab7640")) == null) {
				Columns.Add(CreateDurationInSecondsColumn());
			}
			if (Columns.FindByUId(new Guid("b560aefb-1c78-4c18-aceb-e90ce9ede93a")) == null) {
				Columns.Add(CreateDurationColumn());
			}
			if (Columns.FindByUId(new Guid("7cf2992f-7130-4f93-ad02-4928a040a986")) == null) {
				Columns.Add(CreateCommentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fd765cb6-b181-49fd-8ec2-f5f4e071792e"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateThemeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("caa0c011-e1b2-4b13-9195-0d8b608efa06"),
				Name = @"Theme",
				ReferenceSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("93f6f913-3ebe-4282-b13a-b27ce85871fc"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadMediumColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("425e496c-9ec2-4cc8-9984-562e14fa1768"),
				Name = @"LeadMedium",
				ReferenceSchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("67db3bf1-6c6d-4c7a-a133-5a704c091ed6"),
				Name = @"Result",
				ReferenceSchemaUId = new Guid("a751c2e7-865b-4645-92e1-75a737015b54"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateDateTimeStartColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("0421986b-5617-46e2-8ffd-78e2bd888915"),
				Name = @"DateTimeStart",
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDateTimeEndColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("8860499e-ac40-4c49-9725-00b8e32998ba"),
				Name = @"DateTimeEnd",
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInSecondsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d2f07388-fdad-40b9-b2ad-e9649eab7640"),
				Name = @"DurationInSeconds",
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b560aefb-1c78-4c18-aceb-e90ce9ede93a"),
				Name = @"Duration",
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("7cf2992f-7130-4f93-ad02-4928a040a986"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				ModifiedInSchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"),
				CreatedInPackageId = new Guid("9a81f169-b7e9-4fdc-86ba-fba6a57c3d94")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseConsultationTheme(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CaseConsultationTheme_OBSWEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CaseConsultationThemeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseConsultationThemeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0b15550-eb1b-4557-9847-d193804edd4b"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseConsultationTheme

	/// <summary>
	/// Consultation theme in case.
	/// </summary>
	public class CaseConsultationTheme : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CaseConsultationTheme(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseConsultationTheme";
		}

		public CaseConsultationTheme(CaseConsultationTheme source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CaseId {
			get {
				return GetTypedColumnValue<Guid>("CaseId");
			}
			set {
				SetColumnValue("CaseId", value);
				_case = null;
			}
		}

		/// <exclude/>
		public string CaseNumber {
			get {
				return GetTypedColumnValue<string>("CaseNumber");
			}
			set {
				SetColumnValue("CaseNumber", value);
				if (_case != null) {
					_case.Number = value;
				}
			}
		}

		private Case _case;
		/// <summary>
		/// Case.
		/// </summary>
		public Case Case {
			get {
				return _case ??
					(_case = LookupColumnEntities.GetEntity("Case") as Case);
			}
		}

		/// <exclude/>
		public Guid ThemeId {
			get {
				return GetTypedColumnValue<Guid>("ThemeId");
			}
			set {
				SetColumnValue("ThemeId", value);
				_theme = null;
			}
		}

		/// <exclude/>
		public string ThemeName {
			get {
				return GetTypedColumnValue<string>("ThemeName");
			}
			set {
				SetColumnValue("ThemeName", value);
				if (_theme != null) {
					_theme.Name = value;
				}
			}
		}

		private ConsultationTheme _theme;
		/// <summary>
		/// Subject.
		/// </summary>
		public ConsultationTheme Theme {
			get {
				return _theme ??
					(_theme = LookupColumnEntities.GetEntity("Theme") as ConsultationTheme);
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
		public Guid LeadMediumId {
			get {
				return GetTypedColumnValue<Guid>("LeadMediumId");
			}
			set {
				SetColumnValue("LeadMediumId", value);
				_leadMedium = null;
			}
		}

		/// <exclude/>
		public string LeadMediumName {
			get {
				return GetTypedColumnValue<string>("LeadMediumName");
			}
			set {
				SetColumnValue("LeadMediumName", value);
				if (_leadMedium != null) {
					_leadMedium.Name = value;
				}
			}
		}

		private LeadMedium _leadMedium;
		/// <summary>
		/// Involvement channel.
		/// </summary>
		public LeadMedium LeadMedium {
			get {
				return _leadMedium ??
					(_leadMedium = LookupColumnEntities.GetEntity("LeadMedium") as LeadMedium);
			}
		}

		/// <exclude/>
		public Guid ResultId {
			get {
				return GetTypedColumnValue<Guid>("ResultId");
			}
			set {
				SetColumnValue("ResultId", value);
				_result = null;
			}
		}

		/// <exclude/>
		public string ResultName {
			get {
				return GetTypedColumnValue<string>("ResultName");
			}
			set {
				SetColumnValue("ResultName", value);
				if (_result != null) {
					_result.Name = value;
				}
			}
		}

		private SubjectResult _result;
		/// <summary>
		/// Result.
		/// </summary>
		public SubjectResult Result {
			get {
				return _result ??
					(_result = LookupColumnEntities.GetEntity("Result") as SubjectResult);
			}
		}

		/// <summary>
		/// Start.
		/// </summary>
		public DateTime DateTimeStart {
			get {
				return GetTypedColumnValue<DateTime>("DateTimeStart");
			}
			set {
				SetColumnValue("DateTimeStart", value);
			}
		}

		/// <summary>
		/// End.
		/// </summary>
		public DateTime DateTimeEnd {
			get {
				return GetTypedColumnValue<DateTime>("DateTimeEnd");
			}
			set {
				SetColumnValue("DateTimeEnd", value);
			}
		}

		/// <summary>
		/// Duration, seconds.
		/// </summary>
		public int DurationInSeconds {
			get {
				return GetTypedColumnValue<int>("DurationInSeconds");
			}
			set {
				SetColumnValue("DurationInSeconds", value);
			}
		}

		/// <summary>
		/// Duration.
		/// </summary>
		public string Duration {
			get {
				return GetTypedColumnValue<string>("Duration");
			}
			set {
				SetColumnValue("Duration", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseConsultationTheme_OBSWEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CaseConsultationThemeDeleted", e);
			Saving += (s, e) => ThrowEvent("CaseConsultationThemeSaving", e);
			Validating += (s, e) => ThrowEvent("CaseConsultationThemeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseConsultationTheme(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseConsultationTheme_OBSWEventsProcess

	/// <exclude/>
	public partial class CaseConsultationTheme_OBSWEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CaseConsultationTheme
	{

		public CaseConsultationTheme_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseConsultationTheme_OBSWEventsProcess";
			SchemaUId = new Guid("c0b15550-eb1b-4557-9847-d193804edd4b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c0b15550-eb1b-4557-9847-d193804edd4b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("e77a6e4e-7ac2-483b-a5d8-7d0390f6208b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("6db6eb92-f846-409a-b70e-dd185d364bfd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("0bf08edf-51a5-41d5-849c-80e55c1a264c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var consultationStart = Entity.DateTimeStart;
			var consultationEnd = Entity.DateTimeEnd;
			if (consultationStart != DateTime.MinValue && consultationEnd != DateTime.MinValue) {
				TimeSpan duration = Entity.DateTimeEnd - Entity.DateTimeStart;
				int durationInSeconds = Convert.ToInt32(duration.TotalSeconds);
				var durationMinutes = Math.Abs((int)duration.TotalMinutes).ToString();
				var durationSeconds = Math.Abs(Convert.ToInt32(duration.Seconds));
				string durationMinutesString = Convert.ToInt32(durationMinutes) < 10 ? "0" + durationMinutes : durationMinutes;
				string durationSecondsString = durationSeconds < 10 ? "0" + durationSeconds.ToString() : durationSeconds.ToString();
				Entity.Duration = durationMinutesString + ":" + durationSecondsString;
				Entity.DurationInSeconds = Math.Abs(durationInSeconds);
			} else {
				Entity.Duration = string.Empty;
				Entity.DurationInSeconds = 0;
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CaseConsultationThemeSaving":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: CaseConsultationTheme_OBSWEventsProcess

	/// <exclude/>
	public class CaseConsultationTheme_OBSWEventsProcess : CaseConsultationTheme_OBSWEventsProcess<CaseConsultationTheme>
	{

		public CaseConsultationTheme_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseConsultationTheme_OBSWEventsProcess

	public partial class CaseConsultationTheme_OBSWEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CaseConsultationThemeEventsProcess

	/// <exclude/>
	public class CaseConsultationThemeEventsProcess : CaseConsultationTheme_OBSWEventsProcess
	{

		public CaseConsultationThemeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

