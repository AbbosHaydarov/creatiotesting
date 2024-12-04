namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StopEmailRequestSchema

	/// <exclude/>
	public class StopEmailRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StopEmailRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StopEmailRequestSchema(StopEmailRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3d11e55e-cb8c-465a-9cb7-dfaf13400a61");
			Name = "StopEmailRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,146,79,107,194,64,16,197,207,21,252,14,67,122,105,47,201,221,63,133,214,138,244,96,17,227,173,148,50,102,39,233,194,110,54,221,217,21,172,248,221,187,217,168,69,133,246,146,240,38,239,13,111,126,4,106,212,196,13,22,4,43,178,22,217,148,46,157,152,186,148,149,183,232,164,169,211,201,52,159,27,65,138,251,189,93,191,119,227,89,214,21,228,91,118,164,135,23,58,93,250,218,73,77,105,78,86,162,146,223,113,67,112,5,223,173,165,42,8,152,40,100,30,192,163,16,43,210,141,66,71,75,250,242,196,46,186,178,44,131,17,123,173,209,110,31,14,58,38,160,52,22,108,231,4,103,128,157,105,128,52,74,149,30,99,217,69,110,196,68,168,216,64,97,169,28,39,255,222,151,62,33,83,104,190,145,197,177,83,2,89,187,237,237,25,29,134,148,179,88,184,247,48,104,252,90,201,2,138,216,44,15,85,166,109,147,67,8,6,112,189,41,132,2,189,240,60,129,88,88,211,144,117,146,2,141,69,220,215,125,191,68,16,7,51,114,12,129,0,183,111,247,73,221,233,32,5,5,224,165,36,219,82,184,198,208,77,54,168,60,157,228,234,239,244,175,57,94,61,39,189,38,123,247,26,126,19,24,67,18,131,31,82,36,247,45,134,35,135,153,151,2,34,130,23,1,59,168,200,13,219,166,67,216,31,78,166,90,116,87,71,221,77,207,135,251,31,25,232,86,234,138,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d11e55e-cb8c-465a-9cb7-dfaf13400a61"));
		}

		#endregion

	}

	#endregion

}

