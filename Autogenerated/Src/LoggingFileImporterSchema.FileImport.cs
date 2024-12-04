namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LoggingFileImporterSchema

	/// <exclude/>
	public class LoggingFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LoggingFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LoggingFileImporterSchema(LoggingFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10ecd8e5-f4a7-4119-9170-ce80b8367b66");
			Name = "LoggingFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,84,193,138,219,48,16,61,59,144,127,16,233,197,185,248,3,178,148,165,132,108,9,108,216,192,182,189,148,82,20,123,162,10,108,141,25,201,185,148,252,123,71,178,186,187,89,169,110,150,61,36,145,39,239,205,123,111,70,216,200,14,108,47,107,16,95,128,72,90,60,186,106,141,230,168,213,64,210,105,52,213,157,110,97,219,245,72,110,62,251,61,159,21,131,213,70,9,213,226,65,182,171,213,26,187,142,65,247,168,20,151,111,158,254,127,217,141,224,95,245,234,78,214,14,73,131,101,4,99,62,16,40,214,20,235,86,90,187,18,177,235,179,3,160,0,251,254,112,226,54,186,129,31,252,208,15,135,86,215,162,246,148,28,67,172,196,101,131,130,83,240,247,179,24,26,235,104,240,70,88,115,31,218,141,136,216,58,211,180,252,106,129,152,104,160,246,67,18,195,197,227,146,53,15,210,66,249,186,236,231,87,156,163,60,152,102,116,112,105,103,79,216,3,57,158,9,155,33,116,204,133,38,250,33,125,146,14,196,150,29,137,159,45,134,121,115,53,130,198,186,255,4,157,66,129,139,167,130,192,13,100,2,71,220,222,138,50,28,62,122,236,78,26,169,128,170,207,224,124,78,142,182,168,195,78,63,245,61,59,4,90,44,151,65,198,251,254,175,249,29,184,95,216,228,156,255,245,136,113,117,226,132,154,29,135,121,150,227,207,94,18,223,70,158,174,21,253,211,49,14,173,96,115,213,214,28,177,92,140,224,71,39,201,45,162,53,63,236,42,246,122,65,189,201,50,55,166,137,188,243,180,185,29,144,138,27,223,24,167,253,74,222,230,52,211,32,181,157,83,153,200,144,129,95,29,136,151,82,131,181,107,108,135,206,124,147,237,240,214,64,153,6,105,160,156,202,68,160,12,252,234,64,91,163,221,123,22,148,242,51,215,42,213,152,186,98,9,122,99,174,12,243,40,79,239,186,109,41,63,13,147,209,152,8,147,162,147,48,175,94,4,99,245,178,120,158,207,254,0,78,213,184,34,102,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10ecd8e5-f4a7-4119-9170-ce80b8367b66"));
		}

		#endregion

	}

	#endregion

}

