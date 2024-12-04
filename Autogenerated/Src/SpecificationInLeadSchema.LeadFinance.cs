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

	#region Class: SpecificationInLeadSchema

	/// <exclude/>
	public class SpecificationInLeadSchema : Terrasoft.Configuration.SpecificationInLead_CoreLead_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationInLeadSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInLeadSchema(SpecificationInLeadSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInLeadSchema(SpecificationInLeadSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d28432fa-32a8-4d76-a195-4234a725ba5b");
			Name = "SpecificationInLead";
			ParentSchemaUId = new Guid("7d33f0c2-09c8-458d-8de4-0bc823f28260");
			ExtendParent = true;
			CreatedInPackageId = new Guid("51be342d-4f13-4684-ba97-2e8f7a6eb308");
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
			return new SpecificationInLead(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInLead_LeadFinanceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInLeadSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInLeadSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d28432fa-32a8-4d76-a195-4234a725ba5b"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInLead

	/// <summary>
	/// Need parameter.
	/// </summary>
	public class SpecificationInLead : Terrasoft.Configuration.SpecificationInLead_CoreLead_Terrasoft
	{

		#region Constructors: Public

		public SpecificationInLead(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInLead";
		}

		public SpecificationInLead(SpecificationInLead source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInLead_LeadFinanceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInLeadDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecificationInLeadValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInLead(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInLead_LeadFinanceEventsProcess

	/// <exclude/>
	public partial class SpecificationInLead_LeadFinanceEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInLead_CoreLeadEventsProcess<TEntity> where TEntity : SpecificationInLead
	{

		public SpecificationInLead_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInLead_LeadFinanceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d28432fa-32a8-4d76-a195-4234a725ba5b");
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

	#region Class: SpecificationInLead_LeadFinanceEventsProcess

	/// <exclude/>
	public class SpecificationInLead_LeadFinanceEventsProcess : SpecificationInLead_LeadFinanceEventsProcess<SpecificationInLead>
	{

		public SpecificationInLead_LeadFinanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecificationInLead_LeadFinanceEventsProcess

	public partial class SpecificationInLead_LeadFinanceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationInLeadEventsProcess

	/// <exclude/>
	public class SpecificationInLeadEventsProcess : SpecificationInLead_LeadFinanceEventsProcess
	{

		public SpecificationInLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

