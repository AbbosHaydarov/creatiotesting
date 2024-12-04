namespace Terrasoft.Configuration
{

	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
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
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
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

	#region Class: Case_OBSW_TerrasoftSchema

	/// <exclude/>
	public class Case_OBSW_TerrasoftSchema : Terrasoft.Configuration.Case_CrtCustomerInfoInCaseMgmt_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_OBSW_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_OBSW_TerrasoftSchema(Case_OBSW_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_OBSW_TerrasoftSchema(Case_OBSW_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_RegisteredOn_DescIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ed6688c-3e02-47af-9124-e38e20904716");
			index.Name = "IX_RegisteredOn_Desc";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289");
			EntitySchemaIndexColumn registeredOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aa03e37c-3527-4b5c-a16c-53fbc178b41e"),
				ColumnUId = new Guid("c91a9a6f-008d-4b2e-83d5-03868ad68c99"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(registeredOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_SolutionOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ad0ba05-3b32-4561-8bfc-870aee9c951c");
			index.Name = "IX_SolutionOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn solutionProvidedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f3631c8-b14e-4591-a25a-b9207401cfa2"),
				ColumnUId = new Guid("81552f0a-fd92-4865-9533-f4c3ab2861a7"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionProvidedOnIndexColumn);
			EntitySchemaIndexColumn solutionDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5de35510-255d-4f3f-8119-9a3f9b8082f5"),
				ColumnUId = new Guid("624839d1-3bd0-45e0-95d1-28326703f19c"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionDateIndexColumn);
			EntitySchemaIndexColumn solutionOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8dab4368-f988-43de-a48e-bbf238fc3237"),
				ColumnUId = new Guid("0fa66efc-d2d0-47b9-abab-9e3ad2ea82d3"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(solutionOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_ResponseOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("8d002ad1-0715-4bdc-aa5e-8be1a5e39381");
			index.Name = "IX_ResponseOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn respondedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("14abc9af-1b98-4ee2-b236-3a9576b1770f"),
				ColumnUId = new Guid("02612dc8-7243-4acb-b0bd-abbd19e24136"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(respondedOnIndexColumn);
			EntitySchemaIndexColumn responseDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("c3226bd5-beb9-48ea-9383-30fb120d4f4d"),
				ColumnUId = new Guid("25280121-c075-441f-b4f8-feeb6cc7ca38"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(responseDateIndexColumn);
			EntitySchemaIndexColumn responseOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a4aaaa1e-d84e-48a2-84ac-04c35a6fad1e"),
				ColumnUId = new Guid("1ed4e080-0bf8-4f4f-97e8-b3e22f3240a0"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(responseOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_SubjectIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e675ceca-ff2f-44c2-bd1a-f2c1af261cba");
			index.Name = "IDX_Subject";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5");
			EntitySchemaIndexColumn subjectIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5f164afe-e5a5-40a6-9e32-b7f83656bba8"),
				ColumnUId = new Guid("ffe8526d-044f-4222-a1ef-fca83a0772d8"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(subjectIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3");
			Name = "Case_OBSW_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("56232fbe-b69b-474b-8acf-c97c01ca31ca");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("51f855e5-e277-4f2f-9b54-6dff1222ee65")) == null) {
				Columns.Add(CreatePostponedOnColumn());
			}
			if (Columns.FindByUId(new Guid("e4314e84-77f4-49f7-9f26-825fbff9a6d5")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateRegisteredOnColumn() {
			EntitySchemaColumn column = base.CreateRegisteredOnColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.SystemValue,
				ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
			};
			column.ModifiedInSchemaUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3");
			return column;
		}

		protected override EntitySchemaColumn CreateOwnerColumn() {
			EntitySchemaColumn column = base.CreateOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3");
			return column;
		}

		protected override EntitySchemaColumn CreateCategoryColumn() {
			EntitySchemaColumn column = base.CreateCategoryColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"b162f14e-1d4b-4a77-a533-f4c0ad5890df"
			};
			column.ModifiedInSchemaUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePostponedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("51f855e5-e277-4f2f-9b54-6dff1222ee65"),
				Name = @"PostponedOn",
				CreatedInSchemaUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3"),
				ModifiedInSchemaUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3"),
				CreatedInPackageId = new Guid("56232fbe-b69b-474b-8acf-c97c01ca31ca"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e4314e84-77f4-49f7-9f26-825fbff9a6d5"),
				Name = @"IsActive",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3"),
				ModifiedInSchemaUId = new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3"),
				CreatedInPackageId = new Guid("2c0e9c2e-5a97-48fb-b09e-73fa5aae21fc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_RegisteredOn_DescIndex());
			Indexes.Add(CreateIX_SolutionOverdue_AttributesIndex());
			Indexes.Add(CreateIX_ResponseOverdue_AttributesIndex());
			Indexes.Add(CreateIDX_SubjectIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Case_OBSW_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Case_OBSWEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Case_OBSW_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_OBSW_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_OBSW_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_OBSW_Terrasoft : Terrasoft.Configuration.Case_CrtCustomerInfoInCaseMgmt_Terrasoft
	{

		#region Constructors: Public

		public Case_OBSW_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_OBSW_Terrasoft";
		}

		public Case_OBSW_Terrasoft(Case_OBSW_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Postponed on.
		/// </summary>
		public DateTime PostponedOn {
			get {
				return GetTypedColumnValue<DateTime>("PostponedOn");
			}
			set {
				SetColumnValue("PostponedOn", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_OBSWEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Case_OBSW_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("Case_OBSW_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Case_OBSW_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Case_OBSW_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_OBSW_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_OBSWEventsProcess

	/// <exclude/>
	public partial class Case_OBSWEventsProcess<TEntity> : Terrasoft.Configuration.Case_CrtCustomerInfoInCaseMgmtEventsProcess<TEntity> where TEntity : Case_OBSW_Terrasoft
	{

		public Case_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_OBSWEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_isNeedUpdateCaseHistory = () => {{ return false; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("06b33366-0c57-44fd-9d5e-1d3d5199c0f3");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<bool> _isNeedUpdateCaseHistory;
		public virtual bool IsNeedUpdateCaseHistory {
			get {
				return (_isNeedUpdateCaseHistory ?? (_isNeedUpdateCaseHistory = () => false)).Invoke();
			}
			set {
				_isNeedUpdateCaseHistory = () => { return value; };
			}
		}

		private ProcessFlowElement _oBSWEventSubProcess4;
		public ProcessFlowElement OBSWEventSubProcess4 {
			get {
				return _oBSWEventSubProcess4 ?? (_oBSWEventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OBSWEventSubProcess4",
					SchemaElementUId = new Guid("6034f3bc-61c1-438a-b412-b8782a5a3898"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _caseSavingStartMessage5;
		public ProcessFlowElement CaseSavingStartMessage5 {
			get {
				return _caseSavingStartMessage5 ?? (_caseSavingStartMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaseSavingStartMessage5",
					SchemaElementUId = new Guid("66c8a26f-3b95-42b9-868f-3b1fb1effcef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _caseSavingScriptTask13;
		public ProcessScriptTask CaseSavingScriptTask13 {
			get {
				return _caseSavingScriptTask13 ?? (_caseSavingScriptTask13 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CaseSavingScriptTask13",
					SchemaElementUId = new Guid("aab24db1-13e3-47e4-99f5-ff65d73b7513"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CaseSavingScriptTask13Execute,
				});
			}
		}

		private ProcessFlowElement _oBSWEventSubProcess5;
		public ProcessFlowElement OBSWEventSubProcess5 {
			get {
				return _oBSWEventSubProcess5 ?? (_oBSWEventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OBSWEventSubProcess5",
					SchemaElementUId = new Guid("308addda-4d13-44dd-b670-59f35c39fff3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _caseSavedStartMessage5;
		public ProcessFlowElement CaseSavedStartMessage5 {
			get {
				return _caseSavedStartMessage5 ?? (_caseSavedStartMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaseSavedStartMessage5",
					SchemaElementUId = new Guid("0f28ba81-3a2a-4b64-adc2-7f530fbcd3a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _caseSavedScriptTask123;
		public ProcessScriptTask CaseSavedScriptTask123 {
			get {
				return _caseSavedScriptTask123 ?? (_caseSavedScriptTask123 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CaseSavedScriptTask123",
					SchemaElementUId = new Guid("b2aa1e6b-875c-485c-9547-23e9fea95161"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CaseSavedScriptTask123Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OBSWEventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { OBSWEventSubProcess4 };
			FlowElements[CaseSavingStartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavingStartMessage5 };
			FlowElements[CaseSavingScriptTask13.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavingScriptTask13 };
			FlowElements[OBSWEventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { OBSWEventSubProcess5 };
			FlowElements[CaseSavedStartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavedStartMessage5 };
			FlowElements[CaseSavedScriptTask123.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavedScriptTask123 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OBSWEventSubProcess4":
						break;
					case "CaseSavingStartMessage5":
						e.Context.QueueTasks.Enqueue("CaseSavingScriptTask13");
						break;
					case "CaseSavingScriptTask13":
						break;
					case "OBSWEventSubProcess5":
						break;
					case "CaseSavedStartMessage5":
						e.Context.QueueTasks.Enqueue("CaseSavedScriptTask123");
						break;
					case "CaseSavedScriptTask123":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CaseSavingStartMessage5");
			ActivatedEventElements.Add("CaseSavedStartMessage5");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OBSWEventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "CaseSavingStartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavingStartMessage5";
					result = CaseSavingStartMessage5.Execute(context);
					break;
				case "CaseSavingScriptTask13":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavingScriptTask13";
					result = CaseSavingScriptTask13.Execute(context, CaseSavingScriptTask13Execute);
					break;
				case "OBSWEventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "CaseSavedStartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavedStartMessage5";
					result = CaseSavedStartMessage5.Execute(context);
					break;
				case "CaseSavedScriptTask123":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavedScriptTask123";
					result = CaseSavedScriptTask123.Execute(context, CaseSavedScriptTask123Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool CaseSavingScriptTask13Execute(ProcessExecutingContext context) {
			OnCaseSaving();
			return true;
		}

		public virtual bool CaseSavedScriptTask123Execute(ProcessExecutingContext context) {
			OnCaseSaved();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Case_OBSW_TerrasoftSaving":
							if (ActivatedEventElements.Contains("CaseSavingStartMessage5")) {
							context.QueueTasks.Enqueue("CaseSavingStartMessage5");
							ProcessQueue(context);
							return;
						}
						break;
					case "Case_OBSW_TerrasoftSaved":
							if (ActivatedEventElements.Contains("CaseSavedStartMessage5")) {
							context.QueueTasks.Enqueue("CaseSavedStartMessage5");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Case_OBSWEventsProcess

	/// <exclude/>
	public class Case_OBSWEventsProcess : Case_OBSWEventsProcess<Case_OBSW_Terrasoft>
	{

		public Case_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Case_OBSWEventsProcess

	public partial class Case_OBSWEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnCaseSaving() {
			CheckIsNeedUpdateCaseHistory();
			UpdateIsActive();
		}

		public virtual void UpdateIsActive() {
			var entity = Entity;
			Guid closedStatus = CaseConsts.CaseStatusClosedId;
			bool currentIsActive = entity.GetTypedColumnValue<bool>("IsActive");
			Guid currentStatus = entity.GetTypedColumnValue<Guid>("StatusId");
			if (!currentIsActive || currentStatus.Equals(Guid.Empty)) {
				return;
			}
			foreach(var column in entity.GetChangedColumnValues()) { 
				if (column.Name == "StatusId" && currentStatus.Equals(closedStatus)) {
					entity.SetColumnValue("IsActive", false);
					currentIsActive = false;
					break;
				}
			}
			if (currentIsActive) {
				Guid currentOwner = entity.GetTypedColumnValue<Guid>("OwnerId");
				bool oldIsActive = entity.GetTypedOldColumnValue<bool>("IsActive");
				Guid oldOwner = entity.GetTypedOldColumnValue<Guid>("OwnerId");
				if (!currentOwner.Equals(Guid.Empty) && (!oldIsActive || !currentOwner.Equals(oldOwner))) {
					var update = new Update(UserConnection, entity.SchemaName)
							.Set("IsActive", Column.Const("0"))
						.Where("OwnerId")
							.IsEqual(Column.Const(currentOwner))
						.And("Id").IsNotEqual(Column.Const(entity.PrimaryColumnValue))
						.And("IsActive").IsEqual(Column.Const("1"));
					update.Execute();
				}
			}
		}

		public virtual void UpdateCaseHistory() {
			if (IsNeedUpdateCaseHistory) {
				var entity = Entity;
				bool currentIsActive = entity.GetTypedColumnValue<bool>("IsActive");
				Guid currentStatus = entity.GetTypedColumnValue<Guid>("StatusId");
				var insert = new Insert(UserConnection).Into("CaseHistory").
						Set("CaseId", Column.Parameter(entity.PrimaryColumnValue)).
						Set("CaseStatusId", Column.Parameter(currentStatus)).
						Set("IsActive", Column.Parameter(currentIsActive)).
						Set("ChangesDate", Column.Parameter(DateTime.UtcNow)) as Insert;
				insert.Execute();
			}
		}

		public virtual void OnCaseSaved() {
			UpdateCaseHistory();
		}

		public virtual void CheckIsNeedUpdateCaseHistory() {
			IsNeedUpdateCaseHistory = false;
			var entity = Entity;
			foreach(var column in entity.GetChangedColumnValues()) { 
				if (column.Name == "IsActive") {
					bool currentIsActive = entity.GetTypedColumnValue<bool>("IsActive");
					bool oldIsActive = entity.GetTypedOldColumnValue<bool>("IsActive");
					IsNeedUpdateCaseHistory = currentIsActive != oldIsActive;
					break;
				}
			}
		}

		#endregion

	}

	#endregion

}

