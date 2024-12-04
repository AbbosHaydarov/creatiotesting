namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebAnalyticsAccountRepositotySchema

	/// <exclude/>
	public class IWebAnalyticsAccountRepositotySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebAnalyticsAccountRepositotySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebAnalyticsAccountRepositotySchema(IWebAnalyticsAccountRepositotySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edfdab45-5f9d-4dac-9acd-05db76cc58b0");
			Name = "IWebAnalyticsAccountRepositoty";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("04eed549-e1cf-4e3c-9d22-ce076df2f40c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,111,107,194,48,16,198,95,43,248,29,130,190,217,96,180,239,167,19,68,68,132,13,198,116,236,117,154,94,53,208,94,186,220,197,81,198,190,251,210,212,118,157,19,97,80,10,185,63,191,123,158,75,80,22,64,165,84,32,118,96,173,36,147,113,180,52,152,233,189,179,146,181,193,209,240,115,52,28,56,210,184,23,219,138,24,10,159,207,115,80,117,146,162,53,32,88,173,166,93,77,31,99,33,90,33,107,214,64,190,192,151,196,113,44,102,228,138,66,218,106,126,58,191,64,105,129,0,89,240,1,132,70,6,155,213,122,50,99,67,132,228,177,230,126,64,34,36,202,188,98,173,72,72,165,140,67,166,168,133,198,61,106,233,146,92,171,30,106,243,6,201,162,237,93,52,173,126,172,33,205,134,43,223,225,45,250,255,96,98,97,239,93,137,39,224,131,73,233,94,60,7,82,147,60,215,126,18,207,142,145,132,234,86,34,76,22,100,59,212,239,14,124,2,209,39,32,189,98,224,175,131,65,88,91,245,179,104,177,6,94,182,168,147,3,186,185,157,94,145,182,149,71,160,32,229,95,147,227,58,82,74,43,11,129,254,109,60,140,219,250,71,77,60,158,239,122,60,175,176,207,155,197,161,237,50,165,204,37,251,27,45,94,9,236,38,109,56,109,44,114,62,40,116,218,7,28,141,78,131,133,206,236,102,133,174,0,43,147,28,102,151,46,116,222,41,169,149,222,9,98,91,191,155,223,131,219,141,77,0,211,230,178,195,249,107,52,244,223,55,200,240,139,185,12,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edfdab45-5f9d-4dac-9acd-05db76cc58b0"));
		}

		#endregion

	}

	#endregion

}

