namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetEmailPageUrlResponseSchema

	/// <exclude/>
	public class GetEmailPageUrlResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetEmailPageUrlResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetEmailPageUrlResponseSchema(GetEmailPageUrlResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("872439b1-86b6-4dc6-a409-1b6e24420de0");
			Name = "GetEmailPageUrlResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,65,79,195,48,12,133,207,68,202,127,176,118,130,75,123,103,192,5,16,151,13,161,142,157,16,7,175,184,149,165,38,157,108,23,105,76,251,239,36,101,149,134,122,72,164,56,126,207,223,243,160,28,91,216,28,212,40,20,213,16,141,3,21,27,18,198,142,127,208,184,143,75,239,188,139,24,72,247,88,19,188,147,8,106,223,88,241,216,199,134,219,65,198,46,239,142,222,93,149,101,9,119,58,132,128,114,120,56,191,171,36,236,163,18,52,189,64,75,102,121,32,5,228,14,190,72,185,141,36,176,173,86,197,36,47,47,244,31,79,104,152,230,152,96,109,159,169,176,31,118,29,215,80,119,168,10,47,100,207,217,231,13,91,218,74,55,13,186,133,127,100,41,204,55,215,52,253,38,147,76,58,67,29,11,163,221,12,107,206,245,7,182,166,176,35,185,126,77,187,129,123,88,140,153,206,44,139,155,76,59,225,170,73,14,125,9,11,199,188,139,37,104,190,78,169,55,157,147,119,191,30,205,136,46,143,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("872439b1-86b6-4dc6-a409-1b6e24420de0"));
		}

		#endregion

	}

	#endregion

}

