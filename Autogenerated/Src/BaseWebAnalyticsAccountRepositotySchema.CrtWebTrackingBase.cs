﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseWebAnalyticsAccountRepositotySchema

	/// <exclude/>
	public class BaseWebAnalyticsAccountRepositotySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseWebAnalyticsAccountRepositotySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseWebAnalyticsAccountRepositotySchema(BaseWebAnalyticsAccountRepositotySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7222d0ba-8739-4d59-94b8-4348d1a7f0cb");
			Name = "BaseWebAnalyticsAccountRepositoty";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,88,219,110,219,56,16,125,118,129,254,3,235,5,10,5,136,149,166,105,220,166,137,189,176,19,187,48,144,94,182,110,218,199,130,150,198,14,177,186,56,36,149,212,45,242,239,59,20,73,75,150,104,57,221,110,177,47,65,68,14,57,23,158,115,134,116,66,99,16,75,26,0,249,4,156,83,145,206,165,127,158,38,115,182,200,56,149,44,77,30,63,250,241,248,81,43,19,44,89,144,233,74,72,136,79,43,223,104,31,69,16,40,99,225,191,129,4,56,11,106,54,151,44,185,41,6,203,190,226,56,77,220,51,28,182,141,251,163,68,50,201,64,20,6,139,40,157,209,232,245,107,189,161,127,153,46,22,56,140,243,104,241,7,135,5,70,71,206,35,42,196,107,242,5,102,131,132,70,43,201,2,49,149,28,104,252,54,13,33,202,77,15,14,14,200,153,200,226,152,242,85,223,124,95,192,156,37,32,8,139,151,17,196,144,200,188,48,36,157,147,59,152,17,106,183,34,34,223,139,120,130,73,216,243,237,102,7,165,221,150,217,44,98,1,9,84,28,219,195,104,169,138,91,91,220,84,165,55,9,201,15,178,0,121,74,132,250,115,95,183,120,135,39,185,203,6,51,161,89,36,175,56,219,101,169,3,114,120,189,215,21,133,36,212,69,117,21,120,72,5,148,179,27,4,65,154,37,242,35,44,83,172,77,42,87,91,75,173,86,154,242,200,148,220,165,252,111,114,199,228,117,165,208,84,239,135,255,36,161,169,186,104,170,55,157,161,17,13,164,217,249,1,225,169,35,80,69,177,137,141,25,68,33,102,246,129,179,91,42,65,79,46,245,7,65,255,97,154,68,43,114,37,128,35,121,18,77,6,242,53,219,248,62,117,174,153,32,82,201,215,8,225,10,220,109,241,38,99,33,249,170,178,103,114,21,136,15,17,149,243,148,227,217,104,112,87,207,194,17,115,42,49,2,8,109,212,230,179,226,193,4,10,225,20,241,157,9,60,250,30,73,224,46,159,244,218,199,135,195,23,135,71,221,110,103,116,124,114,209,121,241,234,228,176,51,24,31,31,118,142,142,71,135,23,47,187,207,135,71,175,158,183,247,78,155,28,92,48,17,52,250,120,53,124,246,114,120,113,120,212,233,14,158,141,59,47,158,157,159,116,6,23,221,151,157,241,73,247,120,60,28,118,143,134,195,65,238,163,41,107,76,3,15,59,11,100,202,85,238,57,0,180,69,21,111,249,192,36,65,29,193,202,126,71,126,211,60,22,134,235,105,130,130,136,252,150,215,128,75,0,33,201,97,222,107,239,4,78,251,160,175,49,166,208,88,135,163,30,89,82,142,42,145,32,93,123,237,77,132,180,251,159,208,161,26,35,193,122,208,63,59,200,87,184,55,208,192,209,11,245,255,205,246,14,24,233,197,5,187,150,102,134,176,16,181,142,205,89,101,79,67,170,157,197,240,42,116,216,204,117,95,35,95,199,188,175,17,226,8,110,143,228,98,216,170,112,9,113,227,32,87,203,240,8,103,75,132,106,185,184,131,38,110,70,181,140,194,109,5,24,210,105,9,92,53,159,26,181,182,32,108,43,158,54,11,132,224,217,2,155,130,81,149,146,86,62,117,169,80,175,73,175,95,83,31,82,202,237,103,3,85,71,165,176,109,16,182,43,202,252,100,47,245,81,108,198,100,142,133,60,160,206,111,65,94,167,14,205,181,78,242,43,192,106,26,92,67,76,255,202,128,163,202,128,52,32,20,249,128,103,193,115,75,57,1,113,243,17,4,54,63,35,57,181,229,21,184,250,101,131,183,136,149,28,166,109,7,226,219,214,77,11,35,85,213,200,183,195,75,81,22,43,156,254,32,19,241,153,9,54,139,0,191,80,154,64,247,219,214,189,70,231,58,48,127,16,134,122,149,215,70,86,238,53,76,27,207,59,172,212,141,160,209,160,200,86,235,177,53,86,245,154,179,72,2,31,174,202,148,209,89,22,91,157,163,192,75,24,231,150,95,176,77,127,80,26,1,248,33,60,61,136,151,49,212,13,38,210,228,211,106,137,183,182,155,140,70,149,34,218,253,219,251,206,30,87,11,95,111,44,84,26,94,61,70,99,206,65,102,60,41,206,188,204,235,2,65,179,52,141,240,112,70,223,152,144,120,231,49,69,245,204,13,200,92,50,38,225,190,193,74,113,205,93,95,64,138,161,61,132,119,238,186,62,69,158,32,226,178,40,34,79,159,58,22,250,131,100,229,125,83,228,248,134,151,103,169,234,100,206,231,51,141,50,56,211,209,244,55,206,156,244,80,189,236,167,109,136,85,102,40,58,252,238,212,252,47,215,192,225,215,194,215,160,194,115,229,66,190,231,230,134,234,213,179,186,101,92,34,124,116,167,152,210,91,120,7,119,54,175,137,131,150,214,197,134,8,232,202,244,200,110,174,171,108,172,34,14,87,138,74,158,155,252,38,126,205,5,189,81,69,74,44,134,243,57,127,10,18,147,44,213,72,120,53,131,210,108,185,114,251,54,39,191,32,134,123,77,78,253,194,92,125,54,47,168,74,65,238,173,118,37,108,222,195,69,235,124,159,38,98,155,173,240,60,189,10,121,245,140,209,212,146,35,55,153,157,237,64,191,98,76,55,208,87,140,53,238,126,111,111,208,158,255,135,214,96,31,110,191,214,25,166,248,132,189,226,145,171,33,88,122,253,150,110,96,89,181,134,238,3,59,128,89,247,83,242,95,147,190,146,96,26,224,60,16,51,85,164,85,99,175,198,163,180,165,234,221,169,25,181,152,111,83,140,231,106,25,98,161,109,136,147,81,146,197,192,41,130,232,108,203,79,10,125,243,72,190,196,228,28,146,111,94,208,54,59,251,160,30,167,124,68,131,107,207,138,102,223,98,89,165,111,126,235,232,149,118,214,147,45,211,19,132,90,96,56,220,216,24,10,192,106,68,8,79,248,118,108,207,168,171,179,61,168,113,54,39,222,19,189,149,63,17,239,176,203,190,231,163,120,137,18,172,227,250,83,75,223,154,134,59,244,82,47,42,203,165,58,130,135,57,42,126,91,217,237,206,210,107,237,177,180,120,211,175,67,31,239,55,176,177,251,250,188,235,9,252,49,71,167,192,39,231,26,17,230,5,176,126,174,23,191,184,160,120,147,32,227,28,227,170,252,40,99,159,141,77,79,95,77,4,209,63,127,128,43,124,115,90,243,210,171,211,222,2,92,228,93,183,43,251,10,216,250,0,168,191,20,234,58,167,123,30,233,149,104,251,239,20,78,31,100,253,178,221,208,95,27,181,78,27,255,71,210,82,129,143,235,215,189,251,127,0,241,239,164,124,36,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7222d0ba-8739-4d59-94b8-4348d1a7f0cb"));
		}

		#endregion

	}

	#endregion

}

