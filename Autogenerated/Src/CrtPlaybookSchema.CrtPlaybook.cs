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

	#region Class: CrtPlaybookSchema

	/// <exclude/>
	public class CrtPlaybookSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CrtPlaybookSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CrtPlaybookSchema(CrtPlaybookSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CrtPlaybookSchema(CrtPlaybookSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26");
			RealUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26");
			Name = "CrtPlaybook";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateCreatedByColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e474f3d9-06ef-0580-b3bc-9d960f487560")) == null) {
				Columns.Add(CreateObjectColumn());
			}
			if (Columns.FindByUId(new Guid("8d1cce42-f5cb-69d7-a336-c972a2b13aac")) == null) {
				Columns.Add(CreateDcmCaseColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3c72ebb1-712a-7cec-e768-c19597d33a3e"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"),
				ModifiedInSchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"),
				CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f")
			};
		}

		protected virtual EntitySchemaColumn CreateObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e474f3d9-06ef-0580-b3bc-9d960f487560"),
				Name = @"Object",
				ReferenceSchemaUId = new Guid("14bc3643-5f20-4ff9-b8ba-c1333fe81935"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"),
				ModifiedInSchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"),
				CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDcmCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8d1cce42-f5cb-69d7-a336-c972a2b13aac"),
				Name = @"DcmCase",
				ReferenceSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"),
				ModifiedInSchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"),
				CreatedInPackageId = new Guid("d2d9085d-750f-4eec-8e9a-908f45ce129f"),
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
			return new CrtPlaybook(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CrtPlaybook_CrtPlaybookEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CrtPlaybookSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CrtPlaybookSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26"));
		}

		#endregion

	}

	#endregion

	#region Class: CrtPlaybook

	/// <summary>
	/// Playbook (Crt).
	/// </summary>
	public class CrtPlaybook : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CrtPlaybook(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CrtPlaybook";
		}

		public CrtPlaybook(CrtPlaybook source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <exclude/>
		public Guid ObjectId {
			get {
				return GetTypedColumnValue<Guid>("ObjectId");
			}
			set {
				SetColumnValue("ObjectId", value);
				_object = null;
			}
		}

		/// <exclude/>
		public string ObjectCaption {
			get {
				return GetTypedColumnValue<string>("ObjectCaption");
			}
			set {
				SetColumnValue("ObjectCaption", value);
				if (_object != null) {
					_object.Caption = value;
				}
			}
		}

		private VwDcmStagedObject _object;
		/// <summary>
		/// Object.
		/// </summary>
		public VwDcmStagedObject Object {
			get {
				return _object ??
					(_object = LookupColumnEntities.GetEntity("Object") as VwDcmStagedObject);
			}
		}

		/// <exclude/>
		public Guid DcmCaseId {
			get {
				return GetTypedColumnValue<Guid>("DcmCaseId");
			}
			set {
				SetColumnValue("DcmCaseId", value);
				_dcmCase = null;
			}
		}

		/// <exclude/>
		public string DcmCaseCaption {
			get {
				return GetTypedColumnValue<string>("DcmCaseCaption");
			}
			set {
				SetColumnValue("DcmCaseCaption", value);
				if (_dcmCase != null) {
					_dcmCase.Caption = value;
				}
			}
		}

		private VwSysDcmLib _dcmCase;
		/// <summary>
		/// Dynamic case.
		/// </summary>
		public VwSysDcmLib DcmCase {
			get {
				return _dcmCase ??
					(_dcmCase = LookupColumnEntities.GetEntity("DcmCase") as VwSysDcmLib);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CrtPlaybook_CrtPlaybookEventsProcess(UserConnection);
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
			return new CrtPlaybook(this);
		}

		#endregion

	}

	#endregion

	#region Class: CrtPlaybook_CrtPlaybookEventsProcess

	/// <exclude/>
	public partial class CrtPlaybook_CrtPlaybookEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CrtPlaybook
	{

		public CrtPlaybook_CrtPlaybookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CrtPlaybook_CrtPlaybookEventsProcess";
			SchemaUId = new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0edefc78-87af-4c32-8fe6-2cb5730baa26");
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

	#region Class: CrtPlaybook_CrtPlaybookEventsProcess

	/// <exclude/>
	public class CrtPlaybook_CrtPlaybookEventsProcess : CrtPlaybook_CrtPlaybookEventsProcess<CrtPlaybook>
	{

		public CrtPlaybook_CrtPlaybookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CrtPlaybook_CrtPlaybookEventsProcess

	public partial class CrtPlaybook_CrtPlaybookEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CrtPlaybookEventsProcess

	/// <exclude/>
	public class CrtPlaybookEventsProcess : CrtPlaybook_CrtPlaybookEventsProcess
	{

		public CrtPlaybookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

