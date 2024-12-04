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

	#region Class: SpecificationSchema

	/// <exclude/>
	public class SpecificationSchema : Terrasoft.Configuration.Specification_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationSchema(SpecificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationSchema(SpecificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3");
			Name = "Specification";
			ParentSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef");
			ExtendParent = true;
			CreatedInPackageId = new Guid("86a98e97-c14a-402e-8678-a2ccda7f89c3");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5ecb578f-6b8f-4b40-84d1-08dfa18d74d2")) == null) {
				Columns.Add(CreateCodeColumn());
			}
			if (Columns.FindByUId(new Guid("ab569a13-ac46-4c1d-8b94-14bd457f355b")) == null) {
				Columns.Add(CreateUnitColumn());
			}
			if (Columns.FindByUId(new Guid("ad0a5614-ab10-42bc-97ce-a253694b3376")) == null) {
				Columns.Add(CreateLookupColumn());
			}
			if (Columns.FindByUId(new Guid("c63c5495-955a-731f-1813-aaff1a7553bd")) == null) {
				Columns.Add(CreateSpecInConditionTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5ecb578f-6b8f-4b40-84d1-08dfa18d74d2"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				ModifiedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ab569a13-ac46-4c1d-8b94-14bd457f355b"),
				Name = @"Unit",
				ReferenceSchemaUId = new Guid("38f2220e-7085-494d-b4c9-396666b6327b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				ModifiedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b")
			};
		}

		protected virtual EntitySchemaColumn CreateLookupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ad0a5614-ab10-42bc-97ce-a253694b3376"),
				Name = @"Lookup",
				ReferenceSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				ModifiedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecInConditionTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c63c5495-955a-731f-1813-aaff1a7553bd"),
				Name = @"SpecInConditionType",
				ReferenceSchemaUId = new Guid("f36204bb-8e9a-4fac-a8f2-520b9e8d4819"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				ModifiedInSchemaUId = new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"),
				CreatedInPackageId = new Guid("86a98e97-c14a-402e-8678-a2ccda7f89c3")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Specification(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Specification_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3"));
		}

		#endregion

	}

	#endregion

	#region Class: Specification

	/// <summary>
	/// Parameter.
	/// </summary>
	public class Specification : Terrasoft.Configuration.Specification_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public Specification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Specification";
		}

		public Specification(Specification source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <exclude/>
		public Guid UnitId {
			get {
				return GetTypedColumnValue<Guid>("UnitId");
			}
			set {
				SetColumnValue("UnitId", value);
				_unit = null;
			}
		}

		/// <exclude/>
		public string UnitName {
			get {
				return GetTypedColumnValue<string>("UnitName");
			}
			set {
				SetColumnValue("UnitName", value);
				if (_unit != null) {
					_unit.Name = value;
				}
			}
		}

		private Unit _unit;
		/// <summary>
		/// Unit of measure.
		/// </summary>
		public Unit Unit {
			get {
				return _unit ??
					(_unit = LookupColumnEntities.GetEntity("Unit") as Unit);
			}
		}

		/// <exclude/>
		public Guid LookupId {
			get {
				return GetTypedColumnValue<Guid>("LookupId");
			}
			set {
				SetColumnValue("LookupId", value);
				_lookup = null;
			}
		}

		/// <exclude/>
		public string LookupName {
			get {
				return GetTypedColumnValue<string>("LookupName");
			}
			set {
				SetColumnValue("LookupName", value);
				if (_lookup != null) {
					_lookup.Name = value;
				}
			}
		}

		private Lookup _lookup;
		/// <summary>
		/// Connect with lookup.
		/// </summary>
		public Lookup Lookup {
			get {
				return _lookup ??
					(_lookup = LookupColumnEntities.GetEntity("Lookup") as Lookup);
			}
		}

		/// <exclude/>
		public Guid SpecInConditionTypeId {
			get {
				return GetTypedColumnValue<Guid>("SpecInConditionTypeId");
			}
			set {
				SetColumnValue("SpecInConditionTypeId", value);
				_specInConditionType = null;
			}
		}

		/// <exclude/>
		public string SpecInConditionTypeName {
			get {
				return GetTypedColumnValue<string>("SpecInConditionTypeName");
			}
			set {
				SetColumnValue("SpecInConditionTypeName", value);
				if (_specInConditionType != null) {
					_specInConditionType.Name = value;
				}
			}
		}

		private SpecInConditionType _specInConditionType;
		/// <summary>
		/// Parameter classification.
		/// </summary>
		public SpecInConditionType SpecInConditionType {
			get {
				return _specInConditionType ??
					(_specInConditionType = LookupColumnEntities.GetEntity("SpecInConditionType") as SpecInConditionType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Specification_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("SpecificationDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecificationInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationInserting", e);
			Saved += (s, e) => ThrowEvent("SpecificationSaved", e);
			Saving += (s, e) => ThrowEvent("SpecificationSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Specification(this);
		}

		#endregion

	}

	#endregion

	#region Class: Specification_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class Specification_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.Specification_CrtProductCatalogueEventsProcess<TEntity> where TEntity : Specification
	{

		public Specification_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Specification_CrtFinservProductEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f2ee6b2d-37f9-d4a6-87ab-ebcb37c3f3a3");
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

	#region Class: Specification_CrtFinservProductEventsProcess

	/// <exclude/>
	public class Specification_CrtFinservProductEventsProcess : Specification_CrtFinservProductEventsProcess<Specification>
	{

		public Specification_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Specification_CrtFinservProductEventsProcess

	public partial class Specification_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationEventsProcess

	/// <exclude/>
	public class SpecificationEventsProcess : Specification_CrtFinservProductEventsProcess
	{

		public SpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

