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

	#region Class: ContactCareer_CrtBaseFinserv_TerrasoftSchema

	/// <exclude/>
	public class ContactCareer_CrtBaseFinserv_TerrasoftSchema : Terrasoft.Configuration.ContactCareer_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactCareer_CrtBaseFinserv_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactCareer_CrtBaseFinserv_TerrasoftSchema(ContactCareer_CrtBaseFinserv_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactCareer_CrtBaseFinserv_TerrasoftSchema(ContactCareer_CrtBaseFinserv_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateI74adXnmFiCFKGusIbN0Dbj6qLecIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("17cb5432-9f78-4115-a8c8-643ca03dac9c");
			index.Name = "I74adXnmFiCFKGusIbN0Dbj6qLec";
			index.CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			index.ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			index.CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			EntitySchemaIndexColumn contactIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("05f34390-f7ed-41ff-87b8-8ebf2e779d42"),
				ColumnUId = new Guid("d6628cf3-ba29-472e-b0f2-9b51f693ef2a"),
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(contactIdIndexColumn);
			EntitySchemaIndexColumn accountIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a9d46f67-ad38-46bc-b369-368490bc8e24"),
				ColumnUId = new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854"),
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(accountIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5031063b-2df0-427e-ab6d-f1ed88acbadb");
			Name = "ContactCareer_CrtBaseFinserv_Terrasoft";
			ParentSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4abe1293-1938-40e7-b242-cfd601c2c10c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4247fd0d-cf93-4498-9d76-544e8ee6249d")) == null) {
				Columns.Add(CreateEmploymentTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEmploymentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4247fd0d-cf93-4498-9d76-544e8ee6249d"),
				Name = @"EmploymentType",
				ReferenceSchemaUId = new Guid("77f4f59a-215f-4863-ac49-1bae83dfbb08"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5031063b-2df0-427e-ab6d-f1ed88acbadb"),
				ModifiedInSchemaUId = new Guid("5031063b-2df0-427e-ab6d-f1ed88acbadb"),
				CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateI74adXnmFiCFKGusIbN0Dbj6qLecIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactCareer_CrtBaseFinserv_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactCareer_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactCareer_CrtBaseFinserv_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactCareer_CrtBaseFinserv_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5031063b-2df0-427e-ab6d-f1ed88acbadb"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactCareer_CrtBaseFinserv_Terrasoft

	/// <summary>
	/// Job experience of contact.
	/// </summary>
	public class ContactCareer_CrtBaseFinserv_Terrasoft : Terrasoft.Configuration.ContactCareer_SSP_Terrasoft
	{

		#region Constructors: Public

		public ContactCareer_CrtBaseFinserv_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactCareer_CrtBaseFinserv_Terrasoft";
		}

		public ContactCareer_CrtBaseFinserv_Terrasoft(ContactCareer_CrtBaseFinserv_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EmploymentTypeId {
			get {
				return GetTypedColumnValue<Guid>("EmploymentTypeId");
			}
			set {
				SetColumnValue("EmploymentTypeId", value);
				_employmentType = null;
			}
		}

		/// <exclude/>
		public string EmploymentTypeName {
			get {
				return GetTypedColumnValue<string>("EmploymentTypeName");
			}
			set {
				SetColumnValue("EmploymentTypeName", value);
				if (_employmentType != null) {
					_employmentType.Name = value;
				}
			}
		}

		private EmploymentType _employmentType;
		/// <summary>
		/// Type of employment.
		/// </summary>
		public EmploymentType EmploymentType {
			get {
				return _employmentType ??
					(_employmentType = LookupColumnEntities.GetEntity("EmploymentType") as EmploymentType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactCareer_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactCareer_CrtBaseFinserv_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactCareer_CrtBaseFinserv_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactCareer_CrtBaseFinserv_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactCareer_CrtBaseFinserv_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactCareer_CrtBaseFinserv_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactCareer_CrtBaseFinserv_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ContactCareer_CrtBaseFinserv_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCareer_CrtBaseFinserv_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactCareer_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class ContactCareer_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.ContactCareer_SSPEventsProcess<TEntity> where TEntity : ContactCareer_CrtBaseFinserv_Terrasoft
	{

		public ContactCareer_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactCareer_CrtBaseFinservEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5031063b-2df0-427e-ab6d-f1ed88acbadb");
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

	#region Class: ContactCareer_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class ContactCareer_CrtBaseFinservEventsProcess : ContactCareer_CrtBaseFinservEventsProcess<ContactCareer_CrtBaseFinserv_Terrasoft>
	{

		public ContactCareer_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactCareer_CrtBaseFinservEventsProcess

	public partial class ContactCareer_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

