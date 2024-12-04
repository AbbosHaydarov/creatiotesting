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

	#region Class: PropertyTypeSchema

	/// <exclude/>
	public class PropertyTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public PropertyTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PropertyTypeSchema(PropertyTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PropertyTypeSchema(PropertyTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84");
			RealUId = new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84");
			Name = "PropertyType";
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
			if (Columns.FindByUId(new Guid("65acd627-26f1-4d7d-a90c-efff3b00d8f8")) == null) {
				Columns.Add(CreateCollateralObjectTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCollateralObjectTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("65acd627-26f1-4d7d-a90c-efff3b00d8f8"),
				Name = @"CollateralObjectType",
				ReferenceSchemaUId = new Guid("3a4b2faa-1812-4b3d-99ce-007ac3d55db2"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84"),
				ModifiedInSchemaUId = new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PropertyType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PropertyType_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PropertyTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PropertyTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84"));
		}

		#endregion

	}

	#endregion

	#region Class: PropertyType

	/// <summary>
	/// Property types.
	/// </summary>
	public class PropertyType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public PropertyType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PropertyType";
		}

		public PropertyType(PropertyType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CollateralObjectTypeId {
			get {
				return GetTypedColumnValue<Guid>("CollateralObjectTypeId");
			}
			set {
				SetColumnValue("CollateralObjectTypeId", value);
				_collateralObjectType = null;
			}
		}

		/// <exclude/>
		public string CollateralObjectTypeName {
			get {
				return GetTypedColumnValue<string>("CollateralObjectTypeName");
			}
			set {
				SetColumnValue("CollateralObjectTypeName", value);
				if (_collateralObjectType != null) {
					_collateralObjectType.Name = value;
				}
			}
		}

		private CollateralObjectType _collateralObjectType;
		/// <summary>
		/// Collateral object type.
		/// </summary>
		public CollateralObjectType CollateralObjectType {
			get {
				return _collateralObjectType ??
					(_collateralObjectType = LookupColumnEntities.GetEntity("CollateralObjectType") as CollateralObjectType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PropertyType_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PropertyTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("PropertyTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PropertyType(this);
		}

		#endregion

	}

	#endregion

	#region Class: PropertyType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class PropertyType_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : PropertyType
	{

		public PropertyType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PropertyType_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84");
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

	#region Class: PropertyType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class PropertyType_CrtFinservApplicationEventsProcess : PropertyType_CrtFinservApplicationEventsProcess<PropertyType>
	{

		public PropertyType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PropertyType_CrtFinservApplicationEventsProcess

	public partial class PropertyType_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PropertyTypeEventsProcess

	/// <exclude/>
	public class PropertyTypeEventsProcess : PropertyType_CrtFinservApplicationEventsProcess
	{

		public PropertyTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

