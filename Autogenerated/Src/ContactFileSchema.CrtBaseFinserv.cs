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
	using Terrasoft.Configuration;
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

	#region Class: ContactFileSchema

	/// <exclude/>
	public class ContactFileSchema : Terrasoft.Configuration.ContactFile_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactFileSchema(ContactFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactFileSchema(ContactFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("33eb5812-7931-4702-8a3b-1520407706ea");
			Name = "ContactFile";
			ParentSchemaUId = new Guid("e9eafee9-c4e4-4793-ad0a-003bd2c6a9b4");
			ExtendParent = true;
			CreatedInPackageId = new Guid("84dd6f82-37fc-40d2-a0db-12a091512ff5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactFile_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33eb5812-7931-4702-8a3b-1520407706ea"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactFile

	/// <summary>
	/// Contact attachment.
	/// </summary>
	public class ContactFile : Terrasoft.Configuration.ContactFile_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactFile";
		}

		public ContactFile(ContactFile source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactFile_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactFileDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactFileDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactFileInserted", e);
			Saved += (s, e) => ThrowEvent("ContactFileSaved", e);
			Saving += (s, e) => ThrowEvent("ContactFileSaving", e);
			Updated += (s, e) => ThrowEvent("ContactFileUpdated", e);
			Validating += (s, e) => ThrowEvent("ContactFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactFile_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactFile_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactFile_CrtBaseEventsProcess<TEntity> where TEntity : ContactFile
	{

		public ContactFile_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactFile_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("33eb5812-7931-4702-8a3b-1520407706ea");
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

	#region Class: ContactFile_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactFile_CrtBaseFinservEventsProcess : ContactFile_CrtBaseFinservEventsProcess<ContactFile>
	{

		public ContactFile_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactFile_CrtBaseFinservEventsProcess

	public partial class ContactFile_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContactFileEventsProcess

	/// <exclude/>
	public class ContactFileEventsProcess : ContactFile_CrtBaseFinservEventsProcess
	{

		public ContactFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

