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

	#region Class: AddressType_CrtCustomer360App_TerrasoftSchema

	/// <exclude/>
	public class AddressType_CrtCustomer360App_TerrasoftSchema : Terrasoft.Configuration.AddressType_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public AddressType_CrtCustomer360App_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AddressType_CrtCustomer360App_TerrasoftSchema(AddressType_CrtCustomer360App_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AddressType_CrtCustomer360App_TerrasoftSchema(AddressType_CrtCustomer360App_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("605554f5-cbdc-49dc-98c2-b0c919c2f2eb");
			Name = "AddressType_CrtCustomer360App_Terrasoft";
			ParentSchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fc4aecd3-2015-46dd-9cce-abee4c701856");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("ff40cd49-76cb-c51a-6fa9-0021d25e544e"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("605554f5-cbdc-49dc-98c2-b0c919c2f2eb"),
				ModifiedInSchemaUId = new Guid("605554f5-cbdc-49dc-98c2-b0c919c2f2eb"),
				CreatedInPackageId = new Guid("fc4aecd3-2015-46dd-9cce-abee4c701856")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AddressType_CrtCustomer360App_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AddressType_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AddressType_CrtCustomer360App_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AddressType_CrtCustomer360App_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("605554f5-cbdc-49dc-98c2-b0c919c2f2eb"));
		}

		#endregion

	}

	#endregion

	#region Class: AddressType_CrtCustomer360App_Terrasoft

	/// <summary>
	/// Address type.
	/// </summary>
	public class AddressType_CrtCustomer360App_Terrasoft : Terrasoft.Configuration.AddressType_SSP_Terrasoft
	{

		#region Constructors: Public

		public AddressType_CrtCustomer360App_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AddressType_CrtCustomer360App_Terrasoft";
		}

		public AddressType_CrtCustomer360App_Terrasoft(AddressType_CrtCustomer360App_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AddressType_CrtCustomer360AppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AddressType_CrtCustomer360App_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("AddressType_CrtCustomer360App_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("AddressType_CrtCustomer360App_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("AddressType_CrtCustomer360App_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("AddressType_CrtCustomer360App_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("AddressType_CrtCustomer360App_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AddressType_CrtCustomer360App_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AddressType_CrtCustomer360App_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AddressType_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class AddressType_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.AddressType_SSPEventsProcess<TEntity> where TEntity : AddressType_CrtCustomer360App_Terrasoft
	{

		public AddressType_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AddressType_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("605554f5-cbdc-49dc-98c2-b0c919c2f2eb");
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

	#region Class: AddressType_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class AddressType_CrtCustomer360AppEventsProcess : AddressType_CrtCustomer360AppEventsProcess<AddressType_CrtCustomer360App_Terrasoft>
	{

		public AddressType_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AddressType_CrtCustomer360AppEventsProcess

	public partial class AddressType_CrtCustomer360AppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

