namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetEmailPageUrlRequestSchema

	/// <exclude/>
	public class GetEmailPageUrlRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetEmailPageUrlRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetEmailPageUrlRequestSchema(GetEmailPageUrlRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("839d346e-7c54-464f-bff1-3330fcbd5ee4");
			Name = "GetEmailPageUrlRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,203,78,195,48,16,69,215,141,148,127,24,117,5,155,228,3,10,44,74,11,170,4,8,245,177,66,44,38,201,36,25,213,113,138,61,22,42,85,255,29,187,164,64,169,42,209,133,45,121,94,247,220,177,179,172,43,152,173,173,80,147,76,157,22,110,40,153,145,97,84,252,129,194,173,30,196,81,28,105,108,200,174,48,39,152,147,49,104,219,82,146,219,86,151,92,57,179,171,138,163,77,28,245,210,52,133,43,235,154,6,205,250,166,123,79,233,205,145,21,40,91,3,21,137,4,61,106,144,21,20,100,185,210,100,96,49,125,72,246,221,233,175,246,151,17,10,122,25,49,152,203,171,15,172,92,166,56,135,92,161,181,112,79,50,14,115,158,177,162,133,81,157,142,175,10,36,71,40,187,192,248,80,87,214,43,10,194,199,202,95,210,143,212,100,100,46,158,188,121,184,134,254,190,111,238,219,38,69,255,50,16,237,145,172,152,96,108,116,80,2,155,224,120,0,54,92,219,176,199,19,92,67,167,150,221,82,184,32,255,9,37,147,57,131,44,115,106,185,243,118,2,107,232,231,119,249,127,51,221,41,172,64,106,20,96,93,112,142,66,22,222,107,146,218,47,174,67,181,16,132,207,224,100,251,77,114,200,153,181,173,130,201,79,246,47,101,207,159,237,39,197,77,46,29,172,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("839d346e-7c54-464f-bff1-3330fcbd5ee4"));
		}

		#endregion

	}

	#endregion

}

