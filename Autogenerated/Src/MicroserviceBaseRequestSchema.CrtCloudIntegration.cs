namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MicroserviceBaseRequestSchema

	/// <exclude/>
	public class MicroserviceBaseRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MicroserviceBaseRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MicroserviceBaseRequestSchema(MicroserviceBaseRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e403b733-11e3-45d0-a676-d6106e2dd742");
			Name = "MicroserviceBaseRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,75,75,3,49,16,128,207,45,244,63,12,237,197,94,118,239,86,5,173,32,61,84,74,43,120,16,15,233,238,236,26,204,38,235,204,44,165,22,255,187,73,182,43,197,22,124,92,134,100,30,95,62,38,86,85,200,181,202,16,166,36,83,227,154,124,102,5,75,82,162,157,77,230,46,71,195,201,18,223,26,100,225,65,127,55,232,247,26,214,182,132,213,150,5,171,100,217,88,209,21,38,43,36,173,140,126,143,115,147,65,223,247,165,105,10,23,220,84,149,162,237,213,254,190,196,154,144,209,10,131,2,106,177,32,14,88,20,249,195,11,130,106,124,244,204,44,146,160,48,110,147,116,176,244,128,246,116,171,68,77,157,21,82,153,60,251,68,221,172,141,206,32,51,138,25,110,20,227,222,218,151,188,181,143,189,17,97,25,152,11,114,53,146,104,228,115,88,196,169,182,254,93,56,38,30,130,83,93,155,78,72,231,193,174,208,72,65,235,216,171,21,155,99,181,70,58,187,247,219,133,75,24,30,0,134,227,32,219,217,178,80,88,230,245,193,3,59,40,81,38,192,33,124,252,32,86,27,37,133,163,10,172,127,232,15,62,221,220,112,124,66,102,209,65,127,107,114,135,254,59,29,133,70,142,127,184,193,53,187,236,21,197,167,152,255,189,181,47,204,170,165,204,242,147,190,143,71,109,167,204,71,104,243,246,255,227,221,103,99,225,19,40,108,233,2,0,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e403b733-11e3-45d0-a676-d6106e2dd742"));
		}

		#endregion

	}

	#endregion

}

