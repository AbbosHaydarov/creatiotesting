﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationSearchSchema

	/// <exclude/>
	public class DeduplicationSearchSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationSearchSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationSearchSchema(DeduplicationSearchSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04");
			Name = "DeduplicationSearch";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,90,109,111,220,56,14,254,156,3,238,63,232,102,191,56,192,192,217,207,109,102,138,52,47,197,244,146,38,155,100,111,23,87,20,133,99,107,18,111,61,246,84,178,147,166,109,254,251,145,34,101,75,126,155,201,118,23,184,160,168,199,22,69,82,20,73,61,162,148,71,43,169,215,81,44,197,181,84,42,210,197,178,12,15,139,124,153,222,86,42,42,211,34,23,223,254,249,143,157,74,167,249,173,184,122,212,165,92,189,108,189,3,121,150,201,24,105,117,248,70,230,82,165,113,135,230,40,42,163,230,163,43,74,201,161,239,225,209,235,193,166,227,188,76,203,84,234,126,130,213,170,200,155,150,119,242,161,4,221,176,233,173,118,27,88,183,211,52,255,220,249,248,251,42,27,20,126,18,197,101,161,60,233,220,235,178,2,189,86,50,188,2,35,68,89,250,213,88,112,212,96,231,55,127,192,207,179,34,145,195,242,188,249,24,164,186,138,239,100,82,101,82,53,20,191,84,145,42,191,182,223,195,197,106,237,8,115,62,134,215,42,189,189,149,74,247,183,30,70,153,204,147,8,5,64,251,79,74,222,162,127,92,149,170,138,203,23,226,42,93,165,89,164,174,100,164,226,59,48,223,89,84,198,119,134,114,111,111,79,236,235,106,181,138,212,227,156,223,143,164,142,85,122,35,181,88,33,29,138,146,56,167,143,34,46,178,106,149,139,178,16,177,146,81,41,133,54,28,197,125,148,85,82,135,150,223,158,195,112,93,221,100,105,44,180,209,164,95,17,116,99,160,236,232,98,62,156,89,21,20,216,79,44,11,197,74,160,176,174,180,150,184,75,236,195,220,187,236,205,151,67,26,82,14,177,102,88,246,240,116,152,162,34,212,227,29,116,48,241,7,127,183,178,196,89,129,63,109,127,61,141,10,69,127,88,69,207,17,74,61,126,72,232,165,140,11,149,136,242,113,45,69,154,139,68,150,81,154,109,18,255,166,74,19,113,13,93,22,201,102,193,79,35,243,120,85,84,10,50,153,110,141,124,108,6,205,184,77,183,102,244,47,71,68,128,223,150,105,78,153,241,185,114,156,190,219,9,59,118,35,66,139,135,180,188,163,112,49,142,58,46,243,40,53,25,6,190,238,147,248,169,241,212,57,51,37,7,211,108,239,218,220,214,218,100,101,250,255,39,8,122,138,117,47,238,15,179,72,235,23,226,168,90,131,56,136,83,77,1,119,9,203,9,36,54,57,18,249,9,119,65,46,144,74,241,161,184,87,111,120,191,199,213,3,146,96,169,128,250,67,19,239,49,106,48,168,192,104,196,3,81,149,149,3,22,52,242,206,228,234,70,170,192,68,195,76,76,116,21,199,82,235,201,46,202,183,10,220,20,69,38,174,168,101,220,146,253,90,44,242,101,33,96,253,213,209,173,124,134,46,220,195,215,133,125,236,140,218,254,140,54,103,178,188,43,18,141,182,169,231,98,75,141,236,244,249,42,245,184,32,61,231,181,140,17,61,183,243,62,215,153,104,254,7,29,15,215,48,185,130,85,198,174,40,197,82,216,222,227,11,11,59,90,87,150,245,177,90,43,24,83,25,229,37,104,118,161,210,123,224,75,237,107,122,129,72,134,118,59,85,180,180,190,45,110,222,168,162,90,163,25,61,9,147,151,35,125,237,98,159,144,30,77,12,0,59,59,41,131,52,200,121,103,103,91,222,148,170,52,114,196,24,132,16,252,126,16,199,5,32,157,81,13,189,177,128,86,23,170,192,48,177,202,121,205,7,198,79,152,98,124,220,180,182,211,50,163,175,245,250,34,42,75,169,114,100,89,234,245,199,147,52,79,190,253,252,228,147,141,114,100,131,57,124,176,127,143,197,204,60,251,206,88,207,251,73,42,179,100,104,210,127,213,82,129,229,114,130,124,226,99,229,189,183,116,91,144,45,78,139,248,147,84,226,99,102,158,27,164,131,225,214,82,33,28,70,13,138,18,24,203,196,178,229,215,22,99,126,212,209,103,215,93,37,203,10,172,192,114,197,171,87,34,176,191,103,34,151,15,254,180,186,44,131,214,184,118,119,235,101,155,226,218,138,104,248,25,68,231,80,61,141,15,147,243,211,128,149,121,58,223,200,242,52,254,122,101,94,254,131,252,3,110,200,226,175,56,207,187,172,134,253,90,196,6,167,223,100,146,250,176,127,82,115,120,82,40,88,111,131,201,105,155,76,135,224,37,161,17,48,153,214,188,105,44,247,145,234,242,101,243,117,24,5,108,20,223,120,225,111,133,250,100,182,101,33,100,74,130,39,176,229,128,196,62,109,133,14,121,42,234,208,55,18,214,136,7,107,236,13,138,116,72,105,32,68,155,46,69,96,8,195,133,126,87,101,217,185,58,94,173,203,199,96,215,90,110,103,152,13,24,255,16,150,213,74,73,50,189,217,13,70,89,107,8,225,145,92,50,217,84,44,163,76,75,207,85,216,5,27,231,120,242,39,26,16,253,49,231,241,67,179,65,104,227,253,5,236,177,236,172,19,68,67,83,216,181,71,172,35,5,125,27,0,54,165,81,25,16,138,184,117,145,212,164,4,188,168,119,97,54,106,164,214,20,149,56,42,226,202,104,241,101,149,209,14,205,90,200,209,144,55,51,179,134,40,36,165,153,32,152,164,160,237,132,13,224,116,148,244,116,32,249,8,143,102,148,195,156,46,90,195,30,227,215,54,209,48,87,70,237,35,188,200,164,195,28,156,157,206,8,151,102,38,134,57,25,159,219,204,132,130,150,185,116,204,28,46,32,6,213,181,252,82,98,22,112,81,122,67,221,54,165,215,167,109,59,175,103,51,88,175,79,51,58,143,218,104,234,17,82,100,138,25,36,19,8,205,93,241,202,60,197,11,114,203,240,186,224,164,226,143,142,38,201,103,68,211,130,156,208,241,67,19,227,14,63,106,238,48,228,109,241,193,122,13,57,250,240,46,205,146,160,99,193,141,164,109,243,109,236,64,250,111,36,107,140,187,145,212,88,150,169,56,223,16,113,95,194,49,40,255,240,78,198,159,142,191,164,186,212,61,144,171,155,110,108,46,88,212,101,25,211,72,191,102,2,116,170,27,96,98,16,52,198,60,249,204,234,143,26,200,249,107,145,143,87,32,85,181,237,136,203,15,116,254,183,124,228,53,231,173,121,9,152,225,180,133,59,185,151,25,100,170,105,132,236,250,164,157,51,114,228,1,172,124,195,217,78,47,183,88,194,13,62,198,170,73,161,112,29,55,232,122,100,71,226,144,15,108,70,204,23,8,185,104,101,182,225,179,137,191,142,78,230,214,182,8,246,247,181,4,240,167,228,114,54,241,49,217,100,111,30,238,239,25,54,222,22,186,187,208,6,45,48,215,194,60,60,233,173,213,28,204,217,193,124,207,64,59,155,172,180,200,239,139,79,80,72,227,93,205,154,96,244,182,6,115,214,142,185,91,50,114,237,97,58,209,116,235,198,162,142,57,135,246,224,96,88,220,218,195,98,175,77,89,205,87,81,200,47,50,174,12,222,217,223,179,236,29,251,223,167,170,172,162,108,120,135,143,104,159,202,25,13,201,129,126,204,227,225,120,28,228,69,106,90,148,59,64,21,212,32,200,238,179,103,61,136,115,66,21,232,99,165,10,197,116,147,93,66,56,13,198,250,23,193,102,40,170,230,199,198,12,50,240,252,205,248,190,14,73,254,57,224,123,243,213,128,147,102,80,181,58,164,125,56,170,213,2,119,88,183,64,169,107,165,184,198,198,145,76,76,60,216,254,131,185,200,66,174,231,236,253,56,133,25,239,147,192,87,219,57,233,86,19,8,147,205,155,89,249,70,187,94,246,103,225,106,36,158,166,53,141,99,78,64,206,91,153,93,60,185,19,232,165,111,251,107,177,90,201,36,5,167,225,193,224,186,48,144,116,167,174,73,72,175,225,29,0,49,104,183,31,86,10,151,81,204,71,76,209,88,172,78,208,198,41,108,129,106,38,32,151,242,34,179,141,191,112,191,150,179,116,125,101,180,34,203,182,209,2,76,153,22,9,88,57,27,44,191,108,147,174,98,5,129,245,101,141,94,108,242,123,179,188,98,11,100,20,219,212,151,208,239,11,192,248,125,73,227,245,163,229,99,51,135,47,199,58,216,165,92,21,247,178,166,221,253,81,119,117,189,117,58,80,120,169,253,246,207,184,173,231,181,11,112,191,35,83,145,199,136,110,163,16,2,203,142,239,146,216,77,149,38,214,174,229,223,244,113,164,6,196,20,27,188,190,159,168,227,250,68,214,241,255,67,152,67,62,209,194,218,31,184,191,249,205,19,212,106,13,54,14,180,29,195,36,181,229,40,36,153,37,133,215,112,24,248,223,34,199,0,179,63,177,230,27,254,90,198,62,225,89,170,151,169,130,70,194,59,4,26,186,31,67,71,233,240,4,218,206,97,33,126,87,60,244,100,37,187,76,215,233,137,211,209,212,154,97,119,99,240,146,183,215,192,194,66,194,241,115,7,19,99,237,56,97,135,247,20,36,26,212,234,185,150,223,172,249,133,84,0,55,86,141,234,84,34,128,172,101,10,130,0,199,12,58,0,92,9,149,49,147,138,19,168,70,252,229,144,201,237,68,162,33,114,231,124,70,86,229,233,103,216,203,165,9,158,123,46,83,176,200,104,127,26,137,73,205,122,50,167,39,30,146,46,33,157,181,199,55,12,222,122,113,214,41,192,247,125,220,6,206,77,114,228,122,10,229,200,190,66,138,41,149,216,241,248,181,16,87,75,59,235,14,123,237,213,101,109,77,172,110,183,9,149,101,66,65,183,23,118,12,21,129,7,54,67,52,205,23,118,150,89,234,149,255,181,93,190,156,90,233,181,74,30,121,248,27,156,197,93,216,132,19,52,179,59,173,13,179,93,71,111,90,97,0,206,107,120,14,160,80,129,117,153,19,57,109,112,244,154,240,34,192,233,228,166,254,57,235,0,132,227,92,131,188,163,215,205,39,167,134,199,188,208,60,144,246,19,147,20,219,154,50,44,189,52,237,65,35,171,225,178,243,0,155,106,41,2,98,1,17,29,37,142,12,174,169,193,191,25,11,49,5,194,166,8,195,147,62,105,202,67,104,47,111,114,195,131,36,9,82,107,75,11,75,249,225,213,11,253,126,27,51,4,104,162,5,31,226,212,219,16,56,178,134,3,185,165,42,86,80,220,188,253,127,219,64,25,229,254,226,29,20,152,1,23,164,191,111,191,212,132,161,212,159,153,154,50,11,217,234,151,74,170,199,118,240,133,46,197,89,148,3,252,84,94,225,91,162,47,210,6,170,174,228,233,207,33,28,12,224,60,25,158,228,103,80,196,62,200,30,162,71,208,11,175,220,120,24,24,123,128,123,17,97,128,111,151,69,193,117,41,244,84,230,214,148,149,192,183,169,103,103,0,124,193,35,46,240,136,17,78,91,206,1,144,113,225,215,151,130,71,104,247,128,80,12,34,178,17,6,228,147,13,156,83,221,236,222,134,88,47,28,26,215,42,39,105,134,160,200,132,18,190,19,208,163,175,94,54,210,1,125,132,237,43,184,110,10,119,165,176,242,22,30,127,6,23,98,180,51,113,21,100,216,138,83,74,208,246,253,7,241,205,219,114,237,254,93,106,212,16,183,43,127,203,237,156,63,151,205,149,44,180,170,243,70,86,6,111,104,211,117,206,187,250,235,104,155,234,134,237,5,11,75,3,158,6,225,65,238,30,190,240,149,16,190,43,101,180,107,104,223,255,252,129,19,37,171,209,56,4,146,154,62,56,22,180,103,226,38,98,36,159,7,93,39,51,240,122,87,124,255,238,87,249,32,45,192,0,16,209,186,46,111,235,239,35,114,108,183,121,208,9,21,18,85,23,36,6,119,174,182,173,78,68,131,219,45,190,107,208,108,183,118,234,133,105,114,26,233,146,162,15,58,161,86,19,246,172,102,104,120,205,193,104,109,188,207,222,232,147,174,230,166,121,218,129,246,84,235,129,245,199,242,132,146,131,23,156,83,129,23,17,41,21,148,13,107,186,11,232,77,195,46,215,29,236,22,238,9,14,59,234,91,19,198,89,236,196,52,163,28,51,222,143,88,239,153,195,64,169,181,250,86,255,190,149,123,203,82,2,229,11,241,251,217,41,86,83,19,183,158,216,134,191,91,174,220,228,168,147,57,197,212,56,252,134,67,37,115,75,112,50,183,55,167,234,123,139,230,190,96,223,85,197,65,4,128,99,24,81,127,116,41,119,209,54,153,4,190,120,71,160,84,190,241,18,197,116,224,82,164,29,149,115,114,217,61,214,100,31,113,218,236,178,222,57,232,212,155,143,223,234,165,169,161,115,15,104,152,136,105,192,72,50,2,61,13,80,141,13,53,158,238,226,213,66,171,58,99,5,158,149,218,91,123,199,11,247,115,1,174,154,75,158,51,135,157,123,252,93,95,12,0,192,234,29,77,114,86,99,120,192,226,48,201,189,126,52,216,192,97,135,71,36,76,97,56,55,7,123,59,124,138,236,156,68,122,9,211,233,20,248,26,216,204,216,119,182,124,56,124,12,110,238,9,58,103,221,141,217,122,47,35,218,132,101,186,209,177,27,108,104,240,165,209,100,234,106,111,24,242,233,55,107,200,51,216,51,171,125,199,252,117,247,145,51,145,190,139,96,240,237,127,115,173,137,34,187,46,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCommonErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateInProgressMessageLocalizableString());
			LocalizableStrings.Add(CreateSuccessMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCommonErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("60c70870-5ccd-47cf-a5a0-494cc80eb062"),
				Name = "CommonErrorMessage",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04"),
				ModifiedInSchemaUId = new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInProgressMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8edc83dd-0fe2-4d3c-b7be-e5e503cff6ff"),
				Name = "InProgressMessage",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04"),
				ModifiedInSchemaUId = new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c952b70f-de43-4988-85a3-eff18ce8de9a"),
				Name = "SuccessMessage",
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7"),
				CreatedInSchemaUId = new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04"),
				ModifiedInSchemaUId = new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0b83d87-a9b0-4deb-9f1d-a591aa9f4b04"));
		}

		#endregion

	}

	#endregion

}

