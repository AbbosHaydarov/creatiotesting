namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportInfoLoggerSchema

	/// <exclude/>
	public class FileImportInfoLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportInfoLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportInfoLoggerSchema(FileImportInfoLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("675e9ab2-9b09-4f89-aa1d-1b5a419d6253");
			Name = "FileImportInfoLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,83,77,107,194,64,16,61,71,240,63,44,177,135,4,74,188,167,85,177,182,74,160,66,193,66,15,165,148,53,153,196,133,100,55,236,110,4,145,252,247,206,102,253,168,214,126,8,246,18,118,102,222,155,121,111,152,112,90,128,42,105,12,228,25,164,164,74,164,58,24,9,158,178,172,146,84,51,193,131,49,203,33,42,74,33,117,187,181,110,183,156,74,49,158,145,217,74,105,40,110,118,113,150,139,57,205,195,112,36,138,2,73,143,34,203,48,189,175,127,238,46,33,24,211,88,11,201,64,33,2,49,29,9,25,206,34,163,156,42,21,146,253,200,136,167,194,244,2,217,224,94,239,33,165,85,174,239,24,79,176,171,167,87,37,136,212,139,78,17,124,255,13,25,101,53,207,89,76,98,211,248,100,95,18,146,147,116,228,162,91,252,238,196,61,73,81,130,212,40,58,196,55,91,82,13,22,80,218,128,68,200,36,239,121,67,191,249,82,216,140,235,245,183,16,50,24,16,111,251,238,153,250,148,114,138,65,48,1,109,209,158,187,151,54,44,75,224,9,72,215,247,237,210,156,14,198,86,219,161,208,41,232,133,72,140,202,198,188,45,118,187,93,114,203,248,2,36,211,137,192,141,72,72,123,238,73,235,193,11,98,96,6,74,97,183,97,108,174,96,166,169,212,83,204,160,62,183,219,111,204,217,205,46,5,75,200,207,4,111,82,33,134,53,83,54,160,40,185,38,74,75,115,25,133,5,249,196,28,151,227,108,36,24,53,222,149,187,62,98,213,200,194,198,33,89,111,104,181,107,182,225,56,245,37,92,158,99,240,63,188,93,202,212,159,220,28,218,248,93,240,182,116,185,117,63,240,228,156,141,239,225,23,93,58,240,228,219,115,58,250,195,108,246,48,89,183,91,31,189,178,186,196,68,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("675e9ab2-9b09-4f89-aa1d-1b5a419d6253"));
		}

		#endregion

	}

	#endregion

}

