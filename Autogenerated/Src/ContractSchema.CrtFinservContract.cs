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

	#region Class: Contract_CrtFinservContract_TerrasoftSchema

	/// <exclude/>
	public class Contract_CrtFinservContract_TerrasoftSchema : Terrasoft.Configuration.Contract_CrtContract_TerrasoftSchema
	{

		#region Constructors: Public

		public Contract_CrtFinservContract_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contract_CrtFinservContract_TerrasoftSchema(Contract_CrtFinservContract_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contract_CrtFinservContract_TerrasoftSchema(Contract_CrtFinservContract_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5560ebca-8aa8-4188-8388-df059a92eada");
			Name = "Contract_CrtFinservContract_Terrasoft";
			ParentSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e7203a6d-211b-48f5-ae5f-46692e82281e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("092890ae-cb80-4b7f-b80f-b2559852dbf3")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("a11e3bec-af0c-4ef0-a6bc-902e496a921d")) == null) {
				Columns.Add(CreateSigningDateColumn());
			}
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Sequence,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("5560ebca-8aa8-4188-8388-df059a92eada");
			return column;
		}

		protected override EntitySchemaColumn CreateStartDateColumn() {
			EntitySchemaColumn column = base.CreateStartDateColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("5560ebca-8aa8-4188-8388-df059a92eada");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("092890ae-cb80-4b7f-b80f-b2559852dbf3"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5560ebca-8aa8-4188-8388-df059a92eada"),
				ModifiedInSchemaUId = new Guid("5560ebca-8aa8-4188-8388-df059a92eada"),
				CreatedInPackageId = new Guid("e7203a6d-211b-48f5-ae5f-46692e82281e")
			};
		}

		protected virtual EntitySchemaColumn CreateSigningDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("a11e3bec-af0c-4ef0-a6bc-902e496a921d"),
				Name = @"SigningDate",
				CreatedInSchemaUId = new Guid("5560ebca-8aa8-4188-8388-df059a92eada"),
				ModifiedInSchemaUId = new Guid("5560ebca-8aa8-4188-8388-df059a92eada"),
				CreatedInPackageId = new Guid("00b2a829-0986-4225-99c7-36c032e3adbe")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contract_CrtFinservContract_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contract_CrtFinservContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contract_CrtFinservContract_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contract_CrtFinservContract_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5560ebca-8aa8-4188-8388-df059a92eada"));
		}

		#endregion

	}

	#endregion

	#region Class: Contract_CrtFinservContract_Terrasoft

	/// <summary>
	/// Contract.
	/// </summary>
	public class Contract_CrtFinservContract_Terrasoft : Terrasoft.Configuration.Contract_CrtContract_Terrasoft
	{

		#region Constructors: Public

		public Contract_CrtFinservContract_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contract_CrtFinservContract_Terrasoft";
		}

		public Contract_CrtFinservContract_Terrasoft(Contract_CrtFinservContract_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		/// <summary>
		/// Signed on.
		/// </summary>
		public DateTime SigningDate {
			get {
				return GetTypedColumnValue<DateTime>("SigningDate");
			}
			set {
				SetColumnValue("SigningDate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contract_CrtFinservContractEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contract_CrtFinservContract_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contract_CrtFinservContract_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Contract_CrtFinservContract_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Contract_CrtFinservContract_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Contract_CrtFinservContract_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Contract_CrtFinservContract_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Contract_CrtFinservContract_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contract_CrtFinservContract_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contract_CrtFinservContractEventsProcess

	/// <exclude/>
	public partial class Contract_CrtFinservContractEventsProcess<TEntity> : Terrasoft.Configuration.Contract_CrtContractEventsProcess<TEntity> where TEntity : Contract_CrtFinservContract_Terrasoft
	{

		public Contract_CrtFinservContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contract_CrtFinservContractEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5560ebca-8aa8-4188-8388-df059a92eada");
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

	#region Class: Contract_CrtFinservContractEventsProcess

	/// <exclude/>
	public class Contract_CrtFinservContractEventsProcess : Contract_CrtFinservContractEventsProcess<Contract_CrtFinservContract_Terrasoft>
	{

		public Contract_CrtFinservContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contract_CrtFinservContractEventsProcess

	public partial class Contract_CrtFinservContractEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

