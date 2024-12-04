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

	#region Class: VirtualAdAccountSchema

	/// <exclude/>
	[IsVirtual]
	public class VirtualAdAccountSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VirtualAdAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VirtualAdAccountSchema(VirtualAdAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VirtualAdAccountSchema(VirtualAdAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ae89414-4a5c-49bd-8137-a8fac2ec16e8");
			RealUId = new Guid("9ae89414-4a5c-49bd-8137-a8fac2ec16e8");
			Name = "VirtualAdAccount";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("abf715ae-fc66-421f-87dc-256931a52a49");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b4897030-b5bc-a521-e558-2c8395e6069f"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("9ae89414-4a5c-49bd-8137-a8fac2ec16e8"),
				ModifiedInSchemaUId = new Guid("9ae89414-4a5c-49bd-8137-a8fac2ec16e8"),
				CreatedInPackageId = new Guid("abf715ae-fc66-421f-87dc-256931a52a49")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VirtualAdAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VirtualAdAccount_CrtDigitalAdsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VirtualAdAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VirtualAdAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ae89414-4a5c-49bd-8137-a8fac2ec16e8"));
		}

		#endregion

	}

	#endregion

	#region Class: VirtualAdAccount

	/// <summary>
	/// Virtual ad account.
	/// </summary>
	public class VirtualAdAccount : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VirtualAdAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VirtualAdAccount";
		}

		public VirtualAdAccount(VirtualAdAccount source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VirtualAdAccount_CrtDigitalAdsAppEventsProcess(UserConnection);
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
			return new VirtualAdAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: VirtualAdAccount_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public partial class VirtualAdAccount_CrtDigitalAdsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VirtualAdAccount
	{

		public VirtualAdAccount_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VirtualAdAccount_CrtDigitalAdsAppEventsProcess";
			SchemaUId = new Guid("9ae89414-4a5c-49bd-8137-a8fac2ec16e8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9ae89414-4a5c-49bd-8137-a8fac2ec16e8");
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

	#region Class: VirtualAdAccount_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public class VirtualAdAccount_CrtDigitalAdsAppEventsProcess : VirtualAdAccount_CrtDigitalAdsAppEventsProcess<VirtualAdAccount>
	{

		public VirtualAdAccount_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VirtualAdAccount_CrtDigitalAdsAppEventsProcess

	public partial class VirtualAdAccount_CrtDigitalAdsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VirtualAdAccountEventsProcess

	/// <exclude/>
	public class VirtualAdAccountEventsProcess : VirtualAdAccount_CrtDigitalAdsAppEventsProcess
	{

		public VirtualAdAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

