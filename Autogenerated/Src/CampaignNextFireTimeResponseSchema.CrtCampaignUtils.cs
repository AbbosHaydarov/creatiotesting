namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignNextFireTimeResponseSchema

	/// <exclude/>
	public class CampaignNextFireTimeResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignNextFireTimeResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignNextFireTimeResponseSchema(CampaignNextFireTimeResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33b2b06a-b8c5-4d45-827a-16cf4cc3cdd4");
			Name = "CampaignNextFireTimeResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,146,77,79,195,48,12,134,207,157,196,127,176,202,133,73,104,189,243,117,25,66,226,192,52,177,138,3,136,67,154,185,93,80,147,84,78,34,24,136,255,142,147,182,236,67,66,92,170,198,113,94,63,246,107,35,52,186,78,72,132,18,137,132,179,181,159,205,173,169,85,19,72,120,101,205,201,228,235,100,146,5,167,76,3,171,173,243,168,47,143,206,179,199,96,188,210,56,91,33,41,209,170,207,244,110,151,181,47,172,245,95,55,132,28,231,155,83,194,134,159,195,188,21,206,93,192,92,232,78,168,198,44,240,195,223,41,194,146,11,61,50,177,53,14,83,126,81,20,112,229,130,214,130,182,55,195,153,27,240,36,164,135,218,18,208,144,13,162,178,193,131,28,4,193,176,34,212,44,9,9,126,148,42,246,180,94,110,133,23,163,216,43,7,186,80,181,74,130,140,108,255,160,101,60,54,254,254,246,179,36,219,33,121,133,220,212,50,201,244,247,199,252,41,176,242,20,231,67,216,49,61,26,159,38,10,182,230,76,68,144,132,245,117,206,108,169,100,94,220,192,251,70,201,13,40,35,219,176,70,199,63,220,184,238,31,253,219,117,42,88,110,148,59,46,231,54,54,180,107,168,16,108,229,133,50,184,134,154,172,222,65,227,49,74,28,215,147,104,3,150,219,110,183,14,120,102,171,55,148,254,28,98,206,179,53,120,207,124,83,230,30,165,162,77,210,18,113,18,116,130,210,110,40,195,99,86,12,243,203,120,96,77,239,205,3,234,10,233,108,193,75,12,215,144,199,230,70,39,242,105,52,108,116,204,245,3,221,183,10,226,94,103,89,131,62,46,100,150,185,225,231,123,240,13,205,186,183,46,157,251,232,97,240,251,7,25,4,71,56,61,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33b2b06a-b8c5-4d45-827a-16cf4cc3cdd4"));
		}

		#endregion

	}

	#endregion

}

