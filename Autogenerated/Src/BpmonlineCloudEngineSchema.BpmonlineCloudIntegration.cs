﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BpmonlineCloudEngineSchema

	/// <exclude/>
	public class BpmonlineCloudEngineSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BpmonlineCloudEngineSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BpmonlineCloudEngineSchema(BpmonlineCloudEngineSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0");
			Name = "BpmonlineCloudEngine";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,89,221,111,219,54,16,127,118,129,254,15,172,247,48,25,240,148,61,55,181,139,52,77,87,99,105,86,196,233,242,48,12,3,35,209,14,17,73,84,73,42,105,90,228,127,223,241,67,223,164,34,7,238,134,190,4,17,117,188,239,251,221,157,156,225,148,136,28,71,4,93,16,206,177,96,27,25,30,179,108,67,183,5,199,146,178,236,249,179,111,207,159,77,10,65,179,45,90,223,11,73,210,195,206,51,208,39,9,137,20,177,8,127,35,25,225,52,234,209,156,210,236,115,125,216,148,197,137,251,60,77,89,230,122,115,73,174,194,247,82,230,225,209,149,144,28,27,185,110,22,13,51,194,227,147,245,40,162,15,44,38,201,56,126,231,224,57,144,77,20,53,208,255,196,201,22,222,160,227,4,11,241,18,189,201,193,128,132,102,228,56,97,69,124,146,109,225,95,77,119,112,112,128,94,137,34,77,49,191,95,218,231,85,154,39,36,37,153,20,72,50,150,8,180,97,28,209,76,146,173,17,135,238,168,188,70,87,37,75,20,41,158,97,201,236,160,193,45,47,174,18,26,1,1,40,225,209,97,2,17,133,191,181,194,96,132,196,32,251,37,250,200,233,45,150,70,207,73,110,30,80,164,222,35,112,182,242,71,197,114,77,183,25,150,5,39,191,147,123,180,64,211,74,185,95,68,249,102,106,28,51,249,137,100,177,145,213,22,252,142,146,36,246,73,93,173,225,22,225,111,89,138,105,118,140,163,107,178,38,252,150,66,166,254,35,60,111,14,59,28,32,70,71,57,85,244,250,53,252,255,136,66,218,19,188,136,36,227,74,45,237,74,67,209,13,154,62,104,144,171,88,244,131,97,78,114,204,113,138,50,168,180,197,180,0,93,224,90,102,234,101,186,92,105,215,131,81,108,3,252,9,56,155,147,205,98,250,169,77,118,176,12,95,29,104,54,154,171,141,177,43,186,65,251,38,106,203,155,33,85,204,147,73,135,104,209,33,83,217,63,121,24,48,124,149,81,73,113,66,191,18,129,48,202,200,29,228,106,109,135,188,38,77,91,92,106,130,69,38,69,159,234,183,11,144,161,206,84,114,218,195,150,139,122,12,234,28,48,151,237,51,58,250,184,218,143,111,231,85,190,213,162,74,127,55,50,16,156,221,74,199,221,162,225,75,220,143,156,229,132,75,74,116,53,49,9,55,73,60,24,192,145,105,231,14,79,94,138,64,29,221,59,143,223,208,150,200,67,48,24,254,236,98,193,99,133,247,137,39,101,162,113,146,130,46,165,79,125,250,154,160,90,8,179,104,161,152,44,244,235,73,96,222,204,84,55,234,224,60,244,175,53,145,18,222,170,230,38,255,196,73,209,77,132,57,154,234,44,177,124,197,27,44,20,243,233,236,112,192,4,149,10,146,105,140,87,77,204,0,60,222,201,156,91,202,101,129,147,42,239,214,141,36,91,54,81,15,189,126,141,130,118,14,170,154,53,215,2,176,10,138,0,80,188,99,214,108,222,240,212,108,208,152,183,88,98,20,1,18,43,247,150,149,165,90,152,138,144,65,235,159,5,138,53,96,143,180,201,139,254,222,23,54,150,222,238,0,94,48,193,246,83,24,191,248,36,244,194,94,59,92,187,103,50,25,78,241,15,68,94,51,111,191,131,130,148,117,142,66,80,78,163,175,107,253,224,202,185,30,248,216,123,73,244,245,12,240,174,4,158,242,148,69,10,173,241,85,66,12,75,69,163,144,72,63,132,239,24,79,177,12,166,167,93,50,17,126,251,245,33,212,242,167,243,138,183,65,173,91,204,251,124,173,7,123,140,130,182,186,225,37,227,55,122,236,12,97,136,98,5,143,128,142,113,188,37,115,205,123,226,110,26,115,183,33,86,33,107,235,173,210,22,244,232,145,26,59,12,45,221,160,64,19,134,43,113,86,36,201,31,252,36,205,229,125,48,43,29,55,241,179,129,208,28,23,137,154,111,76,96,244,200,139,147,142,33,225,91,178,177,100,115,180,193,137,40,213,4,28,132,191,156,192,155,204,40,59,6,224,235,220,121,12,27,143,10,40,186,12,82,73,143,110,202,123,232,6,38,52,154,1,182,124,46,136,144,99,91,174,37,247,206,40,106,8,63,183,52,170,157,23,156,131,220,74,202,96,55,126,234,24,244,184,20,227,88,177,108,184,65,249,143,19,1,193,104,242,246,13,246,237,139,231,250,158,25,192,74,214,173,142,162,139,214,117,167,21,136,160,225,172,82,247,57,26,53,171,169,58,195,46,254,166,212,92,162,131,89,157,229,47,74,79,189,39,24,80,77,132,71,73,2,88,47,148,213,18,0,78,4,206,137,30,192,77,103,59,236,97,224,96,194,195,85,6,138,80,216,18,108,82,175,182,25,52,203,99,104,117,117,205,184,212,12,63,16,33,160,30,64,221,62,166,117,65,108,90,169,112,198,228,59,86,100,177,189,173,123,233,164,174,27,151,164,102,121,89,44,160,89,196,82,248,71,57,201,172,41,29,111,252,229,52,254,239,22,160,68,205,222,94,115,82,109,211,60,116,204,104,56,223,226,107,27,99,92,252,246,233,195,202,164,247,88,156,49,43,160,227,199,7,4,75,46,65,94,29,59,142,219,167,122,182,10,198,41,247,194,106,119,242,25,134,2,209,85,107,238,140,205,62,149,189,228,172,146,230,214,114,127,169,95,68,96,131,54,162,102,212,77,127,167,24,123,19,196,192,50,74,28,93,198,91,45,67,59,30,168,44,244,252,6,195,161,234,32,223,117,83,171,80,27,134,83,213,173,212,52,172,58,87,2,101,170,106,16,103,49,24,135,41,164,245,22,221,93,83,105,62,90,137,65,84,174,71,41,231,124,59,128,183,74,133,5,218,117,43,40,6,183,2,163,67,25,73,149,220,202,169,80,118,76,186,39,16,163,132,34,186,224,52,45,49,189,21,88,120,217,140,163,215,124,139,83,163,236,183,172,247,108,188,209,192,90,63,148,118,231,38,156,8,71,17,224,191,4,8,223,176,161,212,171,50,167,73,239,204,138,114,181,176,148,43,32,108,254,31,116,102,102,236,66,250,206,134,116,216,244,88,189,13,132,77,182,150,207,227,150,31,197,177,176,203,146,93,149,70,127,29,49,228,211,165,217,89,252,229,181,110,113,31,225,43,27,196,122,31,18,198,109,113,235,208,230,138,229,219,26,92,226,254,237,114,12,178,243,203,0,133,45,4,240,168,9,68,211,195,250,204,110,11,230,42,16,24,5,76,157,152,216,248,118,185,16,228,154,211,11,166,207,131,1,85,253,113,118,220,9,172,23,198,197,187,94,144,135,215,227,94,200,7,212,53,152,11,4,157,108,210,241,86,155,158,25,136,251,3,180,13,254,200,160,15,69,110,200,153,54,172,3,36,161,63,226,255,91,84,31,101,244,240,35,238,100,255,237,182,84,33,240,83,214,165,78,127,106,145,123,54,170,217,184,33,7,242,36,186,129,111,153,4,2,171,126,122,225,44,69,240,133,243,150,66,180,199,6,198,220,157,46,79,178,34,133,175,1,240,181,64,69,198,156,186,106,172,2,88,35,251,68,17,150,191,39,41,173,154,231,34,88,213,108,95,25,172,93,90,222,29,175,52,178,184,199,196,94,24,221,129,29,224,129,174,238,53,98,149,222,209,198,143,117,145,24,132,171,29,161,234,187,180,53,112,89,191,240,189,24,231,179,167,154,35,158,138,110,30,237,122,252,208,194,180,63,47,26,58,237,17,163,224,176,71,53,34,109,182,20,126,234,229,98,135,143,190,222,65,230,194,193,98,160,138,110,25,141,43,5,30,159,76,60,14,54,68,198,179,168,239,184,230,71,149,154,52,180,36,225,201,23,144,46,130,47,234,219,251,23,123,138,22,229,76,82,143,245,221,54,218,28,23,204,116,255,196,226,28,51,37,239,171,82,28,222,105,76,125,190,20,115,124,95,223,109,222,107,78,118,63,102,149,124,202,99,104,88,194,108,196,162,220,162,70,86,199,29,185,122,207,216,205,81,158,27,145,211,229,165,57,129,117,41,207,93,117,178,135,21,201,104,172,26,107,185,244,149,69,213,85,167,250,17,162,92,121,188,189,201,193,179,207,108,244,226,164,155,120,99,86,49,209,132,181,148,198,186,129,40,51,212,52,164,127,98,19,68,121,7,198,48,219,237,9,116,86,241,189,187,188,75,35,100,31,33,15,213,203,17,61,94,149,150,237,133,182,146,218,44,118,93,155,244,92,112,10,168,5,52,70,82,179,190,250,81,107,75,131,31,141,224,55,91,61,6,148,243,87,43,84,157,95,50,204,105,251,240,225,249,179,127,1,38,57,69,235,128,36,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBpmonlineHasNoAuthKeyMessageLocalizableString());
			LocalizableStrings.Add(CreateRequestHasNoAuthKeyMessageLocalizableString());
			LocalizableStrings.Add(CreateWrongAuthKeyMessageLocalizableString());
			LocalizableStrings.Add(CreateSuccessAuthenticationMessageLocalizableString());
			LocalizableStrings.Add(CreateSignatureNotFoundMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBpmonlineHasNoAuthKeyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("77de8a8e-db41-47e7-b15e-5548a122938a"),
				Name = "BpmonlineHasNoAuthKeyMessage",
				CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4"),
				CreatedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0"),
				ModifiedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRequestHasNoAuthKeyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("190d17a2-ccc0-43a9-bf97-de4147d86501"),
				Name = "RequestHasNoAuthKeyMessage",
				CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4"),
				CreatedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0"),
				ModifiedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWrongAuthKeyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("adc8d8f8-a290-4e48-90d6-dc1e2fe587fd"),
				Name = "WrongAuthKeyMessage",
				CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4"),
				CreatedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0"),
				ModifiedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSuccessAuthenticationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ca23492d-8328-4d1b-8a05-f2f5731eaee3"),
				Name = "SuccessAuthenticationMessage",
				CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4"),
				CreatedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0"),
				ModifiedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSignatureNotFoundMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("86262171-731a-4810-94c7-728e03d97529"),
				Name = "SignatureNotFoundMessage",
				CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4"),
				CreatedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0"),
				ModifiedInSchemaUId = new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7547043a-2bc6-4dfb-b00c-c05f475d2df0"));
		}

		#endregion

	}

	#endregion

}

