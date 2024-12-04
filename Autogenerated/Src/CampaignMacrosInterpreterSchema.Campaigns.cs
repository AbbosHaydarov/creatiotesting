﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignMacrosInterpreterSchema

	/// <exclude/>
	public class CampaignMacrosInterpreterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignMacrosInterpreterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignMacrosInterpreterSchema(CampaignMacrosInterpreterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cad16678-c498-4136-8792-f9a8e171d00c");
			Name = "CampaignMacrosInterpreter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,26,107,111,219,182,246,179,7,236,63,176,238,48,216,64,166,108,23,3,46,176,36,46,90,39,237,140,219,54,69,226,172,192,45,138,65,145,105,135,171,36,186,164,148,198,75,243,223,119,200,67,74,164,222,46,214,11,92,236,139,97,81,228,121,63,121,148,134,9,149,219,48,162,100,73,133,8,37,95,103,193,156,167,107,182,201,69,152,49,158,126,251,205,253,183,223,140,114,201,210,13,185,220,201,140,38,71,149,103,216,31,199,52,82,155,101,240,130,166,84,176,168,182,231,69,204,175,195,152,253,169,97,214,222,190,100,233,199,218,226,146,222,101,229,162,75,94,146,184,48,90,8,15,174,50,22,203,230,109,130,182,173,7,103,105,198,50,70,91,15,6,207,195,40,227,2,119,192,158,199,130,110,0,27,153,199,161,148,191,144,121,152,108,67,182,73,95,133,145,224,114,145,102,84,108,5,133,95,189,249,240,240,144,28,203,60,73,66,177,155,153,231,83,42,35,193,174,169,36,145,2,65,50,78,152,61,70,18,13,134,132,233,138,68,60,206,147,148,220,134,113,14,123,215,92,144,200,224,34,243,139,171,83,194,175,255,0,37,16,26,211,132,166,153,12,44,186,67,7,223,187,243,107,201,99,32,103,50,254,119,240,211,207,193,79,228,51,185,146,173,186,15,44,55,50,168,241,3,68,130,150,194,213,120,250,30,0,111,243,235,152,69,134,131,14,25,140,192,152,224,183,148,26,216,76,22,2,185,191,144,55,130,221,134,25,197,247,91,124,0,166,225,61,145,153,80,138,64,120,111,194,12,64,165,228,132,140,223,61,190,255,241,225,241,251,49,106,98,244,152,166,43,132,219,128,68,228,74,109,10,143,38,21,119,84,245,161,23,156,237,90,204,199,146,2,33,130,174,79,198,173,156,141,15,103,74,224,117,137,227,202,54,20,97,66,82,240,181,147,113,46,169,0,20,41,122,204,120,54,207,133,0,133,17,181,174,248,53,47,130,227,67,125,170,25,72,198,18,250,95,158,210,243,245,90,210,12,128,88,83,80,47,200,159,240,198,59,111,212,211,74,254,228,202,35,74,211,82,62,30,144,165,65,183,72,215,156,248,184,167,68,197,135,209,168,2,225,164,2,67,185,211,104,244,187,53,217,165,7,3,118,251,64,245,238,135,110,173,190,17,124,75,133,114,85,101,59,60,3,60,116,213,169,86,27,165,8,95,19,224,123,69,215,44,165,43,215,199,214,121,26,161,3,222,242,15,180,75,163,32,182,92,164,114,230,67,205,118,91,234,218,203,41,211,175,224,228,253,211,152,133,242,128,60,7,12,75,190,208,240,31,30,148,217,28,31,90,88,104,248,134,19,114,203,68,150,135,49,41,97,28,163,31,32,144,99,244,247,217,12,152,183,172,160,94,21,120,27,63,78,102,68,11,62,165,159,250,1,161,34,71,247,202,177,16,84,112,10,78,168,116,21,188,230,159,192,209,14,200,11,154,217,181,171,44,130,85,2,106,130,67,15,71,123,104,171,207,3,23,58,40,64,78,2,145,58,210,244,77,172,221,229,140,181,87,44,178,242,120,79,54,96,103,138,250,118,139,169,57,85,147,142,93,223,232,160,201,4,52,207,147,90,220,225,200,97,194,219,63,111,241,158,89,167,115,61,121,66,38,237,142,231,34,128,148,25,77,143,246,87,12,26,203,175,52,6,21,255,246,175,126,33,248,251,201,239,137,243,236,50,111,93,160,178,223,125,52,70,187,65,91,247,32,33,227,222,202,137,178,95,247,248,100,170,248,5,0,178,9,192,9,102,91,55,26,125,77,177,88,245,234,18,100,119,25,221,208,36,68,24,111,185,248,0,244,24,234,240,169,73,80,189,16,188,135,38,209,153,87,142,232,204,138,22,157,159,64,240,77,139,8,139,99,53,17,182,133,136,87,52,187,225,171,182,74,160,98,3,53,61,26,110,170,10,212,101,25,150,108,59,40,78,179,99,31,206,108,98,136,247,206,5,181,100,230,47,224,17,12,219,13,214,107,248,28,172,214,86,193,26,158,12,34,21,195,123,97,153,24,222,195,192,65,177,235,233,42,97,233,5,219,220,100,82,101,97,145,211,34,156,215,24,105,72,32,182,146,88,243,89,169,146,50,39,78,16,207,226,44,205,19,42,194,235,152,30,91,14,230,34,95,157,235,204,51,215,133,237,111,202,76,102,166,202,213,15,210,242,127,27,10,147,164,157,108,123,162,229,209,77,146,85,174,11,52,120,206,197,89,24,221,76,76,61,13,22,107,100,198,214,196,44,6,122,43,121,4,56,242,56,182,100,140,70,79,87,43,36,22,113,188,100,50,51,39,14,106,4,26,212,74,134,234,215,60,26,85,86,55,55,73,251,150,179,21,105,194,216,41,65,35,64,163,224,30,141,213,104,118,4,46,121,46,34,90,162,5,129,187,174,19,156,221,101,2,220,170,170,241,231,130,39,170,113,243,36,249,36,88,242,75,141,191,12,22,21,240,79,10,189,220,57,42,81,132,64,215,24,42,219,68,6,212,182,36,204,38,94,47,112,64,238,2,93,95,89,161,43,85,62,170,114,167,122,155,44,132,182,229,63,116,55,209,80,167,165,106,13,0,192,163,223,28,21,203,139,149,138,34,86,228,170,53,144,65,159,23,46,86,246,124,141,6,80,40,226,6,154,27,77,164,197,10,170,69,30,26,243,196,245,172,46,205,26,123,128,180,212,228,50,166,2,36,130,202,60,46,42,122,37,252,109,35,90,76,6,45,36,181,56,2,194,86,252,95,132,233,134,46,214,175,121,118,118,7,154,151,147,102,36,141,226,232,32,190,157,162,161,66,114,25,71,114,219,163,140,193,106,35,76,21,20,138,59,120,123,67,5,69,139,238,168,210,61,195,180,150,60,53,32,172,91,152,46,165,244,13,77,166,78,174,64,101,7,244,119,120,18,193,190,15,176,245,176,116,187,122,153,184,27,15,16,116,97,162,126,252,194,67,93,246,90,119,141,175,104,177,208,150,228,128,22,154,231,12,66,210,98,229,42,146,182,16,130,54,220,74,102,141,28,7,122,175,65,183,225,252,2,147,254,187,228,184,143,128,188,44,219,111,217,143,246,54,109,207,150,220,192,105,128,23,149,132,225,181,139,68,87,49,230,248,146,151,50,53,21,200,40,81,148,38,1,144,97,4,50,210,169,223,36,40,252,109,84,143,185,86,3,146,48,243,64,107,238,164,219,137,171,31,92,55,2,197,7,131,108,72,202,214,255,15,186,204,1,85,225,215,70,42,211,185,8,85,199,30,234,45,75,232,83,131,133,180,221,122,145,234,140,216,21,67,76,200,162,155,119,153,242,8,242,176,162,230,30,134,161,126,201,249,135,124,107,196,253,249,51,233,220,252,10,156,137,13,63,65,152,212,78,239,45,182,241,168,54,254,221,252,41,2,158,113,184,76,13,211,65,52,152,189,251,147,81,129,131,117,212,30,96,218,237,185,77,253,195,173,181,181,202,236,50,89,55,111,57,192,208,7,143,10,209,187,71,131,167,233,14,74,199,178,44,196,211,222,22,205,206,185,56,165,235,16,76,105,50,117,225,121,146,92,138,221,51,126,103,25,71,150,157,100,215,45,175,170,41,253,35,100,165,152,222,83,78,13,230,254,143,16,149,225,187,79,90,102,162,209,238,212,255,7,194,130,30,81,99,122,150,179,120,165,47,91,84,173,124,233,174,161,4,26,218,191,145,11,217,196,251,198,188,61,210,37,198,157,155,184,71,59,181,4,162,67,152,40,175,157,73,225,166,6,168,212,205,110,217,60,242,168,14,46,232,54,134,241,39,238,211,104,80,96,110,73,224,20,192,86,219,62,144,146,191,230,200,237,82,58,196,40,220,253,198,177,240,152,147,245,141,250,240,142,130,64,178,52,13,242,66,190,134,133,115,241,246,134,101,244,82,141,118,27,180,80,205,82,230,236,89,178,205,118,213,28,136,136,32,221,217,144,73,86,110,236,172,130,250,110,124,239,189,47,209,142,55,48,64,152,131,23,229,2,175,155,161,23,9,5,131,241,159,89,156,62,144,201,213,114,62,29,55,72,81,83,81,21,116,115,12,106,10,240,221,82,116,153,83,247,251,24,237,200,247,223,187,79,112,29,84,140,67,94,177,180,145,249,114,123,85,138,197,81,160,238,77,40,100,131,86,192,101,115,69,162,168,8,216,152,32,80,227,173,15,34,200,187,222,135,98,252,22,134,48,106,109,201,225,174,127,226,193,3,221,52,14,9,154,108,90,217,92,175,6,202,180,209,43,125,221,158,248,146,127,164,214,208,34,131,179,143,112,187,45,39,229,134,233,112,193,107,48,67,132,190,177,228,78,91,208,151,27,170,216,139,55,95,42,42,47,109,244,74,235,26,118,59,28,15,151,133,58,56,72,22,106,99,51,171,197,155,1,172,14,184,233,239,159,219,150,221,37,6,102,61,164,213,205,105,125,80,123,129,147,84,2,65,68,187,6,78,238,96,107,100,134,236,9,87,31,71,12,25,236,22,241,0,252,132,164,252,83,223,152,182,172,127,252,249,40,220,226,67,242,41,252,20,23,187,102,108,150,135,88,93,186,170,73,117,8,21,2,185,215,125,175,185,154,209,255,181,18,30,244,23,10,114,75,35,182,102,229,44,59,42,59,120,252,116,68,119,200,4,12,186,131,115,247,251,130,106,215,63,174,12,186,205,120,184,243,27,133,162,47,31,207,174,82,246,81,153,238,74,245,83,64,40,126,88,97,149,82,124,199,2,167,51,22,177,45,100,4,75,115,29,133,85,3,146,96,191,135,137,246,156,195,163,244,58,7,240,221,23,51,95,231,50,198,45,139,6,95,62,182,95,15,215,111,177,212,125,90,67,171,217,117,99,215,15,164,233,114,204,153,115,224,166,253,2,67,223,39,2,58,130,73,107,239,107,152,58,84,62,144,82,118,111,244,90,49,14,115,6,247,13,117,8,119,132,84,117,6,31,177,251,253,214,96,7,153,15,112,5,146,87,189,232,127,239,28,56,110,254,66,207,216,99,244,55,208,81,188,155,202,166,249,163,55,78,244,76,179,74,104,109,82,211,98,218,93,223,1,152,94,2,140,15,42,242,240,54,100,177,226,219,179,15,107,125,159,88,118,163,130,160,186,81,84,69,191,23,15,241,186,201,66,93,128,202,212,109,171,202,252,41,55,73,240,7,215,184,21,116,3,75,101,36,93,41,239,21,232,173,93,119,154,171,123,23,54,158,97,184,32,82,199,11,75,114,143,185,23,186,208,30,228,200,132,175,40,20,52,28,198,77,28,196,215,144,87,172,17,22,119,176,158,80,155,173,212,100,228,226,46,218,109,175,123,198,10,94,112,67,83,236,187,232,37,131,59,118,215,140,113,185,50,151,168,247,198,238,117,123,84,109,215,237,156,186,108,19,106,91,156,26,175,184,145,135,235,120,232,118,139,57,147,215,124,59,77,55,209,221,182,109,175,171,46,212,120,39,238,203,197,33,198,62,180,206,68,42,121,1,87,253,69,88,251,11,127,238,163,211,180,44,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cad16678-c498-4136-8792-f9a8e171d00c"));
		}

		#endregion

	}

	#endregion

}

