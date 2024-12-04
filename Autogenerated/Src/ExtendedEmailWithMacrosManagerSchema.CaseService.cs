namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExtendedEmailWithMacrosManagerSchema

	/// <exclude/>
	public class ExtendedEmailWithMacrosManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExtendedEmailWithMacrosManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExtendedEmailWithMacrosManagerSchema(ExtendedEmailWithMacrosManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b4234d1f-a1c8-4608-bfc8-7af5ebf00ca9");
			Name = "ExtendedEmailWithMacrosManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,203,110,219,48,16,60,219,128,255,97,225,94,28,32,176,238,137,35,32,117,28,160,7,3,5,154,162,231,141,184,146,9,72,164,65,82,74,221,34,255,222,37,245,178,252,144,235,131,32,45,57,179,179,179,99,133,5,217,61,38,4,111,100,12,90,157,186,229,90,171,84,102,165,65,39,181,154,77,255,206,166,147,210,74,149,193,143,131,117,84,60,118,223,199,16,67,215,234,203,141,114,210,73,178,124,129,175,124,49,148,49,47,172,115,180,246,1,54,191,29,41,65,98,83,160,204,127,73,183,219,98,98,180,221,162,194,140,204,108,10,252,99,212,190,124,207,101,2,137,7,221,192,192,45,210,175,104,137,41,121,46,126,246,122,180,178,206,148,137,211,134,101,125,15,253,234,27,81,20,193,202,150,69,129,230,16,183,133,111,138,103,194,92,254,33,11,8,138,62,64,50,30,21,59,169,83,112,59,98,8,17,36,134,210,167,249,184,158,121,20,215,131,45,187,110,209,105,187,213,30,13,22,160,120,93,79,243,210,146,97,185,138,18,191,161,121,252,198,221,124,13,146,174,184,92,69,1,17,8,26,243,198,85,44,126,14,88,3,97,255,121,231,121,38,15,240,206,222,45,78,142,192,39,100,242,217,216,201,45,106,71,135,246,110,201,237,180,240,206,26,237,24,72,98,196,220,181,33,116,222,88,5,200,61,42,233,14,252,46,32,149,121,110,65,58,248,96,245,32,40,197,50,119,80,97,94,210,168,121,134,92,105,148,141,159,91,50,242,145,60,176,73,237,73,176,169,85,6,186,226,4,75,65,16,162,123,104,244,180,232,186,184,104,230,158,212,20,39,119,22,119,143,71,166,244,204,149,52,174,196,28,58,37,167,176,33,169,183,123,121,165,59,218,142,229,184,215,69,67,95,131,113,108,103,157,35,14,101,19,165,214,222,57,112,8,131,171,153,172,232,252,158,64,135,254,206,255,70,180,227,189,224,121,31,204,51,88,104,19,175,121,106,240,175,195,20,159,175,167,210,82,132,217,106,83,124,166,61,246,133,161,139,102,117,173,144,123,104,79,64,240,163,245,217,131,91,133,3,120,159,187,222,230,251,26,58,190,217,78,211,69,218,206,141,27,186,194,226,175,76,214,67,207,228,156,252,251,234,234,176,248,249,15,87,104,106,238,243,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4234d1f-a1c8-4608-bfc8-7af5ebf00ca9"));
		}

		#endregion

	}

	#endregion

}

