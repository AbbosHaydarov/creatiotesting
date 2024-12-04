namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESContactManagerSchema

	/// <exclude/>
	public class IESContactManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESContactManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESContactManagerSchema(IESContactManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d67308e4-6320-4c6b-bc57-690f1d4497fe");
			Name = "IESContactManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,219,78,195,48,12,125,102,18,255,96,141,23,144,80,203,51,116,149,208,52,208,36,6,136,237,7,66,230,118,17,109,50,236,100,104,66,252,59,78,211,141,187,120,105,149,19,159,139,29,91,213,34,175,149,70,88,32,145,98,87,249,108,236,108,101,234,64,202,27,103,179,201,252,246,112,240,122,56,56,8,108,108,13,243,45,123,108,165,166,105,80,199,2,206,174,209,34,25,125,241,189,102,177,34,84,75,1,178,133,226,39,150,123,169,56,34,172,133,5,83,235,145,42,49,62,135,233,100,62,105,149,105,102,202,170,26,73,138,242,60,135,130,67,219,42,218,150,253,249,158,220,198,44,145,161,69,191,114,75,134,202,17,104,103,189,210,158,129,81,145,94,69,175,29,61,255,196,95,135,199,198,104,48,59,207,104,57,78,212,15,83,233,81,190,251,128,179,100,115,14,247,29,57,93,126,15,214,1,243,206,123,159,37,38,248,25,33,33,107,69,170,5,43,67,31,13,9,159,3,178,31,150,55,134,61,184,170,239,1,216,147,244,193,89,145,119,213,127,144,221,203,216,5,43,236,238,23,233,2,177,180,8,132,62,144,133,141,106,2,254,43,194,119,85,197,40,50,15,145,237,186,3,136,72,29,223,84,53,34,198,107,121,227,95,132,146,13,239,211,23,140,8,154,176,26,13,251,209,94,57,154,161,141,59,50,204,75,17,216,49,162,68,220,136,98,58,177,161,21,155,199,6,139,31,156,178,236,7,219,223,240,37,111,173,62,142,118,69,26,81,41,233,186,17,158,74,98,31,251,79,179,24,193,217,30,233,251,139,216,73,90,192,131,35,180,203,244,198,221,249,45,173,229,23,240,237,29,24,73,253,245,23,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d67308e4-6320-4c6b-bc57-690f1d4497fe"));
		}

		#endregion

	}

	#endregion

}

