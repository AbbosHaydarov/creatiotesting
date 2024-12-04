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

	#region Class: SpecInheritedSchema

	/// <exclude/>
	public class SpecInheritedSchema : Terrasoft.Configuration.SpecInherited_CrtFinservProduct_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecInheritedSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecInheritedSchema(SpecInheritedSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecInheritedSchema(SpecInheritedSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d238c049-873e-49a0-88e2-18e68f93db40");
			Name = "SpecInherited";
			ParentSchemaUId = new Guid("4430c857-b064-4c09-b872-6d15dda4fe8a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1d99b280-9a58-47a7-9127-10ddd89d1406")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1d99b280-9a58-47a7-9127-10ddd89d1406"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d238c049-873e-49a0-88e2-18e68f93db40"),
				ModifiedInSchemaUId = new Guid("d238c049-873e-49a0-88e2-18e68f93db40"),
				CreatedInPackageId = new Guid("dfbb9e85-62b1-43e4-abb8-bd76279c7a8b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecInherited(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecInherited_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecInheritedSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecInheritedSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d238c049-873e-49a0-88e2-18e68f93db40"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecInherited

	/// <summary>
	/// Inherited specification value.
	/// </summary>
	public class SpecInherited : Terrasoft.Configuration.SpecInherited_CrtFinservProduct_Terrasoft
	{

		#region Constructors: Public

		public SpecInherited(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecInherited";
		}

		public SpecInherited(SpecInherited source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid FinApplicationId {
			get {
				return GetTypedColumnValue<Guid>("FinApplicationId");
			}
			set {
				SetColumnValue("FinApplicationId", value);
				_finApplication = null;
			}
		}

		/// <exclude/>
		public string FinApplicationNumber {
			get {
				return GetTypedColumnValue<string>("FinApplicationNumber");
			}
			set {
				SetColumnValue("FinApplicationNumber", value);
				if (_finApplication != null) {
					_finApplication.Number = value;
				}
			}
		}

		private FinApplication _finApplication;
		/// <summary>
		/// Application.
		/// </summary>
		public FinApplication FinApplication {
			get {
				return _finApplication ??
					(_finApplication = LookupColumnEntities.GetEntity("FinApplication") as FinApplication);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecInherited_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecInheritedDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecInheritedDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecInheritedInserted", e);
			Inserting += (s, e) => ThrowEvent("SpecInheritedInserting", e);
			Saved += (s, e) => ThrowEvent("SpecInheritedSaved", e);
			Saving += (s, e) => ThrowEvent("SpecInheritedSaving", e);
			Validating += (s, e) => ThrowEvent("SpecInheritedValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecInherited(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecInherited_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class SpecInherited_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.SpecInherited_CrtFinservProductEventsProcess<TEntity> where TEntity : SpecInherited
	{

		public SpecInherited_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecInherited_CrtFinservApplicationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d238c049-873e-49a0-88e2-18e68f93db40");
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

	#region Class: SpecInherited_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class SpecInherited_CrtFinservApplicationEventsProcess : SpecInherited_CrtFinservApplicationEventsProcess<SpecInherited>
	{

		public SpecInherited_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecInherited_CrtFinservApplicationEventsProcess

	public partial class SpecInherited_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecInheritedEventsProcess

	/// <exclude/>
	public class SpecInheritedEventsProcess : SpecInherited_CrtFinservApplicationEventsProcess
	{

		public SpecInheritedEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

