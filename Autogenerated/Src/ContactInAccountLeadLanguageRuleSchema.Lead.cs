namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInAccountLeadLanguageRuleSchema

	/// <exclude/>
	public class ContactInAccountLeadLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInAccountLeadLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInAccountLeadLanguageRuleSchema(ContactInAccountLeadLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cfdf212a-4f1d-4503-a3e8-25f804f8d198");
			Name = "ContactInAccountLeadLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,77,111,219,48,12,134,207,41,208,255,64,120,151,4,8,236,123,154,38,232,130,162,8,208,110,253,220,157,145,232,68,128,45,165,250,200,96,12,253,239,163,44,187,77,210,109,217,197,128,40,242,17,223,151,180,198,154,220,22,5,193,51,89,139,206,148,62,95,24,93,170,117,176,232,149,209,231,103,191,206,207,6,193,41,189,134,167,198,121,170,47,222,207,251,37,150,254,22,207,175,181,87,94,145,227,4,78,249,98,105,205,92,88,84,232,220,4,248,49,143,194,47,245,149,16,38,104,127,75,40,111,81,175,3,174,233,49,84,212,214,20,69,1,83,23,234,26,109,51,235,206,109,253,24,252,6,61,108,173,217,41,73,14,68,162,65,105,77,13,152,136,160,52,84,76,133,170,195,130,101,110,222,99,139,61,238,54,172,42,37,64,68,244,201,206,96,2,95,209,209,97,179,3,118,139,191,31,42,141,118,222,6,225,141,101,177,247,45,63,101,28,107,74,162,44,161,103,29,138,171,80,243,84,76,201,73,68,32,44,149,151,217,169,150,178,98,22,117,125,22,150,34,91,180,88,131,230,145,95,102,193,145,101,156,38,17,167,156,205,94,248,28,237,235,2,249,180,104,179,219,226,206,150,83,175,15,95,14,152,112,248,196,40,146,6,19,88,177,103,195,163,43,136,59,54,24,196,207,91,231,31,105,153,44,60,244,243,142,252,198,200,255,177,242,251,202,35,219,248,49,117,94,16,94,196,82,177,206,118,61,250,93,225,245,232,55,165,141,199,93,249,151,139,74,111,200,42,47,141,128,98,223,30,179,227,181,231,71,224,38,40,9,55,228,123,111,150,114,216,134,226,243,190,121,36,97,172,92,202,94,244,14,45,144,123,133,75,208,244,19,218,127,165,121,18,27,170,241,33,144,109,142,76,205,247,19,238,80,51,222,142,33,139,163,200,70,23,239,192,94,244,194,84,161,214,223,120,226,204,39,247,154,95,73,153,98,195,236,33,96,21,237,144,221,56,243,123,171,162,210,110,204,121,223,126,190,100,116,30,25,137,159,58,232,212,116,88,86,155,194,71,237,142,143,69,39,132,37,31,172,238,238,230,177,250,185,217,82,215,217,15,172,2,77,163,99,179,225,103,29,35,152,207,91,135,243,235,122,235,155,150,247,231,157,73,209,195,224,219,111,215,29,113,207,240,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cfdf212a-4f1d-4503-a3e8-25f804f8d198"));
		}

		#endregion

	}

	#endregion

}

