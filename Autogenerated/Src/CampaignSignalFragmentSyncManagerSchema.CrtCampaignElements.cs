﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignSignalFragmentSyncManagerSchema

	/// <exclude/>
	public class CampaignSignalFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignSignalFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignSignalFragmentSyncManagerSchema(CampaignSignalFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f640b49a-c5da-4d1a-b93b-a51f180dd679");
			Name = "CampaignSignalFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,90,91,111,227,184,21,126,246,0,243,31,8,23,88,200,64,160,244,242,182,153,4,200,197,153,186,152,73,166,177,167,243,80,20,5,45,209,142,58,178,168,33,169,56,233,34,255,189,135,23,73,36,69,201,118,146,109,251,176,11,108,48,22,201,195,143,231,126,14,89,224,13,225,37,78,8,90,16,198,48,167,43,17,95,210,98,149,173,43,134,69,70,139,247,239,126,121,255,110,84,241,172,88,163,249,19,23,100,115,226,253,134,249,121,78,18,57,153,199,31,73,65,88,150,116,230,124,202,138,31,237,71,123,175,205,134,22,225,17,70,250,190,199,87,23,237,144,252,112,137,55,37,206,214,5,64,231,130,163,83,245,49,174,191,198,206,48,46,4,135,213,176,254,119,140,172,1,53,186,204,49,231,63,163,122,214,28,254,199,249,53,195,235,13,41,196,252,169,72,62,227,2,175,9,83,139,142,143,143,209,7,94,109,54,152,61,157,153,223,87,132,39,44,91,18,142,56,204,190,103,180,200,254,77,24,18,247,88,160,140,163,45,101,223,73,138,182,153,184,71,137,217,4,149,152,137,44,201,74,9,199,144,89,81,134,182,247,89,114,143,102,69,38,50,156,215,136,102,192,194,89,42,73,53,203,185,2,137,72,78,36,72,52,75,227,26,219,177,5,174,172,150,121,150,32,78,112,14,0,18,121,206,221,199,68,45,43,46,48,39,65,70,140,64,43,224,111,203,66,201,89,86,37,130,50,224,228,23,181,173,158,97,32,236,220,53,250,88,101,0,177,62,113,122,132,220,15,138,5,19,73,113,244,51,90,2,174,200,158,235,77,67,82,105,71,207,6,35,41,82,13,211,197,252,133,209,146,128,16,136,135,216,151,176,250,112,157,227,53,18,20,101,69,154,37,88,16,4,138,4,127,233,10,49,146,84,140,73,77,108,68,42,109,1,177,42,39,104,249,100,36,37,197,211,149,79,205,157,37,165,57,154,241,187,134,212,47,104,77,196,9,8,14,254,236,56,198,103,34,238,105,42,207,192,178,7,192,100,216,174,127,0,94,129,62,211,7,242,197,82,183,232,43,39,12,36,86,104,171,69,149,243,211,48,111,244,128,25,250,81,17,246,4,230,244,145,8,159,200,95,229,80,228,45,149,86,57,26,49,34,42,86,232,197,241,244,17,14,37,72,164,199,158,93,116,15,20,68,124,5,74,44,200,188,181,156,20,40,10,156,28,2,52,85,52,52,210,46,189,1,172,122,225,48,202,57,204,73,132,36,125,67,182,22,15,22,20,4,150,149,25,40,242,29,201,149,212,249,130,74,70,233,21,145,141,144,107,34,167,168,32,91,67,49,178,249,185,160,18,177,30,48,216,244,18,233,95,171,13,248,214,203,156,96,22,57,99,234,159,35,51,35,26,39,37,17,180,28,31,161,49,24,85,202,178,60,111,0,126,157,165,227,73,103,186,156,42,7,226,115,30,141,107,19,181,80,5,23,213,123,92,84,249,247,233,6,103,185,53,235,188,72,163,0,157,219,114,129,151,57,185,129,104,3,11,231,130,148,224,248,75,201,121,185,249,140,79,127,84,56,143,244,22,50,254,112,17,129,55,33,147,154,236,12,164,198,254,66,179,34,68,92,97,88,96,6,22,99,237,163,207,100,208,26,58,163,248,182,216,13,111,102,99,178,206,59,204,159,65,136,29,84,14,34,35,8,163,245,206,246,59,193,90,139,106,138,82,6,134,228,28,156,84,197,173,193,145,207,108,32,12,132,4,248,223,110,28,141,3,187,55,255,20,224,166,106,242,147,208,222,77,240,10,136,216,218,213,114,226,99,233,241,199,1,161,119,180,217,227,231,146,8,151,161,242,131,101,5,125,18,29,180,146,118,251,70,209,59,219,250,187,54,246,212,108,102,144,132,108,165,171,49,50,122,249,170,146,121,170,146,117,247,240,248,173,66,160,175,14,106,25,156,147,178,212,7,88,19,116,156,206,188,4,158,172,158,110,232,39,154,124,255,51,68,17,30,185,222,93,207,27,118,151,224,190,211,223,92,230,30,46,115,18,223,80,8,23,16,134,50,176,187,104,143,16,17,187,161,177,145,182,113,211,142,43,253,67,107,159,215,140,110,118,248,80,219,187,72,228,173,38,125,187,39,140,104,251,233,183,158,253,237,236,55,231,126,176,115,31,244,237,224,80,58,254,85,233,210,223,255,97,242,16,248,239,21,94,254,232,48,26,179,2,18,236,53,35,156,215,4,204,250,231,70,242,111,18,45,222,202,109,205,10,176,40,229,182,156,67,172,168,30,24,206,69,13,111,102,211,162,218,16,38,69,248,65,21,52,186,138,209,127,39,103,144,141,175,232,39,48,241,80,142,45,141,222,108,229,101,170,32,88,65,67,86,43,209,181,241,66,159,19,138,72,130,161,132,140,36,109,185,31,252,233,236,59,210,185,249,223,112,94,17,224,80,173,64,115,34,162,49,148,234,80,173,78,11,145,137,39,144,198,17,234,72,65,82,139,101,152,177,28,139,90,26,206,144,134,40,252,209,163,160,183,189,93,254,11,142,190,99,233,159,106,209,63,119,138,142,222,82,67,250,79,143,127,78,146,238,50,30,132,178,167,251,61,105,40,224,60,167,91,146,106,149,135,134,128,146,107,107,128,175,55,191,253,40,76,25,163,204,177,187,231,22,163,100,225,60,80,142,120,106,231,38,254,29,65,52,194,239,13,42,174,122,154,204,183,201,103,218,112,146,13,100,215,126,150,19,72,116,213,114,79,113,156,117,52,56,163,229,135,213,138,153,31,82,165,121,149,81,215,91,55,35,193,212,172,29,6,139,133,74,232,182,176,65,241,67,5,212,28,212,51,224,55,170,250,194,76,180,53,160,195,198,90,228,116,191,34,233,182,12,42,12,108,236,21,75,52,148,2,107,124,255,139,26,173,70,212,45,197,220,8,215,74,185,187,180,29,11,45,109,67,125,56,198,123,78,167,241,169,225,8,107,148,176,11,34,92,64,188,109,81,167,141,222,203,119,91,135,52,65,152,27,109,223,51,174,215,14,237,28,26,196,50,140,154,5,166,161,211,198,227,232,17,157,158,213,110,88,46,202,29,51,129,149,143,208,189,22,250,44,42,48,126,144,200,207,58,1,209,236,235,123,142,65,18,61,106,105,81,34,142,97,13,144,10,187,177,58,252,69,238,169,142,92,132,71,222,54,117,0,157,196,11,205,191,154,169,217,10,41,161,168,143,32,103,144,214,116,83,10,24,111,50,136,222,60,201,75,140,90,225,76,188,46,155,14,220,251,117,4,253,160,189,163,49,120,170,154,171,35,233,58,53,173,30,215,217,23,185,124,87,228,70,172,222,80,85,236,140,21,54,7,194,53,179,71,161,226,37,244,125,141,255,31,78,65,117,195,156,215,61,25,187,247,104,190,153,116,4,201,84,208,232,19,76,107,134,145,201,17,154,233,241,121,154,206,86,82,248,218,78,95,211,34,178,34,27,101,224,235,206,1,180,219,81,62,56,37,1,159,244,79,78,43,150,52,45,12,119,92,210,249,6,13,123,186,85,13,224,235,170,80,84,34,227,216,228,240,29,221,222,84,155,37,97,238,140,201,145,53,71,13,105,146,211,199,82,22,52,114,138,187,185,229,251,15,94,218,250,254,166,194,186,101,41,97,87,25,92,45,72,56,177,188,95,2,45,0,118,78,116,112,210,176,221,240,59,20,210,84,41,95,239,217,201,191,108,48,7,250,247,78,231,207,162,181,43,106,53,106,86,39,242,198,135,237,45,254,121,181,244,4,175,24,49,172,95,154,129,114,169,199,7,67,173,102,45,156,254,163,146,12,11,166,190,94,156,10,22,27,218,118,247,191,121,241,44,184,254,105,92,64,192,174,113,231,140,158,199,208,23,34,67,46,197,71,208,184,143,147,215,121,208,23,250,207,157,39,10,57,82,131,243,107,153,2,239,59,39,26,76,245,12,53,85,123,54,250,26,168,58,125,33,120,39,122,37,252,253,180,231,170,42,225,174,16,38,240,139,39,227,111,246,187,32,11,41,98,135,75,255,165,194,212,96,169,147,213,70,209,222,14,99,183,239,244,18,128,157,208,213,219,228,62,207,115,87,224,214,5,224,222,247,151,77,181,7,4,229,165,123,47,197,224,37,102,115,81,8,184,85,192,112,174,10,189,68,21,114,27,149,8,244,182,54,134,83,103,227,164,251,210,211,54,37,125,14,53,222,218,160,99,21,113,161,224,224,3,238,243,184,123,220,138,83,1,107,72,58,112,185,127,167,32,242,90,10,112,169,47,95,6,168,11,93,120,99,193,234,187,93,253,160,227,30,63,16,249,18,96,73,208,6,228,2,207,50,160,59,7,67,164,37,79,8,74,24,89,157,142,47,55,37,40,23,19,73,233,180,216,199,199,103,72,72,206,246,188,10,80,95,52,223,248,153,209,52,221,177,251,112,92,127,214,202,104,206,134,0,8,60,28,72,109,189,188,109,143,176,243,154,218,228,203,47,184,225,62,249,127,100,171,126,106,243,13,115,121,1,133,86,240,116,227,215,100,180,220,228,101,204,126,201,253,216,16,195,33,93,231,42,125,10,190,50,146,220,13,13,24,158,193,29,141,76,40,32,225,131,130,139,183,226,105,88,183,184,39,240,170,133,72,233,240,86,146,61,123,65,211,89,48,92,112,25,17,193,33,13,176,31,150,225,13,42,192,240,79,199,174,119,27,159,205,212,123,45,120,157,6,186,99,201,223,117,171,32,118,16,151,34,211,21,234,37,173,224,132,176,220,122,153,149,58,80,119,139,90,190,161,129,22,60,97,32,93,171,40,221,223,187,227,20,2,158,237,111,53,170,83,244,123,237,34,245,67,54,213,177,79,151,218,253,194,83,176,83,143,98,60,45,120,197,200,213,69,251,201,170,199,219,133,49,4,46,38,22,45,247,235,64,48,18,112,209,80,223,4,245,98,234,188,22,10,134,28,221,35,240,0,130,74,207,248,53,36,205,0,115,90,72,173,130,154,192,125,249,213,60,113,130,22,5,32,148,229,8,250,233,39,251,237,83,115,162,80,82,16,202,129,122,240,233,107,1,32,18,234,249,215,147,118,119,26,122,168,67,88,73,32,197,104,140,180,111,222,192,227,166,158,21,150,32,229,235,200,44,40,201,103,48,59,33,111,121,166,143,9,41,109,125,115,8,220,193,211,204,37,78,190,135,72,140,4,32,218,214,244,218,134,76,29,176,195,10,98,199,94,101,104,89,1,17,61,19,41,77,142,119,187,202,215,37,74,191,186,198,49,162,78,190,35,169,11,202,205,97,157,124,158,40,161,29,68,34,156,208,232,175,238,199,231,247,239,254,3,116,31,50,183,184,43,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f640b49a-c5da-4d1a-b93b-a51f180dd679"));
		}

		#endregion

	}

	#endregion

}

