namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWorkplaceNavigationPanelProviderSchema

	/// <exclude/>
	public class IWorkplaceNavigationPanelProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWorkplaceNavigationPanelProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWorkplaceNavigationPanelProviderSchema(IWorkplaceNavigationPanelProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8254b1c8-62eb-4388-85ee-c89cb0aa6a53");
			Name = "IWorkplaceNavigationPanelProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b5fa047-b3f1-455e-b921-26461fc6607e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,65,75,3,49,16,133,207,93,216,255,16,232,69,47,155,187,46,123,17,41,5,91,22,20,60,167,201,108,26,204,78,194,36,169,20,241,191,187,201,214,173,10,222,242,146,247,190,188,153,20,12,106,246,124,14,17,198,230,193,89,11,50,26,135,161,217,0,2,25,121,95,87,169,88,94,128,72,4,55,196,201,133,131,209,137,68,54,54,123,113,50,186,28,119,128,105,178,215,21,231,156,181,33,141,163,160,115,55,203,87,71,111,222,10,9,76,137,40,152,39,119,50,10,136,13,142,24,46,4,230,5,130,109,46,4,126,69,248,116,176,70,50,131,17,104,200,148,237,2,220,47,233,62,135,251,11,185,174,62,114,149,213,154,64,103,242,14,226,209,169,112,199,250,130,42,111,127,122,22,253,228,132,10,236,125,162,7,159,63,210,228,146,15,255,245,156,17,63,138,206,23,4,49,17,134,46,151,252,133,145,203,130,91,254,109,154,66,219,71,76,35,144,56,88,104,175,243,228,125,110,114,174,43,173,110,110,203,114,87,107,64,53,15,149,229,231,23,194,253,169,252,193,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8254b1c8-62eb-4388-85ee-c89cb0aa6a53"));
		}

		#endregion

	}

	#endregion

}

