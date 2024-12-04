namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExternalAccessAppListenerSchema

	/// <exclude/>
	public class ExternalAccessAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExternalAccessAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExternalAccessAppListenerSchema(ExternalAccessAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df");
			Name = "ExternalAccessAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,86,109,111,219,54,16,254,236,2,253,15,156,186,15,52,144,40,77,155,174,70,151,100,112,83,57,53,208,151,32,106,214,15,195,48,208,212,217,225,42,145,46,73,121,77,139,252,247,30,69,73,51,101,41,45,10,244,139,45,30,143,119,207,61,247,66,74,86,128,89,51,14,228,29,104,205,140,90,218,248,76,201,165,88,149,154,89,161,100,156,124,178,160,37,203,167,156,131,49,23,140,127,96,43,184,127,239,203,253,123,163,210,8,185,34,233,141,177,80,252,222,174,183,13,21,133,146,253,59,26,134,228,161,255,65,173,23,207,7,183,102,140,91,165,5,152,62,141,247,176,184,3,152,219,125,105,237,58,158,46,140,213,104,7,33,56,51,168,250,64,195,10,87,228,44,103,198,60,35,33,47,211,245,250,149,64,30,36,232,74,249,224,224,128,28,11,121,13,90,216,76,241,131,83,148,173,203,69,46,56,225,238,252,240,113,242,140,224,42,217,128,180,141,232,57,51,200,248,8,41,199,223,22,199,76,64,158,33,144,11,45,54,204,130,223,92,251,5,49,22,217,227,68,3,203,148,204,111,200,121,41,50,242,15,4,78,83,126,13,5,187,154,103,228,132,72,248,175,210,161,209,236,241,228,201,36,57,250,109,63,153,62,158,236,31,29,62,74,246,167,179,163,233,254,163,135,135,135,179,135,147,167,135,147,105,18,141,61,37,163,7,32,51,15,39,196,246,26,236,181,26,4,87,129,57,7,27,114,112,174,153,196,180,209,43,3,26,75,64,66,69,62,41,131,229,158,63,28,6,50,207,198,196,213,227,104,180,97,154,24,200,81,23,99,162,105,245,53,118,177,249,79,26,26,27,87,103,70,88,14,185,161,81,237,127,158,69,141,124,166,85,65,163,16,101,180,71,34,96,173,202,123,204,48,80,39,65,185,59,26,207,77,242,177,100,57,69,163,101,33,227,11,166,177,197,208,2,221,193,236,72,68,27,30,47,246,25,240,210,66,138,245,152,195,37,112,165,51,234,210,135,21,113,114,90,37,18,116,140,164,121,187,127,178,188,132,99,199,197,105,128,124,143,168,210,18,71,195,170,17,214,110,52,216,82,203,255,197,149,244,54,76,76,135,122,244,22,74,232,54,207,215,216,38,184,101,49,46,31,146,66,164,190,59,124,3,222,56,184,199,243,151,187,122,167,180,6,213,177,131,231,123,172,58,51,115,137,21,45,57,208,48,154,45,237,63,226,20,181,17,228,95,81,8,58,250,155,48,211,9,173,47,248,141,194,194,58,67,162,45,210,95,8,153,97,38,102,74,135,233,167,56,21,220,196,200,249,231,180,250,122,131,217,109,88,185,179,114,49,182,30,62,125,52,98,73,58,165,73,78,176,39,203,60,111,76,215,1,123,245,219,150,187,110,77,161,147,208,78,103,124,215,105,175,28,118,207,186,202,45,214,246,134,142,239,112,234,14,254,130,19,63,5,107,49,122,227,114,83,213,98,7,63,118,67,232,185,78,206,27,101,197,82,240,106,180,39,146,45,114,200,176,115,150,44,55,112,151,219,158,166,111,139,222,19,219,63,75,186,160,118,122,112,136,142,214,250,119,177,82,23,69,6,134,107,177,174,179,237,198,206,43,197,89,46,62,187,56,125,185,116,16,197,151,96,84,169,57,238,42,141,247,234,14,109,91,23,67,180,231,221,255,26,237,88,53,241,151,160,32,111,227,42,39,213,152,174,43,69,55,37,125,101,69,46,44,94,142,125,205,122,185,163,213,182,234,174,129,184,211,44,59,108,59,6,218,93,127,171,211,161,59,168,101,119,90,226,213,225,211,218,225,234,172,212,26,111,69,215,66,238,141,96,17,247,60,171,73,105,215,120,108,32,147,181,102,90,46,254,133,94,205,86,229,69,144,199,173,172,250,148,143,183,167,199,183,111,192,234,214,247,155,125,175,130,230,89,160,54,248,8,17,89,61,135,222,202,186,97,82,203,180,165,205,139,160,153,147,220,255,55,164,125,115,106,69,189,205,88,217,134,236,53,174,176,246,234,106,169,227,250,1,168,137,204,126,18,80,180,60,0,179,67,191,151,134,66,148,125,5,142,217,10,22,230,10,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExternalAccessSessionStartedMessageLocalizableString());
			LocalizableStrings.Add(CreateExternalAccessSessionEndedMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExternalAccessSessionStartedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("400920bc-ccb5-41e3-ac22-d74e0dc85be5"),
				Name = "ExternalAccessSessionStartedMessage",
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd"),
				CreatedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df"),
				ModifiedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExternalAccessSessionEndedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7f54a547-ff83-45e6-9501-b0794feebae8"),
				Name = "ExternalAccessSessionEndedMessage",
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd"),
				CreatedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df"),
				ModifiedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df"));
		}

		#endregion

	}

	#endregion

}

