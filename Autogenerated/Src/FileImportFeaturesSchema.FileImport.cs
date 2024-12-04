namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportFeaturesSchema

	/// <exclude/>
	public class FileImportFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportFeaturesSchema(FileImportFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("faca2563-4987-469f-bdd0-d33f34d766b5");
			Name = "FileImportFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,205,74,195,64,16,62,55,144,119,24,234,69,47,121,0,197,131,166,22,122,16,5,243,2,211,100,146,46,108,118,151,217,9,30,164,239,238,108,54,82,82,132,230,144,192,55,223,223,76,192,225,72,49,96,75,208,16,51,70,223,75,85,123,215,155,97,98,20,227,93,181,55,150,14,99,240,44,101,241,83,22,155,41,26,55,64,205,148,198,213,94,63,19,83,227,135,193,42,254,84,22,74,185,99,26,84,10,181,197,24,31,225,226,176,176,227,204,10,211,209,154,22,218,68,250,151,179,209,56,125,95,219,213,150,208,189,78,125,79,76,93,214,52,120,180,244,225,94,66,248,18,76,69,147,108,229,127,91,4,90,52,71,191,147,96,135,130,201,100,169,112,233,224,93,20,158,90,241,172,85,62,231,136,133,178,228,221,78,186,127,128,116,72,125,14,241,205,165,89,7,207,160,174,164,231,75,240,142,98,203,38,164,243,235,96,187,35,33,30,141,163,8,223,39,146,19,49,136,215,189,52,7,214,65,32,201,13,84,134,33,104,153,249,15,66,76,161,219,236,125,254,219,135,92,151,87,202,192,130,95,193,25,93,131,231,95,234,111,115,122,52,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("faca2563-4987-469f-bdd0-d33f34d766b5"));
		}

		#endregion

	}

	#endregion

}

