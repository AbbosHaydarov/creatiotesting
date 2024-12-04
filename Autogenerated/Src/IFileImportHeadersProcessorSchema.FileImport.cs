namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportHeadersProcessorSchema

	/// <exclude/>
	public class IFileImportHeadersProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportHeadersProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportHeadersProcessorSchema(IFileImportHeadersProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6a6f9f3-e056-43f4-b54a-65bfa522f74f");
			Name = "IFileImportHeadersProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,81,205,106,2,49,16,62,43,248,14,195,94,218,66,217,60,64,215,92,196,182,158,45,189,199,56,209,64,126,150,153,164,32,165,239,222,108,86,93,161,21,2,33,201,55,223,95,130,242,200,189,210,8,31,72,164,56,154,212,174,98,48,246,144,73,37,27,67,251,106,29,110,124,31,41,193,247,98,62,203,108,195,1,182,39,78,232,11,210,57,212,3,140,219,55,12,72,86,191,92,49,183,132,132,237,58,36,155,44,242,0,40,171,207,59,103,53,216,144,144,204,160,191,153,132,222,81,237,145,120,69,168,82,164,42,59,3,33,4,116,156,189,87,116,146,215,155,138,65,6,59,58,212,209,101,31,24,76,25,235,41,106,100,198,61,28,43,223,3,195,151,114,25,185,157,248,196,31,194,174,87,164,60,132,210,203,178,161,24,211,86,31,209,171,70,118,140,8,154,208,44,155,26,229,116,126,16,146,99,166,18,128,235,185,74,235,234,234,226,166,237,68,37,189,35,162,43,234,179,90,107,228,184,131,161,232,193,148,70,254,25,38,76,153,2,203,169,125,136,166,116,115,245,55,182,88,158,11,111,241,215,137,203,196,192,177,89,135,236,145,212,206,97,119,11,148,231,46,199,242,199,59,126,188,141,10,83,29,207,3,211,93,170,154,65,158,227,143,129,158,134,111,255,89,204,203,250,5,9,103,190,54,115,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6a6f9f3-e056-43f4-b54a-65bfa522f74f"));
		}

		#endregion

	}

	#endregion

}

