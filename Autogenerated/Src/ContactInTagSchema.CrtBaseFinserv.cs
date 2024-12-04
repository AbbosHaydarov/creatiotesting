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

	#region Class: ContactInTagSchema

	/// <exclude/>
	public class ContactInTagSchema : Terrasoft.Configuration.ContactInTag_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactInTagSchema(ContactInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactInTagSchema(ContactInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("696af7c5-293a-408c-8287-11e5e5aec5b8");
			Name = "ContactInTag";
			ParentSchemaUId = new Guid("fa9dd0a1-1f55-4ce9-86a4-acad6092697b");
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
			return new ContactInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactInTag_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("696af7c5-293a-408c-8287-11e5e5aec5b8"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactInTag

	/// <summary>
	/// Contacts section record tag.
	/// </summary>
	public class ContactInTag : Terrasoft.Configuration.ContactInTag_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactInTag";
		}

		public ContactInTag(ContactInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactInTag_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactInTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactInTag_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactInTag_CrtBaseEventsProcess<TEntity> where TEntity : ContactInTag
	{

		public ContactInTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactInTag_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("696af7c5-293a-408c-8287-11e5e5aec5b8");
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

	#region Class: ContactInTag_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactInTag_CrtBaseFinservEventsProcess : ContactInTag_CrtBaseFinservEventsProcess<ContactInTag>
	{

		public ContactInTag_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactInTag_CrtBaseFinservEventsProcess

	public partial class ContactInTag_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContactInTagEventsProcess

	/// <exclude/>
	public class ContactInTagEventsProcess : ContactInTag_CrtBaseFinservEventsProcess
	{

		public ContactInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

