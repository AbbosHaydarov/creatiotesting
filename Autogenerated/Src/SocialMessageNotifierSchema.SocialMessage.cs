namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMessageNotifierSchema

	/// <exclude/>
	public class SocialMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMessageNotifierSchema(SocialMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f5268ed0-9504-4b95-a582-f1d27a5fc37c");
			Name = "SocialMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,221,106,194,48,20,199,175,43,248,14,193,221,40,72,31,192,125,192,172,195,9,115,202,116,187,207,210,211,26,104,19,73,82,70,145,190,251,78,147,216,214,41,226,110,90,114,242,59,255,243,149,83,104,46,82,178,41,181,129,252,190,223,43,58,199,48,146,89,6,204,112,41,116,56,7,1,138,179,6,217,130,82,84,203,196,32,165,32,124,17,134,27,14,26,239,251,61,65,115,208,123,202,224,132,18,9,79,11,69,107,185,126,239,80,115,193,157,130,20,143,36,202,168,214,19,178,145,140,211,108,9,90,211,20,222,165,225,9,7,101,193,125,241,157,113,70,88,205,93,198,200,132,76,169,134,51,231,192,69,106,67,97,49,70,21,204,72,53,33,107,43,235,0,31,226,162,248,208,150,87,18,176,191,17,65,205,32,8,60,180,16,137,36,143,68,192,15,233,90,28,115,132,16,112,206,216,72,179,45,247,16,99,115,139,92,124,209,172,128,7,204,8,123,250,52,28,120,122,48,26,59,239,72,1,53,16,79,203,69,124,93,97,94,240,24,253,59,252,95,141,149,184,174,48,67,104,203,115,104,85,86,162,209,88,202,184,110,196,237,137,116,29,206,84,254,145,74,235,210,168,188,82,253,108,12,101,187,28,37,80,8,167,9,254,234,56,175,15,96,82,197,221,84,215,138,231,84,149,157,40,222,101,195,118,144,211,207,46,235,76,33,218,60,243,198,113,29,240,249,107,76,140,250,81,207,184,93,12,212,180,37,143,137,45,252,56,245,224,112,67,143,220,163,106,18,192,2,111,118,170,105,82,185,88,149,207,210,203,25,108,94,91,75,180,163,34,133,90,204,66,21,238,39,126,253,74,128,136,221,86,216,179,179,158,26,171,95,67,44,209,123,31,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5268ed0-9504-4b95-a582-f1d27a5fc37c"));
		}

		#endregion

	}

	#endregion

}

