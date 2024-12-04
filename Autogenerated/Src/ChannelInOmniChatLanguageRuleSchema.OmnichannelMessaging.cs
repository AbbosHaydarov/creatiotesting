namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChannelInOmniChatLanguageRuleSchema

	/// <exclude/>
	public class ChannelInOmniChatLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChannelInOmniChatLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChannelInOmniChatLanguageRuleSchema(ChannelInOmniChatLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("793788e6-b334-a107-994a-4852353f66cb");
			Name = "ChannelInOmniChatLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,77,111,219,48,12,64,207,41,208,255,64,120,23,7,8,236,123,154,4,232,140,162,8,208,172,221,218,238,174,218,180,35,192,150,92,74,202,96,20,253,239,163,45,219,115,210,143,245,18,68,12,249,72,62,41,160,68,133,166,22,41,194,3,18,9,163,115,27,37,90,229,178,112,36,172,212,234,252,236,229,252,108,230,140,84,5,220,55,198,98,117,49,158,63,40,137,110,43,37,211,189,80,10,203,104,135,198,136,130,179,223,47,35,252,40,30,93,41,43,173,68,195,9,156,18,199,49,172,140,171,42,65,205,166,63,39,165,48,102,1,53,233,131,204,208,64,41,84,225,68,129,11,200,73,87,208,142,145,236,133,5,143,79,250,137,6,88,60,161,213,238,169,148,41,164,45,112,72,220,170,1,112,211,115,127,185,18,97,9,223,133,193,105,136,235,217,17,127,206,190,17,22,44,0,88,135,177,228,82,171,201,44,225,174,131,251,140,211,53,252,30,132,194,242,252,146,171,132,226,187,208,57,39,33,66,74,152,175,131,79,231,9,226,77,187,209,219,149,124,164,22,36,42,104,111,121,29,56,131,196,147,41,76,219,91,10,54,143,124,134,116,12,68,171,184,203,238,138,123,33,159,182,14,31,143,128,172,121,122,156,183,152,217,18,158,216,86,120,242,19,188,192,107,111,12,85,230,165,29,27,220,161,221,235,236,43,242,238,78,111,255,127,151,255,21,85,186,175,222,102,193,102,36,97,251,32,27,224,102,252,37,151,72,71,198,58,134,84,123,36,105,51,157,66,60,245,168,15,252,182,185,16,174,157,204,224,26,71,143,219,44,236,66,255,26,178,156,206,220,65,16,160,121,134,53,40,252,3,221,159,161,185,79,247,88,137,159,14,169,57,145,31,77,19,118,66,49,154,22,16,12,179,7,243,139,17,58,120,74,116,233,42,245,131,247,229,30,220,41,186,204,50,31,11,135,39,23,13,99,70,44,98,30,181,185,158,115,91,117,255,112,123,101,158,125,137,185,172,107,190,74,118,194,148,27,93,20,216,179,76,200,232,190,187,159,113,220,181,63,250,230,236,196,159,79,22,91,76,213,120,76,39,108,216,98,155,49,224,152,216,178,30,154,122,152,224,183,40,29,174,218,162,77,248,118,247,158,73,104,29,169,9,181,11,191,255,72,57,250,250,23,183,214,209,160,57,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("793788e6-b334-a107-994a-4852353f66cb"));
		}

		#endregion

	}

	#endregion

}

