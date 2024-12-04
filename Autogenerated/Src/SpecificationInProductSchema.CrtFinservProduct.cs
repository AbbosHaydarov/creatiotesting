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

	#region Class: SpecificationInProductSchema

	/// <exclude/>
	public class SpecificationInProductSchema : Terrasoft.Configuration.SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationInProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInProductSchema(SpecificationInProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInProductSchema(SpecificationInProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c97edbbb-4e3a-4ddf-b2be-41e891823eba");
			Name = "SpecificationInProduct";
			ParentSchemaUId = new Guid("5fa8a10e-372c-4d18-9709-04b9932d5509");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new SpecificationInProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInProduct_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c97edbbb-4e3a-4ddf-b2be-41e891823eba"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInProduct

	/// <summary>
	/// Product parameter.
	/// </summary>
	public class SpecificationInProduct : Terrasoft.Configuration.SpecificationInProduct_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public SpecificationInProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInProduct";
		}

		public SpecificationInProduct(SpecificationInProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInProduct_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInProductDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecificationInProductDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecificationInProductInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationInProductInserting", e);
			Saved += (s, e) => ThrowEvent("SpecificationInProductSaved", e);
			Saving += (s, e) => ThrowEvent("SpecificationInProductSaving", e);
			Validating += (s, e) => ThrowEvent("SpecificationInProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class SpecificationInProduct_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInProduct_CrtProductCatalogueEventsProcess<TEntity> where TEntity : SpecificationInProduct
	{

		public SpecificationInProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInProduct_CrtFinservProductEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c97edbbb-4e3a-4ddf-b2be-41e891823eba");
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

	#region Class: SpecificationInProduct_CrtFinservProductEventsProcess

	/// <exclude/>
	public class SpecificationInProduct_CrtFinservProductEventsProcess : SpecificationInProduct_CrtFinservProductEventsProcess<SpecificationInProduct>
	{

		public SpecificationInProduct_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInProduct_CrtFinservProductEventsProcess

	public partial class SpecificationInProduct_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationInProductEventsProcess

	/// <exclude/>
	public class SpecificationInProductEventsProcess : SpecificationInProduct_CrtFinservProductEventsProcess
	{

		public SpecificationInProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

