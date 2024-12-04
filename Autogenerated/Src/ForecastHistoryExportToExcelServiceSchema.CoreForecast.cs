﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHistoryExportToExcelServiceSchema

	/// <exclude/>
	public class ForecastHistoryExportToExcelServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHistoryExportToExcelServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHistoryExportToExcelServiceSchema(ForecastHistoryExportToExcelServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b9a6113-1660-45d2-8131-c707ea7d4a0a");
			Name = "ForecastHistoryExportToExcelService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,88,91,111,219,54,20,126,214,128,253,7,194,123,145,1,67,6,246,152,216,14,210,56,233,188,181,105,102,103,125,41,138,129,145,142,109,174,178,228,146,84,28,175,240,127,223,225,77,162,110,110,6,244,37,9,15,207,141,31,15,191,115,148,140,238,64,236,105,12,228,17,56,167,34,95,203,232,38,207,214,108,83,112,42,89,158,69,119,57,135,152,10,249,241,87,242,237,231,159,130,66,176,108,67,86,71,33,97,119,217,88,163,101,154,66,172,204,68,244,22,50,224,44,110,233,188,99,217,215,74,120,15,7,137,218,42,236,239,34,207,170,13,63,157,221,174,111,199,79,244,246,101,159,115,249,152,223,190,196,144,118,171,115,232,147,71,183,153,100,146,129,232,85,184,163,177,204,121,143,198,125,193,162,21,240,103,22,195,251,60,129,52,154,83,73,49,61,201,209,170,50,64,137,144,130,76,191,11,246,135,167,127,16,199,143,52,45,96,9,113,206,19,109,73,51,233,69,87,33,180,198,227,113,15,53,159,103,179,137,106,118,149,187,59,150,74,224,255,211,87,101,132,142,208,213,47,28,54,120,14,114,147,82,33,172,75,115,66,189,61,30,143,201,68,20,187,29,229,199,153,93,27,37,146,160,91,18,215,192,112,6,99,207,98,95,60,165,44,38,123,202,37,163,41,137,91,113,84,145,162,94,43,148,137,101,225,197,64,105,177,203,72,76,247,42,146,14,174,194,181,227,185,128,206,242,55,38,176,10,142,10,4,139,138,42,122,244,117,99,92,169,141,79,159,73,75,70,190,145,13,200,75,34,212,143,19,65,207,39,3,24,100,137,193,172,141,223,69,51,106,173,194,109,248,94,92,237,62,89,231,156,128,54,84,183,188,118,8,36,156,165,105,146,31,204,225,137,204,81,9,189,118,130,254,105,14,107,90,164,242,13,203,18,116,18,74,188,239,124,29,46,92,122,93,121,13,71,228,30,185,5,107,105,96,179,31,12,63,87,23,104,47,238,251,231,35,23,228,108,28,119,223,37,114,234,161,240,66,189,213,210,125,47,110,61,183,219,165,31,254,37,116,137,101,134,223,72,81,91,14,53,55,6,65,93,26,221,108,33,254,114,205,55,197,14,50,121,95,164,105,152,33,38,8,93,195,122,168,158,97,16,52,66,76,27,65,180,146,41,155,102,221,148,199,191,99,144,38,88,57,15,156,61,83,233,78,105,22,164,19,191,191,161,67,122,121,62,202,3,207,247,128,5,5,125,145,26,39,105,44,107,111,225,21,41,118,10,167,250,121,6,157,233,147,171,43,18,118,239,76,205,219,50,108,126,196,46,37,39,93,238,103,161,190,148,115,32,188,7,185,205,123,177,54,156,36,8,6,88,129,106,138,127,22,192,143,86,26,46,110,51,172,9,78,159,82,152,188,45,88,50,35,92,211,188,88,36,174,148,158,41,39,107,235,100,74,50,56,148,46,205,126,80,35,236,106,17,45,50,179,24,25,53,108,159,200,150,12,155,107,77,181,46,142,110,191,22,52,181,22,239,96,173,158,12,7,33,76,25,170,224,111,168,0,79,104,115,8,42,145,245,174,251,232,113,21,111,97,71,245,145,235,26,145,217,49,252,104,227,5,102,245,64,229,86,209,197,34,25,24,249,201,238,47,217,102,235,37,164,224,40,209,138,12,184,161,17,44,18,44,139,31,154,238,3,229,248,98,43,52,131,82,96,113,169,214,46,70,208,108,204,181,117,164,174,219,57,11,180,184,60,207,34,177,114,124,20,250,215,48,122,204,175,177,19,31,195,161,150,156,12,79,112,144,5,207,92,117,248,180,224,170,111,206,244,75,67,254,158,32,27,34,103,143,136,87,133,6,239,89,163,54,141,116,129,51,154,8,107,29,117,237,45,252,234,140,43,3,11,198,171,194,134,150,237,148,11,129,15,111,206,120,73,120,126,168,104,133,155,230,207,171,200,83,154,146,15,60,1,94,74,86,24,9,71,145,107,17,227,67,197,152,6,187,171,134,86,115,255,162,185,63,7,167,96,210,83,157,146,198,91,18,86,71,37,44,171,103,216,106,243,14,158,192,195,38,186,78,146,208,172,35,213,18,71,26,170,22,46,97,105,27,88,135,136,135,53,179,2,87,54,245,204,207,193,230,191,172,210,155,238,203,87,13,236,91,120,220,231,25,184,128,45,54,48,126,43,177,151,252,143,161,132,58,39,120,137,55,95,136,185,172,147,255,46,60,236,95,211,50,43,30,215,195,192,153,241,241,6,43,66,130,32,52,75,200,129,51,245,167,30,154,8,22,59,208,157,26,162,210,60,198,177,84,77,17,116,3,90,209,38,101,154,17,249,2,199,158,65,83,75,144,146,209,143,26,18,166,3,255,82,7,179,254,49,121,50,214,86,221,78,242,230,135,132,24,204,204,199,5,121,214,220,99,153,116,68,14,91,134,213,126,192,169,144,60,129,77,23,146,182,119,115,30,49,155,8,0,18,115,88,79,7,181,6,186,196,239,73,36,105,24,140,103,70,142,33,140,4,125,57,99,111,246,234,52,86,212,84,219,248,3,142,253,164,52,34,126,63,109,125,59,205,72,27,5,87,175,181,97,96,9,106,194,157,44,150,176,207,5,83,162,201,74,221,36,122,93,233,27,54,149,60,67,86,211,203,37,36,76,84,202,43,136,11,172,138,227,92,133,160,40,169,81,157,169,74,199,148,173,231,143,109,157,56,42,237,231,229,58,21,159,46,73,199,168,208,61,113,180,33,112,173,243,69,245,204,151,8,39,15,159,152,43,15,237,140,221,91,95,230,185,52,143,215,142,250,230,251,182,252,138,181,227,52,94,136,23,183,50,40,7,20,7,140,133,200,202,221,184,227,232,77,116,180,192,174,209,45,122,224,128,53,171,218,63,238,133,234,223,10,152,215,51,206,171,234,67,22,191,26,217,191,96,106,36,244,78,105,15,223,205,21,93,223,106,40,251,15,204,175,34,47,61,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b9a6113-1660-45d2-8131-c707ea7d4a0a"));
		}

		#endregion

	}

	#endregion

}

