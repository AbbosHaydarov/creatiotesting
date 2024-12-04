namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LongTextColumnProcessorSchema

	/// <exclude/>
	public class LongTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LongTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LongTextColumnProcessorSchema(LongTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c7c9656-e810-4ae6-bd3f-7aa194ca6b08");
			Name = "LongTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,81,107,219,48,16,199,159,83,232,119,56,210,151,4,134,253,222,54,129,53,165,35,48,70,161,201,94,198,30,20,249,156,10,236,147,119,39,149,133,209,239,222,179,21,111,117,90,15,250,98,75,199,255,254,119,247,147,68,166,70,105,140,69,216,32,179,17,95,134,108,229,169,116,251,200,38,56,79,217,157,171,112,93,55,158,195,249,217,159,243,179,73,20,71,123,120,56,72,192,250,234,239,254,117,54,227,88,60,187,51,54,120,118,40,170,80,205,5,227,94,107,192,170,50,34,151,240,213,211,126,131,191,195,202,87,177,166,123,246,22,69,60,119,210,60,207,225,218,209,35,178,11,133,183,96,25,203,197,244,29,245,52,95,246,114,137,117,109,248,208,239,63,19,56,146,96,72,167,245,37,132,71,39,96,219,202,160,11,86,12,158,196,237,42,132,210,51,52,201,175,157,161,111,11,108,87,9,158,76,21,81,178,190,74,254,170,204,143,91,44,77,172,194,141,163,66,83,103,225,208,160,47,103,235,147,30,231,159,224,155,130,135,5,144,254,84,48,50,249,124,254,83,77,155,184,171,156,61,182,58,162,132,75,120,151,220,68,143,76,191,255,72,235,140,129,99,123,10,10,252,190,115,78,138,15,2,126,67,184,11,172,24,77,64,25,114,86,6,170,68,60,90,142,76,160,182,45,210,183,76,83,164,49,108,234,14,215,98,26,5,89,7,33,180,237,13,157,46,183,186,215,195,233,3,217,117,222,169,187,228,35,188,145,162,179,237,192,10,134,206,115,165,186,51,130,179,211,112,251,14,38,207,71,178,72,69,130,59,36,173,53,26,228,160,119,93,57,179,15,154,139,197,255,80,223,104,165,15,160,190,53,193,164,171,152,8,71,114,191,116,237,10,164,224,74,135,60,66,83,47,118,234,5,252,147,62,78,213,195,151,232,138,206,239,123,107,183,81,183,237,186,128,197,114,24,203,122,134,167,202,244,150,79,65,36,60,195,224,243,11,53,24,3,3,111,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c7c9656-e810-4ae6-bd3f-7aa194ca6b08"));
		}

		#endregion

	}

	#endregion

}

