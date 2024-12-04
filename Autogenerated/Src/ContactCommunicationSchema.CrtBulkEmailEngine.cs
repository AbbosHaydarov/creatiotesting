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

	#region Class: ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema

	/// <exclude/>
	public class ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema : Terrasoft.Configuration.ContactCommunication_CrtBaseFinserv_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema(ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema(ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("da72c078-5037-447d-9259-0a40ef20bd68");
			Name = "ContactCommunication_CrtBulkEmailEngine_Terrasoft";
			ParentSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1f5a6178-e602-42c0-b4d9-e7d8824941b4");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new ContactCommunication_CrtBulkEmailEngine_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactCommunication_CrtBulkEmailEngineEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactCommunication_CrtBulkEmailEngine_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da72c078-5037-447d-9259-0a40ef20bd68"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_CrtBulkEmailEngine_Terrasoft

	/// <summary>
	/// Contact communication option.
	/// </summary>
	public class ContactCommunication_CrtBulkEmailEngine_Terrasoft : Terrasoft.Configuration.ContactCommunication_CrtBaseFinserv_Terrasoft
	{

		#region Constructors: Public

		public ContactCommunication_CrtBulkEmailEngine_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactCommunication_CrtBulkEmailEngine_Terrasoft";
		}

		public ContactCommunication_CrtBulkEmailEngine_Terrasoft(ContactCommunication_CrtBulkEmailEngine_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactCommunication_CrtBulkEmailEngineEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactCommunication_CrtBulkEmailEngine_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("ContactCommunication_CrtBulkEmailEngine_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactCommunication_CrtBulkEmailEngine_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactCommunication_CrtBulkEmailEngine_TerrasoftSaving", e);
			Updating += (s, e) => ThrowEvent("ContactCommunication_CrtBulkEmailEngine_TerrasoftUpdating", e);
			Validating += (s, e) => ThrowEvent("ContactCommunication_CrtBulkEmailEngine_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCommunication_CrtBulkEmailEngine_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_CrtBulkEmailEngineEventsProcess

	/// <exclude/>
	public partial class ContactCommunication_CrtBulkEmailEngineEventsProcess<TEntity> : Terrasoft.Configuration.ContactCommunication_CrtBaseFinservEventsProcess<TEntity> where TEntity : ContactCommunication_CrtBulkEmailEngine_Terrasoft
	{

		public ContactCommunication_CrtBulkEmailEngineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactCommunication_CrtBulkEmailEngineEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("da72c078-5037-447d-9259-0a40ef20bd68");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid OldCommunicationTypeId {
			get;
			set;
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

	#region Class: ContactCommunication_CrtBulkEmailEngineEventsProcess

	/// <exclude/>
	public class ContactCommunication_CrtBulkEmailEngineEventsProcess : ContactCommunication_CrtBulkEmailEngineEventsProcess<ContactCommunication_CrtBulkEmailEngine_Terrasoft>
	{

		public ContactCommunication_CrtBulkEmailEngineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

