namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportExcelDataSchema

	/// <exclude/>
	public class ImportExcelDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportExcelDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportExcelDataSchema(ImportExcelDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f0c56b32-3373-4f0c-9885-a983759de99d");
			Name = "ImportExcelData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,203,106,195,48,16,69,215,14,228,31,134,100,211,110,236,189,211,118,227,134,98,72,67,32,233,186,40,241,68,136,202,146,145,198,37,38,228,223,43,201,15,220,148,54,53,88,214,227,206,213,204,241,40,86,162,173,216,1,97,135,198,48,171,143,20,103,90,29,5,175,13,35,161,85,156,151,149,54,180,60,29,80,62,51,98,211,201,121,58,137,106,43,20,135,109,99,9,203,197,176,230,82,239,153,76,211,76,151,165,139,92,105,206,221,182,59,119,138,185,65,238,236,32,147,204,218,20,90,215,76,203,186,84,91,36,39,11,170,36,73,224,193,214,101,201,76,243,212,173,231,221,51,76,198,139,238,11,163,157,144,106,220,155,37,35,183,170,222,75,113,128,131,79,161,149,181,9,180,5,59,129,47,173,87,9,69,144,171,2,79,112,6,142,180,0,235,135,203,72,97,201,248,170,51,86,121,80,183,100,75,69,130,154,246,194,181,163,254,171,126,175,181,132,220,174,180,254,168,171,93,83,221,80,174,17,139,150,230,15,221,165,37,143,170,248,23,252,171,95,20,0,189,145,144,130,4,218,160,24,42,98,244,157,227,32,131,158,98,111,182,49,186,66,227,143,82,216,132,240,224,20,85,70,124,50,194,222,203,32,43,180,146,13,228,174,107,224,93,186,225,17,220,244,149,41,198,209,196,47,72,190,157,208,220,205,194,133,179,251,182,173,174,82,10,209,254,13,57,68,14,71,55,139,12,82,109,84,112,246,13,27,121,56,97,8,201,14,136,254,160,118,205,227,242,5,225,87,52,18,60,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f0c56b32-3373-4f0c-9885-a983759de99d"));
		}

		#endregion

	}

	#endregion

}

