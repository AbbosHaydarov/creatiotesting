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

	#region Class: AccountCategory_CrtCoreBase_TerrasoftSchema

	/// <exclude/>
	public class AccountCategory_CrtCoreBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AccountCategory_CrtCoreBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountCategory_CrtCoreBase_TerrasoftSchema(AccountCategory_CrtCoreBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountCategory_CrtCoreBase_TerrasoftSchema(AccountCategory_CrtCoreBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665");
			RealUId = new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665");
			Name = "AccountCategory_CrtCoreBase_Terrasoft";
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
			return new AccountCategory_CrtCoreBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountCategory_CrtCoreBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountCategory_CrtCoreBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountCategory_CrtCoreBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountCategory_CrtCoreBase_Terrasoft

	/// <summary>
	/// Category of Account.
	/// </summary>
	public class AccountCategory_CrtCoreBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AccountCategory_CrtCoreBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountCategory_CrtCoreBase_Terrasoft";
		}

		public AccountCategory_CrtCoreBase_Terrasoft(AccountCategory_CrtCoreBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountCategory_CrtCoreBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountCategory_CrtCoreBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountCategory_CrtCoreBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountCategory_CrtCoreBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountCategory_CrtCoreBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("AccountCategory_CrtCoreBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AccountCategory_CrtCoreBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AccountCategory_CrtCoreBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountCategory_CrtCoreBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountCategory_CrtCoreBaseEventsProcess

	/// <exclude/>
	public partial class AccountCategory_CrtCoreBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountCategory_CrtCoreBase_Terrasoft
	{

		public AccountCategory_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountCategory_CrtCoreBaseEventsProcess";
			SchemaUId = new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665");
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

	#region Class: AccountCategory_CrtCoreBaseEventsProcess

	/// <exclude/>
	public class AccountCategory_CrtCoreBaseEventsProcess : AccountCategory_CrtCoreBaseEventsProcess<AccountCategory_CrtCoreBase_Terrasoft>
	{

		public AccountCategory_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountCategory_CrtCoreBaseEventsProcess

	public partial class AccountCategory_CrtCoreBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

