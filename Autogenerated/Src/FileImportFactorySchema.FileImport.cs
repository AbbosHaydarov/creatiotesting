namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportFactorySchema

	/// <exclude/>
	public class FileImportFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportFactorySchema(FileImportFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c7625a4-8130-4b80-a086-770eb086519c");
			Name = "FileImportFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,65,75,195,64,16,133,207,41,244,63,12,241,146,64,105,238,213,10,181,54,146,131,82,80,79,226,97,187,153,164,11,201,110,152,221,160,65,250,223,157,108,68,173,177,160,129,236,178,147,199,55,239,237,68,139,26,109,35,36,194,3,18,9,107,10,55,95,27,93,168,178,37,225,148,209,243,84,85,152,213,141,33,7,211,201,219,116,18,180,86,233,242,72,78,120,126,162,62,79,133,116,134,20,90,86,176,230,140,176,100,40,192,186,18,214,46,224,11,62,8,59,175,74,146,228,66,233,61,146,114,185,145,32,9,139,101,152,141,180,97,114,201,226,167,107,44,68,91,185,43,165,115,54,16,185,174,65,83,68,99,121,60,131,59,78,11,75,208,188,177,100,172,136,159,167,19,224,167,105,119,149,226,198,189,201,177,199,5,140,225,108,164,191,155,207,128,183,232,246,38,231,132,91,143,242,177,254,145,43,232,229,31,46,178,45,169,90,80,183,209,78,185,46,229,152,72,112,131,238,151,114,244,104,145,120,124,26,101,63,59,104,143,142,51,200,214,166,106,107,109,87,101,201,62,5,55,91,229,162,113,204,147,195,135,45,25,137,214,26,138,193,199,233,223,64,21,16,29,147,230,220,62,179,41,10,215,18,110,180,216,85,152,71,33,55,79,209,201,125,106,232,30,5,201,253,230,85,89,55,248,203,244,87,204,48,142,61,215,119,8,2,66,166,104,208,248,2,199,145,122,22,103,250,25,98,100,181,255,249,130,224,224,87,191,156,36,14,151,244,55,32,243,252,64,81,231,195,76,249,52,212,190,151,14,239,199,119,173,20,65,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c7625a4-8130-4b80-a086-770eb086519c"));
		}

		#endregion

	}

	#endregion

}

