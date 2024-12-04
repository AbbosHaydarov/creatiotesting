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

	#region Class: FinIndicatorInTagSchema

	/// <exclude/>
	public class FinIndicatorInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public FinIndicatorInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinIndicatorInTagSchema(FinIndicatorInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinIndicatorInTagSchema(FinIndicatorInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("604da837-3607-4bc7-a4d2-9a255af2ab3e");
			RealUId = new Guid("604da837-3607-4bc7-a4d2-9a255af2ab3e");
			Name = "FinIndicatorInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("210a14ff-406c-49ae-8ce4-dafcac50a46b");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("604da837-3607-4bc7-a4d2-9a255af2ab3e");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("11b638a3-36b8-447a-8573-54e9fc96403b");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityName";
			column.ModifiedInSchemaUId = new Guid("604da837-3607-4bc7-a4d2-9a255af2ab3e");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinIndicatorInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinIndicatorInTag_FinancialIndicatorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinIndicatorInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinIndicatorInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("604da837-3607-4bc7-a4d2-9a255af2ab3e"));
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorInTag

	/// <summary>
	/// Financial indicators section record tag.
	/// </summary>
	public class FinIndicatorInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public FinIndicatorInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinIndicatorInTag";
		}

		public FinIndicatorInTag(FinIndicatorInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinIndicatorInTag_FinancialIndicatorEventsProcess(UserConnection);
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
			return new FinIndicatorInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorInTag_FinancialIndicatorEventsProcess

	/// <exclude/>
	public partial class FinIndicatorInTag_FinancialIndicatorEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinIndicatorInTag
	{

		public FinIndicatorInTag_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinIndicatorInTag_FinancialIndicatorEventsProcess";
			SchemaUId = new Guid("604da837-3607-4bc7-a4d2-9a255af2ab3e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("604da837-3607-4bc7-a4d2-9a255af2ab3e");
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

	#region Class: FinIndicatorInTag_FinancialIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicatorInTag_FinancialIndicatorEventsProcess : FinIndicatorInTag_FinancialIndicatorEventsProcess<FinIndicatorInTag>
	{

		public FinIndicatorInTag_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinIndicatorInTag_FinancialIndicatorEventsProcess

	public partial class FinIndicatorInTag_FinancialIndicatorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinIndicatorInTagEventsProcess

	/// <exclude/>
	public class FinIndicatorInTagEventsProcess : FinIndicatorInTag_FinancialIndicatorEventsProcess
	{

		public FinIndicatorInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

