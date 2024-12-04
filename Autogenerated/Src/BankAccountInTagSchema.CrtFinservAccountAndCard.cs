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

	#region Class: BankAccountInTagSchema

	/// <exclude/>
	public class BankAccountInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public BankAccountInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankAccountInTagSchema(BankAccountInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankAccountInTagSchema(BankAccountInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d6ed380a-9947-461f-b710-564bbedf4cf5");
			RealUId = new Guid("d6ed380a-9947-461f-b710-564bbedf4cf5");
			Name = "BankAccountInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("52e3ea63-86ec-48b1-8252-db8e01b90122");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("d6ed380a-9947-461f-b710-564bbedf4cf5");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("8e07b87f-6425-4de2-bae2-663576293e82");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityBankAccountNumber";
			column.ModifiedInSchemaUId = new Guid("d6ed380a-9947-461f-b710-564bbedf4cf5");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankAccountInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankAccountInTag_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankAccountInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankAccountInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6ed380a-9947-461f-b710-564bbedf4cf5"));
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountInTag

	/// <summary>
	/// Financial accounts section record tag.
	/// </summary>
	public class BankAccountInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public BankAccountInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankAccountInTag";
		}

		public BankAccountInTag(BankAccountInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankAccountInTag_CrtFinservAccountAndCardEventsProcess(UserConnection);
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
			return new BankAccountInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountInTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankAccountInTag_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankAccountInTag
	{

		public BankAccountInTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankAccountInTag_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("d6ed380a-9947-461f-b710-564bbedf4cf5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d6ed380a-9947-461f-b710-564bbedf4cf5");
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

	#region Class: BankAccountInTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankAccountInTag_CrtFinservAccountAndCardEventsProcess : BankAccountInTag_CrtFinservAccountAndCardEventsProcess<BankAccountInTag>
	{

		public BankAccountInTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankAccountInTag_CrtFinservAccountAndCardEventsProcess

	public partial class BankAccountInTag_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankAccountInTagEventsProcess

	/// <exclude/>
	public class BankAccountInTagEventsProcess : BankAccountInTag_CrtFinservAccountAndCardEventsProcess
	{

		public BankAccountInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

