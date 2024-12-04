namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnMessageReaderSchema

	/// <exclude/>
	public class IEsnMessageReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnMessageReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnMessageReaderSchema(IEsnMessageReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06f8b050-f68f-4336-acf7-4f1801ecd769");
			Name = "IEsnMessageReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,85,219,110,219,48,12,125,78,128,252,3,225,189,172,64,97,191,111,169,129,34,75,3,63,108,29,218,254,128,106,211,137,80,75,10,72,105,69,80,244,223,167,139,157,100,189,12,73,129,238,242,20,155,34,15,207,57,116,40,45,20,242,90,212,8,55,72,36,216,180,54,159,25,221,202,165,35,97,165,209,249,252,250,219,100,252,48,25,143,28,75,189,132,235,13,91,84,159,159,188,251,154,174,195,58,20,112,190,64,141,36,235,93,206,204,16,230,115,109,165,149,200,62,236,15,62,16,46,125,50,64,165,45,82,235,9,124,130,106,206,250,43,50,139,37,94,161,104,144,98,102,81,20,48,101,167,148,160,77,217,191,127,39,243,67,54,200,160,208,174,76,195,208,26,2,54,181,20,29,104,180,247,134,238,128,60,68,104,174,18,34,231,3,86,177,7,182,118,183,157,172,65,14,36,94,226,48,10,226,159,209,136,129,5,90,168,141,82,168,195,239,224,64,100,211,183,13,93,159,183,77,145,181,32,161,64,251,9,156,101,125,122,213,100,101,223,30,100,147,79,139,152,179,43,33,180,142,52,151,83,70,132,154,176,61,203,162,175,155,172,40,165,102,43,180,215,176,99,226,1,134,138,0,81,205,181,83,72,226,182,195,105,42,43,33,168,156,37,9,252,113,225,100,51,48,175,154,147,52,170,215,165,183,136,13,8,107,69,189,250,223,45,56,223,170,56,218,133,191,39,243,137,182,116,30,229,244,200,111,148,2,247,210,174,64,116,93,240,209,41,205,128,17,250,95,148,120,222,117,179,68,50,157,29,43,185,94,57,125,183,93,18,241,187,61,78,108,202,14,90,123,114,234,55,146,247,11,195,130,186,92,199,149,153,149,87,253,182,50,41,0,251,158,176,222,211,59,84,64,81,254,169,255,70,122,254,229,147,26,68,159,194,139,236,226,242,237,159,223,50,1,199,72,113,187,28,58,4,122,63,47,119,55,27,152,118,59,220,47,55,151,175,227,250,195,30,243,16,123,47,188,206,193,220,131,220,28,61,166,43,20,117,147,110,209,201,216,71,126,2,66,125,217,76,202,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06f8b050-f68f-4336-acf7-4f1801ecd769"));
		}

		#endregion

	}

	#endregion

}

