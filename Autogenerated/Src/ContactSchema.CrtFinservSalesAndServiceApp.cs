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
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema : Terrasoft.Configuration.Contact_CrtDigitalAdsInC360_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema(Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema(Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
			Name = "Contact_CrtFinservSalesAndServiceApp_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("929db29c-5471-46f0-93aa-7200cd6864dc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreatePhoneColumn() {
			EntitySchemaColumn column = base.CreatePhoneColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MediumText");
			column.ModifiedInSchemaUId = new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
			column.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			return column;
		}

		protected override EntitySchemaColumn CreateMobilePhoneColumn() {
			EntitySchemaColumn column = base.CreateMobilePhoneColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MediumText");
			column.ModifiedInSchemaUId = new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
			column.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			return column;
		}

		protected override EntitySchemaColumn CreateHomePhoneColumn() {
			EntitySchemaColumn column = base.CreateHomePhoneColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MediumText");
			column.ModifiedInSchemaUId = new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
			column.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			return column;
		}

		protected override EntitySchemaColumn CreateEmailColumn() {
			EntitySchemaColumn column = base.CreateEmailColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MediumText");
			column.IsFormatValidated = false;
			column.ModifiedInSchemaUId = new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
			column.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseFaxColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseFaxColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
			column.CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			return column;
		}

		protected override EntitySchemaColumn CreateConfirmedColumn() {
			EntitySchemaColumn column = base.CreateConfirmedColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_CrtFinservSalesAndServiceApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtFinservSalesAndServiceAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtFinservSalesAndServiceApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtFinservSalesAndServiceApp_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtFinservSalesAndServiceApp_Terrasoft : Terrasoft.Configuration.Contact_CrtDigitalAdsInC360_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtFinservSalesAndServiceApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtFinservSalesAndServiceApp_Terrasoft";
		}

		public Contact_CrtFinservSalesAndServiceApp_Terrasoft(Contact_CrtFinservSalesAndServiceApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_CrtFinservSalesAndServiceAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("Contact_CrtFinservSalesAndServiceApp_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Contact_CrtFinservSalesAndServiceApp_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_CrtFinservSalesAndServiceApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtFinservSalesAndServiceAppEventsProcess

	/// <exclude/>
	public partial class Contact_CrtFinservSalesAndServiceAppEventsProcess<TEntity> : Terrasoft.Configuration.Contact_CrtDigitalAdsInC360EventsProcess<TEntity> where TEntity : Contact_CrtFinservSalesAndServiceApp_Terrasoft
	{

		public Contact_CrtFinservSalesAndServiceAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtFinservSalesAndServiceAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("695d78e7-c031-47f3-a6e9-208dba55cef0");
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

	#region Class: Contact_CrtFinservSalesAndServiceAppEventsProcess

	/// <exclude/>
	public class Contact_CrtFinservSalesAndServiceAppEventsProcess : Contact_CrtFinservSalesAndServiceAppEventsProcess<Contact_CrtFinservSalesAndServiceApp_Terrasoft>
	{

		public Contact_CrtFinservSalesAndServiceAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_CrtFinservSalesAndServiceAppEventsProcess

	public partial class Contact_CrtFinservSalesAndServiceAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

