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

	#region Class: SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.SpecificationInProduct_CrtProductSpecification_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema(SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema(SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0839cde0-b794-402a-97fb-6ceb3b29655d");
			Name = "SpecificationInProduct_CrtProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("5fa8a10e-372c-4d18-9709-04b9932d5509");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2dc6b63d-3add-4bb9-a81e-0eb90b27dc0e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			column.ModifiedInSchemaUId = new Guid("0839cde0-b794-402a-97fb-6ceb3b29655d");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationInProduct_CrtProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInProduct_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInProduct_CrtProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0839cde0-b794-402a-97fb-6ceb3b29655d"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInProduct_CrtProductCatalogue_Terrasoft

	/// <summary>
	/// Product feature.
	/// </summary>
	public class SpecificationInProduct_CrtProductCatalogue_Terrasoft : Terrasoft.Configuration.SpecificationInProduct_CrtProductSpecification_Terrasoft
	{

		#region Constructors: Public

		public SpecificationInProduct_CrtProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInProduct_CrtProductCatalogue_Terrasoft";
		}

		public SpecificationInProduct_CrtProductCatalogue_Terrasoft(SpecificationInProduct_CrtProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInProduct_CrtProductCatalogueEventsProcess(UserConnection);
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
			return new SpecificationInProduct_CrtProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInProduct_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class SpecificationInProduct_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInProduct_CrtProductSpecificationEventsProcess<TEntity> where TEntity : SpecificationInProduct_CrtProductCatalogue_Terrasoft
	{

		public SpecificationInProduct_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInProduct_CrtProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0839cde0-b794-402a-97fb-6ceb3b29655d");
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

	#region Class: SpecificationInProduct_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class SpecificationInProduct_CrtProductCatalogueEventsProcess : SpecificationInProduct_CrtProductCatalogueEventsProcess<SpecificationInProduct_CrtProductCatalogue_Terrasoft>
	{

		public SpecificationInProduct_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInProduct_CrtProductCatalogueEventsProcess

	public partial class SpecificationInProduct_CrtProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

