namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportParametersIteratorSchema

	/// <exclude/>
	public class ImportParametersIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportParametersIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportParametersIteratorSchema(ImportParametersIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a556f6f-f364-4e38-8c78-e99a9660b2e1");
			Name = "ImportParametersIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,203,106,195,48,16,60,43,224,127,88,232,197,129,224,15,104,154,66,73,90,200,161,16,104,233,93,149,215,137,64,150,140,30,133,80,242,239,149,37,217,145,210,210,203,174,118,53,51,251,144,36,237,209,12,148,33,188,163,214,212,168,206,54,91,37,59,126,116,154,90,174,100,243,194,5,238,251,65,105,91,45,190,171,5,113,134,203,35,188,157,141,197,126,93,45,124,230,78,227,209,35,97,43,168,49,247,16,193,7,170,189,180,69,109,246,222,80,171,116,192,14,238,83,112,6,198,122,113,6,108,100,252,67,32,190,160,183,115,133,87,180,39,213,250,26,135,32,19,47,75,201,47,197,91,136,10,88,223,42,195,48,31,87,35,149,144,39,54,14,249,16,129,207,210,114,123,94,165,134,182,74,184,94,150,209,7,21,14,203,212,14,141,229,50,236,234,17,120,106,125,9,227,170,8,233,148,70,202,78,80,231,5,128,23,129,204,186,106,66,146,163,153,4,110,21,98,77,96,209,149,220,120,119,165,146,95,157,39,94,60,111,138,62,252,59,203,54,131,214,17,186,92,39,45,222,65,74,37,246,6,164,19,226,90,140,48,229,133,164,195,137,113,73,254,207,9,178,173,65,155,157,253,68,177,74,147,33,178,145,200,180,225,58,111,126,149,72,147,79,207,148,9,207,115,164,174,162,11,214,155,240,199,80,182,241,155,133,56,102,203,228,229,7,56,180,91,209,46,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a556f6f-f364-4e38-8c78-e99a9660b2e1"));
		}

		#endregion

	}

	#endregion

}

