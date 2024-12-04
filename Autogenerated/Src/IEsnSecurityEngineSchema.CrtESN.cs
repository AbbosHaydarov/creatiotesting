namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnSecurityEngineSchema

	/// <exclude/>
	public class IEsnSecurityEngineSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnSecurityEngineSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnSecurityEngineSchema(IEsnSecurityEngineSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9c30106-e300-4bc7-ad30-d1a26877b5c8");
			Name = "IEsnSecurityEngine";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,86,193,106,219,64,16,61,219,224,127,24,210,75,3,193,186,183,174,32,168,34,245,161,37,212,237,7,172,87,35,123,137,181,43,102,118,227,154,210,127,239,172,86,10,85,236,150,134,180,197,244,34,180,195,204,155,247,222,8,205,90,213,32,183,74,35,124,66,34,197,174,246,243,194,217,218,108,2,41,111,156,157,151,171,15,179,233,215,217,116,18,216,216,13,172,14,236,177,121,61,155,74,228,5,225,70,82,0,150,214,35,213,130,242,10,150,37,219,21,234,64,198,31,74,187,49,22,187,212,44,203,96,193,161,105,20,29,242,254,124,75,238,222,84,200,208,160,223,186,138,161,118,4,122,139,250,46,54,106,145,26,195,28,241,189,3,140,29,90,50,140,192,78,27,181,3,139,126,239,232,78,138,153,213,6,121,62,116,201,126,104,211,134,245,206,104,48,3,191,147,244,38,81,221,17,195,46,80,68,54,176,223,10,65,36,144,7,4,150,151,173,98,80,90,75,231,200,141,80,163,185,199,200,81,80,71,132,142,25,165,72,171,72,53,96,197,252,55,23,44,146,27,245,121,89,93,228,171,238,117,64,0,137,205,23,89,151,123,186,52,117,140,149,229,168,55,152,113,225,218,185,29,20,202,126,68,85,165,204,247,41,241,229,77,48,21,60,48,184,130,238,60,192,94,202,152,39,147,231,153,211,58,246,113,156,61,179,51,52,165,32,84,30,127,219,144,63,99,135,118,77,35,168,103,107,71,145,248,253,109,59,176,50,103,250,117,28,21,246,121,215,65,254,85,20,235,251,47,6,84,23,249,153,157,165,40,188,149,161,255,218,201,254,248,168,199,243,253,173,112,135,255,185,193,111,163,68,252,71,22,227,23,89,36,86,182,207,9,175,251,189,244,84,167,187,170,94,234,50,250,61,130,17,213,81,64,109,144,142,221,35,244,129,44,231,11,157,123,10,184,200,116,14,166,78,220,12,167,173,23,201,138,121,99,226,235,224,31,209,141,249,67,206,21,8,96,173,120,151,16,93,84,191,151,205,43,4,134,142,15,3,184,65,255,78,113,226,220,139,40,123,152,235,206,153,126,40,99,149,131,235,223,210,53,2,109,149,110,18,179,169,68,190,3,184,177,15,187,147,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9c30106-e300-4bc7-ad30-d1a26877b5c8"));
		}

		#endregion

	}

	#endregion

}

