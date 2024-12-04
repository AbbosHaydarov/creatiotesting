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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_CrtCaseService_TerrasoftSchema

	/// <exclude/>
	public class Activity_CrtCaseService_TerrasoftSchema : Terrasoft.Configuration.Activity_CrtCaseManagmentObject_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_CrtCaseService_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_CrtCaseService_TerrasoftSchema(Activity_CrtCaseService_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_CrtCaseService_TerrasoftSchema(Activity_CrtCaseService_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateId_StartDate_Type_ShowInSchedIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("5616f33c-a275-4edb-a072-5264b6f7e077");
			index.Name = "Id_StartDate_Type_ShowInSched";
			index.CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			index.ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			index.CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			EntitySchemaIndexColumn showInSchedulerIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("9ba50dac-d3dd-57f3-3c2c-3ec8035c8b31"),
				ColumnUId = new Guid("ff2dec51-885c-428a-8e6a-80c0c14b1434"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(showInSchedulerIndexColumn);
			EntitySchemaIndexColumn startDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("dbd9d02a-031e-a4fa-1033-6b9f10122ca4"),
				ColumnUId = new Guid("a12ca538-61b1-4907-9fdf-01969163d4dd"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(startDateIndexColumn);
			EntitySchemaIndexColumn typeIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("1a9e19cd-0fbc-4a81-0d2b-741666da87e0"),
				ColumnUId = new Guid("5491c33f-e927-4ca8-a579-d4810ea54c56"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(typeIdIndexColumn);
			EntitySchemaIndexColumn idIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("cb359a7a-c5a6-6760-3d2e-d22eb2b0730a"),
				ColumnUId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617"),
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(idIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("64bbf312-ea2b-4093-9040-a1e1be592e32");
			Name = "Activity_CrtCaseService_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f1773fe1-394d-47f6-b668-13c7c22c835e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fe3732e9-7b58-4e30-afc3-b121bba13a8c")) == null) {
				Columns.Add(CreateIsNotPublishedColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIsNotPublishedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("fe3732e9-7b58-4e30-afc3-b121bba13a8c"),
				Name = @"IsNotPublished",
				CreatedInSchemaUId = new Guid("64bbf312-ea2b-4093-9040-a1e1be592e32"),
				ModifiedInSchemaUId = new Guid("64bbf312-ea2b-4093-9040-a1e1be592e32"),
				CreatedInPackageId = new Guid("f1773fe1-394d-47f6-b668-13c7c22c835e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateId_StartDate_Type_ShowInSchedIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_CrtCaseService_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_CrtCaseServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_CrtCaseService_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_CrtCaseService_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64bbf312-ea2b-4093-9040-a1e1be592e32"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtCaseService_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_CrtCaseService_Terrasoft : Terrasoft.Configuration.Activity_CrtCaseManagmentObject_Terrasoft
	{

		#region Constructors: Public

		public Activity_CrtCaseService_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_CrtCaseService_Terrasoft";
		}

		public Activity_CrtCaseService_Terrasoft(Activity_CrtCaseService_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Is not published.
		/// </summary>
		public bool IsNotPublished {
			get {
				return GetTypedColumnValue<bool>("IsNotPublished");
			}
			set {
				SetColumnValue("IsNotPublished", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_CrtCaseServiceEventsProcess(UserConnection);
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
			return new Activity_CrtCaseService_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtCaseServiceEventsProcess

	/// <exclude/>
	public partial class Activity_CrtCaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CrtCaseManagmentObjectEventsProcess<TEntity> where TEntity : Activity_CrtCaseService_Terrasoft
	{

		public Activity_CrtCaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_CrtCaseServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("64bbf312-ea2b-4093-9040-a1e1be592e32");
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

	#region Class: Activity_CrtCaseServiceEventsProcess

	/// <exclude/>
	public class Activity_CrtCaseServiceEventsProcess : Activity_CrtCaseServiceEventsProcess<Activity_CrtCaseService_Terrasoft>
	{

		public Activity_CrtCaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_CrtCaseServiceEventsProcess

	public partial class Activity_CrtCaseServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

