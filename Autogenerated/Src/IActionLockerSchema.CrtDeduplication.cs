namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IActionLockerSchema

	/// <exclude/>
	public class IActionLockerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IActionLockerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IActionLockerSchema(IActionLockerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb40de33-e3f6-43df-ac5e-ea49b9ed783e");
			Name = "IActionLocker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5c46c08-cc76-4157-b24b-44267444e258");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,106,195,48,12,61,175,208,127,16,217,101,131,82,223,215,46,80,178,49,10,99,151,236,7,92,71,105,77,19,59,88,118,89,25,251,247,217,78,186,38,180,180,133,93,18,75,122,210,147,158,108,71,82,173,33,223,147,197,122,54,30,141,71,138,215,72,13,23,8,159,104,12,39,93,218,105,166,85,41,215,206,112,43,181,130,239,0,187,187,55,184,14,214,82,89,52,165,199,63,193,114,33,2,224,93,139,45,154,8,98,140,193,156,92,93,115,179,79,59,219,23,179,70,87,4,92,8,36,2,171,1,191,80,184,88,91,151,160,27,108,137,104,122,168,192,122,37,26,183,170,164,0,121,160,29,178,118,205,157,16,71,71,128,48,167,42,255,187,68,121,202,217,122,26,110,120,13,65,159,231,68,104,181,67,67,49,105,89,36,105,214,179,65,22,211,57,139,232,243,201,36,54,88,243,15,127,78,210,60,158,99,224,114,210,95,143,129,238,5,11,215,120,25,184,61,246,126,149,86,82,16,32,73,195,23,200,114,59,100,220,105,89,64,142,54,132,243,16,125,120,115,222,51,156,116,226,19,77,184,49,199,25,38,16,113,189,254,38,176,210,186,130,150,239,113,118,97,35,217,6,197,214,223,132,149,172,164,221,119,75,193,193,74,110,221,136,254,183,62,55,175,197,160,117,70,81,186,184,122,129,231,236,128,13,201,81,149,140,171,215,118,204,86,223,94,223,103,196,237,212,251,105,159,28,170,162,125,117,193,244,190,95,182,133,10,200,189,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb40de33-e3f6-43df-ac5e-ea49b9ed783e"));
		}

		#endregion

	}

	#endregion

}

