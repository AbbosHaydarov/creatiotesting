namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TagConstantsSchema

	/// <exclude/>
	public class TagConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TagConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TagConstantsSchema(TagConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae28a44b-17af-49d1-987b-2e02f87bc1ca");
			Name = "TagConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,79,77,107,132,48,16,61,175,224,127,8,235,165,61,76,215,213,36,42,75,15,154,143,210,91,161,246,7,164,154,21,193,53,98,180,69,202,254,247,102,237,169,7,105,7,134,129,121,111,230,189,55,219,182,111,208,235,98,39,125,57,249,158,239,245,234,162,237,160,42,141,74,61,142,202,154,243,244,192,76,127,110,155,121,84,83,107,122,223,251,242,189,221,48,191,119,109,133,236,228,118,21,170,58,101,45,42,85,227,152,118,178,14,191,113,118,135,67,16,4,200,117,128,96,29,107,221,144,223,231,163,86,181,233,187,5,61,205,109,141,94,86,204,61,43,151,65,191,61,215,232,17,245,250,115,197,238,246,156,202,2,115,65,33,76,195,12,240,81,10,200,83,44,129,242,8,19,86,48,34,227,104,127,127,218,86,255,143,3,102,198,193,184,180,122,195,4,225,73,38,226,44,6,153,138,16,112,26,135,144,39,180,0,25,179,164,96,130,68,153,224,219,38,254,204,63,182,31,219,218,41,79,36,229,148,1,102,57,1,92,224,24,10,206,51,200,137,8,143,57,73,163,136,134,63,218,87,223,187,126,3,126,99,119,71,223,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae28a44b-17af-49d1-987b-2e02f87bc1ca"));
		}

		#endregion

	}

	#endregion

}

