namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISsoContactUpdaterSchema

	/// <exclude/>
	public class ISsoContactUpdaterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISsoContactUpdaterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISsoContactUpdaterSchema(ISsoContactUpdaterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("210deb1a-27cb-45b7-b65b-28f2254acf3b");
			Name = "ISsoContactUpdater";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc09773-c057-4470-b5fb-7fbb57d82a07");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,221,74,196,48,16,133,175,87,240,29,134,221,27,5,105,238,215,90,144,21,100,193,69,161,232,253,108,58,173,129,252,148,36,45,44,226,187,155,38,169,138,20,100,9,36,204,228,204,201,151,76,6,39,116,7,245,201,121,82,197,206,72,73,220,11,163,93,241,72,154,172,224,183,151,23,211,216,88,234,66,26,246,218,147,109,145,211,22,246,181,51,59,163,61,114,255,218,55,24,242,147,144,49,6,165,27,148,66,123,170,82,152,118,129,39,45,28,79,16,98,132,214,26,5,245,253,225,9,44,185,62,28,73,128,109,112,1,105,58,161,97,20,8,117,253,92,100,75,246,227,217,15,71,41,56,136,25,101,129,4,62,38,150,213,76,125,32,255,110,26,183,133,151,88,26,247,254,128,174,254,35,45,123,180,168,44,181,160,81,209,221,58,139,222,80,14,228,214,172,42,102,207,95,164,41,17,11,65,47,84,85,153,26,198,24,23,37,139,218,169,114,52,162,201,60,89,116,245,32,98,107,130,117,233,188,13,109,187,129,180,86,51,113,178,189,142,61,59,251,130,113,138,143,170,81,6,103,99,177,163,197,91,45,176,229,51,55,164,155,244,230,83,248,25,127,206,119,234,11,83,109,243,230,107,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("210deb1a-27cb-45b7-b65b-28f2254acf3b"));
		}

		#endregion

	}

	#endregion

}

