namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CurrencyRateHelperSchema

	/// <exclude/>
	public class CurrencyRateHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CurrencyRateHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CurrencyRateHelperSchema(CurrencyRateHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10302f70-95a4-407b-9a13-247da73bf707");
			Name = "CurrencyRateHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,82,77,111,219,48,12,61,39,64,254,3,225,147,141,121,118,119,110,146,75,134,182,3,214,161,72,130,222,25,143,78,12,232,195,160,164,21,217,208,255,62,73,142,92,183,104,119,26,16,35,16,249,248,30,201,71,103,58,117,132,221,217,88,146,215,139,185,155,60,171,91,161,15,40,186,223,104,59,173,124,114,49,87,40,201,244,216,16,236,137,25,141,110,109,181,209,170,237,142,142,35,106,49,255,179,152,207,122,119,16,93,3,141,64,99,96,227,152,73,53,231,45,90,186,35,209,19,123,68,64,205,234,186,134,165,113,82,34,159,215,41,112,75,214,128,61,17,52,206,130,68,101,59,99,16,116,235,223,3,15,120,37,170,198,250,250,45,193,178,71,70,9,161,213,85,22,176,217,58,72,87,203,58,38,94,112,76,214,177,50,235,205,68,104,89,167,104,128,93,230,48,214,207,22,254,56,44,199,55,24,248,238,47,21,249,79,106,58,137,34,182,85,64,28,108,150,98,45,99,19,214,2,171,152,134,207,144,59,161,213,177,8,175,235,8,253,133,12,126,129,30,161,232,9,126,56,121,32,190,209,44,209,126,83,173,190,240,205,134,248,215,129,118,71,97,18,171,217,23,101,101,22,17,207,3,219,208,253,168,91,237,245,46,118,157,123,137,162,218,82,47,188,121,121,118,85,102,37,100,89,17,139,158,131,179,31,184,177,11,110,140,46,88,253,223,150,63,197,37,254,108,157,150,250,177,89,219,127,57,148,214,238,187,78,76,123,29,244,243,169,73,101,114,50,233,38,215,186,22,242,224,78,181,231,243,3,178,161,60,33,74,208,254,72,66,110,44,122,68,225,168,72,165,239,57,254,10,9,53,164,38,138,123,180,167,234,65,63,229,95,174,202,17,85,125,39,117,180,167,193,18,111,100,56,151,21,68,232,141,208,154,243,120,95,147,236,167,213,40,54,68,189,143,47,23,48,30,88,136,250,207,255,254,2,53,140,159,202,235,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10302f70-95a4-407b-9a13-247da73bf707"));
		}

		#endregion

	}

	#endregion

}

