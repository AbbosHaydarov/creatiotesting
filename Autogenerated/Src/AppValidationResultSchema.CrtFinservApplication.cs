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

	#region Class: AppValidationResultSchema

	/// <exclude/>
	public class AppValidationResultSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AppValidationResultSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValidationResultSchema(AppValidationResultSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValidationResultSchema(AppValidationResultSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2edae1ed-a765-4453-8a7d-f7652fe3efa6");
			RealUId = new Guid("2edae1ed-a765-4453-8a7d-f7652fe3efa6");
			Name = "AppValidationResult";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc");
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
			return new AppValidationResult(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValidationResult_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValidationResultSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValidationResultSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2edae1ed-a765-4453-8a7d-f7652fe3efa6"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationResult

	/// <summary>
	/// Validation item results.
	/// </summary>
	public class AppValidationResult : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AppValidationResult(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidationResult";
		}

		public AppValidationResult(AppValidationResult source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValidationResult_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValidationResultDeleted", e);
			Validating += (s, e) => ThrowEvent("AppValidationResultValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidationResult(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationResult_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppValidationResult_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AppValidationResult
	{

		public AppValidationResult_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValidationResult_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("2edae1ed-a765-4453-8a7d-f7652fe3efa6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2edae1ed-a765-4453-8a7d-f7652fe3efa6");
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

	#region Class: AppValidationResult_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppValidationResult_CrtFinservApplicationEventsProcess : AppValidationResult_CrtFinservApplicationEventsProcess<AppValidationResult>
	{

		public AppValidationResult_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppValidationResult_CrtFinservApplicationEventsProcess

	public partial class AppValidationResult_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppValidationResultEventsProcess

	/// <exclude/>
	public class AppValidationResultEventsProcess : AppValidationResult_CrtFinservApplicationEventsProcess
	{

		public AppValidationResultEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

