﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportEngineServiceSchema

	/// <exclude/>
	public class ReportEngineServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportEngineServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportEngineServiceSchema(ReportEngineServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91106b62-dfb2-27a6-b997-c2a8feac87b2");
			Name = "ReportEngineService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a721d4de-7c48-45cc-b19d-676727a40f20");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,87,221,111,26,57,16,127,166,82,255,135,17,125,56,144,170,229,61,13,72,9,87,34,78,77,19,1,213,61,68,85,101,118,7,98,221,174,119,99,123,169,184,170,255,251,141,237,253,254,32,161,57,169,47,32,143,231,211,51,243,155,89,193,34,84,9,243,17,54,40,37,83,241,78,123,243,88,236,248,62,149,76,243,88,188,125,243,227,237,155,65,170,184,216,195,250,168,52,70,31,26,103,111,149,10,205,35,244,214,40,57,11,249,191,86,174,197,69,183,7,238,227,109,28,96,120,242,210,187,242,53,63,60,175,196,251,27,183,37,67,213,125,137,125,116,111,193,124,29,75,142,170,139,131,20,18,87,20,117,24,158,199,97,136,228,87,44,148,119,131,130,34,245,91,60,159,184,120,34,34,145,223,73,220,19,43,204,67,166,212,5,172,48,137,165,94,138,93,188,36,62,203,49,153,76,224,82,165,81,196,228,113,150,157,29,27,112,226,3,78,140,224,27,113,47,231,158,84,216,31,254,100,154,81,158,180,164,120,190,18,33,73,183,33,247,157,68,166,104,131,81,18,50,141,165,221,1,165,146,126,11,247,238,101,156,160,212,244,26,23,112,111,21,184,251,166,115,53,239,2,164,108,239,56,74,227,88,219,51,231,218,45,70,91,148,163,207,84,93,48,133,33,15,134,99,227,101,238,230,77,202,3,88,6,240,3,246,168,63,128,50,63,63,159,183,237,179,196,100,224,12,195,153,68,221,186,210,210,100,109,238,238,206,117,66,31,19,60,195,3,195,94,55,159,101,135,232,96,127,94,106,223,106,140,119,160,31,17,164,243,197,164,66,31,65,249,143,24,177,51,156,114,114,107,43,102,104,157,239,243,177,193,212,229,232,59,20,129,43,166,122,101,221,162,126,140,131,151,148,213,92,34,213,168,2,6,2,191,83,237,43,205,132,95,196,121,169,16,193,151,184,155,14,187,139,122,56,153,1,19,1,9,114,109,193,135,84,113,253,135,130,196,213,246,17,14,44,76,137,248,157,235,71,163,178,112,36,97,146,69,164,25,4,197,54,29,202,150,122,82,221,214,211,243,200,165,198,126,117,179,43,113,42,190,101,59,64,19,156,45,183,203,137,213,93,154,146,168,83,41,212,108,89,132,29,252,218,219,101,234,115,125,181,42,32,8,46,170,181,33,10,11,25,71,37,172,141,58,156,207,106,180,74,26,131,153,37,131,129,179,102,19,222,163,222,241,13,8,34,166,29,122,188,101,240,222,49,228,61,220,201,149,93,102,172,182,215,58,249,204,77,198,212,170,249,78,129,38,151,149,253,105,230,193,160,187,47,28,181,65,108,12,137,27,212,238,49,212,138,38,50,205,25,236,29,20,196,154,185,165,232,223,49,255,242,176,40,236,230,33,22,246,225,2,106,171,64,54,124,75,247,94,53,79,202,137,218,0,53,51,255,212,25,96,86,79,144,170,99,217,39,174,244,101,119,145,205,26,197,167,206,1,56,122,24,130,201,212,44,19,47,9,182,236,211,23,32,93,127,70,76,199,230,64,214,131,96,38,58,69,124,185,101,194,175,3,205,236,224,60,224,114,90,102,27,50,19,210,11,246,195,85,1,83,180,178,20,49,54,67,52,46,87,236,151,88,150,175,3,189,1,27,96,97,193,157,8,143,54,145,29,48,51,131,138,199,57,192,52,19,59,173,50,209,18,105,10,111,212,93,21,94,29,217,198,222,38,54,166,71,227,87,182,183,83,185,224,33,82,151,248,168,204,226,152,53,212,115,11,225,142,132,76,30,51,41,170,79,43,214,221,235,153,206,106,187,63,92,169,228,51,106,218,108,19,234,227,45,15,9,188,86,248,148,114,137,17,109,2,138,94,162,60,152,213,154,222,235,25,17,195,229,101,132,96,220,179,128,126,20,123,46,48,115,136,192,228,154,169,252,212,198,142,5,199,208,46,12,210,236,254,238,77,6,137,59,80,246,88,16,83,17,192,178,170,25,190,201,202,201,230,231,119,181,108,71,192,197,116,237,110,188,218,50,88,19,28,229,85,92,11,143,114,98,43,201,125,192,28,233,35,164,104,7,199,48,171,151,232,239,136,169,5,38,41,149,42,61,187,112,56,63,156,125,161,51,248,5,161,182,215,156,120,144,47,53,53,80,215,58,182,111,117,1,91,170,174,81,227,234,255,120,200,215,175,184,43,183,92,1,59,48,30,178,45,53,115,54,188,79,61,99,190,145,93,181,132,234,219,218,195,29,141,92,59,158,171,45,63,120,160,111,217,165,56,196,255,224,200,57,106,38,229,253,221,122,51,124,79,254,60,209,38,171,23,177,140,152,38,58,177,222,18,180,176,61,58,146,247,151,162,173,9,174,227,224,184,214,71,178,92,101,41,168,222,53,147,217,218,148,163,245,105,141,227,218,23,96,255,214,209,190,42,58,226,192,100,99,31,51,216,94,75,175,201,103,75,220,230,179,186,118,158,152,56,13,253,231,226,62,85,205,127,209,62,139,79,84,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91106b62-dfb2-27a6-b997-c2a8feac87b2"));
		}

		#endregion

	}

	#endregion

}

