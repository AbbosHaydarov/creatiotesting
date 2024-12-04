﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IgnoredEntityListSchema

	/// <exclude/>
	public class IgnoredEntityListSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IgnoredEntityListSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IgnoredEntityListSchema(IgnoredEntityListSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93e0ac8f-9a34-42f9-8aaf-3d5bb3c2ee6f");
			Name = "IgnoredEntityList";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,90,219,114,28,183,17,125,94,87,249,31,166,232,60,208,85,172,101,242,26,145,84,89,55,135,85,146,205,152,180,94,226,100,11,59,131,221,69,17,3,108,0,204,82,107,153,255,158,131,203,204,224,50,179,146,163,7,138,115,78,3,104,52,186,27,13,128,130,180,84,239,73,77,171,7,170,20,209,114,99,150,175,165,216,176,109,167,136,97,82,44,127,228,114,77,248,61,37,170,222,125,251,205,231,111,191,89,116,154,137,109,117,127,212,134,182,47,178,111,52,230,156,214,182,165,94,254,72,5,85,172,46,100,30,232,39,179,252,133,110,59,78,212,219,79,123,69,181,182,242,163,220,215,232,130,129,186,86,252,106,24,159,105,168,232,242,173,48,204,48,58,47,240,142,212,70,42,47,1,153,239,20,221,98,156,234,53,39,90,255,189,186,221,10,8,53,174,151,227,123,166,141,19,186,188,188,172,174,116,215,182,68,29,111,194,55,212,52,74,114,93,49,223,164,162,97,228,138,136,166,170,157,170,122,217,55,190,140,90,239,187,53,103,117,85,219,17,167,6,92,88,139,143,138,193,76,134,8,3,229,238,20,59,16,67,157,74,133,78,14,120,67,55,164,227,38,232,84,49,152,94,87,123,98,12,85,94,153,82,155,197,222,247,90,97,20,3,181,20,37,141,20,252,136,111,5,243,253,235,223,213,170,241,189,6,85,111,109,167,119,161,207,234,186,114,218,46,206,72,93,203,78,152,149,124,130,7,252,229,236,194,163,255,169,73,187,39,80,231,183,223,150,186,222,209,150,52,196,144,129,94,161,175,61,199,232,175,100,115,28,81,237,150,251,167,174,93,71,93,173,72,211,88,191,49,199,61,29,193,90,182,109,39,88,237,188,37,165,180,172,25,225,45,109,24,97,205,8,195,19,161,57,225,39,90,10,41,224,37,29,225,48,134,150,98,36,182,123,157,126,69,141,96,199,154,114,172,224,0,61,10,249,196,105,179,165,107,162,41,58,53,84,207,112,181,108,232,12,245,72,143,79,82,53,99,203,186,236,204,65,24,31,126,109,142,41,10,104,203,68,138,213,92,234,78,209,100,80,71,104,216,66,111,48,117,88,132,211,3,229,89,59,44,212,86,170,108,132,61,81,112,125,251,107,174,143,172,109,152,139,173,97,45,133,165,77,54,24,85,7,88,108,186,83,45,249,129,194,15,117,183,223,75,101,38,148,153,103,118,146,55,145,223,244,202,172,57,109,179,249,236,136,216,70,43,136,213,118,83,47,244,181,234,116,147,76,152,132,13,180,164,249,164,64,220,203,32,16,52,91,145,206,236,164,42,224,196,49,123,176,88,234,158,176,49,220,233,2,206,38,170,40,167,206,132,169,116,15,39,67,246,96,49,100,152,24,54,18,147,119,20,83,73,103,73,155,240,187,146,7,22,47,215,9,153,26,166,3,60,41,90,19,78,69,67,102,250,153,244,21,103,148,220,238,1,13,78,157,218,45,112,90,118,170,46,208,125,167,246,82,23,112,233,222,65,188,136,214,208,121,106,202,128,134,85,24,97,187,71,58,151,202,196,123,60,232,31,62,75,190,84,107,96,108,22,159,34,252,126,52,209,32,153,197,168,152,162,212,148,120,72,226,3,225,118,205,99,216,97,14,132,119,81,90,219,72,213,110,24,229,81,242,219,218,250,2,186,55,79,116,109,233,213,58,222,56,10,214,154,135,206,211,233,94,85,208,137,239,194,193,248,170,97,72,155,54,132,83,24,51,130,246,41,102,115,193,33,77,199,64,177,140,77,138,32,183,39,201,202,66,206,91,109,158,201,90,39,73,182,31,160,116,165,129,201,124,123,192,109,2,250,93,138,137,190,80,183,68,13,86,216,175,81,108,33,176,50,63,91,161,166,146,10,233,25,212,8,54,161,104,99,162,21,29,246,39,20,66,59,196,138,158,80,140,115,249,68,155,204,110,3,141,2,85,147,45,77,236,63,146,80,105,71,244,174,100,182,174,86,236,63,163,61,127,28,55,252,2,119,20,217,66,14,50,82,109,137,96,191,71,139,50,90,7,122,151,46,176,218,97,81,169,66,150,218,83,101,43,192,178,97,135,108,228,108,153,187,255,32,193,165,47,68,74,230,191,29,237,220,254,81,82,137,243,135,236,136,106,45,202,130,61,168,17,89,166,172,116,122,26,174,159,120,97,128,205,19,179,101,30,217,52,164,224,80,38,208,181,148,143,147,36,103,226,17,117,151,152,36,81,123,8,156,65,74,37,216,129,138,73,166,101,77,131,244,62,69,165,33,236,130,105,85,119,10,217,175,62,102,176,207,219,105,188,121,102,79,142,45,18,81,98,26,207,96,173,41,212,74,21,14,163,160,126,68,163,2,117,122,137,180,118,101,226,32,177,25,245,3,101,209,212,179,118,155,226,140,170,53,227,48,32,202,182,141,44,100,234,78,27,217,126,73,38,155,63,92,179,233,10,99,245,104,82,208,244,224,108,31,134,124,42,177,196,112,99,246,154,39,108,9,74,179,234,58,225,243,253,41,38,17,65,123,228,30,134,218,166,193,6,175,76,186,14,145,228,19,37,143,2,241,22,197,100,76,219,77,10,229,233,110,186,45,67,142,80,147,84,67,117,173,216,62,137,215,152,183,89,62,153,122,35,235,206,42,153,109,72,214,89,84,95,64,77,192,126,23,47,113,235,200,18,231,42,113,44,185,98,225,172,50,121,157,224,48,38,26,56,83,100,99,135,18,33,220,193,7,177,216,209,140,154,56,128,57,162,152,111,130,78,141,29,78,139,197,50,199,164,243,86,189,99,251,148,157,88,114,135,103,57,44,200,146,12,73,67,192,219,6,165,163,158,192,163,21,157,27,211,54,45,39,30,74,40,216,54,197,125,5,85,192,182,128,42,192,245,190,221,41,186,41,192,24,107,31,205,118,220,155,80,41,138,168,188,77,200,108,9,18,46,157,121,218,103,238,75,41,27,142,246,56,192,39,145,98,93,39,203,9,30,74,71,242,88,166,153,7,183,146,240,188,59,84,28,12,23,55,199,12,47,156,216,195,253,241,221,37,10,58,73,98,139,159,28,92,211,173,203,209,147,100,63,231,168,46,243,192,192,228,21,121,207,207,116,59,240,134,40,84,60,83,153,101,16,73,237,55,192,157,105,231,213,74,150,97,221,241,71,87,134,100,93,141,248,140,120,166,116,68,76,207,106,20,128,114,217,121,41,225,236,237,76,215,78,115,197,164,18,22,14,49,215,14,169,48,142,212,145,108,36,254,19,147,243,192,198,139,82,39,186,188,25,185,34,73,141,20,39,157,168,119,50,93,175,200,154,225,118,203,157,126,182,163,128,20,157,46,131,203,21,122,43,127,32,242,119,101,53,113,61,167,2,225,94,37,145,200,250,216,48,14,243,36,55,109,49,1,155,155,9,210,253,140,135,207,248,181,189,79,197,200,137,2,131,76,168,21,89,211,3,125,129,56,34,53,54,124,28,175,214,199,33,169,201,250,49,254,110,101,195,112,224,179,136,5,158,253,21,237,226,59,100,118,159,59,195,119,184,26,189,27,42,110,123,55,138,27,177,26,189,159,184,29,181,215,171,149,220,84,72,233,216,42,62,17,212,15,149,14,55,215,149,173,240,190,112,67,106,219,95,249,107,209,155,106,21,238,125,239,67,7,47,188,100,208,162,58,48,108,29,132,167,109,110,211,38,225,234,20,97,31,126,91,40,106,80,28,23,125,87,47,95,122,126,177,56,47,184,235,158,90,8,250,148,142,23,122,181,255,206,62,62,189,14,241,244,94,110,131,193,123,230,159,118,125,237,189,110,134,223,249,149,126,207,214,25,129,91,253,55,117,155,227,64,31,20,17,26,46,63,122,237,64,245,157,101,163,131,249,161,105,153,248,21,251,236,36,241,51,214,184,236,240,77,135,136,181,145,249,75,199,105,194,188,181,161,87,34,15,33,22,231,153,119,44,235,105,24,67,23,131,220,215,56,114,139,237,7,92,161,166,99,221,187,75,231,15,254,0,155,48,175,144,22,220,120,247,54,215,156,160,10,61,222,35,138,186,125,58,12,14,132,111,237,142,244,128,132,61,207,20,93,221,249,3,72,49,159,8,47,218,244,126,115,231,247,249,83,92,209,214,185,202,252,202,223,169,250,31,112,88,36,215,9,242,158,26,3,27,107,151,11,220,191,231,239,93,148,45,158,221,79,61,198,77,25,20,149,187,75,138,196,159,79,36,134,55,204,53,3,100,211,131,217,209,225,81,39,164,135,252,77,231,228,51,74,255,108,194,38,222,75,102,178,196,208,104,242,141,229,75,105,34,149,126,249,178,26,146,68,254,86,115,234,41,231,75,182,205,251,250,51,6,190,210,148,86,72,255,155,235,179,153,7,189,179,203,155,138,185,151,174,250,75,105,120,166,135,42,220,255,76,190,21,70,54,159,107,62,135,23,214,103,27,24,120,102,172,234,250,186,18,29,231,223,15,185,119,94,210,191,57,250,247,200,35,94,78,205,213,140,10,55,231,97,109,194,226,12,235,127,106,194,201,162,204,237,160,31,40,46,8,155,116,251,92,44,82,123,97,15,231,21,180,187,213,253,246,229,54,254,115,255,100,233,63,42,95,12,244,179,14,250,121,176,55,73,245,199,31,1,89,222,234,55,175,62,50,236,86,49,244,49,196,66,34,118,196,182,140,20,204,249,241,181,47,30,220,220,220,212,190,110,94,238,173,245,132,103,98,98,120,194,29,95,113,125,144,207,120,160,67,252,228,244,205,131,234,144,39,54,161,69,212,199,242,234,178,151,113,150,244,207,189,125,168,23,230,244,11,55,101,206,139,42,6,189,92,24,174,183,180,79,28,1,252,129,51,98,253,106,198,141,172,139,57,145,115,47,126,209,175,218,139,178,43,196,249,14,61,121,108,249,14,183,225,196,156,159,125,254,235,243,242,243,223,158,207,250,150,203,159,80,52,93,244,54,179,31,161,47,92,159,227,49,108,87,157,31,136,170,162,252,17,210,7,34,125,50,211,13,81,227,140,196,244,59,212,105,183,189,46,248,235,1,250,9,62,241,129,224,93,38,76,193,82,23,19,3,92,120,233,159,93,113,172,151,126,172,215,184,61,239,3,41,25,160,183,219,212,8,142,251,191,134,176,105,34,153,2,28,59,25,113,204,17,33,94,12,60,42,9,116,255,51,176,27,130,155,248,222,253,79,251,115,191,107,69,126,109,100,229,139,94,247,87,21,39,220,27,23,29,164,117,213,240,245,153,95,229,179,155,171,75,135,206,199,64,57,224,159,12,130,176,113,127,69,82,153,200,68,189,28,12,156,85,216,246,143,73,140,61,242,5,153,200,71,39,50,99,192,98,8,200,255,0,150,19,41,187,48,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93e0ac8f-9a34-42f9-8aaf-3d5bb3c2ee6f"));
		}

		#endregion

	}

	#endregion

}

