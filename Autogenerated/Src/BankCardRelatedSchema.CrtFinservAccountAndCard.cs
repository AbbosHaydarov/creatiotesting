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

	#region Class: BankCardRelatedSchema

	/// <exclude/>
	public class BankCardRelatedSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BankCardRelatedSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardRelatedSchema(BankCardRelatedSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardRelatedSchema(BankCardRelatedSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7");
			RealUId = new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7");
			Name = "BankCardRelated";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("defd0fb9-6872-4721-8a3a-94624eb48bf8")) == null) {
				Columns.Add(CreateBankCardColumn());
			}
			if (Columns.FindByUId(new Guid("c169dcd5-9be3-48ec-bea6-d3027083ed0b")) == null) {
				Columns.Add(CreateRelatedBankCardColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateBankCardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("defd0fb9-6872-4721-8a3a-94624eb48bf8"),
				Name = @"BankCard",
				ReferenceSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7"),
				ModifiedInSchemaUId = new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedBankCardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c169dcd5-9be3-48ec-bea6-d3027083ed0b"),
				Name = @"RelatedBankCard",
				ReferenceSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7"),
				ModifiedInSchemaUId = new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7"),
				CreatedInPackageId = new Guid("5b349728-1e4d-4e42-b2cc-d37fb229ceaa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankCardRelated(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardRelated_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardRelatedSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardRelatedSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardRelated

	/// <summary>
	/// Connected cards.
	/// </summary>
	public class BankCardRelated : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BankCardRelated(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardRelated";
		}

		public BankCardRelated(BankCardRelated source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BankCardId {
			get {
				return GetTypedColumnValue<Guid>("BankCardId");
			}
			set {
				SetColumnValue("BankCardId", value);
				_bankCard = null;
			}
		}

		/// <exclude/>
		public string BankCardNumber {
			get {
				return GetTypedColumnValue<string>("BankCardNumber");
			}
			set {
				SetColumnValue("BankCardNumber", value);
				if (_bankCard != null) {
					_bankCard.Number = value;
				}
			}
		}

		private BankCard _bankCard;
		/// <summary>
		/// Card.
		/// </summary>
		public BankCard BankCard {
			get {
				return _bankCard ??
					(_bankCard = LookupColumnEntities.GetEntity("BankCard") as BankCard);
			}
		}

		/// <exclude/>
		public Guid RelatedBankCardId {
			get {
				return GetTypedColumnValue<Guid>("RelatedBankCardId");
			}
			set {
				SetColumnValue("RelatedBankCardId", value);
				_relatedBankCard = null;
			}
		}

		/// <exclude/>
		public string RelatedBankCardNumber {
			get {
				return GetTypedColumnValue<string>("RelatedBankCardNumber");
			}
			set {
				SetColumnValue("RelatedBankCardNumber", value);
				if (_relatedBankCard != null) {
					_relatedBankCard.Number = value;
				}
			}
		}

		private BankCard _relatedBankCard;
		/// <summary>
		/// Linked card.
		/// </summary>
		public BankCard RelatedBankCard {
			get {
				return _relatedBankCard ??
					(_relatedBankCard = LookupColumnEntities.GetEntity("RelatedBankCard") as BankCard);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardRelated_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BankCardRelatedDeleted", e);
			Deleting += (s, e) => ThrowEvent("BankCardRelatedDeleting", e);
			Inserted += (s, e) => ThrowEvent("BankCardRelatedInserted", e);
			Inserting += (s, e) => ThrowEvent("BankCardRelatedInserting", e);
			Saved += (s, e) => ThrowEvent("BankCardRelatedSaved", e);
			Saving += (s, e) => ThrowEvent("BankCardRelatedSaving", e);
			Validating += (s, e) => ThrowEvent("BankCardRelatedValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardRelated(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardRelated_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardRelated_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BankCardRelated
	{

		public BankCardRelated_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardRelated_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3e2a48ad-6478-4406-a8d4-cfaf0f4e8ab7");
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
					SchemaElementUId = new Guid("80bc292a-c3ea-4490-9610-25285890b696"),
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
					SchemaElementUId = new Guid("0363fee4-b140-4f55-b064-e3936f11e1f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _createRelationshipScriptTask;
		public ProcessScriptTask CreateRelationshipScriptTask {
			get {
				return _createRelationshipScriptTask ?? (_createRelationshipScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateRelationshipScriptTask",
					SchemaElementUId = new Guid("7a29283c-80a7-41e2-9ba9-76d483b45c4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateRelationshipScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("b53f6eed-7d34-4ba3-88f2-abc5f070c5ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("d6c09e33-bc64-463f-80d7-9a99bc27d77d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _removeRelationshipScriptTask;
		public ProcessScriptTask RemoveRelationshipScriptTask {
			get {
				return _removeRelationshipScriptTask ?? (_removeRelationshipScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemoveRelationshipScriptTask",
					SchemaElementUId = new Guid("d4a574db-4692-4307-9a2d-19a646403494"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemoveRelationshipScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[CreateRelationshipScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateRelationshipScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[RemoveRelationshipScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveRelationshipScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("CreateRelationshipScriptTask");
						break;
					case "CreateRelationshipScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("RemoveRelationshipScriptTask");
						break;
					case "RemoveRelationshipScriptTask":
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
			ActivatedEventElements.Add("StartMessage2");
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
				case "CreateRelationshipScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateRelationshipScriptTask";
					result = CreateRelationshipScriptTask.Execute(context, CreateRelationshipScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "RemoveRelationshipScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveRelationshipScriptTask";
					result = RemoveRelationshipScriptTask.Execute(context, RemoveRelationshipScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool CreateRelationshipScriptTaskExecute(ProcessExecutingContext context) {
			OnAddBankCardRelated();
			return true;
		}

		public virtual bool RemoveRelationshipScriptTaskExecute(ProcessExecutingContext context) {
			OnDeleteBankCardRelated();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BankCardRelatedInserted":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "BankCardRelatedDeleted":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardRelated_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardRelated_CrtFinservAccountAndCardEventsProcess : BankCardRelated_CrtFinservAccountAndCardEventsProcess<BankCardRelated>
	{

		public BankCardRelated_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardRelated_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardRelated_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnAddBankCardRelated() {
			Guid createdById = Entity.GetTypedColumnValue<Guid>("CreatedById");
			Guid modifiedById = Entity.GetTypedColumnValue<Guid>("ModifiedById");
			Guid bankCardId = Entity.GetTypedColumnValue<Guid>("BankCardId");
			Guid relatedBankCardId = Entity.GetTypedColumnValue<Guid>("RelatedBankCardId");
			Insert insert = new Insert(UserConnection).Into("BankCardRelated")
				.Set("CreatedById", Column.Parameter(createdById))
				.Set("ModifiedById", Column.Parameter(modifiedById))
				.Set("BankCardId", Column.Parameter(relatedBankCardId))
				.Set("RelatedBankCardId", Column.Parameter(bankCardId));
			insert.Execute();
		}

		public virtual void OnDeleteBankCardRelated() {
			Guid bankCardId = Entity.GetTypedColumnValue<Guid>("BankCardId");
			Guid relatedBankCardId = Entity.GetTypedColumnValue<Guid>("RelatedBankCardId");
			Delete delete = new Delete(UserConnection)
				.From("BankCardRelated")
				.Where("BankCardId").IsEqual(Column.Parameter(relatedBankCardId))
				.And("RelatedBankCardId").IsEqual(Column.Parameter(bankCardId)) as Delete;
			delete.Execute();
		}

		#endregion

	}

	#endregion


	#region Class: BankCardRelatedEventsProcess

	/// <exclude/>
	public class BankCardRelatedEventsProcess : BankCardRelated_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardRelatedEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

