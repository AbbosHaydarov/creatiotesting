namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportEntitiesChunksDataProviderSchema

	/// <exclude/>
	public class IImportEntitiesChunksDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportEntitiesChunksDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportEntitiesChunksDataProviderSchema(IImportEntitiesChunksDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a8003b9-4985-421c-aeb6-96632952b722");
			Name = "IImportEntitiesChunksDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,65,110,194,48,16,60,131,196,31,86,112,105,37,148,220,75,200,133,82,148,67,37,4,253,128,227,108,192,106,98,71,107,27,138,42,254,94,219,129,136,82,137,28,122,244,120,102,103,118,156,72,86,163,110,24,71,248,64,34,166,85,105,162,133,146,165,216,89,98,70,40,25,189,137,10,179,186,81,100,70,195,239,209,112,96,181,144,59,216,158,180,193,122,118,119,118,210,170,66,238,117,58,90,161,68,18,220,113,28,107,66,184,115,40,100,210,32,149,206,239,5,178,118,234,82,26,97,4,234,197,222,202,79,253,202,12,91,147,58,136,2,41,8,227,56,134,68,219,186,102,116,74,47,231,86,8,133,227,66,115,33,67,169,200,17,17,129,19,150,243,113,255,58,81,112,62,5,95,111,59,134,56,141,174,142,241,141,101,99,243,74,112,16,215,232,253,201,187,229,186,225,215,155,164,197,61,20,238,146,187,16,105,10,174,100,103,218,53,246,142,102,175,10,221,130,247,109,4,96,203,14,232,210,185,2,234,176,35,176,92,89,227,155,225,168,195,235,144,58,2,161,182,149,241,11,254,221,112,0,7,37,138,48,104,221,170,176,216,168,227,211,202,58,148,251,108,89,49,245,5,248,73,153,44,240,107,10,185,82,21,104,203,61,27,230,96,200,226,243,236,65,202,13,26,18,232,146,242,238,27,129,163,48,251,222,228,250,113,244,108,41,109,141,196,242,10,147,219,240,155,32,74,97,133,230,22,214,191,150,234,73,92,171,127,55,27,138,109,39,245,199,152,160,44,218,103,15,231,115,251,235,220,128,231,31,124,233,142,117,176,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a8003b9-4985-421c-aeb6-96632952b722"));
		}

		#endregion

	}

	#endregion

}

