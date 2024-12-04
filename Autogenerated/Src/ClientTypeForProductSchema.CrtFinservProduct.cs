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

	#region Class: ClientTypeForProductSchema

	/// <exclude/>
	public class ClientTypeForProductSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ClientTypeForProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ClientTypeForProductSchema(ClientTypeForProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ClientTypeForProductSchema(ClientTypeForProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f42e1f0f-94da-44b7-82e0-ba56300fac21");
			RealUId = new Guid("f42e1f0f-94da-44b7-82e0-ba56300fac21");
			Name = "ClientTypeForProduct";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2a139ddd-8ae7-4248-b1b7-a5365e69a65f");
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
			return new ClientTypeForProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ClientTypeForProduct_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ClientTypeForProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ClientTypeForProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f42e1f0f-94da-44b7-82e0-ba56300fac21"));
		}

		#endregion

	}

	#endregion

	#region Class: ClientTypeForProduct

	/// <summary>
	/// Client type for product.
	/// </summary>
	public class ClientTypeForProduct : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ClientTypeForProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ClientTypeForProduct";
		}

		public ClientTypeForProduct(ClientTypeForProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ClientTypeForProduct_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ClientTypeForProductDeleted", e);
			Validating += (s, e) => ThrowEvent("ClientTypeForProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ClientTypeForProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: ClientTypeForProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ClientTypeForProduct_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ClientTypeForProduct
	{

		public ClientTypeForProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ClientTypeForProduct_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("f42e1f0f-94da-44b7-82e0-ba56300fac21");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f42e1f0f-94da-44b7-82e0-ba56300fac21");
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

	#region Class: ClientTypeForProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ClientTypeForProduct_CrtFinservProductEventsProcess : ClientTypeForProduct_CrtFinservProductEventsProcess<ClientTypeForProduct>
	{

		public ClientTypeForProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ClientTypeForProduct_CrtFinservProductEventsProcess

	public partial class ClientTypeForProduct_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ClientTypeForProductEventsProcess

	/// <exclude/>
	public class ClientTypeForProductEventsProcess : ClientTypeForProduct_CrtFinservProductEventsProcess
	{

		public ClientTypeForProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

