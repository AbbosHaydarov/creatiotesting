namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailMacroInfoSchema

	/// <exclude/>
	public class BulkEmailMacroInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailMacroInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailMacroInfoSchema(BulkEmailMacroInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd908fae-7593-41a7-85f2-5a9b52456b8d");
			Name = "BulkEmailMacroInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,79,107,195,48,12,197,207,45,244,59,8,122,111,118,222,198,160,43,59,236,80,90,178,178,187,234,42,169,169,255,4,73,41,27,165,223,125,142,211,192,216,198,200,69,88,178,223,123,63,43,160,39,105,208,16,236,136,25,37,86,186,88,197,80,217,186,101,84,27,195,108,122,153,77,39,69,81,192,163,180,222,35,127,62,221,250,146,26,38,161,160,2,122,36,56,160,34,152,24,148,209,40,84,145,97,223,186,19,144,71,235,192,163,225,8,103,116,45,129,224,217,134,122,49,184,22,223,108,155,118,239,172,1,227,80,4,158,147,252,165,83,175,59,241,107,168,98,122,145,96,82,157,204,153,234,4,7,91,142,13,177,90,146,123,216,102,113,127,255,147,55,15,178,143,0,58,139,2,206,158,8,214,203,85,185,121,187,235,88,126,195,12,52,162,156,120,97,153,101,23,168,73,31,64,186,114,253,39,107,195,182,182,1,135,159,43,125,164,157,112,244,233,228,27,135,74,163,50,51,241,174,211,142,205,45,73,90,167,183,77,199,170,143,31,149,245,158,37,127,228,204,41,28,250,117,231,62,77,175,95,114,27,143,70,54,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd908fae-7593-41a7-85f2-5a9b52456b8d"));
		}

		#endregion

	}

	#endregion

}

