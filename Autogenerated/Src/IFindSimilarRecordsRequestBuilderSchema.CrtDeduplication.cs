namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFindSimilarRecordsRequestBuilderSchema

	/// <exclude/>
	public class IFindSimilarRecordsRequestBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFindSimilarRecordsRequestBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFindSimilarRecordsRequestBuilderSchema(IFindSimilarRecordsRequestBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f0cc1cb-f956-4f6e-ba88-abeb40ffc587");
			Name = "IFindSimilarRecordsRequestBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,107,220,48,16,61,39,144,255,48,56,151,44,4,155,148,66,33,217,236,161,13,129,28,74,75,54,57,133,28,180,214,120,87,176,150,156,25,137,18,218,252,247,142,108,107,191,146,18,111,201,197,48,26,205,155,121,239,141,108,85,141,220,168,18,225,14,137,20,187,202,231,223,156,173,204,60,144,242,198,217,252,10,117,104,150,166,108,163,163,195,223,71,135,7,129,141,157,195,244,153,61,214,23,171,120,19,128,80,206,37,115,76,56,151,50,184,177,30,169,146,54,231,112,115,109,172,158,154,218,44,21,221,98,233,72,243,45,62,5,100,255,53,152,165,70,106,11,139,162,128,49,135,186,86,244,60,233,227,62,15,174,2,191,64,73,35,66,73,88,93,102,17,242,170,159,18,19,92,86,76,160,114,4,140,138,202,69,156,80,10,185,107,220,35,162,245,198,27,228,60,117,44,54,90,54,97,38,128,96,210,232,67,38,63,16,121,228,187,226,253,29,253,194,105,62,135,159,45,88,151,220,229,182,38,199,195,137,145,171,65,1,55,88,154,202,160,222,45,218,30,243,90,110,79,189,184,162,55,32,188,235,165,129,100,112,39,196,107,37,186,147,70,145,170,193,202,194,92,102,213,128,22,147,59,225,66,93,16,155,205,34,195,150,160,197,95,169,117,159,207,199,69,11,191,238,70,232,3,89,110,65,140,101,175,172,56,176,135,243,111,178,27,23,9,54,246,121,179,182,51,162,15,78,6,72,9,3,180,24,93,188,239,124,82,106,189,178,255,225,75,96,36,121,190,22,203,248,90,179,201,189,196,80,174,14,94,203,188,183,169,137,181,86,94,253,219,181,233,46,129,116,127,83,255,135,31,51,118,75,244,120,146,125,201,207,62,229,159,225,79,255,96,192,72,1,54,132,177,86,231,32,52,222,127,125,249,190,206,141,178,209,227,192,61,136,58,174,117,133,109,153,79,33,162,180,48,31,184,43,199,104,117,247,23,105,227,151,238,127,186,117,248,242,23,79,137,135,212,190,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f0cc1cb-f956-4f6e-ba88-abeb40ffc587"));
		}

		#endregion

	}

	#endregion

}

