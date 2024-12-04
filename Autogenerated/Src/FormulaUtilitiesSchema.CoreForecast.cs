﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormulaUtilitiesSchema

	/// <exclude/>
	public class FormulaUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormulaUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormulaUtilitiesSchema(FormulaUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c6ea8fb7-7e3c-40cb-979a-7382af0fc4c2");
			Name = "FormulaUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,27,107,111,27,55,242,179,2,228,63,208,186,162,144,16,157,236,20,247,201,15,25,62,63,82,221,37,113,17,251,82,224,130,28,176,214,82,246,158,87,187,234,62,108,171,174,254,251,205,144,67,46,201,229,174,86,110,131,107,63,52,90,114,56,28,206,155,195,113,18,44,120,190,12,102,156,93,243,44,11,242,116,94,140,79,211,100,30,221,150,89,80,68,105,50,190,72,51,62,11,242,226,243,15,175,95,61,191,126,213,43,243,40,185,101,87,171,188,224,139,3,231,27,150,198,49,159,225,186,124,252,142,39,60,139,102,53,152,179,160,8,106,131,239,226,244,38,136,163,95,197,158,181,217,247,81,242,75,53,248,145,63,22,176,1,146,250,143,220,132,54,143,176,88,52,205,100,124,124,17,204,138,52,139,120,14,16,0,243,151,140,223,194,182,236,60,41,23,251,12,14,188,40,227,96,10,27,95,175,150,92,64,236,238,238,178,195,188,92,44,130,108,53,161,111,130,99,17,0,178,2,32,199,10,112,215,128,92,150,55,113,52,99,28,80,215,49,247,144,161,189,143,229,226,134,103,236,136,237,141,240,19,120,88,46,18,248,124,43,62,47,151,60,11,146,16,190,127,16,223,23,101,34,24,12,3,127,131,239,181,60,1,79,66,121,8,235,64,167,113,144,231,214,137,58,157,166,237,32,51,68,105,98,100,251,108,122,254,75,9,66,189,137,249,161,49,49,145,231,67,154,221,13,197,192,59,94,228,44,205,88,142,255,22,119,92,243,176,190,183,28,121,8,226,146,235,207,235,250,138,10,224,11,42,198,79,89,10,188,43,86,131,62,194,245,135,95,113,134,142,225,136,130,137,255,61,179,91,94,28,32,65,7,108,189,13,229,179,96,41,108,101,43,226,235,139,26,233,39,80,251,8,121,145,161,106,159,202,185,151,19,47,118,221,142,116,119,73,35,225,98,194,75,246,103,156,233,76,244,52,9,163,89,80,240,156,61,222,113,32,58,147,108,47,179,140,39,5,75,111,254,11,78,135,69,57,227,160,136,49,43,82,22,36,169,0,163,169,116,46,22,228,224,237,54,170,217,50,200,130,5,75,0,244,168,47,144,244,39,39,137,66,4,168,103,233,2,64,56,123,140,138,59,192,10,187,202,185,241,225,174,88,90,97,202,120,81,102,73,174,7,24,28,140,115,22,7,201,237,99,154,133,71,253,34,3,238,176,221,9,139,230,155,14,132,211,146,180,140,207,45,234,96,125,181,129,128,224,5,207,14,152,152,125,140,114,62,114,183,157,7,113,46,246,53,216,96,210,74,146,186,73,211,152,161,105,199,249,192,52,120,129,120,200,132,239,234,1,229,131,75,121,254,79,124,206,129,252,25,167,53,2,110,196,146,50,142,135,67,38,55,96,98,239,131,77,75,145,173,35,218,72,47,69,110,201,149,52,32,116,104,108,238,54,22,67,67,246,253,247,194,162,237,57,28,25,10,4,164,106,116,206,244,1,162,67,20,114,22,1,235,193,60,126,12,242,187,211,52,228,3,117,70,218,78,96,180,231,255,67,52,88,163,106,139,109,124,179,64,35,3,111,163,139,182,226,50,170,244,156,124,182,176,178,92,124,6,69,103,231,109,109,41,35,145,215,246,164,165,46,33,11,136,242,102,39,71,59,32,11,127,82,160,182,121,99,4,59,216,142,43,255,42,162,56,42,32,78,55,242,4,92,205,3,136,46,103,160,244,119,105,152,155,108,1,101,191,7,87,211,153,33,198,110,146,29,138,40,242,103,48,179,143,191,11,208,88,30,122,188,149,244,173,104,169,115,21,164,65,52,81,24,64,178,49,110,246,172,194,165,250,87,84,142,117,169,246,101,42,1,248,172,0,61,35,71,19,201,73,153,232,172,80,63,15,107,80,19,161,170,226,160,182,48,244,193,63,72,166,226,169,163,7,112,191,100,54,242,67,250,7,80,123,109,188,3,149,43,82,10,67,130,144,95,35,230,204,162,19,77,232,67,89,218,67,144,169,85,232,106,114,208,25,32,221,112,62,249,192,66,42,109,77,25,168,185,82,140,247,198,63,131,225,243,129,72,209,128,39,34,185,49,29,131,147,6,140,9,235,144,86,159,36,43,123,173,229,113,204,3,140,167,225,248,58,189,18,177,109,48,28,218,110,134,248,53,197,252,18,146,57,55,79,170,29,209,97,212,204,98,17,157,85,14,162,96,37,212,21,47,10,216,59,87,152,233,27,100,44,137,102,199,199,44,225,143,102,226,243,101,239,171,143,204,16,172,119,1,65,7,81,7,241,12,128,65,235,76,159,49,160,16,78,236,54,101,23,22,32,49,220,6,147,252,107,60,41,185,67,49,155,241,188,140,17,34,228,243,0,126,13,104,43,2,41,178,21,161,18,208,66,247,17,88,164,243,203,178,224,74,246,35,74,34,198,231,139,101,177,162,213,61,141,29,124,26,120,244,2,228,113,38,241,15,4,42,130,91,67,226,85,204,238,216,224,44,66,207,241,247,213,191,121,150,158,63,205,184,72,163,212,97,52,212,37,160,154,199,233,99,51,132,158,97,252,73,77,246,138,187,44,125,20,156,208,211,131,239,250,231,89,6,198,25,150,138,125,66,202,218,95,205,136,219,232,100,149,156,246,217,51,77,175,199,253,17,238,64,167,48,117,65,158,220,39,75,146,84,165,96,131,70,37,52,141,103,196,166,103,145,112,22,224,174,14,37,18,197,116,176,132,4,99,54,15,133,50,228,30,211,5,25,152,2,170,20,32,34,155,54,247,2,49,189,143,242,66,233,137,69,31,121,172,105,50,79,129,64,250,66,4,152,83,72,120,64,197,6,2,55,94,160,14,224,159,67,185,13,40,77,153,32,90,22,189,121,163,229,98,230,49,148,109,137,223,71,114,209,151,72,154,68,175,151,67,122,135,210,53,128,100,2,161,48,245,64,118,156,249,29,200,190,6,234,41,150,188,17,158,108,106,178,110,96,51,114,100,18,68,137,12,17,211,235,221,100,60,184,87,95,235,54,10,228,109,114,191,13,132,174,148,251,30,26,107,36,248,41,240,162,85,226,50,79,111,200,172,250,13,174,8,53,82,125,15,76,117,168,142,44,20,170,186,236,234,229,227,139,40,3,125,153,163,83,158,143,175,138,32,3,182,134,252,105,154,168,59,236,17,72,211,198,35,189,101,117,149,86,200,20,43,20,210,106,21,89,206,61,95,1,56,34,54,194,103,201,255,201,87,150,102,136,193,145,189,141,43,194,109,52,1,182,173,22,70,184,68,83,252,169,140,43,86,127,8,158,222,243,228,182,184,59,127,90,2,130,31,121,16,66,234,223,170,52,228,123,181,240,125,158,74,205,17,23,176,6,4,153,229,160,175,24,140,87,40,246,188,183,102,112,203,98,121,185,92,166,25,16,15,254,201,181,150,122,76,84,132,88,14,140,88,211,238,193,108,142,181,57,168,80,79,169,49,193,80,82,203,106,118,124,157,173,0,177,68,8,16,112,227,40,11,166,99,143,157,92,16,43,166,249,71,240,61,151,153,240,108,20,88,216,49,235,239,245,161,16,34,62,125,167,80,169,18,84,159,192,233,23,151,25,136,169,155,43,54,221,171,207,125,30,59,254,19,47,85,4,39,221,36,251,237,55,114,136,211,92,18,13,55,42,50,208,250,157,108,109,35,81,78,20,145,189,117,151,73,143,185,247,85,72,26,33,252,174,72,19,208,6,42,253,166,73,131,233,169,33,149,117,220,180,69,220,95,217,91,114,219,72,184,2,110,220,75,25,207,70,54,152,30,72,165,162,218,105,9,18,134,14,247,55,70,35,164,245,133,17,201,4,76,248,147,3,197,222,104,38,188,52,118,81,228,168,188,55,114,83,237,180,65,114,32,100,237,52,54,46,169,9,192,43,3,195,103,109,17,254,106,1,248,91,29,66,43,247,159,227,220,158,224,107,166,79,90,143,241,67,111,94,143,170,214,109,199,19,91,213,221,39,210,238,92,114,120,167,118,187,28,211,47,200,218,141,173,135,38,195,192,151,2,203,206,99,190,0,45,61,153,67,213,74,97,249,152,22,39,49,100,221,60,148,118,54,178,232,31,118,103,160,21,59,113,237,239,141,159,158,232,165,235,82,62,167,223,233,140,232,66,236,16,64,167,110,20,161,46,191,65,189,37,169,54,16,194,146,132,58,199,246,229,73,111,186,112,70,158,95,156,37,50,207,2,228,95,150,197,229,28,105,255,4,165,69,188,170,185,148,212,114,241,42,186,180,162,242,58,199,154,207,115,119,83,238,239,69,22,191,181,189,191,192,218,107,117,76,111,46,164,21,217,45,31,180,100,60,16,153,174,121,78,41,18,38,20,242,120,50,157,220,62,209,152,241,56,174,221,211,168,148,34,188,195,6,182,170,250,201,25,8,52,2,46,12,212,192,21,199,231,65,137,4,83,78,81,34,56,133,221,52,143,36,2,44,164,162,156,41,177,166,57,89,200,80,15,99,134,135,203,197,204,135,96,169,170,15,117,78,133,41,84,252,160,214,166,29,199,179,54,46,168,23,228,69,144,20,249,248,170,92,140,216,219,245,168,13,230,228,1,176,189,93,59,94,193,206,21,171,251,54,73,192,190,92,11,246,122,75,68,194,204,78,239,248,236,254,52,72,116,245,197,21,160,81,28,154,176,32,142,229,79,116,23,109,245,183,218,245,250,93,25,133,19,93,117,224,33,161,49,21,65,215,84,42,157,149,195,84,241,163,37,50,55,250,228,140,14,76,210,124,101,59,172,128,4,152,168,120,112,66,149,161,182,141,182,36,180,112,103,82,104,36,20,225,170,194,30,113,2,228,6,193,205,220,93,66,14,89,101,152,136,175,198,7,124,7,47,130,8,206,225,110,5,139,141,8,52,3,176,40,169,110,202,74,53,52,239,204,208,68,147,70,100,233,88,201,113,68,139,222,83,233,135,80,79,28,109,213,19,75,0,121,103,109,128,82,80,13,40,93,68,69,5,65,229,152,234,65,104,224,206,19,192,235,87,240,64,165,255,35,254,213,113,129,253,138,120,40,246,82,49,195,119,93,84,114,18,153,203,101,118,70,69,69,121,9,7,15,35,55,216,105,17,44,21,81,81,25,224,197,104,199,166,197,7,214,165,174,107,113,189,242,4,202,40,218,160,103,182,158,91,165,94,229,128,245,241,84,9,88,170,51,57,227,77,74,111,210,191,185,234,47,30,73,90,158,101,113,135,188,246,12,149,165,208,15,129,231,147,142,174,235,91,43,161,233,79,204,86,132,28,79,73,45,37,245,7,86,115,185,216,171,63,17,17,133,2,152,120,161,149,84,109,88,43,94,193,250,19,25,96,102,86,255,75,227,171,110,21,100,204,141,64,127,121,8,175,52,120,19,212,133,93,242,104,34,140,122,159,90,219,67,187,29,75,54,69,243,186,105,235,40,59,145,140,25,121,158,0,233,212,142,49,235,90,136,178,204,102,66,149,165,106,60,244,195,126,119,48,118,252,93,21,95,204,123,141,59,54,29,221,95,243,117,30,149,170,188,102,172,210,114,200,72,212,117,70,230,9,250,241,97,79,93,169,101,25,73,74,114,26,138,10,29,77,85,57,12,50,215,185,130,27,251,110,81,62,86,161,69,86,31,213,166,118,66,230,148,103,113,111,132,21,22,231,120,68,235,82,87,37,88,242,78,144,255,12,202,75,94,69,123,56,201,54,201,2,68,121,92,61,34,237,189,164,34,252,162,122,240,159,165,20,108,240,223,83,224,253,134,18,144,156,175,37,185,199,86,221,178,166,18,170,138,105,21,159,91,234,216,30,4,154,150,173,106,208,126,197,112,235,205,78,186,68,9,17,102,96,228,169,85,216,69,218,176,108,107,152,140,119,41,45,59,9,67,89,195,149,205,73,186,240,220,191,232,195,69,87,58,163,177,110,77,24,177,83,32,170,204,184,184,249,78,19,208,140,8,210,123,26,28,250,178,14,185,143,25,64,253,173,74,112,197,23,157,74,182,247,207,49,161,133,214,128,8,222,255,248,18,34,47,228,147,43,232,195,130,122,67,215,0,73,136,160,29,9,125,13,97,237,26,30,35,73,214,69,210,159,16,133,149,56,205,133,20,144,30,210,40,84,71,217,62,129,25,177,19,129,185,54,175,169,80,66,173,50,189,122,234,217,152,12,26,14,221,186,128,56,132,170,108,74,46,114,31,213,221,228,25,80,248,147,106,39,113,246,92,152,42,170,164,104,65,145,174,238,163,229,114,243,73,30,239,34,8,54,131,58,49,59,118,28,22,246,81,191,23,106,118,215,16,248,200,52,238,59,74,12,199,168,250,233,61,96,114,17,104,211,175,167,207,104,105,53,120,204,142,43,147,223,142,11,202,146,27,214,109,220,240,15,148,165,186,250,55,144,98,250,133,54,39,240,73,166,120,162,23,72,162,210,89,252,182,198,46,90,69,105,109,171,133,155,237,40,114,153,28,81,247,132,141,237,137,85,243,54,118,81,53,146,237,73,95,31,162,172,192,62,197,13,55,161,51,129,114,43,63,210,177,103,72,223,181,181,130,57,24,91,93,135,125,193,170,53,11,109,85,85,240,149,54,172,13,49,14,216,20,88,70,110,245,83,57,13,84,214,233,205,178,34,30,94,88,137,175,202,226,43,50,214,235,12,27,213,88,23,65,190,189,38,67,82,4,125,131,166,38,203,145,23,106,114,27,229,30,101,222,160,196,181,42,87,23,61,150,130,112,148,217,60,166,217,78,187,99,78,188,64,3,157,103,205,138,60,217,142,211,100,26,235,174,29,120,22,221,149,89,81,210,232,125,163,126,97,27,222,65,135,50,8,133,128,106,115,209,181,23,232,153,94,96,119,237,233,98,142,217,155,32,65,229,63,195,141,102,113,198,115,14,233,98,28,253,202,169,221,147,238,147,91,89,132,212,108,59,75,220,86,181,69,99,247,12,20,252,72,245,102,32,11,204,150,240,46,42,94,149,16,140,147,169,134,177,46,205,136,174,134,16,208,70,70,234,76,70,178,49,135,55,184,104,30,201,234,73,85,2,218,178,128,36,72,176,153,171,42,47,109,249,177,213,129,35,151,171,177,198,26,82,77,56,58,157,168,253,137,132,71,10,170,209,178,177,206,255,173,154,243,140,118,64,27,177,179,216,125,211,104,104,7,181,174,235,109,226,86,47,194,255,31,105,187,194,154,138,63,176,16,237,214,30,3,110,250,123,8,253,170,189,213,163,26,186,117,219,171,58,249,125,91,39,206,142,219,56,100,237,208,169,139,165,176,30,7,165,120,165,34,180,60,27,122,218,242,58,234,145,111,187,246,38,223,142,218,69,71,114,59,111,55,242,160,225,165,190,173,168,109,244,227,139,154,48,84,107,186,106,166,126,51,12,57,84,179,21,34,129,98,67,25,90,21,134,250,19,237,110,125,139,148,114,94,120,136,244,170,46,149,47,189,245,31,213,205,109,80,173,219,230,42,138,28,143,255,93,255,217,92,176,222,127,174,64,215,253,141,60,22,127,40,81,21,0,197,147,65,205,31,188,204,19,88,175,7,205,172,195,75,130,248,99,17,77,132,172,216,206,168,250,132,105,122,157,162,205,209,212,42,96,91,85,205,63,164,221,207,233,55,107,184,251,152,68,116,110,77,123,97,91,90,132,111,167,78,163,89,183,118,8,85,213,21,205,45,146,124,147,114,55,54,233,242,130,121,223,161,229,91,92,117,240,135,243,242,229,251,139,36,24,251,31,163,194,147,156,28,61,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c6ea8fb7-7e3c-40cb-979a-7382af0fc4c2"));
		}

		#endregion

	}

	#endregion

}

