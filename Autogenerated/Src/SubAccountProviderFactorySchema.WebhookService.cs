﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SubAccountProviderFactorySchema

	/// <exclude/>
	public class SubAccountProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SubAccountProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SubAccountProviderFactorySchema(SubAccountProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ce0fb0a-b3be-453f-b442-807c2fb7c87c");
			Name = "SubAccountProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,85,239,107,219,48,16,253,156,66,255,135,91,58,138,3,155,253,189,75,2,165,107,75,160,101,133,118,244,227,80,148,115,34,166,72,222,73,106,26,74,254,247,73,150,146,216,249,209,49,6,243,39,251,116,119,239,244,222,179,164,216,28,77,197,56,194,19,18,49,163,75,155,95,105,85,138,169,35,102,133,86,249,29,83,19,161,166,98,164,44,78,99,236,244,228,237,244,164,227,140,15,195,227,210,88,156,127,217,249,246,61,164,68,30,146,77,126,139,10,73,240,189,156,59,161,126,109,131,77,124,194,252,134,113,171,73,160,241,25,62,231,140,112,234,155,193,149,100,198,92,192,232,209,141,47,57,215,78,217,7,210,47,98,130,20,11,150,117,118,81,20,208,55,110,62,103,180,28,166,239,167,25,66,25,115,160,212,4,198,141,129,197,22,80,165,30,38,95,23,23,141,234,202,141,165,224,32,60,1,228,59,224,187,232,157,64,205,222,0,117,224,22,173,1,235,199,88,224,120,166,245,207,61,248,128,190,15,31,35,21,35,54,7,229,229,26,116,83,253,163,118,196,177,59,124,106,180,52,117,44,239,23,117,254,182,156,208,58,82,166,149,187,11,223,47,214,89,161,108,244,28,211,118,54,26,118,113,120,37,51,150,130,144,173,233,62,193,88,107,9,156,169,239,6,191,98,201,156,220,182,26,120,65,164,193,94,48,193,42,8,7,254,57,67,53,137,98,111,34,109,237,223,149,62,228,215,27,22,106,230,77,103,39,154,3,39,44,7,221,227,162,117,139,97,44,76,66,243,128,115,28,6,46,254,104,128,192,223,122,234,27,129,114,226,199,126,32,241,194,44,198,197,42,126,192,232,90,185,57,18,27,75,236,31,33,124,8,63,54,246,140,255,66,167,77,209,22,202,151,84,72,214,255,52,255,2,183,126,51,80,91,185,51,69,155,222,58,162,132,108,59,13,124,24,128,114,82,194,249,121,99,198,252,82,45,179,94,111,93,210,137,158,106,111,34,196,189,224,7,151,189,43,106,161,19,161,254,244,176,151,82,30,29,55,171,221,147,218,173,222,231,231,30,237,76,215,90,212,66,199,197,191,117,75,24,232,240,44,181,143,60,217,209,69,255,241,255,73,92,31,67,172,182,249,27,109,243,27,65,198,126,163,212,50,123,133,193,16,94,243,231,38,182,9,55,129,101,66,153,172,53,83,47,81,30,220,176,233,157,188,176,209,61,233,186,94,111,136,228,235,178,131,251,217,173,189,146,109,27,100,118,89,161,46,179,195,219,244,150,99,230,24,235,77,248,23,70,224,239,26,77,247,104,12,155,162,167,229,99,215,203,253,121,247,60,132,133,176,179,116,162,94,192,91,139,131,21,40,109,253,61,226,212,36,239,198,238,118,70,122,1,10,23,112,253,202,177,10,119,95,214,196,137,172,29,182,104,140,54,131,171,211,147,223,2,165,122,66,156,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ce0fb0a-b3be-453f-b442-807c2fb7c87c"));
		}

		#endregion

	}

	#endregion

}

