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

	#region Class: Job_CrtCoreBase_TerrasoftSchema

	/// <exclude/>
	public class Job_CrtCoreBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public Job_CrtCoreBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Job_CrtCoreBase_TerrasoftSchema(Job_CrtCoreBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Job_CrtCoreBase_TerrasoftSchema(Job_CrtCoreBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6");
			RealUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6");
			Name = "Job_CrtCoreBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Job_CrtCoreBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Job_CrtCoreBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Job_CrtCoreBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Job_CrtCoreBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6"));
		}

		#endregion

	}

	#endregion

	#region Class: Job_CrtCoreBase_Terrasoft

	/// <summary>
	/// Job title.
	/// </summary>
	public class Job_CrtCoreBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Job_CrtCoreBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Job_CrtCoreBase_Terrasoft";
		}

		public Job_CrtCoreBase_Terrasoft(Job_CrtCoreBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Job_CrtCoreBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Job_CrtCoreBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Job_CrtCoreBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Job_CrtCoreBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Job_CrtCoreBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Job_CrtCoreBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Job_CrtCoreBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Job_CrtCoreBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Job_CrtCoreBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Job_CrtCoreBaseEventsProcess

	/// <exclude/>
	public partial class Job_CrtCoreBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : Job_CrtCoreBase_Terrasoft
	{

		public Job_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Job_CrtCoreBaseEventsProcess";
			SchemaUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6");
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

	#region Class: Job_CrtCoreBaseEventsProcess

	/// <exclude/>
	public class Job_CrtCoreBaseEventsProcess : Job_CrtCoreBaseEventsProcess<Job_CrtCoreBase_Terrasoft>
	{

		public Job_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Job_CrtCoreBaseEventsProcess

	public partial class Job_CrtCoreBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

}

