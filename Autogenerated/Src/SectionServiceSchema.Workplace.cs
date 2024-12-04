﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SectionServiceSchema

	/// <exclude/>
	public class SectionServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SectionServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SectionServiceSchema(SectionServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69e688f5-79ee-45b6-b372-e56d1cdaed4c");
			Name = "SectionService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a77104ae-5f68-4069-bd8c-b88c3fda022c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,90,89,79,27,73,16,126,118,164,252,135,150,179,15,99,201,26,222,1,59,50,4,34,175,194,33,12,225,1,69,171,246,76,219,204,102,174,116,247,0,94,196,127,223,170,62,230,246,65,4,236,6,242,146,216,221,85,93,247,215,213,101,98,26,49,145,82,143,145,115,198,57,21,201,76,186,251,73,60,11,230,25,167,50,72,98,119,194,60,252,255,253,187,251,247,239,58,153,8,226,57,153,44,132,100,209,78,237,59,240,133,161,38,22,238,103,22,51,30,120,13,154,47,65,252,163,177,120,150,197,50,136,24,136,226,1,13,131,127,148,224,6,21,236,222,4,30,59,74,124,22,174,220,116,71,160,196,205,250,67,220,75,54,109,16,192,26,16,9,1,204,19,73,37,43,8,142,217,173,4,211,208,67,127,138,242,209,101,207,69,209,178,157,178,79,79,233,156,29,128,205,114,209,78,203,153,123,72,61,153,240,128,137,54,10,84,50,151,5,251,91,91,91,100,87,100,81,68,249,98,104,190,159,242,228,38,240,153,32,163,211,49,73,82,166,69,11,114,27,200,107,34,108,156,44,243,86,137,251,202,56,9,116,150,28,212,248,134,107,35,145,30,51,9,66,83,56,103,26,132,160,251,25,251,145,5,156,69,44,150,194,41,127,65,239,146,1,89,195,130,84,174,89,240,123,40,36,205,166,97,224,17,47,164,66,16,147,119,70,151,109,178,71,5,51,95,250,100,124,198,168,127,18,135,139,114,168,224,4,200,81,248,183,243,129,179,57,172,146,125,60,105,155,28,39,114,228,71,65,28,8,176,7,15,85,190,7,223,158,65,238,131,23,152,230,170,123,81,45,156,177,148,51,129,250,18,110,168,181,11,227,68,18,90,156,202,124,194,204,169,232,212,166,87,59,87,159,168,164,101,159,86,237,93,171,36,217,38,149,44,50,206,200,183,241,68,172,209,22,67,212,74,81,158,36,153,229,202,146,219,235,192,107,179,102,186,0,131,189,132,251,218,158,22,131,180,69,71,44,154,50,238,28,3,144,64,204,187,83,136,177,226,234,170,144,230,70,142,15,226,44,130,36,156,134,108,23,68,64,62,15,201,158,165,37,247,100,206,228,14,164,37,252,243,160,163,241,100,86,20,185,255,72,67,78,114,198,141,108,41,200,235,230,116,58,198,166,15,44,246,117,106,86,243,20,106,21,152,209,144,109,114,170,100,232,253,148,35,142,49,50,46,0,227,136,198,240,153,147,191,210,250,210,206,138,44,70,126,65,34,77,184,36,63,173,113,77,89,205,21,157,103,96,36,25,12,91,84,33,31,63,170,116,236,116,156,150,205,129,174,75,141,112,11,184,42,228,110,83,232,208,137,217,45,38,60,56,56,67,194,17,159,131,211,99,233,116,51,175,219,39,23,130,113,216,141,117,46,244,122,61,196,201,78,71,44,85,105,64,110,104,152,41,60,95,23,142,35,38,175,19,31,99,161,253,191,194,177,251,156,1,129,128,13,198,136,199,217,108,208,29,27,228,50,130,187,91,67,18,68,105,168,64,79,229,7,9,192,40,26,123,108,73,32,212,74,74,57,141,72,12,201,56,232,202,69,202,186,67,115,172,141,34,193,85,119,119,75,17,22,124,156,201,140,199,98,248,115,10,237,110,89,254,74,250,85,15,32,16,177,234,138,163,171,64,169,212,51,201,161,15,106,9,117,149,245,145,113,238,235,180,90,202,99,46,182,115,244,88,95,235,211,123,92,200,75,229,119,149,151,116,5,182,175,224,250,29,199,55,201,119,230,104,54,132,139,211,147,201,57,72,220,75,252,197,68,46,66,132,16,32,59,130,235,9,172,204,87,221,75,78,211,148,249,218,12,188,252,152,144,135,9,143,168,172,48,232,37,213,103,244,137,69,248,213,116,26,162,86,32,20,56,95,117,101,52,28,197,254,68,164,38,14,194,249,156,5,190,237,8,198,190,141,223,13,229,121,170,13,90,66,222,53,135,117,77,229,33,61,220,144,89,136,26,98,124,190,0,8,91,225,142,33,146,124,97,142,87,244,182,13,1,14,139,77,40,8,146,94,215,110,174,98,161,157,62,167,163,37,185,35,223,63,163,241,156,141,103,112,125,30,220,129,196,156,86,64,27,135,55,133,3,167,15,137,112,207,147,137,210,197,201,177,66,33,115,199,163,18,110,14,231,224,206,99,169,74,49,163,224,67,57,139,181,184,114,34,189,186,220,176,190,30,1,76,6,184,9,252,151,9,255,158,134,240,58,208,57,114,107,191,62,81,150,148,98,14,82,131,16,165,230,34,243,216,151,165,238,52,131,178,60,204,111,34,92,151,208,139,38,153,132,122,254,26,176,91,103,227,184,76,38,167,235,98,178,183,64,24,117,12,39,126,214,207,58,26,190,245,56,96,53,168,40,192,237,228,107,168,26,251,63,13,164,165,80,24,143,150,130,112,198,66,108,100,11,33,53,40,252,229,253,106,90,135,194,47,152,104,162,146,200,126,160,54,160,63,50,87,203,167,124,193,148,68,31,90,24,153,223,50,51,120,64,83,4,245,210,137,54,46,234,115,16,87,246,174,190,245,48,184,232,238,175,216,35,10,7,27,135,100,86,166,129,91,195,222,92,133,58,120,255,216,128,168,250,40,178,30,62,94,128,251,184,211,235,19,7,148,235,149,200,42,247,143,9,57,250,5,66,119,3,207,128,124,14,194,78,166,127,99,73,21,2,95,55,166,217,23,47,98,90,237,45,204,121,194,159,167,192,12,241,113,18,151,68,50,63,127,155,234,202,219,167,170,57,120,249,242,51,65,120,238,136,172,159,62,128,171,170,68,6,148,128,102,111,129,207,55,29,29,124,120,77,188,107,22,209,139,106,132,242,233,137,46,225,245,2,77,181,21,67,130,182,182,210,188,7,42,175,239,54,58,93,112,197,125,103,194,120,180,42,109,14,238,36,227,113,209,187,212,154,87,180,20,24,27,47,87,76,42,229,143,170,43,76,227,26,204,136,218,32,3,80,51,11,195,28,85,74,183,169,178,223,208,63,20,2,227,154,251,65,120,213,12,148,108,221,104,19,182,30,51,112,103,48,191,134,54,25,149,112,97,232,105,58,237,186,158,86,13,183,226,255,218,97,110,62,237,105,114,85,3,210,100,44,246,87,117,227,132,221,229,30,202,15,47,118,7,176,223,2,166,21,31,254,46,81,85,162,58,206,246,165,206,74,81,199,137,215,171,174,212,178,177,112,64,117,164,224,150,11,192,22,210,97,16,251,99,51,20,217,91,160,131,156,134,199,74,5,93,21,80,47,108,121,205,147,91,101,233,24,126,97,0,119,30,38,89,236,231,73,236,252,209,213,42,224,176,18,7,62,228,190,46,235,65,77,54,103,200,230,90,27,159,15,25,202,210,221,255,20,18,136,130,131,78,29,14,200,83,224,65,235,56,111,194,96,206,95,26,157,149,115,195,109,239,15,96,156,214,223,144,163,52,80,134,25,92,154,15,125,251,86,252,97,16,134,21,249,128,207,208,188,148,207,28,121,30,220,228,88,50,120,134,196,22,10,18,131,155,129,33,48,153,153,97,229,242,1,210,194,228,86,85,241,48,26,251,224,41,245,220,32,66,173,138,77,39,148,85,105,67,188,254,204,17,4,22,42,83,202,95,190,85,90,249,35,12,36,144,129,150,162,61,210,101,181,182,73,106,159,141,61,10,247,158,165,47,89,15,95,42,220,0,94,23,96,218,125,229,244,85,192,85,67,168,229,158,91,211,170,108,210,56,40,20,48,67,227,165,193,115,128,165,5,60,214,178,245,222,16,172,148,239,134,151,0,150,186,188,161,185,42,127,131,139,41,145,90,46,108,214,229,61,21,212,188,234,198,106,115,124,90,210,48,173,109,95,94,14,149,126,193,81,209,149,54,116,155,24,130,83,68,5,38,75,191,208,143,133,26,11,157,120,94,198,225,79,72,186,149,91,122,154,36,33,226,174,253,51,18,13,59,237,88,187,100,174,164,142,8,170,66,64,238,140,134,246,117,94,171,163,77,135,80,29,59,126,218,84,191,250,207,95,38,179,172,236,166,142,240,187,40,107,73,154,26,225,27,186,183,114,15,62,251,141,85,72,178,63,216,191,88,3,252,127,175,197,6,126,214,18,194,56,236,69,202,241,160,126,159,149,106,114,105,7,111,21,124,129,122,172,253,161,2,172,62,252,11,123,252,140,72,172,41,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69e688f5-79ee-45b6-b372-e56d1cdaed4c"));
		}

		#endregion

	}

	#endregion

}

