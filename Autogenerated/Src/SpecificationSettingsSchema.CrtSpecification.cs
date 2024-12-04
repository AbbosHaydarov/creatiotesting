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

	#region Class: SpecificationSettingsSchema

	/// <exclude/>
	public class SpecificationSettingsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecificationSettingsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationSettingsSchema(SpecificationSettingsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationSettingsSchema(SpecificationSettingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3");
			RealUId = new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3");
			Name = "SpecificationSettings";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("356cd724-5c53-4074-944f-dbf1a0fcb7ef");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fc3ee4ea-2a48-9dda-ffde-231cba0e951a")) == null) {
				Columns.Add(CreateSpecificationEntityNameColumn());
			}
			if (Columns.FindByUId(new Guid("29a79e0c-4e78-c440-9137-3e42ae3afa94")) == null) {
				Columns.Add(CreateEntityNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSpecificationEntityNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("fc3ee4ea-2a48-9dda-ffde-231cba0e951a"),
				Name = @"SpecificationEntityName",
				CreatedInSchemaUId = new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3"),
				ModifiedInSchemaUId = new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3"),
				CreatedInPackageId = new Guid("356cd724-5c53-4074-944f-dbf1a0fcb7ef")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("29a79e0c-4e78-c440-9137-3e42ae3afa94"),
				Name = @"EntityName",
				CreatedInSchemaUId = new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3"),
				ModifiedInSchemaUId = new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3"),
				CreatedInPackageId = new Guid("356cd724-5c53-4074-944f-dbf1a0fcb7ef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationSettings(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationSettings_CrtSpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationSettingsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationSettingsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationSettings

	/// <summary>
	/// Specification settings.
	/// </summary>
	public class SpecificationSettings : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecificationSettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationSettings";
		}

		public SpecificationSettings(SpecificationSettings source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Specification entity name.
		/// </summary>
		public string SpecificationEntityName {
			get {
				return GetTypedColumnValue<string>("SpecificationEntityName");
			}
			set {
				SetColumnValue("SpecificationEntityName", value);
			}
		}

		/// <summary>
		/// Entity name.
		/// </summary>
		public string EntityName {
			get {
				return GetTypedColumnValue<string>("EntityName");
			}
			set {
				SetColumnValue("EntityName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationSettings_CrtSpecificationEventsProcess(UserConnection);
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
			return new SpecificationSettings(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationSettings_CrtSpecificationEventsProcess

	/// <exclude/>
	public partial class SpecificationSettings_CrtSpecificationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SpecificationSettings
	{

		public SpecificationSettings_CrtSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationSettings_CrtSpecificationEventsProcess";
			SchemaUId = new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("326ede24-cd8e-41fc-8505-ade68eb1a1b3");
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

	#region Class: SpecificationSettings_CrtSpecificationEventsProcess

	/// <exclude/>
	public class SpecificationSettings_CrtSpecificationEventsProcess : SpecificationSettings_CrtSpecificationEventsProcess<SpecificationSettings>
	{

		public SpecificationSettings_CrtSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationSettings_CrtSpecificationEventsProcess

	public partial class SpecificationSettings_CrtSpecificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationSettingsEventsProcess

	/// <exclude/>
	public class SpecificationSettingsEventsProcess : SpecificationSettings_CrtSpecificationEventsProcess
	{

		public SpecificationSettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

