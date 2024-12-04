﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchServiceSchema

	/// <exclude/>
	public class GlobalSearchServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchServiceSchema(GlobalSearchServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69");
			Name = "GlobalSearchService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,90,91,115,219,54,22,126,86,103,250,31,80,181,211,82,19,133,110,95,157,200,94,199,151,70,157,248,178,150,187,121,200,236,120,104,17,146,184,161,72,149,23,199,90,215,255,125,191,131,11,9,130,32,45,111,187,179,59,155,135,88,4,14,14,206,13,231,6,36,193,154,231,155,96,206,217,13,207,178,32,79,23,133,127,156,38,139,104,89,102,65,17,165,137,255,115,156,222,5,241,140,7,217,124,245,245,87,143,95,127,53,40,243,40,89,178,217,54,47,248,250,141,245,141,197,113,204,231,180,50,247,127,230,9,207,162,121,11,230,67,148,252,214,26,156,241,236,62,154,243,243,52,228,113,239,164,127,4,244,247,130,184,126,184,143,252,174,5,112,179,202,120,16,98,160,123,198,191,9,242,207,121,107,30,216,128,62,207,177,237,172,8,10,94,3,28,167,25,247,207,130,121,145,102,17,55,22,46,133,228,246,247,143,211,245,26,130,252,144,46,151,141,141,47,248,151,2,98,34,145,255,146,155,204,152,170,160,165,238,153,46,37,157,20,233,203,22,188,231,241,134,103,238,53,224,236,154,255,86,242,188,48,24,35,81,116,83,102,162,118,205,95,148,81,83,79,39,65,17,128,186,34,131,8,93,11,206,211,36,34,217,154,178,115,111,247,12,232,229,81,89,172,166,73,193,151,82,10,46,152,154,55,77,228,117,90,22,29,8,9,248,125,81,108,252,163,187,92,144,79,102,95,3,158,102,89,154,77,147,69,202,38,182,80,77,1,104,222,253,10,30,40,128,228,219,140,47,129,144,29,199,65,158,239,51,147,81,181,92,128,237,237,237,177,183,121,185,94,7,217,246,64,125,75,88,150,11,96,252,17,208,108,147,165,15,91,95,47,217,51,214,124,82,8,53,41,127,167,177,19,190,8,202,184,48,196,192,197,248,44,223,180,198,142,242,205,5,47,32,184,13,36,123,23,197,81,177,37,187,137,50,190,230,73,145,123,230,7,49,13,137,60,179,132,160,124,53,16,142,104,147,77,121,23,71,115,54,39,113,184,164,193,246,217,187,32,231,234,107,204,166,215,56,208,151,73,188,53,143,45,240,192,135,225,255,90,188,208,89,17,96,199,125,118,149,145,99,145,98,29,108,228,7,155,211,60,131,126,133,51,80,122,139,242,185,58,79,60,20,106,59,150,76,13,93,0,67,169,207,193,183,60,9,229,166,77,10,206,34,30,135,93,219,147,87,74,193,4,155,158,115,208,48,191,230,155,52,43,120,198,110,215,205,239,137,52,20,233,136,182,112,190,197,91,107,201,129,55,122,99,162,110,59,1,118,187,116,58,134,106,9,36,85,64,7,53,81,240,106,236,54,198,127,19,134,159,231,65,18,44,121,70,155,147,187,227,153,55,52,55,25,142,158,145,196,85,150,98,199,2,110,180,67,26,14,146,27,31,20,159,6,131,37,47,212,175,65,180,96,158,131,41,54,153,176,164,140,227,145,134,27,56,129,218,34,109,19,112,224,37,252,139,180,162,172,36,192,163,108,89,146,9,123,195,18,39,15,19,137,12,136,195,177,218,106,240,107,99,124,36,181,50,24,60,201,63,25,47,202,44,233,84,133,4,195,127,77,189,40,243,52,206,195,175,89,220,150,135,66,238,201,5,35,225,140,154,161,1,241,110,198,11,114,121,20,193,139,191,5,113,201,189,38,197,99,214,80,43,54,18,154,237,160,45,74,10,166,130,200,77,180,230,240,25,108,66,78,103,48,240,48,245,239,147,64,113,67,177,250,215,146,103,91,133,188,50,50,115,255,155,180,8,226,43,216,230,21,207,44,90,108,17,49,252,83,82,250,83,164,211,189,245,112,204,94,255,244,140,224,28,171,63,68,235,232,191,66,182,216,24,68,255,244,99,15,209,83,10,136,106,193,113,28,225,28,176,219,21,134,228,239,55,207,128,210,136,250,233,60,202,223,180,150,232,195,121,147,109,193,216,5,242,217,112,42,28,250,156,55,157,143,50,149,122,7,112,66,250,55,168,27,25,238,160,30,133,27,232,220,21,91,234,221,206,178,116,125,50,245,58,14,179,37,2,183,232,166,33,230,17,7,21,169,31,179,96,35,156,114,228,28,127,179,219,234,142,97,117,4,59,112,179,195,67,248,205,142,185,73,7,78,233,164,76,153,120,163,151,121,252,180,128,45,242,80,130,216,137,141,35,179,153,75,235,77,51,182,146,30,59,82,27,99,33,71,232,206,248,98,210,48,2,101,238,169,162,117,184,119,64,249,80,59,33,114,6,28,107,113,211,67,91,147,202,208,21,67,236,62,202,138,18,116,247,161,235,155,211,218,234,217,81,170,172,15,96,34,77,178,55,166,89,107,94,16,220,152,29,213,180,234,119,208,227,138,7,113,1,117,174,248,252,115,135,22,167,22,149,181,115,123,47,22,31,203,181,207,107,116,71,68,45,237,118,192,117,40,122,215,93,118,4,235,208,127,23,184,203,20,58,81,119,88,197,142,28,32,169,236,85,244,49,41,50,142,197,66,86,164,159,121,226,84,175,9,118,67,80,125,138,180,133,221,90,236,24,113,134,19,17,12,80,243,240,7,212,101,101,150,145,183,255,70,102,134,236,251,239,153,99,26,37,73,190,193,113,224,26,174,14,25,202,213,247,45,242,101,8,56,17,213,1,29,20,30,10,234,156,49,163,197,131,127,145,38,188,29,62,186,92,43,146,255,85,218,170,43,156,74,58,139,98,212,7,57,219,192,6,32,215,98,187,225,57,187,219,178,96,62,71,237,196,178,104,185,42,114,150,46,216,92,9,137,14,127,135,122,196,200,38,200,130,53,75,16,141,39,67,194,54,60,160,162,58,120,157,115,154,33,221,201,0,194,114,156,249,117,32,32,115,255,237,158,88,87,163,145,146,200,119,89,204,22,130,7,76,130,110,147,204,38,19,216,67,35,117,228,207,82,14,55,32,248,221,246,72,44,187,22,171,84,186,44,4,163,21,126,31,100,112,95,178,230,71,72,164,41,169,62,127,182,65,49,235,253,48,254,97,164,6,62,174,64,152,149,110,249,39,239,102,28,116,130,143,211,4,141,33,46,226,102,126,42,227,170,96,140,234,87,236,122,20,199,233,23,212,192,82,243,202,56,36,65,254,47,105,148,120,195,49,188,175,38,69,130,89,153,133,153,191,136,147,12,155,32,97,114,53,216,197,31,125,207,228,212,68,111,57,205,47,96,246,151,217,233,122,83,108,61,185,226,80,79,138,65,20,226,223,13,247,30,59,133,41,214,60,81,85,140,109,212,206,37,138,149,9,150,61,218,37,204,211,99,77,196,211,222,173,12,24,135,242,207,45,77,77,194,69,126,11,46,178,237,109,177,226,201,237,130,23,168,52,27,200,113,218,54,84,157,155,30,77,52,131,102,52,33,50,98,241,235,12,117,188,180,28,210,149,165,48,37,127,18,75,38,165,6,140,20,29,219,194,213,30,129,42,48,9,243,107,22,121,96,113,164,75,64,121,54,155,153,165,28,243,175,46,103,55,26,204,46,155,172,58,74,131,181,189,29,42,87,123,76,185,24,255,99,84,72,230,27,113,255,140,7,176,43,200,2,76,139,217,3,207,157,228,193,210,72,84,74,26,228,68,143,209,13,192,46,190,66,113,131,194,63,38,91,168,80,10,195,134,207,11,238,98,30,62,183,107,157,131,247,164,37,254,17,72,73,66,236,44,104,12,226,220,83,58,49,43,19,125,86,212,148,235,96,80,195,168,242,232,160,83,244,114,244,128,167,10,20,53,157,169,31,99,163,177,199,141,22,159,25,13,148,225,113,221,26,170,165,165,177,224,28,145,22,195,203,178,168,56,230,102,39,73,207,42,83,126,98,60,6,17,13,20,167,15,115,190,17,129,53,202,25,181,173,165,210,209,146,210,19,110,212,71,119,212,15,10,155,152,93,128,130,81,13,86,153,127,36,249,173,121,71,186,65,70,94,139,69,225,58,199,153,71,5,9,216,54,201,135,100,22,112,109,10,38,247,224,69,14,107,56,248,62,244,196,175,86,104,154,242,198,132,8,173,137,54,125,179,247,86,81,46,201,149,84,191,219,172,165,5,85,106,148,174,163,250,148,231,179,13,166,88,152,149,50,122,76,216,2,86,198,205,109,149,218,73,26,230,142,74,245,154,96,106,237,3,138,254,128,244,123,212,58,212,252,133,201,70,255,228,151,119,255,128,81,87,250,84,182,75,237,52,217,11,246,190,251,203,80,19,68,221,203,18,193,252,145,246,147,211,196,171,74,25,64,168,152,167,33,192,84,210,170,71,43,64,177,84,73,93,163,83,159,21,140,18,178,137,73,13,61,85,77,44,77,152,1,68,76,62,13,173,64,213,16,171,235,12,222,167,81,136,206,85,161,97,46,144,57,81,49,237,181,149,114,103,143,224,44,206,44,24,158,91,32,130,26,61,38,60,129,104,23,85,148,213,67,102,232,67,58,92,92,112,248,151,240,125,84,76,201,85,183,54,23,55,23,254,7,0,122,35,127,26,190,105,172,157,38,33,127,32,54,78,233,139,154,176,180,8,73,175,202,183,109,50,253,234,19,61,119,31,123,230,254,77,250,33,34,220,74,226,254,89,148,132,2,173,247,128,130,160,10,185,191,33,5,206,189,7,80,48,182,169,30,51,25,56,69,151,61,139,160,30,127,154,128,194,8,253,238,99,236,3,223,59,93,38,104,23,29,227,152,233,62,100,155,79,173,17,74,2,90,66,243,197,204,171,126,166,95,177,159,92,170,191,75,83,212,196,20,30,46,210,226,244,97,67,189,126,15,82,229,228,252,168,217,76,110,234,18,173,41,106,133,169,164,142,122,82,98,224,16,229,4,122,84,215,124,158,102,33,157,208,31,181,254,200,73,26,208,212,236,173,230,180,93,162,158,229,45,199,150,159,7,15,180,2,39,166,76,64,208,92,136,146,26,30,238,25,115,23,35,34,118,224,169,72,16,39,252,99,144,37,222,119,184,48,16,21,48,50,165,117,148,136,228,22,249,171,202,66,8,197,254,163,177,199,147,223,217,16,196,49,236,154,170,142,164,201,169,146,246,59,221,54,21,76,218,131,94,165,130,6,119,54,216,238,140,233,205,206,243,253,71,232,93,80,124,30,197,113,132,244,53,77,194,220,216,208,205,171,66,224,230,86,77,246,241,75,14,187,205,251,239,191,119,233,222,193,54,85,134,77,203,51,205,171,233,189,149,16,224,32,113,218,114,134,140,155,113,145,34,223,241,121,128,234,4,51,80,47,221,78,177,47,65,206,66,174,42,219,176,148,249,248,74,220,218,137,8,132,234,75,150,56,50,186,200,173,237,26,77,212,100,226,31,114,89,22,132,97,68,177,22,37,50,185,249,108,45,178,193,49,202,39,74,197,176,99,150,16,178,152,223,243,152,197,242,126,218,111,10,79,157,150,111,42,238,251,142,49,121,158,15,105,16,42,193,80,123,95,81,42,100,58,118,132,217,150,179,169,206,48,214,6,247,65,20,19,169,215,53,18,151,35,214,183,57,168,67,126,68,241,209,225,168,197,242,70,108,114,226,127,107,146,220,201,237,251,32,63,210,171,43,103,39,185,222,41,212,72,151,38,204,232,12,27,41,145,137,61,181,4,172,0,106,160,211,236,194,108,187,253,177,99,102,134,156,3,252,57,119,221,69,175,20,7,232,136,236,22,153,255,168,28,228,84,102,9,134,238,57,244,63,37,33,135,229,53,172,206,97,99,212,220,233,214,160,139,76,183,170,92,82,35,170,157,190,173,29,216,180,170,105,116,182,9,18,22,70,139,133,248,49,97,26,26,93,159,47,236,117,189,166,97,193,226,6,77,47,242,91,91,214,228,105,145,53,84,219,21,213,172,104,107,134,213,206,251,168,183,142,24,43,82,102,135,55,49,99,243,65,103,68,123,83,83,221,199,66,43,102,117,139,185,131,1,29,5,118,98,161,50,215,211,7,62,63,167,180,227,153,56,214,208,151,185,210,201,185,162,197,230,189,117,105,166,142,29,161,194,27,12,221,198,105,183,34,84,237,187,227,105,52,19,224,185,76,248,159,169,93,28,56,36,195,238,218,89,117,60,100,27,20,200,146,144,218,17,180,193,187,52,220,234,34,126,172,55,31,237,86,55,91,79,33,124,249,67,92,93,168,106,135,166,217,163,18,130,89,52,154,77,134,106,220,215,22,241,52,218,165,248,182,59,193,29,228,188,160,108,87,81,220,40,171,95,204,130,170,241,201,124,4,174,253,63,128,75,185,71,49,80,203,164,217,98,233,174,239,212,155,17,85,23,227,180,52,30,199,232,167,68,186,231,162,91,118,114,24,101,97,185,193,189,32,124,244,58,215,2,254,207,215,244,206,110,134,209,206,112,81,167,11,99,83,156,189,207,133,204,158,191,234,29,40,105,238,114,224,204,150,193,206,23,1,226,5,85,207,61,192,117,153,168,103,139,74,164,187,246,248,69,255,85,214,154,195,3,229,93,100,121,218,234,233,155,203,84,211,90,54,189,233,238,30,247,4,170,117,175,166,116,171,159,224,251,113,25,33,159,110,27,40,149,67,202,156,227,92,137,140,90,101,204,253,56,228,85,5,181,172,85,174,221,15,190,64,166,53,60,56,139,50,244,130,37,126,4,127,84,192,12,185,182,22,96,231,157,134,86,172,72,197,141,155,176,150,217,226,38,172,186,50,179,174,47,62,93,162,25,42,146,122,243,229,222,224,19,30,38,162,206,71,215,215,171,26,205,67,234,43,227,158,64,185,234,51,81,13,96,28,160,202,174,229,144,120,139,138,76,29,238,120,86,108,65,154,9,82,141,250,178,27,28,74,163,215,148,246,35,21,143,248,244,43,190,198,131,37,125,232,13,43,66,155,89,59,2,203,68,90,105,97,5,74,218,35,78,135,18,132,180,211,232,10,96,108,3,146,46,74,49,172,66,75,87,246,9,144,215,178,103,177,91,239,72,53,128,187,186,142,142,154,197,128,239,113,122,186,95,180,219,109,44,53,85,169,217,19,33,154,52,160,52,58,247,165,6,5,54,215,230,116,217,147,22,242,190,231,227,42,42,40,73,21,175,58,172,44,233,89,167,238,242,230,85,24,49,83,122,113,171,166,115,39,43,11,150,11,190,172,192,28,243,236,174,145,209,44,82,74,118,36,254,135,162,18,60,148,165,160,168,2,92,213,141,163,150,217,185,34,24,55,10,150,74,78,78,123,49,159,246,137,59,40,121,245,133,229,220,132,244,154,199,162,125,30,26,103,161,98,158,204,95,63,70,106,94,90,89,119,127,226,58,78,1,118,102,109,86,162,89,37,106,157,249,159,124,174,101,100,109,42,234,214,29,233,250,230,188,113,11,35,218,248,117,168,109,93,202,88,221,242,157,130,166,137,211,122,160,245,108,255,88,129,119,223,249,40,128,2,58,213,12,217,56,172,36,250,132,231,77,2,223,218,84,28,120,118,227,189,34,155,205,3,92,112,50,143,16,214,153,164,33,77,199,230,34,159,177,25,213,240,149,127,163,30,149,226,73,77,169,180,68,221,10,245,38,71,174,203,158,230,93,141,117,91,163,47,29,172,173,158,106,235,233,109,145,59,94,240,254,217,85,128,51,237,221,201,222,58,141,118,188,195,173,153,41,202,102,3,145,234,5,209,62,172,159,18,55,30,159,139,219,119,41,158,161,22,171,253,186,184,71,74,114,175,74,76,39,42,116,144,178,108,77,220,164,233,231,90,36,228,94,84,155,18,249,109,110,24,94,195,197,93,73,144,83,11,89,75,207,26,109,87,92,118,108,37,91,31,134,231,233,236,17,214,246,226,10,201,14,212,213,185,51,111,73,7,29,61,198,163,48,188,14,18,196,16,23,141,4,97,105,195,73,170,209,174,100,7,116,156,90,173,193,174,253,187,111,169,110,2,36,131,38,166,234,118,73,155,181,235,6,206,17,9,91,215,107,61,33,64,49,169,66,210,171,87,142,194,177,239,20,181,251,118,102,181,227,126,86,136,247,93,193,114,137,194,71,152,174,104,144,139,240,249,191,93,199,56,107,2,52,147,68,9,227,170,13,142,106,30,255,191,202,131,79,146,254,125,166,0,174,72,80,184,21,201,60,18,43,17,170,31,58,13,93,245,4,244,255,115,150,150,216,122,166,192,94,84,91,232,243,5,241,86,102,110,164,108,176,44,215,176,202,208,237,116,174,70,242,210,148,206,249,212,200,202,218,134,250,158,230,197,41,155,155,11,163,18,216,45,107,251,35,97,112,212,186,160,227,185,41,243,157,179,166,163,250,28,60,155,58,145,187,123,235,58,65,7,108,73,54,67,13,33,119,188,114,236,130,160,133,81,119,224,218,65,50,114,195,190,238,141,28,109,14,138,177,127,1,196,3,153,148,179,59,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69"));
		}

		#endregion

	}

	#endregion

}

