namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignConfigurationServiceResponseSchema

	/// <exclude/>
	public class CampaignConfigurationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignConfigurationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignConfigurationServiceResponseSchema(CampaignConfigurationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd1fe187-de0b-4898-b834-f29572b7524b");
			Name = "CampaignConfigurationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,83,61,79,195,48,16,157,83,169,255,225,212,46,205,146,236,20,88,90,6,134,86,85,139,196,128,24,174,238,37,24,37,118,100,59,148,130,248,239,156,243,65,211,2,85,133,88,44,251,201,239,238,189,243,179,194,156,108,129,130,224,142,140,65,171,19,23,77,180,74,100,90,26,116,82,171,126,239,189,223,11,74,43,85,10,171,157,117,148,143,191,206,123,202,188,148,209,138,204,139,20,52,211,27,202,162,41,58,228,58,206,160,112,227,163,2,209,178,84,78,230,228,25,18,51,249,86,53,226,91,124,111,104,40,229,3,76,50,180,246,2,38,152,23,40,83,117,32,169,105,180,100,225,90,89,170,120,113,28,195,165,45,243,28,205,238,186,57,183,253,33,209,6,68,83,9,108,205,6,211,208,163,150,29,119,232,15,93,253,143,12,20,229,58,147,2,132,151,117,150,42,96,241,39,69,7,60,87,94,247,142,25,118,166,20,78,27,54,190,168,250,213,55,142,189,85,192,148,18,44,51,7,98,79,3,167,65,24,66,71,32,25,68,197,46,117,114,150,90,63,132,239,83,104,93,159,83,97,20,130,15,74,16,220,163,81,252,214,183,42,209,112,5,138,182,208,65,70,161,15,67,240,113,194,216,228,111,14,96,43,221,19,112,32,121,14,210,247,94,163,165,13,240,96,233,85,80,225,25,255,96,242,166,173,5,20,242,11,251,30,35,250,131,243,33,169,77,253,238,135,33,88,24,93,144,113,146,206,137,64,83,29,244,250,153,132,251,197,93,149,228,25,229,107,50,163,57,127,118,86,54,216,238,101,13,66,159,238,118,6,93,7,221,125,237,47,165,234,43,7,129,109,54,63,155,169,209,67,144,177,79,180,197,214,26,106,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd1fe187-de0b-4898-b834-f29572b7524b"));
		}

		#endregion

	}

	#endregion

}

