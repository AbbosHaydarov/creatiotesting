namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateGroupContractSchema

	/// <exclude/>
	public class DCTemplateGroupContractSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateGroupContractSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateGroupContractSchema(DCTemplateGroupContractSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a052ae9-b9e1-450f-b270-7e2a8392c61d");
			Name = "DCTemplateGroupContract";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e81fdc99-2bd3-4785-b2cd-a2accfc6f9a3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,193,110,163,48,16,61,167,82,255,97,54,189,36,82,5,247,180,164,135,68,170,114,200,110,213,118,79,171,30,28,60,36,174,192,80,123,188,41,91,245,223,119,108,66,160,217,68,27,14,24,15,51,111,222,27,63,208,162,64,91,137,20,225,25,141,17,182,204,40,154,149,58,83,107,103,4,169,82,71,243,90,139,66,165,28,36,212,20,205,5,9,255,108,68,74,151,23,31,151,23,3,103,149,94,195,83,109,9,139,155,131,125,244,232,52,169,2,163,39,52,74,228,234,79,192,236,178,206,108,186,44,37,230,150,203,184,240,202,224,154,83,96,150,11,107,39,48,159,61,99,81,229,130,240,222,148,174,234,168,113,106,28,199,112,107,93,81,8,83,79,119,251,80,6,84,130,193,202,160,101,116,144,44,9,210,93,33,100,165,225,34,68,72,13,102,201,240,0,127,24,79,129,107,20,213,81,219,32,238,117,248,213,31,207,11,7,42,183,202,85,10,105,232,122,146,235,128,231,200,247,189,182,7,83,86,104,72,33,11,124,8,8,205,251,67,65,33,240,83,171,55,135,160,164,231,149,41,52,158,217,191,212,26,110,75,44,86,104,60,179,150,218,189,83,18,22,18,62,96,141,116,3,214,223,62,207,104,167,37,190,195,86,209,70,105,160,13,2,237,164,253,191,251,104,97,31,241,205,41,131,18,18,32,227,112,220,39,164,248,72,22,1,253,8,165,43,212,178,25,210,215,137,45,145,54,165,60,103,92,63,126,179,231,120,88,22,240,189,226,84,69,254,236,57,72,222,144,108,140,211,135,31,108,232,29,64,117,213,233,156,53,213,22,180,203,115,15,224,215,19,83,8,145,74,24,81,0,27,28,147,97,107,187,225,180,237,212,57,177,92,189,34,47,219,141,74,55,45,71,148,209,109,28,0,166,189,145,89,226,207,38,237,4,121,247,8,98,35,31,19,48,58,97,195,125,227,49,36,1,124,176,103,242,45,9,162,66,112,112,7,26,183,71,145,193,255,14,252,197,118,74,246,112,145,223,37,32,49,19,46,167,145,247,219,24,238,130,239,162,239,184,245,235,104,12,147,126,254,117,139,19,108,208,135,242,129,230,37,27,194,47,147,192,172,249,53,28,186,163,241,204,215,224,231,95,45,171,114,86,242,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a052ae9-b9e1-450f-b270-7e2a8392c61d"));
		}

		#endregion

	}

	#endregion

}

