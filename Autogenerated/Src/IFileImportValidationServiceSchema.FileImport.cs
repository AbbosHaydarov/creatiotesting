namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportValidationServiceSchema

	/// <exclude/>
	public class IFileImportValidationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportValidationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportValidationServiceSchema(IFileImportValidationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb43cabf-2447-44e4-b1b4-3716ee0c72e1");
			Name = "IFileImportValidationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,193,106,131,64,16,61,111,32,255,48,152,139,1,241,3,82,122,105,33,96,193,38,196,208,28,66,15,27,29,237,82,221,181,187,107,64,74,254,189,163,171,177,135,214,211,50,111,223,155,247,102,70,242,10,77,205,83,132,35,106,205,141,202,109,248,172,100,46,138,70,115,43,148,12,183,162,196,168,170,149,182,203,197,247,114,193,26,35,100,1,73,107,44,86,97,130,250,42,82,140,85,134,229,195,220,103,120,194,11,17,136,178,210,88,80,95,136,164,69,157,147,243,6,162,201,227,141,151,34,235,141,7,117,175,57,15,5,37,179,154,167,214,127,165,216,240,8,222,140,208,91,191,147,178,110,46,165,72,65,140,102,179,94,64,130,110,196,123,198,24,237,135,202,204,6,246,125,155,62,11,59,239,106,116,187,25,227,116,70,236,76,19,70,242,170,62,209,119,178,46,223,126,151,28,189,0,14,248,213,160,177,91,165,43,110,9,39,106,140,198,240,2,29,20,190,24,37,3,120,82,89,155,216,182,236,70,155,40,119,52,60,105,94,215,152,5,157,29,99,7,58,156,146,102,104,241,95,215,126,11,236,175,161,71,61,12,16,250,19,107,88,200,144,27,180,123,215,238,130,108,133,50,115,27,162,234,230,174,250,11,186,253,0,148,49,173,177,85,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb43cabf-2447-44e4-b1b4-3716ee0c72e1"));
		}

		#endregion

	}

	#endregion

}

