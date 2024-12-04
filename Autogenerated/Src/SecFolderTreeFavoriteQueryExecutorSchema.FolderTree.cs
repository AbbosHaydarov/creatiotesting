namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecFolderTreeFavoriteQueryExecutorSchema

	/// <exclude/>
	public class SecFolderTreeFavoriteQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecFolderTreeFavoriteQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecFolderTreeFavoriteQueryExecutorSchema(SecFolderTreeFavoriteQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0eb3a998-3aac-4696-9f2f-3c08a51f388d");
			Name = "SecFolderTreeFavoriteQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd00e878-1009-445f-bd06-4d0e05a51d60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,193,106,27,49,16,61,111,32,255,48,117,46,187,16,214,119,187,13,36,174,23,10,109,105,113,114,42,61,40,210,172,45,216,149,54,35,201,212,4,255,123,71,90,219,177,107,187,41,164,23,177,122,122,51,111,230,73,179,70,180,232,58,33,17,238,145,72,56,91,251,114,98,77,173,231,129,132,215,214,92,94,60,95,94,100,193,105,51,135,217,202,121,108,203,207,218,60,141,119,224,126,28,225,57,188,156,26,175,189,70,119,150,80,9,233,45,245,12,230,92,17,206,89,30,38,141,112,110,4,51,148,149,109,20,210,61,33,86,98,201,76,143,223,3,210,106,250,11,101,224,200,20,245,227,35,214,34,52,254,78,27,197,26,185,95,117,104,235,252,83,82,95,29,240,139,107,248,202,205,195,7,24,188,158,124,80,252,228,236,93,120,108,180,4,25,75,250,135,138,70,112,39,28,50,47,16,170,158,123,166,242,44,122,188,107,249,27,217,14,41,154,53,138,223,30,165,71,149,218,203,134,195,33,188,215,102,129,156,68,89,9,195,155,136,118,91,18,216,37,155,170,21,130,243,20,61,62,84,237,93,152,201,5,182,162,239,253,6,6,199,77,12,198,255,67,108,98,155,208,154,19,50,111,75,191,87,253,51,204,209,143,193,197,101,29,239,241,88,227,10,141,234,93,221,236,55,22,127,65,191,176,234,13,254,46,173,86,112,171,84,165,27,143,228,42,178,237,196,118,26,213,212,61,229,251,62,167,155,6,73,40,124,58,188,134,19,167,219,200,2,210,67,200,116,13,249,187,29,90,110,68,202,91,179,202,139,45,39,35,244,129,76,156,167,44,91,167,245,69,229,37,68,169,252,40,81,145,130,56,230,111,22,241,95,128,141,15,113,40,217,166,244,242,123,194,102,10,94,127,255,249,131,67,226,52,134,189,139,25,195,193,182,128,17,60,242,124,228,127,194,169,189,147,197,49,210,227,135,240,250,55,20,38,23,86,197,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0eb3a998-3aac-4696-9f2f-3c08a51f388d"));
		}

		#endregion

	}

	#endregion

}

