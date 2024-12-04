﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialNetworkServiceSchema

	/// <exclude/>
	public class SocialNetworkServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialNetworkServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialNetworkServiceSchema(SocialNetworkServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("679fa724-ae5c-4a2b-a837-e5714f2ac352");
			Name = "SocialNetworkService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,88,81,79,219,48,16,126,46,18,255,193,98,47,237,75,127,64,11,76,172,64,87,77,160,137,178,237,1,161,201,117,142,54,34,113,58,219,129,117,83,255,251,46,177,27,156,216,205,74,90,54,180,189,180,201,229,252,125,119,223,57,103,59,156,198,32,231,148,1,185,6,33,168,76,238,84,119,144,240,187,112,154,10,170,194,132,119,199,9,11,105,180,191,247,115,127,175,149,202,144,79,201,120,33,21,196,253,202,61,14,139,34,96,217,24,217,29,2,7,17,50,199,231,42,229,42,140,161,59,198,167,52,10,127,228,20,79,94,107,98,240,59,8,232,158,83,166,18,17,130,244,121,124,129,9,122,197,113,62,30,159,191,17,48,69,48,50,136,168,148,61,162,243,186,4,245,152,136,123,140,231,33,100,144,251,205,211,73,20,50,194,50,55,175,215,225,245,49,233,145,119,84,130,49,144,199,25,8,84,208,178,130,192,12,56,202,145,8,132,68,237,240,183,136,224,163,72,230,32,20,198,221,203,174,21,186,65,160,93,230,34,124,160,42,195,250,42,203,48,125,253,216,120,163,67,133,134,100,5,106,181,166,160,204,85,75,128,74,5,119,128,200,219,183,164,237,24,143,200,16,84,5,18,19,109,119,58,57,113,107,153,253,46,77,30,192,3,157,74,57,175,11,80,179,36,240,37,181,138,250,33,20,42,165,17,70,191,134,205,146,82,23,64,231,98,82,201,75,167,139,190,192,57,166,242,33,253,103,69,150,23,215,132,165,11,93,154,106,166,162,87,248,82,224,60,6,20,89,157,48,6,82,94,39,247,192,219,190,233,112,5,223,82,144,138,8,253,223,49,33,43,177,88,21,98,146,36,17,145,105,142,131,66,87,242,238,86,56,86,56,90,247,85,234,28,30,107,35,69,233,12,91,107,92,48,25,78,109,95,154,66,18,70,21,155,145,246,217,119,6,243,12,137,64,49,214,144,85,35,124,79,121,16,65,49,224,176,46,144,227,54,120,166,140,209,218,202,179,144,120,184,11,137,165,18,217,219,79,159,128,60,66,15,55,21,218,19,166,165,239,73,137,196,162,220,185,206,158,56,158,45,239,121,200,131,63,164,111,149,234,223,19,184,182,87,12,4,96,235,214,250,34,112,130,107,221,86,13,131,62,100,216,105,164,60,82,251,184,118,217,56,10,238,215,211,59,74,201,142,248,93,98,119,16,231,97,67,229,29,28,34,29,139,183,177,184,1,172,47,199,218,76,236,90,120,104,157,80,118,94,156,181,145,53,172,76,214,17,254,110,105,252,17,252,63,181,169,237,88,167,16,193,14,59,86,144,195,173,237,89,62,182,29,246,44,155,253,245,116,173,250,21,99,6,236,126,23,242,59,203,131,11,220,84,233,215,161,161,76,99,16,213,166,111,219,27,10,103,67,16,102,223,120,187,124,137,177,86,81,39,96,107,206,150,72,143,74,180,47,49,113,157,80,252,98,87,206,78,218,90,49,110,112,134,54,154,231,238,55,167,84,81,140,64,9,60,179,221,110,114,182,46,70,215,158,153,173,67,92,78,113,1,241,4,68,251,18,63,102,160,158,7,214,142,241,160,147,209,174,120,205,46,214,222,95,22,167,102,45,136,52,23,203,245,232,106,49,135,50,236,48,13,241,64,142,230,6,104,41,30,196,61,104,159,208,220,0,109,53,149,62,192,194,155,249,224,233,249,22,232,99,96,56,251,106,9,180,203,22,28,159,65,72,172,123,45,137,241,105,192,162,87,235,81,224,133,215,243,114,20,108,129,43,125,192,55,183,5,180,108,164,76,28,227,203,93,70,206,190,55,13,244,3,148,69,255,55,134,174,68,61,58,227,153,202,116,18,193,161,197,115,188,34,250,93,18,141,27,138,103,143,179,113,59,241,237,66,123,181,75,220,118,189,198,217,247,149,53,116,183,138,142,165,223,88,45,207,233,117,3,157,124,31,9,94,82,161,103,116,227,230,82,248,150,185,13,180,240,238,44,94,82,12,123,173,47,171,81,218,20,216,55,155,139,178,252,5,153,53,226,65,206,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("679fa724-ae5c-4a2b-a837-e5714f2ac352"));
		}

		#endregion

	}

	#endregion

}

