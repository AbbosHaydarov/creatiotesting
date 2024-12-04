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

	#region Class: SpecificationInLeadTypeSchema

	/// <exclude/>
	public class SpecificationInLeadTypeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecificationInLeadTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInLeadTypeSchema(SpecificationInLeadTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInLeadTypeSchema(SpecificationInLeadTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32");
			RealUId = new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32");
			Name = "SpecificationInLeadType";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5bbcd9c3-8540-42ad-affa-e89ba1f18d53");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("086e04e6-275b-4069-af68-c3f06cc5717f")) == null) {
				Columns.Add(CreateLeadTypeColumn());
			}
			if (Columns.FindByUId(new Guid("298949ec-fc06-4602-b0d2-1de4f2cf1464")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("086e04e6-275b-4069-af68-c3f06cc5717f"),
				Name = @"LeadType",
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32"),
				ModifiedInSchemaUId = new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32"),
				CreatedInPackageId = new Guid("5bbcd9c3-8540-42ad-affa-e89ba1f18d53")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("298949ec-fc06-4602-b0d2-1de4f2cf1464"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32"),
				ModifiedInSchemaUId = new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32"),
				CreatedInPackageId = new Guid("5bbcd9c3-8540-42ad-affa-e89ba1f18d53")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationInLeadType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInLeadType_LeadFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInLeadTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInLeadTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInLeadType

	/// <summary>
	/// Need type parameter.
	/// </summary>
	public class SpecificationInLeadType : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecificationInLeadType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInLeadType";
		}

		public SpecificationInLeadType(SpecificationInLeadType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadTypeId {
			get {
				return GetTypedColumnValue<Guid>("LeadTypeId");
			}
			set {
				SetColumnValue("LeadTypeId", value);
				_leadType = null;
			}
		}

		/// <exclude/>
		public string LeadTypeName {
			get {
				return GetTypedColumnValue<string>("LeadTypeName");
			}
			set {
				SetColumnValue("LeadTypeName", value);
				if (_leadType != null) {
					_leadType.Name = value;
				}
			}
		}

		private LeadType _leadType;
		/// <summary>
		/// Customer need.
		/// </summary>
		public LeadType LeadType {
			get {
				return _leadType ??
					(_leadType = LookupColumnEntities.GetEntity("LeadType") as LeadType);
			}
		}

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Parameter.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInLeadType_LeadFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInLeadTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecificationInLeadTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInLeadType(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInLeadType_LeadFinanceEventsProcess

	/// <exclude/>
	public partial class SpecificationInLeadType_LeadFinanceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SpecificationInLeadType
	{

		public SpecificationInLeadType_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInLeadType_LeadFinanceEventsProcess";
			SchemaUId = new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4fb04432-2b96-42f5-86e7-ab1663230a32");
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

	#region Class: SpecificationInLeadType_LeadFinanceEventsProcess

	/// <exclude/>
	public class SpecificationInLeadType_LeadFinanceEventsProcess : SpecificationInLeadType_LeadFinanceEventsProcess<SpecificationInLeadType>
	{

		public SpecificationInLeadType_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInLeadType_LeadFinanceEventsProcess

	public partial class SpecificationInLeadType_LeadFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationInLeadTypeEventsProcess

	/// <exclude/>
	public class SpecificationInLeadTypeEventsProcess : SpecificationInLeadType_LeadFinanceEventsProcess
	{

		public SpecificationInLeadTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

