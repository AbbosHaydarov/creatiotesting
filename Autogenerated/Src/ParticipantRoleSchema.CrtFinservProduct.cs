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

	#region Class: ParticipantRoleSchema

	/// <exclude/>
	public class ParticipantRoleSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ParticipantRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ParticipantRoleSchema(ParticipantRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ParticipantRoleSchema(ParticipantRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964");
			RealUId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964");
			Name = "ParticipantRole";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e2042f77-9f94-4a21-9abe-8598d34329e6");
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
			return new ParticipantRole(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ParticipantRole_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ParticipantRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ParticipantRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964"));
		}

		#endregion

	}

	#endregion

	#region Class: ParticipantRole

	/// <summary>
	/// Role of participant.
	/// </summary>
	public class ParticipantRole : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ParticipantRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ParticipantRole";
		}

		public ParticipantRole(ParticipantRole source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ParticipantRole_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ParticipantRoleDeleted", e);
			Validating += (s, e) => ThrowEvent("ParticipantRoleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ParticipantRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: ParticipantRole_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class ParticipantRole_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : ParticipantRole
	{

		public ParticipantRole_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ParticipantRole_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ed6220d4-3e12-4a1d-82b8-40119f31c964");
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

	#region Class: ParticipantRole_CrtFinservProductEventsProcess

	/// <exclude/>
	public class ParticipantRole_CrtFinservProductEventsProcess : ParticipantRole_CrtFinservProductEventsProcess<ParticipantRole>
	{

		public ParticipantRole_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ParticipantRole_CrtFinservProductEventsProcess

	public partial class ParticipantRole_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ParticipantRoleEventsProcess

	/// <exclude/>
	public class ParticipantRoleEventsProcess : ParticipantRole_CrtFinservProductEventsProcess
	{

		public ParticipantRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

