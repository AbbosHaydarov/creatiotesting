namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactCommunicationEventListenerSchema

	/// <exclude/>
	public class ContactCommunicationEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactCommunicationEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactCommunicationEventListenerSchema(ContactCommunicationEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47");
			Name = "ContactCommunicationEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,85,203,110,219,48,16,60,59,64,254,129,81,47,18,96,8,61,231,5,228,13,3,73,106,84,73,123,40,122,160,169,181,205,66,34,93,62,156,164,133,255,189,75,82,150,41,71,142,123,49,34,238,206,112,103,119,184,17,180,6,189,160,12,200,19,40,69,181,156,154,252,74,138,41,159,89,69,13,151,226,240,224,239,225,193,192,106,46,102,164,120,211,6,234,147,246,59,134,212,181,20,253,17,5,187,206,243,235,203,157,161,27,97,184,225,160,247,38,228,55,75,16,230,131,188,87,3,74,208,234,89,131,218,157,117,75,153,145,42,220,135,57,159,20,204,80,60,185,170,168,214,199,4,59,98,48,193,169,180,130,51,223,24,127,237,61,199,142,8,80,30,244,195,151,244,214,9,164,5,155,67,77,31,177,205,228,140,36,125,68,73,246,19,193,11,59,169,56,35,204,93,184,255,190,99,114,73,53,244,220,135,76,56,47,252,109,37,60,128,153,203,18,69,140,21,95,82,3,33,186,8,31,100,34,101,69,238,192,140,116,220,167,206,197,233,157,229,37,97,161,164,81,57,36,33,67,8,96,46,76,108,231,51,35,206,47,131,193,146,42,162,161,194,67,212,45,224,133,20,254,35,221,202,246,185,131,1,14,193,10,147,38,163,50,105,142,242,91,37,235,52,65,203,93,148,53,23,207,130,155,54,244,125,14,10,210,117,51,29,38,199,250,127,91,90,165,87,178,178,181,200,199,84,97,199,81,80,218,214,157,173,209,23,162,244,216,166,132,167,183,5,124,68,224,212,186,156,188,40,198,89,70,168,110,148,156,180,50,33,118,152,23,130,146,131,118,116,31,48,107,160,96,180,162,234,148,11,115,158,102,1,169,192,88,37,250,192,71,103,228,179,207,89,53,147,4,81,134,97,238,154,172,247,78,51,216,224,35,185,68,127,243,18,200,82,226,240,190,136,130,46,209,245,169,156,252,114,19,209,200,8,106,72,130,129,46,97,138,79,192,219,232,66,205,52,129,245,12,39,232,177,188,197,174,65,144,69,210,61,1,202,77,3,85,22,146,54,9,44,118,146,107,227,168,196,236,0,203,209,119,238,168,12,61,255,70,43,11,167,206,108,231,110,62,239,112,73,115,47,159,146,180,143,22,219,230,192,110,116,26,112,142,91,25,56,113,109,112,91,212,148,87,206,13,141,198,102,14,129,122,21,213,221,216,230,63,171,109,157,184,145,222,117,250,134,167,251,124,54,154,142,246,60,195,232,5,110,61,162,61,90,112,255,240,234,99,29,218,40,28,49,42,121,180,245,4,84,44,195,163,49,139,151,20,55,36,210,248,157,24,246,165,39,59,29,197,53,251,254,94,75,252,21,45,168,245,188,227,227,218,167,248,160,43,170,67,143,207,208,255,29,177,220,74,21,243,167,30,16,89,225,40,38,108,59,17,4,17,252,231,166,233,204,173,94,183,130,238,37,62,67,254,135,78,42,40,124,124,107,27,229,95,65,75,171,24,70,165,66,216,176,217,78,189,107,187,179,118,147,33,73,222,177,163,217,148,146,234,33,212,144,251,78,175,59,59,48,115,37,95,194,98,44,198,120,47,34,152,129,88,248,205,43,131,133,159,124,163,162,129,250,193,246,175,134,112,218,61,92,253,3,209,140,148,118,227,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e4acc0dc-d8bb-0687-baa4-abd07ca5eb85"),
				Name = "ErrorMessage",
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				CreatedInSchemaUId = new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47"),
				ModifiedInSchemaUId = new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47"));
		}

		#endregion

	}

	#endregion

}

