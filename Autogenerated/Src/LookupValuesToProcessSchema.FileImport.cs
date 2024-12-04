﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesToProcessSchema

	/// <exclude/>
	public class LookupValuesToProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesToProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesToProcessSchema(LookupValuesToProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c11f5401-c0a0-47d1-92f1-7788a37f4b29");
			Name = "LookupValuesToProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,89,221,111,219,54,16,127,118,129,254,15,172,59,180,50,96,56,219,30,155,196,65,235,36,133,183,36,11,146,118,47,70,16,48,18,157,16,149,40,151,164,156,121,129,255,247,29,63,36,145,148,108,43,105,177,151,196,226,199,221,241,119,95,188,35,195,25,17,11,28,19,244,133,112,142,69,62,151,163,73,206,230,244,190,224,88,210,156,141,78,105,74,166,217,34,231,242,245,171,167,215,175,122,133,160,236,30,93,175,132,36,217,126,240,13,91,211,148,196,106,159,24,125,38,140,112,26,55,214,156,81,246,189,49,120,85,48,73,51,50,186,134,45,56,165,255,106,222,245,170,73,158,101,254,55,39,245,215,5,121,148,192,81,201,254,135,208,203,96,234,45,39,247,64,3,161,73,138,133,248,128,206,242,252,91,177,152,144,52,213,211,123,123,123,232,64,20,89,134,249,106,108,191,63,50,68,153,144,152,1,28,249,28,201,7,42,80,172,118,163,56,103,18,195,28,204,207,115,158,105,233,16,190,203,11,137,98,160,56,42,9,238,57,20,23,197,93,74,99,75,192,229,222,83,48,86,242,1,218,138,165,4,17,47,57,93,98,73,180,124,189,153,58,202,37,207,23,132,203,213,141,26,89,152,105,36,36,87,167,190,141,243,180,200,216,148,37,228,159,253,93,123,56,193,73,206,210,21,42,40,147,232,150,231,143,238,190,183,132,37,70,28,251,237,202,198,139,88,230,92,137,167,15,100,86,132,240,233,129,9,112,145,68,248,32,174,22,4,86,18,130,98,78,230,135,253,26,136,62,218,27,43,224,154,200,149,208,213,107,35,99,129,39,96,36,114,133,168,243,49,68,102,106,162,193,176,83,230,99,128,52,208,189,234,180,232,208,219,138,14,15,17,43,210,20,29,161,132,204,113,145,202,72,161,51,64,31,188,101,163,171,26,44,69,205,129,189,34,104,24,30,141,234,117,235,237,200,158,19,249,144,39,93,64,253,76,36,216,31,96,0,178,102,119,132,111,128,76,143,112,34,11,206,196,120,226,44,63,216,43,71,29,100,173,9,1,109,181,244,66,175,140,6,232,112,108,103,84,12,136,177,140,220,195,14,107,179,25,180,216,141,61,113,112,224,118,47,252,27,167,5,17,95,114,48,213,152,8,161,87,182,184,75,99,153,239,57,232,148,146,52,9,253,166,21,196,105,195,109,49,32,164,80,21,232,241,129,198,15,165,135,163,84,115,70,75,197,122,147,117,90,159,178,230,169,17,50,162,30,28,83,29,252,96,229,129,1,114,136,206,168,144,7,181,37,143,199,99,116,107,152,232,61,106,76,88,56,183,16,214,84,12,73,69,96,233,35,243,98,55,246,28,45,128,59,250,42,8,135,173,204,4,116,84,120,159,218,88,130,21,135,193,154,29,98,217,64,69,73,39,21,26,233,144,204,209,194,200,247,124,237,248,32,6,199,133,243,104,255,238,133,224,162,163,35,20,53,6,33,116,144,199,157,76,34,240,176,63,201,106,80,58,204,15,155,206,89,96,57,74,11,13,115,2,137,205,81,162,230,212,70,185,59,241,15,207,211,77,181,185,4,123,32,73,9,129,253,12,173,39,248,124,66,247,68,238,163,206,113,116,167,1,233,64,106,221,155,184,137,4,124,95,231,14,6,119,161,109,209,117,129,57,206,244,170,195,126,66,132,164,76,7,148,254,120,234,145,113,166,32,248,234,77,205,8,125,182,67,142,32,106,251,153,31,78,114,92,51,113,243,223,5,108,141,220,1,103,157,43,88,153,26,151,152,91,25,174,227,7,146,225,175,211,4,44,4,232,95,145,57,225,4,114,120,53,30,185,219,247,91,119,195,86,95,137,163,19,103,246,28,51,124,15,9,9,168,79,237,5,225,211,74,17,14,4,112,136,211,224,104,192,192,69,247,148,178,164,113,122,103,187,32,234,50,74,18,143,128,77,112,83,113,1,169,255,47,126,146,45,228,42,10,25,13,140,255,244,142,188,243,41,209,193,206,148,85,28,83,177,72,241,202,229,107,183,148,151,135,122,202,8,100,244,217,34,147,123,93,104,42,26,188,45,250,92,208,36,84,211,176,92,19,215,66,171,96,240,75,255,41,88,185,190,125,170,215,172,251,251,59,239,26,13,51,134,219,163,181,6,36,140,162,11,70,191,23,4,209,68,241,154,211,237,183,146,141,126,51,121,134,195,92,237,22,161,221,103,52,120,237,22,253,76,71,17,142,139,132,102,216,66,221,26,34,157,163,232,77,181,21,236,206,88,220,160,164,92,25,70,185,196,108,91,87,108,185,79,122,131,31,4,2,52,92,193,58,168,53,210,142,110,10,149,217,167,149,38,213,34,132,165,238,162,98,126,143,170,67,180,30,109,221,161,130,240,195,180,181,200,70,21,97,50,151,43,188,209,165,170,44,224,42,162,188,227,158,46,9,67,223,200,170,171,129,194,210,254,24,156,174,107,232,54,178,109,176,189,237,98,162,235,69,74,181,131,91,87,6,222,174,189,81,128,95,37,108,37,189,94,26,65,234,158,221,64,102,124,127,251,30,173,135,232,247,129,7,115,157,216,55,113,212,145,100,116,137,185,32,145,166,62,251,245,102,48,52,140,102,191,221,12,126,110,229,242,49,73,188,235,52,212,133,10,46,219,32,232,170,16,183,20,235,143,221,18,221,204,192,69,194,168,162,169,49,151,140,209,83,144,171,187,108,209,88,134,57,222,148,7,91,119,191,224,134,96,111,227,203,28,34,22,128,215,185,232,53,100,253,65,45,182,157,209,191,135,198,245,255,183,203,129,123,15,14,178,158,49,79,103,153,115,199,52,69,153,153,235,114,37,53,170,40,171,168,109,137,127,199,173,169,121,2,29,185,131,42,65,21,198,186,19,164,220,182,153,146,27,124,235,48,223,6,65,121,27,119,160,42,131,118,47,100,172,12,162,3,195,112,204,144,41,137,214,96,89,214,93,32,174,68,10,139,143,238,50,213,124,45,173,53,34,169,32,59,176,9,33,0,13,234,161,78,192,183,157,184,113,128,23,80,172,19,115,139,212,192,195,113,185,145,249,251,5,174,140,222,109,160,150,201,51,167,22,122,181,249,152,94,133,99,47,142,134,42,5,45,125,213,180,16,28,26,255,106,213,66,201,162,166,50,107,161,112,227,194,16,87,188,156,170,82,245,235,252,104,101,48,25,56,24,180,105,188,2,99,59,18,38,219,185,82,180,18,219,0,128,151,227,126,94,218,122,78,232,62,129,206,28,225,248,46,37,7,110,20,26,91,174,230,75,148,231,133,198,21,193,208,160,138,148,201,217,4,82,245,169,130,181,218,44,29,3,12,26,158,250,162,232,96,17,89,189,88,235,81,122,241,54,155,246,104,69,188,167,122,100,148,21,182,160,177,224,251,2,186,85,131,193,77,165,89,39,238,214,178,246,20,78,109,118,82,254,183,6,219,12,204,150,243,122,151,38,193,187,109,143,47,206,115,158,40,34,186,59,141,68,94,112,184,64,204,225,105,163,75,59,181,181,133,234,170,177,76,115,182,159,42,116,147,148,136,174,133,91,53,100,154,76,110,254,141,159,31,185,156,130,176,246,55,67,231,141,109,120,191,123,103,8,67,104,90,85,132,12,243,33,82,221,81,197,218,90,152,14,23,97,177,226,204,193,147,141,114,13,205,65,21,160,250,61,36,104,44,123,161,179,188,173,130,32,187,235,129,156,45,161,143,36,212,29,24,20,7,205,191,214,202,0,179,68,117,139,132,238,234,186,190,43,16,88,167,59,234,223,218,59,232,254,172,51,181,157,86,2,49,94,35,125,137,41,63,216,126,81,183,89,184,108,35,106,203,82,213,152,136,218,10,132,42,39,252,0,135,50,135,120,222,252,205,161,167,252,38,72,200,149,85,104,65,170,52,240,114,41,162,170,34,114,57,143,84,199,209,94,95,123,61,111,198,166,134,22,243,210,34,121,173,21,39,66,95,65,72,129,115,94,75,8,8,81,107,243,251,156,100,160,220,28,101,230,127,121,210,250,125,243,171,164,32,42,52,56,71,167,57,63,1,196,34,187,116,20,186,170,169,175,148,107,132,51,51,53,161,78,119,163,2,181,250,237,164,168,78,188,2,169,107,86,193,196,86,78,62,64,91,225,184,198,75,139,154,110,54,133,21,103,99,189,181,143,102,215,186,129,133,213,111,163,41,31,158,68,11,252,115,159,159,172,176,122,195,236,24,75,176,77,38,57,142,165,122,65,157,85,47,210,224,194,55,157,222,169,42,122,254,115,149,215,19,119,106,103,205,18,246,168,72,105,75,149,126,216,182,239,15,204,107,174,225,221,114,105,127,225,235,129,105,178,11,221,104,71,90,3,27,203,130,99,218,229,125,160,124,24,104,59,84,240,132,178,243,76,219,159,107,236,251,128,149,125,123,53,83,197,151,142,15,151,235,215,175,254,3,58,40,110,136,25,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c11f5401-c0a0-47d1-92f1-7788a37f4b29"));
		}

		#endregion

	}

	#endregion

}

