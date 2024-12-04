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
	using Terrasoft.Configuration;
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

	#region Class: FinApplicationFileSchema

	/// <exclude/>
	public class FinApplicationFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public FinApplicationFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FinApplicationFileSchema(FinApplicationFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FinApplicationFileSchema(FinApplicationFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5145c5bc-e44a-4d2a-8463-20d4e20072c1");
			RealUId = new Guid("5145c5bc-e44a-4d2a-8463-20d4e20072c1");
			Name = "FinApplicationFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5d8512b8-f418-4a9d-bdfc-68683d2fba13")) == null) {
				Columns.Add(CreateFinApplicationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFinApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5d8512b8-f418-4a9d-bdfc-68683d2fba13"),
				Name = @"FinApplication",
				ReferenceSchemaUId = new Guid("cdda1304-e571-42de-9df7-6dfe528ea7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5145c5bc-e44a-4d2a-8463-20d4e20072c1"),
				ModifiedInSchemaUId = new Guid("5145c5bc-e44a-4d2a-8463-20d4e20072c1"),
				CreatedInPackageId = new Guid("1b80d0d5-8546-4bd8-8bcd-d6a0825f768b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FinApplicationFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FinApplicationFile_CrtFinservApplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FinApplicationFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FinApplicationFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5145c5bc-e44a-4d2a-8463-20d4e20072c1"));
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationFile

	/// <summary>
	/// Application attachment.
	/// </summary>
	public class FinApplicationFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public FinApplicationFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FinApplicationFile";
		}

		public FinApplicationFile(FinApplicationFile source)
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
			var process = new FinApplicationFile_CrtFinservApplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FinApplicationFileDeleted", e);
			Updated += (s, e) => ThrowEvent("FinApplicationFileUpdated", e);
			Validating += (s, e) => ThrowEvent("FinApplicationFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FinApplicationFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: FinApplicationFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public partial class FinApplicationFile_CrtFinservApplicationEventsProcess<TEntity> : Terrasoft.Configuration.File_LinkPreviewEventsProcess<TEntity> where TEntity : FinApplicationFile
	{

		public FinApplicationFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FinApplicationFile_CrtFinservApplicationEventsProcess";
			SchemaUId = new Guid("5145c5bc-e44a-4d2a-8463-20d4e20072c1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5145c5bc-e44a-4d2a-8463-20d4e20072c1");
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

	#region Class: FinApplicationFile_CrtFinservApplicationEventsProcess

	/// <exclude/>
	public class FinApplicationFile_CrtFinservApplicationEventsProcess : FinApplicationFile_CrtFinservApplicationEventsProcess<FinApplicationFile>
	{

		public FinApplicationFile_CrtFinservApplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FinApplicationFile_CrtFinservApplicationEventsProcess

	public partial class FinApplicationFile_CrtFinservApplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FinApplicationFileEventsProcess

	/// <exclude/>
	public class FinApplicationFileEventsProcess : FinApplicationFile_CrtFinservApplicationEventsProcess
	{

		public FinApplicationFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

