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

	#region Class: OpportunityInTagSchema

	/// <exclude/>
	public class OpportunityInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public OpportunityInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityInTagSchema(OpportunityInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityInTagSchema(OpportunityInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff25bc2c-cc51-4654-932d-c89bc4d90db4");
			RealUId = new Guid("ff25bc2c-cc51-4654-932d-c89bc4d90db4");
			Name = "OpportunityInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("7e18476b-185f-406b-b415-b942b35b4c0b");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("ff25bc2c-cc51-4654-932d-c89bc4d90db4");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityTitle";
			column.ModifiedInSchemaUId = new Guid("ff25bc2c-cc51-4654-932d-c89bc4d90db4");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityInTag_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff25bc2c-cc51-4654-932d-c89bc4d90db4"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityInTag

	/// <summary>
	/// Opportunities section record tag.
	/// </summary>
	public class OpportunityInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public OpportunityInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityInTag";
		}

		public OpportunityInTag(OpportunityInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityInTag_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityInTag_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityInTag_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtCoreBaseEventsProcess<TEntity> where TEntity : OpportunityInTag
	{

		public OpportunityInTag_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityInTag_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("ff25bc2c-cc51-4654-932d-c89bc4d90db4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ff25bc2c-cc51-4654-932d-c89bc4d90db4");
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

	#region Class: OpportunityInTag_CrtOpportunityEventsProcess

	/// <exclude/>
	public class OpportunityInTag_CrtOpportunityEventsProcess : OpportunityInTag_CrtOpportunityEventsProcess<OpportunityInTag>
	{

		public OpportunityInTag_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityInTag_CrtOpportunityEventsProcess

	public partial class OpportunityInTag_CrtOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityInTagEventsProcess

	/// <exclude/>
	public class OpportunityInTagEventsProcess : OpportunityInTag_CrtOpportunityEventsProcess
	{

		public OpportunityInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

