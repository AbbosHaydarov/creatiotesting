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

	#region Class: LeadMediumSchema

	/// <exclude/>
	public class LeadMediumSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadMediumSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadMediumSchema(LeadMediumSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadMediumSchema(LeadMediumSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
			RealUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
			Name = "LeadMedium";
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadMedium(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadMedium_CrtTouchPointEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadMediumSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadMediumSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadMedium

	/// <summary>
	/// Lead channel.
	/// </summary>
	public class LeadMedium : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadMedium(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadMedium";
		}

		public LeadMedium(LeadMedium source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadMedium_CrtTouchPointEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadMediumDeleted", e);
			Validating += (s, e) => ThrowEvent("LeadMediumValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadMedium(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadMedium_CrtTouchPointEventsProcess

	/// <exclude/>
	public partial class LeadMedium_CrtTouchPointEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtCoreBaseEventsProcess<TEntity> where TEntity : LeadMedium
	{

		public LeadMedium_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadMedium_CrtTouchPointEventsProcess";
			SchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
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

	#region Class: LeadMedium_CrtTouchPointEventsProcess

	/// <exclude/>
	public class LeadMedium_CrtTouchPointEventsProcess : LeadMedium_CrtTouchPointEventsProcess<LeadMedium>
	{

		public LeadMedium_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadMedium_CrtTouchPointEventsProcess

	public partial class LeadMedium_CrtTouchPointEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadMediumEventsProcess

	/// <exclude/>
	public class LeadMediumEventsProcess : LeadMedium_CrtTouchPointEventsProcess
	{

		public LeadMediumEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

