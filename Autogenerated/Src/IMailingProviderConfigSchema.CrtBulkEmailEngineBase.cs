namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigSchema

	/// <exclude/>
	public class IMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigSchema(IMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468");
			Name = "IMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,80,203,106,3,49,12,60,123,97,255,65,164,247,248,158,166,185,20,10,123,8,4,154,31,112,29,121,107,88,63,144,189,133,165,244,223,171,216,222,210,180,228,34,164,209,104,52,146,87,14,83,84,26,225,140,68,42,5,147,183,207,193,27,59,206,164,178,13,190,239,62,251,78,204,201,250,17,94,151,148,209,61,246,29,35,15,132,35,183,97,240,25,201,176,192,14,134,163,178,19,243,78,20,62,236,5,169,234,20,182,148,18,246,105,118,78,209,114,104,117,163,37,208,133,7,193,64,126,71,112,85,4,98,83,217,174,227,242,215,124,156,223,38,171,193,174,203,239,238,22,236,158,227,143,93,238,71,164,108,49,237,224,84,68,106,255,175,193,2,12,62,101,229,89,189,89,219,39,68,208,132,230,105,179,238,59,163,139,147,202,248,162,116,14,180,108,228,225,234,247,191,97,113,103,128,223,126,91,95,191,45,196,136,153,223,204,73,106,201,87,59,3,253,165,94,82,234,138,222,130,140,125,3,196,96,212,232,213,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468"));
		}

		#endregion

	}

	#endregion

}

