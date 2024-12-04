namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UploadAttachmentsDataExecutorSchema

	/// <exclude/>
	public class UploadAttachmentsDataExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UploadAttachmentsDataExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UploadAttachmentsDataExecutorSchema(UploadAttachmentsDataExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2e5d4ef8-77c1-49cb-9a08-7abb85fd5ce3");
			Name = "UploadAttachmentsDataExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,193,106,194,64,16,61,71,240,31,134,244,98,64,146,187,141,1,81,41,22,10,5,245,84,122,24,55,99,178,37,217,13,187,27,209,150,254,123,55,27,53,70,164,151,176,153,55,251,222,155,183,3,2,75,210,21,50,130,13,41,133,90,238,77,56,151,98,207,179,90,161,225,82,12,7,63,195,129,87,107,46,50,88,159,180,161,210,226,69,65,172,1,117,248,66,130,20,103,207,215,158,91,26,69,182,110,145,39,69,153,237,134,121,129,90,79,96,91,21,18,211,153,49,200,242,146,132,209,11,52,184,60,18,171,141,84,238,66,85,239,10,206,128,53,253,255,183,195,4,86,175,114,215,221,246,172,93,251,189,106,190,145,201,101,106,85,223,29,103,11,70,81,4,177,174,203,18,213,41,185,20,90,14,210,64,71,150,163,200,8,168,68,94,0,118,202,144,90,105,208,39,193,114,37,5,255,118,9,133,87,198,232,158,50,174,80,97,9,77,200,83,191,214,164,108,180,162,141,206,79,98,77,4,76,209,126,234,111,251,80,148,0,23,218,160,96,20,198,145,227,120,76,233,206,100,72,105,63,89,247,93,221,187,132,81,163,127,25,41,77,21,217,104,201,176,48,232,73,84,109,242,7,174,76,141,5,28,36,79,47,193,140,250,46,161,63,207,24,86,11,238,78,54,128,88,27,101,151,97,12,114,247,101,225,4,58,163,1,52,251,228,121,203,115,200,91,195,11,110,78,225,195,87,118,158,111,53,58,158,15,23,218,178,25,103,214,78,227,127,134,27,185,118,194,163,32,104,54,210,251,61,239,2,9,219,209,172,131,251,111,171,253,162,171,253,1,111,80,141,232,14,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e5d4ef8-77c1-49cb-9a08-7abb85fd5ce3"));
		}

		#endregion

	}

	#endregion

}

