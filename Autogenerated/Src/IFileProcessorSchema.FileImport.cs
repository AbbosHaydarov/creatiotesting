namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileProcessorSchema

	/// <exclude/>
	public class IFileProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileProcessorSchema(IFileProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e8d1b4d-9296-459a-b005-ca3460aef8ac");
			Name = "IFileProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,193,74,195,64,16,61,183,208,127,24,218,75,5,73,238,109,13,136,160,230,32,22,171,120,222,36,147,100,164,217,141,187,147,74,17,255,221,217,109,82,169,34,232,101,225,189,121,243,118,230,237,106,213,160,107,85,142,240,136,214,42,103,74,142,174,140,46,169,234,172,98,50,58,186,166,45,166,77,107,44,79,198,239,147,241,168,115,164,43,216,236,29,99,179,60,226,175,238,103,204,162,91,230,54,186,204,28,91,149,123,19,39,66,145,206,44,86,130,32,213,140,182,148,75,23,144,122,251,181,53,57,58,103,108,80,181,93,182,165,28,104,16,253,208,140,100,12,57,143,118,119,200,181,41,220,2,214,161,243,80,140,227,24,86,174,107,26,101,247,201,64,244,38,232,160,162,29,106,40,197,56,58,170,227,239,242,85,171,172,106,64,75,70,23,83,175,157,38,126,148,104,21,135,66,208,237,12,21,131,175,47,206,253,238,107,35,233,20,30,134,43,206,150,255,152,201,100,47,152,243,57,228,18,27,21,104,125,186,196,30,178,34,237,160,80,172,192,148,128,154,137,247,224,242,26,27,53,152,189,17,215,208,105,122,237,16,164,89,36,37,161,237,23,177,88,246,187,88,99,120,19,26,159,210,98,26,39,127,205,224,180,47,121,16,216,15,0,66,252,154,203,125,88,105,126,211,9,117,98,49,4,51,67,93,28,30,51,224,143,195,111,57,33,133,251,4,178,104,181,4,172,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e8d1b4d-9296-459a-b005-ca3460aef8ac"));
		}

		#endregion

	}

	#endregion

}

