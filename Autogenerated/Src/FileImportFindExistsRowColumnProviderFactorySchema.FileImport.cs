namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportFindExistsRowColumnProviderFactorySchema

	/// <exclude/>
	public class FileImportFindExistsRowColumnProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportFindExistsRowColumnProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportFindExistsRowColumnProviderFactorySchema(FileImportFindExistsRowColumnProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a04f7c20-82c6-48ee-8202-f1192dbd1806");
			Name = "FileImportFindExistsRowColumnProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,77,107,2,49,16,61,71,240,63,4,189,172,80,214,187,181,22,180,110,241,208,34,173,61,149,82,226,102,86,3,107,178,76,178,86,41,254,247,206,26,197,174,162,184,120,10,73,38,239,99,222,68,139,5,216,76,196,192,39,128,40,172,73,92,56,48,58,81,179,28,133,83,70,135,145,74,97,180,200,12,186,122,237,183,94,99,185,85,122,86,170,70,184,63,115,30,70,34,118,6,21,88,170,160,154,38,194,140,48,249,32,21,214,118,248,1,58,82,90,14,87,202,58,251,102,126,6,38,205,23,122,140,102,169,36,160,135,88,111,223,183,219,109,222,85,122,14,168,156,52,49,143,17,146,135,70,21,152,70,187,71,56,159,79,144,136,60,117,125,170,39,213,129,91,103,96,146,96,84,5,169,117,71,64,236,149,250,199,31,184,166,133,0,42,189,111,125,17,64,150,79,83,69,70,138,134,84,234,7,239,240,74,114,137,139,210,43,36,239,67,136,20,164,146,82,24,163,90,10,7,254,50,243,27,142,32,164,209,233,154,127,88,64,26,8,13,113,49,13,252,59,47,237,125,172,172,9,90,122,212,50,5,21,90,135,121,33,160,32,218,122,221,241,120,223,85,28,4,71,82,202,74,90,188,24,78,198,142,4,82,54,39,138,25,219,92,150,253,2,110,110,228,145,226,219,103,47,124,6,87,190,240,211,184,111,198,117,121,242,19,148,96,239,29,193,229,120,146,81,65,59,178,17,8,186,132,161,22,211,20,100,208,160,102,78,96,181,67,178,19,243,14,2,227,249,142,19,98,131,210,142,244,65,80,163,181,101,96,143,254,239,254,115,212,61,39,187,191,62,16,236,165,246,72,171,176,30,138,93,231,215,23,119,42,241,210,119,150,59,103,55,48,95,24,21,127,90,62,220,252,1,158,74,123,210,76,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a04f7c20-82c6-48ee-8202-f1192dbd1806"));
		}

		#endregion

	}

	#endregion

}

