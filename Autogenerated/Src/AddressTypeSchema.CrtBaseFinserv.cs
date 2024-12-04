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

	#region Class: AddressTypeSchema

	/// <exclude/>
	public class AddressTypeSchema : Terrasoft.Configuration.AddressType_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public AddressTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AddressTypeSchema(AddressTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AddressTypeSchema(AddressTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("45afa182-8e03-470a-b08c-b2ca5ccf8fa5");
			Name = "AddressType";
			ParentSchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b497ac54-4655-4864-b5ea-8065c6b0b6e0");
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
			return new AddressType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AddressType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AddressTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AddressTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45afa182-8e03-470a-b08c-b2ca5ccf8fa5"));
		}

		#endregion

	}

	#endregion

	#region Class: AddressType

	/// <summary>
	/// Address type.
	/// </summary>
	public class AddressType : Terrasoft.Configuration.AddressType_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public AddressType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AddressType";
		}

		public AddressType(AddressType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AddressType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AddressTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("AddressTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AddressType(this);
		}

		#endregion

	}

	#endregion

	#region Class: AddressType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class AddressType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.AddressType_CrtCustomer360AppEventsProcess<TEntity> where TEntity : AddressType
	{

		public AddressType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AddressType_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("45afa182-8e03-470a-b08c-b2ca5ccf8fa5");
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

	#region Class: AddressType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class AddressType_CrtBaseFinservEventsProcess : AddressType_CrtBaseFinservEventsProcess<AddressType>
	{

		public AddressType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AddressType_CrtBaseFinservEventsProcess

	public partial class AddressType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AddressTypeEventsProcess

	/// <exclude/>
	public class AddressTypeEventsProcess : AddressType_CrtBaseFinservEventsProcess
	{

		public AddressTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

