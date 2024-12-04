namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CtiRightsServiceSchema

	/// <exclude/>
	public class CtiRightsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CtiRightsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CtiRightsServiceSchema(CtiRightsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6c64027-2137-42ca-b41d-24afcb039a7e");
			Name = "CtiRightsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c124cf91-dc7b-4db8-b77e-ff0b639610dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,93,107,227,48,16,124,86,32,255,65,237,67,73,192,248,7,220,23,164,129,107,115,52,151,35,110,233,67,232,131,98,175,19,17,89,242,105,215,1,115,244,191,223,202,118,156,52,87,210,123,145,144,102,118,118,70,90,171,10,192,82,165,32,31,193,123,133,46,167,120,234,108,174,55,149,87,164,157,29,14,254,12,7,162,66,109,55,50,169,145,160,96,220,24,72,3,136,241,29,88,240,58,253,124,206,73,192,239,117,10,115,151,129,185,8,198,207,176,190,76,152,112,171,125,227,229,31,30,215,50,23,145,177,132,20,193,145,112,76,19,56,83,87,20,77,57,227,171,78,156,83,146,87,41,189,132,187,9,150,63,129,152,86,114,163,181,54,154,234,37,252,174,180,135,2,44,225,232,244,16,92,201,175,242,131,146,192,138,187,139,108,28,154,148,213,218,232,84,166,70,33,202,41,233,165,222,108,9,59,55,159,228,173,66,232,14,145,156,45,65,101,11,107,234,211,116,172,193,127,193,171,88,45,74,104,191,231,52,133,88,113,214,153,221,187,29,140,230,64,91,151,177,205,235,95,139,228,241,58,146,183,46,171,19,170,77,176,206,180,57,235,170,13,244,183,241,179,87,101,9,89,20,116,68,240,13,72,223,157,47,20,189,41,104,175,226,31,232,108,36,151,60,58,60,4,112,153,215,132,63,164,95,59,103,228,29,208,19,130,191,87,216,231,120,224,216,172,52,122,208,72,95,144,60,255,225,55,233,14,40,70,109,161,198,137,173,251,154,177,12,163,41,196,94,121,233,59,43,108,130,124,213,12,130,16,185,243,160,210,173,28,5,70,47,38,181,61,81,62,136,136,166,65,186,133,116,199,94,102,54,119,44,21,92,242,11,219,118,218,99,6,238,193,112,41,143,61,189,231,190,151,29,183,6,132,206,229,232,234,141,232,205,141,188,122,63,134,16,39,33,114,101,176,75,193,214,56,198,174,59,188,202,163,242,185,240,127,232,30,31,231,76,182,217,218,213,3,85,222,246,79,218,48,24,225,173,89,95,135,131,191,215,182,249,86,54,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6c64027-2137-42ca-b41d-24afcb039a7e"));
		}

		#endregion

	}

	#endregion

}

