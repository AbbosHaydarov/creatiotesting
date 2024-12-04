namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LanguageInContactLanguageRuleSchema

	/// <exclude/>
	public class LanguageInContactLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LanguageInContactLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LanguageInContactLanguageRuleSchema(LanguageInContactLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2c80707-56d1-485c-9153-61f3c4d5fd6c");
			Name = "LanguageInContactLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,77,111,219,48,12,134,207,46,208,255,64,104,23,7,8,236,123,150,248,208,44,43,2,108,64,208,172,235,89,149,104,87,128,45,101,250,200,22,20,253,239,163,45,167,181,189,172,232,197,176,72,189,212,203,135,146,230,13,186,3,23,8,63,208,90,238,76,233,179,181,209,165,170,130,229,94,25,125,125,245,124,125,149,4,167,116,5,251,147,243,216,124,126,93,15,37,77,99,244,229,140,197,255,197,179,47,55,148,162,100,158,231,176,116,161,105,184,61,21,253,122,93,115,231,230,112,176,230,168,36,58,168,185,174,2,175,112,14,165,53,13,8,163,61,23,62,59,171,243,129,252,16,30,107,37,64,180,21,224,91,175,219,234,117,148,156,3,119,161,70,88,192,13,119,56,12,145,158,58,166,111,242,201,98,69,4,128,116,206,219,32,188,177,110,1,187,174,120,220,49,245,29,141,91,228,158,12,43,82,113,77,100,77,73,155,16,65,88,44,87,236,93,63,44,47,218,142,254,109,41,70,14,220,242,6,52,205,108,197,130,67,75,21,52,138,118,76,172,184,167,117,75,165,15,100,203,188,219,221,137,123,32,239,30,157,222,143,10,194,184,254,172,45,147,44,224,145,104,165,147,20,60,195,75,79,12,181,140,208,198,4,191,163,127,50,242,35,240,118,211,113,3,173,180,87,165,162,238,166,131,255,8,38,65,134,55,84,192,159,238,80,24,43,183,146,21,125,247,208,22,246,167,193,9,35,104,93,41,165,159,208,42,47,141,128,124,136,210,28,233,38,147,16,110,131,146,112,139,175,40,183,50,237,66,189,205,173,36,60,29,187,35,239,198,51,196,190,199,154,16,194,10,52,254,134,184,152,76,97,70,239,164,14,141,78,153,96,115,120,187,59,146,205,178,175,68,35,101,125,47,109,86,176,56,165,36,123,32,211,216,107,186,189,91,183,249,21,120,157,198,106,217,174,109,18,61,218,244,205,230,12,184,235,77,180,239,53,73,46,154,205,54,127,80,4,143,123,122,205,53,70,164,41,93,120,73,227,89,21,16,255,50,226,17,79,250,201,235,128,203,22,72,145,142,220,207,193,4,31,225,157,39,77,30,226,193,22,125,176,122,16,239,194,151,175,24,69,95,254,2,49,96,84,172,196,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2c80707-56d1-485c-9153-61f3c4d5fd6c"));
		}

		#endregion

	}

	#endregion

}

