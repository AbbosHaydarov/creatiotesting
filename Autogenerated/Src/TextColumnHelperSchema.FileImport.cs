namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TextColumnHelperSchema

	/// <exclude/>
	public class TextColumnHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TextColumnHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TextColumnHelperSchema(TextColumnHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1a85a55-168d-4a14-be59-272acc0d963d");
			Name = "TextColumnHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7e188b25-9774-4cd9-86fe-ed132c1bc48f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,146,81,107,194,48,16,199,159,43,248,29,110,14,196,129,180,123,118,218,23,199,152,48,65,80,124,143,237,169,129,54,45,201,101,232,134,223,125,151,164,110,118,246,37,112,151,255,239,238,127,151,40,81,162,169,69,134,176,65,173,133,169,246,20,207,43,181,151,7,171,5,201,74,197,111,178,192,69,89,87,154,250,189,239,126,47,178,70,170,67,75,173,241,165,223,227,155,71,141,7,38,96,94,8,99,38,44,57,209,188,42,108,169,222,177,168,81,123,77,146,36,48,53,182,44,133,62,167,77,204,253,72,72,101,128,152,128,204,35,6,44,201,66,210,25,74,164,99,149,155,248,10,39,55,116,109,119,133,204,192,16,91,205,32,115,125,59,218,70,108,155,207,95,127,203,80,113,2,43,143,135,203,255,198,124,98,165,177,22,26,91,206,224,83,20,22,99,88,31,121,37,200,70,125,12,114,15,146,32,175,88,172,42,130,61,7,116,196,134,113,230,239,221,135,12,55,16,37,40,126,135,217,32,23,36,182,174,220,230,92,227,32,125,229,176,41,79,156,136,167,137,23,119,179,94,55,72,231,183,38,239,0,141,100,181,50,105,51,88,222,49,216,52,185,138,28,213,222,176,33,237,30,191,161,255,54,189,117,228,200,197,206,178,143,220,4,208,154,103,124,197,125,159,39,112,159,41,138,120,111,163,135,150,46,94,152,165,56,173,229,23,194,112,216,152,250,64,117,160,35,164,237,138,177,19,93,11,69,97,81,179,134,88,219,93,104,55,122,30,119,81,252,101,153,185,248,51,12,220,128,27,45,203,81,184,230,91,255,111,80,229,225,235,248,56,100,219,201,203,15,246,17,59,246,72,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1a85a55-168d-4a14-be59-272acc0d963d"));
		}

		#endregion

	}

	#endregion

}

