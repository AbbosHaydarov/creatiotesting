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

	#region Class: AppValidationAnswerSchema

	/// <exclude/>
	public class AppValidationAnswerSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AppValidationAnswerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppValidationAnswerSchema(AppValidationAnswerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppValidationAnswerSchema(AppValidationAnswerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("14569457-970c-45f7-a78f-2c7d9b57bf0b");
			RealUId = new Guid("14569457-970c-45f7-a78f-2c7d9b57bf0b");
			Name = "AppValidationAnswer";
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
			return new AppValidationAnswer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppValidationAnswer_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppValidationAnswerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppValidationAnswerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14569457-970c-45f7-a78f-2c7d9b57bf0b"));
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationAnswer

	/// <summary>
	/// Answer.
	/// </summary>
	public class AppValidationAnswer : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AppValidationAnswer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValidationAnswer";
		}

		public AppValidationAnswer(AppValidationAnswer source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppValidationAnswer_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppValidationAnswerDeleted", e);
			Validating += (s, e) => ThrowEvent("AppValidationAnswerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppValidationAnswer(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppValidationAnswer_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppValidationAnswer_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : AppValidationAnswer
	{

		public AppValidationAnswer_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppValidationAnswer_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("14569457-970c-45f7-a78f-2c7d9b57bf0b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("14569457-970c-45f7-a78f-2c7d9b57bf0b");
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

	#region Class: AppValidationAnswer_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppValidationAnswer_CrtFinservApplicationEventsProcess : AppValidationAnswer_CrtFinservApplicationEventsProcess<AppValidationAnswer>
	{

		public AppValidationAnswer_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppValidationAnswer_CrtFinservApplicationEventsProcess

	public partial class AppValidationAnswer_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppValidationAnswerEventsProcess

	/// <exclude/>
	public class AppValidationAnswerEventsProcess : AppValidationAnswer_CrtFinservApplicationEventsProcess
	{

		public AppValidationAnswerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

