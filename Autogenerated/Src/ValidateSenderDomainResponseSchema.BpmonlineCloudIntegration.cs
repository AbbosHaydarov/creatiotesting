namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderDomainResponseSchema

	/// <exclude/>
	public class ValidateSenderDomainResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderDomainResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderDomainResponseSchema(ValidateSenderDomainResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("871f1b8a-e82c-41c2-a927-53b14043304e");
			Name = "ValidateSenderDomainResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,146,65,107,194,64,16,133,207,10,254,135,193,94,218,75,188,87,235,69,139,8,181,136,41,189,148,30,214,100,146,46,36,187,97,102,35,88,233,127,239,236,38,22,137,210,66,15,165,151,132,125,243,50,243,189,157,24,85,34,87,42,65,120,66,34,197,54,115,209,204,154,76,231,53,41,167,173,137,102,247,241,202,166,88,240,160,127,24,244,123,53,107,147,67,188,103,135,165,56,139,2,19,111,227,104,129,6,73,39,227,174,103,83,27,167,75,140,98,169,170,66,191,135,174,226,18,223,21,97,46,7,152,21,138,249,22,158,165,156,42,135,49,154,20,105,110,75,165,205,70,232,164,59,6,255,104,52,130,9,215,101,169,104,63,109,207,27,172,8,25,141,99,160,214,11,54,3,247,134,192,72,59,45,201,50,75,82,115,164,113,231,185,210,208,152,131,44,31,166,94,67,145,138,232,56,98,116,50,163,170,183,133,78,32,241,136,63,16,246,228,126,228,249,21,107,77,182,66,114,26,37,219,58,180,105,234,221,24,65,88,160,36,8,68,242,246,244,13,166,103,58,135,234,189,204,149,83,43,44,183,72,215,143,178,66,184,131,33,159,64,45,77,102,121,120,243,234,189,109,130,7,205,110,18,119,60,83,232,42,12,7,200,209,141,61,200,24,62,218,68,98,106,66,133,115,163,118,196,206,50,187,125,255,199,2,207,169,254,112,105,85,67,194,18,68,136,27,136,75,183,125,113,212,6,93,77,18,218,81,141,160,143,247,227,211,180,67,65,51,236,252,255,249,253,244,173,181,5,44,57,252,201,191,92,181,96,126,2,147,170,249,53,55,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("871f1b8a-e82c-41c2-a927-53b14043304e"));
		}

		#endregion

	}

	#endregion

}

