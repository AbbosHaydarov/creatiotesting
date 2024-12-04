namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecuredFolderFavoriteQueryExecutorSchema

	/// <exclude/>
	public class SecuredFolderFavoriteQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecuredFolderFavoriteQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecuredFolderFavoriteQueryExecutorSchema(SecuredFolderFavoriteQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7c6e626-3da4-4dd0-a413-a934aea09181");
			Name = "SecuredFolderFavoriteQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd00e878-1009-445f-bd06-4d0e05a51d60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,86,77,111,219,56,16,61,171,64,255,3,215,93,20,50,224,40,237,53,169,13,36,94,187,8,144,180,105,221,143,67,16,44,24,105,100,19,149,72,149,164,220,104,3,255,247,14,69,202,150,44,203,118,209,221,245,193,146,200,225,204,123,51,143,67,114,154,130,202,104,8,228,19,72,73,149,136,117,48,22,60,102,243,92,82,205,4,127,254,236,233,249,51,47,87,140,207,201,172,80,26,210,243,173,111,180,79,18,8,141,177,10,222,2,7,201,194,150,205,53,227,223,55,131,245,88,105,42,248,238,25,9,93,227,193,132,107,166,25,168,78,131,41,13,181,144,214,2,109,94,72,152,35,62,50,78,168,82,103,100,6,97,46,33,154,138,36,2,57,165,75,180,212,240,33,7,89,76,30,113,10,87,150,171,238,254,130,152,230,137,190,100,60,194,24,190,46,50,16,177,127,85,70,47,26,246,253,1,121,135,169,36,67,210,59,236,188,215,191,71,239,89,254,144,176,144,132,6,210,17,136,200,25,185,164,10,142,129,238,97,201,240,127,205,122,202,32,137,144,246,173,100,75,170,193,78,102,246,131,72,160,145,224,73,65,148,150,38,145,127,199,165,107,203,113,22,46,32,165,134,25,22,57,79,121,197,113,186,211,166,103,147,237,189,0,30,217,208,77,28,183,82,100,32,77,221,12,22,161,81,52,16,89,147,211,211,83,242,134,241,5,138,71,71,34,36,167,35,139,209,25,17,177,196,250,178,8,42,148,77,254,219,64,200,112,84,97,172,76,42,108,191,23,168,158,133,117,136,171,232,247,156,215,112,63,145,57,232,115,162,204,223,106,127,50,113,151,162,151,220,200,28,179,89,106,201,21,214,234,234,176,80,252,207,10,36,186,225,118,243,146,188,241,217,71,193,61,160,224,252,237,97,211,15,188,3,224,110,64,47,68,167,228,234,229,42,17,77,89,162,77,144,170,143,144,183,160,111,37,100,20,9,140,69,198,32,154,168,239,214,72,249,173,213,36,172,76,28,56,111,73,37,129,45,77,40,212,45,135,31,228,154,41,253,198,230,127,228,247,77,3,241,188,41,110,240,11,30,125,132,20,43,228,226,92,22,183,84,47,252,181,239,192,141,15,14,239,144,65,59,184,11,52,94,64,248,13,35,205,64,111,215,222,239,90,35,65,231,146,147,22,144,243,90,29,170,204,46,5,139,200,30,54,135,51,31,174,95,7,149,74,121,73,169,158,55,108,26,10,251,98,149,238,24,187,147,207,184,38,12,115,188,113,128,157,56,199,193,19,242,250,28,103,70,67,242,10,159,39,39,213,170,178,74,168,201,180,177,232,142,221,91,218,30,139,209,169,153,102,170,75,49,36,182,143,151,47,221,91,112,13,177,158,60,102,136,79,25,4,134,52,25,14,75,10,235,184,158,69,31,92,68,145,239,150,125,100,243,69,109,157,194,28,75,165,253,62,58,144,184,20,77,190,208,36,7,66,149,75,138,171,141,231,213,232,218,132,151,152,171,105,44,143,121,64,162,128,28,193,167,86,7,149,63,108,190,54,208,247,212,182,177,98,224,170,230,10,213,128,179,234,84,206,62,121,54,234,223,214,170,67,104,72,254,209,154,13,46,120,225,247,215,44,62,45,164,248,97,193,79,210,76,23,19,41,177,27,57,144,171,181,159,182,27,43,168,17,121,189,203,213,13,158,251,239,121,227,44,216,225,184,213,114,135,109,50,85,245,59,243,212,65,160,222,125,204,200,13,170,137,206,161,106,60,34,164,9,251,135,62,36,48,43,211,184,213,127,131,175,66,126,43,239,98,168,36,37,114,25,162,157,144,232,96,224,138,111,126,199,92,47,6,164,215,10,134,164,118,118,173,26,139,160,212,120,207,165,75,27,142,37,240,201,99,8,153,65,232,215,89,29,149,157,238,154,252,15,185,250,111,82,229,40,253,91,201,194,38,52,121,196,173,101,157,95,22,187,67,239,58,244,240,226,166,27,167,222,102,164,58,34,202,22,87,27,30,151,175,101,60,101,77,252,63,123,119,79,219,123,98,117,118,21,157,85,119,155,251,0,239,55,253,6,129,35,78,253,198,229,110,199,5,168,226,238,128,78,165,72,215,7,253,94,178,3,114,196,249,95,118,161,214,129,25,92,252,106,23,50,234,180,110,156,11,148,231,190,171,201,6,136,245,210,85,145,186,75,103,122,164,14,106,85,239,170,136,27,107,22,105,245,19,244,245,148,198,233,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFolderEntitySchemaNameFilterMoreOneLocalizableString());
			LocalizableStrings.Add(CreateFolderEntitySchemaNameEmptyLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFolderEntitySchemaNameFilterMoreOneLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b28e4545-600d-8706-087b-bdaa3d310cce"),
				Name = "FolderEntitySchemaNameFilterMoreOne",
				CreatedInPackageId = new Guid("dd00e878-1009-445f-bd06-4d0e05a51d60"),
				CreatedInSchemaUId = new Guid("f7c6e626-3da4-4dd0-a413-a934aea09181"),
				ModifiedInSchemaUId = new Guid("f7c6e626-3da4-4dd0-a413-a934aea09181")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFolderEntitySchemaNameEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a5f60912-7e06-3944-37d4-8c73cbfb9aca"),
				Name = "FolderEntitySchemaNameEmpty",
				CreatedInPackageId = new Guid("dd00e878-1009-445f-bd06-4d0e05a51d60"),
				CreatedInSchemaUId = new Guid("f7c6e626-3da4-4dd0-a413-a934aea09181"),
				ModifiedInSchemaUId = new Guid("f7c6e626-3da4-4dd0-a413-a934aea09181")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7c6e626-3da4-4dd0-a413-a934aea09181"));
		}

		#endregion

	}

	#endregion

}

