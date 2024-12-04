namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebAnalyticsActionQueryExecutorSchema

	/// <exclude/>
	public class WebAnalyticsActionQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebAnalyticsActionQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebAnalyticsActionQueryExecutorSchema(WebAnalyticsActionQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("65a646ad-12ec-4d97-a9ca-53b2aa586a28");
			Name = "WebAnalyticsActionQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,193,110,219,48,12,61,167,64,255,65,240,46,14,96,56,247,116,43,144,166,233,16,96,91,59,36,93,15,65,15,138,196,36,2,108,201,149,168,110,70,209,127,31,101,37,91,156,185,77,81,96,23,195,166,30,31,31,31,69,107,94,130,171,184,0,54,7,107,185,51,43,204,199,70,175,212,218,91,142,202,232,211,147,167,211,147,158,119,74,175,217,172,118,8,229,217,159,239,253,148,178,52,186,251,196,194,75,241,124,162,81,161,2,247,34,224,138,11,52,54,34,8,243,193,194,154,52,177,113,193,157,27,178,59,88,142,52,47,106,84,194,141,68,80,251,221,131,173,39,191,64,120,74,107,82,22,151,176,226,190,192,11,165,37,21,72,177,174,192,172,210,105,83,186,110,225,251,25,251,70,118,176,79,44,57,194,156,244,239,137,186,242,203,66,9,38,130,152,99,90,216,144,93,112,7,251,168,75,142,188,133,201,88,151,42,42,68,19,160,231,223,238,141,118,104,125,112,134,76,184,177,6,65,32,200,8,26,12,6,236,163,210,27,176,10,165,17,131,243,16,220,42,61,162,49,189,117,96,137,92,19,93,168,227,91,159,125,106,97,73,45,164,135,225,39,246,188,213,7,90,70,137,109,189,164,176,2,27,230,252,70,181,59,12,51,143,116,29,148,4,70,253,134,219,17,237,153,137,13,148,60,142,234,156,37,115,227,197,38,182,147,156,189,174,228,43,224,198,200,247,203,216,175,223,88,119,165,10,12,110,20,197,214,179,177,5,142,64,246,32,221,220,120,234,210,127,210,24,184,135,140,125,246,74,50,17,161,83,73,70,134,170,189,71,110,119,193,109,62,93,72,13,63,143,23,79,137,181,31,86,169,215,107,19,228,95,204,90,9,94,92,211,24,154,165,38,198,195,208,140,28,22,152,95,219,78,130,145,148,129,61,143,237,197,232,157,194,205,13,183,52,134,166,201,157,154,178,226,86,57,163,231,180,104,249,228,193,243,34,107,24,123,201,162,153,212,112,42,135,205,203,84,222,135,95,77,40,147,100,123,62,116,183,240,191,20,44,246,151,226,135,114,138,22,33,0,58,194,175,202,181,128,222,234,131,201,53,71,221,219,17,163,237,224,243,111,131,247,32,204,142,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65a646ad-12ec-4d97-a9ca-53b2aa586a28"));
		}

		#endregion

	}

	#endregion

}

