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

	#region Class: SpecificationType_CrtSpecification_TerrasoftSchema

	/// <exclude/>
	public class SpecificationType_CrtSpecification_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SpecificationType_CrtSpecification_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationType_CrtSpecification_TerrasoftSchema(SpecificationType_CrtSpecification_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationType_CrtSpecification_TerrasoftSchema(SpecificationType_CrtSpecification_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			RealUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			Name = "SpecificationType_CrtSpecification_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationType_CrtSpecification_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationType_CrtSpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationType_CrtSpecification_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationType_CrtSpecification_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("787ae6a1-f727-4c4e-964a-c09e24083810"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationType_CrtSpecification_Terrasoft

	/// <summary>
	/// Feature type.
	/// </summary>
	public class SpecificationType_CrtSpecification_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SpecificationType_CrtSpecification_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationType_CrtSpecification_Terrasoft";
		}

		public SpecificationType_CrtSpecification_Terrasoft(SpecificationType_CrtSpecification_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationType_CrtSpecificationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationType_CrtSpecification_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationType_CrtSpecification_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("SpecificationType_CrtSpecification_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationType_CrtSpecification_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationType_CrtSpecificationEventsProcess

	/// <exclude/>
	public partial class SpecificationType_CrtSpecificationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : SpecificationType_CrtSpecification_Terrasoft
	{

		public SpecificationType_CrtSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationType_CrtSpecificationEventsProcess";
			SchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
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

	#region Class: SpecificationType_CrtSpecificationEventsProcess

	/// <exclude/>
	public class SpecificationType_CrtSpecificationEventsProcess : SpecificationType_CrtSpecificationEventsProcess<SpecificationType_CrtSpecification_Terrasoft>
	{

		public SpecificationType_CrtSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationType_CrtSpecificationEventsProcess

	public partial class SpecificationType_CrtSpecificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

