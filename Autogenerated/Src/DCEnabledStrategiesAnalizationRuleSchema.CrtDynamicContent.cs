﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCEnabledStrategiesAnalizationRuleSchema

	/// <exclude/>
	public class DCEnabledStrategiesAnalizationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCEnabledStrategiesAnalizationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCEnabledStrategiesAnalizationRuleSchema(DCEnabledStrategiesAnalizationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0d13a6b-c13b-4508-ac19-81807f584656");
			Name = "DCEnabledStrategiesAnalizationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,87,75,111,227,54,16,62,123,129,253,15,132,123,113,128,84,222,246,184,217,4,72,157,108,80,96,55,45,54,105,115,40,122,160,229,145,77,172,68,10,36,21,199,73,243,223,251,241,37,59,146,156,199,165,104,14,134,56,28,206,227,155,225,55,140,228,21,153,154,231,196,174,73,107,110,84,97,179,153,146,133,88,54,154,91,161,100,118,182,145,188,18,57,132,150,164,125,255,238,225,253,187,81,99,132,92,178,171,141,177,84,29,181,235,93,11,85,165,36,118,176,247,131,166,37,236,176,89,201,141,249,200,206,102,231,146,207,75,90,92,89,56,192,22,153,83,201,203,205,189,247,246,173,41,201,159,154,78,167,236,147,105,170,138,235,205,73,92,199,19,27,166,201,168,242,150,52,211,80,103,118,197,45,227,206,134,33,131,21,49,99,161,199,84,49,228,140,25,31,53,51,100,45,130,206,146,175,233,142,179,186,153,151,34,103,185,139,248,21,1,51,151,85,10,238,91,140,45,100,50,2,90,248,109,65,56,151,77,5,16,126,215,202,82,110,105,17,118,187,201,122,65,244,138,64,151,21,128,247,222,144,89,138,193,5,222,143,124,244,215,231,146,47,205,223,238,179,78,78,24,193,235,32,22,174,150,163,209,165,146,196,142,217,135,67,191,186,208,170,169,93,57,143,217,79,65,130,106,206,133,12,162,159,157,228,49,38,69,114,17,242,122,154,36,90,5,113,54,185,85,218,229,234,193,124,38,209,29,117,102,21,171,53,213,92,19,3,248,150,229,43,46,36,147,106,65,108,45,236,74,53,168,52,147,116,103,67,233,231,88,59,57,91,80,193,155,210,110,125,16,177,92,83,113,60,70,101,118,0,76,85,250,133,27,26,79,79,152,128,107,46,115,218,131,166,151,32,26,94,49,92,2,58,30,231,238,22,220,217,241,201,169,108,207,186,70,219,235,112,22,15,192,151,111,167,236,211,212,219,27,54,31,211,72,81,142,79,110,68,89,178,57,161,227,109,163,37,74,41,10,160,145,218,96,195,76,77,185,40,4,45,158,216,141,253,251,114,231,78,6,131,101,49,203,80,253,209,126,4,19,236,73,118,128,155,48,135,124,146,12,244,21,30,118,250,231,45,221,80,209,66,160,137,59,253,224,111,123,219,14,255,147,34,186,120,28,184,219,234,225,38,230,100,204,127,93,190,61,172,228,1,115,31,7,161,190,221,154,181,219,79,138,181,239,178,131,202,106,210,22,193,189,142,214,126,149,121,217,44,192,61,133,35,42,7,123,236,17,102,154,186,86,218,190,153,242,182,60,55,68,113,103,193,122,127,227,216,31,70,119,247,182,178,150,2,255,25,50,153,181,124,120,244,60,52,95,9,140,181,240,184,136,91,28,14,187,117,88,12,6,123,65,253,64,39,177,14,163,91,174,193,228,157,221,63,121,217,56,242,158,41,77,157,193,141,241,124,21,134,28,50,34,235,53,39,177,71,178,63,12,105,124,75,0,7,221,120,211,209,246,61,247,227,67,54,17,210,30,236,195,241,192,205,255,209,40,16,20,67,71,246,53,134,131,62,218,105,174,132,9,106,237,96,71,180,95,242,251,43,191,8,97,199,141,50,191,191,196,29,75,136,36,169,202,121,41,238,157,147,112,198,233,0,147,176,157,125,86,186,226,118,50,254,210,85,51,217,195,135,199,204,59,64,150,201,246,81,11,118,207,46,108,74,90,179,158,161,61,168,102,55,74,127,247,143,171,204,221,191,70,231,208,87,154,47,41,226,237,248,66,21,147,151,47,250,193,225,112,146,49,216,136,195,109,236,133,158,106,200,49,232,130,129,38,81,17,217,52,101,153,192,28,237,63,142,122,204,80,251,70,83,168,198,5,73,210,188,236,36,149,161,69,162,218,33,43,120,105,82,120,143,187,29,114,219,173,253,203,183,231,197,7,196,138,242,239,134,173,87,34,95,237,227,14,230,134,72,108,196,150,71,110,86,36,253,8,81,178,220,224,135,182,204,44,204,150,156,227,244,53,76,216,167,71,65,229,209,228,174,167,31,97,82,171,117,120,138,210,93,78,181,111,134,116,242,55,136,245,90,96,122,2,230,210,132,241,229,158,175,128,220,7,237,70,217,62,174,243,146,24,206,171,199,87,247,209,131,201,186,163,235,122,0,82,76,160,100,183,117,212,6,31,85,207,211,122,124,114,29,82,92,3,134,143,73,255,82,13,162,239,193,236,66,127,13,16,200,109,52,114,203,251,185,155,235,5,194,235,163,154,237,12,70,133,65,166,5,84,159,121,153,160,101,211,250,180,174,113,202,25,188,86,126,106,62,75,168,184,0,195,44,188,229,5,252,199,100,208,239,65,179,67,84,227,75,213,59,123,174,181,210,95,195,161,113,186,178,120,190,160,91,39,61,255,237,117,204,93,26,67,227,199,61,215,61,230,248,243,157,230,73,169,173,205,36,134,23,29,237,183,147,166,92,178,21,47,168,51,118,54,75,155,9,196,68,113,47,90,157,165,225,56,104,182,221,125,179,221,215,206,228,174,91,116,119,52,29,223,25,175,135,206,243,214,48,75,5,233,83,33,100,255,2,83,80,139,66,78,15,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoEnabledStrategiesErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoEnabledStrategiesErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("542c751e-6e66-4180-b1f9-e65e7639c0ef"),
				Name = "NoEnabledStrategiesErrorMessage",
				CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a"),
				CreatedInSchemaUId = new Guid("c0d13a6b-c13b-4508-ac19-81807f584656"),
				ModifiedInSchemaUId = new Guid("c0d13a6b-c13b-4508-ac19-81807f584656")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0d13a6b-c13b-4508-ac19-81807f584656"));
		}

		#endregion

	}

	#endregion

}

