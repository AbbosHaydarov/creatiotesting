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

	#region Class: CopilotIntentPageQuickLinksSchema

	/// <exclude/>
	public class CopilotIntentPageQuickLinksSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CopilotIntentPageQuickLinksSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CopilotIntentPageQuickLinksSchema(CopilotIntentPageQuickLinksSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CopilotIntentPageQuickLinksSchema(CopilotIntentPageQuickLinksSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreatePageNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("d472e3db-2dc5-4e8d-9a20-181856f2467d");
			index.Name = "PageName";
			index.CreatedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670");
			index.ModifiedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670");
			index.CreatedInPackageId = new Guid("125b7a8a-c96a-4aa1-a9da-b53467f2b91f");
			EntitySchemaIndexColumn pageNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("553f65e0-2860-6988-460e-f737441f2fe0"),
				ColumnUId = new Guid("c110d2f0-8972-53bd-8071-a349512215c9"),
				CreatedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670"),
				ModifiedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670"),
				CreatedInPackageId = new Guid("125b7a8a-c96a-4aa1-a9da-b53467f2b91f"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(pageNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670");
			RealUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670");
			Name = "CopilotIntentPageQuickLinks";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("125b7a8a-c96a-4aa1-a9da-b53467f2b91f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("abce90b9-1401-3ac3-18c6-abfcd3ca10b3")) == null) {
				Columns.Add(CreateIntentCodeColumn());
			}
			if (Columns.FindByUId(new Guid("c110d2f0-8972-53bd-8071-a349512215c9")) == null) {
				Columns.Add(CreatePageNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670");
			return column;
		}

		protected virtual EntitySchemaColumn CreateIntentCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("abce90b9-1401-3ac3-18c6-abfcd3ca10b3"),
				Name = @"IntentCode",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670"),
				ModifiedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670"),
				CreatedInPackageId = new Guid("125b7a8a-c96a-4aa1-a9da-b53467f2b91f")
			};
		}

		protected virtual EntitySchemaColumn CreatePageNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c110d2f0-8972-53bd-8071-a349512215c9"),
				Name = @"PageName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670"),
				ModifiedInSchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670"),
				CreatedInPackageId = new Guid("125b7a8a-c96a-4aa1-a9da-b53467f2b91f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreatePageNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CopilotIntentPageQuickLinks(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CopilotIntentPageQuickLinks_CrtCopilotEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CopilotIntentPageQuickLinksSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CopilotIntentPageQuickLinksSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670"));
		}

		#endregion

	}

	#endregion

	#region Class: CopilotIntentPageQuickLinks

	/// <summary>
	/// Copilot intent page quick links.
	/// </summary>
	/// <remarks>
	/// Used to link which intents should be displayed in the quick access panel on a specific page.
	/// </remarks>
	public class CopilotIntentPageQuickLinks : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CopilotIntentPageQuickLinks(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CopilotIntentPageQuickLinks";
		}

		public CopilotIntentPageQuickLinks(CopilotIntentPageQuickLinks source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Intent code.
		/// </summary>
		public string IntentCode {
			get {
				return GetTypedColumnValue<string>("IntentCode");
			}
			set {
				SetColumnValue("IntentCode", value);
			}
		}

		/// <summary>
		/// Page name.
		/// </summary>
		public string PageName {
			get {
				return GetTypedColumnValue<string>("PageName");
			}
			set {
				SetColumnValue("PageName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CopilotIntentPageQuickLinks_CrtCopilotEventsProcess(UserConnection);
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
			return new CopilotIntentPageQuickLinks(this);
		}

		#endregion

	}

	#endregion

	#region Class: CopilotIntentPageQuickLinks_CrtCopilotEventsProcess

	/// <exclude/>
	public partial class CopilotIntentPageQuickLinks_CrtCopilotEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CopilotIntentPageQuickLinks
	{

		public CopilotIntentPageQuickLinks_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CopilotIntentPageQuickLinks_CrtCopilotEventsProcess";
			SchemaUId = new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4aea0dc2-80ec-4784-a69f-dff46196d670");
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

	#region Class: CopilotIntentPageQuickLinks_CrtCopilotEventsProcess

	/// <exclude/>
	public class CopilotIntentPageQuickLinks_CrtCopilotEventsProcess : CopilotIntentPageQuickLinks_CrtCopilotEventsProcess<CopilotIntentPageQuickLinks>
	{

		public CopilotIntentPageQuickLinks_CrtCopilotEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CopilotIntentPageQuickLinks_CrtCopilotEventsProcess

	public partial class CopilotIntentPageQuickLinks_CrtCopilotEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CopilotIntentPageQuickLinksEventsProcess

	/// <exclude/>
	public class CopilotIntentPageQuickLinksEventsProcess : CopilotIntentPageQuickLinks_CrtCopilotEventsProcess
	{

		public CopilotIntentPageQuickLinksEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

