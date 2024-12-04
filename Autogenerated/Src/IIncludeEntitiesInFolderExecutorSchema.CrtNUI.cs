namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncludeEntitiesInFolderExecutorSchema

	/// <exclude/>
	public class IIncludeEntitiesInFolderExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncludeEntitiesInFolderExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncludeEntitiesInFolderExecutorSchema(IIncludeEntitiesInFolderExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc490832-b2c8-4995-9b6d-4c38bf371f49");
			Name = "IIncludeEntitiesInFolderExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,177,106,3,49,16,68,235,24,252,15,139,211,36,141,213,59,142,33,4,7,174,119,23,92,40,210,234,16,232,86,199,106,5,54,198,255,30,157,116,38,1,7,82,238,104,102,244,24,210,3,166,81,27,132,3,50,235,20,157,172,223,35,57,223,103,214,226,35,193,101,185,88,46,30,30,25,251,233,242,36,200,174,248,55,208,117,100,66,182,184,39,241,226,49,117,244,17,131,69,222,159,208,100,137,92,115,74,41,216,166,60,12,154,207,187,249,238,110,29,165,173,54,0,206,21,32,17,92,45,73,235,91,88,253,74,143,249,43,120,243,3,241,47,195,76,127,135,81,133,55,107,33,97,64,35,104,255,64,152,8,238,17,154,50,106,214,3,80,25,239,117,229,124,40,56,169,173,182,218,109,85,125,172,222,2,10,13,5,159,146,176,167,254,243,8,140,38,178,77,135,88,254,127,126,41,182,107,91,24,201,182,145,167,179,104,223,229,214,194,10,155,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc490832-b2c8-4995-9b6d-4c38bf371f49"));
		}

		#endregion

	}

	#endregion

}

