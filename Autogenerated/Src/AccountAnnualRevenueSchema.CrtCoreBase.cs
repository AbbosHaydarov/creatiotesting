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

	#region Class: AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema

	/// <exclude/>
	public class AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema(AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema(AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			RealUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			Name = "AccountAnnualRevenue_CrtCoreBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateFromBaseCurrencyColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("94a2ebc5-c110-4929-94b4-baaafee43d7d")) == null) {
				Columns.Add(CreateToBaseCurrencyColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFromBaseCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("633ed4cd-fe02-423a-a4d4-062cae2a2ec4"),
				Name = @"FromBaseCurrency",
				CreatedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				ModifiedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateToBaseCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("94a2ebc5-c110-4929-94b4-baaafee43d7d"),
				Name = @"ToBaseCurrency",
				CreatedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				ModifiedInSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountAnnualRevenue_CrtCoreBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAnnualRevenue_CrtCoreBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAnnualRevenue_CrtCoreBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenue_CrtCoreBase_Terrasoft

	/// <summary>
	/// Annual revenue of account.
	/// </summary>
	public class AccountAnnualRevenue_CrtCoreBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AccountAnnualRevenue_CrtCoreBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAnnualRevenue_CrtCoreBase_Terrasoft";
		}

		public AccountAnnualRevenue_CrtCoreBase_Terrasoft(AccountAnnualRevenue_CrtCoreBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// From, base currency.
		/// </summary>
		public int FromBaseCurrency {
			get {
				return GetTypedColumnValue<int>("FromBaseCurrency");
			}
			set {
				SetColumnValue("FromBaseCurrency", value);
			}
		}

		/// <summary>
		/// To, base currency.
		/// </summary>
		public int ToBaseCurrency {
			get {
				return GetTypedColumnValue<int>("ToBaseCurrency");
			}
			set {
				SetColumnValue("ToBaseCurrency", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAnnualRevenue_CrtCoreBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAnnualRevenue_CrtCoreBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountAnnualRevenue_CrtCoreBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountAnnualRevenue_CrtCoreBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAnnualRevenue_CrtCoreBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAnnualRevenue_CrtCoreBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AccountAnnualRevenue_CrtCoreBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AccountAnnualRevenue_CrtCoreBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAnnualRevenue_CrtCoreBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnnualRevenue_CrtCoreBaseEventsProcess

	/// <exclude/>
	public partial class AccountAnnualRevenue_CrtCoreBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AccountAnnualRevenue_CrtCoreBase_Terrasoft
	{

		public AccountAnnualRevenue_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAnnualRevenue_CrtCoreBaseEventsProcess";
			SchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9");
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

	#region Class: AccountAnnualRevenue_CrtCoreBaseEventsProcess

	/// <exclude/>
	public class AccountAnnualRevenue_CrtCoreBaseEventsProcess : AccountAnnualRevenue_CrtCoreBaseEventsProcess<AccountAnnualRevenue_CrtCoreBase_Terrasoft>
	{

		public AccountAnnualRevenue_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAnnualRevenue_CrtCoreBaseEventsProcess

	public partial class AccountAnnualRevenue_CrtCoreBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

