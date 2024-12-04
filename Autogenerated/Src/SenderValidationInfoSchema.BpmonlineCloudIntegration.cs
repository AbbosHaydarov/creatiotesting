namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderValidationInfoSchema

	/// <exclude/>
	public class SenderValidationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderValidationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderValidationInfoSchema(SenderValidationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6ab86a0-e08a-4fdf-9955-a869f72bbafb");
			Name = "SenderValidationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,77,107,195,48,12,61,39,144,255,32,232,61,185,175,165,151,82,202,96,27,101,41,219,57,75,148,204,224,216,193,114,58,74,217,127,159,236,100,89,215,239,246,18,99,89,122,122,79,122,68,101,53,82,147,229,8,43,52,38,35,93,218,120,166,85,41,170,214,100,86,104,21,207,230,233,179,46,80,82,20,110,163,48,104,73,168,10,210,13,89,172,57,83,74,204,93,26,197,11,84,104,68,62,142,66,206,26,25,172,56,10,51,153,17,61,64,138,170,64,243,150,73,81,120,208,71,85,106,159,151,36,9,76,168,173,235,204,108,166,253,253,21,27,131,132,202,18,240,217,48,54,66,169,13,144,7,129,245,128,18,255,2,36,59,8,77,251,33,69,14,185,107,124,162,111,192,58,248,59,144,92,26,221,160,177,2,153,233,210,151,119,239,251,228,124,96,129,204,203,179,225,211,126,34,124,25,205,3,193,58,19,146,64,10,178,142,214,33,175,46,194,228,91,28,174,171,11,229,127,217,189,170,39,126,159,144,53,188,130,41,188,187,202,185,47,116,113,216,66,133,118,236,136,141,225,251,22,5,253,68,177,184,95,197,37,136,243,74,250,5,97,113,94,205,136,183,217,173,204,223,187,232,110,48,56,116,30,239,118,45,216,3,157,19,60,254,53,198,235,189,214,139,233,220,231,156,206,2,231,233,242,178,241,142,182,189,198,119,65,112,253,222,164,155,147,46,255,147,61,177,183,99,99,223,33,71,251,243,190,133,7,79,4,20,255,71,206,183,238,186,14,147,121,225,130,187,150,28,133,28,251,1,165,115,188,72,183,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6ab86a0-e08a-4fdf-9955-a869f72bbafb"));
		}

		#endregion

	}

	#endregion

}

