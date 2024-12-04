namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportHeadersProcessorFactorySchema

	/// <exclude/>
	public class IFileImportHeadersProcessorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportHeadersProcessorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportHeadersProcessorFactorySchema(IFileImportHeadersProcessorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0f82a9d-1f0d-4e82-bc54-fa38907c8a4f");
			Name = "IFileImportHeadersProcessorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,193,106,2,49,16,134,207,10,190,195,176,94,90,40,155,123,187,238,69,106,187,135,130,96,125,128,52,206,106,192,77,150,153,201,65,74,223,189,217,88,117,183,85,40,228,146,201,63,223,63,249,19,167,27,228,86,27,132,119,36,210,236,107,201,231,222,213,118,27,72,139,245,46,95,216,61,86,77,235,73,224,115,50,30,5,182,110,59,16,19,62,221,168,231,207,78,172,88,228,40,136,146,54,124,236,173,1,235,4,169,238,44,171,11,251,21,245,6,137,151,228,13,50,123,90,104,35,158,14,157,101,236,28,77,9,183,113,24,120,67,217,249,13,63,194,50,177,142,135,74,41,40,56,52,141,166,67,121,42,204,9,181,32,236,18,23,218,19,55,10,17,193,16,214,179,236,175,125,106,242,148,169,18,234,168,101,31,40,142,201,102,135,141,134,179,149,250,237,85,180,154,116,3,46,102,57,203,2,35,197,4,29,154,46,190,172,92,199,61,152,115,161,231,191,30,42,85,89,168,4,186,206,37,239,101,149,38,201,202,85,127,176,30,49,229,125,248,81,93,225,17,74,32,199,101,229,88,180,139,4,95,255,55,144,66,157,154,59,218,77,37,188,160,156,31,241,110,120,67,24,70,243,0,253,113,225,114,191,251,227,119,25,77,209,109,142,239,158,246,95,147,113,92,223,24,252,141,14,177,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0f82a9d-1f0d-4e82-bc54-fa38907c8a4f"));
		}

		#endregion

	}

	#endregion

}

