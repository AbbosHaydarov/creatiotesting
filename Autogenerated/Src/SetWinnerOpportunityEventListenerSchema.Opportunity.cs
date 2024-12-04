namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SetWinnerOpportunityEventListenerSchema

	/// <exclude/>
	public class SetWinnerOpportunityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SetWinnerOpportunityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SetWinnerOpportunityEventListenerSchema(SetWinnerOpportunityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("231522b7-74cb-4b33-902e-c806990f6c39");
			Name = "SetWinnerOpportunityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,193,110,219,48,12,61,187,64,255,129,240,46,54,80,200,247,46,41,176,118,221,118,216,150,1,217,176,195,208,131,98,51,137,6,91,50,40,201,67,48,244,223,71,73,118,144,172,105,114,177,77,138,79,124,124,143,214,178,67,219,203,26,225,59,18,73,107,214,78,60,24,189,86,27,79,210,41,163,175,175,254,94,95,101,222,42,189,57,42,33,20,143,218,41,167,208,190,189,84,32,30,7,212,46,212,113,229,27,194,13,223,11,15,173,180,246,22,150,232,126,42,173,145,22,125,111,200,121,173,220,46,150,127,86,214,33,231,35,168,170,42,152,89,223,117,146,118,119,99,252,73,234,166,69,130,181,33,56,0,3,99,227,43,246,20,19,184,250,15,61,179,136,178,181,6,106,194,245,60,63,207,92,220,75,139,49,119,204,45,135,42,220,247,235,196,81,177,172,183,216,201,175,172,47,204,33,63,32,152,151,79,140,233,253,170,85,53,212,65,133,203,34,192,45,188,66,129,175,98,131,248,185,23,246,11,186,173,105,88,218,111,100,28,214,14,155,116,222,79,33,12,138,123,200,22,6,163,154,208,251,160,107,162,81,164,70,163,148,37,132,21,200,178,65,18,216,19,213,139,30,211,174,240,160,81,189,15,178,118,134,130,124,209,228,20,238,196,71,116,179,229,57,252,93,17,251,100,153,198,63,47,110,50,218,58,242,33,124,71,27,223,49,181,34,247,22,137,15,52,143,197,240,252,102,36,44,126,28,229,203,50,108,104,150,157,229,46,222,155,253,119,49,206,29,97,207,163,186,168,155,36,240,107,106,251,96,104,58,140,11,166,244,22,73,185,198,212,105,75,38,203,205,192,187,166,26,76,242,47,244,82,14,252,239,20,102,245,155,233,178,192,186,65,186,129,228,192,61,242,118,99,52,156,167,182,128,147,23,43,222,6,177,199,78,32,28,39,13,78,141,191,193,28,70,51,203,84,148,10,78,154,126,121,234,148,61,78,62,255,3,206,77,237,177,67,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("231522b7-74cb-4b33-902e-c806990f6c39"));
		}

		#endregion

	}

	#endregion

}

