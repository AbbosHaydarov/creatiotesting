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

	#region Class: AppFormAddressSchema

	/// <exclude/>
	public class AppFormAddressSchema : Terrasoft.Configuration.BaseAddressSchema
	{

		#region Constructors: Public

		public AppFormAddressSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AppFormAddressSchema(AppFormAddressSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AppFormAddressSchema(AppFormAddressSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9bb1fcf8-271b-4535-bb96-1032313255d7");
			RealUId = new Guid("9bb1fcf8-271b-4535-bb96-1032313255d7");
			Name = "AppFormAddress";
			ParentSchemaUId = new Guid("400e8687-9616-480d-9d81-61de0235cc86");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cb8caf3d-0a52-4429-8403-c7b65aaa6978")) == null) {
				Columns.Add(CreateAppFormColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAppFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cb8caf3d-0a52-4429-8403-c7b65aaa6978"),
				Name = @"AppForm",
				ReferenceSchemaUId = new Guid("6a8b2e56-3afe-4495-923a-f33f8379dc97"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9bb1fcf8-271b-4535-bb96-1032313255d7"),
				ModifiedInSchemaUId = new Guid("9bb1fcf8-271b-4535-bb96-1032313255d7"),
				CreatedInPackageId = new Guid("1f0850f5-bf97-4777-9ded-d9a21db6c4bc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AppFormAddress(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AppFormAddress_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AppFormAddressSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AppFormAddressSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9bb1fcf8-271b-4535-bb96-1032313255d7"));
		}

		#endregion

	}

	#endregion

	#region Class: AppFormAddress

	/// <summary>
	/// Address in application form.
	/// </summary>
	public class AppFormAddress : Terrasoft.Configuration.BaseAddress
	{

		#region Constructors: Public

		public AppFormAddress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppFormAddress";
		}

		public AppFormAddress(AppFormAddress source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AppFormId {
			get {
				return GetTypedColumnValue<Guid>("AppFormId");
			}
			set {
				SetColumnValue("AppFormId", value);
				_appForm = null;
			}
		}

		/// <exclude/>
		public string AppFormParticipant {
			get {
				return GetTypedColumnValue<string>("AppFormParticipant");
			}
			set {
				SetColumnValue("AppFormParticipant", value);
				if (_appForm != null) {
					_appForm.Participant = value;
				}
			}
		}

		private AppForm _appForm;
		/// <summary>
		/// Application form.
		/// </summary>
		public AppForm AppForm {
			get {
				return _appForm ??
					(_appForm = LookupColumnEntities.GetEntity("AppForm") as AppForm);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AppFormAddress_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AppFormAddressDeleted", e);
			Deleting += (s, e) => ThrowEvent("AppFormAddressDeleting", e);
			Inserted += (s, e) => ThrowEvent("AppFormAddressInserted", e);
			Inserting += (s, e) => ThrowEvent("AppFormAddressInserting", e);
			Saved += (s, e) => ThrowEvent("AppFormAddressSaved", e);
			Saving += (s, e) => ThrowEvent("AppFormAddressSaving", e);
			Validating += (s, e) => ThrowEvent("AppFormAddressValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AppFormAddress(this);
		}

		#endregion

	}

	#endregion

	#region Class: AppFormAddress_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class AppFormAddress_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseAddress_AddressFinanceEventsProcess<TEntity> where TEntity : AppFormAddress
	{

		public AppFormAddress_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AppFormAddress_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("9bb1fcf8-271b-4535-bb96-1032313255d7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9bb1fcf8-271b-4535-bb96-1032313255d7");
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

	#region Class: AppFormAddress_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class AppFormAddress_CrtFinservApplicationEventsProcess : AppFormAddress_CrtFinservApplicationEventsProcess<AppFormAddress>
	{

		public AppFormAddress_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AppFormAddress_CrtFinservApplicationEventsProcess

	public partial class AppFormAddress_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AppFormAddressEventsProcess

	/// <exclude/>
	public class AppFormAddressEventsProcess : AppFormAddress_CrtFinservApplicationEventsProcess
	{

		public AppFormAddressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

