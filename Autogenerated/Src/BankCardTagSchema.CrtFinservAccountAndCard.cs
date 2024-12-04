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

	#region Class: BankCardTagSchema

	/// <exclude/>
	public class BankCardTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public BankCardTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardTagSchema(BankCardTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardTagSchema(BankCardTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("216dbf6a-3679-4866-b33a-0e4569dc7a7f");
			RealUId = new Guid("216dbf6a-3679-4866-b33a-0e4569dc7a7f");
			Name = "BankCardTag";
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
			return new BankCardTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardTag_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("216dbf6a-3679-4866-b33a-0e4569dc7a7f"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardTag

	/// <summary>
	/// Cards section tag.
	/// </summary>
	public class BankCardTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public BankCardTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardTag";
		}

		public BankCardTag(BankCardTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardTag_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("BankCardTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("BankCardTagInserted", e);
			Inserting += (s, e) => ThrowEvent("BankCardTagInserting", e);
			Saved += (s, e) => ThrowEvent("BankCardTagSaved", e);
			Saving += (s, e) => ThrowEvent("BankCardTagSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardTag_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : BankCardTag
	{

		public BankCardTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardTag_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("216dbf6a-3679-4866-b33a-0e4569dc7a7f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("216dbf6a-3679-4866-b33a-0e4569dc7a7f");
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

	#region Class: BankCardTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardTag_CrtFinservAccountAndCardEventsProcess : BankCardTag_CrtFinservAccountAndCardEventsProcess<BankCardTag>
	{

		public BankCardTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardTag_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardTag_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardTagEventsProcess

	/// <exclude/>
	public class BankCardTagEventsProcess : BankCardTag_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

