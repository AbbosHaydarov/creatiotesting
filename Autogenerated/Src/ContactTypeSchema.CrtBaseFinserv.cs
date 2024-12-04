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

	#region Class: ContactTypeSchema

	/// <exclude/>
	public class ContactTypeSchema : Terrasoft.Configuration.ContactType_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactTypeSchema(ContactTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactTypeSchema(ContactTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("cb346a07-3934-46a9-83f6-097e1d5e8727");
			Name = "ContactType";
			ParentSchemaUId = new Guid("0b5ff414-e00a-4115-af0c-fe872e826f07");
			ExtendParent = true;
			CreatedInPackageId = new Guid("27329051-b308-4a64-83ef-1a0f05a9ca5f");
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
			return new ContactType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb346a07-3934-46a9-83f6-097e1d5e8727"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactType

	/// <summary>
	/// Contact type.
	/// </summary>
	public class ContactType : Terrasoft.Configuration.ContactType_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public ContactType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactType";
		}

		public ContactType(ContactType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactTypeInserting", e);
			Saved += (s, e) => ThrowEvent("ContactTypeSaved", e);
			Saving += (s, e) => ThrowEvent("ContactTypeSaving", e);
			Validating += (s, e) => ThrowEvent("ContactTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactType_CrtCustomer360AppEventsProcess<TEntity> where TEntity : ContactType
	{

		public ContactType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactType_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cb346a07-3934-46a9-83f6-097e1d5e8727");
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

	#region Class: ContactType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactType_CrtBaseFinservEventsProcess : ContactType_CrtBaseFinservEventsProcess<ContactType>
	{

		public ContactType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactType_CrtBaseFinservEventsProcess

	public partial class ContactType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContactTypeEventsProcess

	/// <exclude/>
	public class ContactTypeEventsProcess : ContactType_CrtBaseFinservEventsProcess
	{

		public ContactTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

