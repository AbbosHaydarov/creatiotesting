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

	#region Class: KnowledgeBaseTypeSchema

	/// <exclude/>
	public class KnowledgeBaseTypeSchema : Terrasoft.Configuration.KnowledgeBaseType_CrtCoreBase_TerrasoftSchema
	{

		#region Constructors: Public

		public KnowledgeBaseTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public KnowledgeBaseTypeSchema(KnowledgeBaseTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public KnowledgeBaseTypeSchema(KnowledgeBaseTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e3a97b0b-e848-4e15-9895-d7465cf04b2d");
			Name = "KnowledgeBaseType";
			ParentSchemaUId = new Guid("9d744e43-11b0-4811-bfe1-6350f1d100c3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ae553dc5-e6bd-4ee3-9766-f7983a69044b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("a681e162-f4b7-cfa3-bb28-22ac792b8e2d"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("e3a97b0b-e848-4e15-9895-d7465cf04b2d"),
				ModifiedInSchemaUId = new Guid("e3a97b0b-e848-4e15-9895-d7465cf04b2d"),
				CreatedInPackageId = new Guid("ae553dc5-e6bd-4ee3-9766-f7983a69044b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new KnowledgeBaseType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new KnowledgeBaseTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new KnowledgeBaseTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3a97b0b-e848-4e15-9895-d7465cf04b2d"));
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseType

	/// <summary>
	/// Type of Knowledge Base Article.
	/// </summary>
	public class KnowledgeBaseType : Terrasoft.Configuration.KnowledgeBaseType_CrtCoreBase_Terrasoft
	{

		#region Constructors: Public

		public KnowledgeBaseType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "KnowledgeBaseType";
		}

		public KnowledgeBaseType(KnowledgeBaseType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess(UserConnection);
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
			return new KnowledgeBaseType(this);
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess

	/// <exclude/>
	public partial class KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess<TEntity> : Terrasoft.Configuration.KnowledgeBaseType_CrtCoreBaseEventsProcess<TEntity> where TEntity : KnowledgeBaseType
	{

		public KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e3a97b0b-e848-4e15-9895-d7465cf04b2d");
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

	#region Class: KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess

	/// <exclude/>
	public class KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess : KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess<KnowledgeBaseType>
	{

		public KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess

	public partial class KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: KnowledgeBaseTypeEventsProcess

	/// <exclude/>
	public class KnowledgeBaseTypeEventsProcess : KnowledgeBaseType_CrtKnowledgeManagementAppEventsProcess
	{

		public KnowledgeBaseTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

