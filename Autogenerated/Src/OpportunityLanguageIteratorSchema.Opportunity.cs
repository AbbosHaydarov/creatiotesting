namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityLanguageIteratorSchema

	/// <exclude/>
	public class OpportunityLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityLanguageIteratorSchema(OpportunityLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("561424eb-006b-4c14-a174-a6cb826ea99f");
			Name = "OpportunityLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,146,77,107,195,48,12,134,207,41,244,63,136,236,210,66,73,238,221,90,216,186,75,97,176,49,214,211,216,65,245,148,96,112,236,224,15,70,55,250,223,167,36,110,155,116,165,59,216,96,233,245,99,189,178,52,86,228,106,20,4,111,100,45,58,83,248,108,101,116,33,203,96,209,75,163,199,163,159,241,40,9,78,234,114,32,177,116,59,30,113,230,198,82,201,50,88,41,116,110,14,207,117,109,172,15,90,250,221,19,234,50,96,73,107,79,140,50,182,149,231,121,14,119,46,84,21,218,221,50,158,15,2,40,120,41,233,124,243,214,118,7,230,196,2,21,97,46,59,64,242,30,165,14,91,37,5,136,166,134,107,37,192,28,30,208,209,223,202,18,54,201,251,201,141,209,206,219,32,56,201,166,94,90,124,167,56,55,208,57,224,199,36,42,249,77,14,52,125,129,228,219,168,185,169,166,96,49,17,8,75,197,34,189,82,89,154,47,51,56,242,251,222,186,72,141,22,43,208,252,91,139,52,56,178,92,160,38,209,124,80,186,220,240,25,196,49,144,221,229,173,186,189,28,59,115,229,229,201,102,128,131,33,125,218,64,146,57,108,185,109,147,179,20,52,147,145,36,7,224,107,80,108,127,209,54,96,221,15,190,127,68,101,210,164,30,169,192,160,60,115,60,10,223,215,157,85,50,131,126,195,210,233,236,196,136,151,215,250,94,8,19,180,191,96,239,2,176,79,136,85,252,175,222,243,152,243,30,199,131,244,103,55,33,237,185,139,14,131,251,95,245,37,224,207,82,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("561424eb-006b-4c14-a174-a6cb826ea99f"));
		}

		#endregion

	}

	#endregion

}

