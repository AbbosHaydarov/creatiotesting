namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastUtilitiesSchema

	/// <exclude/>
	public class ForecastUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastUtilitiesSchema(ForecastUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91be19b7-738e-4443-9fd0-37cbba5954a8");
			Name = "ForecastUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,77,107,195,48,12,134,207,41,244,63,136,156,186,75,12,59,110,105,160,4,186,235,88,187,221,61,87,246,12,177,29,252,145,81,70,255,251,228,166,161,235,218,195,118,176,192,146,30,189,250,176,220,96,232,185,64,216,162,247,60,56,25,171,214,89,169,85,242,60,106,103,171,181,243,40,120,136,111,247,243,217,215,124,86,164,160,173,186,200,54,198,217,199,249,140,98,140,49,168,67,50,134,251,125,115,250,63,123,55,232,29,6,144,167,66,144,162,238,116,212,24,170,9,97,63,152,62,189,119,90,64,136,36,47,64,116,60,4,152,122,120,157,72,202,163,94,200,94,73,30,29,47,24,147,183,129,138,120,45,34,112,165,60,170,227,56,16,247,61,102,221,107,225,209,211,115,207,13,88,90,203,178,148,201,138,214,237,176,108,178,5,39,175,42,213,236,152,127,198,253,168,220,108,110,43,195,192,187,132,117,64,4,225,81,46,203,213,57,97,75,241,17,43,89,83,179,169,82,46,125,185,147,155,12,60,97,108,121,39,214,212,115,142,44,242,236,116,168,105,134,59,200,199,43,138,240,169,163,248,128,197,111,127,65,251,69,40,105,31,229,195,232,40,198,14,110,203,85,155,100,232,230,103,80,184,100,227,223,208,54,167,94,192,124,80,127,67,87,131,58,129,59,148,60,117,241,127,189,30,178,205,134,222,225,27,115,187,16,130,251,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91be19b7-738e-4443-9fd0-37cbba5954a8"));
		}

		#endregion

	}

	#endregion

}

