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

	#region Class: FinApplicationInFolderSchema

	/// <exclude/>
	public class FinApplicationInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public FinApplicationInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationInFolderSchema(FinApplicationInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationInFolderSchema(FinApplicationInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4");
			RealUId = new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4");
			Name = "FinApplicationInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
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
			if (Columns.FindByUId(new Guid("cb7a03ed-947d-4ce7-9c57-0ebc356a02b6")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("c7252e4d-e67d-4bc2-aa90-2ca6bc58eb78");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cb7a03ed-947d-4ce7-9c57-0ebc356a02b6"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4"),
				ModifiedInSchemaUId = new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplicationInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplicationInFolder_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationInFolder

	/// <summary>
	/// "Application" in folder object.
	/// </summary>
	public class FinApplicationInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public FinApplicationInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationInFolder";
		}

		public FinApplicationInFolder(FinApplicationInFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid FinApplicationId {
			get {
				return GetTypedColumnValue<Guid>("FinApplicationId");
			}
			set {
				SetColumnValue("FinApplicationId", value);
				_finApplication = null;
			}
		}

		/// <exclude/>
		public string FinApplicationNumber {
			get {
				return GetTypedColumnValue<string>("FinApplicationNumber");
			}
			set {
				SetColumnValue("FinApplicationNumber", value);
				if (_finApplication != null) {
					_finApplication.Number = value;
				}
			}
		}

		private FinApplication _finApplication;
		/// <summary>
		/// Application.
		/// </summary>
		public FinApplication FinApplication {
			get {
				return _finApplication ??
					(_finApplication = LookupColumnEntities.GetEntity("FinApplication") as FinApplication);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplicationInFolder_CrtFinservApplicationEventsProcess(UserConnection);
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
			return new FinApplicationInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationInFolder_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplicationInFolder_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinApplicationInFolder
	{

		public FinApplicationInFolder_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplicationInFolder_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2c5e67ca-256a-4f34-9e29-aa5b5493baf4");
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

	#region Class: FinApplicationInFolder_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationInFolder_CrtFinservApplicationEventsProcess : FinApplicationInFolder_CrtFinservApplicationEventsProcess<FinApplicationInFolder>
	{

		public FinApplicationInFolder_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplicationInFolder_CrtFinservApplicationEventsProcess

	public partial class FinApplicationInFolder_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinApplicationInFolderEventsProcess

	/// <exclude/>
	public class FinApplicationInFolderEventsProcess : FinApplicationInFolder_CrtFinservApplicationEventsProcess
	{

		public FinApplicationInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

