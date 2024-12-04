namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenAIFeaturesSchema

	/// <exclude/>
	public class GenAIFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenAIFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenAIFeaturesSchema(GenAIFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c34afc2a-3a9e-42a3-8317-da9524c6d9bf");
			Name = "GenAIFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cb0914d9-1fee-4752-8315-10e295faf1dc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,146,65,110,194,48,16,69,215,32,113,135,17,171,118,195,1,138,186,64,80,170,44,232,162,208,3,24,51,137,44,18,219,245,56,85,165,170,119,239,76,156,208,160,130,84,16,89,196,145,253,255,159,255,172,88,85,33,121,165,17,54,24,130,34,151,199,201,220,217,220,20,117,80,209,56,59,121,70,59,203,70,195,175,209,112,80,147,177,5,204,3,202,201,100,201,75,29,112,227,138,162,228,253,233,104,200,18,95,111,75,163,129,34,75,52,232,82,17,65,147,208,170,137,53,18,213,9,15,10,228,113,184,208,21,60,64,43,93,97,84,59,21,149,168,27,75,231,233,169,239,238,33,29,13,50,122,178,106,91,226,14,30,33,134,26,167,105,123,129,164,131,241,66,194,7,227,55,66,152,101,144,187,0,69,74,17,34,25,43,91,202,123,206,111,176,199,201,255,45,111,126,157,111,140,149,91,112,201,75,106,183,150,219,116,223,113,26,200,188,107,9,94,240,51,174,35,122,186,0,225,224,185,13,131,229,56,254,101,164,195,133,16,115,231,77,233,226,63,170,183,202,43,11,183,238,63,117,160,125,142,74,177,103,229,244,126,141,225,195,104,92,186,48,203,94,241,189,70,58,217,179,139,224,90,221,231,111,224,249,168,4,210,115,240,211,71,202,85,73,194,116,172,56,65,87,113,62,80,26,208,92,63,227,134,52,67,112,123,102,38,238,125,202,5,240,242,3,45,155,217,126,65,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c34afc2a-3a9e-42a3-8317-da9524c6d9bf"));
		}

		#endregion

	}

	#endregion

}

