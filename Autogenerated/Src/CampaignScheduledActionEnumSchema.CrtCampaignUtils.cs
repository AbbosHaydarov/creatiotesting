namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignScheduledActionEnumSchema

	/// <exclude/>
	public class CampaignScheduledActionEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignScheduledActionEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignScheduledActionEnumSchema(CampaignScheduledActionEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee85b26e-3465-4222-8e7e-6c8dbf431c31");
			Name = "CampaignScheduledActionEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,203,106,195,64,12,69,215,54,248,31,4,221,150,184,105,187,42,117,161,36,253,129,166,208,181,50,150,157,129,204,131,121,44,66,232,191,87,30,199,36,197,78,48,93,74,220,57,247,74,98,52,42,242,22,5,193,23,57,135,222,52,97,177,50,186,145,109,116,24,164,209,69,126,44,242,34,207,238,28,181,92,194,135,142,234,5,86,168,44,202,86,111,196,142,234,184,167,250,93,244,98,86,150,101,9,175,62,42,133,238,240,118,170,215,132,94,56,185,37,15,152,148,30,26,227,64,156,48,80,75,14,17,24,230,22,3,161,188,64,216,184,221,75,1,196,222,215,173,51,14,154,141,220,83,227,51,234,179,87,31,160,243,25,27,101,157,178,130,135,251,52,201,52,108,19,208,133,153,184,94,91,193,242,54,208,216,217,60,150,86,240,120,19,55,44,6,252,100,82,248,222,209,197,58,146,136,197,124,219,32,21,65,77,141,212,228,7,154,212,103,96,154,102,141,129,186,238,112,7,32,29,100,56,92,11,252,231,45,71,127,154,27,125,98,39,163,228,198,218,185,201,141,253,119,240,180,242,103,110,254,244,63,129,116,221,127,134,174,228,222,47,24,145,138,250,68,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee85b26e-3465-4222-8e7e-6c8dbf431c31"));
		}

		#endregion

	}

	#endregion

}

