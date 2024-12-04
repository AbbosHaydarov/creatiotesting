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

	#region Class: SpecificationInContractSchema

	/// <exclude/>
	public class SpecificationInContractSchema : Terrasoft.Configuration.SpecificationInObjectSchema
	{

		#region Constructors: Public

		public SpecificationInContractSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInContractSchema(SpecificationInContractSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInContractSchema(SpecificationInContractSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f5fa86d-101e-43a4-a8fb-78774ec9d5bc");
			RealUId = new Guid("7f5fa86d-101e-43a4-a8fb-78774ec9d5bc");
			Name = "SpecificationInContract";
			ParentSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e7203a6d-211b-48f5-ae5f-46692e82281e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("bf7f4f69-e6a2-4bf0-8c4d-716d69c62dbe")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bf7f4f69-e6a2-4bf0-8c4d-716d69c62dbe"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("7f5fa86d-101e-43a4-a8fb-78774ec9d5bc"),
				ModifiedInSchemaUId = new Guid("7f5fa86d-101e-43a4-a8fb-78774ec9d5bc"),
				CreatedInPackageId = new Guid("e7203a6d-211b-48f5-ae5f-46692e82281e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationInContract(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInContract_CrtFinservContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInContractSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInContractSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f5fa86d-101e-43a4-a8fb-78774ec9d5bc"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInContract

	/// <summary>
	/// Contract parameter.
	/// </summary>
	public class SpecificationInContract : Terrasoft.Configuration.SpecificationInObject
	{

		#region Constructors: Public

		public SpecificationInContract(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInContract";
		}

		public SpecificationInContract(SpecificationInContract source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInContract_CrtFinservContractEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInContractDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecificationInContractDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecificationInContractInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationInContractInserting", e);
			Saved += (s, e) => ThrowEvent("SpecificationInContractSaved", e);
			Saving += (s, e) => ThrowEvent("SpecificationInContractSaving", e);
			Validating += (s, e) => ThrowEvent("SpecificationInContractValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInContract(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInContract_CrtFinservContractEventsProcess

	/// <exclude/>
	public partial class SpecificationInContract_CrtFinservContractEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInObject_SpecificationEventsProcess<TEntity> where TEntity : SpecificationInContract
	{

		public SpecificationInContract_CrtFinservContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInContract_CrtFinservContractEventsProcess";
			SchemaUId = new Guid("7f5fa86d-101e-43a4-a8fb-78774ec9d5bc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7f5fa86d-101e-43a4-a8fb-78774ec9d5bc");
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

	#region Class: SpecificationInContract_CrtFinservContractEventsProcess

	/// <exclude/>
	public class SpecificationInContract_CrtFinservContractEventsProcess : SpecificationInContract_CrtFinservContractEventsProcess<SpecificationInContract>
	{

		public SpecificationInContract_CrtFinservContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInContract_CrtFinservContractEventsProcess

	public partial class SpecificationInContract_CrtFinservContractEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationInContractEventsProcess

	/// <exclude/>
	public class SpecificationInContractEventsProcess : SpecificationInContract_CrtFinservContractEventsProcess
	{

		public SpecificationInContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

