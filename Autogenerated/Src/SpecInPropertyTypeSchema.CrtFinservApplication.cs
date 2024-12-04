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

	#region Class: SpecInPropertyTypeSchema

	/// <exclude/>
	public class SpecInPropertyTypeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecInPropertyTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecInPropertyTypeSchema(SpecInPropertyTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecInPropertyTypeSchema(SpecInPropertyTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27");
			RealUId = new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27");
			Name = "SpecInPropertyType";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
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
			if (Columns.FindByUId(new Guid("3efd4129-0bf7-4222-ab25-da2987c76812")) == null) {
				Columns.Add(CreatePropertyTypeColumn());
			}
			if (Columns.FindByUId(new Guid("8a45e049-c121-4063-ba36-490379037699")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePropertyTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3efd4129-0bf7-4222-ab25-da2987c76812"),
				Name = @"PropertyType",
				ReferenceSchemaUId = new Guid("aae763b8-2deb-47cd-a41a-ec36cb8d3e84"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27"),
				ModifiedInSchemaUId = new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8a45e049-c121-4063-ba36-490379037699"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27"),
				ModifiedInSchemaUId = new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecInPropertyType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecInPropertyType_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecInPropertyTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecInPropertyTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecInPropertyType

	/// <summary>
	/// Specification in property type.
	/// </summary>
	public class SpecInPropertyType : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecInPropertyType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecInPropertyType";
		}

		public SpecInPropertyType(SpecInPropertyType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PropertyTypeId {
			get {
				return GetTypedColumnValue<Guid>("PropertyTypeId");
			}
			set {
				SetColumnValue("PropertyTypeId", value);
				_propertyType = null;
			}
		}

		/// <exclude/>
		public string PropertyTypeName {
			get {
				return GetTypedColumnValue<string>("PropertyTypeName");
			}
			set {
				SetColumnValue("PropertyTypeName", value);
				if (_propertyType != null) {
					_propertyType.Name = value;
				}
			}
		}

		private PropertyType _propertyType;
		/// <summary>
		/// Property type.
		/// </summary>
		public PropertyType PropertyType {
			get {
				return _propertyType ??
					(_propertyType = LookupColumnEntities.GetEntity("PropertyType") as PropertyType);
			}
		}

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Parameters.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecInPropertyType_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecInPropertyTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecInPropertyTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecInPropertyType(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInPropertyType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class SpecInPropertyType_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SpecInPropertyType
	{

		public SpecInPropertyType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecInPropertyType_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("af0861c7-d5f0-431a-84df-3684b43e2f27");
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

	#region Class: SpecInPropertyType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class SpecInPropertyType_CrtFinservApplicationEventsProcess : SpecInPropertyType_CrtFinservApplicationEventsProcess<SpecInPropertyType>
	{

		public SpecInPropertyType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecInPropertyType_CrtFinservApplicationEventsProcess

	public partial class SpecInPropertyType_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecInPropertyTypeEventsProcess

	/// <exclude/>
	public class SpecInPropertyTypeEventsProcess : SpecInPropertyType_CrtFinservApplicationEventsProcess
	{

		public SpecInPropertyTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

