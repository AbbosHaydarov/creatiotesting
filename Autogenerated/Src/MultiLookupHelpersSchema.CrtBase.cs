﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiLookupHelpersSchema

	/// <exclude/>
	public class MultiLookupHelpersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiLookupHelpersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiLookupHelpersSchema(MultiLookupHelpersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7");
			Name = "MultiLookupHelpers";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,87,91,111,219,54,20,126,118,129,254,135,51,7,104,101,212,83,218,189,108,107,235,14,169,227,182,6,154,45,139,211,229,161,232,3,45,29,59,108,40,81,37,169,46,94,224,255,190,195,139,36,250,150,13,219,48,33,112,44,242,92,190,115,63,46,89,129,186,98,25,194,37,42,197,180,92,152,116,44,203,5,95,214,138,25,46,203,135,15,238,30,62,232,213,154,151,75,152,173,180,193,226,197,214,59,209,11,129,153,37,214,233,91,44,81,241,108,135,230,18,111,77,119,24,235,42,10,89,238,191,81,120,232,60,157,148,134,27,142,122,31,193,135,105,122,133,115,50,194,40,41,180,181,198,125,33,82,34,174,234,185,224,25,104,67,198,101,144,9,166,53,156,213,194,240,247,82,222,212,213,59,20,21,42,77,132,214,234,222,145,194,37,153,5,227,90,27,89,160,242,164,194,145,78,114,110,96,82,212,130,25,169,156,236,222,241,241,180,168,4,22,88,26,13,11,46,12,185,130,160,177,50,7,86,27,249,173,70,235,39,88,72,5,39,89,38,235,210,56,33,246,222,162,100,153,127,55,18,232,43,48,13,69,167,206,202,223,4,255,85,242,188,69,182,5,172,193,149,120,179,188,154,78,229,208,74,235,69,119,89,167,222,223,125,208,168,8,83,233,227,10,245,198,235,0,156,119,122,17,87,122,174,176,98,10,189,204,55,206,118,120,50,130,68,99,153,163,26,2,14,96,244,42,240,245,48,245,20,20,29,129,76,37,3,27,71,122,190,50,5,222,73,152,7,15,253,50,255,108,125,54,138,225,167,191,49,81,99,196,19,238,166,57,209,237,231,255,102,4,101,45,132,103,129,173,167,247,19,36,111,107,158,15,246,51,31,96,122,14,150,39,157,20,149,89,5,44,124,1,73,132,101,20,81,52,62,235,245,20,154,90,185,148,167,103,189,237,144,147,60,79,74,252,29,78,185,115,53,83,171,151,218,216,52,26,130,116,104,90,39,246,238,250,153,44,200,233,92,203,242,114,85,97,127,8,94,202,120,227,56,157,124,169,153,88,15,91,46,129,11,51,185,173,20,106,77,26,168,122,235,162,60,103,230,154,248,251,193,240,126,68,78,177,63,229,186,18,108,229,220,78,84,11,38,52,70,20,138,47,175,35,137,231,76,81,87,33,28,142,94,19,131,53,200,163,255,248,9,238,90,15,173,131,245,235,16,255,181,175,209,205,196,58,249,204,110,39,95,109,73,165,227,107,86,46,201,30,251,118,56,185,182,19,98,39,74,17,193,207,4,212,230,140,243,240,14,81,193,74,182,164,60,30,109,229,191,111,63,171,89,118,141,5,59,243,68,17,219,151,26,213,138,152,172,213,49,229,175,246,60,9,66,35,95,199,217,95,41,94,80,204,125,80,2,58,39,207,38,134,63,77,250,211,188,63,72,237,229,46,99,136,212,253,252,246,124,83,130,39,137,115,208,159,140,21,50,131,254,252,138,155,235,54,180,58,9,209,63,156,113,77,126,244,63,134,230,246,60,24,252,124,154,127,74,201,134,134,32,212,94,28,116,151,57,131,216,49,24,58,126,107,207,91,52,222,185,221,248,73,182,218,84,84,149,13,59,141,3,66,0,175,224,105,87,144,113,178,52,116,31,159,126,178,26,172,53,193,109,14,210,75,11,245,85,178,19,165,70,85,35,203,123,62,156,245,254,74,168,79,191,86,236,78,12,27,233,107,64,42,188,123,27,73,220,37,103,181,174,168,64,186,2,106,251,236,6,21,26,135,226,164,204,237,144,238,250,215,48,46,146,125,156,23,168,235,2,119,197,219,50,118,128,220,8,37,4,126,138,218,183,189,67,117,170,47,240,75,205,21,230,158,37,140,185,156,122,241,146,178,207,15,58,202,201,89,166,120,101,78,195,113,226,189,6,218,157,90,213,126,4,147,61,26,100,137,32,23,96,97,106,80,65,122,10,211,210,216,142,145,219,17,59,71,200,24,101,78,14,11,37,11,186,34,139,14,12,217,14,224,5,65,167,125,70,121,40,135,166,43,220,55,89,207,168,73,82,3,56,103,37,10,40,162,151,33,156,50,195,102,178,86,180,141,229,237,215,225,174,233,192,154,147,38,137,99,57,233,123,94,222,116,131,196,190,249,141,174,73,28,123,226,146,61,14,230,88,112,138,225,244,52,20,229,152,85,110,240,143,34,36,169,111,99,169,79,76,187,235,153,215,43,155,28,73,215,202,210,192,232,19,33,36,196,63,67,23,247,131,127,135,46,244,159,3,232,90,103,38,27,56,27,149,240,4,250,41,245,150,199,130,128,101,148,26,55,143,105,2,214,165,239,56,20,30,123,62,205,7,119,253,80,150,96,57,108,203,202,138,138,16,78,110,77,186,68,51,46,170,36,80,190,216,160,180,221,201,82,62,122,100,25,210,133,204,106,77,97,221,160,105,47,168,196,214,235,33,152,107,174,7,97,110,132,58,59,62,166,42,230,228,14,4,30,213,211,118,62,207,165,20,81,62,55,60,255,117,38,255,173,245,49,218,150,186,166,239,103,135,78,226,205,201,186,102,123,56,236,161,107,59,186,91,35,231,97,2,207,92,155,120,93,115,65,171,66,219,1,143,143,143,142,142,134,64,31,246,105,254,111,188,193,17,92,73,117,227,127,29,141,47,158,125,255,221,15,63,62,235,20,208,178,227,242,110,70,107,54,25,190,187,36,180,204,182,81,198,164,241,26,34,80,153,224,199,128,247,189,164,182,196,255,96,115,129,30,122,178,165,169,25,155,189,254,238,15,23,187,194,237,8,160,106,139,212,120,247,109,44,29,49,138,174,180,254,15,48,65,219,22,38,61,79,79,42,59,186,222,72,85,48,26,73,17,7,201,188,235,83,77,236,235,93,182,84,214,86,171,163,216,215,63,60,69,163,103,163,222,169,35,5,21,27,250,2,194,33,37,84,122,41,131,19,6,67,8,215,110,221,185,98,170,164,227,70,172,159,203,126,75,14,19,209,125,134,115,163,194,111,151,125,19,146,206,232,239,79,162,197,92,225,150,15,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAlertMessageLocalizableString());
			LocalizableStrings.Add(CreateAlertMessageCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAlertMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d05cfcd7-cc35-44a8-bc05-e3aabc4cd1c5"),
				Name = "AlertMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7"),
				ModifiedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAlertMessageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5ab4d66e-8007-4ea2-ad2f-237ff275a15d"),
				Name = "AlertMessageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7"),
				ModifiedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7"));
		}

		#endregion

	}

	#endregion

}

