namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMentionRepositorySchema

	/// <exclude/>
	public class IMentionRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMentionRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMentionRepositorySchema(IMentionRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e27ff36-28e0-a0f4-308c-766147bea603");
			Name = "IMentionRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,82,193,106,194,64,16,61,43,244,31,134,120,105,161,36,119,27,3,182,136,120,16,172,230,7,214,56,209,180,201,110,58,179,161,132,226,191,119,54,107,162,149,94,22,246,237,155,247,222,206,140,86,21,114,173,50,132,20,137,20,155,220,134,111,70,231,197,177,33,101,11,163,31,198,63,15,227,81,195,133,62,194,174,101,139,85,152,158,8,213,65,128,48,85,252,201,47,195,251,85,98,89,154,189,42,119,168,40,59,133,43,109,145,114,241,112,84,33,79,8,143,162,12,3,62,133,213,98,183,70,237,252,222,27,164,246,181,41,202,3,82,199,142,162,8,98,110,170,74,81,155,92,238,23,46,16,214,134,11,107,168,133,162,23,123,118,40,33,11,5,230,155,21,228,134,224,136,214,186,128,102,255,129,153,229,14,171,188,70,216,91,68,55,30,117,179,47,139,236,170,9,171,139,227,118,48,20,150,52,70,206,225,59,107,180,39,115,224,41,108,186,106,255,120,159,190,3,150,104,161,44,216,130,201,33,21,23,182,74,75,119,32,39,83,1,150,138,173,152,179,111,222,32,114,155,207,35,182,173,177,86,164,42,208,50,197,89,144,6,73,42,144,83,245,31,245,255,84,181,27,85,28,13,244,100,80,184,173,254,114,141,15,146,152,17,33,35,204,103,193,194,39,233,38,18,68,201,16,84,180,238,116,8,109,67,154,255,41,222,202,118,25,205,120,87,223,23,56,5,183,68,177,95,149,158,29,167,73,226,186,52,231,86,103,114,121,236,159,37,164,180,173,139,250,4,223,39,36,217,91,152,66,38,102,151,229,26,77,80,31,252,68,220,93,144,179,95,186,63,240,249,23,108,130,137,47,248,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e27ff36-28e0-a0f4-308c-766147bea603"));
		}

		#endregion

	}

	#endregion

}

