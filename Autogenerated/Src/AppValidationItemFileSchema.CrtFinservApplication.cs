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
	using Terrasoft.Configuration;
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

	#region Class: AppValidationItemFileSchema

	/// <exclude/>
	public class AppValidationItemFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public AppValidationItemFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValidationItemFileSchema(AppValidationItemFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValidationItemFileSchema(AppValidationItemFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("379a4534-d3ee-4c56-8fdf-f12fde521f89");
			RealUId = new Guid("379a4534-d3ee-4c56-8fdf-f12fde521f89");
			Name = "AppValidationItemFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("71edc66a-8e84-47ff-ae8f-5a12179bf1a9")) == null) {
				Columns.Add(CreateAppValidationItemColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAppValidationItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("71edc66a-8e84-47ff-ae8f-5a12179bf1a9"),
				Name = @"AppValidationItem",
				ReferenceSchemaUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("379a4534-d3ee-4c56-8fdf-f12fde521f89"),
				ModifiedInSchemaUId = new Guid("379a4534-d3ee-4c56-8fdf-f12fde521f89"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppValidationItemFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValidationItemFile_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValidationItemFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValidationItemFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("379a4534-d3ee-4c56-8fdf-f12fde521f89"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationItemFile

	/// <summary>
	/// Validation action file.
	/// </summary>
	public class AppValidationItemFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public AppValidationItemFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidationItemFile";
		}

		public AppValidationItemFile(AppValidationItemFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AppValidationItemId {
			get {
				return GetTypedColumnValue<Guid>("AppValidationItemId");
			}
			set {
				SetColumnValue("AppValidationItemId", value);
				_appValidationItem = null;
			}
		}

		/// <exclude/>
		public string AppValidationItemName {
			get {
				return GetTypedColumnValue<string>("AppValidationItemName");
			}
			set {
				SetColumnValue("AppValidationItemName", value);
				if (_appValidationItem != null) {
					_appValidationItem.Name = value;
				}
			}
		}

		private AppValidationItem _appValidationItem;
		/// <summary>
		/// Validation item.
		/// </summary>
		public AppValidationItem AppValidationItem {
			get {
				return _appValidationItem ??
					(_appValidationItem = LookupColumnEntities.GetEntity("AppValidationItem") as AppValidationItem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValidationItemFile_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValidationItemFileDeleted", e);
			Updated += (s, e) => ThrowEvent("AppValidationItemFileUpdated", e);
			Validating += (s, e) => ThrowEvent("AppValidationItemFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidationItemFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationItemFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppValidationItemFile_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.File_LinkPreviewEventsProcess<TEntity> where TEntity : AppValidationItemFile
	{

		public AppValidationItemFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValidationItemFile_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("379a4534-d3ee-4c56-8fdf-f12fde521f89");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("379a4534-d3ee-4c56-8fdf-f12fde521f89");
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

	#region Class: AppValidationItemFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppValidationItemFile_CrtFinservApplicationEventsProcess : AppValidationItemFile_CrtFinservApplicationEventsProcess<AppValidationItemFile>
	{

		public AppValidationItemFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppValidationItemFile_CrtFinservApplicationEventsProcess

	public partial class AppValidationItemFile_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppValidationItemFileEventsProcess

	/// <exclude/>
	public class AppValidationItemFileEventsProcess : AppValidationItemFile_CrtFinservApplicationEventsProcess
	{

		public AppValidationItemFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

