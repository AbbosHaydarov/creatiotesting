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

	#region Class: KnowledgeBaseType_CrtCoreBase_TerrasoftSchema

	/// <exclude/>
	public class KnowledgeBaseType_CrtCoreBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public KnowledgeBaseType_CrtCoreBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public KnowledgeBaseType_CrtCoreBase_TerrasoftSchema(KnowledgeBaseType_CrtCoreBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public KnowledgeBaseType_CrtCoreBase_TerrasoftSchema(KnowledgeBaseType_CrtCoreBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9d744e43-11b0-4811-bfe1-6350f1d100c3");
			RealUId = new Guid("9d744e43-11b0-4811-bfe1-6350f1d100c3");
			Name = "KnowledgeBaseType_CrtCoreBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
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
			return new KnowledgeBaseType_CrtCoreBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new KnowledgeBaseType_CrtCoreBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new KnowledgeBaseType_CrtCoreBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new KnowledgeBaseType_CrtCoreBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d744e43-11b0-4811-bfe1-6350f1d100c3"));
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseType_CrtCoreBase_Terrasoft

	/// <summary>
	/// Type of Knowledge Base Article.
	/// </summary>
	public class KnowledgeBaseType_CrtCoreBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public KnowledgeBaseType_CrtCoreBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "KnowledgeBaseType_CrtCoreBase_Terrasoft";
		}

		public KnowledgeBaseType_CrtCoreBase_Terrasoft(KnowledgeBaseType_CrtCoreBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new KnowledgeBaseType_CrtCoreBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("KnowledgeBaseType_CrtCoreBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("KnowledgeBaseType_CrtCoreBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("KnowledgeBaseType_CrtCoreBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("KnowledgeBaseType_CrtCoreBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("KnowledgeBaseType_CrtCoreBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("KnowledgeBaseType_CrtCoreBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("KnowledgeBaseType_CrtCoreBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new KnowledgeBaseType_CrtCoreBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseType_CrtCoreBaseEventsProcess

	/// <exclude/>
	public partial class KnowledgeBaseType_CrtCoreBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : KnowledgeBaseType_CrtCoreBase_Terrasoft
	{

		public KnowledgeBaseType_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "KnowledgeBaseType_CrtCoreBaseEventsProcess";
			SchemaUId = new Guid("9d744e43-11b0-4811-bfe1-6350f1d100c3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9d744e43-11b0-4811-bfe1-6350f1d100c3");
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

	#region Class: KnowledgeBaseType_CrtCoreBaseEventsProcess

	/// <exclude/>
	public class KnowledgeBaseType_CrtCoreBaseEventsProcess : KnowledgeBaseType_CrtCoreBaseEventsProcess<KnowledgeBaseType_CrtCoreBase_Terrasoft>
	{

		public KnowledgeBaseType_CrtCoreBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: KnowledgeBaseType_CrtCoreBaseEventsProcess

	public partial class KnowledgeBaseType_CrtCoreBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

