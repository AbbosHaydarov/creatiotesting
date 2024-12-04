namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenRestResponseSchema

	/// <exclude/>
	public class SessionTokenRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenRestResponseSchema(SessionTokenRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff");
			Name = "SessionTokenRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,143,65,107,195,48,12,133,207,13,228,63,8,118,79,238,91,233,37,131,93,6,45,107,254,128,155,40,153,88,98,5,201,222,24,165,255,189,142,157,174,237,198,14,54,232,73,188,247,61,107,70,212,201,52,8,53,138,24,229,206,21,21,219,142,122,47,198,17,219,98,207,13,153,225,21,77,251,130,54,207,142,121,150,103,171,7,193,62,44,161,26,140,234,35,236,81,53,140,53,127,160,125,67,117,225,77,108,21,227,109,89,150,176,86,63,142,70,190,55,203,92,13,236,91,144,229,12,158,235,45,124,145,123,7,178,29,203,24,131,193,28,216,59,208,100,13,110,246,46,46,118,229,141,223,228,15,3,53,208,204,40,255,146,64,128,188,45,50,239,118,194,159,212,162,92,105,87,169,221,79,189,112,49,161,56,194,208,113,23,99,210,254,119,165,40,44,209,87,210,191,168,23,86,117,66,182,191,131,133,35,244,232,158,66,223,240,157,22,12,180,109,34,137,115,82,239,197,160,157,1,125,62,81,71,195,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff"));
		}

		#endregion

	}

	#endregion

}

