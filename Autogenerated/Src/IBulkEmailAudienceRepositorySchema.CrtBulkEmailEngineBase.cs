namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkEmailAudienceRepositorySchema

	/// <exclude/>
	public class IBulkEmailAudienceRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkEmailAudienceRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkEmailAudienceRepositorySchema(IBulkEmailAudienceRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a");
			Name = "IBulkEmailAudienceRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,147,219,110,194,48,12,134,175,65,226,29,44,184,217,36,68,239,25,84,218,0,33,46,166,29,96,15,16,90,23,172,181,73,201,65,83,53,237,221,231,166,20,58,138,88,47,42,197,137,191,252,254,237,72,145,161,201,69,132,176,65,173,133,81,137,29,205,148,76,104,231,180,176,164,100,175,251,221,235,118,156,33,185,131,117,97,44,102,15,167,117,51,69,227,104,33,45,89,66,115,62,224,35,197,76,165,41,70,37,12,166,240,231,228,232,242,0,167,114,242,64,227,174,60,189,146,22,117,194,226,198,176,122,114,233,231,34,19,148,62,186,152,80,70,248,142,185,50,100,149,46,124,78,16,4,48,49,46,203,132,46,194,227,122,142,38,210,180,69,3,137,147,158,47,82,190,14,18,165,65,28,49,160,18,176,123,132,45,243,1,203,11,70,53,45,104,224,114,183,77,41,2,170,21,253,35,168,195,166,241,255,84,201,51,218,189,138,205,24,94,61,167,218,188,148,236,3,75,180,230,134,56,248,34,187,135,216,229,76,17,22,33,82,50,102,43,149,52,165,236,182,238,42,146,11,45,50,144,220,235,105,127,91,235,94,197,253,240,67,210,193,33,80,140,220,136,132,80,95,177,99,18,248,244,235,52,52,135,126,184,198,178,125,192,36,93,92,145,92,87,115,155,116,170,105,83,228,216,15,107,87,27,181,90,222,184,205,80,185,183,226,82,81,21,109,167,106,180,78,75,19,54,6,148,213,107,140,40,231,187,185,15,109,179,173,96,236,217,46,102,214,144,146,218,154,247,74,71,93,203,221,210,81,236,157,57,54,96,120,124,33,235,104,207,86,189,121,181,236,232,176,100,117,90,3,54,111,58,116,150,85,174,174,128,94,170,170,235,234,239,171,167,213,25,160,140,171,161,244,235,159,234,193,53,130,192,95,175,203,241,95,236,51,94,224,27,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a"));
		}

		#endregion

	}

	#endregion

}

