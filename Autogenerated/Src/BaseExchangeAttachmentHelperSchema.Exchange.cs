namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseExchangeAttachmentHelperSchema

	/// <exclude/>
	public class BaseExchangeAttachmentHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseExchangeAttachmentHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseExchangeAttachmentHelperSchema(BaseExchangeAttachmentHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e525563-4bdb-4dfc-a6eb-a86a1fe5e500");
			Name = "BaseExchangeAttachmentHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,85,77,107,219,64,16,61,55,144,255,48,36,23,23,140,116,79,82,67,236,154,84,80,67,192,9,57,148,30,70,187,99,121,65,187,18,187,163,80,17,242,223,179,43,57,178,28,7,163,130,122,233,105,189,243,241,246,189,55,131,5,6,53,185,18,5,193,3,89,139,174,216,112,180,40,204,70,101,149,69,86,133,57,63,123,57,63,251,82,57,101,50,88,215,142,73,251,124,158,147,8,73,23,221,145,33,171,196,117,87,179,82,194,22,13,204,242,143,216,162,201,40,122,162,116,77,246,89,9,114,209,119,100,220,23,247,223,180,228,227,62,115,105,41,243,208,176,200,209,185,43,152,163,163,119,164,91,102,20,91,77,134,127,80,94,146,109,234,227,56,134,27,87,105,141,182,158,117,119,34,16,150,54,223,46,146,227,230,71,86,185,98,69,238,34,158,129,210,101,78,33,218,168,141,222,1,226,30,98,89,165,185,18,128,169,99,139,130,65,4,102,39,137,193,21,156,122,215,99,6,83,59,169,43,226,109,33,189,216,251,246,165,70,215,145,176,191,81,22,45,44,33,119,252,118,246,123,189,29,78,95,224,145,194,15,125,240,41,218,228,209,145,245,187,98,218,93,128,234,224,58,5,143,21,102,28,194,75,141,42,191,149,210,146,115,95,175,71,144,183,198,13,205,149,145,137,223,199,225,170,2,139,149,167,128,25,65,31,97,242,81,175,107,207,41,132,108,34,65,53,199,20,238,109,225,167,203,245,154,24,202,246,183,103,243,255,41,154,194,176,217,58,50,114,55,221,81,76,184,35,222,135,221,96,27,146,165,169,52,89,76,115,186,217,247,207,224,16,110,114,224,150,110,207,127,64,123,94,39,114,100,234,1,242,83,250,221,36,176,43,78,228,40,154,126,22,56,92,197,115,161,36,132,142,201,30,170,71,105,44,147,253,6,178,143,13,166,149,214,76,191,126,7,47,119,157,167,233,93,250,109,110,255,145,253,237,181,253,24,245,66,175,111,203,15,207,87,45,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e525563-4bdb-4dfc-a6eb-a86a1fe5e500"));
		}

		#endregion

	}

	#endregion

}

