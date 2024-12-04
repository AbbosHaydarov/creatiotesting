namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IChildImportEntitiesSetterSchema

	/// <exclude/>
	public class IChildImportEntitiesSetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IChildImportEntitiesSetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IChildImportEntitiesSetterSchema(IChildImportEntitiesSetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06530102-5f59-41f5-9ac8-4a7901f07ee8");
			Name = "IChildImportEntitiesSetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,77,106,195,48,16,70,215,49,248,14,194,171,22,138,116,128,186,222,4,183,120,23,112,47,160,56,227,116,64,63,70,26,149,152,146,187,87,178,107,53,13,221,73,51,111,222,55,140,145,26,252,36,7,96,239,224,156,244,118,36,190,183,102,196,115,112,146,208,26,254,138,10,58,61,89,71,101,241,85,22,187,224,209,156,89,63,123,2,29,81,165,96,72,156,231,111,96,192,225,240,156,153,91,163,3,222,26,66,66,240,17,136,200,20,142,10,7,134,134,192,141,41,191,219,127,160,58,173,73,27,218,3,197,118,164,83,240,78,8,193,106,31,180,150,110,110,182,66,15,228,25,92,208,83,138,132,159,65,70,150,225,162,202,37,158,21,226,222,81,79,210,73,205,76,188,197,75,181,188,33,198,250,170,89,183,97,191,37,94,139,229,243,255,232,22,85,53,237,253,66,127,6,63,45,158,210,226,15,171,255,144,245,55,73,79,172,107,77,208,224,228,81,65,189,28,100,110,178,238,49,93,249,90,22,215,111,238,14,23,19,192,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06530102-5f59-41f5-9ac8-4a7901f07ee8"));
		}

		#endregion

	}

	#endregion

}

