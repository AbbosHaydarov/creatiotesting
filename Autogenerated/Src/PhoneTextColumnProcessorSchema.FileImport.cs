namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PhoneTextColumnProcessorSchema

	/// <exclude/>
	public class PhoneTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PhoneTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PhoneTextColumnProcessorSchema(PhoneTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91251571-ba36-4a68-9430-619bc29975f7");
			Name = "PhoneTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,81,75,43,49,16,133,159,43,248,31,134,250,210,130,236,190,171,45,104,69,41,136,8,182,247,229,114,31,210,236,108,27,216,157,172,147,68,44,226,127,119,178,105,189,110,117,5,95,118,147,225,228,156,204,151,132,84,141,174,81,26,97,129,204,202,217,210,103,51,75,165,89,7,86,222,88,202,110,76,133,243,186,177,236,143,143,94,143,143,6,193,25,90,195,227,214,121,172,207,63,230,159,87,51,246,213,179,27,165,189,101,131,78,20,162,57,97,92,75,6,204,42,229,220,25,60,108,44,225,2,95,252,204,86,161,166,7,182,26,157,179,220,106,243,60,135,11,67,27,100,227,11,171,65,51,150,147,225,55,234,97,62,221,203,93,168,107,197,219,253,252,146,192,144,243,138,164,93,91,130,223,24,7,58,70,131,12,88,56,88,114,102,85,33,148,150,161,73,126,177,137,59,75,235,24,4,186,77,130,103,85,5,116,217,62,37,255,20,243,247,26,75,21,42,127,101,168,144,165,35,191,109,208,150,163,249,193,30,199,167,112,47,228,97,2,36,63,17,244,181,62,30,255,19,215,38,172,42,163,119,123,237,147,194,25,124,203,110,32,167,38,223,255,176,165,75,207,33,30,68,100,222,90,39,197,47,17,127,97,220,22,102,140,202,163,235,146,22,10,162,68,220,89,246,181,32,190,145,234,87,172,169,210,40,86,117,75,108,50,12,14,89,58,33,212,241,150,14,167,75,153,203,249,236,11,217,69,222,170,219,197,59,124,125,169,163,101,199,11,186,214,99,225,186,82,14,71,135,229,248,24,6,111,59,182,72,69,194,219,101,45,25,13,178,151,11,47,164,217,122,89,139,197,79,176,175,36,233,23,176,175,149,87,233,58,38,198,129,204,147,140,77,129,228,77,105,144,123,112,202,229,78,123,1,251,44,47,84,244,112,27,76,209,250,253,137,118,11,113,91,206,11,152,76,187,181,236,3,226,161,52,189,232,67,18,137,79,183,40,181,119,234,229,177,13,119,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91251571-ba36-4a68-9430-619bc29975f7"));
		}

		#endregion

	}

	#endregion

}

