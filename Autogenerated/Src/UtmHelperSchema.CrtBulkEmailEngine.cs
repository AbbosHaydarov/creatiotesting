﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtmHelperSchema

	/// <exclude/>
	public class UtmHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtmHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtmHelperSchema(UtmHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e02aad0-4fd4-4d2f-85a6-43398aa0ca6e");
			Name = "UtmHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5da875-f48b-48a1-a687-7137717191f8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,26,107,79,35,57,242,115,86,218,255,224,105,78,208,25,66,3,119,210,73,7,36,17,203,176,115,104,153,199,241,184,147,46,4,212,164,157,164,53,253,200,216,110,102,88,38,255,125,203,207,182,251,145,132,213,221,106,119,38,109,151,171,202,245,174,242,102,97,138,233,34,156,96,116,131,9,9,105,62,101,193,89,158,77,227,89,65,66,22,231,89,240,33,204,34,18,39,201,53,38,79,241,4,255,252,211,203,207,63,117,10,26,103,51,116,253,76,25,78,143,43,223,112,62,73,240,132,31,166,193,123,156,97,18,79,106,48,151,113,246,181,182,120,131,191,179,224,10,207,138,36,36,231,223,23,4,83,202,145,0,28,64,110,17,60,131,47,116,150,132,148,30,161,91,150,190,11,89,40,182,22,197,99,18,79,208,132,239,148,27,29,206,168,222,123,204,243,4,221,82,12,187,232,5,205,48,59,70,148,255,177,180,96,40,35,156,153,119,121,26,198,25,93,7,6,152,174,243,130,128,228,214,3,126,192,81,92,164,27,0,158,133,233,34,140,103,217,6,160,160,175,141,48,230,25,195,25,91,7,121,131,211,69,18,50,124,150,71,245,11,45,109,41,83,6,118,161,133,13,216,159,48,97,56,106,150,186,130,85,155,26,250,38,87,11,62,155,199,20,253,82,36,95,206,65,228,9,122,212,191,122,154,45,102,177,213,69,2,117,135,96,86,144,12,101,248,155,65,44,55,58,74,191,253,18,81,32,151,122,114,95,107,214,6,80,107,10,162,84,170,131,68,175,150,80,74,163,21,40,185,90,66,25,117,86,224,244,122,9,41,180,89,129,226,107,22,46,165,200,42,42,185,172,224,28,53,246,29,241,9,128,37,247,185,78,169,211,45,12,206,45,252,170,197,199,254,137,147,5,38,98,115,127,127,31,157,208,34,77,67,242,60,80,223,2,16,77,115,130,190,229,228,11,250,22,179,57,63,133,88,56,163,129,62,179,111,29,170,186,170,198,207,205,134,179,102,56,0,191,103,97,198,128,139,207,36,126,130,59,200,253,9,95,215,214,241,57,100,12,147,12,98,201,23,184,172,231,159,132,163,251,193,248,237,112,116,191,55,158,19,60,189,187,163,111,251,163,59,239,110,103,220,245,135,39,9,192,13,70,247,226,123,183,235,235,13,126,102,183,59,28,120,199,237,36,62,135,132,133,233,133,34,37,68,233,1,70,96,145,176,129,38,203,201,85,200,74,106,119,119,195,45,78,113,120,242,181,192,228,249,65,226,30,192,178,220,231,155,67,216,157,146,112,150,130,50,31,226,104,176,101,24,229,59,160,166,129,224,115,208,93,197,166,52,102,195,224,232,254,104,188,123,180,191,47,80,68,98,111,48,10,247,126,63,221,251,239,193,222,63,198,229,207,189,135,241,203,97,239,239,135,75,123,41,24,191,28,244,150,93,31,142,175,162,9,74,188,12,31,113,194,53,48,26,110,143,253,130,165,15,84,184,203,15,254,115,162,108,93,124,164,194,65,196,79,56,43,127,76,164,5,119,251,154,74,197,40,27,109,66,152,145,220,214,38,213,204,155,112,148,139,200,176,200,157,231,1,243,197,7,18,71,107,105,126,192,108,158,71,85,43,172,186,130,244,5,130,1,128,34,41,104,148,196,148,113,23,168,251,128,92,89,132,36,76,81,6,249,183,239,201,35,212,27,92,75,246,133,31,169,69,63,194,73,156,198,16,99,229,242,78,111,7,129,191,237,28,239,116,79,246,5,146,18,167,12,141,116,112,9,180,81,62,213,40,78,246,245,134,144,23,201,25,164,103,192,167,194,51,135,62,81,54,137,222,99,38,173,136,175,250,74,156,10,143,142,192,79,33,65,11,41,97,16,169,132,9,126,205,73,26,50,223,187,127,57,88,254,197,235,185,38,217,61,54,7,33,171,23,9,15,99,254,148,228,169,150,22,252,171,136,4,215,139,36,102,62,132,247,209,24,50,17,92,183,199,47,139,150,93,25,226,58,29,4,153,137,23,24,8,74,5,252,29,10,20,54,153,99,144,147,56,31,220,144,56,245,187,61,205,96,79,66,125,90,200,122,228,98,150,229,4,159,133,20,27,116,128,47,206,88,142,128,251,201,92,178,91,82,250,54,199,4,219,91,80,221,20,60,10,247,209,97,141,31,11,108,116,48,14,222,147,188,88,208,145,210,174,55,14,254,29,38,5,238,6,55,185,144,173,146,137,74,103,82,44,58,60,183,26,217,149,84,36,18,138,7,115,35,218,226,121,12,46,72,34,109,4,220,106,79,135,224,141,236,15,146,168,55,16,169,84,159,23,33,188,213,192,108,59,21,32,24,88,161,154,137,53,246,166,56,6,75,3,255,132,200,26,166,18,157,175,211,57,103,71,219,154,2,46,20,100,221,222,202,112,211,7,203,219,46,163,76,255,229,80,126,234,8,212,127,249,235,210,83,137,146,147,168,229,117,189,232,164,113,189,168,115,182,82,91,60,245,223,40,78,46,232,199,34,73,62,145,243,116,193,158,125,13,207,179,119,87,223,162,99,248,223,133,24,180,173,227,95,223,67,187,200,62,32,113,47,55,163,160,82,255,42,34,42,182,58,116,212,49,155,148,178,65,125,254,127,100,133,57,196,229,89,200,114,242,108,12,106,83,131,52,37,206,213,69,228,13,202,10,17,62,255,223,54,105,136,1,45,219,56,33,70,148,149,23,236,181,27,104,75,242,217,117,142,67,20,80,136,221,56,176,177,14,182,172,127,212,135,249,75,111,202,191,13,168,136,11,226,215,171,19,147,67,96,171,166,3,251,140,93,116,86,15,174,62,169,239,174,79,73,94,245,157,12,243,235,176,100,180,120,164,19,18,63,226,15,225,132,228,244,52,137,33,222,155,75,88,236,148,146,49,136,181,56,90,205,236,181,162,94,99,120,239,98,209,41,3,73,149,130,117,239,35,82,49,175,55,41,68,186,43,12,34,157,96,223,73,213,74,57,141,205,82,79,118,188,133,108,127,52,132,22,176,10,109,106,149,224,175,69,76,68,15,39,119,209,197,121,86,164,152,132,143,9,54,212,218,196,106,23,5,243,103,40,230,121,153,205,123,44,222,160,181,223,78,155,61,184,39,14,39,115,95,100,113,153,65,69,145,13,5,129,155,222,221,219,89,165,127,123,134,55,129,145,243,198,217,2,174,12,5,147,158,249,134,78,206,146,167,142,227,94,234,103,175,162,107,253,71,169,105,121,86,200,61,166,220,251,191,243,50,172,95,185,7,39,215,171,22,207,237,119,80,245,198,0,29,160,31,63,208,27,169,208,99,135,148,137,88,23,209,102,36,237,176,180,41,229,198,76,84,181,28,165,83,35,131,210,100,132,177,0,99,156,21,62,96,98,162,180,245,222,254,184,253,120,125,251,203,145,167,79,106,115,80,166,25,138,99,96,11,235,172,79,164,75,23,185,56,91,218,0,64,52,49,196,136,209,58,240,13,196,191,232,47,153,26,245,95,128,190,225,60,8,198,183,116,189,189,221,160,14,139,5,158,142,227,204,16,84,225,221,177,183,106,96,177,4,42,253,93,42,53,114,89,231,6,110,85,159,171,45,64,194,180,43,254,216,220,216,111,44,124,15,186,112,111,117,35,255,141,46,219,79,51,168,76,20,245,193,102,165,112,112,254,181,8,19,93,185,247,144,76,136,103,57,20,90,36,166,48,123,252,68,162,56,11,19,219,165,45,105,86,229,49,5,92,171,68,107,187,178,250,208,255,85,132,110,45,27,89,148,177,205,152,216,111,248,217,47,227,73,153,208,55,208,184,81,24,63,250,14,3,186,132,214,180,214,132,187,215,52,146,216,68,151,85,106,86,35,83,178,187,178,174,40,197,161,51,135,24,103,168,186,203,10,173,138,130,173,120,123,240,81,9,182,162,208,109,112,155,210,113,47,50,10,99,195,127,149,196,32,240,76,109,226,189,90,14,211,23,215,238,171,136,216,158,234,152,207,235,168,21,109,84,26,229,87,117,105,187,146,113,229,41,155,64,53,207,170,244,57,208,220,12,161,163,129,30,230,229,111,166,141,233,116,86,9,93,140,167,180,180,205,9,251,38,155,96,177,166,82,53,92,171,206,193,68,197,244,188,90,78,150,19,157,70,81,139,129,151,82,208,231,150,245,94,165,196,180,121,165,108,242,247,173,86,128,227,241,102,247,234,114,211,250,216,146,101,173,212,149,152,94,85,240,186,117,227,138,131,81,254,49,103,23,220,78,229,81,219,234,156,251,182,86,236,141,229,108,189,206,94,89,187,62,229,113,132,154,221,165,30,32,106,69,168,118,185,214,62,215,58,92,70,84,55,228,212,125,100,27,124,196,120,71,165,222,181,15,7,215,220,57,232,127,160,91,244,189,161,215,69,67,155,217,224,26,242,188,188,205,97,207,217,184,196,217,12,26,204,61,30,53,143,236,29,101,171,75,132,33,11,53,115,235,244,118,210,156,151,155,142,31,173,129,103,163,145,159,46,22,128,131,138,78,219,234,126,97,174,197,230,24,137,129,167,105,16,94,55,22,82,15,34,252,131,207,20,93,2,193,74,51,117,219,120,248,131,35,224,252,152,96,255,39,59,185,242,137,81,99,20,213,30,76,95,57,135,229,49,200,73,252,92,157,75,109,215,231,142,96,202,233,151,115,67,199,9,156,151,173,114,108,96,191,188,112,163,210,149,189,51,212,234,241,73,163,51,6,80,150,249,103,26,46,39,103,84,30,126,196,172,199,94,147,38,215,212,62,2,180,59,243,21,103,213,179,152,50,234,250,140,163,62,188,19,67,59,7,188,154,147,229,177,182,249,138,51,91,145,120,86,244,198,78,167,217,208,40,155,222,184,38,9,181,228,60,12,154,56,209,208,11,183,170,193,25,219,216,137,109,54,3,239,5,106,126,93,53,138,158,63,41,8,225,175,118,229,185,46,175,154,213,114,160,111,97,118,3,40,53,45,96,149,85,37,11,34,132,172,24,213,165,249,19,174,197,5,49,123,135,177,216,166,161,0,64,189,193,45,192,183,122,146,220,92,235,42,146,31,16,239,175,192,193,45,137,117,167,7,4,180,97,195,42,124,198,229,156,21,22,96,172,255,44,31,88,124,128,236,33,88,250,45,206,162,224,244,145,230,73,193,64,171,121,193,248,169,50,83,232,129,26,73,236,81,167,157,152,120,72,6,212,34,119,25,106,215,173,169,104,29,234,201,28,138,122,202,95,47,248,68,180,143,118,182,119,28,127,144,201,64,62,7,139,223,86,150,57,232,65,66,177,161,225,241,67,192,124,46,117,214,183,114,138,157,160,186,229,147,9,226,60,136,119,19,195,199,82,247,85,2,72,183,8,82,13,226,114,231,25,108,27,123,86,188,66,174,159,192,255,126,129,35,33,156,50,211,138,19,238,228,198,190,157,225,150,247,236,21,254,141,244,64,200,238,150,157,139,155,167,20,188,227,172,224,115,18,184,245,8,224,89,221,105,103,205,17,243,50,224,109,66,64,78,236,95,131,94,79,223,55,193,174,30,45,188,149,205,163,238,100,26,141,212,213,153,133,167,162,76,120,29,208,214,225,98,94,212,224,92,158,171,175,19,175,226,162,130,92,225,22,238,176,91,49,183,166,167,9,240,211,79,36,158,241,113,128,34,171,131,164,192,3,239,125,46,93,187,43,168,84,87,245,255,245,1,86,254,0,38,61,240,100,9,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e02aad0-4fd4-4d2f-85a6-43398aa0ca6e"));
		}

		#endregion

	}

	#endregion

}

