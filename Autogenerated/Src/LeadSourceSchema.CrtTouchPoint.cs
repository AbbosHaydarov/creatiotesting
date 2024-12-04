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

	#region Class: LeadSourceSchema

	/// <exclude/>
	public class LeadSourceSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadSourceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadSourceSchema(LeadSourceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadSourceSchema(LeadSourceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6");
			RealUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6");
			Name = "LeadSource";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6cdbb516-9811-46ca-a4f8-441ae8e11086");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dbd396e5-c9e6-41cd-b877-953d52d5f79b")) == null) {
				Columns.Add(CreateLeadMediumColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadMediumColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dbd396e5-c9e6-41cd-b877-953d52d5f79b"),
				Name = @"LeadMedium",
				ReferenceSchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6"),
				ModifiedInSchemaUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6"),
				CreatedInPackageId = new Guid("6cdbb516-9811-46ca-a4f8-441ae8e11086")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadSource(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadSource_CrtTouchPointEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadSourceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadSourceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("533025a5-cb29-46d5-935a-7e12616d69b6"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadSource

	/// <summary>
	/// Lead source.
	/// </summary>
	public class LeadSource : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadSource(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadSource";
		}

		public LeadSource(LeadSource source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadMediumId {
			get {
				return GetTypedColumnValue<Guid>("LeadMediumId");
			}
			set {
				SetColumnValue("LeadMediumId", value);
				_leadMedium = null;
			}
		}

		/// <exclude/>
		public string LeadMediumName {
			get {
				return GetTypedColumnValue<string>("LeadMediumName");
			}
			set {
				SetColumnValue("LeadMediumName", value);
				if (_leadMedium != null) {
					_leadMedium.Name = value;
				}
			}
		}

		private LeadMedium _leadMedium;
		/// <summary>
		/// Default channel.
		/// </summary>
		public LeadMedium LeadMedium {
			get {
				return _leadMedium ??
					(_leadMedium = LookupColumnEntities.GetEntity("LeadMedium") as LeadMedium);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadSource_CrtTouchPointEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadSourceDeleted", e);
			Validating += (s, e) => ThrowEvent("LeadSourceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadSource(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadSource_CrtTouchPointEventsProcess

	/// <exclude/>
	public partial class LeadSource_CrtTouchPointEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : LeadSource
	{

		public LeadSource_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadSource_CrtTouchPointEventsProcess";
			SchemaUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("533025a5-cb29-46d5-935a-7e12616d69b6");
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

	#region Class: LeadSource_CrtTouchPointEventsProcess

	/// <exclude/>
	public class LeadSource_CrtTouchPointEventsProcess : LeadSource_CrtTouchPointEventsProcess<LeadSource>
	{

		public LeadSource_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadSource_CrtTouchPointEventsProcess

	public partial class LeadSource_CrtTouchPointEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadSourceEventsProcess

	/// <exclude/>
	public class LeadSourceEventsProcess : LeadSource_CrtTouchPointEventsProcess
	{

		public LeadSourceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

