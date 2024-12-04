﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileUploadInfoSchema

	/// <exclude/>
	public class FileUploadInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileUploadInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileUploadInfoSchema(FileUploadInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ffa4eee2-4d47-4707-930e-a0662be64d90");
			Name = "FileUploadInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,88,89,115,19,71,16,126,22,85,252,135,65,188,72,41,121,109,136,3,193,23,49,150,13,74,97,155,88,194,121,32,142,107,188,219,146,38,236,197,204,172,177,146,226,191,167,231,216,251,176,76,30,242,2,214,244,245,77,127,221,61,51,27,210,0,68,76,93,32,51,224,156,138,104,46,157,163,40,156,179,69,194,169,100,81,232,156,48,31,62,198,126,68,189,199,143,254,121,252,168,151,8,22,46,200,116,37,36,4,187,149,223,104,234,251,224,42,59,225,188,133,16,56,115,59,117,166,49,184,140,250,236,111,240,106,122,147,243,218,210,123,22,126,169,45,158,129,116,222,73,25,59,239,128,122,192,69,77,97,6,119,210,185,128,69,226,83,126,124,23,115,16,66,5,207,245,206,224,171,196,5,181,247,95,69,20,230,130,98,78,130,160,89,242,59,220,28,198,49,74,30,63,122,202,230,228,236,120,54,157,29,158,141,15,47,198,207,175,183,200,230,38,153,157,143,207,201,209,197,233,198,246,139,237,87,47,115,15,83,178,95,118,99,118,113,120,35,36,167,38,63,232,245,41,248,2,50,163,83,101,100,183,133,22,90,30,122,108,142,10,79,57,44,208,134,28,249,84,136,29,146,211,54,9,231,145,66,215,139,147,27,159,185,196,85,10,21,57,217,33,147,170,69,15,217,198,127,115,199,8,72,210,80,162,243,15,156,221,82,9,70,30,155,31,196,85,114,130,224,21,80,84,150,16,202,11,26,46,192,240,114,134,149,134,224,251,86,178,161,69,253,221,86,15,13,166,153,137,134,133,27,55,200,202,48,79,24,248,94,17,227,154,172,100,40,102,83,77,196,5,124,73,0,225,92,115,243,199,110,69,199,202,199,84,210,188,162,201,53,46,242,213,84,111,161,192,94,102,120,90,114,254,134,10,104,14,160,182,124,73,253,4,186,124,91,230,51,35,142,217,138,66,127,69,80,7,104,64,174,231,72,169,205,247,110,163,226,228,2,68,148,112,23,166,50,226,116,129,96,132,249,195,38,121,19,51,181,39,146,32,160,124,117,144,46,216,86,34,144,245,18,153,71,156,200,37,144,57,227,152,50,119,153,132,159,157,204,126,179,232,32,133,128,78,224,78,33,68,131,35,165,111,22,246,73,8,95,141,112,240,75,255,207,63,198,63,108,245,135,247,48,174,11,147,39,46,34,87,188,235,42,127,0,237,166,43,202,213,63,176,25,44,36,112,84,45,12,75,219,168,158,68,155,195,33,81,243,178,215,75,9,198,205,21,169,238,21,233,65,89,149,172,94,202,5,202,114,86,122,189,111,197,178,90,27,124,67,225,253,175,27,72,107,183,141,212,15,60,138,129,75,6,186,149,35,137,61,0,222,67,154,217,154,180,183,234,111,121,55,217,125,46,0,183,113,80,234,51,162,5,189,215,175,201,160,180,188,79,38,66,151,45,120,38,241,86,177,135,138,109,17,135,89,171,59,133,216,214,110,39,23,158,68,60,48,171,195,58,225,217,190,154,38,68,243,150,204,95,61,204,92,101,15,216,108,137,239,167,44,35,95,221,59,124,221,136,159,84,144,27,234,21,104,245,31,7,153,240,218,232,74,229,15,175,4,219,220,173,179,73,117,2,193,2,100,114,69,132,187,132,128,146,16,19,213,54,140,76,251,216,19,231,88,155,77,181,149,57,114,14,138,25,253,212,135,138,66,255,170,107,76,42,242,43,80,220,200,79,130,112,125,68,71,90,191,17,139,113,117,63,10,157,144,181,3,42,237,52,92,157,254,18,0,213,237,38,124,169,2,112,85,24,161,232,95,233,159,74,233,94,132,204,83,153,154,51,224,221,56,223,38,204,211,22,19,79,97,84,135,133,90,26,212,160,77,188,254,213,240,222,176,114,21,175,31,251,150,113,153,80,223,96,152,161,37,98,168,117,153,77,164,130,96,85,246,235,121,51,18,77,92,161,73,140,169,51,17,103,216,149,231,252,56,136,229,106,144,171,15,145,1,5,90,31,119,66,167,86,9,62,98,136,157,60,17,5,253,114,163,181,38,98,22,73,220,148,178,35,62,132,11,185,236,206,130,135,55,246,0,13,180,153,2,241,94,27,181,102,66,150,245,178,233,82,74,74,69,41,203,140,154,89,79,108,68,103,198,87,31,40,23,48,104,116,57,34,81,34,51,116,21,149,97,62,228,228,146,71,95,117,190,38,225,45,62,61,60,165,53,197,23,200,241,157,11,177,26,163,131,244,220,26,54,206,178,138,235,53,179,140,200,213,41,249,157,163,201,88,223,59,160,226,70,181,238,1,97,129,61,116,52,25,179,142,1,21,87,20,30,130,2,121,73,238,129,161,155,176,8,66,159,133,237,51,33,174,170,174,51,30,92,115,155,233,70,98,111,91,233,61,168,241,220,125,82,25,166,121,57,166,7,100,203,0,157,132,113,34,77,132,114,49,222,172,36,124,186,42,222,185,222,224,138,176,23,104,45,205,124,234,86,213,226,180,175,138,55,55,188,172,80,51,55,138,142,70,100,107,84,243,238,216,110,42,207,45,21,240,20,130,72,39,27,129,214,124,173,59,137,200,161,231,49,213,129,216,192,200,23,22,141,196,247,124,119,246,199,76,95,125,112,117,79,164,115,224,230,47,188,15,29,20,188,97,157,208,64,212,169,185,197,87,140,174,53,155,182,118,103,131,116,207,182,252,105,213,119,101,160,85,99,151,38,90,213,88,141,252,72,22,167,126,97,94,165,248,212,151,9,76,234,45,94,133,156,49,8,252,180,162,191,155,156,107,124,123,237,200,15,106,225,154,199,154,142,179,38,81,99,69,76,192,66,172,55,220,15,147,132,9,243,232,195,123,105,162,11,188,155,180,155,40,242,107,247,11,108,221,39,141,71,160,170,33,253,244,239,108,88,165,69,184,82,107,137,173,87,56,206,68,254,89,28,104,127,248,130,165,65,140,141,182,67,182,54,70,228,217,243,31,55,182,127,122,225,100,173,204,139,74,59,169,124,243,229,207,175,156,189,205,212,83,125,52,102,120,91,207,196,148,211,172,67,237,167,171,79,149,143,30,197,162,49,51,177,156,153,134,50,169,185,108,254,18,115,245,159,107,64,15,72,172,70,245,254,239,102,155,97,42,47,141,162,34,249,89,145,69,22,46,177,146,165,23,225,119,41,14,243,253,126,229,51,20,110,248,36,251,68,208,223,108,40,162,92,172,223,110,149,15,10,104,127,74,165,187,108,41,162,53,194,191,167,93,209,51,105,43,215,75,157,243,203,239,163,71,17,95,215,184,212,165,144,93,135,10,17,70,182,26,122,234,46,212,98,152,158,106,213,245,66,49,217,114,104,81,196,243,68,189,29,219,164,246,62,184,161,137,110,184,62,241,166,18,171,60,254,204,106,113,241,219,191,177,185,91,96,170,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ffa4eee2-4d47-4707-930e-a0662be64d90"));
		}

		#endregion

	}

	#endregion

}

