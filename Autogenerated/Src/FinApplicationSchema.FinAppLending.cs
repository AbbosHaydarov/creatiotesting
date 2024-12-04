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

	#region Class: FinApplication_FinAppLending_TerrasoftSchema

	/// <exclude/>
	public class FinApplication_FinAppLending_TerrasoftSchema : Terrasoft.Configuration.FinApplication_FinApplication_TerrasoftSchema
	{

		#region Constructors: Public

		public FinApplication_FinAppLending_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplication_FinAppLending_TerrasoftSchema(FinApplication_FinAppLending_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplication_FinAppLending_TerrasoftSchema(FinApplication_FinAppLending_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ef60e72e-d518-4820-b8c2-ea43be5988e3");
			Name = "FinApplication_FinAppLending_Terrasoft";
			ParentSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("979b8d33-1efb-406e-b9eb-bb1fd00a3c53");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateProductCategoryColumn() {
			EntitySchemaColumn column = base.CreateProductCategoryColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"959c892e-b49a-40c4-829a-63199bd25351"
			};
			column.ModifiedInSchemaUId = new Guid("ef60e72e-d518-4820-b8c2-ea43be5988e3");
			return column;
		}

		protected override EntitySchemaColumn CreateProductTypeColumn() {
			EntitySchemaColumn column = base.CreateProductTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"67490dc0-dec4-4936-b40c-da4efd9cb57e"
			};
			column.ModifiedInSchemaUId = new Guid("ef60e72e-d518-4820-b8c2-ea43be5988e3");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplication_FinAppLending_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplication_FinAppLendingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplication_FinAppLending_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplication_FinAppLending_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ef60e72e-d518-4820-b8c2-ea43be5988e3"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_FinAppLending_Terrasoft

	/// <summary>
	/// Application.
	/// </summary>
	public class FinApplication_FinAppLending_Terrasoft : Terrasoft.Configuration.FinApplication_FinApplication_Terrasoft
	{

		#region Constructors: Public

		public FinApplication_FinAppLending_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplication_FinAppLending_Terrasoft";
		}

		public FinApplication_FinAppLending_Terrasoft(FinApplication_FinAppLending_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FinApplication_FinAppLendingEventsProcess(UserConnection);
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
			return new FinApplication_FinAppLending_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplication_FinAppLendingEventsProcess

	/// <exclude/>
	public partial class FinApplication_FinAppLendingEventsProcess<TEntity> : Terrasoft.Configuration.FinApplication_FinApplicationEventsProcess<TEntity> where TEntity : FinApplication_FinAppLending_Terrasoft
	{

		public FinApplication_FinAppLendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplication_FinAppLendingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ef60e72e-d518-4820-b8c2-ea43be5988e3");
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

	#region Class: FinApplication_FinAppLendingEventsProcess

	/// <exclude/>
	public class FinApplication_FinAppLendingEventsProcess : FinApplication_FinAppLendingEventsProcess<FinApplication_FinAppLending_Terrasoft>
	{

		public FinApplication_FinAppLendingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplication_FinAppLendingEventsProcess

	public partial class FinApplication_FinAppLendingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

