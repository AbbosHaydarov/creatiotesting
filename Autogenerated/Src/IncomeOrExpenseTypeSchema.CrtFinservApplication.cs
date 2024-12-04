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

	#region Class: IncomeOrExpenseTypeSchema

	/// <exclude/>
	public class IncomeOrExpenseTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public IncomeOrExpenseTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public IncomeOrExpenseTypeSchema(IncomeOrExpenseTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public IncomeOrExpenseTypeSchema(IncomeOrExpenseTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("874540b6-a106-4531-98b5-d1326aefe5d6");
			RealUId = new Guid("874540b6-a106-4531-98b5-d1326aefe5d6");
			Name = "IncomeOrExpenseType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new IncomeOrExpenseType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new IncomeOrExpenseType_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new IncomeOrExpenseTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new IncomeOrExpenseTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("874540b6-a106-4531-98b5-d1326aefe5d6"));
		}

		#endregion

	}

	#endregion

	#region Class: IncomeOrExpenseType

	/// <summary>
	/// Income or expense type.
	/// </summary>
	public class IncomeOrExpenseType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public IncomeOrExpenseType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "IncomeOrExpenseType";
		}

		public IncomeOrExpenseType(IncomeOrExpenseType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new IncomeOrExpenseType_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("IncomeOrExpenseTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("IncomeOrExpenseTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IncomeOrExpenseType(this);
		}

		#endregion

	}

	#endregion

	#region Class: IncomeOrExpenseType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class IncomeOrExpenseType_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : IncomeOrExpenseType
	{

		public IncomeOrExpenseType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IncomeOrExpenseType_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("874540b6-a106-4531-98b5-d1326aefe5d6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("874540b6-a106-4531-98b5-d1326aefe5d6");
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

	#region Class: IncomeOrExpenseType_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class IncomeOrExpenseType_CrtFinservApplicationEventsProcess : IncomeOrExpenseType_CrtFinservApplicationEventsProcess<IncomeOrExpenseType>
	{

		public IncomeOrExpenseType_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IncomeOrExpenseType_CrtFinservApplicationEventsProcess

	public partial class IncomeOrExpenseType_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: IncomeOrExpenseTypeEventsProcess

	/// <exclude/>
	public class IncomeOrExpenseTypeEventsProcess : IncomeOrExpenseType_CrtFinservApplicationEventsProcess
	{

		public IncomeOrExpenseTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

