namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileSchemaProviderSchema

	/// <exclude/>
	public class IFileSchemaProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileSchemaProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileSchemaProviderSchema(IFileSchemaProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c19fcb3d-30cc-4889-b3ff-cadcced57d1c");
			Name = "IFileSchemaProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ee75749b-5184-4f75-a3ec-dd2e096c705e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,219,106,2,49,16,125,174,224,63,12,250,98,161,184,239,106,133,82,90,17,122,145,218,31,136,217,89,55,37,155,200,76,182,34,165,255,222,201,238,122,151,226,75,32,51,103,206,156,57,147,128,83,5,242,74,105,132,79,36,82,236,179,208,127,244,46,51,203,146,84,48,222,181,91,63,237,214,77,201,198,45,97,190,225,128,133,228,173,69,29,147,220,159,160,67,50,122,216,110,9,170,75,184,148,40,76,93,64,202,132,116,0,211,39,23,76,216,84,233,36,73,96,196,101,81,40,218,140,155,251,140,252,183,73,145,193,184,204,83,81,181,4,181,240,101,0,172,42,129,117,142,133,98,80,132,2,202,165,91,192,20,50,242,5,116,158,141,69,238,244,183,220,201,1,249,170,92,88,163,165,162,145,2,211,8,158,87,100,77,83,18,152,12,39,231,78,249,43,134,220,167,60,128,89,85,94,39,79,117,87,129,15,12,37,57,134,144,35,88,195,1,124,6,202,218,43,228,54,144,59,73,107,91,166,209,88,149,166,38,78,174,236,161,15,113,174,243,193,234,8,213,237,199,251,93,68,1,177,193,78,65,100,234,143,146,45,50,150,190,136,208,209,222,135,169,32,198,48,193,240,96,109,29,225,222,237,240,138,161,207,151,149,197,206,71,27,131,117,110,116,14,134,129,208,170,104,66,240,192,43,212,38,51,114,33,212,158,210,227,146,255,6,94,41,82,5,196,231,122,223,169,107,107,197,111,18,233,140,227,25,13,136,219,184,200,60,74,42,130,115,3,223,23,95,226,31,172,77,16,173,151,199,218,81,28,90,121,236,162,56,239,26,65,61,14,20,119,122,42,114,107,108,23,93,90,191,182,234,254,91,255,156,163,160,196,254,0,51,177,95,189,153,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c19fcb3d-30cc-4889-b3ff-cadcced57d1c"));
		}

		#endregion

	}

	#endregion

}

