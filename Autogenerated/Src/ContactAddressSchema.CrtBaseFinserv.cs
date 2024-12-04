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

	#region Class: ContactAddress_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class ContactAddress_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.ContactAddress_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactAddress_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactAddress_CrtBaseFinserv_TerrasoftSchema(ContactAddress_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactAddress_CrtBaseFinserv_TerrasoftSchema(ContactAddress_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("85b4914c-5e56-4a7c-be42-21c9ee8cf789");
			Name = "ContactAddress_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c306f334-b3c9-4e98-9644-0ec16cd9a358");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText");
			column.ModifiedInSchemaUId = new Guid("85b4914c-5e56-4a7c-be42-21c9ee8cf789");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactAddress_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactAddress_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactAddress_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactAddress_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85b4914c-5e56-4a7c-be42-21c9ee8cf789"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Contact address.
	/// </summary>
	public class ContactAddress_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.ContactAddress_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public ContactAddress_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactAddress_CrtBaseFinserv_Terrasoft";
		}

		public ContactAddress_CrtBaseFinserv_Terrasoft(ContactAddress_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactAddress_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("ContactAddress_CrtBaseFinserv_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactAddress_CrtBaseFinserv_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactAddress_CrtBaseFinserv_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactAddress_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactAddress_CrtBaseFinserv_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ContactAddress_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactAddress_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactAddress_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactAddress_CrtCustomer360AppEventsProcess<TEntity> where TEntity : ContactAddress_CrtBaseFinserv_Terrasoft
	{

		public ContactAddress_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactAddress_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("85b4914c-5e56-4a7c-be42-21c9ee8cf789");
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

	#region Class: ContactAddress_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactAddress_CrtBaseFinservEventsProcess : ContactAddress_CrtBaseFinservEventsProcess<ContactAddress_CrtBaseFinserv_Terrasoft>
	{

		public ContactAddress_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

