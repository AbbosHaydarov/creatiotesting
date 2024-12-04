namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImporterConstantsSchema

	/// <exclude/>
	public class FileImporterConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImporterConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImporterConstantsSchema(FileImporterConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1dc2dd32-8b13-47cd-be30-3ed1dbba2572");
			Name = "FileImporterConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,144,193,10,194,48,12,134,207,27,236,29,2,222,199,60,120,153,120,26,8,30,132,137,190,64,221,178,89,232,218,209,180,224,144,189,187,177,67,198,4,5,47,13,253,243,255,95,66,180,232,144,122,81,33,92,208,90,65,166,113,105,97,116,35,91,111,133,147,70,167,123,169,240,208,245,198,186,36,126,36,113,228,73,234,22,206,3,57,236,182,73,204,202,202,98,203,78,40,148,32,202,97,14,160,101,20,57,161,29,5,99,239,175,74,86,192,138,227,82,189,236,223,220,17,143,226,119,102,191,91,57,148,129,50,181,151,68,169,29,28,197,253,228,209,14,204,101,34,21,198,179,184,131,77,150,241,178,191,2,165,176,124,139,255,50,197,77,170,250,99,210,58,164,194,238,168,235,105,253,240,31,167,99,45,196,241,9,72,157,138,60,128,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1dc2dd32-8b13-47cd-be30-3ed1dbba2572"));
		}

		#endregion

	}

	#endregion

}

