namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingAudienceDataSourceFactorySchema

	/// <exclude/>
	public class IMailingAudienceDataSourceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingAudienceDataSourceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingAudienceDataSourceFactorySchema(IMailingAudienceDataSourceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719");
			Name = "IMailingAudienceDataSourceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("137c1838-0170-451f-b0dc-9c1d36ce6de8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,84,75,111,212,64,12,62,183,82,255,131,149,30,104,165,42,17,226,80,169,108,35,161,229,161,28,10,149,210,138,3,226,48,59,227,100,71,74,102,194,140,167,101,65,253,239,56,143,13,187,93,22,182,8,232,133,75,20,143,237,207,246,231,135,17,53,250,70,72,132,43,116,78,120,91,80,60,181,166,208,101,112,130,180,53,7,251,95,15,246,247,130,215,166,132,124,225,9,235,231,163,60,181,14,89,98,249,208,97,201,198,144,25,66,87,48,220,25,100,23,66,87,108,245,34,40,141,70,226,75,65,34,183,193,73,124,45,36,89,183,232,28,147,36,129,137,15,117,45,220,34,29,228,75,103,111,180,66,15,53,210,220,42,32,11,210,161,32,4,109,60,9,198,242,96,11,118,67,108,21,197,121,180,61,86,148,164,241,50,76,178,18,231,195,187,153,183,21,18,30,69,239,117,85,193,12,193,97,109,111,80,129,40,184,6,56,141,159,158,198,207,162,227,143,108,220,132,89,165,37,71,31,138,251,117,109,192,94,204,27,127,71,106,46,186,98,252,25,92,118,104,189,242,126,249,235,245,127,15,184,193,132,193,219,145,141,135,146,177,201,70,255,210,8,39,106,48,60,17,231,81,240,232,120,14,12,202,118,8,162,244,154,229,39,30,228,248,20,79,146,206,254,199,238,60,84,94,148,152,169,40,189,154,35,4,163,63,5,110,159,66,67,186,208,76,47,167,76,172,168,251,84,127,14,54,19,36,231,185,254,130,61,152,231,191,214,191,225,0,45,35,76,136,218,4,112,72,193,25,159,190,253,93,162,38,201,18,162,197,220,110,11,211,174,35,217,16,227,232,122,141,57,88,39,242,4,222,4,173,96,164,231,164,237,49,140,5,30,247,219,180,119,136,70,245,99,211,201,119,253,142,173,63,238,176,114,57,135,97,19,84,143,183,123,48,224,190,250,76,156,190,239,154,190,147,243,144,40,99,192,173,166,121,231,232,251,122,50,5,62,52,141,117,244,15,86,123,59,135,176,211,141,251,127,6,118,56,3,228,116,89,178,56,156,131,101,163,255,194,89,88,5,24,199,169,7,184,23,124,37,205,199,191,46,249,114,10,255,200,153,25,212,99,253,15,56,59,119,223,0,17,168,94,105,49,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719"));
		}

		#endregion

	}

	#endregion

}

