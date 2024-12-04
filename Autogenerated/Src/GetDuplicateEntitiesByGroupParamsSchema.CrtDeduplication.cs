namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetDuplicateEntitiesByGroupParamsSchema

	/// <exclude/>
	public class GetDuplicateEntitiesByGroupParamsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetDuplicateEntitiesByGroupParamsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetDuplicateEntitiesByGroupParamsSchema(GetDuplicateEntitiesByGroupParamsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87b86dad-c94c-4ef5-a14c-884f5a2ac989");
			Name = "GetDuplicateEntitiesByGroupParams";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,193,110,194,48,12,134,207,32,241,14,22,92,182,75,123,135,109,135,181,172,226,176,13,141,221,16,135,208,186,85,164,38,169,156,228,208,33,222,125,73,10,104,157,58,173,82,21,233,255,109,127,118,156,74,38,80,55,44,71,248,68,34,166,85,105,162,68,201,146,87,150,152,225,74,70,41,22,182,169,121,30,212,108,122,154,77,39,86,115,89,193,174,213,6,197,234,151,142,62,172,52,92,96,180,67,226,172,230,95,161,206,101,185,188,5,97,229,4,36,53,211,122,9,25,154,244,130,198,181,43,50,28,245,115,155,145,178,205,150,17,19,58,20,185,47,142,99,120,208,86,8,70,237,211,69,135,12,52,72,26,132,42,176,134,82,209,255,196,232,74,139,127,224,246,41,51,204,93,218,16,203,205,193,25,141,61,58,6,228,126,204,49,83,78,220,82,220,121,187,223,150,84,131,228,19,151,176,13,172,46,30,26,189,162,56,34,221,189,185,233,225,17,230,232,145,173,87,243,123,223,251,218,92,27,242,75,93,223,194,112,130,10,205,10,180,63,206,127,3,115,85,91,33,245,16,109,127,128,164,139,142,133,169,178,116,41,125,22,151,6,222,131,63,126,36,43,7,32,137,183,199,50,42,191,240,77,209,167,100,150,23,16,158,98,83,140,5,149,188,246,127,205,224,182,95,186,216,16,106,129,178,232,158,55,232,206,237,155,231,111,200,58,0,96,77,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87b86dad-c94c-4ef5-a14c-884f5a2ac989"));
		}

		#endregion

	}

	#endregion

}

