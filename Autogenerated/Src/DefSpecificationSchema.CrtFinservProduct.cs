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

	#region Class: DefSpecificationSchema

	/// <exclude/>
	public class DefSpecificationSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DefSpecificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DefSpecificationSchema(DefSpecificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DefSpecificationSchema(DefSpecificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3");
			RealUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3");
			Name = "DefSpecification";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3a95f579-cf8a-44e3-b1dd-96cb1a734e9c")) == null) {
				Columns.Add(CreateProductCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("e641b20a-57de-42e5-9bf3-4ecff965584b")) == null) {
				Columns.Add(CreateProductTypeColumn());
			}
			if (Columns.FindByUId(new Guid("cd201cde-b1b1-4b71-8bd7-599bba97e37b")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3a95f579-cf8a-44e3-b1dd-96cb1a734e9c"),
				Name = @"ProductCategory",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				ModifiedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d")
			};
		}

		protected virtual EntitySchemaColumn CreateProductTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e641b20a-57de-42e5-9bf3-4ecff965584b"),
				Name = @"ProductType",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				ModifiedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cd201cde-b1b1-4b71-8bd7-599bba97e37b"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				ModifiedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				CreatedInPackageId = new Guid("b421e28e-3799-4a6f-81a8-f76e8f87b41d")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3e385306-14ae-413a-a534-19c46ec0c28d"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				ModifiedInSchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"),
				CreatedInPackageId = new Guid("83856585-b81f-4d42-9fb8-d0b6cb7b9009"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DefSpecification(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DefSpecification_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DefSpecificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DefSpecificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3"));
		}

		#endregion

	}

	#endregion

	#region Class: DefSpecification

	/// <summary>
	/// Default feature.
	/// </summary>
	public class DefSpecification : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DefSpecification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DefSpecification";
		}

		public DefSpecification(DefSpecification source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProductCategoryId {
			get {
				return GetTypedColumnValue<Guid>("ProductCategoryId");
			}
			set {
				SetColumnValue("ProductCategoryId", value);
				_productCategory = null;
			}
		}

		/// <exclude/>
		public string ProductCategoryName {
			get {
				return GetTypedColumnValue<string>("ProductCategoryName");
			}
			set {
				SetColumnValue("ProductCategoryName", value);
				if (_productCategory != null) {
					_productCategory.Name = value;
				}
			}
		}

		private ProductCategory _productCategory;
		/// <summary>
		/// Category.
		/// </summary>
		public ProductCategory ProductCategory {
			get {
				return _productCategory ??
					(_productCategory = LookupColumnEntities.GetEntity("ProductCategory") as ProductCategory);
			}
		}

		/// <exclude/>
		public Guid ProductTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeId");
			}
			set {
				SetColumnValue("ProductTypeId", value);
				_productType = null;
			}
		}

		/// <exclude/>
		public string ProductTypeName {
			get {
				return GetTypedColumnValue<string>("ProductTypeName");
			}
			set {
				SetColumnValue("ProductTypeName", value);
				if (_productType != null) {
					_productType.Name = value;
				}
			}
		}

		private ProductType _productType;
		/// <summary>
		/// Type.
		/// </summary>
		public ProductType ProductType {
			get {
				return _productType ??
					(_productType = LookupColumnEntities.GetEntity("ProductType") as ProductType);
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
		/// Feature.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DefSpecification_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DefSpecificationDeleted", e);
			Saving += (s, e) => ThrowEvent("DefSpecificationSaving", e);
			Validating += (s, e) => ThrowEvent("DefSpecificationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DefSpecification(this);
		}

		#endregion

	}

	#endregion

	#region Class: DefSpecification_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class DefSpecification_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DefSpecification
	{

		public DefSpecification_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DefSpecification_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4201880b-a6e1-4e1b-82f0-d4c7e6358bd3");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcessDefSpecificationSaving;
		public ProcessFlowElement EventSubProcessDefSpecificationSaving {
			get {
				return _eventSubProcessDefSpecificationSaving ?? (_eventSubProcessDefSpecificationSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDefSpecificationSaving",
					SchemaElementUId = new Guid("bf9266ae-facf-48c0-8153-bf6da73d39a6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDefSpecificationSaving;
		public ProcessFlowElement StartMessageDefSpecificationSaving {
			get {
				return _startMessageDefSpecificationSaving ?? (_startMessageDefSpecificationSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDefSpecificationSaving",
					SchemaElementUId = new Guid("ecd2e257-ec66-47c9-813c-2e9470581225"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDefSpecificationSaving;
		public ProcessScriptTask ScriptTaskDefSpecificationSaving {
			get {
				return _scriptTaskDefSpecificationSaving ?? (_scriptTaskDefSpecificationSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDefSpecificationSaving",
					SchemaElementUId = new Guid("29bc4f7a-7143-4d9c-819a-52c261bc587d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDefSpecificationSavingExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessDefSpecificationSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDefSpecificationSaving };
			FlowElements[StartMessageDefSpecificationSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDefSpecificationSaving };
			FlowElements[ScriptTaskDefSpecificationSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDefSpecificationSaving };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessDefSpecificationSaving":
						break;
					case "StartMessageDefSpecificationSaving":
						e.Context.QueueTasks.Enqueue("ScriptTaskDefSpecificationSaving");
						break;
					case "ScriptTaskDefSpecificationSaving":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageDefSpecificationSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessDefSpecificationSaving":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDefSpecificationSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDefSpecificationSaving";
					result = StartMessageDefSpecificationSaving.Execute(context);
					break;
				case "ScriptTaskDefSpecificationSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDefSpecificationSaving";
					result = ScriptTaskDefSpecificationSaving.Execute(context, ScriptTaskDefSpecificationSavingExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskDefSpecificationSavingExecute(ProcessExecutingContext context) {
			OnSaving();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DefSpecificationSaving":
							if (ActivatedEventElements.Contains("StartMessageDefSpecificationSaving")) {
							context.QueueTasks.Enqueue("StartMessageDefSpecificationSaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: DefSpecification_CrtFinservProductEventsProcess

	/// <exclude/>
	public class DefSpecification_CrtFinservProductEventsProcess : DefSpecification_CrtFinservProductEventsProcess<DefSpecification>
	{

		public DefSpecification_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DefSpecification_CrtFinservProductEventsProcess

	public partial class DefSpecification_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnSaving() {
			SetName();
		}

		public virtual void SetName() {
			Guid specificationId = Entity.GetTypedColumnValue<Guid>("SpecificationId");
			EntitySchema specificationSchema = UserConnection.EntitySchemaManager.FindInstanceByName("Specification");
			Entity specificationEntity = specificationSchema.CreateEntity(UserConnection);
			var columns = new List<string>() {"Name"};
			if (specificationEntity.FetchFromDB("Id", specificationId, columns)) {
				string name = specificationEntity.GetTypedColumnValue<string>("Name");
				Entity.SetColumnValue("Name", name);
			}
		}

		#endregion

	}

	#endregion


	#region Class: DefSpecificationEventsProcess

	/// <exclude/>
	public class DefSpecificationEventsProcess : DefSpecification_CrtFinservProductEventsProcess
	{

		public DefSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

