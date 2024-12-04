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

	#region Class: PlaybookStageSchema

	/// <exclude/>
	public class PlaybookStageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PlaybookStageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PlaybookStageSchema(PlaybookStageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PlaybookStageSchema(PlaybookStageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd");
			RealUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd");
			Name = "PlaybookStage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a3e3f73c-77d7-f885-f44e-c0cd74ae365b")) == null) {
				Columns.Add(CreateKnowledgeBaseColumn());
			}
			if (Columns.FindByUId(new Guid("0cfcfb87-c9d1-4682-d72e-4f2594d66fe5")) == null) {
				Columns.Add(CreatePlaybookColumn());
			}
			if (Columns.FindByUId(new Guid("e18d46f5-c23c-adab-ae70-09815ee8df78")) == null) {
				Columns.Add(CreateDcmStageValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateKnowledgeBaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3e3f73c-77d7-f885-f44e-c0cd74ae365b"),
				Name = @"KnowledgeBase",
				ReferenceSchemaUId = new Guid("0326868c-ce5e-4934-8f1f-178801bfe6c3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd"),
				ModifiedInSchemaUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd"),
				CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreatePlaybookColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0cfcfb87-c9d1-4682-d72e-4f2594d66fe5"),
				Name = @"Playbook",
				ReferenceSchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd"),
				ModifiedInSchemaUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd"),
				CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDcmStageValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e18d46f5-c23c-adab-ae70-09815ee8df78"),
				Name = @"DcmStageValue",
				CreatedInSchemaUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd"),
				ModifiedInSchemaUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd"),
				CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PlaybookStage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PlaybookStage_CrtPlaybookEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PlaybookStageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PlaybookStageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd"));
		}

		#endregion

	}

	#endregion

	#region Class: PlaybookStage

	/// <summary>
	/// Playbook stage.
	/// </summary>
	public class PlaybookStage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PlaybookStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PlaybookStage";
		}

		public PlaybookStage(PlaybookStage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid KnowledgeBaseId {
			get {
				return GetTypedColumnValue<Guid>("KnowledgeBaseId");
			}
			set {
				SetColumnValue("KnowledgeBaseId", value);
				_knowledgeBase = null;
			}
		}

		/// <exclude/>
		public string KnowledgeBaseName {
			get {
				return GetTypedColumnValue<string>("KnowledgeBaseName");
			}
			set {
				SetColumnValue("KnowledgeBaseName", value);
				if (_knowledgeBase != null) {
					_knowledgeBase.Name = value;
				}
			}
		}

		private KnowledgeBase _knowledgeBase;
		/// <summary>
		/// Knowledge base ID.
		/// </summary>
		public KnowledgeBase KnowledgeBase {
			get {
				return _knowledgeBase ??
					(_knowledgeBase = LookupColumnEntities.GetEntity("KnowledgeBase") as KnowledgeBase);
			}
		}

		/// <exclude/>
		public Guid PlaybookId {
			get {
				return GetTypedColumnValue<Guid>("PlaybookId");
			}
			set {
				SetColumnValue("PlaybookId", value);
				_playbook = null;
			}
		}

		/// <exclude/>
		public string PlaybookName {
			get {
				return GetTypedColumnValue<string>("PlaybookName");
			}
			set {
				SetColumnValue("PlaybookName", value);
				if (_playbook != null) {
					_playbook.Name = value;
				}
			}
		}

		private CrtPlaybook _playbook;
		/// <summary>
		/// Playbook ID.
		/// </summary>
		public CrtPlaybook Playbook {
			get {
				return _playbook ??
					(_playbook = LookupColumnEntities.GetEntity("Playbook") as CrtPlaybook);
			}
		}

		/// <summary>
		/// Dcm stage value.
		/// </summary>
		public Guid DcmStageValue {
			get {
				return GetTypedColumnValue<Guid>("DcmStageValue");
			}
			set {
				SetColumnValue("DcmStageValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PlaybookStage_CrtPlaybookEventsProcess(UserConnection);
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
			return new PlaybookStage(this);
		}

		#endregion

	}

	#endregion

	#region Class: PlaybookStage_CrtPlaybookEventsProcess

	/// <exclude/>
	public partial class PlaybookStage_CrtPlaybookEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : PlaybookStage
	{

		public PlaybookStage_CrtPlaybookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PlaybookStage_CrtPlaybookEventsProcess";
			SchemaUId = new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("240d99cd-6e16-4d68-9674-0d3e1c72a7fd");
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

	#region Class: PlaybookStage_CrtPlaybookEventsProcess

	/// <exclude/>
	public class PlaybookStage_CrtPlaybookEventsProcess : PlaybookStage_CrtPlaybookEventsProcess<PlaybookStage>
	{

		public PlaybookStage_CrtPlaybookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PlaybookStage_CrtPlaybookEventsProcess

	public partial class PlaybookStage_CrtPlaybookEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PlaybookStageEventsProcess

	/// <exclude/>
	public class PlaybookStageEventsProcess : PlaybookStage_CrtPlaybookEventsProcess
	{

		public PlaybookStageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

