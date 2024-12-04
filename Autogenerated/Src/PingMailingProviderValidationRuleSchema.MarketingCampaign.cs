namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PingMailingProviderValidationRuleSchema

	/// <exclude/>
	public class PingMailingProviderValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PingMailingProviderValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PingMailingProviderValidationRuleSchema(PingMailingProviderValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("245550c8-e406-4a0d-af79-0307b61b4d65");
			Name = "PingMailingProviderValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,203,106,195,48,16,60,43,144,127,216,38,23,7,74,114,111,154,94,74,83,10,13,132,190,174,69,181,215,174,64,182,204,74,10,164,165,255,94,201,178,147,200,53,205,197,176,235,157,213,204,236,84,188,68,93,243,20,225,5,137,184,86,185,153,223,170,42,23,133,37,110,132,170,198,163,239,241,136,89,45,170,34,26,33,92,142,71,238,207,98,177,128,107,109,203,146,211,254,166,173,223,184,20,89,131,6,178,18,33,87,4,37,23,210,239,168,73,237,68,134,52,239,176,139,19,112,109,63,164,72,33,149,92,107,216,186,241,77,64,109,91,208,113,241,147,223,123,5,15,113,199,173,112,108,221,151,77,9,11,255,254,90,160,204,244,21,108,73,236,184,193,240,179,14,5,104,67,158,210,29,145,162,199,244,235,185,41,221,70,139,176,186,129,137,39,176,118,4,48,219,160,214,188,192,201,242,20,77,200,51,85,201,61,180,36,159,145,118,194,25,249,94,70,245,48,230,85,35,57,159,43,76,27,155,222,109,84,7,107,217,20,171,44,232,136,69,185,65,71,221,166,70,145,151,214,152,214,42,11,6,158,181,46,233,189,31,63,127,217,151,20,43,154,129,143,4,99,61,161,176,130,1,229,172,39,205,77,253,209,202,216,207,255,130,157,136,26,201,8,28,150,123,122,71,248,134,2,205,18,14,55,246,197,153,245,27,52,159,42,235,237,238,7,155,157,36,251,224,72,20,231,102,34,202,115,71,240,67,41,121,192,38,157,127,34,79,46,122,30,206,253,229,186,147,37,179,110,146,5,105,171,161,168,206,239,209,196,157,164,103,249,44,28,130,17,26,75,21,228,92,234,246,54,206,151,99,223,37,42,180,135,221,114,221,159,95,40,223,136,88,46,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("245550c8-e406-4a0d-af79-0307b61b4d65"));
		}

		#endregion

	}

	#endregion

}

