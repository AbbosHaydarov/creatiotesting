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

	#region Class: QualificationSchema

	/// <exclude/>
	public class QualificationSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public QualificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QualificationSchema(QualificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QualificationSchema(QualificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("74e97118-b269-428f-89a0-d6047ee66673");
			RealUId = new Guid("74e97118-b269-428f-89a0-d6047ee66673");
			Name = "Qualification";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6d264e00-0113-471a-aef7-55e7b844e13c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
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
			return new Qualification(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Qualification_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new QualificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QualificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74e97118-b269-428f-89a0-d6047ee66673"));
		}

		#endregion

	}

	#endregion

	#region Class: Qualification

	/// <summary>
	/// Qualification.
	/// </summary>
	public class Qualification : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Qualification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Qualification";
		}

		public Qualification(Qualification source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Qualification_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("QualificationDeleted", e);
			Validating += (s, e) => ThrowEvent("QualificationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Qualification(this);
		}

		#endregion

	}

	#endregion

	#region Class: Qualification_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class Qualification_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : Qualification
	{

		public Qualification_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Qualification_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("74e97118-b269-428f-89a0-d6047ee66673");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("74e97118-b269-428f-89a0-d6047ee66673");
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

	#region Class: Qualification_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class Qualification_CrtFinservApplicationEventsProcess : Qualification_CrtFinservApplicationEventsProcess<Qualification>
	{

		public Qualification_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Qualification_CrtFinservApplicationEventsProcess

	public partial class Qualification_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: QualificationEventsProcess

	/// <exclude/>
	public class QualificationEventsProcess : Qualification_CrtFinservApplicationEventsProcess
	{

		public QualificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

