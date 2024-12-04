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

	#region Class: PeriodType_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class PeriodType_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public PeriodType_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PeriodType_CrtBase_TerrasoftSchema(PeriodType_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PeriodType_CrtBase_TerrasoftSchema(PeriodType_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3608a0e4-0235-4936-9c0e-99620e73940c");
			RealUId = new Guid("3608a0e4-0235-4936-9c0e-99620e73940c");
			Name = "PeriodType_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("bb5b13b5-8833-41e4-a262-01f88b33e376");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PeriodType_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PeriodType_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PeriodType_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PeriodType_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3608a0e4-0235-4936-9c0e-99620e73940c"));
		}

		#endregion

	}

	#endregion

	#region Class: PeriodType_CrtBase_Terrasoft

	/// <summary>
	/// Period type.
	/// </summary>
	public class PeriodType_CrtBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public PeriodType_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PeriodType_CrtBase_Terrasoft";
		}

		public PeriodType_CrtBase_Terrasoft(PeriodType_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PeriodType_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PeriodType_CrtBase_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("PeriodType_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PeriodType_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: PeriodType_CrtBaseEventsProcess

	/// <exclude/>
	public partial class PeriodType_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : PeriodType_CrtBase_Terrasoft
	{

		public PeriodType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PeriodType_CrtBaseEventsProcess";
			SchemaUId = new Guid("3608a0e4-0235-4936-9c0e-99620e73940c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3608a0e4-0235-4936-9c0e-99620e73940c");
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

	#region Class: PeriodType_CrtBaseEventsProcess

	/// <exclude/>
	public class PeriodType_CrtBaseEventsProcess : PeriodType_CrtBaseEventsProcess<PeriodType_CrtBase_Terrasoft>
	{

		public PeriodType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PeriodType_CrtBaseEventsProcess

	public partial class PeriodType_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

