namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketingAppEventListenerSchema

	/// <exclude/>
	public class MarketingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketingAppEventListenerSchema(MarketingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab8c1b0d-1351-4fe6-8ded-74eb63abcdfb");
			Name = "MarketingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,77,107,194,64,16,61,71,240,63,12,233,197,66,73,238,86,3,85,90,16,42,45,42,120,94,147,73,92,52,187,233,206,68,106,75,255,123,39,95,37,218,246,178,176,111,222,188,125,243,102,141,202,145,10,21,35,108,208,57,69,54,229,96,110,77,170,179,210,41,214,214,12,7,159,195,129,87,146,54,217,5,197,97,240,164,98,182,78,35,221,255,193,216,226,78,88,121,110,141,84,165,126,227,48,19,57,152,31,21,209,24,150,202,29,144,165,229,161,40,30,79,104,248,89,19,163,65,87,147,195,48,132,9,149,121,174,220,57,106,239,43,44,28,146,48,9,114,228,189,77,8,216,130,54,154,181,58,234,15,4,153,226,160,50,12,186,254,176,39,80,148,187,163,142,33,174,30,255,255,109,24,195,53,52,83,132,210,47,25,200,249,51,196,178,49,48,134,215,90,183,41,94,155,174,129,153,54,98,180,181,70,82,71,132,216,97,58,245,235,32,154,8,207,126,24,129,102,204,169,50,255,219,125,131,20,202,169,28,140,44,108,234,199,214,48,190,179,31,45,12,177,50,178,62,155,246,197,187,49,100,149,53,47,140,130,73,88,11,212,122,109,28,246,36,235,210,9,194,201,234,4,94,140,116,173,89,57,30,93,181,67,251,220,45,84,127,193,243,118,18,74,208,163,119,229,234,31,120,94,127,176,160,154,127,178,168,116,4,160,141,93,159,77,188,194,183,18,137,239,160,131,183,154,247,115,49,116,184,36,68,163,70,241,171,13,31,77,210,228,95,223,27,244,18,20,236,27,152,237,247,127,209,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab8c1b0d-1351-4fe6-8ded-74eb63abcdfb"));
		}

		#endregion

	}

	#endregion

}

