﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookHandlerSchema

	/// <exclude/>
	public class WebHookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookHandlerSchema(WebHookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40006aab-bf10-4248-abcc-b15221fc05db");
			Name = "WebHookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,89,91,111,219,54,20,126,118,129,253,7,214,3,6,25,13,148,236,117,137,61,56,113,186,185,75,155,32,113,214,135,32,24,104,137,78,180,202,164,75,82,73,188,181,255,125,135,55,145,162,228,203,46,88,30,28,139,58,60,60,215,239,156,67,83,188,36,98,133,51,130,102,132,115,44,216,66,166,103,140,46,138,135,138,99,89,48,250,205,171,63,191,121,213,171,68,65,31,208,205,90,72,178,60,142,158,129,190,44,73,166,136,69,250,19,161,132,23,89,139,102,122,217,90,186,40,232,103,191,120,198,56,105,62,165,147,83,191,240,129,60,75,224,175,196,123,39,24,117,155,225,253,183,156,60,192,209,232,172,196,66,252,128,62,146,249,207,140,125,250,25,211,188,36,92,83,28,30,30,162,19,81,45,151,152,175,71,246,249,138,179,167,34,39,2,45,137,124,100,185,64,146,161,21,103,25,17,2,61,147,57,122,4,30,2,45,56,91,162,179,243,155,212,113,57,12,216,172,170,121,89,100,40,83,231,182,142,237,129,213,224,211,75,7,194,75,76,37,72,120,197,139,39,44,137,121,191,50,15,40,83,239,81,65,165,227,116,138,101,246,248,190,160,55,197,31,4,13,209,247,199,123,209,227,23,71,127,116,116,20,109,225,4,231,140,150,107,116,43,8,7,121,168,241,25,250,173,106,60,111,60,8,152,79,37,49,81,33,206,88,5,75,234,28,75,255,45,161,185,209,53,86,92,72,94,101,146,113,165,186,54,153,33,136,189,162,23,166,180,144,5,46,65,7,129,242,66,203,3,175,17,91,32,92,150,232,209,88,23,252,194,120,237,37,36,215,43,34,148,135,218,46,114,62,106,122,39,137,12,208,212,127,128,84,192,247,122,145,89,64,215,150,157,122,189,175,219,149,135,40,91,17,46,11,178,201,237,19,248,152,21,75,242,35,154,176,15,76,94,97,46,8,8,171,163,239,173,10,62,35,203,3,145,246,91,143,19,89,113,138,146,122,231,32,76,92,200,154,70,246,166,144,107,55,68,74,72,33,149,155,242,87,92,86,36,49,156,98,13,15,80,255,70,178,149,49,146,181,216,149,73,137,177,236,15,180,190,74,225,90,235,125,148,152,177,255,93,5,204,229,254,58,108,242,220,123,3,11,27,220,118,67,20,224,33,144,38,204,62,179,154,184,0,122,194,58,72,253,107,147,153,9,228,210,0,253,125,141,99,85,141,5,250,239,65,85,94,148,101,83,89,216,122,133,179,79,248,129,232,68,117,154,23,11,148,180,68,58,233,130,28,167,68,175,67,131,14,242,192,176,221,135,140,186,112,106,239,67,12,121,120,136,53,174,138,49,235,140,33,162,228,217,122,38,54,214,64,239,73,103,108,213,146,204,190,130,26,86,45,105,210,191,198,207,246,100,209,135,104,82,181,6,194,20,247,183,147,77,115,71,160,146,54,49,113,161,100,155,230,194,74,4,113,41,11,33,139,236,252,137,80,57,3,204,74,207,151,184,40,235,117,97,57,220,82,16,120,95,22,183,84,84,115,145,241,98,78,6,59,247,211,170,44,7,3,132,133,181,210,32,29,139,164,95,57,209,47,200,66,94,86,128,240,239,88,17,169,56,72,47,97,165,234,31,104,77,211,169,56,255,92,225,178,211,12,158,189,113,151,77,246,134,175,66,232,236,76,169,93,122,255,168,65,63,76,180,207,21,129,58,177,59,6,188,11,107,159,89,167,53,21,182,111,62,62,18,78,146,254,91,112,20,9,53,55,76,82,128,58,232,159,192,100,201,2,151,2,92,224,211,76,9,136,94,131,64,202,232,46,206,157,148,250,127,58,166,121,210,87,234,108,99,172,225,66,107,27,162,151,51,171,97,216,52,121,100,216,39,86,228,104,2,175,165,3,68,145,76,207,105,181,132,82,62,47,201,201,79,85,145,143,80,145,95,128,137,157,160,202,138,102,203,38,43,238,52,89,96,222,41,109,169,37,18,123,224,32,61,127,33,25,68,93,50,216,40,60,96,161,59,197,56,34,81,91,55,10,126,187,202,97,107,11,47,81,167,180,192,187,118,239,1,178,98,234,102,45,129,182,197,37,85,67,171,127,163,79,219,240,22,176,107,215,76,234,174,71,19,28,52,182,156,98,93,89,21,229,104,228,138,139,8,243,0,154,209,218,88,30,69,111,101,81,66,99,5,109,18,228,215,69,64,226,224,80,216,224,82,44,22,69,9,26,145,220,149,240,46,54,111,53,77,128,62,150,162,109,245,80,160,240,16,109,114,119,132,70,99,155,189,222,183,214,132,118,2,72,38,167,198,180,208,251,229,243,250,235,48,238,95,211,115,144,138,147,201,169,95,74,6,117,6,66,231,72,48,156,149,4,213,25,186,219,150,210,245,6,45,45,39,162,42,85,137,177,59,82,93,146,211,25,95,55,58,141,196,203,117,16,139,101,117,49,224,240,218,48,244,135,244,58,236,145,142,243,252,26,211,7,226,156,148,254,66,214,53,27,3,3,246,159,175,137,118,134,209,172,180,205,167,57,136,29,107,151,26,184,128,222,97,157,188,160,225,8,189,104,222,141,88,215,235,175,187,228,2,165,36,46,168,72,94,6,29,97,163,131,34,136,157,48,0,32,57,50,178,146,73,203,218,27,4,50,220,187,117,234,88,85,146,101,216,179,111,136,18,96,115,215,214,49,156,236,195,36,194,203,174,13,19,85,146,168,234,247,186,128,185,195,110,93,120,160,230,42,72,201,15,213,114,78,248,229,194,246,108,226,45,227,227,76,66,61,40,254,128,208,31,87,121,65,104,6,144,98,197,115,13,180,42,13,255,89,35,185,159,12,151,139,211,170,252,164,59,23,219,84,126,221,50,206,233,81,0,102,235,71,82,143,107,27,6,53,189,178,82,112,138,40,64,234,176,15,24,142,251,163,89,176,19,169,165,244,228,80,83,249,77,198,24,162,65,10,84,110,57,180,246,187,49,216,106,109,164,114,41,59,95,75,114,119,175,121,71,141,187,62,211,96,146,217,152,4,33,164,232,209,48,42,239,205,94,39,110,87,97,14,38,160,158,225,248,158,44,25,95,223,232,37,205,204,242,150,80,206,45,55,160,87,184,247,59,180,160,55,230,235,16,102,112,64,96,250,224,129,120,66,50,182,92,1,156,192,164,101,168,18,115,142,3,10,175,136,81,66,213,44,65,18,207,213,69,47,130,204,81,192,104,82,84,205,64,141,254,220,89,3,244,181,156,91,178,88,147,94,176,135,244,156,115,198,33,130,150,144,141,253,187,230,248,29,208,221,67,205,37,93,233,19,154,112,91,128,93,27,47,131,73,95,36,154,107,5,224,174,192,95,224,248,91,157,125,227,206,21,196,254,72,21,162,144,155,225,15,122,182,66,48,220,15,223,1,39,160,121,245,12,68,149,41,9,22,85,137,204,91,104,90,236,221,210,94,44,13,150,52,88,82,38,247,231,229,82,193,100,184,218,174,174,130,224,35,99,60,23,27,114,197,34,83,208,51,37,172,146,168,213,158,152,168,242,205,200,1,82,100,65,131,86,75,223,145,94,245,232,182,97,146,54,145,225,88,219,212,217,36,130,35,175,15,220,216,80,40,9,50,53,23,131,53,134,232,168,209,101,168,119,255,188,189,8,153,168,205,13,61,93,107,120,13,214,135,206,222,159,226,247,247,158,31,65,120,128,23,158,42,170,128,179,145,26,186,225,182,68,147,83,53,68,192,194,19,220,53,65,126,77,78,53,208,207,152,82,26,88,221,169,182,245,190,238,28,52,35,131,95,32,228,157,159,113,239,213,32,97,240,176,166,181,144,233,1,160,1,158,1,112,249,193,95,19,198,147,79,224,198,187,34,191,247,166,169,119,127,69,4,70,168,128,190,246,163,106,132,160,191,246,7,217,222,167,215,179,78,124,243,102,75,87,100,17,197,146,118,21,225,57,99,37,154,10,3,79,87,112,125,205,192,240,86,16,165,211,134,171,57,139,254,232,203,23,219,51,116,93,126,237,38,114,188,186,182,199,149,69,141,36,113,89,161,236,185,35,38,206,42,206,97,88,86,55,157,170,242,219,71,119,227,22,38,130,198,14,144,146,61,167,234,53,122,179,225,42,210,245,188,176,253,114,49,193,107,207,1,64,118,199,254,25,235,222,173,172,171,207,31,1,147,90,89,181,170,180,2,236,80,239,190,124,209,58,158,132,36,190,205,130,152,57,110,56,221,132,81,196,227,187,239,218,60,218,44,26,1,83,219,122,239,155,194,93,151,219,118,212,131,134,72,93,102,71,191,50,8,192,1,104,187,182,223,99,235,113,56,158,24,195,80,125,29,135,113,164,109,227,158,14,16,30,219,14,143,184,254,206,117,127,182,86,12,255,78,119,122,92,179,93,89,202,179,24,100,131,246,70,209,81,203,89,97,157,227,110,189,217,85,65,236,171,157,53,104,207,66,161,69,200,76,102,212,191,108,120,89,29,22,39,93,82,26,203,196,213,177,89,4,125,229,27,64,28,30,57,208,130,88,108,29,122,210,241,235,138,15,246,216,156,111,134,219,44,23,94,60,235,126,161,30,91,5,220,128,122,163,4,131,150,157,1,122,61,187,100,146,117,44,222,249,187,135,196,78,135,240,103,135,181,228,247,25,251,68,192,96,245,221,110,216,150,2,240,152,31,114,92,173,48,212,105,221,166,14,224,47,156,137,3,137,235,97,12,133,37,171,54,167,187,45,136,19,33,224,224,107,69,163,138,152,113,186,201,104,112,236,78,113,101,69,143,136,145,201,71,195,93,185,18,148,186,141,225,15,127,45,83,185,84,34,182,159,190,38,89,177,2,254,82,180,238,222,162,42,103,224,179,238,118,108,201,85,88,23,40,221,24,107,123,189,246,93,154,143,210,152,125,28,165,117,153,181,4,157,118,66,71,254,180,255,64,87,7,234,91,134,147,127,60,135,68,241,211,26,70,186,129,223,172,54,23,191,254,5,46,73,180,60,71,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40006aab-bf10-4248-abcc-b15221fc05db"));
		}

		#endregion

	}

	#endregion

}

