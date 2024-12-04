namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActualLicenseInfoSchema

	/// <exclude/>
	public class ActualLicenseInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActualLicenseInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActualLicenseInfoSchema(ActualLicenseInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8f2556a-7b31-4323-98aa-de2f37e95af2");
			Name = "ActualLicenseInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,193,106,195,48,12,134,207,11,244,29,4,189,55,247,109,12,74,118,25,236,144,67,95,64,113,148,76,144,200,193,150,11,91,233,187,207,177,151,208,110,99,108,187,24,36,253,255,207,135,100,193,145,252,132,134,224,64,206,161,183,157,238,42,43,29,247,193,161,178,149,77,113,218,20,155,226,102,235,168,143,37,84,3,122,127,11,123,163,1,7,126,163,54,170,91,206,202,40,43,203,18,238,125,24,71,116,175,15,31,117,178,128,177,162,200,226,129,165,179,110,76,225,128,141,13,10,104,148,143,148,21,70,97,96,67,226,105,183,196,149,23,121,83,104,226,24,76,138,204,16,207,89,254,20,99,163,32,211,174,184,181,179,19,57,101,138,204,117,242,230,249,103,206,212,56,188,16,72,24,27,114,96,59,152,144,219,133,105,166,6,141,227,11,182,175,112,11,29,139,66,29,221,85,54,87,54,196,198,9,122,210,59,240,243,115,254,53,196,245,106,254,142,177,79,254,127,131,180,168,52,99,196,117,175,119,129,35,14,129,252,140,150,190,64,186,228,207,36,94,29,75,191,126,154,228,120,156,163,191,97,217,146,180,249,120,169,206,221,235,230,249,29,157,197,33,64,182,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8f2556a-7b31-4323-98aa-de2f37e95af2"));
		}

		#endregion

	}

	#endregion

}

