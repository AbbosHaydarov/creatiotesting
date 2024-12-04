namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CryptographicServiceSchema

	/// <exclude/>
	public class CryptographicServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CryptographicServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CryptographicServiceSchema(CryptographicServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378");
			Name = "CryptographicService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55f82158-5486-4bb7-b202-c8f84f805cfa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,84,223,111,218,48,16,126,78,165,254,15,86,246,18,36,100,222,215,31,82,219,177,169,219,104,43,210,141,7,212,7,147,28,52,106,98,123,103,135,46,155,246,191,239,156,56,36,132,142,33,8,248,252,221,247,125,190,59,35,69,1,70,139,4,216,35,32,10,163,214,150,223,40,185,206,54,37,10,155,41,121,122,242,251,244,36,40,77,38,55,44,174,140,133,226,108,176,222,199,31,236,198,128,219,44,129,153,74,33,63,186,201,23,176,58,14,184,74,108,182,29,168,244,109,23,197,191,118,16,222,138,147,96,151,69,251,75,175,70,7,178,40,18,251,228,98,87,70,223,129,37,152,38,229,85,150,103,182,154,195,143,50,67,40,64,90,19,245,23,206,38,187,96,255,73,113,40,238,3,233,200,137,232,114,149,103,9,75,114,97,12,187,193,74,91,181,65,161,159,179,196,59,98,239,217,181,48,208,174,92,75,130,229,189,134,166,230,125,191,193,146,78,117,43,183,234,5,162,25,216,103,149,146,161,240,225,62,126,12,199,236,90,165,85,108,171,220,153,36,216,12,140,17,27,216,69,249,130,68,53,164,99,199,19,56,135,96,236,71,133,133,176,123,9,77,136,127,54,74,142,217,156,230,71,73,3,199,113,238,152,142,117,50,153,176,115,83,22,133,192,234,178,13,188,235,191,118,43,255,131,190,58,0,251,48,141,249,142,103,50,36,58,215,2,69,193,36,13,245,69,168,169,152,175,10,211,240,178,227,235,73,241,243,73,141,238,146,17,108,137,210,120,248,120,223,86,63,181,191,38,154,54,207,17,249,78,26,139,110,212,62,185,41,144,91,64,11,233,131,183,243,93,228,37,68,30,208,122,28,53,45,13,178,53,243,91,252,214,220,149,121,126,143,211,66,219,42,218,1,91,100,208,168,122,37,94,163,220,140,7,193,159,250,185,21,200,146,122,146,252,208,124,129,138,154,179,119,87,103,66,82,151,144,95,105,29,131,181,196,99,150,225,204,108,190,25,192,214,46,21,252,102,64,19,62,157,29,55,59,212,237,76,59,87,8,70,149,152,64,108,21,146,60,153,114,122,100,76,2,221,111,37,249,66,225,75,253,159,68,151,100,15,122,214,145,208,29,86,232,199,140,24,36,188,178,175,42,17,121,246,75,172,114,194,59,87,209,64,169,25,235,32,8,223,186,97,116,59,194,3,6,195,135,103,159,254,76,64,215,181,107,180,121,221,206,112,228,173,217,103,84,175,181,27,87,143,57,172,1,65,38,176,203,138,250,190,125,82,211,47,63,16,197,126,245,155,166,13,235,201,31,149,63,161,167,104,254,216,162,131,158,63,160,218,102,41,160,175,208,176,151,237,118,116,168,122,48,103,111,242,242,169,172,227,221,120,246,142,228,30,244,161,247,95,242,229,208,255,101,6,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCryptoServiceKeyExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCryptoServiceKeyExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7264c8f8-6a12-42f2-b6d0-3a6bc04b2a99"),
				Name = "CryptoServiceKeyExceptionMessage",
				CreatedInPackageId = new Guid("55f82158-5486-4bb7-b202-c8f84f805cfa"),
				CreatedInSchemaUId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378"),
				ModifiedInSchemaUId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378"));
		}

		#endregion

	}

	#endregion

}

