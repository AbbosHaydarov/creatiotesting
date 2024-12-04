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

	#region Class: Call_CrtCall_TerrasoftSchema

	/// <exclude/>
	public class Call_CrtCall_TerrasoftSchema : Terrasoft.Configuration.Call_Timeline_TerrasoftSchema
	{

		#region Constructors: Public

		public Call_CrtCall_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Call_CrtCall_TerrasoftSchema(Call_CrtCall_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Call_CrtCall_TerrasoftSchema(Call_CrtCall_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c0ba1d7d-2918-4eae-84a8-178376094bbb");
			Name = "Call_CrtCall_Terrasoft";
			ParentSchemaUId = new Guid("2f81fa05-11ae-400d-8e07-5ef6a620d1ad");
			ExtendParent = true;
			CreatedInPackageId = new Guid("86aa4580-107f-4b57-8ece-a7f3b6645305");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateCallerIdColumn() {
			EntitySchemaColumn column = base.CreateCallerIdColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("c0ba1d7d-2918-4eae-84a8-178376094bbb");
			return column;
		}

		protected override EntitySchemaColumn CreateCalledIdColumn() {
			EntitySchemaColumn column = base.CreateCalledIdColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("c0ba1d7d-2918-4eae-84a8-178376094bbb");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Call_CrtCall_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Call_CrtCallEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Call_CrtCall_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Call_CrtCall_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0ba1d7d-2918-4eae-84a8-178376094bbb"));
		}

		#endregion

	}

	#endregion

	#region Class: Call_CrtCall_Terrasoft

	/// <summary>
	/// Call.
	/// </summary>
	public class Call_CrtCall_Terrasoft : Terrasoft.Configuration.Call_Timeline_Terrasoft
	{

		#region Constructors: Public

		public Call_CrtCall_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Call_CrtCall_Terrasoft";
		}

		public Call_CrtCall_Terrasoft(Call_CrtCall_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Call_CrtCallEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Call_CrtCall_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Call_CrtCall_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Call_CrtCall_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Call_CrtCall_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Call_CrtCall_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Call_CrtCall_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Call_CrtCall_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Call_CrtCall_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Call_CrtCallEventsProcess

	/// <exclude/>
	public partial class Call_CrtCallEventsProcess<TEntity> : Terrasoft.Configuration.Call_TimelineEventsProcess<TEntity> where TEntity : Call_CrtCall_Terrasoft
	{

		public Call_CrtCallEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Call_CrtCallEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c0ba1d7d-2918-4eae-84a8-178376094bbb");
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

	#region Class: Call_CrtCallEventsProcess

	/// <exclude/>
	public class Call_CrtCallEventsProcess : Call_CrtCallEventsProcess<Call_CrtCall_Terrasoft>
	{

		public Call_CrtCallEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Call_CrtCallEventsProcess

	public partial class Call_CrtCallEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

