﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignHelperLegacySchema

	/// <exclude/>
	public class CampaignHelperLegacySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignHelperLegacySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignHelperLegacySchema(CampaignHelperLegacySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd4bdd61-4fcd-4584-8c95-224cf60157df");
			Name = "CampaignHelperLegacy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,28,93,115,219,200,237,217,55,115,255,129,163,123,161,166,42,211,220,61,180,19,59,238,196,31,73,116,117,108,215,86,154,135,76,38,67,145,43,155,23,138,212,113,73,219,186,187,252,247,98,23,251,205,37,69,217,78,147,118,250,98,75,92,44,22,192,2,88,44,0,170,136,151,132,174,226,132,4,51,82,85,49,45,23,117,116,88,22,139,236,170,169,226,58,43,139,239,191,251,253,251,239,118,26,154,21,87,193,229,154,214,100,185,235,124,7,248,60,39,9,3,166,209,43,82,144,42,75,52,204,97,185,92,150,133,249,189,34,246,183,232,48,94,174,226,236,202,1,138,142,14,244,131,55,113,245,137,212,240,41,122,91,103,121,86,103,132,234,65,147,114,152,119,92,212,14,0,123,44,23,185,76,174,201,50,14,158,219,75,71,246,48,76,133,201,63,84,228,10,152,10,14,243,152,210,103,129,4,121,77,242,21,169,78,200,85,156,172,57,220,170,153,231,89,18,36,12,172,3,106,7,132,8,127,53,74,144,85,253,44,56,175,178,155,184,38,56,182,194,47,65,194,198,2,90,87,92,196,164,72,143,151,113,150,79,151,75,146,102,48,158,175,127,46,231,175,170,178,89,157,194,222,1,35,35,99,104,86,101,87,87,164,34,56,103,180,187,1,115,231,204,243,170,76,8,165,114,133,33,176,27,23,243,176,193,240,159,199,117,77,170,162,151,145,143,191,255,229,115,47,126,91,234,124,195,4,237,5,252,43,23,161,13,48,30,130,11,85,225,180,172,95,150,13,80,127,151,144,21,211,113,70,232,6,144,65,164,246,34,238,68,249,3,8,18,117,200,163,80,85,147,212,101,5,170,122,206,53,18,33,222,159,205,105,153,147,154,132,163,191,70,79,127,140,126,12,254,48,161,131,140,6,69,89,7,89,17,52,148,4,113,145,6,183,89,158,7,115,18,84,100,89,222,144,148,15,173,146,114,201,168,175,72,78,98,74,104,52,26,127,224,44,162,238,251,180,62,124,75,97,43,202,162,64,223,192,208,27,95,39,193,84,78,58,46,174,178,2,164,100,125,29,51,236,59,207,130,250,58,163,161,61,117,28,48,151,180,243,89,8,249,190,20,8,52,59,31,237,199,176,13,246,131,93,99,177,46,241,191,204,72,158,210,14,131,118,168,112,214,219,176,177,111,72,125,93,118,162,166,53,56,233,4,204,139,57,224,224,21,169,15,154,252,19,55,153,183,5,109,230,52,169,178,57,193,209,77,219,241,170,201,210,96,46,167,79,83,41,158,155,184,10,26,3,89,51,23,171,129,109,145,91,177,180,187,67,124,230,14,59,25,154,101,17,226,191,232,60,174,192,24,193,216,195,167,99,9,241,178,42,151,225,72,81,125,137,203,160,202,75,152,119,215,224,8,194,17,160,175,227,164,158,166,163,113,52,165,199,191,54,113,30,142,96,82,49,154,4,230,160,152,245,162,72,29,196,151,32,172,134,26,32,18,75,139,190,55,48,3,180,157,155,9,141,20,18,177,136,33,218,116,236,95,110,182,94,17,36,180,8,17,96,103,147,176,180,184,70,114,182,26,112,164,100,140,8,217,88,66,105,177,99,238,234,120,28,196,84,16,194,53,123,199,183,185,209,229,138,36,217,98,125,90,158,148,201,167,215,89,81,211,112,140,224,21,169,27,112,215,190,89,166,165,116,106,232,241,93,70,217,73,126,1,11,172,50,2,152,135,232,167,169,141,164,3,195,99,106,228,27,112,132,21,248,65,181,6,200,247,5,133,231,23,174,90,194,19,208,63,181,55,23,126,253,180,199,77,157,193,249,124,236,69,10,46,0,78,82,207,124,123,220,221,194,46,137,108,222,198,174,153,131,182,178,125,94,43,54,167,41,224,202,22,25,60,90,95,214,100,53,77,197,182,32,235,67,124,17,229,211,204,141,167,28,5,67,103,172,179,197,174,143,128,203,178,74,141,29,192,205,86,199,57,96,118,183,183,223,178,4,141,214,134,106,219,239,154,37,215,107,249,23,131,14,196,50,22,187,165,185,223,134,93,131,81,37,129,22,243,45,175,226,229,220,43,122,139,237,67,208,131,171,178,90,247,179,174,2,121,193,187,29,231,25,146,144,200,108,217,106,23,62,124,9,125,6,240,201,47,64,84,55,196,69,124,18,55,69,114,125,198,15,158,97,39,132,151,15,59,198,181,145,182,61,175,176,65,58,220,226,164,134,156,128,213,30,172,79,192,73,1,9,202,182,134,88,85,46,231,180,13,107,27,213,58,100,78,137,239,3,243,138,146,44,143,194,29,94,122,33,79,8,39,3,93,67,135,57,202,41,106,248,231,50,43,66,246,135,25,7,28,173,112,213,100,71,191,101,189,56,229,82,205,57,83,52,152,68,106,7,171,24,113,130,13,115,198,16,173,115,108,250,162,41,220,217,182,194,33,77,91,251,10,33,55,159,167,104,99,215,238,174,27,191,214,135,225,234,185,57,86,53,238,31,79,158,60,9,246,104,179,92,198,213,122,95,62,56,98,107,195,133,130,80,8,240,227,154,221,144,88,100,5,119,128,130,221,60,240,222,1,207,74,184,112,252,218,100,224,31,248,113,16,148,11,128,215,87,133,72,45,240,196,93,97,111,197,88,228,215,191,231,35,91,151,71,251,83,144,101,92,64,210,67,224,219,163,4,144,86,100,241,124,228,36,19,108,147,26,61,217,143,246,158,112,204,254,133,36,97,32,243,253,183,69,246,107,67,130,76,157,132,114,53,149,116,232,69,133,71,203,0,52,76,7,54,80,165,130,227,30,108,8,211,70,132,90,64,247,47,8,109,242,90,130,47,73,117,5,226,131,171,22,207,18,193,52,9,103,220,201,132,251,154,151,101,14,212,22,111,216,28,25,168,195,222,74,6,6,249,45,45,89,43,60,152,160,214,35,136,100,211,116,109,156,80,22,36,44,226,156,242,204,19,62,79,227,58,254,87,156,55,132,153,15,68,123,49,120,239,214,213,47,58,242,64,105,28,140,49,18,23,12,136,141,195,116,31,86,200,137,213,82,225,14,214,44,45,1,135,46,206,28,153,199,251,74,250,95,184,149,147,148,103,85,210,6,124,145,35,14,100,120,84,211,213,71,83,3,94,131,29,231,164,250,216,35,103,185,26,93,69,239,178,250,90,251,0,211,53,78,12,73,119,194,11,183,61,145,49,90,39,94,165,120,19,99,119,44,232,179,166,94,53,181,49,7,245,12,38,56,210,21,211,48,163,23,242,45,156,31,223,145,164,97,73,140,214,198,29,195,245,164,34,71,7,250,81,56,150,106,193,150,198,153,36,212,56,4,254,157,108,17,132,0,160,40,162,239,127,250,16,241,61,101,169,18,70,148,194,179,163,148,43,228,207,253,211,4,94,240,157,234,175,240,172,56,221,244,172,94,103,249,6,188,33,85,46,242,255,94,241,43,123,69,219,185,221,148,224,121,190,156,103,235,118,108,67,253,69,208,233,42,254,59,252,196,151,54,248,207,155,204,239,176,34,16,139,211,32,211,183,221,224,151,114,142,129,11,65,180,44,140,33,131,82,234,193,10,255,127,115,161,203,74,121,174,209,254,37,81,7,189,32,55,208,195,155,140,1,229,213,145,241,223,96,17,184,93,211,163,140,127,5,161,236,97,214,124,18,148,243,95,0,102,223,160,195,52,6,216,15,145,239,71,248,232,101,89,45,227,58,220,92,119,64,155,139,78,201,45,251,15,58,131,90,81,87,107,169,60,34,25,200,114,253,105,3,118,163,42,80,17,114,234,48,232,154,159,32,77,176,182,179,169,160,51,25,92,152,153,152,178,216,181,104,213,36,158,148,87,112,81,90,148,66,30,163,247,118,158,92,176,208,65,212,135,103,193,40,248,147,32,124,4,15,2,168,195,4,11,48,63,169,21,191,63,253,60,210,44,14,38,93,154,30,248,144,58,185,14,66,93,3,33,242,147,178,93,47,75,199,85,85,86,143,192,19,199,19,220,94,103,57,92,182,113,131,153,183,97,230,205,74,78,19,77,143,226,82,138,186,190,174,202,219,129,46,228,2,99,99,216,176,140,31,45,250,160,161,210,206,84,150,2,10,35,41,187,137,177,135,255,32,107,94,145,185,208,143,120,72,241,205,57,143,7,94,86,228,221,97,218,35,151,222,43,6,8,138,11,230,28,4,188,199,12,121,2,85,43,240,22,219,38,41,31,148,158,52,184,198,147,185,131,170,144,123,156,227,229,170,94,79,130,63,63,245,165,248,238,153,92,117,9,181,142,221,199,56,72,13,28,96,100,41,231,20,137,150,7,236,5,127,108,30,179,58,92,230,119,38,205,4,230,34,166,69,74,238,0,13,226,99,151,165,179,10,50,18,44,55,195,50,23,187,190,185,23,3,38,95,152,179,89,80,47,96,24,129,6,71,45,170,44,108,252,76,240,147,172,112,183,72,179,48,64,96,245,211,143,97,7,229,26,199,96,221,49,136,129,43,146,129,86,225,250,220,121,223,208,139,236,14,245,88,137,234,237,112,45,89,100,110,160,210,14,95,32,94,184,133,144,78,103,107,120,31,8,40,111,250,142,204,153,159,158,72,196,36,6,135,159,65,219,136,202,229,232,21,120,232,151,1,102,144,161,179,26,115,127,210,27,182,71,153,17,48,136,172,166,223,168,131,84,105,182,30,31,233,202,172,219,79,30,118,239,74,175,155,52,226,42,84,41,246,119,191,39,177,60,40,92,27,144,87,222,152,186,118,61,151,70,167,189,99,133,25,40,180,15,63,43,225,55,229,235,244,13,105,163,183,50,147,211,187,30,20,86,190,124,48,54,39,203,46,17,99,188,211,235,16,53,233,109,127,232,101,203,118,135,94,178,187,49,117,113,167,145,226,222,191,215,75,127,0,108,222,233,155,221,32,226,26,236,2,193,88,225,50,192,162,222,184,73,161,68,138,222,65,174,141,94,144,94,151,77,158,234,212,53,36,174,153,111,14,8,143,92,254,135,179,212,198,113,212,131,203,12,226,190,72,20,105,187,185,118,189,236,133,216,185,89,169,171,129,195,107,102,70,134,198,240,120,214,73,220,17,18,58,97,129,90,252,159,76,167,196,117,197,236,218,1,48,251,132,119,170,112,218,25,54,69,118,55,203,160,121,179,6,226,0,181,113,43,45,139,27,82,213,144,55,37,12,96,86,42,176,80,62,131,46,202,228,180,188,181,208,121,59,124,250,59,138,92,97,153,125,38,187,67,218,53,250,218,65,58,57,103,45,17,92,126,219,212,43,123,251,48,92,32,145,142,234,3,177,251,49,108,160,86,141,205,218,171,49,150,40,213,119,187,248,185,177,75,168,115,17,43,22,196,53,124,204,118,150,112,221,6,42,7,240,194,133,236,198,41,186,9,56,176,79,78,15,20,148,91,38,158,197,144,198,148,253,57,135,51,13,198,11,196,188,102,44,105,214,21,101,172,11,207,156,214,177,206,178,176,174,11,207,58,75,201,45,110,140,4,169,66,131,213,89,142,228,148,220,241,134,138,97,29,38,186,56,139,60,112,69,180,139,214,227,8,218,70,225,47,55,41,26,118,217,157,89,40,118,166,248,188,64,171,44,172,236,111,115,119,145,2,221,120,216,190,93,65,233,12,210,168,184,153,47,146,235,140,220,176,187,65,83,212,158,35,105,224,129,250,136,231,220,151,58,155,61,249,83,20,133,173,221,66,32,97,171,96,48,184,105,142,139,114,91,183,249,18,250,87,224,51,204,148,74,203,148,213,223,173,209,97,134,208,177,176,168,161,200,167,44,209,211,173,193,218,53,208,32,141,110,17,109,138,104,114,77,85,193,214,57,13,35,155,145,159,42,228,167,221,200,77,83,180,76,234,129,246,142,54,38,62,159,173,72,113,144,131,165,40,62,237,62,207,193,61,32,175,202,216,219,42,38,215,169,20,175,91,183,151,108,64,125,152,151,148,32,15,45,183,160,21,172,199,47,40,77,20,221,4,16,195,235,105,226,86,117,153,196,121,92,237,241,108,135,25,161,112,179,48,53,24,13,165,93,239,210,117,44,65,54,148,51,160,207,178,76,153,221,167,103,236,252,110,201,193,141,140,188,83,15,88,115,155,103,178,115,171,20,170,202,76,51,50,132,199,81,89,230,236,195,101,72,103,188,85,43,162,169,125,108,111,80,58,226,58,172,101,167,10,97,227,199,245,201,131,11,90,214,237,81,100,49,70,125,25,13,51,91,254,141,58,105,106,123,233,233,113,209,64,109,63,158,231,132,39,39,246,237,76,128,96,84,220,37,6,121,112,184,125,242,196,89,232,220,205,179,194,139,90,93,230,251,206,18,243,24,241,6,219,27,203,26,211,2,132,25,211,78,157,80,23,230,175,112,96,115,146,152,10,0,137,75,64,129,52,126,29,253,177,94,193,249,91,244,83,240,135,104,149,99,29,37,41,89,85,4,234,96,36,181,95,169,17,218,6,110,144,201,89,50,45,130,185,26,15,229,86,56,144,73,70,183,136,12,208,57,220,203,167,162,66,205,202,58,206,193,151,113,255,130,126,233,248,14,152,130,204,48,120,67,8,254,249,173,198,59,106,163,24,203,34,169,223,43,142,31,207,33,202,151,24,248,163,45,92,34,48,163,59,113,64,216,165,206,3,61,186,174,15,213,243,254,46,150,206,190,62,11,137,21,92,249,17,49,24,6,164,57,102,87,147,126,188,133,142,171,252,72,25,192,54,8,151,250,16,223,199,83,25,44,135,169,55,223,199,123,27,55,27,99,219,42,79,240,123,24,47,247,161,160,18,192,67,12,61,16,118,69,186,171,211,38,234,49,121,32,169,22,83,102,165,155,199,106,91,190,221,40,36,191,155,251,106,228,174,254,206,5,47,30,7,50,246,9,180,116,183,112,31,25,167,84,184,15,36,187,227,82,193,56,111,223,23,76,127,98,245,23,13,137,175,113,150,209,61,228,241,28,178,157,104,139,104,80,11,194,89,201,178,19,223,106,38,128,51,215,226,91,181,148,123,144,56,49,185,111,226,57,212,71,10,146,186,107,76,41,187,147,241,94,18,31,98,222,2,43,59,92,88,73,84,107,65,244,58,166,188,114,166,66,7,181,175,248,1,23,48,46,74,30,252,6,58,196,101,6,18,170,8,137,232,134,251,92,88,88,191,86,29,44,248,155,150,67,157,108,246,48,231,138,139,141,246,241,245,78,158,213,135,62,17,82,127,25,79,211,246,2,192,186,36,20,73,64,187,103,229,174,158,22,41,164,122,18,108,17,95,62,48,14,248,58,119,43,101,247,219,197,5,153,39,30,176,226,107,46,63,22,90,163,32,117,65,16,163,5,70,54,31,137,160,32,237,179,50,62,230,49,0,49,159,245,62,226,165,152,9,250,162,188,149,183,100,213,124,118,223,232,4,210,233,216,36,164,78,84,94,148,167,252,58,14,50,22,12,193,63,184,40,32,135,224,46,130,163,131,251,86,168,102,176,86,159,70,247,6,61,51,147,80,109,157,155,194,29,38,109,58,43,95,18,232,28,19,72,240,25,135,224,70,186,96,99,221,213,243,190,10,185,242,51,70,241,232,126,53,34,190,56,21,253,136,239,63,4,54,229,82,169,248,143,85,172,197,143,82,80,249,219,20,173,50,181,6,234,121,169,192,237,223,197,105,90,198,80,190,230,40,68,131,28,14,251,235,44,230,13,214,92,29,149,125,95,137,92,163,196,7,188,152,197,201,161,161,195,176,62,117,212,219,59,124,128,157,88,71,7,161,192,115,94,101,76,253,16,157,217,99,204,26,131,57,62,97,236,194,38,133,169,232,40,92,31,21,158,179,167,104,242,252,11,90,17,11,127,234,130,253,152,202,146,71,136,247,185,10,60,186,85,108,182,7,243,124,50,174,184,74,157,248,109,214,99,50,55,89,85,131,135,245,219,204,67,140,66,236,150,137,206,249,209,4,175,102,88,154,182,117,68,17,40,49,108,183,121,255,137,16,195,17,248,67,67,3,71,206,109,84,12,139,140,34,28,201,143,7,247,77,64,154,56,206,179,223,248,171,123,252,151,79,230,107,249,137,177,30,5,67,173,67,254,154,11,100,9,249,79,236,176,199,188,31,67,172,192,188,148,192,220,223,131,149,252,118,201,161,16,25,126,230,99,157,166,113,226,89,193,123,120,112,84,160,176,39,114,13,126,254,135,98,64,177,192,90,50,249,19,139,22,185,31,114,76,47,170,97,90,173,237,163,19,23,140,70,208,179,140,129,7,68,82,246,10,58,143,222,194,46,34,190,22,58,209,11,235,236,127,244,174,172,62,241,95,140,130,198,33,90,54,85,2,224,101,5,103,210,196,100,51,247,241,32,223,255,192,101,111,248,59,85,207,219,160,230,107,83,236,188,16,128,64,38,184,111,21,141,117,79,103,126,3,210,231,208,217,133,155,128,125,117,240,83,14,22,185,209,17,89,8,48,80,118,126,51,242,156,24,124,149,158,119,95,241,169,253,240,243,191,1,64,53,12,0,85,75,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd4bdd61-4fcd-4584-8c95-224cf60157df"));
		}

		#endregion

	}

	#endregion

}

