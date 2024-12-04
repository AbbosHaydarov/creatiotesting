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

	#region Class: ContactsProductInterestSchema

	/// <exclude/>
	public class ContactsProductInterestSchema : Terrasoft.Configuration.ContactsProductInterest_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactsProductInterestSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactsProductInterestSchema(ContactsProductInterestSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactsProductInterestSchema(ContactsProductInterestSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2237e267-e05a-4751-a330-bb8a5e750115");
			Name = "ContactsProductInterest";
			ParentSchemaUId = new Guid("d8381a92-7870-47b5-8e5b-73f3f571fe57");
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
			return new ContactsProductInterest(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactsProductInterest_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactsProductInterestSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactsProductInterestSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2237e267-e05a-4751-a330-bb8a5e750115"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactsProductInterest

	/// <summary>
	/// Contact interest to products.
	/// </summary>
	public class ContactsProductInterest : Terrasoft.Configuration.ContactsProductInterest_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactsProductInterest(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactsProductInterest";
		}

		public ContactsProductInterest(ContactsProductInterest source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactsProductInterest_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactsProductInterestDeleted", e);
			Validating += (s, e) => ThrowEvent("ContactsProductInterestValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactsProductInterest(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactsProductInterest_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactsProductInterest_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactsProductInterest_CrtBaseEventsProcess<TEntity> where TEntity : ContactsProductInterest
	{

		public ContactsProductInterest_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactsProductInterest_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2237e267-e05a-4751-a330-bb8a5e750115");
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

	#region Class: ContactsProductInterest_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactsProductInterest_CrtBaseFinservEventsProcess : ContactsProductInterest_CrtBaseFinservEventsProcess<ContactsProductInterest>
	{

		public ContactsProductInterest_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactsProductInterest_CrtBaseFinservEventsProcess

	public partial class ContactsProductInterest_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContactsProductInterestEventsProcess

	/// <exclude/>
	public class ContactsProductInterestEventsProcess : ContactsProductInterest_CrtBaseFinservEventsProcess
	{

		public ContactsProductInterestEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

