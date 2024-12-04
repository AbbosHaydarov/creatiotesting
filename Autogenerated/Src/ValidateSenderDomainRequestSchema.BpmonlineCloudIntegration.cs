namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderDomainRequestSchema

	/// <exclude/>
	public class ValidateSenderDomainRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderDomainRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderDomainRequestSchema(ValidateSenderDomainRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f9ce81e-a5d7-4bb1-aa16-62e6c9485129");
			Name = "ValidateSenderDomainRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,193,110,194,48,12,134,207,32,241,14,22,92,182,75,123,31,219,46,128,208,14,76,136,78,187,32,14,161,113,187,72,109,210,217,41,18,67,123,247,185,41,32,96,104,18,187,52,181,99,255,249,252,39,86,149,200,149,74,17,222,144,72,177,203,124,52,114,54,51,121,77,202,27,103,163,209,36,153,57,141,5,247,186,187,94,183,83,179,177,57,36,91,246,88,14,47,226,104,81,91,111,74,140,18,36,163,10,243,21,20,164,74,234,6,132,185,4,48,42,20,243,3,188,203,182,86,30,19,180,26,105,236,74,101,236,2,63,107,100,31,202,227,56,134,71,174,203,82,209,246,121,31,135,86,200,28,1,181,149,224,29,108,246,66,192,65,9,116,144,138,14,18,241,137,198,114,172,188,146,225,60,169,212,175,36,81,213,235,194,164,144,6,221,63,137,58,50,186,124,143,83,204,201,85,72,222,160,140,50,15,42,237,254,37,118,72,76,209,51,8,53,55,171,255,64,64,209,46,192,104,20,183,50,131,212,208,254,198,109,121,103,88,174,145,238,94,229,158,224,9,250,161,245,69,247,239,27,254,195,0,211,218,104,152,180,59,176,131,28,253,176,57,108,8,223,183,80,157,25,200,55,48,241,137,99,124,78,198,158,228,121,44,87,112,234,42,255,159,209,54,71,186,44,252,87,228,54,226,225,45,238,29,90,154,248,26,104,115,175,199,130,107,148,3,25,163,125,2,33,110,179,231,73,201,253,0,47,158,90,233,85,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f9ce81e-a5d7-4bb1-aa16-62e6c9485129"));
		}

		#endregion

	}

	#endregion

}

