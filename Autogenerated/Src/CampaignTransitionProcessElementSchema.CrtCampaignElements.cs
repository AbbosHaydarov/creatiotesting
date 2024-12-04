﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignTransitionProcessElementSchema

	/// <exclude/>
	public class CampaignTransitionProcessElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignTransitionProcessElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignTransitionProcessElementSchema(CampaignTransitionProcessElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("895b9ca3-4911-4c86-a68d-8acbe9d91a96");
			Name = "CampaignTransitionProcessElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3114fdd2-1796-4282-98ef-60854140c213");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,87,75,143,219,54,16,62,59,64,254,195,212,61,84,6,22,242,125,31,6,54,155,109,106,160,73,211,245,26,57,211,210,200,38,34,145,10,31,235,184,65,254,123,135,164,40,75,94,217,206,6,173,15,134,69,205,243,227,204,55,99,193,42,212,53,203,16,30,81,41,166,101,97,210,59,41,10,190,182,138,25,46,197,235,87,223,94,191,26,89,205,197,26,22,59,109,176,186,106,159,187,42,10,211,59,86,213,140,175,197,81,129,183,111,232,21,189,252,85,225,154,76,195,93,201,180,190,132,168,247,168,152,208,220,57,253,168,100,134,90,223,151,88,161,48,94,103,58,157,194,181,182,85,197,212,110,214,60,191,97,26,1,191,98,102,13,91,149,8,166,53,0,117,176,0,24,76,164,209,194,180,99,162,182,171,146,103,144,185,40,206,6,1,151,222,93,20,251,189,148,219,54,188,17,65,68,223,109,94,164,89,163,50,28,41,57,250,109,48,51,152,7,145,195,52,252,193,222,39,216,58,103,6,225,139,69,181,115,65,63,143,122,84,71,139,240,183,147,234,104,135,231,111,176,70,115,5,218,125,125,111,2,67,145,135,216,78,4,234,209,56,17,229,82,112,10,11,120,78,57,243,130,163,2,89,128,217,32,104,105,21,21,80,7,234,161,168,3,216,239,44,207,97,225,21,230,84,75,243,124,40,220,151,185,55,76,145,133,23,184,127,244,10,47,116,79,77,145,135,43,50,27,102,128,211,83,70,55,165,97,203,179,77,184,47,200,246,50,18,88,93,151,59,40,164,130,133,193,250,78,86,117,137,238,210,234,128,249,238,116,160,61,157,189,239,35,199,47,184,242,247,104,54,50,255,193,194,188,165,28,168,56,14,50,232,165,105,126,178,118,159,184,50,150,149,240,36,233,70,156,159,221,112,110,201,4,28,1,141,70,122,203,13,33,157,12,139,69,169,81,230,56,97,88,38,93,82,255,198,211,191,68,185,187,12,42,163,131,14,74,111,69,158,140,123,54,198,147,116,174,239,191,80,192,201,157,44,109,37,210,143,76,17,117,26,84,137,81,22,39,19,71,122,238,179,82,200,62,95,253,80,44,115,145,253,247,209,20,172,212,63,17,206,173,104,253,119,85,114,44,152,45,205,255,12,20,149,172,255,58,90,135,15,104,172,18,26,86,46,131,208,107,174,177,174,53,34,100,10,139,155,241,2,233,88,100,216,225,229,241,116,54,92,132,254,164,118,97,129,160,208,110,198,129,192,30,176,88,206,243,241,236,56,207,53,62,126,211,135,148,119,61,245,230,134,173,7,126,122,137,245,3,70,123,102,93,5,56,102,129,239,169,47,54,1,153,82,174,137,58,200,222,89,96,200,102,52,50,220,150,203,208,203,239,208,116,13,184,9,24,222,36,158,73,187,192,93,4,114,237,102,27,155,242,137,41,80,168,169,144,224,6,4,110,27,235,9,245,128,162,18,20,228,154,74,234,162,157,193,84,50,134,103,188,102,194,60,186,193,62,9,37,147,46,208,36,227,40,20,248,123,76,90,207,234,172,27,66,79,215,149,234,123,153,59,220,169,229,134,116,223,82,92,143,188,194,116,105,178,15,114,251,92,189,67,32,67,250,194,150,229,5,140,163,153,241,9,3,67,234,77,247,54,58,159,54,168,208,105,49,99,245,252,100,111,69,84,8,78,109,8,55,157,14,128,217,254,52,180,156,69,171,209,219,40,116,243,1,188,241,229,232,184,235,110,17,76,38,192,116,115,189,161,183,121,1,201,47,11,218,163,232,134,231,121,234,109,232,164,225,21,95,69,147,73,75,222,161,72,124,32,199,106,129,192,109,173,157,2,164,21,138,140,227,73,38,122,248,68,61,243,7,39,152,18,87,142,15,114,251,167,204,62,187,131,36,138,135,246,104,202,214,31,157,220,14,136,204,220,50,16,184,201,111,8,52,37,13,227,145,180,66,107,58,210,218,15,204,35,51,178,215,226,157,78,14,168,82,243,6,251,149,124,34,135,245,30,30,13,133,146,149,231,146,204,42,229,118,86,90,215,107,63,164,233,76,224,87,3,82,224,217,214,247,19,57,36,228,9,166,157,192,135,139,230,205,9,122,232,174,120,23,189,141,171,193,247,228,200,63,143,119,4,55,179,218,80,210,123,120,59,128,221,218,156,99,22,146,112,176,113,65,230,89,201,255,241,127,108,206,110,40,132,175,82,196,211,205,154,77,185,122,131,148,107,31,150,30,84,189,226,57,0,236,108,86,247,254,175,12,221,106,188,191,130,64,141,99,192,103,167,233,193,7,199,154,80,78,213,80,119,8,69,249,0,70,51,57,10,178,200,233,82,96,187,113,75,108,148,129,13,123,162,181,90,194,10,227,255,40,204,143,79,161,15,182,90,133,49,166,109,230,132,11,226,192,221,94,179,87,163,71,171,175,69,155,154,16,22,196,79,37,54,112,36,33,216,94,6,19,184,153,245,79,210,40,237,174,96,96,1,14,184,247,15,233,236,95,43,74,207,78,0,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("895b9ca3-4911-4c86-a68d-8acbe9d91a96"));
		}

		#endregion

	}

	#endregion

}

