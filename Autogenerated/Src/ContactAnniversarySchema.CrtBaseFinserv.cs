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

	#region Class: ContactAnniversarySchema

	/// <exclude/>
	public class ContactAnniversarySchema : Terrasoft.Configuration.ContactAnniversary_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactAnniversarySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactAnniversarySchema(ContactAnniversarySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactAnniversarySchema(ContactAnniversarySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("95c44c0e-46de-47b0-82fc-62aec67b3c78");
			Name = "ContactAnniversary";
			ParentSchemaUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("bfaefaae-1809-4100-a7d5-ff7de9dab6b8");
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
			return new ContactAnniversary(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactAnniversary_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactAnniversarySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactAnniversarySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95c44c0e-46de-47b0-82fc-62aec67b3c78"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactAnniversary

	/// <summary>
	/// Noteworthy event of contact.
	/// </summary>
	public class ContactAnniversary : Terrasoft.Configuration.ContactAnniversary_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactAnniversary(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactAnniversary";
		}

		public ContactAnniversary(ContactAnniversary source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactAnniversary_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("ContactAnniversaryInserted", e);
			Saving += (s, e) => ThrowEvent("ContactAnniversarySaving", e);
			Validating += (s, e) => ThrowEvent("ContactAnniversaryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactAnniversary(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactAnniversary_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactAnniversary_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactAnniversary_CrtBaseEventsProcess<TEntity> where TEntity : ContactAnniversary
	{

		public ContactAnniversary_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactAnniversary_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("95c44c0e-46de-47b0-82fc-62aec67b3c78");
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

	#region Class: ContactAnniversary_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactAnniversary_CrtBaseFinservEventsProcess : ContactAnniversary_CrtBaseFinservEventsProcess<ContactAnniversary>
	{

		public ContactAnniversary_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactAnniversary_CrtBaseFinservEventsProcess

	public partial class ContactAnniversary_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContactAnniversaryEventsProcess

	/// <exclude/>
	public class ContactAnniversaryEventsProcess : ContactAnniversary_CrtBaseFinservEventsProcess
	{

		public ContactAnniversaryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

