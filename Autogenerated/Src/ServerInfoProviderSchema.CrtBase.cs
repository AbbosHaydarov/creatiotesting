namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServerInfoProviderSchema

	/// <exclude/>
	public class ServerInfoProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServerInfoProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServerInfoProviderSchema(ServerInfoProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2935beff-9218-4465-a00f-9cf4abce22f6");
			Name = "ServerInfoProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,193,78,227,48,16,61,167,82,255,97,128,11,92,146,123,161,28,128,69,138,4,162,82,119,1,105,181,66,38,25,119,45,57,118,52,30,23,34,224,223,177,147,180,4,8,98,247,16,43,227,25,191,121,239,205,0,24,81,161,171,69,129,240,19,137,132,179,146,211,83,107,164,90,121,18,172,172,153,78,158,166,147,196,59,101,86,176,108,28,99,117,184,141,135,79,8,211,115,81,176,37,133,46,86,64,248,246,8,87,1,2,114,195,72,50,52,153,65,190,68,90,35,229,70,218,5,217,181,42,145,166,147,80,154,101,25,28,57,95,85,130,154,227,62,238,11,28,120,86,90,113,3,21,242,95,91,58,96,11,43,100,112,45,20,168,128,149,110,32,178,1,70,237,239,181,42,66,190,239,62,222,60,9,250,194,185,37,27,50,53,18,7,25,48,131,69,11,209,21,220,91,171,33,119,23,202,248,71,120,138,12,14,225,229,93,234,70,153,210,62,184,15,201,61,52,101,135,221,198,221,237,240,178,245,106,232,215,169,22,206,205,224,63,172,202,171,90,99,133,134,219,153,129,149,161,2,17,10,66,57,223,29,145,189,155,29,143,90,246,251,12,165,240,154,79,130,146,48,225,125,110,106,180,114,127,4,225,224,224,207,155,197,69,36,60,194,55,56,248,79,158,159,43,212,101,80,188,32,181,22,140,93,178,238,2,112,81,84,1,132,162,180,70,55,176,208,130,165,165,42,63,131,187,194,19,5,213,155,43,152,195,15,179,86,100,77,244,34,189,90,94,35,185,208,32,221,20,196,205,76,70,134,50,50,253,183,225,119,47,122,169,239,183,32,38,146,184,139,221,95,66,200,158,204,8,175,249,128,118,250,203,168,71,120,126,254,174,236,82,20,87,203,219,150,114,220,154,246,248,204,100,187,116,95,112,217,233,201,126,198,249,118,49,167,147,151,87,63,210,2,202,34,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2935beff-9218-4465-a00f-9cf4abce22f6"));
		}

		#endregion

	}

	#endregion

}

