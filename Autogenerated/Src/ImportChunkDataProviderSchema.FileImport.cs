﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportChunkDataProviderSchema

	/// <exclude/>
	public class ImportChunkDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportChunkDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportChunkDataProviderSchema(ImportChunkDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9ff971c-8134-4075-beb4-e73a602bfc8d");
			Name = "ImportChunkDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,89,221,111,219,54,16,127,118,129,253,15,68,250,34,99,134,210,110,123,216,150,196,64,154,143,194,67,155,100,181,219,62,12,123,144,37,38,225,42,75,46,73,37,245,134,252,239,59,242,72,137,162,40,217,70,243,146,68,228,125,241,238,119,199,59,166,72,86,84,172,147,148,146,5,229,60,17,229,173,140,207,202,226,150,221,85,60,145,172,44,226,75,150,211,217,106,93,114,249,195,139,255,126,120,49,170,4,43,238,200,124,35,36,93,29,121,223,192,154,231,52,85,124,34,126,75,11,202,89,218,161,121,199,138,175,157,197,5,253,38,155,197,43,250,40,65,132,50,230,15,81,22,205,134,107,228,106,213,183,195,105,223,122,124,254,166,119,235,162,144,76,50,42,128,0,72,94,114,122,7,199,32,103,121,34,196,239,4,61,112,158,200,228,134,151,15,44,163,92,83,29,30,30,146,99,86,220,195,65,101,86,166,228,112,10,139,235,106,153,179,148,36,75,33,121,146,74,146,42,17,70,194,217,125,85,124,113,197,28,47,166,4,196,247,237,54,122,245,30,80,43,13,42,14,181,133,151,140,230,25,152,8,60,18,124,79,51,109,25,154,38,170,213,42,225,155,169,93,152,167,247,116,149,144,2,162,78,110,75,110,140,154,83,33,64,146,214,16,215,188,135,46,243,218,10,39,41,4,70,18,56,154,114,97,151,31,53,92,41,5,39,228,160,187,127,112,52,96,222,135,242,81,128,130,170,144,100,157,112,169,77,100,133,160,92,130,178,173,150,49,96,115,226,4,2,230,236,95,101,198,207,191,252,102,180,54,196,156,38,89,89,228,27,242,17,196,3,226,11,132,173,247,105,216,94,210,34,67,111,155,111,11,14,229,11,94,165,178,228,42,0,58,238,70,17,98,160,39,172,145,167,180,106,125,142,137,142,239,200,35,58,241,200,20,144,71,79,195,6,190,167,242,190,68,112,176,135,68,82,235,5,253,65,102,23,69,181,162,60,89,230,244,184,245,119,23,116,83,242,150,202,182,115,69,180,133,135,176,122,205,30,137,83,89,241,194,217,136,231,235,156,201,107,196,6,72,236,132,111,236,30,211,26,190,220,72,250,215,223,202,164,57,100,94,146,3,93,180,32,169,117,179,167,237,162,72,203,76,1,232,227,226,242,87,40,75,242,13,176,139,72,85,22,240,230,3,160,43,174,197,92,47,255,1,239,70,141,168,160,254,133,82,125,78,69,173,220,24,212,103,129,171,202,97,67,101,224,170,168,99,226,92,231,87,200,142,209,200,181,228,161,100,25,57,205,178,79,73,94,81,177,40,103,58,91,254,172,40,223,68,248,183,73,160,9,233,70,200,137,131,94,178,86,35,7,56,69,70,7,179,236,96,2,56,207,171,85,17,67,76,32,175,37,224,215,99,140,245,207,89,102,172,108,9,56,131,76,131,132,187,46,66,114,64,2,93,176,21,141,175,202,199,16,243,98,179,166,33,190,8,114,125,236,27,161,136,67,66,230,18,180,236,44,69,83,135,196,40,146,144,148,22,10,125,105,24,187,128,52,140,70,45,69,236,230,231,86,61,173,253,237,161,83,192,9,160,246,104,104,220,112,10,149,148,222,36,119,84,165,233,245,90,223,205,145,190,235,54,88,171,53,88,204,6,148,221,59,75,52,33,72,69,224,250,146,248,231,68,31,195,212,126,80,167,138,48,218,172,10,190,133,143,13,170,195,88,131,0,170,88,179,170,128,174,130,150,161,12,141,225,99,203,61,117,161,99,28,248,182,130,35,53,252,179,172,45,238,198,181,72,75,67,54,231,80,177,245,4,164,99,6,215,125,137,116,34,62,203,105,194,163,241,238,12,144,116,109,112,7,78,187,167,184,142,71,93,161,16,237,80,176,3,89,109,42,205,162,212,43,38,214,132,234,95,54,70,170,114,199,11,190,1,168,9,91,188,53,185,138,199,52,162,117,124,28,103,154,116,28,199,139,210,148,167,241,132,192,245,7,102,150,149,36,15,9,39,82,165,224,209,176,6,157,96,189,42,48,89,135,116,40,120,91,37,11,146,193,201,1,5,94,61,110,132,131,20,154,172,140,112,157,194,74,246,41,116,126,155,200,230,165,169,210,5,125,12,184,51,178,46,27,121,201,7,90,105,63,140,21,84,167,193,52,31,99,22,141,76,205,108,196,116,225,107,40,149,112,32,83,206,53,43,218,75,176,164,125,97,214,148,209,176,164,28,162,23,158,250,26,4,188,65,2,45,194,246,254,81,91,130,69,9,47,187,158,166,76,175,160,91,197,180,203,116,124,104,247,218,77,89,221,50,123,128,108,154,143,122,73,167,106,155,219,222,133,209,238,55,157,194,19,86,101,240,156,142,191,254,240,250,179,113,60,43,100,25,13,53,187,6,73,61,55,177,189,130,125,43,90,215,194,197,55,154,86,18,15,182,71,99,231,52,157,110,93,232,84,120,229,67,173,21,77,210,165,148,121,215,137,227,21,42,190,26,151,116,36,121,222,137,93,130,247,73,1,5,142,219,110,99,208,89,160,194,98,94,203,53,183,223,76,124,98,130,65,137,84,144,135,204,63,170,109,74,109,93,69,74,149,57,32,2,124,142,223,129,11,195,227,136,175,57,116,223,111,54,167,34,141,94,15,91,225,80,254,228,80,58,202,176,24,6,183,76,17,11,238,97,13,10,110,249,197,194,37,131,49,92,45,197,239,202,59,150,38,249,245,26,250,110,51,22,248,75,170,112,166,50,62,45,178,46,187,74,15,245,141,158,194,213,207,76,222,55,74,35,92,132,249,26,26,7,6,141,171,58,103,124,241,181,74,242,9,233,154,104,138,143,143,164,241,243,171,198,94,16,213,233,206,45,84,20,172,98,183,174,131,210,118,243,28,156,218,235,145,109,203,80,3,90,119,76,158,118,194,249,228,54,247,213,168,123,71,205,164,250,218,222,157,219,219,179,190,236,180,219,230,210,178,253,198,57,227,245,28,105,215,230,84,61,214,212,59,16,41,46,164,241,176,165,129,145,252,76,15,228,39,181,157,30,133,215,201,24,187,206,1,130,176,6,89,117,140,253,34,92,224,122,220,129,11,213,185,158,204,81,155,119,35,115,25,58,11,152,229,224,76,159,212,171,67,19,215,59,214,189,183,196,244,2,13,91,108,206,115,66,94,213,87,251,70,189,161,144,37,32,243,11,50,106,172,152,101,3,35,175,173,234,136,125,7,173,90,172,125,96,175,166,96,227,183,75,32,174,204,107,216,190,173,171,102,89,150,101,174,158,10,174,111,111,5,149,151,84,166,144,98,119,170,99,7,72,230,229,50,201,79,215,107,152,65,212,155,138,136,63,6,8,219,208,196,237,186,77,241,29,121,52,56,19,152,232,5,10,172,218,69,222,172,180,97,80,225,10,89,94,199,169,229,15,245,90,84,27,215,88,138,66,177,246,124,128,158,16,114,78,25,140,89,104,112,49,122,34,52,23,180,22,219,51,38,181,166,161,129,128,79,2,195,144,85,132,191,158,21,213,59,195,186,139,107,107,207,119,32,187,14,3,186,254,199,97,96,60,145,199,123,120,65,30,178,215,214,149,86,227,51,88,163,21,52,117,163,183,243,3,84,79,215,167,32,100,203,219,171,166,209,96,173,103,40,44,229,254,227,87,79,47,215,162,138,79,133,186,221,224,200,121,52,142,47,75,126,145,164,247,145,123,99,214,242,80,209,180,142,220,115,119,166,163,17,60,166,82,165,190,125,64,80,66,2,166,52,16,178,237,41,22,155,58,129,246,232,117,107,22,131,189,145,239,123,128,80,176,7,182,28,237,49,205,227,222,25,52,186,46,126,92,195,124,68,135,39,4,23,38,149,166,55,33,48,204,126,130,14,122,31,207,177,223,67,148,125,131,114,121,247,124,125,178,15,79,70,196,103,112,9,13,79,163,208,111,235,14,43,26,120,124,234,190,59,25,185,208,99,234,39,194,221,164,212,175,132,46,183,121,83,232,229,247,125,131,175,124,36,17,38,28,45,108,96,184,26,24,145,169,73,107,251,106,226,253,107,70,143,140,216,144,214,96,176,175,208,141,155,12,54,154,5,123,215,110,199,155,42,28,2,197,94,124,99,2,234,198,182,222,145,121,163,239,73,223,240,107,232,133,190,221,12,66,241,170,243,139,132,113,247,162,92,195,212,99,62,204,204,97,220,173,255,145,17,169,105,107,60,134,162,5,147,148,82,133,22,31,88,150,75,94,174,134,75,205,118,180,25,138,45,104,233,1,218,30,80,169,93,133,80,65,191,180,160,130,126,179,80,153,195,0,149,240,99,21,51,104,80,119,174,41,26,63,231,32,9,192,246,220,129,205,180,88,219,78,163,142,112,96,47,159,45,48,251,71,230,187,66,99,250,63,125,182,237,239,31,102,173,253,36,242,244,63,191,227,185,19,194,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9ff971c-8134-4075-beb4-e73a602bfc8d"));
		}

		#endregion

	}

	#endregion

}

