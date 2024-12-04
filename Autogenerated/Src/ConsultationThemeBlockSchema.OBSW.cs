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

	#region Class: ConsultationThemeBlockSchema

	/// <exclude/>
	public class ConsultationThemeBlockSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public ConsultationThemeBlockSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ConsultationThemeBlockSchema(ConsultationThemeBlockSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ConsultationThemeBlockSchema(ConsultationThemeBlockSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802");
			RealUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802");
			Name = "ConsultationThemeBlock";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da");
			IsDBView = false;
			UseDenyRecordRights = false;
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
			if (Columns.FindByUId(new Guid("e3770871-c395-4c59-91a4-84dd1deeefd8")) == null) {
				Columns.Add(CreateUseInOBSWColumn());
			}
			if (Columns.FindByUId(new Guid("cdf4b3c9-6879-469d-988d-fea04247a98e")) == null) {
				Columns.Add(CreateCaptionColorColumn());
			}
			if (Columns.FindByUId(new Guid("5e9bc9c3-1fac-45ef-b2e8-0dc57178ca30")) == null) {
				Columns.Add(CreateItemColorColumn());
			}
			if (Columns.FindByUId(new Guid("b2a875db-a2c9-4514-b279-28ca45594aff")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4847bf18-149e-4c1a-9c9e-84d19654a94d"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				ModifiedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateUseInOBSWColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e3770871-c395-4c59-91a4-84dd1deeefd8"),
				Name = @"UseInOBSW",
				CreatedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				ModifiedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("cdf4b3c9-6879-469d-988d-fea04247a98e"),
				Name = @"CaptionColor",
				CreatedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				ModifiedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"#64b8df"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateItemColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5e9bc9c3-1fac-45ef-b2e8-0dc57178ca30"),
				Name = @"ItemColor",
				CreatedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				ModifiedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"#d4ebf6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b2a875db-a2c9-4514-b279-28ca45594aff"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				ModifiedInSchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"),
				CreatedInPackageId = new Guid("daa81edd-ed0e-404c-8139-41a8d7bd00da")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ConsultationThemeBlock(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ConsultationThemeBlock_OBSWEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ConsultationThemeBlockSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ConsultationThemeBlockSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802"));
		}

		#endregion

	}

	#endregion

	#region Class: ConsultationThemeBlock

	/// <summary>
	/// Consultation themes block.
	/// </summary>
	public class ConsultationThemeBlock : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public ConsultationThemeBlock(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ConsultationThemeBlock";
		}

		public ConsultationThemeBlock(ConsultationThemeBlock source)
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

		/// <summary>
		/// Show in the consultations panel.
		/// </summary>
		public bool UseInOBSW {
			get {
				return GetTypedColumnValue<bool>("UseInOBSW");
			}
			set {
				SetColumnValue("UseInOBSW", value);
			}
		}

		/// <summary>
		/// Heading color.
		/// </summary>
		public string CaptionColor {
			get {
				return GetTypedColumnValue<string>("CaptionColor");
			}
			set {
				SetColumnValue("CaptionColor", value);
			}
		}

		/// <summary>
		/// Block item color.
		/// </summary>
		public string ItemColor {
			get {
				return GetTypedColumnValue<string>("ItemColor");
			}
			set {
				SetColumnValue("ItemColor", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ConsultationThemeBlock_OBSWEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("ConsultationThemeBlockValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConsultationThemeBlock(this);
		}

		#endregion

	}

	#endregion

	#region Class: ConsultationThemeBlock_OBSWEventsProcess

	/// <exclude/>
	public partial class ConsultationThemeBlock_OBSWEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_CrtCoreBaseEventsProcess<TEntity> where TEntity : ConsultationThemeBlock
	{

		public ConsultationThemeBlock_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConsultationThemeBlock_OBSWEventsProcess";
			SchemaUId = new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8618e5fe-a93e-461c-b7f1-aae7ad98a802");
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

	#region Class: ConsultationThemeBlock_OBSWEventsProcess

	/// <exclude/>
	public class ConsultationThemeBlock_OBSWEventsProcess : ConsultationThemeBlock_OBSWEventsProcess<ConsultationThemeBlock>
	{

		public ConsultationThemeBlock_OBSWEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConsultationThemeBlock_OBSWEventsProcess

	public partial class ConsultationThemeBlock_OBSWEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ConsultationThemeBlockEventsProcess

	/// <exclude/>
	public class ConsultationThemeBlockEventsProcess : ConsultationThemeBlock_OBSWEventsProcess
	{

		public ConsultationThemeBlockEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

