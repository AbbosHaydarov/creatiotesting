namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationEventListenerSchema

	/// <exclude/>
	public class DeduplicationEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationEventListenerSchema(DeduplicationEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5977cffb-468d-4a86-a1e4-3fa810cbe99a");
			Name = "DeduplicationEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,219,110,26,49,16,125,38,82,254,193,34,47,68,170,150,247,144,32,149,165,81,145,138,122,1,41,207,142,61,128,139,215,94,217,99,212,109,213,127,239,236,45,196,101,33,219,190,176,204,237,156,241,209,204,24,158,129,207,185,0,182,6,231,184,183,27,76,82,107,54,106,27,28,71,101,77,50,7,25,114,173,68,101,93,95,253,186,190,26,4,175,204,54,42,112,144,60,114,129,214,41,240,147,142,140,39,120,166,172,44,179,134,162,20,191,113,176,37,56,150,106,238,253,29,139,56,62,28,192,224,39,229,17,12,184,42,123,60,30,179,123,31,178,140,187,98,218,216,81,9,227,249,241,63,148,245,76,55,0,73,91,63,126,5,144,135,103,74,103,162,100,191,64,206,238,216,251,60,143,92,51,238,129,0,72,5,250,61,62,195,26,143,220,32,61,229,75,5,93,135,27,26,10,33,125,28,112,105,141,46,200,118,165,58,243,134,21,252,183,160,33,221,129,216,131,91,243,45,123,96,195,206,216,112,210,7,118,22,244,62,122,210,71,196,60,213,138,30,209,128,95,200,248,79,138,53,247,251,183,105,78,178,90,182,27,48,178,86,50,150,245,81,129,150,165,166,78,29,72,139,166,181,218,96,162,212,252,69,203,215,60,209,252,174,132,83,57,206,130,210,242,168,110,191,236,183,218,91,2,238,108,221,159,69,16,8,178,237,176,49,217,65,57,12,92,179,131,85,146,45,140,66,197,181,250,9,17,255,28,114,194,7,35,138,133,249,78,101,228,90,90,9,122,116,203,202,93,27,12,170,29,169,183,171,72,102,202,200,251,69,26,60,218,236,124,231,239,250,10,50,29,85,20,131,254,250,221,78,206,53,21,97,44,185,225,219,147,70,26,239,116,116,1,165,107,242,9,38,114,191,224,156,219,161,158,93,174,128,59,177,251,26,192,21,221,202,157,38,92,234,189,115,226,87,200,29,150,192,39,209,191,212,248,221,119,218,194,241,194,84,151,77,153,29,56,133,210,210,69,115,176,121,24,118,29,173,228,179,33,119,213,204,112,92,222,192,118,199,237,129,174,180,146,80,15,233,49,107,212,162,208,56,32,252,192,114,225,202,111,59,150,255,60,206,23,30,89,123,99,39,249,254,0,253,66,235,56,157,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5977cffb-468d-4a86-a1e4-3fa810cbe99a"));
		}

		#endregion

	}

	#endregion

}

