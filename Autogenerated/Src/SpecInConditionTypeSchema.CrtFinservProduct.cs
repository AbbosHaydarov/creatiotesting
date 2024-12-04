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

	#region Class: SpecInConditionTypeSchema

	/// <exclude/>
	public class SpecInConditionTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SpecInConditionTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecInConditionTypeSchema(SpecInConditionTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecInConditionTypeSchema(SpecInConditionTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f36204bb-8e9a-4fac-a8f2-520b9e8d4819");
			RealUId = new Guid("f36204bb-8e9a-4fac-a8f2-520b9e8d4819");
			Name = "SpecInConditionType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("4700f410-f74f-4ec0-b62f-1588de01772b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = true;
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
			return new SpecInConditionType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecInConditionType_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecInConditionTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecInConditionTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f36204bb-8e9a-4fac-a8f2-520b9e8d4819"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecInConditionType

	/// <summary>
	/// Parameter classification in product condition.
	/// </summary>
	public class SpecInConditionType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SpecInConditionType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecInConditionType";
		}

		public SpecInConditionType(SpecInConditionType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecInConditionType_CrtFinservProductEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecInConditionTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecInConditionTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecInConditionType(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInConditionType_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class SpecInConditionType_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : SpecInConditionType
	{

		public SpecInConditionType_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecInConditionType_CrtFinservProductEventsProcess";
			SchemaUId = new Guid("f36204bb-8e9a-4fac-a8f2-520b9e8d4819");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f36204bb-8e9a-4fac-a8f2-520b9e8d4819");
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

	#region Class: SpecInConditionType_CrtFinservProductEventsProcess

	/// <exclude/>
	public class SpecInConditionType_CrtFinservProductEventsProcess : SpecInConditionType_CrtFinservProductEventsProcess<SpecInConditionType>
	{

		public SpecInConditionType_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecInConditionType_CrtFinservProductEventsProcess

	public partial class SpecInConditionType_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecInConditionTypeEventsProcess

	/// <exclude/>
	public class SpecInConditionTypeEventsProcess : SpecInConditionType_CrtFinservProductEventsProcess
	{

		public SpecInConditionTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

