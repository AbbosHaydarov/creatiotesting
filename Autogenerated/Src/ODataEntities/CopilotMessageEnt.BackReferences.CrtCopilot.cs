namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CopilotMessageEnt

	/// <exclude/>
	public class CopilotMessageEnt : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CopilotMessageEnt(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CopilotMessageEnt";
		}

		public CopilotMessageEnt(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "CopilotMessageEnt";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CopilotToolCallEnt> CopilotToolCallEntCollectionByCopilotMessage {
			get;
			set;
		}

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

		/// <summary>
		/// ToolCall identifier.
		/// </summary>
		public string ToolCallId {
			get {
				return GetTypedColumnValue<string>("ToolCallId");
			}
			set {
				SetColumnValue("ToolCallId", value);
			}
		}

		/// <exclude/>
		public Guid RoleId {
			get {
				return GetTypedColumnValue<Guid>("RoleId");
			}
			set {
				SetColumnValue("RoleId", value);
				_role = null;
			}
		}

		/// <exclude/>
		public string RoleName {
			get {
				return GetTypedColumnValue<string>("RoleName");
			}
			set {
				SetColumnValue("RoleName", value);
				if (_role != null) {
					_role.Name = value;
				}
			}
		}

		private CopilotMessageRoleEnt _role;
		/// <summary>
		/// Role.
		/// </summary>
		public CopilotMessageRoleEnt Role {
			get {
				return _role ??
					(_role = new CopilotMessageRoleEnt(LookupColumnEntities.GetEntity("Role")));
			}
		}

		/// <summary>
		/// Content.
		/// </summary>
		public string Content {
			get {
				return GetTypedColumnValue<string>("Content");
			}
			set {
				SetColumnValue("Content", value);
			}
		}

		/// <exclude/>
		public Guid CopilotSessionId {
			get {
				return GetTypedColumnValue<Guid>("CopilotSessionId");
			}
			set {
				SetColumnValue("CopilotSessionId", value);
				_copilotSession = null;
			}
		}

		/// <exclude/>
		public string CopilotSessionTitle {
			get {
				return GetTypedColumnValue<string>("CopilotSessionTitle");
			}
			set {
				SetColumnValue("CopilotSessionTitle", value);
				if (_copilotSession != null) {
					_copilotSession.Title = value;
				}
			}
		}

		private CopilotSessionEnt _copilotSession;
		/// <summary>
		/// Copilot Session.
		/// </summary>
		public CopilotSessionEnt CopilotSession {
			get {
				return _copilotSession ??
					(_copilotSession = new CopilotSessionEnt(LookupColumnEntities.GetEntity("CopilotSession")));
			}
		}

		/// <exclude/>
		public Guid IntentId {
			get {
				return GetTypedColumnValue<Guid>("IntentId");
			}
			set {
				SetColumnValue("IntentId", value);
				_intent = null;
			}
		}

		/// <exclude/>
		public string IntentCaption {
			get {
				return GetTypedColumnValue<string>("IntentCaption");
			}
			set {
				SetColumnValue("IntentCaption", value);
				if (_intent != null) {
					_intent.Caption = value;
				}
			}
		}

		private VwSysSchemaInfo _intent;
		/// <summary>
		/// Intent.
		/// </summary>
		public VwSysSchemaInfo Intent {
			get {
				return _intent ??
					(_intent = new VwSysSchemaInfo(LookupColumnEntities.GetEntity("Intent")));
			}
		}

		/// <exclude/>
		public Guid CopilotRequestId {
			get {
				return GetTypedColumnValue<Guid>("CopilotRequestId");
			}
			set {
				SetColumnValue("CopilotRequestId", value);
				_copilotRequest = null;
			}
		}

		private CopilotRequestEnt _copilotRequest;
		/// <summary>
		/// Copilot Request.
		/// </summary>
		/// <remarks>
		/// Copilot Request.
		/// </remarks>
		public CopilotRequestEnt CopilotRequest {
			get {
				return _copilotRequest ??
					(_copilotRequest = new CopilotRequestEnt(LookupColumnEntities.GetEntity("CopilotRequest")));
			}
		}

		#endregion

	}

	#endregion

}

