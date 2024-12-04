﻿namespace Terrasoft.Configuration
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

	#region Class: ContactSalutationType_CrtCoreBase_TerrasoftSchema

	/// <exclude/>
	public class ContactSalutationType_CrtCoreBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ContactSalutationType_CrtCoreBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactSalutationType_CrtCoreBase_TerrasoftSchema(ContactSalutationType_CrtCoreBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactSalutationType_CrtCoreBase_TerrasoftSchema(ContactSalutationType_CrtCoreBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
			RealUId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
			Name = "ContactSalutationType_CrtCoreBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
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
			return new ContactSalutationType_CrtCoreBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactSalutationType_CrtCoreBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactSalutationType_CrtCoreBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactSalutationType_CrtCoreBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactSalutationType_CrtCoreBase_Terrasoft

	/// <summary>
	/// Contact title.
	/// </summary>
	public class ContactSalutationType_CrtCoreBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ContactSalutationType_CrtCoreBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactSalutationType_CrtCoreBase_Terrasoft";
		}

		public ContactSalutationType_CrtCoreBase_Terrasoft(ContactSalutationType_CrtCoreBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactSalutationType_CrtCoreBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactSalutationType_CrtCoreBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactSalutationType_CrtCoreBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactSalutationType_CrtCoreBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactSalutationType_CrtCoreBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactSalutationType_CrtCoreBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactSalutationType_CrtCoreBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ContactSalutationType_CrtCoreBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactSalutationType_CrtCoreBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactSalutationType_CrtCoreBaseEventsProcess

	/// <exclude/>
	public partial class ContactSalutationType_CrtCoreBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ContactSalutationType_CrtCoreBase_Terrasoft
	{

		public ContactSalutationType_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactSalutationType_CrtCoreBaseEventsProcess";
			SchemaUId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
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

	#region Class: ContactSalutationType_CrtCoreBaseEventsProcess

	/// <exclude/>
	public class ContactSalutationType_CrtCoreBaseEventsProcess : ContactSalutationType_CrtCoreBaseEventsProcess<ContactSalutationType_CrtCoreBase_Terrasoft>
	{

		public ContactSalutationType_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactSalutationType_CrtCoreBaseEventsProcess

	public partial class ContactSalutationType_CrtCoreBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

