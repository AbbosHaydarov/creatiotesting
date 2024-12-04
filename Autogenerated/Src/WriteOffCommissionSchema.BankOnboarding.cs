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

	#region Class: WriteOffCommissionSchema

	/// <exclude/>
	public class WriteOffCommissionSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public WriteOffCommissionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WriteOffCommissionSchema(WriteOffCommissionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WriteOffCommissionSchema(WriteOffCommissionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2042df5-7c08-4f94-a286-fb77448db491");
			RealUId = new Guid("c2042df5-7c08-4f94-a286-fb77448db491");
			Name = "WriteOffCommission";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f06c7ce5-55b1-4dc3-b481-e1b0a2ceaa62");
			IsDBView = false;
			UseDenyRecordRights = false;
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
			return new WriteOffCommission(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WriteOffCommission_BankOnboardingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WriteOffCommissionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WriteOffCommissionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2042df5-7c08-4f94-a286-fb77448db491"));
		}

		#endregion

	}

	#endregion

	#region Class: WriteOffCommission

	/// <summary>
	/// Commission write off method.
	/// </summary>
	public class WriteOffCommission : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public WriteOffCommission(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WriteOffCommission";
		}

		public WriteOffCommission(WriteOffCommission source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WriteOffCommission_BankOnboardingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WriteOffCommissionDeleted", e);
			Validating += (s, e) => ThrowEvent("WriteOffCommissionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WriteOffCommission(this);
		}

		#endregion

	}

	#endregion

	#region Class: WriteOffCommission_BankOnboardingEventsProcess

	/// <exclude/>
	public partial class WriteOffCommission_BankOnboardingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : WriteOffCommission
	{

		public WriteOffCommission_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WriteOffCommission_BankOnboardingEventsProcess";
			SchemaUId = new Guid("c2042df5-7c08-4f94-a286-fb77448db491");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c2042df5-7c08-4f94-a286-fb77448db491");
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

	#region Class: WriteOffCommission_BankOnboardingEventsProcess

	/// <exclude/>
	public class WriteOffCommission_BankOnboardingEventsProcess : WriteOffCommission_BankOnboardingEventsProcess<WriteOffCommission>
	{

		public WriteOffCommission_BankOnboardingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WriteOffCommission_BankOnboardingEventsProcess

	public partial class WriteOffCommission_BankOnboardingEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: WriteOffCommissionEventsProcess

	/// <exclude/>
	public class WriteOffCommissionEventsProcess : WriteOffCommission_BankOnboardingEventsProcess
	{

		public WriteOffCommissionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

