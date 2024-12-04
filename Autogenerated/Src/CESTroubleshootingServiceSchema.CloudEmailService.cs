﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESTroubleshootingServiceSchema

	/// <exclude/>
	public class CESTroubleshootingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESTroubleshootingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESTroubleshootingServiceSchema(CESTroubleshootingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a5ad7633-714c-451d-a42f-44c6ec7759b5");
			Name = "CESTroubleshootingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,24,219,110,211,72,244,57,72,252,195,224,74,200,93,165,238,106,31,161,41,202,13,8,218,94,84,135,237,67,133,144,99,159,54,94,28,143,153,25,167,68,171,254,251,158,185,217,30,199,73,41,176,15,203,3,141,207,156,251,125,38,143,86,192,139,40,6,50,7,198,34,78,111,69,48,166,249,109,122,87,178,72,164,52,127,254,236,159,231,207,122,37,79,243,59,18,110,184,128,213,235,214,55,226,103,25,196,18,153,7,239,32,7,150,198,91,56,231,32,182,96,33,176,117,26,195,25,77,32,219,123,24,12,145,251,90,169,179,31,239,26,22,53,66,211,32,6,93,112,68,15,222,11,81,4,195,5,23,44,210,38,236,66,28,211,213,170,41,223,101,31,76,70,221,71,134,8,207,14,24,220,161,0,50,206,34,206,95,145,241,52,156,51,90,46,50,224,75,74,5,210,25,83,20,242,241,241,241,9,47,87,171,136,109,78,245,39,185,100,116,157,38,192,9,215,120,100,5,98,73,19,78,110,41,35,176,138,210,140,8,151,97,96,40,79,142,27,172,110,140,24,140,178,178,249,147,132,13,121,129,17,66,109,11,244,242,34,205,82,177,185,130,175,101,202,96,5,185,224,126,243,67,186,154,12,200,35,36,18,43,48,128,228,80,10,41,80,181,52,38,177,52,127,183,245,228,21,25,69,28,42,95,244,48,253,240,255,202,123,232,133,2,152,72,1,93,120,201,100,86,104,135,245,10,253,65,62,162,123,208,182,92,103,100,235,51,140,110,81,247,211,54,210,155,55,100,88,20,53,32,208,201,229,98,233,40,246,14,32,79,180,46,174,98,103,58,26,59,180,90,211,52,33,195,82,44,209,55,105,140,16,255,144,200,194,234,245,100,2,202,88,192,55,65,150,141,223,3,210,56,25,198,49,112,78,25,214,151,152,229,92,68,121,140,28,100,198,245,122,13,174,168,199,21,240,50,19,36,234,2,14,20,126,111,84,96,78,102,105,14,227,140,150,201,52,191,195,159,129,163,91,67,15,21,67,224,162,223,225,73,163,192,58,194,252,203,35,140,101,114,70,243,84,80,38,139,96,64,252,5,165,217,97,171,78,156,230,34,253,28,130,144,225,151,173,67,252,21,101,37,248,219,130,250,90,113,111,170,164,76,101,174,207,242,68,234,74,89,45,210,51,250,164,183,196,127,225,119,121,32,8,75,229,72,242,242,229,182,198,135,54,34,61,177,100,244,158,228,112,79,176,240,223,70,72,56,253,22,67,33,249,156,96,163,64,220,211,110,246,103,200,59,186,131,190,10,93,40,34,81,242,177,172,131,183,148,45,210,36,129,220,104,248,32,255,127,112,51,36,4,217,68,201,152,1,126,133,200,72,218,174,96,254,187,18,147,135,107,208,44,177,106,74,183,115,77,52,80,202,26,236,142,56,105,179,100,163,46,87,185,239,141,35,101,139,215,134,143,32,143,151,216,39,190,108,157,96,3,46,163,108,76,203,92,108,157,73,59,161,130,190,101,116,229,123,110,136,170,195,235,37,48,64,10,107,74,117,48,227,211,175,40,192,215,60,131,203,136,225,92,18,192,252,218,234,67,18,113,99,162,118,34,3,81,178,220,184,224,117,135,71,85,205,205,217,70,187,180,230,25,162,74,144,96,35,137,33,41,25,16,238,126,247,17,160,50,184,176,20,231,248,167,79,232,226,111,233,235,10,170,146,213,6,67,230,156,123,66,94,96,84,202,44,171,178,170,37,38,184,78,197,178,86,170,37,172,37,101,79,218,180,140,49,249,227,66,125,21,15,21,40,83,206,228,54,205,144,59,239,147,61,201,213,98,109,178,172,197,186,163,90,137,39,120,241,89,107,226,102,2,183,53,186,223,25,94,165,143,215,111,232,166,73,59,34,186,21,65,79,205,67,69,110,12,13,180,34,79,98,130,125,150,137,137,204,238,154,77,104,97,79,210,38,79,90,108,166,26,114,232,166,178,75,216,149,211,19,204,118,252,227,116,9,13,219,211,37,18,77,164,227,103,176,119,119,137,255,182,130,181,120,199,108,173,94,151,181,127,166,92,156,184,154,156,18,156,19,46,72,98,237,206,240,166,35,24,238,186,184,226,89,87,116,177,183,83,85,119,87,163,58,226,75,239,226,22,123,47,255,90,156,71,26,9,82,117,87,99,85,123,237,212,54,51,160,234,234,93,195,160,77,99,50,162,138,113,87,106,180,105,244,154,234,79,70,211,111,16,151,168,29,73,22,213,207,65,199,164,199,124,229,168,249,100,84,131,253,122,94,182,139,89,179,2,191,102,106,228,90,193,58,22,81,2,82,154,182,214,18,93,41,112,147,180,18,211,187,95,166,25,16,95,83,226,98,18,97,36,234,83,189,135,84,105,48,195,5,206,196,217,13,177,141,30,254,115,177,3,51,23,145,202,136,192,84,211,249,172,186,112,53,251,235,1,90,113,50,195,97,97,39,168,30,1,150,209,77,99,180,126,170,104,228,204,104,17,224,204,152,140,206,113,106,4,206,116,233,208,181,98,216,29,175,201,104,190,41,228,142,191,198,101,25,45,153,140,20,195,57,157,229,162,37,180,54,226,161,101,77,84,79,253,182,61,205,133,192,181,104,139,232,251,109,210,76,173,168,167,90,213,22,220,97,87,75,158,250,245,120,180,205,130,83,177,179,93,36,24,38,137,239,178,172,144,140,72,243,71,23,231,238,186,120,104,182,67,203,190,217,16,191,227,210,65,5,58,10,18,219,64,205,39,89,167,76,186,69,47,67,151,12,112,177,64,7,50,254,94,217,204,245,53,228,0,3,247,226,124,58,15,231,195,243,201,240,106,242,199,231,223,149,70,184,254,94,224,109,75,173,184,246,94,34,175,95,14,96,64,58,208,130,113,201,24,238,199,218,62,68,208,242,234,167,2,66,75,113,71,209,193,87,198,92,163,16,178,107,75,8,46,90,168,129,193,181,171,132,218,214,210,60,166,43,133,164,218,255,5,75,241,94,211,197,109,230,34,90,102,55,158,38,177,233,188,67,63,21,116,76,127,121,141,56,82,119,104,154,29,13,179,140,222,31,25,250,126,183,42,50,212,7,144,113,248,53,183,190,71,172,238,184,193,237,50,212,69,173,83,91,163,255,132,173,216,112,111,159,148,195,234,129,64,31,170,103,139,198,171,133,2,188,143,242,4,31,12,200,197,229,124,118,113,30,98,165,152,73,143,83,171,158,255,246,125,68,190,126,108,63,127,244,110,156,84,181,47,32,189,27,204,209,89,190,166,95,192,215,10,161,19,61,35,8,205,252,200,210,57,172,138,76,55,12,189,29,153,190,160,200,205,227,134,170,50,187,160,168,243,11,53,41,76,157,213,113,139,164,23,235,148,55,33,233,19,21,136,92,28,201,62,215,39,210,245,5,94,189,171,27,251,81,152,222,229,120,173,100,224,189,254,159,151,237,79,212,151,247,155,237,198,79,103,98,178,77,114,185,188,8,231,63,206,200,96,32,163,102,44,127,113,149,255,92,109,214,126,250,33,62,59,92,245,67,188,246,121,171,213,39,246,150,126,179,228,213,232,197,231,80,89,102,59,138,93,65,212,93,154,228,120,31,25,120,102,245,246,78,237,45,97,65,147,77,112,114,172,112,158,220,31,148,91,246,53,7,44,93,228,31,138,13,238,173,170,224,204,11,81,5,13,174,89,84,20,144,232,23,46,163,20,62,23,173,34,225,16,104,80,240,129,83,108,18,214,235,251,241,156,198,180,247,38,165,116,125,252,6,213,181,61,108,61,65,86,169,107,182,153,238,219,154,229,188,103,199,209,80,23,248,240,47,44,197,64,139,175,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5ad7633-714c-451d-a42f-44c6ec7759b5"));
		}

		#endregion

	}

	#endregion

}

