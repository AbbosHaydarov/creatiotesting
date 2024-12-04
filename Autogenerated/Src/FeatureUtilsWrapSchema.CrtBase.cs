namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeatureUtilsWrapSchema

	/// <exclude/>
	public class FeatureUtilsWrapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeatureUtilsWrapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeatureUtilsWrapSchema(FeatureUtilsWrapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("857989eb-d198-4858-9f7a-b2ad3d351897");
			Name = "FeatureUtilsWrap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,147,77,107,2,49,16,134,207,43,244,63,12,122,113,65,220,187,253,0,107,187,226,161,80,104,165,135,210,67,76,102,53,16,147,37,31,135,165,248,223,59,217,181,98,187,149,22,181,151,64,38,239,251,100,222,12,209,108,141,174,100,28,225,25,173,101,206,20,126,56,49,186,144,203,96,153,151,70,95,116,222,47,58,73,112,82,47,225,169,114,30,215,151,187,253,190,197,226,161,250,48,103,220,27,43,209,145,130,52,61,139,75,2,195,68,49,231,70,144,35,243,193,226,220,75,229,94,44,43,107,205,235,29,22,44,40,127,43,181,32,98,223,87,37,154,162,63,219,19,75,79,196,52,125,35,117,25,22,74,114,224,17,216,226,193,8,90,54,242,80,42,90,119,205,60,160,95,25,65,237,60,214,172,230,48,203,50,184,146,122,133,86,122,97,232,2,139,197,117,183,69,27,78,209,207,220,182,122,175,217,66,161,232,207,29,90,122,72,141,60,190,226,0,156,183,20,36,237,102,55,145,188,237,120,97,140,130,223,221,16,248,39,0,184,17,152,66,156,73,146,88,36,79,60,253,177,131,90,25,135,146,108,254,43,206,0,166,65,138,243,132,106,88,224,42,55,22,107,169,231,90,250,153,248,123,210,193,119,231,153,146,231,198,142,117,21,91,63,109,164,7,57,71,13,119,143,118,206,49,231,132,85,234,244,160,45,198,209,33,149,138,32,215,78,217,67,45,154,191,91,239,155,234,215,226,230,3,77,103,160,222,221,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("857989eb-d198-4858-9f7a-b2ad3d351897"));
		}

		#endregion

	}

	#endregion

}

