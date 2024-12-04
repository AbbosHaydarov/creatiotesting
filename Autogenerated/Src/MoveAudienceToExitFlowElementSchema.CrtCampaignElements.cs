﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MoveAudienceToExitFlowElementSchema

	/// <exclude/>
	public class MoveAudienceToExitFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MoveAudienceToExitFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MoveAudienceToExitFlowElementSchema(MoveAudienceToExitFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149");
			Name = "MoveAudienceToExitFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,89,89,111,220,54,16,126,222,0,249,15,204,6,72,181,128,33,23,125,42,124,194,118,236,196,64,156,195,107,199,15,69,81,208,210,236,46,17,73,84,72,42,182,27,228,191,119,120,73,162,150,187,94,7,40,218,60,216,22,57,23,103,190,25,14,39,164,162,37,200,154,102,64,174,64,8,42,249,76,165,39,188,154,177,121,35,168,98,188,122,254,236,251,243,103,163,70,178,106,78,166,15,82,65,185,59,248,70,250,162,128,76,19,203,244,13,84,32,88,182,68,115,5,247,170,91,236,235,42,75,94,197,119,122,86,164,39,180,172,41,155,87,167,5,148,80,41,25,231,16,208,18,174,36,120,125,188,114,235,163,224,25,72,45,27,41,94,10,152,163,102,114,82,80,41,119,200,5,255,6,71,77,206,160,202,224,138,159,222,51,117,86,240,59,103,142,97,216,222,222,38,123,178,41,75,42,30,14,220,247,233,61,100,141,162,183,5,144,204,25,70,192,242,144,187,5,203,22,164,68,185,146,100,188,82,52,83,146,40,78,178,70,8,189,223,50,48,237,64,175,96,187,167,161,110,110,11,150,145,76,91,184,222,64,178,67,188,99,2,179,71,24,92,252,217,29,22,99,168,40,250,119,135,124,52,194,237,118,45,216,55,170,240,12,122,155,72,37,180,243,78,172,205,87,250,116,239,17,70,100,159,104,52,241,89,226,118,38,214,145,163,151,80,229,86,126,168,12,221,93,131,80,12,180,54,171,33,84,247,166,97,57,249,72,145,36,99,53,90,53,85,84,53,242,60,39,251,7,228,92,250,3,189,225,180,208,92,163,195,246,140,237,49,90,56,244,164,92,2,205,22,144,107,54,47,208,176,239,108,198,174,61,11,185,231,220,13,45,158,98,112,51,213,186,134,235,160,184,181,239,100,14,106,151,72,253,227,199,19,28,211,11,195,16,97,102,225,146,115,69,102,188,200,65,16,137,7,43,169,9,131,6,204,50,98,60,100,92,8,207,12,219,212,112,217,16,30,12,98,104,41,124,36,163,6,92,87,236,107,3,132,229,136,40,54,99,104,6,159,17,181,0,103,212,122,67,76,136,173,146,75,200,184,200,49,186,17,79,69,21,159,21,116,238,178,136,85,57,203,48,0,152,64,11,170,218,20,99,152,89,46,130,191,72,50,199,136,19,46,72,197,213,122,163,110,57,47,6,0,123,154,81,152,197,222,34,107,144,206,114,66,93,118,106,179,110,31,200,140,21,234,49,247,24,75,222,82,121,102,104,55,55,194,146,163,25,129,226,205,48,177,82,149,7,185,13,215,91,40,16,164,228,175,89,239,107,29,76,142,176,144,153,180,66,7,56,128,236,73,192,154,34,96,182,63,238,203,28,111,31,164,232,126,98,107,244,12,35,118,193,179,47,164,110,68,205,37,200,245,167,8,140,11,62,244,61,54,26,225,169,52,202,3,179,201,225,33,73,194,21,172,101,112,23,240,39,19,157,5,40,65,198,36,236,147,111,180,104,192,80,60,146,221,23,160,22,60,95,85,243,206,79,171,166,4,161,139,234,158,78,142,3,242,6,212,81,129,69,27,242,165,82,8,50,153,160,45,198,172,72,157,76,79,191,54,180,144,201,207,150,197,137,17,140,117,21,125,241,199,159,206,129,248,111,35,121,237,159,10,163,232,37,110,61,73,68,88,106,29,43,122,87,255,218,241,70,145,159,183,134,252,136,151,239,243,138,41,87,255,166,205,173,93,76,220,158,141,186,253,152,56,151,124,163,88,122,205,74,191,148,6,164,233,148,55,34,131,211,251,90,96,135,161,59,154,142,116,183,21,226,218,128,243,28,91,170,166,172,80,198,178,216,165,91,150,28,146,241,121,62,198,43,126,236,150,240,203,202,100,51,146,4,86,96,41,65,154,156,233,158,202,91,111,52,195,61,147,218,53,237,174,28,30,160,221,73,79,10,94,193,5,36,147,244,70,208,250,184,192,228,76,92,110,140,86,178,0,21,113,162,155,5,8,72,150,245,59,226,31,67,231,180,17,105,73,93,178,126,106,64,60,180,139,73,248,121,245,80,131,77,135,246,216,239,96,166,186,120,132,66,180,247,187,189,100,24,133,173,97,164,108,166,104,56,225,175,149,134,166,151,108,190,232,233,148,233,81,158,39,17,180,154,158,106,171,31,79,231,141,192,115,200,220,29,119,165,210,45,98,123,236,244,29,159,227,141,84,124,192,114,101,123,234,163,42,119,98,5,168,70,84,65,188,251,149,108,216,221,8,192,47,223,107,186,244,88,174,91,245,114,181,218,242,34,134,214,246,51,201,223,86,142,212,198,197,105,185,150,32,240,100,149,125,110,184,250,52,74,109,16,214,121,82,187,208,82,167,103,130,151,43,73,39,233,145,92,189,233,36,88,200,174,139,155,219,234,180,142,210,115,105,224,151,88,91,83,228,66,32,225,77,219,202,193,122,235,21,96,100,54,18,143,15,131,80,197,123,174,30,211,98,120,54,213,228,43,101,79,71,181,36,91,38,145,80,7,26,38,41,150,114,169,228,18,74,39,132,74,23,91,139,196,48,248,233,180,134,140,205,30,222,243,119,88,100,222,50,44,238,73,8,217,144,126,13,104,245,45,26,208,154,76,79,60,240,116,165,140,117,237,186,220,54,69,87,52,156,90,189,246,88,125,66,228,70,47,146,136,26,119,38,45,37,226,74,20,244,72,15,16,184,36,154,158,209,100,92,138,70,204,127,215,117,110,222,98,128,133,43,43,154,188,149,108,29,104,126,182,97,48,95,253,100,110,12,183,37,178,153,108,229,13,50,25,139,212,250,156,27,165,83,80,201,16,249,186,182,109,132,115,199,222,194,57,194,24,233,159,150,184,161,190,224,185,126,227,228,31,170,152,140,215,120,178,43,134,143,175,107,149,189,231,119,17,126,172,197,117,129,180,81,19,102,216,172,193,36,172,50,129,103,187,27,213,36,142,117,165,13,126,207,209,233,13,83,11,155,44,218,225,151,252,206,103,79,219,195,58,168,244,152,214,167,142,123,40,90,44,245,115,38,124,186,233,34,87,214,10,211,10,105,200,163,25,99,175,85,196,69,191,207,78,7,234,62,255,150,12,39,13,91,75,15,87,191,226,13,241,125,230,224,190,232,186,34,25,79,111,247,6,194,177,16,23,23,120,73,211,185,25,107,160,23,209,133,180,96,127,107,19,166,134,104,128,224,244,134,139,47,102,146,150,94,130,52,205,222,84,113,129,2,188,45,227,181,19,26,196,195,120,73,135,76,95,131,65,75,240,26,119,134,165,159,245,139,195,119,6,35,181,16,252,206,152,58,152,149,29,11,254,5,42,132,38,197,4,134,218,116,11,246,156,233,25,23,37,85,73,255,184,58,19,13,141,126,20,105,215,122,200,216,176,185,104,90,247,61,130,25,243,144,140,96,198,41,199,219,10,93,255,65,220,44,176,203,159,106,207,37,150,101,242,255,13,135,245,165,53,243,191,12,131,205,30,42,178,133,22,136,62,57,173,50,172,76,40,235,250,234,236,119,157,66,199,15,56,13,241,14,237,112,255,34,72,181,147,5,100,95,166,173,156,118,208,16,201,184,78,219,22,25,100,213,38,151,35,200,175,145,60,127,253,128,111,25,150,217,229,211,233,167,167,233,237,78,101,164,111,118,83,35,105,138,114,142,242,146,85,166,29,55,15,29,93,120,131,202,168,201,208,192,126,171,16,211,190,18,252,145,75,222,60,213,123,195,156,195,72,146,236,44,23,219,221,141,167,9,92,33,3,228,107,102,48,118,28,173,231,205,110,198,60,67,196,251,105,217,138,185,138,89,193,246,129,150,230,225,185,63,214,93,3,78,243,199,7,87,56,194,1,35,81,27,226,150,211,189,109,67,220,241,90,143,202,131,19,222,160,70,28,253,180,131,237,94,83,34,221,32,239,14,239,60,82,219,57,60,228,122,76,230,77,245,86,238,109,123,129,214,243,238,212,4,253,44,4,14,33,113,202,164,200,148,206,192,29,54,113,83,125,251,105,159,152,218,80,111,176,7,76,180,251,91,25,202,14,123,49,190,23,22,139,228,213,171,216,40,56,254,10,119,192,187,165,18,210,190,249,222,204,72,21,254,181,143,193,248,112,216,186,42,152,188,245,166,110,6,216,56,110,35,119,216,49,104,135,248,183,63,78,14,245,160,172,157,88,226,183,11,202,58,148,248,192,216,118,207,200,180,67,206,78,80,167,227,241,64,90,49,189,198,221,183,236,152,70,171,218,249,221,159,69,191,53,183,181,243,171,209,221,179,118,195,228,48,2,156,165,99,231,8,61,193,212,255,135,19,184,243,182,7,243,127,45,103,36,118,156,27,38,12,38,70,209,98,174,215,212,71,122,122,235,27,147,27,209,39,65,192,23,84,85,195,137,111,65,171,37,40,161,131,250,102,87,195,69,92,251,7,210,249,164,124,176,28,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDeletedContactFolderMessageLocalizableString());
			LocalizableStrings.Add(CreateBrokenFilterMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDeletedContactFolderMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54e63929-cf70-48a2-aca7-039392c5e3a9"),
				Name = "DeletedContactFolderMessage",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149"),
				ModifiedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBrokenFilterMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5ebb106e-ae06-b237-e049-c3729c30a5c6"),
				Name = "BrokenFilterMessage",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149"),
				ModifiedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149"));
		}

		#endregion

	}

	#endregion

}

