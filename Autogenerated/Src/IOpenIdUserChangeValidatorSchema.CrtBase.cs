namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOpenIdUserChangeValidatorSchema

	/// <exclude/>
	public class IOpenIdUserChangeValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOpenIdUserChangeValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOpenIdUserChangeValidatorSchema(IOpenIdUserChangeValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb3ab0c1-6714-4491-9345-efbe56bcf524");
			Name = "IOpenIdUserChangeValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,77,75,195,64,16,61,183,224,127,24,234,69,161,52,119,173,129,18,60,244,32,130,88,239,147,236,36,25,76,102,195,126,168,65,250,223,221,77,140,181,90,61,44,153,44,243,222,188,247,118,4,91,178,29,22,4,143,100,12,90,93,186,85,166,165,228,202,27,116,172,101,117,223,145,108,213,198,187,250,108,254,126,54,159,121,203,82,29,117,27,186,254,227,126,117,43,142,29,147,13,13,161,229,220,80,21,40,97,43,142,76,25,134,94,193,118,164,223,89,50,89,141,82,209,19,54,172,208,105,51,32,58,159,55,92,0,79,128,127,251,103,81,222,44,73,18,88,91,223,182,104,250,116,186,200,106,42,158,45,112,9,244,198,214,69,165,62,80,64,129,2,57,65,171,21,151,76,234,11,159,252,36,88,119,104,176,5,9,113,221,44,34,52,132,36,84,196,132,22,233,161,6,167,33,168,193,28,45,173,147,1,115,154,194,246,118,163,90,150,157,176,187,251,156,190,72,167,10,40,230,214,131,46,33,58,253,197,100,200,121,35,54,125,24,191,224,140,167,104,238,148,39,64,81,96,241,37,84,223,196,45,65,187,154,204,43,91,130,145,13,74,108,162,232,137,59,14,203,181,110,32,67,25,163,142,82,46,134,228,15,126,143,163,88,194,240,224,61,156,178,119,25,183,100,31,78,220,4,18,53,46,195,240,191,255,0,132,168,138,87,135,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb3ab0c1-6714-4491-9345-efbe56bcf524"));
		}

		#endregion

	}

	#endregion

}

