namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebAnalyticsVisitorModelSchema

	/// <exclude/>
	public class WebAnalyticsVisitorModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebAnalyticsVisitorModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebAnalyticsVisitorModelSchema(WebAnalyticsVisitorModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("233289f6-ed87-4d47-adc7-85f4a748505c");
			Name = "WebAnalyticsVisitorModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,77,107,195,48,12,134,207,13,228,63,8,122,111,238,235,24,140,30,198,14,133,66,199,122,118,18,37,8,98,59,147,228,141,80,250,223,231,56,205,216,71,55,70,47,2,73,214,251,62,178,156,177,40,189,169,16,158,144,217,136,111,116,181,241,174,161,54,176,81,242,46,207,142,121,182,8,66,174,133,253,32,138,118,157,103,177,178,100,108,99,27,54,157,17,185,129,3,150,247,206,116,131,82,37,207,36,164,158,183,190,198,46,189,45,138,2,110,37,88,107,120,184,59,231,105,14,212,3,99,207,40,232,20,222,176,4,51,139,192,235,164,2,118,148,89,205,42,197,39,153,62,148,29,85,80,37,165,223,1,22,113,129,24,63,136,119,236,123,100,37,140,216,187,36,49,245,191,83,78,152,222,169,169,20,130,163,151,128,64,117,4,165,134,144,71,162,159,72,51,211,67,160,122,158,125,172,225,8,45,234,26,100,12,167,63,220,14,120,233,7,254,107,42,202,227,149,206,219,95,109,27,101,208,216,171,54,222,167,209,203,206,75,116,245,116,129,148,79,213,175,197,211,59,90,54,142,55,142,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("233289f6-ed87-4d47-adc7-85f4a748505c"));
		}

		#endregion

	}

	#endregion

}

