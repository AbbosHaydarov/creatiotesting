namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnCenterFactorySchema

	/// <exclude/>
	public class IEsnCenterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnCenterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnCenterFactorySchema(IEsnCenterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5db535e2-9bbb-4b57-8890-3bdffc4020de");
			Name = "IEsnCenterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,207,106,132,48,16,135,207,10,190,195,96,47,237,197,220,91,215,139,108,193,75,41,253,243,0,169,142,54,176,73,100,146,20,150,210,119,239,196,117,171,178,189,180,39,153,113,248,126,95,134,49,82,163,27,101,139,240,130,68,210,217,222,23,181,53,189,26,2,73,175,172,41,246,207,15,89,250,153,165,73,112,202,12,80,91,194,187,44,229,250,138,112,224,1,128,198,120,164,158,25,183,208,236,157,169,49,214,247,178,245,150,142,211,164,16,2,74,23,180,150,116,172,230,250,145,236,135,234,208,129,70,255,110,59,7,189,37,104,9,57,148,83,148,113,94,26,182,178,61,40,61,30,80,51,148,25,136,113,166,223,229,75,80,14,162,42,206,33,98,149,50,134,183,131,106,25,53,219,253,38,151,196,135,93,248,77,141,58,186,224,127,76,46,85,146,169,51,74,146,26,12,111,124,151,7,135,196,123,54,216,198,37,231,85,179,138,89,193,95,183,99,49,160,20,19,103,193,18,250,64,198,85,79,211,247,207,194,165,56,3,34,113,249,57,47,224,167,190,222,186,192,246,5,55,124,19,201,215,233,46,208,116,167,211,200,82,238,124,3,138,134,112,100,98,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5db535e2-9bbb-4b57-8890-3bdffc4020de"));
		}

		#endregion

	}

	#endregion

}

