﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringExcelCellWriterSchema

	/// <exclude/>
	public class StringExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringExcelCellWriterSchema(StringExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("052444f1-9b26-428f-bf14-859460e74a8d");
			Name = "StringExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,86,93,111,211,48,20,125,238,164,253,7,83,94,82,169,164,3,36,64,108,171,52,74,25,147,134,54,109,229,67,2,30,220,228,174,53,114,236,96,223,108,173,208,254,59,215,177,221,165,77,59,196,67,218,230,250,158,251,113,124,174,93,197,11,176,37,207,128,77,192,24,110,245,13,166,35,173,110,196,172,50,28,133,86,233,120,81,106,131,19,61,94,100,32,247,247,254,236,239,117,42,43,212,140,93,47,45,66,65,222,82,66,230,92,109,122,10,10,140,200,14,55,125,206,133,250,221,50,78,96,129,233,21,204,42,201,13,37,49,96,173,11,210,242,251,86,200,7,219,123,157,85,5,40,252,160,77,193,49,189,40,65,173,173,55,187,40,10,173,104,133,214,158,26,152,81,108,54,146,220,218,183,236,26,13,249,214,13,141,64,202,175,70,32,152,218,113,48,24,176,35,91,21,5,55,203,97,120,247,222,12,156,59,163,71,178,187,26,144,70,255,65,3,80,86,83,41,50,150,185,68,219,243,176,183,236,29,183,208,202,222,33,102,233,115,85,235,165,209,37,24,20,64,5,211,111,36,142,33,247,46,101,124,101,214,215,22,104,152,44,75,152,240,217,9,146,117,90,33,176,227,33,235,98,247,240,113,148,175,210,97,215,129,228,213,134,10,133,236,19,95,184,194,71,115,110,56,25,141,29,233,138,204,132,121,249,226,245,171,215,1,243,20,84,238,91,233,116,30,233,172,230,203,173,186,135,232,60,18,106,78,26,194,92,103,108,224,24,141,148,234,91,218,90,145,3,91,49,231,53,208,122,167,58,54,76,169,111,177,85,216,122,89,159,0,231,58,175,217,22,183,28,161,81,212,154,38,106,195,21,20,84,16,155,195,130,231,144,137,130,75,102,151,197,84,75,235,100,209,214,133,183,148,196,88,193,20,205,220,113,23,23,216,29,94,65,41,121,230,4,205,144,198,129,221,9,156,111,13,122,52,168,177,15,161,12,96,101,148,29,78,34,76,87,184,3,25,93,253,78,214,189,69,9,248,54,62,62,192,174,61,42,9,235,84,100,143,185,145,239,116,130,165,228,72,91,174,216,49,235,126,255,177,56,56,120,70,31,111,232,121,71,207,136,158,49,25,158,127,248,233,148,67,32,159,154,210,204,96,145,250,102,33,161,160,253,24,167,31,42,73,199,69,137,203,190,247,188,40,253,113,66,35,92,10,9,121,175,14,118,31,55,100,107,15,103,234,150,75,145,147,158,157,46,183,53,128,102,25,126,117,156,151,86,36,40,76,191,144,216,110,150,43,152,243,247,165,199,218,201,226,13,247,44,227,152,205,99,140,91,110,88,157,178,6,18,31,228,152,126,37,237,66,210,8,127,102,67,232,94,58,209,39,116,54,45,147,141,248,10,238,66,39,201,67,184,224,115,191,214,119,83,184,193,210,150,238,218,65,177,125,158,86,195,188,26,169,64,150,159,150,47,92,86,144,232,233,47,114,114,29,86,16,25,20,55,44,121,226,170,172,128,9,27,81,254,171,70,245,162,103,167,97,36,106,106,8,17,224,231,48,50,80,55,182,225,249,15,65,250,44,135,91,128,62,244,103,20,82,184,147,37,13,27,240,17,233,88,212,151,146,11,229,38,229,159,97,30,19,83,19,229,168,104,88,211,115,80,51,26,221,225,142,195,113,7,47,205,8,215,213,52,200,224,160,191,43,74,147,183,32,159,70,136,56,37,255,179,243,103,99,69,247,169,225,83,9,71,225,62,88,221,2,67,118,10,184,105,180,73,236,197,13,0,29,228,235,171,212,212,148,110,55,250,39,176,13,73,18,56,23,22,163,0,90,232,244,36,207,19,55,16,155,216,100,199,13,215,103,170,146,178,255,200,85,214,11,185,2,93,173,148,77,210,54,110,6,111,93,155,186,253,189,251,191,86,226,192,159,50,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("052444f1-9b26-428f-bf14-859460e74a8d"));
		}

		#endregion

	}

	#endregion

}

