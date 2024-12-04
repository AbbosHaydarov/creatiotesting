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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: FinIndicatorTagSchema

	/// <exclude/>
	public class FinIndicatorTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public FinIndicatorTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinIndicatorTagSchema(FinIndicatorTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinIndicatorTagSchema(FinIndicatorTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("210a14ff-406c-49ae-8ce4-dafcac50a46b");
			RealUId = new Guid("210a14ff-406c-49ae-8ce4-dafcac50a46b");
			Name = "FinIndicatorTag";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dfe2c6b5-61e8-4e57-95ae-a3c34fa0908f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinIndicatorTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinIndicatorTag_FinancialIndicatorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinIndicatorTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinIndicatorTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("210a14ff-406c-49ae-8ce4-dafcac50a46b"));
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorTag

	/// <summary>
	/// Financial indicators section tag.
	/// </summary>
	public class FinIndicatorTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public FinIndicatorTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinIndicatorTag";
		}

		public FinIndicatorTag(FinIndicatorTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinIndicatorTag_FinancialIndicatorEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("FinIndicatorTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("FinIndicatorTagInserted", e);
			Inserting += (s, e) => ThrowEvent("FinIndicatorTagInserting", e);
			Saved += (s, e) => ThrowEvent("FinIndicatorTagSaved", e);
			Saving += (s, e) => ThrowEvent("FinIndicatorTagSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinIndicatorTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinIndicatorTag_FinancialIndicatorEventsProcess

	/// <exclude/>
	public partial class FinIndicatorTag_FinancialIndicatorEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : FinIndicatorTag
	{

		public FinIndicatorTag_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinIndicatorTag_FinancialIndicatorEventsProcess";
			SchemaUId = new Guid("210a14ff-406c-49ae-8ce4-dafcac50a46b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("210a14ff-406c-49ae-8ce4-dafcac50a46b");
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

	#region Class: FinIndicatorTag_FinancialIndicatorEventsProcess

	/// <exclude/>
	public class FinIndicatorTag_FinancialIndicatorEventsProcess : FinIndicatorTag_FinancialIndicatorEventsProcess<FinIndicatorTag>
	{

		public FinIndicatorTag_FinancialIndicatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinIndicatorTag_FinancialIndicatorEventsProcess

	public partial class FinIndicatorTag_FinancialIndicatorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinIndicatorTagEventsProcess

	/// <exclude/>
	public class FinIndicatorTagEventsProcess : FinIndicatorTag_FinancialIndicatorEventsProcess
	{

		public FinIndicatorTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

