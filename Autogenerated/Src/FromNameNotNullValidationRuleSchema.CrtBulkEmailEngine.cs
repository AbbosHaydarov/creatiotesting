namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromNameNotNullValidationRuleSchema

	/// <exclude/>
	public class FromNameNotNullValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromNameNotNullValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromNameNotNullValidationRuleSchema(FromNameNotNullValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50");
			Name = "FromNameNotNullValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,221,107,219,48,16,127,118,161,255,195,173,131,146,194,144,223,187,186,15,11,91,9,91,194,72,75,223,21,251,156,136,201,146,119,39,103,152,209,255,125,39,249,99,73,6,123,17,214,79,186,223,199,233,236,116,131,220,234,18,225,5,137,52,251,58,168,165,119,181,217,119,164,131,241,14,174,175,126,95,95,101,29,27,183,135,231,158,3,54,114,193,90,44,227,41,171,39,116,72,166,252,120,121,231,155,113,63,5,20,248,61,225,62,18,45,173,102,190,7,248,66,190,217,136,236,198,135,77,103,237,171,182,166,74,82,219,206,98,170,200,243,28,30,184,107,26,77,253,227,184,223,98,75,200,232,2,67,56,32,148,145,12,126,153,112,0,146,50,6,95,195,113,102,130,218,19,56,209,128,90,196,160,209,37,121,134,93,15,216,180,161,87,147,68,126,162,209,118,59,107,202,145,247,191,22,225,30,62,105,198,11,80,40,164,79,178,206,121,215,24,14,190,146,196,223,201,7,105,23,86,195,249,101,186,4,140,108,56,164,147,156,21,158,38,136,224,100,106,29,211,196,12,255,134,24,144,86,147,110,82,113,113,67,88,154,214,72,219,110,30,183,211,103,236,213,174,179,63,164,27,218,88,245,144,167,130,84,223,78,86,193,31,101,30,76,133,112,244,166,130,149,11,72,78,79,157,192,197,106,141,204,122,143,51,233,202,213,30,102,181,59,136,67,147,101,71,77,241,89,58,156,204,67,1,79,24,82,132,215,9,159,57,22,115,253,7,88,139,53,25,39,153,69,14,172,206,178,127,197,254,46,206,91,150,153,26,22,231,244,239,10,112,242,98,112,123,123,174,171,146,154,250,43,12,69,1,28,72,36,212,231,56,20,147,227,108,246,160,86,206,4,163,237,86,126,16,113,129,75,47,221,40,96,97,36,222,232,238,244,72,45,181,43,209,98,245,156,30,143,199,249,73,29,27,220,190,197,85,150,52,36,114,105,152,147,180,31,208,115,240,237,15,43,177,177,1,156,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50"));
		}

		#endregion

	}

	#endregion

}

