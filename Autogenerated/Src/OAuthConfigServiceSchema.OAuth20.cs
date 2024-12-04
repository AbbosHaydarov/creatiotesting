﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthConfigServiceSchema

	/// <exclude/>
	public class OAuthConfigServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthConfigServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthConfigServiceSchema(OAuthConfigServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83");
			Name = "OAuthConfigService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2e618fe0-496b-4dc6-9b5c-1f29508fde14");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,91,235,111,219,56,18,255,236,5,246,127,96,188,139,133,2,24,66,113,56,224,128,116,147,34,111,120,113,77,115,117,114,253,80,44,22,178,68,219,186,149,37,151,164,146,250,130,252,239,55,124,138,148,40,91,78,236,116,219,94,63,36,21,31,195,121,252,56,51,28,50,121,52,199,116,17,197,24,221,96,66,34,90,76,88,120,90,228,147,116,90,146,136,165,69,30,190,59,46,217,236,111,175,126,252,225,225,199,31,122,37,77,243,41,26,45,41,195,243,215,181,111,152,151,101,56,230,147,104,120,137,115,76,210,184,49,102,132,201,93,26,227,183,69,130,179,149,157,225,49,80,186,19,44,172,30,247,1,143,171,1,211,172,24,71,217,193,193,105,49,159,3,239,255,44,166,83,104,174,250,109,33,249,8,127,15,193,109,237,225,121,206,82,150,98,218,58,192,230,13,20,201,72,20,51,223,96,96,123,13,15,174,29,218,23,100,146,95,232,255,137,224,41,12,69,167,89,68,233,1,18,150,147,68,20,87,98,212,71,245,161,185,251,157,183,29,211,197,21,102,192,208,2,86,27,167,89,202,150,239,241,167,50,37,120,142,115,70,3,251,131,203,134,14,209,154,41,124,84,168,26,146,125,190,200,162,28,103,105,140,98,206,157,135,57,116,128,78,34,138,13,171,61,0,28,252,52,82,93,164,56,75,64,172,107,194,113,33,101,233,45,228,7,34,56,74,138,60,91,162,33,216,28,253,145,193,143,67,4,255,125,27,229,209,20,19,192,35,227,96,192,36,232,43,64,247,247,165,210,122,63,225,60,145,75,240,111,123,197,107,82,44,48,225,230,134,85,5,243,106,81,41,8,101,132,219,67,208,59,75,105,52,206,112,242,22,83,10,11,162,195,35,62,176,151,227,123,224,34,142,178,244,191,188,123,36,102,4,183,20,19,16,61,151,155,5,148,68,139,146,196,208,91,16,152,59,64,253,166,114,250,3,65,175,215,111,80,163,161,143,129,240,223,81,86,226,22,25,43,9,223,98,54,43,90,149,58,46,138,12,13,169,230,111,152,159,102,41,152,246,56,227,218,94,158,127,78,41,32,67,105,33,22,93,195,100,160,213,66,212,172,43,240,48,251,136,59,143,94,239,46,34,8,211,79,96,26,174,24,177,151,150,163,120,134,231,209,191,74,76,150,117,197,216,3,148,33,181,114,234,60,9,73,97,5,160,30,30,39,9,184,162,114,158,7,253,97,162,59,134,141,213,46,210,140,97,50,4,135,162,152,151,13,192,28,16,145,218,14,79,65,82,134,101,199,135,148,205,174,35,2,226,192,7,13,100,163,128,63,73,105,145,223,44,23,224,30,62,149,81,102,12,40,168,134,242,23,112,50,48,74,234,194,147,214,223,182,185,210,154,11,185,97,128,39,199,78,149,18,37,33,202,149,25,216,234,105,25,226,114,171,6,73,241,170,176,192,215,42,51,38,101,225,91,178,62,160,6,0,69,134,96,86,18,61,25,156,94,153,51,116,132,94,137,206,71,15,98,111,200,18,104,43,172,46,22,195,228,100,169,109,208,68,107,81,50,116,89,166,137,106,18,227,53,92,173,38,224,153,143,10,207,231,11,182,124,189,101,48,27,86,53,88,27,196,36,158,81,92,100,130,149,231,160,124,152,104,68,73,52,113,90,79,5,84,59,180,253,16,210,107,183,225,3,134,184,13,27,34,37,157,160,160,78,67,1,230,240,16,189,210,118,213,136,154,68,25,21,161,94,224,168,97,240,58,165,143,175,126,231,172,112,13,40,213,11,39,251,43,7,198,81,32,108,35,54,149,11,91,70,74,220,10,213,33,133,148,230,56,153,167,249,109,158,50,32,151,38,129,64,35,181,154,43,64,110,5,114,246,138,207,115,155,46,147,219,131,149,0,84,77,3,213,158,155,136,169,151,164,40,23,122,49,175,54,244,18,6,50,192,210,128,231,4,41,68,208,119,16,216,69,94,197,131,104,204,194,119,164,139,192,37,232,151,115,186,61,81,109,99,240,14,25,182,7,232,239,93,216,97,56,158,221,190,24,75,255,80,44,89,250,23,91,219,85,74,203,160,38,171,45,142,194,135,169,150,161,214,26,124,4,178,254,109,215,179,216,148,213,174,110,241,50,235,195,146,73,92,32,42,113,103,161,35,146,29,134,173,168,164,155,43,31,80,181,236,52,38,105,62,119,27,146,108,169,183,135,224,238,153,77,115,253,47,16,154,142,156,200,100,89,247,153,1,168,17,129,84,148,107,68,191,26,90,239,10,0,158,212,189,55,215,150,17,202,138,149,131,54,172,114,56,146,218,108,133,77,63,229,150,252,207,29,5,103,108,118,134,39,150,6,104,208,54,212,202,175,132,74,45,174,87,205,168,118,41,204,169,228,146,83,248,233,50,60,195,227,114,26,252,220,23,122,50,199,192,186,64,232,30,96,139,244,250,7,232,193,90,255,113,128,170,101,160,171,90,230,177,223,42,121,116,135,149,172,53,163,57,197,2,117,104,4,242,11,40,198,96,196,81,74,72,65,86,13,210,142,104,46,15,144,149,187,17,96,225,38,91,57,219,32,120,84,198,49,144,0,189,9,128,169,115,171,88,126,152,79,10,237,154,204,183,154,214,51,39,103,205,129,108,151,144,125,244,137,236,104,92,1,86,127,6,54,4,227,34,79,160,106,3,124,170,213,207,32,228,195,103,68,150,191,74,169,193,227,142,255,3,160,59,210,236,60,64,22,66,1,100,17,28,57,192,149,240,45,132,108,86,28,104,251,32,221,238,5,246,244,180,240,2,179,120,118,65,138,249,217,73,80,241,184,223,112,6,43,0,95,141,225,27,31,24,249,185,15,224,130,234,132,48,210,177,48,197,31,15,34,76,92,225,123,254,59,216,63,184,122,236,215,103,67,249,96,145,69,75,69,196,166,129,34,65,164,49,195,168,7,198,87,30,198,226,185,130,42,4,129,211,8,252,191,40,85,161,184,250,239,33,170,5,36,107,93,49,35,228,110,95,148,60,248,39,175,157,104,138,21,21,168,159,204,11,88,171,175,248,113,204,32,66,129,154,35,237,135,1,148,90,193,108,70,138,123,97,59,30,141,236,186,198,249,231,24,47,132,55,119,20,236,80,170,206,165,98,128,15,162,141,48,2,59,209,114,73,96,198,173,87,70,172,195,164,217,91,80,221,153,3,216,237,184,125,104,58,123,67,122,156,221,71,75,58,194,156,75,101,78,213,41,37,213,160,215,201,207,6,129,207,151,9,93,97,156,188,199,9,168,153,164,227,146,97,9,211,155,66,104,30,140,60,204,25,158,74,55,67,131,134,10,165,11,165,53,7,165,90,87,231,97,34,178,217,43,59,88,169,24,208,214,113,61,140,54,180,99,51,53,195,54,42,207,203,234,102,174,182,255,70,194,251,200,87,254,65,68,221,68,162,222,27,177,66,101,120,203,115,168,237,51,129,141,3,59,8,5,45,66,160,20,204,236,91,220,192,70,56,86,247,188,220,28,223,206,64,111,85,130,225,228,22,13,1,181,11,80,254,216,178,243,250,50,167,85,197,253,104,206,128,118,37,188,247,17,42,243,195,252,174,248,19,7,114,26,247,135,215,239,70,55,16,6,78,138,100,57,98,203,140,123,46,24,166,66,150,105,13,63,144,104,1,185,25,15,236,159,192,73,179,139,130,204,35,230,12,150,77,225,111,144,179,202,208,168,35,232,234,177,162,128,174,11,207,144,185,106,109,152,16,15,109,202,255,53,66,96,58,9,246,46,197,197,8,104,20,66,9,183,17,133,224,19,193,198,193,231,57,47,27,171,154,184,133,189,122,173,132,187,37,223,186,26,14,254,176,223,33,238,91,129,223,87,200,246,250,33,249,197,200,82,83,241,111,84,32,89,207,10,20,116,54,240,1,102,215,191,222,76,31,49,220,29,216,91,145,135,15,87,8,136,132,16,255,81,96,98,13,50,174,69,230,152,66,89,144,99,138,223,168,136,99,176,23,108,248,82,93,59,64,102,105,36,141,69,26,90,228,144,71,98,147,62,118,229,181,98,0,54,113,83,209,143,223,192,126,145,214,180,119,139,114,53,86,159,96,1,69,181,134,93,236,34,151,155,42,119,222,120,23,89,83,183,178,143,68,126,234,43,74,214,181,18,202,171,88,30,241,193,33,87,92,64,26,11,58,116,143,18,28,16,163,5,142,211,73,10,240,133,2,143,46,165,161,148,162,188,96,232,142,47,17,234,12,211,138,44,198,94,135,107,53,215,166,186,110,186,107,59,125,24,133,105,141,213,242,13,205,136,19,145,44,1,236,147,129,73,204,252,71,3,85,124,94,149,235,171,17,42,73,111,152,132,183,187,35,173,116,250,150,100,190,57,238,8,119,54,119,146,4,120,108,153,106,117,215,36,176,160,225,155,104,247,187,51,33,19,229,183,254,216,61,82,104,178,246,129,162,227,126,106,156,252,205,109,156,198,135,252,30,97,112,160,172,62,74,182,118,119,218,29,153,250,214,221,237,202,82,196,237,34,129,128,172,203,61,214,135,246,191,101,179,173,114,193,104,11,62,184,83,49,196,231,66,247,91,156,230,134,37,6,11,9,15,206,21,154,71,114,3,87,85,124,48,110,232,105,46,70,40,80,65,124,93,241,161,213,149,191,199,113,65,18,89,217,162,198,173,3,139,73,129,165,63,23,7,129,202,159,111,162,119,93,125,114,29,42,231,219,167,29,199,211,236,129,34,202,44,67,191,252,162,214,245,6,50,81,188,220,95,71,108,203,17,237,249,26,112,93,191,143,125,209,245,230,141,246,96,205,96,224,186,115,31,9,123,68,69,169,213,207,55,162,139,143,102,109,80,69,118,85,228,169,69,144,181,166,175,168,118,138,45,62,122,166,187,162,165,155,186,133,161,213,213,209,205,162,199,74,90,142,31,122,129,96,161,194,64,151,136,129,182,29,45,206,160,36,101,162,133,253,161,163,69,210,108,251,78,162,133,71,242,255,71,11,123,163,74,184,60,121,171,138,159,95,225,118,253,130,185,221,37,137,32,251,16,199,48,39,181,19,181,16,170,183,236,180,26,245,117,236,88,206,214,186,87,144,77,161,170,147,134,71,98,243,230,83,92,42,108,146,108,168,164,47,178,47,104,36,39,104,22,81,117,89,131,88,97,165,102,166,4,181,213,140,44,216,91,245,206,110,165,62,188,111,238,214,43,193,190,82,173,164,211,47,203,118,156,126,238,181,60,223,88,99,91,255,83,142,46,73,182,42,236,213,164,205,121,150,183,59,73,59,23,229,45,97,190,163,84,232,11,250,86,25,205,132,39,93,225,91,137,184,10,245,244,124,5,46,118,111,157,143,109,21,174,81,212,105,31,185,43,191,155,23,47,232,122,209,106,223,219,65,79,223,148,11,238,102,237,175,204,19,63,235,152,96,21,131,204,211,108,121,75,251,56,168,141,50,239,252,108,159,222,173,218,212,237,245,214,46,139,78,238,235,174,40,87,45,214,93,248,238,12,244,93,159,50,118,93,19,176,202,239,246,35,54,187,189,241,10,81,235,172,246,84,230,236,4,198,195,149,41,91,158,231,211,52,199,225,233,12,199,127,158,70,249,249,103,104,135,100,71,43,41,232,67,163,124,76,51,130,219,23,222,164,47,82,159,84,109,133,20,217,135,122,159,191,181,173,236,17,189,113,161,209,253,186,66,226,107,35,111,222,186,107,58,115,185,225,19,64,75,188,238,143,0,119,7,110,5,235,47,154,237,233,78,112,97,160,103,192,238,53,41,238,210,4,19,153,85,233,188,77,167,125,212,253,254,139,39,123,59,216,160,61,5,110,160,124,135,9,212,147,149,176,167,242,79,85,91,117,0,172,140,48,60,33,135,116,90,119,129,189,204,159,60,11,76,190,81,145,18,148,164,140,49,210,171,244,209,1,255,107,149,122,171,203,147,206,142,94,128,37,83,30,108,242,101,186,124,204,201,141,252,98,12,202,229,90,153,84,221,138,81,168,232,27,14,228,221,184,184,21,175,249,220,234,15,208,44,41,6,245,141,97,18,224,253,39,17,111,168,169,109,1,57,112,211,69,40,110,130,183,185,194,72,195,76,147,111,121,226,244,87,57,143,215,222,228,201,86,183,241,241,127,217,231,215,210,134,64,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOAuthDisabledMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOAuthDisabledMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ba685975-464c-6850-99f9-1f1fa441091e"),
				Name = "OAuthDisabledMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83"),
				ModifiedInSchemaUId = new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83"));
		}

		#endregion

	}

	#endregion

}

