namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLTextSimilarityProblemTypeFeaturesSchema

	/// <exclude/>
	public class MLTextSimilarityProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLTextSimilarityProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLTextSimilarityProblemTypeFeaturesSchema(MLTextSimilarityProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fc5d315-3ac5-48a3-af06-cad122142a03");
			Name = "MLTextSimilarityProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d4e7fe16-4978-48c7-8486-0391de2e8fa7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,145,77,75,3,49,16,134,207,93,216,255,48,199,22,100,247,110,213,131,149,162,208,106,193,222,196,195,116,119,178,4,146,204,146,15,177,148,254,119,39,109,215,143,90,72,14,153,188,121,222,153,55,14,45,133,30,27,130,53,121,143,129,85,172,102,236,148,238,146,199,168,217,85,203,69,89,236,202,98,148,130,118,221,31,149,167,106,142,77,100,175,41,76,203,66,52,117,93,195,77,72,214,162,223,222,157,206,43,244,81,55,201,160,7,69,24,147,167,0,172,4,244,25,225,85,91,45,23,58,110,161,247,188,49,100,33,110,123,170,6,84,253,139,245,246,64,10,147,137,247,218,181,210,201,56,11,89,141,159,150,139,213,241,233,90,10,243,147,195,228,10,158,101,50,184,133,229,34,59,253,24,173,60,181,58,55,93,157,215,121,128,76,222,197,174,79,27,163,27,104,12,134,112,1,242,45,30,28,225,90,84,167,22,47,92,11,49,135,56,202,251,60,165,67,225,17,37,150,20,251,20,97,28,209,119,20,39,208,176,73,214,129,98,15,150,91,50,16,61,106,39,195,231,128,254,39,52,244,204,31,242,73,186,37,216,48,155,12,126,57,112,103,71,218,14,132,61,133,189,100,163,208,4,146,159,27,237,203,66,214,23,186,212,161,149,12,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fc5d315-3ac5-48a3-af06-cad122142a03"));
		}

		#endregion

	}

	#endregion

}

