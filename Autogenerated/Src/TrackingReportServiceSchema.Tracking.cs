﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TrackingReportServiceSchema

	/// <exclude/>
	public class TrackingReportServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TrackingReportServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TrackingReportServiceSchema(TrackingReportServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b5fb204-338d-431a-890a-e9af7ad86c56");
			Name = "TrackingReportService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,75,79,227,48,16,190,35,241,31,70,112,1,169,74,239,60,86,130,242,16,171,101,139,104,17,7,180,7,55,153,20,139,196,206,218,78,81,133,248,239,59,118,156,146,164,161,15,30,218,93,237,246,128,200,120,30,223,124,51,158,177,96,41,234,140,133,8,67,84,138,105,25,155,160,39,69,204,199,185,98,134,75,17,12,21,11,31,184,24,111,110,60,109,110,0,253,114,77,95,48,152,106,131,233,254,188,40,24,160,154,240,16,47,101,132,201,178,243,224,40,52,124,226,2,45,85,189,197,81,155,14,137,73,79,107,114,49,48,204,96,155,78,79,38,9,82,36,41,116,112,142,2,21,15,107,106,47,185,91,111,61,153,166,14,79,161,178,173,112,76,150,208,75,152,214,123,80,242,113,141,153,84,198,35,44,117,187,221,46,28,232,60,77,153,154,126,121,17,57,83,48,18,30,165,122,128,71,110,238,65,57,115,208,133,125,80,49,239,214,237,239,124,8,170,138,161,208,230,135,23,31,233,236,59,26,194,154,17,125,35,158,112,51,189,198,159,57,87,152,162,48,122,167,250,97,9,132,67,88,98,98,181,2,47,136,118,125,156,44,31,37,60,132,208,101,208,154,59,236,193,49,211,232,191,58,112,113,141,44,234,139,100,90,173,74,225,140,58,168,248,167,133,215,211,9,97,56,67,140,44,2,212,166,170,218,66,107,41,246,218,112,50,236,67,44,21,140,209,104,8,137,43,162,10,98,114,231,169,125,141,222,185,28,231,113,148,106,190,255,155,248,175,148,204,80,25,142,148,196,149,243,84,133,190,0,254,172,59,60,90,30,81,100,30,115,84,46,147,199,123,169,209,230,211,76,99,81,42,149,116,206,115,30,193,41,121,52,211,139,8,158,172,167,125,234,55,250,243,188,38,192,126,28,147,29,200,152,186,214,113,130,145,195,68,159,161,84,145,94,31,155,54,202,222,59,239,248,61,216,122,50,23,31,10,141,147,187,194,233,66,88,219,40,162,162,1,170,39,53,181,118,149,215,219,94,103,52,159,102,163,100,65,238,86,124,66,211,68,121,147,15,111,252,18,201,103,119,126,181,177,126,123,39,217,212,223,142,227,226,84,228,41,42,54,74,240,160,194,164,245,246,165,160,86,191,179,207,169,178,92,104,160,85,69,213,166,173,173,217,24,105,72,160,0,91,5,183,67,33,23,58,15,67,58,139,243,36,153,82,59,164,89,130,116,39,222,204,235,169,141,118,233,131,173,124,33,222,112,29,46,209,220,203,168,181,145,22,78,127,147,43,81,239,123,136,149,76,33,99,138,158,54,6,85,181,150,175,229,125,215,47,25,108,108,89,119,72,111,130,11,49,145,15,184,83,128,164,77,186,117,213,31,12,183,58,112,163,248,16,137,99,218,112,86,122,110,183,171,67,98,171,79,231,199,50,154,14,204,52,177,167,228,198,19,57,147,6,183,138,101,25,70,157,58,149,126,243,156,73,149,50,83,179,44,68,193,87,45,69,7,202,123,186,88,175,92,228,149,218,206,221,116,168,3,223,105,238,64,199,171,255,127,183,57,13,38,76,1,90,131,19,102,24,141,132,9,237,49,69,104,4,62,22,145,170,242,157,27,122,241,80,40,81,60,199,118,247,87,240,229,145,157,216,203,196,140,124,213,247,32,188,199,148,205,212,26,161,58,243,142,155,209,187,221,149,226,207,88,59,92,174,27,52,152,173,16,25,148,187,185,81,253,2,73,85,177,24,110,157,106,21,2,183,162,154,9,40,119,29,94,216,105,159,230,246,215,168,161,11,89,191,236,43,36,87,186,14,170,134,243,217,188,12,250,117,124,250,164,91,113,22,227,116,45,132,206,164,238,236,121,191,49,169,214,26,57,9,189,114,255,128,121,243,141,96,252,125,195,166,68,253,143,78,26,106,139,79,153,52,51,90,87,25,51,4,2,106,35,229,255,152,169,211,243,89,99,166,252,152,127,16,205,142,235,71,207,191,0,154,147,139,130,166,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b5fb204-338d-431a-890a-e9af7ad86c56"));
		}

		#endregion

	}

	#endregion

}

