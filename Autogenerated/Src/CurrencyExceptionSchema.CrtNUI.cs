namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CurrencyExceptionSchema

	/// <exclude/>
	public class CurrencyExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CurrencyExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CurrencyExceptionSchema(CurrencyExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf");
			Name = "CurrencyException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,86,77,111,218,64,16,61,19,169,255,97,228,244,0,18,50,119,74,124,65,73,138,148,164,81,130,122,232,109,177,7,216,214,222,117,119,215,16,18,229,191,119,236,181,141,193,54,132,54,145,26,9,5,15,179,51,111,62,222,91,11,22,161,142,153,143,48,69,165,152,150,115,227,142,165,152,243,69,162,152,225,82,184,227,68,41,20,254,230,242,201,199,56,181,124,58,123,249,116,214,73,52,23,11,120,220,104,131,209,151,242,121,44,163,72,10,122,38,203,185,194,5,185,195,56,100,90,15,161,140,163,148,84,183,168,53,91,224,87,12,99,84,153,247,96,48,128,145,78,162,136,169,141,151,63,223,43,185,226,1,106,72,12,15,185,217,64,132,102,41,3,13,115,169,96,45,213,175,52,229,154,155,37,16,118,50,69,54,42,200,57,152,37,130,159,103,116,139,240,131,74,124,46,12,42,193,66,208,134,234,244,193,79,81,30,4,217,73,203,46,171,186,181,80,134,4,146,175,152,193,172,136,90,21,153,225,1,77,162,132,134,80,250,44,228,207,108,22,34,101,85,41,120,35,119,161,167,80,235,88,173,37,102,138,69,32,104,96,23,142,54,82,145,187,227,61,160,150,137,162,241,229,22,119,52,200,252,154,143,85,16,60,102,0,238,200,236,120,55,117,96,169,127,61,150,178,149,120,163,65,241,45,253,41,78,102,33,117,48,111,100,30,224,26,77,181,137,83,140,226,144,218,212,157,20,136,31,45,224,2,120,191,56,216,136,177,7,89,243,59,43,166,108,195,246,194,194,5,8,92,195,205,254,217,110,25,221,169,237,177,211,207,66,118,62,59,181,99,218,125,105,132,241,234,126,103,97,130,78,47,221,248,78,199,54,161,17,144,59,149,57,2,235,251,106,247,227,28,69,96,23,40,125,162,143,181,87,205,237,204,185,147,230,74,38,34,168,48,177,133,56,83,218,126,44,188,136,11,204,0,215,244,95,201,181,128,245,18,69,201,13,32,126,9,195,231,28,21,4,146,168,38,164,33,122,81,22,160,173,52,54,206,146,9,26,20,233,1,110,125,52,154,70,94,229,203,176,75,167,26,114,24,194,93,18,134,223,212,101,20,155,170,180,164,36,171,210,140,180,136,246,34,241,105,140,41,215,178,224,121,235,154,201,54,17,220,240,116,114,132,147,101,75,193,41,2,19,126,41,11,35,141,164,13,10,231,23,78,43,62,103,224,217,18,62,152,144,197,24,38,129,227,141,235,35,217,57,156,119,182,21,243,1,106,93,39,60,40,71,62,9,122,217,246,14,97,198,52,118,247,136,186,101,76,197,63,167,223,107,209,249,189,125,61,34,138,177,125,40,4,162,198,182,125,173,56,161,144,227,178,112,80,209,233,207,109,19,170,186,114,212,58,158,31,217,147,3,171,99,238,149,84,17,51,221,38,88,59,189,109,147,135,19,197,225,62,221,19,164,59,237,134,114,17,175,126,39,44,212,63,80,201,203,39,243,126,106,17,23,89,32,164,52,169,68,96,150,8,158,41,211,219,245,224,0,216,173,64,156,172,10,239,171,9,199,49,254,143,34,81,59,92,78,204,94,245,101,85,45,55,124,245,232,42,187,235,188,3,26,116,188,71,111,231,114,126,27,231,111,1,59,176,251,32,103,63,209,55,144,33,234,193,137,242,213,223,143,102,195,108,69,237,159,37,173,249,157,231,67,106,183,130,151,123,126,188,230,221,31,157,240,223,139,96,86,81,109,56,111,144,198,150,55,39,242,252,3,149,146,174,90,207,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCurrencyNotFoundExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateCurrencyParameterLessOrEqualsZeroExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCurrencyNotFoundExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a74da309-e90a-4cbe-9b82-2327571ebd4e"),
				Name = "CurrencyNotFoundExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf"),
				ModifiedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCurrencyParameterLessOrEqualsZeroExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("47fc8d47-9788-470a-afd5-51c6e1736e59"),
				Name = "CurrencyParameterLessOrEqualsZeroExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf"),
				ModifiedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf"));
		}

		#endregion

	}

	#endregion

}

