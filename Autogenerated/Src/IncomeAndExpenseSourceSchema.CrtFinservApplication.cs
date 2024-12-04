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

	#region Class: IncomeAndExpenseSourceSchema

	/// <exclude/>
	public class IncomeAndExpenseSourceSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public IncomeAndExpenseSourceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public IncomeAndExpenseSourceSchema(IncomeAndExpenseSourceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public IncomeAndExpenseSourceSchema(IncomeAndExpenseSourceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf");
			RealUId = new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf");
			Name = "IncomeAndExpenseSource";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
			if (Columns.FindByUId(new Guid("d0d3fe56-8e3f-45b6-8ba8-c770dcf12b90")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d0d3fe56-8e3f-45b6-8ba8-c770dcf12b90"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("874540b6-a106-4531-98b5-d1326aefe5d6"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf"),
				ModifiedInSchemaUId = new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
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
			return new IncomeAndExpenseSource(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new IncomeAndExpenseSource_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new IncomeAndExpenseSourceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new IncomeAndExpenseSourceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf"));
		}

		#endregion

	}

	#endregion

	#region Class: IncomeAndExpenseSource

	/// <summary>
	/// Income and expenses source.
	/// </summary>
	public class IncomeAndExpenseSource : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public IncomeAndExpenseSource(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "IncomeAndExpenseSource";
		}

		public IncomeAndExpenseSource(IncomeAndExpenseSource source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		private IncomeOrExpenseType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public IncomeOrExpenseType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as IncomeOrExpenseType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new IncomeAndExpenseSource_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("IncomeAndExpenseSourceDeleted", e);
			Validating += (s, e) => ThrowEvent("IncomeAndExpenseSourceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IncomeAndExpenseSource(this);
		}

		#endregion

	}

	#endregion

	#region Class: IncomeAndExpenseSource_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class IncomeAndExpenseSource_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : IncomeAndExpenseSource
	{

		public IncomeAndExpenseSource_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IncomeAndExpenseSource_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("55a25460-ea90-4976-82b0-35c5a8de8ecf");
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

	#region Class: IncomeAndExpenseSource_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class IncomeAndExpenseSource_CrtFinservApplicationEventsProcess : IncomeAndExpenseSource_CrtFinservApplicationEventsProcess<IncomeAndExpenseSource>
	{

		public IncomeAndExpenseSource_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IncomeAndExpenseSource_CrtFinservApplicationEventsProcess

	public partial class IncomeAndExpenseSource_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: IncomeAndExpenseSourceEventsProcess

	/// <exclude/>
	public class IncomeAndExpenseSourceEventsProcess : IncomeAndExpenseSource_CrtFinservApplicationEventsProcess
	{

		public IncomeAndExpenseSourceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

