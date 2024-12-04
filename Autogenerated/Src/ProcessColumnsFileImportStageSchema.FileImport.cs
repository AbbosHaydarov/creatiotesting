namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessColumnsFileImportStageSchema

	/// <exclude/>
	public class ProcessColumnsFileImportStageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessColumnsFileImportStageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessColumnsFileImportStageSchema(ProcessColumnsFileImportStageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7af17616-4f9f-4644-894a-b58b57826cf5");
			Name = "ProcessColumnsFileImportStage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,77,79,164,64,16,61,99,226,127,168,232,133,137,10,247,209,209,232,56,70,146,117,99,162,158,54,123,104,233,2,59,129,110,82,221,109,52,198,255,190,5,13,163,140,35,155,221,11,244,199,171,247,120,245,10,45,106,180,141,200,17,238,145,72,88,83,184,100,105,116,161,74,79,194,41,163,147,43,85,97,86,55,134,220,238,206,219,238,78,228,173,210,229,8,77,120,252,205,121,114,37,114,103,72,161,101,4,99,246,9,75,230,4,88,86,194,218,57,220,146,201,209,218,165,169,124,173,237,135,210,157,19,37,118,21,105,154,194,137,210,79,72,202,73,147,67,78,88,44,246,46,132,197,13,244,94,122,58,192,173,175,107,65,175,195,126,245,130,185,119,8,77,16,131,60,168,13,232,244,19,252,215,37,22,194,87,238,66,105,201,110,98,247,218,160,41,226,108,139,222,236,16,126,114,239,96,1,154,95,12,154,244,50,155,253,102,250,198,63,86,138,61,180,230,167,189,195,28,182,104,50,5,39,192,207,117,35,57,42,235,200,183,77,110,219,217,241,7,68,175,53,169,18,63,88,36,166,208,152,183,81,131,31,109,15,91,154,40,202,250,218,243,178,100,81,193,74,231,82,52,14,105,104,100,47,97,104,22,10,230,240,200,159,30,111,144,125,69,195,27,188,247,110,80,203,96,104,236,142,177,13,146,227,241,25,123,251,199,161,24,122,97,158,121,56,149,68,216,64,217,149,246,53,116,203,76,194,226,116,235,125,50,217,201,227,105,35,55,232,158,140,12,3,239,184,33,40,255,211,200,80,62,237,229,12,50,205,1,105,81,245,31,29,7,196,173,32,158,85,190,177,208,172,151,156,67,151,219,114,35,159,164,95,173,136,12,193,193,2,2,199,15,83,150,72,201,181,208,178,194,238,174,253,249,191,47,143,63,41,77,35,131,208,209,223,132,8,157,39,61,153,209,74,59,213,78,205,215,144,162,104,251,200,133,211,241,33,159,253,1,249,151,179,51,30,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7af17616-4f9f-4644-894a-b58b57826cf5"));
		}

		#endregion

	}

	#endregion

}

