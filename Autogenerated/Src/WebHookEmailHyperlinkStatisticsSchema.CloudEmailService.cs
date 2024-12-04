namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookEmailHyperlinkStatisticsSchema

	/// <exclude/>
	public class WebHookEmailHyperlinkStatisticsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookEmailHyperlinkStatisticsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookEmailHyperlinkStatisticsSchema(WebHookEmailHyperlinkStatisticsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("360ea3e1-2a77-455d-9130-520eefc7c9b3");
			Name = "WebHookEmailHyperlinkStatistics";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,77,79,227,48,20,60,7,137,255,96,133,139,35,170,104,207,32,14,180,84,109,181,187,82,181,165,226,236,198,175,173,85,215,14,254,0,170,21,255,157,231,56,46,88,20,184,88,177,253,102,222,204,248,69,177,61,216,150,53,64,238,193,24,102,245,218,213,35,173,214,98,227,13,115,66,171,243,179,255,231,103,133,183,66,109,200,226,96,29,236,175,143,251,145,54,144,239,234,187,33,30,224,209,133,129,13,162,201,72,50,107,175,200,120,207,132,156,30,90,48,82,168,221,194,33,181,117,162,177,93,109,235,87,82,52,164,9,165,95,86,146,43,50,100,22,30,96,53,213,122,135,40,148,133,235,177,209,220,104,196,56,1,216,109,222,17,198,251,158,124,226,5,143,220,51,78,130,163,162,216,128,11,226,139,194,246,31,175,25,194,58,19,92,117,82,254,160,148,31,80,23,160,120,148,146,177,8,229,48,3,209,236,236,79,248,222,199,95,112,91,205,79,155,208,79,248,70,130,67,210,54,1,55,49,218,183,191,225,64,171,158,223,128,243,70,145,21,102,85,231,247,151,201,127,125,175,23,29,65,119,120,52,120,34,131,99,195,39,141,241,77,153,226,50,189,0,93,90,48,56,41,10,154,48,38,196,103,219,164,38,216,223,166,6,255,48,250,27,210,227,151,78,72,17,158,43,168,156,126,40,161,57,211,224,93,224,32,25,168,98,130,98,77,104,78,126,67,126,165,206,125,16,177,18,93,225,170,224,153,44,91,206,28,124,234,81,14,189,220,229,163,87,86,145,167,94,128,163,101,124,195,145,246,202,149,3,28,117,233,247,170,158,51,131,191,143,3,67,227,117,149,32,15,91,48,64,223,73,103,188,172,234,153,29,63,122,38,233,39,112,114,149,208,183,138,211,18,253,124,135,249,232,187,170,234,241,11,52,30,125,197,100,78,143,100,8,33,252,153,217,233,235,27,12,47,249,197,1,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("360ea3e1-2a77-455d-9130-520eefc7c9b3"));
		}

		#endregion

	}

	#endregion

}

