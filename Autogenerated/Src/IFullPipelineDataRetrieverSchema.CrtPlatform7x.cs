namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFullPipelineDataRetrieverSchema

	/// <exclude/>
	public class IFullPipelineDataRetrieverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFullPipelineDataRetrieverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFullPipelineDataRetrieverSchema(IFullPipelineDataRetrieverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bab0b7d8-fd3f-4488-b7c0-eec4053f33c3");
			Name = "IFullPipelineDataRetriever";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,77,110,194,48,16,133,215,32,113,135,81,216,180,155,120,79,67,54,45,173,178,168,20,81,46,96,146,73,176,228,216,209,216,166,66,21,119,175,19,147,16,168,202,198,146,231,231,211,123,207,86,188,65,211,242,2,97,135,68,220,232,202,198,175,90,85,162,118,196,173,208,106,49,255,89,204,103,206,8,85,195,215,201,88,108,124,95,74,44,186,166,137,63,80,33,137,226,101,49,247,83,75,194,218,87,33,83,22,169,242,208,21,100,239,78,202,92,180,40,133,194,55,110,249,22,45,9,60,34,245,27,140,49,72,140,107,26,78,167,244,114,207,73,31,69,137,6,196,128,1,93,1,133,61,46,161,242,68,104,47,72,40,61,51,30,72,108,130,106,221,94,138,98,2,121,36,101,230,77,250,115,116,240,137,246,160,75,179,130,188,167,132,230,189,216,190,48,64,70,33,127,149,132,74,203,137,55,160,124,222,235,104,80,191,81,86,216,83,200,219,68,233,238,128,87,99,216,247,160,152,62,134,137,19,214,115,174,88,159,139,35,101,210,235,163,116,105,37,6,17,10,194,106,29,77,93,111,245,119,196,210,132,13,75,29,37,219,40,215,32,241,189,196,228,110,54,133,105,76,79,255,77,78,93,164,163,129,27,111,207,225,131,204,150,168,202,16,113,127,63,135,111,115,83,60,255,2,218,137,64,206,147,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bab0b7d8-fd3f-4488-b7c0-eec4053f33c3"));
		}

		#endregion

	}

	#endregion

}

