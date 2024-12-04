namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInOmniChatLanguageRuleSchema

	/// <exclude/>
	public class ContactInOmniChatLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInOmniChatLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInOmniChatLanguageRuleSchema(ContactInOmniChatLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba21deee-aa7e-5f17-8481-2cba8316ae86");
			Name = "ContactInOmniChatLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,77,79,227,64,12,134,207,69,226,63,88,217,75,42,85,147,123,105,43,177,21,66,149,40,176,11,236,125,152,56,233,72,201,76,152,143,162,8,241,223,215,201,36,33,109,1,113,137,98,199,126,108,191,118,20,47,209,86,92,32,60,162,49,220,234,204,177,181,86,153,204,189,225,78,106,117,126,246,118,126,54,241,86,170,28,30,106,235,176,188,24,236,47,82,216,93,169,164,216,113,165,176,96,91,180,150,231,20,253,121,154,193,175,252,236,74,57,233,36,90,10,160,144,36,73,96,97,125,89,114,83,175,58,123,93,112,107,103,80,25,189,151,41,90,40,184,202,61,207,113,6,153,209,37,52,109,172,119,220,65,192,83,143,142,11,199,122,88,50,162,85,254,185,144,2,68,3,236,3,55,170,7,220,116,220,191,190,64,152,195,111,110,113,236,162,124,210,136,158,147,95,6,115,18,160,33,88,103,188,112,218,216,57,220,183,240,16,113,60,70,152,195,32,119,212,191,164,44,174,104,23,58,163,32,68,16,6,179,101,244,109,63,81,178,106,38,58,29,41,120,42,110,120,9,138,182,188,140,188,69,67,44,133,162,217,82,180,122,34,27,196,224,96,139,164,141,110,147,59,65,190,45,29,63,29,0,73,230,177,57,109,48,147,57,60,147,90,241,209,39,120,131,247,78,49,84,105,16,237,80,193,45,186,157,78,127,34,222,253,241,246,15,151,63,59,221,254,79,180,210,93,250,38,141,86,195,29,97,115,145,53,80,53,122,201,36,154,3,201,90,134,84,59,52,210,165,90,64,50,22,82,239,233,184,41,17,174,189,76,225,26,7,33,55,105,220,186,62,10,146,58,173,116,123,110,0,237,11,44,65,225,43,180,127,67,253,32,118,88,242,63,30,77,125,164,62,27,7,108,185,34,180,153,65,212,247,30,77,47,6,104,47,212,90,23,190,84,183,52,47,213,160,74,236,50,77,131,47,238,111,142,245,109,50,18,98,202,154,216,192,185,43,219,95,220,93,217,151,144,98,47,171,138,118,73,154,16,229,70,231,57,118,44,27,19,186,171,30,122,28,102,237,204,80,156,52,9,246,209,96,179,177,52,1,211,10,214,79,177,73,9,112,72,108,88,143,117,213,119,240,143,23,30,23,77,210,42,62,157,189,99,26,116,222,168,17,181,117,127,126,165,228,125,255,15,14,192,98,171,57,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba21deee-aa7e-5f17-8481-2cba8316ae86"));
		}

		#endregion

	}

	#endregion

}

