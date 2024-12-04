namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnCenterFactorySchema

	/// <exclude/>
	public class EsnCenterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnCenterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnCenterFactorySchema(EsnCenterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1");
			Name = "EsnCenterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,148,77,79,227,48,16,134,207,69,226,63,88,229,146,72,40,189,243,81,105,9,237,170,210,130,86,176,123,90,237,193,196,147,96,17,236,106,108,195,86,136,255,190,227,184,77,234,180,133,144,155,95,207,60,51,158,188,182,226,207,96,150,188,0,246,11,16,185,209,165,205,114,173,74,89,57,228,86,106,149,205,238,111,143,143,222,142,143,70,206,72,85,177,92,35,156,71,171,108,206,11,171,81,130,33,157,118,78,16,42,74,100,44,175,185,49,103,108,102,84,14,202,2,134,184,85,19,52,153,76,216,133,84,143,128,210,10,93,176,201,148,196,63,215,80,114,87,219,43,169,4,209,19,187,90,130,46,147,69,159,144,166,127,41,122,233,30,106,89,176,194,87,217,41,194,206,216,78,26,229,248,115,180,13,222,128,125,212,130,58,252,217,144,154,190,246,55,182,169,213,33,89,142,192,45,180,235,228,183,1,164,193,41,40,252,212,152,139,150,41,107,10,143,94,56,246,118,190,97,229,158,137,192,46,153,130,87,154,167,50,22,157,111,119,179,147,140,227,140,241,105,31,126,222,178,107,249,4,119,176,212,70,54,51,184,12,191,96,125,252,236,59,216,11,127,130,31,81,212,52,217,223,209,22,182,148,245,0,236,60,138,26,128,5,163,110,192,24,94,81,26,23,52,211,3,224,40,232,139,92,209,176,62,37,135,176,97,236,123,40,28,153,99,53,83,149,84,112,8,29,71,13,32,215,186,162,125,11,255,54,94,240,127,170,211,130,129,154,143,212,153,226,15,53,8,138,140,185,190,252,194,204,201,154,14,97,29,148,140,91,151,82,102,5,184,214,199,233,105,199,244,246,93,236,225,229,14,145,82,253,118,182,16,189,132,91,122,60,62,78,241,17,93,206,123,56,45,125,8,212,160,218,157,92,219,233,52,57,120,29,160,239,96,186,17,177,241,183,15,54,250,136,19,57,139,48,125,233,235,160,96,164,30,74,52,226,96,88,108,157,192,138,181,97,168,248,218,18,39,22,134,65,58,91,250,49,183,139,52,56,247,61,60,154,39,160,68,120,84,105,21,180,109,137,148,255,187,93,169,106,104,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1"));
		}

		#endregion

	}

	#endregion

}

