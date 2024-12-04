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

	#region Class: FinApplicationInTagSchema

	/// <exclude/>
	public class FinApplicationInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public FinApplicationInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationInTagSchema(FinApplicationInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationInTagSchema(FinApplicationInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18fa57ec-5e44-41f8-82c2-1d6f5be591e0");
			RealUId = new Guid("18fa57ec-5e44-41f8-82c2-1d6f5be591e0");
			Name = "FinApplicationInTag";
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
			column.ReferenceSchemaUId = new Guid("6b1e71d0-4131-43fc-8f8a-11b9ca30ba9c");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("18fa57ec-5e44-41f8-82c2-1d6f5be591e0");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityNumber";
			column.ModifiedInSchemaUId = new Guid("18fa57ec-5e44-41f8-82c2-1d6f5be591e0");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplicationInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplicationInTag_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18fa57ec-5e44-41f8-82c2-1d6f5be591e0"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationInTag

	/// <summary>
	/// Application object tag.
	/// </summary>
	public class FinApplicationInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public FinApplicationInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationInTag";
		}

		public FinApplicationInTag(FinApplicationInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplicationInTag_CrtFinservApplicationEventsProcess(UserConnection);
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
			return new FinApplicationInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationInTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplicationInTag_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtCoreBaseEventsProcess<TEntity> where TEntity : FinApplicationInTag
	{

		public FinApplicationInTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplicationInTag_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("18fa57ec-5e44-41f8-82c2-1d6f5be591e0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("18fa57ec-5e44-41f8-82c2-1d6f5be591e0");
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

	#region Class: FinApplicationInTag_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationInTag_CrtFinservApplicationEventsProcess : FinApplicationInTag_CrtFinservApplicationEventsProcess<FinApplicationInTag>
	{

		public FinApplicationInTag_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplicationInTag_CrtFinservApplicationEventsProcess

	public partial class FinApplicationInTag_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinApplicationInTagEventsProcess

	/// <exclude/>
	public class FinApplicationInTagEventsProcess : FinApplicationInTag_CrtFinservApplicationEventsProcess
	{

		public FinApplicationInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

