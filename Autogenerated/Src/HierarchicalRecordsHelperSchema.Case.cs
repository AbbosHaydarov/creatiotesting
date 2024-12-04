﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HierarchicalRecordsHelperSchema

	/// <exclude/>
	public class HierarchicalRecordsHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HierarchicalRecordsHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HierarchicalRecordsHelperSchema(HierarchicalRecordsHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87fe419d-20a5-48e1-89db-5c4063d4534b");
			Name = "HierarchicalRecordsHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4057c03e-fa31-4cb4-9ecf-0f27311073bf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,87,77,111,219,56,16,61,171,64,255,3,225,94,20,192,144,239,137,99,96,253,145,196,64,210,45,226,221,237,177,160,165,177,37,84,34,189,36,229,212,187,240,127,239,80,164,36,90,162,220,0,11,108,14,145,73,61,206,188,121,51,67,82,140,22,32,15,52,6,242,7,8,65,37,223,169,104,193,217,46,219,151,130,170,140,179,143,31,254,253,248,33,40,101,198,246,100,115,146,10,138,187,206,24,241,121,14,177,6,203,232,17,24,136,44,238,97,150,84,209,118,210,245,85,20,156,249,223,8,24,154,143,150,243,193,87,43,166,50,149,129,68,0,66,62,9,216,35,49,178,200,169,148,183,228,41,3,65,69,156,102,49,205,95,33,230,34,145,21,236,80,110,243,44,38,177,70,249,65,1,202,128,255,27,131,15,25,228,9,90,252,34,178,35,85,96,94,30,204,128,72,37,52,179,111,160,185,156,54,113,10,5,253,140,74,223,249,97,7,42,16,137,50,150,5,243,192,254,148,32,48,39,204,104,76,190,149,23,99,11,254,4,44,185,70,173,17,2,179,164,68,25,43,46,52,164,138,219,186,51,26,120,162,15,59,12,46,9,140,235,56,186,209,54,47,186,241,221,16,93,83,65,208,137,132,220,119,44,223,25,84,215,46,226,60,194,106,100,215,17,34,61,218,6,193,185,167,217,176,44,181,112,47,160,82,222,147,117,50,153,144,169,44,139,130,138,211,172,158,120,4,101,25,146,157,224,5,89,206,201,246,68,178,132,52,43,38,221,37,83,228,73,11,194,144,225,253,8,114,40,112,253,58,25,205,166,147,234,69,139,19,160,74,193,228,236,181,122,90,55,211,73,61,237,214,77,213,9,39,205,198,252,10,31,75,228,208,24,175,179,176,114,180,36,210,60,238,187,85,22,185,168,23,202,232,30,4,54,187,90,163,108,148,197,48,63,105,113,195,94,174,110,76,102,44,21,43,202,189,117,19,45,4,32,81,203,174,227,209,174,52,75,162,7,80,113,250,128,98,46,231,97,27,129,129,152,216,173,241,129,252,250,179,215,207,173,147,120,111,106,23,41,196,223,73,182,179,117,85,171,73,50,70,82,219,56,39,194,119,56,144,22,18,189,51,233,216,113,121,226,77,185,139,50,54,175,86,198,52,158,97,37,195,116,18,207,52,81,31,195,78,189,152,198,223,114,158,147,39,42,191,24,23,108,46,48,177,169,41,26,75,110,76,170,81,77,162,174,32,3,41,133,153,109,154,110,157,152,252,60,103,82,77,53,102,134,118,80,62,64,75,18,81,12,222,136,243,206,216,10,26,59,213,240,108,76,152,157,62,60,82,65,146,237,234,7,196,37,54,170,183,74,101,41,96,57,111,167,194,155,154,101,240,134,65,0,9,181,56,205,92,176,65,125,98,85,179,95,25,177,236,164,161,104,6,189,242,180,235,131,200,236,45,97,111,243,105,17,186,110,61,173,17,125,77,65,64,56,194,108,222,68,107,185,250,187,164,121,104,214,71,152,4,132,40,16,97,163,7,6,66,165,101,99,84,105,116,89,235,227,245,21,104,2,130,96,75,233,199,189,55,164,200,104,7,6,27,182,90,182,42,5,1,22,77,104,172,68,26,231,40,120,249,114,45,151,243,207,101,158,215,99,220,14,126,23,73,198,48,138,190,24,23,70,234,150,221,209,92,218,189,91,255,157,177,88,37,184,56,183,178,108,32,182,60,117,153,181,126,141,163,191,104,142,117,95,85,147,135,65,235,167,10,194,111,53,170,178,32,67,91,240,151,172,107,218,186,130,28,107,231,142,225,166,198,245,77,74,209,140,201,1,103,29,235,246,180,124,230,120,242,102,255,208,109,14,27,51,99,91,165,59,223,45,201,232,43,23,223,171,203,28,230,77,242,82,196,8,228,2,183,234,177,227,37,24,121,78,248,39,200,15,32,70,99,50,234,121,145,145,139,95,9,193,197,11,72,137,86,163,74,239,145,43,108,160,82,193,223,44,93,126,88,179,122,237,105,245,35,134,67,213,144,61,15,174,129,126,9,4,142,158,191,37,201,144,148,46,9,119,43,242,195,189,217,107,126,213,63,236,211,60,206,206,193,226,61,26,54,120,234,119,78,5,197,107,255,245,212,255,112,24,216,237,252,200,177,117,22,41,101,123,48,81,191,103,39,239,158,211,237,221,161,110,136,139,83,121,115,209,121,253,158,27,183,14,46,215,209,35,132,85,243,155,249,107,178,190,66,193,143,208,85,182,186,87,89,109,255,139,166,174,88,198,147,43,214,251,229,25,136,243,151,250,48,220,63,223,165,141,247,46,99,111,43,22,227,94,103,175,127,238,116,190,138,158,7,90,181,255,105,52,132,36,183,196,89,165,191,149,26,105,135,150,132,86,212,170,175,126,133,181,91,35,126,171,234,141,199,156,172,183,100,75,37,132,245,92,107,109,72,141,107,97,158,127,2,22,59,237,103,9,15,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHierarchicalErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHierarchicalErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("10431e3a-1f45-409e-81ff-b6cda04620b5"),
				Name = "HierarchicalErrorMessage",
				CreatedInPackageId = new Guid("4057c03e-fa31-4cb4-9ecf-0f27311073bf"),
				CreatedInSchemaUId = new Guid("87fe419d-20a5-48e1-89db-5c4063d4534b"),
				ModifiedInSchemaUId = new Guid("87fe419d-20a5-48e1-89db-5c4063d4534b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87fe419d-20a5-48e1-89db-5c4063d4534b"));
		}

		#endregion

	}

	#endregion

}

