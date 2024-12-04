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

	#region Class: Specification_CrtFinservSpecification_TerrasoftSchema

	/// <exclude/>
	public class Specification_CrtFinservSpecification_TerrasoftSchema : Terrasoft.Configuration.Specification_CrtSpecification_TerrasoftSchema
	{

		#region Constructors: Public

		public Specification_CrtFinservSpecification_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Specification_CrtFinservSpecification_TerrasoftSchema(Specification_CrtFinservSpecification_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Specification_CrtFinservSpecification_TerrasoftSchema(Specification_CrtFinservSpecification_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6914c0ed-9880-4528-8bba-42c391c8da3c");
			Name = "Specification_CrtFinservSpecification_Terrasoft";
			ParentSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
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
			return new Specification_CrtFinservSpecification_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Specification_CrtFinservSpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Specification_CrtFinservSpecification_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Specification_CrtFinservSpecification_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6914c0ed-9880-4528-8bba-42c391c8da3c"));
		}

		#endregion

	}

	#endregion

	#region Class: Specification_CrtFinservSpecification_Terrasoft

	/// <summary>
	/// Parameter.
	/// </summary>
	public class Specification_CrtFinservSpecification_Terrasoft : Terrasoft.Configuration.Specification_CrtSpecification_Terrasoft
	{

		#region Constructors: Public

		public Specification_CrtFinservSpecification_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Specification_CrtFinservSpecification_Terrasoft";
		}

		public Specification_CrtFinservSpecification_Terrasoft(Specification_CrtFinservSpecification_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Specification_CrtFinservSpecificationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Specification_CrtFinservSpecification_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Specification_CrtFinservSpecification_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Specification_CrtFinservSpecification_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Specification_CrtFinservSpecification_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Specification_CrtFinservSpecification_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Specification_CrtFinservSpecification_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Specification_CrtFinservSpecification_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Specification_CrtFinservSpecificationEventsProcess

	/// <exclude/>
	public partial class Specification_CrtFinservSpecificationEventsProcess<TEntity> : Terrasoft.Configuration.Specification_CrtSpecificationEventsProcess<TEntity> where TEntity : Specification_CrtFinservSpecification_Terrasoft
	{

		public Specification_CrtFinservSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Specification_CrtFinservSpecificationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6914c0ed-9880-4528-8bba-42c391c8da3c");
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

	#region Class: Specification_CrtFinservSpecificationEventsProcess

	/// <exclude/>
	public class Specification_CrtFinservSpecificationEventsProcess : Specification_CrtFinservSpecificationEventsProcess<Specification_CrtFinservSpecification_Terrasoft>
	{

		public Specification_CrtFinservSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Specification_CrtFinservSpecificationEventsProcess

	public partial class Specification_CrtFinservSpecificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

