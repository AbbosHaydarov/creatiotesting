namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportLogItemSchema

	/// <exclude/>
	public class IImportLogItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportLogItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportLogItemSchema(IImportLogItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a68587a1-ef86-40c0-811b-ca07c771c3c7");
			Name = "IImportLogItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,221,10,194,48,12,133,175,59,216,59,4,118,191,221,79,241,70,20,6,10,130,190,64,157,89,41,218,31,210,12,20,241,221,237,86,39,130,160,119,233,201,151,115,146,90,105,48,120,217,34,28,144,72,6,215,113,185,116,182,211,170,39,201,218,217,114,173,47,216,24,239,136,243,236,158,103,121,38,10,66,21,59,208,88,70,234,226,108,13,77,34,54,78,53,140,102,164,124,127,188,232,22,244,4,125,49,34,185,189,237,118,228,60,18,107,12,53,236,198,225,212,175,170,10,230,161,55,70,210,109,49,9,209,5,226,230,65,42,44,223,80,245,73,5,38,109,21,108,19,4,49,76,8,161,144,103,99,17,94,197,227,71,198,234,218,162,31,254,0,2,203,246,12,76,241,140,223,105,251,1,60,12,220,159,192,2,237,41,221,61,190,147,250,41,70,229,9,174,230,212,133,156,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a68587a1-ef86-40c0-811b-ca07c771c3c7"));
		}

		#endregion

	}

	#endregion

}

