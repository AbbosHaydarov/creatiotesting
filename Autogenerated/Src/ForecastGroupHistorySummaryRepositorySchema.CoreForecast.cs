﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastGroupHistorySummaryRepositorySchema

	/// <exclude/>
	public class ForecastGroupHistorySummaryRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastGroupHistorySummaryRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastGroupHistorySummaryRepositorySchema(ForecastGroupHistorySummaryRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("042bcfd7-febb-6900-e0cf-dd5c420f98fd");
			Name = "ForecastGroupHistorySummaryRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,88,221,111,219,54,16,127,118,129,254,15,156,55,160,50,106,40,88,31,155,56,65,146,38,153,135,180,9,146,174,123,24,134,130,181,104,91,152,76,185,36,149,197,8,252,191,239,142,31,18,69,73,182,18,96,125,72,12,145,247,125,63,30,239,200,233,138,201,53,157,49,242,153,9,65,101,62,87,241,121,206,231,233,162,16,84,165,57,143,47,115,193,102,84,170,47,239,94,191,122,122,253,106,80,200,148,47,200,253,70,42,182,58,12,190,129,53,203,216,12,249,100,124,197,56,19,233,172,65,243,129,42,218,88,188,78,249,247,106,209,183,101,181,202,121,251,142,96,93,235,241,135,179,206,173,11,174,82,149,50,217,73,112,73,103,42,23,134,2,104,126,22,108,1,254,144,243,140,74,249,158,184,112,92,137,188,88,255,150,74,32,221,220,23,171,21,21,155,59,182,206,101,138,11,154,241,224,224,128,28,73,179,117,108,191,111,69,254,144,38,76,146,21,83,203,60,145,100,158,11,252,211,34,201,2,101,146,165,17,74,44,107,236,68,29,120,178,254,250,192,230,180,200,212,89,202,19,112,33,82,155,53,203,231,209,212,89,215,176,232,203,187,209,152,124,130,100,147,9,25,90,179,181,11,195,209,223,32,111,93,124,203,210,25,153,161,143,253,92,36,85,40,186,163,48,0,192,192,255,48,134,119,108,206,4,227,51,6,112,41,86,28,1,97,232,214,34,87,0,31,150,88,75,90,9,7,40,117,48,112,54,75,37,48,137,37,233,253,108,201,86,20,93,61,205,82,42,201,19,89,48,117,72,36,254,219,238,98,52,58,116,140,246,241,84,58,158,65,218,207,28,99,197,45,85,203,38,233,214,70,147,241,196,4,180,30,221,203,148,101,9,132,247,86,164,15,84,49,23,82,253,65,4,163,73,206,179,141,211,243,85,131,205,243,25,112,113,206,178,236,142,205,114,145,76,147,225,225,110,101,80,36,64,82,129,71,5,85,106,31,172,70,227,79,47,20,69,127,72,38,64,20,55,69,131,20,181,207,49,153,222,66,9,201,19,15,118,235,96,97,172,99,88,2,223,56,228,209,207,130,133,145,166,127,79,190,81,201,162,80,93,67,120,147,29,178,178,39,13,112,198,65,14,150,152,142,84,232,10,180,49,192,48,246,134,32,12,83,239,115,95,67,40,143,90,14,198,113,40,68,226,42,82,59,105,91,200,49,103,255,118,75,136,70,135,125,117,253,150,50,65,197,108,185,217,163,20,116,234,128,63,79,175,197,232,53,36,52,160,55,81,235,56,74,142,61,229,138,104,146,91,193,230,233,227,148,39,236,177,45,164,93,25,252,104,138,115,71,250,30,242,52,33,167,73,82,134,224,50,205,20,19,145,249,49,151,39,153,123,31,99,114,207,240,86,4,221,248,3,16,210,33,241,73,226,82,216,9,94,184,23,116,182,140,150,110,105,10,23,36,153,28,91,182,193,3,21,164,220,11,203,203,132,92,49,40,200,181,93,189,131,129,62,219,84,213,165,46,62,174,54,48,23,168,38,157,147,232,170,72,147,248,98,181,86,155,248,226,123,65,51,25,112,125,161,89,193,70,206,161,193,192,56,24,159,242,36,234,178,112,76,134,80,92,70,241,84,126,42,178,76,103,30,57,183,132,101,146,189,64,144,101,24,128,64,109,98,100,60,137,111,169,0,74,204,75,171,201,78,173,254,217,154,207,109,43,8,251,198,211,146,151,218,188,136,90,183,48,113,166,158,32,51,164,106,239,33,138,255,92,194,122,244,8,201,127,244,82,68,38,147,86,61,241,101,42,164,114,49,21,76,21,130,123,26,227,32,130,109,78,59,112,95,179,185,250,61,79,185,115,17,249,163,238,114,80,41,65,154,46,192,67,141,6,96,147,8,3,33,130,138,151,242,64,72,137,42,139,5,180,232,166,128,132,162,89,81,192,238,185,54,138,79,229,142,109,237,185,67,77,124,211,148,212,213,72,140,73,39,101,117,139,150,130,29,26,247,24,98,65,108,18,230,223,241,251,43,48,224,50,64,75,27,28,189,91,62,132,162,96,18,58,200,94,119,2,102,193,200,147,85,231,51,9,47,156,48,116,49,146,213,184,203,104,52,203,86,37,184,198,49,135,34,225,3,159,12,135,102,63,112,44,190,95,103,169,138,222,196,111,70,101,1,53,120,50,182,150,213,179,33,48,186,215,154,108,65,186,17,186,220,69,117,50,40,113,39,196,19,247,158,252,50,124,170,147,108,227,167,138,96,107,141,28,152,24,199,112,160,34,139,12,72,91,75,152,93,234,144,25,49,227,133,67,227,174,51,114,174,67,49,148,161,213,22,87,245,130,96,108,106,59,252,45,134,145,190,246,134,240,48,125,153,183,213,237,129,37,240,29,105,205,190,3,175,223,63,89,141,83,104,70,41,200,110,1,165,79,253,145,114,186,96,2,70,83,229,56,206,54,218,135,202,112,27,172,150,38,205,208,216,15,135,88,39,199,150,103,28,123,149,149,89,57,212,118,134,28,240,1,73,190,224,214,67,180,253,250,20,246,51,111,223,58,144,213,142,228,94,81,135,237,231,191,37,199,81,89,129,219,70,164,137,127,30,222,234,50,54,14,168,155,135,188,19,3,134,179,171,42,248,52,181,179,91,199,71,67,74,173,172,152,163,224,78,194,158,58,84,221,143,221,167,166,71,247,104,167,217,112,184,205,31,224,197,1,158,1,200,103,250,45,99,56,117,225,180,180,42,191,46,69,190,50,248,139,166,152,137,59,152,221,24,38,12,127,96,40,186,224,197,10,110,127,160,62,50,243,209,177,157,92,228,148,207,243,90,187,225,77,116,58,254,40,1,33,106,162,166,155,161,35,236,242,142,163,112,32,180,152,117,82,128,27,71,166,184,203,80,103,156,111,136,145,128,220,177,103,132,111,83,189,83,129,141,122,89,106,4,76,183,39,250,97,9,234,149,61,113,166,215,136,106,45,7,116,32,75,198,224,11,255,143,9,122,72,36,167,107,185,204,213,52,49,64,233,236,215,93,0,181,191,237,202,156,22,43,223,19,93,151,100,79,168,233,96,140,136,104,247,84,227,250,99,104,98,218,51,210,51,56,152,26,200,213,143,9,78,93,217,142,224,96,169,169,137,182,21,198,192,120,10,15,98,112,168,253,185,168,220,168,221,100,173,45,97,159,110,68,199,181,23,161,177,11,27,196,175,246,65,14,1,111,83,20,188,124,225,142,126,15,161,92,73,123,225,52,122,194,178,37,236,163,190,214,23,118,181,227,93,83,195,216,245,221,187,217,247,78,31,117,57,61,113,167,39,150,255,19,120,230,234,194,242,209,0,139,171,42,242,36,254,156,163,7,112,133,157,156,84,253,173,41,116,54,44,53,0,7,86,63,239,120,227,164,108,45,194,46,50,87,166,133,172,230,98,159,224,60,47,224,117,226,152,252,218,58,53,143,226,155,53,227,103,89,62,251,167,95,157,168,198,95,222,152,124,101,169,212,142,145,216,6,63,146,159,224,141,160,156,235,71,229,40,28,88,201,21,77,185,244,94,0,188,49,223,89,124,35,122,22,179,96,216,183,99,119,85,24,179,92,50,227,116,199,123,192,243,109,195,104,190,208,184,186,234,23,8,220,145,138,81,24,3,251,2,225,78,106,248,168,84,127,71,122,193,121,212,207,175,103,155,31,118,21,52,244,189,232,170,180,82,250,5,124,79,56,172,195,231,208,161,192,53,14,165,186,236,24,118,185,78,246,186,29,190,217,78,140,40,236,174,204,21,16,16,4,111,221,214,225,206,167,31,0,195,29,229,11,22,237,25,244,107,21,80,199,173,57,1,238,121,72,109,12,77,149,21,200,9,85,169,237,229,232,217,15,152,175,53,224,247,63,122,149,158,27,6,28,153,119,5,160,243,33,211,121,111,219,75,13,211,38,10,122,225,178,189,229,55,171,245,69,189,246,31,188,122,134,147,86,29,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("042bcfd7-febb-6900-e0cf-dd5c420f98fd"));
		}

		#endregion

	}

	#endregion

}

