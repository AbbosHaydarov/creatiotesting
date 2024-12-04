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

	#region Class: KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema

	/// <exclude/>
	public class KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema : Terrasoft.Configuration.KnowledgeBase_CrtPortal_TerrasoftSchema
	{

		#region Constructors: Public

		public KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema(KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema(KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8e694a78-86a6-48de-9c67-4cd6d6525776");
			Name = "KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft";
			ParentSchemaUId = new Guid("0326868c-ce5e-4934-8f1f-178801bfe6c3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c2cac68a-0823-4f13-a1dc-85f85789b1d6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("RichText");
			column.ModifiedInSchemaUId = new Guid("8e694a78-86a6-48de-9c67-4cd6d6525776");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new KnowledgeBase_CrtKnowledgeManagementAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e694a78-86a6-48de-9c67-4cd6d6525776"));
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft

	/// <summary>
	/// Knowledge base article.
	/// </summary>
	public class KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft : Terrasoft.Configuration.KnowledgeBase_CrtPortal_Terrasoft
	{

		#region Constructors: Public

		public KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft";
		}

		public KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft(KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new KnowledgeBase_CrtKnowledgeManagementAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("KnowledgeBase_CrtKnowledgeManagementApp_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBase_CrtKnowledgeManagementAppEventsProcess

	/// <exclude/>
	public partial class KnowledgeBase_CrtKnowledgeManagementAppEventsProcess<TEntity> : Terrasoft.Configuration.KnowledgeBase_CrtPortalEventsProcess<TEntity> where TEntity : KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft
	{

		public KnowledgeBase_CrtKnowledgeManagementAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "KnowledgeBase_CrtKnowledgeManagementAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8e694a78-86a6-48de-9c67-4cd6d6525776");
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

	#region Class: KnowledgeBase_CrtKnowledgeManagementAppEventsProcess

	/// <exclude/>
	public class KnowledgeBase_CrtKnowledgeManagementAppEventsProcess : KnowledgeBase_CrtKnowledgeManagementAppEventsProcess<KnowledgeBase_CrtKnowledgeManagementApp_Terrasoft>
	{

		public KnowledgeBase_CrtKnowledgeManagementAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: KnowledgeBase_CrtKnowledgeManagementAppEventsProcess

	public partial class KnowledgeBase_CrtKnowledgeManagementAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

