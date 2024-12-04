namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsCountValidationRuleSchema

	/// <exclude/>
	public class ActiveContactsCountValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsCountValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsCountValidationRuleSchema(ActiveContactsCountValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0cfaf6c-8e52-4d6e-9308-ace8e31dafc5");
			Name = "ActiveContactsCountValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,219,110,194,48,12,125,46,18,255,96,141,23,120,129,61,143,21,105,66,187,73,48,77,187,189,78,161,117,187,72,33,65,78,50,141,93,254,125,78,75,129,116,108,147,170,42,62,177,143,79,143,93,45,150,104,87,34,67,120,64,34,97,77,225,134,83,163,11,89,122,18,78,26,221,237,124,116,59,137,183,82,151,81,10,225,184,219,225,155,209,104,4,167,214,47,151,130,214,147,77,252,36,148,204,171,106,32,175,16,76,1,34,115,242,21,33,51,218,241,209,242,193,107,55,108,234,71,123,4,43,191,80,50,131,76,9,107,225,172,42,155,110,170,166,161,104,71,126,23,184,79,224,58,70,152,130,21,243,59,233,17,150,65,195,133,68,149,219,19,184,37,249,42,28,214,151,171,58,0,235,40,124,218,57,145,161,89,246,126,95,133,204,232,17,210,9,28,221,24,119,174,141,47,95,98,37,115,91,30,141,247,105,8,69,110,180,90,195,163,69,226,44,141,156,207,189,159,125,20,215,158,37,61,212,121,45,46,86,202,137,172,199,103,206,80,208,91,57,177,145,91,187,242,175,31,253,86,255,184,253,0,194,48,147,164,165,10,210,86,94,245,105,95,127,107,189,37,179,66,114,18,15,43,221,247,21,62,160,68,55,134,173,231,33,248,135,126,142,238,197,228,45,238,246,178,237,111,27,254,190,99,63,151,172,81,185,48,70,109,9,250,141,61,51,153,177,23,185,12,86,204,77,142,10,56,247,90,23,134,141,138,39,112,133,138,77,24,94,162,139,241,89,157,223,111,25,61,168,140,77,100,209,223,16,14,231,226,109,219,170,26,39,164,41,28,195,231,103,211,146,127,181,128,78,182,241,143,138,70,117,82,123,157,30,218,229,160,48,70,126,145,150,16,58,79,26,10,161,108,248,195,25,225,65,237,112,222,206,26,62,60,62,70,249,249,6,131,220,96,51,85,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0cfaf6c-8e52-4d6e-9308-ace8e31dafc5"));
		}

		#endregion

	}

	#endregion

}

