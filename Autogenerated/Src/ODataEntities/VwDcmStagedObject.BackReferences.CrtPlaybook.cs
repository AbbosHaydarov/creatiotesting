namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwDcmStagedObject

	/// <exclude/>
	public class VwDcmStagedObject : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwDcmStagedObject(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwDcmStagedObject";
		}

		public VwDcmStagedObject(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "VwDcmStagedObject";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CrtPlaybook> CrtPlaybookCollectionByObject {
			get;
			set;
		}

		/// <summary>
		/// SysSchema UId.
		/// </summary>
		public Guid UId {
			get {
				return GetTypedColumnValue<Guid>("UId");
			}
			set {
				SetColumnValue("UId", value);
			}
		}

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
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

		#endregion

	}

	#endregion

}

