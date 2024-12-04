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

	#region Class: ChangeCriteriaSchema

	/// <exclude/>
	public class ChangeCriteriaSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ChangeCriteriaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ChangeCriteriaSchema(ChangeCriteriaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ChangeCriteriaSchema(ChangeCriteriaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9947da59-abc4-47f8-880d-396729a00a86");
			RealUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86");
			Name = "ChangeCriteria";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateDisplayValueColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a8f8280a-f747-4fbc-a5e2-2fd782be1922")) == null) {
				Columns.Add(CreateProductCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("7dda985d-a153-4d39-924b-70e6f87e6b6f")) == null) {
				Columns.Add(CreateProductTypeColumn());
			}
			if (Columns.FindByUId(new Guid("c473a5fd-e8c0-49a4-b93c-27dfcefbd0b7")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a8f8280a-f747-4fbc-a5e2-2fd782be1922"),
				Name = @"ProductCategory",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				ModifiedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateProductTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7dda985d-a153-4d39-924b-70e6f87e6b6f"),
				Name = @"ProductType",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				ModifiedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c473a5fd-e8c0-49a4-b93c-27dfcefbd0b7"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				ModifiedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected virtual EntitySchemaColumn CreateDisplayValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("61b76e79-4c28-4b4a-ae40-185348050f17"),
				Name = @"DisplayValue",
				CreatedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				ModifiedInSchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86"),
				CreatedInPackageId = new Guid("d0543033-f640-4e64-a7b1-f6eac7a56108")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ChangeCriteria(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ChangeCriteria_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ChangeCriteriaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ChangeCriteriaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9947da59-abc4-47f8-880d-396729a00a86"));
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteria

	/// <summary>
	/// Condition change criteria.
	/// </summary>
	public class ChangeCriteria : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ChangeCriteria(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ChangeCriteria";
		}

		public ChangeCriteria(ChangeCriteria source)
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
		/// Change criteria.
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
		public string DisplayValue {
			get {
				return GetTypedColumnValue<string>("DisplayValue");
			}
			set {
				SetColumnValue("DisplayValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ChangeCriteria_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ChangeCriteriaDeleted", e);
			Saving += (s, e) => ThrowEvent("ChangeCriteriaSaving", e);
			Validating += (s, e) => ThrowEvent("ChangeCriteriaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeCriteria(this);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteria_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ChangeCriteria_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ChangeCriteria
	{

		public ChangeCriteria_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeCriteria_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("9947da59-abc4-47f8-880d-396729a00a86");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9947da59-abc4-47f8-880d-396729a00a86");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("c5846554-c8d7-464c-9587-e49cfcab0398"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("b99316d9-e0d0-479b-9c5e-b848648c4613"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeCriteriaSavingScriptTask;
		public ProcessScriptTask ChangeCriteriaSavingScriptTask {
			get {
				return _changeCriteriaSavingScriptTask ?? (_changeCriteriaSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeCriteriaSavingScriptTask",
					SchemaElementUId = new Guid("75598bf5-87e9-4bd9-b94a-bbe17a1d8ebb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeCriteriaSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ChangeCriteriaSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeCriteriaSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ChangeCriteriaSavingScriptTask");
						break;
					case "ChangeCriteriaSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ChangeCriteriaSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeCriteriaSavingScriptTask";
					result = ChangeCriteriaSavingScriptTask.Execute(context, ChangeCriteriaSavingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ChangeCriteriaSavingScriptTaskExecute(ProcessExecutingContext context) {
			Guid specificationId = Entity.GetTypedColumnValue<Guid>("SpecificationId");
			EntitySchema specificationSchema = UserConnection.EntitySchemaManager.FindInstanceByName("Specification");
			Entity specificationEntity = specificationSchema.CreateEntity(UserConnection);
			var columns = new List<string>() {"Name"};
			if (specificationEntity.FetchFromDB("Id", specificationId, columns)) {
				string name = specificationEntity.GetTypedColumnValue<string>("Name");
				Entity.SetColumnValue("DisplayValue", name);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ChangeCriteriaSaving":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeCriteria_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ChangeCriteria_CrtFinservProductEventsProcess : ChangeCriteria_CrtFinservProductEventsProcess<ChangeCriteria>
	{

		public ChangeCriteria_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeCriteria_CrtFinservProductEventsProcess

	public partial class ChangeCriteria_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ChangeCriteriaEventsProcess

	/// <exclude/>
	public class ChangeCriteriaEventsProcess : ChangeCriteria_CrtFinservProductEventsProcess
	{

		public ChangeCriteriaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

