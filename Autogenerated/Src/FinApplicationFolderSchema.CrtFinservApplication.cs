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

	#region Class: FinApplicationFolder_CrtFinservApplication_TerrasoftSchema

	/// <exclude/>
	public class FinApplicationFolder_CrtFinservApplication_TerrasoftSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public FinApplicationFolder_CrtFinservApplication_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationFolder_CrtFinservApplication_TerrasoftSchema(FinApplicationFolder_CrtFinservApplication_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationFolder_CrtFinservApplication_TerrasoftSchema(FinApplicationFolder_CrtFinservApplication_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			RealUId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			Name = "FinApplicationFolder_CrtFinservApplication_Terrasoft";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplicationFolder_CrtFinservApplication_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplicationFolder_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationFolder_CrtFinservApplication_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationFolder_CrtFinservApplication_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationFolder_CrtFinservApplication_Terrasoft

	/// <summary>
	/// "Application" section folder.
	/// </summary>
	public class FinApplicationFolder_CrtFinservApplication_Terrasoft : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public FinApplicationFolder_CrtFinservApplication_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationFolder_CrtFinservApplication_Terrasoft";
		}

		public FinApplicationFolder_CrtFinservApplication_Terrasoft(FinApplicationFolder_CrtFinservApplication_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		private FinApplicationFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public FinApplicationFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as FinApplicationFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplicationFolder_CrtFinservApplicationEventsProcess(UserConnection);
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
			return new FinApplicationFolder_CrtFinservApplication_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationFolder_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplicationFolder_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinApplicationFolder_CrtFinservApplication_Terrasoft
	{

		public FinApplicationFolder_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplicationFolder_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
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

	#region Class: FinApplicationFolder_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationFolder_CrtFinservApplicationEventsProcess : FinApplicationFolder_CrtFinservApplicationEventsProcess<FinApplicationFolder_CrtFinservApplication_Terrasoft>
	{

		public FinApplicationFolder_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

