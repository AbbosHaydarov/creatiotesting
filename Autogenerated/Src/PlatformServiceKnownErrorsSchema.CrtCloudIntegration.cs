namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PlatformServiceKnownErrorsSchema

	/// <exclude/>
	public class PlatformServiceKnownErrorsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PlatformServiceKnownErrorsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PlatformServiceKnownErrorsSchema(PlatformServiceKnownErrorsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21cce7d0-88dc-4544-823a-a5510c009480");
			Name = "PlatformServiceKnownErrors";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,85,77,111,19,49,16,61,55,82,254,195,40,28,184,37,247,210,86,138,210,10,34,16,138,72,203,181,154,216,147,196,170,99,47,246,56,33,173,250,223,25,123,119,149,166,80,132,10,5,114,217,149,189,158,55,239,67,227,117,184,162,88,161,34,24,5,30,89,159,244,216,49,45,2,178,241,174,127,197,198,26,54,20,251,23,33,248,16,187,157,187,110,231,104,48,24,192,73,76,171,21,134,237,89,179,30,206,34,7,84,12,202,98,140,48,247,1,120,73,112,227,252,198,1,149,226,126,91,58,120,84,123,18,137,208,70,15,42,208,252,180,247,43,68,250,227,242,238,193,32,131,84,105,102,141,2,220,231,240,62,247,46,199,224,24,234,243,112,7,247,221,206,19,18,206,41,170,96,102,4,216,48,134,205,146,92,94,161,6,84,202,39,199,176,193,8,206,51,44,136,255,172,160,29,219,125,81,181,150,145,79,86,127,244,252,150,120,168,135,53,151,86,218,174,82,170,36,31,121,30,189,10,180,144,54,48,9,190,162,144,251,28,195,164,0,214,223,31,235,47,27,2,30,75,106,186,56,81,101,162,96,189,66,107,110,113,102,9,196,94,227,22,89,246,247,186,91,190,245,153,198,204,2,241,65,221,194,233,25,244,158,212,112,253,224,112,239,77,35,128,156,174,53,148,245,179,82,251,127,34,123,32,246,48,243,122,225,180,178,136,202,34,203,181,177,130,72,97,109,20,69,8,196,41,184,8,201,209,215,138,20,147,150,173,88,121,23,229,163,148,38,135,107,52,54,75,253,139,185,78,26,158,211,134,230,213,142,197,1,13,227,79,84,188,84,192,50,127,156,217,96,226,37,176,191,145,237,185,180,36,253,15,134,114,40,28,200,177,81,200,116,233,91,51,14,237,70,157,110,227,180,54,245,122,172,179,28,222,230,60,41,140,221,90,90,232,207,104,211,239,197,41,131,79,98,91,157,150,246,20,221,107,134,37,174,73,38,241,75,50,65,70,50,42,49,228,199,23,235,158,245,53,212,101,70,58,23,32,9,225,157,224,124,106,96,166,5,101,207,251,246,103,125,255,13,250,104,57,84,164,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21cce7d0-88dc-4544-823a-a5510c009480"));
		}

		#endregion

	}

	#endregion

}

