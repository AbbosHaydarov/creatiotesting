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

	#region Class: ConsultationThemeSchema

	/// <exclude/>
	public class ConsultationThemeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ConsultationThemeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ConsultationThemeSchema(ConsultationThemeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ConsultationThemeSchema(ConsultationThemeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893");
			RealUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893");
			Name = "ConsultationTheme";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("460c7e45-23cf-458d-bc6d-3fbb35bcfe62")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("63d61196-c5bf-4236-a796-8e50f666dd8a")) == null) {
				Columns.Add(CreateBlockColumn());
			}
			if (Columns.FindByUId(new Guid("ecc0d733-b98d-472c-8e23-a20a5d2a5afd")) == null) {
				Columns.Add(CreateParentColumn());
			}
			if (Columns.FindByUId(new Guid("7fde7df0-9d6f-4cb3-a5d2-aad3bbf21c27")) == null) {
				Columns.Add(CreateProcessSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("76ec9f25-6179-49f2-a60d-cf6418fa407f")) == null) {
				Columns.Add(CreateIsFolderColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsValueCloneable = false;
			column.ModifiedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("460c7e45-23cf-458d-bc6d-3fbb35bcfe62"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				ModifiedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da")
			};
		}

		protected virtual EntitySchemaColumn CreateBlockColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("63d61196-c5bf-4236-a796-8e50f666dd8a"),
				Name = @"Block",
				ReferenceSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				ModifiedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ecc0d733-b98d-472c-8e23-a20a5d2a5afd"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				ModifiedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7fde7df0-9d6f-4cb3-a5d2-aad3bbf21c27"),
				Name = @"ProcessSchema",
				ReferenceSchemaUId = new Guid("842e74a2-e737-476c-b3d0-8aa3d5ddd229"),
				IsValueCloneable = false,
				IsIndexed = true,
				IsWeakReference = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				ModifiedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da")
			};
		}

		protected virtual EntitySchemaColumn CreateIsFolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("76ec9f25-6179-49f2-a60d-cf6418fa407f"),
				Name = @"IsFolder",
				CreatedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				ModifiedInSchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ConsultationTheme(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ConsultationTheme_OBSWEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ConsultationThemeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ConsultationThemeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893"));
		}

		#endregion

	}

	#endregion

	#region Class: ConsultationTheme

	/// <summary>
	/// Consultation theme.
	/// </summary>
	public class ConsultationTheme : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ConsultationTheme(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ConsultationTheme";
		}

		public ConsultationTheme(ConsultationTheme source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <exclude/>
		public Guid BlockId {
			get {
				return GetTypedColumnValue<Guid>("BlockId");
			}
			set {
				SetColumnValue("BlockId", value);
				_block = null;
			}
		}

		/// <exclude/>
		public string BlockName {
			get {
				return GetTypedColumnValue<string>("BlockName");
			}
			set {
				SetColumnValue("BlockName", value);
				if (_block != null) {
					_block.Name = value;
				}
			}
		}

		private ConsultationThemeBlock _block;
		/// <summary>
		/// Consultation theme block.
		/// </summary>
		public ConsultationThemeBlock Block {
			get {
				return _block ??
					(_block = LookupColumnEntities.GetEntity("Block") as ConsultationThemeBlock);
			}
		}

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private ConsultationTheme _parent;
		/// <summary>
		/// Theme group.
		/// </summary>
		public ConsultationTheme Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as ConsultationTheme);
			}
		}

		/// <exclude/>
		public Guid ProcessSchemaId {
			get {
				return GetTypedColumnValue<Guid>("ProcessSchemaId");
			}
			set {
				SetColumnValue("ProcessSchemaId", value);
				_processSchema = null;
			}
		}

		/// <exclude/>
		public string ProcessSchemaCaption {
			get {
				return GetTypedColumnValue<string>("ProcessSchemaCaption");
			}
			set {
				SetColumnValue("ProcessSchemaCaption", value);
				if (_processSchema != null) {
					_processSchema.Caption = value;
				}
			}
		}

		private VwSysProcess _processSchema;
		/// <summary>
		/// Process.
		/// </summary>
		public VwSysProcess ProcessSchema {
			get {
				return _processSchema ??
					(_processSchema = LookupColumnEntities.GetEntity("ProcessSchema") as VwSysProcess);
			}
		}

		/// <summary>
		/// Group.
		/// </summary>
		public bool IsFolder {
			get {
				return GetTypedColumnValue<bool>("IsFolder");
			}
			set {
				SetColumnValue("IsFolder", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ConsultationTheme_OBSWEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ConsultationThemeDeleted", e);
			Validating += (s, e) => ThrowEvent("ConsultationThemeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConsultationTheme(this);
		}

		#endregion

	}

	#endregion

	#region Class: ConsultationTheme_OBSWEventsProcess

	/// <exclude/>
	public partial class ConsultationTheme_OBSWEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ConsultationTheme
	{

		public ConsultationTheme_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConsultationTheme_OBSWEventsProcess";
			SchemaUId = new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3b255678-b38b-4c19-a1f9-cd6289f52893");
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

	#region Class: ConsultationTheme_OBSWEventsProcess

	/// <exclude/>
	public class ConsultationTheme_OBSWEventsProcess : ConsultationTheme_OBSWEventsProcess<ConsultationTheme>
	{

		public ConsultationTheme_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConsultationTheme_OBSWEventsProcess

	public partial class ConsultationTheme_OBSWEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ConsultationThemeEventsProcess

	/// <exclude/>
	public class ConsultationThemeEventsProcess : ConsultationTheme_OBSWEventsProcess
	{

		public ConsultationThemeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

