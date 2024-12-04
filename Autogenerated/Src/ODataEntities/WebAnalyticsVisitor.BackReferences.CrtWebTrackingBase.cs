namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebAnalyticsVisitor

	/// <exclude/>
	public class WebAnalyticsVisitor : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public WebAnalyticsVisitor(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsVisitor";
		}

		public WebAnalyticsVisitor(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "WebAnalyticsVisitor";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Touch> TouchCollectionByWebAnalyticsVisitor {
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

		/// <exclude/>
		public Guid WebAnalyticsStreamId {
			get {
				return GetTypedColumnValue<Guid>("WebAnalyticsStreamId");
			}
			set {
				SetColumnValue("WebAnalyticsStreamId", value);
				_webAnalyticsStream = null;
			}
		}

		/// <exclude/>
		public string WebAnalyticsStreamName {
			get {
				return GetTypedColumnValue<string>("WebAnalyticsStreamName");
			}
			set {
				SetColumnValue("WebAnalyticsStreamName", value);
				if (_webAnalyticsStream != null) {
					_webAnalyticsStream.Name = value;
				}
			}
		}

		private WebAnalyticsStream _webAnalyticsStream;
		/// <summary>
		/// Web analytics stream.
		/// </summary>
		public WebAnalyticsStream WebAnalyticsStream {
			get {
				return _webAnalyticsStream ??
					(_webAnalyticsStream = new WebAnalyticsStream(LookupColumnEntities.GetEntity("WebAnalyticsStream")));
			}
		}

		/// <summary>
		/// VisitorId.
		/// </summary>
		public string VisitorId {
			get {
				return GetTypedColumnValue<string>("VisitorId");
			}
			set {
				SetColumnValue("VisitorId", value);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = new Contact(LookupColumnEntities.GetEntity("Contact")));
			}
		}

		#endregion

	}

	#endregion

}

