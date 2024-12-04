namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCConstantsSchema

	/// <exclude/>
	public class DCConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCConstantsSchema(DCConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b71266ae-26dd-4d4b-bb2e-0ecca246e43c");
			Name = "DCConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,145,221,110,130,64,16,133,175,53,241,29,38,122,211,94,32,218,98,109,236,79,34,160,77,239,76,234,11,140,48,232,38,176,144,157,161,134,52,190,123,119,193,54,213,222,176,153,51,195,57,223,236,106,44,136,43,76,8,182,100,12,114,153,201,56,42,117,166,246,181,65,81,165,30,199,141,198,66,37,86,20,210,50,232,127,13,250,189,154,149,222,195,71,195,66,197,211,160,111,149,145,161,189,157,134,40,71,230,5,196,145,157,103,65,45,220,182,125,223,135,103,174,139,2,77,243,122,174,157,35,42,205,144,156,71,225,19,243,154,24,178,210,64,218,165,186,158,139,133,204,148,133,43,28,88,203,5,169,74,220,137,70,17,143,127,34,252,63,25,85,189,203,173,131,181,22,103,228,192,46,185,122,118,21,251,253,101,223,152,178,34,35,214,111,1,155,246,231,174,239,95,193,183,66,28,45,69,140,218,213,66,144,169,92,200,128,52,21,129,74,225,120,80,201,1,82,226,196,246,237,62,76,104,156,128,130,150,198,184,171,67,238,150,117,224,255,201,175,208,13,97,90,234,188,129,183,218,186,255,9,94,183,185,91,27,251,158,194,11,104,58,182,35,55,195,120,181,92,133,113,48,243,86,209,116,237,5,235,89,232,133,147,48,242,86,243,135,96,62,153,77,31,239,238,131,225,109,247,114,189,17,233,180,187,129,182,62,117,239,121,33,158,190,1,240,98,81,111,39,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b71266ae-26dd-4d4b-bb2e-0ecca246e43c"));
		}

		#endregion

	}

	#endregion

}

