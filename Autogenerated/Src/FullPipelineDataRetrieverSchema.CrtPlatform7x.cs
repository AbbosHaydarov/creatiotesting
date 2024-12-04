﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FullPipelineDataRetrieverSchema

	/// <exclude/>
	public class FullPipelineDataRetrieverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FullPipelineDataRetrieverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FullPipelineDataRetrieverSchema(FullPipelineDataRetrieverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f1f6cded-634c-48b9-bf5e-fe3e8bc24a80");
			Name = "FullPipelineDataRetriever";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,88,89,111,219,70,16,126,86,128,252,135,133,250,66,1,6,245,30,91,2,98,249,128,208,212,113,108,183,47,69,17,172,201,145,180,40,185,100,246,176,43,20,249,239,157,61,120,115,165,40,238,75,20,46,231,248,102,246,155,131,230,52,7,89,210,4,200,19,8,65,101,177,81,241,170,224,27,182,213,130,42,86,240,247,239,254,125,255,110,162,37,227,91,242,184,151,10,242,243,222,51,202,103,25,36,70,88,198,183,192,65,176,100,32,115,69,21,29,28,126,98,252,91,115,184,42,242,188,224,237,103,1,221,167,248,234,178,119,112,67,19,85,8,6,18,207,241,205,47,2,182,8,131,172,50,42,229,7,114,163,179,236,158,149,144,49,14,95,52,136,61,70,38,149,180,162,243,249,156,92,72,157,231,84,236,151,254,249,94,20,47,44,5,73,18,35,71,185,146,100,83,8,178,65,51,164,244,118,200,55,52,132,14,227,202,198,188,101,164,212,207,25,75,8,234,42,252,73,12,138,48,136,9,38,22,255,29,32,177,7,79,59,48,102,182,64,16,16,87,108,195,64,32,172,76,231,156,112,188,51,227,126,232,191,7,64,0,77,11,158,237,241,89,216,180,27,131,235,116,101,205,220,161,21,178,32,83,127,56,61,63,130,38,209,66,32,18,194,184,7,150,20,26,31,223,138,105,229,204,174,185,197,177,50,54,187,248,188,64,243,250,40,210,226,5,4,197,43,251,63,97,126,118,54,67,32,253,235,26,223,228,187,227,35,240,212,81,242,24,61,31,138,215,227,180,44,69,81,130,80,200,190,17,94,138,226,245,16,39,135,100,180,46,13,9,3,169,188,5,228,63,186,145,230,87,141,240,49,144,72,123,242,66,51,13,7,217,220,210,110,132,61,216,91,205,210,138,173,196,34,156,108,65,157,27,40,38,185,62,187,63,8,219,17,160,162,237,105,160,131,186,3,200,41,36,44,167,25,182,37,93,179,57,0,253,71,129,87,60,182,32,78,195,29,82,13,194,110,19,248,237,25,167,89,162,51,170,32,109,81,246,196,196,31,49,49,8,228,138,217,9,132,102,47,92,201,158,85,177,45,201,170,54,118,223,84,208,207,4,105,130,227,58,127,62,149,251,3,157,1,124,134,105,191,179,82,45,96,246,63,248,6,4,199,43,106,51,232,212,246,98,198,239,3,96,94,0,239,249,120,163,201,65,237,138,20,47,117,131,141,208,106,161,255,110,187,73,209,226,104,191,113,134,1,104,38,11,146,8,216,44,166,129,213,34,94,7,33,78,201,220,216,250,243,10,54,84,103,234,146,241,20,175,52,82,251,18,138,77,20,214,155,205,254,58,212,242,58,178,228,3,9,27,106,198,115,149,213,27,6,89,138,105,189,23,236,5,169,228,94,150,238,161,25,23,191,75,16,24,36,119,251,16,249,170,59,207,231,1,173,245,96,73,184,212,44,75,17,227,215,103,247,31,175,217,187,241,230,202,205,78,33,180,89,134,12,68,27,191,247,229,114,17,12,52,234,33,238,2,62,179,20,156,132,241,121,120,51,207,218,174,118,188,218,65,242,247,71,177,213,57,118,253,59,180,17,153,1,140,55,216,149,155,205,28,213,189,177,176,90,229,205,203,247,178,139,131,120,144,110,35,229,181,240,117,147,204,186,216,67,25,253,205,149,64,224,190,123,115,212,116,135,222,81,180,118,105,166,198,179,185,104,16,103,29,181,107,156,131,106,239,10,194,44,156,248,83,101,241,133,138,186,208,140,245,5,225,240,58,240,233,100,39,213,152,92,120,47,184,130,251,229,228,15,211,100,46,204,44,93,70,245,154,55,243,87,218,153,83,33,221,170,131,70,129,37,54,62,184,189,85,174,58,179,229,167,93,29,216,192,102,214,207,247,243,58,121,102,122,180,90,253,194,220,207,216,16,136,170,139,241,249,119,22,90,169,143,71,71,199,162,231,192,169,97,167,212,130,183,47,174,205,179,138,57,135,230,84,8,229,27,168,196,54,36,114,39,173,80,62,163,97,219,129,101,188,150,215,121,169,246,209,172,82,168,194,224,104,223,197,101,55,150,234,248,128,45,167,30,63,21,77,136,81,81,189,37,139,37,169,31,226,90,233,140,56,173,73,71,240,8,67,70,236,248,142,208,203,245,250,26,7,47,74,60,103,112,209,171,158,37,185,254,7,18,173,28,197,162,71,48,95,176,246,219,110,127,82,153,10,144,56,159,124,133,126,98,82,13,28,69,158,85,238,171,53,50,74,233,179,115,142,59,211,162,63,34,226,107,46,181,128,171,203,230,40,178,24,127,197,25,136,95,204,57,195,164,55,183,213,178,234,178,134,22,109,20,177,143,207,209,38,106,92,54,186,147,215,29,203,128,248,34,136,141,100,139,7,99,109,104,164,205,141,86,144,229,139,73,76,252,49,77,163,150,141,250,189,35,149,255,233,48,204,41,158,214,162,91,243,110,116,121,171,166,93,189,181,132,86,183,146,10,154,219,175,196,197,180,28,97,128,156,46,205,62,87,111,65,230,99,70,237,125,240,126,173,145,241,197,220,218,105,204,186,208,100,125,208,252,197,196,172,88,102,91,242,155,82,47,187,126,13,242,104,219,86,252,88,63,200,240,246,156,143,66,146,237,232,150,100,52,230,138,18,163,47,195,195,122,220,150,103,192,105,181,131,95,187,64,147,157,227,185,75,182,249,40,59,136,214,186,176,165,96,138,172,90,45,236,222,242,197,214,252,168,118,69,228,248,49,217,65,78,237,116,241,156,53,173,212,219,67,200,136,180,41,21,212,81,140,107,251,231,170,134,220,53,128,135,42,208,78,207,241,205,166,91,56,77,217,60,80,190,5,39,228,244,189,200,105,197,50,246,161,128,103,255,1,144,207,235,99,247,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f1f6cded-634c-48b9-bf5e-fe3e8bc24a80"));
		}

		#endregion

	}

	#endregion

}

