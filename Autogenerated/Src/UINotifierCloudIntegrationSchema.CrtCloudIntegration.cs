namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UINotifierCloudIntegrationSchema

	/// <exclude/>
	public class UINotifierCloudIntegrationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UINotifierCloudIntegrationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UINotifierCloudIntegrationSchema(UINotifierCloudIntegrationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e5e79c3a-7d9a-42b3-9e61-5839136f3c4b");
			Name = "UINotifierCloudIntegration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,193,106,195,48,12,61,55,208,127,16,217,165,133,145,220,187,182,176,166,12,114,41,99,91,79,99,7,47,81,50,131,99,27,73,25,148,209,127,159,147,180,93,9,163,24,140,159,121,122,122,122,178,170,65,246,170,64,200,72,50,227,218,50,183,130,53,41,209,206,38,123,209,70,139,70,158,70,63,211,104,210,178,182,53,188,33,145,98,87,73,146,57,194,228,73,21,226,40,112,30,166,81,119,38,119,132,117,40,134,204,40,230,5,236,243,157,19,93,105,164,173,174,181,40,243,88,114,207,75,211,20,150,220,54,141,162,195,250,132,95,208,19,50,90,97,144,47,4,221,120,131,77,128,189,29,112,85,80,3,123,146,75,206,26,233,72,100,201,136,202,176,131,130,176,90,197,55,7,75,242,63,127,49,164,157,196,251,22,43,213,26,217,104,91,134,121,103,114,240,232,170,217,21,113,126,15,187,144,27,172,32,30,43,199,243,143,32,225,219,79,163,11,40,186,4,174,2,24,147,175,195,217,40,198,80,25,98,14,247,37,195,103,114,30,169,51,186,232,222,130,133,96,57,80,252,25,130,251,14,27,209,37,2,11,117,11,122,69,91,34,13,14,215,255,88,236,23,21,122,4,218,208,166,199,199,97,121,151,207,40,58,70,191,172,229,47,130,30,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5e79c3a-7d9a-42b3-9e61-5839136f3c4b"));
		}

		#endregion

	}

	#endregion

}

