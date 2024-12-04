namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInAccountOpportunityLanguageRuleSchema

	/// <exclude/>
	public class ContactInAccountOpportunityLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInAccountOpportunityLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInAccountOpportunityLanguageRuleSchema(ContactInAccountOpportunityLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a831195-1dd5-446c-9d0a-2a61dd77a5bb");
			Name = "ContactInAccountOpportunityLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,77,111,219,48,12,134,207,41,208,255,64,120,151,4,8,236,123,154,15,180,65,81,4,88,215,174,95,119,69,166,19,1,182,228,81,82,6,99,232,127,31,101,57,169,147,110,69,46,6,76,147,15,249,190,164,181,168,208,214,66,34,188,32,145,176,166,112,233,210,232,66,109,60,9,167,140,190,188,248,115,121,49,240,86,233,13,60,55,214,97,117,117,120,239,151,16,254,47,158,222,106,167,156,66,203,9,156,242,141,112,195,92,88,150,194,218,9,112,51,39,164,91,233,107,41,141,215,238,161,174,13,57,175,149,107,190,11,189,241,98,131,79,190,196,182,52,203,50,152,90,95,85,130,154,121,247,222,98,198,224,182,194,65,77,102,167,114,180,32,35,20,202,142,0,133,33,232,145,211,61,44,235,209,106,191,46,149,4,25,128,231,142,5,19,184,17,22,143,39,29,176,99,252,252,80,106,180,117,228,165,51,196,130,31,219,54,49,227,84,80,84,68,40,28,139,80,92,37,52,111,198,20,156,132,8,146,176,152,37,103,78,150,100,243,160,242,179,204,24,169,5,137,10,52,111,127,150,120,139,196,84,141,50,44,60,153,191,242,123,176,176,11,164,211,172,205,110,139,59,147,206,28,98,248,122,132,134,227,78,163,0,28,76,96,205,14,14,79,62,65,184,186,193,32,60,222,59,55,81,231,209,208,99,119,239,209,109,77,126,142,177,15,107,39,216,212,143,171,224,91,225,211,44,20,203,45,200,84,135,179,81,26,68,212,245,149,133,74,111,145,148,203,141,132,172,239,141,217,241,249,51,26,238,188,202,225,14,221,222,145,85,62,108,67,161,169,107,158,80,26,202,87,249,94,234,78,16,160,253,5,51,208,248,27,218,127,166,121,150,91,172,196,79,143,212,156,88,153,246,19,238,133,102,60,141,33,233,237,33,25,93,29,184,123,197,75,83,250,74,255,224,173,115,27,110,150,94,231,121,140,13,147,110,147,233,35,169,160,179,219,112,186,31,62,93,229,201,40,13,165,17,27,251,119,90,58,26,107,141,225,147,97,199,167,146,35,130,208,121,210,221,183,69,168,126,105,106,236,6,122,19,165,199,105,240,107,62,252,60,254,8,22,139,214,223,244,182,170,93,211,242,254,125,39,49,122,28,124,255,11,209,175,91,139,246,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a831195-1dd5-446c-9d0a-2a61dd77a5bb"));
		}

		#endregion

	}

	#endregion

}

