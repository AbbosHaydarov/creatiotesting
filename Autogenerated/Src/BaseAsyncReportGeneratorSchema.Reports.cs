﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAsyncReportGeneratorSchema

	/// <exclude/>
	public class BaseAsyncReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAsyncReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAsyncReportGeneratorSchema(BaseAsyncReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("52bb6fa5-1309-457e-afd9-b2f8dcb16569");
			Name = "BaseAsyncReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,85,77,111,226,48,16,61,83,169,255,193,162,123,0,9,133,123,11,72,45,187,173,144,118,87,171,66,127,128,73,6,106,53,56,89,219,161,139,42,254,251,142,63,66,236,144,0,221,195,94,104,51,30,191,121,51,111,102,204,233,6,100,78,99,32,11,16,130,202,108,165,162,105,198,87,108,93,8,170,88,198,175,175,62,174,175,58,133,100,124,77,230,59,169,96,115,119,248,126,100,41,160,243,22,132,2,17,77,83,6,92,181,156,234,143,111,127,20,112,137,152,100,220,120,53,210,198,234,190,79,72,180,216,61,162,209,51,228,153,80,115,16,91,22,183,194,68,143,52,86,153,96,32,79,167,17,45,168,124,67,23,116,186,17,176,214,164,167,41,149,242,150,60,80,9,247,114,199,99,27,239,9,56,32,129,76,24,223,225,112,72,70,178,216,108,168,216,77,220,55,250,9,144,136,41,9,37,75,188,77,232,82,42,129,60,52,106,182,66,171,48,80,100,109,177,180,121,85,112,115,78,83,166,118,196,242,140,45,71,34,109,138,81,25,111,232,5,204,139,101,202,226,67,4,18,107,210,173,156,201,45,153,53,218,17,9,101,199,223,67,246,191,68,150,99,112,44,220,173,254,95,65,172,32,177,46,245,164,141,225,9,48,95,245,10,68,102,133,192,246,114,41,174,176,214,4,202,70,208,41,28,231,208,201,75,252,42,143,246,102,138,194,214,154,155,112,161,237,3,43,171,238,200,254,18,186,138,10,116,254,111,116,23,38,220,191,211,101,92,42,202,177,190,166,143,52,14,57,196,69,241,77,43,159,99,189,101,66,21,52,37,179,128,181,157,131,48,19,103,27,79,236,48,216,89,218,69,200,102,212,116,121,210,235,219,17,234,220,0,79,108,35,133,93,245,3,212,107,150,92,220,82,166,61,65,150,234,44,97,133,35,141,243,192,19,61,31,42,107,26,145,134,212,141,37,167,130,110,8,199,253,55,238,22,232,143,220,57,50,64,86,221,201,72,2,144,88,192,106,220,125,9,143,134,147,104,52,52,87,155,145,98,127,37,117,39,207,193,96,227,96,5,231,199,80,2,84,33,184,196,123,230,111,121,17,69,114,41,39,84,209,136,120,252,108,132,175,104,182,220,74,132,150,198,172,220,177,228,128,209,193,90,122,97,158,184,113,252,207,1,169,45,136,96,243,134,73,125,66,114,182,197,212,236,105,110,63,8,210,212,82,98,71,217,136,63,177,170,61,143,180,45,67,159,232,71,169,211,217,82,225,44,186,251,180,47,62,45,214,16,77,105,174,233,220,53,56,250,15,81,195,0,70,139,108,110,104,244,250,248,239,247,236,29,132,105,100,196,177,213,37,95,186,31,97,216,125,228,25,14,64,251,174,185,181,15,83,124,42,88,66,230,184,103,92,138,118,104,180,191,126,115,142,147,29,148,69,137,105,154,46,105,252,246,34,82,191,0,184,0,234,32,207,240,187,0,137,131,74,56,188,219,88,213,120,214,156,122,6,168,227,129,15,172,197,213,81,51,113,150,134,221,234,78,26,170,232,42,166,25,198,65,220,250,235,239,61,184,81,11,85,243,70,245,218,19,109,141,53,75,48,90,104,210,219,234,254,157,50,140,140,250,154,70,147,69,170,106,10,215,97,124,33,207,119,182,121,132,189,77,198,248,43,8,166,146,44,118,83,219,248,234,90,50,158,9,65,45,57,28,109,211,65,246,113,47,247,117,179,111,53,59,245,147,94,221,108,212,80,248,227,183,147,211,17,235,140,66,170,19,130,105,155,166,92,105,239,238,60,236,42,205,52,186,145,118,150,120,34,217,214,114,238,8,127,28,243,50,149,116,119,183,228,106,2,87,59,100,16,198,180,48,251,207,75,228,205,109,88,199,203,36,50,229,108,197,56,183,132,155,24,157,218,196,71,91,18,75,29,110,253,122,132,163,77,222,241,175,187,5,27,46,103,183,145,79,78,96,251,182,43,87,92,248,46,78,189,77,119,86,112,131,83,15,90,234,173,41,6,98,215,134,215,90,67,35,218,254,2,20,139,176,201,23,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52bb6fa5-1309-457e-afd9-b2f8dcb16569"));
		}

		#endregion

	}

	#endregion

}

