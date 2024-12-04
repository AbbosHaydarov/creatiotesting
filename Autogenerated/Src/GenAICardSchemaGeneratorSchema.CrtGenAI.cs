namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenAICardSchemaGeneratorSchema

	/// <exclude/>
	public class GenAICardSchemaGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenAICardSchemaGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenAICardSchemaGeneratorSchema(GenAICardSchemaGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6cbc09fe-7a42-47c9-aeda-e4c59cd9ad7d");
			Name = "GenAICardSchemaGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ecaffa2e-7d24-4fa3-bf71-1610bb70ac02");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,77,107,219,64,16,61,43,144,255,48,77,46,50,132,37,103,23,31,28,181,14,58,184,132,38,62,133,80,54,210,200,89,144,119,197,236,42,212,4,255,247,206,238,74,173,109,36,211,4,114,145,52,31,59,239,205,155,89,129,150,27,180,141,44,16,30,144,72,90,83,57,145,25,93,169,117,75,210,41,163,197,45,234,121,126,126,6,111,231,103,73,107,149,94,31,100,18,126,29,241,139,121,211,212,170,8,69,172,152,63,91,71,178,136,70,70,24,220,163,71,23,156,105,72,161,229,12,206,185,36,92,115,58,228,218,33,85,76,118,10,121,160,149,73,42,239,139,23,220,72,54,145,9,27,10,7,154,246,153,161,65,245,249,167,210,19,110,140,159,127,65,150,232,94,76,105,167,112,23,138,196,224,171,81,37,116,135,208,151,177,233,94,123,93,128,191,126,162,109,107,7,133,97,100,237,142,253,87,192,34,248,118,101,211,100,166,196,73,108,47,185,68,93,70,244,96,239,98,211,135,206,158,94,86,75,203,228,78,182,255,248,13,43,201,120,55,74,151,12,151,186,109,131,166,74,71,69,152,76,158,254,137,86,120,128,209,250,48,125,143,150,188,73,214,73,237,188,154,164,94,89,187,24,111,162,225,117,178,174,23,229,78,174,241,7,175,227,3,110,154,218,71,103,112,241,118,189,251,181,48,180,241,177,139,97,181,6,6,55,4,213,129,220,162,235,113,210,163,97,132,13,79,146,206,235,47,6,51,136,150,240,28,164,75,143,41,94,237,79,146,207,170,10,210,149,69,226,190,53,134,101,23,89,75,196,171,32,178,90,241,107,165,149,139,170,45,165,230,98,36,22,60,163,60,168,84,224,205,54,240,242,208,19,248,50,3,221,214,117,79,43,249,16,33,94,37,126,18,186,150,116,104,41,184,119,255,43,228,222,13,232,182,227,147,46,66,215,228,161,118,208,30,154,51,24,214,54,182,154,29,9,12,248,91,89,199,32,75,169,244,119,237,148,219,122,190,48,139,114,30,214,126,207,120,246,87,168,231,223,201,61,210,174,184,143,40,246,241,250,73,248,179,17,99,149,51,155,17,154,130,131,39,102,53,244,139,216,253,1,61,246,182,9,205,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6cbc09fe-7a42-47c9-aeda-e4c59cd9ad7d"));
		}

		#endregion

	}

	#endregion

}

