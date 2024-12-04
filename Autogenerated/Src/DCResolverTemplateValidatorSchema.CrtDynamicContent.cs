namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCResolverTemplateValidatorSchema

	/// <exclude/>
	public class DCResolverTemplateValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCResolverTemplateValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCResolverTemplateValidatorSchema(DCResolverTemplateValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27");
			Name = "DCResolverTemplateValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4f82e5e2-fdef-4aa4-baf8-be69c75a6ead");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,85,201,110,219,48,16,61,43,64,254,97,170,94,44,32,160,209,107,19,59,112,237,52,13,144,0,109,237,54,103,70,26,217,68,37,82,33,41,47,45,252,239,29,82,75,44,197,241,37,23,11,228,12,223,188,89,222,88,242,28,77,193,99,132,5,106,205,141,74,45,155,42,153,138,101,169,185,21,74,178,217,78,242,92,196,116,105,81,218,243,179,127,231,103,65,105,132,92,194,124,103,44,230,228,158,101,24,59,95,195,110,81,162,22,241,101,223,231,94,200,231,151,203,195,80,121,174,228,113,203,219,36,216,131,74,48,51,199,159,105,124,235,158,205,190,144,137,140,31,53,46,9,21,166,25,55,230,51,204,166,63,209,168,108,141,122,129,121,145,113,139,191,121,38,18,110,149,246,238,195,225,16,174,76,153,231,92,239,198,245,185,246,64,67,22,68,136,53,166,163,112,54,109,0,60,193,112,56,134,84,105,48,184,204,137,181,207,4,10,173,98,52,134,53,184,195,3,224,162,124,202,68,12,177,163,117,154,85,64,93,160,223,54,147,7,180,43,149,80,46,223,181,88,147,107,101,45,170,3,220,11,99,175,230,232,186,52,134,91,180,95,69,102,81,155,65,143,47,216,250,116,1,191,12,106,42,182,172,250,10,101,231,24,193,200,177,13,130,198,255,154,77,172,213,226,169,164,122,92,179,199,21,106,28,108,201,9,182,236,206,84,193,6,81,228,159,4,172,226,209,216,23,170,182,247,66,68,100,113,180,7,209,101,55,151,181,18,73,91,253,249,115,246,238,92,220,60,7,193,154,187,62,57,102,6,70,135,53,122,193,233,61,116,83,22,4,34,133,193,135,250,33,155,200,29,229,89,35,6,26,109,169,253,108,7,193,190,117,110,124,187,101,152,171,82,199,120,179,45,52,205,134,27,248,73,38,184,137,216,140,74,32,36,249,69,52,193,165,164,47,140,225,83,27,194,177,38,253,26,190,68,98,45,113,3,247,42,166,218,252,229,79,25,206,169,37,114,217,43,44,123,84,250,143,23,60,115,227,229,162,206,105,162,8,224,162,130,12,194,19,131,23,94,64,248,42,130,97,223,184,153,137,52,165,182,75,235,137,163,185,217,198,88,184,128,11,220,90,70,0,37,134,81,245,173,42,18,216,149,86,27,207,249,78,174,93,128,31,37,234,29,65,150,49,213,13,91,128,65,157,96,116,80,201,125,61,253,40,147,74,0,111,169,193,11,170,50,246,85,220,151,113,193,53,207,73,198,64,155,6,71,97,211,247,70,196,73,181,129,32,174,86,80,163,99,202,223,73,249,181,150,171,27,15,218,71,28,55,117,245,192,62,119,58,176,171,161,247,62,254,184,219,197,112,60,145,32,164,177,92,210,230,86,41,216,21,30,46,34,191,237,186,115,79,121,188,142,128,77,145,235,119,167,59,65,196,93,207,12,108,86,40,129,91,200,144,27,11,118,163,90,233,52,200,43,190,70,72,154,153,128,106,208,128,176,185,33,22,109,88,207,164,222,122,29,97,191,87,206,71,22,196,105,33,31,159,40,127,235,254,48,58,215,251,255,40,44,154,93,53,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHasDifferentAliasesExceptionTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHasDifferentAliasesExceptionTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0516f4b9-03c3-4a08-80ae-8affa9b34e2b"),
				Name = "HasDifferentAliasesExceptionText",
				CreatedInPackageId = new Guid("4f82e5e2-fdef-4aa4-baf8-be69c75a6ead"),
				CreatedInSchemaUId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27"),
				ModifiedInSchemaUId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27"));
		}

		#endregion

	}

	#endregion

}

