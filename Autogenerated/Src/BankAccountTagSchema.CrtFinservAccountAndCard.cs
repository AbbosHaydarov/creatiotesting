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

	#region Class: BankAccountTagSchema

	/// <exclude/>
	public class BankAccountTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public BankAccountTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankAccountTagSchema(BankAccountTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankAccountTagSchema(BankAccountTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("52e3ea63-86ec-48b1-8252-db8e01b90122");
			RealUId = new Guid("52e3ea63-86ec-48b1-8252-db8e01b90122");
			Name = "BankAccountTag";
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
			return new BankAccountTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankAccountTag_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankAccountTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankAccountTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52e3ea63-86ec-48b1-8252-db8e01b90122"));
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountTag

	/// <summary>
	/// Financial accounts section tag.
	/// </summary>
	public class BankAccountTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public BankAccountTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankAccountTag";
		}

		public BankAccountTag(BankAccountTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankAccountTag_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("BankAccountTagDeleting", e);
			Inserted += (s, e) => ThrowEvent("BankAccountTagInserted", e);
			Inserting += (s, e) => ThrowEvent("BankAccountTagInserting", e);
			Saved += (s, e) => ThrowEvent("BankAccountTagSaved", e);
			Saving += (s, e) => ThrowEvent("BankAccountTagSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankAccountTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankAccountTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankAccountTag_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : BankAccountTag
	{

		public BankAccountTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankAccountTag_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("52e3ea63-86ec-48b1-8252-db8e01b90122");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("52e3ea63-86ec-48b1-8252-db8e01b90122");
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

	#region Class: BankAccountTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankAccountTag_CrtFinservAccountAndCardEventsProcess : BankAccountTag_CrtFinservAccountAndCardEventsProcess<BankAccountTag>
	{

		public BankAccountTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankAccountTag_CrtFinservAccountAndCardEventsProcess

	public partial class BankAccountTag_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankAccountTagEventsProcess

	/// <exclude/>
	public class BankAccountTagEventsProcess : BankAccountTag_CrtFinservAccountAndCardEventsProcess
	{

		public BankAccountTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

