namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringLczHelperSchema

	/// <exclude/>
	public class StringLczHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringLczHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringLczHelperSchema(StringLczHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f3f34d7-0318-4d6e-85df-0dbdd9ff8f22");
			Name = "StringLczHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,77,111,219,48,12,61,187,64,255,3,225,237,144,0,134,125,95,211,20,88,54,116,135,118,24,150,117,59,43,10,157,104,149,37,67,31,9,150,162,255,125,148,100,119,115,236,246,34,72,36,245,248,30,159,164,88,131,182,101,28,225,7,26,195,172,174,93,185,210,170,22,59,111,152,19,90,93,94,60,93,94,100,222,10,181,27,148,52,141,86,87,147,25,131,20,167,204,59,131,59,2,128,149,100,214,126,128,181,51,84,121,199,79,95,80,182,104,98,73,85,85,176,176,190,105,152,249,179,236,206,41,13,181,54,112,212,230,17,142,194,237,65,106,206,164,56,33,216,136,98,203,254,114,245,223,237,214,111,164,224,84,66,196,57,240,208,118,220,53,35,57,180,190,176,187,71,183,215,91,226,247,45,222,78,201,115,94,49,112,139,238,156,71,160,49,230,145,34,45,51,172,1,69,243,189,206,37,63,125,165,77,190,188,75,247,217,70,98,98,102,33,214,161,35,201,112,96,210,227,162,138,145,105,32,111,209,144,61,10,121,240,38,95,62,208,25,248,75,0,232,120,16,252,109,12,131,86,123,195,241,158,41,182,67,147,136,133,21,116,13,125,50,128,58,38,20,232,205,111,194,30,1,26,116,222,40,187,92,84,253,46,164,134,14,164,25,133,185,209,252,147,220,159,65,225,204,237,133,237,179,221,104,10,120,24,72,131,161,210,162,47,159,32,15,215,81,152,174,103,31,189,124,252,220,48,33,215,173,20,142,122,137,45,115,218,204,231,16,222,112,150,29,152,233,29,252,231,64,7,241,62,31,123,83,62,117,236,158,203,72,60,191,122,29,38,176,192,35,140,64,102,67,33,229,47,122,211,241,195,149,223,59,41,107,162,72,90,138,136,157,77,8,44,166,73,207,19,155,110,48,241,237,16,137,81,105,162,14,55,55,19,41,178,102,229,37,249,135,201,152,91,84,104,152,60,99,86,126,194,186,43,43,160,102,210,246,173,147,245,169,117,140,60,119,127,11,213,54,125,175,120,78,209,97,144,98,127,1,121,252,76,205,123,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f3f34d7-0318-4d6e-85df-0dbdd9ff8f22"));
		}

		#endregion

	}

	#endregion

}

