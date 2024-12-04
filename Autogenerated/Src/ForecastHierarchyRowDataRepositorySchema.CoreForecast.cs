﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHierarchyRowDataRepositorySchema

	/// <exclude/>
	public class ForecastHierarchyRowDataRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHierarchyRowDataRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHierarchyRowDataRepositorySchema(ForecastHierarchyRowDataRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f");
			Name = "ForecastHierarchyRowDataRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,88,75,111,219,70,16,62,43,64,254,195,66,185,80,128,32,1,61,202,146,80,75,142,93,1,121,184,150,147,30,130,28,86,228,72,98,75,46,153,221,165,13,34,240,127,239,236,139,164,40,146,146,210,180,232,197,198,14,119,102,190,153,249,102,118,87,140,198,32,82,234,3,121,4,206,169,72,182,114,180,76,216,54,220,101,156,202,48,97,163,219,132,131,79,133,252,252,203,235,87,223,95,191,234,101,34,100,59,178,206,133,132,248,170,182,70,213,40,2,95,233,137,209,29,48,224,161,127,180,231,134,74,122,36,124,23,178,111,165,176,138,133,67,179,60,142,19,214,166,49,122,203,100,40,67,16,173,27,110,169,47,19,222,181,227,102,129,159,240,227,27,14,59,140,135,172,152,4,190,197,76,77,200,202,229,228,183,16,56,229,254,62,127,72,158,85,88,15,144,38,34,68,195,185,86,29,143,199,100,42,178,56,166,60,159,219,245,61,79,158,194,0,4,137,65,238,147,64,16,153,16,14,18,161,60,1,145,123,32,1,218,33,123,103,152,36,91,45,69,127,9,199,221,33,211,203,173,5,48,114,94,198,21,55,105,182,137,66,31,183,90,192,231,225,237,169,226,30,65,214,130,59,144,66,187,45,97,241,228,89,40,231,199,222,141,36,165,156,198,132,33,187,102,125,177,7,144,253,249,99,5,55,209,50,2,170,76,249,104,58,214,219,155,181,11,159,198,66,177,236,214,74,233,14,232,38,2,195,101,163,90,228,48,16,199,202,88,131,140,51,49,47,25,172,82,63,21,0,196,231,176,157,245,171,185,235,143,231,211,177,211,80,38,86,111,89,22,227,119,244,56,173,110,156,171,220,85,5,194,91,235,200,117,252,67,165,218,172,187,6,41,145,148,43,236,141,121,25,243,144,220,31,196,69,14,195,28,40,50,191,180,82,239,177,94,193,46,246,248,17,21,130,84,161,59,138,184,134,64,38,167,192,85,151,77,200,189,86,210,158,59,40,148,112,34,28,149,76,49,176,22,138,3,91,116,211,197,166,39,26,101,80,44,31,79,168,151,187,109,44,119,89,24,144,7,173,177,10,200,119,178,3,121,165,144,92,145,151,75,32,107,187,151,193,172,171,28,65,19,216,249,56,123,62,43,121,19,178,55,192,2,147,111,189,54,210,154,176,107,66,97,221,214,9,151,107,137,211,28,118,29,99,73,117,3,160,62,134,188,249,19,27,160,210,170,168,175,48,10,107,227,52,107,90,156,107,31,162,115,210,56,77,211,31,45,185,182,190,76,35,153,191,231,214,116,153,113,14,44,175,180,65,132,115,55,234,118,132,131,212,42,150,173,252,78,169,213,221,118,244,158,202,67,145,65,149,219,50,191,14,75,232,211,168,152,171,23,12,245,163,18,119,228,119,109,56,29,0,39,155,28,241,160,70,140,97,105,64,2,212,224,59,123,168,235,221,253,249,90,255,39,223,50,224,185,58,203,104,154,70,104,89,133,155,164,250,34,128,210,83,179,90,241,162,63,47,139,175,180,211,130,145,237,195,250,112,8,91,40,215,10,129,202,200,71,227,223,179,114,131,120,216,205,78,242,171,65,83,25,165,45,221,182,84,84,159,84,173,125,64,188,181,74,156,197,6,172,68,16,138,52,162,185,153,23,196,79,162,44,102,63,194,146,47,55,176,165,89,36,23,33,11,176,103,61,153,167,144,108,189,54,174,12,6,95,59,122,183,30,15,153,156,32,221,127,64,59,199,149,195,12,150,92,33,246,124,165,44,104,238,217,65,55,23,29,173,11,46,170,84,59,140,103,242,208,205,167,159,73,71,162,123,186,103,129,44,247,224,255,117,205,119,120,111,96,242,67,22,69,158,66,143,133,54,223,7,154,189,189,222,19,229,142,89,250,128,89,26,94,205,92,60,102,45,70,183,33,23,210,179,74,38,18,183,229,163,42,218,34,191,22,190,119,108,105,64,168,176,97,106,221,151,11,123,230,255,121,125,54,110,1,104,36,18,123,247,59,227,2,221,39,227,115,26,176,221,64,71,47,182,43,97,75,46,168,128,166,141,229,166,225,37,15,128,162,84,72,85,201,51,245,74,170,221,239,44,196,211,38,189,79,2,56,218,97,246,62,157,29,44,7,154,109,19,178,65,252,94,237,19,30,172,205,247,159,94,21,226,123,67,129,115,111,159,255,198,3,166,242,62,208,115,71,177,224,199,158,51,141,79,141,202,43,224,180,229,166,39,143,147,225,145,82,121,211,87,125,29,62,40,154,189,184,225,70,206,123,28,161,141,198,129,248,79,30,73,63,245,153,100,135,105,207,92,50,219,135,169,250,236,102,105,239,208,70,187,86,205,151,83,215,191,72,228,107,127,15,49,181,239,94,187,152,145,195,62,49,63,94,216,175,239,41,67,123,28,127,76,145,43,108,72,202,124,88,228,159,86,129,1,87,252,56,99,84,80,238,220,169,209,111,70,56,218,87,249,61,220,105,134,182,87,197,49,82,199,253,208,228,124,80,177,98,152,131,86,24,60,219,97,255,187,186,236,153,248,188,34,153,238,250,229,78,23,87,183,162,86,248,165,172,144,211,209,117,70,149,106,165,107,197,155,213,202,103,118,189,88,136,246,184,194,8,43,216,254,8,229,222,29,183,6,191,141,168,97,170,52,158,88,184,239,111,195,232,246,69,26,19,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmptyHierarchyValueLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmptyHierarchyValueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a416b392-9149-46c8-b2a6-121bc2cb969e"),
				Name = "EmptyHierarchyValue",
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f"),
				ModifiedInSchemaUId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f"));
		}

		#endregion

	}

	#endregion

}

