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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: ContactTagSchema

	/// <exclude/>
	public class ContactTagSchema : Terrasoft.Configuration.ContactTag_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactTagSchema(ContactTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactTagSchema(ContactTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("45995d84-0948-41a8-93e6-64cb936ea669");
			Name = "ContactTag";
			ParentSchemaUId = new Guid("2c1204a0-8b81-4a4e-9703-802e78782532");
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
			return new ContactTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactTag_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45995d84-0948-41a8-93e6-64cb936ea669"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactTag

	/// <summary>
	/// Contacts section tag.
	/// </summary>
	public class ContactTag : Terrasoft.Configuration.ContactTag_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactTag";
		}

		public ContactTag(ContactTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactTag_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactTagDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactTagDeleting", e);
			Inserting += (s, e) => ThrowEvent("ContactTagInserting", e);
			Saved += (s, e) => ThrowEvent("ContactTagSaved", e);
			Saving += (s, e) => ThrowEvent("ContactTagSaving", e);
			Validating += (s, e) => ThrowEvent("ContactTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactTag_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactTag_CrtBaseEventsProcess<TEntity> where TEntity : ContactTag
	{

		public ContactTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactTag_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("45995d84-0948-41a8-93e6-64cb936ea669");
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

	#region Class: ContactTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactTag_CrtBaseFinservEventsProcess : ContactTag_CrtBaseFinservEventsProcess<ContactTag>
	{

		public ContactTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactTag_CrtBaseFinservEventsProcess

	public partial class ContactTag_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContactTagEventsProcess

	/// <exclude/>
	public class ContactTagEventsProcess : ContactTag_CrtBaseFinservEventsProcess
	{

		public ContactTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

