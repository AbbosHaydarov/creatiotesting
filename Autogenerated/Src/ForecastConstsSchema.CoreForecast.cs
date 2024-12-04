﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastConstsSchema

	/// <exclude/>
	public class ForecastConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastConstsSchema(ForecastConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ddba69f-54ab-463d-85d0-bc0e3119f357");
			Name = "ForecastConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0db428d0-fc38-40d1-af3f-5cbb75ee95a9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,91,111,155,48,24,125,94,164,252,7,148,167,237,193,19,24,8,70,83,31,192,151,169,210,218,77,75,178,119,7,220,212,147,49,17,54,218,162,105,255,125,134,132,46,205,165,163,147,144,140,191,203,57,246,249,142,220,26,169,55,222,98,103,172,168,62,76,39,211,137,230,149,48,91,94,8,111,41,154,134,155,250,193,190,199,181,126,144,155,182,225,86,214,122,58,249,53,157,188,217,182,107,37,11,207,88,23,43,188,66,113,99,60,86,55,162,224,198,186,114,99,141,43,234,10,79,42,27,193,203,90,171,157,39,181,245,238,248,207,47,162,145,117,105,112,221,186,253,141,7,163,254,16,87,187,62,182,178,124,226,161,218,74,187,91,20,143,162,226,171,219,210,181,107,241,163,47,121,59,203,179,48,77,253,20,129,44,134,62,136,178,32,7,105,150,67,0,41,78,104,134,72,154,224,116,246,238,101,50,99,155,78,156,213,182,228,86,12,164,102,89,111,93,209,141,55,59,137,207,70,129,61,105,196,85,177,176,188,177,162,188,19,198,240,141,232,32,47,100,95,7,187,120,20,194,30,35,245,129,113,24,159,14,196,173,234,231,76,220,229,150,178,234,207,117,37,53,14,247,158,239,65,186,117,92,199,222,20,203,221,182,239,251,187,187,125,165,26,123,131,28,203,177,143,252,31,206,173,198,66,169,11,104,125,124,53,22,116,33,172,237,86,135,115,248,157,141,240,252,231,245,119,81,216,111,92,181,2,215,170,173,244,94,143,103,158,143,32,97,243,40,164,32,195,17,2,17,157,39,0,177,4,129,24,146,0,229,148,98,22,248,255,242,124,79,70,75,105,249,90,93,103,66,113,230,83,66,48,240,231,161,99,194,36,6,121,64,34,144,48,200,16,100,52,14,34,54,138,201,41,89,57,83,93,37,10,242,200,15,130,4,2,18,96,234,136,146,24,160,56,244,1,142,97,2,243,52,15,33,34,167,68,69,247,252,12,106,95,212,237,254,224,200,163,228,201,12,158,97,156,203,49,0,12,153,151,186,207,174,56,52,31,18,99,166,207,164,230,186,16,95,107,117,54,9,66,40,138,253,28,132,73,74,220,204,99,31,164,41,197,32,159,99,28,5,25,99,144,132,131,64,191,167,19,247,253,1,78,242,215,128,242,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ddba69f-54ab-463d-85d0-bc0e3119f357"));
		}

		#endregion

	}

	#endregion

}

