namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalizableStringHelperSchema

	/// <exclude/>
	public class LocalizableStringHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalizableStringHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalizableStringHelperSchema(LocalizableStringHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("372a558a-906c-4891-8361-c65204ffc892");
			Name = "LocalizableStringHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,201,78,195,48,16,61,167,82,255,193,164,151,34,80,114,135,210,11,66,128,196,38,214,179,9,211,54,194,177,163,25,187,168,32,254,157,137,179,80,183,41,248,96,121,182,231,247,102,108,45,11,160,82,102,32,30,1,81,146,153,217,228,212,232,89,62,119,40,109,110,244,112,240,53,28,68,142,114,61,15,82,138,194,232,227,222,8,2,251,57,50,66,152,51,128,56,85,146,232,72,92,153,76,170,252,83,190,42,120,176,200,69,23,160,74,64,159,154,166,169,152,144,43,10,137,171,105,99,143,194,85,219,188,55,1,209,30,194,4,94,73,11,152,174,33,150,238,85,229,153,32,203,162,50,145,85,148,118,51,138,88,50,239,157,130,107,176,11,243,198,26,238,60,74,29,220,228,28,144,222,62,172,91,21,195,109,138,181,167,148,40,11,161,121,44,39,177,35,64,30,134,134,172,154,68,60,237,83,91,173,73,234,171,250,65,40,91,64,33,111,248,236,1,234,194,195,181,250,94,138,127,66,170,205,198,109,160,255,135,133,96,29,106,234,244,236,168,106,211,170,186,112,126,228,111,21,231,96,159,165,114,48,126,10,26,37,194,190,29,182,233,191,157,232,92,189,74,246,69,245,228,163,104,41,81,32,144,83,86,156,52,5,201,89,81,218,85,245,238,163,40,159,137,241,94,227,190,164,27,167,212,45,250,240,184,31,181,133,141,218,187,105,201,184,241,214,43,164,36,22,7,253,204,216,31,39,94,114,92,115,240,28,21,49,142,134,143,237,7,61,14,59,145,188,24,124,247,191,61,185,7,50,14,51,206,51,40,231,85,67,214,154,195,204,246,27,252,78,191,162,228,209,52,168,77,240,219,239,245,148,154,70,249,0,251,253,239,1,253,86,127,32,111,215,222,208,249,253,3,218,41,142,224,127,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("372a558a-906c-4891-8361-c65204ffc892"));
		}

		#endregion

	}

	#endregion

}

