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

	#region Class: EducationSchema

	/// <exclude/>
	public class EducationSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public EducationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EducationSchema(EducationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EducationSchema(EducationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0cd2cddb-839f-48ef-aea1-eb905396f0a1");
			RealUId = new Guid("0cd2cddb-839f-48ef-aea1-eb905396f0a1");
			Name = "Education";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("257ec8a3-4817-4ab0-a9e5-9abd4b2115e6");
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
			return new Education(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Education_CrtBaseFinservEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EducationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EducationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0cd2cddb-839f-48ef-aea1-eb905396f0a1"));
		}

		#endregion

	}

	#endregion

	#region Class: Education

	/// <summary>
	/// Education.
	/// </summary>
	public class Education : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Education(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Education";
		}

		public Education(Education source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Education_CrtBaseFinservEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EducationDeleted", e);
			Validating += (s, e) => ThrowEvent("EducationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Education(this);
		}

		#endregion

	}

	#endregion

	#region Class: Education_CrtBaseFinservEventsProcess

	/// <exclude/>
	public partial class Education_CrtBaseFinservEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : Education
	{

		public Education_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Education_CrtBaseFinservEventsProcess";
			SchemaUId = new Guid("0cd2cddb-839f-48ef-aea1-eb905396f0a1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0cd2cddb-839f-48ef-aea1-eb905396f0a1");
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

	#region Class: Education_CrtBaseFinservEventsProcess

	/// <exclude/>
	public class Education_CrtBaseFinservEventsProcess : Education_CrtBaseFinservEventsProcess<Education>
	{

		public Education_CrtBaseFinservEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Education_CrtBaseFinservEventsProcess

	public partial class Education_CrtBaseFinservEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EducationEventsProcess

	/// <exclude/>
	public class EducationEventsProcess : Education_CrtBaseFinservEventsProcess
	{

		public EducationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

