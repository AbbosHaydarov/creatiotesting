namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportHeadersProcessorFactorySchema

	/// <exclude/>
	public class FileImportHeadersProcessorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportHeadersProcessorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportHeadersProcessorFactorySchema(FileImportHeadersProcessorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f308309d-78f0-4eae-9765-b45ee0dd84b7");
			Name = "FileImportHeadersProcessorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,77,75,195,64,16,61,167,208,255,48,228,148,64,73,238,218,22,180,90,237,69,132,214,147,120,88,55,147,118,33,217,13,179,187,149,32,253,239,110,146,70,77,67,8,40,228,107,119,231,189,121,243,102,34,89,142,186,96,28,97,135,68,76,171,212,68,43,37,83,177,183,196,140,80,50,90,139,12,55,121,161,200,192,231,116,226,89,45,228,190,19,76,120,61,176,31,221,75,35,140,64,61,24,176,102,220,40,106,34,92,76,28,199,48,215,54,207,25,149,203,118,45,228,1,73,152,68,113,224,132,233,194,223,252,72,122,68,150,32,233,103,82,28,181,86,212,240,149,126,220,162,221,201,81,36,8,60,99,90,67,170,168,226,96,6,225,80,35,161,104,145,109,182,248,87,250,215,59,76,153,205,204,173,144,137,19,31,152,178,64,149,6,227,249,195,25,60,57,99,97,1,210,189,28,100,28,17,190,185,132,133,125,207,4,63,139,29,197,92,193,184,146,186,103,238,234,89,251,79,111,251,102,181,226,251,12,171,202,113,231,252,3,154,111,178,224,69,35,185,65,147,200,171,41,3,219,89,206,160,158,156,114,203,15,152,51,32,165,76,243,25,214,245,120,222,145,209,5,228,134,246,186,242,27,63,192,109,106,67,182,82,235,118,109,142,210,4,126,55,218,159,93,192,195,106,68,61,79,164,16,252,100,139,154,38,46,192,223,150,122,71,76,234,172,254,39,252,86,134,71,104,44,73,88,85,13,59,251,19,185,50,231,221,248,97,79,151,65,191,138,179,148,83,253,28,74,112,158,204,191,48,87,196,238,158,78,78,95,241,134,175,204,253,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f308309d-78f0-4eae-9765-b45ee0dd84b7"));
		}

		#endregion

	}

	#endregion

}

