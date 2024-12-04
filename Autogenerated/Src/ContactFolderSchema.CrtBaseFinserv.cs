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

	#region Class: ContactFolder_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class ContactFolder_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.ContactFolder_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactFolder_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactFolder_CrtBaseFinserv_TerrasoftSchema(ContactFolder_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactFolder_CrtBaseFinserv_TerrasoftSchema(ContactFolder_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("73127275-152c-43b8-b054-2bff5f01f3f0");
			Name = "ContactFolder_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
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
			column.ModifiedInSchemaUId = new Guid("73127275-152c-43b8-b054-2bff5f01f3f0");
			column.CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("73127275-152c-43b8-b054-2bff5f01f3f0");
			column.CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactFolder_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactFolder_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactFolder_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactFolder_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("73127275-152c-43b8-b054-2bff5f01f3f0"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactFolder_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Contact folder.
	/// </summary>
	public class ContactFolder_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.ContactFolder_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactFolder_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactFolder_CrtBaseFinserv_Terrasoft";
		}

		public ContactFolder_CrtBaseFinserv_Terrasoft(ContactFolder_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactFolder_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactFolder_CrtBaseFinserv_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("ContactFolder_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactFolder_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactFolder_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactFolder_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactFolder_CrtBaseEventsProcess<TEntity> where TEntity : ContactFolder_CrtBaseFinserv_Terrasoft
	{

		public ContactFolder_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactFolder_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("73127275-152c-43b8-b054-2bff5f01f3f0");
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

	#region Class: ContactFolder_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactFolder_CrtBaseFinservEventsProcess : ContactFolder_CrtBaseFinservEventsProcess<ContactFolder_CrtBaseFinserv_Terrasoft>
	{

		public ContactFolder_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactFolder_CrtBaseFinservEventsProcess

	public partial class ContactFolder_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

