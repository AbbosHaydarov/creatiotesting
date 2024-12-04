namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetThrottlingSchedulesResponseSchema

	/// <exclude/>
	public class GetThrottlingSchedulesResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetThrottlingSchedulesResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetThrottlingSchedulesResponseSchema(GetThrottlingSchedulesResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfe8f2e9-f969-4657-87c8-6095ab77b87d");
			Name = "GetThrottlingSchedulesResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,49,111,194,48,16,133,231,34,241,31,78,176,180,75,178,23,202,66,43,150,182,66,132,173,234,96,204,17,44,57,118,228,59,15,20,245,191,247,236,64,218,66,165,46,73,238,249,249,249,125,142,83,13,82,171,52,194,26,67,80,228,119,92,204,189,219,153,58,6,197,198,187,98,254,84,173,196,226,29,33,13,7,199,225,224,38,146,113,53,84,7,98,108,196,108,45,234,228,164,98,129,14,131,209,147,75,207,42,58,54,13,22,149,172,42,107,62,114,176,184,196,55,14,88,203,0,115,171,136,238,97,129,188,222,7,207,108,101,123,165,247,184,141,22,233,124,126,222,81,150,37,76,41,54,141,10,135,217,105,94,97,27,144,208,49,1,239,17,228,59,90,6,191,203,19,247,129,64,167,196,226,156,83,254,8,122,123,84,172,132,157,131,210,252,46,66,27,55,214,104,208,169,218,191,205,110,228,102,228,217,3,45,131,111,49,176,65,161,90,230,160,97,94,191,172,159,5,9,39,240,1,40,189,117,127,163,29,193,85,123,74,245,175,251,119,0,47,216,108,48,220,190,202,127,133,7,24,125,111,239,59,63,27,226,209,93,2,60,19,38,101,122,77,55,131,63,136,147,23,142,80,35,79,82,221,9,124,118,92,99,116,219,14,61,207,157,250,91,20,237,11,140,48,50,247,111,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfe8f2e9-f969-4657-87c8-6095ab77b87d"));
		}

		#endregion

	}

	#endregion

}

