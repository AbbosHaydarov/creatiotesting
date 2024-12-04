﻿namespace Terrasoft.Configuration
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

	#region Class: SpecificationTypeSchema

	/// <exclude/>
	public class SpecificationTypeSchema : Terrasoft.Configuration.SpecificationType_CrtSpecification_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationTypeSchema(SpecificationTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationTypeSchema(SpecificationTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f40fa073-c28a-4238-9aba-17bf10cb4290");
			Name = "SpecificationType";
			ParentSchemaUId = new Guid("787ae6a1-f727-4c4e-964a-c09e24083810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b5695b7-ad48-40fb-8123-71e215886a84");
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
			return new SpecificationType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationType_CrtFinservSpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f40fa073-c28a-4238-9aba-17bf10cb4290"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationType

	/// <summary>
	/// Parameter type.
	/// </summary>
	public class SpecificationType : Terrasoft.Configuration.SpecificationType_CrtSpecification_Terrasoft
	{

		#region Constructors: Public

		public SpecificationType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationType";
		}

		public SpecificationType(SpecificationType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationType_CrtFinservSpecificationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("SpecificationTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("SpecificationTypeInserted", e);
			Saved += (s, e) => ThrowEvent("SpecificationTypeSaved", e);
			Saving += (s, e) => ThrowEvent("SpecificationTypeSaving", e);
			Validating += (s, e) => ThrowEvent("SpecificationTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationType(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationType_CrtFinservSpecificationEventsProcess

	/// <exclude/>
	public partial class SpecificationType_CrtFinservSpecificationEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationType_CrtSpecificationEventsProcess<TEntity> where TEntity : SpecificationType
	{

		public SpecificationType_CrtFinservSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationType_CrtFinservSpecificationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f40fa073-c28a-4238-9aba-17bf10cb4290");
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

	#region Class: SpecificationType_CrtFinservSpecificationEventsProcess

	/// <exclude/>
	public class SpecificationType_CrtFinservSpecificationEventsProcess : SpecificationType_CrtFinservSpecificationEventsProcess<SpecificationType>
	{

		public SpecificationType_CrtFinservSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationType_CrtFinservSpecificationEventsProcess

	public partial class SpecificationType_CrtFinservSpecificationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationTypeEventsProcess

	/// <exclude/>
	public class SpecificationTypeEventsProcess : SpecificationType_CrtFinservSpecificationEventsProcess
	{

		public SpecificationTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

