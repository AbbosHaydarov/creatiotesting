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

	#region Class: AppValidationItemSchema

	/// <exclude/>
	public class AppValidationItemSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AppValidationItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValidationItemSchema(AppValidationItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValidationItemSchema(AppValidationItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de");
			RealUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de");
			Name = "AppValidationItem";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("271b0555-d508-48ef-8064-e8ba3454a6de")) == null) {
				Columns.Add(CreateSceneryColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSceneryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("271b0555-d508-48ef-8064-e8ba3454a6de"),
				Name = @"Scenery",
				CreatedInSchemaUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de"),
				ModifiedInSchemaUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de"),
				CreatedInPackageId = new Guid("fd87606a-bef1-4244-b372-5e9d688841d1"),
				IsMultiLineText = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppValidationItem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValidationItem_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValidationItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValidationItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93854998-54ce-4474-b9c3-b7e6b21410de"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationItem

	/// <summary>
	/// Validation items.
	/// </summary>
	public class AppValidationItem : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AppValidationItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidationItem";
		}

		public AppValidationItem(AppValidationItem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Conversation script.
		/// </summary>
		public string Scenery {
			get {
				return GetTypedColumnValue<string>("Scenery");
			}
			set {
				SetColumnValue("Scenery", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValidationItem_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValidationItemDeleted", e);
			Validating += (s, e) => ThrowEvent("AppValidationItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidationItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationItem_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppValidationItem_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AppValidationItem
	{

		public AppValidationItem_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValidationItem_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("93854998-54ce-4474-b9c3-b7e6b21410de");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("93854998-54ce-4474-b9c3-b7e6b21410de");
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

	#region Class: AppValidationItem_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppValidationItem_CrtFinservApplicationEventsProcess : AppValidationItem_CrtFinservApplicationEventsProcess<AppValidationItem>
	{

		public AppValidationItem_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppValidationItem_CrtFinservApplicationEventsProcess

	public partial class AppValidationItem_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppValidationItemEventsProcess

	/// <exclude/>
	public class AppValidationItemEventsProcess : AppValidationItem_CrtFinservApplicationEventsProcess
	{

		public AppValidationItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

