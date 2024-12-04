namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GeneratedWebFormServiceSchema

	/// <exclude/>
	public class GeneratedWebFormServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GeneratedWebFormServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GeneratedWebFormServiceSchema(GeneratedWebFormServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("177ef661-e736-4802-9520-b1d553edb13c");
			Name = "GeneratedWebFormService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,89,91,83,219,72,22,126,246,84,205,127,232,40,251,32,239,26,145,153,167,169,16,152,114,128,36,204,4,76,197,102,243,192,82,41,97,181,77,47,178,228,109,181,96,60,20,255,125,190,211,23,91,45,201,198,144,217,23,219,106,157,123,159,243,157,211,237,44,158,241,98,30,143,57,27,113,41,227,34,159,168,232,48,207,38,98,90,202,88,137,60,139,62,242,140,227,39,79,190,242,235,15,185,156,13,185,188,19,99,254,227,15,15,63,254,208,41,11,145,77,217,112,81,40,62,219,171,61,71,31,211,252,58,78,197,159,90,78,227,237,201,160,177,116,198,85,99,109,196,255,104,46,90,27,78,243,132,167,27,95,70,48,122,51,65,127,172,196,93,205,194,106,40,102,51,196,224,183,98,221,107,201,215,173,71,199,153,18,74,240,162,141,0,102,69,159,148,154,71,253,235,66,201,24,54,228,25,17,130,244,210,154,135,93,208,111,174,104,173,95,204,17,28,88,51,135,169,215,34,21,106,241,133,255,175,20,146,207,120,166,138,176,250,64,126,177,125,246,4,11,81,69,118,33,233,146,146,121,121,157,138,49,27,167,113,81,176,181,187,222,161,109,239,188,150,124,10,147,25,140,132,253,229,88,229,178,120,203,206,181,4,237,133,147,182,70,78,216,101,90,78,7,220,20,25,201,39,136,13,151,176,59,43,83,189,167,157,142,152,176,144,130,68,145,64,22,68,135,37,72,50,165,173,230,133,138,46,100,250,197,241,189,50,140,78,108,167,34,112,75,17,180,21,121,90,42,126,33,133,209,255,168,63,239,98,201,238,144,198,73,12,39,201,62,126,223,240,234,223,238,125,232,244,246,216,69,193,37,212,102,92,111,110,119,111,41,44,225,147,184,76,21,120,74,126,26,103,241,148,59,177,159,121,156,28,53,223,134,150,249,52,158,207,151,180,164,246,40,86,241,40,215,121,182,48,47,195,165,165,189,54,61,237,86,105,63,183,216,179,147,118,157,108,166,191,92,232,151,86,154,101,167,65,103,13,207,18,147,56,246,217,102,209,185,204,65,73,181,130,28,146,185,130,113,60,177,105,36,169,58,121,117,19,217,183,155,213,131,22,63,119,60,236,78,72,85,198,169,71,110,247,188,186,100,44,157,114,197,246,15,60,113,236,215,95,89,232,45,180,230,143,221,144,162,69,192,62,37,75,201,171,110,59,31,252,216,179,111,165,247,92,243,164,70,92,123,92,57,96,243,157,106,165,38,176,81,19,40,10,85,202,118,197,46,219,59,117,33,251,45,241,3,130,22,5,94,94,6,190,89,193,21,139,139,154,169,123,127,179,125,84,65,72,44,207,194,176,95,93,232,182,24,12,2,100,182,134,249,203,192,163,14,174,246,214,57,238,169,137,76,243,104,117,110,147,221,143,207,205,255,10,134,238,238,238,178,119,69,57,155,197,114,113,224,22,78,128,184,113,134,134,157,79,216,154,138,140,150,204,187,85,110,91,222,235,202,216,126,61,48,164,213,30,67,110,239,177,39,236,62,229,234,38,79,116,209,234,12,247,211,221,161,71,124,7,132,255,194,11,96,17,160,69,13,203,241,24,233,83,93,94,118,3,27,72,194,183,54,238,37,182,211,211,41,132,0,211,176,79,117,188,250,60,254,243,66,81,195,67,64,109,102,97,138,81,88,30,234,110,163,17,49,12,40,4,39,100,7,79,172,77,19,100,227,194,202,13,122,44,88,3,132,65,3,70,123,85,195,14,77,255,125,99,182,191,13,8,214,68,230,88,202,92,122,113,177,221,113,102,76,250,190,40,89,33,109,166,238,252,180,222,214,187,92,36,152,37,10,49,205,32,127,142,126,175,39,19,212,151,179,110,108,30,71,139,57,239,177,52,199,10,94,240,120,246,153,103,83,117,211,99,62,217,145,128,144,66,232,176,145,169,175,129,12,175,206,142,71,195,81,255,236,168,255,229,232,231,111,38,112,240,108,128,116,212,37,91,239,222,131,82,77,115,227,176,54,136,38,86,103,2,220,169,24,180,247,98,89,198,122,72,171,58,243,2,113,159,208,211,185,44,162,126,146,132,129,149,189,83,9,2,146,169,37,50,80,244,154,167,5,205,91,157,78,181,115,249,173,166,137,116,198,194,10,85,180,109,144,90,121,172,245,151,75,203,77,28,0,244,126,96,162,81,110,106,43,60,68,90,149,146,159,100,147,60,58,201,128,214,34,206,148,93,236,110,208,132,248,24,101,207,141,82,150,136,201,22,24,187,194,170,10,192,94,122,251,232,166,237,206,37,118,24,182,231,183,60,52,108,240,54,56,31,12,71,48,195,78,142,84,117,49,109,1,72,109,141,153,37,125,86,32,50,227,215,102,58,61,119,59,92,182,117,50,132,3,43,132,38,120,114,133,134,185,46,118,24,64,253,180,54,19,236,55,70,96,13,19,134,57,58,158,205,213,162,58,215,90,161,183,124,1,235,254,17,172,212,253,206,23,223,30,62,150,34,193,121,236,158,190,195,238,99,96,56,125,141,110,12,32,214,75,200,161,164,32,27,13,173,85,143,245,42,172,108,136,56,16,48,196,236,61,226,179,121,74,200,131,152,147,57,171,88,124,16,41,223,125,152,224,243,12,167,214,199,221,7,82,102,19,9,70,63,6,94,56,135,58,61,89,83,132,11,167,19,180,68,40,95,220,243,35,189,58,185,120,17,174,136,133,79,27,66,232,235,191,90,213,84,229,240,192,179,113,158,144,84,115,10,184,24,125,248,229,216,46,85,201,76,109,90,162,83,62,203,229,194,196,195,17,93,47,20,191,188,50,226,56,105,7,173,147,77,205,242,61,222,23,97,197,34,55,242,106,41,209,87,41,20,15,87,220,61,246,166,87,17,22,25,84,240,121,134,156,223,134,32,163,239,129,20,83,145,69,239,81,155,238,104,212,236,38,148,1,164,122,23,249,32,50,155,130,107,187,137,238,234,196,18,43,21,143,111,232,144,187,167,247,56,195,30,239,255,39,8,216,191,150,91,142,159,1,86,140,196,246,230,230,117,53,235,129,235,104,107,148,91,71,86,117,7,158,45,115,191,129,54,131,243,209,201,224,108,72,163,70,179,36,220,156,67,199,69,68,219,207,123,221,176,177,131,53,34,139,91,131,185,190,106,8,55,246,94,202,160,188,214,200,108,39,48,72,246,236,246,103,34,179,70,166,233,141,125,61,130,237,232,208,228,233,78,63,77,243,251,29,147,39,52,139,253,51,232,190,84,136,133,126,146,162,65,252,197,130,44,5,9,50,134,245,152,235,85,38,79,136,107,174,130,255,75,251,174,52,200,109,67,245,34,57,107,162,245,34,89,207,11,88,173,147,183,158,126,14,81,84,64,38,150,66,50,187,142,245,181,26,16,57,141,193,140,159,115,154,117,9,181,214,28,129,244,202,60,150,192,70,13,11,193,196,182,134,224,96,112,253,95,96,50,187,23,152,250,154,226,222,237,106,174,149,16,83,229,197,1,251,109,56,56,115,77,150,45,205,132,151,192,172,2,199,40,12,64,184,3,197,137,62,175,40,152,8,158,98,24,113,228,149,105,124,7,163,131,44,11,176,190,97,162,96,40,90,185,96,252,15,62,198,205,84,194,138,202,65,165,199,114,117,195,229,189,40,192,245,211,210,97,127,238,223,97,238,151,214,107,94,90,121,212,202,244,126,34,72,206,157,23,78,69,91,128,148,57,120,188,207,19,116,162,69,202,189,145,104,185,138,198,66,167,208,100,219,57,75,203,252,142,89,171,105,103,232,134,5,230,82,227,185,199,20,118,223,178,182,17,54,189,206,38,208,69,103,26,150,12,96,235,186,1,127,139,84,12,216,30,237,106,92,183,96,96,239,54,218,88,55,31,84,54,35,76,171,137,223,11,122,79,184,239,227,207,70,119,191,15,62,55,56,231,0,234,111,152,190,169,197,98,91,40,217,62,1,108,210,229,189,238,87,111,177,166,197,98,177,207,24,153,111,90,9,151,57,187,186,65,127,85,163,182,119,29,117,67,169,68,232,159,17,131,86,97,235,117,68,77,146,38,176,133,214,237,86,189,91,43,179,245,242,103,121,11,189,233,252,118,72,127,75,188,109,187,240,240,254,111,48,255,94,180,82,117,204,95,23,79,222,186,213,48,194,199,83,27,52,186,34,51,191,232,158,204,121,94,229,22,153,170,194,250,211,124,85,199,91,163,97,215,106,1,33,220,58,207,11,5,111,40,178,154,164,222,57,233,185,70,7,219,128,214,99,180,20,29,49,234,30,141,110,233,133,180,161,135,162,249,228,1,187,181,135,159,67,12,102,232,252,86,112,166,114,70,29,230,150,34,141,84,167,235,181,109,91,55,141,0,230,2,51,56,32,235,112,254,160,7,175,85,187,153,216,254,45,160,103,99,82,255,126,142,203,60,125,242,58,73,234,149,236,223,226,246,152,209,161,39,14,243,211,150,78,123,194,218,77,242,22,177,246,23,18,152,98,147,104,29,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNotAllowedURLMessageLocalizableString());
			LocalizableStrings.Add(CreateDataIsSavedSuccessfullyMessageLocalizableString());
			LocalizableStrings.Add(CreateUnknownWebFormIdentifierMessageLocalizableString());
			LocalizableStrings.Add(CreateLandingDisabledMessageLocalizableString());
			LocalizableStrings.Add(CreateConversionExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateOverflowExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateFormatExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNotAllowedURLMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab59051e-66d5-4ef8-885c-4a1307f76006"),
				Name = "NotAllowedURLMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDataIsSavedSuccessfullyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fe873f3-73c3-4911-ada1-b77028b1ac25"),
				Name = "DataIsSavedSuccessfullyMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnknownWebFormIdentifierMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("29eb0044-749f-44a7-be3e-f5ca1d725a82"),
				Name = "UnknownWebFormIdentifierMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLandingDisabledMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ec21278c-9228-4888-ad81-2753b2f4bfc7"),
				Name = "LandingDisabledMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateConversionExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4fdb8564-ea35-4b21-8dc4-c5f118c7a7e0"),
				Name = "ConversionExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOverflowExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54e9d086-fbb8-4bea-a8f1-7611beb3aee1"),
				Name = "OverflowExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFormatExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e82e92af-f617-41f4-b061-1fe472ab96dd"),
				Name = "FormatExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("177ef661-e736-4802-9520-b1d553edb13c"));
		}

		#endregion

	}

	#endregion

}

