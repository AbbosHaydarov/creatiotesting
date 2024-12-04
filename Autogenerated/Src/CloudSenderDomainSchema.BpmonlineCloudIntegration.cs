namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainSchema

	/// <exclude/>
	public class CloudSenderDomainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainSchema(CloudSenderDomainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942");
			Name = "CloudSenderDomain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,148,205,78,195,48,12,199,207,155,180,119,176,180,123,123,103,192,101,131,105,66,131,137,238,5,178,198,45,17,77,82,229,3,168,166,189,59,110,218,77,101,32,232,54,46,141,226,216,254,255,220,196,86,76,162,45,89,138,176,70,99,152,213,153,139,166,90,101,34,247,134,57,161,85,52,189,75,150,154,99,97,71,195,237,104,56,240,86,168,28,146,202,58,148,147,209,144,44,99,131,57,57,194,180,96,214,94,209,162,61,79,80,113,52,51,45,153,80,193,41,142,99,184,182,94,74,102,170,219,118,255,140,165,65,139,202,89,16,42,211,70,6,65,96,27,237,29,240,16,11,100,6,114,225,181,168,123,65,64,178,22,54,218,103,140,59,41,75,191,41,68,10,105,141,241,19,197,128,240,233,123,224,93,25,93,162,113,2,9,122,21,98,155,243,99,212,96,152,35,81,6,22,90,107,144,150,143,113,78,53,4,160,239,68,123,36,235,76,205,223,128,192,22,114,116,147,58,211,4,118,167,72,190,161,17,153,72,155,191,68,183,165,77,47,217,187,218,243,159,84,95,177,234,165,249,128,213,249,138,203,143,222,58,228,122,182,76,178,186,239,173,147,148,217,69,37,89,199,156,39,83,214,121,59,253,132,155,192,179,133,5,167,254,162,251,195,63,222,202,220,11,14,11,126,65,133,161,215,218,210,190,54,180,224,39,48,116,123,214,46,40,203,37,80,82,243,90,151,3,205,177,95,165,103,204,225,90,72,122,123,109,196,211,81,159,194,205,193,39,122,212,239,205,228,27,140,9,182,153,38,97,223,176,117,141,187,79,126,41,6,235,96,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942"));
		}

		#endregion

	}

	#endregion

}

