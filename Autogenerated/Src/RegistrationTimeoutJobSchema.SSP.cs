namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RegistrationTimeoutJobSchema

	/// <exclude/>
	public class RegistrationTimeoutJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RegistrationTimeoutJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RegistrationTimeoutJobSchema(RegistrationTimeoutJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("51199334-03d1-4755-a35a-4e27cf9831ed");
			Name = "RegistrationTimeoutJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,193,110,219,48,12,61,187,64,255,129,240,46,54,80,200,247,174,233,97,73,91,164,104,129,98,235,176,179,98,51,169,54,91,50,40,41,109,80,228,223,71,89,78,102,123,77,47,182,41,82,207,143,239,61,45,27,180,173,44,17,158,145,72,90,179,118,98,110,244,90,109,60,73,167,140,62,63,123,63,63,75,188,85,122,3,63,118,214,97,243,117,82,243,124,93,99,25,134,173,184,67,141,164,202,127,51,67,88,194,83,231,98,241,141,91,220,252,66,184,97,32,152,215,210,218,75,248,206,149,117,145,201,179,106,208,120,119,111,86,208,141,22,69,1,87,214,55,141,164,221,117,95,47,176,70,135,22,240,173,85,132,21,208,224,62,24,130,150,81,95,13,133,70,105,182,72,59,168,149,254,99,197,1,174,24,224,181,126,85,171,18,202,192,228,20,145,75,88,242,235,230,13,75,239,12,241,37,22,139,159,199,53,30,209,189,152,138,23,121,34,181,149,14,99,183,141,5,108,141,170,122,202,55,145,240,67,96,147,253,180,72,108,130,142,162,130,31,149,57,4,67,146,100,193,8,129,9,148,158,8,181,59,214,179,201,5,49,143,3,1,149,253,113,243,241,124,150,7,83,146,100,43,9,170,142,11,204,186,131,68,227,107,207,46,155,80,136,125,113,75,166,201,82,78,193,80,29,198,149,233,97,226,215,11,18,102,105,88,43,110,24,254,154,230,98,105,31,208,218,140,147,227,27,45,158,36,113,12,29,82,54,217,37,239,185,69,94,34,234,124,96,188,239,165,70,93,69,181,79,73,223,249,24,155,157,201,74,51,43,229,42,195,230,18,174,103,233,208,195,227,79,198,38,92,192,114,161,186,47,78,199,59,239,202,25,190,0,179,250,205,237,125,158,22,33,48,135,196,116,182,126,12,51,177,102,132,122,53,70,189,230,176,246,178,216,163,231,255,103,101,226,204,39,202,196,211,241,225,254,47,111,137,72,215,0,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51199334-03d1-4755-a35a-4e27cf9831ed"));
		}

		#endregion

	}

	#endregion

}

