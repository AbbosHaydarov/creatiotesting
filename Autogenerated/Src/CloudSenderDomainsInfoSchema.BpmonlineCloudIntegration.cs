namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainsInfoSchema

	/// <exclude/>
	public class CloudSenderDomainsInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainsInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainsInfoSchema(CloudSenderDomainsInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6");
			Name = "CloudSenderDomainsInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,193,106,27,49,16,61,199,224,127,24,146,67,111,187,247,58,205,197,110,141,73,13,198,91,114,87,87,163,237,96,173,180,72,90,131,9,249,247,142,36,219,184,41,14,187,9,20,122,145,208,104,102,222,123,154,209,24,209,162,239,68,141,240,3,157,19,222,170,80,204,173,81,212,244,78,4,178,166,152,127,173,214,86,162,246,211,201,243,116,114,211,123,50,13,84,7,31,176,157,189,58,115,164,214,88,199,48,95,44,209,160,163,154,125,216,235,206,97,195,86,152,107,225,253,103,222,108,47,43,52,18,221,194,182,130,140,95,25,101,147,103,89,150,112,239,251,182,21,238,240,112,60,111,177,115,232,209,4,15,188,119,156,29,193,42,8,191,16,60,186,61,49,123,101,29,223,5,71,184,143,124,100,206,154,204,28,40,163,13,217,164,139,19,68,121,129,209,245,63,53,213,80,71,114,87,185,221,176,122,94,207,82,54,206,118,232,2,33,235,217,164,4,249,254,181,128,100,88,34,115,79,92,120,143,188,79,4,133,145,64,225,19,95,118,249,217,206,41,46,9,30,147,34,10,237,45,212,14,213,151,219,75,138,183,101,242,58,234,248,78,62,220,255,37,227,1,142,114,224,25,26,12,179,200,101,6,47,163,72,163,18,189,14,32,119,212,22,192,109,18,82,190,189,208,61,2,41,232,156,221,19,3,230,136,216,24,26,97,135,135,84,6,161,245,73,245,21,145,71,250,158,171,200,229,90,100,176,197,227,106,253,200,41,254,19,210,204,118,139,181,117,242,253,132,171,205,183,204,110,16,98,213,169,167,36,229,31,225,45,216,190,27,135,152,251,46,98,144,76,51,133,127,106,124,162,97,120,41,248,233,28,59,242,117,183,167,121,225,131,8,253,176,34,86,201,117,60,68,205,99,242,109,0,50,129,59,80,226,248,220,60,165,189,104,134,149,104,157,125,223,223,17,36,121,214,146,34,116,111,227,45,123,146,176,250,64,171,215,162,230,149,63,219,32,93,243,232,125,101,22,220,241,164,203,131,57,157,179,245,79,227,203,116,242,27,79,14,202,74,238,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6"));
		}

		#endregion

	}

	#endregion

}

