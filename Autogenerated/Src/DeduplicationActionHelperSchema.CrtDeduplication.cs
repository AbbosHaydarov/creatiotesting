﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationActionHelperSchema

	/// <exclude/>
	public class DeduplicationActionHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationActionHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationActionHelperSchema(DeduplicationActionHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc");
			Name = "DeduplicationActionHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,26,93,111,219,56,242,217,11,236,127,224,105,95,20,156,79,201,46,208,151,54,117,145,196,118,107,160,105,123,117,122,251,112,56,20,172,68,219,186,147,37,151,164,210,248,138,252,247,155,33,41,138,148,40,219,233,21,1,98,75,156,25,206,247,12,135,46,233,150,137,29,77,25,185,99,156,83,81,173,100,114,83,149,171,124,93,115,42,243,170,252,245,151,239,191,254,50,170,69,94,174,201,114,47,36,219,190,176,207,46,10,103,67,239,147,233,245,224,210,172,148,185,204,153,8,3,108,183,85,249,162,179,59,188,46,10,150,34,107,34,121,205,74,198,243,116,144,252,156,166,178,226,30,125,67,229,142,61,72,120,9,175,127,227,108,13,196,200,77,65,133,120,78,166,44,171,119,69,158,42,225,175,212,62,111,88,177,99,92,1,239,234,47,176,70,82,132,61,4,58,2,165,193,255,150,56,112,43,105,41,97,131,15,60,191,167,146,233,245,157,126,32,41,174,19,33,57,178,56,207,203,108,106,40,179,15,188,74,97,31,206,62,80,41,25,47,201,75,18,73,177,251,140,64,223,47,30,45,92,244,226,0,197,91,198,215,65,74,106,1,200,132,177,243,82,18,109,133,229,215,98,246,144,178,29,202,120,83,101,12,112,255,246,251,32,206,148,137,148,231,10,248,110,191,99,75,197,196,91,86,174,229,6,16,255,120,118,49,136,185,172,191,252,27,140,123,67,135,144,159,93,92,28,18,116,81,130,59,209,226,35,19,117,33,197,29,253,82,176,101,189,90,229,15,40,172,213,213,146,81,158,110,52,208,65,189,125,100,105,197,179,69,6,62,87,111,203,119,16,43,142,238,64,109,139,172,65,255,141,149,153,182,181,111,248,121,206,138,108,200,234,156,209,172,42,139,61,249,36,24,7,23,41,181,95,147,207,181,247,252,98,0,203,48,249,89,164,27,182,165,200,93,7,114,161,157,242,109,149,254,135,113,242,185,80,159,93,24,216,231,158,113,161,156,24,92,228,62,207,16,54,13,188,61,34,42,128,129,239,99,52,163,184,149,4,230,89,214,108,102,30,59,44,153,15,204,48,163,209,154,73,243,109,196,153,172,65,201,134,99,242,234,21,137,155,239,47,73,201,190,133,66,79,211,138,59,186,59,59,195,208,31,141,30,213,127,209,110,209,210,187,167,69,205,28,168,199,30,207,65,21,5,95,14,74,18,210,167,150,43,184,162,165,12,109,113,186,128,3,132,7,196,29,178,170,202,92,188,198,60,138,118,85,249,79,67,156,159,159,147,75,81,111,183,148,239,39,205,11,7,60,177,64,231,93,168,203,29,229,116,75,74,112,217,151,81,235,190,209,100,169,190,171,133,228,242,92,65,133,145,124,37,68,147,133,202,175,80,198,170,21,48,197,32,142,57,91,189,140,252,192,138,206,39,30,85,147,205,7,243,120,108,34,172,229,112,220,13,213,142,49,140,242,157,144,4,141,123,241,137,171,62,18,64,244,226,253,168,89,110,153,220,84,131,137,197,240,253,154,201,126,6,235,11,213,112,109,124,85,175,39,243,138,111,169,140,7,83,224,216,165,224,178,220,50,1,10,77,61,94,182,80,180,224,225,13,21,155,120,154,43,97,193,45,46,53,200,152,84,42,249,79,72,102,151,26,214,238,41,71,66,38,46,116,77,184,174,243,2,3,194,4,192,10,10,62,77,55,36,214,84,180,159,67,81,113,168,37,255,192,119,162,33,58,2,138,201,213,110,7,42,142,21,180,23,74,70,27,243,188,96,159,100,94,168,54,5,26,14,121,59,125,166,248,159,149,105,133,194,36,159,202,28,190,49,92,187,222,75,38,80,193,201,93,165,153,140,207,206,28,229,12,171,231,142,215,165,42,77,26,171,177,81,85,243,20,156,14,75,99,161,74,96,199,86,177,134,72,76,125,156,52,80,90,190,87,134,0,250,160,134,131,250,170,73,199,23,99,31,246,185,1,121,162,243,121,105,62,156,17,192,44,160,21,40,91,198,250,104,147,148,10,21,170,162,78,83,38,196,170,46,10,34,84,85,62,53,107,52,33,203,26,7,21,209,164,109,13,145,182,133,32,12,187,204,61,201,51,63,250,109,130,191,207,185,172,105,65,238,171,60,51,252,46,53,99,214,101,99,215,19,153,248,106,60,81,245,175,123,157,181,254,94,51,190,239,166,231,196,133,184,165,37,93,51,62,118,75,182,241,57,36,107,25,22,55,85,93,74,29,113,176,17,108,151,92,101,38,2,99,124,210,60,94,173,215,96,16,149,181,230,224,61,248,25,59,239,154,238,41,197,102,24,232,141,73,4,253,74,83,47,144,12,228,178,171,12,4,252,152,175,55,82,192,78,43,90,8,147,164,150,12,85,137,123,155,111,154,15,112,114,253,28,148,214,208,54,222,155,247,155,49,157,17,109,244,57,121,6,219,169,239,191,63,70,158,114,198,195,13,157,191,21,239,101,41,224,55,156,254,250,186,55,2,26,118,173,184,42,211,168,135,158,152,90,128,81,98,76,210,223,221,64,36,115,94,109,227,1,61,156,37,87,98,112,141,80,97,54,215,60,122,204,37,127,110,24,103,177,255,110,169,194,119,246,176,227,224,183,232,121,87,69,78,197,152,12,51,183,16,179,175,224,246,232,81,71,104,40,199,177,126,227,49,113,150,204,30,114,33,173,36,122,209,241,234,20,125,79,71,65,235,67,250,185,141,215,158,134,255,121,241,175,70,112,217,13,12,32,227,16,69,114,232,234,70,64,149,226,47,1,107,18,7,227,41,113,12,111,156,7,78,192,2,226,18,179,164,118,201,217,118,39,247,102,251,21,233,210,129,44,123,97,75,72,15,215,184,115,55,13,0,147,208,160,210,34,255,175,114,97,157,131,163,193,206,35,26,27,23,139,150,109,134,180,231,23,161,15,48,183,122,239,232,108,220,213,80,83,200,8,131,120,238,179,250,211,152,123,87,181,60,205,97,227,204,178,228,86,82,157,173,218,84,106,24,241,154,134,39,148,143,111,155,28,74,93,90,11,89,109,137,132,115,252,169,37,195,146,192,195,127,52,193,255,68,86,228,11,212,226,77,245,173,196,186,100,65,78,46,20,173,88,54,21,57,187,52,126,98,161,218,101,27,18,152,103,90,42,225,140,138,129,180,213,213,35,108,63,175,192,196,81,160,234,68,14,41,73,225,216,111,112,128,158,161,156,224,76,97,1,211,145,235,253,64,166,124,10,11,55,69,14,117,23,154,35,57,200,70,81,81,104,224,142,177,17,117,253,254,93,37,243,149,241,203,59,37,201,91,69,168,33,221,52,79,122,150,128,204,118,59,240,41,16,187,203,161,72,160,20,246,161,47,213,77,205,57,10,1,111,81,66,243,216,32,52,157,231,235,26,188,193,96,74,152,56,45,178,35,164,44,156,155,37,193,252,230,52,160,14,184,195,221,177,9,103,243,49,138,174,106,232,198,32,40,125,22,244,234,227,184,1,31,69,102,233,56,160,174,2,0,103,189,82,157,234,68,98,159,53,132,222,56,72,193,27,227,0,37,99,139,0,228,94,184,190,10,160,174,111,38,159,90,234,58,161,120,22,206,218,57,83,83,238,13,131,206,4,234,112,143,178,129,86,190,131,171,186,123,107,143,179,182,14,252,197,164,248,133,120,7,217,248,61,87,101,34,246,227,189,61,91,88,239,115,105,27,197,116,121,234,52,61,62,73,55,149,42,54,58,41,36,153,51,153,110,176,211,152,94,199,199,124,7,254,34,20,16,20,173,68,127,36,96,13,213,246,181,172,119,233,47,153,156,178,149,83,94,69,220,57,41,57,236,130,192,157,179,140,183,60,62,52,28,108,76,99,85,215,61,21,233,133,241,145,49,161,33,19,16,195,145,33,142,110,225,248,182,202,89,246,30,29,212,77,4,39,226,55,238,223,13,168,19,209,45,252,15,226,235,24,84,232,39,198,233,137,132,53,54,42,226,199,244,226,24,24,8,56,49,122,170,96,3,201,227,68,116,175,58,128,103,4,53,212,5,114,159,79,86,148,19,71,167,138,230,103,59,197,90,55,223,157,72,74,151,60,69,193,45,163,79,160,176,128,211,45,69,124,29,254,3,72,244,190,169,115,189,185,104,211,13,5,38,60,110,254,61,105,98,102,230,25,63,167,49,141,66,124,68,79,151,162,201,214,7,37,0,255,236,79,9,15,245,130,102,45,213,254,221,155,254,253,168,208,196,97,128,252,149,244,186,166,38,158,172,161,3,195,62,60,132,63,39,250,24,110,248,11,86,163,147,231,67,199,198,197,215,128,0,76,40,6,9,216,4,143,58,3,237,188,25,214,170,214,91,161,105,177,236,96,70,117,97,120,3,97,130,24,20,235,233,204,68,190,198,122,223,194,105,117,124,169,170,130,228,98,14,45,61,220,144,205,74,84,125,184,205,93,248,64,89,28,121,247,117,226,125,137,49,211,233,69,225,198,206,131,106,38,195,158,246,15,222,251,133,134,70,216,13,116,120,182,69,252,103,236,184,116,142,195,253,54,68,95,184,36,55,180,156,61,176,180,150,44,118,180,239,179,235,180,22,232,117,46,41,101,54,247,170,66,89,46,116,243,145,40,171,187,43,113,72,72,195,168,228,251,102,83,195,40,228,63,252,182,132,185,43,139,253,29,59,253,151,39,7,220,102,52,52,205,24,26,6,205,153,85,150,29,73,123,111,251,13,222,1,86,15,218,17,60,200,163,156,252,9,167,223,15,120,54,101,96,164,216,189,61,9,185,200,81,252,135,109,241,177,250,38,162,160,181,143,239,190,23,106,130,136,199,60,220,255,192,161,199,214,37,99,248,30,233,198,139,26,176,160,15,204,202,204,243,0,223,142,22,117,96,134,219,140,69,192,0,120,83,96,175,180,73,171,239,83,118,69,37,204,56,175,120,207,141,194,183,229,99,194,18,51,25,241,57,28,60,246,63,189,8,144,104,78,225,62,100,112,70,100,101,95,229,37,45,138,159,20,28,110,235,224,222,38,30,72,246,91,252,201,193,145,92,223,27,221,172,121,85,239,160,217,153,44,50,28,230,67,219,206,113,196,47,55,140,168,37,117,151,160,171,8,215,163,212,195,215,135,255,255,237,65,96,186,36,170,226,30,199,144,229,10,48,165,162,136,63,164,33,112,51,69,244,170,170,251,205,122,232,42,178,173,110,234,151,25,48,84,149,90,64,84,246,91,152,179,94,98,190,132,27,178,30,255,227,208,177,79,127,78,72,143,183,78,47,162,108,226,166,52,191,76,4,127,62,50,84,144,2,117,225,164,58,124,114,197,192,36,188,161,101,86,168,65,148,250,217,142,254,157,143,26,5,95,122,155,41,206,223,104,224,73,172,41,154,155,245,230,154,250,138,175,235,45,216,56,238,222,41,247,210,89,19,67,102,115,8,105,32,174,251,228,169,50,31,134,157,59,53,27,183,182,11,25,172,111,149,225,230,10,222,232,247,238,235,199,255,1,7,129,201,80,190,37,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSuccessfullDuplicatesSearchMessageLocalizableString());
			LocalizableStrings.Add(CreateFaildDuplicatesSearchMessageLocalizableString());
			LocalizableStrings.Add(CreateNoDuplicatesFoundMessageLocalizableString());
			LocalizableStrings.Add(CreateContactDuplicatesSearchCaptionLocalizableString());
			LocalizableStrings.Add(CreateAccountDuplicatesSearchCaptionLocalizableString());
			LocalizableStrings.Add(CreateRemindingDescriptionLocalizableString());
			LocalizableStrings.Add(CreateCanceledDuplicatesSearchMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSuccessfullDuplicatesSearchMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1fbfc263-3bfc-4a19-aad3-e6da19d96ffa"),
				Name = "SuccessfullDuplicatesSearchMessage",
				CreatedInPackageId = new Guid("891b85fe-ef15-418d-a66c-ac70369b4f0c"),
				CreatedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"),
				ModifiedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFaildDuplicatesSearchMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d707cc2e-5ad7-47a7-935a-c37b438bcb77"),
				Name = "FaildDuplicatesSearchMessage",
				CreatedInPackageId = new Guid("891b85fe-ef15-418d-a66c-ac70369b4f0c"),
				CreatedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"),
				ModifiedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoDuplicatesFoundMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2e00d9b2-2d6c-44ae-98c7-b7f3b9fc9146"),
				Name = "NoDuplicatesFoundMessage",
				CreatedInPackageId = new Guid("642e1b93-32fe-4cca-aefe-e71452bbfc69"),
				CreatedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"),
				ModifiedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactDuplicatesSearchCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a9c39552-a3ac-4065-bbc0-fa621389a7c1"),
				Name = "ContactDuplicatesSearchCaption",
				CreatedInPackageId = new Guid("642e1b93-32fe-4cca-aefe-e71452bbfc69"),
				CreatedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"),
				ModifiedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAccountDuplicatesSearchCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("871497cc-49e4-4f08-b21a-633ea4d1d0f9"),
				Name = "AccountDuplicatesSearchCaption",
				CreatedInPackageId = new Guid("642e1b93-32fe-4cca-aefe-e71452bbfc69"),
				CreatedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"),
				ModifiedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemindingDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a54c8ecd-9f81-4289-9ada-493edc58dd43"),
				Name = "RemindingDescription",
				CreatedInPackageId = new Guid("642e1b93-32fe-4cca-aefe-e71452bbfc69"),
				CreatedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"),
				ModifiedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledDuplicatesSearchMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0c571c35-22cb-b678-fa91-ee22e3b017d8"),
				Name = "CanceledDuplicatesSearchMessage",
				CreatedInPackageId = new Guid("6fb12721-ccf5-4064-87d6-bebe274d54ea"),
				CreatedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"),
				ModifiedInSchemaUId = new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca5f1105-df58-42a1-8d4e-47e406f63bbc"));
		}

		#endregion

	}

	#endregion

}

