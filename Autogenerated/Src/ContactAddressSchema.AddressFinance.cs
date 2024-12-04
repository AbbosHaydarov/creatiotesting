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

	#region Class: ContactAddressSchema

	/// <exclude/>
	public class ContactAddressSchema : Terrasoft.Configuration.ContactAddress_CrtBaseFinserv_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactAddressSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactAddressSchema(ContactAddressSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactAddressSchema(ContactAddressSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("01138341-a2e7-4cae-b7d3-f2f60391a929");
			Name = "ContactAddress";
			ParentSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9a909c9d-955a-4e10-b52b-fe1cb989996b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new ContactAddress(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactAddress_AddressFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactAddressSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactAddressSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01138341-a2e7-4cae-b7d3-f2f60391a929"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress

	/// <summary>
	/// Contact address.
	/// </summary>
	public class ContactAddress : Terrasoft.Configuration.ContactAddress_CrtBaseFinserv_Terrasoft
	{

		#region Constructors: Public

		public ContactAddress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactAddress";
		}

		public ContactAddress(ContactAddress source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactAddress_AddressFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactAddressDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactAddressDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactAddressInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactAddressInserting", e);
			Saved += (s, e) => ThrowEvent("ContactAddressSaved", e);
			Saving += (s, e) => ThrowEvent("ContactAddressSaving", e);
			Validating += (s, e) => ThrowEvent("ContactAddressValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactAddress(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_AddressFinanceEventsProcess

	/// <exclude/>
	public partial class ContactAddress_AddressFinanceEventsProcess<TEntity> : Terrasoft.Configuration.ContactAddress_CrtBaseFinservEventsProcess<TEntity> where TEntity : ContactAddress
	{

		public ContactAddress_AddressFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactAddress_AddressFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("01138341-a2e7-4cae-b7d3-f2f60391a929");
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

	#region Class: ContactAddress_AddressFinanceEventsProcess

	/// <exclude/>
	public class ContactAddress_AddressFinanceEventsProcess : ContactAddress_AddressFinanceEventsProcess<ContactAddress>
	{

		public ContactAddress_AddressFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: ContactAddressEventsProcess

	/// <exclude/>
	public class ContactAddressEventsProcess : ContactAddress_AddressFinanceEventsProcess
	{

		public ContactAddressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

