namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportInfoLoggerSchema

	/// <exclude/>
	public class IFileImportInfoLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportInfoLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportInfoLoggerSchema(IFileImportInfoLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ae8c7f3-cc95-4f57-90f0-6d91f024f280");
			Name = "IFileImportInfoLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,193,74,196,48,16,61,111,161,255,48,116,47,10,210,222,119,107,65,68,165,224,130,80,193,115,108,166,49,176,73,202,36,21,22,217,127,55,109,186,213,93,244,176,171,151,189,20,50,121,239,205,123,51,164,154,41,180,45,171,17,158,145,136,89,211,184,244,214,232,70,138,142,152,147,70,167,247,114,141,165,106,13,185,56,250,136,163,89,103,165,22,80,109,172,67,181,140,35,95,153,19,10,143,132,82,59,164,198,107,45,160,252,98,149,186,49,143,70,8,164,1,220,118,175,107,89,131,220,97,127,131,206,124,47,255,157,196,87,232,222,12,183,11,120,26,4,194,101,150,101,144,219,78,41,70,155,98,87,120,33,233,16,44,90,219,243,88,221,167,0,235,24,57,240,89,45,19,152,78,220,236,144,156,183,140,152,2,237,199,114,157,200,193,85,21,148,74,158,20,16,124,78,226,146,167,121,54,48,126,22,24,251,37,133,79,53,53,255,206,120,55,146,7,195,99,151,155,193,110,213,187,93,5,252,197,67,231,49,7,86,174,124,32,234,247,48,138,94,46,143,29,200,185,140,226,159,167,112,90,250,35,204,239,187,254,235,150,80,243,179,217,212,157,230,167,44,107,238,51,134,55,62,156,183,225,151,178,87,220,126,2,6,13,38,123,166,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ae8c7f3-cc95-4f57-90f0-6d91f024f280"));
		}

		#endregion

	}

	#endregion

}

