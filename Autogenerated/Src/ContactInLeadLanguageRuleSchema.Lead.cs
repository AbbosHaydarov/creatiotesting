namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInLeadLanguageRuleSchema

	/// <exclude/>
	public class ContactInLeadLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInLeadLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInLeadLanguageRuleSchema(ContactInLeadLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd37686f-0318-45bd-ba58-4b312c10abb5");
			Name = "ContactInLeadLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,77,111,219,48,12,134,207,41,208,255,64,120,151,4,8,236,123,154,15,108,65,81,4,104,183,245,107,119,85,162,19,1,182,228,81,82,6,99,232,127,31,101,57,109,226,46,195,46,6,68,147,15,249,190,164,17,53,186,70,72,132,39,36,18,206,150,62,95,91,83,234,109,32,225,181,53,151,23,191,47,47,70,193,105,179,133,199,214,121,172,175,222,222,199,37,132,231,226,249,181,241,218,107,116,156,192,41,159,8,183,204,133,117,37,156,155,1,55,243,66,250,141,185,69,161,110,133,217,6,177,197,135,80,97,151,92,20,5,204,93,168,107,65,237,178,127,119,133,83,240,59,225,161,33,187,215,10,29,200,132,1,109,160,98,16,84,61,9,136,81,249,129,84,28,161,154,240,82,105,9,50,210,206,79,1,51,248,34,28,158,14,54,98,75,248,251,46,197,26,231,41,72,111,137,21,125,239,192,41,99,56,127,18,64,40,60,207,172,185,74,24,182,222,150,156,132,8,146,176,92,100,103,103,201,138,101,84,242,81,74,138,52,130,68,13,134,23,186,200,130,67,98,142,65,25,119,152,45,159,249,29,61,234,3,249,188,232,178,187,226,222,136,179,109,199,207,39,48,56,101,79,34,98,52,131,23,118,105,60,248,5,241,116,70,163,248,121,237,29,67,163,146,105,167,14,222,161,223,89,245,63,230,125,123,241,130,141,123,95,48,175,159,239,171,212,44,176,36,91,15,47,225,95,142,105,179,67,210,94,89,9,197,177,21,118,207,7,204,92,184,9,90,193,13,250,131,29,27,53,238,66,177,163,111,31,80,90,82,27,117,208,185,23,4,232,126,194,2,12,254,130,238,234,219,71,185,195,90,220,7,164,118,224,99,126,156,112,39,12,227,105,10,89,116,63,155,92,189,1,15,58,215,182,10,181,249,202,219,101,62,119,201,63,43,149,98,227,236,62,136,42,58,192,129,78,123,126,152,55,223,48,43,143,69,9,152,90,246,227,247,28,150,151,194,131,249,166,67,149,9,65,232,3,153,254,223,42,86,63,181,77,236,28,71,249,33,170,128,243,104,209,114,252,113,240,9,172,86,157,165,249,117,221,248,182,227,253,253,46,82,244,52,248,250,7,47,193,218,200,171,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd37686f-0318-45bd-ba58-4b312c10abb5"));
		}

		#endregion

	}

	#endregion

}

