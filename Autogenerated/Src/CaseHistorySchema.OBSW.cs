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

	#region Class: CaseHistorySchema

	/// <exclude/>
	public class CaseHistorySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CaseHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseHistorySchema(CaseHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseHistorySchema(CaseHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1");
			RealUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1");
			Name = "CaseHistory";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("61148459-8f28-4d90-9fb2-a3ac47c4e0aa")) == null) {
				Columns.Add(CreateCaseColumn());
			}
			if (Columns.FindByUId(new Guid("0b76b194-904a-4bf7-ab72-7db8e1b7aed1")) == null) {
				Columns.Add(CreateCaseStatusColumn());
			}
			if (Columns.FindByUId(new Guid("55045030-0143-4aaa-9fa2-832976861e51")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("3233b6bd-fbfc-4335-9194-fba48b7489db")) == null) {
				Columns.Add(CreateChangesDateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("61148459-8f28-4d90-9fb2-a3ac47c4e0aa"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				ModifiedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef")
			};
		}

		protected virtual EntitySchemaColumn CreateCaseStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0b76b194-904a-4bf7-ab72-7db8e1b7aed1"),
				Name = @"CaseStatus",
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				ModifiedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("55045030-0143-4aaa-9fa2-832976861e51"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				ModifiedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef")
			};
		}

		protected virtual EntitySchemaColumn CreateChangesDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("3233b6bd-fbfc-4335-9194-fba48b7489db"),
				Name = @"ChangesDate",
				CreatedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				ModifiedInSchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"),
				CreatedInPackageId = new Guid("97c75f49-0b42-4849-aaee-01d6ae9ee3ef"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
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
			return new CaseHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CaseHistory_OBSWEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CaseHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseHistory

	/// <summary>
	/// Case history.
	/// </summary>
	public class CaseHistory : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CaseHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseHistory";
		}

		public CaseHistory(CaseHistory source)
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
		public Guid CaseStatusId {
			get {
				return GetTypedColumnValue<Guid>("CaseStatusId");
			}
			set {
				SetColumnValue("CaseStatusId", value);
				_caseStatus = null;
			}
		}

		/// <exclude/>
		public string CaseStatusName {
			get {
				return GetTypedColumnValue<string>("CaseStatusName");
			}
			set {
				SetColumnValue("CaseStatusName", value);
				if (_caseStatus != null) {
					_caseStatus.Name = value;
				}
			}
		}

		private CaseStatus _caseStatus;
		/// <summary>
		/// Case status.
		/// </summary>
		public CaseStatus CaseStatus {
			get {
				return _caseStatus ??
					(_caseStatus = LookupColumnEntities.GetEntity("CaseStatus") as CaseStatus);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ChangesDate {
			get {
				return GetTypedColumnValue<DateTime>("ChangesDate");
			}
			set {
				SetColumnValue("ChangesDate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseHistory_OBSWEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CaseHistoryDeleted", e);
			Validating += (s, e) => ThrowEvent("CaseHistoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseHistory_OBSWEventsProcess

	/// <exclude/>
	public partial class CaseHistory_OBSWEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CaseHistory
	{

		public CaseHistory_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseHistory_OBSWEventsProcess";
			SchemaUId = new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("15bc81b7-2038-4d83-a399-5445a1c084d1");
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

	#region Class: CaseHistory_OBSWEventsProcess

	/// <exclude/>
	public class CaseHistory_OBSWEventsProcess : CaseHistory_OBSWEventsProcess<CaseHistory>
	{

		public CaseHistory_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseHistory_OBSWEventsProcess

	public partial class CaseHistory_OBSWEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CaseHistoryEventsProcess

	/// <exclude/>
	public class CaseHistoryEventsProcess : CaseHistory_OBSWEventsProcess
	{

		public CaseHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

