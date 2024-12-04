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

	#region Class: SpecInherited_CrtFinservProduct_TerrasoftSchema

	/// <exclude/>
	public class SpecInherited_CrtFinservProduct_TerrasoftSchema : Terrasoft.Configuration.BaseSpecValueSchema
	{

		#region Constructors: Public

		public SpecInherited_CrtFinservProduct_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecInherited_CrtFinservProduct_TerrasoftSchema(SpecInherited_CrtFinservProduct_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecInherited_CrtFinservProduct_TerrasoftSchema(SpecInherited_CrtFinservProduct_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a");
			RealUId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a");
			Name = "SpecInherited_CrtFinservProduct_Terrasoft";
			ParentSchemaUId = new Guid("8a31cfd1-f7a1-4167-9b29-3967b95573f3");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("987187cb-d3a2-4343-8017-5ae772dc5fbe")) == null) {
				Columns.Add(CreateSpecTableInheritedXColumn());
			}
			if (Columns.FindByUId(new Guid("6efce3c1-c13d-4d12-a802-bf8485debc90")) == null) {
				Columns.Add(CreateSpecTableInheritedYColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSpecTableInheritedXColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("987187cb-d3a2-4343-8017-5ae772dc5fbe"),
				Name = @"SpecTableInheritedX",
				ReferenceSchemaUId = new Guid("01e20a43-d408-453c-9730-ae8dab8bae69"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a"),
				ModifiedInSchemaUId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecTableInheritedYColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6efce3c1-c13d-4d12-a802-bf8485debc90"),
				Name = @"SpecTableInheritedY",
				ReferenceSchemaUId = new Guid("01e20a43-d408-453c-9730-ae8dab8bae69"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a"),
				ModifiedInSchemaUId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a"),
				CreatedInPackageId = new Guid("3c6cde7b-c93e-4240-bbfc-6d99594246c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecInherited_CrtFinservProduct_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecInherited_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecInherited_CrtFinservProduct_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecInherited_CrtFinservProduct_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecInherited_CrtFinservProduct_Terrasoft

	/// <summary>
	/// Inherited specification value.
	/// </summary>
	public class SpecInherited_CrtFinservProduct_Terrasoft : Terrasoft.Configuration.BaseSpecValue
	{

		#region Constructors: Public

		public SpecInherited_CrtFinservProduct_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecInherited_CrtFinservProduct_Terrasoft";
		}

		public SpecInherited_CrtFinservProduct_Terrasoft(SpecInherited_CrtFinservProduct_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SpecTableInheritedXId {
			get {
				return GetTypedColumnValue<Guid>("SpecTableInheritedXId");
			}
			set {
				SetColumnValue("SpecTableInheritedXId", value);
				_specTableInheritedX = null;
			}
		}

		private SpecTableInherited _specTableInheritedX;
		/// <summary>
		/// Table part inherited parameter value for X axis.
		/// </summary>
		public SpecTableInherited SpecTableInheritedX {
			get {
				return _specTableInheritedX ??
					(_specTableInheritedX = LookupColumnEntities.GetEntity("SpecTableInheritedX") as SpecTableInherited);
			}
		}

		/// <exclude/>
		public Guid SpecTableInheritedYId {
			get {
				return GetTypedColumnValue<Guid>("SpecTableInheritedYId");
			}
			set {
				SetColumnValue("SpecTableInheritedYId", value);
				_specTableInheritedY = null;
			}
		}

		private SpecTableInherited _specTableInheritedY;
		/// <summary>
		/// Table part inherited parameter value for Y axis.
		/// </summary>
		public SpecTableInherited SpecTableInheritedY {
			get {
				return _specTableInheritedY ??
					(_specTableInheritedY = LookupColumnEntities.GetEntity("SpecTableInheritedY") as SpecTableInherited);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecInherited_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecInherited_CrtFinservProduct_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecInherited_CrtFinservProduct_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecInherited_CrtFinservProduct_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecInherited_CrtFinservProduct_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("SpecInherited_CrtFinservProduct_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SpecInherited_CrtFinservProduct_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SpecInherited_CrtFinservProduct_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecInherited_CrtFinservProduct_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInherited_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class SpecInherited_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseSpecValue_CrtFinservProductEventsProcess<TEntity> where TEntity : SpecInherited_CrtFinservProduct_Terrasoft
	{

		public SpecInherited_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecInherited_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a");
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

	#region Class: SpecInherited_CrtFinservProductEventsProcess

	/// <exclude/>
	public class SpecInherited_CrtFinservProductEventsProcess : SpecInherited_CrtFinservProductEventsProcess<SpecInherited_CrtFinservProduct_Terrasoft>
	{

		public SpecInherited_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecInherited_CrtFinservProductEventsProcess

	public partial class SpecInherited_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

