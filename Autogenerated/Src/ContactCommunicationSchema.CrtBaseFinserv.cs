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

	#region Class: ContactCommunication_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class ContactCommunication_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.ContactCommunication_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactCommunication_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactCommunication_CrtBaseFinserv_TerrasoftSchema(ContactCommunication_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactCommunication_CrtBaseFinserv_TerrasoftSchema(ContactCommunication_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("36d2d170-1f04-4227-a228-2cd6de3ffa8b");
			Name = "ContactCommunication_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
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
			return new ContactCommunication_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactCommunication_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactCommunication_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactCommunication_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36d2d170-1f04-4227-a228-2cd6de3ffa8b"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Contact communication option.
	/// </summary>
	public class ContactCommunication_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.ContactCommunication_SSP_Terrasoft
	{

		#region Constructors: Public

		public ContactCommunication_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactCommunication_CrtBaseFinserv_Terrasoft";
		}

		public ContactCommunication_CrtBaseFinserv_Terrasoft(ContactCommunication_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactCommunication_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftSaving", e);
			Updating += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftUpdating", e);
			Validating += (s, e) => ThrowEvent("ContactCommunication_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCommunication_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactCommunication_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactCommunication_SSPEventsProcess<TEntity> where TEntity : ContactCommunication_CrtBaseFinserv_Terrasoft
	{

		public ContactCommunication_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactCommunication_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("36d2d170-1f04-4227-a228-2cd6de3ffa8b");
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

	#region Class: ContactCommunication_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactCommunication_CrtBaseFinservEventsProcess : ContactCommunication_CrtBaseFinservEventsProcess<ContactCommunication_CrtBaseFinserv_Terrasoft>
	{

		public ContactCommunication_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactCommunication_CrtBaseFinservEventsProcess

	public partial class ContactCommunication_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

