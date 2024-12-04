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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: FinApplicationTagSchema

	/// <exclude/>
	public class FinApplicationTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public FinApplicationTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationTagSchema(FinApplicationTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationTagSchema(FinApplicationTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b1e71d0-4131-43fc-8f8a-11b9ca30ba9c");
			RealUId = new Guid("6b1e71d0-4131-43fc-8f8a-11b9ca30ba9c");
			Name = "FinApplicationTag";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dfe2c6b5-61e8-4e57-95ae-a3c34fa0908f");
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
			return new FinApplicationTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplicationTag_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b1e71d0-4131-43fc-8f8a-11b9ca30ba9c"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationTag

	/// <summary>
	/// Applications section tag.
	/// </summary>
	public class FinApplicationTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public FinApplicationTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationTag";
		}

		public FinApplicationTag(FinApplicationTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplicationTag_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("FinApplicationTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("FinApplicationTagInserted", e);
			Inserting += (s, e) => ThrowEvent("FinApplicationTagInserting", e);
			Saved += (s, e) => ThrowEvent("FinApplicationTagSaved", e);
			Saving += (s, e) => ThrowEvent("FinApplicationTagSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinApplicationTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplicationTag_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : FinApplicationTag
	{

		public FinApplicationTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplicationTag_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("6b1e71d0-4131-43fc-8f8a-11b9ca30ba9c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6b1e71d0-4131-43fc-8f8a-11b9ca30ba9c");
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

	#region Class: FinApplicationTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationTag_CrtFinservApplicationEventsProcess : FinApplicationTag_CrtFinservApplicationEventsProcess<FinApplicationTag>
	{

		public FinApplicationTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplicationTag_CrtFinservApplicationEventsProcess

	public partial class FinApplicationTag_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinApplicationTagEventsProcess

	/// <exclude/>
	public class FinApplicationTagEventsProcess : FinApplicationTag_CrtFinservApplicationEventsProcess
	{

		public FinApplicationTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

