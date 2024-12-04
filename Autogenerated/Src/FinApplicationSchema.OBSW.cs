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

	#region Class: FinApplication_OBSW_TerrasoftSchema

	/// <exclude/>
	public class FinApplication_OBSW_TerrasoftSchema : Terrasoft.Configuration.FinApplication_FinAppLending_TerrasoftSchema
	{

		#region Constructors: Public

		public FinApplication_OBSW_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplication_OBSW_TerrasoftSchema(FinApplication_OBSW_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplication_OBSW_TerrasoftSchema(FinApplication_OBSW_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b5d4a41b-d8dc-4c64-ab83-125fbb5262df");
			Name = "FinApplication_OBSW_Terrasoft";
			ParentSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("14cf1f86-adf3-4718-ad95-7e0b957126a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c56b7fda-2a23-481f-adc9-e2689192d384")) == null) {
				Columns.Add(CreateCaseColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c56b7fda-2a23-481f-adc9-e2689192d384"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b5d4a41b-d8dc-4c64-ab83-125fbb5262df"),
				ModifiedInSchemaUId = new Guid("b5d4a41b-d8dc-4c64-ab83-125fbb5262df"),
				CreatedInPackageId = new Guid("14cf1f86-adf3-4718-ad95-7e0b957126a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplication_OBSW_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplication_OBSWEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplication_OBSW_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplication_OBSW_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5d4a41b-d8dc-4c64-ab83-125fbb5262df"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_OBSW_Terrasoft

	/// <summary>
	/// Application.
	/// </summary>
	public class FinApplication_OBSW_Terrasoft : Terrasoft.Configuration.FinApplication_FinAppLending_Terrasoft
	{

		#region Constructors: Public

		public FinApplication_OBSW_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplication_OBSW_Terrasoft";
		}

		public FinApplication_OBSW_Terrasoft(FinApplication_OBSW_Terrasoft source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplication_OBSWEventsProcess(UserConnection);
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
			return new FinApplication_OBSW_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_OBSWEventsProcess

	/// <exclude/>
	public partial class FinApplication_OBSWEventsProcess<TEntity> : Terrasoft.Configuration.FinApplication_FinAppLendingEventsProcess<TEntity> where TEntity : FinApplication_OBSW_Terrasoft
	{

		public FinApplication_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplication_OBSWEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b5d4a41b-d8dc-4c64-ab83-125fbb5262df");
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

	#region Class: FinApplication_OBSWEventsProcess

	/// <exclude/>
	public class FinApplication_OBSWEventsProcess : FinApplication_OBSWEventsProcess<FinApplication_OBSW_Terrasoft>
	{

		public FinApplication_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplication_OBSWEventsProcess

	public partial class FinApplication_OBSWEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

