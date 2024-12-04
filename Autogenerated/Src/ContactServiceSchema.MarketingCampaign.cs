namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactServiceSchema

	/// <exclude/>
	public class ContactServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactServiceSchema(ContactServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a");
			Name = "ContactService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,84,77,107,219,64,16,61,43,144,255,48,56,23,27,140,124,79,99,135,36,52,52,133,124,16,219,228,96,74,217,72,35,101,233,126,40,59,43,21,83,250,223,59,187,146,21,199,40,233,109,247,205,204,211,155,183,51,50,66,35,85,34,67,88,161,115,130,108,225,211,43,107,10,89,214,78,120,105,205,241,209,159,227,163,164,38,105,74,88,110,201,163,78,151,232,26,153,225,173,205,81,125,249,44,152,94,100,94,54,145,230,243,188,39,124,126,75,120,19,194,48,139,209,58,150,115,252,196,97,201,92,112,165,4,209,41,176,78,47,50,223,49,197,140,77,119,9,33,199,177,31,1,187,160,234,14,61,19,85,44,229,89,42,233,183,143,248,90,75,135,26,141,167,241,254,37,232,129,57,252,167,36,100,165,29,144,79,194,71,170,250,89,201,12,178,160,236,64,24,156,194,165,32,236,101,38,193,208,190,151,7,103,43,116,94,34,55,244,16,73,98,35,73,229,130,115,120,192,245,13,21,103,195,207,108,0,109,61,74,102,179,25,156,81,173,181,112,219,197,14,184,49,228,133,97,45,182,24,100,76,251,202,217,126,105,215,213,160,134,65,48,182,150,148,232,97,190,24,86,9,231,231,48,30,142,204,193,224,239,65,222,241,154,208,113,192,32,15,148,53,147,73,152,150,36,161,207,190,51,135,70,168,26,99,230,223,214,154,19,52,121,107,123,119,239,222,224,22,253,139,205,15,30,96,208,199,71,212,182,65,130,66,137,18,238,172,225,1,175,133,130,194,89,189,19,14,194,228,253,57,76,111,109,100,22,119,224,3,147,35,82,9,39,52,24,222,198,249,168,144,202,163,163,209,226,186,61,128,183,64,168,184,247,29,111,122,54,139,5,195,245,60,161,60,175,203,236,5,181,88,223,228,163,69,123,4,22,242,90,35,200,60,36,20,146,95,125,159,102,115,207,174,69,157,251,203,147,108,120,9,111,76,99,127,225,184,181,137,141,29,61,220,47,87,163,41,172,157,92,161,174,84,152,83,70,151,232,91,63,190,106,33,21,113,194,165,205,183,75,191,85,33,204,60,183,72,36,74,236,209,244,201,137,170,194,124,26,95,51,236,19,146,191,182,78,11,255,174,224,58,66,233,119,178,102,202,79,64,149,53,212,129,31,229,197,165,220,205,111,99,101,14,7,234,198,228,93,248,219,116,102,79,161,187,31,152,55,233,70,122,112,105,214,85,206,173,119,161,11,218,154,236,202,58,28,247,148,135,92,237,44,38,201,224,52,182,51,186,15,50,242,15,197,122,229,232,159,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRemindingUpdateMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRemindingUpdateMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dcc3279a-ae13-4ada-8127-1557b79bc092"),
				Name = "RemindingUpdateMessage",
				CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc"),
				CreatedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"),
				ModifiedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"));
		}

		#endregion

	}

	#endregion

}

