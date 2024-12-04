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

	#region Class: BulkEmail_CrtBulkEmailEngine_TerrasoftSchema

	/// <exclude/>
	public class BulkEmail_CrtBulkEmailEngine_TerrasoftSchema : Terrasoft.Configuration.BulkEmail_CrtBulkEmail_TerrasoftSchema
	{

		#region Constructors: Public

		public BulkEmail_CrtBulkEmailEngine_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmail_CrtBulkEmailEngine_TerrasoftSchema(BulkEmail_CrtBulkEmailEngine_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmail_CrtBulkEmailEngine_TerrasoftSchema(BulkEmail_CrtBulkEmailEngine_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("233b6ea7-2f91-4a29-aff2-2898f4b520c0");
			Name = "BulkEmail_CrtBulkEmailEngine_Terrasoft";
			ParentSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f263d051-828e-b8b1-7c0e-14a99c5e68af")) == null) {
				Columns.Add(CreateEmailDesignerTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEmailDesignerTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f263d051-828e-b8b1-7c0e-14a99c5e68af"),
				Name = @"EmailDesignerType",
				ReferenceSchemaUId = new Guid("85292d56-edcf-453d-a626-777f267d81a4"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("233b6ea7-2f91-4a29-aff2-2898f4b520c0"),
				ModifiedInSchemaUId = new Guid("233b6ea7-2f91-4a29-aff2-2898f4b520c0"),
				CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmail_CrtBulkEmailEngine_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmail_CrtBulkEmailEngineEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmail_CrtBulkEmailEngine_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmail_CrtBulkEmailEngine_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("233b6ea7-2f91-4a29-aff2-2898f4b520c0"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail_CrtBulkEmailEngine_Terrasoft

	/// <summary>
	/// Bulk email.
	/// </summary>
	public class BulkEmail_CrtBulkEmailEngine_Terrasoft : Terrasoft.Configuration.BulkEmail_CrtBulkEmail_Terrasoft
	{

		#region Constructors: Public

		public BulkEmail_CrtBulkEmailEngine_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmail_CrtBulkEmailEngine_Terrasoft";
		}

		public BulkEmail_CrtBulkEmailEngine_Terrasoft(BulkEmail_CrtBulkEmailEngine_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EmailDesignerTypeId {
			get {
				return GetTypedColumnValue<Guid>("EmailDesignerTypeId");
			}
			set {
				SetColumnValue("EmailDesignerTypeId", value);
				_emailDesignerType = null;
			}
		}

		/// <exclude/>
		public string EmailDesignerTypeName {
			get {
				return GetTypedColumnValue<string>("EmailDesignerTypeName");
			}
			set {
				SetColumnValue("EmailDesignerTypeName", value);
				if (_emailDesignerType != null) {
					_emailDesignerType.Name = value;
				}
			}
		}

		private EmailDesignerType _emailDesignerType;
		/// <summary>
		/// Email designer type.
		/// </summary>
		public EmailDesignerType EmailDesignerType {
			get {
				return _emailDesignerType ??
					(_emailDesignerType = LookupColumnEntities.GetEntity("EmailDesignerType") as EmailDesignerType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmail_CrtBulkEmailEngineEventsProcess(UserConnection);
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
			return new BulkEmail_CrtBulkEmailEngine_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail_CrtBulkEmailEngineEventsProcess

	/// <exclude/>
	public partial class BulkEmail_CrtBulkEmailEngineEventsProcess<TEntity> : Terrasoft.Configuration.BulkEmail_CrtBulkEmailEventsProcess<TEntity> where TEntity : BulkEmail_CrtBulkEmailEngine_Terrasoft
	{

		public BulkEmail_CrtBulkEmailEngineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmail_CrtBulkEmailEngineEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("233b6ea7-2f91-4a29-aff2-2898f4b520c0");
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

	#region Class: BulkEmail_CrtBulkEmailEngineEventsProcess

	/// <exclude/>
	public class BulkEmail_CrtBulkEmailEngineEventsProcess : BulkEmail_CrtBulkEmailEngineEventsProcess<BulkEmail_CrtBulkEmailEngine_Terrasoft>
	{

		public BulkEmail_CrtBulkEmailEngineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmail_CrtBulkEmailEngineEventsProcess

	public partial class BulkEmail_CrtBulkEmailEngineEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

