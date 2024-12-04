﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StartTrackingPostProcessSchema

	/// <exclude/>
	public class StartTrackingPostProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StartTrackingPostProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StartTrackingPostProcessSchema(StartTrackingPostProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9cc3ee2-57f1-42fa-b232-c437fbafc33c");
			Name = "StartTrackingPostProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,86,221,83,155,64,16,127,198,25,255,135,43,125,40,153,58,228,189,141,233,68,205,116,156,106,141,18,219,231,147,108,226,85,56,240,62,108,153,234,255,222,61,14,8,71,136,198,250,194,192,178,251,219,175,223,237,45,167,41,200,156,198,64,230,32,4,149,217,82,133,199,25,95,178,149,22,84,177,140,135,145,162,66,205,5,141,239,24,95,205,50,169,102,34,139,65,202,253,189,191,251,123,158,150,40,37,81,33,21,164,159,59,223,8,148,36,16,27,20,25,126,5,14,130,197,27,58,103,140,223,111,8,35,16,15,44,134,243,108,1,73,248,19,110,214,10,237,40,5,108,147,187,41,108,213,154,114,197,20,3,217,175,208,46,194,244,1,120,83,132,43,144,58,81,187,26,21,57,180,170,134,86,104,247,94,192,10,53,200,113,66,165,252,68,182,151,24,117,115,125,147,176,152,72,133,160,49,137,141,197,51,6,30,54,5,159,141,135,115,80,183,217,2,125,204,74,24,251,115,56,28,146,145,212,105,74,69,49,174,5,37,38,1,19,51,81,21,116,216,104,15,187,234,163,156,10,154,18,142,252,57,244,181,4,129,185,115,219,108,127,124,237,124,135,163,97,169,220,111,75,115,246,13,10,127,60,201,25,185,131,98,83,89,128,210,130,203,177,45,59,137,145,20,168,84,75,141,154,91,34,134,9,56,5,10,220,112,136,27,237,1,218,9,211,70,27,200,128,24,90,123,222,3,21,149,228,10,238,53,72,69,14,9,135,223,100,210,150,5,3,195,2,207,171,16,202,226,213,94,207,178,21,227,104,132,148,142,64,41,148,152,67,160,126,208,68,67,208,9,161,4,241,252,233,134,189,63,8,231,89,84,162,63,231,107,134,164,248,157,137,197,27,220,213,16,61,30,219,144,248,114,2,203,94,84,226,2,218,66,249,7,117,93,183,71,143,7,124,146,231,215,34,121,67,248,13,134,19,63,249,72,252,33,226,233,188,214,251,178,204,68,74,213,225,47,137,60,117,66,186,201,211,87,135,112,148,167,78,20,213,220,234,134,209,245,51,209,234,22,75,242,106,95,149,93,15,54,91,146,192,226,135,167,242,187,78,146,11,49,77,115,85,4,54,171,1,121,124,36,219,254,87,168,131,154,249,158,61,90,36,192,131,52,232,25,124,225,58,232,83,89,162,216,24,158,154,115,83,143,143,147,44,165,140,79,163,203,234,236,148,243,182,136,226,91,72,233,165,6,81,116,82,13,219,10,231,148,211,21,8,164,213,220,129,243,171,148,141,35,51,65,240,146,209,169,57,104,27,94,195,201,98,97,255,6,254,119,212,108,91,186,202,235,139,170,23,7,59,99,35,91,235,117,34,175,144,157,129,17,186,113,159,177,114,134,108,115,140,39,203,188,5,12,239,63,114,56,38,182,21,230,203,184,183,105,88,122,172,147,14,77,86,109,50,152,119,227,167,77,139,119,47,5,21,78,120,17,236,222,125,107,216,211,121,215,15,50,228,136,74,22,27,118,5,155,131,241,160,127,128,245,214,17,161,170,87,123,155,5,254,236,34,154,251,189,186,118,234,96,157,173,184,79,101,125,144,80,109,205,255,45,170,118,38,216,99,84,21,21,239,23,97,239,162,218,77,173,63,253,3,177,86,224,230,219,140,166,237,77,137,116,108,174,239,157,123,112,161,110,65,76,133,200,68,187,1,125,251,134,41,94,35,239,39,109,229,204,166,84,138,158,170,29,2,248,194,174,17,229,183,149,118,132,157,77,198,185,29,219,235,139,221,91,156,223,228,19,65,134,0,166,164,142,19,134,33,142,48,221,241,230,10,131,153,228,32,204,158,182,195,22,131,141,250,144,241,132,113,48,173,41,23,138,254,29,166,217,25,202,161,92,209,198,150,127,5,182,12,158,4,167,30,47,57,148,120,90,137,22,201,78,30,43,106,189,205,35,69,234,238,156,99,139,247,255,225,181,102,32,89,148,231,95,62,239,210,204,149,145,245,59,110,76,91,115,240,249,0,118,32,222,211,63,179,117,246,191,185,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9cc3ee2-57f1-42fa-b232-c437fbafc33c"));
		}

		#endregion

	}

	#endregion

}

