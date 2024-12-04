namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApprovalConstantsSchema

	/// <exclude/>
	public class ApprovalConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApprovalConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApprovalConstantsSchema(ApprovalConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96d50106-6c2d-4bb1-9f14-582f073e5e34");
			Name = "ApprovalConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,147,65,79,131,48,24,134,207,35,217,127,104,220,69,15,221,86,90,232,234,212,100,217,193,171,81,19,207,95,203,199,130,97,64,104,209,44,102,255,221,142,201,4,221,193,68,46,192,155,231,123,191,7,2,5,108,209,86,96,144,60,99,93,131,45,83,55,93,151,69,154,109,154,26,92,86,22,227,224,99,28,16,127,52,54,43,54,228,105,103,29,110,151,227,224,24,78,106,220,120,136,172,115,176,246,154,172,170,170,46,223,32,247,13,214,65,225,108,199,205,102,51,114,99,155,237,22,234,221,221,119,212,241,164,55,112,194,103,67,190,106,116,158,25,226,49,231,79,230,176,240,220,190,3,234,141,143,23,125,197,135,186,172,176,118,25,122,207,135,182,171,79,157,17,236,226,23,200,92,251,232,126,115,99,167,63,102,126,88,254,54,189,111,178,228,212,113,123,71,10,124,111,179,203,11,46,226,48,82,34,161,82,130,164,66,207,129,46,164,0,26,39,11,29,9,29,42,174,205,197,213,242,143,154,43,99,176,114,152,252,203,243,84,50,16,69,169,82,48,154,83,110,120,72,5,71,73,33,82,72,89,168,129,133,17,198,140,135,127,23,125,196,87,52,255,21,125,236,74,6,162,160,56,232,185,86,212,0,143,253,27,85,17,85,58,228,20,231,12,128,197,202,112,190,248,18,29,157,177,60,101,107,255,67,228,125,195,111,186,167,215,134,103,220,214,80,28,199,7,110,138,133,243,52,193,148,198,74,35,21,44,94,80,29,165,156,70,76,74,38,180,4,129,170,115,27,77,176,72,142,223,173,191,219,183,89,63,26,7,251,79,47,131,74,15,185,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96d50106-6c2d-4bb1-9f14-582f073e5e34"));
		}

		#endregion

	}

	#endregion

}

