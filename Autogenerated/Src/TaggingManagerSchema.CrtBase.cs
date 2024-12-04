﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TaggingManagerSchema

	/// <exclude/>
	public class TaggingManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TaggingManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TaggingManagerSchema(TaggingManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c3b9698-5711-47a9-9751-4e71722bca1f");
			Name = "TaggingManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,86,75,111,211,64,16,62,167,82,255,195,16,36,228,72,145,115,47,109,80,73,91,136,160,15,154,0,7,132,208,214,158,56,139,236,221,176,187,14,68,136,255,206,236,174,237,216,142,83,210,3,151,100,31,243,248,102,230,155,89,11,150,161,94,177,8,97,142,74,49,45,23,38,156,72,177,224,73,174,152,225,82,132,115,150,36,92,36,199,71,191,143,143,122,185,166,37,204,54,218,96,70,114,105,138,145,21,210,225,27,20,168,120,244,178,45,243,158,139,31,219,195,186,143,44,147,162,251,166,238,253,30,83,102,48,190,199,72,170,88,119,203,43,220,119,30,94,10,195,13,199,189,138,225,21,139,140,84,94,130,100,158,43,76,200,45,76,133,65,181,160,180,156,192,180,72,192,53,19,44,65,229,196,70,163,17,156,234,60,203,152,218,140,139,125,165,2,114,1,198,235,64,230,149,194,82,103,84,83,90,229,15,41,143,128,87,122,45,79,64,190,155,225,87,16,122,191,225,143,199,139,34,246,144,27,240,39,41,211,250,4,14,68,62,63,0,236,151,11,92,176,60,53,175,185,136,73,54,48,155,21,202,69,208,130,60,24,194,13,17,10,206,160,223,188,232,15,190,110,35,142,44,58,216,9,182,51,214,225,110,254,123,150,136,85,168,87,28,211,152,98,189,83,124,77,234,46,200,222,202,111,156,238,61,79,150,70,191,197,116,69,94,190,153,230,193,203,182,244,71,195,83,237,196,220,202,179,162,157,230,202,249,157,146,100,196,18,236,80,0,237,253,153,77,110,175,215,198,5,175,94,185,243,96,231,226,204,157,247,92,133,61,121,55,212,124,230,180,237,105,28,8,252,9,212,76,218,168,220,138,157,171,36,207,80,152,160,159,107,84,116,33,124,239,246,135,240,177,113,48,24,12,246,164,165,90,156,141,183,41,34,168,224,96,22,87,208,9,205,93,142,3,103,250,177,140,214,0,219,156,58,194,20,41,245,228,105,178,33,104,66,135,102,104,68,158,38,169,168,94,107,30,83,22,85,231,241,192,229,246,4,30,152,198,160,109,106,143,10,148,173,184,55,164,107,52,75,185,151,162,107,201,99,56,143,227,243,52,149,63,49,166,240,174,120,74,19,33,112,163,107,51,139,150,152,177,15,57,170,141,29,42,186,182,39,215,14,239,154,41,96,149,246,121,20,161,214,104,11,209,98,132,173,69,145,189,154,220,149,84,54,135,173,68,134,147,92,41,34,139,61,13,167,177,39,132,243,100,74,128,228,192,50,108,7,166,191,221,190,13,65,11,246,16,222,203,132,71,44,189,37,76,110,200,207,12,189,28,38,188,85,133,155,202,69,72,121,105,171,135,19,133,148,55,47,240,153,155,229,29,83,52,114,104,163,131,210,117,182,98,138,107,41,230,52,164,194,203,31,57,75,135,110,32,249,152,251,67,223,66,187,57,11,39,76,155,83,249,240,157,144,91,174,62,1,207,141,52,151,191,184,54,186,168,94,255,75,101,247,141,98,52,226,241,164,58,216,174,190,82,110,251,53,55,13,195,222,146,46,157,250,173,151,61,156,113,210,80,44,24,251,123,55,213,185,88,210,75,109,98,25,193,200,13,159,85,41,4,114,77,143,35,177,122,183,168,64,220,185,102,92,20,236,223,185,15,58,135,247,5,51,172,124,85,236,186,206,216,86,180,196,38,219,117,225,191,252,212,173,249,180,241,5,4,207,202,9,19,78,245,109,26,207,220,4,201,21,214,197,203,79,137,169,168,57,240,166,237,155,53,40,193,245,186,154,177,221,122,222,53,149,129,126,21,146,43,209,14,168,94,167,131,243,238,134,193,12,77,241,216,126,98,105,142,122,46,9,81,247,28,179,113,5,14,196,163,34,176,170,109,134,240,164,90,185,170,60,21,82,211,223,255,171,25,188,120,225,107,246,172,238,49,188,168,99,181,31,148,134,180,245,59,220,4,125,111,99,107,130,186,175,172,251,35,38,108,11,218,97,71,38,220,201,29,227,234,148,222,41,26,165,67,240,255,227,14,219,197,160,105,90,110,166,173,222,240,247,82,26,191,15,61,35,107,44,235,238,248,174,143,192,63,199,71,127,1,67,101,46,106,213,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c3b9698-5711-47a9-9751-4e71722bca1f"));
		}

		#endregion

	}

	#endregion

}

