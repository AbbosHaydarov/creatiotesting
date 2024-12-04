namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AuthenticationResultSchema

	/// <exclude/>
	public class AuthenticationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AuthenticationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AuthenticationResultSchema(AuthenticationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16a1ffba-730d-4792-8d1d-f8f8fb57e8df");
			Name = "AuthenticationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,205,138,194,48,16,199,207,45,244,29,6,188,219,187,138,176,184,215,133,162,190,64,140,211,24,104,147,48,147,28,68,124,119,211,68,197,46,85,47,129,153,252,63,126,137,17,61,178,19,18,97,143,68,130,109,235,231,27,107,90,173,2,9,175,173,169,202,75,85,86,101,49,35,84,113,132,77,39,152,23,240,19,252,9,141,215,50,137,182,200,161,243,73,87,215,53,172,56,244,189,160,243,250,62,111,209,17,114,148,51,200,193,14,182,133,104,7,49,10,1,74,41,243,71,72,253,146,226,194,161,211,242,238,158,238,46,50,231,19,180,33,235,144,188,198,72,219,36,123,190,255,15,88,100,194,33,100,154,107,0,74,162,17,209,3,233,96,109,7,187,32,37,70,178,11,40,244,75,224,225,184,126,168,251,69,150,164,93,122,245,183,191,120,95,205,158,180,81,240,23,155,133,194,169,242,25,154,99,254,142,52,231,237,120,25,119,55,214,235,240,102,4,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16a1ffba-730d-4792-8d1d-f8f8fb57e8df"));
		}

		#endregion

	}

	#endregion

}

