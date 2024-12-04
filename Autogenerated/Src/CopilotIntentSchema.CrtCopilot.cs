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

	#region Class: CopilotIntentSchema

	/// <exclude/>
	[IsVirtual]
	public class CopilotIntentSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public CopilotIntentSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CopilotIntentSchema(CopilotIntentSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CopilotIntentSchema(CopilotIntentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			RealUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			Name = "CopilotIntent";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e94aa263-bfb4-4fa2-906e-1a8040844e6c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fd74cb1d-8581-7757-ccc4-37b0c47b3fcf")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("a440274b-60df-319e-f31d-94b4ffeb8c55")) == null) {
				Columns.Add(CreatePromptColumn());
			}
			if (Columns.FindByUId(new Guid("71bab4b1-806b-3e6a-bc71-bc42def75c05")) == null) {
				Columns.Add(CreatePackageUIdColumn());
			}
			if (Columns.FindByUId(new Guid("01a7f87c-4b97-bda5-b26e-cf832ea95121")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("1faf575b-0e5f-9c15-5110-42359f4d83e5")) == null) {
				Columns.Add(CreateModeColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			return column;
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fd74cb1d-8581-7757-ccc4-37b0c47b3fcf"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("157ceb57-a606-426e-952e-7cadeac5650a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				CreatedInPackageId = new Guid("a4098b1e-9718-401a-b1c3-ae0a33f3e48f"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"4670b068-ad03-4364-9350-6cc61efd1b7f"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePromptColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("RichText")) {
				UId = new Guid("a440274b-60df-319e-f31d-94b4ffeb8c55"),
				Name = @"Prompt",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				CreatedInPackageId = new Guid("a4098b1e-9718-401a-b1c3-ae0a33f3e48f")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("71bab4b1-806b-3e6a-bc71-bc42def75c05"),
				Name = @"PackageUId",
				CreatedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				CreatedInPackageId = new Guid("bada5b38-c916-4512-97f3-8d4b5a8a22b4")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("01a7f87c-4b97-bda5-b26e-cf832ea95121"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("98aeb3cf-5caf-4a0e-964b-a9c40a043104"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				CreatedInPackageId = new Guid("800f00c8-04db-4ed1-bc94-0c44b7e5e4f0"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateModeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1faf575b-0e5f-9c15-5110-42359f4d83e5"),
				Name = @"Mode",
				ReferenceSchemaUId = new Guid("c541ee8e-5939-4e57-be5b-9c252fe968cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				ModifiedInSchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"),
				CreatedInPackageId = new Guid("a5645ea0-1b73-4b60-b012-23b3100050d4"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"326bba59-302a-4a5e-857c-2576e1a38ab0"
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
			return new CopilotIntent(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CopilotIntent_CrtCopilotEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CopilotIntentSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CopilotIntentSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec"));
		}

		#endregion

	}

	#endregion

	#region Class: CopilotIntent

	/// <summary>
	/// CopilotIntent.
	/// </summary>
	public class CopilotIntent : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public CopilotIntent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CopilotIntent";
		}

		public CopilotIntent(CopilotIntent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private CopilotIntentStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public CopilotIntentStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as CopilotIntentStatus);
			}
		}

		/// <summary>
		/// Prompt.
		/// </summary>
		public string Prompt {
			get {
				return GetTypedColumnValue<string>("Prompt");
			}
			set {
				SetColumnValue("Prompt", value);
			}
		}

		/// <summary>
		/// Package unique identifier.
		/// </summary>
		public Guid PackageUId {
			get {
				return GetTypedColumnValue<Guid>("PackageUId");
			}
			set {
				SetColumnValue("PackageUId", value);
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

		private CopilotIntentType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public CopilotIntentType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as CopilotIntentType);
			}
		}

		/// <exclude/>
		public Guid ModeId {
			get {
				return GetTypedColumnValue<Guid>("ModeId");
			}
			set {
				SetColumnValue("ModeId", value);
				_mode = null;
			}
		}

		/// <exclude/>
		public string ModeName {
			get {
				return GetTypedColumnValue<string>("ModeName");
			}
			set {
				SetColumnValue("ModeName", value);
				if (_mode != null) {
					_mode.Name = value;
				}
			}
		}

		private CopilotIntentMode _mode;
		/// <summary>
		/// Mode.
		/// </summary>
		public CopilotIntentMode Mode {
			get {
				return _mode ??
					(_mode = LookupColumnEntities.GetEntity("Mode") as CopilotIntentMode);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CopilotIntent_CrtCopilotEventsProcess(UserConnection);
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
			return new CopilotIntent(this);
		}

		#endregion

	}

	#endregion

	#region Class: CopilotIntent_CrtCopilotEventsProcess

	/// <exclude/>
	public partial class CopilotIntent_CrtCopilotEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : CopilotIntent
	{

		public CopilotIntent_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CopilotIntent_CrtCopilotEventsProcess";
			SchemaUId = new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7cd7a99a-b22e-4e50-af02-6ee4ac8612ec");
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

	#region Class: CopilotIntent_CrtCopilotEventsProcess

	/// <exclude/>
	public class CopilotIntent_CrtCopilotEventsProcess : CopilotIntent_CrtCopilotEventsProcess<CopilotIntent>
	{

		public CopilotIntent_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CopilotIntent_CrtCopilotEventsProcess

	public partial class CopilotIntent_CrtCopilotEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CopilotIntentEventsProcess

	/// <exclude/>
	public class CopilotIntentEventsProcess : CopilotIntent_CrtCopilotEventsProcess
	{

		public CopilotIntentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

