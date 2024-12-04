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

	#region Class: Activity_CrtFinservProduct_TerrasoftSchema

	/// <exclude/>
	public class Activity_CrtFinservProduct_TerrasoftSchema : Terrasoft.Configuration.Activity_CrtFinservAccountAndCard_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_CrtFinservProduct_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_CrtFinservProduct_TerrasoftSchema(Activity_CrtFinservProduct_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_CrtFinservProduct_TerrasoftSchema(Activity_CrtFinservProduct_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMBQHMXCKGjle42hQVBJkGeeQSBAIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("cfe2f65b-f8e3-4b11-a0cd-25fdc94133b8");
			index.Name = "IMBQHMXCKGjle42hQVBJkGeeQSBA";
			index.CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			index.ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			index.CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("149ae115-9ed5-42dc-9fdb-ec2cd31bcc9e"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_Activity_SendDateIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("1e60c588-1264-4219-9f83-2a3e68bc54b6");
			index.Name = "IX_Activity_SendDate";
			index.CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed");
			EntitySchemaIndexColumn sendDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b8f4292f-5ae6-43ca-9685-1301b31eba68"),
				ColumnUId = new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc"),
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(sendDateIndexColumn);
			return index;
		}

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
			RealUId = new Guid("c4f1f60d-6fb4-463f-9c31-67c2c29aab0b");
			Name = "Activity_CrtFinservProduct_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4efa8867-fa3b-451d-945a-311f34ad0914");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("433b36f4-312b-454d-85f9-4ce175b7f1cb")) == null) {
				Columns.Add(CreateProductColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("433b36f4-312b-454d-85f9-4ce175b7f1cb"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c4f1f60d-6fb4-463f-9c31-67c2c29aab0b"),
				ModifiedInSchemaUId = new Guid("c4f1f60d-6fb4-463f-9c31-67c2c29aab0b"),
				CreatedInPackageId = new Guid("4efa8867-fa3b-451d-945a-311f34ad0914")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMBQHMXCKGjle42hQVBJkGeeQSBAIndex());
			Indexes.Add(CreateIX_Activity_SendDateIndex());
			Indexes.Add(CreateId_StartDate_Type_ShowInSchedIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_CrtFinservProduct_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_CrtFinservProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_CrtFinservProduct_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_CrtFinservProduct_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4f1f60d-6fb4-463f-9c31-67c2c29aab0b"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtFinservProduct_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_CrtFinservProduct_Terrasoft : Terrasoft.Configuration.Activity_CrtFinservAccountAndCard_Terrasoft
	{

		#region Constructors: Public

		public Activity_CrtFinservProduct_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_CrtFinservProduct_Terrasoft";
		}

		public Activity_CrtFinservProduct_Terrasoft(Activity_CrtFinservProduct_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_CrtFinservProductEventsProcess(UserConnection);
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
			return new Activity_CrtFinservProduct_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtFinservProductEventsProcess

	/// <exclude/>
	public partial class Activity_CrtFinservProductEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CrtFinservAccountAndCardEventsProcess<TEntity> where TEntity : Activity_CrtFinservProduct_Terrasoft
	{

		public Activity_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_CrtFinservProductEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c4f1f60d-6fb4-463f-9c31-67c2c29aab0b");
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

	#region Class: Activity_CrtFinservProductEventsProcess

	/// <exclude/>
	public class Activity_CrtFinservProductEventsProcess : Activity_CrtFinservProductEventsProcess<Activity_CrtFinservProduct_Terrasoft>
	{

		public Activity_CrtFinservProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_CrtFinservProductEventsProcess

	public partial class Activity_CrtFinservProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

