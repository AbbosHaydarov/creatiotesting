namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebAnalyticsStream

	/// <exclude/>
	public class WebAnalyticsStream : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public WebAnalyticsStream(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebAnalyticsStream";
		}

		public WebAnalyticsStream(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "WebAnalyticsStream";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WebAnalyticsVisitor> WebAnalyticsVisitorCollectionByWebAnalyticsStream {
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
		public Guid WebAnalyticsAccountId {
			get {
				return GetTypedColumnValue<Guid>("WebAnalyticsAccountId");
			}
			set {
				SetColumnValue("WebAnalyticsAccountId", value);
				_webAnalyticsAccount = null;
			}
		}

		/// <exclude/>
		public string WebAnalyticsAccountName {
			get {
				return GetTypedColumnValue<string>("WebAnalyticsAccountName");
			}
			set {
				SetColumnValue("WebAnalyticsAccountName", value);
				if (_webAnalyticsAccount != null) {
					_webAnalyticsAccount.Name = value;
				}
			}
		}

		private WebAnalyticsAccount _webAnalyticsAccount;
		/// <summary>
		/// Web analytics account.
		/// </summary>
		public WebAnalyticsAccount WebAnalyticsAccount {
			get {
				return _webAnalyticsAccount ??
					(_webAnalyticsAccount = new WebAnalyticsAccount(LookupColumnEntities.GetEntity("WebAnalyticsAccount")));
			}
		}

		/// <summary>
		/// Stream Id.
		/// </summary>
		public string StreamId {
			get {
				return GetTypedColumnValue<string>("StreamId");
			}
			set {
				SetColumnValue("StreamId", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Google analytics property Id.
		/// </summary>
		public string GAPropertyId {
			get {
				return GetTypedColumnValue<string>("GAPropertyId");
			}
			set {
				SetColumnValue("GAPropertyId", value);
			}
		}

		/// <summary>
		/// URL.
		/// </summary>
		public string SiteUrl {
			get {
				return GetTypedColumnValue<string>("SiteUrl");
			}
			set {
				SetColumnValue("SiteUrl", value);
			}
		}

		/// <summary>
		/// Measurement id.
		/// </summary>
		public string MeasurementId {
			get {
				return GetTypedColumnValue<string>("MeasurementId");
			}
			set {
				SetColumnValue("MeasurementId", value);
			}
		}

		#endregion

	}

	#endregion

}

