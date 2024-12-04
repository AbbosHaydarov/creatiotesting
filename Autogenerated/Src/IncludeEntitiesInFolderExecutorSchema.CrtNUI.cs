﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IncludeEntitiesInFolderExecutorSchema

	/// <exclude/>
	public class IncludeEntitiesInFolderExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IncludeEntitiesInFolderExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IncludeEntitiesInFolderExecutorSchema(IncludeEntitiesInFolderExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("156c8b66-cea5-40c8-9f55-36d52ac4b396");
			Name = "IncludeEntitiesInFolderExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,87,75,111,227,54,16,62,187,64,255,3,155,94,40,52,80,210,235,102,147,34,177,157,173,129,102,55,77,210,246,176,88,4,140,52,182,137,149,73,47,73,37,54,22,253,239,29,62,36,81,175,56,221,67,214,34,231,249,205,204,55,146,96,27,208,91,150,1,121,0,165,152,150,75,147,78,165,88,242,85,169,152,225,82,144,239,63,254,48,41,53,23,43,114,191,215,6,54,103,157,103,20,47,10,200,172,172,78,63,128,0,197,179,158,204,31,92,124,107,14,99,87,155,141,20,195,55,10,198,206,211,217,213,232,213,53,203,140,84,28,52,74,160,204,207,10,86,54,139,105,193,180,126,71,174,101,145,131,186,116,209,222,50,133,201,27,80,218,73,110,203,167,130,103,36,179,130,35,114,22,11,148,172,141,222,42,185,5,101,208,217,59,114,235,212,237,109,48,164,141,178,225,205,133,225,102,127,159,173,97,195,62,162,29,242,157,172,192,156,17,109,255,252,59,38,143,152,150,27,97,229,23,194,199,226,207,71,181,63,148,60,15,81,47,242,174,148,139,25,68,238,195,198,39,127,22,31,245,161,90,136,172,40,115,112,126,49,195,58,142,29,100,37,34,236,84,78,78,78,200,123,46,214,128,50,185,68,240,20,44,207,143,22,7,84,143,78,46,80,247,243,12,150,172,44,204,21,23,57,38,78,205,126,11,114,73,15,41,39,199,196,193,120,78,4,254,103,21,14,200,39,95,186,197,61,160,65,48,247,67,34,157,70,192,137,209,134,9,99,251,64,241,103,102,192,223,111,253,3,201,236,61,225,194,144,27,182,107,250,105,42,75,97,110,65,253,89,130,218,79,215,165,248,138,105,253,122,122,122,122,214,87,14,237,225,227,104,218,3,21,142,170,178,31,249,150,239,214,181,142,242,154,67,145,143,133,168,128,229,82,20,123,242,151,182,246,133,240,35,77,30,203,214,243,217,160,206,200,184,60,110,235,223,45,189,144,203,35,244,122,125,246,116,32,135,214,200,13,229,225,177,116,38,231,187,173,2,173,93,234,46,64,119,87,199,71,206,47,136,23,76,235,51,26,133,156,86,184,38,67,193,247,231,116,246,228,184,114,50,193,217,11,191,38,124,73,232,96,154,228,28,27,184,44,138,164,146,156,60,51,69,32,34,11,172,108,7,251,52,230,146,27,38,216,10,20,50,174,89,184,230,203,224,106,111,173,183,82,232,178,143,79,5,255,141,4,213,138,224,183,212,95,35,18,92,105,67,51,247,100,97,243,191,82,223,128,24,103,207,227,24,127,37,193,228,223,172,40,193,94,135,120,28,149,77,38,10,76,169,196,104,99,84,130,3,148,214,155,70,85,218,61,16,17,115,68,150,7,166,155,118,70,160,93,133,227,177,110,111,64,168,138,218,41,223,116,13,217,215,75,181,42,55,152,223,71,44,62,13,20,214,150,75,66,145,34,80,71,53,35,159,65,171,211,51,88,210,129,1,158,68,21,67,137,206,152,30,128,247,6,204,90,142,242,200,98,46,48,74,197,158,10,120,31,255,182,11,234,226,130,96,187,222,65,38,85,238,232,78,211,158,8,146,138,189,174,49,180,99,17,142,28,93,98,184,225,49,117,207,52,228,109,229,50,103,179,18,163,200,183,201,13,51,235,116,10,188,176,43,166,101,231,132,208,92,98,63,64,114,128,147,131,131,208,155,149,243,251,109,193,205,39,91,127,163,105,228,56,137,33,172,64,177,204,143,83,138,196,21,39,255,32,103,79,3,0,8,120,185,235,99,192,150,75,44,32,228,119,242,197,150,204,175,136,8,29,111,18,111,186,8,71,230,170,68,154,91,228,56,53,103,217,218,103,96,71,187,229,231,151,243,16,182,147,118,241,58,193,164,141,73,172,243,122,250,141,157,126,222,222,114,181,90,93,106,220,41,185,82,216,133,15,47,193,12,237,116,121,146,46,132,145,111,97,190,37,190,35,98,190,132,54,200,161,151,200,183,99,237,198,109,234,152,74,87,93,214,186,186,7,67,135,214,192,113,127,173,120,79,201,152,149,238,86,63,30,92,88,65,59,128,91,129,31,219,242,12,6,33,218,78,21,126,103,122,141,206,2,218,117,155,232,249,142,107,83,147,32,141,155,46,139,223,51,134,82,109,186,80,131,253,8,136,75,117,239,78,122,165,242,8,164,51,116,202,5,222,87,7,222,112,88,50,174,98,225,226,90,201,205,235,165,13,130,255,172,65,65,15,75,236,13,61,255,86,178,130,14,98,74,152,14,145,182,90,58,74,167,66,181,105,88,186,179,147,178,179,187,55,90,103,30,216,56,129,36,125,144,1,245,225,146,244,135,96,190,243,171,201,213,36,20,136,182,43,23,24,232,65,94,230,121,92,44,136,117,98,34,232,85,56,230,1,111,39,189,131,141,124,134,59,38,86,64,91,134,6,217,207,233,252,191,93,17,109,225,250,171,65,69,95,13,228,141,159,13,213,14,183,156,82,181,187,127,37,251,252,133,32,174,27,86,189,254,249,201,173,16,26,184,122,101,173,14,216,137,246,76,141,2,190,141,102,248,134,105,87,232,128,249,48,0,94,26,191,202,176,103,108,5,45,45,104,168,143,7,186,100,210,117,144,142,70,218,149,140,195,108,152,223,78,239,80,99,245,180,189,178,125,107,253,169,209,78,47,197,158,38,53,59,134,86,8,27,200,191,185,133,179,145,29,215,93,65,111,253,36,69,185,255,0,59,214,190,135,160,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("156c8b66-cea5-40c8-9f55-36d52ac4b396"));
		}

		#endregion

	}

	#endregion

}

