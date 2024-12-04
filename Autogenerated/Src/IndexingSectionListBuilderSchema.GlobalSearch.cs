﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingSectionListBuilderSchema

	/// <exclude/>
	public class IndexingSectionListBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingSectionListBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingSectionListBuilderSchema(IndexingSectionListBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1195b437-03c8-4435-ad94-63358b301303");
			Name = "IndexingSectionListBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,88,91,111,219,54,20,126,118,129,254,7,78,217,131,50,36,74,178,75,215,174,141,129,38,77,3,99,107,215,197,237,246,88,48,210,81,76,84,38,29,146,74,235,181,253,239,59,135,164,108,74,150,156,102,69,141,32,142,40,158,11,191,243,157,11,35,249,28,204,130,231,192,94,131,214,220,168,210,102,167,74,150,226,170,214,220,10,37,179,243,74,93,242,106,10,92,231,179,251,247,62,222,191,55,170,141,144,87,108,186,52,22,230,143,59,207,40,92,85,144,147,164,201,206,65,130,22,249,122,79,108,67,195,208,122,246,236,100,240,213,153,180,194,10,48,184,1,183,236,104,184,66,75,236,180,226,198,252,198,38,178,128,15,40,52,245,14,252,33,140,61,169,69,85,128,198,189,248,115,112,112,192,158,152,122,62,231,122,57,14,207,110,131,97,118,6,76,144,56,20,204,52,254,55,34,7,145,204,162,190,172,68,206,114,178,184,197,32,91,123,227,92,94,182,157,33,24,215,222,163,45,203,165,197,19,188,210,226,134,91,112,135,219,112,215,45,188,94,46,208,211,130,169,210,249,92,138,10,24,56,11,172,18,242,29,249,188,233,244,104,225,245,50,180,99,209,123,13,188,80,178,90,178,243,26,85,189,37,37,141,151,242,29,89,152,20,236,152,73,120,239,54,164,201,47,63,63,186,204,127,44,31,238,31,2,28,238,23,229,209,209,254,163,95,143,46,247,15,15,143,138,7,135,240,232,167,135,249,131,100,247,241,54,75,198,106,10,231,91,179,52,207,209,220,52,159,193,156,191,68,246,161,161,100,234,23,147,187,104,184,128,92,233,98,82,32,225,234,185,108,52,53,171,164,202,97,12,178,240,48,135,231,24,115,93,231,86,105,130,221,5,181,7,245,137,68,182,241,74,252,11,134,113,7,136,112,177,194,124,9,1,120,98,0,88,174,161,60,78,222,24,208,168,87,122,50,36,236,96,236,105,146,117,98,225,25,52,204,157,180,173,136,213,173,199,93,164,214,37,55,144,118,151,29,167,70,111,219,203,136,73,123,193,65,252,121,59,56,47,192,206,84,241,69,116,124,90,96,242,56,18,26,23,81,118,93,131,94,50,171,144,141,198,14,176,209,173,44,184,230,115,38,49,110,199,137,39,176,231,68,50,14,136,196,208,158,197,27,16,215,38,10,8,173,211,51,160,214,92,19,172,201,152,126,83,192,188,29,239,41,57,138,133,164,165,161,161,222,141,194,180,192,163,173,153,250,23,29,43,141,221,8,202,252,195,30,35,19,79,226,247,78,98,204,130,15,77,120,110,184,118,112,5,29,199,236,57,86,157,11,40,65,3,30,103,109,47,141,181,251,204,26,137,146,165,177,44,102,104,93,85,236,211,167,72,99,230,211,193,100,164,247,100,73,105,145,38,148,209,201,110,35,208,184,50,210,96,107,237,9,65,140,136,188,59,51,215,232,218,57,216,41,80,49,127,174,180,99,171,107,8,145,11,193,175,0,20,89,193,111,139,4,14,58,194,251,0,65,134,251,218,111,2,13,187,168,135,106,16,3,127,7,116,91,5,6,79,209,73,136,44,214,242,130,75,126,5,218,129,53,9,148,10,160,109,22,170,40,10,29,27,235,64,180,94,124,93,44,200,206,228,74,98,211,43,214,29,4,91,170,157,152,176,28,242,164,237,205,238,215,134,183,173,237,241,74,80,183,234,45,202,223,122,214,225,74,29,65,217,85,251,69,28,109,11,61,173,4,55,116,160,104,82,241,111,222,88,81,209,24,98,177,144,81,245,137,246,119,12,239,245,116,166,224,101,64,140,232,235,247,110,59,88,54,5,194,51,135,194,49,212,191,249,155,87,53,120,171,223,39,59,59,31,123,220,255,188,179,147,124,163,116,234,40,219,200,34,74,162,78,121,194,125,136,39,174,103,167,216,126,109,16,253,71,216,217,43,170,149,128,15,38,245,139,167,106,142,245,83,24,37,201,70,246,82,217,179,235,154,87,123,204,51,125,175,127,186,88,31,37,243,106,76,115,28,252,123,247,142,61,74,89,36,49,20,91,186,20,50,32,238,38,158,246,212,71,124,183,42,149,246,195,159,203,0,150,43,105,185,144,52,108,228,158,213,236,61,30,157,85,74,189,171,23,140,203,130,89,248,96,89,193,45,103,55,20,91,102,233,236,223,170,217,57,227,193,147,205,134,231,51,196,140,47,252,119,255,57,233,132,149,186,194,10,103,102,236,135,204,92,87,174,16,160,182,70,220,51,39,64,201,110,132,182,24,69,182,73,150,129,170,49,216,25,99,102,65,83,119,158,65,137,172,237,235,113,79,23,139,106,249,66,21,162,20,80,252,41,3,57,82,162,104,180,225,37,194,223,74,233,192,109,220,182,215,178,158,181,118,101,81,86,251,115,147,75,49,219,134,216,99,154,25,59,154,114,112,120,96,165,86,243,230,190,192,112,84,54,119,35,193,155,73,97,146,241,96,72,135,162,51,212,13,209,209,238,42,58,233,155,39,13,242,216,47,87,102,91,113,217,20,10,227,255,128,165,180,41,141,216,134,120,62,99,169,187,71,212,120,107,16,178,199,198,104,144,29,255,171,63,163,234,20,109,5,31,238,208,40,91,124,91,57,55,162,124,23,178,118,247,209,85,155,233,5,102,57,220,54,123,184,60,234,193,213,149,185,13,181,141,64,207,200,217,158,50,123,52,6,89,239,117,255,244,52,44,213,100,193,230,134,91,179,226,149,6,164,45,50,197,9,19,101,154,137,154,13,221,65,27,254,170,27,188,212,139,34,180,168,160,200,199,174,225,236,237,244,28,32,123,231,90,101,28,15,241,48,44,250,172,104,219,20,165,21,107,219,24,245,210,55,84,0,223,30,47,148,178,126,189,99,130,62,68,204,239,90,199,162,127,173,80,107,49,191,195,50,245,138,124,77,114,166,186,242,244,105,139,19,121,34,49,228,131,175,139,93,41,140,219,150,199,11,152,99,4,206,230,11,187,196,42,76,217,18,202,119,139,27,183,86,68,10,154,180,1,143,47,173,123,38,180,189,225,118,231,119,12,247,57,156,64,214,102,9,227,230,47,186,161,23,128,240,86,131,109,109,69,188,240,191,4,154,12,157,186,245,208,215,238,100,94,119,67,132,144,45,52,160,110,25,81,252,106,188,136,43,255,1,158,167,184,21,104,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1195b437-03c8-4435-ad94-63358b301303"));
		}

		#endregion

	}

	#endregion

}

