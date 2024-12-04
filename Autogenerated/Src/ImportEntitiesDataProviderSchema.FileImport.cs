﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitiesDataProviderSchema

	/// <exclude/>
	public class ImportEntitiesDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitiesDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitiesDataProviderSchema(ImportEntitiesDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429");
			Name = "ImportEntitiesDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,91,91,115,219,54,22,126,86,102,242,31,176,106,31,168,137,134,78,247,173,137,173,140,175,173,182,113,147,141,221,228,161,211,201,208,36,100,115,67,145,10,8,42,86,61,249,239,123,0,28,16,23,130,148,28,167,205,238,75,44,226,114,112,206,135,115,195,1,82,38,75,90,175,146,148,146,75,202,88,82,87,11,30,31,87,229,34,191,110,88,194,243,170,140,207,242,130,206,151,171,138,241,199,143,238,30,63,26,53,117,94,94,147,139,77,205,233,242,185,247,13,83,139,130,166,98,94,29,255,68,75,202,242,180,51,230,101,94,126,52,141,199,213,114,89,149,246,55,163,238,87,124,114,228,53,156,150,60,231,57,173,189,230,179,36,229,21,83,237,208,243,29,163,215,192,8,57,46,146,186,126,70,148,12,122,234,73,194,147,215,172,90,231,25,101,114,244,239,39,116,145,52,5,63,202,203,12,40,70,124,179,162,213,34,154,247,79,155,76,201,175,128,30,57,32,37,252,17,99,251,135,78,254,128,37,86,205,85,145,167,36,21,252,12,176,67,128,215,33,102,71,98,23,140,116,0,53,79,74,14,18,190,102,249,58,225,84,138,51,90,169,15,146,138,126,146,151,156,156,39,183,175,19,6,172,114,202,234,227,170,41,249,107,202,254,221,80,182,57,190,105,202,15,32,199,15,63,62,125,250,188,119,242,155,234,211,89,197,230,101,77,89,119,230,83,57,179,59,183,230,76,236,207,81,179,88,80,70,51,75,174,205,69,122,67,151,9,66,56,14,141,24,35,201,239,104,153,41,113,241,27,101,63,203,105,145,245,9,174,8,189,172,174,175,1,210,247,133,252,235,8,103,115,65,222,215,242,175,51,96,14,218,220,44,203,250,240,250,26,22,76,64,183,148,134,109,200,251,180,167,103,203,252,195,44,89,1,250,237,124,216,212,148,214,117,229,50,198,104,146,85,101,177,209,224,189,207,21,38,183,41,45,96,19,230,101,70,111,5,100,243,110,243,54,196,164,182,176,70,240,42,112,147,10,137,176,41,229,236,87,188,232,55,216,120,152,95,42,251,38,141,243,57,33,82,43,71,222,160,3,111,152,148,115,52,47,129,122,82,228,127,82,181,61,209,68,182,127,254,42,156,76,7,112,247,97,159,128,173,241,155,188,142,36,91,163,176,72,157,205,2,169,130,251,247,191,35,215,84,201,51,55,190,251,12,220,218,233,109,94,243,26,84,69,209,209,203,106,165,78,67,173,93,74,243,114,81,161,85,45,2,141,45,164,30,247,138,78,119,3,28,140,125,150,52,208,94,187,66,251,125,104,121,152,18,106,182,247,161,207,54,96,145,21,184,54,216,148,62,143,210,139,255,113,71,67,102,93,27,39,47,94,40,16,162,144,70,245,249,154,23,16,71,121,167,211,83,149,137,80,180,221,92,87,111,135,197,114,183,179,195,122,96,190,10,180,248,41,184,222,239,229,98,22,117,57,182,221,181,222,203,153,118,220,192,0,137,244,111,8,184,244,147,51,33,4,135,69,58,168,188,65,245,217,97,94,176,241,96,54,160,146,146,247,30,101,237,98,22,162,31,192,203,243,21,222,231,29,185,166,252,57,209,158,167,43,208,14,254,32,108,147,207,191,156,96,184,85,67,23,246,0,18,187,30,231,160,84,114,8,193,237,76,133,52,113,167,249,62,60,95,70,196,251,12,99,17,2,161,245,24,158,60,198,91,180,81,165,21,176,207,241,157,83,126,83,245,230,81,39,180,128,140,145,0,221,80,138,166,122,101,46,24,85,87,255,1,245,35,42,91,185,0,199,6,196,231,153,48,215,166,40,180,167,95,39,140,100,138,164,178,99,69,193,183,96,181,183,241,25,171,150,209,112,242,168,108,125,148,47,72,228,175,252,15,119,233,145,90,55,126,119,3,212,34,76,159,218,209,227,73,60,175,79,63,54,73,17,41,0,227,54,91,246,9,163,127,17,1,5,254,101,148,55,172,68,161,156,128,175,117,65,166,204,125,8,170,94,133,160,13,210,85,96,172,118,125,114,138,15,89,60,47,121,181,27,88,200,114,104,137,160,0,167,101,179,164,44,185,42,232,190,243,219,154,55,155,9,1,221,228,70,158,14,234,168,119,10,161,56,80,103,25,157,129,106,39,102,228,3,221,96,44,177,33,210,211,95,130,113,1,52,250,51,190,172,68,11,102,95,114,36,70,45,28,104,168,5,134,46,241,152,84,195,25,71,31,111,206,19,126,19,31,94,213,209,182,51,212,30,137,172,165,98,57,130,60,33,255,212,26,211,75,252,60,47,163,161,51,214,180,203,151,45,158,4,90,173,118,0,118,80,242,137,164,122,76,243,66,28,102,109,160,144,41,224,52,171,32,35,165,147,62,194,168,36,206,220,139,85,145,243,87,37,140,231,117,100,173,58,9,169,141,152,177,255,83,147,103,82,53,128,122,13,13,90,219,90,99,170,29,173,175,219,102,212,117,67,196,222,164,26,140,13,92,141,26,114,33,63,58,230,112,2,51,243,18,58,180,51,81,123,30,48,252,123,59,27,85,116,136,164,47,187,58,189,165,105,3,190,23,184,113,89,128,58,69,221,48,122,114,100,154,192,25,107,103,100,211,128,67,192,27,56,244,73,183,174,68,139,21,85,170,154,35,179,138,33,48,250,116,3,49,6,182,177,157,29,139,63,214,18,163,145,129,51,62,204,50,123,104,27,39,222,38,69,67,17,225,46,52,40,176,246,117,248,199,113,124,102,141,144,18,172,171,60,35,221,131,17,178,24,68,59,89,3,102,167,140,1,164,79,14,48,23,140,127,78,202,172,160,178,245,28,22,76,174,233,192,106,80,120,18,84,92,111,116,89,157,92,125,93,95,132,67,5,118,126,212,179,117,90,117,225,156,33,247,99,98,152,238,135,136,180,92,241,141,181,167,10,116,59,254,132,18,198,248,29,203,57,69,110,14,165,234,93,112,48,90,132,206,15,104,40,200,184,255,108,26,247,131,122,244,140,212,201,90,40,179,134,144,92,37,28,76,166,38,133,240,183,188,34,39,71,99,203,120,61,183,221,23,54,218,13,113,1,68,66,11,168,248,37,233,141,50,32,61,244,72,172,11,245,42,103,137,22,186,175,7,212,131,145,130,226,88,10,59,73,61,200,198,228,9,46,240,253,56,146,45,102,64,138,222,253,206,17,86,121,243,104,242,121,226,226,60,82,49,68,142,145,138,239,11,226,130,58,117,33,212,68,118,68,236,180,204,254,223,241,186,151,41,109,149,247,175,55,36,233,247,252,19,63,150,222,29,199,102,57,121,33,147,12,197,184,233,151,149,118,191,154,9,187,132,189,65,13,81,31,95,144,161,217,177,83,117,25,22,137,42,183,26,159,136,245,87,140,209,42,146,140,100,236,31,20,102,173,127,58,233,194,208,148,200,247,31,40,179,26,135,137,34,88,7,232,14,156,219,232,237,68,184,19,203,99,99,178,17,165,48,102,34,42,20,120,90,120,70,160,69,214,96,159,145,28,82,190,31,38,198,103,99,29,87,209,198,130,119,187,13,226,59,50,203,138,37,181,9,91,140,157,80,145,204,200,27,25,56,105,152,223,186,66,22,91,3,106,184,179,97,53,127,197,240,74,67,139,44,227,139,51,217,59,31,141,248,13,171,62,73,28,15,217,53,108,116,201,127,133,254,87,76,6,33,81,104,94,201,36,6,239,59,44,82,109,158,128,105,130,208,120,137,249,37,92,163,200,252,198,124,29,184,155,47,50,145,163,141,68,193,34,136,138,32,115,174,216,161,22,0,71,246,33,16,234,247,129,163,188,128,71,153,89,67,17,110,205,51,158,91,165,46,65,246,45,108,179,197,21,201,41,160,16,165,23,174,64,0,253,66,126,96,247,179,78,57,80,174,255,214,34,111,75,58,181,87,210,44,25,189,150,121,155,169,119,5,149,186,77,167,70,163,139,170,97,41,53,224,25,5,81,61,218,33,7,70,136,15,183,91,99,105,35,227,142,16,59,131,155,234,96,130,202,16,58,39,27,209,6,18,56,55,118,133,18,172,169,109,234,218,9,185,49,173,207,101,249,25,159,10,121,8,33,135,202,18,130,41,115,55,115,58,87,70,187,245,8,143,59,232,228,39,182,50,218,233,137,179,114,63,171,29,183,103,105,12,56,62,157,236,15,122,118,199,153,7,51,42,88,127,215,24,178,74,88,173,114,113,171,75,184,96,155,177,88,243,165,234,45,233,90,120,203,116,141,150,237,24,214,196,75,132,149,171,10,175,18,31,150,118,62,12,42,239,228,143,150,155,10,207,215,194,171,209,237,130,112,53,1,13,101,163,253,139,246,100,146,19,71,172,195,162,8,10,3,50,92,72,71,15,230,8,114,41,167,31,75,215,105,179,219,187,142,81,162,88,173,100,208,104,149,105,96,87,108,236,229,55,232,153,205,183,197,130,189,20,160,23,121,51,45,223,171,173,93,219,187,85,19,11,79,146,223,142,75,179,58,181,183,232,156,42,59,28,117,14,162,83,116,170,226,113,2,232,73,79,65,174,75,40,116,119,218,210,50,194,200,146,137,19,50,244,96,63,178,217,11,224,25,93,239,211,103,146,202,20,52,106,85,144,208,22,245,87,229,150,179,174,116,242,246,249,246,116,13,110,2,226,112,109,252,67,167,178,218,147,110,27,6,160,42,166,27,145,172,104,138,241,119,192,77,135,252,113,175,133,61,208,97,40,206,122,115,78,251,12,189,108,153,151,89,94,149,138,106,130,112,148,104,114,94,229,229,93,197,62,200,103,45,80,18,169,101,224,187,128,218,9,16,216,158,160,131,170,141,59,244,107,161,43,40,1,98,167,140,84,159,31,148,181,255,254,135,21,75,133,63,236,113,97,152,68,58,41,198,172,61,201,220,89,237,24,182,141,69,126,134,58,245,101,117,8,111,117,218,88,227,232,109,112,163,218,186,49,4,223,60,59,78,106,110,246,16,253,20,132,247,101,194,35,196,25,97,194,190,127,85,80,157,20,184,76,109,241,32,193,13,69,112,76,118,221,252,118,91,142,125,103,103,8,238,253,133,200,15,79,174,44,90,66,146,193,219,21,233,253,208,102,156,133,117,124,66,233,244,104,245,156,66,114,162,236,192,145,107,135,91,147,138,195,110,210,76,227,128,159,202,118,182,219,125,216,230,169,254,181,99,169,236,5,28,44,215,213,7,26,137,203,247,169,53,221,221,163,150,183,156,113,184,234,32,87,85,85,144,240,105,244,155,212,202,234,38,21,57,51,236,7,60,83,193,24,137,231,112,177,231,152,176,122,4,172,200,251,60,152,196,57,178,245,223,20,192,93,34,77,66,251,101,18,40,195,116,91,103,233,47,54,186,235,78,109,52,58,24,236,16,66,12,54,139,164,168,117,2,241,53,2,203,238,145,37,28,90,118,140,45,122,39,5,115,240,83,195,174,235,200,74,188,251,217,158,245,130,105,111,111,143,236,215,205,114,153,192,181,174,110,16,59,202,106,121,56,33,11,168,239,7,95,162,17,46,84,151,92,109,200,74,57,157,140,236,131,231,78,150,140,46,228,227,190,131,177,7,199,152,236,181,75,236,239,249,139,170,201,61,51,103,251,123,178,123,102,189,9,146,158,98,72,249,134,204,230,111,169,255,66,121,67,176,103,191,229,67,126,172,98,21,21,121,42,214,176,116,96,124,176,241,182,151,197,59,220,64,247,216,40,222,251,254,221,233,218,55,181,42,180,32,169,142,121,9,39,176,156,103,21,60,62,5,149,62,24,15,188,47,141,135,212,112,50,222,187,151,218,110,87,81,165,155,90,45,119,80,67,120,236,10,58,183,85,25,227,241,195,181,233,27,171,207,3,146,248,175,9,56,184,224,221,225,118,159,58,26,253,120,85,120,170,241,38,249,36,150,137,206,154,50,149,151,143,80,60,149,3,204,245,250,12,94,242,149,153,223,42,38,244,212,106,192,241,208,204,220,43,171,77,30,184,118,110,107,109,140,148,21,7,96,32,33,82,243,60,74,248,98,4,132,57,232,103,10,186,39,109,61,3,119,75,39,250,185,152,232,30,96,39,246,242,31,229,61,191,236,63,189,93,49,181,176,44,105,91,124,249,201,138,40,76,132,39,226,21,255,140,60,53,135,254,47,85,254,237,143,102,202,30,46,124,10,158,253,232,3,245,174,170,58,168,164,176,41,121,125,51,172,107,227,111,232,247,133,134,171,82,208,67,93,190,170,209,239,234,254,209,16,7,179,124,79,151,197,153,21,127,130,77,222,227,190,231,75,242,16,179,22,30,92,239,115,147,22,22,72,111,51,222,40,133,94,101,152,123,169,243,164,4,54,228,25,115,46,255,31,69,74,143,54,191,205,51,155,177,55,85,197,213,104,232,176,174,177,65,207,225,114,5,232,247,0,107,145,8,31,1,250,133,199,85,238,127,29,249,23,226,137,89,186,146,186,147,98,116,242,238,27,154,126,32,201,58,201,11,153,91,131,220,250,17,150,186,153,141,119,76,159,13,96,210,169,141,103,191,116,40,217,9,181,156,175,88,173,103,111,212,14,201,162,7,148,38,96,160,238,241,109,227,45,14,249,197,93,77,148,5,173,45,83,79,157,182,188,209,195,255,80,162,171,242,247,85,62,89,226,216,233,17,146,245,174,13,148,176,159,149,248,216,190,83,21,179,224,197,44,111,37,53,255,155,65,86,214,83,89,216,142,85,174,126,64,190,31,171,81,119,30,10,80,134,114,212,194,33,57,116,132,67,212,101,125,130,72,223,169,94,246,176,253,160,83,157,133,255,235,144,241,199,98,45,181,148,189,210,231,199,143,254,11,158,26,111,5,218,54,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateParseErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateParseErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ce4fafe3-7081-535a-ac50-5b650c19375d"),
				Name = "ParseErrorMessage",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429"),
				ModifiedInSchemaUId = new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429"));
		}

		#endregion

	}

	#endregion

}

