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

	#region Class: OpportunityCondition_CrtFinservProduct_TerrasoftSchema

	/// <exclude/>
	public class OpportunityCondition_CrtFinservProduct_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OpportunityCondition_CrtFinservProduct_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityCondition_CrtFinservProduct_TerrasoftSchema(OpportunityCondition_CrtFinservProduct_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityCondition_CrtFinservProduct_TerrasoftSchema(OpportunityCondition_CrtFinservProduct_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2");
			RealUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2");
			Name = "OpportunityCondition_CrtFinservProduct_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a");
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
			if (Columns.FindByUId(new Guid("0407acc1-845f-4bee-ad7a-7c82b5c5886b")) == null) {
				Columns.Add(CreateProductConditionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a2975fc0-5e7e-412e-821b-18821a2d8fb4"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"),
				ModifiedInSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"),
				CreatedInPackageId = new Guid("b79a0c10-67f6-4888-83a9-7cfa6a8df39a")
			};
		}

		protected virtual EntitySchemaColumn CreateProductConditionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0407acc1-845f-4bee-ad7a-7c82b5c5886b"),
				Name = @"ProductCondition",
				ReferenceSchemaUId = new Guid("eecaf746-82f5-428e-947e-169fce01cbd9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"),
				ModifiedInSchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"),
				CreatedInPackageId = new Guid("8348d424-5381-454b-b3a5-294bd3fbfdd9")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityCondition_CrtFinservProduct_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityCondition_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityCondition_CrtFinservProduct_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityCondition_CrtFinservProduct_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCondition_CrtFinservProduct_Terrasoft

	/// <summary>
	/// Opportunity condition.
	/// </summary>
	public class OpportunityCondition_CrtFinservProduct_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OpportunityCondition_CrtFinservProduct_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityCondition_CrtFinservProduct_Terrasoft";
		}

		public OpportunityCondition_CrtFinservProduct_Terrasoft(OpportunityCondition_CrtFinservProduct_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <exclude/>
		public Guid ProductConditionId {
			get {
				return GetTypedColumnValue<Guid>("ProductConditionId");
			}
			set {
				SetColumnValue("ProductConditionId", value);
				_productCondition = null;
			}
		}

		/// <exclude/>
		public string ProductConditionName {
			get {
				return GetTypedColumnValue<string>("ProductConditionName");
			}
			set {
				SetColumnValue("ProductConditionName", value);
				if (_productCondition != null) {
					_productCondition.Name = value;
				}
			}
		}

		private ProductCondition _productCondition;
		/// <summary>
		/// Product conditions.
		/// </summary>
		public ProductCondition ProductCondition {
			get {
				return _productCondition ??
					(_productCondition = LookupColumnEntities.GetEntity("ProductCondition") as ProductCondition);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityCondition_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityCondition_CrtFinservProduct_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class OpportunityCondition_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : OpportunityCondition_CrtFinservProduct_Terrasoft
	{

		public OpportunityCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityCondition_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ffcf222c-312d-4de8-8561-ab3f4c998fd2");
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

	#region Class: OpportunityCondition_CrtFinservProductEventsProcess

	/// <exclude/>
	public class OpportunityCondition_CrtFinservProductEventsProcess : OpportunityCondition_CrtFinservProductEventsProcess<OpportunityCondition_CrtFinservProduct_Terrasoft>
	{

		public OpportunityCondition_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

