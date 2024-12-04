﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMentionSearchRuleEntityRepositorySchema

	/// <exclude/>
	public class SocialMentionSearchRuleEntityRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMentionSearchRuleEntityRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMentionSearchRuleEntityRepositorySchema(SocialMentionSearchRuleEntityRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df2f2b65-3bbc-4d32-a495-5a77a207f077");
			Name = "SocialMentionSearchRuleEntityRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c726abc-cc67-49b0-9345-f38bdff9ced8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,86,93,143,218,58,16,125,78,165,254,7,139,190,4,105,21,222,111,1,169,44,80,173,116,119,181,130,219,190,123,147,1,172,38,54,178,157,221,210,170,255,253,142,191,136,147,133,40,220,251,194,135,61,115,60,62,51,115,60,156,86,160,142,52,7,242,15,72,73,149,216,233,236,94,240,29,219,215,146,106,38,248,199,15,191,63,126,72,106,197,248,158,108,79,74,67,133,251,101,9,185,217,84,217,87,224,32,89,254,185,107,179,164,154,54,139,49,118,85,9,126,121,71,194,181,245,108,185,192,45,220,252,36,97,143,231,146,251,146,42,69,182,34,103,180,124,4,110,98,217,2,149,249,97,83,151,176,194,255,250,180,129,163,80,76,11,121,178,158,199,250,165,100,57,201,111,115,76,240,242,248,121,62,119,205,160,44,212,95,228,89,10,141,20,64,225,182,39,147,9,153,170,186,170,168,60,205,155,5,0,146,75,216,205,70,223,20,72,100,149,59,214,70,147,57,97,92,105,202,115,200,206,214,147,216,255,24,240,137,4,90,8,94,158,72,27,163,243,215,177,147,124,2,94,184,72,219,97,163,161,210,178,206,241,82,38,120,75,133,179,240,180,12,36,36,237,4,81,231,99,98,202,35,73,58,27,51,220,50,201,76,254,244,7,246,8,250,32,134,18,186,5,83,118,42,38,246,74,220,134,225,2,43,48,120,82,94,24,7,170,97,136,183,187,181,193,200,207,149,126,37,79,118,69,130,174,37,87,243,255,136,60,157,4,128,118,230,255,102,74,79,123,129,230,228,43,232,43,22,42,13,169,121,165,146,72,179,130,89,225,240,54,4,55,29,127,62,187,30,233,30,148,163,30,1,122,14,116,54,193,213,181,113,186,92,172,126,66,94,99,241,144,226,229,252,115,214,41,223,108,197,85,45,97,185,104,150,210,113,136,63,64,61,24,77,217,96,59,0,98,53,63,103,113,132,153,59,2,220,94,218,28,217,160,37,111,7,86,2,73,27,136,204,124,69,231,37,137,165,43,251,82,20,15,187,39,161,87,63,145,49,149,222,219,2,234,37,238,193,119,117,4,62,246,124,216,86,104,190,220,167,75,188,203,78,220,46,23,203,127,227,170,196,230,240,150,82,11,82,115,71,28,145,140,239,132,172,188,184,59,232,157,20,21,153,30,169,164,21,98,18,142,143,194,108,212,220,1,81,250,234,223,250,189,119,138,251,33,202,157,13,169,58,150,80,97,200,54,138,70,12,167,19,139,245,255,90,43,66,107,55,22,123,197,252,245,75,29,185,37,201,151,11,50,148,17,10,174,97,219,96,232,211,54,63,64,69,177,86,163,170,195,86,194,151,180,174,248,119,90,214,48,117,246,243,116,180,138,60,70,190,122,60,216,142,149,26,228,226,228,252,134,193,173,91,62,29,192,218,182,225,112,48,215,182,49,80,80,23,47,46,189,204,117,158,143,187,22,57,119,157,219,153,114,13,135,249,179,162,118,25,220,45,195,31,11,162,156,132,220,168,244,214,169,183,238,130,160,123,17,29,32,161,145,114,87,193,200,9,176,211,16,203,180,179,109,83,58,206,150,168,85,140,27,16,47,59,153,163,176,91,87,221,221,110,153,116,247,227,204,187,189,108,141,170,145,94,101,181,157,179,214,53,110,155,12,206,211,202,45,185,70,74,52,205,245,90,72,31,89,156,161,232,245,245,154,104,21,184,165,134,246,194,33,108,44,13,115,47,103,54,34,165,16,63,234,227,80,73,116,190,79,248,123,52,127,166,82,19,177,187,16,169,137,207,216,19,125,160,154,188,177,178,36,47,96,90,160,32,90,248,214,192,97,80,213,165,38,37,230,120,144,86,14,101,161,91,178,110,40,180,131,194,59,8,59,116,248,85,213,44,47,78,110,234,240,194,210,92,58,46,230,220,187,197,147,200,251,3,226,233,35,12,46,189,131,142,51,199,87,13,40,38,41,237,87,120,43,86,204,63,186,227,240,230,135,200,204,163,191,161,124,15,241,203,111,76,141,36,94,1,14,100,164,209,165,195,171,207,118,36,61,99,223,139,154,107,50,159,145,213,246,105,13,80,60,138,2,221,183,32,95,25,202,134,199,13,104,207,56,213,108,217,175,51,127,73,242,130,247,251,225,113,47,76,17,225,152,107,221,229,215,218,13,247,231,95,150,216,253,34,1,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df2f2b65-3bbc-4d32-a495-5a77a207f077"));
		}

		#endregion

	}

	#endregion

}

