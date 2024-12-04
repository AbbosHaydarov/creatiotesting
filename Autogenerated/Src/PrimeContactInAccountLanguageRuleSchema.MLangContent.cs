namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PrimeContactInAccountLanguageRuleSchema

	/// <exclude/>
	public class PrimeContactInAccountLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PrimeContactInAccountLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PrimeContactInAccountLanguageRuleSchema(PrimeContactInAccountLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("41844107-7e4d-4d9f-9450-654c0ae6bb86");
			Name = "PrimeContactInAccountLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,193,106,219,64,16,61,59,144,127,24,212,139,13,70,186,59,182,33,49,33,8,154,226,54,73,239,155,213,200,94,144,118,213,217,93,23,17,242,239,29,105,87,70,86,90,154,139,96,70,243,222,188,247,102,181,168,209,54,66,34,60,35,145,176,166,116,233,206,232,82,29,60,9,167,140,190,190,122,187,190,154,121,171,244,1,158,90,235,176,190,57,215,99,8,225,191,250,233,189,118,202,41,180,60,192,35,89,150,193,218,250,186,22,212,110,99,189,171,132,181,75,104,200,156,84,129,22,42,161,15,94,28,112,9,37,153,26,132,148,198,107,151,14,232,108,4,111,252,107,165,36,200,142,1,246,164,106,100,249,78,72,151,235,219,0,251,26,201,126,248,10,97,5,119,194,226,184,197,28,236,144,191,179,47,132,7,118,12,76,96,29,121,233,12,217,21,236,251,5,97,98,170,61,136,39,20,142,69,43,70,9,205,73,154,146,135,16,65,18,150,155,100,216,149,235,40,108,188,60,201,182,157,171,143,182,66,167,17,36,106,208,124,163,77,226,45,18,51,104,148,221,89,146,237,11,215,32,207,141,116,157,245,211,61,56,134,242,223,56,230,47,23,164,112,185,99,209,81,205,86,240,202,137,205,39,191,224,13,222,99,106,168,139,16,220,101,138,143,232,142,166,248,76,128,251,233,217,129,43,126,51,165,98,135,211,7,240,153,168,226,120,94,36,219,104,26,58,62,215,142,136,47,242,234,25,148,62,34,41,87,24,9,217,56,69,115,226,231,204,64,120,240,170,128,7,60,39,152,23,243,190,117,94,199,169,244,145,157,4,1,218,95,176,1,141,191,161,127,254,237,147,60,98,45,190,123,164,118,146,122,58,30,120,20,154,153,105,9,73,84,158,44,110,206,156,67,62,59,83,249,90,127,99,175,188,130,23,165,183,69,17,122,243,164,187,57,7,19,175,158,14,90,83,14,99,145,118,144,64,23,118,14,210,93,44,3,27,91,12,245,68,232,114,228,52,176,244,246,7,85,121,193,248,75,194,142,234,185,109,48,170,251,41,42,143,235,14,180,157,127,244,18,57,9,157,39,61,98,237,219,127,127,108,220,125,255,3,14,60,58,101,194,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("41844107-7e4d-4d9f-9450-654c0ae6bb86"));
		}

		#endregion

	}

	#endregion

}

