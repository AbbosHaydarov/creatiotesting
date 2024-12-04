namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialAccountInfoSchema

	/// <exclude/>
	public class SocialAccountInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialAccountInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialAccountInfoSchema(SocialAccountInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f043ea0-5608-4609-9088-37f2047f71ad");
			Name = "SocialAccountInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,77,107,131,64,16,134,207,6,242,31,150,244,146,92,252,1,45,61,148,20,74,160,45,161,218,83,201,97,93,71,89,208,93,217,143,67,90,252,239,29,119,108,27,63,74,240,34,238,187,239,188,51,62,163,226,53,216,134,11,96,41,24,195,173,46,92,188,215,170,144,165,55,220,73,173,226,68,11,201,171,245,234,107,189,138,188,149,170,100,201,217,58,168,239,70,231,248,205,43,39,107,136,19,48,88,32,63,67,57,186,208,119,99,160,196,3,219,87,220,218,91,70,145,15,66,104,44,57,168,66,7,211,199,35,119,28,123,59,195,133,59,161,208,248,172,146,130,137,174,104,174,38,194,145,240,249,151,174,149,117,198,11,167,13,54,57,134,106,114,244,73,147,140,237,64,97,246,242,180,99,221,23,71,209,179,46,165,98,247,195,203,56,168,29,130,40,162,70,19,7,201,100,161,54,135,124,98,250,185,32,91,122,110,96,198,68,50,89,222,45,152,25,11,201,193,210,246,80,64,229,196,101,8,233,104,116,3,198,73,24,33,10,244,95,160,206,192,108,95,241,167,192,22,27,31,82,55,187,211,5,195,39,47,115,214,79,65,128,74,112,52,155,237,95,218,255,19,171,14,219,48,16,87,214,253,68,132,121,121,162,11,112,102,102,76,9,230,242,68,34,59,206,236,199,252,221,228,242,92,105,137,247,48,55,211,186,234,23,113,37,115,180,81,82,135,98,251,13,2,177,164,113,207,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f043ea0-5608-4609-9088-37f2047f71ad"));
		}

		#endregion

	}

	#endregion

}

