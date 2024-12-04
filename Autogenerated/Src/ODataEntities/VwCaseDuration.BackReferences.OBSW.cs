namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwCaseDuration

	/// <exclude/>
	public class VwCaseDuration : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwCaseDuration(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwCaseDuration";
		}

		public VwCaseDuration(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "VwCaseDuration";
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
		/// Total number of seconds.
		/// </summary>
		public int TotalSeconds {
			get {
				return GetTypedColumnValue<int>("TotalSeconds");
			}
			set {
				SetColumnValue("TotalSeconds", value);
			}
		}

		/// <summary>
		/// Last date of active state.
		/// </summary>
		public DateTime LastActiveDate {
			get {
				return GetTypedColumnValue<DateTime>("LastActiveDate");
			}
			set {
				SetColumnValue("LastActiveDate", value);
			}
		}

		#endregion

	}

	#endregion

}

