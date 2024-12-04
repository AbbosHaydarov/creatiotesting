namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignFireTimeConfigSchema

	/// <exclude/>
	public class CampaignFireTimeConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignFireTimeConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignFireTimeConfigSchema(CampaignFireTimeConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9223c62-28e8-4dfe-acbc-1c6c34636529");
			Name = "CampaignFireTimeConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,219,106,195,48,12,125,78,161,255,32,218,247,228,125,151,194,232,218,177,61,21,218,31,112,28,37,245,72,236,96,57,180,161,236,223,39,59,23,178,150,149,237,197,88,199,242,209,145,116,180,168,144,106,33,17,14,104,173,32,147,187,120,109,116,174,138,198,10,167,140,158,207,46,243,89,212,144,210,5,236,91,114,88,61,142,241,244,139,197,120,45,170,90,168,66,199,27,221,84,196,105,156,184,180,88,48,11,172,75,65,244,0,67,202,86,89,60,168,10,187,82,33,51,73,18,120,162,166,170,132,109,87,125,28,126,129,59,10,7,210,104,39,148,38,168,133,101,205,14,45,65,110,44,144,60,98,214,148,8,26,207,156,213,243,195,167,73,227,129,52,153,176,214,77,90,42,9,50,16,255,166,38,226,150,249,28,197,239,172,169,209,58,133,220,193,46,16,116,239,215,146,3,240,97,82,32,39,172,3,199,148,49,188,107,142,52,15,216,228,156,140,8,210,98,254,188,120,21,46,212,92,36,43,47,244,86,233,32,117,72,132,112,248,101,68,81,129,206,111,33,138,168,191,124,221,17,180,119,188,73,44,218,48,174,137,130,223,182,183,45,205,233,13,53,242,47,99,71,216,163,123,158,117,37,198,183,169,244,17,132,162,187,33,1,139,35,223,53,155,166,38,200,176,70,157,49,160,121,161,138,247,216,13,181,189,223,253,80,190,43,189,57,163,108,188,43,199,158,110,145,203,255,39,244,34,61,67,231,179,12,145,164,85,41,235,63,249,152,141,4,116,52,77,153,65,102,24,82,238,8,98,244,217,223,197,123,143,102,125,161,235,248,190,228,37,143,173,51,98,136,59,244,39,200,216,55,135,238,108,200,201,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9223c62-28e8-4dfe-acbc-1c6c34636529"));
		}

		#endregion

	}

	#endregion

}

