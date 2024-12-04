﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddCampaignParticipantElementSchema

	/// <exclude/>
	public class AddCampaignParticipantElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddCampaignParticipantElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddCampaignParticipantElementSchema(AddCampaignParticipantElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5cfb8ea0-871b-465f-9528-ee004222f938");
			Name = "AddCampaignParticipantElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fa1eba96-dfc3-478b-8218-5e2f73e3966c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,88,89,111,219,56,16,126,118,129,254,7,194,125,88,7,176,157,56,103,157,195,128,227,35,107,96,27,4,105,210,125,40,246,129,150,104,155,187,146,168,37,169,184,222,32,255,125,135,151,44,217,146,234,20,41,176,216,135,166,22,103,248,113,142,111,134,35,69,56,36,34,198,30,65,15,132,115,44,216,76,182,7,44,154,209,121,194,177,164,44,122,255,238,249,253,187,90,34,104,52,71,159,87,66,146,240,98,227,25,244,131,128,120,74,89,180,111,72,68,56,245,214,58,89,216,48,100,81,177,132,147,178,245,246,0,135,49,166,243,210,141,169,66,123,18,73,194,103,224,139,40,213,189,227,12,196,74,14,26,31,56,153,131,209,104,16,96,33,206,81,223,247,29,212,29,230,146,122,52,198,145,28,5,36,36,145,212,27,246,247,247,209,165,72,194,16,243,85,207,62,91,57,146,11,44,17,142,99,18,249,2,197,235,253,2,73,134,60,103,162,3,217,207,160,124,29,18,1,178,79,204,39,96,94,76,184,92,53,110,33,45,232,10,213,39,226,158,120,9,231,224,74,189,9,186,181,71,129,231,228,97,21,43,233,122,95,186,218,190,101,242,11,21,116,26,144,38,250,68,36,118,136,22,48,131,151,149,236,253,241,29,59,210,93,99,78,254,78,72,228,173,38,209,16,175,196,155,24,165,128,110,147,112,74,248,171,108,186,227,148,113,42,87,111,98,131,3,219,178,32,78,166,1,245,144,167,56,82,77,17,116,142,174,177,32,78,161,159,248,20,2,69,172,180,137,38,246,151,59,10,192,161,180,148,237,41,17,161,130,164,226,204,185,178,231,9,75,98,228,177,121,64,158,146,35,33,85,34,202,82,185,201,154,139,82,128,226,176,87,102,219,212,77,237,3,144,220,152,92,97,63,147,208,19,136,239,60,176,143,121,19,138,162,158,75,237,46,7,242,196,147,140,171,51,117,170,140,198,102,169,234,133,33,153,225,36,144,198,6,179,13,205,224,223,165,32,16,27,78,102,87,245,202,12,215,247,123,170,130,183,75,216,177,164,114,119,99,15,169,86,90,171,217,103,75,86,183,225,179,183,32,33,206,200,218,128,230,72,164,179,248,82,225,218,224,205,93,210,43,208,200,112,136,34,72,203,85,93,176,132,123,164,222,155,232,36,195,141,193,102,175,58,230,114,95,163,237,30,175,234,106,51,230,236,233,136,214,206,161,255,82,209,48,107,77,20,37,65,96,254,218,152,255,143,66,183,5,238,83,79,62,176,123,50,165,145,95,239,13,225,9,74,3,76,81,23,15,215,171,72,104,110,33,98,16,197,47,136,250,162,26,20,126,131,166,225,100,189,7,86,169,144,187,107,204,226,253,156,140,234,110,94,171,173,253,184,188,73,168,223,68,234,111,15,101,157,109,162,252,253,159,175,36,148,117,193,210,4,120,50,133,22,157,242,36,143,150,219,96,107,53,211,74,161,86,205,190,118,102,81,23,102,173,172,97,174,183,148,105,152,253,174,223,173,245,221,74,182,240,203,186,160,237,158,148,108,247,221,66,194,79,124,112,147,206,40,225,138,135,150,20,8,235,120,151,245,183,180,127,179,39,152,168,168,79,116,62,80,95,111,66,87,189,180,141,233,106,18,105,46,126,99,115,213,203,242,173,108,103,103,190,215,208,199,1,158,163,229,130,122,11,4,25,164,30,220,113,194,76,98,206,43,15,71,200,87,117,224,146,136,125,31,205,56,11,161,212,3,159,240,18,127,191,170,17,65,25,158,78,29,245,231,179,254,73,247,232,168,223,109,141,199,131,81,235,184,243,113,216,186,238,94,119,90,103,157,227,78,103,124,116,120,216,29,247,95,234,122,104,112,213,48,101,44,200,94,212,232,25,205,137,188,64,66,253,169,234,73,230,94,86,233,241,21,141,166,4,26,19,201,142,149,104,73,131,0,214,149,63,144,149,136,124,131,17,148,134,228,21,254,12,7,167,221,254,241,225,73,235,248,160,59,110,29,143,187,215,173,238,209,233,97,107,52,28,140,250,39,195,81,255,112,48,218,240,135,194,193,165,92,223,213,183,148,236,224,157,202,6,182,196,72,115,70,190,193,17,21,100,44,114,230,224,116,116,60,234,142,63,182,198,157,46,120,116,218,57,109,117,251,253,131,86,167,123,116,112,114,61,24,157,14,58,103,5,206,164,182,20,24,95,198,80,56,125,193,252,29,107,237,158,96,120,31,80,6,15,177,196,232,9,7,137,162,40,67,113,202,243,221,75,238,137,169,146,139,227,96,229,0,191,40,188,134,250,165,14,2,198,112,253,159,235,94,170,217,181,11,54,88,45,211,124,196,146,74,40,32,187,216,30,64,118,33,11,122,0,182,48,53,15,112,202,6,206,115,219,90,243,157,210,130,221,16,121,13,53,96,78,181,231,129,89,32,253,235,34,3,93,60,138,58,228,138,238,186,62,70,31,113,9,57,237,85,156,83,52,111,186,83,50,61,120,141,10,175,148,21,182,251,102,158,60,223,22,189,236,208,182,215,60,250,94,155,251,29,236,2,214,132,144,67,232,7,41,141,118,157,62,150,106,59,207,79,31,114,65,178,19,136,162,134,62,133,195,184,129,164,154,62,11,46,247,60,17,181,190,227,85,99,141,128,204,121,57,14,230,117,173,130,9,149,121,48,26,38,214,37,68,131,55,168,181,160,137,102,56,16,164,20,163,152,81,77,237,26,155,53,128,39,123,205,210,86,214,68,7,165,192,69,20,106,166,196,74,119,86,14,156,192,19,149,79,12,109,123,9,109,200,102,69,223,91,84,45,123,1,139,210,44,41,19,85,87,116,122,85,89,231,68,38,60,18,189,129,2,240,215,208,22,170,114,252,130,132,187,237,69,41,103,211,63,161,27,33,141,156,190,201,152,13,218,141,234,193,79,77,231,111,17,24,22,175,126,36,46,255,189,113,57,159,46,22,211,159,148,46,8,88,227,141,71,233,31,201,125,229,168,189,51,47,68,76,60,152,91,61,100,63,227,141,3,182,116,47,15,175,165,65,34,8,135,89,53,50,31,46,75,95,205,30,243,106,69,239,98,46,13,37,8,219,182,26,148,170,236,21,248,103,98,176,45,104,228,45,68,121,191,92,178,158,48,79,231,172,17,12,255,114,101,98,63,137,102,12,46,60,184,233,250,37,210,198,6,224,69,138,103,198,52,12,95,212,156,141,87,155,108,216,248,6,230,198,137,252,168,144,237,234,70,94,113,225,151,182,108,179,115,172,135,122,80,98,220,159,248,160,111,22,38,190,149,111,4,235,106,35,92,14,133,6,234,30,131,221,250,135,93,253,21,139,84,144,254,182,178,124,244,244,201,110,201,134,210,89,144,95,126,212,170,101,153,105,11,167,84,120,140,81,180,223,204,112,53,134,190,166,138,64,192,121,9,175,126,119,88,46,170,80,224,147,153,82,131,79,253,73,8,69,46,23,102,204,49,108,152,68,84,82,28,208,127,210,143,159,5,60,221,162,139,165,146,237,35,91,226,138,55,95,179,154,95,132,181,127,1,187,68,255,93,204,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5cfb8ea0-871b-465f-9528-ee004222f938"));
		}

		#endregion

	}

	#endregion

}

