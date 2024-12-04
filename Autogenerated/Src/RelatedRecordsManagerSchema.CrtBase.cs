﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RelatedRecordsManagerSchema

	/// <exclude/>
	public class RelatedRecordsManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RelatedRecordsManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RelatedRecordsManagerSchema(RelatedRecordsManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("79e42f7f-72ab-478b-8c68-883244204648");
			Name = "RelatedRecordsManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,88,75,111,227,54,16,62,59,64,254,195,32,123,177,1,67,190,39,177,23,187,78,187,200,33,197,54,217,246,82,244,192,149,198,14,1,139,84,73,202,133,17,228,191,151,15,217,166,40,82,182,54,187,69,123,137,35,105,30,223,124,243,224,72,140,148,40,43,146,35,124,65,33,136,228,43,149,45,57,91,209,117,45,136,162,156,101,143,184,33,10,139,71,204,185,40,228,229,197,203,229,197,168,150,148,173,225,105,39,21,150,90,124,179,193,220,200,202,236,19,50,20,52,191,57,200,248,86,5,166,238,103,63,49,69,21,69,153,20,248,153,228,138,11,39,161,101,222,9,92,107,135,112,207,20,138,149,134,127,13,247,109,160,15,132,145,53,10,43,61,155,205,224,86,214,101,73,196,110,209,92,31,52,129,175,64,56,85,253,107,117,161,116,202,217,94,119,230,41,87,245,215,13,205,129,30,244,83,142,71,154,41,253,247,128,245,1,213,51,47,228,53,124,182,22,220,195,16,154,189,241,161,208,24,2,76,6,75,23,140,187,83,17,65,74,96,58,149,243,171,6,250,29,81,228,106,113,43,17,33,23,184,154,95,69,65,90,169,217,2,86,92,0,41,10,195,123,232,246,118,102,173,31,157,9,84,181,96,114,177,228,53,83,134,188,74,240,28,165,108,233,236,133,140,150,102,202,68,212,6,48,78,226,217,147,111,254,159,220,244,176,244,136,37,223,226,191,206,147,48,110,127,28,83,46,170,183,144,245,14,89,225,74,206,94,191,186,134,105,223,220,215,228,114,67,164,174,200,97,173,243,56,160,91,254,184,195,21,169,55,234,35,101,166,188,198,106,87,33,95,141,227,61,51,153,194,47,58,57,48,183,57,210,98,113,169,201,159,199,54,204,77,0,113,252,112,125,118,107,126,22,188,66,97,6,144,238,78,65,183,90,199,9,84,238,34,52,164,229,183,180,208,46,18,183,95,96,141,234,6,164,249,227,248,15,19,144,112,205,149,158,164,88,244,84,253,111,82,219,207,57,99,110,228,38,202,189,218,91,178,242,203,131,120,120,57,0,168,214,146,74,212,102,12,7,51,172,73,69,148,235,113,224,176,110,93,78,147,196,138,232,237,9,152,211,103,52,82,207,84,102,129,229,121,96,251,230,40,153,240,49,79,120,177,154,39,216,56,14,243,88,185,116,198,221,222,180,237,217,165,64,253,168,35,99,158,157,217,233,13,13,91,34,224,43,145,193,180,48,136,246,174,230,141,179,143,17,169,35,162,113,48,69,26,211,164,55,10,221,164,248,119,127,164,227,94,112,141,167,39,84,205,140,248,157,108,106,148,95,120,191,205,94,84,211,112,32,106,7,110,194,246,71,227,167,124,159,196,216,36,142,228,49,38,246,159,74,101,19,191,201,214,169,144,206,73,88,192,82,63,156,243,48,91,152,131,233,42,9,101,141,244,83,254,140,37,249,181,70,177,211,60,125,66,245,112,124,102,87,203,157,39,145,168,246,246,44,232,88,108,195,59,199,168,199,251,9,146,92,76,35,15,116,219,125,60,210,169,211,106,219,109,43,38,99,106,235,222,179,142,235,230,28,246,162,202,250,133,27,139,199,103,250,181,160,46,89,196,78,76,36,22,75,210,64,66,202,154,120,29,56,188,79,31,184,58,247,102,197,161,236,176,239,160,77,62,72,27,59,252,101,248,252,145,91,103,122,177,244,12,116,10,210,172,171,122,229,244,129,7,219,230,113,71,216,82,161,106,178,129,142,145,147,173,52,168,105,155,134,136,215,130,95,157,126,14,211,57,9,95,218,254,79,105,233,190,59,124,67,102,78,141,164,183,38,39,57,89,78,230,71,159,233,18,10,119,170,195,214,28,235,160,56,120,188,244,30,241,134,220,51,19,87,249,106,139,33,14,58,217,251,174,245,208,205,224,150,211,2,134,238,58,54,51,253,203,164,207,192,20,6,165,220,87,205,90,184,130,129,219,126,246,254,189,61,211,238,168,93,179,117,106,110,245,123,129,126,183,155,130,251,93,140,39,195,134,112,248,57,132,178,103,253,17,73,21,60,135,153,99,243,240,201,229,155,63,36,120,123,67,103,17,108,173,87,241,181,60,121,186,199,51,147,117,97,70,189,182,136,58,25,251,27,62,13,192,139,183,231,196,247,213,3,3,201,133,118,40,9,81,188,41,247,125,53,19,251,132,241,122,121,241,15,49,162,27,46,188,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79e42f7f-72ab-478b-8c68-883244204648"));
		}

		#endregion

	}

	#endregion

}

