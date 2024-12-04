namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpperExpressionConverterSchema

	/// <exclude/>
	public class UpperExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpperExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpperExpressionConverterSchema(UpperExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("610a8b86-38e8-423a-9fde-cc03471e6042");
			Name = "UpperExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("75f7d434-56de-4d62-8a8c-9fe090e3ebb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,77,139,219,48,16,61,59,144,255,48,168,23,155,46,118,115,205,238,186,44,33,133,64,191,32,187,167,210,131,98,79,28,21,91,54,35,41,109,40,251,223,59,150,108,147,108,210,139,132,222,204,123,51,79,51,90,54,104,58,89,32,60,35,145,52,237,222,166,171,86,239,85,229,72,90,213,234,249,236,239,124,22,57,163,116,5,219,147,177,216,220,207,103,140,188,35,172,56,12,171,90,26,179,132,151,174,67,90,255,233,8,141,97,152,37,142,72,22,201,231,102,89,6,15,198,53,141,164,83,62,188,61,1,10,105,16,140,165,94,29,39,54,20,35,29,138,94,62,29,53,178,51,145,31,55,170,61,89,150,218,57,139,177,240,250,34,249,201,153,157,219,213,170,8,82,255,109,20,150,176,185,5,51,159,63,128,207,201,241,23,180,135,182,100,207,223,189,110,8,190,181,232,129,65,197,140,14,143,178,118,216,155,185,118,19,144,78,146,108,64,243,76,30,133,79,22,249,246,156,250,144,249,140,219,4,73,149,107,80,91,35,114,120,42,75,213,79,79,214,48,193,215,108,66,235,72,155,124,116,91,94,52,10,182,5,55,77,137,217,99,122,207,31,254,116,200,95,247,4,201,223,222,238,126,97,97,3,255,110,140,78,29,192,35,8,145,64,191,80,81,52,4,249,98,56,14,175,196,19,239,125,92,237,71,52,221,152,175,174,174,191,209,186,233,236,169,7,147,81,36,10,61,1,99,129,245,26,180,127,43,91,28,32,158,42,79,249,126,225,196,39,69,198,174,14,146,196,178,31,240,165,80,186,117,187,80,56,254,112,7,139,36,125,110,253,210,108,244,81,146,146,218,198,9,188,247,189,165,159,81,87,246,0,57,44,224,227,27,234,34,225,141,98,183,161,173,168,196,189,116,181,189,85,238,90,254,204,10,31,126,247,80,151,97,253,252,59,160,151,224,235,63,198,180,205,214,203,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("610a8b86-38e8-423a-9fde-cc03471e6042"));
		}

		#endregion

	}

	#endregion

}

