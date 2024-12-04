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

	#region Class: SpecificationInObject_CrtFinservSpecification_TerrasoftSchema

	/// <exclude/>
	public class SpecificationInObject_CrtFinservSpecification_TerrasoftSchema : Terrasoft.Configuration.SpecificationInObject_CrtSpecification_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationInObject_CrtFinservSpecification_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInObject_CrtFinservSpecification_TerrasoftSchema(SpecificationInObject_CrtFinservSpecification_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInObject_CrtFinservSpecification_TerrasoftSchema(SpecificationInObject_CrtFinservSpecification_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e77481c7-e214-4a05-acde-8f85e24d50fd");
			Name = "SpecificationInObject_CrtFinservSpecification_Terrasoft";
			ParentSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateStringValueColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateStringValueColumn() {
			EntitySchemaColumn column = base.CreateStringValueColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("LongText");
			column.ModifiedInSchemaUId = new Guid("e77481c7-e214-4a05-acde-8f85e24d50fd");
			column.CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationInObject_CrtFinservSpecification_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInObject_CrtFinservSpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInObject_CrtFinservSpecification_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInObject_CrtFinservSpecification_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e77481c7-e214-4a05-acde-8f85e24d50fd"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject_CrtFinservSpecification_Terrasoft

	/// <summary>
	/// Feature in object.
	/// </summary>
	public class SpecificationInObject_CrtFinservSpecification_Terrasoft : Terrasoft.Configuration.SpecificationInObject_CrtSpecification_Terrasoft
	{

		#region Constructors: Public

		public SpecificationInObject_CrtFinservSpecification_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInObject_CrtFinservSpecification_Terrasoft";
		}

		public SpecificationInObject_CrtFinservSpecification_Terrasoft(SpecificationInObject_CrtFinservSpecification_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInObject_CrtFinservSpecificationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInObject_CrtFinservSpecification_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecificationInObject_CrtFinservSpecification_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecificationInObject_CrtFinservSpecification_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("SpecificationInObject_CrtFinservSpecification_TerrasoftSaved", e);
			Validating += (s, e) => ThrowEvent("SpecificationInObject_CrtFinservSpecification_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInObject_CrtFinservSpecification_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject_CrtFinservSpecificationEventsProcess

	/// <exclude/>
	public partial class SpecificationInObject_CrtFinservSpecificationEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInObject_CrtSpecificationEventsProcess<TEntity> where TEntity : SpecificationInObject_CrtFinservSpecification_Terrasoft
	{

		public SpecificationInObject_CrtFinservSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInObject_CrtFinservSpecificationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e77481c7-e214-4a05-acde-8f85e24d50fd");
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

	#region Class: SpecificationInObject_CrtFinservSpecificationEventsProcess

	/// <exclude/>
	public class SpecificationInObject_CrtFinservSpecificationEventsProcess : SpecificationInObject_CrtFinservSpecificationEventsProcess<SpecificationInObject_CrtFinservSpecification_Terrasoft>
	{

		public SpecificationInObject_CrtFinservSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInObject_CrtFinservSpecificationEventsProcess

	public partial class SpecificationInObject_CrtFinservSpecificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

