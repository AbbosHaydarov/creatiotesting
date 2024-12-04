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

	#region Class: LeadQualificationSchema

	/// <exclude/>
	public class LeadQualificationSchema : Terrasoft.Configuration.LeadQualification_CoreLead_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadQualificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadQualificationSchema(LeadQualificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadQualificationSchema(LeadQualificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a");
			Name = "LeadQualification";
			ParentSchemaUId = new Guid("3e76137e-09bc-41af-9df2-38f840e14732");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6d3c150d-8ff3-423c-a7d3-b65b61ee218f");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1b3887cc-4c22-47d8-ad9a-1ea2f6340961")) == null) {
				Columns.Add(CreateLeadContactSurnameColumn());
			}
			if (Columns.FindByUId(new Guid("5e7cdf01-6710-43ad-bb41-069f3eedd7dd")) == null) {
				Columns.Add(CreateLeadContactGivenNameColumn());
			}
			if (Columns.FindByUId(new Guid("bdd49d43-6439-433c-a16a-a61f3ba9dc76")) == null) {
				Columns.Add(CreateLeadContactMiddleNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadContactSurnameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1b3887cc-4c22-47d8-ad9a-1ea2f6340961"),
				Name = @"LeadContactSurname",
				CreatedInSchemaUId = new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a"),
				ModifiedInSchemaUId = new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a"),
				CreatedInPackageId = new Guid("6d3c150d-8ff3-423c-a7d3-b65b61ee218f")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadContactGivenNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5e7cdf01-6710-43ad-bb41-069f3eedd7dd"),
				Name = @"LeadContactGivenName",
				CreatedInSchemaUId = new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a"),
				ModifiedInSchemaUId = new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a"),
				CreatedInPackageId = new Guid("6d3c150d-8ff3-423c-a7d3-b65b61ee218f")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadContactMiddleNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("bdd49d43-6439-433c-a16a-a61f3ba9dc76"),
				Name = @"LeadContactMiddleName",
				CreatedInSchemaUId = new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a"),
				ModifiedInSchemaUId = new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a"),
				CreatedInPackageId = new Guid("6d3c150d-8ff3-423c-a7d3-b65b61ee218f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadQualification(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadQualification_LeadFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadQualificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadQualificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadQualification

	/// <summary>
	/// Qualified lead.
	/// </summary>
	public class LeadQualification : Terrasoft.Configuration.LeadQualification_CoreLead_Terrasoft
	{

		#region Constructors: Public

		public LeadQualification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadQualification";
		}

		public LeadQualification(LeadQualification source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Last name.
		/// </summary>
		public string LeadContactSurname {
			get {
				return GetTypedColumnValue<string>("LeadContactSurname");
			}
			set {
				SetColumnValue("LeadContactSurname", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string LeadContactGivenName {
			get {
				return GetTypedColumnValue<string>("LeadContactGivenName");
			}
			set {
				SetColumnValue("LeadContactGivenName", value);
			}
		}

		/// <summary>
		/// Middle name.
		/// </summary>
		public string LeadContactMiddleName {
			get {
				return GetTypedColumnValue<string>("LeadContactMiddleName");
			}
			set {
				SetColumnValue("LeadContactMiddleName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadQualification_LeadFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadQualificationDeleted", e);
			Validating += (s, e) => ThrowEvent("LeadQualificationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadQualification(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadQualification_LeadFinanceEventsProcess

	/// <exclude/>
	public partial class LeadQualification_LeadFinanceEventsProcess<TEntity> : Terrasoft.Configuration.LeadQualification_CoreLeadEventsProcess<TEntity> where TEntity : LeadQualification
	{

		public LeadQualification_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadQualification_LeadFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4c5dbb21-cea3-42e0-8993-56a433b33f8a");
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

	#region Class: LeadQualification_LeadFinanceEventsProcess

	/// <exclude/>
	public class LeadQualification_LeadFinanceEventsProcess : LeadQualification_LeadFinanceEventsProcess<LeadQualification>
	{

		public LeadQualification_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadQualification_LeadFinanceEventsProcess

	public partial class LeadQualification_LeadFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadQualificationEventsProcess

	/// <exclude/>
	public class LeadQualificationEventsProcess : LeadQualification_LeadFinanceEventsProcess
	{

		public LeadQualificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

