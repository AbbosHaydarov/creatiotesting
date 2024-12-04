namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApiKeyProviderSchema

	/// <exclude/>
	public class ApiKeyProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApiKeyProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApiKeyProviderSchema(ApiKeyProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394");
			Name = "ApiKeyProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e8c267b1-bae4-4c71-bb04-0c218f8cac09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,88,75,111,219,56,16,62,187,64,255,3,235,237,65,6,2,165,123,216,75,90,187,112,179,205,194,219,230,129,56,221,30,130,69,64,203,180,35,68,22,181,36,149,212,13,252,223,119,248,146,72,137,178,157,102,183,57,180,214,112,56,156,249,230,73,230,120,69,120,129,19,130,174,8,99,152,211,133,136,143,105,190,72,151,37,195,34,165,121,252,25,231,243,52,95,166,147,92,144,165,166,189,124,241,248,242,69,175,228,64,70,211,53,23,100,245,182,241,29,79,9,187,79,19,114,74,231,36,219,186,24,143,19,145,222,43,177,219,249,190,146,89,205,176,204,232,12,103,71,71,199,116,181,146,58,210,229,18,200,245,186,107,140,228,8,175,48,18,166,187,230,127,40,96,123,150,230,228,56,163,229,220,1,33,180,245,172,76,125,165,127,199,2,131,60,193,112,34,66,27,192,168,90,67,88,255,133,145,37,200,70,199,25,230,252,8,141,139,244,19,89,95,48,122,159,206,9,147,28,8,254,14,15,15,209,59,94,174,86,152,173,71,53,9,152,209,29,89,163,194,176,199,14,247,161,207,126,109,148,180,170,253,13,71,95,143,121,113,70,4,104,83,128,125,179,52,75,197,250,146,252,83,166,140,172,72,46,120,228,126,72,235,208,16,237,216,34,185,98,67,152,15,228,33,69,57,203,210,4,37,210,188,134,117,232,8,125,192,156,24,205,128,23,98,12,254,173,33,161,57,23,24,164,30,161,11,38,35,134,232,245,66,127,160,68,174,35,46,152,68,120,156,36,180,204,133,17,246,133,101,19,126,70,197,73,154,101,100,126,172,117,239,111,227,249,200,24,101,167,124,217,127,219,121,132,102,33,156,227,37,185,96,100,145,126,179,130,219,43,91,196,252,1,248,49,34,35,10,52,80,59,173,152,246,138,81,72,122,80,254,5,229,77,230,128,60,248,97,74,132,128,111,62,102,196,183,202,138,223,201,184,221,252,115,113,75,152,39,176,166,108,223,9,49,127,75,233,157,15,191,213,198,147,184,155,211,156,164,226,132,228,115,29,42,126,220,156,164,36,155,119,5,205,4,42,7,186,201,160,124,16,230,105,60,57,31,151,226,214,73,247,75,130,101,144,222,208,32,221,223,123,73,169,48,74,87,209,125,195,218,68,127,215,180,156,53,214,79,32,53,41,91,163,27,222,181,180,195,118,224,46,8,19,41,233,178,191,51,150,209,112,36,67,243,115,242,125,170,88,162,112,184,15,158,162,128,202,125,189,222,40,97,154,0,231,113,68,25,226,242,127,8,38,164,253,18,87,27,156,42,214,179,165,68,121,80,214,127,192,88,118,165,94,111,73,132,212,222,120,21,189,127,143,34,251,123,40,57,79,113,14,54,176,88,154,167,200,81,223,175,68,253,129,52,11,36,113,95,210,16,221,227,172,84,61,163,183,233,12,239,105,2,38,67,240,62,232,224,141,19,157,195,241,162,204,178,27,156,36,0,161,13,217,32,10,87,96,184,140,21,132,181,199,221,122,190,13,135,80,208,133,104,62,72,129,168,212,136,133,22,134,40,39,15,33,161,209,23,78,32,107,243,156,64,51,167,249,129,6,161,9,99,88,164,135,233,127,142,74,71,26,119,144,125,108,194,169,174,225,233,88,211,8,133,165,71,77,60,58,101,236,7,73,43,93,160,74,180,224,65,11,93,40,118,192,212,93,123,186,87,92,176,212,207,94,119,157,2,208,52,75,180,133,71,131,215,121,96,11,191,109,146,90,16,118,85,40,53,86,176,82,238,219,167,70,77,242,84,164,56,75,191,19,174,180,77,213,80,2,227,51,93,0,51,129,90,0,181,113,216,44,40,135,163,237,248,251,236,209,0,102,161,25,204,66,240,227,177,50,225,127,84,169,192,12,175,80,14,87,129,97,191,244,50,185,63,154,56,210,100,144,57,18,253,164,151,18,223,29,42,81,163,167,24,235,75,65,254,249,21,18,77,242,227,30,174,61,37,226,150,118,182,254,122,254,170,155,156,161,101,52,145,120,226,89,70,84,147,51,161,126,143,153,187,164,247,156,1,106,16,111,175,251,159,155,43,60,126,108,8,218,196,127,201,176,212,179,81,143,17,81,178,92,185,172,181,183,129,74,252,149,178,59,117,77,131,113,154,211,146,37,192,71,25,180,177,3,212,116,236,129,78,180,160,162,58,129,54,62,16,118,202,82,98,64,124,1,25,65,100,231,150,173,74,181,125,139,11,113,102,0,105,207,129,5,113,165,105,46,80,46,175,194,231,177,61,65,108,208,163,7,127,83,254,96,99,160,210,125,58,214,202,188,214,3,182,61,244,8,61,186,251,54,232,227,183,132,20,42,150,106,14,243,107,211,55,37,164,210,176,178,87,23,159,48,22,218,170,222,37,125,224,227,197,2,92,66,230,192,255,171,65,218,178,77,5,22,37,183,77,210,35,70,253,223,222,188,233,31,120,160,12,204,246,105,169,102,2,216,183,192,25,151,23,31,240,144,23,33,158,162,33,15,206,40,205,208,21,91,3,152,78,59,153,228,11,106,61,151,214,100,25,7,7,136,150,2,53,120,93,38,249,173,245,147,140,1,247,91,87,139,170,17,244,26,219,209,80,147,123,225,110,24,7,148,109,4,253,184,40,156,47,253,38,208,24,52,204,17,238,217,117,156,247,122,141,32,204,97,4,51,43,6,218,134,206,177,113,134,102,218,160,4,139,228,22,69,117,68,85,118,183,173,117,165,55,206,37,177,249,237,31,174,252,109,142,218,238,213,41,77,160,194,59,131,87,228,184,5,122,94,137,235,171,227,83,221,230,72,149,134,84,65,111,39,137,97,104,224,147,222,59,103,234,122,74,218,202,89,248,27,154,129,40,255,214,24,70,203,28,172,179,61,8,156,54,44,134,251,58,64,126,206,62,174,10,177,142,66,219,6,13,71,78,32,130,228,37,23,24,231,33,167,182,21,222,245,144,240,195,14,183,42,249,183,252,189,116,10,63,25,60,91,147,73,14,67,83,58,175,223,5,216,61,97,246,117,96,63,205,246,122,124,120,182,162,251,233,178,79,168,61,63,49,171,17,212,86,90,115,237,155,170,38,125,176,179,198,34,55,145,85,215,241,73,207,203,237,137,255,130,82,221,186,218,147,115,85,173,59,199,111,153,242,97,113,81,195,102,24,167,171,10,172,109,2,168,219,71,186,53,196,8,54,105,166,219,111,83,108,3,186,231,21,153,118,43,120,21,174,42,74,149,193,62,17,104,45,117,68,255,140,168,220,61,253,238,245,238,34,103,123,24,170,212,107,5,177,81,140,198,23,19,249,166,220,113,123,105,93,30,26,109,184,63,82,211,177,185,57,56,139,237,139,130,43,197,243,123,127,36,175,254,86,31,61,251,182,183,107,136,248,72,190,32,35,102,91,216,67,42,110,237,179,56,236,177,76,114,215,245,57,188,75,41,93,220,55,240,222,53,4,34,212,65,122,71,34,141,159,124,134,188,56,159,94,193,240,102,59,227,9,101,43,44,251,34,240,26,71,105,82,252,39,183,35,201,7,58,95,79,197,58,35,30,91,69,141,191,50,92,20,100,46,223,198,9,23,234,105,220,94,143,194,35,104,59,87,76,146,116,13,120,161,114,100,99,53,93,160,232,85,120,94,252,161,65,17,117,85,164,42,57,76,8,123,151,138,253,222,129,27,67,179,19,255,174,25,79,26,144,148,186,251,235,217,218,190,151,66,117,99,216,94,198,58,59,192,79,211,218,185,135,110,189,254,104,170,28,208,180,150,205,235,139,44,251,206,237,37,92,158,52,213,39,110,94,190,248,23,159,126,182,35,135,28,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOtherErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateIdentitySettingsAreNotFilledErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateAccountServiceUrlIsNotFilledErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateErrorMessagePrefixLocalizableString());
			LocalizableStrings.Add(CreateWebhookAccountServiceIdentityErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateGetCreatioUrlErrorMsgLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOtherErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2d5ffaaa-9e13-a68a-41a3-50e2f7dcc505"),
				Name = "OtherErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIdentitySettingsAreNotFilledErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("418532a4-9551-7296-cd86-04a914304d8c"),
				Name = "IdentitySettingsAreNotFilledErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAccountServiceUrlIsNotFilledErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9c5f3a3c-d4fe-7100-3640-a3b6a653fa3a"),
				Name = "AccountServiceUrlIsNotFilledErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorMessagePrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a7c65f0-a15d-29eb-908c-baa495d7d6e0"),
				Name = "ErrorMessagePrefix",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWebhookAccountServiceIdentityErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4fccb0b9-3c96-6654-2624-b0dc0489d356"),
				Name = "WebhookAccountServiceIdentityErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateGetCreatioUrlErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("efb3459a-1bd2-cd22-10ba-cac8d6926ff0"),
				Name = "GetCreatioUrlErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"));
		}

		#endregion

	}

	#endregion

}

