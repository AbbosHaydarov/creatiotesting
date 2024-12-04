namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudDataResponseSchema

	/// <exclude/>
	public class CloudDataResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudDataResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudDataResponseSchema(CloudDataResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db4128e4-39dd-4160-97b6-b20928a12b20");
			Name = "CloudDataResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,193,106,131,64,16,61,27,200,63,12,246,98,46,122,111,53,80,210,82,10,77,9,73,111,165,135,205,58,49,11,186,43,187,107,75,90,242,239,157,93,77,49,177,9,185,168,251,118,230,189,55,111,148,172,66,83,51,142,240,134,90,51,163,54,54,158,41,185,17,69,163,153,21,74,142,71,63,227,81,208,24,33,11,88,237,140,197,138,238,203,18,185,187,52,241,19,74,212,130,223,157,214,44,27,105,69,133,241,138,110,89,41,190,61,23,85,81,221,141,198,130,14,48,43,153,49,183,244,82,77,254,192,44,91,146,17,162,68,95,148,36,9,164,166,169,42,166,119,211,238,252,40,73,105,11,92,73,203,184,5,44,177,66,105,13,1,7,63,241,161,51,233,181,190,59,114,154,201,106,234,250,32,160,110,214,165,224,192,157,254,127,242,1,77,76,207,63,163,11,173,106,212,86,32,185,93,248,222,246,254,212,99,7,32,2,215,184,201,194,214,175,83,38,225,103,74,37,132,100,10,130,62,12,148,194,88,231,118,104,183,245,59,199,106,141,58,122,165,245,64,6,97,78,80,56,113,230,15,238,95,136,32,29,40,76,193,53,131,91,89,16,20,104,221,94,130,192,116,31,251,110,46,148,121,59,218,241,156,196,99,172,110,184,85,250,100,210,78,115,144,85,52,233,164,188,106,6,18,191,206,25,139,38,215,88,152,163,221,170,252,154,156,239,243,220,64,90,51,205,42,10,27,36,5,149,133,46,219,144,50,182,170,191,7,103,206,161,23,50,247,136,39,235,51,77,47,46,211,237,146,2,99,146,99,156,38,190,217,115,117,97,125,42,145,59,151,209,160,211,255,2,253,228,98,87,230,193,115,25,117,216,113,108,251,95,225,139,124,69,189,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db4128e4-39dd-4160-97b6-b20928a12b20"));
		}

		#endregion

	}

	#endregion

}

