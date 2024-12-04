namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormulaCalculationServiceSchema

	/// <exclude/>
	public class FormulaCalculationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormulaCalculationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormulaCalculationServiceSchema(FormulaCalculationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb");
			Name = "FormulaCalculationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,86,109,111,219,54,16,254,172,2,253,15,132,247,69,6,2,253,128,44,9,144,164,73,234,109,137,3,43,67,129,165,69,65,75,103,91,43,37,106,36,101,215,107,243,223,119,71,82,146,109,249,37,193,154,97,95,108,233,120,239,247,60,71,21,60,7,93,242,4,216,3,40,197,181,156,152,232,82,22,147,108,90,41,110,50,89,68,215,82,229,149,224,111,223,124,123,251,38,168,116,86,76,89,188,212,6,242,159,55,222,209,78,8,72,200,72,71,55,80,128,202,146,142,206,29,152,142,108,84,21,38,203,33,138,209,130,139,236,111,27,183,163,133,167,243,44,129,91,153,130,216,123,24,125,128,241,126,133,115,76,114,190,17,165,45,31,205,177,148,60,223,126,122,41,21,212,61,57,116,30,189,227,134,223,43,57,207,82,80,122,237,205,245,88,239,246,192,19,35,85,6,250,96,140,171,175,9,148,182,233,251,139,169,91,48,146,149,65,157,86,249,14,22,6,173,73,251,23,109,139,198,163,159,20,76,209,39,187,20,92,235,99,230,131,93,114,145,224,31,69,171,189,33,122,208,24,172,209,35,85,136,149,25,133,217,127,66,65,89,141,69,150,176,132,156,28,246,193,142,217,26,244,58,33,2,132,32,254,54,201,93,103,32,82,204,238,94,209,56,93,14,65,233,94,152,28,255,137,96,100,159,21,232,74,16,232,172,37,20,169,51,94,247,132,113,181,81,21,245,28,221,217,172,189,55,87,193,193,220,195,62,251,198,158,94,104,211,140,142,65,253,212,39,7,193,49,27,115,60,111,165,173,243,93,21,32,176,74,80,6,17,179,94,128,157,201,45,228,99,80,225,29,146,157,157,178,158,107,73,175,255,105,37,91,223,174,145,61,98,196,245,32,152,2,62,49,5,166,82,69,211,72,74,4,207,52,157,217,167,32,155,176,112,206,69,5,44,211,12,195,193,3,178,185,95,159,6,222,16,3,19,188,176,211,115,204,179,33,59,12,109,96,231,224,136,21,176,176,106,205,177,138,193,16,94,117,227,47,160,16,212,92,110,222,243,34,21,132,225,83,214,21,70,3,45,91,169,55,126,234,71,35,40,5,46,188,176,247,177,215,59,98,56,118,210,189,202,75,179,236,19,41,72,137,129,64,56,118,11,176,73,214,74,246,207,254,110,31,141,147,110,8,159,203,43,207,39,152,112,140,188,194,92,160,153,61,198,186,236,202,156,96,149,126,143,231,186,196,133,139,252,47,209,247,56,19,153,89,142,224,175,42,83,144,67,97,116,184,250,66,171,17,75,60,96,66,90,145,23,164,253,231,115,28,185,125,129,144,110,170,219,164,242,45,152,153,220,201,101,55,36,118,67,137,173,44,136,43,165,164,186,5,173,249,20,66,175,243,5,150,53,244,60,112,127,215,118,221,22,238,106,194,155,201,252,38,19,123,207,140,5,196,214,42,236,237,76,28,33,66,46,237,208,159,214,179,58,188,208,48,86,195,241,134,245,222,108,136,116,69,164,58,62,104,170,102,203,54,88,175,132,200,113,120,171,116,172,3,219,167,65,49,145,56,223,26,212,190,109,40,105,244,163,120,38,149,241,7,107,32,255,129,213,111,169,178,38,33,19,126,46,36,252,181,157,227,156,171,86,185,241,126,250,74,237,216,11,178,205,12,187,93,170,103,213,73,120,181,135,187,150,120,203,130,213,13,110,145,66,174,86,185,29,60,226,213,62,40,230,242,11,132,206,140,54,251,253,48,126,64,196,18,65,65,27,183,249,80,142,170,190,2,39,178,23,61,169,185,212,14,232,217,178,46,100,186,140,205,82,192,154,90,35,141,62,40,94,150,126,37,60,251,6,100,245,81,67,223,137,51,105,32,129,59,7,55,80,156,204,32,231,116,125,29,177,155,42,75,241,78,74,164,74,7,169,203,237,93,102,169,205,213,242,196,153,29,249,235,236,140,37,51,94,76,1,89,38,170,188,208,53,4,140,90,214,147,39,112,53,251,221,110,101,247,233,181,164,69,113,50,216,40,65,170,179,208,15,61,104,190,147,33,36,36,186,16,221,111,188,112,125,255,28,109,41,169,169,102,51,221,54,84,211,39,223,160,250,170,122,201,102,104,192,238,47,249,83,95,184,7,177,243,248,196,18,110,146,25,11,187,238,182,46,168,197,12,10,214,146,44,26,96,161,170,213,164,47,130,140,186,113,177,252,3,148,188,234,144,113,23,185,183,46,143,149,149,81,111,108,75,79,10,65,43,212,5,233,213,205,49,51,37,23,182,55,136,216,107,186,73,27,151,39,7,187,117,214,70,171,69,14,109,65,240,222,152,50,54,220,84,250,146,174,195,65,97,64,21,92,144,3,172,157,18,234,191,86,51,135,24,97,34,228,162,21,126,255,206,246,25,156,171,105,69,55,247,176,50,195,201,136,208,245,74,51,136,241,99,141,180,33,133,244,255,59,129,151,220,186,255,54,251,253,237,235,239,168,229,130,167,126,125,111,150,176,47,213,31,50,194,65,129,31,184,89,122,245,181,196,197,64,205,249,175,231,216,173,253,101,159,215,168,254,15,49,88,201,184,209,16,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFormulaErrorDivisionByZeroLocalizableString());
			LocalizableStrings.Add(CreateFormulaErrorInvalidExpressionLocalizableString());
			LocalizableStrings.Add(CreateFormulaErrorSizeExceededLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFormulaErrorDivisionByZeroLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2803ac41-a52f-49a0-9401-5d8ea0a163c6"),
				Name = "FormulaErrorDivisionByZero",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"),
				ModifiedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFormulaErrorInvalidExpressionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dc7e4609-6ddd-4c7b-8ad4-b56900b4b4d5"),
				Name = "FormulaErrorInvalidExpression",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"),
				ModifiedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFormulaErrorSizeExceededLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9e2fbf3c-ae0a-4801-aa90-f7fb21b38026"),
				Name = "FormulaErrorSizeExceeded",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"),
				ModifiedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"));
		}

		#endregion

	}

	#endregion

}

