namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCSegmentationStrategyBaseSchema

	/// <exclude/>
	public class DCSegmentationStrategyBaseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCSegmentationStrategyBaseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCSegmentationStrategyBaseSchema(DCSegmentationStrategyBaseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9");
			Name = "DCSegmentationStrategyBase";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,83,203,110,219,64,12,60,203,128,255,129,112,47,9,80,88,247,250,1,164,118,208,83,209,32,110,63,128,150,40,105,1,105,87,221,165,156,8,65,255,189,220,149,228,202,174,157,250,212,139,0,113,201,33,103,134,212,88,145,171,49,33,248,78,214,162,51,25,207,55,70,103,42,111,44,178,50,122,190,109,53,86,42,145,32,147,230,233,228,109,58,137,26,167,116,14,187,214,49,85,139,233,68,34,31,44,229,146,13,155,18,157,251,4,219,205,142,242,74,242,3,198,142,5,139,242,246,51,58,10,217,113,28,195,210,53,85,133,182,93,247,255,207,84,91,114,82,226,192,117,249,138,28,112,129,12,104,9,92,135,231,251,162,6,108,82,69,58,161,249,0,22,143,208,234,102,95,170,4,112,239,113,18,134,196,207,244,238,72,145,144,146,239,31,22,70,75,109,147,176,177,66,230,41,224,117,25,231,147,135,192,198,146,128,57,144,249,77,121,32,59,16,104,65,9,14,202,156,240,162,184,0,4,161,152,82,166,52,165,144,120,65,95,217,51,248,155,66,23,169,209,98,5,34,63,173,102,110,52,124,240,226,149,103,235,7,145,133,193,100,99,220,80,68,76,214,125,132,151,66,37,69,144,175,115,108,223,142,180,157,47,227,144,27,250,245,154,93,23,233,238,244,169,31,97,176,101,28,187,7,191,34,81,116,41,125,117,169,64,54,40,138,126,245,14,144,78,59,19,78,29,121,178,166,38,203,50,246,13,126,140,86,137,11,26,148,134,204,216,163,33,206,171,182,116,36,175,150,178,213,236,58,241,89,188,190,226,209,69,205,6,166,151,98,111,144,19,47,224,31,84,191,18,23,38,189,133,231,54,88,238,122,155,45,213,146,142,224,10,211,148,41,236,253,205,104,6,54,242,146,168,90,238,229,218,178,157,31,140,210,199,249,31,250,67,187,187,95,252,135,65,66,196,18,55,86,187,245,15,173,126,54,4,42,245,103,159,41,57,171,115,203,158,187,70,226,16,136,181,163,167,47,141,74,231,143,85,205,173,119,111,25,15,144,151,200,250,220,129,237,78,142,164,164,71,233,199,237,251,140,119,29,55,75,149,57,16,96,89,130,223,207,224,54,150,144,34,227,141,90,31,140,180,223,148,132,246,91,189,149,178,99,219,179,245,232,150,230,52,40,177,223,148,86,246,116,192,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9"));
		}

		#endregion

	}

	#endregion

}

