namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LinkedInPullLeadsRestRequestSchema

	/// <exclude/>
	public class LinkedInPullLeadsRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LinkedInPullLeadsRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LinkedInPullLeadsRestRequestSchema(LinkedInPullLeadsRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6413fce5-0d56-4454-a110-907134c1fae3");
			Name = "LinkedInPullLeadsRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,83,221,106,194,48,20,190,174,224,59,28,216,197,238,236,253,20,189,80,39,1,97,162,190,64,154,156,102,97,105,210,229,103,67,196,119,95,154,234,172,99,168,131,245,162,165,167,223,223,57,57,213,180,66,87,83,134,176,69,107,169,51,165,31,76,141,46,165,8,150,122,105,244,96,99,152,164,106,137,148,47,80,247,123,251,126,47,11,78,106,1,155,157,243,88,13,251,61,136,87,183,20,5,148,66,214,176,221,32,146,208,74,22,97,45,240,193,162,136,31,96,170,168,115,79,176,148,250,13,57,209,171,160,146,135,91,163,243,107,124,15,241,113,162,228,121,14,35,23,170,138,218,221,248,92,154,42,19,56,216,22,11,179,237,11,124,74,255,10,82,151,198,86,41,59,208,194,4,15,117,212,6,213,136,3,75,173,117,100,243,75,221,58,20,74,50,96,77,184,27,217,178,102,18,217,169,157,149,53,53,90,47,49,246,180,74,34,77,250,44,251,145,189,45,108,60,181,30,56,245,248,13,233,228,200,178,99,10,231,109,26,106,131,158,69,48,236,65,160,31,130,107,110,135,127,211,159,107,254,39,117,162,153,10,28,227,160,105,60,227,15,4,75,181,64,119,213,170,48,70,157,136,228,200,91,39,218,221,182,75,25,79,217,148,32,133,54,22,193,165,181,76,199,10,146,63,94,183,39,115,29,42,180,180,80,56,106,187,30,3,73,58,231,237,38,113,61,238,31,129,71,209,254,31,209,252,170,245,34,72,62,233,18,8,191,219,230,57,46,242,45,125,101,180,152,36,228,111,194,105,69,81,243,118,75,211,123,107,120,89,60,124,1,250,168,252,239,7,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6413fce5-0d56-4454-a110-907134c1fae3"));
		}

		#endregion

	}

	#endregion

}

