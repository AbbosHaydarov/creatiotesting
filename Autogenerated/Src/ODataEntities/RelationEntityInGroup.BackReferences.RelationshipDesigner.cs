﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RelationEntityInGroup

	/// <exclude/>
	public class RelationEntityInGroup : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public RelationEntityInGroup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RelationEntityInGroup";
		}

		public RelationEntityInGroup(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "RelationEntityInGroup";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

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

		/// <exclude/>
		public Guid RelationshipEntityId {
			get {
				return GetTypedColumnValue<Guid>("RelationshipEntityId");
			}
			set {
				SetColumnValue("RelationshipEntityId", value);
				_relationshipEntity = null;
			}
		}

		private RelationshipEntity _relationshipEntity;
		/// <summary>
		/// Entity.
		/// </summary>
		public RelationshipEntity RelationshipEntity {
			get {
				return _relationshipEntity ??
					(_relationshipEntity = new RelationshipEntity(LookupColumnEntities.GetEntity("RelationshipEntity")));
			}
		}

		/// <exclude/>
		public Guid RelationshipGroupId {
			get {
				return GetTypedColumnValue<Guid>("RelationshipGroupId");
			}
			set {
				SetColumnValue("RelationshipGroupId", value);
				_relationshipGroup = null;
			}
		}

		private RelationshipGroup _relationshipGroup;
		/// <summary>
		/// Entity group.
		/// </summary>
		public RelationshipGroup RelationshipGroup {
			get {
				return _relationshipGroup ??
					(_relationshipGroup = new RelationshipGroup(LookupColumnEntities.GetEntity("RelationshipGroup")));
			}
		}

		/// <summary>
		/// Comment.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		#endregion

	}

	#endregion

}

