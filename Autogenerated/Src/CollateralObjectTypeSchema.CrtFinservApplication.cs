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

	#region Class: CollateralObjectTypeSchema

	/// <exclude/>
	public class CollateralObjectTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CollateralObjectTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CollateralObjectTypeSchema(CollateralObjectTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CollateralObjectTypeSchema(CollateralObjectTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3a4b2faa-1812-4b3d-99ce-007ac3d55db2");
			RealUId = new Guid("3a4b2faa-1812-4b3d-99ce-007ac3d55db2");
			Name = "CollateralObjectType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1");
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
			return new CollateralObjectType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CollateralObjectType_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CollateralObjectTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CollateralObjectTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3a4b2faa-1812-4b3d-99ce-007ac3d55db2"));
		}

		#endregion

	}

	#endregion

	#region Class: CollateralObjectType

	/// <summary>
	/// Collateral object type.
	/// </summary>
	public class CollateralObjectType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CollateralObjectType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CollateralObjectType";
		}

		public CollateralObjectType(CollateralObjectType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CollateralObjectType_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CollateralObjectTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("CollateralObjectTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CollateralObjectType(this);
		}

		#endregion

	}

	#endregion

	#region Class: CollateralObjectType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class CollateralObjectType_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : CollateralObjectType
	{

		public CollateralObjectType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CollateralObjectType_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("3a4b2faa-1812-4b3d-99ce-007ac3d55db2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3a4b2faa-1812-4b3d-99ce-007ac3d55db2");
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

	#region Class: CollateralObjectType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class CollateralObjectType_CrtFinservApplicationEventsProcess : CollateralObjectType_CrtFinservApplicationEventsProcess<CollateralObjectType>
	{

		public CollateralObjectType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CollateralObjectType_CrtFinservApplicationEventsProcess

	public partial class CollateralObjectType_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CollateralObjectTypeEventsProcess

	/// <exclude/>
	public class CollateralObjectTypeEventsProcess : CollateralObjectType_CrtFinservApplicationEventsProcess
	{

		public CollateralObjectTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

