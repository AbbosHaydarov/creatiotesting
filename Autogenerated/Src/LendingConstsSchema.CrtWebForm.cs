namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LendingConstsSchema

	/// <exclude/>
	public class LendingConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LendingConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LendingConstsSchema(LendingConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d6b4cef-d71c-4217-89fd-d792efa796f2");
			Name = "LendingConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa93560d-2a86-466f-a9e4-295d1f97bfe2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,201,106,195,48,16,134,207,9,228,29,134,248,210,30,20,59,174,188,117,3,71,177,67,161,244,146,190,128,106,43,198,96,203,65,146,91,76,233,187,87,94,18,236,230,80,90,157,102,249,231,159,15,49,156,150,76,30,105,194,224,149,9,65,101,117,80,43,82,241,67,158,213,130,170,188,226,240,185,152,207,106,153,243,12,246,141,84,172,188,91,204,117,197,16,44,107,187,164,160,82,222,194,51,227,169,150,232,73,169,100,39,48,77,19,238,101,93,150,84,52,143,67,110,12,239,28,140,99,152,214,47,132,198,234,228,106,142,108,143,245,91,145,39,32,149,134,77,32,105,105,166,48,45,191,214,93,240,76,128,70,20,232,20,158,135,198,235,126,236,19,140,166,21,47,26,216,213,121,10,97,162,242,119,54,108,223,107,5,123,74,225,1,56,251,232,250,87,203,120,19,217,129,187,198,136,88,54,65,24,187,17,10,137,79,80,228,197,174,77,176,31,4,17,89,94,247,31,252,39,224,255,51,191,84,244,55,106,11,135,91,219,89,251,8,91,126,132,176,19,123,200,15,92,15,221,184,177,189,37,193,102,27,135,78,71,61,251,234,79,67,91,245,215,209,166,186,246,13,24,187,185,177,100,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d6b4cef-d71c-4217-89fd-d792efa796f2"));
		}

		#endregion

	}

	#endregion

}

