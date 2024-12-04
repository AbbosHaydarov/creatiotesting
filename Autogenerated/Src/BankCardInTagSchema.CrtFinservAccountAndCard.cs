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

	#region Class: BankCardInTagSchema

	/// <exclude/>
	public class BankCardInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public BankCardInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BankCardInTagSchema(BankCardInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BankCardInTagSchema(BankCardInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d7072f3-08ee-4c1f-bb1e-a7e06d45a604");
			RealUId = new Guid("7d7072f3-08ee-4c1f-bb1e-a7e06d45a604");
			Name = "BankCardInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("216dbf6a-3679-4866-b33a-0e4569dc7a7f");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("7d7072f3-08ee-4c1f-bb1e-a7e06d45a604");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("4f942935-9de1-43d6-aaf0-250f640b1dac");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityNumber";
			column.ModifiedInSchemaUId = new Guid("7d7072f3-08ee-4c1f-bb1e-a7e06d45a604");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BankCardInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BankCardInTag_CrtFinservAccountAndCardEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BankCardInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BankCardInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d7072f3-08ee-4c1f-bb1e-a7e06d45a604"));
		}

		#endregion

	}

	#endregion

	#region Class: BankCardInTag

	/// <summary>
	/// Cards section record tag.
	/// </summary>
	public class BankCardInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public BankCardInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardInTag";
		}

		public BankCardInTag(BankCardInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BankCardInTag_CrtFinservAccountAndCardEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BankCardInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: BankCardInTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public partial class BankCardInTag_CrtFinservAccountAndCardEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtCoreBaseEventsProcess<TEntity> where TEntity : BankCardInTag
	{

		public BankCardInTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BankCardInTag_CrtFinservAccountAndCardEventsProcess";
			SchemaUId = new Guid("7d7072f3-08ee-4c1f-bb1e-a7e06d45a604");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7d7072f3-08ee-4c1f-bb1e-a7e06d45a604");
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

	#region Class: BankCardInTag_CrtFinservAccountAndCardEventsProcess

	/// <exclude/>
	public class BankCardInTag_CrtFinservAccountAndCardEventsProcess : BankCardInTag_CrtFinservAccountAndCardEventsProcess<BankCardInTag>
	{

		public BankCardInTag_CrtFinservAccountAndCardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BankCardInTag_CrtFinservAccountAndCardEventsProcess

	public partial class BankCardInTag_CrtFinservAccountAndCardEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BankCardInTagEventsProcess

	/// <exclude/>
	public class BankCardInTagEventsProcess : BankCardInTag_CrtFinservAccountAndCardEventsProcess
	{

		public BankCardInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

