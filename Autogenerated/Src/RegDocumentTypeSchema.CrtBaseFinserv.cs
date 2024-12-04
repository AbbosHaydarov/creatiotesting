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

	#region Class: RegDocumentTypeSchema

	/// <exclude/>
	public class RegDocumentTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public RegDocumentTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RegDocumentTypeSchema(RegDocumentTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RegDocumentTypeSchema(RegDocumentTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ec520e44-c1ab-4545-8489-6e9adaf5c73b");
			RealUId = new Guid("ec520e44-c1ab-4545-8489-6e9adaf5c73b");
			Name = "RegDocumentType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c59bcbb3-4d6b-4498-a20c-666c7b25526d");
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
			return new RegDocumentType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RegDocumentType_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RegDocumentTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RegDocumentTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec520e44-c1ab-4545-8489-6e9adaf5c73b"));
		}

		#endregion

	}

	#endregion

	#region Class: RegDocumentType

	/// <summary>
	/// Identity document.
	/// </summary>
	public class RegDocumentType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public RegDocumentType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RegDocumentType";
		}

		public RegDocumentType(RegDocumentType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RegDocumentType_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RegDocumentTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("RegDocumentTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RegDocumentType(this);
		}

		#endregion

	}

	#endregion

	#region Class: RegDocumentType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class RegDocumentType_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : RegDocumentType
	{

		public RegDocumentType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RegDocumentType_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("ec520e44-c1ab-4545-8489-6e9adaf5c73b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ec520e44-c1ab-4545-8489-6e9adaf5c73b");
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

	#region Class: RegDocumentType_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class RegDocumentType_CrtBaseFinservEventsProcess : RegDocumentType_CrtBaseFinservEventsProcess<RegDocumentType>
	{

		public RegDocumentType_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RegDocumentType_CrtBaseFinservEventsProcess

	public partial class RegDocumentType_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RegDocumentTypeEventsProcess

	/// <exclude/>
	public class RegDocumentTypeEventsProcess : RegDocumentType_CrtBaseFinservEventsProcess
	{

		public RegDocumentTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

